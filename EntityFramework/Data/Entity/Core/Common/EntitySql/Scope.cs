using System;
using System.Collections;
using System.Collections.Generic;

namespace System.Data.Entity.Core.Common.EntitySql
{
	// Token: 0x02000666 RID: 1638
	internal sealed class Scope : global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.EntitySql.ScopeEntry>>, global::System.Collections.IEnumerable
	{
		// Token: 0x06004E3F RID: 20031 RVA: 0x00118240 File Offset: 0x00116440
		internal Scope(global::System.Collections.Generic.IEqualityComparer<string> keyComparer)
		{
			this._scopeEntries = new global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Common.EntitySql.ScopeEntry>(keyComparer);
		}

		// Token: 0x06004E40 RID: 20032 RVA: 0x00118254 File Offset: 0x00116454
		internal global::System.Data.Entity.Core.Common.EntitySql.Scope Add(string key, global::System.Data.Entity.Core.Common.EntitySql.ScopeEntry value)
		{
			this._scopeEntries.Add(key, value);
			return this;
		}

		// Token: 0x06004E41 RID: 20033 RVA: 0x00118264 File Offset: 0x00116464
		internal void Remove(string key)
		{
			this._scopeEntries.Remove(key);
		}

		// Token: 0x06004E42 RID: 20034 RVA: 0x00118273 File Offset: 0x00116473
		internal void Replace(string key, global::System.Data.Entity.Core.Common.EntitySql.ScopeEntry value)
		{
			this._scopeEntries[key] = value;
		}

		// Token: 0x06004E43 RID: 20035 RVA: 0x00118282 File Offset: 0x00116482
		internal bool Contains(string key)
		{
			return this._scopeEntries.ContainsKey(key);
		}

		// Token: 0x06004E44 RID: 20036 RVA: 0x00118290 File Offset: 0x00116490
		internal bool TryLookup(string key, out global::System.Data.Entity.Core.Common.EntitySql.ScopeEntry value)
		{
			return this._scopeEntries.TryGetValue(key, out value);
		}

		// Token: 0x06004E45 RID: 20037 RVA: 0x0011829F File Offset: 0x0011649F
		public global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Common.EntitySql.ScopeEntry>.Enumerator GetEnumerator()
		{
			return this._scopeEntries.GetEnumerator();
		}

		// Token: 0x06004E46 RID: 20038 RVA: 0x001182AC File Offset: 0x001164AC
		global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.EntitySql.ScopeEntry>> global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.EntitySql.ScopeEntry>>.GetEnumerator()
		{
			return this._scopeEntries.GetEnumerator();
		}

		// Token: 0x06004E47 RID: 20039 RVA: 0x001182BE File Offset: 0x001164BE
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return this._scopeEntries.GetEnumerator();
		}

		// Token: 0x04001C63 RID: 7267
		private readonly global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Common.EntitySql.ScopeEntry> _scopeEntries;
	}
}
