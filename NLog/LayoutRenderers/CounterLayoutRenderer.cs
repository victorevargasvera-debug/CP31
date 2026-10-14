using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using NLog.Internal;
using NLog.Layouts;

namespace NLog.LayoutRenderers
{
	// Token: 0x020000AE RID: 174
	[global::NLog.LayoutRenderers.LayoutRenderer("counter")]
	public class CounterLayoutRenderer : global::NLog.LayoutRenderers.LayoutRenderer
	{
		// Token: 0x06000A83 RID: 2691 RVA: 0x0001ACAA File Offset: 0x00018EAA
		public CounterLayoutRenderer()
		{
			this.Increment = 1;
			this.Value = 1;
		}

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x06000A84 RID: 2692 RVA: 0x0001ACC0 File Offset: 0x00018EC0
		// (set) Token: 0x06000A85 RID: 2693 RVA: 0x0001ACC8 File Offset: 0x00018EC8
		[global::System.ComponentModel.DefaultValue(1)]
		public int Value { get; set; }

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x06000A86 RID: 2694 RVA: 0x0001ACD1 File Offset: 0x00018ED1
		// (set) Token: 0x06000A87 RID: 2695 RVA: 0x0001ACD9 File Offset: 0x00018ED9
		[global::System.ComponentModel.DefaultValue(1)]
		public int Increment { get; set; }

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x06000A88 RID: 2696 RVA: 0x0001ACE2 File Offset: 0x00018EE2
		// (set) Token: 0x06000A89 RID: 2697 RVA: 0x0001ACEA File Offset: 0x00018EEA
		public global::NLog.Layouts.Layout Sequence { get; set; }

		// Token: 0x06000A8A RID: 2698 RVA: 0x0001ACF4 File Offset: 0x00018EF4
		protected override void Append(global::System.Text.StringBuilder builder, global::NLog.LogEventInfo logEvent)
		{
			int value;
			if (this.Sequence != null)
			{
				value = global::NLog.LayoutRenderers.CounterLayoutRenderer.GetNextSequenceValue(this.Sequence.Render(logEvent), this.Value, this.Increment);
			}
			else
			{
				value = this.Value;
				this.Value += this.Increment;
			}
			builder.AppendInvariant(value);
		}

		// Token: 0x06000A8B RID: 2699 RVA: 0x0001AD4C File Offset: 0x00018F4C
		private static int GetNextSequenceValue(string sequenceName, int defaultValue, int increment)
		{
			global::System.Collections.Generic.Dictionary<string, int> obj = global::NLog.LayoutRenderers.CounterLayoutRenderer.sequences;
			int result;
			lock (obj)
			{
				int num;
				if (!global::NLog.LayoutRenderers.CounterLayoutRenderer.sequences.TryGetValue(sequenceName, out num))
				{
					num = defaultValue;
				}
				int num2 = num;
				num += increment;
				global::NLog.LayoutRenderers.CounterLayoutRenderer.sequences[sequenceName] = num;
				result = num2;
			}
			return result;
		}

		// Token: 0x04000294 RID: 660
		private static global::System.Collections.Generic.Dictionary<string, int> sequences = new global::System.Collections.Generic.Dictionary<string, int>();
	}
}
