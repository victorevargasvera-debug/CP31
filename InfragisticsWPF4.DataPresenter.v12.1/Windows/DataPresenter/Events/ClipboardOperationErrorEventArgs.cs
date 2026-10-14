using System;
using System.Windows;

namespace Infragistics.Windows.DataPresenter.Events
{
	// Token: 0x02000275 RID: 629
	public class ClipboardOperationErrorEventArgs : global::System.Windows.RoutedEventArgs
	{
		// Token: 0x06001D8E RID: 7566 RVA: 0x00080F0C File Offset: 0x0007F10C
		internal ClipboardOperationErrorEventArgs(global::Infragistics.Windows.DataPresenter.ClipboardOperation operation, global::Infragistics.Windows.DataPresenter.ClipboardError error, global::Infragistics.Windows.DataPresenter.DataRecord record, global::Infragistics.Windows.DataPresenter.Field field, string errorMessage, global::System.Exception exception, bool canContinueWithRemainingCells)
		{
			this._record = record;
			this._field = field;
			this._error = error;
			this._exception = exception;
			this._operation = operation;
			this._canContinueWithRemainingCells = canContinueWithRemainingCells;
			this._message = errorMessage;
		}

		// Token: 0x17000800 RID: 2048
		// (get) Token: 0x06001D8F RID: 7567 RVA: 0x00080F62 File Offset: 0x0007F162
		// (set) Token: 0x06001D90 RID: 7568 RVA: 0x00080F6A File Offset: 0x0007F16A
		public global::Infragistics.Windows.DataPresenter.ClipboardErrorAction Action
		{
			get
			{
				return this._action;
			}
			set
			{
				this._action = value;
			}
		}

		// Token: 0x17000801 RID: 2049
		// (get) Token: 0x06001D91 RID: 7569 RVA: 0x00080F73 File Offset: 0x0007F173
		public bool CanContinueWithRemainingCells
		{
			get
			{
				return this._canContinueWithRemainingCells;
			}
		}

		// Token: 0x17000802 RID: 2050
		// (get) Token: 0x06001D92 RID: 7570 RVA: 0x00080F7B File Offset: 0x0007F17B
		public global::Infragistics.Windows.DataPresenter.Cell Cell
		{
			get
			{
				if (this._record != null && this._field != null)
				{
					return this._record.Cells[this._field];
				}
				return null;
			}
		}

		// Token: 0x17000803 RID: 2051
		// (get) Token: 0x06001D93 RID: 7571 RVA: 0x00080FA5 File Offset: 0x0007F1A5
		// (set) Token: 0x06001D94 RID: 7572 RVA: 0x00080FAD File Offset: 0x0007F1AD
		public bool DisplayErrorMessage
		{
			get
			{
				return this._displayErrorMessage;
			}
			set
			{
				this._displayErrorMessage = value;
			}
		}

		// Token: 0x17000804 RID: 2052
		// (get) Token: 0x06001D95 RID: 7573 RVA: 0x00080FB6 File Offset: 0x0007F1B6
		public global::Infragistics.Windows.DataPresenter.ClipboardError Error
		{
			get
			{
				return this._error;
			}
		}

		// Token: 0x17000805 RID: 2053
		// (get) Token: 0x06001D96 RID: 7574 RVA: 0x00080FBE File Offset: 0x0007F1BE
		public global::System.Exception Exception
		{
			get
			{
				return this._exception;
			}
		}

		// Token: 0x17000806 RID: 2054
		// (get) Token: 0x06001D97 RID: 7575 RVA: 0x00080FC6 File Offset: 0x0007F1C6
		public global::Infragistics.Windows.DataPresenter.Field Field
		{
			get
			{
				return this._field;
			}
		}

		// Token: 0x17000807 RID: 2055
		// (get) Token: 0x06001D98 RID: 7576 RVA: 0x00080FCE File Offset: 0x0007F1CE
		// (set) Token: 0x06001D99 RID: 7577 RVA: 0x00080FD6 File Offset: 0x0007F1D6
		public string Message
		{
			get
			{
				return this._message;
			}
			set
			{
				this._message = value;
			}
		}

		// Token: 0x17000808 RID: 2056
		// (get) Token: 0x06001D9A RID: 7578 RVA: 0x00080FDF File Offset: 0x0007F1DF
		public global::Infragistics.Windows.DataPresenter.ClipboardOperation Operation
		{
			get
			{
				return this._operation;
			}
		}

		// Token: 0x17000809 RID: 2057
		// (get) Token: 0x06001D9B RID: 7579 RVA: 0x00080FE7 File Offset: 0x0007F1E7
		public global::Infragistics.Windows.DataPresenter.DataRecord Record
		{
			get
			{
				return this._record;
			}
		}

		// Token: 0x04000E8E RID: 3726
		private global::Infragistics.Windows.DataPresenter.ClipboardErrorAction _action = global::Infragistics.Windows.DataPresenter.ClipboardErrorAction.ClearCellAndContinue;

		// Token: 0x04000E8F RID: 3727
		private global::Infragistics.Windows.DataPresenter.DataRecord _record;

		// Token: 0x04000E90 RID: 3728
		private global::Infragistics.Windows.DataPresenter.Field _field;

		// Token: 0x04000E91 RID: 3729
		private global::System.Exception _exception;

		// Token: 0x04000E92 RID: 3730
		private global::Infragistics.Windows.DataPresenter.ClipboardOperation _operation;

		// Token: 0x04000E93 RID: 3731
		private bool _canContinueWithRemainingCells;

		// Token: 0x04000E94 RID: 3732
		private string _message;

		// Token: 0x04000E95 RID: 3733
		private global::Infragistics.Windows.DataPresenter.ClipboardError _error;

		// Token: 0x04000E96 RID: 3734
		private bool _displayErrorMessage = true;
	}
}
