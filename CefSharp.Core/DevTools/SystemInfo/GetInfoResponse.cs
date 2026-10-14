using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.SystemInfo
{
	// Token: 0x0200011C RID: 284
	[global::System.Runtime.Serialization.DataContract]
	public class GetInfoResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x17000353 RID: 851
		// (get) Token: 0x060008EF RID: 2287 RVA: 0x0000B98A File Offset: 0x00009B8A
		// (set) Token: 0x060008F0 RID: 2288 RVA: 0x0000B992 File Offset: 0x00009B92
		[global::System.Runtime.Serialization.DataMember]
		internal global::CefSharp.DevTools.SystemInfo.GPUInfo gpu { get; set; }

		// Token: 0x17000354 RID: 852
		// (get) Token: 0x060008F1 RID: 2289 RVA: 0x0000B99B File Offset: 0x00009B9B
		public global::CefSharp.DevTools.SystemInfo.GPUInfo Gpu
		{
			get
			{
				return this.gpu;
			}
		}

		// Token: 0x17000355 RID: 853
		// (get) Token: 0x060008F2 RID: 2290 RVA: 0x0000B9A3 File Offset: 0x00009BA3
		// (set) Token: 0x060008F3 RID: 2291 RVA: 0x0000B9AB File Offset: 0x00009BAB
		[global::System.Runtime.Serialization.DataMember]
		internal string modelName { get; set; }

		// Token: 0x17000356 RID: 854
		// (get) Token: 0x060008F4 RID: 2292 RVA: 0x0000B9B4 File Offset: 0x00009BB4
		public string ModelName
		{
			get
			{
				return this.modelName;
			}
		}

		// Token: 0x17000357 RID: 855
		// (get) Token: 0x060008F5 RID: 2293 RVA: 0x0000B9BC File Offset: 0x00009BBC
		// (set) Token: 0x060008F6 RID: 2294 RVA: 0x0000B9C4 File Offset: 0x00009BC4
		[global::System.Runtime.Serialization.DataMember]
		internal string modelVersion { get; set; }

		// Token: 0x17000358 RID: 856
		// (get) Token: 0x060008F7 RID: 2295 RVA: 0x0000B9CD File Offset: 0x00009BCD
		public string ModelVersion
		{
			get
			{
				return this.modelVersion;
			}
		}

		// Token: 0x17000359 RID: 857
		// (get) Token: 0x060008F8 RID: 2296 RVA: 0x0000B9D5 File Offset: 0x00009BD5
		// (set) Token: 0x060008F9 RID: 2297 RVA: 0x0000B9DD File Offset: 0x00009BDD
		[global::System.Runtime.Serialization.DataMember]
		internal string commandLine { get; set; }

		// Token: 0x1700035A RID: 858
		// (get) Token: 0x060008FA RID: 2298 RVA: 0x0000B9E6 File Offset: 0x00009BE6
		public string CommandLine
		{
			get
			{
				return this.commandLine;
			}
		}
	}
}
