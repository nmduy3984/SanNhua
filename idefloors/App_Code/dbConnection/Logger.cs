using System;
using log4net;
using System.IO;

namespace dbConnection
{
    /// <summary>
    /// Utility class to support logging
    /// </summary>
    internal static class Logger
    {
        private static ILog m_log;

        /// <summary>
        /// Static constructor
        /// </summary>
        static Logger()
        {
            string configFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "App_Data\\log4net.config");
            log4net.Config.XmlConfigurator.Configure(new FileInfo(configFile));
        }

        /// <summary>
        /// Writes a log message in the log
        /// </summary>
        /// <param name="message">The message to write to log</param>
        /// <param name="messageType">The type of the log message to write</param>
        public static void Write(string message, LogMessageType messageType)
        {
            DoLog(message, messageType, null, Type.GetType("System.Object"));
        }

        /// <summary>
        /// Writes a log message in the log
        /// </summary>
        /// <param name="message">The message to write to log</param>
        /// <param name="messageType">The type of the log message to write</param>
        /// <param name="type">The object type for which to get the logger for writing the log</param>
        public static void Write(string message, LogMessageType messageType, Type type)
        {
            DoLog(message, messageType, null, type);
        }

        /// <summary>
        /// Writes a log message in the log
        /// </summary>
        /// <param name="message">The message to write to log</param>
        /// <param name="messageType">The type of the log message to write</param>
        /// <param name="ex">Exception to be logged</param>
        public static void Write(string message, LogMessageType messageType, Exception ex)
        {
            DoLog(message, messageType, ex, Type.GetType("System.Object"));
        }

        /// <summary>
        /// Writes a log message in the log
        /// </summary>
        /// <param name="message">The message to write to log</param>
        /// <param name="messageType">The type of the log message to write</param>
        /// <param name="ex">Exception to be logged</param>
        /// <param name="type">The object type for which to get the logger for writing the log</param>
        public static void Write(string message, LogMessageType messageType, Exception ex, Type type)
        {
            DoLog(message, messageType, ex, type);
        }

        /// <summary>
        /// Assertion is logged for given condition with the given message
        /// </summary>
        /// <param name="condition">The value condition evaluates to</param>
        /// <param name="message">The message to log</param>
        public static void Assert(bool condition, string message)
        {
            Assert(condition, message, Type.GetType("System.Object"));
        }

        /// <summary>
        /// Assertion is logged for given condition with the given message
        /// </summary>
        /// <param name="condition">The value condition evaluates to</param>
        /// <param name="message">The message to log</param>
        /// <param name="type">The object type for which to get the logger for writing the log</param>
        public static void Assert(bool condition, string message, Type type)
        {
            if (condition == false)
                Write(message, LogMessageType.Info);
        }

        /// <summary>
        /// Writes a log message in the log
        /// </summary>
        /// <param name="message">The message to write to log</param>
        /// <param name="messageType">The type of the log message to write</param>
        /// <param name="ex">Exception to be logged</param>
        /// <param name="type">The object type for which to get the logger for writing the log</param>
        private static void DoLog(string message, LogMessageType messageType, Exception ex, Type type)
        {
            m_log = LogManager.GetLogger(type);
            switch (messageType)
            {
                case LogMessageType.Debug:
                    Logger.m_log.Debug(message, ex);
                    break;

                case LogMessageType.Info:
                    Logger.m_log.Info(message, ex);
                    break;

                case LogMessageType.Warn:
                    Logger.m_log.Warn(message, ex);
                    break;

                case LogMessageType.Error:
                    Logger.m_log.Error(message, ex);
                    break;

                case LogMessageType.Fatal:
                    Logger.m_log.Fatal(message, ex);
                    break;
            }
        }

        /// <summary>
        /// Log a debug message
        /// </summary>
        /// <param name="message">The message to write to the log</param>
        public static void Debug(string message)
        {
            Write(message, LogMessageType.Debug);
        }

        /// <summary>
        /// Log a debug message
        /// </summary>
        /// <param name="message">The message to write to the log</param>
        /// <param name="ex">The exception to log</param>
        public static void Debug(string message, Exception ex)
        {
            Write(message, LogMessageType.Debug, ex);
        }

        /// <summary>
        /// Log an information message
        /// </summary>
        /// <param name="message">The message to write to the log</param>
        public static void Info(string message)
        {
            Write(message, LogMessageType.Info);
        }

        /// <summary>
        /// Log an information message
        /// </summary>
        /// <param name="message">The message to write to the log</param>
        /// <param name="ex">The exception to log</param>
        public static void Info(string message, Exception ex)
        {
            Write(message, LogMessageType.Info, ex);
        }

        /// <summary>
        /// Log a warning message
        /// </summary>
        /// <param name="message">The message to write to the log</param>
        public static void Warn(string message)
        {
            Write(message, LogMessageType.Warn);
        }

        /// <summary>
        /// Log a warning message
        /// </summary>
        /// <param name="message">The message to write to the log</param>
        /// <param name="ex">The exception to log</param>
        public static void Warn(string message, Exception ex)
        {
            Write(message, LogMessageType.Warn, ex);
        }

        /// <summary>
        /// Log an error message
        /// </summary>
        /// <param name="message">The message to write to the log</param>
        public static void Error(string message)
        {
            Write(message, LogMessageType.Error);
        }

        /// <summary>
        /// Log an error message
        /// </summary>
        /// <param name="message">The message to write to the log</param>
        /// <param name="ex">The exception to log</param>
        public static void Error(string message, Exception ex)
        {
            Write(message, LogMessageType.Error, ex);
        }

        /// <summary>
        /// Log a fatal error message
        /// </summary>
        /// <param name="message">The message to write to the log</param>
        public static void Fatal(string message)
        {
            Write(message, LogMessageType.Fatal);
        }

        /// <summary>
        /// Log a fatal error message
        /// </summary>
        /// <param name="message">The message to write to the log</param>
        /// <param name="ex">The exception to log</param>
        public static void Fatal(string message, Exception ex)
        {
            Write(message, LogMessageType.Fatal, ex);
        }

        /// <summary>
        /// Enumeration that represents the type of log message
        /// </summary>
        public enum LogMessageType
        {
            /// <summary>
            /// This is a debugging log
            /// </summary>
            Debug,

            /// <summary>
            /// This is information log
            /// </summary>
            Info,

            /// <summary>
            /// This is a warning log
            /// </summary>
            Warn,

            /// <summary>
            /// This is a error log
            /// </summary>
            Error,

            /// <summary>
            /// This is a fatal error log
            /// </summary>
            Fatal
        }
    }
}