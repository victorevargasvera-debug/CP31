using System;
using System.Data.Entity.Core.Objects.Internal;
using System.Linq.Expressions;

namespace System.Data.Entity.Core.Common.Internal.Materialization
{
	// Token: 0x02000645 RID: 1605
	internal class TranslatorResult
	{
		// Token: 0x06004D47 RID: 19783 RVA: 0x0011019F File Offset: 0x0010E39F
		internal TranslatorResult(global::System.Linq.Expressions.Expression returnedExpression, global::System.Type requestedType)
		{
			this.RequestedType = requestedType;
			this.ReturnedExpression = returnedExpression;
		}

		// Token: 0x17000EF0 RID: 3824
		// (get) Token: 0x06004D48 RID: 19784 RVA: 0x001101B5 File Offset: 0x0010E3B5
		internal global::System.Linq.Expressions.Expression Expression
		{
			get
			{
				return global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.Emit_EnsureType(this.ReturnedExpression, this.RequestedType);
			}
		}

		// Token: 0x17000EF1 RID: 3825
		// (get) Token: 0x06004D49 RID: 19785 RVA: 0x001101C8 File Offset: 0x0010E3C8
		internal global::System.Linq.Expressions.Expression UnconvertedExpression
		{
			get
			{
				return this.ReturnedExpression;
			}
		}

		// Token: 0x17000EF2 RID: 3826
		// (get) Token: 0x06004D4A RID: 19786 RVA: 0x001101D0 File Offset: 0x0010E3D0
		internal global::System.Linq.Expressions.Expression UnwrappedExpression
		{
			get
			{
				if (!typeof(global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper).IsAssignableFrom(this.ReturnedExpression.Type))
				{
					return this.ReturnedExpression;
				}
				return global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.Emit_UnwrapAndEnsureType(this.ReturnedExpression, this.RequestedType);
			}
		}

		// Token: 0x04001B72 RID: 7026
		private readonly global::System.Linq.Expressions.Expression ReturnedExpression;

		// Token: 0x04001B73 RID: 7027
		private readonly global::System.Type RequestedType;
	}
}
