using System;
using System.ComponentModel;

namespace Infragistics.Windows.Reporting.Events
{
	// Token: 0x0200000B RID: 11
	public class PrintProgressEventArgs : global::System.ComponentModel.CancelEventArgs
	{
		// Token: 0x06000041 RID: 65 RVA: 0x000032BF File Offset: 0x000014BF
		public PrintProgressEventArgs(int currenPage, string description, double percentCompleted)
		{
			base.Cancel = false;
			this._currentPageNumber = currenPage;
			this._description = description;
			this._percentCompleted = percentCompleted;
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000042 RID: 66 RVA: 0x000032E3 File Offset: 0x000014E3
		public int CurrentPageNumber
		{
			get
			{
				return this._currentPageNumber;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000043 RID: 67 RVA: 0x000032EB File Offset: 0x000014EB
		// (set) Token: 0x06000044 RID: 68 RVA: 0x000032F3 File Offset: 0x000014F3
		public string Description
		{
			get
			{
				return this._description;
			}
			set
			{
				this._description = value;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000045 RID: 69 RVA: 0x000032FC File Offset: 0x000014FC
		public double PercentCompleted
		{
			get
			{
				return this._percentCompleted;
			}
		}

		// Token: 0x0400001F RID: 31
		private int _currentPageNumber;

		// Token: 0x04000020 RID: 32
		private string _description;

		// Token: 0x04000021 RID: 33
		private double _percentCompleted;
	}
}
