using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Diagnostics;
using System.Globalization;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x02000390 RID: 912
	internal class ComplexTypeColumnMap : global::System.Data.Entity.Core.Query.InternalTrees.TypedColumnMap
	{
		// Token: 0x06002CB4 RID: 11444 RVA: 0x0008F0D0 File Offset: 0x0008D2D0
		internal ComplexTypeColumnMap(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type, string name, global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap[] properties, global::System.Data.Entity.Core.Query.InternalTrees.SimpleColumnMap nullSentinel) : base(type, name, properties)
		{
			this.m_nullSentinel = nullSentinel;
		}

		// Token: 0x170008C8 RID: 2248
		// (get) Token: 0x06002CB5 RID: 11445 RVA: 0x0008F0E3 File Offset: 0x0008D2E3
		internal override global::System.Data.Entity.Core.Query.InternalTrees.SimpleColumnMap NullSentinel
		{
			get
			{
				return this.m_nullSentinel;
			}
		}

		// Token: 0x06002CB6 RID: 11446 RVA: 0x0008F0EB File Offset: 0x0008D2EB
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override void Accept<TArgType>(global::System.Data.Entity.Core.Query.InternalTrees.ColumnMapVisitor<TArgType> visitor, TArgType arg)
		{
			visitor.Visit(this, arg);
		}

		// Token: 0x06002CB7 RID: 11447 RVA: 0x0008F0F5 File Offset: 0x0008D2F5
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override TResultType Accept<TResultType, TArgType>(global::System.Data.Entity.Core.Query.InternalTrees.ColumnMapVisitorWithResults<TResultType, TArgType> visitor, TArgType arg)
		{
			return visitor.Visit(this, arg);
		}

		// Token: 0x06002CB8 RID: 11448 RVA: 0x0008F0FF File Offset: 0x0008D2FF
		public override string ToString()
		{
			return string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "C{0}", new object[]
			{
				base.ToString()
			});
		}

		// Token: 0x04000F06 RID: 3846
		private readonly global::System.Data.Entity.Core.Query.InternalTrees.SimpleColumnMap m_nullSentinel;
	}
}
