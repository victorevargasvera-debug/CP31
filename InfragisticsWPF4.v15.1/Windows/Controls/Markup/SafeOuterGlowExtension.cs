using System;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Effects;

namespace Infragistics.Windows.Controls.Markup
{
	// Token: 0x0200020C RID: 524
	[global::System.Windows.Markup.MarkupExtensionReturnType(typeof(global::System.Windows.Media.Effects.OuterGlowBitmapEffect))]
	public class SafeOuterGlowExtension : global::System.Windows.Markup.MarkupExtension
	{
		// Token: 0x1700047C RID: 1148
		// (get) Token: 0x06001392 RID: 5010 RVA: 0x00045448 File Offset: 0x00043648
		// (set) Token: 0x06001393 RID: 5011 RVA: 0x00045450 File Offset: 0x00043650
		public global::System.Windows.Media.Color GlowColor
		{
			get
			{
				return this._glowColor;
			}
			set
			{
				this._glowColor = value;
			}
		}

		// Token: 0x1700047D RID: 1149
		// (get) Token: 0x06001394 RID: 5012 RVA: 0x00045459 File Offset: 0x00043659
		// (set) Token: 0x06001395 RID: 5013 RVA: 0x00045461 File Offset: 0x00043661
		public double GlowSize
		{
			get
			{
				return this._glowSize;
			}
			set
			{
				this._glowSize = value;
			}
		}

		// Token: 0x1700047E RID: 1150
		// (get) Token: 0x06001396 RID: 5014 RVA: 0x0004546A File Offset: 0x0004366A
		// (set) Token: 0x06001397 RID: 5015 RVA: 0x00045472 File Offset: 0x00043672
		public double Noise
		{
			get
			{
				return this._noise;
			}
			set
			{
				this._noise = value;
			}
		}

		// Token: 0x1700047F RID: 1151
		// (get) Token: 0x06001398 RID: 5016 RVA: 0x0004547B File Offset: 0x0004367B
		// (set) Token: 0x06001399 RID: 5017 RVA: 0x00045483 File Offset: 0x00043683
		public double Opacity
		{
			get
			{
				return this._opacity;
			}
			set
			{
				this._opacity = value;
			}
		}

		// Token: 0x0600139A RID: 5018 RVA: 0x0004548C File Offset: 0x0004368C
		public override object ProvideValue(global::System.IServiceProvider serviceProvider)
		{
			if (global::System.Windows.Interop.BrowserInteropHelper.IsBrowserHosted)
			{
				return null;
			}
			object result;
			try
			{
				result = new global::System.Windows.Media.Effects.OuterGlowBitmapEffect
				{
					GlowColor = this._glowColor,
					GlowSize = this._glowSize,
					Noise = this._noise,
					Opacity = this._opacity
				};
			}
			catch
			{
				result = null;
			}
			return result;
		}

		// Token: 0x04000A74 RID: 2676
		private global::System.Windows.Media.Color _glowColor = global::System.Windows.Media.Colors.Gold;

		// Token: 0x04000A75 RID: 2677
		private double _glowSize = 5.0;

		// Token: 0x04000A76 RID: 2678
		private double _noise;

		// Token: 0x04000A77 RID: 2679
		private double _opacity = 1.0;
	}
}
