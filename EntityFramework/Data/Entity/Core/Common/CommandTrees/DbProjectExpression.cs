using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Core.Common.CommandTrees
{
	// Token: 0x020006D6 RID: 1750
	public sealed class DbProjectExpression : global::System.Data.Entity.Core.Common.CommandTrees.DbExpression
	{
		// Token: 0x0600516E RID: 20846 RVA: 0x00122EEA File Offset: 0x001210EA
		internal DbProjectExpression(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage resultType, global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding input, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression projection) : base(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Project, resultType, true)
		{
			this._input = input;
			this._projection = projection;
		}

		// Token: 0x17000FDF RID: 4063
		// (get) Token: 0x0600516F RID: 20847 RVA: 0x00122F04 File Offset: 0x00121104
		public global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding Input
		{
			get
			{
				return this._input;
			}
		}

		// Token: 0x17000FE0 RID: 4064
		// (get) Token: 0x06005170 RID: 20848 RVA: 0x00122F0C File Offset: 0x0012110C
		public global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Projection
		{
			get
			{
				return this._projection;
			}
		}

		// Token: 0x06005171 RID: 20849 RVA: 0x00122F14 File Offset: 0x00121114
		public override void Accept(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor visitor)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor>(visitor, "visitor");
			visitor.Visit(this);
		}

		// Token: 0x06005172 RID: 20850 RVA: 0x00122F29 File Offset: 0x00121129
		public override TResultType Accept<TResultType>(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor<TResultType> visitor)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor<TResultType>>(visitor, "visitor");
			return visitor.Visit(this);
		}

		// Token: 0x04001DC0 RID: 7616
		private readonly global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding _input;

		// Token: 0x04001DC1 RID: 7617
		private readonly global::System.Data.Entity.Core.Common.CommandTrees.DbExpression _projection;
	}
}
