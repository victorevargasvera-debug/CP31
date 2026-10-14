using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Core.Mapping.ViewGeneration.Structures;
using System.Data.Entity.Core.Metadata.Edm;
using System.Text;

namespace System.Data.Entity.Core.Mapping.ViewGeneration
{
	// Token: 0x02000571 RID: 1393
	internal class ViewGenResults : global::System.Data.Entity.Core.Common.Utils.InternalBase
	{
		// Token: 0x060043E2 RID: 17378 RVA: 0x000EBD06 File Offset: 0x000E9F06
		internal ViewGenResults()
		{
			this.m_views = new global::System.Data.Entity.Core.Common.Utils.KeyToListMap<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase, global::System.Data.Entity.Core.Mapping.ViewGeneration.GeneratedView>(global::System.Collections.Generic.EqualityComparer<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase>.Default);
			this.m_errorLog = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog();
		}

		// Token: 0x17000D76 RID: 3446
		// (get) Token: 0x060043E3 RID: 17379 RVA: 0x000EBD29 File Offset: 0x000E9F29
		internal global::System.Data.Entity.Core.Common.Utils.KeyToListMap<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase, global::System.Data.Entity.Core.Mapping.ViewGeneration.GeneratedView> Views
		{
			get
			{
				return this.m_views;
			}
		}

		// Token: 0x17000D77 RID: 3447
		// (get) Token: 0x060043E4 RID: 17380 RVA: 0x000EBD31 File Offset: 0x000E9F31
		internal global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError> Errors
		{
			get
			{
				return this.m_errorLog.Errors;
			}
		}

		// Token: 0x17000D78 RID: 3448
		// (get) Token: 0x060043E5 RID: 17381 RVA: 0x000EBD3E File Offset: 0x000E9F3E
		internal bool HasErrors
		{
			get
			{
				return this.m_errorLog.Count > 0;
			}
		}

		// Token: 0x060043E6 RID: 17382 RVA: 0x000EBD4E File Offset: 0x000E9F4E
		internal void AddErrors(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog errorLog)
		{
			this.m_errorLog.Merge(errorLog);
		}

		// Token: 0x060043E7 RID: 17383 RVA: 0x000EBD5C File Offset: 0x000E9F5C
		internal string ErrorsToString()
		{
			return this.m_errorLog.ToString();
		}

		// Token: 0x060043E8 RID: 17384 RVA: 0x000EBD69 File Offset: 0x000E9F69
		internal override void ToCompactString(global::System.Text.StringBuilder builder)
		{
			builder.Append(this.m_errorLog.Count);
			builder.Append(" ");
			this.m_errorLog.ToCompactString(builder);
		}

		// Token: 0x0400185B RID: 6235
		private readonly global::System.Data.Entity.Core.Common.Utils.KeyToListMap<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase, global::System.Data.Entity.Core.Mapping.ViewGeneration.GeneratedView> m_views;

		// Token: 0x0400185C RID: 6236
		private readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog m_errorLog;
	}
}
