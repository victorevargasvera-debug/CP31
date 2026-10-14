using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020001AA RID: 426
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class SummaryRecordHeaderPresenter : global::System.Windows.Controls.Control
	{
		// Token: 0x0600176F RID: 5999 RVA: 0x000678F4 File Offset: 0x00065AF4
		static SummaryRecordHeaderPresenter()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.SummaryRecordHeaderPresenter), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.DataPresenter.SummaryRecordHeaderPresenter)));
			global::System.Windows.UIElement.FocusableProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.SummaryRecordHeaderPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));
		}

		// Token: 0x17000634 RID: 1588
		// (get) Token: 0x06001771 RID: 6001 RVA: 0x00067973 File Offset: 0x00065B73
		// (set) Token: 0x06001772 RID: 6002 RVA: 0x00067985 File Offset: 0x00065B85
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.DataPresenter.SummaryRecord SummaryRecord
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.SummaryRecord)base.GetValue(global::Infragistics.Windows.DataPresenter.SummaryRecordHeaderPresenter.SummaryRecordProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.SummaryRecordHeaderPresenter.SummaryRecordProperty, value);
			}
		}

		// Token: 0x04000926 RID: 2342
		public static readonly global::System.Windows.DependencyProperty SummaryRecordProperty = global::System.Windows.DependencyProperty.Register("SummaryRecord", typeof(global::Infragistics.Windows.DataPresenter.SummaryRecord), typeof(global::Infragistics.Windows.DataPresenter.SummaryRecordHeaderPresenter), new global::System.Windows.FrameworkPropertyMetadata(null));
	}
}
