using System;
using System.Runtime.Serialization;

namespace CefSharp.Internals.Wcf
{
	// Token: 0x020000F6 RID: 246
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Runtime.Serialization.KnownType(typeof(bool[]))]
	[global::System.Runtime.Serialization.KnownType(typeof(byte[]))]
	[global::System.Runtime.Serialization.KnownType(typeof(short[]))]
	[global::System.Runtime.Serialization.KnownType(typeof(int[]))]
	[global::System.Runtime.Serialization.KnownType(typeof(long[]))]
	[global::System.Runtime.Serialization.KnownType(typeof(ushort[]))]
	[global::System.Runtime.Serialization.KnownType(typeof(uint[]))]
	[global::System.Runtime.Serialization.KnownType(typeof(ulong[]))]
	[global::System.Runtime.Serialization.KnownType(typeof(float[]))]
	[global::System.Runtime.Serialization.KnownType(typeof(double[]))]
	[global::System.Runtime.Serialization.KnownType(typeof(string[]))]
	public class BrowserProcessResponse
	{
		// Token: 0x17000229 RID: 553
		// (get) Token: 0x06000749 RID: 1865 RVA: 0x0000BE9B File Offset: 0x0000A09B
		// (set) Token: 0x0600074A RID: 1866 RVA: 0x0000BEA3 File Offset: 0x0000A0A3
		[global::System.Runtime.Serialization.DataMember]
		public string Message { get; set; }

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x0600074B RID: 1867 RVA: 0x0000BEAC File Offset: 0x0000A0AC
		// (set) Token: 0x0600074C RID: 1868 RVA: 0x0000BEB4 File Offset: 0x0000A0B4
		[global::System.Runtime.Serialization.DataMember]
		public bool Success { get; set; }

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x0600074D RID: 1869 RVA: 0x0000BEBD File Offset: 0x0000A0BD
		// (set) Token: 0x0600074E RID: 1870 RVA: 0x0000BEC5 File Offset: 0x0000A0C5
		[global::System.Runtime.Serialization.DataMember]
		public object Result { get; set; }
	}
}
