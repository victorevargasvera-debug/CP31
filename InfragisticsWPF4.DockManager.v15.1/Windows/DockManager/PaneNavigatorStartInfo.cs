using System;

namespace Infragistics.Windows.DockManager
{
	// Token: 0x02000084 RID: 132
	internal class PaneNavigatorStartInfo
	{
		// Token: 0x170000FE RID: 254
		// (get) Token: 0x060004C3 RID: 1219 RVA: 0x0001A462 File Offset: 0x00018662
		// (set) Token: 0x060004C4 RID: 1220 RVA: 0x0001A46A File Offset: 0x0001866A
		public bool CloseWhenModifiersRelease
		{
			get
			{
				return this._closeWhenModifiersReleased;
			}
			set
			{
				this._closeWhenModifiersReleased = value;
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x060004C5 RID: 1221 RVA: 0x0001A473 File Offset: 0x00018673
		// (set) Token: 0x060004C6 RID: 1222 RVA: 0x0001A47B File Offset: 0x0001867B
		public bool? StartWithDocuments
		{
			get
			{
				return this._startWithDocuments;
			}
			set
			{
				this._startWithDocuments = value;
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x060004C7 RID: 1223 RVA: 0x0001A484 File Offset: 0x00018684
		// (set) Token: 0x060004C8 RID: 1224 RVA: 0x0001A48C File Offset: 0x0001868C
		public int ActivationOffset
		{
			get
			{
				return this._activationOffset;
			}
			set
			{
				this._activationOffset = value;
			}
		}

		// Token: 0x04000318 RID: 792
		private bool _closeWhenModifiersReleased;

		// Token: 0x04000319 RID: 793
		private bool? _startWithDocuments = new bool?(true);

		// Token: 0x0400031A RID: 794
		private int _activationOffset;
	}
}
