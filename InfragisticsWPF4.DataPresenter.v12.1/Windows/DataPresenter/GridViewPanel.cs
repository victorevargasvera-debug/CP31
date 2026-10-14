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
	// Token: 0x0200015B RID: 347
	public abstract class GridViewPanel : global::Infragistics.Windows.Virtualization.RecyclingItemsPanel, global::System.Windows.Controls.Primitives.IScrollInfo, global::Infragistics.Windows.DataPresenter.IViewPanel, global::System.Windows.IWeakEventListener, global::Infragistics.Windows.Scrolling.IDeferredScrollPanel
	{
		// Token: 0x060013A9 RID: 5033 RVA: 0x000549BC File Offset: 0x00052BBC
		static GridViewPanel()
		{
			global::System.Windows.EventManager.RegisterClassHandler(typeof(global::Infragistics.Windows.DataPresenter.GridViewPanel), global::System.Windows.FrameworkElement.RequestBringIntoViewEvent, new global::System.Windows.RequestBringIntoViewEventHandler(global::Infragistics.Windows.DataPresenter.GridViewPanel.OnRequestBringIntoView));
		}

		// Token: 0x060013AA RID: 5034 RVA: 0x00054A4B File Offset: 0x00052C4B
		internal GridViewPanel()
		{
		}

		// Token: 0x170004B9 RID: 1209
		// (get) Token: 0x060013AB RID: 5035 RVA: 0x00054A53 File Offset: 0x00052C53
		protected override bool HasLogicalOrientation
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170004BA RID: 1210
		// (get) Token: 0x060013AC RID: 5036 RVA: 0x00054A58 File Offset: 0x00052C58
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

		// Token: 0x170004BB RID: 1211
		// (get) Token: 0x060013AD RID: 5037 RVA: 0x00054AA0 File Offset: 0x00052CA0
		protected override global::System.Windows.Controls.Orientation LogicalOrientation
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.GridViewSettings viewSettings = this.ViewSettings;
				if (viewSettings == null)
				{
					return global::System.Windows.Controls.Orientation.Vertical;
				}
				return viewSettings.Orientation;
			}
		}

		// Token: 0x060013AE RID: 5038 RVA: 0x00054ABF File Offset: 0x00052CBF
		protected override global::System.Windows.Media.Visual GetVisualChild(int index)
		{
			return base.GetVisualChild(index);
		}

		// Token: 0x060013AF RID: 5039 RVA: 0x00054AC8 File Offset: 0x00052CC8
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

		// Token: 0x060013B0 RID: 5040 RVA: 0x00054AE4 File Offset: 0x00052CE4
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

		// Token: 0x060013B1 RID: 5041 RVA: 0x00054B78 File Offset: 0x00052D78
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
				global::Infragistics.Windows.DataPresenter.GridViewSettings viewSettings = this.ViewSettings;
				if (viewSettings != null)
				{
					global::System.Windows.DependencyObject parent = global::System.Windows.LogicalTreeHelper.GetParent(viewSettings);
					if (parent == this)
					{
						base.RemoveLogicalChild(viewSettings);
					}
				}
				base.SetBinding(global::Infragistics.Windows.DataPresenter.GridViewPanel.ViewSettingsProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.DataPresenter.GridView.ViewSettingsProperty, global::System.Windows.Data.BindingMode.OneWay, global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetCurrentView(this)));
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

		// Token: 0x170004BC RID: 1212
		// (get) Token: 0x060013B2 RID: 5042
		public abstract bool IsRootPanel { get; }

		// Token: 0x170004BD RID: 1213
		// (get) Token: 0x060013B3 RID: 5043
		public abstract global::Infragistics.Windows.DataPresenter.GridViewPanel RootPanel { get; }

		// Token: 0x170004BE RID: 1214
		// (get) Token: 0x060013B4 RID: 5044 RVA: 0x00054CA8 File Offset: 0x00052EA8
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

		// Token: 0x170004BF RID: 1215
		// (get) Token: 0x060013B5 RID: 5045 RVA: 0x00054D12 File Offset: 0x00052F12
		internal int CleanupThreshhold
		{
			get
			{
				return 10;
			}
		}

		// Token: 0x170004C0 RID: 1216
		// (get) Token: 0x060013B6 RID: 5046 RVA: 0x00054D16 File Offset: 0x00052F16
		internal global::Infragistics.Windows.DataPresenter.DataPresenterBase DataPresenter
		{
			get
			{
				return this._dataPresenter;
			}
		}

		// Token: 0x170004C1 RID: 1217
		// (get) Token: 0x060013B7 RID: 5047 RVA: 0x00054D1E File Offset: 0x00052F1E
		// (set) Token: 0x060013B8 RID: 5048 RVA: 0x00054D30 File Offset: 0x00052F30
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

		// Token: 0x170004C2 RID: 1218
		// (get) Token: 0x060013B9 RID: 5049
		// (set) Token: 0x060013BA RID: 5050
		internal abstract int EffectiveScrollPosition { get; set; }

		// Token: 0x170004C3 RID: 1219
		// (get) Token: 0x060013BB RID: 5051
		internal abstract global::Infragistics.Windows.DataPresenter.Record FirstScrollableRecord { get; }

		// Token: 0x170004C4 RID: 1220
		// (get) Token: 0x060013BC RID: 5052 RVA: 0x00054D43 File Offset: 0x00052F43
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

		// Token: 0x170004C5 RID: 1221
		// (get) Token: 0x060013BD RID: 5053 RVA: 0x00054D7C File Offset: 0x00052F7C
		internal double HeightInfiniteContainersResolved
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.GridViewSettings viewSettings = this.ViewSettings;
				if (viewSettings != null)
				{
					double heightInInfiniteContainers = viewSettings.HeightInInfiniteContainers;
					if (!double.IsNaN(heightInInfiniteContainers))
					{
						return heightInInfiniteContainers;
					}
				}
				return global::Infragistics.Windows.Helpers.SafeSystemInformation.VirtualScreenHeight;
			}
		}

		// Token: 0x170004C6 RID: 1222
		// (get) Token: 0x060013BE RID: 5054 RVA: 0x00054DA9 File Offset: 0x00052FA9
		// (set) Token: 0x060013BF RID: 5055 RVA: 0x00054DB1 File Offset: 0x00052FB1
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

		// Token: 0x170004C7 RID: 1223
		// (get) Token: 0x060013C0 RID: 5056
		internal abstract bool IsRootPanelInInfiniteContainer { get; }

		// Token: 0x170004C8 RID: 1224
		// (get) Token: 0x060013C1 RID: 5057 RVA: 0x00054DBA File Offset: 0x00052FBA
		internal bool IsScrolling
		{
			get
			{
				return this.IsRootPanel && this.ScrollingData._scrollOwner != null;
			}
		}

		// Token: 0x170004C9 RID: 1225
		// (get) Token: 0x060013C2 RID: 5058 RVA: 0x00054DD7 File Offset: 0x00052FD7
		internal int MouseWheelScrollMultiplier
		{
			get
			{
				return global::System.Windows.SystemParameters.WheelScrollLines;
			}
		}

		// Token: 0x170004CA RID: 1226
		// (get) Token: 0x060013C3 RID: 5059 RVA: 0x00054DE0 File Offset: 0x00052FE0
		internal global::Infragistics.Windows.DataPresenter.Record RecordAtEffectiveScrollPosition
		{
			get
			{
				int effectiveScrollPosition = this.EffectiveScrollPosition;
				return this.ViewPanelInfo.GetRecordAtOverallScrollPosition(effectiveScrollPosition);
			}
		}

		// Token: 0x170004CB RID: 1227
		// (get) Token: 0x060013C4 RID: 5060 RVA: 0x00054E00 File Offset: 0x00053000
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

		// Token: 0x170004CC RID: 1228
		// (get) Token: 0x060013C5 RID: 5061
		internal abstract int RootPanelTopFixedOffset { get; }

		// Token: 0x170004CD RID: 1229
		// (get) Token: 0x060013C6 RID: 5062 RVA: 0x00054E21 File Offset: 0x00053021
		// (set) Token: 0x060013C7 RID: 5063 RVA: 0x00054E29 File Offset: 0x00053029
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

		// Token: 0x170004CE RID: 1230
		// (get) Token: 0x060013C8 RID: 5064 RVA: 0x00054E32 File Offset: 0x00053032
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

		// Token: 0x170004CF RID: 1231
		// (get) Token: 0x060013C9 RID: 5065
		internal abstract int ScrollPositionOfLastVisibleRecord { get; }

		// Token: 0x170004D0 RID: 1232
		// (get) Token: 0x060013CA RID: 5066 RVA: 0x00054E4D File Offset: 0x0005304D
		internal double ScrollSmallChangeInNonOrientationDimension
		{
			get
			{
				return 20.0;
			}
		}

		// Token: 0x170004D1 RID: 1233
		// (get) Token: 0x060013CB RID: 5067 RVA: 0x00054E58 File Offset: 0x00053058
		internal double ScrollSmallChangeInOrientationDimension
		{
			get
			{
				return 1.0;
			}
		}

		// Token: 0x170004D2 RID: 1234
		// (get) Token: 0x060013CC RID: 5068 RVA: 0x00054E63 File Offset: 0x00053063
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

		// Token: 0x170004D3 RID: 1235
		// (get) Token: 0x060013CD RID: 5069 RVA: 0x00054E7A File Offset: 0x0005307A
		internal global::Infragistics.Windows.DataPresenter.IViewPanelInfo ViewPanelInfo
		{
			get
			{
				return this.DataPresenter;
			}
		}

		// Token: 0x060013CE RID: 5070 RVA: 0x00054E82 File Offset: 0x00053082
		private static object OnCoerceViewSettings(global::System.Windows.DependencyObject d, object value)
		{
			if (value == null)
			{
				return new global::Infragistics.Windows.DataPresenter.GridViewSettings();
			}
			return value;
		}

		// Token: 0x170004D4 RID: 1236
		// (get) Token: 0x060013CF RID: 5071 RVA: 0x00054E8E File Offset: 0x0005308E
		// (set) Token: 0x060013D0 RID: 5072 RVA: 0x00054EA0 File Offset: 0x000530A0
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.DataPresenter.GridViewSettings ViewSettings
		{
			get
			{
				return base.GetValue(global::Infragistics.Windows.DataPresenter.GridViewPanel.ViewSettingsProperty) as global::Infragistics.Windows.DataPresenter.GridViewSettings;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.GridViewPanel.ViewSettingsProperty, value);
			}
		}

		// Token: 0x060013D1 RID: 5073 RVA: 0x00054EAE File Offset: 0x000530AE
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeViewSettings()
		{
			return this.ViewSettings != (global::Infragistics.Windows.DataPresenter.GridViewSettings)global::Infragistics.Windows.DataPresenter.GridViewPanel.ViewSettingsProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x060013D2 RID: 5074 RVA: 0x00054ECF File Offset: 0x000530CF
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetViewSettings()
		{
			this.ViewSettings = (global::Infragistics.Windows.DataPresenter.GridViewSettings)global::Infragistics.Windows.DataPresenter.GridViewPanel.ViewSettingsProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x170004D5 RID: 1237
		// (get) Token: 0x060013D3 RID: 5075 RVA: 0x00054EEC File Offset: 0x000530EC
		internal double WidthInfiniteContainersResolved
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.GridViewSettings viewSettings = this.ViewSettings;
				if (viewSettings != null)
				{
					double widthInInfiniteContainers = viewSettings.WidthInInfiniteContainers;
					if (!double.IsNaN(widthInInfiniteContainers))
					{
						return widthInInfiniteContainers;
					}
				}
				return global::Infragistics.Windows.Helpers.SafeSystemInformation.VirtualScreenWidth;
			}
		}

		// Token: 0x060013D4 RID: 5076 RVA: 0x00054F19 File Offset: 0x00053119
		private int EnsureIntInRange(int value, int minValue, int maxValue)
		{
			return global::System.Math.Max(global::System.Math.Min(maxValue, value), minValue);
		}

		// Token: 0x060013D5 RID: 5077 RVA: 0x00054F28 File Offset: 0x00053128
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

		// Token: 0x060013D6 RID: 5078 RVA: 0x00054FBA File Offset: 0x000531BA
		private int GetEffectiveGeneratedCount(global::System.Windows.Controls.UIElementCollection children)
		{
			if (!base.IsItemsHost)
			{
				return 0;
			}
			return children.Count;
		}

		// Token: 0x060013D7 RID: 5079 RVA: 0x00054FCC File Offset: 0x000531CC
		private global::Infragistics.Windows.DataPresenter.Record GetNavigationTargetRecord(global::Infragistics.Windows.DataPresenter.PanelNavigationDirection navigationDirection, global::Infragistics.Windows.DataPresenter.Record currentRecord, global::Infragistics.Windows.DataPresenter.PanelSiblingNavigationStyle siblingNavigationStyle, global::System.Type restrictToRecordType)
		{
			if (!this.IsRootPanel)
			{
				return this.RootPanel.GetNavigationTargetRecord(navigationDirection, currentRecord, siblingNavigationStyle, restrictToRecordType);
			}
			global::Infragistics.Windows.DataPresenter.GridViewSettings viewSettings = this.ViewSettings;
			if (viewSettings == null)
			{
				return null;
			}
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this.DataPresenter;
			global::Infragistics.Windows.DataPresenter.IViewPanelInfo viewPanelInfo = this.ViewPanelInfo;
			int overallScrollCount = viewPanelInfo.OverallScrollCount;
			bool flag = viewSettings.Orientation == global::System.Windows.Controls.Orientation.Vertical;
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

		// Token: 0x060013D8 RID: 5080 RVA: 0x00055220 File Offset: 0x00053420
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

		// Token: 0x060013D9 RID: 5081 RVA: 0x000552B0 File Offset: 0x000534B0
		private void OnViewSettingsPropertyChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
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
				if (this.ViewSettings.Orientation == global::System.Windows.Controls.Orientation.Horizontal)
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

		// Token: 0x060013DA RID: 5082 RVA: 0x00055438 File Offset: 0x00053638
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

		// Token: 0x060013DB RID: 5083
		internal abstract void SetOffsetInternal(double newOffset, double oldOffset, bool isSettingVerticalOffset);

		// Token: 0x060013DC RID: 5084 RVA: 0x0005548F File Offset: 0x0005368F
		private void SetupRecordManagerWeakEventListener(global::Infragistics.Windows.DataPresenter.RecordManager recordManager)
		{
			if (this._isRecordManagerWeakEventListenerHookedUp || recordManager == null)
			{
				return;
			}
			global::System.ComponentModel.PropertyChangedEventManager.AddListener(recordManager, this, string.Empty);
			this._isRecordManagerWeakEventListenerHookedUp = true;
		}

		// Token: 0x060013DD RID: 5085 RVA: 0x000554B0 File Offset: 0x000536B0
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

		// Token: 0x060013DE RID: 5086 RVA: 0x000554DC File Offset: 0x000536DC
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

		// Token: 0x060013DF RID: 5087
		internal abstract bool EnsureRecordIsVisible(global::Infragistics.Windows.DataPresenter.Record record);

		// Token: 0x060013E0 RID: 5088 RVA: 0x000555B0 File Offset: 0x000537B0
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

		// Token: 0x060013E1 RID: 5089 RVA: 0x000555FA File Offset: 0x000537FA
		internal int GetGeneratedIndexFromChildIndex(int childIndex)
		{
			return this.GetGenerator().IndexFromGeneratorPosition(new global::System.Windows.Controls.Primitives.GeneratorPosition(childIndex, 0));
		}

		// Token: 0x060013E2 RID: 5090 RVA: 0x00055610 File Offset: 0x00053810
		internal global::System.Windows.Controls.Primitives.GeneratorPosition GetGeneratorPositionFromItemIndex(int itemIndex, out int childIndex)
		{
			global::System.Windows.Controls.Primitives.IItemContainerGenerator generator = this.GetGenerator();
			global::System.Windows.Controls.Primitives.GeneratorPosition result = (generator != null) ? generator.GeneratorPositionFromIndex(itemIndex) : new global::System.Windows.Controls.Primitives.GeneratorPosition(-1, itemIndex + 1);
			childIndex = ((result.Offset == 0) ? result.Index : (result.Index + 1));
			return result;
		}

		// Token: 0x060013E3 RID: 5091 RVA: 0x00055658 File Offset: 0x00053858
		internal global::System.Windows.Controls.Primitives.IItemContainerGenerator GetGenerator()
		{
			if (this.RecordListControl == null)
			{
				throw new global::System.InvalidOperationException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_InvalidOperationException_11"));
			}
			return base.ActiveItemContainerGenerator;
		}

		// Token: 0x060013E4 RID: 5092 RVA: 0x00055678 File Offset: 0x00053878
		internal bool GetIsPreviousChildGenerated(int childIndex)
		{
			global::System.Windows.Controls.Primitives.GeneratorPosition position = new global::System.Windows.Controls.Primitives.GeneratorPosition(childIndex, 0);
			position = this.GetGenerator().GeneratorPositionFromIndex(this.GetGenerator().IndexFromGeneratorPosition(position) - 1);
			return position.Offset == 0;
		}

		// Token: 0x060013E5 RID: 5093 RVA: 0x000556B2 File Offset: 0x000538B2
		internal bool GetIsIndexOutOfRange(int index, int minIndex, int maxIndex)
		{
			return index < minIndex || index > maxIndex;
		}

		// Token: 0x060013E6 RID: 5094 RVA: 0x000556C0 File Offset: 0x000538C0
		internal virtual int GetScrollOffsetFromRecord(global::Infragistics.Windows.DataPresenter.Record record)
		{
			global::Infragistics.Windows.DataPresenter.IViewPanelInfo viewPanelInfo = this.ViewPanelInfo;
			int val = viewPanelInfo.GetOverallScrollPositionForRecord(record) - this.RootPanelTopFixedOffset;
			return global::System.Math.Min(global::System.Math.Max(val, 0), viewPanelInfo.OverallScrollCount - 1);
		}

		// Token: 0x060013E7 RID: 5095 RVA: 0x000556F8 File Offset: 0x000538F8
		internal virtual global::Infragistics.Windows.DataPresenter.Record GetTopRecordFromScrollOffset(int scrollOffset)
		{
			global::Infragistics.Windows.DataPresenter.IViewPanelInfo viewPanelInfo = this.ViewPanelInfo;
			scrollOffset += this.RootPanelTopFixedOffset;
			return viewPanelInfo.GetRecordAtOverallScrollPosition(global::System.Math.Min(global::System.Math.Max(scrollOffset, 0), viewPanelInfo.OverallScrollCount - 1));
		}

		// Token: 0x170004D6 RID: 1238
		// (get) Token: 0x060013E8 RID: 5096 RVA: 0x00055730 File Offset: 0x00053930
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

		// Token: 0x060013E9 RID: 5097 RVA: 0x00055796 File Offset: 0x00053996
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

		// Token: 0x060013EA RID: 5098 RVA: 0x000557B6 File Offset: 0x000539B6
		internal void OnArrangeComplete()
		{
			if (this.IsRootPanel)
			{
				this._lastArrangeScrollOffset = this.ScrollingData._offset;
			}
		}

		// Token: 0x060013EB RID: 5099 RVA: 0x000557D1 File Offset: 0x000539D1
		internal virtual void OnDeferredRecordScrollStart()
		{
		}

		// Token: 0x060013EC RID: 5100 RVA: 0x000557D3 File Offset: 0x000539D3
		internal void OnScrollInfoChange()
		{
			if (this.ScrollingData._scrollOwner != null)
			{
				this.ScrollingData._scrollOwner.InvalidateScrollInfo();
			}
		}

		// Token: 0x060013ED RID: 5101 RVA: 0x000557F2 File Offset: 0x000539F2
		internal void RemoveLogicalChildInternal(global::System.Windows.DependencyObject child)
		{
			if (this._logicalChildren != null)
			{
				this._logicalChildren.Remove(child);
				base.RemoveLogicalChild(child);
			}
		}

		// Token: 0x060013EE RID: 5102
		internal abstract void SetBoundaryRecordFlags();

		// Token: 0x060013EF RID: 5103 RVA: 0x00055810 File Offset: 0x00053A10
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

		// Token: 0x060013F0 RID: 5104 RVA: 0x000558CC File Offset: 0x00053ACC
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

		// Token: 0x060013F1 RID: 5105 RVA: 0x0005595C File Offset: 0x00053B5C
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

		// Token: 0x170004D7 RID: 1239
		// (get) Token: 0x060013F2 RID: 5106 RVA: 0x00055A20 File Offset: 0x00053C20
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

		// Token: 0x170004D8 RID: 1240
		// (get) Token: 0x060013F3 RID: 5107 RVA: 0x00055A85 File Offset: 0x00053C85
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

		// Token: 0x170004D9 RID: 1241
		// (get) Token: 0x060013F4 RID: 5108 RVA: 0x00055AA9 File Offset: 0x00053CA9
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

		// Token: 0x170004DA RID: 1242
		// (get) Token: 0x060013F5 RID: 5109 RVA: 0x00055AD0 File Offset: 0x00053CD0
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

		// Token: 0x170004DB RID: 1243
		// (get) Token: 0x060013F6 RID: 5110 RVA: 0x00055B20 File Offset: 0x00053D20
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

		// Token: 0x060013F7 RID: 5111 RVA: 0x00055B71 File Offset: 0x00053D71
		public void SetHorizontalOffset(double newOffset)
		{
			this.SetOffsetInternal(newOffset, this.HorizontalOffset, false);
		}

		// Token: 0x060013F8 RID: 5112 RVA: 0x00055B81 File Offset: 0x00053D81
		public void SetVerticalOffset(double newOffset)
		{
			this.SetOffsetInternal(newOffset, this.VerticalOffset, true);
		}

		// Token: 0x060013F9 RID: 5113 RVA: 0x00055B91 File Offset: 0x00053D91
		public void LineDown()
		{
			if (!this.IsRootPanel)
			{
				this.RootPanel.LineDown();
				return;
			}
			this.SetVerticalOffset(this.VerticalOffset + ((this.LogicalOrientation == global::System.Windows.Controls.Orientation.Vertical) ? this.ScrollSmallChangeInOrientationDimension : this.ScrollSmallChangeInNonOrientationDimension));
		}

		// Token: 0x060013FA RID: 5114 RVA: 0x00055BCB File Offset: 0x00053DCB
		public void LineLeft()
		{
			if (!this.IsRootPanel)
			{
				this.RootPanel.LineUp();
				return;
			}
			this.SetHorizontalOffset(this.HorizontalOffset - ((this.LogicalOrientation == global::System.Windows.Controls.Orientation.Horizontal) ? this.ScrollSmallChangeInOrientationDimension : this.ScrollSmallChangeInNonOrientationDimension));
		}

		// Token: 0x060013FB RID: 5115 RVA: 0x00055C04 File Offset: 0x00053E04
		public void LineRight()
		{
			if (!this.IsRootPanel)
			{
				this.RootPanel.LineRight();
				return;
			}
			this.SetHorizontalOffset(this.HorizontalOffset + ((this.LogicalOrientation == global::System.Windows.Controls.Orientation.Horizontal) ? this.ScrollSmallChangeInOrientationDimension : this.ScrollSmallChangeInNonOrientationDimension));
		}

		// Token: 0x060013FC RID: 5116 RVA: 0x00055C3D File Offset: 0x00053E3D
		public void LineUp()
		{
			if (!this.IsRootPanel)
			{
				this.RootPanel.LineUp();
				return;
			}
			this.SetVerticalOffset(this.VerticalOffset - ((this.LogicalOrientation == global::System.Windows.Controls.Orientation.Vertical) ? this.ScrollSmallChangeInOrientationDimension : this.ScrollSmallChangeInNonOrientationDimension));
		}

		// Token: 0x060013FD RID: 5117 RVA: 0x00055C78 File Offset: 0x00053E78
		public void MouseWheelDown()
		{
			if (!this.IsRootPanel)
			{
				this.RootPanel.MouseWheelDown();
				return;
			}
			this.SetVerticalOffset(this.VerticalOffset + (double)this.MouseWheelScrollMultiplier * ((this.LogicalOrientation == global::System.Windows.Controls.Orientation.Vertical) ? this.ScrollSmallChangeInOrientationDimension : this.ScrollSmallChangeInNonOrientationDimension));
		}

		// Token: 0x060013FE RID: 5118 RVA: 0x00055CC8 File Offset: 0x00053EC8
		public void MouseWheelLeft()
		{
			if (!this.IsRootPanel)
			{
				this.RootPanel.MouseWheelLeft();
				return;
			}
			this.SetHorizontalOffset(this.HorizontalOffset - (double)this.MouseWheelScrollMultiplier * ((this.LogicalOrientation == global::System.Windows.Controls.Orientation.Horizontal) ? this.ScrollSmallChangeInOrientationDimension : this.ScrollSmallChangeInNonOrientationDimension));
		}

		// Token: 0x060013FF RID: 5119 RVA: 0x00055D14 File Offset: 0x00053F14
		public void MouseWheelRight()
		{
			if (!this.IsRootPanel)
			{
				this.RootPanel.MouseWheelRight();
				return;
			}
			this.SetHorizontalOffset(this.HorizontalOffset + (double)this.MouseWheelScrollMultiplier * ((this.LogicalOrientation == global::System.Windows.Controls.Orientation.Horizontal) ? this.ScrollSmallChangeInOrientationDimension : this.ScrollSmallChangeInNonOrientationDimension));
		}

		// Token: 0x06001400 RID: 5120 RVA: 0x00055D60 File Offset: 0x00053F60
		public void MouseWheelUp()
		{
			if (!this.IsRootPanel)
			{
				this.RootPanel.MouseWheelUp();
				return;
			}
			this.SetVerticalOffset(this.VerticalOffset - (double)this.MouseWheelScrollMultiplier * ((this.LogicalOrientation == global::System.Windows.Controls.Orientation.Vertical) ? this.ScrollSmallChangeInOrientationDimension : this.ScrollSmallChangeInNonOrientationDimension));
		}

		// Token: 0x06001401 RID: 5121 RVA: 0x00055DB0 File Offset: 0x00053FB0
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

		// Token: 0x06001402 RID: 5122 RVA: 0x00055E1A File Offset: 0x0005401A
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

		// Token: 0x06001403 RID: 5123 RVA: 0x00055E4C File Offset: 0x0005404C
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

		// Token: 0x06001404 RID: 5124 RVA: 0x00055EB7 File Offset: 0x000540B7
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

		// Token: 0x170004DC RID: 1244
		// (get) Token: 0x06001405 RID: 5125 RVA: 0x00055EE7 File Offset: 0x000540E7
		// (set) Token: 0x06001406 RID: 5126 RVA: 0x00055EF4 File Offset: 0x000540F4
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

		// Token: 0x170004DD RID: 1245
		// (get) Token: 0x06001407 RID: 5127 RVA: 0x00055F21 File Offset: 0x00054121
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

		// Token: 0x170004DE RID: 1246
		// (get) Token: 0x06001408 RID: 5128 RVA: 0x00055F45 File Offset: 0x00054145
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

		// Token: 0x06001409 RID: 5129 RVA: 0x00055F6C File Offset: 0x0005416C
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

		// Token: 0x170004DF RID: 1247
		// (get) Token: 0x0600140A RID: 5130 RVA: 0x00056234 File Offset: 0x00054434
		// (set) Token: 0x0600140B RID: 5131 RVA: 0x00056241 File Offset: 0x00054441
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

		// Token: 0x170004E0 RID: 1248
		// (get) Token: 0x0600140C RID: 5132 RVA: 0x00056263 File Offset: 0x00054463
		// (set) Token: 0x0600140D RID: 5133 RVA: 0x00056270 File Offset: 0x00054470
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

		// Token: 0x0600140E RID: 5134 RVA: 0x00056292 File Offset: 0x00054492
		bool global::Infragistics.Windows.DataPresenter.IViewPanel.EnsureCellIsVisible(global::Infragistics.Windows.DataPresenter.Cell cell)
		{
			return this.RootPanel.EnsureCellIsVisible(cell);
		}

		// Token: 0x0600140F RID: 5135 RVA: 0x000562A0 File Offset: 0x000544A0
		bool global::Infragistics.Windows.DataPresenter.IViewPanel.EnsureRecordIsVisible(global::Infragistics.Windows.DataPresenter.Record record)
		{
			return this.RootPanel.EnsureRecordIsVisible(record);
		}

		// Token: 0x06001410 RID: 5136 RVA: 0x000562B0 File Offset: 0x000544B0
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

		// Token: 0x06001411 RID: 5137 RVA: 0x00056358 File Offset: 0x00054558
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

		// Token: 0x06001412 RID: 5138 RVA: 0x000563C8 File Offset: 0x000545C8
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

		// Token: 0x06001413 RID: 5139 RVA: 0x0005646C File Offset: 0x0005466C
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

		// Token: 0x06001414 RID: 5140 RVA: 0x000564E4 File Offset: 0x000546E4
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

		// Token: 0x06001415 RID: 5141 RVA: 0x00056590 File Offset: 0x00054790
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

		// Token: 0x170004E1 RID: 1249
		// (get) Token: 0x06001416 RID: 5142 RVA: 0x000565D0 File Offset: 0x000547D0
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

		// Token: 0x06001417 RID: 5143 RVA: 0x000565F9 File Offset: 0x000547F9
		void global::Infragistics.Windows.DataPresenter.IViewPanel.OnActiveRecordChanged(global::Infragistics.Windows.DataPresenter.Record record)
		{
		}

		// Token: 0x06001418 RID: 5144 RVA: 0x000565FB File Offset: 0x000547FB
		void global::Infragistics.Windows.DataPresenter.IViewPanel.OnSelectedItemsChanged()
		{
		}

		// Token: 0x06001419 RID: 5145 RVA: 0x00056600 File Offset: 0x00054800
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

		// Token: 0x0600141A RID: 5146 RVA: 0x00056658 File Offset: 0x00054858
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

		// Token: 0x0600141B RID: 5147 RVA: 0x00056700 File Offset: 0x00054900
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
					this._scrollingData._deferredDragOffset = global::System.Math.Max(num3 - 2.0, this._scrollingData._deferredDragOffset);
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

		// Token: 0x0600141C RID: 5148 RVA: 0x0005682C File Offset: 0x00054A2C
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

		// Token: 0x0600141D RID: 5149 RVA: 0x00056960 File Offset: 0x00054B60
		bool global::Infragistics.Windows.Scrolling.IDeferredScrollPanel.SupportsDeferredScrolling(global::System.Windows.Controls.Orientation scrollBarOrientation, global::System.Windows.Controls.ScrollViewer scrollViewer)
		{
			return scrollViewer != null && this.IsRootPanel && scrollViewer.TemplatedParent == this.RecordListControl && scrollBarOrientation == this.LogicalOrientation;
		}

		// Token: 0x04000780 RID: 1920
		private global::Infragistics.Windows.DataPresenter.DataPresenterBase _dataPresenter;

		// Token: 0x04000781 RID: 1921
		private global::Infragistics.Windows.DataPresenter.RecordListControl _recordListControl;

		// Token: 0x04000782 RID: 1922
		private global::Infragistics.Windows.DataPresenter.GridViewPanel.ScrollData _scrollingData;

		// Token: 0x04000783 RID: 1923
		private global::Infragistics.Windows.DataPresenter.GridViewSettings _viewSettings;

		// Token: 0x04000784 RID: 1924
		private global::System.Collections.Generic.List<global::System.Windows.DependencyObject> _logicalChildren;

		// Token: 0x04000785 RID: 1925
		private bool _isHidingRecord;

		// Token: 0x04000786 RID: 1926
		private global::Infragistics.Windows.DataPresenter.FixedFieldInfo _fixedFieldInfo;

		// Token: 0x04000787 RID: 1927
		private bool _isRecordManagerWeakEventListenerHookedUp;

		// Token: 0x04000788 RID: 1928
		private bool _setOffsetTriggeredByPageBack;

		// Token: 0x04000789 RID: 1929
		private global::System.Windows.Vector _lastArrangeScrollOffset;

		// Token: 0x0400078A RID: 1930
		internal static readonly global::System.Windows.DependencyProperty DisplayNestedContentProperty = global::System.Windows.DependencyProperty.Register("DisplayNestedContent", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.GridViewPanel), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.TrueBox));

		// Token: 0x0400078B RID: 1931
		public static readonly global::System.Windows.DependencyProperty ViewSettingsProperty = global::System.Windows.DependencyProperty.Register("ViewSettings", typeof(global::Infragistics.Windows.DataPresenter.GridViewSettings), typeof(global::Infragistics.Windows.DataPresenter.GridViewPanel), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DataPresenter.GridViewPanel.OnCoerceViewSettings)));

		// Token: 0x0200015C RID: 348
		internal class ScrollData
		{
			// Token: 0x0600141E RID: 5150 RVA: 0x00056988 File Offset: 0x00054B88
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

			// Token: 0x0600141F RID: 5151 RVA: 0x000569E0 File Offset: 0x00054BE0
			internal void Reset()
			{
				this._offset = default(global::System.Windows.Vector);
				this._extent = default(global::System.Windows.Size);
				this._viewport = default(global::System.Windows.Size);
				this._extentForScrollbar = default(global::System.Windows.Size);
				this._viewportForScrollbar = default(global::System.Windows.Size);
				this._isLastRecordInView = false;
			}

			// Token: 0x0400078C RID: 1932
			internal global::System.Windows.Controls.ScrollViewer _scrollOwner;

			// Token: 0x0400078D RID: 1933
			internal global::System.Windows.Size _extent = default(global::System.Windows.Size);

			// Token: 0x0400078E RID: 1934
			internal global::System.Windows.Size _viewport = default(global::System.Windows.Size);

			// Token: 0x0400078F RID: 1935
			internal global::System.Windows.Vector _offset = default(global::System.Windows.Vector);

			// Token: 0x04000790 RID: 1936
			internal global::System.Windows.Size _extentForScrollbar = default(global::System.Windows.Size);

			// Token: 0x04000791 RID: 1937
			internal global::System.Windows.Size _viewportForScrollbar = default(global::System.Windows.Size);

			// Token: 0x04000792 RID: 1938
			internal double _averageHeightOfRecords;

			// Token: 0x04000793 RID: 1939
			internal double _highestRecordDisplayed;

			// Token: 0x04000794 RID: 1940
			internal bool _isLastRecordInView;

			// Token: 0x04000795 RID: 1941
			internal bool _hasOffsetChanged;

			// Token: 0x04000796 RID: 1942
			internal bool _canHorizontallyScroll;

			// Token: 0x04000797 RID: 1943
			internal bool _canVerticallyScroll;

			// Token: 0x04000798 RID: 1944
			internal global::System.Windows.Controls.ToolTip _scrollTip;

			// Token: 0x04000799 RID: 1945
			internal bool _isInDeferredDrag;

			// Token: 0x0400079A RID: 1946
			internal double _deferredDragOffset;

			// Token: 0x0400079B RID: 1947
			internal global::System.Windows.Size _availableScrollSize;
		}
	}
}
