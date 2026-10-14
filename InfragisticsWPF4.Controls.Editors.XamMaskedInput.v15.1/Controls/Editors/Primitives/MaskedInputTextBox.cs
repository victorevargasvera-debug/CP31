using System;
using System.ComponentModel;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Threading;
using Infragistics.Controls.Primitives;

namespace Infragistics.Controls.Editors.Primitives
{
	// Token: 0x02000030 RID: 48
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class MaskedInputTextBox : global::Infragistics.Controls.Primitives.EmbeddedTextBox
	{
		// Token: 0x0600015B RID: 347 RVA: 0x0000AE19 File Offset: 0x00009019
		public MaskedInputTextBox()
		{
			base.FlowDirection = global::System.Windows.FlowDirection.LeftToRight;
			base.SelectionChanged += this.OnSelectionChanged;
			base.TextChanged += this.OnTextChanged;
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x0600015C RID: 348 RVA: 0x0000AE4C File Offset: 0x0000904C
		private global::Infragistics.Controls.Editors.EditInfo EditInfo
		{
			get
			{
				if (this._editor == null)
				{
					return null;
				}
				return this._editor.EditInfo;
			}
		}

		// Token: 0x0600015D RID: 349 RVA: 0x0000AE64 File Offset: 0x00009064
		internal void Initialize(global::Infragistics.Controls.Editors.XamMaskedInput editor)
		{
			this._editor = editor;
			if (this._editor != null)
			{
				base.SetBinding(global::System.Windows.Controls.Primitives.TextBoxBase.IsUndoEnabledProperty, new global::System.Windows.Data.Binding
				{
					Source = this._editor,
					Mode = global::System.Windows.Data.BindingMode.TwoWay,
					Path = new global::System.Windows.PropertyPath("IsUndoEnabled", new object[0])
				});
			}
			this.OnSectionsChanged();
		}

		// Token: 0x0600015E RID: 350 RVA: 0x0000AEC2 File Offset: 0x000090C2
		internal void OnSectionsChanged()
		{
			global::Infragistics.Controls.Editors.XamMaskedInput editor = this._editor;
		}

		// Token: 0x0600015F RID: 351 RVA: 0x0000AECB File Offset: 0x000090CB
		internal void OnSyncComplete()
		{
			this._lastTextValue = base.Text;
			this._lastSelectionStart = base.SelectionStart;
			this._lastSelectionLength = base.SelectionLength;
		}

		// Token: 0x06000160 RID: 352 RVA: 0x0000AEF4 File Offset: 0x000090F4
		private void OnSelectionChanged(object sender, global::System.Windows.RoutedEventArgs e)
		{
			if (this._isRestoringOldState)
			{
				return;
			}
			bool flag = null != this.EditInfo;
			if (flag)
			{
				this.EditInfo.SyncWithIMETextBox();
			}
			if (string.Equals(base.Text, this._lastTextValue))
			{
				this.OnSyncComplete();
			}
		}

		// Token: 0x06000161 RID: 353 RVA: 0x0000AF40 File Offset: 0x00009140
		private void OnTextChanged(object sender, global::System.Windows.Controls.TextChangedEventArgs e)
		{
			if (!string.Equals(this._lastTextValue, base.Text))
			{
				if (this._justProcessedTextInput)
				{
					if (this.EditInfo != null)
					{
						this.EditInfo.SyncIMETextBox(false);
					}
					return;
				}
				global::System.Windows.Threading.DispatcherSynchronizationContext dispatcherSynchronizationContext = new global::System.Windows.Threading.DispatcherSynchronizationContext();
				dispatcherSynchronizationContext.Post(new global::System.Threading.SendOrPostCallback(this.VerifyText), null);
			}
		}

		// Token: 0x06000162 RID: 354 RVA: 0x0000AF98 File Offset: 0x00009198
		private void VerifyText(object param)
		{
			if (string.Equals(base.Text, this._lastTextValue))
			{
				return;
			}
			string text = base.Text ?? string.Empty;
			string text2 = this._lastTextValue ?? string.Empty;
			int num = string.IsNullOrEmpty(text) ? 0 : text.Length;
			int num2 = string.IsNullOrEmpty(text2) ? 0 : text2.Length;
			global::Infragistics.Controls.Editors.EditInfo editInfo = this.EditInfo;
			if (editInfo != null && !editInfo.IsTextInputInProgress)
			{
				if (this._editor.IsInEditMode)
				{
					if (this._lastSelectionStart == 0 && this._lastSelectionLength == num2)
					{
						editInfo.SetText(text);
					}
					else if (string.Equals(text, text2.Remove(this._lastSelectionStart, this._lastSelectionLength)))
					{
						editInfo.Delete();
					}
					else if (num >= this._lastSelectionStart && (this._lastSelectionStart == 0 || string.Equals(text.Substring(0, this._lastSelectionStart), text2.Substring(0, this._lastSelectionStart))))
					{
						string text3 = text2.Substring(this._lastSelectionStart + this._lastSelectionLength);
						int num3 = string.IsNullOrEmpty(text3) ? 0 : text3.Length;
						if (num3 == 0 || text.EndsWith(text3))
						{
							string selectedText = text.Substring(this._lastSelectionStart, num - (this._lastSelectionStart + num3));
							bool isRestoringOldState = this._isRestoringOldState;
							try
							{
								this._isRestoringOldState = true;
								base.Text = this._lastTextValue;
								base.SelectionStart = this._lastSelectionStart;
								base.SelectionLength = this._lastSelectionLength;
							}
							finally
							{
								this._isRestoringOldState = isRestoringOldState;
							}
							editInfo.SyncWithIMETextBox();
							editInfo.SelectedText = selectedText;
						}
					}
				}
				editInfo.SyncIMETextBox(false);
			}
		}

		// Token: 0x06000163 RID: 355 RVA: 0x0000B160 File Offset: 0x00009360
		protected override void OnGotFocus(global::System.Windows.RoutedEventArgs e)
		{
			base.OnGotFocus(e);
			this._editor.OnIsFocusWithinChangedHelper(true);
		}

		// Token: 0x06000164 RID: 356 RVA: 0x0000B178 File Offset: 0x00009378
		protected override void OnKeyDown(global::System.Windows.Input.KeyEventArgs e)
		{
			this._enteringEditModeViaMouseDown = null;
			if (this._editor != null)
			{
				this._editor.ProcessKeyDown(e);
			}
			if (!e.Handled)
			{
				base.OnKeyDown(e);
			}
			if (this.EditInfo != null)
			{
				this.EditInfo.SyncIMETextBox(false);
			}
		}

		// Token: 0x06000165 RID: 357 RVA: 0x0000B1C8 File Offset: 0x000093C8
		protected override void OnMouseDown(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			if (!this._editor.MaskInfo.IsBeingEditedAndFocused)
			{
				this._enteringEditModeViaMouseDown = new global::System.DateTime?(global::System.DateTime.Now);
			}
			try
			{
				base.OnMouseDown(e);
			}
			finally
			{
				this._enteringEditModeViaMouseDown = null;
			}
		}

		// Token: 0x06000166 RID: 358 RVA: 0x0000B220 File Offset: 0x00009420
		protected override void OnIsKeyboardFocusedChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			base.OnIsKeyboardFocusedChanged(e);
			this._editor.OnIsFocusWithinChangedHelper((bool)e.NewValue);
		}

		// Token: 0x06000167 RID: 359 RVA: 0x0000B240 File Offset: 0x00009440
		protected override void OnPreviewKeyDown(global::System.Windows.Input.KeyEventArgs e)
		{
			bool flag = false;
			switch (e.Key)
			{
			case global::System.Windows.Input.Key.End:
			case global::System.Windows.Input.Key.Home:
			case global::System.Windows.Input.Key.Left:
			case global::System.Windows.Input.Key.Right:
				flag = true;
				break;
			}
			if (!flag && e.KeyboardDevice != null)
			{
				flag = global::Infragistics.CoreUtilities.HasItems(this._editor.GetMatchingCommands(e.Key, e.KeyboardDevice.Modifiers));
			}
			if (flag)
			{
				this.OnKeyDown(e);
				if (e.Handled)
				{
					return;
				}
			}
			base.OnPreviewKeyDown(e);
		}

		// Token: 0x06000168 RID: 360 RVA: 0x0000B2BE File Offset: 0x000094BE
		protected override void OnTextInput(global::System.Windows.Input.TextCompositionEventArgs e)
		{
			if (this._editor != null && this.EditInfo != null)
			{
				this.EditInfo.ImeTextBox_TextInput(this, e, null);
			}
		}

		// Token: 0x040000B5 RID: 181
		private int _lastSelectionStart;

		// Token: 0x040000B6 RID: 182
		private int _lastSelectionLength;

		// Token: 0x040000B7 RID: 183
		private string _lastTextValue;

		// Token: 0x040000B8 RID: 184
		private global::Infragistics.Controls.Editors.XamMaskedInput _editor;

		// Token: 0x040000B9 RID: 185
		internal global::System.DateTime? _enteringEditModeViaMouseDown;

		// Token: 0x040000BA RID: 186
		private bool _justProcessedTextInput;

		// Token: 0x040000BB RID: 187
		private bool _isRestoringOldState;
	}
}
