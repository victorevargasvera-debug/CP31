using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020001CD RID: 461
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class SummaryRecordHeaderPresenter : global::System.Windows.Controls.Control
	{
		// Token: 0x06001B2D RID: 6957 RVA: 0x0007A51C File Offset: 0x0007871C
		static SummaryRecordHeaderPresenter()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.SummaryRecordHeaderPresenter), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.DataPresenter.SummaryRecordHeaderPresenter)));
			global::System.Windows.UIElement.FocusableProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.SummaryRecordHeaderPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));
		}

		// Token: 0x17000797 RID: 1943
		// (get) Token: 0x06001B2F RID: 6959 RVA: 0x0007A59B File Offset: 0x0007879B
		// (set) Token: 0x06001B30 RID: 6960 RVA: 0x0007A5AD File Offset: 0x000787AD
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
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

		// Token: 0x04000AF0 RID: 2800
		public static readonly global::System.Windows.DependencyProperty SummaryRecordProperty = global::System.Windows.DependencyProperty.Register("SummaryRecord", typeof(global::Infragistics.Windows.DataPresenter.SummaryRecord), typeof(global::Infragistics.Windows.DataPresenter.SummaryRecordHeaderPresenter), new global::System.Windows.FrameworkPropertyMetadata(null));
	}
}
