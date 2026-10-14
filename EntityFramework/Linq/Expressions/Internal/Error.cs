using System;
using System.Data.Entity.Resources;

namespace System.Linq.Expressions.Internal
{
	// Token: 0x02000055 RID: 85
	internal static class Error
	{
		// Token: 0x0600021B RID: 539 RVA: 0x00008111 File Offset: 0x00006311
		internal static global::System.Exception UnhandledExpressionType(global::System.Linq.Expressions.ExpressionType expressionType)
		{
			return new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_UnhandledExpressionType(expressionType));
		}

		// Token: 0x0600021C RID: 540 RVA: 0x00008123 File Offset: 0x00006323
		internal static global::System.Exception UnhandledBindingType(global::System.Linq.Expressions.MemberBindingType memberBindingType)
		{
			return new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_UnhandledBindingType(memberBindingType));
		}
	}
}
