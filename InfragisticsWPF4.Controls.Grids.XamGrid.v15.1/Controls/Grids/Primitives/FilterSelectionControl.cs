using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Threading;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x02000085 RID: 133
	[global::System.Windows.TemplatePart(Name = "SelectAllCheckBox", Type = typeof(global::System.Windows.Controls.CheckBox))]
	[global::System.Windows.TemplateVisualState(GroupName = "LimitItemsStatus", Name = "Limited")]
	[global::System.Windows.TemplateVisualState(GroupName = "LimitItemsStatus", Name = "NotLimited")]
	[global::System.Windows.TemplateVisualState(GroupName = "BusyStatus", Name = "Idle")]
	[global::System.Windows.TemplateVisualState(GroupName = "SelectionBoxWaterMark", Name = "HideSelectionBoxWaterMark")]
	[global::System.Windows.TemplateVisualState(GroupName = "SelectionBoxWaterMark", Name = "ShowSelectionBoxWaterMark")]
	[global::System.Windows.TemplateVisualState(GroupName = "AppendButtonVisibility", Name = "ShowAppendFilterButton")]
	[global::System.Windows.TemplateVisualState(GroupName = "AppendButtonVisibility", Name = "HideAppendFilterButton")]
	[global::System.Windows.TemplateVisualState(GroupName = "BusyStatus", Name = "Busy")]
	public class FilterSelectionControl : global::Infragistics.Controls.Grids.Primitives.SelectionControl
	{
		// Token: 0x060004A9 RID: 1193
		[global::System.Runtime.InteropServices.DllImport("user32.dll")]
		private static extern global::System.IntPtr SetActiveWindow(global::System.IntPtr hWnd);

		// Token: 0x060004AA RID: 1194 RVA: 0x00015660 File Offset: 0x00013860
		static FilterSelectionControl()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Controls.Grids.Primitives.FilterSelectionControl), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Controls.Grids.Primitives.FilterSelectionControl)));
			global::System.Windows.UIElement.FocusableProperty.OverrideMetadata(typeof(global::Infragistics.Controls.Grids.Primitives.FilterSelectionControl), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));
			if (!global::System.Windows.Interop.BrowserInteropHelper.IsBrowserHosted)
			{
				try
				{
					global::System.Windows.EventManager.RegisterClassHandler(typeof(global::Infragistics.Controls.Grids.Primitives.FilterSelectionControl), global::System.Windows.UIElement.PreviewGotKeyboardFocusEvent, new global::System.Windows.Input.KeyboardFocusChangedEventHandler(global::Infragistics.Controls.Grids.Primitives.FilterSelectionControl.OnPreviewGotKeyboardFocus), true);
				}
				catch (global::System.Security.SecurityException)
				{
				}
			}
		}

		// Token: 0x060004AB RID: 1195 RVA: 0x000158FC File Offset: 0x00013AFC
		public FilterSelectionControl()
		{
			this._isInDesignMode = global::System.ComponentModel.DesignerProperties.GetIsInDesignMode(this);
			base.Loaded += this.FilterSelectionControl_Loaded;
			base.Unloaded += this.FilterSelectionControl_Unloaded;
			this.OKButtonText = global::Infragistics.SRGrid.GetString("FilterSelectionControl_OKButtonText");
			this.CancelButtonText = global::Infragistics.SRGrid.GetString("FilterSelectionControl_CancelButtonText");
			this.AppendFilterText = global::Infragistics.SRGrid.GetString("AppendFilterText");
			this.NotAllItemsShowingText = global::Infragistics.SRGrid.GetString("FilterBoxNotAllItemsShowing");
			this.NotAllItemsShowingTooltipText = string.Format(global::Infragistics.SRGrid.GetString("FilterBoxNotAllItemsShowingTooltip"), 10000);
			this._busyIndicatorStartTimer = new global::System.Windows.Threading.DispatcherTimer
			{
				Interval = new global::System.TimeSpan(0, 0, 0, 0, 250)
			};
		}

		// Token: 0x060004AC RID: 1196 RVA: 0x000159D4 File Offset: 0x00013BD4
		protected internal static global::System.Type GetUnderlyingNonNullableType(global::System.Type dataType)
		{
			if (dataType != null)
			{
				bool isGenericType = dataType.IsGenericType;
				if (isGenericType && dataType.GetGenericTypeDefinition().Equals(typeof(global::System.Nullable<>)))
				{
					return global::System.Nullable.GetUnderlyingType(dataType);
				}
			}
			return dataType;
		}

		// Token: 0x060004AD RID: 1197 RVA: 0x00015A18 File Offset: 0x00013C18
		[global::System.Security.SecuritySafeCritical]
		private static void OnPreviewGotKeyboardFocus(object sender, global::System.Windows.Input.KeyboardFocusChangedEventArgs e)
		{
			global::System.Windows.Controls.Primitives.TextBoxBase textBoxBase = e.NewFocus as global::System.Windows.Controls.Primitives.TextBoxBase;
			if (textBoxBase != null)
			{
				global::System.Windows.Interop.HwndSource hwndSource = global::System.Windows.PresentationSource.FromVisual(textBoxBase) as global::System.Windows.Interop.HwndSource;
				if (hwndSource != null && global::System.Windows.Input.InputMethod.Current.ImeState == global::System.Windows.Input.InputMethodState.On)
				{
					global::Infragistics.Controls.Grids.Primitives.FilterSelectionControl.SetActiveWindow(hwndSource.Handle);
				}
			}
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x060004AE RID: 1198 RVA: 0x00015A5C File Offset: 0x00013C5C
		// (set) Token: 0x060004AF RID: 1199 RVA: 0x00015A64 File Offset: 0x00013C64
		internal new bool IsLoaded { get; private set; }

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x060004B0 RID: 1200 RVA: 0x00015A6D File Offset: 0x00013C6D
		// (set) Token: 0x060004B1 RID: 1201 RVA: 0x00015A75 File Offset: 0x00013C75
		private bool IsLoadingData { get; set; }

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x060004B2 RID: 1202 RVA: 0x00015A7E File Offset: 0x00013C7E
		// (set) Token: 0x060004B3 RID: 1203 RVA: 0x00015A86 File Offset: 0x00013C86
		private bool DelayIsBusy { get; set; }

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x060004B4 RID: 1204 RVA: 0x00015A8F File Offset: 0x00013C8F
		// (set) Token: 0x060004B5 RID: 1205 RVA: 0x00015A97 File Offset: 0x00013C97
		protected bool IsBusy
		{
			get
			{
				return this._isBusy;
			}
			set
			{
				this._isBusy = value;
				if (!value)
				{
					this.DelayIsBusy = false;
				}
			}
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x060004B6 RID: 1206 RVA: 0x00015AAA File Offset: 0x00013CAA
		// (set) Token: 0x060004B7 RID: 1207 RVA: 0x00015AB2 File Offset: 0x00013CB2
		protected bool IsLimited { get; set; }

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x060004B8 RID: 1208 RVA: 0x00015ABB File Offset: 0x00013CBB
		// (set) Token: 0x060004B9 RID: 1209 RVA: 0x00015AC3 File Offset: 0x00013CC3
		public bool ItemSourceSet
		{
			get
			{
				return this._itemSourceSet;
			}
			set
			{
				if (this._itemSourceSet != value)
				{
					this._itemSourceSet = value;
					this.OnPropertyChanged("ItemSourceSet");
				}
			}
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x060004BA RID: 1210 RVA: 0x00015AE0 File Offset: 0x00013CE0
		// (set) Token: 0x060004BB RID: 1211 RVA: 0x00015AF2 File Offset: 0x00013CF2
		public string ClearFiltersText
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Controls.Grids.Primitives.FilterSelectionControl.ClearFiltersTextProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.Primitives.FilterSelectionControl.ClearFiltersTextProperty, value);
			}
		}

		// Token: 0x060004BC RID: 1212 RVA: 0x00015B00 File Offset: 0x00013D00
		private static void ClearFiltersTextChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.Primitives.FilterSelectionControl filterSelectionControl = (global::Infragistics.Controls.Grids.Primitives.FilterSelectionControl)obj;
			filterSelectionControl.OnPropertyChanged("ClearFiltersText");
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x060004BD RID: 1213 RVA: 0x00015B1F File Offset: 0x00013D1F
		// (set) Token: 0x060004BE RID: 1214 RVA: 0x00015B31 File Offset: 0x00013D31
		public string TypeSpecificFiltersText
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Controls.Grids.Primitives.FilterSelectionControl.TypeSpecificFiltersTextProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.Primitives.FilterSelectionControl.TypeSpecificFiltersTextProperty, value);
			}
		}

		// Token: 0x060004BF RID: 1215 RVA: 0x00015B40 File Offset: 0x00013D40
		private static void TypeSpecificFiltersTextChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.Primitives.FilterSelectionControl filterSelectionControl = (global::Infragistics.Controls.Grids.Primitives.FilterSelectionControl)obj;
			filterSelectionControl.OnPropertyChanged("TypeSpecificFiltersText");
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x060004C0 RID: 1216 RVA: 0x00015B5F File Offset: 0x00013D5F
		// (set) Token: 0x060004C1 RID: 1217 RVA: 0x00015B71 File Offset: 0x00013D71
		public string CancelButtonText
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Controls.Grids.Primitives.FilterSelectionControl.CancelButtonTextProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.Primitives.FilterSelectionControl.CancelButtonTextProperty, value);
			}
		}

		// Token: 0x060004C2 RID: 1218 RVA: 0x00015B80 File Offset: 0x00013D80
		private static void CancelButtonTextChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.Primitives.FilterSelectionControl filterSelectionControl = (global::Infragistics.Controls.Grids.Primitives.FilterSelectionControl)obj;
			filterSelectionControl.OnPropertyChanged("CancelButtonText");
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x060004C3 RID: 1219 RVA: 0x00015B9F File Offset: 0x00013D9F
		// (set) Token: 0x060004C4 RID: 1220 RVA: 0x00015BB1 File Offset: 0x00013DB1
		public string OKButtonText
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Controls.Grids.Primitives.FilterSelectionControl.OKButtonTextProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.Primitives.FilterSelectionControl.OKButtonTextProperty, value);
			}
		}

		// Token: 0x060004C5 RID: 1221 RVA: 0x00015BC0 File Offset: 0x00013DC0
		private static void OKButtonTextChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.Primitives.FilterSelectionControl filterSelectionControl = (global::Infragistics.Controls.Grids.Primitives.FilterSelectionControl)obj;
			filterSelectionControl.OnPropertyChanged("OKButtonText");
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x060004C6 RID: 1222 RVA: 0x00015BDF File Offset: 0x00013DDF
		public string BusyText
		{
			get
			{
				return global::Infragistics.SRGrid.GetString("FilterBoxLoading");
			}
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x060004C7 RID: 1223 RVA: 0x00015BEB File Offset: 0x00013DEB
		// (set) Token: 0x060004C8 RID: 1224 RVA: 0x00015BFD File Offset: 0x00013DFD
		public string NotAllItemsShowingText
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Controls.Grids.Primitives.FilterSelectionControl.NotAllItemsShowingTextProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.Primitives.FilterSelectionControl.NotAllItemsShowingTextProperty, value);
			}
		}

		// Token: 0x060004C9 RID: 1225 RVA: 0x00015C0C File Offset: 0x00013E0C
		private static void NotAllItemsShowingTextChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.Primitives.FilterSelectionControl filterSelectionControl = (global::Infragistics.Controls.Grids.Primitives.FilterSelectionControl)obj;
			filterSelectionControl.OnPropertyChanged("NotAllItemsShowingText");
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x060004CA RID: 1226 RVA: 0x00015C2B File Offset: 0x00013E2B
		// (set) Token: 0x060004CB RID: 1227 RVA: 0x00015C3D File Offset: 0x00013E3D
		public string NotAllItemsShowingTooltipText
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Controls.Grids.Primitives.FilterSelectionControl.NotAllItemsShowingTooltipTextProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.Primitives.FilterSelectionControl.NotAllItemsShowingTooltipTextProperty, value);
			}
		}

		// Token: 0x060004CC RID: 1228 RVA: 0x00015C4C File Offset: 0x00013E4C
		private static void NotAllItemsShowingTooltipTextChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.Primitives.FilterSelectionControl filterSelectionControl = (global::Infragistics.Controls.Grids.Primitives.FilterSelectionControl)obj;
			filterSelectionControl.OnPropertyChanged("NotAllItemsShowingTooltipText");
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x060004CD RID: 1229 RVA: 0x00015C6B File Offset: 0x00013E6B
		// (set) Token: 0x060004CE RID: 1230 RVA: 0x00015C73 File Offset: 0x00013E73
		protected internal global::System.Windows.Controls.CheckBox SelectAllCheckBox { get; set; }

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x060004CF RID: 1231 RVA: 0x00015C7C File Offset: 0x00013E7C
		public virtual global::Infragistics.Controls.Grids.Primitives.FilterItemCollection UniqueValues
		{
			get
			{
				if (this._uniqueValues == null)
				{
					this._uniqueValues = this.GetCollection();
					if (this._uniqueValues != null)
					{
						this._uniqueValues.CollectionChanged += this.UniqueValues_CollectionChanged;
					}
				}
				return this._uniqueValues;
			}
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x060004D0 RID: 1232 RVA: 0x00015CB7 File Offset: 0x00013EB7
		public virtual global::System.Collections.IEnumerable FilterableUniqueValues
		{
			get
			{
				if (this.UniqueValues == null || this.UniqueValues.Count == 0)
				{
					return null;
				}
				return this.UniqueValues;
			}
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x060004D1 RID: 1233 RVA: 0x00015CD6 File Offset: 0x00013ED6
		// (set) Token: 0x060004D2 RID: 1234 RVA: 0x00015CE8 File Offset: 0x00013EE8
		public string ClearFiltersTextResolved
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Controls.Grids.Primitives.FilterSelectionControl.ClearFiltersTextResolvedProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.Primitives.FilterSelectionControl.ClearFiltersTextResolvedProperty, value);
			}
		}

		// Token: 0x060004D3 RID: 1235 RVA: 0x00015CF8 File Offset: 0x00013EF8
		private static void ClearFiltersTextResolvedChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.Primitives.FilterSelectionControl filterSelectionControl = (global::Infragistics.Controls.Grids.Primitives.FilterSelectionControl)obj;
			filterSelectionControl.OnPropertyChanged("ClearFiltersTextResolved");
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x060004D4 RID: 1236 RVA: 0x00015D17 File Offset: 0x00013F17
		// (set) Token: 0x060004D5 RID: 1237 RVA: 0x00015D29 File Offset: 0x00013F29
		public string TypeSpecificFiltersTextResolved
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Controls.Grids.Primitives.FilterSelectionControl.TypeSpecificFiltersTextResolvedProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.Primitives.FilterSelectionControl.TypeSpecificFiltersTextResolvedProperty, value);
			}
		}

		// Token: 0x060004D6 RID: 1238 RVA: 0x00015D38 File Offset: 0x00013F38
		private static void TypeSpecificFiltersTextResolvedChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.Primitives.FilterSelectionControl filterSelectionControl = (global::Infragistics.Controls.Grids.Primitives.FilterSelectionControl)obj;
			filterSelectionControl.OnPropertyChanged("TypeSpecificFiltersTextResolved");
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x060004D7 RID: 1239 RVA: 0x00015D57 File Offset: 0x00013F57
		// (set) Token: 0x060004D8 RID: 1240 RVA: 0x00015D5F File Offset: 0x00013F5F
		protected int CheckedCount { get; set; }

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x060004D9 RID: 1241 RVA: 0x00015D68 File Offset: 0x00013F68
		// (set) Token: 0x060004DA RID: 1242 RVA: 0x00015D70 File Offset: 0x00013F70
		protected int UncheckedCount { get; set; }

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x060004DB RID: 1243 RVA: 0x00015D79 File Offset: 0x00013F79
		// (set) Token: 0x060004DC RID: 1244 RVA: 0x00015D81 File Offset: 0x00013F81
		protected global::System.Collections.IList RawValues { get; set; }

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x060004DD RID: 1245 RVA: 0x00015D8A File Offset: 0x00013F8A
		// (set) Token: 0x060004DE RID: 1246 RVA: 0x00015D92 File Offset: 0x00013F92
		public string FilterText
		{
			get
			{
				return this._filterText;
			}
			set
			{
				if (this._filterText != value)
				{
					this._filterText = value;
					this.OnPropertyChanged("FilterText");
				}
			}
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x060004DF RID: 1247 RVA: 0x00015DB4 File Offset: 0x00013FB4
		public string FilterBoxNoDataAvailable
		{
			get
			{
				return global::Infragistics.SRGrid.GetString("FilterBoxNoDataAvailable");
			}
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x060004E0 RID: 1248 RVA: 0x00015DC0 File Offset: 0x00013FC0
		// (set) Token: 0x060004E1 RID: 1249 RVA: 0x00015DC8 File Offset: 0x00013FC8
		protected bool ShowAppendFiltersCheckBox { get; set; }

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x060004E2 RID: 1250 RVA: 0x00015DD1 File Offset: 0x00013FD1
		// (set) Token: 0x060004E3 RID: 1251 RVA: 0x00015DE3 File Offset: 0x00013FE3
		public string AppendFilterText
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Controls.Grids.Primitives.FilterSelectionControl.AppendFilterTextProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.Primitives.FilterSelectionControl.AppendFilterTextProperty, value);
			}
		}

		// Token: 0x060004E4 RID: 1252 RVA: 0x00015DF4 File Offset: 0x00013FF4
		private static void AppendFilterTextChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.Primitives.FilterSelectionControl filterSelectionControl = (global::Infragistics.Controls.Grids.Primitives.FilterSelectionControl)obj;
			filterSelectionControl.OnPropertyChanged("AppendFilterText");
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x060004E5 RID: 1253 RVA: 0x00015E13 File Offset: 0x00014013
		// (set) Token: 0x060004E6 RID: 1254 RVA: 0x00015E25 File Offset: 0x00014025
		public bool AppendFilters
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Controls.Grids.Primitives.FilterSelectionControl.AppendFiltersProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.Primitives.FilterSelectionControl.AppendFiltersProperty, value);
			}
		}

		// Token: 0x060004E7 RID: 1255 RVA: 0x00015E38 File Offset: 0x00014038
		private static void AppendFiltersChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.Primitives.FilterSelectionControl filterSelectionControl = (global::Infragistics.Controls.Grids.Primitives.FilterSelectionControl)obj;
			filterSelectionControl.OnPropertyChanged("AppendFilters");
			filterSelectionControl.OnPropertyChanged("CanFilter");
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x060004E8 RID: 1256 RVA: 0x00015E62 File Offset: 0x00014062
		internal global::Infragistics.Controls.Grids.Primitives.FilterItemCollection CachedUniqueValues
		{
			get
			{
				if (this._cachedUniqueValues == null)
				{
					this._cachedUniqueValues = this.GetCollection();
				}
				return this._cachedUniqueValues;
			}
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x060004E9 RID: 1257 RVA: 0x00015E7E File Offset: 0x0001407E
		// (set) Token: 0x060004EA RID: 1258 RVA: 0x00015E86 File Offset: 0x00014086
		private int CachedCheckedCount { get; set; }

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x060004EB RID: 1259 RVA: 0x00015E8F File Offset: 0x0001408F
		// (set) Token: 0x060004EC RID: 1260 RVA: 0x00015E97 File Offset: 0x00014097
		private int CachedUncheckedCount { get; set; }

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x060004ED RID: 1261 RVA: 0x00015EA0 File Offset: 0x000140A0
		// (set) Token: 0x060004EE RID: 1262 RVA: 0x00015EA8 File Offset: 0x000140A8
		public bool HasFilters
		{
			get
			{
				return this._hasFilters;
			}
			protected set
			{
				if (value != this._hasFilters)
				{
					this._hasFilters = value;
					this.OnPropertyChanged("HasFilters");
					this.OnPropertyChanged("HasCheckedItems");
				}
			}
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x060004EF RID: 1263 RVA: 0x00015ED0 File Offset: 0x000140D0
		// (set) Token: 0x060004F0 RID: 1264 RVA: 0x00015ED8 File Offset: 0x000140D8
		public virtual bool HasCheckedItems
		{
			get
			{
				return this._hasCheckedItems;
			}
			protected set
			{
				if (value != this._hasCheckedItems)
				{
					this._hasCheckedItems = value;
					this.OnPropertyChanged("HasCheckedItems");
				}
			}
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x060004F1 RID: 1265 RVA: 0x00015EF5 File Offset: 0x000140F5
		internal global::System.Collections.Generic.List<global::System.Threading.CancellationTokenSource> Phase2TokenSourceQueue
		{
			get
			{
				return this._phase2TokenSourceQueue;
			}
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x060004F2 RID: 1266 RVA: 0x00015EFD File Offset: 0x000140FD
		// (set) Token: 0x060004F3 RID: 1267 RVA: 0x00015F05 File Offset: 0x00014105
		protected bool AllowFiltering
		{
			get
			{
				return this._allowFiltering;
			}
			set
			{
				if (value != this._allowFiltering)
				{
					this._allowFiltering = value;
					this.OnPropertyChanged("CanFilter");
				}
			}
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x060004F4 RID: 1268 RVA: 0x00015F22 File Offset: 0x00014122
		public virtual bool CanFilter
		{
			get
			{
				return this.AllowFiltering || this.AppendFilters;
			}
		}

		// Token: 0x060004F5 RID: 1269 RVA: 0x00015F34 File Offset: 0x00014134
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();
			this.SelectAllCheckBox = (base.GetTemplateChild("SelectAllCheckBox") as global::System.Windows.Controls.CheckBox);
			global::Infragistics.Controls.Grids.FilterColumnSettings filterColumnSettings = null;
			string text = "";
			if (base.Cell != null && base.Cell.Column != null)
			{
				filterColumnSettings = base.Cell.Column.FilterColumnSettings;
				if (base.Cell.Column.ColumnLayout != null && base.Cell.Column.ColumnLayout.Grid != null)
				{
					text = base.Cell.Column.ColumnLayout.Grid.FilteringSettings.SelectAllText;
				}
			}
			if (this.SelectAllCheckBox != null)
			{
				this.SelectAllCheckBox.Style = base.CheckBoxStyle;
				if (!string.IsNullOrEmpty(text))
				{
					this.SelectAllCheckBox.Content = text;
				}
				else
				{
					this.SelectAllCheckBox.Content = global::Infragistics.SRGrid.GetString("SelectAllCheckBox");
				}
			}
			string text2 = (filterColumnSettings == null) ? string.Empty : filterColumnSettings.FilterMenuClearFiltersStringResolved;
			if (string.IsNullOrEmpty(text2) && base.Cell != null)
			{
				string arg = (!string.IsNullOrEmpty(base.Cell.Column.HeaderText)) ? base.Cell.Column.HeaderText : base.Cell.Column.Key;
				if (string.IsNullOrEmpty(this.ClearFiltersText))
				{
					this.ClearFiltersTextResolved = string.Format(global::Infragistics.SRGrid.GetString("ClearFiltersForColumnKey"), arg);
				}
				else
				{
					this.ClearFiltersTextResolved = string.Format(this.ClearFiltersText, arg);
				}
			}
			else
			{
				this.ClearFiltersTextResolved = text2;
			}
			string text3 = (filterColumnSettings == null) ? string.Empty : filterColumnSettings.FilterMenuTypeSpecificFiltersString;
			if (string.IsNullOrEmpty(text3) && base.Cell != null)
			{
				global::System.Type underlyingNonNullableType = global::Infragistics.Controls.Grids.Primitives.FilterSelectionControl.GetUnderlyingNonNullableType(base.Cell.Column.DataType);
				if (string.IsNullOrEmpty(this.TypeSpecificFiltersText))
				{
					if (underlyingNonNullableType != null)
					{
						this.TypeSpecificFiltersTextResolved = string.Format(global::Infragistics.SRGrid.GetString("CustomFiltersWithType"), underlyingNonNullableType.Name);
					}
					else
					{
						this.TypeSpecificFiltersTextResolved = global::Infragistics.SRGrid.GetString("CustomFiltersWithoutType");
					}
				}
				else
				{
					this.TypeSpecificFiltersTextResolved = this.TypeSpecificFiltersText;
				}
			}
			else
			{
				this.TypeSpecificFiltersTextResolved = text3;
			}
			this.EnsureCurrentState();
			base.Dispatcher.BeginInvoke(new global::System.Action(base.InvalidateArrange), new object[0]);
		}

		// Token: 0x060004F6 RID: 1270 RVA: 0x0001616E File Offset: 0x0001436E
		protected override bool SupportsCommand(global::System.Windows.Input.ICommand command)
		{
			return command is global::Infragistics.Controls.Grids.ClearSelectedItemsCommand || command is global::Infragistics.Controls.Grids.Primitives.ShowCustomFilterDialogCommand || base.SupportsCommand(command);
		}

		// Token: 0x060004F7 RID: 1271 RVA: 0x000161A8 File Offset: 0x000143A8
		protected internal override void AcceptChanges()
		{
			if (!this._changeDetected)
			{
				return;
			}
			global::Infragistics.Controls.Grids.CellBase cell = base.Cell;
			string key = cell.Column.Key;
			global::Infragistics.Controls.Grids.RowsManager rowsManager = cell.Row.Manager as global::Infragistics.Controls.Grids.RowsManager;
			if (rowsManager == null)
			{
				return;
			}
			global::Infragistics.Controls.Grids.RowFiltersCollection rowFiltersCollectionResolved = rowsManager.RowFiltersCollectionResolved;
			global::Infragistics.Controls.Grids.RowsFilter rowsFilter = rowFiltersCollectionResolved[key];
			if (rowsFilter == null)
			{
				return;
			}
			global::Infragistics.Controls.Grids.Column column = base.Cell.Column;
			global::Infragistics.Controls.Grids.ColumnLayout columnLayout = column.ColumnLayout;
			global::Infragistics.Controls.Grids.XamGrid grid = column.ColumnLayout.Grid;
			bool flag = !this.AppendFilters;
			if (columnLayout.Grid.FilteringSettings.FilterMenuSelectionListGeneration == global::Infragistics.Controls.Grids.FilterMenuCumulativeSelectionList.ExcelStyle && flag)
			{
				if (rowsFilter.Conditions.Any((global::Infragistics.IFilterCondition condition) => !(condition is global::Infragistics.ComparisonCondition) || ((global::Infragistics.ComparisonCondition)condition).Operator != global::Infragistics.ComparisonOperator.InOperand))
				{
					foreach (global::Infragistics.IRecordFilter recordFilter in rowFiltersCollectionResolved)
					{
						global::Infragistics.Controls.Grids.RowsFilter rowsFilter2 = (global::Infragistics.Controls.Grids.RowsFilter)recordFilter;
						if (rowsFilter != rowsFilter2 && rowsFilter2.Conditions.Count > 0)
						{
							flag = false;
							break;
						}
					}
				}
			}
			if (flag)
			{
				rowsFilter.Conditions.LogicalOperator = global::Infragistics.LogicalOperator.Or;
				rowsFilter.Conditions.ClearSilently();
			}
			if (this.AppendFilters)
			{
				if (rowsFilter.Conditions.Count == 0)
				{
					rowsFilter.Conditions.LogicalOperator = global::Infragistics.LogicalOperator.And;
				}
				global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.Primitives.FilterValueProxy> list = new global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.Primitives.FilterValueProxy>();
				foreach (object obj in this.FilterableUniqueValues)
				{
					global::Infragistics.Controls.Grids.Primitives.FilterValueProxy filterValueProxy = (global::Infragistics.Controls.Grids.Primitives.FilterValueProxy)obj;
					foreach (object obj2 in this.CachedUniqueValues)
					{
						global::Infragistics.Controls.Grids.Primitives.FilterValueProxy filterValueProxy2 = (global::Infragistics.Controls.Grids.Primitives.FilterValueProxy)obj2;
						bool flag2;
						if (filterValueProxy.Value == null)
						{
							flag2 = (filterValueProxy.Value == filterValueProxy2.Value);
						}
						else
						{
							flag2 = filterValueProxy.Value.Equals(filterValueProxy2.Value);
						}
						if (flag2)
						{
							if (filterValueProxy.IsChecked == filterValueProxy2.IsChecked)
							{
								break;
							}
							if (filterValueProxy2.IsChecked)
							{
								this.CachedCheckedCount--;
							}
							else
							{
								this.CachedUncheckedCount--;
							}
							filterValueProxy2.IsChecked = filterValueProxy.IsChecked;
							list.Add(filterValueProxy);
							if (filterValueProxy2.IsChecked)
							{
								this.CachedCheckedCount++;
								break;
							}
							this.CachedUncheckedCount++;
							break;
						}
					}
				}
				if (rowsFilter.Conditions.LogicalOperator == global::Infragistics.LogicalOperator.Or)
				{
					using (global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.Primitives.FilterValueProxy>.Enumerator enumerator4 = list.GetEnumerator())
					{
						while (enumerator4.MoveNext())
						{
							global::Infragistics.Controls.Grids.Primitives.FilterValueProxy filterValueProxy3 = enumerator4.Current;
							this.ApplyNegativeFilterForItem(filterValueProxy3.Value, filterValueProxy3.IsChecked, column, columnLayout, rowsManager, rowsFilter, true);
						}
						goto IL_4F8;
					}
				}
				using (global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.Primitives.FilterValueProxy>.Enumerator enumerator5 = list.GetEnumerator())
				{
					while (enumerator5.MoveNext())
					{
						global::Infragistics.Controls.Grids.Primitives.FilterValueProxy filterValueProxy4 = enumerator5.Current;
						this.ApplyFilterForItem(filterValueProxy4.Value, filterValueProxy4.IsChecked, column, columnLayout, rowsManager, rowsFilter, true);
					}
					goto IL_4F8;
				}
			}
			if (string.IsNullOrEmpty(this.FilterText) || this.FilterableUniqueValues == null)
			{
				this.ProcessChanges(this.CheckedCount, this.UncheckedCount, ((global::Infragistics.Controls.Grids.Primitives.FilterItemCollection<global::Infragistics.Controls.Grids.Primitives.FilterValueProxy>)this.UniqueValues).ToList<global::Infragistics.Controls.Grids.Primitives.FilterValueProxy>());
			}
			else
			{
				this.CachedCheckedCount = this.RawValues.Count;
				this.CachedUncheckedCount = 0;
				global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.Primitives.FilterValueProxy> list2 = this.FilterableUniqueValues.Cast<global::Infragistics.Controls.Grids.Primitives.FilterValueProxy>().ToList<global::Infragistics.Controls.Grids.Primitives.FilterValueProxy>();
				int num = list2.Count;
				int count = this.CachedUniqueValues.Count;
				for (int i = 0; i < count; i++)
				{
					global::Infragistics.Controls.Grids.Primitives.FilterValueProxy filterValueProxy5 = this.CachedUniqueValues[i] as global::Infragistics.Controls.Grids.Primitives.FilterValueProxy;
					filterValueProxy5.IsChecked = false;
					this.CachedUncheckedCount++;
					this.CachedCheckedCount--;
					if (this.FilterableUniqueValues != null)
					{
						for (int j = 0; j < num; j++)
						{
							global::Infragistics.Controls.Grids.Primitives.FilterValueProxy filterValueProxy6 = list2[j];
							bool flag3;
							if (filterValueProxy6.Value == null)
							{
								flag3 = (filterValueProxy6.Value == filterValueProxy5.Value);
							}
							else
							{
								flag3 = filterValueProxy6.Value.Equals(filterValueProxy5.Value);
							}
							if (flag3)
							{
								if (filterValueProxy6.IsChecked != filterValueProxy5.IsChecked)
								{
									if (filterValueProxy5.IsChecked)
									{
										this.CachedCheckedCount--;
									}
									else
									{
										this.CachedUncheckedCount--;
									}
									filterValueProxy5.IsChecked = filterValueProxy6.IsChecked;
									if (filterValueProxy5.IsChecked)
									{
										this.CachedCheckedCount++;
									}
									else
									{
										this.CachedUncheckedCount++;
									}
								}
								list2.Remove(filterValueProxy6);
								num--;
								break;
							}
						}
					}
				}
				this.ProcessChanges(this.CachedCheckedCount, this.CachedUncheckedCount, ((global::Infragistics.Controls.Grids.Primitives.FilterItemCollection<global::Infragistics.Controls.Grids.Primitives.FilterValueProxy>)this.CachedUniqueValues).ToList<global::Infragistics.Controls.Grids.Primitives.FilterValueProxy>());
			}
			IL_4F8:
			cell.Row.ColumnLayout.InvalidateFiltering();
			grid.ResetPanelRows();
			grid.OnFiltered(rowsManager.RowFiltersCollectionResolved);
		}

		// Token: 0x060004F8 RID: 1272 RVA: 0x00016750 File Offset: 0x00014950
		protected override void OnCellAssigned()
		{
			if (base.Cell != null)
			{
				global::System.Windows.Style filterSelectionControlStyleResolved = base.Cell.Column.ColumnLayout.FilteringSettings.FilterSelectionControlStyleResolved;
				global::Infragistics.Controls.Grids.Primitives.ColumnContentProviderBase.SetControlStyle(this, filterSelectionControlStyleResolved);
				return;
			}
			this._formatString = string.Empty;
			base.ClearValue(global::System.Windows.FrameworkElement.StyleProperty);
		}

		// Token: 0x060004F9 RID: 1273 RVA: 0x0001679E File Offset: 0x0001499E
		protected override void OnMouseLeftButtonDown(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			base.OnMouseLeftButtonDown(e);
			e.Handled = true;
		}

		// Token: 0x060004FA RID: 1274 RVA: 0x000167AE File Offset: 0x000149AE
		protected virtual void OnRawValuesSet()
		{
		}

		// Token: 0x060004FB RID: 1275 RVA: 0x000167B0 File Offset: 0x000149B0
		protected internal virtual void EnsureCurrentState()
		{
			if (base.Cell != null && base.Cell.Column is global::Infragistics.Controls.Grids.UnboundColumn)
			{
				global::System.Windows.VisualStateManager.GoToState(this, "HideSelectionBox", false);
			}
			else
			{
				global::System.Windows.VisualStateManager.GoToState(this, "ShowSelectionBox", false);
			}
			if (!this._isInDesignMode && this.IsLoaded && !this.DelayIsBusy && !this.IsBusy && (this.UniqueValues == null || this.UniqueValues.Count == 0))
			{
				global::System.Windows.VisualStateManager.GoToState(this, "ShowSelectionBoxWaterMark", false);
			}
			else
			{
				global::System.Windows.VisualStateManager.GoToState(this, "HideSelectionBoxWaterMark", false);
			}
			if (this.ShowAppendFiltersCheckBox)
			{
				global::System.Windows.VisualStateManager.GoToState(this, "ShowAppendFilterButton", false);
			}
			else
			{
				global::System.Windows.VisualStateManager.GoToState(this, "HideAppendFilterButton", false);
			}
			if (this.IsBusy)
			{
				global::System.Windows.VisualStateManager.GoToState(this, "Busy", false);
			}
			else
			{
				global::System.Windows.VisualStateManager.GoToState(this, "Idle", false);
			}
			if (this.IsLimited)
			{
				global::System.Windows.VisualStateManager.GoToState(this, "Limited", false);
				return;
			}
			global::System.Windows.VisualStateManager.GoToState(this, "NotLimited", false);
		}

		// Token: 0x060004FC RID: 1276 RVA: 0x00016D9C File Offset: 0x00014F9C
		protected override void SetupSelectionBox()
		{
			global::Infragistics.CommandSourceManager.NotifyCanExecuteChanged(typeof(global::Infragistics.Controls.Grids.ClearSelectedItemsCommand));
			if (this.SelectAllCheckBox != null && base.Cell != null && base.Cell.Column != null && base.Cell.Column.IsFilterable && !(base.Cell.Column is global::Infragistics.Controls.Grids.UnboundColumn))
			{
				this.CheckedCount = (this.UncheckedCount = 0);
				global::Infragistics.Controls.Grids.RowsManager rowsManager = base.Cell.Row.Manager as global::Infragistics.Controls.Grids.RowsManager;
				if (rowsManager == null)
				{
					return;
				}
				if (rowsManager.DataManager == null || rowsManager.DataManager.CachedType == null)
				{
					this.SelectAllCheckBox.IsEnabled = false;
					this.ItemSourceSet = false;
					return;
				}
				this.ItemSourceSet = true;
				this.SelectAllCheckBox.IsEnabled = true;
				global::Infragistics.Controls.Grids.RowFiltersCollection rowFiltersCollectionResolved = rowsManager.RowFiltersCollectionResolved;
				global::Infragistics.Controls.Grids.RowsFilter rf = rowFiltersCollectionResolved[base.Cell.Column.Key];
				if (rf == null)
				{
					rf = new global::Infragistics.Controls.Grids.RowsFilter(rowsManager.DataManager.CachedType, base.Cell.Column);
					rowsManager.RowFiltersCollectionResolved.AddItemSilently(rf);
				}
				bool respectPreviousFilters = false;
				if (rowsManager.ColumnLayout.Grid.FilteringSettings.FilterMenuSelectionListGeneration == global::Infragistics.Controls.Grids.FilterMenuCumulativeSelectionList.ExcelStyle)
				{
					foreach (global::Infragistics.IRecordFilter recordFilter in rowFiltersCollectionResolved)
					{
						global::Infragistics.Controls.Grids.RowsFilter rowsFilter = (global::Infragistics.Controls.Grids.RowsFilter)recordFilter;
						if (rf != rowsFilter && rowsFilter.Conditions.Count > 0)
						{
							respectPreviousFilters = true;
							break;
						}
					}
				}
				if (!this.IsLoadingData)
				{
					this.IsLoadingData = true;
					this._phase1TokenSource = new global::System.Threading.CancellationTokenSource();
					global::System.Threading.CancellationToken token = this._phase1TokenSource.Token;
					global::System.Threading.Tasks.TaskScheduler scheduler = global::System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext();
					global::System.Threading.Tasks.Task<global::System.Collections.IList> distinctItemsForColumn = rowsManager.GetDistinctItemsForColumn(base.Cell, respectPreviousFilters, token);
					if (this._busyIndicatorStartTimer.IsEnabled)
					{
						this._busyIndicatorStartTimer.Tick -= this.BusyIndicatorStartTimer_Tick;
						this._busyIndicatorStartTimer.Stop();
					}
					this.DelayIsBusy = true;
					this.EnsureCurrentState();
					this._busyIndicatorStartTimer.Tick += this.BusyIndicatorStartTimer_Tick;
					this._busyIndicatorStartTimer.Start();
					distinctItemsForColumn.ContinueWith(delegate(global::System.Threading.Tasks.Task<global::System.Collections.IList> result)
					{
						if (this._phase1TokenSource == null || this._phase1TokenSource.IsCancellationRequested)
						{
							this.IsBusy = false;
							this.IsLoadingData = false;
							this.EnsureCurrentState();
							this._phase1TokenSource = null;
							return;
						}
						if (result.Exception != null || result.Status == global::System.Threading.Tasks.TaskStatus.Faulted || result.Result == null)
						{
							this.IsBusy = false;
							this.IsLoadingData = false;
							this.EnsureCurrentState();
							this._phase1TokenSource = null;
							return;
						}
						this.RawValues = result.Result;
						this.OnRawValuesSet();
						int num = 0;
						int count = this.RawValues.Count;
						int count2 = rf.Conditions.Count;
						if ((count2 > 1 && rf.Conditions.LogicalOperator == global::Infragistics.LogicalOperator.Or) || (count2 == 1 && rf.Conditions[0] is global::Infragistics.ComparisonCondition && ((global::Infragistics.ComparisonCondition)rf.Conditions[0]).Operator == global::Infragistics.ComparisonOperator.InOperand))
						{
							bool flag = true;
							global::System.Collections.Generic.List<object> list = new global::System.Collections.Generic.List<object>();
							foreach (global::Infragistics.IFilterCondition filterCondition in rf.Conditions)
							{
								global::Infragistics.ComparisonCondition comparisonCondition = filterCondition as global::Infragistics.ComparisonCondition;
								if (comparisonCondition == null)
								{
									flag = false;
									list.Clear();
									break;
								}
								if (comparisonCondition.Operator == global::Infragistics.ComparisonOperator.InOperand)
								{
									list = (comparisonCondition.FilterValue as global::System.Collections.IList).Cast<object>().ToList<object>();
								}
								else
								{
									if (comparisonCondition.Operator != global::Infragistics.ComparisonOperator.Equals)
									{
										flag = false;
										list.Clear();
										list.Add(comparisonCondition.FilterValue);
										break;
									}
									list.Add(comparisonCondition.FilterValue);
								}
							}
							if (flag)
							{
								num = this.CreateEqualsBasedCheckboxTree(this.RawValues, list);
								this.HasCheckedItems = true;
								this.HasFilters = false;
							}
							else
							{
								this.CreateAllCheckBoxes(this.RawValues, false);
								this.HasCheckedItems = false;
							}
						}
						else if (count2 > 1 && rf.Conditions.LogicalOperator == global::Infragistics.LogicalOperator.And)
						{
							bool flag2 = true;
							global::System.Collections.Generic.List<object> list2 = new global::System.Collections.Generic.List<object>();
							global::Infragistics.ConditionCollection conditions = rf.Conditions;
							int count3 = conditions.Count;
							for (int i = 0; i < count3; i++)
							{
								global::Infragistics.ComparisonCondition comparisonCondition2 = conditions[i] as global::Infragistics.ComparisonCondition;
								if (comparisonCondition2 == null)
								{
									flag2 = false;
									list2.Clear();
									break;
								}
								if (comparisonCondition2.Operator != global::Infragistics.ComparisonOperator.NotEquals)
								{
									flag2 = false;
									list2.Clear();
									break;
								}
								list2.Add(comparisonCondition2.FilterValue);
							}
							if (flag2)
							{
								num = this.CreateNotEqualsBasedCheckboxTree(this.RawValues, list2);
								this.HasCheckedItems = true;
								this.HasFilters = false;
							}
							else
							{
								this.CreateAllCheckBoxes(this.RawValues, false);
								this.HasCheckedItems = false;
							}
						}
						else if (count2 == 1)
						{
							global::Infragistics.ComparisonCondition comparisonCondition3 = rf.Conditions[0] as global::Infragistics.ComparisonCondition;
							if (comparisonCondition3 != null)
							{
								bool flag3 = comparisonCondition3.Operator == global::Infragistics.ComparisonOperator.Equals;
								bool flag4 = comparisonCondition3.Operator == global::Infragistics.ComparisonOperator.NotEquals;
								global::System.Collections.Generic.List<object> list3 = new global::System.Collections.Generic.List<object>();
								list3.Add(comparisonCondition3.FilterValue);
								if (flag3)
								{
									num = this.CreateEqualsBasedCheckboxTree(this.RawValues, list3);
									this.HasCheckedItems = true;
									this.HasFilters = false;
								}
								else if (flag4)
								{
									num = this.CreateNotEqualsBasedCheckboxTree(this.RawValues, list3);
									this.HasCheckedItems = true;
									this.HasFilters = false;
								}
								else
								{
									this.CreateAllCheckBoxes(this.RawValues, false);
									this.HasCheckedItems = false;
								}
							}
							else
							{
								this.CreateAllCheckBoxes(this.RawValues, false);
								this.HasCheckedItems = false;
							}
						}
						else
						{
							bool flag5 = count2 == 0;
							if (flag5)
							{
								num = count;
							}
							this.CreateAllCheckBoxes(this.RawValues, flag5);
							this.HasCheckedItems = false;
						}
						bool? selectAllCheckBox;
						if (num == 0)
						{
							selectAllCheckBox = new bool?(false);
						}
						else if (num == count)
						{
							selectAllCheckBox = new bool?(true);
						}
						else
						{
							selectAllCheckBox = null;
						}
						this.SetSelectAllCheckBox(selectAllCheckBox);
						this.IsBusy = false;
						this.IsLoadingData = false;
						this.EnsureCurrentState();
					}, scheduler);
				}
			}
		}

		// Token: 0x060004FD RID: 1277 RVA: 0x0001701C File Offset: 0x0001521C
		protected virtual void OnSelectAllCheckBoxChecked(global::System.Windows.Controls.CheckBox checkBoxSender)
		{
			bool flag = checkBoxSender.IsChecked == true;
			foreach (object obj in this.UniqueValues)
			{
				global::Infragistics.Controls.Grids.Primitives.FilterValueProxy filterValueProxy = (global::Infragistics.Controls.Grids.Primitives.FilterValueProxy)obj;
				filterValueProxy.PropertyChanged -= this.UniqueValue_PropertyChanged;
				filterValueProxy.IsChecked = flag;
				filterValueProxy.PropertyChanged += this.UniqueValue_PropertyChanged;
			}
			if (flag)
			{
				this.CheckedCount = this.UniqueValues.Count;
				this.UncheckedCount = 0;
			}
			else
			{
				this.UncheckedCount = this.UniqueValues.Count;
				this.CheckedCount = 0;
			}
			this.AllowFiltering = (checkBoxSender.IsChecked != false);
		}

		// Token: 0x060004FE RID: 1278 RVA: 0x00017110 File Offset: 0x00015310
		protected virtual global::Infragistics.Controls.Grids.Primitives.FilterItemCollection GetCollection()
		{
			return new global::Infragistics.Controls.Grids.Primitives.FilterValueProxyCollection();
		}

		// Token: 0x060004FF RID: 1279 RVA: 0x00017118 File Offset: 0x00015318
		protected internal virtual void ClearExistingFilters()
		{
			this.AllowFiltering = true;
			if (this.SelectAllCheckBox != null)
			{
				this.SelectAllCheckBox.IsChecked = new bool?(true);
			}
			global::Infragistics.Controls.Grids.CellBase cell = base.Cell;
			string key = cell.Column.Key;
			global::Infragistics.Controls.Grids.RowsManager rowsManager = cell.Row.Manager as global::Infragistics.Controls.Grids.RowsManager;
			if (rowsManager == null)
			{
				return;
			}
			global::Infragistics.Controls.Grids.RowFiltersCollection rowFiltersCollectionResolved = rowsManager.RowFiltersCollectionResolved;
			global::Infragistics.Controls.Grids.RowsFilter rowsFilter = rowFiltersCollectionResolved[key];
			if (rowsFilter == null)
			{
				return;
			}
			rowsFilter.Conditions.Clear();
		}

		// Token: 0x06000500 RID: 1280 RVA: 0x0001719C File Offset: 0x0001539C
		protected virtual void ControlLoaded()
		{
			if (base.Cell != null)
			{
				global::Infragistics.Controls.Grids.FilterColumnSettings filterColumnSettings = base.Cell.Column.FilterColumnSettings;
				filterColumnSettings.ValidateResolvedProperties();
				if (base.Cell.Column.ColumnLayout.Grid != null)
				{
					global::Infragistics.Controls.Grids.FilteringSettings filteringSettings = base.Cell.Column.ColumnLayout.Grid.FilteringSettings;
					this._nullString = filteringSettings.NullValueString;
					this._emptyString = filteringSettings.EmptyValueString;
					this._formatString = filterColumnSettings.FilterMenuFormatStringResolved;
					if (this.SelectAllCheckBox != null)
					{
						this.SelectAllCheckBox.Content = filteringSettings.SelectAllText;
					}
				}
			}
			this.CachedUniqueValues.Clear();
			this.ShowAppendFiltersCheckBox = false;
			this.IsBusy = false;
			this.IsLimited = false;
			this.FilterText = string.Empty;
			base.Dispatcher.BeginInvoke(new global::System.Action(delegate()
			{
				this.OnPropertyChanged("FilterText");
			}), new object[0]);
			this.SetupSelectionBox();
			this.EnsureCurrentState();
			this.EnsureMenuCheckedState();
			this._changeDetected = false;
		}

		// Token: 0x06000501 RID: 1281 RVA: 0x0001729C File Offset: 0x0001549C
		protected virtual void EnsureMenuCheckedState()
		{
			this.HasFilters = this.EnsureMenuCheckedStateHelper(base.Cell.Column.FilterColumnSettings.FilterMenuOperands);
		}

		// Token: 0x06000502 RID: 1282 RVA: 0x000172C0 File Offset: 0x000154C0
		protected virtual void SetSelectAllCheckBox(bool? value)
		{
			this.DetachSelectAllCheckBoxEvents();
			if (this.SelectAllCheckBox != null)
			{
				this.SelectAllCheckBox.IsChecked = value;
			}
			this.AttachSelectAllCheckBoxEvents();
			this._changeDetected = true;
			this.AllowFiltering = (value != false);
		}

		// Token: 0x06000503 RID: 1283 RVA: 0x00017314 File Offset: 0x00015514
		protected virtual int GenerateUniqueList(global::System.Collections.IList items, global::System.Collections.Generic.List<object> values, bool shouldCheck)
		{
			this.UniqueValues.Clear();
			int num = 0;
			global::System.Type dataType = base.Cell.Column.DataType;
			this.IsLimited = (items.Count > 10000);
			int num2 = values.Count;
			for (int i = 0; i < items.Count; i++)
			{
				object obj = items[i];
				bool flag = false;
				for (int j = 0; j < num2; j++)
				{
					object obj2 = values[j];
					if (obj == obj2)
					{
						flag = true;
					}
					else if (obj != null)
					{
						if (dataType == typeof(string))
						{
							if (base.Cell.Column.FilterColumnSettings.FilterCaseSensitive)
							{
								flag = ((string)obj).Equals(obj2 as string);
							}
							else
							{
								flag = ((string)obj).Equals(obj2 as string, global::System.StringComparison.OrdinalIgnoreCase);
							}
						}
						else
						{
							flag = obj.Equals(obj2);
						}
					}
					if (!flag && dataType == typeof(string) && string.IsNullOrEmpty((string)obj) && string.IsNullOrEmpty((string)obj2))
					{
						flag = true;
					}
					if (flag)
					{
						values.Remove(obj2);
						num2--;
						break;
					}
				}
				bool flag2 = shouldCheck ? flag : (!flag);
				if (flag2)
				{
					num++;
				}
				bool isChecked = shouldCheck ? flag : (!flag);
				this.AddUniqueValue(obj, isChecked, dataType, i + 1 > 10000);
			}
			this.UniqueValues.RaiseCollectionChanged();
			this.OnPropertyChanged("FilterableUniqueValues");
			return num;
		}

		// Token: 0x06000504 RID: 1284 RVA: 0x000174A8 File Offset: 0x000156A8
		protected virtual void CreateAllCheckBoxes(global::System.Collections.IList items, bool shouldCheck)
		{
			this.UniqueValuesClear();
			if (base.Cell.Column is global::Infragistics.Controls.Grids.ComboBoxColumnBase)
			{
				this._filterMenuItemDisplayValueConverter = ((global::Infragistics.Controls.Grids.ComboBoxColumnBase)base.Cell.Column).FilterMenuItemConverter;
			}
			global::System.Type dataType = base.Cell.Column.DataType;
			this._isMassEdit = true;
			this.IsLimited = (items.Count > 10000);
			for (int i = 0; i < items.Count; i++)
			{
				object value = items[i];
				this.AddUniqueValue(value, shouldCheck, dataType, i + 1 > 10000);
			}
			this._isMassEdit = false;
			this.UniqueValues.RaiseCollectionChanged();
			this.OnPropertyChanged("FilterableUniqueValues");
		}

		// Token: 0x06000505 RID: 1285 RVA: 0x0001755C File Offset: 0x0001575C
		protected void AttachSelectAllCheckBoxEvents()
		{
			if (this.SelectAllCheckBox != null)
			{
				this.SelectAllCheckBox.Checked += this.SelectAllCheckBox_Checked;
				this.SelectAllCheckBox.Unchecked += this.SelectAllCheckBox_Checked;
				this.SelectAllCheckBox.Indeterminate += this.SelectAllCheckBox_Checked;
			}
		}

		// Token: 0x06000506 RID: 1286 RVA: 0x000175B8 File Offset: 0x000157B8
		protected void DetachSelectAllCheckBoxEvents()
		{
			if (this.SelectAllCheckBox != null)
			{
				this.SelectAllCheckBox.Checked -= this.SelectAllCheckBox_Checked;
				this.SelectAllCheckBox.Unchecked -= this.SelectAllCheckBox_Checked;
				this.SelectAllCheckBox.Indeterminate -= this.SelectAllCheckBox_Checked;
			}
		}

		// Token: 0x06000507 RID: 1287 RVA: 0x00017612 File Offset: 0x00015812
		protected virtual void AddUniqueValue(object value, bool isChecked, global::System.Type type)
		{
			this.AddUniqueValue(value, isChecked, type, false);
		}

		// Token: 0x06000508 RID: 1288 RVA: 0x00017620 File Offset: 0x00015820
		protected virtual void AddUniqueValue(object value, bool isChecked, global::System.Type type, bool limitUniqueValues)
		{
			object convertedValue = null;
			if (this._filterMenuItemDisplayValueConverter != null)
			{
				convertedValue = this._filterMenuItemDisplayValueConverter.Convert(value, typeof(string), null, global::System.Globalization.CultureInfo.CurrentCulture);
			}
			if (!limitUniqueValues)
			{
				global::Infragistics.Controls.Grids.Primitives.FilterValueProxy filterValueProxy = new global::Infragistics.Controls.Grids.Primitives.FilterValueProxy(value, isChecked)
				{
					FormatString = this._formatString,
					DataType = type,
					EmptyString = this._emptyString,
					NullString = this._nullString,
					Column = base.Cell.Column,
					ConvertedValue = convertedValue
				};
				if (isChecked)
				{
					this.CheckedCount++;
				}
				else
				{
					this.UncheckedCount++;
				}
				filterValueProxy.PropertyChanged += this.UniqueValue_PropertyChanged;
				this.UniqueValues.AddSilently(filterValueProxy);
			}
			if (this._boolBuildCachedList)
			{
				global::Infragistics.Controls.Grids.Primitives.FilterValueProxy item = new global::Infragistics.Controls.Grids.Primitives.FilterValueProxy(value, isChecked)
				{
					FormatString = this._formatString,
					DataType = type,
					EmptyString = this._emptyString,
					NullString = this._nullString,
					Column = base.Cell.Column,
					ConvertedValue = convertedValue
				};
				this.CachedUniqueValues.AddSilently(item);
				if (isChecked)
				{
					this.CachedCheckedCount++;
					return;
				}
				this.CachedUncheckedCount++;
			}
		}

		// Token: 0x06000509 RID: 1289 RVA: 0x00017778 File Offset: 0x00015978
		protected virtual void InvalidateShowAppendFilterButton(string filterValue)
		{
			if (string.IsNullOrEmpty(filterValue))
			{
				this.ShowAppendFiltersCheckBox = false;
				this.AppendFilters = false;
			}
			else if (this.UniqueValues != null && this.UniqueValues.Count == 0)
			{
				this.ShowAppendFiltersCheckBox = false;
				this.AppendFilters = false;
			}
			else if (this.FilterableUniqueValues == null)
			{
				this.ShowAppendFiltersCheckBox = false;
				this.AppendFilters = false;
			}
			else
			{
				this.ShowAppendFiltersCheckBox = true;
			}
			this.EnsureCurrentState();
		}

		// Token: 0x0600050A RID: 1290 RVA: 0x000177E8 File Offset: 0x000159E8
		internal string GenerateContentString(object o)
		{
			string formatString = this._formatString;
			if (o == null)
			{
				return this._nullString;
			}
			if (base.Cell.Column.DataType == typeof(string))
			{
				string value = o as string;
				if (string.IsNullOrEmpty(value))
				{
					return this._emptyString;
				}
			}
			else if (base.Cell.Column.DataType == typeof(string))
			{
				string value2 = o as string;
				if (string.IsNullOrEmpty(value2))
				{
					return global::Infragistics.SRGrid.GetString("EmptyContentString");
				}
			}
			if (!string.IsNullOrEmpty(formatString))
			{
				return string.Format(formatString, o);
			}
			return o.ToString();
		}

		// Token: 0x0600050B RID: 1291 RVA: 0x00017890 File Offset: 0x00015A90
		protected internal virtual void FilterUniqueValue(string filterValue)
		{
			this.FilterText = filterValue;
			global::System.Collections.Generic.List<global::System.Threading.CancellationTokenSource> list = new global::System.Collections.Generic.List<global::System.Threading.CancellationTokenSource>(this.Phase2TokenSourceQueue);
			foreach (global::System.Threading.CancellationTokenSource cancellationTokenSource in list)
			{
				cancellationTokenSource.Cancel();
				this.Phase2TokenSourceQueue.Remove(cancellationTokenSource);
			}
			if (this._waitSearchStringTimer.IsEnabled)
			{
				this._waitSearchStringTimer.Stop();
			}
			this._waitSearchStringTimer.Start();
		}

		// Token: 0x0600050C RID: 1292 RVA: 0x00017ABC File Offset: 0x00015CBC
		internal virtual void FilterUniqueValueInternal(string filterValue)
		{
			if (this.CachedUniqueValues != null && this.CachedUniqueValues.Count > 0)
			{
				if (string.IsNullOrEmpty(filterValue))
				{
					this._boolBuildCachedList = false;
					this.RefreshUniqueValues(this.CachedUniqueValues);
					this._boolBuildCachedList = true;
					global::System.Collections.Generic.List<global::System.Threading.CancellationTokenSource> list = new global::System.Collections.Generic.List<global::System.Threading.CancellationTokenSource>(this.Phase2TokenSourceQueue);
					foreach (global::System.Threading.CancellationTokenSource cancellationTokenSource in list)
					{
						cancellationTokenSource.Cancel();
						this.Phase2TokenSourceQueue.Remove(cancellationTokenSource);
					}
					this.IsBusy = false;
					this.InvalidateShowAppendFilterButton(filterValue);
					this.EnsureCurrentState();
					return;
				}
				global::System.Threading.Tasks.TaskScheduler scheduler = global::System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext();
				this.IsBusy = true;
				this.EnsureCurrentState();
				global::System.Threading.CancellationTokenSource source = new global::System.Threading.CancellationTokenSource();
				this.Phase2TokenSourceQueue.Add(source);
				global::System.Threading.Tasks.Task<global::Infragistics.Controls.Grids.Primitives.FilterSelectionControl.Phase2Payload>.Factory.StartNew(delegate()
				{
					global::Infragistics.DataManagerBase dataManagerBase = global::Infragistics.DataManagerBase.CreateDataManager(this.CachedUniqueValues);
					dataManagerBase.Filters = new global::Infragistics.RecordFilterCollection();
					dataManagerBase.Filters.Add(new global::Infragistics.Controls.Grids.FilterValueProxyRowsFilter(typeof(global::Infragistics.Controls.Grids.Primitives.FilterValueProxy), dataManagerBase.CachedTypedInfo));
					dataManagerBase.Filters[0].Conditions.Clear();
					dataManagerBase.Filters[0].Conditions.Add(new global::Infragistics.Controls.Grids.FilterValueProxyStringFilter
					{
						FilterValue = filterValue
					});
					dataManagerBase.UpdateData();
					return new global::Infragistics.Controls.Grids.Primitives.FilterSelectionControl.Phase2Payload
					{
						CancellationTokenSource = source,
						FilteredList = dataManagerBase.SortedFilteredDataSource
					};
				}, source.Token).ContinueWith(delegate(global::System.Threading.Tasks.Task<global::Infragistics.Controls.Grids.Primitives.FilterSelectionControl.Phase2Payload> result)
				{
					if (result.IsCanceled || result.Exception != null || result.Result.CancellationTokenSource.IsCancellationRequested)
					{
						return;
					}
					this._boolBuildCachedList = false;
					this.RefreshUniqueValues(result.Result.FilteredList);
					if (!string.IsNullOrEmpty(filterValue))
					{
						this.SetSelectAllCheckBox(new bool?(true));
					}
					this.InvalidateShowAppendFilterButton(filterValue);
					this._boolBuildCachedList = true;
					this.Phase2TokenSourceQueue.Remove(result.Result.CancellationTokenSource);
					if (this.Phase2TokenSourceQueue.Count == 0)
					{
						this.IsBusy = false;
					}
					this.EnsureCurrentState();
				}, scheduler);
			}
		}

		// Token: 0x0600050D RID: 1293 RVA: 0x00017C18 File Offset: 0x00015E18
		internal virtual void UniqueValuesClear()
		{
			if (this.UniqueValues != null)
			{
				global::System.Collections.IEnumerable list = this.UniqueValues.Cast<global::Infragistics.Controls.Grids.Primitives.FilterValueProxy>();
				this.UniqueValuesClear(list);
				this.UniqueValues.Clear();
			}
		}

		// Token: 0x0600050E RID: 1294 RVA: 0x00017C4C File Offset: 0x00015E4C
		internal virtual void UniqueValuesClear(global::System.Collections.IEnumerable list)
		{
			foreach (object obj in list)
			{
				global::Infragistics.Controls.Grids.Primitives.FilterValueProxy filterValueProxy = (global::Infragistics.Controls.Grids.Primitives.FilterValueProxy)obj;
				filterValueProxy.PropertyChanged -= this.UniqueValue_PropertyChanged;
			}
		}

		// Token: 0x0600050F RID: 1295 RVA: 0x00017CAC File Offset: 0x00015EAC
		private void RefreshUniqueValues(global::System.Collections.IEnumerable values)
		{
			this.UniqueValuesClear();
			this.IsLimited = false;
			global::System.Type dataType = base.Cell.Column.DataType;
			if (string.IsNullOrEmpty(this.FilterText))
			{
				int num = 0;
				using (global::System.Collections.IEnumerator enumerator = values.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						object obj = enumerator.Current;
						global::Infragistics.Controls.Grids.Primitives.FilterValueProxy filterValueProxy = (global::Infragistics.Controls.Grids.Primitives.FilterValueProxy)obj;
						if (++num > 10000)
						{
							this.IsLimited = true;
							break;
						}
						this.AddUniqueValue(filterValueProxy.Value, filterValueProxy.IsChecked, dataType);
					}
					goto IL_EA;
				}
			}
			int num2 = 0;
			foreach (object obj2 in values)
			{
				global::Infragistics.Controls.Grids.Primitives.FilterValueProxy filterValueProxy2 = (global::Infragistics.Controls.Grids.Primitives.FilterValueProxy)obj2;
				if (++num2 > 10000)
				{
					this.IsLimited = true;
					break;
				}
				this.AddUniqueValue(filterValueProxy2.Value, true, dataType);
			}
			IL_EA:
			this.UniqueValues.RaiseCollectionChanged();
			this.OnPropertyChanged("FilterableUniqueValues");
		}

		// Token: 0x06000510 RID: 1296 RVA: 0x00017DD8 File Offset: 0x00015FD8
		private int CreateEqualsBasedCheckboxTree(global::System.Collections.IList items, global::System.Collections.Generic.List<object> values)
		{
			return this.GenerateUniqueList(items, values, true);
		}

		// Token: 0x06000511 RID: 1297 RVA: 0x00017DE3 File Offset: 0x00015FE3
		private int CreateNotEqualsBasedCheckboxTree(global::System.Collections.IList items, global::System.Collections.Generic.List<object> values)
		{
			return this.GenerateUniqueList(items, values, false);
		}

		// Token: 0x06000512 RID: 1298 RVA: 0x00017DF0 File Offset: 0x00015FF0
		internal void ApplyFilterForItem(object value, bool isChecked, global::Infragistics.Controls.Grids.Column col, global::Infragistics.Controls.Grids.ColumnLayout colLayout, global::Infragistics.Controls.Grids.RowsManager rm, global::Infragistics.Controls.Grids.RowsFilter rf, bool raiseEvents)
		{
			bool flag = false;
			global::Infragistics.ComparisonCondition item = null;
			foreach (global::Infragistics.IFilterCondition filterCondition in rf.Conditions)
			{
				global::Infragistics.ComparisonCondition comparisonCondition = (global::Infragistics.ComparisonCondition)filterCondition;
				if (object.Equals(value, comparisonCondition.FilterValue))
				{
					item = comparisonCondition;
					flag = true;
					break;
				}
			}
			if (!isChecked)
			{
				if (!flag)
				{
					if (value == null || (col.DataType == typeof(string) && string.IsNullOrEmpty((string)value)))
					{
						colLayout.BuildNullableFilter(rm.RowFiltersCollectionResolved, col, new global::Infragistics.Controls.Grids.NotEqualsOperand(), true, false, false);
					}
					else
					{
						colLayout.BuildFilters(rm.RowFiltersCollectionResolved, value, col, new global::Infragistics.Controls.Grids.NotEqualsOperand(), true, false, raiseEvents);
					}
					rf.Conditions.LogicalOperator = global::Infragistics.LogicalOperator.And;
					return;
				}
			}
			else if (flag)
			{
				rf.Conditions.RemoveItemSilently(item);
			}
		}

		// Token: 0x06000513 RID: 1299 RVA: 0x00017ED4 File Offset: 0x000160D4
		internal void ApplyNegativeFilterForItem(object value, bool isChecked, global::Infragistics.Controls.Grids.Column col, global::Infragistics.Controls.Grids.ColumnLayout colLayout, global::Infragistics.Controls.Grids.RowsManager rm, global::Infragistics.Controls.Grids.RowsFilter rf, bool raiseEvents)
		{
			bool flag = false;
			global::Infragistics.ComparisonCondition item = null;
			foreach (global::Infragistics.IFilterCondition filterCondition in rf.Conditions)
			{
				global::Infragistics.ComparisonCondition comparisonCondition = (global::Infragistics.ComparisonCondition)filterCondition;
				if (object.Equals(value, comparisonCondition.FilterValue))
				{
					item = comparisonCondition;
					flag = true;
					break;
				}
			}
			if (isChecked)
			{
				if (!flag)
				{
					if (value == null)
					{
						colLayout.BuildNullableFilter(rm.RowFiltersCollectionResolved, col, new global::Infragistics.Controls.Grids.EqualsOperand(), true, false, raiseEvents);
					}
					else
					{
						colLayout.BuildFilters(rm.RowFiltersCollectionResolved, value, col, new global::Infragistics.Controls.Grids.EqualsOperand(), true, false, raiseEvents);
					}
					rf.Conditions.LogicalOperator = global::Infragistics.LogicalOperator.Or;
					return;
				}
			}
			else if (flag)
			{
				rf.Conditions.RemoveItemSilently(item);
			}
		}

		// Token: 0x06000514 RID: 1300 RVA: 0x00017F94 File Offset: 0x00016194
		private void ClearAllMenuChecks(global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.FilterMenuTrackingObject> list)
		{
			if (list == null)
			{
				return;
			}
			if (list.Count == 0)
			{
				return;
			}
			foreach (global::Infragistics.Controls.Grids.FilterMenuTrackingObject filterMenuTrackingObject in list)
			{
				if (!filterMenuTrackingObject.IsSeparator)
				{
					filterMenuTrackingObject.IsChecked = false;
					this.ClearAllMenuChecks(filterMenuTrackingObject.Children);
				}
			}
		}

		// Token: 0x06000515 RID: 1301 RVA: 0x00018004 File Offset: 0x00016204
		private bool EnsureMenuCheckedStateHelper(global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.FilterMenuTrackingObject> list)
		{
			if (list == null)
			{
				return true;
			}
			if (list.Count == 0)
			{
				return false;
			}
			global::Infragistics.Controls.Grids.CellBase cell = base.Cell;
			string key = cell.Column.Key;
			global::Infragistics.Controls.Grids.RowsManager rowsManager = cell.Row.Manager as global::Infragistics.Controls.Grids.RowsManager;
			if (rowsManager == null)
			{
				return false;
			}
			global::Infragistics.Controls.Grids.RowFiltersCollection rowFiltersCollectionResolved = rowsManager.RowFiltersCollectionResolved;
			global::Infragistics.Controls.Grids.RowsFilter rowsFilter = rowFiltersCollectionResolved[key];
			if (rowsFilter == null)
			{
				return false;
			}
			this.ClearAllMenuChecks(list);
			if (rowsFilter.Conditions.Count == 0)
			{
				return false;
			}
			global::Infragistics.Controls.Grids.FilterMenuTrackingObject filterMenuTrackingObject = null;
			foreach (global::Infragistics.Controls.Grids.FilterMenuTrackingObject filterMenuTrackingObject2 in list)
			{
				if (!filterMenuTrackingObject2.IsSeparator)
				{
					if (filterMenuTrackingObject2.IsCustomOption)
					{
						filterMenuTrackingObject = filterMenuTrackingObject2;
					}
					if (filterMenuTrackingObject2.FilterOperands.Count == rowsFilter.Conditions.Count)
					{
						bool flag = false;
						int i = 0;
						while (i < rowsFilter.Conditions.Count)
						{
							global::Infragistics.ComparisonCondition comparisonCondition = rowsFilter.Conditions[i] as global::Infragistics.ComparisonCondition;
							if (comparisonCondition == null)
							{
								goto IL_145;
							}
							if (!flag)
							{
								using (global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.FilterOperand>.Enumerator enumerator2 = filterMenuTrackingObject2.FilterOperands.GetEnumerator())
								{
									while (enumerator2.MoveNext())
									{
										if (enumerator2.Current.ComparisonOperatorValue == comparisonCondition.Operator)
										{
											flag = true;
											break;
										}
										flag = false;
									}
									goto IL_1B9;
								}
								goto IL_145;
							}
							IL_1B9:
							i++;
							continue;
							IL_145:
							global::Infragistics.CustomComparisonCondition customComparisonCondition = rowsFilter.Conditions[i] as global::Infragistics.CustomComparisonCondition;
							if (customComparisonCondition == null)
							{
								goto IL_1B9;
							}
							global::System.Type filterOperand = customComparisonCondition.FilterOperand;
							if (!flag)
							{
								foreach (global::Infragistics.Controls.Grids.FilterOperand filterOperand2 in filterMenuTrackingObject2.FilterOperands)
								{
									global::System.Type type = filterOperand2.GetType();
									if (type == filterOperand)
									{
										flag = true;
										break;
									}
									flag = false;
								}
								goto IL_1B9;
							}
							goto IL_1B9;
						}
						if (flag)
						{
							filterMenuTrackingObject2.IsChecked = true;
							return true;
						}
						filterMenuTrackingObject2.IsChecked = false;
					}
					if (this.EnsureMenuCheckedStateHelper(filterMenuTrackingObject2.Children))
					{
						filterMenuTrackingObject2.IsChecked = true;
						return true;
					}
					if (!this._hasCheckedItems && filterMenuTrackingObject != null)
					{
						filterMenuTrackingObject.IsChecked = true;
						return true;
					}
					filterMenuTrackingObject2.IsChecked = false;
				}
			}
			return false;
		}

		// Token: 0x06000516 RID: 1302 RVA: 0x000182B8 File Offset: 0x000164B8
		private void ProcessChanges(int checkedCount, int uncheckedCount, global::System.Collections.IList list)
		{
			global::Infragistics.Controls.Grids.CellBase cell = base.Cell;
			string key = cell.Column.Key;
			global::Infragistics.Controls.Grids.RowsManager rowsManager = cell.Row.Manager as global::Infragistics.Controls.Grids.RowsManager;
			if (rowsManager == null)
			{
				return;
			}
			global::Infragistics.Controls.Grids.RowFiltersCollection rowFiltersCollectionResolved = rowsManager.RowFiltersCollectionResolved;
			global::Infragistics.Controls.Grids.RowsFilter rowsFilter = rowFiltersCollectionResolved[key];
			if (rowsFilter == null)
			{
				return;
			}
			global::Infragistics.Controls.Grids.Column column = base.Cell.Column;
			global::Infragistics.Controls.Grids.ColumnLayout columnLayout = column.ColumnLayout;
			bool flag = checkedCount <= uncheckedCount && checkedCount != 0;
			if (rowsFilter.Conditions.Any<global::Infragistics.IFilterCondition>())
			{
				global::Infragistics.ComparisonCondition comparisonCondition = (global::Infragistics.ComparisonCondition)rowsFilter.Conditions[0];
				if (comparisonCondition.Operator == global::Infragistics.ComparisonOperator.Equals)
				{
					flag = true;
				}
				else if (comparisonCondition.Operator == global::Infragistics.ComparisonOperator.NotEquals)
				{
					flag = false;
				}
			}
			if (!flag)
			{
				using (global::System.Collections.IEnumerator enumerator = list.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						object obj = enumerator.Current;
						global::Infragistics.Controls.Grids.Primitives.FilterValueProxy filterValueProxy = (global::Infragistics.Controls.Grids.Primitives.FilterValueProxy)obj;
						this.ApplyFilterForItem(filterValueProxy.Value, filterValueProxy.IsChecked, column, columnLayout, rowsManager, rowsFilter, true);
					}
					return;
				}
			}
			global::System.Collections.Generic.List<object> newValue = (from global::Infragistics.Controls.Grids.Primitives.FilterValueProxy fvp in list
			where fvp.IsChecked
			select fvp into fvp1
			select fvp1.Value).ToList<object>();
			columnLayout.BuildFilters(rowsManager.RowFiltersCollectionResolved, newValue, column, new global::Infragistics.Controls.Grids.InOperand(), true, false, true);
		}

		// Token: 0x06000517 RID: 1303 RVA: 0x0001843C File Offset: 0x0001663C
		private void WaitSearchStringTimer_Tick(object sender, global::System.EventArgs e)
		{
			this._waitSearchStringTimer.Stop();
			this.FilterUniqueValueInternal(this.FilterText);
		}

		// Token: 0x06000518 RID: 1304 RVA: 0x00018455 File Offset: 0x00016655
		private void BusyIndicatorStartTimer_Tick(object sender, global::System.EventArgs e)
		{
			this._busyIndicatorStartTimer.Tick -= this.BusyIndicatorStartTimer_Tick;
			this._busyIndicatorStartTimer.Stop();
			if (this.DelayIsBusy)
			{
				this.DelayIsBusy = false;
				this.IsBusy = true;
				this.EnsureCurrentState();
			}
		}

		// Token: 0x06000519 RID: 1305 RVA: 0x00018498 File Offset: 0x00016698
		private void FilterSelectionControl_Loaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			this.IsLoaded = true;
			if (this._waitSearchStringTimer == null)
			{
				this._waitSearchStringTimer = new global::System.Windows.Threading.DispatcherTimer
				{
					Interval = new global::System.TimeSpan(0, 0, 0, 0, 400)
				};
				this._waitSearchStringTimer.Tick += this.WaitSearchStringTimer_Tick;
			}
			this.ControlLoaded();
		}

		// Token: 0x0600051A RID: 1306 RVA: 0x000184F4 File Offset: 0x000166F4
		private void FilterSelectionControl_Unloaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			this.IsLoaded = false;
			if (this._phase1TokenSource != null)
			{
				this._phase1TokenSource.Cancel();
			}
			global::System.Collections.Generic.List<global::System.Threading.CancellationTokenSource> list = new global::System.Collections.Generic.List<global::System.Threading.CancellationTokenSource>(this.Phase2TokenSourceQueue);
			foreach (global::System.Threading.CancellationTokenSource cancellationTokenSource in list)
			{
				cancellationTokenSource.Cancel();
				this.Phase2TokenSourceQueue.Remove(cancellationTokenSource);
			}
			this.IsBusy = false;
			this.EnsureCurrentState();
			this.RawValues = null;
			this.UniqueValuesClear();
			this._filterText = string.Empty;
			if (this._waitSearchStringTimer != null)
			{
				this._waitSearchStringTimer.Tick -= this.WaitSearchStringTimer_Tick;
				if (this._waitSearchStringTimer.IsEnabled)
				{
					this._waitSearchStringTimer.Stop();
				}
				this._waitSearchStringTimer = null;
			}
		}

		// Token: 0x0600051B RID: 1307 RVA: 0x000185D8 File Offset: 0x000167D8
		private void SelectAllCheckBox_Checked(object sender, global::System.Windows.RoutedEventArgs e)
		{
			global::System.Windows.Controls.CheckBox checkBoxSender = (global::System.Windows.Controls.CheckBox)sender;
			this.OnSelectAllCheckBoxChecked(checkBoxSender);
			this._changeDetected = true;
		}

		// Token: 0x0600051C RID: 1308 RVA: 0x000185FC File Offset: 0x000167FC
		private void UniqueValue_PropertyChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.Primitives.FilterValueProxy filterValueProxy = (global::Infragistics.Controls.Grids.Primitives.FilterValueProxy)sender;
			if (e.PropertyName == "IsChecked")
			{
				bool flag = filterValueProxy.IsChecked;
				bool flag2 = !filterValueProxy.IsChecked;
				foreach (object obj in this.UniqueValues)
				{
					global::Infragistics.Controls.Grids.Primitives.FilterValueProxy filterValueProxy2 = (global::Infragistics.Controls.Grids.Primitives.FilterValueProxy)obj;
					if (filterValueProxy2 != filterValueProxy)
					{
						if (filterValueProxy2.IsChecked)
						{
							flag = true;
						}
						else
						{
							flag2 = true;
						}
						if (flag && flag2)
						{
							break;
						}
					}
				}
				if (filterValueProxy.IsChecked)
				{
					this.UncheckedCount--;
					this.CheckedCount++;
				}
				else
				{
					this.UncheckedCount++;
					this.CheckedCount--;
				}
				bool? selectAllCheckBox;
				if (flag && flag2)
				{
					selectAllCheckBox = null;
				}
				else if (flag)
				{
					selectAllCheckBox = new bool?(true);
				}
				else
				{
					selectAllCheckBox = new bool?(false);
				}
				this.SetSelectAllCheckBox(selectAllCheckBox);
				this._changeDetected = true;
			}
		}

		// Token: 0x0600051D RID: 1309 RVA: 0x00018710 File Offset: 0x00016910
		private void UniqueValues_CollectionChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			this.OnUniqueValuesCollectionChanged(sender, e);
		}

		// Token: 0x0600051E RID: 1310 RVA: 0x0001871A File Offset: 0x0001691A
		protected virtual void OnUniqueValuesCollectionChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			if (!this._isMassEdit)
			{
				this.EnsureCurrentState();
			}
		}

		// Token: 0x0400013D RID: 317
		internal const int Limit = 10000;

		// Token: 0x0400013E RID: 318
		private bool _boolBuildCachedList = true;

		// Token: 0x0400013F RID: 319
		private bool _itemSourceSet;

		// Token: 0x04000140 RID: 320
		private bool _hasFilters;

		// Token: 0x04000141 RID: 321
		private bool _hasCheckedItems;

		// Token: 0x04000142 RID: 322
		private bool _isMassEdit;

		// Token: 0x04000143 RID: 323
		private bool _changeDetected;

		// Token: 0x04000144 RID: 324
		private bool _isBusy;

		// Token: 0x04000145 RID: 325
		private bool _isInDesignMode;

		// Token: 0x04000146 RID: 326
		private bool _allowFiltering;

		// Token: 0x04000147 RID: 327
		private string _formatString;

		// Token: 0x04000148 RID: 328
		private string _nullString;

		// Token: 0x04000149 RID: 329
		private string _emptyString;

		// Token: 0x0400014A RID: 330
		private string _filterText;

		// Token: 0x0400014B RID: 331
		private global::Infragistics.Controls.Grids.Primitives.FilterItemCollection _uniqueValues;

		// Token: 0x0400014C RID: 332
		private global::Infragistics.Controls.Grids.Primitives.FilterItemCollection _cachedUniqueValues;

		// Token: 0x0400014D RID: 333
		private global::System.Threading.CancellationTokenSource _phase1TokenSource;

		// Token: 0x0400014E RID: 334
		private global::System.Collections.Generic.List<global::System.Threading.CancellationTokenSource> _phase2TokenSourceQueue = new global::System.Collections.Generic.List<global::System.Threading.CancellationTokenSource>();

		// Token: 0x0400014F RID: 335
		private global::System.Windows.Threading.DispatcherTimer _waitSearchStringTimer;

		// Token: 0x04000150 RID: 336
		private global::System.Windows.Threading.DispatcherTimer _busyIndicatorStartTimer;

		// Token: 0x04000151 RID: 337
		private global::System.Windows.Data.IValueConverter _filterMenuItemDisplayValueConverter;

		// Token: 0x04000152 RID: 338
		public static readonly global::System.Windows.DependencyProperty ClearFiltersTextProperty = global::System.Windows.DependencyProperty.Register("ClearFiltersText", typeof(string), typeof(global::Infragistics.Controls.Grids.Primitives.FilterSelectionControl), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.Primitives.FilterSelectionControl.ClearFiltersTextChanged)));

		// Token: 0x04000153 RID: 339
		public static readonly global::System.Windows.DependencyProperty TypeSpecificFiltersTextProperty = global::System.Windows.DependencyProperty.Register("TypeSpecificFiltersText", typeof(string), typeof(global::Infragistics.Controls.Grids.Primitives.FilterSelectionControl), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.Primitives.FilterSelectionControl.TypeSpecificFiltersTextChanged)));

		// Token: 0x04000154 RID: 340
		public static readonly global::System.Windows.DependencyProperty CancelButtonTextProperty = global::System.Windows.DependencyProperty.Register("CancelButtonText", typeof(string), typeof(global::Infragistics.Controls.Grids.Primitives.FilterSelectionControl), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.Primitives.FilterSelectionControl.CancelButtonTextChanged)));

		// Token: 0x04000155 RID: 341
		public static readonly global::System.Windows.DependencyProperty OKButtonTextProperty = global::System.Windows.DependencyProperty.Register("OKButtonText", typeof(string), typeof(global::Infragistics.Controls.Grids.Primitives.FilterSelectionControl), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.Primitives.FilterSelectionControl.OKButtonTextChanged)));

		// Token: 0x04000156 RID: 342
		public static readonly global::System.Windows.DependencyProperty NotAllItemsShowingTextProperty = global::System.Windows.DependencyProperty.Register("NotAllItemsShowingText", typeof(string), typeof(global::Infragistics.Controls.Grids.Primitives.FilterSelectionControl), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.Primitives.FilterSelectionControl.NotAllItemsShowingTextChanged)));

		// Token: 0x04000157 RID: 343
		public static readonly global::System.Windows.DependencyProperty NotAllItemsShowingTooltipTextProperty = global::System.Windows.DependencyProperty.Register("NotAllItemsShowingTooltipText", typeof(string), typeof(global::Infragistics.Controls.Grids.Primitives.FilterSelectionControl), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.Primitives.FilterSelectionControl.NotAllItemsShowingTooltipTextChanged)));

		// Token: 0x04000158 RID: 344
		public static readonly global::System.Windows.DependencyProperty ClearFiltersTextResolvedProperty = global::System.Windows.DependencyProperty.Register("ClearFiltersTextResolved", typeof(string), typeof(global::Infragistics.Controls.Grids.Primitives.FilterSelectionControl), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.Primitives.FilterSelectionControl.ClearFiltersTextResolvedChanged)));

		// Token: 0x04000159 RID: 345
		public static readonly global::System.Windows.DependencyProperty TypeSpecificFiltersTextResolvedProperty = global::System.Windows.DependencyProperty.Register("TypeSpecificFiltersTextResolved", typeof(string), typeof(global::Infragistics.Controls.Grids.Primitives.FilterSelectionControl), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.Primitives.FilterSelectionControl.TypeSpecificFiltersTextResolvedChanged)));

		// Token: 0x0400015A RID: 346
		public static readonly global::System.Windows.DependencyProperty AppendFilterTextProperty = global::System.Windows.DependencyProperty.Register("AppendFilterText", typeof(string), typeof(global::Infragistics.Controls.Grids.Primitives.FilterSelectionControl), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.Primitives.FilterSelectionControl.AppendFilterTextChanged)));

		// Token: 0x0400015B RID: 347
		public static readonly global::System.Windows.DependencyProperty AppendFiltersProperty = global::System.Windows.DependencyProperty.Register("AppendFilters", typeof(bool), typeof(global::Infragistics.Controls.Grids.Primitives.FilterSelectionControl), new global::System.Windows.PropertyMetadata(false, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.Primitives.FilterSelectionControl.AppendFiltersChanged)));

		// Token: 0x02000086 RID: 134
		internal class Phase2Payload
		{
			// Token: 0x17000165 RID: 357
			// (get) Token: 0x06000523 RID: 1315 RVA: 0x0001872A File Offset: 0x0001692A
			// (set) Token: 0x06000524 RID: 1316 RVA: 0x00018732 File Offset: 0x00016932
			public global::System.Threading.CancellationTokenSource CancellationTokenSource { get; set; }

			// Token: 0x17000166 RID: 358
			// (get) Token: 0x06000525 RID: 1317 RVA: 0x0001873B File Offset: 0x0001693B
			// (set) Token: 0x06000526 RID: 1318 RVA: 0x00018743 File Offset: 0x00016943
			public global::System.Collections.IList FilteredList { get; set; }
		}
	}
}
