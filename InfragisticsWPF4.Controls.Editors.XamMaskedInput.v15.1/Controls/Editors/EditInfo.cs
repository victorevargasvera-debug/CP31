using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Threading;
using Infragistics.Controls.Editors.Primitives;

namespace Infragistics.Controls.Editors
{
	// Token: 0x0200001B RID: 27
	internal class EditInfo
	{
		// Token: 0x0600008C RID: 140 RVA: 0x00004026 File Offset: 0x00002226
		internal EditInfo(global::Infragistics.Controls.Editors.MaskInfo maskInfo)
		{
			this.Initialize(maskInfo);
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00004038 File Offset: 0x00002238
		private int CalculateInitialCaretPos()
		{
			int result = -1;
			if (this.InsertMode)
			{
				global::Infragistics.Controls.Editors.FractionPartContinuous fractionPartContinuous = this.LastEditSection as global::Infragistics.Controls.Editors.FractionPartContinuous;
				if (fractionPartContinuous != null && fractionPartContinuous.LastDisplayChar != null)
				{
					result = 1 + fractionPartContinuous.LastDisplayChar.OverallIndexInEdit;
				}
				else
				{
					global::Infragistics.Controls.Editors.NumberSection numberSection = this.FirstEditSection as global::Infragistics.Controls.Editors.NumberSection;
					if (numberSection != null)
					{
						if (numberSection.FirstFilledChar != null)
						{
							result = numberSection.FirstFilledChar.OverallIndexInEdit;
						}
						else if (numberSection.LastDisplayChar != null)
						{
							result = 1 + numberSection.LastDisplayChar.OverallIndexInEdit;
						}
					}
					else if (this.FirstEditDisplayChar != null)
					{
						result = this.FirstEditDisplayChar.OverallIndexInEdit;
					}
				}
			}
			return result;
		}

		// Token: 0x0600008E RID: 142 RVA: 0x000040C8 File Offset: 0x000022C8
		private void Initialize(global::Infragistics.Controls.Editors.MaskInfo maskInfo)
		{
			this.Reset();
			if (maskInfo == null)
			{
				throw new global::System.ArgumentNullException("maskInfo");
			}
			this._maskInfo = maskInfo;
			this.KeepHistory = this.MaskedInput.IsUndoEnabled;
			this.InitializeInitialCaretPos();
			this.ManageUndoHistory_TextChanged(false, null);
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00004118 File Offset: 0x00002318
		internal bool InitializeInitialCaretPos()
		{
			int num = this.CalculateInitialCaretPos();
			if (num >= 0)
			{
				this._caretPosition = (this._pivotPosition = num);
				return true;
			}
			return false;
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00004143 File Offset: 0x00002343
		internal void NotifyStateChanged()
		{
			this.NotifyCommandsManagerAsync();
		}

		// Token: 0x06000091 RID: 145 RVA: 0x0000414C File Offset: 0x0000234C
		internal void NotifyCommandsManagerAsync()
		{
			if (global::Infragistics.Controls.Editors.EditInfo._notifyCommandsManagerOperation == null)
			{
				global::System.Windows.Threading.Dispatcher dispatcher = this.MaskedInput.GetDispatcher();
				if (dispatcher != null)
				{
					global::Infragistics.Controls.Editors.EditInfo._notifyCommandsManagerOperation = dispatcher.BeginInvoke(new global::System.Action(this.NotifyCommandsManagerHandler), new object[0]);
				}
			}
		}

		// Token: 0x06000092 RID: 146 RVA: 0x0000418C File Offset: 0x0000238C
		private void NotifyCommandsManagerHandler()
		{
			global::Infragistics.Controls.Editors.EditInfo._notifyCommandsManagerOperation = null;
			global::Infragistics.Controls.Editors.Primitives.MaskedInputStates currentState = this.CurrentState;
			if (this._prevCurrentState != currentState)
			{
				this._prevCurrentState = currentState;
				global::Infragistics.CommandSourceManager.NotifyCanExecuteChanged(typeof(global::Infragistics.Controls.Editors.Primitives.MaskedInputCommand));
			}
		}

		// Token: 0x06000093 RID: 147 RVA: 0x000041C5 File Offset: 0x000023C5
		private void Reset()
		{
			this._caretPosition = 0;
			this._pivotPosition = 0;
			this._lastIllegalChar = '\0';
			this._lastIllegalDisplayChar = null;
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000094 RID: 148 RVA: 0x000041E3 File Offset: 0x000023E3
		private global::Infragistics.Controls.Editors.EditInfo.TextBoxEventProxy EventProxy
		{
			get
			{
				if (this._staticEventProxy == null)
				{
					this._staticEventProxy = new global::Infragistics.Controls.Editors.EditInfo.TextBoxEventProxy(this);
				}
				return this._staticEventProxy;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000095 RID: 149 RVA: 0x000041FF File Offset: 0x000023FF
		internal global::Infragistics.Controls.Editors.MaskInfo MaskInfo
		{
			get
			{
				return this._maskInfo;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000096 RID: 150 RVA: 0x00004207 File Offset: 0x00002407
		internal global::Infragistics.Controls.Editors.XamMaskedInput MaskedInput
		{
			get
			{
				return this._maskInfo.MaskedInput;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000097 RID: 151 RVA: 0x00004214 File Offset: 0x00002414
		// (set) Token: 0x06000098 RID: 152 RVA: 0x0000421C File Offset: 0x0000241C
		internal bool KeepHistory { get; set; }

		// Token: 0x06000099 RID: 153 RVA: 0x00004225 File Offset: 0x00002425
		internal void OnInvalidOperation(global::Infragistics.Controls.Editors.InvalidOperationEventArgs e)
		{
			this.MaskedInput.OnInvalidOperation(e);
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00004233 File Offset: 0x00002433
		internal void OnInvalidChar(global::Infragistics.Controls.Editors.InvalidCharEventArgs e)
		{
			this.MaskedInput.OnInvalidChar(e);
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00004244 File Offset: 0x00002444
		internal void OnTextChanged(bool viaUserAction, global::Infragistics.Controls.Editors.Primitives.MaskedInputCommandId? command = null, bool syncImeTextBox = true, global::Infragistics.Controls.Editors.EditInfo.EditorValueSnapshot oldValueSnapshot = null)
		{
			global::Infragistics.Controls.Editors.XamMaskedInput maskedInput = this.MaskedInput;
			maskedInput.BeginSyncValueProperties();
			bool inOnTextChanged = this._inOnTextChanged;
			this._inOnTextChanged = true;
			try
			{
				string text = global::Infragistics.Controls.Editors.XamMaskedInput.GetText(this.Sections, this.MaskInfo.DataMode, this.MaskInfo, string.Empty);
				maskedInput.Text = text;
				bool flag = true;
				if (command == global::Infragistics.Controls.Editors.Primitives.MaskedInputCommandId.SpinDown || command == global::Infragistics.Controls.Editors.Primitives.MaskedInputCommandId.SpinUp)
				{
					object objA = null;
					global::System.Exception ex;
					if (maskedInput.ConvertTextToValue(text, out objA, out ex) && !object.Equals(objA, maskedInput.Value))
					{
						this.MaskInfo.InternalRefreshValue(maskedInput.Value, out ex);
						text = global::Infragistics.Controls.Editors.XamMaskedInput.GetText(this.Sections, this.MaskInfo.DataMode, this.MaskInfo, string.Empty);
						maskedInput.Text = text;
						if (oldValueSnapshot != null && oldValueSnapshot.IsCurrentValueSame(this))
						{
							flag = false;
						}
					}
				}
				if (syncImeTextBox)
				{
					this.SyncIMETextBox(false);
				}
				if (flag)
				{
					this.ManageUndoHistory_TextChanged(viaUserAction, command);
				}
			}
			finally
			{
				this._inOnTextChanged = inOnTextChanged;
				maskedInput.EndSyncValueProperties();
				this.NotifyStateChanged();
			}
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00004374 File Offset: 0x00002574
		internal global::Infragistics.Controls.Editors.SectionBase GetCurrentSection(bool returnPrevRightToLeftSection)
		{
			global::Infragistics.Controls.Editors.DisplayCharBase currentDisplayChar = this.GetCurrentDisplayChar();
			if (currentDisplayChar == null || (!currentDisplayChar.IsEditable && currentDisplayChar.Section.FirstDisplayChar == currentDisplayChar))
			{
				global::Infragistics.Controls.Editors.SectionBase sectionBase = (currentDisplayChar == null) ? this.LastEditSection : ((currentDisplayChar.PrevDisplayChar != null) ? currentDisplayChar.PrevDisplayChar.Section : null);
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

		// Token: 0x0600009D RID: 157 RVA: 0x000043DC File Offset: 0x000025DC
		internal string GetText(global::Infragistics.Controls.Editors.InputMaskMode maskMode)
		{
			return global::Infragistics.Controls.Editors.XamMaskedInput.GetText(this.Sections, maskMode, this.MaskInfo);
		}

		// Token: 0x0600009E RID: 158 RVA: 0x000043F0 File Offset: 0x000025F0
		internal global::Infragistics.Controls.Editors.EditInfo.EditorValueSnapshot GetValueSnapshot()
		{
			return new global::Infragistics.Controls.Editors.EditInfo.EditorValueSnapshot(this);
		}

		// Token: 0x0600009F RID: 159 RVA: 0x000043F8 File Offset: 0x000025F8
		internal int SetText(string text)
		{
			global::Infragistics.Controls.Editors.EditInfo.EditorValueSnapshot valueSnapshot = this.GetValueSnapshot();
			int result;
			try
			{
				int num = global::Infragistics.Controls.Editors.XamMaskedInput.SetText(this.Sections, text, this.MaskInfo);
				this.DirtyMaskElement();
				result = num;
			}
			finally
			{
				if (!valueSnapshot.IsCurrentValueSame(this))
				{
					this.OnTextChanged(false, null, true, null);
				}
			}
			return result;
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00004458 File Offset: 0x00002658
		internal void InvalidateMaskElement()
		{
			this.DirtyMaskElement();
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00004460 File Offset: 0x00002660
		internal void DirtyMaskElement()
		{
			this.MaskedInput.InvalidateArrange();
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00004470 File Offset: 0x00002670
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

		// Token: 0x060000A3 RID: 163 RVA: 0x000044E0 File Offset: 0x000026E0
		internal void ImeTextBox_TextInput(object sender, global::System.Windows.Input.TextCompositionEventArgs e, string text)
		{
			if (!this.ReadOnly && !this._skipNextTextInput && (e == null || !string.IsNullOrEmpty(e.Text)))
			{
				int num = -1;
				if (e != null)
				{
					text = e.Text;
					global::System.Windows.Input.TextComposition textComposition = e.TextComposition;
					if (textComposition != null)
					{
						try
						{
							if (textComposition is global::System.Windows.Documents.FrameworkTextComposition)
							{
								global::System.Reflection.PropertyInfo property = typeof(global::System.Windows.Documents.FrameworkTextComposition).GetProperty("ResultOffset");
								if (null != property)
								{
									num = (int)property.GetValue(textComposition, null);
								}
							}
						}
						catch
						{
						}
					}
				}
				if (this._imeTextBox_PendingDelete != null)
				{
					global::Infragistics.Controls.Editors.Primitives.Utils.Range imeTextBox_PendingDelete = this._imeTextBox_PendingDelete;
					this._imeTextBox_PendingDelete = null;
					this.Select(imeTextBox_PendingDelete.Start, imeTextBox_PendingDelete.Length, false);
					if (this.IsAnyTextSelected && num >= 0 && num != imeTextBox_PendingDelete.Start)
					{
						this.Delete();
					}
				}
				if (num >= 0 && !this.IsCaretPositionInSelection(num))
				{
					this.SetCaretPivot(num);
				}
				if (this.ProcessTextInput(text, true) && e != null)
				{
					e.Handled = true;
				}
			}
			this._imeTextBox_PendingDelete = null;
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x000045EC File Offset: 0x000027EC
		internal void ImeTextBox_TextInputStart(object sender, global::System.Windows.Input.TextCompositionEventArgs e)
		{
			if (!this._skipNextTextInput)
			{
				this._imeTextBox_PendingDelete = new global::Infragistics.Controls.Editors.Primitives.Utils.Range(this.SelectionStart, this.SelectionLength);
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000A5 RID: 165 RVA: 0x0000460D File Offset: 0x0000280D
		internal bool IsTextInputInProgress
		{
			get
			{
				return null != this._imeTextBox_PendingDelete;
			}
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x0000461C File Offset: 0x0000281C
		internal void InitializeIMETextBox(global::System.Windows.DependencyObject focusSite)
		{
			global::Infragistics.Controls.Editors.XamMaskedInput maskedInput = this.MaskedInput;
			if (this._imeTextBox != null)
			{
				this.EventProxy.UnwireTextBoxEvents();
				this._imeTextBox = null;
			}
			global::Infragistics.Controls.Editors.Primitives.MaskedInputTextBox imeTextBox = focusSite as global::Infragistics.Controls.Editors.Primitives.MaskedInputTextBox;
			this._imeTextBox = imeTextBox;
			if (this._imeTextBox != null)
			{
				global::System.Windows.Controls.ContextMenu contextMenu = null;
				if (maskedInput.ReadLocalValue(global::System.Windows.FrameworkElement.ContextMenuProperty) != null)
				{
					contextMenu = maskedInput.ContextMenu;
					if (contextMenu == null)
					{
						contextMenu = maskedInput.CreateContextMenu();
					}
				}
				this._imeTextBox.ContextMenu = contextMenu;
				this._imeTextBox.Initialize(this.MaskedInput);
				this.EventProxy.WireTextBoxEvents(this._imeTextBox);
				this.SyncIMETextBox(false);
			}
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x000046B8 File Offset: 0x000028B8
		internal int MapCaretPosFromImeTextBox(int pos)
		{
			int totalNumberOfDisplayChars = this.GetTotalNumberOfDisplayChars();
			int num = global::System.Math.Min(pos, totalNumberOfDisplayChars);
			int num2 = this.MapCaretPosToImeTextBox(num);
			if (num2 < pos)
			{
				while (++num <= totalNumberOfDisplayChars)
				{
					num2 = this.MapCaretPosToImeTextBox(num);
					if (num2 >= pos)
					{
						break;
					}
				}
			}
			else if (num2 > pos)
			{
				while (--num <= totalNumberOfDisplayChars)
				{
					num2 = this.MapCaretPosToImeTextBox(num);
					if (num2 < pos)
					{
						num++;
						break;
					}
					if (num2 == pos)
					{
						break;
					}
				}
			}
			return global::System.Math.Max(0, global::System.Math.Min(num, totalNumberOfDisplayChars));
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x0000472C File Offset: 0x0000292C
		private int MapCaretPosToImeTextBox(int pos)
		{
			int num = 0;
			foreach (object obj in this.Sections.AllDisplayCharacters)
			{
				global::Infragistics.Controls.Editors.DisplayCharBase displayCharBase = (global::Infragistics.Controls.Editors.DisplayCharBase)obj;
				if (displayCharBase.OverallIndexInEdit >= pos)
				{
					break;
				}
				num += this.GetDrawStringHelper(displayCharBase, null) - 1;
			}
			return pos + num;
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x000047A0 File Offset: 0x000029A0
		private int GetDrawStringHelper(global::Infragistics.Controls.Editors.DisplayCharBase dc, global::System.Text.StringBuilder sb)
		{
			int num = 0;
			char @char = dc.GetChar(global::Infragistics.Controls.Editors.InputMaskMode.IncludeBoth, this._maskInfo.PromptChar, this._maskInfo.PadChar);
			if (@char == '\0' && dc is global::Infragistics.Controls.Editors.DecimalSeperatorChar)
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
				global::Infragistics.Controls.Editors.DigitChar digitChar = dc as global::Infragistics.Controls.Editors.DigitChar;
				if (digitChar != null && digitChar.ShouldIncludeComma(global::Infragistics.Controls.Editors.InputMaskMode.IncludeBoth))
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

		// Token: 0x060000AA RID: 170 RVA: 0x00004820 File Offset: 0x00002A20
		private string GetDrawString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(4 + this.GetTotalNumberOfDisplayChars());
			foreach (object obj in this.Sections.AllDisplayCharacters)
			{
				global::Infragistics.Controls.Editors.DisplayCharBase dc = (global::Infragistics.Controls.Editors.DisplayCharBase)obj;
				this.GetDrawStringHelper(dc, stringBuilder);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00004894 File Offset: 0x00002A94
		internal void SyncIMETextBox(bool fromIsInEditModeChanged = false)
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
					global::Infragistics.Controls.Editors.XamMaskedInput maskedInput = this.MaskedInput;
					string text;
					if (this._maskInfo.IsBeingEditedAndFocused || (maskedInput != null && !maskedInput.IsValueValid && !this.IsInputParseable()))
					{
						text = this.GetDrawString();
						if (fromIsInEditModeChanged && this._imeTextBox._enteringEditModeViaMouseDown != null && this.IsInputNull())
						{
							this.InitializeInitialCaretPos();
						}
					}
					else
					{
						text = this._maskInfo.MaskedInput.DisplayText;
						if (this.IsInputNull())
						{
							string nullText = this.MaskedInput.NullText;
							if (global::Infragistics.Controls.Editors.InputMaskMode.IncludeBoth != this._maskInfo.DisplayMode || !string.IsNullOrEmpty(nullText))
							{
								text = nullText;
							}
						}
					}
					this._imeTextBox.Text = text;
					this.SyncSelectionOnImeTextBoxHelper();
					if (fromIsInEditModeChanged && maskedInput.IsInEditMode)
					{
						global::System.Windows.Input.InputLanguageManager.SetInputLanguage(this._imeTextBox, global::System.Windows.Input.InputLanguageManager.GetInputLanguage(maskedInput));
					}
					this._imeTextBox.OnSyncComplete();
				}
			}
			finally
			{
				this._inSyncIMETextBox = false;
			}
		}

		// Token: 0x060000AC RID: 172 RVA: 0x000049B4 File Offset: 0x00002BB4
		internal void SyncWithIMETextBox()
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
					if (this._maskInfo.IsBeingEditedAndFocused)
					{
						bool flag = false;
						if (this._imeTextBox._enteringEditModeViaMouseDown != null)
						{
							int num3 = -1;
							if (num == num2)
							{
								int num4 = this.MapCaretPosToImeTextBox(this.GetTotalNumberOfDisplayChars());
								if (num == 0 || this.IsInputNull())
								{
									num3 = this.CalculateInitialCaretPos();
								}
								else if (num4 == num)
								{
									global::Infragistics.Controls.Editors.DisplayCharBase lastFilledDisplayChar = this.LastFilledDisplayChar;
									if (lastFilledDisplayChar != null)
									{
										num3 = 1 + lastFilledDisplayChar.OverallIndexInEdit;
									}
								}
							}
							if (num3 >= 0)
							{
								num2 = (num = num3);
								flag = true;
							}
						}
						this.SelectionStart = num;
						this.SelectionLength = num2 - num;
						if (flag)
						{
							this.SyncSelectionOnImeTextBoxHelper();
						}
					}
				}
			}
			finally
			{
				this._inSyncWithIMETextBox = false;
			}
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00004AC4 File Offset: 0x00002CC4
		private void SyncSelectionOnImeTextBoxHelper()
		{
			if (this.IsTextInputInProgress)
			{
				return;
			}
			int selectionStart = this.SelectionStart;
			int num = this.MapCaretPosToImeTextBox(selectionStart);
			int num2 = (this.SelectionLength == 0) ? num : this.MapCaretPosToImeTextBox(selectionStart + this.SelectionLength);
			int num3 = num2 - num;
			if (this._imeTextBox != null && (this._imeTextBox.SelectionStart != num || this._imeTextBox.SelectionLength != num3))
			{
				this._imeTextBox.Select(num, num3);
			}
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00004B38 File Offset: 0x00002D38
		internal void SetValue(object val)
		{
			global::Infragistics.Controls.Editors.EditInfo.EditorValueSnapshot valueSnapshot = this.GetValueSnapshot();
			try
			{
				global::Infragistics.Controls.Editors.XamMaskedInput.SetDataValue(this.Sections, this.MaskInfo.DataType, val, this.MaskInfo);
			}
			finally
			{
				this.DirtyMaskElement();
				if (!valueSnapshot.IsCurrentValueSame(this))
				{
					this.OnTextChanged(false, null, true, null);
				}
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000AF RID: 175 RVA: 0x00004BA0 File Offset: 0x00002DA0
		// (set) Token: 0x060000B0 RID: 176 RVA: 0x00004BAD File Offset: 0x00002DAD
		internal object Value
		{
			get
			{
				return global::Infragistics.Controls.Editors.XamMaskedInput.InternalGetDataValue(this.MaskInfo);
			}
			set
			{
				this.SetValue(value);
			}
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00004BB8 File Offset: 0x00002DB8
		internal bool IsInputParseable()
		{
			bool result;
			try
			{
				object value = this.Value;
				result = true;
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000B2 RID: 178 RVA: 0x00004BE8 File Offset: 0x00002DE8
		internal global::Infragistics.Controls.Editors.SectionsCollection Sections
		{
			get
			{
				return this.MaskInfo.Sections;
			}
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00004BF5 File Offset: 0x00002DF5
		internal long GetCurrentStateLong(long statesToQuery)
		{
			return (long)this.GetCurrentState((global::Infragistics.Controls.Editors.Primitives.MaskedInputStates)statesToQuery);
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00004C00 File Offset: 0x00002E00
		internal global::Infragistics.Controls.Editors.Primitives.MaskedInputStates GetCurrentState(global::Infragistics.Controls.Editors.Primitives.MaskedInputStates statesToQuery)
		{
			if (!this.IsInitialized)
			{
				return global::Infragistics.Controls.Editors.Primitives.MaskedInputStates.Uninitialized;
			}
			global::Infragistics.Controls.Editors.XamMaskedInput maskedInput = this.MaskedInput;
			global::Infragistics.Controls.Editors.Primitives.MaskedInputStates maskedInputStates = (global::Infragistics.Controls.Editors.Primitives.MaskedInputStates)0L;
			if (this.MaskedInput != null && !this.MaskedInput.IsEnabled)
			{
				maskedInputStates |= global::Infragistics.Controls.Editors.Primitives.MaskedInputStates.NotInEditMode;
			}
			if ((global::Infragistics.Controls.Editors.Primitives.MaskedInputStates)0L != (global::Infragistics.Controls.Editors.Primitives.MaskedInputStates.Character & statesToQuery))
			{
				if (this.GetCurrentDisplayChar() != null)
				{
					maskedInputStates |= global::Infragistics.Controls.Editors.Primitives.MaskedInputStates.Character;
				}
				else
				{
					maskedInputStates |= global::Infragistics.Controls.Editors.Primitives.MaskedInputStates.AfterLastCharacter;
				}
			}
			if ((global::Infragistics.Controls.Editors.Primitives.MaskedInputStates)0L != (global::Infragistics.Controls.Editors.Primitives.MaskedInputStates.Selected & statesToQuery) && this.SelectionLength > 0)
			{
				maskedInputStates |= global::Infragistics.Controls.Editors.Primitives.MaskedInputStates.Selected;
			}
			if ((global::Infragistics.Controls.Editors.Primitives.MaskedInputStates)0L != (global::Infragistics.Controls.Editors.Primitives.MaskedInputStates.FirstSection & statesToQuery) && this.FirstSection != null && this.CurrentSection == this.FirstSection)
			{
				maskedInputStates |= global::Infragistics.Controls.Editors.Primitives.MaskedInputStates.FirstSection;
			}
			if ((global::Infragistics.Controls.Editors.Primitives.MaskedInputStates)0L != (global::Infragistics.Controls.Editors.Primitives.MaskedInputStates.LastSection & statesToQuery) && this.LastSection != null && this.CurrentSection == this.LastSection)
			{
				maskedInputStates |= global::Infragistics.Controls.Editors.Primitives.MaskedInputStates.LastSection;
			}
			if ((global::Infragistics.Controls.Editors.Primitives.MaskedInputStates)0L != (global::Infragistics.Controls.Editors.Primitives.MaskedInputStates.FirstEditSection & statesToQuery))
			{
				if (this.FirstEditSection != null && this.CurrentSection == this.FirstEditSection)
				{
					maskedInputStates |= global::Infragistics.Controls.Editors.Primitives.MaskedInputStates.FirstEditSection;
				}
				else if (this.IsRightToLeft(this.FirstEditSection) && this.FirstEditSection.LastDisplayChar.NextDisplayChar == this.GetCurrentDisplayChar())
				{
					maskedInputStates |= global::Infragistics.Controls.Editors.Primitives.MaskedInputStates.FirstEditSection;
				}
			}
			if ((global::Infragistics.Controls.Editors.Primitives.MaskedInputStates)0L != (global::Infragistics.Controls.Editors.Primitives.MaskedInputStates.LastEditSection & statesToQuery) && this.LastEditSection != null && this.CurrentSection == this.LastEditSection)
			{
				maskedInputStates |= global::Infragistics.Controls.Editors.Primitives.MaskedInputStates.LastEditSection;
			}
			if ((global::Infragistics.Controls.Editors.Primitives.MaskedInputStates)0L != (global::Infragistics.Controls.Editors.Primitives.MaskedInputStates.FirstCharacter & statesToQuery) && this.FirstSection != null && this.GetCurrentDisplayChar() == this.FirstSection.FirstDisplayChar)
			{
				maskedInputStates |= global::Infragistics.Controls.Editors.Primitives.MaskedInputStates.FirstCharacter;
			}
			if ((global::Infragistics.Controls.Editors.Primitives.MaskedInputStates)0L != (global::Infragistics.Controls.Editors.Primitives.MaskedInputStates.LastCharacter & statesToQuery) && this.LastSection != null && this.GetCurrentDisplayChar() == this.LastSection.LastDisplayChar)
			{
				maskedInputStates |= global::Infragistics.Controls.Editors.Primitives.MaskedInputStates.LastCharacter;
			}
			if ((global::Infragistics.Controls.Editors.Primitives.MaskedInputStates)0L != (global::Infragistics.Controls.Editors.Primitives.MaskedInputStates.FirstCharacterInSection & statesToQuery) && this.CurrentSection != null && this.CurrentSection.FirstDisplayChar == this.GetCurrentDisplayChar())
			{
				maskedInputStates |= global::Infragistics.Controls.Editors.Primitives.MaskedInputStates.FirstCharacterInSection;
			}
			if ((global::Infragistics.Controls.Editors.Primitives.MaskedInputStates)0L != (global::Infragistics.Controls.Editors.Primitives.MaskedInputStates.LastCharacterInSection & statesToQuery) && this.CurrentSection != null && this.CurrentSection.LastDisplayChar == this.GetCurrentDisplayChar())
			{
				maskedInputStates |= global::Infragistics.Controls.Editors.Primitives.MaskedInputStates.LastCharacterInSection;
			}
			if ((global::Infragistics.Controls.Editors.Primitives.MaskedInputStates)0L != (global::Infragistics.Controls.Editors.Primitives.MaskedInputStates.FirstSection & statesToQuery) && (global::Infragistics.Controls.Editors.Primitives.MaskedInputStates)0L == (maskedInputStates & global::Infragistics.Controls.Editors.Primitives.MaskedInputStates.FirstSection))
			{
				global::Infragistics.Controls.Editors.DisplayCharBase currentDisplayChar = this.GetCurrentDisplayChar();
				if (currentDisplayChar != null && currentDisplayChar.PrevDisplayChar != null)
				{
					global::Infragistics.Controls.Editors.SectionBase section = currentDisplayChar.PrevDisplayChar.Section;
					if (section != null && section.PreviousSection == null && this.IsRightToLeft(section))
					{
						maskedInputStates |= global::Infragistics.Controls.Editors.Primitives.MaskedInputStates.FirstSection;
					}
				}
			}
			if ((global::Infragistics.Controls.Editors.Primitives.MaskedInputStates)0L != (global::Infragistics.Controls.Editors.Primitives.MaskedInputStates.NextSectionFraction & statesToQuery) && this.CurrentSection != null && this.CurrentSection.NextEditSection is global::Infragistics.Controls.Editors.FractionPart)
			{
				maskedInputStates |= global::Infragistics.Controls.Editors.Primitives.MaskedInputStates.NextSectionFraction;
			}
			if ((global::Infragistics.Controls.Editors.Primitives.MaskedInputStates)0L != (global::Infragistics.Controls.Editors.Primitives.MaskedInputStates.CanSpinUp & statesToQuery) && this.CanSpin(true))
			{
				maskedInputStates |= global::Infragistics.Controls.Editors.Primitives.MaskedInputStates.CanSpinUp;
			}
			if ((global::Infragistics.Controls.Editors.Primitives.MaskedInputStates)0L != (global::Infragistics.Controls.Editors.Primitives.MaskedInputStates.CanSpinDown & statesToQuery) && this.CanSpin(false))
			{
				maskedInputStates |= global::Infragistics.Controls.Editors.Primitives.MaskedInputStates.CanSpinDown;
			}
			if ((global::Infragistics.Controls.Editors.Primitives.MaskedInputStates)0L != (global::Infragistics.Controls.Editors.Primitives.MaskedInputStates.CanUndo & statesToQuery) && this.HasUndoHistory && this.KeepHistory)
			{
				maskedInputStates |= global::Infragistics.Controls.Editors.Primitives.MaskedInputStates.CanUndo;
			}
			if ((global::Infragistics.Controls.Editors.Primitives.MaskedInputStates)0L != (global::Infragistics.Controls.Editors.Primitives.MaskedInputStates.CanRedo & statesToQuery) && this.HasRedoHistory && this.KeepHistory)
			{
				maskedInputStates |= global::Infragistics.Controls.Editors.Primitives.MaskedInputStates.CanRedo;
			}
			if ((global::Infragistics.Controls.Editors.Primitives.MaskedInputStates)0L != (global::Infragistics.Controls.Editors.Primitives.MaskedInputStates.IsReadOnly & statesToQuery) && this.ReadOnly)
			{
				maskedInputStates |= global::Infragistics.Controls.Editors.Primitives.MaskedInputStates.IsReadOnly;
			}
			if (maskedInput != null)
			{
				if ((global::Infragistics.Controls.Editors.Primitives.MaskedInputStates)0L != (global::Infragistics.Controls.Editors.Primitives.MaskedInputStates.TabBySections & statesToQuery) && global::Infragistics.Controls.Editors.MaskedEditTabNavigation.NextSection == maskedInput.SectionTabNavigationResolved)
				{
					maskedInputStates |= global::Infragistics.Controls.Editors.Primitives.MaskedInputStates.TabBySections;
				}
				if ((global::Infragistics.Controls.Editors.Primitives.MaskedInputStates)0L != ((global::Infragistics.Controls.Editors.Primitives.MaskedInputStates.HasDropDown | global::Infragistics.Controls.Editors.Primitives.MaskedInputStates.IsDropDownOpen) & statesToQuery) && maskedInput.HasDropDown)
				{
					maskedInputStates |= global::Infragistics.Controls.Editors.Primitives.MaskedInputStates.HasDropDown;
					if (maskedInput.HasOpenDropDown)
					{
						maskedInputStates |= global::Infragistics.Controls.Editors.Primitives.MaskedInputStates.IsDropDownOpen;
					}
				}
			}
			return maskedInputStates;
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000B5 RID: 181 RVA: 0x00004F5E File Offset: 0x0000315E
		internal global::Infragistics.Controls.Editors.Primitives.MaskedInputStates CurrentState
		{
			get
			{
				return this.GetCurrentState((global::Infragistics.Controls.Editors.Primitives.MaskedInputStates)((ulong)-1));
			}
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00004F68 File Offset: 0x00003168
		internal bool ValidateChangeSection(global::Infragistics.Controls.Editors.SectionBase from, global::Infragistics.Controls.Editors.SectionBase to)
		{
			global::Infragistics.Controls.Editors.EditSectionBase editSectionBase = from as global::Infragistics.Controls.Editors.EditSectionBase;
			if (editSectionBase != null)
			{
				editSectionBase.ValidateSection();
			}
			return true;
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00004F87 File Offset: 0x00003187
		internal bool ValidateAllSections()
		{
			return this.ValidateAllSections(false);
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00004F90 File Offset: 0x00003190
		internal bool ValidateAllSections(bool loosingFocus)
		{
			if (!this.IsInitialized)
			{
				return false;
			}
			string text = this.GetText(global::Infragistics.Controls.Editors.InputMaskMode.IncludeBoth);
			bool result;
			try
			{
				result = global::Infragistics.Controls.Editors.XamMaskedInput.ValidateAllSections(this.Sections, loosingFocus);
			}
			finally
			{
				string text2 = this.GetText(global::Infragistics.Controls.Editors.InputMaskMode.IncludeBoth);
				if (text != text2)
				{
					this.OnTextChanged(false, null, true, null);
				}
			}
			return result;
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000B9 RID: 185 RVA: 0x00004FF4 File Offset: 0x000031F4
		internal bool IsAnyTextSelected
		{
			get
			{
				return this.CaretPosition != this.PivotPosition;
			}
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00005008 File Offset: 0x00003208
		internal bool IsCaretPositionInSelection(int caretPos)
		{
			int selectionStart = this.SelectionStart;
			int selectionLength = this.SelectionLength;
			return caretPos >= selectionStart && caretPos <= selectionStart + selectionLength;
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00005034 File Offset: 0x00003234
		internal bool IsDisplayCharSelected(global::Infragistics.Controls.Editors.DisplayCharBase dc)
		{
			int overallIndexInEdit = dc.OverallIndexInEdit;
			int selectionStart = this.SelectionStart;
			int num = this.SelectionStart + this.SelectionLength - 1;
			return selectionStart <= overallIndexInEdit && overallIndexInEdit <= num;
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000BC RID: 188 RVA: 0x0000506C File Offset: 0x0000326C
		internal bool IsAfterLastCharacter
		{
			get
			{
				return this.CaretPosition >= this.GetTotalNumberOfDisplayChars();
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000BD RID: 189 RVA: 0x0000507F File Offset: 0x0000327F
		internal bool IsAtFirstChar
		{
			get
			{
				return 0 == this.CaretPosition;
			}
		}

		// Token: 0x060000BE RID: 190 RVA: 0x0000508C File Offset: 0x0000328C
		internal bool DeleteWithoutShiftingAcrrossSectionBoundaries()
		{
			if (!this.CanDelete())
			{
				return false;
			}
			if (!this.IsAnyTextSelected)
			{
				global::Infragistics.Controls.Editors.DisplayCharBase currentDisplayChar = this.GetCurrentDisplayChar();
				global::Infragistics.Controls.Editors.EditSectionBase editSectionBase = currentDisplayChar.Section as global::Infragistics.Controls.Editors.EditSectionBase;
				return editSectionBase != null && editSectionBase.DeleteCharAndShift(currentDisplayChar.Index);
			}
			int selectionStart = this.SelectionStart;
			int selectionLength = this.SelectionLength;
			int num = selectionStart + selectionLength - 1;
			bool flag = true;
			for (int i = 0; i < this.Sections.Count; i++)
			{
				global::Infragistics.Controls.Editors.EditSectionBase editSectionBase2 = this.Sections[i] as global::Infragistics.Controls.Editors.EditSectionBase;
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
						global::Infragistics.Controls.Editors.DisplayCharBase displayCharAtPosition = this.GetDisplayCharAtPosition(num2);
						if (displayCharAtPosition != null)
						{
							if (this.IsRightToLeft(editSectionBase2) || editSectionBase2 is global::Infragistics.Controls.Editors.FractionPart)
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
					global::Infragistics.Controls.Editors.SectionBase sectionContainingPosition = this.GetSectionContainingPosition(selectionStart);
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

		// Token: 0x060000BF RID: 191 RVA: 0x00005284 File Offset: 0x00003484
		private bool InsertCharAtShiftGlobalHelper(char c, int from, int to)
		{
			if (from == to)
			{
				global::Infragistics.Controls.Editors.DisplayCharBase displayCharAtPosition = this.GetDisplayCharAtPosition(from);
				if (displayCharAtPosition == null || !displayCharAtPosition.IsEmpty || !displayCharAtPosition.MatchChar(c))
				{
					return false;
				}
				displayCharAtPosition.Char = c;
			}
			bool flag = false;
			for (int i = to; i >= from; i--)
			{
				global::Infragistics.Controls.Editors.DisplayCharBase displayCharAtPosition2 = this.GetDisplayCharAtPosition(i);
				if (displayCharAtPosition2.IsEmpty)
				{
					flag = true;
					to = i;
					break;
				}
			}
			if (!flag || from == to)
			{
				global::Infragistics.Controls.Editors.DisplayCharBase displayCharAtPosition = this.GetDisplayCharAtPosition(from);
				if (displayCharAtPosition == null || !displayCharAtPosition.IsEmpty || !displayCharAtPosition.MatchChar(c))
				{
					return false;
				}
				displayCharAtPosition.Char = c;
			}
			int num = 1;
			for (int j = to - 1; j >= from; j--)
			{
				global::Infragistics.Controls.Editors.DisplayCharBase displayCharAtPosition3 = this.GetDisplayCharAtPosition(j);
				global::Infragistics.Controls.Editors.DisplayCharBase displayCharAtPosition4 = this.GetDisplayCharAtPosition(j + num);
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
				global::Infragistics.Controls.Editors.DisplayCharBase displayCharAtPosition5 = this.GetDisplayCharAtPosition(k);
				global::Infragistics.Controls.Editors.DisplayCharBase displayCharAtPosition6 = this.GetDisplayCharAtPosition(k + num);
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

		// Token: 0x060000C0 RID: 192 RVA: 0x00005458 File Offset: 0x00003658
		private bool InsertCharAtShiftGlobal(char c, int pos)
		{
			global::Infragistics.Controls.Editors.DisplayCharBase displayCharAtPosition = this.GetDisplayCharAtPosition(pos);
			if (displayCharAtPosition == null || this.IsRightToLeft(displayCharAtPosition.Section))
			{
				return false;
			}
			if (displayCharAtPosition == null || displayCharAtPosition.Section is global::Infragistics.Controls.Editors.FractionPart)
			{
				return false;
			}
			int totalNumberOfDisplayChars = this.GetTotalNumberOfDisplayChars();
			if (pos < 0 || pos >= totalNumberOfDisplayChars)
			{
				return false;
			}
			global::Infragistics.Controls.Editors.DisplayCharBase displayCharBase = null;
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

		// Token: 0x060000C1 RID: 193 RVA: 0x000054ED File Offset: 0x000036ED
		internal bool CanDelete()
		{
			return this.CanDelete(false);
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x000054F8 File Offset: 0x000036F8
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
			global::Infragistics.Controls.Editors.DisplayCharBase currentDisplayChar = this.GetCurrentDisplayChar();
			return currentDisplayChar != null && (currentDisplayChar.Section is global::Infragistics.Controls.Editors.EditSectionBase || emulateDeleteKey);
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x0000553C File Offset: 0x0000373C
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
				global::Infragistics.Controls.Editors.DisplayCharBase displayCharAtPosition = this.GetDisplayCharAtPosition(num3);
				global::Infragistics.Controls.Editors.DisplayCharBase displayCharAtPosition2 = this.GetDisplayCharAtPosition(num3 + positionsToShift);
				global::Infragistics.Controls.Editors.EditSectionBase editSectionBase = displayCharAtPosition.Section as global::Infragistics.Controls.Editors.EditSectionBase;
				if (displayCharAtPosition != null && editSectionBase != null && global::Infragistics.Controls.Editors.EditOrientation.RightToLeft == editSectionBase.Orientation)
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
					int num4 = 0;
					while (displayCharAtPosition2 != null && !displayCharAtPosition2.IsEditable)
					{
						num4++;
						displayCharAtPosition2 = this.GetDisplayCharAtPosition(num3 + positionsToShift + num4);
					}
					positionsToShift += num4;
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

		// Token: 0x060000C4 RID: 196 RVA: 0x00005668 File Offset: 0x00003868
		internal void SetPivot()
		{
			this.PivotPosition = this.CaretPosition;
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00005676 File Offset: 0x00003876
		internal bool Delete()
		{
			return this.Delete(false, false);
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00005680 File Offset: 0x00003880
		internal bool Delete(bool emulateDeleteKey, bool fireTextChanged)
		{
			global::Infragistics.Controls.Editors.EditInfo.EditorValueSnapshot editorValueSnapshot = null;
			if (fireTextChanged)
			{
				editorValueSnapshot = this.GetValueSnapshot();
			}
			bool result = this.DeleteHelper(emulateDeleteKey);
			if (fireTextChanged && !editorValueSnapshot.IsCurrentValueSame(this))
			{
				this.OnTextChanged(true, null, true, null);
			}
			return result;
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x000056C0 File Offset: 0x000038C0
		private bool DeleteHelper(bool emulateDeleteKey)
		{
			if (this.ReadOnly)
			{
				return false;
			}
			if (!this.MaskedInput.AllowShiftingAcrossSections)
			{
				return this.DeleteWithoutShiftingAcrrossSectionBoundaries();
			}
			if (!this.IsAnyTextSelected)
			{
				if (this.CanDelete(emulateDeleteKey))
				{
					global::Infragistics.Controls.Editors.DisplayCharBase currentDisplayChar = this.GetCurrentDisplayChar();
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
						global::Infragistics.Controls.Editors.EditSectionBase editSectionBase = currentDisplayChar.Section as global::Infragistics.Controls.Editors.EditSectionBase;
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
				global::Infragistics.Controls.Editors.DisplayCharBase displayCharAtPosition = this.GetDisplayCharAtPosition(selectionStart);
				global::Infragistics.Controls.Editors.EditSectionBase editSectionBase2 = displayCharAtPosition.Section as global::Infragistics.Controls.Editors.EditSectionBase;
				if (this.InsertMode && displayCharAtPosition != null && editSectionBase2 != null && this.IsRightToLeft(editSectionBase2))
				{
					displayCharAtPosition = this.GetDisplayCharAtPosition(global::System.Math.Min(num, editSectionBase2.LastDisplayChar.OverallIndexInEdit));
					if (displayCharAtPosition != null)
					{
						editSectionBase2 = (displayCharAtPosition.Section as global::Infragistics.Controls.Editors.EditSectionBase);
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
								global::Infragistics.Controls.Editors.EditSectionBase editSectionBase3 = displayCharAtPosition.Section as global::Infragistics.Controls.Editors.EditSectionBase;
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

		// Token: 0x060000C8 RID: 200 RVA: 0x00005932 File Offset: 0x00003B32
		private void GotoSection(global::Infragistics.Controls.Editors.SectionBase section)
		{
			this.GotoSection(section, false);
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x0000593C File Offset: 0x00003B3C
		private void GotoSection(global::Infragistics.Controls.Editors.SectionBase section, bool positionToRight)
		{
			this.GotoSection(section, positionToRight, true);
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00005948 File Offset: 0x00003B48
		private void GotoSection(global::Infragistics.Controls.Editors.SectionBase section, bool positionToRight, bool positionRightAfterLastCharacter)
		{
			if (section == null)
			{
				return;
			}
			if (section != this.CurrentSection && !this.ValidateChangeSection(this.CurrentSection, section))
			{
				return;
			}
			global::Infragistics.Controls.Editors.EditSectionBase editSectionBase = section as global::Infragistics.Controls.Editors.EditSectionBase;
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

		// Token: 0x060000CB RID: 203 RVA: 0x000059F0 File Offset: 0x00003BF0
		internal void GotoNextChar()
		{
			if (this.IsAfterLastCharacter)
			{
				string @string = global::Infragistics.Controls.Editors.ValueInput.GetString("IllegalOperationMessageAtLastCharacter");
				this.IllegalOperation(@string);
				return;
			}
			global::Infragistics.Controls.Editors.DisplayCharBase currentDisplayChar = this.GetCurrentDisplayChar();
			global::Infragistics.Controls.Editors.DisplayCharBase displayCharAtPosition = this.GetDisplayCharAtPosition(this.CaretPosition + 1);
			if (currentDisplayChar != null && displayCharAtPosition != null && currentDisplayChar.Section != displayCharAtPosition.Section)
			{
				global::Infragistics.Controls.Editors.SectionBase section = currentDisplayChar.Section;
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

		// Token: 0x060000CC RID: 204 RVA: 0x00005A9C File Offset: 0x00003C9C
		internal int SkipDisplayCharsWithEmptyDrawString(int caretPos)
		{
			for (;;)
			{
				global::Infragistics.Controls.Editors.DisplayCharBase displayCharAtPosition = this.GetDisplayCharAtPosition(caretPos);
				if (displayCharAtPosition == null || !displayCharAtPosition.IsEmpty || displayCharAtPosition.GetDrawChar() != '\0')
				{
					break;
				}
				caretPos++;
			}
			return caretPos;
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00005ACC File Offset: 0x00003CCC
		internal void GotoPrevEditSection()
		{
			global::Infragistics.Controls.Editors.SectionBase sectionBase = (this.CurrentSection != null) ? this.CurrentSection : this.LastSection;
			global::Infragistics.Controls.Editors.DisplayCharBase displayCharAtPosition = this.GetDisplayCharAtPosition(this.CaretPosition - 1);
			if (displayCharAtPosition != null)
			{
				global::Infragistics.Controls.Editors.EditSectionBase editSectionBase = displayCharAtPosition.Section as global::Infragistics.Controls.Editors.EditSectionBase;
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
			string @string = global::Infragistics.Controls.Editors.ValueInput.GetString("IllegalOperationMessageNoPrevEditSection");
			this.IllegalOperation(@string);
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00005B74 File Offset: 0x00003D74
		internal void GotoNextEditSection()
		{
			global::Infragistics.Controls.Editors.SectionBase currentSection = this.CurrentSection;
			if (currentSection == null)
			{
				string @string = global::Infragistics.Controls.Editors.ValueInput.GetString("IllegalOperationMessageNoNextEditSection");
				this.IllegalOperation(@string);
				return;
			}
			if (currentSection.NextEditSection != null)
			{
				this.GotoSection(currentSection.NextEditSection, false);
				return;
			}
			string string2 = global::Infragistics.Controls.Editors.ValueInput.GetString("IllegalOperationMessageNoNextEditSection");
			this.IllegalOperation(string2);
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000CF RID: 207 RVA: 0x00005BC6 File Offset: 0x00003DC6
		private global::System.Collections.Generic.Stack<global::Infragistics.Controls.Editors.EditInfo.EditorSnapshot> UndoHistory
		{
			get
			{
				if (this._undoHistory == null)
				{
					this._undoHistory = new global::System.Collections.Generic.Stack<global::Infragistics.Controls.Editors.EditInfo.EditorSnapshot>();
				}
				return this._undoHistory;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000D0 RID: 208 RVA: 0x00005BE1 File Offset: 0x00003DE1
		private global::System.Collections.Generic.Stack<global::Infragistics.Controls.Editors.EditInfo.EditorSnapshot> RedoHistory
		{
			get
			{
				if (this._redoHistory == null)
				{
					this._redoHistory = new global::System.Collections.Generic.Stack<global::Infragistics.Controls.Editors.EditInfo.EditorSnapshot>();
				}
				return this._redoHistory;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000D1 RID: 209 RVA: 0x00005BFC File Offset: 0x00003DFC
		private bool HasUndoHistory
		{
			get
			{
				return this._undoHistory != null && this._undoHistory.Count >= 2;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000D2 RID: 210 RVA: 0x00005C19 File Offset: 0x00003E19
		private bool HasRedoHistory
		{
			get
			{
				return this._redoHistory != null && this._redoHistory.Count > 0;
			}
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00005C34 File Offset: 0x00003E34
		internal void ManageUndoHistory_TextChanged(bool viaUserAction, global::Infragistics.Controls.Editors.Primitives.MaskedInputCommandId? command)
		{
			if (!this._inUndoRedoHelper && (command == null || (global::Infragistics.Controls.Editors.Primitives.MaskedInputCommandId.Undo != command.Value && global::Infragistics.Controls.Editors.Primitives.MaskedInputCommandId.Redo != command.Value)))
			{
				this.ClearRedoHistory();
				if (!viaUserAction)
				{
					this.ClearUndoHistory();
				}
				if (this.KeepHistory)
				{
					this.UndoHistory.Push(new global::Infragistics.Controls.Editors.EditInfo.EditorSnapshot(this));
				}
			}
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00005C90 File Offset: 0x00003E90
		internal void Undo(bool fireValueChanged)
		{
			this.UndoRedoHelper(true, fireValueChanged);
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00005C9A File Offset: 0x00003E9A
		internal void Redo(bool fireValueChanged)
		{
			this.UndoRedoHelper(false, fireValueChanged);
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00005CA4 File Offset: 0x00003EA4
		internal void UndoRedoHelper(bool undo, bool fireValueChanged)
		{
			if (this._inUndoRedoHelper)
			{
				return;
			}
			this._inUndoRedoHelper = true;
			try
			{
				global::Infragistics.Controls.Editors.EditInfo.EditorValueSnapshot valueSnapshot = this.GetValueSnapshot();
				try
				{
					global::System.Collections.Generic.Stack<global::Infragistics.Controls.Editors.EditInfo.EditorSnapshot> stack = undo ? this._undoHistory : this._redoHistory;
					if (stack != null && stack.Count >= 2 && this.KeepHistory)
					{
						global::Infragistics.Controls.Editors.EditInfo.EditorSnapshot editorSnapshot = stack.Pop();
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
						this.OnTextChanged(true, null, true, null);
					}
				}
			}
			finally
			{
				this._inUndoRedoHelper = false;
			}
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00005D68 File Offset: 0x00003F68
		internal void ClearRedoHistory()
		{
			this._redoHistory = null;
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00005D71 File Offset: 0x00003F71
		internal void ClearUndoHistory()
		{
			this._undoHistory = null;
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00005D7C File Offset: 0x00003F7C
		internal void GotoPrevChar()
		{
			if (this.IsAfterLastCharacter)
			{
				global::Infragistics.Controls.Editors.EditSectionBase editSectionBase = this.LastSection as global::Infragistics.Controls.Editors.EditSectionBase;
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
					string @string = global::Infragistics.Controls.Editors.ValueInput.GetString("IllegalOperationMessageNoPrevCharacter");
					this.IllegalOperation(@string);
					return;
				}
				global::Infragistics.Controls.Editors.DisplayCharBase currentDisplayChar = this.GetCurrentDisplayChar();
				global::Infragistics.Controls.Editors.DisplayCharBase displayCharAtPosition = this.GetDisplayCharAtPosition(this.CaretPosition - 1);
				if (currentDisplayChar == null || displayCharAtPosition == null || currentDisplayChar.Section != displayCharAtPosition.Section)
				{
					if (currentDisplayChar != null && displayCharAtPosition != null)
					{
						global::Infragistics.Controls.Editors.EditSectionBase editSectionBase2 = displayCharAtPosition.Section as global::Infragistics.Controls.Editors.EditSectionBase;
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
							string string2 = global::Infragistics.Controls.Editors.ValueInput.GetString("IllegalOperationMessageCannotMoveToPrevCharacter");
							this.IllegalOperation(string2);
						}
					}
					return;
				}
				global::Infragistics.Controls.Editors.EditSectionBase editSectionBase3 = currentDisplayChar.Section as global::Infragistics.Controls.Editors.EditSectionBase;
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

		// Token: 0x060000DA RID: 218 RVA: 0x00005F4C File Offset: 0x0000414C
		internal bool ExecuteCommandImpl(global::Infragistics.Controls.Editors.Primitives.MaskedInputCommandId command, object commandParameter, bool shift, bool control, global::System.Windows.FrameworkElement sourceElement)
		{
			bool flag = false;
			bool flag2 = false;
			global::Infragistics.Controls.Editors.SectionBase currentSection = this.GetCurrentSection(true);
			if (!this.IsInitialized || this.MaskInfo.DesignMode)
			{
				return false;
			}
			global::Infragistics.Controls.Editors.EditInfo.EditorValueSnapshot valueSnapshot = this.GetValueSnapshot();
			global::Infragistics.Controls.Editors.XamMaskedInput maskedInput = this.MaskedInput;
			if (command != global::Infragistics.Controls.Editors.Primitives.MaskedInputCommandId.NotACommand)
			{
				this.IsBackspaceInvalidOperation = false;
				this.IsBackspaceOperation = (global::Infragistics.Controls.Editors.Primitives.MaskedInputCommandId.Backspace == command);
			}
			if (global::Infragistics.Controls.Editors.Primitives.MaskedInputCommandId.SetPivot == command)
			{
				this.SetPivot();
				flag2 = true;
			}
			else if (global::Infragistics.Controls.Editors.Primitives.MaskedInputCommandId.Backspace == command)
			{
				if (!this.ReadOnly)
				{
					global::Infragistics.Controls.Editors.DisplayCharBase displayCharBase = this.GetCurrentDisplayChar();
					global::Infragistics.Controls.Editors.DisplayCharBase displayCharAtPosition = this.GetDisplayCharAtPosition(this.CaretPosition - 1);
					if (this.IsAnyTextSelected)
					{
						if (!this.Delete())
						{
							string @string = global::Infragistics.Controls.Editors.ValueInput.GetString("IllegalOperationMessageCannotDelete");
							this.IllegalOperation(@string);
						}
					}
					else if (this.IsAfterLastCharacter)
					{
						global::Infragistics.Controls.Editors.EditSectionBase editSectionBase = this.LastSection as global::Infragistics.Controls.Editors.EditSectionBase;
						if (this.IsRightToLeft(editSectionBase) && this.InsertMode)
						{
							displayCharBase = editSectionBase.LastDisplayChar;
							if (!displayCharBase.IsEmpty)
							{
								if (editSectionBase != null && !editSectionBase.DeleteCharAndShift(displayCharBase.Index))
								{
									string string2 = global::Infragistics.Controls.Editors.ValueInput.GetString("IllegalOperationMessageGeneral");
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
								string string3 = global::Infragistics.Controls.Editors.ValueInput.GetString("IllegalOperationMessageNoPrevEditableCharacter");
								this.IllegalOperation(string3);
							}
						}
						else
						{
							displayCharBase = this.GetDisplayCharAtPosition(this.CaretPosition - 1);
							editSectionBase = (displayCharBase.Section as global::Infragistics.Controls.Editors.EditSectionBase);
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
						string string4 = global::Infragistics.Controls.Editors.ValueInput.GetString("IllegalOperationMessageNoPrevCharacter");
						this.IllegalOperation(string4);
					}
					else if (displayCharBase != null)
					{
						global::Infragistics.Controls.Editors.EditSectionBase editSectionBase = displayCharBase.Section as global::Infragistics.Controls.Editors.EditSectionBase;
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
									string string5 = global::Infragistics.Controls.Editors.ValueInput.GetString("IllegalOperationMessageGeneral");
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
								string string6 = global::Infragistics.Controls.Editors.ValueInput.GetString("IllegalOperationMessageNoPrevEditableCharacter");
								this.IllegalOperation(string6);
								this.IsBackspaceInvalidOperation = true;
							}
						}
						else if (this.IsAtFirstChar)
						{
							string string7 = global::Infragistics.Controls.Editors.ValueInput.GetString("IllegalOperationMessageNoPrevCharacter");
							this.IllegalOperation(string7);
						}
						else
						{
							displayCharBase = this.GetDisplayCharAtPosition(this.CaretPosition - 1);
							editSectionBase = (displayCharBase.Section as global::Infragistics.Controls.Editors.EditSectionBase);
							if (editSectionBase != null)
							{
								if (this.IsRightToLeft(editSectionBase) && this.InsertMode)
								{
									if (!displayCharBase.IsEmpty)
									{
										editSectionBase = (displayCharBase.Section as global::Infragistics.Controls.Editors.EditSectionBase);
										if (!editSectionBase.DeleteCharAndShift(displayCharBase.Index))
										{
											string string8 = global::Infragistics.Controls.Editors.ValueInput.GetString("IllegalOperationMessageGeneral");
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
										string string9 = global::Infragistics.Controls.Editors.ValueInput.GetString("IllegalOperationMessageNoPrevEditableCharacter");
										this.IllegalOperation(string9);
										this.IsBackspaceInvalidOperation = true;
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
					if (this.CurrentSection != null && this.CurrentSection.NextEditSection is global::Infragistics.Controls.Editors.FractionPartContinuous)
					{
						this.EnsureNumberSectionState();
					}
					flag = true;
				}
			}
			else if (global::Infragistics.Controls.Editors.Primitives.MaskedInputCommandId.Delete == command)
			{
				if (!this.ReadOnly)
				{
					if (!this.Delete(true, false))
					{
						string string10 = global::Infragistics.Controls.Editors.ValueInput.GetString("IllegalOperationMessageGeneral");
						this.IllegalOperation(string10);
					}
					flag = true;
				}
			}
			else if (global::Infragistics.Controls.Editors.Primitives.MaskedInputCommandId.FirstCharacter == command)
			{
				global::Infragistics.Controls.Editors.SectionBase firstSection = this.FirstSection;
				if (global::System.Windows.Input.ModifierKeys.None == (global::Infragistics.Controls.PresentationUtilities.GetCurrentModifierKeys() & global::System.Windows.Input.ModifierKeys.Shift) && this.IsRightToLeft(firstSection) && this.InsertMode)
				{
					global::Infragistics.Controls.Editors.EditSectionBase editSectionBase = firstSection as global::Infragistics.Controls.Editors.EditSectionBase;
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
			else if (global::Infragistics.Controls.Editors.Primitives.MaskedInputCommandId.AfterLastCharacter == command)
			{
				this.CaretPosition = this.GetTotalNumberOfDisplayChars();
				flag2 = true;
			}
			else if (global::Infragistics.Controls.Editors.Primitives.MaskedInputCommandId.NextCharacter == command)
			{
				this.GotoNextChar();
				flag2 = true;
			}
			else if (global::Infragistics.Controls.Editors.Primitives.MaskedInputCommandId.PreviousCharacter == command)
			{
				this.GotoPrevChar();
				if (this.CurrentSection != null && this.CurrentSection.NextEditSection is global::Infragistics.Controls.Editors.FractionPartContinuous)
				{
					this.EnsureNumberSectionState();
				}
				flag2 = true;
			}
			else if (global::Infragistics.Controls.Editors.Primitives.MaskedInputCommandId.NextSection == command)
			{
				this.GotoNextEditSection();
				flag2 = true;
			}
			else if (global::Infragistics.Controls.Editors.Primitives.MaskedInputCommandId.PreviousSection == command)
			{
				this.GotoPrevEditSection();
				if (this.CurrentSection != null && this.CurrentSection.NextEditSection is global::Infragistics.Controls.Editors.FractionPartContinuous)
				{
					this.EnsureNumberSectionState();
				}
				flag2 = true;
			}
			else if (global::Infragistics.Controls.Editors.Primitives.MaskedInputCommandId.SpinUp == command || global::Infragistics.Controls.Editors.Primitives.MaskedInputCommandId.SpinDown == command)
			{
				if (!this.ReadOnly)
				{
					if (sourceElement != null && !maskedInput.IsInEditMode && global::Infragistics.Controls.Editors.Primitives.Utils.GetAncestorFromName(sourceElement, "PART_SpinButtons", null) != null)
					{
						maskedInput.SetFocusToFocusSite();
					}
					this.Spin(global::Infragistics.Controls.Editors.Primitives.MaskedInputCommandId.SpinUp == command, commandParameter, false, false);
					flag = true;
				}
			}
			else if (global::Infragistics.Controls.Editors.Primitives.MaskedInputCommandId.ToggleInsertionMode == command)
			{
				this.ToggleInsertMode();
			}
			else if (global::Infragistics.Controls.Editors.Primitives.MaskedInputCommandId.SelectSection == command)
			{
				global::Infragistics.Controls.Editors.EditSectionBase editSectionBase = this.CurrentSection as global::Infragistics.Controls.Editors.EditSectionBase;
				if (editSectionBase != null && editSectionBase.FirstFilledChar != null)
				{
					this.CaretPosition = editSectionBase.FirstFilledChar.OverallIndexInEdit;
					this.PivotPosition = 1 + editSectionBase.LastFilledChar.OverallIndexInEdit;
					flag2 = true;
				}
			}
			else if (global::Infragistics.Controls.Editors.Primitives.MaskedInputCommandId.SelectAll == command)
			{
				this.SelectAll();
			}
			else if (global::Infragistics.Controls.Editors.Primitives.MaskedInputCommandId.Copy == command)
			{
				this.Copy();
			}
			else if (global::Infragistics.Controls.Editors.Primitives.MaskedInputCommandId.Cut == command)
			{
				this.Cut(false);
				flag = true;
			}
			else if (global::Infragistics.Controls.Editors.Primitives.MaskedInputCommandId.Paste == command)
			{
				this.Paste(false);
				flag = true;
			}
			else if (global::Infragistics.Controls.Editors.Primitives.MaskedInputCommandId.Undo == command)
			{
				this.Undo(false);
			}
			else if (global::Infragistics.Controls.Editors.Primitives.MaskedInputCommandId.Redo == command)
			{
				this.Redo(false);
			}
			else if (global::Infragistics.Controls.Editors.Primitives.MaskedInputCommandId.ToggleDropDown == command)
			{
				global::Infragistics.Controls.Editors.XamMaskedInput maskedInput2 = this.MaskedInput;
				if (maskedInput2 != null)
				{
					maskedInput2.ToggleDropDown();
				}
			}
			global::Infragistics.Controls.Editors.SectionBase currentSection2 = this.GetCurrentSection(true);
			if (currentSection2 != null && currentSection != null && currentSection != currentSection2)
			{
				global::Infragistics.Controls.Editors.EditSectionBase editSectionBase2 = currentSection as global::Infragistics.Controls.Editors.EditSectionBase;
				if (editSectionBase2 != null)
				{
					editSectionBase2.ValidateSection();
				}
			}
			if (!valueSnapshot.IsCurrentValueSame(this))
			{
				this.OnTextChanged(true, new global::Infragistics.Controls.Editors.Primitives.MaskedInputCommandId?(command), true, valueSnapshot);
			}
			if (flag)
			{
				this.DirtyMaskElement();
			}
			else if (flag2)
			{
				this.DirtyMaskElement();
			}
			if (flag || flag2)
			{
				this.NotifyStateChanged();
			}
			return true;
		}

		// Token: 0x060000DB RID: 219 RVA: 0x000066C4 File Offset: 0x000048C4
		internal bool Spin(bool up, object amount, bool setToLimit, bool fireValueChanged)
		{
			if (!this.CanSpin(up, amount))
			{
				return false;
			}
			string text = null;
			if (fireValueChanged)
			{
				text = this.GetText(global::Infragistics.Controls.Editors.InputMaskMode.IncludeBoth);
			}
			bool result;
			try
			{
				if (this.SelectionStart + this.SelectionLength >= this.GetTotalNumberOfDisplayChars() && this.Sections != null && global::Infragistics.Controls.Editors.XamMaskedInput.IsMaskValidForDataType(typeof(global::System.DateTime), this.Sections))
				{
					string text2 = this.GetText(global::Infragistics.Controls.Editors.InputMaskMode.Raw);
					if (text2 != null)
					{
						if (text2.Length != 0)
						{
							goto IL_7E;
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
				IL_7E:
				global::Infragistics.Controls.Editors.XamMaskedInput maskedInput = this.MaskedInput;
				global::Infragistics.Controls.Editors.Primitives.SpinInfo resolvedSpinInfo = this.GetResolvedSpinInfo(amount);
				if (amount != null || resolvedSpinInfo != null)
				{
					result = (resolvedSpinInfo != null && resolvedSpinInfo.Spin(up));
				}
				else
				{
					global::Infragistics.Controls.Editors.EditSectionBase spinSection = this.GetSpinSection();
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
					string text3 = this.GetText(global::Infragistics.Controls.Editors.InputMaskMode.IncludeBoth);
					if (text3 != null && text != null && global::Infragistics.Controls.Editors.Primitives.Utils.CompareStrings(text, text3, false, null) != 0)
					{
						this.OnTextChanged(true, null, true, null);
					}
				}
			}
			return result;
		}

		// Token: 0x060000DC RID: 220 RVA: 0x000067F0 File Offset: 0x000049F0
		internal global::Infragistics.Controls.Editors.EditSectionBase GetSpinSection()
		{
			global::Infragistics.Controls.Editors.EditSectionBase editSectionBase = this.CurrentSection as global::Infragistics.Controls.Editors.EditSectionBase;
			if (editSectionBase != null && editSectionBase.SupportsSpinning)
			{
				return editSectionBase;
			}
			global::Infragistics.Controls.Editors.DisplayCharBase displayCharAtPosition = this.GetDisplayCharAtPosition(this.CaretPosition - 1);
			if (displayCharAtPosition != null)
			{
				editSectionBase = (displayCharAtPosition.Section as global::Infragistics.Controls.Editors.EditSectionBase);
				if (editSectionBase != null && editSectionBase.SupportsSpinning)
				{
					return editSectionBase;
				}
			}
			return null;
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00006844 File Offset: 0x00004A44
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

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000DE RID: 222 RVA: 0x00006904 File Offset: 0x00004B04
		internal bool ReadOnly
		{
			get
			{
				return this.MaskedInput.IsReadOnly;
			}
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00006911 File Offset: 0x00004B11
		internal bool CanSpin(bool up)
		{
			return this.CanSpin(up, null);
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x0000691C File Offset: 0x00004B1C
		private global::Infragistics.Controls.Editors.Primitives.SpinInfo GetResolvedSpinInfo(object amount)
		{
			global::Infragistics.Controls.Editors.XamMaskedInput maskedInput = this.MaskedInput;
			global::Infragistics.Controls.Editors.Primitives.SpinInfo spinInfo = maskedInput._cachedSpinInfo;
			if ((amount != null || spinInfo != null) && (spinInfo == null || (amount != null && !spinInfo.IsSameSpinIncrement(amount))))
			{
				spinInfo = global::Infragistics.Controls.Editors.Primitives.SpinInfo.Parse(maskedInput, amount);
			}
			return spinInfo;
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00006958 File Offset: 0x00004B58
		internal bool CanSpin(bool up, object amount)
		{
			if (this.ReadOnly)
			{
				return false;
			}
			global::Infragistics.Controls.Editors.XamMaskedInput maskedInput = this.MaskedInput;
			global::Infragistics.Controls.Editors.Primitives.SpinInfo resolvedSpinInfo = this.GetResolvedSpinInfo(amount);
			if (amount != null || resolvedSpinInfo != null)
			{
				return resolvedSpinInfo != null && resolvedSpinInfo.CanSpin(up);
			}
			if (this.Sections != null && global::Infragistics.Controls.Editors.XamMaskedInput.IsMaskValidForDataType(typeof(global::System.DateTime), this.Sections))
			{
				string text = this.GetText(global::Infragistics.Controls.Editors.InputMaskMode.Raw);
				if (text == null || text.Length == 0)
				{
					return true;
				}
			}
			global::Infragistics.Controls.Editors.EditSectionBase spinSection = this.GetSpinSection();
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
			if (this.MaskInfo.MaskedInput.SpinWrap)
			{
				if (spinSection is global::Infragistics.Controls.Editors.YearSection && num != num2)
				{
					return true;
				}
				if (spinSection is global::Infragistics.Controls.Editors.MonthSection && (num != num2 || num3 != num4))
				{
					return true;
				}
				if (spinSection is global::Infragistics.Controls.Editors.DaySection)
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
				global::Infragistics.Controls.Editors.NumberSection numberSection = null;
				if (spinSection is global::Infragistics.Controls.Editors.NumberSection)
				{
					numberSection = (global::Infragistics.Controls.Editors.NumberSection)spinSection;
				}
				else if (spinSection is global::Infragistics.Controls.Editors.FractionPart)
				{
					numberSection = (spinSection.PreviousEditSection as global::Infragistics.Controls.Editors.NumberSection);
				}
				bool flag = true;
				if (numberSection != null && typeof(global::Infragistics.Controls.Editors.NumberSection) == numberSection.GetType())
				{
					if (this.MaskInfo.MaskedInput.SpinWrap)
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
				if (flag && spinSection is global::Infragistics.Controls.Editors.FractionPart)
				{
					if (this.MaskInfo.MaskedInput.SpinWrap)
					{
						return true;
					}
					numberSection = (spinSection.PreviousEditSection as global::Infragistics.Controls.Editors.NumberSection);
					double fractionValue = ((global::Infragistics.Controls.Editors.FractionPart)spinSection).GetFractionValue();
					int num7;
					if (this.InternalCompareNumerical(fractionValue, maxValue, out num7) && num7 >= 0)
					{
						return false;
					}
					return true;
				}
				else
				{
					if (spinSection is global::Infragistics.Controls.Editors.YearSection)
					{
						try
						{
							int num8;
							if (((global::Infragistics.Controls.Editors.YearSection)spinSection).TryGetYear(out num8) && dateTime2 != null && num8 >= calendar.GetYear(dateTime2.Value))
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
					if (spinSection is global::Infragistics.Controls.Editors.MonthSection)
					{
						try
						{
							int num9;
							if (((global::Infragistics.Controls.Editors.MonthSection)spinSection).TryToInt(out num9) && dateTime2 != null && num == num2 && num9 >= calendar.GetYear(dateTime2.Value))
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
					if (!(spinSection is global::Infragistics.Controls.Editors.DaySection))
					{
						return true;
					}
					try
					{
						int num10;
						if (((global::Infragistics.Controls.Editors.DaySection)spinSection).TryToInt(out num10) && dateTime2 != null && num == num2 && num3 == num4 && num10 >= calendar.GetDayOfMonth(dateTime2.Value))
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
				global::Infragistics.Controls.Editors.NumberSection numberSection2 = null;
				if (spinSection is global::Infragistics.Controls.Editors.NumberSection)
				{
					numberSection2 = (global::Infragistics.Controls.Editors.NumberSection)spinSection;
				}
				else if (spinSection is global::Infragistics.Controls.Editors.FractionPart)
				{
					numberSection2 = (spinSection.PreviousEditSection as global::Infragistics.Controls.Editors.NumberSection);
				}
				bool flag2 = true;
				if (numberSection2 != null && typeof(global::Infragistics.Controls.Editors.NumberSection) == numberSection2.GetType())
				{
					if (this.MaskInfo.MaskedInput.SpinWrap)
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
				if (flag2 && spinSection is global::Infragistics.Controls.Editors.FractionPart)
				{
					if (this.MaskInfo.MaskedInput.SpinWrap)
					{
						return true;
					}
					numberSection2 = (spinSection.PreviousEditSection as global::Infragistics.Controls.Editors.NumberSection);
					double fractionValue2 = ((global::Infragistics.Controls.Editors.FractionPart)spinSection).GetFractionValue();
					int num13;
					if (this.InternalCompareNumerical(fractionValue2, minValue, out num13) && num13 <= 0)
					{
						return false;
					}
				}
				else
				{
					if (spinSection is global::Infragistics.Controls.Editors.YearSection)
					{
						try
						{
							int num14;
							if (((global::Infragistics.Controls.Editors.YearSection)spinSection).TryGetYear(out num14) && dateTime != null && num14 <= calendar.GetYear(dateTime.Value))
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
					if (spinSection is global::Infragistics.Controls.Editors.MonthSection)
					{
						try
						{
							int num15;
							if (((global::Infragistics.Controls.Editors.MonthSection)spinSection).TryToInt(out num15) && dateTime != null && num == num2 && num15 <= calendar.GetMonth(dateTime.Value))
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
					if (spinSection is global::Infragistics.Controls.Editors.DaySection)
					{
						try
						{
							int num16;
							if (((global::Infragistics.Controls.Editors.DaySection)spinSection).TryToInt(out num16) && dateTime != null && num == num2 && num3 == num4 && num16 <= calendar.GetDayOfMonth(dateTime.Value))
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

		// Token: 0x060000E2 RID: 226 RVA: 0x00006F04 File Offset: 0x00005104
		internal void IllegalOperation(string message)
		{
			global::Infragistics.Controls.Editors.InvalidOperationEventArgs invalidOperationEventArgs = new global::Infragistics.Controls.Editors.InvalidOperationEventArgs(message);
			this.OnInvalidOperation(invalidOperationEventArgs);
			if (invalidOperationEventArgs.Beep)
			{
				this.MaskInfo.MaskedInput.Beep();
			}
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00006F38 File Offset: 0x00005138
		private void IllegalCharPressed(global::Infragistics.Controls.Editors.DisplayCharBase displayChar, char c)
		{
			global::Infragistics.Controls.Editors.InvalidCharEventArgs invalidCharEventArgs = new global::Infragistics.Controls.Editors.InvalidCharEventArgs(c, displayChar);
			this.OnInvalidChar(invalidCharEventArgs);
			if (invalidCharEventArgs.Beep)
			{
				this.MaskInfo.MaskedInput.Beep();
			}
			this._lastIllegalChar = c;
			this._lastIllegalDisplayChar = displayChar;
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00006F7C File Offset: 0x0000517C
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
				global::Infragistics.Controls.Editors.DisplayCharBase displayCharAtPosition = this.GetDisplayCharAtPosition(num2);
				global::Infragistics.Controls.Editors.EditSectionBase editSectionBase = displayCharAtPosition.Section as global::Infragistics.Controls.Editors.EditSectionBase;
				if (this.InsertMode && this.IsRightToLeft(editSectionBase))
				{
					int num3 = global::System.Math.Min(num - 1, editSectionBase.LastDisplayChar.OverallIndexInEdit);
					global::Infragistics.Controls.Editors.DisplayCharBase displayCharAtPosition2 = this.GetDisplayCharAtPosition(num3);
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

		// Token: 0x060000E5 RID: 229 RVA: 0x00007069 File Offset: 0x00005269
		internal void EraseSelectedText()
		{
			this.GetTotalNumberOfDisplayChars();
			if (this.SelectionLength <= 0)
			{
				return;
			}
			this.EraseDisplayChars(this.SelectionStart, this.SelectionLength);
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000E6 RID: 230 RVA: 0x00007090 File Offset: 0x00005290
		internal global::Infragistics.Controls.Editors.EditSectionBase FirstEditSection
		{
			get
			{
				global::Infragistics.Controls.Editors.SectionBase firstSection = this.FirstSection;
				if (firstSection == null)
				{
					return null;
				}
				if (firstSection is global::Infragistics.Controls.Editors.EditSectionBase)
				{
					return (global::Infragistics.Controls.Editors.EditSectionBase)firstSection;
				}
				return firstSection.NextEditSection;
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000E7 RID: 231 RVA: 0x000070C0 File Offset: 0x000052C0
		internal global::Infragistics.Controls.Editors.InputCharBase FirstEditDisplayChar
		{
			get
			{
				global::Infragistics.Controls.Editors.SectionBase firstSection = this.FirstSection;
				if (firstSection == null)
				{
					return null;
				}
				return firstSection.FirstDisplayChar as global::Infragistics.Controls.Editors.InputCharBase;
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000E8 RID: 232 RVA: 0x000070E4 File Offset: 0x000052E4
		internal global::Infragistics.Controls.Editors.EditSectionBase LastEditSection
		{
			get
			{
				global::Infragistics.Controls.Editors.SectionBase lastSection = this.LastSection;
				if (lastSection == null)
				{
					return null;
				}
				if (lastSection is global::Infragistics.Controls.Editors.EditSectionBase)
				{
					return (global::Infragistics.Controls.Editors.EditSectionBase)lastSection;
				}
				return lastSection.PreviousEditSection;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000E9 RID: 233 RVA: 0x00007112 File Offset: 0x00005312
		internal global::Infragistics.Controls.Editors.SectionBase FirstSection
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

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000EA RID: 234 RVA: 0x00007138 File Offset: 0x00005338
		internal global::Infragistics.Controls.Editors.SectionBase LastSection
		{
			get
			{
				return global::Infragistics.Controls.Editors.EditInfo.GetLastSection(this.Sections);
			}
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00007145 File Offset: 0x00005345
		internal static global::Infragistics.Controls.Editors.SectionBase GetLastSection(global::Infragistics.Controls.Editors.SectionsCollection sections)
		{
			if (sections == null || sections.Count <= 0)
			{
				return null;
			}
			return sections[sections.Count - 1];
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000EC RID: 236 RVA: 0x00007164 File Offset: 0x00005364
		internal global::Infragistics.Controls.Editors.InputCharBase FirstFilledDisplayChar
		{
			get
			{
				int i = 0;
				int totalNumberOfDisplayChars = this.GetTotalNumberOfDisplayChars();
				while (i < totalNumberOfDisplayChars)
				{
					global::Infragistics.Controls.Editors.InputCharBase inputCharBase = this.GetDisplayCharAtPosition(i) as global::Infragistics.Controls.Editors.InputCharBase;
					if (inputCharBase != null && inputCharBase.IsEditable && !inputCharBase.IsEmpty)
					{
						return inputCharBase;
					}
					i++;
				}
				return null;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000ED RID: 237 RVA: 0x000071A8 File Offset: 0x000053A8
		internal global::Infragistics.Controls.Editors.InputCharBase LastFilledDisplayChar
		{
			get
			{
				for (int i = this.GetTotalNumberOfDisplayChars() - 1; i >= 0; i--)
				{
					global::Infragistics.Controls.Editors.InputCharBase inputCharBase = this.GetDisplayCharAtPosition(i) as global::Infragistics.Controls.Editors.InputCharBase;
					if (inputCharBase != null && inputCharBase.IsEditable && !inputCharBase.IsEmpty)
					{
						return inputCharBase;
					}
				}
				return null;
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000EE RID: 238 RVA: 0x000071EB File Offset: 0x000053EB
		internal global::Infragistics.Controls.Editors.DisplayCharBase LastDisplayChar
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

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000EF RID: 239 RVA: 0x00007204 File Offset: 0x00005404
		internal global::Infragistics.Controls.Editors.SectionBase CurrentSection
		{
			get
			{
				global::Infragistics.Controls.Editors.DisplayCharBase currentDisplayChar = this.GetCurrentDisplayChar();
				if (currentDisplayChar == null)
				{
					return null;
				}
				return currentDisplayChar.Section;
			}
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00007224 File Offset: 0x00005424
		internal global::Infragistics.Controls.Editors.DisplayCharBase GetCurrentDisplayChar()
		{
			global::Infragistics.Controls.Editors.DisplayCharBase result = null;
			int totalNumberOfDisplayChars = this.GetTotalNumberOfDisplayChars();
			if (this.CaretPosition >= 0 && this.CaretPosition < totalNumberOfDisplayChars)
			{
				result = this.GetDisplayCharAtPosition(this.CaretPosition);
			}
			return result;
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x0000725A File Offset: 0x0000545A
		internal void ToggleInsertMode()
		{
			this.InsertMode = !this.InsertMode;
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000F2 RID: 242 RVA: 0x0000726C File Offset: 0x0000546C
		// (set) Token: 0x060000F3 RID: 243 RVA: 0x0000728C File Offset: 0x0000548C
		internal bool InsertMode
		{
			get
			{
				global::Infragistics.Controls.Editors.XamMaskedInput maskedInput = this.MaskedInput;
				return maskedInput == null || maskedInput.InsertMode;
			}
			set
			{
				if (value != this.InsertMode)
				{
					global::Infragistics.Controls.Editors.XamMaskedInput maskedInput = this.MaskedInput;
					if (maskedInput != null)
					{
						maskedInput.InsertMode = value;
					}
					if (!this.InsertMode && this.IsAfterLastCharacter)
					{
						this.CaretPosition = this.GetTotalNumberOfDisplayChars() - 1;
					}
				}
			}
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x000072D4 File Offset: 0x000054D4
		internal bool IsRightToLeft(global::Infragistics.Controls.Editors.SectionBase section)
		{
			global::Infragistics.Controls.Editors.EditSectionBase editSectionBase = section as global::Infragistics.Controls.Editors.EditSectionBase;
			return editSectionBase != null && global::Infragistics.Controls.Editors.EditOrientation.RightToLeft == editSectionBase.Orientation;
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x000072F8 File Offset: 0x000054F8
		private bool CanInsertAt(char c, int pos)
		{
			global::Infragistics.Controls.Editors.DisplayCharBase displayCharAtPosition = this.GetDisplayCharAtPosition(pos);
			if (displayCharAtPosition == null)
			{
				return false;
			}
			if (!displayCharAtPosition.IsEditable)
			{
				return false;
			}
			global::Infragistics.Controls.Editors.SectionBase section = displayCharAtPosition.Section;
			global::Infragistics.Controls.Editors.EditSectionBase editSectionBase = section as global::Infragistics.Controls.Editors.EditSectionBase;
			return editSectionBase != null && editSectionBase.CanInsertCharAt(displayCharAtPosition.Index, c);
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x0000733C File Offset: 0x0000553C
		private void EnsureNumberSectionState()
		{
			if (!this.InsertMode)
			{
				return;
			}
			global::Infragistics.Controls.Editors.DisplayCharBase displayCharBase = this.GetDisplayCharAtPosition(this.CaretPosition);
			global::Infragistics.Controls.Editors.DisplayCharBase displayCharAtPosition = this.GetDisplayCharAtPosition(this.CaretPosition - 1);
			if (displayCharBase != null && displayCharAtPosition != null && displayCharAtPosition.Section != displayCharBase.Section && this.IsRightToLeft(displayCharAtPosition.Section))
			{
				if (!(displayCharAtPosition.Section.NextEditSection is global::Infragistics.Controls.Editors.FractionPartContinuous))
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
				global::Infragistics.Controls.Editors.EditSectionBase editSectionBase = (global::Infragistics.Controls.Editors.EditSectionBase)displayCharBase.Section;
				if (editSectionBase.IsEmpty && editSectionBase.NextEditSection is global::Infragistics.Controls.Editors.FractionPartContinuous)
				{
					global::Infragistics.Controls.Editors.FractionPartContinuous fractionPartContinuous = (global::Infragistics.Controls.Editors.FractionPartContinuous)editSectionBase.NextEditSection;
					if (fractionPartContinuous.FirstDisplayChar.IsEmpty)
					{
						editSectionBase = fractionPartContinuous;
					}
				}
				int caretPivot = (editSectionBase.FirstFilledChar != null) ? editSectionBase.FirstFilledChar.OverallIndexInEdit : (1 + editSectionBase.LastDisplayChar.OverallIndexInEdit);
				this.SetCaretPivot(caretPivot);
				return;
			}
			if (displayCharBase != null && displayCharBase.Section is global::Infragistics.Controls.Editors.FractionPart && displayCharBase.IsEmpty)
			{
				global::Infragistics.Controls.Editors.EditSectionBase editSectionBase2 = (global::Infragistics.Controls.Editors.EditSectionBase)displayCharBase.Section;
				int num = (editSectionBase2.LastFilledChar != null) ? (1 + editSectionBase2.LastFilledChar.OverallIndexInEdit) : editSectionBase2.FirstDisplayChar.OverallIndexInEdit;
				if (displayCharBase.OverallIndexInEdit > num)
				{
					this.SetCaretPivot(num);
				}
			}
			if (displayCharBase != null && displayCharBase.Section is global::Infragistics.Controls.Editors.FractionPartContinuous)
			{
				global::Infragistics.Controls.Editors.FractionPartContinuous fractionPartContinuous2 = (global::Infragistics.Controls.Editors.FractionPartContinuous)displayCharBase.Section;
				if (displayCharBase.Index == 0 && !displayCharBase.IsEmpty && this.IsRightToLeft(fractionPartContinuous2.PreviousEditSection) && displayCharBase.OverallIndexInEdit >= this.CaretPosition)
				{
					this.SetCaretPivot(1 + fractionPartContinuous2.PreviousEditSection.LastDisplayChar.OverallIndexInEdit);
				}
			}
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x000074F0 File Offset: 0x000056F0
		internal string NormalizeEncodingHelper(string text)
		{
			if (text != null)
			{
				bool flag = true;
				global::Infragistics.Controls.Editors.MaskInfo maskInfo = this.MaskInfo;
				if (maskInfo != null && !global::Infragistics.Controls.Editors.Primitives.Utils.IsNumericType(maskInfo.DataType) && typeof(global::System.DateTime) != maskInfo.DataType && global::Infragistics.Controls.Editors.XamMaskedInput.GetSection(maskInfo.Sections, typeof(global::Infragistics.Controls.Editors.NumberSection)) == null)
				{
					flag = false;
				}
				if (flag)
				{
					global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder("0123456789");
					foreach (char c in "+-/:$,.")
					{
						char cultureChar = maskInfo.GetCultureChar(c);
						stringBuilder.Append(cultureChar);
						if (c != cultureChar)
						{
							stringBuilder.Append(c);
						}
					}
					global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>(stringBuilder.Length);
					for (int j = 0; j < stringBuilder.Length; j++)
					{
						list.Add(stringBuilder[j].ToString());
					}
					global::System.Text.StringBuilder stringBuilder2 = new global::System.Text.StringBuilder(text.Length);
					global::System.Globalization.CultureInfo currentCulture = global::System.Globalization.CultureInfo.CurrentCulture;
					foreach (char value in text)
					{
						string @string = value.ToString();
						bool flag2 = false;
						for (int l = 0; l < list.Count; l++)
						{
							string text3 = list[l];
							if (currentCulture.CompareInfo.Compare(@string, text3, global::System.Globalization.CompareOptions.IgnoreWidth) == 0)
							{
								stringBuilder2.Append(text3);
								flag2 = true;
								break;
							}
						}
						if (!flag2)
						{
							stringBuilder2.Append(value);
						}
					}
					text = stringBuilder2.ToString();
				}
			}
			return text;
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00007678 File Offset: 0x00005878
		internal bool ProcessTextInput(string text, bool normalizeEncoding)
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
				this.InternalProcessChar(c, false);
				if (this._lastIllegalChar != '\0')
				{
					break;
				}
				num++;
			}
			if (num > 0)
			{
				this.OnTextChanged(true, null, true, null);
			}
			else if (num == 0)
			{
				this.SyncIMETextBox(false);
			}
			return true;
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00007700 File Offset: 0x00005900
		internal int GetInputPositionInSelection(char c)
		{
			global::Infragistics.Controls.Editors.DisplayCharBase displayCharAtPosition = this.GetDisplayCharAtPosition(this.SelectionStart);
			global::Infragistics.Controls.Editors.DisplayCharBase displayCharAtPosition2 = this.GetDisplayCharAtPosition(this.SelectionStart + this.SelectionLength - 1);
			global::Infragistics.Controls.Editors.DisplayCharBase nextEditableDisplayChar = displayCharAtPosition.NextEditableDisplayChar;
			if (!displayCharAtPosition.IsEditable && displayCharAtPosition.Section != displayCharAtPosition2.Section && nextEditableDisplayChar != null && nextEditableDisplayChar.OverallIndexInEdit <= displayCharAtPosition2.OverallIndexInEdit)
			{
				return nextEditableDisplayChar.OverallIndexInEdit;
			}
			return -1;
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00007768 File Offset: 0x00005968
		private bool ProcessRTLInputSectionOverride(global::Infragistics.Controls.Editors.DisplayCharBase dc, char c)
		{
			if (!dc.MatchChar(c))
			{
				global::Infragistics.Controls.Editors.DisplayCharBase prevDisplayChar = dc.PrevDisplayChar;
				global::Infragistics.Controls.Editors.EditSectionBase editSectionBase = (prevDisplayChar != null) ? (prevDisplayChar.Section as global::Infragistics.Controls.Editors.EditSectionBase) : null;
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

		// Token: 0x060000FB RID: 251 RVA: 0x000077CC File Offset: 0x000059CC
		internal void InternalProcessChar(char c, bool disallowSignAfterDigits = false)
		{
			if (!this.IsInitialized || this.MaskedInput.DesignMode)
			{
				return;
			}
			global::Infragistics.Controls.Editors.SectionBase sectionBase = (this.CurrentSection == null) ? this.LastEditSection : this.CurrentSection;
			if (sectionBase != null && (sectionBase.IsDateTimeSeperatorSection || sectionBase.IsDateSection || sectionBase.IsTimeSection))
			{
				string text = "-/.,:";
				if (-1 < text.IndexOf(c))
				{
					global::Infragistics.Controls.Editors.DisplayCharBase currentDisplayChar = this.GetCurrentDisplayChar();
					if (currentDisplayChar == null || !currentDisplayChar.MatchChar(c))
					{
						global::Infragistics.Controls.Editors.SectionBase sectionBase2 = sectionBase.NextEditSection;
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
				global::Infragistics.Controls.Editors.DisplayCharBase displayCharAtPosition = this.GetDisplayCharAtPosition(this.SelectionStart);
				if (displayCharAtPosition != null && !displayCharAtPosition.MatchChar(c))
				{
					global::Infragistics.Controls.Editors.SectionBase sectionBase3 = displayCharAtPosition.Section;
					while (sectionBase3 != null && !(sectionBase3.LastDisplayChar is global::Infragistics.Controls.Editors.DecimalSeperatorChar))
					{
						sectionBase3 = sectionBase3.NextSection;
					}
					if (sectionBase3 != null && sectionBase3.LastDisplayChar is global::Infragistics.Controls.Editors.DecimalSeperatorChar)
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
				global::Infragistics.Controls.Editors.DisplayCharBase displayCharAtPosition2 = this.GetDisplayCharAtPosition(this.SelectionStart);
				if (char.IsDigit(c) && this.FirstEditSection is global::Infragistics.Controls.Editors.NumberSection && this.SelectionStart == 0)
				{
					this.Delete();
				}
				else
				{
					global::Infragistics.Controls.Editors.NumberSection numberSection = displayCharAtPosition2.Section as global::Infragistics.Controls.Editors.NumberSection;
					global::Infragistics.Controls.Editors.DisplayCharBase displayCharBase = (numberSection != null) ? numberSection.FirstFilledChar : null;
					bool flag2 = (numberSection != null && (c == numberSection.PlusSignChar || c == numberSection.MinusSignChar) && numberSection.FirstFilledChar == displayCharAtPosition2) || (char.IsDigit(c) && displayCharBase != null && this.IsDisplayCharSelected(displayCharBase));
					if (displayCharAtPosition2 != null && displayCharAtPosition2.IsEditable && !displayCharAtPosition2.MatchChar(c) && !flag2)
					{
						this.IllegalCharPressed(displayCharAtPosition2, c);
						return;
					}
					int inputPositionInSelection = this.GetInputPositionInSelection(c);
					if (!this.InsertMode && displayCharAtPosition2 != null && displayCharAtPosition2.Section is global::Infragistics.Controls.Editors.NumberSection)
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
			global::Infragistics.Controls.Editors.DisplayCharBase displayCharBase2 = this.GetCurrentDisplayChar();
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
				global::Infragistics.Controls.Editors.NumberSection numberSection2 = displayCharBase2.Section as global::Infragistics.Controls.Editors.NumberSection;
				if (numberSection2 == null && displayCharBase2 is global::Infragistics.Controls.Editors.DecimalSeperatorChar)
				{
					numberSection2 = ((displayCharBase2.PrevDisplayChar != null) ? (displayCharBase2.PrevDisplayChar.Section as global::Infragistics.Controls.Editors.NumberSection) : null);
				}
				if (numberSection2 == null && displayCharBase2.Section is global::Infragistics.Controls.Editors.FractionPart)
				{
					numberSection2 = (displayCharBase2.Section.PreviousEditSection as global::Infragistics.Controls.Editors.NumberSection);
				}
				if (displayCharBase2 != null && displayCharBase2.PrevDisplayChar != null && displayCharBase2.PrevDisplayChar.Section is global::Infragistics.Controls.Editors.NumberSection)
				{
					numberSection2 = (displayCharBase2.PrevDisplayChar.Section as global::Infragistics.Controls.Editors.NumberSection);
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
						global::Infragistics.Controls.Editors.EditSectionBase editSectionBase = displayCharBase2.Section as global::Infragistics.Controls.Editors.EditSectionBase;
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
									global::Infragistics.Controls.Editors.DisplayCharBase displayCharBase3 = null;
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
										global::Infragistics.Controls.Editors.DisplayCharBase displayCharAtPosition3 = this.GetDisplayCharAtPosition(1 + displayCharBase3.OverallIndexInEdit);
										if (displayCharAtPosition3 != null && displayCharAtPosition3.IsEditable)
										{
											global::Infragistics.Controls.Editors.EditSectionBase editSectionBase2 = displayCharAtPosition3.Section as global::Infragistics.Controls.Editors.EditSectionBase;
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
										global::Infragistics.Controls.Editors.EditSectionBase nextEditSection = editSectionBase.NextEditSection;
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
													this.InternalProcessChar(c, false);
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
													this.InternalProcessChar(c, false);
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
								global::Infragistics.Controls.Editors.SectionBase section = displayCharBase2.Section;
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
						global::Infragistics.Controls.Editors.EditSectionBase editSectionBase3 = displayCharBase2.Section as global::Infragistics.Controls.Editors.EditSectionBase;
						if (editSectionBase3 != null && global::Infragistics.Controls.Editors.EditOrientation.RightToLeft == editSectionBase3.Orientation)
						{
							if (flag ? editSectionBase3.InsertCharAt(displayCharBase2.Index, c) : editSectionBase3.ReplaceCharAt(displayCharBase2.Index, c))
							{
								if (global::Infragistics.Controls.Editors.XamMaskedInput.IsSectionNumeric(editSectionBase3))
								{
									this.CaretPosition++;
									this.SetPivot();
								}
								this.DirtyMaskElement();
							}
							else
							{
								bool flag5 = false;
								global::Infragistics.Controls.Editors.SectionBase section2 = displayCharBase2.Section;
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
							global::Infragistics.Controls.Editors.SectionBase section3 = displayCharBase2.Section;
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
					global::Infragistics.Controls.Editors.DisplayCharBase displayCharAtPosition4 = this.GetDisplayCharAtPosition(this.CaretPosition + 1);
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
					global::Infragistics.Controls.Editors.DisplayCharBase displayCharAtPosition5 = this.GetDisplayCharAtPosition(displayCharBase2.OverallIndexInEdit - 1);
					if (displayCharAtPosition5 != null && displayCharAtPosition5.Section != displayCharBase2.Section)
					{
						global::Infragistics.Controls.Editors.EditSectionBase editSectionBase4 = displayCharAtPosition5.Section as global::Infragistics.Controls.Editors.EditSectionBase;
						if (this.IsRightToLeft(editSectionBase4))
						{
							global::Infragistics.Controls.Editors.DisplayCharBase lastDisplayChar = editSectionBase4.LastDisplayChar;
							if (this.CanInsertAt(c, lastDisplayChar.OverallIndexInEdit))
							{
								if (editSectionBase4.InsertCharAt(lastDisplayChar.Index, c))
								{
									this.DirtyMaskElement();
								}
								else if (lastDisplayChar == editSectionBase4.LastDisplayChar)
								{
									global::Infragistics.Controls.Editors.EditSectionBase nextEditSection2 = editSectionBase4.NextEditSection;
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
												this.InternalProcessChar(c, false);
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
												this.InternalProcessChar(c, false);
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
								global::Infragistics.Controls.Editors.EditSectionBase nextEditSection3 = displayCharBase2.Section.NextEditSection;
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
											this.InternalProcessChar(c, false);
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
											this.InternalProcessChar(c, false);
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
							global::Infragistics.Controls.Editors.EditSectionBase nextEditSection4 = displayCharBase2.Section.NextEditSection;
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
										this.InternalProcessChar(c, false);
									}
									else
									{
										this.IllegalCharPressed(displayCharBase2, c);
									}
								}
								else
								{
									int overallIndexInEdit4 = nextEditSection4.FirstDisplayChar.OverallIndexInEdit;
									global::Infragistics.Controls.Editors.DisplayCharBase displayCharAtPosition6 = this.GetDisplayCharAtPosition(overallIndexInEdit4);
									if (this.CanInsertAt(c, overallIndexInEdit4))
									{
										this.GotoSection(nextEditSection4);
										this.SetPivot();
										this.InternalProcessChar(c, false);
									}
									else if (!this.InsertMode && displayCharAtPosition6.MatchChar(c))
									{
										this.SetCaretPivot(overallIndexInEdit4);
										this.InternalProcessChar(c, false);
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
						global::Infragistics.Controls.Editors.EditSectionBase nextEditSection5 = displayCharBase2.Section.NextEditSection;
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
									this.InternalProcessChar(c, false);
								}
								else
								{
									this.IllegalCharPressed(displayCharBase2, c);
								}
							}
							else
							{
								int overallIndexInEdit5 = nextEditSection5.FirstDisplayChar.OverallIndexInEdit;
								global::Infragistics.Controls.Editors.DisplayCharBase displayCharAtPosition7 = this.GetDisplayCharAtPosition(overallIndexInEdit5);
								if (this.CanInsertAt(c, overallIndexInEdit5))
								{
									this.GotoSection(nextEditSection5);
									this.SetPivot();
									this.InternalProcessChar(c, false);
								}
								else if (!this.InsertMode && displayCharAtPosition7.MatchChar(c))
								{
									this.SetCaretPivot(overallIndexInEdit5);
									this.InternalProcessChar(c, false);
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
				global::Infragistics.Controls.Editors.DisplayCharBase displayCharAtPosition8 = this.GetDisplayCharAtPosition(this.CaretPosition - 1);
				global::Infragistics.Controls.Editors.EditSectionBase editSectionBase5 = (displayCharAtPosition8 != null) ? (displayCharAtPosition8.Section as global::Infragistics.Controls.Editors.EditSectionBase) : null;
				bool flag7 = false;
				global::Infragistics.Controls.Editors.NumberSection numberSection3 = null;
				if (editSectionBase5 is global::Infragistics.Controls.Editors.NumberSection)
				{
					numberSection3 = (global::Infragistics.Controls.Editors.NumberSection)editSectionBase5;
				}
				else if (editSectionBase5 is global::Infragistics.Controls.Editors.FractionPart)
				{
					numberSection3 = (editSectionBase5.PreviousEditSection as global::Infragistics.Controls.Editors.NumberSection);
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
						global::Infragistics.Controls.Editors.DisplayCharBase lastDisplayChar2 = editSectionBase5.LastDisplayChar;
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
		}

		// Token: 0x060000FC RID: 252 RVA: 0x0000860C File Offset: 0x0000680C
		internal global::Infragistics.Controls.Editors.SectionBase GetSectionContainingPosition(int position)
		{
			return global::Infragistics.Controls.Editors.EditInfo.GetSectionContainingPosition(position, this.Sections);
		}

		// Token: 0x060000FD RID: 253 RVA: 0x0000861C File Offset: 0x0000681C
		internal static global::Infragistics.Controls.Editors.SectionBase GetSectionContainingPosition(int position, global::Infragistics.Controls.Editors.SectionsCollection sections)
		{
			if (sections == null || sections.Count <= 0)
			{
				return null;
			}
			int num = 0;
			for (int i = 0; i < sections.Count; i++)
			{
				global::Infragistics.Controls.Editors.SectionBase sectionBase = sections[i];
				num += sectionBase.DisplayChars.Count;
				if (position < num)
				{
					return sectionBase;
				}
			}
			return null;
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00008667 File Offset: 0x00006867
		internal global::Infragistics.Controls.Editors.DisplayCharBase GetDisplayCharAtPosition(int position)
		{
			return global::Infragistics.Controls.Editors.XamMaskedInput.GetDisplayCharAtPosition(this.Sections, position);
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00008675 File Offset: 0x00006875
		internal int GetTotalNumberOfDisplayChars()
		{
			return global::Infragistics.Controls.Editors.XamMaskedInput.InternalGetTotalNumberOfDisplayChars(this.Sections);
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000100 RID: 256 RVA: 0x00008682 File Offset: 0x00006882
		internal bool IsInitialized
		{
			get
			{
				return this.GetTotalNumberOfDisplayChars() > 0;
			}
		}

		// Token: 0x06000101 RID: 257 RVA: 0x0000868D File Offset: 0x0000688D
		internal void SetCaretPivot(int pos)
		{
			this.CaretPosition = pos;
			this.PivotPosition = pos;
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000102 RID: 258 RVA: 0x0000869D File Offset: 0x0000689D
		// (set) Token: 0x06000103 RID: 259 RVA: 0x000086A5 File Offset: 0x000068A5
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
					this.NotifyStateChanged();
				}
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000104 RID: 260 RVA: 0x000086CB File Offset: 0x000068CB
		internal bool ConstraintCaretToFilledCharacters
		{
			get
			{
				return this._maskInfo.PromptChar == '\0';
			}
		}

		// Token: 0x06000105 RID: 261 RVA: 0x000086E0 File Offset: 0x000068E0
		internal int CoerceCaretPosition(int pos)
		{
			if (pos < 0)
			{
				pos = 0;
			}
			int num = this.GetTotalNumberOfDisplayChars() - 1;
			if (this.ConstraintCaretToFilledCharacters)
			{
				global::Infragistics.Controls.Editors.SectionBase currentSection = this.GetCurrentSection(true);
				if (!this.IsRightToLeft(currentSection) && !(currentSection is global::Infragistics.Controls.Editors.FractionPart))
				{
					global::Infragistics.Controls.Editors.InputCharBase lastFilledDisplayChar = this.LastFilledDisplayChar;
					num = ((lastFilledDisplayChar != null) ? lastFilledDisplayChar.OverallIndexInEdit : 0);
					global::Infragistics.Controls.Editors.DisplayCharBase displayCharAtPosition;
					while ((displayCharAtPosition = this.GetDisplayCharAtPosition(1 + num)) != null && !displayCharAtPosition.IsEmpty)
					{
						num++;
					}
				}
			}
			global::Infragistics.Controls.Editors.SectionBase lastSection = this.LastSection;
			if (pos > num)
			{
				pos = num + 1;
			}
			return pos;
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00008760 File Offset: 0x00006960
		internal void OnMaskReparsed()
		{
			int caretPosition = this.CaretPosition;
			int pivotPosition = this.PivotPosition;
			if (!this.InitializeInitialCaretPos())
			{
				this.CaretPosition = this.CoerceCaretPosition(caretPosition);
				this.PivotPosition = this.CoerceCaretPosition(pivotPosition);
			}
			if (caretPosition != this.CaretPosition || pivotPosition != this.PivotPosition)
			{
				this.SyncSelectionOnImeTextBoxHelper();
			}
			this.NotifyStateChanged();
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000107 RID: 263 RVA: 0x000087BB File Offset: 0x000069BB
		// (set) Token: 0x06000108 RID: 264 RVA: 0x000087C3 File Offset: 0x000069C3
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
					this.InvalidateMaskElement();
					this.NotifyStateChanged();
				}
			}
		}

		// Token: 0x06000109 RID: 265 RVA: 0x000087F0 File Offset: 0x000069F0
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

		// Token: 0x0600010A RID: 266 RVA: 0x00008818 File Offset: 0x00006A18
		internal void SelectAll()
		{
			if (!this.IsInitialized || this.MaskedInput.DesignMode)
			{
				return;
			}
			if (this.MaskedInput != null && global::Infragistics.Controls.Editors.MaskSelectAllBehavior.SelectEnteredCharacters == this.MaskedInput.SelectAllBehavior)
			{
				global::Infragistics.Controls.Editors.DisplayCharBase displayCharBase = this.FirstFilledDisplayChar;
				global::Infragistics.Controls.Editors.DisplayCharBase displayCharBase2 = this.LastFilledDisplayChar;
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
					this.Select(displayCharBase.OverallIndexInEdit, 1 + displayCharBase2.OverallIndexInEdit - displayCharBase.OverallIndexInEdit, true);
					return;
				}
			}
			this.Select(0, this.GetTotalNumberOfDisplayChars(), true);
		}

		// Token: 0x0600010B RID: 267 RVA: 0x000088D5 File Offset: 0x00006AD5
		internal void Select(int start, int length, bool syncSelectionWithImeTextBox = false)
		{
			this.SelectionStart = start;
			this.SelectionLength = length;
			if (syncSelectionWithImeTextBox)
			{
				this.SyncSelectionOnImeTextBoxHelper();
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x0600010C RID: 268 RVA: 0x000088F0 File Offset: 0x00006AF0
		// (set) Token: 0x0600010D RID: 269 RVA: 0x00008944 File Offset: 0x00006B44
		internal int SelectionStart
		{
			get
			{
				global::Infragistics.Controls.Editors.DisplayCharBase displayCharAtPosition = this.GetDisplayCharAtPosition(this.CaretPosition);
				global::Infragistics.Controls.Editors.DisplayCharBase displayCharAtPosition2 = this.GetDisplayCharAtPosition(this.PivotPosition);
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

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x0600010E RID: 270 RVA: 0x00008994 File Offset: 0x00006B94
		// (set) Token: 0x0600010F RID: 271 RVA: 0x000089EC File Offset: 0x00006BEC
		internal int SelectionLength
		{
			get
			{
				global::Infragistics.Controls.Editors.DisplayCharBase displayCharAtPosition = this.GetDisplayCharAtPosition(this.CaretPosition);
				global::Infragistics.Controls.Editors.DisplayCharBase displayCharAtPosition2 = this.GetDisplayCharAtPosition(this.PivotPosition);
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

		// Token: 0x06000110 RID: 272 RVA: 0x00008A55 File Offset: 0x00006C55
		internal void Cut()
		{
			this.Cut(true);
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00008A60 File Offset: 0x00006C60
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
				if (!global::Infragistics.Controls.Editors.Primitives.Utils.SetClipboardText(selectedText))
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
				this.OnTextChanged(true, null, true, null);
			}
			this.DirtyMaskElement();
		}

		// Token: 0x06000112 RID: 274 RVA: 0x00008AD0 File Offset: 0x00006CD0
		internal void Paste()
		{
			this.Paste(true);
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00008ADC File Offset: 0x00006CDC
		internal void Paste(bool fireValueChanged)
		{
			if (this.ReadOnly)
			{
				return;
			}
			string text = global::Infragistics.Controls.Editors.Primitives.Utils.GetClipboardText();
			text = this.NormalizeEncodingHelper(text);
			if (!string.IsNullOrEmpty(text))
			{
				this.SetSelectedText(text, fireValueChanged);
			}
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00008B10 File Offset: 0x00006D10
		internal void Copy()
		{
			string text = this.SelectedText;
			if (text != null && text.Length > 1 && this.MaskInfo != null && this.MaskInfo.ClipMode == global::Infragistics.Controls.Editors.InputMaskMode.Raw)
			{
				string value = string.Concat(this.MaskInfo.DecimalSeperatorChar);
				if (text.EndsWith(value))
				{
					text = text.Substring(0, text.Length - 1);
				}
			}
			try
			{
				global::System.DateTime now = global::System.DateTime.Now;
				global::Infragistics.Controls.Editors.Primitives.Utils.SetClipboardText(text);
				this.OnClipboardOperationAttempted(now);
			}
			catch
			{
			}
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00008BAC File Offset: 0x00006DAC
		private void OnClipboardOperationAttempted(global::System.DateTime operationStartTime)
		{
			if ((global::System.DateTime.Now - operationStartTime).Milliseconds > 50)
			{
				global::System.Windows.Threading.Dispatcher dispatcher = this.MaskedInput.GetDispatcher();
				if (dispatcher != null)
				{
					this._skipNextTextInput = true;
					dispatcher.BeginInvoke(new global::System.Action(delegate()
					{
						this._skipNextTextInput = false;
					}), new object[0]);
				}
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000116 RID: 278 RVA: 0x00008C06 File Offset: 0x00006E06
		// (set) Token: 0x06000117 RID: 279 RVA: 0x00008C33 File Offset: 0x00006E33
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

		// Token: 0x06000118 RID: 280 RVA: 0x00008C40 File Offset: 0x00006E40
		internal bool IsInputNull()
		{
			string text = this.GetText(global::Infragistics.Controls.Editors.InputMaskMode.Raw);
			return text == null || text.Length == 0 || this.TreatStringAsNull(text);
		}

		// Token: 0x06000119 RID: 281 RVA: 0x00008C6C File Offset: 0x00006E6C
		private bool TreatStringAsNull(string value)
		{
			global::Infragistics.Controls.Editors.MaskInfo maskInfo = this.MaskInfo;
			maskInfo.GetCultureChar('.');
			global::Infragistics.Controls.Editors.SectionsCollection sections = maskInfo.Sections;
			int num = 0;
			int count = sections.Count;
			while (num + 2 < count)
			{
				if (sections[num] is global::Infragistics.Controls.Editors.NumberSection)
				{
					global::Infragistics.Controls.Editors.LiteralSection literalSection = sections[num + 1] as global::Infragistics.Controls.Editors.LiteralSection;
					if (literalSection != null && sections[num + 2] is global::Infragistics.Controls.Editors.FractionPart && literalSection.GetText() == value)
					{
						return true;
					}
				}
				num++;
			}
			return false;
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00008CEC File Offset: 0x00006EEC
		private void SetSelectedText(string text, bool fireValueChanged)
		{
			if (text == null)
			{
				text = string.Empty;
			}
			global::Infragistics.Controls.Editors.EditInfo.EditorValueSnapshot valueSnapshot = this.GetValueSnapshot();
			if (this.IsAnyTextSelected)
			{
				this.Delete();
			}
			if (global::Infragistics.Controls.Editors.XamMaskedInput.AreAllDisplayCharsEmpty(this.Sections))
			{
				int num = global::Infragistics.Controls.Editors.XamMaskedInput.InternalGetNumberSectionCount(this.Sections);
				if (1 == num || (2 == num && this.LastEditSection is global::Infragistics.Controls.Editors.FractionPart))
				{
					object obj;
					global::System.Exception ex;
					this.MaskedInput.ConvertTextToValue(text, out obj, out ex);
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
				global::Infragistics.Controls.Editors.DisplayCharBase currentDisplayChar = this.GetCurrentDisplayChar();
				global::Infragistics.Controls.Editors.EditSectionBase firstEditSection = this.FirstEditSection;
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
				global::Infragistics.Controls.Editors.DisplayCharBase currentDisplayChar2 = this.GetCurrentDisplayChar();
				global::Infragistics.Controls.Editors.SectionBase sectionBase = (currentDisplayChar2 != null) ? currentDisplayChar2.Section : this.LastEditSection;
				if ((!(sectionBase is global::Infragistics.Controls.Editors.NumberSection) && !(currentDisplayChar2 is global::Infragistics.Controls.Editors.DecimalSeperatorChar)) || text[i] != this.MaskInfo.CommaChar)
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
					global::Infragistics.Controls.Editors.EditSectionBase editSectionBase = this.CurrentSection as global::Infragistics.Controls.Editors.EditSectionBase;
					if (editSectionBase != null)
					{
						this.GotoSection(editSectionBase);
						this.SetPivot();
					}
				}
				if (fireValueChanged)
				{
					this.OnTextChanged(true, null, true, null);
				}
			}
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00008EA0 File Offset: 0x000070A0
		internal string GetText(global::Infragistics.Controls.Editors.InputMaskMode maskMode, int start, int length)
		{
			if (!this.IsInitialized)
			{
				return string.Empty;
			}
			return global::Infragistics.Controls.Editors.EditInfo.GetText(maskMode, start, length, this.Sections);
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00008EC0 File Offset: 0x000070C0
		internal static string GetText(global::Infragistics.Controls.Editors.InputMaskMode maskMode, int start, int length, global::Infragistics.Controls.Editors.SectionsCollection sections)
		{
			int num = start + length;
			if (start == num)
			{
				return string.Empty;
			}
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(1 + length);
			for (int i = start; i < num; i++)
			{
				global::Infragistics.Controls.Editors.DisplayCharBase displayCharAtPosition = global::Infragistics.Controls.Editors.XamMaskedInput.GetDisplayCharAtPosition(sections, i);
				char c = '\0';
				if (displayCharAtPosition != null)
				{
					c = displayCharAtPosition.GetChar(maskMode);
				}
				if (c != '\0')
				{
					stringBuilder.Append(c);
					if (displayCharAtPosition is global::Infragistics.Controls.Editors.DigitChar && ((global::Infragistics.Controls.Editors.DigitChar)displayCharAtPosition).ShouldIncludeComma(maskMode))
					{
						stringBuilder.Append(displayCharAtPosition.Section.CommaChar);
					}
				}
			}
			return stringBuilder.ToString();
		}

		// Token: 0x04000056 RID: 86
		private global::Infragistics.Controls.Editors.MaskInfo _maskInfo;

		// Token: 0x04000057 RID: 87
		private int _caretPosition;

		// Token: 0x04000058 RID: 88
		private int _pivotPosition;

		// Token: 0x04000059 RID: 89
		private char _lastIllegalChar;

		// Token: 0x0400005A RID: 90
		private global::Infragistics.Controls.Editors.DisplayCharBase _lastIllegalDisplayChar;

		// Token: 0x0400005B RID: 91
		internal bool _inOnTextChanged;

		// Token: 0x0400005C RID: 92
		private global::System.Collections.Generic.Stack<global::Infragistics.Controls.Editors.EditInfo.EditorSnapshot> _undoHistory;

		// Token: 0x0400005D RID: 93
		private global::System.Collections.Generic.Stack<global::Infragistics.Controls.Editors.EditInfo.EditorSnapshot> _redoHistory;

		// Token: 0x0400005E RID: 94
		private bool _inUndoRedoHelper;

		// Token: 0x0400005F RID: 95
		private global::Infragistics.Controls.Editors.EditInfo.TextBoxEventProxy _staticEventProxy;

		// Token: 0x04000060 RID: 96
		internal global::Infragistics.Controls.Editors.Primitives.MaskedInputTextBox _imeTextBox;

		// Token: 0x04000061 RID: 97
		internal bool _inSyncWithIMETextBox;

		// Token: 0x04000062 RID: 98
		internal bool _inSyncIMETextBox;

		// Token: 0x04000063 RID: 99
		internal global::Infragistics.Controls.Editors.Primitives.Utils.Range _imeTextBox_PendingDelete;

		// Token: 0x04000064 RID: 100
		private bool _skipNextTextInput;

		// Token: 0x04000065 RID: 101
		private global::Infragistics.Controls.Editors.Primitives.MaskedInputStates _prevCurrentState;

		// Token: 0x04000066 RID: 102
		[global::System.ThreadStatic]
		private static object _notifyCommandsManagerOperation;

		// Token: 0x04000067 RID: 103
		internal bool IsBackspaceInvalidOperation;

		// Token: 0x04000068 RID: 104
		internal bool IsBackspaceOperation;

		// Token: 0x0200001C RID: 28
		private class EditorSnapshot
		{
			// Token: 0x0600011E RID: 286 RVA: 0x00008F42 File Offset: 0x00007142
			internal EditorSnapshot(global::Infragistics.Controls.Editors.EditInfo editInfo)
			{
				this._text = editInfo.GetText(global::Infragistics.Controls.Editors.InputMaskMode.IncludeBoth);
				this._caretPos = editInfo.CaretPosition;
				this._pivotPos = editInfo.PivotPosition;
			}

			// Token: 0x0600011F RID: 287 RVA: 0x00008F6F File Offset: 0x0000716F
			internal void Apply(global::Infragistics.Controls.Editors.EditInfo editInfo)
			{
				editInfo.SetText(this._text);
				editInfo.PivotPosition = this._pivotPos;
				editInfo.CaretPosition = this._caretPos;
			}

			// Token: 0x0400006A RID: 106
			internal int _caretPos;

			// Token: 0x0400006B RID: 107
			internal int _pivotPos;

			// Token: 0x0400006C RID: 108
			internal string _text;
		}

		// Token: 0x0200001D RID: 29
		internal class EditorValueSnapshot
		{
			// Token: 0x06000120 RID: 288 RVA: 0x00008F96 File Offset: 0x00007196
			internal EditorValueSnapshot(global::Infragistics.Controls.Editors.EditInfo editInfo)
			{
				this._text = editInfo.GetText(global::Infragistics.Controls.Editors.InputMaskMode.IncludeBoth);
				this._textRaw = editInfo.GetText(global::Infragistics.Controls.Editors.InputMaskMode.Raw);
			}

			// Token: 0x06000121 RID: 289 RVA: 0x00008FB8 File Offset: 0x000071B8
			internal bool AreEqual(global::Infragistics.Controls.Editors.EditInfo.EditorValueSnapshot ii)
			{
				return ii._text == this._text && ii._textRaw == this._textRaw;
			}

			// Token: 0x06000122 RID: 290 RVA: 0x00008FE0 File Offset: 0x000071E0
			internal bool IsCurrentValueSame(global::Infragistics.Controls.Editors.EditInfo editInfo)
			{
				return this.AreEqual(new global::Infragistics.Controls.Editors.EditInfo.EditorValueSnapshot(editInfo));
			}

			// Token: 0x0400006D RID: 109
			internal string _text;

			// Token: 0x0400006E RID: 110
			internal string _textRaw;
		}

		// Token: 0x0200001E RID: 30
		private class TextBoxEventProxy
		{
			// Token: 0x06000123 RID: 291 RVA: 0x00008FEE File Offset: 0x000071EE
			internal TextBoxEventProxy(global::Infragistics.Controls.Editors.EditInfo editInfo)
			{
				this._editInfoRef = new global::System.WeakReference(editInfo);
			}

			// Token: 0x17000041 RID: 65
			// (get) Token: 0x06000124 RID: 292 RVA: 0x00009002 File Offset: 0x00007202
			internal global::Infragistics.Controls.Editors.EditInfo EditInfo
			{
				get
				{
					return global::Infragistics.CoreUtilities.GetWeakReferenceTargetSafe(this._editInfoRef) as global::Infragistics.Controls.Editors.EditInfo;
				}
			}

			// Token: 0x06000125 RID: 293 RVA: 0x00009014 File Offset: 0x00007214
			internal void UnwireTextBoxEvents()
			{
				if (this._textBoxWired != null)
				{
					this._textBoxWired.ClearValue(global::System.Windows.FrameworkElement.ContextMenuProperty);
					global::System.Windows.Input.CommandManager.RemovePreviewCanExecuteHandler(this._textBoxWired, new global::System.Windows.Input.CanExecuteRoutedEventHandler(this.ImeTextBox_PreviewCanExecuteCommand));
					global::System.Windows.Input.TextCompositionManager.RemoveTextInputStartHandler(this._textBoxWired, new global::System.Windows.Input.TextCompositionEventHandler(this.ImeTextBox_TextInputStart));
					this._textBoxWired = null;
				}
			}

			// Token: 0x06000126 RID: 294 RVA: 0x00009070 File Offset: 0x00007270
			internal void WireTextBoxEvents(global::System.Windows.Controls.TextBox textBox)
			{
				if (this._textBoxWired != textBox)
				{
					this.UnwireTextBoxEvents();
					this._textBoxWired = textBox;
					if (this._textBoxWired != null)
					{
						global::System.Windows.Input.CommandManager.AddPreviewCanExecuteHandler(this._textBoxWired, new global::System.Windows.Input.CanExecuteRoutedEventHandler(this.ImeTextBox_PreviewCanExecuteCommand));
						global::System.Windows.Input.TextCompositionManager.AddTextInputStartHandler(this._textBoxWired, new global::System.Windows.Input.TextCompositionEventHandler(this.ImeTextBox_TextInputStart));
					}
				}
			}

			// Token: 0x06000127 RID: 295 RVA: 0x000090C9 File Offset: 0x000072C9
			private void OnCleanup()
			{
				this.UnwireTextBoxEvents();
			}

			// Token: 0x06000128 RID: 296 RVA: 0x000090D4 File Offset: 0x000072D4
			private void ImeTextBox_TextInputStart(object sender, global::System.Windows.Input.TextCompositionEventArgs e)
			{
				global::Infragistics.Controls.Editors.EditInfo editInfo = this.EditInfo;
				if (editInfo != null)
				{
					editInfo.ImeTextBox_TextInputStart(sender, e);
					return;
				}
				this.OnCleanup();
			}

			// Token: 0x06000129 RID: 297 RVA: 0x000090FC File Offset: 0x000072FC
			private void ImeTextBox_PreviewCanExecuteCommand(object sender, global::System.Windows.Input.CanExecuteRoutedEventArgs e)
			{
				global::Infragistics.Controls.Editors.EditInfo editInfo = this.EditInfo;
				if (editInfo != null)
				{
					editInfo.ImeTextBox_PreviewCanExecuteCommand(sender, e);
					return;
				}
				this.OnCleanup();
			}

			// Token: 0x0400006F RID: 111
			private global::System.WeakReference _editInfoRef;

			// Token: 0x04000070 RID: 112
			private global::System.Windows.Controls.TextBox _textBoxWired;
		}
	}
}
