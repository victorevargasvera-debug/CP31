using System;
using NLog.Config;

namespace NLog.LayoutRenderers
{
	// Token: 0x020000BE RID: 190
	[global::System.AttributeUsage(global::System.AttributeTargets.Class)]
	public sealed class LayoutRendererAttribute : global::NLog.Config.NameBaseAttribute
	{
		// Token: 0x06000B0E RID: 2830 RVA: 0x0001BEC2 File Offset: 0x0001A0C2
		public LayoutRendererAttribute(string name) : base(name)
		{
		}
	}
}
