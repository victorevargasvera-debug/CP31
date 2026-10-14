using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020001BF RID: 447
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class RecordScrollTip : global::System.Windows.Controls.ToolTip
	{
		// Token: 0x06001A52 RID: 6738 RVA: 0x00072C1C File Offset: 0x00070E1C
		static RecordScrollTip()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.RecordScrollTip), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.DataPresenter.RecordScrollTip)));
		}

		// Token: 0x06001A53 RID: 6739 RVA: 0x00072C8A File Offset: 0x00070E8A
		public RecordScrollTip()
		{
			base.SetValue(global::Infragistics.Windows.DataPresenter.RecordScrollTip.IsInRecordScrollTipPropertyKey, global::Infragistics.KnownBoxes.TrueBox);
		}

		// Token: 0x06001A54 RID: 6740 RVA: 0x00072CA4 File Offset: 0x00070EA4
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size availableSize)
		{
			global::System.Windows.Size size = base.MeasureOverride(availableSize);
			if (size.Width < this._lastSize.Width)
			{
				size.Width = this._lastSize.Width;
			}
			if (size.Height < this._lastSize.Height)
			{
				size.Height = this._lastSize.Height;
			}
			this._lastSize = size;
			return size;
		}

		// Token: 0x06001A55 RID: 6741 RVA: 0x00072D0D File Offset: 0x00070F0D
		public static bool GetIsInRecordScrollTip(global::System.Windows.DependencyObject d)
		{
			return (bool)d.GetValue(global::Infragistics.Windows.DataPresenter.RecordScrollTip.IsInRecordScrollTipProperty);
		}

		// Token: 0x04000AE6 RID: 2790
		private global::System.Windows.Size _lastSize;

		// Token: 0x04000AE7 RID: 2791
		private static readonly global::System.Windows.DependencyPropertyKey IsInRecordScrollTipPropertyKey = global::System.Windows.DependencyProperty.RegisterAttachedReadOnly("IsInRecordScrollTip", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.RecordScrollTip), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, global::System.Windows.FrameworkPropertyMetadataOptions.Inherits));

		// Token: 0x04000AE8 RID: 2792
		public static readonly global::System.Windows.DependencyProperty IsInRecordScrollTipProperty = global::Infragistics.Windows.DataPresenter.RecordScrollTip.IsInRecordScrollTipPropertyKey.DependencyProperty;
	}
}
