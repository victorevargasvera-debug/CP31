using System;
using System.ComponentModel;
using System.Globalization;
using System.Text;
using NLog.Internal;

namespace NLog.LayoutRenderers
{
	// Token: 0x020000D4 RID: 212
	[global::NLog.LayoutRenderers.LayoutRenderer("qpc")]
	public class QueryPerformanceCounterLayoutRenderer : global::NLog.LayoutRenderers.LayoutRenderer
	{
		// Token: 0x06000BA7 RID: 2983 RVA: 0x0001D384 File Offset: 0x0001B584
		public QueryPerformanceCounterLayoutRenderer()
		{
			this.Normalize = true;
			this.Difference = false;
			this.Precision = 4;
			this.AlignDecimalPoint = true;
		}

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x06000BA8 RID: 2984 RVA: 0x0001D3B7 File Offset: 0x0001B5B7
		// (set) Token: 0x06000BA9 RID: 2985 RVA: 0x0001D3BF File Offset: 0x0001B5BF
		[global::System.ComponentModel.DefaultValue(true)]
		public bool Normalize { get; set; }

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x06000BAA RID: 2986 RVA: 0x0001D3C8 File Offset: 0x0001B5C8
		// (set) Token: 0x06000BAB RID: 2987 RVA: 0x0001D3D0 File Offset: 0x0001B5D0
		[global::System.ComponentModel.DefaultValue(false)]
		public bool Difference { get; set; }

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x06000BAC RID: 2988 RVA: 0x0001D3D9 File Offset: 0x0001B5D9
		// (set) Token: 0x06000BAD RID: 2989 RVA: 0x0001D3E4 File Offset: 0x0001B5E4
		[global::System.ComponentModel.DefaultValue(true)]
		public bool Seconds
		{
			get
			{
				return !this.raw;
			}
			set
			{
				this.raw = !value;
			}
		}

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x06000BAE RID: 2990 RVA: 0x0001D3F0 File Offset: 0x0001B5F0
		// (set) Token: 0x06000BAF RID: 2991 RVA: 0x0001D3F8 File Offset: 0x0001B5F8
		[global::System.ComponentModel.DefaultValue(4)]
		public int Precision { get; set; }

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x06000BB0 RID: 2992 RVA: 0x0001D401 File Offset: 0x0001B601
		// (set) Token: 0x06000BB1 RID: 2993 RVA: 0x0001D409 File Offset: 0x0001B609
		[global::System.ComponentModel.DefaultValue(true)]
		public bool AlignDecimalPoint { get; set; }

		// Token: 0x06000BB2 RID: 2994 RVA: 0x0001D414 File Offset: 0x0001B614
		protected override void InitializeLayoutRenderer()
		{
			base.InitializeLayoutRenderer();
			ulong num;
			if (!global::NLog.Internal.NativeMethods.QueryPerformanceFrequency(out num))
			{
				throw new global::System.InvalidOperationException("Cannot determine high-performance counter frequency.");
			}
			ulong num2;
			if (!global::NLog.Internal.NativeMethods.QueryPerformanceCounter(out num2))
			{
				throw new global::System.InvalidOperationException("Cannot determine high-performance counter value.");
			}
			this.frequency = num;
			this.firstQpcValue = num2;
			this.lastQpcValue = num2;
		}

		// Token: 0x06000BB3 RID: 2995 RVA: 0x0001D468 File Offset: 0x0001B668
		protected override void Append(global::System.Text.StringBuilder builder, global::NLog.LogEventInfo logEvent)
		{
			ulong num;
			if (!global::NLog.Internal.NativeMethods.QueryPerformanceCounter(out num))
			{
				return;
			}
			ulong num2 = num;
			if (this.Difference)
			{
				num -= this.lastQpcValue;
			}
			else if (this.Normalize)
			{
				num -= this.firstQpcValue;
			}
			this.lastQpcValue = num2;
			string text;
			if (this.Seconds)
			{
				text = global::System.Convert.ToString(global::System.Math.Round(num / this.frequency, this.Precision), global::System.Globalization.CultureInfo.InvariantCulture);
				if (this.AlignDecimalPoint)
				{
					int num3 = text.IndexOf('.');
					if (num3 == -1)
					{
						text = text + "." + new string('0', this.Precision);
					}
					else
					{
						text += new string('0', this.Precision - (text.Length - 1 - num3));
					}
				}
			}
			else
			{
				text = global::System.Convert.ToString(num, global::System.Globalization.CultureInfo.InvariantCulture);
			}
			builder.Append(text);
		}

		// Token: 0x04000330 RID: 816
		private bool raw;

		// Token: 0x04000331 RID: 817
		private ulong firstQpcValue;

		// Token: 0x04000332 RID: 818
		private ulong lastQpcValue;

		// Token: 0x04000333 RID: 819
		private double frequency = 1.0;
	}
}
