using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Diagnostics;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x020003D7 RID: 983
	internal sealed class RelPropertyOp : global::System.Data.Entity.Core.Query.InternalTrees.ScalarOp
	{
		// Token: 0x06002ECB RID: 11979 RVA: 0x0009413A File Offset: 0x0009233A
		private RelPropertyOp() : base(global::System.Data.Entity.Core.Query.InternalTrees.OpType.RelProperty)
		{
		}

		// Token: 0x06002ECC RID: 11980 RVA: 0x00094144 File Offset: 0x00092344
		internal RelPropertyOp(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type, global::System.Data.Entity.Core.Query.InternalTrees.RelProperty property) : base(global::System.Data.Entity.Core.Query.InternalTrees.OpType.RelProperty, type)
		{
			this.m_property = property;
		}

		// Token: 0x1700092C RID: 2348
		// (get) Token: 0x06002ECD RID: 11981 RVA: 0x00094156 File Offset: 0x00092356
		internal override int Arity
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x1700092D RID: 2349
		// (get) Token: 0x06002ECE RID: 11982 RVA: 0x00094159 File Offset: 0x00092359
		public global::System.Data.Entity.Core.Query.InternalTrees.RelProperty PropertyInfo
		{
			get
			{
				return this.m_property;
			}
		}

		// Token: 0x06002ECF RID: 11983 RVA: 0x00094161 File Offset: 0x00092361
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override void Accept(global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitor v, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			v.Visit(this, n);
		}

		// Token: 0x06002ED0 RID: 11984 RVA: 0x0009416B File Offset: 0x0009236B
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override TResultType Accept<TResultType>(global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitorOfT<TResultType> v, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return v.Visit(this, n);
		}

		// Token: 0x04000FC8 RID: 4040
		private readonly global::System.Data.Entity.Core.Query.InternalTrees.RelProperty m_property;

		// Token: 0x04000FC9 RID: 4041
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.RelPropertyOp Pattern = new global::System.Data.Entity.Core.Query.InternalTrees.RelPropertyOp();
	}
}
