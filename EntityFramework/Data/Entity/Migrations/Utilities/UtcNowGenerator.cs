using System;
using System.Globalization;
using System.Threading;

namespace System.Data.Entity.Migrations.Utilities
{
	// Token: 0x020000A7 RID: 167
	internal static class UtcNowGenerator
	{
		// Token: 0x06000EEF RID: 3823 RVA: 0x0001EA0C File Offset: 0x0001CC0C
		public static global::System.DateTime UtcNow()
		{
			global::System.DateTime dateTime = global::System.DateTime.UtcNow;
			global::System.DateTime value = global::System.Data.Entity.Migrations.Utilities.UtcNowGenerator._lastNow.Value;
			if (dateTime <= value || dateTime.ToString("yyyyMMddHHmmssf", global::System.Globalization.CultureInfo.InvariantCulture).Equals(value.ToString("yyyyMMddHHmmssf", global::System.Globalization.CultureInfo.InvariantCulture), global::System.StringComparison.Ordinal))
			{
				dateTime = value.AddMilliseconds(100.0);
			}
			global::System.Data.Entity.Migrations.Utilities.UtcNowGenerator._lastNow.Value = dateTime;
			return dateTime;
		}

		// Token: 0x06000EF0 RID: 3824 RVA: 0x0001EA7C File Offset: 0x0001CC7C
		public static string UtcNowAsMigrationIdTimestamp()
		{
			return global::System.Data.Entity.Migrations.Utilities.UtcNowGenerator.UtcNow().ToString("yyyyMMddHHmmssf", global::System.Globalization.CultureInfo.InvariantCulture);
		}

		// Token: 0x0400083C RID: 2108
		public const string MigrationIdFormat = "yyyyMMddHHmmssf";

		// Token: 0x0400083D RID: 2109
		private static readonly global::System.Threading.ThreadLocal<global::System.DateTime> _lastNow = new global::System.Threading.ThreadLocal<global::System.DateTime>(() => global::System.DateTime.UtcNow);
	}
}
