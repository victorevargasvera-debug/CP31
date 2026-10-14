using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Diagnostics;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x020003D0 RID: 976
	internal sealed class PropertyOp : global::System.Data.Entity.Core.Query.InternalTrees.ScalarOp
	{
		// Token: 0x06002EA6 RID: 11942 RVA: 0x00093DAA File Offset: 0x00091FAA
		internal PropertyOp(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type, global::System.Data.Entity.Core.Metadata.Edm.EdmMember property) : base(global::System.Data.Entity.Core.Query.InternalTrees.OpType.Property, type)
		{
			this.m_property = property;
		}

		// Token: 0x06002EA7 RID: 11943 RVA: 0x00093DBC File Offset: 0x00091FBC
		private PropertyOp() : base(global::System.Data.Entity.Core.Query.InternalTrees.OpType.Property)
		{
		}

		// Token: 0x17000922 RID: 2338
		// (get) Token: 0x06002EA8 RID: 11944 RVA: 0x00093DC6 File Offset: 0x00091FC6
		internal override int Arity
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x17000923 RID: 2339
		// (get) Token: 0x06002EA9 RID: 11945 RVA: 0x00093DC9 File Offset: 0x00091FC9
		internal global::System.Data.Entity.Core.Metadata.Edm.EdmMember PropertyInfo
		{
			get
			{
				return this.m_property;
			}
		}

		// Token: 0x06002EAA RID: 11946 RVA: 0x00093DD1 File Offset: 0x00091FD1
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override void Accept(global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitor v, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			v.Visit(this, n);
		}

		// Token: 0x06002EAB RID: 11947 RVA: 0x00093DDB File Offset: 0x00091FDB
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override TResultType Accept<TResultType>(global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitorOfT<TResultType> v, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return v.Visit(this, n);
		}

		// Token: 0x06002EAC RID: 11948 RVA: 0x00093DE8 File Offset: 0x00091FE8
		internal override bool IsEquivalent(global::System.Data.Entity.Core.Query.InternalTrees.Op other)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.PropertyOp propertyOp = other as global::System.Data.Entity.Core.Query.InternalTrees.PropertyOp;
			return propertyOp != null && propertyOp.PropertyInfo.EdmEquals(this.PropertyInfo) && base.IsEquivalent(other);
		}

		// Token: 0x04000FBD RID: 4029
		private readonly global::System.Data.Entity.Core.Metadata.Edm.EdmMember m_property;

		// Token: 0x04000FBE RID: 4030
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.PropertyOp Pattern = new global::System.Data.Entity.Core.Query.InternalTrees.PropertyOp();
	}
}
