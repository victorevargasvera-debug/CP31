using System;

namespace System.Data.Entity.Core.Common.EntitySql.AST
{
	// Token: 0x0200069A RID: 1690
	internal sealed class RefTypeDefinition : global::System.Data.Entity.Core.Common.EntitySql.AST.Node
	{
		// Token: 0x06004FAC RID: 20396 RVA: 0x001202B6 File Offset: 0x0011E4B6
		internal RefTypeDefinition(global::System.Data.Entity.Core.Common.EntitySql.AST.Node refTypeIdentifier)
		{
			this._refTypeIdentifier = refTypeIdentifier;
		}

		// Token: 0x17000F88 RID: 3976
		// (get) Token: 0x06004FAD RID: 20397 RVA: 0x001202C5 File Offset: 0x0011E4C5
		internal global::System.Data.Entity.Core.Common.EntitySql.AST.Node RefTypeIdentifier
		{
			get
			{
				return this._refTypeIdentifier;
			}
		}

		// Token: 0x04001D2E RID: 7470
		private readonly global::System.Data.Entity.Core.Common.EntitySql.AST.Node _refTypeIdentifier;
	}
}
