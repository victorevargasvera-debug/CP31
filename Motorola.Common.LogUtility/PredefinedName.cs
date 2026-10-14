using System;
using System.Globalization;
using System.IO;
using System.Text.RegularExpressions;
using Motorola.Common.LogUtility.PerformanceMeasurement;

namespace Motorola.Common.LogUtility
{
	// Token: 0x02000018 RID: 24
	public class PredefinedName
	{
		// Token: 0x060000E4 RID: 228 RVA: 0x0000FAE0 File Offset: 0x0000DCE0
		// Note: this type is marked as 'beforefieldinit'.
		static PredefinedName()
		{
			int a_ = 18;
			short num = (short)448611805;
			short num2 = num;
			num = (short)1459570141;
			switch (num2 == num)
			{
			}
			num = (short)2083651584;
			if (num != 0)
			{
			}
			num = (short)637403137;
			if (num != 0)
			{
			}
			num = (short)1915551744;
			short num3 = num;
			global::Motorola.Common.LogUtility.PredefinedName.CommonCpsProgrammingDataFolder = global::System.IO.Path.Combine(global::System.Environment.GetFolderPath(global::System.Environment.SpecialFolder.CommonApplicationData), global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("⭥ݧṩͫᱭὯṱᕳ⩵㭷ᕹᅻ፽잃횅\udb87", a_));
			global::Motorola.Common.LogUtility.PredefinedName.Cps20LogFile = global::System.IO.Path.Combine(global::System.Environment.GetFolderPath(global::System.Environment.SpecialFolder.CommonApplicationData), global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("⭥ݧṩͫᱭὯṱᕳ⩵㭷ᕹᅻ፽잃횅\udb87횉쾋\ude8d쎏ꂑ몓ꚕ쒗劣躟횡\udca3튥", a_));
			global::Motorola.Common.LogUtility.PredefinedName.RegCps20Log = new global::System.Text.RegularExpressions.Regex(global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("乥㑧ࡩၫ㕭Ɐ╱⭳⭵卷卹㽻⹽퍿낁것\uda85힋튍잏춑즓붕놗", a_), global::System.Text.RegularExpressions.RegexOptions.IgnoreCase | global::System.Text.RegularExpressions.RegexOptions.Compiled);
			global::Motorola.Common.LogUtility.PredefinedName.RegPerformanceLogger = new global::System.Text.RegularExpressions.Regex(global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("乥㑧ࡩၫ㕭Ɐ╱⭳⭵卷卹呻⹽慎쮓\uda95ﶙﮛﮝ튟\udea1쎥\udaa7첩쎫\udcad\uddaf펱\udab3햵\uddb7욹톽ꞿꗁꇃ듅郋곍곏觑裓臕蟗蟙", a_), global::System.Text.RegularExpressions.RegexOptions.IgnoreCase | global::System.Text.RegularExpressions.RegexOptions.Compiled);
			global::Motorola.Common.LogUtility.PredefinedName.DefaultCulture = global::System.Globalization.CultureInfo.CreateSpecificCulture(global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("ͥ٧䝩㥫㵭", a_));
		}

		// Token: 0x04000063 RID: 99
		public const string PerformanceLogFileExtension = ".json";

		// Token: 0x04000064 RID: 100
		public const string AppSettings = "appSettings";

		// Token: 0x04000065 RID: 101
		public const string UnkownLogger = "Unknown_Logger";

		// Token: 0x04000066 RID: 102
		public const string PerformanceLogName = "Performance";

		// Token: 0x04000067 RID: 103
		public const string LoggerInLogName = "_Logger";

		// Token: 0x04000068 RID: 104
		public static readonly string CommonCpsProgrammingDataFolder;

		// Token: 0x04000069 RID: 105
		public static readonly string Cps20LogFile;

		// Token: 0x0400006A RID: 106
		public static readonly global::System.Text.RegularExpressions.Regex RegCps20Log;

		// Token: 0x0400006B RID: 107
		public static readonly global::System.Text.RegularExpressions.Regex RegPerformanceLogger;

		// Token: 0x0400006C RID: 108
		public static readonly global::System.Globalization.CultureInfo DefaultCulture;
	}
}
