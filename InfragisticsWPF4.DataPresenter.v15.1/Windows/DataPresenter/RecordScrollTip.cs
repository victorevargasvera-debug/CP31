using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020001E6 RID: 486
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class RecordScrollTip : global::System.Windows.Controls.ToolTip
	{
		// Token: 0x06001E60 RID: 7776 RVA: 0x0008686C File Offset: 0x00084A6C
		static RecordScrollTip()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.RecordScrollTip), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.DataPresenter.RecordScrollTip)));
		}

		// Token: 0x06001E61 RID: 7777 RVA: 0x000868DA File Offset: 0x00084ADA
		public RecordScrollTip()
		{
			base.SetValue(global::Infragistics.Windows.DataPresenter.RecordScrollTip.IsInRecordScrollTipPropertyKey, global::Infragistics.KnownBoxes.TrueBox);
		}

		// Token: 0x06001E62 RID: 7778 RVA: 0x000868F4 File Offset: 0x00084AF4
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

		// Token: 0x06001E63 RID: 7779 RVA: 0x0008695D File Offset: 0x00084B5D
		public static bool GetIsInRecordScrollTip(global::System.Windows.DependencyObject d)
		{
			return (bool)d.GetValue(global::Infragistics.Windows.DataPresenter.RecordScrollTip.IsInRecordScrollTipProperty);
		}

		// Token: 0x04000CD0 RID: 3280
		private global::System.Windows.Size _lastSize;

		// Token: 0x04000CD1 RID: 3281
		private static readonly global::System.Windows.DependencyPropertyKey IsInRecordScrollTipPropertyKey = global::System.Windows.DependencyProperty.RegisterAttachedReadOnly("IsInRecordScrollTip", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.RecordScrollTip), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, global::System.Windows.FrameworkPropertyMetadataOptions.Inherits));

		// Token: 0x04000CD2 RID: 3282
		public static readonly global::System.Windows.DependencyProperty IsInRecordScrollTipProperty = global::Infragistics.Windows.DataPresenter.RecordScrollTip.IsInRecordScrollTipPropertyKey.DependencyProperty;
	}
}
