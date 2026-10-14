using System;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Effects;

namespace Infragistics.Windows.Controls.Markup
{
	// Token: 0x020001DE RID: 478
	[global::System.Windows.Markup.MarkupExtensionReturnType(typeof(global::System.Windows.Media.Effects.OuterGlowBitmapEffect))]
	public class SafeOuterGlowExtension : global::System.Windows.Markup.MarkupExtension
	{
		// Token: 0x17000409 RID: 1033
		// (get) Token: 0x060011BE RID: 4542 RVA: 0x0003FBA0 File Offset: 0x0003DDA0
		// (set) Token: 0x060011BF RID: 4543 RVA: 0x0003FBA8 File Offset: 0x0003DDA8
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

		// Token: 0x1700040A RID: 1034
		// (get) Token: 0x060011C0 RID: 4544 RVA: 0x0003FBB1 File Offset: 0x0003DDB1
		// (set) Token: 0x060011C1 RID: 4545 RVA: 0x0003FBB9 File Offset: 0x0003DDB9
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

		// Token: 0x1700040B RID: 1035
		// (get) Token: 0x060011C2 RID: 4546 RVA: 0x0003FBC2 File Offset: 0x0003DDC2
		// (set) Token: 0x060011C3 RID: 4547 RVA: 0x0003FBCA File Offset: 0x0003DDCA
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

		// Token: 0x1700040C RID: 1036
		// (get) Token: 0x060011C4 RID: 4548 RVA: 0x0003FBD3 File Offset: 0x0003DDD3
		// (set) Token: 0x060011C5 RID: 4549 RVA: 0x0003FBDB File Offset: 0x0003DDDB
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

		// Token: 0x060011C6 RID: 4550 RVA: 0x0003FBE4 File Offset: 0x0003DDE4
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

		// Token: 0x04000930 RID: 2352
		private global::System.Windows.Media.Color _glowColor = global::System.Windows.Media.Colors.Gold;

		// Token: 0x04000931 RID: 2353
		private double _glowSize = 5.0;

		// Token: 0x04000932 RID: 2354
		private double _noise;

		// Token: 0x04000933 RID: 2355
		private double _opacity = 1.0;
	}
}
