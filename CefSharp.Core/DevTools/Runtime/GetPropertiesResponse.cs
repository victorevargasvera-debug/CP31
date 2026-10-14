using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Runtime
{
	// Token: 0x02000056 RID: 86
	[global::System.Runtime.Serialization.DataContract]
	public class GetPropertiesResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x17000130 RID: 304
		// (get) Token: 0x06000343 RID: 835 RVA: 0x00005B2F File Offset: 0x00003D2F
		// (set) Token: 0x06000344 RID: 836 RVA: 0x00005B37 File Offset: 0x00003D37
		[global::System.Runtime.Serialization.DataMember]
		internal global::System.Collections.Generic.IList<global::CefSharp.DevTools.Runtime.PropertyDescriptor> result { get; set; }

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x06000345 RID: 837 RVA: 0x00005B40 File Offset: 0x00003D40
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.Runtime.PropertyDescriptor> Result
		{
			get
			{
				return this.result;
			}
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x06000346 RID: 838 RVA: 0x00005B48 File Offset: 0x00003D48
		// (set) Token: 0x06000347 RID: 839 RVA: 0x00005B50 File Offset: 0x00003D50
		[global::System.Runtime.Serialization.DataMember]
		internal global::System.Collections.Generic.IList<global::CefSharp.DevTools.Runtime.InternalPropertyDescriptor> internalProperties { get; set; }

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x06000348 RID: 840 RVA: 0x00005B59 File Offset: 0x00003D59
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.Runtime.InternalPropertyDescriptor> InternalProperties
		{
			get
			{
				return this.internalProperties;
			}
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x06000349 RID: 841 RVA: 0x00005B61 File Offset: 0x00003D61
		// (set) Token: 0x0600034A RID: 842 RVA: 0x00005B69 File Offset: 0x00003D69
		[global::System.Runtime.Serialization.DataMember]
		internal global::System.Collections.Generic.IList<global::CefSharp.DevTools.Runtime.PrivatePropertyDescriptor> privateProperties { get; set; }

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x0600034B RID: 843 RVA: 0x00005B72 File Offset: 0x00003D72
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.Runtime.PrivatePropertyDescriptor> PrivateProperties
		{
			get
			{
				return this.privateProperties;
			}
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x0600034C RID: 844 RVA: 0x00005B7A File Offset: 0x00003D7A
		// (set) Token: 0x0600034D RID: 845 RVA: 0x00005B82 File Offset: 0x00003D82
		[global::System.Runtime.Serialization.DataMember]
		internal global::CefSharp.DevTools.Runtime.ExceptionDetails exceptionDetails { get; set; }

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x0600034E RID: 846 RVA: 0x00005B8B File Offset: 0x00003D8B
		public global::CefSharp.DevTools.Runtime.ExceptionDetails ExceptionDetails
		{
			get
			{
				return this.exceptionDetails;
			}
		}
	}
}
