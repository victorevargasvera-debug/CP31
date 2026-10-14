using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Diagnostics;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x0200037B RID: 891
	internal sealed class AggregateOp : global::System.Data.Entity.Core.Query.InternalTrees.ScalarOp
	{
		// Token: 0x06002B09 RID: 11017 RVA: 0x0008C71B File Offset: 0x0008A91B
		internal AggregateOp(global::System.Data.Entity.Core.Metadata.Edm.EdmFunction aggFunc, bool distinctAgg) : base(global::System.Data.Entity.Core.Query.InternalTrees.OpType.Aggregate, aggFunc.ReturnParameter.TypeUsage)
		{
			this.m_aggFunc = aggFunc;
			this.m_distinctAgg = distinctAgg;
		}

		// Token: 0x06002B0A RID: 11018 RVA: 0x0008C73E File Offset: 0x0008A93E
		private AggregateOp() : base(global::System.Data.Entity.Core.Query.InternalTrees.OpType.Aggregate)
		{
		}

		// Token: 0x170008A5 RID: 2213
		// (get) Token: 0x06002B0B RID: 11019 RVA: 0x0008C748 File Offset: 0x0008A948
		internal global::System.Data.Entity.Core.Metadata.Edm.EdmFunction AggFunc
		{
			get
			{
				return this.m_aggFunc;
			}
		}

		// Token: 0x170008A6 RID: 2214
		// (get) Token: 0x06002B0C RID: 11020 RVA: 0x0008C750 File Offset: 0x0008A950
		internal bool IsDistinctAggregate
		{
			get
			{
				return this.m_distinctAgg;
			}
		}

		// Token: 0x170008A7 RID: 2215
		// (get) Token: 0x06002B0D RID: 11021 RVA: 0x0008C758 File Offset: 0x0008A958
		internal override bool IsAggregateOp
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06002B0E RID: 11022 RVA: 0x0008C75B File Offset: 0x0008A95B
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override void Accept(global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitor v, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			v.Visit(this, n);
		}

		// Token: 0x06002B0F RID: 11023 RVA: 0x0008C765 File Offset: 0x0008A965
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override TResultType Accept<TResultType>(global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitorOfT<TResultType> v, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return v.Visit(this, n);
		}

		// Token: 0x04000EDA RID: 3802
		private readonly global::System.Data.Entity.Core.Metadata.Edm.EdmFunction m_aggFunc;

		// Token: 0x04000EDB RID: 3803
		private readonly bool m_distinctAgg;

		// Token: 0x04000EDC RID: 3804
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.AggregateOp Pattern = new global::System.Data.Entity.Core.Query.InternalTrees.AggregateOp();
	}
}
