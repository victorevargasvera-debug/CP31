using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Storage
{
	// Token: 0x02000121 RID: 289
	[global::System.Runtime.Serialization.DataContract]
	public class UsageForType : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x1700035F RID: 863
		// (get) Token: 0x06000908 RID: 2312 RVA: 0x0000BAB8 File Offset: 0x00009CB8
		// (set) Token: 0x06000909 RID: 2313 RVA: 0x0000BAD4 File Offset: 0x00009CD4
		public global::CefSharp.DevTools.Storage.StorageType StorageType
		{
			get
			{
				return (global::CefSharp.DevTools.Storage.StorageType)global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.Storage.StorageType), this.storageType);
			}
			set
			{
				this.storageType = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x17000360 RID: 864
		// (get) Token: 0x0600090A RID: 2314 RVA: 0x0000BAE7 File Offset: 0x00009CE7
		// (set) Token: 0x0600090B RID: 2315 RVA: 0x0000BAEF File Offset: 0x00009CEF
		[global::System.Runtime.Serialization.DataMember(Name = "storageType", IsRequired = true)]
		internal string storageType { get; set; }

		// Token: 0x17000361 RID: 865
		// (get) Token: 0x0600090C RID: 2316 RVA: 0x0000BAF8 File Offset: 0x00009CF8
		// (set) Token: 0x0600090D RID: 2317 RVA: 0x0000BB00 File Offset: 0x00009D00
		[global::System.Runtime.Serialization.DataMember(Name = "usage", IsRequired = true)]
		public double Usage { get; set; }
	}
}
