using System;
using NLog.Config;

namespace NLog.Filters
{
	// Token: 0x0200014E RID: 334
	[global::System.AttributeUsage(global::System.AttributeTargets.Class)]
	public sealed class FilterAttribute : global::NLog.Config.NameBaseAttribute
	{
		// Token: 0x06000EF5 RID: 3829 RVA: 0x00026125 File Offset: 0x00024325
		public FilterAttribute(string name) : base(name)
		{
		}
	}
}
