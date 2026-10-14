using System;
using System.Data.Entity.Core.Metadata.Edm;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x020003DE RID: 990
	internal abstract class ScalarOp : global::System.Data.Entity.Core.Query.InternalTrees.Op
	{
		// Token: 0x06002EEA RID: 12010 RVA: 0x000943FA File Offset: 0x000925FA
		internal ScalarOp(global::System.Data.Entity.Core.Query.InternalTrees.OpType opType, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type) : this(opType)
		{
			this.m_type = type;
		}

		// Token: 0x06002EEB RID: 12011 RVA: 0x0009440A File Offset: 0x0009260A
		protected ScalarOp(global::System.Data.Entity.Core.Query.InternalTrees.OpType opType) : base(opType)
		{
		}

		// Token: 0x17000933 RID: 2355
		// (get) Token: 0x06002EEC RID: 12012 RVA: 0x00094413 File Offset: 0x00092613
		internal override bool IsScalarOp
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06002EED RID: 12013 RVA: 0x00094416 File Offset: 0x00092616
		internal override bool IsEquivalent(global::System.Data.Entity.Core.Query.InternalTrees.Op other)
		{
			return other.OpType == base.OpType && global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsStructurallyEqual(this.Type, other.Type);
		}

		// Token: 0x17000934 RID: 2356
		// (get) Token: 0x06002EEE RID: 12014 RVA: 0x00094439 File Offset: 0x00092639
		// (set) Token: 0x06002EEF RID: 12015 RVA: 0x00094441 File Offset: 0x00092641
		internal override global::System.Data.Entity.Core.Metadata.Edm.TypeUsage Type
		{
			get
			{
				return this.m_type;
			}
			set
			{
				this.m_type = value;
			}
		}

		// Token: 0x17000935 RID: 2357
		// (get) Token: 0x06002EF0 RID: 12016 RVA: 0x0009444A File Offset: 0x0009264A
		internal virtual bool IsAggregateOp
		{
			get
			{
				return false;
			}
		}

		// Token: 0x04000FD4 RID: 4052
		private global::System.Data.Entity.Core.Metadata.Edm.TypeUsage m_type;
	}
}
