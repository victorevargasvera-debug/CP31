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
	public class ViewableRecordCollectionAutomationPeer : global::System.Windows.Automation.Peers.AutomationPeer, global::Infragistics.Windows.Automation.Peers.IListAutomationPeer, global::Infragistics.Windows.Automation.Peers.DataPresenter.IRecordListAutomationPeer, global::System.Windows.Automation.Provider.ISelectionProvider, global::System.Windows.Automation.Provider.ITableProvider, global::System.Windows.Automation.Provider.IGridProvider, global::System.Windows.Automation.Provider.IItemContainerProvider
	{
		// Token: 0x060001C9 RID: 457 RVA: 0x0000762C File Offset: 0x0000582C
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
			this._dpPeer = (global::System.Windows.Automation.Peers.UIElementAutomationPeer.CreatePeerForElement(this._viewableRecordCollection.RecordCollection.DataPresenter) as global::Infragistics.Windows.Automation.Peers.DataPresenter.DataPresenterBaseAutomationPeer);
			if (this._dpPeer != null)
			{
				this._dpPeer.AddProxyPeerHost(this);
			}
		}

		// Token: 0x060001CA RID: 458 RVA: 0x000076C7 File Offset: 0x000058C7
		protected override string GetAcceleratorKeyCore()
		{
			return string.Empty;
		}

		// Token: 0x060001CB RID: 459 RVA: 0x000076CE File Offset: 0x000058CE
		protected override string GetAccessKeyCore()
		{
			return string.Empty;
		}

		// Token: 0x060001CC RID: 460 RVA: 0x000076D5 File Offset: 0x000058D5
		protected override global::System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore()
		{
			if (!this._listAutomationPeerHelper.HasRecordGroups && this.GetPattern(global::System.Windows.Automation.Peers.PatternInterface.Table) != null)
			{
				return global::System.Windows.Automation.Peers.AutomationControlType.DataGrid;
			}
			return global::System.Windows.Automation.Peers.AutomationControlType.List;
		}

		// Token: 0x060001CD RID: 461 RVA: 0x000076F2 File Offset: 0x000058F2
		protected override string GetAutomationIdCore()
		{
			return string.Empty;
		}

		// Token: 0x060001CE RID: 462 RVA: 0x000076FC File Offset: 0x000058FC
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
			global::Infragistics.Windows.Automation.Peers.DataPresenter.HeaderAutomationPeer headerPeer = this.ShouldIncludeHeaderPeer ? this._listAutomationPeerHelper.HeaderPeer : null;
			result = (global::Infragistics.Windows.Automation.Peers.DataPresenter.RecordListGroup.GetVisibleBounds(this._viewableRecordCollection, headerPeer, true) ?? default(global::System.Windows.Rect));
			return result;
		}

		// Token: 0x060001CF RID: 463 RVA: 0x000077C8 File Offset: 0x000059C8
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
				global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer> childrenHelper = this.GetChildrenHelper(false);
				if (this._listAutomationPeerHelper.ShouldIncludeHeaderPeer)
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

		// Token: 0x060001D0 RID: 464 RVA: 0x00007898 File Offset: 0x00005A98
		protected override string GetClassNameCore()
		{
			return "ViewableRecordCollection";
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x000078A0 File Offset: 0x00005AA0
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

		// Token: 0x060001D2 RID: 466 RVA: 0x00007920 File Offset: 0x00005B20
		protected override string GetHelpTextCore()
		{
			return string.Empty;
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x00007927 File Offset: 0x00005B27
		protected override string GetItemStatusCore()
		{
			return string.Empty;
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x0000792E File Offset: 0x00005B2E
		protected override string GetItemTypeCore()
		{
			return string.Empty;
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x00007935 File Offset: 0x00005B35
		protected override global::System.Windows.Automation.Peers.AutomationPeer GetLabeledByCore()
		{
			return null;
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x00007938 File Offset: 0x00005B38
		protected override string GetNameCore()
		{
			return "Records";
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x00007940 File Offset: 0x00005B40
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

		// Token: 0x060001D8 RID: 472 RVA: 0x00007970 File Offset: 0x00005B70
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
			else if (patternInterface == global::System.Windows.Automation.Peers.PatternInterface.Grid || patternInterface == global::System.Windows.Automation.Peers.PatternInterface.Table)
			{
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
			else
			{
				if (patternInterface == global::System.Windows.Automation.Peers.PatternInterface.ItemContainer && !this._listAutomationPeerHelper.HasRecordGroups)
				{
					return this;
				}
				return null;
			}
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x00007A38 File Offset: 0x00005C38
		protected override bool HasKeyboardFocusCore()
		{
			return this._recordListControl.IsKeyboardFocused;
		}

		// Token: 0x060001DA RID: 474 RVA: 0x00007A45 File Offset: 0x00005C45
		protected override bool IsContentElementCore()
		{
			return true;
		}

		// Token: 0x060001DB RID: 475 RVA: 0x00007A48 File Offset: 0x00005C48
		protected override bool IsControlElementCore()
		{
			return true;
		}

		// Token: 0x060001DC RID: 476 RVA: 0x00007A4B File Offset: 0x00005C4B
		protected override bool IsEnabledCore()
		{
			return this._recordListControl.IsEnabled;
		}

		// Token: 0x060001DD RID: 477 RVA: 0x00007A58 File Offset: 0x00005C58
		protected override bool IsKeyboardFocusableCore()
		{
			return this._recordListControl.Focusable;
		}

		// Token: 0x060001DE RID: 478 RVA: 0x00007A65 File Offset: 0x00005C65
		protected override bool IsOffscreenCore()
		{
			return false;
		}

		// Token: 0x060001DF RID: 479 RVA: 0x00007A68 File Offset: 0x00005C68
		protected override bool IsPasswordCore()
		{
			return false;
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x00007A6B File Offset: 0x00005C6B
		protected override bool IsRequiredForFormCore()
		{
			return false;
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x00007A6E File Offset: 0x00005C6E
		protected override void SetFocusCore()
		{
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x060001E2 RID: 482 RVA: 0x00007A70 File Offset: 0x00005C70
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

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x060001E3 RID: 483 RVA: 0x00007AA8 File Offset: 0x00005CA8
		private bool IsRootLevel
		{
			get
			{
				return this._isRootLevel;
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x060001E4 RID: 484 RVA: 0x00007AB0 File Offset: 0x00005CB0
		private bool ProcessVisualTreeOnly
		{
			get
			{
				return global::Infragistics.Windows.Automation.Peers.DataPresenter.DataPresenterBaseAutomationPeer.ProcessVisualTreeOnly;
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x060001E5 RID: 485 RVA: 0x00007AB7 File Offset: 0x00005CB7
		private bool ShouldIncludeHeaderPeer
		{
			get
			{
				return !this.ProcessVisualTreeOnly && this._listAutomationPeerHelper.ShouldIncludeHeaderPeer;
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x060001E6 RID: 486 RVA: 0x00007ACE File Offset: 0x00005CCE
		internal global::Infragistics.Windows.DataPresenter.ViewableRecordCollection ViewableRecords
		{
			get
			{
				return this._viewableRecordCollection;
			}
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x00007AD8 File Offset: 0x00005CD8
		private bool CouldSupportGridPattern()
		{
			global::Infragistics.Windows.DataPresenter.RecordCollectionBase recordCollection = this._viewableRecordCollection.RecordCollection;
			return recordCollection != null && global::Infragistics.Windows.Automation.Peers.DataPresenter.ListAutomationPeerHelper.CouldSupportGridPattern(recordCollection.RecordsType) && this._listAutomationPeerHelper.IsHomogenousCollection();
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x00007B0E File Offset: 0x00005D0E
		private global::Infragistics.Windows.Automation.Peers.DataPresenter.RecordAutomationPeer CreateAutomationPeer(global::Infragistics.Windows.DataPresenter.Record record)
		{
			if (record == null)
			{
				throw new global::System.ArgumentNullException("record");
			}
			return global::Infragistics.Windows.Automation.Peers.DataPresenter.ListAutomationPeerHelper.CreateRecordAutomationPeer(record, this, this);
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x00007B28 File Offset: 0x00005D28
		private global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer> GetChildrenHelper(bool forceGetAll = false)
		{
			global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer> childrenHelperBaseItems = this.GetChildrenHelperBaseItems();
			global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer> list = new global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer>();
			if (!forceGetAll && global::Infragistics.Windows.Automation.Peers.DataPresenter.DataPresenterBaseAutomationPeer.ShouldVirtualizeRecordPeers)
			{
				if (this._dpPeer == null)
				{
					goto IL_11A;
				}
				using (global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Record> enumerator = this._dpPeer.GetRecordsInView(this._viewableRecordCollection).GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						global::Infragistics.Windows.DataPresenter.Record record = enumerator.Current;
						global::Infragistics.Windows.Automation.Peers.RecycleableItemAutomationPeer orCreateRecordAutomationPeer = global::Infragistics.Windows.Automation.Peers.DataPresenter.ListAutomationPeerHelper.GetOrCreateRecordAutomationPeer(record, this, this, this);
						global::System.Windows.Automation.Peers.AutomationPeer underlyingPeer = ((global::Infragistics.Windows.Automation.Peers.IListAutomationPeer)this).GetUnderlyingPeer(record);
						if (underlyingPeer != null)
						{
							underlyingPeer.EventsSource = orCreateRecordAutomationPeer;
						}
						list.Add(orCreateRecordAutomationPeer);
					}
					goto IL_11A;
				}
			}
			global::System.Collections.Generic.Dictionary<object, global::Infragistics.Windows.Automation.Peers.RecycleableItemAutomationPeer> itemPeers = this._itemPeers;
			this._itemPeers = new global::System.Collections.Generic.Dictionary<object, global::Infragistics.Windows.Automation.Peers.RecycleableItemAutomationPeer>();
			foreach (object obj in ((global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Record>)this._viewableRecordCollection))
			{
				if (obj != null)
				{
					global::Infragistics.Windows.Automation.Peers.RecycleableItemAutomationPeer orCreateRecordAutomationPeer2;
					if (!itemPeers.TryGetValue(obj, out orCreateRecordAutomationPeer2))
					{
						orCreateRecordAutomationPeer2 = global::Infragistics.Windows.Automation.Peers.DataPresenter.ListAutomationPeerHelper.GetOrCreateRecordAutomationPeer((global::Infragistics.Windows.DataPresenter.Record)obj, this, this, this);
					}
					if (orCreateRecordAutomationPeer2 != null)
					{
						global::System.Windows.Automation.Peers.AutomationPeer underlyingPeer2 = ((global::Infragistics.Windows.Automation.Peers.IListAutomationPeer)this).GetUnderlyingPeer(obj);
						if (underlyingPeer2 != null)
						{
							underlyingPeer2.EventsSource = orCreateRecordAutomationPeer2;
						}
					}
					list.Add(orCreateRecordAutomationPeer2);
					this._itemPeers[obj] = orCreateRecordAutomationPeer2;
				}
			}
			IL_11A:
			if (childrenHelperBaseItems != null)
			{
				list.AddRange(childrenHelperBaseItems);
			}
			return list;
		}

		// Token: 0x060001EA RID: 490 RVA: 0x00007C78 File Offset: 0x00005E78
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

		// Token: 0x060001EB RID: 491 RVA: 0x00007D7A File Offset: 0x00005F7A
		private global::Infragistics.Windows.DataPresenter.RecordCollectionBase GetRecordCollection()
		{
			return this._viewableRecordCollection.RecordCollection;
		}

		// Token: 0x060001EC RID: 492 RVA: 0x00007D87 File Offset: 0x00005F87
		private void OnCollectionChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			if (this.ProcessVisualTreeOnly)
			{
				return;
			}
			if (global::Infragistics.Windows.Automation.Peers.DataPresenter.DataPresenterBaseAutomationPeer.ShouldVirtualizeRecordPeers)
			{
				this._itemPeers.Clear();
			}
			if (this._listAutomationPeerHelper != null)
			{
				this._listAutomationPeerHelper.ProcessListChange(e);
			}
		}

		// Token: 0x060001ED RID: 493 RVA: 0x00007DB8 File Offset: 0x00005FB8
		internal void InitializeViewableRecordsCollection(global::Infragistics.Windows.DataPresenter.ViewableRecordCollection viewableRecordCollection)
		{
			if (global::Infragistics.Windows.Automation.Peers.DataPresenter.DataPresenterBaseAutomationPeer.ShouldVirtualizeRecordPeers)
			{
				this._itemPeers.Clear();
			}
			if (this._viewableRecordCollection != null)
			{
				this._viewableRecordCollection.CollectionChanged -= this.OnCollectionChanged;
			}
			this._viewableRecordCollection = viewableRecordCollection;
			this._viewableRecordCollection.CollectionChanged += this.OnCollectionChanged;
		}

		// Token: 0x060001EE RID: 494 RVA: 0x00007E14 File Offset: 0x00006014
		global::System.Windows.DependencyObject global::Infragistics.Windows.Automation.Peers.IListAutomationPeer.ContainerFromItem(object item)
		{
			global::Infragistics.Windows.DataPresenter.Record record = item as global::Infragistics.Windows.DataPresenter.Record;
			if (record != null)
			{
				return record.AssociatedRecordPresenter;
			}
			throw new global::System.NotSupportedException("Don't know how to provide a container for the specified item!");
		}

		// Token: 0x060001EF RID: 495 RVA: 0x00007E3C File Offset: 0x0000603C
		object global::Infragistics.Windows.Automation.Peers.IListAutomationPeer.GetPattern(global::System.Windows.Automation.Peers.PatternInterface patternInterface)
		{
			return this.GetPattern(patternInterface);
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x00007E48 File Offset: 0x00006048
		global::System.Windows.Automation.Peers.AutomationPeer global::Infragistics.Windows.Automation.Peers.IListAutomationPeer.GetUnderlyingPeer(object item)
		{
			global::Infragistics.Windows.DataPresenter.Record record = item as global::Infragistics.Windows.DataPresenter.Record;
			if (record != null && record.AssociatedRecordPresenter != null)
			{
				return global::System.Windows.Automation.Peers.UIElementAutomationPeer.CreatePeerForElement(record.AssociatedRecordPresenter);
			}
			return null;
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x060001F1 RID: 497 RVA: 0x00007E74 File Offset: 0x00006074
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

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x060001F2 RID: 498 RVA: 0x00007E95 File Offset: 0x00006095
		global::System.Windows.UIElement global::Infragistics.Windows.Automation.Peers.IListAutomationPeer.Owner
		{
			get
			{
				return this._recordListControl;
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x060001F3 RID: 499 RVA: 0x00007E9D File Offset: 0x0000609D
		bool global::Infragistics.Windows.Automation.Peers.DataPresenter.IRecordListAutomationPeer.IsHorizontalRowLayout
		{
			get
			{
				return this.IsHorizontalRowLayout;
			}
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x00007EA5 File Offset: 0x000060A5
		global::Infragistics.Windows.Automation.Peers.DataPresenter.RecordAutomationPeer global::Infragistics.Windows.Automation.Peers.DataPresenter.IRecordListAutomationPeer.CreateAutomationPeer(global::Infragistics.Windows.DataPresenter.Record record)
		{
			return this.CreateAutomationPeer(record);
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x00007EAE File Offset: 0x000060AE
		global::Infragistics.Windows.Automation.Peers.DataPresenter.HeaderAutomationPeer global::Infragistics.Windows.Automation.Peers.DataPresenter.IRecordListAutomationPeer.GetHeaderPeer(global::Infragistics.Windows.DataPresenter.Record record)
		{
			return this._listAutomationPeerHelper.GetHeaderPeer(record);
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x00007EBC File Offset: 0x000060BC
		bool global::Infragistics.Windows.Automation.Peers.DataPresenter.IRecordListAutomationPeer.CouldSupportGridPattern()
		{
			return this.CouldSupportGridPattern();
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x00007EC4 File Offset: 0x000060C4
		global::Infragistics.Windows.DataPresenter.RecordCollectionBase global::Infragistics.Windows.Automation.Peers.DataPresenter.IRecordListAutomationPeer.GetRecordCollection()
		{
			return this.GetRecordCollection();
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x00007ECC File Offset: 0x000060CC
		global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Record> global::Infragistics.Windows.Automation.Peers.DataPresenter.IRecordListAutomationPeer.GetRecordList()
		{
			return this._viewableRecordCollection;
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x00007ED4 File Offset: 0x000060D4
		int global::Infragistics.Windows.Automation.Peers.DataPresenter.IRecordListAutomationPeer.GetTableRowIndex(global::Infragistics.Windows.DataPresenter.Cell cell)
		{
			return this._listAutomationPeerHelper.GetTableRowIndex(cell);
		}

		// Token: 0x060001FA RID: 506 RVA: 0x00007EE2 File Offset: 0x000060E2
		global::System.Windows.Automation.Peers.AutomationPeer global::Infragistics.Windows.Automation.Peers.DataPresenter.IRecordListAutomationPeer.GetContainingGrid(global::Infragistics.Windows.DataPresenter.Cell cell)
		{
			return this._listAutomationPeerHelper.GetContainingGrid(cell);
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x060001FB RID: 507 RVA: 0x00007EF0 File Offset: 0x000060F0
		bool global::Infragistics.Windows.Automation.Peers.DataPresenter.IRecordListAutomationPeer.IsRootLevel
		{
			get
			{
				return this.IsRootLevel;
			}
		}

		// Token: 0x060001FC RID: 508 RVA: 0x00007EF8 File Offset: 0x000060F8
		global::System.Windows.Automation.Provider.IRawElementProviderSimple global::Infragistics.Windows.Automation.Peers.DataPresenter.IRecordListAutomationPeer.ProviderFromPeer(global::System.Windows.Automation.Peers.AutomationPeer peer)
		{
			return base.ProviderFromPeer(peer);
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x060001FD RID: 509 RVA: 0x00007F01 File Offset: 0x00006101
		bool global::System.Windows.Automation.Provider.ISelectionProvider.CanSelectMultiple
		{
			get
			{
				return this._listAutomationPeerHelper.ISelectionProvider_CanSelectMultiple;
			}
		}

		// Token: 0x060001FE RID: 510 RVA: 0x00007F0E File Offset: 0x0000610E
		global::System.Windows.Automation.Provider.IRawElementProviderSimple[] global::System.Windows.Automation.Provider.ISelectionProvider.GetSelection()
		{
			return this._listAutomationPeerHelper.ISelectionProvider_GetSelection();
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x060001FF RID: 511 RVA: 0x00007F1B File Offset: 0x0000611B
		bool global::System.Windows.Automation.Provider.ISelectionProvider.IsSelectionRequired
		{
			get
			{
				return this._listAutomationPeerHelper.ISelectionProvider_IsSelectionRequired;
			}
		}

		// Token: 0x06000200 RID: 512 RVA: 0x00007F28 File Offset: 0x00006128
		global::System.Windows.Automation.Provider.IRawElementProviderSimple[] global::System.Windows.Automation.Provider.ITableProvider.GetColumnHeaders()
		{
			return this._listAutomationPeerHelper.ITableProvider_GetColumnHeaders();
		}

		// Token: 0x06000201 RID: 513 RVA: 0x00007F35 File Offset: 0x00006135
		global::System.Windows.Automation.Provider.IRawElementProviderSimple[] global::System.Windows.Automation.Provider.ITableProvider.GetRowHeaders()
		{
			return this._listAutomationPeerHelper.ITableProvider_GetRowHeaders();
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06000202 RID: 514 RVA: 0x00007F42 File Offset: 0x00006142
		global::System.Windows.Automation.RowOrColumnMajor global::System.Windows.Automation.Provider.ITableProvider.RowOrColumnMajor
		{
			get
			{
				return this._listAutomationPeerHelper.ITableProvider_RowOrColumnMajor;
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000203 RID: 515 RVA: 0x00007F4F File Offset: 0x0000614F
		int global::System.Windows.Automation.Provider.IGridProvider.ColumnCount
		{
			get
			{
				return this._listAutomationPeerHelper.IGridProvider_ColumnCount;
			}
		}

		// Token: 0x06000204 RID: 516 RVA: 0x00007F5C File Offset: 0x0000615C
		global::System.Windows.Automation.Provider.IRawElementProviderSimple global::System.Windows.Automation.Provider.IGridProvider.GetItem(int row, int column)
		{
			return this._listAutomationPeerHelper.IGridProvider_GetItem(row, column);
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x06000205 RID: 517 RVA: 0x00007F6B File Offset: 0x0000616B
		int global::System.Windows.Automation.Provider.IGridProvider.RowCount
		{
			get
			{
				return this._listAutomationPeerHelper.IGridProvider_RowCount;
			}
		}

		// Token: 0x06000206 RID: 518 RVA: 0x00007F78 File Offset: 0x00006178
		global::System.Windows.Automation.Provider.IRawElementProviderSimple global::System.Windows.Automation.Provider.IItemContainerProvider.FindItemByProperty(global::System.Windows.Automation.Provider.IRawElementProviderSimple startAfter, int propertyId, object value)
		{
			if (propertyId != 0 && propertyId != global::System.Windows.Automation.AutomationElementIdentifiers.NameProperty.Id && propertyId != global::System.Windows.Automation.AutomationElementIdentifiers.AutomationIdProperty.Id && propertyId != global::System.Windows.Automation.AutomationElementIdentifiers.ControlTypeProperty.Id)
			{
				throw new global::System.ArgumentException("PropertyNotSupported");
			}
			global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer> list = global::Infragistics.Windows.Automation.Peers.DataPresenter.DataPresenterBaseAutomationPeer.ShouldVirtualizeRecordPeers ? this.GetChildrenHelper(true) : base.GetChildren();
			if (list.Count == 0)
			{
				return null;
			}
			global::Infragistics.Windows.Automation.Peers.DataPresenter.RecordAutomationPeer recordAutomationPeer = null;
			global::Infragistics.Windows.Automation.Peers.DataPresenter.HeaderAutomationPeer headerAutomationPeer = null;
			if (startAfter != null)
			{
				recordAutomationPeer = (base.PeerFromProvider(startAfter) as global::Infragistics.Windows.Automation.Peers.DataPresenter.RecordAutomationPeer);
				if (recordAutomationPeer == null)
				{
					headerAutomationPeer = (base.PeerFromProvider(startAfter) as global::Infragistics.Windows.Automation.Peers.DataPresenter.HeaderAutomationPeer);
				}
			}
			int i = 0;
			while (i < list.Count && !(list[i] is global::Infragistics.Windows.Automation.Peers.DataPresenter.HeaderAutomationPeer) && !(list[i] is global::Infragistics.Windows.Automation.Peers.DataPresenter.RecordAutomationPeer))
			{
				i++;
			}
			if (recordAutomationPeer != null || headerAutomationPeer != null)
			{
				global::Infragistics.Windows.DataPresenter.Record record = (recordAutomationPeer != null) ? recordAutomationPeer.Record : null;
				global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = (headerAutomationPeer != null) ? headerAutomationPeer.FieldLayout : null;
				int count = list.Count;
				int num = (recordAutomationPeer != null) ? (i + this._viewableRecordCollection.IndexOf(record)) : 0;
				i = -1;
				if (num >= 0)
				{
					int j = num;
					int num2 = global::System.Math.Min(count, num + this._viewableRecordCollection.CountOfSpecialRecordsOnTop + 2);
					while (j < num2)
					{
						if (recordAutomationPeer != null)
						{
							global::Infragistics.Windows.Automation.Peers.DataPresenter.RecordAutomationPeer recordAutomationPeer2 = list[j] as global::Infragistics.Windows.Automation.Peers.DataPresenter.RecordAutomationPeer;
							if (recordAutomationPeer2 != null && recordAutomationPeer2.Record == record)
							{
								i = j + 1;
								break;
							}
						}
						else
						{
							global::Infragistics.Windows.Automation.Peers.DataPresenter.HeaderAutomationPeer headerAutomationPeer2 = list[j] as global::Infragistics.Windows.Automation.Peers.DataPresenter.HeaderAutomationPeer;
							if (headerAutomationPeer2 != null && headerAutomationPeer2.FieldLayout == fieldLayout)
							{
								i = j + 1;
								break;
							}
						}
						j++;
					}
				}
			}
			if (propertyId != 0)
			{
				while (i < list.Count)
				{
					object automationPropertyValue = global::Infragistics.AutomationPeers.AutomationPeerHelper.GetAutomationPropertyValue(propertyId, list[i]);
					if (object.Equals(value, automationPropertyValue))
					{
						break;
					}
					i++;
				}
			}
			if (i < 0 || i >= list.Count)
			{
				return null;
			}
			return base.ProviderFromPeer(list[i]);
		}

		// Token: 0x04000067 RID: 103
		private const bool DebugGetChildren = false;

		// Token: 0x04000068 RID: 104
		private global::Infragistics.Windows.DataPresenter.RecordListControl _recordListControl;

		// Token: 0x04000069 RID: 105
		private global::Infragistics.Windows.DataPresenter.ViewableRecordCollection _viewableRecordCollection;

		// Token: 0x0400006A RID: 106
		private global::Infragistics.Windows.Automation.Peers.DataPresenter.ListAutomationPeerHelper _listAutomationPeerHelper;

		// Token: 0x0400006B RID: 107
		private global::System.Collections.Generic.Dictionary<object, global::Infragistics.Windows.Automation.Peers.RecycleableItemAutomationPeer> _itemPeers = new global::System.Collections.Generic.Dictionary<object, global::Infragistics.Windows.Automation.Peers.RecycleableItemAutomationPeer>();

		// Token: 0x0400006C RID: 108
		private bool _isRootLevel;

		// Token: 0x0400006D RID: 109
		private global::Infragistics.Windows.Automation.Peers.DataPresenter.DataPresenterBaseAutomationPeer _dpPeer;
	}
}
