using System;
using System.Collections.Generic;
using System.Data.Entity.Resources;

namespace System.Data.Entity.Core.Common.EntitySql
{
	// Token: 0x0200065F RID: 1631
	internal abstract class MetadataMember : global::System.Data.Entity.Core.Common.EntitySql.ExpressionResolution
	{
		// Token: 0x06004E2C RID: 20012 RVA: 0x0011815D File Offset: 0x0011635D
		protected MetadataMember(global::System.Data.Entity.Core.Common.EntitySql.MetadataMemberClass @class, string name) : base(global::System.Data.Entity.Core.Common.EntitySql.ExpressionResolutionClass.MetadataMember)
		{
			this.MetadataMemberClass = @class;
			this.Name = name;
		}

		// Token: 0x17000F13 RID: 3859
		// (get) Token: 0x06004E2D RID: 20013 RVA: 0x00118174 File Offset: 0x00116374
		internal override string ExpressionClassName
		{
			get
			{
				return global::System.Data.Entity.Core.Common.EntitySql.MetadataMember.MetadataMemberExpressionClassName;
			}
		}

		// Token: 0x17000F14 RID: 3860
		// (get) Token: 0x06004E2E RID: 20014 RVA: 0x0011817B File Offset: 0x0011637B
		internal static string MetadataMemberExpressionClassName
		{
			get
			{
				return global::System.Data.Entity.Resources.Strings.LocalizedMetadataMemberExpression;
			}
		}

		// Token: 0x17000F15 RID: 3861
		// (get) Token: 0x06004E2F RID: 20015
		internal abstract string MetadataMemberClassName { get; }

		// Token: 0x06004E30 RID: 20016 RVA: 0x00118182 File Offset: 0x00116382
		internal static global::System.Collections.Generic.IEqualityComparer<global::System.Data.Entity.Core.Common.EntitySql.MetadataMember> CreateMetadataMemberNameEqualityComparer(global::System.StringComparer stringComparer)
		{
			return new global::System.Data.Entity.Core.Common.EntitySql.MetadataMember.MetadataMemberNameEqualityComparer(stringComparer);
		}

		// Token: 0x04001C55 RID: 7253
		internal readonly global::System.Data.Entity.Core.Common.EntitySql.MetadataMemberClass MetadataMemberClass;

		// Token: 0x04001C56 RID: 7254
		internal readonly string Name;

		// Token: 0x02000C74 RID: 3188
		private sealed class MetadataMemberNameEqualityComparer : global::System.Collections.Generic.IEqualityComparer<global::System.Data.Entity.Core.Common.EntitySql.MetadataMember>
		{
			// Token: 0x06006B6A RID: 27498 RVA: 0x0016E77C File Offset: 0x0016C97C
			internal MetadataMemberNameEqualityComparer(global::System.StringComparer stringComparer)
			{
				this._stringComparer = stringComparer;
			}

			// Token: 0x06006B6B RID: 27499 RVA: 0x0016E78B File Offset: 0x0016C98B
			bool global::System.Collections.Generic.IEqualityComparer<global::System.Data.Entity.Core.Common.EntitySql.MetadataMember>.Equals(global::System.Data.Entity.Core.Common.EntitySql.MetadataMember x, global::System.Data.Entity.Core.Common.EntitySql.MetadataMember y)
			{
				return this._stringComparer.Equals(x.Name, y.Name);
			}

			// Token: 0x06006B6C RID: 27500 RVA: 0x0016E7A4 File Offset: 0x0016C9A4
			int global::System.Collections.Generic.IEqualityComparer<global::System.Data.Entity.Core.Common.EntitySql.MetadataMember>.GetHashCode(global::System.Data.Entity.Core.Common.EntitySql.MetadataMember obj)
			{
				return this._stringComparer.GetHashCode(obj.Name);
			}

			// Token: 0x04003136 RID: 12598
			private readonly global::System.StringComparer _stringComparer;
		}
	}
}
