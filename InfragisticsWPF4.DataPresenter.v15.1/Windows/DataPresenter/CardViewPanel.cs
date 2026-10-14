using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Media.Animation;
using Infragistics.Windows.Internal;
using Infragistics.Windows.Selection;
using Infragistics.Windows.Tiles;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200023B RID: 571
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class CardViewPanel : global::Infragistics.Windows.Tiles.TilesPanelBase, global::Infragistics.Windows.DataPresenter.IViewPanel, global::System.Windows.IWeakEventListener
	{
		// Token: 0x0600213F RID: 8511 RVA: 0x000944FC File Offset: 0x000926FC
		protected internal override global::Infragistics.Windows.Tiles.ITileConstraints GetContainerConstraints(global::System.Windows.DependencyObject container, global::Infragistics.Windows.Tiles.TileState state)
		{
			global::Infragistics.Windows.DataPresenter.CardViewPanel.TileConstraints tileConstraints = new global::Infragistics.Windows.DataPresenter.CardViewPanel.TileConstraints();
			tileConstraints.MaxHeight = double.PositiveInfinity;
			tileConstraints.MaxWidth = double.PositiveInfinity;
			global::Infragistics.Windows.DataPresenter.CardViewSettings viewSettings = this.ViewSettings;
			global::Infragistics.Windows.DataPresenter.CardViewCard cardViewCard = container as global::Infragistics.Windows.DataPresenter.CardViewCard;
			if (viewSettings == null || cardViewCard == null)
			{
				return tileConstraints;
			}
			if (!double.IsNaN(viewSettings.CardHeight) && !cardViewCard.IsCollapsed)
			{
				tileConstraints.PreferredHeight = viewSettings.CardHeight;
			}
			if (!double.IsNaN(viewSettings.CardWidth))
			{
				tileConstraints.PreferredWidth = viewSettings.CardWidth;
			}
			switch (viewSettings.AutoFitCards)
			{
			case global::Infragistics.Windows.DataPresenter.AutoFitCards.Horizontally:
				tileConstraints.HorizontalAlignment = new global::System.Windows.HorizontalAlignment?(global::System.Windows.HorizontalAlignment.Stretch);
				break;
			case global::Infragistics.Windows.DataPresenter.AutoFitCards.Vertically:
				tileConstraints.VerticalAlignment = new global::System.Windows.VerticalAlignment?(global::System.Windows.VerticalAlignment.Stretch);
				break;
			case global::Infragistics.Windows.DataPresenter.AutoFitCards.HorizontallyAndVertically:
				tileConstraints.HorizontalAlignment = new global::System.Windows.HorizontalAlignment?(global::System.Windows.HorizontalAlignment.Stretch);
				tileConstraints.VerticalAlignment = new global::System.Windows.VerticalAlignment?(global::System.Windows.VerticalAlignment.Stretch);
				break;
			}
			return tileConstraints;
		}

		// Token: 0x06002140 RID: 8512 RVA: 0x000945D0 File Offset: 0x000927D0
		protected internal override global::System.Windows.HorizontalAlignment GetHorizontalTileAreaAlignment()
		{
			if (this.ViewSettings == null)
			{
				return global::System.Windows.HorizontalAlignment.Left;
			}
			global::Infragistics.Windows.DataPresenter.AutoFitCards autoFitCards = this.ViewSettings.AutoFitCards;
			if (autoFitCards == global::Infragistics.Windows.DataPresenter.AutoFitCards.Horizontally || autoFitCards == global::Infragistics.Windows.DataPresenter.AutoFitCards.HorizontallyAndVertically)
			{
				return global::System.Windows.HorizontalAlignment.Stretch;
			}
			return global::System.Windows.HorizontalAlignment.Left;
		}

		// Token: 0x06002141 RID: 8513 RVA: 0x000945FE File Offset: 0x000927FE
		protected internal override double GetInterTileSpacing(bool vertical, global::Infragistics.Windows.Tiles.TileState state)
		{
			if (this.ViewSettings == null)
			{
				return 0.0;
			}
			if (!vertical)
			{
				return this.ViewSettings.InterCardSpacingX;
			}
			return this.ViewSettings.InterCardSpacingY;
		}

		// Token: 0x06002142 RID: 8514 RVA: 0x0009462C File Offset: 0x0009282C
		protected internal override bool GetIsInDeferredScrollingMode()
		{
			return this.DataPresenter != null && (this.DataPresenter.ScrollingMode == global::Infragistics.Windows.DataPresenter.ScrollingMode.DeferredWithScrollTips || this.DataPresenter.ScrollingMode == global::Infragistics.Windows.DataPresenter.ScrollingMode.Deferred);
		}

		// Token: 0x06002143 RID: 8515 RVA: 0x00094655 File Offset: 0x00092855
		protected internal override int GetMaxColumns()
		{
			if (this.ViewSettings == null)
			{
				return 0;
			}
			return this.ViewSettings.MaxCardCols;
		}

		// Token: 0x06002144 RID: 8516 RVA: 0x0009466C File Offset: 0x0009286C
		protected internal override int GetMaxRows()
		{
			if (this.ViewSettings == null)
			{
				return 0;
			}
			return this.ViewSettings.MaxCardRows;
		}

		// Token: 0x06002145 RID: 8517 RVA: 0x00094683 File Offset: 0x00092883
		protected internal override int GetMinColumns()
		{
			return 1;
		}

		// Token: 0x06002146 RID: 8518 RVA: 0x00094686 File Offset: 0x00092886
		protected internal override int GetMinRows()
		{
			return 1;
		}

		// Token: 0x06002147 RID: 8519 RVA: 0x00094689 File Offset: 0x00092889
		protected override global::System.Windows.Media.Animation.DoubleAnimationBase GetRepositionAnimation()
		{
			if (this.ViewSettings == null)
			{
				return null;
			}
			return this.ViewSettings.RepositionAnimation;
		}

		// Token: 0x06002148 RID: 8520 RVA: 0x000946A0 File Offset: 0x000928A0
		protected internal override bool GetShouldAnimate()
		{
			return this.ViewSettings == null || this.ViewSettings.ShouldAnimateCardPositioning;
		}

		// Token: 0x06002149 RID: 8521 RVA: 0x000946B7 File Offset: 0x000928B7
		protected internal override bool GetSupportsDeferredScrolling(global::System.Windows.Controls.Orientation scrollBarOrientation, global::System.Windows.Controls.ScrollViewer scrollViewer)
		{
			return scrollViewer != null && scrollViewer.TemplatedParent == this.RecordListControl && scrollBarOrientation == this.ScrollBarOrientation;
		}

		// Token: 0x0600214A RID: 8522 RVA: 0x000946D8 File Offset: 0x000928D8
		protected internal override global::System.Windows.Thickness GetTileAreaPadding()
		{
			if (this.ViewSettings == null)
			{
				return default(global::System.Windows.Thickness);
			}
			return this.ViewSettings.Padding;
		}

		// Token: 0x0600214B RID: 8523 RVA: 0x00094702 File Offset: 0x00092902
		protected internal override global::Infragistics.Windows.Tiles.TileLayoutOrder GetTileLayoutOrder()
		{
			if (this.ViewSettings == null)
			{
				return global::Infragistics.Windows.Tiles.TileLayoutOrder.Horizontal;
			}
			if (this.ViewSettings.Orientation != global::System.Windows.Controls.Orientation.Vertical)
			{
				return global::Infragistics.Windows.Tiles.TileLayoutOrder.Horizontal;
			}
			return global::Infragistics.Windows.Tiles.TileLayoutOrder.VerticalVariable;
		}

		// Token: 0x0600214C RID: 8524 RVA: 0x00094720 File Offset: 0x00092920
		protected internal override global::System.Windows.VerticalAlignment GetVerticalTileAreaAlignment()
		{
			if (this.ViewSettings == null)
			{
				return global::System.Windows.VerticalAlignment.Top;
			}
			global::Infragistics.Windows.DataPresenter.AutoFitCards autoFitCards = this.ViewSettings.AutoFitCards;
			if (autoFitCards == global::Infragistics.Windows.DataPresenter.AutoFitCards.Vertically || autoFitCards == global::Infragistics.Windows.DataPresenter.AutoFitCards.HorizontallyAndVertically)
			{
				return global::System.Windows.VerticalAlignment.Stretch;
			}
			return global::System.Windows.VerticalAlignment.Top;
		}

		// Token: 0x17000960 RID: 2400
		// (get) Token: 0x0600214D RID: 8525 RVA: 0x0009474E File Offset: 0x0009294E
		protected override bool IsOkToCleanupUnusedGeneratedElements
		{
			get
			{
				return !base.IsAnimationInProgress;
			}
		}

		// Token: 0x0600214E RID: 8526 RVA: 0x0009475C File Offset: 0x0009295C
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size availableSize)
		{
			global::System.Windows.Size result = base.MeasureOverride(availableSize);
			if (this.DataPresenter != null)
			{
				((global::Infragistics.Windows.DataPresenter.IViewPanelInfo)this.DataPresenter).OverallScrollPosition = base.ScrollPosition;
			}
			this._layoutColumns = null;
			return result;
		}

		// Token: 0x0600214F RID: 8527 RVA: 0x00094794 File Offset: 0x00092994
		protected override void OnItemsChanged(object sender, global::System.Windows.Controls.Primitives.ItemsChangedEventArgs args)
		{
			base.OnItemsChanged(sender, args);
			switch (args.Action)
			{
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Add:
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Replace:
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Move:
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset:
				break;
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Remove:
				if (args.Position.Index > -1)
				{
					base.RemoveInternalChildRange(args.Position.Index, 1);
				}
				break;
			default:
				return;
			}
		}

		// Token: 0x06002150 RID: 8528 RVA: 0x000947F4 File Offset: 0x000929F4
		protected internal override void OnDeferredScrollingStarted(global::System.Windows.Controls.Primitives.Thumb thumb, global::System.Windows.Controls.Orientation scrollBarOrientation)
		{
			if (this.DataPresenter != null && this.DataPresenter.ScrollingMode == global::Infragistics.Windows.DataPresenter.ScrollingMode.DeferredWithScrollTips)
			{
				this._recordScrollTip = new global::Infragistics.Windows.DataPresenter.RecordScrollTip();
				global::System.Windows.Point location = thumb.TranslatePoint(default(global::System.Windows.Point), this);
				global::System.Windows.Rect placementRectangle = new global::System.Windows.Rect(location, thumb.RenderSize);
				if (this.ScrollBarOrientation == global::System.Windows.Controls.Orientation.Vertical)
				{
					placementRectangle.Inflate(5.0, 0.0);
				}
				else
				{
					placementRectangle.Inflate(0.0, 5.0);
				}
				this._recordScrollTip.PlacementRectangle = placementRectangle;
				this._recordScrollTip.PlacementTarget = this;
				this._recordScrollTip.Placement = ((this.ScrollBarOrientation == global::System.Windows.Controls.Orientation.Horizontal) ? global::System.Windows.Controls.Primitives.PlacementMode.Top : global::System.Windows.Controls.Primitives.PlacementMode.Left);
				if (this.ViewPanelInfo != null)
				{
					this.InitializeScrollTip(this.ViewPanelInfo.GetRecordAtOverallScrollPosition(this.ViewPanelInfo.OverallScrollPosition));
				}
			}
		}

		// Token: 0x06002151 RID: 8529 RVA: 0x000948D8 File Offset: 0x00092AD8
		protected internal override void OnDeferredScrollingEnded(bool cancelled)
		{
			if (this._recordScrollTip != null)
			{
				this._recordScrollTip.IsOpen = false;
				this._recordScrollTip = null;
			}
		}

		// Token: 0x06002152 RID: 8530 RVA: 0x000948F5 File Offset: 0x00092AF5
		protected internal override void OnDeferredScrollOffsetChanged(double newDeferredScrollPosition)
		{
			if (this.ViewPanelInfo != null && this.RecordListControl != null && this.RecordListControl.HasItems)
			{
				this.InitializeScrollTip(this.ViewPanelInfo.GetRecordAtOverallScrollPosition(base.GetScrollPositionFromOffset(newDeferredScrollPosition)));
			}
		}

		// Token: 0x06002153 RID: 8531 RVA: 0x0009492C File Offset: 0x00092B2C
		protected override void OnPropertyChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			base.OnPropertyChanged(e);
			if (e.Property == global::Infragistics.Windows.DataPresenter.DataPresenterBase.DataPresenterProperty)
			{
				this._dataPresenter = (e.NewValue as global::Infragistics.Windows.DataPresenter.DataPresenterBase);
				this._dataPresenterViewPanelInfo = this._dataPresenter;
				if (!this._itemsPanelInitialized)
				{
					this._dataPresenter.InitializeItemsPanel();
					return;
				}
			}
			else if (e.Property == global::Infragistics.Windows.DataPresenter.CardViewPanel.ViewSettingsProperty)
			{
				if (this._viewSettings != null)
				{
					global::System.ComponentModel.PropertyChangedEventManager.RemoveListener(this._viewSettings, this, string.Empty);
				}
				this._viewSettings = (e.NewValue as global::Infragistics.Windows.DataPresenter.CardViewSettings);
				if (this._viewSettings != null)
				{
					global::System.ComponentModel.PropertyChangedEventManager.AddListener(this._viewSettings, this, string.Empty);
					this._viewSettings.EnumeratePropertiesWithNonDefaultValues(new global::System.ComponentModel.PropertyChangedEventHandler(this.OnViewSettingsPropertyChanged));
					if (this._dataPresenter != null)
					{
						this._dataPresenter.InitializeItemsPanel();
						this._itemsPanelInitialized = true;
						return;
					}
				}
			}
			else if (e.Property == global::Infragistics.Windows.DataPresenter.DataPresenterBase.CurrentViewProperty)
			{
				this._view = (e.NewValue as global::Infragistics.Windows.DataPresenter.ViewBase);
				global::Infragistics.Windows.DataPresenter.CardViewSettings viewSettings = this.ViewSettings;
				if (viewSettings != null)
				{
					global::System.Windows.DependencyObject parent = global::System.Windows.LogicalTreeHelper.GetParent(viewSettings);
					if (parent == this)
					{
						base.RemoveLogicalChild(viewSettings);
					}
				}
				base.SetBinding(global::Infragistics.Windows.DataPresenter.CardViewPanel.ViewSettingsProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.DataPresenter.CardView.ViewSettingsProperty, global::System.Windows.Data.BindingMode.OneWay, global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetCurrentView(this)));
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

		// Token: 0x06002154 RID: 8532 RVA: 0x00094A98 File Offset: 0x00092C98
		protected override void OnItemsInViewChanged()
		{
			global::Infragistics.Windows.DataPresenter.IViewPanelInfo viewPanelInfo = this.ViewPanelInfo;
			if (viewPanelInfo != null)
			{
				viewPanelInfo.OnRecordsInViewChanged();
			}
		}

		// Token: 0x06002155 RID: 8533 RVA: 0x00094AB8 File Offset: 0x00092CB8
		protected override void UpdateTransform(global::System.Windows.DependencyObject container, global::System.Windows.Rect originalRect, global::System.Windows.Rect currentRect, global::System.Windows.Rect targetRect, global::System.Windows.Vector offset, double resizeFactor, bool calledFromArrange)
		{
			global::Infragistics.Windows.DataPresenter.CardViewCard cardViewCard = container as global::Infragistics.Windows.DataPresenter.CardViewCard;
			if (cardViewCard != null)
			{
				cardViewCard.UpdateTransform(originalRect, currentRect, targetRect, offset, calledFromArrange);
				return;
			}
			base.UpdateTransform(container, originalRect, currentRect, targetRect, offset, resizeFactor, calledFromArrange);
		}

		// Token: 0x06002156 RID: 8534 RVA: 0x00094AEF File Offset: 0x00092CEF
		private static object OnCoerceViewSettings(global::System.Windows.DependencyObject d, object value)
		{
			if (value == null)
			{
				return new global::Infragistics.Windows.DataPresenter.CardViewSettings();
			}
			return value;
		}

		// Token: 0x17000961 RID: 2401
		// (get) Token: 0x06002157 RID: 8535 RVA: 0x00094AFB File Offset: 0x00092CFB
		// (set) Token: 0x06002158 RID: 8536 RVA: 0x00094B0D File Offset: 0x00092D0D
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.DataPresenter.CardViewSettings ViewSettings
		{
			get
			{
				return base.GetValue(global::Infragistics.Windows.DataPresenter.CardViewPanel.ViewSettingsProperty) as global::Infragistics.Windows.DataPresenter.CardViewSettings;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.CardViewPanel.ViewSettingsProperty, value);
			}
		}

		// Token: 0x06002159 RID: 8537 RVA: 0x00094B1B File Offset: 0x00092D1B
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeViewSettings()
		{
			return this.ViewSettings != (global::Infragistics.Windows.DataPresenter.CardViewSettings)global::Infragistics.Windows.DataPresenter.CardViewPanel.ViewSettingsProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x0600215A RID: 8538 RVA: 0x00094B3C File Offset: 0x00092D3C
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetViewSettings()
		{
			this.ViewSettings = (global::Infragistics.Windows.DataPresenter.CardViewSettings)global::Infragistics.Windows.DataPresenter.CardViewPanel.ViewSettingsProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x17000962 RID: 2402
		// (get) Token: 0x0600215B RID: 8539 RVA: 0x00094B58 File Offset: 0x00092D58
		private global::Infragistics.Windows.DataPresenter.DataPresenterBase DataPresenter
		{
			get
			{
				return this._dataPresenter;
			}
		}

		// Token: 0x17000963 RID: 2403
		// (get) Token: 0x0600215C RID: 8540 RVA: 0x00094B60 File Offset: 0x00092D60
		private global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::Infragistics.Windows.Tiles.ItemInfoBase>> LayoutColumns
		{
			get
			{
				if (this._layoutColumns == null)
				{
					int totalColumnsDisplayed = base.GetTotalColumnsDisplayed();
					this._layoutColumns = new global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::Infragistics.Windows.Tiles.ItemInfoBase>>(totalColumnsDisplayed);
					for (int i = 0; i < totalColumnsDisplayed; i++)
					{
						this._layoutColumns.Add(new global::System.Collections.Generic.List<global::Infragistics.Windows.Tiles.ItemInfoBase>());
					}
					global::Infragistics.Windows.Tiles.ItemInfoBase[] itemsInView = base.GetItemsInView();
					global::System.Array.Sort<global::Infragistics.Windows.Tiles.ItemInfoBase>(itemsInView, new global::Infragistics.Windows.DataPresenter.CardViewPanel.ItemInfoComparer());
					double num = double.MinValue;
					int num2 = -1;
					foreach (global::Infragistics.Windows.Tiles.ItemInfoBase itemInfoBase in itemsInView)
					{
						double left = itemInfoBase.GetCurrentTargetRect().Left;
						if (left > num)
						{
							num2++;
							num = left;
						}
						if (num2 >= this.LayoutColumns.Count)
						{
							break;
						}
						this._layoutColumns[num2].Add(itemInfoBase);
					}
				}
				return this._layoutColumns;
			}
		}

		// Token: 0x17000964 RID: 2404
		// (get) Token: 0x0600215D RID: 8541 RVA: 0x00094C2C File Offset: 0x00092E2C
		private global::Infragistics.Windows.DataPresenter.RecordListControl RecordListControl
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

		// Token: 0x17000965 RID: 2405
		// (get) Token: 0x0600215E RID: 8542 RVA: 0x00094C4D File Offset: 0x00092E4D
		private global::System.Windows.Controls.Orientation ScrollBarOrientation
		{
			get
			{
				if (this.ViewSettings.Orientation != global::System.Windows.Controls.Orientation.Horizontal)
				{
					return global::System.Windows.Controls.Orientation.Horizontal;
				}
				return global::System.Windows.Controls.Orientation.Vertical;
			}
		}

		// Token: 0x17000966 RID: 2406
		// (get) Token: 0x0600215F RID: 8543 RVA: 0x00094C5F File Offset: 0x00092E5F
		private global::Infragistics.Windows.DataPresenter.IViewPanelInfo ViewPanelInfo
		{
			get
			{
				return this._dataPresenterViewPanelInfo;
			}
		}

		// Token: 0x17000967 RID: 2407
		// (get) Token: 0x06002160 RID: 8544 RVA: 0x00094C67 File Offset: 0x00092E67
		// (set) Token: 0x06002161 RID: 8545 RVA: 0x00094C6F File Offset: 0x00092E6F
		internal double UncollapsedCardWidth
		{
			get
			{
				return this._uncollapsedCardWidth;
			}
			set
			{
				this._uncollapsedCardWidth = value;
			}
		}

		// Token: 0x06002162 RID: 8546 RVA: 0x00094C78 File Offset: 0x00092E78
		internal void SetScrollPosition(int scrollPosition)
		{
			base.ScrollPosition = scrollPosition;
		}

		// Token: 0x06002163 RID: 8547 RVA: 0x00094C81 File Offset: 0x00092E81
		internal void SetupSpecialRecordsVersionTracker(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout)
		{
			if (fieldLayout != this._specialRecordsVersionTrackerFieldLayout)
			{
				this._specialRecordsVersionTrackerFieldLayout = fieldLayout;
				this._specialRecordsVersionTracker = new global::Infragistics.Windows.Internal.PropertyValueTracker(fieldLayout, "SpecialRecordsVersion", new global::Infragistics.Windows.Internal.PropertyValueTracker.PropertyValueChangedHandler(this.OnSpecialRecordsVersionChanged), true);
			}
		}

		// Token: 0x06002164 RID: 8548 RVA: 0x00094CB4 File Offset: 0x00092EB4
		private global::Infragistics.Windows.DataPresenter.Record EnsureNotCollapsed(global::Infragistics.Windows.DataPresenter.Record record)
		{
			if (record == null)
			{
				return null;
			}
			if (record.IsContainingCardCollapsed == true)
			{
				record.ToggleContainingCardCollapsedState(true);
			}
			return record;
		}

		// Token: 0x06002165 RID: 8549 RVA: 0x00094CEC File Offset: 0x00092EEC
		private int GetLayoutColumn(global::Infragistics.Windows.Tiles.ItemInfoBase itemInfo)
		{
			int num = 0;
			foreach (global::System.Collections.Generic.List<global::Infragistics.Windows.Tiles.ItemInfoBase> list in this.LayoutColumns)
			{
				if (list.Contains(itemInfo))
				{
					return num;
				}
				num++;
			}
			return -1;
		}

		// Token: 0x06002166 RID: 8550 RVA: 0x00094D50 File Offset: 0x00092F50
		private global::Infragistics.Windows.DataPresenter.Record GetNavigationTargetRecord(global::Infragistics.Windows.DataPresenter.PanelNavigationDirection navigationDirection, global::Infragistics.Windows.DataPresenter.Record currentRecord, global::Infragistics.Windows.DataPresenter.PanelSiblingNavigationStyle siblingNavigationStyle, global::System.Type restrictToRecordType)
		{
			global::Infragistics.Windows.DataPresenter.IViewPanelInfo viewPanelInfo = this.ViewPanelInfo;
			if (viewPanelInfo == null)
			{
				return null;
			}
			global::Infragistics.Windows.DataPresenter.CardViewSettings viewSettings = this.ViewSettings;
			bool flag = viewSettings.Orientation == global::System.Windows.Controls.Orientation.Vertical;
			global::System.Windows.Controls.Orientation orientation = viewSettings.Orientation;
			if (!flag)
			{
				bool flag2 = false;
				bool flag3 = false;
				bool flag4 = false;
				bool flag5 = false;
				switch (navigationDirection)
				{
				case global::Infragistics.Windows.DataPresenter.PanelNavigationDirection.Left:
					if (flag)
					{
						flag4 = true;
					}
					else
					{
						flag2 = true;
					}
					break;
				case global::Infragistics.Windows.DataPresenter.PanelNavigationDirection.Right:
					if (flag)
					{
						flag5 = true;
					}
					else
					{
						flag3 = true;
					}
					break;
				case global::Infragistics.Windows.DataPresenter.PanelNavigationDirection.Above:
					if (flag)
					{
						flag2 = true;
					}
					else
					{
						flag4 = true;
					}
					break;
				case global::Infragistics.Windows.DataPresenter.PanelNavigationDirection.Below:
					if (flag)
					{
						flag3 = true;
					}
					else
					{
						flag5 = true;
					}
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
				int num = flag ? base.GetTotalRowsDisplayed() : base.GetTotalColumnsDisplayed();
				while (record2 == null)
				{
					int overallScrollPositionForRecord = viewPanelInfo.GetOverallScrollPositionForRecord(record);
					if (overallScrollPositionForRecord == -1)
					{
						return null;
					}
					int num2 = -1;
					if (flag2)
					{
						num2 = overallScrollPositionForRecord - 1;
					}
					else if (flag3)
					{
						num2 = overallScrollPositionForRecord + 1;
					}
					else if (flag4)
					{
						num2 = overallScrollPositionForRecord - num;
					}
					else if (flag5)
					{
						num2 = overallScrollPositionForRecord + num;
					}
					if (num2 == -1 || num2 < 0 || num2 > viewPanelInfo.OverallScrollCount - 1)
					{
						return null;
					}
					record2 = viewPanelInfo.GetRecordAtOverallScrollPosition(num2);
					if (record2 == null || record2.GetType() == restrictToRecordType || record2.GetType().IsSubclassOf(restrictToRecordType))
					{
						return this.EnsureNotCollapsed(record2);
					}
					record = record2;
					record2 = null;
				}
				return null;
			}
			global::Infragistics.Windows.Tiles.ItemInfoBase itemInfo = base.GetManager().GetItemInfo(currentRecord);
			global::System.Windows.Rect currentTargetRect = itemInfo.GetCurrentTargetRect();
			int layoutColumn = this.GetLayoutColumn(itemInfo);
			int overallScrollPositionForRecord2 = viewPanelInfo.GetOverallScrollPositionForRecord(currentRecord);
			int totalColumnsDisplayed = base.GetTotalColumnsDisplayed();
			switch (navigationDirection)
			{
			case global::Infragistics.Windows.DataPresenter.PanelNavigationDirection.Left:
			case global::Infragistics.Windows.DataPresenter.PanelNavigationDirection.Right:
			{
				int num3 = (navigationDirection == global::Infragistics.Windows.DataPresenter.PanelNavigationDirection.Left) ? (layoutColumn - 1) : (layoutColumn + 1);
				if (num3 < 0 || num3 > totalColumnsDisplayed - 1)
				{
					double offsetFromScrollPosition = base.GetOffsetFromScrollPosition(viewPanelInfo.OverallScrollPosition);
					if (num3 < 0)
					{
						viewPanelInfo.OverallScrollPosition = global::System.Math.Max(viewPanelInfo.OverallScrollPosition - 1, 0);
						base.InvalidateMeasure();
						base.UpdateLayout();
						totalColumnsDisplayed = base.GetTotalColumnsDisplayed();
						num3 = 0;
					}
					else if (num3 > totalColumnsDisplayed - 1)
					{
						viewPanelInfo.OverallScrollPosition = global::System.Math.Min(viewPanelInfo.OverallScrollPosition + this.LayoutColumns[0].Count, viewPanelInfo.OverallScrollCount);
						base.InvalidateMeasure();
						base.UpdateLayout();
						totalColumnsDisplayed = base.GetTotalColumnsDisplayed();
						num3 = totalColumnsDisplayed - 1;
					}
					if (offsetFromScrollPosition == base.GetOffsetFromScrollPosition(viewPanelInfo.OverallScrollPosition))
					{
						return null;
					}
				}
				for (int i = 0; i < this.LayoutColumns[num3].Count; i++)
				{
					global::Infragistics.Windows.Tiles.ItemInfoBase itemInfoBase = this.LayoutColumns[num3][i];
					double num4 = currentTargetRect.Top + (currentTargetRect.Bottom - currentTargetRect.Top) / 2.0;
					if (itemInfoBase.GetCurrentTargetRect().Top >= currentTargetRect.Top && itemInfoBase.GetCurrentTargetRect().Top <= num4)
					{
						return this.EnsureNotCollapsed(itemInfoBase.Item as global::Infragistics.Windows.DataPresenter.Record);
					}
					if (itemInfoBase.GetCurrentTargetRect().Bottom <= currentTargetRect.Bottom && itemInfoBase.GetCurrentTargetRect().Bottom >= num4)
					{
						return this.EnsureNotCollapsed(itemInfoBase.Item as global::Infragistics.Windows.DataPresenter.Record);
					}
				}
				return this.EnsureNotCollapsed(this.LayoutColumns[num3][this.LayoutColumns[num3].Count - 1].Item as global::Infragistics.Windows.DataPresenter.Record);
			}
			case global::Infragistics.Windows.DataPresenter.PanelNavigationDirection.Above:
			case global::Infragistics.Windows.DataPresenter.PanelNavigationDirection.Previous:
				return this.EnsureNotCollapsed(viewPanelInfo.GetRecordAtOverallScrollPosition(global::System.Math.Max(overallScrollPositionForRecord2 - 1, 0)));
			case global::Infragistics.Windows.DataPresenter.PanelNavigationDirection.Below:
			case global::Infragistics.Windows.DataPresenter.PanelNavigationDirection.Next:
				return this.EnsureNotCollapsed(viewPanelInfo.GetRecordAtOverallScrollPosition(global::System.Math.Min(overallScrollPositionForRecord2 + 1, viewPanelInfo.OverallScrollCount)));
			default:
				return null;
			}
		}

		// Token: 0x06002167 RID: 8551 RVA: 0x00095114 File Offset: 0x00093314
		private void InitializeScrollTip(global::Infragistics.Windows.DataPresenter.Record topRecord)
		{
			if (this._recordScrollTip != null)
			{
				global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.RecordScrollTipInfo> list = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.RecordScrollTipInfo>();
				list.Add(global::Infragistics.Windows.DataPresenter.RecordScrollTipInfo.Create(topRecord));
				this._recordScrollTip.DataContext = list;
				this._recordScrollTip.Content = this._recordScrollTip.DataContext;
				this._recordScrollTip.IsOpen = true;
			}
		}

		// Token: 0x06002168 RID: 8552 RVA: 0x0009516C File Offset: 0x0009336C
		private void InvalidateMeasureHelper()
		{
			base.InvalidateMeasure();
			global::System.Windows.UIElement uielement = base.Parent as global::System.Windows.UIElement;
			if (uielement != null)
			{
				uielement.InvalidateMeasure();
			}
		}

		// Token: 0x06002169 RID: 8553 RVA: 0x00095194 File Offset: 0x00093394
		private void OnSpecialRecordsVersionChanged()
		{
			base.InvalidateMeasure();
		}

		// Token: 0x0600216A RID: 8554 RVA: 0x0009519C File Offset: 0x0009339C
		private void OnViewSettingsPropertyChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			if (this._dataPresenter == null)
			{
				return;
			}
			string propertyName;
			switch (propertyName = e.PropertyName)
			{
			case "AutoFitCards":
			case "CardHeight":
			case "CardWidth":
			case "CollapseCardButtonVisibility":
			case "CollapseEmptyCellsButtonVisibility":
			case "HeaderPath":
			case "HeaderVisibility":
			case "InterCardSpacingX":
			case "InterCardSpacingY":
			case "MaxCardCols":
			case "MaxCardRows":
			case "Orientation":
			case "Padding":
			case "ShouldCollapseCards":
			case "ShouldCollapseEmptyCells":
				this.InvalidateMeasureHelper();
				break;

				return;
			}
		}

		// Token: 0x0600216B RID: 8555 RVA: 0x000952F0 File Offset: 0x000934F0
		bool global::Infragistics.Windows.DataPresenter.IViewPanel.EnsureCellIsVisible(global::Infragistics.Windows.DataPresenter.Cell cell)
		{
			if (cell == null)
			{
				return false;
			}
			global::Infragistics.Windows.DataPresenter.DataRecord record = cell.Record;
			if (record == null)
			{
				return false;
			}
			global::Infragistics.Windows.DataPresenter.DataRecordPresenter dataRecordPresenter = record.AssociatedRecordPresenter as global::Infragistics.Windows.DataPresenter.DataRecordPresenter;
			if (dataRecordPresenter == null)
			{
				((global::Infragistics.Windows.DataPresenter.IViewPanel)this).EnsureRecordIsVisible(cell.Record);
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
					cellValuePresenter.BringIntoView();
					return true;
				}
			}
			return false;
		}

		// Token: 0x0600216C RID: 8556 RVA: 0x00095388 File Offset: 0x00093588
		bool global::Infragistics.Windows.DataPresenter.IViewPanel.EnsureRecordIsVisible(global::Infragistics.Windows.DataPresenter.Record record)
		{
			if (record == null)
			{
				throw new global::System.ArgumentNullException("record");
			}
			if (this.DataPresenter == null)
			{
				return false;
			}
			global::Infragistics.Windows.DataPresenter.IViewPanelInfo viewPanelInfo = this.ViewPanelInfo;
			if (!viewPanelInfo.IsOkToScroll())
			{
				return false;
			}
			int overallScrollPositionForRecord = viewPanelInfo.GetOverallScrollPositionForRecord(record);
			if (overallScrollPositionForRecord < 0)
			{
				return true;
			}
			int scrollIndexOfFirstArrangedItem = base.ScrollIndexOfFirstArrangedItem;
			int scrollIndexOfLastArrangedItem = base.ScrollIndexOfLastArrangedItem;
			if (overallScrollPositionForRecord >= scrollIndexOfFirstArrangedItem && overallScrollPositionForRecord <= scrollIndexOfLastArrangedItem)
			{
				return true;
			}
			if (overallScrollPositionForRecord < scrollIndexOfFirstArrangedItem)
			{
				base.ScrollPosition = overallScrollPositionForRecord;
				return true;
			}
			int num = overallScrollPositionForRecord - scrollIndexOfLastArrangedItem;
			int num2 = base.ScrollPosition + num;
			if (num2 != 0)
			{
				double offsetFromScrollPosition = base.GetOffsetFromScrollPosition(num2);
				double offsetFromScrollPosition2 = base.GetOffsetFromScrollPosition(num2 - 1);
				if (offsetFromScrollPosition == offsetFromScrollPosition2)
				{
					int num3 = num2 + 1;
					while (base.GetOffsetFromScrollPosition(num3) == offsetFromScrollPosition)
					{
						num3++;
						if (num3 >= viewPanelInfo.OverallScrollCount)
						{
							break;
						}
					}
					num2 = num3;
				}
			}
			base.ScrollPosition = num2;
			return true;
		}

		// Token: 0x0600216D RID: 8557 RVA: 0x00095450 File Offset: 0x00093650
		global::Infragistics.Windows.DataPresenter.Record global::Infragistics.Windows.DataPresenter.IViewPanel.GetFirstDisplayedRecord(global::System.Type recordType)
		{
			global::Infragistics.Windows.DataPresenter.IViewPanelInfo viewPanelInfo = this.ViewPanelInfo;
			if (viewPanelInfo == null)
			{
				return null;
			}
			if (viewPanelInfo.OverallScrollCount < 1)
			{
				return null;
			}
			global::Infragistics.Windows.DataPresenter.Record recordAtOverallScrollPosition = viewPanelInfo.GetRecordAtOverallScrollPosition(viewPanelInfo.OverallScrollPosition);
			if (recordAtOverallScrollPosition != null && (recordAtOverallScrollPosition.GetType() == recordType || recordAtOverallScrollPosition.GetType().IsSubclassOf(recordType)))
			{
				return recordAtOverallScrollPosition;
			}
			int num = viewPanelInfo.OverallScrollPosition + 1;
			int scrollIndexOfLastArrangedItem = base.ScrollIndexOfLastArrangedItem;
			for (int i = num; i <= scrollIndexOfLastArrangedItem; i++)
			{
				global::Infragistics.Windows.DataPresenter.Record recordAtOverallScrollPosition2 = viewPanelInfo.GetRecordAtOverallScrollPosition(i);
				if (recordAtOverallScrollPosition2 != null && (recordAtOverallScrollPosition2.GetType() == recordType || recordAtOverallScrollPosition2.GetType().IsSubclassOf(recordType)))
				{
					return recordAtOverallScrollPosition2;
				}
			}
			return null;
		}

		// Token: 0x0600216E RID: 8558 RVA: 0x000954F4 File Offset: 0x000936F4
		global::Infragistics.Windows.DataPresenter.Record global::Infragistics.Windows.DataPresenter.IViewPanel.GetFirstOverallRecord(global::System.Type recordType)
		{
			global::Infragistics.Windows.DataPresenter.IViewPanelInfo viewPanelInfo = this.ViewPanelInfo;
			if (viewPanelInfo == null)
			{
				return null;
			}
			int overallScrollCount = viewPanelInfo.OverallScrollCount;
			for (int i = 0; i < overallScrollCount; i++)
			{
				global::Infragistics.Windows.DataPresenter.Record recordAtOverallScrollPosition = viewPanelInfo.GetRecordAtOverallScrollPosition(i);
				if (recordAtOverallScrollPosition != null && (recordAtOverallScrollPosition.GetType() == recordType || recordAtOverallScrollPosition.GetType().IsSubclassOf(recordType)))
				{
					return recordAtOverallScrollPosition;
				}
			}
			return null;
		}

		// Token: 0x0600216F RID: 8559 RVA: 0x0009554C File Offset: 0x0009374C
		global::Infragistics.Windows.DataPresenter.Record global::Infragistics.Windows.DataPresenter.IViewPanel.GetLastDisplayedRecord(global::System.Type recordType)
		{
			global::Infragistics.Windows.DataPresenter.IViewPanelInfo viewPanelInfo = this.ViewPanelInfo;
			if (viewPanelInfo == null)
			{
				return null;
			}
			int scrollIndexOfLastArrangedItem = base.ScrollIndexOfLastArrangedItem;
			if (scrollIndexOfLastArrangedItem < 0)
			{
				return null;
			}
			global::Infragistics.Windows.DataPresenter.Record recordAtOverallScrollPosition = viewPanelInfo.GetRecordAtOverallScrollPosition(scrollIndexOfLastArrangedItem);
			if (recordAtOverallScrollPosition != null && (recordAtOverallScrollPosition.GetType() == recordType || recordAtOverallScrollPosition.GetType().IsSubclassOf(recordType)))
			{
				return recordAtOverallScrollPosition;
			}
			int num = scrollIndexOfLastArrangedItem - 1;
			for (int i = num; i > -1; i--)
			{
				global::Infragistics.Windows.DataPresenter.Record recordAtOverallScrollPosition2 = viewPanelInfo.GetRecordAtOverallScrollPosition(i);
				if (recordAtOverallScrollPosition2 != null && (recordAtOverallScrollPosition2.GetType() == recordType || recordAtOverallScrollPosition2.GetType().IsSubclassOf(recordType)))
				{
					return recordAtOverallScrollPosition2;
				}
			}
			return null;
		}

		// Token: 0x06002170 RID: 8560 RVA: 0x000955E0 File Offset: 0x000937E0
		global::Infragistics.Windows.DataPresenter.Record global::Infragistics.Windows.DataPresenter.IViewPanel.GetLastOverallRecord(global::System.Type recordType)
		{
			global::Infragistics.Windows.DataPresenter.IViewPanelInfo viewPanelInfo = this.ViewPanelInfo;
			if (viewPanelInfo == null)
			{
				return null;
			}
			int overallScrollCount = viewPanelInfo.OverallScrollCount;
			for (int i = overallScrollCount - 1; i >= 0; i--)
			{
				global::Infragistics.Windows.DataPresenter.Record recordAtOverallScrollPosition = viewPanelInfo.GetRecordAtOverallScrollPosition(i);
				if (recordAtOverallScrollPosition != null && (recordAtOverallScrollPosition.GetType() == recordType || recordAtOverallScrollPosition.GetType().IsSubclassOf(recordType)))
				{
					return recordAtOverallScrollPosition;
				}
			}
			return null;
		}

		// Token: 0x06002171 RID: 8561 RVA: 0x00095638 File Offset: 0x00093838
		global::Infragistics.Windows.DataPresenter.Record global::Infragistics.Windows.DataPresenter.IViewPanel.GetNavigationTargetRecord(global::Infragistics.Windows.DataPresenter.Record currentRecord, global::Infragistics.Windows.DataPresenter.PanelNavigationDirection navigationDirection, global::Infragistics.Windows.Selection.ISelectionHost selectionHost, bool shiftKeyDown, bool ctlKeyDown, global::Infragistics.Windows.DataPresenter.PanelSiblingNavigationStyle siblingNavigationStyle, global::System.Type restrictToRecordType)
		{
			if (this.ViewPanelInfo == null)
			{
				return null;
			}
			if (currentRecord == null)
			{
				throw new global::System.ArgumentNullException("currentRecord");
			}
			if (selectionHost == null)
			{
				throw new global::System.ArgumentNullException("selectionHost");
			}
			global::Infragistics.Windows.Selection.SelectionStrategyBase selectionStrategyForItem = selectionHost.GetSelectionStrategyForItem(currentRecord);
			if (selectionStrategyForItem == null)
			{
				throw new global::System.InvalidOperationException("SelectionStrategy is null!");
			}
			global::Infragistics.Windows.DataPresenter.Record navigationTargetRecord = this.GetNavigationTargetRecord(navigationDirection, currentRecord, siblingNavigationStyle, restrictToRecordType);
			if (navigationTargetRecord == null)
			{
				return null;
			}
			if (selectionStrategyForItem.CanItemBeNavigatedTo(navigationTargetRecord, shiftKeyDown, ctlKeyDown))
			{
				return navigationTargetRecord;
			}
			return null;
		}

		// Token: 0x17000968 RID: 2408
		// (get) Token: 0x06002172 RID: 8562 RVA: 0x000956A5 File Offset: 0x000938A5
		global::Infragistics.Windows.DataPresenter.PanelLayoutStyle global::Infragistics.Windows.DataPresenter.IViewPanel.LayoutStyle
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.PanelLayoutStyle.Custom;
			}
		}

		// Token: 0x06002173 RID: 8563 RVA: 0x000956A8 File Offset: 0x000938A8
		void global::Infragistics.Windows.DataPresenter.IViewPanel.OnActiveRecordChanged(global::Infragistics.Windows.DataPresenter.Record record)
		{
		}

		// Token: 0x06002174 RID: 8564 RVA: 0x000956AA File Offset: 0x000938AA
		void global::Infragistics.Windows.DataPresenter.IViewPanel.OnSelectedItemsChanged()
		{
		}

		// Token: 0x06002175 RID: 8565 RVA: 0x000956AC File Offset: 0x000938AC
		void global::Infragistics.Windows.DataPresenter.IViewPanel.Scroll(global::Infragistics.Windows.DataPresenter.PanelNavigationScrollType scrollType)
		{
			bool flag = false;
			if (this.ViewSettings.ShouldAnimateCardPositioning)
			{
				this.ViewSettings.ShouldAnimateCardPositioning = false;
				flag = true;
			}
			switch (scrollType)
			{
			case global::Infragistics.Windows.DataPresenter.PanelNavigationScrollType.PageAbove:
				if (this.ScrollBarOrientation == global::System.Windows.Controls.Orientation.Vertical)
				{
					((global::System.Windows.Controls.Primitives.IScrollInfo)this).PageUp();
				}
				break;
			case global::Infragistics.Windows.DataPresenter.PanelNavigationScrollType.PageBelow:
				if (this.ScrollBarOrientation == global::System.Windows.Controls.Orientation.Vertical)
				{
					((global::System.Windows.Controls.Primitives.IScrollInfo)this).PageDown();
				}
				break;
			case global::Infragistics.Windows.DataPresenter.PanelNavigationScrollType.PageLeft:
				if (this.ScrollBarOrientation == global::System.Windows.Controls.Orientation.Horizontal)
				{
					((global::System.Windows.Controls.Primitives.IScrollInfo)this).PageLeft();
				}
				break;
			case global::Infragistics.Windows.DataPresenter.PanelNavigationScrollType.PageRight:
				if (this.ScrollBarOrientation == global::System.Windows.Controls.Orientation.Horizontal)
				{
					((global::System.Windows.Controls.Primitives.IScrollInfo)this).PageRight();
				}
				break;
			}
			if (flag)
			{
				base.UpdateLayout();
				this.ViewSettings.ShouldAnimateCardPositioning = true;
			}
		}

		// Token: 0x06002176 RID: 8566 RVA: 0x00095748 File Offset: 0x00093948
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
			if (!(sender is global::Infragistics.Windows.DataPresenter.CardViewSettings))
			{
				return false;
			}
			if (sender == this._viewSettings)
			{
				this.OnViewSettingsPropertyChanged(sender, propertyChangedEventArgs);
				return true;
			}
			return true;
		}

		// Token: 0x04000E20 RID: 3616
		private global::Infragistics.Windows.DataPresenter.DataPresenterBase _dataPresenter;

		// Token: 0x04000E21 RID: 3617
		private global::Infragistics.Windows.DataPresenter.IViewPanelInfo _dataPresenterViewPanelInfo;

		// Token: 0x04000E22 RID: 3618
		private global::Infragistics.Windows.DataPresenter.ViewBase _view;

		// Token: 0x04000E23 RID: 3619
		private global::Infragistics.Windows.DataPresenter.CardViewSettings _viewSettings;

		// Token: 0x04000E24 RID: 3620
		private bool _itemsPanelInitialized;

		// Token: 0x04000E25 RID: 3621
		private global::Infragistics.Windows.DataPresenter.RecordListControl _recordListControl;

		// Token: 0x04000E26 RID: 3622
		private global::Infragistics.Windows.DataPresenter.RecordScrollTip _recordScrollTip;

		// Token: 0x04000E27 RID: 3623
		private global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::Infragistics.Windows.Tiles.ItemInfoBase>> _layoutColumns;

		// Token: 0x04000E28 RID: 3624
		private double _uncollapsedCardWidth = double.NaN;

		// Token: 0x04000E29 RID: 3625
		private global::Infragistics.Windows.Internal.PropertyValueTracker _specialRecordsVersionTracker;

		// Token: 0x04000E2A RID: 3626
		private global::Infragistics.Windows.DataPresenter.FieldLayout _specialRecordsVersionTrackerFieldLayout;

		// Token: 0x04000E2B RID: 3627
		public static readonly global::System.Windows.DependencyProperty ViewSettingsProperty = global::Infragistics.Windows.DataPresenter.CardView.ViewSettingsProperty.AddOwner(typeof(global::Infragistics.Windows.DataPresenter.CardViewPanel), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DataPresenter.CardViewPanel.OnCoerceViewSettings)));

		// Token: 0x0200023C RID: 572
		private class ItemInfoComparer : global::System.Collections.Generic.IComparer<global::Infragistics.Windows.Tiles.ItemInfoBase>
		{
			// Token: 0x06002178 RID: 8568 RVA: 0x000957C0 File Offset: 0x000939C0
			internal ItemInfoComparer()
			{
			}

			// Token: 0x06002179 RID: 8569 RVA: 0x000957C8 File Offset: 0x000939C8
			public int Compare(global::Infragistics.Windows.Tiles.ItemInfoBase x, global::Infragistics.Windows.Tiles.ItemInfoBase y)
			{
				global::System.Windows.Rect currentTargetRect = x.GetCurrentTargetRect();
				global::System.Windows.Rect currentTargetRect2 = y.GetCurrentTargetRect();
				if (currentTargetRect.Left != currentTargetRect2.Left)
				{
					return (int)currentTargetRect.Left - (int)currentTargetRect2.Left;
				}
				return (int)currentTargetRect.Top - (int)currentTargetRect2.Top;
			}
		}

		// Token: 0x0200023D RID: 573
		private class TileConstraints : global::Infragistics.Windows.Tiles.ITileConstraints
		{
			// Token: 0x17000969 RID: 2409
			// (get) Token: 0x0600217A RID: 8570 RVA: 0x00095816 File Offset: 0x00093A16
			// (set) Token: 0x0600217B RID: 8571 RVA: 0x0009581E File Offset: 0x00093A1E
			internal global::System.Windows.HorizontalAlignment? HorizontalAlignment { get; set; }

			// Token: 0x1700096A RID: 2410
			// (get) Token: 0x0600217C RID: 8572 RVA: 0x00095827 File Offset: 0x00093A27
			// (set) Token: 0x0600217D RID: 8573 RVA: 0x0009582F File Offset: 0x00093A2F
			internal global::System.Windows.Thickness? Margin { get; set; }

			// Token: 0x1700096B RID: 2411
			// (get) Token: 0x0600217E RID: 8574 RVA: 0x00095838 File Offset: 0x00093A38
			// (set) Token: 0x0600217F RID: 8575 RVA: 0x00095840 File Offset: 0x00093A40
			internal double MaxHeight { get; set; }

			// Token: 0x1700096C RID: 2412
			// (get) Token: 0x06002180 RID: 8576 RVA: 0x00095849 File Offset: 0x00093A49
			// (set) Token: 0x06002181 RID: 8577 RVA: 0x00095851 File Offset: 0x00093A51
			internal double MaxWidth { get; set; }

			// Token: 0x1700096D RID: 2413
			// (get) Token: 0x06002182 RID: 8578 RVA: 0x0009585A File Offset: 0x00093A5A
			// (set) Token: 0x06002183 RID: 8579 RVA: 0x00095862 File Offset: 0x00093A62
			internal double MinHeight { get; set; }

			// Token: 0x1700096E RID: 2414
			// (get) Token: 0x06002184 RID: 8580 RVA: 0x0009586B File Offset: 0x00093A6B
			// (set) Token: 0x06002185 RID: 8581 RVA: 0x00095873 File Offset: 0x00093A73
			internal double MinWidth { get; set; }

			// Token: 0x1700096F RID: 2415
			// (get) Token: 0x06002186 RID: 8582 RVA: 0x0009587C File Offset: 0x00093A7C
			// (set) Token: 0x06002187 RID: 8583 RVA: 0x00095884 File Offset: 0x00093A84
			internal double PreferredHeight { get; set; }

			// Token: 0x17000970 RID: 2416
			// (get) Token: 0x06002188 RID: 8584 RVA: 0x0009588D File Offset: 0x00093A8D
			// (set) Token: 0x06002189 RID: 8585 RVA: 0x00095895 File Offset: 0x00093A95
			internal double PreferredWidth { get; set; }

			// Token: 0x17000971 RID: 2417
			// (get) Token: 0x0600218A RID: 8586 RVA: 0x0009589E File Offset: 0x00093A9E
			// (set) Token: 0x0600218B RID: 8587 RVA: 0x000958A6 File Offset: 0x00093AA6
			internal global::System.Windows.VerticalAlignment? VerticalAlignment { get; set; }

			// Token: 0x0600218C RID: 8588 RVA: 0x000958B0 File Offset: 0x00093AB0
			internal TileConstraints()
			{
				this.MaxHeight = double.PositiveInfinity;
				this.MaxWidth = double.PositiveInfinity;
				this.PreferredHeight = double.NaN;
				this.PreferredWidth = double.NaN;
			}

			// Token: 0x17000972 RID: 2418
			// (get) Token: 0x0600218D RID: 8589 RVA: 0x000958FF File Offset: 0x00093AFF
			global::System.Windows.HorizontalAlignment? global::Infragistics.Windows.Tiles.ITileConstraints.HorizontalAlignment
			{
				get
				{
					return this.HorizontalAlignment;
				}
			}

			// Token: 0x17000973 RID: 2419
			// (get) Token: 0x0600218E RID: 8590 RVA: 0x00095907 File Offset: 0x00093B07
			global::System.Windows.Thickness? global::Infragistics.Windows.Tiles.ITileConstraints.Margin
			{
				get
				{
					return this.Margin;
				}
			}

			// Token: 0x17000974 RID: 2420
			// (get) Token: 0x0600218F RID: 8591 RVA: 0x0009590F File Offset: 0x00093B0F
			double global::Infragistics.Windows.Tiles.ITileConstraints.MaxHeight
			{
				get
				{
					return this.MaxHeight;
				}
			}

			// Token: 0x17000975 RID: 2421
			// (get) Token: 0x06002190 RID: 8592 RVA: 0x00095917 File Offset: 0x00093B17
			double global::Infragistics.Windows.Tiles.ITileConstraints.MaxWidth
			{
				get
				{
					return this.MaxWidth;
				}
			}

			// Token: 0x17000976 RID: 2422
			// (get) Token: 0x06002191 RID: 8593 RVA: 0x0009591F File Offset: 0x00093B1F
			double global::Infragistics.Windows.Tiles.ITileConstraints.MinHeight
			{
				get
				{
					return this.MinHeight;
				}
			}

			// Token: 0x17000977 RID: 2423
			// (get) Token: 0x06002192 RID: 8594 RVA: 0x00095927 File Offset: 0x00093B27
			double global::Infragistics.Windows.Tiles.ITileConstraints.MinWidth
			{
				get
				{
					return this.MinWidth;
				}
			}

			// Token: 0x17000978 RID: 2424
			// (get) Token: 0x06002193 RID: 8595 RVA: 0x0009592F File Offset: 0x00093B2F
			double global::Infragistics.Windows.Tiles.ITileConstraints.PreferredHeight
			{
				get
				{
					return this.PreferredHeight;
				}
			}

			// Token: 0x17000979 RID: 2425
			// (get) Token: 0x06002194 RID: 8596 RVA: 0x00095937 File Offset: 0x00093B37
			double global::Infragistics.Windows.Tiles.ITileConstraints.PreferredWidth
			{
				get
				{
					return this.PreferredWidth;
				}
			}

			// Token: 0x1700097A RID: 2426
			// (get) Token: 0x06002195 RID: 8597 RVA: 0x0009593F File Offset: 0x00093B3F
			global::System.Windows.VerticalAlignment? global::Infragistics.Windows.Tiles.ITileConstraints.VerticalAlignment
			{
				get
				{
					return this.VerticalAlignment;
				}
			}
		}
	}
}
