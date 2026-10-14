using System;
using System.Windows;
using Infragistics.Controls.Primitives;
using Infragistics.Windows.Controls;
using Infragistics.Windows.Tiles;

namespace Infragistics.Windows.Themes
{
	// Token: 0x02000271 RID: 625
	public abstract class PrimitivesResourceSet<T> : global::Infragistics.Windows.Themes.ResourceSet where T : global::Infragistics.Windows.Themes.ResourceSetLocator, new()
	{
		// Token: 0x170005CD RID: 1485
		// (get) Token: 0x06001999 RID: 6553 RVA: 0x000627F2 File Offset: 0x000609F2
		public override string Grouping
		{
			get
			{
				return global::Infragistics.Windows.Themes.PrimitivesResourceSet<T>.Location.Grouping;
			}
		}

		// Token: 0x170005CE RID: 1486
		// (get) Token: 0x0600199A RID: 6554 RVA: 0x000627FE File Offset: 0x000609FE
		public override string Theme
		{
			get
			{
				return global::Infragistics.Windows.Themes.PrimitivesResourceSet<T>.Location.Theme;
			}
		}

		// Token: 0x170005CF RID: 1487
		// (get) Token: 0x0600199B RID: 6555 RVA: 0x0006280C File Offset: 0x00060A0C
		public override global::System.Windows.ResourceDictionary Resources
		{
			get
			{
				global::System.Windows.ResourceDictionary resourcesInternal = global::Infragistics.Windows.Themes.PrimitivesResourceSet<T>.ResourcesInternal;
				base.VerifyResources();
				return resourcesInternal;
			}
		}

		// Token: 0x170005D0 RID: 1488
		// (get) Token: 0x0600199C RID: 6556 RVA: 0x00062826 File Offset: 0x00060A26
		public static global::Infragistics.Windows.Themes.ResourceSetLocator Location
		{
			get
			{
				if (global::Infragistics.Windows.Themes.PrimitivesResourceSet<T>.g_Location == null)
				{
					global::Infragistics.Windows.Themes.PrimitivesResourceSet<T>.g_Location = global::System.Activator.CreateInstance<T>();
				}
				return global::Infragistics.Windows.Themes.PrimitivesResourceSet<T>.g_Location;
			}
		}

		// Token: 0x170005D1 RID: 1489
		// (get) Token: 0x0600199D RID: 6557 RVA: 0x00062843 File Offset: 0x00060A43
		private static global::System.Windows.ResourceDictionary ResourcesInternal
		{
			get
			{
				if (global::Infragistics.Windows.Themes.PrimitivesResourceSet<T>.g_ResourcesInternal == null)
				{
					global::Infragistics.Windows.Themes.PrimitivesResourceSet<T>.g_ResourcesInternal = global::Infragistics.Windows.Utilities.CreateResourceSetDictionary(global::Infragistics.Windows.Themes.PrimitivesResourceSet<T>.Location.Assembly, global::Infragistics.Windows.Themes.PrimitivesResourceSet<T>.Location.ResourcePath);
				}
				return global::Infragistics.Windows.Themes.PrimitivesResourceSet<T>.g_ResourcesInternal;
			}
		}

		// Token: 0x170005D2 RID: 1490
		// (get) Token: 0x0600199E RID: 6558 RVA: 0x0006286F File Offset: 0x00060A6F
		public static global::System.Windows.Style ComparisonOperatorSelector
		{
			get
			{
				if (global::Infragistics.Windows.Themes.PrimitivesResourceSet<T>.g_ComparisonOperatorSelector == null)
				{
					global::Infragistics.Windows.Themes.PrimitivesResourceSet<T>.g_ComparisonOperatorSelector = (global::Infragistics.Windows.Themes.ResourceSet.GetSealedResource(global::Infragistics.Windows.Themes.PrimitivesResourceSet<T>.ResourcesInternal, typeof(global::Infragistics.Windows.Controls.ComparisonOperatorSelector)) as global::System.Windows.Style);
				}
				return global::Infragistics.Windows.Themes.PrimitivesResourceSet<T>.g_ComparisonOperatorSelector;
			}
		}

		// Token: 0x170005D3 RID: 1491
		// (get) Token: 0x0600199F RID: 6559 RVA: 0x0006289B File Offset: 0x00060A9B
		public static global::System.Windows.Style DropIndicator
		{
			get
			{
				if (global::Infragistics.Windows.Themes.PrimitivesResourceSet<T>.g_DropIndicator == null)
				{
					global::Infragistics.Windows.Themes.PrimitivesResourceSet<T>.g_DropIndicator = (global::Infragistics.Windows.Themes.ResourceSet.GetSealedResource(global::Infragistics.Windows.Themes.PrimitivesResourceSet<T>.ResourcesInternal, typeof(global::Infragistics.Windows.Controls.DropIndicator)) as global::System.Windows.Style);
				}
				return global::Infragistics.Windows.Themes.PrimitivesResourceSet<T>.g_DropIndicator;
			}
		}

		// Token: 0x170005D4 RID: 1492
		// (get) Token: 0x060019A0 RID: 6560 RVA: 0x000628C7 File Offset: 0x00060AC7
		public static global::System.Windows.Style EmbeddedTextBox
		{
			get
			{
				if (global::Infragistics.Windows.Themes.PrimitivesResourceSet<T>.g_EmbeddedTextBox == null)
				{
					global::Infragistics.Windows.Themes.PrimitivesResourceSet<T>.g_EmbeddedTextBox = (global::Infragistics.Windows.Themes.ResourceSet.GetSealedResource(global::Infragistics.Windows.Themes.PrimitivesResourceSet<T>.ResourcesInternal, typeof(global::Infragistics.Controls.Primitives.EmbeddedTextBox)) as global::System.Windows.Style);
				}
				return global::Infragistics.Windows.Themes.PrimitivesResourceSet<T>.g_EmbeddedTextBox;
			}
		}

		// Token: 0x170005D5 RID: 1493
		// (get) Token: 0x060019A1 RID: 6561 RVA: 0x000628F3 File Offset: 0x00060AF3
		public static global::System.Windows.Style ExpanderBar
		{
			get
			{
				if (global::Infragistics.Windows.Themes.PrimitivesResourceSet<T>.g_ExpanderBar == null)
				{
					global::Infragistics.Windows.Themes.PrimitivesResourceSet<T>.g_ExpanderBar = (global::Infragistics.Windows.Themes.ResourceSet.GetSealedResource(global::Infragistics.Windows.Themes.PrimitivesResourceSet<T>.ResourcesInternal, typeof(global::Infragistics.Windows.Controls.ExpanderBar)) as global::System.Windows.Style);
				}
				return global::Infragistics.Windows.Themes.PrimitivesResourceSet<T>.g_ExpanderBar;
			}
		}

		// Token: 0x170005D6 RID: 1494
		// (get) Token: 0x060019A2 RID: 6562 RVA: 0x0006291F File Offset: 0x00060B1F
		public static global::System.Windows.Style ExpansionIndicator
		{
			get
			{
				if (global::Infragistics.Windows.Themes.PrimitivesResourceSet<T>.g_ExpansionIndicator == null)
				{
					global::Infragistics.Windows.Themes.PrimitivesResourceSet<T>.g_ExpansionIndicator = (global::Infragistics.Windows.Themes.ResourceSet.GetSealedResource(global::Infragistics.Windows.Themes.PrimitivesResourceSet<T>.ResourcesInternal, typeof(global::Infragistics.Windows.Controls.ExpansionIndicator)) as global::System.Windows.Style);
				}
				return global::Infragistics.Windows.Themes.PrimitivesResourceSet<T>.g_ExpansionIndicator;
			}
		}

		// Token: 0x170005D7 RID: 1495
		// (get) Token: 0x060019A3 RID: 6563 RVA: 0x0006294B File Offset: 0x00060B4B
		public static global::System.Windows.Style XamCarouselListBox
		{
			get
			{
				if (global::Infragistics.Windows.Themes.PrimitivesResourceSet<T>.g_XamCarouselListBox == null)
				{
					global::Infragistics.Windows.Themes.PrimitivesResourceSet<T>.g_XamCarouselListBox = (global::Infragistics.Windows.Themes.ResourceSet.GetSealedResource(global::Infragistics.Windows.Themes.PrimitivesResourceSet<T>.ResourcesInternal, typeof(global::Infragistics.Windows.Controls.XamCarouselListBox)) as global::System.Windows.Style);
				}
				return global::Infragistics.Windows.Themes.PrimitivesResourceSet<T>.g_XamCarouselListBox;
			}
		}

		// Token: 0x170005D8 RID: 1496
		// (get) Token: 0x060019A4 RID: 6564 RVA: 0x00062977 File Offset: 0x00060B77
		public static global::System.Windows.Style CarouselPanelItem
		{
			get
			{
				if (global::Infragistics.Windows.Themes.PrimitivesResourceSet<T>.g_CarouselPanelItem == null)
				{
					global::Infragistics.Windows.Themes.PrimitivesResourceSet<T>.g_CarouselPanelItem = (global::Infragistics.Windows.Themes.ResourceSet.GetSealedResource(global::Infragistics.Windows.Themes.PrimitivesResourceSet<T>.ResourcesInternal, typeof(global::Infragistics.Windows.Controls.CarouselPanelItem)) as global::System.Windows.Style);
				}
				return global::Infragistics.Windows.Themes.PrimitivesResourceSet<T>.g_CarouselPanelItem;
			}
		}

		// Token: 0x170005D9 RID: 1497
		// (get) Token: 0x060019A5 RID: 6565 RVA: 0x000629A3 File Offset: 0x00060BA3
		public static global::System.Windows.Style CarouselListBoxItem
		{
			get
			{
				if (global::Infragistics.Windows.Themes.PrimitivesResourceSet<T>.g_CarouselListBoxItem == null)
				{
					global::Infragistics.Windows.Themes.PrimitivesResourceSet<T>.g_CarouselListBoxItem = (global::Infragistics.Windows.Themes.ResourceSet.GetSealedResource(global::Infragistics.Windows.Themes.PrimitivesResourceSet<T>.ResourcesInternal, typeof(global::Infragistics.Windows.Controls.CarouselListBoxItem)) as global::System.Windows.Style);
				}
				return global::Infragistics.Windows.Themes.PrimitivesResourceSet<T>.g_CarouselListBoxItem;
			}
		}

		// Token: 0x170005DA RID: 1498
		// (get) Token: 0x060019A6 RID: 6566 RVA: 0x000629CF File Offset: 0x00060BCF
		public static global::System.Windows.Style CarouselPanelNavigator
		{
			get
			{
				if (global::Infragistics.Windows.Themes.PrimitivesResourceSet<T>.g_CarouselPanelNavigator == null)
				{
					global::Infragistics.Windows.Themes.PrimitivesResourceSet<T>.g_CarouselPanelNavigator = (global::Infragistics.Windows.Themes.ResourceSet.GetSealedResource(global::Infragistics.Windows.Themes.PrimitivesResourceSet<T>.ResourcesInternal, typeof(global::Infragistics.Windows.Controls.CarouselPanelNavigator)) as global::System.Windows.Style);
				}
				return global::Infragistics.Windows.Themes.PrimitivesResourceSet<T>.g_CarouselPanelNavigator;
			}
		}

		// Token: 0x170005DB RID: 1499
		// (get) Token: 0x060019A7 RID: 6567 RVA: 0x000629FB File Offset: 0x00060BFB
		public static global::System.Windows.Style PopupResizerBar
		{
			get
			{
				if (global::Infragistics.Windows.Themes.PrimitivesResourceSet<T>.g_PopupResizerBar == null)
				{
					global::Infragistics.Windows.Themes.PrimitivesResourceSet<T>.g_PopupResizerBar = (global::Infragistics.Windows.Themes.ResourceSet.GetSealedResource(global::Infragistics.Windows.Themes.PrimitivesResourceSet<T>.ResourcesInternal, typeof(global::Infragistics.Windows.Controls.PopupResizerBar)) as global::System.Windows.Style);
				}
				return global::Infragistics.Windows.Themes.PrimitivesResourceSet<T>.g_PopupResizerBar;
			}
		}

		// Token: 0x170005DC RID: 1500
		// (get) Token: 0x060019A8 RID: 6568 RVA: 0x00062A27 File Offset: 0x00060C27
		public static global::System.Windows.Style SortIndicator
		{
			get
			{
				if (global::Infragistics.Windows.Themes.PrimitivesResourceSet<T>.g_SortIndicator == null)
				{
					global::Infragistics.Windows.Themes.PrimitivesResourceSet<T>.g_SortIndicator = (global::Infragistics.Windows.Themes.ResourceSet.GetSealedResource(global::Infragistics.Windows.Themes.PrimitivesResourceSet<T>.ResourcesInternal, typeof(global::Infragistics.Windows.Controls.SortIndicator)) as global::System.Windows.Style);
				}
				return global::Infragistics.Windows.Themes.PrimitivesResourceSet<T>.g_SortIndicator;
			}
		}

		// Token: 0x170005DD RID: 1501
		// (get) Token: 0x060019A9 RID: 6569 RVA: 0x00062A53 File Offset: 0x00060C53
		public static global::System.Windows.Style XamPager
		{
			get
			{
				if (global::Infragistics.Windows.Themes.PrimitivesResourceSet<T>.g_XamPager == null)
				{
					global::Infragistics.Windows.Themes.PrimitivesResourceSet<T>.g_XamPager = (global::Infragistics.Windows.Themes.ResourceSet.GetSealedResource(global::Infragistics.Windows.Themes.PrimitivesResourceSet<T>.ResourcesInternal, typeof(global::Infragistics.Windows.Controls.XamPager)) as global::System.Windows.Style);
				}
				return global::Infragistics.Windows.Themes.PrimitivesResourceSet<T>.g_XamPager;
			}
		}

		// Token: 0x170005DE RID: 1502
		// (get) Token: 0x060019AA RID: 6570 RVA: 0x00062A7F File Offset: 0x00060C7F
		public static global::System.Windows.Style ToolWindow
		{
			get
			{
				if (global::Infragistics.Windows.Themes.PrimitivesResourceSet<T>.g_ToolWindow == null)
				{
					global::Infragistics.Windows.Themes.PrimitivesResourceSet<T>.g_ToolWindow = (global::Infragistics.Windows.Themes.ResourceSet.GetSealedResource(global::Infragistics.Windows.Themes.PrimitivesResourceSet<T>.ResourcesInternal, typeof(global::Infragistics.Windows.Controls.ToolWindow)) as global::System.Windows.Style);
				}
				return global::Infragistics.Windows.Themes.PrimitivesResourceSet<T>.g_ToolWindow;
			}
		}

		// Token: 0x170005DF RID: 1503
		// (get) Token: 0x060019AB RID: 6571 RVA: 0x00062AAB File Offset: 0x00060CAB
		public static global::System.Windows.Style XamTabControl
		{
			get
			{
				if (global::Infragistics.Windows.Themes.PrimitivesResourceSet<T>.g_XamTabControl == null)
				{
					global::Infragistics.Windows.Themes.PrimitivesResourceSet<T>.g_XamTabControl = (global::Infragistics.Windows.Themes.ResourceSet.GetSealedResource(global::Infragistics.Windows.Themes.PrimitivesResourceSet<T>.ResourcesInternal, typeof(global::Infragistics.Windows.Controls.XamTabControl)) as global::System.Windows.Style);
				}
				return global::Infragistics.Windows.Themes.PrimitivesResourceSet<T>.g_XamTabControl;
			}
		}

		// Token: 0x170005E0 RID: 1504
		// (get) Token: 0x060019AC RID: 6572 RVA: 0x00062AD7 File Offset: 0x00060CD7
		public static global::System.Windows.Style TabItemEx
		{
			get
			{
				if (global::Infragistics.Windows.Themes.PrimitivesResourceSet<T>.g_TabItemEx == null)
				{
					global::Infragistics.Windows.Themes.PrimitivesResourceSet<T>.g_TabItemEx = (global::Infragistics.Windows.Themes.ResourceSet.GetSealedResource(global::Infragistics.Windows.Themes.PrimitivesResourceSet<T>.ResourcesInternal, typeof(global::Infragistics.Windows.Controls.TabItemEx)) as global::System.Windows.Style);
				}
				return global::Infragistics.Windows.Themes.PrimitivesResourceSet<T>.g_TabItemEx;
			}
		}

		// Token: 0x170005E1 RID: 1505
		// (get) Token: 0x060019AD RID: 6573 RVA: 0x00062B03 File Offset: 0x00060D03
		public static global::System.Windows.Style XamScreenTip
		{
			get
			{
				if (global::Infragistics.Windows.Themes.PrimitivesResourceSet<T>.g_XamScreenTip == null)
				{
					global::Infragistics.Windows.Themes.PrimitivesResourceSet<T>.g_XamScreenTip = (global::Infragistics.Windows.Themes.ResourceSet.GetSealedResource(global::Infragistics.Windows.Themes.PrimitivesResourceSet<T>.ResourcesInternal, typeof(global::Infragistics.Windows.Controls.XamScreenTip)) as global::System.Windows.Style);
				}
				return global::Infragistics.Windows.Themes.PrimitivesResourceSet<T>.g_XamScreenTip;
			}
		}

		// Token: 0x170005E2 RID: 1506
		// (get) Token: 0x060019AE RID: 6574 RVA: 0x00062B2F File Offset: 0x00060D2F
		public static global::System.Windows.Style TileDragIndicator
		{
			get
			{
				if (global::Infragistics.Windows.Themes.PrimitivesResourceSet<T>.g_TileDragIndicator == null)
				{
					global::Infragistics.Windows.Themes.PrimitivesResourceSet<T>.g_TileDragIndicator = (global::Infragistics.Windows.Themes.ResourceSet.GetSealedResource(global::Infragistics.Windows.Themes.PrimitivesResourceSet<T>.ResourcesInternal, typeof(global::Infragistics.Windows.Tiles.TileDragIndicator)) as global::System.Windows.Style);
				}
				return global::Infragistics.Windows.Themes.PrimitivesResourceSet<T>.g_TileDragIndicator;
			}
		}

		// Token: 0x04000CC6 RID: 3270
		internal const string GroupingName = "Primitives";

		// Token: 0x04000CC7 RID: 3271
		[global::System.ThreadStatic]
		private static global::Infragistics.Windows.Themes.ResourceSetLocator g_Location;

		// Token: 0x04000CC8 RID: 3272
		[global::System.ThreadStatic]
		private static global::System.Windows.ResourceDictionary g_ResourcesInternal;

		// Token: 0x04000CC9 RID: 3273
		[global::System.ThreadStatic]
		private static global::System.Windows.Style g_ComparisonOperatorSelector;

		// Token: 0x04000CCA RID: 3274
		[global::System.ThreadStatic]
		private static global::System.Windows.Style g_DropIndicator;

		// Token: 0x04000CCB RID: 3275
		[global::System.ThreadStatic]
		private static global::System.Windows.Style g_EmbeddedTextBox;

		// Token: 0x04000CCC RID: 3276
		[global::System.ThreadStatic]
		private static global::System.Windows.Style g_ExpanderBar;

		// Token: 0x04000CCD RID: 3277
		[global::System.ThreadStatic]
		private static global::System.Windows.Style g_ExpansionIndicator;

		// Token: 0x04000CCE RID: 3278
		[global::System.ThreadStatic]
		private static global::System.Windows.Style g_XamCarouselListBox;

		// Token: 0x04000CCF RID: 3279
		[global::System.ThreadStatic]
		private static global::System.Windows.Style g_CarouselPanelItem;

		// Token: 0x04000CD0 RID: 3280
		[global::System.ThreadStatic]
		private static global::System.Windows.Style g_CarouselListBoxItem;

		// Token: 0x04000CD1 RID: 3281
		[global::System.ThreadStatic]
		private static global::System.Windows.Style g_CarouselPanelNavigator;

		// Token: 0x04000CD2 RID: 3282
		[global::System.ThreadStatic]
		private static global::System.Windows.Style g_PopupResizerBar;

		// Token: 0x04000CD3 RID: 3283
		[global::System.ThreadStatic]
		private static global::System.Windows.Style g_SortIndicator;

		// Token: 0x04000CD4 RID: 3284
		[global::System.ThreadStatic]
		private static global::System.Windows.Style g_XamPager;

		// Token: 0x04000CD5 RID: 3285
		[global::System.ThreadStatic]
		private static global::System.Windows.Style g_ToolWindow;

		// Token: 0x04000CD6 RID: 3286
		[global::System.ThreadStatic]
		private static global::System.Windows.Style g_XamTabControl;

		// Token: 0x04000CD7 RID: 3287
		[global::System.ThreadStatic]
		private static global::System.Windows.Style g_TabItemEx;

		// Token: 0x04000CD8 RID: 3288
		[global::System.ThreadStatic]
		private static global::System.Windows.Style g_XamScreenTip;

		// Token: 0x04000CD9 RID: 3289
		[global::System.ThreadStatic]
		private static global::System.Windows.Style g_TileDragIndicator;
	}
}
