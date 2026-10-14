using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Page
{
	// Token: 0x0200017F RID: 383
	[global::System.Runtime.Serialization.DataContract]
	public class FontFamilies : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000480 RID: 1152
		// (get) Token: 0x06000BD3 RID: 3027 RVA: 0x0000DF3E File Offset: 0x0000C13E
		// (set) Token: 0x06000BD4 RID: 3028 RVA: 0x0000DF46 File Offset: 0x0000C146
		[global::System.Runtime.Serialization.DataMember(Name = "standard", IsRequired = false)]
		public string Standard { get; set; }

		// Token: 0x17000481 RID: 1153
		// (get) Token: 0x06000BD5 RID: 3029 RVA: 0x0000DF4F File Offset: 0x0000C14F
		// (set) Token: 0x06000BD6 RID: 3030 RVA: 0x0000DF57 File Offset: 0x0000C157
		[global::System.Runtime.Serialization.DataMember(Name = "fixed", IsRequired = false)]
		public string Fixed { get; set; }

		// Token: 0x17000482 RID: 1154
		// (get) Token: 0x06000BD7 RID: 3031 RVA: 0x0000DF60 File Offset: 0x0000C160
		// (set) Token: 0x06000BD8 RID: 3032 RVA: 0x0000DF68 File Offset: 0x0000C168
		[global::System.Runtime.Serialization.DataMember(Name = "serif", IsRequired = false)]
		public string Serif { get; set; }

		// Token: 0x17000483 RID: 1155
		// (get) Token: 0x06000BD9 RID: 3033 RVA: 0x0000DF71 File Offset: 0x0000C171
		// (set) Token: 0x06000BDA RID: 3034 RVA: 0x0000DF79 File Offset: 0x0000C179
		[global::System.Runtime.Serialization.DataMember(Name = "sansSerif", IsRequired = false)]
		public string SansSerif { get; set; }

		// Token: 0x17000484 RID: 1156
		// (get) Token: 0x06000BDB RID: 3035 RVA: 0x0000DF82 File Offset: 0x0000C182
		// (set) Token: 0x06000BDC RID: 3036 RVA: 0x0000DF8A File Offset: 0x0000C18A
		[global::System.Runtime.Serialization.DataMember(Name = "cursive", IsRequired = false)]
		public string Cursive { get; set; }

		// Token: 0x17000485 RID: 1157
		// (get) Token: 0x06000BDD RID: 3037 RVA: 0x0000DF93 File Offset: 0x0000C193
		// (set) Token: 0x06000BDE RID: 3038 RVA: 0x0000DF9B File Offset: 0x0000C19B
		[global::System.Runtime.Serialization.DataMember(Name = "fantasy", IsRequired = false)]
		public string Fantasy { get; set; }

		// Token: 0x17000486 RID: 1158
		// (get) Token: 0x06000BDF RID: 3039 RVA: 0x0000DFA4 File Offset: 0x0000C1A4
		// (set) Token: 0x06000BE0 RID: 3040 RVA: 0x0000DFAC File Offset: 0x0000C1AC
		[global::System.Runtime.Serialization.DataMember(Name = "math", IsRequired = false)]
		public string Math { get; set; }
	}
}
