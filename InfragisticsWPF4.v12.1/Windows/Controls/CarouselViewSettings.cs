using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Infragistics.Windows.Controls
{
	// Token: 0x020000FA RID: 250
	[global::System.Windows.StyleTypedProperty(Property = "CarouselPanelNavigatorStyle", StyleTargetType = typeof(global::Infragistics.Windows.Controls.CarouselPanelNavigator))]
	public class CarouselViewSettings : global::Infragistics.Windows.Controls.ViewSettingsBase
	{
		// Token: 0x06000895 RID: 2197 RVA: 0x0001CCF0 File Offset: 0x0001AEF0
		public CarouselViewSettings()
		{
			base.SetValue(global::Infragistics.Windows.Controls.CarouselViewSettings.OpacityEffectStopsProperty, new global::Infragistics.Windows.Controls.OpacityEffectStopCollection());
			base.SetValue(global::Infragistics.Windows.Controls.CarouselViewSettings.ScalingEffectStopsProperty, new global::Infragistics.Windows.Controls.ScalingEffectStopCollection());
			base.SetValue(global::Infragistics.Windows.Controls.CarouselViewSettings.SkewAngleXEffectStopsProperty, new global::Infragistics.Windows.Controls.SkewAngleXEffectStopCollection());
			base.SetValue(global::Infragistics.Windows.Controls.CarouselViewSettings.SkewAngleYEffectStopsProperty, new global::Infragistics.Windows.Controls.SkewAngleYEffectStopCollection());
			base.SetValue(global::Infragistics.Windows.Controls.CarouselViewSettings.ZOrderEffectStopsProperty, new global::Infragistics.Windows.Controls.ZOrderEffectStopCollection());
		}

		// Token: 0x06000896 RID: 2198 RVA: 0x0001CD53 File Offset: 0x0001AF53
		protected internal override void OnControlInitialized()
		{
		}

		// Token: 0x06000897 RID: 2199 RVA: 0x0001CD55 File Offset: 0x0001AF55
		protected override void OnPropertyChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			base.OnPropertyChanged(e);
			if (e.Property != global::Infragistics.Windows.Controls.CarouselViewSettings.VersionProperty && !global::System.ComponentModel.DesignerProperties.GetIsInDesignMode(this))
			{
				base.SetValue(global::Infragistics.Windows.Controls.CarouselViewSettings.VersionPropertyKey, this.Version + 1);
			}
		}

		// Token: 0x06000898 RID: 2200 RVA: 0x0001CD8C File Offset: 0x0001AF8C
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

		// Token: 0x06000899 RID: 2201 RVA: 0x0001CE84 File Offset: 0x0001B084
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override bool ShouldSerialize()
		{
			return this.ShouldSerializeAutoScaleItemContentsToFit() || this.ShouldSerializeCarouselPanelNavigatorStyle() || this.ShouldSerializeHeightInInfiniteContainers() || this.ShouldSerializeIsListContinuous() || this.ShouldSerializeIsNavigatorVisible() || this.ShouldSerializeItemHorizontalScrollBarVisibility() || this.ShouldSerializeItemPath() || this.ShouldSerializeItemPathAutoPad() || this.ShouldSerializeItemPathHorizontalAlignment() || this.ShouldSerializeItemPathPadding() || this.ShouldSerializeItemPathPrefixPercent() || this.ShouldSerializeItemPathRenderBrush() || this.ShouldSerializeItemPathRenderPen() || this.ShouldSerializeItemPathStretch() || this.ShouldSerializeItemPathSuffixPercent() || this.ShouldSerializeItemPathVerticalAlignment() || this.ShouldSerializeItemSize() || this.ShouldSerializeItemsPerPage() || this.ShouldSerializeItemTransitionStyle() || this.ShouldSerializeItemVerticalScrollBarVisibility() || this.ShouldSerializeOpacityEffectStopDirection() || this.ShouldSerializeOpacityEffectStops() || this.ShouldSerializeReserveSpaceForReflections() || this.ShouldSerializeRotateItemsWithPathTangent() || this.ShouldSerializeScalingEffectStopDirection() || this.ShouldSerializeScalingEffectStops() || this.ShouldSerializeShouldAnimateItemsOnListChange() || this.ShouldSerializeShouldScrollItemsIntoInitialPosition() || this.ShouldSerializeSkewAngleXEffectStopDirection() || this.ShouldSerializeSkewAngleXEffectStops() || this.ShouldSerializeSkewAngleYEffectStopDirection() || this.ShouldSerializeSkewAngleYEffectStops() || this.ShouldSerializeUseOpacity() || this.ShouldSerializeUseScaling() || this.ShouldSerializeUseSkewing() || this.ShouldSerializeUseZOrder() || this.ShouldSerializeWidthInInfiniteContainers() || this.ShouldSerializeZOrderEffectStopDirection() || this.ShouldSerializeZOrderEffectStops();
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x0600089A RID: 2202 RVA: 0x0001D00B File Offset: 0x0001B20B
		// (set) Token: 0x0600089B RID: 2203 RVA: 0x0001D01D File Offset: 0x0001B21D
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

		// Token: 0x0600089C RID: 2204 RVA: 0x0001D030 File Offset: 0x0001B230
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeAutoScaleItemContentsToFit()
		{
			return this.AutoScaleItemContentsToFit != (bool)global::Infragistics.Windows.Controls.CarouselViewSettings.AutoScaleItemContentsToFitProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x0600089D RID: 2205 RVA: 0x0001D051 File Offset: 0x0001B251
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetAutoScaleItemContentsToFit()
		{
			base.ClearValue(global::Infragistics.Windows.Controls.CarouselViewSettings.AutoScaleItemContentsToFitProperty);
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x0600089E RID: 2206 RVA: 0x0001D05E File Offset: 0x0001B25E
		// (set) Token: 0x0600089F RID: 2207 RVA: 0x0001D070 File Offset: 0x0001B270
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

		// Token: 0x060008A0 RID: 2208 RVA: 0x0001D07E File Offset: 0x0001B27E
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeCarouselPanelNavigatorStyle()
		{
			return this.CarouselPanelNavigatorStyle != null;
		}

		// Token: 0x060008A1 RID: 2209 RVA: 0x0001D08C File Offset: 0x0001B28C
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetCarouselPanelNavigatorStyle()
		{
			base.ClearValue(global::Infragistics.Windows.Controls.CarouselViewSettings.CarouselPanelNavigatorStyleProperty);
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x060008A2 RID: 2210 RVA: 0x0001D099 File Offset: 0x0001B299
		// (set) Token: 0x060008A3 RID: 2211 RVA: 0x0001D0AB File Offset: 0x0001B2AB
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

		// Token: 0x060008A4 RID: 2212 RVA: 0x0001D0BE File Offset: 0x0001B2BE
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeHeightInInfiniteContainers()
		{
			return this.HeightInInfiniteContainers != (double)global::Infragistics.Windows.Controls.CarouselViewSettings.HeightInInfiniteContainersProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x060008A5 RID: 2213 RVA: 0x0001D0DF File Offset: 0x0001B2DF
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetHeightInInfiniteContainers()
		{
			base.ClearValue(global::Infragistics.Windows.Controls.CarouselViewSettings.HeightInInfiniteContainersProperty);
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x060008A6 RID: 2214 RVA: 0x0001D0EC File Offset: 0x0001B2EC
		// (set) Token: 0x060008A7 RID: 2215 RVA: 0x0001D0FE File Offset: 0x0001B2FE
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

		// Token: 0x060008A8 RID: 2216 RVA: 0x0001D111 File Offset: 0x0001B311
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeIsListContinuous()
		{
			return this.IsListContinuous != (bool)global::Infragistics.Windows.Controls.CarouselViewSettings.IsListContinuousProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x060008A9 RID: 2217 RVA: 0x0001D132 File Offset: 0x0001B332
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetIsListContinuous()
		{
			base.ClearValue(global::Infragistics.Windows.Controls.CarouselViewSettings.IsListContinuousProperty);
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x060008AA RID: 2218 RVA: 0x0001D13F File Offset: 0x0001B33F
		// (set) Token: 0x060008AB RID: 2219 RVA: 0x0001D151 File Offset: 0x0001B351
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

		// Token: 0x060008AC RID: 2220 RVA: 0x0001D164 File Offset: 0x0001B364
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeIsNavigatorVisible()
		{
			return this.IsNavigatorVisible != (bool)global::Infragistics.Windows.Controls.CarouselViewSettings.IsNavigatorVisibleProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x060008AD RID: 2221 RVA: 0x0001D185 File Offset: 0x0001B385
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetIsNavigatorVisible()
		{
			base.ClearValue(global::Infragistics.Windows.Controls.CarouselViewSettings.IsNavigatorVisibleProperty);
		}

		// Token: 0x060008AE RID: 2222 RVA: 0x0001D192 File Offset: 0x0001B392
		private static bool OnValidateItemHorizontalScrollBarVisibility(object value)
		{
			if (!global::System.Enum.IsDefined(typeof(global::System.Windows.Controls.ScrollBarVisibility), value))
			{
				throw new global::System.ComponentModel.InvalidEnumArgumentException("value", (int)value, typeof(global::System.Windows.Controls.ScrollBarVisibility));
			}
			return true;
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x060008AF RID: 2223 RVA: 0x0001D1C2 File Offset: 0x0001B3C2
		// (set) Token: 0x060008B0 RID: 2224 RVA: 0x0001D1D4 File Offset: 0x0001B3D4
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

		// Token: 0x060008B1 RID: 2225 RVA: 0x0001D1E7 File Offset: 0x0001B3E7
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeItemHorizontalScrollBarVisibility()
		{
			return this.ItemHorizontalScrollBarVisibility != (global::System.Windows.Controls.ScrollBarVisibility)global::Infragistics.Windows.Controls.CarouselViewSettings.ItemHorizontalScrollBarVisibilityProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x060008B2 RID: 2226 RVA: 0x0001D208 File Offset: 0x0001B408
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetItemHorizontalScrollBarVisibility()
		{
			base.ClearValue(global::Infragistics.Windows.Controls.CarouselViewSettings.ItemHorizontalScrollBarVisibilityProperty);
		}

		// Token: 0x060008B3 RID: 2227 RVA: 0x0001D215 File Offset: 0x0001B415
		private static bool OnValidateItemVerticalScrollBarVisibility(object value)
		{
			if (!global::System.Enum.IsDefined(typeof(global::System.Windows.Controls.ScrollBarVisibility), value))
			{
				throw new global::System.ComponentModel.InvalidEnumArgumentException("value", (int)value, typeof(global::System.Windows.Controls.ScrollBarVisibility));
			}
			return true;
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x060008B4 RID: 2228 RVA: 0x0001D245 File Offset: 0x0001B445
		// (set) Token: 0x060008B5 RID: 2229 RVA: 0x0001D257 File Offset: 0x0001B457
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

		// Token: 0x060008B6 RID: 2230 RVA: 0x0001D26A File Offset: 0x0001B46A
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeItemVerticalScrollBarVisibility()
		{
			return this.ItemVerticalScrollBarVisibility != (global::System.Windows.Controls.ScrollBarVisibility)global::Infragistics.Windows.Controls.CarouselViewSettings.ItemVerticalScrollBarVisibilityProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x060008B7 RID: 2231 RVA: 0x0001D28B File Offset: 0x0001B48B
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetItemVerticalScrollBarVisibility()
		{
			base.ClearValue(global::Infragistics.Windows.Controls.CarouselViewSettings.ItemVerticalScrollBarVisibilityProperty);
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x060008B8 RID: 2232 RVA: 0x0001D298 File Offset: 0x0001B498
		// (set) Token: 0x060008B9 RID: 2233 RVA: 0x0001D2AA File Offset: 0x0001B4AA
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

		// Token: 0x060008BA RID: 2234 RVA: 0x0001D2B8 File Offset: 0x0001B4B8
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeItemPath()
		{
			return this.ItemPath != (global::System.Windows.Shapes.Shape)global::Infragistics.Windows.Controls.CarouselViewSettings.ItemPathProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x060008BB RID: 2235 RVA: 0x0001D2D9 File Offset: 0x0001B4D9
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetItemPath()
		{
			base.ClearValue(global::Infragistics.Windows.Controls.CarouselViewSettings.ItemPathProperty);
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x060008BC RID: 2236 RVA: 0x0001D2E6 File Offset: 0x0001B4E6
		// (set) Token: 0x060008BD RID: 2237 RVA: 0x0001D2F8 File Offset: 0x0001B4F8
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

		// Token: 0x060008BE RID: 2238 RVA: 0x0001D30B File Offset: 0x0001B50B
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeItemPathAutoPad()
		{
			return this.ItemPathAutoPad != (bool)global::Infragistics.Windows.Controls.CarouselViewSettings.ItemPathAutoPadProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x060008BF RID: 2239 RVA: 0x0001D32C File Offset: 0x0001B52C
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetItemPathAutoPad()
		{
			base.ClearValue(global::Infragistics.Windows.Controls.CarouselViewSettings.ItemPathAutoPadProperty);
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x060008C0 RID: 2240 RVA: 0x0001D339 File Offset: 0x0001B539
		// (set) Token: 0x060008C1 RID: 2241 RVA: 0x0001D34B File Offset: 0x0001B54B
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

		// Token: 0x060008C2 RID: 2242 RVA: 0x0001D35E File Offset: 0x0001B55E
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeItemPathHorizontalAlignment()
		{
			return this.ItemPathHorizontalAlignment != (global::System.Windows.HorizontalAlignment)global::Infragistics.Windows.Controls.CarouselViewSettings.ItemPathHorizontalAlignmentProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x060008C3 RID: 2243 RVA: 0x0001D37F File Offset: 0x0001B57F
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetItemPathHorizontalAlignment()
		{
			base.ClearValue(global::Infragistics.Windows.Controls.CarouselViewSettings.ItemPathHorizontalAlignmentProperty);
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x060008C4 RID: 2244 RVA: 0x0001D38C File Offset: 0x0001B58C
		// (set) Token: 0x060008C5 RID: 2245 RVA: 0x0001D39E File Offset: 0x0001B59E
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

		// Token: 0x060008C6 RID: 2246 RVA: 0x0001D3B1 File Offset: 0x0001B5B1
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeItemPathPadding()
		{
			return this.ItemPathPadding != (global::System.Windows.Thickness)global::Infragistics.Windows.Controls.CarouselViewSettings.ItemPathPaddingProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x060008C7 RID: 2247 RVA: 0x0001D3D2 File Offset: 0x0001B5D2
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetItemPathPadding()
		{
			base.ClearValue(global::Infragistics.Windows.Controls.CarouselViewSettings.ItemPathPaddingProperty);
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x060008C8 RID: 2248 RVA: 0x0001D3DF File Offset: 0x0001B5DF
		// (set) Token: 0x060008C9 RID: 2249 RVA: 0x0001D3F1 File Offset: 0x0001B5F1
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

		// Token: 0x060008CA RID: 2250 RVA: 0x0001D404 File Offset: 0x0001B604
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeItemPathStretch()
		{
			return this.ItemPathStretch != (global::System.Windows.Media.Stretch)global::Infragistics.Windows.Controls.CarouselViewSettings.ItemPathStretchProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x060008CB RID: 2251 RVA: 0x0001D425 File Offset: 0x0001B625
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetItemPathStretch()
		{
			base.ClearValue(global::Infragistics.Windows.Controls.CarouselViewSettings.ItemPathStretchProperty);
		}

		// Token: 0x060008CC RID: 2252 RVA: 0x0001D432 File Offset: 0x0001B632
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

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x060008CD RID: 2253 RVA: 0x0001D46D File Offset: 0x0001B66D
		// (set) Token: 0x060008CE RID: 2254 RVA: 0x0001D47F File Offset: 0x0001B67F
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

		// Token: 0x060008CF RID: 2255 RVA: 0x0001D492 File Offset: 0x0001B692
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeItemPathPrefixPercent()
		{
			return this.ItemPathPrefixPercent != (double)global::Infragistics.Windows.Controls.CarouselViewSettings.ItemPathPrefixPercentProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x060008D0 RID: 2256 RVA: 0x0001D4B3 File Offset: 0x0001B6B3
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetItemPathPrefixPercent()
		{
			base.ClearValue(global::Infragistics.Windows.Controls.CarouselViewSettings.ItemPathPrefixPercentProperty);
		}

		// Token: 0x060008D1 RID: 2257 RVA: 0x0001D4C0 File Offset: 0x0001B6C0
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

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x060008D2 RID: 2258 RVA: 0x0001D4FB File Offset: 0x0001B6FB
		// (set) Token: 0x060008D3 RID: 2259 RVA: 0x0001D50D File Offset: 0x0001B70D
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

		// Token: 0x060008D4 RID: 2260 RVA: 0x0001D520 File Offset: 0x0001B720
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeItemPathSuffixPercent()
		{
			return this.ItemPathSuffixPercent != (double)global::Infragistics.Windows.Controls.CarouselViewSettings.ItemPathSuffixPercentProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x060008D5 RID: 2261 RVA: 0x0001D541 File Offset: 0x0001B741
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetItemPathSuffixPercent()
		{
			base.ClearValue(global::Infragistics.Windows.Controls.CarouselViewSettings.ItemPathSuffixPercentProperty);
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x060008D6 RID: 2262 RVA: 0x0001D54E File Offset: 0x0001B74E
		// (set) Token: 0x060008D7 RID: 2263 RVA: 0x0001D560 File Offset: 0x0001B760
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

		// Token: 0x060008D8 RID: 2264 RVA: 0x0001D56E File Offset: 0x0001B76E
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeItemPathRenderBrush()
		{
			return this.ItemPathRenderBrush != (global::System.Windows.Media.Brush)global::Infragistics.Windows.Controls.CarouselViewSettings.ItemPathRenderBrushProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x060008D9 RID: 2265 RVA: 0x0001D58F File Offset: 0x0001B78F
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetItemPathRenderBrush()
		{
			base.ClearValue(global::Infragistics.Windows.Controls.CarouselViewSettings.ItemPathRenderBrushProperty);
		}

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x060008DA RID: 2266 RVA: 0x0001D59C File Offset: 0x0001B79C
		// (set) Token: 0x060008DB RID: 2267 RVA: 0x0001D5AE File Offset: 0x0001B7AE
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

		// Token: 0x060008DC RID: 2268 RVA: 0x0001D5BC File Offset: 0x0001B7BC
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeItemPathRenderPen()
		{
			return this.ItemPathRenderPen != (global::System.Windows.Media.Pen)global::Infragistics.Windows.Controls.CarouselViewSettings.ItemPathRenderPenProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x060008DD RID: 2269 RVA: 0x0001D5DD File Offset: 0x0001B7DD
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetItemPathRenderPen()
		{
			base.ClearValue(global::Infragistics.Windows.Controls.CarouselViewSettings.ItemPathRenderPenProperty);
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x060008DE RID: 2270 RVA: 0x0001D5EA File Offset: 0x0001B7EA
		// (set) Token: 0x060008DF RID: 2271 RVA: 0x0001D5FC File Offset: 0x0001B7FC
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

		// Token: 0x060008E0 RID: 2272 RVA: 0x0001D60F File Offset: 0x0001B80F
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeItemPathVerticalAlignment()
		{
			return this.ItemPathVerticalAlignment != (global::System.Windows.VerticalAlignment)global::Infragistics.Windows.Controls.CarouselViewSettings.ItemPathVerticalAlignmentProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x060008E1 RID: 2273 RVA: 0x0001D630 File Offset: 0x0001B830
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetItemPathVerticalAlignment()
		{
			base.ClearValue(global::Infragistics.Windows.Controls.CarouselViewSettings.ItemPathVerticalAlignmentProperty);
		}

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x060008E2 RID: 2274 RVA: 0x0001D63D File Offset: 0x0001B83D
		// (set) Token: 0x060008E3 RID: 2275 RVA: 0x0001D64F File Offset: 0x0001B84F
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

		// Token: 0x060008E4 RID: 2276 RVA: 0x0001D662 File Offset: 0x0001B862
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeItemSize()
		{
			return this.ItemSize != (global::System.Windows.Size)global::Infragistics.Windows.Controls.CarouselViewSettings.ItemSizeProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x060008E5 RID: 2277 RVA: 0x0001D683 File Offset: 0x0001B883
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetItemSize()
		{
			base.ClearValue(global::Infragistics.Windows.Controls.CarouselViewSettings.ItemSizeProperty);
		}

		// Token: 0x060008E6 RID: 2278 RVA: 0x0001D690 File Offset: 0x0001B890
		private static object OnCoerceItemsPerPage(global::System.Windows.DependencyObject d, object value)
		{
			if ((int)value < 1)
			{
				return 1;
			}
			return value;
		}

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x060008E7 RID: 2279 RVA: 0x0001D6A3 File Offset: 0x0001B8A3
		// (set) Token: 0x060008E8 RID: 2280 RVA: 0x0001D6B5 File Offset: 0x0001B8B5
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

		// Token: 0x060008E9 RID: 2281 RVA: 0x0001D6C8 File Offset: 0x0001B8C8
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeItemsPerPage()
		{
			return this.ItemsPerPage != (int)global::Infragistics.Windows.Controls.CarouselViewSettings.ItemsPerPageProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x060008EA RID: 2282 RVA: 0x0001D6E9 File Offset: 0x0001B8E9
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetItemsPerPage()
		{
			base.ClearValue(global::Infragistics.Windows.Controls.CarouselViewSettings.ItemsPerPageProperty);
		}

		// Token: 0x060008EB RID: 2283 RVA: 0x0001D6F6 File Offset: 0x0001B8F6
		private static bool OnValidateItemTransitionStyle(object value)
		{
			if (!global::System.Enum.IsDefined(typeof(global::Infragistics.Windows.Controls.PathItemTransitionStyle), value))
			{
				throw new global::System.ComponentModel.InvalidEnumArgumentException("value", (int)value, typeof(global::Infragistics.Windows.Controls.PathItemTransitionStyle));
			}
			return true;
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x060008EC RID: 2284 RVA: 0x0001D726 File Offset: 0x0001B926
		// (set) Token: 0x060008ED RID: 2285 RVA: 0x0001D738 File Offset: 0x0001B938
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

		// Token: 0x060008EE RID: 2286 RVA: 0x0001D74B File Offset: 0x0001B94B
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeItemTransitionStyle()
		{
			return this.ItemTransitionStyle != (global::Infragistics.Windows.Controls.PathItemTransitionStyle)global::Infragistics.Windows.Controls.CarouselViewSettings.ItemTransitionStyleProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x060008EF RID: 2287 RVA: 0x0001D76C File Offset: 0x0001B96C
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetItemTransitionStyle()
		{
			base.ClearValue(global::Infragistics.Windows.Controls.CarouselViewSettings.ItemTransitionStyleProperty);
		}

		// Token: 0x060008F0 RID: 2288 RVA: 0x0001D77C File Offset: 0x0001B97C
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

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x060008F1 RID: 2289 RVA: 0x0001D7E9 File Offset: 0x0001B9E9
		// (set) Token: 0x060008F2 RID: 2290 RVA: 0x0001D7FB File Offset: 0x0001B9FB
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

		// Token: 0x060008F3 RID: 2291 RVA: 0x0001D809 File Offset: 0x0001BA09
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeOpacityEffectStops()
		{
			return this.OpacityEffectStops.ShouldSerialize();
		}

		// Token: 0x060008F4 RID: 2292 RVA: 0x0001D816 File Offset: 0x0001BA16
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetOpacityEffectStops()
		{
			this.OpacityEffectStops.Clear();
		}

		// Token: 0x060008F5 RID: 2293 RVA: 0x0001D823 File Offset: 0x0001BA23
		private static bool OnValidateOpacityEffectStopDirection(object value)
		{
			if (!global::System.Enum.IsDefined(typeof(global::Infragistics.Windows.Controls.EffectStopDirection), value))
			{
				throw new global::System.ComponentModel.InvalidEnumArgumentException("value", (int)value, typeof(global::Infragistics.Windows.Controls.EffectStopDirection));
			}
			return true;
		}

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x060008F6 RID: 2294 RVA: 0x0001D853 File Offset: 0x0001BA53
		// (set) Token: 0x060008F7 RID: 2295 RVA: 0x0001D865 File Offset: 0x0001BA65
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

		// Token: 0x060008F8 RID: 2296 RVA: 0x0001D878 File Offset: 0x0001BA78
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeOpacityEffectStopDirection()
		{
			return this.OpacityEffectStopDirection != (global::Infragistics.Windows.Controls.EffectStopDirection)global::Infragistics.Windows.Controls.CarouselViewSettings.OpacityEffectStopDirectionProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x060008F9 RID: 2297 RVA: 0x0001D899 File Offset: 0x0001BA99
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetOpacityEffectStopDirection()
		{
			base.ClearValue(global::Infragistics.Windows.Controls.CarouselViewSettings.OpacityEffectStopDirectionProperty);
		}

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x060008FA RID: 2298 RVA: 0x0001D8A6 File Offset: 0x0001BAA6
		// (set) Token: 0x060008FB RID: 2299 RVA: 0x0001D8B8 File Offset: 0x0001BAB8
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

		// Token: 0x060008FC RID: 2300 RVA: 0x0001D8CB File Offset: 0x0001BACB
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeReserveSpaceForReflections()
		{
			return this.ReserveSpaceForReflections != (bool)global::Infragistics.Windows.Controls.CarouselViewSettings.ReserveSpaceForReflectionsProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x060008FD RID: 2301 RVA: 0x0001D8EC File Offset: 0x0001BAEC
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetReserveSpaceForReflections()
		{
			base.ClearValue(global::Infragistics.Windows.Controls.CarouselViewSettings.ReserveSpaceForReflectionsProperty);
		}

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x060008FE RID: 2302 RVA: 0x0001D8F9 File Offset: 0x0001BAF9
		// (set) Token: 0x060008FF RID: 2303 RVA: 0x0001D90B File Offset: 0x0001BB0B
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

		// Token: 0x06000900 RID: 2304 RVA: 0x0001D91E File Offset: 0x0001BB1E
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeRotateItemsWithPathTangent()
		{
			return this.RotateItemsWithPathTangent != (bool)global::Infragistics.Windows.Controls.CarouselViewSettings.RotateItemsWithPathTangentProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x06000901 RID: 2305 RVA: 0x0001D93F File Offset: 0x0001BB3F
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetRotateItemsWithPathTangent()
		{
			base.ClearValue(global::Infragistics.Windows.Controls.CarouselViewSettings.RotateItemsWithPathTangentProperty);
		}

		// Token: 0x06000902 RID: 2306 RVA: 0x0001D94C File Offset: 0x0001BB4C
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

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x06000903 RID: 2307 RVA: 0x0001D9B9 File Offset: 0x0001BBB9
		// (set) Token: 0x06000904 RID: 2308 RVA: 0x0001D9CB File Offset: 0x0001BBCB
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

		// Token: 0x06000905 RID: 2309 RVA: 0x0001D9D9 File Offset: 0x0001BBD9
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeScalingEffectStops()
		{
			return this.ScalingEffectStops.ShouldSerialize();
		}

		// Token: 0x06000906 RID: 2310 RVA: 0x0001D9E6 File Offset: 0x0001BBE6
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetScalingEffectStops()
		{
			this.ScalingEffectStops.Clear();
		}

		// Token: 0x06000907 RID: 2311 RVA: 0x0001D9F3 File Offset: 0x0001BBF3
		private static bool OnValidateScalingEffectStopDirection(object value)
		{
			if (!global::System.Enum.IsDefined(typeof(global::Infragistics.Windows.Controls.EffectStopDirection), value))
			{
				throw new global::System.ComponentModel.InvalidEnumArgumentException("value", (int)value, typeof(global::Infragistics.Windows.Controls.EffectStopDirection));
			}
			return true;
		}

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x06000908 RID: 2312 RVA: 0x0001DA23 File Offset: 0x0001BC23
		// (set) Token: 0x06000909 RID: 2313 RVA: 0x0001DA35 File Offset: 0x0001BC35
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

		// Token: 0x0600090A RID: 2314 RVA: 0x0001DA48 File Offset: 0x0001BC48
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeScalingEffectStopDirection()
		{
			return this.ScalingEffectStopDirection != (global::Infragistics.Windows.Controls.EffectStopDirection)global::Infragistics.Windows.Controls.CarouselViewSettings.ScalingEffectStopDirectionProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x0600090B RID: 2315 RVA: 0x0001DA69 File Offset: 0x0001BC69
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetScalingEffectStopDirection()
		{
			base.ClearValue(global::Infragistics.Windows.Controls.CarouselViewSettings.ScalingEffectStopDirectionProperty);
		}

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x0600090C RID: 2316 RVA: 0x0001DA76 File Offset: 0x0001BC76
		// (set) Token: 0x0600090D RID: 2317 RVA: 0x0001DA88 File Offset: 0x0001BC88
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

		// Token: 0x0600090E RID: 2318 RVA: 0x0001DA9B File Offset: 0x0001BC9B
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeShouldAnimateItemsOnListChange()
		{
			return this.ShouldAnimateItemsOnListChange != (bool)global::Infragistics.Windows.Controls.CarouselViewSettings.ShouldAnimateItemsOnListChangeProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x0600090F RID: 2319 RVA: 0x0001DABC File Offset: 0x0001BCBC
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetShouldAnimateItemsOnListChange()
		{
			base.ClearValue(global::Infragistics.Windows.Controls.CarouselViewSettings.ShouldAnimateItemsOnListChangeProperty);
		}

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x06000910 RID: 2320 RVA: 0x0001DAC9 File Offset: 0x0001BCC9
		// (set) Token: 0x06000911 RID: 2321 RVA: 0x0001DADB File Offset: 0x0001BCDB
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

		// Token: 0x06000912 RID: 2322 RVA: 0x0001DAEE File Offset: 0x0001BCEE
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeShouldScrollItemsIntoInitialPosition()
		{
			return this.ShouldScrollItemsIntoInitialPosition != (bool)global::Infragistics.Windows.Controls.CarouselViewSettings.ShouldScrollItemsIntoInitialPositionProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x06000913 RID: 2323 RVA: 0x0001DB0F File Offset: 0x0001BD0F
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetShouldScrollItemsIntoInitialPosition()
		{
			base.ClearValue(global::Infragistics.Windows.Controls.CarouselViewSettings.ShouldScrollItemsIntoInitialPositionProperty);
		}

		// Token: 0x06000914 RID: 2324 RVA: 0x0001DB1C File Offset: 0x0001BD1C
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

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x06000915 RID: 2325 RVA: 0x0001DB89 File Offset: 0x0001BD89
		// (set) Token: 0x06000916 RID: 2326 RVA: 0x0001DB9B File Offset: 0x0001BD9B
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

		// Token: 0x06000917 RID: 2327 RVA: 0x0001DBA9 File Offset: 0x0001BDA9
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeSkewAngleXEffectStops()
		{
			return this.SkewAngleXEffectStops.ShouldSerialize();
		}

		// Token: 0x06000918 RID: 2328 RVA: 0x0001DBB6 File Offset: 0x0001BDB6
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetSkewAngleXEffectStops()
		{
			this.SkewAngleXEffectStops.Clear();
		}

		// Token: 0x06000919 RID: 2329 RVA: 0x0001DBC3 File Offset: 0x0001BDC3
		private static bool OnValidateSkewAngleXEffectStopDirection(object value)
		{
			if (!global::System.Enum.IsDefined(typeof(global::Infragistics.Windows.Controls.EffectStopDirection), value))
			{
				throw new global::System.ComponentModel.InvalidEnumArgumentException("value", (int)value, typeof(global::Infragistics.Windows.Controls.EffectStopDirection));
			}
			return true;
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x0600091A RID: 2330 RVA: 0x0001DBF3 File Offset: 0x0001BDF3
		// (set) Token: 0x0600091B RID: 2331 RVA: 0x0001DC05 File Offset: 0x0001BE05
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

		// Token: 0x0600091C RID: 2332 RVA: 0x0001DC18 File Offset: 0x0001BE18
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeSkewAngleXEffectStopDirection()
		{
			return this.SkewAngleXEffectStopDirection != (global::Infragistics.Windows.Controls.EffectStopDirection)global::Infragistics.Windows.Controls.CarouselViewSettings.SkewAngleXEffectStopDirectionProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x0600091D RID: 2333 RVA: 0x0001DC39 File Offset: 0x0001BE39
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetSkewAngleXEffectStopDirection()
		{
			base.ClearValue(global::Infragistics.Windows.Controls.CarouselViewSettings.SkewAngleXEffectStopDirectionProperty);
		}

		// Token: 0x0600091E RID: 2334 RVA: 0x0001DC48 File Offset: 0x0001BE48
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

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x0600091F RID: 2335 RVA: 0x0001DCB5 File Offset: 0x0001BEB5
		// (set) Token: 0x06000920 RID: 2336 RVA: 0x0001DCC7 File Offset: 0x0001BEC7
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

		// Token: 0x06000921 RID: 2337 RVA: 0x0001DCD5 File Offset: 0x0001BED5
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeSkewAngleYEffectStops()
		{
			return this.SkewAngleYEffectStops.ShouldSerialize();
		}

		// Token: 0x06000922 RID: 2338 RVA: 0x0001DCE2 File Offset: 0x0001BEE2
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetSkewAngleYEffectStops()
		{
			this.SkewAngleYEffectStops.Clear();
		}

		// Token: 0x06000923 RID: 2339 RVA: 0x0001DCEF File Offset: 0x0001BEEF
		private static bool OnValidateSkewAngleYEffectStopDirection(object value)
		{
			if (!global::System.Enum.IsDefined(typeof(global::Infragistics.Windows.Controls.EffectStopDirection), value))
			{
				throw new global::System.ComponentModel.InvalidEnumArgumentException("value", (int)value, typeof(global::Infragistics.Windows.Controls.EffectStopDirection));
			}
			return true;
		}

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x06000924 RID: 2340 RVA: 0x0001DD1F File Offset: 0x0001BF1F
		// (set) Token: 0x06000925 RID: 2341 RVA: 0x0001DD31 File Offset: 0x0001BF31
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

		// Token: 0x06000926 RID: 2342 RVA: 0x0001DD44 File Offset: 0x0001BF44
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeSkewAngleYEffectStopDirection()
		{
			return this.SkewAngleYEffectStopDirection != (global::Infragistics.Windows.Controls.EffectStopDirection)global::Infragistics.Windows.Controls.CarouselViewSettings.SkewAngleYEffectStopDirectionProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x06000927 RID: 2343 RVA: 0x0001DD65 File Offset: 0x0001BF65
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetSkewAngleYEffectStopDirection()
		{
			base.ClearValue(global::Infragistics.Windows.Controls.CarouselViewSettings.SkewAngleYEffectStopDirectionProperty);
		}

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x06000928 RID: 2344 RVA: 0x0001DD72 File Offset: 0x0001BF72
		// (set) Token: 0x06000929 RID: 2345 RVA: 0x0001DD84 File Offset: 0x0001BF84
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

		// Token: 0x0600092A RID: 2346 RVA: 0x0001DD97 File Offset: 0x0001BF97
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeUseOpacity()
		{
			return this.UseOpacity != (bool)global::Infragistics.Windows.Controls.CarouselViewSettings.UseOpacityProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x0600092B RID: 2347 RVA: 0x0001DDB8 File Offset: 0x0001BFB8
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetUseOpacity()
		{
			base.ClearValue(global::Infragistics.Windows.Controls.CarouselViewSettings.UseOpacityProperty);
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x0600092C RID: 2348 RVA: 0x0001DDC5 File Offset: 0x0001BFC5
		// (set) Token: 0x0600092D RID: 2349 RVA: 0x0001DDD7 File Offset: 0x0001BFD7
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

		// Token: 0x0600092E RID: 2350 RVA: 0x0001DDEA File Offset: 0x0001BFEA
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeUseScaling()
		{
			return this.UseScaling != (bool)global::Infragistics.Windows.Controls.CarouselViewSettings.UseScalingProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x0600092F RID: 2351 RVA: 0x0001DE0B File Offset: 0x0001C00B
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetUseScaling()
		{
			base.ClearValue(global::Infragistics.Windows.Controls.CarouselViewSettings.UseScalingProperty);
		}

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x06000930 RID: 2352 RVA: 0x0001DE18 File Offset: 0x0001C018
		// (set) Token: 0x06000931 RID: 2353 RVA: 0x0001DE2A File Offset: 0x0001C02A
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

		// Token: 0x06000932 RID: 2354 RVA: 0x0001DE3D File Offset: 0x0001C03D
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeUseSkewing()
		{
			return this.UseSkewing != (bool)global::Infragistics.Windows.Controls.CarouselViewSettings.UseSkewingProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x06000933 RID: 2355 RVA: 0x0001DE5E File Offset: 0x0001C05E
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetUseSkewing()
		{
			base.ClearValue(global::Infragistics.Windows.Controls.CarouselViewSettings.UseSkewingProperty);
		}

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x06000934 RID: 2356 RVA: 0x0001DE6B File Offset: 0x0001C06B
		// (set) Token: 0x06000935 RID: 2357 RVA: 0x0001DE7D File Offset: 0x0001C07D
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

		// Token: 0x06000936 RID: 2358 RVA: 0x0001DE90 File Offset: 0x0001C090
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeUseZOrder()
		{
			return this.UseZOrder != (bool)global::Infragistics.Windows.Controls.CarouselViewSettings.UseZOrderProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x06000937 RID: 2359 RVA: 0x0001DEB1 File Offset: 0x0001C0B1
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetUseZOrder()
		{
			base.ClearValue(global::Infragistics.Windows.Controls.CarouselViewSettings.UseZOrderProperty);
		}

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x06000938 RID: 2360 RVA: 0x0001DEBE File Offset: 0x0001C0BE
		// (set) Token: 0x06000939 RID: 2361 RVA: 0x0001DED0 File Offset: 0x0001C0D0
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

		// Token: 0x0600093A RID: 2362 RVA: 0x0001DEE3 File Offset: 0x0001C0E3
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeWidthInInfiniteContainers()
		{
			return this.WidthInInfiniteContainers != (double)global::Infragistics.Windows.Controls.CarouselViewSettings.WidthInInfiniteContainersProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x0600093B RID: 2363 RVA: 0x0001DF04 File Offset: 0x0001C104
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetWidthInInfiniteContainers()
		{
			base.ClearValue(global::Infragistics.Windows.Controls.CarouselViewSettings.WidthInInfiniteContainersProperty);
		}

		// Token: 0x0600093C RID: 2364 RVA: 0x0001DF14 File Offset: 0x0001C114
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

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x0600093D RID: 2365 RVA: 0x0001DF81 File Offset: 0x0001C181
		// (set) Token: 0x0600093E RID: 2366 RVA: 0x0001DF93 File Offset: 0x0001C193
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

		// Token: 0x0600093F RID: 2367 RVA: 0x0001DFA1 File Offset: 0x0001C1A1
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeZOrderEffectStops()
		{
			return this.ZOrderEffectStops.ShouldSerialize();
		}

		// Token: 0x06000940 RID: 2368 RVA: 0x0001DFAE File Offset: 0x0001C1AE
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetZOrderEffectStops()
		{
			this.ZOrderEffectStops.Clear();
		}

		// Token: 0x06000941 RID: 2369 RVA: 0x0001DFBB File Offset: 0x0001C1BB
		private static bool OnValidateZOrderEffectStopDirection(object value)
		{
			if (!global::System.Enum.IsDefined(typeof(global::Infragistics.Windows.Controls.EffectStopDirection), value))
			{
				throw new global::System.ComponentModel.InvalidEnumArgumentException("value", (int)value, typeof(global::Infragistics.Windows.Controls.EffectStopDirection));
			}
			return true;
		}

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x06000942 RID: 2370 RVA: 0x0001DFEB File Offset: 0x0001C1EB
		// (set) Token: 0x06000943 RID: 2371 RVA: 0x0001DFFD File Offset: 0x0001C1FD
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

		// Token: 0x06000944 RID: 2372 RVA: 0x0001E010 File Offset: 0x0001C210
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeZOrderEffectStopDirection()
		{
			return this.ZOrderEffectStopDirection != (global::Infragistics.Windows.Controls.EffectStopDirection)global::Infragistics.Windows.Controls.CarouselViewSettings.ZOrderEffectStopDirectionProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x06000945 RID: 2373 RVA: 0x0001E031 File Offset: 0x0001C231
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetZOrderEffectStopDirection()
		{
			base.ClearValue(global::Infragistics.Windows.Controls.CarouselViewSettings.ZOrderEffectStopDirectionProperty);
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x06000946 RID: 2374 RVA: 0x0001E03E File Offset: 0x0001C23E
		internal int Version
		{
			get
			{
				return (int)base.GetValue(global::Infragistics.Windows.Controls.CarouselViewSettings.VersionProperty);
			}
		}

		// Token: 0x06000947 RID: 2375 RVA: 0x0001E050 File Offset: 0x0001C250
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

		// Token: 0x06000948 RID: 2376 RVA: 0x0001E0AE File Offset: 0x0001C2AE
		private void OnOpacityEffectStopsCollectionChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			base.RaisePropertyChangedEvent("OpacityEffectStops");
		}

		// Token: 0x06000949 RID: 2377 RVA: 0x0001E0BB File Offset: 0x0001C2BB
		private void OnScalingEffectStopsCollectionChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			base.RaisePropertyChangedEvent("ScalingEffectStops");
		}

		// Token: 0x0600094A RID: 2378 RVA: 0x0001E0C8 File Offset: 0x0001C2C8
		private void OnSkewAngleXEffectStopsCollectionChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			base.RaisePropertyChangedEvent("SkewAngleXEffectStops");
		}

		// Token: 0x0600094B RID: 2379 RVA: 0x0001E0D5 File Offset: 0x0001C2D5
		private void OnSkewAngleYEffectStopsCollectionChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			base.RaisePropertyChangedEvent("SkewAngleYEffectStops");
		}

		// Token: 0x0600094C RID: 2380 RVA: 0x0001E0E2 File Offset: 0x0001C2E2
		private void OnZOrderEffectStopsCollectionChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			base.RaisePropertyChangedEvent("ZOrderEffectStops");
		}

		// Token: 0x0600094D RID: 2381 RVA: 0x0001E0EF File Offset: 0x0001C2EF
		private static bool ValidatePositiveDouble(object value)
		{
			return value is double && !double.IsNaN((double)value) && (double)value > 0.0;
		}

		// Token: 0x0400039B RID: 923
		internal const int DEFAULT_ITEMS_PER_PAGE = 5;

		// Token: 0x0400039C RID: 924
		private const double DEFAULT_PATH_PREFIX_PCT = 0.15;

		// Token: 0x0400039D RID: 925
		private const double DEFAULT_PATH_SUFFIX_PCT = 0.15;

		// Token: 0x0400039E RID: 926
		private const double DEFAULT_WIDTH_IN_INFINITE_CONTAINERS = 400.0;

		// Token: 0x0400039F RID: 927
		private const double DEFAULT_HEIGHT_IN_INFINITE_CONTAINERS = 300.0;

		// Token: 0x040003A0 RID: 928
		private static readonly global::System.Windows.Size DEFAULT_ITEM_SIZE = new global::System.Windows.Size(150.0, 100.0);

		// Token: 0x040003A1 RID: 929
		public static readonly global::System.Windows.DependencyProperty AutoScaleItemContentsToFitProperty = global::System.Windows.DependencyProperty.Register("AutoScaleItemContentsToFit", typeof(bool), typeof(global::Infragistics.Windows.Controls.CarouselViewSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x040003A2 RID: 930
		public static readonly global::System.Windows.DependencyProperty CarouselPanelNavigatorStyleProperty = global::System.Windows.DependencyProperty.Register("CarouselPanelNavigatorStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Windows.Controls.CarouselViewSettings), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x040003A3 RID: 931
		public static readonly global::System.Windows.DependencyProperty HeightInInfiniteContainersProperty = global::System.Windows.DependencyProperty.Register("HeightInInfiniteContainers", typeof(double), typeof(global::Infragistics.Windows.Controls.CarouselViewSettings), new global::System.Windows.FrameworkPropertyMetadata(300.0), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.Controls.CarouselViewSettings.ValidatePositiveDouble));

		// Token: 0x040003A4 RID: 932
		public static readonly global::System.Windows.DependencyProperty IsListContinuousProperty = global::System.Windows.DependencyProperty.Register("IsListContinuous", typeof(bool), typeof(global::Infragistics.Windows.Controls.CarouselViewSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x040003A5 RID: 933
		public static readonly global::System.Windows.DependencyProperty IsNavigatorVisibleProperty = global::System.Windows.DependencyProperty.Register("IsNavigatorVisible", typeof(bool), typeof(global::Infragistics.Windows.Controls.CarouselViewSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.TrueBox));

		// Token: 0x040003A6 RID: 934
		public static readonly global::System.Windows.DependencyProperty ItemHorizontalScrollBarVisibilityProperty = global::System.Windows.DependencyProperty.Register("ItemHorizontalScrollBarVisibility", typeof(global::System.Windows.Controls.ScrollBarVisibility), typeof(global::Infragistics.Windows.Controls.CarouselViewSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.ScrollBarVisibilityAutoBox), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.Controls.CarouselViewSettings.OnValidateItemHorizontalScrollBarVisibility));

		// Token: 0x040003A7 RID: 935
		public static readonly global::System.Windows.DependencyProperty ItemVerticalScrollBarVisibilityProperty = global::System.Windows.DependencyProperty.Register("ItemVerticalScrollBarVisibility", typeof(global::System.Windows.Controls.ScrollBarVisibility), typeof(global::Infragistics.Windows.Controls.CarouselViewSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.ScrollBarVisibilityAutoBox), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.Controls.CarouselViewSettings.OnValidateItemVerticalScrollBarVisibility));

		// Token: 0x040003A8 RID: 936
		public static readonly global::System.Windows.DependencyProperty ItemPathProperty = global::System.Windows.DependencyProperty.Register("ItemPath", typeof(global::System.Windows.Shapes.Shape), typeof(global::Infragistics.Windows.Controls.CarouselViewSettings), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x040003A9 RID: 937
		public static readonly global::System.Windows.DependencyProperty ItemPathAutoPadProperty = global::System.Windows.DependencyProperty.Register("ItemPathAutoPad", typeof(bool), typeof(global::Infragistics.Windows.Controls.CarouselViewSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.TrueBox));

		// Token: 0x040003AA RID: 938
		public static readonly global::System.Windows.DependencyProperty ItemPathHorizontalAlignmentProperty = global::System.Windows.DependencyProperty.Register("ItemPathHorizontalAlignment", typeof(global::System.Windows.HorizontalAlignment), typeof(global::Infragistics.Windows.Controls.CarouselViewSettings), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.HorizontalAlignment.Center));

		// Token: 0x040003AB RID: 939
		public static readonly global::System.Windows.DependencyProperty ItemPathPaddingProperty = global::System.Windows.DependencyProperty.Register("ItemPathPadding", typeof(global::System.Windows.Thickness), typeof(global::Infragistics.Windows.Controls.CarouselViewSettings), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.Thickness(0.0)));

		// Token: 0x040003AC RID: 940
		public static readonly global::System.Windows.DependencyProperty ItemPathStretchProperty = global::System.Windows.DependencyProperty.Register("ItemPathStretch", typeof(global::System.Windows.Media.Stretch), typeof(global::Infragistics.Windows.Controls.CarouselViewSettings), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Media.Stretch.Fill));

		// Token: 0x040003AD RID: 941
		public static readonly global::System.Windows.DependencyProperty ItemPathPrefixPercentProperty = global::System.Windows.DependencyProperty.Register("ItemPathPrefixPercent", typeof(double), typeof(global::Infragistics.Windows.Controls.CarouselViewSettings), new global::System.Windows.FrameworkPropertyMetadata(0.15, null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.Controls.CarouselViewSettings.OnCoerceItemPathPrefixPercent)));

		// Token: 0x040003AE RID: 942
		public static readonly global::System.Windows.DependencyProperty ItemPathSuffixPercentProperty = global::System.Windows.DependencyProperty.Register("ItemPathSuffixPercent", typeof(double), typeof(global::Infragistics.Windows.Controls.CarouselViewSettings), new global::System.Windows.FrameworkPropertyMetadata(0.15, null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.Controls.CarouselViewSettings.OnCoerceItemPathSuffixPercent)));

		// Token: 0x040003AF RID: 943
		public static readonly global::System.Windows.DependencyProperty ItemPathRenderBrushProperty = global::System.Windows.DependencyProperty.Register("ItemPathRenderBrush", typeof(global::System.Windows.Media.Brush), typeof(global::Infragistics.Windows.Controls.CarouselViewSettings), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x040003B0 RID: 944
		public static readonly global::System.Windows.DependencyProperty ItemPathRenderPenProperty = global::System.Windows.DependencyProperty.Register("ItemPathRenderPen", typeof(global::System.Windows.Media.Pen), typeof(global::Infragistics.Windows.Controls.CarouselViewSettings), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x040003B1 RID: 945
		public static readonly global::System.Windows.DependencyProperty ItemPathVerticalAlignmentProperty = global::System.Windows.DependencyProperty.Register("ItemPathVerticalAlignment", typeof(global::System.Windows.VerticalAlignment), typeof(global::Infragistics.Windows.Controls.CarouselViewSettings), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.VerticalAlignment.Center));

		// Token: 0x040003B2 RID: 946
		public static readonly global::System.Windows.DependencyProperty ItemSizeProperty = global::System.Windows.DependencyProperty.Register("ItemSize", typeof(global::System.Windows.Size), typeof(global::Infragistics.Windows.Controls.CarouselViewSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.Controls.CarouselViewSettings.DEFAULT_ITEM_SIZE));

		// Token: 0x040003B3 RID: 947
		public static readonly global::System.Windows.DependencyProperty ItemsPerPageProperty = global::System.Windows.DependencyProperty.Register("ItemsPerPage", typeof(int), typeof(global::Infragistics.Windows.Controls.CarouselViewSettings), new global::System.Windows.FrameworkPropertyMetadata(5, null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.Controls.CarouselViewSettings.OnCoerceItemsPerPage)));

		// Token: 0x040003B4 RID: 948
		public static readonly global::System.Windows.DependencyProperty ItemTransitionStyleProperty = global::System.Windows.DependencyProperty.Register("ItemTransitionStyle", typeof(global::Infragistics.Windows.Controls.PathItemTransitionStyle), typeof(global::Infragistics.Windows.Controls.CarouselViewSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.Controls.PathItemTransitionStyle.AdjustOpacity), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.Controls.CarouselViewSettings.OnValidateItemTransitionStyle));

		// Token: 0x040003B5 RID: 949
		public static readonly global::System.Windows.DependencyProperty OpacityEffectStopsProperty = global::System.Windows.DependencyProperty.Register("OpacityEffectStops", typeof(global::Infragistics.Windows.Controls.OpacityEffectStopCollection), typeof(global::Infragistics.Windows.Controls.CarouselViewSettings), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.CarouselViewSettings.OnOpacityEffectsChanged)));

		// Token: 0x040003B6 RID: 950
		public static readonly global::System.Windows.DependencyProperty OpacityEffectStopDirectionProperty = global::System.Windows.DependencyProperty.Register("OpacityEffectStopDirection", typeof(global::Infragistics.Windows.Controls.EffectStopDirection), typeof(global::Infragistics.Windows.Controls.CarouselViewSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.Controls.EffectStopDirection.Default), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.Controls.CarouselViewSettings.OnValidateOpacityEffectStopDirection));

		// Token: 0x040003B7 RID: 951
		public static readonly global::System.Windows.DependencyProperty ReserveSpaceForReflectionsProperty = global::System.Windows.DependencyProperty.Register("ReserveSpaceForReflections", typeof(bool), typeof(global::Infragistics.Windows.Controls.CarouselViewSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.TrueBox));

		// Token: 0x040003B8 RID: 952
		public static readonly global::System.Windows.DependencyProperty RotateItemsWithPathTangentProperty = global::System.Windows.DependencyProperty.Register("RotateItemsWithPathTangent", typeof(bool), typeof(global::Infragistics.Windows.Controls.CarouselViewSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x040003B9 RID: 953
		public static readonly global::System.Windows.DependencyProperty ScalingEffectStopsProperty = global::System.Windows.DependencyProperty.Register("ScalingEffectStops", typeof(global::Infragistics.Windows.Controls.ScalingEffectStopCollection), typeof(global::Infragistics.Windows.Controls.CarouselViewSettings), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.CarouselViewSettings.OnScalingEffectsChanged)));

		// Token: 0x040003BA RID: 954
		public static readonly global::System.Windows.DependencyProperty ScalingEffectStopDirectionProperty = global::System.Windows.DependencyProperty.Register("ScalingEffectStopDirection", typeof(global::Infragistics.Windows.Controls.EffectStopDirection), typeof(global::Infragistics.Windows.Controls.CarouselViewSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.Controls.EffectStopDirection.Default), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.Controls.CarouselViewSettings.OnValidateScalingEffectStopDirection));

		// Token: 0x040003BB RID: 955
		public static readonly global::System.Windows.DependencyProperty ShouldAnimateItemsOnListChangeProperty = global::System.Windows.DependencyProperty.Register("ShouldAnimateItemsOnListChange", typeof(bool), typeof(global::Infragistics.Windows.Controls.CarouselViewSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x040003BC RID: 956
		public static readonly global::System.Windows.DependencyProperty ShouldScrollItemsIntoInitialPositionProperty = global::System.Windows.DependencyProperty.Register("ShouldScrollItemsIntoInitialPosition", typeof(bool), typeof(global::Infragistics.Windows.Controls.CarouselViewSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.TrueBox));

		// Token: 0x040003BD RID: 957
		public static readonly global::System.Windows.DependencyProperty SkewAngleXEffectStopsProperty = global::System.Windows.DependencyProperty.Register("SkewAngleXEffectStops", typeof(global::Infragistics.Windows.Controls.SkewAngleXEffectStopCollection), typeof(global::Infragistics.Windows.Controls.CarouselViewSettings), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.CarouselViewSettings.OnSkewAngleXEffectsChanged)));

		// Token: 0x040003BE RID: 958
		public static readonly global::System.Windows.DependencyProperty SkewAngleXEffectStopDirectionProperty = global::System.Windows.DependencyProperty.Register("SkewAngleXEffectStopDirection", typeof(global::Infragistics.Windows.Controls.EffectStopDirection), typeof(global::Infragistics.Windows.Controls.CarouselViewSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.Controls.EffectStopDirection.Default), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.Controls.CarouselViewSettings.OnValidateSkewAngleXEffectStopDirection));

		// Token: 0x040003BF RID: 959
		public static readonly global::System.Windows.DependencyProperty SkewAngleYEffectStopsProperty = global::System.Windows.DependencyProperty.Register("SkewAngleYEffectStops", typeof(global::Infragistics.Windows.Controls.SkewAngleYEffectStopCollection), typeof(global::Infragistics.Windows.Controls.CarouselViewSettings), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.CarouselViewSettings.OnSkewAngleYEffectsChanged)));

		// Token: 0x040003C0 RID: 960
		public static readonly global::System.Windows.DependencyProperty SkewAngleYEffectStopDirectionProperty = global::System.Windows.DependencyProperty.Register("SkewAngleYEffectStopDirection", typeof(global::Infragistics.Windows.Controls.EffectStopDirection), typeof(global::Infragistics.Windows.Controls.CarouselViewSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.Controls.EffectStopDirection.Default), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.Controls.CarouselViewSettings.OnValidateSkewAngleYEffectStopDirection));

		// Token: 0x040003C1 RID: 961
		public static readonly global::System.Windows.DependencyProperty UseOpacityProperty = global::System.Windows.DependencyProperty.Register("UseOpacity", typeof(bool), typeof(global::Infragistics.Windows.Controls.CarouselViewSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x040003C2 RID: 962
		public static readonly global::System.Windows.DependencyProperty UseScalingProperty = global::System.Windows.DependencyProperty.Register("UseScaling", typeof(bool), typeof(global::Infragistics.Windows.Controls.CarouselViewSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.TrueBox));

		// Token: 0x040003C3 RID: 963
		public static readonly global::System.Windows.DependencyProperty UseSkewingProperty = global::System.Windows.DependencyProperty.Register("UseSkewing", typeof(bool), typeof(global::Infragistics.Windows.Controls.CarouselViewSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x040003C4 RID: 964
		public static readonly global::System.Windows.DependencyProperty UseZOrderProperty = global::System.Windows.DependencyProperty.Register("UseZOrder", typeof(bool), typeof(global::Infragistics.Windows.Controls.CarouselViewSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x040003C5 RID: 965
		public static readonly global::System.Windows.DependencyProperty WidthInInfiniteContainersProperty = global::System.Windows.DependencyProperty.Register("WidthInInfiniteContainers", typeof(double), typeof(global::Infragistics.Windows.Controls.CarouselViewSettings), new global::System.Windows.FrameworkPropertyMetadata(400.0), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.Controls.CarouselViewSettings.ValidatePositiveDouble));

		// Token: 0x040003C6 RID: 966
		public static readonly global::System.Windows.DependencyProperty ZOrderEffectStopsProperty = global::System.Windows.DependencyProperty.Register("ZOrderEffectStops", typeof(global::Infragistics.Windows.Controls.ZOrderEffectStopCollection), typeof(global::Infragistics.Windows.Controls.CarouselViewSettings), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.CarouselViewSettings.OnZOrderEffectsChanged)));

		// Token: 0x040003C7 RID: 967
		public static readonly global::System.Windows.DependencyProperty ZOrderEffectStopDirectionProperty = global::System.Windows.DependencyProperty.Register("ZOrderEffectStopDirection", typeof(global::Infragistics.Windows.Controls.EffectStopDirection), typeof(global::Infragistics.Windows.Controls.CarouselViewSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.Controls.EffectStopDirection.Default), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.Controls.CarouselViewSettings.OnValidateZOrderEffectStopDirection));

		// Token: 0x040003C8 RID: 968
		private static readonly global::System.Windows.DependencyPropertyKey VersionPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("Version", typeof(int), typeof(global::Infragistics.Windows.Controls.CarouselViewSettings), new global::System.Windows.FrameworkPropertyMetadata(0));

		// Token: 0x040003C9 RID: 969
		public static readonly global::System.Windows.DependencyProperty VersionProperty = global::Infragistics.Windows.Controls.CarouselViewSettings.VersionPropertyKey.DependencyProperty;
	}
}
