using System;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000100 RID: 256
	public class ProcessRecordParams
	{
		// Token: 0x170002EA RID: 746
		// (get) Token: 0x06000D94 RID: 3476 RVA: 0x0003ADD3 File Offset: 0x00038FD3
		// (set) Token: 0x06000D95 RID: 3477 RVA: 0x0003ADDB File Offset: 0x00038FDB
		public bool SkipDescendants
		{
			get
			{
				return this._skipDescendants;
			}
			set
			{
				this._skipDescendants = value;
			}
		}

		// Token: 0x170002EB RID: 747
		// (get) Token: 0x06000D96 RID: 3478 RVA: 0x0003ADE4 File Offset: 0x00038FE4
		// (set) Token: 0x06000D97 RID: 3479 RVA: 0x0003ADEC File Offset: 0x00038FEC
		public bool SkipSiblings
		{
			get
			{
				return this._skipSiblings;
			}
			set
			{
				this._skipSiblings = value;
			}
		}

		// Token: 0x170002EC RID: 748
		// (get) Token: 0x06000D98 RID: 3480 RVA: 0x0003ADF5 File Offset: 0x00038FF5
		// (set) Token: 0x06000D99 RID: 3481 RVA: 0x0003ADFD File Offset: 0x00038FFD
		public bool TerminateExport
		{
			get
			{
				return this._terminateExport;
			}
			set
			{
				this._terminateExport = value;
			}
		}

		// Token: 0x06000D9A RID: 3482 RVA: 0x0003AE06 File Offset: 0x00039006
		internal void Reset()
		{
			this._skipDescendants = false;
			this._skipSiblings = false;
			this._terminateExport = false;
		}

		// Token: 0x0400053C RID: 1340
		private bool _skipDescendants;

		// Token: 0x0400053D RID: 1341
		private bool _skipSiblings;

		// Token: 0x0400053E RID: 1342
		private bool _terminateExport;
	}
}
