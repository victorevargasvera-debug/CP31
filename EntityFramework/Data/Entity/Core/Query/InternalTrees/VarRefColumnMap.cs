using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Diagnostics;
using System.Globalization;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x020003FD RID: 1021
	internal class VarRefColumnMap : global::System.Data.Entity.Core.Query.InternalTrees.SimpleColumnMap
	{
		// Token: 0x17000967 RID: 2407
		// (get) Token: 0x06002F91 RID: 12177 RVA: 0x00095199 File Offset: 0x00093399
		internal global::System.Data.Entity.Core.Query.InternalTrees.Var Var
		{
			get
			{
				return this.m_var;
			}
		}

		// Token: 0x06002F92 RID: 12178 RVA: 0x000951A1 File Offset: 0x000933A1
		internal VarRefColumnMap(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type, string name, global::System.Data.Entity.Core.Query.InternalTrees.Var v) : base(type, name)
		{
			this.m_var = v;
		}

		// Token: 0x06002F93 RID: 12179 RVA: 0x000951B2 File Offset: 0x000933B2
		internal VarRefColumnMap(global::System.Data.Entity.Core.Query.InternalTrees.Var v) : this(v.Type, null, v)
		{
		}

		// Token: 0x06002F94 RID: 12180 RVA: 0x000951C2 File Offset: 0x000933C2
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override void Accept<TArgType>(global::System.Data.Entity.Core.Query.InternalTrees.ColumnMapVisitor<TArgType> visitor, TArgType arg)
		{
			visitor.Visit(this, arg);
		}

		// Token: 0x06002F95 RID: 12181 RVA: 0x000951CC File Offset: 0x000933CC
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal override TResultType Accept<TResultType, TArgType>(global::System.Data.Entity.Core.Query.InternalTrees.ColumnMapVisitorWithResults<TResultType, TArgType> visitor, TArgType arg)
		{
			return visitor.Visit(this, arg);
		}

		// Token: 0x06002F96 RID: 12182 RVA: 0x000951D6 File Offset: 0x000933D6
		public override string ToString()
		{
			if (!base.IsNamed)
			{
				return string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "{0}", new object[]
				{
					this.m_var.Id
				});
			}
			return base.Name;
		}

		// Token: 0x04001009 RID: 4105
		private readonly global::System.Data.Entity.Core.Query.InternalTrees.Var m_var;
	}
}
