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
	// Token: 0x02000207 RID: 519
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class CardViewPanel : global::Infragistics.Windows.Tiles.TilesPanelBase, global::Infragistics.Windows.DataPresenter.IViewPanel, global::System.Windows.IWeakEventListener
	{
		// Token: 0x06001CC0 RID: 7360 RVA: 0x0007DF70 File Offset: 0x0007C170
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

		// Token: 0x06001CC1 RID: 7361 RVA: 0x0007E044 File Offset: 0x0007C244
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

		// Token: 0x06001CC2 RID: 7362 RVA: 0x0007E072 File Offset: 0x0007C272
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

		// Token: 0x06001CC3 RID: 7363 RVA: 0x0007E0A0 File Offset: 0x0007C2A0
		protected internal override bool GetIsInDeferredScrollingMode()
		{
			return this.DataPresenter != null && (this.DataPresenter.ScrollingMode == global::Infragistics.Windows.DataPresenter.ScrollingMode.DeferredWithScrollTips || this.DataPresenter.ScrollingMode == global::Infragistics.Windows.DataPresenter.ScrollingMode.Deferred);
		}

		// Token: 0x06001CC4 RID: 7364 RVA: 0x0007E0C9 File Offset: 0x0007C2C9
		protected internal override int GetMaxColumns()
		{
			if (this.ViewSettings == null)
			{
				return 0;
			}
			return this.ViewSettings.MaxCardCols;
		}

		// Token: 0x06001CC5 RID: 7365 RVA: 0x0007E0E0 File Offset: 0x0007C2E0
		protected internal override int GetMaxRows()
		{
			if (this.ViewSettings == null)
			{
				return 0;
			}
			return this.ViewSettings.MaxCardRows;
		}

		// Token: 0x06001CC6 RID: 7366 RVA: 0x0007E0F7 File Offset: 0x0007C2F7
		protected internal override int GetMinColumns()
		{
			return 1;
		}

		// Token: 0x06001CC7 RID: 7367 RVA: 0x0007E0FA File Offset: 0x0007C2FA
		protected internal override int GetMinRows()
		{
			return 1;
		}

		// Token: 0x06001CC8 RID: 7368 RVA: 0x0007E0FD File Offset: 0x0007C2FD
		protected override global::System.Windows.Media.Animation.DoubleAnimationBase GetRepositionAnimation()
		{
			if (this.ViewSettings == null)
			{
				return null;
			}
			return this.ViewSettings.RepositionAnimation;
		}

		// Token: 0x06001CC9 RID: 7369 RVA: 0x0007E114 File Offset: 0x0007C314
		protected internal override bool GetShouldAnimate()
		{
			return this.ViewSettings == null || this.ViewSettings.ShouldAnimateCardPositioning;
		}

		// Token: 0x06001CCA RID: 7370 RVA: 0x0007E12B File Offset: 0x0007C32B
		protected internal override bool GetSupportsDeferredScrolling(global::System.Windows.Controls.Orientation scrollBarOrientation, global::System.Windows.Controls.ScrollViewer scrollViewer)
		{
			return scrollViewer != null && scrollViewer.TemplatedParent == this.RecordListControl && scrollBarOrientation == this.ScrollBarOrientation;
		}

		// Token: 0x06001CCB RID: 7371 RVA: 0x0007E14C File Offset: 0x0007C34C
		protected internal override global::System.Windows.Thickness GetTileAreaPadding()
		{
			if (this.ViewSettings == null)
			{
				return default(global::System.Windows.Thickness);
			}
			return this.ViewSettings.Padding;
		}

		// Token: 0x06001CCC RID: 7372 RVA: 0x0007E176 File Offset: 0x0007C376
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

		// Token: 0x06001CCD RID: 7373 RVA: 0x0007E194 File Offset: 0x0007C394
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

		// Token: 0x170007B9 RID: 1977
		// (get) Token: 0x06001CCE RID: 7374 RVA: 0x0007E1C2 File Offset: 0x0007C3C2
		protected override bool IsOkToCleanupUnusedGeneratedElements
		{
			get
			{
				return !base.IsAnimationInProgress;
			}
		}

		// Token: 0x06001CCF RID: 7375 RVA: 0x0007E1D0 File Offset: 0x0007C3D0
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

		// Token: 0x06001CD0 RID: 7376 RVA: 0x0007E208 File Offset: 0x0007C408
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

		// Token: 0x06001CD1 RID: 7377 RVA: 0x0007E268 File Offset: 0x0007C468
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

		// Token: 0x06001CD2 RID: 7378 RVA: 0x0007E34C File Offset: 0x0007C54C
		protected internal override void OnDeferredScrollingEnded(bool cancelled)
		{
			if (this._recordScrollTip != null)
			{
				this._recordScrollTip.IsOpen = false;
				this._recordScrollTip = null;
			}
		}

		// Token: 0x06001CD3 RID: 7379 RVA: 0x0007E369 File Offset: 0x0007C569
		protected internal override void OnDeferredScrollOffsetChanged(double newDeferredScrollPosition)
		{
			if (this.ViewPanelInfo != null && this.RecordListControl != null && this.RecordListControl.HasItems)
			{
				this.InitializeScrollTip(this.ViewPanelInfo.GetRecordAtOverallScrollPosition(base.GetScrollPositionFromOffset(newDeferredScrollPosition)));
			}
		}

		// Token: 0x06001CD4 RID: 7380 RVA: 0x0007E3A0 File Offset: 0x0007C5A0
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

		// Token: 0x06001CD5 RID: 7381 RVA: 0x0007E50C File Offset: 0x0007C70C
		protected override void OnItemsInViewChanged()
		{
			global::Infragistics.Windows.DataPresenter.IViewPanelInfo viewPanelInfo = this.ViewPanelInfo;
			if (viewPanelInfo != null)
			{
				viewPanelInfo.OnRecordsInViewChanged();
			}
		}

		// Token: 0x06001CD6 RID: 7382 RVA: 0x0007E52C File Offset: 0x0007C72C
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

		// Token: 0x06001CD7 RID: 7383 RVA: 0x0007E563 File Offset: 0x0007C763
		private static object OnCoerceViewSettings(global::System.Windows.DependencyObject d, object value)
		{
			if (value == null)
			{
				return new global::Infragistics.Windows.DataPresenter.CardViewSettings();
			}
			return value;
		}

		// Token: 0x170007BA RID: 1978
		// (get) Token: 0x06001CD8 RID: 7384 RVA: 0x0007E56F File Offset: 0x0007C76F
		// (set) Token: 0x06001CD9 RID: 7385 RVA: 0x0007E581 File Offset: 0x0007C781
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

		// Token: 0x06001CDA RID: 7386 RVA: 0x0007E58F File Offset: 0x0007C78F
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeViewSettings()
		{
			return this.ViewSettings != (global::Infragistics.Windows.DataPresenter.CardViewSettings)global::Infragistics.Windows.DataPresenter.CardViewPanel.ViewSettingsProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x06001CDB RID: 7387 RVA: 0x0007E5B0 File Offset: 0x0007C7B0
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetViewSettings()
		{
			this.ViewSettings = (global::Infragistics.Windows.DataPresenter.CardViewSettings)global::Infragistics.Windows.DataPresenter.CardViewPanel.ViewSettingsProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x170007BB RID: 1979
		// (get) Token: 0x06001CDC RID: 7388 RVA: 0x0007E5CC File Offset: 0x0007C7CC
		private global::Infragistics.Windows.DataPresenter.DataPresenterBase DataPresenter
		{
			get
			{
				return this._dataPresenter;
			}
		}

		// Token: 0x170007BC RID: 1980
		// (get) Token: 0x06001CDD RID: 7389 RVA: 0x0007E5D4 File Offset: 0x0007C7D4
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

		// Token: 0x170007BD RID: 1981
		// (get) Token: 0x06001CDE RID: 7390 RVA: 0x0007E6A0 File Offset: 0x0007C8A0
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

		// Token: 0x170007BE RID: 1982
		// (get) Token: 0x06001CDF RID: 7391 RVA: 0x0007E6C1 File Offset: 0x0007C8C1
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

		// Token: 0x170007BF RID: 1983
		// (get) Token: 0x06001CE0 RID: 7392 RVA: 0x0007E6D3 File Offset: 0x0007C8D3
		private global::Infragistics.Windows.DataPresenter.IViewPanelInfo ViewPanelInfo
		{
			get
			{
				return this._dataPresenterViewPanelInfo;
			}
		}

		// Token: 0x170007C0 RID: 1984
		// (get) Token: 0x06001CE1 RID: 7393 RVA: 0x0007E6DB File Offset: 0x0007C8DB
		// (set) Token: 0x06001CE2 RID: 7394 RVA: 0x0007E6E3 File Offset: 0x0007C8E3
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

		// Token: 0x06001CE3 RID: 7395 RVA: 0x0007E6EC File Offset: 0x0007C8EC
		internal void SetScrollPosition(int scrollPosition)
		{
			base.ScrollPosition = scrollPosition;
		}

		// Token: 0x06001CE4 RID: 7396 RVA: 0x0007E6F5 File Offset: 0x0007C8F5
		internal void SetupSpecialRecordsVersionTracker(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout)
		{
			if (fieldLayout != this._specialRecordsVersionTrackerFieldLayout)
			{
				this._specialRecordsVersionTrackerFieldLayout = fieldLayout;
				this._specialRecordsVersionTracker = new global::Infragistics.Windows.Internal.PropertyValueTracker(fieldLayout, "SpecialRecordsVersion", new global::Infragistics.Windows.Internal.PropertyValueTracker.PropertyValueChangedHandler(this.OnSpecialRecordsVersionChanged), true);
			}
		}

		// Token: 0x06001CE5 RID: 7397 RVA: 0x0007E728 File Offset: 0x0007C928
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

		// Token: 0x06001CE6 RID: 7398 RVA: 0x0007E760 File Offset: 0x0007C960
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

		// Token: 0x06001CE7 RID: 7399 RVA: 0x0007E7C4 File Offset: 0x0007C9C4
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

		// Token: 0x06001CE8 RID: 7400 RVA: 0x0007EB88 File Offset: 0x0007CD88
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

		// Token: 0x06001CE9 RID: 7401 RVA: 0x0007EBE0 File Offset: 0x0007CDE0
		private void InvalidateMeasureHelper()
		{
			base.InvalidateMeasure();
			global::System.Windows.UIElement uielement = base.Parent as global::System.Windows.UIElement;
			if (uielement != null)
			{
				uielement.InvalidateMeasure();
			}
		}

		// Token: 0x06001CEA RID: 7402 RVA: 0x0007EC08 File Offset: 0x0007CE08
		private void OnSpecialRecordsVersionChanged()
		{
			base.InvalidateMeasure();
		}

		// Token: 0x06001CEB RID: 7403 RVA: 0x0007EC10 File Offset: 0x0007CE10
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

		// Token: 0x06001CEC RID: 7404 RVA: 0x0007ED64 File Offset: 0x0007CF64
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

		// Token: 0x06001CED RID: 7405 RVA: 0x0007EDFC File Offset: 0x0007CFFC
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

		// Token: 0x06001CEE RID: 7406 RVA: 0x0007EEC4 File Offset: 0x0007D0C4
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

		// Token: 0x06001CEF RID: 7407 RVA: 0x0007EF68 File Offset: 0x0007D168
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

		// Token: 0x06001CF0 RID: 7408 RVA: 0x0007EFC0 File Offset: 0x0007D1C0
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

		// Token: 0x06001CF1 RID: 7409 RVA: 0x0007F054 File Offset: 0x0007D254
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

		// Token: 0x06001CF2 RID: 7410 RVA: 0x0007F0AC File Offset: 0x0007D2AC
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

		// Token: 0x170007C1 RID: 1985
		// (get) Token: 0x06001CF3 RID: 7411 RVA: 0x0007F119 File Offset: 0x0007D319
		global::Infragistics.Windows.DataPresenter.PanelLayoutStyle global::Infragistics.Windows.DataPresenter.IViewPanel.LayoutStyle
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.PanelLayoutStyle.Custom;
			}
		}

		// Token: 0x06001CF4 RID: 7412 RVA: 0x0007F11C File Offset: 0x0007D31C
		void global::Infragistics.Windows.DataPresenter.IViewPanel.OnActiveRecordChanged(global::Infragistics.Windows.DataPresenter.Record record)
		{
		}

		// Token: 0x06001CF5 RID: 7413 RVA: 0x0007F11E File Offset: 0x0007D31E
		void global::Infragistics.Windows.DataPresenter.IViewPanel.OnSelectedItemsChanged()
		{
		}

		// Token: 0x06001CF6 RID: 7414 RVA: 0x0007F120 File Offset: 0x0007D320
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

		// Token: 0x06001CF7 RID: 7415 RVA: 0x0007F1BC File Offset: 0x0007D3BC
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

		// Token: 0x04000C03 RID: 3075
		private global::Infragistics.Windows.DataPresenter.DataPresenterBase _dataPresenter;

		// Token: 0x04000C04 RID: 3076
		private global::Infragistics.Windows.DataPresenter.IViewPanelInfo _dataPresenterViewPanelInfo;

		// Token: 0x04000C05 RID: 3077
		private global::Infragistics.Windows.DataPresenter.ViewBase _view;

		// Token: 0x04000C06 RID: 3078
		private global::Infragistics.Windows.DataPresenter.CardViewSettings _viewSettings;

		// Token: 0x04000C07 RID: 3079
		private bool _itemsPanelInitialized;

		// Token: 0x04000C08 RID: 3080
		private global::Infragistics.Windows.DataPresenter.RecordListControl _recordListControl;

		// Token: 0x04000C09 RID: 3081
		private global::Infragistics.Windows.DataPresenter.RecordScrollTip _recordScrollTip;

		// Token: 0x04000C0A RID: 3082
		private global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::Infragistics.Windows.Tiles.ItemInfoBase>> _layoutColumns;

		// Token: 0x04000C0B RID: 3083
		private double _uncollapsedCardWidth = double.NaN;

		// Token: 0x04000C0C RID: 3084
		private global::Infragistics.Windows.Internal.PropertyValueTracker _specialRecordsVersionTracker;

		// Token: 0x04000C0D RID: 3085
		private global::Infragistics.Windows.DataPresenter.FieldLayout _specialRecordsVersionTrackerFieldLayout;

		// Token: 0x04000C0E RID: 3086
		public static readonly global::System.Windows.DependencyProperty ViewSettingsProperty = global::Infragistics.Windows.DataPresenter.CardView.ViewSettingsProperty.AddOwner(typeof(global::Infragistics.Windows.DataPresenter.CardViewPanel), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DataPresenter.CardViewPanel.OnCoerceViewSettings)));

		// Token: 0x02000208 RID: 520
		private class ItemInfoComparer : global::System.Collections.Generic.IComparer<global::Infragistics.Windows.Tiles.ItemInfoBase>
		{
			// Token: 0x06001CF9 RID: 7417 RVA: 0x0007F234 File Offset: 0x0007D434
			internal ItemInfoComparer()
			{
			}

			// Token: 0x06001CFA RID: 7418 RVA: 0x0007F23C File Offset: 0x0007D43C
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

		// Token: 0x02000209 RID: 521
		private class TileConstraints : global::Infragistics.Windows.Tiles.ITileConstraints
		{
			// Token: 0x170007C2 RID: 1986
			// (get) Token: 0x06001CFB RID: 7419 RVA: 0x0007F28A File Offset: 0x0007D48A
			// (set) Token: 0x06001CFC RID: 7420 RVA: 0x0007F292 File Offset: 0x0007D492
			internal global::System.Windows.HorizontalAlignment? HorizontalAlignment { get; set; }

			// Token: 0x170007C3 RID: 1987
			// (get) Token: 0x06001CFD RID: 7421 RVA: 0x0007F29B File Offset: 0x0007D49B
			// (set) Token: 0x06001CFE RID: 7422 RVA: 0x0007F2A3 File Offset: 0x0007D4A3
			internal global::System.Windows.Thickness? Margin { get; set; }

			// Token: 0x170007C4 RID: 1988
			// (get) Token: 0x06001CFF RID: 7423 RVA: 0x0007F2AC File Offset: 0x0007D4AC
			// (set) Token: 0x06001D00 RID: 7424 RVA: 0x0007F2B4 File Offset: 0x0007D4B4
			internal double MaxHeight { get; set; }

			// Token: 0x170007C5 RID: 1989
			// (get) Token: 0x06001D01 RID: 7425 RVA: 0x0007F2BD File Offset: 0x0007D4BD
			// (set) Token: 0x06001D02 RID: 7426 RVA: 0x0007F2C5 File Offset: 0x0007D4C5
			internal double MaxWidth { get; set; }

			// Token: 0x170007C6 RID: 1990
			// (get) Token: 0x06001D03 RID: 7427 RVA: 0x0007F2CE File Offset: 0x0007D4CE
			// (set) Token: 0x06001D04 RID: 7428 RVA: 0x0007F2D6 File Offset: 0x0007D4D6
			internal double MinHeight { get; set; }

			// Token: 0x170007C7 RID: 1991
			// (get) Token: 0x06001D05 RID: 7429 RVA: 0x0007F2DF File Offset: 0x0007D4DF
			// (set) Token: 0x06001D06 RID: 7430 RVA: 0x0007F2E7 File Offset: 0x0007D4E7
			internal double MinWidth { get; set; }

			// Token: 0x170007C8 RID: 1992
			// (get) Token: 0x06001D07 RID: 7431 RVA: 0x0007F2F0 File Offset: 0x0007D4F0
			// (set) Token: 0x06001D08 RID: 7432 RVA: 0x0007F2F8 File Offset: 0x0007D4F8
			internal double PreferredHeight { get; set; }

			// Token: 0x170007C9 RID: 1993
			// (get) Token: 0x06001D09 RID: 7433 RVA: 0x0007F301 File Offset: 0x0007D501
			// (set) Token: 0x06001D0A RID: 7434 RVA: 0x0007F309 File Offset: 0x0007D509
			internal double PreferredWidth { get; set; }

			// Token: 0x170007CA RID: 1994
			// (get) Token: 0x06001D0B RID: 7435 RVA: 0x0007F312 File Offset: 0x0007D512
			// (set) Token: 0x06001D0C RID: 7436 RVA: 0x0007F31A File Offset: 0x0007D51A
			internal global::System.Windows.VerticalAlignment? VerticalAlignment { get; set; }

			// Token: 0x06001D0D RID: 7437 RVA: 0x0007F324 File Offset: 0x0007D524
			internal TileConstraints()
			{
				this.MaxHeight = double.PositiveInfinity;
				this.MaxWidth = double.PositiveInfinity;
				this.PreferredHeight = double.NaN;
				this.PreferredWidth = double.NaN;
			}

			// Token: 0x170007CB RID: 1995
			// (get) Token: 0x06001D0E RID: 7438 RVA: 0x0007F373 File Offset: 0x0007D573
			global::System.Windows.HorizontalAlignment? global::Infragistics.Windows.Tiles.ITileConstraints.HorizontalAlignment
			{
				get
				{
					return this.HorizontalAlignment;
				}
			}

			// Token: 0x170007CC RID: 1996
			// (get) Token: 0x06001D0F RID: 7439 RVA: 0x0007F37B File Offset: 0x0007D57B
			global::System.Windows.Thickness? global::Infragistics.Windows.Tiles.ITileConstraints.Margin
			{
				get
				{
					return this.Margin;
				}
			}

			// Token: 0x170007CD RID: 1997
			// (get) Token: 0x06001D10 RID: 7440 RVA: 0x0007F383 File Offset: 0x0007D583
			double global::Infragistics.Windows.Tiles.ITileConstraints.MaxHeight
			{
				get
				{
					return this.MaxHeight;
				}
			}

			// Token: 0x170007CE RID: 1998
			// (get) Token: 0x06001D11 RID: 7441 RVA: 0x0007F38B File Offset: 0x0007D58B
			double global::Infragistics.Windows.Tiles.ITileConstraints.MaxWidth
			{
				get
				{
					return this.MaxWidth;
				}
			}

			// Token: 0x170007CF RID: 1999
			// (get) Token: 0x06001D12 RID: 7442 RVA: 0x0007F393 File Offset: 0x0007D593
			double global::Infragistics.Windows.Tiles.ITileConstraints.MinHeight
			{
				get
				{
					return this.MinHeight;
				}
			}

			// Token: 0x170007D0 RID: 2000
			// (get) Token: 0x06001D13 RID: 7443 RVA: 0x0007F39B File Offset: 0x0007D59B
			double global::Infragistics.Windows.Tiles.ITileConstraints.MinWidth
			{
				get
				{
					return this.MinWidth;
				}
			}

			// Token: 0x170007D1 RID: 2001
			// (get) Token: 0x06001D14 RID: 7444 RVA: 0x0007F3A3 File Offset: 0x0007D5A3
			double global::Infragistics.Windows.Tiles.ITileConstraints.PreferredHeight
			{
				get
				{
					return this.PreferredHeight;
				}
			}

			// Token: 0x170007D2 RID: 2002
			// (get) Token: 0x06001D15 RID: 7445 RVA: 0x0007F3AB File Offset: 0x0007D5AB
			double global::Infragistics.Windows.Tiles.ITileConstraints.PreferredWidth
			{
				get
				{
					return this.PreferredWidth;
				}
			}

			// Token: 0x170007D3 RID: 2003
			// (get) Token: 0x06001D16 RID: 7446 RVA: 0x0007F3B3 File Offset: 0x0007D5B3
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
