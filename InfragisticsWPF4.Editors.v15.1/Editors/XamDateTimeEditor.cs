using System;
using System.ComponentModel;
using System.IO;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Threading;
using Infragistics.Themes;
using Infragistics.Windows.Automation.Peers.Editors;
using Infragistics.Windows.Licensing;

namespace Infragistics.Windows.Editors
{
	// Token: 0x0200007B RID: 123
	[global::Infragistics.Windows.Licensing.UltraLicense("XamDateTimeEditor")]
	[global::System.Windows.TemplatePart(Name = "PART_DropDownButton", Type = typeof(global::System.Windows.Controls.Primitives.ToggleButton))]
	[global::System.Windows.StyleTypedProperty(Property = "DropDownButtonStyle", StyleTargetType = typeof(global::System.Windows.Controls.Primitives.ToggleButton))]
	[global::System.Windows.TemplatePart(Name = "PART_Popup", Type = typeof(global::System.Windows.Controls.Primitives.Popup))]
	[global::System.Windows.TemplateVisualState(Name = "FocusedDropDown", GroupName = "FocusStates")]
	[global::System.ComponentModel.LicenseProvider(typeof(global::Infragistics.Windows.Licensing.UltraLicenseProvider))]
	[global::System.Windows.TemplatePart(Name = "PART_Calendar", Type = typeof(global::Infragistics.Windows.Editors.XamMonthCalendar))]
	public class XamDateTimeEditor : global::Infragistics.Windows.Editors.XamMaskedEditor
	{
		// Token: 0x0600075E RID: 1886 RVA: 0x0001FF70 File Offset: 0x0001E170
		static XamDateTimeEditor()
		{
			global::Infragistics.Windows.Editors.XamDateTimeEditor.DropDownOpenedEvent = global::Infragistics.Windows.Editors.XamComboEditor.DropDownOpenedEvent.AddOwner(typeof(global::Infragistics.Windows.Editors.XamDateTimeEditor));
			global::Infragistics.Windows.Editors.XamDateTimeEditor.DropDownClosedEvent = global::Infragistics.Windows.Editors.XamComboEditor.DropDownClosedEvent.AddOwner(typeof(global::Infragistics.Windows.Editors.XamDateTimeEditor));
			global::Infragistics.Windows.Editors.ValueEditor.ValueTypeProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Editors.XamDateTimeEditor), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::System.DateTime)));
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Editors.XamDateTimeEditor), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.Editors.XamDateTimeEditor)));
			global::System.Windows.EventManager.RegisterClassHandler(typeof(global::Infragistics.Windows.Editors.XamDateTimeEditor), global::Infragistics.Windows.Editors.XamMonthCalendar.SelectionCommittedEvent, new global::System.Windows.RoutedEventHandler(global::Infragistics.Windows.Editors.XamDateTimeEditor.OnSelectionCommitted));
			global::Infragistics.Windows.Editors.ValueEditor.IsReadOnlyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Editors.XamDateTimeEditor), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.XamDateTimeEditor.OnIsReadOnlyChanged)));
			global::Infragistics.Themes.ThemeManager.RegisterControl(typeof(global::Infragistics.Windows.Editors.XamDateTimeEditor));
		}

		// Token: 0x0600075F RID: 1887 RVA: 0x00020210 File Offset: 0x0001E410
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

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x06000760 RID: 1888 RVA: 0x00020254 File Offset: 0x0001E454
		internal override bool HasDropDown
		{
			get
			{
				return this.AllowDropDown;
			}
		}

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x06000761 RID: 1889 RVA: 0x0002025C File Offset: 0x0001E45C
		internal override bool HasOpenDropDown
		{
			get
			{
				return this.IsDropDownOpen;
			}
		}

		// Token: 0x06000762 RID: 1890 RVA: 0x00020264 File Offset: 0x0001E464
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

		// Token: 0x06000763 RID: 1891 RVA: 0x000202B4 File Offset: 0x0001E4B4
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

		// Token: 0x06000764 RID: 1892 RVA: 0x00020349 File Offset: 0x0001E549
		protected override void OnInitialized(global::System.EventArgs e)
		{
			base.CoerceValue(global::Infragistics.Windows.Editors.XamDateTimeEditor.AllowDropDownProperty);
			base.UpdateDropDownButtonVisibility(this.AllowDropDown);
			this.UpdateComputedDates();
			base.OnInitialized(e);
		}

		// Token: 0x06000765 RID: 1893 RVA: 0x00020370 File Offset: 0x0001E570
		protected override void OnPropertyChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			base.OnPropertyChanged(e);
			global::System.Windows.DependencyProperty property = e.Property;
			if (global::System.Windows.UIElement.IsMouseOverProperty == property || global::Infragistics.Windows.Editors.XamDateTimeEditor.DropDownButtonDisplayModeProperty == property || global::Infragistics.Windows.Editors.ValueEditor.IsInEditModeProperty == property)
			{
				base.UpdateDropDownButtonVisibility(this.AllowDropDown);
			}
		}

		// Token: 0x06000766 RID: 1894 RVA: 0x000203B0 File Offset: 0x0001E5B0
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

		// Token: 0x06000767 RID: 1895 RVA: 0x0002053C File Offset: 0x0001E73C
		internal override void OnValueConstraintChanged(string valueConstraintPropertyName)
		{
			base.OnValueConstraintChanged(valueConstraintPropertyName);
			this.UpdateComputedDates();
		}

		// Token: 0x06000768 RID: 1896 RVA: 0x0002054B File Offset: 0x0001E74B
		internal override void RaiseDropDownClosedIfPending()
		{
			if (this._isClosePending)
			{
				this._isClosePending = false;
				this.RaiseDropDownClosed(new global::System.Windows.RoutedEventArgs());
			}
		}

		// Token: 0x06000769 RID: 1897 RVA: 0x00020568 File Offset: 0x0001E768
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
				global::Infragistics.DependencyPropertyUtilities.SetCurrentValue(this, global::Infragistics.Windows.Editors.XamDateTimeEditor.DateValueProperty, (global::System.DBNull.Value != obj) ? obj : null);
				return result;
			}
			global::System.DateTime? dateTime = (global::System.DateTime?)newValue;
			global::Infragistics.Windows.Editors.MaskInfo maskInfo = base.MaskInfo;
			global::Infragistics.Windows.Editors.EditInfo editInfo = base.EditInfo;
			global::Infragistics.Windows.Editors.SectionsCollection sections2 = maskInfo.Sections;
			if (editInfo == null)
			{
				object newValue2 = null;
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
						newValue2 = sections2.Calendar.ToDateTime(dateTime.Value.Year, dateTime.Value.Month, dateTime.Value.Day, dateTime2.Hour, dateTime2.Minute, dateTime2.Second, dateTime2.Millisecond);
					}
					else
					{
						newValue2 = dateTime;
					}
				}
				global::Infragistics.DependencyPropertyUtilities.SetCurrentValue(this, global::Infragistics.Windows.Editors.ValueEditor.ValueProperty, newValue2);
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
					global::Infragistics.DependencyPropertyUtilities.SetCurrentValue(this, global::Infragistics.Windows.Editors.ValueEditor.ValueProperty, editInfo.Value);
				}
				catch (global::System.Exception ex)
				{
					global::Infragistics.DependencyPropertyUtilities.SetCurrentValue(this, global::Infragistics.Windows.Editors.ValueEditor.ValueProperty, null);
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

		// Token: 0x0600076A RID: 1898 RVA: 0x0002085C File Offset: 0x0001EA5C
		internal override void ToggleDropDown()
		{
			this.IsDropDownOpen = !this.IsDropDownOpen;
		}

		// Token: 0x0600076B RID: 1899 RVA: 0x00020870 File Offset: 0x0001EA70
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

		// Token: 0x0600076C RID: 1900 RVA: 0x000208A4 File Offset: 0x0001EAA4
		private static void OnAllowDropDownChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Editors.XamDateTimeEditor xamDateTimeEditor = (global::Infragistics.Windows.Editors.XamDateTimeEditor)d;
			xamDateTimeEditor.UpdateDropDownButtonVisibility(xamDateTimeEditor.AllowDropDown);
			xamDateTimeEditor.RaisePeerExpandCollapseChange();
		}

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x0600076D RID: 1901 RVA: 0x000208CA File Offset: 0x0001EACA
		// (set) Token: 0x0600076E RID: 1902 RVA: 0x000208DC File Offset: 0x0001EADC
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

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x0600076F RID: 1903 RVA: 0x000208EF File Offset: 0x0001EAEF
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		public global::System.DateTime ComputedMaxDate
		{
			get
			{
				return (global::System.DateTime)base.GetValue(global::Infragistics.Windows.Editors.XamDateTimeEditor.ComputedMaxDateProperty);
			}
		}

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x06000770 RID: 1904 RVA: 0x00020901 File Offset: 0x0001EB01
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		public global::Infragistics.Windows.Editors.CalendarMode ComputedMinCalendarMode
		{
			get
			{
				return (global::Infragistics.Windows.Editors.CalendarMode)base.GetValue(global::Infragistics.Windows.Editors.XamDateTimeEditor.ComputedMinCalendarModeProperty);
			}
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x06000771 RID: 1905 RVA: 0x00020913 File Offset: 0x0001EB13
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public global::System.DateTime ComputedMinDate
		{
			get
			{
				return (global::System.DateTime)base.GetValue(global::Infragistics.Windows.Editors.XamDateTimeEditor.ComputedMinDateProperty);
			}
		}

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x06000772 RID: 1906 RVA: 0x00020925 File Offset: 0x0001EB25
		// (set) Token: 0x06000773 RID: 1907 RVA: 0x00020937 File Offset: 0x0001EB37
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Browsable(false)]
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

		// Token: 0x06000774 RID: 1908 RVA: 0x0002094C File Offset: 0x0001EB4C
		private static void OnDateValueChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Editors.XamDateTimeEditor xamDateTimeEditor = (global::Infragistics.Windows.Editors.XamDateTimeEditor)dependencyObject;
			xamDateTimeEditor.SyncValueProperties(global::Infragistics.Windows.Editors.XamDateTimeEditor.DateValueProperty, e.NewValue);
		}

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x06000775 RID: 1909 RVA: 0x00020972 File Offset: 0x0001EB72
		// (set) Token: 0x06000776 RID: 1910 RVA: 0x00020984 File Offset: 0x0001EB84
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

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x06000777 RID: 1911 RVA: 0x00020997 File Offset: 0x0001EB97
		// (set) Token: 0x06000778 RID: 1912 RVA: 0x000209A9 File Offset: 0x0001EBA9
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

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x06000779 RID: 1913 RVA: 0x000209B7 File Offset: 0x0001EBB7
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::System.Windows.Visibility DropDownButtonVisibility
		{
			get
			{
				return (global::System.Windows.Visibility)base.GetValue(global::Infragistics.Windows.Editors.XamDateTimeEditor.DropDownButtonVisibilityProperty);
			}
		}

		// Token: 0x0600077A RID: 1914 RVA: 0x000209CC File Offset: 0x0001EBCC
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

		// Token: 0x0600077B RID: 1915 RVA: 0x00020A40 File Offset: 0x0001EC40
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

		// Token: 0x0600077C RID: 1916 RVA: 0x00020AAC File Offset: 0x0001ECAC
		private void RegisterToOpenOnLoad()
		{
			global::System.Windows.RoutedEventHandler value = new global::System.Windows.RoutedEventHandler(this.OpenOnLoad);
			base.Loaded -= value;
			base.Loaded += value;
		}

		// Token: 0x0600077D RID: 1917 RVA: 0x00020AE2 File Offset: 0x0001ECE2
		private void OpenOnLoad(object sender, global::System.Windows.RoutedEventArgs e)
		{
			base.Loaded -= this.OpenOnLoad;
			base.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Input, new global::System.Windows.Threading.DispatcherOperationCallback(delegate(object param)
			{
				base.CoerceValue(global::Infragistics.Windows.Editors.XamDateTimeEditor.IsDropDownOpenProperty);
				return null;
			}), null);
		}

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x0600077E RID: 1918 RVA: 0x00020B10 File Offset: 0x0001ED10
		// (set) Token: 0x0600077F RID: 1919 RVA: 0x00020B22 File Offset: 0x0001ED22
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.Bindable(true)]
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

		// Token: 0x06000780 RID: 1920 RVA: 0x00020B38 File Offset: 0x0001ED38
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

		// Token: 0x06000781 RID: 1921 RVA: 0x00020BC4 File Offset: 0x0001EDC4
		private static void OnIsReadOnlyChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			d.CoerceValue(global::Infragistics.Windows.Editors.XamDateTimeEditor.AllowDropDownProperty);
		}

		// Token: 0x06000782 RID: 1922 RVA: 0x00020BD4 File Offset: 0x0001EDD4
		private void OnPopupOpened(object sender, global::System.EventArgs e)
		{
			global::System.Windows.Controls.Primitives.Popup popup = (global::System.Windows.Controls.Primitives.Popup)sender;
			if (popup.Child != null)
			{
				popup.Child.MoveFocus(new global::System.Windows.Input.TraversalRequest(global::System.Windows.Input.FocusNavigationDirection.First));
			}
		}

		// Token: 0x06000783 RID: 1923 RVA: 0x00020C02 File Offset: 0x0001EE02
		private void OnPopupClosed(object sender, global::System.EventArgs e)
		{
			this.RaiseDropDownClosedIfPending();
		}

		// Token: 0x06000784 RID: 1924 RVA: 0x00020C0C File Offset: 0x0001EE0C
		private static void OnSelectionCommitted(object sender, global::System.Windows.RoutedEventArgs e)
		{
			global::Infragistics.Windows.Editors.XamDateTimeEditor xamDateTimeEditor = sender as global::Infragistics.Windows.Editors.XamDateTimeEditor;
			global::Infragistics.Windows.Editors.XamMonthCalendar xamMonthCalendar = e.OriginalSource as global::Infragistics.Windows.Editors.XamMonthCalendar;
			if (xamMonthCalendar != null && xamMonthCalendar.TemplatedParent == xamDateTimeEditor && xamDateTimeEditor.IsDropDownOpen)
			{
				xamDateTimeEditor.ToggleDropDown();
			}
		}

		// Token: 0x06000785 RID: 1925 RVA: 0x00020C48 File Offset: 0x0001EE48
		private void RaisePeerExpandCollapseChange()
		{
			global::Infragistics.Windows.Automation.Peers.Editors.XamMaskedEditorAutomationPeer xamMaskedEditorAutomationPeer = global::System.Windows.Automation.Peers.UIElementAutomationPeer.FromElement(this) as global::Infragistics.Windows.Automation.Peers.Editors.XamMaskedEditorAutomationPeer;
			if (xamMaskedEditorAutomationPeer != null)
			{
				xamMaskedEditorAutomationPeer.RaiseExpandCollapseChanged();
			}
		}

		// Token: 0x06000786 RID: 1926 RVA: 0x00020C6C File Offset: 0x0001EE6C
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

		// Token: 0x06000787 RID: 1927 RVA: 0x00020DE5 File Offset: 0x0001EFE5
		protected virtual void OnDropDownOpened(global::System.Windows.RoutedEventArgs args)
		{
			base.RaiseEventHelper(args);
		}

		// Token: 0x06000788 RID: 1928 RVA: 0x00020DEF File Offset: 0x0001EFEF
		internal void RaiseDropDownOpened(global::System.Windows.RoutedEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.Editors.XamDateTimeEditor.DropDownOpenedEvent;
			args.Source = this;
			this.OnDropDownOpened(args);
		}

		// Token: 0x1400001A RID: 26
		// (add) Token: 0x06000789 RID: 1929 RVA: 0x00020E0A File Offset: 0x0001F00A
		// (remove) Token: 0x0600078A RID: 1930 RVA: 0x00020E18 File Offset: 0x0001F018
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

		// Token: 0x0600078B RID: 1931 RVA: 0x00020E26 File Offset: 0x0001F026
		protected virtual void OnDropDownClosed(global::System.Windows.RoutedEventArgs args)
		{
			base.RaiseEventHelper(args);
		}

		// Token: 0x0600078C RID: 1932 RVA: 0x00020E30 File Offset: 0x0001F030
		internal void RaiseDropDownClosed(global::System.Windows.RoutedEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.Editors.XamDateTimeEditor.DropDownClosedEvent;
			args.Source = this;
			this.OnDropDownClosed(args);
		}

		// Token: 0x1400001B RID: 27
		// (add) Token: 0x0600078D RID: 1933 RVA: 0x00020E4B File Offset: 0x0001F04B
		// (remove) Token: 0x0600078E RID: 1934 RVA: 0x00020E59 File Offset: 0x0001F059
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

		// Token: 0x040002AE RID: 686
		private global::Infragistics.Windows.Licensing.UltraLicense _license;

		// Token: 0x040002AF RID: 687
		private global::System.Windows.Controls.Primitives.Popup _popup;

		// Token: 0x040002B0 RID: 688
		private bool _isClosePending;

		// Token: 0x040002B1 RID: 689
		private bool _hasTimeSectionsOnly;

		// Token: 0x040002B2 RID: 690
		public static readonly global::System.Windows.DependencyProperty AllowDropDownProperty = global::System.Windows.DependencyProperty.Register("AllowDropDown", typeof(bool), typeof(global::Infragistics.Windows.Editors.XamDateTimeEditor), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.TrueBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.XamDateTimeEditor.OnAllowDropDownChanged), new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.Editors.XamDateTimeEditor.CoerceAllowDropDown)));

		// Token: 0x040002B3 RID: 691
		private static readonly global::System.Windows.DependencyPropertyKey ComputedMaxDatePropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("ComputedMaxDate", typeof(global::System.DateTime), typeof(global::Infragistics.Windows.Editors.XamDateTimeEditor), new global::System.Windows.FrameworkPropertyMetadata(global::System.DateTime.MaxValue));

		// Token: 0x040002B4 RID: 692
		public static readonly global::System.Windows.DependencyProperty ComputedMaxDateProperty = global::Infragistics.Windows.Editors.XamDateTimeEditor.ComputedMaxDatePropertyKey.DependencyProperty;

		// Token: 0x040002B5 RID: 693
		private static readonly global::System.Windows.DependencyPropertyKey ComputedMinCalendarModePropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("ComputedMinCalendarMode", typeof(global::Infragistics.Windows.Editors.CalendarMode), typeof(global::Infragistics.Windows.Editors.XamDateTimeEditor), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.Editors.CalendarMode.Days));

		// Token: 0x040002B6 RID: 694
		public static readonly global::System.Windows.DependencyProperty ComputedMinCalendarModeProperty = global::Infragistics.Windows.Editors.XamDateTimeEditor.ComputedMinCalendarModePropertyKey.DependencyProperty;

		// Token: 0x040002B7 RID: 695
		private static readonly global::System.Windows.DependencyPropertyKey ComputedMinDatePropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("ComputedMinDate", typeof(global::System.DateTime), typeof(global::Infragistics.Windows.Editors.XamDateTimeEditor), new global::System.Windows.FrameworkPropertyMetadata(global::System.DateTime.MinValue));

		// Token: 0x040002B8 RID: 696
		public static readonly global::System.Windows.DependencyProperty ComputedMinDateProperty = global::Infragistics.Windows.Editors.XamDateTimeEditor.ComputedMinDatePropertyKey.DependencyProperty;

		// Token: 0x040002B9 RID: 697
		public static readonly global::System.Windows.DependencyProperty DateValueProperty = global::System.Windows.DependencyProperty.Register("DateValue", typeof(global::System.DateTime?), typeof(global::Infragistics.Windows.Editors.XamDateTimeEditor), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.None, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.XamDateTimeEditor.OnDateValueChanged)));

		// Token: 0x040002BA RID: 698
		public static readonly global::System.Windows.DependencyProperty DropDownButtonDisplayModeProperty = global::Infragistics.Windows.Editors.XamComboEditor.DropDownButtonDisplayModeProperty.AddOwner(typeof(global::Infragistics.Windows.Editors.XamDateTimeEditor));

		// Token: 0x040002BB RID: 699
		public static readonly global::System.Windows.DependencyProperty DropDownButtonStyleProperty = global::Infragistics.Windows.Editors.XamComboEditor.DropDownButtonStyleProperty.AddOwner(typeof(global::Infragistics.Windows.Editors.XamDateTimeEditor));

		// Token: 0x040002BC RID: 700
		public static readonly global::System.Windows.DependencyProperty DropDownButtonVisibilityProperty = global::Infragistics.Windows.Editors.XamComboEditor.DropDownButtonVisibilityProperty.AddOwner(typeof(global::Infragistics.Windows.Editors.XamDateTimeEditor));

		// Token: 0x040002BD RID: 701
		public static readonly global::System.Windows.DependencyProperty IsDropDownOpenProperty = global::Infragistics.Windows.Editors.XamComboEditor.IsDropDownOpenProperty.AddOwner(typeof(global::Infragistics.Windows.Editors.XamDateTimeEditor), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.XamDateTimeEditor.OnIsDropDownOpenChanged), new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.Editors.XamDateTimeEditor.OnCoerceIsDropDownOpen)));
	}
}
