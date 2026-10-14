using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Core.Common.CommandTrees
{
	// Token: 0x020006D5 RID: 1749
	public class DbParameterReferenceExpression : global::System.Data.Entity.Core.Common.CommandTrees.DbExpression
	{
		// Token: 0x06005169 RID: 20841 RVA: 0x00122E9D File Offset: 0x0012109D
		internal DbParameterReferenceExpression()
		{
		}

		// Token: 0x0600516A RID: 20842 RVA: 0x00122EA5 File Offset: 0x001210A5
		internal DbParameterReferenceExpression(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type, string name) : base(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.ParameterReference, type, false)
		{
			this._name = name;
		}

		// Token: 0x17000FDE RID: 4062
		// (get) Token: 0x0600516B RID: 20843 RVA: 0x00122EB8 File Offset: 0x001210B8
		public virtual string ParameterName
		{
			get
			{
				return this._name;
			}
		}

		// Token: 0x0600516C RID: 20844 RVA: 0x00122EC0 File Offset: 0x001210C0
		public override void Accept(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor visitor)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor>(visitor, "visitor");
			visitor.Visit(this);
		}

		// Token: 0x0600516D RID: 20845 RVA: 0x00122ED5 File Offset: 0x001210D5
		public override TResultType Accept<TResultType>(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor<TResultType> visitor)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor<TResultType>>(visitor, "visitor");
			return visitor.Visit(this);
		}

		// Token: 0x04001DBF RID: 7615
		private readonly string _name;
	}
}
