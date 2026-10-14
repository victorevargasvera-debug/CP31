using System;
using System.Collections.Generic;
using System.Data.Entity.Resources;

namespace System.Data.Entity.Core.Common.EntitySql
{
	// Token: 0x0200065A RID: 1626
	internal sealed class InlineFunctionGroup : global::System.Data.Entity.Core.Common.EntitySql.MetadataMember
	{
		// Token: 0x06004E1F RID: 19999 RVA: 0x001180BD File Offset: 0x001162BD
		internal InlineFunctionGroup(string name, global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Common.EntitySql.InlineFunctionInfo> functionMetadata) : base(global::System.Data.Entity.Core.Common.EntitySql.MetadataMemberClass.InlineFunctionGroup, name)
		{
			this.FunctionMetadata = functionMetadata;
		}

		// Token: 0x17000F0D RID: 3853
		// (get) Token: 0x06004E20 RID: 20000 RVA: 0x001180CE File Offset: 0x001162CE
		internal override string MetadataMemberClassName
		{
			get
			{
				return global::System.Data.Entity.Core.Common.EntitySql.InlineFunctionGroup.InlineFunctionGroupClassName;
			}
		}

		// Token: 0x17000F0E RID: 3854
		// (get) Token: 0x06004E21 RID: 20001 RVA: 0x001180D5 File Offset: 0x001162D5
		internal static string InlineFunctionGroupClassName
		{
			get
			{
				return global::System.Data.Entity.Resources.Strings.LocalizedInlineFunction;
			}
		}

		// Token: 0x04001C4F RID: 7247
		internal readonly global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Common.EntitySql.InlineFunctionInfo> FunctionMetadata;
	}
}
