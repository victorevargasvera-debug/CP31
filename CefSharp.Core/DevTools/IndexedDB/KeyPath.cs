using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.IndexedDB
{
	// Token: 0x02000279 RID: 633
	[global::System.Runtime.Serialization.DataContract]
	public class KeyPath : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x1700077A RID: 1914
		// (get) Token: 0x06001352 RID: 4946 RVA: 0x000154E5 File Offset: 0x000136E5
		// (set) Token: 0x06001353 RID: 4947 RVA: 0x00015501 File Offset: 0x00013701
		public global::CefSharp.DevTools.IndexedDB.KeyPathType Type
		{
			get
			{
				return (global::CefSharp.DevTools.IndexedDB.KeyPathType)global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.IndexedDB.KeyPathType), this.type);
			}
			set
			{
				this.type = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x1700077B RID: 1915
		// (get) Token: 0x06001354 RID: 4948 RVA: 0x00015514 File Offset: 0x00013714
		// (set) Token: 0x06001355 RID: 4949 RVA: 0x0001551C File Offset: 0x0001371C
		[global::System.Runtime.Serialization.DataMember(Name = "type", IsRequired = true)]
		internal string type { get; set; }

		// Token: 0x1700077C RID: 1916
		// (get) Token: 0x06001356 RID: 4950 RVA: 0x00015525 File Offset: 0x00013725
		// (set) Token: 0x06001357 RID: 4951 RVA: 0x0001552D File Offset: 0x0001372D
		[global::System.Runtime.Serialization.DataMember(Name = "string", IsRequired = false)]
		public string String { get; set; }

		// Token: 0x1700077D RID: 1917
		// (get) Token: 0x06001358 RID: 4952 RVA: 0x00015536 File Offset: 0x00013736
		// (set) Token: 0x06001359 RID: 4953 RVA: 0x0001553E File Offset: 0x0001373E
		[global::System.Runtime.Serialization.DataMember(Name = "array", IsRequired = false)]
		public string[] Array { get; set; }
	}
}
