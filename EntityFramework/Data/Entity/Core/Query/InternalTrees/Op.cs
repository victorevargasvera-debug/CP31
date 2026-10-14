using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Resources;
using System.Diagnostics;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x020003C6 RID: 966
	internal abstract class Op
	{
		// Token: 0x06002E2C RID: 11820 RVA: 0x00092D98 File Offset: 0x00090F98
		internal Op(global::System.Data.Entity.Core.Query.InternalTrees.OpType opType)
		{
			this.m_opType = opType;
		}

		// Token: 0x17000914 RID: 2324
		// (get) Token: 0x06002E2D RID: 11821 RVA: 0x00092DA7 File Offset: 0x00090FA7
		internal global::System.Data.Entity.Core.Query.InternalTrees.OpType OpType
		{
			get
			{
				return this.m_opType;
			}
		}

		// Token: 0x17000915 RID: 2325
		// (get) Token: 0x06002E2E RID: 11822 RVA: 0x00092DAF File Offset: 0x00090FAF
		internal virtual int Arity
		{
			get
			{
				return -1;
			}
		}

		// Token: 0x17000916 RID: 2326
		// (get) Token: 0x06002E2F RID: 11823 RVA: 0x00092DB2 File Offset: 0x00090FB2
		internal virtual bool IsScalarOp
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000917 RID: 2327
		// (get) Token: 0x06002E30 RID: 11824 RVA: 0x00092DB5 File Offset: 0x00090FB5
		internal virtual bool IsRulePatternOp
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000918 RID: 2328
		// (get) Token: 0x06002E31 RID: 11825 RVA: 0x00092DB8 File Offset: 0x00090FB8
		internal virtual bool IsRelOp
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000919 RID: 2329
		// (get) Token: 0x06002E32 RID: 11826 RVA: 0x00092DBB File Offset: 0x00090FBB
		internal virtual bool IsAncillaryOp
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700091A RID: 2330
		// (get) Token: 0x06002E33 RID: 11827 RVA: 0x00092DBE File Offset: 0x00090FBE
		internal virtual bool IsPhysicalOp
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06002E34 RID: 11828 RVA: 0x00092DC1 File Offset: 0x00090FC1
		internal virtual bool IsEquivalent(global::System.Data.Entity.Core.Query.InternalTrees.Op other)
		{
			return false;
		}

		// Token: 0x1700091B RID: 2331
		// (get) Token: 0x06002E35 RID: 11829 RVA: 0x00092DC4 File Offset: 0x00090FC4
		// (set) Token: 0x06002E36 RID: 11830 RVA: 0x00092DC7 File Offset: 0x00090FC7
		internal virtual global::System.Data.Entity.Core.Metadata.Edm.TypeUsage Type
		{
			get
			{
				return null;
			}
			set
			{
				throw global::System.Data.Entity.Resources.Error.NotSupported();
			}
		}

		// Token: 0x06002E37 RID: 11831 RVA: 0x00092DCE File Offset: 0x00090FCE
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal virtual void Accept(global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitor v, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			v.Visit(this, n);
		}

		// Token: 0x06002E38 RID: 11832 RVA: 0x00092DD8 File Offset: 0x00090FD8
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal virtual TResultType Accept<TResultType>(global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitorOfT<TResultType> v, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return v.Visit(this, n);
		}

		// Token: 0x04000F63 RID: 3939
		private readonly global::System.Data.Entity.Core.Query.InternalTrees.OpType m_opType;

		// Token: 0x04000F64 RID: 3940
		internal const int ArityVarying = -1;
	}
}
