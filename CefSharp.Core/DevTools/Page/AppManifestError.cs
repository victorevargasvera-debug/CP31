using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Page
{
	// Token: 0x0200017A RID: 378
	[global::System.Runtime.Serialization.DataContract]
	public class AppManifestError : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x1700046A RID: 1130
		// (get) Token: 0x06000BA2 RID: 2978 RVA: 0x0000DD91 File Offset: 0x0000BF91
		// (set) Token: 0x06000BA3 RID: 2979 RVA: 0x0000DD99 File Offset: 0x0000BF99
		[global::System.Runtime.Serialization.DataMember(Name = "message", IsRequired = true)]
		public string Message { get; set; }

		// Token: 0x1700046B RID: 1131
		// (get) Token: 0x06000BA4 RID: 2980 RVA: 0x0000DDA2 File Offset: 0x0000BFA2
		// (set) Token: 0x06000BA5 RID: 2981 RVA: 0x0000DDAA File Offset: 0x0000BFAA
		[global::System.Runtime.Serialization.DataMember(Name = "critical", IsRequired = true)]
		public int Critical { get; set; }

		// Token: 0x1700046C RID: 1132
		// (get) Token: 0x06000BA6 RID: 2982 RVA: 0x0000DDB3 File Offset: 0x0000BFB3
		// (set) Token: 0x06000BA7 RID: 2983 RVA: 0x0000DDBB File Offset: 0x0000BFBB
		[global::System.Runtime.Serialization.DataMember(Name = "line", IsRequired = true)]
		public int Line { get; set; }

		// Token: 0x1700046D RID: 1133
		// (get) Token: 0x06000BA8 RID: 2984 RVA: 0x0000DDC4 File Offset: 0x0000BFC4
		// (set) Token: 0x06000BA9 RID: 2985 RVA: 0x0000DDCC File Offset: 0x0000BFCC
		[global::System.Runtime.Serialization.DataMember(Name = "column", IsRequired = true)]
		public int Column { get; set; }
	}
}
