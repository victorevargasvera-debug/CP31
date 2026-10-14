using System;

namespace System.Data.Entity.Core.Common.EntitySql.AST
{
	// Token: 0x0200067B RID: 1659
	internal sealed class Command : global::System.Data.Entity.Core.Common.EntitySql.AST.Node
	{
		// Token: 0x06004F36 RID: 20278 RVA: 0x0011F15F File Offset: 0x0011D35F
		internal Command(global::System.Data.Entity.Core.Common.EntitySql.AST.NodeList<global::System.Data.Entity.Core.Common.EntitySql.AST.NamespaceImport> nsImportList, global::System.Data.Entity.Core.Common.EntitySql.AST.Statement statement)
		{
			this._namespaceImportList = nsImportList;
			this._statement = statement;
		}

		// Token: 0x17000F47 RID: 3911
		// (get) Token: 0x06004F37 RID: 20279 RVA: 0x0011F175 File Offset: 0x0011D375
		internal global::System.Data.Entity.Core.Common.EntitySql.AST.NodeList<global::System.Data.Entity.Core.Common.EntitySql.AST.NamespaceImport> NamespaceImportList
		{
			get
			{
				return this._namespaceImportList;
			}
		}

		// Token: 0x17000F48 RID: 3912
		// (get) Token: 0x06004F38 RID: 20280 RVA: 0x0011F17D File Offset: 0x0011D37D
		internal global::System.Data.Entity.Core.Common.EntitySql.AST.Statement Statement
		{
			get
			{
				return this._statement;
			}
		}

		// Token: 0x04001CCC RID: 7372
		private readonly global::System.Data.Entity.Core.Common.EntitySql.AST.NodeList<global::System.Data.Entity.Core.Common.EntitySql.AST.NamespaceImport> _namespaceImportList;

		// Token: 0x04001CCD RID: 7373
		private readonly global::System.Data.Entity.Core.Common.EntitySql.AST.Statement _statement;
	}
}
