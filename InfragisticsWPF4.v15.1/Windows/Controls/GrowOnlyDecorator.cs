using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace Infragistics.Windows.Controls
{
	// Token: 0x02000121 RID: 289
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class GrowOnlyDecorator : global::System.Windows.Controls.Decorator
	{
		// Token: 0x06000AAD RID: 2733 RVA: 0x00023AE8 File Offset: 0x00021CE8
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

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x06000AAE RID: 2734 RVA: 0x00023BD8 File Offset: 0x00021DD8
		// (set) Token: 0x06000AAF RID: 2735 RVA: 0x00023BEA File Offset: 0x00021DEA
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

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x06000AB0 RID: 2736 RVA: 0x00023BFD File Offset: 0x00021DFD
		// (set) Token: 0x06000AB1 RID: 2737 RVA: 0x00023C0F File Offset: 0x00021E0F
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

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x06000AB2 RID: 2738 RVA: 0x00023C22 File Offset: 0x00021E22
		// (set) Token: 0x06000AB3 RID: 2739 RVA: 0x00023C34 File Offset: 0x00021E34
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

		// Token: 0x04000495 RID: 1173
		private global::System.Windows.Size _lastDesiredSize;

		// Token: 0x04000496 RID: 1174
		public static readonly global::System.Windows.DependencyProperty GrowHeightProperty = global::System.Windows.DependencyProperty.Register("GrowHeight", typeof(bool), typeof(global::Infragistics.Windows.Controls.GrowOnlyDecorator), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.TrueBox, global::System.Windows.FrameworkPropertyMetadataOptions.None));

		// Token: 0x04000497 RID: 1175
		public static readonly global::System.Windows.DependencyProperty GrowWidthProperty = global::System.Windows.DependencyProperty.Register("GrowWidth", typeof(bool), typeof(global::Infragistics.Windows.Controls.GrowOnlyDecorator), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.TrueBox, global::System.Windows.FrameworkPropertyMetadataOptions.None));

		// Token: 0x04000498 RID: 1176
		public static readonly global::System.Windows.DependencyProperty ResetSizeProperty = global::System.Windows.DependencyProperty.Register("ResetSize", typeof(bool), typeof(global::Infragistics.Windows.Controls.GrowOnlyDecorator), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, global::System.Windows.FrameworkPropertyMetadataOptions.None));
	}
}
