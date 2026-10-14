using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using Infragistics.Windows.Internal;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020001A9 RID: 425
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class SummaryRecordContentArea : global::System.Windows.Controls.Control
	{
		// Token: 0x06001763 RID: 5987 RVA: 0x00067540 File Offset: 0x00065740
		static SummaryRecordContentArea()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.SummaryRecordContentArea), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.DataPresenter.SummaryRecordContentArea)));
			global::System.Windows.UIElement.FocusableProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.SummaryRecordContentArea), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));
			global::System.Windows.Controls.Control.HorizontalContentAlignmentProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.SummaryRecordContentArea), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.HorizontalAlignmentStretchBox));
		}

		// Token: 0x06001764 RID: 5988 RVA: 0x000676EA File Offset: 0x000658EA
		public SummaryRecordContentArea()
		{
			this._summaryDefinitionsTracker = new global::Infragistics.Windows.Internal.PropertyValueTracker(this, "SummaryRecord.FieldLayout.SummaryDefinitions.SummariesVersion", new global::Infragistics.Windows.Internal.PropertyValueTracker.PropertyValueChangedHandler(this.OnSummariesChanged), true);
		}

		// Token: 0x06001765 RID: 5989 RVA: 0x00067710 File Offset: 0x00065910
		protected override void OnPropertyChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			base.OnPropertyChanged(e);
			global::System.Windows.DependencyProperty property = e.Property;
			if (global::System.Windows.FrameworkElement.DataContextProperty == property)
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.SummaryRecordContentArea.SummaryRecordPropertyKey, e.NewValue as global::Infragistics.Windows.DataPresenter.SummaryRecord);
				this.OnSummariesChanged();
			}
		}

		// Token: 0x1700062E RID: 1582
		// (get) Token: 0x06001766 RID: 5990 RVA: 0x00067751 File Offset: 0x00065951
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		public global::Infragistics.Windows.DataPresenter.SummaryRecord SummaryRecord
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.SummaryRecord)base.GetValue(global::Infragistics.Windows.DataPresenter.SummaryRecordContentArea.SummaryRecordProperty);
			}
		}

		// Token: 0x1700062F RID: 1583
		// (get) Token: 0x06001767 RID: 5991 RVA: 0x00067763 File Offset: 0x00065963
		// (set) Token: 0x06001768 RID: 5992 RVA: 0x00067775 File Offset: 0x00065975
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Bindable(true)]
		public bool HasSummariesInCellArea
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.SummaryRecordContentArea.HasSummariesInCellAreaProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.SummaryRecordContentArea.HasSummariesInCellAreaProperty, value);
			}
		}

		// Token: 0x17000630 RID: 1584
		// (get) Token: 0x06001769 RID: 5993 RVA: 0x00067788 File Offset: 0x00065988
		// (set) Token: 0x0600176A RID: 5994 RVA: 0x0006779A File Offset: 0x0006599A
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::System.Windows.Visibility SummaryRecordHeaderVisibility
		{
			get
			{
				return (global::System.Windows.Visibility)base.GetValue(global::Infragistics.Windows.DataPresenter.SummaryRecordContentArea.SummaryRecordHeaderVisibilityProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.SummaryRecordContentArea.SummaryRecordHeaderVisibilityProperty, value);
			}
		}

		// Token: 0x17000631 RID: 1585
		// (get) Token: 0x0600176B RID: 5995 RVA: 0x000677AD File Offset: 0x000659AD
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Browsable(false)]
		public global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.SummaryResult> SummaryResultsCenter
		{
			get
			{
				return (global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.SummaryResult>)base.GetValue(global::Infragistics.Windows.DataPresenter.SummaryRecordContentArea.SummaryResultsCenterProperty);
			}
		}

		// Token: 0x17000632 RID: 1586
		// (get) Token: 0x0600176C RID: 5996 RVA: 0x000677BF File Offset: 0x000659BF
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.ReadOnly(true)]
		public global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.SummaryResult> SummaryResultsLeft
		{
			get
			{
				return (global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.SummaryResult>)base.GetValue(global::Infragistics.Windows.DataPresenter.SummaryRecordContentArea.SummaryResultsLeftProperty);
			}
		}

		// Token: 0x17000633 RID: 1587
		// (get) Token: 0x0600176D RID: 5997 RVA: 0x000677D1 File Offset: 0x000659D1
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.ReadOnly(true)]
		public global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.SummaryResult> SummaryResultsRight
		{
			get
			{
				return (global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.SummaryResult>)base.GetValue(global::Infragistics.Windows.DataPresenter.SummaryRecordContentArea.SummaryResultsRightProperty);
			}
		}

		// Token: 0x0600176E RID: 5998 RVA: 0x000677E4 File Offset: 0x000659E4
		private void OnSummariesChanged()
		{
			global::Infragistics.Windows.DataPresenter.SummaryRecord summaryRecord = this.SummaryRecord;
			if (summaryRecord != null)
			{
				summaryRecord.VerifySummaryResults();
				base.SetValue(global::Infragistics.Windows.DataPresenter.SummaryRecordContentArea.SummaryResultsLeftPropertyKey, summaryRecord.GetFreeFormSummaryResults(global::Infragistics.Windows.DataPresenter.SummaryPosition.Left));
				base.SetValue(global::Infragistics.Windows.DataPresenter.SummaryRecordContentArea.SummaryResultsCenterPropertyKey, summaryRecord.GetFreeFormSummaryResults(global::Infragistics.Windows.DataPresenter.SummaryPosition.Center));
				base.SetValue(global::Infragistics.Windows.DataPresenter.SummaryRecordContentArea.SummaryResultsRightPropertyKey, summaryRecord.GetFreeFormSummaryResults(global::Infragistics.Windows.DataPresenter.SummaryPosition.Right));
				base.SetValue(global::Infragistics.Windows.DataPresenter.SummaryRecordContentArea.SummaryRecordHeaderVisibilityProperty, summaryRecord.SummaryRecordHeaderVisibilityResolved);
				base.SetValue(global::Infragistics.Windows.DataPresenter.SummaryRecordContentArea.HasSummariesInCellAreaProperty, summaryRecord.HasFixedSummaryResults());
				summaryRecord.ClearSizeToContentManager();
			}
			else
			{
				base.ClearValue(global::Infragistics.Windows.DataPresenter.SummaryRecordContentArea.SummaryResultsLeftPropertyKey);
				base.ClearValue(global::Infragistics.Windows.DataPresenter.SummaryRecordContentArea.SummaryResultsCenterPropertyKey);
				base.ClearValue(global::Infragistics.Windows.DataPresenter.SummaryRecordContentArea.SummaryResultsRightPropertyKey);
				base.ClearValue(global::Infragistics.Windows.DataPresenter.SummaryRecordContentArea.SummaryRecordHeaderVisibilityProperty);
				base.ClearValue(global::Infragistics.Windows.DataPresenter.SummaryRecordContentArea.HasSummariesInCellAreaProperty);
			}
			object target = this._summaryDefinitionsTracker.Target;
			int num = (target is int) ? ((int)target) : -1;
			if (this._lastSummaryDefinitionCollection_Version != num)
			{
				this._lastSummaryDefinitionCollection_Version = num;
				global::Infragistics.Windows.DataPresenter.VirtualizingSummaryCellPanel virtualizingSummaryCellPanel = (global::Infragistics.Windows.DataPresenter.VirtualizingSummaryCellPanel)global::Infragistics.Windows.Utilities.GetDescendantFromType(this, typeof(global::Infragistics.Windows.DataPresenter.VirtualizingSummaryCellPanel), true);
				if (virtualizingSummaryCellPanel != null)
				{
					virtualizingSummaryCellPanel.DirtyCellElements(true);
				}
			}
		}

		// Token: 0x0400091A RID: 2330
		private global::Infragistics.Windows.Internal.PropertyValueTracker _summaryDefinitionsTracker;

		// Token: 0x0400091B RID: 2331
		private int _lastSummaryDefinitionCollection_Version;

		// Token: 0x0400091C RID: 2332
		private static readonly global::System.Windows.DependencyPropertyKey SummaryRecordPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("SummaryRecord", typeof(global::Infragistics.Windows.DataPresenter.SummaryRecord), typeof(global::Infragistics.Windows.DataPresenter.SummaryRecordContentArea), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x0400091D RID: 2333
		public static readonly global::System.Windows.DependencyProperty SummaryRecordProperty = global::Infragistics.Windows.DataPresenter.SummaryRecordContentArea.SummaryRecordPropertyKey.DependencyProperty;

		// Token: 0x0400091E RID: 2334
		public static readonly global::System.Windows.DependencyProperty HasSummariesInCellAreaProperty = global::System.Windows.DependencyProperty.Register("HasSummariesInCellArea", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.SummaryRecordContentArea), new global::System.Windows.FrameworkPropertyMetadata(false, global::System.Windows.FrameworkPropertyMetadataOptions.None, null));

		// Token: 0x0400091F RID: 2335
		public static readonly global::System.Windows.DependencyProperty SummaryRecordHeaderVisibilityProperty = global::System.Windows.DependencyProperty.Register("SummaryRecordHeaderVisibility", typeof(global::System.Windows.Visibility), typeof(global::Infragistics.Windows.DataPresenter.SummaryRecordContentArea), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Visibility.Collapsed));

		// Token: 0x04000920 RID: 2336
		private static readonly global::System.Windows.DependencyPropertyKey SummaryResultsCenterPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("SummaryResultsCenter", typeof(global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.SummaryResult>), typeof(global::Infragistics.Windows.DataPresenter.SummaryRecordContentArea), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000921 RID: 2337
		public static readonly global::System.Windows.DependencyProperty SummaryResultsCenterProperty = global::Infragistics.Windows.DataPresenter.SummaryRecordContentArea.SummaryResultsCenterPropertyKey.DependencyProperty;

		// Token: 0x04000922 RID: 2338
		private static readonly global::System.Windows.DependencyPropertyKey SummaryResultsLeftPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("SummaryResultsLeft", typeof(global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.SummaryResult>), typeof(global::Infragistics.Windows.DataPresenter.SummaryRecordContentArea), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000923 RID: 2339
		public static readonly global::System.Windows.DependencyProperty SummaryResultsLeftProperty = global::Infragistics.Windows.DataPresenter.SummaryRecordContentArea.SummaryResultsLeftPropertyKey.DependencyProperty;

		// Token: 0x04000924 RID: 2340
		private static readonly global::System.Windows.DependencyPropertyKey SummaryResultsRightPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("SummaryResultsRight", typeof(global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.SummaryResult>), typeof(global::Infragistics.Windows.DataPresenter.SummaryRecordContentArea), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000925 RID: 2341
		public static readonly global::System.Windows.DependencyProperty SummaryResultsRightProperty = global::Infragistics.Windows.DataPresenter.SummaryRecordContentArea.SummaryResultsRightPropertyKey.DependencyProperty;
	}
}
