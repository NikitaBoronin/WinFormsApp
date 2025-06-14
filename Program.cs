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
            // Получаем путь к директории bin\Debug\net8.0-windows\
            var baseDir = AppDomain.CurrentDomain.BaseDirectory;

            // Поднимаемся на три уровня вверх: к каталогу, где находится .sln
            var dirInfo = new DirectoryInfo(baseDir);
            var solutionDir = dirInfo.Parent?.Parent?.Parent?.FullName;

            // Убедимся, что не null
            if (solutionDir == null)
                throw new DirectoryNotFoundException("Не удалось найти корень проекта.");

            // Папка logs рядом с .sln
            var logFolderPath = Path.Combine(solutionDir, "logs");

            // Создаём папку logs, если её нет
            if (!Directory.Exists(logFolderPath))
                Directory.CreateDirectory(logFolderPath);

            // Настройка NLog
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

            // Запуск приложения
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}