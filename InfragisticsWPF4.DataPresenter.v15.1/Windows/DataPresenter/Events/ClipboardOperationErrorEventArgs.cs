using System;
using System.Windows;

namespace Infragistics.Windows.DataPresenter.Events
{
	// Token: 0x020002B8 RID: 696
	public class ClipboardOperationErrorEventArgs : global::System.Windows.RoutedEventArgs
	{
		// Token: 0x06002212 RID: 8722 RVA: 0x0009766C File Offset: 0x0009586C
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

		// Token: 0x170009A9 RID: 2473
		// (get) Token: 0x06002213 RID: 8723 RVA: 0x000976C2 File Offset: 0x000958C2
		// (set) Token: 0x06002214 RID: 8724 RVA: 0x000976CA File Offset: 0x000958CA
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

		// Token: 0x170009AA RID: 2474
		// (get) Token: 0x06002215 RID: 8725 RVA: 0x000976D3 File Offset: 0x000958D3
		public bool CanContinueWithRemainingCells
		{
			get
			{
				return this._canContinueWithRemainingCells;
			}
		}

		// Token: 0x170009AB RID: 2475
		// (get) Token: 0x06002216 RID: 8726 RVA: 0x000976DB File Offset: 0x000958DB
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

		// Token: 0x170009AC RID: 2476
		// (get) Token: 0x06002217 RID: 8727 RVA: 0x00097705 File Offset: 0x00095905
		// (set) Token: 0x06002218 RID: 8728 RVA: 0x0009770D File Offset: 0x0009590D
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

		// Token: 0x170009AD RID: 2477
		// (get) Token: 0x06002219 RID: 8729 RVA: 0x00097716 File Offset: 0x00095916
		public global::Infragistics.Windows.DataPresenter.ClipboardError Error
		{
			get
			{
				return this._error;
			}
		}

		// Token: 0x170009AE RID: 2478
		// (get) Token: 0x0600221A RID: 8730 RVA: 0x0009771E File Offset: 0x0009591E
		public global::System.Exception Exception
		{
			get
			{
				return this._exception;
			}
		}

		// Token: 0x170009AF RID: 2479
		// (get) Token: 0x0600221B RID: 8731 RVA: 0x00097726 File Offset: 0x00095926
		public global::Infragistics.Windows.DataPresenter.Field Field
		{
			get
			{
				return this._field;
			}
		}

		// Token: 0x170009B0 RID: 2480
		// (get) Token: 0x0600221C RID: 8732 RVA: 0x0009772E File Offset: 0x0009592E
		// (set) Token: 0x0600221D RID: 8733 RVA: 0x00097736 File Offset: 0x00095936
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

		// Token: 0x170009B1 RID: 2481
		// (get) Token: 0x0600221E RID: 8734 RVA: 0x0009773F File Offset: 0x0009593F
		public global::Infragistics.Windows.DataPresenter.ClipboardOperation Operation
		{
			get
			{
				return this._operation;
			}
		}

		// Token: 0x170009B2 RID: 2482
		// (get) Token: 0x0600221F RID: 8735 RVA: 0x00097747 File Offset: 0x00095947
		public global::Infragistics.Windows.DataPresenter.DataRecord Record
		{
			get
			{
				return this._record;
			}
		}

		// Token: 0x040010F5 RID: 4341
		private global::Infragistics.Windows.DataPresenter.ClipboardErrorAction _action = global::Infragistics.Windows.DataPresenter.ClipboardErrorAction.ClearCellAndContinue;

		// Token: 0x040010F6 RID: 4342
		private global::Infragistics.Windows.DataPresenter.DataRecord _record;

		// Token: 0x040010F7 RID: 4343
		private global::Infragistics.Windows.DataPresenter.Field _field;

		// Token: 0x040010F8 RID: 4344
		private global::System.Exception _exception;

		// Token: 0x040010F9 RID: 4345
		private global::Infragistics.Windows.DataPresenter.ClipboardOperation _operation;

		// Token: 0x040010FA RID: 4346
		private bool _canContinueWithRemainingCells;

		// Token: 0x040010FB RID: 4347
		private string _message;

		// Token: 0x040010FC RID: 4348
		private global::Infragistics.Windows.DataPresenter.ClipboardError _error;

		// Token: 0x040010FD RID: 4349
		private bool _displayErrorMessage = true;
	}
}
