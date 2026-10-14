using System;
using System.ComponentModel;
using System.IO;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Threading;
using Infragistics.AutomationPeers;
using Infragistics.Controls.Editors.Primitives;
using Infragistics.Controls.Primitives;
using Infragistics.Themes;
using Infragistics.Windows;
using Infragistics.Windows.Licensing;
using Microsoft.Windows.Themes;

namespace Infragistics.Controls.Editors
{
	// Token: 0x02000006 RID: 6
	[global::System.Windows.TemplatePart(Name = "PART_DropDownButton", Type = typeof(global::System.Windows.Controls.Primitives.ToggleButton))]
	[global::Infragistics.Windows.Licensing.UltraLicense("XamDateTimeInput")]
	[global::System.Windows.TemplateVisualState(Name = "FocusedDropDown", GroupName = "FocusStates")]
	[global::System.Windows.TemplatePart(Name = "PART_Calendar", Type = typeof(global::Infragistics.Controls.Editors.XamCalendar))]
	[global::System.Windows.StyleTypedProperty(Property = "DropDownButtonStyle", StyleTargetType = typeof(global::System.Windows.Controls.Primitives.ToggleButton))]
	[global::System.Windows.TemplatePart(Name = "PART_Popup", Type = typeof(global::System.Windows.Controls.Primitives.Popup))]
	[global::System.ComponentModel.LicenseProvider(typeof(global::Infragistics.Windows.Licensing.UltraLicenseProvider))]
	public class XamDateTimeInput : global::Infragistics.Controls.Editors.XamMaskedInput
	{
		// Token: 0x0600001B RID: 27 RVA: 0x000023CC File Offset: 0x000005CC
		static XamDateTimeInput()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Controls.Editors.XamDateTimeInput), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Controls.Editors.XamDateTimeInput)));
			global::Infragistics.Themes.ThemeManager.RegisterControl(typeof(global::Infragistics.Controls.Editors.XamDateTimeInput));
		}

		// Token: 0x0600001C RID: 28 RVA: 0x0000264C File Offset: 0x0000084C
		public XamDateTimeInput()
		{
			try
			{
				this._license = (global::System.ComponentModel.LicenseManager.Validate(typeof(global::Infragistics.Controls.Editors.XamDateTimeInput), this) as global::Infragistics.Windows.Licensing.UltraLicense);
			}
			catch (global::System.IO.FileNotFoundException)
			{
			}
			this._cachedAllowDropDownResolved = (bool)global::Infragistics.DependencyPropertyUtilities.GetDefaultValue(this, global::Infragistics.Controls.Editors.XamDateTimeInput.AllowDropDownResolvedProperty);
			this._cachedIsDropDownOpen = (bool)global::Infragistics.DependencyPropertyUtilities.GetDefaultValue(this, global::Infragistics.Controls.Editors.XamDateTimeInput.IsDropDownOpenProperty);
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600001D RID: 29 RVA: 0x000026BC File Offset: 0x000008BC
		protected override global::System.Type DefaultValueType
		{
			get
			{
				return typeof(global::System.DateTime);
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600001E RID: 30 RVA: 0x000026C8 File Offset: 0x000008C8
		internal override bool HasDropDown
		{
			get
			{
				return this.AllowDropDownResolved;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600001F RID: 31 RVA: 0x000026D0 File Offset: 0x000008D0
		internal override bool HasOpenDropDown
		{
			get
			{
				return this.IsDropDownOpen;
			}
		}

		// Token: 0x06000020 RID: 32 RVA: 0x000026D8 File Offset: 0x000008D8
		internal override void InitializeValueProperties()
		{
			if (global::Infragistics.Controls.Editors.Primitives.Utils.IsValuePropertySet(global::Infragistics.Controls.Editors.XamDateTimeInput.DateValueProperty, this) && !global::Infragistics.Controls.Editors.Primitives.Utils.IsValuePropertySet(global::Infragistics.Controls.Editors.ValueInput.ValueProperty, this))
			{
				base.SyncValueProperties(global::Infragistics.Controls.Editors.XamDateTimeInput.DateValueProperty, this.DateValue);
				return;
			}
			base.InitializeValueProperties();
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002714 File Offset: 0x00000914
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();
			if (this._dropDownManager != null)
			{
				this._dropDownManager.Dispose();
				this._dropDownManager = null;
			}
			if (this._calendar != null)
			{
				this._calendar.SelectionCommitted -= this.OnSelectionCommitted;
			}
			this._popup = (base.GetTemplateChild("PART_Popup") as global::System.Windows.Controls.Primitives.Popup);
			this._dropDownButton = (base.GetTemplateChild("PART_DropDownButton") as global::System.Windows.Controls.Primitives.ToggleButton);
			this._calendar = (base.GetTemplateChild("PART_Calendar") as global::Infragistics.Controls.Editors.XamCalendar);
			if (this._calendar != null)
			{
				this._calendar.SelectionCommitted += this.OnSelectionCommitted;
			}
			if (this._dropDownButton != null)
			{
				global::Infragistics.Controls.Primitives.ControlDropDownManager.InitializeIfNotDefault(this._dropDownButton, global::System.Windows.FrameworkElement.WidthProperty, global::System.Windows.SystemParameters.VerticalScrollBarWidth);
			}
			global::Microsoft.Windows.Themes.SystemDropShadowChrome systemDropShadowChrome = null;
			if (this._popup != null)
			{
				this._popup.SetBinding(global::System.Windows.Controls.Primitives.Popup.IsOpenProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Controls.Editors.XamDateTimeInput.IsDropDownOpenProperty, global::System.Windows.Data.BindingMode.TwoWay, this));
				systemDropShadowChrome = new global::Microsoft.Windows.Themes.SystemDropShadowChrome();
				if (this._popup.HasDropShadow)
				{
					systemDropShadowChrome.Margin = new global::System.Windows.Thickness(0.0, 0.0, 5.0, 5.0);
					systemDropShadowChrome.Color = global::System.Windows.Media.Color.FromArgb(113, 0, 0, 0);
				}
				else
				{
					systemDropShadowChrome.Color = global::System.Windows.Media.Colors.Transparent;
				}
			}
			if (this._popup != null)
			{
				this._dropDownManager = new global::Infragistics.Controls.Primitives.ControlDropDownManager(this, this._popup, this._dropDownButton, new global::System.Action(this.OnPopopOpened), new global::System.Action(this.OnPopupClosed), systemDropShadowChrome);
			}
		}

		// Token: 0x06000022 RID: 34 RVA: 0x000028A2 File Offset: 0x00000AA2
		protected override void OnGotFocus(global::System.Windows.RoutedEventArgs e)
		{
			base.OnGotFocus(e);
			if (this.IsDropDownOpen && this._calendar != null)
			{
				this._calendar.Focus();
			}
			this.UpdateDropDownButtonVisibility();
		}

		// Token: 0x06000023 RID: 35 RVA: 0x000028CD File Offset: 0x00000ACD
		protected override void OnInitialized(global::System.EventArgs e)
		{
			base.OnInitialized(e);
			if (this._isInitialized)
			{
				return;
			}
			this._isInitialized = true;
			this.ResolveAllowDropDown();
			this.UpdateDropDownButtonVisibility(this.AllowDropDownResolved);
			this.UpdateComputedDates();
		}

		// Token: 0x06000024 RID: 36 RVA: 0x000028FE File Offset: 0x00000AFE
		protected override void OnIsKeyboardFocusWithinChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			base.OnIsKeyboardFocusWithinChanged(e);
			if (this.IsDropDownOpen && this._calendar != null)
			{
				this._calendar.Focus();
			}
			this.UpdateDropDownButtonVisibility();
		}

		// Token: 0x06000025 RID: 37 RVA: 0x0000292C File Offset: 0x00000B2C
		protected override void OnKeyDown(global::System.Windows.Input.KeyEventArgs e)
		{
			global::System.Windows.Input.Key key = e.Key;
			if (key != global::System.Windows.Input.Key.Return && key != global::System.Windows.Input.Key.Escape)
			{
				if (key == global::System.Windows.Input.Key.F4)
				{
					if (global::System.Windows.Input.Keyboard.Modifiers == global::System.Windows.Input.ModifierKeys.None)
					{
						this.ToggleDropDown();
						e.Handled = true;
					}
				}
			}
			else if (this.IsDropDownOpen && (e.Key == global::System.Windows.Input.Key.Return || e.Key == global::System.Windows.Input.Key.Escape))
			{
				this.ToggleDropDown();
				e.Handled = true;
			}
			base.OnKeyDown(e);
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002995 File Offset: 0x00000B95
		protected override void OnMouseEnter(global::System.Windows.Input.MouseEventArgs e)
		{
			base.OnMouseEnter(e);
			this.UpdateDropDownButtonVisibility();
		}

		// Token: 0x06000027 RID: 39 RVA: 0x000029A4 File Offset: 0x00000BA4
		protected override void OnMouseLeave(global::System.Windows.Input.MouseEventArgs e)
		{
			base.OnMouseLeave(e);
			this.UpdateDropDownButtonVisibility();
		}

		// Token: 0x06000028 RID: 40 RVA: 0x000029B3 File Offset: 0x00000BB3
		protected override void OnIsReadOnlyChanged()
		{
			this.ResolveAllowDropDown();
		}

		// Token: 0x06000029 RID: 41 RVA: 0x000029BC File Offset: 0x00000BBC
		internal override void ProcessPropertyChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			base.ProcessPropertyChanged(e);
			global::System.Windows.DependencyProperty property = e.Property;
			if (global::System.Windows.UIElement.IsMouseOverProperty == property || global::Infragistics.Controls.Editors.XamDateTimeInput.DropDownButtonDisplayModeProperty == property || global::System.Windows.UIElement.IsKeyboardFocusWithinProperty == property)
			{
				this.UpdateDropDownButtonVisibility(this.AllowDropDownResolved);
			}
		}

		// Token: 0x0600002A RID: 42 RVA: 0x000029FC File Offset: 0x00000BFC
		internal override void OnSectionsChanged()
		{
			base.OnSectionsChanged();
			global::Infragistics.Controls.Editors.CalendarZoomMode? calendarZoomMode = null;
			bool? flag = null;
			if (base.Sections != null)
			{
				foreach (global::Infragistics.Controls.Editors.SectionBase sectionBase in base.Sections)
				{
					if (sectionBase is global::Infragistics.Controls.Editors.DaySection)
					{
						calendarZoomMode = new global::Infragistics.Controls.Editors.CalendarZoomMode?(global::Infragistics.Controls.Editors.CalendarZoomMode.Days);
					}
					else if (sectionBase is global::Infragistics.Controls.Editors.MonthSection)
					{
						if (calendarZoomMode == null || calendarZoomMode > global::Infragistics.Controls.Editors.CalendarZoomMode.Months)
						{
							calendarZoomMode = new global::Infragistics.Controls.Editors.CalendarZoomMode?(global::Infragistics.Controls.Editors.CalendarZoomMode.Months);
						}
					}
					else if (sectionBase is global::Infragistics.Controls.Editors.YearSection && (calendarZoomMode == null || calendarZoomMode > global::Infragistics.Controls.Editors.CalendarZoomMode.Years))
					{
						calendarZoomMode = new global::Infragistics.Controls.Editors.CalendarZoomMode?(global::Infragistics.Controls.Editors.CalendarZoomMode.Years);
					}
					if (sectionBase is global::Infragistics.Controls.Editors.HourSection || sectionBase is global::Infragistics.Controls.Editors.MinuteSection || sectionBase is global::Infragistics.Controls.Editors.AMPMSection || sectionBase is global::Infragistics.Controls.Editors.SecondSection)
					{
						if (flag == null)
						{
							flag = new bool?(true);
						}
					}
					else if (sectionBase is global::Infragistics.Controls.Editors.EditSectionBase)
					{
						flag = new bool?(false);
					}
				}
				this._hasTimeSectionsOnly = (flag == true);
				if (calendarZoomMode == null)
				{
					calendarZoomMode = new global::Infragistics.Controls.Editors.CalendarZoomMode?(global::Infragistics.Controls.Editors.CalendarZoomMode.Days);
				}
			}
			else
			{
				calendarZoomMode = new global::Infragistics.Controls.Editors.CalendarZoomMode?(global::Infragistics.Controls.Editors.CalendarZoomMode.Days);
				this._hasTimeSectionsOnly = false;
			}
			base.SetValue(global::Infragistics.Controls.Editors.XamDateTimeInput.ComputedMinCalendarModePropertyKey, calendarZoomMode);
			this.ResolveAllowDropDown();
			this.UpdateDropDownButtonVisibility(this.AllowDropDownResolved);
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002B80 File Offset: 0x00000D80
		internal override void OnValueConstraintChanged(string valueConstraintPropertyName)
		{
			base.OnValueConstraintChanged(valueConstraintPropertyName);
			this.UpdateComputedDates();
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002B8F File Offset: 0x00000D8F
		internal override void RaiseDropDownClosedIfPending()
		{
			if (this._isClosePending)
			{
				this._isClosePending = false;
				this.RaiseDropDownClosed(new global::System.Windows.RoutedEventArgs());
			}
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002BAC File Offset: 0x00000DAC
		internal override bool SyncValuePropertiesOverride(global::System.Windows.DependencyProperty prop, object newValue, out global::System.Exception error)
		{
			if (global::Infragistics.Controls.Editors.XamDateTimeInput.DateValueProperty != prop)
			{
				bool result = base.SyncValuePropertiesOverride(prop, newValue, out error);
				global::Infragistics.Controls.Editors.SectionsCollection sections = base.Sections;
				object obj;
				if (!base.IsValueValid)
				{
					obj = global::Infragistics.Controls.Editors.XamMaskedInput.InternalGetDateValue(sections);
				}
				else
				{
					object value = base.Value;
					obj = ((value is global::System.DateTime) ? value : null);
					string text;
					if (obj == null && !global::Infragistics.CoreUtilities.IsValueEmpty(value) && sections != null && global::Infragistics.Controls.Editors.XamMaskedInput.IsMaskValidForDataType(typeof(global::System.DateTime), sections) && base.IsInputValid(sections, out text))
					{
						try
						{
							obj = global::Infragistics.Controls.Editors.XamMaskedInput.InternalGetDateTimeValue(base.Sections);
						}
						catch
						{
						}
					}
					if (obj == null)
					{
						obj = global::Infragistics.CoreUtilities.ConvertDataValue(value, typeof(global::System.DateTime), base.FormatProviderResolved, base.Format);
					}
				}
				base.SetValue(global::Infragistics.Controls.Editors.XamDateTimeInput.DateValueProperty, (global::System.DBNull.Value != obj) ? obj : null);
				return result;
			}
			global::System.DateTime? dateTime = (global::System.DateTime?)newValue;
			global::Infragistics.Controls.Editors.MaskInfo maskInfo = base.MaskInfo;
			global::Infragistics.Controls.Editors.EditInfo editInfo = base.EditInfo;
			global::Infragistics.Controls.Editors.SectionsCollection sections2 = maskInfo.Sections;
			if (editInfo == null)
			{
				object value2 = null;
				if (dateTime != null)
				{
					object obj2 = base.Value;
					if (!global::Infragistics.CoreUtilities.IsValueEmpty(obj2) && !(obj2 is global::System.DateTime))
					{
						obj2 = global::Infragistics.CoreUtilities.ConvertDataValue(obj2, typeof(global::System.DateTime), base.FormatProviderResolved, base.Format);
					}
					if (obj2 is global::System.DateTime)
					{
						global::System.DateTime dateTime2 = (global::System.DateTime)obj2;
						value2 = sections2.Calendar.ToDateTime(dateTime.Value.Year, dateTime.Value.Month, dateTime.Value.Day, dateTime2.Hour, dateTime2.Minute, dateTime2.Second, dateTime2.Millisecond);
					}
					else
					{
						value2 = dateTime;
					}
				}
				base.SetValue(global::Infragistics.Controls.Editors.ValueInput.ValueProperty, value2);
				return base.SyncValuePropertiesOverride(global::Infragistics.Controls.Editors.ValueInput.ValueProperty, base.Value, out error);
			}
			string text2 = global::Infragistics.Controls.Editors.XamMaskedInput.GetText(sections2, global::Infragistics.Controls.Editors.InputMaskMode.IncludeBoth, maskInfo);
			if (dateTime != null)
			{
				global::Infragistics.Controls.Editors.XamMaskedInput.SetDateTimeValue(sections2, dateTime.Value, editInfo.MaskInfo, true);
			}
			else
			{
				global::Infragistics.Controls.Editors.YearSection yearSection = (global::Infragistics.Controls.Editors.YearSection)global::Infragistics.Controls.Editors.XamMaskedInput.GetSection(sections2, typeof(global::Infragistics.Controls.Editors.YearSection));
				global::Infragistics.Controls.Editors.MonthSection monthSection = (global::Infragistics.Controls.Editors.MonthSection)global::Infragistics.Controls.Editors.XamMaskedInput.GetSection(sections2, typeof(global::Infragistics.Controls.Editors.MonthSection));
				global::Infragistics.Controls.Editors.DaySection daySection = (global::Infragistics.Controls.Editors.DaySection)global::Infragistics.Controls.Editors.XamMaskedInput.GetSection(sections2, typeof(global::Infragistics.Controls.Editors.DaySection));
				yearSection.EraseAllChars();
				monthSection.EraseAllChars();
				daySection.EraseAllChars();
			}
			string text3 = global::Infragistics.Controls.Editors.XamMaskedInput.GetText(sections2, global::Infragistics.Controls.Editors.InputMaskMode.IncludeBoth, maskInfo);
			if (text2 != text3)
			{
				editInfo.OnTextChanged(true, null, false, null);
				try
				{
					base.Value = editInfo.Value;
				}
				catch (global::System.Exception ex)
				{
					base.Value = null;
					error = ex;
					return false;
				}
				finally
				{
					base.SyncDisplayText();
					editInfo.SyncIMETextBox(false);
				}
				error = null;
				return true;
			}
			error = null;
			return true;
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002EAC File Offset: 0x000010AC
		internal override void ToggleDropDown()
		{
			this.IsDropDownOpen = !this.IsDropDownOpen;
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002EC0 File Offset: 0x000010C0
		private static void OnAllowDropDownChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Editors.XamDateTimeInput xamDateTimeInput = (global::Infragistics.Controls.Editors.XamDateTimeInput)d;
			xamDateTimeInput.ResolveAllowDropDown();
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002EDC File Offset: 0x000010DC
		private void ResolveAllowDropDown()
		{
			bool? allowDropDown = this.AllowDropDown;
			if (this._hasTimeSectionsOnly)
			{
				allowDropDown = new bool?(false);
			}
			if (!base.IsEditingAllowed)
			{
				allowDropDown = new bool?(false);
			}
			if (allowDropDown == null)
			{
				allowDropDown = new bool?(true);
			}
			this.AllowDropDownResolved = allowDropDown.Value;
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000031 RID: 49 RVA: 0x00002F2E File Offset: 0x0000112E
		// (set) Token: 0x06000032 RID: 50 RVA: 0x00002F40 File Offset: 0x00001140
		public bool? AllowDropDown
		{
			get
			{
				return (bool?)base.GetValue(global::Infragistics.Controls.Editors.XamDateTimeInput.AllowDropDownProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Editors.XamDateTimeInput.AllowDropDownProperty, value);
			}
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002F54 File Offset: 0x00001154
		private static void OnAllowDropDownResolvedChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Editors.XamDateTimeInput xamDateTimeInput = (global::Infragistics.Controls.Editors.XamDateTimeInput)d;
			xamDateTimeInput._cachedAllowDropDownResolved = (bool)e.NewValue;
			xamDateTimeInput.UpdateDropDownButtonVisibility(xamDateTimeInput.AllowDropDownResolved);
			xamDateTimeInput.RaisePeerExpandCollapseChange();
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000034 RID: 52 RVA: 0x00002F8C File Offset: 0x0000118C
		// (set) Token: 0x06000035 RID: 53 RVA: 0x00002F94 File Offset: 0x00001194
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		public bool AllowDropDownResolved
		{
			get
			{
				return this._cachedAllowDropDownResolved;
			}
			internal set
			{
				base.SetValue(global::Infragistics.Controls.Editors.XamDateTimeInput.AllowDropDownResolvedPropertyKey, value);
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000036 RID: 54 RVA: 0x00002FA7 File Offset: 0x000011A7
		// (set) Token: 0x06000037 RID: 55 RVA: 0x00002FB9 File Offset: 0x000011B9
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		public global::System.DateTime ComputedMaxDate
		{
			get
			{
				return (global::System.DateTime)base.GetValue(global::Infragistics.Controls.Editors.XamDateTimeInput.ComputedMaxDateProperty);
			}
			internal set
			{
				base.SetValue(global::Infragistics.Controls.Editors.XamDateTimeInput.ComputedMaxDatePropertyKey, value);
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000038 RID: 56 RVA: 0x00002FCC File Offset: 0x000011CC
		// (set) Token: 0x06000039 RID: 57 RVA: 0x00002FDE File Offset: 0x000011DE
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		public global::Infragistics.Controls.Editors.CalendarZoomMode ComputedMinCalendarMode
		{
			get
			{
				return (global::Infragistics.Controls.Editors.CalendarZoomMode)base.GetValue(global::Infragistics.Controls.Editors.XamDateTimeInput.ComputedMinCalendarModeProperty);
			}
			internal set
			{
				base.SetValue(global::Infragistics.Controls.Editors.XamDateTimeInput.ComputedMinCalendarModePropertyKey, value);
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600003A RID: 58 RVA: 0x00002FF1 File Offset: 0x000011F1
		// (set) Token: 0x0600003B RID: 59 RVA: 0x00003003 File Offset: 0x00001203
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public global::System.DateTime ComputedMinDate
		{
			get
			{
				return (global::System.DateTime)base.GetValue(global::Infragistics.Controls.Editors.XamDateTimeInput.ComputedMinDateProperty);
			}
			internal set
			{
				base.SetValue(global::Infragistics.Controls.Editors.XamDateTimeInput.ComputedMinDatePropertyKey, value);
			}
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00003018 File Offset: 0x00001218
		private static void OnDateValueChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Editors.XamDateTimeInput xamDateTimeInput = (global::Infragistics.Controls.Editors.XamDateTimeInput)d;
			xamDateTimeInput.SyncValueProperties(global::Infragistics.Controls.Editors.XamDateTimeInput.DateValueProperty, e.NewValue);
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600003D RID: 61 RVA: 0x0000303E File Offset: 0x0000123E
		// (set) Token: 0x0600003E RID: 62 RVA: 0x00003050 File Offset: 0x00001250
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.ComponentModel.Browsable(false)]
		public global::System.DateTime? DateValue
		{
			get
			{
				return (global::System.DateTime?)base.GetValue(global::Infragistics.Controls.Editors.XamDateTimeInput.DateValueProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Editors.XamDateTimeInput.DateValueProperty, value);
			}
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00003064 File Offset: 0x00001264
		private static void OnDropDownButtonDisplayModeChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Editors.XamDateTimeInput xamDateTimeInput = d as global::Infragistics.Controls.Editors.XamDateTimeInput;
			xamDateTimeInput.UpdateDropDownButtonVisibility();
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000040 RID: 64 RVA: 0x0000307E File Offset: 0x0000127E
		// (set) Token: 0x06000041 RID: 65 RVA: 0x00003090 File Offset: 0x00001290
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Controls.Editors.DropDownButtonDisplayMode DropDownButtonDisplayMode
		{
			get
			{
				return (global::Infragistics.Controls.Editors.DropDownButtonDisplayMode)base.GetValue(global::Infragistics.Controls.Editors.XamDateTimeInput.DropDownButtonDisplayModeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Editors.XamDateTimeInput.DropDownButtonDisplayModeProperty, value);
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000042 RID: 66 RVA: 0x000030A3 File Offset: 0x000012A3
		// (set) Token: 0x06000043 RID: 67 RVA: 0x000030B5 File Offset: 0x000012B5
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Style DropDownButtonStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Controls.Editors.XamDateTimeInput.DropDownButtonStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Editors.XamDateTimeInput.DropDownButtonStyleProperty, value);
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000044 RID: 68 RVA: 0x000030C3 File Offset: 0x000012C3
		// (set) Token: 0x06000045 RID: 69 RVA: 0x000030D5 File Offset: 0x000012D5
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Visibility DropDownButtonVisibility
		{
			get
			{
				return (global::System.Windows.Visibility)base.GetValue(global::Infragistics.Controls.Editors.XamDateTimeInput.DropDownButtonVisibilityProperty);
			}
			internal set
			{
				base.SetValue(global::Infragistics.Controls.Editors.XamDateTimeInput.DropDownButtonVisibilityPropertyKey, value);
			}
		}

		// Token: 0x06000046 RID: 70 RVA: 0x000030E8 File Offset: 0x000012E8
		private static void OnIsDropDownOpenChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Editors.XamDateTimeInput xamDateTimeInput = (global::Infragistics.Controls.Editors.XamDateTimeInput)d;
			bool flag = (bool)e.NewValue;
			xamDateTimeInput._cachedIsDropDownOpen = flag;
			xamDateTimeInput.RaisePeerExpandCollapseChange();
			if (flag)
			{
				xamDateTimeInput.RaiseDropDownClosedIfPending();
				xamDateTimeInput.RaiseDropDownOpened(new global::System.Windows.RoutedEventArgs());
			}
			else
			{
				if (xamDateTimeInput.IsKeyboardFocusWithin)
				{
					xamDateTimeInput.SetFocusToFocusSite();
				}
				xamDateTimeInput._isClosePending = true;
				if (xamDateTimeInput._popup == null)
				{
					xamDateTimeInput.RaiseDropDownClosedIfPending();
				}
			}
			xamDateTimeInput.UpdateDropDownButtonVisibility();
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00003158 File Offset: 0x00001358
		private static object OnCoerceIsDropDownOpen(global::System.Windows.DependencyObject dependencyObject, object valueAsObject)
		{
			bool flag = (bool)valueAsObject;
			global::Infragistics.Controls.Editors.XamDateTimeInput xamDateTimeInput = (global::Infragistics.Controls.Editors.XamDateTimeInput)dependencyObject;
			if (flag)
			{
				if (!xamDateTimeInput.IsLoaded)
				{
					xamDateTimeInput.RegisterToOpenOnLoad();
					return global::Infragistics.KnownBoxes.FalseBox;
				}
				if (xamDateTimeInput.AllowDropDown == false)
				{
					return global::Infragistics.KnownBoxes.FalseBox;
				}
				if (xamDateTimeInput.IsReadOnly)
				{
					return false;
				}
				if (!xamDateTimeInput.IsKeyboardFocusWithin)
				{
					xamDateTimeInput.SetFocusToFocusSite();
				}
			}
			return flag;
		}

		// Token: 0x06000048 RID: 72 RVA: 0x000031D0 File Offset: 0x000013D0
		private void RegisterToOpenOnLoad()
		{
			global::System.Windows.RoutedEventHandler value = new global::System.Windows.RoutedEventHandler(this.OpenOnLoad);
			base.Loaded -= value;
			base.Loaded += value;
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00003200 File Offset: 0x00001400
		private void OpenOnLoad(object sender, global::System.Windows.RoutedEventArgs e)
		{
			base.Loaded -= this.OpenOnLoad;
			base.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Input, new global::System.Action(delegate()
			{
				this.VerifyIsDropDownOpen();
			}));
		}

		// Token: 0x0600004A RID: 74 RVA: 0x0000322D File Offset: 0x0000142D
		private void VerifyIsDropDownOpen()
		{
			base.CoerceValue(global::Infragistics.Controls.Editors.XamDateTimeInput.IsDropDownOpenProperty);
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600004B RID: 75 RVA: 0x0000323A File Offset: 0x0000143A
		// (set) Token: 0x0600004C RID: 76 RVA: 0x00003242 File Offset: 0x00001442
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.Bindable(true)]
		public bool IsDropDownOpen
		{
			get
			{
				return this._cachedIsDropDownOpen;
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Editors.XamDateTimeInput.IsDropDownOpenProperty, value);
			}
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00003258 File Offset: 0x00001458
		private void EnsureFocusInCalendar()
		{
			if (this._calendar == null || !this.IsDropDownOpen || this._calendar.IsFocused)
			{
				return;
			}
			this._calendar.Focus();
			if (!this._calendar.IsFocused && this._calendar.IsEnabled)
			{
				base.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.ApplicationIdle, new global::System.Action(this.EnsureFocusInCalendar));
				return;
			}
			this.InitializeCalendarStateInPopup();
		}

		// Token: 0x0600004E RID: 78 RVA: 0x000032CC File Offset: 0x000014CC
		private global::System.DateTime? GetDate(object value, global::System.TimeSpan adjustment)
		{
			global::System.DateTime? result = null;
			if (value != null)
			{
				global::Infragistics.Controls.Editors.MaskInfo maskInfo = base.MaskInfo;
				result = (global::System.DateTime?)global::Infragistics.CoreUtilities.ConvertDataValue(value, typeof(global::System.DateTime), maskInfo.FormatProvider, maskInfo.Format);
				if (result != null)
				{
					result = new global::System.DateTime?(result.Value.Date);
					try
					{
						result = new global::System.DateTime?(result.Value.Add(adjustment));
					}
					catch (global::System.ArgumentException)
					{
					}
				}
			}
			return result;
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00003358 File Offset: 0x00001558
		private void InitializeCalendarStateInPopup()
		{
			this._calendar.CurrentMode = this._calendar.MinCalendarMode;
			if (this._calendar.SelectedDate != null)
			{
				this._calendar.DisableAnimations = true;
				try
				{
					this._calendar.BringDateIntoView(this._calendar.SelectedDate.Value);
				}
				finally
				{
					this._calendar.DisableAnimations = false;
				}
			}
		}

		// Token: 0x06000050 RID: 80 RVA: 0x000033DC File Offset: 0x000015DC
		private void OnPopopOpened()
		{
			this.EnsureFocusInCalendar();
		}

		// Token: 0x06000051 RID: 81 RVA: 0x000033E4 File Offset: 0x000015E4
		private void OnPopupClosed()
		{
			this.RaiseDropDownClosedIfPending();
		}

		// Token: 0x06000052 RID: 82 RVA: 0x000033EC File Offset: 0x000015EC
		private void OnSelectionCommitted(object sender, global::System.EventArgs e)
		{
			if (sender == this._calendar && this.IsDropDownOpen)
			{
				this.ToggleDropDown();
			}
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00003408 File Offset: 0x00001608
		private void RaisePeerExpandCollapseChange()
		{
			global::Infragistics.AutomationPeers.XamMaskedInputAutomationPeer xamMaskedInputAutomationPeer = global::System.Windows.Automation.Peers.UIElementAutomationPeer.FromElement(this) as global::Infragistics.AutomationPeers.XamMaskedInputAutomationPeer;
			if (xamMaskedInputAutomationPeer != null)
			{
				xamMaskedInputAutomationPeer.RaiseExpandCollapseChanged();
			}
		}

		// Token: 0x06000054 RID: 84 RVA: 0x0000342C File Offset: 0x0000162C
		private void UpdateComputedDates()
		{
			if (!this._isInitialized)
			{
				return;
			}
			global::Infragistics.Controls.Editors.ValueConstraint valueConstraint = base.ValueConstraint;
			object obj = global::System.Windows.DependencyProperty.UnsetValue;
			object obj2 = global::System.Windows.DependencyProperty.UnsetValue;
			if (valueConstraint != null)
			{
				global::Infragistics.Controls.Editors.MaskInfo maskInfo = base.MaskInfo;
				global::System.DateTime? date = this.GetDate(valueConstraint.MaxExclusive, new global::System.TimeSpan(-864000000000L));
				global::System.DateTime? date2 = this.GetDate(valueConstraint.MaxInclusive, global::System.TimeSpan.Zero);
				global::System.DateTime? date3 = this.GetDate(valueConstraint.MinExclusive, new global::System.TimeSpan(864000000000L));
				global::System.DateTime? date4 = this.GetDate(valueConstraint.MinInclusive, global::System.TimeSpan.Zero);
				if (date != null)
				{
					if (date2 != null && date2 < date)
					{
						obj = date2;
					}
					else
					{
						obj = date;
					}
				}
				else if (date2 != null)
				{
					obj = date2;
				}
				if (date3 != null)
				{
					if (date4 != null && date4 > date3)
					{
						obj2 = date4;
					}
					else
					{
						obj2 = date3;
					}
				}
				else if (date4 != null)
				{
					obj2 = date4;
				}
			}
			if (obj == global::System.Windows.DependencyProperty.UnsetValue)
			{
				base.ClearValue(global::Infragistics.Controls.Editors.XamDateTimeInput.ComputedMaxDatePropertyKey);
			}
			else
			{
				base.SetValue(global::Infragistics.Controls.Editors.XamDateTimeInput.ComputedMaxDatePropertyKey, obj);
			}
			if (obj2 == global::System.Windows.DependencyProperty.UnsetValue)
			{
				base.ClearValue(global::Infragistics.Controls.Editors.XamDateTimeInput.ComputedMinDatePropertyKey);
				return;
			}
			base.SetValue(global::Infragistics.Controls.Editors.XamDateTimeInput.ComputedMinDatePropertyKey, obj2);
		}

		// Token: 0x06000055 RID: 85 RVA: 0x000035CE File Offset: 0x000017CE
		internal void UpdateDropDownButtonVisibility()
		{
			this.UpdateDropDownButtonVisibility(this.AllowDropDownResolved);
		}

		// Token: 0x06000056 RID: 86 RVA: 0x000035DC File Offset: 0x000017DC
		internal void UpdateDropDownButtonVisibility(bool allowButton)
		{
			bool flag = false;
			if (allowButton)
			{
				switch (this.DropDownButtonDisplayMode)
				{
				case global::Infragistics.Controls.Editors.DropDownButtonDisplayMode.Always:
					flag = true;
					goto IL_5C;
				case global::Infragistics.Controls.Editors.DropDownButtonDisplayMode.Focused:
					flag = (base.IsKeyboardFocusWithin || this.IsDropDownOpen);
					goto IL_5C;
				case global::Infragistics.Controls.Editors.DropDownButtonDisplayMode.Never:
					flag = false;
					goto IL_5C;
				}
				flag = (base.IsKeyboardFocusWithin || base.IsMouseOver || this.IsDropDownOpen);
			}
			IL_5C:
			this.DropDownButtonVisibility = (flag ? global::System.Windows.Visibility.Visible : global::System.Windows.Visibility.Collapsed);
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00003652 File Offset: 0x00001852
		protected virtual void OnDropDownOpened(global::System.EventArgs args)
		{
			if (this.DropDownOpened != null)
			{
				this.DropDownOpened(this, args);
			}
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00003669 File Offset: 0x00001869
		internal void RaiseDropDownOpened(global::System.EventArgs args)
		{
			this.OnIsDropDownOpenChanged(true);
			base.ConsiderIsInEditMode("IsDropDownOpen", true);
			this.OnDropDownOpened(args);
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000059 RID: 89 RVA: 0x00003688 File Offset: 0x00001888
		// (remove) Token: 0x0600005A RID: 90 RVA: 0x000036C0 File Offset: 0x000018C0
		public event global::System.EventHandler<global::System.EventArgs> DropDownOpened;

		// Token: 0x0600005B RID: 91 RVA: 0x000036F5 File Offset: 0x000018F5
		protected virtual void OnDropDownClosed(global::System.EventArgs args)
		{
			if (this.DropDownClosed != null)
			{
				this.DropDownClosed(this, args);
			}
		}

		// Token: 0x0600005C RID: 92 RVA: 0x0000370C File Offset: 0x0000190C
		internal void RaiseDropDownClosed(global::System.EventArgs args)
		{
			if (base.IsKeyboardFocusWithin)
			{
				base.OnIsFocusWithinChangedHelper(true);
			}
			this.OnIsDropDownOpenChanged(false);
			base.ConsiderIsInEditMode("IsDropDownOpen", false);
			this.OnDropDownClosed(args);
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x0600005D RID: 93 RVA: 0x00003738 File Offset: 0x00001938
		// (remove) Token: 0x0600005E RID: 94 RVA: 0x00003770 File Offset: 0x00001970
		public event global::System.EventHandler<global::System.EventArgs> DropDownClosed;

		// Token: 0x0400000B RID: 11
		private const string PopupPart = "PART_Popup";

		// Token: 0x0400000C RID: 12
		private const string DropDownButtonPart = "PART_DropDownButton";

		// Token: 0x0400000D RID: 13
		private const string CalendarPart = "PART_Calendar";

		// Token: 0x0400000E RID: 14
		private global::Infragistics.Windows.Licensing.UltraLicense _license;

		// Token: 0x0400000F RID: 15
		private global::Infragistics.Controls.Primitives.ControlDropDownManager _dropDownManager;

		// Token: 0x04000010 RID: 16
		private bool _isInitialized;

		// Token: 0x04000011 RID: 17
		private bool _isClosePending;

		// Token: 0x04000012 RID: 18
		private bool _hasTimeSectionsOnly;

		// Token: 0x04000013 RID: 19
		private global::System.Windows.Controls.Primitives.Popup _popup;

		// Token: 0x04000014 RID: 20
		private global::System.Windows.Controls.Primitives.ToggleButton _dropDownButton;

		// Token: 0x04000015 RID: 21
		private global::Infragistics.Controls.Editors.XamCalendar _calendar;

		// Token: 0x04000016 RID: 22
		private bool _cachedIsDropDownOpen;

		// Token: 0x04000017 RID: 23
		private bool _cachedAllowDropDownResolved;

		// Token: 0x04000018 RID: 24
		public static readonly global::System.Windows.DependencyProperty AllowDropDownProperty = global::Infragistics.DependencyPropertyUtilities.Register("AllowDropDown", typeof(bool?), typeof(global::Infragistics.Controls.Editors.XamDateTimeInput), global::Infragistics.DependencyPropertyUtilities.CreateMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Editors.XamDateTimeInput.OnAllowDropDownChanged)));

		// Token: 0x04000019 RID: 25
		private static readonly global::System.Windows.DependencyPropertyKey AllowDropDownResolvedPropertyKey = global::Infragistics.DependencyPropertyUtilities.RegisterReadOnly("AllowDropDownResolved", typeof(bool), typeof(global::Infragistics.Controls.Editors.XamDateTimeInput), global::Infragistics.KnownBoxes.TrueBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Editors.XamDateTimeInput.OnAllowDropDownResolvedChanged));

		// Token: 0x0400001A RID: 26
		public static readonly global::System.Windows.DependencyProperty AllowDropDownResolvedProperty = global::Infragistics.Controls.Editors.XamDateTimeInput.AllowDropDownResolvedPropertyKey.DependencyProperty;

		// Token: 0x0400001B RID: 27
		private static readonly global::System.Windows.DependencyPropertyKey ComputedMaxDatePropertyKey = global::Infragistics.DependencyPropertyUtilities.RegisterReadOnly("ComputedMaxDate", typeof(global::System.DateTime), typeof(global::Infragistics.Controls.Editors.XamDateTimeInput), global::System.DateTime.MaxValue, null);

		// Token: 0x0400001C RID: 28
		public static readonly global::System.Windows.DependencyProperty ComputedMaxDateProperty = global::Infragistics.Controls.Editors.XamDateTimeInput.ComputedMaxDatePropertyKey.DependencyProperty;

		// Token: 0x0400001D RID: 29
		private static readonly global::System.Windows.DependencyPropertyKey ComputedMinCalendarModePropertyKey = global::Infragistics.DependencyPropertyUtilities.RegisterReadOnly("ComputedMinCalendarMode", typeof(global::Infragistics.Controls.Editors.CalendarZoomMode), typeof(global::Infragistics.Controls.Editors.XamDateTimeInput), global::Infragistics.Controls.Editors.CalendarZoomMode.Days, null);

		// Token: 0x0400001E RID: 30
		public static readonly global::System.Windows.DependencyProperty ComputedMinCalendarModeProperty = global::Infragistics.Controls.Editors.XamDateTimeInput.ComputedMinCalendarModePropertyKey.DependencyProperty;

		// Token: 0x0400001F RID: 31
		private static readonly global::System.Windows.DependencyPropertyKey ComputedMinDatePropertyKey = global::Infragistics.DependencyPropertyUtilities.RegisterReadOnly("ComputedMinDate", typeof(global::System.DateTime), typeof(global::Infragistics.Controls.Editors.XamDateTimeInput), global::System.DateTime.MinValue, null);

		// Token: 0x04000020 RID: 32
		public static readonly global::System.Windows.DependencyProperty ComputedMinDateProperty = global::Infragistics.Controls.Editors.XamDateTimeInput.ComputedMinDatePropertyKey.DependencyProperty;

		// Token: 0x04000021 RID: 33
		public static readonly global::System.Windows.DependencyProperty DateValueProperty = global::Infragistics.DependencyPropertyUtilities.Register("DateValue", typeof(global::System.DateTime?), typeof(global::Infragistics.Controls.Editors.XamDateTimeInput), global::Infragistics.DependencyPropertyUtilities.CreateMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Editors.XamDateTimeInput.OnDateValueChanged)));

		// Token: 0x04000022 RID: 34
		public static readonly global::System.Windows.DependencyProperty DropDownButtonDisplayModeProperty = global::Infragistics.DependencyPropertyUtilities.Register("DropDownButtonDisplayMode", typeof(global::Infragistics.Controls.Editors.DropDownButtonDisplayMode), typeof(global::Infragistics.Controls.Editors.XamDateTimeInput), global::Infragistics.Controls.Editors.DropDownButtonDisplayMode.MouseOver, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Editors.XamDateTimeInput.OnDropDownButtonDisplayModeChanged));

		// Token: 0x04000023 RID: 35
		public static readonly global::System.Windows.DependencyProperty DropDownButtonStyleProperty = global::Infragistics.DependencyPropertyUtilities.Register("DropDownButtonStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Controls.Editors.XamDateTimeInput), global::Infragistics.DependencyPropertyUtilities.CreateMetadata(null));

		// Token: 0x04000024 RID: 36
		private static readonly global::System.Windows.DependencyPropertyKey DropDownButtonVisibilityPropertyKey = global::Infragistics.DependencyPropertyUtilities.RegisterReadOnly("DropDownButtonVisibility", typeof(global::System.Windows.Visibility), typeof(global::Infragistics.Controls.Editors.XamDateTimeInput), global::Infragistics.KnownBoxes.VisibilityVisibleBox, null);

		// Token: 0x04000025 RID: 37
		public static readonly global::System.Windows.DependencyProperty DropDownButtonVisibilityProperty = global::Infragistics.Controls.Editors.XamDateTimeInput.DropDownButtonVisibilityPropertyKey.DependencyProperty;

		// Token: 0x04000026 RID: 38
		public static readonly global::System.Windows.DependencyProperty IsDropDownOpenProperty = global::Infragistics.DependencyPropertyUtilities.Register("IsDropDownOpen", typeof(bool), typeof(global::Infragistics.Controls.Editors.XamDateTimeInput), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Editors.XamDateTimeInput.OnIsDropDownOpenChanged), new global::System.Windows.CoerceValueCallback(global::Infragistics.Controls.Editors.XamDateTimeInput.OnCoerceIsDropDownOpen)));
	}
}
