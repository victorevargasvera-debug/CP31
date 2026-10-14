using System;
using System.Collections.Generic;

namespace Gibraltar.Data
{
	// Token: 0x020000D4 RID: 212
	internal abstract class CollectingExtentBase : global::Gibraltar.Data.ExtentBase
	{
		// Token: 0x060008D8 RID: 2264 RVA: 0x00013740 File Offset: 0x00011940
		protected internal CollectingExtentBase(global::Gibraltar.Data.ExtentPreamble preamble) : base(preamble)
		{
		}

		// Token: 0x060008D9 RID: 2265 RVA: 0x00013754 File Offset: 0x00011954
		protected internal CollectingExtentBase(global::Gibraltar.Data.ExtentTypeCode typeCode, short majorVersion) : base(typeCode, majorVersion)
		{
		}

		// Token: 0x170003E5 RID: 997
		// (get) Token: 0x060008DA RID: 2266
		// (set) Token: 0x060008DB RID: 2267
		public abstract long ChildOffset { get; internal set; }

		// Token: 0x040001EA RID: 490
		private readonly global::System.Collections.Generic.List<global::Gibraltar.Data.ExtentBase> m_ExtentCollection = new global::System.Collections.Generic.List<global::Gibraltar.Data.ExtentBase>();
	}
}
