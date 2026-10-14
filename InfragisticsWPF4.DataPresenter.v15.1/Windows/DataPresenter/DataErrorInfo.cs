using System;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200009F RID: 159
	internal class DataErrorInfo
	{
		// Token: 0x060007E6 RID: 2022 RVA: 0x00021264 File Offset: 0x0001F464
		internal DataErrorInfo(global::Infragistics.Windows.DataPresenter.DataRecord record, global::Infragistics.Windows.DataPresenter.Field field, global::System.Exception exception, global::Infragistics.Windows.DataPresenter.DataErrorOperation operation, string message)
		{
			this._record = record;
			this._field = field;
			this._exception = exception;
			this._operation = operation;
			this._message = message;
			if (string.IsNullOrEmpty(this._message) && this._exception != null)
			{
				this._message = this._exception.Message;
			}
		}

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x060007E7 RID: 2023 RVA: 0x000212C2 File Offset: 0x0001F4C2
		internal global::Infragistics.Windows.DataPresenter.DataRecord Record
		{
			get
			{
				return this._record;
			}
		}

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x060007E8 RID: 2024 RVA: 0x000212CA File Offset: 0x0001F4CA
		internal global::Infragistics.Windows.DataPresenter.Field Field
		{
			get
			{
				return this._field;
			}
		}

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x060007E9 RID: 2025 RVA: 0x000212D2 File Offset: 0x0001F4D2
		internal global::Infragistics.Windows.DataPresenter.Cell Cell
		{
			get
			{
				if (this._field != null && this._record != null)
				{
					return this._record.Cells[this._field];
				}
				return null;
			}
		}

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x060007EA RID: 2026 RVA: 0x000212FC File Offset: 0x0001F4FC
		internal global::System.Exception Exception
		{
			get
			{
				return this._exception;
			}
		}

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x060007EB RID: 2027 RVA: 0x00021304 File Offset: 0x0001F504
		internal global::Infragistics.Windows.DataPresenter.DataErrorOperation Operation
		{
			get
			{
				return this._operation;
			}
		}

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x060007EC RID: 2028 RVA: 0x0002130C File Offset: 0x0001F50C
		// (set) Token: 0x060007ED RID: 2029 RVA: 0x00021314 File Offset: 0x0001F514
		internal string Message
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

		// Token: 0x0400029C RID: 668
		private global::Infragistics.Windows.DataPresenter.DataRecord _record;

		// Token: 0x0400029D RID: 669
		private global::Infragistics.Windows.DataPresenter.Field _field;

		// Token: 0x0400029E RID: 670
		private global::System.Exception _exception;

		// Token: 0x0400029F RID: 671
		private global::Infragistics.Windows.DataPresenter.DataErrorOperation _operation;

		// Token: 0x040002A0 RID: 672
		private string _message;
	}
}
