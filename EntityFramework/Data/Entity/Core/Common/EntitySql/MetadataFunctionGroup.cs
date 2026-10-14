using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Resources;

namespace System.Data.Entity.Core.Common.EntitySql
{
	// Token: 0x0200065E RID: 1630
	internal sealed class MetadataFunctionGroup : global::System.Data.Entity.Core.Common.EntitySql.MetadataMember
	{
		// Token: 0x06004E29 RID: 20009 RVA: 0x0011813E File Offset: 0x0011633E
		internal MetadataFunctionGroup(string name, global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction> functionMetadata) : base(global::System.Data.Entity.Core.Common.EntitySql.MetadataMemberClass.FunctionGroup, name)
		{
			this.FunctionMetadata = functionMetadata;
		}

		// Token: 0x17000F11 RID: 3857
		// (get) Token: 0x06004E2A RID: 20010 RVA: 0x0011814F File Offset: 0x0011634F
		internal override string MetadataMemberClassName
		{
			get
			{
				return global::System.Data.Entity.Core.Common.EntitySql.MetadataFunctionGroup.FunctionGroupClassName;
			}
		}

		// Token: 0x17000F12 RID: 3858
		// (get) Token: 0x06004E2B RID: 20011 RVA: 0x00118156 File Offset: 0x00116356
		internal static string FunctionGroupClassName
		{
			get
			{
				return global::System.Data.Entity.Resources.Strings.LocalizedFunction;
			}
		}

		// Token: 0x04001C54 RID: 7252
		internal readonly global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction> FunctionMetadata;
	}
}
