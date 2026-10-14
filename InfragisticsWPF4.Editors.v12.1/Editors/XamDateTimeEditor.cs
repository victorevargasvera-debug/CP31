using System;
using System.ComponentModel;
using System.IO;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Threading;
using Infragistics.Windows.Automation.Peers.Editors;
using Infragistics.Windows.Licensing;

namespace Infragistics.Windows.Editors
{
	// Token: 0x02000075 RID: 117
	[global::System.Windows.TemplateVisualState(Name = "FocusedDropDown", GroupName = "FocusStates")]
	[global::System.Windows.TemplatePart(Name = "PART_Calendar", Type = typeof(global::Infragistics.Windows.Editors.XamMonthCalendar))]
	[global::System.ComponentModel.LicenseProvider(typeof(global::Infragistics.Windows.Licensing.UltraLicenseProvider))]
	[global::Infragistics.Windows.Licensing.UltraLicense("XamDateTimeEditor")]
	[global::System.Windows.StyleTypedProperty(Property = "DropDownButtonStyle", StyleTargetType = typeof(global::System.Windows.Controls.Primitives.ToggleButton))]
	[global::System.Windows.TemplatePart(Name = "PART_Popup", Type = typeof(global::System.Windows.Controls.Primitives.Popup))]
	[global::System.Windows.TemplatePart(Name = "PART_DropDownButton", Type = typeof(global::System.Windows.Controls.Primitives.ToggleButton))]
	public class XamDateTimeEditor : global::Infragistics.Windows.Editors.XamMaskedEditor
	{
		// Token: 0x060006FE RID: 1790 RVA: 0x0001E58C File Offset: 0x0001C78C
		static XamDateTimeEditor()
		{
			global::Infragistics.Windows.Editors.XamDateTimeEditor.DropDownOpenedEvent = global::Infragistics.Windows.Editors.XamComboEditor.DropDownOpenedEvent.AddOwner(typeof(global::Infragistics.Windows.Editors.XamDateTimeEditor));
			global::Infragistics.Windows.Editors.XamDateTimeEditor.DropDownClosedEvent = global::Infragistics.Windows.Editors.XamComboEditor.DropDownClosedEvent.AddOwner(typeof(global::Infragistics.Windows.Editors.XamDateTimeEditor));
			global::Infragistics.Windows.Editors.ValueEditor.ValueTypeProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Editors.XamDateTimeEditor), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::System.DateTime)));
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Editors.XamDateTimeEditor), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.Editors.XamDateTimeEditor)));
			global::System.Windows.EventManager.RegisterClassHandler(typeof(global::Infragistics.Windows.Editors.XamDateTimeEditor), global::Infragistics.Windows.Editors.XamMonthCalendar.SelectionCommittedEvent, new global::System.Windows.RoutedEventHandler(global::Infragistics.Windows.Editors.XamDateTimeEditor.OnSelectionCommitted));
			global::Infragistics.Windows.Editors.ValueEditor.IsReadOnlyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Editors.XamDateTimeEditor), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.XamDateTimeEditor.OnIsReadOnlyChanged)));
		}

		// Token: 0x060006FF RID: 1791 RVA: 0x0001E81C File Offset: 0x0001CA1C
		public XamDateTimeEditor()
		{
			try
			{
				this._license = (global::System.ComponentModel.LicenseManager.Validate(typeof(global::Infragistics.Windows.Editors.XamDateTimeEditor), this) as global::Infragistics.Windows.Licensing.UltraLicense);
			}
			catch (global::System.IO.FileNotFoundException)
			{
			}
		}

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x06000700 RID: 1792 RVA: 0x0001E860 File Offset: 0x0001CA60
		internal override bool HasDropDown
		{
			get
			{
				return this.AllowDropDown;
			}
		}

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x06000701 RID: 1793 RVA: 0x0001E868 File Offset: 0x0001CA68
		internal override bool HasOpenDropDown
		{
			get
			{
				return this.IsDropDownOpen;
			}
		}

		// Token: 0x06000702 RID: 1794 RVA: 0x0001E870 File Offset: 0x0001CA70
		internal override void InitializeValueProperties()
		{
			if (global::Infragistics.Windows.Editors.Utils.IsValuePropertySet(global::Infragistics.Windows.Editors.XamDateTimeEditor.DateValueProperty, this) && !global::Infragistics.Windows.Editors.Utils.IsValuePropertySet(global::Infragistics.Windows.Editors.ValueEditor.ValueProperty, this))
			{
				base.CoerceValue(global::Infragistics.Windows.Editors.XamDateTimeEditor.DateValueProperty);
				base.SyncValueProperties(global::Infragistics.Windows.Editors.XamDateTimeEditor.DateValueProperty, this.DateValue);
				return;
			}
			base.InitializeValueProperties();
		}

		// Token: 0x06000703 RID: 1795 RVA: 0x0001E8C0 File Offset: 0x0001CAC0
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();
			if (this._popup != null)
			{
				this._popup.Opened -= this.OnPopupOpened;
				this._popup.Closed -= this.OnPopupClosed;
			}
			this._popup = (base.GetTemplateChild("PART_Popup") as global::System.Windows.Controls.Primitives.Popup);
			if (this._popup != null)
			{
				this._popup.Opened += this.OnPopupOpened;
				this._popup.Closed += this.OnPopupClosed;
			}
		}

		// Token: 0x06000704 RID: 1796 RVA: 0x0001E955 File Offset: 0x0001CB55
		protected override void OnInitialized(global::System.EventArgs e)
		{
			base.CoerceValue(global::Infragistics.Windows.Editors.XamDateTimeEditor.AllowDropDownProperty);
			base.UpdateDropDownButtonVisibility(this.AllowDropDown);
			this.UpdateComputedDates();
			base.OnInitialized(e);
		}

		// Token: 0x06000705 RID: 1797 RVA: 0x0001E97C File Offset: 0x0001CB7C
		protected override void OnPropertyChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			base.OnPropertyChanged(e);
			global::System.Windows.DependencyProperty property = e.Property;
			if (global::System.Windows.UIElement.IsMouseOverProperty == property || global::Infragistics.Windows.Editors.XamDateTimeEditor.DropDownButtonDisplayModeProperty == property || global::Infragistics.Windows.Editors.ValueEditor.IsInEditModeProperty == property)
			{
				base.UpdateDropDownButtonVisibility(this.AllowDropDown);
			}
		}

		// Token: 0x06000706 RID: 1798 RVA: 0x0001E9BC File Offset: 0x0001CBBC
		internal override void OnSectionsChanged()
		{
			base.OnSectionsChanged();
			global::Infragistics.Windows.Editors.CalendarMode? calendarMode = null;
			bool? flag = null;
			if (base.Sections != null)
			{
				foreach (global::Infragistics.Windows.Editors.SectionBase sectionBase in base.Sections)
				{
					if (sectionBase is global::Infragistics.Windows.Editors.DaySection)
					{
						calendarMode = new global::Infragistics.Windows.Editors.CalendarMode?(global::Infragistics.Windows.Editors.CalendarMode.Days);
					}
					else if (sectionBase is global::Infragistics.Windows.Editors.MonthSection)
					{
						if (calendarMode == null || calendarMode > global::Infragistics.Windows.Editors.CalendarMode.Months)
						{
							calendarMode = new global::Infragistics.Windows.Editors.CalendarMode?(global::Infragistics.Windows.Editors.CalendarMode.Months);
						}
					}
					else if (sectionBase is global::Infragistics.Windows.Editors.YearSection && (calendarMode == null || calendarMode > global::Infragistics.Windows.Editors.CalendarMode.Years))
					{
						calendarMode = new global::Infragistics.Windows.Editors.CalendarMode?(global::Infragistics.Windows.Editors.CalendarMode.Years);
					}
					if (sectionBase is global::Infragistics.Windows.Editors.HourSection || sectionBase is global::Infragistics.Windows.Editors.MinuteSection || sectionBase is global::Infragistics.Windows.Editors.AMPMSection || sectionBase is global::Infragistics.Windows.Editors.SecondSection)
					{
						if (flag == null)
						{
							flag = new bool?(true);
						}
					}
					else if (sectionBase is global::Infragistics.Windows.Editors.EditSectionBase)
					{
						flag = new bool?(false);
					}
				}
				this._hasTimeSectionsOnly = (flag == true);
				if (calendarMode == null)
				{
					calendarMode = new global::Infragistics.Windows.Editors.CalendarMode?(global::Infragistics.Windows.Editors.CalendarMode.Days);
				}
			}
			else
			{
				calendarMode = new global::Infragistics.Windows.Editors.CalendarMode?(global::Infragistics.Windows.Editors.CalendarMode.Days);
				this._hasTimeSectionsOnly = false;
			}
			base.SetValue(global::Infragistics.Windows.Editors.XamDateTimeEditor.ComputedMinCalendarModePropertyKey, calendarMode);
			base.CoerceValue(global::Infragistics.Windows.Editors.XamDateTimeEditor.AllowDropDownProperty);
			base.UpdateDropDownButtonVisibility(this.AllowDropDown);
		}

		// Token: 0x06000707 RID: 1799 RVA: 0x0001EB48 File Offset: 0x0001CD48
		internal override void OnValueConstraintChanged(string valueConstraintPropertyName)
		{
			base.OnValueConstraintChanged(valueConstraintPropertyName);
			this.UpdateComputedDates();
		}

		// Token: 0x06000708 RID: 1800 RVA: 0x0001EB57 File Offset: 0x0001CD57
		internal override void RaiseDropDownClosedIfPending()
		{
			if (this._isClosePending)
			{
				this._isClosePending = false;
				this.RaiseDropDownClosed(new global::System.Windows.RoutedEventArgs());
			}
		}

		// Token: 0x06000709 RID: 1801 RVA: 0x0001EB74 File Offset: 0x0001CD74
		internal override bool SyncValuePropertiesOverride(global::System.Windows.DependencyProperty prop, object newValue, out global::System.Exception error)
		{
			if (global::Infragistics.Windows.Editors.XamDateTimeEditor.DateValueProperty != prop)
			{
				bool result = base.SyncValuePropertiesOverride(prop, newValue, out error);
				global::Infragistics.Windows.Editors.SectionsCollection sections = base.Sections;
				object obj;
				if (!base.IsValueValid)
				{
					obj = global::Infragistics.Windows.Editors.XamMaskedEditor.GetDateValue(sections);
				}
				else
				{
					object value = base.Value;
					obj = ((value is global::System.DateTime) ? value : null);
					string text;
					if (obj == null && !global::Infragistics.Windows.Editors.Utils.IsValueEmpty(value) && sections != null && global::Infragistics.Windows.Editors.XamMaskedEditor.IsMaskValidForDataType(typeof(global::System.DateTime), sections) && base.IsInputValid(sections, out text))
					{
						try
						{
							obj = global::Infragistics.Windows.Editors.XamMaskedEditor.GetDateTimeValue(base.Sections);
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
				base.SetValue(global::Infragistics.Windows.Editors.XamDateTimeEditor.DateValueProperty, (global::System.DBNull.Value != obj) ? obj : null);
				return result;
			}
			global::System.DateTime? dateTime = (global::System.DateTime?)newValue;
			global::Infragistics.Windows.Editors.MaskInfo maskInfo = base.MaskInfo;
			global::Infragistics.Windows.Editors.EditInfo editInfo = base.EditInfo;
			global::Infragistics.Windows.Editors.SectionsCollection sections2 = maskInfo.Sections;
			if (editInfo == null)
			{
				object value2 = null;
				if (dateTime != null)
				{
					object obj2 = base.Value;
					if (!global::Infragistics.Windows.Editors.Utils.IsValueEmpty(obj2) && !(obj2 is global::System.DateTime))
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
				base.SetValue(global::Infragistics.Windows.Editors.ValueEditor.ValueProperty, value2);
				return base.SyncValuePropertiesOverride(global::Infragistics.Windows.Editors.ValueEditor.ValueProperty, base.Value, out error);
			}
			string text2 = global::Infragistics.Windows.Editors.XamMaskedEditor.GetText(sections2, global::Infragistics.Windows.Editors.MaskMode.IncludeBoth, maskInfo);
			if (dateTime != null)
			{
				global::Infragistics.Windows.Editors.XamMaskedEditor.SetDateTimeValue(sections2, dateTime.Value, editInfo.MaskInfo, true);
			}
			else
			{
				global::Infragistics.Windows.Editors.YearSection yearSection = (global::Infragistics.Windows.Editors.YearSection)global::Infragistics.Windows.Editors.XamMaskedEditor.GetSection(sections2, typeof(global::Infragistics.Windows.Editors.YearSection));
				global::Infragistics.Windows.Editors.MonthSection monthSection = (global::Infragistics.Windows.Editors.MonthSection)global::Infragistics.Windows.Editors.XamMaskedEditor.GetSection(sections2, typeof(global::Infragistics.Windows.Editors.MonthSection));
				global::Infragistics.Windows.Editors.DaySection daySection = (global::Infragistics.Windows.Editors.DaySection)global::Infragistics.Windows.Editors.XamMaskedEditor.GetSection(sections2, typeof(global::Infragistics.Windows.Editors.DaySection));
				yearSection.EraseAllChars();
				monthSection.EraseAllChars();
				daySection.EraseAllChars();
			}
			string text3 = global::Infragistics.Windows.Editors.XamMaskedEditor.GetText(sections2, global::Infragistics.Windows.Editors.MaskMode.IncludeBoth, maskInfo);
			if (text2 != text3)
			{
				editInfo.OnTextChanged(true);
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
				}
				error = null;
				return true;
			}
			error = null;
			return true;
		}

		// Token: 0x0600070A RID: 1802 RVA: 0x0001EE60 File Offset: 0x0001D060
		internal override void ToggleDropDown()
		{
			this.IsDropDownOpen = !this.IsDropDownOpen;
		}

		// Token: 0x0600070B RID: 1803 RVA: 0x0001EE74 File Offset: 0x0001D074
		private static object CoerceAllowDropDown(global::System.Windows.DependencyObject d, object newValue)
		{
			global::Infragistics.Windows.Editors.XamDateTimeEditor xamDateTimeEditor = (global::Infragistics.Windows.Editors.XamDateTimeEditor)d;
			if (xamDateTimeEditor._hasTimeSectionsOnly)
			{
				return global::Infragistics.KnownBoxes.FalseBox;
			}
			if (!xamDateTimeEditor.IsEditingAllowed)
			{
				return global::Infragistics.KnownBoxes.FalseBox;
			}
			return newValue;
		}

		// Token: 0x0600070C RID: 1804 RVA: 0x0001EEA8 File Offset: 0x0001D0A8
		private static void OnAllowDropDownChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Editors.XamDateTimeEditor xamDateTimeEditor = (global::Infragistics.Windows.Editors.XamDateTimeEditor)d;
			xamDateTimeEditor.UpdateDropDownButtonVisibility(xamDateTimeEditor.AllowDropDown);
			xamDateTimeEditor.RaisePeerExpandCollapseChange();
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x0600070D RID: 1805 RVA: 0x0001EECE File Offset: 0x0001D0CE
		// (set) Token: 0x0600070E RID: 1806 RVA: 0x0001EEE0 File Offset: 0x0001D0E0
		[global::System.ComponentModel.Bindable(true)]
		public bool AllowDropDown
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.Editors.XamDateTimeEditor.AllowDropDownProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.XamDateTimeEditor.AllowDropDownProperty, value);
			}
		}

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x0600070F RID: 1807 RVA: 0x0001EEF3 File Offset: 0x0001D0F3
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		public global::System.DateTime ComputedMaxDate
		{
			get
			{
				return (global::System.DateTime)base.GetValue(global::Infragistics.Windows.Editors.XamDateTimeEditor.ComputedMaxDateProperty);
			}
		}

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x06000710 RID: 1808 RVA: 0x0001EF05 File Offset: 0x0001D105
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		public global::Infragistics.Windows.Editors.CalendarMode ComputedMinCalendarMode
		{
			get
			{
				return (global::Infragistics.Windows.Editors.CalendarMode)base.GetValue(global::Infragistics.Windows.Editors.XamDateTimeEditor.ComputedMinCalendarModeProperty);
			}
		}

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x06000711 RID: 1809 RVA: 0x0001EF17 File Offset: 0x0001D117
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public global::System.DateTime ComputedMinDate
		{
			get
			{
				return (global::System.DateTime)base.GetValue(global::Infragistics.Windows.Editors.XamDateTimeEditor.ComputedMinDateProperty);
			}
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x06000712 RID: 1810 RVA: 0x0001EF29 File Offset: 0x0001D129
		// (set) Token: 0x06000713 RID: 1811 RVA: 0x0001EF3B File Offset: 0x0001D13B
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public global::System.DateTime? DateValue
		{
			get
			{
				return (global::System.DateTime?)base.GetValue(global::Infragistics.Windows.Editors.XamDateTimeEditor.DateValueProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.XamDateTimeEditor.DateValueProperty, value);
			}
		}

		// Token: 0x06000714 RID: 1812 RVA: 0x0001EF50 File Offset: 0x0001D150
		private static void OnDateValueChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Editors.XamDateTimeEditor xamDateTimeEditor = (global::Infragistics.Windows.Editors.XamDateTimeEditor)dependencyObject;
			xamDateTimeEditor.SyncValueProperties(global::Infragistics.Windows.Editors.XamDateTimeEditor.DateValueProperty, e.NewValue);
		}

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x06000715 RID: 1813 RVA: 0x0001EF76 File Offset: 0x0001D176
		// (set) Token: 0x06000716 RID: 1814 RVA: 0x0001EF88 File Offset: 0x0001D188
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.Editors.DropDownButtonDisplayMode DropDownButtonDisplayMode
		{
			get
			{
				return (global::Infragistics.Windows.Editors.DropDownButtonDisplayMode)base.GetValue(global::Infragistics.Windows.Editors.XamDateTimeEditor.DropDownButtonDisplayModeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.XamDateTimeEditor.DropDownButtonDisplayModeProperty, value);
			}
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x06000717 RID: 1815 RVA: 0x0001EF9B File Offset: 0x0001D19B
		// (set) Token: 0x06000718 RID: 1816 RVA: 0x0001EFAD File Offset: 0x0001D1AD
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Style DropDownButtonStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Windows.Editors.XamDateTimeEditor.DropDownButtonStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.XamDateTimeEditor.DropDownButtonStyleProperty, value);
			}
		}

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x06000719 RID: 1817 RVA: 0x0001EFBB File Offset: 0x0001D1BB
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.ReadOnly(true)]
		public global::System.Windows.Visibility DropDownButtonVisibility
		{
			get
			{
				return (global::System.Windows.Visibility)base.GetValue(global::Infragistics.Windows.Editors.XamDateTimeEditor.DropDownButtonVisibilityProperty);
			}
		}

		// Token: 0x0600071A RID: 1818 RVA: 0x0001EFD0 File Offset: 0x0001D1D0
		private static void OnIsDropDownOpenChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Editors.XamDateTimeEditor xamDateTimeEditor = (global::Infragistics.Windows.Editors.XamDateTimeEditor)d;
			bool flag = (bool)e.NewValue;
			xamDateTimeEditor.RaisePeerExpandCollapseChange();
			xamDateTimeEditor.ProcessIsBeingEditedAndFocusedChanged();
			if (flag)
			{
				xamDateTimeEditor.RaiseDropDownClosedIfPending();
				xamDateTimeEditor.RaiseDropDownOpened(new global::System.Windows.RoutedEventArgs());
			}
			else
			{
				if (xamDateTimeEditor.IsFocusWithin)
				{
					xamDateTimeEditor.SetFocusToFocusSite();
				}
				xamDateTimeEditor._isClosePending = true;
				if (xamDateTimeEditor._popup == null)
				{
					xamDateTimeEditor.RaiseDropDownClosedIfPending();
				}
			}
			xamDateTimeEditor.CoerceValue(global::System.Windows.Controls.ToolTipService.IsEnabledProperty);
		}

		// Token: 0x0600071B RID: 1819 RVA: 0x0001F044 File Offset: 0x0001D244
		private static object OnCoerceIsDropDownOpen(global::System.Windows.DependencyObject dependencyObject, object valueAsObject)
		{
			bool flag = (bool)valueAsObject;
			global::Infragistics.Windows.Editors.XamDateTimeEditor xamDateTimeEditor = (global::Infragistics.Windows.Editors.XamDateTimeEditor)dependencyObject;
			if (flag)
			{
				if (!xamDateTimeEditor.IsLoaded)
				{
					xamDateTimeEditor.RegisterToOpenOnLoad();
					return global::Infragistics.KnownBoxes.FalseBox;
				}
				if (!xamDateTimeEditor.AllowDropDown)
				{
					return global::Infragistics.KnownBoxes.FalseBox;
				}
				if (xamDateTimeEditor.IsReadOnly)
				{
					return false;
				}
				xamDateTimeEditor.StartEditMode();
				if (!xamDateTimeEditor.IsInEditMode)
				{
					return global::Infragistics.KnownBoxes.FalseBox;
				}
			}
			return flag;
		}

		// Token: 0x0600071C RID: 1820 RVA: 0x0001F0B0 File Offset: 0x0001D2B0
		private void RegisterToOpenOnLoad()
		{
			global::System.Windows.RoutedEventHandler value = new global::System.Windows.RoutedEventHandler(this.OpenOnLoad);
			base.Loaded -= value;
			base.Loaded += value;
		}

		// Token: 0x0600071D RID: 1821 RVA: 0x0001F0E6 File Offset: 0x0001D2E6
		private void OpenOnLoad(object sender, global::System.Windows.RoutedEventArgs e)
		{
			base.Loaded -= this.OpenOnLoad;
			base.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Input, new global::System.Windows.Threading.DispatcherOperationCallback(delegate(object param)
			{
				base.CoerceValue(global::Infragistics.Windows.Editors.XamDateTimeEditor.IsDropDownOpenProperty);
				return null;
			}), null);
		}

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x0600071E RID: 1822 RVA: 0x0001F114 File Offset: 0x0001D314
		// (set) Token: 0x0600071F RID: 1823 RVA: 0x0001F126 File Offset: 0x0001D326
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		public bool IsDropDownOpen
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.Editors.XamDateTimeEditor.IsDropDownOpenProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.XamDateTimeEditor.IsDropDownOpenProperty, value);
			}
		}

		// Token: 0x06000720 RID: 1824 RVA: 0x0001F13C File Offset: 0x0001D33C
		private global::System.DateTime? GetDate(object value, global::System.TimeSpan adjustment)
		{
			global::System.DateTime? result = null;
			if (value != null)
			{
				global::Infragistics.Windows.Editors.MaskInfo maskInfo = base.MaskInfo;
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

		// Token: 0x06000721 RID: 1825 RVA: 0x0001F1C8 File Offset: 0x0001D3C8
		private static void OnIsReadOnlyChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			d.CoerceValue(global::Infragistics.Windows.Editors.XamDateTimeEditor.AllowDropDownProperty);
		}

		// Token: 0x06000722 RID: 1826 RVA: 0x0001F1D8 File Offset: 0x0001D3D8
		private void OnPopupOpened(object sender, global::System.EventArgs e)
		{
			global::System.Windows.Controls.Primitives.Popup popup = (global::System.Windows.Controls.Primitives.Popup)sender;
			if (popup.Child != null)
			{
				popup.Child.MoveFocus(new global::System.Windows.Input.TraversalRequest(global::System.Windows.Input.FocusNavigationDirection.First));
			}
		}

		// Token: 0x06000723 RID: 1827 RVA: 0x0001F206 File Offset: 0x0001D406
		private void OnPopupClosed(object sender, global::System.EventArgs e)
		{
			this.RaiseDropDownClosedIfPending();
		}

		// Token: 0x06000724 RID: 1828 RVA: 0x0001F210 File Offset: 0x0001D410
		private static void OnSelectionCommitted(object sender, global::System.Windows.RoutedEventArgs e)
		{
			global::Infragistics.Windows.Editors.XamDateTimeEditor xamDateTimeEditor = sender as global::Infragistics.Windows.Editors.XamDateTimeEditor;
			global::Infragistics.Windows.Editors.XamMonthCalendar xamMonthCalendar = e.OriginalSource as global::Infragistics.Windows.Editors.XamMonthCalendar;
			if (xamMonthCalendar != null && xamMonthCalendar.TemplatedParent == xamDateTimeEditor && xamDateTimeEditor.IsDropDownOpen)
			{
				xamDateTimeEditor.ToggleDropDown();
			}
		}

		// Token: 0x06000725 RID: 1829 RVA: 0x0001F24C File Offset: 0x0001D44C
		private void RaisePeerExpandCollapseChange()
		{
			global::Infragistics.Windows.Automation.Peers.Editors.XamMaskedEditorAutomationPeer xamMaskedEditorAutomationPeer = global::System.Windows.Automation.Peers.UIElementAutomationPeer.FromElement(this) as global::Infragistics.Windows.Automation.Peers.Editors.XamMaskedEditorAutomationPeer;
			if (xamMaskedEditorAutomationPeer != null)
			{
				xamMaskedEditorAutomationPeer.RaiseExpandCollapseChanged();
			}
		}

		// Token: 0x06000726 RID: 1830 RVA: 0x0001F270 File Offset: 0x0001D470
		private void UpdateComputedDates()
		{
			if (!base.IsInitialized)
			{
				return;
			}
			global::Infragistics.Windows.Editors.ValueConstraint valueConstraint = base.ValueConstraint;
			object value = global::System.Windows.DependencyProperty.UnsetValue;
			object value2 = global::System.Windows.DependencyProperty.UnsetValue;
			if (valueConstraint != null)
			{
				global::Infragistics.Windows.Editors.MaskInfo maskInfo = base.MaskInfo;
				global::System.DateTime? date = this.GetDate(valueConstraint.MaxExclusive, new global::System.TimeSpan(-864000000000L));
				global::System.DateTime? date2 = this.GetDate(valueConstraint.MaxInclusive, global::System.TimeSpan.Zero);
				global::System.DateTime? date3 = this.GetDate(valueConstraint.MinExclusive, new global::System.TimeSpan(864000000000L));
				global::System.DateTime? date4 = this.GetDate(valueConstraint.MinInclusive, global::System.TimeSpan.Zero);
				if (date != null)
				{
					if (date2 != null && date2 < date)
					{
						value = date2;
					}
					else
					{
						value = date;
					}
				}
				else if (date2 != null)
				{
					value = date2;
				}
				if (date3 != null)
				{
					if (date4 != null && date4 > date3)
					{
						value2 = date4;
					}
					else
					{
						value2 = date3;
					}
				}
				else if (date4 != null)
				{
					value2 = date4;
				}
			}
			base.SetValue(global::Infragistics.Windows.Editors.XamDateTimeEditor.ComputedMaxDatePropertyKey, value);
			base.SetValue(global::Infragistics.Windows.Editors.XamDateTimeEditor.ComputedMinDatePropertyKey, value2);
		}

		// Token: 0x06000727 RID: 1831 RVA: 0x0001F3E9 File Offset: 0x0001D5E9
		protected virtual void OnDropDownOpened(global::System.Windows.RoutedEventArgs args)
		{
			base.RaiseEventHelper(args);
		}

		// Token: 0x06000728 RID: 1832 RVA: 0x0001F3F3 File Offset: 0x0001D5F3
		internal void RaiseDropDownOpened(global::System.Windows.RoutedEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.Editors.XamDateTimeEditor.DropDownOpenedEvent;
			args.Source = this;
			this.OnDropDownOpened(args);
		}

		// Token: 0x1400001A RID: 26
		// (add) Token: 0x06000729 RID: 1833 RVA: 0x0001F40E File Offset: 0x0001D60E
		// (remove) Token: 0x0600072A RID: 1834 RVA: 0x0001F41C File Offset: 0x0001D61C
		public event global::System.EventHandler<global::System.Windows.RoutedEventArgs> DropDownOpened
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.Editors.XamDateTimeEditor.DropDownOpenedEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.Editors.XamDateTimeEditor.DropDownOpenedEvent, value);
			}
		}

		// Token: 0x0600072B RID: 1835 RVA: 0x0001F42A File Offset: 0x0001D62A
		protected virtual void OnDropDownClosed(global::System.Windows.RoutedEventArgs args)
		{
			base.RaiseEventHelper(args);
		}

		// Token: 0x0600072C RID: 1836 RVA: 0x0001F434 File Offset: 0x0001D634
		internal void RaiseDropDownClosed(global::System.Windows.RoutedEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.Editors.XamDateTimeEditor.DropDownClosedEvent;
			args.Source = this;
			this.OnDropDownClosed(args);
		}

		// Token: 0x1400001B RID: 27
		// (add) Token: 0x0600072D RID: 1837 RVA: 0x0001F44F File Offset: 0x0001D64F
		// (remove) Token: 0x0600072E RID: 1838 RVA: 0x0001F45D File Offset: 0x0001D65D
		public event global::System.EventHandler<global::System.Windows.RoutedEventArgs> DropDownClosed
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.Editors.XamDateTimeEditor.DropDownClosedEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.Editors.XamDateTimeEditor.DropDownClosedEvent, value);
			}
		}

		// Token: 0x0400027B RID: 635
		private global::Infragistics.Windows.Licensing.UltraLicense _license;

		// Token: 0x0400027C RID: 636
		private global::System.Windows.Controls.Primitives.Popup _popup;

		// Token: 0x0400027D RID: 637
		private bool _isClosePending;

		// Token: 0x0400027E RID: 638
		private bool _hasTimeSectionsOnly;

		// Token: 0x0400027F RID: 639
		public static readonly global::System.Windows.DependencyProperty AllowDropDownProperty = global::System.Windows.DependencyProperty.Register("AllowDropDown", typeof(bool), typeof(global::Infragistics.Windows.Editors.XamDateTimeEditor), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.TrueBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.XamDateTimeEditor.OnAllowDropDownChanged), new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.Editors.XamDateTimeEditor.CoerceAllowDropDown)));

		// Token: 0x04000280 RID: 640
		private static readonly global::System.Windows.DependencyPropertyKey ComputedMaxDatePropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("ComputedMaxDate", typeof(global::System.DateTime), typeof(global::Infragistics.Windows.Editors.XamDateTimeEditor), new global::System.Windows.FrameworkPropertyMetadata(global::System.DateTime.MaxValue));

		// Token: 0x04000281 RID: 641
		public static readonly global::System.Windows.DependencyProperty ComputedMaxDateProperty = global::Infragistics.Windows.Editors.XamDateTimeEditor.ComputedMaxDatePropertyKey.DependencyProperty;

		// Token: 0x04000282 RID: 642
		private static readonly global::System.Windows.DependencyPropertyKey ComputedMinCalendarModePropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("ComputedMinCalendarMode", typeof(global::Infragistics.Windows.Editors.CalendarMode), typeof(global::Infragistics.Windows.Editors.XamDateTimeEditor), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.Editors.CalendarMode.Days));

		// Token: 0x04000283 RID: 643
		public static readonly global::System.Windows.DependencyProperty ComputedMinCalendarModeProperty = global::Infragistics.Windows.Editors.XamDateTimeEditor.ComputedMinCalendarModePropertyKey.DependencyProperty;

		// Token: 0x04000284 RID: 644
		private static readonly global::System.Windows.DependencyPropertyKey ComputedMinDatePropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("ComputedMinDate", typeof(global::System.DateTime), typeof(global::Infragistics.Windows.Editors.XamDateTimeEditor), new global::System.Windows.FrameworkPropertyMetadata(global::System.DateTime.MinValue));

		// Token: 0x04000285 RID: 645
		public static readonly global::System.Windows.DependencyProperty ComputedMinDateProperty = global::Infragistics.Windows.Editors.XamDateTimeEditor.ComputedMinDatePropertyKey.DependencyProperty;

		// Token: 0x04000286 RID: 646
		public static readonly global::System.Windows.DependencyProperty DateValueProperty = global::System.Windows.DependencyProperty.Register("DateValue", typeof(global::System.DateTime?), typeof(global::Infragistics.Windows.Editors.XamDateTimeEditor), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.None, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.XamDateTimeEditor.OnDateValueChanged)));

		// Token: 0x04000287 RID: 647
		public static readonly global::System.Windows.DependencyProperty DropDownButtonDisplayModeProperty = global::Infragistics.Windows.Editors.XamComboEditor.DropDownButtonDisplayModeProperty.AddOwner(typeof(global::Infragistics.Windows.Editors.XamDateTimeEditor));

		// Token: 0x04000288 RID: 648
		public static readonly global::System.Windows.DependencyProperty DropDownButtonStyleProperty = global::Infragistics.Windows.Editors.XamComboEditor.DropDownButtonStyleProperty.AddOwner(typeof(global::Infragistics.Windows.Editors.XamDateTimeEditor));

		// Token: 0x04000289 RID: 649
		public static readonly global::System.Windows.DependencyProperty DropDownButtonVisibilityProperty = global::Infragistics.Windows.Editors.XamComboEditor.DropDownButtonVisibilityProperty.AddOwner(typeof(global::Infragistics.Windows.Editors.XamDateTimeEditor));

		// Token: 0x0400028A RID: 650
		public static readonly global::System.Windows.DependencyProperty IsDropDownOpenProperty = global::Infragistics.Windows.Editors.XamComboEditor.IsDropDownOpenProperty.AddOwner(typeof(global::Infragistics.Windows.Editors.XamDateTimeEditor), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.XamDateTimeEditor.OnIsDropDownOpenChanged), new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.Editors.XamDateTimeEditor.OnCoerceIsDropDownOpen)));
	}
}
