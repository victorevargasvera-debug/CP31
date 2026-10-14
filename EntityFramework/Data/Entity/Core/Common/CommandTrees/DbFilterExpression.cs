using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Core.Common.CommandTrees
{
	// Token: 0x020006BC RID: 1724
	public sealed class DbFilterExpression : global::System.Data.Entity.Core.Common.CommandTrees.DbExpression
	{
		// Token: 0x060050DE RID: 20702 RVA: 0x00121741 File Offset: 0x0011F941
		internal DbFilterExpression(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage resultType, global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding input, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression predicate) : base(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Filter, resultType, true)
		{
			this._input = input;
			this._predicate = predicate;
		}

		// Token: 0x17000FB0 RID: 4016
		// (get) Token: 0x060050DF RID: 20703 RVA: 0x0012175B File Offset: 0x0011F95B
		public global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding Input
		{
			get
			{
				return this._input;
			}
		}

		// Token: 0x17000FB1 RID: 4017
		// (get) Token: 0x060050E0 RID: 20704 RVA: 0x00121763 File Offset: 0x0011F963
		public global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Predicate
		{
			get
			{
				return this._predicate;
			}
		}

		// Token: 0x060050E1 RID: 20705 RVA: 0x0012176B File Offset: 0x0011F96B
		public override void Accept(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor visitor)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor>(visitor, "visitor");
			visitor.Visit(this);
		}

		// Token: 0x060050E2 RID: 20706 RVA: 0x00121780 File Offset: 0x0011F980
		public override TResultType Accept<TResultType>(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor<TResultType> visitor)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor<TResultType>>(visitor, "visitor");
			return visitor.Visit(this);
		}

		// Token: 0x04001D97 RID: 7575
		private readonly global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding _input;

		// Token: 0x04001D98 RID: 7576
		private readonly global::System.Data.Entity.Core.Common.CommandTrees.DbExpression _predicate;
	}
}
