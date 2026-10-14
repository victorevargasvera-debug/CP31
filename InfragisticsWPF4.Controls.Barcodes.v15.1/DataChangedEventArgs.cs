using System;
using System.Runtime.CompilerServices;

namespace Infragistics.Controls.Barcodes
{
	// Token: 0x0200003E RID: 62
	public class DataChangedEventArgs : global::System.EventArgs
	{
		// Token: 0x060001B9 RID: 441 RVA: 0x0001A20F File Offset: 0x0001840F
		public DataChangedEventArgs(string newData)
		{
			this.NewData = newData;
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060001BA RID: 442 RVA: 0x0001A21E File Offset: 0x0001841E
		// (set) Token: 0x060001BB RID: 443 RVA: 0x0001A226 File Offset: 0x00018426
		[global::System.Runtime.CompilerServices.DontObfuscate]
		public string NewData
		{
			get
			{
				return this._newData;
			}
			private set
			{
				this._newData = value;
			}
		}

		// Token: 0x040001A1 RID: 417
		private string _newData;
	}
}
