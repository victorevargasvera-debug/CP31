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
	// Token: 0x0200008B RID: 139
	internal class EditInfo
	{
		// Token: 0x060007F9 RID: 2041 RVA: 0x00021DE2 File Offset: 0x0001FFE2
		internal EditInfo(global::Infragistics.Windows.Editors.MaskInfo maskInfo)
		{
			this.Initialize(maskInfo);
		}

		// Token: 0x060007FA RID: 2042 RVA: 0x00021DF4 File Offset: 0x0001FFF4
		private string GetTextInputText(global::System.Windows.Input.TextCompositionEventArgs e)
		{
			string text = e.Text;
			if (string.IsNullOrEmpty(text) && this._lastInputTextChanged != null && this._imeTextBox != null)
			{
				global::System.Windows.Controls.TextChange firstItem = global::Infragistics.CoreUtilities.GetFirstItem<global::System.Windows.Controls.TextChange>(this._lastInputTextChanged.Changes);
				string text2 = this._imeTextBox.Text;
				if (firstItem.Offset < text2.Length)
				{
					int start = firstItem.Offset;
					int length = firstItem.RemovedLength;
					if (this._imeTextBox_PendingDelete != null)
					{
						start = this._imeTextBox_PendingDelete.Start;
						length = this._imeTextBox_PendingDelete.Length;
					}
					this.Select(start, length);
					text = text2.Substring(firstItem.Offset, firstItem.AddedLength);
				}
			}
			this._lastInputTextChanged = null;
			return text;
		}

		// Token: 0x060007FB RID: 2043 RVA: 0x00021EA4 File Offset: 0x000200A4
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

		// Token: 0x060007FC RID: 2044 RVA: 0x00021F54 File Offset: 0x00020154
		private void Reset()
		{
			this._caretPosition = 0;
			this._pivotPosition = 0;
			this._lastIllegalChar = '\0';
			this._lastIllegalDisplayChar = null;
		}

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x060007FD RID: 2045 RVA: 0x00021F72 File Offset: 0x00020172
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

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x060007FE RID: 2046 RVA: 0x00021F8E File Offset: 0x0002018E
		internal global::Infragistics.Windows.Editors.MaskInfo MaskInfo
		{
			get
			{
				return this._maskInfo;
			}
		}

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x060007FF RID: 2047 RVA: 0x00021F96 File Offset: 0x00020196
		internal global::Infragistics.Windows.Editors.XamMaskedEditor MaskedEditor
		{
			get
			{
				return this._maskInfo.MaskEditor;
			}
		}

		// Token: 0x06000800 RID: 2048 RVA: 0x00021FA3 File Offset: 0x000201A3
		internal void OnInvalidOperation(global::Infragistics.Windows.Editors.Events.InvalidOperationEventArgs e)
		{
			this.MaskedEditor.OnInvalidOperation(e);
		}

		// Token: 0x06000801 RID: 2049 RVA: 0x00021FB1 File Offset: 0x000201B1
		internal void OnInvalidChar(global::Infragistics.Windows.Editors.Events.InvalidCharEventArgs e)
		{
			this.MaskedEditor.OnInvalidChar(e);
		}

		// Token: 0x06000802 RID: 2050 RVA: 0x00021FBF File Offset: 0x000201BF
		internal void OnTextChanged(bool viaUserAction)
		{
			this.OnTextChanged(viaUserAction, null);
		}

		// Token: 0x06000803 RID: 2051 RVA: 0x00021FCC File Offset: 0x000201CC
		internal void OnTextChanged(bool viaUserAction, global::System.Windows.Input.RoutedCommand command)
		{
			global::Infragistics.Windows.Editors.XamMaskedEditor maskedEditor = this.MaskedEditor;
			maskedEditor.BeginSyncValueProperties();
			bool inOnTextChanged = this._inOnTextChanged;
			this._inOnTextChanged = true;
			try
			{
				string text = global::Infragistics.Windows.Editors.XamMaskedEditor.GetText(this.Sections, this.MaskInfo.DataMode, this.MaskInfo, string.Empty);
				maskedEditor.Text_CurrentValue = text;
				this.SyncIMETextBox();
				this.ManageUndoHistory_TextChanged(viaUserAction, command);
			}
			finally
			{
				this._inOnTextChanged = inOnTextChanged;
				maskedEditor.EndSyncValueProperties();
			}
		}

		// Token: 0x06000804 RID: 2052 RVA: 0x0002204C File Offset: 0x0002024C
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

		// Token: 0x06000805 RID: 2053 RVA: 0x000220B7 File Offset: 0x000202B7
		internal string GetText(global::Infragistics.Windows.Editors.MaskMode maskMode)
		{
			return global::Infragistics.Windows.Editors.XamMaskedEditor.GetText(this.Sections, maskMode, this.MaskInfo);
		}

		// Token: 0x06000806 RID: 2054 RVA: 0x000220CB File Offset: 0x000202CB
		internal global::Infragistics.Windows.Editors.EditInfo.EditorValueSnapshot GetValueSnapshot()
		{
			return new global::Infragistics.Windows.Editors.EditInfo.EditorValueSnapshot(this);
		}

		// Token: 0x06000807 RID: 2055 RVA: 0x000220D4 File Offset: 0x000202D4
		internal int SetText(string text)
		{
			global::Infragistics.Windows.Editors.EditInfo.EditorValueSnapshot valueSnapshot = this.GetValueSnapshot();
			int result;
			try
			{
				int num = global::Infragistics.Windows.Editors.XamMaskedEditor.SetText(this.Sections, text, this.MaskInfo);
				this.DirtyMaskElement();
				result = num;
			}
			finally
			{
				if (!valueSnapshot.IsCurrentValueSame(this))
				{
					this.OnTextChanged(false);
				}
			}
			return result;
		}

		// Token: 0x06000808 RID: 2056 RVA: 0x0002212C File Offset: 0x0002032C
		internal void InvalidateMaskElement()
		{
			this.DirtyMaskElement();
		}

		// Token: 0x06000809 RID: 2057 RVA: 0x00022134 File Offset: 0x00020334
		internal void DirtyMaskElement()
		{
			this.MaskedEditor.InvalidateArrange();
		}

		// Token: 0x0600080A RID: 2058 RVA: 0x00022141 File Offset: 0x00020341
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

		// Token: 0x0600080B RID: 2059 RVA: 0x00022164 File Offset: 0x00020364
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

		// Token: 0x0600080C RID: 2060 RVA: 0x000221D4 File Offset: 0x000203D4
		private void ImeTextBox_PreviewKeyDown(object sender, global::System.Windows.Input.KeyEventArgs e)
		{
			this._lastInputTextChanged = null;
			if (global::System.Windows.Input.Key.V == e.Key || global::System.Windows.Input.Key.X == e.Key || global::System.Windows.Input.Key.C == e.Key)
			{
				global::System.Windows.Input.ModifierKeys modifierKeys = (e.KeyboardDevice != null) ? e.KeyboardDevice.Modifiers : global::System.Windows.Input.ModifierKeys.None;
				if ((global::System.Windows.Input.ModifierKeys.Control & modifierKeys) != global::System.Windows.Input.ModifierKeys.None)
				{
					this.MaskedEditor.ProcessKeyDown(e);
					return;
				}
			}
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

		// Token: 0x0600080D RID: 2061 RVA: 0x00022270 File Offset: 0x00020470
		private void ImeTextBox_PreviewTextInput(object sender, global::System.Windows.Input.TextCompositionEventArgs e)
		{
			string textInputText = this.GetTextInputText(e);
			if (!this.ReadOnly && !string.IsNullOrEmpty(textInputText))
			{
				global::System.Windows.Documents.FrameworkTextComposition frameworkTextComposition = e.TextComposition as global::System.Windows.Documents.FrameworkTextComposition;
				if (frameworkTextComposition != null && textInputText == e.Text)
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
				else
				{
					this._imeTextBox_PendingDelete = null;
				}
				if (this.ProcessTextInput(textInputText, true))
				{
					e.Handled = true;
				}
			}
			this._imeTextBox_PendingDelete = null;
		}

		// Token: 0x0600080E RID: 2062 RVA: 0x00022388 File Offset: 0x00020588
		private void ImeTextBox_SelectionChanged(object sender, global::System.Windows.RoutedEventArgs e)
		{
			this.SyncWithIMETextBox();
		}

		// Token: 0x0600080F RID: 2063 RVA: 0x00022390 File Offset: 0x00020590
		private void ImeTextBox_TextChanged(object sender, global::System.Windows.Controls.TextChangedEventArgs e)
		{
			if (this.IsTextInputInProgress && !this._inSyncIMETextBox && e.Changes.Count == 1)
			{
				this._lastInputTextChanged = e;
			}
		}

		// Token: 0x06000810 RID: 2064 RVA: 0x000223B7 File Offset: 0x000205B7
		private void ImeTextBox_TextInputStart(object sender, global::System.Windows.Input.TextCompositionEventArgs e)
		{
			this._imeTextBox_PendingDelete = null;
			this._imeTextBox_PendingDelete = new global::Infragistics.Windows.Editors.Utils.Range(this.SelectionStart, this.SelectionLength);
		}

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x06000811 RID: 2065 RVA: 0x000223D7 File Offset: 0x000205D7
		internal bool IsTextInputInProgress
		{
			get
			{
				return null != this._imeTextBox_PendingDelete;
			}
		}

		// Token: 0x06000812 RID: 2066 RVA: 0x000223E8 File Offset: 0x000205E8
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

		// Token: 0x06000813 RID: 2067 RVA: 0x00022498 File Offset: 0x00020698
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

		// Token: 0x06000814 RID: 2068 RVA: 0x00022614 File Offset: 0x00020814
		internal void InitializeIsTextBoxEntryEnabled()
		{
			global::System.Windows.Input.InputMethod inputMethod = global::System.Windows.Input.InputMethod.Current;
			bool flag = (inputMethod != null && global::System.Windows.Input.InputMethodState.On == inputMethod.ImeState) || global::Infragistics.Windows.Editors.XamMaskedEditor._IsTouchEnabled;
			flag = (flag && !this.ReadOnly);
			this.MaskedEditor.InternalSetIsTextBoxEntryEnabled(flag);
		}

		// Token: 0x06000815 RID: 2069 RVA: 0x0002265F File Offset: 0x0002085F
		private void InputMethod_StateChanged(object sender, global::System.Windows.Input.InputMethodStateChangedEventArgs e)
		{
			this.InitializeIsTextBoxEntryEnabled();
			this.SynchronizeTextBoxToInputMethodState();
		}

		// Token: 0x06000816 RID: 2070 RVA: 0x00022670 File Offset: 0x00020870
		private void SynchronizeTextBoxToInputMethodState()
		{
			global::Infragistics.Windows.Editors.XamMaskedEditor maskedEditor = this.MaskedEditor;
			if (this._imeTextBox != null)
			{
				global::System.Windows.Input.InputMethod.SetIsInputMethodEnabled(this._imeTextBox, maskedEditor.IsInputMethodEnabled);
			}
		}

		// Token: 0x06000817 RID: 2071 RVA: 0x000226A0 File Offset: 0x000208A0
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

		// Token: 0x06000818 RID: 2072 RVA: 0x000226F4 File Offset: 0x000208F4
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

		// Token: 0x06000819 RID: 2073 RVA: 0x00022768 File Offset: 0x00020968
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

		// Token: 0x0600081A RID: 2074 RVA: 0x000227E8 File Offset: 0x000209E8
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

		// Token: 0x0600081B RID: 2075 RVA: 0x0002285C File Offset: 0x00020A5C
		internal void SyncIMETextBox()
		{
			if (this.IsTextInputInProgress)
			{
				return;
			}
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

		// Token: 0x0600081C RID: 2076 RVA: 0x00022904 File Offset: 0x00020B04
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

		// Token: 0x0600081D RID: 2077 RVA: 0x00022994 File Offset: 0x00020B94
		internal void SetValue(object val)
		{
			global::Infragistics.Windows.Editors.EditInfo.EditorValueSnapshot valueSnapshot = this.GetValueSnapshot();
			try
			{
				global::Infragistics.Windows.Editors.XamMaskedEditor.SetDataValue(this.Sections, this.MaskInfo.DataType, val, this.MaskInfo);
			}
			finally
			{
				this.DirtyMaskElement();
				if (!valueSnapshot.IsCurrentValueSame(this))
				{
					this.OnTextChanged(false);
				}
			}
		}

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x0600081E RID: 2078 RVA: 0x000229F0 File Offset: 0x00020BF0
		// (set) Token: 0x0600081F RID: 2079 RVA: 0x000229FD File Offset: 0x00020BFD
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

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x06000820 RID: 2080 RVA: 0x00022A06 File Offset: 0x00020C06
		internal global::Infragistics.Windows.Editors.SectionsCollection Sections
		{
			get
			{
				return this.MaskInfo.Sections;
			}
		}

		// Token: 0x06000821 RID: 2081 RVA: 0x00022A14 File Offset: 0x00020C14
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

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x06000822 RID: 2082 RVA: 0x00022D27 File Offset: 0x00020F27
		internal global::Infragistics.Windows.Editors.MaskedEditorStates CurrentState
		{
			get
			{
				return this.GetCurrentState((global::Infragistics.Windows.Editors.MaskedEditorStates)((ulong)-1));
			}
		}

		// Token: 0x06000823 RID: 2083 RVA: 0x00022D34 File Offset: 0x00020F34
		internal bool ValidateChangeSection(global::Infragistics.Windows.Editors.SectionBase from, global::Infragistics.Windows.Editors.SectionBase to)
		{
			global::Infragistics.Windows.Editors.EditSectionBase editSectionBase = from as global::Infragistics.Windows.Editors.EditSectionBase;
			if (editSectionBase != null)
			{
				editSectionBase.ValidateSection();
			}
			return true;
		}

		// Token: 0x06000824 RID: 2084 RVA: 0x00022D53 File Offset: 0x00020F53
		internal bool ValidateAllSections()
		{
			return this.ValidateAllSections(false);
		}

		// Token: 0x06000825 RID: 2085 RVA: 0x00022D5C File Offset: 0x00020F5C
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

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x06000826 RID: 2086 RVA: 0x00022DB4 File Offset: 0x00020FB4
		internal bool IsAnyTextSelected
		{
			get
			{
				return this.CaretPosition != this.PivotPosition;
			}
		}

		// Token: 0x06000827 RID: 2087 RVA: 0x00022DC8 File Offset: 0x00020FC8
		internal bool IsDisplayCharSelected(global::Infragistics.Windows.Editors.DisplayCharBase dc)
		{
			int overallIndexInEdit = dc.OverallIndexInEdit;
			int selectionStart = this.SelectionStart;
			int num = this.SelectionStart + this.SelectionLength - 1;
			return selectionStart <= overallIndexInEdit && overallIndexInEdit <= num;
		}

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x06000828 RID: 2088 RVA: 0x00022E00 File Offset: 0x00021000
		internal bool IsAfterLastCharacter
		{
			get
			{
				return this.CaretPosition >= this.GetTotalNumberOfDisplayChars();
			}
		}

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x06000829 RID: 2089 RVA: 0x00022E13 File Offset: 0x00021013
		internal bool IsAtFirstChar
		{
			get
			{
				return 0 == this.CaretPosition;
			}
		}

		// Token: 0x0600082A RID: 2090 RVA: 0x00022E20 File Offset: 0x00021020
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

		// Token: 0x0600082B RID: 2091 RVA: 0x00023018 File Offset: 0x00021218
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

		// Token: 0x0600082C RID: 2092 RVA: 0x000231EC File Offset: 0x000213EC
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

		// Token: 0x0600082D RID: 2093 RVA: 0x00023281 File Offset: 0x00021481
		internal bool CanDelete()
		{
			return this.CanDelete(false);
		}

		// Token: 0x0600082E RID: 2094 RVA: 0x0002328C File Offset: 0x0002148C
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

		// Token: 0x0600082F RID: 2095 RVA: 0x000232D0 File Offset: 0x000214D0
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

		// Token: 0x06000830 RID: 2096 RVA: 0x00023409 File Offset: 0x00021609
		internal void SetPivot()
		{
			this.PivotPosition = this.CaretPosition;
		}

		// Token: 0x06000831 RID: 2097 RVA: 0x00023417 File Offset: 0x00021617
		internal bool Delete()
		{
			return this.Delete(false, false);
		}

		// Token: 0x06000832 RID: 2098 RVA: 0x00023424 File Offset: 0x00021624
		internal bool Delete(bool emulateDeleteKey, bool fireTextChanged)
		{
			global::Infragistics.Windows.Editors.EditInfo.EditorValueSnapshot editorValueSnapshot = null;
			if (fireTextChanged)
			{
				editorValueSnapshot = this.GetValueSnapshot();
			}
			bool result = this.DeleteHelper(emulateDeleteKey);
			if (fireTextChanged && !editorValueSnapshot.IsCurrentValueSame(this))
			{
				this.OnTextChanged(true);
			}
			return result;
		}

		// Token: 0x06000833 RID: 2099 RVA: 0x0002345C File Offset: 0x0002165C
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

		// Token: 0x06000834 RID: 2100 RVA: 0x000236CE File Offset: 0x000218CE
		private void GotoSection(global::Infragistics.Windows.Editors.SectionBase section)
		{
			this.GotoSection(section, false);
		}

		// Token: 0x06000835 RID: 2101 RVA: 0x000236D8 File Offset: 0x000218D8
		private void GotoSection(global::Infragistics.Windows.Editors.SectionBase section, bool positionToRight)
		{
			this.GotoSection(section, positionToRight, true);
		}

		// Token: 0x06000836 RID: 2102 RVA: 0x000236E4 File Offset: 0x000218E4
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

		// Token: 0x06000837 RID: 2103 RVA: 0x0002378C File Offset: 0x0002198C
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

		// Token: 0x06000838 RID: 2104 RVA: 0x00023838 File Offset: 0x00021A38
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

		// Token: 0x06000839 RID: 2105 RVA: 0x00023868 File Offset: 0x00021A68
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

		// Token: 0x0600083A RID: 2106 RVA: 0x00023910 File Offset: 0x00021B10
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

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x0600083B RID: 2107 RVA: 0x00023962 File Offset: 0x00021B62
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

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x0600083C RID: 2108 RVA: 0x0002397D File Offset: 0x00021B7D
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

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x0600083D RID: 2109 RVA: 0x00023998 File Offset: 0x00021B98
		private bool HasUndoHistory
		{
			get
			{
				return this._undoHistory != null && this._undoHistory.Count >= 2;
			}
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x0600083E RID: 2110 RVA: 0x000239B5 File Offset: 0x00021BB5
		private bool HasRedoHistory
		{
			get
			{
				return this._redoHistory != null && this._redoHistory.Count > 0;
			}
		}

		// Token: 0x0600083F RID: 2111 RVA: 0x000239CF File Offset: 0x00021BCF
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

		// Token: 0x06000840 RID: 2112 RVA: 0x00023A09 File Offset: 0x00021C09
		internal void Undo(bool fireValueChanged)
		{
			this.UndoRedoHelper(true, fireValueChanged);
		}

		// Token: 0x06000841 RID: 2113 RVA: 0x00023A13 File Offset: 0x00021C13
		internal void Redo(bool fireValueChanged)
		{
			this.UndoRedoHelper(false, fireValueChanged);
		}

		// Token: 0x06000842 RID: 2114 RVA: 0x00023A20 File Offset: 0x00021C20
		internal void UndoRedoHelper(bool undo, bool fireValueChanged)
		{
			if (this._inUndoRedoHelper)
			{
				return;
			}
			this._inUndoRedoHelper = true;
			try
			{
				global::Infragistics.Windows.Editors.EditInfo.EditorValueSnapshot valueSnapshot = this.GetValueSnapshot();
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
					if (fireValueChanged && !valueSnapshot.IsCurrentValueSame(this))
					{
						this.OnTextChanged(true);
					}
				}
			}
			finally
			{
				this._inUndoRedoHelper = false;
			}
		}

		// Token: 0x06000843 RID: 2115 RVA: 0x00023AD0 File Offset: 0x00021CD0
		internal void ClearRedoHistory()
		{
			this._redoHistory = null;
		}

		// Token: 0x06000844 RID: 2116 RVA: 0x00023AD9 File Offset: 0x00021CD9
		internal void ClearUndoHistory()
		{
			this._undoHistory = null;
		}

		// Token: 0x06000845 RID: 2117 RVA: 0x00023AE4 File Offset: 0x00021CE4
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

		// Token: 0x06000846 RID: 2118 RVA: 0x00023CB4 File Offset: 0x00021EB4
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
			global::Infragistics.Windows.Editors.EditInfo.EditorValueSnapshot valueSnapshot = this.GetValueSnapshot();
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
			if (!valueSnapshot.IsCurrentValueSame(this))
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

		// Token: 0x06000847 RID: 2119 RVA: 0x00024440 File Offset: 0x00022640
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

		// Token: 0x06000848 RID: 2120 RVA: 0x0002456C File Offset: 0x0002276C
		internal global::Infragistics.Windows.Editors.EditSectionBase GetSpinSection()
		{
			global::Infragistics.Windows.Editors.EditSectionBase editSectionBase = this.CurrentSection as global::Infragistics.Windows.Editors.EditSectionBase;
			if (editSectionBase != null && editSectionBase.SupportsSpinning)
			{
				return editSectionBase;
			}
			int num = this.CaretPosition - 1;
			while (0 <= num)
			{
				global::Infragistics.Windows.Editors.DisplayCharBase displayCharAtPosition = this.GetDisplayCharAtPosition(num);
				if (displayCharAtPosition == null)
				{
					break;
				}
				editSectionBase = (displayCharAtPosition.Section as global::Infragistics.Windows.Editors.EditSectionBase);
				if (editSectionBase != null && editSectionBase.SupportsSpinning)
				{
					return editSectionBase;
				}
				if (!(displayCharAtPosition.Section is global::Infragistics.Windows.Editors.LiteralSection) || !char.IsWhiteSpace(displayCharAtPosition.Char))
				{
					break;
				}
				num--;
			}
			return null;
		}

		// Token: 0x06000849 RID: 2121 RVA: 0x000245E4 File Offset: 0x000227E4
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

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x0600084A RID: 2122 RVA: 0x000246A4 File Offset: 0x000228A4
		internal bool ReadOnly
		{
			get
			{
				return this.MaskedEditor.IsReadOnly;
			}
		}

		// Token: 0x0600084B RID: 2123 RVA: 0x000246B1 File Offset: 0x000228B1
		internal bool CanSpin(bool up)
		{
			return this.CanSpin(up, null);
		}

		// Token: 0x0600084C RID: 2124 RVA: 0x000246BC File Offset: 0x000228BC
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

		// Token: 0x0600084D RID: 2125 RVA: 0x000246F8 File Offset: 0x000228F8
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
						decimal num5;
						if (!numberSection.TryToDecimal(out num5))
						{
							num5 = 0m;
						}
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
						decimal num11;
						if (!numberSection2.TryToDecimal(out num11))
						{
							num11 = 0m;
						}
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

		// Token: 0x0600084E RID: 2126 RVA: 0x00024CAC File Offset: 0x00022EAC
		internal void IllegalOperation(string message)
		{
			global::Infragistics.Windows.Editors.Events.InvalidOperationEventArgs invalidOperationEventArgs = new global::Infragistics.Windows.Editors.Events.InvalidOperationEventArgs(message);
			this.OnInvalidOperation(invalidOperationEventArgs);
			if (invalidOperationEventArgs.Beep)
			{
				this.MaskInfo.MaskEditor.Beep();
			}
		}

		// Token: 0x0600084F RID: 2127 RVA: 0x00024CE0 File Offset: 0x00022EE0
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

		// Token: 0x06000850 RID: 2128 RVA: 0x00024D24 File Offset: 0x00022F24
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

		// Token: 0x06000851 RID: 2129 RVA: 0x00024E11 File Offset: 0x00023011
		internal void EraseSelectedText()
		{
			this.GetTotalNumberOfDisplayChars();
			if (this.SelectionLength <= 0)
			{
				return;
			}
			this.EraseDisplayChars(this.SelectionStart, this.SelectionLength);
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x06000852 RID: 2130 RVA: 0x00024E38 File Offset: 0x00023038
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

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x06000853 RID: 2131 RVA: 0x00024E68 File Offset: 0x00023068
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

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x06000854 RID: 2132 RVA: 0x00024E96 File Offset: 0x00023096
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

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x06000855 RID: 2133 RVA: 0x00024EBC File Offset: 0x000230BC
		internal global::Infragistics.Windows.Editors.SectionBase LastSection
		{
			get
			{
				return global::Infragistics.Windows.Editors.EditInfo.GetLastSection(this.Sections);
			}
		}

		// Token: 0x06000856 RID: 2134 RVA: 0x00024EC9 File Offset: 0x000230C9
		internal static global::Infragistics.Windows.Editors.SectionBase GetLastSection(global::Infragistics.Windows.Editors.SectionsCollection sections)
		{
			if (sections == null || sections.Count <= 0)
			{
				return null;
			}
			return sections[sections.Count - 1];
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x06000857 RID: 2135 RVA: 0x00024EE8 File Offset: 0x000230E8
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

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x06000858 RID: 2136 RVA: 0x00024F2C File Offset: 0x0002312C
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

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x06000859 RID: 2137 RVA: 0x00024F6F File Offset: 0x0002316F
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

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x0600085A RID: 2138 RVA: 0x00024F88 File Offset: 0x00023188
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

		// Token: 0x0600085B RID: 2139 RVA: 0x00024FA8 File Offset: 0x000231A8
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

		// Token: 0x0600085C RID: 2140 RVA: 0x00024FDE File Offset: 0x000231DE
		internal void ToggleInsertMode()
		{
			this.InsertMode = !this.InsertMode;
		}

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x0600085D RID: 2141 RVA: 0x00024FF0 File Offset: 0x000231F0
		// (set) Token: 0x0600085E RID: 2142 RVA: 0x00025010 File Offset: 0x00023210
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

		// Token: 0x0600085F RID: 2143 RVA: 0x00025064 File Offset: 0x00023264
		internal bool IsRightToLeft(global::Infragistics.Windows.Editors.SectionBase section)
		{
			global::Infragistics.Windows.Editors.EditSectionBase editSectionBase = section as global::Infragistics.Windows.Editors.EditSectionBase;
			return editSectionBase != null && global::Infragistics.Windows.Editors.EditOrientation.RightToLeft == editSectionBase.Orientation;
		}

		// Token: 0x06000860 RID: 2144 RVA: 0x00025088 File Offset: 0x00023288
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

		// Token: 0x06000861 RID: 2145 RVA: 0x000250CC File Offset: 0x000232CC
		internal void ScrollAllTheWayRightHelper()
		{
			this.ScrollDisplayCharIntoView(this.GetTotalNumberOfDisplayChars());
		}

		// Token: 0x06000862 RID: 2146 RVA: 0x000250DA File Offset: 0x000232DA
		internal void ScrollCaretIntoView()
		{
			this.ScrollDisplayCharIntoView(this.CaretPosition);
		}

		// Token: 0x06000863 RID: 2147 RVA: 0x000250E8 File Offset: 0x000232E8
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

		// Token: 0x06000864 RID: 2148 RVA: 0x000252B4 File Offset: 0x000234B4
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

		// Token: 0x06000865 RID: 2149 RVA: 0x0002531C File Offset: 0x0002351C
		internal void ProcessTextInput(global::System.Windows.Input.TextCompositionEventArgs e, bool normalizeEncoding)
		{
			string textInputText = this.GetTextInputText(e);
			if (this.ProcessTextInput(textInputText, normalizeEncoding))
			{
				e.Handled = true;
			}
		}

		// Token: 0x06000866 RID: 2150 RVA: 0x00025344 File Offset: 0x00023544
		private bool ProcessTextInput(string text, bool normalizeEncoding)
		{
			if (this.ReadOnly)
			{
				return false;
			}
			this._lastIllegalChar = '\0';
			int num = 0;
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
			return true;
		}

		// Token: 0x06000867 RID: 2151 RVA: 0x000253B4 File Offset: 0x000235B4
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

		// Token: 0x06000868 RID: 2152 RVA: 0x0002541C File Offset: 0x0002361C
		private bool ProcessRTLInputSectionOverride(global::Infragistics.Windows.Editors.DisplayCharBase dc, char c)
		{
			if (!dc.MatchChar(c))
			{
				global::Infragistics.Windows.Editors.DisplayCharBase prevDisplayChar = dc.PrevDisplayChar;
				global::Infragistics.Windows.Editors.EditSectionBase editSectionBase = (prevDisplayChar != null) ? (prevDisplayChar.Section as global::Infragistics.Windows.Editors.EditSectionBase) : null;
				if (editSectionBase != dc.Section && this.IsRightToLeft(editSectionBase))
				{
					int pos = editSectionBase.DisplayChars.Count - 1;
					if (editSectionBase.CanInsertCharAt(pos, c))
					{
						return editSectionBase.InsertCharAt(pos, c);
					}
				}
			}
			return false;
		}

		// Token: 0x06000869 RID: 2153 RVA: 0x0002547F File Offset: 0x0002367F
		internal void InternalProcessChar(char c)
		{
			this.InternalProcessChar(c, false);
		}

		// Token: 0x0600086A RID: 2154 RVA: 0x0002548C File Offset: 0x0002368C
		internal void InternalProcessChar(char c, bool disallowSignAfterDigits)
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
					global::Infragistics.Windows.Editors.DisplayCharBase currentDisplayChar = this.GetCurrentDisplayChar();
					if (currentDisplayChar == null || !currentDisplayChar.MatchChar(c))
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
					bool flag3 = disallowSignAfterDigits && numberSection2.FirstFilledChar != null && numberSection2.FirstFilledChar.OverallIndexInEdit < displayCharBase2.OverallIndexInEdit;
					if (numberSection2.PlusSignChar == c)
					{
						if (flag3 || !numberSection2.SetNumberSign(false))
						{
							this.IllegalCharPressed(displayCharBase2, c);
						}
						this.DirtyMaskElement();
						return;
					}
					if (numberSection2.MinusSignChar == c)
					{
						if (flag3 || !numberSection2.SetNumberSign(true))
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
						if (!this.ProcessRTLInputSectionOverride(displayCharBase2, c))
						{
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
								bool flag4 = false;
								global::Infragistics.Windows.Editors.SectionBase section = displayCharBase2.Section;
								if (section.NextLiteralSection != null && section.NextLiteralSection.FirstDisplayChar.MatchChar(c))
								{
									this.CaretPosition = 1 + section.NextLiteralSection.FirstDisplayChar.OverallIndexInEdit;
									this.SetPivot();
									flag4 = true;
								}
								if (!flag4)
								{
									this.IllegalCharPressed(displayCharBase2, c);
								}
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
								bool flag5 = false;
								global::Infragistics.Windows.Editors.SectionBase section2 = displayCharBase2.Section;
								if (section2.NextLiteralSection != null && section2.NextLiteralSection.FirstDisplayChar.MatchChar(c))
								{
									this.CaretPosition = 1 + section2.NextLiteralSection.FirstDisplayChar.OverallIndexInEdit;
									this.SetPivot();
									flag5 = true;
								}
								if (!flag5)
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
							bool flag6 = false;
							global::Infragistics.Windows.Editors.SectionBase section3 = displayCharBase2.Section;
							if (section3.NextLiteralSection != null && section3.NextLiteralSection.FirstDisplayChar.MatchChar(c))
							{
								this.CaretPosition = 1 + section3.NextLiteralSection.FirstDisplayChar.OverallIndexInEdit;
								this.SetPivot();
								flag6 = true;
							}
							if (!flag6)
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
				bool flag7 = false;
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
					bool flag8 = disallowSignAfterDigits && numberSection3.FirstFilledChar != null && numberSection3.FirstFilledChar.OverallIndexInEdit < this.CaretPosition;
					if (numberSection3.PlusSignChar == c)
					{
						if (flag8 || !numberSection3.SetNumberSign(false))
						{
							this.IllegalCharPressed(displayCharBase2, c);
						}
						this.DirtyMaskElement();
						flag7 = true;
					}
					else if (numberSection3.MinusSignChar == c)
					{
						if (flag8 || !numberSection3.SetNumberSign(true))
						{
							this.IllegalCharPressed(displayCharBase2, c);
						}
						this.DirtyMaskElement();
						flag7 = true;
					}
				}
				if (!flag7)
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
							this.IllegalCharPressed(lastDisplayChar2, c);
						}
					}
					else
					{
						this.IllegalCharPressed(displayCharAtPosition8, c);
					}
				}
			}
			this.SetPivot();
			this.ScrollCaretIntoView();
		}

		// Token: 0x0600086B RID: 2155 RVA: 0x000262E0 File Offset: 0x000244E0
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

		// Token: 0x0600086C RID: 2156 RVA: 0x0002646C File Offset: 0x0002466C
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

		// Token: 0x0600086D RID: 2157 RVA: 0x000264C5 File Offset: 0x000246C5
		internal void MaskedEditUIElementMouseUp(global::System.Windows.Point point)
		{
			if (!this.IsAnyTextSelected)
			{
				this.EnsureNumberSectionState();
			}
		}

		// Token: 0x0600086E RID: 2158 RVA: 0x000264D8 File Offset: 0x000246D8
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

		// Token: 0x0600086F RID: 2159 RVA: 0x0002656D File Offset: 0x0002476D
		internal void EnsureMaskEditAreaFilled()
		{
		}

		// Token: 0x06000870 RID: 2160 RVA: 0x00026570 File Offset: 0x00024770
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

		// Token: 0x06000871 RID: 2161 RVA: 0x000265C8 File Offset: 0x000247C8
		internal global::Infragistics.Windows.Editors.SectionBase GetSectionContainingPosition(int position)
		{
			return global::Infragistics.Windows.Editors.EditInfo.GetSectionContainingPosition(position, this.Sections);
		}

		// Token: 0x06000872 RID: 2162 RVA: 0x000265D8 File Offset: 0x000247D8
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

		// Token: 0x06000873 RID: 2163 RVA: 0x00026623 File Offset: 0x00024823
		internal global::Infragistics.Windows.Editors.DisplayCharBase GetDisplayCharAtPosition(int position)
		{
			return global::Infragistics.Windows.Editors.XamMaskedEditor.GetDisplayCharAtPosition(this.Sections, position);
		}

		// Token: 0x06000874 RID: 2164 RVA: 0x00026631 File Offset: 0x00024831
		internal int GetTotalNumberOfDisplayChars()
		{
			return global::Infragistics.Windows.Editors.XamMaskedEditor.GetTotalNumberOfDisplayChars(this.Sections);
		}

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x06000875 RID: 2165 RVA: 0x0002663E File Offset: 0x0002483E
		internal bool IsInitialized
		{
			get
			{
				return this.GetTotalNumberOfDisplayChars() > 0;
			}
		}

		// Token: 0x06000876 RID: 2166 RVA: 0x00026649 File Offset: 0x00024849
		internal void SetCaretPivot(int pos)
		{
			this.CaretPosition = pos;
			this.PivotPosition = pos;
		}

		// Token: 0x06000877 RID: 2167 RVA: 0x00026659 File Offset: 0x00024859
		internal void SyncCaretAndPivotsWithMaskedEditor()
		{
			this.MaskedEditor.CaretPosition = this.CaretPosition;
			this.MaskedEditor.PivotPosition = this.PivotPosition;
		}

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x06000878 RID: 2168 RVA: 0x0002667D File Offset: 0x0002487D
		// (set) Token: 0x06000879 RID: 2169 RVA: 0x00026688 File Offset: 0x00024888
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

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x0600087A RID: 2170 RVA: 0x000266E1 File Offset: 0x000248E1
		internal bool ConstraintCaretToFilledCharacters
		{
			get
			{
				return this._maskInfo.PromptChar == '\0';
			}
		}

		// Token: 0x0600087B RID: 2171 RVA: 0x000266F4 File Offset: 0x000248F4
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

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x0600087C RID: 2172 RVA: 0x00026772 File Offset: 0x00024972
		// (set) Token: 0x0600087D RID: 2173 RVA: 0x0002677A File Offset: 0x0002497A
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

		// Token: 0x0600087E RID: 2174 RVA: 0x000267B4 File Offset: 0x000249B4
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

		// Token: 0x0600087F RID: 2175 RVA: 0x000267DC File Offset: 0x000249DC
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

		// Token: 0x06000880 RID: 2176 RVA: 0x0002689D File Offset: 0x00024A9D
		internal void Select(int start, int length)
		{
			this.SelectionStart = start;
			this.SelectionLength = length;
		}

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x06000881 RID: 2177 RVA: 0x000268B0 File Offset: 0x00024AB0
		// (set) Token: 0x06000882 RID: 2178 RVA: 0x00026904 File Offset: 0x00024B04
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

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x06000883 RID: 2179 RVA: 0x00026954 File Offset: 0x00024B54
		// (set) Token: 0x06000884 RID: 2180 RVA: 0x000269AC File Offset: 0x00024BAC
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

		// Token: 0x06000885 RID: 2181 RVA: 0x00026A15 File Offset: 0x00024C15
		internal void Cut()
		{
			this.Cut(true);
		}

		// Token: 0x06000886 RID: 2182 RVA: 0x00026A20 File Offset: 0x00024C20
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

		// Token: 0x06000887 RID: 2183 RVA: 0x00026A88 File Offset: 0x00024C88
		internal void Paste()
		{
			this.Paste(true);
		}

		// Token: 0x06000888 RID: 2184 RVA: 0x00026A94 File Offset: 0x00024C94
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

		// Token: 0x06000889 RID: 2185 RVA: 0x00026AC8 File Offset: 0x00024CC8
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

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x0600088A RID: 2186 RVA: 0x00026B48 File Offset: 0x00024D48
		// (set) Token: 0x0600088B RID: 2187 RVA: 0x00026B75 File Offset: 0x00024D75
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

		// Token: 0x0600088C RID: 2188 RVA: 0x00026B80 File Offset: 0x00024D80
		internal bool IsInputNull()
		{
			string text = this.GetText(global::Infragistics.Windows.Editors.MaskMode.Raw);
			return text == null || text.Length == 0 || this.TreatStringAsNull(text);
		}

		// Token: 0x0600088D RID: 2189 RVA: 0x00026BAC File Offset: 0x00024DAC
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

		// Token: 0x0600088E RID: 2190 RVA: 0x00026C28 File Offset: 0x00024E28
		private void SetSelectedText(string text, bool fireValueChanged)
		{
			if (text == null)
			{
				text = string.Empty;
			}
			global::Infragistics.Windows.Editors.EditInfo.EditorValueSnapshot valueSnapshot = this.GetValueSnapshot();
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
					this.InternalProcessChar(text[i], true);
					if (this._lastIllegalDisplayChar != null)
					{
						break;
					}
				}
			}
			if (!valueSnapshot.IsCurrentValueSame(this))
			{
				this.ValidateAllSections();
				if (this.IsRightToLeft(this.CurrentSection))
				{
					global::Infragistics.Windows.Editors.EditSectionBase editSectionBase = this.CurrentSection as global::Infragistics.Windows.Editors.EditSectionBase;
					if (editSectionBase != null)
					{
						this.GotoSection(editSectionBase);
						this.SetPivot();
					}
				}
				if (fireValueChanged)
				{
					this.OnTextChanged(true);
				}
			}
		}

		// Token: 0x0600088F RID: 2191 RVA: 0x00026DD0 File Offset: 0x00024FD0
		internal string GetText(global::Infragistics.Windows.Editors.MaskMode maskMode, int start, int length)
		{
			if (!this.IsInitialized)
			{
				return string.Empty;
			}
			return global::Infragistics.Windows.Editors.EditInfo.GetText(maskMode, start, length, this.Sections);
		}

		// Token: 0x06000890 RID: 2192 RVA: 0x00026DF0 File Offset: 0x00024FF0
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

		// Token: 0x040002D3 RID: 723
		private global::Infragistics.Windows.Editors.MaskInfo _maskInfo;

		// Token: 0x040002D4 RID: 724
		private int _caretPosition;

		// Token: 0x040002D5 RID: 725
		private int _pivotPosition;

		// Token: 0x040002D6 RID: 726
		private char _lastIllegalChar;

		// Token: 0x040002D7 RID: 727
		private global::Infragistics.Windows.Editors.DisplayCharBase _lastIllegalDisplayChar;

		// Token: 0x040002D8 RID: 728
		internal bool _skipNextDecimalKeyPress;

		// Token: 0x040002D9 RID: 729
		internal bool _inOnTextChanged;

		// Token: 0x040002DA RID: 730
		private global::System.Collections.Generic.Stack<global::Infragistics.Windows.Editors.EditInfo.EditorSnapshot> _undoHistory;

		// Token: 0x040002DB RID: 731
		private global::System.Collections.Generic.Stack<global::Infragistics.Windows.Editors.EditInfo.EditorSnapshot> _redoHistory;

		// Token: 0x040002DC RID: 732
		private bool _inUndoRedoHelper;

		// Token: 0x040002DD RID: 733
		private global::Infragistics.Windows.Editors.EditInfo.TextBoxEventProxy _staticEventProxy;

		// Token: 0x040002DE RID: 734
		internal global::System.Windows.Controls.TextBox _imeTextBox;

		// Token: 0x040002DF RID: 735
		internal bool _inSyncWithIMETextBox;

		// Token: 0x040002E0 RID: 736
		internal bool _inSyncIMETextBox;

		// Token: 0x040002E1 RID: 737
		internal global::Infragistics.Windows.Editors.Utils.Range _imeTextBox_PendingDelete;

		// Token: 0x040002E2 RID: 738
		private global::System.Windows.Controls.TextChangedEventArgs _lastInputTextChanged;

		// Token: 0x0200008C RID: 140
		private class EditorSnapshot
		{
			// Token: 0x06000891 RID: 2193 RVA: 0x00026E72 File Offset: 0x00025072
			internal EditorSnapshot(global::Infragistics.Windows.Editors.EditInfo editInfo)
			{
				this._text = editInfo.GetText(global::Infragistics.Windows.Editors.MaskMode.IncludeBoth);
				this._caretPos = editInfo.CaretPosition;
				this._pivotPos = editInfo.PivotPosition;
			}

			// Token: 0x06000892 RID: 2194 RVA: 0x00026E9F File Offset: 0x0002509F
			internal void Apply(global::Infragistics.Windows.Editors.EditInfo editInfo)
			{
				editInfo.SetText(this._text);
				editInfo.PivotPosition = this._pivotPos;
				editInfo.CaretPosition = this._caretPos;
			}

			// Token: 0x040002E3 RID: 739
			internal int _caretPos;

			// Token: 0x040002E4 RID: 740
			internal int _pivotPos;

			// Token: 0x040002E5 RID: 741
			internal string _text;
		}

		// Token: 0x0200008D RID: 141
		internal class EditorValueSnapshot
		{
			// Token: 0x06000893 RID: 2195 RVA: 0x00026EC6 File Offset: 0x000250C6
			internal EditorValueSnapshot(global::Infragistics.Windows.Editors.EditInfo editInfo)
			{
				this._text = editInfo.GetText(global::Infragistics.Windows.Editors.MaskMode.IncludeBoth);
				this._textRaw = editInfo.GetText(global::Infragistics.Windows.Editors.MaskMode.Raw);
			}

			// Token: 0x06000894 RID: 2196 RVA: 0x00026EE8 File Offset: 0x000250E8
			internal bool AreEqual(global::Infragistics.Windows.Editors.EditInfo.EditorValueSnapshot ii)
			{
				return ii._text == this._text && ii._textRaw == this._textRaw;
			}

			// Token: 0x06000895 RID: 2197 RVA: 0x00026F10 File Offset: 0x00025110
			internal bool IsCurrentValueSame(global::Infragistics.Windows.Editors.EditInfo editInfo)
			{
				return this.AreEqual(new global::Infragistics.Windows.Editors.EditInfo.EditorValueSnapshot(editInfo));
			}

			// Token: 0x040002E6 RID: 742
			internal string _text;

			// Token: 0x040002E7 RID: 743
			internal string _textRaw;
		}

		// Token: 0x0200008E RID: 142
		private class TextBoxEventProxy
		{
			// Token: 0x06000896 RID: 2198 RVA: 0x00026F1E File Offset: 0x0002511E
			internal TextBoxEventProxy(global::Infragistics.Windows.Editors.EditInfo editInfo)
			{
				this._editInfoRef = new global::System.WeakReference(editInfo);
			}

			// Token: 0x170001EA RID: 490
			// (get) Token: 0x06000897 RID: 2199 RVA: 0x00026F32 File Offset: 0x00025132
			internal global::Infragistics.Windows.Editors.EditInfo EditInfo
			{
				get
				{
					return global::Infragistics.CoreUtilities.GetWeakReferenceTargetSafe(this._editInfoRef) as global::Infragistics.Windows.Editors.EditInfo;
				}
			}

			// Token: 0x06000898 RID: 2200 RVA: 0x00026F44 File Offset: 0x00025144
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

			// Token: 0x06000899 RID: 2201 RVA: 0x00026F9C File Offset: 0x0002519C
			internal void UnwireTextBoxEvents()
			{
				if (this._textBoxWired != null)
				{
					this._textBoxWired.ClearValue(global::System.Windows.FrameworkElement.ContextMenuProperty);
					this._textBoxWired.PreviewTextInput -= this.ImeTextBox_PreviewTextInput;
					this._textBoxWired.TextChanged -= this.ImeTextBox_TextChanged;
					this._textBoxWired.SelectionChanged -= this.ImeTextBox_SelectionChanged;
					this._textBoxWired.PreviewKeyDown -= this.ImeTextBox_PreviewKeyDown;
					global::System.Windows.Input.CommandManager.RemovePreviewCanExecuteHandler(this._textBoxWired, new global::System.Windows.Input.CanExecuteRoutedEventHandler(this.ImeTextBox_PreviewCanExecuteCommand));
					global::System.Windows.Input.TextCompositionManager.RemoveTextInputStartHandler(this._textBoxWired, new global::System.Windows.Input.TextCompositionEventHandler(this.ImeTextBox_TextInputStart));
					this._textBoxWired = null;
				}
			}

			// Token: 0x0600089A RID: 2202 RVA: 0x00027058 File Offset: 0x00025258
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

			// Token: 0x0600089B RID: 2203 RVA: 0x000270B0 File Offset: 0x000252B0
			internal void WireTextBoxEvents(global::System.Windows.Controls.TextBox textBox)
			{
				if (this._textBoxWired != textBox)
				{
					this.UnwireTextBoxEvents();
					this._textBoxWired = textBox;
					if (this._textBoxWired != null)
					{
						this._textBoxWired.PreviewTextInput += this.ImeTextBox_PreviewTextInput;
						this._textBoxWired.TextChanged += this.ImeTextBox_TextChanged;
						this._textBoxWired.SelectionChanged += this.ImeTextBox_SelectionChanged;
						this._textBoxWired.PreviewKeyDown += this.ImeTextBox_PreviewKeyDown;
						global::System.Windows.Input.CommandManager.AddPreviewCanExecuteHandler(this._textBoxWired, new global::System.Windows.Input.CanExecuteRoutedEventHandler(this.ImeTextBox_PreviewCanExecuteCommand));
						global::System.Windows.Input.TextCompositionManager.AddTextInputStartHandler(this._textBoxWired, new global::System.Windows.Input.TextCompositionEventHandler(this.ImeTextBox_TextInputStart));
					}
				}
			}

			// Token: 0x0600089C RID: 2204 RVA: 0x0002716B File Offset: 0x0002536B
			private void OnCleanup()
			{
				this.UnwireTextBoxEvents();
				this.UnwireInputMethod_StateChanged();
			}

			// Token: 0x0600089D RID: 2205 RVA: 0x0002717C File Offset: 0x0002537C
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

			// Token: 0x0600089E RID: 2206 RVA: 0x000271A4 File Offset: 0x000253A4
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

			// Token: 0x0600089F RID: 2207 RVA: 0x000271CC File Offset: 0x000253CC
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

			// Token: 0x060008A0 RID: 2208 RVA: 0x000271F4 File Offset: 0x000253F4
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

			// Token: 0x060008A1 RID: 2209 RVA: 0x0002721C File Offset: 0x0002541C
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

			// Token: 0x060008A2 RID: 2210 RVA: 0x00027244 File Offset: 0x00025444
			private void ImeTextBox_TextChanged(object sender, global::System.Windows.Controls.TextChangedEventArgs e)
			{
				global::Infragistics.Windows.Editors.EditInfo editInfo = this.EditInfo;
				if (editInfo != null)
				{
					editInfo.ImeTextBox_TextChanged(sender, e);
					return;
				}
				this.OnCleanup();
			}

			// Token: 0x060008A3 RID: 2211 RVA: 0x0002726C File Offset: 0x0002546C
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

			// Token: 0x040002E8 RID: 744
			private global::System.WeakReference _editInfoRef;

			// Token: 0x040002E9 RID: 745
			private global::System.Windows.Input.InputMethod _inputMethodWired;

			// Token: 0x040002EA RID: 746
			private global::System.Windows.Controls.TextBox _textBoxWired;
		}
	}
}
