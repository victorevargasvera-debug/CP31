using System;
using System.Collections.Generic;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x020004A5 RID: 1189
	public class EdmFunctionPayload
	{
		// Token: 0x17000B3F RID: 2879
		// (get) Token: 0x06003A7C RID: 14972 RVA: 0x000C06E4 File Offset: 0x000BE8E4
		// (set) Token: 0x06003A7D RID: 14973 RVA: 0x000C06EC File Offset: 0x000BE8EC
		public string Schema { get; set; }

		// Token: 0x17000B40 RID: 2880
		// (get) Token: 0x06003A7E RID: 14974 RVA: 0x000C06F5 File Offset: 0x000BE8F5
		// (set) Token: 0x06003A7F RID: 14975 RVA: 0x000C06FD File Offset: 0x000BE8FD
		public string StoreFunctionName { get; set; }

		// Token: 0x17000B41 RID: 2881
		// (get) Token: 0x06003A80 RID: 14976 RVA: 0x000C0706 File Offset: 0x000BE906
		// (set) Token: 0x06003A81 RID: 14977 RVA: 0x000C070E File Offset: 0x000BE90E
		public string CommandText { get; set; }

		// Token: 0x17000B42 RID: 2882
		// (get) Token: 0x06003A82 RID: 14978 RVA: 0x000C0717 File Offset: 0x000BE917
		// (set) Token: 0x06003A83 RID: 14979 RVA: 0x000C071F File Offset: 0x000BE91F
		public global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Metadata.Edm.EntitySet> EntitySets { get; set; }

		// Token: 0x17000B43 RID: 2883
		// (get) Token: 0x06003A84 RID: 14980 RVA: 0x000C0728 File Offset: 0x000BE928
		// (set) Token: 0x06003A85 RID: 14981 RVA: 0x000C0730 File Offset: 0x000BE930
		public bool? IsAggregate { get; set; }

		// Token: 0x17000B44 RID: 2884
		// (get) Token: 0x06003A86 RID: 14982 RVA: 0x000C0739 File Offset: 0x000BE939
		// (set) Token: 0x06003A87 RID: 14983 RVA: 0x000C0741 File Offset: 0x000BE941
		public bool? IsBuiltIn { get; set; }

		// Token: 0x17000B45 RID: 2885
		// (get) Token: 0x06003A88 RID: 14984 RVA: 0x000C074A File Offset: 0x000BE94A
		// (set) Token: 0x06003A89 RID: 14985 RVA: 0x000C0752 File Offset: 0x000BE952
		public bool? IsNiladic { get; set; }

		// Token: 0x17000B46 RID: 2886
		// (get) Token: 0x06003A8A RID: 14986 RVA: 0x000C075B File Offset: 0x000BE95B
		// (set) Token: 0x06003A8B RID: 14987 RVA: 0x000C0763 File Offset: 0x000BE963
		public bool? IsComposable { get; set; }

		// Token: 0x17000B47 RID: 2887
		// (get) Token: 0x06003A8C RID: 14988 RVA: 0x000C076C File Offset: 0x000BE96C
		// (set) Token: 0x06003A8D RID: 14989 RVA: 0x000C0774 File Offset: 0x000BE974
		public bool? IsFromProviderManifest { get; set; }

		// Token: 0x17000B48 RID: 2888
		// (get) Token: 0x06003A8E RID: 14990 RVA: 0x000C077D File Offset: 0x000BE97D
		// (set) Token: 0x06003A8F RID: 14991 RVA: 0x000C0785 File Offset: 0x000BE985
		public bool? IsCachedStoreFunction { get; set; }

		// Token: 0x17000B49 RID: 2889
		// (get) Token: 0x06003A90 RID: 14992 RVA: 0x000C078E File Offset: 0x000BE98E
		// (set) Token: 0x06003A91 RID: 14993 RVA: 0x000C0796 File Offset: 0x000BE996
		public bool? IsFunctionImport { get; set; }

		// Token: 0x17000B4A RID: 2890
		// (get) Token: 0x06003A92 RID: 14994 RVA: 0x000C079F File Offset: 0x000BE99F
		// (set) Token: 0x06003A93 RID: 14995 RVA: 0x000C07A7 File Offset: 0x000BE9A7
		public global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter> ReturnParameters { get; set; }

		// Token: 0x17000B4B RID: 2891
		// (get) Token: 0x06003A94 RID: 14996 RVA: 0x000C07B0 File Offset: 0x000BE9B0
		// (set) Token: 0x06003A95 RID: 14997 RVA: 0x000C07B8 File Offset: 0x000BE9B8
		public global::System.Data.Entity.Core.Metadata.Edm.ParameterTypeSemantics? ParameterTypeSemantics { get; set; }

		// Token: 0x17000B4C RID: 2892
		// (get) Token: 0x06003A96 RID: 14998 RVA: 0x000C07C1 File Offset: 0x000BE9C1
		// (set) Token: 0x06003A97 RID: 14999 RVA: 0x000C07C9 File Offset: 0x000BE9C9
		public global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter> Parameters { get; set; }
	}
}
