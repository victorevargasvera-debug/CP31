using System;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000099 RID: 153
	internal class DataErrorInfo
	{
		// Token: 0x0600075E RID: 1886 RVA: 0x0001E298 File Offset: 0x0001C498
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

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x0600075F RID: 1887 RVA: 0x0001E2F6 File Offset: 0x0001C4F6
		internal global::Infragistics.Windows.DataPresenter.DataRecord Record
		{
			get
			{
				return this._record;
			}
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x06000760 RID: 1888 RVA: 0x0001E2FE File Offset: 0x0001C4FE
		internal global::Infragistics.Windows.DataPresenter.Field Field
		{
			get
			{
				return this._field;
			}
		}

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x06000761 RID: 1889 RVA: 0x0001E306 File Offset: 0x0001C506
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

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x06000762 RID: 1890 RVA: 0x0001E330 File Offset: 0x0001C530
		internal global::System.Exception Exception
		{
			get
			{
				return this._exception;
			}
		}

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x06000763 RID: 1891 RVA: 0x0001E338 File Offset: 0x0001C538
		internal global::Infragistics.Windows.DataPresenter.DataErrorOperation Operation
		{
			get
			{
				return this._operation;
			}
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x06000764 RID: 1892 RVA: 0x0001E340 File Offset: 0x0001C540
		// (set) Token: 0x06000765 RID: 1893 RVA: 0x0001E348 File Offset: 0x0001C548
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

		// Token: 0x04000257 RID: 599
		private global::Infragistics.Windows.DataPresenter.DataRecord _record;

		// Token: 0x04000258 RID: 600
		private global::Infragistics.Windows.DataPresenter.Field _field;

		// Token: 0x04000259 RID: 601
		private global::System.Exception _exception;

		// Token: 0x0400025A RID: 602
		private global::Infragistics.Windows.DataPresenter.DataErrorOperation _operation;

		// Token: 0x0400025B RID: 603
		private string _message;
	}
}
