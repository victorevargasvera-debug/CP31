using System;

namespace System.Data.Entity.Core.Common.EntitySql
{
	// Token: 0x0200064E RID: 1614
	internal abstract class ExpressionResolution
	{
		// Token: 0x06004DF9 RID: 19961 RVA: 0x00117880 File Offset: 0x00115A80
		protected ExpressionResolution(global::System.Data.Entity.Core.Common.EntitySql.ExpressionResolutionClass @class)
		{
			this.ExpressionClass = @class;
		}

		// Token: 0x17000EFF RID: 3839
		// (get) Token: 0x06004DFA RID: 19962
		internal abstract string ExpressionClassName { get; }

		// Token: 0x04001C31 RID: 7217
		internal readonly global::System.Data.Entity.Core.Common.EntitySql.ExpressionResolutionClass ExpressionClass;
	}
}
