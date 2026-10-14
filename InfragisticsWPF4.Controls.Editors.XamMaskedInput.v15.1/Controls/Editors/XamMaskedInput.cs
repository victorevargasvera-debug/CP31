using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Markup;
using Infragistics.AutomationPeers;
using Infragistics.Controls.Editors.Primitives;
using Infragistics.Themes;
using Infragistics.Windows.Licensing;

namespace Infragistics.Controls.Editors
{
	// Token: 0x02000058 RID: 88
	[global::System.ComponentModel.LicenseProvider(typeof(global::Infragistics.Windows.Licensing.UltraLicenseProvider))]
	[global::System.Windows.StyleTypedProperty(Property = "SpinButtonStyle", StyleTargetType = typeof(global::System.Windows.Controls.Primitives.RepeatButton))]
	[global::System.Windows.Markup.ContentProperty("Value")]
	[global::Infragistics.Windows.Licensing.UltraLicense("XamMaskedInput")]
	[global::System.Windows.TemplatePart(Name = "PART_InputTextBox", Type = typeof(global::Infragistics.Controls.Editors.Primitives.MaskedInputTextBox))]
	[global::System.Windows.TemplatePart(Name = "PART_SpinButtons", Type = typeof(global::System.Windows.FrameworkElement))]
	public class XamMaskedInput : global::Infragistics.Controls.Editors.TextInputBase, global::Infragistics.ICommandTarget
	{
		// Token: 0x14000005 RID: 5
		// (add) Token: 0x06000401 RID: 1025 RVA: 0x000147D0 File Offset: 0x000129D0
		// (remove) Token: 0x06000402 RID: 1026 RVA: 0x00014808 File Offset: 0x00012A08
		public event global::System.EventHandler<global::Infragistics.Controls.Editors.InvalidCharEventArgs> InvalidChar;

		// Token: 0x06000403 RID: 1027 RVA: 0x000148A0 File Offset: 0x00012AA0
		static XamMaskedInput()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Controls.Editors.XamMaskedInput), global::Infragistics.DependencyPropertyUtilities.CreateMetadata(typeof(global::Infragistics.Controls.Editors.XamMaskedInput)));
			global::System.Windows.Input.KeyboardNavigation.TabNavigationProperty.OverrideMetadata(typeof(global::Infragistics.Controls.Editors.XamMaskedInput), global::Infragistics.DependencyPropertyUtilities.CreateMetadata(global::System.Windows.Input.KeyboardNavigationMode.Local));
			global::System.Windows.Input.KeyboardNavigation.ControlTabNavigationProperty.OverrideMetadata(typeof(global::Infragistics.Controls.Editors.XamMaskedInput), global::Infragistics.DependencyPropertyUtilities.CreateMetadata(global::System.Windows.Input.KeyboardNavigationMode.None));
			global::System.Windows.Input.KeyboardNavigation.DirectionalNavigationProperty.OverrideMetadata(typeof(global::Infragistics.Controls.Editors.XamMaskedInput), global::Infragistics.DependencyPropertyUtilities.CreateMetadata(global::System.Windows.Input.KeyboardNavigationMode.None));
			global::System.Windows.Style style = new global::System.Windows.Style();
			style.Seal();
			global::System.Windows.FrameworkElement.FocusVisualStyleProperty.OverrideMetadata(typeof(global::Infragistics.Controls.Editors.XamMaskedInput), new global::System.Windows.FrameworkPropertyMetadata(style));
			global::System.Windows.Controls.ControlTemplate controlTemplate = new global::System.Windows.Controls.ControlTemplate();
			controlTemplate.Seal();
			global::System.Windows.Controls.Validation.ErrorTemplateProperty.OverrideMetadata(typeof(global::Infragistics.Controls.Editors.XamMaskedInput), new global::System.Windows.FrameworkPropertyMetadata(controlTemplate));
			global::Infragistics.Themes.ThemeManager.RegisterControl(typeof(global::Infragistics.Controls.Editors.XamMaskedInput));
		}

		// Token: 0x06000404 RID: 1028 RVA: 0x00014D94 File Offset: 0x00012F94
		public XamMaskedInput()
		{
			try
			{
				this._license = (global::System.ComponentModel.LicenseManager.Validate(typeof(global::Infragistics.Controls.Editors.XamMaskedInput), this) as global::Infragistics.Windows.Licensing.UltraLicense);
			}
			catch (global::System.IO.FileNotFoundException)
			{
			}
			this.InitializeCachedPropertyValues();
			this._maskInfo = new global::Infragistics.Controls.Editors.MaskInfo(this);
			this._editInfo = new global::Infragistics.Controls.Editors.EditInfo(this._maskInfo);
			this.InternalSetSections(this._maskInfo.Sections);
			global::Infragistics.CommandSourceManager.RegisterCommandTarget(this);
		}

		// Token: 0x06000405 RID: 1029 RVA: 0x00014E18 File Offset: 0x00013018
		public override bool CanEditType(global::System.Type type)
		{
			return global::Infragistics.Controls.Editors.XamMaskedInput.SupportsDataType(type);
		}

		// Token: 0x06000406 RID: 1030 RVA: 0x00014E20 File Offset: 0x00013020
		public override bool CanRenderType(global::System.Type type)
		{
			return this.CanEditType(type);
		}

		// Token: 0x06000407 RID: 1031 RVA: 0x00014E29 File Offset: 0x00013029
		protected override global::System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
		{
			return new global::Infragistics.AutomationPeers.XamMaskedInputAutomationPeer(this);
		}

		// Token: 0x06000408 RID: 1032 RVA: 0x00014E34 File Offset: 0x00013034
		protected override void DoInitialization()
		{
			base.DoInitialization();
			global::Infragistics.Controls.Editors.MaskInfo maskInfo = this.MaskInfo;
			maskInfo.RecreateSections(true);
			maskInfo.InternalRefreshValue(base.Value);
			this.ApplyMaskToText();
		}

		// Token: 0x06000409 RID: 1033 RVA: 0x00014E68 File Offset: 0x00013068
		protected override global::System.Windows.FrameworkElement GetFocusSite()
		{
			global::System.Windows.FrameworkElement frameworkElement = base.GetTemplateChild("PART_InputTextBox") as global::System.Windows.FrameworkElement;
			if (frameworkElement != null)
			{
				return frameworkElement;
			}
			return global::Infragistics.Controls.Editors.Primitives.Utils.GetDescendantFromName(this, "PART_InputTextBox");
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x00014E98 File Offset: 0x00013098
		protected override string OnCoerceText(string text)
		{
			text = base.OnCoerceText(text);
			if (!base.SyncingValueProperties && (this._editInfo == null || !this._editInfo._inOnTextChanged) && text != null && text.Length > 0)
			{
				global::Infragistics.Controls.Editors.MaskInfo maskInfo = global::Infragistics.Controls.Editors.MaskInfo.CreateMaskInfoForConverter(this);
				if (maskInfo != null)
				{
					try
					{
						global::Infragistics.Controls.Editors.XamMaskedInput.SetText(maskInfo.Sections, text, maskInfo);
						text = global::Infragistics.Controls.Editors.XamMaskedInput.GetText(maskInfo.Sections, maskInfo.DataMode, maskInfo);
					}
					finally
					{
						global::Infragistics.Controls.Editors.MaskInfo.ReleaseMaskInfoForConverter(maskInfo);
					}
				}
			}
			return text;
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x00014F20 File Offset: 0x00013120
		internal override void ProcessPropertyChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			base.ProcessPropertyChanged(e);
			global::System.Windows.DependencyProperty property = e.Property;
			if (global::Infragistics.Controls.Editors.ValueInput.FormatProviderProperty == property || global::System.Windows.FrameworkElement.LanguageProperty == property)
			{
				if (this._maskInfo != null)
				{
					this._maskInfo.InitializeFormatProvider();
					this.ReparseMask();
				}
			}
			else if (global::Infragistics.Controls.Editors.ValueInput.FormatProperty == property)
			{
				if (this._maskInfo != null)
				{
					this._maskInfo.Format = (e.NewValue as string);
				}
			}
			else if (global::Infragistics.Controls.Editors.XamMaskedInput.IsUndoEnabledProperty == property && this.EditInfo != null)
			{
				this.EditInfo.KeepHistory = this.IsUndoEnabled;
				if (this.IsUndoEnabled)
				{
					this.EditInfo.ManageUndoHistory_TextChanged(false, null);
				}
				else
				{
					this.EditInfo.ClearRedoHistory();
					this.EditInfo.ClearUndoHistory();
				}
			}
			if (global::System.Windows.UIElement.IsMouseOverProperty == property || global::Infragistics.Controls.Editors.XamMaskedInput.SpinButtonDisplayModeProperty == property || global::Infragistics.Controls.Editors.ValueInput.IsReadOnlyProperty == property)
			{
				this.UpdateSpinButtonVisibility();
			}
		}

		// Token: 0x0600040C RID: 1036 RVA: 0x00015008 File Offset: 0x00013208
		protected override bool ValidateCurrentValue(out global::System.Exception error)
		{
			if (!base.ValidateCurrentValue(out error))
			{
				return false;
			}
			global::Infragistics.Controls.Editors.MaskInfo maskInfo = this.MaskInfo;
			string message;
			if (maskInfo != null && maskInfo.Sections != null && !this.IsInputValid(maskInfo.Sections, out message))
			{
				error = new global::System.Exception(message);
				return false;
			}
			return true;
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x0600040D RID: 1037 RVA: 0x0001504D File Offset: 0x0001324D
		protected override global::System.Type DefaultValueType
		{
			get
			{
				return typeof(string);
			}
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x0001505C File Offset: 0x0001325C
		protected override void OnFocusSiteChanged()
		{
			base.OnFocusSiteChanged();
			global::Infragistics.Controls.Editors.EditInfo editInfo = this.EditInfo;
			if (editInfo != null)
			{
				editInfo.InitializeIMETextBox(base.FocusSite);
			}
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x00015085 File Offset: 0x00013285
		internal override void OnIsInEditModeChanged(bool isInEditMode)
		{
			base.OnIsInEditModeChanged(isInEditMode);
			if (this._editInfo != null && base.InternalIsInitialized)
			{
				if (!isInEditMode)
				{
					this._editInfo.ValidateAllSections(true);
				}
				this._editInfo.SyncIMETextBox(true);
				this.UpdateSpinButtonVisibility();
			}
		}

		// Token: 0x06000410 RID: 1040 RVA: 0x000150C0 File Offset: 0x000132C0
		protected override void OnValueChanged(object previousValue, object currentValue)
		{
			base.OnValueChanged(previousValue, currentValue);
			global::Infragistics.Controls.Editors.EditInfo editInfo = this.EditInfo;
			if (editInfo != null)
			{
				editInfo.NotifyCommandsManagerAsync();
			}
		}

		// Token: 0x06000411 RID: 1041 RVA: 0x000150E5 File Offset: 0x000132E5
		internal override void OnValueConstraintChanged(string valueConstraintPropertyName)
		{
			if (this._maskInfo != null)
			{
				this._maskInfo.InitializedCachedMinMaxValues();
				if (this._editInfo != null)
				{
					this._editInfo.NotifyStateChanged();
				}
			}
			base.OnValueConstraintChanged(valueConstraintPropertyName);
		}

		// Token: 0x06000412 RID: 1042 RVA: 0x00015114 File Offset: 0x00013314
		protected internal override void ProcessKeyDown(global::System.Windows.Input.KeyEventArgs args)
		{
			bool flag = false;
			global::System.Windows.Input.Key key = args.Key;
			global::System.Windows.Input.ModifierKeys currentModifierKeys = global::Infragistics.Controls.PresentationUtilities.GetCurrentModifierKeys();
			global::System.Collections.Generic.IEnumerable<global::Infragistics.Controls.Editors.Primitives.MaskedInputCommandId> matchingCommands = this.GetMatchingCommands(key, currentModifierKeys);
			if (matchingCommands != null)
			{
				foreach (global::Infragistics.Controls.Editors.Primitives.MaskedInputCommandId command in matchingCommands)
				{
					this.ExecuteCommand(command, null, this);
					flag = true;
				}
			}
			if (flag)
			{
				args.Handled = true;
				return;
			}
			base.ProcessKeyDown(args);
		}

		// Token: 0x06000413 RID: 1043 RVA: 0x00015198 File Offset: 0x00013398
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override bool ValidateValue(object value, out global::System.Exception error)
		{
			if (!base.ValidateValue(value, out error))
			{
				return false;
			}
			global::Infragistics.Controls.Editors.MaskInfo maskInfo = global::Infragistics.Controls.Editors.MaskInfo.CreateMaskInfoForConverter(this);
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
				global::Infragistics.Controls.Editors.MaskInfo.ReleaseMaskInfoForConverter(maskInfo);
			}
			return true;
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x0001520C File Offset: 0x0001340C
		private void InitializeCachedPropertyValues()
		{
			this._cachedClipMode = (global::Infragistics.Controls.Editors.InputMaskMode)global::Infragistics.DependencyPropertyUtilities.GetDefaultValue(this, global::Infragistics.Controls.Editors.XamMaskedInput.ClipModeProperty);
			this._cachedDataMode = (global::Infragistics.Controls.Editors.InputMaskMode)global::Infragistics.DependencyPropertyUtilities.GetDefaultValue(this, global::Infragistics.Controls.Editors.XamMaskedInput.DataModeProperty);
			this._cachedDisplayMode = (global::Infragistics.Controls.Editors.InputMaskMode)global::Infragistics.DependencyPropertyUtilities.GetDefaultValue(this, global::Infragistics.Controls.Editors.XamMaskedInput.DisplayModeProperty);
			this._cachedMask = (string)global::Infragistics.DependencyPropertyUtilities.GetDefaultValue(this, global::Infragistics.Controls.Editors.XamMaskedInput.MaskProperty);
			this._cachedPadChar = (char)global::Infragistics.DependencyPropertyUtilities.GetDefaultValue(this, global::Infragistics.Controls.Editors.XamMaskedInput.PadCharProperty);
			this._cachedPromptChar = (char)global::Infragistics.DependencyPropertyUtilities.GetDefaultValue(this, global::Infragistics.Controls.Editors.XamMaskedInput.PromptCharProperty);
			this.SetFlag(global::Infragistics.Controls.Editors.XamMaskedInput.InternalFlags.TrimFractionalZeros, (bool)global::Infragistics.DependencyPropertyUtilities.GetDefaultValue(this, global::Infragistics.Controls.Editors.XamMaskedInput.TrimFractionalZerosProperty));
			this.SetFlag(global::Infragistics.Controls.Editors.XamMaskedInput.InternalFlags.SpinWrap, (bool)global::Infragistics.DependencyPropertyUtilities.GetDefaultValue(this, global::Infragistics.Controls.Editors.XamMaskedInput.SpinWrapProperty));
			this.SetFlag(global::Infragistics.Controls.Editors.XamMaskedInput.InternalFlags.InsertMode, (bool)global::Infragistics.DependencyPropertyUtilities.GetDefaultValue(this, global::Infragistics.Controls.Editors.XamMaskedInput.InsertModeProperty));
			this.SetFlag(global::Infragistics.Controls.Editors.XamMaskedInput.InternalFlags.IsUndoEnabled, (bool)global::Infragistics.DependencyPropertyUtilities.GetDefaultValue(this, global::Infragistics.Controls.Editors.XamMaskedInput.IsUndoEnabledProperty));
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x000152FC File Offset: 0x000134FC
		internal bool ResolveMask(global::System.Type dataType, global::System.IFormatProvider formatProvider, out string mask)
		{
			mask = null;
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
			mask = global::Infragistics.Controls.Editors.XamMaskedInput.GetDefaultMaskForType(dataType);
			return mask != null && mask.Length > 0;
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x00015364 File Offset: 0x00013564
		internal static string GetNonstandardForeignDateMaskAndPostfixSymbols(global::System.IFormatProvider formatProv, ref global::System.Collections.Generic.Dictionary<global::System.Type, char> foreignDateSymbols)
		{
			foreignDateSymbols = null;
			string result = null;
			global::System.Globalization.DateTimeFormatInfo dateTimeFormatInfo = global::Infragistics.Controls.Editors.XamMaskedInput.InternalGetDateTimeFormatInfo(formatProv);
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
					foreignDateSymbols = new global::System.Collections.Generic.Dictionary<global::System.Type, char>(3);
					foreignDateSymbols.Add(typeof(global::Infragistics.Controls.Editors.DaySection), c2);
					foreignDateSymbols.Add(typeof(global::Infragistics.Controls.Editors.MonthSection), c);
					foreignDateSymbols.Add(typeof(global::Infragistics.Controls.Editors.YearSection), c3);
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

		// Token: 0x06000417 RID: 1047 RVA: 0x00015750 File Offset: 0x00013950
		internal static bool IsSectionNumeric(global::Infragistics.Controls.Editors.SectionBase section)
		{
			if (section is global::Infragistics.Controls.Editors.NumberSection)
			{
				return true;
			}
			bool flag = false;
			bool flag2 = false;
			for (int i = 0; i < section.DisplayChars.Count; i++)
			{
				global::Infragistics.Controls.Editors.DisplayCharBase displayCharBase = section.DisplayChars[i];
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
					if (!(displayCharBase is global::Infragistics.Controls.Editors.DigitChar) && (displayCharBase.IsEditable || !char.IsDigit(displayCharBase.Char)))
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

		// Token: 0x06000418 RID: 1048 RVA: 0x000157EA File Offset: 0x000139EA
		internal static int ConvertToFourYear(int twoYear, global::System.Globalization.Calendar calendar)
		{
			if (twoYear < 100)
			{
				return calendar.ToFourDigitYear(twoYear);
			}
			return twoYear;
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x000157FA File Offset: 0x000139FA
		internal global::System.Collections.Generic.IEnumerable<global::Infragistics.Controls.Editors.Primitives.MaskedInputCommandId> GetMatchingCommands(global::System.Windows.Input.Key key, global::System.Windows.Input.ModifierKeys modifierKeys)
		{
			return this.Commands.GetMatchingCommands(key, modifierKeys, new global::System.Func<long, long>(this.EditInfo.GetCurrentStateLong));
		}

		// Token: 0x0600041A RID: 1050 RVA: 0x0001581C File Offset: 0x00013A1C
		private static int GetNumberSectionValueHelper(global::Infragistics.Controls.Editors.SectionsCollection sections, global::System.Type sectionType)
		{
			global::Infragistics.Controls.Editors.NumberSection numberSection = (global::Infragistics.Controls.Editors.NumberSection)global::Infragistics.Controls.Editors.XamMaskedInput.GetSection(sections, sectionType);
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

		// Token: 0x0600041B RID: 1051 RVA: 0x0001584C File Offset: 0x00013A4C
		internal static global::System.DateTime? InternalGetDateValue(global::Infragistics.Controls.Editors.SectionsCollection sections)
		{
			int numberSectionValueHelper = global::Infragistics.Controls.Editors.XamMaskedInput.GetNumberSectionValueHelper(sections, typeof(global::Infragistics.Controls.Editors.YearSection));
			int numberSectionValueHelper2 = global::Infragistics.Controls.Editors.XamMaskedInput.GetNumberSectionValueHelper(sections, typeof(global::Infragistics.Controls.Editors.MonthSection));
			int numberSectionValueHelper3 = global::Infragistics.Controls.Editors.XamMaskedInput.GetNumberSectionValueHelper(sections, typeof(global::Infragistics.Controls.Editors.DaySection));
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

		// Token: 0x0600041C RID: 1052 RVA: 0x000158D0 File Offset: 0x00013AD0
		internal static global::System.DateTime InternalGetDateTimeValue(global::Infragistics.Controls.Editors.SectionsCollection sections)
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
			global::Infragistics.Controls.Editors.MaskInfo maskInfo = sections.MaskInfo;
			if (maskInfo != null && maskInfo.MaskedInput != null)
			{
				object obj = maskInfo.MaskedInput.OriginalValue;
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
			global::Infragistics.Controls.Editors.MonthSection monthSection = (global::Infragistics.Controls.Editors.MonthSection)global::Infragistics.Controls.Editors.XamMaskedInput.GetSection(sections, typeof(global::Infragistics.Controls.Editors.MonthSection));
			global::Infragistics.Controls.Editors.DaySection daySection = (global::Infragistics.Controls.Editors.DaySection)global::Infragistics.Controls.Editors.XamMaskedInput.GetSection(sections, typeof(global::Infragistics.Controls.Editors.DaySection));
			global::Infragistics.Controls.Editors.YearSection yearSection = (global::Infragistics.Controls.Editors.YearSection)global::Infragistics.Controls.Editors.XamMaskedInput.GetSection(sections, typeof(global::Infragistics.Controls.Editors.YearSection));
			global::Infragistics.Controls.Editors.HourSection hourSection = (global::Infragistics.Controls.Editors.HourSection)global::Infragistics.Controls.Editors.XamMaskedInput.GetSection(sections, typeof(global::Infragistics.Controls.Editors.HourSection));
			global::Infragistics.Controls.Editors.MinuteSection minuteSection = (global::Infragistics.Controls.Editors.MinuteSection)global::Infragistics.Controls.Editors.XamMaskedInput.GetSection(sections, typeof(global::Infragistics.Controls.Editors.MinuteSection));
			global::Infragistics.Controls.Editors.SecondSection secondSection = (global::Infragistics.Controls.Editors.SecondSection)global::Infragistics.Controls.Editors.XamMaskedInput.GetSection(sections, typeof(global::Infragistics.Controls.Editors.SecondSection));
			if (flag)
			{
				num = ((hourSection != null) ? calendar.GetDayOfMonth(now) : 1);
				num2 = ((hourSection != null) ? calendar.GetMonth(now) : 1);
			}
			global::Infragistics.Controls.Editors.AMPMSection ampmsection = (global::Infragistics.Controls.Editors.AMPMSection)global::Infragistics.Controls.Editors.XamMaskedInput.GetSection(sections, typeof(global::Infragistics.Controls.Editors.AMPMSection));
			if (monthSection == null && daySection == null && yearSection == null && hourSection == null && minuteSection == null && secondSection == null)
			{
				throw new global::System.ArgumentException(global::Infragistics.Controls.Editors.ValueInput.GetString("LE_ArgumentException_4"));
			}
			int num6 = (hourSection != null) ? hourSection.ToInt() : num3;
			if (hourSection != null && ampmsection != null)
			{
				if (num6 < 12)
				{
					if (ampmsection.PMValue != null && global::Infragistics.Controls.Editors.Primitives.Utils.CompareStrings(ampmsection.PMValue, ampmsection.GetText(global::Infragistics.Controls.Editors.InputMaskMode.IncludeLiterals), true, null) == 0)
					{
						num6 += 12;
					}
				}
				else if (12 == num6 && ampmsection.AMValue != null && global::Infragistics.Controls.Editors.Primitives.Utils.CompareStrings(ampmsection.AMValue, ampmsection.GetText(global::Infragistics.Controls.Editors.InputMaskMode.IncludeLiterals), true, null) == 0)
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

		// Token: 0x0600041D RID: 1053 RVA: 0x00015BAC File Offset: 0x00013DAC
		internal static string GetText(global::Infragistics.Controls.Editors.SectionsCollection sections, global::Infragistics.Controls.Editors.InputMaskMode maskMode, char promptChar, char padChar)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(1 + global::Infragistics.Controls.Editors.XamMaskedInput.InternalGetTotalNumberOfDisplayChars(sections));
			int i = 0;
			int count = sections.Count;
			while (i < count)
			{
				global::Infragistics.Controls.Editors.DisplayCharsCollection displayChars = sections[i].DisplayChars;
				int count2 = displayChars.Count;
				for (int j = 0; j < count2; j++)
				{
					global::Infragistics.Controls.Editors.DisplayCharBase displayCharBase = displayChars[j];
					char @char = displayCharBase.GetChar(maskMode, promptChar, padChar);
					if (@char != '\0')
					{
						stringBuilder.Append(@char);
					}
					if (displayCharBase is global::Infragistics.Controls.Editors.DigitChar && ((global::Infragistics.Controls.Editors.DigitChar)displayCharBase).ShouldIncludeComma(maskMode) && displayCharBase.Section.CommaChar != '\0')
					{
						stringBuilder.Append(displayCharBase.Section.CommaChar);
					}
				}
				i++;
			}
			return stringBuilder.ToString();
		}

		// Token: 0x0600041E RID: 1054 RVA: 0x00015C68 File Offset: 0x00013E68
		internal static bool AreAllDisplayCharsEmpty(global::Infragistics.Controls.Editors.SectionsCollection sections)
		{
			foreach (object obj in sections.AllDisplayCharacters)
			{
				global::Infragistics.Controls.Editors.DisplayCharBase displayCharBase = (global::Infragistics.Controls.Editors.DisplayCharBase)obj;
				if (displayCharBase.IsEditable && !displayCharBase.IsEmpty)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0600041F RID: 1055 RVA: 0x00015CD4 File Offset: 0x00013ED4
		internal static string GetText(global::Infragistics.Controls.Editors.SectionsCollection sections, global::Infragistics.Controls.Editors.InputMaskMode maskMode, global::Infragistics.Controls.Editors.MaskInfo maskInfo)
		{
			return global::Infragistics.Controls.Editors.XamMaskedInput.GetText(sections, maskMode, (maskInfo != null) ? maskInfo.PromptChar : '_', (maskInfo != null) ? maskInfo.PadChar : ' ');
		}

		// Token: 0x06000420 RID: 1056 RVA: 0x00015CF7 File Offset: 0x00013EF7
		internal static string GetText(global::Infragistics.Controls.Editors.SectionsCollection sections, global::Infragistics.Controls.Editors.InputMaskMode maskMode, global::Infragistics.Controls.Editors.MaskInfo maskInfo, string nullText)
		{
			if (global::Infragistics.Controls.Editors.XamMaskedInput.AreAllDisplayCharsEmpty(sections))
			{
				return nullText;
			}
			return global::Infragistics.Controls.Editors.XamMaskedInput.GetText(sections, maskMode, (maskInfo != null) ? maskInfo.PromptChar : '_', (maskInfo != null) ? maskInfo.PadChar : ' ');
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x00015D24 File Offset: 0x00013F24
		internal static int SetText(global::Infragistics.Controls.Editors.SectionsCollection sections, string text, char promptCharacter, char padCharacter)
		{
			return global::Infragistics.Controls.Editors.XamMaskedInput.SetText(sections, text, promptCharacter, padCharacter, true);
		}

		// Token: 0x06000422 RID: 1058 RVA: 0x00015D30 File Offset: 0x00013F30
		internal static bool MatchesNextLiteralChar(global::Infragistics.Controls.Editors.DisplayCharBase dc, char c)
		{
			global::Infragistics.Controls.Editors.DisplayCharBase nextLiteralChar = dc.NextLiteralChar;
			return nextLiteralChar != null && nextLiteralChar.MatchChar(c);
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x00015D50 File Offset: 0x00013F50
		internal static int SetText(global::Infragistics.Controls.Editors.SectionsCollection sections, string text, char promptCharacter, char padCharacter, bool skipDigitSeparator)
		{
			if (text == null)
			{
				text = "";
			}
			global::Infragistics.Controls.Editors.XamMaskedInput.EraseAllChars(sections);
			int num = 0;
			global::Infragistics.Controls.Editors.MaskInfo maskInfo = sections.MaskInfo;
			global::Infragistics.Controls.Editors.InputMaskMode inputMaskMode = (maskInfo != null) ? maskInfo.DataMode : global::Infragistics.Controls.Editors.InputMaskMode.IncludeLiterals;
			global::Infragistics.Controls.Editors.DisplayCharBase displayCharBase = global::Infragistics.Controls.Editors.XamMaskedInput.GetDisplayCharAtPosition(sections, 0);
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
					if (!displayCharBase.IsEditable && (inputMaskMode == global::Infragistics.Controls.Editors.InputMaskMode.Raw || global::Infragistics.Controls.Editors.InputMaskMode.IncludePromptChars == inputMaskMode))
					{
						flag = false;
					}
					if (flag)
					{
						num++;
					}
					displayCharBase = displayCharBase.NextDisplayChar;
				}
				else if (displayCharBase is global::Infragistics.Controls.Editors.DigitChar && displayCharBase.Section is global::Infragistics.Controls.Editors.NumberSection && skipDigitSeparator && displayCharBase.Section.CommaChar == c && !global::Infragistics.Controls.Editors.XamMaskedInput.MatchesNextLiteralChar(displayCharBase, c))
				{
					num++;
				}
				else
				{
					global::Infragistics.Controls.Editors.SectionBase nextSection = displayCharBase.Section.NextSection;
					if (nextSection == null)
					{
						break;
					}
					displayCharBase = nextSection.FirstDisplayChar;
				}
			}
			for (int i = 0; i < sections.Count; i++)
			{
				global::Infragistics.Controls.Editors.EditSectionBase editSectionBase = sections[i] as global::Infragistics.Controls.Editors.EditSectionBase;
				if (editSectionBase != null)
				{
					editSectionBase.ValidateSection();
				}
			}
			return num;
		}

		// Token: 0x06000424 RID: 1060 RVA: 0x00015E89 File Offset: 0x00014089
		internal static int SetText(global::Infragistics.Controls.Editors.SectionsCollection sections, string text, global::Infragistics.Controls.Editors.MaskInfo maskInfo)
		{
			return global::Infragistics.Controls.Editors.XamMaskedInput.SetText(sections, text, maskInfo.PromptChar, maskInfo.PadChar, maskInfo.SkipDigitSeparator);
		}

		// Token: 0x06000425 RID: 1061 RVA: 0x00015EA4 File Offset: 0x000140A4
		internal static void EraseAllChars(global::Infragistics.Controls.Editors.SectionsCollection sections)
		{
			if (sections != null)
			{
				int i = 0;
				int count = sections.Count;
				while (i < count)
				{
					global::Infragistics.Controls.Editors.DisplayCharsCollection displayChars = sections[i].DisplayChars;
					int j = 0;
					int count2 = displayChars.Count;
					while (j < count2)
					{
						global::Infragistics.Controls.Editors.DisplayCharBase displayCharBase = displayChars[j];
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

		// Token: 0x06000426 RID: 1062 RVA: 0x00015F08 File Offset: 0x00014108
		internal static global::Infragistics.Controls.Editors.DisplayCharBase GetDisplayCharAtPosition(global::Infragistics.Controls.Editors.SectionsCollection sections, int position)
		{
			if (sections == null || position < 0)
			{
				return null;
			}
			int count = sections.Count;
			int num = 0;
			for (int i = 0; i < count; i++)
			{
				global::Infragistics.Controls.Editors.SectionBase sectionBase = sections[i];
				int count2 = sectionBase.DisplayChars.Count;
				if (position < num + count2)
				{
					return sectionBase.DisplayChars[position - num];
				}
				num += count2;
			}
			return null;
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x00015F64 File Offset: 0x00014164
		internal static int InternalGetTotalNumberOfDisplayChars(global::Infragistics.Controls.Editors.SectionsCollection sections)
		{
			if (sections == null)
			{
				return 0;
			}
			int count = sections.Count;
			int num = 0;
			for (int i = 0; i < count; i++)
			{
				global::Infragistics.Controls.Editors.SectionBase sectionBase = sections[i];
				num += sectionBase.DisplayChars.Count;
			}
			return num;
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x00015FA4 File Offset: 0x000141A4
		private static object GetWholeNumberValue(global::Infragistics.Controls.Editors.SectionsCollection sections, global::System.Type wholeNumberType, global::Infragistics.Controls.Editors.MaskInfo maskInfo)
		{
			string text = global::Infragistics.Controls.Editors.XamMaskedInput.GetText(sections, global::Infragistics.Controls.Editors.InputMaskMode.Raw, maskInfo);
			if (text == null || text.Length == 0)
			{
				throw new global::System.InvalidOperationException(global::Infragistics.Controls.Editors.ValueInput.GetString("LE_InvalidOperationException_9"));
			}
			decimal num = decimal.Parse(text, maskInfo.FormatProvider);
			return global::System.Convert.ChangeType(num, wholeNumberType, maskInfo.FormatProvider);
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x00015FF4 File Offset: 0x000141F4
		private static double GetDoubleValue(global::Infragistics.Controls.Editors.SectionsCollection sections, global::Infragistics.Controls.Editors.MaskInfo maskInfo)
		{
			string text = string.Empty;
			string text2 = string.Empty;
			bool flag = false;
			for (int i = 0; i < sections.Count; i++)
			{
				global::Infragistics.Controls.Editors.SectionBase sectionBase = sections[i];
				if (global::Infragistics.Controls.Editors.XamMaskedInput.IsSectionNumeric(sectionBase))
				{
					if (!flag)
					{
						text += sectionBase.GetText(global::Infragistics.Controls.Editors.InputMaskMode.Raw);
					}
					else
					{
						text2 = sectionBase.GetText(global::Infragistics.Controls.Editors.InputMaskMode.Raw);
					}
				}
				else
				{
					if (!(sectionBase is global::Infragistics.Controls.Editors.LiteralSection))
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
			string text3 = global::Infragistics.Controls.Editors.XamMaskedInput.GetText(sections, maskInfo.DataMode, maskInfo);
			return double.Parse(text3, maskInfo.FormatProvider);
		}

		// Token: 0x0600042A RID: 1066 RVA: 0x00016100 File Offset: 0x00014300
		private static float GetFloatValue(global::Infragistics.Controls.Editors.SectionsCollection sections, global::Infragistics.Controls.Editors.MaskInfo maskInfo)
		{
			double num = global::Infragistics.Controls.Editors.XamMaskedInput.GetDoubleValue(sections, maskInfo);
			return (float)num;
		}

		// Token: 0x0600042B RID: 1067 RVA: 0x00016118 File Offset: 0x00014318
		private static decimal GetCurrencyValue(global::Infragistics.Controls.Editors.SectionsCollection sections, global::Infragistics.Controls.Editors.MaskInfo maskInfo)
		{
			string text = string.Empty;
			string text2 = string.Empty;
			bool flag = false;
			for (int i = 0; i < sections.Count; i++)
			{
				global::Infragistics.Controls.Editors.SectionBase sectionBase = sections[i];
				if (global::Infragistics.Controls.Editors.XamMaskedInput.IsSectionNumeric(sectionBase))
				{
					if (!flag)
					{
						text += sectionBase.GetText(global::Infragistics.Controls.Editors.InputMaskMode.Raw);
					}
					else
					{
						text2 = sectionBase.GetText(global::Infragistics.Controls.Editors.InputMaskMode.Raw);
					}
				}
				else
				{
					if (!(sectionBase is global::Infragistics.Controls.Editors.LiteralSection))
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
			string text3 = global::Infragistics.Controls.Editors.XamMaskedInput.GetText(sections, maskInfo.DataMode, maskInfo);
			return decimal.Parse(text3, maskInfo.FormatProvider);
		}

		// Token: 0x0600042C RID: 1068 RVA: 0x00016248 File Offset: 0x00014448
		private static int GetEditableSectionCount(global::Infragistics.Controls.Editors.SectionsCollection sections)
		{
			return global::Infragistics.Controls.Editors.XamMaskedInput.GetSectionCount(sections, typeof(global::Infragistics.Controls.Editors.EditSectionBase));
		}

		// Token: 0x0600042D RID: 1069 RVA: 0x00016270 File Offset: 0x00014470
		private static int GetSectionCount(global::Infragistics.Controls.Editors.SectionsCollection sections, global::System.Type type)
		{
			return sections.Count((global::Infragistics.Controls.Editors.SectionBase ii) => type.IsInstanceOfType(ii));
		}

		// Token: 0x0600042E RID: 1070 RVA: 0x0001629C File Offset: 0x0001449C
		private static bool IsNumericMask(global::Infragistics.Controls.Editors.SectionsCollection sections)
		{
			int sectionCount = global::Infragistics.Controls.Editors.XamMaskedInput.GetSectionCount(sections, typeof(global::Infragistics.Controls.Editors.NumberSection));
			int sectionCount2 = global::Infragistics.Controls.Editors.XamMaskedInput.GetSectionCount(sections, typeof(global::Infragistics.Controls.Editors.FractionPart));
			return sectionCount + sectionCount2 <= 2 && sectionCount2 <= 1 && sectionCount + sectionCount2 >= 1 && sectionCount + sectionCount2 == global::Infragistics.Controls.Editors.XamMaskedInput.GetEditableSectionCount(sections);
		}

		// Token: 0x0600042F RID: 1071 RVA: 0x00016300 File Offset: 0x00014500
		private static bool IsDateTimeMask(global::Infragistics.Controls.Editors.SectionsCollection sections)
		{
			global::System.Type[] source = new global::System.Type[]
			{
				typeof(global::Infragistics.Controls.Editors.YearSection),
				typeof(global::Infragistics.Controls.Editors.MonthSection),
				typeof(global::Infragistics.Controls.Editors.DaySection),
				typeof(global::Infragistics.Controls.Editors.HourSection),
				typeof(global::Infragistics.Controls.Editors.MinuteSection),
				typeof(global::Infragistics.Controls.Editors.SecondSection),
				typeof(global::Infragistics.Controls.Editors.AMPMSection)
			};
			int[] source2 = (from ii in source
			select global::Infragistics.Controls.Editors.XamMaskedInput.GetSectionCount(sections, ii)).ToArray<int>();
			int num = source2.Sum();
			return 1 == source2.Max() && num == global::Infragistics.Controls.Editors.XamMaskedInput.GetEditableSectionCount(sections);
		}

		// Token: 0x06000430 RID: 1072 RVA: 0x000163C0 File Offset: 0x000145C0
		private static bool ShouldUseValueToTextConverter(global::Infragistics.Controls.Editors.MaskInfo maskInfo)
		{
			global::Infragistics.Controls.Editors.XamMaskedInput maskedInput = maskInfo.MaskedInput;
			if (maskedInput != null && !(maskedInput.ValueToTextConverter is global::Infragistics.Controls.Editors.MaskedInputDefaultConverter))
			{
				global::System.Type dataType = maskInfo.DataType;
				if (typeof(global::System.DateTime) == dataType)
				{
					return !global::Infragistics.Controls.Editors.XamMaskedInput.IsDateTimeMask(maskInfo.Sections);
				}
				if (global::Infragistics.Controls.Editors.Primitives.Utils.IsNumericType(dataType))
				{
					return !global::Infragistics.Controls.Editors.XamMaskedInput.IsNumericMask(maskInfo.Sections);
				}
			}
			return false;
		}

		// Token: 0x06000431 RID: 1073 RVA: 0x00016424 File Offset: 0x00014624
		internal static object InternalGetDataValue(global::Infragistics.Controls.Editors.MaskInfo maskInfo)
		{
			global::System.Type dataType = maskInfo.DataType;
			global::Infragistics.Controls.Editors.SectionsCollection sectionsCollection = maskInfo.Sections;
			sectionsCollection = sectionsCollection.Clone(maskInfo, true);
			global::Infragistics.Controls.Editors.XamMaskedInput.ValidateAllSections(sectionsCollection, true);
			if (global::Infragistics.Controls.Editors.XamMaskedInput.ShouldUseValueToTextConverter(maskInfo))
			{
				string text = global::Infragistics.Controls.Editors.XamMaskedInput.GetText(sectionsCollection, maskInfo.DataMode, maskInfo);
				global::System.Windows.Data.IValueConverter valueToTextConverter = maskInfo.MaskedInput.ValueToTextConverter;
				if (valueToTextConverter != null)
				{
					return valueToTextConverter.ConvertBack(text, maskInfo.DataType, maskInfo.MaskedInput, maskInfo.CultureInfo);
				}
			}
			object result;
			try
			{
				if (typeof(global::System.DateTime) == dataType)
				{
					result = global::Infragistics.Controls.Editors.XamMaskedInput.InternalGetDateTimeValue(sectionsCollection);
				}
				else if (typeof(double) == dataType)
				{
					result = global::Infragistics.Controls.Editors.XamMaskedInput.GetDoubleValue(sectionsCollection, maskInfo);
				}
				else if (typeof(float) == dataType)
				{
					result = global::Infragistics.Controls.Editors.XamMaskedInput.GetFloatValue(sectionsCollection, maskInfo);
				}
				else if (typeof(byte) == dataType || typeof(sbyte) == dataType || typeof(short) == dataType || typeof(ushort) == dataType || typeof(short) == dataType || typeof(int) == dataType || typeof(uint) == dataType || typeof(int) == dataType || typeof(long) == dataType || typeof(ulong) == dataType || typeof(long) == dataType)
				{
					result = global::Infragistics.Controls.Editors.XamMaskedInput.GetWholeNumberValue(sectionsCollection, dataType, maskInfo);
				}
				else if (typeof(decimal) == dataType)
				{
					result = global::Infragistics.Controls.Editors.XamMaskedInput.GetCurrencyValue(sectionsCollection, maskInfo);
				}
				else if (typeof(string) == dataType)
				{
					result = global::Infragistics.Controls.Editors.XamMaskedInput.GetText(sectionsCollection, maskInfo.DataMode, maskInfo);
				}
				else
				{
					global::System.ComponentModel.TypeConverter converter = global::System.ComponentModel.TypeDescriptor.GetConverter(dataType);
					if (!converter.CanConvertFrom(typeof(string)))
					{
						throw new global::System.ArgumentException(global::Infragistics.Controls.Editors.ValueInput.GetString("LE_NotSupportedException_2", new object[]
						{
							dataType.Name
						}), "dataType");
					}
					string text2 = global::Infragistics.Controls.Editors.XamMaskedInput.GetText(maskInfo.Sections, maskInfo.DataMode, maskInfo);
					result = converter.ConvertFromString(null, maskInfo.CultureInfo, text2);
				}
			}
			catch (global::System.Exception innerException)
			{
				throw new global::System.ArgumentException(global::Infragistics.Controls.Editors.ValueInput.GetString("LE_ArgumentException_5"), innerException);
			}
			return result;
		}

		// Token: 0x06000432 RID: 1074 RVA: 0x000166C4 File Offset: 0x000148C4
		internal static global::Infragistics.Controls.Editors.SectionBase GetSection(global::Infragistics.Controls.Editors.SectionsCollection sections, global::System.Type sectionType)
		{
			int num = 0;
			return global::Infragistics.Controls.Editors.XamMaskedInput.GetSection(sections, sectionType, ref num);
		}

		// Token: 0x06000433 RID: 1075 RVA: 0x000166DC File Offset: 0x000148DC
		internal static global::Infragistics.Controls.Editors.SectionBase GetSection(global::Infragistics.Controls.Editors.SectionsCollection sections, global::System.Type sectionType, ref int index)
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

		// Token: 0x06000434 RID: 1076 RVA: 0x00016724 File Offset: 0x00014924
		internal static bool HasNonDateTimeEditSections(global::Infragistics.Controls.Editors.SectionsCollection sections)
		{
			int i = 0;
			int count = sections.Count;
			while (i < count)
			{
				global::Infragistics.Controls.Editors.EditSectionBase editSectionBase = sections[i] as global::Infragistics.Controls.Editors.EditSectionBase;
				if (editSectionBase != null && !global::Infragistics.Controls.Editors.XamMaskedInput.IsDateTimeSection(editSectionBase))
				{
					return true;
				}
				i++;
			}
			return false;
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x0001675F File Offset: 0x0001495F
		internal static bool IsDateTimeSection(global::Infragistics.Controls.Editors.EditSectionBase editSection)
		{
			return editSection is global::Infragistics.Controls.Editors.YearSection || editSection is global::Infragistics.Controls.Editors.MonthSection || editSection is global::Infragistics.Controls.Editors.DaySection || editSection is global::Infragistics.Controls.Editors.HourSection || editSection is global::Infragistics.Controls.Editors.MinuteSection || editSection is global::Infragistics.Controls.Editors.SecondSection || editSection is global::Infragistics.Controls.Editors.AMPMSection;
		}

		// Token: 0x06000436 RID: 1078 RVA: 0x0001679C File Offset: 0x0001499C
		private void PadFractionPartHelper(global::Infragistics.Controls.Editors.SectionsCollection sections)
		{
			global::Infragistics.Controls.Editors.FractionPart fractionPart = (global::Infragistics.Controls.Editors.FractionPart)global::Infragistics.Controls.Editors.XamMaskedInput.GetSection(sections, typeof(global::Infragistics.Controls.Editors.FractionPart));
			if (fractionPart != null)
			{
				if (fractionPart is global::Infragistics.Controls.Editors.FractionPartContinuous || !this.TrimFractionalZeros)
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

		// Token: 0x06000437 RID: 1079 RVA: 0x000167E8 File Offset: 0x000149E8
		internal static void SetDateTimeValue(global::Infragistics.Controls.Editors.SectionsCollection sections, global::System.DateTime date, global::Infragistics.Controls.Editors.MaskInfo maskInfo, bool retainOriginalTime)
		{
			global::System.Globalization.Calendar calendar = sections.Calendar;
			global::Infragistics.Controls.Editors.MonthSection monthSection = (global::Infragistics.Controls.Editors.MonthSection)global::Infragistics.Controls.Editors.XamMaskedInput.GetSection(sections, typeof(global::Infragistics.Controls.Editors.MonthSection));
			global::Infragistics.Controls.Editors.DaySection daySection = (global::Infragistics.Controls.Editors.DaySection)global::Infragistics.Controls.Editors.XamMaskedInput.GetSection(sections, typeof(global::Infragistics.Controls.Editors.DaySection));
			global::Infragistics.Controls.Editors.YearSection yearSection = (global::Infragistics.Controls.Editors.YearSection)global::Infragistics.Controls.Editors.XamMaskedInput.GetSection(sections, typeof(global::Infragistics.Controls.Editors.YearSection));
			global::Infragistics.Controls.Editors.HourSection hourSection = (global::Infragistics.Controls.Editors.HourSection)global::Infragistics.Controls.Editors.XamMaskedInput.GetSection(sections, typeof(global::Infragistics.Controls.Editors.HourSection));
			global::Infragistics.Controls.Editors.MinuteSection minuteSection = (global::Infragistics.Controls.Editors.MinuteSection)global::Infragistics.Controls.Editors.XamMaskedInput.GetSection(sections, typeof(global::Infragistics.Controls.Editors.MinuteSection));
			global::Infragistics.Controls.Editors.SecondSection secondSection = (global::Infragistics.Controls.Editors.SecondSection)global::Infragistics.Controls.Editors.XamMaskedInput.GetSection(sections, typeof(global::Infragistics.Controls.Editors.SecondSection));
			global::Infragistics.Controls.Editors.AMPMSection ampmsection = (global::Infragistics.Controls.Editors.AMPMSection)global::Infragistics.Controls.Editors.XamMaskedInput.GetSection(sections, typeof(global::Infragistics.Controls.Editors.AMPMSection));
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
				global::Infragistics.Controls.Editors.XamMaskedInput.SetText(sections, date.ToString(maskInfo.Format, maskInfo.FormatProvider), maskInfo);
			}
		}

		// Token: 0x06000438 RID: 1080 RVA: 0x00016A04 File Offset: 0x00014C04
		private static void SetCurrencyValue(global::Infragistics.Controls.Editors.SectionsCollection sections, decimal val, global::Infragistics.Controls.Editors.MaskInfo maskInfo)
		{
			global::Infragistics.Controls.Editors.NumberSection numberSection = (global::Infragistics.Controls.Editors.NumberSection)global::Infragistics.Controls.Editors.XamMaskedInput.GetSection(sections, typeof(global::Infragistics.Controls.Editors.NumberSection));
			global::Infragistics.Controls.Editors.FractionPart fractionPart = (global::Infragistics.Controls.Editors.FractionPart)global::Infragistics.Controls.Editors.XamMaskedInput.GetSection(sections, typeof(global::Infragistics.Controls.Editors.FractionPart));
			if (numberSection != null || fractionPart != null)
			{
				global::Infragistics.Controls.Editors.XamMaskedInput.EraseAllChars(sections);
				val = global::System.Math.Round(val, (fractionPart != null) ? fractionPart.DisplayChars.Count : 0);
				global::Infragistics.Controls.Editors.XamMaskedInput maskedInput = maskInfo.MaskedInput;
				bool autoExpand = maskedInput != null && string.IsNullOrEmpty(maskedInput.Mask);
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
			global::Infragistics.Controls.Editors.XamMaskedInput.SetText(sections, text, maskInfo);
			maskInfo.MaskedInput.PadFractionPartHelper(sections);
		}

		// Token: 0x06000439 RID: 1081 RVA: 0x00016B8C File Offset: 0x00014D8C
		private static void SetDoubleValue(global::Infragistics.Controls.Editors.SectionsCollection sections, double val, global::Infragistics.Controls.Editors.MaskInfo maskInfo)
		{
			global::Infragistics.Controls.Editors.NumberSection numberSection = (global::Infragistics.Controls.Editors.NumberSection)global::Infragistics.Controls.Editors.XamMaskedInput.GetSection(sections, typeof(global::Infragistics.Controls.Editors.NumberSection));
			global::Infragistics.Controls.Editors.FractionPart fractionPart = (global::Infragistics.Controls.Editors.FractionPart)global::Infragistics.Controls.Editors.XamMaskedInput.GetSection(sections, typeof(global::Infragistics.Controls.Editors.FractionPart));
			if (numberSection == null && fractionPart == null)
			{
				string text = val.ToString(maskInfo.Format, maskInfo.FormatProvider);
				if (text.Length > 2 && text.StartsWith("0."))
				{
					text = text.Remove(0, 1);
				}
				global::Infragistics.Controls.Editors.XamMaskedInput.SetText(sections, text, maskInfo);
				maskInfo.MaskedInput.PadFractionPartHelper(sections);
				return;
			}
			global::Infragistics.Controls.Editors.XamMaskedInput.EraseAllChars(sections);
			if (global::Infragistics.Controls.Editors.Primitives.Utils.IsInfinityOrNaN(val))
			{
				return;
			}
			global::Infragistics.Controls.Editors.XamMaskedInput maskedInput = maskInfo.MaskedInput;
			bool autoExpand = maskedInput != null && string.IsNullOrEmpty(maskedInput.Mask);
			double num;
			double fractionValue;
			global::Infragistics.Controls.Editors.Primitives.Utils.RoundAndSplitHelper(val, (fractionPart != null) ? fractionPart.DisplayChars.Count : 0, out num, out fractionValue);
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

		// Token: 0x0600043A RID: 1082 RVA: 0x00016CBB File Offset: 0x00014EBB
		private static void SetFloatValue(global::Infragistics.Controls.Editors.SectionsCollection sections, float val, global::Infragistics.Controls.Editors.MaskInfo maskInfo)
		{
			global::Infragistics.Controls.Editors.XamMaskedInput.SetDoubleValue(sections, (double)val, maskInfo);
		}

		// Token: 0x0600043B RID: 1083 RVA: 0x00016CC8 File Offset: 0x00014EC8
		internal static bool SetDataValue(global::Infragistics.Controls.Editors.SectionsCollection sections, global::System.Type dataType, object val, global::Infragistics.Controls.Editors.MaskInfo maskInfo)
		{
			dataType = global::Infragistics.CoreUtilities.GetUnderlyingType(dataType);
			if (global::Infragistics.Controls.Editors.XamMaskedInput.ShouldUseValueToTextConverter(maskInfo))
			{
				global::System.Windows.Data.IValueConverter valueToTextConverter = maskInfo.MaskedInput.ValueToTextConverter;
				if (valueToTextConverter != null)
				{
					string text = (string)valueToTextConverter.Convert(val, typeof(string), maskInfo.MaskedInput, maskInfo.CultureInfo);
					global::Infragistics.Controls.Editors.XamMaskedInput.SetText(sections, text, maskInfo);
					global::Infragistics.Controls.Editors.XamMaskedInput.ValidateAllSections(sections);
					return true;
				}
			}
			if (global::Infragistics.CoreUtilities.IsNull(val))
			{
				global::Infragistics.Controls.Editors.XamMaskedInput.SetText(sections, "", maskInfo);
				return true;
			}
			if (!global::Infragistics.Controls.Editors.XamMaskedInput.SupportsDataType(dataType))
			{
				throw new global::System.ArgumentException(global::Infragistics.Controls.Editors.ValueInput.GetString("LE_NotSupportedException_2", new object[]
				{
					dataType.Name
				}), "dataType");
			}
			dataType = global::Infragistics.CoreUtilities.GetUnderlyingType(dataType);
			if (val.GetType() != dataType)
			{
				val = global::Infragistics.CoreUtilities.ConvertDataValue(val, dataType, maskInfo.FormatProvider, maskInfo.Format);
			}
			bool result = true;
			if (typeof(global::System.DateTime) == dataType)
			{
				global::Infragistics.Controls.Editors.XamMaskedInput.SetDateTimeValue(sections, (global::System.DateTime)val, maskInfo, false);
			}
			else if (typeof(decimal) == dataType)
			{
				global::Infragistics.Controls.Editors.XamMaskedInput.SetCurrencyValue(sections, (decimal)val, maskInfo);
			}
			else if (typeof(double) == dataType)
			{
				global::Infragistics.Controls.Editors.XamMaskedInput.SetDoubleValue(sections, (double)val, maskInfo);
			}
			else if (typeof(float) == dataType)
			{
				global::Infragistics.Controls.Editors.XamMaskedInput.SetFloatValue(sections, (float)val, maskInfo);
			}
			else if (typeof(string) == dataType)
			{
				string text2 = (string)val;
				int num = global::Infragistics.Controls.Editors.XamMaskedInput.SetText(sections, text2, maskInfo);
				if (text2 != null && num < text2.Length)
				{
					return false;
				}
			}
			else if (typeof(byte) == dataType || typeof(sbyte) == dataType || typeof(short) == dataType || typeof(ushort) == dataType || typeof(short) == dataType || typeof(int) == dataType || typeof(uint) == dataType || typeof(int) == dataType || typeof(long) == dataType || typeof(ulong) == dataType || typeof(long) == dataType)
			{
				string text3 = val.ToString();
				int num2 = global::Infragistics.Controls.Editors.XamMaskedInput.SetText(sections, text3, maskInfo);
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
					throw new global::System.ArgumentException(global::Infragistics.Controls.Editors.ValueInput.GetString("LE_NotSupportedException_2", new object[]
					{
						dataType.Name
					}), "dataType");
				}
				string text4 = converter.ConvertToString(null, maskInfo.CultureInfo, val);
				int num3 = global::Infragistics.Controls.Editors.XamMaskedInput.SetText(sections, text4, maskInfo.PromptChar, maskInfo.PadChar, false);
				if (text4 != null && num3 < text4.Length)
				{
					result = false;
				}
			}
			global::Infragistics.Controls.Editors.XamMaskedInput.ValidateAllSections(sections);
			return result;
		}

		// Token: 0x0600043C RID: 1084 RVA: 0x00016FF3 File Offset: 0x000151F3
		internal static bool ValidateAllSections(global::Infragistics.Controls.Editors.SectionsCollection sections)
		{
			return global::Infragistics.Controls.Editors.XamMaskedInput.ValidateAllSections(sections, false);
		}

		// Token: 0x0600043D RID: 1085 RVA: 0x00016FFC File Offset: 0x000151FC
		internal bool IsInputValid(global::Infragistics.Controls.Editors.SectionsCollection sections, out string maskValidationErrorMessage)
		{
			maskValidationErrorMessage = null;
			if (base.IsNullable && global::Infragistics.Controls.Editors.XamMaskedInput.AreAllDisplayCharsEmpty(sections))
			{
				return true;
			}
			sections = sections.Clone(sections.MaskInfo, true);
			global::Infragistics.Controls.Editors.XamMaskedInput.ValidateAllSections(sections, true);
			int i = 0;
			while (i < sections.Count)
			{
				global::Infragistics.Controls.Editors.EditSectionBase editSectionBase = sections[i] as global::Infragistics.Controls.Editors.EditSectionBase;
				if (editSectionBase == null || !(typeof(global::Infragistics.Controls.Editors.NumberSection) == editSectionBase.GetType()))
				{
					goto IL_83;
				}
				global::Infragistics.Controls.Editors.NumberSection numberSection = (global::Infragistics.Controls.Editors.NumberSection)editSectionBase;
				string text;
				if (!numberSection.ValidateAgainstMinMaxHelper(out text))
				{
					maskValidationErrorMessage = text;
					return false;
				}
				string text2 = numberSection.GetText(global::Infragistics.Controls.Editors.InputMaskMode.Raw);
				if (text2 != null && text2.Length != 0)
				{
					goto IL_83;
				}
				IL_9D:
				i++;
				continue;
				IL_83:
				if (editSectionBase != null && !editSectionBase.ValidateSection(false))
				{
					maskValidationErrorMessage = global::Infragistics.Controls.Editors.ValueInput.GetString("MaskValidationErrorInputDoesNotMatchMask");
					return false;
				}
				goto IL_9D;
			}
			global::Infragistics.Controls.Editors.MonthSection monthSection = global::Infragistics.Controls.Editors.XamMaskedInput.GetSection(sections, typeof(global::Infragistics.Controls.Editors.MonthSection)) as global::Infragistics.Controls.Editors.MonthSection;
			global::Infragistics.Controls.Editors.DaySection daySection = global::Infragistics.Controls.Editors.XamMaskedInput.GetSection(sections, typeof(global::Infragistics.Controls.Editors.DaySection)) as global::Infragistics.Controls.Editors.DaySection;
			global::Infragistics.Controls.Editors.YearSection yearSection = global::Infragistics.Controls.Editors.XamMaskedInput.GetSection(sections, typeof(global::Infragistics.Controls.Editors.YearSection)) as global::Infragistics.Controls.Editors.YearSection;
			if (monthSection != null && daySection != null)
			{
				int num = monthSection.ToInt();
				int num2 = daySection.ToInt();
				if (2 == num && num2 > 29)
				{
					maskValidationErrorMessage = global::Infragistics.Controls.Editors.ValueInput.GetString("MaskValidationErrorInvalidDate");
					return false;
				}
				int num3 = 30 + (num + ((num >= 8) ? 1 : 0)) % 2;
				if (num2 > num3)
				{
					maskValidationErrorMessage = global::Infragistics.Controls.Editors.ValueInput.GetString("MaskValidationErrorInvalidDayOfMonth");
					return false;
				}
				if (yearSection != null)
				{
					int year = yearSection.GetYear();
					global::System.Globalization.Calendar calendar = sections.Calendar;
					if (num2 > calendar.GetDaysInMonth(year, num))
					{
						maskValidationErrorMessage = global::Infragistics.Controls.Editors.ValueInput.GetString("MaskValidationErrorInvalidDayOfMonth");
						return false;
					}
				}
			}
			maskValidationErrorMessage = null;
			return true;
		}

		// Token: 0x0600043E RID: 1086 RVA: 0x00017190 File Offset: 0x00015390
		internal static bool ValidateAllSections(global::Infragistics.Controls.Editors.SectionsCollection sections, bool loosingFocus)
		{
			bool flag = true;
			global::Infragistics.Controls.Editors.XamMaskedInput maskedInput = sections.MaskedInput;
			for (int i = 0; i < sections.Count; i++)
			{
				global::Infragistics.Controls.Editors.EditSectionBase editSectionBase = sections[i] as global::Infragistics.Controls.Editors.EditSectionBase;
				if (editSectionBase != null)
				{
					flag = (flag && editSectionBase.ValidateSection());
				}
				if (editSectionBase is global::Infragistics.Controls.Editors.FractionPart)
				{
					global::Infragistics.Controls.Editors.NumberSection numberSection = editSectionBase.PreviousEditSection as global::Infragistics.Controls.Editors.NumberSection;
					bool flag2 = false;
					if (numberSection != null)
					{
						string text = numberSection.GetText(global::Infragistics.Controls.Editors.InputMaskMode.Raw);
						if (text != null && text.Length > 0)
						{
							flag2 = true;
						}
					}
					if (!flag2)
					{
						string text2 = editSectionBase.GetText(global::Infragistics.Controls.Editors.InputMaskMode.Raw);
						if (text2 != null && text2.Length > 0)
						{
							flag2 = true;
						}
					}
					if (flag2 && maskedInput != null)
					{
						maskedInput.PadFractionPartHelper(sections);
					}
				}
			}
			if (loosingFocus)
			{
				global::Infragistics.Controls.Editors.AutoFillDate autoFillDate = maskedInput.AutoFillDate;
				global::System.DateTime now = global::System.DateTime.Now;
				global::System.Globalization.Calendar calendar = sections.Calendar;
				global::Infragistics.Controls.Editors.MonthSection monthSection = (global::Infragistics.Controls.Editors.MonthSection)global::Infragistics.Controls.Editors.XamMaskedInput.GetSection(sections, typeof(global::Infragistics.Controls.Editors.MonthSection));
				global::Infragistics.Controls.Editors.DaySection daySection = (global::Infragistics.Controls.Editors.DaySection)global::Infragistics.Controls.Editors.XamMaskedInput.GetSection(sections, typeof(global::Infragistics.Controls.Editors.DaySection));
				global::Infragistics.Controls.Editors.YearSection yearSection = (global::Infragistics.Controls.Editors.YearSection)global::Infragistics.Controls.Editors.XamMaskedInput.GetSection(sections, typeof(global::Infragistics.Controls.Editors.YearSection));
				if (monthSection != null && monthSection.IsEmpty && daySection != null && !daySection.IsEmpty && global::Infragistics.Controls.Editors.AutoFillDate.MonthAndYear == autoFillDate)
				{
					monthSection.SetText(calendar.GetMonth(now).ToString());
				}
				if (yearSection != null && yearSection.IsEmpty && monthSection != null && !monthSection.IsEmpty && (daySection == null || !daySection.IsEmpty) && (global::Infragistics.Controls.Editors.AutoFillDate.Year == autoFillDate || global::Infragistics.Controls.Editors.AutoFillDate.MonthAndYear == autoFillDate))
				{
					yearSection.SetText(calendar.GetYear(now).ToString());
				}
				global::Infragistics.Controls.Editors.NumberSection numberSection2 = (global::Infragistics.Controls.Editors.NumberSection)global::Infragistics.Controls.Editors.XamMaskedInput.GetSection(sections, typeof(global::Infragistics.Controls.Editors.NumberSection));
				if (numberSection2 != null && (numberSection2.IsEmpty || (numberSection2.HasOnlySignSymbol && numberSection2.DisplayChars.Count >= 2)) && numberSection2.IsFractionPartNonEmpty)
				{
					numberSection2.InsertCharAt(numberSection2.DisplayChars.Count - 1, '0');
				}
			}
			if (flag && loosingFocus && sections.MaskInfo != null && maskedInput != null)
			{
				try
				{
					global::Infragistics.Controls.Editors.AMPMSection ampmsection = (global::Infragistics.Controls.Editors.AMPMSection)global::Infragistics.Controls.Editors.XamMaskedInput.GetSection(sections, typeof(global::Infragistics.Controls.Editors.AMPMSection));
					global::Infragistics.Controls.Editors.HourSection hourSection = (global::Infragistics.Controls.Editors.HourSection)global::Infragistics.Controls.Editors.XamMaskedInput.GetSection(sections, typeof(global::Infragistics.Controls.Editors.HourSection));
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

		// Token: 0x0600043F RID: 1087 RVA: 0x00017420 File Offset: 0x00015620
		internal static global::System.Type DeduceEditAsType(global::Infragistics.Controls.Editors.SectionsCollection sections)
		{
			bool flag;
			bool flag2;
			return global::Infragistics.Controls.Editors.XamMaskedInput.DeduceEditAsType(sections, out flag, out flag2);
		}

		// Token: 0x06000440 RID: 1088 RVA: 0x00017438 File Offset: 0x00015638
		internal static global::System.Type DeduceEditAsType(global::Infragistics.Controls.Editors.SectionsCollection sections, out bool hasDateComponents, out bool hasTimeComponents)
		{
			global::System.Type type = null;
			hasDateComponents = (hasTimeComponents = false);
			try
			{
				global::Infragistics.Controls.Editors.MonthSection monthSection = (global::Infragistics.Controls.Editors.MonthSection)global::Infragistics.Controls.Editors.XamMaskedInput.GetSection(sections, typeof(global::Infragistics.Controls.Editors.MonthSection));
				global::Infragistics.Controls.Editors.DaySection daySection = (global::Infragistics.Controls.Editors.DaySection)global::Infragistics.Controls.Editors.XamMaskedInput.GetSection(sections, typeof(global::Infragistics.Controls.Editors.DaySection));
				global::Infragistics.Controls.Editors.YearSection yearSection = (global::Infragistics.Controls.Editors.YearSection)global::Infragistics.Controls.Editors.XamMaskedInput.GetSection(sections, typeof(global::Infragistics.Controls.Editors.YearSection));
				global::Infragistics.Controls.Editors.HourSection hourSection = (global::Infragistics.Controls.Editors.HourSection)global::Infragistics.Controls.Editors.XamMaskedInput.GetSection(sections, typeof(global::Infragistics.Controls.Editors.HourSection));
				global::Infragistics.Controls.Editors.MinuteSection minuteSection = (global::Infragistics.Controls.Editors.MinuteSection)global::Infragistics.Controls.Editors.XamMaskedInput.GetSection(sections, typeof(global::Infragistics.Controls.Editors.MinuteSection));
				global::Infragistics.Controls.Editors.SecondSection secondSection = (global::Infragistics.Controls.Editors.SecondSection)global::Infragistics.Controls.Editors.XamMaskedInput.GetSection(sections, typeof(global::Infragistics.Controls.Editors.SecondSection));
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
						if (sections[i] is global::Infragistics.Controls.Editors.NumberSection || (flag3 && sections[i] is global::Infragistics.Controls.Editors.FractionPart))
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
						else if (sections[i] is global::Infragistics.Controls.Editors.LiteralSection && 1 == sections[i].DisplayChars.Count)
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
							if (!(sections[i] is global::Infragistics.Controls.Editors.LiteralSection))
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

		// Token: 0x06000441 RID: 1089 RVA: 0x000176B8 File Offset: 0x000158B8
		internal void OnInvalidOperation(global::Infragistics.Controls.Editors.InvalidOperationEventArgs e)
		{
		}

		// Token: 0x06000442 RID: 1090 RVA: 0x000176BA File Offset: 0x000158BA
		internal void OnInvalidChar(global::Infragistics.Controls.Editors.InvalidCharEventArgs e)
		{
			if (this.InvalidChar == null)
			{
				return;
			}
			this.InvalidChar(this, e);
		}

		// Token: 0x06000443 RID: 1091 RVA: 0x000176D2 File Offset: 0x000158D2
		internal void VerifyElementsPositioned()
		{
			base.UpdateLayout();
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x06000444 RID: 1092 RVA: 0x000176DA File Offset: 0x000158DA
		internal static global::System.Globalization.CultureInfo DefaultCultureInfo
		{
			get
			{
				if (global::Infragistics.Controls.Editors.XamMaskedInput.s_defaultCultureInfo == null)
				{
					global::Infragistics.Controls.Editors.XamMaskedInput.s_defaultCultureInfo = global::System.Globalization.CultureInfo.CurrentCulture;
				}
				return global::Infragistics.Controls.Editors.XamMaskedInput.s_defaultCultureInfo;
			}
		}

		// Token: 0x06000445 RID: 1093 RVA: 0x000176F4 File Offset: 0x000158F4
		internal static global::System.Globalization.NumberFormatInfo InternalGetNumberFormatInfo(global::System.IFormatProvider formatProvider)
		{
			global::System.Globalization.NumberFormatInfo numberFormatInfo = formatProvider as global::System.Globalization.NumberFormatInfo;
			if (numberFormatInfo == null && formatProvider != null)
			{
				numberFormatInfo = (global::System.Globalization.NumberFormatInfo)formatProvider.GetFormat(typeof(global::System.Globalization.NumberFormatInfo));
			}
			if (numberFormatInfo == null)
			{
				global::System.Globalization.CultureInfo defaultCultureInfo = global::Infragistics.Controls.Editors.XamMaskedInput.DefaultCultureInfo;
				if (defaultCultureInfo != null)
				{
					numberFormatInfo = defaultCultureInfo.NumberFormat;
				}
			}
			return numberFormatInfo;
		}

		// Token: 0x06000446 RID: 1094 RVA: 0x00017738 File Offset: 0x00015938
		internal static global::System.Globalization.DateTimeFormatInfo InternalGetDateTimeFormatInfo(global::System.IFormatProvider formatProvider)
		{
			global::System.Globalization.DateTimeFormatInfo dateTimeFormatInfo = formatProvider as global::System.Globalization.DateTimeFormatInfo;
			if (dateTimeFormatInfo == null && formatProvider != null)
			{
				dateTimeFormatInfo = (global::System.Globalization.DateTimeFormatInfo)formatProvider.GetFormat(typeof(global::System.Globalization.DateTimeFormatInfo));
			}
			if (dateTimeFormatInfo == null && global::Infragistics.Controls.Editors.XamMaskedInput.DefaultCultureInfo != null)
			{
				dateTimeFormatInfo = global::Infragistics.Controls.Editors.XamMaskedInput.DefaultCultureInfo.DateTimeFormat;
			}
			return dateTimeFormatInfo;
		}

		// Token: 0x06000447 RID: 1095 RVA: 0x00017780 File Offset: 0x00015980
		internal void NotifyDisplayCharDrawStringsChanged()
		{
			global::Infragistics.Controls.Editors.SectionsCollection sections = this.Sections;
			global::Infragistics.Controls.Editors.XamMaskedInput.NotifyPropertyOnDisplayCharacters(sections, global::Infragistics.Controls.Editors.DisplayCharBase.PROPERTY_DRAWSTRING);
		}

		// Token: 0x06000448 RID: 1096 RVA: 0x000177A0 File Offset: 0x000159A0
		internal static void NotifyPropertyOnDisplayCharacters(global::Infragistics.Controls.Editors.SectionsCollection sections, string propertyName)
		{
			if (sections != null)
			{
				foreach (object obj in sections.AllDisplayCharacters)
				{
					global::Infragistics.Controls.Editors.DisplayCharBase displayCharBase = (global::Infragistics.Controls.Editors.DisplayCharBase)obj;
					displayCharBase.NotifyPropertyChangedEvent(propertyName);
				}
			}
		}

		// Token: 0x06000449 RID: 1097 RVA: 0x000177FC File Offset: 0x000159FC
		internal static void NotifyPropertyOnDisplayCharacters(global::Infragistics.Controls.Editors.SectionBase section, string propertyName)
		{
			if (section != null)
			{
				global::Infragistics.Controls.Editors.DisplayCharsCollection displayChars = section.DisplayChars;
				if (displayChars != null)
				{
					int i = 0;
					int count = displayChars.Count;
					while (i < count)
					{
						global::Infragistics.Controls.Editors.DisplayCharBase displayCharBase = displayChars[i];
						displayCharBase.NotifyPropertyChangedEvent(propertyName);
						i++;
					}
				}
			}
		}

		// Token: 0x0600044A RID: 1098 RVA: 0x00017838 File Offset: 0x00015A38
		internal static global::System.Globalization.Calendar InternalGetCultureCalendar(global::System.IFormatProvider formatProvider)
		{
			global::System.Globalization.DateTimeFormatInfo dateTimeFormatInfo = global::Infragistics.Controls.Editors.XamMaskedInput.InternalGetDateTimeFormatInfo(formatProvider);
			return dateTimeFormatInfo.Calendar;
		}

		// Token: 0x0600044B RID: 1099 RVA: 0x00017852 File Offset: 0x00015A52
		internal static char GetCultureChar(char c, global::System.IFormatProvider formatProvider)
		{
			return global::Infragistics.Controls.Editors.XamMaskedInput.GetCultureChar(c, formatProvider, false);
		}

		// Token: 0x0600044C RID: 1100 RVA: 0x0001785C File Offset: 0x00015A5C
		internal static char GetCultureChar(char c, global::Infragistics.Controls.Editors.MaskInfo maskInfo)
		{
			bool useCurrencySymbols = maskInfo != null && typeof(decimal) == maskInfo.DataType;
			return global::Infragistics.Controls.Editors.XamMaskedInput.GetCultureChar(c, (maskInfo != null) ? maskInfo.FormatProvider : null, useCurrencySymbols);
		}

		// Token: 0x0600044D RID: 1101 RVA: 0x00017898 File Offset: 0x00015A98
		internal static char GetCultureChar(char c, global::System.IFormatProvider formatProvider, bool useCurrencySymbols)
		{
			global::System.Globalization.NumberFormatInfo numberFormatInfo = global::Infragistics.Controls.Editors.XamMaskedInput.InternalGetNumberFormatInfo(formatProvider);
			global::System.Globalization.DateTimeFormatInfo provider = global::Infragistics.Controls.Editors.XamMaskedInput.InternalGetDateTimeFormatInfo(formatProvider);
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
					text = global::System.DateTime.Now.ToString("%/", provider);
					break;
				default:
					if (c == ':')
					{
						text = global::System.DateTime.Now.ToString("%:", provider);
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

		// Token: 0x0600044E RID: 1102 RVA: 0x00017969 File Offset: 0x00015B69
		private static char GetChar(string value, int position)
		{
			if (value == null || value.Length <= position)
			{
				return '\0';
			}
			return value[position];
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x00017980 File Offset: 0x00015B80
		internal static int InternalGetNumberSectionCount(global::Infragistics.Controls.Editors.SectionsCollection sections)
		{
			int num = 0;
			foreach (global::Infragistics.Controls.Editors.SectionBase section in sections)
			{
				if (global::Infragistics.Controls.Editors.XamMaskedInput.IsSectionNumeric(section))
				{
					num++;
				}
			}
			return num;
		}

		// Token: 0x06000450 RID: 1104 RVA: 0x000179D0 File Offset: 0x00015BD0
		internal static string GetCultureAMPMDesignator(bool am, global::System.IFormatProvider formatProvider)
		{
			global::System.Globalization.DateTimeFormatInfo dateTimeFormatInfo = global::Infragistics.Controls.Editors.XamMaskedInput.InternalGetDateTimeFormatInfo(formatProvider);
			if (!am)
			{
				return dateTimeFormatInfo.PMDesignator;
			}
			return dateTimeFormatInfo.AMDesignator;
		}

		// Token: 0x06000451 RID: 1105 RVA: 0x000179F4 File Offset: 0x00015BF4
		internal void IllegalOperation(string message)
		{
			global::Infragistics.Controls.Editors.InvalidOperationEventArgs invalidOperationEventArgs = new global::Infragistics.Controls.Editors.InvalidOperationEventArgs(message);
			this.OnInvalidOperation(invalidOperationEventArgs);
			if (invalidOperationEventArgs.Beep)
			{
				this.Beep();
			}
		}

		// Token: 0x06000452 RID: 1106 RVA: 0x00017A20 File Offset: 0x00015C20
		private void UpdateSpinButtonVisibility()
		{
			bool flag = false;
			if (!base.IsReadOnly)
			{
				switch (this.SpinButtonDisplayMode)
				{
				case global::Infragistics.Controls.Editors.SpinButtonDisplayMode.Always:
					flag = true;
					break;
				case global::Infragistics.Controls.Editors.SpinButtonDisplayMode.MouseOver:
					flag = (base.IsMouseOver || base.IsInEditMode);
					break;
				case global::Infragistics.Controls.Editors.SpinButtonDisplayMode.Focused:
					flag = base.IsInEditMode;
					break;
				}
			}
			base.SetValue(global::Infragistics.Controls.Editors.XamMaskedInput.SpinButtonVisibilityResolvedPropertyKey, flag ? global::Infragistics.KnownBoxes.VisibilityVisibleBox : global::Infragistics.KnownBoxes.VisibilityCollapsedBox);
		}

		// Token: 0x06000453 RID: 1107 RVA: 0x00017A91 File Offset: 0x00015C91
		private bool GetFlag(global::Infragistics.Controls.Editors.XamMaskedInput.InternalFlags flag)
		{
			return (this._flags & flag) != (global::Infragistics.Controls.Editors.XamMaskedInput.InternalFlags)0;
		}

		// Token: 0x06000454 RID: 1108 RVA: 0x00017AA1 File Offset: 0x00015CA1
		private void SetFlag(global::Infragistics.Controls.Editors.XamMaskedInput.InternalFlags flag, bool set)
		{
			if (set)
			{
				this._flags |= flag;
				return;
			}
			this._flags &= ~flag;
		}

		// Token: 0x06000455 RID: 1109 RVA: 0x00017AC4 File Offset: 0x00015CC4
		private static void OnTrimFractionalZerosChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Editors.XamMaskedInput xamMaskedInput = (global::Infragistics.Controls.Editors.XamMaskedInput)d;
			xamMaskedInput.SetFlag(global::Infragistics.Controls.Editors.XamMaskedInput.InternalFlags.TrimFractionalZeros, (bool)e.NewValue);
			xamMaskedInput.ProcessPropertyChanged(e);
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x06000456 RID: 1110 RVA: 0x00017AF2 File Offset: 0x00015CF2
		// (set) Token: 0x06000457 RID: 1111 RVA: 0x00017AFB File Offset: 0x00015CFB
		public bool TrimFractionalZeros
		{
			get
			{
				return this.GetFlag(global::Infragistics.Controls.Editors.XamMaskedInput.InternalFlags.TrimFractionalZeros);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Editors.XamMaskedInput.TrimFractionalZerosProperty, value);
			}
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x06000458 RID: 1112 RVA: 0x00017B0E File Offset: 0x00015D0E
		// (set) Token: 0x06000459 RID: 1113 RVA: 0x00017B20 File Offset: 0x00015D20
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Controls.Editors.SpinButtonDisplayMode SpinButtonDisplayMode
		{
			get
			{
				return (global::Infragistics.Controls.Editors.SpinButtonDisplayMode)base.GetValue(global::Infragistics.Controls.Editors.XamMaskedInput.SpinButtonDisplayModeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Editors.XamMaskedInput.SpinButtonDisplayModeProperty, value);
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x0600045A RID: 1114 RVA: 0x00017B33 File Offset: 0x00015D33
		// (set) Token: 0x0600045B RID: 1115 RVA: 0x00017B45 File Offset: 0x00015D45
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Style SpinButtonStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Controls.Editors.XamMaskedInput.SpinButtonStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Editors.XamMaskedInput.SpinButtonStyleProperty, value);
			}
		}

		// Token: 0x0600045C RID: 1116 RVA: 0x00017B54 File Offset: 0x00015D54
		private static void OnSpinButtonVisibilityResolvedChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Editors.XamMaskedInput xamMaskedInput = (global::Infragistics.Controls.Editors.XamMaskedInput)d;
			xamMaskedInput.ProcessPropertyChanged(e);
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x0600045D RID: 1117 RVA: 0x00017B6F File Offset: 0x00015D6F
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		public global::System.Windows.Visibility SpinButtonVisibilityResolved
		{
			get
			{
				return (global::System.Windows.Visibility)base.GetValue(global::Infragistics.Controls.Editors.XamMaskedInput.SpinButtonVisibilityResolvedProperty);
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x0600045E RID: 1118 RVA: 0x00017B81 File Offset: 0x00015D81
		// (set) Token: 0x0600045F RID: 1119 RVA: 0x00017B8E File Offset: 0x00015D8E
		[global::System.ComponentModel.Bindable(true)]
		public object SpinIncrement
		{
			get
			{
				return base.GetValue(global::Infragistics.Controls.Editors.XamMaskedInput.SpinIncrementProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Editors.XamMaskedInput.SpinIncrementProperty, value);
			}
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x06000460 RID: 1120 RVA: 0x00017B9C File Offset: 0x00015D9C
		internal bool HasSpinIncrement
		{
			get
			{
				return null != this.SpinIncrement;
			}
		}

		// Token: 0x06000461 RID: 1121 RVA: 0x00017BAC File Offset: 0x00015DAC
		private static void OnSpinIncrementChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Editors.XamMaskedInput xamMaskedInput = (global::Infragistics.Controls.Editors.XamMaskedInput)dependencyObject;
			object newValue = e.NewValue;
			xamMaskedInput._cachedSpinInfo = ((newValue != null) ? global::Infragistics.Controls.Editors.Primitives.SpinInfo.Parse(xamMaskedInput, newValue) : null);
			xamMaskedInput.ProcessPropertyChanged(e);
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x06000462 RID: 1122 RVA: 0x00017BE2 File Offset: 0x00015DE2
		// (set) Token: 0x06000463 RID: 1123 RVA: 0x00017BEB File Offset: 0x00015DEB
		public bool SpinWrap
		{
			get
			{
				return this.GetFlag(global::Infragistics.Controls.Editors.XamMaskedInput.InternalFlags.SpinWrap);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Editors.XamMaskedInput.SpinWrapProperty, value);
			}
		}

		// Token: 0x06000464 RID: 1124 RVA: 0x00017C00 File Offset: 0x00015E00
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

		// Token: 0x06000465 RID: 1125 RVA: 0x00017C2C File Offset: 0x00015E2C
		private static void OnSectionsChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Controls.Editors.XamMaskedInput)d).OnSectionsChanged();
		}

		// Token: 0x06000466 RID: 1126 RVA: 0x00017C39 File Offset: 0x00015E39
		internal virtual void OnSectionsChanged()
		{
			if (this._editInfo != null && this._editInfo._imeTextBox != null)
			{
				this._editInfo._imeTextBox.OnSectionsChanged();
			}
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x06000467 RID: 1127 RVA: 0x00017C60 File Offset: 0x00015E60
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.ReadOnly(true)]
		public global::Infragistics.Controls.Editors.SectionsCollection Sections
		{
			get
			{
				return (global::Infragistics.Controls.Editors.SectionsCollection)base.GetValue(global::Infragistics.Controls.Editors.XamMaskedInput.SectionsProperty);
			}
		}

		// Token: 0x06000468 RID: 1128 RVA: 0x00017C72 File Offset: 0x00015E72
		internal void InternalSetSections(global::Infragistics.Controls.Editors.SectionsCollection sections)
		{
			base.SetValue(global::Infragistics.Controls.Editors.XamMaskedInput.SectionsPropertyKey, sections);
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x06000469 RID: 1129 RVA: 0x00017C80 File Offset: 0x00015E80
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::Infragistics.Controls.Editors.DisplayCharsCollection DisplayChars
		{
			get
			{
				global::Infragistics.Controls.Editors.SectionsCollection sections = this.Sections;
				if (this._displayChars_Sections != sections)
				{
					if (this._displayChars == null)
					{
						this._displayChars = new global::Infragistics.Controls.Editors.DisplayCharsCollection();
					}
					this._displayChars.Clear();
					if (sections != null)
					{
						for (int i = 0; i < sections.Count; i++)
						{
							global::Infragistics.Controls.Editors.SectionBase sectionBase = sections[i];
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

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x0600046A RID: 1130 RVA: 0x00017D11 File Offset: 0x00015F11
		internal bool DesignMode
		{
			get
			{
				return false;
			}
		}

		// Token: 0x0600046B RID: 1131 RVA: 0x00017D14 File Offset: 0x00015F14
		public static void RegisterDefaultMaskForType(global::System.Type dataType, string mask)
		{
			lock (global::Infragistics.Controls.Editors.XamMaskedInput.g_defaultMaskTable)
			{
				if (mask != null && mask.Length > 0)
				{
					global::Infragistics.Controls.Editors.XamMaskedInput.g_defaultMaskTable[dataType] = mask;
					global::Infragistics.Controls.Editors.XamMaskedInput.g_defaultMaskTableInitialized = true;
				}
				else if (global::Infragistics.Controls.Editors.XamMaskedInput.g_defaultMaskTable.ContainsKey(dataType))
				{
					global::Infragistics.Controls.Editors.XamMaskedInput.g_defaultMaskTable.Remove(dataType);
					if (global::Infragistics.Controls.Editors.XamMaskedInput.g_defaultMaskTable.Count == 0)
					{
						global::Infragistics.Controls.Editors.XamMaskedInput.g_defaultMaskTableInitialized = false;
					}
				}
			}
		}

		// Token: 0x0600046C RID: 1132 RVA: 0x00017D98 File Offset: 0x00015F98
		public static void ResetDefaultMaskForType(global::System.Type dataType)
		{
			global::Infragistics.Controls.Editors.XamMaskedInput.RegisterDefaultMaskForType(dataType, null);
		}

		// Token: 0x0600046D RID: 1133 RVA: 0x00017DA4 File Offset: 0x00015FA4
		public static string GetDefaultMaskForType(global::System.Type dataType)
		{
			if (global::Infragistics.Controls.Editors.XamMaskedInput.g_defaultMaskTableInitialized)
			{
				lock (global::Infragistics.Controls.Editors.XamMaskedInput.g_defaultMaskTable)
				{
					string text = global::Infragistics.Controls.Editors.XamMaskedInput.g_defaultMaskTable[dataType];
					if (text != null && text.Length > 0)
					{
						return text;
					}
				}
			}
			return global::Infragistics.Controls.Editors.XamMaskedInput.GetDefaultMaskForTypeHelper(dataType);
		}

		// Token: 0x0600046E RID: 1134 RVA: 0x00017E08 File Offset: 0x00016008
		private static string GetDefaultMaskForTypeHelper(global::System.Type type)
		{
			type = global::Infragistics.CoreUtilities.GetUnderlyingType(type);
			string result = null;
			if (typeof(global::System.DateTime) == type)
			{
				result = "{date}";
			}
			else if (typeof(byte) == type)
			{
				result = "{number:0-255}";
			}
			else if (typeof(sbyte) == type)
			{
				result = "{number:-128-127}";
			}
			else if (typeof(short) == type)
			{
				result = "{number:-32768-32767}";
			}
			else if (typeof(ushort) == type)
			{
				result = "{number:0-65535}";
			}
			else if (typeof(int) == type)
			{
				result = "{number:-2147483648-2147483647}";
			}
			else if (typeof(uint) == type)
			{
				result = "{number:0-4294967295}";
			}
			else if (typeof(long) == type)
			{
				result = "{number:-9223372036854775808-9223372036854775807}";
			}
			else if (typeof(ulong) == type)
			{
				result = "{number:0-18446744073709551615}";
			}
			else if (typeof(decimal) == type)
			{
				result = "{currency}";
			}
			else if (typeof(double) == type || typeof(float) == type)
			{
				result = "{double}";
			}
			else if (typeof(string) == type)
			{
				result = new string('&', 64);
			}
			return result;
		}

		// Token: 0x0600046F RID: 1135 RVA: 0x00017F84 File Offset: 0x00016184
		public static bool SupportsDataType(global::System.Type dataType)
		{
			bool flag;
			return global::Infragistics.Controls.Editors.XamMaskedInput.SupportsDataType(dataType, out flag);
		}

		// Token: 0x06000470 RID: 1136 RVA: 0x00017F9C File Offset: 0x0001619C
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

		// Token: 0x06000471 RID: 1137 RVA: 0x00018134 File Offset: 0x00016334
		public static string CalcDefaultTimeMask(global::System.IFormatProvider formatProvider)
		{
			global::System.Globalization.DateTimeFormatInfo dateTimeFormatInfo = global::Infragistics.Controls.Editors.XamMaskedInput.InternalGetDateTimeFormatInfo(formatProvider);
			bool flag = false;
			bool flag2 = false;
			string shortTimePattern = dateTimeFormatInfo.ShortTimePattern;
			char cultureChar = global::Infragistics.Controls.Editors.XamMaskedInput.GetCultureChar(':', formatProvider);
			if (cultureChar == global::Infragistics.Controls.Editors.XamMaskedInput.g_lastTimeSeparator && shortTimePattern == global::Infragistics.Controls.Editors.XamMaskedInput.g_lastShortTimePattern)
			{
				return global::Infragistics.Controls.Editors.XamMaskedInput.g_lastDefaultTimeMask;
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
			global::Infragistics.Controls.Editors.XamMaskedInput.g_lastDefaultTimeMask = text;
			global::Infragistics.Controls.Editors.XamMaskedInput.g_lastShortTimePattern = shortTimePattern;
			global::Infragistics.Controls.Editors.XamMaskedInput.g_lastTimeSeparator = cultureChar;
			return text;
		}

		// Token: 0x06000472 RID: 1138 RVA: 0x00018210 File Offset: 0x00016410
		public static string CalcDefaultLongTimeMask(global::System.IFormatProvider formatProvider)
		{
			global::System.Globalization.DateTimeFormatInfo dateTimeFormatInfo = global::Infragistics.Controls.Editors.XamMaskedInput.InternalGetDateTimeFormatInfo(formatProvider);
			bool flag = false;
			bool flag2 = false;
			string longTimePattern = dateTimeFormatInfo.LongTimePattern;
			char cultureChar = global::Infragistics.Controls.Editors.XamMaskedInput.GetCultureChar(':', formatProvider);
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

		// Token: 0x06000473 RID: 1139 RVA: 0x000182BC File Offset: 0x000164BC
		public static string CalcDefaultDateMask(global::System.IFormatProvider formatProvider)
		{
			return global::Infragistics.Controls.Editors.XamMaskedInput.CalcDefaultDateMask(formatProvider, true);
		}

		// Token: 0x06000474 RID: 1140 RVA: 0x000182C8 File Offset: 0x000164C8
		public static string CalcDefaultDateMask(global::System.IFormatProvider formatProvider, bool usePostfixSeparatorsFromLongDatePattern)
		{
			global::System.Globalization.DateTimeFormatInfo dateTimeFormatInfo = global::Infragistics.Controls.Editors.XamMaskedInput.InternalGetDateTimeFormatInfo(formatProvider);
			string shortDatePattern = dateTimeFormatInfo.ShortDatePattern;
			string text = null;
			char cultureChar = global::Infragistics.Controls.Editors.XamMaskedInput.GetCultureChar('/', formatProvider);
			if (cultureChar == global::Infragistics.Controls.Editors.XamMaskedInput.g_lastDateSeparator && shortDatePattern == global::Infragistics.Controls.Editors.XamMaskedInput.g_lastShortDatePattern && formatProvider == global::Infragistics.Controls.Editors.XamMaskedInput.g_lastDateFormatProvider && usePostfixSeparatorsFromLongDatePattern == global::Infragistics.Controls.Editors.XamMaskedInput.g_lastUsePostfixSeparatorsFromLongDatePattern)
			{
				return global::Infragistics.Controls.Editors.XamMaskedInput.g_lastDefaultDateMask;
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
					global::System.Collections.Generic.Dictionary<global::System.Type, char> dictionary = null;
					text = global::Infragistics.Controls.Editors.XamMaskedInput.GetNonstandardForeignDateMaskAndPostfixSymbols(dateTimeFormatInfo, ref dictionary);
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
			global::Infragistics.Controls.Editors.XamMaskedInput.g_lastDefaultDateMask = text;
			global::Infragistics.Controls.Editors.XamMaskedInput.g_lastShortDatePattern = shortDatePattern;
			global::Infragistics.Controls.Editors.XamMaskedInput.g_lastDateSeparator = cultureChar;
			global::Infragistics.Controls.Editors.XamMaskedInput.g_lastDateFormatProvider = formatProvider;
			global::Infragistics.Controls.Editors.XamMaskedInput.g_lastUsePostfixSeparatorsFromLongDatePattern = usePostfixSeparatorsFromLongDatePattern;
			return text;
		}

		// Token: 0x06000475 RID: 1141 RVA: 0x000184AC File Offset: 0x000166AC
		public static string CalcDefaultCurrencyMask(global::System.IFormatProvider formatProvider, int integerDigits, int fractionDigits, char allowNegatives, bool includeCurrencySymbol)
		{
			global::System.Globalization.NumberFormatInfo numberFormatInfo = global::Infragistics.Controls.Editors.XamMaskedInput.InternalGetNumberFormatInfo(formatProvider);
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(15);
			int currencyPositivePattern = numberFormatInfo.CurrencyPositivePattern;
			bool flag = currencyPositivePattern > 1;
			bool flag2 = currencyPositivePattern % 2 == 0;
			if (flag2 && includeCurrencySymbol)
			{
				string value;
				global::Infragistics.Controls.Editors.MaskParser.EscapeLiteralsInString(numberFormatInfo.CurrencySymbol, out value);
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
				global::Infragistics.Controls.Editors.MaskParser.EscapeLiteralsInString(numberFormatInfo.CurrencySymbol, out value2);
				stringBuilder.Append(value2);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06000476 RID: 1142 RVA: 0x00018614 File Offset: 0x00016814
		public static string CalcDefaultDoubleMask(global::System.IFormatProvider formatProvider, int integerDigits, int fractionDigits, char allowNegatives)
		{
			global::System.Globalization.NumberFormatInfo numberFormatInfo = global::Infragistics.Controls.Editors.XamMaskedInput.InternalGetNumberFormatInfo(formatProvider);
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

		// Token: 0x06000477 RID: 1143 RVA: 0x00018708 File Offset: 0x00016908
		internal static bool IsMaskValidForDataType(global::System.Type dataType, string mask, global::System.IFormatProvider formatProvider)
		{
			if (mask == null)
			{
				return false;
			}
			global::Infragistics.Controls.Editors.MaskInfo maskInfo = new global::Infragistics.Controls.Editors.MaskInfo();
			maskInfo.InitializeFormatProvider(formatProvider, null);
			global::Infragistics.Controls.Editors.SectionsCollection sectionsCollection;
			global::Infragistics.Controls.Editors.MaskParser.Parse(mask, out sectionsCollection, maskInfo.FormatProvider);
			sectionsCollection.Initialize(maskInfo);
			return global::Infragistics.Controls.Editors.XamMaskedInput.IsMaskValidForDataType(dataType, sectionsCollection);
		}

		// Token: 0x06000478 RID: 1144 RVA: 0x00018744 File Offset: 0x00016944
		internal static bool IsMaskValidForDataType(global::System.Type dataType, global::Infragistics.Controls.Editors.SectionsCollection parsedSections)
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
				int i = 0;
				int count = parsedSections.Count;
				while (i < count)
				{
					global::Infragistics.Controls.Editors.SectionBase sectionBase = parsedSections[i];
					if (sectionBase is global::Infragistics.Controls.Editors.DaySection)
					{
						num2++;
					}
					else if (sectionBase is global::Infragistics.Controls.Editors.YearSection)
					{
						num3++;
					}
					else if (sectionBase is global::Infragistics.Controls.Editors.MonthSection)
					{
						num++;
					}
					else if (sectionBase is global::Infragistics.Controls.Editors.MinuteSection)
					{
						num4++;
					}
					else if (sectionBase is global::Infragistics.Controls.Editors.HourSection)
					{
						num5++;
					}
					else if (sectionBase is global::Infragistics.Controls.Editors.SecondSection)
					{
						num6++;
					}
					else if (sectionBase is global::Infragistics.Controls.Editors.AMPMSection)
					{
						num7++;
					}
					else if (!(sectionBase is global::Infragistics.Controls.Editors.LiteralSection))
					{
						return false;
					}
					i++;
				}
				bool flag = num <= 1 && num2 <= 1 && num3 <= 1 && num5 <= 1 && num4 <= 1 && num6 <= 1 && num7 <= 1;
				return flag && (1 == num || 1 == num2 || 1 == num3 || 1 == num5);
			}
			if (typeof(byte) == underlyingType || typeof(sbyte) == underlyingType || typeof(short) == underlyingType || typeof(ushort) == underlyingType || typeof(short) == underlyingType || typeof(int) == underlyingType || typeof(uint) == underlyingType || typeof(int) == underlyingType || typeof(long) == underlyingType || typeof(ulong) == underlyingType || typeof(long) == underlyingType)
			{
				int num8 = 0;
				int j = 0;
				int count2 = parsedSections.Count;
				while (j < count2)
				{
					if (global::Infragistics.Controls.Editors.XamMaskedInput.IsSectionNumeric(parsedSections[j]))
					{
						num8++;
					}
					if (num8 >= 2)
					{
						break;
					}
					j++;
				}
				return 1 == num8;
			}
			if (typeof(double) == underlyingType || typeof(float) == underlyingType || typeof(decimal) == underlyingType)
			{
				global::Infragistics.Controls.Editors.SectionBase sectionBase2 = null;
				global::Infragistics.Controls.Editors.SectionBase sectionBase3 = null;
				bool flag2 = false;
				int k = 0;
				int count3 = parsedSections.Count;
				while (k < count3)
				{
					global::Infragistics.Controls.Editors.SectionBase sectionBase4 = parsedSections[k];
					if (global::Infragistics.Controls.Editors.XamMaskedInput.IsSectionNumeric(sectionBase4))
					{
						if (!flag2)
						{
							sectionBase2 = sectionBase4;
						}
						else
						{
							if (sectionBase3 != null)
							{
								return false;
							}
							sectionBase3 = sectionBase4;
						}
					}
					else if (sectionBase4 is global::Infragistics.Controls.Editors.LiteralSection && 1 == sectionBase4.DisplayChars.Count && sectionBase4.CommaChar == sectionBase4.DisplayChars[0].Char)
					{
						if (flag2)
						{
							return false;
						}
						sectionBase2 = null;
					}
					else if (sectionBase4 is global::Infragistics.Controls.Editors.LiteralSection && 1 == sectionBase4.DisplayChars.Count && sectionBase4.DecimalSeperatorChar == sectionBase4.DisplayChars[0].Char)
					{
						flag2 = true;
					}
					else if ((sectionBase2 != null || sectionBase3 != null || flag2) && !(sectionBase4 is global::Infragistics.Controls.Editors.LiteralSection))
					{
						return false;
					}
					k++;
				}
				return sectionBase2 != null || null != sectionBase3;
			}
			return typeof(string) == underlyingType;
		}

		// Token: 0x06000479 RID: 1145 RVA: 0x00018AC0 File Offset: 0x00016CC0
		public string GetText(global::Infragistics.Controls.Editors.InputMaskMode maskMode)
		{
			global::Infragistics.Controls.Editors.EditInfo editInfo = this.EditInfo;
			if (editInfo != null)
			{
				return editInfo.GetText(maskMode);
			}
			global::Infragistics.Controls.Editors.MaskInfo maskInfo = this.MaskInfo;
			return global::Infragistics.Controls.Editors.XamMaskedInput.GetText(maskInfo.Sections, maskMode, maskInfo);
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x0600047A RID: 1146 RVA: 0x00018AF3 File Offset: 0x00016CF3
		internal global::Infragistics.Controls.Editors.MaskInfo MaskInfo
		{
			get
			{
				return this._maskInfo;
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x0600047B RID: 1147 RVA: 0x00018AFB File Offset: 0x00016CFB
		internal global::Infragistics.Controls.Editors.EditInfo EditInfo
		{
			get
			{
				return this._editInfo;
			}
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x0600047C RID: 1148 RVA: 0x00018B03 File Offset: 0x00016D03
		// (set) Token: 0x0600047D RID: 1149 RVA: 0x00018B0C File Offset: 0x00016D0C
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.Bindable(true)]
		public bool InsertMode
		{
			get
			{
				return this.GetFlag(global::Infragistics.Controls.Editors.XamMaskedInput.InternalFlags.InsertMode);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Editors.XamMaskedInput.InsertModeProperty, value);
			}
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x0600047E RID: 1150 RVA: 0x00018B1F File Offset: 0x00016D1F
		// (set) Token: 0x0600047F RID: 1151 RVA: 0x00018B27 File Offset: 0x00016D27
		[global::System.ComponentModel.RefreshProperties(global::System.ComponentModel.RefreshProperties.All)]
		public string Mask
		{
			get
			{
				return this._cachedMask;
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Editors.XamMaskedInput.MaskProperty, value);
			}
		}

		// Token: 0x06000480 RID: 1152 RVA: 0x00018B38 File Offset: 0x00016D38
		private static void OnMaskChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Editors.XamMaskedInput xamMaskedInput = (global::Infragistics.Controls.Editors.XamMaskedInput)dependencyObject;
			xamMaskedInput._cachedMask = (string)e.NewValue;
			if (xamMaskedInput.InternalIsInitialized)
			{
				xamMaskedInput.ReparseMask();
			}
			xamMaskedInput.ProcessPropertyChanged(e);
		}

		// Token: 0x06000481 RID: 1153 RVA: 0x00018B73 File Offset: 0x00016D73
		private void ReparseMask()
		{
			if (this._maskInfo != null)
			{
				this._maskInfo.RecreateSections(false);
			}
			base.SyncValueProperties(global::Infragistics.Controls.Editors.ValueInput.ValueProperty, base.Value);
		}

		// Token: 0x06000482 RID: 1154 RVA: 0x00018B9A File Offset: 0x00016D9A
		protected override void OnValueTypeResolvedChanged(global::System.Type newType)
		{
			base.OnValueTypeResolvedChanged(newType);
			if (this._maskInfo != null)
			{
				this._maskInfo.DataType = base.ValueTypeResolved;
				if (base.InternalIsInitialized)
				{
					this.ReparseMask();
				}
			}
		}

		// Token: 0x06000483 RID: 1155 RVA: 0x00018BCA File Offset: 0x00016DCA
		private void ApplyMaskToText()
		{
			base.SyncValueProperties(global::Infragistics.Controls.Editors.ValueInput.ValueProperty, base.Value);
			base.SyncDisplayText();
		}

		// Token: 0x06000484 RID: 1156 RVA: 0x00018BE4 File Offset: 0x00016DE4
		public static string ApplyMask(string text, string mask, global::System.IFormatProvider formatProvider, char promptCharacter, char padCharacter, global::Infragistics.Controls.Editors.InputMaskMode maskMode)
		{
			global::Infragistics.Controls.Editors.ParsedMask parsedMask = new global::Infragistics.Controls.Editors.ParsedMask(mask, formatProvider, promptCharacter, padCharacter);
			return parsedMask.ApplyMask(text, maskMode);
		}

		// Token: 0x06000485 RID: 1157 RVA: 0x00018C08 File Offset: 0x00016E08
		internal override bool SyncValuePropertiesOverride(global::System.Windows.DependencyProperty prop, object newValue, out global::System.Exception error)
		{
			bool result = base.SyncValuePropertiesOverride(prop, newValue, out error);
			global::System.Exception ex;
			if ((this._editInfo == null || !this._editInfo._inOnTextChanged) && !this.MaskInfo.InternalRefreshValue(base.Value, out ex))
			{
				if (error == null)
				{
					error = ex;
				}
				result = false;
			}
			if (this._editInfo != null)
			{
				this._editInfo.SyncIMETextBox(false);
			}
			return result;
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x06000486 RID: 1158 RVA: 0x00018C67 File Offset: 0x00016E67
		// (set) Token: 0x06000487 RID: 1159 RVA: 0x00018C6F File Offset: 0x00016E6F
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Controls.Editors.InputMaskMode DataMode
		{
			get
			{
				return this._cachedDataMode;
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Editors.XamMaskedInput.DataModeProperty, value);
			}
		}

		// Token: 0x06000488 RID: 1160 RVA: 0x00018C84 File Offset: 0x00016E84
		private static void OnDataModeChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Editors.XamMaskedInput xamMaskedInput = (global::Infragistics.Controls.Editors.XamMaskedInput)dependencyObject;
			global::Infragistics.Controls.Editors.InputMaskMode inputMaskMode = (global::Infragistics.Controls.Editors.InputMaskMode)e.NewValue;
			xamMaskedInput._cachedDataMode = inputMaskMode;
			if (xamMaskedInput._maskInfo != null)
			{
				xamMaskedInput._maskInfo.DataMode = inputMaskMode;
			}
			if (xamMaskedInput.InternalIsInitialized)
			{
				xamMaskedInput.ApplyMaskToText();
			}
			xamMaskedInput.ProcessPropertyChanged(e);
		}

		// Token: 0x06000489 RID: 1161 RVA: 0x00018CD5 File Offset: 0x00016ED5
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeDataMode()
		{
			return global::Infragistics.DependencyPropertyUtilities.ShouldSerialize(this, global::Infragistics.Controls.Editors.XamMaskedInput.DataModeProperty);
		}

		// Token: 0x0600048A RID: 1162 RVA: 0x00018CE2 File Offset: 0x00016EE2
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetDataMode()
		{
			base.ClearValue(global::Infragistics.Controls.Editors.XamMaskedInput.DataModeProperty);
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x0600048B RID: 1163 RVA: 0x00018CEF File Offset: 0x00016EEF
		// (set) Token: 0x0600048C RID: 1164 RVA: 0x00018CF7 File Offset: 0x00016EF7
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Controls.Editors.InputMaskMode ClipMode
		{
			get
			{
				return this._cachedClipMode;
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Editors.XamMaskedInput.ClipModeProperty, value);
			}
		}

		// Token: 0x0600048D RID: 1165 RVA: 0x00018D0C File Offset: 0x00016F0C
		private static void OnClipModeChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Editors.XamMaskedInput xamMaskedInput = (global::Infragistics.Controls.Editors.XamMaskedInput)dependencyObject;
			global::Infragistics.Controls.Editors.InputMaskMode inputMaskMode = (global::Infragistics.Controls.Editors.InputMaskMode)e.NewValue;
			xamMaskedInput._cachedClipMode = inputMaskMode;
			if (xamMaskedInput._maskInfo != null)
			{
				xamMaskedInput._maskInfo.ClipMode = inputMaskMode;
			}
			xamMaskedInput.ProcessPropertyChanged(e);
		}

		// Token: 0x0600048E RID: 1166 RVA: 0x00018D4F File Offset: 0x00016F4F
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeClipMode()
		{
			return global::Infragistics.DependencyPropertyUtilities.ShouldSerialize(this, global::Infragistics.Controls.Editors.XamMaskedInput.ClipModeProperty);
		}

		// Token: 0x0600048F RID: 1167 RVA: 0x00018D5C File Offset: 0x00016F5C
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetClipMode()
		{
			base.ClearValue(global::Infragistics.Controls.Editors.XamMaskedInput.ClipModeProperty);
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x06000490 RID: 1168 RVA: 0x00018D69 File Offset: 0x00016F69
		// (set) Token: 0x06000491 RID: 1169 RVA: 0x00018D71 File Offset: 0x00016F71
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Controls.Editors.InputMaskMode DisplayMode
		{
			get
			{
				return this._cachedDisplayMode;
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Editors.XamMaskedInput.DisplayModeProperty, value);
			}
		}

		// Token: 0x06000492 RID: 1170 RVA: 0x00018D84 File Offset: 0x00016F84
		private static void OnDisplayModeChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Editors.XamMaskedInput xamMaskedInput = (global::Infragistics.Controls.Editors.XamMaskedInput)dependencyObject;
			global::Infragistics.Controls.Editors.InputMaskMode inputMaskMode = (global::Infragistics.Controls.Editors.InputMaskMode)e.NewValue;
			xamMaskedInput._cachedDisplayMode = inputMaskMode;
			if (xamMaskedInput._maskInfo != null)
			{
				xamMaskedInput._maskInfo.DisplayMode = inputMaskMode;
			}
			xamMaskedInput.ProcessPropertyChanged(e);
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x00018DC7 File Offset: 0x00016FC7
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeDisplayMode()
		{
			return global::Infragistics.DependencyPropertyUtilities.ShouldSerialize(this, global::Infragistics.Controls.Editors.XamMaskedInput.DisplayModeProperty);
		}

		// Token: 0x06000494 RID: 1172 RVA: 0x00018DD4 File Offset: 0x00016FD4
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetDisplayMode()
		{
			base.ClearValue(global::Infragistics.Controls.Editors.XamMaskedInput.DisplayModeProperty);
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x06000495 RID: 1173 RVA: 0x00018DE1 File Offset: 0x00016FE1
		// (set) Token: 0x06000496 RID: 1174 RVA: 0x00018DE9 File Offset: 0x00016FE9
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Controls.Editors.Primitives.MaskCharConverter))]
		[global::System.ComponentModel.Bindable(true)]
		public char PadChar
		{
			get
			{
				return this._cachedPadChar;
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Editors.XamMaskedInput.PadCharProperty, value);
			}
		}

		// Token: 0x06000497 RID: 1175 RVA: 0x00018DFC File Offset: 0x00016FFC
		private static bool ValidatePadChar(object objVal)
		{
			return global::Infragistics.Controls.Editors.XamMaskedInput.IsValidPromptChar((char)objVal);
		}

		// Token: 0x06000498 RID: 1176 RVA: 0x00018E0C File Offset: 0x0001700C
		private static void OnPadCharChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Editors.XamMaskedInput xamMaskedInput = (global::Infragistics.Controls.Editors.XamMaskedInput)dependencyObject;
			char c = (char)e.NewValue;
			xamMaskedInput._cachedPadChar = c;
			global::Infragistics.Controls.Editors.XamMaskedInput.ValidatePadChar(c);
			xamMaskedInput.NotifyDisplayCharDrawStringsChanged();
			xamMaskedInput.ProcessPropertyChanged(e);
		}

		// Token: 0x06000499 RID: 1177 RVA: 0x00018E4D File Offset: 0x0001704D
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializePadChar()
		{
			return global::Infragistics.DependencyPropertyUtilities.ShouldSerialize(this, global::Infragistics.Controls.Editors.XamMaskedInput.PadCharProperty);
		}

		// Token: 0x0600049A RID: 1178 RVA: 0x00018E5A File Offset: 0x0001705A
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetPadChar()
		{
			base.ClearValue(global::Infragistics.Controls.Editors.XamMaskedInput.PadCharProperty);
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x0600049B RID: 1179 RVA: 0x00018E67 File Offset: 0x00017067
		// (set) Token: 0x0600049C RID: 1180 RVA: 0x00018E6F File Offset: 0x0001706F
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Controls.Editors.Primitives.MaskCharConverter))]
		[global::System.ComponentModel.Bindable(true)]
		public char PromptChar
		{
			get
			{
				return this._cachedPromptChar;
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Editors.XamMaskedInput.PromptCharProperty, value);
			}
		}

		// Token: 0x0600049D RID: 1181 RVA: 0x00018E82 File Offset: 0x00017082
		private static bool ValidatePromptChar(object objVal)
		{
			return global::Infragistics.Controls.Editors.XamMaskedInput.IsValidPromptChar((char)objVal);
		}

		// Token: 0x0600049E RID: 1182 RVA: 0x00018E90 File Offset: 0x00017090
		private static void OnPromptCharChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Editors.XamMaskedInput xamMaskedInput = (global::Infragistics.Controls.Editors.XamMaskedInput)dependencyObject;
			char c = (char)e.NewValue;
			xamMaskedInput._cachedPromptChar = c;
			global::Infragistics.Controls.Editors.XamMaskedInput.ValidatePromptChar(c);
			xamMaskedInput.NotifyDisplayCharDrawStringsChanged();
			xamMaskedInput.ProcessPropertyChanged(e);
		}

		// Token: 0x0600049F RID: 1183 RVA: 0x00018ED1 File Offset: 0x000170D1
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializePromptChar()
		{
			return global::Infragistics.DependencyPropertyUtilities.ShouldSerialize(this, global::Infragistics.Controls.Editors.XamMaskedInput.PromptCharProperty);
		}

		// Token: 0x060004A0 RID: 1184 RVA: 0x00018EDE File Offset: 0x000170DE
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetPromptChar()
		{
			base.ClearValue(global::Infragistics.Controls.Editors.XamMaskedInput.PromptCharProperty);
		}

		// Token: 0x060004A1 RID: 1185 RVA: 0x00018EEB File Offset: 0x000170EB
		public void SelectAll()
		{
			this.EditInfo.SelectAll();
		}

		// Token: 0x060004A2 RID: 1186 RVA: 0x00018EF8 File Offset: 0x000170F8
		public bool Delete()
		{
			return this.EditInfo.Delete(false, true);
		}

		// Token: 0x060004A3 RID: 1187 RVA: 0x00018F07 File Offset: 0x00017107
		public void Copy()
		{
			this.EditInfo.Copy();
		}

		// Token: 0x060004A4 RID: 1188 RVA: 0x00018F14 File Offset: 0x00017114
		public void Cut()
		{
			this.EditInfo.Cut();
		}

		// Token: 0x060004A5 RID: 1189 RVA: 0x00018F21 File Offset: 0x00017121
		public void Paste()
		{
			this.EditInfo.Paste();
		}

		// Token: 0x060004A6 RID: 1190 RVA: 0x00018F2E File Offset: 0x0001712E
		public void ToggleInsertMode()
		{
			this.EditInfo.ToggleInsertMode();
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x060004A7 RID: 1191 RVA: 0x00018F3B File Offset: 0x0001713B
		// (set) Token: 0x060004A8 RID: 1192 RVA: 0x00018F4D File Offset: 0x0001714D
		public global::Infragistics.Controls.Editors.MaskedEditTabNavigation SectionTabNavigation
		{
			get
			{
				return (global::Infragistics.Controls.Editors.MaskedEditTabNavigation)base.GetValue(global::Infragistics.Controls.Editors.XamMaskedInput.SectionTabNavigationProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Editors.XamMaskedInput.SectionTabNavigationProperty, value);
			}
		}

		// Token: 0x060004A9 RID: 1193 RVA: 0x00018F60 File Offset: 0x00017160
		private void SetCommand(global::System.Windows.Controls.MenuItem item, global::Infragistics.Controls.Editors.Primitives.MaskedInputCommandId command)
		{
			global::Infragistics.Controls.Editors.Primitives.MaskedInputCommandSource command2 = new global::Infragistics.Controls.Editors.Primitives.MaskedInputCommandSource
			{
				CommandId = command,
				EventName = "Click",
				Target = this
			};
			global::Infragistics.Controls.Commanding.SetCommand(item, command2);
		}

		// Token: 0x060004AA RID: 1194 RVA: 0x00018F98 File Offset: 0x00017198
		internal global::System.Windows.Controls.ContextMenu CreateContextMenu()
		{
			global::System.Windows.Controls.ContextMenu contextMenu = new global::System.Windows.Controls.ContextMenu();
			global::System.Windows.Controls.MenuItem menuItem = new global::System.Windows.Controls.MenuItem();
			contextMenu.Items.Add(menuItem);
			this.SetCommand(menuItem, global::Infragistics.Controls.Editors.Primitives.MaskedInputCommandId.Undo);
			menuItem.CommandTarget = this;
			menuItem.Header = global::System.Windows.Input.ApplicationCommands.Undo.Text;
			contextMenu.Items.Add(new global::System.Windows.Controls.Separator());
			menuItem = new global::System.Windows.Controls.MenuItem();
			contextMenu.Items.Add(menuItem);
			this.SetCommand(menuItem, global::Infragistics.Controls.Editors.Primitives.MaskedInputCommandId.Cut);
			menuItem.CommandTarget = this;
			menuItem.Header = global::System.Windows.Input.ApplicationCommands.Cut.Text;
			menuItem = new global::System.Windows.Controls.MenuItem();
			contextMenu.Items.Add(menuItem);
			this.SetCommand(menuItem, global::Infragistics.Controls.Editors.Primitives.MaskedInputCommandId.Copy);
			menuItem.CommandTarget = this;
			menuItem.Header = global::System.Windows.Input.ApplicationCommands.Copy.Text;
			menuItem = new global::System.Windows.Controls.MenuItem();
			contextMenu.Items.Add(menuItem);
			this.SetCommand(menuItem, global::Infragistics.Controls.Editors.Primitives.MaskedInputCommandId.Paste);
			menuItem.CommandTarget = this;
			menuItem.Header = global::System.Windows.Input.ApplicationCommands.Paste.Text;
			menuItem = new global::System.Windows.Controls.MenuItem();
			contextMenu.Items.Add(menuItem);
			this.SetCommand(menuItem, global::Infragistics.Controls.Editors.Primitives.MaskedInputCommandId.Delete);
			menuItem.CommandTarget = this;
			menuItem.Header = global::System.Windows.Input.ApplicationCommands.Delete.Text;
			contextMenu.Items.Add(new global::System.Windows.Controls.Separator());
			menuItem = new global::System.Windows.Controls.MenuItem();
			contextMenu.Items.Add(menuItem);
			this.SetCommand(menuItem, global::Infragistics.Controls.Editors.Primitives.MaskedInputCommandId.SelectAll);
			menuItem.CommandTarget = this;
			menuItem.Header = global::System.Windows.Input.ApplicationCommands.SelectAll.Text;
			return contextMenu;
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x060004AB RID: 1195 RVA: 0x00019104 File Offset: 0x00017304
		internal global::Infragistics.Controls.Editors.MaskedEditTabNavigation SectionTabNavigationResolved
		{
			get
			{
				global::Infragistics.Controls.Editors.MaskedEditTabNavigation maskedEditTabNavigation = this.SectionTabNavigation;
				if (global::Infragistics.Controls.Editors.MaskedEditTabNavigation.NextSection == maskedEditTabNavigation && this._editInfo != null && this._editInfo.LastEditSection is global::Infragistics.Controls.Editors.FractionPartContinuous)
				{
					maskedEditTabNavigation = global::Infragistics.Controls.Editors.MaskedEditTabNavigation.NextControl;
				}
				return maskedEditTabNavigation;
			}
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x060004AC RID: 1196 RVA: 0x00019139 File Offset: 0x00017339
		// (set) Token: 0x060004AD RID: 1197 RVA: 0x00019141 File Offset: 0x00017341
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

		// Token: 0x060004AE RID: 1198 RVA: 0x00019153 File Offset: 0x00017353
		private static bool IsValidPromptChar(char promptCharacter)
		{
			return "\b\t\u0013".IndexOf(promptCharacter) < 0;
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x060004AF RID: 1199 RVA: 0x00019163 File Offset: 0x00017363
		// (set) Token: 0x060004B0 RID: 1200 RVA: 0x0001917A File Offset: 0x0001737A
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
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
				if (this.EditInfo != null && this.SelectionStart != value)
				{
					this.EditInfo.Select(value, this.SelectionLength, true);
				}
			}
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x060004B1 RID: 1201 RVA: 0x000191A0 File Offset: 0x000173A0
		// (set) Token: 0x060004B2 RID: 1202 RVA: 0x000191B7 File Offset: 0x000173B7
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
				if (this.EditInfo != null && this.SelectionLength != value)
				{
					this.EditInfo.Select(this.SelectionStart, value, true);
				}
			}
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x060004B3 RID: 1203 RVA: 0x000191DD File Offset: 0x000173DD
		// (set) Token: 0x060004B4 RID: 1204 RVA: 0x000191F4 File Offset: 0x000173F4
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

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x060004B5 RID: 1205 RVA: 0x0001920A File Offset: 0x0001740A
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

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x060004B6 RID: 1206 RVA: 0x00019221 File Offset: 0x00017421
		// (set) Token: 0x060004B7 RID: 1207 RVA: 0x0001922A File Offset: 0x0001742A
		public bool IsUndoEnabled
		{
			get
			{
				return this.GetFlag(global::Infragistics.Controls.Editors.XamMaskedInput.InternalFlags.IsUndoEnabled);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Editors.XamMaskedInput.IsUndoEnabledProperty, value);
			}
		}

		// Token: 0x060004B8 RID: 1208 RVA: 0x0001923D File Offset: 0x0001743D
		protected internal virtual string GetDefaultMask(global::System.Type dataType, global::System.IFormatProvider formatProvider)
		{
			return null;
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x060004B9 RID: 1209 RVA: 0x00019240 File Offset: 0x00017440
		// (set) Token: 0x060004BA RID: 1210 RVA: 0x00019252 File Offset: 0x00017452
		public global::Infragistics.Controls.Editors.MaskSelectAllBehavior SelectAllBehavior
		{
			get
			{
				return (global::Infragistics.Controls.Editors.MaskSelectAllBehavior)base.GetValue(global::Infragistics.Controls.Editors.XamMaskedInput.SelectAllBehaviorProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Editors.XamMaskedInput.SelectAllBehaviorProperty, value);
			}
		}

		// Token: 0x060004BB RID: 1211 RVA: 0x00019265 File Offset: 0x00017465
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeSelectAllBehavior()
		{
			return global::Infragistics.DependencyPropertyUtilities.ShouldSerialize(this, global::Infragistics.Controls.Editors.XamMaskedInput.SelectAllBehaviorProperty);
		}

		// Token: 0x060004BC RID: 1212 RVA: 0x00019272 File Offset: 0x00017472
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetSelectAllBehavior()
		{
			base.ClearValue(global::Infragistics.Controls.Editors.XamMaskedInput.SelectAllBehaviorProperty);
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x060004BD RID: 1213 RVA: 0x0001927F File Offset: 0x0001747F
		// (set) Token: 0x060004BE RID: 1214 RVA: 0x00019291 File Offset: 0x00017491
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Controls.Editors.AutoFillDate AutoFillDate
		{
			get
			{
				return (global::Infragistics.Controls.Editors.AutoFillDate)base.GetValue(global::Infragistics.Controls.Editors.XamMaskedInput.AutoFillDateProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Editors.XamMaskedInput.AutoFillDateProperty, value);
			}
		}

		// Token: 0x060004BF RID: 1215 RVA: 0x000192A4 File Offset: 0x000174A4
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeAutoFillDate()
		{
			return global::Infragistics.DependencyPropertyUtilities.ShouldSerialize(this, global::Infragistics.Controls.Editors.XamMaskedInput.AutoFillDateProperty);
		}

		// Token: 0x060004C0 RID: 1216 RVA: 0x000192B1 File Offset: 0x000174B1
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetAutoFillDate()
		{
			base.ClearValue(global::Infragistics.Controls.Editors.XamMaskedInput.AutoFillDateProperty);
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x060004C1 RID: 1217 RVA: 0x000192BE File Offset: 0x000174BE
		protected override global::System.Windows.Data.IValueConverter DefaultValueToDisplayTextConverter
		{
			get
			{
				return global::Infragistics.Controls.Editors.MaskedInputDefaultConverter.ValueToDisplayTextConverter;
			}
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x060004C2 RID: 1218 RVA: 0x000192C5 File Offset: 0x000174C5
		protected override global::System.Windows.Data.IValueConverter DefaultValueToTextConverter
		{
			get
			{
				return global::Infragistics.Controls.Editors.MaskedInputDefaultConverter.ValueToTextConverter;
			}
		}

		// Token: 0x060004C3 RID: 1219 RVA: 0x000192CC File Offset: 0x000174CC
		public bool ExecuteCommand(global::Infragistics.Controls.Editors.Primitives.MaskedInputCommandId command, object commandParameter, global::System.Windows.FrameworkElement sourceElement)
		{
			global::Infragistics.Controls.Editors.EditInfo editInfo = this.EditInfo;
			global::Infragistics.Controls.Editors.XamMaskedInput xamMaskedInput = sourceElement as global::Infragistics.Controls.Editors.XamMaskedInput;
			global::System.Windows.Input.ModifierKeys currentModifierKeys = global::Infragistics.Controls.PresentationUtilities.GetCurrentModifierKeys();
			bool shift = (currentModifierKeys & global::System.Windows.Input.ModifierKeys.Shift) != global::System.Windows.Input.ModifierKeys.None;
			bool control = (currentModifierKeys & global::System.Windows.Input.ModifierKeys.Control) != global::System.Windows.Input.ModifierKeys.None;
			if (!this.CanExecuteCommand(command, commandParameter))
			{
				return false;
			}
			bool result = false;
			if (xamMaskedInput != null && !xamMaskedInput.IsUndoEnabled && (command == global::Infragistics.Controls.Editors.Primitives.MaskedInputCommandId.Undo || command == global::Infragistics.Controls.Editors.Primitives.MaskedInputCommandId.Redo))
			{
				return false;
			}
			if (editInfo != null && editInfo.ExecuteCommandImpl(command, commandParameter, shift, control, sourceElement))
			{
				result = true;
			}
			return result;
		}

		// Token: 0x060004C4 RID: 1220 RVA: 0x00019340 File Offset: 0x00017540
		internal bool IsMouseOverTemplateChild(string templateChildName, global::System.Windows.Input.MouseEventArgs mouseArgs)
		{
			global::System.Windows.DependencyObject dependencyObject;
			return this.IsMouseOverTemplateChild(templateChildName, mouseArgs, out dependencyObject);
		}

		// Token: 0x060004C5 RID: 1221 RVA: 0x00019357 File Offset: 0x00017557
		internal bool IsMouseOverTemplateChild(string templateChildName, global::System.Windows.Input.MouseEventArgs mouseArgs, out global::System.Windows.DependencyObject templateChildElem)
		{
			templateChildElem = base.GetTemplateChild(templateChildName);
			return templateChildElem != null && global::Infragistics.Controls.Editors.Primitives.Utils.IsMouseOverElement(templateChildElem, mouseArgs);
		}

		// Token: 0x060004C6 RID: 1222 RVA: 0x00019374 File Offset: 0x00017574
		protected override void OnContextMenuOpening(global::System.Windows.Controls.ContextMenuEventArgs e)
		{
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
				base.ConsiderIsInEditMode("IsDisplayingContextMenu", base.IsEnabled);
				global::Infragistics.CommandSourceManager.NotifyCanExecuteChanged(typeof(global::Infragistics.Controls.Editors.Primitives.MaskedInputCommand));
				contextMenu.IsOpen = true;
				e.Handled = true;
				if (!contextMenu.IsOpen)
				{
					base.ConsiderIsInEditMode("IsDisplayingContextMenu", false);
				}
			}
		}

		// Token: 0x060004C7 RID: 1223 RVA: 0x000194D4 File Offset: 0x000176D4
		private void OnContextMenuClosed(object sender, global::System.Windows.RoutedEventArgs e)
		{
			global::System.Windows.Controls.ContextMenu contextMenu = sender as global::System.Windows.Controls.ContextMenu;
			base.ConsiderIsInEditMode("IsDisplayingContextMenu", false);
			if (contextMenu != null)
			{
				contextMenu.Closed -= this.OnContextMenuClosed;
			}
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x060004C8 RID: 1224 RVA: 0x00019509 File Offset: 0x00017709
		private global::Infragistics.Controls.Editors.Primitives.MaskedInputCommandsHelper Commands
		{
			get
			{
				if (this._commands == null)
				{
					this._commands = new global::Infragistics.Controls.Editors.Primitives.MaskedInputCommandsHelper();
				}
				return this._commands;
			}
		}

		// Token: 0x060004C9 RID: 1225 RVA: 0x00019524 File Offset: 0x00017724
		object global::Infragistics.ICommandTarget.GetParameter(global::Infragistics.Controls.CommandSource source)
		{
			if (!(source is global::Infragistics.Controls.Editors.Primitives.MaskedInputCommandSource))
			{
				return null;
			}
			return this;
		}

		// Token: 0x060004CA RID: 1226 RVA: 0x00019531 File Offset: 0x00017731
		bool global::Infragistics.ICommandTarget.SupportsCommand(global::System.Windows.Input.ICommand command)
		{
			return command is global::Infragistics.Controls.Editors.Primitives.MaskedInputCommand;
		}

		// Token: 0x060004CB RID: 1227 RVA: 0x0001953C File Offset: 0x0001773C
		internal bool CanExecuteCommand(global::Infragistics.Controls.Editors.Primitives.MaskedInputCommandId command, object commandParameter)
		{
			return this.Commands.DoesMinimumStateMatch(command, new global::System.Func<long, long>(this.EditInfo.GetCurrentStateLong)) ?? true;
		}

		// Token: 0x04000182 RID: 386
		internal const char DEFAULT_PROMPT_CHAR = '_';

		// Token: 0x04000183 RID: 387
		internal const char DEFAULT_PAD_CHAR = ' ';

		// Token: 0x04000184 RID: 388
		internal const string LOCALIZED_ESCAPE_SEQUENCE = "{LOC}";

		// Token: 0x04000185 RID: 389
		private global::Infragistics.Windows.Licensing.UltraLicense _license;

		// Token: 0x04000186 RID: 390
		private global::Infragistics.Controls.Editors.EditInfo _editInfo;

		// Token: 0x04000187 RID: 391
		private global::Infragistics.Controls.Editors.MaskInfo _maskInfo;

		// Token: 0x04000188 RID: 392
		private global::Infragistics.Controls.Editors.SectionsCollection _displayChars_Sections;

		// Token: 0x04000189 RID: 393
		private global::Infragistics.Controls.Editors.DisplayCharsCollection _displayChars;

		// Token: 0x0400018A RID: 394
		private static string g_lastShortDatePattern;

		// Token: 0x0400018B RID: 395
		private static char g_lastDateSeparator;

		// Token: 0x0400018C RID: 396
		private static string g_lastDefaultDateMask;

		// Token: 0x0400018D RID: 397
		private static global::System.IFormatProvider g_lastDateFormatProvider;

		// Token: 0x0400018E RID: 398
		private static bool g_lastUsePostfixSeparatorsFromLongDatePattern;

		// Token: 0x0400018F RID: 399
		private static string g_lastShortTimePattern;

		// Token: 0x04000190 RID: 400
		private static char g_lastTimeSeparator;

		// Token: 0x04000191 RID: 401
		private static string g_lastDefaultTimeMask;

		// Token: 0x04000192 RID: 402
		private static global::System.Collections.Generic.Dictionary<global::System.Type, string> g_defaultMaskTable = new global::System.Collections.Generic.Dictionary<global::System.Type, string>();

		// Token: 0x04000193 RID: 403
		private static bool g_defaultMaskTableInitialized = false;

		// Token: 0x04000194 RID: 404
		private bool _allowShiftingAcrossSections = true;

		// Token: 0x04000195 RID: 405
		internal global::Infragistics.Controls.Editors.Primitives.SpinInfo _cachedSpinInfo;

		// Token: 0x04000196 RID: 406
		private global::Infragistics.Controls.Editors.XamMaskedInput.InternalFlags _flags;

		// Token: 0x04000198 RID: 408
		[global::System.ThreadStatic]
		private static global::System.Globalization.CultureInfo s_defaultCultureInfo;

		// Token: 0x04000199 RID: 409
		public static readonly global::System.Windows.DependencyProperty TrimFractionalZerosProperty = global::Infragistics.DependencyPropertyUtilities.Register("TrimFractionalZeros", typeof(bool), typeof(global::Infragistics.Controls.Editors.XamMaskedInput), global::Infragistics.DependencyPropertyUtilities.CreateMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Editors.XamMaskedInput.OnTrimFractionalZerosChanged)));

		// Token: 0x0400019A RID: 410
		public static readonly global::System.Windows.DependencyProperty SpinButtonDisplayModeProperty = global::Infragistics.DependencyPropertyUtilities.Register("SpinButtonDisplayMode", typeof(global::Infragistics.Controls.Editors.SpinButtonDisplayMode), typeof(global::Infragistics.Controls.Editors.XamMaskedInput), global::Infragistics.Controls.Editors.SpinButtonDisplayMode.Never, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Editors.ValueInput.OnProcessPropertyChangedCallback));

		// Token: 0x0400019B RID: 411
		public static readonly global::System.Windows.DependencyProperty SpinButtonStyleProperty = global::Infragistics.DependencyPropertyUtilities.Register("SpinButtonStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Controls.Editors.XamMaskedInput), null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Editors.ValueInput.OnProcessPropertyChangedCallback));

		// Token: 0x0400019C RID: 412
		private static readonly global::System.Windows.DependencyPropertyKey SpinButtonVisibilityResolvedPropertyKey = global::Infragistics.DependencyPropertyUtilities.RegisterReadOnly("SpinButtonVisibilityResolved", typeof(global::System.Windows.Visibility), typeof(global::Infragistics.Controls.Editors.XamMaskedInput), global::System.Windows.Visibility.Collapsed, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Editors.XamMaskedInput.OnSpinButtonVisibilityResolvedChanged));

		// Token: 0x0400019D RID: 413
		public static readonly global::System.Windows.DependencyProperty SpinButtonVisibilityResolvedProperty = global::Infragistics.Controls.Editors.XamMaskedInput.SpinButtonVisibilityResolvedPropertyKey.DependencyProperty;

		// Token: 0x0400019E RID: 414
		public static readonly global::System.Windows.DependencyProperty SpinIncrementProperty = global::Infragistics.DependencyPropertyUtilities.Register("SpinIncrement", typeof(object), typeof(global::Infragistics.Controls.Editors.XamMaskedInput), null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Editors.XamMaskedInput.OnSpinIncrementChanged));

		// Token: 0x0400019F RID: 415
		public static readonly global::System.Windows.DependencyProperty SpinWrapProperty = global::Infragistics.DependencyPropertyUtilities.Register("SpinWrap", typeof(bool), typeof(global::Infragistics.Controls.Editors.XamMaskedInput), global::Infragistics.KnownBoxes.FalseBox, delegate(global::System.Windows.DependencyObject o, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Controls.Editors.XamMaskedInput)o).SetFlag(global::Infragistics.Controls.Editors.XamMaskedInput.InternalFlags.SpinWrap, (bool)e.NewValue);
			global::Infragistics.Controls.Editors.ValueInput.OnProcessPropertyChangedCallback(o, e);
		});

		// Token: 0x040001A0 RID: 416
		private static readonly global::System.Windows.DependencyPropertyKey SectionsPropertyKey = global::Infragistics.DependencyPropertyUtilities.RegisterReadOnly("Sections", typeof(global::Infragistics.Controls.Editors.SectionsCollection), typeof(global::Infragistics.Controls.Editors.XamMaskedInput), null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Editors.XamMaskedInput.OnSectionsChanged));

		// Token: 0x040001A1 RID: 417
		public static readonly global::System.Windows.DependencyProperty SectionsProperty = global::Infragistics.Controls.Editors.XamMaskedInput.SectionsPropertyKey.DependencyProperty;

		// Token: 0x040001A2 RID: 418
		public static readonly global::System.Windows.DependencyProperty InsertModeProperty = global::Infragistics.DependencyPropertyUtilities.Register("InsertMode", typeof(bool), typeof(global::Infragistics.Controls.Editors.XamMaskedInput), global::Infragistics.KnownBoxes.TrueBox, delegate(global::System.Windows.DependencyObject o, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Controls.Editors.XamMaskedInput)o).SetFlag(global::Infragistics.Controls.Editors.XamMaskedInput.InternalFlags.InsertMode, (bool)e.NewValue);
			global::Infragistics.Controls.Editors.ValueInput.OnProcessPropertyChangedCallback(o, e);
		});

		// Token: 0x040001A3 RID: 419
		public static readonly global::System.Windows.DependencyProperty MaskProperty = global::Infragistics.DependencyPropertyUtilities.Register("Mask", typeof(string), typeof(global::Infragistics.Controls.Editors.XamMaskedInput), null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Editors.XamMaskedInput.OnMaskChanged));

		// Token: 0x040001A4 RID: 420
		private string _cachedMask;

		// Token: 0x040001A5 RID: 421
		public static readonly global::System.Windows.DependencyProperty DataModeProperty = global::Infragistics.DependencyPropertyUtilities.Register("DataMode", typeof(global::Infragistics.Controls.Editors.InputMaskMode), typeof(global::Infragistics.Controls.Editors.XamMaskedInput), global::Infragistics.Controls.Editors.InputMaskMode.IncludeLiterals, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Editors.XamMaskedInput.OnDataModeChanged));

		// Token: 0x040001A6 RID: 422
		private global::Infragistics.Controls.Editors.InputMaskMode _cachedDataMode;

		// Token: 0x040001A7 RID: 423
		public static readonly global::System.Windows.DependencyProperty ClipModeProperty = global::Infragistics.DependencyPropertyUtilities.Register("ClipMode", typeof(global::Infragistics.Controls.Editors.InputMaskMode), typeof(global::Infragistics.Controls.Editors.XamMaskedInput), global::Infragistics.Controls.Editors.InputMaskMode.IncludeLiterals, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Editors.XamMaskedInput.OnClipModeChanged));

		// Token: 0x040001A8 RID: 424
		private global::Infragistics.Controls.Editors.InputMaskMode _cachedClipMode;

		// Token: 0x040001A9 RID: 425
		public static readonly global::System.Windows.DependencyProperty DisplayModeProperty = global::Infragistics.DependencyPropertyUtilities.Register("DisplayMode", typeof(global::Infragistics.Controls.Editors.InputMaskMode), typeof(global::Infragistics.Controls.Editors.XamMaskedInput), global::Infragistics.Controls.Editors.InputMaskMode.IncludeLiterals, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Editors.XamMaskedInput.OnDisplayModeChanged));

		// Token: 0x040001AA RID: 426
		private global::Infragistics.Controls.Editors.InputMaskMode _cachedDisplayMode;

		// Token: 0x040001AB RID: 427
		public static readonly global::System.Windows.DependencyProperty PadCharProperty = global::Infragistics.DependencyPropertyUtilities.Register("PadChar", typeof(char), typeof(global::Infragistics.Controls.Editors.XamMaskedInput), ' ', new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Editors.XamMaskedInput.OnPadCharChanged));

		// Token: 0x040001AC RID: 428
		private char _cachedPadChar;

		// Token: 0x040001AD RID: 429
		public static readonly global::System.Windows.DependencyProperty PromptCharProperty = global::Infragistics.DependencyPropertyUtilities.Register("PromptChar", typeof(char), typeof(global::Infragistics.Controls.Editors.XamMaskedInput), '_', new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Editors.XamMaskedInput.OnPromptCharChanged));

		// Token: 0x040001AE RID: 430
		private char _cachedPromptChar;

		// Token: 0x040001AF RID: 431
		public static readonly global::System.Windows.DependencyProperty SectionTabNavigationProperty = global::Infragistics.DependencyPropertyUtilities.Register("SectionTabNavigation", typeof(global::Infragistics.Controls.Editors.MaskedEditTabNavigation), typeof(global::Infragistics.Controls.Editors.XamMaskedInput), global::Infragistics.Controls.Editors.MaskedEditTabNavigation.NextControl, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Editors.ValueInput.OnProcessPropertyChangedCallback));

		// Token: 0x040001B0 RID: 432
		public static readonly global::System.Windows.DependencyProperty IsUndoEnabledProperty = global::Infragistics.DependencyPropertyUtilities.Register("IsUndoEnabled", typeof(bool), typeof(global::Infragistics.Controls.Editors.XamMaskedInput), global::Infragistics.KnownBoxes.TrueBox, delegate(global::System.Windows.DependencyObject o, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Controls.Editors.XamMaskedInput)o).SetFlag(global::Infragistics.Controls.Editors.XamMaskedInput.InternalFlags.IsUndoEnabled, (bool)e.NewValue);
			global::Infragistics.Controls.Editors.ValueInput.OnProcessPropertyChangedCallback(o, e);
		});

		// Token: 0x040001B1 RID: 433
		public static readonly global::System.Windows.DependencyProperty SelectAllBehaviorProperty = global::Infragistics.DependencyPropertyUtilities.Register("SelectAllBehavior", typeof(global::Infragistics.Controls.Editors.MaskSelectAllBehavior), typeof(global::Infragistics.Controls.Editors.XamMaskedInput), global::Infragistics.Controls.Editors.MaskSelectAllBehavior.SelectAllCharacters, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Editors.ValueInput.OnProcessPropertyChangedCallback));

		// Token: 0x040001B2 RID: 434
		public static readonly global::System.Windows.DependencyProperty AutoFillDateProperty = global::Infragistics.DependencyPropertyUtilities.Register("AutoFillDate", typeof(global::Infragistics.Controls.Editors.AutoFillDate), typeof(global::Infragistics.Controls.Editors.XamMaskedInput), global::Infragistics.Controls.Editors.AutoFillDate.None, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Editors.ValueInput.OnProcessPropertyChangedCallback));

		// Token: 0x040001B3 RID: 435
		private global::Infragistics.Controls.Editors.Primitives.MaskedInputCommandsHelper _commands;

		// Token: 0x02000059 RID: 89
		private enum InternalFlags
		{
			// Token: 0x040001B8 RID: 440
			TrimFractionalZeros = 1,
			// Token: 0x040001B9 RID: 441
			SpinWrap,
			// Token: 0x040001BA RID: 442
			InsertMode = 4,
			// Token: 0x040001BB RID: 443
			IsUndoEnabled = 8
		}
	}
}
