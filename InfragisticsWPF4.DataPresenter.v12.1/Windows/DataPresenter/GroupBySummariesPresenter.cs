using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using Infragistics.Windows.Internal;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200019F RID: 415
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class GroupBySummariesPresenter : global::System.Windows.Controls.Control
	{
		// Token: 0x060016F9 RID: 5881 RVA: 0x000659A0 File Offset: 0x00063BA0
		static GroupBySummariesPresenter()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.GroupBySummariesPresenter), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.DataPresenter.GroupBySummariesPresenter)));
			global::System.Windows.UIElement.FocusableProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.GroupBySummariesPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));
		}

		// Token: 0x060016FA RID: 5882 RVA: 0x00065AED File Offset: 0x00063CED
		public GroupBySummariesPresenter()
		{
			this._summariesVersionTracker = new global::Infragistics.Windows.Internal.PropertyValueTracker(this, "GroupByRecord.ChildRecords.SummaryResults.SummaryDefinitions.SummariesVersion", new global::Infragistics.Windows.Internal.PropertyValueTracker.PropertyValueChangedHandler(this.VerifySummaries), true);
		}

		// Token: 0x060016FB RID: 5883 RVA: 0x00065B13 File Offset: 0x00063D13
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();
			global::Infragistics.Windows.DataPresenter.SummaryRecordPresenter.InitializeContentAreaMarginBinding(this, this.GroupByRecord, base.GetType());
		}

		// Token: 0x17000611 RID: 1553
		// (get) Token: 0x060016FC RID: 5884 RVA: 0x00065B2D File Offset: 0x00063D2D
		// (set) Token: 0x060016FD RID: 5885 RVA: 0x00065B3F File Offset: 0x00063D3F
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::System.Windows.Thickness ContentAreaMargins
		{
			get
			{
				return (global::System.Windows.Thickness)base.GetValue(global::Infragistics.Windows.DataPresenter.GroupBySummariesPresenter.ContentAreaMarginsProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.GroupBySummariesPresenter.ContentAreaMarginsProperty, value);
			}
		}

		// Token: 0x17000612 RID: 1554
		// (get) Token: 0x060016FE RID: 5886 RVA: 0x00065B52 File Offset: 0x00063D52
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.ReadOnly(true)]
		public bool DisplaySummariesAsCells
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.GroupBySummariesPresenter.DisplaySummariesAsCellsProperty);
			}
		}

		// Token: 0x17000613 RID: 1555
		// (get) Token: 0x060016FF RID: 5887 RVA: 0x00065B64 File Offset: 0x00063D64
		// (set) Token: 0x06001700 RID: 5888 RVA: 0x00065B76 File Offset: 0x00063D76
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::Infragistics.Windows.DataPresenter.GroupByRecord GroupByRecord
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.GroupByRecord)base.GetValue(global::Infragistics.Windows.DataPresenter.GroupBySummariesPresenter.GroupByRecordProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.GroupBySummariesPresenter.GroupByRecordProperty, value);
			}
		}

		// Token: 0x06001701 RID: 5889 RVA: 0x00065B84 File Offset: 0x00063D84
		private static void OnGroupByRecordChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.GroupBySummariesPresenter groupBySummariesPresenter = (global::Infragistics.Windows.DataPresenter.GroupBySummariesPresenter)dependencyObject;
			global::Infragistics.Windows.DataPresenter.SummaryRecord dataContext = null;
			global::Infragistics.Windows.DataPresenter.GroupByRecord groupByRecord = e.NewValue as global::Infragistics.Windows.DataPresenter.GroupByRecord;
			if (groupByRecord != null)
			{
				dataContext = groupByRecord.CreateSummaryRecord();
			}
			groupBySummariesPresenter.DataContext = dataContext;
			global::Infragistics.Windows.DataPresenter.SummaryRecordPresenter.InitializeContentAreaMarginBinding(groupBySummariesPresenter, groupBySummariesPresenter.GroupByRecord, groupBySummariesPresenter.GetType());
			groupBySummariesPresenter.VerifySummaries();
		}

		// Token: 0x17000614 RID: 1556
		// (get) Token: 0x06001702 RID: 5890 RVA: 0x00065BD0 File Offset: 0x00063DD0
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		public bool HasSummaries
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.GroupBySummariesPresenter.HasSummariesProperty);
			}
		}

		// Token: 0x17000615 RID: 1557
		// (get) Token: 0x06001703 RID: 5891 RVA: 0x00065BE2 File Offset: 0x00063DE2
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.SummaryResult> SummaryResults
		{
			get
			{
				return (global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.SummaryResult>)base.GetValue(global::Infragistics.Windows.DataPresenter.GroupBySummariesPresenter.SummaryResultsProperty);
			}
		}

		// Token: 0x06001704 RID: 5892 RVA: 0x00065BF4 File Offset: 0x00063DF4
		private void VerifySummaries()
		{
			global::Infragistics.Windows.DataPresenter.GroupByRecord groupByRecord = this.GroupByRecord;
			global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.SummaryResult> enumerable = (groupByRecord != null) ? groupByRecord.GetSummaryResults() : null;
			bool flag = false;
			global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = (groupByRecord != null) ? groupByRecord.FieldLayout : null;
			if (fieldLayout != null)
			{
				global::Infragistics.Windows.DataPresenter.GroupBySummaryDisplayMode groupBySummaryDisplayModeResolved = fieldLayout.GroupBySummaryDisplayModeResolved;
				if (global::Infragistics.Windows.DataPresenter.GroupBySummaryDisplayMode.SummaryCellsAlwaysBelowDescription == groupBySummaryDisplayModeResolved)
				{
					flag = true;
				}
			}
			this._propertyChangeTrackers = new global::System.Collections.ArrayList();
			bool flag2 = false;
			if (enumerable != null)
			{
				foreach (global::Infragistics.Windows.DataPresenter.SummaryResult source in enumerable)
				{
					flag2 = true;
					global::Infragistics.Windows.Internal.PropertyValueTracker propertyValueTracker = new global::Infragistics.Windows.Internal.PropertyValueTracker(source, "DataVersion", new global::Infragistics.Windows.Internal.PropertyValueTracker.PropertyValueChangedHandler(this.VerifySummaryCalculations), true);
					propertyValueTracker.ThrottleTime = 250;
					propertyValueTracker.ThrottleFirstInvoke = true;
					this._propertyChangeTrackers.Add(propertyValueTracker);
					if (groupByRecord != null)
					{
						propertyValueTracker = new global::Infragistics.Windows.Internal.PropertyValueTracker(source, "DisplayText", new global::Infragistics.Windows.Internal.PropertyValueTracker.PropertyValueChangedHandler(groupByRecord.DirtyDescriptionWithSummaries), true);
						propertyValueTracker.ThrottleTime = 250;
						propertyValueTracker.ThrottleFirstInvoke = true;
						this._propertyChangeTrackers.Add(propertyValueTracker);
						propertyValueTracker = new global::Infragistics.Windows.Internal.PropertyValueTracker(source, "PositionFieldResolved.VisibilityResolved", new global::Infragistics.Windows.Internal.PropertyValueTracker.PropertyValueChangedHandler(groupByRecord.DirtyDescriptionWithSummaries), true);
						propertyValueTracker.ThrottleTime = 250;
						propertyValueTracker.ThrottleFirstInvoke = true;
						this._propertyChangeTrackers.Add(propertyValueTracker);
					}
				}
			}
			base.SetValue(global::Infragistics.Windows.DataPresenter.GroupBySummariesPresenter.SummaryResultsPropertyKey, enumerable);
			base.SetValue(global::Infragistics.Windows.DataPresenter.GroupBySummariesPresenter.HasSummariesPropertyKey, flag2);
			base.SetValue(global::Infragistics.Windows.DataPresenter.GroupBySummariesPresenter.DisplaySummariesAsCellsPropertyKey, flag);
			this.VerifySummaryCalculations();
			global::Infragistics.Windows.DataPresenter.GroupByRecordPresenter groupByRecordPresenter = (global::Infragistics.Windows.DataPresenter.GroupByRecordPresenter)global::Infragistics.Windows.Utilities.GetAncestorFromType(this, typeof(global::Infragistics.Windows.DataPresenter.GroupByRecordPresenter), true);
			if (groupByRecordPresenter != null)
			{
				groupByRecordPresenter.UpdateShouldDisplaySummaries();
			}
		}

		// Token: 0x06001705 RID: 5893 RVA: 0x00065DA0 File Offset: 0x00063FA0
		private void VerifySummaryCalculations()
		{
			global::Infragistics.Windows.DataPresenter.GroupByRecord groupByRecord = this.GroupByRecord;
			global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.SummaryResult> summaryResults = this.SummaryResults;
			if (summaryResults != null)
			{
				foreach (global::Infragistics.Windows.DataPresenter.SummaryResult summaryResult in summaryResults)
				{
					summaryResult.EnsureCalculated();
				}
			}
			if (groupByRecord != null)
			{
				groupByRecord.DirtyDescriptionWithSummaries();
			}
		}

		// Token: 0x040008F8 RID: 2296
		private global::Infragistics.Windows.Internal.PropertyValueTracker _summariesVersionTracker;

		// Token: 0x040008F9 RID: 2297
		private global::System.Collections.ArrayList _propertyChangeTrackers;

		// Token: 0x040008FA RID: 2298
		public static readonly global::System.Windows.DependencyProperty ContentAreaMarginsProperty = global::Infragistics.Windows.DataPresenter.SummaryRecordPresenter.ContentAreaMarginsProperty.AddOwner(typeof(global::Infragistics.Windows.DataPresenter.GroupBySummariesPresenter));

		// Token: 0x040008FB RID: 2299
		private static readonly global::System.Windows.DependencyPropertyKey DisplaySummariesAsCellsPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("DisplaySummariesAsCells", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.GroupBySummariesPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x040008FC RID: 2300
		public static readonly global::System.Windows.DependencyProperty DisplaySummariesAsCellsProperty = global::Infragistics.Windows.DataPresenter.GroupBySummariesPresenter.DisplaySummariesAsCellsPropertyKey.DependencyProperty;

		// Token: 0x040008FD RID: 2301
		public static readonly global::System.Windows.DependencyProperty GroupByRecordProperty = global::System.Windows.DependencyProperty.Register("GroupByRecord", typeof(global::Infragistics.Windows.DataPresenter.GroupByRecord), typeof(global::Infragistics.Windows.DataPresenter.GroupBySummariesPresenter), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.None, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.GroupBySummariesPresenter.OnGroupByRecordChanged)));

		// Token: 0x040008FE RID: 2302
		private static readonly global::System.Windows.DependencyPropertyKey HasSummariesPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("HasSummaries", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.GroupBySummariesPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x040008FF RID: 2303
		public static readonly global::System.Windows.DependencyProperty HasSummariesProperty = global::Infragistics.Windows.DataPresenter.GroupBySummariesPresenter.HasSummariesPropertyKey.DependencyProperty;

		// Token: 0x04000900 RID: 2304
		private static readonly global::System.Windows.DependencyPropertyKey SummaryResultsPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("SummaryResults", typeof(global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.SummaryResult>), typeof(global::Infragistics.Windows.DataPresenter.GroupBySummariesPresenter), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000901 RID: 2305
		public static readonly global::System.Windows.DependencyProperty SummaryResultsProperty = global::Infragistics.Windows.DataPresenter.GroupBySummariesPresenter.SummaryResultsPropertyKey.DependencyProperty;
	}
}
