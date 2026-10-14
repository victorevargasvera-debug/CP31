using System;
using System.Windows;
using Infragistics.Windows.Editors;

namespace Infragistics.Windows.Themes
{
	// Token: 0x020000BD RID: 189
	public abstract class EditorsResourceSet<T> : global::Infragistics.Windows.Themes.ResourceSet where T : global::Infragistics.Windows.Themes.ResourceSetLocator, new()
	{
		// Token: 0x17000256 RID: 598
		// (get) Token: 0x06000A0C RID: 2572 RVA: 0x0002D830 File Offset: 0x0002BA30
		public override string Grouping
		{
			get
			{
				return global::Infragistics.Windows.Themes.EditorsResourceSet<T>.Location.Grouping;
			}
		}

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x06000A0D RID: 2573 RVA: 0x0002D83C File Offset: 0x0002BA3C
		public override string Theme
		{
			get
			{
				return global::Infragistics.Windows.Themes.EditorsResourceSet<T>.Location.Theme;
			}
		}

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x06000A0E RID: 2574 RVA: 0x0002D848 File Offset: 0x0002BA48
		public override global::System.Windows.ResourceDictionary Resources
		{
			get
			{
				global::System.Windows.ResourceDictionary resourcesInternal = global::Infragistics.Windows.Themes.EditorsResourceSet<T>.ResourcesInternal;
				base.VerifyResources();
				return resourcesInternal;
			}
		}

		// Token: 0x17000259 RID: 601
		// (get) Token: 0x06000A0F RID: 2575 RVA: 0x0002D862 File Offset: 0x0002BA62
		public static global::Infragistics.Windows.Themes.ResourceSetLocator Location
		{
			get
			{
				if (global::Infragistics.Windows.Themes.EditorsResourceSet<T>.g_Location == null)
				{
					global::Infragistics.Windows.Themes.EditorsResourceSet<T>.g_Location = global::System.Activator.CreateInstance<T>();
				}
				return global::Infragistics.Windows.Themes.EditorsResourceSet<T>.g_Location;
			}
		}

		// Token: 0x1700025A RID: 602
		// (get) Token: 0x06000A10 RID: 2576 RVA: 0x0002D87F File Offset: 0x0002BA7F
		private static global::System.Windows.ResourceDictionary ResourcesInternal
		{
			get
			{
				if (global::Infragistics.Windows.Themes.EditorsResourceSet<T>.g_ResourcesInternal == null)
				{
					global::Infragistics.Windows.Themes.EditorsResourceSet<T>.g_ResourcesInternal = global::Infragistics.Windows.Utilities.CreateResourceSetDictionary(global::Infragistics.Windows.Themes.EditorsResourceSet<T>.Location.Assembly, global::Infragistics.Windows.Themes.EditorsResourceSet<T>.Location.ResourcePath);
				}
				return global::Infragistics.Windows.Themes.EditorsResourceSet<T>.g_ResourcesInternal;
			}
		}

		// Token: 0x1700025B RID: 603
		// (get) Token: 0x06000A11 RID: 2577 RVA: 0x0002D8AB File Offset: 0x0002BAAB
		public static global::System.Windows.Style CaretElement
		{
			get
			{
				if (global::Infragistics.Windows.Themes.EditorsResourceSet<T>.g_CaretElement == null)
				{
					global::Infragistics.Windows.Themes.EditorsResourceSet<T>.g_CaretElement = (global::Infragistics.Windows.Themes.ResourceSet.GetSealedResource(global::Infragistics.Windows.Themes.EditorsResourceSet<T>.ResourcesInternal, typeof(global::Infragistics.Windows.Editors.CaretElement)) as global::System.Windows.Style);
				}
				return global::Infragistics.Windows.Themes.EditorsResourceSet<T>.g_CaretElement;
			}
		}

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x06000A12 RID: 2578 RVA: 0x0002D8D7 File Offset: 0x0002BAD7
		public static global::System.Windows.Style DisplayCharactersList
		{
			get
			{
				if (global::Infragistics.Windows.Themes.EditorsResourceSet<T>.g_DisplayCharactersList == null)
				{
					global::Infragistics.Windows.Themes.EditorsResourceSet<T>.g_DisplayCharactersList = (global::Infragistics.Windows.Themes.ResourceSet.GetSealedResource(global::Infragistics.Windows.Themes.EditorsResourceSet<T>.ResourcesInternal, typeof(global::Infragistics.Windows.Editors.DisplayCharactersList)) as global::System.Windows.Style);
				}
				return global::Infragistics.Windows.Themes.EditorsResourceSet<T>.g_DisplayCharactersList;
			}
		}

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x06000A13 RID: 2579 RVA: 0x0002D903 File Offset: 0x0002BB03
		public static global::System.Windows.Style DisplayCharacterPresenter
		{
			get
			{
				if (global::Infragistics.Windows.Themes.EditorsResourceSet<T>.g_DisplayCharacterPresenter == null)
				{
					global::Infragistics.Windows.Themes.EditorsResourceSet<T>.g_DisplayCharacterPresenter = (global::Infragistics.Windows.Themes.ResourceSet.GetSealedResource(global::Infragistics.Windows.Themes.EditorsResourceSet<T>.ResourcesInternal, typeof(global::Infragistics.Windows.Editors.DisplayCharacterPresenter)) as global::System.Windows.Style);
				}
				return global::Infragistics.Windows.Themes.EditorsResourceSet<T>.g_DisplayCharacterPresenter;
			}
		}

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x06000A14 RID: 2580 RVA: 0x0002D92F File Offset: 0x0002BB2F
		public static global::System.Windows.Style SectionsList
		{
			get
			{
				if (global::Infragistics.Windows.Themes.EditorsResourceSet<T>.g_SectionsList == null)
				{
					global::Infragistics.Windows.Themes.EditorsResourceSet<T>.g_SectionsList = (global::Infragistics.Windows.Themes.ResourceSet.GetSealedResource(global::Infragistics.Windows.Themes.EditorsResourceSet<T>.ResourcesInternal, typeof(global::Infragistics.Windows.Editors.SectionsList)) as global::System.Windows.Style);
				}
				return global::Infragistics.Windows.Themes.EditorsResourceSet<T>.g_SectionsList;
			}
		}

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x06000A15 RID: 2581 RVA: 0x0002D95B File Offset: 0x0002BB5B
		public static global::System.Windows.Style SectionPresenter
		{
			get
			{
				if (global::Infragistics.Windows.Themes.EditorsResourceSet<T>.g_SectionPresenter == null)
				{
					global::Infragistics.Windows.Themes.EditorsResourceSet<T>.g_SectionPresenter = (global::Infragistics.Windows.Themes.ResourceSet.GetSealedResource(global::Infragistics.Windows.Themes.EditorsResourceSet<T>.ResourcesInternal, typeof(global::Infragistics.Windows.Editors.SectionPresenter)) as global::System.Windows.Style);
				}
				return global::Infragistics.Windows.Themes.EditorsResourceSet<T>.g_SectionPresenter;
			}
		}

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x06000A16 RID: 2582 RVA: 0x0002D987 File Offset: 0x0002BB87
		public static global::System.Windows.Style XamCurrencyEditor
		{
			get
			{
				if (global::Infragistics.Windows.Themes.EditorsResourceSet<T>.g_XamCurrencyEditor == null)
				{
					global::Infragistics.Windows.Themes.EditorsResourceSet<T>.g_XamCurrencyEditor = (global::Infragistics.Windows.Themes.ResourceSet.GetSealedResource(global::Infragistics.Windows.Themes.EditorsResourceSet<T>.ResourcesInternal, typeof(global::Infragistics.Windows.Editors.XamCurrencyEditor)) as global::System.Windows.Style);
				}
				return global::Infragistics.Windows.Themes.EditorsResourceSet<T>.g_XamCurrencyEditor;
			}
		}

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x06000A17 RID: 2583 RVA: 0x0002D9B3 File Offset: 0x0002BBB3
		public static global::System.Windows.Style XamDateTimeEditor
		{
			get
			{
				if (global::Infragistics.Windows.Themes.EditorsResourceSet<T>.g_XamDateTimeEditor == null)
				{
					global::Infragistics.Windows.Themes.EditorsResourceSet<T>.g_XamDateTimeEditor = (global::Infragistics.Windows.Themes.ResourceSet.GetSealedResource(global::Infragistics.Windows.Themes.EditorsResourceSet<T>.ResourcesInternal, typeof(global::Infragistics.Windows.Editors.XamDateTimeEditor)) as global::System.Windows.Style);
				}
				return global::Infragistics.Windows.Themes.EditorsResourceSet<T>.g_XamDateTimeEditor;
			}
		}

		// Token: 0x17000262 RID: 610
		// (get) Token: 0x06000A18 RID: 2584 RVA: 0x0002D9DF File Offset: 0x0002BBDF
		public static global::System.Windows.Style XamMaskedEditor
		{
			get
			{
				if (global::Infragistics.Windows.Themes.EditorsResourceSet<T>.g_MaskedEditor == null)
				{
					global::Infragistics.Windows.Themes.EditorsResourceSet<T>.g_MaskedEditor = (global::Infragistics.Windows.Themes.ResourceSet.GetSealedResource(global::Infragistics.Windows.Themes.EditorsResourceSet<T>.ResourcesInternal, typeof(global::Infragistics.Windows.Editors.XamMaskedEditor)) as global::System.Windows.Style);
				}
				return global::Infragistics.Windows.Themes.EditorsResourceSet<T>.g_MaskedEditor;
			}
		}

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x06000A19 RID: 2585 RVA: 0x0002DA0B File Offset: 0x0002BC0B
		public static global::System.Windows.Style XamNumericEditor
		{
			get
			{
				if (global::Infragistics.Windows.Themes.EditorsResourceSet<T>.g_XamNumericEditor == null)
				{
					global::Infragistics.Windows.Themes.EditorsResourceSet<T>.g_XamNumericEditor = (global::Infragistics.Windows.Themes.ResourceSet.GetSealedResource(global::Infragistics.Windows.Themes.EditorsResourceSet<T>.ResourcesInternal, typeof(global::Infragistics.Windows.Editors.XamNumericEditor)) as global::System.Windows.Style);
				}
				return global::Infragistics.Windows.Themes.EditorsResourceSet<T>.g_XamNumericEditor;
			}
		}

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x06000A1A RID: 2586 RVA: 0x0002DA37 File Offset: 0x0002BC37
		public static global::System.Windows.Style XamComboEditor
		{
			get
			{
				if (global::Infragistics.Windows.Themes.EditorsResourceSet<T>.g_XamComboEditor == null)
				{
					global::Infragistics.Windows.Themes.EditorsResourceSet<T>.g_XamComboEditor = (global::Infragistics.Windows.Themes.ResourceSet.GetSealedResource(global::Infragistics.Windows.Themes.EditorsResourceSet<T>.ResourcesInternal, typeof(global::Infragistics.Windows.Editors.XamComboEditor)) as global::System.Windows.Style);
				}
				return global::Infragistics.Windows.Themes.EditorsResourceSet<T>.g_XamComboEditor;
			}
		}

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x06000A1B RID: 2587 RVA: 0x0002DA63 File Offset: 0x0002BC63
		public static global::System.Windows.Style XamComboEditorComboBox
		{
			get
			{
				if (global::Infragistics.Windows.Themes.EditorsResourceSet<T>.g_XamComboEditorComboBox == null)
				{
					global::Infragistics.Windows.Themes.EditorsResourceSet<T>.g_XamComboEditorComboBox = (global::Infragistics.Windows.Themes.ResourceSet.GetSealedResource(global::Infragistics.Windows.Themes.EditorsResourceSet<T>.ResourcesInternal, global::Infragistics.Windows.Editors.XamComboEditor.ComboEditorComboBoxStyleKey) as global::System.Windows.Style);
				}
				return global::Infragistics.Windows.Themes.EditorsResourceSet<T>.g_XamComboEditorComboBox;
			}
		}

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x06000A1C RID: 2588 RVA: 0x0002DA8A File Offset: 0x0002BC8A
		public static global::System.Windows.Style XamComboEditorDropDownButton
		{
			get
			{
				if (global::Infragistics.Windows.Themes.EditorsResourceSet<T>.g_XamComboEditorDropDownButton == null)
				{
					global::Infragistics.Windows.Themes.EditorsResourceSet<T>.g_XamComboEditorDropDownButton = (global::Infragistics.Windows.Themes.ResourceSet.GetSealedResource(global::Infragistics.Windows.Themes.EditorsResourceSet<T>.ResourcesInternal, "ComboEditor_DropDownButtonStyle") as global::System.Windows.Style);
				}
				return global::Infragistics.Windows.Themes.EditorsResourceSet<T>.g_XamComboEditorDropDownButton;
			}
		}

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x06000A1D RID: 2589 RVA: 0x0002DAB1 File Offset: 0x0002BCB1
		public static global::System.Windows.Style CalendarItem
		{
			get
			{
				if (global::Infragistics.Windows.Themes.EditorsResourceSet<T>.g_CalendarItem == null)
				{
					global::Infragistics.Windows.Themes.EditorsResourceSet<T>.g_CalendarItem = (global::Infragistics.Windows.Themes.ResourceSet.GetSealedResource(global::Infragistics.Windows.Themes.EditorsResourceSet<T>.ResourcesInternal, typeof(global::Infragistics.Windows.Editors.CalendarItem)) as global::System.Windows.Style);
				}
				return global::Infragistics.Windows.Themes.EditorsResourceSet<T>.g_CalendarItem;
			}
		}

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x06000A1E RID: 2590 RVA: 0x0002DADD File Offset: 0x0002BCDD
		public static global::System.Windows.Style CalendarItemGroup
		{
			get
			{
				if (global::Infragistics.Windows.Themes.EditorsResourceSet<T>.g_CalendarItemGroup == null)
				{
					global::Infragistics.Windows.Themes.EditorsResourceSet<T>.g_CalendarItemGroup = (global::Infragistics.Windows.Themes.ResourceSet.GetSealedResource(global::Infragistics.Windows.Themes.EditorsResourceSet<T>.ResourcesInternal, typeof(global::Infragistics.Windows.Editors.CalendarItemGroup)) as global::System.Windows.Style);
				}
				return global::Infragistics.Windows.Themes.EditorsResourceSet<T>.g_CalendarItemGroup;
			}
		}

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x06000A1F RID: 2591 RVA: 0x0002DB09 File Offset: 0x0002BD09
		public static global::System.Windows.Style CalendarDayOfWeek
		{
			get
			{
				if (global::Infragistics.Windows.Themes.EditorsResourceSet<T>.g_CalendarDayOfWeek == null)
				{
					global::Infragistics.Windows.Themes.EditorsResourceSet<T>.g_CalendarDayOfWeek = (global::Infragistics.Windows.Themes.ResourceSet.GetSealedResource(global::Infragistics.Windows.Themes.EditorsResourceSet<T>.ResourcesInternal, typeof(global::Infragistics.Windows.Editors.CalendarDayOfWeek)) as global::System.Windows.Style);
				}
				return global::Infragistics.Windows.Themes.EditorsResourceSet<T>.g_CalendarDayOfWeek;
			}
		}

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x06000A20 RID: 2592 RVA: 0x0002DB35 File Offset: 0x0002BD35
		public static global::System.Windows.Style CalendarItemArea
		{
			get
			{
				if (global::Infragistics.Windows.Themes.EditorsResourceSet<T>.g_CalendarItemArea == null)
				{
					global::Infragistics.Windows.Themes.EditorsResourceSet<T>.g_CalendarItemArea = (global::Infragistics.Windows.Themes.ResourceSet.GetSealedResource(global::Infragistics.Windows.Themes.EditorsResourceSet<T>.ResourcesInternal, typeof(global::Infragistics.Windows.Editors.CalendarItemArea)) as global::System.Windows.Style);
				}
				return global::Infragistics.Windows.Themes.EditorsResourceSet<T>.g_CalendarItemArea;
			}
		}

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x06000A21 RID: 2593 RVA: 0x0002DB61 File Offset: 0x0002BD61
		public static global::System.Windows.Style CalendarItemGroupTitle
		{
			get
			{
				if (global::Infragistics.Windows.Themes.EditorsResourceSet<T>.g_CalendarItemGroupTitle == null)
				{
					global::Infragistics.Windows.Themes.EditorsResourceSet<T>.g_CalendarItemGroupTitle = (global::Infragistics.Windows.Themes.ResourceSet.GetSealedResource(global::Infragistics.Windows.Themes.EditorsResourceSet<T>.ResourcesInternal, typeof(global::Infragistics.Windows.Editors.CalendarItemGroupTitle)) as global::System.Windows.Style);
				}
				return global::Infragistics.Windows.Themes.EditorsResourceSet<T>.g_CalendarItemGroupTitle;
			}
		}

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x06000A22 RID: 2594 RVA: 0x0002DB8D File Offset: 0x0002BD8D
		public static global::System.Windows.Style CalendarDay
		{
			get
			{
				if (global::Infragistics.Windows.Themes.EditorsResourceSet<T>.g_CalendarDay == null)
				{
					global::Infragistics.Windows.Themes.EditorsResourceSet<T>.g_CalendarDay = (global::Infragistics.Windows.Themes.ResourceSet.GetSealedResource(global::Infragistics.Windows.Themes.EditorsResourceSet<T>.ResourcesInternal, typeof(global::Infragistics.Windows.Editors.CalendarDay)) as global::System.Windows.Style);
				}
				return global::Infragistics.Windows.Themes.EditorsResourceSet<T>.g_CalendarDay;
			}
		}

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x06000A23 RID: 2595 RVA: 0x0002DBB9 File Offset: 0x0002BDB9
		public static global::System.Windows.Style XamMonthCalendar
		{
			get
			{
				if (global::Infragistics.Windows.Themes.EditorsResourceSet<T>.g_XamMonthCalendar == null)
				{
					global::Infragistics.Windows.Themes.EditorsResourceSet<T>.g_XamMonthCalendar = (global::Infragistics.Windows.Themes.ResourceSet.GetSealedResource(global::Infragistics.Windows.Themes.EditorsResourceSet<T>.ResourcesInternal, typeof(global::Infragistics.Windows.Editors.XamMonthCalendar)) as global::System.Windows.Style);
				}
				return global::Infragistics.Windows.Themes.EditorsResourceSet<T>.g_XamMonthCalendar;
			}
		}

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x06000A24 RID: 2596 RVA: 0x0002DBE5 File Offset: 0x0002BDE5
		public static global::System.Windows.Style CalendarWeekNumber
		{
			get
			{
				if (global::Infragistics.Windows.Themes.EditorsResourceSet<T>.g_CalendarWeekNumber == null)
				{
					global::Infragistics.Windows.Themes.EditorsResourceSet<T>.g_CalendarWeekNumber = (global::Infragistics.Windows.Themes.ResourceSet.GetSealedResource(global::Infragistics.Windows.Themes.EditorsResourceSet<T>.ResourcesInternal, typeof(global::Infragistics.Windows.Editors.CalendarWeekNumber)) as global::System.Windows.Style);
				}
				return global::Infragistics.Windows.Themes.EditorsResourceSet<T>.g_CalendarWeekNumber;
			}
		}

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x06000A25 RID: 2597 RVA: 0x0002DC11 File Offset: 0x0002BE11
		public static global::System.Windows.Style XamCheckEditor
		{
			get
			{
				if (global::Infragistics.Windows.Themes.EditorsResourceSet<T>.g_XamCheckEditor == null)
				{
					global::Infragistics.Windows.Themes.EditorsResourceSet<T>.g_XamCheckEditor = (global::Infragistics.Windows.Themes.ResourceSet.GetSealedResource(global::Infragistics.Windows.Themes.EditorsResourceSet<T>.ResourcesInternal, typeof(global::Infragistics.Windows.Editors.XamCheckEditor)) as global::System.Windows.Style);
				}
				return global::Infragistics.Windows.Themes.EditorsResourceSet<T>.g_XamCheckEditor;
			}
		}

		// Token: 0x17000270 RID: 624
		// (get) Token: 0x06000A26 RID: 2598 RVA: 0x0002DC3D File Offset: 0x0002BE3D
		public static global::System.Windows.Style XamTextEditor
		{
			get
			{
				if (global::Infragistics.Windows.Themes.EditorsResourceSet<T>.g_XamTextEditor == null)
				{
					global::Infragistics.Windows.Themes.EditorsResourceSet<T>.g_XamTextEditor = (global::Infragistics.Windows.Themes.ResourceSet.GetSealedResource(global::Infragistics.Windows.Themes.EditorsResourceSet<T>.ResourcesInternal, typeof(global::Infragistics.Windows.Editors.XamTextEditor)) as global::System.Windows.Style);
				}
				return global::Infragistics.Windows.Themes.EditorsResourceSet<T>.g_XamTextEditor;
			}
		}

		// Token: 0x0400038B RID: 907
		internal const string GroupingName = "Editors";

		// Token: 0x0400038C RID: 908
		private static global::Infragistics.Windows.Themes.ResourceSetLocator g_Location;

		// Token: 0x0400038D RID: 909
		private static global::System.Windows.ResourceDictionary g_ResourcesInternal;

		// Token: 0x0400038E RID: 910
		private static global::System.Windows.Style g_CaretElement;

		// Token: 0x0400038F RID: 911
		private static global::System.Windows.Style g_DisplayCharactersList;

		// Token: 0x04000390 RID: 912
		private static global::System.Windows.Style g_DisplayCharacterPresenter;

		// Token: 0x04000391 RID: 913
		private static global::System.Windows.Style g_SectionsList;

		// Token: 0x04000392 RID: 914
		private static global::System.Windows.Style g_SectionPresenter;

		// Token: 0x04000393 RID: 915
		private static global::System.Windows.Style g_XamCurrencyEditor;

		// Token: 0x04000394 RID: 916
		private static global::System.Windows.Style g_XamDateTimeEditor;

		// Token: 0x04000395 RID: 917
		private static global::System.Windows.Style g_MaskedEditor;

		// Token: 0x04000396 RID: 918
		private static global::System.Windows.Style g_XamNumericEditor;

		// Token: 0x04000397 RID: 919
		private static global::System.Windows.Style g_XamComboEditor;

		// Token: 0x04000398 RID: 920
		private static global::System.Windows.Style g_XamComboEditorComboBox;

		// Token: 0x04000399 RID: 921
		private static global::System.Windows.Style g_XamComboEditorDropDownButton;

		// Token: 0x0400039A RID: 922
		private static global::System.Windows.Style g_CalendarItem;

		// Token: 0x0400039B RID: 923
		private static global::System.Windows.Style g_CalendarItemGroup;

		// Token: 0x0400039C RID: 924
		private static global::System.Windows.Style g_CalendarDayOfWeek;

		// Token: 0x0400039D RID: 925
		private static global::System.Windows.Style g_CalendarItemArea;

		// Token: 0x0400039E RID: 926
		private static global::System.Windows.Style g_CalendarItemGroupTitle;

		// Token: 0x0400039F RID: 927
		private static global::System.Windows.Style g_CalendarDay;

		// Token: 0x040003A0 RID: 928
		private static global::System.Windows.Style g_XamMonthCalendar;

		// Token: 0x040003A1 RID: 929
		private static global::System.Windows.Style g_CalendarWeekNumber;

		// Token: 0x040003A2 RID: 930
		private static global::System.Windows.Style g_XamCheckEditor;

		// Token: 0x040003A3 RID: 931
		private static global::System.Windows.Style g_XamTextEditor;
	}
}
