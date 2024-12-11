using NengHuan.Forms;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
// 控制台输出，需加入此库
using System.Runtime.InteropServices;
using NengHuan.UI;
using System.IO;
using System.Threading;
using System.Diagnostics;
using System.Reflection;
namespace NengHuan
{
    internal static class Program
    {
        [DllImport("kernel32.dll")]
        public static extern bool AllocConsole();
        [DllImport("kernel32.dll")]
        static extern bool FreeConsole();

        private static int restartCount = 0; // 防止无限重启循环
        private const int maxRestarts = 5;   // 最大重启次数

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            // 注册未处理异常处理器
            AppDomain.CurrentDomain.UnhandledException += CurrentDomainOnUnhandledException;
            Application.ThreadException += Application_ThreadException;
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);

            try
            {
                // 允许调用控制台输出
                AllocConsole();
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new FMain());
                //Application.Run(new Test());
            }
            catch (Exception ex)
            {
                // 记录异常到日志文件
                LogException(ex);
            }
            finally
            {
                // 释放
                FreeConsole();
            }
        }
        private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            HandleException(e.Exception);
        }

        /// <summary>
        /// 处理未捕获的异常。
        /// </summary>
        private static void CurrentDomainOnUnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            Exception exception = (e.ExceptionObject as Exception) ?? new Exception("Unknown exception");
            LogException(exception);
        }

        /// <summary>
        /// 统一处理异常并尝试重启应用。
        /// </summary>
        private static void HandleException(Exception ex)
        {
            if (ex != null)
            {
                // 日志记录错误信息
                LogException(ex);

                // 尝试重启应用
                RestartApplication();
            }
        }

        /// <summary>
        /// 将异常信息写入日志文件。
        /// </summary>
        /// <param name="ex">异常对象</param>
        private static void LogException(Exception ex)
        {
            string logFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ErrorLog.txt");

            // 确保日志目录存在
            Directory.CreateDirectory(Path.GetDirectoryName(logFilePath));

            // 写入异常信息
            using (StreamWriter sw = File.AppendText(logFilePath))
            {
                sw.WriteLine($"Exception at {DateTime.Now}:");
                sw.WriteLine(ex.ToString());
                sw.WriteLine(new string('-', 50));
            }
        }

        /// <summary>
        /// 尝试重启应用程序。
        /// </summary>
        private static void RestartApplication()
        {
            if (++restartCount > maxRestarts)
            {
                MessageBox.Show("应用程序已达到最大重启次数，请检查日志文件以解决问题。", "频繁崩溃", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(1); // 超过最大重启次数则退出
                return;
            }

            try
            {
                string appName = Assembly.GetEntryAssembly().Location;

                // 显示一个简短的消息框给用户
                MessageBox.Show("应用程序将重新启动...", "应用程序崩溃", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // 使用 Timer 来延迟重启，以便用户有时间阅读消息
                System.Timers.Timer timer = new System.Timers.Timer(3000); // 3秒延迟
                timer.Elapsed += (sender, e) =>
                {
                    timer.Stop();
                    Process.Start(appName);
                };
                timer.Start();
            }
            catch (Exception restartEx)
            {
                Console.WriteLine($"Failed to restart application: {restartEx.Message}");
                MessageBox.Show($"Failed to restart application: {restartEx.Message}", "Restart Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Environment.Exit(1); // 确保当前实例完全退出
            }
        }
    }
}