using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media.Animation;
using Infragistics.Collections;
using Infragistics.Windows.Controls;
using Infragistics.Windows.DataPresenter.Events;
using Infragistics.Windows.Selection;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020002FB RID: 763
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class CarouselViewPanel : global::Infragistics.Windows.Controls.XamCarouselPanel, global::Infragistics.Windows.DataPresenter.IViewPanel
	{
		// Token: 0x060023A7 RID: 9127 RVA: 0x0009B9D8 File Offset: 0x00099BD8
		protected override global::System.Windows.Size ArrangeOverride(global::System.Windows.Size finalSize)
		{
			global::System.Windows.Size result = base.ArrangeOverride(finalSize);
			if (!this._adornerInitialized)
			{
				this.InitializeAdorner();
			}
			return result;
		}

		// Token: 0x17000A6A RID: 2666
		// (get) Token: 0x060023A8 RID: 9128 RVA: 0x0009B9FC File Offset: 0x00099BFC
		protected override global::System.Collections.IEnumerator LogicalChildren
		{
			get
			{
				return new global::Infragistics.Collections.MultiSourceEnumerator(new global::System.Collections.IEnumerator[]
				{
					base.LogicalChildren,
					new global::Infragistics.Collections.SingleItemEnumerator(this._carouselBreadcrumbControl)
				});
			}
		}

		// Token: 0x060023A9 RID: 9129 RVA: 0x0009BA2D File Offset: 0x00099C2D
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size availableSize)
		{
			return base.MeasureOverride(availableSize);
		}

		// Token: 0x060023AA RID: 9130 RVA: 0x0009BA36 File Offset: 0x00099C36
		protected override void OnAnimatedScrollComplete(int newScrollPosition)
		{
			if (this.ViewPanelInfo != null)
			{
				this.ViewPanelInfo.OverallScrollPosition = newScrollPosition;
				this.ViewPanelInfo.OnRecordsInViewChanged();
			}
		}

		// Token: 0x060023AB RID: 9131 RVA: 0x0009BA58 File Offset: 0x00099C58
		protected override void OnItemsChanged(object sender, global::System.Windows.Controls.Primitives.ItemsChangedEventArgs args)
		{
			base.OnItemsChanged(sender, args);
			if (this.DataPresenter != null && this.DataPresenter.DefaultFieldLayout != this._fieldLayout)
			{
				if (this._fieldLayout != null)
				{
					this._fieldLayout.PropertyChanged -= this.OnFieldLayoutPropertyChanged;
					this._fieldLayout = null;
				}
				if (this.DataPresenter.DefaultFieldLayout != null)
				{
					this._fieldLayout = this.DataPresenter.DefaultFieldLayout;
					this._fieldLayout.PropertyChanged += this.OnFieldLayoutPropertyChanged;
				}
			}
		}

		// Token: 0x060023AC RID: 9132 RVA: 0x0009BAE3 File Offset: 0x00099CE3
		protected override void OnKeyDown(global::System.Windows.Input.KeyEventArgs e)
		{
		}

		// Token: 0x060023AD RID: 9133 RVA: 0x0009BAE8 File Offset: 0x00099CE8
		protected override void OnPropertyChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			base.OnPropertyChanged(e);
			if (e.Property == global::Infragistics.Windows.DataPresenter.DataPresenterBase.DataPresenterProperty)
			{
				if (e.OldValue != null)
				{
					global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenterBase = e.OldValue as global::Infragistics.Windows.DataPresenter.DataPresenterBase;
					if (dataPresenterBase != null)
					{
						dataPresenterBase.RecordCollapsed -= this.OnRecordCollapsed;
					}
				}
				this._dataPresenter = (e.NewValue as global::Infragistics.Windows.DataPresenter.DataPresenterBase);
				if (this._dataPresenter != null)
				{
					this._dataPresenter.RecordCollapsed += this.OnRecordCollapsed;
					return;
				}
			}
			else if (e.Property == global::Infragistics.Windows.DataPresenter.DataPresenterBase.CurrentViewProperty)
			{
				global::Infragistics.Windows.DataPresenter.CarouselView carouselView = e.OldValue as global::Infragistics.Windows.DataPresenter.CarouselView;
				global::Infragistics.Windows.Controls.CarouselViewSettings carouselViewSettings = null;
				if (carouselView != null)
				{
					this.HookViewDotViewSettingsChangedEvent(carouselView, false);
					carouselViewSettings = carouselView.ViewSettings;
				}
				if (carouselViewSettings != null)
				{
					global::System.Windows.DependencyObject parent = global::System.Windows.LogicalTreeHelper.GetParent(carouselViewSettings);
					if (parent == this)
					{
						base.RemoveLogicalChild(carouselViewSettings);
					}
				}
				global::Infragistics.Windows.DataPresenter.CarouselView carouselView2 = e.NewValue as global::Infragistics.Windows.DataPresenter.CarouselView;
				global::Infragistics.Windows.Controls.CarouselViewSettings carouselViewSettings2 = null;
				if (carouselView2 != null)
				{
					this.HookViewDotViewSettingsChangedEvent(carouselView2, true);
					carouselViewSettings2 = carouselView2.ViewSettings;
				}
				if (carouselViewSettings2 != null)
				{
					global::System.Windows.DependencyObject parent2 = global::System.Windows.LogicalTreeHelper.GetParent(carouselViewSettings2);
					if (parent2 != null && parent2 != this)
					{
						base.RemoveLogicalChild(carouselViewSettings2);
						parent2 = global::System.Windows.LogicalTreeHelper.GetParent(carouselViewSettings2);
					}
					if (parent2 == null)
					{
						base.AddLogicalChild(carouselViewSettings2);
					}
				}
			}
		}

		// Token: 0x060023AE RID: 9134 RVA: 0x0009BC0B File Offset: 0x00099E0B
		bool global::Infragistics.Windows.DataPresenter.IViewPanel.EnsureCellIsVisible(global::Infragistics.Windows.DataPresenter.Cell cell)
		{
			return ((global::Infragistics.Windows.DataPresenter.IViewPanel)this).EnsureRecordIsVisible(cell.Record);
		}

		// Token: 0x060023AF RID: 9135 RVA: 0x0009BC1C File Offset: 0x00099E1C
		bool global::Infragistics.Windows.DataPresenter.IViewPanel.EnsureRecordIsVisible(global::Infragistics.Windows.DataPresenter.Record record)
		{
			global::Infragistics.Windows.DataPresenter.IViewPanelInfo viewPanelInfo = this.ViewPanelInfo;
			int num = this.RecordListControl.Items.IndexOf(record);
			global::Infragistics.Windows.Controls.CarouselViewSettings viewSettings = base.ViewSettings;
			if (num < 0)
			{
				return false;
			}
			if (base.GetIsItemIndexVisible(num, base.FirstVisibleItemIndex))
			{
				return true;
			}
			if (num < base.FirstVisibleItemIndex)
			{
				if (this._lastPanelNavigationDirection != null && this._lastPanelNavigationDirection != null)
				{
					switch (this._lastPanelNavigationDirection.Value)
					{
					case global::Infragistics.Windows.DataPresenter.PanelNavigationDirection.Right:
					case global::Infragistics.Windows.DataPresenter.PanelNavigationDirection.Below:
					case global::Infragistics.Windows.DataPresenter.PanelNavigationDirection.Next:
						base.SetVerticalOffset(base.VerticalOffset + 1.0);
						goto IL_12F;
					}
					base.SetVerticalOffset((double)num);
				}
				else
				{
					base.SetVerticalOffset((double)num);
				}
			}
			else if (this._lastPanelNavigationDirection != null && this._lastPanelNavigationDirection != null)
			{
				global::Infragistics.Windows.DataPresenter.PanelNavigationDirection value = this._lastPanelNavigationDirection.Value;
				switch (value)
				{
				case global::Infragistics.Windows.DataPresenter.PanelNavigationDirection.Left:
				case global::Infragistics.Windows.DataPresenter.PanelNavigationDirection.Above:
					break;
				case global::Infragistics.Windows.DataPresenter.PanelNavigationDirection.Right:
					goto IL_FF;
				default:
					if (value != global::Infragistics.Windows.DataPresenter.PanelNavigationDirection.Previous)
					{
						goto IL_FF;
					}
					break;
				}
				base.SetVerticalOffset((double)(num - base.TotalItemCount));
				goto IL_12F;
				IL_FF:
				base.SetVerticalOffset((double)global::System.Math.Max(0, num - base.ItemsPerPageResolved + 1));
			}
			else
			{
				base.SetVerticalOffset((double)global::System.Math.Max(0, num - base.ItemsPerPageResolved + 1));
			}
			IL_12F:
			this._lastPanelNavigationDirection = null;
			return true;
		}

		// Token: 0x060023B0 RID: 9136 RVA: 0x0009BD65 File Offset: 0x00099F65
		global::Infragistics.Windows.DataPresenter.Record global::Infragistics.Windows.DataPresenter.IViewPanel.GetFirstDisplayedRecord(global::System.Type recordType)
		{
			if (base.FirstVisibleItemIndex >= 0)
			{
				return this.ViewPanelInfo.GetRecordAtOverallScrollPosition(base.FirstVisibleItemIndex);
			}
			return null;
		}

		// Token: 0x060023B1 RID: 9137 RVA: 0x0009BD83 File Offset: 0x00099F83
		global::Infragistics.Windows.DataPresenter.Record global::Infragistics.Windows.DataPresenter.IViewPanel.GetFirstOverallRecord(global::System.Type recordType)
		{
			return this.ViewPanelInfo.GetRecordAtOverallScrollPosition(0);
		}

		// Token: 0x060023B2 RID: 9138 RVA: 0x0009BD94 File Offset: 0x00099F94
		global::Infragistics.Windows.DataPresenter.Record global::Infragistics.Windows.DataPresenter.IViewPanel.GetLastDisplayedRecord(global::System.Type recordType)
		{
			if (base.FirstVisibleItemIndex >= 0)
			{
				global::Infragistics.Windows.DataPresenter.IViewPanelInfo viewPanelInfo = this.ViewPanelInfo;
				return viewPanelInfo.GetRecordAtOverallScrollPosition(global::System.Math.Min(viewPanelInfo.OverallScrollCount - 1, base.FirstVisibleItemIndex + base.ItemsPerPageResolved - 1));
			}
			return null;
		}

		// Token: 0x060023B3 RID: 9139 RVA: 0x0009BDD8 File Offset: 0x00099FD8
		global::Infragistics.Windows.DataPresenter.Record global::Infragistics.Windows.DataPresenter.IViewPanel.GetLastOverallRecord(global::System.Type recordType)
		{
			global::Infragistics.Windows.DataPresenter.IViewPanelInfo viewPanelInfo = this.ViewPanelInfo;
			int overallScrollCount = viewPanelInfo.OverallScrollCount;
			if (overallScrollCount == 0)
			{
				return null;
			}
			return viewPanelInfo.GetRecordAtOverallScrollPosition(overallScrollCount - 1);
		}

		// Token: 0x060023B4 RID: 9140 RVA: 0x0009BE04 File Offset: 0x0009A004
		global::Infragistics.Windows.DataPresenter.Record global::Infragistics.Windows.DataPresenter.IViewPanel.GetNavigationTargetRecord(global::Infragistics.Windows.DataPresenter.Record currentRecord, global::Infragistics.Windows.DataPresenter.PanelNavigationDirection navigationDirection, global::Infragistics.Windows.Selection.ISelectionHost selectionHost, bool shiftKeyDown, bool ctlKeyDown, global::Infragistics.Windows.DataPresenter.PanelSiblingNavigationStyle siblingNavigationStyle, global::System.Type restrictToRecordType)
		{
			global::Infragistics.Windows.DataPresenter.IViewPanelInfo viewPanelInfo = this.ViewPanelInfo;
			int overallScrollCount = viewPanelInfo.OverallScrollCount;
			int overallScrollPositionForRecord = viewPanelInfo.GetOverallScrollPositionForRecord(currentRecord);
			int num = -1;
			switch (navigationDirection)
			{
			case global::Infragistics.Windows.DataPresenter.PanelNavigationDirection.Left:
			case global::Infragistics.Windows.DataPresenter.PanelNavigationDirection.Above:
			case global::Infragistics.Windows.DataPresenter.PanelNavigationDirection.Previous:
				if (base.ViewSettings.IsListContinuous && overallScrollPositionForRecord == 0)
				{
					num = overallScrollCount - 1;
				}
				else
				{
					num = global::System.Math.Max(0, overallScrollPositionForRecord - 1);
				}
				break;
			case global::Infragistics.Windows.DataPresenter.PanelNavigationDirection.Right:
			case global::Infragistics.Windows.DataPresenter.PanelNavigationDirection.Below:
			case global::Infragistics.Windows.DataPresenter.PanelNavigationDirection.Next:
				if (base.ViewSettings.IsListContinuous && overallScrollPositionForRecord == overallScrollCount - 1)
				{
					num = 0;
				}
				else
				{
					num = global::System.Math.Min(overallScrollCount - 1, overallScrollPositionForRecord + 1);
				}
				break;
			}
			if (num >= 0 && num != overallScrollPositionForRecord)
			{
				global::Infragistics.Windows.DataPresenter.Record recordAtOverallScrollPosition = viewPanelInfo.GetRecordAtOverallScrollPosition(num);
				global::Infragistics.Windows.Selection.SelectionStrategyBase selectionStrategyForItem = selectionHost.GetSelectionStrategyForItem(recordAtOverallScrollPosition);
				if (selectionStrategyForItem == null)
				{
					throw new global::System.InvalidOperationException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_InvalidOperationException_4"));
				}
				if (selectionStrategyForItem.CanItemBeNavigatedTo(recordAtOverallScrollPosition, shiftKeyDown, ctlKeyDown))
				{
					this._lastPanelNavigationDirection = new global::Infragistics.Windows.DataPresenter.PanelNavigationDirection?(navigationDirection);
					return recordAtOverallScrollPosition;
				}
			}
			this._lastPanelNavigationDirection = null;
			return null;
		}

		// Token: 0x17000A6B RID: 2667
		// (get) Token: 0x060023B5 RID: 9141 RVA: 0x0009BEEC File Offset: 0x0009A0EC
		global::Infragistics.Windows.DataPresenter.PanelLayoutStyle global::Infragistics.Windows.DataPresenter.IViewPanel.LayoutStyle
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.PanelLayoutStyle.Custom;
			}
		}

		// Token: 0x060023B6 RID: 9142 RVA: 0x0009BEEF File Offset: 0x0009A0EF
		void global::Infragistics.Windows.DataPresenter.IViewPanel.OnActiveRecordChanged(global::Infragistics.Windows.DataPresenter.Record record)
		{
			((global::Infragistics.Windows.DataPresenter.IViewPanel)this).EnsureRecordIsVisible(record);
		}

		// Token: 0x060023B7 RID: 9143 RVA: 0x0009BEF9 File Offset: 0x0009A0F9
		void global::Infragistics.Windows.DataPresenter.IViewPanel.OnSelectedItemsChanged()
		{
		}

		// Token: 0x060023B8 RID: 9144 RVA: 0x0009BEFC File Offset: 0x0009A0FC
		void global::Infragistics.Windows.DataPresenter.IViewPanel.Scroll(global::Infragistics.Windows.DataPresenter.PanelNavigationScrollType scrollType)
		{
			switch (scrollType)
			{
			case global::Infragistics.Windows.DataPresenter.PanelNavigationScrollType.PageAbove:
				base.PageUp();
				return;
			case global::Infragistics.Windows.DataPresenter.PanelNavigationScrollType.PageBelow:
				base.PageDown();
				return;
			case global::Infragistics.Windows.DataPresenter.PanelNavigationScrollType.PageLeft:
				base.PageLeft();
				return;
			case global::Infragistics.Windows.DataPresenter.PanelNavigationScrollType.PageRight:
				base.PageRight();
				return;
			default:
				return;
			}
		}

		// Token: 0x17000A6C RID: 2668
		// (get) Token: 0x060023B9 RID: 9145 RVA: 0x0009BF3D File Offset: 0x0009A13D
		internal global::Infragistics.Windows.DataPresenter.DataPresenterBase DataPresenter
		{
			get
			{
				return this._dataPresenter;
			}
		}

		// Token: 0x17000A6D RID: 2669
		// (get) Token: 0x060023BA RID: 9146 RVA: 0x0009BF45 File Offset: 0x0009A145
		internal global::System.Collections.Generic.Stack<global::Infragistics.Windows.DataPresenter.CarouselViewPanel.ExpandedRecordInfo> ExpandedRecords
		{
			get
			{
				if (this._expandedRecordInfos == null)
				{
					this._expandedRecordInfos = new global::System.Collections.Generic.Stack<global::Infragistics.Windows.DataPresenter.CarouselViewPanel.ExpandedRecordInfo>(3);
				}
				return this._expandedRecordInfos;
			}
		}

		// Token: 0x17000A6E RID: 2670
		// (get) Token: 0x060023BB RID: 9147 RVA: 0x0009BF61 File Offset: 0x0009A161
		internal global::Infragistics.Windows.DataPresenter.RecordListControl RecordListControl
		{
			get
			{
				if (this._recordListControl == null)
				{
					this._recordListControl = (global::System.Windows.Controls.ItemsControl.GetItemsOwner(this) as global::Infragistics.Windows.DataPresenter.RecordListControl);
				}
				return this._recordListControl;
			}
		}

		// Token: 0x17000A6F RID: 2671
		// (get) Token: 0x060023BC RID: 9148 RVA: 0x0009BF82 File Offset: 0x0009A182
		internal global::Infragistics.Windows.DataPresenter.IViewPanelInfo ViewPanelInfo
		{
			get
			{
				return this.DataPresenter;
			}
		}

		// Token: 0x17000A70 RID: 2672
		// (get) Token: 0x060023BD RID: 9149 RVA: 0x0009BF8C File Offset: 0x0009A18C
		private global::Infragistics.Windows.DataPresenter.CarouselBreadcrumbControl CarouselBreadcrumbControl
		{
			get
			{
				if (this._carouselBreadcrumbControl == null)
				{
					this._carouselBreadcrumbControl = new global::Infragistics.Windows.DataPresenter.CarouselBreadcrumbControl();
					this._carouselBreadcrumbControl.CarouselBreadcrumbClick += this.OnCarouselBreadcrumbClick;
					if (global::System.Windows.LogicalTreeHelper.GetParent(this._carouselBreadcrumbControl) == null)
					{
						base.AddLogicalChild(this._carouselBreadcrumbControl);
					}
				}
				return this._carouselBreadcrumbControl;
			}
		}

		// Token: 0x060023BE RID: 9150 RVA: 0x0009BFE4 File Offset: 0x0009A1E4
		internal void OnRecordExpanded(global::Infragistics.Windows.DataPresenter.Record record)
		{
			if (record == null)
			{
				return;
			}
			if (!this.ExitEditModeOnCurrentActiveCell())
			{
				return;
			}
			if (record is global::Infragistics.Windows.DataPresenter.DataRecord && record.FieldLayout.Fields.ExpandableFieldsCount == 0)
			{
				return;
			}
			record.IsExpanded = true;
			if (!record.IsExpanded)
			{
				return;
			}
			global::Infragistics.Windows.DataPresenter.Record recordToUseForChildrenBindingSource;
			if (record is global::Infragistics.Windows.DataPresenter.GroupByRecord)
			{
				recordToUseForChildrenBindingSource = record;
			}
			else
			{
				if (record.FieldLayout.Fields.ExpandableFieldsCount != 1)
				{
					global::System.Windows.Controls.ContextMenu contextMenu = new global::System.Windows.Controls.ContextMenu();
					foreach (global::Infragistics.Windows.DataPresenter.Record record2 in ((global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Record>)record.ChildRecordsInternal))
					{
						global::System.Windows.Controls.MenuItem menuItem = new global::System.Windows.Controls.MenuItem();
						menuItem.Header = record2.AssociatedField.Name;
						menuItem.Tag = new global::Infragistics.Windows.DataPresenter.CarouselViewPanel.RecordExpansionChildSelectionInfo(record, record2);
						menuItem.Click += this.OnRecordExpansionChildSelectionMenuItemClick;
						contextMenu.Items.Add(menuItem);
					}
					this._recordExpansionChildSelectionMenuItemWasClicked = false;
					contextMenu.Closed += this.OnRecordExpansionChildSelectionMenuClosed;
					contextMenu.IsOpen = true;
					return;
				}
				recordToUseForChildrenBindingSource = record.ChildRecordsInternal[0];
			}
			this.ProcessRecordExpansion(new global::Infragistics.Windows.DataPresenter.CarouselViewPanel.RecordExpansionChildSelectionInfo(record, recordToUseForChildrenBindingSource));
		}

		// Token: 0x060023BF RID: 9151 RVA: 0x0009C11C File Offset: 0x0009A31C
		private bool ExitEditModeOnCurrentActiveCell()
		{
			if (this.DataPresenter != null && this.DataPresenter.ActiveCell != null && this.DataPresenter.ActiveCell.IsInEditMode)
			{
				this.DataPresenter.ActiveCell.EndEditMode();
				if (this.DataPresenter.ActiveCell != null && this.DataPresenter.ActiveCell.IsInEditMode)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x060023C0 RID: 9152 RVA: 0x0009C183 File Offset: 0x0009A383
		private void HookViewDotViewSettingsChangedEvent(global::Infragistics.Windows.DataPresenter.CarouselView view, bool hook)
		{
			if (hook)
			{
				base.SetBinding(global::Infragistics.Windows.Controls.XamCarouselPanel.ViewSettingsProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.DataPresenter.CarouselView.ViewSettingsProperty, global::System.Windows.Data.BindingMode.OneWay, view));
				return;
			}
			global::System.Windows.Data.BindingOperations.ClearBinding(this, global::Infragistics.Windows.Controls.XamCarouselPanel.ViewSettingsProperty);
		}

		// Token: 0x060023C1 RID: 9153 RVA: 0x0009C1AC File Offset: 0x0009A3AC
		private void InitializeAdorner()
		{
			if (this._adornerInitialized)
			{
				return;
			}
			base.AddAdornerChildElement(this.CarouselBreadcrumbControl);
			this._adornerInitialized = true;
		}

		// Token: 0x060023C2 RID: 9154 RVA: 0x0009C1CC File Offset: 0x0009A3CC
		private void NavigateUpToParent()
		{
			if (!this._canNavigateUpToParent)
			{
				return;
			}
			global::Infragistics.Windows.DataPresenter.CarouselViewPanel.ExpandedRecordInfo expandedRecordInfo = this.ExpandedRecords.Pop();
			this.CarouselBreadcrumbControl.PopBreadcrumb();
			base.ScrollOffsetForInitialArrangeAnimation = expandedRecordInfo.ScrollOffsetBeforeExpansion;
			global::Infragistics.Windows.DataPresenter.Record parentRecord = null;
			if (expandedRecordInfo.Record != null && expandedRecordInfo.Record.ParentCollection != null)
			{
				parentRecord = expandedRecordInfo.Record.ParentCollection.ParentRecord;
			}
			this.ReBindRecordListControlItemsSource(parentRecord);
			this._canNavigateUpToParent = (this.ExpandedRecords.Count > 0);
		}

		// Token: 0x060023C3 RID: 9155 RVA: 0x0009C24C File Offset: 0x0009A44C
		private void OnCarouselBreadcrumbClick(object sender, global::Infragistics.Windows.DataPresenter.Events.CarouselBreadcrumbClickEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.Record record = e.Breadcrumb.Content as global::Infragistics.Windows.DataPresenter.Record;
			if (record == null)
			{
				return;
			}
			if (!record.IsExpanded)
			{
				return;
			}
			this._ignoreRecordCollapsed = true;
			try
			{
				record.IsExpanded = false;
			}
			finally
			{
				this._ignoreRecordCollapsed = false;
			}
			if (record.IsExpanded)
			{
				return;
			}
			if (!this.ExitEditModeOnCurrentActiveCell())
			{
				return;
			}
			for (int i = this.CarouselBreadcrumbControl.PopBreadcrumbsUpTo(e.Breadcrumb); i > 0; i--)
			{
				this.ExpandedRecords.Pop();
			}
			this.NavigateUpToParent();
		}

		// Token: 0x060023C4 RID: 9156 RVA: 0x0009C2E4 File Offset: 0x0009A4E4
		private void OnFieldLayoutPropertyChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			if (e.PropertyName == "GroupByVersion")
			{
				while (this._canNavigateUpToParent)
				{
					this.NavigateUpToParent();
				}
			}
		}

		// Token: 0x060023C5 RID: 9157 RVA: 0x0009C308 File Offset: 0x0009A508
		private void OnItemsDisappearingStoryboardCompleted(object sender, global::System.EventArgs e)
		{
			if (this._totalDisappearingItemsRemaining > 1)
			{
				this._totalDisappearingItemsRemaining--;
				return;
			}
			this._tempItemsDisappearingStoryboard.Completed -= this.OnItemsDisappearingStoryboardCompleted;
			this.PerformRecordExpansionRebind(this._recordExpansionChildSelectionInfo);
		}

		// Token: 0x060023C6 RID: 9158 RVA: 0x0009C345 File Offset: 0x0009A545
		private void PerformRecordExpansionRebind(global::Infragistics.Windows.DataPresenter.CarouselViewPanel.RecordExpansionChildSelectionInfo recordExpansionChildSelectionInfo)
		{
			base.ScrollOffsetForInitialArrangeAnimation = 0.0;
			this.ReBindRecordListControlItemsSource(recordExpansionChildSelectionInfo.RecordToUseForChildrenBindingSource);
			this._canNavigateUpToParent = true;
		}

		// Token: 0x060023C7 RID: 9159 RVA: 0x0009C36C File Offset: 0x0009A56C
		private void OnRecordCollapsed(object sender, global::Infragistics.Windows.DataPresenter.Events.RecordCollapsedEventArgs e)
		{
			if (this._ignoreRecordCollapsed)
			{
				return;
			}
			bool flag = false;
			foreach (global::Infragistics.Windows.DataPresenter.CarouselViewPanel.ExpandedRecordInfo expandedRecordInfo in this.ExpandedRecords)
			{
				if (expandedRecordInfo.Record == e.Record)
				{
					flag = true;
					break;
				}
			}
			if (flag)
			{
				bool flag2 = false;
				while (!flag2 && this.ExpandedRecords.Count > 0)
				{
					global::Infragistics.Windows.DataPresenter.Record record = this.ExpandedRecords.Peek().Record;
					if (record == e.Record)
					{
						flag2 = true;
					}
					else
					{
						this.ExpandedRecords.Pop();
						this.CarouselBreadcrumbControl.PopBreadcrumb();
					}
				}
				if (flag2)
				{
					this.NavigateUpToParent();
				}
			}
		}

		// Token: 0x060023C8 RID: 9160 RVA: 0x0009C430 File Offset: 0x0009A630
		private void OnRecordExpansionChildSelectionMenuClosed(object sender, global::System.Windows.RoutedEventArgs e)
		{
			global::System.Windows.Controls.ContextMenu contextMenu = sender as global::System.Windows.Controls.ContextMenu;
			if (contextMenu != null && contextMenu.Items.Count > 0)
			{
				global::System.Windows.Controls.MenuItem menuItem = contextMenu.Items[0] as global::System.Windows.Controls.MenuItem;
				if (menuItem != null)
				{
					global::Infragistics.Windows.DataPresenter.CarouselViewPanel.RecordExpansionChildSelectionInfo recordExpansionChildSelectionInfo = menuItem.Tag as global::Infragistics.Windows.DataPresenter.CarouselViewPanel.RecordExpansionChildSelectionInfo;
					if (recordExpansionChildSelectionInfo != null)
					{
						foreach (object obj in base.ChildElements)
						{
							global::System.Windows.UIElement uielement = (global::System.Windows.UIElement)obj;
							global::Infragistics.Windows.DataPresenter.CarouselItem carouselItem = uielement as global::Infragistics.Windows.DataPresenter.CarouselItem;
							if (carouselItem != null && carouselItem.Record == recordExpansionChildSelectionInfo.ExpandedRecord)
							{
								carouselItem.IsExpanded = false;
								if (!this._recordExpansionChildSelectionMenuItemWasClicked)
								{
									carouselItem.Record.IsExpanded = false;
									break;
								}
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060023C9 RID: 9161 RVA: 0x0009C508 File Offset: 0x0009A708
		private void OnRecordExpansionChildSelectionMenuItemClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			this._recordExpansionChildSelectionMenuItemWasClicked = true;
			global::System.Windows.Controls.MenuItem menuItem = sender as global::System.Windows.Controls.MenuItem;
			if (menuItem != null)
			{
				this.ProcessRecordExpansion(menuItem.Tag as global::Infragistics.Windows.DataPresenter.CarouselViewPanel.RecordExpansionChildSelectionInfo);
			}
		}

		// Token: 0x060023CA RID: 9162 RVA: 0x0009C538 File Offset: 0x0009A738
		private void ProcessRecordExpansion(global::Infragistics.Windows.DataPresenter.CarouselViewPanel.RecordExpansionChildSelectionInfo recordExpansionChildSelectionInfo)
		{
			this.ExpandedRecords.Push(new global::Infragistics.Windows.DataPresenter.CarouselViewPanel.ExpandedRecordInfo(recordExpansionChildSelectionInfo.ExpandedRecord, base.VerticalOffset));
			this.CarouselBreadcrumbControl.PushBreadcrumb(new global::Infragistics.Windows.DataPresenter.CarouselBreadcrumb(recordExpansionChildSelectionInfo.ExpandedRecord));
			if (this._dataPresenter.ActiveRecord != null && this._dataPresenter.ActiveRecord != recordExpansionChildSelectionInfo.ExpandedRecord)
			{
				this._dataPresenter.ActiveRecord = null;
			}
			global::System.Collections.IList childElements = base.ChildElements;
			global::System.Windows.Media.Animation.Storyboard itemDisappearingStoryboard = (childElements[0] as global::Infragistics.Windows.DataPresenter.CarouselItem).ItemDisappearingStoryboard;
			if (itemDisappearingStoryboard != null)
			{
				this._tempItemsDisappearingStoryboard = itemDisappearingStoryboard.Clone();
				this._tempItemsDisappearingStoryboard.Completed += this.OnItemsDisappearingStoryboardCompleted;
				this._recordExpansionChildSelectionInfo = recordExpansionChildSelectionInfo;
				int count = childElements.Count;
				this._totalDisappearingItemsRemaining = 0;
				for (int i = 0; i < count; i++)
				{
					global::Infragistics.Windows.DataPresenter.CarouselItem carouselItem = childElements[i] as global::Infragistics.Windows.DataPresenter.CarouselItem;
					if (carouselItem != null && carouselItem.ItemDisappearingStoryboard != null)
					{
						this._tempItemsDisappearingStoryboard.Begin(carouselItem);
						this._totalDisappearingItemsRemaining++;
					}
				}
				return;
			}
			this.PerformRecordExpansionRebind(recordExpansionChildSelectionInfo);
		}

		// Token: 0x060023CB RID: 9163 RVA: 0x0009C644 File Offset: 0x0009A844
		private void ReBindRecordListControlItemsSource(global::Infragistics.Windows.DataPresenter.Record parentRecord)
		{
			global::System.Windows.Data.Binding binding = new global::System.Windows.Data.Binding();
			binding.Mode = global::System.Windows.Data.BindingMode.OneWay;
			if (parentRecord == null)
			{
				binding.Source = this.DataPresenter;
				binding.Path = new global::System.Windows.PropertyPath("ViewableRecords", new object[0]);
			}
			else
			{
				binding.Source = parentRecord;
				binding.Path = new global::System.Windows.PropertyPath("ViewableChildRecords", new object[0]);
			}
			this.RecordListControl.SetBinding(global::System.Windows.Controls.ItemsControl.ItemsSourceProperty, binding);
		}

		// Token: 0x04001152 RID: 4434
		private const int DEFAULT_ITEMS_PER_PAGE = 10;

		// Token: 0x04001153 RID: 4435
		private const int SCROLL_SMALL_CHANGE = 1;

		// Token: 0x04001154 RID: 4436
		private global::Infragistics.Windows.DataPresenter.RecordListControl _recordListControl;

		// Token: 0x04001155 RID: 4437
		private global::Infragistics.Windows.DataPresenter.DataPresenterBase _dataPresenter;

		// Token: 0x04001156 RID: 4438
		private global::System.Collections.Generic.Stack<global::Infragistics.Windows.DataPresenter.CarouselViewPanel.ExpandedRecordInfo> _expandedRecordInfos;

		// Token: 0x04001157 RID: 4439
		private global::Infragistics.Windows.DataPresenter.CarouselViewPanel.RecordExpansionChildSelectionInfo _recordExpansionChildSelectionInfo;

		// Token: 0x04001158 RID: 4440
		private global::Infragistics.Windows.DataPresenter.CarouselBreadcrumbControl _carouselBreadcrumbControl;

		// Token: 0x04001159 RID: 4441
		private bool _adornerInitialized;

		// Token: 0x0400115A RID: 4442
		private int _totalDisappearingItemsRemaining;

		// Token: 0x0400115B RID: 4443
		private global::System.Windows.Media.Animation.Storyboard _tempItemsDisappearingStoryboard;

		// Token: 0x0400115C RID: 4444
		private global::Infragistics.Windows.DataPresenter.PanelNavigationDirection? _lastPanelNavigationDirection = null;

		// Token: 0x0400115D RID: 4445
		private bool _canNavigateUpToParent;

		// Token: 0x0400115E RID: 4446
		private bool _ignoreRecordCollapsed;

		// Token: 0x0400115F RID: 4447
		private global::Infragistics.Windows.DataPresenter.FieldLayout _fieldLayout;

		// Token: 0x04001160 RID: 4448
		private bool _recordExpansionChildSelectionMenuItemWasClicked;

		// Token: 0x04001161 RID: 4449
		private static readonly global::System.Windows.Size DEFAULT_ITEM_SIZE = new global::System.Windows.Size(150.0, 100.0);

		// Token: 0x020002FC RID: 764
		private class RecordExpansionChildSelectionInfo
		{
			// Token: 0x060023CD RID: 9165 RVA: 0x0009C6D2 File Offset: 0x0009A8D2
			internal RecordExpansionChildSelectionInfo(global::Infragistics.Windows.DataPresenter.Record expandedRecord, global::Infragistics.Windows.DataPresenter.Record recordToUseForChildrenBindingSource)
			{
				this.ExpandedRecord = expandedRecord;
				this.RecordToUseForChildrenBindingSource = recordToUseForChildrenBindingSource;
			}

			// Token: 0x04001162 RID: 4450
			internal global::Infragistics.Windows.DataPresenter.Record ExpandedRecord;

			// Token: 0x04001163 RID: 4451
			internal global::Infragistics.Windows.DataPresenter.Record RecordToUseForChildrenBindingSource;
		}

		// Token: 0x020002FD RID: 765
		internal class ExpandedRecordInfo
		{
			// Token: 0x060023CE RID: 9166 RVA: 0x0009C6E8 File Offset: 0x0009A8E8
			internal ExpandedRecordInfo(global::Infragistics.Windows.DataPresenter.Record record, double scrollOffsetBeforeExpansion)
			{
				this._record = record;
				this._scrollOffsetBeforeExpansion = scrollOffsetBeforeExpansion;
			}

			// Token: 0x17000A71 RID: 2673
			// (get) Token: 0x060023CF RID: 9167 RVA: 0x0009C6FE File Offset: 0x0009A8FE
			internal global::Infragistics.Windows.DataPresenter.Record Record
			{
				get
				{
					return this._record;
				}
			}

			// Token: 0x17000A72 RID: 2674
			// (get) Token: 0x060023D0 RID: 9168 RVA: 0x0009C706 File Offset: 0x0009A906
			internal double ScrollOffsetBeforeExpansion
			{
				get
				{
					return this._scrollOffsetBeforeExpansion;
				}
			}

			// Token: 0x04001164 RID: 4452
			private global::Infragistics.Windows.DataPresenter.Record _record;

			// Token: 0x04001165 RID: 4453
			private double _scrollOffsetBeforeExpansion;
		}
	}
}
