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
using System.Windows.Threading;
using Infragistics.AutomationPeers;
using Infragistics.Windows.Automation.Peers.DataPresenter;
using Infragistics.Windows.Controls;
using Infragistics.Windows.DataPresenter.Internal;
using Infragistics.Windows.Virtualization;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000355 RID: 853
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public sealed class RecordListControl : global::Infragistics.Windows.Virtualization.RecyclingItemsControl, global::Infragistics.Windows.Controls.ICarouselPanelSelectionHost
	{
		// Token: 0x06002954 RID: 10580 RVA: 0x000B5CE0 File Offset: 0x000B3EE0
		static RecordListControl()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.RecordListControl), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.DataPresenter.RecordListControl)));
			global::System.Windows.Controls.ItemsControl.ItemsSourceProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.RecordListControl), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DataPresenter.RecordListControl.CoerceItemsSource)));
			global::Infragistics.Windows.DataPresenter.GridUtilities.SuppressBringIntoView(typeof(global::Infragistics.Windows.DataPresenter.RecordListControl));
		}

		// Token: 0x06002955 RID: 10581 RVA: 0x000B5E10 File Offset: 0x000B4010
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

		// Token: 0x06002956 RID: 10582 RVA: 0x000B5E74 File Offset: 0x000B4074
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

		// Token: 0x06002957 RID: 10583 RVA: 0x000B5EF0 File Offset: 0x000B40F0
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

		// Token: 0x06002958 RID: 10584 RVA: 0x000B6004 File Offset: 0x000B4204
		protected override global::System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
		{
			if (this.DataPresenter != null && this.DataPresenter.IsFlatView)
			{
				return new global::Infragistics.Windows.Automation.Peers.DataPresenter.ViewableRecordCollectionAutomationPeer(this, this.DataPresenter.ViewableRecords, true);
			}
			return new global::Infragistics.Windows.Automation.Peers.DataPresenter.RecordListControlAutomationPeer(this);
		}

		// Token: 0x06002959 RID: 10585 RVA: 0x000B6034 File Offset: 0x000B4234
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

		// Token: 0x0600295A RID: 10586 RVA: 0x000B60B8 File Offset: 0x000B42B8
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

		// Token: 0x17000C31 RID: 3121
		// (get) Token: 0x0600295B RID: 10587 RVA: 0x000B6126 File Offset: 0x000B4326
		protected override bool HandlesScrolling
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000C32 RID: 3122
		// (get) Token: 0x0600295C RID: 10588 RVA: 0x000B6129 File Offset: 0x000B4329
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

		// Token: 0x17000C33 RID: 3123
		// (get) Token: 0x0600295D RID: 10589 RVA: 0x000B6144 File Offset: 0x000B4344
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

		// Token: 0x0600295E RID: 10590 RVA: 0x000B6174 File Offset: 0x000B4374
		protected override void ClearContainerForItemOverride(global::System.Windows.DependencyObject element, object item)
		{
			global::Infragistics.Windows.DataPresenter.RecordPresenter recordPresenterFromContainer = global::Infragistics.Windows.DataPresenter.RecordListControl.GetRecordPresenterFromContainer(element);
			if (recordPresenterFromContainer != null)
			{
				bool flag = true;
				if ((recordPresenterFromContainer.HasCellInEditMode || recordPresenterFromContainer.IsKeyboardFocusWithin) && this._dataPresenter != null && this._dataPresenter.RecordContainerGenerationMode != global::Infragistics.Windows.Controls.ItemContainerGenerationMode.Recycle)
				{
					global::Infragistics.Windows.DataPresenter.Internal.RecordListItemContainer recordListItemContainer = element as global::Infragistics.Windows.DataPresenter.Internal.RecordListItemContainer;
					if (recordListItemContainer != null)
					{
						recordPresenterFromContainer.DataContext = recordListItemContainer.DataContext;
						this._dataPresenter.PendingActiveRecordPresenter = recordPresenterFromContainer;
						recordListItemContainer.SetChild(null, this._dataPresenter);
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

		// Token: 0x0600295F RID: 10591 RVA: 0x000B620C File Offset: 0x000B440C
		protected override global::System.Windows.DependencyObject GetContainerForItemOverride()
		{
			return this.GetContainerForItemOverrideHelper(null);
		}

		// Token: 0x06002960 RID: 10592 RVA: 0x000B6215 File Offset: 0x000B4415
		protected override global::System.Windows.DependencyObject GetContainerForItemOverride(object item)
		{
			return this.GetContainerForItemOverrideHelper(item);
		}

		// Token: 0x06002961 RID: 10593 RVA: 0x000B6220 File Offset: 0x000B4420
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

		// Token: 0x06002962 RID: 10594 RVA: 0x000B63C0 File Offset: 0x000B45C0
		protected override bool IsItemItsOwnContainerOverride(object item)
		{
			if (item == null)
			{
				return false;
			}
			global::System.Type recordPresenterContainerType = this.DataPresenter.CurrentViewInternal.RecordPresenterContainerType;
			return item is global::Infragistics.Windows.DataPresenter.RecordPresenter || item.GetType() == recordPresenterContainerType;
		}

		// Token: 0x06002963 RID: 10595 RVA: 0x000B63FC File Offset: 0x000B45FC
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size availableSize)
		{
			global::System.Windows.Size result = base.MeasureOverride(availableSize);
			this.FindPanel();
			return result;
		}

		// Token: 0x06002964 RID: 10596 RVA: 0x000B6418 File Offset: 0x000B4618
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
				recordListItemContainer.SetChild(recordPresenter, this.DataPresenter);
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

		// Token: 0x06002965 RID: 10597 RVA: 0x000B6490 File Offset: 0x000B4690
		protected internal override void ReuseContainerForNewItem(global::System.Windows.DependencyObject container, object item)
		{
			global::Infragistics.Windows.DataPresenter.RecordPresenter recordPresenterFromContainer = global::Infragistics.Windows.DataPresenter.RecordListControl.GetRecordPresenterFromContainer(container);
			if (recordPresenterFromContainer == null)
			{
				base.ReuseContainerForNewItem(container, item);
				return;
			}
			global::Infragistics.Windows.DataPresenter.Record record = recordPresenterFromContainer.Record;
			if (record != null && record != item)
			{
				record.InvalidatePeer();
			}
			recordPresenterFromContainer.PrepareContainerForItem(item);
			this.PrepareViewContainerForRecordPresenter(container, recordPresenterFromContainer);
		}

		// Token: 0x06002966 RID: 10598 RVA: 0x000B64D4 File Offset: 0x000B46D4
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

		// Token: 0x17000C34 RID: 3124
		// (get) Token: 0x06002967 RID: 10599 RVA: 0x000B652F File Offset: 0x000B472F
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		public global::System.Windows.Media.Transform FixedNearElementTransform
		{
			get
			{
				return (global::System.Windows.Media.Transform)base.GetValue(global::Infragistics.Windows.DataPresenter.RecordListControl.FixedNearElementTransformProperty);
			}
		}

		// Token: 0x17000C35 RID: 3125
		// (get) Token: 0x06002968 RID: 10600 RVA: 0x000B6541 File Offset: 0x000B4741
		// (set) Token: 0x06002969 RID: 10601 RVA: 0x000B6553 File Offset: 0x000B4753
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

		// Token: 0x17000C36 RID: 3126
		// (get) Token: 0x0600296A RID: 10602 RVA: 0x000B6566 File Offset: 0x000B4766
		public bool IsRoot
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.RecordListControl.IsRootProperty);
			}
		}

		// Token: 0x17000C37 RID: 3127
		// (get) Token: 0x0600296B RID: 10603 RVA: 0x000B6578 File Offset: 0x000B4778
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		public global::System.Windows.Media.Transform ScrollableElementTransform
		{
			get
			{
				return (global::System.Windows.Media.Transform)base.GetValue(global::Infragistics.Windows.DataPresenter.RecordListControl.ScrollableElementTransformProperty);
			}
		}

		// Token: 0x17000C38 RID: 3128
		// (get) Token: 0x0600296C RID: 10604 RVA: 0x000B658A File Offset: 0x000B478A
		// (set) Token: 0x0600296D RID: 10605 RVA: 0x000B659C File Offset: 0x000B479C
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

		// Token: 0x17000C39 RID: 3129
		// (get) Token: 0x0600296E RID: 10606 RVA: 0x000B65AF File Offset: 0x000B47AF
		internal global::Infragistics.Windows.DataPresenter.DataPresenterBase DataPresenter
		{
			get
			{
				return this._dataPresenter;
			}
		}

		// Token: 0x17000C3A RID: 3130
		// (get) Token: 0x0600296F RID: 10607 RVA: 0x000B65B7 File Offset: 0x000B47B7
		internal bool IsFlattenedList
		{
			get
			{
				return base.ItemsSource is global::Infragistics.Windows.DataPresenter.FlatScrollRecordsCollection;
			}
		}

		// Token: 0x17000C3B RID: 3131
		// (get) Token: 0x06002970 RID: 10608 RVA: 0x000B65C7 File Offset: 0x000B47C7
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

		// Token: 0x17000C3C RID: 3132
		// (get) Token: 0x06002971 RID: 10609 RVA: 0x000B65DD File Offset: 0x000B47DD
		internal global::System.Windows.Controls.Primitives.IScrollInfo ScrollInfo
		{
			get
			{
				return this._panel as global::System.Windows.Controls.Primitives.IScrollInfo;
			}
		}

		// Token: 0x17000C3D RID: 3133
		// (get) Token: 0x06002972 RID: 10610 RVA: 0x000B65EC File Offset: 0x000B47EC
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

		// Token: 0x06002973 RID: 10611 RVA: 0x000B661E File Offset: 0x000B481E
		internal void BeginCoerceItemsSourceToNull()
		{
			this._coerceItemsSourceToNullCount++;
			base.CoerceValue(global::System.Windows.Controls.ItemsControl.ItemsSourceProperty);
		}

		// Token: 0x06002974 RID: 10612 RVA: 0x000B6639 File Offset: 0x000B4839
		internal void EndCoerceItemsSourceToNull()
		{
			this._coerceItemsSourceToNullCount--;
			base.CoerceValue(global::System.Windows.Controls.ItemsControl.ItemsSourceProperty);
		}

		// Token: 0x06002975 RID: 10613 RVA: 0x000B6654 File Offset: 0x000B4854
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

		// Token: 0x06002976 RID: 10614 RVA: 0x000B6698 File Offset: 0x000B4898
		private static object CoerceItemsSource(global::System.Windows.DependencyObject target, object value)
		{
			global::Infragistics.Windows.DataPresenter.RecordListControl recordListControl = target as global::Infragistics.Windows.DataPresenter.RecordListControl;
			if (recordListControl._coerceItemsSourceToNullCount > 0)
			{
				return null;
			}
			return value;
		}

		// Token: 0x06002977 RID: 10615 RVA: 0x000B66E0 File Offset: 0x000B48E0
		private static global::Infragistics.Windows.DataPresenter.RecordPresenter CreateRecordPresenterForItem(object item)
		{
			global::Infragistics.Windows.DataPresenter.Record record = item as global::Infragistics.Windows.DataPresenter.Record;
			if (record != null && record.IsActive)
			{
				global::Infragistics.Windows.DataPresenter.DataPresenterBase dp = record.DataPresenter;
				if (dp != null)
				{
					global::Infragistics.Windows.DataPresenter.RecordPresenter rp = dp.PendingActiveRecordPresenter;
					if (rp != null && rp.Record == record && (rp.Parent == null || rp.Parent == dp))
					{
						if (rp.Parent == dp)
						{
							dp.Dispatcher.BeginInvoke(new global::System.Action(delegate()
							{
								dp.InternalRemoveLogicalChild(rp);
							}), global::System.Windows.Threading.DispatcherPriority.Send, new object[0]);
						}
						dp.PendingActiveRecordPresenter = null;
						return rp;
					}
				}
			}
			return (record != null) ? record.CreateRecordPresenter() : null;
		}

		// Token: 0x06002978 RID: 10616 RVA: 0x000B67D8 File Offset: 0x000B49D8
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

		// Token: 0x06002979 RID: 10617 RVA: 0x000B6830 File Offset: 0x000B4A30
		private global::System.Windows.DependencyObject GetContainerForItemOverrideHelper(object item)
		{
			global::System.Windows.DependencyObject viewContainerForRecordPresenter = this.GetViewContainerForRecordPresenter(item as global::Infragistics.Windows.DataPresenter.Record);
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

		// Token: 0x0600297A RID: 10618 RVA: 0x000B6868 File Offset: 0x000B4A68
		private global::System.Windows.DependencyObject GetViewContainerForRecordPresenter(global::Infragistics.Windows.DataPresenter.Record record)
		{
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this.DataPresenter;
			global::Infragistics.Windows.DataPresenter.ViewBase currentViewInternal = dataPresenter.CurrentViewInternal;
			global::System.Windows.DependencyObject containerForRecordPresenter = currentViewInternal.GetContainerForRecordPresenter(this._panel, record);
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

		// Token: 0x0600297B RID: 10619 RVA: 0x000B68A7 File Offset: 0x000B4AA7
		private void OnLayoutUpdated()
		{
			if (this._dataPresenter != null)
			{
				this._dataPresenter.ClearPendingActiveRecordPresenter();
			}
		}

		// Token: 0x0600297C RID: 10620 RVA: 0x000B68BC File Offset: 0x000B4ABC
		private void PrepareViewContainerForRecordPresenter(global::System.Windows.DependencyObject viewContainer, global::Infragistics.Windows.DataPresenter.RecordPresenter recordPresenter)
		{
			this.DataPresenter.CurrentViewInternal.PrepareContainerForRecordPresenter(this._panel, viewContainer, recordPresenter);
		}

		// Token: 0x0600297D RID: 10621 RVA: 0x000B68D8 File Offset: 0x000B4AD8
		private void ValidateRecordPresenterContainer(global::Infragistics.Windows.DataPresenter.ViewBase view, global::System.Windows.DependencyObject container)
		{
			global::System.Type type = container.GetType();
			global::System.Type recordPresenterContainerType = view.RecordPresenterContainerType;
			if (!typeof(global::Infragistics.Windows.DataPresenter.IRecordPresenterContainer).IsAssignableFrom(type) && !typeof(global::System.Windows.Controls.ContentControl).IsAssignableFrom(type))
			{
				throw new global::System.InvalidOperationException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_InvalidOperationException_15"));
			}
		}

		// Token: 0x17000C3E RID: 3134
		// (get) Token: 0x0600297E RID: 10622 RVA: 0x000B6927 File Offset: 0x000B4B27
		// (set) Token: 0x0600297F RID: 10623 RVA: 0x000B6968 File Offset: 0x000B4B68
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

		// Token: 0x040013F7 RID: 5111
		private global::Infragistics.Windows.DataPresenter.DataPresenterBase _dataPresenter;

		// Token: 0x040013F8 RID: 5112
		private global::System.Windows.Controls.Panel _panel;

		// Token: 0x040013F9 RID: 5113
		private int _coerceItemsSourceToNullCount;

		// Token: 0x040013FA RID: 5114
		public static readonly global::System.Windows.DependencyProperty FixedNearElementTransformProperty = global::Infragistics.Windows.DataPresenter.RecordPresenter.FixedNearElementTransformProperty.AddOwner(typeof(global::Infragistics.Windows.DataPresenter.RecordListControl));

		// Token: 0x040013FB RID: 5115
		public static readonly global::System.Windows.DependencyProperty HorizontalScrollBarVisibilityProperty = global::System.Windows.DependencyProperty.Register("HorizontalScrollBarVisibility", typeof(global::System.Windows.Controls.ScrollBarVisibility), typeof(global::Infragistics.Windows.DataPresenter.RecordListControl), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.ScrollBarVisibilityAutoBox));

		// Token: 0x040013FC RID: 5116
		private static readonly global::System.Windows.DependencyPropertyKey IsRootPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("IsRoot", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.RecordListControl), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x040013FD RID: 5117
		public static readonly global::System.Windows.DependencyProperty IsRootProperty = global::Infragistics.Windows.DataPresenter.RecordListControl.IsRootPropertyKey.DependencyProperty;

		// Token: 0x040013FE RID: 5118
		public static readonly global::System.Windows.DependencyProperty ScrollableElementTransformProperty = global::Infragistics.Windows.DataPresenter.RecordPresenter.ScrollableElementTransformProperty.AddOwner(typeof(global::Infragistics.Windows.DataPresenter.RecordListControl));

		// Token: 0x040013FF RID: 5119
		public static readonly global::System.Windows.DependencyProperty VerticalScrollBarVisibilityProperty = global::System.Windows.DependencyProperty.Register("VerticalScrollBarVisibility", typeof(global::System.Windows.Controls.ScrollBarVisibility), typeof(global::Infragistics.Windows.DataPresenter.RecordListControl), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.ScrollBarVisibilityAutoBox));
	}
}
