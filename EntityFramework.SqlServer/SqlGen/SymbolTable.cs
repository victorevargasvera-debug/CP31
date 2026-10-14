using System;
using System.Collections.Generic;

namespace System.Data.Entity.SqlServer.SqlGen
{
	// Token: 0x0200003E RID: 62
	internal sealed class SymbolTable
	{
		// Token: 0x060005C0 RID: 1472 RVA: 0x00019F97 File Offset: 0x00018197
		internal void EnterScope()
		{
			this.symbols.Add(new global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.SqlServer.SqlGen.Symbol>(global::System.StringComparer.OrdinalIgnoreCase));
		}

		// Token: 0x060005C1 RID: 1473 RVA: 0x00019FAE File Offset: 0x000181AE
		internal void ExitScope()
		{
			this.symbols.RemoveAt(this.symbols.Count - 1);
		}

		// Token: 0x060005C2 RID: 1474 RVA: 0x00019FC8 File Offset: 0x000181C8
		internal void Add(string name, global::System.Data.Entity.SqlServer.SqlGen.Symbol value)
		{
			this.symbols[this.symbols.Count - 1][name] = value;
		}

		// Token: 0x060005C3 RID: 1475 RVA: 0x00019FEC File Offset: 0x000181EC
		internal global::System.Data.Entity.SqlServer.SqlGen.Symbol Lookup(string name)
		{
			for (int i = this.symbols.Count - 1; i >= 0; i--)
			{
				if (this.symbols[i].ContainsKey(name))
				{
					return this.symbols[i][name];
				}
			}
			return null;
		}

		// Token: 0x04000126 RID: 294
		private readonly global::System.Collections.Generic.List<global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.SqlServer.SqlGen.Symbol>> symbols = new global::System.Collections.Generic.List<global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.SqlServer.SqlGen.Symbol>>();
	}
}
