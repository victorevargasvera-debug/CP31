using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools
{
	// Token: 0x02000020 RID: 32
	[global::System.Serializable]
	public class DevToolsClientException : global::System.Exception
	{
		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x060001E0 RID: 480 RVA: 0x000047CC File Offset: 0x000029CC
		// (set) Token: 0x060001E1 RID: 481 RVA: 0x000047D4 File Offset: 0x000029D4
		public global::CefSharp.DevTools.DevToolsDomainErrorResponse Response { get; private set; }

		// Token: 0x060001E2 RID: 482 RVA: 0x000047DD File Offset: 0x000029DD
		public DevToolsClientException() : base("Error occurred whilst executing DevTools protocol method")
		{
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x000047EA File Offset: 0x000029EA
		public DevToolsClientException(string message) : base(message)
		{
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x000047F3 File Offset: 0x000029F3
		public DevToolsClientException(string message, global::CefSharp.DevTools.DevToolsDomainErrorResponse errorResponse) : base(message)
		{
			this.Response = errorResponse;
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x00004803 File Offset: 0x00002A03
		public DevToolsClientException(string message, global::System.Exception inner) : base(message, inner)
		{
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x0000480D File Offset: 0x00002A0D
		protected DevToolsClientException(global::System.Runtime.Serialization.SerializationInfo serializationInfo, global::System.Runtime.Serialization.StreamingContext streamingContext) : base(serializationInfo, streamingContext)
		{
		}
	}
}
