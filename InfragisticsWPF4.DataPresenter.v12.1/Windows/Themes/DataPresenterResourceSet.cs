using System;
using System.Windows;
using Infragistics.Windows.DataPresenter;

namespace Infragistics.Windows.Themes
{
	// Token: 0x0200032F RID: 815
	public abstract class DataPresenterResourceSet<T> : global::Infragistics.Windows.Themes.ResourceSet where T : global::Infragistics.Windows.Themes.ResourceSetLocator, new()
	{
		// Token: 0x17000B8A RID: 2954
		// (get) Token: 0x0600273A RID: 10042 RVA: 0x000AAFFA File Offset: 0x000A91FA
		public override string Grouping
		{
			get
			{
				return global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.Location.Grouping;
			}
		}

		// Token: 0x17000B8B RID: 2955
		// (get) Token: 0x0600273B RID: 10043 RVA: 0x000AB006 File Offset: 0x000A9206
		public override string Theme
		{
			get
			{
				return global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.Location.Theme;
			}
		}

		// Token: 0x17000B8C RID: 2956
		// (get) Token: 0x0600273C RID: 10044 RVA: 0x000AB014 File Offset: 0x000A9214
		public override global::System.Windows.ResourceDictionary Resources
		{
			get
			{
				global::System.Windows.ResourceDictionary resourcesInternal = global::Infragistics.Windows.Themes.DataPresenterResourceSet<T>.ResourcesInternal;
				base.VerifyResources();
				return resourcesInternal;
			}
		}

		// Token: 0x17000B8D RID: 2957
		// (get) Token: 0x0600273D RID: 10045 RVA: 0x000AB02E File Offset: 0x000A922E
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

		// Token: 0x17000B8E RID: 2958
		// (get) Token: 0x0600273E RID: 10046 RVA: 0x000AB04B File Offset: 0x000A924B
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

		// Token: 0x17000B8F RID: 2959
		// (get) Token: 0x0600273F RID: 10047 RVA: 0x000AB077 File Offset: 0x000A9277
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

		// Token: 0x17000B90 RID: 2960
		// (get) Token: 0x06002740 RID: 10048 RVA: 0x000AB0A3 File Offset: 0x000A92A3
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

		// Token: 0x17000B91 RID: 2961
		// (get) Token: 0x06002741 RID: 10049 RVA: 0x000AB0CF File Offset: 0x000A92CF
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

		// Token: 0x17000B92 RID: 2962
		// (get) Token: 0x06002742 RID: 10050 RVA: 0x000AB0FB File Offset: 0x000A92FB
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

		// Token: 0x17000B93 RID: 2963
		// (get) Token: 0x06002743 RID: 10051 RVA: 0x000AB127 File Offset: 0x000A9327
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

		// Token: 0x17000B94 RID: 2964
		// (get) Token: 0x06002744 RID: 10052 RVA: 0x000AB153 File Offset: 0x000A9353
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

		// Token: 0x17000B95 RID: 2965
		// (get) Token: 0x06002745 RID: 10053 RVA: 0x000AB17F File Offset: 0x000A937F
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

		// Token: 0x17000B96 RID: 2966
		// (get) Token: 0x06002746 RID: 10054 RVA: 0x000AB1AB File Offset: 0x000A93AB
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

		// Token: 0x17000B97 RID: 2967
		// (get) Token: 0x06002747 RID: 10055 RVA: 0x000AB1D7 File Offset: 0x000A93D7
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

		// Token: 0x17000B98 RID: 2968
		// (get) Token: 0x06002748 RID: 10056 RVA: 0x000AB203 File Offset: 0x000A9403
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

		// Token: 0x17000B99 RID: 2969
		// (get) Token: 0x06002749 RID: 10057 RVA: 0x000AB22F File Offset: 0x000A942F
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

		// Token: 0x17000B9A RID: 2970
		// (get) Token: 0x0600274A RID: 10058 RVA: 0x000AB25B File Offset: 0x000A945B
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

		// Token: 0x17000B9B RID: 2971
		// (get) Token: 0x0600274B RID: 10059 RVA: 0x000AB287 File Offset: 0x000A9487
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

		// Token: 0x17000B9C RID: 2972
		// (get) Token: 0x0600274C RID: 10060 RVA: 0x000AB2B3 File Offset: 0x000A94B3
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

		// Token: 0x17000B9D RID: 2973
		// (get) Token: 0x0600274D RID: 10061 RVA: 0x000AB2DF File Offset: 0x000A94DF
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

		// Token: 0x17000B9E RID: 2974
		// (get) Token: 0x0600274E RID: 10062 RVA: 0x000AB30B File Offset: 0x000A950B
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

		// Token: 0x17000B9F RID: 2975
		// (get) Token: 0x0600274F RID: 10063 RVA: 0x000AB337 File Offset: 0x000A9537
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

		// Token: 0x17000BA0 RID: 2976
		// (get) Token: 0x06002750 RID: 10064 RVA: 0x000AB363 File Offset: 0x000A9563
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

		// Token: 0x17000BA1 RID: 2977
		// (get) Token: 0x06002751 RID: 10065 RVA: 0x000AB38F File Offset: 0x000A958F
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

		// Token: 0x17000BA2 RID: 2978
		// (get) Token: 0x06002752 RID: 10066 RVA: 0x000AB3BB File Offset: 0x000A95BB
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

		// Token: 0x17000BA3 RID: 2979
		// (get) Token: 0x06002753 RID: 10067 RVA: 0x000AB3E7 File Offset: 0x000A95E7
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

		// Token: 0x17000BA4 RID: 2980
		// (get) Token: 0x06002754 RID: 10068 RVA: 0x000AB413 File Offset: 0x000A9613
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

		// Token: 0x17000BA5 RID: 2981
		// (get) Token: 0x06002755 RID: 10069 RVA: 0x000AB43F File Offset: 0x000A963F
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

		// Token: 0x17000BA6 RID: 2982
		// (get) Token: 0x06002756 RID: 10070 RVA: 0x000AB46B File Offset: 0x000A966B
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

		// Token: 0x17000BA7 RID: 2983
		// (get) Token: 0x06002757 RID: 10071 RVA: 0x000AB497 File Offset: 0x000A9697
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

		// Token: 0x17000BA8 RID: 2984
		// (get) Token: 0x06002758 RID: 10072 RVA: 0x000AB4C3 File Offset: 0x000A96C3
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

		// Token: 0x17000BA9 RID: 2985
		// (get) Token: 0x06002759 RID: 10073 RVA: 0x000AB4EF File Offset: 0x000A96EF
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

		// Token: 0x17000BAA RID: 2986
		// (get) Token: 0x0600275A RID: 10074 RVA: 0x000AB51B File Offset: 0x000A971B
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

		// Token: 0x17000BAB RID: 2987
		// (get) Token: 0x0600275B RID: 10075 RVA: 0x000AB547 File Offset: 0x000A9747
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

		// Token: 0x17000BAC RID: 2988
		// (get) Token: 0x0600275C RID: 10076 RVA: 0x000AB573 File Offset: 0x000A9773
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

		// Token: 0x17000BAD RID: 2989
		// (get) Token: 0x0600275D RID: 10077 RVA: 0x000AB59F File Offset: 0x000A979F
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

		// Token: 0x17000BAE RID: 2990
		// (get) Token: 0x0600275E RID: 10078 RVA: 0x000AB5CB File Offset: 0x000A97CB
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

		// Token: 0x17000BAF RID: 2991
		// (get) Token: 0x0600275F RID: 10079 RVA: 0x000AB5F7 File Offset: 0x000A97F7
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

		// Token: 0x17000BB0 RID: 2992
		// (get) Token: 0x06002760 RID: 10080 RVA: 0x000AB623 File Offset: 0x000A9823
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

		// Token: 0x17000BB1 RID: 2993
		// (get) Token: 0x06002761 RID: 10081 RVA: 0x000AB64F File Offset: 0x000A984F
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

		// Token: 0x17000BB2 RID: 2994
		// (get) Token: 0x06002762 RID: 10082 RVA: 0x000AB67B File Offset: 0x000A987B
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

		// Token: 0x17000BB3 RID: 2995
		// (get) Token: 0x06002763 RID: 10083 RVA: 0x000AB6A7 File Offset: 0x000A98A7
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

		// Token: 0x17000BB4 RID: 2996
		// (get) Token: 0x06002764 RID: 10084 RVA: 0x000AB6D3 File Offset: 0x000A98D3
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

		// Token: 0x17000BB5 RID: 2997
		// (get) Token: 0x06002765 RID: 10085 RVA: 0x000AB6FF File Offset: 0x000A98FF
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

		// Token: 0x17000BB6 RID: 2998
		// (get) Token: 0x06002766 RID: 10086 RVA: 0x000AB72B File Offset: 0x000A992B
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

		// Token: 0x17000BB7 RID: 2999
		// (get) Token: 0x06002767 RID: 10087 RVA: 0x000AB757 File Offset: 0x000A9957
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

		// Token: 0x17000BB8 RID: 3000
		// (get) Token: 0x06002768 RID: 10088 RVA: 0x000AB783 File Offset: 0x000A9983
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

		// Token: 0x17000BB9 RID: 3001
		// (get) Token: 0x06002769 RID: 10089 RVA: 0x000AB7AF File Offset: 0x000A99AF
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

		// Token: 0x17000BBA RID: 3002
		// (get) Token: 0x0600276A RID: 10090 RVA: 0x000AB7DB File Offset: 0x000A99DB
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

		// Token: 0x17000BBB RID: 3003
		// (get) Token: 0x0600276B RID: 10091 RVA: 0x000AB807 File Offset: 0x000A9A07
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

		// Token: 0x17000BBC RID: 3004
		// (get) Token: 0x0600276C RID: 10092 RVA: 0x000AB833 File Offset: 0x000A9A33
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

		// Token: 0x17000BBD RID: 3005
		// (get) Token: 0x0600276D RID: 10093 RVA: 0x000AB85F File Offset: 0x000A9A5F
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

		// Token: 0x17000BBE RID: 3006
		// (get) Token: 0x0600276E RID: 10094 RVA: 0x000AB88B File Offset: 0x000A9A8B
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

		// Token: 0x17000BBF RID: 3007
		// (get) Token: 0x0600276F RID: 10095 RVA: 0x000AB8B7 File Offset: 0x000A9AB7
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

		// Token: 0x040012A3 RID: 4771
		internal const string GroupingName = "DataPresenter";

		// Token: 0x040012A4 RID: 4772
		private static global::Infragistics.Windows.Themes.ResourceSetLocator g_Location;

		// Token: 0x040012A5 RID: 4773
		private static global::System.Windows.ResourceDictionary g_ResourcesInternal;

		// Token: 0x040012A6 RID: 4774
		private static global::System.Windows.Style g_CardHeaderPresenter;

		// Token: 0x040012A7 RID: 4775
		private static global::System.Windows.Style g_CardViewCard;

		// Token: 0x040012A8 RID: 4776
		private static global::System.Windows.Style g_CarouselBreadcrumbControl;

		// Token: 0x040012A9 RID: 4777
		private static global::System.Windows.Style g_CarouselBreadcrumb;

		// Token: 0x040012AA RID: 4778
		private static global::System.Windows.Style g_CarouselItem;

		// Token: 0x040012AB RID: 4779
		private static global::System.Windows.Style g_FieldDragIndicator;

		// Token: 0x040012AC RID: 4780
		private static global::System.Windows.Style g_CustomFilterSelectionControl;

		// Token: 0x040012AD RID: 4781
		private static global::System.Windows.Style g_FilterButton;

		// Token: 0x040012AE RID: 4782
		private static global::System.Windows.Style g_FixedFieldButton;

		// Token: 0x040012AF RID: 4783
		private static global::System.Windows.Style g_FixedRecordButton;

		// Token: 0x040012B0 RID: 4784
		private static global::System.Windows.Style g_Cell;

		// Token: 0x040012B1 RID: 4785
		private static global::System.Windows.Style g_CellValue;

		// Token: 0x040012B2 RID: 4786
		private static global::System.Windows.Style g_DataRecordPresenter;

		// Token: 0x040012B3 RID: 4787
		private static global::System.Windows.Style g_DataRecordCellArea;

		// Token: 0x040012B4 RID: 4788
		private static global::System.Windows.Style g_ExpandableFieldRecordPresenter;

		// Token: 0x040012B5 RID: 4789
		private static global::System.Windows.Style g_ExpandedCellPresenter;

		// Token: 0x040012B6 RID: 4790
		private static global::System.Windows.Style g_FieldChooser;

		// Token: 0x040012B7 RID: 4791
		private static global::System.Windows.Style g_FieldMenuItem;

		// Token: 0x040012B8 RID: 4792
		private static global::System.Windows.Style g_FilterCellValuePresenter;

		// Token: 0x040012B9 RID: 4793
		private static global::System.Windows.Style g_FixedFieldSplitter;

		// Token: 0x040012BA RID: 4794
		private static global::System.Windows.Style g_FieldLabel;

		// Token: 0x040012BB RID: 4795
		private static global::System.Windows.Style g_GroupByArea;

		// Token: 0x040012BC RID: 4796
		private static global::System.Windows.Style g_GroupByAreaFieldLabel;

		// Token: 0x040012BD RID: 4797
		private static global::System.Windows.Style g_GroupByAreaFieldListBox;

		// Token: 0x040012BE RID: 4798
		private static global::System.Windows.Style g_GroupByAreaMulti;

		// Token: 0x040012BF RID: 4799
		private static global::System.Windows.Style g_GroupByRecordPresenter;

		// Token: 0x040012C0 RID: 4800
		private static global::System.Windows.Style g_GroupBySummariesPresenter;

		// Token: 0x040012C1 RID: 4801
		private static global::System.Windows.Style g_HeaderPresenter;

		// Token: 0x040012C2 RID: 4802
		private static global::System.Windows.Style g_HeaderLabelArea;

		// Token: 0x040012C3 RID: 4803
		private static global::System.Windows.Style g_HeaderPrefixArea;

		// Token: 0x040012C4 RID: 4804
		private static global::System.Windows.Style g_RecordExportStatusControl;

		// Token: 0x040012C5 RID: 4805
		private static global::System.Windows.Style g_RecordFilterTreeControl;

		// Token: 0x040012C6 RID: 4806
		private static global::System.Windows.Style g_RecordListControl;

		// Token: 0x040012C7 RID: 4807
		private static global::System.Windows.Style g_RecordScrollTip;

		// Token: 0x040012C8 RID: 4808
		private static global::System.Windows.Style g_RecordSelector;

		// Token: 0x040012C9 RID: 4809
		private static global::System.Windows.Style g_SummaryButton;

		// Token: 0x040012CA RID: 4810
		private static global::System.Windows.Style g_SummaryCalculatorSelectionControl;

		// Token: 0x040012CB RID: 4811
		private static global::System.Windows.Style g_SummaryCellPresenter;

		// Token: 0x040012CC RID: 4812
		private static global::System.Windows.Style g_SummaryRecordCellArea;

		// Token: 0x040012CD RID: 4813
		private static global::System.Windows.Style g_SummaryRecordContentArea;

		// Token: 0x040012CE RID: 4814
		private static global::System.Windows.Style g_SummaryRecordHeaderPresenter;

		// Token: 0x040012CF RID: 4815
		private static global::System.Windows.Style g_SummaryRecordPrefixArea;

		// Token: 0x040012D0 RID: 4816
		private static global::System.Windows.Style g_SummaryRecordPresenter;

		// Token: 0x040012D1 RID: 4817
		private static global::System.Windows.Style g_SummaryResultPresenter;

		// Token: 0x040012D2 RID: 4818
		private static global::System.Windows.Style g_SummaryResultsPresenter;

		// Token: 0x040012D3 RID: 4819
		private static global::System.Windows.Style g_XamDataCards;

		// Token: 0x040012D4 RID: 4820
		private static global::System.Windows.Style g_XamDataCarousel;

		// Token: 0x040012D5 RID: 4821
		private static global::System.Windows.Style g_XamDataPresenter;

		// Token: 0x040012D6 RID: 4822
		private static global::System.Windows.Style g_XamDataGrid;
	}
}
