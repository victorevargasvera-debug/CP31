using System;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200011C RID: 284
	public class ProcessRecordParams
	{
		// Token: 0x17000429 RID: 1065
		// (get) Token: 0x060010F5 RID: 4341 RVA: 0x0004B893 File Offset: 0x00049A93
		// (set) Token: 0x060010F6 RID: 4342 RVA: 0x0004B89B File Offset: 0x00049A9B
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

		// Token: 0x1700042A RID: 1066
		// (get) Token: 0x060010F7 RID: 4343 RVA: 0x0004B8A4 File Offset: 0x00049AA4
		// (set) Token: 0x060010F8 RID: 4344 RVA: 0x0004B8AC File Offset: 0x00049AAC
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

		// Token: 0x1700042B RID: 1067
		// (get) Token: 0x060010F9 RID: 4345 RVA: 0x0004B8B5 File Offset: 0x00049AB5
		// (set) Token: 0x060010FA RID: 4346 RVA: 0x0004B8BD File Offset: 0x00049ABD
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

		// Token: 0x060010FB RID: 4347 RVA: 0x0004B8C6 File Offset: 0x00049AC6
		internal void Reset()
		{
			this._skipDescendants = false;
			this._skipSiblings = false;
			this._terminateExport = false;
		}

		// Token: 0x040006DB RID: 1755
		private bool _skipDescendants;

		// Token: 0x040006DC RID: 1756
		private bool _skipSiblings;

		// Token: 0x040006DD RID: 1757
		private bool _terminateExport;
	}
}
