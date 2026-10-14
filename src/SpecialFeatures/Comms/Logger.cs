namespace SpecialFeatures.Comms
{
    using System;
    using System.Runtime.CompilerServices;

    public class Logger
    {
        private static readonly string a;
        private static readonly string b;
        [CompilerGenerated]
        private static string c;

        static Logger();
        public Logger();
        public static void Log(string message);
        public static void LogWithDateTime(string message);

        internal static string ExcepitonMsg { get; set; }
    }
}

