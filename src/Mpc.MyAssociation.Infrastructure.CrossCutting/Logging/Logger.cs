using System;

namespace Mpc.MyAssociation.Infrastructure.CrossCutting.Logging
{
    public class Logging : ILogger
    {
        public void Error(string message)
        {
        }

        public void Error(string message, Exception ex)
        {
        }

        public void Error(string message, Func<object> dataFunc)
        {
        }

        public void Fatal(string message)
        {
        }

        public void Fatal(string message, Func<object> dataFunc)
        {
        }

        public void Info(string message)
        {
        }

        public void Info(string message, Func<object> dataFunc)
        {
        }

        public void Verbose(string message)
        {
        }

        public void Verbose(string message, Func<object> dataFunc)
        {
        }

        public void Warning(string message)
        {
        }

        public void Warning(string message, Func<object> dataFunc)
        {
        }
    }
}
