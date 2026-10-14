using System;
using Infragistics.Windows.Controls.Events;

namespace Infragistics.Windows.DataPresenter.Events
{
	// Token: 0x020002BD RID: 701
	public class DataErrorEventArgs : global::Infragistics.Windows.Controls.Events.CancelableRoutedEventArgs
	{
		// Token: 0x06002236 RID: 8758 RVA: 0x00097887 File Offset: 0x00095A87
		internal DataErrorEventArgs(global::Infragistics.Windows.DataPresenter.DataErrorInfo info)
		{
			global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNotNull(info);
			this._info = info;
		}

		// Token: 0x170009B9 RID: 2489
		// (get) Token: 0x06002237 RID: 8759 RVA: 0x0009789C File Offset: 0x00095A9C
		public global::Infragistics.Windows.DataPresenter.Cell Cell
		{
			get
			{
				return this._info.Cell;
			}
		}

		// Token: 0x170009BA RID: 2490
		// (get) Token: 0x06002238 RID: 8760 RVA: 0x000978A9 File Offset: 0x00095AA9
		public global::Infragistics.Windows.DataPresenter.DataRecord Record
		{
			get
			{
				return this._info.Record;
			}
		}

		// Token: 0x170009BB RID: 2491
		// (get) Token: 0x06002239 RID: 8761 RVA: 0x000978B6 File Offset: 0x00095AB6
		public global::System.Exception Exception
		{
			get
			{
				return this._info.Exception;
			}
		}

		// Token: 0x170009BC RID: 2492
		// (get) Token: 0x0600223A RID: 8762 RVA: 0x000978C3 File Offset: 0x00095AC3
		public global::Infragistics.Windows.DataPresenter.Field Field
		{
			get
			{
				return this._info.Field;
			}
		}

		// Token: 0x170009BD RID: 2493
		// (get) Token: 0x0600223B RID: 8763 RVA: 0x000978D0 File Offset: 0x00095AD0
		// (set) Token: 0x0600223C RID: 8764 RVA: 0x000978DD File Offset: 0x00095ADD
		public string Message
		{
			get
			{
				return this._info.Message;
			}
			set
			{
				this._info.Message = value;
			}
		}

		// Token: 0x170009BE RID: 2494
		// (get) Token: 0x0600223D RID: 8765 RVA: 0x000978EB File Offset: 0x00095AEB
		public global::Infragistics.Windows.DataPresenter.DataErrorOperation Operation
		{
			get
			{
				return this._info.Operation;
			}
		}

		// Token: 0x04001102 RID: 4354
		private global::Infragistics.Windows.DataPresenter.DataErrorInfo _info;
	}
}
