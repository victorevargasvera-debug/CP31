using System;
using System.ComponentModel;

namespace SourceGrid
{
	// Token: 0x02000388 RID: 904
	internal class ChangeActivePositionEventArgs : global::System.ComponentModel.CancelEventArgs
	{
		// Token: 0x06002AB2 RID: 10930 RVA: 0x0008FCA0 File Offset: 0x0008DEA0
		public ChangeActivePositionEventArgs(global::SourceGrid.Position pOldFocusPosition, global::SourceGrid.Position pNewFocusPosition) : base(false)
		{
			this.mOldFocusPosition = pOldFocusPosition;
			this.mNewFocusPosition = pNewFocusPosition;
		}

		// Token: 0x17000CB4 RID: 3252
		// (get) Token: 0x06002AB3 RID: 10931 RVA: 0x0008FCB8 File Offset: 0x0008DEB8
		public global::SourceGrid.Position OldFocusPosition
		{
			get
			{
				return this.mOldFocusPosition;
			}
		}

		// Token: 0x17000CB5 RID: 3253
		// (get) Token: 0x06002AB4 RID: 10932 RVA: 0x0008FCC0 File Offset: 0x0008DEC0
		public global::SourceGrid.Position NewFocusPosition
		{
			get
			{
				return this.mNewFocusPosition;
			}
		}

		// Token: 0x04000E5C RID: 3676
		private global::SourceGrid.Position mOldFocusPosition;

		// Token: 0x04000E5D RID: 3677
		private global::SourceGrid.Position mNewFocusPosition;
	}
}
