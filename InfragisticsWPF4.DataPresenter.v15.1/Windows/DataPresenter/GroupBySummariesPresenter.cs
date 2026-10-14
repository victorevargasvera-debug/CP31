using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using Infragistics.Windows.Internal;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020001C2 RID: 450
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class GroupBySummariesPresenter : global::System.Windows.Controls.Control
	{
		// Token: 0x06001AB6 RID: 6838 RVA: 0x000784D8 File Offset: 0x000766D8
		static GroupBySummariesPresenter()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.GroupBySummariesPresenter), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.DataPresenter.GroupBySummariesPresenter)));
			global::System.Windows.UIElement.FocusableProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.GroupBySummariesPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));
		}

		// Token: 0x06001AB7 RID: 6839 RVA: 0x00078625 File Offset: 0x00076825
		public GroupBySummariesPresenter()
		{
			this._summariesVersionTracker = new global::Infragistics.Windows.Internal.PropertyValueTracker(this, "GroupByRecord.ChildRecords.SummaryResults.SummaryDefinitions.SummariesVersion", new global::Infragistics.Windows.Internal.PropertyValueTracker.PropertyValueChangedHandler(this.VerifySummaries), true);
		}

		// Token: 0x06001AB8 RID: 6840 RVA: 0x0007864B File Offset: 0x0007684B
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();
			global::Infragistics.Windows.DataPresenter.SummaryRecordPresenter.InitializeContentAreaMarginBinding(this, this.GroupByRecord, base.GetType());
		}

		// Token: 0x17000773 RID: 1907
		// (get) Token: 0x06001AB9 RID: 6841 RVA: 0x00078665 File Offset: 0x00076865
		// (set) Token: 0x06001ABA RID: 6842 RVA: 0x00078677 File Offset: 0x00076877
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

		// Token: 0x17000774 RID: 1908
		// (get) Token: 0x06001ABB RID: 6843 RVA: 0x0007868A File Offset: 0x0007688A
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Browsable(false)]
		public bool DisplaySummariesAsCells
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.GroupBySummariesPresenter.DisplaySummariesAsCellsProperty);
			}
		}

		// Token: 0x17000775 RID: 1909
		// (get) Token: 0x06001ABC RID: 6844 RVA: 0x0007869C File Offset: 0x0007689C
		// (set) Token: 0x06001ABD RID: 6845 RVA: 0x000786AE File Offset: 0x000768AE
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

		// Token: 0x06001ABE RID: 6846 RVA: 0x000786BC File Offset: 0x000768BC
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

		// Token: 0x17000776 RID: 1910
		// (get) Token: 0x06001ABF RID: 6847 RVA: 0x00078708 File Offset: 0x00076908
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

		// Token: 0x17000777 RID: 1911
		// (get) Token: 0x06001AC0 RID: 6848 RVA: 0x0007871A File Offset: 0x0007691A
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

		// Token: 0x06001AC1 RID: 6849 RVA: 0x0007872C File Offset: 0x0007692C
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
				foreach (global::Infragistics.Windows.DataPresenter.SummaryResult summaryResult in enumerable)
				{
					flag2 = true;
					global::Infragistics.Windows.Internal.PropertyValueTracker propertyValueTracker = new global::Infragistics.Windows.Internal.PropertyValueTracker(summaryResult, "DataVersion", new global::Infragistics.Windows.Internal.PropertyValueTracker.PropertyValueChangedHandler(this.VerifySummaryCalculations), true);
					propertyValueTracker.ThrottleTime = 250;
					propertyValueTracker.ThrottleFirstInvoke = true;
					this._propertyChangeTrackers.Add(propertyValueTracker);
					if (groupByRecord != null)
					{
						bool skipEnsureCalculated = summaryResult.SkipEnsureCalculated;
						summaryResult.SkipEnsureCalculated = true;
						propertyValueTracker = new global::Infragistics.Windows.Internal.PropertyValueTracker(summaryResult, "DisplayText", new global::Infragistics.Windows.Internal.PropertyValueTracker.PropertyValueChangedHandler(groupByRecord.DirtyDescriptionWithSummaries), true);
						summaryResult.SkipEnsureCalculated = skipEnsureCalculated;
						propertyValueTracker.ThrottleTime = 250;
						propertyValueTracker.ThrottleFirstInvoke = true;
						this._propertyChangeTrackers.Add(propertyValueTracker);
						propertyValueTracker = new global::Infragistics.Windows.Internal.PropertyValueTracker(summaryResult, "PositionFieldResolved.VisibilityResolved", new global::Infragistics.Windows.Internal.PropertyValueTracker.PropertyValueChangedHandler(groupByRecord.DirtyDescriptionWithSummaries), true);
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

		// Token: 0x06001AC2 RID: 6850 RVA: 0x000788F4 File Offset: 0x00076AF4
		private void VerifySummaryCalculations()
		{
			global::Infragistics.Windows.DataPresenter.GroupByRecord groupByRecord = this.GroupByRecord;
			global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.SummaryResult> summaryResults = this.SummaryResults;
			if (summaryResults != null)
			{
				bool flag = false;
				global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = groupByRecord.FieldLayout;
				global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenterBase = (fieldLayout != null) ? fieldLayout.DataPresenter : null;
				if (dataPresenterBase != null && fieldLayout.GroupBySummaryDisplayModeResolved != global::Infragistics.Windows.DataPresenter.GroupBySummaryDisplayMode.Text && dataPresenterBase.SummaryCellContainerGenerationMode != global::Infragistics.Windows.DataPresenter.CellContainerGenerationMode.PreLoad)
				{
					flag = true;
				}
				foreach (global::Infragistics.Windows.DataPresenter.SummaryResult summaryResult in summaryResults)
				{
					if (!flag || summaryResult.PositionResolved != global::Infragistics.Windows.DataPresenter.SummaryPosition.UseSummaryPositionField)
					{
						summaryResult.EnsureCalculated();
					}
				}
			}
			if (groupByRecord != null)
			{
				groupByRecord.DirtyDescriptionWithSummaries();
			}
		}

		// Token: 0x04000AC2 RID: 2754
		private global::Infragistics.Windows.Internal.PropertyValueTracker _summariesVersionTracker;

		// Token: 0x04000AC3 RID: 2755
		private global::System.Collections.ArrayList _propertyChangeTrackers;

		// Token: 0x04000AC4 RID: 2756
		public static readonly global::System.Windows.DependencyProperty ContentAreaMarginsProperty = global::Infragistics.Windows.DataPresenter.SummaryRecordPresenter.ContentAreaMarginsProperty.AddOwner(typeof(global::Infragistics.Windows.DataPresenter.GroupBySummariesPresenter));

		// Token: 0x04000AC5 RID: 2757
		private static readonly global::System.Windows.DependencyPropertyKey DisplaySummariesAsCellsPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("DisplaySummariesAsCells", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.GroupBySummariesPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x04000AC6 RID: 2758
		public static readonly global::System.Windows.DependencyProperty DisplaySummariesAsCellsProperty = global::Infragistics.Windows.DataPresenter.GroupBySummariesPresenter.DisplaySummariesAsCellsPropertyKey.DependencyProperty;

		// Token: 0x04000AC7 RID: 2759
		public static readonly global::System.Windows.DependencyProperty GroupByRecordProperty = global::System.Windows.DependencyProperty.Register("GroupByRecord", typeof(global::Infragistics.Windows.DataPresenter.GroupByRecord), typeof(global::Infragistics.Windows.DataPresenter.GroupBySummariesPresenter), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.None, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.GroupBySummariesPresenter.OnGroupByRecordChanged)));

		// Token: 0x04000AC8 RID: 2760
		private static readonly global::System.Windows.DependencyPropertyKey HasSummariesPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("HasSummaries", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.GroupBySummariesPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x04000AC9 RID: 2761
		public static readonly global::System.Windows.DependencyProperty HasSummariesProperty = global::Infragistics.Windows.DataPresenter.GroupBySummariesPresenter.HasSummariesPropertyKey.DependencyProperty;

		// Token: 0x04000ACA RID: 2762
		private static readonly global::System.Windows.DependencyPropertyKey SummaryResultsPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("SummaryResults", typeof(global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.SummaryResult>), typeof(global::Infragistics.Windows.DataPresenter.GroupBySummariesPresenter), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000ACB RID: 2763
		public static readonly global::System.Windows.DependencyProperty SummaryResultsProperty = global::Infragistics.Windows.DataPresenter.GroupBySummariesPresenter.SummaryResultsPropertyKey.DependencyProperty;
	}
}
