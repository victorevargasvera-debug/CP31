using System;
using NLog.Config;

namespace NLog.Targets
{
	// Token: 0x02000051 RID: 81
	[global::System.AttributeUsage(global::System.AttributeTargets.Class)]
	public sealed class TargetAttribute : global::NLog.Config.NameBaseAttribute
	{
		// Token: 0x0600073B RID: 1851 RVA: 0x00012604 File Offset: 0x00010804
		public TargetAttribute(string name) : base(name)
		{
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x0600073C RID: 1852 RVA: 0x0001260D File Offset: 0x0001080D
		// (set) Token: 0x0600073D RID: 1853 RVA: 0x00012615 File Offset: 0x00010815
		public bool IsWrapper { get; set; }

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x0600073E RID: 1854 RVA: 0x0001261E File Offset: 0x0001081E
		// (set) Token: 0x0600073F RID: 1855 RVA: 0x00012626 File Offset: 0x00010826
		public bool IsCompound { get; set; }
	}
}
