using System;
using System.ComponentModel;
using System.Globalization;
using System.Text;
using NLog.Config;
using NLog.Internal;

namespace NLog.LayoutRenderers
{
	// Token: 0x020000B7 RID: 183
	[global::NLog.LayoutRenderers.LayoutRenderer("gc")]
	[global::NLog.Config.ThreadSafe]
	public class GarbageCollectorInfoLayoutRenderer : global::NLog.LayoutRenderers.LayoutRenderer
	{
		// Token: 0x06000ADB RID: 2779 RVA: 0x0001B8AB File Offset: 0x00019AAB
		public GarbageCollectorInfoLayoutRenderer()
		{
			this.Property = global::NLog.LayoutRenderers.GarbageCollectorProperty.TotalMemory;
		}

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x06000ADC RID: 2780 RVA: 0x0001B8BA File Offset: 0x00019ABA
		// (set) Token: 0x06000ADD RID: 2781 RVA: 0x0001B8C2 File Offset: 0x00019AC2
		[global::System.ComponentModel.DefaultValue("TotalMemory")]
		public global::NLog.LayoutRenderers.GarbageCollectorProperty Property { get; set; }

		// Token: 0x06000ADE RID: 2782 RVA: 0x0001B8CC File Offset: 0x00019ACC
		protected override void Append(global::System.Text.StringBuilder builder, global::NLog.LogEventInfo logEvent)
		{
			global::System.IFormatProvider formatProvider = base.GetFormatProvider(logEvent, null);
			if (formatProvider == global::System.Globalization.CultureInfo.InvariantCulture)
			{
				formatProvider = null;
			}
			long num = 0L;
			switch (this.Property)
			{
			case global::NLog.LayoutRenderers.GarbageCollectorProperty.TotalMemory:
				num = global::System.GC.GetTotalMemory(false);
				break;
			case global::NLog.LayoutRenderers.GarbageCollectorProperty.TotalMemoryForceCollection:
				num = global::System.GC.GetTotalMemory(true);
				break;
			case global::NLog.LayoutRenderers.GarbageCollectorProperty.CollectionCount0:
				num = (long)global::System.GC.CollectionCount(0);
				break;
			case global::NLog.LayoutRenderers.GarbageCollectorProperty.CollectionCount1:
				num = (long)global::System.GC.CollectionCount(1);
				break;
			case global::NLog.LayoutRenderers.GarbageCollectorProperty.CollectionCount2:
				num = (long)global::System.GC.CollectionCount(2);
				break;
			case global::NLog.LayoutRenderers.GarbageCollectorProperty.MaxGeneration:
				num = (long)global::System.GC.MaxGeneration;
				break;
			}
			if (formatProvider == null && num >= 0L && num < (long)((ulong)-1))
			{
				builder.AppendInvariant((uint)num);
				return;
			}
			builder.Append(global::System.Convert.ToString(num, formatProvider ?? global::System.Globalization.CultureInfo.InvariantCulture));
		}
	}
}
