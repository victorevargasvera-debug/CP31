using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Infragistics.Windows.Controls
{
	// Token: 0x02000118 RID: 280
	[global::System.Windows.StyleTypedProperty(Property = "CarouselPanelNavigatorStyle", StyleTargetType = typeof(global::Infragistics.Windows.Controls.CarouselPanelNavigator))]
	public class CarouselViewSettings : global::Infragistics.Windows.Controls.ViewSettingsBase
	{
		// Token: 0x06000994 RID: 2452 RVA: 0x000208B8 File Offset: 0x0001EAB8
		public CarouselViewSettings()
		{
			base.SetValue(global::Infragistics.Windows.Controls.CarouselViewSettings.OpacityEffectStopsProperty, new global::Infragistics.Windows.Controls.OpacityEffectStopCollection());
			base.SetValue(global::Infragistics.Windows.Controls.CarouselViewSettings.ScalingEffectStopsProperty, new global::Infragistics.Windows.Controls.ScalingEffectStopCollection());
			base.SetValue(global::Infragistics.Windows.Controls.CarouselViewSettings.SkewAngleXEffectStopsProperty, new global::Infragistics.Windows.Controls.SkewAngleXEffectStopCollection());
			base.SetValue(global::Infragistics.Windows.Controls.CarouselViewSettings.SkewAngleYEffectStopsProperty, new global::Infragistics.Windows.Controls.SkewAngleYEffectStopCollection());
			base.SetValue(global::Infragistics.Windows.Controls.CarouselViewSettings.ZOrderEffectStopsProperty, new global::Infragistics.Windows.Controls.ZOrderEffectStopCollection());
		}

		// Token: 0x06000995 RID: 2453 RVA: 0x0002091B File Offset: 0x0001EB1B
		protected internal override void OnControlInitialized()
		{
		}

		// Token: 0x06000996 RID: 2454 RVA: 0x0002091D File Offset: 0x0001EB1D
		protected override void OnPropertyChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			base.OnPropertyChanged(e);
			if (e.Property != global::Infragistics.Windows.Controls.CarouselViewSettings.VersionProperty && !global::System.ComponentModel.DesignerProperties.GetIsInDesignMode(this))
			{
				base.SetValue(global::Infragistics.Windows.Controls.CarouselViewSettings.VersionPropertyKey, this.Version + 1);
			}
		}

		// Token: 0x06000997 RID: 2455 RVA: 0x00020954 File Offset: 0x0001EB54
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override void Reset()
		{
			this.ResetAutoScaleItemContentsToFit();
			this.ResetCarouselPanelNavigatorStyle();
			this.ResetHeightInInfiniteContainers();
			this.ResetIsListContinuous();
			this.ResetIsNavigatorVisible();
			this.ResetItemHorizontalScrollBarVisibility();
			this.ResetItemPath();
			this.ResetItemPathAutoPad();
			this.ResetItemPathHorizontalAlignment();
			this.ResetItemPathPadding();
			this.ResetItemPathPrefixPercent();
			this.ResetItemPathRenderBrush();
			this.ResetItemPathRenderPen();
			this.ResetItemPathStretch();
			this.ResetItemPathSuffixPercent();
			this.ResetItemPathVerticalAlignment();
			this.ResetItemSize();
			this.ResetItemsPerPage();
			this.ResetItemTransitionStyle();
			this.ResetItemVerticalScrollBarVisibility();
			this.ResetOpacityEffectStopDirection();
			this.ResetOpacityEffectStops();
			this.ResetReserveSpaceForReflections();
			this.ResetRotateItemsWithPathTangent();
			this.ResetScalingEffectStops();
			this.ResetScalingEffectStopDirection();
			this.ResetShouldAnimateItemsOnListChange();
			this.ResetShouldScrollItemsIntoInitialPosition();
			this.ResetSkewAngleXEffectStops();
			this.ResetSkewAngleXEffectStopDirection();
			this.ResetSkewAngleYEffectStops();
			this.ResetSkewAngleYEffectStopDirection();
			this.ResetUseOpacity();
			this.ResetUseScaling();
			this.ResetUseSkewing();
			this.ResetUseZOrder();
			this.ResetWidthInInfiniteContainers();
			this.ResetZOrderEffectStopDirection();
			this.ResetZOrderEffectStops();
		}

		// Token: 0x06000998 RID: 2456 RVA: 0x00020A4C File Offset: 0x0001EC4C
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override bool ShouldSerialize()
		{
			return this.ShouldSerializeAutoScaleItemContentsToFit() || this.ShouldSerializeCarouselPanelNavigatorStyle() || this.ShouldSerializeHeightInInfiniteContainers() || this.ShouldSerializeIsListContinuous() || this.ShouldSerializeIsNavigatorVisible() || this.ShouldSerializeItemHorizontalScrollBarVisibility() || this.ShouldSerializeItemPath() || this.ShouldSerializeItemPathAutoPad() || this.ShouldSerializeItemPathHorizontalAlignment() || this.ShouldSerializeItemPathPadding() || this.ShouldSerializeItemPathPrefixPercent() || this.ShouldSerializeItemPathRenderBrush() || this.ShouldSerializeItemPathRenderPen() || this.ShouldSerializeItemPathStretch() || this.ShouldSerializeItemPathSuffixPercent() || this.ShouldSerializeItemPathVerticalAlignment() || this.ShouldSerializeItemSize() || this.ShouldSerializeItemsPerPage() || this.ShouldSerializeItemTransitionStyle() || this.ShouldSerializeItemVerticalScrollBarVisibility() || this.ShouldSerializeOpacityEffectStopDirection() || this.ShouldSerializeOpacityEffectStops() || this.ShouldSerializeReserveSpaceForReflections() || this.ShouldSerializeRotateItemsWithPathTangent() || this.ShouldSerializeScalingEffectStopDirection() || this.ShouldSerializeScalingEffectStops() || this.ShouldSerializeShouldAnimateItemsOnListChange() || this.ShouldSerializeShouldScrollItemsIntoInitialPosition() || this.ShouldSerializeSkewAngleXEffectStopDirection() || this.ShouldSerializeSkewAngleXEffectStops() || this.ShouldSerializeSkewAngleYEffectStopDirection() || this.ShouldSerializeSkewAngleYEffectStops() || this.ShouldSerializeUseOpacity() || this.ShouldSerializeUseScaling() || this.ShouldSerializeUseSkewing() || this.ShouldSerializeUseZOrder() || this.ShouldSerializeWidthInInfiniteContainers() || this.ShouldSerializeZOrderEffectStopDirection() || this.ShouldSerializeZOrderEffectStops();
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x06000999 RID: 2457 RVA: 0x00020BD3 File Offset: 0x0001EDD3
		// (set) Token: 0x0600099A RID: 2458 RVA: 0x00020BE5 File Offset: 0x0001EDE5
		public bool AutoScaleItemContentsToFit
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.Controls.CarouselViewSettings.AutoScaleItemContentsToFitProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.CarouselViewSettings.AutoScaleItemContentsToFitProperty, value);
			}
		}

		// Token: 0x0600099B RID: 2459 RVA: 0x00020BF8 File Offset: 0x0001EDF8
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeAutoScaleItemContentsToFit()
		{
			return this.AutoScaleItemContentsToFit != (bool)global::Infragistics.Windows.Controls.CarouselViewSettings.AutoScaleItemContentsToFitProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x0600099C RID: 2460 RVA: 0x00020C19 File Offset: 0x0001EE19
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetAutoScaleItemContentsToFit()
		{
			base.ClearValue(global::Infragistics.Windows.Controls.CarouselViewSettings.AutoScaleItemContentsToFitProperty);
		}

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x0600099D RID: 2461 RVA: 0x00020C26 File Offset: 0x0001EE26
		// (set) Token: 0x0600099E RID: 2462 RVA: 0x00020C38 File Offset: 0x0001EE38
		public global::System.Windows.Style CarouselPanelNavigatorStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Windows.Controls.CarouselViewSettings.CarouselPanelNavigatorStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.CarouselViewSettings.CarouselPanelNavigatorStyleProperty, value);
			}
		}

		// Token: 0x0600099F RID: 2463 RVA: 0x00020C46 File Offset: 0x0001EE46
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeCarouselPanelNavigatorStyle()
		{
			return this.CarouselPanelNavigatorStyle != null;
		}

		// Token: 0x060009A0 RID: 2464 RVA: 0x00020C54 File Offset: 0x0001EE54
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetCarouselPanelNavigatorStyle()
		{
			base.ClearValue(global::Infragistics.Windows.Controls.CarouselViewSettings.CarouselPanelNavigatorStyleProperty);
		}

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x060009A1 RID: 2465 RVA: 0x00020C61 File Offset: 0x0001EE61
		// (set) Token: 0x060009A2 RID: 2466 RVA: 0x00020C73 File Offset: 0x0001EE73
		public double HeightInInfiniteContainers
		{
			get
			{
				return (double)base.GetValue(global::Infragistics.Windows.Controls.CarouselViewSettings.HeightInInfiniteContainersProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.CarouselViewSettings.HeightInInfiniteContainersProperty, value);
			}
		}

		// Token: 0x060009A3 RID: 2467 RVA: 0x00020C86 File Offset: 0x0001EE86
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeHeightInInfiniteContainers()
		{
			return this.HeightInInfiniteContainers != (double)global::Infragistics.Windows.Controls.CarouselViewSettings.HeightInInfiniteContainersProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x060009A4 RID: 2468 RVA: 0x00020CA7 File Offset: 0x0001EEA7
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetHeightInInfiniteContainers()
		{
			base.ClearValue(global::Infragistics.Windows.Controls.CarouselViewSettings.HeightInInfiniteContainersProperty);
		}

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x060009A5 RID: 2469 RVA: 0x00020CB4 File Offset: 0x0001EEB4
		// (set) Token: 0x060009A6 RID: 2470 RVA: 0x00020CC6 File Offset: 0x0001EEC6
		public bool IsListContinuous
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.Controls.CarouselViewSettings.IsListContinuousProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.CarouselViewSettings.IsListContinuousProperty, value);
			}
		}

		// Token: 0x060009A7 RID: 2471 RVA: 0x00020CD9 File Offset: 0x0001EED9
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeIsListContinuous()
		{
			return this.IsListContinuous != (bool)global::Infragistics.Windows.Controls.CarouselViewSettings.IsListContinuousProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x060009A8 RID: 2472 RVA: 0x00020CFA File Offset: 0x0001EEFA
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetIsListContinuous()
		{
			base.ClearValue(global::Infragistics.Windows.Controls.CarouselViewSettings.IsListContinuousProperty);
		}

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x060009A9 RID: 2473 RVA: 0x00020D07 File Offset: 0x0001EF07
		// (set) Token: 0x060009AA RID: 2474 RVA: 0x00020D19 File Offset: 0x0001EF19
		public bool IsNavigatorVisible
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.Controls.CarouselViewSettings.IsNavigatorVisibleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.CarouselViewSettings.IsNavigatorVisibleProperty, value);
			}
		}

		// Token: 0x060009AB RID: 2475 RVA: 0x00020D2C File Offset: 0x0001EF2C
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeIsNavigatorVisible()
		{
			return this.IsNavigatorVisible != (bool)global::Infragistics.Windows.Controls.CarouselViewSettings.IsNavigatorVisibleProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x060009AC RID: 2476 RVA: 0x00020D4D File Offset: 0x0001EF4D
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetIsNavigatorVisible()
		{
			base.ClearValue(global::Infragistics.Windows.Controls.CarouselViewSettings.IsNavigatorVisibleProperty);
		}

		// Token: 0x060009AD RID: 2477 RVA: 0x00020D5A File Offset: 0x0001EF5A
		private static bool OnValidateItemHorizontalScrollBarVisibility(object value)
		{
			if (!global::System.Enum.IsDefined(typeof(global::System.Windows.Controls.ScrollBarVisibility), value))
			{
				throw new global::System.ComponentModel.InvalidEnumArgumentException("value", (int)value, typeof(global::System.Windows.Controls.ScrollBarVisibility));
			}
			return true;
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x060009AE RID: 2478 RVA: 0x00020D8A File Offset: 0x0001EF8A
		// (set) Token: 0x060009AF RID: 2479 RVA: 0x00020D9C File Offset: 0x0001EF9C
		public global::System.Windows.Controls.ScrollBarVisibility ItemHorizontalScrollBarVisibility
		{
			get
			{
				return (global::System.Windows.Controls.ScrollBarVisibility)base.GetValue(global::Infragistics.Windows.Controls.CarouselViewSettings.ItemHorizontalScrollBarVisibilityProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.CarouselViewSettings.ItemHorizontalScrollBarVisibilityProperty, value);
			}
		}

		// Token: 0x060009B0 RID: 2480 RVA: 0x00020DAF File Offset: 0x0001EFAF
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeItemHorizontalScrollBarVisibility()
		{
			return this.ItemHorizontalScrollBarVisibility != (global::System.Windows.Controls.ScrollBarVisibility)global::Infragistics.Windows.Controls.CarouselViewSettings.ItemHorizontalScrollBarVisibilityProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x060009B1 RID: 2481 RVA: 0x00020DD0 File Offset: 0x0001EFD0
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetItemHorizontalScrollBarVisibility()
		{
			base.ClearValue(global::Infragistics.Windows.Controls.CarouselViewSettings.ItemHorizontalScrollBarVisibilityProperty);
		}

		// Token: 0x060009B2 RID: 2482 RVA: 0x00020DDD File Offset: 0x0001EFDD
		private static bool OnValidateItemVerticalScrollBarVisibility(object value)
		{
			if (!global::System.Enum.IsDefined(typeof(global::System.Windows.Controls.ScrollBarVisibility), value))
			{
				throw new global::System.ComponentModel.InvalidEnumArgumentException("value", (int)value, typeof(global::System.Windows.Controls.ScrollBarVisibility));
			}
			return true;
		}

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x060009B3 RID: 2483 RVA: 0x00020E0D File Offset: 0x0001F00D
		// (set) Token: 0x060009B4 RID: 2484 RVA: 0x00020E1F File Offset: 0x0001F01F
		public global::System.Windows.Controls.ScrollBarVisibility ItemVerticalScrollBarVisibility
		{
			get
			{
				return (global::System.Windows.Controls.ScrollBarVisibility)base.GetValue(global::Infragistics.Windows.Controls.CarouselViewSettings.ItemVerticalScrollBarVisibilityProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.CarouselViewSettings.ItemVerticalScrollBarVisibilityProperty, value);
			}
		}

		// Token: 0x060009B5 RID: 2485 RVA: 0x00020E32 File Offset: 0x0001F032
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeItemVerticalScrollBarVisibility()
		{
			return this.ItemVerticalScrollBarVisibility != (global::System.Windows.Controls.ScrollBarVisibility)global::Infragistics.Windows.Controls.CarouselViewSettings.ItemVerticalScrollBarVisibilityProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x060009B6 RID: 2486 RVA: 0x00020E53 File Offset: 0x0001F053
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetItemVerticalScrollBarVisibility()
		{
			base.ClearValue(global::Infragistics.Windows.Controls.CarouselViewSettings.ItemVerticalScrollBarVisibilityProperty);
		}

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x060009B7 RID: 2487 RVA: 0x00020E60 File Offset: 0x0001F060
		// (set) Token: 0x060009B8 RID: 2488 RVA: 0x00020E72 File Offset: 0x0001F072
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Shapes.Shape ItemPath
		{
			get
			{
				return (global::System.Windows.Shapes.Shape)base.GetValue(global::Infragistics.Windows.Controls.CarouselViewSettings.ItemPathProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.CarouselViewSettings.ItemPathProperty, value);
			}
		}

		// Token: 0x060009B9 RID: 2489 RVA: 0x00020E80 File Offset: 0x0001F080
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeItemPath()
		{
			return this.ItemPath != (global::System.Windows.Shapes.Shape)global::Infragistics.Windows.Controls.CarouselViewSettings.ItemPathProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x060009BA RID: 2490 RVA: 0x00020EA1 File Offset: 0x0001F0A1
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetItemPath()
		{
			base.ClearValue(global::Infragistics.Windows.Controls.CarouselViewSettings.ItemPathProperty);
		}

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x060009BB RID: 2491 RVA: 0x00020EAE File Offset: 0x0001F0AE
		// (set) Token: 0x060009BC RID: 2492 RVA: 0x00020EC0 File Offset: 0x0001F0C0
		public bool ItemPathAutoPad
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.Controls.CarouselViewSettings.ItemPathAutoPadProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.CarouselViewSettings.ItemPathAutoPadProperty, value);
			}
		}

		// Token: 0x060009BD RID: 2493 RVA: 0x00020ED3 File Offset: 0x0001F0D3
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeItemPathAutoPad()
		{
			return this.ItemPathAutoPad != (bool)global::Infragistics.Windows.Controls.CarouselViewSettings.ItemPathAutoPadProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x060009BE RID: 2494 RVA: 0x00020EF4 File Offset: 0x0001F0F4
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetItemPathAutoPad()
		{
			base.ClearValue(global::Infragistics.Windows.Controls.CarouselViewSettings.ItemPathAutoPadProperty);
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x060009BF RID: 2495 RVA: 0x00020F01 File Offset: 0x0001F101
		// (set) Token: 0x060009C0 RID: 2496 RVA: 0x00020F13 File Offset: 0x0001F113
		public global::System.Windows.HorizontalAlignment ItemPathHorizontalAlignment
		{
			get
			{
				return (global::System.Windows.HorizontalAlignment)base.GetValue(global::Infragistics.Windows.Controls.CarouselViewSettings.ItemPathHorizontalAlignmentProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.CarouselViewSettings.ItemPathHorizontalAlignmentProperty, value);
			}
		}

		// Token: 0x060009C1 RID: 2497 RVA: 0x00020F26 File Offset: 0x0001F126
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeItemPathHorizontalAlignment()
		{
			return this.ItemPathHorizontalAlignment != (global::System.Windows.HorizontalAlignment)global::Infragistics.Windows.Controls.CarouselViewSettings.ItemPathHorizontalAlignmentProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x060009C2 RID: 2498 RVA: 0x00020F47 File Offset: 0x0001F147
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetItemPathHorizontalAlignment()
		{
			base.ClearValue(global::Infragistics.Windows.Controls.CarouselViewSettings.ItemPathHorizontalAlignmentProperty);
		}

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x060009C3 RID: 2499 RVA: 0x00020F54 File Offset: 0x0001F154
		// (set) Token: 0x060009C4 RID: 2500 RVA: 0x00020F66 File Offset: 0x0001F166
		public global::System.Windows.Thickness ItemPathPadding
		{
			get
			{
				return (global::System.Windows.Thickness)base.GetValue(global::Infragistics.Windows.Controls.CarouselViewSettings.ItemPathPaddingProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.CarouselViewSettings.ItemPathPaddingProperty, value);
			}
		}

		// Token: 0x060009C5 RID: 2501 RVA: 0x00020F79 File Offset: 0x0001F179
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeItemPathPadding()
		{
			return this.ItemPathPadding != (global::System.Windows.Thickness)global::Infragistics.Windows.Controls.CarouselViewSettings.ItemPathPaddingProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x060009C6 RID: 2502 RVA: 0x00020F9A File Offset: 0x0001F19A
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetItemPathPadding()
		{
			base.ClearValue(global::Infragistics.Windows.Controls.CarouselViewSettings.ItemPathPaddingProperty);
		}

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x060009C7 RID: 2503 RVA: 0x00020FA7 File Offset: 0x0001F1A7
		// (set) Token: 0x060009C8 RID: 2504 RVA: 0x00020FB9 File Offset: 0x0001F1B9
		public global::System.Windows.Media.Stretch ItemPathStretch
		{
			get
			{
				return (global::System.Windows.Media.Stretch)base.GetValue(global::Infragistics.Windows.Controls.CarouselViewSettings.ItemPathStretchProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.CarouselViewSettings.ItemPathStretchProperty, value);
			}
		}

		// Token: 0x060009C9 RID: 2505 RVA: 0x00020FCC File Offset: 0x0001F1CC
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeItemPathStretch()
		{
			return this.ItemPathStretch != (global::System.Windows.Media.Stretch)global::Infragistics.Windows.Controls.CarouselViewSettings.ItemPathStretchProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x060009CA RID: 2506 RVA: 0x00020FED File Offset: 0x0001F1ED
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetItemPathStretch()
		{
			base.ClearValue(global::Infragistics.Windows.Controls.CarouselViewSettings.ItemPathStretchProperty);
		}

		// Token: 0x060009CB RID: 2507 RVA: 0x00020FFA File Offset: 0x0001F1FA
		private static object OnCoerceItemPathPrefixPercent(global::System.Windows.DependencyObject d, object value)
		{
			if ((double)value < 0.0)
			{
				return 0;
			}
			if ((double)value > 0.4)
			{
				return 0.4;
			}
			return value;
		}

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x060009CC RID: 2508 RVA: 0x00021035 File Offset: 0x0001F235
		// (set) Token: 0x060009CD RID: 2509 RVA: 0x00021047 File Offset: 0x0001F247
		public double ItemPathPrefixPercent
		{
			get
			{
				return (double)base.GetValue(global::Infragistics.Windows.Controls.CarouselViewSettings.ItemPathPrefixPercentProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.CarouselViewSettings.ItemPathPrefixPercentProperty, value);
			}
		}

		// Token: 0x060009CE RID: 2510 RVA: 0x0002105A File Offset: 0x0001F25A
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeItemPathPrefixPercent()
		{
			return this.ItemPathPrefixPercent != (double)global::Infragistics.Windows.Controls.CarouselViewSettings.ItemPathPrefixPercentProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x060009CF RID: 2511 RVA: 0x0002107B File Offset: 0x0001F27B
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetItemPathPrefixPercent()
		{
			base.ClearValue(global::Infragistics.Windows.Controls.CarouselViewSettings.ItemPathPrefixPercentProperty);
		}

		// Token: 0x060009D0 RID: 2512 RVA: 0x00021088 File Offset: 0x0001F288
		private static object OnCoerceItemPathSuffixPercent(global::System.Windows.DependencyObject d, object value)
		{
			if ((double)value < 0.0)
			{
				return 0;
			}
			if ((double)value > 0.4)
			{
				return 0.4;
			}
			return value;
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x060009D1 RID: 2513 RVA: 0x000210C3 File Offset: 0x0001F2C3
		// (set) Token: 0x060009D2 RID: 2514 RVA: 0x000210D5 File Offset: 0x0001F2D5
		public double ItemPathSuffixPercent
		{
			get
			{
				return (double)base.GetValue(global::Infragistics.Windows.Controls.CarouselViewSettings.ItemPathSuffixPercentProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.CarouselViewSettings.ItemPathSuffixPercentProperty, value);
			}
		}

		// Token: 0x060009D3 RID: 2515 RVA: 0x000210E8 File Offset: 0x0001F2E8
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeItemPathSuffixPercent()
		{
			return this.ItemPathSuffixPercent != (double)global::Infragistics.Windows.Controls.CarouselViewSettings.ItemPathSuffixPercentProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x060009D4 RID: 2516 RVA: 0x00021109 File Offset: 0x0001F309
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetItemPathSuffixPercent()
		{
			base.ClearValue(global::Infragistics.Windows.Controls.CarouselViewSettings.ItemPathSuffixPercentProperty);
		}

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x060009D5 RID: 2517 RVA: 0x00021116 File Offset: 0x0001F316
		// (set) Token: 0x060009D6 RID: 2518 RVA: 0x00021128 File Offset: 0x0001F328
		public global::System.Windows.Media.Brush ItemPathRenderBrush
		{
			get
			{
				return (global::System.Windows.Media.Brush)base.GetValue(global::Infragistics.Windows.Controls.CarouselViewSettings.ItemPathRenderBrushProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.CarouselViewSettings.ItemPathRenderBrushProperty, value);
			}
		}

		// Token: 0x060009D7 RID: 2519 RVA: 0x00021136 File Offset: 0x0001F336
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeItemPathRenderBrush()
		{
			return this.ItemPathRenderBrush != (global::System.Windows.Media.Brush)global::Infragistics.Windows.Controls.CarouselViewSettings.ItemPathRenderBrushProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x060009D8 RID: 2520 RVA: 0x00021157 File Offset: 0x0001F357
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetItemPathRenderBrush()
		{
			base.ClearValue(global::Infragistics.Windows.Controls.CarouselViewSettings.ItemPathRenderBrushProperty);
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x060009D9 RID: 2521 RVA: 0x00021164 File Offset: 0x0001F364
		// (set) Token: 0x060009DA RID: 2522 RVA: 0x00021176 File Offset: 0x0001F376
		public global::System.Windows.Media.Pen ItemPathRenderPen
		{
			get
			{
				return (global::System.Windows.Media.Pen)base.GetValue(global::Infragistics.Windows.Controls.CarouselViewSettings.ItemPathRenderPenProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.CarouselViewSettings.ItemPathRenderPenProperty, value);
			}
		}

		// Token: 0x060009DB RID: 2523 RVA: 0x00021184 File Offset: 0x0001F384
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeItemPathRenderPen()
		{
			return this.ItemPathRenderPen != (global::System.Windows.Media.Pen)global::Infragistics.Windows.Controls.CarouselViewSettings.ItemPathRenderPenProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x060009DC RID: 2524 RVA: 0x000211A5 File Offset: 0x0001F3A5
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetItemPathRenderPen()
		{
			base.ClearValue(global::Infragistics.Windows.Controls.CarouselViewSettings.ItemPathRenderPenProperty);
		}

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x060009DD RID: 2525 RVA: 0x000211B2 File Offset: 0x0001F3B2
		// (set) Token: 0x060009DE RID: 2526 RVA: 0x000211C4 File Offset: 0x0001F3C4
		public global::System.Windows.VerticalAlignment ItemPathVerticalAlignment
		{
			get
			{
				return (global::System.Windows.VerticalAlignment)base.GetValue(global::Infragistics.Windows.Controls.CarouselViewSettings.ItemPathVerticalAlignmentProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.CarouselViewSettings.ItemPathVerticalAlignmentProperty, value);
			}
		}

		// Token: 0x060009DF RID: 2527 RVA: 0x000211D7 File Offset: 0x0001F3D7
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeItemPathVerticalAlignment()
		{
			return this.ItemPathVerticalAlignment != (global::System.Windows.VerticalAlignment)global::Infragistics.Windows.Controls.CarouselViewSettings.ItemPathVerticalAlignmentProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x060009E0 RID: 2528 RVA: 0x000211F8 File Offset: 0x0001F3F8
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetItemPathVerticalAlignment()
		{
			base.ClearValue(global::Infragistics.Windows.Controls.CarouselViewSettings.ItemPathVerticalAlignmentProperty);
		}

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x060009E1 RID: 2529 RVA: 0x00021205 File Offset: 0x0001F405
		// (set) Token: 0x060009E2 RID: 2530 RVA: 0x00021217 File Offset: 0x0001F417
		public global::System.Windows.Size ItemSize
		{
			get
			{
				return (global::System.Windows.Size)base.GetValue(global::Infragistics.Windows.Controls.CarouselViewSettings.ItemSizeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.CarouselViewSettings.ItemSizeProperty, value);
			}
		}

		// Token: 0x060009E3 RID: 2531 RVA: 0x0002122A File Offset: 0x0001F42A
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeItemSize()
		{
			return this.ItemSize != (global::System.Windows.Size)global::Infragistics.Windows.Controls.CarouselViewSettings.ItemSizeProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x060009E4 RID: 2532 RVA: 0x0002124B File Offset: 0x0001F44B
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetItemSize()
		{
			base.ClearValue(global::Infragistics.Windows.Controls.CarouselViewSettings.ItemSizeProperty);
		}

		// Token: 0x060009E5 RID: 2533 RVA: 0x00021258 File Offset: 0x0001F458
		private static object OnCoerceItemsPerPage(global::System.Windows.DependencyObject d, object value)
		{
			if ((int)value < 1)
			{
				return 1;
			}
			return value;
		}

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x060009E6 RID: 2534 RVA: 0x0002126B File Offset: 0x0001F46B
		// (set) Token: 0x060009E7 RID: 2535 RVA: 0x0002127D File Offset: 0x0001F47D
		public int ItemsPerPage
		{
			get
			{
				return (int)base.GetValue(global::Infragistics.Windows.Controls.CarouselViewSettings.ItemsPerPageProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.CarouselViewSettings.ItemsPerPageProperty, value);
			}
		}

		// Token: 0x060009E8 RID: 2536 RVA: 0x00021290 File Offset: 0x0001F490
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeItemsPerPage()
		{
			return this.ItemsPerPage != (int)global::Infragistics.Windows.Controls.CarouselViewSettings.ItemsPerPageProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x060009E9 RID: 2537 RVA: 0x000212B1 File Offset: 0x0001F4B1
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetItemsPerPage()
		{
			base.ClearValue(global::Infragistics.Windows.Controls.CarouselViewSettings.ItemsPerPageProperty);
		}

		// Token: 0x060009EA RID: 2538 RVA: 0x000212BE File Offset: 0x0001F4BE
		private static bool OnValidateItemTransitionStyle(object value)
		{
			if (!global::System.Enum.IsDefined(typeof(global::Infragistics.Windows.Controls.PathItemTransitionStyle), value))
			{
				throw new global::System.ComponentModel.InvalidEnumArgumentException("value", (int)value, typeof(global::Infragistics.Windows.Controls.PathItemTransitionStyle));
			}
			return true;
		}

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x060009EB RID: 2539 RVA: 0x000212EE File Offset: 0x0001F4EE
		// (set) Token: 0x060009EC RID: 2540 RVA: 0x00021300 File Offset: 0x0001F500
		public global::Infragistics.Windows.Controls.PathItemTransitionStyle ItemTransitionStyle
		{
			get
			{
				return (global::Infragistics.Windows.Controls.PathItemTransitionStyle)base.GetValue(global::Infragistics.Windows.Controls.CarouselViewSettings.ItemTransitionStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.CarouselViewSettings.ItemTransitionStyleProperty, value);
			}
		}

		// Token: 0x060009ED RID: 2541 RVA: 0x00021313 File Offset: 0x0001F513
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeItemTransitionStyle()
		{
			return this.ItemTransitionStyle != (global::Infragistics.Windows.Controls.PathItemTransitionStyle)global::Infragistics.Windows.Controls.CarouselViewSettings.ItemTransitionStyleProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x060009EE RID: 2542 RVA: 0x00021334 File Offset: 0x0001F534
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetItemTransitionStyle()
		{
			base.ClearValue(global::Infragistics.Windows.Controls.CarouselViewSettings.ItemTransitionStyleProperty);
		}

		// Token: 0x060009EF RID: 2543 RVA: 0x00021344 File Offset: 0x0001F544
		private static void OnOpacityEffectsChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.CarouselViewSettings carouselViewSettings = d as global::Infragistics.Windows.Controls.CarouselViewSettings;
			if (carouselViewSettings != null)
			{
				if (e.OldValue != null)
				{
					global::Infragistics.Windows.Controls.OpacityEffectStopCollection opacityEffectStopCollection = e.OldValue as global::Infragistics.Windows.Controls.OpacityEffectStopCollection;
					if (opacityEffectStopCollection != null)
					{
						opacityEffectStopCollection.PropertyChanged -= carouselViewSettings.OnOpacityEffectStopsCollectionChanged;
					}
				}
				if (e.NewValue != null)
				{
					global::Infragistics.Windows.Controls.OpacityEffectStopCollection opacityEffectStopCollection2 = e.NewValue as global::Infragistics.Windows.Controls.OpacityEffectStopCollection;
					if (opacityEffectStopCollection2 != null)
					{
						opacityEffectStopCollection2.PropertyChanged += carouselViewSettings.OnOpacityEffectStopsCollectionChanged;
					}
				}
			}
		}

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x060009F0 RID: 2544 RVA: 0x000213B1 File Offset: 0x0001F5B1
		// (set) Token: 0x060009F1 RID: 2545 RVA: 0x000213C3 File Offset: 0x0001F5C3
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.Controls.OpacityEffectStopCollection OpacityEffectStops
		{
			get
			{
				return base.GetValue(global::Infragistics.Windows.Controls.CarouselViewSettings.OpacityEffectStopsProperty) as global::Infragistics.Windows.Controls.OpacityEffectStopCollection;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.CarouselViewSettings.OpacityEffectStopsProperty, value);
			}
		}

		// Token: 0x060009F2 RID: 2546 RVA: 0x000213D1 File Offset: 0x0001F5D1
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeOpacityEffectStops()
		{
			return this.OpacityEffectStops.ShouldSerialize();
		}

		// Token: 0x060009F3 RID: 2547 RVA: 0x000213DE File Offset: 0x0001F5DE
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetOpacityEffectStops()
		{
			this.OpacityEffectStops.Clear();
		}

		// Token: 0x060009F4 RID: 2548 RVA: 0x000213EB File Offset: 0x0001F5EB
		private static bool OnValidateOpacityEffectStopDirection(object value)
		{
			if (!global::System.Enum.IsDefined(typeof(global::Infragistics.Windows.Controls.EffectStopDirection), value))
			{
				throw new global::System.ComponentModel.InvalidEnumArgumentException("value", (int)value, typeof(global::Infragistics.Windows.Controls.EffectStopDirection));
			}
			return true;
		}

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x060009F5 RID: 2549 RVA: 0x0002141B File Offset: 0x0001F61B
		// (set) Token: 0x060009F6 RID: 2550 RVA: 0x0002142D File Offset: 0x0001F62D
		public global::Infragistics.Windows.Controls.EffectStopDirection OpacityEffectStopDirection
		{
			get
			{
				return (global::Infragistics.Windows.Controls.EffectStopDirection)base.GetValue(global::Infragistics.Windows.Controls.CarouselViewSettings.OpacityEffectStopDirectionProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.CarouselViewSettings.OpacityEffectStopDirectionProperty, value);
			}
		}

		// Token: 0x060009F7 RID: 2551 RVA: 0x00021440 File Offset: 0x0001F640
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeOpacityEffectStopDirection()
		{
			return this.OpacityEffectStopDirection != (global::Infragistics.Windows.Controls.EffectStopDirection)global::Infragistics.Windows.Controls.CarouselViewSettings.OpacityEffectStopDirectionProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x060009F8 RID: 2552 RVA: 0x00021461 File Offset: 0x0001F661
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetOpacityEffectStopDirection()
		{
			base.ClearValue(global::Infragistics.Windows.Controls.CarouselViewSettings.OpacityEffectStopDirectionProperty);
		}

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x060009F9 RID: 2553 RVA: 0x0002146E File Offset: 0x0001F66E
		// (set) Token: 0x060009FA RID: 2554 RVA: 0x00021480 File Offset: 0x0001F680
		public bool ReserveSpaceForReflections
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.Controls.CarouselViewSettings.ReserveSpaceForReflectionsProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.CarouselViewSettings.ReserveSpaceForReflectionsProperty, value);
			}
		}

		// Token: 0x060009FB RID: 2555 RVA: 0x00021493 File Offset: 0x0001F693
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeReserveSpaceForReflections()
		{
			return this.ReserveSpaceForReflections != (bool)global::Infragistics.Windows.Controls.CarouselViewSettings.ReserveSpaceForReflectionsProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x060009FC RID: 2556 RVA: 0x000214B4 File Offset: 0x0001F6B4
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetReserveSpaceForReflections()
		{
			base.ClearValue(global::Infragistics.Windows.Controls.CarouselViewSettings.ReserveSpaceForReflectionsProperty);
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x060009FD RID: 2557 RVA: 0x000214C1 File Offset: 0x0001F6C1
		// (set) Token: 0x060009FE RID: 2558 RVA: 0x000214D3 File Offset: 0x0001F6D3
		public bool RotateItemsWithPathTangent
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.Controls.CarouselViewSettings.RotateItemsWithPathTangentProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.CarouselViewSettings.RotateItemsWithPathTangentProperty, value);
			}
		}

		// Token: 0x060009FF RID: 2559 RVA: 0x000214E6 File Offset: 0x0001F6E6
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeRotateItemsWithPathTangent()
		{
			return this.RotateItemsWithPathTangent != (bool)global::Infragistics.Windows.Controls.CarouselViewSettings.RotateItemsWithPathTangentProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x06000A00 RID: 2560 RVA: 0x00021507 File Offset: 0x0001F707
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetRotateItemsWithPathTangent()
		{
			base.ClearValue(global::Infragistics.Windows.Controls.CarouselViewSettings.RotateItemsWithPathTangentProperty);
		}

		// Token: 0x06000A01 RID: 2561 RVA: 0x00021514 File Offset: 0x0001F714
		private static void OnScalingEffectsChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.CarouselViewSettings carouselViewSettings = d as global::Infragistics.Windows.Controls.CarouselViewSettings;
			if (carouselViewSettings != null)
			{
				if (e.OldValue != null)
				{
					global::Infragistics.Windows.Controls.ScalingEffectStopCollection scalingEffectStopCollection = e.OldValue as global::Infragistics.Windows.Controls.ScalingEffectStopCollection;
					if (scalingEffectStopCollection != null)
					{
						scalingEffectStopCollection.PropertyChanged -= carouselViewSettings.OnScalingEffectStopsCollectionChanged;
					}
				}
				if (e.NewValue != null)
				{
					global::Infragistics.Windows.Controls.ScalingEffectStopCollection scalingEffectStopCollection2 = e.NewValue as global::Infragistics.Windows.Controls.ScalingEffectStopCollection;
					if (scalingEffectStopCollection2 != null)
					{
						scalingEffectStopCollection2.PropertyChanged += carouselViewSettings.OnScalingEffectStopsCollectionChanged;
					}
				}
			}
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x06000A02 RID: 2562 RVA: 0x00021581 File Offset: 0x0001F781
		// (set) Token: 0x06000A03 RID: 2563 RVA: 0x00021593 File Offset: 0x0001F793
		public global::Infragistics.Windows.Controls.ScalingEffectStopCollection ScalingEffectStops
		{
			get
			{
				return base.GetValue(global::Infragistics.Windows.Controls.CarouselViewSettings.ScalingEffectStopsProperty) as global::Infragistics.Windows.Controls.ScalingEffectStopCollection;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.CarouselViewSettings.ScalingEffectStopsProperty, value);
			}
		}

		// Token: 0x06000A04 RID: 2564 RVA: 0x000215A1 File Offset: 0x0001F7A1
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeScalingEffectStops()
		{
			return this.ScalingEffectStops.ShouldSerialize();
		}

		// Token: 0x06000A05 RID: 2565 RVA: 0x000215AE File Offset: 0x0001F7AE
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetScalingEffectStops()
		{
			this.ScalingEffectStops.Clear();
		}

		// Token: 0x06000A06 RID: 2566 RVA: 0x000215BB File Offset: 0x0001F7BB
		private static bool OnValidateScalingEffectStopDirection(object value)
		{
			if (!global::System.Enum.IsDefined(typeof(global::Infragistics.Windows.Controls.EffectStopDirection), value))
			{
				throw new global::System.ComponentModel.InvalidEnumArgumentException("value", (int)value, typeof(global::Infragistics.Windows.Controls.EffectStopDirection));
			}
			return true;
		}

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x06000A07 RID: 2567 RVA: 0x000215EB File Offset: 0x0001F7EB
		// (set) Token: 0x06000A08 RID: 2568 RVA: 0x000215FD File Offset: 0x0001F7FD
		public global::Infragistics.Windows.Controls.EffectStopDirection ScalingEffectStopDirection
		{
			get
			{
				return (global::Infragistics.Windows.Controls.EffectStopDirection)base.GetValue(global::Infragistics.Windows.Controls.CarouselViewSettings.ScalingEffectStopDirectionProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.CarouselViewSettings.ScalingEffectStopDirectionProperty, value);
			}
		}

		// Token: 0x06000A09 RID: 2569 RVA: 0x00021610 File Offset: 0x0001F810
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeScalingEffectStopDirection()
		{
			return this.ScalingEffectStopDirection != (global::Infragistics.Windows.Controls.EffectStopDirection)global::Infragistics.Windows.Controls.CarouselViewSettings.ScalingEffectStopDirectionProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x06000A0A RID: 2570 RVA: 0x00021631 File Offset: 0x0001F831
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetScalingEffectStopDirection()
		{
			base.ClearValue(global::Infragistics.Windows.Controls.CarouselViewSettings.ScalingEffectStopDirectionProperty);
		}

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x06000A0B RID: 2571 RVA: 0x0002163E File Offset: 0x0001F83E
		// (set) Token: 0x06000A0C RID: 2572 RVA: 0x00021650 File Offset: 0x0001F850
		public bool ShouldAnimateItemsOnListChange
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.Controls.CarouselViewSettings.ShouldAnimateItemsOnListChangeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.CarouselViewSettings.ShouldAnimateItemsOnListChangeProperty, value);
			}
		}

		// Token: 0x06000A0D RID: 2573 RVA: 0x00021663 File Offset: 0x0001F863
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeShouldAnimateItemsOnListChange()
		{
			return this.ShouldAnimateItemsOnListChange != (bool)global::Infragistics.Windows.Controls.CarouselViewSettings.ShouldAnimateItemsOnListChangeProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x06000A0E RID: 2574 RVA: 0x00021684 File Offset: 0x0001F884
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetShouldAnimateItemsOnListChange()
		{
			base.ClearValue(global::Infragistics.Windows.Controls.CarouselViewSettings.ShouldAnimateItemsOnListChangeProperty);
		}

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x06000A0F RID: 2575 RVA: 0x00021691 File Offset: 0x0001F891
		// (set) Token: 0x06000A10 RID: 2576 RVA: 0x000216A3 File Offset: 0x0001F8A3
		public bool ShouldScrollItemsIntoInitialPosition
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.Controls.CarouselViewSettings.ShouldScrollItemsIntoInitialPositionProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.CarouselViewSettings.ShouldScrollItemsIntoInitialPositionProperty, value);
			}
		}

		// Token: 0x06000A11 RID: 2577 RVA: 0x000216B6 File Offset: 0x0001F8B6
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeShouldScrollItemsIntoInitialPosition()
		{
			return this.ShouldScrollItemsIntoInitialPosition != (bool)global::Infragistics.Windows.Controls.CarouselViewSettings.ShouldScrollItemsIntoInitialPositionProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x06000A12 RID: 2578 RVA: 0x000216D7 File Offset: 0x0001F8D7
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetShouldScrollItemsIntoInitialPosition()
		{
			base.ClearValue(global::Infragistics.Windows.Controls.CarouselViewSettings.ShouldScrollItemsIntoInitialPositionProperty);
		}

		// Token: 0x06000A13 RID: 2579 RVA: 0x000216E4 File Offset: 0x0001F8E4
		private static void OnSkewAngleXEffectsChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.CarouselViewSettings carouselViewSettings = d as global::Infragistics.Windows.Controls.CarouselViewSettings;
			if (carouselViewSettings != null)
			{
				if (e.OldValue != null)
				{
					global::Infragistics.Windows.Controls.SkewAngleXEffectStopCollection skewAngleXEffectStopCollection = e.OldValue as global::Infragistics.Windows.Controls.SkewAngleXEffectStopCollection;
					if (skewAngleXEffectStopCollection != null)
					{
						skewAngleXEffectStopCollection.PropertyChanged -= carouselViewSettings.OnSkewAngleXEffectStopsCollectionChanged;
					}
				}
				if (e.NewValue != null)
				{
					global::Infragistics.Windows.Controls.SkewAngleXEffectStopCollection skewAngleXEffectStopCollection2 = e.NewValue as global::Infragistics.Windows.Controls.SkewAngleXEffectStopCollection;
					if (skewAngleXEffectStopCollection2 != null)
					{
						skewAngleXEffectStopCollection2.PropertyChanged += carouselViewSettings.OnSkewAngleXEffectStopsCollectionChanged;
					}
				}
			}
		}

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x06000A14 RID: 2580 RVA: 0x00021751 File Offset: 0x0001F951
		// (set) Token: 0x06000A15 RID: 2581 RVA: 0x00021763 File Offset: 0x0001F963
		public global::Infragistics.Windows.Controls.SkewAngleXEffectStopCollection SkewAngleXEffectStops
		{
			get
			{
				return base.GetValue(global::Infragistics.Windows.Controls.CarouselViewSettings.SkewAngleXEffectStopsProperty) as global::Infragistics.Windows.Controls.SkewAngleXEffectStopCollection;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.CarouselViewSettings.SkewAngleXEffectStopsProperty, value);
			}
		}

		// Token: 0x06000A16 RID: 2582 RVA: 0x00021771 File Offset: 0x0001F971
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeSkewAngleXEffectStops()
		{
			return this.SkewAngleXEffectStops.ShouldSerialize();
		}

		// Token: 0x06000A17 RID: 2583 RVA: 0x0002177E File Offset: 0x0001F97E
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetSkewAngleXEffectStops()
		{
			this.SkewAngleXEffectStops.Clear();
		}

		// Token: 0x06000A18 RID: 2584 RVA: 0x0002178B File Offset: 0x0001F98B
		private static bool OnValidateSkewAngleXEffectStopDirection(object value)
		{
			if (!global::System.Enum.IsDefined(typeof(global::Infragistics.Windows.Controls.EffectStopDirection), value))
			{
				throw new global::System.ComponentModel.InvalidEnumArgumentException("value", (int)value, typeof(global::Infragistics.Windows.Controls.EffectStopDirection));
			}
			return true;
		}

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x06000A19 RID: 2585 RVA: 0x000217BB File Offset: 0x0001F9BB
		// (set) Token: 0x06000A1A RID: 2586 RVA: 0x000217CD File Offset: 0x0001F9CD
		public global::Infragistics.Windows.Controls.EffectStopDirection SkewAngleXEffectStopDirection
		{
			get
			{
				return (global::Infragistics.Windows.Controls.EffectStopDirection)base.GetValue(global::Infragistics.Windows.Controls.CarouselViewSettings.SkewAngleXEffectStopDirectionProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.CarouselViewSettings.SkewAngleXEffectStopDirectionProperty, value);
			}
		}

		// Token: 0x06000A1B RID: 2587 RVA: 0x000217E0 File Offset: 0x0001F9E0
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeSkewAngleXEffectStopDirection()
		{
			return this.SkewAngleXEffectStopDirection != (global::Infragistics.Windows.Controls.EffectStopDirection)global::Infragistics.Windows.Controls.CarouselViewSettings.SkewAngleXEffectStopDirectionProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x06000A1C RID: 2588 RVA: 0x00021801 File Offset: 0x0001FA01
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetSkewAngleXEffectStopDirection()
		{
			base.ClearValue(global::Infragistics.Windows.Controls.CarouselViewSettings.SkewAngleXEffectStopDirectionProperty);
		}

		// Token: 0x06000A1D RID: 2589 RVA: 0x00021810 File Offset: 0x0001FA10
		private static void OnSkewAngleYEffectsChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.CarouselViewSettings carouselViewSettings = d as global::Infragistics.Windows.Controls.CarouselViewSettings;
			if (carouselViewSettings != null)
			{
				if (e.OldValue != null)
				{
					global::Infragistics.Windows.Controls.SkewAngleYEffectStopCollection skewAngleYEffectStopCollection = e.OldValue as global::Infragistics.Windows.Controls.SkewAngleYEffectStopCollection;
					if (skewAngleYEffectStopCollection != null)
					{
						skewAngleYEffectStopCollection.PropertyChanged -= carouselViewSettings.OnSkewAngleYEffectStopsCollectionChanged;
					}
				}
				if (e.NewValue != null)
				{
					global::Infragistics.Windows.Controls.SkewAngleYEffectStopCollection skewAngleYEffectStopCollection2 = e.NewValue as global::Infragistics.Windows.Controls.SkewAngleYEffectStopCollection;
					if (skewAngleYEffectStopCollection2 != null)
					{
						skewAngleYEffectStopCollection2.PropertyChanged += carouselViewSettings.OnSkewAngleYEffectStopsCollectionChanged;
					}
				}
			}
		}

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x06000A1E RID: 2590 RVA: 0x0002187D File Offset: 0x0001FA7D
		// (set) Token: 0x06000A1F RID: 2591 RVA: 0x0002188F File Offset: 0x0001FA8F
		public global::Infragistics.Windows.Controls.SkewAngleYEffectStopCollection SkewAngleYEffectStops
		{
			get
			{
				return base.GetValue(global::Infragistics.Windows.Controls.CarouselViewSettings.SkewAngleYEffectStopsProperty) as global::Infragistics.Windows.Controls.SkewAngleYEffectStopCollection;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.CarouselViewSettings.SkewAngleYEffectStopsProperty, value);
			}
		}

		// Token: 0x06000A20 RID: 2592 RVA: 0x0002189D File Offset: 0x0001FA9D
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeSkewAngleYEffectStops()
		{
			return this.SkewAngleYEffectStops.ShouldSerialize();
		}

		// Token: 0x06000A21 RID: 2593 RVA: 0x000218AA File Offset: 0x0001FAAA
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetSkewAngleYEffectStops()
		{
			this.SkewAngleYEffectStops.Clear();
		}

		// Token: 0x06000A22 RID: 2594 RVA: 0x000218B7 File Offset: 0x0001FAB7
		private static bool OnValidateSkewAngleYEffectStopDirection(object value)
		{
			if (!global::System.Enum.IsDefined(typeof(global::Infragistics.Windows.Controls.EffectStopDirection), value))
			{
				throw new global::System.ComponentModel.InvalidEnumArgumentException("value", (int)value, typeof(global::Infragistics.Windows.Controls.EffectStopDirection));
			}
			return true;
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x06000A23 RID: 2595 RVA: 0x000218E7 File Offset: 0x0001FAE7
		// (set) Token: 0x06000A24 RID: 2596 RVA: 0x000218F9 File Offset: 0x0001FAF9
		public global::Infragistics.Windows.Controls.EffectStopDirection SkewAngleYEffectStopDirection
		{
			get
			{
				return (global::Infragistics.Windows.Controls.EffectStopDirection)base.GetValue(global::Infragistics.Windows.Controls.CarouselViewSettings.SkewAngleYEffectStopDirectionProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.CarouselViewSettings.SkewAngleYEffectStopDirectionProperty, value);
			}
		}

		// Token: 0x06000A25 RID: 2597 RVA: 0x0002190C File Offset: 0x0001FB0C
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeSkewAngleYEffectStopDirection()
		{
			return this.SkewAngleYEffectStopDirection != (global::Infragistics.Windows.Controls.EffectStopDirection)global::Infragistics.Windows.Controls.CarouselViewSettings.SkewAngleYEffectStopDirectionProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x06000A26 RID: 2598 RVA: 0x0002192D File Offset: 0x0001FB2D
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetSkewAngleYEffectStopDirection()
		{
			base.ClearValue(global::Infragistics.Windows.Controls.CarouselViewSettings.SkewAngleYEffectStopDirectionProperty);
		}

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x06000A27 RID: 2599 RVA: 0x0002193A File Offset: 0x0001FB3A
		// (set) Token: 0x06000A28 RID: 2600 RVA: 0x0002194C File Offset: 0x0001FB4C
		public bool UseOpacity
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.Controls.CarouselViewSettings.UseOpacityProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.CarouselViewSettings.UseOpacityProperty, value);
			}
		}

		// Token: 0x06000A29 RID: 2601 RVA: 0x0002195F File Offset: 0x0001FB5F
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeUseOpacity()
		{
			return this.UseOpacity != (bool)global::Infragistics.Windows.Controls.CarouselViewSettings.UseOpacityProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x06000A2A RID: 2602 RVA: 0x00021980 File Offset: 0x0001FB80
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetUseOpacity()
		{
			base.ClearValue(global::Infragistics.Windows.Controls.CarouselViewSettings.UseOpacityProperty);
		}

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x06000A2B RID: 2603 RVA: 0x0002198D File Offset: 0x0001FB8D
		// (set) Token: 0x06000A2C RID: 2604 RVA: 0x0002199F File Offset: 0x0001FB9F
		public bool UseScaling
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.Controls.CarouselViewSettings.UseScalingProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.CarouselViewSettings.UseScalingProperty, value);
			}
		}

		// Token: 0x06000A2D RID: 2605 RVA: 0x000219B2 File Offset: 0x0001FBB2
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeUseScaling()
		{
			return this.UseScaling != (bool)global::Infragistics.Windows.Controls.CarouselViewSettings.UseScalingProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x06000A2E RID: 2606 RVA: 0x000219D3 File Offset: 0x0001FBD3
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetUseScaling()
		{
			base.ClearValue(global::Infragistics.Windows.Controls.CarouselViewSettings.UseScalingProperty);
		}

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x06000A2F RID: 2607 RVA: 0x000219E0 File Offset: 0x0001FBE0
		// (set) Token: 0x06000A30 RID: 2608 RVA: 0x000219F2 File Offset: 0x0001FBF2
		public bool UseSkewing
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.Controls.CarouselViewSettings.UseSkewingProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.CarouselViewSettings.UseSkewingProperty, value);
			}
		}

		// Token: 0x06000A31 RID: 2609 RVA: 0x00021A05 File Offset: 0x0001FC05
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeUseSkewing()
		{
			return this.UseSkewing != (bool)global::Infragistics.Windows.Controls.CarouselViewSettings.UseSkewingProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x06000A32 RID: 2610 RVA: 0x00021A26 File Offset: 0x0001FC26
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetUseSkewing()
		{
			base.ClearValue(global::Infragistics.Windows.Controls.CarouselViewSettings.UseSkewingProperty);
		}

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x06000A33 RID: 2611 RVA: 0x00021A33 File Offset: 0x0001FC33
		// (set) Token: 0x06000A34 RID: 2612 RVA: 0x00021A45 File Offset: 0x0001FC45
		public bool UseZOrder
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.Controls.CarouselViewSettings.UseZOrderProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.CarouselViewSettings.UseZOrderProperty, value);
			}
		}

		// Token: 0x06000A35 RID: 2613 RVA: 0x00021A58 File Offset: 0x0001FC58
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeUseZOrder()
		{
			return this.UseZOrder != (bool)global::Infragistics.Windows.Controls.CarouselViewSettings.UseZOrderProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x06000A36 RID: 2614 RVA: 0x00021A79 File Offset: 0x0001FC79
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetUseZOrder()
		{
			base.ClearValue(global::Infragistics.Windows.Controls.CarouselViewSettings.UseZOrderProperty);
		}

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x06000A37 RID: 2615 RVA: 0x00021A86 File Offset: 0x0001FC86
		// (set) Token: 0x06000A38 RID: 2616 RVA: 0x00021A98 File Offset: 0x0001FC98
		public double WidthInInfiniteContainers
		{
			get
			{
				return (double)base.GetValue(global::Infragistics.Windows.Controls.CarouselViewSettings.WidthInInfiniteContainersProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.CarouselViewSettings.WidthInInfiniteContainersProperty, value);
			}
		}

		// Token: 0x06000A39 RID: 2617 RVA: 0x00021AAB File Offset: 0x0001FCAB
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeWidthInInfiniteContainers()
		{
			return this.WidthInInfiniteContainers != (double)global::Infragistics.Windows.Controls.CarouselViewSettings.WidthInInfiniteContainersProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x06000A3A RID: 2618 RVA: 0x00021ACC File Offset: 0x0001FCCC
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetWidthInInfiniteContainers()
		{
			base.ClearValue(global::Infragistics.Windows.Controls.CarouselViewSettings.WidthInInfiniteContainersProperty);
		}

		// Token: 0x06000A3B RID: 2619 RVA: 0x00021ADC File Offset: 0x0001FCDC
		private static void OnZOrderEffectsChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.CarouselViewSettings carouselViewSettings = d as global::Infragistics.Windows.Controls.CarouselViewSettings;
			if (carouselViewSettings != null)
			{
				if (e.OldValue != null)
				{
					global::Infragistics.Windows.Controls.ZOrderEffectStopCollection zorderEffectStopCollection = e.OldValue as global::Infragistics.Windows.Controls.ZOrderEffectStopCollection;
					if (zorderEffectStopCollection != null)
					{
						zorderEffectStopCollection.PropertyChanged -= carouselViewSettings.OnZOrderEffectStopsCollectionChanged;
					}
				}
				if (e.NewValue != null)
				{
					global::Infragistics.Windows.Controls.ZOrderEffectStopCollection zorderEffectStopCollection2 = e.NewValue as global::Infragistics.Windows.Controls.ZOrderEffectStopCollection;
					if (zorderEffectStopCollection2 != null)
					{
						zorderEffectStopCollection2.PropertyChanged += carouselViewSettings.OnZOrderEffectStopsCollectionChanged;
					}
				}
			}
		}

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x06000A3C RID: 2620 RVA: 0x00021B49 File Offset: 0x0001FD49
		// (set) Token: 0x06000A3D RID: 2621 RVA: 0x00021B5B File Offset: 0x0001FD5B
		public global::Infragistics.Windows.Controls.ZOrderEffectStopCollection ZOrderEffectStops
		{
			get
			{
				return base.GetValue(global::Infragistics.Windows.Controls.CarouselViewSettings.ZOrderEffectStopsProperty) as global::Infragistics.Windows.Controls.ZOrderEffectStopCollection;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.CarouselViewSettings.ZOrderEffectStopsProperty, value);
			}
		}

		// Token: 0x06000A3E RID: 2622 RVA: 0x00021B69 File Offset: 0x0001FD69
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeZOrderEffectStops()
		{
			return this.ZOrderEffectStops.ShouldSerialize();
		}

		// Token: 0x06000A3F RID: 2623 RVA: 0x00021B76 File Offset: 0x0001FD76
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetZOrderEffectStops()
		{
			this.ZOrderEffectStops.Clear();
		}

		// Token: 0x06000A40 RID: 2624 RVA: 0x00021B83 File Offset: 0x0001FD83
		private static bool OnValidateZOrderEffectStopDirection(object value)
		{
			if (!global::System.Enum.IsDefined(typeof(global::Infragistics.Windows.Controls.EffectStopDirection), value))
			{
				throw new global::System.ComponentModel.InvalidEnumArgumentException("value", (int)value, typeof(global::Infragistics.Windows.Controls.EffectStopDirection));
			}
			return true;
		}

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x06000A41 RID: 2625 RVA: 0x00021BB3 File Offset: 0x0001FDB3
		// (set) Token: 0x06000A42 RID: 2626 RVA: 0x00021BC5 File Offset: 0x0001FDC5
		public global::Infragistics.Windows.Controls.EffectStopDirection ZOrderEffectStopDirection
		{
			get
			{
				return (global::Infragistics.Windows.Controls.EffectStopDirection)base.GetValue(global::Infragistics.Windows.Controls.CarouselViewSettings.ZOrderEffectStopDirectionProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.CarouselViewSettings.ZOrderEffectStopDirectionProperty, value);
			}
		}

		// Token: 0x06000A43 RID: 2627 RVA: 0x00021BD8 File Offset: 0x0001FDD8
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeZOrderEffectStopDirection()
		{
			return this.ZOrderEffectStopDirection != (global::Infragistics.Windows.Controls.EffectStopDirection)global::Infragistics.Windows.Controls.CarouselViewSettings.ZOrderEffectStopDirectionProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x06000A44 RID: 2628 RVA: 0x00021BF9 File Offset: 0x0001FDF9
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetZOrderEffectStopDirection()
		{
			base.ClearValue(global::Infragistics.Windows.Controls.CarouselViewSettings.ZOrderEffectStopDirectionProperty);
		}

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x06000A45 RID: 2629 RVA: 0x00021C06 File Offset: 0x0001FE06
		internal int Version
		{
			get
			{
				return (int)base.GetValue(global::Infragistics.Windows.Controls.CarouselViewSettings.VersionProperty);
			}
		}

		// Token: 0x06000A46 RID: 2630 RVA: 0x00021C18 File Offset: 0x0001FE18
		internal void EnumeratePropertiesWithNonDefaultValues(global::System.ComponentModel.PropertyChangedEventHandler callback)
		{
			global::System.Windows.LocalValueEnumerator localValueEnumerator = base.GetLocalValueEnumerator();
			while (localValueEnumerator.MoveNext())
			{
				global::System.Windows.LocalValueEntry localValueEntry = localValueEnumerator.Current;
				if (!object.Equals(localValueEntry.Property.DefaultMetadata.DefaultValue, localValueEntry.Value))
				{
					callback(this, new global::System.ComponentModel.PropertyChangedEventArgs(localValueEntry.Property.Name));
				}
			}
		}

		// Token: 0x06000A47 RID: 2631 RVA: 0x00021C76 File Offset: 0x0001FE76
		private void OnOpacityEffectStopsCollectionChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			base.RaisePropertyChangedEvent("OpacityEffectStops");
		}

		// Token: 0x06000A48 RID: 2632 RVA: 0x00021C83 File Offset: 0x0001FE83
		private void OnScalingEffectStopsCollectionChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			base.RaisePropertyChangedEvent("ScalingEffectStops");
		}

		// Token: 0x06000A49 RID: 2633 RVA: 0x00021C90 File Offset: 0x0001FE90
		private void OnSkewAngleXEffectStopsCollectionChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			base.RaisePropertyChangedEvent("SkewAngleXEffectStops");
		}

		// Token: 0x06000A4A RID: 2634 RVA: 0x00021C9D File Offset: 0x0001FE9D
		private void OnSkewAngleYEffectStopsCollectionChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			base.RaisePropertyChangedEvent("SkewAngleYEffectStops");
		}

		// Token: 0x06000A4B RID: 2635 RVA: 0x00021CAA File Offset: 0x0001FEAA
		private void OnZOrderEffectStopsCollectionChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			base.RaisePropertyChangedEvent("ZOrderEffectStops");
		}

		// Token: 0x06000A4C RID: 2636 RVA: 0x00021CB7 File Offset: 0x0001FEB7
		private static bool ValidatePositiveDouble(object value)
		{
			return value is double && !double.IsNaN((double)value) && (double)value > 0.0;
		}

		// Token: 0x0400044E RID: 1102
		internal const int DEFAULT_ITEMS_PER_PAGE = 5;

		// Token: 0x0400044F RID: 1103
		private const double DEFAULT_PATH_PREFIX_PCT = 0.15;

		// Token: 0x04000450 RID: 1104
		private const double DEFAULT_PATH_SUFFIX_PCT = 0.15;

		// Token: 0x04000451 RID: 1105
		private const double DEFAULT_WIDTH_IN_INFINITE_CONTAINERS = 400.0;

		// Token: 0x04000452 RID: 1106
		private const double DEFAULT_HEIGHT_IN_INFINITE_CONTAINERS = 300.0;

		// Token: 0x04000453 RID: 1107
		private static readonly global::System.Windows.Size DEFAULT_ITEM_SIZE = new global::System.Windows.Size(150.0, 100.0);

		// Token: 0x04000454 RID: 1108
		public static readonly global::System.Windows.DependencyProperty AutoScaleItemContentsToFitProperty = global::System.Windows.DependencyProperty.Register("AutoScaleItemContentsToFit", typeof(bool), typeof(global::Infragistics.Windows.Controls.CarouselViewSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x04000455 RID: 1109
		public static readonly global::System.Windows.DependencyProperty CarouselPanelNavigatorStyleProperty = global::System.Windows.DependencyProperty.Register("CarouselPanelNavigatorStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Windows.Controls.CarouselViewSettings), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000456 RID: 1110
		public static readonly global::System.Windows.DependencyProperty HeightInInfiniteContainersProperty = global::System.Windows.DependencyProperty.Register("HeightInInfiniteContainers", typeof(double), typeof(global::Infragistics.Windows.Controls.CarouselViewSettings), new global::System.Windows.FrameworkPropertyMetadata(300.0), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.Controls.CarouselViewSettings.ValidatePositiveDouble));

		// Token: 0x04000457 RID: 1111
		public static readonly global::System.Windows.DependencyProperty IsListContinuousProperty = global::System.Windows.DependencyProperty.Register("IsListContinuous", typeof(bool), typeof(global::Infragistics.Windows.Controls.CarouselViewSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x04000458 RID: 1112
		public static readonly global::System.Windows.DependencyProperty IsNavigatorVisibleProperty = global::System.Windows.DependencyProperty.Register("IsNavigatorVisible", typeof(bool), typeof(global::Infragistics.Windows.Controls.CarouselViewSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.TrueBox));

		// Token: 0x04000459 RID: 1113
		public static readonly global::System.Windows.DependencyProperty ItemHorizontalScrollBarVisibilityProperty = global::System.Windows.DependencyProperty.Register("ItemHorizontalScrollBarVisibility", typeof(global::System.Windows.Controls.ScrollBarVisibility), typeof(global::Infragistics.Windows.Controls.CarouselViewSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.ScrollBarVisibilityAutoBox), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.Controls.CarouselViewSettings.OnValidateItemHorizontalScrollBarVisibility));

		// Token: 0x0400045A RID: 1114
		public static readonly global::System.Windows.DependencyProperty ItemVerticalScrollBarVisibilityProperty = global::System.Windows.DependencyProperty.Register("ItemVerticalScrollBarVisibility", typeof(global::System.Windows.Controls.ScrollBarVisibility), typeof(global::Infragistics.Windows.Controls.CarouselViewSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.ScrollBarVisibilityAutoBox), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.Controls.CarouselViewSettings.OnValidateItemVerticalScrollBarVisibility));

		// Token: 0x0400045B RID: 1115
		public static readonly global::System.Windows.DependencyProperty ItemPathProperty = global::System.Windows.DependencyProperty.Register("ItemPath", typeof(global::System.Windows.Shapes.Shape), typeof(global::Infragistics.Windows.Controls.CarouselViewSettings), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x0400045C RID: 1116
		public static readonly global::System.Windows.DependencyProperty ItemPathAutoPadProperty = global::System.Windows.DependencyProperty.Register("ItemPathAutoPad", typeof(bool), typeof(global::Infragistics.Windows.Controls.CarouselViewSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.TrueBox));

		// Token: 0x0400045D RID: 1117
		public static readonly global::System.Windows.DependencyProperty ItemPathHorizontalAlignmentProperty = global::System.Windows.DependencyProperty.Register("ItemPathHorizontalAlignment", typeof(global::System.Windows.HorizontalAlignment), typeof(global::Infragistics.Windows.Controls.CarouselViewSettings), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.HorizontalAlignment.Center));

		// Token: 0x0400045E RID: 1118
		public static readonly global::System.Windows.DependencyProperty ItemPathPaddingProperty = global::System.Windows.DependencyProperty.Register("ItemPathPadding", typeof(global::System.Windows.Thickness), typeof(global::Infragistics.Windows.Controls.CarouselViewSettings), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.Thickness(0.0)));

		// Token: 0x0400045F RID: 1119
		public static readonly global::System.Windows.DependencyProperty ItemPathStretchProperty = global::System.Windows.DependencyProperty.Register("ItemPathStretch", typeof(global::System.Windows.Media.Stretch), typeof(global::Infragistics.Windows.Controls.CarouselViewSettings), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Media.Stretch.Fill));

		// Token: 0x04000460 RID: 1120
		public static readonly global::System.Windows.DependencyProperty ItemPathPrefixPercentProperty = global::System.Windows.DependencyProperty.Register("ItemPathPrefixPercent", typeof(double), typeof(global::Infragistics.Windows.Controls.CarouselViewSettings), new global::System.Windows.FrameworkPropertyMetadata(0.15, null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.Controls.CarouselViewSettings.OnCoerceItemPathPrefixPercent)));

		// Token: 0x04000461 RID: 1121
		public static readonly global::System.Windows.DependencyProperty ItemPathSuffixPercentProperty = global::System.Windows.DependencyProperty.Register("ItemPathSuffixPercent", typeof(double), typeof(global::Infragistics.Windows.Controls.CarouselViewSettings), new global::System.Windows.FrameworkPropertyMetadata(0.15, null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.Controls.CarouselViewSettings.OnCoerceItemPathSuffixPercent)));

		// Token: 0x04000462 RID: 1122
		public static readonly global::System.Windows.DependencyProperty ItemPathRenderBrushProperty = global::System.Windows.DependencyProperty.Register("ItemPathRenderBrush", typeof(global::System.Windows.Media.Brush), typeof(global::Infragistics.Windows.Controls.CarouselViewSettings), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000463 RID: 1123
		public static readonly global::System.Windows.DependencyProperty ItemPathRenderPenProperty = global::System.Windows.DependencyProperty.Register("ItemPathRenderPen", typeof(global::System.Windows.Media.Pen), typeof(global::Infragistics.Windows.Controls.CarouselViewSettings), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000464 RID: 1124
		public static readonly global::System.Windows.DependencyProperty ItemPathVerticalAlignmentProperty = global::System.Windows.DependencyProperty.Register("ItemPathVerticalAlignment", typeof(global::System.Windows.VerticalAlignment), typeof(global::Infragistics.Windows.Controls.CarouselViewSettings), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.VerticalAlignment.Center));

		// Token: 0x04000465 RID: 1125
		public static readonly global::System.Windows.DependencyProperty ItemSizeProperty = global::System.Windows.DependencyProperty.Register("ItemSize", typeof(global::System.Windows.Size), typeof(global::Infragistics.Windows.Controls.CarouselViewSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.Controls.CarouselViewSettings.DEFAULT_ITEM_SIZE));

		// Token: 0x04000466 RID: 1126
		public static readonly global::System.Windows.DependencyProperty ItemsPerPageProperty = global::System.Windows.DependencyProperty.Register("ItemsPerPage", typeof(int), typeof(global::Infragistics.Windows.Controls.CarouselViewSettings), new global::System.Windows.FrameworkPropertyMetadata(5, null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.Controls.CarouselViewSettings.OnCoerceItemsPerPage)));

		// Token: 0x04000467 RID: 1127
		public static readonly global::System.Windows.DependencyProperty ItemTransitionStyleProperty = global::System.Windows.DependencyProperty.Register("ItemTransitionStyle", typeof(global::Infragistics.Windows.Controls.PathItemTransitionStyle), typeof(global::Infragistics.Windows.Controls.CarouselViewSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.Controls.PathItemTransitionStyle.AdjustOpacity), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.Controls.CarouselViewSettings.OnValidateItemTransitionStyle));

		// Token: 0x04000468 RID: 1128
		public static readonly global::System.Windows.DependencyProperty OpacityEffectStopsProperty = global::System.Windows.DependencyProperty.Register("OpacityEffectStops", typeof(global::Infragistics.Windows.Controls.OpacityEffectStopCollection), typeof(global::Infragistics.Windows.Controls.CarouselViewSettings), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.CarouselViewSettings.OnOpacityEffectsChanged)));

		// Token: 0x04000469 RID: 1129
		public static readonly global::System.Windows.DependencyProperty OpacityEffectStopDirectionProperty = global::System.Windows.DependencyProperty.Register("OpacityEffectStopDirection", typeof(global::Infragistics.Windows.Controls.EffectStopDirection), typeof(global::Infragistics.Windows.Controls.CarouselViewSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.Controls.EffectStopDirection.Default), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.Controls.CarouselViewSettings.OnValidateOpacityEffectStopDirection));

		// Token: 0x0400046A RID: 1130
		public static readonly global::System.Windows.DependencyProperty ReserveSpaceForReflectionsProperty = global::System.Windows.DependencyProperty.Register("ReserveSpaceForReflections", typeof(bool), typeof(global::Infragistics.Windows.Controls.CarouselViewSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.TrueBox));

		// Token: 0x0400046B RID: 1131
		public static readonly global::System.Windows.DependencyProperty RotateItemsWithPathTangentProperty = global::System.Windows.DependencyProperty.Register("RotateItemsWithPathTangent", typeof(bool), typeof(global::Infragistics.Windows.Controls.CarouselViewSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x0400046C RID: 1132
		public static readonly global::System.Windows.DependencyProperty ScalingEffectStopsProperty = global::System.Windows.DependencyProperty.Register("ScalingEffectStops", typeof(global::Infragistics.Windows.Controls.ScalingEffectStopCollection), typeof(global::Infragistics.Windows.Controls.CarouselViewSettings), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.CarouselViewSettings.OnScalingEffectsChanged)));

		// Token: 0x0400046D RID: 1133
		public static readonly global::System.Windows.DependencyProperty ScalingEffectStopDirectionProperty = global::System.Windows.DependencyProperty.Register("ScalingEffectStopDirection", typeof(global::Infragistics.Windows.Controls.EffectStopDirection), typeof(global::Infragistics.Windows.Controls.CarouselViewSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.Controls.EffectStopDirection.Default), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.Controls.CarouselViewSettings.OnValidateScalingEffectStopDirection));

		// Token: 0x0400046E RID: 1134
		public static readonly global::System.Windows.DependencyProperty ShouldAnimateItemsOnListChangeProperty = global::System.Windows.DependencyProperty.Register("ShouldAnimateItemsOnListChange", typeof(bool), typeof(global::Infragistics.Windows.Controls.CarouselViewSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x0400046F RID: 1135
		public static readonly global::System.Windows.DependencyProperty ShouldScrollItemsIntoInitialPositionProperty = global::System.Windows.DependencyProperty.Register("ShouldScrollItemsIntoInitialPosition", typeof(bool), typeof(global::Infragistics.Windows.Controls.CarouselViewSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.TrueBox));

		// Token: 0x04000470 RID: 1136
		public static readonly global::System.Windows.DependencyProperty SkewAngleXEffectStopsProperty = global::System.Windows.DependencyProperty.Register("SkewAngleXEffectStops", typeof(global::Infragistics.Windows.Controls.SkewAngleXEffectStopCollection), typeof(global::Infragistics.Windows.Controls.CarouselViewSettings), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.CarouselViewSettings.OnSkewAngleXEffectsChanged)));

		// Token: 0x04000471 RID: 1137
		public static readonly global::System.Windows.DependencyProperty SkewAngleXEffectStopDirectionProperty = global::System.Windows.DependencyProperty.Register("SkewAngleXEffectStopDirection", typeof(global::Infragistics.Windows.Controls.EffectStopDirection), typeof(global::Infragistics.Windows.Controls.CarouselViewSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.Controls.EffectStopDirection.Default), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.Controls.CarouselViewSettings.OnValidateSkewAngleXEffectStopDirection));

		// Token: 0x04000472 RID: 1138
		public static readonly global::System.Windows.DependencyProperty SkewAngleYEffectStopsProperty = global::System.Windows.DependencyProperty.Register("SkewAngleYEffectStops", typeof(global::Infragistics.Windows.Controls.SkewAngleYEffectStopCollection), typeof(global::Infragistics.Windows.Controls.CarouselViewSettings), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.CarouselViewSettings.OnSkewAngleYEffectsChanged)));

		// Token: 0x04000473 RID: 1139
		public static readonly global::System.Windows.DependencyProperty SkewAngleYEffectStopDirectionProperty = global::System.Windows.DependencyProperty.Register("SkewAngleYEffectStopDirection", typeof(global::Infragistics.Windows.Controls.EffectStopDirection), typeof(global::Infragistics.Windows.Controls.CarouselViewSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.Controls.EffectStopDirection.Default), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.Controls.CarouselViewSettings.OnValidateSkewAngleYEffectStopDirection));

		// Token: 0x04000474 RID: 1140
		public static readonly global::System.Windows.DependencyProperty UseOpacityProperty = global::System.Windows.DependencyProperty.Register("UseOpacity", typeof(bool), typeof(global::Infragistics.Windows.Controls.CarouselViewSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x04000475 RID: 1141
		public static readonly global::System.Windows.DependencyProperty UseScalingProperty = global::System.Windows.DependencyProperty.Register("UseScaling", typeof(bool), typeof(global::Infragistics.Windows.Controls.CarouselViewSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.TrueBox));

		// Token: 0x04000476 RID: 1142
		public static readonly global::System.Windows.DependencyProperty UseSkewingProperty = global::System.Windows.DependencyProperty.Register("UseSkewing", typeof(bool), typeof(global::Infragistics.Windows.Controls.CarouselViewSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x04000477 RID: 1143
		public static readonly global::System.Windows.DependencyProperty UseZOrderProperty = global::System.Windows.DependencyProperty.Register("UseZOrder", typeof(bool), typeof(global::Infragistics.Windows.Controls.CarouselViewSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x04000478 RID: 1144
		public static readonly global::System.Windows.DependencyProperty WidthInInfiniteContainersProperty = global::System.Windows.DependencyProperty.Register("WidthInInfiniteContainers", typeof(double), typeof(global::Infragistics.Windows.Controls.CarouselViewSettings), new global::System.Windows.FrameworkPropertyMetadata(400.0), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.Controls.CarouselViewSettings.ValidatePositiveDouble));

		// Token: 0x04000479 RID: 1145
		public static readonly global::System.Windows.DependencyProperty ZOrderEffectStopsProperty = global::System.Windows.DependencyProperty.Register("ZOrderEffectStops", typeof(global::Infragistics.Windows.Controls.ZOrderEffectStopCollection), typeof(global::Infragistics.Windows.Controls.CarouselViewSettings), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.CarouselViewSettings.OnZOrderEffectsChanged)));

		// Token: 0x0400047A RID: 1146
		public static readonly global::System.Windows.DependencyProperty ZOrderEffectStopDirectionProperty = global::System.Windows.DependencyProperty.Register("ZOrderEffectStopDirection", typeof(global::Infragistics.Windows.Controls.EffectStopDirection), typeof(global::Infragistics.Windows.Controls.CarouselViewSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.Controls.EffectStopDirection.Default), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.Controls.CarouselViewSettings.OnValidateZOrderEffectStopDirection));

		// Token: 0x0400047B RID: 1147
		private static readonly global::System.Windows.DependencyPropertyKey VersionPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("Version", typeof(int), typeof(global::Infragistics.Windows.Controls.CarouselViewSettings), new global::System.Windows.FrameworkPropertyMetadata(0));

		// Token: 0x0400047C RID: 1148
		public static readonly global::System.Windows.DependencyProperty VersionProperty = global::Infragistics.Windows.Controls.CarouselViewSettings.VersionPropertyKey.DependencyProperty;
	}
}
