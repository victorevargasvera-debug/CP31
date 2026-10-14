using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.CSS
{
	// Token: 0x0200032A RID: 810
	[global::System.Runtime.Serialization.DataContract]
	public class SetStyleSheetTextResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x170009B0 RID: 2480
		// (get) Token: 0x060018B0 RID: 6320 RVA: 0x0001A532 File Offset: 0x00018732
		// (set) Token: 0x060018B1 RID: 6321 RVA: 0x0001A53A File Offset: 0x0001873A
		[global::System.Runtime.Serialization.DataMember]
		internal string sourceMapURL { get; set; }

		// Token: 0x170009B1 RID: 2481
		// (get) Token: 0x060018B2 RID: 6322 RVA: 0x0001A543 File Offset: 0x00018743
		public string SourceMapURL
		{
			get
			{
				return this.sourceMapURL;
			}
		}
	}
}
