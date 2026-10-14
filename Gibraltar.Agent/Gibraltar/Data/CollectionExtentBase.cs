using System;

namespace Gibraltar.Data
{
	// Token: 0x020000D5 RID: 213
	internal class CollectionExtentBase : global::Gibraltar.Data.CollectingExtentBase
	{
		// Token: 0x060008DC RID: 2268 RVA: 0x0001376C File Offset: 0x0001196C
		protected internal CollectionExtentBase(global::Gibraltar.Data.ExtentPreamble preamble) : base(preamble)
		{
		}

		// Token: 0x060008DD RID: 2269 RVA: 0x00013778 File Offset: 0x00011978
		protected internal CollectionExtentBase(global::Gibraltar.Data.ExtentTypeCode typeCode, short majorVersion) : base(typeCode, majorVersion)
		{
		}

		// Token: 0x170003E6 RID: 998
		// (get) Token: 0x060008DE RID: 2270 RVA: 0x00013784 File Offset: 0x00011984
		// (set) Token: 0x060008DF RID: 2271 RVA: 0x0001378C File Offset: 0x0001198C
		public override long ChildOffset
		{
			get
			{
				return this.m_ChildOffset;
			}
			internal set
			{
				this.m_ChildOffset = value;
			}
		}

		// Token: 0x040001EB RID: 491
		private long m_ChildOffset;
	}
}
