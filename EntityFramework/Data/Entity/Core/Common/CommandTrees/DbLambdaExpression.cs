using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees.Internal;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Core.Common.CommandTrees
{
	// Token: 0x020006CB RID: 1739
	public sealed class DbLambdaExpression : global::System.Data.Entity.Core.Common.CommandTrees.DbExpression
	{
		// Token: 0x0600513A RID: 20794 RVA: 0x00122B96 File Offset: 0x00120D96
		internal DbLambdaExpression(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage resultType, global::System.Data.Entity.Core.Common.CommandTrees.DbLambda lambda, global::System.Data.Entity.Core.Common.CommandTrees.Internal.DbExpressionList args) : base(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Lambda, resultType, true)
		{
			this._lambda = lambda;
			this._arguments = args;
		}

		// Token: 0x17000FD0 RID: 4048
		// (get) Token: 0x0600513B RID: 20795 RVA: 0x00122BB0 File Offset: 0x00120DB0
		public global::System.Data.Entity.Core.Common.CommandTrees.DbLambda Lambda
		{
			get
			{
				return this._lambda;
			}
		}

		// Token: 0x17000FD1 RID: 4049
		// (get) Token: 0x0600513C RID: 20796 RVA: 0x00122BB8 File Offset: 0x00120DB8
		public global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> Arguments
		{
			get
			{
				return this._arguments;
			}
		}

		// Token: 0x0600513D RID: 20797 RVA: 0x00122BC0 File Offset: 0x00120DC0
		public override void Accept(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor visitor)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor>(visitor, "visitor");
			visitor.Visit(this);
		}

		// Token: 0x0600513E RID: 20798 RVA: 0x00122BD5 File Offset: 0x00120DD5
		public override TResultType Accept<TResultType>(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor<TResultType> visitor)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor<TResultType>>(visitor, "visitor");
			return visitor.Visit(this);
		}

		// Token: 0x04001DB2 RID: 7602
		private readonly global::System.Data.Entity.Core.Common.CommandTrees.DbLambda _lambda;

		// Token: 0x04001DB3 RID: 7603
		private readonly global::System.Data.Entity.Core.Common.CommandTrees.Internal.DbExpressionList _arguments;
	}
}
