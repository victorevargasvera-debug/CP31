using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees.Internal;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Core.Common.CommandTrees
{
	// Token: 0x020006BF RID: 1727
	public class DbFunctionExpression : global::System.Data.Entity.Core.Common.CommandTrees.DbExpression
	{
		// Token: 0x060050ED RID: 20717 RVA: 0x001218AE File Offset: 0x0011FAAE
		internal DbFunctionExpression()
		{
		}

		// Token: 0x060050EE RID: 20718 RVA: 0x001218B6 File Offset: 0x0011FAB6
		internal DbFunctionExpression(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage resultType, global::System.Data.Entity.Core.Metadata.Edm.EdmFunction function, global::System.Data.Entity.Core.Common.CommandTrees.Internal.DbExpressionList arguments) : base(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Function, resultType, true)
		{
			this._functionInfo = function;
			this._arguments = arguments;
		}

		// Token: 0x17000FB7 RID: 4023
		// (get) Token: 0x060050EF RID: 20719 RVA: 0x001218D0 File Offset: 0x0011FAD0
		public virtual global::System.Data.Entity.Core.Metadata.Edm.EdmFunction Function
		{
			get
			{
				return this._functionInfo;
			}
		}

		// Token: 0x17000FB8 RID: 4024
		// (get) Token: 0x060050F0 RID: 20720 RVA: 0x001218D8 File Offset: 0x0011FAD8
		public virtual global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> Arguments
		{
			get
			{
				return this._arguments;
			}
		}

		// Token: 0x060050F1 RID: 20721 RVA: 0x001218E0 File Offset: 0x0011FAE0
		public override void Accept(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor visitor)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor>(visitor, "visitor");
			visitor.Visit(this);
		}

		// Token: 0x060050F2 RID: 20722 RVA: 0x001218F5 File Offset: 0x0011FAF5
		public override TResultType Accept<TResultType>(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor<TResultType> visitor)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor<TResultType>>(visitor, "visitor");
			return visitor.Visit(this);
		}

		// Token: 0x04001D9F RID: 7583
		private readonly global::System.Data.Entity.Core.Metadata.Edm.EdmFunction _functionInfo;

		// Token: 0x04001DA0 RID: 7584
		private readonly global::System.Data.Entity.Core.Common.CommandTrees.Internal.DbExpressionList _arguments;
	}
}
