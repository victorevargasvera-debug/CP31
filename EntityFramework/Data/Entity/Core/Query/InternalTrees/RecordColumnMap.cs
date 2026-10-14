using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Diagnostics;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x020003D1 RID: 977
	internal class RecordColumnMap : global::System.Data.Entity.Core.Query.InternalTrees.StructuredColumnMap
	{
		// Token: 0x06002EAE RID: 11950 RVA: 0x00093E27 File Offset: 0x00092027
		internal RecordColumnMap(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type, string name, global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap[] properties, global::System.Data.Entity.Core.Query.InternalTrees.SimpleColumnMap nullSentinel) : base(type, name, properties)
		{
			this.m_nullSentinel = nullSentinel;
		}

		// Token: 0x17000924 RID: 2340
		// (get) Token: 0x06002EAF RID: 11951 RVA: 0x00093E3A File Offset: 0x0009203A
		internal override global::System.Data.Entity.Core.Query.InternalTrees.SimpleColumnMap NullSentinel
		{
			get
			{
				return this.m_nullSentinel;
			}
		}

		// Token: 0x06002EB0 RID: 11952 RVA: 0x00093E42 File Offset: 0x00092042
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override void Accept<TArgType>(global::System.Data.Entity.Core.Query.InternalTrees.ColumnMapVisitor<TArgType> visitor, TArgType arg)
		{
			visitor.Visit(this, arg);
		}

		// Token: 0x06002EB1 RID: 11953 RVA: 0x00093E4C File Offset: 0x0009204C
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override TResultType Accept<TResultType, TArgType>(global::System.Data.Entity.Core.Query.InternalTrees.ColumnMapVisitorWithResults<TResultType, TArgType> visitor, TArgType arg)
		{
			return visitor.Visit(this, arg);
		}

		// Token: 0x04000FBF RID: 4031
		private readonly global::System.Data.Entity.Core.Query.InternalTrees.SimpleColumnMap m_nullSentinel;
	}
}
