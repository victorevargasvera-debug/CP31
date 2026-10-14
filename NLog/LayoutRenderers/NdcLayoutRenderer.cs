using System;
using System.Text;
using NLog.Config;
using NLog.Internal;

namespace NLog.LayoutRenderers
{
	// Token: 0x020000C9 RID: 201
	[global::NLog.LayoutRenderers.LayoutRenderer("ndc")]
	[global::NLog.Config.ThreadSafe]
	public class NdcLayoutRenderer : global::NLog.LayoutRenderers.LayoutRenderer
	{
		// Token: 0x06000B63 RID: 2915 RVA: 0x0001CC54 File Offset: 0x0001AE54
		public NdcLayoutRenderer()
		{
			this.Separator = " ";
			this.BottomFrames = -1;
			this.TopFrames = -1;
		}

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x06000B64 RID: 2916 RVA: 0x0001CC75 File Offset: 0x0001AE75
		// (set) Token: 0x06000B65 RID: 2917 RVA: 0x0001CC7D File Offset: 0x0001AE7D
		public int TopFrames { get; set; }

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x06000B66 RID: 2918 RVA: 0x0001CC86 File Offset: 0x0001AE86
		// (set) Token: 0x06000B67 RID: 2919 RVA: 0x0001CC8E File Offset: 0x0001AE8E
		public int BottomFrames { get; set; }

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x06000B68 RID: 2920 RVA: 0x0001CC97 File Offset: 0x0001AE97
		// (set) Token: 0x06000B69 RID: 2921 RVA: 0x0001CC9F File Offset: 0x0001AE9F
		public string Separator { get; set; }

		// Token: 0x06000B6A RID: 2922 RVA: 0x0001CCA8 File Offset: 0x0001AEA8
		protected override void Append(global::System.Text.StringBuilder builder, global::NLog.LogEventInfo logEvent)
		{
			object[] allObjects = global::NLog.NestedDiagnosticsContext.GetAllObjects();
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
