using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Diagnostics;
using System.Globalization;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x020003A0 RID: 928
	internal class EntityColumnMap : global::System.Data.Entity.Core.Query.InternalTrees.TypedColumnMap
	{
		// Token: 0x06002D32 RID: 11570 RVA: 0x00090B18 File Offset: 0x0008ED18
		internal EntityColumnMap(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type, string name, global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap[] properties, global::System.Data.Entity.Core.Query.InternalTrees.EntityIdentity entityIdentity) : base(type, name, properties)
		{
			this.m_entityIdentity = entityIdentity;
		}

		// Token: 0x170008DA RID: 2266
		// (get) Token: 0x06002D33 RID: 11571 RVA: 0x00090B2B File Offset: 0x0008ED2B
		internal global::System.Data.Entity.Core.Query.InternalTrees.EntityIdentity EntityIdentity
		{
			get
			{
				return this.m_entityIdentity;
			}
		}

		// Token: 0x06002D34 RID: 11572 RVA: 0x00090B33 File Offset: 0x0008ED33
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override void Accept<TArgType>(global::System.Data.Entity.Core.Query.InternalTrees.ColumnMapVisitor<TArgType> visitor, TArgType arg)
		{
			visitor.Visit(this, arg);
		}

		// Token: 0x06002D35 RID: 11573 RVA: 0x00090B3D File Offset: 0x0008ED3D
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override TResultType Accept<TResultType, TArgType>(global::System.Data.Entity.Core.Query.InternalTrees.ColumnMapVisitorWithResults<TResultType, TArgType> visitor, TArgType arg)
		{
			return visitor.Visit(this, arg);
		}

		// Token: 0x06002D36 RID: 11574 RVA: 0x00090B47 File Offset: 0x0008ED47
		public override string ToString()
		{
			return string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "E{0}", new object[]
			{
				base.ToString()
			});
		}

		// Token: 0x04000F21 RID: 3873
		private readonly global::System.Data.Entity.Core.Query.InternalTrees.EntityIdentity m_entityIdentity;
	}
}
