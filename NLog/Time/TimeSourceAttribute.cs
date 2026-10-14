using System;
using NLog.Config;

namespace NLog.Time
{
	// Token: 0x02000025 RID: 37
	[global::System.AttributeUsage(global::System.AttributeTargets.Class)]
	public sealed class TimeSourceAttribute : global::NLog.Config.NameBaseAttribute
	{
		// Token: 0x06000498 RID: 1176 RVA: 0x00009128 File Offset: 0x00007328
		public TimeSourceAttribute(string name) : base(name)
		{
		}
	}
}
