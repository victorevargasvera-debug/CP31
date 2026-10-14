using System;
using System.Runtime.CompilerServices;

namespace Infragistics
{
	// Token: 0x02000033 RID: 51
	public class ErrorMessageDisplayingEventArgs : global::System.EventArgs
	{
		// Token: 0x060002D7 RID: 727 RVA: 0x0000CABF File Offset: 0x0000ACBF
		public ErrorMessageDisplayingEventArgs(string errorMessage)
		{
			this.ErrorMessage = errorMessage;
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x060002D8 RID: 728 RVA: 0x0000CACE File Offset: 0x0000ACCE
		// (set) Token: 0x060002D9 RID: 729 RVA: 0x0000CAD6 File Offset: 0x0000ACD6
		[global::System.Runtime.CompilerServices.DontObfuscate]
		public string ErrorMessage
		{
			get
			{
				return this._errorMessage;
			}
			set
			{
				this._errorMessage = value;
			}
		}

		// Token: 0x04000112 RID: 274
		private string _errorMessage;
	}
}
