using System;
using System.Windows;
using Infragistics.Windows.DataPresenter;

namespace Infragistics.Windows.Themes
{
	// Token: 0x02000371 RID: 881
	public abstract class DataPresenterResourceSet<T> : global::Infragistics.Windows.Themes.ResourceSet where T : global::Infragistics.Windows.Themes.ResourceSetLocator, new()
	{
		// Token: 0x17000CD5 RID: 3285
		// (get) Token: 0x06002B11 RID: 11025 RVA: 0x000BFB3E File Offset: 0x000BDD3E
		public override string Grouping
		{
			get
			{
				return global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.Location.Grouping;
			}
		}

		// Token: 0x17000CD6 RID: 3286
		// (get) Token: 0x06002B12 RID: 11026 RVA: 0x000BFB4A File Offset: 0x000BDD4A
		public override string Theme
		{
			get
			{
				return global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.Location.Theme;
			}
		}

		// Token: 0x17000CD7 RID: 3287
		// (get) Token: 0x06002B13 RID: 11027 RVA: 0x000BFB58 File Offset: 0x000BDD58
		public override global::System.Windows.ResourceDictionary Resources
		{
			get
			{
				global::System.Windows.ResourceDictionary resourcesInternal = global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.ResourcesInternal;
				base.VerifyResources();
				return resourcesInternal;
			}
		}

		// Token: 0x17000CD8 RID: 3288
		// (get) Token: 0x06002B14 RID: 11028 RVA: 0x000BFB72 File Offset: 0x000BDD72
		public static global::Infragistics.Windows.Themes.ResourceSetLocator Location
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_Location == null)
				{
					global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_Location = global::System.Activator.CreateInstance<T>();
				}
				return global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_Location;
			}
		}

		// Token: 0x17000CD9 RID: 3289
		// (get) Token: 0x06002B15 RID: 11029 RVA: 0x000BFB8F File Offset: 0x000BDD8F
		private static global::System.Windows.ResourceDictionary ResourcesInternal
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_ResourcesInternal == null)
				{
					global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_ResourcesInternal = global::Infragistics.Windows.Utilities.CreateResourceSetDictionary(global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.Location.Assembly, global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.Location.ResourcePath);
				}
				return global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_ResourcesInternal;
			}
		}

		// Token: 0x17000CDA RID: 3290
		// (get) Token: 0x06002B16 RID: 11030 RVA: 0x000BFBBB File Offset: 0x000BDDBB
		public static global::System.Windows.Style CardHeaderPresenter
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_CardHeaderPresenter == null)
				{
					global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_CardHeaderPresenter = (global::Infragistics.Windows.Themes.ResourceSet.GetSealedResource(global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.ResourcesInternal, typeof(global::Infragistics.Windows.DataPresenter.CardHeaderPresenter)) as global::System.Windows.Style);
				}
				return global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_CardHeaderPresenter;
			}
		}

		// Token: 0x17000CDB RID: 3291
		// (get) Token: 0x06002B17 RID: 11031 RVA: 0x000BFBE7 File Offset: 0x000BDDE7
		public static global::System.Windows.Style CardViewCard
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_CardViewCard == null)
				{
					global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_CardViewCard = (global::Infragistics.Windows.Themes.ResourceSet.GetSealedResource(global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.ResourcesInternal, typeof(global::Infragistics.Windows.DataPresenter.CardViewCard)) as global::System.Windows.Style);
				}
				return global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_CardViewCard;
			}
		}

		// Token: 0x17000CDC RID: 3292
		// (get) Token: 0x06002B18 RID: 11032 RVA: 0x000BFC13 File Offset: 0x000BDE13
		public static global::System.Windows.Style CarouselBreadcrumbControl
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_CarouselBreadcrumbControl == null)
				{
					global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_CarouselBreadcrumbControl = (global::Infragistics.Windows.Themes.ResourceSet.GetSealedResource(global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.ResourcesInternal, typeof(global::Infragistics.Windows.DataPresenter.CarouselBreadcrumbControl)) as global::System.Windows.Style);
				}
				return global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_CarouselBreadcrumbControl;
			}
		}

		// Token: 0x17000CDD RID: 3293
		// (get) Token: 0x06002B19 RID: 11033 RVA: 0x000BFC3F File Offset: 0x000BDE3F
		public static global::System.Windows.Style CarouselBreadcrumb
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_CarouselBreadcrumb == null)
				{
					global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_CarouselBreadcrumb = (global::Infragistics.Windows.Themes.ResourceSet.GetSealedResource(global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.ResourcesInternal, typeof(global::Infragistics.Windows.DataPresenter.CarouselBreadcrumb)) as global::System.Windows.Style);
				}
				return global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_CarouselBreadcrumb;
			}
		}

		// Token: 0x17000CDE RID: 3294
		// (get) Token: 0x06002B1A RID: 11034 RVA: 0x000BFC6B File Offset: 0x000BDE6B
		public static global::System.Windows.Style CarouselItem
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_CarouselItem == null)
				{
					global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_CarouselItem = (global::Infragistics.Windows.Themes.ResourceSet.GetSealedResource(global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.ResourcesInternal, typeof(global::Infragistics.Windows.DataPresenter.CarouselItem)) as global::System.Windows.Style);
				}
				return global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_CarouselItem;
			}
		}

		// Token: 0x17000CDF RID: 3295
		// (get) Token: 0x06002B1B RID: 11035 RVA: 0x000BFC97 File Offset: 0x000BDE97
		public static global::System.Windows.Style FieldDragIndicator
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_FieldDragIndicator == null)
				{
					global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_FieldDragIndicator = (global::Infragistics.Windows.Themes.ResourceSet.GetSealedResource(global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.ResourcesInternal, typeof(global::Infragistics.Windows.DataPresenter.FieldDragIndicator)) as global::System.Windows.Style);
				}
				return global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_FieldDragIndicator;
			}
		}

		// Token: 0x17000CE0 RID: 3296
		// (get) Token: 0x06002B1C RID: 11036 RVA: 0x000BFCC3 File Offset: 0x000BDEC3
		public static global::System.Windows.Style CustomFilterSelectionControl
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_CustomFilterSelectionControl == null)
				{
					global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_CustomFilterSelectionControl = (global::Infragistics.Windows.Themes.ResourceSet.GetSealedResource(global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.ResourcesInternal, typeof(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl)) as global::System.Windows.Style);
				}
				return global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_CustomFilterSelectionControl;
			}
		}

		// Token: 0x17000CE1 RID: 3297
		// (get) Token: 0x06002B1D RID: 11037 RVA: 0x000BFCEF File Offset: 0x000BDEEF
		public static global::System.Windows.Style FilterButton
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_FilterButton == null)
				{
					global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_FilterButton = (global::Infragistics.Windows.Themes.ResourceSet.GetSealedResource(global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.ResourcesInternal, typeof(global::Infragistics.Windows.DataPresenter.FilterButton)) as global::System.Windows.Style);
				}
				return global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_FilterButton;
			}
		}

		// Token: 0x17000CE2 RID: 3298
		// (get) Token: 0x06002B1E RID: 11038 RVA: 0x000BFD1B File Offset: 0x000BDF1B
		public static global::System.Windows.Style FixedFieldButton
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_FixedFieldButton == null)
				{
					global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_FixedFieldButton = (global::Infragistics.Windows.Themes.ResourceSet.GetSealedResource(global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.ResourcesInternal, typeof(global::Infragistics.Windows.DataPresenter.FixedFieldButton)) as global::System.Windows.Style);
				}
				return global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_FixedFieldButton;
			}
		}

		// Token: 0x17000CE3 RID: 3299
		// (get) Token: 0x06002B1F RID: 11039 RVA: 0x000BFD47 File Offset: 0x000BDF47
		public static global::System.Windows.Style FixedRecordButton
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_FixedRecordButton == null)
				{
					global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_FixedRecordButton = (global::Infragistics.Windows.Themes.ResourceSet.GetSealedResource(global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.ResourcesInternal, typeof(global::Infragistics.Windows.DataPresenter.FixedRecordButton)) as global::System.Windows.Style);
				}
				return global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_FixedRecordButton;
			}
		}

		// Token: 0x17000CE4 RID: 3300
		// (get) Token: 0x06002B20 RID: 11040 RVA: 0x000BFD73 File Offset: 0x000BDF73
		public static global::System.Windows.Style CellPresenter
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_Cell == null)
				{
					global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_Cell = (global::Infragistics.Windows.Themes.ResourceSet.GetSealedResource(global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.ResourcesInternal, typeof(global::Infragistics.Windows.DataPresenter.CellPresenter)) as global::System.Windows.Style);
				}
				return global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_Cell;
			}
		}

		// Token: 0x17000CE5 RID: 3301
		// (get) Token: 0x06002B21 RID: 11041 RVA: 0x000BFD9F File Offset: 0x000BDF9F
		public static global::System.Windows.Style CellValuePresenter
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_CellValue == null)
				{
					global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_CellValue = (global::Infragistics.Windows.Themes.ResourceSet.GetSealedResource(global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.ResourcesInternal, typeof(global::Infragistics.Windows.DataPresenter.CellValuePresenter)) as global::System.Windows.Style);
				}
				return global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_CellValue;
			}
		}

		// Token: 0x17000CE6 RID: 3302
		// (get) Token: 0x06002B22 RID: 11042 RVA: 0x000BFDCB File Offset: 0x000BDFCB
		public static global::System.Windows.Style TreeCellValuePresenter
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_TreeCellValue == null)
				{
					global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_TreeCellValue = (global::Infragistics.Windows.Themes.ResourceSet.GetSealedResource(global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.ResourcesInternal, typeof(global::Infragistics.Windows.DataPresenter.TreeCellValuePresenter)) as global::System.Windows.Style);
				}
				return global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_TreeCellValue;
			}
		}

		// Token: 0x17000CE7 RID: 3303
		// (get) Token: 0x06002B23 RID: 11043 RVA: 0x000BFDF7 File Offset: 0x000BDFF7
		public static global::System.Windows.Style DataRecordPresenter
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_DataRecordPresenter == null)
				{
					global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_DataRecordPresenter = (global::Infragistics.Windows.Themes.ResourceSet.GetSealedResource(global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.ResourcesInternal, typeof(global::Infragistics.Windows.DataPresenter.DataRecordPresenter)) as global::System.Windows.Style);
				}
				return global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_DataRecordPresenter;
			}
		}

		// Token: 0x17000CE8 RID: 3304
		// (get) Token: 0x06002B24 RID: 11044 RVA: 0x000BFE23 File Offset: 0x000BE023
		public static global::System.Windows.Style DataRecordCellArea
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_DataRecordCellArea == null)
				{
					global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_DataRecordCellArea = (global::Infragistics.Windows.Themes.ResourceSet.GetSealedResource(global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.ResourcesInternal, typeof(global::Infragistics.Windows.DataPresenter.DataRecordCellArea)) as global::System.Windows.Style);
				}
				return global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_DataRecordCellArea;
			}
		}

		// Token: 0x17000CE9 RID: 3305
		// (get) Token: 0x06002B25 RID: 11045 RVA: 0x000BFE4F File Offset: 0x000BE04F
		public static global::System.Windows.Style ExpandableFieldRecordPresenter
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_ExpandableFieldRecordPresenter == null)
				{
					global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_ExpandableFieldRecordPresenter = (global::Infragistics.Windows.Themes.ResourceSet.GetSealedResource(global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.ResourcesInternal, typeof(global::Infragistics.Windows.DataPresenter.ExpandableFieldRecordPresenter)) as global::System.Windows.Style);
				}
				return global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_ExpandableFieldRecordPresenter;
			}
		}

		// Token: 0x17000CEA RID: 3306
		// (get) Token: 0x06002B26 RID: 11046 RVA: 0x000BFE7B File Offset: 0x000BE07B
		public static global::System.Windows.Style ExpandedCellPresenter
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_ExpandedCellPresenter == null)
				{
					global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_ExpandedCellPresenter = (global::Infragistics.Windows.Themes.ResourceSet.GetSealedResource(global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.ResourcesInternal, typeof(global::Infragistics.Windows.DataPresenter.ExpandedCellPresenter)) as global::System.Windows.Style);
				}
				return global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_ExpandedCellPresenter;
			}
		}

		// Token: 0x17000CEB RID: 3307
		// (get) Token: 0x06002B27 RID: 11047 RVA: 0x000BFEA7 File Offset: 0x000BE0A7
		public static global::System.Windows.Style FieldChooser
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_FieldChooser == null)
				{
					global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_FieldChooser = (global::Infragistics.Windows.Themes.ResourceSet.GetSealedResource(global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.ResourcesInternal, typeof(global::Infragistics.Windows.DataPresenter.FieldChooser)) as global::System.Windows.Style);
				}
				return global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_FieldChooser;
			}
		}

		// Token: 0x17000CEC RID: 3308
		// (get) Token: 0x06002B28 RID: 11048 RVA: 0x000BFED3 File Offset: 0x000BE0D3
		public static global::System.Windows.Style FieldMenuItem
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_FieldMenuItem == null)
				{
					global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_FieldMenuItem = (global::Infragistics.Windows.Themes.ResourceSet.GetSealedResource(global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.ResourcesInternal, typeof(global::Infragistics.Windows.DataPresenter.FieldMenuItem)) as global::System.Windows.Style);
				}
				return global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_FieldMenuItem;
			}
		}

		// Token: 0x17000CED RID: 3309
		// (get) Token: 0x06002B29 RID: 11049 RVA: 0x000BFEFF File Offset: 0x000BE0FF
		public static global::System.Windows.Style FilterCellValuePresenter
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_FilterCellValuePresenter == null)
				{
					global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_FilterCellValuePresenter = (global::Infragistics.Windows.Themes.ResourceSet.GetSealedResource(global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.ResourcesInternal, typeof(global::Infragistics.Windows.DataPresenter.FilterCellValuePresenter)) as global::System.Windows.Style);
				}
				return global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_FilterCellValuePresenter;
			}
		}

		// Token: 0x17000CEE RID: 3310
		// (get) Token: 0x06002B2A RID: 11050 RVA: 0x000BFF2B File Offset: 0x000BE12B
		public static global::System.Windows.Style FixedFieldSplitter
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_FixedFieldSplitter == null)
				{
					global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_FixedFieldSplitter = (global::Infragistics.Windows.Themes.ResourceSet.GetSealedResource(global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.ResourcesInternal, typeof(global::Infragistics.Windows.DataPresenter.FixedFieldSplitter)) as global::System.Windows.Style);
				}
				return global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_FixedFieldSplitter;
			}
		}

		// Token: 0x17000CEF RID: 3311
		// (get) Token: 0x06002B2B RID: 11051 RVA: 0x000BFF57 File Offset: 0x000BE157
		public static global::System.Windows.Style LabelPresenter
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_FieldLabel == null)
				{
					global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_FieldLabel = (global::Infragistics.Windows.Themes.ResourceSet.GetSealedResource(global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.ResourcesInternal, typeof(global::Infragistics.Windows.DataPresenter.LabelPresenter)) as global::System.Windows.Style);
				}
				return global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_FieldLabel;
			}
		}

		// Token: 0x17000CF0 RID: 3312
		// (get) Token: 0x06002B2C RID: 11052 RVA: 0x000BFF83 File Offset: 0x000BE183
		public static global::System.Windows.Style GroupByArea
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_GroupByArea == null)
				{
					global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_GroupByArea = (global::Infragistics.Windows.Themes.ResourceSet.GetSealedResource(global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.ResourcesInternal, typeof(global::Infragistics.Windows.DataPresenter.GroupByArea)) as global::System.Windows.Style);
				}
				return global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_GroupByArea;
			}
		}

		// Token: 0x17000CF1 RID: 3313
		// (get) Token: 0x06002B2D RID: 11053 RVA: 0x000BFFAF File Offset: 0x000BE1AF
		public static global::System.Windows.Style GroupByAreaFieldLabel
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_GroupByAreaFieldLabel == null)
				{
					global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_GroupByAreaFieldLabel = (global::Infragistics.Windows.Themes.ResourceSet.GetSealedResource(global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.ResourcesInternal, typeof(global::Infragistics.Windows.DataPresenter.GroupByAreaFieldLabel)) as global::System.Windows.Style);
				}
				return global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_GroupByAreaFieldLabel;
			}
		}

		// Token: 0x17000CF2 RID: 3314
		// (get) Token: 0x06002B2E RID: 11054 RVA: 0x000BFFDB File Offset: 0x000BE1DB
		public static global::System.Windows.Style GroupByAreaFieldListBox
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_GroupByAreaFieldListBox == null)
				{
					global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_GroupByAreaFieldListBox = (global::Infragistics.Windows.Themes.ResourceSet.GetSealedResource(global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.ResourcesInternal, typeof(global::Infragistics.Windows.DataPresenter.GroupByAreaFieldListBox)) as global::System.Windows.Style);
				}
				return global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_GroupByAreaFieldListBox;
			}
		}

		// Token: 0x17000CF3 RID: 3315
		// (get) Token: 0x06002B2F RID: 11055 RVA: 0x000C0007 File Offset: 0x000BE207
		public static global::System.Windows.Style GroupByAreaMulti
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_GroupByAreaMulti == null)
				{
					global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_GroupByAreaMulti = (global::Infragistics.Windows.Themes.ResourceSet.GetSealedResource(global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.ResourcesInternal, typeof(global::Infragistics.Windows.DataPresenter.GroupByAreaMulti)) as global::System.Windows.Style);
				}
				return global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_GroupByAreaMulti;
			}
		}

		// Token: 0x17000CF4 RID: 3316
		// (get) Token: 0x06002B30 RID: 11056 RVA: 0x000C0033 File Offset: 0x000BE233
		public static global::System.Windows.Style GroupByRecordPresenter
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_GroupByRecordPresenter == null)
				{
					global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_GroupByRecordPresenter = (global::Infragistics.Windows.Themes.ResourceSet.GetSealedResource(global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.ResourcesInternal, typeof(global::Infragistics.Windows.DataPresenter.GroupByRecordPresenter)) as global::System.Windows.Style);
				}
				return global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_GroupByRecordPresenter;
			}
		}

		// Token: 0x17000CF5 RID: 3317
		// (get) Token: 0x06002B31 RID: 11057 RVA: 0x000C005F File Offset: 0x000BE25F
		public static global::System.Windows.Style GroupBySummariesPresenter
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_GroupBySummariesPresenter == null)
				{
					global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_GroupBySummariesPresenter = (global::Infragistics.Windows.Themes.ResourceSet.GetSealedResource(global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.ResourcesInternal, typeof(global::Infragistics.Windows.DataPresenter.GroupBySummariesPresenter)) as global::System.Windows.Style);
				}
				return global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_GroupBySummariesPresenter;
			}
		}

		// Token: 0x17000CF6 RID: 3318
		// (get) Token: 0x06002B32 RID: 11058 RVA: 0x000C008B File Offset: 0x000BE28B
		public static global::System.Windows.Style HeaderPresenter
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_HeaderPresenter == null)
				{
					global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_HeaderPresenter = (global::Infragistics.Windows.Themes.ResourceSet.GetSealedResource(global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.ResourcesInternal, typeof(global::Infragistics.Windows.DataPresenter.HeaderPresenter)) as global::System.Windows.Style);
				}
				return global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_HeaderPresenter;
			}
		}

		// Token: 0x17000CF7 RID: 3319
		// (get) Token: 0x06002B33 RID: 11059 RVA: 0x000C00B7 File Offset: 0x000BE2B7
		public static global::System.Windows.Style HeaderLabelArea
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_HeaderLabelArea == null)
				{
					global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_HeaderLabelArea = (global::Infragistics.Windows.Themes.ResourceSet.GetSealedResource(global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.ResourcesInternal, typeof(global::Infragistics.Windows.DataPresenter.HeaderLabelArea)) as global::System.Windows.Style);
				}
				return global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_HeaderLabelArea;
			}
		}

		// Token: 0x17000CF8 RID: 3320
		// (get) Token: 0x06002B34 RID: 11060 RVA: 0x000C00E3 File Offset: 0x000BE2E3
		public static global::System.Windows.Style HeaderPrefixArea
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_HeaderPrefixArea == null)
				{
					global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_HeaderPrefixArea = (global::Infragistics.Windows.Themes.ResourceSet.GetSealedResource(global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.ResourcesInternal, typeof(global::Infragistics.Windows.DataPresenter.HeaderPrefixArea)) as global::System.Windows.Style);
				}
				return global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_HeaderPrefixArea;
			}
		}

		// Token: 0x17000CF9 RID: 3321
		// (get) Token: 0x06002B35 RID: 11061 RVA: 0x000C010F File Offset: 0x000BE30F
		public static global::System.Windows.Style RecordExportStatusControl
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_RecordExportStatusControl == null)
				{
					global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_RecordExportStatusControl = (global::Infragistics.Windows.Themes.ResourceSet.GetSealedResource(global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.ResourcesInternal, typeof(global::Infragistics.Windows.DataPresenter.RecordExportStatusControl)) as global::System.Windows.Style);
				}
				return global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_RecordExportStatusControl;
			}
		}

		// Token: 0x17000CFA RID: 3322
		// (get) Token: 0x06002B36 RID: 11062 RVA: 0x000C013B File Offset: 0x000BE33B
		public static global::System.Windows.Style RecordFilterTreeControl
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_RecordFilterTreeControl == null)
				{
					global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_RecordFilterTreeControl = (global::Infragistics.Windows.Themes.ResourceSet.GetSealedResource(global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.ResourcesInternal, typeof(global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl)) as global::System.Windows.Style);
				}
				return global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_RecordFilterTreeControl;
			}
		}

		// Token: 0x17000CFB RID: 3323
		// (get) Token: 0x06002B37 RID: 11063 RVA: 0x000C0167 File Offset: 0x000BE367
		public static global::System.Windows.Style RecordListControl
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_RecordListControl == null)
				{
					global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_RecordListControl = (global::Infragistics.Windows.Themes.ResourceSet.GetSealedResource(global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.ResourcesInternal, typeof(global::Infragistics.Windows.DataPresenter.RecordListControl)) as global::System.Windows.Style);
				}
				return global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_RecordListControl;
			}
		}

		// Token: 0x17000CFC RID: 3324
		// (get) Token: 0x06002B38 RID: 11064 RVA: 0x000C0193 File Offset: 0x000BE393
		public static global::System.Windows.Style RecordScrollTip
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_RecordScrollTip == null)
				{
					global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_RecordScrollTip = (global::Infragistics.Windows.Themes.ResourceSet.GetSealedResource(global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.ResourcesInternal, typeof(global::Infragistics.Windows.DataPresenter.RecordScrollTip)) as global::System.Windows.Style);
				}
				return global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_RecordScrollTip;
			}
		}

		// Token: 0x17000CFD RID: 3325
		// (get) Token: 0x06002B39 RID: 11065 RVA: 0x000C01BF File Offset: 0x000BE3BF
		public static global::System.Windows.Style RecordSelector
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_RecordSelector == null)
				{
					global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_RecordSelector = (global::Infragistics.Windows.Themes.ResourceSet.GetSealedResource(global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.ResourcesInternal, typeof(global::Infragistics.Windows.DataPresenter.RecordSelector)) as global::System.Windows.Style);
				}
				return global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_RecordSelector;
			}
		}

		// Token: 0x17000CFE RID: 3326
		// (get) Token: 0x06002B3A RID: 11066 RVA: 0x000C01EB File Offset: 0x000BE3EB
		public static global::System.Windows.Style RecordSelectorNumber
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_RecordSelectorNumber == null)
				{
					global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_RecordSelectorNumber = (global::Infragistics.Windows.Themes.ResourceSet.GetSealedResource(global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.ResourcesInternal, typeof(global::Infragistics.Windows.DataPresenter.RecordSelectorNumber)) as global::System.Windows.Style);
				}
				return global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_RecordSelectorNumber;
			}
		}

		// Token: 0x17000CFF RID: 3327
		// (get) Token: 0x06002B3B RID: 11067 RVA: 0x000C0217 File Offset: 0x000BE417
		public static global::System.Windows.Style SummaryButton
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_SummaryButton == null)
				{
					global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_SummaryButton = (global::Infragistics.Windows.Themes.ResourceSet.GetSealedResource(global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.ResourcesInternal, typeof(global::Infragistics.Windows.DataPresenter.SummaryButton)) as global::System.Windows.Style);
				}
				return global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_SummaryButton;
			}
		}

		// Token: 0x17000D00 RID: 3328
		// (get) Token: 0x06002B3C RID: 11068 RVA: 0x000C0243 File Offset: 0x000BE443
		public static global::System.Windows.Style SummaryCalculatorSelectionControl
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_SummaryCalculatorSelectionControl == null)
				{
					global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_SummaryCalculatorSelectionControl = (global::Infragistics.Windows.Themes.ResourceSet.GetSealedResource(global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.ResourcesInternal, typeof(global::Infragistics.Windows.DataPresenter.SummaryCalculatorSelectionControl)) as global::System.Windows.Style);
				}
				return global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_SummaryCalculatorSelectionControl;
			}
		}

		// Token: 0x17000D01 RID: 3329
		// (get) Token: 0x06002B3D RID: 11069 RVA: 0x000C026F File Offset: 0x000BE46F
		public static global::System.Windows.Style SummaryCellPresenter
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_SummaryCellPresenter == null)
				{
					global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_SummaryCellPresenter = (global::Infragistics.Windows.Themes.ResourceSet.GetSealedResource(global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.ResourcesInternal, typeof(global::Infragistics.Windows.DataPresenter.SummaryCellPresenter)) as global::System.Windows.Style);
				}
				return global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_SummaryCellPresenter;
			}
		}

		// Token: 0x17000D02 RID: 3330
		// (get) Token: 0x06002B3E RID: 11070 RVA: 0x000C029B File Offset: 0x000BE49B
		public static global::System.Windows.Style SummaryRecordCellArea
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_SummaryRecordCellArea == null)
				{
					global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_SummaryRecordCellArea = (global::Infragistics.Windows.Themes.ResourceSet.GetSealedResource(global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.ResourcesInternal, typeof(global::Infragistics.Windows.DataPresenter.SummaryRecordCellArea)) as global::System.Windows.Style);
				}
				return global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_SummaryRecordCellArea;
			}
		}

		// Token: 0x17000D03 RID: 3331
		// (get) Token: 0x06002B3F RID: 11071 RVA: 0x000C02C7 File Offset: 0x000BE4C7
		public static global::System.Windows.Style SummaryRecordContentArea
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_SummaryRecordContentArea == null)
				{
					global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_SummaryRecordContentArea = (global::Infragistics.Windows.Themes.ResourceSet.GetSealedResource(global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.ResourcesInternal, typeof(global::Infragistics.Windows.DataPresenter.SummaryRecordContentArea)) as global::System.Windows.Style);
				}
				return global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_SummaryRecordContentArea;
			}
		}

		// Token: 0x17000D04 RID: 3332
		// (get) Token: 0x06002B40 RID: 11072 RVA: 0x000C02F3 File Offset: 0x000BE4F3
		public static global::System.Windows.Style SummaryRecordHeaderPresenter
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_SummaryRecordHeaderPresenter == null)
				{
					global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_SummaryRecordHeaderPresenter = (global::Infragistics.Windows.Themes.ResourceSet.GetSealedResource(global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.ResourcesInternal, typeof(global::Infragistics.Windows.DataPresenter.SummaryRecordHeaderPresenter)) as global::System.Windows.Style);
				}
				return global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_SummaryRecordHeaderPresenter;
			}
		}

		// Token: 0x17000D05 RID: 3333
		// (get) Token: 0x06002B41 RID: 11073 RVA: 0x000C031F File Offset: 0x000BE51F
		public static global::System.Windows.Style SummaryRecordPrefixArea
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_SummaryRecordPrefixArea == null)
				{
					global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_SummaryRecordPrefixArea = (global::Infragistics.Windows.Themes.ResourceSet.GetSealedResource(global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.ResourcesInternal, typeof(global::Infragistics.Windows.DataPresenter.SummaryRecordPrefixArea)) as global::System.Windows.Style);
				}
				return global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_SummaryRecordPrefixArea;
			}
		}

		// Token: 0x17000D06 RID: 3334
		// (get) Token: 0x06002B42 RID: 11074 RVA: 0x000C034B File Offset: 0x000BE54B
		public static global::System.Windows.Style SummaryRecordPresenter
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_SummaryRecordPresenter == null)
				{
					global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_SummaryRecordPresenter = (global::Infragistics.Windows.Themes.ResourceSet.GetSealedResource(global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.ResourcesInternal, typeof(global::Infragistics.Windows.DataPresenter.SummaryRecordPresenter)) as global::System.Windows.Style);
				}
				return global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_SummaryRecordPresenter;
			}
		}

		// Token: 0x17000D07 RID: 3335
		// (get) Token: 0x06002B43 RID: 11075 RVA: 0x000C0377 File Offset: 0x000BE577
		public static global::System.Windows.Style SummaryResultPresenter
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_SummaryResultPresenter == null)
				{
					global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_SummaryResultPresenter = (global::Infragistics.Windows.Themes.ResourceSet.GetSealedResource(global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.ResourcesInternal, typeof(global::Infragistics.Windows.DataPresenter.SummaryResultPresenter)) as global::System.Windows.Style);
				}
				return global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_SummaryResultPresenter;
			}
		}

		// Token: 0x17000D08 RID: 3336
		// (get) Token: 0x06002B44 RID: 11076 RVA: 0x000C03A3 File Offset: 0x000BE5A3
		public static global::System.Windows.Style SummaryResultsPresenter
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_SummaryResultsPresenter == null)
				{
					global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_SummaryResultsPresenter = (global::Infragistics.Windows.Themes.ResourceSet.GetSealedResource(global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.ResourcesInternal, typeof(global::Infragistics.Windows.DataPresenter.SummaryResultsPresenter)) as global::System.Windows.Style);
				}
				return global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_SummaryResultsPresenter;
			}
		}

		// Token: 0x17000D09 RID: 3337
		// (get) Token: 0x06002B45 RID: 11077 RVA: 0x000C03CF File Offset: 0x000BE5CF
		public static global::System.Windows.Style XamDataCards
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_XamDataCards == null)
				{
					global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_XamDataCards = (global::Infragistics.Windows.Themes.ResourceSet.GetSealedResource(global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.ResourcesInternal, typeof(global::Infragistics.Windows.DataPresenter.XamDataCards)) as global::System.Windows.Style);
				}
				return global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_XamDataCards;
			}
		}

		// Token: 0x17000D0A RID: 3338
		// (get) Token: 0x06002B46 RID: 11078 RVA: 0x000C03FB File Offset: 0x000BE5FB
		public static global::System.Windows.Style XamDataCarousel
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_XamDataCarousel == null)
				{
					global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_XamDataCarousel = (global::Infragistics.Windows.Themes.ResourceSet.GetSealedResource(global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.ResourcesInternal, typeof(global::Infragistics.Windows.DataPresenter.XamDataCarousel)) as global::System.Windows.Style);
				}
				return global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_XamDataCarousel;
			}
		}

		// Token: 0x17000D0B RID: 3339
		// (get) Token: 0x06002B47 RID: 11079 RVA: 0x000C0427 File Offset: 0x000BE627
		public static global::System.Windows.Style XamDataPresenter
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_XamDataPresenter == null)
				{
					global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_XamDataPresenter = (global::Infragistics.Windows.Themes.ResourceSet.GetSealedResource(global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.ResourcesInternal, typeof(global::Infragistics.Windows.DataPresenter.XamDataPresenter)) as global::System.Windows.Style);
				}
				return global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_XamDataPresenter;
			}
		}

		// Token: 0x17000D0C RID: 3340
		// (get) Token: 0x06002B48 RID: 11080 RVA: 0x000C0453 File Offset: 0x000BE653
		public static global::System.Windows.Style XamDataGrid
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_XamDataGrid == null)
				{
					global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_XamDataGrid = (global::Infragistics.Windows.Themes.ResourceSet.GetSealedResource(global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.ResourcesInternal, typeof(global::Infragistics.Windows.DataPresenter.XamDataGrid)) as global::System.Windows.Style);
				}
				return global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_XamDataGrid;
			}
		}

		// Token: 0x17000D0D RID: 3341
		// (get) Token: 0x06002B49 RID: 11081 RVA: 0x000C047F File Offset: 0x000BE67F
		public static global::System.Windows.Style XamTreeGrid
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_XamTreeGrid == null)
				{
					global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_XamTreeGrid = (global::Infragistics.Windows.Themes.ResourceSet.GetSealedResource(global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.ResourcesInternal, typeof(global::Infragistics.Windows.DataPresenter.XamTreeGrid)) as global::System.Windows.Style);
				}
				return global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.g_XamTreeGrid;
			}
		}

		// Token: 0x040014C6 RID: 5318
		internal const string GroupingName = "DataPresenter";

		// Token: 0x040014C7 RID: 5319
		[global::System.ThreadStatic]
		private static global::Infragistics.Windows.Themes.ResourceSetLocator g_Location;

		// Token: 0x040014C8 RID: 5320
		[global::System.ThreadStatic]
		private static global::System.Windows.ResourceDictionary g_ResourcesInternal;

		// Token: 0x040014C9 RID: 5321
		[global::System.ThreadStatic]
		private static global::System.Windows.Style g_CardHeaderPresenter;

		// Token: 0x040014CA RID: 5322
		[global::System.ThreadStatic]
		private static global::System.Windows.Style g_CardViewCard;

		// Token: 0x040014CB RID: 5323
		[global::System.ThreadStatic]
		private static global::System.Windows.Style g_CarouselBreadcrumbControl;

		// Token: 0x040014CC RID: 5324
		[global::System.ThreadStatic]
		private static global::System.Windows.Style g_CarouselBreadcrumb;

		// Token: 0x040014CD RID: 5325
		[global::System.ThreadStatic]
		private static global::System.Windows.Style g_CarouselItem;

		// Token: 0x040014CE RID: 5326
		[global::System.ThreadStatic]
		private static global::System.Windows.Style g_FieldDragIndicator;

		// Token: 0x040014CF RID: 5327
		[global::System.ThreadStatic]
		private static global::System.Windows.Style g_CustomFilterSelectionControl;

		// Token: 0x040014D0 RID: 5328
		[global::System.ThreadStatic]
		private static global::System.Windows.Style g_FilterButton;

		// Token: 0x040014D1 RID: 5329
		[global::System.ThreadStatic]
		private static global::System.Windows.Style g_FixedFieldButton;

		// Token: 0x040014D2 RID: 5330
		[global::System.ThreadStatic]
		private static global::System.Windows.Style g_FixedRecordButton;

		// Token: 0x040014D3 RID: 5331
		[global::System.ThreadStatic]
		private static global::System.Windows.Style g_Cell;

		// Token: 0x040014D4 RID: 5332
		[global::System.ThreadStatic]
		private static global::System.Windows.Style g_CellValue;

		// Token: 0x040014D5 RID: 5333
		private static global::System.Windows.Style g_TreeCellValue;

		// Token: 0x040014D6 RID: 5334
		[global::System.ThreadStatic]
		private static global::System.Windows.Style g_DataRecordPresenter;

		// Token: 0x040014D7 RID: 5335
		[global::System.ThreadStatic]
		private static global::System.Windows.Style g_DataRecordCellArea;

		// Token: 0x040014D8 RID: 5336
		[global::System.ThreadStatic]
		private static global::System.Windows.Style g_ExpandableFieldRecordPresenter;

		// Token: 0x040014D9 RID: 5337
		[global::System.ThreadStatic]
		private static global::System.Windows.Style g_ExpandedCellPresenter;

		// Token: 0x040014DA RID: 5338
		[global::System.ThreadStatic]
		private static global::System.Windows.Style g_FieldChooser;

		// Token: 0x040014DB RID: 5339
		[global::System.ThreadStatic]
		private static global::System.Windows.Style g_FieldMenuItem;

		// Token: 0x040014DC RID: 5340
		[global::System.ThreadStatic]
		private static global::System.Windows.Style g_FilterCellValuePresenter;

		// Token: 0x040014DD RID: 5341
		[global::System.ThreadStatic]
		private static global::System.Windows.Style g_FixedFieldSplitter;

		// Token: 0x040014DE RID: 5342
		[global::System.ThreadStatic]
		private static global::System.Windows.Style g_FieldLabel;

		// Token: 0x040014DF RID: 5343
		[global::System.ThreadStatic]
		private static global::System.Windows.Style g_GroupByArea;

		// Token: 0x040014E0 RID: 5344
		[global::System.ThreadStatic]
		private static global::System.Windows.Style g_GroupByAreaFieldLabel;

		// Token: 0x040014E1 RID: 5345
		[global::System.ThreadStatic]
		private static global::System.Windows.Style g_GroupByAreaFieldListBox;

		// Token: 0x040014E2 RID: 5346
		[global::System.ThreadStatic]
		private static global::System.Windows.Style g_GroupByAreaMulti;

		// Token: 0x040014E3 RID: 5347
		[global::System.ThreadStatic]
		private static global::System.Windows.Style g_GroupByRecordPresenter;

		// Token: 0x040014E4 RID: 5348
		[global::System.ThreadStatic]
		private static global::System.Windows.Style g_GroupBySummariesPresenter;

		// Token: 0x040014E5 RID: 5349
		[global::System.ThreadStatic]
		private static global::System.Windows.Style g_HeaderPresenter;

		// Token: 0x040014E6 RID: 5350
		[global::System.ThreadStatic]
		private static global::System.Windows.Style g_HeaderLabelArea;

		// Token: 0x040014E7 RID: 5351
		[global::System.ThreadStatic]
		private static global::System.Windows.Style g_HeaderPrefixArea;

		// Token: 0x040014E8 RID: 5352
		[global::System.ThreadStatic]
		private static global::System.Windows.Style g_RecordExportStatusControl;

		// Token: 0x040014E9 RID: 5353
		[global::System.ThreadStatic]
		private static global::System.Windows.Style g_RecordFilterTreeControl;

		// Token: 0x040014EA RID: 5354
		[global::System.ThreadStatic]
		private static global::System.Windows.Style g_RecordListControl;

		// Token: 0x040014EB RID: 5355
		[global::System.ThreadStatic]
		private static global::System.Windows.Style g_RecordScrollTip;

		// Token: 0x040014EC RID: 5356
		[global::System.ThreadStatic]
		private static global::System.Windows.Style g_RecordSelector;

		// Token: 0x040014ED RID: 5357
		[global::System.ThreadStatic]
		private static global::System.Windows.Style g_RecordSelectorNumber;

		// Token: 0x040014EE RID: 5358
		[global::System.ThreadStatic]
		private static global::System.Windows.Style g_SummaryButton;

		// Token: 0x040014EF RID: 5359
		[global::System.ThreadStatic]
		private static global::System.Windows.Style g_SummaryCalculatorSelectionControl;

		// Token: 0x040014F0 RID: 5360
		[global::System.ThreadStatic]
		private static global::System.Windows.Style g_SummaryCellPresenter;

		// Token: 0x040014F1 RID: 5361
		[global::System.ThreadStatic]
		private static global::System.Windows.Style g_SummaryRecordCellArea;

		// Token: 0x040014F2 RID: 5362
		[global::System.ThreadStatic]
		private static global::System.Windows.Style g_SummaryRecordContentArea;

		// Token: 0x040014F3 RID: 5363
		[global::System.ThreadStatic]
		private static global::System.Windows.Style g_SummaryRecordHeaderPresenter;

		// Token: 0x040014F4 RID: 5364
		[global::System.ThreadStatic]
		private static global::System.Windows.Style g_SummaryRecordPrefixArea;

		// Token: 0x040014F5 RID: 5365
		[global::System.ThreadStatic]
		private static global::System.Windows.Style g_SummaryRecordPresenter;

		// Token: 0x040014F6 RID: 5366
		[global::System.ThreadStatic]
		private static global::System.Windows.Style g_SummaryResultPresenter;

		// Token: 0x040014F7 RID: 5367
		[global::System.ThreadStatic]
		private static global::System.Windows.Style g_SummaryResultsPresenter;

		// Token: 0x040014F8 RID: 5368
		[global::System.ThreadStatic]
		private static global::System.Windows.Style g_XamDataCards;

		// Token: 0x040014F9 RID: 5369
		[global::System.ThreadStatic]
		private static global::System.Windows.Style g_XamDataCarousel;

		// Token: 0x040014FA RID: 5370
		[global::System.ThreadStatic]
		private static global::System.Windows.Style g_XamDataPresenter;

		// Token: 0x040014FB RID: 5371
		[global::System.ThreadStatic]
		private static global::System.Windows.Style g_XamDataGrid;

		// Token: 0x040014FC RID: 5372
		private static global::System.Windows.Style g_XamTreeGrid;
	}
}
