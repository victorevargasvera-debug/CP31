using System;

namespace System.Data.Entity.Core.Common.EntitySql.AST
{
	// Token: 0x02000677 RID: 1655
	internal sealed class BuiltInExpr : global::System.Data.Entity.Core.Common.EntitySql.AST.Node
	{
		// Token: 0x06004F2B RID: 20267 RVA: 0x0011F06D File Offset: 0x0011D26D
		private BuiltInExpr(global::System.Data.Entity.Core.Common.EntitySql.AST.BuiltInKind kind, string name)
		{
			this.Kind = kind;
			this.Name = name.ToUpperInvariant();
		}

		// Token: 0x06004F2C RID: 20268 RVA: 0x0011F088 File Offset: 0x0011D288
		internal BuiltInExpr(global::System.Data.Entity.Core.Common.EntitySql.AST.BuiltInKind kind, string name, global::System.Data.Entity.Core.Common.EntitySql.AST.Node arg1) : this(kind, name)
		{
			this.ArgCount = 1;
			this.Arg1 = arg1;
		}

		// Token: 0x06004F2D RID: 20269 RVA: 0x0011F0A0 File Offset: 0x0011D2A0
		internal BuiltInExpr(global::System.Data.Entity.Core.Common.EntitySql.AST.BuiltInKind kind, string name, global::System.Data.Entity.Core.Common.EntitySql.AST.Node arg1, global::System.Data.Entity.Core.Common.EntitySql.AST.Node arg2) : this(kind, name)
		{
			this.ArgCount = 2;
			this.Arg1 = arg1;
			this.Arg2 = arg2;
		}

		// Token: 0x06004F2E RID: 20270 RVA: 0x0011F0C0 File Offset: 0x0011D2C0
		internal BuiltInExpr(global::System.Data.Entity.Core.Common.EntitySql.AST.BuiltInKind kind, string name, global::System.Data.Entity.Core.Common.EntitySql.AST.Node arg1, global::System.Data.Entity.Core.Common.EntitySql.AST.Node arg2, global::System.Data.Entity.Core.Common.EntitySql.AST.Node arg3) : this(kind, name)
		{
			this.ArgCount = 3;
			this.Arg1 = arg1;
			this.Arg2 = arg2;
			this.Arg3 = arg3;
		}

		// Token: 0x06004F2F RID: 20271 RVA: 0x0011F0E8 File Offset: 0x0011D2E8
		internal BuiltInExpr(global::System.Data.Entity.Core.Common.EntitySql.AST.BuiltInKind kind, string name, global::System.Data.Entity.Core.Common.EntitySql.AST.Node arg1, global::System.Data.Entity.Core.Common.EntitySql.AST.Node arg2, global::System.Data.Entity.Core.Common.EntitySql.AST.Node arg3, global::System.Data.Entity.Core.Common.EntitySql.AST.Node arg4) : this(kind, name)
		{
			this.ArgCount = 4;
			this.Arg1 = arg1;
			this.Arg2 = arg2;
			this.Arg3 = arg3;
			this.Arg4 = arg4;
		}

		// Token: 0x04001C9C RID: 7324
		internal readonly global::System.Data.Entity.Core.Common.EntitySql.AST.BuiltInKind Kind;

		// Token: 0x04001C9D RID: 7325
		internal readonly string Name;

		// Token: 0x04001C9E RID: 7326
		internal readonly int ArgCount;

		// Token: 0x04001C9F RID: 7327
		internal readonly global::System.Data.Entity.Core.Common.EntitySql.AST.Node Arg1;

		// Token: 0x04001CA0 RID: 7328
		internal readonly global::System.Data.Entity.Core.Common.EntitySql.AST.Node Arg2;

		// Token: 0x04001CA1 RID: 7329
		internal readonly global::System.Data.Entity.Core.Common.EntitySql.AST.Node Arg3;

		// Token: 0x04001CA2 RID: 7330
		internal readonly global::System.Data.Entity.Core.Common.EntitySql.AST.Node Arg4;
	}
}
