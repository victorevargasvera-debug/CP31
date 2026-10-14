using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using Infragistics.Windows.Automation.Peers.DataPresenter;
using Infragistics.Windows.Themes;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200011E RID: 286
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class RecordExportStatusControl : global::System.Windows.Controls.Control
	{
		// Token: 0x06001108 RID: 4360 RVA: 0x0004BA5C File Offset: 0x00049C5C
		static RecordExportStatusControl()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.RecordExportStatusControl), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.DataPresenter.RecordExportStatusControl)));
		}

		// Token: 0x0600110A RID: 4362 RVA: 0x0004BBAD File Offset: 0x00049DAD
		protected override global::System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
		{
			return new global::Infragistics.Windows.Automation.Peers.DataPresenter.RecordExportStatusControlAutomationPeer(this);
		}

		// Token: 0x0600110B RID: 4363 RVA: 0x0004BBB8 File Offset: 0x00049DB8
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

		// Token: 0x1700042E RID: 1070
		// (get) Token: 0x0600110C RID: 4364 RVA: 0x0004BC04 File Offset: 0x00049E04
		// (set) Token: 0x0600110D RID: 4365 RVA: 0x0004BC16 File Offset: 0x00049E16
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

		// Token: 0x1700042F RID: 1071
		// (get) Token: 0x0600110E RID: 4366 RVA: 0x0004BC24 File Offset: 0x00049E24
		// (set) Token: 0x0600110F RID: 4367 RVA: 0x0004BC36 File Offset: 0x00049E36
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
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

		// Token: 0x17000430 RID: 1072
		// (get) Token: 0x06001110 RID: 4368 RVA: 0x0004BC44 File Offset: 0x00049E44
		// (set) Token: 0x06001111 RID: 4369 RVA: 0x0004BC56 File Offset: 0x00049E56
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

		// Token: 0x17000431 RID: 1073
		// (get) Token: 0x06001112 RID: 4370 RVA: 0x0004BC69 File Offset: 0x00049E69
		// (set) Token: 0x06001113 RID: 4371 RVA: 0x0004BC7B File Offset: 0x00049E7B
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

		// Token: 0x040006E2 RID: 1762
		public static readonly global::System.Windows.ResourceKey CancelExportButtonStyleKey = new global::Infragistics.Windows.Themes.StaticPropertyResourceKey(typeof(global::Infragistics.Windows.DataPresenter.RecordExportStatusControl), "CancelExportButtonStyleKey");

		// Token: 0x040006E3 RID: 1763
		public static readonly global::System.Windows.DependencyProperty DataPresenterProperty = global::System.Windows.DependencyProperty.Register("DataPresenter", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase), typeof(global::Infragistics.Windows.DataPresenter.RecordExportStatusControl), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.RecordExportStatusControl.OnDataPresenterChanged)));

		// Token: 0x040006E4 RID: 1764
		private static readonly global::System.Windows.DependencyPropertyKey ExportInfoPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("ExportInfo", typeof(global::Infragistics.Windows.DataPresenter.ExportInfo), typeof(global::Infragistics.Windows.DataPresenter.RecordExportStatusControl), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x040006E5 RID: 1765
		public static readonly global::System.Windows.DependencyProperty ExportInfoProperty = global::Infragistics.Windows.DataPresenter.RecordExportStatusControl.ExportInfoPropertyKey.DependencyProperty;

		// Token: 0x040006E6 RID: 1766
		private static readonly global::System.Windows.DependencyPropertyKey ExportedRecordCountPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("ExportedRecordCount", typeof(int), typeof(global::Infragistics.Windows.DataPresenter.RecordExportStatusControl), new global::System.Windows.FrameworkPropertyMetadata(0));

		// Token: 0x040006E7 RID: 1767
		public static readonly global::System.Windows.DependencyProperty ExportedRecordCountProperty = global::Infragistics.Windows.DataPresenter.RecordExportStatusControl.ExportedRecordCountPropertyKey.DependencyProperty;

		// Token: 0x040006E8 RID: 1768
		public static readonly global::System.Windows.ResourceKey IndeterminateProgressBarStyleKey = new global::Infragistics.Windows.Themes.StaticPropertyResourceKey(typeof(global::Infragistics.Windows.DataPresenter.RecordExportStatusControl), "IndeterminateProgressBarStyleKey");

		// Token: 0x040006E9 RID: 1769
		private static readonly global::System.Windows.DependencyPropertyKey StatusPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("Status", typeof(global::Infragistics.Windows.DataPresenter.RecordExportStatus), typeof(global::Infragistics.Windows.DataPresenter.RecordExportStatusControl), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.RecordExportStatus.NotExporting));

		// Token: 0x040006EA RID: 1770
		public static readonly global::System.Windows.DependencyProperty StatusProperty = global::Infragistics.Windows.DataPresenter.RecordExportStatusControl.StatusPropertyKey.DependencyProperty;
	}
}
