using System;

namespace Gibraltar.Data
{
	// Token: 0x020000DC RID: 220
	internal class FileExtentBase : global::Gibraltar.Data.CollectingExtentBase
	{
		// Token: 0x06000916 RID: 2326 RVA: 0x0001489C File Offset: 0x00012A9C
		protected internal FileExtentBase(global::Gibraltar.Data.ExtentPreamble preamble) : base(preamble)
		{
		}

		// Token: 0x06000917 RID: 2327 RVA: 0x000148A8 File Offset: 0x00012AA8
		protected internal FileExtentBase(global::Gibraltar.Data.ExtentTypeCode typeCode, short majorVersion) : base(typeCode, majorVersion)
		{
		}

		// Token: 0x170003F5 RID: 1013
		// (get) Token: 0x06000918 RID: 2328 RVA: 0x000148B4 File Offset: 0x00012AB4
		// (set) Token: 0x06000919 RID: 2329 RVA: 0x000148C4 File Offset: 0x00012AC4
		public override long ChildOffset
		{
			get
			{
				return base.Preamble.Offset;
			}
			internal set
			{
				base.Preamble.Offset = value;
			}
		}
	}
}
