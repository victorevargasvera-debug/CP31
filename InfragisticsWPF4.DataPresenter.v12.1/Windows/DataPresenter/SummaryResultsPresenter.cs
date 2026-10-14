using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using Infragistics.Collections;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020001B4 RID: 436
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class SummaryResultsPresenter : global::System.Windows.Controls.Control
	{
		// Token: 0x0600184F RID: 6223 RVA: 0x0006BE9C File Offset: 0x0006A09C
		static SummaryResultsPresenter()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.SummaryResultsPresenter), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.DataPresenter.SummaryResultsPresenter)));
			global::System.Windows.UIElement.FocusableProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.SummaryResultsPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));
			global::System.Windows.UIElement.ClipProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.SummaryResultsPresenter), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel.CoerceCellClip)));
			global::System.Windows.UIElement.VisibilityProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.SummaryResultsPresenter), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DataPresenter.GridUtilities.CoerceFieldElementVisibility)));
		}

		// Token: 0x06001851 RID: 6225 RVA: 0x0006BFA8 File Offset: 0x0006A1A8
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

		// Token: 0x06001852 RID: 6226 RVA: 0x0006C01C File Offset: 0x0006A21C
		private static void OnSummaryResultsChanged(global::System.Windows.DependencyObject sender, global::System.Windows.DependencyPropertyChangedEventArgs args)
		{
			global::Infragistics.Windows.DataPresenter.SummaryResultsPresenter summaryResultsPresenter = (global::Infragistics.Windows.DataPresenter.SummaryResultsPresenter)sender;
			global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.SummaryResult> summaryResults = summaryResultsPresenter.SummaryResults;
			global::Infragistics.Collections.ObservableCollectionExtended<global::Infragistics.Windows.DataPresenter.SummaryResultEntry> observableCollectionExtended = summaryResultsPresenter._cachedSummaryResultEntries;
			if (observableCollectionExtended == null)
			{
				observableCollectionExtended = (summaryResultsPresenter._cachedSummaryResultEntries = new global::Infragistics.Collections.ObservableCollectionExtended<global::Infragistics.Windows.DataPresenter.SummaryResultEntry>());
				summaryResultsPresenter.SetValue(global::Infragistics.Windows.DataPresenter.SummaryResultsPresenter.SummaryResultEntriesPropertyKey, observableCollectionExtended);
			}
			bool flag = false;
			try
			{
				int num = 0;
				if (summaryResults != null)
				{
					foreach (global::Infragistics.Windows.DataPresenter.SummaryResult summaryResult in summaryResults)
					{
						if (num == observableCollectionExtended.Count)
						{
							if (!flag)
							{
								observableCollectionExtended.BeginUpdate();
								flag = true;
							}
							observableCollectionExtended.Add(new global::Infragistics.Windows.DataPresenter.SummaryResultEntry());
						}
						observableCollectionExtended[num].SummaryResult = summaryResult;
						num++;
					}
				}
				if (num < observableCollectionExtended.Count)
				{
					if (!flag)
					{
						observableCollectionExtended.BeginUpdate();
						flag = true;
					}
					observableCollectionExtended.RemoveRange(num, observableCollectionExtended.Count - num);
				}
			}
			finally
			{
				if (flag)
				{
					observableCollectionExtended.EndUpdate();
				}
			}
		}

		// Token: 0x1700067D RID: 1661
		// (get) Token: 0x06001853 RID: 6227 RVA: 0x0006C110 File Offset: 0x0006A310
		// (set) Token: 0x06001854 RID: 6228 RVA: 0x0006C122 File Offset: 0x0006A322
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

		// Token: 0x1700067E RID: 1662
		// (get) Token: 0x06001855 RID: 6229 RVA: 0x0006C130 File Offset: 0x0006A330
		public global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.SummaryResultEntry> SummaryResultEntries
		{
			get
			{
				return this._cachedSummaryResultEntries;
			}
		}

		// Token: 0x040009C1 RID: 2497
		private global::Infragistics.Collections.ObservableCollectionExtended<global::Infragistics.Windows.DataPresenter.SummaryResultEntry> _cachedSummaryResultEntries;

		// Token: 0x040009C2 RID: 2498
		public static readonly global::System.Windows.DependencyProperty SummaryResultsProperty = global::System.Windows.DependencyProperty.Register("SummaryResults", typeof(global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.SummaryResult>), typeof(global::Infragistics.Windows.DataPresenter.SummaryResultsPresenter), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.SummaryResultsPresenter.OnSummaryResultsChanged)));

		// Token: 0x040009C3 RID: 2499
		private static readonly global::System.Windows.DependencyPropertyKey SummaryResultEntriesPropertyKey = global::Infragistics.DependencyPropertyUtilities.RegisterReadOnly("SummaryResultEntries", typeof(global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.SummaryResultEntry>), typeof(global::Infragistics.Windows.DataPresenter.SummaryResultsPresenter), null, null);

		// Token: 0x040009C4 RID: 2500
		public static readonly global::System.Windows.DependencyProperty SummaryResultEntriesProperty = global::Infragistics.Windows.DataPresenter.SummaryResultsPresenter.SummaryResultEntriesPropertyKey.DependencyProperty;
	}
}
