using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Diagnostics;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x020003D2 RID: 978
	internal class RefColumnMap : global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap
	{
		// Token: 0x06002EB2 RID: 11954 RVA: 0x00093E56 File Offset: 0x00092056
		internal RefColumnMap(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type, string name, global::System.Data.Entity.Core.Query.InternalTrees.EntityIdentity entityIdentity) : base(type, name)
		{
			this.m_entityIdentity = entityIdentity;
		}

		// Token: 0x17000925 RID: 2341
		// (get) Token: 0x06002EB3 RID: 11955 RVA: 0x00093E67 File Offset: 0x00092067
		internal global::System.Data.Entity.Core.Query.InternalTrees.EntityIdentity EntityIdentity
		{
			get
			{
				return this.m_entityIdentity;
			}
		}

		// Token: 0x06002EB4 RID: 11956 RVA: 0x00093E6F File Offset: 0x0009206F
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override void Accept<TArgType>(global::System.Data.Entity.Core.Query.InternalTrees.ColumnMapVisitor<TArgType> visitor, TArgType arg)
		{
			visitor.Visit(this, arg);
		}

		// Token: 0x06002EB5 RID: 11957 RVA: 0x00093E79 File Offset: 0x00092079
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override TResultType Accept<TResultType, TArgType>(global::System.Data.Entity.Core.Query.InternalTrees.ColumnMapVisitorWithResults<TResultType, TArgType> visitor, TArgType arg)
		{
			return visitor.Visit(this, arg);
		}

		// Token: 0x04000FC0 RID: 4032
		private readonly global::System.Data.Entity.Core.Query.InternalTrees.EntityIdentity m_entityIdentity;
	}
}
