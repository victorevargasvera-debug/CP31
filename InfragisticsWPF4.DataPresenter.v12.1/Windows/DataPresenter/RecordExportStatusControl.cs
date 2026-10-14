using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using Infragistics.Windows.Automation.Peers.DataPresenter;
using Infragistics.Windows.Themes;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000102 RID: 258
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class RecordExportStatusControl : global::System.Windows.Controls.Control
	{
		// Token: 0x06000DA7 RID: 3495 RVA: 0x0003AF9C File Offset: 0x0003919C
		static RecordExportStatusControl()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.RecordExportStatusControl), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.DataPresenter.RecordExportStatusControl)));
		}

		// Token: 0x06000DA9 RID: 3497 RVA: 0x0003B0ED File Offset: 0x000392ED
		protected override global::System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
		{
			return new global::Infragistics.Windows.Automation.Peers.DataPresenter.RecordExportStatusControlAutomationPeer(this);
		}

		// Token: 0x06000DAA RID: 3498 RVA: 0x0003B0F8 File Offset: 0x000392F8
		private static void OnDataPresenterChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.RecordExportStatusControl ctrl = d as global::Infragistics.Windows.DataPresenter.RecordExportStatusControl;
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenterBase = e.OldValue as global::Infragistics.Windows.DataPresenter.DataPresenterBase;
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenterBase2 = e.NewValue as global::Infragistics.Windows.DataPresenter.DataPresenterBase;
			if (dataPresenterBase != null)
			{
				dataPresenterBase.ExportHelper.RemoveStatusControl(ctrl);
			}
			if (dataPresenterBase2 != null)
			{
				dataPresenterBase2.ExportHelper.AddStatusControl(ctrl);
			}
		}

		// Token: 0x170002EF RID: 751
		// (get) Token: 0x06000DAB RID: 3499 RVA: 0x0003B144 File Offset: 0x00039344
		// (set) Token: 0x06000DAC RID: 3500 RVA: 0x0003B156 File Offset: 0x00039356
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.DataPresenter.DataPresenterBase DataPresenter
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.DataPresenterBase)base.GetValue(global::Infragistics.Windows.DataPresenter.RecordExportStatusControl.DataPresenterProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.RecordExportStatusControl.DataPresenterProperty, value);
			}
		}

		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x06000DAD RID: 3501 RVA: 0x0003B164 File Offset: 0x00039364
		// (set) Token: 0x06000DAE RID: 3502 RVA: 0x0003B176 File Offset: 0x00039376
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		public global::Infragistics.Windows.DataPresenter.ExportInfo ExportInfo
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.ExportInfo)base.GetValue(global::Infragistics.Windows.DataPresenter.RecordExportStatusControl.ExportInfoProperty);
			}
			internal set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.RecordExportStatusControl.ExportInfoPropertyKey, value);
			}
		}

		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x06000DAF RID: 3503 RVA: 0x0003B184 File Offset: 0x00039384
		// (set) Token: 0x06000DB0 RID: 3504 RVA: 0x0003B196 File Offset: 0x00039396
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public int ExportedRecordCount
		{
			get
			{
				return (int)base.GetValue(global::Infragistics.Windows.DataPresenter.RecordExportStatusControl.ExportedRecordCountProperty);
			}
			internal set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.RecordExportStatusControl.ExportedRecordCountPropertyKey, value);
			}
		}

		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x06000DB1 RID: 3505 RVA: 0x0003B1A9 File Offset: 0x000393A9
		// (set) Token: 0x06000DB2 RID: 3506 RVA: 0x0003B1BB File Offset: 0x000393BB
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		public global::Infragistics.Windows.DataPresenter.RecordExportStatus Status
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.RecordExportStatus)base.GetValue(global::Infragistics.Windows.DataPresenter.RecordExportStatusControl.StatusProperty);
			}
			internal set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.RecordExportStatusControl.StatusPropertyKey, value);
			}
		}

		// Token: 0x04000543 RID: 1347
		public static readonly global::System.Windows.ResourceKey CancelExportButtonStyleKey = new global::Infragistics.Windows.Themes.StaticPropertyResourceKey(typeof(global::Infragistics.Windows.DataPresenter.RecordExportStatusControl), "CancelExportButtonStyleKey");

		// Token: 0x04000544 RID: 1348
		public static readonly global::System.Windows.DependencyProperty DataPresenterProperty = global::System.Windows.DependencyProperty.Register("DataPresenter", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase), typeof(global::Infragistics.Windows.DataPresenter.RecordExportStatusControl), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.RecordExportStatusControl.OnDataPresenterChanged)));

		// Token: 0x04000545 RID: 1349
		private static readonly global::System.Windows.DependencyPropertyKey ExportInfoPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("ExportInfo", typeof(global::Infragistics.Windows.DataPresenter.ExportInfo), typeof(global::Infragistics.Windows.DataPresenter.RecordExportStatusControl), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000546 RID: 1350
		public static readonly global::System.Windows.DependencyProperty ExportInfoProperty = global::Infragistics.Windows.DataPresenter.RecordExportStatusControl.ExportInfoPropertyKey.DependencyProperty;

		// Token: 0x04000547 RID: 1351
		private static readonly global::System.Windows.DependencyPropertyKey ExportedRecordCountPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("ExportedRecordCount", typeof(int), typeof(global::Infragistics.Windows.DataPresenter.RecordExportStatusControl), new global::System.Windows.FrameworkPropertyMetadata(0));

		// Token: 0x04000548 RID: 1352
		public static readonly global::System.Windows.DependencyProperty ExportedRecordCountProperty = global::Infragistics.Windows.DataPresenter.RecordExportStatusControl.ExportedRecordCountPropertyKey.DependencyProperty;

		// Token: 0x04000549 RID: 1353
		public static readonly global::System.Windows.ResourceKey IndeterminateProgressBarStyleKey = new global::Infragistics.Windows.Themes.StaticPropertyResourceKey(typeof(global::Infragistics.Windows.DataPresenter.RecordExportStatusControl), "IndeterminateProgressBarStyleKey");

		// Token: 0x0400054A RID: 1354
		private static readonly global::System.Windows.DependencyPropertyKey StatusPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("Status", typeof(global::Infragistics.Windows.DataPresenter.RecordExportStatus), typeof(global::Infragistics.Windows.DataPresenter.RecordExportStatusControl), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.RecordExportStatus.NotExporting));

		// Token: 0x0400054B RID: 1355
		public static readonly global::System.Windows.DependencyProperty StatusProperty = global::Infragistics.Windows.DataPresenter.RecordExportStatusControl.StatusPropertyKey.DependencyProperty;
	}
}
