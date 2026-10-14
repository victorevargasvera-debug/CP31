using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization;
using CefSharp.Internals;

namespace CefSharp
{
	// Token: 0x0200008A RID: 138
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Runtime.Serialization.KnownType(typeof(object[]))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::CefSharp.Internals.JavascriptCallback))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
	[global::System.Diagnostics.DebuggerDisplay("Success = {Success}, Message = {Message}, Result = {Result}")]
	public class JavascriptResponse
	{
		// Token: 0x17000138 RID: 312
		// (get) Token: 0x060003A3 RID: 931 RVA: 0x00003704 File Offset: 0x00001904
		// (set) Token: 0x060003A4 RID: 932 RVA: 0x0000370C File Offset: 0x0000190C
		[global::System.Runtime.Serialization.DataMember]
		public string Message { get; set; }

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x060003A5 RID: 933 RVA: 0x00003715 File Offset: 0x00001915
		// (set) Token: 0x060003A6 RID: 934 RVA: 0x0000371D File Offset: 0x0000191D
		[global::System.Runtime.Serialization.DataMember]
		public bool Success { get; set; }

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x060003A7 RID: 935 RVA: 0x00003726 File Offset: 0x00001926
		// (set) Token: 0x060003A8 RID: 936 RVA: 0x0000372E File Offset: 0x0000192E
		[global::System.Runtime.Serialization.DataMember]
		public object Result { get; set; }
	}
}
