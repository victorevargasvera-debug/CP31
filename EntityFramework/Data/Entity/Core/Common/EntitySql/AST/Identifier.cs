using System;
using System.Data.Entity.Resources;

namespace System.Data.Entity.Core.Common.EntitySql.AST
{
	// Token: 0x02000688 RID: 1672
	internal sealed class Identifier : global::System.Data.Entity.Core.Common.EntitySql.AST.Node
	{
		// Token: 0x06004F59 RID: 20313 RVA: 0x0011F410 File Offset: 0x0011D610
		internal Identifier(string name, bool isEscaped, string query, int inputPos) : base(query, inputPos)
		{
			if (!isEscaped)
			{
				bool flag = true;
				if (!global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.IsLetterOrDigitOrUnderscore(name, out flag))
				{
					if (flag)
					{
						global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx = base.ErrCtx;
						string errorMessage = global::System.Data.Entity.Resources.Strings.InvalidSimpleIdentifier(name);
						throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx, errorMessage, null);
					}
					global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx2 = base.ErrCtx;
					string errorMessage2 = global::System.Data.Entity.Resources.Strings.InvalidSimpleIdentifierNonASCII(name);
					throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx2, errorMessage2, null);
				}
			}
			this._name = name;
			this._isEscaped = isEscaped;
		}

		// Token: 0x17000F5B RID: 3931
		// (get) Token: 0x06004F5A RID: 20314 RVA: 0x0011F470 File Offset: 0x0011D670
		internal string Name
		{
			get
			{
				return this._name;
			}
		}

		// Token: 0x17000F5C RID: 3932
		// (get) Token: 0x06004F5B RID: 20315 RVA: 0x0011F478 File Offset: 0x0011D678
		internal bool IsEscaped
		{
			get
			{
				return this._isEscaped;
			}
		}

		// Token: 0x04001CEC RID: 7404
		private readonly string _name;

		// Token: 0x04001CED RID: 7405
		private readonly bool _isEscaped;
	}
}
