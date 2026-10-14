using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Core.Common.CommandTrees
{
	// Token: 0x020006E7 RID: 1767
	public class DbVariableReferenceExpression : global::System.Data.Entity.Core.Common.CommandTrees.DbExpression
	{
		// Token: 0x060051C7 RID: 20935 RVA: 0x001236E1 File Offset: 0x001218E1
		internal DbVariableReferenceExpression()
		{
		}

		// Token: 0x060051C8 RID: 20936 RVA: 0x001236E9 File Offset: 0x001218E9
		internal DbVariableReferenceExpression(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type, string name) : base(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.VariableReference, type, true)
		{
			this._name = name;
		}

		// Token: 0x17001000 RID: 4096
		// (get) Token: 0x060051C9 RID: 20937 RVA: 0x001236FC File Offset: 0x001218FC
		public virtual string VariableName
		{
			get
			{
				return this._name;
			}
		}

		// Token: 0x060051CA RID: 20938 RVA: 0x00123704 File Offset: 0x00121904
		public override void Accept(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor visitor)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor>(visitor, "visitor");
			visitor.Visit(this);
		}

		// Token: 0x060051CB RID: 20939 RVA: 0x00123719 File Offset: 0x00121919
		public override TResultType Accept<TResultType>(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor<TResultType> visitor)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor<TResultType>>(visitor, "visitor");
			return visitor.Visit(this);
		}

		// Token: 0x04001DDF RID: 7647
		private readonly string _name;
	}
}
