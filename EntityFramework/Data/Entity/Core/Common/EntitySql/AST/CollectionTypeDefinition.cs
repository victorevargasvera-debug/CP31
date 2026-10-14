using System;

namespace System.Data.Entity.Core.Common.EntitySql.AST
{
	// Token: 0x0200067A RID: 1658
	internal sealed class CollectionTypeDefinition : global::System.Data.Entity.Core.Common.EntitySql.AST.Node
	{
		// Token: 0x06004F34 RID: 20276 RVA: 0x0011F148 File Offset: 0x0011D348
		internal CollectionTypeDefinition(global::System.Data.Entity.Core.Common.EntitySql.AST.Node elementTypeDef)
		{
			this._elementTypeDef = elementTypeDef;
		}

		// Token: 0x17000F46 RID: 3910
		// (get) Token: 0x06004F35 RID: 20277 RVA: 0x0011F157 File Offset: 0x0011D357
		internal global::System.Data.Entity.Core.Common.EntitySql.AST.Node ElementTypeDef
		{
			get
			{
				return this._elementTypeDef;
			}
		}

		// Token: 0x04001CCB RID: 7371
		private readonly global::System.Data.Entity.Core.Common.EntitySql.AST.Node _elementTypeDef;
	}
}
