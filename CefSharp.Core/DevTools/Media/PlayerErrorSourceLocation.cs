using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Media
{
	// Token: 0x020000B7 RID: 183
	[global::System.Runtime.Serialization.DataContract]
	public class PlayerErrorSourceLocation : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x1700024E RID: 590
		// (get) Token: 0x06000632 RID: 1586 RVA: 0x00008F51 File Offset: 0x00007151
		// (set) Token: 0x06000633 RID: 1587 RVA: 0x00008F59 File Offset: 0x00007159
		[global::System.Runtime.Serialization.DataMember(Name = "file", IsRequired = true)]
		public string File { get; set; }

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x06000634 RID: 1588 RVA: 0x00008F62 File Offset: 0x00007162
		// (set) Token: 0x06000635 RID: 1589 RVA: 0x00008F6A File Offset: 0x0000716A
		[global::System.Runtime.Serialization.DataMember(Name = "line", IsRequired = true)]
		public int Line { get; set; }
	}
}
