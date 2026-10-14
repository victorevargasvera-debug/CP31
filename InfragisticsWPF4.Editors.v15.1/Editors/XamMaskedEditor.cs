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
using Infragistics.Themes;
using Infragistics.Windows.Automation.Peers.Editors;
using Infragistics.Windows.Commands;
using Infragistics.Windows.Controls;
using Infragistics.Windows.Controls.Events;
using Infragistics.Windows.Editors.Events;
using Infragistics.Windows.Licensing;

namespace Infragistics.Windows.Editors
{
	// Token: 0x02000077 RID: 119
	[global::Infragistics.Windows.Licensing.UltraLicense("XamMaskedEditor")]
	[global::System.Windows.TemplatePart(Name = "PART_InputTextBox", Type = typeof(global::System.Windows.Controls.TextBox))]
	[global::System.Windows.StyleTypedProperty(Property = "SpinButtonStyle", StyleTargetType = typeof(global::System.Windows.Controls.Primitives.RepeatButton))]
	[global::System.Windows.Markup.ContentProperty("Value")]
	[global::System.ComponentModel.LicenseProvider(typeof(global::Infragistics.Windows.Licensing.UltraLicenseProvider))]
	[global::System.Windows.TemplatePart(Name = "PART_SpinButtons", Type = typeof(global::System.Windows.FrameworkElement))]
	public class XamMaskedEditor : global::Infragistics.Windows.Editors.TextEditorBase, global::Infragistics.Windows.Commands.ICommandHost, global::Infragistics.Windows.Editors.ISupportsSelectableText
	{
		// Token: 0x14000017 RID: 23
		// (add) Token: 0x06000656 RID: 1622 RVA: 0x00019FEC File Offset: 0x000181EC
		// (remove) Token: 0x06000657 RID: 1623 RVA: 0x0001A024 File Offset: 0x00018224
		public event global::System.EventHandler<global::Infragistics.Windows.Editors.Events.InvalidCharEventArgs> InvalidChar;

		// Token: 0x06000658 RID: 1624 RVA: 0x0001A05C File Offset: 0x0001825C
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
			global::Infragistics.Themes.ThemeManager.RegisterControl(typeof(global::Infragistics.Windows.Editors.XamMaskedEditor));
		}

		// Token: 0x06000659 RID: 1625 RVA: 0x0001A62C File Offset: 0x0001882C
		public XamMaskedEditor()
		{
			try
			{
				this._license = (global::System.ComponentModel.LicenseManager.Validate(typeof(global::Infragistics.Windows.Editors.XamMaskedEditor), this) as global::Infragistics.Windows.Licensing.UltraLicense);
			}
			catch (global::System.IO.FileNotFoundException)
			{
			}
			global::Infragistics.Themes.ThemeManager.RegisterControl(typeof(global::Infragistics.Windows.Editors.XamMaskedEditor));
			this.InitializeCachedPropertyValues();
		}

		// Token: 0x0600065A RID: 1626 RVA: 0x0001A690 File Offset: 0x00018890
		public override bool CanEditType(global::System.Type type)
		{
			return global::Infragistics.Windows.Editors.XamMaskedEditor.SupportsDataType(type);
		}

		// Token: 0x0600065B RID: 1627 RVA: 0x0001A698 File Offset: 0x00018898
		public override bool CanRenderType(global::System.Type type)
		{
			return this.CanEditType(type);
		}

		// Token: 0x0600065C RID: 1628 RVA: 0x0001A6A1 File Offset: 0x000188A1
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override bool IsExtentBasedOnValue(global::System.Windows.Controls.Orientation orientation)
		{
			return orientation == global::System.Windows.Controls.Orientation.Horizontal;
		}

		// Token: 0x0600065D RID: 1629 RVA: 0x0001A6A9 File Offset: 0x000188A9
		protected override global::System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
		{
			return new global::Infragistics.Windows.Automation.Peers.Editors.XamMaskedEditorAutomationPeer(this);
		}

		// Token: 0x0600065E RID: 1630 RVA: 0x0001A6B4 File Offset: 0x000188B4
		protected override void DoInitialization()
		{
			base.DoInitialization();
			global::Infragistics.Windows.Editors.MaskInfo maskInfo = this.MaskInfo;
			maskInfo.RecreateSections(true);
			maskInfo.InternalRefreshValue(base.Value);
			this.ApplyMaskToText();
		}

		// Token: 0x0600065F RID: 1631 RVA: 0x0001A6E8 File Offset: 0x000188E8
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

		// Token: 0x06000660 RID: 1632 RVA: 0x0001A770 File Offset: 0x00018970
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

		// Token: 0x06000661 RID: 1633 RVA: 0x0001A814 File Offset: 0x00018A14
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

		// Token: 0x06000662 RID: 1634 RVA: 0x0001A870 File Offset: 0x00018A70
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

		// Token: 0x06000663 RID: 1635 RVA: 0x0001A8E4 File Offset: 0x00018AE4
		protected override void OnEditModeEnding(global::Infragistics.Windows.Editors.Events.EditModeEndingEventArgs args)
		{
			base.OnEditModeEnding(args);
			if (!args.Cancel && this._editInfo != null && this._editInfo._imeTextBox != null && this._editInfo._imeTextBox.IsKeyboardFocused)
			{
				base.Focus();
			}
		}

		// Token: 0x06000664 RID: 1636 RVA: 0x0001A924 File Offset: 0x00018B24
		protected override void OnFocusSiteChanged()
		{
			base.OnFocusSiteChanged();
			global::Infragistics.Windows.Editors.EditInfo editInfo = this.EditInfo;
			if (editInfo != null)
			{
				editInfo.InitializeIMETextBox(base.FocusSite);
			}
		}

		// Token: 0x06000665 RID: 1637 RVA: 0x0001A950 File Offset: 0x00018B50
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

		// Token: 0x06000666 RID: 1638 RVA: 0x0001A981 File Offset: 0x00018B81
		internal override void OnValueConstraintChanged(string valueConstraintPropertyName)
		{
			if (this._maskInfo != null)
			{
				this._maskInfo.InitializedCachedMinMaxValues();
			}
			base.OnValueConstraintChanged(valueConstraintPropertyName);
		}

		// Token: 0x06000667 RID: 1639 RVA: 0x0001A9A0 File Offset: 0x00018BA0
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

		// Token: 0x06000668 RID: 1640 RVA: 0x0001AA88 File Offset: 0x00018C88
		internal bool ResolveMask(global::System.Type dataType, global::System.IFormatProvider formatProvider, out string mask)
		{
			global::Infragistics.Windows.Editors.MaskDefaultType maskDefaultType;
			return this.ResolveMask(dataType, formatProvider, out mask, out maskDefaultType);
		}

		// Token: 0x06000669 RID: 1641 RVA: 0x0001AAA0 File Offset: 0x00018CA0
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

		// Token: 0x0600066A RID: 1642 RVA: 0x0001AB0C File Offset: 0x00018D0C
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

		// Token: 0x0600066B RID: 1643 RVA: 0x0001AF08 File Offset: 0x00019108
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

		// Token: 0x0600066C RID: 1644 RVA: 0x0001AFA2 File Offset: 0x000191A2
		internal static int ConvertToFourYear(int twoYear, global::System.Globalization.Calendar calendar)
		{
			if (twoYear < 100)
			{
				return calendar.ToFourDigitYear(twoYear);
			}
			return twoYear;
		}

		// Token: 0x0600066D RID: 1645 RVA: 0x0001AFB4 File Offset: 0x000191B4
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

		// Token: 0x0600066E RID: 1646 RVA: 0x0001AFE4 File Offset: 0x000191E4
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

		// Token: 0x0600066F RID: 1647 RVA: 0x0001B068 File Offset: 0x00019268
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

		// Token: 0x06000670 RID: 1648 RVA: 0x0001B3F0 File Offset: 0x000195F0
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

		// Token: 0x06000671 RID: 1649 RVA: 0x0001B4AC File Offset: 0x000196AC
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

		// Token: 0x06000672 RID: 1650 RVA: 0x0001B518 File Offset: 0x00019718
		internal static string GetText(global::Infragistics.Windows.Editors.SectionsCollection sections, global::Infragistics.Windows.Editors.MaskMode maskMode, global::Infragistics.Windows.Editors.MaskInfo maskInfo)
		{
			return global::Infragistics.Windows.Editors.XamMaskedEditor.GetText(sections, maskMode, (maskInfo != null) ? maskInfo.PromptChar : '_', (maskInfo != null) ? maskInfo.PadChar : ' ');
		}

		// Token: 0x06000673 RID: 1651 RVA: 0x0001B53B File Offset: 0x0001973B
		internal static string GetText(global::Infragistics.Windows.Editors.SectionsCollection sections, global::Infragistics.Windows.Editors.MaskMode maskMode, global::Infragistics.Windows.Editors.MaskInfo maskInfo, string nullText)
		{
			if (global::Infragistics.Windows.Editors.XamMaskedEditor.AreAllDisplayCharsEmpty(sections))
			{
				return nullText;
			}
			return global::Infragistics.Windows.Editors.XamMaskedEditor.GetText(sections, maskMode, (maskInfo != null) ? maskInfo.PromptChar : '_', (maskInfo != null) ? maskInfo.PadChar : ' ');
		}

		// Token: 0x06000674 RID: 1652 RVA: 0x0001B568 File Offset: 0x00019768
		internal static int SetText(global::Infragistics.Windows.Editors.SectionsCollection sections, string text, char promptCharacter, char padCharacter)
		{
			return global::Infragistics.Windows.Editors.XamMaskedEditor.SetText(sections, text, promptCharacter, padCharacter, true);
		}

		// Token: 0x06000675 RID: 1653 RVA: 0x0001B574 File Offset: 0x00019774
		internal static bool MatchesNextLiteralChar(global::Infragistics.Windows.Editors.DisplayCharBase dc, char c)
		{
			global::Infragistics.Windows.Editors.DisplayCharBase nextLiteralChar = dc.NextLiteralChar;
			return nextLiteralChar != null && nextLiteralChar.MatchChar(c);
		}

		// Token: 0x06000676 RID: 1654 RVA: 0x0001B594 File Offset: 0x00019794
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
				if (displayCharBase.MatchChar(c) && promptCharacter != c)
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
				else if (displayCharBase is global::Infragistics.Windows.Editors.DigitChar && displayCharBase.Section is global::Infragistics.Windows.Editors.NumberSection && skipDigitSeparator && displayCharBase.Section.CommaChar == c && !global::Infragistics.Windows.Editors.XamMaskedEditor.MatchesNextLiteralChar(displayCharBase, c))
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

		// Token: 0x06000677 RID: 1655 RVA: 0x0001B6CD File Offset: 0x000198CD
		internal static int SetText(global::Infragistics.Windows.Editors.SectionsCollection sections, string text, global::Infragistics.Windows.Editors.MaskInfo maskInfo)
		{
			return global::Infragistics.Windows.Editors.XamMaskedEditor.SetText(sections, text, maskInfo.PromptChar, maskInfo.PadChar, maskInfo.SkipDigitSeparator);
		}

		// Token: 0x06000678 RID: 1656 RVA: 0x0001B6E8 File Offset: 0x000198E8
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

		// Token: 0x06000679 RID: 1657 RVA: 0x0001B74C File Offset: 0x0001994C
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

		// Token: 0x0600067A RID: 1658 RVA: 0x0001B7B4 File Offset: 0x000199B4
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

		// Token: 0x0600067B RID: 1659 RVA: 0x0001B7FC File Offset: 0x000199FC
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

		// Token: 0x0600067C RID: 1660 RVA: 0x0001B84C File Offset: 0x00019A4C
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

		// Token: 0x0600067D RID: 1661 RVA: 0x0001B958 File Offset: 0x00019B58
		private static float GetFloatValue(global::Infragistics.Windows.Editors.SectionsCollection sections, global::Infragistics.Windows.Editors.MaskInfo maskInfo)
		{
			double num = global::Infragistics.Windows.Editors.XamMaskedEditor.GetDoubleValue(sections, maskInfo);
			return (float)num;
		}

		// Token: 0x0600067E RID: 1662 RVA: 0x0001B970 File Offset: 0x00019B70
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

		// Token: 0x0600067F RID: 1663 RVA: 0x0001BAA0 File Offset: 0x00019CA0
		private static int GetEditableSectionCount(global::Infragistics.Windows.Editors.SectionsCollection sections)
		{
			return global::Infragistics.Windows.Editors.XamMaskedEditor.GetSectionCount(sections, typeof(global::Infragistics.Windows.Editors.EditSectionBase));
		}

		// Token: 0x06000680 RID: 1664 RVA: 0x0001BAB4 File Offset: 0x00019CB4
		private static int GetSectionCount(global::Infragistics.Windows.Editors.SectionsCollection sections, global::System.Type type)
		{
			int num = 0;
			int i = 0;
			int count = sections.Count;
			while (i < count)
			{
				if (type.IsInstanceOfType(sections[i]))
				{
					num++;
				}
				i++;
			}
			return num;
		}

		// Token: 0x06000681 RID: 1665 RVA: 0x0001BAEC File Offset: 0x00019CEC
		private static bool IsNumericMask(global::Infragistics.Windows.Editors.SectionsCollection sections)
		{
			int sectionCount = global::Infragistics.Windows.Editors.XamMaskedEditor.GetSectionCount(sections, typeof(global::Infragistics.Windows.Editors.NumberSection));
			int sectionCount2 = global::Infragistics.Windows.Editors.XamMaskedEditor.GetSectionCount(sections, typeof(global::Infragistics.Windows.Editors.FractionPart));
			return sectionCount + sectionCount2 <= 2 && sectionCount2 <= 1 && sectionCount + sectionCount2 >= 1 && sectionCount + sectionCount2 == global::Infragistics.Windows.Editors.XamMaskedEditor.GetEditableSectionCount(sections);
		}

		// Token: 0x06000682 RID: 1666 RVA: 0x0001BB38 File Offset: 0x00019D38
		private static bool IsDateTimeMask(global::Infragistics.Windows.Editors.SectionsCollection sections)
		{
			global::System.Type[] array = new global::System.Type[]
			{
				typeof(global::Infragistics.Windows.Editors.YearSection),
				typeof(global::Infragistics.Windows.Editors.MonthSection),
				typeof(global::Infragistics.Windows.Editors.DaySection),
				typeof(global::Infragistics.Windows.Editors.HourSection),
				typeof(global::Infragistics.Windows.Editors.MinuteSection),
				typeof(global::Infragistics.Windows.Editors.SecondSection),
				typeof(global::Infragistics.Windows.Editors.AMPMSection)
			};
			int num = 0;
			int num2 = 0;
			for (int i = 0; i < array.Length; i++)
			{
				int sectionCount = global::Infragistics.Windows.Editors.XamMaskedEditor.GetSectionCount(sections, array[i]);
				num2 = global::System.Math.Max(num2, sectionCount);
				num += sectionCount;
			}
			return 1 == num2 && num == global::Infragistics.Windows.Editors.XamMaskedEditor.GetEditableSectionCount(sections);
		}

		// Token: 0x06000683 RID: 1667 RVA: 0x0001BBEC File Offset: 0x00019DEC
		private static bool ShouldUseValueToTextConverter(global::Infragistics.Windows.Editors.MaskInfo maskInfo)
		{
			global::Infragistics.Windows.Editors.XamMaskedEditor maskEditor = maskInfo.MaskEditor;
			if (maskEditor != null && !(maskEditor.ValueToTextConverter is global::Infragistics.Windows.Editors.MaskedEditorDefaultConverter))
			{
				global::System.Type dataType = maskInfo.DataType;
				if (typeof(global::System.DateTime) == dataType)
				{
					return !global::Infragistics.Windows.Editors.XamMaskedEditor.IsDateTimeMask(maskInfo.Sections);
				}
				if (global::Infragistics.Windows.Editors.Utils.IsNumericType(dataType))
				{
					return !global::Infragistics.Windows.Editors.XamMaskedEditor.IsNumericMask(maskInfo.Sections);
				}
			}
			return false;
		}

		// Token: 0x06000684 RID: 1668 RVA: 0x0001BC50 File Offset: 0x00019E50
		internal static object GetDataValue(global::Infragistics.Windows.Editors.MaskInfo maskInfo)
		{
			global::System.Type dataType = maskInfo.DataType;
			global::Infragistics.Windows.Editors.SectionsCollection sectionsCollection = maskInfo.Sections;
			sectionsCollection = sectionsCollection.Clone(maskInfo, true);
			global::Infragistics.Windows.Editors.XamMaskedEditor.ValidateAllSections(sectionsCollection, true);
			if (global::Infragistics.Windows.Editors.XamMaskedEditor.ShouldUseValueToTextConverter(maskInfo))
			{
				string text = global::Infragistics.Windows.Editors.XamMaskedEditor.GetText(sectionsCollection, maskInfo.DataMode, maskInfo);
				global::System.Windows.Data.IValueConverter valueToTextConverter = maskInfo.MaskEditor.ValueToTextConverter;
				if (valueToTextConverter != null)
				{
					return valueToTextConverter.ConvertBack(text, maskInfo.DataType, maskInfo.MaskEditor, maskInfo.CultureInfo);
				}
			}
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
					string text2 = global::Infragistics.Windows.Editors.XamMaskedEditor.GetText(maskInfo.Sections, maskInfo.DataMode, maskInfo);
					result = converter.ConvertFromString(null, maskInfo.CultureInfo, text2);
				}
			}
			catch (global::System.Exception innerException)
			{
				throw new global::System.ArgumentException(global::Infragistics.Windows.Editors.ValueEditor.GetString("LE_ArgumentException_5"), innerException);
			}
			return result;
		}

		// Token: 0x06000685 RID: 1669 RVA: 0x0001BEF0 File Offset: 0x0001A0F0
		internal static global::Infragistics.Windows.Editors.SectionBase GetSection(global::Infragistics.Windows.Editors.SectionsCollection sections, global::System.Type sectionType)
		{
			int num = 0;
			return global::Infragistics.Windows.Editors.XamMaskedEditor.GetSection(sections, sectionType, ref num);
		}

		// Token: 0x06000686 RID: 1670 RVA: 0x0001BF08 File Offset: 0x0001A108
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

		// Token: 0x06000687 RID: 1671 RVA: 0x0001BF50 File Offset: 0x0001A150
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

		// Token: 0x06000688 RID: 1672 RVA: 0x0001BF8B File Offset: 0x0001A18B
		internal static bool IsDateTimeSection(global::Infragistics.Windows.Editors.EditSectionBase editSection)
		{
			return editSection is global::Infragistics.Windows.Editors.YearSection || editSection is global::Infragistics.Windows.Editors.MonthSection || editSection is global::Infragistics.Windows.Editors.DaySection || editSection is global::Infragistics.Windows.Editors.HourSection || editSection is global::Infragistics.Windows.Editors.MinuteSection || editSection is global::Infragistics.Windows.Editors.SecondSection || editSection is global::Infragistics.Windows.Editors.AMPMSection;
		}

		// Token: 0x06000689 RID: 1673 RVA: 0x0001BFC8 File Offset: 0x0001A1C8
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

		// Token: 0x0600068A RID: 1674 RVA: 0x0001C014 File Offset: 0x0001A214
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

		// Token: 0x0600068B RID: 1675 RVA: 0x0001C268 File Offset: 0x0001A468
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

		// Token: 0x0600068C RID: 1676 RVA: 0x0001C3F0 File Offset: 0x0001A5F0
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
			global::Infragistics.Windows.Editors.XamMaskedEditor maskEditor = maskInfo.MaskEditor;
			bool autoExpand = maskEditor != null && string.IsNullOrEmpty(maskEditor.Mask);
			double num;
			double fractionValue;
			global::Infragistics.Windows.Editors.Utils.RoundAndSplitHelper(val, (fractionPart != null) ? fractionPart.DisplayChars.Count : 0, out num, out fractionValue);
			if (numberSection != null)
			{
				if (val >= 0.0)
				{
					numberSection.SetText(num.ToString("G28"), autoExpand);
				}
				else
				{
					numberSection.SetText((0.0 == num) ? "-0" : num.ToString("G28"), autoExpand);
				}
			}
			if (fractionPart != null)
			{
				fractionPart.SetFractionValue(fractionValue);
			}
		}

		// Token: 0x0600068D RID: 1677 RVA: 0x0001C51F File Offset: 0x0001A71F
		private static void SetFloatValue(global::Infragistics.Windows.Editors.SectionsCollection sections, float val, global::Infragistics.Windows.Editors.MaskInfo maskInfo)
		{
			global::Infragistics.Windows.Editors.XamMaskedEditor.SetDoubleValue(sections, (double)val, maskInfo);
		}

		// Token: 0x0600068E RID: 1678 RVA: 0x0001C52C File Offset: 0x0001A72C
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

		// Token: 0x0600068F RID: 1679 RVA: 0x0001C568 File Offset: 0x0001A768
		internal static bool SetDataValueHelper(global::Infragistics.Windows.Editors.SectionsCollection sections, global::System.Type dataType, object val, global::Infragistics.Windows.Editors.MaskInfo maskInfo)
		{
			if (global::Infragistics.Windows.Editors.XamMaskedEditor.ShouldUseValueToTextConverter(maskInfo))
			{
				global::System.Windows.Data.IValueConverter valueToTextConverter = maskInfo.MaskEditor.ValueToTextConverter;
				if (valueToTextConverter != null)
				{
					string text = (string)valueToTextConverter.ConvertBack(val, typeof(string), maskInfo.MaskEditor, maskInfo.CultureInfo);
					global::Infragistics.Windows.Editors.XamMaskedEditor.SetText(sections, text, maskInfo);
					global::Infragistics.Windows.Editors.XamMaskedEditor.ValidateAllSections(sections);
					return true;
				}
			}
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
				string text2 = (string)val;
				int num = global::Infragistics.Windows.Editors.XamMaskedEditor.SetText(sections, text2, maskInfo);
				if (text2 != null && num < text2.Length)
				{
					return false;
				}
			}
			else if (typeof(byte) == dataType || typeof(sbyte) == dataType || typeof(short) == dataType || typeof(ushort) == dataType || typeof(short) == dataType || typeof(int) == dataType || typeof(uint) == dataType || typeof(int) == dataType || typeof(long) == dataType || typeof(ulong) == dataType || typeof(long) == dataType)
			{
				string text3 = val.ToString();
				int num2 = global::Infragistics.Windows.Editors.XamMaskedEditor.SetText(sections, text3, maskInfo);
				if (text3 != null && num2 < text3.Length)
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
				string text4 = converter.ConvertToString(null, maskInfo.CultureInfo, val);
				int num3 = global::Infragistics.Windows.Editors.XamMaskedEditor.SetText(sections, text4, maskInfo.PromptChar, maskInfo.PadChar, false);
				if (text4 != null && num3 < text4.Length)
				{
					result = false;
				}
			}
			return result;
		}

		// Token: 0x06000690 RID: 1680 RVA: 0x0001C87C File Offset: 0x0001AA7C
		internal static bool ValidateAllSections(global::Infragistics.Windows.Editors.SectionsCollection sections)
		{
			return global::Infragistics.Windows.Editors.XamMaskedEditor.ValidateAllSections(sections, false);
		}

		// Token: 0x06000691 RID: 1681 RVA: 0x0001C888 File Offset: 0x0001AA88
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

		// Token: 0x06000692 RID: 1682 RVA: 0x0001CA1C File Offset: 0x0001AC1C
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

		// Token: 0x06000693 RID: 1683 RVA: 0x0001CC5C File Offset: 0x0001AE5C
		internal static global::System.Type DeduceEditAsType(global::Infragistics.Windows.Editors.SectionsCollection sections)
		{
			bool flag;
			bool flag2;
			return global::Infragistics.Windows.Editors.XamMaskedEditor.DeduceEditAsType(sections, out flag, out flag2);
		}

		// Token: 0x06000694 RID: 1684 RVA: 0x0001CC74 File Offset: 0x0001AE74
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

		// Token: 0x06000695 RID: 1685 RVA: 0x0001CEF4 File Offset: 0x0001B0F4
		protected override void OnIsKeyboardFocusWithinChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			base.OnIsKeyboardFocusWithinChanged(e);
			bool focused = (bool)e.NewValue;
			this.ProcessIsBeingEditedAndFocusedChanged(focused);
		}

		// Token: 0x06000696 RID: 1686 RVA: 0x0001CF1C File Offset: 0x0001B11C
		internal void ProcessIsBeingEditedAndFocusedChanged()
		{
			global::Infragistics.Windows.Editors.MaskInfo maskInfo = this.MaskInfo;
			bool focused = maskInfo != null && maskInfo.IsBeingEditedAndFocused;
			this.ProcessIsBeingEditedAndFocusedChanged(focused);
		}

		// Token: 0x06000697 RID: 1687 RVA: 0x0001CF44 File Offset: 0x0001B144
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

		// Token: 0x06000698 RID: 1688 RVA: 0x0001D084 File Offset: 0x0001B284
		internal void OnInvalidOperation(global::Infragistics.Windows.Editors.Events.InvalidOperationEventArgs e)
		{
		}

		// Token: 0x06000699 RID: 1689 RVA: 0x0001D086 File Offset: 0x0001B286
		internal void OnInvalidChar(global::Infragistics.Windows.Editors.Events.InvalidCharEventArgs e)
		{
			if (this.InvalidChar == null)
			{
				return;
			}
			this.InvalidChar(this, e);
		}

		// Token: 0x0600069A RID: 1690 RVA: 0x0001D09E File Offset: 0x0001B29E
		internal void EnsureInEditMode()
		{
			if (!base.IsInEditMode)
			{
				throw new global::System.InvalidOperationException(global::Infragistics.Windows.Editors.ValueEditor.GetString("LE_InvalidOperationException_10"));
			}
		}

		// Token: 0x0600069B RID: 1691 RVA: 0x0001D0B8 File Offset: 0x0001B2B8
		internal void VerifyElementsPositioned()
		{
			base.UpdateLayout();
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x0600069C RID: 1692 RVA: 0x0001D0C0 File Offset: 0x0001B2C0
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

		// Token: 0x0600069D RID: 1693 RVA: 0x0001D0D8 File Offset: 0x0001B2D8
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

		// Token: 0x0600069E RID: 1694 RVA: 0x0001D11C File Offset: 0x0001B31C
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

		// Token: 0x0600069F RID: 1695 RVA: 0x0001D164 File Offset: 0x0001B364
		internal void NotifyDisplayCharDrawStringsChanged()
		{
			global::Infragistics.Windows.Editors.SectionsCollection sections = this.Sections;
			global::Infragistics.Windows.Editors.XamMaskedEditor.NotifyPropertyOnDisplayCharacters(sections, global::Infragistics.Windows.Editors.DisplayCharBase.PROPERTY_DRAWSTRING);
		}

		// Token: 0x060006A0 RID: 1696 RVA: 0x0001D184 File Offset: 0x0001B384
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

		// Token: 0x060006A1 RID: 1697 RVA: 0x0001D1E0 File Offset: 0x0001B3E0
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

		// Token: 0x060006A2 RID: 1698 RVA: 0x0001D21C File Offset: 0x0001B41C
		internal static global::System.Globalization.Calendar GetCultureCalendar(global::System.IFormatProvider formatProvider)
		{
			global::System.Globalization.DateTimeFormatInfo dateTimeFormatInfo = global::Infragistics.Windows.Editors.XamMaskedEditor.GetDateTimeFormatInfo(formatProvider);
			return dateTimeFormatInfo.Calendar;
		}

		// Token: 0x060006A3 RID: 1699 RVA: 0x0001D236 File Offset: 0x0001B436
		internal static char GetCultureChar(char c, global::System.IFormatProvider formatProvider)
		{
			return global::Infragistics.Windows.Editors.XamMaskedEditor.GetCultureChar(c, formatProvider, false);
		}

		// Token: 0x060006A4 RID: 1700 RVA: 0x0001D240 File Offset: 0x0001B440
		internal static char GetCultureChar(char c, global::Infragistics.Windows.Editors.MaskInfo maskInfo)
		{
			bool useCurrencySymbols = maskInfo != null && typeof(decimal) == maskInfo.DataType;
			return global::Infragistics.Windows.Editors.XamMaskedEditor.GetCultureChar(c, (maskInfo != null) ? maskInfo.FormatProvider : null, useCurrencySymbols);
		}

		// Token: 0x060006A5 RID: 1701 RVA: 0x0001D27C File Offset: 0x0001B47C
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

		// Token: 0x060006A6 RID: 1702 RVA: 0x0001D32E File Offset: 0x0001B52E
		private static char GetChar(string value, int position)
		{
			if (value == null || value.Length <= position)
			{
				return '\0';
			}
			return value[position];
		}

		// Token: 0x060006A7 RID: 1703 RVA: 0x0001D348 File Offset: 0x0001B548
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

		// Token: 0x060006A8 RID: 1704 RVA: 0x0001D398 File Offset: 0x0001B598
		internal static string GetCultureAMPMDesignator(bool am, global::System.IFormatProvider formatProvider)
		{
			global::System.Globalization.DateTimeFormatInfo dateTimeFormatInfo = global::Infragistics.Windows.Editors.XamMaskedEditor.GetDateTimeFormatInfo(formatProvider);
			if (!am)
			{
				return dateTimeFormatInfo.PMDesignator;
			}
			return dateTimeFormatInfo.AMDesignator;
		}

		// Token: 0x060006A9 RID: 1705 RVA: 0x0001D3BC File Offset: 0x0001B5BC
		internal void IllegalOperation(string message)
		{
			global::Infragistics.Windows.Editors.Events.InvalidOperationEventArgs invalidOperationEventArgs = new global::Infragistics.Windows.Editors.Events.InvalidOperationEventArgs(message);
			this.OnInvalidOperation(invalidOperationEventArgs);
			if (invalidOperationEventArgs.Beep)
			{
				this.Beep();
			}
		}

		// Token: 0x060006AA RID: 1706 RVA: 0x0001D3E8 File Offset: 0x0001B5E8
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

		// Token: 0x060006AB RID: 1707 RVA: 0x0001D474 File Offset: 0x0001B674
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

		// Token: 0x060006AC RID: 1708 RVA: 0x0001D57C File Offset: 0x0001B77C
		private static void OnTrimFractionalZerosChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Editors.XamMaskedEditor xamMaskedEditor = (global::Infragistics.Windows.Editors.XamMaskedEditor)d;
			xamMaskedEditor._cachedTrimFractionalZeros = (bool)e.NewValue;
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x060006AD RID: 1709 RVA: 0x0001D5A2 File Offset: 0x0001B7A2
		// (set) Token: 0x060006AE RID: 1710 RVA: 0x0001D5AA File Offset: 0x0001B7AA
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

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x060006AF RID: 1711 RVA: 0x0001D5BD File Offset: 0x0001B7BD
		// (set) Token: 0x060006B0 RID: 1712 RVA: 0x0001D5CF File Offset: 0x0001B7CF
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

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x060006B1 RID: 1713 RVA: 0x0001D5E2 File Offset: 0x0001B7E2
		// (set) Token: 0x060006B2 RID: 1714 RVA: 0x0001D5F4 File Offset: 0x0001B7F4
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

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x060006B3 RID: 1715 RVA: 0x0001D602 File Offset: 0x0001B802
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::System.Windows.Visibility SpinButtonVisibilityResolved
		{
			get
			{
				return (global::System.Windows.Visibility)base.GetValue(global::Infragistics.Windows.Editors.XamMaskedEditor.SpinButtonVisibilityResolvedProperty);
			}
		}

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x060006B4 RID: 1716 RVA: 0x0001D614 File Offset: 0x0001B814
		// (set) Token: 0x060006B5 RID: 1717 RVA: 0x0001D621 File Offset: 0x0001B821
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

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x060006B6 RID: 1718 RVA: 0x0001D62F File Offset: 0x0001B82F
		internal bool HasSpinIncrement
		{
			get
			{
				return null != this.SpinIncrement;
			}
		}

		// Token: 0x060006B7 RID: 1719 RVA: 0x0001D640 File Offset: 0x0001B840
		private static void OnSpinIncrementChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Editors.XamMaskedEditor xamMaskedEditor = (global::Infragistics.Windows.Editors.XamMaskedEditor)dependencyObject;
			object newValue = e.NewValue;
			xamMaskedEditor._cachedSpinInfo = ((newValue != null) ? global::Infragistics.Windows.Editors.SpinInfo.Parse(xamMaskedEditor, newValue) : null);
		}

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x060006B8 RID: 1720 RVA: 0x0001D66F File Offset: 0x0001B86F
		// (set) Token: 0x060006B9 RID: 1721 RVA: 0x0001D681 File Offset: 0x0001B881
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

		// Token: 0x060006BA RID: 1722 RVA: 0x0001D694 File Offset: 0x0001B894
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

		// Token: 0x060006BB RID: 1723 RVA: 0x0001D6C0 File Offset: 0x0001B8C0
		private static void OnSectionsChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Windows.Editors.XamMaskedEditor)d).OnSectionsChanged();
		}

		// Token: 0x060006BC RID: 1724 RVA: 0x0001D6CD File Offset: 0x0001B8CD
		internal virtual void OnSectionsChanged()
		{
		}

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x060006BD RID: 1725 RVA: 0x0001D6CF File Offset: 0x0001B8CF
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.ReadOnly(true)]
		public global::Infragistics.Windows.Editors.SectionsCollection Sections
		{
			get
			{
				return (global::Infragistics.Windows.Editors.SectionsCollection)base.GetValue(global::Infragistics.Windows.Editors.XamMaskedEditor.SectionsProperty);
			}
		}

		// Token: 0x060006BE RID: 1726 RVA: 0x0001D6E1 File Offset: 0x0001B8E1
		internal void InternalSetSections(global::Infragistics.Windows.Editors.SectionsCollection sections)
		{
			base.SetValue(global::Infragistics.Windows.Editors.XamMaskedEditor.SectionsPropertyKey, sections);
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x060006BF RID: 1727 RVA: 0x0001D6F0 File Offset: 0x0001B8F0
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Bindable(false)]
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

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x060006C0 RID: 1728 RVA: 0x0001D781 File Offset: 0x0001B981
		internal bool DesignMode
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060006C1 RID: 1729 RVA: 0x0001D784 File Offset: 0x0001B984
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

		// Token: 0x060006C2 RID: 1730 RVA: 0x0001D808 File Offset: 0x0001BA08
		public static void ResetDefaultMaskForType(global::System.Type dataType)
		{
			global::Infragistics.Windows.Editors.XamMaskedEditor.RegisterDefaultMaskForType(dataType, null);
		}

		// Token: 0x060006C3 RID: 1731 RVA: 0x0001D814 File Offset: 0x0001BA14
		public static string GetDefaultMaskForType(global::System.Type dataType)
		{
			global::Infragistics.Windows.Editors.MaskDefaultType maskDefaultType;
			return global::Infragistics.Windows.Editors.XamMaskedEditor.GetDefaultMaskForType(dataType, out maskDefaultType);
		}

		// Token: 0x060006C4 RID: 1732 RVA: 0x0001D82C File Offset: 0x0001BA2C
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

		// Token: 0x060006C5 RID: 1733 RVA: 0x0001D89C File Offset: 0x0001BA9C
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

		// Token: 0x060006C6 RID: 1734 RVA: 0x0001DA58 File Offset: 0x0001BC58
		public static bool SupportsDataType(global::System.Type dataType)
		{
			bool flag;
			return global::Infragistics.Windows.Editors.XamMaskedEditor.SupportsDataType(dataType, out flag);
		}

		// Token: 0x060006C7 RID: 1735 RVA: 0x0001DA70 File Offset: 0x0001BC70
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

		// Token: 0x060006C8 RID: 1736 RVA: 0x0001DC08 File Offset: 0x0001BE08
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

		// Token: 0x060006C9 RID: 1737 RVA: 0x0001DCE4 File Offset: 0x0001BEE4
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

		// Token: 0x060006CA RID: 1738 RVA: 0x0001DD90 File Offset: 0x0001BF90
		public static string CalcDefaultDateMask(global::System.IFormatProvider formatProvider)
		{
			return global::Infragistics.Windows.Editors.XamMaskedEditor.CalcDefaultDateMask(formatProvider, true);
		}

		// Token: 0x060006CB RID: 1739 RVA: 0x0001DD9C File Offset: 0x0001BF9C
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

		// Token: 0x060006CC RID: 1740 RVA: 0x0001DF80 File Offset: 0x0001C180
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

		// Token: 0x060006CD RID: 1741 RVA: 0x0001E0E8 File Offset: 0x0001C2E8
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

		// Token: 0x060006CE RID: 1742 RVA: 0x0001E1DC File Offset: 0x0001C3DC
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

		// Token: 0x060006CF RID: 1743 RVA: 0x0001E218 File Offset: 0x0001C418
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

		// Token: 0x060006D0 RID: 1744 RVA: 0x0001E5C8 File Offset: 0x0001C7C8
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

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x060006D1 RID: 1745 RVA: 0x0001E5FB File Offset: 0x0001C7FB
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

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x060006D2 RID: 1746 RVA: 0x0001E628 File Offset: 0x0001C828
		internal global::Infragistics.Windows.Editors.MaskInfo MaskInfoIfAllocated
		{
			get
			{
				return this._maskInfo;
			}
		}

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x060006D3 RID: 1747 RVA: 0x0001E630 File Offset: 0x0001C830
		internal global::Infragistics.Windows.Editors.EditInfo EditInfo
		{
			get
			{
				return this._editInfo;
			}
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x060006D4 RID: 1748 RVA: 0x0001E638 File Offset: 0x0001C838
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Browsable(false)]
		public bool IsTextBoxEntryEnabled
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.Editors.XamMaskedEditor.IsTextBoxEntryEnabledProperty);
			}
		}

		// Token: 0x060006D5 RID: 1749 RVA: 0x0001E64C File Offset: 0x0001C84C
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

		// Token: 0x060006D6 RID: 1750 RVA: 0x0001E6E6 File Offset: 0x0001C8E6
		private void DelayedSetFocusToFocusSiteHelper()
		{
			if (base.IsInEditMode && !this._isInEndEditMode)
			{
				base.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Input, new global::Infragistics.Windows.Editors.Utils.MethodInvoker(base.SetFocusToFocusSite));
			}
		}

		// Token: 0x060006D7 RID: 1751 RVA: 0x0001E711 File Offset: 0x0001C911
		protected override void OnEditModeStarting(global::Infragistics.Windows.Editors.Events.EditModeStartingEventArgs args)
		{
			base.OnEditModeStarting(args);
			if (!args.Cancel)
			{
				this._editInfo = new global::Infragistics.Windows.Editors.EditInfo(this.MaskInfo);
				this.MaskInfo.InternalRefreshValue(base.Value);
			}
		}

		// Token: 0x060006D8 RID: 1752 RVA: 0x0001E748 File Offset: 0x0001C948
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

		// Token: 0x060006D9 RID: 1753 RVA: 0x0001E83D File Offset: 0x0001CA3D
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

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x060006DA RID: 1754 RVA: 0x0001E876 File Offset: 0x0001CA76
		// (set) Token: 0x060006DB RID: 1755 RVA: 0x0001E888 File Offset: 0x0001CA88
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

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x060006DC RID: 1756 RVA: 0x0001E89B File Offset: 0x0001CA9B
		// (set) Token: 0x060006DD RID: 1757 RVA: 0x0001E8A3 File Offset: 0x0001CAA3
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

		// Token: 0x060006DE RID: 1758 RVA: 0x0001E8B4 File Offset: 0x0001CAB4
		private static void OnMaskChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Editors.XamMaskedEditor xamMaskedEditor = (global::Infragistics.Windows.Editors.XamMaskedEditor)dependencyObject;
			xamMaskedEditor._cachedMask = (string)e.NewValue;
			if (xamMaskedEditor.IsInitialized)
			{
				xamMaskedEditor.ReparseMask();
			}
		}

		// Token: 0x060006DF RID: 1759 RVA: 0x0001E8E8 File Offset: 0x0001CAE8
		private void ReparseMask()
		{
			if (this._maskInfo != null)
			{
				this._maskInfo.RecreateSections(false);
			}
			base.SyncValueProperties(global::Infragistics.Windows.Editors.ValueEditor.ValueProperty, base.Value);
		}

		// Token: 0x060006E0 RID: 1760 RVA: 0x0001E90F File Offset: 0x0001CB0F
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

		// Token: 0x060006E1 RID: 1761 RVA: 0x0001E93F File Offset: 0x0001CB3F
		private void ApplyMaskToText()
		{
			base.SyncTextWithValue();
			base.SyncDisplayText();
		}

		// Token: 0x060006E2 RID: 1762 RVA: 0x0001E950 File Offset: 0x0001CB50
		public static string ApplyMask(string text, string mask, global::System.IFormatProvider formatProvider, char promptCharacter, char padCharacter, global::Infragistics.Windows.Editors.MaskMode maskMode)
		{
			global::Infragistics.Windows.Editors.ParsedMask parsedMask = new global::Infragistics.Windows.Editors.ParsedMask(mask, formatProvider, promptCharacter, padCharacter);
			return parsedMask.ApplyMask(text, maskMode);
		}

		// Token: 0x060006E3 RID: 1763 RVA: 0x0001E974 File Offset: 0x0001CB74
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

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x060006E4 RID: 1764 RVA: 0x0001E9E8 File Offset: 0x0001CBE8
		// (set) Token: 0x060006E5 RID: 1765 RVA: 0x0001E9F0 File Offset: 0x0001CBF0
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

		// Token: 0x060006E6 RID: 1766 RVA: 0x0001EA04 File Offset: 0x0001CC04
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

		// Token: 0x060006E7 RID: 1767 RVA: 0x0001EA4E File Offset: 0x0001CC4E
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeDataMode()
		{
			return global::Infragistics.Windows.Utilities.ShouldSerialize(global::Infragistics.Windows.Editors.XamMaskedEditor.DataModeProperty, this);
		}

		// Token: 0x060006E8 RID: 1768 RVA: 0x0001EA5B File Offset: 0x0001CC5B
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetDataMode()
		{
			base.ClearValue(global::Infragistics.Windows.Editors.XamMaskedEditor.DataModeProperty);
		}

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x060006E9 RID: 1769 RVA: 0x0001EA68 File Offset: 0x0001CC68
		// (set) Token: 0x060006EA RID: 1770 RVA: 0x0001EA70 File Offset: 0x0001CC70
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

		// Token: 0x060006EB RID: 1771 RVA: 0x0001EA84 File Offset: 0x0001CC84
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

		// Token: 0x060006EC RID: 1772 RVA: 0x0001EAC0 File Offset: 0x0001CCC0
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeClipMode()
		{
			return global::Infragistics.Windows.Utilities.ShouldSerialize(global::Infragistics.Windows.Editors.XamMaskedEditor.ClipModeProperty, this);
		}

		// Token: 0x060006ED RID: 1773 RVA: 0x0001EACD File Offset: 0x0001CCCD
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetClipMode()
		{
			base.ClearValue(global::Infragistics.Windows.Editors.XamMaskedEditor.ClipModeProperty);
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x060006EE RID: 1774 RVA: 0x0001EADA File Offset: 0x0001CCDA
		// (set) Token: 0x060006EF RID: 1775 RVA: 0x0001EAE2 File Offset: 0x0001CCE2
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

		// Token: 0x060006F0 RID: 1776 RVA: 0x0001EAF8 File Offset: 0x0001CCF8
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

		// Token: 0x060006F1 RID: 1777 RVA: 0x0001EB34 File Offset: 0x0001CD34
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeDisplayMode()
		{
			return global::Infragistics.Windows.Utilities.ShouldSerialize(global::Infragistics.Windows.Editors.XamMaskedEditor.DisplayModeProperty, this);
		}

		// Token: 0x060006F2 RID: 1778 RVA: 0x0001EB41 File Offset: 0x0001CD41
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetDisplayMode()
		{
			base.ClearValue(global::Infragistics.Windows.Editors.XamMaskedEditor.DisplayModeProperty);
		}

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x060006F3 RID: 1779 RVA: 0x0001EB4E File Offset: 0x0001CD4E
		// (set) Token: 0x060006F4 RID: 1780 RVA: 0x0001EB56 File Offset: 0x0001CD56
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

		// Token: 0x060006F5 RID: 1781 RVA: 0x0001EB69 File Offset: 0x0001CD69
		private static bool ValidatePadChar(object objVal)
		{
			return global::Infragistics.Windows.Editors.XamMaskedEditor.IsValidPromptChar((char)objVal);
		}

		// Token: 0x060006F6 RID: 1782 RVA: 0x0001EB78 File Offset: 0x0001CD78
		private static void OnPadCharChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Editors.XamMaskedEditor xamMaskedEditor = (global::Infragistics.Windows.Editors.XamMaskedEditor)dependencyObject;
			char cachedPadChar = (char)e.NewValue;
			xamMaskedEditor._cachedPadChar = cachedPadChar;
			xamMaskedEditor.NotifyDisplayCharDrawStringsChanged();
		}

		// Token: 0x060006F7 RID: 1783 RVA: 0x0001EBA6 File Offset: 0x0001CDA6
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializePadChar()
		{
			return global::Infragistics.Windows.Utilities.ShouldSerialize(global::Infragistics.Windows.Editors.XamMaskedEditor.PadCharProperty, this);
		}

		// Token: 0x060006F8 RID: 1784 RVA: 0x0001EBB3 File Offset: 0x0001CDB3
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetPadChar()
		{
			base.ClearValue(global::Infragistics.Windows.Editors.XamMaskedEditor.PadCharProperty);
		}

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x060006F9 RID: 1785 RVA: 0x0001EBC0 File Offset: 0x0001CDC0
		// (set) Token: 0x060006FA RID: 1786 RVA: 0x0001EBC8 File Offset: 0x0001CDC8
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

		// Token: 0x060006FB RID: 1787 RVA: 0x0001EBDB File Offset: 0x0001CDDB
		private static bool ValidatePromptChar(object objVal)
		{
			return global::Infragistics.Windows.Editors.XamMaskedEditor.IsValidPromptChar((char)objVal);
		}

		// Token: 0x060006FC RID: 1788 RVA: 0x0001EBE8 File Offset: 0x0001CDE8
		private static void OnPromptCharChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Editors.XamMaskedEditor xamMaskedEditor = (global::Infragistics.Windows.Editors.XamMaskedEditor)dependencyObject;
			char cachedPromptChar = (char)e.NewValue;
			xamMaskedEditor._cachedPromptChar = cachedPromptChar;
			xamMaskedEditor.NotifyDisplayCharDrawStringsChanged();
		}

		// Token: 0x060006FD RID: 1789 RVA: 0x0001EC16 File Offset: 0x0001CE16
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializePromptChar()
		{
			return global::Infragistics.Windows.Utilities.ShouldSerialize(global::Infragistics.Windows.Editors.XamMaskedEditor.PromptCharProperty, this);
		}

		// Token: 0x060006FE RID: 1790 RVA: 0x0001EC23 File Offset: 0x0001CE23
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetPromptChar()
		{
			base.ClearValue(global::Infragistics.Windows.Editors.XamMaskedEditor.PromptCharProperty);
		}

		// Token: 0x060006FF RID: 1791 RVA: 0x0001EC30 File Offset: 0x0001CE30
		public void SelectAll()
		{
			this.EnsureInEditMode();
			this.EditInfo.SelectAll();
		}

		// Token: 0x06000700 RID: 1792 RVA: 0x0001EC43 File Offset: 0x0001CE43
		public bool Delete()
		{
			this.EnsureInEditMode();
			return this.EditInfo.Delete(false, true);
		}

		// Token: 0x06000701 RID: 1793 RVA: 0x0001EC58 File Offset: 0x0001CE58
		public void Copy()
		{
			this.EnsureInEditMode();
			this.EditInfo.Copy();
		}

		// Token: 0x06000702 RID: 1794 RVA: 0x0001EC6B File Offset: 0x0001CE6B
		public void Cut()
		{
			this.EnsureInEditMode();
			this.EditInfo.Cut();
		}

		// Token: 0x06000703 RID: 1795 RVA: 0x0001EC7E File Offset: 0x0001CE7E
		public void Paste()
		{
			this.EnsureInEditMode();
			this.EditInfo.Paste();
		}

		// Token: 0x06000704 RID: 1796 RVA: 0x0001EC91 File Offset: 0x0001CE91
		public void ToggleInsertMode()
		{
			this.EnsureInEditMode();
			this.EditInfo.ToggleInsertMode();
		}

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x06000705 RID: 1797 RVA: 0x0001ECA4 File Offset: 0x0001CEA4
		// (set) Token: 0x06000706 RID: 1798 RVA: 0x0001ECAC File Offset: 0x0001CEAC
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
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

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x06000707 RID: 1799 RVA: 0x0001ECB5 File Offset: 0x0001CEB5
		// (set) Token: 0x06000708 RID: 1800 RVA: 0x0001ECC7 File Offset: 0x0001CEC7
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

		// Token: 0x06000709 RID: 1801 RVA: 0x0001ECDA File Offset: 0x0001CEDA
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeTabNavigation()
		{
			return global::Infragistics.Windows.Utilities.ShouldSerialize(global::Infragistics.Windows.Editors.XamMaskedEditor.TabNavigationProperty, this);
		}

		// Token: 0x0600070A RID: 1802 RVA: 0x0001ECE7 File Offset: 0x0001CEE7
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetTabNavigation()
		{
			base.ClearValue(global::Infragistics.Windows.Editors.XamMaskedEditor.TabNavigationProperty);
		}

		// Token: 0x0600070B RID: 1803 RVA: 0x0001ECF4 File Offset: 0x0001CEF4
		internal global::System.Windows.Controls.ContextMenu CreateContextMenu()
		{
			global::System.Windows.Controls.ContextMenu contextMenu = new global::System.Windows.Controls.ContextMenu();
			new global::Infragistics.Windows.Editors.XamMaskedEditor.ContextMenuHelper(this, contextMenu);
			return contextMenu;
		}

		// Token: 0x0600070C RID: 1804 RVA: 0x0001ED10 File Offset: 0x0001CF10
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

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x0600070D RID: 1805 RVA: 0x0001EE20 File Offset: 0x0001D020
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

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x0600070E RID: 1806 RVA: 0x0001EE55 File Offset: 0x0001D055
		// (set) Token: 0x0600070F RID: 1807 RVA: 0x0001EE67 File Offset: 0x0001D067
		public bool AllowShiftingAcrossSections
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.Editors.XamMaskedEditor.AllowShiftingAcrossSectionsProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.XamMaskedEditor.AllowShiftingAcrossSectionsProperty, value);
			}
		}

		// Token: 0x06000710 RID: 1808 RVA: 0x0001EE7A File Offset: 0x0001D07A
		private static bool IsValidPromptChar(char promptCharacter)
		{
			return "\b\t\u0013".IndexOf(promptCharacter) < 0;
		}

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x06000711 RID: 1809 RVA: 0x0001EE8A File Offset: 0x0001D08A
		// (set) Token: 0x06000712 RID: 1810 RVA: 0x0001EEA1 File Offset: 0x0001D0A1
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

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x06000713 RID: 1811 RVA: 0x0001EEB7 File Offset: 0x0001D0B7
		// (set) Token: 0x06000714 RID: 1812 RVA: 0x0001EECE File Offset: 0x0001D0CE
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
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

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x06000715 RID: 1813 RVA: 0x0001EEE4 File Offset: 0x0001D0E4
		// (set) Token: 0x06000716 RID: 1814 RVA: 0x0001EEFB File Offset: 0x0001D0FB
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
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

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x06000717 RID: 1815 RVA: 0x0001EF11 File Offset: 0x0001D111
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
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

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x06000718 RID: 1816 RVA: 0x0001EF28 File Offset: 0x0001D128
		// (set) Token: 0x06000719 RID: 1817 RVA: 0x0001EF3A File Offset: 0x0001D13A
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
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

		// Token: 0x0600071A RID: 1818 RVA: 0x0001EF50 File Offset: 0x0001D150
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

		// Token: 0x0600071B RID: 1819 RVA: 0x0001EF90 File Offset: 0x0001D190
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

		// Token: 0x0600071C RID: 1820 RVA: 0x0001EFD0 File Offset: 0x0001D1D0
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

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x0600071D RID: 1821 RVA: 0x0001F00A File Offset: 0x0001D20A
		// (set) Token: 0x0600071E RID: 1822 RVA: 0x0001F01C File Offset: 0x0001D21C
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
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

		// Token: 0x0600071F RID: 1823 RVA: 0x0001F030 File Offset: 0x0001D230
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

		// Token: 0x06000720 RID: 1824 RVA: 0x0001F070 File Offset: 0x0001D270
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

		// Token: 0x06000721 RID: 1825 RVA: 0x0001F0AA File Offset: 0x0001D2AA
		protected virtual void OnExecutingCommand(global::Infragistics.Windows.Controls.Events.ExecutingCommandEventArgs args)
		{
			base.RaiseEventHelper(args);
		}

		// Token: 0x06000722 RID: 1826 RVA: 0x0001F0B4 File Offset: 0x0001D2B4
		internal bool RaiseExecutingCommand(global::Infragistics.Windows.Controls.Events.ExecutingCommandEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.Editors.XamMaskedEditor.ExecutingCommandEvent;
			args.Source = this;
			this.OnExecutingCommand(args);
			return !args.Cancel;
		}

		// Token: 0x14000018 RID: 24
		// (add) Token: 0x06000723 RID: 1827 RVA: 0x0001F0D8 File Offset: 0x0001D2D8
		// (remove) Token: 0x06000724 RID: 1828 RVA: 0x0001F0E6 File Offset: 0x0001D2E6
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

		// Token: 0x06000725 RID: 1829 RVA: 0x0001F0F4 File Offset: 0x0001D2F4
		protected virtual void OnExecutedCommand(global::Infragistics.Windows.Controls.Events.ExecutedCommandEventArgs args)
		{
			base.RaiseEventHelper(args);
		}

		// Token: 0x06000726 RID: 1830 RVA: 0x0001F0FE File Offset: 0x0001D2FE
		internal void RaiseExecutedCommand(global::Infragistics.Windows.Controls.Events.ExecutedCommandEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.Editors.XamMaskedEditor.ExecutedCommandEvent;
			args.Source = this;
			this.OnExecutedCommand(args);
		}

		// Token: 0x14000019 RID: 25
		// (add) Token: 0x06000727 RID: 1831 RVA: 0x0001F119 File Offset: 0x0001D319
		// (remove) Token: 0x06000728 RID: 1832 RVA: 0x0001F127 File Offset: 0x0001D327
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

		// Token: 0x06000729 RID: 1833 RVA: 0x0001F135 File Offset: 0x0001D335
		public bool ExecuteCommand(global::Infragistics.Windows.Commands.CommandWrapper commandWrapper)
		{
			if (commandWrapper == null)
			{
				throw new global::System.ArgumentNullException("commandWrapper");
			}
			return this.ExecuteCommandImpl(commandWrapper.Command, null);
		}

		// Token: 0x0600072A RID: 1834 RVA: 0x0001F152 File Offset: 0x0001D352
		public bool ExecuteCommand(global::System.Windows.Input.RoutedCommand command)
		{
			return this.ExecuteCommandImpl(command, null);
		}

		// Token: 0x0600072B RID: 1835 RVA: 0x0001F15C File Offset: 0x0001D35C
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

		// Token: 0x0600072C RID: 1836 RVA: 0x0001F1FA File Offset: 0x0001D3FA
		protected internal virtual string GetDefaultMask(global::System.Type dataType, global::System.IFormatProvider formatProvider)
		{
			return null;
		}

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x0600072D RID: 1837 RVA: 0x0001F1FD File Offset: 0x0001D3FD
		// (set) Token: 0x0600072E RID: 1838 RVA: 0x0001F20F File Offset: 0x0001D40F
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

		// Token: 0x0600072F RID: 1839 RVA: 0x0001F222 File Offset: 0x0001D422
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeSelectAllBehavior()
		{
			return global::Infragistics.Windows.Utilities.ShouldSerialize(global::Infragistics.Windows.Editors.XamMaskedEditor.SelectAllBehaviorProperty, this);
		}

		// Token: 0x06000730 RID: 1840 RVA: 0x0001F22F File Offset: 0x0001D42F
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetSelectAllBehavior()
		{
			base.ClearValue(global::Infragistics.Windows.Editors.XamMaskedEditor.SelectAllBehaviorProperty);
		}

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x06000731 RID: 1841 RVA: 0x0001F23C File Offset: 0x0001D43C
		// (set) Token: 0x06000732 RID: 1842 RVA: 0x0001F24E File Offset: 0x0001D44E
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

		// Token: 0x06000733 RID: 1843 RVA: 0x0001F261 File Offset: 0x0001D461
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeAutoFillDate()
		{
			return global::Infragistics.Windows.Utilities.ShouldSerialize(global::Infragistics.Windows.Editors.XamMaskedEditor.AutoFillDateProperty, this);
		}

		// Token: 0x06000734 RID: 1844 RVA: 0x0001F26E File Offset: 0x0001D46E
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetAutoFillDate()
		{
			base.ClearValue(global::Infragistics.Windows.Editors.XamMaskedEditor.AutoFillDateProperty);
		}

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x06000735 RID: 1845 RVA: 0x0001F27B File Offset: 0x0001D47B
		protected override global::System.Windows.Data.IValueConverter DefaultValueToDisplayTextConverter
		{
			get
			{
				return global::Infragistics.Windows.Editors.MaskedEditorDefaultConverter.ValueToDisplayTextConverter;
			}
		}

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x06000736 RID: 1846 RVA: 0x0001F282 File Offset: 0x0001D482
		protected override global::System.Windows.Data.IValueConverter DefaultValueToTextConverter
		{
			get
			{
				return global::Infragistics.Windows.Editors.MaskedEditorDefaultConverter.ValueToTextConverter;
			}
		}

		// Token: 0x06000737 RID: 1847 RVA: 0x0001F289 File Offset: 0x0001D489
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

		// Token: 0x06000738 RID: 1848 RVA: 0x0001F2BC File Offset: 0x0001D4BC
		protected override void OnTextInput(global::System.Windows.Input.TextCompositionEventArgs e)
		{
			base.OnTextInput(e);
			if (!e.Handled && base.IsInEditMode && this.EditInfo != null && e.Text != null && e.Text.Length > 0)
			{
				if (e.Text.Length == 1 && e.Text[0] == '\t' && base.Value == null)
				{
					return;
				}
				this.EditInfo.ProcessTextInput(e, true);
			}
		}

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x06000739 RID: 1849 RVA: 0x0001F332 File Offset: 0x0001D532
		protected global::Infragistics.Windows.Commands.CommandsBase Commands
		{
			get
			{
				return global::Infragistics.Windows.Editors.MaskedEditorCommands.Instance;
			}
		}

		// Token: 0x0600073A RID: 1850 RVA: 0x0001F33C File Offset: 0x0001D53C
		long global::Infragistics.Windows.Commands.ICommandHost.GetCurrentState(long statesToQuery)
		{
			global::Infragistics.Windows.Editors.EditInfo editInfo = this.EditInfo;
			if (editInfo != null)
			{
				return (long)editInfo.GetCurrentState((global::Infragistics.Windows.Editors.MaskedEditorStates)statesToQuery);
			}
			return 0L;
		}

		// Token: 0x0600073B RID: 1851 RVA: 0x0001F360 File Offset: 0x0001D560
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

		// Token: 0x0600073C RID: 1852 RVA: 0x0001F4B8 File Offset: 0x0001D6B8
		bool global::Infragistics.Windows.Commands.ICommandHost.Execute(global::Infragistics.Windows.Commands.ExecuteCommandInfo commandInfo)
		{
			global::System.Windows.Input.RoutedCommand routedCommand = commandInfo.RoutedCommand;
			return routedCommand != null && this.ExecuteCommandImpl(routedCommand, commandInfo.Parameter);
		}

		// Token: 0x0600073D RID: 1853 RVA: 0x0001F4E0 File Offset: 0x0001D6E0
		private static void OnCaretVisibleChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Editors.XamMaskedEditor xamMaskedEditor = (global::Infragistics.Windows.Editors.XamMaskedEditor)dependencyObject;
			bool cachedCaretVisible = (bool)e.NewValue;
			xamMaskedEditor._cachedCaretVisible = cachedCaretVisible;
			xamMaskedEditor.NotifyDisplayCharDrawStringsChanged();
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x0600073E RID: 1854 RVA: 0x0001F50E File Offset: 0x0001D70E
		// (set) Token: 0x0600073F RID: 1855 RVA: 0x0001F516 File Offset: 0x0001D716
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

		// Token: 0x06000740 RID: 1856 RVA: 0x0001F529 File Offset: 0x0001D729
		private void ShowCaretElement()
		{
			if (!this.CaretVisible && !this.IsTextBoxEntryEnabled)
			{
				this.CaretVisible = true;
				base.AddVisualChild(this.CaretElement);
			}
		}

		// Token: 0x06000741 RID: 1857 RVA: 0x0001F54E File Offset: 0x0001D74E
		private void HideCaretElement()
		{
			if (this.CaretVisible)
			{
				base.RemoveVisualChild(this.CaretElement);
				this.CaretVisible = false;
			}
		}

		// Token: 0x06000742 RID: 1858 RVA: 0x0001F56C File Offset: 0x0001D76C
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

		// Token: 0x06000743 RID: 1859 RVA: 0x0001F5BA File Offset: 0x0001D7BA
		internal void ResetCaretBlinking()
		{
			if (this._caretElement != null)
			{
				this._caretElement.ResetCaretBlinking();
			}
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x06000744 RID: 1860 RVA: 0x0001F5D0 File Offset: 0x0001D7D0
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

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x06000745 RID: 1861 RVA: 0x0001F5F1 File Offset: 0x0001D7F1
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

		// Token: 0x06000746 RID: 1862 RVA: 0x0001F60C File Offset: 0x0001D80C
		protected override global::System.Windows.Media.Visual GetVisualChild(int index)
		{
			if (this.CaretVisible && 1 + index == this.VisualChildrenCount)
			{
				return this.CaretElement;
			}
			return base.GetVisualChild(index);
		}

		// Token: 0x06000747 RID: 1863 RVA: 0x0001F630 File Offset: 0x0001D830
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

		// Token: 0x06000748 RID: 1864 RVA: 0x0001F724 File Offset: 0x0001D924
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

		// Token: 0x06000749 RID: 1865 RVA: 0x0001F818 File Offset: 0x0001DA18
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

		// Token: 0x0600074A RID: 1866 RVA: 0x0001F888 File Offset: 0x0001DA88
		internal global::Infragistics.Windows.Editors.DisplayCharacterPresenter GetDisplayCharacterPresenter(global::Infragistics.Windows.Editors.DisplayCharBase dc)
		{
			global::Infragistics.Windows.Utilities.DependencyObjectSearchCallback<global::Infragistics.Windows.Editors.DisplayCharacterPresenter> callback = (global::Infragistics.Windows.Editors.DisplayCharacterPresenter presenter) => dc == presenter.DisplayCharacter;
			return global::Infragistics.Windows.Utilities.GetDescendantFromType<global::Infragistics.Windows.Editors.DisplayCharacterPresenter>(this, true, callback);
		}

		// Token: 0x0600074B RID: 1867 RVA: 0x0001F8BC File Offset: 0x0001DABC
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

		// Token: 0x0600074C RID: 1868 RVA: 0x0001F948 File Offset: 0x0001DB48
		internal bool IsMouseOverTemplateChild(string templateChildName, global::System.Windows.Input.MouseEventArgs mouseArgs)
		{
			global::System.Windows.DependencyObject dependencyObject;
			return this.IsMouseOverTemplateChild(templateChildName, mouseArgs, out dependencyObject);
		}

		// Token: 0x0600074D RID: 1869 RVA: 0x0001F95F File Offset: 0x0001DB5F
		internal bool IsMouseOverTemplateChild(string templateChildName, global::System.Windows.Input.MouseEventArgs mouseArgs, out global::System.Windows.DependencyObject templateChildElem)
		{
			templateChildElem = base.GetTemplateChild(templateChildName);
			return templateChildElem != null && global::Infragistics.Windows.Editors.Utils.IsMouseOverElement(templateChildElem, mouseArgs);
		}

		// Token: 0x0600074E RID: 1870 RVA: 0x0001F97C File Offset: 0x0001DB7C
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

		// Token: 0x0600074F RID: 1871 RVA: 0x0001F9E4 File Offset: 0x0001DBE4
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

		// Token: 0x06000750 RID: 1872 RVA: 0x0001FB2C File Offset: 0x0001DD2C
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

		// Token: 0x06000751 RID: 1873 RVA: 0x0001FB62 File Offset: 0x0001DD62
		protected override void OnMouseDoubleClick(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			base.OnMouseDoubleClick(e);
			if (this.EditInfo != null && global::Infragistics.Windows.Editors.Utils.IsMouseOverElement(this, e) && !global::Infragistics.Windows.Editors.Utils.IsMouseOverButton(this, e))
			{
				this.EditInfo.SelectAll();
				e.Handled = true;
			}
		}

		// Token: 0x06000752 RID: 1874 RVA: 0x0001FB98 File Offset: 0x0001DD98
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

		// Token: 0x06000753 RID: 1875 RVA: 0x0001FC9C File Offset: 0x0001DE9C
		protected override void OnMouseUp(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			base.OnMouseUp(e);
			if (e.Device != null && e.Device.Target != null)
			{
				this._isDragSelecting = false;
				e.Device.Target.ReleaseMouseCapture();
			}
		}

		// Token: 0x06000754 RID: 1876 RVA: 0x0001FCD1 File Offset: 0x0001DED1
		protected override void OnLostMouseCapture(global::System.Windows.Input.MouseEventArgs e)
		{
			this._isDragSelecting = false;
			base.OnLostMouseCapture(e);
		}

		// Token: 0x06000755 RID: 1877 RVA: 0x0001FCE1 File Offset: 0x0001DEE1
		protected override void OnMouseLeftButtonUp(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			base.OnMouseLeftButtonUp(e);
			if (this.EditInfo != null)
			{
				this.EditInfo.MaskedEditUIElementMouseUp(e.GetPosition(this));
				e.Handled = true;
			}
		}

		// Token: 0x06000756 RID: 1878 RVA: 0x0001FD0C File Offset: 0x0001DF0C
		protected override void OnMouseMove(global::System.Windows.Input.MouseEventArgs e)
		{
			base.OnMouseMove(e);
			if (this._isDragSelecting && this.EditInfo != null && e.Device != null && e.Device.Target != null && e.Device.Target.IsMouseCaptured)
			{
				this.EditInfo.MouseDragged(e.GetPosition(this));
				e.Handled = true;
			}
		}

		// Token: 0x04000269 RID: 617
		internal const char DEFAULT_PROMPT_CHAR = '_';

		// Token: 0x0400026A RID: 618
		internal const char DEFAULT_PAD_CHAR = ' ';

		// Token: 0x0400026B RID: 619
		internal const string LOCALIZED_ESCAPE_SEQUENCE = "{LOC}";

		// Token: 0x0400026C RID: 620
		private global::Infragistics.Windows.Licensing.UltraLicense _license;

		// Token: 0x0400026D RID: 621
		private global::Infragistics.Windows.Editors.EditInfo _editInfo;

		// Token: 0x0400026E RID: 622
		private global::Infragistics.Windows.Editors.MaskInfo _maskInfo;

		// Token: 0x0400026F RID: 623
		private global::Infragistics.Windows.Editors.SectionsCollection _displayChars_Sections;

		// Token: 0x04000270 RID: 624
		private global::Infragistics.Windows.Editors.DisplayCharsCollection _displayChars;

		// Token: 0x04000271 RID: 625
		private bool _displayNullTextWhenNotFocused;

		// Token: 0x04000272 RID: 626
		private static string g_lastShortDatePattern;

		// Token: 0x04000273 RID: 627
		private static char g_lastDateSeparator;

		// Token: 0x04000274 RID: 628
		private static string g_lastDefaultDateMask;

		// Token: 0x04000275 RID: 629
		private static global::System.IFormatProvider g_lastDateFormatProvider;

		// Token: 0x04000276 RID: 630
		private static bool g_lastUsePostfixSeparatorsFromLongDatePattern;

		// Token: 0x04000277 RID: 631
		private static string g_lastShortTimePattern;

		// Token: 0x04000278 RID: 632
		private static char g_lastTimeSeparator;

		// Token: 0x04000279 RID: 633
		private static string g_lastDefaultTimeMask;

		// Token: 0x0400027A RID: 634
		private static global::System.Collections.Hashtable g_defaultMaskTable = new global::System.Collections.Hashtable();

		// Token: 0x0400027B RID: 635
		private static bool g_defaultMaskTableInitialized = false;

		// Token: 0x0400027C RID: 636
		internal bool _isDisplayingContextMenu;

		// Token: 0x0400027D RID: 637
		internal bool _transitingIntoEditModeInMouseDown;

		// Token: 0x0400027E RID: 638
		internal global::System.Windows.Point _transitingIntoEditModeInMouseDownPoint = default(global::System.Windows.Point);

		// Token: 0x0400027F RID: 639
		private bool _isDragSelecting;

		// Token: 0x04000280 RID: 640
		internal global::Infragistics.Windows.Editors.SpinInfo _cachedSpinInfo;

		// Token: 0x04000281 RID: 641
		private bool _skipNextMaskValidation;

		// Token: 0x04000282 RID: 642
		private bool _resetIsTextBoxEntryEnabledWhenEditModeEnds;

		// Token: 0x04000283 RID: 643
		private bool _cachedTrimFractionalZeros;

		// Token: 0x04000284 RID: 644
		internal static bool _IsTouchEnabled;

		// Token: 0x04000286 RID: 646
		[global::System.ThreadStatic]
		private static global::System.Globalization.CultureInfo s_defaultCultureInfo;

		// Token: 0x04000287 RID: 647
		public static readonly global::System.Windows.DependencyProperty TrimFractionalZerosProperty = global::System.Windows.DependencyProperty.Register("TrimFractionalZeros", typeof(bool), typeof(global::Infragistics.Windows.Editors.XamMaskedEditor), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.XamMaskedEditor.OnTrimFractionalZerosChanged)));

		// Token: 0x04000288 RID: 648
		public static readonly global::System.Windows.DependencyProperty SpinButtonDisplayModeProperty = global::System.Windows.DependencyProperty.Register("SpinButtonDisplayMode", typeof(global::Infragistics.Windows.Editors.SpinButtonDisplayMode), typeof(global::Infragistics.Windows.Editors.XamMaskedEditor), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.Editors.SpinButtonDisplayMode.Never));

		// Token: 0x04000289 RID: 649
		public static readonly global::System.Windows.DependencyProperty SpinButtonStyleProperty = global::System.Windows.DependencyProperty.Register("SpinButtonStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Windows.Editors.XamMaskedEditor), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.None));

		// Token: 0x0400028A RID: 650
		private static readonly global::System.Windows.DependencyPropertyKey SpinButtonVisibilityResolvedPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("SpinButtonVisibilityResolved", typeof(global::System.Windows.Visibility), typeof(global::Infragistics.Windows.Editors.XamMaskedEditor), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Visibility.Collapsed));

		// Token: 0x0400028B RID: 651
		public static readonly global::System.Windows.DependencyProperty SpinButtonVisibilityResolvedProperty = global::Infragistics.Windows.Editors.XamMaskedEditor.SpinButtonVisibilityResolvedPropertyKey.DependencyProperty;

		// Token: 0x0400028C RID: 652
		public static readonly global::System.Windows.DependencyProperty SpinIncrementProperty = global::System.Windows.DependencyProperty.Register("SpinIncrement", typeof(object), typeof(global::Infragistics.Windows.Editors.XamMaskedEditor), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.None, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.XamMaskedEditor.OnSpinIncrementChanged)));

		// Token: 0x0400028D RID: 653
		public static readonly global::System.Windows.DependencyProperty SpinWrapProperty = global::System.Windows.DependencyProperty.Register("SpinWrap", typeof(bool), typeof(global::Infragistics.Windows.Editors.XamMaskedEditor), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x0400028E RID: 654
		private static readonly global::System.Windows.DependencyPropertyKey SectionsPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("Sections", typeof(global::Infragistics.Windows.Editors.SectionsCollection), typeof(global::Infragistics.Windows.Editors.XamMaskedEditor), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.None, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.XamMaskedEditor.OnSectionsChanged)));

		// Token: 0x0400028F RID: 655
		public static readonly global::System.Windows.DependencyProperty SectionsProperty = global::Infragistics.Windows.Editors.XamMaskedEditor.SectionsPropertyKey.DependencyProperty;

		// Token: 0x04000290 RID: 656
		private static readonly global::System.Windows.DependencyPropertyKey IsTextBoxEntryEnabledPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("IsTextBoxEntryEnabled", typeof(bool), typeof(global::Infragistics.Windows.Editors.XamMaskedEditor), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, global::System.Windows.FrameworkPropertyMetadataOptions.None));

		// Token: 0x04000291 RID: 657
		public static readonly global::System.Windows.DependencyProperty IsTextBoxEntryEnabledProperty = global::Infragistics.Windows.Editors.XamMaskedEditor.IsTextBoxEntryEnabledPropertyKey.DependencyProperty;

		// Token: 0x04000292 RID: 658
		public static readonly global::System.Windows.DependencyProperty InsertModeProperty = global::System.Windows.DependencyProperty.Register("InsertMode", typeof(bool), typeof(global::Infragistics.Windows.Editors.XamMaskedEditor), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.TrueBox));

		// Token: 0x04000293 RID: 659
		public static readonly global::System.Windows.DependencyProperty MaskProperty = global::System.Windows.DependencyProperty.Register("Mask", typeof(string), typeof(global::Infragistics.Windows.Editors.XamMaskedEditor), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.None, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.XamMaskedEditor.OnMaskChanged)));

		// Token: 0x04000294 RID: 660
		private string _cachedMask;

		// Token: 0x04000295 RID: 661
		public static readonly global::System.Windows.DependencyProperty DataModeProperty = global::System.Windows.DependencyProperty.Register("DataMode", typeof(global::Infragistics.Windows.Editors.MaskMode), typeof(global::Infragistics.Windows.Editors.XamMaskedEditor), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.Editors.MaskMode.IncludeLiterals, global::System.Windows.FrameworkPropertyMetadataOptions.None, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.XamMaskedEditor.OnDataModeChanged)));

		// Token: 0x04000296 RID: 662
		private global::Infragistics.Windows.Editors.MaskMode _cachedDataMode;

		// Token: 0x04000297 RID: 663
		public static readonly global::System.Windows.DependencyProperty ClipModeProperty = global::System.Windows.DependencyProperty.Register("ClipMode", typeof(global::Infragistics.Windows.Editors.MaskMode), typeof(global::Infragistics.Windows.Editors.XamMaskedEditor), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.Editors.MaskMode.IncludeLiterals, global::System.Windows.FrameworkPropertyMetadataOptions.None, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.XamMaskedEditor.OnClipModeChanged)));

		// Token: 0x04000298 RID: 664
		private global::Infragistics.Windows.Editors.MaskMode _cachedClipMode;

		// Token: 0x04000299 RID: 665
		public static readonly global::System.Windows.DependencyProperty DisplayModeProperty = global::System.Windows.DependencyProperty.Register("DisplayMode", typeof(global::Infragistics.Windows.Editors.MaskMode), typeof(global::Infragistics.Windows.Editors.XamMaskedEditor), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.Editors.MaskMode.IncludeLiterals, global::System.Windows.FrameworkPropertyMetadataOptions.None, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.XamMaskedEditor.OnDisplayModeChanged)));

		// Token: 0x0400029A RID: 666
		private global::Infragistics.Windows.Editors.MaskMode _cachedDisplayMode;

		// Token: 0x0400029B RID: 667
		public static readonly global::System.Windows.DependencyProperty PadCharProperty = global::System.Windows.DependencyProperty.Register("PadChar", typeof(char), typeof(global::Infragistics.Windows.Editors.XamMaskedEditor), new global::System.Windows.FrameworkPropertyMetadata(' ', global::System.Windows.FrameworkPropertyMetadataOptions.None, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.XamMaskedEditor.OnPadCharChanged)), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.Editors.XamMaskedEditor.ValidatePadChar));

		// Token: 0x0400029C RID: 668
		private char _cachedPadChar;

		// Token: 0x0400029D RID: 669
		public static readonly global::System.Windows.DependencyProperty PromptCharProperty = global::System.Windows.DependencyProperty.Register("PromptChar", typeof(char), typeof(global::Infragistics.Windows.Editors.XamMaskedEditor), new global::System.Windows.FrameworkPropertyMetadata('_', global::System.Windows.FrameworkPropertyMetadataOptions.None, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.XamMaskedEditor.OnPromptCharChanged)), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.Editors.XamMaskedEditor.ValidatePromptChar));

		// Token: 0x0400029E RID: 670
		private char _cachedPromptChar;

		// Token: 0x0400029F RID: 671
		public static readonly global::System.Windows.DependencyProperty TabNavigationProperty = global::System.Windows.DependencyProperty.Register("TabNavigation", typeof(global::Infragistics.Windows.Editors.MaskedEditTabNavigation), typeof(global::Infragistics.Windows.Editors.XamMaskedEditor), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.Editors.MaskedEditTabNavigation.NextControl, global::System.Windows.FrameworkPropertyMetadataOptions.None, null));

		// Token: 0x040002A0 RID: 672
		public static readonly global::System.Windows.DependencyProperty AllowShiftingAcrossSectionsProperty = global::System.Windows.DependencyProperty.Register("AllowShiftingAcrossSections", typeof(bool), typeof(global::Infragistics.Windows.Editors.XamMaskedEditor), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.TrueBox, global::System.Windows.FrameworkPropertyMetadataOptions.None));

		// Token: 0x040002A1 RID: 673
		internal static readonly global::System.Windows.DependencyProperty CaretPositionProperty = global::System.Windows.DependencyProperty.Register("CaretPosition", typeof(int), typeof(global::Infragistics.Windows.Editors.XamMaskedEditor), new global::System.Windows.FrameworkPropertyMetadata(0, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsArrange, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.XamMaskedEditor.OnCaretPositionChanged), new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.Editors.XamMaskedEditor.OnCoerceCaretPosition)));

		// Token: 0x040002A2 RID: 674
		internal static readonly global::System.Windows.DependencyProperty PivotPositionProperty = global::System.Windows.DependencyProperty.Register("PivotPosition", typeof(int), typeof(global::Infragistics.Windows.Editors.XamMaskedEditor), new global::System.Windows.FrameworkPropertyMetadata(0, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsArrange, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.XamMaskedEditor.OnPivotPositionChanged), new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.Editors.XamMaskedEditor.OnCoercePivotPosition)));

		// Token: 0x040002A5 RID: 677
		public static readonly global::System.Windows.DependencyProperty SelectAllBehaviorProperty;

		// Token: 0x040002A6 RID: 678
		public static readonly global::System.Windows.DependencyProperty AutoFillDateProperty;

		// Token: 0x040002A7 RID: 679
		internal static readonly global::System.Windows.DependencyProperty CaretVisibleProperty;

		// Token: 0x040002A8 RID: 680
		private bool _cachedCaretVisible;

		// Token: 0x040002A9 RID: 681
		private global::Infragistics.Windows.Editors.CaretElement _caretElement;

		// Token: 0x02000078 RID: 120
		private class ContextMenuHelper
		{
			// Token: 0x06000757 RID: 1879 RVA: 0x0001FD70 File Offset: 0x0001DF70
			internal ContextMenuHelper(global::Infragistics.Windows.Editors.XamMaskedEditor editor, global::System.Windows.Controls.ContextMenu menu)
			{
				this._menu = menu;
				this._editor = editor;
				menu.Opened += this.OnMenuOpened;
				menu.Closed += this.OnMenuClosed;
			}

			// Token: 0x06000758 RID: 1880 RVA: 0x0001FDAA File Offset: 0x0001DFAA
			private void OnMenuClosed(object sender, global::System.Windows.RoutedEventArgs e)
			{
				this._menu.Items.Clear();
			}

			// Token: 0x06000759 RID: 1881 RVA: 0x0001FDBC File Offset: 0x0001DFBC
			private void OnMenuOpened(object sender, global::System.Windows.RoutedEventArgs e)
			{
				this._menu.Items.Clear();
				global::Infragistics.Windows.Editors.XamMaskedEditor.InitializeContextMenu(this._editor, this._menu);
			}

			// Token: 0x040002AA RID: 682
			private global::Infragistics.Windows.Editors.XamMaskedEditor _editor;

			// Token: 0x040002AB RID: 683
			private global::System.Windows.Controls.ContextMenu _menu;
		}
	}
}
