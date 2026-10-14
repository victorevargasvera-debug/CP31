using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Resources;

namespace System.Data.Entity.Core.Common.EntitySql
{
	// Token: 0x0200064B RID: 1611
	internal sealed class EntityContainerExpression : global::System.Data.Entity.Core.Common.EntitySql.ExpressionResolution
	{
		// Token: 0x06004DF2 RID: 19954 RVA: 0x001177C6 File Offset: 0x001159C6
		internal EntityContainerExpression(global::System.Data.Entity.Core.Metadata.Edm.EntityContainer entityContainer) : base(global::System.Data.Entity.Core.Common.EntitySql.ExpressionResolutionClass.EntityContainer)
		{
			this.EntityContainer = entityContainer;
		}

		// Token: 0x17000EFD RID: 3837
		// (get) Token: 0x06004DF3 RID: 19955 RVA: 0x001177D6 File Offset: 0x001159D6
		internal override string ExpressionClassName
		{
			get
			{
				return global::System.Data.Entity.Core.Common.EntitySql.EntityContainerExpression.EntityContainerClassName;
			}
		}

		// Token: 0x17000EFE RID: 3838
		// (get) Token: 0x06004DF4 RID: 19956 RVA: 0x001177DD File Offset: 0x001159DD
		internal static string EntityContainerClassName
		{
			get
			{
				return global::System.Data.Entity.Resources.Strings.LocalizedEntityContainerExpression;
			}
		}

		// Token: 0x04001C2B RID: 7211
		internal readonly global::System.Data.Entity.Core.Metadata.Edm.EntityContainer EntityContainer;
	}
}
