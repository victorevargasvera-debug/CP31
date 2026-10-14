using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Page
{
	// Token: 0x0200019E RID: 414
	[global::System.Runtime.Serialization.DataContract]
	public class JavascriptDialogClosedEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x170004BF RID: 1215
		// (get) Token: 0x06000C66 RID: 3174 RVA: 0x0000E523 File Offset: 0x0000C723
		// (set) Token: 0x06000C67 RID: 3175 RVA: 0x0000E52B File Offset: 0x0000C72B
		[global::System.Runtime.Serialization.DataMember(Name = "result", IsRequired = true)]
		public bool Result { get; private set; }

		// Token: 0x170004C0 RID: 1216
		// (get) Token: 0x06000C68 RID: 3176 RVA: 0x0000E534 File Offset: 0x0000C734
		// (set) Token: 0x06000C69 RID: 3177 RVA: 0x0000E53C File Offset: 0x0000C73C
		[global::System.Runtime.Serialization.DataMember(Name = "userInput", IsRequired = true)]
		public string UserInput { get; private set; }
	}
}
