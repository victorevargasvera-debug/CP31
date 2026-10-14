using System;

namespace System.Data.Entity.Core.Common.EntitySql.AST
{
	// Token: 0x0200067F RID: 1663
	internal sealed class DotExpr : global::System.Data.Entity.Core.Common.EntitySql.AST.Node
	{
		// Token: 0x06004F40 RID: 20288 RVA: 0x0011F1DC File Offset: 0x0011D3DC
		internal DotExpr(global::System.Data.Entity.Core.Common.EntitySql.AST.Node leftExpr, global::System.Data.Entity.Core.Common.EntitySql.AST.Identifier id)
		{
			this._leftExpr = leftExpr;
			this._identifier = id;
		}

		// Token: 0x17000F4D RID: 3917
		// (get) Token: 0x06004F41 RID: 20289 RVA: 0x0011F1F2 File Offset: 0x0011D3F2
		internal global::System.Data.Entity.Core.Common.EntitySql.AST.Node Left
		{
			get
			{
				return this._leftExpr;
			}
		}

		// Token: 0x17000F4E RID: 3918
		// (get) Token: 0x06004F42 RID: 20290 RVA: 0x0011F1FA File Offset: 0x0011D3FA
		internal global::System.Data.Entity.Core.Common.EntitySql.AST.Identifier Identifier
		{
			get
			{
				return this._identifier;
			}
		}

		// Token: 0x06004F43 RID: 20291 RVA: 0x0011F204 File Offset: 0x0011D404
		internal bool IsMultipartIdentifier(out string[] names)
		{
			if (this._isMultipartIdentifierComputed != null)
			{
				names = this._names;
				return this._isMultipartIdentifierComputed.Value;
			}
			this._names = null;
			global::System.Data.Entity.Core.Common.EntitySql.AST.Identifier identifier = this._leftExpr as global::System.Data.Entity.Core.Common.EntitySql.AST.Identifier;
			if (identifier != null)
			{
				this._names = new string[]
				{
					identifier.Name,
					this._identifier.Name
				};
			}
			global::System.Data.Entity.Core.Common.EntitySql.AST.DotExpr dotExpr = this._leftExpr as global::System.Data.Entity.Core.Common.EntitySql.AST.DotExpr;
			string[] array;
			if (dotExpr != null && dotExpr.IsMultipartIdentifier(out array))
			{
				this._names = new string[array.Length + 1];
				array.CopyTo(this._names, 0);
				this._names[this._names.Length - 1] = this._identifier.Name;
			}
			this._isMultipartIdentifierComputed = new bool?(this._names != null);
			names = this._names;
			return this._isMultipartIdentifierComputed.Value;
		}

		// Token: 0x04001CD6 RID: 7382
		private readonly global::System.Data.Entity.Core.Common.EntitySql.AST.Node _leftExpr;

		// Token: 0x04001CD7 RID: 7383
		private readonly global::System.Data.Entity.Core.Common.EntitySql.AST.Identifier _identifier;

		// Token: 0x04001CD8 RID: 7384
		private bool? _isMultipartIdentifierComputed;

		// Token: 0x04001CD9 RID: 7385
		private string[] _names;
	}
}
