using System;
using System.Data.Entity.Core.Metadata.Edm;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x02000393 RID: 915
	internal abstract class ConstantBaseOp : global::System.Data.Entity.Core.Query.InternalTrees.ScalarOp
	{
		// Token: 0x06002CBF RID: 11455 RVA: 0x0008F18F File Offset: 0x0008D38F
		protected ConstantBaseOp(global::System.Data.Entity.Core.Query.InternalTrees.OpType opType, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type, object value) : base(opType, type)
		{
			this.m_value = value;
		}

		// Token: 0x06002CC0 RID: 11456 RVA: 0x0008F1A0 File Offset: 0x0008D3A0
		protected ConstantBaseOp(global::System.Data.Entity.Core.Query.InternalTrees.OpType opType) : base(opType)
		{
		}

		// Token: 0x170008C9 RID: 2249
		// (get) Token: 0x06002CC1 RID: 11457 RVA: 0x0008F1A9 File Offset: 0x0008D3A9
		internal virtual object Value
		{
			get
			{
				return this.m_value;
			}
		}

		// Token: 0x170008CA RID: 2250
		// (get) Token: 0x06002CC2 RID: 11458 RVA: 0x0008F1B1 File Offset: 0x0008D3B1
		internal override int Arity
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x06002CC3 RID: 11459 RVA: 0x0008F1B4 File Offset: 0x0008D3B4
		internal override bool IsEquivalent(global::System.Data.Entity.Core.Query.InternalTrees.Op other)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.ConstantBaseOp constantBaseOp = other as global::System.Data.Entity.Core.Query.InternalTrees.ConstantBaseOp;
			return constantBaseOp != null && base.OpType == other.OpType && constantBaseOp.Type.EdmEquals(this.Type) && ((constantBaseOp.Value == null && this.Value == null) || constantBaseOp.Value.Equals(this.Value));
		}

		// Token: 0x04000F0C RID: 3852
		private readonly object m_value;
	}
}
