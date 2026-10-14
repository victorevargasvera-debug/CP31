using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace Infragistics.Windows.Controls
{
	// Token: 0x02000103 RID: 259
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class GrowOnlyDecorator : global::System.Windows.Controls.Decorator
	{
		// Token: 0x060009AE RID: 2478 RVA: 0x0001FF20 File Offset: 0x0001E120
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size availableSize)
		{
			global::System.Windows.Size result = base.MeasureOverride(availableSize);
			if (this.ResetSize)
			{
				this.ResetSize = false;
				this._lastDesiredSize = global::System.Windows.Size.Empty;
			}
			if (this.GrowWidth)
			{
				if (!double.IsNaN(this._lastDesiredSize.Width) && (double.IsNaN(result.Width) || result.Width < this._lastDesiredSize.Width))
				{
					result.Width = this._lastDesiredSize.Width;
				}
				this._lastDesiredSize.Width = result.Width;
			}
			if (this.GrowHeight)
			{
				if (!double.IsNaN(this._lastDesiredSize.Height) && (double.IsNaN(result.Height) || result.Height < this._lastDesiredSize.Height))
				{
					result.Height = this._lastDesiredSize.Height;
				}
				this._lastDesiredSize.Height = result.Height;
			}
			return result;
		}

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x060009AF RID: 2479 RVA: 0x00020010 File Offset: 0x0001E210
		// (set) Token: 0x060009B0 RID: 2480 RVA: 0x00020022 File Offset: 0x0001E222
		[global::System.ComponentModel.Bindable(true)]
		public bool GrowHeight
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.Controls.GrowOnlyDecorator.GrowHeightProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.GrowOnlyDecorator.GrowHeightProperty, value);
			}
		}

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x060009B1 RID: 2481 RVA: 0x00020035 File Offset: 0x0001E235
		// (set) Token: 0x060009B2 RID: 2482 RVA: 0x00020047 File Offset: 0x0001E247
		[global::System.ComponentModel.Bindable(true)]
		public bool GrowWidth
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.Controls.GrowOnlyDecorator.GrowWidthProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.GrowOnlyDecorator.GrowWidthProperty, value);
			}
		}

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x060009B3 RID: 2483 RVA: 0x0002005A File Offset: 0x0001E25A
		// (set) Token: 0x060009B4 RID: 2484 RVA: 0x0002006C File Offset: 0x0001E26C
		[global::System.ComponentModel.Bindable(false)]
		public bool ResetSize
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.Controls.GrowOnlyDecorator.ResetSizeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.GrowOnlyDecorator.ResetSizeProperty, value);
			}
		}

		// Token: 0x040003E2 RID: 994
		private global::System.Windows.Size _lastDesiredSize;

		// Token: 0x040003E3 RID: 995
		public static readonly global::System.Windows.DependencyProperty GrowHeightProperty = global::System.Windows.DependencyProperty.Register("GrowHeight", typeof(bool), typeof(global::Infragistics.Windows.Controls.GrowOnlyDecorator), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.TrueBox, global::System.Windows.FrameworkPropertyMetadataOptions.None));

		// Token: 0x040003E4 RID: 996
		public static readonly global::System.Windows.DependencyProperty GrowWidthProperty = global::System.Windows.DependencyProperty.Register("GrowWidth", typeof(bool), typeof(global::Infragistics.Windows.Controls.GrowOnlyDecorator), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.TrueBox, global::System.Windows.FrameworkPropertyMetadataOptions.None));

		// Token: 0x040003E5 RID: 997
		public static readonly global::System.Windows.DependencyProperty ResetSizeProperty = global::System.Windows.DependencyProperty.Register("ResetSize", typeof(bool), typeof(global::Infragistics.Windows.Controls.GrowOnlyDecorator), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, global::System.Windows.FrameworkPropertyMetadataOptions.None));
	}
}
