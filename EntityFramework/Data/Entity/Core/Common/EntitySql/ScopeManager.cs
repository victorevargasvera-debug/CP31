using System;
using System.Collections.Generic;
using System.Data.Entity.Resources;

namespace System.Data.Entity.Core.Common.EntitySql
{
	// Token: 0x0200066F RID: 1647
	internal sealed class ScopeManager
	{
		// Token: 0x06004EF8 RID: 20216 RVA: 0x0011E82B File Offset: 0x0011CA2B
		internal ScopeManager(global::System.Collections.Generic.IEqualityComparer<string> keyComparer)
		{
			this._keyComparer = keyComparer;
		}

		// Token: 0x06004EF9 RID: 20217 RVA: 0x0011E845 File Offset: 0x0011CA45
		internal void EnterScope()
		{
			this._scopes.Add(new global::System.Data.Entity.Core.Common.EntitySql.Scope(this._keyComparer));
		}

		// Token: 0x06004EFA RID: 20218 RVA: 0x0011E85D File Offset: 0x0011CA5D
		internal void LeaveScope()
		{
			this._scopes.RemoveAt(this.CurrentScopeIndex);
		}

		// Token: 0x17000F33 RID: 3891
		// (get) Token: 0x06004EFB RID: 20219 RVA: 0x0011E870 File Offset: 0x0011CA70
		internal int CurrentScopeIndex
		{
			get
			{
				return this._scopes.Count - 1;
			}
		}

		// Token: 0x17000F34 RID: 3892
		// (get) Token: 0x06004EFC RID: 20220 RVA: 0x0011E87F File Offset: 0x0011CA7F
		internal global::System.Data.Entity.Core.Common.EntitySql.Scope CurrentScope
		{
			get
			{
				return this._scopes[this.CurrentScopeIndex];
			}
		}

		// Token: 0x06004EFD RID: 20221 RVA: 0x0011E892 File Offset: 0x0011CA92
		internal global::System.Data.Entity.Core.Common.EntitySql.Scope GetScopeByIndex(int scopeIndex)
		{
			if (0 > scopeIndex || scopeIndex > this.CurrentScopeIndex)
			{
				throw new global::System.Data.Entity.Core.EntitySqlException(global::System.Data.Entity.Resources.Strings.InvalidScopeIndex);
			}
			return this._scopes[scopeIndex];
		}

		// Token: 0x06004EFE RID: 20222 RVA: 0x0011E8B8 File Offset: 0x0011CAB8
		internal void RollbackToScope(int scopeIndex)
		{
			if (scopeIndex > this.CurrentScopeIndex || scopeIndex < 0 || this.CurrentScopeIndex < 0)
			{
				throw new global::System.Data.Entity.Core.EntitySqlException(global::System.Data.Entity.Resources.Strings.InvalidSavePoint);
			}
			if (this.CurrentScopeIndex - scopeIndex > 0)
			{
				this._scopes.RemoveRange(scopeIndex + 1, this.CurrentScopeIndex - scopeIndex);
			}
		}

		// Token: 0x06004EFF RID: 20223 RVA: 0x0011E907 File Offset: 0x0011CB07
		internal bool IsInCurrentScope(string key)
		{
			return this.CurrentScope.Contains(key);
		}

		// Token: 0x04001C88 RID: 7304
		private readonly global::System.Collections.Generic.IEqualityComparer<string> _keyComparer;

		// Token: 0x04001C89 RID: 7305
		private readonly global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.EntitySql.Scope> _scopes = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.EntitySql.Scope>();
	}
}
