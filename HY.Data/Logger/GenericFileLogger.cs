using HY.Common.ReturnValues;
using System;
using System.IO;

namespace HY.Data.Logger
{
    public class GenericFileLogger : ILogger
    {
        private static string LogFilePrefix = "HellYeah_";
        private static string ErrorSuffix = "Error";
        private static string InfoSuffix = "Info";
        private static string MessageSuffix = "Message";
        private static string WarningSuffix = "Warning";
        private static string fileExtension = ".txt";
        private string FilePath;

        public GenericFileLogger()
        {
            try
            {
                FilePath = Environment.CurrentDirectory;
            }
            catch (Exception)
            {
                FilePath = string.Empty;
            }
        }

        public HYReturn LogError(string message)
        {
            var fileName = LogFilePrefix + ErrorSuffix + fileExtension;
            return Write(Path.Combine(FilePath, fileName), message);
        }

        public HYReturn LogInformation(string message)
        {
            var fileName = LogFilePrefix + InfoSuffix + fileExtension;
            return Write(Path.Combine(FilePath, fileName), message);
        }

        public HYReturn LogMessage(string message)
        {
            var fileName = LogFilePrefix + MessageSuffix + fileExtension;
            return Write(Path.Combine(FilePath, fileName), message);
        }

        public HYReturn LogWarning(string message)
        {
            var fileName = LogFilePrefix + WarningSuffix + fileExtension;
            return Write(Path.Combine(FilePath, fileName), message);
        }

        private HYReturn Write(string path, string message)
        {
            try
            {
                string toWrite = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss") + ":  " + message + Environment.NewLine;
                File.AppendAllText(path, toWrite);
            }
            catch (Exception e)
            {
                return new ErrorReturn(e.ToString());
            }

            return new SuccessReturn();
        }
    }
}
