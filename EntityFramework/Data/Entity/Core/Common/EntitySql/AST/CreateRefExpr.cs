using System;

namespace System.Data.Entity.Core.Common.EntitySql.AST
{
	// Token: 0x0200067C RID: 1660
	internal sealed class CreateRefExpr : global::System.Data.Entity.Core.Common.EntitySql.AST.Node
	{
		// Token: 0x06004F39 RID: 20281 RVA: 0x0011F185 File Offset: 0x0011D385
		internal CreateRefExpr(global::System.Data.Entity.Core.Common.EntitySql.AST.Node entitySet, global::System.Data.Entity.Core.Common.EntitySql.AST.Node keys) : this(entitySet, keys, null)
		{
		}

		// Token: 0x06004F3A RID: 20282 RVA: 0x0011F190 File Offset: 0x0011D390
		internal CreateRefExpr(global::System.Data.Entity.Core.Common.EntitySql.AST.Node entitySet, global::System.Data.Entity.Core.Common.EntitySql.AST.Node keys, global::System.Data.Entity.Core.Common.EntitySql.AST.Node typeIdentifier)
		{
			this._entitySet = entitySet;
			this._keys = keys;
			this._typeIdentifier = typeIdentifier;
		}

		// Token: 0x17000F49 RID: 3913
		// (get) Token: 0x06004F3B RID: 20283 RVA: 0x0011F1AD File Offset: 0x0011D3AD
		internal global::System.Data.Entity.Core.Common.EntitySql.AST.Node EntitySet
		{
			get
			{
				return this._entitySet;
			}
		}

		// Token: 0x17000F4A RID: 3914
		// (get) Token: 0x06004F3C RID: 20284 RVA: 0x0011F1B5 File Offset: 0x0011D3B5
		internal global::System.Data.Entity.Core.Common.EntitySql.AST.Node Keys
		{
			get
			{
				return this._keys;
			}
		}

		// Token: 0x17000F4B RID: 3915
		// (get) Token: 0x06004F3D RID: 20285 RVA: 0x0011F1BD File Offset: 0x0011D3BD
		internal global::System.Data.Entity.Core.Common.EntitySql.AST.Node TypeIdentifier
		{
			get
			{
				return this._typeIdentifier;
			}
		}

		// Token: 0x04001CCE RID: 7374
		private readonly global::System.Data.Entity.Core.Common.EntitySql.AST.Node _entitySet;

		// Token: 0x04001CCF RID: 7375
		private readonly global::System.Data.Entity.Core.Common.EntitySql.AST.Node _keys;

		// Token: 0x04001CD0 RID: 7376
		private readonly global::System.Data.Entity.Core.Common.EntitySql.AST.Node _typeIdentifier;
	}
}
