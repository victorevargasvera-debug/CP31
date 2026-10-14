using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x020003EB RID: 1003
	internal class SingleStreamNestOp : global::System.Data.Entity.Core.Query.InternalTrees.NestBaseOp
	{
		// Token: 0x17000941 RID: 2369
		// (get) Token: 0x06002F1F RID: 12063 RVA: 0x000947A5 File Offset: 0x000929A5
		internal override int Arity
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x17000942 RID: 2370
		// (get) Token: 0x06002F20 RID: 12064 RVA: 0x000947A8 File Offset: 0x000929A8
		internal global::System.Data.Entity.Core.Query.InternalTrees.Var Discriminator
		{
			get
			{
				return this.m_discriminator;
			}
		}

		// Token: 0x17000943 RID: 2371
		// (get) Token: 0x06002F21 RID: 12065 RVA: 0x000947B0 File Offset: 0x000929B0
		internal global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.SortKey> PostfixSortKeys
		{
			get
			{
				return this.m_postfixSortKeys;
			}
		}

		// Token: 0x17000944 RID: 2372
		// (get) Token: 0x06002F22 RID: 12066 RVA: 0x000947B8 File Offset: 0x000929B8
		internal global::System.Data.Entity.Core.Query.InternalTrees.VarVec Keys
		{
			get
			{
				return this.m_keys;
			}
		}

		// Token: 0x06002F23 RID: 12067 RVA: 0x000947C0 File Offset: 0x000929C0
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override void Accept(global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitor v, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			v.Visit(this, n);
		}

		// Token: 0x06002F24 RID: 12068 RVA: 0x000947CA File Offset: 0x000929CA
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override TResultType Accept<TResultType>(global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitorOfT<TResultType> v, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return v.Visit(this, n);
		}

		// Token: 0x06002F25 RID: 12069 RVA: 0x000947D4 File Offset: 0x000929D4
		internal SingleStreamNestOp(global::System.Data.Entity.Core.Query.InternalTrees.VarVec keys, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.SortKey> prefixSortKeys, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.SortKey> postfixSortKeys, global::System.Data.Entity.Core.Query.InternalTrees.VarVec outputVars, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.CollectionInfo> collectionInfoList, global::System.Data.Entity.Core.Query.InternalTrees.Var discriminatorVar) : base(global::System.Data.Entity.Core.Query.InternalTrees.OpType.SingleStreamNest, prefixSortKeys, outputVars, collectionInfoList)
		{
			this.m_keys = keys;
			this.m_postfixSortKeys = postfixSortKeys;
			this.m_discriminator = discriminatorVar;
		}

		// Token: 0x04000FE1 RID: 4065
		private readonly global::System.Data.Entity.Core.Query.InternalTrees.VarVec m_keys;

		// Token: 0x04000FE2 RID: 4066
		private readonly global::System.Data.Entity.Core.Query.InternalTrees.Var m_discriminator;

		// Token: 0x04000FE3 RID: 4067
		private readonly global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.SortKey> m_postfixSortKeys;
	}
}
