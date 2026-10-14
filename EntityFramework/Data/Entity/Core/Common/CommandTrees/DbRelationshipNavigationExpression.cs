using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Core.Common.CommandTrees
{
	// Token: 0x020006DD RID: 1757
	public sealed class DbRelationshipNavigationExpression : global::System.Data.Entity.Core.Common.CommandTrees.DbExpression
	{
		// Token: 0x06005195 RID: 20885 RVA: 0x001232B0 File Offset: 0x001214B0
		internal DbRelationshipNavigationExpression(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage resultType, global::System.Data.Entity.Core.Metadata.Edm.RelationshipType relType, global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember fromEnd, global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember toEnd, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression navigateFrom) : base(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.RelationshipNavigation, resultType, true)
		{
			this._relation = relType;
			this._fromRole = fromEnd;
			this._toRole = toEnd;
			this._from = navigateFrom;
		}

		// Token: 0x17000FEB RID: 4075
		// (get) Token: 0x06005196 RID: 20886 RVA: 0x001232DA File Offset: 0x001214DA
		public global::System.Data.Entity.Core.Metadata.Edm.RelationshipType Relationship
		{
			get
			{
				return this._relation;
			}
		}

		// Token: 0x17000FEC RID: 4076
		// (get) Token: 0x06005197 RID: 20887 RVA: 0x001232E2 File Offset: 0x001214E2
		public global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember NavigateFrom
		{
			get
			{
				return this._fromRole;
			}
		}

		// Token: 0x17000FED RID: 4077
		// (get) Token: 0x06005198 RID: 20888 RVA: 0x001232EA File Offset: 0x001214EA
		public global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember NavigateTo
		{
			get
			{
				return this._toRole;
			}
		}

		// Token: 0x17000FEE RID: 4078
		// (get) Token: 0x06005199 RID: 20889 RVA: 0x001232F2 File Offset: 0x001214F2
		public global::System.Data.Entity.Core.Common.CommandTrees.DbExpression NavigationSource
		{
			get
			{
				return this._from;
			}
		}

		// Token: 0x0600519A RID: 20890 RVA: 0x001232FA File Offset: 0x001214FA
		public override void Accept(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor visitor)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor>(visitor, "visitor");
			visitor.Visit(this);
		}

		// Token: 0x0600519B RID: 20891 RVA: 0x0012330F File Offset: 0x0012150F
		public override TResultType Accept<TResultType>(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor<TResultType> visitor)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor<TResultType>>(visitor, "visitor");
			return visitor.Visit(this);
		}

		// Token: 0x04001DCC RID: 7628
		private readonly global::System.Data.Entity.Core.Metadata.Edm.RelationshipType _relation;

		// Token: 0x04001DCD RID: 7629
		private readonly global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember _fromRole;

		// Token: 0x04001DCE RID: 7630
		private readonly global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember _toRole;

		// Token: 0x04001DCF RID: 7631
		private readonly global::System.Data.Entity.Core.Common.CommandTrees.DbExpression _from;
	}
}
