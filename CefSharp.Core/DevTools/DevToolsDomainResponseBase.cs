using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools
{
	// Token: 0x02000025 RID: 37
	[global::System.Runtime.Serialization.DataContract]
	public abstract class DevToolsDomainResponseBase
	{
		// Token: 0x060001FE RID: 510 RVA: 0x00004CD4 File Offset: 0x00002ED4
		public byte[] Convert(string data)
		{
			return global::System.Convert.FromBase64String(data);
		}
	}
}
