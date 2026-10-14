using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using Infragistics.Windows.Editors.Events;
using Infragistics.Windows.Helpers;

namespace Infragistics.Windows.Editors
{
	// Token: 0x02000085 RID: 133
	internal class EditInfo
	{
		// Token: 0x06000797 RID: 1943 RVA: 0x0002037A File Offset: 0x0001E57A
		internal EditInfo(global::Infragistics.Windows.Editors.MaskInfo maskInfo)
		{
			this.Initialize(maskInfo);
		}

		// Token: 0x06000798 RID: 1944 RVA: 0x0002038C File Offset: 0x0001E58C
		private void Initialize(global::Infragistics.Windows.Editors.MaskInfo maskInfo)
		{
			this.Reset();
			if (maskInfo == null)
			{
				throw new global::System.ArgumentNullException("maskInfo");
			}
			this._maskInfo = maskInfo;
			global::Infragistics.Windows.Editors.FractionPartContinuous fractionPartContinuous = this.LastEditSection as global::Infragistics.Windows.Editors.FractionPartContinuous;
			int num = -1;
			if (this.InsertMode)
			{
				if (fractionPartContinuous != null && fractionPartContinuous.LastDisplayChar != null)
				{
					num = 1 + fractionPartContinuous.LastDisplayChar.OverallIndexInEdit;
				}
				else
				{
					global::Infragistics.Windows.Editors.NumberSection numberSection = this.FirstEditSection as global::Infragistics.Windows.Editors.NumberSection;
					if (numberSection != null)
					{
						if (numberSection.FirstFilledChar != null)
						{
							num = numberSection.FirstFilledChar.OverallIndexInEdit;
						}
						else if (numberSection.LastDisplayChar != null)
						{
							num = 1 + numberSection.LastDisplayChar.OverallIndexInEdit;
						}
					}
				}
			}
			if (num >= 0)
			{
				this._caretPosition = (this._pivotPosition = num);
			}
			this.ManageUndoHistory_TextChanged(false, null);
		}

		// Token: 0x06000799 RID: 1945 RVA: 0x0002043C File Offset: 0x0001E63C
		private void Reset()
		{
			this._caretPosition = 0;
			this._pivotPosition = 0;
			this._lastIllegalChar = '\0';
			this._lastIllegalDisplayChar = null;
		}

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x0600079A RID: 1946 RVA: 0x0002045A File Offset: 0x0001E65A
		private global::Infragistics.Windows.Editors.EditInfo.TextBoxEventProxy EventProxy
		{
			get
			{
				if (this._staticEventProxy == null)
				{
					this._staticEventProxy = new global::Infragistics.Windows.Editors.EditInfo.TextBoxEventProxy(this);
				}
				return this._staticEventProxy;
			}
		}

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x0600079B RID: 1947 RVA: 0x00020476 File Offset: 0x0001E676
		internal global::Infragistics.Windows.Editors.MaskInfo MaskInfo
		{
			get
			{
				return this._maskInfo;
			}
		}

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x0600079C RID: 1948 RVA: 0x0002047E File Offset: 0x0001E67E
		internal global::Infragistics.Windows.Editors.XamMaskedEditor MaskedEditor
		{
			get
			{
				return this._maskInfo.MaskEditor;
			}
		}

		// Token: 0x0600079D RID: 1949 RVA: 0x0002048B File Offset: 0x0001E68B
		internal void OnInvalidOperation(global::Infragistics.Windows.Editors.Events.InvalidOperationEventArgs e)
		{
			this.MaskedEditor.OnInvalidOperation(e);
		}

		// Token: 0x0600079E RID: 1950 RVA: 0x00020499 File Offset: 0x0001E699
		internal void OnInvalidChar(global::Infragistics.Windows.Editors.Events.InvalidCharEventArgs e)
		{
			this.MaskedEditor.OnInvalidChar(e);
		}

		// Token: 0x0600079F RID: 1951 RVA: 0x000204A7 File Offset: 0x0001E6A7
		internal void OnTextChanged(bool viaUserAction)
		{
			this.OnTextChanged(viaUserAction, null);
		}

		// Token: 0x060007A0 RID: 1952 RVA: 0x000204B4 File Offset: 0x0001E6B4
		internal void OnTextChanged(bool viaUserAction, global::System.Windows.Input.RoutedCommand command)
		{
			global::Infragistics.Windows.Editors.XamMaskedEditor maskedEditor = this.MaskedEditor;
			maskedEditor.BeginSyncValueProperties();
			bool inOnTextChanged = this._inOnTextChanged;
			this._inOnTextChanged = true;
			try
			{
				string text = global::Infragistics.Windows.Editors.XamMaskedEditor.GetText(this.Sections, this.MaskInfo.DataMode, this.MaskInfo, string.Empty);
				maskedEditor.Text = text;
				this.SyncIMETextBox();
				this.ManageUndoHistory_TextChanged(viaUserAction, command);
			}
			finally
			{
				this._inOnTextChanged = inOnTextChanged;
				maskedEditor.EndSyncValueProperties();
			}
		}

		// Token: 0x060007A1 RID: 1953 RVA: 0x00020534 File Offset: 0x0001E734
		internal global::Infragistics.Windows.Editors.SectionBase GetCurrentSection(bool returnPrevRightToLeftSection)
		{
			global::Infragistics.Windows.Editors.DisplayCharBase currentDisplayChar = this.GetCurrentDisplayChar();
			if (returnPrevRightToLeftSection && (currentDisplayChar == null || (!currentDisplayChar.IsEditable && currentDisplayChar.Section.FirstDisplayChar == currentDisplayChar)))
			{
				global::Infragistics.Windows.Editors.SectionBase sectionBase = (currentDisplayChar == null) ? this.LastEditSection : ((currentDisplayChar.PrevDisplayChar != null) ? currentDisplayChar.PrevDisplayChar.Section : null);
				if (sectionBase != null && this.IsRightToLeft(sectionBase))
				{
					return sectionBase;
				}
			}
			if (currentDisplayChar == null)
			{
				return null;
			}
			return currentDisplayChar.Section;
		}

		// Token: 0x060007A2 RID: 1954 RVA: 0x0002059F File Offset: 0x0001E79F
		internal string GetText(global::Infragistics.Windows.Editors.MaskMode maskMode)
		{
			return global::Infragistics.Windows.Editors.XamMaskedEditor.GetText(this.Sections, maskMode, this.MaskInfo);
		}

		// Token: 0x060007A3 RID: 1955 RVA: 0x000205B4 File Offset: 0x0001E7B4
		internal int SetText(string text)
		{
			string text2 = this.GetText(global::Infragistics.Windows.Editors.MaskMode.IncludeBoth);
			int result;
			try
			{
				int num = global::Infragistics.Windows.Editors.XamMaskedEditor.SetText(this.Sections, text, this.MaskInfo);
				this.DirtyMaskElement();
				result = num;
			}
			finally
			{
				if (text2 == null)
				{
					text2 = "";
				}
				string text3 = this.GetText(global::Infragistics.Windows.Editors.MaskMode.IncludeBoth);
				if (string.Compare(text2, text3, false, global::System.Globalization.CultureInfo.CurrentCulture) != 0)
				{
					this.OnTextChanged(false);
				}
			}
			return result;
		}

		// Token: 0x060007A4 RID: 1956 RVA: 0x00020624 File Offset: 0x0001E824
		internal void InvalidateMaskElement()
		{
			this.DirtyMaskElement();
		}

		// Token: 0x060007A5 RID: 1957 RVA: 0x0002062C File Offset: 0x0001E82C
		internal void DirtyMaskElement()
		{
			this.MaskedEditor.InvalidateArrange();
		}

		// Token: 0x060007A6 RID: 1958 RVA: 0x00020639 File Offset: 0x0001E839
		internal void HookUnhookInputMethodHelper(bool hook)
		{
			if (hook)
			{
				this.EventProxy.WireInputMethod_StateChanged();
			}
			else
			{
				this.EventProxy.UnwireInputMethod_StateChanged();
			}
			this.InitializeIsTextBoxEntryEnabled();
		}

		// Token: 0x060007A7 RID: 1959 RVA: 0x0002065C File Offset: 0x0001E85C
		private void ImeTextBox_PreviewCanExecuteCommand(object sender, global::System.Windows.Input.CanExecuteRoutedEventArgs e)
		{
			global::System.Windows.Input.RoutedCommand routedCommand = e.Command as global::System.Windows.Input.RoutedCommand;
			if (routedCommand != null && typeof(global::System.Windows.Documents.EditingCommands) == routedCommand.OwnerType)
			{
				bool canExecute = false;
				bool handled = true;
				bool continueRouting = true;
				if (global::System.Windows.Documents.EditingCommands.MoveLeftByCharacter == routedCommand || global::System.Windows.Documents.EditingCommands.MoveRightByCharacter == routedCommand || global::System.Windows.Documents.EditingCommands.MoveToLineStart == routedCommand || global::System.Windows.Documents.EditingCommands.MoveToLineEnd == routedCommand)
				{
					continueRouting = false;
				}
				e.CanExecute = canExecute;
				e.Handled = handled;
				e.ContinueRouting = continueRouting;
			}
		}

		// Token: 0x060007A8 RID: 1960 RVA: 0x000206CC File Offset: 0x0001E8CC
		private void ImeTextBox_PreviewKeyDown(object sender, global::System.Windows.Input.KeyEventArgs e)
		{
			global::System.Windows.Input.Key key = e.Key;
			if (key != global::System.Windows.Input.Key.Escape)
			{
				switch (key)
				{
				case global::System.Windows.Input.Key.End:
				case global::System.Windows.Input.Key.Home:
				case global::System.Windows.Input.Key.Left:
				case global::System.Windows.Input.Key.Up:
				case global::System.Windows.Input.Key.Right:
				case global::System.Windows.Input.Key.Down:
					break;
				default:
					return;
				}
			}
			this.MaskedEditor.ProcessKeyDown(e);
			e.Handled = true;
		}

		// Token: 0x060007A9 RID: 1961 RVA: 0x0002071C File Offset: 0x0001E91C
		private void ImeTextBox_PreviewTextInput(object sender, global::System.Windows.Input.TextCompositionEventArgs e)
		{
			if (!this.ReadOnly)
			{
				global::System.Windows.Documents.FrameworkTextComposition frameworkTextComposition = e.TextComposition as global::System.Windows.Documents.FrameworkTextComposition;
				if (frameworkTextComposition != null)
				{
					int num = -1;
					try
					{
						global::System.Reflection.PropertyInfo property = typeof(global::System.Windows.Documents.FrameworkTextComposition).GetProperty("ResultOffset");
						if (null != property)
						{
							num = (int)property.GetValue(frameworkTextComposition, null);
						}
					}
					catch
					{
					}
					if (num < 0)
					{
						num = this._imeTextBox.SelectionStart - frameworkTextComposition.Text.Length;
					}
					if (this._imeTextBox_PendingDelete != null)
					{
						global::Infragistics.Windows.Editors.Utils.Range imeTextBox_PendingDelete = this._imeTextBox_PendingDelete;
						this._imeTextBox_PendingDelete = null;
						this.Select(imeTextBox_PendingDelete.Start, imeTextBox_PendingDelete.Length);
						if (this.IsAnyTextSelected)
						{
							this.Delete();
						}
					}
					this.SetCaretPivot(global::System.Math.Max(0, num));
				}
				this.ProcessTextInput(e, true);
			}
		}

		// Token: 0x060007AA RID: 1962 RVA: 0x000207F4 File Offset: 0x0001E9F4
		private void ImeTextBox_SelectionChanged(object sender, global::System.Windows.RoutedEventArgs e)
		{
			this.SyncWithIMETextBox();
		}

		// Token: 0x060007AB RID: 1963 RVA: 0x000207FC File Offset: 0x0001E9FC
		private void ImeTextBox_TextInputStart(object sender, global::System.Windows.Input.TextCompositionEventArgs e)
		{
			this._imeTextBox_PendingDelete = null;
			if (this.IsAnyTextSelected)
			{
				this._imeTextBox_PendingDelete = new global::Infragistics.Windows.Editors.Utils.Range(this.SelectionStart, this.SelectionLength);
			}
		}

		// Token: 0x060007AC RID: 1964 RVA: 0x00020824 File Offset: 0x0001EA24
		internal void InitializeIMETextBox(global::System.Windows.DependencyObject focusSite)
		{
			global::Infragistics.Windows.Editors.XamMaskedEditor maskedEditor = this.MaskedEditor;
			if (this._imeTextBox != null)
			{
				this.EventProxy.UnwireTextBoxEvents();
				this.EventProxy.UnwireInputMethod_StateChanged();
				this._imeTextBox = null;
			}
			global::System.Windows.Controls.TextBox imeTextBox = (focusSite != null) ? (global::Infragistics.Windows.Utilities.GetDescendantFromName(focusSite, "PART_InputTextBox") as global::System.Windows.Controls.TextBox) : null;
			this._imeTextBox = imeTextBox;
			if (this._imeTextBox != null)
			{
				global::System.Windows.Controls.ContextMenu contextMenu = null;
				if (maskedEditor.ReadLocalValue(global::System.Windows.FrameworkElement.ContextMenuProperty) != null)
				{
					contextMenu = maskedEditor.ContextMenu;
					if (contextMenu == null)
					{
						contextMenu = maskedEditor.CreateContextMenu();
					}
				}
				this._imeTextBox.ContextMenu = contextMenu;
				this.SynchronizeTextBoxToInputMethodState();
				this.EventProxy.WireTextBoxEvents(this._imeTextBox);
				this.SyncIMETextBox();
				this.InitializeInputScope();
			}
		}

		// Token: 0x060007AD RID: 1965 RVA: 0x000208D4 File Offset: 0x0001EAD4
		private void InitializeInputScope()
		{
			if (!global::Infragistics.Windows.Editors.XamMaskedEditor._IsTouchEnabled || this._imeTextBox == null)
			{
				return;
			}
			if (global::System.Windows.DependencyPropertyHelper.GetValueSource(this._imeTextBox, global::System.Windows.FrameworkElement.InputScopeProperty).BaseValueSource > global::System.Windows.BaseValueSource.Default)
			{
				return;
			}
			this._imeTextBox.ClearValue(global::System.Windows.FrameworkElement.InputScopeProperty);
			if (this.Sections != null && this._imeTextBox.InputScope == null)
			{
				bool flag = false;
				bool flag2 = false;
				bool flag3 = false;
				bool flag4 = false;
				foreach (global::Infragistics.Windows.Editors.SectionBase sectionBase in this.Sections)
				{
					if (!(sectionBase is global::Infragistics.Windows.Editors.LiteralSection))
					{
						if (sectionBase is global::Infragistics.Windows.Editors.AMPMSection)
						{
							flag = true;
						}
						else if (sectionBase is global::Infragistics.Windows.Editors.NumberSection)
						{
							if (sectionBase.IsTimeSection || sectionBase.IsDateSection)
							{
								flag2 = true;
							}
							else
							{
								flag3 = true;
							}
						}
						else if (sectionBase is global::Infragistics.Windows.Editors.FractionPart)
						{
							flag3 = true;
						}
						else
						{
							flag4 = (!(sectionBase is global::Infragistics.Windows.Editors.DisplayCharsEditSection) || true);
						}
					}
				}
				if (!flag4)
				{
					global::System.Windows.Input.InputScopeNameValue? inputScopeNameValue = null;
					if (flag3)
					{
						inputScopeNameValue = new global::System.Windows.Input.InputScopeNameValue?(global::System.Windows.Input.InputScopeNameValue.CurrencyAmountAndSymbol);
					}
					else if (flag2)
					{
						if (!flag)
						{
							inputScopeNameValue = new global::System.Windows.Input.InputScopeNameValue?(global::System.Windows.Input.InputScopeNameValue.Number);
						}
						else
						{
							inputScopeNameValue = new global::System.Windows.Input.InputScopeNameValue?(global::System.Windows.Input.InputScopeNameValue.Time);
						}
					}
					if (inputScopeNameValue != null)
					{
						global::System.Windows.Input.InputScope inputScope = new global::System.Windows.Input.InputScope();
						inputScope.Names.Add(new global::System.Windows.Input.InputScopeName
						{
							NameValue = inputScopeNameValue.Value
						});
						this._imeTextBox.SetCurrentValue(global::System.Windows.FrameworkElement.InputScopeProperty, inputScope);
					}
				}
			}
		}

		// Token: 0x060007AE RID: 1966 RVA: 0x00020A50 File Offset: 0x0001EC50
		internal void InitializeIsTextBoxEntryEnabled()
		{
			global::System.Windows.Input.InputMethod inputMethod = global::System.Windows.Input.InputMethod.Current;
			bool flag = (inputMethod != null && global::System.Windows.Input.InputMethodState.On == inputMethod.ImeState) || global::Infragistics.Windows.Editors.XamMaskedEditor._IsTouchEnabled;
			flag = (flag && !this.ReadOnly);
			this.MaskedEditor.InternalSetIsTextBoxEntryEnabled(flag);
		}

		// Token: 0x060007AF RID: 1967 RVA: 0x00020A9B File Offset: 0x0001EC9B
		private void InputMethod_StateChanged(object sender, global::System.Windows.Input.InputMethodStateChangedEventArgs e)
		{
			this.InitializeIsTextBoxEntryEnabled();
			this.SynchronizeTextBoxToInputMethodState();
		}

		// Token: 0x060007B0 RID: 1968 RVA: 0x00020AAC File Offset: 0x0001ECAC
		private void SynchronizeTextBoxToInputMethodState()
		{
			global::Infragistics.Windows.Editors.XamMaskedEditor maskedEditor = this.MaskedEditor;
			if (this._imeTextBox != null)
			{
				global::System.Windows.Input.InputMethod.SetIsInputMethodEnabled(this._imeTextBox, maskedEditor.IsInputMethodEnabled);
			}
		}

		// Token: 0x060007B1 RID: 1969 RVA: 0x00020ADC File Offset: 0x0001ECDC
		private int MapCaretPosFromImeTextBox(int pos)
		{
			int totalNumberOfDisplayChars = this.GetTotalNumberOfDisplayChars();
			int num = global::System.Math.Min(pos, totalNumberOfDisplayChars);
			int num2 = 0;
			do
			{
				int num3 = this.MapCaretPosToImeTextBox(num);
				if (num3 == pos)
				{
					break;
				}
				if (num2 == 0)
				{
					num2 = ((num3 < pos) ? 1 : -1);
				}
				num += num2;
			}
			while (num >= 0 && num <= totalNumberOfDisplayChars);
			return global::System.Math.Max(0, global::System.Math.Min(num, totalNumberOfDisplayChars));
		}

		// Token: 0x060007B2 RID: 1970 RVA: 0x00020B30 File Offset: 0x0001ED30
		private int MapCaretPosToImeTextBox(int pos)
		{
			int num = 0;
			foreach (object obj in this.Sections.AllDisplayCharacters)
			{
				global::Infragistics.Windows.Editors.DisplayCharBase displayCharBase = (global::Infragistics.Windows.Editors.DisplayCharBase)obj;
				if (displayCharBase.OverallIndexInEdit >= pos)
				{
					break;
				}
				num += this.GetDrawStringHelper(displayCharBase, null) - 1;
			}
			return pos + num;
		}

		// Token: 0x060007B3 RID: 1971 RVA: 0x00020BA4 File Offset: 0x0001EDA4
		private int GetDrawStringHelper(global::Infragistics.Windows.Editors.DisplayCharBase dc, global::System.Text.StringBuilder sb)
		{
			int num = 0;
			char @char = dc.GetChar(global::Infragistics.Windows.Editors.MaskMode.IncludeBoth, this._maskInfo.PromptChar, this._maskInfo.PadChar);
			if (@char == '\0' && dc is global::Infragistics.Windows.Editors.DecimalSeperatorChar)
			{
				@char = dc.Char;
			}
			if (@char != '\0')
			{
				num++;
				if (sb != null)
				{
					sb.Append(@char);
				}
				global::Infragistics.Windows.Editors.DigitChar digitChar = dc as global::Infragistics.Windows.Editors.DigitChar;
				if (digitChar != null && digitChar.ShouldIncludeComma(global::Infragistics.Windows.Editors.MaskMode.IncludeBoth))
				{
					num++;
					if (sb != null)
					{
						sb.Append(this._maskInfo.CommaChar);
					}
				}
			}
			return num;
		}

		// Token: 0x060007B4 RID: 1972 RVA: 0x00020C24 File Offset: 0x0001EE24
		private string GetDrawString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(4 + this.GetTotalNumberOfDisplayChars());
			foreach (object obj in this.Sections.AllDisplayCharacters)
			{
				global::Infragistics.Windows.Editors.DisplayCharBase dc = (global::Infragistics.Windows.Editors.DisplayCharBase)obj;
				this.GetDrawStringHelper(dc, stringBuilder);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x060007B5 RID: 1973 RVA: 0x00020C98 File Offset: 0x0001EE98
		internal void SyncIMETextBox()
		{
			if (this._inSyncIMETextBox || this._inSyncWithIMETextBox)
			{
				return;
			}
			this._inSyncIMETextBox = true;
			try
			{
				if (this._imeTextBox != null)
				{
					string drawString = this.GetDrawString();
					this._imeTextBox.Text = drawString;
					int selectionStart = this.SelectionStart;
					int num = this.MapCaretPosToImeTextBox(selectionStart);
					int num2 = (this.SelectionLength == 0) ? num : this.MapCaretPosToImeTextBox(selectionStart + this.SelectionLength);
					this._imeTextBox.SelectionStart = num;
					this._imeTextBox.SelectionLength = num2 - num;
				}
			}
			finally
			{
				this._inSyncIMETextBox = false;
			}
		}

		// Token: 0x060007B6 RID: 1974 RVA: 0x00020D38 File Offset: 0x0001EF38
		private void SyncWithIMETextBox()
		{
			if (this._inSyncIMETextBox || this._inSyncWithIMETextBox)
			{
				return;
			}
			this._inSyncWithIMETextBox = true;
			try
			{
				if (this._imeTextBox != null)
				{
					int selectionStart = this._imeTextBox.SelectionStart;
					int num = this.MapCaretPosFromImeTextBox(selectionStart);
					int num2 = (this._imeTextBox.SelectionLength == 0) ? num : this.MapCaretPosFromImeTextBox(selectionStart + this._imeTextBox.SelectionLength);
					this.SelectionStart = num;
					this.SelectionLength = num2 - num;
				}
			}
			finally
			{
				this._inSyncWithIMETextBox = false;
			}
		}

		// Token: 0x060007B7 RID: 1975 RVA: 0x00020DC8 File Offset: 0x0001EFC8
		internal void SetValue(object val)
		{
			string text = this.GetText(global::Infragistics.Windows.Editors.MaskMode.IncludeBoth);
			try
			{
				global::Infragistics.Windows.Editors.XamMaskedEditor.SetDataValue(this.Sections, this.MaskInfo.DataType, val, this.MaskInfo);
			}
			finally
			{
				this.DirtyMaskElement();
				string text2 = this.GetText(global::Infragistics.Windows.Editors.MaskMode.IncludeBoth);
				if (string.Compare(text2, text, false, global::System.Globalization.CultureInfo.CurrentCulture) != 0)
				{
					this.OnTextChanged(false);
				}
			}
		}

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x060007B8 RID: 1976 RVA: 0x00020E34 File Offset: 0x0001F034
		// (set) Token: 0x060007B9 RID: 1977 RVA: 0x00020E41 File Offset: 0x0001F041
		internal object Value
		{
			get
			{
				return global::Infragistics.Windows.Editors.XamMaskedEditor.GetDataValue(this.MaskInfo);
			}
			set
			{
				this.SetValue(value);
			}
		}

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x060007BA RID: 1978 RVA: 0x00020E4A File Offset: 0x0001F04A
		internal global::Infragistics.Windows.Editors.SectionsCollection Sections
		{
			get
			{
				return this.MaskInfo.Sections;
			}
		}

		// Token: 0x060007BB RID: 1979 RVA: 0x00020E58 File Offset: 0x0001F058
		internal global::Infragistics.Windows.Editors.MaskedEditorStates GetCurrentState(global::Infragistics.Windows.Editors.MaskedEditorStates statesToQuery)
		{
			if (!this.IsInitialized)
			{
				return global::Infragistics.Windows.Editors.MaskedEditorStates.Uninitialized;
			}
			global::Infragistics.Windows.Editors.XamMaskedEditor maskedEditor = this.MaskedEditor;
			global::Infragistics.Windows.Editors.MaskedEditorStates maskedEditorStates = (global::Infragistics.Windows.Editors.MaskedEditorStates)0L;
			if ((global::Infragistics.Windows.Editors.MaskedEditorStates)0L != (global::Infragistics.Windows.Editors.MaskedEditorStates.Character & statesToQuery))
			{
				if (this.GetCurrentDisplayChar() != null)
				{
					maskedEditorStates |= global::Infragistics.Windows.Editors.MaskedEditorStates.Character;
				}
				else
				{
					maskedEditorStates |= global::Infragistics.Windows.Editors.MaskedEditorStates.AfterLastCharacter;
				}
			}
			if ((global::Infragistics.Windows.Editors.MaskedEditorStates)0L != (global::Infragistics.Windows.Editors.MaskedEditorStates.Selected & statesToQuery) && this.SelectionLength > 0)
			{
				maskedEditorStates |= global::Infragistics.Windows.Editors.MaskedEditorStates.Selected;
			}
			if ((global::Infragistics.Windows.Editors.MaskedEditorStates)0L != (global::Infragistics.Windows.Editors.MaskedEditorStates.FirstSection & statesToQuery) && this.FirstSection != null && this.CurrentSection == this.FirstSection)
			{
				maskedEditorStates |= global::Infragistics.Windows.Editors.MaskedEditorStates.FirstSection;
			}
			if ((global::Infragistics.Windows.Editors.MaskedEditorStates)0L != (global::Infragistics.Windows.Editors.MaskedEditorStates.LastSection & statesToQuery) && this.LastSection != null && this.CurrentSection == this.LastSection)
			{
				maskedEditorStates |= global::Infragistics.Windows.Editors.MaskedEditorStates.LastSection;
			}
			if ((global::Infragistics.Windows.Editors.MaskedEditorStates)0L != (global::Infragistics.Windows.Editors.MaskedEditorStates.FirstEditSection & statesToQuery))
			{
				if (this.FirstEditSection != null && this.CurrentSection == this.FirstEditSection)
				{
					maskedEditorStates |= global::Infragistics.Windows.Editors.MaskedEditorStates.FirstEditSection;
				}
				else if (this.IsRightToLeft(this.FirstEditSection) && this.FirstEditSection.LastDisplayChar.NextDisplayChar == this.GetCurrentDisplayChar())
				{
					maskedEditorStates |= global::Infragistics.Windows.Editors.MaskedEditorStates.FirstEditSection;
				}
			}
			if ((global::Infragistics.Windows.Editors.MaskedEditorStates)0L != (global::Infragistics.Windows.Editors.MaskedEditorStates.LastEditSection & statesToQuery) && this.LastEditSection != null && this.CurrentSection == this.LastEditSection)
			{
				maskedEditorStates |= global::Infragistics.Windows.Editors.MaskedEditorStates.LastEditSection;
			}
			if ((global::Infragistics.Windows.Editors.MaskedEditorStates)0L != (global::Infragistics.Windows.Editors.MaskedEditorStates.FirstCharacter & statesToQuery) && this.FirstSection != null && this.GetCurrentDisplayChar() == this.FirstSection.FirstDisplayChar)
			{
				maskedEditorStates |= global::Infragistics.Windows.Editors.MaskedEditorStates.FirstCharacter;
			}
			if ((global::Infragistics.Windows.Editors.MaskedEditorStates)0L != (global::Infragistics.Windows.Editors.MaskedEditorStates.LastCharacter & statesToQuery) && this.LastSection != null && this.GetCurrentDisplayChar() == this.LastSection.LastDisplayChar)
			{
				maskedEditorStates |= global::Infragistics.Windows.Editors.MaskedEditorStates.LastCharacter;
			}
			if ((global::Infragistics.Windows.Editors.MaskedEditorStates)0L != (global::Infragistics.Windows.Editors.MaskedEditorStates.FirstCharacterInSection & statesToQuery) && this.CurrentSection != null && this.CurrentSection.FirstDisplayChar == this.GetCurrentDisplayChar())
			{
				maskedEditorStates |= global::Infragistics.Windows.Editors.MaskedEditorStates.FirstCharacterInSection;
			}
			if ((global::Infragistics.Windows.Editors.MaskedEditorStates)0L != (global::Infragistics.Windows.Editors.MaskedEditorStates.LastCharacterInSection & statesToQuery) && this.CurrentSection != null && this.CurrentSection.LastDisplayChar == this.GetCurrentDisplayChar())
			{
				maskedEditorStates |= global::Infragistics.Windows.Editors.MaskedEditorStates.LastCharacterInSection;
			}
			if ((global::Infragistics.Windows.Editors.MaskedEditorStates)0L != (global::Infragistics.Windows.Editors.MaskedEditorStates.FirstSection & statesToQuery) && (global::Infragistics.Windows.Editors.MaskedEditorStates)0L == (maskedEditorStates & global::Infragistics.Windows.Editors.MaskedEditorStates.FirstSection))
			{
				global::Infragistics.Windows.Editors.DisplayCharBase currentDisplayChar = this.GetCurrentDisplayChar();
				if (currentDisplayChar != null && currentDisplayChar.PrevDisplayChar != null)
				{
					global::Infragistics.Windows.Editors.SectionBase section = currentDisplayChar.PrevDisplayChar.Section;
					if (section != null && section.PreviousSection == null && this.IsRightToLeft(section))
					{
						maskedEditorStates |= global::Infragistics.Windows.Editors.MaskedEditorStates.FirstSection;
					}
				}
			}
			if ((global::Infragistics.Windows.Editors.MaskedEditorStates)0L != (global::Infragistics.Windows.Editors.MaskedEditorStates.NextSectionFraction & statesToQuery) && this.CurrentSection != null && this.CurrentSection.NextEditSection is global::Infragistics.Windows.Editors.FractionPart)
			{
				maskedEditorStates |= global::Infragistics.Windows.Editors.MaskedEditorStates.NextSectionFraction;
			}
			if ((global::Infragistics.Windows.Editors.MaskedEditorStates)0L != (global::Infragistics.Windows.Editors.MaskedEditorStates.CanSpinUp & statesToQuery) && this.CanSpin(true))
			{
				maskedEditorStates |= global::Infragistics.Windows.Editors.MaskedEditorStates.CanSpinUp;
			}
			if ((global::Infragistics.Windows.Editors.MaskedEditorStates)0L != (global::Infragistics.Windows.Editors.MaskedEditorStates.CanSpinDown & statesToQuery) && this.CanSpin(false))
			{
				maskedEditorStates |= global::Infragistics.Windows.Editors.MaskedEditorStates.CanSpinDown;
			}
			if ((global::Infragistics.Windows.Editors.MaskedEditorStates)0L != (global::Infragistics.Windows.Editors.MaskedEditorStates.CanUndo & statesToQuery) && this.HasUndoHistory)
			{
				maskedEditorStates |= global::Infragistics.Windows.Editors.MaskedEditorStates.CanUndo;
			}
			if ((global::Infragistics.Windows.Editors.MaskedEditorStates)0L != (global::Infragistics.Windows.Editors.MaskedEditorStates.CanRedo & statesToQuery) && this.HasRedoHistory)
			{
				maskedEditorStates |= global::Infragistics.Windows.Editors.MaskedEditorStates.CanRedo;
			}
			if (maskedEditor != null)
			{
				if ((global::Infragistics.Windows.Editors.MaskedEditorStates)0L != (global::Infragistics.Windows.Editors.MaskedEditorStates.TabBySections & statesToQuery) && global::Infragistics.Windows.Editors.MaskedEditTabNavigation.NextSection == maskedEditor.TabNavigationResolved)
				{
					maskedEditorStates |= global::Infragistics.Windows.Editors.MaskedEditorStates.TabBySections;
				}
				if ((global::Infragistics.Windows.Editors.MaskedEditorStates)0L != ((global::Infragistics.Windows.Editors.MaskedEditorStates.HasDropDown | global::Infragistics.Windows.Editors.MaskedEditorStates.IsDropDownOpen) & statesToQuery) && maskedEditor.HasDropDown)
				{
					maskedEditorStates |= global::Infragistics.Windows.Editors.MaskedEditorStates.HasDropDown;
					if (maskedEditor.HasOpenDropDown)
					{
						maskedEditorStates |= global::Infragistics.Windows.Editors.MaskedEditorStates.IsDropDownOpen;
					}
				}
			}
			return maskedEditorStates;
		}

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x060007BC RID: 1980 RVA: 0x0002116B File Offset: 0x0001F36B
		internal global::Infragistics.Windows.Editors.MaskedEditorStates CurrentState
		{
			get
			{
				return this.GetCurrentState((global::Infragistics.Windows.Editors.MaskedEditorStates)((ulong)-1));
			}
		}

		// Token: 0x060007BD RID: 1981 RVA: 0x00021178 File Offset: 0x0001F378
		internal bool ValidateChangeSection(global::Infragistics.Windows.Editors.SectionBase from, global::Infragistics.Windows.Editors.SectionBase to)
		{
			global::Infragistics.Windows.Editors.EditSectionBase editSectionBase = from as global::Infragistics.Windows.Editors.EditSectionBase;
			if (editSectionBase != null)
			{
				editSectionBase.ValidateSection();
			}
			return true;
		}

		// Token: 0x060007BE RID: 1982 RVA: 0x00021197 File Offset: 0x0001F397
		internal bool ValidateAllSections()
		{
			return this.ValidateAllSections(false);
		}

		// Token: 0x060007BF RID: 1983 RVA: 0x000211A0 File Offset: 0x0001F3A0
		internal bool ValidateAllSections(bool loosingFocus)
		{
			if (!this.IsInitialized)
			{
				return false;
			}
			string text = this.GetText(global::Infragistics.Windows.Editors.MaskMode.IncludeBoth);
			bool result;
			try
			{
				result = global::Infragistics.Windows.Editors.XamMaskedEditor.ValidateAllSections(this.Sections, loosingFocus);
			}
			finally
			{
				string text2 = this.GetText(global::Infragistics.Windows.Editors.MaskMode.IncludeBoth);
				if (text != text2)
				{
					this.OnTextChanged(false);
				}
			}
			return result;
		}

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x060007C0 RID: 1984 RVA: 0x000211F8 File Offset: 0x0001F3F8
		internal bool IsAnyTextSelected
		{
			get
			{
				return this.CaretPosition != this.PivotPosition;
			}
		}

		// Token: 0x060007C1 RID: 1985 RVA: 0x0002120C File Offset: 0x0001F40C
		internal bool IsDisplayCharSelected(global::Infragistics.Windows.Editors.DisplayCharBase dc)
		{
			int overallIndexInEdit = dc.OverallIndexInEdit;
			int selectionStart = this.SelectionStart;
			int num = this.SelectionStart + this.SelectionLength - 1;
			return selectionStart <= overallIndexInEdit && overallIndexInEdit <= num;
		}

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x060007C2 RID: 1986 RVA: 0x00021244 File Offset: 0x0001F444
		internal bool IsAfterLastCharacter
		{
			get
			{
				return this.CaretPosition >= this.GetTotalNumberOfDisplayChars();
			}
		}

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x060007C3 RID: 1987 RVA: 0x00021257 File Offset: 0x0001F457
		internal bool IsAtFirstChar
		{
			get
			{
				return 0 == this.CaretPosition;
			}
		}

		// Token: 0x060007C4 RID: 1988 RVA: 0x00021264 File Offset: 0x0001F464
		internal bool DeleteWithoutShiftingAcrrossSectionBoundaries()
		{
			if (!this.CanDelete())
			{
				return false;
			}
			if (!this.IsAnyTextSelected)
			{
				global::Infragistics.Windows.Editors.DisplayCharBase currentDisplayChar = this.GetCurrentDisplayChar();
				global::Infragistics.Windows.Editors.EditSectionBase editSectionBase = currentDisplayChar.Section as global::Infragistics.Windows.Editors.EditSectionBase;
				return editSectionBase != null && editSectionBase.DeleteCharAndShift(currentDisplayChar.Index);
			}
			int selectionStart = this.SelectionStart;
			int selectionLength = this.SelectionLength;
			int num = selectionStart + selectionLength - 1;
			bool flag = true;
			for (int i = 0; i < this.Sections.Count; i++)
			{
				global::Infragistics.Windows.Editors.EditSectionBase editSectionBase2 = this.Sections[i] as global::Infragistics.Windows.Editors.EditSectionBase;
				if (editSectionBase2 != null && editSectionBase2.LastDisplayChar.OverallIndexInEdit >= selectionStart && editSectionBase2.FirstDisplayChar.OverallIndexInEdit <= num)
				{
					if (editSectionBase2.FirstDisplayChar.OverallIndexInEdit >= selectionStart && editSectionBase2.LastDisplayChar.OverallIndexInEdit <= num)
					{
						editSectionBase2.EraseAllChars();
					}
					else if (!this.IsRightToLeft(editSectionBase2) && editSectionBase2.LastDisplayChar.OverallIndexInEdit <= num)
					{
						editSectionBase2.EraseChars(this.GetDisplayCharAtPosition(selectionStart).Index, editSectionBase2.DisplayChars.Count - 1);
					}
					else
					{
						int num2 = global::System.Math.Max(selectionStart, editSectionBase2.FirstDisplayChar.OverallIndexInEdit);
						int num3 = global::System.Math.Min(num, editSectionBase2.LastDisplayChar.OverallIndexInEdit);
						int num4 = num3 - num2 + 1;
						global::Infragistics.Windows.Editors.DisplayCharBase displayCharAtPosition = this.GetDisplayCharAtPosition(num2);
						if (displayCharAtPosition != null)
						{
							if (this.IsRightToLeft(editSectionBase2) || editSectionBase2 is global::Infragistics.Windows.Editors.FractionPart)
							{
								if (!editSectionBase2.DeleteCharsAndShift(displayCharAtPosition.Index + num4 - 1, num4))
								{
									flag = false;
								}
							}
							else if (!editSectionBase2.ShiftLeft(displayCharAtPosition.Index, num4))
							{
								flag = false;
							}
						}
					}
				}
			}
			if (flag)
			{
				if (this.IsRightToLeft(this.GetSectionContainingPosition(selectionStart)))
				{
					global::Infragistics.Windows.Editors.SectionBase sectionContainingPosition = this.GetSectionContainingPosition(selectionStart);
					this.CaretPosition = global::System.Math.Min(1 + num, 1 + sectionContainingPosition.LastDisplayChar.OverallIndexInEdit);
				}
				else
				{
					this.CaretPosition = selectionStart;
				}
				this.SetPivot();
			}
			return flag;
		}

		// Token: 0x060007C5 RID: 1989 RVA: 0x0002145C File Offset: 0x0001F65C
		private bool InsertCharAtShiftGlobalHelper(char c, int from, int to)
		{
			if (from == to)
			{
				global::Infragistics.Windows.Editors.DisplayCharBase displayCharAtPosition = this.GetDisplayCharAtPosition(from);
				if (displayCharAtPosition == null || !displayCharAtPosition.IsEmpty || !displayCharAtPosition.MatchChar(c))
				{
					return false;
				}
				displayCharAtPosition.Char = c;
			}
			bool flag = false;
			for (int i = to; i >= from; i--)
			{
				global::Infragistics.Windows.Editors.DisplayCharBase displayCharAtPosition2 = this.GetDisplayCharAtPosition(i);
				if (displayCharAtPosition2.IsEmpty)
				{
					flag = true;
					to = i;
					break;
				}
			}
			if (!flag || from == to)
			{
				global::Infragistics.Windows.Editors.DisplayCharBase displayCharAtPosition = this.GetDisplayCharAtPosition(from);
				if (displayCharAtPosition == null || !displayCharAtPosition.IsEmpty || !displayCharAtPosition.MatchChar(c))
				{
					return false;
				}
				displayCharAtPosition.Char = c;
			}
			int num = 1;
			for (int j = to - 1; j >= from; j--)
			{
				global::Infragistics.Windows.Editors.DisplayCharBase displayCharAtPosition3 = this.GetDisplayCharAtPosition(j);
				global::Infragistics.Windows.Editors.DisplayCharBase displayCharAtPosition4 = this.GetDisplayCharAtPosition(j + num);
				if (displayCharAtPosition3 != null && !displayCharAtPosition3.IsEditable)
				{
					num++;
				}
				else if (displayCharAtPosition4 != null && !displayCharAtPosition4.IsEditable)
				{
					num--;
					if (num > 0)
					{
						j++;
					}
					else
					{
						num = 1;
					}
				}
				else
				{
					if (!displayCharAtPosition3.IsEmpty && !displayCharAtPosition4.MatchChar(displayCharAtPosition3.Char))
					{
						return this.InsertCharAtShiftGlobalHelper(c, from, j - 1);
					}
					if (j == from && !displayCharAtPosition3.MatchChar(c))
					{
						return false;
					}
				}
			}
			num = 1;
			for (int k = to - 1; k >= from; k--)
			{
				global::Infragistics.Windows.Editors.DisplayCharBase displayCharAtPosition5 = this.GetDisplayCharAtPosition(k);
				global::Infragistics.Windows.Editors.DisplayCharBase displayCharAtPosition6 = this.GetDisplayCharAtPosition(k + num);
				if (displayCharAtPosition5 != null && !displayCharAtPosition5.IsEditable)
				{
					num++;
				}
				else if (displayCharAtPosition6 != null && !displayCharAtPosition6.IsEditable)
				{
					num--;
					if (num > 0)
					{
						k++;
					}
					else
					{
						num = 1;
					}
				}
				else
				{
					if (!displayCharAtPosition5.IsEmpty && !displayCharAtPosition6.MatchChar(displayCharAtPosition5.Char))
					{
						return false;
					}
					displayCharAtPosition6.Char = displayCharAtPosition5.Char;
					if (k == from)
					{
						displayCharAtPosition5.Char = c;
					}
				}
			}
			return true;
		}

		// Token: 0x060007C6 RID: 1990 RVA: 0x00021630 File Offset: 0x0001F830
		private bool InsertCharAtShiftGlobal(char c, int pos)
		{
			global::Infragistics.Windows.Editors.DisplayCharBase displayCharAtPosition = this.GetDisplayCharAtPosition(pos);
			if (displayCharAtPosition == null || this.IsRightToLeft(displayCharAtPosition.Section))
			{
				return false;
			}
			if (displayCharAtPosition == null || displayCharAtPosition.Section is global::Infragistics.Windows.Editors.FractionPart)
			{
				return false;
			}
			int totalNumberOfDisplayChars = this.GetTotalNumberOfDisplayChars();
			if (pos < 0 || pos >= totalNumberOfDisplayChars)
			{
				return false;
			}
			global::Infragistics.Windows.Editors.DisplayCharBase displayCharBase = null;
			for (int i = totalNumberOfDisplayChars - 1; i >= pos; i--)
			{
				displayCharAtPosition = this.GetDisplayCharAtPosition(i);
				if (this.IsRightToLeft(displayCharAtPosition.Section))
				{
					displayCharBase = null;
				}
				else if (displayCharBase == null)
				{
					displayCharBase = displayCharAtPosition;
				}
			}
			if (displayCharBase == null)
			{
				return false;
			}
			int overallIndexInEdit = displayCharBase.OverallIndexInEdit;
			return this.InsertCharAtShiftGlobalHelper(c, pos, overallIndexInEdit);
		}

		// Token: 0x060007C7 RID: 1991 RVA: 0x000216C5 File Offset: 0x0001F8C5
		internal bool CanDelete()
		{
			return this.CanDelete(false);
		}

		// Token: 0x060007C8 RID: 1992 RVA: 0x000216D0 File Offset: 0x0001F8D0
		internal bool CanDelete(bool emulateDeleteKey)
		{
			if (this.IsAnyTextSelected)
			{
				return true;
			}
			if (this.IsAfterLastCharacter)
			{
				return false;
			}
			global::Infragistics.Windows.Editors.DisplayCharBase currentDisplayChar = this.GetCurrentDisplayChar();
			return currentDisplayChar != null && (currentDisplayChar.Section is global::Infragistics.Windows.Editors.EditSectionBase || emulateDeleteKey);
		}

		// Token: 0x060007C9 RID: 1993 RVA: 0x00021714 File Offset: 0x0001F914
		private int ShiftGlobalLeft(int from, int positionsToShift)
		{
			int totalNumberOfDisplayChars = this.GetTotalNumberOfDisplayChars();
			if (from < 0 || from >= totalNumberOfDisplayChars)
			{
				return 0;
			}
			if (positionsToShift < 0)
			{
				return 0;
			}
			if (from + positionsToShift > totalNumberOfDisplayChars)
			{
				return 0;
			}
			int num = 0;
			int num2 = positionsToShift;
			int num3 = from;
			while (num3 < totalNumberOfDisplayChars && positionsToShift != 0)
			{
				global::Infragistics.Windows.Editors.DisplayCharBase displayCharAtPosition = this.GetDisplayCharAtPosition(num3);
				global::Infragistics.Windows.Editors.DisplayCharBase displayCharAtPosition2 = this.GetDisplayCharAtPosition(num3 + positionsToShift);
				global::Infragistics.Windows.Editors.EditSectionBase editSectionBase = displayCharAtPosition.Section as global::Infragistics.Windows.Editors.EditSectionBase;
				if (displayCharAtPosition != null && editSectionBase != null && global::Infragistics.Windows.Editors.EditOrientation.RightToLeft == editSectionBase.Orientation)
				{
					int num4 = 1 + editSectionBase.LastDisplayChar.OverallIndexInEdit;
					if (num2 <= num4 - num3 || from + num2 < num4)
					{
						break;
					}
					positionsToShift--;
				}
				else if (displayCharAtPosition != null && !displayCharAtPosition.IsEditable)
				{
					positionsToShift--;
				}
				else
				{
					if (displayCharAtPosition2 != null && !displayCharAtPosition2.IsEditable)
					{
						int num5 = 0;
						while (displayCharAtPosition2 != null && !displayCharAtPosition2.IsEditable)
						{
							num5++;
							displayCharAtPosition2 = this.GetDisplayCharAtPosition(num3 + positionsToShift + num5);
						}
						positionsToShift += num5;
					}
					char c = '\0';
					if (displayCharAtPosition2 != null)
					{
						c = displayCharAtPosition2.Char;
					}
					if (displayCharAtPosition == null || (c != '\0' && !displayCharAtPosition.MatchChar(c)))
					{
						break;
					}
					displayCharAtPosition.Char = c;
					if (displayCharAtPosition2 != null)
					{
						displayCharAtPosition2.EraseChar();
					}
					if (!displayCharAtPosition.IsEmpty)
					{
						num++;
					}
				}
				num3++;
			}
			return num;
		}

		// Token: 0x060007CA RID: 1994 RVA: 0x0002184D File Offset: 0x0001FA4D
		internal void SetPivot()
		{
			this.PivotPosition = this.CaretPosition;
		}

		// Token: 0x060007CB RID: 1995 RVA: 0x0002185B File Offset: 0x0001FA5B
		internal bool Delete()
		{
			return this.Delete(false, false);
		}

		// Token: 0x060007CC RID: 1996 RVA: 0x00021868 File Offset: 0x0001FA68
		internal bool Delete(bool emulateDeleteKey, bool fireTextChanged)
		{
			string a = null;
			if (fireTextChanged)
			{
				a = this.GetText(global::Infragistics.Windows.Editors.MaskMode.IncludeBoth);
			}
			bool result = this.DeleteHelper(emulateDeleteKey);
			if (fireTextChanged)
			{
				string text = this.GetText(global::Infragistics.Windows.Editors.MaskMode.IncludeBoth);
				if (a != text)
				{
					this.OnTextChanged(true);
				}
			}
			return result;
		}

		// Token: 0x060007CD RID: 1997 RVA: 0x000218A8 File Offset: 0x0001FAA8
		private bool DeleteHelper(bool emulateDeleteKey)
		{
			if (this.ReadOnly)
			{
				return false;
			}
			if (!this.MaskedEditor.AllowShiftingAcrossSections)
			{
				return this.DeleteWithoutShiftingAcrrossSectionBoundaries();
			}
			if (!this.IsAnyTextSelected)
			{
				if (this.CanDelete(emulateDeleteKey))
				{
					global::Infragistics.Windows.Editors.DisplayCharBase currentDisplayChar = this.GetCurrentDisplayChar();
					if (currentDisplayChar == null)
					{
						return false;
					}
					if (!currentDisplayChar.IsEditable)
					{
						if (!emulateDeleteKey || currentDisplayChar.NextFilledEditableDisplayChar == null)
						{
							return false;
						}
						this.SetCaretPivot(currentDisplayChar.NextFilledEditableDisplayChar.OverallIndexInEdit);
					}
					else
					{
						global::Infragistics.Windows.Editors.EditSectionBase editSectionBase = currentDisplayChar.Section as global::Infragistics.Windows.Editors.EditSectionBase;
						if (editSectionBase == null)
						{
							return false;
						}
						if (this.IsRightToLeft(editSectionBase))
						{
							if (editSectionBase.DeleteCharAndShift(currentDisplayChar.Index))
							{
								this.SetCaretPivot(1 + currentDisplayChar.OverallIndexInEdit);
								return true;
							}
							return false;
						}
						else
						{
							bool isEmpty = currentDisplayChar.IsEmpty;
							if (this.ShiftGlobalLeft(currentDisplayChar.OverallIndexInEdit, 1) == 0)
							{
								if (!currentDisplayChar.IsEmpty)
								{
									currentDisplayChar.EraseChar();
								}
								else if (emulateDeleteKey && isEmpty && currentDisplayChar.NextFilledEditableDisplayChar != null)
								{
									this.SetCaretPivot(currentDisplayChar.NextFilledEditableDisplayChar.OverallIndexInEdit);
								}
							}
						}
					}
				}
				this.SetPivot();
				return true;
			}
			if (this.CanDelete(emulateDeleteKey))
			{
				this.EraseSelectedText();
				int selectionStart = this.SelectionStart;
				int selectionLength = this.SelectionLength;
				int num = selectionStart + selectionLength - 1;
				this.ShiftGlobalLeft(selectionStart, selectionLength);
				bool flag = false;
				global::Infragistics.Windows.Editors.DisplayCharBase displayCharAtPosition = this.GetDisplayCharAtPosition(selectionStart);
				global::Infragistics.Windows.Editors.EditSectionBase editSectionBase2 = displayCharAtPosition.Section as global::Infragistics.Windows.Editors.EditSectionBase;
				if (this.InsertMode && displayCharAtPosition != null && editSectionBase2 != null && this.IsRightToLeft(editSectionBase2))
				{
					displayCharAtPosition = this.GetDisplayCharAtPosition(global::System.Math.Min(num, editSectionBase2.LastDisplayChar.OverallIndexInEdit));
					if (displayCharAtPosition != null)
					{
						editSectionBase2 = (displayCharAtPosition.Section as global::Infragistics.Windows.Editors.EditSectionBase);
					}
					if (displayCharAtPosition != null)
					{
						if (editSectionBase2 != null && editSectionBase2.FirstFilledChar != null && num < editSectionBase2.FirstFilledChar.OverallIndexInEdit - 1)
						{
							this.SetCaretPivot(editSectionBase2.FirstFilledChar.OverallIndexInEdit - 1);
						}
						else if (displayCharAtPosition != null)
						{
							int num2 = displayCharAtPosition.OverallIndexInEdit;
							if (this.IsRightToLeft(displayCharAtPosition.Section))
							{
								global::Infragistics.Windows.Editors.EditSectionBase editSectionBase3 = displayCharAtPosition.Section as global::Infragistics.Windows.Editors.EditSectionBase;
								if (editSectionBase3 != null)
								{
									num2 = 1 + global::System.Math.Min(num, editSectionBase3.LastDisplayChar.OverallIndexInEdit);
									int num3 = editSectionBase3.LastDisplayChar.OverallIndexInEdit + 1;
									if (editSectionBase3.FirstFilledChar != null)
									{
										num3 = editSectionBase3.FirstFilledChar.OverallIndexInEdit;
									}
									if (num2 < num3)
									{
										num2 = num3;
									}
								}
							}
							this.SetCaretPivot(num2);
						}
						flag = true;
					}
				}
				if (!flag)
				{
					this.SetCaretPivot(selectionStart);
				}
				return true;
			}
			return false;
		}

		// Token: 0x060007CE RID: 1998 RVA: 0x00021B1A File Offset: 0x0001FD1A
		private void GotoSection(global::Infragistics.Windows.Editors.SectionBase section)
		{
			this.GotoSection(section, false);
		}

		// Token: 0x060007CF RID: 1999 RVA: 0x00021B24 File Offset: 0x0001FD24
		private void GotoSection(global::Infragistics.Windows.Editors.SectionBase section, bool positionToRight)
		{
			this.GotoSection(section, positionToRight, true);
		}

		// Token: 0x060007D0 RID: 2000 RVA: 0x00021B30 File Offset: 0x0001FD30
		private void GotoSection(global::Infragistics.Windows.Editors.SectionBase section, bool positionToRight, bool positionRightAfterLastCharacter)
		{
			if (section == null)
			{
				return;
			}
			if (section != this.CurrentSection && !this.ValidateChangeSection(this.CurrentSection, section))
			{
				return;
			}
			global::Infragistics.Windows.Editors.EditSectionBase editSectionBase = section as global::Infragistics.Windows.Editors.EditSectionBase;
			if (this.IsRightToLeft(editSectionBase))
			{
				if (positionToRight)
				{
					this.CaretPosition = 1 + editSectionBase.LastDisplayChar.OverallIndexInEdit;
					return;
				}
				this.CaretPosition = ((editSectionBase.FirstFilledChar != null) ? editSectionBase.FirstFilledChar.OverallIndexInEdit : (1 + editSectionBase.LastDisplayChar.OverallIndexInEdit));
				return;
			}
			else
			{
				if (positionToRight)
				{
					this.CaretPosition = section.LastDisplayChar.OverallIndexInEdit + (positionRightAfterLastCharacter ? 1 : 0);
					return;
				}
				this.CaretPosition = section.FirstDisplayChar.OverallIndexInEdit;
				return;
			}
		}

		// Token: 0x060007D1 RID: 2001 RVA: 0x00021BD8 File Offset: 0x0001FDD8
		internal void GotoNextChar()
		{
			if (this.IsAfterLastCharacter)
			{
				string @string = global::Infragistics.Windows.Editors.ValueEditor.GetString("IllegalOperationMessageAtLastCharacter");
				this.IllegalOperation(@string);
				return;
			}
			global::Infragistics.Windows.Editors.DisplayCharBase currentDisplayChar = this.GetCurrentDisplayChar();
			global::Infragistics.Windows.Editors.DisplayCharBase displayCharAtPosition = this.GetDisplayCharAtPosition(this.CaretPosition + 1);
			if (currentDisplayChar != null && displayCharAtPosition != null && currentDisplayChar.Section != displayCharAtPosition.Section)
			{
				global::Infragistics.Windows.Editors.SectionBase section = currentDisplayChar.Section;
				this.GotoSection(displayCharAtPosition.Section, false);
				return;
			}
			if (!this.InsertMode)
			{
				this.CaretPosition++;
				return;
			}
			if (this._maskInfo.PromptChar == '\0')
			{
				this.CaretPosition = this.SkipDisplayCharsWithEmptyDrawString(this.CaretPosition);
			}
			this.CaretPosition++;
		}

		// Token: 0x060007D2 RID: 2002 RVA: 0x00021C84 File Offset: 0x0001FE84
		internal int SkipDisplayCharsWithEmptyDrawString(int caretPos)
		{
			for (;;)
			{
				global::Infragistics.Windows.Editors.DisplayCharBase displayCharAtPosition = this.GetDisplayCharAtPosition(caretPos);
				if (displayCharAtPosition == null || !displayCharAtPosition.IsEmpty || displayCharAtPosition.GetDrawChar() != '\0')
				{
					break;
				}
				caretPos++;
			}
			return caretPos;
		}

		// Token: 0x060007D3 RID: 2003 RVA: 0x00021CB4 File Offset: 0x0001FEB4
		internal void GotoPrevEditSection()
		{
			global::Infragistics.Windows.Editors.SectionBase sectionBase = (this.CurrentSection != null) ? this.CurrentSection : this.LastSection;
			global::Infragistics.Windows.Editors.DisplayCharBase displayCharAtPosition = this.GetDisplayCharAtPosition(this.CaretPosition - 1);
			if (displayCharAtPosition != null)
			{
				global::Infragistics.Windows.Editors.EditSectionBase editSectionBase = displayCharAtPosition.Section as global::Infragistics.Windows.Editors.EditSectionBase;
				if (editSectionBase != null)
				{
					if (!this.IsRightToLeft(editSectionBase))
					{
						this.GotoSection(editSectionBase, false);
						return;
					}
					if (!displayCharAtPosition.IsEmpty)
					{
						this.GotoSection(editSectionBase, false);
						return;
					}
					if (editSectionBase.PreviousEditSection != null)
					{
						this.GotoSection(editSectionBase.PreviousEditSection, true);
						return;
					}
				}
			}
			if (sectionBase.PreviousEditSection != null)
			{
				this.GotoSection(sectionBase.PreviousEditSection);
				return;
			}
			string @string = global::Infragistics.Windows.Editors.ValueEditor.GetString("IllegalOperationMessageNoPrevEditSection");
			this.IllegalOperation(@string);
		}

		// Token: 0x060007D4 RID: 2004 RVA: 0x00021D5C File Offset: 0x0001FF5C
		internal void GotoNextEditSection()
		{
			global::Infragistics.Windows.Editors.SectionBase currentSection = this.CurrentSection;
			if (currentSection == null)
			{
				string @string = global::Infragistics.Windows.Editors.ValueEditor.GetString("IllegalOperationMessageNoNextEditSection");
				this.IllegalOperation(@string);
				return;
			}
			if (currentSection.NextEditSection != null)
			{
				this.GotoSection(currentSection.NextEditSection, false);
				return;
			}
			string string2 = global::Infragistics.Windows.Editors.ValueEditor.GetString("IllegalOperationMessageNoNextEditSection");
			this.IllegalOperation(string2);
		}

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x060007D5 RID: 2005 RVA: 0x00021DAE File Offset: 0x0001FFAE
		private global::System.Collections.Generic.Stack<global::Infragistics.Windows.Editors.EditInfo.EditorSnapshot> UndoHistory
		{
			get
			{
				if (this._undoHistory == null)
				{
					this._undoHistory = new global::System.Collections.Generic.Stack<global::Infragistics.Windows.Editors.EditInfo.EditorSnapshot>();
				}
				return this._undoHistory;
			}
		}

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x060007D6 RID: 2006 RVA: 0x00021DC9 File Offset: 0x0001FFC9
		private global::System.Collections.Generic.Stack<global::Infragistics.Windows.Editors.EditInfo.EditorSnapshot> RedoHistory
		{
			get
			{
				if (this._redoHistory == null)
				{
					this._redoHistory = new global::System.Collections.Generic.Stack<global::Infragistics.Windows.Editors.EditInfo.EditorSnapshot>();
				}
				return this._redoHistory;
			}
		}

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x060007D7 RID: 2007 RVA: 0x00021DE4 File Offset: 0x0001FFE4
		private bool HasUndoHistory
		{
			get
			{
				return this._undoHistory != null && this._undoHistory.Count >= 2;
			}
		}

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x060007D8 RID: 2008 RVA: 0x00021E01 File Offset: 0x00020001
		private bool HasRedoHistory
		{
			get
			{
				return this._redoHistory != null && this._redoHistory.Count > 0;
			}
		}

		// Token: 0x060007D9 RID: 2009 RVA: 0x00021E1B File Offset: 0x0002001B
		internal void ManageUndoHistory_TextChanged(bool viaUserAction, global::System.Windows.Input.RoutedCommand command)
		{
			if (!this._inUndoRedoHelper && global::Infragistics.Windows.Editors.MaskedEditorCommands.Undo != command && global::Infragistics.Windows.Editors.MaskedEditorCommands.Redo != command)
			{
				this.ClearRedoHistory();
				if (!viaUserAction)
				{
					this.ClearUndoHistory();
				}
				this.UndoHistory.Push(new global::Infragistics.Windows.Editors.EditInfo.EditorSnapshot(this));
			}
		}

		// Token: 0x060007DA RID: 2010 RVA: 0x00021E55 File Offset: 0x00020055
		internal void Undo(bool fireValueChanged)
		{
			this.UndoRedoHelper(true, fireValueChanged);
		}

		// Token: 0x060007DB RID: 2011 RVA: 0x00021E5F File Offset: 0x0002005F
		internal void Redo(bool fireValueChanged)
		{
			this.UndoRedoHelper(false, fireValueChanged);
		}

		// Token: 0x060007DC RID: 2012 RVA: 0x00021E6C File Offset: 0x0002006C
		internal void UndoRedoHelper(bool undo, bool fireValueChanged)
		{
			if (this._inUndoRedoHelper)
			{
				return;
			}
			this._inUndoRedoHelper = true;
			try
			{
				string text = this.GetText(global::Infragistics.Windows.Editors.MaskMode.IncludeBoth);
				try
				{
					global::System.Collections.Generic.Stack<global::Infragistics.Windows.Editors.EditInfo.EditorSnapshot> stack = undo ? this._undoHistory : this._redoHistory;
					if (stack != null && stack.Count >= 2)
					{
						global::Infragistics.Windows.Editors.EditInfo.EditorSnapshot editorSnapshot = stack.Pop();
						if (undo)
						{
							this.RedoHistory.Push(editorSnapshot);
						}
						else
						{
							this.UndoHistory.Push(editorSnapshot);
						}
						editorSnapshot = stack.Peek();
						editorSnapshot.Apply(this);
					}
				}
				finally
				{
					if (fireValueChanged)
					{
						string text2 = this.GetText(global::Infragistics.Windows.Editors.MaskMode.IncludeBoth);
						if (string.Compare(text, text2, false, global::System.Globalization.CultureInfo.CurrentCulture) != 0)
						{
							this.OnTextChanged(true);
						}
					}
				}
			}
			finally
			{
				this._inUndoRedoHelper = false;
			}
		}

		// Token: 0x060007DD RID: 2013 RVA: 0x00021F2C File Offset: 0x0002012C
		internal void ClearRedoHistory()
		{
			this._redoHistory = null;
		}

		// Token: 0x060007DE RID: 2014 RVA: 0x00021F35 File Offset: 0x00020135
		internal void ClearUndoHistory()
		{
			this._undoHistory = null;
		}

		// Token: 0x060007DF RID: 2015 RVA: 0x00021F40 File Offset: 0x00020140
		internal void GotoPrevChar()
		{
			if (this.IsAfterLastCharacter)
			{
				global::Infragistics.Windows.Editors.EditSectionBase editSectionBase = this.LastSection as global::Infragistics.Windows.Editors.EditSectionBase;
				if (!this.IsRightToLeft(editSectionBase))
				{
					this.CaretPosition = this.GetTotalNumberOfDisplayChars() - 1;
					return;
				}
				if (!editSectionBase.LastDisplayChar.IsEmpty)
				{
					this.CaretPosition = this.GetTotalNumberOfDisplayChars() - 1;
					return;
				}
				if (!this.InsertMode && editSectionBase.PreviousEditSection == null)
				{
					this.SetCaretPivot(0);
					return;
				}
				this.GotoPrevEditSection();
				return;
			}
			else
			{
				if (this.IsAtFirstChar)
				{
					string @string = global::Infragistics.Windows.Editors.ValueEditor.GetString("IllegalOperationMessageNoPrevCharacter");
					this.IllegalOperation(@string);
					return;
				}
				global::Infragistics.Windows.Editors.DisplayCharBase currentDisplayChar = this.GetCurrentDisplayChar();
				global::Infragistics.Windows.Editors.DisplayCharBase displayCharAtPosition = this.GetDisplayCharAtPosition(this.CaretPosition - 1);
				if (currentDisplayChar == null || displayCharAtPosition == null || currentDisplayChar.Section != displayCharAtPosition.Section)
				{
					if (currentDisplayChar != null && displayCharAtPosition != null)
					{
						global::Infragistics.Windows.Editors.EditSectionBase editSectionBase2 = displayCharAtPosition.Section as global::Infragistics.Windows.Editors.EditSectionBase;
						if (editSectionBase2 != null && this.IsRightToLeft(editSectionBase2))
						{
							if (!editSectionBase2.LastDisplayChar.IsEmpty)
							{
								if (currentDisplayChar.Section != editSectionBase2)
								{
									this.ValidateChangeSection(currentDisplayChar.Section, editSectionBase2);
								}
								this.CaretPosition = editSectionBase2.LastDisplayChar.OverallIndexInEdit;
								return;
							}
							if (!this.InsertMode && editSectionBase2.PreviousEditSection == null)
							{
								this.SetCaretPivot(0);
								return;
							}
							this.GotoPrevEditSection();
							return;
						}
						else
						{
							if (displayCharAtPosition.Section != null)
							{
								this.GotoSection(displayCharAtPosition.Section, true, false);
								return;
							}
							string string2 = global::Infragistics.Windows.Editors.ValueEditor.GetString("IllegalOperationMessageCannotMoveToPrevCharacter");
							this.IllegalOperation(string2);
						}
					}
					return;
				}
				global::Infragistics.Windows.Editors.EditSectionBase editSectionBase3 = currentDisplayChar.Section as global::Infragistics.Windows.Editors.EditSectionBase;
				if (!this.IsRightToLeft(editSectionBase3))
				{
					this.CaretPosition--;
					return;
				}
				if (!displayCharAtPosition.IsEmpty)
				{
					this.CaretPosition--;
					return;
				}
				if (editSectionBase3.PreviousEditSection != null)
				{
					this.GotoSection(editSectionBase3.PreviousEditSection, true);
					return;
				}
				if (!this.InsertMode)
				{
					this.SetCaretPivot(0);
				}
				return;
			}
		}

		// Token: 0x060007E0 RID: 2016 RVA: 0x00022110 File Offset: 0x00020310
		internal bool ExecuteCommandImpl(global::System.Windows.Input.RoutedCommand command, object commandParameter, bool shift, bool control)
		{
			if (global::Infragistics.Windows.Editors.MaskedEditorCommands.NotACommand == command)
			{
				return true;
			}
			bool flag = false;
			bool flag2 = false;
			global::Infragistics.Windows.Editors.SectionBase currentSection = this.GetCurrentSection(true);
			if (!this.IsInitialized || this.MaskInfo.DesignMode)
			{
				return false;
			}
			string text = this.GetText(global::Infragistics.Windows.Editors.MaskMode.IncludeBoth);
			bool flag3 = false;
			if (global::Infragistics.Windows.Editors.MaskedEditorCommands.SetPivot == command)
			{
				this.SetPivot();
				flag2 = true;
			}
			else if (global::Infragistics.Windows.Editors.MaskedEditorCommands.Backspace == command)
			{
				flag3 = true;
				if (!this.ReadOnly)
				{
					global::Infragistics.Windows.Editors.DisplayCharBase displayCharBase = this.GetCurrentDisplayChar();
					global::Infragistics.Windows.Editors.DisplayCharBase displayCharAtPosition = this.GetDisplayCharAtPosition(this.CaretPosition - 1);
					if (this.IsAnyTextSelected)
					{
						if (!this.Delete())
						{
							string @string = global::Infragistics.Windows.Editors.ValueEditor.GetString("IllegalOperationMessageCannotDelete");
							this.IllegalOperation(@string);
						}
					}
					else if (this.IsAfterLastCharacter)
					{
						global::Infragistics.Windows.Editors.EditSectionBase editSectionBase = this.LastSection as global::Infragistics.Windows.Editors.EditSectionBase;
						if (this.IsRightToLeft(editSectionBase) && this.InsertMode)
						{
							displayCharBase = editSectionBase.LastDisplayChar;
							if (!displayCharBase.IsEmpty)
							{
								if (editSectionBase != null && !editSectionBase.DeleteCharAndShift(displayCharBase.Index))
								{
									string string2 = global::Infragistics.Windows.Editors.ValueEditor.GetString("IllegalOperationMessageGeneral");
									this.IllegalOperation(string2);
								}
							}
							else if (editSectionBase.PreviousEditSection != null)
							{
								this.GotoSection(editSectionBase.PreviousEditSection, true);
								this.SetPivot();
							}
							else
							{
								string string3 = global::Infragistics.Windows.Editors.ValueEditor.GetString("IllegalOperationMessageNoPrevEditableCharacter");
								this.IllegalOperation(string3);
							}
						}
						else
						{
							displayCharBase = this.GetDisplayCharAtPosition(this.CaretPosition - 1);
							editSectionBase = (displayCharBase.Section as global::Infragistics.Windows.Editors.EditSectionBase);
							if (editSectionBase != null)
							{
								if (this.InsertMode)
								{
									editSectionBase.DeleteCharAndShift(displayCharBase.Index);
									this.CaretPosition--;
									this.SetPivot();
								}
								else
								{
									this.CaretPosition--;
									if (this.CanDelete())
									{
										this.Delete();
									}
									else
									{
										this.SetPivot();
									}
								}
							}
							else
							{
								this.CaretPosition--;
								this.SetPivot();
							}
						}
					}
					else if (this.IsAtFirstChar)
					{
						string string4 = global::Infragistics.Windows.Editors.ValueEditor.GetString("IllegalOperationMessageNoPrevCharacter");
						this.IllegalOperation(string4);
					}
					else if (displayCharBase != null)
					{
						global::Infragistics.Windows.Editors.EditSectionBase editSectionBase = displayCharBase.Section as global::Infragistics.Windows.Editors.EditSectionBase;
						if (this.IsRightToLeft(editSectionBase) && this.InsertMode)
						{
							displayCharAtPosition = this.GetDisplayCharAtPosition(displayCharBase.OverallIndexInEdit - 1);
							if (displayCharAtPosition.Section != editSectionBase)
							{
								if (displayCharAtPosition.IsEditable)
								{
									int caretPosition = this.CaretPosition;
									this.CaretPosition--;
									if (this.CanDelete())
									{
										this.Delete();
									}
									else
									{
										this.CaretPosition = caretPosition;
									}
									this.SetPivot();
								}
								else
								{
									this.SetCaretPivot(displayCharAtPosition.OverallIndexInEdit);
								}
							}
							else if (!displayCharAtPosition.IsEmpty)
							{
								if (!editSectionBase.DeleteCharAndShift(displayCharAtPosition.Index))
								{
									string string5 = global::Infragistics.Windows.Editors.ValueEditor.GetString("IllegalOperationMessageGeneral");
									this.IllegalOperation(string5);
								}
							}
							else if (editSectionBase.PreviousEditSection != null)
							{
								this.GotoSection(editSectionBase.PreviousEditSection, true);
								this.SetPivot();
							}
							else if (!this.InsertMode)
							{
								this.SetCaretPivot(0);
							}
							else
							{
								string string6 = global::Infragistics.Windows.Editors.ValueEditor.GetString("IllegalOperationMessageNoPrevEditableCharacter");
								this.IllegalOperation(string6);
							}
						}
						else if (this.IsAtFirstChar)
						{
							string string7 = global::Infragistics.Windows.Editors.ValueEditor.GetString("IllegalOperationMessageNoPrevCharacter");
							this.IllegalOperation(string7);
						}
						else
						{
							displayCharBase = this.GetDisplayCharAtPosition(this.CaretPosition - 1);
							editSectionBase = (displayCharBase.Section as global::Infragistics.Windows.Editors.EditSectionBase);
							if (editSectionBase != null)
							{
								if (this.IsRightToLeft(editSectionBase) && this.InsertMode)
								{
									if (!displayCharBase.IsEmpty)
									{
										editSectionBase = (displayCharBase.Section as global::Infragistics.Windows.Editors.EditSectionBase);
										if (!editSectionBase.DeleteCharAndShift(displayCharBase.Index))
										{
											string string8 = global::Infragistics.Windows.Editors.ValueEditor.GetString("IllegalOperationMessageGeneral");
											this.IllegalOperation(string8);
										}
									}
									else if (editSectionBase.PreviousEditSection != null)
									{
										this.GotoSection(editSectionBase.PreviousEditSection, true);
										this.SetPivot();
									}
									else if (!this.InsertMode)
									{
										this.SetCaretPivot(0);
									}
									else
									{
										string string9 = global::Infragistics.Windows.Editors.ValueEditor.GetString("IllegalOperationMessageNoPrevEditableCharacter");
										this.IllegalOperation(string9);
									}
								}
								else
								{
									int caretPosition2 = this.CaretPosition;
									this.CaretPosition--;
									if (this.CanDelete())
									{
										this.Delete();
									}
									else
									{
										this.CaretPosition = caretPosition2;
									}
									this.SetPivot();
								}
							}
							else
							{
								this.CaretPosition--;
								this.SetPivot();
							}
						}
					}
					if (this.CurrentSection != null && this.CurrentSection.NextEditSection is global::Infragistics.Windows.Editors.FractionPartContinuous)
					{
						this.EnsureNumberSectionState();
					}
					flag = true;
				}
			}
			else if (global::Infragistics.Windows.Editors.MaskedEditorCommands.Delete == command)
			{
				flag3 = true;
				if (!this.ReadOnly)
				{
					if (!this.Delete(true, false))
					{
						string string10 = global::Infragistics.Windows.Editors.ValueEditor.GetString("IllegalOperationMessageGeneral");
						this.IllegalOperation(string10);
					}
					flag = true;
				}
			}
			else if (global::Infragistics.Windows.Editors.MaskedEditorCommands.FirstCharacter == command)
			{
				global::Infragistics.Windows.Editors.SectionBase firstSection = this.FirstSection;
				if (global::System.Windows.Input.ModifierKeys.None == (global::System.Windows.Input.Keyboard.Modifiers & global::System.Windows.Input.ModifierKeys.Shift) && this.IsRightToLeft(firstSection) && this.InsertMode)
				{
					global::Infragistics.Windows.Editors.EditSectionBase editSectionBase = firstSection as global::Infragistics.Windows.Editors.EditSectionBase;
					if (editSectionBase != null)
					{
						if (editSectionBase.FirstFilledChar != null)
						{
							this.CaretPosition = editSectionBase.FirstFilledChar.OverallIndexInEdit;
						}
						else
						{
							this.CaretPosition = 1 + editSectionBase.LastDisplayChar.OverallIndexInEdit;
						}
					}
				}
				else
				{
					this.CaretPosition = 0;
				}
				flag2 = true;
			}
			else if (global::Infragistics.Windows.Editors.MaskedEditorCommands.AfterLastCharacter == command)
			{
				this.CaretPosition = this.GetTotalNumberOfDisplayChars();
				flag2 = true;
			}
			else if (global::Infragistics.Windows.Editors.MaskedEditorCommands.NextCharacter == command)
			{
				this.GotoNextChar();
				flag2 = true;
			}
			else if (global::Infragistics.Windows.Editors.MaskedEditorCommands.PreviousCharacter == command)
			{
				this.GotoPrevChar();
				if (this.CurrentSection != null && this.CurrentSection.NextEditSection is global::Infragistics.Windows.Editors.FractionPartContinuous)
				{
					this.EnsureNumberSectionState();
				}
				flag2 = true;
			}
			else if (global::Infragistics.Windows.Editors.MaskedEditorCommands.NextSection == command)
			{
				this.GotoNextEditSection();
				flag2 = true;
			}
			else if (global::Infragistics.Windows.Editors.MaskedEditorCommands.PreviousSection == command)
			{
				this.GotoPrevEditSection();
				if (this.CurrentSection != null && this.CurrentSection.NextEditSection is global::Infragistics.Windows.Editors.FractionPartContinuous)
				{
					this.EnsureNumberSectionState();
				}
				flag2 = true;
			}
			else if (global::Infragistics.Windows.Editors.MaskedEditorCommands.SpinUp == command || global::Infragistics.Windows.Editors.MaskedEditorCommands.SpinDown == command)
			{
				if (!this.ReadOnly)
				{
					this.Spin(global::Infragistics.Windows.Editors.MaskedEditorCommands.SpinUp == command, commandParameter, false, false);
					flag = true;
					flag3 = true;
				}
			}
			else if (global::Infragistics.Windows.Editors.MaskedEditorCommands.ToggleInsertionMode == command)
			{
				this.ToggleInsertMode();
				flag3 = true;
			}
			else if (global::Infragistics.Windows.Editors.MaskedEditorCommands.SelectSection == command)
			{
				global::Infragistics.Windows.Editors.EditSectionBase editSectionBase = this.CurrentSection as global::Infragistics.Windows.Editors.EditSectionBase;
				if (editSectionBase != null && editSectionBase.FirstFilledChar != null)
				{
					this.CaretPosition = editSectionBase.FirstFilledChar.OverallIndexInEdit;
					this.PivotPosition = 1 + editSectionBase.LastFilledChar.OverallIndexInEdit;
					flag2 = true;
				}
			}
			else if (global::Infragistics.Windows.Editors.MaskedEditorCommands.SelectAll == command)
			{
				this.SelectAll();
			}
			else if (global::Infragistics.Windows.Editors.MaskedEditorCommands.Copy == command)
			{
				this.Copy();
			}
			else if (global::Infragistics.Windows.Editors.MaskedEditorCommands.Cut == command)
			{
				this.Cut(false);
				flag = true;
			}
			else if (global::Infragistics.Windows.Editors.MaskedEditorCommands.Paste == command)
			{
				this.Paste(false);
				flag = true;
			}
			else if (global::Infragistics.Windows.Editors.MaskedEditorCommands.Undo == command)
			{
				this.Undo(false);
			}
			else if (global::Infragistics.Windows.Editors.MaskedEditorCommands.Redo == command)
			{
				this.Redo(false);
			}
			else if (global::Infragistics.Windows.Editors.MaskedEditorCommands.ToggleDropDown == command)
			{
				global::Infragistics.Windows.Editors.XamMaskedEditor maskedEditor = this.MaskedEditor;
				if (maskedEditor != null)
				{
					maskedEditor.ToggleDropDown();
				}
			}
			global::Infragistics.Windows.Editors.SectionBase currentSection2 = this.GetCurrentSection(true);
			if (currentSection2 != null && currentSection != null && currentSection != currentSection2)
			{
				global::Infragistics.Windows.Editors.EditSectionBase editSectionBase2 = currentSection as global::Infragistics.Windows.Editors.EditSectionBase;
				if (editSectionBase2 != null)
				{
					editSectionBase2.ValidateSection();
				}
			}
			string text2 = this.GetText(global::Infragistics.Windows.Editors.MaskMode.IncludeBoth);
			if (!text2.Equals(text))
			{
				this.OnTextChanged(true, command);
			}
			if (flag)
			{
				this.DirtyMaskElement();
			}
			else if (flag2)
			{
				this.DirtyMaskElement();
			}
			if (flag3 && this.MaskedEditor != null)
			{
				this.MaskedEditor.ResetCaretBlinking();
			}
			return true;
		}

		// Token: 0x060007E1 RID: 2017 RVA: 0x000228A8 File Offset: 0x00020AA8
		internal bool Spin(bool up, object amount, bool setToLimit, bool fireValueChanged)
		{
			if (!this.CanSpin(up, amount))
			{
				return false;
			}
			string text = null;
			if (fireValueChanged)
			{
				text = this.GetText(global::Infragistics.Windows.Editors.MaskMode.IncludeBoth);
			}
			bool result;
			try
			{
				if (this.SelectionStart + this.SelectionLength >= this.GetTotalNumberOfDisplayChars() && global::Infragistics.Windows.Editors.XamMaskedEditor.IsMaskValidForDataType(typeof(global::System.DateTime), this.MaskInfo.ResolvedMask, this.MaskInfo.FormatProvider))
				{
					string text2 = this.GetText(global::Infragistics.Windows.Editors.MaskMode.Raw);
					if (text2 != null)
					{
						if (text2.Length != 0)
						{
							goto IL_83;
						}
					}
					try
					{
						this.Value = global::System.DateTime.Now;
					}
					catch
					{
					}
					return true;
				}
				IL_83:
				global::Infragistics.Windows.Editors.XamMaskedEditor maskedEditor = this.MaskedEditor;
				global::Infragistics.Windows.Editors.SpinInfo resolvedSpinInfo = this.GetResolvedSpinInfo(amount);
				if (amount != null || resolvedSpinInfo != null)
				{
					result = (resolvedSpinInfo != null && resolvedSpinInfo.Spin(up));
				}
				else
				{
					global::Infragistics.Windows.Editors.EditSectionBase spinSection = this.GetSpinSection();
					if (spinSection != null && spinSection.SupportsSpinning)
					{
						result = spinSection.Spin(up, setToLimit);
					}
					else
					{
						result = false;
					}
				}
			}
			finally
			{
				this.DirtyMaskElement();
				if (fireValueChanged)
				{
					string text3 = this.GetText(global::Infragistics.Windows.Editors.MaskMode.IncludeBoth);
					if (text3 != null && text != null && string.Compare(text, text3, false, global::System.Globalization.CultureInfo.CurrentCulture) != 0)
					{
						this.OnTextChanged(true);
					}
				}
			}
			return result;
		}

		// Token: 0x060007E2 RID: 2018 RVA: 0x000229D4 File Offset: 0x00020BD4
		internal global::Infragistics.Windows.Editors.EditSectionBase GetSpinSection()
		{
			global::Infragistics.Windows.Editors.EditSectionBase editSectionBase = this.CurrentSection as global::Infragistics.Windows.Editors.EditSectionBase;
			if (editSectionBase != null && editSectionBase.SupportsSpinning)
			{
				return editSectionBase;
			}
			global::Infragistics.Windows.Editors.DisplayCharBase displayCharAtPosition = this.GetDisplayCharAtPosition(this.CaretPosition - 1);
			if (displayCharAtPosition != null)
			{
				editSectionBase = (displayCharAtPosition.Section as global::Infragistics.Windows.Editors.EditSectionBase);
				if (editSectionBase != null && editSectionBase.SupportsSpinning)
				{
					return editSectionBase;
				}
			}
			return null;
		}

		// Token: 0x060007E3 RID: 2019 RVA: 0x00022A28 File Offset: 0x00020C28
		private bool InternalCompareNumerical(object o1, object o2, out int result)
		{
			result = 0;
			if (o1 == null || o2 == null)
			{
				return false;
			}
			if (o1.GetType() != o2.GetType())
			{
				global::System.IFormatProvider formatProvider = this.MaskInfo.FormatProvider;
				try
				{
					if (o1 is global::System.IComparable)
					{
						o2 = global::System.Convert.ChangeType(o2, o1.GetType(), formatProvider);
					}
					else if (o2 is global::System.IComparable)
					{
						o1 = global::System.Convert.ChangeType(o1, o2.GetType(), formatProvider);
					}
				}
				catch (global::System.Exception)
				{
				}
			}
			if (o1.GetType() == o2.GetType() && o1 is global::System.IComparable)
			{
				try
				{
					result = ((global::System.IComparable)o1).CompareTo(o2);
					return true;
				}
				catch (global::System.Exception)
				{
					return false;
				}
				return false;
			}
			return false;
		}

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x060007E4 RID: 2020 RVA: 0x00022AE8 File Offset: 0x00020CE8
		internal bool ReadOnly
		{
			get
			{
				return this.MaskedEditor.IsReadOnly;
			}
		}

		// Token: 0x060007E5 RID: 2021 RVA: 0x00022AF5 File Offset: 0x00020CF5
		internal bool CanSpin(bool up)
		{
			return this.CanSpin(up, null);
		}

		// Token: 0x060007E6 RID: 2022 RVA: 0x00022B00 File Offset: 0x00020D00
		private global::Infragistics.Windows.Editors.SpinInfo GetResolvedSpinInfo(object amount)
		{
			global::Infragistics.Windows.Editors.XamMaskedEditor maskedEditor = this.MaskedEditor;
			global::Infragistics.Windows.Editors.SpinInfo spinInfo = maskedEditor._cachedSpinInfo;
			if ((amount != null || spinInfo != null) && (spinInfo == null || (amount != null && !spinInfo.IsSameSpinIncrement(amount))))
			{
				spinInfo = global::Infragistics.Windows.Editors.SpinInfo.Parse(maskedEditor, amount);
			}
			return spinInfo;
		}

		// Token: 0x060007E7 RID: 2023 RVA: 0x00022B3C File Offset: 0x00020D3C
		internal bool CanSpin(bool up, object amount)
		{
			if (this.ReadOnly)
			{
				return false;
			}
			global::Infragistics.Windows.Editors.XamMaskedEditor maskedEditor = this.MaskedEditor;
			global::Infragistics.Windows.Editors.SpinInfo resolvedSpinInfo = this.GetResolvedSpinInfo(amount);
			if (amount != null || resolvedSpinInfo != null)
			{
				return resolvedSpinInfo != null && resolvedSpinInfo.CanSpin(up);
			}
			if (global::Infragistics.Windows.Editors.XamMaskedEditor.IsMaskValidForDataType(typeof(global::System.DateTime), this.MaskInfo.ResolvedMask, this.MaskInfo.FormatProvider))
			{
				string text = this.GetText(global::Infragistics.Windows.Editors.MaskMode.Raw);
				if (text == null || text.Length == 0)
				{
					return true;
				}
			}
			global::Infragistics.Windows.Editors.EditSectionBase spinSection = this.GetSpinSection();
			if (spinSection == null || !spinSection.SupportsSpinning)
			{
				return false;
			}
			if (!spinSection.CanSpin(up))
			{
				return false;
			}
			object minValue = this.MaskInfo.MinValue;
			object maxValue = this.MaskInfo.MaxValue;
			int num = 0;
			int num2 = 9999;
			int num3 = 1;
			int num4 = 12;
			global::System.DateTime? dateTime = (minValue is global::System.DateTime) ? ((global::System.DateTime?)minValue) : null;
			global::System.DateTime? dateTime2 = (maxValue is global::System.DateTime) ? ((global::System.DateTime?)maxValue) : null;
			global::System.Globalization.Calendar calendar = this.Sections.Calendar;
			if (dateTime != null && dateTime2 != null)
			{
				num = calendar.GetYear(dateTime.Value);
				num2 = calendar.GetYear(dateTime2.Value);
				num3 = calendar.GetMonth(dateTime.Value);
				num4 = calendar.GetMonth(dateTime2.Value);
			}
			if (this.MaskInfo.MaskEditor.SpinWrap)
			{
				if (spinSection is global::Infragistics.Windows.Editors.YearSection && num != num2)
				{
					return true;
				}
				if (spinSection is global::Infragistics.Windows.Editors.MonthSection && (num != num2 || num3 != num4))
				{
					return true;
				}
				if (spinSection is global::Infragistics.Windows.Editors.DaySection)
				{
					return true;
				}
			}
			if (up)
			{
				if (maxValue == null)
				{
					return true;
				}
				global::Infragistics.Windows.Editors.NumberSection numberSection = null;
				if (spinSection is global::Infragistics.Windows.Editors.NumberSection)
				{
					numberSection = (global::Infragistics.Windows.Editors.NumberSection)spinSection;
				}
				else if (spinSection is global::Infragistics.Windows.Editors.FractionPart)
				{
					numberSection = (spinSection.PreviousEditSection as global::Infragistics.Windows.Editors.NumberSection);
				}
				bool flag = true;
				if (numberSection != null && typeof(global::Infragistics.Windows.Editors.NumberSection) == numberSection.GetType())
				{
					if (this.MaskInfo.MaskEditor.SpinWrap)
					{
						return true;
					}
					try
					{
						decimal num5 = numberSection.ToDecimal();
						int num6;
						if (this.InternalCompareNumerical(num5, maxValue, out num6) && num6 >= 0)
						{
							return false;
						}
						flag = false;
					}
					catch (global::System.Exception)
					{
					}
				}
				if (flag && spinSection is global::Infragistics.Windows.Editors.FractionPart)
				{
					if (this.MaskInfo.MaskEditor.SpinWrap)
					{
						return true;
					}
					numberSection = (spinSection.PreviousEditSection as global::Infragistics.Windows.Editors.NumberSection);
					double fractionValue = ((global::Infragistics.Windows.Editors.FractionPart)spinSection).GetFractionValue();
					int num7;
					if (this.InternalCompareNumerical(fractionValue, maxValue, out num7) && num7 >= 0)
					{
						return false;
					}
					return true;
				}
				else
				{
					if (spinSection is global::Infragistics.Windows.Editors.YearSection)
					{
						try
						{
							int num8;
							if (((global::Infragistics.Windows.Editors.YearSection)spinSection).TryGetYear(out num8) && dateTime2 != null && num8 >= calendar.GetYear(dateTime2.Value))
							{
								return false;
							}
							return true;
						}
						catch (global::System.Exception)
						{
							return true;
						}
					}
					if (spinSection is global::Infragistics.Windows.Editors.MonthSection)
					{
						try
						{
							int num9;
							if (((global::Infragistics.Windows.Editors.MonthSection)spinSection).TryToInt(out num9) && dateTime2 != null && num == num2 && num9 >= calendar.GetYear(dateTime2.Value))
							{
								return false;
							}
							return true;
						}
						catch (global::System.Exception)
						{
							return true;
						}
					}
					if (!(spinSection is global::Infragistics.Windows.Editors.DaySection))
					{
						return true;
					}
					try
					{
						int num10;
						if (((global::Infragistics.Windows.Editors.DaySection)spinSection).TryToInt(out num10) && dateTime2 != null && num == num2 && num3 == num4 && num10 >= calendar.GetDayOfMonth(dateTime2.Value))
						{
							return false;
						}
						return true;
					}
					catch (global::System.Exception)
					{
						return true;
					}
				}
			}
			if (minValue != null)
			{
				global::Infragistics.Windows.Editors.NumberSection numberSection2 = null;
				if (spinSection is global::Infragistics.Windows.Editors.NumberSection)
				{
					numberSection2 = (global::Infragistics.Windows.Editors.NumberSection)spinSection;
				}
				else if (spinSection is global::Infragistics.Windows.Editors.FractionPart)
				{
					numberSection2 = (spinSection.PreviousEditSection as global::Infragistics.Windows.Editors.NumberSection);
				}
				bool flag2 = true;
				if (numberSection2 != null && typeof(global::Infragistics.Windows.Editors.NumberSection) == numberSection2.GetType())
				{
					if (this.MaskInfo.MaskEditor.SpinWrap)
					{
						return true;
					}
					try
					{
						decimal num11 = numberSection2.ToDecimal();
						int num12;
						if (this.InternalCompareNumerical(num11, minValue, out num12) && num12 <= 0 && spinSection == numberSection2)
						{
							return false;
						}
						flag2 = false;
					}
					catch (global::System.Exception)
					{
					}
				}
				if (flag2 && spinSection is global::Infragistics.Windows.Editors.FractionPart)
				{
					if (this.MaskInfo.MaskEditor.SpinWrap)
					{
						return true;
					}
					numberSection2 = (spinSection.PreviousEditSection as global::Infragistics.Windows.Editors.NumberSection);
					double fractionValue2 = ((global::Infragistics.Windows.Editors.FractionPart)spinSection).GetFractionValue();
					int num13;
					if (this.InternalCompareNumerical(fractionValue2, minValue, out num13) && num13 <= 0)
					{
						return false;
					}
				}
				else
				{
					if (spinSection is global::Infragistics.Windows.Editors.YearSection)
					{
						try
						{
							int num14;
							if (((global::Infragistics.Windows.Editors.YearSection)spinSection).TryGetYear(out num14) && dateTime != null && num14 <= calendar.GetYear(dateTime.Value))
							{
								return false;
							}
							return true;
						}
						catch (global::System.Exception)
						{
							return true;
						}
					}
					if (spinSection is global::Infragistics.Windows.Editors.MonthSection)
					{
						try
						{
							int num15;
							if (((global::Infragistics.Windows.Editors.MonthSection)spinSection).TryToInt(out num15) && dateTime != null && num == num2 && num15 <= calendar.GetMonth(dateTime.Value))
							{
								return false;
							}
							return true;
						}
						catch (global::System.Exception)
						{
							return true;
						}
					}
					if (spinSection is global::Infragistics.Windows.Editors.DaySection)
					{
						try
						{
							int num16;
							if (((global::Infragistics.Windows.Editors.DaySection)spinSection).TryToInt(out num16) && dateTime != null && num == num2 && num3 == num4 && num16 <= calendar.GetDayOfMonth(dateTime.Value))
							{
								return false;
							}
						}
						catch (global::System.Exception)
						{
						}
					}
				}
			}
			return true;
		}

		// Token: 0x060007E8 RID: 2024 RVA: 0x000230DC File Offset: 0x000212DC
		internal void IllegalOperation(string message)
		{
			global::Infragistics.Windows.Editors.Events.InvalidOperationEventArgs invalidOperationEventArgs = new global::Infragistics.Windows.Editors.Events.InvalidOperationEventArgs(message);
			this.OnInvalidOperation(invalidOperationEventArgs);
			if (invalidOperationEventArgs.Beep)
			{
				this.MaskInfo.MaskEditor.Beep();
			}
		}

		// Token: 0x060007E9 RID: 2025 RVA: 0x00023110 File Offset: 0x00021310
		private void IllegalCharPressed(global::Infragistics.Windows.Editors.DisplayCharBase displayChar, char c)
		{
			global::Infragistics.Windows.Editors.Events.InvalidCharEventArgs invalidCharEventArgs = new global::Infragistics.Windows.Editors.Events.InvalidCharEventArgs(c, displayChar);
			this.OnInvalidChar(invalidCharEventArgs);
			if (invalidCharEventArgs.Beep)
			{
				this.MaskInfo.MaskEditor.Beep();
			}
			this._lastIllegalChar = c;
			this._lastIllegalDisplayChar = displayChar;
		}

		// Token: 0x060007EA RID: 2026 RVA: 0x00023154 File Offset: 0x00021354
		private void EraseDisplayChars(int startIndex, int eraseCharCount)
		{
			int totalNumberOfDisplayChars = this.GetTotalNumberOfDisplayChars();
			if (startIndex < 0 || startIndex > totalNumberOfDisplayChars)
			{
				return;
			}
			int i = startIndex;
			int num = i + eraseCharCount;
			while (i < num)
			{
				int num2 = i;
				if (num2 >= totalNumberOfDisplayChars)
				{
					return;
				}
				global::Infragistics.Windows.Editors.DisplayCharBase displayCharAtPosition = this.GetDisplayCharAtPosition(num2);
				global::Infragistics.Windows.Editors.EditSectionBase editSectionBase = displayCharAtPosition.Section as global::Infragistics.Windows.Editors.EditSectionBase;
				if (this.InsertMode && this.IsRightToLeft(editSectionBase))
				{
					int num3 = global::System.Math.Min(num - 1, editSectionBase.LastDisplayChar.OverallIndexInEdit);
					global::Infragistics.Windows.Editors.DisplayCharBase displayCharAtPosition2 = this.GetDisplayCharAtPosition(num3);
					if (displayCharAtPosition2 != null)
					{
						num3 = displayCharAtPosition2.Index;
					}
					else
					{
						num3 = displayCharAtPosition.Index;
					}
					editSectionBase.DeleteCharsAndShift(num3, global::System.Math.Min(num - displayCharAtPosition.OverallIndexInEdit, 1 + editSectionBase.LastDisplayChar.Index - displayCharAtPosition.Index));
					i = editSectionBase.LastDisplayChar.OverallIndexInEdit;
				}
				else if (displayCharAtPosition != null && displayCharAtPosition.IsEditable)
				{
					displayCharAtPosition.Char = '\0';
				}
				i++;
			}
		}

		// Token: 0x060007EB RID: 2027 RVA: 0x00023241 File Offset: 0x00021441
		internal void EraseSelectedText()
		{
			this.GetTotalNumberOfDisplayChars();
			if (this.SelectionLength <= 0)
			{
				return;
			}
			this.EraseDisplayChars(this.SelectionStart, this.SelectionLength);
		}

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x060007EC RID: 2028 RVA: 0x00023268 File Offset: 0x00021468
		internal global::Infragistics.Windows.Editors.EditSectionBase FirstEditSection
		{
			get
			{
				global::Infragistics.Windows.Editors.SectionBase firstSection = this.FirstSection;
				if (firstSection == null)
				{
					return null;
				}
				if (firstSection is global::Infragistics.Windows.Editors.EditSectionBase)
				{
					return (global::Infragistics.Windows.Editors.EditSectionBase)firstSection;
				}
				return firstSection.NextEditSection;
			}
		}

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x060007ED RID: 2029 RVA: 0x00023298 File Offset: 0x00021498
		internal global::Infragistics.Windows.Editors.EditSectionBase LastEditSection
		{
			get
			{
				global::Infragistics.Windows.Editors.SectionBase lastSection = this.LastSection;
				if (lastSection == null)
				{
					return null;
				}
				if (lastSection is global::Infragistics.Windows.Editors.EditSectionBase)
				{
					return (global::Infragistics.Windows.Editors.EditSectionBase)lastSection;
				}
				return lastSection.PreviousEditSection;
			}
		}

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x060007EE RID: 2030 RVA: 0x000232C6 File Offset: 0x000214C6
		internal global::Infragistics.Windows.Editors.SectionBase FirstSection
		{
			get
			{
				if (this.Sections == null || this.Sections.Count <= 0)
				{
					return null;
				}
				return this.Sections[0];
			}
		}

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x060007EF RID: 2031 RVA: 0x000232EC File Offset: 0x000214EC
		internal global::Infragistics.Windows.Editors.SectionBase LastSection
		{
			get
			{
				return global::Infragistics.Windows.Editors.EditInfo.GetLastSection(this.Sections);
			}
		}

		// Token: 0x060007F0 RID: 2032 RVA: 0x000232F9 File Offset: 0x000214F9
		internal static global::Infragistics.Windows.Editors.SectionBase GetLastSection(global::Infragistics.Windows.Editors.SectionsCollection sections)
		{
			if (sections == null || sections.Count <= 0)
			{
				return null;
			}
			return sections[sections.Count - 1];
		}

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x060007F1 RID: 2033 RVA: 0x00023318 File Offset: 0x00021518
		internal global::Infragistics.Windows.Editors.InputCharBase FirstFilledDisplayChar
		{
			get
			{
				int i = 0;
				int totalNumberOfDisplayChars = this.GetTotalNumberOfDisplayChars();
				while (i < totalNumberOfDisplayChars)
				{
					global::Infragistics.Windows.Editors.InputCharBase inputCharBase = this.GetDisplayCharAtPosition(i) as global::Infragistics.Windows.Editors.InputCharBase;
					if (inputCharBase != null && inputCharBase.IsEditable && !inputCharBase.IsEmpty)
					{
						return inputCharBase;
					}
					i++;
				}
				return null;
			}
		}

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x060007F2 RID: 2034 RVA: 0x0002335C File Offset: 0x0002155C
		internal global::Infragistics.Windows.Editors.InputCharBase LastFilledDisplayChar
		{
			get
			{
				for (int i = this.GetTotalNumberOfDisplayChars() - 1; i >= 0; i--)
				{
					global::Infragistics.Windows.Editors.InputCharBase inputCharBase = this.GetDisplayCharAtPosition(i) as global::Infragistics.Windows.Editors.InputCharBase;
					if (inputCharBase != null && inputCharBase.IsEditable && !inputCharBase.IsEmpty)
					{
						return inputCharBase;
					}
				}
				return null;
			}
		}

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x060007F3 RID: 2035 RVA: 0x0002339F File Offset: 0x0002159F
		internal global::Infragistics.Windows.Editors.DisplayCharBase LastDisplayChar
		{
			get
			{
				if (this.LastSection == null)
				{
					return null;
				}
				return this.LastSection.LastDisplayChar;
			}
		}

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x060007F4 RID: 2036 RVA: 0x000233B8 File Offset: 0x000215B8
		internal global::Infragistics.Windows.Editors.SectionBase CurrentSection
		{
			get
			{
				global::Infragistics.Windows.Editors.DisplayCharBase currentDisplayChar = this.GetCurrentDisplayChar();
				if (currentDisplayChar == null)
				{
					return null;
				}
				return currentDisplayChar.Section;
			}
		}

		// Token: 0x060007F5 RID: 2037 RVA: 0x000233D8 File Offset: 0x000215D8
		internal global::Infragistics.Windows.Editors.DisplayCharBase GetCurrentDisplayChar()
		{
			global::Infragistics.Windows.Editors.DisplayCharBase result = null;
			int totalNumberOfDisplayChars = this.GetTotalNumberOfDisplayChars();
			if (this.CaretPosition >= 0 && this.CaretPosition < totalNumberOfDisplayChars)
			{
				result = this.GetDisplayCharAtPosition(this.CaretPosition);
			}
			return result;
		}

		// Token: 0x060007F6 RID: 2038 RVA: 0x0002340E File Offset: 0x0002160E
		internal void ToggleInsertMode()
		{
			this.InsertMode = !this.InsertMode;
		}

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x060007F7 RID: 2039 RVA: 0x00023420 File Offset: 0x00021620
		// (set) Token: 0x060007F8 RID: 2040 RVA: 0x00023440 File Offset: 0x00021640
		internal bool InsertMode
		{
			get
			{
				global::Infragistics.Windows.Editors.XamMaskedEditor maskedEditor = this.MaskedEditor;
				return maskedEditor == null || maskedEditor.InsertMode;
			}
			set
			{
				if (value != this.InsertMode)
				{
					global::Infragistics.Windows.Editors.XamMaskedEditor maskedEditor = this.MaskedEditor;
					if (maskedEditor != null)
					{
						maskedEditor.InsertMode = value;
					}
					if (!this.InsertMode && this.IsAfterLastCharacter)
					{
						this.CaretPosition = this.GetTotalNumberOfDisplayChars() - 1;
					}
					if (maskedEditor != null)
					{
						maskedEditor.ResetCaretBlinking();
					}
					this.DirtyMaskElement();
				}
			}
		}

		// Token: 0x060007F9 RID: 2041 RVA: 0x00023494 File Offset: 0x00021694
		internal bool IsRightToLeft(global::Infragistics.Windows.Editors.SectionBase section)
		{
			global::Infragistics.Windows.Editors.EditSectionBase editSectionBase = section as global::Infragistics.Windows.Editors.EditSectionBase;
			return editSectionBase != null && global::Infragistics.Windows.Editors.EditOrientation.RightToLeft == editSectionBase.Orientation;
		}

		// Token: 0x060007FA RID: 2042 RVA: 0x000234B8 File Offset: 0x000216B8
		private bool CanInsertAt(char c, int pos)
		{
			global::Infragistics.Windows.Editors.DisplayCharBase displayCharAtPosition = this.GetDisplayCharAtPosition(pos);
			if (displayCharAtPosition == null)
			{
				return false;
			}
			if (!displayCharAtPosition.IsEditable)
			{
				return false;
			}
			global::Infragistics.Windows.Editors.SectionBase section = displayCharAtPosition.Section;
			global::Infragistics.Windows.Editors.EditSectionBase editSectionBase = section as global::Infragistics.Windows.Editors.EditSectionBase;
			return editSectionBase != null && editSectionBase.CanInsertCharAt(displayCharAtPosition.Index, c);
		}

		// Token: 0x060007FB RID: 2043 RVA: 0x000234FC File Offset: 0x000216FC
		internal void ScrollAllTheWayRightHelper()
		{
			this.ScrollDisplayCharIntoView(this.GetTotalNumberOfDisplayChars());
		}

		// Token: 0x060007FC RID: 2044 RVA: 0x0002350A File Offset: 0x0002170A
		internal void ScrollCaretIntoView()
		{
			this.ScrollDisplayCharIntoView(this.CaretPosition);
		}

		// Token: 0x060007FD RID: 2045 RVA: 0x00023518 File Offset: 0x00021718
		private void EnsureNumberSectionState()
		{
			if (!this.InsertMode)
			{
				return;
			}
			global::Infragistics.Windows.Editors.DisplayCharBase displayCharBase = this.GetDisplayCharAtPosition(this.CaretPosition);
			global::Infragistics.Windows.Editors.DisplayCharBase displayCharAtPosition = this.GetDisplayCharAtPosition(this.CaretPosition - 1);
			if (displayCharBase != null && displayCharAtPosition != null && displayCharAtPosition.Section != displayCharBase.Section && this.IsRightToLeft(displayCharAtPosition.Section))
			{
				if (!(displayCharAtPosition.Section.NextEditSection is global::Infragistics.Windows.Editors.FractionPartContinuous))
				{
					return;
				}
				displayCharBase = displayCharAtPosition;
			}
			if (displayCharBase == null)
			{
				displayCharBase = displayCharAtPosition;
			}
			if (displayCharBase != null && this.IsRightToLeft(displayCharBase.Section) && displayCharBase.IsEmpty)
			{
				global::Infragistics.Windows.Editors.EditSectionBase editSectionBase = (global::Infragistics.Windows.Editors.EditSectionBase)displayCharBase.Section;
				if (editSectionBase.IsEmpty && editSectionBase.NextEditSection is global::Infragistics.Windows.Editors.FractionPartContinuous)
				{
					global::Infragistics.Windows.Editors.FractionPartContinuous fractionPartContinuous = (global::Infragistics.Windows.Editors.FractionPartContinuous)editSectionBase.NextEditSection;
					if (fractionPartContinuous.FirstDisplayChar.IsEmpty)
					{
						editSectionBase = fractionPartContinuous;
					}
				}
				int num = (editSectionBase.FirstFilledChar != null) ? editSectionBase.FirstFilledChar.OverallIndexInEdit : (1 + editSectionBase.LastDisplayChar.OverallIndexInEdit);
				if (this.CaretPosition != num)
				{
					this.ScrollAllTheWayRightHelper();
				}
				this.SetCaretPivot(num);
				return;
			}
			if (displayCharBase != null && displayCharBase.Section is global::Infragistics.Windows.Editors.FractionPart && displayCharBase.IsEmpty)
			{
				global::Infragistics.Windows.Editors.EditSectionBase editSectionBase2 = (global::Infragistics.Windows.Editors.EditSectionBase)displayCharBase.Section;
				int num2 = (editSectionBase2.LastFilledChar != null) ? (1 + editSectionBase2.LastFilledChar.OverallIndexInEdit) : editSectionBase2.FirstDisplayChar.OverallIndexInEdit;
				if (displayCharBase.OverallIndexInEdit > num2)
				{
					this.SetCaretPivot(num2);
				}
			}
			if (displayCharBase != null && displayCharBase.Section is global::Infragistics.Windows.Editors.FractionPartContinuous)
			{
				global::Infragistics.Windows.Editors.FractionPartContinuous fractionPartContinuous2 = (global::Infragistics.Windows.Editors.FractionPartContinuous)displayCharBase.Section;
				if (displayCharBase.Index == 0 && !displayCharBase.IsEmpty && this.IsRightToLeft(fractionPartContinuous2.PreviousEditSection) && displayCharBase.OverallIndexInEdit >= this.CaretPosition)
				{
					this.SetCaretPivot(1 + fractionPartContinuous2.PreviousEditSection.LastDisplayChar.OverallIndexInEdit);
				}
			}
		}

		// Token: 0x060007FE RID: 2046 RVA: 0x000236E4 File Offset: 0x000218E4
		internal string NormalizeEncodingHelper(string text)
		{
			if (text != null)
			{
				bool flag = true;
				global::Infragistics.Windows.Editors.MaskInfo maskInfo = this.MaskInfo;
				if (maskInfo != null && !global::Infragistics.Windows.Editors.Utils.IsNumericType(maskInfo.DataType) && typeof(global::System.DateTime) != maskInfo.DataType && global::Infragistics.Windows.Editors.XamMaskedEditor.GetSection(maskInfo.Sections, typeof(global::Infragistics.Windows.Editors.NumberSection)) == null)
				{
					flag = false;
				}
				if (flag)
				{
					text = text.Normalize(global::System.Text.NormalizationForm.FormKC);
				}
			}
			return text;
		}

		// Token: 0x060007FF RID: 2047 RVA: 0x0002374C File Offset: 0x0002194C
		internal void ProcessTextInput(global::System.Windows.Input.TextCompositionEventArgs e, bool normalizeEncoding)
		{
			if (this.ReadOnly)
			{
				return;
			}
			this._lastIllegalChar = '\0';
			int num = 0;
			string text = e.Text;
			if (normalizeEncoding)
			{
				text = this.NormalizeEncodingHelper(text);
			}
			foreach (char c in text)
			{
				this.InternalProcessChar(c);
				if (this._lastIllegalChar != '\0')
				{
					break;
				}
				num++;
			}
			if (num > 0)
			{
				this.OnTextChanged(true);
			}
			e.Handled = true;
		}

		// Token: 0x06000800 RID: 2048 RVA: 0x000237C4 File Offset: 0x000219C4
		internal int GetInputPositionInSelection(char c)
		{
			global::Infragistics.Windows.Editors.DisplayCharBase displayCharAtPosition = this.GetDisplayCharAtPosition(this.SelectionStart);
			global::Infragistics.Windows.Editors.DisplayCharBase displayCharAtPosition2 = this.GetDisplayCharAtPosition(this.SelectionStart + this.SelectionLength - 1);
			global::Infragistics.Windows.Editors.DisplayCharBase nextEditableDisplayChar = displayCharAtPosition.NextEditableDisplayChar;
			if (!displayCharAtPosition.IsEditable && displayCharAtPosition.Section != displayCharAtPosition2.Section && nextEditableDisplayChar != null && nextEditableDisplayChar.OverallIndexInEdit <= displayCharAtPosition2.OverallIndexInEdit)
			{
				return nextEditableDisplayChar.OverallIndexInEdit;
			}
			return -1;
		}

		// Token: 0x06000801 RID: 2049 RVA: 0x0002382C File Offset: 0x00021A2C
		internal void InternalProcessChar(char c)
		{
			if (this._skipNextDecimalKeyPress && '.' == c)
			{
				this._skipNextDecimalKeyPress = false;
				return;
			}
			if (!this.IsInitialized || this.MaskedEditor.DesignMode)
			{
				return;
			}
			global::Infragistics.Windows.Editors.SectionBase sectionBase = (this.CurrentSection == null) ? this.LastEditSection : this.CurrentSection;
			if (sectionBase != null && (sectionBase.IsDateTimeSeperatorSection || sectionBase.IsDateSection || sectionBase.IsTimeSection))
			{
				string text = "-/.,:";
				if (-1 < text.IndexOf(c))
				{
					global::Infragistics.Windows.Editors.SectionBase sectionBase2 = sectionBase.NextEditSection;
					if (sectionBase2 == null)
					{
						sectionBase2 = this.FirstEditSection;
					}
					if (sectionBase2 != null)
					{
						this.PivotPosition = sectionBase2.FirstDisplayChar.OverallIndexInEdit;
						this.CaretPosition = sectionBase2.LastDisplayChar.OverallIndexInEdit + 1;
					}
					return;
				}
			}
			if (this.MaskInfo.DecimalSeperatorChar == c)
			{
				global::Infragistics.Windows.Editors.DisplayCharBase displayCharAtPosition = this.GetDisplayCharAtPosition(this.SelectionStart);
				if (displayCharAtPosition != null && !displayCharAtPosition.MatchChar(c))
				{
					global::Infragistics.Windows.Editors.SectionBase sectionBase3 = displayCharAtPosition.Section;
					while (sectionBase3 != null && !(sectionBase3.LastDisplayChar is global::Infragistics.Windows.Editors.DecimalSeperatorChar))
					{
						sectionBase3 = sectionBase3.NextSection;
					}
					if (sectionBase3 != null && sectionBase3.LastDisplayChar is global::Infragistics.Windows.Editors.DecimalSeperatorChar)
					{
						if (this.IsAnyTextSelected)
						{
							this.Delete();
						}
						this.SetCaretPivot(1 + sectionBase3.LastDisplayChar.OverallIndexInEdit);
						this.DirtyMaskElement();
						return;
					}
				}
			}
			bool flag = false;
			if (this.IsAnyTextSelected)
			{
				global::Infragistics.Windows.Editors.DisplayCharBase displayCharAtPosition2 = this.GetDisplayCharAtPosition(this.SelectionStart);
				if (char.IsDigit(c) && this.FirstEditSection is global::Infragistics.Windows.Editors.NumberSection && this.SelectionStart == 0)
				{
					this.Delete();
				}
				else
				{
					global::Infragistics.Windows.Editors.NumberSection numberSection = displayCharAtPosition2.Section as global::Infragistics.Windows.Editors.NumberSection;
					global::Infragistics.Windows.Editors.DisplayCharBase displayCharBase = (numberSection != null) ? numberSection.FirstFilledChar : null;
					bool flag2 = (numberSection != null && (c == numberSection.PlusSignChar || c == numberSection.MinusSignChar) && numberSection.FirstFilledChar == displayCharAtPosition2) || (char.IsDigit(c) && displayCharBase != null && this.IsDisplayCharSelected(displayCharBase));
					if (displayCharAtPosition2 != null && displayCharAtPosition2.IsEditable && !displayCharAtPosition2.MatchChar(c) && !flag2)
					{
						this.IllegalCharPressed(displayCharAtPosition2, c);
						return;
					}
					int inputPositionInSelection = this.GetInputPositionInSelection(c);
					if (!this.InsertMode && displayCharAtPosition2 != null && displayCharAtPosition2.Section is global::Infragistics.Windows.Editors.NumberSection)
					{
						flag = true;
					}
					this.Delete();
					if (inputPositionInSelection >= 0)
					{
						this.SetCaretPivot(inputPositionInSelection);
					}
				}
			}
			this.EnsureNumberSectionState();
			global::Infragistics.Windows.Editors.DisplayCharBase displayCharBase2 = this.GetCurrentDisplayChar();
			if (!this.InsertMode && displayCharBase2 != null && !displayCharBase2.IsEditable)
			{
				if (displayCharBase2.MatchChar(c))
				{
					if (displayCharBase2.NextDisplayChar != null)
					{
						displayCharBase2 = displayCharBase2.NextDisplayChar;
						this.SetCaretPivot(displayCharBase2.OverallIndexInEdit);
						return;
					}
				}
				else if (displayCharBase2.NextEditableDisplayChar != null)
				{
					displayCharBase2 = displayCharBase2.NextEditableDisplayChar;
					this.SetCaretPivot(displayCharBase2.OverallIndexInEdit);
				}
			}
			if (displayCharBase2 != null)
			{
				global::Infragistics.Windows.Editors.NumberSection numberSection2 = displayCharBase2.Section as global::Infragistics.Windows.Editors.NumberSection;
				if (numberSection2 == null && displayCharBase2 is global::Infragistics.Windows.Editors.DecimalSeperatorChar)
				{
					numberSection2 = ((displayCharBase2.PrevDisplayChar != null) ? (displayCharBase2.PrevDisplayChar.Section as global::Infragistics.Windows.Editors.NumberSection) : null);
				}
				if (numberSection2 == null && displayCharBase2.Section is global::Infragistics.Windows.Editors.FractionPart)
				{
					numberSection2 = (displayCharBase2.Section.PreviousEditSection as global::Infragistics.Windows.Editors.NumberSection);
				}
				if (displayCharBase2 != null && displayCharBase2.PrevDisplayChar != null && displayCharBase2.PrevDisplayChar.Section is global::Infragistics.Windows.Editors.NumberSection)
				{
					numberSection2 = (displayCharBase2.PrevDisplayChar.Section as global::Infragistics.Windows.Editors.NumberSection);
				}
				if (numberSection2 != null && (numberSection2.MinValue < 0m || numberSection2.lastConvertedMinValWithFractionPart < 0m))
				{
					if (numberSection2.PlusSignChar == c)
					{
						if (!numberSection2.SetNumberSign(false))
						{
							this.IllegalCharPressed(displayCharBase2, c);
						}
						this.DirtyMaskElement();
						return;
					}
					if (numberSection2.MinusSignChar == c)
					{
						if (!numberSection2.SetNumberSign(true))
						{
							this.IllegalCharPressed(displayCharBase2, c);
						}
						this.DirtyMaskElement();
						return;
					}
				}
				if (displayCharBase2.IsEditable)
				{
					if (this.InsertMode)
					{
						global::Infragistics.Windows.Editors.EditSectionBase editSectionBase = displayCharBase2.Section as global::Infragistics.Windows.Editors.EditSectionBase;
						if (this.IsRightToLeft(editSectionBase))
						{
							if (displayCharBase2.Index - 1 >= 0 && editSectionBase.InsertCharAt(displayCharBase2.Index - 1, c))
							{
								this.DirtyMaskElement();
							}
							else
							{
								global::Infragistics.Windows.Editors.DisplayCharBase displayCharBase3 = null;
								if (editSectionBase.NextLiteralSection != null)
								{
									displayCharBase3 = editSectionBase.NextLiteralSection.FirstDisplayChar;
								}
								if (displayCharBase3 == null)
								{
									this.IllegalCharPressed(displayCharBase2, c);
								}
								else if (displayCharBase3.MatchChar(c))
								{
									global::Infragistics.Windows.Editors.DisplayCharBase displayCharAtPosition3 = this.GetDisplayCharAtPosition(1 + displayCharBase3.OverallIndexInEdit);
									if (displayCharAtPosition3 != null && displayCharAtPosition3.IsEditable)
									{
										global::Infragistics.Windows.Editors.EditSectionBase editSectionBase2 = displayCharAtPosition3.Section as global::Infragistics.Windows.Editors.EditSectionBase;
										if (editSectionBase2 != null)
										{
											this.GotoSection(editSectionBase2, false);
											this.SetPivot();
										}
									}
									else if (displayCharAtPosition3 != null)
									{
										this.SetCaretPivot(displayCharAtPosition3.OverallIndexInEdit);
									}
									else
									{
										this.IllegalCharPressed(displayCharBase2, c);
									}
								}
								else if (displayCharBase2 == editSectionBase.LastDisplayChar)
								{
									global::Infragistics.Windows.Editors.EditSectionBase nextEditSection = editSectionBase.NextEditSection;
									if (nextEditSection != null)
									{
										if (this.IsRightToLeft(nextEditSection))
										{
											int pos;
											if (nextEditSection.FirstFilledChar != null)
											{
												pos = nextEditSection.FirstFilledChar.OverallIndexInEdit - 1;
											}
											else
											{
												pos = nextEditSection.LastDisplayChar.OverallIndexInEdit;
											}
											if (this.CanInsertAt(c, pos))
											{
												this.GotoSection(nextEditSection);
												this.SetPivot();
												this.InternalProcessChar(c);
											}
											else
											{
												this.IllegalCharPressed(displayCharBase2, c);
											}
										}
										else
										{
											int overallIndexInEdit = nextEditSection.FirstDisplayChar.OverallIndexInEdit;
											if (this.CanInsertAt(c, overallIndexInEdit))
											{
												this.GotoSection(nextEditSection);
												this.SetPivot();
												this.InternalProcessChar(c);
											}
											else
											{
												this.IllegalCharPressed(displayCharBase2, c);
											}
										}
									}
									else
									{
										this.IllegalCharPressed(displayCharBase2, c);
									}
								}
								else
								{
									this.IllegalCharPressed(displayCharBase2, c);
								}
							}
						}
						else if (editSectionBase != null && editSectionBase.InsertCharAt(displayCharBase2.Index, c))
						{
							this.CaretPosition++;
							this.SetPivot();
							this.DirtyMaskElement();
						}
						else if (this.InsertCharAtShiftGlobal(c, displayCharBase2.OverallIndexInEdit))
						{
							this.CaretPosition++;
							this.SetPivot();
							this.DirtyMaskElement();
						}
						else
						{
							bool flag3 = false;
							global::Infragistics.Windows.Editors.SectionBase section = displayCharBase2.Section;
							if (section.NextLiteralSection != null && section.NextLiteralSection.FirstDisplayChar.MatchChar(c))
							{
								this.CaretPosition = 1 + section.NextLiteralSection.FirstDisplayChar.OverallIndexInEdit;
								this.SetPivot();
								flag3 = true;
							}
							if (!flag3)
							{
								this.IllegalCharPressed(displayCharBase2, c);
							}
						}
					}
					else
					{
						global::Infragistics.Windows.Editors.EditSectionBase editSectionBase3 = displayCharBase2.Section as global::Infragistics.Windows.Editors.EditSectionBase;
						if (editSectionBase3 != null && global::Infragistics.Windows.Editors.EditOrientation.RightToLeft == editSectionBase3.Orientation)
						{
							if (flag ? editSectionBase3.InsertCharAt(displayCharBase2.Index, c) : editSectionBase3.ReplaceCharAt(displayCharBase2.Index, c))
							{
								if (global::Infragistics.Windows.Editors.XamMaskedEditor.IsSectionNumeric(editSectionBase3))
								{
									this.CaretPosition++;
									this.SetPivot();
								}
								this.DirtyMaskElement();
							}
							else
							{
								bool flag4 = false;
								global::Infragistics.Windows.Editors.SectionBase section2 = displayCharBase2.Section;
								if (section2.NextLiteralSection != null && section2.NextLiteralSection.FirstDisplayChar.MatchChar(c))
								{
									this.CaretPosition = 1 + section2.NextLiteralSection.FirstDisplayChar.OverallIndexInEdit;
									this.SetPivot();
									flag4 = true;
								}
								if (!flag4)
								{
									this.IllegalCharPressed(displayCharBase2, c);
								}
							}
						}
						else if (editSectionBase3 != null && editSectionBase3.ReplaceCharAt(displayCharBase2.Index, c))
						{
							this.CaretPosition++;
							this.SetPivot();
							this.DirtyMaskElement();
						}
						else
						{
							bool flag5 = false;
							global::Infragistics.Windows.Editors.SectionBase section3 = displayCharBase2.Section;
							if (section3.NextLiteralSection != null && section3.NextLiteralSection.FirstDisplayChar.MatchChar(c))
							{
								this.CaretPosition = 1 + section3.NextLiteralSection.FirstDisplayChar.OverallIndexInEdit;
								this.SetPivot();
								flag5 = true;
							}
							if (!flag5)
							{
								this.IllegalCharPressed(displayCharBase2, c);
							}
						}
					}
				}
				else if (displayCharBase2.MatchChar(c))
				{
					global::Infragistics.Windows.Editors.DisplayCharBase displayCharAtPosition4 = this.GetDisplayCharAtPosition(this.CaretPosition + 1);
					if (displayCharAtPosition4 != null && displayCharAtPosition4.Section != displayCharBase2.Section)
					{
						this.GotoSection(displayCharAtPosition4.Section);
					}
					else
					{
						this.CaretPosition++;
						this.SetPivot();
					}
				}
				else
				{
					global::Infragistics.Windows.Editors.DisplayCharBase displayCharAtPosition5 = this.GetDisplayCharAtPosition(displayCharBase2.OverallIndexInEdit - 1);
					if (displayCharAtPosition5 != null && displayCharAtPosition5.Section != displayCharBase2.Section)
					{
						global::Infragistics.Windows.Editors.EditSectionBase editSectionBase4 = displayCharAtPosition5.Section as global::Infragistics.Windows.Editors.EditSectionBase;
						if (this.IsRightToLeft(editSectionBase4))
						{
							global::Infragistics.Windows.Editors.DisplayCharBase lastDisplayChar = editSectionBase4.LastDisplayChar;
							if (this.CanInsertAt(c, lastDisplayChar.OverallIndexInEdit))
							{
								if (editSectionBase4.InsertCharAt(lastDisplayChar.Index, c))
								{
									this.DirtyMaskElement();
								}
								else if (lastDisplayChar == editSectionBase4.LastDisplayChar)
								{
									global::Infragistics.Windows.Editors.EditSectionBase nextEditSection2 = editSectionBase4.NextEditSection;
									if (nextEditSection2 != null)
									{
										if (this.IsRightToLeft(nextEditSection2))
										{
											int pos2;
											if (nextEditSection2.FirstFilledChar != null)
											{
												pos2 = nextEditSection2.FirstFilledChar.OverallIndexInEdit - 1;
											}
											else
											{
												pos2 = nextEditSection2.LastDisplayChar.OverallIndexInEdit;
											}
											if (this.CanInsertAt(c, pos2))
											{
												this.GotoSection(nextEditSection2);
												this.SetPivot();
												this.InternalProcessChar(c);
											}
											else
											{
												this.IllegalCharPressed(displayCharBase2, c);
											}
										}
										else
										{
											int overallIndexInEdit2 = nextEditSection2.FirstDisplayChar.OverallIndexInEdit;
											if (this.CanInsertAt(c, overallIndexInEdit2))
											{
												this.GotoSection(nextEditSection2);
												this.SetPivot();
												this.InternalProcessChar(c);
											}
											else
											{
												this.IllegalCharPressed(displayCharBase2, c);
											}
										}
									}
									else
									{
										this.IllegalCharPressed(displayCharBase2, c);
									}
								}
								else
								{
									this.IllegalCharPressed(displayCharBase2, c);
								}
							}
							else
							{
								global::Infragistics.Windows.Editors.EditSectionBase nextEditSection3 = displayCharBase2.Section.NextEditSection;
								if (nextEditSection3 != null)
								{
									if (this.IsRightToLeft(nextEditSection3))
									{
										int pos3;
										if (nextEditSection3.FirstFilledChar != null)
										{
											pos3 = nextEditSection3.FirstFilledChar.OverallIndexInEdit - 1;
										}
										else
										{
											pos3 = nextEditSection3.LastDisplayChar.OverallIndexInEdit;
										}
										if (this.CanInsertAt(c, pos3))
										{
											this.GotoSection(nextEditSection3);
											this.SetPivot();
											this.InternalProcessChar(c);
										}
										else
										{
											this.IllegalCharPressed(displayCharBase2, c);
										}
									}
									else
									{
										int overallIndexInEdit3 = nextEditSection3.FirstDisplayChar.OverallIndexInEdit;
										if (this.CanInsertAt(c, overallIndexInEdit3))
										{
											this.GotoSection(nextEditSection3);
											this.SetPivot();
											this.InternalProcessChar(c);
										}
										else
										{
											this.IllegalCharPressed(displayCharBase2, c);
										}
									}
								}
								else
								{
									this.IllegalCharPressed(displayCharBase2, c);
								}
							}
						}
						else
						{
							global::Infragistics.Windows.Editors.EditSectionBase nextEditSection4 = displayCharBase2.Section.NextEditSection;
							if (nextEditSection4 != null)
							{
								if (this.IsRightToLeft(nextEditSection4))
								{
									int pos4;
									if (nextEditSection4.FirstFilledChar != null)
									{
										pos4 = nextEditSection4.FirstFilledChar.OverallIndexInEdit - 1;
									}
									else
									{
										pos4 = nextEditSection4.LastDisplayChar.OverallIndexInEdit;
									}
									if (this.CanInsertAt(c, pos4))
									{
										this.GotoSection(nextEditSection4);
										this.SetPivot();
										this.InternalProcessChar(c);
									}
									else
									{
										this.IllegalCharPressed(displayCharBase2, c);
									}
								}
								else
								{
									int overallIndexInEdit4 = nextEditSection4.FirstDisplayChar.OverallIndexInEdit;
									global::Infragistics.Windows.Editors.DisplayCharBase displayCharAtPosition6 = this.GetDisplayCharAtPosition(overallIndexInEdit4);
									if (this.CanInsertAt(c, overallIndexInEdit4))
									{
										this.GotoSection(nextEditSection4);
										this.SetPivot();
										this.InternalProcessChar(c);
									}
									else if (!this.InsertMode && displayCharAtPosition6.MatchChar(c))
									{
										this.SetCaretPivot(overallIndexInEdit4);
										this.InternalProcessChar(c);
									}
									else if (this.InsertCharAtShiftGlobal(c, overallIndexInEdit4))
									{
										this.CaretPosition = 1 + overallIndexInEdit4;
										this.SetPivot();
										this.DirtyMaskElement();
									}
									else
									{
										this.IllegalCharPressed(displayCharBase2, c);
									}
								}
							}
							else
							{
								this.IllegalCharPressed(displayCharBase2, c);
							}
						}
					}
					else
					{
						global::Infragistics.Windows.Editors.EditSectionBase nextEditSection5 = displayCharBase2.Section.NextEditSection;
						if (nextEditSection5 != null)
						{
							if (this.IsRightToLeft(nextEditSection5))
							{
								int pos5;
								if (nextEditSection5.FirstFilledChar != null)
								{
									pos5 = nextEditSection5.FirstFilledChar.OverallIndexInEdit - 1;
								}
								else
								{
									pos5 = nextEditSection5.LastDisplayChar.OverallIndexInEdit;
								}
								if (this.CanInsertAt(c, pos5))
								{
									this.GotoSection(nextEditSection5);
									this.SetPivot();
									this.InternalProcessChar(c);
								}
								else
								{
									this.IllegalCharPressed(displayCharBase2, c);
								}
							}
							else
							{
								int overallIndexInEdit5 = nextEditSection5.FirstDisplayChar.OverallIndexInEdit;
								global::Infragistics.Windows.Editors.DisplayCharBase displayCharAtPosition7 = this.GetDisplayCharAtPosition(overallIndexInEdit5);
								if (this.CanInsertAt(c, overallIndexInEdit5))
								{
									this.GotoSection(nextEditSection5);
									this.SetPivot();
									this.InternalProcessChar(c);
								}
								else if (!this.InsertMode && displayCharAtPosition7.MatchChar(c))
								{
									this.SetCaretPivot(overallIndexInEdit5);
									this.InternalProcessChar(c);
								}
								else if (this.InsertCharAtShiftGlobal(c, overallIndexInEdit5))
								{
									this.SetCaretPivot(1 + overallIndexInEdit5);
									this.DirtyMaskElement();
								}
								else
								{
									this.IllegalCharPressed(displayCharBase2, c);
								}
							}
						}
						else
						{
							this.IllegalCharPressed(displayCharBase2, c);
						}
					}
				}
			}
			else
			{
				global::Infragistics.Windows.Editors.DisplayCharBase displayCharAtPosition8 = this.GetDisplayCharAtPosition(this.CaretPosition - 1);
				global::Infragistics.Windows.Editors.EditSectionBase editSectionBase5 = (displayCharAtPosition8 != null) ? (displayCharAtPosition8.Section as global::Infragistics.Windows.Editors.EditSectionBase) : null;
				bool flag6 = false;
				global::Infragistics.Windows.Editors.NumberSection numberSection3 = null;
				if (editSectionBase5 is global::Infragistics.Windows.Editors.NumberSection)
				{
					numberSection3 = (global::Infragistics.Windows.Editors.NumberSection)editSectionBase5;
				}
				else if (editSectionBase5 is global::Infragistics.Windows.Editors.FractionPart)
				{
					numberSection3 = (editSectionBase5.PreviousEditSection as global::Infragistics.Windows.Editors.NumberSection);
				}
				if (numberSection3 != null && numberSection3 != null && (numberSection3.MinValue < 0m || numberSection3.lastConvertedMinValWithFractionPart < 0m))
				{
					if (numberSection3.PlusSignChar == c)
					{
						if (!numberSection3.SetNumberSign(false))
						{
							this.IllegalCharPressed(displayCharBase2, c);
						}
						this.DirtyMaskElement();
						flag6 = true;
					}
					else if (numberSection3.MinusSignChar == c)
					{
						if (!numberSection3.SetNumberSign(true))
						{
							this.IllegalCharPressed(displayCharBase2, c);
						}
						this.DirtyMaskElement();
						flag6 = true;
					}
				}
				if (!flag6)
				{
					if (editSectionBase5 != null && this.IsRightToLeft(editSectionBase5))
					{
						global::Infragistics.Windows.Editors.DisplayCharBase lastDisplayChar2 = editSectionBase5.LastDisplayChar;
						if (this.CanInsertAt(c, lastDisplayChar2.OverallIndexInEdit))
						{
							if (editSectionBase5.InsertCharAt(lastDisplayChar2.Index, c))
							{
								this.DirtyMaskElement();
							}
							else
							{
								this.IllegalCharPressed(lastDisplayChar2, c);
							}
						}
						else
						{
							this.IllegalCharPressed(null, c);
						}
					}
					else
					{
						this.IllegalCharPressed(null, c);
					}
				}
			}
			this.SetPivot();
			this.ScrollCaretIntoView();
		}

		// Token: 0x06000802 RID: 2050 RVA: 0x000245F4 File Offset: 0x000227F4
		internal int GetNearestDisplayChar(global::System.Windows.Point point, bool dragging)
		{
			double x = point.X;
			if (!this.IsInitialized)
			{
				return 0;
			}
			int totalNumberOfDisplayChars = this.GetTotalNumberOfDisplayChars();
			global::System.Windows.Rect rect = global::System.Windows.Rect.Empty;
			int num = -1;
			for (int i = 0; i < totalNumberOfDisplayChars; i++)
			{
				global::Infragistics.Windows.Editors.DisplayCharBase displayCharBase = this.GetDisplayCharAtPosition(i);
				if (displayCharBase != null)
				{
					global::System.Windows.Rect displayCharLocation = this.MaskedEditor.GetDisplayCharLocation(displayCharBase);
					if (!displayCharLocation.IsEmpty && !global::Infragistics.Windows.Utilities.DoubleIsZero(displayCharLocation.Width) && global::System.Windows.Visibility.Collapsed != displayCharBase.Visibility)
					{
						rect = displayCharLocation;
						num = i;
						if (x <= displayCharLocation.X + displayCharLocation.Width / 2.0)
						{
							return i;
						}
					}
				}
			}
			if (!dragging && (num < 0 || rect.IsEmpty || point.X - rect.Right > 15.0))
			{
				totalNumberOfDisplayChars = this.GetTotalNumberOfDisplayChars();
				global::Infragistics.Windows.Editors.DisplayCharBase displayCharBase2 = null;
				for (int j = 0; j < totalNumberOfDisplayChars; j++)
				{
					global::Infragistics.Windows.Editors.DisplayCharBase displayCharBase = this.GetDisplayCharAtPosition(j);
					if (displayCharBase != null && displayCharBase.IsEditable && !displayCharBase.IsEmpty)
					{
						displayCharBase2 = displayCharBase;
					}
				}
				int val = 0;
				if (displayCharBase2 != null)
				{
					global::Infragistics.Windows.Editors.DisplayCharBase displayCharBase = displayCharBase2.NextEditableDisplayChar;
					if (displayCharBase != null && displayCharBase.OverallIndexInEdit >= 0)
					{
						val = displayCharBase.OverallIndexInEdit;
					}
					else
					{
						val = ((num >= 0) ? (1 + num) : totalNumberOfDisplayChars);
					}
				}
				else if (this.FirstEditSection != null)
				{
					global::Infragistics.Windows.Editors.DisplayCharBase displayCharBase = this.FirstEditSection.FirstDisplayChar;
					if (displayCharBase != null && displayCharBase.OverallIndexInEdit >= 0)
					{
						val = displayCharBase.OverallIndexInEdit;
					}
				}
				return global::System.Math.Max(0, global::System.Math.Min(val, this.GetTotalNumberOfDisplayChars()));
			}
			if (num < 0)
			{
				return this.GetTotalNumberOfDisplayChars();
			}
			return 1 + num;
		}

		// Token: 0x06000803 RID: 2051 RVA: 0x00024780 File Offset: 0x00022980
		internal void MouseDragged(global::System.Windows.Point currentLocation)
		{
			if (!this.IsInitialized || this.MaskedEditor.DesignMode)
			{
				return;
			}
			int num = this.GetNearestDisplayChar(currentLocation, true);
			global::Infragistics.Windows.Editors.DisplayCharBase displayCharAtPosition = this.GetDisplayCharAtPosition(num);
			if (displayCharAtPosition != null)
			{
				num = displayCharAtPosition.OverallIndexInEdit;
				this.CaretPosition = num;
			}
			else
			{
				this.CaretPosition = this.GetTotalNumberOfDisplayChars();
			}
			this.InvalidateMaskElement();
		}

		// Token: 0x06000804 RID: 2052 RVA: 0x000247D9 File Offset: 0x000229D9
		internal void MaskedEditUIElementMouseUp(global::System.Windows.Point point)
		{
			if (!this.IsAnyTextSelected)
			{
				this.EnsureNumberSectionState();
			}
		}

		// Token: 0x06000805 RID: 2053 RVA: 0x000247EC File Offset: 0x000229EC
		internal void MaskedEditUIElementClicked(global::System.Windows.Point point)
		{
			int num = this.GetNearestDisplayChar(point, false);
			global::Infragistics.Windows.Editors.DisplayCharBase displayCharAtPosition = this.GetDisplayCharAtPosition(num);
			global::Infragistics.Windows.Editors.SectionBase sectionBase = this.GetCurrentSection(true);
			if (sectionBase == null)
			{
				sectionBase = this.LastSection;
			}
			if (displayCharAtPosition != null)
			{
				if (this.IsRightToLeft(displayCharAtPosition.Section))
				{
					num = displayCharAtPosition.OverallIndexInEdit;
				}
				else
				{
					num = displayCharAtPosition.OverallIndexInEdit;
				}
				this.SetCaretPivot(num);
			}
			else
			{
				this.SetCaretPivot(this.GetTotalNumberOfDisplayChars());
			}
			this.ScrollDisplayCharIntoView(this.CaretPosition);
			global::Infragistics.Windows.Editors.SectionBase currentSection = this.GetCurrentSection(true);
			if (sectionBase != null && sectionBase != currentSection)
			{
				global::Infragistics.Windows.Editors.EditSectionBase editSectionBase = sectionBase as global::Infragistics.Windows.Editors.EditSectionBase;
				if (editSectionBase != null)
				{
					editSectionBase.ValidateSection();
				}
			}
		}

		// Token: 0x06000806 RID: 2054 RVA: 0x00024881 File Offset: 0x00022A81
		internal void EnsureMaskEditAreaFilled()
		{
		}

		// Token: 0x06000807 RID: 2055 RVA: 0x00024884 File Offset: 0x00022A84
		internal void ScrollDisplayCharIntoView(int index)
		{
			global::Infragistics.Windows.Editors.DisplayCharBase displayCharBase = this.GetDisplayCharAtPosition(index);
			if (displayCharBase == null && index >= this.GetTotalNumberOfDisplayChars())
			{
				displayCharBase = this.LastDisplayChar;
			}
			if (displayCharBase == null)
			{
				return;
			}
			global::Infragistics.Windows.Editors.DisplayCharacterPresenter displayCharacterPresenter = this.MaskedEditor.GetDisplayCharacterPresenter(displayCharBase);
			if (displayCharacterPresenter != null)
			{
				displayCharacterPresenter.BringIntoView();
				this.MaskedEditor.UpdateLayout();
				this.MaskedEditor.InvalidateArrange();
			}
		}

		// Token: 0x06000808 RID: 2056 RVA: 0x000248DC File Offset: 0x00022ADC
		internal global::Infragistics.Windows.Editors.SectionBase GetSectionContainingPosition(int position)
		{
			return global::Infragistics.Windows.Editors.EditInfo.GetSectionContainingPosition(position, this.Sections);
		}

		// Token: 0x06000809 RID: 2057 RVA: 0x000248EC File Offset: 0x00022AEC
		internal static global::Infragistics.Windows.Editors.SectionBase GetSectionContainingPosition(int position, global::Infragistics.Windows.Editors.SectionsCollection sections)
		{
			if (sections == null || sections.Count <= 0)
			{
				return null;
			}
			int num = 0;
			for (int i = 0; i < sections.Count; i++)
			{
				global::Infragistics.Windows.Editors.SectionBase sectionBase = sections[i];
				num += sectionBase.DisplayChars.Count;
				if (position < num)
				{
					return sectionBase;
				}
			}
			return null;
		}

		// Token: 0x0600080A RID: 2058 RVA: 0x00024937 File Offset: 0x00022B37
		internal global::Infragistics.Windows.Editors.DisplayCharBase GetDisplayCharAtPosition(int position)
		{
			return global::Infragistics.Windows.Editors.XamMaskedEditor.GetDisplayCharAtPosition(this.Sections, position);
		}

		// Token: 0x0600080B RID: 2059 RVA: 0x00024945 File Offset: 0x00022B45
		internal int GetTotalNumberOfDisplayChars()
		{
			return global::Infragistics.Windows.Editors.XamMaskedEditor.GetTotalNumberOfDisplayChars(this.Sections);
		}

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x0600080C RID: 2060 RVA: 0x00024952 File Offset: 0x00022B52
		internal bool IsInitialized
		{
			get
			{
				return this.GetTotalNumberOfDisplayChars() > 0;
			}
		}

		// Token: 0x0600080D RID: 2061 RVA: 0x0002495D File Offset: 0x00022B5D
		internal void SetCaretPivot(int pos)
		{
			this.CaretPosition = pos;
			this.PivotPosition = pos;
		}

		// Token: 0x0600080E RID: 2062 RVA: 0x0002496D File Offset: 0x00022B6D
		internal void SyncCaretAndPivotsWithMaskedEditor()
		{
			this.MaskedEditor.CaretPosition = this.CaretPosition;
			this.MaskedEditor.PivotPosition = this.PivotPosition;
		}

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x0600080F RID: 2063 RVA: 0x00024991 File Offset: 0x00022B91
		// (set) Token: 0x06000810 RID: 2064 RVA: 0x0002499C File Offset: 0x00022B9C
		internal int CaretPosition
		{
			get
			{
				return this._caretPosition;
			}
			set
			{
				if (this.IsInitialized && value != this._caretPosition)
				{
					this._caretPosition = this.CoerceCaretPosition(value);
					this.MaskedEditor.CaretPosition = this._caretPosition;
					this.ScrollDisplayCharIntoView(this._caretPosition);
					this.MaskedEditor.ResetCaretBlinking();
					this.InvalidateMaskElement();
				}
			}
		}

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x06000811 RID: 2065 RVA: 0x000249F5 File Offset: 0x00022BF5
		internal bool ConstraintCaretToFilledCharacters
		{
			get
			{
				return this._maskInfo.PromptChar == '\0';
			}
		}

		// Token: 0x06000812 RID: 2066 RVA: 0x00024A08 File Offset: 0x00022C08
		internal int CoerceCaretPosition(int pos)
		{
			if (pos < 0)
			{
				pos = 0;
			}
			int num = this.GetTotalNumberOfDisplayChars() - 1;
			if (this.ConstraintCaretToFilledCharacters)
			{
				global::Infragistics.Windows.Editors.SectionBase currentSection = this.GetCurrentSection(true);
				if (!this.IsRightToLeft(currentSection) && !(currentSection is global::Infragistics.Windows.Editors.FractionPart))
				{
					global::Infragistics.Windows.Editors.InputCharBase lastFilledDisplayChar = this.LastFilledDisplayChar;
					num = ((lastFilledDisplayChar != null) ? lastFilledDisplayChar.OverallIndexInEdit : 0);
					global::Infragistics.Windows.Editors.DisplayCharBase displayCharAtPosition;
					while ((displayCharAtPosition = this.GetDisplayCharAtPosition(1 + num)) != null && !displayCharAtPosition.IsEmpty)
					{
						num++;
					}
				}
			}
			global::Infragistics.Windows.Editors.SectionBase lastSection = this.LastSection;
			if (pos > num)
			{
				pos = num + 1;
			}
			return pos;
		}

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x06000813 RID: 2067 RVA: 0x00024A86 File Offset: 0x00022C86
		// (set) Token: 0x06000814 RID: 2068 RVA: 0x00024A8E File Offset: 0x00022C8E
		internal int PivotPosition
		{
			get
			{
				return this._pivotPosition;
			}
			set
			{
				if (this.IsInitialized && value != this._pivotPosition)
				{
					this._pivotPosition = this.CoercePivotPosition(value);
					this.MaskedEditor.PivotPosition = this._pivotPosition;
					this.InvalidateMaskElement();
				}
			}
		}

		// Token: 0x06000815 RID: 2069 RVA: 0x00024AC8 File Offset: 0x00022CC8
		internal int CoercePivotPosition(int pos)
		{
			if (pos < 0)
			{
				pos = 0;
			}
			int num = this.GetTotalNumberOfDisplayChars() - 1;
			if (pos > num)
			{
				pos = num + 1;
			}
			return pos;
		}

		// Token: 0x06000816 RID: 2070 RVA: 0x00024AF0 File Offset: 0x00022CF0
		internal void SelectAll()
		{
			if (!this.IsInitialized || this.MaskedEditor.DesignMode)
			{
				return;
			}
			if (this.MaskedEditor != null && global::Infragistics.Windows.Editors.MaskSelectAllBehavior.SelectEnteredCharacters == this.MaskedEditor.SelectAllBehavior)
			{
				global::Infragistics.Windows.Editors.DisplayCharBase displayCharBase = this.FirstFilledDisplayChar;
				global::Infragistics.Windows.Editors.DisplayCharBase displayCharBase2 = this.LastFilledDisplayChar;
				while (displayCharBase != null && displayCharBase.PrevDisplayChar != null)
				{
					if (displayCharBase.PrevDisplayChar.IsEmpty)
					{
						break;
					}
					displayCharBase = displayCharBase.PrevDisplayChar;
				}
				while (displayCharBase2 != null && displayCharBase2.NextDisplayChar != null && !displayCharBase2.NextDisplayChar.IsEmpty)
				{
					displayCharBase2 = displayCharBase2.NextDisplayChar;
				}
				if (displayCharBase != null && displayCharBase2 != null)
				{
					this.Select(displayCharBase.OverallIndexInEdit, 1 + displayCharBase2.OverallIndexInEdit - displayCharBase.OverallIndexInEdit);
					return;
				}
			}
			this.SelectionStart = 0;
			this.SelectionLength = this.GetTotalNumberOfDisplayChars();
		}

		// Token: 0x06000817 RID: 2071 RVA: 0x00024BB1 File Offset: 0x00022DB1
		internal void Select(int start, int length)
		{
			this.SelectionStart = start;
			this.SelectionLength = length;
		}

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x06000818 RID: 2072 RVA: 0x00024BC4 File Offset: 0x00022DC4
		// (set) Token: 0x06000819 RID: 2073 RVA: 0x00024C18 File Offset: 0x00022E18
		internal int SelectionStart
		{
			get
			{
				global::Infragistics.Windows.Editors.DisplayCharBase displayCharAtPosition = this.GetDisplayCharAtPosition(this.CaretPosition);
				global::Infragistics.Windows.Editors.DisplayCharBase displayCharAtPosition2 = this.GetDisplayCharAtPosition(this.PivotPosition);
				if (displayCharAtPosition != null && displayCharAtPosition2 != null)
				{
					int caretPosition = this.CaretPosition;
					int pivotPosition = this.PivotPosition;
					return global::System.Math.Min(caretPosition, pivotPosition);
				}
				return global::System.Math.Min(this.PivotPosition, this.CaretPosition);
			}
			set
			{
				if (this.IsInitialized && value != this.SelectionStart)
				{
					int num = value;
					int totalNumberOfDisplayChars = this.GetTotalNumberOfDisplayChars();
					if (num < 0)
					{
						num = 0;
					}
					if (num > totalNumberOfDisplayChars)
					{
						num = totalNumberOfDisplayChars;
					}
					int selectionLength = this.SelectionLength;
					this.PivotPosition = num;
					this.CaretPosition = this.PivotPosition + selectionLength;
				}
			}
		}

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x0600081A RID: 2074 RVA: 0x00024C68 File Offset: 0x00022E68
		// (set) Token: 0x0600081B RID: 2075 RVA: 0x00024CC0 File Offset: 0x00022EC0
		internal int SelectionLength
		{
			get
			{
				global::Infragistics.Windows.Editors.DisplayCharBase displayCharAtPosition = this.GetDisplayCharAtPosition(this.CaretPosition);
				global::Infragistics.Windows.Editors.DisplayCharBase displayCharAtPosition2 = this.GetDisplayCharAtPosition(this.PivotPosition);
				if (displayCharAtPosition != null && displayCharAtPosition2 != null)
				{
					int caretPosition = this.CaretPosition;
					int pivotPosition = this.PivotPosition;
					return global::System.Math.Abs(pivotPosition - caretPosition);
				}
				return global::System.Math.Abs(this.PivotPosition - this.CaretPosition);
			}
			set
			{
				if (this.IsInitialized && value != this.SelectionLength)
				{
					int num = value;
					if (num < 0)
					{
						num = 0;
					}
					int totalNumberOfDisplayChars = this.GetTotalNumberOfDisplayChars();
					if (this.SelectionStart + num > totalNumberOfDisplayChars)
					{
						num = totalNumberOfDisplayChars - this.SelectionStart;
					}
					int num2 = global::System.Math.Min(this.CaretPosition, this.PivotPosition);
					this.PivotPosition = num2;
					this.CaretPosition = num2 + num;
					this.DirtyMaskElement();
				}
			}
		}

		// Token: 0x0600081C RID: 2076 RVA: 0x00024D29 File Offset: 0x00022F29
		internal void Cut()
		{
			this.Cut(true);
		}

		// Token: 0x0600081D RID: 2077 RVA: 0x00024D34 File Offset: 0x00022F34
		internal void Cut(bool fireValueChanged)
		{
			if (this.ReadOnly)
			{
				return;
			}
			string selectedText = this.SelectedText;
			if (selectedText == null || selectedText.Length == 0)
			{
				return;
			}
			try
			{
				if (!global::Infragistics.Windows.Helpers.ClipboardHelper.SetText(selectedText))
				{
					return;
				}
			}
			catch
			{
				return;
			}
			this.Delete();
			this.SetPivot();
			if (fireValueChanged)
			{
				this.OnTextChanged(true);
			}
			this.DirtyMaskElement();
		}

		// Token: 0x0600081E RID: 2078 RVA: 0x00024D9C File Offset: 0x00022F9C
		internal void Paste()
		{
			this.Paste(true);
		}

		// Token: 0x0600081F RID: 2079 RVA: 0x00024DA8 File Offset: 0x00022FA8
		internal void Paste(bool fireValueChanged)
		{
			if (this.ReadOnly)
			{
				return;
			}
			string text = global::Infragistics.Windows.Helpers.ClipboardHelper.GetText();
			text = this.NormalizeEncodingHelper(text);
			if (!string.IsNullOrEmpty(text))
			{
				this.SetSelectedText(text, fireValueChanged);
			}
		}

		// Token: 0x06000820 RID: 2080 RVA: 0x00024DDC File Offset: 0x00022FDC
		internal void Copy()
		{
			string text = this.SelectedText;
			if (text != null && text.Length > 1 && this.MaskInfo != null && this.MaskInfo.ClipMode == global::Infragistics.Windows.Editors.MaskMode.Raw)
			{
				string value = string.Concat(this.MaskInfo.DecimalSeperatorChar);
				if (text.EndsWith(value))
				{
					text = text.Substring(0, text.Length - 1);
				}
			}
			try
			{
				global::Infragistics.Windows.Helpers.ClipboardHelper.SetText(text);
			}
			catch
			{
			}
		}

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x06000821 RID: 2081 RVA: 0x00024E5C File Offset: 0x0002305C
		// (set) Token: 0x06000822 RID: 2082 RVA: 0x00024E89 File Offset: 0x00023089
		internal string SelectedText
		{
			get
			{
				if (!this.IsInitialized)
				{
					return string.Empty;
				}
				return this.GetText(this.MaskInfo.ClipMode, this.SelectionStart, this.SelectionLength);
			}
			set
			{
				this.SetSelectedText(value, true);
			}
		}

		// Token: 0x06000823 RID: 2083 RVA: 0x00024E94 File Offset: 0x00023094
		internal bool IsInputNull()
		{
			string text = this.GetText(global::Infragistics.Windows.Editors.MaskMode.Raw);
			return text == null || text.Length == 0 || this.TreatStringAsNull(text);
		}

		// Token: 0x06000824 RID: 2084 RVA: 0x00024EC0 File Offset: 0x000230C0
		private bool TreatStringAsNull(string value)
		{
			global::Infragistics.Windows.Editors.MaskInfo maskInfo = this.MaskInfo;
			char decimalSeperatorChar = maskInfo.DecimalSeperatorChar;
			global::Infragistics.Windows.Editors.SectionsCollection sections = maskInfo.Sections;
			int num = 0;
			int count = sections.Count;
			while (num + 2 < count)
			{
				if (sections[num] is global::Infragistics.Windows.Editors.NumberSection)
				{
					global::Infragistics.Windows.Editors.LiteralSection literalSection = sections[num + 1] as global::Infragistics.Windows.Editors.LiteralSection;
					if (literalSection != null && sections[num + 2] is global::Infragistics.Windows.Editors.FractionPart && literalSection.GetText() == value)
					{
						return true;
					}
				}
				num++;
			}
			return false;
		}

		// Token: 0x06000825 RID: 2085 RVA: 0x00024F3C File Offset: 0x0002313C
		private void SetSelectedText(string text, bool fireValueChanged)
		{
			if (text == null)
			{
				text = string.Empty;
			}
			string text2 = this.GetText(global::Infragistics.Windows.Editors.MaskMode.IncludeBoth);
			if (this.IsAnyTextSelected)
			{
				this.Delete();
			}
			if (global::Infragistics.Windows.Editors.XamMaskedEditor.AreAllDisplayCharsEmpty(this.Sections))
			{
				int numberSectionCount = global::Infragistics.Windows.Editors.XamMaskedEditor.GetNumberSectionCount(this.Sections);
				if (1 == numberSectionCount || (2 == numberSectionCount && this.LastEditSection is global::Infragistics.Windows.Editors.FractionPart))
				{
					object obj;
					global::System.Exception ex;
					this.MaskedEditor.ConvertTextToValue(text, out obj, out ex);
					if (obj != null)
					{
						try
						{
							this.Value = obj;
						}
						catch
						{
						}
						return;
					}
				}
			}
			if (this.IsInputNull())
			{
				global::Infragistics.Windows.Editors.DisplayCharBase currentDisplayChar = this.GetCurrentDisplayChar();
				global::Infragistics.Windows.Editors.EditSectionBase firstEditSection = this.FirstEditSection;
				bool flag = false;
				if (firstEditSection != null)
				{
					flag = (currentDisplayChar == firstEditSection.FirstDisplayChar || (this.IsRightToLeft(firstEditSection) && currentDisplayChar == firstEditSection.LastDisplayChar.NextDisplayChar));
				}
				if (flag)
				{
					this.SetCaretPivot(0);
				}
			}
			for (int i = 0; i < text.Length; i++)
			{
				this._lastIllegalDisplayChar = null;
				global::Infragistics.Windows.Editors.DisplayCharBase currentDisplayChar2 = this.GetCurrentDisplayChar();
				global::Infragistics.Windows.Editors.SectionBase sectionBase = (currentDisplayChar2 != null) ? currentDisplayChar2.Section : this.LastEditSection;
				if ((!(sectionBase is global::Infragistics.Windows.Editors.NumberSection) && !(currentDisplayChar2 is global::Infragistics.Windows.Editors.DecimalSeperatorChar)) || text[i] != this.MaskInfo.CommaChar)
				{
					this._lastIllegalDisplayChar = null;
					this.InternalProcessChar(text[i]);
					if (this._lastIllegalDisplayChar != null)
					{
						break;
					}
				}
			}
			string text3 = this.GetText(global::Infragistics.Windows.Editors.MaskMode.IncludeBoth);
			if (text2 != text3)
			{
				this.ValidateAllSections();
				if (this.IsRightToLeft(this.CurrentSection))
				{
					global::Infragistics.Windows.Editors.EditSectionBase editSectionBase = this.CurrentSection as global::Infragistics.Windows.Editors.EditSectionBase;
					if (editSectionBase != null)
					{
						this.GotoSection(editSectionBase);
					}
				}
				if (fireValueChanged)
				{
					this.OnTextChanged(true);
				}
			}
		}

		// Token: 0x06000826 RID: 2086 RVA: 0x000250E8 File Offset: 0x000232E8
		internal string GetText(global::Infragistics.Windows.Editors.MaskMode maskMode, int start, int length)
		{
			if (!this.IsInitialized)
			{
				return string.Empty;
			}
			return global::Infragistics.Windows.Editors.EditInfo.GetText(maskMode, start, length, this.Sections);
		}

		// Token: 0x06000827 RID: 2087 RVA: 0x00025108 File Offset: 0x00023308
		internal static string GetText(global::Infragistics.Windows.Editors.MaskMode maskMode, int start, int length, global::Infragistics.Windows.Editors.SectionsCollection sections)
		{
			int num = start + length;
			if (start == num)
			{
				return string.Empty;
			}
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(1 + length);
			for (int i = start; i < num; i++)
			{
				global::Infragistics.Windows.Editors.DisplayCharBase displayCharAtPosition = global::Infragistics.Windows.Editors.XamMaskedEditor.GetDisplayCharAtPosition(sections, i);
				char c = '\0';
				if (displayCharAtPosition != null)
				{
					c = displayCharAtPosition.GetChar(maskMode);
				}
				if (c != '\0')
				{
					stringBuilder.Append(c);
					if (displayCharAtPosition is global::Infragistics.Windows.Editors.DigitChar && ((global::Infragistics.Windows.Editors.DigitChar)displayCharAtPosition).ShouldIncludeComma(maskMode))
					{
						stringBuilder.Append(displayCharAtPosition.Section.CommaChar);
					}
				}
			}
			return stringBuilder.ToString();
		}

		// Token: 0x040002A0 RID: 672
		private global::Infragistics.Windows.Editors.MaskInfo _maskInfo;

		// Token: 0x040002A1 RID: 673
		private int _caretPosition;

		// Token: 0x040002A2 RID: 674
		private int _pivotPosition;

		// Token: 0x040002A3 RID: 675
		private char _lastIllegalChar;

		// Token: 0x040002A4 RID: 676
		private global::Infragistics.Windows.Editors.DisplayCharBase _lastIllegalDisplayChar;

		// Token: 0x040002A5 RID: 677
		internal bool _skipNextDecimalKeyPress;

		// Token: 0x040002A6 RID: 678
		internal bool _inOnTextChanged;

		// Token: 0x040002A7 RID: 679
		private global::System.Collections.Generic.Stack<global::Infragistics.Windows.Editors.EditInfo.EditorSnapshot> _undoHistory;

		// Token: 0x040002A8 RID: 680
		private global::System.Collections.Generic.Stack<global::Infragistics.Windows.Editors.EditInfo.EditorSnapshot> _redoHistory;

		// Token: 0x040002A9 RID: 681
		private bool _inUndoRedoHelper;

		// Token: 0x040002AA RID: 682
		private global::Infragistics.Windows.Editors.EditInfo.TextBoxEventProxy _staticEventProxy;

		// Token: 0x040002AB RID: 683
		internal global::System.Windows.Controls.TextBox _imeTextBox;

		// Token: 0x040002AC RID: 684
		internal bool _inSyncWithIMETextBox;

		// Token: 0x040002AD RID: 685
		internal bool _inSyncIMETextBox;

		// Token: 0x040002AE RID: 686
		internal global::Infragistics.Windows.Editors.Utils.Range _imeTextBox_PendingDelete;

		// Token: 0x02000086 RID: 134
		private class EditorSnapshot
		{
			// Token: 0x06000828 RID: 2088 RVA: 0x0002518A File Offset: 0x0002338A
			internal EditorSnapshot(global::Infragistics.Windows.Editors.EditInfo editInfo)
			{
				this._text = editInfo.GetText(global::Infragistics.Windows.Editors.MaskMode.IncludeBoth);
				this._caretPos = editInfo.CaretPosition;
				this._pivotPos = editInfo.PivotPosition;
			}

			// Token: 0x06000829 RID: 2089 RVA: 0x000251B7 File Offset: 0x000233B7
			internal void Apply(global::Infragistics.Windows.Editors.EditInfo editInfo)
			{
				editInfo.SetText(this._text);
				editInfo.PivotPosition = this._pivotPos;
				editInfo.CaretPosition = this._caretPos;
			}

			// Token: 0x040002AF RID: 687
			internal int _caretPos;

			// Token: 0x040002B0 RID: 688
			internal int _pivotPos;

			// Token: 0x040002B1 RID: 689
			internal string _text;
		}

		// Token: 0x02000087 RID: 135
		private class TextBoxEventProxy
		{
			// Token: 0x0600082A RID: 2090 RVA: 0x000251DE File Offset: 0x000233DE
			internal TextBoxEventProxy(global::Infragistics.Windows.Editors.EditInfo editInfo)
			{
				this._editInfoRef = new global::System.WeakReference(editInfo);
			}

			// Token: 0x170001D5 RID: 469
			// (get) Token: 0x0600082B RID: 2091 RVA: 0x000251F2 File Offset: 0x000233F2
			internal global::Infragistics.Windows.Editors.EditInfo EditInfo
			{
				get
				{
					return global::Infragistics.CoreUtilities.GetWeakReferenceTargetSafe(this._editInfoRef) as global::Infragistics.Windows.Editors.EditInfo;
				}
			}

			// Token: 0x0600082C RID: 2092 RVA: 0x00025204 File Offset: 0x00023404
			internal void UnwireInputMethod_StateChanged()
			{
				global::System.Windows.Input.InputMethod inputMethod = global::System.Windows.Input.InputMethod.Current;
				if (this._inputMethodWired != null && this._inputMethodWired == inputMethod)
				{
					try
					{
						this._inputMethodWired.StateChanged -= this.InputMethod_StateChanged;
					}
					catch
					{
					}
					this._inputMethodWired = null;
				}
			}

			// Token: 0x0600082D RID: 2093 RVA: 0x0002525C File Offset: 0x0002345C
			internal void UnwireTextBoxEvents()
			{
				if (this._textBoxWired != null)
				{
					this._textBoxWired.ClearValue(global::System.Windows.FrameworkElement.ContextMenuProperty);
					this._textBoxWired.PreviewTextInput -= this.ImeTextBox_PreviewTextInput;
					this._textBoxWired.SelectionChanged -= this.ImeTextBox_SelectionChanged;
					this._textBoxWired.PreviewKeyDown -= this.ImeTextBox_PreviewKeyDown;
					global::System.Windows.Input.CommandManager.RemovePreviewCanExecuteHandler(this._textBoxWired, new global::System.Windows.Input.CanExecuteRoutedEventHandler(this.ImeTextBox_PreviewCanExecuteCommand));
					global::System.Windows.Input.TextCompositionManager.RemoveTextInputStartHandler(this._textBoxWired, new global::System.Windows.Input.TextCompositionEventHandler(this.ImeTextBox_TextInputStart));
					this._textBoxWired = null;
				}
			}

			// Token: 0x0600082E RID: 2094 RVA: 0x00025300 File Offset: 0x00023500
			internal void WireInputMethod_StateChanged()
			{
				global::System.Windows.Input.InputMethod inputMethod = global::System.Windows.Input.InputMethod.Current;
				if (this._inputMethodWired != inputMethod)
				{
					this.UnwireInputMethod_StateChanged();
					this._inputMethodWired = inputMethod;
					if (inputMethod != null)
					{
						try
						{
							this._inputMethodWired.StateChanged += this.InputMethod_StateChanged;
						}
						catch
						{
						}
					}
				}
			}

			// Token: 0x0600082F RID: 2095 RVA: 0x00025358 File Offset: 0x00023558
			internal void WireTextBoxEvents(global::System.Windows.Controls.TextBox textBox)
			{
				if (this._textBoxWired != textBox)
				{
					this.UnwireTextBoxEvents();
					this._textBoxWired = textBox;
					if (this._textBoxWired != null)
					{
						this._textBoxWired.PreviewTextInput += this.ImeTextBox_PreviewTextInput;
						this._textBoxWired.SelectionChanged += this.ImeTextBox_SelectionChanged;
						this._textBoxWired.PreviewKeyDown += this.ImeTextBox_PreviewKeyDown;
						global::System.Windows.Input.CommandManager.AddPreviewCanExecuteHandler(this._textBoxWired, new global::System.Windows.Input.CanExecuteRoutedEventHandler(this.ImeTextBox_PreviewCanExecuteCommand));
						global::System.Windows.Input.TextCompositionManager.AddTextInputStartHandler(this._textBoxWired, new global::System.Windows.Input.TextCompositionEventHandler(this.ImeTextBox_TextInputStart));
					}
				}
			}

			// Token: 0x06000830 RID: 2096 RVA: 0x000253F9 File Offset: 0x000235F9
			private void OnCleanup()
			{
				this.UnwireTextBoxEvents();
				this.UnwireInputMethod_StateChanged();
			}

			// Token: 0x06000831 RID: 2097 RVA: 0x00025408 File Offset: 0x00023608
			private void ImeTextBox_TextInputStart(object sender, global::System.Windows.Input.TextCompositionEventArgs e)
			{
				global::Infragistics.Windows.Editors.EditInfo editInfo = this.EditInfo;
				if (editInfo != null)
				{
					editInfo.ImeTextBox_TextInputStart(sender, e);
					return;
				}
				this.OnCleanup();
			}

			// Token: 0x06000832 RID: 2098 RVA: 0x00025430 File Offset: 0x00023630
			private void ImeTextBox_PreviewCanExecuteCommand(object sender, global::System.Windows.Input.CanExecuteRoutedEventArgs e)
			{
				global::Infragistics.Windows.Editors.EditInfo editInfo = this.EditInfo;
				if (editInfo != null)
				{
					editInfo.ImeTextBox_PreviewCanExecuteCommand(sender, e);
					return;
				}
				this.OnCleanup();
			}

			// Token: 0x06000833 RID: 2099 RVA: 0x00025458 File Offset: 0x00023658
			private void ImeTextBox_PreviewKeyDown(object sender, global::System.Windows.Input.KeyEventArgs e)
			{
				global::Infragistics.Windows.Editors.EditInfo editInfo = this.EditInfo;
				if (editInfo != null)
				{
					editInfo.ImeTextBox_PreviewKeyDown(sender, e);
					return;
				}
				this.OnCleanup();
			}

			// Token: 0x06000834 RID: 2100 RVA: 0x00025480 File Offset: 0x00023680
			private void ImeTextBox_PreviewTextInput(object sender, global::System.Windows.Input.TextCompositionEventArgs e)
			{
				global::Infragistics.Windows.Editors.EditInfo editInfo = this.EditInfo;
				if (editInfo != null)
				{
					editInfo.ImeTextBox_PreviewTextInput(sender, e);
					return;
				}
				this.OnCleanup();
			}

			// Token: 0x06000835 RID: 2101 RVA: 0x000254A8 File Offset: 0x000236A8
			private void ImeTextBox_SelectionChanged(object sender, global::System.Windows.RoutedEventArgs e)
			{
				global::Infragistics.Windows.Editors.EditInfo editInfo = this.EditInfo;
				if (editInfo != null)
				{
					editInfo.ImeTextBox_SelectionChanged(sender, e);
					return;
				}
				this.OnCleanup();
			}

			// Token: 0x06000836 RID: 2102 RVA: 0x000254D0 File Offset: 0x000236D0
			private void InputMethod_StateChanged(object sender, global::System.Windows.Input.InputMethodStateChangedEventArgs e)
			{
				global::Infragistics.Windows.Editors.EditInfo editInfo = this.EditInfo;
				if (editInfo != null)
				{
					editInfo.InputMethod_StateChanged(sender, e);
					return;
				}
				this.OnCleanup();
			}

			// Token: 0x040002B2 RID: 690
			private global::System.WeakReference _editInfoRef;

			// Token: 0x040002B3 RID: 691
			private global::System.Windows.Input.InputMethod _inputMethodWired;

			// Token: 0x040002B4 RID: 692
			private global::System.Windows.Controls.TextBox _textBoxWired;
		}
	}
}
