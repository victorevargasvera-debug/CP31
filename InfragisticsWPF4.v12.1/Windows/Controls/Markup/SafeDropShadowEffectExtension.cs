using System;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Effects;

namespace Infragistics.Windows.Controls.Markup
{
	// Token: 0x02000193 RID: 403
	public class SafeDropShadowEffectExtension : global::System.Windows.Markup.MarkupExtension
	{
		// Token: 0x1700028F RID: 655
		// (get) Token: 0x06000D6C RID: 3436 RVA: 0x0002AFEC File Offset: 0x000291EC
		// (set) Token: 0x06000D6D RID: 3437 RVA: 0x0002AFF4 File Offset: 0x000291F4
		public double BlurRadius { get; set; }

		// Token: 0x17000290 RID: 656
		// (get) Token: 0x06000D6E RID: 3438 RVA: 0x0002AFFD File Offset: 0x000291FD
		// (set) Token: 0x06000D6F RID: 3439 RVA: 0x0002B005 File Offset: 0x00029205
		public global::System.Windows.Media.Color Color { get; set; }

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x06000D70 RID: 3440 RVA: 0x0002B00E File Offset: 0x0002920E
		// (set) Token: 0x06000D71 RID: 3441 RVA: 0x0002B016 File Offset: 0x00029216
		public double Direction { get; set; }

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x06000D72 RID: 3442 RVA: 0x0002B01F File Offset: 0x0002921F
		// (set) Token: 0x06000D73 RID: 3443 RVA: 0x0002B027 File Offset: 0x00029227
		public double Opacity { get; set; }

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x06000D74 RID: 3444 RVA: 0x0002B030 File Offset: 0x00029230
		// (set) Token: 0x06000D75 RID: 3445 RVA: 0x0002B038 File Offset: 0x00029238
		public double ShadowDepth { get; set; }

		// Token: 0x17000294 RID: 660
		// (get) Token: 0x06000D76 RID: 3446 RVA: 0x0002B041 File Offset: 0x00029241
		// (set) Token: 0x06000D77 RID: 3447 RVA: 0x0002B049 File Offset: 0x00029249
		public global::System.Windows.Media.Effects.RenderingBias RenderingBias { get; set; }

		// Token: 0x06000D78 RID: 3448 RVA: 0x0002B054 File Offset: 0x00029254
		public override object ProvideValue(global::System.IServiceProvider serviceProvider)
		{
			if (global::System.Windows.Interop.BrowserInteropHelper.IsBrowserHosted)
			{
				return null;
			}
			object result;
			try
			{
				result = new global::System.Windows.Media.Effects.DropShadowEffect
				{
					BlurRadius = this.BlurRadius,
					Color = this.Color,
					Direction = this.Direction,
					Opacity = this.Opacity,
					RenderingBias = this.RenderingBias,
					ShadowDepth = this.ShadowDepth
				};
			}
			catch
			{
				result = null;
			}
			return result;
		}
	}
}
