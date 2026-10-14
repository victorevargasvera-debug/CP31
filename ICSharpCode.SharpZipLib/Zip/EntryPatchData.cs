using System;

namespace ICSharpCode.SharpZipLib.Zip
{
	// Token: 0x0200002C RID: 44
	internal class EntryPatchData
	{
		// Token: 0x17000067 RID: 103
		// (get) Token: 0x060001A9 RID: 425 RVA: 0x000082C8 File Offset: 0x000064C8
		// (set) Token: 0x060001AA RID: 426 RVA: 0x000082D0 File Offset: 0x000064D0
		public long SizePatchOffset
		{
			get
			{
				return this.sizePatchOffset_;
			}
			set
			{
				this.sizePatchOffset_ = value;
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x060001AB RID: 427 RVA: 0x000082D9 File Offset: 0x000064D9
		// (set) Token: 0x060001AC RID: 428 RVA: 0x000082E1 File Offset: 0x000064E1
		public long CrcPatchOffset
		{
			get
			{
				return this.crcPatchOffset_;
			}
			set
			{
				this.crcPatchOffset_ = value;
			}
		}

		// Token: 0x040000ED RID: 237
		private long sizePatchOffset_;

		// Token: 0x040000EE RID: 238
		private long crcPatchOffset_;
	}
}
