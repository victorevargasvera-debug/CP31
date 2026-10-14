using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Page
{
	// Token: 0x020001A8 RID: 424
	[global::System.Runtime.Serialization.DataContract]
	public class AddScriptToEvaluateOnNewDocumentResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x170004DC RID: 1244
		// (get) Token: 0x06000CAA RID: 3242 RVA: 0x0000E77E File Offset: 0x0000C97E
		// (set) Token: 0x06000CAB RID: 3243 RVA: 0x0000E786 File Offset: 0x0000C986
		[global::System.Runtime.Serialization.DataMember]
		internal string identifier { get; set; }

		// Token: 0x170004DD RID: 1245
		// (get) Token: 0x06000CAC RID: 3244 RVA: 0x0000E78F File Offset: 0x0000C98F
		public string Identifier
		{
			get
			{
				return this.identifier;
			}
		}
	}
}
