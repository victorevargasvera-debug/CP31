using System;
using System.Diagnostics;
using System.Text;
using NLog.Config;

namespace NLog.LayoutRenderers
{
	// Token: 0x020000CE RID: 206
	[global::NLog.LayoutRenderers.LayoutRenderer("performancecounter")]
	public class PerformanceCounterLayoutRenderer : global::NLog.LayoutRenderers.LayoutRenderer
	{
		// Token: 0x1700021C RID: 540
		// (get) Token: 0x06000B88 RID: 2952 RVA: 0x0001D007 File Offset: 0x0001B207
		// (set) Token: 0x06000B89 RID: 2953 RVA: 0x0001D00F File Offset: 0x0001B20F
		[global::NLog.Config.RequiredParameter]
		public string Category { get; set; }

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x06000B8A RID: 2954 RVA: 0x0001D018 File Offset: 0x0001B218
		// (set) Token: 0x06000B8B RID: 2955 RVA: 0x0001D020 File Offset: 0x0001B220
		[global::NLog.Config.RequiredParameter]
		public string Counter { get; set; }

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x06000B8C RID: 2956 RVA: 0x0001D029 File Offset: 0x0001B229
		// (set) Token: 0x06000B8D RID: 2957 RVA: 0x0001D031 File Offset: 0x0001B231
		public string Instance { get; set; }

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x06000B8E RID: 2958 RVA: 0x0001D03A File Offset: 0x0001B23A
		// (set) Token: 0x06000B8F RID: 2959 RVA: 0x0001D042 File Offset: 0x0001B242
		public string MachineName { get; set; }

		// Token: 0x06000B90 RID: 2960 RVA: 0x0001D04C File Offset: 0x0001B24C
		protected override void InitializeLayoutRenderer()
		{
			base.InitializeLayoutRenderer();
			if (this.MachineName != null)
			{
				this.perfCounter = new global::System.Diagnostics.PerformanceCounter(this.Category, this.Counter, this.Instance, this.MachineName);
				return;
			}
			this.perfCounter = new global::System.Diagnostics.PerformanceCounter(this.Category, this.Counter, this.Instance, true);
		}

		// Token: 0x06000B91 RID: 2961 RVA: 0x0001D0A9 File Offset: 0x0001B2A9
		protected override void CloseLayoutRenderer()
		{
			base.CloseLayoutRenderer();
			if (this.perfCounter != null)
			{
				this.perfCounter.Close();
				this.perfCounter = null;
			}
		}

		// Token: 0x06000B92 RID: 2962 RVA: 0x0001D0CC File Offset: 0x0001B2CC
		protected override void Append(global::System.Text.StringBuilder builder, global::NLog.LogEventInfo logEvent)
		{
			global::System.IFormatProvider formatProvider = base.GetFormatProvider(logEvent, null);
			builder.Append(this.perfCounter.NextValue().ToString(formatProvider));
		}

		// Token: 0x040002FD RID: 765
		private global::System.Diagnostics.PerformanceCounter perfCounter;
	}
}
