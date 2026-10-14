using System;
using System.Collections.Generic;

namespace System.Data.Entity.SqlServer.SqlGen
{
	// Token: 0x0200003F RID: 63
	internal class SymbolUsageManager
	{
		// Token: 0x060005C5 RID: 1477 RVA: 0x0001A04C File Offset: 0x0001824C
		internal bool ContainsKey(global::System.Data.Entity.SqlServer.SqlGen.Symbol key)
		{
			return this.optionalColumnUsage.ContainsKey(key);
		}

		// Token: 0x060005C6 RID: 1478 RVA: 0x0001A05C File Offset: 0x0001825C
		internal bool TryGetValue(global::System.Data.Entity.SqlServer.SqlGen.Symbol key, out bool value)
		{
			global::System.Data.Entity.SqlServer.SqlGen.BoolWrapper boolWrapper;
			if (this.optionalColumnUsage.TryGetValue(key, out boolWrapper))
			{
				value = boolWrapper.Value;
				return true;
			}
			value = false;
			return false;
		}

		// Token: 0x060005C7 RID: 1479 RVA: 0x0001A088 File Offset: 0x00018288
		internal void Add(global::System.Data.Entity.SqlServer.SqlGen.Symbol sourceSymbol, global::System.Data.Entity.SqlServer.SqlGen.Symbol symbolToAdd)
		{
			global::System.Data.Entity.SqlServer.SqlGen.BoolWrapper value;
			if (sourceSymbol == null || !this.optionalColumnUsage.TryGetValue(sourceSymbol, out value))
			{
				value = new global::System.Data.Entity.SqlServer.SqlGen.BoolWrapper();
			}
			this.optionalColumnUsage.Add(symbolToAdd, value);
		}

		// Token: 0x060005C8 RID: 1480 RVA: 0x0001A0BB File Offset: 0x000182BB
		internal void MarkAsUsed(global::System.Data.Entity.SqlServer.SqlGen.Symbol key)
		{
			if (this.optionalColumnUsage.ContainsKey(key))
			{
				this.optionalColumnUsage[key].Value = true;
			}
		}

		// Token: 0x060005C9 RID: 1481 RVA: 0x0001A0DD File Offset: 0x000182DD
		internal bool IsUsed(global::System.Data.Entity.SqlServer.SqlGen.Symbol key)
		{
			return this.optionalColumnUsage[key].Value;
		}

		// Token: 0x04000127 RID: 295
		private readonly global::System.Collections.Generic.Dictionary<global::System.Data.Entity.SqlServer.SqlGen.Symbol, global::System.Data.Entity.SqlServer.SqlGen.BoolWrapper> optionalColumnUsage = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.SqlServer.SqlGen.Symbol, global::System.Data.Entity.SqlServer.SqlGen.BoolWrapper>();
	}
}
