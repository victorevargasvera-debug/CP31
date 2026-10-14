using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using Infragistics.AutomationPeers;
using Infragistics.Windows.DataPresenter;

namespace Infragistics.Windows.Automation.Peers.DataPresenter
{
	// Token: 0x0200002F RID: 47
	public class ViewableRecordCollectionAutomationPeer : global::System.Windows.Automation.Peers.AutomationPeer, global::Infragistics.Windows.Automation.Peers.IListAutomationPeer, global::Infragistics.Windows.Automation.Peers.DataPresenter.IRecordListAutomationPeer, global::System.Windows.Automation.Provider.ISelectionProvider, global::System.Windows.Automation.Provider.ITableProvider, global::System.Windows.Automation.Provider.IGridProvider
	{
		// Token: 0x060001B5 RID: 437 RVA: 0x00007208 File Offset: 0x00005408
		public ViewableRecordCollectionAutomationPeer(global::Infragistics.Windows.DataPresenter.RecordListControl recordListControl, global::Infragistics.Windows.DataPresenter.ViewableRecordCollection viewableRecordCollection, bool isRootLevel)
		{
			if (recordListControl == null)
			{
				throw new global::System.ArgumentException("recordListControl");
			}
			if (viewableRecordCollection == null)
			{
				throw new global::System.ArgumentException("viewableRecordCollection");
			}
			this._recordListControl = recordListControl;
			this._isRootLevel = isRootLevel;
			this.InitializeViewableRecordsCollection(viewableRecordCollection);
			this._listAutomationPeerHelper = new global::Infragistics.Windows.Automation.Peers.DataPresenter.ListAutomationPeerHelper(this, this);
			this._listAutomationPeerHelper.InitializeFieldLayout();
			global::Infragistics.Windows.Automation.Peers.DataPresenter.DataPresenterBaseAutomationPeer.AddProxyPeerHost(this, viewableRecordCollection.RecordManager.DataPresenter);
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x00007280 File Offset: 0x00005480
		protected override string GetAcceleratorKeyCore()
		{
			return string.Empty;
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x00007287 File Offset: 0x00005487
		protected override string GetAccessKeyCore()
		{
			return string.Empty;
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x0000728E File Offset: 0x0000548E
		protected override global::System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore()
		{
			if (!this._listAutomationPeerHelper.HasRecordGroups && this.GetPattern(global::System.Windows.Automation.Peers.PatternInterface.Table) != null)
			{
				return global::System.Windows.Automation.Peers.AutomationControlType.DataGrid;
			}
			return global::System.Windows.Automation.Peers.AutomationControlType.List;
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x000072AB File Offset: 0x000054AB
		protected override string GetAutomationIdCore()
		{
			return string.Empty;
		}

		// Token: 0x060001BA RID: 442 RVA: 0x000072B4 File Offset: 0x000054B4
		protected override global::System.Windows.Rect GetBoundingRectangleCore()
		{
			global::System.Windows.Rect result = default(global::System.Windows.Rect);
			if (this.IsRootLevel)
			{
				try
				{
					global::System.Windows.Point point = global::Infragistics.Windows.Utilities.PointToScreenSafe(this._recordListControl, default(global::System.Windows.Point));
					return new global::System.Windows.Rect(point.X, point.Y, (double)global::Infragistics.Windows.Utilities.ConvertFromLogicalPixels(this._recordListControl.ActualWidth), (double)global::Infragistics.Windows.Utilities.ConvertFromLogicalPixels(this._recordListControl.ActualHeight));
				}
				catch
				{
					return result;
				}
			}
			global::Infragistics.Windows.Automation.Peers.DataPresenter.HeaderAutomationPeer headerPeer = (this.GetPattern(global::System.Windows.Automation.Peers.PatternInterface.Table) != null) ? this._listAutomationPeerHelper.HeaderPeer : null;
			result = (global::Infragistics.Windows.Automation.Peers.DataPresenter.RecordListGroup.GetVisibleBounds(this._viewableRecordCollection, headerPeer, true) ?? default(global::System.Windows.Rect));
			return result;
		}

		// Token: 0x060001BB RID: 443 RVA: 0x00007380 File Offset: 0x00005580
		protected override global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer> GetChildrenCore()
		{
			global::Infragistics.AutomationPeers.AutomationPeerHelper.RemovePendingChildrenInvalidation(this);
			if (this.ProcessVisualTreeOnly)
			{
				this._itemPeers.Clear();
				if (this._isRootLevel)
				{
					return new global::System.Windows.Automation.Peers.FrameworkElementAutomationPeer(this._recordListControl).GetChildren();
				}
				return null;
			}
			else
			{
				if (this._listAutomationPeerHelper.HasRecordGroups)
				{
					global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer> list = null;
					if (this.IsRootLevel)
					{
						list = this.GetChildrenHelperBaseItems();
					}
					global::System.Collections.Generic.List<global::Infragistics.Windows.Automation.Peers.DataPresenter.RecordListGroup> recordListGroups = this._listAutomationPeerHelper.GetRecordListGroups();
					global::System.Converter<global::Infragistics.Windows.Automation.Peers.DataPresenter.RecordListGroup, global::System.Windows.Automation.Peers.AutomationPeer> converter = (global::Infragistics.Windows.Automation.Peers.DataPresenter.RecordListGroup group) => group.AutomationPeer;
					global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer> list2 = recordListGroups.ConvertAll<global::System.Windows.Automation.Peers.AutomationPeer>(converter);
					if (list != null)
					{
						list2.AddRange(list);
					}
					return list2;
				}
				global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer> childrenHelper = this.GetChildrenHelper();
				if (this.CouldSupportGridPattern())
				{
					global::System.Windows.Automation.Peers.AutomationPeer headerPeer = this._listAutomationPeerHelper.HeaderPeer;
					if (headerPeer != null)
					{
						childrenHelper.Insert(0, headerPeer);
					}
				}
				return childrenHelper;
			}
		}

		// Token: 0x060001BC RID: 444 RVA: 0x0000744A File Offset: 0x0000564A
		protected override string GetClassNameCore()
		{
			return "ViewableRecordCollection";
		}

		// Token: 0x060001BD RID: 445 RVA: 0x00007454 File Offset: 0x00005654
		protected override global::System.Windows.Point GetClickablePointCore()
		{
			global::System.Windows.Point result = new global::System.Windows.Point(double.NaN, double.NaN);
			if (this.IsRootLevel)
			{
				try
				{
					result = global::Infragistics.Windows.Utilities.PointToScreenSafe(this._recordListControl, new global::System.Windows.Point(this._recordListControl.ActualWidth * 0.5, this._recordListControl.ActualHeight * 0.5));
				}
				catch
				{
				}
			}
			return result;
		}

		// Token: 0x060001BE RID: 446 RVA: 0x000074D4 File Offset: 0x000056D4
		protected override string GetHelpTextCore()
		{
			return string.Empty;
		}

		// Token: 0x060001BF RID: 447 RVA: 0x000074DB File Offset: 0x000056DB
		protected override string GetItemStatusCore()
		{
			return string.Empty;
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x000074E2 File Offset: 0x000056E2
		protected override string GetItemTypeCore()
		{
			return string.Empty;
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x000074E9 File Offset: 0x000056E9
		protected override global::System.Windows.Automation.Peers.AutomationPeer GetLabeledByCore()
		{
			return null;
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x000074EC File Offset: 0x000056EC
		protected override string GetNameCore()
		{
			return "Records";
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x000074F4 File Offset: 0x000056F4
		protected override global::System.Windows.Automation.Peers.AutomationOrientation GetOrientationCore()
		{
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this._recordListControl.DataPresenter;
			if (dataPresenter == null)
			{
				return global::System.Windows.Automation.Peers.AutomationOrientation.None;
			}
			if (dataPresenter.CurrentViewInternal.LogicalOrientation != global::System.Windows.Controls.Orientation.Vertical)
			{
				return global::System.Windows.Automation.Peers.AutomationOrientation.Horizontal;
			}
			return global::System.Windows.Automation.Peers.AutomationOrientation.Vertical;
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x00007524 File Offset: 0x00005724
		public override object GetPattern(global::System.Windows.Automation.Peers.PatternInterface patternInterface)
		{
			if (patternInterface == global::System.Windows.Automation.Peers.PatternInterface.Scroll)
			{
				global::Infragistics.Windows.DataPresenter.RecordListControl recordListControl = this._recordListControl;
				if (this.IsRootLevel && recordListControl.ScrollInfo != null && recordListControl.ScrollInfo.ScrollOwner != null)
				{
					global::System.Windows.Automation.Peers.AutomationPeer automationPeer = global::System.Windows.Automation.Peers.UIElementAutomationPeer.CreatePeerForElement(recordListControl.ScrollInfo.ScrollOwner);
					if (automationPeer != null && automationPeer is global::System.Windows.Automation.Provider.IScrollProvider)
					{
						automationPeer.EventsSource = this;
						return automationPeer;
					}
				}
				return null;
			}
			if (this.ProcessVisualTreeOnly)
			{
				return null;
			}
			if (patternInterface == global::System.Windows.Automation.Peers.PatternInterface.Selection)
			{
				if (this._viewableRecordCollection.Count < 1 || this._viewableRecordCollection[0] is global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord)
				{
					return null;
				}
				return this;
			}
			else
			{
				if (patternInterface != global::System.Windows.Automation.Peers.PatternInterface.Grid && patternInterface != global::System.Windows.Automation.Peers.PatternInterface.Table)
				{
					return null;
				}
				if (!this.CouldSupportGridPattern())
				{
					return null;
				}
				if (this._listAutomationPeerHelper.HasRecordGroups)
				{
					return null;
				}
				return this;
			}
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x000075D8 File Offset: 0x000057D8
		protected override bool HasKeyboardFocusCore()
		{
			return this._recordListControl.IsKeyboardFocused;
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x000075E5 File Offset: 0x000057E5
		protected override bool IsContentElementCore()
		{
			return true;
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x000075E8 File Offset: 0x000057E8
		protected override bool IsControlElementCore()
		{
			return true;
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x000075EB File Offset: 0x000057EB
		protected override bool IsEnabledCore()
		{
			return this._recordListControl.IsEnabled;
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x000075F8 File Offset: 0x000057F8
		protected override bool IsKeyboardFocusableCore()
		{
			return this._recordListControl.Focusable;
		}

		// Token: 0x060001CA RID: 458 RVA: 0x00007605 File Offset: 0x00005805
		protected override bool IsOffscreenCore()
		{
			return false;
		}

		// Token: 0x060001CB RID: 459 RVA: 0x00007608 File Offset: 0x00005808
		protected override bool IsPasswordCore()
		{
			return false;
		}

		// Token: 0x060001CC RID: 460 RVA: 0x0000760B File Offset: 0x0000580B
		protected override bool IsRequiredForFormCore()
		{
			return false;
		}

		// Token: 0x060001CD RID: 461 RVA: 0x0000760E File Offset: 0x0000580E
		protected override void SetFocusCore()
		{
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x060001CE RID: 462 RVA: 0x00007610 File Offset: 0x00005810
		private bool IsHorizontalRowLayout
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this._recordListControl.DataPresenter;
				if (dataPresenter != null)
				{
					global::Infragistics.Windows.DataPresenter.ViewBase currentViewInternal = dataPresenter.CurrentViewInternal;
					return currentViewInternal.HasLogicalOrientation && currentViewInternal.LogicalOrientation == global::System.Windows.Controls.Orientation.Horizontal;
				}
				return false;
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x060001CF RID: 463 RVA: 0x00007648 File Offset: 0x00005848
		private bool IsRootLevel
		{
			get
			{
				return this._isRootLevel;
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x060001D0 RID: 464 RVA: 0x00007650 File Offset: 0x00005850
		private bool ProcessVisualTreeOnly
		{
			get
			{
				return global::Infragistics.Windows.Automation.Peers.DataPresenter.DataPresenterBaseAutomationPeer.ProcessVisualTreeOnly;
			}
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x00007658 File Offset: 0x00005858
		private bool CouldSupportGridPattern()
		{
			global::Infragistics.Windows.DataPresenter.RecordCollectionBase recordCollection = this._viewableRecordCollection.RecordCollection;
			return recordCollection != null && global::Infragistics.Windows.Automation.Peers.DataPresenter.ListAutomationPeerHelper.CouldSupportGridPattern(recordCollection.RecordsType) && this._listAutomationPeerHelper.IsHomogenousCollection();
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x0000768E File Offset: 0x0000588E
		private global::Infragistics.Windows.Automation.Peers.DataPresenter.RecordAutomationPeer CreateAutomationPeer(global::Infragistics.Windows.DataPresenter.Record record)
		{
			if (record == null)
			{
				throw new global::System.ArgumentNullException("record");
			}
			return global::Infragistics.Windows.Automation.Peers.DataPresenter.ListAutomationPeerHelper.CreateRecordAutomationPeer(record, this, this);
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x000076A8 File Offset: 0x000058A8
		private global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer> GetChildrenHelper()
		{
			global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer> childrenHelperBaseItems = this.GetChildrenHelperBaseItems();
			global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer> list = new global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer>();
			global::System.Collections.Generic.Dictionary<object, global::Infragistics.Windows.Automation.Peers.RecycleableItemAutomationPeer> itemPeers = this._itemPeers;
			this._itemPeers = new global::System.Collections.Generic.Dictionary<object, global::Infragistics.Windows.Automation.Peers.RecycleableItemAutomationPeer>();
			foreach (object obj in ((global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Record>)this._viewableRecordCollection))
			{
				if (obj != null)
				{
					global::Infragistics.Windows.Automation.Peers.RecycleableItemAutomationPeer recycleableItemAutomationPeer;
					if (!itemPeers.TryGetValue(obj, out recycleableItemAutomationPeer))
					{
						recycleableItemAutomationPeer = this.CreateAutomationPeer((global::Infragistics.Windows.DataPresenter.Record)obj);
					}
					if (recycleableItemAutomationPeer != null)
					{
						global::System.Windows.Automation.Peers.AutomationPeer underlyingPeer = ((global::Infragistics.Windows.Automation.Peers.IListAutomationPeer)this).GetUnderlyingPeer(obj);
						if (underlyingPeer != null)
						{
							underlyingPeer.EventsSource = recycleableItemAutomationPeer;
						}
					}
					list.Add(recycleableItemAutomationPeer);
					this._itemPeers[obj] = recycleableItemAutomationPeer;
				}
			}
			if (childrenHelperBaseItems != null)
			{
				list.AddRange(childrenHelperBaseItems);
			}
			return list;
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x0000776C File Offset: 0x0000596C
		private global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer> GetChildrenHelperBaseItems()
		{
			global::System.Windows.Automation.Peers.FrameworkElementAutomationPeer frameworkElementAutomationPeer = new global::System.Windows.Automation.Peers.FrameworkElementAutomationPeer(this._recordListControl);
			global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer> children = frameworkElementAutomationPeer.GetChildren();
			if (children != null)
			{
				for (int i = children.Count - 1; i >= 0; i--)
				{
					global::System.Windows.Automation.Peers.FrameworkElementAutomationPeer frameworkElementAutomationPeer2 = children[i] as global::System.Windows.Automation.Peers.FrameworkElementAutomationPeer;
					if (frameworkElementAutomationPeer2 != null && frameworkElementAutomationPeer2.Owner is global::System.Windows.Controls.ScrollViewer)
					{
						global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer> children2 = children[i].GetChildren();
						if (children2 != null)
						{
							for (int j = children2.Count - 1; j >= 0; j--)
							{
								global::System.Windows.Automation.Peers.FrameworkElementAutomationPeer frameworkElementAutomationPeer3 = children2[j] as global::System.Windows.Automation.Peers.FrameworkElementAutomationPeer;
								if (frameworkElementAutomationPeer3 != null)
								{
									if (frameworkElementAutomationPeer3.Owner is global::System.Windows.Controls.Primitives.ScrollBar)
									{
										children2.RemoveAt(j);
									}
									else if (frameworkElementAutomationPeer3 is global::Infragistics.Windows.Automation.Peers.DataPresenter.RecordPresenterAutomationPeer)
									{
										children2.RemoveAt(j);
									}
								}
							}
						}
						children.RemoveAt(i);
						if (children2 != null)
						{
							children.AddRange(children2);
						}
					}
					else if (this._recordListControl.ItemContainerGenerator.ItemFromContainer(frameworkElementAutomationPeer2.Owner) != global::System.Windows.DependencyProperty.UnsetValue)
					{
						children.RemoveAt(i);
					}
				}
			}
			return children;
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x0000786E File Offset: 0x00005A6E
		private global::Infragistics.Windows.DataPresenter.RecordCollectionBase GetRecordCollection()
		{
			return this._viewableRecordCollection.RecordCollection;
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x0000787B File Offset: 0x00005A7B
		private void OnCollectionChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			if (this.ProcessVisualTreeOnly)
			{
				return;
			}
			if (this._listAutomationPeerHelper != null)
			{
				this._listAutomationPeerHelper.ProcessListChange(e);
			}
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x0000789A File Offset: 0x00005A9A
		internal void InitializeViewableRecordsCollection(global::Infragistics.Windows.DataPresenter.ViewableRecordCollection viewableRecordCollection)
		{
			if (this._viewableRecordCollection != null)
			{
				this._viewableRecordCollection.CollectionChanged -= this.OnCollectionChanged;
			}
			this._viewableRecordCollection = viewableRecordCollection;
			this._viewableRecordCollection.CollectionChanged += this.OnCollectionChanged;
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x000078DC File Offset: 0x00005ADC
		global::System.Windows.DependencyObject global::Infragistics.Windows.Automation.Peers.IListAutomationPeer.ContainerFromItem(object item)
		{
			global::Infragistics.Windows.DataPresenter.Record record = item as global::Infragistics.Windows.DataPresenter.Record;
			if (record != null)
			{
				return record.AssociatedRecordPresenter;
			}
			throw new global::System.NotSupportedException("Don't know how to provide a container for the specified item!");
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x00007904 File Offset: 0x00005B04
		object global::Infragistics.Windows.Automation.Peers.IListAutomationPeer.GetPattern(global::System.Windows.Automation.Peers.PatternInterface patternInterface)
		{
			return this.GetPattern(patternInterface);
		}

		// Token: 0x060001DA RID: 474 RVA: 0x00007910 File Offset: 0x00005B10
		global::System.Windows.Automation.Peers.AutomationPeer global::Infragistics.Windows.Automation.Peers.IListAutomationPeer.GetUnderlyingPeer(object item)
		{
			global::Infragistics.Windows.DataPresenter.Record record = item as global::Infragistics.Windows.DataPresenter.Record;
			if (record != null && record.AssociatedRecordPresenter != null)
			{
				return global::System.Windows.Automation.Peers.UIElementAutomationPeer.CreatePeerForElement(record.AssociatedRecordPresenter);
			}
			return null;
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x060001DB RID: 475 RVA: 0x0000793C File Offset: 0x00005B3C
		global::System.Windows.Controls.Panel global::Infragistics.Windows.Automation.Peers.IListAutomationPeer.ItemsControlPanel
		{
			get
			{
				if (this._recordListControl.DataPresenter != null)
				{
					return this._recordListControl.DataPresenter.CurrentPanel;
				}
				return null;
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x060001DC RID: 476 RVA: 0x0000795D File Offset: 0x00005B5D
		global::System.Windows.UIElement global::Infragistics.Windows.Automation.Peers.IListAutomationPeer.Owner
		{
			get
			{
				return this._recordListControl;
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x060001DD RID: 477 RVA: 0x00007965 File Offset: 0x00005B65
		bool global::Infragistics.Windows.Automation.Peers.DataPresenter.IRecordListAutomationPeer.IsHorizontalRowLayout
		{
			get
			{
				return this.IsHorizontalRowLayout;
			}
		}

		// Token: 0x060001DE RID: 478 RVA: 0x0000796D File Offset: 0x00005B6D
		global::Infragistics.Windows.Automation.Peers.DataPresenter.RecordAutomationPeer global::Infragistics.Windows.Automation.Peers.DataPresenter.IRecordListAutomationPeer.CreateAutomationPeer(global::Infragistics.Windows.DataPresenter.Record record)
		{
			return this.CreateAutomationPeer(record);
		}

		// Token: 0x060001DF RID: 479 RVA: 0x00007976 File Offset: 0x00005B76
		global::Infragistics.Windows.Automation.Peers.DataPresenter.HeaderAutomationPeer global::Infragistics.Windows.Automation.Peers.DataPresenter.IRecordListAutomationPeer.GetHeaderPeer(global::Infragistics.Windows.DataPresenter.Record record)
		{
			return this._listAutomationPeerHelper.GetHeaderPeer(record);
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x00007984 File Offset: 0x00005B84
		bool global::Infragistics.Windows.Automation.Peers.DataPresenter.IRecordListAutomationPeer.CouldSupportGridPattern()
		{
			return this.CouldSupportGridPattern();
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x0000798C File Offset: 0x00005B8C
		global::Infragistics.Windows.DataPresenter.RecordCollectionBase global::Infragistics.Windows.Automation.Peers.DataPresenter.IRecordListAutomationPeer.GetRecordCollection()
		{
			return this.GetRecordCollection();
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x00007994 File Offset: 0x00005B94
		global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Record> global::Infragistics.Windows.Automation.Peers.DataPresenter.IRecordListAutomationPeer.GetRecordList()
		{
			return this._viewableRecordCollection;
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x0000799C File Offset: 0x00005B9C
		int global::Infragistics.Windows.Automation.Peers.DataPresenter.IRecordListAutomationPeer.GetTableRowIndex(global::Infragistics.Windows.DataPresenter.Cell cell)
		{
			return this._listAutomationPeerHelper.GetTableRowIndex(cell);
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x000079AA File Offset: 0x00005BAA
		global::System.Windows.Automation.Peers.AutomationPeer global::Infragistics.Windows.Automation.Peers.DataPresenter.IRecordListAutomationPeer.GetContainingGrid(global::Infragistics.Windows.DataPresenter.Cell cell)
		{
			return this._listAutomationPeerHelper.GetContainingGrid(cell);
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x060001E5 RID: 485 RVA: 0x000079B8 File Offset: 0x00005BB8
		bool global::Infragistics.Windows.Automation.Peers.DataPresenter.IRecordListAutomationPeer.IsRootLevel
		{
			get
			{
				return this.IsRootLevel;
			}
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x000079C0 File Offset: 0x00005BC0
		global::System.Windows.Automation.Provider.IRawElementProviderSimple global::Infragistics.Windows.Automation.Peers.DataPresenter.IRecordListAutomationPeer.ProviderFromPeer(global::System.Windows.Automation.Peers.AutomationPeer peer)
		{
			return base.ProviderFromPeer(peer);
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x060001E7 RID: 487 RVA: 0x000079C9 File Offset: 0x00005BC9
		bool global::System.Windows.Automation.Provider.ISelectionProvider.CanSelectMultiple
		{
			get
			{
				return this._listAutomationPeerHelper.ISelectionProvider_CanSelectMultiple;
			}
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x000079D6 File Offset: 0x00005BD6
		global::System.Windows.Automation.Provider.IRawElementProviderSimple[] global::System.Windows.Automation.Provider.ISelectionProvider.GetSelection()
		{
			return this._listAutomationPeerHelper.ISelectionProvider_GetSelection();
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x060001E9 RID: 489 RVA: 0x000079E3 File Offset: 0x00005BE3
		bool global::System.Windows.Automation.Provider.ISelectionProvider.IsSelectionRequired
		{
			get
			{
				return this._listAutomationPeerHelper.ISelectionProvider_IsSelectionRequired;
			}
		}

		// Token: 0x060001EA RID: 490 RVA: 0x000079F0 File Offset: 0x00005BF0
		global::System.Windows.Automation.Provider.IRawElementProviderSimple[] global::System.Windows.Automation.Provider.ITableProvider.GetColumnHeaders()
		{
			return this._listAutomationPeerHelper.ITableProvider_GetColumnHeaders();
		}

		// Token: 0x060001EB RID: 491 RVA: 0x000079FD File Offset: 0x00005BFD
		global::System.Windows.Automation.Provider.IRawElementProviderSimple[] global::System.Windows.Automation.Provider.ITableProvider.GetRowHeaders()
		{
			return this._listAutomationPeerHelper.ITableProvider_GetRowHeaders();
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x060001EC RID: 492 RVA: 0x00007A0A File Offset: 0x00005C0A
		global::System.Windows.Automation.RowOrColumnMajor global::System.Windows.Automation.Provider.ITableProvider.RowOrColumnMajor
		{
			get
			{
				return this._listAutomationPeerHelper.ITableProvider_RowOrColumnMajor;
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x060001ED RID: 493 RVA: 0x00007A17 File Offset: 0x00005C17
		int global::System.Windows.Automation.Provider.IGridProvider.ColumnCount
		{
			get
			{
				return this._listAutomationPeerHelper.IGridProvider_ColumnCount;
			}
		}

		// Token: 0x060001EE RID: 494 RVA: 0x00007A24 File Offset: 0x00005C24
		global::System.Windows.Automation.Provider.IRawElementProviderSimple global::System.Windows.Automation.Provider.IGridProvider.GetItem(int row, int column)
		{
			return this._listAutomationPeerHelper.IGridProvider_GetItem(row, column);
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x060001EF RID: 495 RVA: 0x00007A33 File Offset: 0x00005C33
		int global::System.Windows.Automation.Provider.IGridProvider.RowCount
		{
			get
			{
				return this._listAutomationPeerHelper.IGridProvider_RowCount;
			}
		}

		// Token: 0x04000057 RID: 87
		private const bool DebugGetChildren = false;

		// Token: 0x04000058 RID: 88
		private global::Infragistics.Windows.DataPresenter.RecordListControl _recordListControl;

		// Token: 0x04000059 RID: 89
		private global::Infragistics.Windows.DataPresenter.ViewableRecordCollection _viewableRecordCollection;

		// Token: 0x0400005A RID: 90
		private global::Infragistics.Windows.Automation.Peers.DataPresenter.ListAutomationPeerHelper _listAutomationPeerHelper;

		// Token: 0x0400005B RID: 91
		private global::System.Collections.Generic.Dictionary<object, global::Infragistics.Windows.Automation.Peers.RecycleableItemAutomationPeer> _itemPeers = new global::System.Collections.Generic.Dictionary<object, global::Infragistics.Windows.Automation.Peers.RecycleableItemAutomationPeer>();

		// Token: 0x0400005C RID: 92
		private bool _isRootLevel;
	}
}
