using System;
using NLog.Config;
using NLog.Internal;

namespace NLog.Time
{
	// Token: 0x02000024 RID: 36
	[global::NLog.Config.NLogConfigurationItem]
	public abstract class TimeSource
	{
		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000491 RID: 1169
		public abstract global::System.DateTime Time { get; }

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000492 RID: 1170 RVA: 0x000090CB File Offset: 0x000072CB
		// (set) Token: 0x06000493 RID: 1171 RVA: 0x000090D2 File Offset: 0x000072D2
		public static global::NLog.Time.TimeSource Current
		{
			get
			{
				return global::NLog.Time.TimeSource.currentSource;
			}
			set
			{
				global::NLog.Time.TimeSource.currentSource = value;
			}
		}

		// Token: 0x06000494 RID: 1172 RVA: 0x000090DC File Offset: 0x000072DC
		public override string ToString()
		{
			global::NLog.Time.TimeSourceAttribute customAttribute = base.GetType().GetCustomAttribute<global::NLog.Time.TimeSourceAttribute>();
			if (customAttribute != null)
			{
				return customAttribute.Name + " (time source)";
			}
			return base.GetType().Name;
		}

		// Token: 0x06000495 RID: 1173
		public abstract global::System.DateTime FromSystemTime(global::System.DateTime systemTime);

		// Token: 0x0400004F RID: 79
		private static global::NLog.Time.TimeSource currentSource = new global::NLog.Time.FastLocalTimeSource();
	}
}
