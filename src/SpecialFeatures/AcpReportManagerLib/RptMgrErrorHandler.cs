namespace SpecialFeatures.AcpReportManagerLib
{
    using System;
    using System.Windows;

    public class RptMgrErrorHandler
    {
        public RptMgrErrorHandler();
        internal static string b(string A_0, int A_1);
        internal MessageBoxResult DisplayError(uint errorCode, string text, string caption);

        public enum ErrorCode : uint
        {
            public const RptMgrErrorHandler.ErrorCode FileDoesNotExist = 1;,
            public const RptMgrErrorHandler.ErrorCode FileCorrupted = 2;,
            public const RptMgrErrorHandler.ErrorCode emptyRptDataObject = 3;,
            public const RptMgrErrorHandler.ErrorCode genericError = 4;
        }
    }
}

