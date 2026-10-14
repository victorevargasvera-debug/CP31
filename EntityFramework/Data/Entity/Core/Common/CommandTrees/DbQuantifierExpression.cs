using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Core.Common.CommandTrees
{
	// Token: 0x020006D8 RID: 1752
	public sealed class DbQuantifierExpression : global::System.Data.Entity.Core.Common.CommandTrees.DbExpression
	{
		// Token: 0x0600517B RID: 20859 RVA: 0x00122FC1 File Offset: 0x001211C1
		internal DbQuantifierExpression(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind kind, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage booleanResultType, global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding input, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression predicate) : base(kind, booleanResultType, true)
		{
			this._input = input;
			this._predicate = predicate;
		}

		// Token: 0x17000FE3 RID: 4067
		// (get) Token: 0x0600517C RID: 20860 RVA: 0x00122FDB File Offset: 0x001211DB
		public global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding Input
		{
			get
			{
				return this._input;
			}
		}

		// Token: 0x17000FE4 RID: 4068
		// (get) Token: 0x0600517D RID: 20861 RVA: 0x00122FE3 File Offset: 0x001211E3
		public global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Predicate
		{
			get
			{
				return this._predicate;
			}
		}

		// Token: 0x0600517E RID: 20862 RVA: 0x00122FEB File Offset: 0x001211EB
		public override void Accept(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor visitor)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor>(visitor, "visitor");
			visitor.Visit(this);
		}

		// Token: 0x0600517F RID: 20863 RVA: 0x00123000 File Offset: 0x00121200
		public override TResultType Accept<TResultType>(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor<TResultType> visitor)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor<TResultType>>(visitor, "visitor");
			return visitor.Visit(this);
		}

		// Token: 0x04001DC4 RID: 7620
		private readonly global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding _input;

		// Token: 0x04001DC5 RID: 7621
		private readonly global::System.Data.Entity.Core.Common.CommandTrees.DbExpression _predicate;
	}
}
