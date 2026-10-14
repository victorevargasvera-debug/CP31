using System;
using Infragistics.Windows.Controls.Events;

namespace Infragistics.Windows.DataPresenter.Events
{
	// Token: 0x0200027A RID: 634
	public class DataErrorEventArgs : global::Infragistics.Windows.Controls.Events.CancelableRoutedEventArgs
	{
		// Token: 0x06001DB2 RID: 7602 RVA: 0x00081127 File Offset: 0x0007F327
		internal DataErrorEventArgs(global::Infragistics.Windows.DataPresenter.DataErrorInfo info)
		{
			global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNotNull(info);
			this._info = info;
		}

		// Token: 0x17000810 RID: 2064
		// (get) Token: 0x06001DB3 RID: 7603 RVA: 0x0008113C File Offset: 0x0007F33C
		public global::Infragistics.Windows.DataPresenter.Cell Cell
		{
			get
			{
				return this._info.Cell;
			}
		}

		// Token: 0x17000811 RID: 2065
		// (get) Token: 0x06001DB4 RID: 7604 RVA: 0x00081149 File Offset: 0x0007F349
		public global::Infragistics.Windows.DataPresenter.DataRecord Record
		{
			get
			{
				return this._info.Record;
			}
		}

		// Token: 0x17000812 RID: 2066
		// (get) Token: 0x06001DB5 RID: 7605 RVA: 0x00081156 File Offset: 0x0007F356
		public global::System.Exception Exception
		{
			get
			{
				return this._info.Exception;
			}
		}

		// Token: 0x17000813 RID: 2067
		// (get) Token: 0x06001DB6 RID: 7606 RVA: 0x00081163 File Offset: 0x0007F363
		public global::Infragistics.Windows.DataPresenter.Field Field
		{
			get
			{
				return this._info.Field;
			}
		}

		// Token: 0x17000814 RID: 2068
		// (get) Token: 0x06001DB7 RID: 7607 RVA: 0x00081170 File Offset: 0x0007F370
		// (set) Token: 0x06001DB8 RID: 7608 RVA: 0x0008117D File Offset: 0x0007F37D
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

		// Token: 0x17000815 RID: 2069
		// (get) Token: 0x06001DB9 RID: 7609 RVA: 0x0008118B File Offset: 0x0007F38B
		public global::Infragistics.Windows.DataPresenter.DataErrorOperation Operation
		{
			get
			{
				return this._info.Operation;
			}
		}

		// Token: 0x04000E9B RID: 3739
		private global::Infragistics.Windows.DataPresenter.DataErrorInfo _info;
	}
}
