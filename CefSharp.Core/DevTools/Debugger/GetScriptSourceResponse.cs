using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Debugger
{
	// Token: 0x0200008B RID: 139
	[global::System.Runtime.Serialization.DataContract]
	public class GetScriptSourceResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x170001DF RID: 479
		// (get) Token: 0x06000507 RID: 1287 RVA: 0x0000791F File Offset: 0x00005B1F
		// (set) Token: 0x06000508 RID: 1288 RVA: 0x00007927 File Offset: 0x00005B27
		[global::System.Runtime.Serialization.DataMember]
		internal string scriptSource { get; set; }

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x06000509 RID: 1289 RVA: 0x00007930 File Offset: 0x00005B30
		public string ScriptSource
		{
			get
			{
				return this.scriptSource;
			}
		}

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x0600050A RID: 1290 RVA: 0x00007938 File Offset: 0x00005B38
		// (set) Token: 0x0600050B RID: 1291 RVA: 0x00007940 File Offset: 0x00005B40
		[global::System.Runtime.Serialization.DataMember]
		internal string bytecode { get; set; }

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x0600050C RID: 1292 RVA: 0x00007949 File Offset: 0x00005B49
		public byte[] Bytecode
		{
			get
			{
				return base.Convert(this.bytecode);
			}
		}
	}
}
