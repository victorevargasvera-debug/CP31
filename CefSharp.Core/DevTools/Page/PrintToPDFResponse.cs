using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Page
{
	// Token: 0x020001B6 RID: 438
	[global::System.Runtime.Serialization.DataContract]
	public class PrintToPDFResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x17000512 RID: 1298
		// (get) Token: 0x06000D09 RID: 3337 RVA: 0x0000EA97 File Offset: 0x0000CC97
		// (set) Token: 0x06000D0A RID: 3338 RVA: 0x0000EA9F File Offset: 0x0000CC9F
		[global::System.Runtime.Serialization.DataMember]
		internal string data { get; set; }

		// Token: 0x17000513 RID: 1299
		// (get) Token: 0x06000D0B RID: 3339 RVA: 0x0000EAA8 File Offset: 0x0000CCA8
		public byte[] Data
		{
			get
			{
				return base.Convert(this.data);
			}
		}

		// Token: 0x17000514 RID: 1300
		// (get) Token: 0x06000D0C RID: 3340 RVA: 0x0000EAB6 File Offset: 0x0000CCB6
		// (set) Token: 0x06000D0D RID: 3341 RVA: 0x0000EABE File Offset: 0x0000CCBE
		[global::System.Runtime.Serialization.DataMember]
		internal string stream { get; set; }

		// Token: 0x17000515 RID: 1301
		// (get) Token: 0x06000D0E RID: 3342 RVA: 0x0000EAC7 File Offset: 0x0000CCC7
		public string Stream
		{
			get
			{
				return this.stream;
			}
		}
	}
}
