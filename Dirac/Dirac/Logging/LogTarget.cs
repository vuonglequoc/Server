﻿using System;

namespace Dirac.Logging
{
    /// <summary>
    /// Log target.
    /// </summary>
    public class LogTarget
    {
        /// <summary>
        /// Minimum level of messages to emit.
        /// </summary>
        public Logger.Level MinimumLevel { get; protected set; }

        /// <summary>
        /// Maximum level of messages to emit.
        /// </summary>
        public Logger.Level MaximumLevel { get; protected set; }

        /// <summary>
        /// Include timestamps in log?
        /// </summary>
        public bool IncludeTimeStamps { get; protected set; }

        /// <summary>
        /// Logs a message to log-target.
        /// </summary>
        /// <param name="level">Log level.</param>
        /// <param name="logger">Source of the log message.</param>
        /// <param name="message">Log message.</param>
        public virtual void LogMessage(Logger.Level level, string logger, string message)
        {
            throw new NotSupportedException("Vanilla log-targets are not supported! Instead use a log-target implementation.");
        }

        /// <summary>
        /// Logs a message and an exception to log-target.
        /// </summary>
        /// <param name="level">Log level.</param>
        /// <param name="logger">Source of the log message.</param>
        /// <param name="message">Log message.</param>
        /// <param name="exception">Exception to be included with log message.</param>
        public virtual void LogException(Logger.Level level, string logger, string message, Exception exception)
        {
            throw new NotSupportedException("Vanilla log-targets are not supported! Instead use a log-target implementation.");
        }
    }
}
