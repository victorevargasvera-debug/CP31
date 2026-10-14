using System;

namespace System.Data.Entity.Core.Common.EntitySql.AST
{
	// Token: 0x02000675 RID: 1653
	internal abstract class Node
	{
		// Token: 0x06004F20 RID: 20256 RVA: 0x0011EF9E File Offset: 0x0011D19E
		internal Node()
		{
		}

		// Token: 0x06004F21 RID: 20257 RVA: 0x0011EFB1 File Offset: 0x0011D1B1
		internal Node(string commandText, int inputPosition)
		{
			this._errCtx.CommandText = commandText;
			this._errCtx.InputPosition = inputPosition;
		}

		// Token: 0x17000F41 RID: 3905
		// (get) Token: 0x06004F22 RID: 20258 RVA: 0x0011EFDC File Offset: 0x0011D1DC
		// (set) Token: 0x06004F23 RID: 20259 RVA: 0x0011EFE4 File Offset: 0x0011D1E4
		internal global::System.Data.Entity.Core.Common.EntitySql.ErrorContext ErrCtx
		{
			get
			{
				return this._errCtx;
			}
			set
			{
				this._errCtx = value;
			}
		}

		// Token: 0x04001C9A RID: 7322
		private global::System.Data.Entity.Core.Common.EntitySql.ErrorContext _errCtx = new global::System.Data.Entity.Core.Common.EntitySql.ErrorContext();
	}
}
