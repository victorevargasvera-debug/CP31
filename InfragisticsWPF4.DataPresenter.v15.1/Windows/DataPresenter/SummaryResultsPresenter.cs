using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using Infragistics.Collections;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020001D7 RID: 471
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class SummaryResultsPresenter : global::System.Windows.Controls.Control
	{
		// Token: 0x06001C13 RID: 7187 RVA: 0x0007EC64 File Offset: 0x0007CE64
		static SummaryResultsPresenter()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.SummaryResultsPresenter), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.DataPresenter.SummaryResultsPresenter)));
			global::System.Windows.UIElement.FocusableProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.SummaryResultsPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));
			global::System.Windows.UIElement.ClipProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.SummaryResultsPresenter), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel.CoerceCellClip)));
			global::System.Windows.UIElement.VisibilityProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.SummaryResultsPresenter), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DataPresenter.GridUtilities.CoerceFieldElementVisibility)));
		}

		// Token: 0x06001C15 RID: 7189 RVA: 0x0007EDB8 File Offset: 0x0007CFB8
		protected override void OnPropertyChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			base.OnPropertyChanged(e);
			bool flag = false;
			if (global::System.Windows.FrameworkElement.DataContextProperty == e.Property)
			{
				flag = true;
			}
			else if (global::Infragistics.Windows.DataPresenter.DataItemPresenter.FieldProperty == e.Property)
			{
				flag = true;
			}
			if (flag)
			{
				global::Infragistics.Windows.DataPresenter.Field field = (global::Infragistics.Windows.DataPresenter.Field)base.GetValue(global::Infragistics.Windows.DataPresenter.DataItemPresenter.FieldProperty);
				if (field != null)
				{
					global::Infragistics.Windows.DataPresenter.SummaryRecord summaryRecord = base.DataContext as global::Infragistics.Windows.DataPresenter.SummaryRecord;
					global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.SummaryResult> summaryResults = (summaryRecord != null) ? summaryRecord.GetFixedSummaryResults(field, true) : null;
					this.SummaryResults = summaryResults;
				}
			}
		}

		// Token: 0x06001C16 RID: 7190 RVA: 0x0007EE2C File Offset: 0x0007D02C
		private static void OnSummaryResultsChanged(global::System.Windows.DependencyObject sender, global::System.Windows.DependencyPropertyChangedEventArgs args)
		{
			global::Infragistics.Windows.DataPresenter.SummaryResultsPresenter summaryResultsPresenter = (global::Infragistics.Windows.DataPresenter.SummaryResultsPresenter)sender;
			global::System.Collections.Specialized.INotifyCollectionChanged notifyCollectionChanged = args.OldValue as global::System.Collections.Specialized.INotifyCollectionChanged;
			global::System.Collections.Specialized.INotifyCollectionChanged notifyCollectionChanged2 = args.NewValue as global::System.Collections.Specialized.INotifyCollectionChanged;
			if (notifyCollectionChanged != null)
			{
				notifyCollectionChanged.CollectionChanged -= summaryResultsPresenter.OnSummaryResultsCollectionChanged;
			}
			if (notifyCollectionChanged2 != null)
			{
				notifyCollectionChanged2.CollectionChanged += summaryResultsPresenter.OnSummaryResultsCollectionChanged;
			}
			if (summaryResultsPresenter._cachedSummaryResultEntries == null)
			{
				global::Infragistics.Collections.ObservableCollectionExtended<global::Infragistics.Windows.DataPresenter.SummaryResultEntry> value = summaryResultsPresenter._cachedSummaryResultEntries = new global::Infragistics.Collections.ObservableCollectionExtended<global::Infragistics.Windows.DataPresenter.SummaryResultEntry>();
				summaryResultsPresenter.SetValue(global::Infragistics.Windows.DataPresenter.SummaryResultsPresenter.SummaryResultEntriesPropertyKey, value);
			}
			summaryResultsPresenter.UpdateEntries();
		}

		// Token: 0x06001C17 RID: 7191 RVA: 0x0007EEAD File Offset: 0x0007D0AD
		private void OnSummaryResultsCollectionChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			this.UpdateEntries();
		}

		// Token: 0x06001C18 RID: 7192 RVA: 0x0007EEB8 File Offset: 0x0007D0B8
		private void UpdateEntries()
		{
			global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.SummaryResult> summaryResults = this.SummaryResults;
			global::Infragistics.Collections.ObservableCollectionExtended<global::Infragistics.Windows.DataPresenter.SummaryResultEntry> cachedSummaryResultEntries = this._cachedSummaryResultEntries;
			bool flag = false;
			try
			{
				int num = 0;
				if (summaryResults != null)
				{
					foreach (global::Infragistics.Windows.DataPresenter.SummaryResult summaryResult in summaryResults)
					{
						if (num == cachedSummaryResultEntries.Count)
						{
							if (!flag)
							{
								cachedSummaryResultEntries.BeginUpdate();
								flag = true;
							}
							cachedSummaryResultEntries.Add(new global::Infragistics.Windows.DataPresenter.SummaryResultEntry());
						}
						cachedSummaryResultEntries[num].SummaryResult = summaryResult;
						num++;
					}
				}
				if (num < cachedSummaryResultEntries.Count)
				{
					if (!flag)
					{
						cachedSummaryResultEntries.BeginUpdate();
						flag = true;
					}
					cachedSummaryResultEntries.RemoveRange(num, cachedSummaryResultEntries.Count - num);
				}
			}
			finally
			{
				if (flag)
				{
					cachedSummaryResultEntries.EndUpdate();
				}
				double num2 = 0.0;
				if (cachedSummaryResultEntries.Count > 0)
				{
					global::Infragistics.Windows.DataPresenter.SummaryResultEntry summaryResultEntry = cachedSummaryResultEntries[0];
					global::Infragistics.Windows.DataPresenter.Field positionFieldResolved = summaryResultEntry.SummaryResult.PositionFieldResolved;
					if (positionFieldResolved != null && positionFieldResolved.Owner.IsTreeView && positionFieldResolved.IsTreeViewExpander)
					{
						global::Infragistics.Windows.DataPresenter.RecordCollectionBase records = summaryResultEntry.SummaryResult.ParentCollection.Records;
						global::Infragistics.Windows.DataPresenter.Record record = (records != null && records.Count > 0) ? records[0] : null;
						if (record != null)
						{
							global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = record.DataPresenter;
							int nestingDepthOfDataRcds = record.NestingDepthOfDataRcds;
							num2 = dataPresenter.DefaultFieldLayout.ExpansionIndicatorSize.Width + dataPresenter.CurrentViewInternal.LevelIndentationResolved * (double)nestingDepthOfDataRcds;
						}
					}
				}
				if (num2 > 0.0)
				{
					base.SetValue(global::Infragistics.Windows.DataPresenter.SummaryResultsPresenter.TreeLineOffsetPropertyKey, new global::System.Windows.Thickness(num2, 0.0, 0.0, 0.0));
				}
				else
				{
					base.ClearValue(global::Infragistics.Windows.DataPresenter.SummaryResultsPresenter.TreeLineOffsetPropertyKey);
				}
			}
		}

		// Token: 0x170007E2 RID: 2018
		// (get) Token: 0x06001C19 RID: 7193 RVA: 0x0007F0A0 File Offset: 0x0007D2A0
		// (set) Token: 0x06001C1A RID: 7194 RVA: 0x0007F0B2 File Offset: 0x0007D2B2
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.SummaryResult> SummaryResults
		{
			get
			{
				return (global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.SummaryResult>)base.GetValue(global::Infragistics.Windows.DataPresenter.SummaryResultsPresenter.SummaryResultsProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.SummaryResultsPresenter.SummaryResultsProperty, value);
			}
		}

		// Token: 0x170007E3 RID: 2019
		// (get) Token: 0x06001C1B RID: 7195 RVA: 0x0007F0C0 File Offset: 0x0007D2C0
		public global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.SummaryResultEntry> SummaryResultEntries
		{
			get
			{
				return this._cachedSummaryResultEntries;
			}
		}

		// Token: 0x170007E4 RID: 2020
		// (get) Token: 0x06001C1C RID: 7196 RVA: 0x0007F0C8 File Offset: 0x0007D2C8
		public global::System.Windows.Thickness TreeLineOffset
		{
			get
			{
				return (global::System.Windows.Thickness)base.GetValue(global::Infragistics.Windows.DataPresenter.SummaryResultsPresenter.TreeLineOffsetProperty);
			}
		}

		// Token: 0x04000B8F RID: 2959
		private global::Infragistics.Collections.ObservableCollectionExtended<global::Infragistics.Windows.DataPresenter.SummaryResultEntry> _cachedSummaryResultEntries;

		// Token: 0x04000B90 RID: 2960
		public static readonly global::System.Windows.DependencyProperty SummaryResultsProperty = global::System.Windows.DependencyProperty.Register("SummaryResults", typeof(global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.SummaryResult>), typeof(global::Infragistics.Windows.DataPresenter.SummaryResultsPresenter), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.SummaryResultsPresenter.OnSummaryResultsChanged)));

		// Token: 0x04000B91 RID: 2961
		private static readonly global::System.Windows.DependencyPropertyKey SummaryResultEntriesPropertyKey = global::Infragistics.DependencyPropertyUtilities.RegisterReadOnly("SummaryResultEntries", typeof(global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.SummaryResultEntry>), typeof(global::Infragistics.Windows.DataPresenter.SummaryResultsPresenter), null, null);

		// Token: 0x04000B92 RID: 2962
		public static readonly global::System.Windows.DependencyProperty SummaryResultEntriesProperty = global::Infragistics.Windows.DataPresenter.SummaryResultsPresenter.SummaryResultEntriesPropertyKey.DependencyProperty;

		// Token: 0x04000B93 RID: 2963
		private static readonly global::System.Windows.DependencyPropertyKey TreeLineOffsetPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("TreeLineOffset", typeof(global::System.Windows.Thickness), typeof(global::Infragistics.Windows.DataPresenter.SummaryResultsPresenter), new global::System.Windows.FrameworkPropertyMetadata(default(global::System.Windows.Thickness)));

		// Token: 0x04000B94 RID: 2964
		public static readonly global::System.Windows.DependencyProperty TreeLineOffsetProperty = global::Infragistics.Windows.DataPresenter.SummaryResultsPresenter.TreeLineOffsetPropertyKey.DependencyProperty;
	}
}
