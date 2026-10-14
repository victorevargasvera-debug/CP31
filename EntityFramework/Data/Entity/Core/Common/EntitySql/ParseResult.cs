using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Core.Common.CommandTrees;

namespace System.Data.Entity.Core.Common.EntitySql
{
	// Token: 0x02000664 RID: 1636
	public sealed class ParseResult
	{
		// Token: 0x06004E39 RID: 20025 RVA: 0x001181EA File Offset: 0x001163EA
		internal ParseResult(global::System.Data.Entity.Core.Common.CommandTrees.DbCommandTree commandTree, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.EntitySql.FunctionDefinition> functionDefs)
		{
			this._commandTree = commandTree;
			this._functionDefs = new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Common.EntitySql.FunctionDefinition>(functionDefs);
		}

		// Token: 0x17000F1A RID: 3866
		// (get) Token: 0x06004E3A RID: 20026 RVA: 0x00118205 File Offset: 0x00116405
		public global::System.Data.Entity.Core.Common.CommandTrees.DbCommandTree CommandTree
		{
			get
			{
				return this._commandTree;
			}
		}

		// Token: 0x17000F1B RID: 3867
		// (get) Token: 0x06004E3B RID: 20027 RVA: 0x0011820D File Offset: 0x0011640D
		public global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Common.EntitySql.FunctionDefinition> FunctionDefinitions
		{
			get
			{
				return this._functionDefs;
			}
		}

		// Token: 0x04001C60 RID: 7264
		private readonly global::System.Data.Entity.Core.Common.CommandTrees.DbCommandTree _commandTree;

		// Token: 0x04001C61 RID: 7265
		private readonly global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Common.EntitySql.FunctionDefinition> _functionDefs;
	}
}
