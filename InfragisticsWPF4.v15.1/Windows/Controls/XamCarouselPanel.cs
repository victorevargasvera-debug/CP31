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
using Infragistics.Themes;
using Infragistics.Windows.Commands;
using Infragistics.Windows.Controls.Events;
using Infragistics.Windows.Licensing;
using Infragistics.Windows.Selection;
using Infragistics.Windows.Virtualization;

namespace Infragistics.Windows.Controls
{
	// Token: 0x02000258 RID: 600
	[global::Infragistics.Windows.Licensing.UltraLicense("XamCarouselPanel", global::Infragistics.Windows.Licensing.UltraLicenseAttribute.WpfProductType.DV | global::Infragistics.Windows.Licensing.UltraLicenseAttribute.WpfProductType.LOB)]
	[global::System.ComponentModel.LicenseProvider(typeof(global::Infragistics.Windows.Licensing.UltraLicenseProvider))]
	public class XamCarouselPanel : global::Infragistics.Windows.Virtualization.RecyclingItemsPanel, global::System.Windows.Controls.Primitives.IScrollInfo, global::System.Windows.IWeakEventListener, global::Infragistics.Windows.Commands.ICommandHost
	{
		// Token: 0x06001848 RID: 6216 RVA: 0x0005CC00 File Offset: 0x0005AE00
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

		// Token: 0x06001849 RID: 6217 RVA: 0x0005CCE0 File Offset: 0x0005AEE0
		static XamCarouselPanel()
		{
			global::Infragistics.Windows.Controls.XamCarouselPanel.ExecutingCommandEvent = global::System.Windows.EventManager.RegisterRoutedEvent("ExecutingCommand", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.EventHandler<global::Infragistics.Windows.Controls.Events.ExecutingCommandEventArgs>), typeof(global::Infragistics.Windows.Controls.XamCarouselPanel));
			global::Infragistics.Windows.Controls.XamCarouselPanel.ExecutedCommandEvent = global::System.Windows.EventManager.RegisterRoutedEvent("ExecutedCommand", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.EventHandler<global::Infragistics.Windows.Controls.Events.ExecutedCommandEventArgs>), typeof(global::Infragistics.Windows.Controls.XamCarouselPanel));
			global::Infragistics.Themes.ThemeManager.RegisterControl(typeof(global::Infragistics.Windows.Controls.XamCarouselPanel));
		}

		// Token: 0x0600184A RID: 6218 RVA: 0x0005CF3D File Offset: 0x0005B13D
		protected override global::System.Windows.Size ArrangeOverride(global::System.Windows.Size finalSize)
		{
			this.DoArrangeProcessing(finalSize, true);
			return finalSize;
		}

		// Token: 0x0600184B RID: 6219 RVA: 0x0005CF48 File Offset: 0x0005B148
		protected override global::System.Windows.Controls.UIElementCollection CreateUIElementCollection(global::System.Windows.FrameworkElement logicalParent)
		{
			global::Infragistics.Windows.Controls.CarouselPanelUIElementCollection carouselPanelUIElementCollection = new global::Infragistics.Windows.Controls.CarouselPanelUIElementCollection(this, this, logicalParent);
			carouselPanelUIElementCollection.CollectionChanged += this.OnChildrenCollectionChanged;
			return carouselPanelUIElementCollection;
		}

		// Token: 0x0600184C RID: 6220 RVA: 0x0005CF71 File Offset: 0x0005B171
		protected override bool GetCanCleanupItem(int itemIndex)
		{
			return !this.GetIsItemIndexVisible(itemIndex, this.FirstVisibleItemIndex);
		}

		// Token: 0x1700056A RID: 1386
		// (get) Token: 0x0600184D RID: 6221 RVA: 0x0005CF83 File Offset: 0x0005B183
		protected override bool IsOkToCleanupUnusedGeneratedElements
		{
			get
			{
				return !this.ScrollInProgress;
			}
		}

		// Token: 0x1700056B RID: 1387
		// (get) Token: 0x0600184E RID: 6222 RVA: 0x0005CF90 File Offset: 0x0005B190
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

		// Token: 0x1700056C RID: 1388
		// (get) Token: 0x0600184F RID: 6223 RVA: 0x0005CFE8 File Offset: 0x0005B1E8
		protected override int MaximumUnusedGeneratedItemsToKeep
		{
			get
			{
				return global::System.Math.Min(this.ItemsPerPageResolved * 5, 100);
			}
		}

		// Token: 0x06001850 RID: 6224 RVA: 0x0005CFFC File Offset: 0x0005B1FC
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

		// Token: 0x06001851 RID: 6225 RVA: 0x0005D0EB File Offset: 0x0005B2EB
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

		// Token: 0x06001852 RID: 6226 RVA: 0x0005D124 File Offset: 0x0005B324
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

		// Token: 0x06001853 RID: 6227 RVA: 0x0005D1A8 File Offset: 0x0005B3A8
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

		// Token: 0x06001854 RID: 6228 RVA: 0x0005D2E4 File Offset: 0x0005B4E4
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

		// Token: 0x06001855 RID: 6229 RVA: 0x0005D544 File Offset: 0x0005B744
		protected override void OnMouseDown(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			base.OnMouseDown(e);
			if (!base.IsFocused)
			{
				base.Focus();
			}
		}

		// Token: 0x06001856 RID: 6230 RVA: 0x0005D55C File Offset: 0x0005B75C
		protected override void OnNewElementRealized(global::System.Windows.UIElement element, int index)
		{
		}

		// Token: 0x06001857 RID: 6231 RVA: 0x0005D560 File Offset: 0x0005B760
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

		// Token: 0x06001858 RID: 6232 RVA: 0x0005D660 File Offset: 0x0005B860
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

		// Token: 0x1700056D RID: 1389
		// (get) Token: 0x06001859 RID: 6233 RVA: 0x0005D6CC File Offset: 0x0005B8CC
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

		// Token: 0x1700056E RID: 1390
		// (get) Token: 0x0600185A RID: 6234 RVA: 0x0005D729 File Offset: 0x0005B929
		public double ExtentHeight
		{
			get
			{
				return this.ScrollingData._extent.Height;
			}
		}

		// Token: 0x1700056F RID: 1391
		// (get) Token: 0x0600185B RID: 6235 RVA: 0x0005D73B File Offset: 0x0005B93B
		public double ExtentWidth
		{
			get
			{
				return this.ScrollingData._extent.Width;
			}
		}

		// Token: 0x17000570 RID: 1392
		// (get) Token: 0x0600185C RID: 6236 RVA: 0x0005D74D File Offset: 0x0005B94D
		public double HorizontalOffset
		{
			get
			{
				return this.ScrollingData._offset.Y;
			}
		}

		// Token: 0x17000571 RID: 1393
		// (get) Token: 0x0600185D RID: 6237 RVA: 0x0005D75F File Offset: 0x0005B95F
		public double VerticalOffset
		{
			get
			{
				return this.ScrollingData._offset.Y;
			}
		}

		// Token: 0x0600185E RID: 6238 RVA: 0x0005D774 File Offset: 0x0005B974
		public void SetHorizontalOffset(double offset)
		{
			this.SetHorizontalOffset(offset, null);
		}

		// Token: 0x0600185F RID: 6239 RVA: 0x0005D791 File Offset: 0x0005B991
		internal void SetHorizontalOffset(double offset, bool? scrollingHigherHint)
		{
			this.SetVerticalOffset(offset, scrollingHigherHint);
		}

		// Token: 0x06001860 RID: 6240 RVA: 0x0005D79C File Offset: 0x0005B99C
		public void SetVerticalOffset(double offset)
		{
			this.SetVerticalOffset(offset, null);
		}

		// Token: 0x06001861 RID: 6241 RVA: 0x0005D7BC File Offset: 0x0005B9BC
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

		// Token: 0x06001862 RID: 6242 RVA: 0x0005DB72 File Offset: 0x0005BD72
		public void LineDown()
		{
			this.SetVerticalOffset(this.VerticalOffset + 1.0, new bool?(true));
		}

		// Token: 0x06001863 RID: 6243 RVA: 0x0005DB90 File Offset: 0x0005BD90
		public void LineLeft()
		{
			this.SetHorizontalOffset(this.HorizontalOffset - 1.0, new bool?(false));
		}

		// Token: 0x06001864 RID: 6244 RVA: 0x0005DBAE File Offset: 0x0005BDAE
		public void LineRight()
		{
			this.SetHorizontalOffset(this.HorizontalOffset + 1.0, new bool?(true));
		}

		// Token: 0x06001865 RID: 6245 RVA: 0x0005DBCC File Offset: 0x0005BDCC
		public void LineUp()
		{
			this.SetVerticalOffset(this.VerticalOffset - 1.0, new bool?(false));
		}

		// Token: 0x06001866 RID: 6246 RVA: 0x0005DBEA File Offset: 0x0005BDEA
		public void MouseWheelDown()
		{
			this.SetVerticalOffset(this.VerticalOffset + 1.0, new bool?(true));
		}

		// Token: 0x06001867 RID: 6247 RVA: 0x0005DC08 File Offset: 0x0005BE08
		public void MouseWheelLeft()
		{
			this.SetVerticalOffset(this.VerticalOffset - 1.0, new bool?(false));
		}

		// Token: 0x06001868 RID: 6248 RVA: 0x0005DC26 File Offset: 0x0005BE26
		public void MouseWheelRight()
		{
			this.SetVerticalOffset(this.VerticalOffset + 1.0, new bool?(true));
		}

		// Token: 0x06001869 RID: 6249 RVA: 0x0005DC44 File Offset: 0x0005BE44
		public void MouseWheelUp()
		{
			this.SetVerticalOffset(this.VerticalOffset - 1.0, new bool?(false));
		}

		// Token: 0x0600186A RID: 6250 RVA: 0x0005DC62 File Offset: 0x0005BE62
		public void PageDown()
		{
			this.SetVerticalOffset(this.VerticalOffset + (double)this.ScrollLargeChange, new bool?(true));
		}

		// Token: 0x0600186B RID: 6251 RVA: 0x0005DC7E File Offset: 0x0005BE7E
		public void PageLeft()
		{
			this.SetHorizontalOffset(this.HorizontalOffset - (double)this.ScrollLargeChange, new bool?(false));
		}

		// Token: 0x0600186C RID: 6252 RVA: 0x0005DC9A File Offset: 0x0005BE9A
		public void PageRight()
		{
			this.SetHorizontalOffset(this.HorizontalOffset + (double)this.ScrollLargeChange, new bool?(true));
		}

		// Token: 0x0600186D RID: 6253 RVA: 0x0005DCB6 File Offset: 0x0005BEB6
		public void PageUp()
		{
			this.SetVerticalOffset(this.VerticalOffset - (double)this.ScrollLargeChange, new bool?(false));
		}

		// Token: 0x17000572 RID: 1394
		// (get) Token: 0x0600186E RID: 6254 RVA: 0x0005DCD2 File Offset: 0x0005BED2
		// (set) Token: 0x0600186F RID: 6255 RVA: 0x0005DCDF File Offset: 0x0005BEDF
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

		// Token: 0x17000573 RID: 1395
		// (get) Token: 0x06001870 RID: 6256 RVA: 0x0005DD06 File Offset: 0x0005BF06
		public double ViewportHeight
		{
			get
			{
				return this.ScrollingData._viewport.Height;
			}
		}

		// Token: 0x17000574 RID: 1396
		// (get) Token: 0x06001871 RID: 6257 RVA: 0x0005DD18 File Offset: 0x0005BF18
		public double ViewportWidth
		{
			get
			{
				return this.ScrollingData._viewport.Width;
			}
		}

		// Token: 0x06001872 RID: 6258 RVA: 0x0005DD2C File Offset: 0x0005BF2C
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

		// Token: 0x17000575 RID: 1397
		// (get) Token: 0x06001873 RID: 6259 RVA: 0x0005DD78 File Offset: 0x0005BF78
		// (set) Token: 0x06001874 RID: 6260 RVA: 0x0005DD85 File Offset: 0x0005BF85
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

		// Token: 0x17000576 RID: 1398
		// (get) Token: 0x06001875 RID: 6261 RVA: 0x0005DDA7 File Offset: 0x0005BFA7
		// (set) Token: 0x06001876 RID: 6262 RVA: 0x0005DDB4 File Offset: 0x0005BFB4
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

		// Token: 0x17000577 RID: 1399
		// (get) Token: 0x06001877 RID: 6263 RVA: 0x0005DDD6 File Offset: 0x0005BFD6
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public bool CanNavigateToPreviousItem
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.Controls.XamCarouselPanel.CanNavigateToPreviousItemProperty);
			}
		}

		// Token: 0x17000578 RID: 1400
		// (get) Token: 0x06001878 RID: 6264 RVA: 0x0005DDE8 File Offset: 0x0005BFE8
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

		// Token: 0x17000579 RID: 1401
		// (get) Token: 0x06001879 RID: 6265 RVA: 0x0005DDFA File Offset: 0x0005BFFA
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		public bool CanNavigateToNextItem
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.Controls.XamCarouselPanel.CanNavigateToNextItemProperty);
			}
		}

		// Token: 0x1700057A RID: 1402
		// (get) Token: 0x0600187A RID: 6266 RVA: 0x0005DE0C File Offset: 0x0005C00C
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public bool CanNavigateToNextPage
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.Controls.XamCarouselPanel.CanNavigateToNextPageProperty);
			}
		}

		// Token: 0x1700057B RID: 1403
		// (get) Token: 0x0600187B RID: 6267 RVA: 0x0005DE1E File Offset: 0x0005C01E
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

		// Token: 0x1700057C RID: 1404
		// (get) Token: 0x0600187C RID: 6268 RVA: 0x0005DE30 File Offset: 0x0005C030
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
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

		// Token: 0x1700057D RID: 1405
		// (get) Token: 0x0600187D RID: 6269 RVA: 0x0005DE69 File Offset: 0x0005C069
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

		// Token: 0x1700057E RID: 1406
		// (get) Token: 0x0600187E RID: 6270 RVA: 0x0005DE9D File Offset: 0x0005C09D
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

		// Token: 0x1700057F RID: 1407
		// (get) Token: 0x0600187F RID: 6271 RVA: 0x0005DEB9 File Offset: 0x0005C0B9
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

		// Token: 0x17000580 RID: 1408
		// (get) Token: 0x06001880 RID: 6272 RVA: 0x0005DECB File Offset: 0x0005C0CB
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

		// Token: 0x17000581 RID: 1409
		// (get) Token: 0x06001881 RID: 6273 RVA: 0x0005DEFF File Offset: 0x0005C0FF
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

		// Token: 0x17000582 RID: 1410
		// (get) Token: 0x06001882 RID: 6274 RVA: 0x0005DF1B File Offset: 0x0005C11B
		// (set) Token: 0x06001883 RID: 6275 RVA: 0x0005DF23 File Offset: 0x0005C123
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

		// Token: 0x17000583 RID: 1411
		// (get) Token: 0x06001884 RID: 6276 RVA: 0x0005DF2C File Offset: 0x0005C12C
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
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

		// Token: 0x17000584 RID: 1412
		// (get) Token: 0x06001885 RID: 6277 RVA: 0x0005DF60 File Offset: 0x0005C160
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

		// Token: 0x17000585 RID: 1413
		// (get) Token: 0x06001886 RID: 6278 RVA: 0x0005DF7C File Offset: 0x0005C17C
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
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

		// Token: 0x17000586 RID: 1414
		// (get) Token: 0x06001887 RID: 6279 RVA: 0x0005DFB0 File Offset: 0x0005C1B0
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

		// Token: 0x06001888 RID: 6280 RVA: 0x0005DFCC File Offset: 0x0005C1CC
		private static object OnCoerceViewSettings(global::System.Windows.DependencyObject d, object value)
		{
			if (value == null && !global::System.ComponentModel.DesignerProperties.GetIsInDesignMode(d))
			{
				return new global::Infragistics.Windows.Controls.CarouselViewSettings();
			}
			return value;
		}

		// Token: 0x17000587 RID: 1415
		// (get) Token: 0x06001889 RID: 6281 RVA: 0x0005DFE0 File Offset: 0x0005C1E0
		// (set) Token: 0x0600188A RID: 6282 RVA: 0x0005E014 File Offset: 0x0005C214
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

		// Token: 0x0600188B RID: 6283 RVA: 0x0005E022 File Offset: 0x0005C222
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeViewSettings()
		{
			return this.ViewSettings != (global::Infragistics.Windows.Controls.CarouselViewSettings)global::Infragistics.Windows.Controls.XamCarouselPanel.ViewSettingsProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x0600188C RID: 6284 RVA: 0x0005E043 File Offset: 0x0005C243
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetViewSettings()
		{
			this.ViewSettings = (global::Infragistics.Windows.Controls.CarouselViewSettings)global::Infragistics.Windows.Controls.XamCarouselPanel.ViewSettingsProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x17000588 RID: 1416
		// (get) Token: 0x0600188D RID: 6285 RVA: 0x0005E060 File Offset: 0x0005C260
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
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

		// Token: 0x17000589 RID: 1417
		// (get) Token: 0x0600188E RID: 6286 RVA: 0x0005E0AC File Offset: 0x0005C2AC
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

		// Token: 0x1700058A RID: 1418
		// (get) Token: 0x0600188F RID: 6287 RVA: 0x0005E0D5 File Offset: 0x0005C2D5
		internal int FirstVisibleChildIndex
		{
			get
			{
				return base.GetChildIndexFromItemIndex(this.FirstVisibleItemIndex);
			}
		}

		// Token: 0x1700058B RID: 1419
		// (get) Token: 0x06001890 RID: 6288 RVA: 0x0005E0E3 File Offset: 0x0005C2E3
		// (set) Token: 0x06001891 RID: 6289 RVA: 0x0005E0F5 File Offset: 0x0005C2F5
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

		// Token: 0x1700058C RID: 1420
		// (get) Token: 0x06001892 RID: 6290 RVA: 0x0005E108 File Offset: 0x0005C308
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

		// Token: 0x1700058D RID: 1421
		// (get) Token: 0x06001893 RID: 6291 RVA: 0x0005E123 File Offset: 0x0005C323
		internal int ScrollLargeChange
		{
			get
			{
				return this.ItemsPerPageResolved;
			}
		}

		// Token: 0x1700058E RID: 1422
		// (get) Token: 0x06001894 RID: 6292 RVA: 0x0005E12C File Offset: 0x0005C32C
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

		// Token: 0x1700058F RID: 1423
		// (get) Token: 0x06001895 RID: 6293 RVA: 0x0005E15E File Offset: 0x0005C35E
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		protected bool ItemsHostSupportsSelection
		{
			get
			{
				return this.SelectionHost != null;
			}
		}

		// Token: 0x17000590 RID: 1424
		// (get) Token: 0x06001896 RID: 6294 RVA: 0x0005E16C File Offset: 0x0005C36C
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		protected internal global::Infragistics.Windows.Controls.CarouselPanelAdorner CarouselPanelAdorner
		{
			get
			{
				return this._carouselPanelAdorner;
			}
		}

		// Token: 0x17000591 RID: 1425
		// (get) Token: 0x06001897 RID: 6295 RVA: 0x0005E174 File Offset: 0x0005C374
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

		// Token: 0x17000592 RID: 1426
		// (get) Token: 0x06001898 RID: 6296 RVA: 0x0005E1B9 File Offset: 0x0005C3B9
		// (set) Token: 0x06001899 RID: 6297 RVA: 0x0005E1C1 File Offset: 0x0005C3C1
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

		// Token: 0x17000593 RID: 1427
		// (get) Token: 0x0600189A RID: 6298 RVA: 0x0005E1CA File Offset: 0x0005C3CA
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		protected bool ScrollInProgress
		{
			get
			{
				return !this._scrollActionInfo.IsEmpty;
			}
		}

		// Token: 0x17000594 RID: 1428
		// (get) Token: 0x0600189B RID: 6299 RVA: 0x0005E1DA File Offset: 0x0005C3DA
		// (set) Token: 0x0600189C RID: 6300 RVA: 0x0005E1E2 File Offset: 0x0005C3E2
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

		// Token: 0x17000595 RID: 1429
		// (get) Token: 0x0600189D RID: 6301 RVA: 0x0005E1EB File Offset: 0x0005C3EB
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

		// Token: 0x17000596 RID: 1430
		// (get) Token: 0x0600189E RID: 6302 RVA: 0x0005E214 File Offset: 0x0005C414
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

		// Token: 0x17000597 RID: 1431
		// (get) Token: 0x0600189F RID: 6303 RVA: 0x0005E2B2 File Offset: 0x0005C4B2
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

		// Token: 0x17000598 RID: 1432
		// (get) Token: 0x060018A0 RID: 6304 RVA: 0x0005E2F0 File Offset: 0x0005C4F0
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

		// Token: 0x17000599 RID: 1433
		// (get) Token: 0x060018A1 RID: 6305 RVA: 0x0005E35C File Offset: 0x0005C55C
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

		// Token: 0x1700059A RID: 1434
		// (get) Token: 0x060018A2 RID: 6306 RVA: 0x0005E3C8 File Offset: 0x0005C5C8
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

		// Token: 0x1700059B RID: 1435
		// (get) Token: 0x060018A3 RID: 6307 RVA: 0x0005E434 File Offset: 0x0005C634
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

		// Token: 0x1700059C RID: 1436
		// (get) Token: 0x060018A4 RID: 6308 RVA: 0x0005E4A0 File Offset: 0x0005C6A0
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

		// Token: 0x1700059D RID: 1437
		// (get) Token: 0x060018A5 RID: 6309 RVA: 0x0005E50C File Offset: 0x0005C70C
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

		// Token: 0x1700059E RID: 1438
		// (get) Token: 0x060018A6 RID: 6310 RVA: 0x0005E5A8 File Offset: 0x0005C7A8
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

		// Token: 0x1700059F RID: 1439
		// (get) Token: 0x060018A7 RID: 6311 RVA: 0x0005E670 File Offset: 0x0005C870
		private double HighestPossibleScrollOffset
		{
			get
			{
				return this.ScrollingData._extent.Height - 1.0;
			}
		}

		// Token: 0x170005A0 RID: 1440
		// (get) Token: 0x060018A8 RID: 6312 RVA: 0x0005E68C File Offset: 0x0005C88C
		private bool IsEntireListVisible
		{
			get
			{
				return this.TotalItemCount <= this.ItemsPerPageResolved;
			}
		}

		// Token: 0x170005A1 RID: 1441
		// (get) Token: 0x060018A9 RID: 6313 RVA: 0x0005E6A0 File Offset: 0x0005C8A0
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

		// Token: 0x170005A2 RID: 1442
		// (get) Token: 0x060018AA RID: 6314 RVA: 0x0005E748 File Offset: 0x0005C948
		private int LastVisibleItemIndex
		{
			get
			{
				return this.GetLastVisibleItemIndex(this.FirstVisibleItemIndex);
			}
		}

		// Token: 0x170005A3 RID: 1443
		// (get) Token: 0x060018AB RID: 6315 RVA: 0x0005E756 File Offset: 0x0005C956
		private double LowestPossibleScrollOffset
		{
			get
			{
				return 0.0 - (this.ScrollingData._viewport.Height - 1.0);
			}
		}

		// Token: 0x170005A4 RID: 1444
		// (get) Token: 0x060018AC RID: 6316 RVA: 0x0005E77C File Offset: 0x0005C97C
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

		// Token: 0x170005A5 RID: 1445
		// (get) Token: 0x060018AD RID: 6317 RVA: 0x0005E79C File Offset: 0x0005C99C
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

		// Token: 0x170005A6 RID: 1446
		// (get) Token: 0x060018AE RID: 6318 RVA: 0x0005E7E7 File Offset: 0x0005C9E7
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

		// Token: 0x170005A7 RID: 1447
		// (get) Token: 0x060018AF RID: 6319 RVA: 0x0005E80C File Offset: 0x0005CA0C
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

		// Token: 0x060018B0 RID: 6320 RVA: 0x0005E880 File Offset: 0x0005CA80
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

		// Token: 0x060018B1 RID: 6321 RVA: 0x0005E8DF File Offset: 0x0005CADF
		public bool ExecuteCommand(global::Infragistics.Windows.Commands.CommandWrapper commandWrapper)
		{
			if (commandWrapper == null)
			{
				throw new global::System.ArgumentNullException("commandWrapper");
			}
			return this.ExecuteCommand(commandWrapper.Command);
		}

		// Token: 0x060018B2 RID: 6322 RVA: 0x0005E8FC File Offset: 0x0005CAFC
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

		// Token: 0x060018B3 RID: 6323 RVA: 0x0005E988 File Offset: 0x0005CB88
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

		// Token: 0x060018B4 RID: 6324 RVA: 0x0005ED60 File Offset: 0x0005CF60
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

		// Token: 0x060018B5 RID: 6325 RVA: 0x0005EDBB File Offset: 0x0005CFBB
		private void BumpCarouselViewSettingsVersion()
		{
			base.SetValue(global::Infragistics.Windows.Controls.XamCarouselPanel.ViewSettingsVersionProperty, (int)base.GetValue(global::Infragistics.Windows.Controls.XamCarouselPanel.ViewSettingsVersionProperty) + 1);
		}

		// Token: 0x060018B6 RID: 6326 RVA: 0x0005EDE0 File Offset: 0x0005CFE0
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

		// Token: 0x060018B7 RID: 6327 RVA: 0x0005EF10 File Offset: 0x0005D110
		private static double CalculateRotationFromTangentPoint(global::System.Windows.Point tangentPoint)
		{
			double num = global::System.Math.Acos(tangentPoint.X) * 57.29577951308232;
			if (tangentPoint.Y < 0.0)
			{
				num = 360.0 - num;
			}
			return num;
		}

		// Token: 0x060018B8 RID: 6328 RVA: 0x0005EF54 File Offset: 0x0005D154
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

		// Token: 0x060018B9 RID: 6329 RVA: 0x0005F11C File Offset: 0x0005D31C
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

		// Token: 0x060018BA RID: 6330 RVA: 0x0005F4B4 File Offset: 0x0005D6B4
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

		// Token: 0x060018BB RID: 6331 RVA: 0x0005F4F8 File Offset: 0x0005D6F8
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
						if (uielement is global::Infragistics.Windows.Controls.CarouselListBoxItem)
						{
							((global::Infragistics.Windows.Controls.CarouselListBoxItem)uielement).IndexOfItem = num2;
						}
					}
					num++;
					num2++;
				}
			}
			return num3;
		}

		// Token: 0x060018BC RID: 6332 RVA: 0x0005F5F0 File Offset: 0x0005D7F0
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

		// Token: 0x060018BD RID: 6333 RVA: 0x0005F64C File Offset: 0x0005D84C
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

		// Token: 0x060018BE RID: 6334 RVA: 0x0005F698 File Offset: 0x0005D898
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

		// Token: 0x060018BF RID: 6335 RVA: 0x0005F6FC File Offset: 0x0005D8FC
		private bool GetIsItemIndexInLastVisiblePosition(int itemIndex, double scrollOffset)
		{
			int num = ((int)scrollOffset < 0) ? (itemIndex + global::System.Math.Abs((int)scrollOffset)) : (itemIndex - (int)scrollOffset);
			return num == this.ItemsPerPageResolved - 1;
		}

		// Token: 0x060018C0 RID: 6336 RVA: 0x0005F72C File Offset: 0x0005D92C
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

		// Token: 0x060018C1 RID: 6337 RVA: 0x0005F77C File Offset: 0x0005D97C
		private int GetLastVisibleItemIndex(int scrollOffset)
		{
			return this.LastVisibleItemIndexFromFirstVisibleItemIndex(scrollOffset);
		}

		// Token: 0x060018C2 RID: 6338 RVA: 0x0005F785 File Offset: 0x0005D985
		private double GetPrefixAreaPenetrationPercent(double pathPositionPercentage, global::Infragistics.Windows.Controls.CarouselViewSettings viewSettings)
		{
			if (viewSettings.ItemPathPrefixPercent == 0.0)
			{
				return 0.0;
			}
			return pathPositionPercentage / viewSettings.ItemPathPrefixPercent;
		}

		// Token: 0x060018C3 RID: 6339 RVA: 0x0005F7AC File Offset: 0x0005D9AC
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

		// Token: 0x060018C4 RID: 6340 RVA: 0x0005F810 File Offset: 0x0005DA10
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

		// Token: 0x060018C5 RID: 6341 RVA: 0x0005F85F File Offset: 0x0005DA5F
		private double GetSuffixAreaPenetrationPercent(double pathPositionPercentage, global::Infragistics.Windows.Controls.CarouselViewSettings viewSettings)
		{
			if (viewSettings.ItemPathSuffixPercent == 0.0)
			{
				return 0.0;
			}
			return (1.0 - pathPositionPercentage) / viewSettings.ItemPathSuffixPercent;
		}

		// Token: 0x060018C6 RID: 6342 RVA: 0x0005F890 File Offset: 0x0005DA90
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

		// Token: 0x060018C7 RID: 6343 RVA: 0x0005F8EC File Offset: 0x0005DAEC
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

		// Token: 0x060018C8 RID: 6344 RVA: 0x0005F9EF File Offset: 0x0005DBEF
		private bool InPathPrefixArea(double pathPositionPercentage, global::Infragistics.Windows.Controls.CarouselViewSettings viewSettings)
		{
			return pathPositionPercentage < viewSettings.ItemPathPrefixPercent;
		}

		// Token: 0x060018C9 RID: 6345 RVA: 0x0005F9FA File Offset: 0x0005DBFA
		private bool InPathSuffixArea(double pathPositionPercentage, global::Infragistics.Windows.Controls.CarouselViewSettings viewSettings)
		{
			return pathPositionPercentage > 1.0 - viewSettings.ItemPathSuffixPercent;
		}

		// Token: 0x060018CA RID: 6346 RVA: 0x0005FA10 File Offset: 0x0005DC10
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

		// Token: 0x060018CB RID: 6347 RVA: 0x0005FA59 File Offset: 0x0005DC59
		private void OnChildrenCollectionChanged(object sender, global::System.EventArgs e)
		{
			if (this.ScrollInProgress)
			{
				this.StopAnimatedScrollProcessing();
			}
		}

		// Token: 0x060018CC RID: 6348 RVA: 0x0005FA6C File Offset: 0x0005DC6C
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

		// Token: 0x060018CD RID: 6349 RVA: 0x0005FAD0 File Offset: 0x0005DCD0
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

		// Token: 0x060018CE RID: 6350 RVA: 0x0005FB65 File Offset: 0x0005DD65
		private void OnOpacityEffectStopsCollectionChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			base.InvalidateArrange();
		}

		// Token: 0x060018CF RID: 6351 RVA: 0x0005FB6D File Offset: 0x0005DD6D
		private void OnScalingEffectStopsCollectionChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			base.InvalidateArrange();
		}

		// Token: 0x060018D0 RID: 6352 RVA: 0x0005FB75 File Offset: 0x0005DD75
		private void OnSkewAngleXEffectStopsCollectionChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			base.InvalidateArrange();
		}

		// Token: 0x060018D1 RID: 6353 RVA: 0x0005FB7D File Offset: 0x0005DD7D
		private void OnSkewAngleYEffectStopsCollectionChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			base.InvalidateArrange();
		}

		// Token: 0x060018D2 RID: 6354 RVA: 0x0005FB88 File Offset: 0x0005DD88
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

		// Token: 0x060018D3 RID: 6355 RVA: 0x0005FF64 File Offset: 0x0005E164
		private void OnZOrderEffectStopsCollectionChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			this.SetZOrder();
		}

		// Token: 0x060018D4 RID: 6356 RVA: 0x0005FF6C File Offset: 0x0005E16C
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

		// Token: 0x060018D5 RID: 6357 RVA: 0x0005FF9C File Offset: 0x0005E19C
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

		// Token: 0x060018D6 RID: 6358 RVA: 0x00060018 File Offset: 0x0005E218
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

		// Token: 0x060018D7 RID: 6359 RVA: 0x000600D0 File Offset: 0x0005E2D0
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

		// Token: 0x060018D8 RID: 6360 RVA: 0x00060134 File Offset: 0x0005E334
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

		// Token: 0x060018D9 RID: 6361 RVA: 0x000604EC File Offset: 0x0005E6EC
		private static double SecondsFromTicks(long ticks)
		{
			return (double)ticks / 10000000.0;
		}

		// Token: 0x060018DA RID: 6362 RVA: 0x00060508 File Offset: 0x0005E708
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

		// Token: 0x060018DB RID: 6363 RVA: 0x000607C6 File Offset: 0x0005E9C6
		private void StartAnimatedScrollProcessing(global::Infragistics.Windows.Controls.XamCarouselPanel.ScrollActionInfo scrollActionInfo)
		{
			this._scrollActionInfo = scrollActionInfo;
			if (this._renderingEventProxy == null)
			{
				this._renderingEventProxy = new global::Infragistics.Windows.Controls.XamCarouselPanel.RenderingEventProxy(this);
			}
			this._renderingEventProxy.WireRenderingEvent();
		}

		// Token: 0x060018DC RID: 6364 RVA: 0x000607EE File Offset: 0x0005E9EE
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

		// Token: 0x060018DD RID: 6365 RVA: 0x0006082C File Offset: 0x0005EA2C
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

		// Token: 0x060018DE RID: 6366 RVA: 0x00060927 File Offset: 0x0005EB27
		private static void UpdateFirstAndLastItemPropertiesOnChild(global::Infragistics.Windows.Controls.CarouselPanelItem child, int childsItemIndex, int totalItemCount)
		{
			if (child == null)
			{
				return;
			}
			child.SetValue(global::Infragistics.Windows.Controls.CarouselPanelItem.IsFirstItemPropertyKey, childsItemIndex == 0);
			child.SetValue(global::Infragistics.Windows.Controls.CarouselPanelItem.IsLastItemPropertyKey, childsItemIndex == totalItemCount - 1);
		}

		// Token: 0x060018DF RID: 6367 RVA: 0x00060958 File Offset: 0x0005EB58
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

		// Token: 0x060018E0 RID: 6368 RVA: 0x000609F0 File Offset: 0x0005EBF0
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

		// Token: 0x060018E1 RID: 6369 RVA: 0x00060BDC File Offset: 0x0005EDDC
		protected void AddAdornerChildElement(global::System.Windows.UIElement childElement)
		{
			if (this.CarouselPanelAdorner != null)
			{
				this.CarouselPanelAdorner.AddChildElement(childElement);
			}
		}

		// Token: 0x060018E2 RID: 6370 RVA: 0x00060BF4 File Offset: 0x0005EDF4
		protected internal bool GetIsItemIndexVisible(int itemIndex, int scrollOffset)
		{
			int num = 0;
			return this.GetIsItemIndexVisible(itemIndex, scrollOffset, out num);
		}

		// Token: 0x060018E3 RID: 6371 RVA: 0x00060C0D File Offset: 0x0005EE0D
		private bool GetIsItemIndexVisible(int itemIndex, int scrollOffset, out int visiblePosition)
		{
			visiblePosition = this.GetVisiblePositionFromItemIndex(itemIndex, scrollOffset);
			return visiblePosition != -1;
		}

		// Token: 0x060018E4 RID: 6372 RVA: 0x00060C21 File Offset: 0x0005EE21
		protected void RemoveAdornerChildElement(global::System.Windows.UIElement childElement)
		{
			if (this.CarouselPanelAdorner != null)
			{
				this.CarouselPanelAdorner.RemoveChildElement(childElement);
			}
		}

		// Token: 0x060018E5 RID: 6373 RVA: 0x00060C38 File Offset: 0x0005EE38
		protected virtual bool CanExecuteCommand(global::Infragistics.Windows.Commands.ExecuteCommandInfo commandInfo)
		{
			global::System.Windows.Input.RoutedCommand routedCommand = commandInfo.RoutedCommand;
			return routedCommand != null && routedCommand.OwnerType == typeof(global::Infragistics.Windows.Controls.XamCarouselPanelCommands);
		}

		// Token: 0x060018E6 RID: 6374 RVA: 0x00060C66 File Offset: 0x0005EE66
		protected virtual void OnAnimatedScrollComplete(int newScrollPosition)
		{
		}

		// Token: 0x060018E7 RID: 6375 RVA: 0x00060C68 File Offset: 0x0005EE68
		protected virtual bool ExecuteCommand(global::Infragistics.Windows.Commands.ExecuteCommandInfo commandInfo)
		{
			global::System.Windows.Input.RoutedCommand routedCommand = commandInfo.RoutedCommand;
			return routedCommand != null && this.ExecuteCommand(routedCommand);
		}

		// Token: 0x060018E8 RID: 6376 RVA: 0x00060C88 File Offset: 0x0005EE88
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

		// Token: 0x060018E9 RID: 6377 RVA: 0x00060D00 File Offset: 0x0005EF00
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

		// Token: 0x060018EA RID: 6378 RVA: 0x00060DAB File Offset: 0x0005EFAB
		internal void RemoveLogicalChildProxy(object child)
		{
			base.RemoveLogicalChild(child);
		}

		// Token: 0x060018EB RID: 6379 RVA: 0x00060DB4 File Offset: 0x0005EFB4
		protected virtual void OnExecutingCommand(global::Infragistics.Windows.Controls.Events.ExecutingCommandEventArgs args)
		{
			base.RaiseEvent(args);
		}

		// Token: 0x060018EC RID: 6380 RVA: 0x00060DBD File Offset: 0x0005EFBD
		internal bool RaiseExecutingCommand(global::Infragistics.Windows.Controls.Events.ExecutingCommandEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.Controls.XamCarouselPanel.ExecutingCommandEvent;
			args.Source = this;
			this.OnExecutingCommand(args);
			return !args.Cancel;
		}

		// Token: 0x14000035 RID: 53
		// (add) Token: 0x060018ED RID: 6381 RVA: 0x00060DE1 File Offset: 0x0005EFE1
		// (remove) Token: 0x060018EE RID: 6382 RVA: 0x00060DEF File Offset: 0x0005EFEF
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

		// Token: 0x060018EF RID: 6383 RVA: 0x00060DFD File Offset: 0x0005EFFD
		protected virtual void OnExecutedCommand(global::Infragistics.Windows.Controls.Events.ExecutedCommandEventArgs args)
		{
			base.RaiseEvent(args);
		}

		// Token: 0x060018F0 RID: 6384 RVA: 0x00060E06 File Offset: 0x0005F006
		internal void RaiseExecutedCommand(global::Infragistics.Windows.Controls.Events.ExecutedCommandEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.Controls.XamCarouselPanel.ExecutedCommandEvent;
			args.Source = this;
			this.OnExecutedCommand(args);
		}

		// Token: 0x14000036 RID: 54
		// (add) Token: 0x060018F1 RID: 6385 RVA: 0x00060E21 File Offset: 0x0005F021
		// (remove) Token: 0x060018F2 RID: 6386 RVA: 0x00060E2F File Offset: 0x0005F02F
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

		// Token: 0x060018F3 RID: 6387 RVA: 0x00060E40 File Offset: 0x0005F040
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

		// Token: 0x060018F4 RID: 6388 RVA: 0x00060E88 File Offset: 0x0005F088
		bool global::Infragistics.Windows.Commands.ICommandHost.Execute(global::Infragistics.Windows.Commands.ExecuteCommandInfo commandInfo)
		{
			global::System.Windows.Input.RoutedCommand routedCommand = commandInfo.RoutedCommand;
			return routedCommand != null && this.ExecuteCommand(routedCommand);
		}

		// Token: 0x060018F5 RID: 6389 RVA: 0x00060EA8 File Offset: 0x0005F0A8
		long global::Infragistics.Windows.Commands.ICommandHost.GetCurrentState(long statesToQuery)
		{
			return this.CurrentState;
		}

		// Token: 0x060018F6 RID: 6390 RVA: 0x00060EB0 File Offset: 0x0005F0B0
		bool global::Infragistics.Windows.Commands.ICommandHost.CanExecute(global::Infragistics.Windows.Commands.ExecuteCommandInfo commandInfo)
		{
			return this.CanExecuteCommand(commandInfo);
		}

		// Token: 0x04000C4C RID: 3148
		private const int SCROLL_SMALL_CHANGE = 1;

		// Token: 0x04000C4D RID: 3149
		private const double REFERENCE_FRAME_RATE = 30.0;

		// Token: 0x04000C4E RID: 3150
		private const double FRAME_RATE_SMOOTHING_FACTOR = 0.05;

		// Token: 0x04000C4F RID: 3151
		private const double MAX_VELOCITY = 0.09;

		// Token: 0x04000C50 RID: 3152
		private const double ATTRACTION = 7.0;

		// Token: 0x04000C51 RID: 3153
		private const double DAMPENING = 0.0;

		// Token: 0x04000C52 RID: 3154
		private const double MIN_DISTANCE_THRESHHOLD = 0.0004;

		// Token: 0x04000C53 RID: 3155
		private global::Infragistics.Windows.Controls.XamCarouselPanel.ScrollData _scrollingData;

		// Token: 0x04000C54 RID: 3156
		private global::Infragistics.Windows.Licensing.UltraLicense _license;

		// Token: 0x04000C55 RID: 3157
		private long _previousTick = long.MinValue;

		// Token: 0x04000C56 RID: 3158
		private double _smoothedFrameRate = 30.0;

		// Token: 0x04000C57 RID: 3159
		private global::System.Windows.Size _previousArrangeSize = global::System.Windows.Size.Empty;

		// Token: 0x04000C58 RID: 3160
		private global::System.Windows.Size _previousMeasureSize = global::System.Windows.Size.Empty;

		// Token: 0x04000C59 RID: 3161
		private bool _shouldGenerateElements = true;

		// Token: 0x04000C5A RID: 3162
		private global::Infragistics.Windows.Controls.XamCarouselPanel.ScrollActionInfo _scrollActionInfo = global::Infragistics.Windows.Controls.XamCarouselPanel.ScrollActionInfo.Empty;

		// Token: 0x04000C5B RID: 3163
		private double _scrollOffsetForInitialArrangeAnimation;

		// Token: 0x04000C5C RID: 3164
		private global::Infragistics.Windows.Controls.CarouselPanelAdorner _carouselPanelAdorner;

		// Token: 0x04000C5D RID: 3165
		private global::System.Windows.Size _wrapperSize = (global::System.Windows.Size)global::Infragistics.Windows.Controls.CarouselViewSettings.ItemSizeProperty.DefaultMetadata.DefaultValue;

		// Token: 0x04000C5E RID: 3166
		private bool _wrapperSizeDirty = true;

		// Token: 0x04000C5F RID: 3167
		private bool _initialArrangeAnimationDone;

		// Token: 0x04000C60 RID: 3168
		private global::Infragistics.Windows.Controls.CarouselPanelNavigator _carouselPanelNavigator;

		// Token: 0x04000C61 RID: 3169
		private global::Infragistics.Windows.Controls.ScalingEffectStopCollection _defaultScalingEffectStops;

		// Token: 0x04000C62 RID: 3170
		private global::Infragistics.Windows.Controls.ZOrderEffectStopCollection _defaultZOrderEffectStops;

		// Token: 0x04000C63 RID: 3171
		private global::Infragistics.Windows.Controls.SkewAngleXEffectStopCollection _defaultSkewAngleXEffectStops;

		// Token: 0x04000C64 RID: 3172
		private global::Infragistics.Windows.Controls.SkewAngleYEffectStopCollection _defaultSkewAngleYEffectStops;

		// Token: 0x04000C65 RID: 3173
		private global::Infragistics.Windows.Controls.OpacityEffectStopCollection _defaultOpacityEffectStops;

		// Token: 0x04000C66 RID: 3174
		private global::System.Windows.Media.Pen _cachedItemPathRenderPen;

		// Token: 0x04000C67 RID: 3175
		private global::System.Windows.Media.Brush _cachedItemPathRenderBrush;

		// Token: 0x04000C68 RID: 3176
		private double[] _visiblePositionPercentValues;

		// Token: 0x04000C69 RID: 3177
		private bool _visiblePositionPercentValuesDirty = true;

		// Token: 0x04000C6A RID: 3178
		private double _distanceBetweenVisiblePositions;

		// Token: 0x04000C6B RID: 3179
		private double _firstVisiblePositionPercentLocation;

		// Token: 0x04000C6C RID: 3180
		private double _lastVisiblePositionPercentLocation = 1.0;

		// Token: 0x04000C6D RID: 3181
		private global::Infragistics.Windows.Controls.ICarouselPanelSelectionHost _selectionHost;

		// Token: 0x04000C6E RID: 3182
		private global::System.Windows.Media.PathGeometry _itemPathGeometry;

		// Token: 0x04000C6F RID: 3183
		private global::Infragistics.Windows.Controls.CarouselViewSettings _viewSettings;

		// Token: 0x04000C70 RID: 3184
		private global::Infragistics.Windows.Controls.XamCarouselPanel.RenderingEventProxy _renderingEventProxy;

		// Token: 0x04000C71 RID: 3185
		private global::System.Collections.Generic.Dictionary<double, global::Infragistics.Windows.Controls.XamCarouselPanel.PathFractionPoint> _pathFractionPointsCache;

		// Token: 0x04000C72 RID: 3186
		private global::Infragistics.Windows.Controls.CarouselViewSettings _designTimeDefaultViewSettings;

		// Token: 0x04000C73 RID: 3187
		private bool _wasLoaded;

		// Token: 0x04000C74 RID: 3188
		private static readonly global::System.Windows.DependencyPropertyKey CanNavigateToPreviousItemPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("CanNavigateToPreviousItem", typeof(bool), typeof(global::Infragistics.Windows.Controls.XamCarouselPanel), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x04000C75 RID: 3189
		public static readonly global::System.Windows.DependencyProperty CanNavigateToPreviousItemProperty = global::Infragistics.Windows.Controls.XamCarouselPanel.CanNavigateToPreviousItemPropertyKey.DependencyProperty;

		// Token: 0x04000C76 RID: 3190
		private static readonly global::System.Windows.DependencyPropertyKey CanNavigateToPreviousPagePropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("CanNavigateToPreviousPage", typeof(bool), typeof(global::Infragistics.Windows.Controls.XamCarouselPanel), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x04000C77 RID: 3191
		public static readonly global::System.Windows.DependencyProperty CanNavigateToPreviousPageProperty = global::Infragistics.Windows.Controls.XamCarouselPanel.CanNavigateToPreviousPagePropertyKey.DependencyProperty;

		// Token: 0x04000C78 RID: 3192
		private static readonly global::System.Windows.DependencyPropertyKey CanNavigateToNextItemPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("CanNavigateToNextItem", typeof(bool), typeof(global::Infragistics.Windows.Controls.XamCarouselPanel), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x04000C79 RID: 3193
		public static readonly global::System.Windows.DependencyProperty CanNavigateToNextItemProperty = global::Infragistics.Windows.Controls.XamCarouselPanel.CanNavigateToNextItemPropertyKey.DependencyProperty;

		// Token: 0x04000C7A RID: 3194
		private static readonly global::System.Windows.DependencyPropertyKey CanNavigateToNextPagePropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("CanNavigateToNextPage", typeof(bool), typeof(global::Infragistics.Windows.Controls.XamCarouselPanel), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x04000C7B RID: 3195
		public static readonly global::System.Windows.DependencyProperty CanNavigateToNextPageProperty = global::Infragistics.Windows.Controls.XamCarouselPanel.CanNavigateToNextPagePropertyKey.DependencyProperty;

		// Token: 0x04000C7C RID: 3196
		private static readonly global::System.Windows.DependencyPropertyKey FirstVisibleItemIndexPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("FirstVisibleItemIndex", typeof(int), typeof(global::Infragistics.Windows.Controls.XamCarouselPanel), new global::System.Windows.FrameworkPropertyMetadata(0));

		// Token: 0x04000C7D RID: 3197
		public static readonly global::System.Windows.DependencyProperty FirstVisibleItemIndexProperty = global::Infragistics.Windows.Controls.XamCarouselPanel.FirstVisibleItemIndexPropertyKey.DependencyProperty;

		// Token: 0x04000C7E RID: 3198
		private static readonly global::System.Windows.DependencyPropertyKey ReflectionVisibilityPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("ReflectionVisibility", typeof(global::System.Windows.Visibility), typeof(global::Infragistics.Windows.Controls.XamCarouselPanel), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.VisibilityVisibleBox));

		// Token: 0x04000C7F RID: 3199
		public static readonly global::System.Windows.DependencyProperty ReflectionVisibilityProperty = global::Infragistics.Windows.Controls.XamCarouselPanel.ReflectionVisibilityPropertyKey.DependencyProperty;

		// Token: 0x04000C80 RID: 3200
		public static readonly global::System.Windows.DependencyProperty ViewSettingsProperty = global::System.Windows.DependencyProperty.Register("ViewSettings", typeof(global::Infragistics.Windows.Controls.CarouselViewSettings), typeof(global::Infragistics.Windows.Controls.XamCarouselPanel), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.Controls.XamCarouselPanel.OnCoerceViewSettings)));

		// Token: 0x04000C81 RID: 3201
		internal static readonly global::System.Windows.DependencyProperty IsInCarouselListBoxProperty = global::System.Windows.DependencyProperty.Register("IsInCarouselListBox", typeof(bool), typeof(global::Infragistics.Windows.Controls.XamCarouselPanel), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x04000C82 RID: 3202
		internal static readonly global::System.Windows.DependencyProperty ViewSettingsVersionProperty = global::System.Windows.DependencyProperty.Register("ViewSettingsVersion", typeof(int), typeof(global::Infragistics.Windows.Controls.XamCarouselPanel), new global::System.Windows.FrameworkPropertyMetadata(0));

		// Token: 0x02000259 RID: 601
		// (Invoke) Token: 0x060018F8 RID: 6392
		private delegate void MethodDelegate();

		// Token: 0x0200025A RID: 602
		private class RenderingEventProxy
		{
			// Token: 0x060018FB RID: 6395 RVA: 0x00060EB9 File Offset: 0x0005F0B9
			internal RenderingEventProxy(global::Infragistics.Windows.Controls.XamCarouselPanel panel)
			{
				this._panelRef = new global::System.WeakReference(panel);
				this._isWired = false;
			}

			// Token: 0x060018FC RID: 6396 RVA: 0x00060ED4 File Offset: 0x0005F0D4
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

			// Token: 0x060018FD RID: 6397 RVA: 0x00060F04 File Offset: 0x0005F104
			internal void UnwireRenderingEvent()
			{
				if (this._isWired)
				{
					global::System.Windows.Media.CompositionTarget.Rendering -= this.OnCompositionTarget_Rendering;
				}
				this._isWired = false;
			}

			// Token: 0x060018FE RID: 6398 RVA: 0x00060F26 File Offset: 0x0005F126
			internal void WireRenderingEvent()
			{
				if (this._isWired)
				{
					return;
				}
				this._isWired = true;
				global::System.Windows.Media.CompositionTarget.Rendering += this.OnCompositionTarget_Rendering;
			}

			// Token: 0x04000C85 RID: 3205
			private global::System.WeakReference _panelRef;

			// Token: 0x04000C86 RID: 3206
			private bool _isWired;
		}

		// Token: 0x0200025B RID: 603
		internal class ScrollData
		{
			// Token: 0x060018FF RID: 6399 RVA: 0x00060F49 File Offset: 0x0005F149
			internal void Reset()
			{
				this._offset = default(global::System.Windows.Vector);
				this._extent = default(global::System.Windows.Size);
				this._viewport = default(global::System.Windows.Size);
			}

			// Token: 0x04000C87 RID: 3207
			internal global::System.Windows.Controls.ScrollViewer _scrollOwner;

			// Token: 0x04000C88 RID: 3208
			internal global::System.Windows.Size _extent = default(global::System.Windows.Size);

			// Token: 0x04000C89 RID: 3209
			internal global::System.Windows.Size _viewport = default(global::System.Windows.Size);

			// Token: 0x04000C8A RID: 3210
			internal global::System.Windows.Vector _offset = default(global::System.Windows.Vector);

			// Token: 0x04000C8B RID: 3211
			internal bool _canHorizontallyScroll;

			// Token: 0x04000C8C RID: 3212
			internal bool _canVerticallyScroll;
		}

		// Token: 0x0200025C RID: 604
		internal struct PathFractionPoint
		{
			// Token: 0x06001901 RID: 6401 RVA: 0x00060F9B File Offset: 0x0005F19B
			internal PathFractionPoint(global::System.Windows.Point point, global::System.Windows.Point tangentPoint)
			{
				this.Point = point;
				this.TangentPoint = tangentPoint;
			}

			// Token: 0x04000C8D RID: 3213
			internal global::System.Windows.Point Point;

			// Token: 0x04000C8E RID: 3214
			internal global::System.Windows.Point TangentPoint;
		}

		// Token: 0x0200025D RID: 605
		internal struct ScrollActionInfo
		{
			// Token: 0x06001902 RID: 6402 RVA: 0x00060FAB File Offset: 0x0005F1AB
			internal ScrollActionInfo(double offsetBeforeScroll, double offsetAfterScroll, bool scrollingHigher, global::Infragistics.Windows.Controls.XamCarouselPanel carouselPanel)
			{
				this.OffsetAfterScroll = offsetAfterScroll;
				this.OffsetBeforeScroll = offsetBeforeScroll;
				this.ScrollingHigher = scrollingHigher;
				this.CarouselPanel = carouselPanel;
			}

			// Token: 0x170005A8 RID: 1448
			// (get) Token: 0x06001903 RID: 6403 RVA: 0x00060FCA File Offset: 0x0005F1CA
			internal bool IsEmpty
			{
				get
				{
					return this.OffsetBeforeScroll == double.NegativeInfinity && this.OffsetAfterScroll == double.NegativeInfinity;
				}
			}

			// Token: 0x170005A9 RID: 1449
			// (get) Token: 0x06001904 RID: 6404 RVA: 0x00060FF0 File Offset: 0x0005F1F0
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

			// Token: 0x170005AA RID: 1450
			// (get) Token: 0x06001905 RID: 6405 RVA: 0x0006107C File Offset: 0x0005F27C
			internal int ScrollAmountAbsolute
			{
				get
				{
					return global::System.Math.Abs(this.ScrollAmount);
				}
			}

			// Token: 0x04000C8F RID: 3215
			internal double OffsetBeforeScroll;

			// Token: 0x04000C90 RID: 3216
			internal double OffsetAfterScroll;

			// Token: 0x04000C91 RID: 3217
			internal static global::Infragistics.Windows.Controls.XamCarouselPanel.ScrollActionInfo Empty = new global::Infragistics.Windows.Controls.XamCarouselPanel.ScrollActionInfo(double.NegativeInfinity, double.NegativeInfinity, false, null);

			// Token: 0x04000C92 RID: 3218
			internal bool ScrollingHigher;

			// Token: 0x04000C93 RID: 3219
			internal global::Infragistics.Windows.Controls.XamCarouselPanel CarouselPanel;
		}
	}
}
