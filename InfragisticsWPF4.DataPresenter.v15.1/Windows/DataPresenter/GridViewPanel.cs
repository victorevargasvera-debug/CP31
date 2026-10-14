using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Media;
using Infragistics.Collections;
using Infragistics.Windows.Controls;
using Infragistics.Windows.Helpers;
using Infragistics.Windows.Scrolling;
using Infragistics.Windows.Selection;
using Infragistics.Windows.Virtualization;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000177 RID: 375
	public abstract class GridViewPanel : global::Infragistics.Windows.Virtualization.RecyclingItemsPanel, global::System.Windows.Controls.Primitives.IScrollInfo, global::Infragistics.Windows.DataPresenter.IViewPanel, global::System.Windows.IWeakEventListener, global::Infragistics.Windows.Scrolling.IDeferredScrollPanel
	{
		// Token: 0x06001721 RID: 5921 RVA: 0x00066778 File Offset: 0x00064978
		static GridViewPanel()
		{
			global::System.Windows.EventManager.RegisterClassHandler(typeof(global::Infragistics.Windows.DataPresenter.GridViewPanel), global::System.Windows.FrameworkElement.RequestBringIntoViewEvent, new global::System.Windows.RequestBringIntoViewEventHandler(global::Infragistics.Windows.DataPresenter.GridViewPanel.OnRequestBringIntoView));
		}

		// Token: 0x06001722 RID: 5922 RVA: 0x00066807 File Offset: 0x00064A07
		internal GridViewPanel()
		{
		}

		// Token: 0x170005FF RID: 1535
		// (get) Token: 0x06001723 RID: 5923 RVA: 0x0006680F File Offset: 0x00064A0F
		protected override bool HasLogicalOrientation
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000600 RID: 1536
		// (get) Token: 0x06001724 RID: 5924 RVA: 0x00066814 File Offset: 0x00064A14
		protected override global::System.Collections.IEnumerator LogicalChildren
		{
			get
			{
				if (this._logicalChildren != null)
				{
					return new global::Infragistics.Collections.MultiSourceEnumerator(new global::System.Collections.IEnumerator[]
					{
						base.LogicalChildren,
						this._logicalChildren.GetEnumerator()
					});
				}
				return base.LogicalChildren;
			}
		}

		// Token: 0x17000601 RID: 1537
		// (get) Token: 0x06001725 RID: 5925 RVA: 0x0006685C File Offset: 0x00064A5C
		protected override global::System.Windows.Controls.Orientation LogicalOrientation
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.GridViewSettings gridViewSettings = this.ViewSettings as global::Infragistics.Windows.DataPresenter.GridViewSettings;
				if (gridViewSettings == null)
				{
					return global::System.Windows.Controls.Orientation.Vertical;
				}
				return gridViewSettings.Orientation;
			}
		}

		// Token: 0x06001726 RID: 5926 RVA: 0x00066880 File Offset: 0x00064A80
		protected override global::System.Windows.Media.Visual GetVisualChild(int index)
		{
			return base.GetVisualChild(index);
		}

		// Token: 0x06001727 RID: 5927 RVA: 0x00066889 File Offset: 0x00064A89
		protected override void OnChildDesiredSizeChanged(global::System.Windows.UIElement child)
		{
			if (this._isHidingRecord)
			{
				return;
			}
			if (child.Visibility == global::System.Windows.Visibility.Collapsed)
			{
				return;
			}
			base.OnChildDesiredSizeChanged(child);
		}

		// Token: 0x06001728 RID: 5928 RVA: 0x000668A8 File Offset: 0x00064AA8
		protected override void OnItemsChanged(object sender, global::System.Windows.Controls.Primitives.ItemsChangedEventArgs args)
		{
			if (args.Action == global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset && base.IsKeyboardFocusWithin)
			{
				global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this.DataPresenter;
				if (dataPresenter != null && dataPresenter.RecordContainerGenerationMode != global::Infragistics.Windows.Controls.ItemContainerGenerationMode.Recycle)
				{
					dataPresenter.ToggleFocusAsync();
				}
			}
			base.OnItemsChanged(sender, args);
			switch (args.Action)
			{
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Remove:
				this.RemoveRangeOfChldren(args.Position, args.ItemUICount);
				return;
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Replace:
				this.RemoveRangeOfChldren(args.Position, args.ItemUICount);
				return;
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Move:
				this.RemoveRangeOfChldren(args.OldPosition, args.ItemUICount);
				return;
			default:
				return;
			}
		}

		// Token: 0x06001729 RID: 5929 RVA: 0x0006693C File Offset: 0x00064B3C
		protected override void OnPropertyChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			base.OnPropertyChanged(e);
			if (e.Property == global::Infragistics.Windows.DataPresenter.DataPresenterBase.DataPresenterProperty)
			{
				this._dataPresenter = (e.NewValue as global::Infragistics.Windows.DataPresenter.DataPresenterBase);
				return;
			}
			if (e.Property == global::Infragistics.Windows.DataPresenter.GridViewPanel.ViewSettingsProperty)
			{
				if (this._viewSettings != null)
				{
					global::System.ComponentModel.PropertyChangedEventManager.RemoveListener(this._viewSettings, this, string.Empty);
				}
				this._viewSettings = (e.NewValue as global::Infragistics.Windows.DataPresenter.GridViewSettings);
				if (this._viewSettings != null)
				{
					global::System.ComponentModel.PropertyChangedEventManager.AddListener(this._viewSettings, this, string.Empty);
					this._viewSettings.EnumeratePropertiesWithNonDefaultValues(new global::System.ComponentModel.PropertyChangedEventHandler(this.OnViewSettingsPropertyChanged));
					if (this._dataPresenter != null)
					{
						this._dataPresenter.InitializeItemsPanel();
						return;
					}
				}
			}
			else if (e.Property == global::Infragistics.Windows.DataPresenter.DataPresenterBase.CurrentViewProperty)
			{
				global::Infragistics.Windows.DataPresenter.GridViewSettingsBase viewSettings = this.ViewSettings;
				if (viewSettings != null)
				{
					global::System.Windows.DependencyObject parent = global::System.Windows.LogicalTreeHelper.GetParent(viewSettings);
					if (parent == this)
					{
						base.RemoveLogicalChild(viewSettings);
					}
				}
				base.SetBinding(global::Infragistics.Windows.DataPresenter.GridViewPanel.ViewSettingsProperty, global::Infragistics.Windows.Utilities.CreateBindingObject("ViewSettings", global::System.Windows.Data.BindingMode.OneWay, global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetCurrentView(this)));
				viewSettings = this.ViewSettings;
				if (viewSettings != null)
				{
					global::System.Windows.DependencyObject parent2 = global::System.Windows.LogicalTreeHelper.GetParent(viewSettings);
					if (parent2 != null && parent2 != this)
					{
						base.RemoveLogicalChild(viewSettings);
						parent2 = global::System.Windows.LogicalTreeHelper.GetParent(viewSettings);
					}
					if (parent2 == null)
					{
						base.AddLogicalChild(viewSettings);
					}
				}
			}
		}

		// Token: 0x17000602 RID: 1538
		// (get) Token: 0x0600172A RID: 5930
		public abstract bool IsRootPanel { get; }

		// Token: 0x17000603 RID: 1539
		// (get) Token: 0x0600172B RID: 5931
		public abstract global::Infragistics.Windows.DataPresenter.GridViewPanel RootPanel { get; }

		// Token: 0x17000604 RID: 1540
		// (get) Token: 0x0600172C RID: 5932 RVA: 0x00066A6C File Offset: 0x00064C6C
		internal bool CanRecordsBeScrolled
		{
			get
			{
				if (!this.IsRootPanelInInfiniteContainer)
				{
					return true;
				}
				if (this.EffectiveScrollPosition > 0)
				{
					return true;
				}
				double num;
				double num2;
				if (this.LogicalOrientation == global::System.Windows.Controls.Orientation.Vertical)
				{
					num = this.HeightInfiniteContainersResolved;
					num2 = base.DesiredSize.Height;
				}
				else
				{
					num = this.WidthInfiniteContainersResolved;
					num2 = base.DesiredSize.Width;
				}
				return !double.IsPositiveInfinity(num) && num2 >= num;
			}
		}

		// Token: 0x17000605 RID: 1541
		// (get) Token: 0x0600172D RID: 5933 RVA: 0x00066AD6 File Offset: 0x00064CD6
		internal int CleanupThreshhold
		{
			get
			{
				return 10;
			}
		}

		// Token: 0x17000606 RID: 1542
		// (get) Token: 0x0600172E RID: 5934 RVA: 0x00066ADA File Offset: 0x00064CDA
		internal global::Infragistics.Windows.DataPresenter.DataPresenterBase DataPresenter
		{
			get
			{
				return this._dataPresenter;
			}
		}

		// Token: 0x17000607 RID: 1543
		// (get) Token: 0x0600172F RID: 5935 RVA: 0x00066AE2 File Offset: 0x00064CE2
		// (set) Token: 0x06001730 RID: 5936 RVA: 0x00066AF4 File Offset: 0x00064CF4
		internal bool DisplayNestedContent
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.GridViewPanel.DisplayNestedContentProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.GridViewPanel.DisplayNestedContentProperty, value);
			}
		}

		// Token: 0x17000608 RID: 1544
		// (get) Token: 0x06001731 RID: 5937
		// (set) Token: 0x06001732 RID: 5938
		internal abstract int EffectiveScrollPosition { get; set; }

		// Token: 0x17000609 RID: 1545
		// (get) Token: 0x06001733 RID: 5939
		internal abstract global::Infragistics.Windows.DataPresenter.Record FirstScrollableRecord { get; }

		// Token: 0x1700060A RID: 1546
		// (get) Token: 0x06001734 RID: 5940 RVA: 0x00066B07 File Offset: 0x00064D07
		internal global::Infragistics.Windows.DataPresenter.FixedFieldInfo FixedFieldInfo
		{
			get
			{
				if (this._fixedFieldInfo == null && this.IsRootPanel && this._dataPresenter != null && this._dataPresenter.IsFixedFieldsSupportedResolved)
				{
					this._fixedFieldInfo = new global::Infragistics.Windows.DataPresenter.FixedFieldInfo();
				}
				return this._fixedFieldInfo;
			}
		}

		// Token: 0x1700060B RID: 1547
		// (get) Token: 0x06001735 RID: 5941 RVA: 0x00066B40 File Offset: 0x00064D40
		internal virtual double HeightInfiniteContainersResolved
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.GridViewSettings gridViewSettings = this.ViewSettings as global::Infragistics.Windows.DataPresenter.GridViewSettings;
				if (gridViewSettings != null)
				{
					double heightInInfiniteContainers = gridViewSettings.HeightInInfiniteContainers;
					if (!double.IsNaN(heightInInfiniteContainers))
					{
						return heightInInfiniteContainers;
					}
				}
				return global::Infragistics.Windows.Helpers.SafeSystemInformation.VirtualScreenHeight;
			}
		}

		// Token: 0x1700060C RID: 1548
		// (get) Token: 0x06001736 RID: 5942 RVA: 0x00066B72 File Offset: 0x00064D72
		// (set) Token: 0x06001737 RID: 5943 RVA: 0x00066B7A File Offset: 0x00064D7A
		internal bool IsHidingRecord
		{
			get
			{
				return this._isHidingRecord;
			}
			set
			{
				this._isHidingRecord = value;
			}
		}

		// Token: 0x1700060D RID: 1549
		// (get) Token: 0x06001738 RID: 5944
		internal abstract bool IsRootPanelInInfiniteContainer { get; }

		// Token: 0x1700060E RID: 1550
		// (get) Token: 0x06001739 RID: 5945 RVA: 0x00066B83 File Offset: 0x00064D83
		internal bool IsScrolling
		{
			get
			{
				return this.IsRootPanel && this.ScrollingData._scrollOwner != null;
			}
		}

		// Token: 0x1700060F RID: 1551
		// (get) Token: 0x0600173A RID: 5946 RVA: 0x00066BA0 File Offset: 0x00064DA0
		internal int MouseWheelScrollMultiplier
		{
			get
			{
				return global::System.Windows.SystemParameters.WheelScrollLines;
			}
		}

		// Token: 0x17000610 RID: 1552
		// (get) Token: 0x0600173B RID: 5947 RVA: 0x00066BA8 File Offset: 0x00064DA8
		internal global::Infragistics.Windows.DataPresenter.Record RecordAtEffectiveScrollPosition
		{
			get
			{
				int effectiveScrollPosition = this.EffectiveScrollPosition;
				return this.ViewPanelInfo.GetRecordAtOverallScrollPosition(effectiveScrollPosition);
			}
		}

		// Token: 0x17000611 RID: 1553
		// (get) Token: 0x0600173C RID: 5948 RVA: 0x00066BC8 File Offset: 0x00064DC8
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

		// Token: 0x17000612 RID: 1554
		// (get) Token: 0x0600173D RID: 5949
		internal abstract int RootPanelTopFixedOffset { get; }

		// Token: 0x17000613 RID: 1555
		// (get) Token: 0x0600173E RID: 5950 RVA: 0x00066BE9 File Offset: 0x00064DE9
		// (set) Token: 0x0600173F RID: 5951 RVA: 0x00066BF1 File Offset: 0x00064DF1
		internal bool SetOffsetTriggeredByPageBack
		{
			get
			{
				return this._setOffsetTriggeredByPageBack;
			}
			set
			{
				this._setOffsetTriggeredByPageBack = value;
			}
		}

		// Token: 0x17000614 RID: 1556
		// (get) Token: 0x06001740 RID: 5952 RVA: 0x00066BFA File Offset: 0x00064DFA
		internal global::Infragistics.Windows.DataPresenter.GridViewPanel.ScrollData ScrollingData
		{
			get
			{
				if (this._scrollingData == null)
				{
					this._scrollingData = new global::Infragistics.Windows.DataPresenter.GridViewPanel.ScrollData();
				}
				return this._scrollingData;
			}
		}

		// Token: 0x17000615 RID: 1557
		// (get) Token: 0x06001741 RID: 5953
		internal abstract int ScrollPositionOfLastVisibleRecord { get; }

		// Token: 0x17000616 RID: 1558
		// (get) Token: 0x06001742 RID: 5954 RVA: 0x00066C15 File Offset: 0x00064E15
		internal double ScrollSmallChangeInNonOrientationDimension
		{
			get
			{
				return 20.0;
			}
		}

		// Token: 0x17000617 RID: 1559
		// (get) Token: 0x06001743 RID: 5955 RVA: 0x00066C20 File Offset: 0x00064E20
		internal double ScrollSmallChangeInOrientationDimension
		{
			get
			{
				return 1.0;
			}
		}

		// Token: 0x17000618 RID: 1560
		// (get) Token: 0x06001744 RID: 5956 RVA: 0x00066C2B File Offset: 0x00064E2B
		internal int TotalGeneratedChildrenCount
		{
			get
			{
				if (!base.IsItemsHost)
				{
					return 0;
				}
				return base.ChildElements.Count;
			}
		}

		// Token: 0x17000619 RID: 1561
		// (get) Token: 0x06001745 RID: 5957 RVA: 0x00066C42 File Offset: 0x00064E42
		internal global::Infragistics.Windows.DataPresenter.IViewPanelInfo ViewPanelInfo
		{
			get
			{
				return this.DataPresenter;
			}
		}

		// Token: 0x06001746 RID: 5958 RVA: 0x00066C4A File Offset: 0x00064E4A
		private static object OnCoerceViewSettings(global::System.Windows.DependencyObject d, object value)
		{
			if (value == null)
			{
				return ((global::Infragistics.Windows.DataPresenter.GridViewPanel)d).CreateDefaultViewSettings();
			}
			return value;
		}

		// Token: 0x06001747 RID: 5959 RVA: 0x00066C5C File Offset: 0x00064E5C
		internal virtual global::Infragistics.Windows.DataPresenter.GridViewSettingsBase CreateDefaultViewSettings()
		{
			return new global::Infragistics.Windows.DataPresenter.GridViewSettings();
		}

		// Token: 0x1700061A RID: 1562
		// (get) Token: 0x06001748 RID: 5960 RVA: 0x00066C63 File Offset: 0x00064E63
		// (set) Token: 0x06001749 RID: 5961 RVA: 0x00066C75 File Offset: 0x00064E75
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.DataPresenter.GridViewSettingsBase ViewSettings
		{
			get
			{
				return base.GetValue(global::Infragistics.Windows.DataPresenter.GridViewPanel.ViewSettingsProperty) as global::Infragistics.Windows.DataPresenter.GridViewSettingsBase;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.GridViewPanel.ViewSettingsProperty, value);
			}
		}

		// Token: 0x0600174A RID: 5962 RVA: 0x00066C83 File Offset: 0x00064E83
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeViewSettings()
		{
			return this.ViewSettings != (global::Infragistics.Windows.DataPresenter.GridViewSettingsBase)global::Infragistics.Windows.DataPresenter.GridViewPanel.ViewSettingsProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x0600174B RID: 5963 RVA: 0x00066CA4 File Offset: 0x00064EA4
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetViewSettings()
		{
			this.ViewSettings = (global::Infragistics.Windows.DataPresenter.GridViewSettingsBase)global::Infragistics.Windows.DataPresenter.GridViewPanel.ViewSettingsProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x1700061B RID: 1563
		// (get) Token: 0x0600174C RID: 5964 RVA: 0x00066CC0 File Offset: 0x00064EC0
		internal virtual double WidthInfiniteContainersResolved
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.GridViewSettings gridViewSettings = this.ViewSettings as global::Infragistics.Windows.DataPresenter.GridViewSettings;
				if (gridViewSettings != null)
				{
					double widthInInfiniteContainers = gridViewSettings.WidthInInfiniteContainers;
					if (!double.IsNaN(widthInInfiniteContainers))
					{
						return widthInInfiniteContainers;
					}
				}
				return global::Infragistics.Windows.Helpers.SafeSystemInformation.VirtualScreenWidth;
			}
		}

		// Token: 0x0600174D RID: 5965 RVA: 0x00066CF2 File Offset: 0x00064EF2
		private int EnsureIntInRange(int value, int minValue, int maxValue)
		{
			return global::System.Math.Max(global::System.Math.Min(maxValue, value), minValue);
		}

		// Token: 0x0600174E RID: 5966 RVA: 0x00066D04 File Offset: 0x00064F04
		private global::Infragistics.Windows.DataPresenter.DataRecord GetDescendantDataRecord(global::Infragistics.Windows.DataPresenter.Record parent, bool getNext)
		{
			if (parent.CanExpand)
			{
				global::Infragistics.Windows.DataPresenter.ViewableRecordCollection viewableChildRecordsIfNeeded = parent.ViewableChildRecordsIfNeeded;
				int num = (viewableChildRecordsIfNeeded != null) ? viewableChildRecordsIfNeeded.Count : 0;
				if (num > 0)
				{
					int num2;
					int num3;
					if (getNext)
					{
						num2 = 0;
						num3 = 1;
					}
					else
					{
						num2 = num - 1;
						num3 = -1;
					}
					int num4 = num2;
					while (getNext ? (num4 < num) : (num4 >= 0))
					{
						global::Infragistics.Windows.DataPresenter.Record record = viewableChildRecordsIfNeeded[num4];
						if (record is global::Infragistics.Windows.DataPresenter.DataRecord && !(record is global::Infragistics.Windows.DataPresenter.HeaderRecord))
						{
							return record as global::Infragistics.Windows.DataPresenter.DataRecord;
						}
						record = this.GetDescendantDataRecord(record, getNext);
						if (record != null)
						{
							return record as global::Infragistics.Windows.DataPresenter.DataRecord;
						}
						num4 += num3;
					}
				}
			}
			return null;
		}

		// Token: 0x0600174F RID: 5967 RVA: 0x00066D96 File Offset: 0x00064F96
		private int GetEffectiveGeneratedCount(global::System.Windows.Controls.UIElementCollection children)
		{
			if (!base.IsItemsHost)
			{
				return 0;
			}
			return children.Count;
		}

		// Token: 0x06001750 RID: 5968 RVA: 0x00066DA8 File Offset: 0x00064FA8
		private global::Infragistics.Windows.DataPresenter.Record GetNavigationTargetRecord(global::Infragistics.Windows.DataPresenter.PanelNavigationDirection navigationDirection, global::Infragistics.Windows.DataPresenter.Record currentRecord, global::Infragistics.Windows.DataPresenter.PanelSiblingNavigationStyle siblingNavigationStyle, global::System.Type restrictToRecordType)
		{
			if (!this.IsRootPanel)
			{
				return this.RootPanel.GetNavigationTargetRecord(navigationDirection, currentRecord, siblingNavigationStyle, restrictToRecordType);
			}
			if (this.ViewSettings == null)
			{
				return null;
			}
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this.DataPresenter;
			global::Infragistics.Windows.DataPresenter.IViewPanelInfo viewPanelInfo = this.ViewPanelInfo;
			int overallScrollCount = viewPanelInfo.OverallScrollCount;
			bool flag = this.LogicalOrientation == global::System.Windows.Controls.Orientation.Vertical;
			bool flag2 = false;
			bool flag3 = false;
			switch (navigationDirection)
			{
			case global::Infragistics.Windows.DataPresenter.PanelNavigationDirection.Left:
				if (flag)
				{
					return null;
				}
				flag2 = true;
				break;
			case global::Infragistics.Windows.DataPresenter.PanelNavigationDirection.Right:
				if (flag)
				{
					return null;
				}
				flag3 = true;
				break;
			case global::Infragistics.Windows.DataPresenter.PanelNavigationDirection.Above:
				if (!flag)
				{
					return null;
				}
				flag2 = true;
				break;
			case global::Infragistics.Windows.DataPresenter.PanelNavigationDirection.Below:
				if (!flag)
				{
					return null;
				}
				flag3 = true;
				break;
			case global::Infragistics.Windows.DataPresenter.PanelNavigationDirection.Next:
				flag3 = true;
				break;
			case global::Infragistics.Windows.DataPresenter.PanelNavigationDirection.Previous:
				flag2 = true;
				break;
			}
			global::Infragistics.Windows.DataPresenter.Record record = currentRecord;
			global::Infragistics.Windows.DataPresenter.Record record2 = null;
			while (record2 == null)
			{
				if (siblingNavigationStyle == global::Infragistics.Windows.DataPresenter.PanelSiblingNavigationStyle.AcrossParentsAndWrap || siblingNavigationStyle == global::Infragistics.Windows.DataPresenter.PanelSiblingNavigationStyle.AcrossParentsNoWrap)
				{
					int overallScrollPositionForRecord = viewPanelInfo.GetOverallScrollPositionForRecord(record);
					if (overallScrollPositionForRecord == -1)
					{
						return null;
					}
					if (flag2 && overallScrollPositionForRecord < 1)
					{
						if (siblingNavigationStyle == global::Infragistics.Windows.DataPresenter.PanelSiblingNavigationStyle.AcrossParentsNoWrap)
						{
							return null;
						}
						record2 = viewPanelInfo.GetRecordAtOverallScrollPosition(overallScrollCount - 1);
					}
					else if (flag3 && overallScrollPositionForRecord > overallScrollCount - 2)
					{
						if (siblingNavigationStyle == global::Infragistics.Windows.DataPresenter.PanelSiblingNavigationStyle.AcrossParentsNoWrap)
						{
							return null;
						}
						record2 = viewPanelInfo.GetRecordAtOverallScrollPosition(0);
					}
					else if (flag2)
					{
						record2 = viewPanelInfo.GetRecordAtOverallScrollPosition(overallScrollPositionForRecord - 1);
					}
					else if (flag3)
					{
						record2 = viewPanelInfo.GetRecordAtOverallScrollPosition(overallScrollPositionForRecord + 1);
					}
				}
				else
				{
					global::Infragistics.Windows.DataPresenter.ViewableRecordCollection viewableRecords = record.ParentCollection.ViewableRecords;
					int num = viewableRecords.IndexOf(record);
					if (num == -1)
					{
						return null;
					}
					if (flag2 && num < 1)
					{
						if (siblingNavigationStyle == global::Infragistics.Windows.DataPresenter.PanelSiblingNavigationStyle.StayWithinParentNoWrap)
						{
							return null;
						}
						record2 = viewableRecords[viewableRecords.Count - 1];
					}
					else if (flag3 && num > viewableRecords.Count - 2)
					{
						if (siblingNavigationStyle == global::Infragistics.Windows.DataPresenter.PanelSiblingNavigationStyle.StayWithinParentNoWrap)
						{
							return null;
						}
						record2 = viewableRecords[0];
					}
					else if (flag2)
					{
						record2 = viewableRecords[num - 1];
					}
					else if (flag3)
					{
						record2 = viewableRecords[num + 1];
					}
				}
				if (record2 == null || restrictToRecordType.IsAssignableFrom(record2.GetType()))
				{
					return record2;
				}
				record = record2;
				record2 = null;
				if (restrictToRecordType == typeof(global::Infragistics.Windows.DataPresenter.DataRecord) && (record.GetType() == typeof(global::Infragistics.Windows.DataPresenter.GroupByRecord) || record.GetType() == typeof(global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord)) && !record.IsAncestorOf(currentRecord))
				{
					global::Infragistics.Windows.DataPresenter.DataRecord descendantDataRecord = this.GetDescendantDataRecord(record, flag3);
					if (descendantDataRecord != null)
					{
						descendantDataRecord.ParentRecord.IsExpanded = true;
						return descendantDataRecord;
					}
				}
			}
			return null;
		}

		// Token: 0x06001751 RID: 5969 RVA: 0x00066FFC File Offset: 0x000651FC
		private static void OnRequestBringIntoView(object sender, global::System.Windows.RequestBringIntoViewEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.GridViewPanel gridViewPanel = (global::Infragistics.Windows.DataPresenter.GridViewPanel)sender;
			if (e.OriginalSource != sender && gridViewPanel.IsScrolling)
			{
				global::System.Windows.Rect rect = e.TargetRect;
				if (rect.IsEmpty)
				{
					global::System.Windows.UIElement uielement = e.TargetObject as global::System.Windows.UIElement;
					if (uielement != null)
					{
						rect = new global::System.Windows.Rect(uielement.RenderSize);
					}
					else
					{
						rect = default(global::System.Windows.Rect);
					}
				}
				global::System.Windows.Media.Visual visual = e.TargetObject as global::System.Windows.Media.Visual;
				if (visual == null || !visual.IsDescendantOf(gridViewPanel))
				{
					return;
				}
				global::System.Windows.Rect targetRectangle = gridViewPanel.MakeVisible(visual, rect);
				e.Handled = true;
				gridViewPanel.BringIntoView(targetRectangle);
			}
		}

		// Token: 0x06001752 RID: 5970 RVA: 0x0006708C File Offset: 0x0006528C
		internal virtual void OnViewSettingsPropertyChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			if (this._dataPresenter == null)
			{
				return;
			}
			string propertyName;
			if ((propertyName = e.PropertyName) != null)
			{
				if (propertyName == "UseNestedPanels")
				{
					this._dataPresenter.InitializeItemsPanel();
					return;
				}
				if (!(propertyName == "Orientation"))
				{
					return;
				}
				global::Infragistics.Windows.DataPresenter.GridViewPanel.ScrollData scrollingData = this.ScrollingData;
				scrollingData._extent = new global::System.Windows.Size(0.0, 0.0);
				scrollingData._viewport = new global::System.Windows.Size(0.0, 0.0);
				scrollingData._extentForScrollbar = new global::System.Windows.Size(0.0, 0.0);
				scrollingData._viewportForScrollbar = new global::System.Windows.Size(0.0, 0.0);
				scrollingData._averageHeightOfRecords = 0.0;
				scrollingData._highestRecordDisplayed = 0.0;
				if (this.LogicalOrientation == global::System.Windows.Controls.Orientation.Horizontal)
				{
					scrollingData._offset.X = scrollingData._offset.Y;
					scrollingData._offset.Y = 0.0;
					this.SetHorizontalOffset(0.0);
				}
				else
				{
					scrollingData._offset.Y = scrollingData._offset.X;
					scrollingData._offset.X = 0.0;
					this.SetVerticalOffset(0.0);
				}
				this.VerifyFixedFieldInfo();
				base.InvalidateMeasure();
				global::System.Windows.UIElement uielement = base.Parent as global::System.Windows.UIElement;
				if (uielement != null)
				{
					uielement.InvalidateMeasure();
				}
			}
		}

		// Token: 0x06001753 RID: 5971 RVA: 0x0006720C File Offset: 0x0006540C
		private void RemoveRangeOfChldren(global::System.Windows.Controls.Primitives.GeneratorPosition position, int count)
		{
			if (count < 1)
			{
				return;
			}
			if (base.ItemContainerGenerationModeResolved == global::Infragistics.Windows.Controls.ItemContainerGenerationMode.Recycle)
			{
				return;
			}
			int num = position.Index;
			if (position.Offset > 0)
			{
				num += position.Offset;
			}
			if (num < 0)
			{
				return;
			}
			int totalGeneratedChildrenCount = this.TotalGeneratedChildrenCount;
			if (num < totalGeneratedChildrenCount)
			{
				base.RemoveInternalChildRange(num, global::System.Math.Min(count, totalGeneratedChildrenCount - num));
			}
		}

		// Token: 0x06001754 RID: 5972
		internal abstract void SetOffsetInternal(double newOffset, double oldOffset, bool isSettingVerticalOffset);

		// Token: 0x06001755 RID: 5973 RVA: 0x00067263 File Offset: 0x00065463
		private void SetupRecordManagerWeakEventListener(global::Infragistics.Windows.DataPresenter.RecordManager recordManager)
		{
			if (this._isRecordManagerWeakEventListenerHookedUp || recordManager == null)
			{
				return;
			}
			global::System.ComponentModel.PropertyChangedEventManager.AddListener(recordManager, this, string.Empty);
			this._isRecordManagerWeakEventListenerHookedUp = true;
		}

		// Token: 0x06001756 RID: 5974 RVA: 0x00067284 File Offset: 0x00065484
		internal void AddLogicalChildInternal(global::System.Windows.DependencyObject child)
		{
			if (child != null)
			{
				if (this._logicalChildren == null)
				{
					this._logicalChildren = new global::System.Collections.Generic.List<global::System.Windows.DependencyObject>();
				}
				this._logicalChildren.Add(child);
				base.AddLogicalChild(child);
			}
		}

		// Token: 0x06001757 RID: 5975 RVA: 0x000672B0 File Offset: 0x000654B0
		internal bool EnsureCellIsVisible(global::Infragistics.Windows.DataPresenter.Cell cell)
		{
			if (!this.IsRootPanel)
			{
				return this.RootPanel.EnsureCellIsVisible(cell);
			}
			if (cell == null)
			{
				return false;
			}
			global::Infragistics.Windows.DataPresenter.DataRecord record = cell.Record;
			if (record == null)
			{
				return false;
			}
			if (this.ViewSettings == null)
			{
				return false;
			}
			global::Infragistics.Windows.DataPresenter.DataRecordPresenter dataRecordPresenter = record.AssociatedRecordPresenter as global::Infragistics.Windows.DataPresenter.DataRecordPresenter;
			if (dataRecordPresenter == null)
			{
				this.EnsureRecordIsVisible(cell.Record);
				base.UpdateLayout();
				dataRecordPresenter = (record.AssociatedRecordPresenter as global::Infragistics.Windows.DataPresenter.DataRecordPresenter);
			}
			if (dataRecordPresenter != null)
			{
				global::Infragistics.Windows.DataPresenter.CellValuePresenter[] childCellValuePresenters = dataRecordPresenter.GetChildCellValuePresenters();
				global::Infragistics.Windows.DataPresenter.CellValuePresenter cellValuePresenter = null;
				foreach (global::Infragistics.Windows.DataPresenter.CellValuePresenter cellValuePresenter2 in childCellValuePresenters)
				{
					if (cellValuePresenter2.Field == cell.Field)
					{
						cellValuePresenter = cellValuePresenter2;
						break;
					}
				}
				if (cellValuePresenter != null)
				{
					if (!cell.IsInEditMode && !((global::Infragistics.Windows.DataPresenter.IViewPanelInfo)this.DataPresenter).IsOkToScroll())
					{
						return false;
					}
					cellValuePresenter.BringIntoView();
					return true;
				}
			}
			return false;
		}

		// Token: 0x06001758 RID: 5976
		internal abstract bool EnsureRecordIsVisible(global::Infragistics.Windows.DataPresenter.Record record);

		// Token: 0x06001759 RID: 5977 RVA: 0x00067384 File Offset: 0x00065584
		internal int FindSlotForNewlyRealizedRecordPresenter(int newItemIndex)
		{
			global::System.Collections.IList childElements = base.ChildElements;
			int count = childElements.Count;
			if (count == 0)
			{
				return 0;
			}
			global::System.Windows.Controls.Primitives.IItemContainerGenerator generator = this.GetGenerator();
			for (int i = 0; i < count; i++)
			{
				int num = generator.IndexFromGeneratorPosition(new global::System.Windows.Controls.Primitives.GeneratorPosition(i, 0));
				if (num >= newItemIndex)
				{
					return i;
				}
			}
			return count;
		}

		// Token: 0x0600175A RID: 5978 RVA: 0x000673CE File Offset: 0x000655CE
		internal int GetGeneratedIndexFromChildIndex(int childIndex)
		{
			return this.GetGenerator().IndexFromGeneratorPosition(new global::System.Windows.Controls.Primitives.GeneratorPosition(childIndex, 0));
		}

		// Token: 0x0600175B RID: 5979 RVA: 0x000673E4 File Offset: 0x000655E4
		internal global::System.Windows.Controls.Primitives.GeneratorPosition GetGeneratorPositionFromItemIndex(int itemIndex, out int childIndex)
		{
			global::System.Windows.Controls.Primitives.IItemContainerGenerator generator = this.GetGenerator();
			global::System.Windows.Controls.Primitives.GeneratorPosition result = (generator != null) ? generator.GeneratorPositionFromIndex(itemIndex) : new global::System.Windows.Controls.Primitives.GeneratorPosition(-1, itemIndex + 1);
			childIndex = ((result.Offset == 0) ? result.Index : (result.Index + 1));
			return result;
		}

		// Token: 0x0600175C RID: 5980 RVA: 0x0006742C File Offset: 0x0006562C
		internal global::System.Windows.Controls.Primitives.IItemContainerGenerator GetGenerator()
		{
			if (this.RecordListControl == null)
			{
				throw new global::System.InvalidOperationException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_InvalidOperationException_11"));
			}
			return base.ActiveItemContainerGenerator;
		}

		// Token: 0x0600175D RID: 5981 RVA: 0x0006744C File Offset: 0x0006564C
		internal bool GetIsPreviousChildGenerated(int childIndex)
		{
			global::System.Windows.Controls.Primitives.GeneratorPosition position = new global::System.Windows.Controls.Primitives.GeneratorPosition(childIndex, 0);
			position = this.GetGenerator().GeneratorPositionFromIndex(this.GetGenerator().IndexFromGeneratorPosition(position) - 1);
			return position.Offset == 0;
		}

		// Token: 0x0600175E RID: 5982 RVA: 0x00067486 File Offset: 0x00065686
		internal bool GetIsIndexOutOfRange(int index, int minIndex, int maxIndex)
		{
			return index < minIndex || index > maxIndex;
		}

		// Token: 0x0600175F RID: 5983 RVA: 0x00067494 File Offset: 0x00065694
		internal virtual int GetScrollOffsetFromRecord(global::Infragistics.Windows.DataPresenter.Record record)
		{
			global::Infragistics.Windows.DataPresenter.IViewPanelInfo viewPanelInfo = this.ViewPanelInfo;
			int val = viewPanelInfo.GetOverallScrollPositionForRecord(record) - this.RootPanelTopFixedOffset;
			return global::System.Math.Min(global::System.Math.Max(val, 0), viewPanelInfo.OverallScrollCount - 1);
		}

		// Token: 0x06001760 RID: 5984 RVA: 0x000674CC File Offset: 0x000656CC
		internal virtual global::Infragistics.Windows.DataPresenter.Record GetTopRecordFromScrollOffset(int scrollOffset)
		{
			global::Infragistics.Windows.DataPresenter.IViewPanelInfo viewPanelInfo = this.ViewPanelInfo;
			scrollOffset += this.RootPanelTopFixedOffset;
			return viewPanelInfo.GetRecordAtOverallScrollPosition(global::System.Math.Min(global::System.Math.Max(scrollOffset, 0), viewPanelInfo.OverallScrollCount - 1));
		}

		// Token: 0x1700061C RID: 1564
		// (get) Token: 0x06001761 RID: 5985 RVA: 0x00067504 File Offset: 0x00065704
		internal double HorizontalPageDelta
		{
			get
			{
				if (!this.IsRootPanel)
				{
					return this.RootPanel.HorizontalPageDelta;
				}
				double val = this.ScrollingData._viewport.Width;
				double val2;
				if (this.LogicalOrientation == global::System.Windows.Controls.Orientation.Vertical)
				{
					if (this._fixedFieldInfo != null)
					{
						val = this._fixedFieldInfo.GetScrollableViewportExtent();
					}
					val2 = this.ScrollSmallChangeInNonOrientationDimension;
				}
				else
				{
					val2 = this.ScrollSmallChangeInOrientationDimension;
				}
				return global::System.Math.Max(val2, val);
			}
		}

		// Token: 0x06001762 RID: 5986 RVA: 0x0006756A File Offset: 0x0006576A
		internal int NormalizeScrollOffset(double scrollOffset, int maxNormalizedValue)
		{
			if (double.IsPositiveInfinity(scrollOffset))
			{
				return maxNormalizedValue;
			}
			if (double.IsNegativeInfinity(scrollOffset))
			{
				return 0;
			}
			return this.EnsureIntInRange((int)scrollOffset, 0, maxNormalizedValue);
		}

		// Token: 0x06001763 RID: 5987 RVA: 0x0006758A File Offset: 0x0006578A
		internal void OnArrangeComplete()
		{
			if (this.IsRootPanel)
			{
				this._lastArrangeScrollOffset = this.ScrollingData._offset;
			}
		}

		// Token: 0x06001764 RID: 5988 RVA: 0x000675A5 File Offset: 0x000657A5
		internal virtual void OnDeferredRecordScrollStart()
		{
		}

		// Token: 0x06001765 RID: 5989 RVA: 0x000675A7 File Offset: 0x000657A7
		internal void OnScrollInfoChange()
		{
			if (this.ScrollingData._scrollOwner != null)
			{
				this.ScrollingData._scrollOwner.InvalidateScrollInfo();
			}
		}

		// Token: 0x06001766 RID: 5990 RVA: 0x000675C6 File Offset: 0x000657C6
		internal void RemoveLogicalChildInternal(global::System.Windows.DependencyObject child)
		{
			if (this._logicalChildren != null)
			{
				this._logicalChildren.Remove(child);
				base.RemoveLogicalChild(child);
			}
		}

		// Token: 0x06001767 RID: 5991
		internal abstract void SetBoundaryRecordFlags();

		// Token: 0x06001768 RID: 5992 RVA: 0x000675E4 File Offset: 0x000657E4
		internal static void SetRecordPresenterClip(bool orientationIsVertical, double extentUsedByLastItem, double clipExtent, global::System.Windows.Rect arrangeRect, bool shouldClip, global::Infragistics.Windows.DataPresenter.RecordPresenter rp)
		{
			if (rp != null)
			{
				global::System.Windows.Media.Geometry geometry = null;
				if (shouldClip && extentUsedByLastItem > clipExtent)
				{
					if (clipExtent <= 0.0)
					{
						geometry = global::System.Windows.Media.Geometry.Empty;
					}
					else
					{
						global::System.Windows.Rect rect;
						if (orientationIsVertical)
						{
							rect = new global::System.Windows.Rect(new global::System.Windows.Point(0.0, -1.0), new global::System.Windows.Size(arrangeRect.Width, clipExtent + 1.0));
						}
						else
						{
							rect = new global::System.Windows.Rect(new global::System.Windows.Point(-1.0, 0.0), new global::System.Windows.Size(clipExtent + 1.0, arrangeRect.Height));
						}
						geometry = new global::System.Windows.Media.RectangleGeometry(rect);
						geometry.Freeze();
					}
				}
				rp.InternalClip = geometry;
			}
		}

		// Token: 0x06001769 RID: 5993 RVA: 0x000676A0 File Offset: 0x000658A0
		internal bool VerifyAllParentsAreInView(global::Infragistics.Windows.DataPresenter.Record record, global::System.Windows.Size panelSize)
		{
			bool flag = this.LogicalOrientation == global::System.Windows.Controls.Orientation.Vertical;
			double num = flag ? panelSize.Height : panelSize.Width;
			if (num <= 0.0 || record == null)
			{
				return true;
			}
			for (global::Infragistics.Windows.DataPresenter.Record parentRecord = record.ParentRecord; parentRecord != null; parentRecord = parentRecord.ParentRecord)
			{
				global::Infragistics.Windows.DataPresenter.RecordPresenter associatedRecordPresenter = parentRecord.AssociatedRecordPresenter;
				if (associatedRecordPresenter == null)
				{
					break;
				}
				global::System.Windows.Point point = associatedRecordPresenter.TranslatePoint(new global::System.Windows.Point(associatedRecordPresenter.ActualWidth, associatedRecordPresenter.ActualHeight), this);
				double num2 = flag ? point.Y : point.X;
				if (num2 > num)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0600176A RID: 5994 RVA: 0x00067730 File Offset: 0x00065930
		internal void VerifyFixedFieldInfo()
		{
			global::Infragistics.Windows.DataPresenter.FixedFieldInfo fixedFieldInfo = this.FixedFieldInfo;
			if (fixedFieldInfo != null)
			{
				double offset = 0.0;
				double extent = 0.0;
				double viewportExtent = 0.0;
				global::Infragistics.Windows.DataPresenter.GridViewPanel.ScrollData scrollingData = this.ScrollingData;
				if (scrollingData != null)
				{
					if (this.LogicalOrientation == global::System.Windows.Controls.Orientation.Horizontal)
					{
						offset = scrollingData._offset.Y;
						extent = scrollingData._extent.Height;
						viewportExtent = scrollingData._viewport.Height;
					}
					else
					{
						offset = scrollingData._offset.X;
						extent = scrollingData._extent.Width;
						viewportExtent = scrollingData._viewport.Width;
					}
				}
				fixedFieldInfo.Offset = offset;
				fixedFieldInfo.Extent = extent;
				fixedFieldInfo.ViewportExtent = viewportExtent;
				fixedFieldInfo.FixedAreaElement = (global::System.Windows.Media.VisualTreeHelper.GetParent(this) as global::System.Windows.FrameworkElement);
			}
		}

		// Token: 0x1700061D RID: 1565
		// (get) Token: 0x0600176B RID: 5995 RVA: 0x000677F4 File Offset: 0x000659F4
		internal double VerticalPageDelta
		{
			get
			{
				if (!this.IsRootPanel)
				{
					return this.RootPanel.VerticalPageDelta;
				}
				double val = this.ScrollingData._viewport.Height;
				double val2;
				if (this.LogicalOrientation == global::System.Windows.Controls.Orientation.Horizontal)
				{
					if (this._fixedFieldInfo != null)
					{
						val = this._fixedFieldInfo.GetScrollableViewportExtent();
					}
					val2 = this.ScrollSmallChangeInNonOrientationDimension;
				}
				else
				{
					val2 = this.ScrollSmallChangeInOrientationDimension;
				}
				return global::System.Math.Max(val2, val);
			}
		}

		// Token: 0x1700061E RID: 1566
		// (get) Token: 0x0600176C RID: 5996 RVA: 0x00067859 File Offset: 0x00065A59
		public double ExtentHeight
		{
			get
			{
				if (this.ScrollingData == null)
				{
					return 0.0;
				}
				return this.ScrollingData._extentForScrollbar.Height;
			}
		}

		// Token: 0x1700061F RID: 1567
		// (get) Token: 0x0600176D RID: 5997 RVA: 0x0006787D File Offset: 0x00065A7D
		public double ExtentWidth
		{
			get
			{
				if (this.ScrollingData == null)
				{
					return 0.0;
				}
				return this.ScrollingData._extentForScrollbar.Width;
			}
		}

		// Token: 0x17000620 RID: 1568
		// (get) Token: 0x0600176E RID: 5998 RVA: 0x000678A4 File Offset: 0x00065AA4
		public double HorizontalOffset
		{
			get
			{
				if (this.ScrollingData == null)
				{
					return 0.0;
				}
				if (this.ScrollingData._isInDeferredDrag && this.LogicalOrientation == global::System.Windows.Controls.Orientation.Horizontal)
				{
					return this.ScrollingData._deferredDragOffset;
				}
				return this.ScrollingData._offset.X;
			}
		}

		// Token: 0x17000621 RID: 1569
		// (get) Token: 0x0600176F RID: 5999 RVA: 0x000678F4 File Offset: 0x00065AF4
		public double VerticalOffset
		{
			get
			{
				if (this.ScrollingData == null)
				{
					return 0.0;
				}
				if (this.ScrollingData._isInDeferredDrag && this.LogicalOrientation == global::System.Windows.Controls.Orientation.Vertical)
				{
					return this.ScrollingData._deferredDragOffset;
				}
				return this.ScrollingData._offset.Y;
			}
		}

		// Token: 0x06001770 RID: 6000 RVA: 0x00067945 File Offset: 0x00065B45
		public void SetHorizontalOffset(double newOffset)
		{
			this.SetOffsetInternal(newOffset, this.HorizontalOffset, false);
		}

		// Token: 0x06001771 RID: 6001 RVA: 0x00067955 File Offset: 0x00065B55
		public void SetVerticalOffset(double newOffset)
		{
			this.SetOffsetInternal(newOffset, this.VerticalOffset, true);
		}

		// Token: 0x06001772 RID: 6002 RVA: 0x00067965 File Offset: 0x00065B65
		public void LineDown()
		{
			if (!this.IsRootPanel)
			{
				this.RootPanel.LineDown();
				return;
			}
			this.SetVerticalOffset(this.VerticalOffset + ((this.LogicalOrientation == global::System.Windows.Controls.Orientation.Vertical) ? this.ScrollSmallChangeInOrientationDimension : this.ScrollSmallChangeInNonOrientationDimension));
		}

		// Token: 0x06001773 RID: 6003 RVA: 0x0006799F File Offset: 0x00065B9F
		public void LineLeft()
		{
			if (!this.IsRootPanel)
			{
				this.RootPanel.LineUp();
				return;
			}
			this.SetHorizontalOffset(this.HorizontalOffset - ((this.LogicalOrientation == global::System.Windows.Controls.Orientation.Horizontal) ? this.ScrollSmallChangeInOrientationDimension : this.ScrollSmallChangeInNonOrientationDimension));
		}

		// Token: 0x06001774 RID: 6004 RVA: 0x000679D8 File Offset: 0x00065BD8
		public void LineRight()
		{
			if (!this.IsRootPanel)
			{
				this.RootPanel.LineRight();
				return;
			}
			this.SetHorizontalOffset(this.HorizontalOffset + ((this.LogicalOrientation == global::System.Windows.Controls.Orientation.Horizontal) ? this.ScrollSmallChangeInOrientationDimension : this.ScrollSmallChangeInNonOrientationDimension));
		}

		// Token: 0x06001775 RID: 6005 RVA: 0x00067A11 File Offset: 0x00065C11
		public void LineUp()
		{
			if (!this.IsRootPanel)
			{
				this.RootPanel.LineUp();
				return;
			}
			this.SetVerticalOffset(this.VerticalOffset - ((this.LogicalOrientation == global::System.Windows.Controls.Orientation.Vertical) ? this.ScrollSmallChangeInOrientationDimension : this.ScrollSmallChangeInNonOrientationDimension));
		}

		// Token: 0x06001776 RID: 6006 RVA: 0x00067A4C File Offset: 0x00065C4C
		public void MouseWheelDown()
		{
			if (!this.IsRootPanel)
			{
				this.RootPanel.MouseWheelDown();
				return;
			}
			this.SetVerticalOffset(this.VerticalOffset + (double)this.MouseWheelScrollMultiplier * ((this.LogicalOrientation == global::System.Windows.Controls.Orientation.Vertical) ? this.ScrollSmallChangeInOrientationDimension : this.ScrollSmallChangeInNonOrientationDimension));
		}

		// Token: 0x06001777 RID: 6007 RVA: 0x00067A9C File Offset: 0x00065C9C
		public void MouseWheelLeft()
		{
			if (!this.IsRootPanel)
			{
				this.RootPanel.MouseWheelLeft();
				return;
			}
			this.SetHorizontalOffset(this.HorizontalOffset - (double)this.MouseWheelScrollMultiplier * ((this.LogicalOrientation == global::System.Windows.Controls.Orientation.Horizontal) ? this.ScrollSmallChangeInOrientationDimension : this.ScrollSmallChangeInNonOrientationDimension));
		}

		// Token: 0x06001778 RID: 6008 RVA: 0x00067AE8 File Offset: 0x00065CE8
		public void MouseWheelRight()
		{
			if (!this.IsRootPanel)
			{
				this.RootPanel.MouseWheelRight();
				return;
			}
			this.SetHorizontalOffset(this.HorizontalOffset + (double)this.MouseWheelScrollMultiplier * ((this.LogicalOrientation == global::System.Windows.Controls.Orientation.Horizontal) ? this.ScrollSmallChangeInOrientationDimension : this.ScrollSmallChangeInNonOrientationDimension));
		}

		// Token: 0x06001779 RID: 6009 RVA: 0x00067B34 File Offset: 0x00065D34
		public void MouseWheelUp()
		{
			if (!this.IsRootPanel)
			{
				this.RootPanel.MouseWheelUp();
				return;
			}
			this.SetVerticalOffset(this.VerticalOffset - (double)this.MouseWheelScrollMultiplier * ((this.LogicalOrientation == global::System.Windows.Controls.Orientation.Vertical) ? this.ScrollSmallChangeInOrientationDimension : this.ScrollSmallChangeInNonOrientationDimension));
		}

		// Token: 0x0600177A RID: 6010 RVA: 0x00067B84 File Offset: 0x00065D84
		public void PageDown()
		{
			if (!this.IsRootPanel)
			{
				this.RootPanel.PageDown();
				return;
			}
			double num = this.VerticalOffset + this.VerticalPageDelta;
			if (this.LogicalOrientation == global::System.Windows.Controls.Orientation.Horizontal)
			{
				double height = this.ScrollingData._viewport.Height;
				double height2 = this.ScrollingData._extent.Height;
				if (num + height > height2)
				{
					num = height2 - height;
				}
			}
			this.SetVerticalOffset(num);
		}

		// Token: 0x0600177B RID: 6011 RVA: 0x00067BEE File Offset: 0x00065DEE
		public void PageLeft()
		{
			if (!this.IsRootPanel)
			{
				this.RootPanel.PageLeft();
				return;
			}
			this._setOffsetTriggeredByPageBack = true;
			this.SetHorizontalOffset(this.HorizontalOffset - this.HorizontalPageDelta);
		}

		// Token: 0x0600177C RID: 6012 RVA: 0x00067C20 File Offset: 0x00065E20
		public void PageRight()
		{
			if (!this.IsRootPanel)
			{
				this.RootPanel.PageRight();
				return;
			}
			double num = this.HorizontalOffset + this.HorizontalPageDelta;
			if (this.LogicalOrientation == global::System.Windows.Controls.Orientation.Vertical)
			{
				double width = this.ScrollingData._viewport.Width;
				double width2 = this.ScrollingData._extent.Width;
				if (num + width > width2)
				{
					num = width2 - width;
				}
			}
			this.SetHorizontalOffset(num);
		}

		// Token: 0x0600177D RID: 6013 RVA: 0x00067C8B File Offset: 0x00065E8B
		public void PageUp()
		{
			if (!this.IsRootPanel)
			{
				this.RootPanel.PageUp();
				return;
			}
			this._setOffsetTriggeredByPageBack = true;
			this.SetVerticalOffset(this.VerticalOffset - this.VerticalPageDelta);
		}

		// Token: 0x17000622 RID: 1570
		// (get) Token: 0x0600177E RID: 6014 RVA: 0x00067CBB File Offset: 0x00065EBB
		// (set) Token: 0x0600177F RID: 6015 RVA: 0x00067CC8 File Offset: 0x00065EC8
		public global::System.Windows.Controls.ScrollViewer ScrollOwner
		{
			get
			{
				return this.ScrollingData._scrollOwner;
			}
			set
			{
				if (value != this.ScrollingData._scrollOwner)
				{
					this.ScrollingData.Reset();
					this.ScrollingData._scrollOwner = value;
					this.VerifyFixedFieldInfo();
				}
			}
		}

		// Token: 0x17000623 RID: 1571
		// (get) Token: 0x06001780 RID: 6016 RVA: 0x00067CF5 File Offset: 0x00065EF5
		public double ViewportHeight
		{
			get
			{
				if (this.ScrollingData == null)
				{
					return 0.0;
				}
				return this.ScrollingData._viewportForScrollbar.Height;
			}
		}

		// Token: 0x17000624 RID: 1572
		// (get) Token: 0x06001781 RID: 6017 RVA: 0x00067D19 File Offset: 0x00065F19
		public double ViewportWidth
		{
			get
			{
				if (this.ScrollingData == null)
				{
					return 0.0;
				}
				return this.ScrollingData._viewportForScrollbar.Width;
			}
		}

		// Token: 0x06001782 RID: 6018 RVA: 0x00067D40 File Offset: 0x00065F40
		public global::System.Windows.Rect MakeVisible(global::System.Windows.Media.Visual visual, global::System.Windows.Rect rect)
		{
			if (!this.IsScrolling)
			{
				return visual.TransformToAncestor(this).TransformBounds(rect);
			}
			global::System.Windows.Rect rect2 = global::System.Windows.Rect.Empty;
			try
			{
				rect2 = visual.TransformToAncestor(this).TransformBounds(rect);
			}
			catch
			{
				return global::System.Windows.Rect.Empty;
			}
			rect2.X += this._lastArrangeScrollOffset.X - this.ScrollingData._offset.X;
			rect2.Y += this._lastArrangeScrollOffset.Y - this.ScrollingData._offset.Y;
			global::System.Windows.Rect rect3 = new global::System.Windows.Rect(0.0, 0.0, base.ActualWidth, base.ActualHeight);
			if (this.LogicalOrientation == global::System.Windows.Controls.Orientation.Vertical)
			{
				rect3.Width = this.ScrollingData._viewport.Width;
			}
			else
			{
				rect3.Height = this.ScrollingData._viewport.Height;
			}
			bool flag = false;
			global::System.Windows.Rect rect4 = global::System.Windows.Rect.Intersect(rect2, rect3);
			if (rect4.Width != rect2.Width)
			{
				double num = 0.0;
				if (rect2.Right > rect3.Right)
				{
					num = rect2.Right - rect3.Right;
				}
				if (rect2.Left - num - rect3.Left < 0.0)
				{
					num += rect2.Left - num - rect3.Left;
				}
				if (!global::Infragistics.Windows.DataPresenter.GridUtilities.AreClose(0.0, num))
				{
					rect2.X -= num;
					if (this.LogicalOrientation == global::System.Windows.Controls.Orientation.Horizontal)
					{
						flag = true;
					}
					else
					{
						num += this.ScrollingData._offset.X;
						this.SetHorizontalOffset(num);
					}
				}
			}
			if (rect4.Height != rect2.Height)
			{
				double num2 = 0.0;
				if (rect2.Bottom > rect3.Bottom)
				{
					num2 = rect2.Bottom - rect3.Bottom;
				}
				if (rect2.Top - num2 - rect3.Top < 0.0)
				{
					num2 += rect2.Top - num2 - rect3.Top;
				}
				if (!global::Infragistics.Windows.DataPresenter.GridUtilities.AreClose(0.0, num2))
				{
					rect2.Y -= num2;
					if (this.LogicalOrientation == global::System.Windows.Controls.Orientation.Vertical)
					{
						flag = true;
					}
					else
					{
						num2 += this.ScrollingData._offset.Y;
						this.SetVerticalOffset(num2);
					}
				}
			}
			if (flag)
			{
				global::System.Windows.DependencyObject immediateDescendant = global::Infragistics.Windows.DataPresenter.GridUtilities.GetImmediateDescendant(visual, this);
				if (immediateDescendant != null)
				{
					global::Infragistics.Windows.DataPresenter.RecordPresenter recordPresenterFromContainer = global::Infragistics.Windows.DataPresenter.RecordListControl.GetRecordPresenterFromContainer(immediateDescendant);
					if (recordPresenterFromContainer != null && recordPresenterFromContainer.Record != null)
					{
						this.EnsureRecordIsVisible(recordPresenterFromContainer.Record);
					}
				}
			}
			return rect2;
		}

		// Token: 0x17000625 RID: 1573
		// (get) Token: 0x06001783 RID: 6019 RVA: 0x00068008 File Offset: 0x00066208
		// (set) Token: 0x06001784 RID: 6020 RVA: 0x00068015 File Offset: 0x00066215
		public bool CanVerticallyScroll
		{
			get
			{
				return this.ScrollingData._canVerticallyScroll;
			}
			set
			{
				if (this.ScrollingData._canVerticallyScroll != value)
				{
					this.ScrollingData._canVerticallyScroll = value;
					base.InvalidateMeasure();
				}
			}
		}

		// Token: 0x17000626 RID: 1574
		// (get) Token: 0x06001785 RID: 6021 RVA: 0x00068037 File Offset: 0x00066237
		// (set) Token: 0x06001786 RID: 6022 RVA: 0x00068044 File Offset: 0x00066244
		public bool CanHorizontallyScroll
		{
			get
			{
				return this.ScrollingData._canHorizontallyScroll;
			}
			set
			{
				if (this.ScrollingData._canHorizontallyScroll != value)
				{
					this.ScrollingData._canHorizontallyScroll = value;
					base.InvalidateMeasure();
				}
			}
		}

		// Token: 0x06001787 RID: 6023 RVA: 0x00068066 File Offset: 0x00066266
		bool global::Infragistics.Windows.DataPresenter.IViewPanel.EnsureCellIsVisible(global::Infragistics.Windows.DataPresenter.Cell cell)
		{
			return this.RootPanel.EnsureCellIsVisible(cell);
		}

		// Token: 0x06001788 RID: 6024 RVA: 0x00068074 File Offset: 0x00066274
		bool global::Infragistics.Windows.DataPresenter.IViewPanel.EnsureRecordIsVisible(global::Infragistics.Windows.DataPresenter.Record record)
		{
			return this.RootPanel.EnsureRecordIsVisible(record);
		}

		// Token: 0x06001789 RID: 6025 RVA: 0x00068084 File Offset: 0x00066284
		global::Infragistics.Windows.DataPresenter.Record global::Infragistics.Windows.DataPresenter.IViewPanel.GetFirstDisplayedRecord(global::System.Type recordType)
		{
			global::Infragistics.Windows.DataPresenter.RecordType? recordTypeFromType = global::Infragistics.Windows.DataPresenter.GridUtilities.GetRecordTypeFromType(recordType);
			if (recordTypeFromType == null && recordType != typeof(global::Infragistics.Windows.DataPresenter.Record))
			{
				return null;
			}
			global::Infragistics.Windows.DataPresenter.Record firstScrollableRecord = this.FirstScrollableRecord;
			if (firstScrollableRecord == null)
			{
				return null;
			}
			if (global::Infragistics.Windows.DataPresenter.GridUtilities.IsRecordOfType(firstScrollableRecord, recordTypeFromType, recordType))
			{
				return firstScrollableRecord;
			}
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this.DataPresenter;
			global::Infragistics.Windows.DataPresenter.IViewPanelInfo viewPanelInfo = this.ViewPanelInfo;
			int num = viewPanelInfo.GetOverallScrollPositionForRecord(firstScrollableRecord) + 1;
			int scrollPositionOfLastVisibleRecord = this.RootPanel.ScrollPositionOfLastVisibleRecord;
			for (int i = num; i <= scrollPositionOfLastVisibleRecord; i++)
			{
				global::Infragistics.Windows.DataPresenter.Record recordAtOverallScrollPosition = viewPanelInfo.GetRecordAtOverallScrollPosition(i);
				if (recordAtOverallScrollPosition != null && !recordAtOverallScrollPosition.IsSpecialRecord && global::Infragistics.Windows.DataPresenter.GridUtilities.IsRecordOfType(recordAtOverallScrollPosition, recordTypeFromType, recordType))
				{
					return recordAtOverallScrollPosition;
				}
			}
			return null;
		}

		// Token: 0x0600178A RID: 6026 RVA: 0x0006812C File Offset: 0x0006632C
		global::Infragistics.Windows.DataPresenter.Record global::Infragistics.Windows.DataPresenter.IViewPanel.GetFirstOverallRecord(global::System.Type recordType)
		{
			global::Infragistics.Windows.DataPresenter.RecordType? recordTypeFromType = global::Infragistics.Windows.DataPresenter.GridUtilities.GetRecordTypeFromType(recordType);
			if (recordTypeFromType == null && recordType != typeof(global::Infragistics.Windows.DataPresenter.Record))
			{
				return null;
			}
			global::Infragistics.Windows.DataPresenter.IViewPanelInfo viewPanelInfo = this.ViewPanelInfo;
			int overallScrollCount = viewPanelInfo.OverallScrollCount;
			for (int i = 0; i < overallScrollCount; i++)
			{
				global::Infragistics.Windows.DataPresenter.Record recordAtOverallScrollPosition = viewPanelInfo.GetRecordAtOverallScrollPosition(i);
				if (recordAtOverallScrollPosition != null && !recordAtOverallScrollPosition.IsSpecialRecord && global::Infragistics.Windows.DataPresenter.GridUtilities.IsRecordOfType(recordAtOverallScrollPosition, recordTypeFromType, recordType))
				{
					return recordAtOverallScrollPosition;
				}
			}
			return null;
		}

		// Token: 0x0600178B RID: 6027 RVA: 0x0006819C File Offset: 0x0006639C
		global::Infragistics.Windows.DataPresenter.Record global::Infragistics.Windows.DataPresenter.IViewPanel.GetLastDisplayedRecord(global::System.Type recordType)
		{
			global::Infragistics.Windows.DataPresenter.RecordType? recordTypeFromType = global::Infragistics.Windows.DataPresenter.GridUtilities.GetRecordTypeFromType(recordType);
			if (recordTypeFromType == null && recordType != typeof(global::Infragistics.Windows.DataPresenter.Record))
			{
				return null;
			}
			int scrollPositionOfLastVisibleRecord = this.RootPanel.ScrollPositionOfLastVisibleRecord;
			if (scrollPositionOfLastVisibleRecord < 0)
			{
				return null;
			}
			global::Infragistics.Windows.DataPresenter.IViewPanelInfo viewPanelInfo = this.ViewPanelInfo;
			if (viewPanelInfo == null)
			{
				return null;
			}
			global::Infragistics.Windows.DataPresenter.Record recordAtOverallScrollPosition = viewPanelInfo.GetRecordAtOverallScrollPosition(scrollPositionOfLastVisibleRecord);
			if (recordAtOverallScrollPosition == null)
			{
				return null;
			}
			if (global::Infragistics.Windows.DataPresenter.GridUtilities.IsRecordOfType(recordAtOverallScrollPosition, recordTypeFromType, recordType))
			{
				return recordAtOverallScrollPosition;
			}
			int num = scrollPositionOfLastVisibleRecord - 1;
			for (int i = num; i > -1; i--)
			{
				global::Infragistics.Windows.DataPresenter.Record recordAtOverallScrollPosition2 = viewPanelInfo.GetRecordAtOverallScrollPosition(i);
				if (recordAtOverallScrollPosition2 != null && !recordAtOverallScrollPosition2.IsSpecialRecord && global::Infragistics.Windows.DataPresenter.GridUtilities.IsRecordOfType(recordAtOverallScrollPosition2, recordTypeFromType, recordType))
				{
					return recordAtOverallScrollPosition2;
				}
			}
			return null;
		}

		// Token: 0x0600178C RID: 6028 RVA: 0x00068240 File Offset: 0x00066440
		global::Infragistics.Windows.DataPresenter.Record global::Infragistics.Windows.DataPresenter.IViewPanel.GetLastOverallRecord(global::System.Type recordType)
		{
			global::Infragistics.Windows.DataPresenter.RecordType? recordTypeFromType = global::Infragistics.Windows.DataPresenter.GridUtilities.GetRecordTypeFromType(recordType);
			if (recordTypeFromType == null && recordType != typeof(global::Infragistics.Windows.DataPresenter.Record))
			{
				return null;
			}
			global::Infragistics.Windows.DataPresenter.IViewPanelInfo viewPanelInfo = this.ViewPanelInfo;
			if (viewPanelInfo == null)
			{
				return null;
			}
			int overallScrollCount = viewPanelInfo.OverallScrollCount;
			for (int i = overallScrollCount - 1; i >= 0; i--)
			{
				global::Infragistics.Windows.DataPresenter.Record recordAtOverallScrollPosition = viewPanelInfo.GetRecordAtOverallScrollPosition(i);
				if (recordAtOverallScrollPosition != null && !recordAtOverallScrollPosition.IsSpecialRecord && global::Infragistics.Windows.DataPresenter.GridUtilities.IsRecordOfType(recordAtOverallScrollPosition, recordTypeFromType, recordType))
				{
					return recordAtOverallScrollPosition;
				}
			}
			return null;
		}

		// Token: 0x0600178D RID: 6029 RVA: 0x000682B8 File Offset: 0x000664B8
		global::Infragistics.Windows.DataPresenter.Record global::Infragistics.Windows.DataPresenter.IViewPanel.GetNavigationTargetRecord(global::Infragistics.Windows.DataPresenter.Record currentRecord, global::Infragistics.Windows.DataPresenter.PanelNavigationDirection navigationDirection, global::Infragistics.Windows.Selection.ISelectionHost selectionHost, bool shiftKeyDown, bool ctlKeyDown, global::Infragistics.Windows.DataPresenter.PanelSiblingNavigationStyle siblingNavigationStyle, global::System.Type restrictToRecordType)
		{
			if (currentRecord == null)
			{
				throw new global::System.ArgumentNullException("currentRecord");
			}
			if (selectionHost == null)
			{
				throw new global::System.ArgumentNullException("selectionHost");
			}
			if (!this.IsRootPanel)
			{
				return ((global::Infragistics.Windows.DataPresenter.IViewPanel)this.RootPanel).GetNavigationTargetRecord(currentRecord, navigationDirection, selectionHost, shiftKeyDown, ctlKeyDown, siblingNavigationStyle, restrictToRecordType);
			}
			global::Infragistics.Windows.Selection.SelectionStrategyBase selectionStrategyForItem = selectionHost.GetSelectionStrategyForItem(currentRecord);
			if (selectionStrategyForItem == null)
			{
				throw new global::System.InvalidOperationException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_InvalidOperationException_4"));
			}
			global::Infragistics.Windows.DataPresenter.Record navigationTargetRecordHelper;
			if (siblingNavigationStyle == global::Infragistics.Windows.DataPresenter.PanelSiblingNavigationStyle.AcrossParentsAndWrap || siblingNavigationStyle == global::Infragistics.Windows.DataPresenter.PanelSiblingNavigationStyle.AcrossParentsNoWrap)
			{
				navigationTargetRecordHelper = this.GetNavigationTargetRecordHelper(currentRecord, navigationDirection, shiftKeyDown, ctlKeyDown, siblingNavigationStyle, restrictToRecordType, selectionStrategyForItem);
				if (navigationTargetRecordHelper != null)
				{
					return navigationTargetRecordHelper;
				}
			}
			global::Infragistics.Windows.DataPresenter.PanelSiblingNavigationStyle siblingNavigationStyle2 = (siblingNavigationStyle == global::Infragistics.Windows.DataPresenter.PanelSiblingNavigationStyle.AcrossParentsAndWrap) ? global::Infragistics.Windows.DataPresenter.PanelSiblingNavigationStyle.StayWithinParentAndWrap : ((siblingNavigationStyle == global::Infragistics.Windows.DataPresenter.PanelSiblingNavigationStyle.AcrossParentsNoWrap) ? global::Infragistics.Windows.DataPresenter.PanelSiblingNavigationStyle.StayWithinParentNoWrap : siblingNavigationStyle);
			navigationTargetRecordHelper = this.GetNavigationTargetRecordHelper(currentRecord, navigationDirection, shiftKeyDown, ctlKeyDown, siblingNavigationStyle2, restrictToRecordType, selectionStrategyForItem);
			if (navigationTargetRecordHelper != null)
			{
				return navigationTargetRecordHelper;
			}
			return null;
		}

		// Token: 0x0600178E RID: 6030 RVA: 0x00068364 File Offset: 0x00066564
		private global::Infragistics.Windows.DataPresenter.Record GetNavigationTargetRecordHelper(global::Infragistics.Windows.DataPresenter.Record currentRecord, global::Infragistics.Windows.DataPresenter.PanelNavigationDirection navigationDirection, bool shiftKeyDown, bool ctlKeyDown, global::Infragistics.Windows.DataPresenter.PanelSiblingNavigationStyle siblingNavigationStyle, global::System.Type restrictToRecordType, global::Infragistics.Windows.Selection.SelectionStrategyBase selectionStrategy)
		{
			global::Infragistics.Windows.DataPresenter.Record record = currentRecord;
			while (record != null)
			{
				record = this.GetNavigationTargetRecord(navigationDirection, record, siblingNavigationStyle, restrictToRecordType);
				if (record == null)
				{
					return null;
				}
				if (record.IsEnabledResolved && selectionStrategy.CanItemBeNavigatedTo(record, shiftKeyDown, ctlKeyDown))
				{
					return record;
				}
			}
			return null;
		}

		// Token: 0x17000627 RID: 1575
		// (get) Token: 0x0600178F RID: 6031 RVA: 0x000683A4 File Offset: 0x000665A4
		global::Infragistics.Windows.DataPresenter.PanelLayoutStyle global::Infragistics.Windows.DataPresenter.IViewPanel.LayoutStyle
		{
			get
			{
				switch (this.LogicalOrientation)
				{
				case global::System.Windows.Controls.Orientation.Horizontal:
					return global::Infragistics.Windows.DataPresenter.PanelLayoutStyle.GridViewHorizontal;
				case global::System.Windows.Controls.Orientation.Vertical:
					return global::Infragistics.Windows.DataPresenter.PanelLayoutStyle.GridViewVertical;
				default:
					return global::Infragistics.Windows.DataPresenter.PanelLayoutStyle.GridViewVertical;
				}
			}
		}

		// Token: 0x06001790 RID: 6032 RVA: 0x000683CD File Offset: 0x000665CD
		void global::Infragistics.Windows.DataPresenter.IViewPanel.OnActiveRecordChanged(global::Infragistics.Windows.DataPresenter.Record record)
		{
		}

		// Token: 0x06001791 RID: 6033 RVA: 0x000683CF File Offset: 0x000665CF
		void global::Infragistics.Windows.DataPresenter.IViewPanel.OnSelectedItemsChanged()
		{
		}

		// Token: 0x06001792 RID: 6034 RVA: 0x000683D4 File Offset: 0x000665D4
		void global::Infragistics.Windows.DataPresenter.IViewPanel.Scroll(global::Infragistics.Windows.DataPresenter.PanelNavigationScrollType scrollType)
		{
			switch (scrollType)
			{
			case global::Infragistics.Windows.DataPresenter.PanelNavigationScrollType.PageAbove:
				this.RootPanel.PageUp();
				return;
			case global::Infragistics.Windows.DataPresenter.PanelNavigationScrollType.PageBelow:
				this.RootPanel.PageDown();
				return;
			case global::Infragistics.Windows.DataPresenter.PanelNavigationScrollType.PageLeft:
				this.RootPanel.PageLeft();
				return;
			case global::Infragistics.Windows.DataPresenter.PanelNavigationScrollType.PageRight:
				this.RootPanel.PageRight();
				return;
			default:
				return;
			}
		}

		// Token: 0x06001793 RID: 6035 RVA: 0x0006842C File Offset: 0x0006662C
		bool global::System.Windows.IWeakEventListener.ReceiveWeakEvent(global::System.Type managerType, object sender, global::System.EventArgs e)
		{
			if (!(managerType == typeof(global::System.ComponentModel.PropertyChangedEventManager)))
			{
				return false;
			}
			global::System.ComponentModel.PropertyChangedEventArgs propertyChangedEventArgs = e as global::System.ComponentModel.PropertyChangedEventArgs;
			if (propertyChangedEventArgs == null)
			{
				return false;
			}
			if (sender is global::Infragistics.Windows.DataPresenter.GridViewSettings)
			{
				if (sender == this._viewSettings)
				{
					this.OnViewSettingsPropertyChanged(sender, propertyChangedEventArgs);
					return true;
				}
				return true;
			}
			else
			{
				if (!(sender is global::Infragistics.Windows.DataPresenter.RecordManager))
				{
					return false;
				}
				string propertyName;
				if ((propertyName = propertyChangedEventArgs.PropertyName) != null && propertyName == "UnderlyingDataVersion")
				{
					global::Infragistics.Windows.DataPresenter.IViewPanelInfo viewPanelInfo = this.ViewPanelInfo;
					int effectiveScrollPosition = this.EffectiveScrollPosition;
					if (effectiveScrollPosition != (int)this.VerticalOffset || effectiveScrollPosition >= viewPanelInfo.OverallScrollCount)
					{
						this.EffectiveScrollPosition = global::System.Math.Max(0, effectiveScrollPosition);
					}
					base.InvalidateMeasure();
					return true;
				}
				return true;
			}
		}

		// Token: 0x06001794 RID: 6036 RVA: 0x000684D4 File Offset: 0x000666D4
		void global::Infragistics.Windows.Scrolling.IDeferredScrollPanel.OnThumbDragComplete(bool cancelled)
		{
			if (this.ScrollingData._isInDeferredDrag)
			{
				this._scrollingData._isInDeferredDrag = false;
				bool flag = this.LogicalOrientation == global::System.Windows.Controls.Orientation.Vertical;
				double num;
				double num2;
				if (flag)
				{
					num = this._scrollingData._extentForScrollbar.Height;
					num2 = this._scrollingData._viewportForScrollbar.Height;
				}
				else
				{
					num = this._scrollingData._extentForScrollbar.Width;
					num2 = this._scrollingData._viewportForScrollbar.Width;
				}
				if (this._scrollingData._deferredDragOffset + num2 >= num)
				{
					double num3 = flag ? this._scrollingData._extent.Height : this._scrollingData._extent.Width;
					global::Infragistics.Windows.DataPresenter.GridViewSettingsBase viewSettings = this.ViewSettings;
					if (this.ViewSettings != null && viewSettings.AllowLastRecordScrollToTop)
					{
						this._scrollingData._deferredDragOffset = global::System.Math.Max(num3 - 1.0, this._scrollingData._deferredDragOffset);
					}
					else
					{
						this._scrollingData._deferredDragOffset = global::System.Math.Max(num3 - 2.0, this._scrollingData._deferredDragOffset);
					}
				}
				if (flag)
				{
					this.SetVerticalOffset(this._scrollingData._deferredDragOffset);
				}
				else
				{
					this.SetHorizontalOffset(this._scrollingData._deferredDragOffset);
				}
			}
			if (this.ScrollingData._scrollTip != null)
			{
				this.ScrollingData._scrollTip.IsOpen = false;
				this.ScrollingData._scrollTip = null;
			}
		}

		// Token: 0x06001795 RID: 6037 RVA: 0x00068644 File Offset: 0x00066844
		void global::Infragistics.Windows.Scrolling.IDeferredScrollPanel.OnThumbDragStart(global::System.Windows.Controls.Primitives.Thumb thumb, global::System.Windows.Controls.Orientation scrollBarOrientation)
		{
			if (this.DataPresenter.ScrollingMode == global::Infragistics.Windows.DataPresenter.ScrollingMode.DeferredWithScrollTips || this.DataPresenter.ScrollingMode == global::Infragistics.Windows.DataPresenter.ScrollingMode.Deferred)
			{
				this.ScrollingData._isInDeferredDrag = true;
				this.ScrollingData._deferredDragOffset = ((this.LogicalOrientation == global::System.Windows.Controls.Orientation.Vertical) ? this.ScrollingData._offset.Y : this.ScrollingData._offset.X);
				this.OnDeferredRecordScrollStart();
			}
			if (this.DataPresenter.ScrollingMode == global::Infragistics.Windows.DataPresenter.ScrollingMode.DeferredWithScrollTips)
			{
				global::Infragistics.Windows.DataPresenter.RecordScrollTip recordScrollTip = new global::Infragistics.Windows.DataPresenter.RecordScrollTip();
				this.ScrollingData._scrollTip = recordScrollTip;
				global::System.Windows.Point location = thumb.TranslatePoint(default(global::System.Windows.Point), this);
				global::System.Windows.Rect placementRectangle = new global::System.Windows.Rect(location, thumb.RenderSize);
				if (this.LogicalOrientation == global::System.Windows.Controls.Orientation.Vertical)
				{
					placementRectangle.Inflate(5.0, 0.0);
				}
				else
				{
					placementRectangle.Inflate(0.0, 5.0);
				}
				recordScrollTip.PlacementRectangle = placementRectangle;
				recordScrollTip.PlacementTarget = this;
				recordScrollTip.Placement = ((this.LogicalOrientation == global::System.Windows.Controls.Orientation.Vertical) ? global::System.Windows.Controls.Primitives.PlacementMode.Left : global::System.Windows.Controls.Primitives.PlacementMode.Top);
				global::Infragistics.Windows.DataPresenter.IViewPanelInfo viewPanelInfo = this.ViewPanelInfo;
				global::Infragistics.Windows.DataPresenter.Record topRecordFromScrollOffset = this.GetTopRecordFromScrollOffset(viewPanelInfo.OverallScrollPosition);
				this.ScrollingData.InitializeScrollTip(topRecordFromScrollOffset);
			}
		}

		// Token: 0x06001796 RID: 6038 RVA: 0x00068778 File Offset: 0x00066978
		bool global::Infragistics.Windows.Scrolling.IDeferredScrollPanel.SupportsDeferredScrolling(global::System.Windows.Controls.Orientation scrollBarOrientation, global::System.Windows.Controls.ScrollViewer scrollViewer)
		{
			return scrollViewer != null && this.IsRootPanel && scrollViewer.TemplatedParent == this.RecordListControl && scrollBarOrientation == this.LogicalOrientation;
		}

		// Token: 0x04000932 RID: 2354
		private global::Infragistics.Windows.DataPresenter.DataPresenterBase _dataPresenter;

		// Token: 0x04000933 RID: 2355
		private global::Infragistics.Windows.DataPresenter.RecordListControl _recordListControl;

		// Token: 0x04000934 RID: 2356
		private global::Infragistics.Windows.DataPresenter.GridViewPanel.ScrollData _scrollingData;

		// Token: 0x04000935 RID: 2357
		private global::Infragistics.Windows.DataPresenter.GridViewSettings _viewSettings;

		// Token: 0x04000936 RID: 2358
		private global::System.Collections.Generic.List<global::System.Windows.DependencyObject> _logicalChildren;

		// Token: 0x04000937 RID: 2359
		private bool _isHidingRecord;

		// Token: 0x04000938 RID: 2360
		private global::Infragistics.Windows.DataPresenter.FixedFieldInfo _fixedFieldInfo;

		// Token: 0x04000939 RID: 2361
		private bool _isRecordManagerWeakEventListenerHookedUp;

		// Token: 0x0400093A RID: 2362
		private bool _setOffsetTriggeredByPageBack;

		// Token: 0x0400093B RID: 2363
		private global::System.Windows.Vector _lastArrangeScrollOffset;

		// Token: 0x0400093C RID: 2364
		internal static readonly global::System.Windows.DependencyProperty DisplayNestedContentProperty = global::System.Windows.DependencyProperty.Register("DisplayNestedContent", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.GridViewPanel), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.TrueBox));

		// Token: 0x0400093D RID: 2365
		public static readonly global::System.Windows.DependencyProperty ViewSettingsProperty = global::System.Windows.DependencyProperty.Register("ViewSettings", typeof(global::Infragistics.Windows.DataPresenter.GridViewSettingsBase), typeof(global::Infragistics.Windows.DataPresenter.GridViewPanel), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DataPresenter.GridViewPanel.OnCoerceViewSettings)));

		// Token: 0x02000178 RID: 376
		internal class ScrollData
		{
			// Token: 0x06001797 RID: 6039 RVA: 0x000687A0 File Offset: 0x000669A0
			internal void InitializeScrollTip(global::Infragistics.Windows.DataPresenter.Record topRecord)
			{
				if (this._scrollTip != null)
				{
					global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.RecordScrollTipInfo> list = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.RecordScrollTipInfo>();
					if (topRecord != null)
					{
						list.Add(global::Infragistics.Windows.DataPresenter.RecordScrollTipInfo.Create(topRecord));
					}
					this._scrollTip.DataContext = list;
					this._scrollTip.Content = this._scrollTip.DataContext;
					this._scrollTip.IsOpen = true;
				}
			}

			// Token: 0x06001798 RID: 6040 RVA: 0x000687F8 File Offset: 0x000669F8
			internal void Reset()
			{
				this._offset = default(global::System.Windows.Vector);
				this._extent = default(global::System.Windows.Size);
				this._viewport = default(global::System.Windows.Size);
				this._extentForScrollbar = default(global::System.Windows.Size);
				this._viewportForScrollbar = default(global::System.Windows.Size);
				this._isLastRecordInView = false;
			}

			// Token: 0x0400093E RID: 2366
			internal global::System.Windows.Controls.ScrollViewer _scrollOwner;

			// Token: 0x0400093F RID: 2367
			internal global::System.Windows.Size _extent = default(global::System.Windows.Size);

			// Token: 0x04000940 RID: 2368
			internal global::System.Windows.Size _viewport = default(global::System.Windows.Size);

			// Token: 0x04000941 RID: 2369
			internal global::System.Windows.Vector _offset = default(global::System.Windows.Vector);

			// Token: 0x04000942 RID: 2370
			internal global::System.Windows.Size _extentForScrollbar = default(global::System.Windows.Size);

			// Token: 0x04000943 RID: 2371
			internal global::System.Windows.Size _viewportForScrollbar = default(global::System.Windows.Size);

			// Token: 0x04000944 RID: 2372
			internal double _averageHeightOfRecords;

			// Token: 0x04000945 RID: 2373
			internal double _highestRecordDisplayed;

			// Token: 0x04000946 RID: 2374
			internal bool _isLastRecordInView;

			// Token: 0x04000947 RID: 2375
			internal bool _hasOffsetChanged;

			// Token: 0x04000948 RID: 2376
			internal bool _canHorizontallyScroll;

			// Token: 0x04000949 RID: 2377
			internal bool _canVerticallyScroll;

			// Token: 0x0400094A RID: 2378
			internal global::System.Windows.Controls.ToolTip _scrollTip;

			// Token: 0x0400094B RID: 2379
			internal bool _isInDeferredDrag;

			// Token: 0x0400094C RID: 2380
			internal double _deferredDragOffset;

			// Token: 0x0400094D RID: 2381
			internal global::System.Windows.Size _availableScrollSize;
		}
	}
}
