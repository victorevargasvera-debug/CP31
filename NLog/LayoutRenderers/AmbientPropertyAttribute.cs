using System;
using NLog.Config;

namespace NLog.LayoutRenderers
{
	// Token: 0x020000A6 RID: 166
	[global::System.AttributeUsage(global::System.AttributeTargets.Class, AllowMultiple = true)]
	public sealed class AmbientPropertyAttribute : global::NLog.Config.NameBaseAttribute
	{
		// Token: 0x06000A46 RID: 2630 RVA: 0x0001A6AD File Offset: 0x000188AD
		public AmbientPropertyAttribute(string name) : base(name)
		{
		}
	}
}
