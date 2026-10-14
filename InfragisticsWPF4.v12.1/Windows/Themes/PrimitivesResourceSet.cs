using System;
using System.Windows;
using Infragistics.Controls.Primitives;
using Infragistics.Windows.Controls;
using Infragistics.Windows.Tiles;

namespace Infragistics.Windows.Themes
{
	// Token: 0x0200023C RID: 572
	public abstract class PrimitivesResourceSet<T> : global::Infragistics.Windows.Themes.ResourceSet where T : global::Infragistics.Windows.Themes.ResourceSetLocator, new()
	{
		// Token: 0x17000550 RID: 1360
		// (get) Token: 0x06001797 RID: 6039 RVA: 0x0005BD7A File Offset: 0x00059F7A
		public override string Grouping
		{
			get
			{
				return global::Infragistics.Windows.Themes.PrimitivesResourceSet<T>.Location.Grouping;
			}
		}

		// Token: 0x17000551 RID: 1361
		// (get) Token: 0x06001798 RID: 6040 RVA: 0x0005BD86 File Offset: 0x00059F86
		public override string Theme
		{
			get
			{
				return global::Infragistics.Windows.Themes.PrimitivesResourceSet<T>.Location.Theme;
			}
		}

		// Token: 0x17000552 RID: 1362
		// (get) Token: 0x06001799 RID: 6041 RVA: 0x0005BD94 File Offset: 0x00059F94
		public override global::System.Windows.ResourceDictionary Resources
		{
			get
			{
				global::System.Windows.ResourceDictionary resourcesInternal = global::Infragistics.Windows.Themes.PrimitivesResourceSet<T>.ResourcesInternal;
				base.VerifyResources();
				return resourcesInternal;
			}
		}

		// Token: 0x17000553 RID: 1363
		// (get) Token: 0x0600179A RID: 6042 RVA: 0x0005BDAE File Offset: 0x00059FAE
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

		// Token: 0x17000554 RID: 1364
		// (get) Token: 0x0600179B RID: 6043 RVA: 0x0005BDCB File Offset: 0x00059FCB
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

		// Token: 0x17000555 RID: 1365
		// (get) Token: 0x0600179C RID: 6044 RVA: 0x0005BDF7 File Offset: 0x00059FF7
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

		// Token: 0x17000556 RID: 1366
		// (get) Token: 0x0600179D RID: 6045 RVA: 0x0005BE23 File Offset: 0x0005A023
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

		// Token: 0x17000557 RID: 1367
		// (get) Token: 0x0600179E RID: 6046 RVA: 0x0005BE4F File Offset: 0x0005A04F
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

		// Token: 0x17000558 RID: 1368
		// (get) Token: 0x0600179F RID: 6047 RVA: 0x0005BE7B File Offset: 0x0005A07B
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

		// Token: 0x17000559 RID: 1369
		// (get) Token: 0x060017A0 RID: 6048 RVA: 0x0005BEA7 File Offset: 0x0005A0A7
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

		// Token: 0x1700055A RID: 1370
		// (get) Token: 0x060017A1 RID: 6049 RVA: 0x0005BED3 File Offset: 0x0005A0D3
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

		// Token: 0x1700055B RID: 1371
		// (get) Token: 0x060017A2 RID: 6050 RVA: 0x0005BEFF File Offset: 0x0005A0FF
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

		// Token: 0x1700055C RID: 1372
		// (get) Token: 0x060017A3 RID: 6051 RVA: 0x0005BF2B File Offset: 0x0005A12B
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

		// Token: 0x1700055D RID: 1373
		// (get) Token: 0x060017A4 RID: 6052 RVA: 0x0005BF57 File Offset: 0x0005A157
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

		// Token: 0x1700055E RID: 1374
		// (get) Token: 0x060017A5 RID: 6053 RVA: 0x0005BF83 File Offset: 0x0005A183
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

		// Token: 0x1700055F RID: 1375
		// (get) Token: 0x060017A6 RID: 6054 RVA: 0x0005BFAF File Offset: 0x0005A1AF
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

		// Token: 0x17000560 RID: 1376
		// (get) Token: 0x060017A7 RID: 6055 RVA: 0x0005BFDB File Offset: 0x0005A1DB
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

		// Token: 0x17000561 RID: 1377
		// (get) Token: 0x060017A8 RID: 6056 RVA: 0x0005C007 File Offset: 0x0005A207
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

		// Token: 0x17000562 RID: 1378
		// (get) Token: 0x060017A9 RID: 6057 RVA: 0x0005C033 File Offset: 0x0005A233
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

		// Token: 0x17000563 RID: 1379
		// (get) Token: 0x060017AA RID: 6058 RVA: 0x0005C05F File Offset: 0x0005A25F
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

		// Token: 0x17000564 RID: 1380
		// (get) Token: 0x060017AB RID: 6059 RVA: 0x0005C08B File Offset: 0x0005A28B
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

		// Token: 0x17000565 RID: 1381
		// (get) Token: 0x060017AC RID: 6060 RVA: 0x0005C0B7 File Offset: 0x0005A2B7
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

		// Token: 0x04000B63 RID: 2915
		internal const string GroupingName = "Primitives";

		// Token: 0x04000B64 RID: 2916
		private static global::Infragistics.Windows.Themes.ResourceSetLocator g_Location;

		// Token: 0x04000B65 RID: 2917
		private static global::System.Windows.ResourceDictionary g_ResourcesInternal;

		// Token: 0x04000B66 RID: 2918
		private static global::System.Windows.Style g_ComparisonOperatorSelector;

		// Token: 0x04000B67 RID: 2919
		private static global::System.Windows.Style g_DropIndicator;

		// Token: 0x04000B68 RID: 2920
		private static global::System.Windows.Style g_EmbeddedTextBox;

		// Token: 0x04000B69 RID: 2921
		private static global::System.Windows.Style g_ExpanderBar;

		// Token: 0x04000B6A RID: 2922
		private static global::System.Windows.Style g_ExpansionIndicator;

		// Token: 0x04000B6B RID: 2923
		private static global::System.Windows.Style g_XamCarouselListBox;

		// Token: 0x04000B6C RID: 2924
		private static global::System.Windows.Style g_CarouselPanelItem;

		// Token: 0x04000B6D RID: 2925
		private static global::System.Windows.Style g_CarouselListBoxItem;

		// Token: 0x04000B6E RID: 2926
		private static global::System.Windows.Style g_CarouselPanelNavigator;

		// Token: 0x04000B6F RID: 2927
		private static global::System.Windows.Style g_PopupResizerBar;

		// Token: 0x04000B70 RID: 2928
		private static global::System.Windows.Style g_SortIndicator;

		// Token: 0x04000B71 RID: 2929
		private static global::System.Windows.Style g_XamPager;

		// Token: 0x04000B72 RID: 2930
		private static global::System.Windows.Style g_ToolWindow;

		// Token: 0x04000B73 RID: 2931
		private static global::System.Windows.Style g_XamTabControl;

		// Token: 0x04000B74 RID: 2932
		private static global::System.Windows.Style g_TabItemEx;

		// Token: 0x04000B75 RID: 2933
		private static global::System.Windows.Style g_XamScreenTip;

		// Token: 0x04000B76 RID: 2934
		private static global::System.Windows.Style g_TileDragIndicator;
	}
}
