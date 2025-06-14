using NLog;
using NLog.Config;
using NLog.Targets;

namespace WinFormsApp1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            // �������� ���� � ���������� bin\Debug\net8.0-windows\
            var baseDir = AppDomain.CurrentDomain.BaseDirectory;

            // ����������� �� ��� ������ �����: � ��������, ��� ��������� .sln
            var dirInfo = new DirectoryInfo(baseDir);
            var solutionDir = dirInfo.Parent?.Parent?.Parent?.FullName;

            // ��������, ��� �� null
            if (solutionDir == null)
                throw new DirectoryNotFoundException("�� ������� ����� ������ �������.");

            // ����� logs ����� � .sln
            var logFolderPath = Path.Combine(solutionDir, "logs");

            // ������ ����� logs, ���� � ���
            if (!Directory.Exists(logFolderPath))
                Directory.CreateDirectory(logFolderPath);

            // ��������� NLog
            var config = new LoggingConfiguration();

            var logfile = new FileTarget("logfile")
            {
                FileName = Path.Combine(logFolderPath, "${shortdate}.log"),
                Layout = "${longdate} | ${level:uppercase=true} | ${message} ${exception:format=ToString}",
                Encoding = System.Text.Encoding.UTF8
            };

            config.AddTarget(logfile);
            config.AddRuleForAllLevels(logfile);

            LogManager.Configuration = config;

            // ������ ����������
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}