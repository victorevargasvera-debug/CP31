using System;
using System.Data.Entity.Core.Metadata.Edm;

namespace System.Data.Entity.Core.Common.CommandTrees
{
	// Token: 0x020006A8 RID: 1704
	public abstract class DbBinaryExpression : global::System.Data.Entity.Core.Common.CommandTrees.DbExpression
	{
		// Token: 0x06005014 RID: 20500 RVA: 0x00120EA8 File Offset: 0x0011F0A8
		internal DbBinaryExpression()
		{
		}

		// Token: 0x06005015 RID: 20501 RVA: 0x00120EB0 File Offset: 0x0011F0B0
		internal DbBinaryExpression(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind kind, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression left, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression right) : base(kind, type, true)
		{
			this._left = left;
			this._right = right;
		}

		// Token: 0x17000F99 RID: 3993
		// (get) Token: 0x06005016 RID: 20502 RVA: 0x00120ECA File Offset: 0x0011F0CA
		public virtual global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Left
		{
			get
			{
				return this._left;
			}
		}

		// Token: 0x17000F9A RID: 3994
		// (get) Token: 0x06005017 RID: 20503 RVA: 0x00120ED2 File Offset: 0x0011F0D2
		public virtual global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Right
		{
			get
			{
				return this._right;
			}
		}

		// Token: 0x04001D42 RID: 7490
		private readonly global::System.Data.Entity.Core.Common.CommandTrees.DbExpression _left;

		// Token: 0x04001D43 RID: 7491
		private readonly global::System.Data.Entity.Core.Common.CommandTrees.DbExpression _right;
	}
}
