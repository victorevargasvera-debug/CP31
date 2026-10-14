using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Threading;
using Infragistics.Collections;
using Infragistics.Windows.Commands;
using Infragistics.Windows.Controls.Events;
using Infragistics.Windows.Licensing;
using Infragistics.Windows.Selection;
using Infragistics.Windows.Virtualization;

namespace Infragistics.Windows.Controls
{
	// Token: 0x02000223 RID: 547
	[global::Infragistics.Windows.Licensing.UltraLicense("XamCarouselPanel", global::Infragistics.Windows.Licensing.UltraLicenseAttribute.WpfProductType.DV | global::Infragistics.Windows.Licensing.UltraLicenseAttribute.WpfProductType.LOB)]
	[global::System.ComponentModel.LicenseProvider(typeof(global::Infragistics.Windows.Licensing.UltraLicenseProvider))]
	public class XamCarouselPanel : global::Infragistics.Windows.Virtualization.RecyclingItemsPanel, global::System.Windows.Controls.Primitives.IScrollInfo, global::System.Windows.IWeakEventListener, global::Infragistics.Windows.Commands.ICommandHost
	{
		// Token: 0x06001648 RID: 5704 RVA: 0x000561D8 File Offset: 0x000543D8
		public XamCarouselPanel()
		{
			base.ClipToBounds = true;
			base.Focusable = true;
			try
			{
				this._license = (global::System.ComponentModel.LicenseManager.Validate(typeof(global::Infragistics.Windows.Controls.XamCarouselPanel), this) as global::Infragistics.Windows.Licensing.UltraLicense);
			}
			catch (global::System.IO.FileNotFoundException)
			{
			}
			base.Unloaded += this.OnUnloaded;
		}

		// Token: 0x06001649 RID: 5705 RVA: 0x000562B8 File Offset: 0x000544B8
		protected override global::System.Windows.Size ArrangeOverride(global::System.Windows.Size finalSize)
		{
			this.DoArrangeProcessing(finalSize, true);
			return finalSize;
		}

		// Token: 0x0600164A RID: 5706 RVA: 0x000562C4 File Offset: 0x000544C4
		protected override global::System.Windows.Controls.UIElementCollection CreateUIElementCollection(global::System.Windows.FrameworkElement logicalParent)
		{
			global::Infragistics.Windows.Controls.CarouselPanelUIElementCollection carouselPanelUIElementCollection = new global::Infragistics.Windows.Controls.CarouselPanelUIElementCollection(this, this, logicalParent);
			carouselPanelUIElementCollection.CollectionChanged += this.OnChildrenCollectionChanged;
			return carouselPanelUIElementCollection;
		}

		// Token: 0x0600164B RID: 5707 RVA: 0x000562ED File Offset: 0x000544ED
		protected override bool GetCanCleanupItem(int itemIndex)
		{
			return !this.GetIsItemIndexVisible(itemIndex, this.FirstVisibleItemIndex);
		}

		// Token: 0x170004EE RID: 1262
		// (get) Token: 0x0600164C RID: 5708 RVA: 0x000562FF File Offset: 0x000544FF
		protected override bool IsOkToCleanupUnusedGeneratedElements
		{
			get
			{
				return !this.ScrollInProgress;
			}
		}

		// Token: 0x170004EF RID: 1263
		// (get) Token: 0x0600164D RID: 5709 RVA: 0x0005630C File Offset: 0x0005450C
		protected override global::System.Collections.IEnumerator LogicalChildren
		{
			get
			{
				return new global::Infragistics.Collections.MultiSourceEnumerator(new global::System.Collections.IEnumerator[]
				{
					new global::Infragistics.Collections.SingleItemEnumerator((this._viewSettings != null && global::System.Windows.LogicalTreeHelper.GetParent(this._viewSettings) == this) ? this._viewSettings : null),
					new global::Infragistics.Collections.SingleItemEnumerator(this._carouselPanelNavigator),
					base.LogicalChildren
				});
			}
		}

		// Token: 0x170004F0 RID: 1264
		// (get) Token: 0x0600164E RID: 5710 RVA: 0x00056364 File Offset: 0x00054564
		protected override int MaximumUnusedGeneratedItemsToKeep
		{
			get
			{
				return global::System.Math.Min(this.ItemsPerPageResolved * 5, 100);
			}
		}

		// Token: 0x0600164F RID: 5711 RVA: 0x00056378 File Offset: 0x00054578
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size availableSize)
		{
			this.PathFractionPointsCache.Clear();
			global::Infragistics.Windows.Controls.CarouselViewSettings viewSettingsInternal = this.ViewSettingsInternal;
			if (availableSize.Width == double.PositiveInfinity || availableSize.Height == double.PositiveInfinity)
			{
				double width = (availableSize.Width == double.PositiveInfinity) ? viewSettingsInternal.WidthInInfiniteContainers : availableSize.Width;
				double height = (availableSize.Height == double.PositiveInfinity) ? viewSettingsInternal.HeightInInfiniteContainers : availableSize.Height;
				availableSize = new global::System.Windows.Size(width, height);
			}
			if (this._carouselPanelAdorner == null)
			{
				this.InitializeAdorner();
			}
			if (this._visiblePositionPercentValuesDirty)
			{
				this.RecalculateVisiblePositionPercentValues();
			}
			int itemsPerPageResolved = this.ItemsPerPageResolved;
			this.UpdateScrollData(new global::System.Windows.Size((double)this.TotalItemCount, (double)this.TotalItemCount), new global::System.Windows.Size((double)itemsPerPageResolved, (double)itemsPerPageResolved), this.ScrollingData._offset);
			this._previousMeasureSize = availableSize;
			this.ScaleItemPath(availableSize);
			return availableSize;
		}

		// Token: 0x06001650 RID: 5712 RVA: 0x00056467 File Offset: 0x00054667
		protected override void OnMouseWheel(global::System.Windows.Input.MouseWheelEventArgs e)
		{
			if (e.Delta > 0)
			{
				this.MouseWheelLeft();
				e.Handled = true;
			}
			else if (e.Delta < 0)
			{
				this.MouseWheelRight();
				e.Handled = true;
			}
			base.OnMouseWheel(e);
		}

		// Token: 0x06001651 RID: 5713 RVA: 0x000564A0 File Offset: 0x000546A0
		protected override void OnInitialized(global::System.EventArgs e)
		{
			base.OnInitialized(e);
			if (this._viewSettings == null && this.IsInCarouselListBox)
			{
				global::Infragistics.Windows.Controls.XamCarouselListBox xamCarouselListBox = global::Infragistics.Windows.Utilities.GetAncestorFromType(this, typeof(global::Infragistics.Windows.Controls.XamCarouselListBox), true) as global::Infragistics.Windows.Controls.XamCarouselListBox;
				if (xamCarouselListBox != null)
				{
					base.SetBinding(global::Infragistics.Windows.Controls.XamCarouselPanel.ViewSettingsProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.Controls.XamCarouselListBox.ViewSettingsProperty, global::System.Windows.Data.BindingMode.OneWay, xamCarouselListBox));
				}
			}
			if (this._viewSettings == null && !global::System.ComponentModel.DesignerProperties.GetIsInDesignMode(this))
			{
				base.SetValue(global::Infragistics.Windows.Controls.XamCarouselPanel.ViewSettingsProperty, this.ViewSettings);
			}
			this.ViewSettingsInternal.OnControlInitialized();
		}

		// Token: 0x06001652 RID: 5714 RVA: 0x00056524 File Offset: 0x00054724
		protected override void OnItemsChanged(object sender, global::System.Windows.Controls.Primitives.ItemsChangedEventArgs args)
		{
			base.OnItemsChanged(sender, args);
			switch (args.Action)
			{
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Remove:
				this.RemoveRangeOfChldren(args.Position, args.ItemUICount);
				break;
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Replace:
				this.RemoveRangeOfChldren(args.Position, args.ItemUICount);
				break;
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Move:
				this.RemoveRangeOfChldren(args.OldPosition, args.ItemUICount);
				break;
			}
			switch (args.Action)
			{
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Add:
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Remove:
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Replace:
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Move:
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset:
			{
				int itemsPerPageResolved = this.ItemsPerPageResolved;
				if (args.Action == global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset)
				{
					this.UpdateScrollData(new global::System.Windows.Size((double)this.TotalItemCount, (double)this.TotalItemCount), new global::System.Windows.Size((double)itemsPerPageResolved, (double)itemsPerPageResolved), new global::System.Windows.Vector(this.ScrollOffsetForInitialArrangeAnimation, this.ScrollOffsetForInitialArrangeAnimation));
				}
				else
				{
					this.UpdateScrollData(new global::System.Windows.Size((double)this.TotalItemCount, (double)this.TotalItemCount), new global::System.Windows.Size((double)itemsPerPageResolved, (double)itemsPerPageResolved), new global::System.Windows.Vector(this.VerticalOffset, this.VerticalOffset));
				}
				this.ShouldGenerateElements = true;
				if (args.Action == global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset)
				{
					this._initialArrangeAnimationDone = false;
				}
				else if (this.ViewSettingsInternal.ShouldAnimateItemsOnListChange)
				{
					this._initialArrangeAnimationDone = false;
				}
				base.InvalidateArrange();
				return;
			}
			default:
				return;
			}
		}

		// Token: 0x06001653 RID: 5715 RVA: 0x00056660 File Offset: 0x00054860
		protected override void OnKeyDown(global::System.Windows.Input.KeyEventArgs e)
		{
			bool flag = false;
			global::System.Windows.Input.Key key = e.Key;
			bool itemsHostSupportsSelection = this.ItemsHostSupportsSelection;
			switch (key)
			{
			case global::System.Windows.Input.Key.Prior:
				if (base.IsItemsHost && itemsHostSupportsSelection)
				{
					if (this.GetIsItemIndexVisible(this.SelectionHost.SelectedItemIndex, this.FirstVisibleItemIndex) && this.SelectionHost.SelectedItemIndex != this.FirstVisibleItemIndex)
					{
						this.SelectionHost.SelectedItemIndex = this.FirstVisibleItemIndex;
					}
					else
					{
						this.SelectionHost.SelectedItemIndex = global::System.Math.Max(0, this.SelectionHost.SelectedItemIndex - this.ItemsPerPageResolved + 1);
						this.EnsureItemIsVisible(this.SelectionHost.SelectedItemIndex);
					}
				}
				else
				{
					this.PageUp();
				}
				flag = true;
				break;
			case global::System.Windows.Input.Key.Next:
				if (base.IsItemsHost && itemsHostSupportsSelection)
				{
					if (this.GetIsItemIndexVisible(this.SelectionHost.SelectedItemIndex, this.FirstVisibleItemIndex) && this.SelectionHost.SelectedItemIndex != this.LastVisibleItemIndex)
					{
						this.SelectionHost.SelectedItemIndex = this.LastVisibleItemIndex;
					}
					else
					{
						this.SelectionHost.SelectedItemIndex = global::System.Math.Min(this.TotalItemCount - 1, this.SelectionHost.SelectedItemIndex + this.ItemsPerPageResolved - 1);
						this.SetVerticalOffset((double)this.FirstVisibleItemIndexFromLastVisibleItemIndex(this.SelectionHost.SelectedItemIndex));
					}
				}
				else
				{
					this.PageDown();
				}
				flag = true;
				break;
			case global::System.Windows.Input.Key.Left:
			case global::System.Windows.Input.Key.Up:
				if (base.IsItemsHost && itemsHostSupportsSelection)
				{
					if (this.SelectionHost.SelectedItemIndex < 0)
					{
						this.SelectionHost.SelectedItemIndex = 0;
					}
					else
					{
						this.SelectionHost.SelectedItemIndex = global::System.Math.Max(0, this.SelectionHost.SelectedItemIndex - 1);
					}
					this.EnsureItemIsVisible(this.SelectionHost.SelectedItemIndex);
				}
				else
				{
					this.LineUp();
				}
				flag = true;
				break;
			case global::System.Windows.Input.Key.Right:
			case global::System.Windows.Input.Key.Down:
				if (base.IsItemsHost && itemsHostSupportsSelection)
				{
					if (this.SelectionHost.SelectedItemIndex < 0)
					{
						this.SelectionHost.SelectedItemIndex = 0;
					}
					else
					{
						this.SelectionHost.SelectedItemIndex = global::System.Math.Min(this.TotalItemCount - 1, this.SelectionHost.SelectedItemIndex + 1);
					}
					this.EnsureItemIsVisible(this.SelectionHost.SelectedItemIndex);
				}
				else
				{
					this.LineDown();
				}
				flag = true;
				break;
			}
			if (flag)
			{
				e.Handled = true;
				return;
			}
			base.OnKeyDown(e);
		}

		// Token: 0x06001654 RID: 5716 RVA: 0x000568C0 File Offset: 0x00054AC0
		protected override void OnMouseDown(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			base.OnMouseDown(e);
			if (!base.IsFocused)
			{
				base.Focus();
			}
		}

		// Token: 0x06001655 RID: 5717 RVA: 0x000568D8 File Offset: 0x00054AD8
		protected override void OnNewElementRealized(global::System.Windows.UIElement element, int index)
		{
		}

		// Token: 0x06001656 RID: 5718 RVA: 0x000568DC File Offset: 0x00054ADC
		protected override void OnPropertyChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			base.OnPropertyChanged(e);
			if (e.Property == global::Infragistics.Windows.Controls.XamCarouselPanel.ViewSettingsProperty)
			{
				if (this._viewSettings != null)
				{
					global::System.ComponentModel.PropertyChangedEventManager.RemoveListener(this._viewSettings, this, string.Empty);
					global::System.Windows.DependencyObject parent = global::System.Windows.LogicalTreeHelper.GetParent(this._viewSettings);
					if (parent == this)
					{
						base.RemoveLogicalChild(this._viewSettings);
					}
				}
				this._viewSettings = (e.NewValue as global::Infragistics.Windows.Controls.CarouselViewSettings);
				if (base.IsInitialized && this._viewSettings != null)
				{
					this._viewSettings.OnControlInitialized();
				}
				this.BindNavigatorVisibility();
				if (this._viewSettings != null)
				{
					this.BumpCarouselViewSettingsVersion();
					global::System.ComponentModel.PropertyChangedEventManager.AddListener(this._viewSettings, this, string.Empty);
					if (global::System.Windows.LogicalTreeHelper.GetParent(this._viewSettings) == null)
					{
						base.AddLogicalChild(this._viewSettings);
					}
					this._viewSettings.EnumeratePropertiesWithNonDefaultValues(new global::System.ComponentModel.PropertyChangedEventHandler(this.OnViewSettingsPropertyChanged));
				}
				global::Infragistics.Windows.Controls.CarouselViewSettings carouselViewSettings = e.OldValue as global::Infragistics.Windows.Controls.CarouselViewSettings;
				if (carouselViewSettings != null)
				{
					carouselViewSettings.EnumeratePropertiesWithNonDefaultValues(new global::System.ComponentModel.PropertyChangedEventHandler(this.OnViewSettingsPropertyChanged));
				}
			}
		}

		// Token: 0x06001657 RID: 5719 RVA: 0x000569DC File Offset: 0x00054BDC
		protected override void OnRender(global::System.Windows.Media.DrawingContext drawingContext)
		{
			base.OnRender(drawingContext);
			if (this._cachedItemPathRenderPen != null || this._cachedItemPathRenderBrush != null)
			{
				drawingContext.DrawGeometry(this._cachedItemPathRenderBrush, this._cachedItemPathRenderPen, this.ItemPathGeometry);
				return;
			}
			drawingContext.DrawRectangle(global::System.Windows.Media.Brushes.Transparent, null, new global::System.Windows.Rect(new global::System.Windows.Point(0.0, 0.0), base.RenderSize));
		}

		// Token: 0x170004F1 RID: 1265
		// (get) Token: 0x06001658 RID: 5720 RVA: 0x00056A48 File Offset: 0x00054C48
		protected override int TotalVisibleGeneratedItems
		{
			get
			{
				if (!base.IsItemsHost)
				{
					return 0;
				}
				return global::System.Math.Min(this.TotalItemCount - this.FirstVisibleItemIndex, ((int)this.ScrollingData._offset.Y >= 0) ? this.ItemsPerPageResolved : (this.ItemsPerPageResolved + (int)this.ScrollingData._offset.Y));
			}
		}

		// Token: 0x170004F2 RID: 1266
		// (get) Token: 0x06001659 RID: 5721 RVA: 0x00056AA5 File Offset: 0x00054CA5
		public double ExtentHeight
		{
			get
			{
				return this.ScrollingData._extent.Height;
			}
		}

		// Token: 0x170004F3 RID: 1267
		// (get) Token: 0x0600165A RID: 5722 RVA: 0x00056AB7 File Offset: 0x00054CB7
		public double ExtentWidth
		{
			get
			{
				return this.ScrollingData._extent.Width;
			}
		}

		// Token: 0x170004F4 RID: 1268
		// (get) Token: 0x0600165B RID: 5723 RVA: 0x00056AC9 File Offset: 0x00054CC9
		public double HorizontalOffset
		{
			get
			{
				return this.ScrollingData._offset.Y;
			}
		}

		// Token: 0x170004F5 RID: 1269
		// (get) Token: 0x0600165C RID: 5724 RVA: 0x00056ADB File Offset: 0x00054CDB
		public double VerticalOffset
		{
			get
			{
				return this.ScrollingData._offset.Y;
			}
		}

		// Token: 0x0600165D RID: 5725 RVA: 0x00056AF0 File Offset: 0x00054CF0
		public void SetHorizontalOffset(double offset)
		{
			this.SetHorizontalOffset(offset, null);
		}

		// Token: 0x0600165E RID: 5726 RVA: 0x00056B0D File Offset: 0x00054D0D
		internal void SetHorizontalOffset(double offset, bool? scrollingHigherHint)
		{
			this.SetVerticalOffset(offset, scrollingHigherHint);
		}

		// Token: 0x0600165F RID: 5727 RVA: 0x00056B18 File Offset: 0x00054D18
		public void SetVerticalOffset(double offset)
		{
			this.SetVerticalOffset(offset, null);
		}

		// Token: 0x06001660 RID: 5728 RVA: 0x00056B38 File Offset: 0x00054D38
		internal void SetVerticalOffset(double offset, bool? scrollingHigherHint)
		{
			bool scrollingHigher = (scrollingHigherHint != null) ? scrollingHigherHint.Value : (offset > this.ScrollingData._offset.Y);
			global::Infragistics.Windows.Controls.CarouselViewSettings viewSettingsInternal = this.ViewSettingsInternal;
			int itemsPerPageResolved = this.ItemsPerPageResolved;
			double num;
			if (!viewSettingsInternal.IsListContinuous || (viewSettingsInternal.IsListContinuous && this.TotalItemCount < itemsPerPageResolved))
			{
				num = global::System.Math.Min(global::System.Math.Max(this.LowestPossibleScrollOffset, offset), this.HighestPossibleScrollOffset);
			}
			else
			{
				int num2 = this.TotalItemCount - 1;
				if (offset > (double)num2)
				{
					num = offset - (double)num2 - 1.0;
				}
				else if (offset < 0.0)
				{
					num = (double)num2 - global::System.Math.Abs(offset) + 1.0;
				}
				else
				{
					num = offset;
				}
			}
			int num3;
			bool isItemIndexVisible = this.GetIsItemIndexVisible((int)num, (int)this.ScrollingData._offset.Y, out num3);
			if (scrollingHigherHint == null && isItemIndexVisible && viewSettingsInternal.IsListContinuous && this.TotalItemCount > itemsPerPageResolved)
			{
				scrollingHigher = true;
			}
			double num4 = num - this.ScrollingData._offset.Y;
			if (num4 == 0.0)
			{
				return;
			}
			global::System.Collections.IList childElements = base.ChildElements;
			int count = childElements.Count;
			if (this.ScrollInProgress)
			{
				this.StopAnimatedScrollProcessing();
				for (int i = 0; i < count; i++)
				{
					global::Infragistics.Windows.Controls.CarouselPanelItem carouselPanelItem = childElements[i] as global::Infragistics.Windows.Controls.CarouselPanelItem;
					if (carouselPanelItem != null)
					{
						carouselPanelItem.PathTargetPercent = carouselPanelItem.PathLocationPercent;
					}
				}
			}
			this.StartAnimatedScrollProcessing(new global::Infragistics.Windows.Controls.XamCarouselPanel.ScrollActionInfo(this.ScrollingData._offset.Y, num, scrollingHigher, this));
			double y = this.ScrollingData._offset.Y;
			this.UpdateScrollData(this.ScrollingData._extent, this.ScrollingData._viewport, new global::System.Windows.Vector(num, num));
			if (base.IsItemsHost)
			{
				this.GenerateElementsHelper((int)num, itemsPerPageResolved, new int?((int)y), itemsPerPageResolved);
			}
			count = childElements.Count;
			bool isListContinuous = viewSettingsInternal.IsListContinuous;
			for (int j = 0; j < count; j++)
			{
				global::Infragistics.Windows.Controls.CarouselPanelItem carouselPanelItem2 = childElements[j] as global::Infragistics.Windows.Controls.CarouselPanelItem;
				int itemIndexFromChildIndex = base.GetItemIndexFromChildIndex(j);
				int num5;
				bool isItemIndexVisible2 = this.GetIsItemIndexVisible(itemIndexFromChildIndex, (int)y, out num5);
				int num6;
				bool isItemIndexVisible3 = this.GetIsItemIndexVisible(itemIndexFromChildIndex, (int)num, out num6);
				if (carouselPanelItem2 != null)
				{
					carouselPanelItem2.Velocity = 0.0;
					carouselPanelItem2.PathTargetPercent = this.CalculateChildTargetPct(j, itemIndexFromChildIndex, (int)num, isItemIndexVisible2, isItemIndexVisible3);
					if (isItemIndexVisible2)
					{
						carouselPanelItem2.PathLocationPercent = this.CalculateChildTargetPct(j, itemIndexFromChildIndex, (int)y, true, true);
					}
					if (this._scrollActionInfo.ScrollingHigher)
					{
						if (isItemIndexVisible3 && !isItemIndexVisible2)
						{
							if (carouselPanelItem2.IsPathLocationUnset || !isListContinuous)
							{
								carouselPanelItem2.PathLocationPercent = 1.0;
							}
							else if (isListContinuous && carouselPanelItem2.PathLocationPercent != 1.0)
							{
								carouselPanelItem2.PathLocationPercent = 1.0;
							}
						}
						else if (isItemIndexVisible3 && isItemIndexVisible2 && num6 > num5 && isListContinuous && carouselPanelItem2.PathLocationPercent != 1.0)
						{
							carouselPanelItem2.PathLocationPercent = 1.0;
						}
					}
					else if (isItemIndexVisible3 && !isItemIndexVisible2)
					{
						if (carouselPanelItem2.IsPathLocationUnset)
						{
							carouselPanelItem2.PathLocationPercent = 0.0;
						}
						else if (carouselPanelItem2.PathLocationPercent != 0.0)
						{
							carouselPanelItem2.PathLocationPercent = 0.0;
						}
					}
					else if (isItemIndexVisible3 && isItemIndexVisible2 && num6 < num5 && isListContinuous && carouselPanelItem2.PathLocationPercent != 0.0)
					{
						carouselPanelItem2.PathLocationPercent = 0.0;
					}
				}
			}
		}

		// Token: 0x06001661 RID: 5729 RVA: 0x00056EEE File Offset: 0x000550EE
		public void LineDown()
		{
			this.SetVerticalOffset(this.VerticalOffset + 1.0, new bool?(true));
		}

		// Token: 0x06001662 RID: 5730 RVA: 0x00056F0C File Offset: 0x0005510C
		public void LineLeft()
		{
			this.SetHorizontalOffset(this.HorizontalOffset - 1.0, new bool?(false));
		}

		// Token: 0x06001663 RID: 5731 RVA: 0x00056F2A File Offset: 0x0005512A
		public void LineRight()
		{
			this.SetHorizontalOffset(this.HorizontalOffset + 1.0, new bool?(true));
		}

		// Token: 0x06001664 RID: 5732 RVA: 0x00056F48 File Offset: 0x00055148
		public void LineUp()
		{
			this.SetVerticalOffset(this.VerticalOffset - 1.0, new bool?(false));
		}

		// Token: 0x06001665 RID: 5733 RVA: 0x00056F66 File Offset: 0x00055166
		public void MouseWheelDown()
		{
			this.SetVerticalOffset(this.VerticalOffset + 1.0, new bool?(true));
		}

		// Token: 0x06001666 RID: 5734 RVA: 0x00056F84 File Offset: 0x00055184
		public void MouseWheelLeft()
		{
			this.SetVerticalOffset(this.VerticalOffset - 1.0, new bool?(false));
		}

		// Token: 0x06001667 RID: 5735 RVA: 0x00056FA2 File Offset: 0x000551A2
		public void MouseWheelRight()
		{
			this.SetVerticalOffset(this.VerticalOffset + 1.0, new bool?(true));
		}

		// Token: 0x06001668 RID: 5736 RVA: 0x00056FC0 File Offset: 0x000551C0
		public void MouseWheelUp()
		{
			this.SetVerticalOffset(this.VerticalOffset - 1.0, new bool?(false));
		}

		// Token: 0x06001669 RID: 5737 RVA: 0x00056FDE File Offset: 0x000551DE
		public void PageDown()
		{
			this.SetVerticalOffset(this.VerticalOffset + (double)this.ScrollLargeChange, new bool?(true));
		}

		// Token: 0x0600166A RID: 5738 RVA: 0x00056FFA File Offset: 0x000551FA
		public void PageLeft()
		{
			this.SetHorizontalOffset(this.HorizontalOffset - (double)this.ScrollLargeChange, new bool?(false));
		}

		// Token: 0x0600166B RID: 5739 RVA: 0x00057016 File Offset: 0x00055216
		public void PageRight()
		{
			this.SetHorizontalOffset(this.HorizontalOffset + (double)this.ScrollLargeChange, new bool?(true));
		}

		// Token: 0x0600166C RID: 5740 RVA: 0x00057032 File Offset: 0x00055232
		public void PageUp()
		{
			this.SetVerticalOffset(this.VerticalOffset - (double)this.ScrollLargeChange, new bool?(false));
		}

		// Token: 0x170004F6 RID: 1270
		// (get) Token: 0x0600166D RID: 5741 RVA: 0x0005704E File Offset: 0x0005524E
		// (set) Token: 0x0600166E RID: 5742 RVA: 0x0005705B File Offset: 0x0005525B
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
				}
			}
		}

		// Token: 0x170004F7 RID: 1271
		// (get) Token: 0x0600166F RID: 5743 RVA: 0x00057082 File Offset: 0x00055282
		public double ViewportHeight
		{
			get
			{
				return this.ScrollingData._viewport.Height;
			}
		}

		// Token: 0x170004F8 RID: 1272
		// (get) Token: 0x06001670 RID: 5744 RVA: 0x00057094 File Offset: 0x00055294
		public double ViewportWidth
		{
			get
			{
				return this.ScrollingData._viewport.Width;
			}
		}

		// Token: 0x06001671 RID: 5745 RVA: 0x000570A8 File Offset: 0x000552A8
		public global::System.Windows.Rect MakeVisible(global::System.Windows.Media.Visual visual, global::System.Windows.Rect rectangle)
		{
			global::Infragistics.Windows.Controls.CarouselPanelItem carouselPanelItem = visual as global::Infragistics.Windows.Controls.CarouselPanelItem;
			if (carouselPanelItem != null)
			{
				int visualChildrenCount = this.VisualChildrenCount;
				for (int i = 0; i < visualChildrenCount; i++)
				{
					global::System.Windows.UIElement uielement = this.GetVisualChild(i) as global::System.Windows.UIElement;
					if (uielement == carouselPanelItem)
					{
						this.EnsureItemIsVisible(base.GetItemIndexFromChildIndex(i));
						break;
					}
				}
			}
			return rectangle;
		}

		// Token: 0x170004F9 RID: 1273
		// (get) Token: 0x06001672 RID: 5746 RVA: 0x000570F4 File Offset: 0x000552F4
		// (set) Token: 0x06001673 RID: 5747 RVA: 0x00057101 File Offset: 0x00055301
		bool global::System.Windows.Controls.Primitives.IScrollInfo.CanVerticallyScroll
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

		// Token: 0x170004FA RID: 1274
		// (get) Token: 0x06001674 RID: 5748 RVA: 0x00057123 File Offset: 0x00055323
		// (set) Token: 0x06001675 RID: 5749 RVA: 0x00057130 File Offset: 0x00055330
		bool global::System.Windows.Controls.Primitives.IScrollInfo.CanHorizontallyScroll
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

		// Token: 0x170004FB RID: 1275
		// (get) Token: 0x06001676 RID: 5750 RVA: 0x00057152 File Offset: 0x00055352
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		public bool CanNavigateToPreviousItem
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.Controls.XamCarouselPanel.CanNavigateToPreviousItemProperty);
			}
		}

		// Token: 0x170004FC RID: 1276
		// (get) Token: 0x06001677 RID: 5751 RVA: 0x00057164 File Offset: 0x00055364
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public bool CanNavigateToPreviousPage
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.Controls.XamCarouselPanel.CanNavigateToPreviousPageProperty);
			}
		}

		// Token: 0x170004FD RID: 1277
		// (get) Token: 0x06001678 RID: 5752 RVA: 0x00057176 File Offset: 0x00055376
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Bindable(true)]
		public bool CanNavigateToNextItem
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.Controls.XamCarouselPanel.CanNavigateToNextItemProperty);
			}
		}

		// Token: 0x170004FE RID: 1278
		// (get) Token: 0x06001679 RID: 5753 RVA: 0x00057188 File Offset: 0x00055388
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Bindable(true)]
		public bool CanNavigateToNextPage
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.Controls.XamCarouselPanel.CanNavigateToNextPageProperty);
			}
		}

		// Token: 0x170004FF RID: 1279
		// (get) Token: 0x0600167A RID: 5754 RVA: 0x0005719A File Offset: 0x0005539A
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		public int FirstVisibleItemIndex
		{
			get
			{
				return (int)base.GetValue(global::Infragistics.Windows.Controls.XamCarouselPanel.FirstVisibleItemIndexProperty);
			}
		}

		// Token: 0x17000500 RID: 1280
		// (get) Token: 0x0600167B RID: 5755 RVA: 0x000571AC File Offset: 0x000553AC
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public int ItemsPerPageResolved
		{
			get
			{
				if (this.ViewSettingsInternal != null)
				{
					return global::System.Math.Max(1, global::System.Math.Min(this.TotalItemCount, this.ViewSettingsInternal.ItemsPerPage));
				}
				return global::System.Math.Max(1, global::System.Math.Min(this.TotalItemCount, 5));
			}
		}

		// Token: 0x17000501 RID: 1281
		// (get) Token: 0x0600167C RID: 5756 RVA: 0x000571E5 File Offset: 0x000553E5
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		public global::Infragistics.Windows.Controls.OpacityEffectStopCollection OpacityEffectStopsResolved
		{
			get
			{
				if (this.ViewSettingsInternal.OpacityEffectStops == null || this.ViewSettingsInternal.OpacityEffectStops.Count < 1)
				{
					return this.DefaultOpacityEffectStops;
				}
				return this.ViewSettingsInternal.OpacityEffectStops;
			}
		}

		// Token: 0x17000502 RID: 1282
		// (get) Token: 0x0600167D RID: 5757 RVA: 0x00057219 File Offset: 0x00055419
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::Infragistics.Windows.Controls.EffectStopDirection OpacityEffectStopDirectionResolved
		{
			get
			{
				if (this.ViewSettingsInternal.OpacityEffectStopDirection == global::Infragistics.Windows.Controls.EffectStopDirection.Default)
				{
					return global::Infragistics.Windows.Controls.EffectStopDirection.UseItemPath;
				}
				return this.ViewSettingsInternal.OpacityEffectStopDirection;
			}
		}

		// Token: 0x17000503 RID: 1283
		// (get) Token: 0x0600167E RID: 5758 RVA: 0x00057235 File Offset: 0x00055435
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		public global::System.Windows.Visibility ReflectionVisibility
		{
			get
			{
				return (global::System.Windows.Visibility)base.GetValue(global::Infragistics.Windows.Controls.XamCarouselPanel.ReflectionVisibilityProperty);
			}
		}

		// Token: 0x17000504 RID: 1284
		// (get) Token: 0x0600167F RID: 5759 RVA: 0x00057247 File Offset: 0x00055447
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		public global::Infragistics.Windows.Controls.ScalingEffectStopCollection ScalingEffectStopsResolved
		{
			get
			{
				if (this.ViewSettingsInternal.ScalingEffectStops == null || this.ViewSettingsInternal.ScalingEffectStops.Count < 1)
				{
					return this.DefaultScalingEffectStops;
				}
				return this.ViewSettingsInternal.ScalingEffectStops;
			}
		}

		// Token: 0x17000505 RID: 1285
		// (get) Token: 0x06001680 RID: 5760 RVA: 0x0005727B File Offset: 0x0005547B
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::Infragistics.Windows.Controls.EffectStopDirection ScalingEffectStopDirectionResolved
		{
			get
			{
				if (this.ViewSettingsInternal.ScalingEffectStopDirection == global::Infragistics.Windows.Controls.EffectStopDirection.Default)
				{
					return global::Infragistics.Windows.Controls.EffectStopDirection.UseItemPath;
				}
				return this.ViewSettingsInternal.ScalingEffectStopDirection;
			}
		}

		// Token: 0x17000506 RID: 1286
		// (get) Token: 0x06001681 RID: 5761 RVA: 0x00057297 File Offset: 0x00055497
		// (set) Token: 0x06001682 RID: 5762 RVA: 0x0005729F File Offset: 0x0005549F
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::Infragistics.Windows.Controls.ICarouselPanelSelectionHost SelectionHost
		{
			get
			{
				return this._selectionHost;
			}
			set
			{
				this._selectionHost = value;
			}
		}

		// Token: 0x17000507 RID: 1287
		// (get) Token: 0x06001683 RID: 5763 RVA: 0x000572A8 File Offset: 0x000554A8
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		public global::Infragistics.Windows.Controls.SkewAngleXEffectStopCollection SkewAngleXEffectStopsResolved
		{
			get
			{
				if (this.ViewSettingsInternal.SkewAngleXEffectStops == null || this.ViewSettingsInternal.SkewAngleXEffectStops.Count < 1)
				{
					return this.DefaultSkewAngleXEffectStops;
				}
				return this.ViewSettingsInternal.SkewAngleXEffectStops;
			}
		}

		// Token: 0x17000508 RID: 1288
		// (get) Token: 0x06001684 RID: 5764 RVA: 0x000572DC File Offset: 0x000554DC
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::Infragistics.Windows.Controls.EffectStopDirection SkewAngleXEffectStopDirectionResolved
		{
			get
			{
				if (this.ViewSettingsInternal.SkewAngleXEffectStopDirection == global::Infragistics.Windows.Controls.EffectStopDirection.Default)
				{
					return global::Infragistics.Windows.Controls.EffectStopDirection.UseItemPath;
				}
				return this.ViewSettingsInternal.SkewAngleXEffectStopDirection;
			}
		}

		// Token: 0x17000509 RID: 1289
		// (get) Token: 0x06001685 RID: 5765 RVA: 0x000572F8 File Offset: 0x000554F8
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::Infragistics.Windows.Controls.SkewAngleYEffectStopCollection SkewAngleYEffectStopsResolved
		{
			get
			{
				if (this.ViewSettingsInternal.SkewAngleYEffectStops == null || this.ViewSettingsInternal.SkewAngleYEffectStops.Count < 1)
				{
					return this.DefaultSkewAngleYEffectStops;
				}
				return this.ViewSettingsInternal.SkewAngleYEffectStops;
			}
		}

		// Token: 0x1700050A RID: 1290
		// (get) Token: 0x06001686 RID: 5766 RVA: 0x0005732C File Offset: 0x0005552C
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::Infragistics.Windows.Controls.EffectStopDirection SkewAngleYEffectStopDirectionResolved
		{
			get
			{
				if (this.ViewSettingsInternal.SkewAngleYEffectStopDirection == global::Infragistics.Windows.Controls.EffectStopDirection.Default)
				{
					return global::Infragistics.Windows.Controls.EffectStopDirection.UseItemPath;
				}
				return this.ViewSettingsInternal.SkewAngleYEffectStopDirection;
			}
		}

		// Token: 0x06001687 RID: 5767 RVA: 0x00057348 File Offset: 0x00055548
		private static object OnCoerceViewSettings(global::System.Windows.DependencyObject d, object value)
		{
			if (value == null && !global::System.ComponentModel.DesignerProperties.GetIsInDesignMode(d))
			{
				return new global::Infragistics.Windows.Controls.CarouselViewSettings();
			}
			return value;
		}

		// Token: 0x1700050B RID: 1291
		// (get) Token: 0x06001688 RID: 5768 RVA: 0x0005735C File Offset: 0x0005555C
		// (set) Token: 0x06001689 RID: 5769 RVA: 0x00057390 File Offset: 0x00055590
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.Controls.CarouselViewSettings ViewSettings
		{
			get
			{
				if (this._viewSettings == null && !global::System.ComponentModel.DesignerProperties.GetIsInDesignMode(this))
				{
					this._viewSettings = new global::Infragistics.Windows.Controls.CarouselViewSettings();
					global::System.ComponentModel.PropertyChangedEventManager.AddListener(this._viewSettings, this, string.Empty);
				}
				return this._viewSettings;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.XamCarouselPanel.ViewSettingsProperty, value);
			}
		}

		// Token: 0x0600168A RID: 5770 RVA: 0x0005739E File Offset: 0x0005559E
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeViewSettings()
		{
			return this.ViewSettings != (global::Infragistics.Windows.Controls.CarouselViewSettings)global::Infragistics.Windows.Controls.XamCarouselPanel.ViewSettingsProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x0600168B RID: 5771 RVA: 0x000573BF File Offset: 0x000555BF
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetViewSettings()
		{
			this.ViewSettings = (global::Infragistics.Windows.Controls.CarouselViewSettings)global::Infragistics.Windows.Controls.XamCarouselPanel.ViewSettingsProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x1700050C RID: 1292
		// (get) Token: 0x0600168C RID: 5772 RVA: 0x000573DC File Offset: 0x000555DC
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		public global::Infragistics.Windows.Controls.ZOrderEffectStopCollection ZOrderEffectStopsResolved
		{
			get
			{
				if (!this.ViewSettingsInternal.UseZOrder || this.ViewSettingsInternal.ZOrderEffectStops == null || this.ViewSettingsInternal.ZOrderEffectStops.Count < 1)
				{
					return this.DefaultZOrderEffectStops;
				}
				return this.ViewSettingsInternal.ZOrderEffectStops;
			}
		}

		// Token: 0x1700050D RID: 1293
		// (get) Token: 0x0600168D RID: 5773 RVA: 0x00057428 File Offset: 0x00055628
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::Infragistics.Windows.Controls.EffectStopDirection ZOrderEffectStopDirectionResolved
		{
			get
			{
				if (!this.ViewSettingsInternal.UseZOrder || this.ViewSettingsInternal.ZOrderEffectStopDirection == global::Infragistics.Windows.Controls.EffectStopDirection.Default)
				{
					return global::Infragistics.Windows.Controls.EffectStopDirection.UseItemPath;
				}
				return this.ViewSettingsInternal.ZOrderEffectStopDirection;
			}
		}

		// Token: 0x1700050E RID: 1294
		// (get) Token: 0x0600168E RID: 5774 RVA: 0x00057451 File Offset: 0x00055651
		internal int FirstVisibleChildIndex
		{
			get
			{
				return base.GetChildIndexFromItemIndex(this.FirstVisibleItemIndex);
			}
		}

		// Token: 0x1700050F RID: 1295
		// (get) Token: 0x0600168F RID: 5775 RVA: 0x0005745F File Offset: 0x0005565F
		// (set) Token: 0x06001690 RID: 5776 RVA: 0x00057471 File Offset: 0x00055671
		internal bool IsInCarouselListBox
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.Controls.XamCarouselPanel.IsInCarouselListBoxProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.XamCarouselPanel.IsInCarouselListBoxProperty, value);
			}
		}

		// Token: 0x17000510 RID: 1296
		// (get) Token: 0x06001691 RID: 5777 RVA: 0x00057484 File Offset: 0x00055684
		internal global::Infragistics.Windows.Controls.XamCarouselPanel.ScrollData ScrollingData
		{
			get
			{
				if (this._scrollingData == null)
				{
					this._scrollingData = new global::Infragistics.Windows.Controls.XamCarouselPanel.ScrollData();
				}
				return this._scrollingData;
			}
		}

		// Token: 0x17000511 RID: 1297
		// (get) Token: 0x06001692 RID: 5778 RVA: 0x0005749F File Offset: 0x0005569F
		internal int ScrollLargeChange
		{
			get
			{
				return this.ItemsPerPageResolved;
			}
		}

		// Token: 0x17000512 RID: 1298
		// (get) Token: 0x06001693 RID: 5779 RVA: 0x000574A8 File Offset: 0x000556A8
		internal global::Infragistics.Windows.Controls.CarouselViewSettings ViewSettingsInternal
		{
			get
			{
				global::Infragistics.Windows.Controls.CarouselViewSettings viewSettings = this.ViewSettings;
				if (viewSettings == null)
				{
					if (this._designTimeDefaultViewSettings == null)
					{
						this._designTimeDefaultViewSettings = new global::Infragistics.Windows.Controls.CarouselViewSettings();
					}
					return this._designTimeDefaultViewSettings;
				}
				return viewSettings;
			}
		}

		// Token: 0x17000513 RID: 1299
		// (get) Token: 0x06001694 RID: 5780 RVA: 0x000574DA File Offset: 0x000556DA
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		protected bool ItemsHostSupportsSelection
		{
			get
			{
				return this.SelectionHost != null;
			}
		}

		// Token: 0x17000514 RID: 1300
		// (get) Token: 0x06001695 RID: 5781 RVA: 0x000574E8 File Offset: 0x000556E8
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		protected internal global::Infragistics.Windows.Controls.CarouselPanelAdorner CarouselPanelAdorner
		{
			get
			{
				return this._carouselPanelAdorner;
			}
		}

		// Token: 0x17000515 RID: 1301
		// (get) Token: 0x06001696 RID: 5782 RVA: 0x000574F0 File Offset: 0x000556F0
		protected virtual long CurrentState
		{
			get
			{
				long num = 0L;
				if (this.CanNavigateToNextItem)
				{
					num |= 1L;
				}
				if (this.CanNavigateToPreviousItem)
				{
					num |= 2L;
				}
				if (this.CanNavigateToNextPage)
				{
					num |= 4L;
				}
				if (this.CanNavigateToPreviousPage)
				{
					num |= 8L;
				}
				return num;
			}
		}

		// Token: 0x17000516 RID: 1302
		// (get) Token: 0x06001697 RID: 5783 RVA: 0x00057535 File Offset: 0x00055735
		// (set) Token: 0x06001698 RID: 5784 RVA: 0x0005753D File Offset: 0x0005573D
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		protected double ScrollOffsetForInitialArrangeAnimation
		{
			get
			{
				return this._scrollOffsetForInitialArrangeAnimation;
			}
			set
			{
				this._scrollOffsetForInitialArrangeAnimation = value;
			}
		}

		// Token: 0x17000517 RID: 1303
		// (get) Token: 0x06001699 RID: 5785 RVA: 0x00057546 File Offset: 0x00055746
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		protected bool ScrollInProgress
		{
			get
			{
				return !this._scrollActionInfo.IsEmpty;
			}
		}

		// Token: 0x17000518 RID: 1304
		// (get) Token: 0x0600169A RID: 5786 RVA: 0x00057556 File Offset: 0x00055756
		// (set) Token: 0x0600169B RID: 5787 RVA: 0x0005755E File Offset: 0x0005575E
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		protected bool ShouldGenerateElements
		{
			get
			{
				return this._shouldGenerateElements;
			}
			set
			{
				this._shouldGenerateElements = value;
			}
		}

		// Token: 0x17000519 RID: 1305
		// (get) Token: 0x0600169C RID: 5788 RVA: 0x00057567 File Offset: 0x00055767
		protected int TotalItemCount
		{
			get
			{
				if (!base.IsItemsHost)
				{
					return base.InternalChildren.Count;
				}
				return base.ItemsControl.Items.Count;
			}
		}

		// Token: 0x1700051A RID: 1306
		// (get) Token: 0x0600169D RID: 5789 RVA: 0x00057590 File Offset: 0x00055790
		private static global::System.Windows.Media.PathGeometry ArcPath
		{
			get
			{
				global::System.Windows.Media.PathGeometry pathGeometry = new global::System.Windows.Media.PathGeometry();
				global::System.Windows.Rect rect = new global::System.Windows.Rect(0.0, 0.0, 1.0, 1.0);
				global::System.Windows.Media.PathFigure pathFigure = new global::System.Windows.Media.PathFigure();
				pathFigure.StartPoint = rect.Location;
				pathFigure.Segments.Add(new global::System.Windows.Media.ArcSegment(rect.TopRight, new global::System.Windows.Size(rect.Width / 2.0, rect.Height), 180.0, false, global::System.Windows.Media.SweepDirection.Counterclockwise, false));
				pathGeometry.Figures.Add(pathFigure);
				return pathGeometry;
			}
		}

		// Token: 0x1700051B RID: 1307
		// (get) Token: 0x0600169E RID: 5790 RVA: 0x0005762E File Offset: 0x0005582E
		private global::Infragistics.Windows.Controls.CarouselPanelNavigator CarouselPanelNavigator
		{
			get
			{
				if (this._carouselPanelNavigator == null)
				{
					this._carouselPanelNavigator = new global::Infragistics.Windows.Controls.CarouselPanelNavigator(this);
					if (global::System.Windows.LogicalTreeHelper.GetParent(this._carouselPanelNavigator) == null)
					{
						base.AddLogicalChild(this._carouselPanelNavigator);
					}
					this.BindNavigatorVisibility();
				}
				return this._carouselPanelNavigator;
			}
		}

		// Token: 0x1700051C RID: 1308
		// (get) Token: 0x0600169F RID: 5791 RVA: 0x0005766C File Offset: 0x0005586C
		private global::Infragistics.Windows.Controls.ScalingEffectStopCollection DefaultScalingEffectStops
		{
			get
			{
				if (this._defaultScalingEffectStops == null)
				{
					this._defaultScalingEffectStops = new global::Infragistics.Windows.Controls.ScalingEffectStopCollection();
					this._defaultScalingEffectStops.Add(new global::Infragistics.Windows.Controls.ScalingEffectStop(0.0, 1.0));
					this._defaultScalingEffectStops.Add(new global::Infragistics.Windows.Controls.ScalingEffectStop(1.0, 1.0));
				}
				return this._defaultScalingEffectStops;
			}
		}

		// Token: 0x1700051D RID: 1309
		// (get) Token: 0x060016A0 RID: 5792 RVA: 0x000576D8 File Offset: 0x000558D8
		private global::Infragistics.Windows.Controls.SkewAngleXEffectStopCollection DefaultSkewAngleXEffectStops
		{
			get
			{
				if (this._defaultSkewAngleXEffectStops == null)
				{
					this._defaultSkewAngleXEffectStops = new global::Infragistics.Windows.Controls.SkewAngleXEffectStopCollection();
					this._defaultSkewAngleXEffectStops.Add(new global::Infragistics.Windows.Controls.SkewAngleXEffectStop(0.0, 0.0));
					this._defaultSkewAngleXEffectStops.Add(new global::Infragistics.Windows.Controls.SkewAngleXEffectStop(1.0, 0.0));
				}
				return this._defaultSkewAngleXEffectStops;
			}
		}

		// Token: 0x1700051E RID: 1310
		// (get) Token: 0x060016A1 RID: 5793 RVA: 0x00057744 File Offset: 0x00055944
		private global::Infragistics.Windows.Controls.SkewAngleYEffectStopCollection DefaultSkewAngleYEffectStops
		{
			get
			{
				if (this._defaultSkewAngleYEffectStops == null)
				{
					this._defaultSkewAngleYEffectStops = new global::Infragistics.Windows.Controls.SkewAngleYEffectStopCollection();
					this._defaultSkewAngleYEffectStops.Add(new global::Infragistics.Windows.Controls.SkewAngleYEffectStop(0.0, 0.0));
					this._defaultSkewAngleYEffectStops.Add(new global::Infragistics.Windows.Controls.SkewAngleYEffectStop(1.0, 0.0));
				}
				return this._defaultSkewAngleYEffectStops;
			}
		}

		// Token: 0x1700051F RID: 1311
		// (get) Token: 0x060016A2 RID: 5794 RVA: 0x000577B0 File Offset: 0x000559B0
		private global::Infragistics.Windows.Controls.OpacityEffectStopCollection DefaultOpacityEffectStops
		{
			get
			{
				if (this._defaultOpacityEffectStops == null)
				{
					this._defaultOpacityEffectStops = new global::Infragistics.Windows.Controls.OpacityEffectStopCollection();
					this._defaultOpacityEffectStops.Add(new global::Infragistics.Windows.Controls.OpacityEffectStop(0.0, 1.0));
					this._defaultOpacityEffectStops.Add(new global::Infragistics.Windows.Controls.OpacityEffectStop(1.0, 1.0));
				}
				return this._defaultOpacityEffectStops;
			}
		}

		// Token: 0x17000520 RID: 1312
		// (get) Token: 0x060016A3 RID: 5795 RVA: 0x0005781C File Offset: 0x00055A1C
		private global::Infragistics.Windows.Controls.ZOrderEffectStopCollection DefaultZOrderEffectStops
		{
			get
			{
				if (this._defaultZOrderEffectStops == null)
				{
					this._defaultZOrderEffectStops = new global::Infragistics.Windows.Controls.ZOrderEffectStopCollection();
					this._defaultZOrderEffectStops.Add(new global::Infragistics.Windows.Controls.ZOrderEffectStop(0.0, 0.0));
					this._defaultZOrderEffectStops.Add(new global::Infragistics.Windows.Controls.ZOrderEffectStop(1.0, 1.0));
				}
				return this._defaultZOrderEffectStops;
			}
		}

		// Token: 0x17000521 RID: 1313
		// (get) Token: 0x060016A4 RID: 5796 RVA: 0x00057888 File Offset: 0x00055A88
		private static global::System.Windows.Media.PathGeometry DiagonalPath
		{
			get
			{
				global::System.Windows.Media.PathGeometry pathGeometry = new global::System.Windows.Media.PathGeometry();
				new global::System.Windows.Rect(0.0, 0.0, 1.0, 1.0);
				global::System.Windows.Point startPoint = new global::System.Windows.Point(0.0, 0.0);
				global::System.Windows.Point point = new global::System.Windows.Point(1.0, 1.0);
				global::System.Windows.Media.PathFigure pathFigure = new global::System.Windows.Media.PathFigure();
				pathFigure.StartPoint = startPoint;
				pathFigure.Segments.Add(new global::System.Windows.Media.LineSegment(point, false));
				pathGeometry.Figures.Add(pathFigure);
				return pathGeometry;
			}
		}

		// Token: 0x17000522 RID: 1314
		// (get) Token: 0x060016A5 RID: 5797 RVA: 0x00057924 File Offset: 0x00055B24
		private static global::System.Windows.Media.PathGeometry EllipsePath
		{
			get
			{
				global::System.Windows.Media.PathGeometry pathGeometry = new global::System.Windows.Media.PathGeometry();
				global::System.Windows.Rect rect = new global::System.Windows.Rect(0.0, 0.0, 1.0, 1.0);
				global::System.Windows.Media.PathFigure pathFigure = new global::System.Windows.Media.PathFigure();
				pathFigure.StartPoint = new global::System.Windows.Point(0.5, 0.0);
				pathFigure.Segments.Add(new global::System.Windows.Media.ArcSegment(new global::System.Windows.Point(0.50001, 0.0), new global::System.Windows.Size(rect.Width / 2.0, rect.Height / 2.0), 360.0, true, global::System.Windows.Media.SweepDirection.Counterclockwise, true));
				pathGeometry.Figures.Add(pathFigure);
				return pathGeometry;
			}
		}

		// Token: 0x17000523 RID: 1315
		// (get) Token: 0x060016A6 RID: 5798 RVA: 0x000579EC File Offset: 0x00055BEC
		private double HighestPossibleScrollOffset
		{
			get
			{
				return this.ScrollingData._extent.Height - 1.0;
			}
		}

		// Token: 0x17000524 RID: 1316
		// (get) Token: 0x060016A7 RID: 5799 RVA: 0x00057A08 File Offset: 0x00055C08
		private bool IsEntireListVisible
		{
			get
			{
				return this.TotalItemCount <= this.ItemsPerPageResolved;
			}
		}

		// Token: 0x17000525 RID: 1317
		// (get) Token: 0x060016A8 RID: 5800 RVA: 0x00057A1C File Offset: 0x00055C1C
		private global::System.Windows.Media.PathGeometry ItemPathGeometry
		{
			get
			{
				if (this._itemPathGeometry == null)
				{
					global::System.Windows.Shapes.Shape itemPath = this.ViewSettingsInternal.ItemPath;
					if (itemPath is global::System.Windows.Shapes.Path)
					{
						global::System.Windows.Shapes.Path path = itemPath as global::System.Windows.Shapes.Path;
						if (path.Data != null && !path.Data.IsEmpty())
						{
							this._itemPathGeometry = global::System.Windows.Media.PathGeometry.CreateFromGeometry(path.Data);
						}
					}
					if (this._itemPathGeometry == null && itemPath != null && itemPath.RenderedGeometry != null && !itemPath.RenderedGeometry.IsEmpty())
					{
						this._itemPathGeometry = global::System.Windows.Media.PathGeometry.CreateFromGeometry(itemPath.RenderedGeometry);
					}
					if (this._itemPathGeometry == null)
					{
						this._itemPathGeometry = global::Infragistics.Windows.Controls.XamCarouselPanel.EllipsePath.Clone();
					}
				}
				return this._itemPathGeometry;
			}
		}

		// Token: 0x17000526 RID: 1318
		// (get) Token: 0x060016A9 RID: 5801 RVA: 0x00057AC4 File Offset: 0x00055CC4
		private int LastVisibleItemIndex
		{
			get
			{
				return this.GetLastVisibleItemIndex(this.FirstVisibleItemIndex);
			}
		}

		// Token: 0x17000527 RID: 1319
		// (get) Token: 0x060016AA RID: 5802 RVA: 0x00057AD2 File Offset: 0x00055CD2
		private double LowestPossibleScrollOffset
		{
			get
			{
				return 0.0 - (this.ScrollingData._viewport.Height - 1.0);
			}
		}

		// Token: 0x17000528 RID: 1320
		// (get) Token: 0x060016AB RID: 5803 RVA: 0x00057AF8 File Offset: 0x00055CF8
		private global::System.Collections.Generic.Dictionary<double, global::Infragistics.Windows.Controls.XamCarouselPanel.PathFractionPoint> PathFractionPointsCache
		{
			get
			{
				if (this._pathFractionPointsCache == null)
				{
					this._pathFractionPointsCache = new global::System.Collections.Generic.Dictionary<double, global::Infragistics.Windows.Controls.XamCarouselPanel.PathFractionPoint>(10);
				}
				return this._pathFractionPointsCache;
			}
		}

		// Token: 0x17000529 RID: 1321
		// (get) Token: 0x060016AC RID: 5804 RVA: 0x00057B18 File Offset: 0x00055D18
		private static global::System.Windows.Media.PathGeometry RectPath
		{
			get
			{
				global::System.Windows.Media.PathGeometry pathGeometry = new global::System.Windows.Media.PathGeometry();
				global::System.Windows.Rect rect = new global::System.Windows.Rect(0.0, 0.0, 1.0, 1.0);
				pathGeometry.AddGeometry(new global::System.Windows.Media.RectangleGeometry(rect));
				return pathGeometry;
			}
		}

		// Token: 0x1700052A RID: 1322
		// (get) Token: 0x060016AD RID: 5805 RVA: 0x00057B63 File Offset: 0x00055D63
		private double[] VisiblePositionPercentLocations
		{
			get
			{
				if (this._visiblePositionPercentValues.Length != this.ItemsPerPageResolved)
				{
					this._visiblePositionPercentValuesDirty = true;
				}
				this.RecalculateVisiblePositionPercentValues();
				return this._visiblePositionPercentValues;
			}
		}

		// Token: 0x1700052B RID: 1323
		// (get) Token: 0x060016AE RID: 5806 RVA: 0x00057B88 File Offset: 0x00055D88
		private global::System.Windows.Size WrapperSize
		{
			get
			{
				if (this._wrapperSizeDirty)
				{
					global::Infragistics.Windows.Controls.CarouselViewSettings viewSettingsInternal = this.ViewSettingsInternal;
					this._wrapperSize = new global::System.Windows.Size(viewSettingsInternal.ItemSize.Width, viewSettingsInternal.ReserveSpaceForReflections ? (viewSettingsInternal.ItemSize.Height * 2.0) : viewSettingsInternal.ItemSize.Height);
					this._wrapperSizeDirty = false;
				}
				return this._wrapperSize;
			}
		}

		// Token: 0x060016AF RID: 5807 RVA: 0x00057BFC File Offset: 0x00055DFC
		public bool EnsureItemIsVisible(int itemIndex)
		{
			if (itemIndex < 0 || itemIndex > this.TotalItemCount - 1)
			{
				throw new global::System.ArgumentException(global::SR.GetString("LE_ArgumentException_10"));
			}
			if (this.GetIsItemIndexVisible(itemIndex, this.FirstVisibleItemIndex))
			{
				return false;
			}
			if (itemIndex < this.FirstVisibleItemIndex)
			{
				this.SetVerticalOffset((double)itemIndex);
				return true;
			}
			this.SetVerticalOffset((double)this.FirstVisibleItemIndexFromLastVisibleItemIndex(itemIndex));
			return true;
		}

		// Token: 0x060016B0 RID: 5808 RVA: 0x00057C5B File Offset: 0x00055E5B
		public bool ExecuteCommand(global::Infragistics.Windows.Commands.CommandWrapper commandWrapper)
		{
			if (commandWrapper == null)
			{
				throw new global::System.ArgumentNullException("commandWrapper");
			}
			return this.ExecuteCommand(commandWrapper.Command);
		}

		// Token: 0x060016B1 RID: 5809 RVA: 0x00057C78 File Offset: 0x00055E78
		public bool ExecuteCommand(global::System.Windows.Input.RoutedCommand command)
		{
			if (!global::Infragistics.Windows.Commands.Commands<global::Infragistics.Windows.Controls.XamCarouselPanel>.IsMinimumStatePresentForCommand(this, command))
			{
				return false;
			}
			global::Infragistics.Windows.Controls.Events.ExecutingCommandEventArgs executingCommandEventArgs = new global::Infragistics.Windows.Controls.Events.ExecutingCommandEventArgs(command);
			if (!this.RaiseExecutingCommand(executingCommandEventArgs))
			{
				return !executingCommandEventArgs.ContinueKeyRouting;
			}
			bool flag = false;
			if (command == global::Infragistics.Windows.Controls.XamCarouselPanelCommands.NavigateToNextItem)
			{
				this.LineRight();
				flag = true;
			}
			else if (command == global::Infragistics.Windows.Controls.XamCarouselPanelCommands.NavigateToPreviousItem)
			{
				this.LineLeft();
				flag = true;
			}
			else if (command == global::Infragistics.Windows.Controls.XamCarouselPanelCommands.NavigateToNextPage)
			{
				this.PageDown();
				flag = true;
			}
			else if (command == global::Infragistics.Windows.Controls.XamCarouselPanelCommands.NavigateToPreviousPage)
			{
				this.PageUp();
				flag = true;
			}
			if (flag)
			{
				this.RaiseExecutedCommand(new global::Infragistics.Windows.Controls.Events.ExecutedCommandEventArgs(command));
			}
			return flag;
		}

		// Token: 0x060016B2 RID: 5810 RVA: 0x00057D04 File Offset: 0x00055F04
		private void ApplyEffectsToItem(global::Infragistics.Windows.Controls.CarouselPanelItem item, double currentPct, global::System.Windows.Point itemTangentPoint)
		{
			if (item == null)
			{
				return;
			}
			global::System.Windows.Media.Matrix identity = global::System.Windows.Media.Matrix.Identity;
			double num = 1.0;
			global::System.Windows.Rect rect = new global::System.Windows.Rect(new global::System.Windows.Point(0.0, 0.0), this._previousArrangeSize);
			global::Infragistics.Windows.Controls.CarouselViewSettings viewSettingsInternal = this.ViewSettingsInternal;
			global::System.Windows.Point currentLocation = item.CurrentLocation;
			if (viewSettingsInternal.UseScaling)
			{
				global::Infragistics.Windows.Controls.EffectStopDirection scalingEffectStopDirectionResolved = this.ScalingEffectStopDirectionResolved;
				if (scalingEffectStopDirectionResolved == global::Infragistics.Windows.Controls.EffectStopDirection.Vertical)
				{
					num = this.ScalingEffectStopsResolved.GetStopValueFromRange(rect.Top, rect.Bottom, currentLocation.Y);
				}
				else if (scalingEffectStopDirectionResolved == global::Infragistics.Windows.Controls.EffectStopDirection.Horizontal)
				{
					num = this.ScalingEffectStopsResolved.GetStopValueFromRange(rect.Left, rect.Right, currentLocation.X);
				}
				else
				{
					num = this.ScalingEffectStopsResolved.GetStopValueFromOffset(currentPct);
				}
				identity.M11 = (identity.M22 = num);
			}
			double num2 = 1.0;
			if (viewSettingsInternal.UseOpacity)
			{
				global::Infragistics.Windows.Controls.EffectStopDirection opacityEffectStopDirectionResolved = this.OpacityEffectStopDirectionResolved;
				if (opacityEffectStopDirectionResolved == global::Infragistics.Windows.Controls.EffectStopDirection.Vertical)
				{
					num2 = this.OpacityEffectStopsResolved.GetStopValueFromRange(rect.Top, rect.Bottom, currentLocation.Y);
				}
				else if (opacityEffectStopDirectionResolved == global::Infragistics.Windows.Controls.EffectStopDirection.Horizontal)
				{
					num2 = this.OpacityEffectStopsResolved.GetStopValueFromRange(rect.Left, rect.Right, currentLocation.X);
				}
				else
				{
					num2 = this.OpacityEffectStopsResolved.GetStopValueFromOffset(currentPct);
				}
			}
			double num3 = 1.0;
			bool flag = false;
			bool flag2;
			if (flag2 = this.InPathPrefixArea(currentPct, viewSettingsInternal))
			{
				num3 = this.GetPrefixAreaPenetrationPercent(currentPct, viewSettingsInternal);
			}
			else if (flag = this.InPathSuffixArea(currentPct, viewSettingsInternal))
			{
				num3 = this.GetSuffixAreaPenetrationPercent(currentPct, viewSettingsInternal);
			}
			if (num3 == 0.0)
			{
				identity.OffsetX = -10000.0;
				identity.OffsetY = -10000.0;
			}
			else
			{
				identity.OffsetX = currentLocation.X;
				identity.OffsetY = currentLocation.Y;
			}
			global::System.Windows.Size itemSize = viewSettingsInternal.ItemSize;
			identity.OffsetX -= itemSize.Width * num / 2.0;
			identity.OffsetY -= itemSize.Height * num / 2.0;
			if (viewSettingsInternal.RotateItemsWithPathTangent)
			{
				identity.RotateAt(global::Infragistics.Windows.Controls.XamCarouselPanel.CalculateRotationFromTangentPoint(itemTangentPoint), currentLocation.X, currentLocation.Y);
			}
			if ((viewSettingsInternal.ItemTransitionStyle & global::Infragistics.Windows.Controls.PathItemTransitionStyle.AdjustOpacity) != (global::Infragistics.Windows.Controls.PathItemTransitionStyle)0 && (flag2 || flag))
			{
				if (item.Opacity != num2 * num3)
				{
					item.Opacity = num2 * num3;
				}
			}
			else if (item.Opacity != num2)
			{
				item.Opacity = num2;
			}
			if ((viewSettingsInternal.ItemTransitionStyle & global::Infragistics.Windows.Controls.PathItemTransitionStyle.AdjustSize) != (global::Infragistics.Windows.Controls.PathItemTransitionStyle)0 && (flag2 || flag))
			{
				identity.M11 = (identity.M22 = identity.M11 * num3);
			}
			double newSkewAngleX = 0.0;
			double newSkewAngleY = 0.0;
			if (viewSettingsInternal.UseSkewing)
			{
				if (this.SkewAngleXEffectStopDirectionResolved == global::Infragistics.Windows.Controls.EffectStopDirection.Vertical)
				{
					newSkewAngleX = this.SkewAngleXEffectStopsResolved.GetStopValueFromRange(rect.Top, rect.Bottom, currentLocation.Y);
				}
				else if (this.SkewAngleXEffectStopDirectionResolved == global::Infragistics.Windows.Controls.EffectStopDirection.Horizontal)
				{
					newSkewAngleX = this.SkewAngleXEffectStopsResolved.GetStopValueFromRange(rect.Left, rect.Right, currentLocation.X);
				}
				else
				{
					newSkewAngleX = this.SkewAngleXEffectStopsResolved.GetStopValueFromOffset(currentPct);
				}
				if (this.SkewAngleYEffectStopDirectionResolved == global::Infragistics.Windows.Controls.EffectStopDirection.Vertical)
				{
					newSkewAngleY = this.SkewAngleYEffectStopsResolved.GetStopValueFromRange(rect.Top, rect.Bottom, currentLocation.Y);
				}
				else if (this.SkewAngleYEffectStopDirectionResolved == global::Infragistics.Windows.Controls.EffectStopDirection.Horizontal)
				{
					newSkewAngleY = this.SkewAngleYEffectStopsResolved.GetStopValueFromRange(rect.Left, rect.Right, currentLocation.X);
				}
				else
				{
					newSkewAngleY = this.SkewAngleYEffectStopsResolved.GetStopValueFromOffset(currentPct);
				}
			}
			item.UpdateTransforms(identity, newSkewAngleX, newSkewAngleY, itemSize.Width / 2.0, itemSize.Height / 2.0);
		}

		// Token: 0x060016B3 RID: 5811 RVA: 0x000580DC File Offset: 0x000562DC
		private void BindNavigatorVisibility()
		{
			if (this._carouselPanelNavigator != null)
			{
				global::System.Windows.Data.Binding binding = new global::System.Windows.Data.Binding();
				binding.Mode = global::System.Windows.Data.BindingMode.OneWay;
				binding.Source = this.ViewSettingsInternal;
				binding.Path = new global::System.Windows.PropertyPath(global::Infragistics.Windows.Controls.CarouselViewSettings.IsNavigatorVisibleProperty);
				binding.Converter = new global::System.Windows.Controls.BooleanToVisibilityConverter();
				this._carouselPanelNavigator.SetBinding(global::System.Windows.UIElement.VisibilityProperty, binding);
			}
		}

		// Token: 0x060016B4 RID: 5812 RVA: 0x00058137 File Offset: 0x00056337
		private void BumpCarouselViewSettingsVersion()
		{
			base.SetValue(global::Infragistics.Windows.Controls.XamCarouselPanel.ViewSettingsVersionProperty, (int)base.GetValue(global::Infragistics.Windows.Controls.XamCarouselPanel.ViewSettingsVersionProperty) + 1);
		}

		// Token: 0x060016B5 RID: 5813 RVA: 0x0005815C File Offset: 0x0005635C
		private double CalculateChildTargetPct(int childIndex, int childsItemIndex, int scrollOffset, bool itemVisibleBeforeScroll, bool itemVisibleAfterScroll)
		{
			global::Infragistics.Windows.Controls.CarouselViewSettings viewSettingsInternal = this.ViewSettingsInternal;
			double result;
			if (this.GetShouldPositionItemAtBeginningOfPath(childsItemIndex, scrollOffset, itemVisibleBeforeScroll, itemVisibleAfterScroll))
			{
				result = 0.0;
			}
			else if (this.GetShouldPositionItemAtEndOfPath(childsItemIndex, scrollOffset, itemVisibleBeforeScroll, itemVisibleAfterScroll))
			{
				result = 1.0;
			}
			else
			{
				int visiblePositionFromItemIndex = this.GetVisiblePositionFromItemIndex(childsItemIndex, scrollOffset);
				if (visiblePositionFromItemIndex < 0)
				{
					global::Infragistics.Windows.Controls.CarouselPanelItem carouselPanelItem = base.ChildElements[childIndex] as global::Infragistics.Windows.Controls.CarouselPanelItem;
					if (carouselPanelItem == null)
					{
						result = 1.0;
					}
					else if (carouselPanelItem.PathLocationPercent == 0.0)
					{
						result = 0.0;
					}
					else if (carouselPanelItem.PathLocationPercent == 1.0)
					{
						result = 1.0;
					}
					else if (carouselPanelItem.PathLocationPercent < 1.0 - carouselPanelItem.PathLocationPercent)
					{
						result = 0.0;
					}
					else
					{
						result = 1.0;
					}
				}
				else if (visiblePositionFromItemIndex == 0)
				{
					result = viewSettingsInternal.ItemPathPrefixPercent;
				}
				else if (visiblePositionFromItemIndex == this.ItemsPerPageResolved - 1)
				{
					result = 1.0 - viewSettingsInternal.ItemPathSuffixPercent;
				}
				else
				{
					result = this.VisiblePositionPercentLocations[visiblePositionFromItemIndex];
				}
			}
			return result;
		}

		// Token: 0x060016B6 RID: 5814 RVA: 0x0005828C File Offset: 0x0005648C
		private static double CalculateRotationFromTangentPoint(global::System.Windows.Point tangentPoint)
		{
			double num = global::System.Math.Acos(tangentPoint.X) * 57.29577951308232;
			if (tangentPoint.Y < 0.0)
			{
				num = 360.0 - num;
			}
			return num;
		}

		// Token: 0x060016B7 RID: 5815 RVA: 0x000582D0 File Offset: 0x000564D0
		private void CompositionTarget_Rendering(object sender, global::System.EventArgs e)
		{
			if (!base.IsInitialized || this._previousMeasureSize == global::System.Windows.Size.Empty || (this._previousMeasureSize.Width == 0.0 && this._previousMeasureSize.Height == 0.0))
			{
				return;
			}
			long ticks = global::System.DateTime.Now.Ticks;
			long val = ticks - this._previousTick;
			double num = global::Infragistics.Windows.Controls.XamCarouselPanel.SecondsFromTicks(global::System.Math.Min(400000L, val));
			this._previousTick = ticks;
			double num2 = 1.0 / num;
			if (num2 > this._smoothedFrameRate)
			{
				if ((num2 - this._smoothedFrameRate) / this._smoothedFrameRate > 0.05)
				{
					this._smoothedFrameRate *= 1.05;
				}
				else
				{
					this._smoothedFrameRate = num2;
				}
			}
			else if ((this._smoothedFrameRate - num2) / this._smoothedFrameRate > 0.05)
			{
				this._smoothedFrameRate *= 0.95;
			}
			else
			{
				this._smoothedFrameRate = num2;
			}
			bool flag = false;
			bool scrollInProgress = this.ScrollInProgress;
			bool scrollingHigher = this._scrollActionInfo.ScrollingHigher;
			global::System.Collections.IList childElements = base.ChildElements;
			int count = childElements.Count;
			global::Infragistics.Windows.Controls.CarouselViewSettings viewSettingsInternal = this.ViewSettingsInternal;
			double attractionFactor = 7.0 * (30.0 / this._smoothedFrameRate);
			for (int i = 0; i < count; i++)
			{
				if (childElements[i] is global::Infragistics.Windows.Controls.CarouselPanelItem && global::Infragistics.Windows.Controls.XamCarouselPanel.UpdateElementPosition(childElements[i] as global::Infragistics.Windows.Controls.CarouselPanelItem, num, 0.0, attractionFactor, scrollInProgress, scrollingHigher))
				{
					flag = true;
				}
			}
			if (!flag && this.ScrollInProgress)
			{
				this.StopAnimatedScrollProcessing();
				return;
			}
			if (flag)
			{
				this.DoArrangeProcessing(this._previousArrangeSize, false);
			}
		}

		// Token: 0x060016B8 RID: 5816 RVA: 0x00058498 File Offset: 0x00056698
		private void DoArrangeProcessing(global::System.Windows.Size finalSize, bool forceArrangeOfAllItems)
		{
			this._previousArrangeSize = finalSize;
			global::System.Windows.Size wrapperSize = this.WrapperSize;
			global::Infragistics.Windows.Controls.CarouselViewSettings viewSettingsInternal = this.ViewSettingsInternal;
			int num = 0;
			int totalItemCount = this.TotalItemCount;
			int itemsPerPageResolved = this.ItemsPerPageResolved;
			if (base.IsItemsHost && this.ShouldGenerateElements)
			{
				num = this.GenerateElementsHelper((int)this.ScrollingData._offset.Y, itemsPerPageResolved, null, 0);
				if (num > 0 && totalItemCount > 0)
				{
					this.ShouldGenerateElements = false;
				}
			}
			if (!this.ScrollInProgress)
			{
				this.RecalculateCurrentItemLocations();
			}
			bool flag = viewSettingsInternal.ShouldScrollItemsIntoInitialPosition && ((base.IsItemsHost && num > 0) || !base.IsItemsHost);
			global::System.Collections.IList childElements = base.ChildElements;
			int count = childElements.Count;
			if (count < 1)
			{
				return;
			}
			int num2 = base.GetItemIndexFromChildIndex(0);
			if (base.IsItemsHost)
			{
				int childrenCount = global::System.Windows.Media.VisualTreeHelper.GetChildrenCount(this);
				for (int i = 0; i < childrenCount; i++)
				{
					global::System.Windows.UIElement uielement = global::System.Windows.Media.VisualTreeHelper.GetChild(this, i) as global::System.Windows.UIElement;
					if (uielement != null && !childElements.Contains(uielement))
					{
						uielement.Opacity = 0.0;
					}
				}
			}
			int j = 0;
			while (j < count)
			{
				global::Infragistics.Windows.Controls.CarouselPanelItem carouselPanelItem = childElements[j] as global::Infragistics.Windows.Controls.CarouselPanelItem;
				if (carouselPanelItem == null)
				{
					throw new global::System.NotSupportedException(global::SR.GetString("LE_NotSupportedException_12"));
				}
				if (flag && !this._initialArrangeAnimationDone)
				{
					carouselPanelItem.PathLocationPercent = 0.0;
				}
				else if (carouselPanelItem.IsPathLocationUnset)
				{
					int num3 = j - this.FirstVisibleChildIndex;
					if (num3 >= 0 && num3 < itemsPerPageResolved)
					{
						carouselPanelItem.PathLocationPercent = this.VisiblePositionPercentLocations[num3];
					}
					else
					{
						carouselPanelItem.PathLocationPercent = 0.0;
					}
				}
				double pathLocationPercent = carouselPanelItem.PathLocationPercent;
				global::System.Windows.Point point = new global::System.Windows.Point(0.0, 0.0);
				global::System.Windows.Point point2 = new global::System.Windows.Point(0.0, 0.0);
				try
				{
					double num4 = global::System.Math.Round(pathLocationPercent, 4);
					if (this.PathFractionPointsCache.ContainsKey(num4))
					{
						global::Infragistics.Windows.Controls.XamCarouselPanel.PathFractionPoint value = this.PathFractionPointsCache[num4];
						point = value.Point;
						point2 = value.TangentPoint;
					}
					else
					{
						this.ItemPathGeometry.GetPointAtFractionLength(num4, out point, out point2);
						global::Infragistics.Windows.Controls.XamCarouselPanel.PathFractionPoint value = new global::Infragistics.Windows.Controls.XamCarouselPanel.PathFractionPoint(point, point2);
						this.PathFractionPointsCache.Add(num4, value);
					}
				}
				catch (global::System.Exception)
				{
					point = carouselPanelItem.CurrentLocation;
				}
				carouselPanelItem.Width = wrapperSize.Width;
				carouselPanelItem.Height = wrapperSize.Height;
				if (!carouselPanelItem.IsMeasureValid)
				{
					carouselPanelItem.Measure(new global::System.Windows.Size(double.PositiveInfinity, double.PositiveInfinity));
				}
				if (carouselPanelItem.NeedsArrange || !carouselPanelItem.IsArrangeValid)
				{
					carouselPanelItem.Arrange(new global::System.Windows.Rect(new global::System.Windows.Point(0.0, 0.0), wrapperSize));
					carouselPanelItem.NeedsArrange = false;
				}
				global::Infragistics.Windows.Controls.XamCarouselPanel.UpdateFirstAndLastItemPropertiesOnChild(carouselPanelItem, num2, totalItemCount);
				carouselPanelItem.CurrentLocation = point;
				this.ApplyEffectsToItem(carouselPanelItem, pathLocationPercent, point2);
				j++;
				num2++;
			}
			if (flag && !this._initialArrangeAnimationDone && count > 0)
			{
				double num5 = this.ScrollOffsetForInitialArrangeAnimation + global::System.Math.Max(global::System.Math.Min((double)count - 1.0, (double)(itemsPerPageResolved - 1)), 1.0);
				this.ScrollingData._offset = new global::System.Windows.Vector(num5, num5);
				base.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.ContextIdle, new global::Infragistics.Windows.Controls.XamCarouselPanel.MethodDelegate(this.PerformInitialArrangeAnimation));
			}
			this.SetZOrder();
		}

		// Token: 0x060016B9 RID: 5817 RVA: 0x00058830 File Offset: 0x00056A30
		private int FirstVisibleItemIndexFromLastVisibleItemIndex(int lastVisibleItemIndex)
		{
			global::Infragistics.Windows.Controls.CarouselViewSettings viewSettingsInternal = this.ViewSettingsInternal;
			int num = lastVisibleItemIndex - this.ItemsPerPageResolved + 1;
			if (!viewSettingsInternal.IsListContinuous)
			{
				return global::System.Math.Max(0, num);
			}
			if (num >= 0)
			{
				return num;
			}
			int num2 = global::System.Math.Abs(num);
			return this.TotalItemCount - num2;
		}

		// Token: 0x060016BA RID: 5818 RVA: 0x00058874 File Offset: 0x00056A74
		private int GenerateElements(int firstItemIndexToGenerate, int totalElementsToGenerate)
		{
			if (!base.IsItemsHost)
			{
				return 0;
			}
			global::System.Windows.Controls.UIElementCollection internalChildren = base.InternalChildren;
			int num = 0;
			int num2 = firstItemIndexToGenerate;
			int num3 = 0;
			global::System.Windows.Controls.Primitives.GeneratorPosition generatorPositionFromItemIndex = this.GetGeneratorPositionFromItemIndex(firstItemIndexToGenerate, out num);
			global::System.Windows.Controls.Primitives.IItemContainerGenerator activeItemContainerGenerator = base.ActiveItemContainerGenerator;
			using (activeItemContainerGenerator.StartAt(generatorPositionFromItemIndex, global::System.Windows.Controls.Primitives.GeneratorDirection.Forward, true))
			{
				int totalItemCount = this.TotalItemCount;
				while (num2 < totalItemCount && num3 < totalElementsToGenerate)
				{
					if (num2 >= 0)
					{
						bool flag;
						global::System.Windows.UIElement uielement = activeItemContainerGenerator.GenerateNext(out flag) as global::System.Windows.UIElement;
						if (uielement == null)
						{
							break;
						}
						num3++;
						if (flag)
						{
							int index = num;
							if (num >= base.InternalChildren.Count)
							{
								base.AddInternalChild(uielement);
								index = this.VisualChildrenCount - 1;
							}
							else
							{
								base.InsertInternalChild(num, uielement);
							}
							activeItemContainerGenerator.PrepareItemContainer(uielement);
							this.OnNewElementRealized(uielement, index);
						}
					}
					num++;
					num2++;
				}
			}
			return num3;
		}

		// Token: 0x060016BB RID: 5819 RVA: 0x00058954 File Offset: 0x00056B54
		private int GenerateElementsHelper(int firstItemIndex1, int totalElements1, int? firstItemIndex2, int totalElements2)
		{
			global::Infragistics.Windows.Selection.ScrollDirection scrollDirection = global::Infragistics.Windows.Selection.ScrollDirection.Increment;
			if (this.ScrollInProgress)
			{
				scrollDirection = (this._scrollActionInfo.ScrollingHigher ? global::Infragistics.Windows.Selection.ScrollDirection.Increment : global::Infragistics.Windows.Selection.ScrollDirection.Decrement);
			}
			base.BeginGeneration(scrollDirection);
			int num = this.GenerateElementsHelperPrivate(firstItemIndex1, totalElements1);
			if (firstItemIndex2 != null)
			{
				num += this.GenerateElementsHelperPrivate(firstItemIndex2.Value, totalElements2);
			}
			base.EndGeneration();
			return num;
		}

		// Token: 0x060016BC RID: 5820 RVA: 0x000589B0 File Offset: 0x00056BB0
		private int GenerateElementsHelperPrivate(int firstItemIndexToGenerate, int totalElementsToGenerate)
		{
			if (!this.GetIsListWrapping(firstItemIndexToGenerate))
			{
				return this.GenerateElements(firstItemIndexToGenerate, totalElementsToGenerate);
			}
			int num = this.TotalItemCount - firstItemIndexToGenerate;
			int num2 = this.GenerateElements(firstItemIndexToGenerate, num);
			if (num2 < totalElementsToGenerate)
			{
				num2 += this.GenerateElements(0, this.ItemsPerPageResolved - num);
			}
			return num2;
		}

		// Token: 0x060016BD RID: 5821 RVA: 0x000589FC File Offset: 0x00056BFC
		private global::System.Windows.Controls.Primitives.GeneratorPosition GetGeneratorPositionFromItemIndex(int itemIndex, out int childIndex)
		{
			if (!base.IsItemsHost)
			{
				childIndex = 0;
				return new global::System.Windows.Controls.Primitives.GeneratorPosition(-1, itemIndex + 1);
			}
			global::System.Windows.Controls.UIElementCollection internalChildren = base.InternalChildren;
			global::System.Windows.Controls.Primitives.IItemContainerGenerator activeItemContainerGenerator = base.ActiveItemContainerGenerator;
			global::System.Windows.Controls.Primitives.GeneratorPosition result = (activeItemContainerGenerator != null) ? activeItemContainerGenerator.GeneratorPositionFromIndex(itemIndex) : new global::System.Windows.Controls.Primitives.GeneratorPosition(-1, itemIndex + 1);
			childIndex = ((result.Offset == 0) ? result.Index : (result.Index + 1));
			return result;
		}

		// Token: 0x060016BE RID: 5822 RVA: 0x00058A60 File Offset: 0x00056C60
		private bool GetIsItemIndexInLastVisiblePosition(int itemIndex, double scrollOffset)
		{
			int num = ((int)scrollOffset < 0) ? (itemIndex + global::System.Math.Abs((int)scrollOffset)) : (itemIndex - (int)scrollOffset);
			return num == this.ItemsPerPageResolved - 1;
		}

		// Token: 0x060016BF RID: 5823 RVA: 0x00058A90 File Offset: 0x00056C90
		private bool GetIsListWrapping(int scrollOffset)
		{
			global::Infragistics.Windows.Controls.CarouselViewSettings viewSettingsInternal = this.ViewSettingsInternal;
			if (!viewSettingsInternal.IsListContinuous)
			{
				return false;
			}
			int itemsPerPageResolved = this.ItemsPerPageResolved;
			if (this.TotalItemCount == itemsPerPageResolved)
			{
				return scrollOffset != 0 && scrollOffset % itemsPerPageResolved != 0;
			}
			return this.TotalItemCount >= itemsPerPageResolved && this.TotalItemCount - scrollOffset < itemsPerPageResolved;
		}

		// Token: 0x060016C0 RID: 5824 RVA: 0x00058AE0 File Offset: 0x00056CE0
		private int GetLastVisibleItemIndex(int scrollOffset)
		{
			return this.LastVisibleItemIndexFromFirstVisibleItemIndex(scrollOffset);
		}

		// Token: 0x060016C1 RID: 5825 RVA: 0x00058AE9 File Offset: 0x00056CE9
		private double GetPrefixAreaPenetrationPercent(double pathPositionPercentage, global::Infragistics.Windows.Controls.CarouselViewSettings viewSettings)
		{
			if (viewSettings.ItemPathPrefixPercent == 0.0)
			{
				return 0.0;
			}
			return pathPositionPercentage / viewSettings.ItemPathPrefixPercent;
		}

		// Token: 0x060016C2 RID: 5826 RVA: 0x00058B10 File Offset: 0x00056D10
		private bool GetShouldPositionItemAtEndOfPath(int itemIndex, int scrollOffset, bool itemVisibleBeforeScroll, bool itemVisibleAfterScroll)
		{
			global::Infragistics.Windows.Controls.CarouselViewSettings viewSettingsInternal = this.ViewSettingsInternal;
			if (!viewSettingsInternal.IsListContinuous)
			{
				return itemIndex >= scrollOffset + this.ItemsPerPageResolved;
			}
			if (this.GetIsItemIndexVisible(itemIndex, scrollOffset))
			{
				return false;
			}
			if (this.ScrollInProgress)
			{
				return !this._scrollActionInfo.ScrollingHigher && itemVisibleBeforeScroll && !itemVisibleAfterScroll;
			}
			return itemIndex > this.GetLastVisibleItemIndex(scrollOffset);
		}

		// Token: 0x060016C3 RID: 5827 RVA: 0x00058B74 File Offset: 0x00056D74
		private bool GetShouldPositionItemAtBeginningOfPath(int itemIndex, int scrollOffset, bool itemVisibleBeforeScroll, bool itemVisibleAfterScroll)
		{
			if (!this.ViewSettingsInternal.IsListContinuous)
			{
				return itemIndex < scrollOffset;
			}
			if (this.GetIsItemIndexVisible(itemIndex, scrollOffset))
			{
				return false;
			}
			if (this.ScrollInProgress)
			{
				return this._scrollActionInfo.ScrollingHigher && itemVisibleBeforeScroll && !itemVisibleAfterScroll;
			}
			return itemIndex < scrollOffset;
		}

		// Token: 0x060016C4 RID: 5828 RVA: 0x00058BC3 File Offset: 0x00056DC3
		private double GetSuffixAreaPenetrationPercent(double pathPositionPercentage, global::Infragistics.Windows.Controls.CarouselViewSettings viewSettings)
		{
			if (viewSettings.ItemPathSuffixPercent == 0.0)
			{
				return 0.0;
			}
			return (1.0 - pathPositionPercentage) / viewSettings.ItemPathSuffixPercent;
		}

		// Token: 0x060016C5 RID: 5829 RVA: 0x00058BF4 File Offset: 0x00056DF4
		private int GetVisiblePositionFromItemIndex(int itemIndex, int scrollOffset)
		{
			global::Infragistics.Windows.Controls.CarouselViewSettings viewSettingsInternal = this.ViewSettingsInternal;
			int itemsPerPageResolved = this.ItemsPerPageResolved;
			if (!this.GetIsListWrapping(scrollOffset))
			{
				int num = itemIndex - scrollOffset;
				if (num < 0 || num >= itemsPerPageResolved)
				{
					return -1;
				}
			}
			int num2 = this.TotalItemCount - scrollOffset;
			if (itemIndex >= scrollOffset && itemIndex < scrollOffset + num2)
			{
				return itemIndex - scrollOffset;
			}
			int num3 = num2 + base.GetChildIndexFromItemIndex(itemIndex);
			if (num3 >= itemsPerPageResolved)
			{
				return -1;
			}
			return num3;
		}

		// Token: 0x060016C6 RID: 5830 RVA: 0x00058C50 File Offset: 0x00056E50
		private void InitializeAdorner()
		{
			if (this._carouselPanelAdorner != null)
			{
				return;
			}
			this._carouselPanelAdorner = new global::Infragistics.Windows.Controls.CarouselPanelAdorner(this);
			global::System.Windows.Data.Binding binding = new global::System.Windows.Data.Binding();
			binding.Mode = global::System.Windows.Data.BindingMode.OneWay;
			binding.Source = this;
			binding.Path = new global::System.Windows.PropertyPath("IsVisible", new object[0]);
			binding.Converter = new global::System.Windows.Controls.BooleanToVisibilityConverter();
			this._carouselPanelAdorner.SetBinding(global::System.Windows.UIElement.VisibilityProperty, binding);
			binding = new global::System.Windows.Data.Binding();
			binding.Mode = global::System.Windows.Data.BindingMode.OneWay;
			binding.Source = this;
			binding.Path = new global::System.Windows.PropertyPath("IsEnabled", new object[0]);
			this._carouselPanelAdorner.SetBinding(global::System.Windows.UIElement.IsEnabledProperty, binding);
			binding = new global::System.Windows.Data.Binding();
			binding.Mode = global::System.Windows.Data.BindingMode.OneWay;
			binding.Source = this;
			binding.Path = new global::System.Windows.PropertyPath("Opacity", new object[0]);
			this._carouselPanelAdorner.SetBinding(global::System.Windows.UIElement.OpacityProperty, binding);
			this.AddAdornerChildElement(this.CarouselPanelNavigator);
			global::System.Windows.Documents.AdornerLayer adornerLayer = global::System.Windows.Documents.AdornerLayer.GetAdornerLayer(this);
			if (adornerLayer != null)
			{
				adornerLayer.Add(this._carouselPanelAdorner);
			}
		}

		// Token: 0x060016C7 RID: 5831 RVA: 0x00058D53 File Offset: 0x00056F53
		private bool InPathPrefixArea(double pathPositionPercentage, global::Infragistics.Windows.Controls.CarouselViewSettings viewSettings)
		{
			return pathPositionPercentage < viewSettings.ItemPathPrefixPercent;
		}

		// Token: 0x060016C8 RID: 5832 RVA: 0x00058D5E File Offset: 0x00056F5E
		private bool InPathSuffixArea(double pathPositionPercentage, global::Infragistics.Windows.Controls.CarouselViewSettings viewSettings)
		{
			return pathPositionPercentage > 1.0 - viewSettings.ItemPathSuffixPercent;
		}

		// Token: 0x060016C9 RID: 5833 RVA: 0x00058D74 File Offset: 0x00056F74
		private int LastVisibleItemIndexFromFirstVisibleItemIndex(int scrollOffset)
		{
			global::Infragistics.Windows.Controls.CarouselViewSettings viewSettingsInternal = this.ViewSettingsInternal;
			int num = scrollOffset + this.ItemsPerPageResolved - 1;
			if (!viewSettingsInternal.IsListContinuous)
			{
				return global::System.Math.Min(this.TotalItemCount, num);
			}
			if (num < this.TotalItemCount)
			{
				return num;
			}
			return num - this.TotalItemCount - 1;
		}

		// Token: 0x060016CA RID: 5834 RVA: 0x00058DBD File Offset: 0x00056FBD
		private void OnChildrenCollectionChanged(object sender, global::System.EventArgs e)
		{
			if (this.ScrollInProgress)
			{
				this.StopAnimatedScrollProcessing();
			}
		}

		// Token: 0x060016CB RID: 5835 RVA: 0x00058DD0 File Offset: 0x00056FD0
		private void OnUnloaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			base.Unloaded -= this.OnUnloaded;
			base.Loaded += this.OnLoaded;
			this._wasLoaded = true;
			this.RemoveAdornerChildElement(this.CarouselPanelNavigator);
			global::System.Windows.Documents.AdornerLayer adornerLayer = global::System.Windows.Documents.AdornerLayer.GetAdornerLayer(this);
			if (adornerLayer != null && this._carouselPanelAdorner != null)
			{
				adornerLayer.Remove(this._carouselPanelAdorner);
			}
		}

		// Token: 0x060016CC RID: 5836 RVA: 0x00058E34 File Offset: 0x00057034
		private void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			base.Loaded -= this.OnLoaded;
			base.Unloaded += this.OnUnloaded;
			this.ShouldGenerateElements = true;
			base.InvalidateMeasure();
			base.UpdateLayout();
			if (this._wasLoaded)
			{
				this._wasLoaded = false;
				global::System.Windows.Documents.AdornerLayer adornerLayer = global::System.Windows.Documents.AdornerLayer.GetAdornerLayer(this);
				if (adornerLayer != null)
				{
					global::System.Windows.Documents.Adorner[] adorners = adornerLayer.GetAdorners(this);
					if (adorners == null || (adorners.GetLength(0) > 0 && adorners[0] != this._carouselPanelAdorner))
					{
						adornerLayer.Add(this._carouselPanelAdorner);
					}
				}
				this.AddAdornerChildElement(this.CarouselPanelNavigator);
			}
		}

		// Token: 0x060016CD RID: 5837 RVA: 0x00058EC9 File Offset: 0x000570C9
		private void OnOpacityEffectStopsCollectionChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			base.InvalidateArrange();
		}

		// Token: 0x060016CE RID: 5838 RVA: 0x00058ED1 File Offset: 0x000570D1
		private void OnScalingEffectStopsCollectionChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			base.InvalidateArrange();
		}

		// Token: 0x060016CF RID: 5839 RVA: 0x00058ED9 File Offset: 0x000570D9
		private void OnSkewAngleXEffectStopsCollectionChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			base.InvalidateArrange();
		}

		// Token: 0x060016D0 RID: 5840 RVA: 0x00058EE1 File Offset: 0x000570E1
		private void OnSkewAngleYEffectStopsCollectionChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			base.InvalidateArrange();
		}

		// Token: 0x060016D1 RID: 5841 RVA: 0x00058EEC File Offset: 0x000570EC
		private void OnViewSettingsPropertyChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			this.BumpCarouselViewSettingsVersion();
			string propertyName;
			switch (propertyName = e.PropertyName)
			{
			case "ShouldScrollItemsIntoInitialPosition":
				this._scrollOffsetForInitialArrangeAnimation = 0.0;
				return;
			case "IsListContinuous":
				this.UpdateCanNavigateStatus();
				base.InvalidateArrange();
				return;
			case "ItemSize":
				this._wrapperSizeDirty = true;
				base.InvalidateArrange();
				return;
			case "ItemPathPrefixPercent":
			case "ItemPathSuffixPercent":
				this.RecalculateCurrentItemLocations();
				base.InvalidateArrange();
				return;
			case "AutoScaleItemContentsToFit":
			case "ItemHorizontalScrollBarVisibility":
			case "ItemVerticalScrollBarVisibility":
				base.InvalidateArrange();
				return;
			case "UseZOrder":
			case "ZOrderEffectStopDirection":
			case "ZOrderEffectStops":
			case "OpacityEffectStops":
			case "OpacityEffectStopDirection":
			case "ScalingEffectStops":
			case "ScalingEffectStopDirection":
			case "SkewAngleXEffectStops":
			case "SkewAngleXEffectStopDirection":
			case "SkewAngleYEffectStops":
			case "SkewAngleYEffectStopDirection":
			case "UseOpacity":
			case "UseScaling":
			case "UseSkewing":
				base.InvalidateArrange();
				return;
			case "ItemPath":
				this._itemPathGeometry = null;
				base.InvalidateVisual();
				base.InvalidateMeasure();
				base.UpdateLayout();
				return;
			case "ItemPathRenderBrush":
				this._cachedItemPathRenderBrush = this.ViewSettingsInternal.ItemPathRenderBrush;
				base.InvalidateVisual();
				return;
			case "ItemPathRenderPen":
				this._cachedItemPathRenderPen = this.ViewSettingsInternal.ItemPathRenderPen;
				base.InvalidateVisual();
				return;
			case "ItemPathAutoPad":
			case "ItemPathHorizontalAlignment":
			case "ItemPathPadding":
			case "ItemPathStretch":
			case "ItemPathVerticalAlignment":
			case "RotateItemsWithPathTangent":
				base.InvalidateMeasure();
				return;
			case "ReserveSpaceForReflections":
				this._wrapperSizeDirty = true;
				this._visiblePositionPercentValuesDirty = true;
				base.SetValue(global::Infragistics.Windows.Controls.XamCarouselPanel.ReflectionVisibilityPropertyKey, this.ViewSettingsInternal.ReserveSpaceForReflections ? global::System.Windows.Visibility.Visible : global::System.Windows.Visibility.Collapsed);
				base.InvalidateMeasure();
				return;
			case "ItemsPerPage":
			{
				if (this.ScrollInProgress)
				{
					this.StopAnimatedScrollProcessing();
				}
				this.ShouldGenerateElements = true;
				int itemsPerPageResolved = this.ItemsPerPageResolved;
				this.UpdateScrollData(this.ScrollingData._extent, new global::System.Windows.Size((double)itemsPerPageResolved, (double)itemsPerPageResolved), this.ScrollingData._offset);
				this.RecalculateCurrentItemLocations();
				base.InvalidateMeasure();
				return;
			}
			case "CarouselPanelNavigatorStyle":
				this.CarouselPanelNavigator.ClearValue(global::System.Windows.FrameworkElement.StyleProperty);
				if (this.ViewSettingsInternal.CarouselPanelNavigatorStyle != null)
				{
					this.CarouselPanelNavigator.Style = this.ViewSettingsInternal.CarouselPanelNavigatorStyle;
				}
				break;

				return;
			}
		}

		// Token: 0x060016D2 RID: 5842 RVA: 0x000592C8 File Offset: 0x000574C8
		private void OnZOrderEffectStopsCollectionChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			this.SetZOrder();
		}

		// Token: 0x060016D3 RID: 5843 RVA: 0x000592D0 File Offset: 0x000574D0
		private void PerformInitialArrangeAnimation()
		{
			if (this._initialArrangeAnimationDone)
			{
				return;
			}
			this._initialArrangeAnimationDone = true;
			this.SetVerticalOffset(this.ScrollOffsetForInitialArrangeAnimation);
			this._scrollOffsetForInitialArrangeAnimation = 0.0;
		}

		// Token: 0x060016D4 RID: 5844 RVA: 0x00059300 File Offset: 0x00057500
		private void RecalculateCurrentItemLocations()
		{
			this._visiblePositionPercentValuesDirty = true;
			this.RecalculateVisiblePositionPercentValues();
			global::System.Collections.IList childElements = base.ChildElements;
			int count = childElements.Count;
			int scrollOffset = (int)this.ScrollingData._offset.Y;
			for (int i = 0; i < count; i++)
			{
				global::Infragistics.Windows.Controls.CarouselPanelItem carouselPanelItem = childElements[i] as global::Infragistics.Windows.Controls.CarouselPanelItem;
				if (carouselPanelItem != null)
				{
					int itemIndexFromChildIndex = base.GetItemIndexFromChildIndex(i);
					carouselPanelItem.PathLocationPercent = this.CalculateChildTargetPct(i, itemIndexFromChildIndex, scrollOffset, true, true);
					carouselPanelItem.NeedsArrange = true;
				}
			}
		}

		// Token: 0x060016D5 RID: 5845 RVA: 0x0005937C File Offset: 0x0005757C
		private void RecalculateVisiblePositionPercentValues()
		{
			if (this._visiblePositionPercentValuesDirty)
			{
				global::Infragistics.Windows.Controls.CarouselViewSettings viewSettingsInternal = this.ViewSettingsInternal;
				int itemsPerPageResolved = this.ItemsPerPageResolved;
				this._visiblePositionPercentValues = new double[itemsPerPageResolved];
				double itemPathPrefixPercent = viewSettingsInternal.ItemPathPrefixPercent;
				double num = 1.0 - viewSettingsInternal.ItemPathSuffixPercent;
				double num2 = num - itemPathPrefixPercent;
				if (itemsPerPageResolved - 1 < 0)
				{
					this._distanceBetweenVisiblePositions = num2;
				}
				else
				{
					this._distanceBetweenVisiblePositions = num2 / (double)(itemsPerPageResolved - 1);
				}
				for (int i = 0; i < itemsPerPageResolved; i++)
				{
					this._visiblePositionPercentValues[i] = itemPathPrefixPercent + (double)i * this._distanceBetweenVisiblePositions;
				}
				this._firstVisiblePositionPercentLocation = this._visiblePositionPercentValues[0];
				this._lastVisiblePositionPercentLocation = this._visiblePositionPercentValues[itemsPerPageResolved - 1];
				this._visiblePositionPercentValuesDirty = false;
			}
		}

		// Token: 0x060016D6 RID: 5846 RVA: 0x00059434 File Offset: 0x00057634
		private void RemoveRangeOfChldren(global::System.Windows.Controls.Primitives.GeneratorPosition position, int count)
		{
			if (base.ItemContainerGenerationModeResolved == global::Infragistics.Windows.Controls.ItemContainerGenerationMode.Recycle || base.Children == null)
			{
				return;
			}
			if (count < 1)
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
			int count2 = base.ChildElements.Count;
			if (num < count2)
			{
				base.RemoveInternalChildRange(num, global::System.Math.Min(count, count2 - num));
			}
		}

		// Token: 0x060016D7 RID: 5847 RVA: 0x00059498 File Offset: 0x00057698
		private void ScaleItemPath(global::System.Windows.Size availableSize)
		{
			global::Infragistics.Windows.Controls.CarouselViewSettings viewSettingsInternal = this.ViewSettingsInternal;
			this.ItemPathGeometry.Transform = null;
			global::System.Windows.Rect rect = new global::System.Windows.Rect(this.ItemPathGeometry.Bounds.Left, this.ItemPathGeometry.Bounds.Top, (this.ItemPathGeometry.Bounds.Width == 0.0) ? 1.0 : this.ItemPathGeometry.Bounds.Width, (this.ItemPathGeometry.Bounds.Height == 0.0) ? 1.0 : this.ItemPathGeometry.Bounds.Height);
			global::System.Windows.Thickness itemPathPadding = viewSettingsInternal.ItemPathPadding;
			if (viewSettingsInternal.ItemPathAutoPad)
			{
				global::System.Windows.Size itemSize = viewSettingsInternal.ItemSize;
				itemPathPadding = new global::System.Windows.Thickness(itemPathPadding.Left + itemSize.Width / 2.0, itemPathPadding.Top + itemSize.Height / 2.0, itemPathPadding.Right + itemSize.Width / 2.0, itemPathPadding.Bottom + itemSize.Height / 2.0);
			}
			global::System.Windows.Rect rect2 = new global::System.Windows.Rect(0.0 + itemPathPadding.Left, 0.0 + itemPathPadding.Top, global::System.Math.Max(availableSize.Width - (itemPathPadding.Left + itemPathPadding.Right), 0.0), global::System.Math.Max(availableSize.Height - (itemPathPadding.Top + itemPathPadding.Bottom), 0.0));
			double num = rect2.Width / rect.Width;
			double num2 = rect2.Height / rect.Height;
			switch (viewSettingsInternal.ItemPathStretch)
			{
			case global::System.Windows.Media.Stretch.None:
				num2 = (num = 1.0);
				break;
			case global::System.Windows.Media.Stretch.Uniform:
				num2 = (num = global::System.Math.Min(num, num2));
				break;
			case global::System.Windows.Media.Stretch.UniformToFill:
				num2 = (num = global::System.Math.Max(num, num2));
				break;
			}
			double num3 = -(num * rect.Left);
			double num4 = -(num2 * rect.Top);
			double num5 = (this.ItemPathGeometry.Bounds.Width == 0.0) ? 1.0 : (rect.Width * num);
			double num6 = (this.ItemPathGeometry.Bounds.Height == 0.0) ? 1.0 : (rect.Height * num2);
			switch (viewSettingsInternal.ItemPathHorizontalAlignment)
			{
			case global::System.Windows.HorizontalAlignment.Left:
				num3 += itemPathPadding.Left;
				break;
			case global::System.Windows.HorizontalAlignment.Center:
			case global::System.Windows.HorizontalAlignment.Stretch:
				num3 += itemPathPadding.Left + (rect2.Width - num5) / 2.0;
				break;
			case global::System.Windows.HorizontalAlignment.Right:
				num3 += itemPathPadding.Left + (rect2.Width - num5);
				break;
			}
			switch (viewSettingsInternal.ItemPathVerticalAlignment)
			{
			case global::System.Windows.VerticalAlignment.Top:
				num4 += itemPathPadding.Top;
				break;
			case global::System.Windows.VerticalAlignment.Center:
			case global::System.Windows.VerticalAlignment.Stretch:
				num4 += itemPathPadding.Top + (rect2.Height - num6) / 2.0;
				break;
			case global::System.Windows.VerticalAlignment.Bottom:
				num4 += itemPathPadding.Top + (rect2.Height - num6);
				break;
			}
			this.ItemPathGeometry.Transform = new global::System.Windows.Media.MatrixTransform(new global::System.Windows.Media.Matrix(num, 0.0, 0.0, num2, num3, num4));
		}

		// Token: 0x060016D8 RID: 5848 RVA: 0x00059850 File Offset: 0x00057A50
		private static double SecondsFromTicks(long ticks)
		{
			return (double)ticks / 10000000.0;
		}

		// Token: 0x060016D9 RID: 5849 RVA: 0x0005986C File Offset: 0x00057A6C
		private void SetZOrder()
		{
			global::System.Collections.IList childElements = base.ChildElements;
			int count = childElements.Count;
			global::Infragistics.Windows.Controls.CarouselViewSettings viewSettingsInternal = this.ViewSettingsInternal;
			if (!viewSettingsInternal.UseZOrder)
			{
				int num = global::System.Math.Max(0, base.GetChildIndexFromItemIndex((int)this.ScrollingData._offset.Y));
				int num2 = 0;
				int num3 = -1;
				int num4 = num;
				while (num2 < count && num4 < count)
				{
					global::System.Windows.DependencyObject dependencyObject = childElements[num4] as global::System.Windows.DependencyObject;
					int num5 = (int)dependencyObject.GetValue(global::System.Windows.Controls.Panel.ZIndexProperty);
					if (num5 <= num3)
					{
						num5 = num3 + 1;
						dependencyObject.SetValue(global::System.Windows.Controls.Panel.ZIndexProperty, num5);
					}
					num3 = num5;
					num2++;
					if (num2 < count && viewSettingsInternal.IsListContinuous && num4 == count - 1)
					{
						num4 = -1;
					}
					num4++;
				}
				return;
			}
			global::System.Collections.Generic.List<int> list = new global::System.Collections.Generic.List<int>(count);
			global::System.Windows.Size size;
			if (this._previousArrangeSize != global::System.Windows.Size.Empty)
			{
				size = this._previousArrangeSize;
			}
			else
			{
				if (!(this._previousMeasureSize != global::System.Windows.Size.Empty))
				{
					return;
				}
				size = this._previousMeasureSize;
			}
			global::System.Windows.Rect rect = new global::System.Windows.Rect(0.0, 0.0, size.Width, size.Height);
			global::Infragistics.Windows.Controls.EffectStopDirection zorderEffectStopDirectionResolved = this.ZOrderEffectStopDirectionResolved;
			global::Infragistics.Windows.Controls.ZOrderEffectStopCollection zorderEffectStopsResolved = this.ZOrderEffectStopsResolved;
			int count2;
			for (int i = 0; i < count; i++)
			{
				bool flag = false;
				global::Infragistics.Windows.Controls.CarouselPanelItem carouselPanelItem = childElements[i] as global::Infragistics.Windows.Controls.CarouselPanelItem;
				if (carouselPanelItem != null && carouselPanelItem.Opacity >= 0.2)
				{
					double num6;
					if (zorderEffectStopDirectionResolved == global::Infragistics.Windows.Controls.EffectStopDirection.Vertical)
					{
						num6 = zorderEffectStopsResolved.GetStopValueFromRange(rect.Top, rect.Bottom, (double)((int)carouselPanelItem.CurrentLocation.Y));
					}
					else if (zorderEffectStopDirectionResolved == global::Infragistics.Windows.Controls.EffectStopDirection.Horizontal)
					{
						num6 = zorderEffectStopsResolved.GetStopValueFromRange(rect.Left, rect.Right, (double)((int)carouselPanelItem.CurrentLocation.X));
					}
					else
					{
						num6 = zorderEffectStopsResolved.GetStopValueFromOffset(carouselPanelItem.PathLocationPercent);
					}
					carouselPanelItem.CurrentZindexEffectStopValue = num6;
					if (list.Count == 0)
					{
						list.Add(i);
					}
					else
					{
						count2 = list.Count;
						for (int j = 0; j < count2; j++)
						{
							if (num6 <= ((global::Infragistics.Windows.Controls.CarouselPanelItem)childElements[list[j]]).CurrentZindexEffectStopValue)
							{
								list.Insert(j, i);
								flag = true;
								break;
							}
						}
						if (!flag)
						{
							list.Add(i);
						}
					}
				}
			}
			count2 = list.Count;
			for (int k = 0; k < count2; k++)
			{
				global::System.Windows.DependencyObject dependencyObject2 = childElements[list[k]] as global::System.Windows.DependencyObject;
				if ((int)dependencyObject2.GetValue(global::System.Windows.Controls.Panel.ZIndexProperty) != k)
				{
					dependencyObject2.SetValue(global::System.Windows.Controls.Panel.ZIndexProperty, k);
				}
			}
		}

		// Token: 0x060016DA RID: 5850 RVA: 0x00059B2A File Offset: 0x00057D2A
		private void StartAnimatedScrollProcessing(global::Infragistics.Windows.Controls.XamCarouselPanel.ScrollActionInfo scrollActionInfo)
		{
			this._scrollActionInfo = scrollActionInfo;
			if (this._renderingEventProxy == null)
			{
				this._renderingEventProxy = new global::Infragistics.Windows.Controls.XamCarouselPanel.RenderingEventProxy(this);
			}
			this._renderingEventProxy.WireRenderingEvent();
		}

		// Token: 0x060016DB RID: 5851 RVA: 0x00059B52 File Offset: 0x00057D52
		private void StopAnimatedScrollProcessing()
		{
			this._scrollActionInfo = global::Infragistics.Windows.Controls.XamCarouselPanel.ScrollActionInfo.Empty;
			if (this._renderingEventProxy != null)
			{
				this._renderingEventProxy.UnwireRenderingEvent();
			}
			this.OnAnimatedScrollComplete((int)this.ScrollingData._offset.Y);
			base.TriggerCleanupOfUnusedGeneratedItems(false);
		}

		// Token: 0x060016DC RID: 5852 RVA: 0x00059B90 File Offset: 0x00057D90
		private static bool UpdateElementPosition(global::Infragistics.Windows.Controls.CarouselPanelItem element, double secondsSinceLastFrameRender, double dampening, double attractionFactor, bool scrollInProgress, bool scrollingHigher)
		{
			if (element == null)
			{
				return false;
			}
			double pathTargetPercent = element.PathTargetPercent;
			double num = element.PathLocationPercent;
			if (num == pathTargetPercent)
			{
				return false;
			}
			double num2 = element.Velocity;
			double num3;
			if (scrollInProgress)
			{
				if (scrollingHigher)
				{
					if (num > pathTargetPercent)
					{
						num3 = pathTargetPercent - num;
					}
					else
					{
						num3 = 0.0;
					}
				}
				else if (pathTargetPercent > num)
				{
					num3 = pathTargetPercent - num;
				}
				else
				{
					num3 = 0.0;
				}
			}
			else
			{
				num3 = pathTargetPercent - num;
			}
			if (global::System.Math.Abs(num3) > 0.0004)
			{
				num2 *= dampening;
				num2 += num3;
				double num4 = num2 * secondsSinceLastFrameRender * attractionFactor;
				num4 *= ((num4 > 0.09) ? (0.09 / num4) : 1.0);
				num += num4;
				num = global::System.Math.Max(global::System.Math.Min(num, 1.0), 0.0);
				element.PathLocationPercent = num;
				element.Velocity = num2;
				return true;
			}
			if (num != pathTargetPercent)
			{
				num = pathTargetPercent;
				element.PathLocationPercent = num;
				return true;
			}
			return false;
		}

		// Token: 0x060016DD RID: 5853 RVA: 0x00059C8B File Offset: 0x00057E8B
		private static void UpdateFirstAndLastItemPropertiesOnChild(global::Infragistics.Windows.Controls.CarouselPanelItem child, int childsItemIndex, int totalItemCount)
		{
			if (child == null)
			{
				return;
			}
			child.SetValue(global::Infragistics.Windows.Controls.CarouselPanelItem.IsFirstItemPropertyKey, childsItemIndex == 0);
			child.SetValue(global::Infragistics.Windows.Controls.CarouselPanelItem.IsLastItemPropertyKey, childsItemIndex == totalItemCount - 1);
		}

		// Token: 0x060016DE RID: 5854 RVA: 0x00059CBC File Offset: 0x00057EBC
		private void UpdateScrollData(global::System.Windows.Size newExtent, global::System.Windows.Size newViewport, global::System.Windows.Vector newOffset)
		{
			if (this.ScrollingData._extent != newExtent || this.ScrollingData._viewport != newViewport || this.ScrollingData._offset != newOffset)
			{
				this.ScrollingData._extent = newExtent;
				this.ScrollingData._viewport = newViewport;
				this.ScrollingData._offset = newOffset;
				base.SetValue(global::Infragistics.Windows.Controls.XamCarouselPanel.FirstVisibleItemIndexPropertyKey, (int)global::System.Math.Max(newOffset.Y, 0.0));
				this.UpdateCanNavigateStatus();
			}
		}

		// Token: 0x060016DF RID: 5855 RVA: 0x00059D54 File Offset: 0x00057F54
		private void UpdateCanNavigateStatus()
		{
			global::Infragistics.Windows.Controls.CarouselViewSettings viewSettingsInternal = this.ViewSettingsInternal;
			bool flag = this.ScrollingData._offset.Y > this.LowestPossibleScrollOffset || viewSettingsInternal.IsListContinuous;
			bool flag2 = this.ScrollingData._offset.Y < this.HighestPossibleScrollOffset || viewSettingsInternal.IsListContinuous;
			if (viewSettingsInternal.IsListContinuous)
			{
				if (this.TotalItemCount > 1)
				{
					base.SetValue(global::Infragistics.Windows.Controls.XamCarouselPanel.CanNavigateToPreviousItemPropertyKey, global::Infragistics.KnownBoxes.TrueBox);
					base.SetValue(global::Infragistics.Windows.Controls.XamCarouselPanel.CanNavigateToNextItemPropertyKey, global::Infragistics.KnownBoxes.TrueBox);
					int itemsPerPageResolved = this.ItemsPerPageResolved;
					int totalItemCount = this.TotalItemCount;
					base.SetValue(global::Infragistics.Windows.Controls.XamCarouselPanel.CanNavigateToPreviousPagePropertyKey, itemsPerPageResolved != totalItemCount);
					base.SetValue(global::Infragistics.Windows.Controls.XamCarouselPanel.CanNavigateToNextPagePropertyKey, itemsPerPageResolved != totalItemCount);
					return;
				}
				base.SetValue(global::Infragistics.Windows.Controls.XamCarouselPanel.CanNavigateToPreviousItemPropertyKey, global::Infragistics.KnownBoxes.FalseBox);
				base.SetValue(global::Infragistics.Windows.Controls.XamCarouselPanel.CanNavigateToNextItemPropertyKey, global::Infragistics.KnownBoxes.FalseBox);
				base.SetValue(global::Infragistics.Windows.Controls.XamCarouselPanel.CanNavigateToPreviousPagePropertyKey, global::Infragistics.KnownBoxes.FalseBox);
				base.SetValue(global::Infragistics.Windows.Controls.XamCarouselPanel.CanNavigateToNextPagePropertyKey, global::Infragistics.KnownBoxes.FalseBox);
				return;
			}
			else
			{
				if (flag && !this.CanNavigateToPreviousItem)
				{
					base.SetValue(global::Infragistics.Windows.Controls.XamCarouselPanel.CanNavigateToPreviousItemPropertyKey, global::Infragistics.KnownBoxes.TrueBox);
				}
				else if (!flag && this.CanNavigateToPreviousItem)
				{
					base.SetValue(global::Infragistics.Windows.Controls.XamCarouselPanel.CanNavigateToPreviousItemPropertyKey, global::Infragistics.KnownBoxes.FalseBox);
				}
				if (flag2 && !this.CanNavigateToNextItem)
				{
					base.SetValue(global::Infragistics.Windows.Controls.XamCarouselPanel.CanNavigateToNextItemPropertyKey, global::Infragistics.KnownBoxes.TrueBox);
				}
				else if (!flag2 && this.CanNavigateToNextItem)
				{
					base.SetValue(global::Infragistics.Windows.Controls.XamCarouselPanel.CanNavigateToNextItemPropertyKey, global::Infragistics.KnownBoxes.FalseBox);
				}
				if (flag && !this.CanNavigateToPreviousPage)
				{
					base.SetValue(global::Infragistics.Windows.Controls.XamCarouselPanel.CanNavigateToPreviousPagePropertyKey, global::Infragistics.KnownBoxes.TrueBox);
				}
				else if (!flag && this.CanNavigateToPreviousPage)
				{
					base.SetValue(global::Infragistics.Windows.Controls.XamCarouselPanel.CanNavigateToPreviousPagePropertyKey, global::Infragistics.KnownBoxes.FalseBox);
				}
				if (flag2 && !this.CanNavigateToNextPage)
				{
					base.SetValue(global::Infragistics.Windows.Controls.XamCarouselPanel.CanNavigateToNextPagePropertyKey, global::Infragistics.KnownBoxes.TrueBox);
					return;
				}
				if (!flag2 && this.CanNavigateToNextPage)
				{
					base.SetValue(global::Infragistics.Windows.Controls.XamCarouselPanel.CanNavigateToNextPagePropertyKey, global::Infragistics.KnownBoxes.FalseBox);
				}
				return;
			}
		}

		// Token: 0x060016E0 RID: 5856 RVA: 0x00059F40 File Offset: 0x00058140
		protected void AddAdornerChildElement(global::System.Windows.UIElement childElement)
		{
			if (this.CarouselPanelAdorner != null)
			{
				this.CarouselPanelAdorner.AddChildElement(childElement);
			}
		}

		// Token: 0x060016E1 RID: 5857 RVA: 0x00059F58 File Offset: 0x00058158
		protected internal bool GetIsItemIndexVisible(int itemIndex, int scrollOffset)
		{
			int num = 0;
			return this.GetIsItemIndexVisible(itemIndex, scrollOffset, out num);
		}

		// Token: 0x060016E2 RID: 5858 RVA: 0x00059F71 File Offset: 0x00058171
		private bool GetIsItemIndexVisible(int itemIndex, int scrollOffset, out int visiblePosition)
		{
			visiblePosition = this.GetVisiblePositionFromItemIndex(itemIndex, scrollOffset);
			return visiblePosition != -1;
		}

		// Token: 0x060016E3 RID: 5859 RVA: 0x00059F85 File Offset: 0x00058185
		protected void RemoveAdornerChildElement(global::System.Windows.UIElement childElement)
		{
			if (this.CarouselPanelAdorner != null)
			{
				this.CarouselPanelAdorner.RemoveChildElement(childElement);
			}
		}

		// Token: 0x060016E4 RID: 5860 RVA: 0x00059F9C File Offset: 0x0005819C
		protected virtual bool CanExecuteCommand(global::Infragistics.Windows.Commands.ExecuteCommandInfo commandInfo)
		{
			global::System.Windows.Input.RoutedCommand routedCommand = commandInfo.RoutedCommand;
			return routedCommand != null && routedCommand.OwnerType == typeof(global::Infragistics.Windows.Controls.XamCarouselPanelCommands);
		}

		// Token: 0x060016E5 RID: 5861 RVA: 0x00059FCA File Offset: 0x000581CA
		protected virtual void OnAnimatedScrollComplete(int newScrollPosition)
		{
		}

		// Token: 0x060016E6 RID: 5862 RVA: 0x00059FCC File Offset: 0x000581CC
		protected virtual bool ExecuteCommand(global::Infragistics.Windows.Commands.ExecuteCommandInfo commandInfo)
		{
			global::System.Windows.Input.RoutedCommand routedCommand = commandInfo.RoutedCommand;
			return routedCommand != null && this.ExecuteCommand(routedCommand);
		}

		// Token: 0x060016E7 RID: 5863 RVA: 0x00059FEC File Offset: 0x000581EC
		internal static global::System.Windows.Media.Transform FindTransform(global::System.Windows.Media.Transform renderTransform, global::System.Type transformTypeToFind)
		{
			if (renderTransform == null)
			{
				return null;
			}
			global::System.Type type = renderTransform.GetType();
			if (type == transformTypeToFind)
			{
				return renderTransform;
			}
			if (type == typeof(global::System.Windows.Media.TransformGroup))
			{
				global::System.Windows.Media.TransformGroup transformGroup = renderTransform as global::System.Windows.Media.TransformGroup;
				global::System.Windows.Media.TransformCollection children = transformGroup.Children;
				int count = children.Count;
				for (int i = 0; i < count; i++)
				{
					global::System.Windows.Media.Transform transform = children[i];
					if (transform.GetType() == transformTypeToFind)
					{
						return transform;
					}
				}
			}
			return null;
		}

		// Token: 0x060016E8 RID: 5864 RVA: 0x0005A064 File Offset: 0x00058264
		internal static bool ReplaceTransform(global::System.Windows.UIElement element, global::System.Windows.Media.Transform newTransform)
		{
			if (element.RenderTransform == null)
			{
				element.RenderTransform = newTransform;
				return true;
			}
			global::System.Type type = element.RenderTransform.GetType();
			global::System.Type type2 = newTransform.GetType();
			if (type == type2)
			{
				element.RenderTransform = newTransform;
				return true;
			}
			if (type == typeof(global::System.Windows.Media.TransformGroup))
			{
				global::System.Windows.Media.TransformGroup transformGroup = element.RenderTransform as global::System.Windows.Media.TransformGroup;
				global::System.Windows.Media.TransformCollection children = transformGroup.Children;
				int count = children.Count;
				for (int i = 0; i < count; i++)
				{
					if (children[i].GetType() == type2)
					{
						children[i] = newTransform;
						return true;
					}
				}
				children.Add(newTransform);
				return true;
			}
			return false;
		}

		// Token: 0x060016E9 RID: 5865 RVA: 0x0005A10F File Offset: 0x0005830F
		internal void RemoveLogicalChildProxy(object child)
		{
			base.RemoveLogicalChild(child);
		}

		// Token: 0x060016EA RID: 5866 RVA: 0x0005A118 File Offset: 0x00058318
		protected virtual void OnExecutingCommand(global::Infragistics.Windows.Controls.Events.ExecutingCommandEventArgs args)
		{
			base.RaiseEvent(args);
		}

		// Token: 0x060016EB RID: 5867 RVA: 0x0005A121 File Offset: 0x00058321
		internal bool RaiseExecutingCommand(global::Infragistics.Windows.Controls.Events.ExecutingCommandEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.Controls.XamCarouselPanel.ExecutingCommandEvent;
			args.Source = this;
			this.OnExecutingCommand(args);
			return !args.Cancel;
		}

		// Token: 0x14000033 RID: 51
		// (add) Token: 0x060016EC RID: 5868 RVA: 0x0005A145 File Offset: 0x00058345
		// (remove) Token: 0x060016ED RID: 5869 RVA: 0x0005A153 File Offset: 0x00058353
		public event global::System.EventHandler<global::Infragistics.Windows.Controls.Events.ExecutingCommandEventArgs> ExecutingCommand
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.Controls.XamCarouselPanel.ExecutingCommandEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.Controls.XamCarouselPanel.ExecutingCommandEvent, value);
			}
		}

		// Token: 0x060016EE RID: 5870 RVA: 0x0005A161 File Offset: 0x00058361
		protected virtual void OnExecutedCommand(global::Infragistics.Windows.Controls.Events.ExecutedCommandEventArgs args)
		{
			base.RaiseEvent(args);
		}

		// Token: 0x060016EF RID: 5871 RVA: 0x0005A16A File Offset: 0x0005836A
		internal void RaiseExecutedCommand(global::Infragistics.Windows.Controls.Events.ExecutedCommandEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.Controls.XamCarouselPanel.ExecutedCommandEvent;
			args.Source = this;
			this.OnExecutedCommand(args);
		}

		// Token: 0x14000034 RID: 52
		// (add) Token: 0x060016F0 RID: 5872 RVA: 0x0005A185 File Offset: 0x00058385
		// (remove) Token: 0x060016F1 RID: 5873 RVA: 0x0005A193 File Offset: 0x00058393
		public event global::System.EventHandler<global::Infragistics.Windows.Controls.Events.ExecutedCommandEventArgs> ExecutedCommand
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.Controls.XamCarouselPanel.ExecutedCommandEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.Controls.XamCarouselPanel.ExecutedCommandEvent, value);
			}
		}

		// Token: 0x060016F2 RID: 5874 RVA: 0x0005A1A4 File Offset: 0x000583A4
		bool global::System.Windows.IWeakEventListener.ReceiveWeakEvent(global::System.Type managerType, object sender, global::System.EventArgs e)
		{
			if (managerType == typeof(global::System.ComponentModel.PropertyChangedEventManager))
			{
				global::System.ComponentModel.PropertyChangedEventArgs propertyChangedEventArgs = e as global::System.ComponentModel.PropertyChangedEventArgs;
				if (propertyChangedEventArgs != null && sender is global::Infragistics.Windows.Controls.CarouselViewSettings && sender == this._viewSettings)
				{
					this.OnViewSettingsPropertyChanged(sender, propertyChangedEventArgs);
					return true;
				}
			}
			return false;
		}

		// Token: 0x060016F3 RID: 5875 RVA: 0x0005A1EC File Offset: 0x000583EC
		bool global::Infragistics.Windows.Commands.ICommandHost.Execute(global::Infragistics.Windows.Commands.ExecuteCommandInfo commandInfo)
		{
			global::System.Windows.Input.RoutedCommand routedCommand = commandInfo.RoutedCommand;
			return routedCommand != null && this.ExecuteCommand(routedCommand);
		}

		// Token: 0x060016F4 RID: 5876 RVA: 0x0005A20C File Offset: 0x0005840C
		long global::Infragistics.Windows.Commands.ICommandHost.GetCurrentState(long statesToQuery)
		{
			return this.CurrentState;
		}

		// Token: 0x060016F5 RID: 5877 RVA: 0x0005A214 File Offset: 0x00058414
		bool global::Infragistics.Windows.Commands.ICommandHost.CanExecute(global::Infragistics.Windows.Commands.ExecuteCommandInfo commandInfo)
		{
			return this.CanExecuteCommand(commandInfo);
		}

		// Token: 0x060016F6 RID: 5878 RVA: 0x0005A220 File Offset: 0x00058420
		// Note: this type is marked as 'beforefieldinit'.
		static XamCarouselPanel()
		{
			global::Infragistics.Windows.Controls.XamCarouselPanel.ExecutingCommandEvent = global::System.Windows.EventManager.RegisterRoutedEvent("ExecutingCommand", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.EventHandler<global::Infragistics.Windows.Controls.Events.ExecutingCommandEventArgs>), typeof(global::Infragistics.Windows.Controls.XamCarouselPanel));
			global::Infragistics.Windows.Controls.XamCarouselPanel.ExecutedCommandEvent = global::System.Windows.EventManager.RegisterRoutedEvent("ExecutedCommand", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.EventHandler<global::Infragistics.Windows.Controls.Events.ExecutedCommandEventArgs>), typeof(global::Infragistics.Windows.Controls.XamCarouselPanel));
		}

		// Token: 0x04000AEA RID: 2794
		private const int SCROLL_SMALL_CHANGE = 1;

		// Token: 0x04000AEB RID: 2795
		private const double REFERENCE_FRAME_RATE = 30.0;

		// Token: 0x04000AEC RID: 2796
		private const double FRAME_RATE_SMOOTHING_FACTOR = 0.05;

		// Token: 0x04000AED RID: 2797
		private const double MAX_VELOCITY = 0.09;

		// Token: 0x04000AEE RID: 2798
		private const double ATTRACTION = 7.0;

		// Token: 0x04000AEF RID: 2799
		private const double DAMPENING = 0.0;

		// Token: 0x04000AF0 RID: 2800
		private const double MIN_DISTANCE_THRESHHOLD = 0.0004;

		// Token: 0x04000AF1 RID: 2801
		private global::Infragistics.Windows.Controls.XamCarouselPanel.ScrollData _scrollingData;

		// Token: 0x04000AF2 RID: 2802
		private global::Infragistics.Windows.Licensing.UltraLicense _license;

		// Token: 0x04000AF3 RID: 2803
		private long _previousTick = long.MinValue;

		// Token: 0x04000AF4 RID: 2804
		private double _smoothedFrameRate = 30.0;

		// Token: 0x04000AF5 RID: 2805
		private global::System.Windows.Size _previousArrangeSize = global::System.Windows.Size.Empty;

		// Token: 0x04000AF6 RID: 2806
		private global::System.Windows.Size _previousMeasureSize = global::System.Windows.Size.Empty;

		// Token: 0x04000AF7 RID: 2807
		private bool _shouldGenerateElements = true;

		// Token: 0x04000AF8 RID: 2808
		private global::Infragistics.Windows.Controls.XamCarouselPanel.ScrollActionInfo _scrollActionInfo = global::Infragistics.Windows.Controls.XamCarouselPanel.ScrollActionInfo.Empty;

		// Token: 0x04000AF9 RID: 2809
		private double _scrollOffsetForInitialArrangeAnimation;

		// Token: 0x04000AFA RID: 2810
		private global::Infragistics.Windows.Controls.CarouselPanelAdorner _carouselPanelAdorner;

		// Token: 0x04000AFB RID: 2811
		private global::System.Windows.Size _wrapperSize = (global::System.Windows.Size)global::Infragistics.Windows.Controls.CarouselViewSettings.ItemSizeProperty.DefaultMetadata.DefaultValue;

		// Token: 0x04000AFC RID: 2812
		private bool _wrapperSizeDirty = true;

		// Token: 0x04000AFD RID: 2813
		private bool _initialArrangeAnimationDone;

		// Token: 0x04000AFE RID: 2814
		private global::Infragistics.Windows.Controls.CarouselPanelNavigator _carouselPanelNavigator;

		// Token: 0x04000AFF RID: 2815
		private global::Infragistics.Windows.Controls.ScalingEffectStopCollection _defaultScalingEffectStops;

		// Token: 0x04000B00 RID: 2816
		private global::Infragistics.Windows.Controls.ZOrderEffectStopCollection _defaultZOrderEffectStops;

		// Token: 0x04000B01 RID: 2817
		private global::Infragistics.Windows.Controls.SkewAngleXEffectStopCollection _defaultSkewAngleXEffectStops;

		// Token: 0x04000B02 RID: 2818
		private global::Infragistics.Windows.Controls.SkewAngleYEffectStopCollection _defaultSkewAngleYEffectStops;

		// Token: 0x04000B03 RID: 2819
		private global::Infragistics.Windows.Controls.OpacityEffectStopCollection _defaultOpacityEffectStops;

		// Token: 0x04000B04 RID: 2820
		private global::System.Windows.Media.Pen _cachedItemPathRenderPen;

		// Token: 0x04000B05 RID: 2821
		private global::System.Windows.Media.Brush _cachedItemPathRenderBrush;

		// Token: 0x04000B06 RID: 2822
		private double[] _visiblePositionPercentValues;

		// Token: 0x04000B07 RID: 2823
		private bool _visiblePositionPercentValuesDirty = true;

		// Token: 0x04000B08 RID: 2824
		private double _distanceBetweenVisiblePositions;

		// Token: 0x04000B09 RID: 2825
		private double _firstVisiblePositionPercentLocation;

		// Token: 0x04000B0A RID: 2826
		private double _lastVisiblePositionPercentLocation = 1.0;

		// Token: 0x04000B0B RID: 2827
		private global::Infragistics.Windows.Controls.ICarouselPanelSelectionHost _selectionHost;

		// Token: 0x04000B0C RID: 2828
		private global::System.Windows.Media.PathGeometry _itemPathGeometry;

		// Token: 0x04000B0D RID: 2829
		private global::Infragistics.Windows.Controls.CarouselViewSettings _viewSettings;

		// Token: 0x04000B0E RID: 2830
		private global::Infragistics.Windows.Controls.XamCarouselPanel.RenderingEventProxy _renderingEventProxy;

		// Token: 0x04000B0F RID: 2831
		private global::System.Collections.Generic.Dictionary<double, global::Infragistics.Windows.Controls.XamCarouselPanel.PathFractionPoint> _pathFractionPointsCache;

		// Token: 0x04000B10 RID: 2832
		private global::Infragistics.Windows.Controls.CarouselViewSettings _designTimeDefaultViewSettings;

		// Token: 0x04000B11 RID: 2833
		private bool _wasLoaded;

		// Token: 0x04000B12 RID: 2834
		private static readonly global::System.Windows.DependencyPropertyKey CanNavigateToPreviousItemPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("CanNavigateToPreviousItem", typeof(bool), typeof(global::Infragistics.Windows.Controls.XamCarouselPanel), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x04000B13 RID: 2835
		public static readonly global::System.Windows.DependencyProperty CanNavigateToPreviousItemProperty = global::Infragistics.Windows.Controls.XamCarouselPanel.CanNavigateToPreviousItemPropertyKey.DependencyProperty;

		// Token: 0x04000B14 RID: 2836
		private static readonly global::System.Windows.DependencyPropertyKey CanNavigateToPreviousPagePropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("CanNavigateToPreviousPage", typeof(bool), typeof(global::Infragistics.Windows.Controls.XamCarouselPanel), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x04000B15 RID: 2837
		public static readonly global::System.Windows.DependencyProperty CanNavigateToPreviousPageProperty = global::Infragistics.Windows.Controls.XamCarouselPanel.CanNavigateToPreviousPagePropertyKey.DependencyProperty;

		// Token: 0x04000B16 RID: 2838
		private static readonly global::System.Windows.DependencyPropertyKey CanNavigateToNextItemPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("CanNavigateToNextItem", typeof(bool), typeof(global::Infragistics.Windows.Controls.XamCarouselPanel), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x04000B17 RID: 2839
		public static readonly global::System.Windows.DependencyProperty CanNavigateToNextItemProperty = global::Infragistics.Windows.Controls.XamCarouselPanel.CanNavigateToNextItemPropertyKey.DependencyProperty;

		// Token: 0x04000B18 RID: 2840
		private static readonly global::System.Windows.DependencyPropertyKey CanNavigateToNextPagePropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("CanNavigateToNextPage", typeof(bool), typeof(global::Infragistics.Windows.Controls.XamCarouselPanel), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x04000B19 RID: 2841
		public static readonly global::System.Windows.DependencyProperty CanNavigateToNextPageProperty = global::Infragistics.Windows.Controls.XamCarouselPanel.CanNavigateToNextPagePropertyKey.DependencyProperty;

		// Token: 0x04000B1A RID: 2842
		private static readonly global::System.Windows.DependencyPropertyKey FirstVisibleItemIndexPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("FirstVisibleItemIndex", typeof(int), typeof(global::Infragistics.Windows.Controls.XamCarouselPanel), new global::System.Windows.FrameworkPropertyMetadata(0));

		// Token: 0x04000B1B RID: 2843
		public static readonly global::System.Windows.DependencyProperty FirstVisibleItemIndexProperty = global::Infragistics.Windows.Controls.XamCarouselPanel.FirstVisibleItemIndexPropertyKey.DependencyProperty;

		// Token: 0x04000B1C RID: 2844
		private static readonly global::System.Windows.DependencyPropertyKey ReflectionVisibilityPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("ReflectionVisibility", typeof(global::System.Windows.Visibility), typeof(global::Infragistics.Windows.Controls.XamCarouselPanel), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.VisibilityVisibleBox));

		// Token: 0x04000B1D RID: 2845
		public static readonly global::System.Windows.DependencyProperty ReflectionVisibilityProperty = global::Infragistics.Windows.Controls.XamCarouselPanel.ReflectionVisibilityPropertyKey.DependencyProperty;

		// Token: 0x04000B1E RID: 2846
		public static readonly global::System.Windows.DependencyProperty ViewSettingsProperty = global::System.Windows.DependencyProperty.Register("ViewSettings", typeof(global::Infragistics.Windows.Controls.CarouselViewSettings), typeof(global::Infragistics.Windows.Controls.XamCarouselPanel), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.Controls.XamCarouselPanel.OnCoerceViewSettings)));

		// Token: 0x04000B1F RID: 2847
		internal static readonly global::System.Windows.DependencyProperty IsInCarouselListBoxProperty = global::System.Windows.DependencyProperty.Register("IsInCarouselListBox", typeof(bool), typeof(global::Infragistics.Windows.Controls.XamCarouselPanel), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x04000B20 RID: 2848
		internal static readonly global::System.Windows.DependencyProperty ViewSettingsVersionProperty = global::System.Windows.DependencyProperty.Register("ViewSettingsVersion", typeof(int), typeof(global::Infragistics.Windows.Controls.XamCarouselPanel), new global::System.Windows.FrameworkPropertyMetadata(0));

		// Token: 0x02000224 RID: 548
		// (Invoke) Token: 0x060016F8 RID: 5880
		private delegate void MethodDelegate();

		// Token: 0x02000225 RID: 549
		private class RenderingEventProxy
		{
			// Token: 0x060016FB RID: 5883 RVA: 0x0005A46E File Offset: 0x0005866E
			internal RenderingEventProxy(global::Infragistics.Windows.Controls.XamCarouselPanel panel)
			{
				this._panelRef = new global::System.WeakReference(panel);
				this._isWired = false;
			}

			// Token: 0x060016FC RID: 5884 RVA: 0x0005A48C File Offset: 0x0005868C
			private void OnCompositionTarget_Rendering(object sender, global::System.EventArgs e)
			{
				global::Infragistics.Windows.Controls.XamCarouselPanel xamCarouselPanel = global::Infragistics.CoreUtilities.GetWeakReferenceTargetSafe(this._panelRef) as global::Infragistics.Windows.Controls.XamCarouselPanel;
				if (xamCarouselPanel != null)
				{
					xamCarouselPanel.CompositionTarget_Rendering(sender, e);
					return;
				}
				this.UnwireRenderingEvent();
			}

			// Token: 0x060016FD RID: 5885 RVA: 0x0005A4BC File Offset: 0x000586BC
			internal void UnwireRenderingEvent()
			{
				if (this._isWired)
				{
					global::System.Windows.Media.CompositionTarget.Rendering -= this.OnCompositionTarget_Rendering;
				}
				this._isWired = false;
			}

			// Token: 0x060016FE RID: 5886 RVA: 0x0005A4DE File Offset: 0x000586DE
			internal void WireRenderingEvent()
			{
				if (this._isWired)
				{
					return;
				}
				this._isWired = true;
				global::System.Windows.Media.CompositionTarget.Rendering += this.OnCompositionTarget_Rendering;
			}

			// Token: 0x04000B23 RID: 2851
			private global::System.WeakReference _panelRef;

			// Token: 0x04000B24 RID: 2852
			private bool _isWired;
		}

		// Token: 0x02000226 RID: 550
		internal class ScrollData
		{
			// Token: 0x060016FF RID: 5887 RVA: 0x0005A501 File Offset: 0x00058701
			internal void Reset()
			{
				this._offset = default(global::System.Windows.Vector);
				this._extent = default(global::System.Windows.Size);
				this._viewport = default(global::System.Windows.Size);
			}

			// Token: 0x04000B25 RID: 2853
			internal global::System.Windows.Controls.ScrollViewer _scrollOwner;

			// Token: 0x04000B26 RID: 2854
			internal global::System.Windows.Size _extent = default(global::System.Windows.Size);

			// Token: 0x04000B27 RID: 2855
			internal global::System.Windows.Size _viewport = default(global::System.Windows.Size);

			// Token: 0x04000B28 RID: 2856
			internal global::System.Windows.Vector _offset = default(global::System.Windows.Vector);

			// Token: 0x04000B29 RID: 2857
			internal bool _canHorizontallyScroll;

			// Token: 0x04000B2A RID: 2858
			internal bool _canVerticallyScroll;
		}

		// Token: 0x02000227 RID: 551
		internal struct PathFractionPoint
		{
			// Token: 0x06001701 RID: 5889 RVA: 0x0005A553 File Offset: 0x00058753
			internal PathFractionPoint(global::System.Windows.Point point, global::System.Windows.Point tangentPoint)
			{
				this.Point = point;
				this.TangentPoint = tangentPoint;
			}

			// Token: 0x04000B2B RID: 2859
			internal global::System.Windows.Point Point;

			// Token: 0x04000B2C RID: 2860
			internal global::System.Windows.Point TangentPoint;
		}

		// Token: 0x02000228 RID: 552
		internal struct ScrollActionInfo
		{
			// Token: 0x06001702 RID: 5890 RVA: 0x0005A563 File Offset: 0x00058763
			internal ScrollActionInfo(double offsetBeforeScroll, double offsetAfterScroll, bool scrollingHigher, global::Infragistics.Windows.Controls.XamCarouselPanel carouselPanel)
			{
				this.OffsetAfterScroll = offsetAfterScroll;
				this.OffsetBeforeScroll = offsetBeforeScroll;
				this.ScrollingHigher = scrollingHigher;
				this.CarouselPanel = carouselPanel;
			}

			// Token: 0x1700052C RID: 1324
			// (get) Token: 0x06001703 RID: 5891 RVA: 0x0005A582 File Offset: 0x00058782
			internal bool IsEmpty
			{
				get
				{
					return this.OffsetBeforeScroll == double.NegativeInfinity && this.OffsetAfterScroll == double.NegativeInfinity;
				}
			}

			// Token: 0x1700052D RID: 1325
			// (get) Token: 0x06001704 RID: 5892 RVA: 0x0005A5A8 File Offset: 0x000587A8
			internal int ScrollAmount
			{
				get
				{
					if (this.CarouselPanel.ViewSettingsInternal.IsListContinuous)
					{
						if (this.ScrollingHigher)
						{
							if (this.OffsetBeforeScroll > this.OffsetAfterScroll)
							{
								return this.CarouselPanel.TotalItemCount - (int)this.OffsetBeforeScroll + ((int)this.OffsetAfterScroll + 1);
							}
						}
						else if (this.OffsetBeforeScroll < this.OffsetAfterScroll)
						{
							return -((int)this.OffsetBeforeScroll + (this.CarouselPanel.TotalItemCount - (int)this.OffsetAfterScroll));
						}
					}
					return (int)(this.OffsetAfterScroll - this.OffsetBeforeScroll);
				}
			}

			// Token: 0x1700052E RID: 1326
			// (get) Token: 0x06001705 RID: 5893 RVA: 0x0005A634 File Offset: 0x00058834
			internal int ScrollAmountAbsolute
			{
				get
				{
					return global::System.Math.Abs(this.ScrollAmount);
				}
			}

			// Token: 0x04000B2D RID: 2861
			internal double OffsetBeforeScroll;

			// Token: 0x04000B2E RID: 2862
			internal double OffsetAfterScroll;

			// Token: 0x04000B2F RID: 2863
			internal static global::Infragistics.Windows.Controls.XamCarouselPanel.ScrollActionInfo Empty = new global::Infragistics.Windows.Controls.XamCarouselPanel.ScrollActionInfo(double.NegativeInfinity, double.NegativeInfinity, false, null);

			// Token: 0x04000B30 RID: 2864
			internal bool ScrollingHigher;

			// Token: 0x04000B31 RID: 2865
			internal global::Infragistics.Windows.Controls.XamCarouselPanel CarouselPanel;
		}
	}
}
