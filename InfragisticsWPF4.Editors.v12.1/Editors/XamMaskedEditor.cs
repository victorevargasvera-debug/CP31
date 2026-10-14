using System;
using System.Collections;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Media;
using System.Text;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Threading;
using Infragistics.Windows.Automation.Peers.Editors;
using Infragistics.Windows.Commands;
using Infragistics.Windows.Controls;
using Infragistics.Windows.Controls.Events;
using Infragistics.Windows.Editors.Events;
using Infragistics.Windows.Licensing;

namespace Infragistics.Windows.Editors
{
	// Token: 0x02000071 RID: 113
	[global::System.Windows.StyleTypedProperty(Property = "SpinButtonStyle", StyleTargetType = typeof(global::System.Windows.Controls.Primitives.RepeatButton))]
	[global::System.Windows.TemplatePart(Name = "PART_SpinButtons", Type = typeof(global::System.Windows.FrameworkElement))]
	[global::System.Windows.TemplatePart(Name = "PART_InputTextBox", Type = typeof(global::System.Windows.Controls.TextBox))]
	[global::System.ComponentModel.LicenseProvider(typeof(global::Infragistics.Windows.Licensing.UltraLicenseProvider))]
	[global::Infragistics.Windows.Licensing.UltraLicense("XamMaskedEditor")]
	[global::System.Windows.Markup.ContentProperty("Value")]
	public class XamMaskedEditor : global::Infragistics.Windows.Editors.TextEditorBase, global::Infragistics.Windows.Commands.ICommandHost, global::Infragistics.Windows.Editors.ISupportsSelectableText
	{
		// Token: 0x14000017 RID: 23
		// (add) Token: 0x060005FD RID: 1533 RVA: 0x0001890C File Offset: 0x00016B0C
		// (remove) Token: 0x060005FE RID: 1534 RVA: 0x00018944 File Offset: 0x00016B44
		public event global::System.EventHandler<global::Infragistics.Windows.Editors.Events.InvalidCharEventArgs> InvalidChar;

		// Token: 0x060005FF RID: 1535 RVA: 0x0001897C File Offset: 0x00016B7C
		static XamMaskedEditor()
		{
			global::Infragistics.Windows.Editors.XamMaskedEditor.ExecutingCommandEvent = global::System.Windows.EventManager.RegisterRoutedEvent("ExecutingCommand", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.EventHandler<global::Infragistics.Windows.Controls.Events.ExecutingCommandEventArgs>), typeof(global::Infragistics.Windows.Editors.XamMaskedEditor));
			global::Infragistics.Windows.Editors.XamMaskedEditor.ExecutedCommandEvent = global::System.Windows.EventManager.RegisterRoutedEvent("ExecutedCommand", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.EventHandler<global::Infragistics.Windows.Controls.Events.ExecutedCommandEventArgs>), typeof(global::Infragistics.Windows.Editors.XamMaskedEditor));
			global::Infragistics.Windows.Editors.XamMaskedEditor.SelectAllBehaviorProperty = global::System.Windows.DependencyProperty.Register("SelectAllBehavior", typeof(global::Infragistics.Windows.Editors.MaskSelectAllBehavior), typeof(global::Infragistics.Windows.Editors.XamMaskedEditor), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.Editors.MaskSelectAllBehavior.SelectAllCharacters, global::System.Windows.FrameworkPropertyMetadataOptions.None, null));
			global::Infragistics.Windows.Editors.XamMaskedEditor.AutoFillDateProperty = global::System.Windows.DependencyProperty.Register("AutoFillDate", typeof(global::Infragistics.Windows.Editors.AutoFillDate), typeof(global::Infragistics.Windows.Editors.XamMaskedEditor), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.Editors.AutoFillDate.None));
			global::Infragistics.Windows.Editors.XamMaskedEditor.CaretVisibleProperty = global::System.Windows.DependencyProperty.Register("CaretVisible", typeof(bool), typeof(global::Infragistics.Windows.Editors.XamMaskedEditor), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure | global::System.Windows.FrameworkPropertyMetadataOptions.AffectsArrange, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.XamMaskedEditor.OnCaretVisibleChanged)));
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Editors.XamMaskedEditor), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.Editors.XamMaskedEditor)));
			global::System.Windows.Input.KeyboardNavigation.TabNavigationProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Editors.XamMaskedEditor), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Input.KeyboardNavigationMode.Local));
			global::System.Windows.Input.KeyboardNavigation.ControlTabNavigationProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Editors.XamMaskedEditor), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Input.KeyboardNavigationMode.None));
			global::System.Windows.Input.KeyboardNavigation.DirectionalNavigationProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Editors.XamMaskedEditor), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Input.KeyboardNavigationMode.None));
		}

		// Token: 0x06000600 RID: 1536 RVA: 0x00018F10 File Offset: 0x00017110
		public XamMaskedEditor()
		{
			try
			{
				this._license = (global::System.ComponentModel.LicenseManager.Validate(typeof(global::Infragistics.Windows.Editors.XamMaskedEditor), this) as global::Infragistics.Windows.Licensing.UltraLicense);
			}
			catch (global::System.IO.FileNotFoundException)
			{
			}
			this.InitializeCachedPropertyValues();
		}

		// Token: 0x06000601 RID: 1537 RVA: 0x00018F6C File Offset: 0x0001716C
		public override bool CanEditType(global::System.Type type)
		{
			return global::Infragistics.Windows.Editors.XamMaskedEditor.SupportsDataType(type);
		}

		// Token: 0x06000602 RID: 1538 RVA: 0x00018F74 File Offset: 0x00017174
		public override bool CanRenderType(global::System.Type type)
		{
			return this.CanEditType(type);
		}

		// Token: 0x06000603 RID: 1539 RVA: 0x00018F7D File Offset: 0x0001717D
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override bool IsExtentBasedOnValue(global::System.Windows.Controls.Orientation orientation)
		{
			return orientation == global::System.Windows.Controls.Orientation.Horizontal;
		}

		// Token: 0x06000604 RID: 1540 RVA: 0x00018F85 File Offset: 0x00017185
		protected override global::System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
		{
			return new global::Infragistics.Windows.Automation.Peers.Editors.XamMaskedEditorAutomationPeer(this);
		}

		// Token: 0x06000605 RID: 1541 RVA: 0x00018F90 File Offset: 0x00017190
		protected override void DoInitialization()
		{
			base.DoInitialization();
			global::Infragistics.Windows.Editors.MaskInfo maskInfo = this.MaskInfo;
			maskInfo.RecreateSections(true);
			maskInfo.InternalRefreshValue(base.Value);
			this.ApplyMaskToText();
		}

		// Token: 0x06000606 RID: 1542 RVA: 0x00018FC4 File Offset: 0x000171C4
		protected override string OnCoerceText(string text)
		{
			text = base.OnCoerceText(text);
			if (!base.SyncingValueProperties && (this._editInfo == null || !this._editInfo._inOnTextChanged) && text != null && text.Length > 0)
			{
				global::Infragistics.Windows.Editors.MaskInfo maskInfo = global::Infragistics.Windows.Editors.MaskInfo.CreateMaskInfoForConverter(this);
				if (maskInfo != null)
				{
					try
					{
						global::Infragistics.Windows.Editors.XamMaskedEditor.SetText(maskInfo.Sections, text, maskInfo);
						text = global::Infragistics.Windows.Editors.XamMaskedEditor.GetText(maskInfo.Sections, maskInfo.DataMode, maskInfo);
					}
					finally
					{
						global::Infragistics.Windows.Editors.MaskInfo.ReleaseMaskInfoForConverter(maskInfo);
					}
				}
			}
			return text;
		}

		// Token: 0x06000607 RID: 1543 RVA: 0x0001904C File Offset: 0x0001724C
		protected override void OnPropertyChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			base.OnPropertyChanged(e);
			global::System.Windows.DependencyProperty property = e.Property;
			if (global::Infragistics.Windows.Editors.ValueEditor.FormatProviderProperty == property || global::System.Windows.FrameworkElement.LanguageProperty == property)
			{
				if (this._maskInfo != null)
				{
					this._maskInfo.InitializeFormatProvider();
					this.ReparseMask();
				}
			}
			else if (global::Infragistics.Windows.Editors.ValueEditor.FormatProperty == property)
			{
				if (this._maskInfo != null)
				{
					this._maskInfo.Format = (e.NewValue as string);
				}
			}
			else if (global::Infragistics.Windows.Editors.ValueEditor.IsInEditModeProperty == property)
			{
				this.ProcessIsBeingEditedAndFocusedChanged();
			}
			if (global::System.Windows.UIElement.IsMouseOverProperty == property || global::Infragistics.Windows.Editors.XamMaskedEditor.SpinButtonDisplayModeProperty == property || global::Infragistics.Windows.Editors.ValueEditor.IsInEditModeProperty == property || global::Infragistics.Windows.Editors.ValueEditor.IsReadOnlyProperty == property)
			{
				this.UpdateSpinButtonVisibility();
			}
		}

		// Token: 0x06000608 RID: 1544 RVA: 0x000190F0 File Offset: 0x000172F0
		protected override bool ValidateCurrentValue(out global::System.Exception error)
		{
			if (!base.ValidateCurrentValue(out error))
			{
				return false;
			}
			if (this._skipNextMaskValidation)
			{
				error = null;
				this._skipNextMaskValidation = false;
				return true;
			}
			global::Infragistics.Windows.Editors.MaskInfo maskInfo = this.MaskInfo;
			string message;
			if (maskInfo != null && maskInfo.Sections != null && !this.IsInputValid(maskInfo.Sections, out message))
			{
				error = new global::System.Exception(message);
				return false;
			}
			return true;
		}

		// Token: 0x06000609 RID: 1545 RVA: 0x0001914C File Offset: 0x0001734C
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override bool ValidateValue(object value, out global::System.Exception error)
		{
			if (!base.ValidateValue(value, out error))
			{
				return false;
			}
			global::Infragistics.Windows.Editors.MaskInfo maskInfo = global::Infragistics.Windows.Editors.MaskInfo.CreateMaskInfoForConverter(this);
			try
			{
				if (maskInfo != null && maskInfo.Sections != null)
				{
					if (!maskInfo.InternalRefreshValue(value, out error))
					{
						return false;
					}
					string message;
					if (!this.IsInputValid(maskInfo.Sections, out message))
					{
						error = new global::System.Exception(message);
						return false;
					}
				}
			}
			finally
			{
				global::Infragistics.Windows.Editors.MaskInfo.ReleaseMaskInfoForConverter(maskInfo);
			}
			return true;
		}

		// Token: 0x0600060A RID: 1546 RVA: 0x000191C0 File Offset: 0x000173C0
		protected override void OnFocusSiteChanged()
		{
			base.OnFocusSiteChanged();
			global::Infragistics.Windows.Editors.EditInfo editInfo = this.EditInfo;
			if (editInfo != null)
			{
				editInfo.InitializeIMETextBox(base.FocusSite);
			}
		}

		// Token: 0x0600060B RID: 1547 RVA: 0x000191EC File Offset: 0x000173EC
		protected override void OnTouchEnter(global::System.Windows.Input.TouchEventArgs e)
		{
			base.OnTouchEnter(e);
			if (!global::Infragistics.Windows.Editors.XamMaskedEditor._IsTouchEnabled)
			{
				global::Infragistics.Windows.Editors.XamMaskedEditor._IsTouchEnabled = true;
				global::Infragistics.Windows.Editors.EditInfo editInfo = this.EditInfo;
				if (editInfo != null)
				{
					editInfo.InitializeIsTextBoxEntryEnabled();
				}
			}
		}

		// Token: 0x0600060C RID: 1548 RVA: 0x0001921D File Offset: 0x0001741D
		internal override void OnValueConstraintChanged(string valueConstraintPropertyName)
		{
			if (this._maskInfo != null)
			{
				this._maskInfo.InitializedCachedMinMaxValues();
			}
			base.OnValueConstraintChanged(valueConstraintPropertyName);
		}

		// Token: 0x0600060D RID: 1549 RVA: 0x0001923C File Offset: 0x0001743C
		private void InitializeCachedPropertyValues()
		{
			this._cachedCaretVisible = (bool)global::Infragistics.Windows.Editors.XamMaskedEditor.CaretVisibleProperty.GetMetadata(this).DefaultValue;
			this._cachedClipMode = (global::Infragistics.Windows.Editors.MaskMode)global::Infragistics.Windows.Editors.XamMaskedEditor.ClipModeProperty.GetMetadata(this).DefaultValue;
			this._cachedDataMode = (global::Infragistics.Windows.Editors.MaskMode)global::Infragistics.Windows.Editors.XamMaskedEditor.DataModeProperty.GetMetadata(this).DefaultValue;
			this._cachedDisplayMode = (global::Infragistics.Windows.Editors.MaskMode)global::Infragistics.Windows.Editors.XamMaskedEditor.DisplayModeProperty.GetMetadata(this).DefaultValue;
			this._cachedMask = (string)global::Infragistics.Windows.Editors.XamMaskedEditor.MaskProperty.GetMetadata(this).DefaultValue;
			this._cachedPadChar = (char)global::Infragistics.Windows.Editors.XamMaskedEditor.PadCharProperty.GetMetadata(this).DefaultValue;
			this._cachedPromptChar = (char)global::Infragistics.Windows.Editors.XamMaskedEditor.PromptCharProperty.GetMetadata(this).DefaultValue;
			this._cachedTrimFractionalZeros = (bool)global::Infragistics.Windows.Editors.XamMaskedEditor.TrimFractionalZerosProperty.GetMetadata(this).DefaultValue;
		}

		// Token: 0x0600060E RID: 1550 RVA: 0x00019324 File Offset: 0x00017524
		internal bool ResolveMask(global::System.Type dataType, global::System.IFormatProvider formatProvider, out string mask)
		{
			global::Infragistics.Windows.Editors.MaskDefaultType maskDefaultType;
			return this.ResolveMask(dataType, formatProvider, out mask, out maskDefaultType);
		}

		// Token: 0x0600060F RID: 1551 RVA: 0x0001933C File Offset: 0x0001753C
		internal bool ResolveMask(global::System.Type dataType, global::System.IFormatProvider formatProvider, out string mask, out global::Infragistics.Windows.Editors.MaskDefaultType maskDefaultType)
		{
			mask = null;
			maskDefaultType = global::Infragistics.Windows.Editors.MaskDefaultType.None;
			string mask2 = this.Mask;
			if (mask2 != null && mask2.Length > 0)
			{
				mask = mask2;
				return true;
			}
			string defaultMask = this.GetDefaultMask(dataType, formatProvider);
			if (defaultMask != null && defaultMask.Length > 0)
			{
				mask = defaultMask;
				return true;
			}
			if (null == dataType)
			{
				return false;
			}
			mask = global::Infragistics.Windows.Editors.XamMaskedEditor.GetDefaultMaskForType(dataType, out maskDefaultType);
			return mask != null && mask.Length > 0;
		}

		// Token: 0x06000610 RID: 1552 RVA: 0x000193A8 File Offset: 0x000175A8
		internal static string GetNonstandardForeignDateMaskAndPostfixSymbols(global::System.IFormatProvider formatProv, ref global::System.Collections.Hashtable foreignDateSymbols)
		{
			foreignDateSymbols = null;
			string result = null;
			global::System.Globalization.DateTimeFormatInfo dateTimeFormatInfo = global::Infragistics.Windows.Editors.XamMaskedEditor.GetDateTimeFormatInfo(formatProv);
			if (dateTimeFormatInfo == null)
			{
				return result;
			}
			string longDatePattern = dateTimeFormatInfo.LongDatePattern;
			if (longDatePattern == null)
			{
				return result;
			}
			int num = longDatePattern.IndexOfAny(new char[]
			{
				'm',
				'M'
			});
			int num2 = longDatePattern.IndexOfAny(new char[]
			{
				'd',
				'D'
			});
			int num3 = longDatePattern.IndexOfAny(new char[]
			{
				'y',
				'Y'
			});
			int num4 = longDatePattern.LastIndexOfAny(new char[]
			{
				'm',
				'M'
			});
			int num5 = longDatePattern.LastIndexOfAny(new char[]
			{
				'd',
				'D'
			});
			int num6 = longDatePattern.LastIndexOfAny(new char[]
			{
				'y',
				'Y'
			});
			int num7 = num4 - num;
			int num8 = num5 - num2;
			if (num7 < 2 && num8 < 2)
			{
				char c = '\0';
				if (num4 + 2 < longDatePattern.Length)
				{
					c = longDatePattern[num4 + 2];
				}
				char c2 = '\0';
				if (num5 + 2 < longDatePattern.Length)
				{
					c2 = longDatePattern[num5 + 2];
				}
				char c3 = '\0';
				if (num6 + 2 < longDatePattern.Length)
				{
					c3 = longDatePattern[num6 + 2];
				}
				if (c != '\0' && c2 != '\0' && c3 != '\0' && num != -1 && num2 != -1 && num3 != -1)
				{
					foreignDateSymbols = new global::System.Collections.Hashtable(3);
					foreignDateSymbols.Add(typeof(global::Infragistics.Windows.Editors.DaySection), c2);
					foreignDateSymbols.Add(typeof(global::Infragistics.Windows.Editors.MonthSection), c);
					foreignDateSymbols.Add(typeof(global::Infragistics.Windows.Editors.YearSection), c3);
					int num9 = num6 - num3 + 1;
					string text = (num9 > 2) ? "yyyy" : "yy";
					string text2 = "mm";
					string text3 = "dd";
					if (num <= num2 && num <= num3)
					{
						if (num2 < num3)
						{
							result = string.Format("{0}{1}{2}{3}{4}{5}", new object[]
							{
								text2,
								c,
								text3,
								c2,
								text,
								c3
							});
						}
						else
						{
							result = string.Format("{0}{1}{2}{3}{4}{5}", new object[]
							{
								text2,
								c,
								text,
								c3,
								text3,
								c2
							});
						}
					}
					else if (num2 <= num && num2 <= num3)
					{
						if (num < num3)
						{
							result = string.Format("{0}{1}{2}{3}{4}{5}", new object[]
							{
								text3,
								c2,
								text2,
								c,
								text,
								c3
							});
						}
						else
						{
							result = string.Format("{0}{1}{2}{3}{4}{5}", new object[]
							{
								text3,
								c2,
								text,
								c3,
								text2,
								c
							});
						}
					}
					else if (num3 <= num && num3 <= num2)
					{
						if (num < num2)
						{
							result = string.Format("{0}{1}{2}{3}{4}{5}", new object[]
							{
								text,
								c3,
								text2,
								c,
								text3,
								c2
							});
						}
						else
						{
							result = string.Format("{0}{1}{2}{3}{4}{5}", new object[]
							{
								text,
								c3,
								text3,
								c2,
								text2,
								c
							});
						}
					}
				}
			}
			return result;
		}

		// Token: 0x06000611 RID: 1553 RVA: 0x000197A4 File Offset: 0x000179A4
		internal static bool IsSectionNumeric(global::Infragistics.Windows.Editors.SectionBase section)
		{
			if (section is global::Infragistics.Windows.Editors.NumberSection)
			{
				return true;
			}
			bool flag = false;
			bool flag2 = false;
			for (int i = 0; i < section.DisplayChars.Count; i++)
			{
				global::Infragistics.Windows.Editors.DisplayCharBase displayCharBase = section.DisplayChars[i];
				if (displayCharBase.Section.PlusSignChar == displayCharBase.Char || displayCharBase.Section.MinusSignChar == displayCharBase.Char)
				{
					if (flag || flag2)
					{
						return false;
					}
					flag = true;
				}
				else
				{
					if (!(displayCharBase is global::Infragistics.Windows.Editors.DigitChar) && (displayCharBase.IsEditable || !char.IsDigit(displayCharBase.Char)))
					{
						return false;
					}
					if (!displayCharBase.IsEmpty)
					{
						flag2 = true;
					}
				}
			}
			return true;
		}

		// Token: 0x06000612 RID: 1554 RVA: 0x0001983E File Offset: 0x00017A3E
		internal static int ConvertToFourYear(int twoYear, global::System.Globalization.Calendar calendar)
		{
			if (twoYear < 100)
			{
				return calendar.ToFourDigitYear(twoYear);
			}
			return twoYear;
		}

		// Token: 0x06000613 RID: 1555 RVA: 0x00019850 File Offset: 0x00017A50
		private static int GetNumberSectionValueHelper(global::Infragistics.Windows.Editors.SectionsCollection sections, global::System.Type sectionType)
		{
			global::Infragistics.Windows.Editors.NumberSection numberSection = (global::Infragistics.Windows.Editors.NumberSection)global::Infragistics.Windows.Editors.XamMaskedEditor.GetSection(sections, sectionType);
			if (numberSection == null)
			{
				return -2;
			}
			if (!numberSection.IsEmpty)
			{
				return numberSection.ToInt();
			}
			return -1;
		}

		// Token: 0x06000614 RID: 1556 RVA: 0x00019880 File Offset: 0x00017A80
		internal static global::System.DateTime? GetDateValue(global::Infragistics.Windows.Editors.SectionsCollection sections)
		{
			int numberSectionValueHelper = global::Infragistics.Windows.Editors.XamMaskedEditor.GetNumberSectionValueHelper(sections, typeof(global::Infragistics.Windows.Editors.YearSection));
			int numberSectionValueHelper2 = global::Infragistics.Windows.Editors.XamMaskedEditor.GetNumberSectionValueHelper(sections, typeof(global::Infragistics.Windows.Editors.MonthSection));
			int numberSectionValueHelper3 = global::Infragistics.Windows.Editors.XamMaskedEditor.GetNumberSectionValueHelper(sections, typeof(global::Infragistics.Windows.Editors.DaySection));
			if (numberSectionValueHelper > 0 && numberSectionValueHelper2 > 0 && numberSectionValueHelper3 > 0)
			{
				global::System.DateTime now = global::System.DateTime.Now;
				try
				{
					return new global::System.DateTime?(new global::System.DateTime(numberSectionValueHelper, numberSectionValueHelper2, numberSectionValueHelper3));
				}
				catch
				{
				}
			}
			return null;
		}

		// Token: 0x06000615 RID: 1557 RVA: 0x00019904 File Offset: 0x00017B04
		internal static global::System.DateTime GetDateTimeValue(global::Infragistics.Windows.Editors.SectionsCollection sections)
		{
			global::System.Globalization.Calendar calendar = sections.Calendar;
			global::System.DateTime now = global::System.DateTime.Now;
			int num = 1;
			int num2 = 1;
			int year = calendar.GetYear(now);
			int num3 = 0;
			int num4 = 0;
			int num5 = 0;
			bool flag = true;
			global::Infragistics.Windows.Editors.MaskInfo maskInfo = sections.MaskInfo;
			if (maskInfo != null && maskInfo.MaskEditor != null)
			{
				object obj = maskInfo.MaskEditor.OriginalValue;
				if (obj != null)
				{
					obj = global::Infragistics.CoreUtilities.ConvertDataValue(obj, typeof(global::System.DateTime), maskInfo.FormatProvider, maskInfo.Format);
				}
				if (obj is global::System.DateTime)
				{
					global::System.DateTime dateTime = (global::System.DateTime)obj;
					if (dateTime >= calendar.MinSupportedDateTime && dateTime <= calendar.MaxSupportedDateTime)
					{
						num = calendar.GetDayOfMonth(dateTime);
						num2 = calendar.GetMonth(dateTime);
						year = calendar.GetYear(dateTime);
						num3 = calendar.GetHour(dateTime);
						num4 = calendar.GetMinute(dateTime);
						num5 = calendar.GetSecond(dateTime);
						flag = false;
					}
				}
			}
			global::Infragistics.Windows.Editors.MonthSection monthSection = (global::Infragistics.Windows.Editors.MonthSection)global::Infragistics.Windows.Editors.XamMaskedEditor.GetSection(sections, typeof(global::Infragistics.Windows.Editors.MonthSection));
			global::Infragistics.Windows.Editors.DaySection daySection = (global::Infragistics.Windows.Editors.DaySection)global::Infragistics.Windows.Editors.XamMaskedEditor.GetSection(sections, typeof(global::Infragistics.Windows.Editors.DaySection));
			global::Infragistics.Windows.Editors.YearSection yearSection = (global::Infragistics.Windows.Editors.YearSection)global::Infragistics.Windows.Editors.XamMaskedEditor.GetSection(sections, typeof(global::Infragistics.Windows.Editors.YearSection));
			global::Infragistics.Windows.Editors.HourSection hourSection = (global::Infragistics.Windows.Editors.HourSection)global::Infragistics.Windows.Editors.XamMaskedEditor.GetSection(sections, typeof(global::Infragistics.Windows.Editors.HourSection));
			global::Infragistics.Windows.Editors.MinuteSection minuteSection = (global::Infragistics.Windows.Editors.MinuteSection)global::Infragistics.Windows.Editors.XamMaskedEditor.GetSection(sections, typeof(global::Infragistics.Windows.Editors.MinuteSection));
			global::Infragistics.Windows.Editors.SecondSection secondSection = (global::Infragistics.Windows.Editors.SecondSection)global::Infragistics.Windows.Editors.XamMaskedEditor.GetSection(sections, typeof(global::Infragistics.Windows.Editors.SecondSection));
			if (flag)
			{
				num = ((hourSection != null) ? calendar.GetDayOfMonth(now) : 1);
				num2 = ((hourSection != null) ? calendar.GetMonth(now) : 1);
			}
			global::Infragistics.Windows.Editors.AMPMSection ampmsection = (global::Infragistics.Windows.Editors.AMPMSection)global::Infragistics.Windows.Editors.XamMaskedEditor.GetSection(sections, typeof(global::Infragistics.Windows.Editors.AMPMSection));
			if (monthSection == null && daySection == null && yearSection == null && hourSection == null && minuteSection == null && secondSection == null)
			{
				string text = global::Infragistics.Windows.Editors.XamMaskedEditor.AreAllDisplayCharsEmpty(sections) ? null : global::Infragistics.Windows.Editors.XamMaskedEditor.GetText(sections, maskInfo.DataMode, maskInfo);
				if (!string.IsNullOrEmpty(text))
				{
					global::System.Windows.Data.IValueConverter valueToTextConverter = maskInfo.MaskEditor.ValueToTextConverter;
					object obj2 = (valueToTextConverter != null) ? valueToTextConverter.ConvertBack(text, typeof(global::System.DateTime), maskInfo.MaskEditor, maskInfo.FormatProvider as global::System.Globalization.CultureInfo) : global::Infragistics.CoreUtilities.ConvertDataValue(text, typeof(global::System.DateTime), maskInfo.FormatProvider, maskInfo.Format);
					if (obj2 is global::System.DateTime)
					{
						return (global::System.DateTime)obj2;
					}
				}
				throw new global::System.ArgumentException(global::Infragistics.Windows.Editors.ValueEditor.GetString("LE_ArgumentException_4"));
			}
			int num6 = (hourSection != null) ? hourSection.ToInt() : num3;
			if (hourSection != null && ampmsection != null)
			{
				if (num6 < 12)
				{
					if (ampmsection.PMValue != null && string.Compare(ampmsection.PMValue, ampmsection.GetText(global::Infragistics.Windows.Editors.MaskMode.IncludeLiterals), true, global::System.Globalization.CultureInfo.CurrentCulture) == 0)
					{
						num6 += 12;
					}
				}
				else if (12 == num6 && ampmsection.AMValue != null && string.Compare(ampmsection.AMValue, ampmsection.GetText(global::Infragistics.Windows.Editors.MaskMode.IncludeLiterals), true, global::System.Globalization.CultureInfo.CurrentCulture) == 0)
				{
					num6 -= 12;
				}
			}
			int year2 = (yearSection != null) ? yearSection.GetYear() : year;
			if (daySection == null && monthSection != null)
			{
				int month = monthSection.ToInt();
				int daysInMonth = calendar.GetDaysInMonth(year2, month);
				if (num > daysInMonth)
				{
					num = daysInMonth;
				}
			}
			return calendar.ToDateTime(year2, (monthSection != null) ? monthSection.ToInt() : num2, (daySection != null) ? daySection.ToInt() : num, num6, (minuteSection != null) ? minuteSection.ToInt() : num4, (secondSection != null) ? secondSection.ToInt() : num5, 0);
		}

		// Token: 0x06000616 RID: 1558 RVA: 0x00019C8C File Offset: 0x00017E8C
		internal static string GetText(global::Infragistics.Windows.Editors.SectionsCollection sections, global::Infragistics.Windows.Editors.MaskMode maskMode, char promptChar, char padChar)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(1 + global::Infragistics.Windows.Editors.XamMaskedEditor.GetTotalNumberOfDisplayChars(sections));
			int i = 0;
			int count = sections.Count;
			while (i < count)
			{
				global::Infragistics.Windows.Editors.DisplayCharsCollection displayChars = sections[i].DisplayChars;
				int count2 = displayChars.Count;
				for (int j = 0; j < count2; j++)
				{
					global::Infragistics.Windows.Editors.DisplayCharBase displayCharBase = displayChars[j];
					char @char = displayCharBase.GetChar(maskMode, promptChar, padChar);
					if (@char != '\0')
					{
						stringBuilder.Append(@char);
					}
					if (displayCharBase is global::Infragistics.Windows.Editors.DigitChar && ((global::Infragistics.Windows.Editors.DigitChar)displayCharBase).ShouldIncludeComma(maskMode) && displayCharBase.Section.CommaChar != '\0')
					{
						stringBuilder.Append(displayCharBase.Section.CommaChar);
					}
				}
				i++;
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06000617 RID: 1559 RVA: 0x00019D48 File Offset: 0x00017F48
		internal static bool AreAllDisplayCharsEmpty(global::Infragistics.Windows.Editors.SectionsCollection sections)
		{
			foreach (object obj in sections.AllDisplayCharacters)
			{
				global::Infragistics.Windows.Editors.DisplayCharBase displayCharBase = (global::Infragistics.Windows.Editors.DisplayCharBase)obj;
				if (displayCharBase.IsEditable && !displayCharBase.IsEmpty)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06000618 RID: 1560 RVA: 0x00019DB4 File Offset: 0x00017FB4
		internal static string GetText(global::Infragistics.Windows.Editors.SectionsCollection sections, global::Infragistics.Windows.Editors.MaskMode maskMode, global::Infragistics.Windows.Editors.MaskInfo maskInfo)
		{
			return global::Infragistics.Windows.Editors.XamMaskedEditor.GetText(sections, maskMode, (maskInfo != null) ? maskInfo.PromptChar : '_', (maskInfo != null) ? maskInfo.PadChar : ' ');
		}

		// Token: 0x06000619 RID: 1561 RVA: 0x00019DD7 File Offset: 0x00017FD7
		internal static string GetText(global::Infragistics.Windows.Editors.SectionsCollection sections, global::Infragistics.Windows.Editors.MaskMode maskMode, global::Infragistics.Windows.Editors.MaskInfo maskInfo, string nullText)
		{
			if (global::Infragistics.Windows.Editors.XamMaskedEditor.AreAllDisplayCharsEmpty(sections))
			{
				return nullText;
			}
			return global::Infragistics.Windows.Editors.XamMaskedEditor.GetText(sections, maskMode, (maskInfo != null) ? maskInfo.PromptChar : '_', (maskInfo != null) ? maskInfo.PadChar : ' ');
		}

		// Token: 0x0600061A RID: 1562 RVA: 0x00019E04 File Offset: 0x00018004
		internal static int SetText(global::Infragistics.Windows.Editors.SectionsCollection sections, string text, char promptCharacter, char padCharacter)
		{
			return global::Infragistics.Windows.Editors.XamMaskedEditor.SetText(sections, text, promptCharacter, padCharacter, true);
		}

		// Token: 0x0600061B RID: 1563 RVA: 0x00019E10 File Offset: 0x00018010
		internal static int SetText(global::Infragistics.Windows.Editors.SectionsCollection sections, string text, char promptCharacter, char padCharacter, bool skipDigitSeparator)
		{
			if (text == null)
			{
				text = "";
			}
			global::Infragistics.Windows.Editors.XamMaskedEditor.EraseAllChars(sections);
			int num = 0;
			global::Infragistics.Windows.Editors.DisplayCharBase displayCharBase = global::Infragistics.Windows.Editors.XamMaskedEditor.GetDisplayCharAtPosition(sections, 0);
			global::Infragistics.Windows.Editors.MaskInfo maskInfo = sections.MaskInfo;
			global::Infragistics.Windows.Editors.MaskMode maskMode = (maskInfo != null) ? maskInfo.DataMode : global::Infragistics.Windows.Editors.MaskMode.IncludeLiterals;
			while (displayCharBase != null && num < text.Length)
			{
				char c = text[num];
				if (displayCharBase.MatchChar(c))
				{
					if (displayCharBase.IsEditable)
					{
						displayCharBase.Char = c;
					}
					num++;
					displayCharBase = displayCharBase.NextDisplayChar;
				}
				else if (promptCharacter == c || padCharacter == c)
				{
					bool flag = true;
					if (!displayCharBase.IsEditable && (maskMode == global::Infragistics.Windows.Editors.MaskMode.Raw || global::Infragistics.Windows.Editors.MaskMode.IncludePromptChars == maskMode))
					{
						flag = false;
					}
					if (flag)
					{
						num++;
					}
					displayCharBase = displayCharBase.NextDisplayChar;
				}
				else if (displayCharBase is global::Infragistics.Windows.Editors.DigitChar && displayCharBase.Section is global::Infragistics.Windows.Editors.NumberSection && skipDigitSeparator && displayCharBase.Section.CommaChar == c)
				{
					num++;
				}
				else
				{
					global::Infragistics.Windows.Editors.SectionBase nextSection = displayCharBase.Section.NextSection;
					if (nextSection == null)
					{
						break;
					}
					displayCharBase = nextSection.FirstDisplayChar;
				}
			}
			for (int i = 0; i < sections.Count; i++)
			{
				global::Infragistics.Windows.Editors.EditSectionBase editSectionBase = sections[i] as global::Infragistics.Windows.Editors.EditSectionBase;
				if (editSectionBase != null)
				{
					editSectionBase.ValidateSection();
				}
			}
			return num;
		}

		// Token: 0x0600061C RID: 1564 RVA: 0x00019F37 File Offset: 0x00018137
		internal static int SetText(global::Infragistics.Windows.Editors.SectionsCollection sections, string text, global::Infragistics.Windows.Editors.MaskInfo maskInfo)
		{
			return global::Infragistics.Windows.Editors.XamMaskedEditor.SetText(sections, text, maskInfo.PromptChar, maskInfo.PadChar, maskInfo.SkipDigitSeparator);
		}

		// Token: 0x0600061D RID: 1565 RVA: 0x00019F54 File Offset: 0x00018154
		internal static void EraseAllChars(global::Infragistics.Windows.Editors.SectionsCollection sections)
		{
			if (sections != null)
			{
				int i = 0;
				int count = sections.Count;
				while (i < count)
				{
					global::Infragistics.Windows.Editors.DisplayCharsCollection displayChars = sections[i].DisplayChars;
					int j = 0;
					int count2 = displayChars.Count;
					while (j < count2)
					{
						global::Infragistics.Windows.Editors.DisplayCharBase displayCharBase = displayChars[j];
						if (displayCharBase != null && displayCharBase.IsEditable)
						{
							displayCharBase.Char = '\0';
						}
						j++;
					}
					i++;
				}
			}
		}

		// Token: 0x0600061E RID: 1566 RVA: 0x00019FB8 File Offset: 0x000181B8
		internal static global::Infragistics.Windows.Editors.DisplayCharBase GetDisplayCharAtPosition(global::Infragistics.Windows.Editors.SectionsCollection sections, int position)
		{
			if (sections == null || position < 0 || sections.Count <= 0)
			{
				return null;
			}
			int count = sections.Count;
			int num = 0;
			for (int i = 0; i < count; i++)
			{
				global::Infragistics.Windows.Editors.SectionBase sectionBase = sections[i];
				int count2 = sectionBase.DisplayChars.Count;
				if (position < num + count2)
				{
					return sectionBase.DisplayChars[position - num];
				}
				num += count2;
			}
			return null;
		}

		// Token: 0x0600061F RID: 1567 RVA: 0x0001A020 File Offset: 0x00018220
		internal static int GetTotalNumberOfDisplayChars(global::Infragistics.Windows.Editors.SectionsCollection sections)
		{
			if (sections == null || sections.Count <= 0)
			{
				return 0;
			}
			int count = sections.Count;
			int num = 0;
			for (int i = 0; i < count; i++)
			{
				global::Infragistics.Windows.Editors.SectionBase sectionBase = sections[i];
				num += sectionBase.DisplayChars.Count;
			}
			return num;
		}

		// Token: 0x06000620 RID: 1568 RVA: 0x0001A068 File Offset: 0x00018268
		private static object GetWholeNumberValue(global::Infragistics.Windows.Editors.SectionsCollection sections, global::System.Type wholeNumberType, global::Infragistics.Windows.Editors.MaskInfo maskInfo)
		{
			string text = global::Infragistics.Windows.Editors.XamMaskedEditor.GetText(sections, global::Infragistics.Windows.Editors.MaskMode.Raw, maskInfo);
			if (text == null || text.Length == 0)
			{
				throw new global::System.InvalidOperationException(global::Infragistics.Windows.Editors.ValueEditor.GetString("LE_InvalidOperationException_9"));
			}
			decimal num = decimal.Parse(text, maskInfo.FormatProvider);
			return global::System.Convert.ChangeType(num, wholeNumberType, maskInfo.FormatProvider);
		}

		// Token: 0x06000621 RID: 1569 RVA: 0x0001A0B8 File Offset: 0x000182B8
		private static double GetDoubleValue(global::Infragistics.Windows.Editors.SectionsCollection sections, global::Infragistics.Windows.Editors.MaskInfo maskInfo)
		{
			string text = string.Empty;
			string text2 = string.Empty;
			bool flag = false;
			for (int i = 0; i < sections.Count; i++)
			{
				global::Infragistics.Windows.Editors.SectionBase sectionBase = sections[i];
				if (global::Infragistics.Windows.Editors.XamMaskedEditor.IsSectionNumeric(sectionBase))
				{
					if (!flag)
					{
						text += sectionBase.GetText(global::Infragistics.Windows.Editors.MaskMode.Raw);
					}
					else
					{
						text2 = sectionBase.GetText(global::Infragistics.Windows.Editors.MaskMode.Raw);
					}
				}
				else
				{
					if (!(sectionBase is global::Infragistics.Windows.Editors.LiteralSection))
					{
						text = null;
						text2 = null;
						break;
					}
					if (sectionBase.DecimalSeperatorChar == sectionBase.DisplayChars[0].Char)
					{
						if (flag)
						{
							text = null;
							text2 = null;
							break;
						}
						flag = true;
					}
				}
			}
			if (text2 != null && text != null)
			{
				try
				{
					if (text2.Length > 0)
					{
						global::System.IFormatProvider provider = (maskInfo != null) ? maskInfo.FormatProvider : null;
						return double.Parse(text + maskInfo.DecimalSeperatorChar + text2, provider);
					}
					return double.Parse(text);
				}
				catch (global::System.Exception)
				{
				}
			}
			string text3 = global::Infragistics.Windows.Editors.XamMaskedEditor.GetText(sections, maskInfo.DataMode, maskInfo);
			return double.Parse(text3, maskInfo.FormatProvider);
		}

		// Token: 0x06000622 RID: 1570 RVA: 0x0001A1C4 File Offset: 0x000183C4
		private static float GetFloatValue(global::Infragistics.Windows.Editors.SectionsCollection sections, global::Infragistics.Windows.Editors.MaskInfo maskInfo)
		{
			double num = global::Infragistics.Windows.Editors.XamMaskedEditor.GetDoubleValue(sections, maskInfo);
			return (float)num;
		}

		// Token: 0x06000623 RID: 1571 RVA: 0x0001A1DC File Offset: 0x000183DC
		private static decimal GetCurrencyValue(global::Infragistics.Windows.Editors.SectionsCollection sections, global::Infragistics.Windows.Editors.MaskInfo maskInfo)
		{
			string text = string.Empty;
			string text2 = string.Empty;
			bool flag = false;
			for (int i = 0; i < sections.Count; i++)
			{
				global::Infragistics.Windows.Editors.SectionBase sectionBase = sections[i];
				if (global::Infragistics.Windows.Editors.XamMaskedEditor.IsSectionNumeric(sectionBase))
				{
					if (!flag)
					{
						text += sectionBase.GetText(global::Infragistics.Windows.Editors.MaskMode.Raw);
					}
					else
					{
						text2 = sectionBase.GetText(global::Infragistics.Windows.Editors.MaskMode.Raw);
					}
				}
				else
				{
					if (!(sectionBase is global::Infragistics.Windows.Editors.LiteralSection))
					{
						text = null;
						text2 = null;
						break;
					}
					if (sectionBase.DecimalSeperatorChar == sectionBase.DisplayChars[0].Char)
					{
						if (flag)
						{
							text = null;
							text2 = null;
							break;
						}
						flag = true;
					}
				}
			}
			if (text2 != null && text != null)
			{
				try
				{
					if (text2.Length > 0)
					{
						string str = (maskInfo != null) ? maskInfo.DecimalSeperatorChar.ToString() : global::System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator.ToString();
						global::System.IFormatProvider provider = (maskInfo != null) ? maskInfo.FormatProvider : null;
						return decimal.Parse(text + str + text2, global::System.Globalization.NumberStyles.Currency, provider);
					}
					return decimal.Parse(text);
				}
				catch (global::System.Exception)
				{
				}
			}
			string text3 = global::Infragistics.Windows.Editors.XamMaskedEditor.GetText(sections, maskInfo.DataMode, maskInfo);
			return decimal.Parse(text3, maskInfo.FormatProvider);
		}

		// Token: 0x06000624 RID: 1572 RVA: 0x0001A30C File Offset: 0x0001850C
		internal static object GetDataValue(global::Infragistics.Windows.Editors.MaskInfo maskInfo)
		{
			global::System.Type dataType = maskInfo.DataType;
			global::Infragistics.Windows.Editors.SectionsCollection sectionsCollection = maskInfo.Sections;
			sectionsCollection = sectionsCollection.Clone(maskInfo, true);
			global::Infragistics.Windows.Editors.XamMaskedEditor.ValidateAllSections(sectionsCollection, true);
			object result;
			try
			{
				if (typeof(global::System.DateTime) == dataType)
				{
					result = global::Infragistics.Windows.Editors.XamMaskedEditor.GetDateTimeValue(sectionsCollection);
				}
				else if (typeof(double) == dataType)
				{
					result = global::Infragistics.Windows.Editors.XamMaskedEditor.GetDoubleValue(sectionsCollection, maskInfo);
				}
				else if (typeof(float) == dataType)
				{
					result = global::Infragistics.Windows.Editors.XamMaskedEditor.GetFloatValue(sectionsCollection, maskInfo);
				}
				else if (typeof(byte) == dataType || typeof(sbyte) == dataType || typeof(short) == dataType || typeof(ushort) == dataType || typeof(short) == dataType || typeof(int) == dataType || typeof(uint) == dataType || typeof(int) == dataType || typeof(long) == dataType || typeof(ulong) == dataType || typeof(long) == dataType)
				{
					result = global::Infragistics.Windows.Editors.XamMaskedEditor.GetWholeNumberValue(sectionsCollection, dataType, maskInfo);
				}
				else if (typeof(decimal) == dataType)
				{
					result = global::Infragistics.Windows.Editors.XamMaskedEditor.GetCurrencyValue(sectionsCollection, maskInfo);
				}
				else if (typeof(string) == dataType)
				{
					result = global::Infragistics.Windows.Editors.XamMaskedEditor.GetText(sectionsCollection, maskInfo.DataMode, maskInfo);
				}
				else
				{
					global::System.ComponentModel.TypeConverter converter = global::System.ComponentModel.TypeDescriptor.GetConverter(dataType);
					if (!converter.CanConvertFrom(typeof(string)))
					{
						throw new global::System.ArgumentException(global::Infragistics.Windows.Editors.ValueEditor.GetString("LE_NotSupportedException_2", new object[]
						{
							dataType.Name
						}), "dataType");
					}
					string text = global::Infragistics.Windows.Editors.XamMaskedEditor.GetText(maskInfo.Sections, maskInfo.DataMode, maskInfo);
					result = converter.ConvertFromString(null, maskInfo.CultureInfo, text);
				}
			}
			catch (global::System.Exception innerException)
			{
				throw new global::System.ArgumentException(global::Infragistics.Windows.Editors.ValueEditor.GetString("LE_ArgumentException_5"), innerException);
			}
			return result;
		}

		// Token: 0x06000625 RID: 1573 RVA: 0x0001A568 File Offset: 0x00018768
		internal static global::Infragistics.Windows.Editors.SectionBase GetSection(global::Infragistics.Windows.Editors.SectionsCollection sections, global::System.Type sectionType)
		{
			int num = 0;
			return global::Infragistics.Windows.Editors.XamMaskedEditor.GetSection(sections, sectionType, ref num);
		}

		// Token: 0x06000626 RID: 1574 RVA: 0x0001A580 File Offset: 0x00018780
		internal static global::Infragistics.Windows.Editors.SectionBase GetSection(global::Infragistics.Windows.Editors.SectionsCollection sections, global::System.Type sectionType, ref int index)
		{
			if (sections == null)
			{
				return null;
			}
			int i = index;
			int count = sections.Count;
			while (i < count)
			{
				global::System.Type type = sections[i].GetType();
				if (sectionType.IsAssignableFrom(type))
				{
					index = 2;
					return sections[i];
				}
				i++;
			}
			return null;
		}

		// Token: 0x06000627 RID: 1575 RVA: 0x0001A5C8 File Offset: 0x000187C8
		internal static bool HasNonDateTimeEditSections(global::Infragistics.Windows.Editors.SectionsCollection sections)
		{
			int i = 0;
			int count = sections.Count;
			while (i < count)
			{
				global::Infragistics.Windows.Editors.EditSectionBase editSectionBase = sections[i] as global::Infragistics.Windows.Editors.EditSectionBase;
				if (editSectionBase != null && !global::Infragistics.Windows.Editors.XamMaskedEditor.IsDateTimeSection(editSectionBase))
				{
					return true;
				}
				i++;
			}
			return false;
		}

		// Token: 0x06000628 RID: 1576 RVA: 0x0001A603 File Offset: 0x00018803
		internal static bool IsDateTimeSection(global::Infragistics.Windows.Editors.EditSectionBase editSection)
		{
			return editSection is global::Infragistics.Windows.Editors.YearSection || editSection is global::Infragistics.Windows.Editors.MonthSection || editSection is global::Infragistics.Windows.Editors.DaySection || editSection is global::Infragistics.Windows.Editors.HourSection || editSection is global::Infragistics.Windows.Editors.MinuteSection || editSection is global::Infragistics.Windows.Editors.SecondSection || editSection is global::Infragistics.Windows.Editors.AMPMSection;
		}

		// Token: 0x06000629 RID: 1577 RVA: 0x0001A640 File Offset: 0x00018840
		private void PadFractionPartHelper(global::Infragistics.Windows.Editors.SectionsCollection sections)
		{
			global::Infragistics.Windows.Editors.FractionPart fractionPart = (global::Infragistics.Windows.Editors.FractionPart)global::Infragistics.Windows.Editors.XamMaskedEditor.GetSection(sections, typeof(global::Infragistics.Windows.Editors.FractionPart));
			if (fractionPart != null)
			{
				if (fractionPart is global::Infragistics.Windows.Editors.FractionPartContinuous || !this.TrimFractionalZeros)
				{
					fractionPart.PadWithZero();
					return;
				}
				if (this.TrimFractionalZeros)
				{
					fractionPart.TrimInsignificantZeros();
				}
			}
		}

		// Token: 0x0600062A RID: 1578 RVA: 0x0001A68C File Offset: 0x0001888C
		internal static void SetDateTimeValue(global::Infragistics.Windows.Editors.SectionsCollection sections, global::System.DateTime date, global::Infragistics.Windows.Editors.MaskInfo maskInfo, bool retainOriginalTime)
		{
			global::System.Globalization.Calendar calendar = sections.Calendar;
			global::Infragistics.Windows.Editors.MonthSection monthSection = (global::Infragistics.Windows.Editors.MonthSection)global::Infragistics.Windows.Editors.XamMaskedEditor.GetSection(sections, typeof(global::Infragistics.Windows.Editors.MonthSection));
			global::Infragistics.Windows.Editors.DaySection daySection = (global::Infragistics.Windows.Editors.DaySection)global::Infragistics.Windows.Editors.XamMaskedEditor.GetSection(sections, typeof(global::Infragistics.Windows.Editors.DaySection));
			global::Infragistics.Windows.Editors.YearSection yearSection = (global::Infragistics.Windows.Editors.YearSection)global::Infragistics.Windows.Editors.XamMaskedEditor.GetSection(sections, typeof(global::Infragistics.Windows.Editors.YearSection));
			global::Infragistics.Windows.Editors.HourSection hourSection = (global::Infragistics.Windows.Editors.HourSection)global::Infragistics.Windows.Editors.XamMaskedEditor.GetSection(sections, typeof(global::Infragistics.Windows.Editors.HourSection));
			global::Infragistics.Windows.Editors.MinuteSection minuteSection = (global::Infragistics.Windows.Editors.MinuteSection)global::Infragistics.Windows.Editors.XamMaskedEditor.GetSection(sections, typeof(global::Infragistics.Windows.Editors.MinuteSection));
			global::Infragistics.Windows.Editors.SecondSection secondSection = (global::Infragistics.Windows.Editors.SecondSection)global::Infragistics.Windows.Editors.XamMaskedEditor.GetSection(sections, typeof(global::Infragistics.Windows.Editors.SecondSection));
			global::Infragistics.Windows.Editors.AMPMSection ampmsection = (global::Infragistics.Windows.Editors.AMPMSection)global::Infragistics.Windows.Editors.XamMaskedEditor.GetSection(sections, typeof(global::Infragistics.Windows.Editors.AMPMSection));
			if (yearSection != null || monthSection != null || daySection != null || hourSection != null || minuteSection != null || secondSection != null)
			{
				if (yearSection != null)
				{
					yearSection.SetText(calendar.GetYear(date).ToString().PadLeft(yearSection.NumberOfDigits, '0'));
				}
				if (monthSection != null)
				{
					monthSection.SetText(calendar.GetMonth(date).ToString().PadLeft(monthSection.NumberOfDigits, '0'));
				}
				if (daySection != null)
				{
					daySection.SetText(calendar.GetDayOfMonth(date).ToString().PadLeft(daySection.NumberOfDigits, '0'));
				}
				if (!retainOriginalTime)
				{
					if (ampmsection != null)
					{
						ampmsection.SetText((date.Hour >= 12) ? ampmsection.PMValue : ampmsection.AMValue);
					}
					if (hourSection != null)
					{
						if (ampmsection != null)
						{
							int num = date.Hour;
							if (num == 0)
							{
								num = 12;
							}
							if (num > 12)
							{
								num -= 12;
							}
							hourSection.SetText(num.ToString());
						}
						else
						{
							hourSection.SetText(date.Hour.ToString());
						}
					}
					if (minuteSection != null)
					{
						minuteSection.SetText(date.Minute.ToString());
					}
					if (secondSection != null)
					{
						secondSection.SetText(date.Second.ToString());
						return;
					}
				}
			}
			else
			{
				if (retainOriginalTime)
				{
					try
					{
						global::System.DateTime dateTimeValue = global::Infragistics.Windows.Editors.XamMaskedEditor.GetDateTimeValue(sections);
						date = date.Date.Add(dateTimeValue.TimeOfDay);
					}
					catch
					{
					}
				}
				global::Infragistics.Windows.Editors.XamMaskedEditor.SetText(sections, date.ToString(maskInfo.Format, maskInfo.FormatProvider), maskInfo);
			}
		}

		// Token: 0x0600062B RID: 1579 RVA: 0x0001A8E0 File Offset: 0x00018AE0
		private static void SetCurrencyValue(global::Infragistics.Windows.Editors.SectionsCollection sections, decimal val, global::Infragistics.Windows.Editors.MaskInfo maskInfo)
		{
			global::Infragistics.Windows.Editors.NumberSection numberSection = (global::Infragistics.Windows.Editors.NumberSection)global::Infragistics.Windows.Editors.XamMaskedEditor.GetSection(sections, typeof(global::Infragistics.Windows.Editors.NumberSection));
			global::Infragistics.Windows.Editors.FractionPart fractionPart = (global::Infragistics.Windows.Editors.FractionPart)global::Infragistics.Windows.Editors.XamMaskedEditor.GetSection(sections, typeof(global::Infragistics.Windows.Editors.FractionPart));
			if (numberSection != null || fractionPart != null)
			{
				global::Infragistics.Windows.Editors.XamMaskedEditor.EraseAllChars(sections);
				val = global::System.Math.Round(val, (fractionPart != null) ? fractionPart.DisplayChars.Count : 0);
				global::Infragistics.Windows.Editors.XamMaskedEditor maskEditor = maskInfo.MaskEditor;
				bool autoExpand = maskEditor != null && string.IsNullOrEmpty(maskEditor.Mask);
				decimal value = 0.0m;
				if (val >= 0.0m)
				{
					decimal num = decimal.Floor(val);
					value = val - num;
					if (numberSection != null)
					{
						numberSection.SetText(num.ToString(), autoExpand);
					}
					if (fractionPart != null)
					{
						fractionPart.SetFractionValue((double)value);
						return;
					}
				}
				else
				{
					decimal num = decimal.Floor(val);
					if (num != val)
					{
						num = ++num;
						value = -val + num;
					}
					if (numberSection != null)
					{
						numberSection.SetText((0.0m == num) ? "-0" : num.ToString(), autoExpand);
					}
					if (fractionPart != null)
					{
						fractionPart.SetFractionValue((double)value);
					}
				}
				return;
			}
			string text = val.ToString(maskInfo.Format, maskInfo.FormatProvider);
			if (text.Length > 2 && text.StartsWith("0."))
			{
				text = text.Remove(0, 1);
			}
			global::Infragistics.Windows.Editors.XamMaskedEditor.SetText(sections, text, maskInfo);
			maskInfo.MaskEditor.PadFractionPartHelper(sections);
		}

		// Token: 0x0600062C RID: 1580 RVA: 0x0001AA68 File Offset: 0x00018C68
		private static void SetDoubleValue(global::Infragistics.Windows.Editors.SectionsCollection sections, double val, global::Infragistics.Windows.Editors.MaskInfo maskInfo)
		{
			global::Infragistics.Windows.Editors.NumberSection numberSection = (global::Infragistics.Windows.Editors.NumberSection)global::Infragistics.Windows.Editors.XamMaskedEditor.GetSection(sections, typeof(global::Infragistics.Windows.Editors.NumberSection));
			global::Infragistics.Windows.Editors.FractionPart fractionPart = (global::Infragistics.Windows.Editors.FractionPart)global::Infragistics.Windows.Editors.XamMaskedEditor.GetSection(sections, typeof(global::Infragistics.Windows.Editors.FractionPart));
			if (numberSection == null && fractionPart == null)
			{
				string text = val.ToString(maskInfo.Format, maskInfo.FormatProvider);
				if (text.Length > 2 && text.StartsWith("0."))
				{
					text = text.Remove(0, 1);
				}
				global::Infragistics.Windows.Editors.XamMaskedEditor.SetText(sections, text, maskInfo);
				maskInfo.MaskEditor.PadFractionPartHelper(sections);
				return;
			}
			global::Infragistics.Windows.Editors.XamMaskedEditor.EraseAllChars(sections);
			if (global::Infragistics.Windows.Editors.Utils.IsInfinityOrNaN(val))
			{
				return;
			}
			val = global::System.Math.Round(val, (fractionPart != null) ? global::System.Math.Min(fractionPart.DisplayChars.Count, 15) : 0);
			global::Infragistics.Windows.Editors.XamMaskedEditor maskEditor = maskInfo.MaskEditor;
			bool autoExpand = maskEditor != null && string.IsNullOrEmpty(maskEditor.Mask);
			double fractionValue = 0.0;
			if (val >= 0.0)
			{
				double num = global::System.Math.Floor(val);
				fractionValue = val - num;
				if (numberSection != null)
				{
					numberSection.SetText(num.ToString("G28"), autoExpand);
				}
				if (fractionPart != null)
				{
					fractionPart.SetFractionValue(fractionValue);
					return;
				}
			}
			else
			{
				double num = global::System.Math.Floor(val);
				if (num != val)
				{
					num += 1.0;
					fractionValue = -val + num;
				}
				if (numberSection != null)
				{
					numberSection.SetText((0.0 == num) ? "-0" : num.ToString(), autoExpand);
				}
				if (fractionPart != null)
				{
					fractionPart.SetFractionValue(fractionValue);
				}
			}
		}

		// Token: 0x0600062D RID: 1581 RVA: 0x0001ABE2 File Offset: 0x00018DE2
		private static void SetFloatValue(global::Infragistics.Windows.Editors.SectionsCollection sections, float val, global::Infragistics.Windows.Editors.MaskInfo maskInfo)
		{
			global::Infragistics.Windows.Editors.XamMaskedEditor.SetDoubleValue(sections, (double)val, maskInfo);
		}

		// Token: 0x0600062E RID: 1582 RVA: 0x0001ABF0 File Offset: 0x00018DF0
		internal static bool SetDataValue(global::Infragistics.Windows.Editors.SectionsCollection sections, global::System.Type dataType, object val, global::Infragistics.Windows.Editors.MaskInfo maskInfo)
		{
			bool result;
			try
			{
				dataType = global::Infragistics.CoreUtilities.GetUnderlyingType(dataType);
				result = global::Infragistics.Windows.Editors.XamMaskedEditor.SetDataValueHelper(sections, dataType, val, maskInfo);
			}
			finally
			{
				global::Infragistics.Windows.Editors.XamMaskedEditor.ValidateAllSections(sections);
			}
			return result;
		}

		// Token: 0x0600062F RID: 1583 RVA: 0x0001AC2C File Offset: 0x00018E2C
		internal static bool SetDataValueHelper(global::Infragistics.Windows.Editors.SectionsCollection sections, global::System.Type dataType, object val, global::Infragistics.Windows.Editors.MaskInfo maskInfo)
		{
			if (val == null || val is global::System.DBNull)
			{
				global::Infragistics.Windows.Editors.XamMaskedEditor.SetText(sections, "", maskInfo);
				return true;
			}
			if (!global::Infragistics.Windows.Editors.XamMaskedEditor.SupportsDataType(dataType))
			{
				throw new global::System.ArgumentException(global::Infragistics.Windows.Editors.ValueEditor.GetString("LE_NotSupportedException_2", new object[]
				{
					dataType.Name
				}), "dataType");
			}
			if (val.GetType() != dataType)
			{
				val = global::Infragistics.CoreUtilities.ConvertDataValue(val, dataType, maskInfo.FormatProvider, maskInfo.Format);
			}
			bool result = true;
			if (typeof(global::System.DateTime) == dataType)
			{
				global::Infragistics.Windows.Editors.XamMaskedEditor.SetDateTimeValue(sections, (global::System.DateTime)val, maskInfo, false);
			}
			else if (typeof(decimal) == dataType)
			{
				global::Infragistics.Windows.Editors.XamMaskedEditor.SetCurrencyValue(sections, (decimal)val, maskInfo);
			}
			else if (typeof(double) == dataType)
			{
				global::Infragistics.Windows.Editors.XamMaskedEditor.SetDoubleValue(sections, (double)val, maskInfo);
			}
			else if (typeof(float) == dataType)
			{
				global::Infragistics.Windows.Editors.XamMaskedEditor.SetFloatValue(sections, (float)val, maskInfo);
			}
			else if (typeof(string) == dataType)
			{
				string text = (string)val;
				int num = global::Infragistics.Windows.Editors.XamMaskedEditor.SetText(sections, text, maskInfo);
				if (text != null && num < text.Length)
				{
					return false;
				}
			}
			else if (typeof(byte) == dataType || typeof(sbyte) == dataType || typeof(short) == dataType || typeof(ushort) == dataType || typeof(short) == dataType || typeof(int) == dataType || typeof(uint) == dataType || typeof(int) == dataType || typeof(long) == dataType || typeof(ulong) == dataType || typeof(long) == dataType)
			{
				string text2 = val.ToString();
				int num2 = global::Infragistics.Windows.Editors.XamMaskedEditor.SetText(sections, text2, maskInfo);
				if (text2 != null && num2 < text2.Length)
				{
					result = false;
				}
			}
			else
			{
				global::System.ComponentModel.TypeConverter converter = global::System.ComponentModel.TypeDescriptor.GetConverter(dataType);
				if (converter == null || !converter.CanConvertTo(typeof(string)))
				{
					throw new global::System.ArgumentException(global::Infragistics.Windows.Editors.ValueEditor.GetString("LE_NotSupportedException_2", new object[]
					{
						dataType.Name
					}), "dataType");
				}
				string text3 = converter.ConvertToString(null, maskInfo.CultureInfo, val);
				int num3 = global::Infragistics.Windows.Editors.XamMaskedEditor.SetText(sections, text3, maskInfo.PromptChar, maskInfo.PadChar, false);
				if (text3 != null && num3 < text3.Length)
				{
					result = false;
				}
			}
			return result;
		}

		// Token: 0x06000630 RID: 1584 RVA: 0x0001AEEE File Offset: 0x000190EE
		internal static bool ValidateAllSections(global::Infragistics.Windows.Editors.SectionsCollection sections)
		{
			return global::Infragistics.Windows.Editors.XamMaskedEditor.ValidateAllSections(sections, false);
		}

		// Token: 0x06000631 RID: 1585 RVA: 0x0001AEF8 File Offset: 0x000190F8
		internal bool IsInputValid(global::Infragistics.Windows.Editors.SectionsCollection sections, out string maskValidationErrorMessage)
		{
			maskValidationErrorMessage = null;
			if (base.IsNullable && global::Infragistics.Windows.Editors.XamMaskedEditor.AreAllDisplayCharsEmpty(sections))
			{
				return true;
			}
			sections = sections.Clone(sections.MaskInfo, true);
			global::Infragistics.Windows.Editors.XamMaskedEditor.ValidateAllSections(sections, true);
			int i = 0;
			while (i < sections.Count)
			{
				global::Infragistics.Windows.Editors.EditSectionBase editSectionBase = sections[i] as global::Infragistics.Windows.Editors.EditSectionBase;
				if (editSectionBase == null || !(typeof(global::Infragistics.Windows.Editors.NumberSection) == editSectionBase.GetType()))
				{
					goto IL_82;
				}
				global::Infragistics.Windows.Editors.NumberSection numberSection = (global::Infragistics.Windows.Editors.NumberSection)editSectionBase;
				string text = numberSection.GetText(global::Infragistics.Windows.Editors.MaskMode.Raw);
				string text2;
				if (!numberSection.ValidateAgainstMinMaxHelper(text, out text2))
				{
					maskValidationErrorMessage = text2;
					return false;
				}
				if (text != null && text.Length != 0)
				{
					goto IL_82;
				}
				IL_9C:
				i++;
				continue;
				IL_82:
				if (editSectionBase != null && !editSectionBase.ValidateSection(false))
				{
					maskValidationErrorMessage = global::Infragistics.Windows.Editors.ValueEditor.GetString("MaskValidationErrorInputDoesNotMatchMask");
					return false;
				}
				goto IL_9C;
			}
			global::Infragistics.Windows.Editors.MonthSection monthSection = global::Infragistics.Windows.Editors.XamMaskedEditor.GetSection(sections, typeof(global::Infragistics.Windows.Editors.MonthSection)) as global::Infragistics.Windows.Editors.MonthSection;
			global::Infragistics.Windows.Editors.DaySection daySection = global::Infragistics.Windows.Editors.XamMaskedEditor.GetSection(sections, typeof(global::Infragistics.Windows.Editors.DaySection)) as global::Infragistics.Windows.Editors.DaySection;
			global::Infragistics.Windows.Editors.YearSection yearSection = global::Infragistics.Windows.Editors.XamMaskedEditor.GetSection(sections, typeof(global::Infragistics.Windows.Editors.YearSection)) as global::Infragistics.Windows.Editors.YearSection;
			if (monthSection != null && daySection != null)
			{
				int num = monthSection.ToInt();
				int num2 = daySection.ToInt();
				if (2 == num && num2 > 29)
				{
					maskValidationErrorMessage = global::Infragistics.Windows.Editors.ValueEditor.GetString("MaskValidationErrorInvalidDate");
					return false;
				}
				int num3 = 30 + (num + ((num >= 8) ? 1 : 0)) % 2;
				if (num2 > num3)
				{
					maskValidationErrorMessage = global::Infragistics.Windows.Editors.ValueEditor.GetString("MaskValidationErrorInvalidDayOfMonth");
					return false;
				}
				if (yearSection != null)
				{
					int year = yearSection.GetYear();
					global::System.Globalization.Calendar calendar = sections.Calendar;
					if (num2 > calendar.GetDaysInMonth(year, num))
					{
						maskValidationErrorMessage = global::Infragistics.Windows.Editors.ValueEditor.GetString("MaskValidationErrorInvalidDayOfMonth");
						return false;
					}
				}
			}
			maskValidationErrorMessage = null;
			return true;
		}

		// Token: 0x06000632 RID: 1586 RVA: 0x0001B08C File Offset: 0x0001928C
		internal static bool ValidateAllSections(global::Infragistics.Windows.Editors.SectionsCollection sections, bool loosingFocus)
		{
			bool flag = true;
			for (int i = 0; i < sections.Count; i++)
			{
				global::Infragistics.Windows.Editors.EditSectionBase editSectionBase = sections[i] as global::Infragistics.Windows.Editors.EditSectionBase;
				if (editSectionBase != null)
				{
					flag = (flag && editSectionBase.ValidateSection());
				}
				if (editSectionBase is global::Infragistics.Windows.Editors.FractionPart)
				{
					global::Infragistics.Windows.Editors.NumberSection numberSection = editSectionBase.PreviousEditSection as global::Infragistics.Windows.Editors.NumberSection;
					bool flag2 = false;
					if (numberSection != null)
					{
						string text = numberSection.GetText(global::Infragistics.Windows.Editors.MaskMode.Raw);
						if (text != null && text.Length > 0)
						{
							flag2 = true;
						}
					}
					if (!flag2)
					{
						string text2 = editSectionBase.GetText(global::Infragistics.Windows.Editors.MaskMode.Raw);
						if (text2 != null && text2.Length > 0)
						{
							flag2 = true;
						}
					}
					if (flag2 && sections.MaskedEditor != null)
					{
						sections.MaskedEditor.PadFractionPartHelper(sections);
					}
				}
			}
			if (loosingFocus)
			{
				global::Infragistics.Windows.Editors.AutoFillDate autoFillDate = sections.MaskedEditor.AutoFillDate;
				global::System.DateTime now = global::System.DateTime.Now;
				global::System.Globalization.Calendar calendar = sections.Calendar;
				global::Infragistics.Windows.Editors.MonthSection monthSection = (global::Infragistics.Windows.Editors.MonthSection)global::Infragistics.Windows.Editors.XamMaskedEditor.GetSection(sections, typeof(global::Infragistics.Windows.Editors.MonthSection));
				global::Infragistics.Windows.Editors.DaySection daySection = (global::Infragistics.Windows.Editors.DaySection)global::Infragistics.Windows.Editors.XamMaskedEditor.GetSection(sections, typeof(global::Infragistics.Windows.Editors.DaySection));
				global::Infragistics.Windows.Editors.YearSection yearSection = (global::Infragistics.Windows.Editors.YearSection)global::Infragistics.Windows.Editors.XamMaskedEditor.GetSection(sections, typeof(global::Infragistics.Windows.Editors.YearSection));
				if (monthSection != null && monthSection.IsEmpty && daySection != null && !daySection.IsEmpty && global::Infragistics.Windows.Editors.AutoFillDate.MonthAndYear == autoFillDate)
				{
					monthSection.SetText(calendar.GetMonth(now).ToString());
				}
				if (yearSection != null && yearSection.IsEmpty && monthSection != null && !monthSection.IsEmpty && (daySection == null || !daySection.IsEmpty) && (global::Infragistics.Windows.Editors.AutoFillDate.Year == autoFillDate || global::Infragistics.Windows.Editors.AutoFillDate.MonthAndYear == autoFillDate))
				{
					yearSection.SetText(calendar.GetYear(now).ToString());
				}
			}
			if (flag && loosingFocus && sections.MaskInfo != null && sections.MaskedEditor != null)
			{
				try
				{
					global::Infragistics.Windows.Editors.AMPMSection ampmsection = (global::Infragistics.Windows.Editors.AMPMSection)global::Infragistics.Windows.Editors.XamMaskedEditor.GetSection(sections, typeof(global::Infragistics.Windows.Editors.AMPMSection));
					global::Infragistics.Windows.Editors.HourSection hourSection = (global::Infragistics.Windows.Editors.HourSection)global::Infragistics.Windows.Editors.XamMaskedEditor.GetSection(sections, typeof(global::Infragistics.Windows.Editors.HourSection));
					if (ampmsection != null && hourSection != null && ampmsection.IsEmpty && !hourSection.IsEmpty)
					{
						int num = hourSection.ToInt();
						if (num >= 12)
						{
							ampmsection.SetText(ampmsection.PMValue);
						}
						else
						{
							ampmsection.SetText(ampmsection.AMValue);
						}
					}
				}
				catch
				{
				}
			}
			return flag;
		}

		// Token: 0x06000633 RID: 1587 RVA: 0x0001B2CC File Offset: 0x000194CC
		internal static global::System.Type DeduceEditAsType(global::Infragistics.Windows.Editors.SectionsCollection sections)
		{
			bool flag;
			bool flag2;
			return global::Infragistics.Windows.Editors.XamMaskedEditor.DeduceEditAsType(sections, out flag, out flag2);
		}

		// Token: 0x06000634 RID: 1588 RVA: 0x0001B2E4 File Offset: 0x000194E4
		internal static global::System.Type DeduceEditAsType(global::Infragistics.Windows.Editors.SectionsCollection sections, out bool hasDateComponents, out bool hasTimeComponents)
		{
			global::System.Type type = null;
			hasDateComponents = (hasTimeComponents = false);
			try
			{
				global::Infragistics.Windows.Editors.MonthSection monthSection = (global::Infragistics.Windows.Editors.MonthSection)global::Infragistics.Windows.Editors.XamMaskedEditor.GetSection(sections, typeof(global::Infragistics.Windows.Editors.MonthSection));
				global::Infragistics.Windows.Editors.DaySection daySection = (global::Infragistics.Windows.Editors.DaySection)global::Infragistics.Windows.Editors.XamMaskedEditor.GetSection(sections, typeof(global::Infragistics.Windows.Editors.DaySection));
				global::Infragistics.Windows.Editors.YearSection yearSection = (global::Infragistics.Windows.Editors.YearSection)global::Infragistics.Windows.Editors.XamMaskedEditor.GetSection(sections, typeof(global::Infragistics.Windows.Editors.YearSection));
				global::Infragistics.Windows.Editors.HourSection hourSection = (global::Infragistics.Windows.Editors.HourSection)global::Infragistics.Windows.Editors.XamMaskedEditor.GetSection(sections, typeof(global::Infragistics.Windows.Editors.HourSection));
				global::Infragistics.Windows.Editors.MinuteSection minuteSection = (global::Infragistics.Windows.Editors.MinuteSection)global::Infragistics.Windows.Editors.XamMaskedEditor.GetSection(sections, typeof(global::Infragistics.Windows.Editors.MinuteSection));
				global::Infragistics.Windows.Editors.SecondSection secondSection = (global::Infragistics.Windows.Editors.SecondSection)global::Infragistics.Windows.Editors.XamMaskedEditor.GetSection(sections, typeof(global::Infragistics.Windows.Editors.SecondSection));
				hasDateComponents = ((monthSection != null && daySection != null) || (monthSection != null && null != yearSection));
				hasTimeComponents = (hourSection != null && null != minuteSection);
				if (hasDateComponents || hasTimeComponents)
				{
					type = typeof(global::System.DateTime);
				}
				if (null == type)
				{
					bool flag = false;
					bool flag2 = false;
					bool flag3 = false;
					int i = 0;
					int count = sections.Count;
					while (i < count)
					{
						if (sections[i] is global::Infragistics.Windows.Editors.NumberSection || (flag3 && sections[i] is global::Infragistics.Windows.Editors.FractionPart))
						{
							if (!flag3)
							{
								if (flag)
								{
									flag = false;
									flag2 = false;
									break;
								}
								flag = true;
							}
							else
							{
								if (flag2)
								{
									flag = false;
									flag2 = false;
									break;
								}
								flag2 = true;
							}
						}
						else if (sections[i] is global::Infragistics.Windows.Editors.LiteralSection && 1 == sections[i].DisplayChars.Count)
						{
							if (sections[i].DecimalSeperatorChar == sections[i].DisplayChars[0].Char)
							{
								if (flag3)
								{
									flag = false;
									flag2 = false;
									break;
								}
								flag3 = true;
							}
							else if (sections[i].CommaChar != sections[i].DisplayChars[0].Char && flag)
							{
								flag = false;
								flag2 = false;
								break;
							}
						}
						else
						{
							if (flag || flag3)
							{
								flag = false;
								flag2 = false;
								break;
							}
							if (!(sections[i] is global::Infragistics.Windows.Editors.LiteralSection))
							{
								flag = false;
								flag2 = false;
								break;
							}
						}
						i++;
					}
					if (flag && flag2)
					{
						type = typeof(decimal);
					}
					else if (flag)
					{
						type = typeof(int);
					}
				}
				if (null == type && sections.Count > 0)
				{
					type = typeof(string);
				}
			}
			catch (global::System.Exception)
			{
			}
			return type;
		}

		// Token: 0x06000635 RID: 1589 RVA: 0x0001B564 File Offset: 0x00019764
		protected override void OnIsKeyboardFocusWithinChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			base.OnIsKeyboardFocusWithinChanged(e);
			bool focused = (bool)e.NewValue;
			this.ProcessIsBeingEditedAndFocusedChanged(focused);
		}

		// Token: 0x06000636 RID: 1590 RVA: 0x0001B58C File Offset: 0x0001978C
		internal void ProcessIsBeingEditedAndFocusedChanged()
		{
			global::Infragistics.Windows.Editors.MaskInfo maskInfo = this.MaskInfo;
			bool focused = maskInfo != null && maskInfo.IsBeingEditedAndFocused;
			this.ProcessIsBeingEditedAndFocusedChanged(focused);
		}

		// Token: 0x06000637 RID: 1591 RVA: 0x0001B5B4 File Offset: 0x000197B4
		private void ProcessIsBeingEditedAndFocusedChanged(bool focused)
		{
			if (base.IsInEditMode && this.EditInfo != null)
			{
				this.EditInfo.HookUnhookInputMethodHelper(focused);
				global::Infragistics.Windows.Editors.SectionsCollection sections = this.MaskInfo.Sections;
				if (sections != null)
				{
					foreach (global::Infragistics.Windows.Editors.SectionBase sectionBase in sections)
					{
						foreach (global::Infragistics.Windows.Editors.DisplayCharBase displayCharBase in sectionBase.DisplayChars)
						{
							displayCharBase.NotifyPropertyChangedEvent(global::Infragistics.Windows.Editors.DisplayCharBase.PROPERTY_DRAWSTRING);
							displayCharBase.NotifyPropertyChangedEvent(global::Infragistics.Windows.Editors.DisplayCharBase.PROPERTY_VISIBILITY);
							displayCharBase.NotifyPropertyChangedEvent(global::Infragistics.Windows.Editors.DisplayCharBase.PROPERTY_DRAWSELECTED);
						}
					}
					this.SyncDrawAsSelectedOnDisplayPresenters();
				}
				if (focused && this.HasOpenDropDown)
				{
					focused = false;
				}
				if (!focused)
				{
					if (this.EditInfo != null)
					{
						this.EditInfo.ValidateAllSections(true);
						this.EditInfo.EnsureMaskEditAreaFilled();
					}
					this.ShowHideCaretHelper();
					return;
				}
				this.ShowHideCaretHelper();
				if (base.IsInEditMode && this.EditInfo != null)
				{
					this.EditInfo.ScrollDisplayCharIntoView(this.EditInfo.CaretPosition);
					return;
				}
			}
			else
			{
				this.ShowHideCaretHelper();
			}
		}

		// Token: 0x06000638 RID: 1592 RVA: 0x0001B6F4 File Offset: 0x000198F4
		internal void OnInvalidOperation(global::Infragistics.Windows.Editors.Events.InvalidOperationEventArgs e)
		{
		}

		// Token: 0x06000639 RID: 1593 RVA: 0x0001B6F6 File Offset: 0x000198F6
		internal void OnInvalidChar(global::Infragistics.Windows.Editors.Events.InvalidCharEventArgs e)
		{
			if (this.InvalidChar == null)
			{
				return;
			}
			this.InvalidChar(this, e);
		}

		// Token: 0x0600063A RID: 1594 RVA: 0x0001B70E File Offset: 0x0001990E
		internal void EnsureInEditMode()
		{
			if (!base.IsInEditMode)
			{
				throw new global::System.InvalidOperationException(global::Infragistics.Windows.Editors.ValueEditor.GetString("LE_InvalidOperationException_10"));
			}
		}

		// Token: 0x0600063B RID: 1595 RVA: 0x0001B728 File Offset: 0x00019928
		internal void VerifyElementsPositioned()
		{
			base.UpdateLayout();
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x0600063C RID: 1596 RVA: 0x0001B730 File Offset: 0x00019930
		internal static global::System.Globalization.CultureInfo DefaultCultureInfo
		{
			get
			{
				if (global::Infragistics.Windows.Editors.XamMaskedEditor.s_defaultCultureInfo == null)
				{
					global::Infragistics.Windows.Editors.XamMaskedEditor.s_defaultCultureInfo = global::System.Globalization.CultureInfo.CurrentCulture;
				}
				return global::Infragistics.Windows.Editors.XamMaskedEditor.s_defaultCultureInfo;
			}
		}

		// Token: 0x0600063D RID: 1597 RVA: 0x0001B748 File Offset: 0x00019948
		internal static global::System.Globalization.NumberFormatInfo GetNumberFormatInfo(global::System.IFormatProvider formatProvider)
		{
			global::System.Globalization.NumberFormatInfo numberFormatInfo = formatProvider as global::System.Globalization.NumberFormatInfo;
			if (numberFormatInfo == null && formatProvider != null)
			{
				numberFormatInfo = (global::System.Globalization.NumberFormatInfo)formatProvider.GetFormat(typeof(global::System.Globalization.NumberFormatInfo));
			}
			if (numberFormatInfo == null)
			{
				global::System.Globalization.CultureInfo defaultCultureInfo = global::Infragistics.Windows.Editors.XamMaskedEditor.DefaultCultureInfo;
				if (defaultCultureInfo != null)
				{
					numberFormatInfo = defaultCultureInfo.NumberFormat;
				}
			}
			return numberFormatInfo;
		}

		// Token: 0x0600063E RID: 1598 RVA: 0x0001B78C File Offset: 0x0001998C
		internal static global::System.Globalization.DateTimeFormatInfo GetDateTimeFormatInfo(global::System.IFormatProvider formatProvider)
		{
			global::System.Globalization.DateTimeFormatInfo dateTimeFormatInfo = formatProvider as global::System.Globalization.DateTimeFormatInfo;
			if (dateTimeFormatInfo == null && formatProvider != null)
			{
				dateTimeFormatInfo = (global::System.Globalization.DateTimeFormatInfo)formatProvider.GetFormat(typeof(global::System.Globalization.DateTimeFormatInfo));
			}
			if (dateTimeFormatInfo == null && global::Infragistics.Windows.Editors.XamMaskedEditor.DefaultCultureInfo != null)
			{
				dateTimeFormatInfo = global::Infragistics.Windows.Editors.XamMaskedEditor.DefaultCultureInfo.DateTimeFormat;
			}
			return dateTimeFormatInfo;
		}

		// Token: 0x0600063F RID: 1599 RVA: 0x0001B7D4 File Offset: 0x000199D4
		internal void NotifyDisplayCharDrawStringsChanged()
		{
			global::Infragistics.Windows.Editors.SectionsCollection sections = this.Sections;
			global::Infragistics.Windows.Editors.XamMaskedEditor.NotifyPropertyOnDisplayCharacters(sections, global::Infragistics.Windows.Editors.DisplayCharBase.PROPERTY_DRAWSTRING);
		}

		// Token: 0x06000640 RID: 1600 RVA: 0x0001B7F4 File Offset: 0x000199F4
		internal static void NotifyPropertyOnDisplayCharacters(global::Infragistics.Windows.Editors.SectionsCollection sections, string propertyName)
		{
			if (sections != null)
			{
				foreach (object obj in sections.AllDisplayCharacters)
				{
					global::Infragistics.Windows.Editors.DisplayCharBase displayCharBase = (global::Infragistics.Windows.Editors.DisplayCharBase)obj;
					displayCharBase.NotifyPropertyChangedEvent(propertyName);
				}
			}
		}

		// Token: 0x06000641 RID: 1601 RVA: 0x0001B850 File Offset: 0x00019A50
		internal static void NotifyPropertyOnDisplayCharacters(global::Infragistics.Windows.Editors.SectionBase section, string propertyName)
		{
			if (section != null)
			{
				global::Infragistics.Windows.Editors.DisplayCharsCollection displayChars = section.DisplayChars;
				if (displayChars != null)
				{
					int i = 0;
					int count = displayChars.Count;
					while (i < count)
					{
						global::Infragistics.Windows.Editors.DisplayCharBase displayCharBase = displayChars[i];
						displayCharBase.NotifyPropertyChangedEvent(propertyName);
						i++;
					}
				}
			}
		}

		// Token: 0x06000642 RID: 1602 RVA: 0x0001B88C File Offset: 0x00019A8C
		internal static global::System.Globalization.Calendar GetCultureCalendar(global::System.IFormatProvider formatProvider)
		{
			global::System.Globalization.DateTimeFormatInfo dateTimeFormatInfo = global::Infragistics.Windows.Editors.XamMaskedEditor.GetDateTimeFormatInfo(formatProvider);
			return dateTimeFormatInfo.Calendar;
		}

		// Token: 0x06000643 RID: 1603 RVA: 0x0001B8A6 File Offset: 0x00019AA6
		internal static char GetCultureChar(char c, global::System.IFormatProvider formatProvider)
		{
			return global::Infragistics.Windows.Editors.XamMaskedEditor.GetCultureChar(c, formatProvider, false);
		}

		// Token: 0x06000644 RID: 1604 RVA: 0x0001B8B0 File Offset: 0x00019AB0
		internal static char GetCultureChar(char c, global::Infragistics.Windows.Editors.MaskInfo maskInfo)
		{
			bool useCurrencySymbols = maskInfo != null && typeof(decimal) == maskInfo.DataType;
			return global::Infragistics.Windows.Editors.XamMaskedEditor.GetCultureChar(c, (maskInfo != null) ? maskInfo.FormatProvider : null, useCurrencySymbols);
		}

		// Token: 0x06000645 RID: 1605 RVA: 0x0001B8EC File Offset: 0x00019AEC
		internal static char GetCultureChar(char c, global::System.IFormatProvider formatProvider, bool useCurrencySymbols)
		{
			global::System.Globalization.NumberFormatInfo numberFormatInfo = global::Infragistics.Windows.Editors.XamMaskedEditor.GetNumberFormatInfo(formatProvider);
			global::System.Globalization.DateTimeFormatInfo dateTimeFormatInfo = global::Infragistics.Windows.Editors.XamMaskedEditor.GetDateTimeFormatInfo(formatProvider);
			string text = null;
			if (c != '$')
			{
				switch (c)
				{
				case '+':
					text = numberFormatInfo.PositiveSign;
					break;
				case ',':
					if (!useCurrencySymbols)
					{
						text = numberFormatInfo.NumberGroupSeparator;
					}
					else
					{
						text = numberFormatInfo.CurrencyGroupSeparator;
					}
					break;
				case '-':
					text = numberFormatInfo.NegativeSign;
					break;
				case '.':
					if (!useCurrencySymbols)
					{
						text = numberFormatInfo.NumberDecimalSeparator;
					}
					else
					{
						text = numberFormatInfo.CurrencyDecimalSeparator;
					}
					break;
				case '/':
					text = dateTimeFormatInfo.DateSeparator;
					break;
				default:
					if (c == ':')
					{
						text = dateTimeFormatInfo.TimeSeparator;
					}
					break;
				}
			}
			else
			{
				text = numberFormatInfo.CurrencySymbol;
			}
			if (text == null || text.Length <= 0)
			{
				return c;
			}
			return text[0];
		}

		// Token: 0x06000646 RID: 1606 RVA: 0x0001B99E File Offset: 0x00019B9E
		private static char GetChar(string value, int position)
		{
			if (value == null || value.Length <= position)
			{
				return '\0';
			}
			return value[position];
		}

		// Token: 0x06000647 RID: 1607 RVA: 0x0001B9B8 File Offset: 0x00019BB8
		internal static int GetNumberSectionCount(global::Infragistics.Windows.Editors.SectionsCollection sections)
		{
			int num = 0;
			foreach (global::Infragistics.Windows.Editors.SectionBase section in sections)
			{
				if (global::Infragistics.Windows.Editors.XamMaskedEditor.IsSectionNumeric(section))
				{
					num++;
				}
			}
			return num;
		}

		// Token: 0x06000648 RID: 1608 RVA: 0x0001BA08 File Offset: 0x00019C08
		internal static string GetCultureAMPMDesignator(bool am, global::System.IFormatProvider formatProvider)
		{
			global::System.Globalization.DateTimeFormatInfo dateTimeFormatInfo = global::Infragistics.Windows.Editors.XamMaskedEditor.GetDateTimeFormatInfo(formatProvider);
			if (!am)
			{
				return dateTimeFormatInfo.PMDesignator;
			}
			return dateTimeFormatInfo.AMDesignator;
		}

		// Token: 0x06000649 RID: 1609 RVA: 0x0001BA2C File Offset: 0x00019C2C
		internal void IllegalOperation(string message)
		{
			global::Infragistics.Windows.Editors.Events.InvalidOperationEventArgs invalidOperationEventArgs = new global::Infragistics.Windows.Editors.Events.InvalidOperationEventArgs(message);
			this.OnInvalidOperation(invalidOperationEventArgs);
			if (invalidOperationEventArgs.Beep)
			{
				this.Beep();
			}
		}

		// Token: 0x0600064A RID: 1610 RVA: 0x0001BA58 File Offset: 0x00019C58
		private void UpdateSpinButtonVisibility()
		{
			bool flag = false;
			if (!base.IsReadOnly)
			{
				switch (this.SpinButtonDisplayMode)
				{
				case global::Infragistics.Windows.Editors.SpinButtonDisplayMode.Always:
					flag = true;
					break;
				case global::Infragistics.Windows.Editors.SpinButtonDisplayMode.MouseOver:
					flag = (base.IsInEditMode || base.IsMouseOver);
					break;
				case global::Infragistics.Windows.Editors.SpinButtonDisplayMode.Focused:
					flag = (base.IsInEditMode || base.IsFocusWithin);
					break;
				case global::Infragistics.Windows.Editors.SpinButtonDisplayMode.OnlyInEditMode:
					flag = base.IsInEditMode;
					break;
				}
			}
			base.SetValue(global::Infragistics.Windows.Editors.XamMaskedEditor.SpinButtonVisibilityResolvedPropertyKey, flag ? global::Infragistics.KnownBoxes.VisibilityVisibleBox : global::Infragistics.KnownBoxes.VisibilityCollapsedBox);
		}

		// Token: 0x0600064B RID: 1611 RVA: 0x0001BAE4 File Offset: 0x00019CE4
		private bool TryFastSyncOnValueChanged(object newValue, out global::System.Exception error)
		{
			error = null;
			global::Infragistics.Windows.Editors.MaskInfo maskInfo = this.MaskInfo;
			global::System.Type defaultTypeForSyncTextFromValue = maskInfo.GetDefaultTypeForSyncTextFromValue(newValue);
			if (defaultTypeForSyncTextFromValue == null)
			{
				return false;
			}
			base.BeginSyncValueProperties();
			bool result;
			try
			{
				bool flag = base.ValueToTextConverterResolved is global::Infragistics.Windows.Editors.MaskedEditorDefaultConverter;
				string value = null;
				if (flag || base.ConvertValueToText(newValue, out value, out error))
				{
					global::Infragistics.Windows.Editors.XamMaskedEditor.SetDataValueHelper(maskInfo.Sections, defaultTypeForSyncTextFromValue, newValue, maskInfo);
					if (flag)
					{
						value = global::Infragistics.Windows.Editors.XamMaskedEditor.GetText(maskInfo.Sections, maskInfo.DataMode, maskInfo);
					}
					base.SetValue(global::Infragistics.Windows.Editors.ValueEditor.TextProperty, value);
					if (string.IsNullOrEmpty(maskInfo.Format) && base.ValueToDisplayTextConverterResolved is global::Infragistics.Windows.Editors.MaskedEditorDefaultConverter)
					{
						global::Infragistics.Windows.Editors.XamMaskedEditor.GetText(maskInfo.Sections, maskInfo.DisplayMode, maskInfo);
						base.SetValue(global::Infragistics.Windows.Editors.TextEditorBase.DisplayTextPropertyKey, value);
					}
					else
					{
						base.SyncDisplayText();
					}
					this._skipNextMaskValidation = true;
					result = true;
				}
				else
				{
					base.SetIsValueValid(false, error);
					result = false;
				}
			}
			catch
			{
				result = false;
			}
			finally
			{
				base.EndSyncValueProperties();
			}
			return result;
		}

		// Token: 0x0600064C RID: 1612 RVA: 0x0001BBEC File Offset: 0x00019DEC
		private static void OnTrimFractionalZerosChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Editors.XamMaskedEditor xamMaskedEditor = (global::Infragistics.Windows.Editors.XamMaskedEditor)d;
			xamMaskedEditor._cachedTrimFractionalZeros = (bool)e.NewValue;
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x0600064D RID: 1613 RVA: 0x0001BC12 File Offset: 0x00019E12
		// (set) Token: 0x0600064E RID: 1614 RVA: 0x0001BC1A File Offset: 0x00019E1A
		public bool TrimFractionalZeros
		{
			get
			{
				return this._cachedTrimFractionalZeros;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.XamMaskedEditor.TrimFractionalZerosProperty, value);
			}
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x0600064F RID: 1615 RVA: 0x0001BC2D File Offset: 0x00019E2D
		// (set) Token: 0x06000650 RID: 1616 RVA: 0x0001BC3F File Offset: 0x00019E3F
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.Editors.SpinButtonDisplayMode SpinButtonDisplayMode
		{
			get
			{
				return (global::Infragistics.Windows.Editors.SpinButtonDisplayMode)base.GetValue(global::Infragistics.Windows.Editors.XamMaskedEditor.SpinButtonDisplayModeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.XamMaskedEditor.SpinButtonDisplayModeProperty, value);
			}
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x06000651 RID: 1617 RVA: 0x0001BC52 File Offset: 0x00019E52
		// (set) Token: 0x06000652 RID: 1618 RVA: 0x0001BC64 File Offset: 0x00019E64
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Style SpinButtonStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Windows.Editors.XamMaskedEditor.SpinButtonStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.XamMaskedEditor.SpinButtonStyleProperty, value);
			}
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x06000653 RID: 1619 RVA: 0x0001BC72 File Offset: 0x00019E72
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		public global::System.Windows.Visibility SpinButtonVisibilityResolved
		{
			get
			{
				return (global::System.Windows.Visibility)base.GetValue(global::Infragistics.Windows.Editors.XamMaskedEditor.SpinButtonVisibilityResolvedProperty);
			}
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x06000654 RID: 1620 RVA: 0x0001BC84 File Offset: 0x00019E84
		// (set) Token: 0x06000655 RID: 1621 RVA: 0x0001BC91 File Offset: 0x00019E91
		[global::System.ComponentModel.Bindable(true)]
		public object SpinIncrement
		{
			get
			{
				return base.GetValue(global::Infragistics.Windows.Editors.XamMaskedEditor.SpinIncrementProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.XamMaskedEditor.SpinIncrementProperty, value);
			}
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x06000656 RID: 1622 RVA: 0x0001BC9F File Offset: 0x00019E9F
		internal bool HasSpinIncrement
		{
			get
			{
				return null != this.SpinIncrement;
			}
		}

		// Token: 0x06000657 RID: 1623 RVA: 0x0001BCB0 File Offset: 0x00019EB0
		private static void OnSpinIncrementChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Editors.XamMaskedEditor xamMaskedEditor = (global::Infragistics.Windows.Editors.XamMaskedEditor)dependencyObject;
			object newValue = e.NewValue;
			xamMaskedEditor._cachedSpinInfo = ((newValue != null) ? global::Infragistics.Windows.Editors.SpinInfo.Parse(xamMaskedEditor, newValue) : null);
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x06000658 RID: 1624 RVA: 0x0001BCDF File Offset: 0x00019EDF
		// (set) Token: 0x06000659 RID: 1625 RVA: 0x0001BCF1 File Offset: 0x00019EF1
		public bool SpinWrap
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.Editors.XamMaskedEditor.SpinWrapProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.XamMaskedEditor.SpinWrapProperty, value);
			}
		}

		// Token: 0x0600065A RID: 1626 RVA: 0x0001BD04 File Offset: 0x00019F04
		internal void Beep()
		{
			try
			{
				global::System.Media.SystemSounds.Beep.Play();
			}
			catch
			{
			}
		}

		// Token: 0x0600065B RID: 1627 RVA: 0x0001BD30 File Offset: 0x00019F30
		private static void OnSectionsChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Windows.Editors.XamMaskedEditor)d).OnSectionsChanged();
		}

		// Token: 0x0600065C RID: 1628 RVA: 0x0001BD3D File Offset: 0x00019F3D
		internal virtual void OnSectionsChanged()
		{
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x0600065D RID: 1629 RVA: 0x0001BD3F File Offset: 0x00019F3F
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.ReadOnly(true)]
		public global::Infragistics.Windows.Editors.SectionsCollection Sections
		{
			get
			{
				return (global::Infragistics.Windows.Editors.SectionsCollection)base.GetValue(global::Infragistics.Windows.Editors.XamMaskedEditor.SectionsProperty);
			}
		}

		// Token: 0x0600065E RID: 1630 RVA: 0x0001BD51 File Offset: 0x00019F51
		internal void InternalSetSections(global::Infragistics.Windows.Editors.SectionsCollection sections)
		{
			base.SetValue(global::Infragistics.Windows.Editors.XamMaskedEditor.SectionsPropertyKey, sections);
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x0600065F RID: 1631 RVA: 0x0001BD60 File Offset: 0x00019F60
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.Bindable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.ReadOnly(true)]
		public global::Infragistics.Windows.Editors.DisplayCharsCollection DisplayChars
		{
			get
			{
				global::Infragistics.Windows.Editors.SectionsCollection sections = this.Sections;
				if (this._displayChars_Sections != sections)
				{
					if (this._displayChars == null)
					{
						this._displayChars = new global::Infragistics.Windows.Editors.DisplayCharsCollection();
					}
					this._displayChars.Clear();
					if (sections != null)
					{
						for (int i = 0; i < sections.Count; i++)
						{
							global::Infragistics.Windows.Editors.SectionBase sectionBase = sections[i];
							for (int j = 0; j < sectionBase.DisplayChars.Count; j++)
							{
								this._displayChars.Add(sectionBase.DisplayChars[j]);
							}
						}
					}
					this._displayChars_Sections = sections;
				}
				return this._displayChars;
			}
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x06000660 RID: 1632 RVA: 0x0001BDF1 File Offset: 0x00019FF1
		internal bool DesignMode
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000661 RID: 1633 RVA: 0x0001BDF4 File Offset: 0x00019FF4
		public static void RegisterDefaultMaskForType(global::System.Type dataType, string mask)
		{
			lock (global::Infragistics.Windows.Editors.XamMaskedEditor.g_defaultMaskTable)
			{
				if (mask != null && mask.Length > 0)
				{
					global::Infragistics.Windows.Editors.XamMaskedEditor.g_defaultMaskTable[dataType] = mask;
					global::Infragistics.Windows.Editors.XamMaskedEditor.g_defaultMaskTableInitialized = true;
				}
				else if (global::Infragistics.Windows.Editors.XamMaskedEditor.g_defaultMaskTable.ContainsKey(dataType))
				{
					global::Infragistics.Windows.Editors.XamMaskedEditor.g_defaultMaskTable.Remove(dataType);
					if (global::Infragistics.Windows.Editors.XamMaskedEditor.g_defaultMaskTable.Count == 0)
					{
						global::Infragistics.Windows.Editors.XamMaskedEditor.g_defaultMaskTableInitialized = false;
					}
				}
			}
		}

		// Token: 0x06000662 RID: 1634 RVA: 0x0001BE78 File Offset: 0x0001A078
		public static void ResetDefaultMaskForType(global::System.Type dataType)
		{
			global::Infragistics.Windows.Editors.XamMaskedEditor.RegisterDefaultMaskForType(dataType, null);
		}

		// Token: 0x06000663 RID: 1635 RVA: 0x0001BE84 File Offset: 0x0001A084
		public static string GetDefaultMaskForType(global::System.Type dataType)
		{
			global::Infragistics.Windows.Editors.MaskDefaultType maskDefaultType;
			return global::Infragistics.Windows.Editors.XamMaskedEditor.GetDefaultMaskForType(dataType, out maskDefaultType);
		}

		// Token: 0x06000664 RID: 1636 RVA: 0x0001BE9C File Offset: 0x0001A09C
		private static string GetDefaultMaskForType(global::System.Type dataType, out global::Infragistics.Windows.Editors.MaskDefaultType maskDefaultType)
		{
			maskDefaultType = global::Infragistics.Windows.Editors.MaskDefaultType.None;
			if (global::Infragistics.Windows.Editors.XamMaskedEditor.g_defaultMaskTableInitialized)
			{
				lock (global::Infragistics.Windows.Editors.XamMaskedEditor.g_defaultMaskTable)
				{
					string text = global::Infragistics.Windows.Editors.XamMaskedEditor.g_defaultMaskTable[dataType] as string;
					if (text != null && text.Length > 0)
					{
						return text;
					}
				}
			}
			return global::Infragistics.Windows.Editors.XamMaskedEditor.GetDefaultMaskForTypeHelper(dataType, out maskDefaultType);
		}

		// Token: 0x06000665 RID: 1637 RVA: 0x0001BF0C File Offset: 0x0001A10C
		private static string GetDefaultMaskForTypeHelper(global::System.Type type, out global::Infragistics.Windows.Editors.MaskDefaultType maskDefaultType)
		{
			maskDefaultType = global::Infragistics.Windows.Editors.MaskDefaultType.None;
			type = global::Infragistics.CoreUtilities.GetUnderlyingType(type);
			string result = null;
			if (typeof(global::System.DateTime) == type)
			{
				result = "{date}";
				maskDefaultType = global::Infragistics.Windows.Editors.MaskDefaultType.DateTime;
			}
			else if (typeof(byte) == type)
			{
				result = "{number:0-255}";
				maskDefaultType = global::Infragistics.Windows.Editors.MaskDefaultType.Byte;
			}
			else if (typeof(sbyte) == type)
			{
				result = "{number:-128-127}";
				maskDefaultType = global::Infragistics.Windows.Editors.MaskDefaultType.SByte;
			}
			else if (typeof(short) == type)
			{
				result = "{number:-32768-32767}";
				maskDefaultType = global::Infragistics.Windows.Editors.MaskDefaultType.Int16;
			}
			else if (typeof(ushort) == type)
			{
				result = "{number:0-65535}";
				maskDefaultType = global::Infragistics.Windows.Editors.MaskDefaultType.UInt16;
			}
			else if (typeof(int) == type)
			{
				result = "{number:-2147483648-2147483647}";
				maskDefaultType = global::Infragistics.Windows.Editors.MaskDefaultType.Int32;
			}
			else if (typeof(uint) == type)
			{
				result = "{number:0-4294967295}";
				maskDefaultType = global::Infragistics.Windows.Editors.MaskDefaultType.UInt32;
			}
			else if (typeof(long) == type)
			{
				result = "{number:-9223372036854775808-9223372036854775807}";
				maskDefaultType = global::Infragistics.Windows.Editors.MaskDefaultType.Int64;
			}
			else if (typeof(ulong) == type)
			{
				result = "{number:0-18446744073709551615}";
				maskDefaultType = global::Infragistics.Windows.Editors.MaskDefaultType.UInt64;
			}
			else if (typeof(decimal) == type)
			{
				result = "{currency}";
				maskDefaultType = global::Infragistics.Windows.Editors.MaskDefaultType.Currency;
			}
			else if (typeof(double) == type || typeof(float) == type)
			{
				result = "{double}";
				maskDefaultType = ((typeof(double) == type) ? global::Infragistics.Windows.Editors.MaskDefaultType.Double : global::Infragistics.Windows.Editors.MaskDefaultType.Float);
			}
			else if (typeof(string) == type)
			{
				result = new string('&', 64);
			}
			return result;
		}

		// Token: 0x06000666 RID: 1638 RVA: 0x0001C0C8 File Offset: 0x0001A2C8
		public static bool SupportsDataType(global::System.Type dataType)
		{
			bool flag;
			return global::Infragistics.Windows.Editors.XamMaskedEditor.SupportsDataType(dataType, out flag);
		}

		// Token: 0x06000667 RID: 1639 RVA: 0x0001C0E0 File Offset: 0x0001A2E0
		internal static bool SupportsDataType(global::System.Type dataType, out bool usesConverter)
		{
			usesConverter = false;
			if (null == dataType)
			{
				return false;
			}
			global::System.Type underlyingType = global::Infragistics.CoreUtilities.GetUnderlyingType(dataType);
			if (typeof(global::System.DateTime) == underlyingType || typeof(short) == underlyingType || typeof(int) == underlyingType || typeof(long) == underlyingType || typeof(ushort) == underlyingType || typeof(uint) == underlyingType || typeof(ulong) == underlyingType || typeof(short) == underlyingType || typeof(int) == underlyingType || typeof(long) == underlyingType || typeof(byte) == underlyingType || typeof(sbyte) == underlyingType || typeof(decimal) == underlyingType || typeof(string) == underlyingType || typeof(double) == underlyingType || typeof(float) == underlyingType)
			{
				return true;
			}
			global::System.ComponentModel.TypeConverter converter = global::System.ComponentModel.TypeDescriptor.GetConverter(dataType);
			if (converter.CanConvertFrom(typeof(string)) && converter.CanConvertTo(typeof(string)))
			{
				usesConverter = true;
				return true;
			}
			return false;
		}

		// Token: 0x06000668 RID: 1640 RVA: 0x0001C278 File Offset: 0x0001A478
		public static string CalcDefaultTimeMask(global::System.IFormatProvider formatProvider)
		{
			global::System.Globalization.DateTimeFormatInfo dateTimeFormatInfo = global::Infragistics.Windows.Editors.XamMaskedEditor.GetDateTimeFormatInfo(formatProvider);
			bool flag = false;
			bool flag2 = false;
			string shortTimePattern = dateTimeFormatInfo.ShortTimePattern;
			char cultureChar = global::Infragistics.Windows.Editors.XamMaskedEditor.GetCultureChar(':', formatProvider);
			if (cultureChar == global::Infragistics.Windows.Editors.XamMaskedEditor.g_lastTimeSeparator && shortTimePattern == global::Infragistics.Windows.Editors.XamMaskedEditor.g_lastShortTimePattern)
			{
				return global::Infragistics.Windows.Editors.XamMaskedEditor.g_lastDefaultTimeMask;
			}
			if (shortTimePattern != null && shortTimePattern.Length > 0)
			{
				flag = (shortTimePattern.IndexOfAny(new char[]
				{
					's',
					'S'
				}) >= 0);
				flag2 = (shortTimePattern.IndexOfAny(new char[]
				{
					't',
					'T'
				}) >= 0);
			}
			string text = flag ? "hh:mm:ss" : "hh:mm";
			if (flag2)
			{
				text += " tt";
			}
			text = text.Replace(':', cultureChar);
			global::Infragistics.Windows.Editors.XamMaskedEditor.g_lastDefaultTimeMask = text;
			global::Infragistics.Windows.Editors.XamMaskedEditor.g_lastShortTimePattern = shortTimePattern;
			global::Infragistics.Windows.Editors.XamMaskedEditor.g_lastTimeSeparator = cultureChar;
			return text;
		}

		// Token: 0x06000669 RID: 1641 RVA: 0x0001C354 File Offset: 0x0001A554
		public static string CalcDefaultLongTimeMask(global::System.IFormatProvider formatProvider)
		{
			global::System.Globalization.DateTimeFormatInfo dateTimeFormatInfo = global::Infragistics.Windows.Editors.XamMaskedEditor.GetDateTimeFormatInfo(formatProvider);
			bool flag = false;
			bool flag2 = false;
			string longTimePattern = dateTimeFormatInfo.LongTimePattern;
			char cultureChar = global::Infragistics.Windows.Editors.XamMaskedEditor.GetCultureChar(':', formatProvider);
			if (longTimePattern != null && longTimePattern.Length > 0)
			{
				flag = (longTimePattern.IndexOfAny(new char[]
				{
					's',
					'S'
				}) >= 0);
				flag2 = (longTimePattern.IndexOfAny(new char[]
				{
					't',
					'T'
				}) >= 0);
			}
			string text = flag ? "hh:mm:ss" : "hh:mm";
			if (flag2)
			{
				text += " tt";
			}
			return text.Replace(':', cultureChar);
		}

		// Token: 0x0600066A RID: 1642 RVA: 0x0001C400 File Offset: 0x0001A600
		public static string CalcDefaultDateMask(global::System.IFormatProvider formatProvider)
		{
			return global::Infragistics.Windows.Editors.XamMaskedEditor.CalcDefaultDateMask(formatProvider, true);
		}

		// Token: 0x0600066B RID: 1643 RVA: 0x0001C40C File Offset: 0x0001A60C
		public static string CalcDefaultDateMask(global::System.IFormatProvider formatProvider, bool usePostfixSeparatorsFromLongDatePattern)
		{
			global::System.Globalization.DateTimeFormatInfo dateTimeFormatInfo = global::Infragistics.Windows.Editors.XamMaskedEditor.GetDateTimeFormatInfo(formatProvider);
			string shortDatePattern = dateTimeFormatInfo.ShortDatePattern;
			string text = null;
			char cultureChar = global::Infragistics.Windows.Editors.XamMaskedEditor.GetCultureChar('/', formatProvider);
			if (cultureChar == global::Infragistics.Windows.Editors.XamMaskedEditor.g_lastDateSeparator && shortDatePattern == global::Infragistics.Windows.Editors.XamMaskedEditor.g_lastShortDatePattern && formatProvider == global::Infragistics.Windows.Editors.XamMaskedEditor.g_lastDateFormatProvider && usePostfixSeparatorsFromLongDatePattern == global::Infragistics.Windows.Editors.XamMaskedEditor.g_lastUsePostfixSeparatorsFromLongDatePattern)
			{
				return global::Infragistics.Windows.Editors.XamMaskedEditor.g_lastDefaultDateMask;
			}
			if (shortDatePattern != null && shortDatePattern.Length > 0)
			{
				int num = shortDatePattern.IndexOfAny(new char[]
				{
					'm',
					'M'
				});
				int num2 = shortDatePattern.IndexOfAny(new char[]
				{
					'd',
					'D'
				});
				int num3 = shortDatePattern.IndexOfAny(new char[]
				{
					'y',
					'Y'
				});
				int num4 = shortDatePattern.LastIndexOfAny(new char[]
				{
					'y',
					'Y'
				}) - num3;
				string text2 = (num4 > 2) ? "yyyy" : "yy";
				if (usePostfixSeparatorsFromLongDatePattern)
				{
					global::System.Collections.Hashtable hashtable = null;
					text = global::Infragistics.Windows.Editors.XamMaskedEditor.GetNonstandardForeignDateMaskAndPostfixSymbols(dateTimeFormatInfo, ref hashtable);
				}
				bool flag = text == null || text.Length == 0;
				if (flag)
				{
					if (num <= num2 && num <= num3)
					{
						if (num2 < num3)
						{
							text = "mm/dd/" + text2;
						}
						else
						{
							text = "mm/" + text2 + "/dd";
						}
					}
					else if (num2 <= num && num2 <= num3)
					{
						if (num < num3)
						{
							text = "dd/mm/" + text2;
						}
						else
						{
							text = "dd/" + text2 + "/mm";
						}
					}
					else if (num3 <= num && num3 <= num2)
					{
						if (num < num2)
						{
							text = text2 + "/mm/dd";
						}
						else
						{
							text = text2 + "/dd/mm";
						}
					}
				}
			}
			if (text == null)
			{
				text = "mm/dd/yyyy";
			}
			text = text.Replace('/', cultureChar);
			global::Infragistics.Windows.Editors.XamMaskedEditor.g_lastDefaultDateMask = text;
			global::Infragistics.Windows.Editors.XamMaskedEditor.g_lastShortDatePattern = shortDatePattern;
			global::Infragistics.Windows.Editors.XamMaskedEditor.g_lastDateSeparator = cultureChar;
			global::Infragistics.Windows.Editors.XamMaskedEditor.g_lastDateFormatProvider = formatProvider;
			global::Infragistics.Windows.Editors.XamMaskedEditor.g_lastUsePostfixSeparatorsFromLongDatePattern = usePostfixSeparatorsFromLongDatePattern;
			return text;
		}

		// Token: 0x0600066C RID: 1644 RVA: 0x0001C5F0 File Offset: 0x0001A7F0
		public static string CalcDefaultCurrencyMask(global::System.IFormatProvider formatProvider, int integerDigits, int fractionDigits, char allowNegatives, bool includeCurrencySymbol)
		{
			global::System.Globalization.NumberFormatInfo numberFormatInfo = global::Infragistics.Windows.Editors.XamMaskedEditor.GetNumberFormatInfo(formatProvider);
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(15);
			int currencyPositivePattern = numberFormatInfo.CurrencyPositivePattern;
			bool flag = currencyPositivePattern > 1;
			bool flag2 = currencyPositivePattern % 2 == 0;
			if (flag2 && includeCurrencySymbol)
			{
				string value;
				global::Infragistics.Windows.Editors.MaskParser.EscapeLiteralsInString(numberFormatInfo.CurrencySymbol, out value);
				stringBuilder.Append(value);
				if (flag)
				{
					stringBuilder.Append(' ');
				}
			}
			int num = 0;
			int num2 = 0;
			int[] currencyGroupSizes = numberFormatInfo.CurrencyGroupSizes;
			global::System.Text.StringBuilder stringBuilder2 = new global::System.Text.StringBuilder(15);
			if (integerDigits < 0)
			{
				integerDigits = 9;
			}
			for (int i = 0; i < integerDigits; i++)
			{
				int num3;
				if (num < currencyGroupSizes.Length)
				{
					num3 = currencyGroupSizes[num];
				}
				else
				{
					num3 = currencyGroupSizes[currencyGroupSizes.Length - 1];
				}
				if (i == num2 + num3)
				{
					num2 = i;
					stringBuilder2.Append(',');
					num++;
				}
				stringBuilder2.Append('n');
			}
			if ('-' == allowNegatives || '+' == allowNegatives)
			{
				stringBuilder.Append(allowNegatives);
			}
			for (int j = stringBuilder2.Length - 1; j >= 0; j--)
			{
				stringBuilder.Append(stringBuilder2[j]);
			}
			if (fractionDigits < 0)
			{
				fractionDigits = numberFormatInfo.CurrencyDecimalDigits;
			}
			if (fractionDigits > 0)
			{
				stringBuilder.Append('.');
				stringBuilder.Append(new string('n', fractionDigits));
			}
			if (!flag2 && includeCurrencySymbol)
			{
				if (flag)
				{
					stringBuilder.Append(' ');
				}
				string value2;
				global::Infragistics.Windows.Editors.MaskParser.EscapeLiteralsInString(numberFormatInfo.CurrencySymbol, out value2);
				stringBuilder.Append(value2);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x0600066D RID: 1645 RVA: 0x0001C758 File Offset: 0x0001A958
		public static string CalcDefaultDoubleMask(global::System.IFormatProvider formatProvider, int integerDigits, int fractionDigits, char allowNegatives)
		{
			global::System.Globalization.NumberFormatInfo numberFormatInfo = global::Infragistics.Windows.Editors.XamMaskedEditor.GetNumberFormatInfo(formatProvider);
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(15);
			int num = 0;
			int num2 = 0;
			int[] numberGroupSizes = numberFormatInfo.NumberGroupSizes;
			global::System.Text.StringBuilder stringBuilder2 = new global::System.Text.StringBuilder(15);
			if (integerDigits < 0)
			{
				integerDigits = 9;
			}
			for (int i = 0; i < integerDigits; i++)
			{
				int num3;
				if (num < numberGroupSizes.Length)
				{
					num3 = numberGroupSizes[num];
				}
				else
				{
					num3 = numberGroupSizes[numberGroupSizes.Length - 1];
				}
				if (i == num2 + num3)
				{
					num2 = i;
					stringBuilder2.Append(',');
					num++;
				}
				stringBuilder2.Append('n');
			}
			if ('-' == allowNegatives || '+' == allowNegatives)
			{
				stringBuilder.Append(allowNegatives);
			}
			for (int j = stringBuilder2.Length - 1; j >= 0; j--)
			{
				stringBuilder.Append(stringBuilder2[j]);
			}
			if (fractionDigits < 0)
			{
				fractionDigits = numberFormatInfo.NumberDecimalDigits;
			}
			if (fractionDigits > 0)
			{
				stringBuilder.Append('.');
				stringBuilder.Append(new string('n', fractionDigits));
			}
			return stringBuilder.ToString();
		}

		// Token: 0x0600066E RID: 1646 RVA: 0x0001C84C File Offset: 0x0001AA4C
		internal static bool IsMaskValidForDataType(global::System.Type dataType, string mask, global::System.IFormatProvider formatProvider)
		{
			if (mask == null)
			{
				return false;
			}
			global::Infragistics.Windows.Editors.MaskInfo maskInfo = new global::Infragistics.Windows.Editors.MaskInfo();
			maskInfo.InitializeFormatProvider(formatProvider, null);
			global::Infragistics.Windows.Editors.SectionsCollection sectionsCollection;
			global::Infragistics.Windows.Editors.MaskParser.Parse(mask, out sectionsCollection, maskInfo.FormatProvider);
			sectionsCollection.Initialize(maskInfo);
			return global::Infragistics.Windows.Editors.XamMaskedEditor.IsMaskValidForDataType(dataType, sectionsCollection);
		}

		// Token: 0x0600066F RID: 1647 RVA: 0x0001C888 File Offset: 0x0001AA88
		internal static bool IsMaskValidForDataType(global::System.Type dataType, global::Infragistics.Windows.Editors.SectionsCollection parsedSections)
		{
			global::System.Type underlyingType = global::Infragistics.CoreUtilities.GetUnderlyingType(dataType);
			if (typeof(global::System.DateTime) == underlyingType)
			{
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				int num4 = 0;
				int num5 = 0;
				int num6 = 0;
				int num7 = 0;
				for (int i = 0; i < parsedSections.Count; i++)
				{
					global::Infragistics.Windows.Editors.SectionBase sectionBase = parsedSections[i];
					if (sectionBase is global::Infragistics.Windows.Editors.DaySection)
					{
						num2++;
					}
					else if (sectionBase is global::Infragistics.Windows.Editors.YearSection)
					{
						num3++;
					}
					else if (sectionBase is global::Infragistics.Windows.Editors.MonthSection)
					{
						num++;
					}
					else if (sectionBase is global::Infragistics.Windows.Editors.MinuteSection)
					{
						num4++;
					}
					else if (sectionBase is global::Infragistics.Windows.Editors.HourSection)
					{
						num5++;
					}
					else if (sectionBase is global::Infragistics.Windows.Editors.SecondSection)
					{
						num6++;
					}
					else if (sectionBase is global::Infragistics.Windows.Editors.AMPMSection)
					{
						num7++;
					}
					else if (!(sectionBase is global::Infragistics.Windows.Editors.LiteralSection))
					{
						return false;
					}
				}
				bool flag = num <= 1 && num2 <= 1 && num3 <= 1 && num5 <= 1 && num4 <= 1 && num6 <= 1 && num7 <= 1;
				return flag && (1 == num || 1 == num2 || 1 == num3 || 1 == num5);
			}
			if (typeof(byte) == underlyingType || typeof(sbyte) == underlyingType || typeof(short) == underlyingType || typeof(ushort) == underlyingType || typeof(short) == underlyingType || typeof(int) == underlyingType || typeof(uint) == underlyingType || typeof(int) == underlyingType || typeof(long) == underlyingType || typeof(ulong) == underlyingType || typeof(long) == underlyingType)
			{
				int num8 = 0;
				for (int j = 0; j < parsedSections.Count; j++)
				{
					if (global::Infragistics.Windows.Editors.XamMaskedEditor.IsSectionNumeric(parsedSections[j]))
					{
						num8++;
					}
					if (num8 >= 2)
					{
						break;
					}
				}
				return 1 == num8;
			}
			if (typeof(double) == underlyingType || typeof(float) == underlyingType || typeof(decimal) == underlyingType)
			{
				global::Infragistics.Windows.Editors.SectionBase sectionBase2 = null;
				global::Infragistics.Windows.Editors.SectionBase sectionBase3 = null;
				bool flag2 = false;
				for (int k = 0; k < parsedSections.Count; k++)
				{
					if (global::Infragistics.Windows.Editors.XamMaskedEditor.IsSectionNumeric(parsedSections[k]))
					{
						if (!flag2)
						{
							sectionBase2 = parsedSections[k];
						}
						else
						{
							if (sectionBase3 != null)
							{
								return false;
							}
							sectionBase3 = parsedSections[k];
						}
					}
					else if (parsedSections[k] is global::Infragistics.Windows.Editors.LiteralSection && 1 == parsedSections[k].DisplayChars.Count && parsedSections[k].CommaChar == parsedSections[k].DisplayChars[0].Char)
					{
						if (flag2)
						{
							return false;
						}
						sectionBase2 = null;
					}
					else if (parsedSections[k] is global::Infragistics.Windows.Editors.LiteralSection && 1 == parsedSections[k].DisplayChars.Count && parsedSections[k].DecimalSeperatorChar == parsedSections[k].DisplayChars[0].Char)
					{
						flag2 = true;
					}
					else if ((sectionBase2 != null || sectionBase3 != null || flag2) && !(parsedSections[k] is global::Infragistics.Windows.Editors.LiteralSection))
					{
						return false;
					}
				}
				return sectionBase2 != null || null != sectionBase3;
			}
			return typeof(string) == underlyingType;
		}

		// Token: 0x06000670 RID: 1648 RVA: 0x0001CC38 File Offset: 0x0001AE38
		public string GetText(global::Infragistics.Windows.Editors.MaskMode maskMode)
		{
			global::Infragistics.Windows.Editors.EditInfo editInfo = this.EditInfo;
			if (editInfo != null)
			{
				return editInfo.GetText(maskMode);
			}
			global::Infragistics.Windows.Editors.MaskInfo maskInfo = this.MaskInfo;
			return global::Infragistics.Windows.Editors.XamMaskedEditor.GetText(maskInfo.Sections, maskMode, maskInfo);
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x06000671 RID: 1649 RVA: 0x0001CC6B File Offset: 0x0001AE6B
		internal global::Infragistics.Windows.Editors.MaskInfo MaskInfo
		{
			get
			{
				if (this._maskInfo == null)
				{
					this._maskInfo = new global::Infragistics.Windows.Editors.MaskInfo(this);
					this.InternalSetSections(this._maskInfo.Sections);
				}
				return this._maskInfo;
			}
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x06000672 RID: 1650 RVA: 0x0001CC98 File Offset: 0x0001AE98
		internal global::Infragistics.Windows.Editors.MaskInfo MaskInfoIfAllocated
		{
			get
			{
				return this._maskInfo;
			}
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x06000673 RID: 1651 RVA: 0x0001CCA0 File Offset: 0x0001AEA0
		internal global::Infragistics.Windows.Editors.EditInfo EditInfo
		{
			get
			{
				return this._editInfo;
			}
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x06000674 RID: 1652 RVA: 0x0001CCA8 File Offset: 0x0001AEA8
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool IsTextBoxEntryEnabled
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.Editors.XamMaskedEditor.IsTextBoxEntryEnabledProperty);
			}
		}

		// Token: 0x06000675 RID: 1653 RVA: 0x0001CCBC File Offset: 0x0001AEBC
		internal void InternalSetIsTextBoxEntryEnabled(bool value)
		{
			if (this.IsTextBoxEntryEnabled != value)
			{
				this._resetIsTextBoxEntryEnabledWhenEditModeEnds = false;
				if (!value && base.IsInEditMode)
				{
					this._resetIsTextBoxEntryEnabledWhenEditModeEnds = true;
					return;
				}
				bool flag = base.IsKeyboardFocusWithin;
				if (flag)
				{
					base.Focus();
				}
				base.SetValue(global::Infragistics.Windows.Editors.XamMaskedEditor.IsTextBoxEntryEnabledPropertyKey, value);
				this.ShowHideCaretHelper();
				flag = (flag && base.IsKeyboardFocusWithin);
				if (base.IsInEditMode && flag && !this._isInEndEditMode)
				{
					base.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Input, new global::Infragistics.Windows.Editors.Utils.MethodInvoker(this.DelayedSetFocusToFocusSiteHelper));
					this.ShowHideCaretHelper();
				}
			}
		}

		// Token: 0x06000676 RID: 1654 RVA: 0x0001CD56 File Offset: 0x0001AF56
		private void DelayedSetFocusToFocusSiteHelper()
		{
			if (base.IsInEditMode && !this._isInEndEditMode)
			{
				base.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Input, new global::Infragistics.Windows.Editors.Utils.MethodInvoker(base.SetFocusToFocusSite));
			}
		}

		// Token: 0x06000677 RID: 1655 RVA: 0x0001CD81 File Offset: 0x0001AF81
		protected override void OnEditModeStarting(global::Infragistics.Windows.Editors.Events.EditModeStartingEventArgs args)
		{
			base.OnEditModeStarting(args);
			if (!args.Cancel)
			{
				this._editInfo = new global::Infragistics.Windows.Editors.EditInfo(this.MaskInfo);
				this.MaskInfo.InternalRefreshValue(base.Value);
			}
		}

		// Token: 0x06000678 RID: 1656 RVA: 0x0001CDB8 File Offset: 0x0001AFB8
		protected override void OnEditModeStarted(global::Infragistics.Windows.Editors.Events.EditModeStartedEventArgs args)
		{
			global::Infragistics.Windows.Editors.EditInfo editInfo = this.EditInfo;
			if (editInfo != null && this._transitingIntoEditModeInMouseDown)
			{
				object value = base.Value;
				bool flag = value == null || global::System.DBNull.Value == value || (value is string && 0 == ((string)value).Length);
				if (!string.IsNullOrEmpty(base.Format) || flag)
				{
					editInfo.SetCaretPivot(0);
				}
				else
				{
					this.VerifyElementsPositioned();
					editInfo.MaskedEditUIElementClicked(this._transitingIntoEditModeInMouseDownPoint);
					base.CaptureMouse();
					if (base.IsMouseCaptured)
					{
						this._isDragSelecting = true;
					}
				}
				this._transitingIntoEditModeInMouseDown = false;
				this.ProcessIsBeingEditedAndFocusedChanged();
			}
			base.OnEditModeStarted(args);
			if (this._editInfo != null)
			{
				this._editInfo.SyncCaretAndPivotsWithMaskedEditor();
				this.ProcessSelectionChanged();
			}
			if (this.MaskInfo != null && this.MaskInfo.IsBeingEditedAndFocused)
			{
				this.ShowHideCaretHelper();
				if (this._editInfo != null)
				{
					this._editInfo.ScrollCaretIntoView();
				}
			}
		}

		// Token: 0x06000679 RID: 1657 RVA: 0x0001CEAD File Offset: 0x0001B0AD
		protected override void OnEditModeEnded(global::Infragistics.Windows.Editors.Events.EditModeEndedEventArgs args)
		{
			base.OnEditModeEnded(args);
			this.ShowHideCaretHelper();
			if (this._editInfo != null)
			{
				this._editInfo.InitializeIMETextBox(null);
				if (this._resetIsTextBoxEntryEnabledWhenEditModeEnds)
				{
					this.InternalSetIsTextBoxEntryEnabled(false);
				}
				this._editInfo = null;
			}
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x0600067A RID: 1658 RVA: 0x0001CEE6 File Offset: 0x0001B0E6
		// (set) Token: 0x0600067B RID: 1659 RVA: 0x0001CEF8 File Offset: 0x0001B0F8
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Browsable(false)]
		public bool InsertMode
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.Editors.XamMaskedEditor.InsertModeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.XamMaskedEditor.InsertModeProperty, value);
			}
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x0600067C RID: 1660 RVA: 0x0001CF0B File Offset: 0x0001B10B
		// (set) Token: 0x0600067D RID: 1661 RVA: 0x0001CF13 File Offset: 0x0001B113
		[global::System.ComponentModel.RefreshProperties(global::System.ComponentModel.RefreshProperties.All)]
		public string Mask
		{
			get
			{
				return this._cachedMask;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.XamMaskedEditor.MaskProperty, value);
			}
		}

		// Token: 0x0600067E RID: 1662 RVA: 0x0001CF24 File Offset: 0x0001B124
		private static void OnMaskChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Editors.XamMaskedEditor xamMaskedEditor = (global::Infragistics.Windows.Editors.XamMaskedEditor)dependencyObject;
			xamMaskedEditor._cachedMask = (string)e.NewValue;
			if (xamMaskedEditor.IsInitialized)
			{
				xamMaskedEditor.ReparseMask();
			}
		}

		// Token: 0x0600067F RID: 1663 RVA: 0x0001CF58 File Offset: 0x0001B158
		private void ReparseMask()
		{
			if (this._maskInfo != null)
			{
				this._maskInfo.RecreateSections(false);
			}
			base.SyncValueProperties(global::Infragistics.Windows.Editors.ValueEditor.ValueProperty, base.Value);
		}

		// Token: 0x06000680 RID: 1664 RVA: 0x0001CF7F File Offset: 0x0001B17F
		protected override void OnValueTypeChanged(global::System.Type newType)
		{
			base.OnValueTypeChanged(newType);
			if (this._maskInfo != null)
			{
				this._maskInfo.DataType = base.ValueType;
				if (base.IsInitialized)
				{
					this.ReparseMask();
				}
			}
		}

		// Token: 0x06000681 RID: 1665 RVA: 0x0001CFAF File Offset: 0x0001B1AF
		private void ApplyMaskToText()
		{
			base.SyncTextWithValue();
			base.SyncDisplayText();
		}

		// Token: 0x06000682 RID: 1666 RVA: 0x0001CFC0 File Offset: 0x0001B1C0
		public static string ApplyMask(string text, string mask, global::System.IFormatProvider formatProvider, char promptCharacter, char padCharacter, global::Infragistics.Windows.Editors.MaskMode maskMode)
		{
			global::Infragistics.Windows.Editors.ParsedMask parsedMask = new global::Infragistics.Windows.Editors.ParsedMask(mask, formatProvider, promptCharacter, padCharacter);
			return parsedMask.ApplyMask(text, maskMode);
		}

		// Token: 0x06000683 RID: 1667 RVA: 0x0001CFE4 File Offset: 0x0001B1E4
		internal override bool SyncValuePropertiesOverride(global::System.Windows.DependencyProperty prop, object newValue, out global::System.Exception error)
		{
			bool result;
			if (prop == global::Infragistics.Windows.Editors.ValueEditor.ValueProperty && this.TryFastSyncOnValueChanged(newValue, out error))
			{
				result = true;
			}
			else
			{
				result = base.SyncValuePropertiesOverride(prop, newValue, out error);
				global::System.Exception ex;
				if ((this._editInfo == null || !this._editInfo._inOnTextChanged) && !this.MaskInfo.InternalRefreshValue(base.Value, out ex))
				{
					if (error == null)
					{
						error = ex;
					}
					result = false;
				}
			}
			if (this._editInfo != null)
			{
				this._editInfo.SyncIMETextBox();
			}
			return result;
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x06000684 RID: 1668 RVA: 0x0001D058 File Offset: 0x0001B258
		// (set) Token: 0x06000685 RID: 1669 RVA: 0x0001D060 File Offset: 0x0001B260
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.Editors.MaskMode DataMode
		{
			get
			{
				return this._cachedDataMode;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.XamMaskedEditor.DataModeProperty, value);
			}
		}

		// Token: 0x06000686 RID: 1670 RVA: 0x0001D074 File Offset: 0x0001B274
		private static void OnDataModeChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Editors.XamMaskedEditor xamMaskedEditor = (global::Infragistics.Windows.Editors.XamMaskedEditor)dependencyObject;
			global::Infragistics.Windows.Editors.MaskMode maskMode = (global::Infragistics.Windows.Editors.MaskMode)e.NewValue;
			xamMaskedEditor._cachedDataMode = maskMode;
			if (xamMaskedEditor._maskInfo != null)
			{
				xamMaskedEditor._maskInfo.DataMode = maskMode;
			}
			if (xamMaskedEditor.IsInitialized)
			{
				xamMaskedEditor.ApplyMaskToText();
			}
		}

		// Token: 0x06000687 RID: 1671 RVA: 0x0001D0BE File Offset: 0x0001B2BE
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeDataMode()
		{
			return global::Infragistics.Windows.Utilities.ShouldSerialize(global::Infragistics.Windows.Editors.XamMaskedEditor.DataModeProperty, this);
		}

		// Token: 0x06000688 RID: 1672 RVA: 0x0001D0CB File Offset: 0x0001B2CB
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetDataMode()
		{
			base.ClearValue(global::Infragistics.Windows.Editors.XamMaskedEditor.DataModeProperty);
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x06000689 RID: 1673 RVA: 0x0001D0D8 File Offset: 0x0001B2D8
		// (set) Token: 0x0600068A RID: 1674 RVA: 0x0001D0E0 File Offset: 0x0001B2E0
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.Editors.MaskMode ClipMode
		{
			get
			{
				return this._cachedClipMode;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.XamMaskedEditor.ClipModeProperty, value);
			}
		}

		// Token: 0x0600068B RID: 1675 RVA: 0x0001D0F4 File Offset: 0x0001B2F4
		private static void OnClipModeChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Editors.XamMaskedEditor xamMaskedEditor = (global::Infragistics.Windows.Editors.XamMaskedEditor)dependencyObject;
			global::Infragistics.Windows.Editors.MaskMode maskMode = (global::Infragistics.Windows.Editors.MaskMode)e.NewValue;
			xamMaskedEditor._cachedClipMode = maskMode;
			if (xamMaskedEditor._maskInfo != null)
			{
				xamMaskedEditor._maskInfo.ClipMode = maskMode;
			}
		}

		// Token: 0x0600068C RID: 1676 RVA: 0x0001D130 File Offset: 0x0001B330
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeClipMode()
		{
			return global::Infragistics.Windows.Utilities.ShouldSerialize(global::Infragistics.Windows.Editors.XamMaskedEditor.ClipModeProperty, this);
		}

		// Token: 0x0600068D RID: 1677 RVA: 0x0001D13D File Offset: 0x0001B33D
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetClipMode()
		{
			base.ClearValue(global::Infragistics.Windows.Editors.XamMaskedEditor.ClipModeProperty);
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x0600068E RID: 1678 RVA: 0x0001D14A File Offset: 0x0001B34A
		// (set) Token: 0x0600068F RID: 1679 RVA: 0x0001D152 File Offset: 0x0001B352
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.Editors.MaskMode DisplayMode
		{
			get
			{
				return this._cachedDisplayMode;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.XamMaskedEditor.DisplayModeProperty, value);
			}
		}

		// Token: 0x06000690 RID: 1680 RVA: 0x0001D168 File Offset: 0x0001B368
		private static void OnDisplayModeChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Editors.XamMaskedEditor xamMaskedEditor = (global::Infragistics.Windows.Editors.XamMaskedEditor)dependencyObject;
			global::Infragistics.Windows.Editors.MaskMode maskMode = (global::Infragistics.Windows.Editors.MaskMode)e.NewValue;
			xamMaskedEditor._cachedDisplayMode = maskMode;
			if (xamMaskedEditor._maskInfo != null)
			{
				xamMaskedEditor._maskInfo.DisplayMode = maskMode;
			}
		}

		// Token: 0x06000691 RID: 1681 RVA: 0x0001D1A4 File Offset: 0x0001B3A4
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeDisplayMode()
		{
			return global::Infragistics.Windows.Utilities.ShouldSerialize(global::Infragistics.Windows.Editors.XamMaskedEditor.DisplayModeProperty, this);
		}

		// Token: 0x06000692 RID: 1682 RVA: 0x0001D1B1 File Offset: 0x0001B3B1
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetDisplayMode()
		{
			base.ClearValue(global::Infragistics.Windows.Editors.XamMaskedEditor.DisplayModeProperty);
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x06000693 RID: 1683 RVA: 0x0001D1BE File Offset: 0x0001B3BE
		// (set) Token: 0x06000694 RID: 1684 RVA: 0x0001D1C6 File Offset: 0x0001B3C6
		[global::System.ComponentModel.Bindable(true)]
		public char PadChar
		{
			get
			{
				return this._cachedPadChar;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.XamMaskedEditor.PadCharProperty, value);
			}
		}

		// Token: 0x06000695 RID: 1685 RVA: 0x0001D1D9 File Offset: 0x0001B3D9
		private static bool ValidatePadChar(object objVal)
		{
			return global::Infragistics.Windows.Editors.XamMaskedEditor.IsValidPromptChar((char)objVal);
		}

		// Token: 0x06000696 RID: 1686 RVA: 0x0001D1E8 File Offset: 0x0001B3E8
		private static void OnPadCharChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Editors.XamMaskedEditor xamMaskedEditor = (global::Infragistics.Windows.Editors.XamMaskedEditor)dependencyObject;
			char cachedPadChar = (char)e.NewValue;
			xamMaskedEditor._cachedPadChar = cachedPadChar;
			xamMaskedEditor.NotifyDisplayCharDrawStringsChanged();
		}

		// Token: 0x06000697 RID: 1687 RVA: 0x0001D216 File Offset: 0x0001B416
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializePadChar()
		{
			return global::Infragistics.Windows.Utilities.ShouldSerialize(global::Infragistics.Windows.Editors.XamMaskedEditor.PadCharProperty, this);
		}

		// Token: 0x06000698 RID: 1688 RVA: 0x0001D223 File Offset: 0x0001B423
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetPadChar()
		{
			base.ClearValue(global::Infragistics.Windows.Editors.XamMaskedEditor.PadCharProperty);
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x06000699 RID: 1689 RVA: 0x0001D230 File Offset: 0x0001B430
		// (set) Token: 0x0600069A RID: 1690 RVA: 0x0001D238 File Offset: 0x0001B438
		[global::System.ComponentModel.Bindable(true)]
		public char PromptChar
		{
			get
			{
				return this._cachedPromptChar;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.XamMaskedEditor.PromptCharProperty, value);
			}
		}

		// Token: 0x0600069B RID: 1691 RVA: 0x0001D24B File Offset: 0x0001B44B
		private static bool ValidatePromptChar(object objVal)
		{
			return global::Infragistics.Windows.Editors.XamMaskedEditor.IsValidPromptChar((char)objVal);
		}

		// Token: 0x0600069C RID: 1692 RVA: 0x0001D258 File Offset: 0x0001B458
		private static void OnPromptCharChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Editors.XamMaskedEditor xamMaskedEditor = (global::Infragistics.Windows.Editors.XamMaskedEditor)dependencyObject;
			char cachedPromptChar = (char)e.NewValue;
			xamMaskedEditor._cachedPromptChar = cachedPromptChar;
			xamMaskedEditor.NotifyDisplayCharDrawStringsChanged();
		}

		// Token: 0x0600069D RID: 1693 RVA: 0x0001D286 File Offset: 0x0001B486
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializePromptChar()
		{
			return global::Infragistics.Windows.Utilities.ShouldSerialize(global::Infragistics.Windows.Editors.XamMaskedEditor.PromptCharProperty, this);
		}

		// Token: 0x0600069E RID: 1694 RVA: 0x0001D293 File Offset: 0x0001B493
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetPromptChar()
		{
			base.ClearValue(global::Infragistics.Windows.Editors.XamMaskedEditor.PromptCharProperty);
		}

		// Token: 0x0600069F RID: 1695 RVA: 0x0001D2A0 File Offset: 0x0001B4A0
		public void SelectAll()
		{
			this.EnsureInEditMode();
			this.EditInfo.SelectAll();
		}

		// Token: 0x060006A0 RID: 1696 RVA: 0x0001D2B3 File Offset: 0x0001B4B3
		public bool Delete()
		{
			this.EnsureInEditMode();
			return this.EditInfo.Delete(false, true);
		}

		// Token: 0x060006A1 RID: 1697 RVA: 0x0001D2C8 File Offset: 0x0001B4C8
		public void Copy()
		{
			this.EnsureInEditMode();
			this.EditInfo.Copy();
		}

		// Token: 0x060006A2 RID: 1698 RVA: 0x0001D2DB File Offset: 0x0001B4DB
		public void Cut()
		{
			this.EnsureInEditMode();
			this.EditInfo.Cut();
		}

		// Token: 0x060006A3 RID: 1699 RVA: 0x0001D2EE File Offset: 0x0001B4EE
		public void Paste()
		{
			this.EnsureInEditMode();
			this.EditInfo.Paste();
		}

		// Token: 0x060006A4 RID: 1700 RVA: 0x0001D301 File Offset: 0x0001B501
		public void ToggleInsertMode()
		{
			this.EnsureInEditMode();
			this.EditInfo.ToggleInsertMode();
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x060006A5 RID: 1701 RVA: 0x0001D314 File Offset: 0x0001B514
		// (set) Token: 0x060006A6 RID: 1702 RVA: 0x0001D31C File Offset: 0x0001B51C
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		[global::System.ComponentModel.Browsable(false)]
		internal bool DisplayNullTextWhenNotFocused
		{
			get
			{
				return this._displayNullTextWhenNotFocused;
			}
			set
			{
				this._displayNullTextWhenNotFocused = value;
			}
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x060006A7 RID: 1703 RVA: 0x0001D325 File Offset: 0x0001B525
		// (set) Token: 0x060006A8 RID: 1704 RVA: 0x0001D337 File Offset: 0x0001B537
		public global::Infragistics.Windows.Editors.MaskedEditTabNavigation TabNavigation
		{
			get
			{
				return (global::Infragistics.Windows.Editors.MaskedEditTabNavigation)base.GetValue(global::Infragistics.Windows.Editors.XamMaskedEditor.TabNavigationProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.XamMaskedEditor.TabNavigationProperty, value);
			}
		}

		// Token: 0x060006A9 RID: 1705 RVA: 0x0001D34A File Offset: 0x0001B54A
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeTabNavigation()
		{
			return global::Infragistics.Windows.Utilities.ShouldSerialize(global::Infragistics.Windows.Editors.XamMaskedEditor.TabNavigationProperty, this);
		}

		// Token: 0x060006AA RID: 1706 RVA: 0x0001D357 File Offset: 0x0001B557
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetTabNavigation()
		{
			base.ClearValue(global::Infragistics.Windows.Editors.XamMaskedEditor.TabNavigationProperty);
		}

		// Token: 0x060006AB RID: 1707 RVA: 0x0001D364 File Offset: 0x0001B564
		internal global::System.Windows.Controls.ContextMenu CreateContextMenu()
		{
			global::System.Windows.Controls.ContextMenu contextMenu = new global::System.Windows.Controls.ContextMenu();
			new global::Infragistics.Windows.Editors.XamMaskedEditor.ContextMenuHelper(this, contextMenu);
			return contextMenu;
		}

		// Token: 0x060006AC RID: 1708 RVA: 0x0001D380 File Offset: 0x0001B580
		private static void InitializeContextMenu(global::Infragistics.Windows.Editors.XamMaskedEditor commandTarget, global::System.Windows.Controls.ContextMenu menu)
		{
			global::System.Windows.Controls.MenuItem menuItem = new global::System.Windows.Controls.MenuItem();
			menu.Items.Add(menuItem);
			menuItem.Command = global::Infragistics.Windows.Editors.MaskedEditorCommands.Undo;
			menuItem.CommandTarget = commandTarget;
			menu.Items.Add(new global::System.Windows.Controls.Separator());
			menuItem = new global::System.Windows.Controls.MenuItem();
			menu.Items.Add(menuItem);
			menuItem.Command = global::Infragistics.Windows.Editors.MaskedEditorCommands.Cut;
			menuItem.CommandTarget = commandTarget;
			menuItem = new global::System.Windows.Controls.MenuItem();
			menu.Items.Add(menuItem);
			menuItem.Command = global::Infragistics.Windows.Editors.MaskedEditorCommands.Copy;
			menuItem.CommandTarget = commandTarget;
			menuItem = new global::System.Windows.Controls.MenuItem();
			menu.Items.Add(menuItem);
			menuItem.Command = global::Infragistics.Windows.Editors.MaskedEditorCommands.Paste;
			menuItem.CommandTarget = commandTarget;
			menuItem = new global::System.Windows.Controls.MenuItem();
			menu.Items.Add(menuItem);
			menuItem.Command = global::Infragistics.Windows.Editors.MaskedEditorCommands.Delete;
			menuItem.CommandTarget = commandTarget;
			menu.Items.Add(new global::System.Windows.Controls.Separator());
			menuItem = new global::System.Windows.Controls.MenuItem();
			menu.Items.Add(menuItem);
			menuItem.Command = global::Infragistics.Windows.Editors.MaskedEditorCommands.SelectAll;
			menuItem.CommandTarget = commandTarget;
		}

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x060006AD RID: 1709 RVA: 0x0001D490 File Offset: 0x0001B690
		internal global::Infragistics.Windows.Editors.MaskedEditTabNavigation TabNavigationResolved
		{
			get
			{
				global::Infragistics.Windows.Editors.MaskedEditTabNavigation maskedEditTabNavigation = this.TabNavigation;
				if (global::Infragistics.Windows.Editors.MaskedEditTabNavigation.NextSection == maskedEditTabNavigation && this.EditInfo != null && this.EditInfo.LastEditSection is global::Infragistics.Windows.Editors.FractionPartContinuous)
				{
					maskedEditTabNavigation = global::Infragistics.Windows.Editors.MaskedEditTabNavigation.NextControl;
				}
				return maskedEditTabNavigation;
			}
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x060006AE RID: 1710 RVA: 0x0001D4C5 File Offset: 0x0001B6C5
		// (set) Token: 0x060006AF RID: 1711 RVA: 0x0001D4CD File Offset: 0x0001B6CD
		public bool AllowShiftingAcrossSections
		{
			get
			{
				return this._allowShiftingAcrossSections;
			}
			set
			{
				if (this._allowShiftingAcrossSections != value)
				{
					this._allowShiftingAcrossSections = value;
				}
			}
		}

		// Token: 0x060006B0 RID: 1712 RVA: 0x0001D4DF File Offset: 0x0001B6DF
		private static bool IsValidPromptChar(char promptCharacter)
		{
			return "\b\t\u0013".IndexOf(promptCharacter) < 0;
		}

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x060006B1 RID: 1713 RVA: 0x0001D4EF File Offset: 0x0001B6EF
		// (set) Token: 0x060006B2 RID: 1714 RVA: 0x0001D506 File Offset: 0x0001B706
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		public int SelectionStart
		{
			get
			{
				if (this.EditInfo == null)
				{
					return 0;
				}
				return this.EditInfo.SelectionStart;
			}
			set
			{
				if (this.EditInfo != null)
				{
					this.EditInfo.SelectionStart = value;
				}
			}
		}

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x060006B3 RID: 1715 RVA: 0x0001D51C File Offset: 0x0001B71C
		// (set) Token: 0x060006B4 RID: 1716 RVA: 0x0001D533 File Offset: 0x0001B733
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public int SelectionLength
		{
			get
			{
				if (this.EditInfo == null)
				{
					return 0;
				}
				return this.EditInfo.SelectionLength;
			}
			set
			{
				if (this.EditInfo != null)
				{
					this.EditInfo.SelectionLength = value;
				}
			}
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x060006B5 RID: 1717 RVA: 0x0001D549 File Offset: 0x0001B749
		// (set) Token: 0x060006B6 RID: 1718 RVA: 0x0001D560 File Offset: 0x0001B760
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public string SelectedText
		{
			get
			{
				if (this.EditInfo == null)
				{
					return null;
				}
				return this.EditInfo.SelectedText;
			}
			set
			{
				if (this.EditInfo != null)
				{
					this.EditInfo.SelectedText = value;
				}
			}
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x060006B7 RID: 1719 RVA: 0x0001D576 File Offset: 0x0001B776
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		public int TextLength
		{
			get
			{
				if (this.EditInfo == null)
				{
					return 0;
				}
				return this.EditInfo.GetTotalNumberOfDisplayChars();
			}
		}

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x060006B8 RID: 1720 RVA: 0x0001D58D File Offset: 0x0001B78D
		// (set) Token: 0x060006B9 RID: 1721 RVA: 0x0001D59F File Offset: 0x0001B79F
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Bindable(true)]
		internal int CaretPosition
		{
			get
			{
				return (int)base.GetValue(global::Infragistics.Windows.Editors.XamMaskedEditor.CaretPositionProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.XamMaskedEditor.CaretPositionProperty, value);
			}
		}

		// Token: 0x060006BA RID: 1722 RVA: 0x0001D5B4 File Offset: 0x0001B7B4
		private static void OnCaretPositionChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Editors.XamMaskedEditor xamMaskedEditor = (global::Infragistics.Windows.Editors.XamMaskedEditor)dependencyObject;
			int caretPosition = (int)e.NewValue;
			if (xamMaskedEditor != null && xamMaskedEditor.EditInfo != null)
			{
				xamMaskedEditor.EditInfo.CaretPosition = caretPosition;
				xamMaskedEditor.ProcessSelectionChanged();
			}
		}

		// Token: 0x060006BB RID: 1723 RVA: 0x0001D5F4 File Offset: 0x0001B7F4
		internal void ProcessSelectionChanged()
		{
			global::Infragistics.Windows.Editors.EditInfo editInfo = this.EditInfo;
			if (editInfo != null)
			{
				global::Infragistics.Windows.Editors.XamMaskedEditor.NotifyPropertyOnDisplayCharacters(this.EditInfo.Sections, global::Infragistics.Windows.Editors.DisplayCharBase.PROPERTY_DRAWSELECTED);
				this.SyncDrawAsSelectedOnDisplayPresenters();
				editInfo.SyncIMETextBox();
				this.ShowHideCaretHelper();
			}
		}

		// Token: 0x060006BC RID: 1724 RVA: 0x0001D634 File Offset: 0x0001B834
		private static object OnCoerceCaretPosition(global::System.Windows.DependencyObject dependencyObject, object valueAsObject)
		{
			global::Infragistics.Windows.Editors.XamMaskedEditor xamMaskedEditor = (global::Infragistics.Windows.Editors.XamMaskedEditor)dependencyObject;
			int num = (int)valueAsObject;
			if (xamMaskedEditor.EditInfo != null)
			{
				num = xamMaskedEditor.EditInfo.CoerceCaretPosition(num);
			}
			else
			{
				num = 0;
			}
			return num;
		}

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x060006BD RID: 1725 RVA: 0x0001D66E File Offset: 0x0001B86E
		// (set) Token: 0x060006BE RID: 1726 RVA: 0x0001D680 File Offset: 0x0001B880
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Bindable(true)]
		internal int PivotPosition
		{
			get
			{
				return (int)base.GetValue(global::Infragistics.Windows.Editors.XamMaskedEditor.PivotPositionProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.XamMaskedEditor.PivotPositionProperty, value);
			}
		}

		// Token: 0x060006BF RID: 1727 RVA: 0x0001D694 File Offset: 0x0001B894
		private static void OnPivotPositionChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Editors.XamMaskedEditor xamMaskedEditor = (global::Infragistics.Windows.Editors.XamMaskedEditor)dependencyObject;
			int pivotPosition = (int)e.NewValue;
			if (xamMaskedEditor != null && xamMaskedEditor.EditInfo != null)
			{
				xamMaskedEditor.EditInfo.PivotPosition = pivotPosition;
				xamMaskedEditor.ProcessSelectionChanged();
			}
		}

		// Token: 0x060006C0 RID: 1728 RVA: 0x0001D6D4 File Offset: 0x0001B8D4
		private static object OnCoercePivotPosition(global::System.Windows.DependencyObject dependencyObject, object valueAsObject)
		{
			global::Infragistics.Windows.Editors.XamMaskedEditor xamMaskedEditor = (global::Infragistics.Windows.Editors.XamMaskedEditor)dependencyObject;
			int num = (int)valueAsObject;
			if (xamMaskedEditor.IsInEditMode)
			{
				num = xamMaskedEditor.EditInfo.CoercePivotPosition(num);
			}
			else
			{
				num = 0;
			}
			return num;
		}

		// Token: 0x060006C1 RID: 1729 RVA: 0x0001D70E File Offset: 0x0001B90E
		protected virtual void OnExecutingCommand(global::Infragistics.Windows.Controls.Events.ExecutingCommandEventArgs args)
		{
			base.RaiseEventHelper(args);
		}

		// Token: 0x060006C2 RID: 1730 RVA: 0x0001D718 File Offset: 0x0001B918
		internal bool RaiseExecutingCommand(global::Infragistics.Windows.Controls.Events.ExecutingCommandEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.Editors.XamMaskedEditor.ExecutingCommandEvent;
			args.Source = this;
			this.OnExecutingCommand(args);
			return !args.Cancel;
		}

		// Token: 0x14000018 RID: 24
		// (add) Token: 0x060006C3 RID: 1731 RVA: 0x0001D73C File Offset: 0x0001B93C
		// (remove) Token: 0x060006C4 RID: 1732 RVA: 0x0001D74A File Offset: 0x0001B94A
		public event global::System.EventHandler<global::Infragistics.Windows.Controls.Events.ExecutingCommandEventArgs> ExecutingCommand
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.Editors.XamMaskedEditor.ExecutingCommandEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.Editors.XamMaskedEditor.ExecutingCommandEvent, value);
			}
		}

		// Token: 0x060006C5 RID: 1733 RVA: 0x0001D758 File Offset: 0x0001B958
		protected virtual void OnExecutedCommand(global::Infragistics.Windows.Controls.Events.ExecutedCommandEventArgs args)
		{
			base.RaiseEventHelper(args);
		}

		// Token: 0x060006C6 RID: 1734 RVA: 0x0001D762 File Offset: 0x0001B962
		internal void RaiseExecutedCommand(global::Infragistics.Windows.Controls.Events.ExecutedCommandEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.Editors.XamMaskedEditor.ExecutedCommandEvent;
			args.Source = this;
			this.OnExecutedCommand(args);
		}

		// Token: 0x14000019 RID: 25
		// (add) Token: 0x060006C7 RID: 1735 RVA: 0x0001D77D File Offset: 0x0001B97D
		// (remove) Token: 0x060006C8 RID: 1736 RVA: 0x0001D78B File Offset: 0x0001B98B
		public event global::System.EventHandler<global::Infragistics.Windows.Controls.Events.ExecutedCommandEventArgs> ExecutedCommand
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.Editors.XamMaskedEditor.ExecutedCommandEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.Editors.XamMaskedEditor.ExecutedCommandEvent, value);
			}
		}

		// Token: 0x060006C9 RID: 1737 RVA: 0x0001D799 File Offset: 0x0001B999
		public bool ExecuteCommand(global::Infragistics.Windows.Commands.CommandWrapper commandWrapper)
		{
			if (commandWrapper == null)
			{
				throw new global::System.ArgumentNullException("commandWrapper");
			}
			return this.ExecuteCommandImpl(commandWrapper.Command, null);
		}

		// Token: 0x060006CA RID: 1738 RVA: 0x0001D7B6 File Offset: 0x0001B9B6
		public bool ExecuteCommand(global::System.Windows.Input.RoutedCommand command)
		{
			return this.ExecuteCommandImpl(command, null);
		}

		// Token: 0x060006CB RID: 1739 RVA: 0x0001D7C0 File Offset: 0x0001B9C0
		private bool ExecuteCommandImpl(global::System.Windows.Input.RoutedCommand command, object commandParameter)
		{
			if (command == null)
			{
				throw new global::System.ArgumentNullException("command");
			}
			if (!global::Infragistics.Windows.Commands.Commands<global::Infragistics.Windows.Editors.XamMaskedEditor>.IsMinimumStatePresentForCommand(this, command))
			{
				return false;
			}
			global::Infragistics.Windows.Controls.Events.ExecutingCommandEventArgs executingCommandEventArgs = new global::Infragistics.Windows.Controls.Events.ExecutingCommandEventArgs(command);
			if (!this.RaiseExecutingCommand(executingCommandEventArgs))
			{
				return !executingCommandEventArgs.ContinueKeyRouting;
			}
			bool shift = (global::System.Windows.Input.Keyboard.Modifiers & global::System.Windows.Input.ModifierKeys.Shift) != global::System.Windows.Input.ModifierKeys.None;
			bool control = (global::System.Windows.Input.Keyboard.Modifiers & global::System.Windows.Input.ModifierKeys.Control) != global::System.Windows.Input.ModifierKeys.None;
			global::System.Windows.Input.Keyboard.IsKeyDown(global::System.Windows.Input.Key.Tab);
			bool flag = false;
			if (base.IsInEditMode && this.EditInfo != null && this.EditInfo.ExecuteCommandImpl(command, commandParameter, shift, control))
			{
				flag = true;
			}
			if (flag)
			{
				this.RaiseExecutedCommand(new global::Infragistics.Windows.Controls.Events.ExecutedCommandEventArgs(command));
			}
			return flag;
		}

		// Token: 0x060006CC RID: 1740 RVA: 0x0001D85E File Offset: 0x0001BA5E
		protected internal virtual string GetDefaultMask(global::System.Type dataType, global::System.IFormatProvider formatProvider)
		{
			return null;
		}

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x060006CD RID: 1741 RVA: 0x0001D861 File Offset: 0x0001BA61
		// (set) Token: 0x060006CE RID: 1742 RVA: 0x0001D873 File Offset: 0x0001BA73
		public global::Infragistics.Windows.Editors.MaskSelectAllBehavior SelectAllBehavior
		{
			get
			{
				return (global::Infragistics.Windows.Editors.MaskSelectAllBehavior)base.GetValue(global::Infragistics.Windows.Editors.XamMaskedEditor.SelectAllBehaviorProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.XamMaskedEditor.SelectAllBehaviorProperty, value);
			}
		}

		// Token: 0x060006CF RID: 1743 RVA: 0x0001D886 File Offset: 0x0001BA86
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeSelectAllBehavior()
		{
			return global::Infragistics.Windows.Utilities.ShouldSerialize(global::Infragistics.Windows.Editors.XamMaskedEditor.SelectAllBehaviorProperty, this);
		}

		// Token: 0x060006D0 RID: 1744 RVA: 0x0001D893 File Offset: 0x0001BA93
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetSelectAllBehavior()
		{
			base.ClearValue(global::Infragistics.Windows.Editors.XamMaskedEditor.SelectAllBehaviorProperty);
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x060006D1 RID: 1745 RVA: 0x0001D8A0 File Offset: 0x0001BAA0
		// (set) Token: 0x060006D2 RID: 1746 RVA: 0x0001D8B2 File Offset: 0x0001BAB2
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.Editors.AutoFillDate AutoFillDate
		{
			get
			{
				return (global::Infragistics.Windows.Editors.AutoFillDate)base.GetValue(global::Infragistics.Windows.Editors.XamMaskedEditor.AutoFillDateProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.XamMaskedEditor.AutoFillDateProperty, value);
			}
		}

		// Token: 0x060006D3 RID: 1747 RVA: 0x0001D8C5 File Offset: 0x0001BAC5
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeAutoFillDate()
		{
			return global::Infragistics.Windows.Utilities.ShouldSerialize(global::Infragistics.Windows.Editors.XamMaskedEditor.AutoFillDateProperty, this);
		}

		// Token: 0x060006D4 RID: 1748 RVA: 0x0001D8D2 File Offset: 0x0001BAD2
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetAutoFillDate()
		{
			base.ClearValue(global::Infragistics.Windows.Editors.XamMaskedEditor.AutoFillDateProperty);
		}

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x060006D5 RID: 1749 RVA: 0x0001D8DF File Offset: 0x0001BADF
		protected override global::System.Windows.Data.IValueConverter DefaultValueToDisplayTextConverter
		{
			get
			{
				return global::Infragistics.Windows.Editors.MaskedEditorDefaultConverter.ValueToDisplayTextConverter;
			}
		}

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x060006D6 RID: 1750 RVA: 0x0001D8E6 File Offset: 0x0001BAE6
		protected override global::System.Windows.Data.IValueConverter DefaultValueToTextConverter
		{
			get
			{
				return global::Infragistics.Windows.Editors.MaskedEditorDefaultConverter.ValueToTextConverter;
			}
		}

		// Token: 0x060006D7 RID: 1751 RVA: 0x0001D8ED File Offset: 0x0001BAED
		protected internal override void ProcessKeyDown(global::System.Windows.Input.KeyEventArgs e)
		{
			base.ProcessKeyDown(e);
			if (e.Handled)
			{
				return;
			}
			if (this.Commands != null && this.Commands.ProcessKeyboardInput(e, this))
			{
				e.Handled = true;
			}
		}

		// Token: 0x060006D8 RID: 1752 RVA: 0x0001D920 File Offset: 0x0001BB20
		protected override void OnTextInput(global::System.Windows.Input.TextCompositionEventArgs e)
		{
			base.OnTextInput(e);
			if (!e.Handled && base.IsInEditMode && this.EditInfo != null && e.Text != null && e.Text.Length > 0)
			{
				this.EditInfo.ProcessTextInput(e, true);
			}
		}

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x060006D9 RID: 1753 RVA: 0x0001D96F File Offset: 0x0001BB6F
		protected global::Infragistics.Windows.Commands.CommandsBase Commands
		{
			get
			{
				return global::Infragistics.Windows.Editors.MaskedEditorCommands.Instance;
			}
		}

		// Token: 0x060006DA RID: 1754 RVA: 0x0001D978 File Offset: 0x0001BB78
		long global::Infragistics.Windows.Commands.ICommandHost.GetCurrentState(long statesToQuery)
		{
			global::Infragistics.Windows.Editors.EditInfo editInfo = this.EditInfo;
			if (editInfo != null)
			{
				return (long)editInfo.GetCurrentState((global::Infragistics.Windows.Editors.MaskedEditorStates)statesToQuery);
			}
			return 0L;
		}

		// Token: 0x060006DB RID: 1755 RVA: 0x0001D99C File Offset: 0x0001BB9C
		bool global::Infragistics.Windows.Commands.ICommandHost.CanExecute(global::Infragistics.Windows.Commands.ExecuteCommandInfo commandInfo)
		{
			global::System.Windows.Input.RoutedCommand routedCommand = commandInfo.RoutedCommand;
			object parameter = commandInfo.Parameter;
			if (base.IsInEditMode && this.EditInfo != null)
			{
				global::Infragistics.Windows.Editors.EditInfo editInfo = this.EditInfo;
				global::Infragistics.Windows.Editors.MaskedEditorStates currentState = editInfo.CurrentState;
				bool isReadOnly = base.IsReadOnly;
				if (isReadOnly && (global::Infragistics.Windows.Editors.MaskedEditorCommands.Delete == routedCommand || global::Infragistics.Windows.Editors.MaskedEditorCommands.Cut == routedCommand || global::Infragistics.Windows.Editors.MaskedEditorCommands.Paste == routedCommand || global::Infragistics.Windows.Editors.MaskedEditorCommands.Undo == routedCommand || global::Infragistics.Windows.Editors.MaskedEditorCommands.Redo == routedCommand))
				{
					return false;
				}
				if (global::Infragistics.Windows.Editors.MaskedEditorCommands.Delete == routedCommand)
				{
					if ((global::Infragistics.Windows.Editors.MaskedEditorStates)0L == (global::Infragistics.Windows.Editors.MaskedEditorStates.AfterLastCharacter & currentState) || (global::Infragistics.Windows.Editors.MaskedEditorStates)0L != (global::Infragistics.Windows.Editors.MaskedEditorStates.Selected & currentState))
					{
						return true;
					}
				}
				else if (global::Infragistics.Windows.Editors.MaskedEditorCommands.Copy == routedCommand)
				{
					if ((global::Infragistics.Windows.Editors.MaskedEditorStates)0L != (global::Infragistics.Windows.Editors.MaskedEditorStates.Selected & currentState))
					{
						return true;
					}
				}
				else if (global::Infragistics.Windows.Editors.MaskedEditorCommands.Cut == routedCommand)
				{
					if ((global::Infragistics.Windows.Editors.MaskedEditorStates)0L != (global::Infragistics.Windows.Editors.MaskedEditorStates.Selected & currentState))
					{
						return true;
					}
				}
				else
				{
					if (global::Infragistics.Windows.Editors.MaskedEditorCommands.Paste == routedCommand)
					{
						return true;
					}
					if (global::Infragistics.Windows.Editors.MaskedEditorCommands.SelectAll == routedCommand)
					{
						return true;
					}
					if (global::Infragistics.Windows.Editors.MaskedEditorCommands.Undo == routedCommand)
					{
						if ((global::Infragistics.Windows.Editors.MaskedEditorStates)0L != (global::Infragistics.Windows.Editors.MaskedEditorStates.CanUndo & currentState))
						{
							return true;
						}
					}
					else if (global::Infragistics.Windows.Editors.MaskedEditorCommands.Redo == routedCommand)
					{
						if ((global::Infragistics.Windows.Editors.MaskedEditorStates)0L != (global::Infragistics.Windows.Editors.MaskedEditorStates.CanRedo & currentState))
						{
							return true;
						}
					}
					else if ((global::Infragistics.Windows.Editors.MaskedEditorCommands.SpinDown == routedCommand || global::Infragistics.Windows.Editors.MaskedEditorCommands.SpinUp == routedCommand) && editInfo.CanSpin(global::Infragistics.Windows.Editors.MaskedEditorCommands.SpinUp == routedCommand, parameter))
					{
						return true;
					}
				}
			}
			else
			{
				commandInfo.ContinueRouting = true;
			}
			return global::Infragistics.Windows.Editors.MaskedEditorCommands.NotACommand == routedCommand || (routedCommand != null && routedCommand.OwnerType == typeof(global::Infragistics.Windows.Editors.MaskedEditorCommands));
		}

		// Token: 0x060006DC RID: 1756 RVA: 0x0001DAF4 File Offset: 0x0001BCF4
		bool global::Infragistics.Windows.Commands.ICommandHost.Execute(global::Infragistics.Windows.Commands.ExecuteCommandInfo commandInfo)
		{
			global::System.Windows.Input.RoutedCommand routedCommand = commandInfo.RoutedCommand;
			return routedCommand != null && this.ExecuteCommandImpl(routedCommand, commandInfo.Parameter);
		}

		// Token: 0x060006DD RID: 1757 RVA: 0x0001DB1C File Offset: 0x0001BD1C
		private static void OnCaretVisibleChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Editors.XamMaskedEditor xamMaskedEditor = (global::Infragistics.Windows.Editors.XamMaskedEditor)dependencyObject;
			bool cachedCaretVisible = (bool)e.NewValue;
			xamMaskedEditor._cachedCaretVisible = cachedCaretVisible;
			xamMaskedEditor.NotifyDisplayCharDrawStringsChanged();
		}

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x060006DE RID: 1758 RVA: 0x0001DB4A File Offset: 0x0001BD4A
		// (set) Token: 0x060006DF RID: 1759 RVA: 0x0001DB52 File Offset: 0x0001BD52
		internal bool CaretVisible
		{
			get
			{
				return this._cachedCaretVisible;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.XamMaskedEditor.CaretVisibleProperty, global::Infragistics.KnownBoxes.FromValue(value));
			}
		}

		// Token: 0x060006E0 RID: 1760 RVA: 0x0001DB65 File Offset: 0x0001BD65
		private void ShowCaretElement()
		{
			if (!this.CaretVisible && !this.IsTextBoxEntryEnabled)
			{
				this.CaretVisible = true;
				base.AddVisualChild(this.CaretElement);
			}
		}

		// Token: 0x060006E1 RID: 1761 RVA: 0x0001DB8A File Offset: 0x0001BD8A
		private void HideCaretElement()
		{
			if (this.CaretVisible)
			{
				base.RemoveVisualChild(this.CaretElement);
				this.CaretVisible = false;
			}
		}

		// Token: 0x060006E2 RID: 1762 RVA: 0x0001DBA8 File Offset: 0x0001BDA8
		internal void ShowHideCaretHelper()
		{
			global::Infragistics.Windows.Editors.MaskInfo maskInfo = this.MaskInfo;
			global::Infragistics.Windows.Editors.EditInfo editInfo = this.EditInfo;
			bool flag = maskInfo != null && editInfo != null && maskInfo.IsBeingEditedAndFocused && !this.IsTextBoxEntryEnabled && 0 == editInfo.SelectionLength;
			if (flag)
			{
				this.ShowCaretElement();
				return;
			}
			this.HideCaretElement();
		}

		// Token: 0x060006E3 RID: 1763 RVA: 0x0001DBF6 File Offset: 0x0001BDF6
		internal void ResetCaretBlinking()
		{
			if (this._caretElement != null)
			{
				this._caretElement.ResetCaretBlinking();
			}
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x060006E4 RID: 1764 RVA: 0x0001DC0C File Offset: 0x0001BE0C
		protected override int VisualChildrenCount
		{
			get
			{
				int num = base.VisualChildrenCount;
				if (this.CaretVisible)
				{
					num++;
				}
				return num;
			}
		}

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x060006E5 RID: 1765 RVA: 0x0001DC2D File Offset: 0x0001BE2D
		internal global::Infragistics.Windows.Editors.CaretElement CaretElement
		{
			get
			{
				if (this._caretElement == null)
				{
					this._caretElement = new global::Infragistics.Windows.Editors.CaretElement();
				}
				return this._caretElement;
			}
		}

		// Token: 0x060006E6 RID: 1766 RVA: 0x0001DC48 File Offset: 0x0001BE48
		protected override global::System.Windows.Media.Visual GetVisualChild(int index)
		{
			if (this.CaretVisible && 1 + index == this.VisualChildrenCount)
			{
				return this.CaretElement;
			}
			return base.GetVisualChild(index);
		}

		// Token: 0x060006E7 RID: 1767 RVA: 0x0001DC6C File Offset: 0x0001BE6C
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size availableSize)
		{
			global::Infragistics.Windows.Editors.XamMaskedEditor.s_defaultCultureInfo = null;
			if (!base.IsInEditMode && global::System.Windows.DependencyProperty.UnsetValue == base.ReadLocalValue(global::System.Windows.FrameworkElement.MinHeightProperty) && global::System.Windows.DependencyProperty.UnsetValue == base.ReadLocalValue(global::System.Windows.FrameworkElement.HeightProperty))
			{
				global::Infragistics.Windows.Controls.SimpleTextBlock simpleTextBlock = (global::Infragistics.Windows.Controls.SimpleTextBlock)global::Infragistics.Windows.Utilities.GetDescendantFromType(this, typeof(global::Infragistics.Windows.Controls.SimpleTextBlock), true);
				if (simpleTextBlock != null)
				{
					simpleTextBlock.MinHeight = global::Infragistics.Windows.Editors.Utils.GetLineHeight(this);
				}
				else
				{
					global::System.Windows.Controls.TextBlock textBlock = (global::System.Windows.Controls.TextBlock)global::Infragistics.Windows.Utilities.GetDescendantFromType(this, typeof(global::System.Windows.Controls.TextBlock), true);
					if (textBlock != null)
					{
						textBlock.MinHeight = global::Infragistics.Windows.Editors.Utils.GetLineHeight(this);
					}
				}
			}
			global::System.Windows.Size result = base.MeasureOverride(availableSize);
			if (this.CaretVisible)
			{
				global::Infragistics.Windows.Editors.DisplayCharBase displayCharBase = this.EditInfo.GetDisplayCharAtPosition(this.CaretPosition);
				if (displayCharBase == null)
				{
					displayCharBase = this.EditInfo.LastDisplayChar;
				}
				global::Infragistics.Windows.Editors.DisplayCharacterPresenter displayCharacterPresenter = this.GetDisplayCharacterPresenter(displayCharBase);
				if (displayCharacterPresenter != null)
				{
					global::System.Windows.Size desiredSize = displayCharacterPresenter.DesiredSize;
					desiredSize.Width = double.PositiveInfinity;
					this.CaretElement.Measure(desiredSize);
				}
			}
			return result;
		}

		// Token: 0x060006E8 RID: 1768 RVA: 0x0001DD60 File Offset: 0x0001BF60
		protected override global::System.Windows.Size ArrangeOverride(global::System.Windows.Size finalSize)
		{
			global::System.Windows.Size result = base.ArrangeOverride(finalSize);
			if (this.CaretVisible)
			{
				bool flag = true;
				global::Infragistics.Windows.Editors.DisplayCharBase displayCharBase = this.EditInfo.GetDisplayCharAtPosition(this.CaretPosition);
				if (displayCharBase == null)
				{
					displayCharBase = this.EditInfo.LastDisplayChar;
					flag = false;
				}
				global::Infragistics.Windows.Editors.DisplayCharacterPresenter displayCharacterPresenter = this.GetDisplayCharacterPresenter(displayCharBase);
				if (displayCharacterPresenter != null)
				{
					global::System.Windows.Point point = new global::System.Windows.Point(0.0, 0.0);
					if (!flag)
					{
						point.X += displayCharacterPresenter.ActualWidth;
					}
					point = displayCharacterPresenter.TranslatePoint(point, this);
					global::System.Windows.Size desiredSize = this.CaretElement.DesiredSize;
					desiredSize.Height = displayCharacterPresenter.ActualHeight;
					global::System.Windows.Rect finalRect = new global::System.Windows.Rect(point, desiredSize);
					double num = finalSize.Height - finalRect.Top;
					if (finalRect.Height > num)
					{
						finalRect.Height = global::System.Math.Max(0.0, num);
					}
					this.CaretElement.Arrange(finalRect);
				}
			}
			return result;
		}

		// Token: 0x060006E9 RID: 1769 RVA: 0x0001DE54 File Offset: 0x0001C054
		internal global::System.Windows.Rect GetDisplayCharLocation(global::Infragistics.Windows.Editors.DisplayCharBase dc)
		{
			global::Infragistics.Windows.Editors.DisplayCharacterPresenter displayCharacterPresenter = this.GetDisplayCharacterPresenter(dc);
			if (displayCharacterPresenter != null)
			{
				global::System.Windows.Point location = displayCharacterPresenter.TranslatePoint(new global::System.Windows.Point(0.0, 0.0), this);
				global::System.Windows.Size size = new global::System.Windows.Size(displayCharacterPresenter.ActualWidth, displayCharacterPresenter.ActualHeight);
				return new global::System.Windows.Rect(location, size);
			}
			return global::System.Windows.Rect.Empty;
		}

		// Token: 0x060006EA RID: 1770 RVA: 0x0001DEC4 File Offset: 0x0001C0C4
		internal global::Infragistics.Windows.Editors.DisplayCharacterPresenter GetDisplayCharacterPresenter(global::Infragistics.Windows.Editors.DisplayCharBase dc)
		{
			global::Infragistics.Windows.Utilities.DependencyObjectSearchCallback<global::Infragistics.Windows.Editors.DisplayCharacterPresenter> callback = (global::Infragistics.Windows.Editors.DisplayCharacterPresenter presenter) => dc == presenter.DisplayCharacter;
			return global::Infragistics.Windows.Utilities.GetDescendantFromType<global::Infragistics.Windows.Editors.DisplayCharacterPresenter>(this, true, callback);
		}

		// Token: 0x060006EB RID: 1771 RVA: 0x0001DEF8 File Offset: 0x0001C0F8
		internal global::System.Collections.IList GetDisplayCharacterPresenters()
		{
			global::System.Collections.ArrayList arrayList = new global::System.Collections.ArrayList();
			if (base.IsInEditMode && this.MaskInfo != null)
			{
				foreach (object obj in this.MaskInfo.Sections.AllDisplayCharacters)
				{
					global::Infragistics.Windows.Editors.DisplayCharBase dc = (global::Infragistics.Windows.Editors.DisplayCharBase)obj;
					global::Infragistics.Windows.Editors.DisplayCharacterPresenter displayCharacterPresenter = this.GetDisplayCharacterPresenter(dc);
					if (displayCharacterPresenter != null)
					{
						arrayList.Add(displayCharacterPresenter);
					}
				}
			}
			return arrayList;
		}

		// Token: 0x060006EC RID: 1772 RVA: 0x0001DF84 File Offset: 0x0001C184
		internal bool IsMouseOverTemplateChild(string templateChildName, global::System.Windows.Input.MouseEventArgs mouseArgs)
		{
			global::System.Windows.DependencyObject dependencyObject;
			return this.IsMouseOverTemplateChild(templateChildName, mouseArgs, out dependencyObject);
		}

		// Token: 0x060006ED RID: 1773 RVA: 0x0001DF9B File Offset: 0x0001C19B
		internal bool IsMouseOverTemplateChild(string templateChildName, global::System.Windows.Input.MouseEventArgs mouseArgs, out global::System.Windows.DependencyObject templateChildElem)
		{
			templateChildElem = base.GetTemplateChild(templateChildName);
			return templateChildElem != null && global::Infragistics.Windows.Editors.Utils.IsMouseOverElement(templateChildElem, mouseArgs);
		}

		// Token: 0x060006EE RID: 1774 RVA: 0x0001DFB8 File Offset: 0x0001C1B8
		internal void SyncDrawAsSelectedOnDisplayPresenters()
		{
			if (base.IsInEditMode && this.EditInfo != null)
			{
				foreach (object obj in this.GetDisplayCharacterPresenters())
				{
					global::Infragistics.Windows.Editors.DisplayCharacterPresenter displayCharacterPresenter = (global::Infragistics.Windows.Editors.DisplayCharacterPresenter)obj;
					displayCharacterPresenter.SyncDrawAsSelected();
				}
			}
		}

		// Token: 0x060006EF RID: 1775 RVA: 0x0001E020 File Offset: 0x0001C220
		protected override void OnContextMenuOpening(global::System.Windows.Controls.ContextMenuEventArgs e)
		{
			if (!base.IsInEditMode)
			{
				return;
			}
			global::System.Windows.Controls.ContextMenu contextMenu = base.ContextMenu;
			if (base.ReadLocalValue(global::System.Windows.FrameworkElement.ContextMenuProperty) != null)
			{
				if (contextMenu != null)
				{
					contextMenu.Closed += this.OnContextMenuClosed;
					return;
				}
				global::System.Windows.UIElement uielement = e.OriginalSource as global::System.Windows.UIElement;
				global::System.Windows.FrameworkElement frameworkElement = base.FocusSite as global::System.Windows.FrameworkElement;
				if (uielement != null && frameworkElement != null)
				{
					global::System.Windows.Rect rect = new global::System.Windows.Rect(0.0, 0.0, frameworkElement.ActualWidth, frameworkElement.ActualHeight);
					global::System.Windows.Point point = uielement.TranslatePoint(new global::System.Windows.Point(e.CursorLeft, e.CursorTop), frameworkElement);
					if (!rect.Contains(point))
					{
						return;
					}
				}
				contextMenu = this.CreateContextMenu();
				contextMenu.Closed += this.OnContextMenuClosed;
				contextMenu.PlacementTarget = this;
				contextMenu.Placement = global::System.Windows.Controls.Primitives.PlacementMode.RelativePoint;
				global::System.Windows.Point point2 = default(global::System.Windows.Point);
				if (e.OriginalSource is global::System.Windows.UIElement)
				{
					point2 = base.TranslatePoint(point2, e.OriginalSource as global::System.Windows.UIElement);
				}
				contextMenu.HorizontalOffset = e.CursorLeft - point2.X;
				contextMenu.VerticalOffset = e.CursorTop - point2.Y;
				contextMenu.IsOpen = true;
				e.Handled = true;
				this._isDisplayingContextMenu = contextMenu.IsOpen;
				this.ProcessIsBeingEditedAndFocusedChanged();
			}
		}

		// Token: 0x060006F0 RID: 1776 RVA: 0x0001E168 File Offset: 0x0001C368
		private void OnContextMenuClosed(object sender, global::System.Windows.RoutedEventArgs e)
		{
			global::System.Windows.Controls.ContextMenu contextMenu = sender as global::System.Windows.Controls.ContextMenu;
			this._isDisplayingContextMenu = false;
			this.ProcessIsBeingEditedAndFocusedChanged();
			if (contextMenu != null)
			{
				contextMenu.Closed -= this.OnContextMenuClosed;
			}
		}

		// Token: 0x060006F1 RID: 1777 RVA: 0x0001E19E File Offset: 0x0001C39E
		protected override void OnMouseDoubleClick(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			base.OnMouseDoubleClick(e);
			if (this.EditInfo != null && global::Infragistics.Windows.Editors.Utils.IsMouseOverElement(this, e) && !global::Infragistics.Windows.Editors.Utils.IsMouseOverButton(this, e))
			{
				this.EditInfo.SelectAll();
				e.Handled = true;
			}
		}

		// Token: 0x060006F2 RID: 1778 RVA: 0x0001E1D4 File Offset: 0x0001C3D4
		protected override void OnMouseLeftButtonDown(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			bool flag = false;
			bool isInEditMode = base.IsInEditMode;
			if (!isInEditMode)
			{
				this._transitingIntoEditModeInMouseDown = true;
				this._transitingIntoEditModeInMouseDownPoint = e.GetPosition(this);
				flag = this.IsMouseOverTemplateChild("PART_SpinButtons", e);
			}
			try
			{
				base.OnMouseLeftButtonDown(e);
				if (isInEditMode && base.IsInEditMode && global::Infragistics.Windows.Editors.Utils.IsMouseOverElement(this, e) && (base.Host == null || base.Host._previewMouseLeftButtonDown_EnterEditMode_TimeStamp != e.Timestamp))
				{
					global::Infragistics.Windows.Editors.EditInfo editInfo = this.EditInfo;
					if (editInfo != null)
					{
						editInfo.MaskedEditUIElementClicked(e.GetPosition(this));
						base.CaptureMouse();
						if (base.IsMouseCaptured)
						{
							this._isDragSelecting = true;
						}
					}
				}
				global::System.Windows.DependencyObject dependencyObject;
				if (flag && this.IsMouseOverTemplateChild("PART_SpinButtons", e, out dependencyObject))
				{
					global::System.Windows.Controls.Primitives.ButtonBase buttonBase = global::Infragistics.Windows.Editors.Utils.HitTest(this, e.GetPosition(this), typeof(global::System.Windows.Controls.Primitives.ButtonBase), true) as global::System.Windows.Controls.Primitives.ButtonBase;
					if (buttonBase != null)
					{
						global::Infragistics.Windows.Editors.Utils.SendLeftMouseButtonDownHelper(buttonBase, e);
					}
				}
			}
			finally
			{
				if (this._transitingIntoEditModeInMouseDown)
				{
					this._transitingIntoEditModeInMouseDown = false;
					this.ProcessIsBeingEditedAndFocusedChanged();
				}
			}
		}

		// Token: 0x060006F3 RID: 1779 RVA: 0x0001E2D8 File Offset: 0x0001C4D8
		protected override void OnMouseUp(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			base.OnMouseUp(e);
			if (e.Device != null && e.Device.Target != null)
			{
				this._isDragSelecting = false;
				e.Device.Target.ReleaseMouseCapture();
			}
		}

		// Token: 0x060006F4 RID: 1780 RVA: 0x0001E30D File Offset: 0x0001C50D
		protected override void OnLostMouseCapture(global::System.Windows.Input.MouseEventArgs e)
		{
			this._isDragSelecting = false;
			base.OnLostMouseCapture(e);
		}

		// Token: 0x060006F5 RID: 1781 RVA: 0x0001E31D File Offset: 0x0001C51D
		protected override void OnMouseLeftButtonUp(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			base.OnMouseLeftButtonUp(e);
			if (this.EditInfo != null)
			{
				this.EditInfo.MaskedEditUIElementMouseUp(e.GetPosition(this));
				e.Handled = true;
			}
		}

		// Token: 0x060006F6 RID: 1782 RVA: 0x0001E348 File Offset: 0x0001C548
		protected override void OnMouseMove(global::System.Windows.Input.MouseEventArgs e)
		{
			base.OnMouseMove(e);
			if (this._isDragSelecting && this.EditInfo != null && e.Device != null && e.Device.Target != null && e.Device.Target.IsMouseCaptured)
			{
				this.EditInfo.MouseDragged(e.GetPosition(this));
				e.Handled = true;
			}
		}

		// Token: 0x04000236 RID: 566
		internal const char DEFAULT_PROMPT_CHAR = '_';

		// Token: 0x04000237 RID: 567
		internal const char DEFAULT_PAD_CHAR = ' ';

		// Token: 0x04000238 RID: 568
		internal const string LOCALIZED_ESCAPE_SEQUENCE = "{LOC}";

		// Token: 0x04000239 RID: 569
		private global::Infragistics.Windows.Licensing.UltraLicense _license;

		// Token: 0x0400023A RID: 570
		private global::Infragistics.Windows.Editors.EditInfo _editInfo;

		// Token: 0x0400023B RID: 571
		private global::Infragistics.Windows.Editors.MaskInfo _maskInfo;

		// Token: 0x0400023C RID: 572
		private global::Infragistics.Windows.Editors.SectionsCollection _displayChars_Sections;

		// Token: 0x0400023D RID: 573
		private global::Infragistics.Windows.Editors.DisplayCharsCollection _displayChars;

		// Token: 0x0400023E RID: 574
		private bool _displayNullTextWhenNotFocused;

		// Token: 0x0400023F RID: 575
		private static string g_lastShortDatePattern;

		// Token: 0x04000240 RID: 576
		private static char g_lastDateSeparator;

		// Token: 0x04000241 RID: 577
		private static string g_lastDefaultDateMask;

		// Token: 0x04000242 RID: 578
		private static global::System.IFormatProvider g_lastDateFormatProvider;

		// Token: 0x04000243 RID: 579
		private static bool g_lastUsePostfixSeparatorsFromLongDatePattern;

		// Token: 0x04000244 RID: 580
		private static string g_lastShortTimePattern;

		// Token: 0x04000245 RID: 581
		private static char g_lastTimeSeparator;

		// Token: 0x04000246 RID: 582
		private static string g_lastDefaultTimeMask;

		// Token: 0x04000247 RID: 583
		private static global::System.Collections.Hashtable g_defaultMaskTable = new global::System.Collections.Hashtable();

		// Token: 0x04000248 RID: 584
		private static bool g_defaultMaskTableInitialized = false;

		// Token: 0x04000249 RID: 585
		private bool _allowShiftingAcrossSections = true;

		// Token: 0x0400024A RID: 586
		internal bool _isDisplayingContextMenu;

		// Token: 0x0400024B RID: 587
		internal bool _transitingIntoEditModeInMouseDown;

		// Token: 0x0400024C RID: 588
		internal global::System.Windows.Point _transitingIntoEditModeInMouseDownPoint = default(global::System.Windows.Point);

		// Token: 0x0400024D RID: 589
		private bool _isDragSelecting;

		// Token: 0x0400024E RID: 590
		internal global::Infragistics.Windows.Editors.SpinInfo _cachedSpinInfo;

		// Token: 0x0400024F RID: 591
		private bool _skipNextMaskValidation;

		// Token: 0x04000250 RID: 592
		private bool _resetIsTextBoxEntryEnabledWhenEditModeEnds;

		// Token: 0x04000251 RID: 593
		private bool _cachedTrimFractionalZeros;

		// Token: 0x04000252 RID: 594
		internal static bool _IsTouchEnabled;

		// Token: 0x04000254 RID: 596
		[global::System.ThreadStatic]
		private static global::System.Globalization.CultureInfo s_defaultCultureInfo;

		// Token: 0x04000255 RID: 597
		public static readonly global::System.Windows.DependencyProperty TrimFractionalZerosProperty = global::System.Windows.DependencyProperty.Register("TrimFractionalZeros", typeof(bool), typeof(global::Infragistics.Windows.Editors.XamMaskedEditor), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.XamMaskedEditor.OnTrimFractionalZerosChanged)));

		// Token: 0x04000256 RID: 598
		public static readonly global::System.Windows.DependencyProperty SpinButtonDisplayModeProperty = global::System.Windows.DependencyProperty.Register("SpinButtonDisplayMode", typeof(global::Infragistics.Windows.Editors.SpinButtonDisplayMode), typeof(global::Infragistics.Windows.Editors.XamMaskedEditor), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.Editors.SpinButtonDisplayMode.Never));

		// Token: 0x04000257 RID: 599
		public static readonly global::System.Windows.DependencyProperty SpinButtonStyleProperty = global::System.Windows.DependencyProperty.Register("SpinButtonStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Windows.Editors.XamMaskedEditor), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.None));

		// Token: 0x04000258 RID: 600
		private static readonly global::System.Windows.DependencyPropertyKey SpinButtonVisibilityResolvedPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("SpinButtonVisibilityResolved", typeof(global::System.Windows.Visibility), typeof(global::Infragistics.Windows.Editors.XamMaskedEditor), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Visibility.Collapsed));

		// Token: 0x04000259 RID: 601
		public static readonly global::System.Windows.DependencyProperty SpinButtonVisibilityResolvedProperty = global::Infragistics.Windows.Editors.XamMaskedEditor.SpinButtonVisibilityResolvedPropertyKey.DependencyProperty;

		// Token: 0x0400025A RID: 602
		public static readonly global::System.Windows.DependencyProperty SpinIncrementProperty = global::System.Windows.DependencyProperty.Register("SpinIncrement", typeof(object), typeof(global::Infragistics.Windows.Editors.XamMaskedEditor), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.None, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.XamMaskedEditor.OnSpinIncrementChanged)));

		// Token: 0x0400025B RID: 603
		public static readonly global::System.Windows.DependencyProperty SpinWrapProperty = global::System.Windows.DependencyProperty.Register("SpinWrap", typeof(bool), typeof(global::Infragistics.Windows.Editors.XamMaskedEditor), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x0400025C RID: 604
		private static readonly global::System.Windows.DependencyPropertyKey SectionsPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("Sections", typeof(global::Infragistics.Windows.Editors.SectionsCollection), typeof(global::Infragistics.Windows.Editors.XamMaskedEditor), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.None, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.XamMaskedEditor.OnSectionsChanged)));

		// Token: 0x0400025D RID: 605
		public static readonly global::System.Windows.DependencyProperty SectionsProperty = global::Infragistics.Windows.Editors.XamMaskedEditor.SectionsPropertyKey.DependencyProperty;

		// Token: 0x0400025E RID: 606
		private static readonly global::System.Windows.DependencyPropertyKey IsTextBoxEntryEnabledPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("IsTextBoxEntryEnabled", typeof(bool), typeof(global::Infragistics.Windows.Editors.XamMaskedEditor), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, global::System.Windows.FrameworkPropertyMetadataOptions.None));

		// Token: 0x0400025F RID: 607
		public static readonly global::System.Windows.DependencyProperty IsTextBoxEntryEnabledProperty = global::Infragistics.Windows.Editors.XamMaskedEditor.IsTextBoxEntryEnabledPropertyKey.DependencyProperty;

		// Token: 0x04000260 RID: 608
		public static readonly global::System.Windows.DependencyProperty InsertModeProperty = global::System.Windows.DependencyProperty.Register("InsertMode", typeof(bool), typeof(global::Infragistics.Windows.Editors.XamMaskedEditor), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.TrueBox));

		// Token: 0x04000261 RID: 609
		public static readonly global::System.Windows.DependencyProperty MaskProperty = global::System.Windows.DependencyProperty.Register("Mask", typeof(string), typeof(global::Infragistics.Windows.Editors.XamMaskedEditor), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.None, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.XamMaskedEditor.OnMaskChanged)));

		// Token: 0x04000262 RID: 610
		private string _cachedMask;

		// Token: 0x04000263 RID: 611
		public static readonly global::System.Windows.DependencyProperty DataModeProperty = global::System.Windows.DependencyProperty.Register("DataMode", typeof(global::Infragistics.Windows.Editors.MaskMode), typeof(global::Infragistics.Windows.Editors.XamMaskedEditor), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.Editors.MaskMode.IncludeLiterals, global::System.Windows.FrameworkPropertyMetadataOptions.None, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.XamMaskedEditor.OnDataModeChanged)));

		// Token: 0x04000264 RID: 612
		private global::Infragistics.Windows.Editors.MaskMode _cachedDataMode;

		// Token: 0x04000265 RID: 613
		public static readonly global::System.Windows.DependencyProperty ClipModeProperty = global::System.Windows.DependencyProperty.Register("ClipMode", typeof(global::Infragistics.Windows.Editors.MaskMode), typeof(global::Infragistics.Windows.Editors.XamMaskedEditor), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.Editors.MaskMode.IncludeLiterals, global::System.Windows.FrameworkPropertyMetadataOptions.None, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.XamMaskedEditor.OnClipModeChanged)));

		// Token: 0x04000266 RID: 614
		private global::Infragistics.Windows.Editors.MaskMode _cachedClipMode;

		// Token: 0x04000267 RID: 615
		public static readonly global::System.Windows.DependencyProperty DisplayModeProperty = global::System.Windows.DependencyProperty.Register("DisplayMode", typeof(global::Infragistics.Windows.Editors.MaskMode), typeof(global::Infragistics.Windows.Editors.XamMaskedEditor), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.Editors.MaskMode.IncludeLiterals, global::System.Windows.FrameworkPropertyMetadataOptions.None, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.XamMaskedEditor.OnDisplayModeChanged)));

		// Token: 0x04000268 RID: 616
		private global::Infragistics.Windows.Editors.MaskMode _cachedDisplayMode;

		// Token: 0x04000269 RID: 617
		public static readonly global::System.Windows.DependencyProperty PadCharProperty = global::System.Windows.DependencyProperty.Register("PadChar", typeof(char), typeof(global::Infragistics.Windows.Editors.XamMaskedEditor), new global::System.Windows.FrameworkPropertyMetadata(' ', global::System.Windows.FrameworkPropertyMetadataOptions.None, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.XamMaskedEditor.OnPadCharChanged)), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.Editors.XamMaskedEditor.ValidatePadChar));

		// Token: 0x0400026A RID: 618
		private char _cachedPadChar;

		// Token: 0x0400026B RID: 619
		public static readonly global::System.Windows.DependencyProperty PromptCharProperty = global::System.Windows.DependencyProperty.Register("PromptChar", typeof(char), typeof(global::Infragistics.Windows.Editors.XamMaskedEditor), new global::System.Windows.FrameworkPropertyMetadata('_', global::System.Windows.FrameworkPropertyMetadataOptions.None, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.XamMaskedEditor.OnPromptCharChanged)), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.Editors.XamMaskedEditor.ValidatePromptChar));

		// Token: 0x0400026C RID: 620
		private char _cachedPromptChar;

		// Token: 0x0400026D RID: 621
		public static readonly global::System.Windows.DependencyProperty TabNavigationProperty = global::System.Windows.DependencyProperty.Register("TabNavigation", typeof(global::Infragistics.Windows.Editors.MaskedEditTabNavigation), typeof(global::Infragistics.Windows.Editors.XamMaskedEditor), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.Editors.MaskedEditTabNavigation.NextControl, global::System.Windows.FrameworkPropertyMetadataOptions.None, null));

		// Token: 0x0400026E RID: 622
		internal static readonly global::System.Windows.DependencyProperty CaretPositionProperty = global::System.Windows.DependencyProperty.Register("CaretPosition", typeof(int), typeof(global::Infragistics.Windows.Editors.XamMaskedEditor), new global::System.Windows.FrameworkPropertyMetadata(0, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsArrange, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.XamMaskedEditor.OnCaretPositionChanged), new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.Editors.XamMaskedEditor.OnCoerceCaretPosition)));

		// Token: 0x0400026F RID: 623
		internal static readonly global::System.Windows.DependencyProperty PivotPositionProperty = global::System.Windows.DependencyProperty.Register("PivotPosition", typeof(int), typeof(global::Infragistics.Windows.Editors.XamMaskedEditor), new global::System.Windows.FrameworkPropertyMetadata(0, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsArrange, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.XamMaskedEditor.OnPivotPositionChanged), new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.Editors.XamMaskedEditor.OnCoercePivotPosition)));

		// Token: 0x04000272 RID: 626
		public static readonly global::System.Windows.DependencyProperty SelectAllBehaviorProperty;

		// Token: 0x04000273 RID: 627
		public static readonly global::System.Windows.DependencyProperty AutoFillDateProperty;

		// Token: 0x04000274 RID: 628
		internal static readonly global::System.Windows.DependencyProperty CaretVisibleProperty;

		// Token: 0x04000275 RID: 629
		private bool _cachedCaretVisible;

		// Token: 0x04000276 RID: 630
		private global::Infragistics.Windows.Editors.CaretElement _caretElement;

		// Token: 0x02000072 RID: 114
		private class ContextMenuHelper
		{
			// Token: 0x060006F7 RID: 1783 RVA: 0x0001E3AC File Offset: 0x0001C5AC
			internal ContextMenuHelper(global::Infragistics.Windows.Editors.XamMaskedEditor editor, global::System.Windows.Controls.ContextMenu menu)
			{
				this._menu = menu;
				this._editor = editor;
				menu.Opened += this.OnMenuOpened;
				menu.Closed += this.OnMenuClosed;
			}

			// Token: 0x060006F8 RID: 1784 RVA: 0x0001E3E6 File Offset: 0x0001C5E6
			private void OnMenuClosed(object sender, global::System.Windows.RoutedEventArgs e)
			{
				this._menu.Items.Clear();
			}

			// Token: 0x060006F9 RID: 1785 RVA: 0x0001E3F8 File Offset: 0x0001C5F8
			private void OnMenuOpened(object sender, global::System.Windows.RoutedEventArgs e)
			{
				this._menu.Items.Clear();
				global::Infragistics.Windows.Editors.XamMaskedEditor.InitializeContextMenu(this._editor, this._menu);
			}

			// Token: 0x04000277 RID: 631
			private global::Infragistics.Windows.Editors.XamMaskedEditor _editor;

			// Token: 0x04000278 RID: 632
			private global::System.Windows.Controls.ContextMenu _menu;
		}
	}
}
