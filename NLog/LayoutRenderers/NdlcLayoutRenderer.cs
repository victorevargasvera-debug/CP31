using System;
using System.Text;
using NLog.Config;
using NLog.Internal;

namespace NLog.LayoutRenderers
{
	// Token: 0x020000CA RID: 202
	[global::NLog.LayoutRenderers.LayoutRenderer("ndlc")]
	[global::NLog.Config.ThreadSafe]
	public class NdlcLayoutRenderer : global::NLog.LayoutRenderers.LayoutRenderer
	{
		// Token: 0x06000B6B RID: 2923 RVA: 0x0001CD38 File Offset: 0x0001AF38
		public NdlcLayoutRenderer()
		{
			this.Separator = " ";
			this.BottomFrames = -1;
			this.TopFrames = -1;
		}

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x06000B6C RID: 2924 RVA: 0x0001CD59 File Offset: 0x0001AF59
		// (set) Token: 0x06000B6D RID: 2925 RVA: 0x0001CD61 File Offset: 0x0001AF61
		public int TopFrames { get; set; }

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x06000B6E RID: 2926 RVA: 0x0001CD6A File Offset: 0x0001AF6A
		// (set) Token: 0x06000B6F RID: 2927 RVA: 0x0001CD72 File Offset: 0x0001AF72
		public int BottomFrames { get; set; }

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x06000B70 RID: 2928 RVA: 0x0001CD7B File Offset: 0x0001AF7B
		// (set) Token: 0x06000B71 RID: 2929 RVA: 0x0001CD83 File Offset: 0x0001AF83
		public string Separator { get; set; }

		// Token: 0x06000B72 RID: 2930 RVA: 0x0001CD8C File Offset: 0x0001AF8C
		protected override void Append(global::System.Text.StringBuilder builder, global::NLog.LogEventInfo logEvent)
		{
			object[] allObjects = global::NLog.NestedDiagnosticsLogicalContext.GetAllObjects();
			int num = 0;
			int num2 = allObjects.Length;
			if (this.TopFrames != -1)
			{
				num2 = global::System.Math.Min(this.TopFrames, allObjects.Length);
			}
			else if (this.BottomFrames != -1)
			{
				num = allObjects.Length - global::System.Math.Min(this.BottomFrames, allObjects.Length);
			}
			string value = string.Empty;
			for (int i = num2 - 1; i >= num; i--)
			{
				string value2 = global::NLog.Internal.FormatHelper.ConvertToString(allObjects[i], logEvent.FormatProvider);
				builder.Append(value);
				builder.Append(value2);
				value = this.Separator;
			}
		}
	}
}
