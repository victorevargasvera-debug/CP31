using System;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Effects;

namespace Infragistics.Windows.Controls.Markup
{
	// Token: 0x020001BA RID: 442
	public class SafeDropShadowEffectExtension : global::System.Windows.Markup.MarkupExtension
	{
		// Token: 0x170002AF RID: 687
		// (get) Token: 0x06000EBF RID: 3775 RVA: 0x0002F84C File Offset: 0x0002DA4C
		// (set) Token: 0x06000EC0 RID: 3776 RVA: 0x0002F854 File Offset: 0x0002DA54
		public double BlurRadius { get; set; }

		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x06000EC1 RID: 3777 RVA: 0x0002F85D File Offset: 0x0002DA5D
		// (set) Token: 0x06000EC2 RID: 3778 RVA: 0x0002F865 File Offset: 0x0002DA65
		public global::System.Windows.Media.Color Color { get; set; }

		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x06000EC3 RID: 3779 RVA: 0x0002F86E File Offset: 0x0002DA6E
		// (set) Token: 0x06000EC4 RID: 3780 RVA: 0x0002F876 File Offset: 0x0002DA76
		public double Direction { get; set; }

		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x06000EC5 RID: 3781 RVA: 0x0002F87F File Offset: 0x0002DA7F
		// (set) Token: 0x06000EC6 RID: 3782 RVA: 0x0002F887 File Offset: 0x0002DA87
		public double Opacity { get; set; }

		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x06000EC7 RID: 3783 RVA: 0x0002F890 File Offset: 0x0002DA90
		// (set) Token: 0x06000EC8 RID: 3784 RVA: 0x0002F898 File Offset: 0x0002DA98
		public double ShadowDepth { get; set; }

		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x06000EC9 RID: 3785 RVA: 0x0002F8A1 File Offset: 0x0002DAA1
		// (set) Token: 0x06000ECA RID: 3786 RVA: 0x0002F8A9 File Offset: 0x0002DAA9
		public global::System.Windows.Media.Effects.RenderingBias RenderingBias { get; set; }

		// Token: 0x06000ECB RID: 3787 RVA: 0x0002F8B4 File Offset: 0x0002DAB4
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
