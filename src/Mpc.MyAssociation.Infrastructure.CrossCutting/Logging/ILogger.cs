namespace Mpc.MyAssociation.Infrastructure.CrossCutting.Logging
{
    using System;

    public interface ILogger
    {
        void Error(string message);

        void Error(string message, Exception ex);

        void Error(string message, Func<object> dataFunc);

        void Fatal(string message);

        void Fatal(string message, Func<object> dataFunc);

        void Info(string message);

        void Info(string message, Func<object> dataFunc);

        void Verbose(string message);

        void Verbose(string message, Func<object> dataFunc);

        void Warning(string message);

        void Warning(string message, Func<object> dataFunc);
    }
}
