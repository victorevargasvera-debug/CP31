using System;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.Entity.Resources;

namespace System.Data.Entity.Core.Common.EntitySql
{
	// Token: 0x02000671 RID: 1649
	internal sealed class ValueExpression : global::System.Data.Entity.Core.Common.EntitySql.ExpressionResolution
	{
		// Token: 0x06004F15 RID: 20245 RVA: 0x0011EEEA File Offset: 0x0011D0EA
		internal ValueExpression(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression value) : base(global::System.Data.Entity.Core.Common.EntitySql.ExpressionResolutionClass.Value)
		{
			this.Value = value;
		}

		// Token: 0x17000F3A RID: 3898
		// (get) Token: 0x06004F16 RID: 20246 RVA: 0x0011EEFA File Offset: 0x0011D0FA
		internal override string ExpressionClassName
		{
			get
			{
				return global::System.Data.Entity.Core.Common.EntitySql.ValueExpression.ValueClassName;
			}
		}

		// Token: 0x17000F3B RID: 3899
		// (get) Token: 0x06004F17 RID: 20247 RVA: 0x0011EF01 File Offset: 0x0011D101
		internal static string ValueClassName
		{
			get
			{
				return global::System.Data.Entity.Resources.Strings.LocalizedValueExpression;
			}
		}

		// Token: 0x04001C91 RID: 7313
		internal readonly global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Value;
	}
}
