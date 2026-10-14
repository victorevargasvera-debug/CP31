using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees.Internal;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Core.Common.CommandTrees
{
	// Token: 0x020006C3 RID: 1731
	public class DbInExpression : global::System.Data.Entity.Core.Common.CommandTrees.DbExpression
	{
		// Token: 0x06005103 RID: 20739 RVA: 0x00121A02 File Offset: 0x0011FC02
		internal DbInExpression(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage booleanResultType, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression item, global::System.Data.Entity.Core.Common.CommandTrees.Internal.DbExpressionList list) : base(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.In, booleanResultType, true)
		{
			this._item = item;
			this._list = list;
		}

		// Token: 0x17000FC4 RID: 4036
		// (get) Token: 0x06005104 RID: 20740 RVA: 0x00121A1C File Offset: 0x0011FC1C
		public global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Item
		{
			get
			{
				return this._item;
			}
		}

		// Token: 0x17000FC5 RID: 4037
		// (get) Token: 0x06005105 RID: 20741 RVA: 0x00121A24 File Offset: 0x0011FC24
		public global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> List
		{
			get
			{
				return this._list;
			}
		}

		// Token: 0x06005106 RID: 20742 RVA: 0x00121A2C File Offset: 0x0011FC2C
		public override void Accept(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor visitor)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor>(visitor, "visitor");
			visitor.Visit(this);
		}

		// Token: 0x06005107 RID: 20743 RVA: 0x00121A41 File Offset: 0x0011FC41
		public override TResultType Accept<TResultType>(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor<TResultType> visitor)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor<TResultType>>(visitor, "visitor");
			return visitor.Visit(this);
		}

		// Token: 0x04001DA8 RID: 7592
		private readonly global::System.Data.Entity.Core.Common.CommandTrees.DbExpression _item;

		// Token: 0x04001DA9 RID: 7593
		private readonly global::System.Data.Entity.Core.Common.CommandTrees.Internal.DbExpressionList _list;
	}
}
