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
	// Token: 0x0200033B RID: 827
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class CarouselViewPanel : global::Infragistics.Windows.Controls.XamCarouselPanel, global::Infragistics.Windows.DataPresenter.IViewPanel
	{
		// Token: 0x0600274A RID: 10058 RVA: 0x000AF364 File Offset: 0x000AD564
		protected override global::System.Windows.Size ArrangeOverride(global::System.Windows.Size finalSize)
		{
			global::System.Windows.Size result = base.ArrangeOverride(finalSize);
			if (!this._adornerInitialized)
			{
				this.InitializeAdorner();
			}
			return result;
		}

		// Token: 0x17000B97 RID: 2967
		// (get) Token: 0x0600274B RID: 10059 RVA: 0x000AF388 File Offset: 0x000AD588
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

		// Token: 0x0600274C RID: 10060 RVA: 0x000AF3B9 File Offset: 0x000AD5B9
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size availableSize)
		{
			return base.MeasureOverride(availableSize);
		}

		// Token: 0x0600274D RID: 10061 RVA: 0x000AF3C2 File Offset: 0x000AD5C2
		protected override void OnAnimatedScrollComplete(int newScrollPosition)
		{
			if (this.ViewPanelInfo != null)
			{
				this.ViewPanelInfo.OverallScrollPosition = newScrollPosition;
				this.ViewPanelInfo.OnRecordsInViewChanged();
			}
		}

		// Token: 0x0600274E RID: 10062 RVA: 0x000AF3E4 File Offset: 0x000AD5E4
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

		// Token: 0x0600274F RID: 10063 RVA: 0x000AF46F File Offset: 0x000AD66F
		protected override void OnKeyDown(global::System.Windows.Input.KeyEventArgs e)
		{
		}

		// Token: 0x06002750 RID: 10064 RVA: 0x000AF474 File Offset: 0x000AD674
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

		// Token: 0x06002751 RID: 10065 RVA: 0x000AF597 File Offset: 0x000AD797
		bool global::Infragistics.Windows.DataPresenter.IViewPanel.EnsureCellIsVisible(global::Infragistics.Windows.DataPresenter.Cell cell)
		{
			return ((global::Infragistics.Windows.DataPresenter.IViewPanel)this).EnsureRecordIsVisible(cell.Record);
		}

		// Token: 0x06002752 RID: 10066 RVA: 0x000AF5A8 File Offset: 0x000AD7A8
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

		// Token: 0x06002753 RID: 10067 RVA: 0x000AF6F1 File Offset: 0x000AD8F1
		global::Infragistics.Windows.DataPresenter.Record global::Infragistics.Windows.DataPresenter.IViewPanel.GetFirstDisplayedRecord(global::System.Type recordType)
		{
			if (base.FirstVisibleItemIndex >= 0)
			{
				return this.ViewPanelInfo.GetRecordAtOverallScrollPosition(base.FirstVisibleItemIndex);
			}
			return null;
		}

		// Token: 0x06002754 RID: 10068 RVA: 0x000AF70F File Offset: 0x000AD90F
		global::Infragistics.Windows.DataPresenter.Record global::Infragistics.Windows.DataPresenter.IViewPanel.GetFirstOverallRecord(global::System.Type recordType)
		{
			return this.ViewPanelInfo.GetRecordAtOverallScrollPosition(0);
		}

		// Token: 0x06002755 RID: 10069 RVA: 0x000AF720 File Offset: 0x000AD920
		global::Infragistics.Windows.DataPresenter.Record global::Infragistics.Windows.DataPresenter.IViewPanel.GetLastDisplayedRecord(global::System.Type recordType)
		{
			if (base.FirstVisibleItemIndex >= 0)
			{
				global::Infragistics.Windows.DataPresenter.IViewPanelInfo viewPanelInfo = this.ViewPanelInfo;
				return viewPanelInfo.GetRecordAtOverallScrollPosition(global::System.Math.Min(viewPanelInfo.OverallScrollCount - 1, base.FirstVisibleItemIndex + base.ItemsPerPageResolved - 1));
			}
			return null;
		}

		// Token: 0x06002756 RID: 10070 RVA: 0x000AF764 File Offset: 0x000AD964
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

		// Token: 0x06002757 RID: 10071 RVA: 0x000AF790 File Offset: 0x000AD990
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

		// Token: 0x17000B98 RID: 2968
		// (get) Token: 0x06002758 RID: 10072 RVA: 0x000AF878 File Offset: 0x000ADA78
		global::Infragistics.Windows.DataPresenter.PanelLayoutStyle global::Infragistics.Windows.DataPresenter.IViewPanel.LayoutStyle
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.PanelLayoutStyle.Custom;
			}
		}

		// Token: 0x06002759 RID: 10073 RVA: 0x000AF87B File Offset: 0x000ADA7B
		void global::Infragistics.Windows.DataPresenter.IViewPanel.OnActiveRecordChanged(global::Infragistics.Windows.DataPresenter.Record record)
		{
			((global::Infragistics.Windows.DataPresenter.IViewPanel)this).EnsureRecordIsVisible(record);
		}

		// Token: 0x0600275A RID: 10074 RVA: 0x000AF885 File Offset: 0x000ADA85
		void global::Infragistics.Windows.DataPresenter.IViewPanel.OnSelectedItemsChanged()
		{
		}

		// Token: 0x0600275B RID: 10075 RVA: 0x000AF888 File Offset: 0x000ADA88
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

		// Token: 0x17000B99 RID: 2969
		// (get) Token: 0x0600275C RID: 10076 RVA: 0x000AF8C9 File Offset: 0x000ADAC9
		internal global::Infragistics.Windows.DataPresenter.DataPresenterBase DataPresenter
		{
			get
			{
				return this._dataPresenter;
			}
		}

		// Token: 0x17000B9A RID: 2970
		// (get) Token: 0x0600275D RID: 10077 RVA: 0x000AF8D1 File Offset: 0x000ADAD1
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

		// Token: 0x17000B9B RID: 2971
		// (get) Token: 0x0600275E RID: 10078 RVA: 0x000AF8ED File Offset: 0x000ADAED
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

		// Token: 0x17000B9C RID: 2972
		// (get) Token: 0x0600275F RID: 10079 RVA: 0x000AF90E File Offset: 0x000ADB0E
		internal global::Infragistics.Windows.DataPresenter.IViewPanelInfo ViewPanelInfo
		{
			get
			{
				return this.DataPresenter;
			}
		}

		// Token: 0x17000B9D RID: 2973
		// (get) Token: 0x06002760 RID: 10080 RVA: 0x000AF918 File Offset: 0x000ADB18
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

		// Token: 0x06002761 RID: 10081 RVA: 0x000AF970 File Offset: 0x000ADB70
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

		// Token: 0x06002762 RID: 10082 RVA: 0x000AFAA8 File Offset: 0x000ADCA8
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

		// Token: 0x06002763 RID: 10083 RVA: 0x000AFB0F File Offset: 0x000ADD0F
		private void HookViewDotViewSettingsChangedEvent(global::Infragistics.Windows.DataPresenter.CarouselView view, bool hook)
		{
			if (hook)
			{
				base.SetBinding(global::Infragistics.Windows.Controls.XamCarouselPanel.ViewSettingsProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.DataPresenter.CarouselView.ViewSettingsProperty, global::System.Windows.Data.BindingMode.OneWay, view));
				return;
			}
			global::System.Windows.Data.BindingOperations.ClearBinding(this, global::Infragistics.Windows.Controls.XamCarouselPanel.ViewSettingsProperty);
		}

		// Token: 0x06002764 RID: 10084 RVA: 0x000AFB38 File Offset: 0x000ADD38
		private void InitializeAdorner()
		{
			if (this._adornerInitialized)
			{
				return;
			}
			base.AddAdornerChildElement(this.CarouselBreadcrumbControl);
			this._adornerInitialized = true;
		}

		// Token: 0x06002765 RID: 10085 RVA: 0x000AFB58 File Offset: 0x000ADD58
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

		// Token: 0x06002766 RID: 10086 RVA: 0x000AFBD8 File Offset: 0x000ADDD8
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

		// Token: 0x06002767 RID: 10087 RVA: 0x000AFC70 File Offset: 0x000ADE70
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

		// Token: 0x06002768 RID: 10088 RVA: 0x000AFC94 File Offset: 0x000ADE94
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

		// Token: 0x06002769 RID: 10089 RVA: 0x000AFCD1 File Offset: 0x000ADED1
		private void PerformRecordExpansionRebind(global::Infragistics.Windows.DataPresenter.CarouselViewPanel.RecordExpansionChildSelectionInfo recordExpansionChildSelectionInfo)
		{
			base.ScrollOffsetForInitialArrangeAnimation = 0.0;
			this.ReBindRecordListControlItemsSource(recordExpansionChildSelectionInfo.RecordToUseForChildrenBindingSource);
			this._canNavigateUpToParent = true;
		}

		// Token: 0x0600276A RID: 10090 RVA: 0x000AFCF8 File Offset: 0x000ADEF8
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

		// Token: 0x0600276B RID: 10091 RVA: 0x000AFDBC File Offset: 0x000ADFBC
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

		// Token: 0x0600276C RID: 10092 RVA: 0x000AFE94 File Offset: 0x000AE094
		private void OnRecordExpansionChildSelectionMenuItemClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			this._recordExpansionChildSelectionMenuItemWasClicked = true;
			global::System.Windows.Controls.MenuItem menuItem = sender as global::System.Windows.Controls.MenuItem;
			if (menuItem != null)
			{
				this.ProcessRecordExpansion(menuItem.Tag as global::Infragistics.Windows.DataPresenter.CarouselViewPanel.RecordExpansionChildSelectionInfo);
			}
		}

		// Token: 0x0600276D RID: 10093 RVA: 0x000AFEC4 File Offset: 0x000AE0C4
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

		// Token: 0x0600276E RID: 10094 RVA: 0x000AFFD0 File Offset: 0x000AE1D0
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

		// Token: 0x0400136C RID: 4972
		private const int DEFAULT_ITEMS_PER_PAGE = 10;

		// Token: 0x0400136D RID: 4973
		private const int SCROLL_SMALL_CHANGE = 1;

		// Token: 0x0400136E RID: 4974
		private global::Infragistics.Windows.DataPresenter.RecordListControl _recordListControl;

		// Token: 0x0400136F RID: 4975
		private global::Infragistics.Windows.DataPresenter.DataPresenterBase _dataPresenter;

		// Token: 0x04001370 RID: 4976
		private global::System.Collections.Generic.Stack<global::Infragistics.Windows.DataPresenter.CarouselViewPanel.ExpandedRecordInfo> _expandedRecordInfos;

		// Token: 0x04001371 RID: 4977
		private global::Infragistics.Windows.DataPresenter.CarouselViewPanel.RecordExpansionChildSelectionInfo _recordExpansionChildSelectionInfo;

		// Token: 0x04001372 RID: 4978
		private global::Infragistics.Windows.DataPresenter.CarouselBreadcrumbControl _carouselBreadcrumbControl;

		// Token: 0x04001373 RID: 4979
		private bool _adornerInitialized;

		// Token: 0x04001374 RID: 4980
		private int _totalDisappearingItemsRemaining;

		// Token: 0x04001375 RID: 4981
		private global::System.Windows.Media.Animation.Storyboard _tempItemsDisappearingStoryboard;

		// Token: 0x04001376 RID: 4982
		private global::Infragistics.Windows.DataPresenter.PanelNavigationDirection? _lastPanelNavigationDirection = null;

		// Token: 0x04001377 RID: 4983
		private bool _canNavigateUpToParent;

		// Token: 0x04001378 RID: 4984
		private bool _ignoreRecordCollapsed;

		// Token: 0x04001379 RID: 4985
		private global::Infragistics.Windows.DataPresenter.FieldLayout _fieldLayout;

		// Token: 0x0400137A RID: 4986
		private bool _recordExpansionChildSelectionMenuItemWasClicked;

		// Token: 0x0400137B RID: 4987
		private static readonly global::System.Windows.Size DEFAULT_ITEM_SIZE = new global::System.Windows.Size(150.0, 100.0);

		// Token: 0x0200033C RID: 828
		private class RecordExpansionChildSelectionInfo
		{
			// Token: 0x06002770 RID: 10096 RVA: 0x000B005E File Offset: 0x000AE25E
			internal RecordExpansionChildSelectionInfo(global::Infragistics.Windows.DataPresenter.Record expandedRecord, global::Infragistics.Windows.DataPresenter.Record recordToUseForChildrenBindingSource)
			{
				this.ExpandedRecord = expandedRecord;
				this.RecordToUseForChildrenBindingSource = recordToUseForChildrenBindingSource;
			}

			// Token: 0x0400137C RID: 4988
			internal global::Infragistics.Windows.DataPresenter.Record ExpandedRecord;

			// Token: 0x0400137D RID: 4989
			internal global::Infragistics.Windows.DataPresenter.Record RecordToUseForChildrenBindingSource;
		}

		// Token: 0x0200033D RID: 829
		internal class ExpandedRecordInfo
		{
			// Token: 0x06002771 RID: 10097 RVA: 0x000B0074 File Offset: 0x000AE274
			internal ExpandedRecordInfo(global::Infragistics.Windows.DataPresenter.Record record, double scrollOffsetBeforeExpansion)
			{
				this._record = record;
				this._scrollOffsetBeforeExpansion = scrollOffsetBeforeExpansion;
			}

			// Token: 0x17000B9E RID: 2974
			// (get) Token: 0x06002772 RID: 10098 RVA: 0x000B008A File Offset: 0x000AE28A
			internal global::Infragistics.Windows.DataPresenter.Record Record
			{
				get
				{
					return this._record;
				}
			}

			// Token: 0x17000B9F RID: 2975
			// (get) Token: 0x06002773 RID: 10099 RVA: 0x000B0092 File Offset: 0x000AE292
			internal double ScrollOffsetBeforeExpansion
			{
				get
				{
					return this._scrollOffsetBeforeExpansion;
				}
			}

			// Token: 0x0400137E RID: 4990
			private global::Infragistics.Windows.DataPresenter.Record _record;

			// Token: 0x0400137F RID: 4991
			private double _scrollOffsetBeforeExpansion;
		}
	}
}
