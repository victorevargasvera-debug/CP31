using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Core.Common.CommandTrees
{
	// Token: 0x020006A6 RID: 1702
	public sealed class DbApplyExpression : global::System.Data.Entity.Core.Common.CommandTrees.DbExpression
	{
		// Token: 0x0600500B RID: 20491 RVA: 0x00120E10 File Offset: 0x0011F010
		internal DbApplyExpression(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind applyKind, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage resultRowCollectionTypeUsage, global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding input, global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding apply) : base(applyKind, resultRowCollectionTypeUsage, true)
		{
			this._input = input;
			this._apply = apply;
		}

		// Token: 0x17000F96 RID: 3990
		// (get) Token: 0x0600500C RID: 20492 RVA: 0x00120E2A File Offset: 0x0011F02A
		public global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding Apply
		{
			get
			{
				return this._apply;
			}
		}

		// Token: 0x17000F97 RID: 3991
		// (get) Token: 0x0600500D RID: 20493 RVA: 0x00120E32 File Offset: 0x0011F032
		public global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding Input
		{
			get
			{
				return this._input;
			}
		}

		// Token: 0x0600500E RID: 20494 RVA: 0x00120E3A File Offset: 0x0011F03A
		public override void Accept(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor visitor)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor>(visitor, "visitor");
			visitor.Visit(this);
		}

		// Token: 0x0600500F RID: 20495 RVA: 0x00120E4F File Offset: 0x0011F04F
		public override TResultType Accept<TResultType>(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor<TResultType> visitor)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor<TResultType>>(visitor, "visitor");
			return visitor.Visit(this);
		}

		// Token: 0x04001D3F RID: 7487
		private readonly global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding _input;

		// Token: 0x04001D40 RID: 7488
		private readonly global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding _apply;
	}
}
