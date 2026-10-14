using System;

namespace System.Data.Entity.Core.Common.EntitySql.AST
{
	// Token: 0x0200069C RID: 1692
	internal sealed class RowTypeDefinition : global::System.Data.Entity.Core.Common.EntitySql.AST.Node
	{
		// Token: 0x06004FB0 RID: 20400 RVA: 0x001202E4 File Offset: 0x0011E4E4
		internal RowTypeDefinition(global::System.Data.Entity.Core.Common.EntitySql.AST.NodeList<global::System.Data.Entity.Core.Common.EntitySql.AST.PropDefinition> propDefList)
		{
			this._propDefList = propDefList;
		}

		// Token: 0x17000F8A RID: 3978
		// (get) Token: 0x06004FB1 RID: 20401 RVA: 0x001202F3 File Offset: 0x0011E4F3
		internal global::System.Data.Entity.Core.Common.EntitySql.AST.NodeList<global::System.Data.Entity.Core.Common.EntitySql.AST.PropDefinition> Properties
		{
			get
			{
				return this._propDefList;
			}
		}

		// Token: 0x04001D30 RID: 7472
		private readonly global::System.Data.Entity.Core.Common.EntitySql.AST.NodeList<global::System.Data.Entity.Core.Common.EntitySql.AST.PropDefinition> _propDefList;
	}
}
