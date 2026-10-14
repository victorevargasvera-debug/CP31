using System;
using System.Windows;
using Infragistics.Windows.Editors;

namespace Infragistics.Windows.Themes
{
	// Token: 0x020000C5 RID: 197
	public abstract class EditorsResourceSet<T> : global::Infragistics.Windows.Themes.ResourceSet where T : global::Infragistics.Windows.Themes.ResourceSetLocator, new()
	{
		// Token: 0x17000270 RID: 624
		// (get) Token: 0x06000A81 RID: 2689 RVA: 0x0002F8C4 File Offset: 0x0002DAC4
		public override string Grouping
		{
			get
			{
				return global::Infragistics.Windows.Themes.EditorsResourceSet<T>.Location.Grouping;
			}
		}

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x06000A82 RID: 2690 RVA: 0x0002F8D0 File Offset: 0x0002DAD0
		public override string Theme
		{
			get
			{
				return global::Infragistics.Windows.Themes.EditorsResourceSet<T>.Location.Theme;
			}
		}

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x06000A83 RID: 2691 RVA: 0x0002F8DC File Offset: 0x0002DADC
		public override global::System.Windows.ResourceDictionary Resources
		{
			get
			{
				global::System.Windows.ResourceDictionary resourcesInternal = global::Infragistics.Windows.Themes.EditorsResourceSet<T>.ResourcesInternal;
				base.VerifyResources();
				return resourcesInternal;
			}
		}

		// Token: 0x17000273 RID: 627
		// (get) Token: 0x06000A84 RID: 2692 RVA: 0x0002F8F6 File Offset: 0x0002DAF6
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

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x06000A85 RID: 2693 RVA: 0x0002F913 File Offset: 0x0002DB13
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

		// Token: 0x17000275 RID: 629
		// (get) Token: 0x06000A86 RID: 2694 RVA: 0x0002F93F File Offset: 0x0002DB3F
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

		// Token: 0x17000276 RID: 630
		// (get) Token: 0x06000A87 RID: 2695 RVA: 0x0002F96B File Offset: 0x0002DB6B
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

		// Token: 0x17000277 RID: 631
		// (get) Token: 0x06000A88 RID: 2696 RVA: 0x0002F997 File Offset: 0x0002DB97
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

		// Token: 0x17000278 RID: 632
		// (get) Token: 0x06000A89 RID: 2697 RVA: 0x0002F9C3 File Offset: 0x0002DBC3
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

		// Token: 0x17000279 RID: 633
		// (get) Token: 0x06000A8A RID: 2698 RVA: 0x0002F9EF File Offset: 0x0002DBEF
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

		// Token: 0x1700027A RID: 634
		// (get) Token: 0x06000A8B RID: 2699 RVA: 0x0002FA1B File Offset: 0x0002DC1B
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

		// Token: 0x1700027B RID: 635
		// (get) Token: 0x06000A8C RID: 2700 RVA: 0x0002FA47 File Offset: 0x0002DC47
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

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x06000A8D RID: 2701 RVA: 0x0002FA73 File Offset: 0x0002DC73
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

		// Token: 0x1700027D RID: 637
		// (get) Token: 0x06000A8E RID: 2702 RVA: 0x0002FA9F File Offset: 0x0002DC9F
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

		// Token: 0x1700027E RID: 638
		// (get) Token: 0x06000A8F RID: 2703 RVA: 0x0002FACB File Offset: 0x0002DCCB
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

		// Token: 0x1700027F RID: 639
		// (get) Token: 0x06000A90 RID: 2704 RVA: 0x0002FAF7 File Offset: 0x0002DCF7
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

		// Token: 0x17000280 RID: 640
		// (get) Token: 0x06000A91 RID: 2705 RVA: 0x0002FB1E File Offset: 0x0002DD1E
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

		// Token: 0x17000281 RID: 641
		// (get) Token: 0x06000A92 RID: 2706 RVA: 0x0002FB45 File Offset: 0x0002DD45
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

		// Token: 0x17000282 RID: 642
		// (get) Token: 0x06000A93 RID: 2707 RVA: 0x0002FB71 File Offset: 0x0002DD71
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

		// Token: 0x17000283 RID: 643
		// (get) Token: 0x06000A94 RID: 2708 RVA: 0x0002FB9D File Offset: 0x0002DD9D
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

		// Token: 0x17000284 RID: 644
		// (get) Token: 0x06000A95 RID: 2709 RVA: 0x0002FBC9 File Offset: 0x0002DDC9
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

		// Token: 0x17000285 RID: 645
		// (get) Token: 0x06000A96 RID: 2710 RVA: 0x0002FBF5 File Offset: 0x0002DDF5
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

		// Token: 0x17000286 RID: 646
		// (get) Token: 0x06000A97 RID: 2711 RVA: 0x0002FC21 File Offset: 0x0002DE21
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

		// Token: 0x17000287 RID: 647
		// (get) Token: 0x06000A98 RID: 2712 RVA: 0x0002FC4D File Offset: 0x0002DE4D
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

		// Token: 0x17000288 RID: 648
		// (get) Token: 0x06000A99 RID: 2713 RVA: 0x0002FC79 File Offset: 0x0002DE79
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

		// Token: 0x17000289 RID: 649
		// (get) Token: 0x06000A9A RID: 2714 RVA: 0x0002FCA5 File Offset: 0x0002DEA5
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

		// Token: 0x1700028A RID: 650
		// (get) Token: 0x06000A9B RID: 2715 RVA: 0x0002FCD1 File Offset: 0x0002DED1
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

		// Token: 0x040003C2 RID: 962
		internal const string GroupingName = "Editors";

		// Token: 0x040003C3 RID: 963
		[global::System.ThreadStatic]
		private static global::Infragistics.Windows.Themes.ResourceSetLocator g_Location;

		// Token: 0x040003C4 RID: 964
		[global::System.ThreadStatic]
		private static global::System.Windows.ResourceDictionary g_ResourcesInternal;

		// Token: 0x040003C5 RID: 965
		[global::System.ThreadStatic]
		private static global::System.Windows.Style g_CaretElement;

		// Token: 0x040003C6 RID: 966
		[global::System.ThreadStatic]
		private static global::System.Windows.Style g_DisplayCharactersList;

		// Token: 0x040003C7 RID: 967
		[global::System.ThreadStatic]
		private static global::System.Windows.Style g_DisplayCharacterPresenter;

		// Token: 0x040003C8 RID: 968
		[global::System.ThreadStatic]
		private static global::System.Windows.Style g_SectionsList;

		// Token: 0x040003C9 RID: 969
		[global::System.ThreadStatic]
		private static global::System.Windows.Style g_SectionPresenter;

		// Token: 0x040003CA RID: 970
		[global::System.ThreadStatic]
		private static global::System.Windows.Style g_XamCurrencyEditor;

		// Token: 0x040003CB RID: 971
		[global::System.ThreadStatic]
		private static global::System.Windows.Style g_XamDateTimeEditor;

		// Token: 0x040003CC RID: 972
		[global::System.ThreadStatic]
		private static global::System.Windows.Style g_MaskedEditor;

		// Token: 0x040003CD RID: 973
		[global::System.ThreadStatic]
		private static global::System.Windows.Style g_XamNumericEditor;

		// Token: 0x040003CE RID: 974
		[global::System.ThreadStatic]
		private static global::System.Windows.Style g_XamComboEditor;

		// Token: 0x040003CF RID: 975
		[global::System.ThreadStatic]
		private static global::System.Windows.Style g_XamComboEditorComboBox;

		// Token: 0x040003D0 RID: 976
		[global::System.ThreadStatic]
		private static global::System.Windows.Style g_XamComboEditorDropDownButton;

		// Token: 0x040003D1 RID: 977
		[global::System.ThreadStatic]
		private static global::System.Windows.Style g_CalendarItem;

		// Token: 0x040003D2 RID: 978
		[global::System.ThreadStatic]
		private static global::System.Windows.Style g_CalendarItemGroup;

		// Token: 0x040003D3 RID: 979
		[global::System.ThreadStatic]
		private static global::System.Windows.Style g_CalendarDayOfWeek;

		// Token: 0x040003D4 RID: 980
		[global::System.ThreadStatic]
		private static global::System.Windows.Style g_CalendarItemArea;

		// Token: 0x040003D5 RID: 981
		[global::System.ThreadStatic]
		private static global::System.Windows.Style g_CalendarItemGroupTitle;

		// Token: 0x040003D6 RID: 982
		[global::System.ThreadStatic]
		private static global::System.Windows.Style g_CalendarDay;

		// Token: 0x040003D7 RID: 983
		[global::System.ThreadStatic]
		private static global::System.Windows.Style g_XamMonthCalendar;

		// Token: 0x040003D8 RID: 984
		[global::System.ThreadStatic]
		private static global::System.Windows.Style g_CalendarWeekNumber;

		// Token: 0x040003D9 RID: 985
		[global::System.ThreadStatic]
		private static global::System.Windows.Style g_XamCheckEditor;

		// Token: 0x040003DA RID: 986
		[global::System.ThreadStatic]
		private static global::System.Windows.Style g_XamTextEditor;
	}
}
