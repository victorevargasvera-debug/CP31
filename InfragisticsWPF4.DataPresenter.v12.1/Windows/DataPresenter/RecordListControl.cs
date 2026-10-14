using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Media;
using Infragistics.AutomationPeers;
using Infragistics.Windows.Automation.Peers.DataPresenter;
using Infragistics.Windows.Controls;
using Infragistics.Windows.DataPresenter.Internal;
using Infragistics.Windows.Virtualization;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000314 RID: 788
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public sealed class RecordListControl : global::Infragistics.Windows.Virtualization.RecyclingItemsControl, global::Infragistics.Windows.Controls.ICarouselPanelSelectionHost
	{
		// Token: 0x060025A1 RID: 9633 RVA: 0x000A1C84 File Offset: 0x0009FE84
		static RecordListControl()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.RecordListControl), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.DataPresenter.RecordListControl)));
			global::System.Windows.Controls.ItemsControl.ItemsSourceProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.RecordListControl), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DataPresenter.RecordListControl.CoerceItemsSource)));
			global::Infragistics.Windows.DataPresenter.GridUtilities.SuppressBringIntoView(typeof(global::Infragistics.Windows.DataPresenter.RecordListControl));
		}

		// Token: 0x060025A2 RID: 9634 RVA: 0x000A1DB4 File Offset: 0x0009FFB4
		internal RecordListControl(global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter, bool isRoot)
		{
			if (dataPresenter == null)
			{
				throw new global::System.ArgumentNullException("dataPresenter", global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_ArgumentNullException_5"));
			}
			this._dataPresenter = dataPresenter;
			if (isRoot)
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.RecordListControl.IsRootPropertyKey, global::Infragistics.KnownBoxes.TrueBox);
			}
			base.SetBinding(global::Infragistics.Windows.Virtualization.RecyclingItemsControl.ItemContainerGenerationModeProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordContainerGenerationModeProperty, global::System.Windows.Data.BindingMode.OneWay, this._dataPresenter));
		}

		// Token: 0x060025A3 RID: 9635 RVA: 0x000A1E18 File Offset: 0x000A0018
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		protected internal override bool? IsStillValid(global::System.Windows.DependencyObject container, object item)
		{
			global::Infragistics.Windows.DataPresenter.Record record = item as global::Infragistics.Windows.DataPresenter.Record;
			global::Infragistics.Windows.DataPresenter.FlatScrollRecordsCollection flatScrollRecordsCollection = base.ItemsSource as global::Infragistics.Windows.DataPresenter.FlatScrollRecordsCollection;
			if (flatScrollRecordsCollection != null)
			{
				return new bool?(flatScrollRecordsCollection.IndexOf(record) >= 0);
			}
			return new bool?(record != null && record.OverallScrollPosition >= 0);
		}

		// Token: 0x060025A4 RID: 9636 RVA: 0x000A1E94 File Offset: 0x000A0094
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();
			global::System.Windows.Controls.ScrollViewer templateChild = global::Infragistics.Windows.Utilities.GetTemplateChild<global::System.Windows.Controls.ScrollViewer>(this, null);
			if (templateChild != null)
			{
				templateChild.ApplyTemplate();
				global::System.Collections.Generic.List<global::System.Windows.Controls.Primitives.ScrollBar> scrollbars = new global::System.Collections.Generic.List<global::System.Windows.Controls.Primitives.ScrollBar>();
				global::Infragistics.Windows.Utilities.DependencyObjectSearchCallback<global::System.Windows.Controls.Primitives.ScrollBar> callback = delegate(global::System.Windows.Controls.Primitives.ScrollBar scrollbar)
				{
					scrollbars.Add(scrollbar);
					return false;
				};
				global::Infragistics.Windows.Utilities.GetTemplateChild<global::System.Windows.Controls.Primitives.ScrollBar>(templateChild, callback);
				foreach (global::System.Windows.Controls.Primitives.ScrollBar scrollBar in scrollbars)
				{
					scrollBar.ApplyTemplate();
					global::System.Collections.Generic.List<global::System.Windows.Controls.Primitives.ButtonBase> buttons = new global::System.Collections.Generic.List<global::System.Windows.Controls.Primitives.ButtonBase>();
					global::Infragistics.Windows.Utilities.DependencyObjectSearchCallback<global::System.Windows.Controls.Primitives.ButtonBase> callback2 = delegate(global::System.Windows.Controls.Primitives.ButtonBase button)
					{
						buttons.Add(button);
						return false;
					};
					global::Infragistics.Windows.Utilities.GetTemplateChild<global::System.Windows.Controls.Primitives.ButtonBase>(scrollBar, callback2);
					foreach (global::System.Windows.Controls.Primitives.ButtonBase button2 in buttons)
					{
						global::Infragistics.Windows.DataPresenter.Internal.RoutedCommandProxy.WireProxy(button2);
					}
				}
			}
		}

		// Token: 0x060025A5 RID: 9637 RVA: 0x000A1FA8 File Offset: 0x000A01A8
		protected override global::System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
		{
			if (this.DataPresenter != null && this.DataPresenter.IsFlatView)
			{
				return new global::Infragistics.Windows.Automation.Peers.DataPresenter.ViewableRecordCollectionAutomationPeer(this, this.DataPresenter.ViewableRecords, true);
			}
			return new global::Infragistics.Windows.Automation.Peers.DataPresenter.RecordListControlAutomationPeer(this);
		}

		// Token: 0x060025A6 RID: 9638 RVA: 0x000A1FD8 File Offset: 0x000A01D8
		protected override void OnItemsChanged(global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			base.OnItemsChanged(e);
			global::System.Windows.Automation.Peers.AutomationPeer automationPeer = global::System.Windows.Automation.Peers.UIElementAutomationPeer.FromElement(this);
			if (automationPeer != null && this.DataPresenter != null && ((this.DataPresenter.IsFlatView && automationPeer is global::Infragistics.Windows.Automation.Peers.DataPresenter.ViewableRecordCollectionAutomationPeer) || (!this.DataPresenter.IsFlatView && automationPeer is global::Infragistics.Windows.Automation.Peers.DataPresenter.RecordListControlAutomationPeer)))
			{
				if (automationPeer is global::Infragistics.Windows.Automation.Peers.DataPresenter.ViewableRecordCollectionAutomationPeer)
				{
					((global::Infragistics.Windows.Automation.Peers.DataPresenter.ViewableRecordCollectionAutomationPeer)automationPeer).InitializeViewableRecordsCollection(this.DataPresenter.ViewableRecords);
				}
				automationPeer.InvalidatePeer();
				global::Infragistics.AutomationPeers.AutomationPeerHelper.InvalidateChildren(automationPeer);
				automationPeer.RaiseAutomationEvent(global::System.Windows.Automation.Peers.AutomationEvents.StructureChanged);
			}
		}

		// Token: 0x060025A7 RID: 9639 RVA: 0x000A205C File Offset: 0x000A025C
		protected override void OnItemsSourceChanged(global::System.Collections.IEnumerable oldValue, global::System.Collections.IEnumerable newValue)
		{
			base.OnItemsSourceChanged(oldValue, newValue);
			global::Infragistics.Windows.DataPresenter.ViewableRecordCollection viewableRecordCollection = oldValue as global::Infragistics.Windows.DataPresenter.ViewableRecordCollection;
			global::Infragistics.Windows.DataPresenter.RecordCollectionBase recordCollectionBase = oldValue as global::Infragistics.Windows.DataPresenter.RecordCollectionBase;
			if (viewableRecordCollection != null && viewableRecordCollection.LastRecordList == this)
			{
				viewableRecordCollection.LastRecordList = null;
			}
			else if (recordCollectionBase != null && recordCollectionBase.LastRecordList == this)
			{
				recordCollectionBase.LastRecordList = null;
			}
			global::Infragistics.Windows.DataPresenter.ViewableRecordCollection viewableRecordCollection2 = newValue as global::Infragistics.Windows.DataPresenter.ViewableRecordCollection;
			global::Infragistics.Windows.DataPresenter.RecordCollectionBase recordCollectionBase2 = newValue as global::Infragistics.Windows.DataPresenter.RecordCollectionBase;
			if (viewableRecordCollection2 != null)
			{
				viewableRecordCollection2.LastRecordList = this;
				return;
			}
			if (recordCollectionBase2 != null)
			{
				recordCollectionBase2.LastRecordList = this;
			}
		}

		// Token: 0x17000B00 RID: 2816
		// (get) Token: 0x060025A8 RID: 9640 RVA: 0x000A20CA File Offset: 0x000A02CA
		protected override bool HandlesScrolling
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000B01 RID: 2817
		// (get) Token: 0x060025A9 RID: 9641 RVA: 0x000A20CD File Offset: 0x000A02CD
		protected internal override int MaxDeactivatedContainersWithoutIndexes
		{
			get
			{
				if (base.ItemsSource is global::Infragistics.Windows.DataPresenter.FlatScrollRecordsCollection)
				{
					return 150;
				}
				return base.MaxDeactivatedContainersWithoutIndexes;
			}
		}

		// Token: 0x17000B02 RID: 2818
		// (get) Token: 0x060025AA RID: 9642 RVA: 0x000A20E8 File Offset: 0x000A02E8
		protected internal override int UnderlyingItemsCount
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.FlatScrollRecordsCollection flatScrollRecordsCollection = base.ItemsSource as global::Infragistics.Windows.DataPresenter.FlatScrollRecordsCollection;
				if (flatScrollRecordsCollection != null)
				{
					return flatScrollRecordsCollection.CountOfNonHeaderRecords;
				}
				return base.Items.Count;
			}
		}

		// Token: 0x060025AB RID: 9643 RVA: 0x000A2118 File Offset: 0x000A0318
		protected override void ClearContainerForItemOverride(global::System.Windows.DependencyObject element, object item)
		{
			global::Infragistics.Windows.DataPresenter.RecordPresenter recordPresenterFromContainer = global::Infragistics.Windows.DataPresenter.RecordListControl.GetRecordPresenterFromContainer(element);
			if (recordPresenterFromContainer != null)
			{
				bool flag = true;
				if (recordPresenterFromContainer.HasCellInEditMode && this._dataPresenter != null && this._dataPresenter.RecordContainerGenerationMode != global::Infragistics.Windows.Controls.ItemContainerGenerationMode.Recycle)
				{
					global::Infragistics.Windows.DataPresenter.Internal.RecordListItemContainer recordListItemContainer = element as global::Infragistics.Windows.DataPresenter.Internal.RecordListItemContainer;
					if (recordListItemContainer != null)
					{
						recordPresenterFromContainer.DataContext = recordListItemContainer.DataContext;
						recordListItemContainer.Child = null;
						this._dataPresenter.PendingActiveRecordPresenter = recordPresenterFromContainer;
						this._dataPresenter.WireLayoutUpdated(new global::Infragistics.Windows.DataPresenter.GridUtilities.MethodDelegate(this.OnLayoutUpdated));
						flag = false;
					}
				}
				if (flag)
				{
					recordPresenterFromContainer.ClearContainerForItem(item);
				}
			}
			base.ClearContainerForItemOverride(element, item);
		}

		// Token: 0x060025AC RID: 9644 RVA: 0x000A21A2 File Offset: 0x000A03A2
		protected override global::System.Windows.DependencyObject GetContainerForItemOverride()
		{
			return this.GetContainerForItemOverrideHelper(null);
		}

		// Token: 0x060025AD RID: 9645 RVA: 0x000A21AB File Offset: 0x000A03AB
		protected override global::System.Windows.DependencyObject GetContainerForItemOverride(object item)
		{
			return this.GetContainerForItemOverrideHelper(item);
		}

		// Token: 0x060025AE RID: 9646 RVA: 0x000A21B4 File Offset: 0x000A03B4
		protected internal override bool IsContainerCompatibleWithItem(global::System.Windows.DependencyObject container, object item)
		{
			global::Infragistics.Windows.DataPresenter.RecordPresenter recordPresenterFromContainer = global::Infragistics.Windows.DataPresenter.RecordListControl.GetRecordPresenterFromContainer(container);
			global::Infragistics.Windows.DataPresenter.Record record = item as global::Infragistics.Windows.DataPresenter.Record;
			if (recordPresenterFromContainer == null || record == null)
			{
				return false;
			}
			if (recordPresenterFromContainer.IsActive)
			{
				return false;
			}
			bool isFlattenedList = this.IsFlattenedList;
			if (!isFlattenedList)
			{
				bool isExpanded = recordPresenterFromContainer.IsExpanded;
				if (isExpanded && recordPresenterFromContainer.HasNestedContent)
				{
					return false;
				}
				if (isExpanded != record.IsExpanded)
				{
					return false;
				}
			}
			global::Infragistics.Windows.DataPresenter.Record record2 = recordPresenterFromContainer.Record;
			if (record2 != null)
			{
				if (record2.RecordType != record.RecordType)
				{
					return false;
				}
				if (!isFlattenedList && record2.ParentRecord != record.ParentRecord)
				{
					return false;
				}
			}
			global::Infragistics.Windows.DataPresenter.DataRecordPresenter dataRecordPresenter = recordPresenterFromContainer as global::Infragistics.Windows.DataPresenter.DataRecordPresenter;
			if (dataRecordPresenter != null)
			{
				global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = item as global::Infragistics.Windows.DataPresenter.DataRecord;
				if (dataRecord == null)
				{
					return false;
				}
				global::Infragistics.Windows.DataPresenter.Record record3 = record2;
				if (dataRecord.IsSpecialRecord && record3 != null && !record3.IsSpecialRecord)
				{
					return false;
				}
				global::Infragistics.Windows.DataPresenter.HeaderRecord headerRecord = record2 as global::Infragistics.Windows.DataPresenter.HeaderRecord;
				if (headerRecord != null && headerRecord._vrcPlaceholderRecord != null)
				{
					return headerRecord._vrcPlaceholderRecord == dataRecord;
				}
				return dataRecordPresenter.FieldLayout == dataRecord.FieldLayout;
			}
			else
			{
				global::Infragistics.Windows.DataPresenter.GroupByRecordPresenter groupByRecordPresenter = recordPresenterFromContainer as global::Infragistics.Windows.DataPresenter.GroupByRecordPresenter;
				if (groupByRecordPresenter != null)
				{
					global::Infragistics.Windows.DataPresenter.GroupByRecord groupByRecord = item as global::Infragistics.Windows.DataPresenter.GroupByRecord;
					return groupByRecord != null && groupByRecordPresenter.FieldLayout == groupByRecord.FieldLayout;
				}
				global::Infragistics.Windows.DataPresenter.ExpandableFieldRecordPresenter expandableFieldRecordPresenter = recordPresenterFromContainer as global::Infragistics.Windows.DataPresenter.ExpandableFieldRecordPresenter;
				if (expandableFieldRecordPresenter != null)
				{
					global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord expandableFieldRecord = item as global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord;
					return expandableFieldRecord != null && expandableFieldRecordPresenter.FieldLayout == expandableFieldRecord.FieldLayout;
				}
				global::Infragistics.Windows.DataPresenter.SummaryRecordPresenter summaryRecordPresenter = recordPresenterFromContainer as global::Infragistics.Windows.DataPresenter.SummaryRecordPresenter;
				if (summaryRecordPresenter != null)
				{
					global::Infragistics.Windows.DataPresenter.SummaryRecord summaryRecord = item as global::Infragistics.Windows.DataPresenter.SummaryRecord;
					global::Infragistics.Windows.DataPresenter.SummaryRecord summaryRecord2 = summaryRecordPresenter.SummaryRecord;
					return summaryRecord != null && summaryRecord2.FieldLayout == summaryRecord.FieldLayout && summaryRecord2.SummaryDisplayAreaContext.Equals(summaryRecord.SummaryDisplayAreaContext) && summaryRecord2.NestingDepth == summaryRecord.NestingDepth;
				}
				return true;
			}
		}

		// Token: 0x060025AF RID: 9647 RVA: 0x000A2354 File Offset: 0x000A0554
		protected override bool IsItemItsOwnContainerOverride(object item)
		{
			if (item == null)
			{
				return false;
			}
			global::System.Type recordPresenterContainerType = this.DataPresenter.CurrentViewInternal.RecordPresenterContainerType;
			return item is global::Infragistics.Windows.DataPresenter.RecordPresenter || item.GetType() == recordPresenterContainerType;
		}

		// Token: 0x060025B0 RID: 9648 RVA: 0x000A2390 File Offset: 0x000A0590
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size availableSize)
		{
			global::System.Windows.Size result = base.MeasureOverride(availableSize);
			this.FindPanel();
			return result;
		}

		// Token: 0x060025B1 RID: 9649 RVA: 0x000A23AC File Offset: 0x000A05AC
		protected override void PrepareContainerForItemOverride(global::System.Windows.DependencyObject element, object item)
		{
			bool flag = false;
			global::Infragistics.Windows.DataPresenter.RecordPresenter recordPresenter;
			if (element is global::Infragistics.Windows.DataPresenter.RecordPresenter)
			{
				recordPresenter = (element as global::Infragistics.Windows.DataPresenter.RecordPresenter);
			}
			else if (element is global::Infragistics.Windows.DataPresenter.Internal.RecordListItemContainer)
			{
				global::Infragistics.Windows.DataPresenter.Internal.RecordListItemContainer recordListItemContainer = element as global::Infragistics.Windows.DataPresenter.Internal.RecordListItemContainer;
				recordPresenter = global::Infragistics.Windows.DataPresenter.RecordListControl.CreateRecordPresenterForItem(item);
				recordListItemContainer.InitializeWithItem(recordPresenter);
			}
			else
			{
				recordPresenter = global::Infragistics.Windows.DataPresenter.RecordListControl.CreateRecordPresenterForItem(item);
				if (recordPresenter != null)
				{
					recordPresenter.PrepareContainerForItem(item);
					flag = true;
				}
				this.PrepareViewContainerForRecordPresenter(element, recordPresenter);
			}
			if (recordPresenter != null && !flag)
			{
				recordPresenter.PrepareContainerForItem(item);
			}
			base.PrepareContainerForItemOverride(element, item);
		}

		// Token: 0x060025B2 RID: 9650 RVA: 0x000A2420 File Offset: 0x000A0620
		protected internal override void ReuseContainerForNewItem(global::System.Windows.DependencyObject container, object item)
		{
			global::Infragistics.Windows.DataPresenter.RecordPresenter recordPresenterFromContainer = global::Infragistics.Windows.DataPresenter.RecordListControl.GetRecordPresenterFromContainer(container);
			if (recordPresenterFromContainer == null)
			{
				base.ReuseContainerForNewItem(container, item);
				return;
			}
			recordPresenterFromContainer.PrepareContainerForItem(item);
			this.PrepareViewContainerForRecordPresenter(container, recordPresenterFromContainer);
		}

		// Token: 0x060025B3 RID: 9651 RVA: 0x000A2450 File Offset: 0x000A0650
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		protected internal override bool ShouldDeactivateContainer(global::System.Windows.DependencyObject container, object item)
		{
			global::Infragistics.Windows.DataPresenter.FlatScrollRecordsCollection flatScrollRecordsCollection = base.ItemsSource as global::Infragistics.Windows.DataPresenter.FlatScrollRecordsCollection;
			if (flatScrollRecordsCollection != null && !flatScrollRecordsCollection.HasPendingNotifications)
			{
				global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = item as global::Infragistics.Windows.DataPresenter.DataRecord;
				if (dataRecord != null && dataRecord.FieldLayout.HasBeenInitializedAfterDataSourceChange && dataRecord.FieldLayout.IsInitialRecordLoaded && !dataRecord.IsSpecialRecord && dataRecord.IsStillValid)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x17000B03 RID: 2819
		// (get) Token: 0x060025B4 RID: 9652 RVA: 0x000A24AB File Offset: 0x000A06AB
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Media.Transform FixedNearElementTransform
		{
			get
			{
				return (global::System.Windows.Media.Transform)base.GetValue(global::Infragistics.Windows.DataPresenter.RecordListControl.FixedNearElementTransformProperty);
			}
		}

		// Token: 0x17000B04 RID: 2820
		// (get) Token: 0x060025B5 RID: 9653 RVA: 0x000A24BD File Offset: 0x000A06BD
		// (set) Token: 0x060025B6 RID: 9654 RVA: 0x000A24CF File Offset: 0x000A06CF
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Controls.ScrollBarVisibility HorizontalScrollBarVisibility
		{
			get
			{
				return (global::System.Windows.Controls.ScrollBarVisibility)base.GetValue(global::Infragistics.Windows.DataPresenter.RecordListControl.HorizontalScrollBarVisibilityProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.RecordListControl.HorizontalScrollBarVisibilityProperty, value);
			}
		}

		// Token: 0x17000B05 RID: 2821
		// (get) Token: 0x060025B7 RID: 9655 RVA: 0x000A24E2 File Offset: 0x000A06E2
		public bool IsRoot
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.RecordListControl.IsRootProperty);
			}
		}

		// Token: 0x17000B06 RID: 2822
		// (get) Token: 0x060025B8 RID: 9656 RVA: 0x000A24F4 File Offset: 0x000A06F4
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		public global::System.Windows.Media.Transform ScrollableElementTransform
		{
			get
			{
				return (global::System.Windows.Media.Transform)base.GetValue(global::Infragistics.Windows.DataPresenter.RecordListControl.ScrollableElementTransformProperty);
			}
		}

		// Token: 0x17000B07 RID: 2823
		// (get) Token: 0x060025B9 RID: 9657 RVA: 0x000A2506 File Offset: 0x000A0706
		// (set) Token: 0x060025BA RID: 9658 RVA: 0x000A2518 File Offset: 0x000A0718
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Controls.ScrollBarVisibility VerticalScrollBarVisibility
		{
			get
			{
				return (global::System.Windows.Controls.ScrollBarVisibility)base.GetValue(global::Infragistics.Windows.DataPresenter.RecordListControl.VerticalScrollBarVisibilityProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.RecordListControl.VerticalScrollBarVisibilityProperty, value);
			}
		}

		// Token: 0x17000B08 RID: 2824
		// (get) Token: 0x060025BB RID: 9659 RVA: 0x000A252B File Offset: 0x000A072B
		internal global::Infragistics.Windows.DataPresenter.DataPresenterBase DataPresenter
		{
			get
			{
				return this._dataPresenter;
			}
		}

		// Token: 0x17000B09 RID: 2825
		// (get) Token: 0x060025BC RID: 9660 RVA: 0x000A2533 File Offset: 0x000A0733
		internal bool IsFlattenedList
		{
			get
			{
				return base.ItemsSource is global::Infragistics.Windows.DataPresenter.FlatScrollRecordsCollection;
			}
		}

		// Token: 0x17000B0A RID: 2826
		// (get) Token: 0x060025BD RID: 9661 RVA: 0x000A2543 File Offset: 0x000A0743
		internal global::System.Windows.Controls.Panel Panel
		{
			get
			{
				if (this._panel == null)
				{
					this.FindPanel();
				}
				return this._panel;
			}
		}

		// Token: 0x17000B0B RID: 2827
		// (get) Token: 0x060025BE RID: 9662 RVA: 0x000A2559 File Offset: 0x000A0759
		internal global::System.Windows.Controls.Primitives.IScrollInfo ScrollInfo
		{
			get
			{
				return this._panel as global::System.Windows.Controls.Primitives.IScrollInfo;
			}
		}

		// Token: 0x17000B0C RID: 2828
		// (get) Token: 0x060025BF RID: 9663 RVA: 0x000A2568 File Offset: 0x000A0768
		internal global::Infragistics.Windows.DataPresenter.ViewableRecordCollection ViewableRecords
		{
			get
			{
				object itemsSource = base.ItemsSource;
				global::Infragistics.Windows.DataPresenter.ViewableRecordCollection viewableRecordCollection = itemsSource as global::Infragistics.Windows.DataPresenter.ViewableRecordCollection;
				if (viewableRecordCollection != null)
				{
					return viewableRecordCollection;
				}
				global::Infragistics.Windows.DataPresenter.FlatScrollRecordsCollection flatScrollRecordsCollection = itemsSource as global::Infragistics.Windows.DataPresenter.FlatScrollRecordsCollection;
				if (flatScrollRecordsCollection != null)
				{
					return flatScrollRecordsCollection.RootViewableRecords;
				}
				return null;
			}
		}

		// Token: 0x060025C0 RID: 9664 RVA: 0x000A259A File Offset: 0x000A079A
		internal void BeginCoerceItemsSourceToNull()
		{
			this._coerceItemsSourceToNullCount++;
			base.CoerceValue(global::System.Windows.Controls.ItemsControl.ItemsSourceProperty);
		}

		// Token: 0x060025C1 RID: 9665 RVA: 0x000A25B5 File Offset: 0x000A07B5
		internal void EndCoerceItemsSourceToNull()
		{
			this._coerceItemsSourceToNullCount--;
			base.CoerceValue(global::System.Windows.Controls.ItemsControl.ItemsSourceProperty);
		}

		// Token: 0x060025C2 RID: 9666 RVA: 0x000A25D0 File Offset: 0x000A07D0
		internal static global::Infragistics.Windows.DataPresenter.RecordPresenter GetRecordPresenterFromContainer(global::System.Windows.DependencyObject container)
		{
			global::Infragistics.Windows.DataPresenter.RecordPresenter recordPresenter = container as global::Infragistics.Windows.DataPresenter.RecordPresenter;
			if (recordPresenter != null)
			{
				return recordPresenter;
			}
			global::Infragistics.Windows.DataPresenter.IRecordPresenterContainer recordPresenterContainer = container as global::Infragistics.Windows.DataPresenter.IRecordPresenterContainer;
			if (recordPresenterContainer != null)
			{
				recordPresenter = recordPresenterContainer.RecordPresenter;
			}
			else
			{
				global::System.Windows.Controls.ContentControl contentControl = container as global::System.Windows.Controls.ContentControl;
				if (contentControl != null)
				{
					recordPresenter = (contentControl.Content as global::Infragistics.Windows.DataPresenter.RecordPresenter);
				}
			}
			return recordPresenter;
		}

		// Token: 0x060025C3 RID: 9667 RVA: 0x000A2614 File Offset: 0x000A0814
		private static object CoerceItemsSource(global::System.Windows.DependencyObject target, object value)
		{
			global::Infragistics.Windows.DataPresenter.RecordListControl recordListControl = target as global::Infragistics.Windows.DataPresenter.RecordListControl;
			if (recordListControl._coerceItemsSourceToNullCount > 0)
			{
				return null;
			}
			return value;
		}

		// Token: 0x060025C4 RID: 9668 RVA: 0x000A2634 File Offset: 0x000A0834
		private static global::Infragistics.Windows.DataPresenter.RecordPresenter CreateRecordPresenterForItem(object item)
		{
			global::Infragistics.Windows.DataPresenter.Record record = item as global::Infragistics.Windows.DataPresenter.Record;
			if (record != null && record.IsActive)
			{
				global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = record.DataPresenter;
				if (dataPresenter != null)
				{
					global::Infragistics.Windows.DataPresenter.RecordPresenter pendingActiveRecordPresenter = dataPresenter.PendingActiveRecordPresenter;
					if (pendingActiveRecordPresenter != null && pendingActiveRecordPresenter.Record == record && pendingActiveRecordPresenter.Parent == null)
					{
						dataPresenter.PendingActiveRecordPresenter = null;
						return pendingActiveRecordPresenter;
					}
				}
			}
			return (record != null) ? record.CreateRecordPresenter() : null;
		}

		// Token: 0x060025C5 RID: 9669 RVA: 0x000A2690 File Offset: 0x000A0890
		private void FindPanel()
		{
			if (this._panel == null && this.DataPresenter != null)
			{
				this._panel = (global::Infragistics.Windows.Utilities.GetDescendantFromType(this, this.DataPresenter.CurrentViewInternal.ItemsPanelType, true) as global::System.Windows.Controls.Panel);
				global::Infragistics.Windows.DataPresenter.CarouselViewPanel carouselViewPanel = this._panel as global::Infragistics.Windows.DataPresenter.CarouselViewPanel;
				if (carouselViewPanel != null)
				{
					carouselViewPanel.SelectionHost = this;
				}
			}
		}

		// Token: 0x060025C6 RID: 9670 RVA: 0x000A26E8 File Offset: 0x000A08E8
		private global::System.Windows.DependencyObject GetContainerForItemOverrideHelper(object item)
		{
			global::System.Windows.DependencyObject viewContainerForRecordPresenter = this.GetViewContainerForRecordPresenter();
			if (viewContainerForRecordPresenter != null)
			{
				return viewContainerForRecordPresenter;
			}
			global::Infragistics.Windows.DataPresenter.Record record = item as global::Infragistics.Windows.DataPresenter.Record;
			if (record != null)
			{
				return global::Infragistics.Windows.DataPresenter.RecordListControl.CreateRecordPresenterForItem(item);
			}
			return new global::Infragistics.Windows.DataPresenter.Internal.RecordListItemContainer();
		}

		// Token: 0x060025C7 RID: 9671 RVA: 0x000A2718 File Offset: 0x000A0918
		private global::System.Windows.DependencyObject GetViewContainerForRecordPresenter()
		{
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this.DataPresenter;
			global::Infragistics.Windows.DataPresenter.ViewBase currentViewInternal = dataPresenter.CurrentViewInternal;
			global::System.Windows.DependencyObject containerForRecordPresenter = currentViewInternal.GetContainerForRecordPresenter(this._panel);
			if (containerForRecordPresenter != null)
			{
				if (!(containerForRecordPresenter is global::Infragistics.Windows.DataPresenter.RecordPresenter))
				{
					this.ValidateRecordPresenterContainer(currentViewInternal, containerForRecordPresenter);
				}
				return containerForRecordPresenter;
			}
			return null;
		}

		// Token: 0x060025C8 RID: 9672 RVA: 0x000A2756 File Offset: 0x000A0956
		private void OnLayoutUpdated()
		{
			if (this._dataPresenter != null)
			{
				this._dataPresenter.ClearPendingActiveRecordPresenter();
			}
		}

		// Token: 0x060025C9 RID: 9673 RVA: 0x000A276B File Offset: 0x000A096B
		private void PrepareViewContainerForRecordPresenter(global::System.Windows.DependencyObject viewContainer, global::Infragistics.Windows.DataPresenter.RecordPresenter recordPresenter)
		{
			this.DataPresenter.CurrentViewInternal.PrepareContainerForRecordPresenter(this._panel, viewContainer, recordPresenter);
		}

		// Token: 0x060025CA RID: 9674 RVA: 0x000A2788 File Offset: 0x000A0988
		private void ValidateRecordPresenterContainer(global::Infragistics.Windows.DataPresenter.ViewBase view, global::System.Windows.DependencyObject container)
		{
			global::System.Type type = container.GetType();
			global::System.Type recordPresenterContainerType = view.RecordPresenterContainerType;
			if (!typeof(global::Infragistics.Windows.DataPresenter.IRecordPresenterContainer).IsAssignableFrom(type) && !typeof(global::System.Windows.Controls.ContentControl).IsAssignableFrom(type))
			{
				throw new global::System.InvalidOperationException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_InvalidOperationException_15"));
			}
		}

		// Token: 0x17000B0D RID: 2829
		// (get) Token: 0x060025CB RID: 9675 RVA: 0x000A27D7 File Offset: 0x000A09D7
		// (set) Token: 0x060025CC RID: 9676 RVA: 0x000A2818 File Offset: 0x000A0A18
		int global::Infragistics.Windows.Controls.ICarouselPanelSelectionHost.SelectedItemIndex
		{
			get
			{
				if (this.DataPresenter == null || this.DataPresenter.SelectedItems.Records.Count == 0)
				{
					return -1;
				}
				return this.DataPresenter.SelectedItems.Records[0].Index;
			}
			set
			{
				global::System.Collections.IList list = base.ItemsSource as global::System.Collections.IList;
				if (list != null)
				{
					global::Infragistics.Windows.DataPresenter.Record record = list[value] as global::Infragistics.Windows.DataPresenter.Record;
					if (record != null && this.DataPresenter != null)
					{
						this.DataPresenter.InternalSelectItem(record, true, true);
					}
				}
			}
		}

		// Token: 0x040011D7 RID: 4567
		private global::Infragistics.Windows.DataPresenter.DataPresenterBase _dataPresenter;

		// Token: 0x040011D8 RID: 4568
		private global::System.Windows.Controls.Panel _panel;

		// Token: 0x040011D9 RID: 4569
		private int _coerceItemsSourceToNullCount;

		// Token: 0x040011DA RID: 4570
		public static readonly global::System.Windows.DependencyProperty FixedNearElementTransformProperty = global::Infragistics.Windows.DataPresenter.RecordPresenter.FixedNearElementTransformProperty.AddOwner(typeof(global::Infragistics.Windows.DataPresenter.RecordListControl));

		// Token: 0x040011DB RID: 4571
		public static readonly global::System.Windows.DependencyProperty HorizontalScrollBarVisibilityProperty = global::System.Windows.DependencyProperty.Register("HorizontalScrollBarVisibility", typeof(global::System.Windows.Controls.ScrollBarVisibility), typeof(global::Infragistics.Windows.DataPresenter.RecordListControl), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.ScrollBarVisibilityAutoBox));

		// Token: 0x040011DC RID: 4572
		private static readonly global::System.Windows.DependencyPropertyKey IsRootPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("IsRoot", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.RecordListControl), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x040011DD RID: 4573
		public static readonly global::System.Windows.DependencyProperty IsRootProperty = global::Infragistics.Windows.DataPresenter.RecordListControl.IsRootPropertyKey.DependencyProperty;

		// Token: 0x040011DE RID: 4574
		public static readonly global::System.Windows.DependencyProperty ScrollableElementTransformProperty = global::Infragistics.Windows.DataPresenter.RecordPresenter.ScrollableElementTransformProperty.AddOwner(typeof(global::Infragistics.Windows.DataPresenter.RecordListControl));

		// Token: 0x040011DF RID: 4575
		public static readonly global::System.Windows.DependencyProperty VerticalScrollBarVisibilityProperty = global::System.Windows.DependencyProperty.Register("VerticalScrollBarVisibility", typeof(global::System.Windows.Controls.ScrollBarVisibility), typeof(global::Infragistics.Windows.DataPresenter.RecordListControl), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.ScrollBarVisibilityAutoBox));
	}
}
