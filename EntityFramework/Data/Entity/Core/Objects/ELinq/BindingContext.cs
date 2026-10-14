using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Linq;
using System.Linq.Expressions;

namespace System.Data.Entity.Core.Objects.ELinq
{
	// Token: 0x0200045D RID: 1117
	internal sealed class BindingContext
	{
		// Token: 0x060036E9 RID: 14057 RVA: 0x000B0578 File Offset: 0x000AE778
		internal BindingContext()
		{
			this._scopes = new global::System.Collections.Generic.Stack<global::System.Data.Entity.Core.Objects.ELinq.Binding>();
		}

		// Token: 0x060036EA RID: 14058 RVA: 0x000B058B File Offset: 0x000AE78B
		internal void PushBindingScope(global::System.Data.Entity.Core.Objects.ELinq.Binding binding)
		{
			this._scopes.Push(binding);
		}

		// Token: 0x060036EB RID: 14059 RVA: 0x000B0599 File Offset: 0x000AE799
		internal void PopBindingScope()
		{
			this._scopes.Pop();
		}

		// Token: 0x060036EC RID: 14060 RVA: 0x000B05A8 File Offset: 0x000AE7A8
		internal bool TryGetBoundExpression(global::System.Linq.Expressions.Expression linqExpression, out global::System.Data.Entity.Core.Common.CommandTrees.DbExpression cqtExpression)
		{
			cqtExpression = (from binding in this._scopes
			where binding.LinqExpression == linqExpression
			select binding.CqtExpression).FirstOrDefault<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>();
			return cqtExpression != null;
		}

		// Token: 0x040011CF RID: 4559
		private readonly global::System.Collections.Generic.Stack<global::System.Data.Entity.Core.Objects.ELinq.Binding> _scopes;
	}
}
