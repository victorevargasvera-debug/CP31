using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.IndexedDB
{
	// Token: 0x02000275 RID: 629
	[global::System.Runtime.Serialization.DataContract]
	public class Key : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x1700076D RID: 1901
		// (get) Token: 0x06001335 RID: 4917 RVA: 0x000153D2 File Offset: 0x000135D2
		// (set) Token: 0x06001336 RID: 4918 RVA: 0x000153EE File Offset: 0x000135EE
		public global::CefSharp.DevTools.IndexedDB.KeyType Type
		{
			get
			{
				return (global::CefSharp.DevTools.IndexedDB.KeyType)global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.IndexedDB.KeyType), this.type);
			}
			set
			{
				this.type = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x1700076E RID: 1902
		// (get) Token: 0x06001337 RID: 4919 RVA: 0x00015401 File Offset: 0x00013601
		// (set) Token: 0x06001338 RID: 4920 RVA: 0x00015409 File Offset: 0x00013609
		[global::System.Runtime.Serialization.DataMember(Name = "type", IsRequired = true)]
		internal string type { get; set; }

		// Token: 0x1700076F RID: 1903
		// (get) Token: 0x06001339 RID: 4921 RVA: 0x00015412 File Offset: 0x00013612
		// (set) Token: 0x0600133A RID: 4922 RVA: 0x0001541A File Offset: 0x0001361A
		[global::System.Runtime.Serialization.DataMember(Name = "number", IsRequired = false)]
		public double? Number { get; set; }

		// Token: 0x17000770 RID: 1904
		// (get) Token: 0x0600133B RID: 4923 RVA: 0x00015423 File Offset: 0x00013623
		// (set) Token: 0x0600133C RID: 4924 RVA: 0x0001542B File Offset: 0x0001362B
		[global::System.Runtime.Serialization.DataMember(Name = "string", IsRequired = false)]
		public string String { get; set; }

		// Token: 0x17000771 RID: 1905
		// (get) Token: 0x0600133D RID: 4925 RVA: 0x00015434 File Offset: 0x00013634
		// (set) Token: 0x0600133E RID: 4926 RVA: 0x0001543C File Offset: 0x0001363C
		[global::System.Runtime.Serialization.DataMember(Name = "date", IsRequired = false)]
		public double? Date { get; set; }

		// Token: 0x17000772 RID: 1906
		// (get) Token: 0x0600133F RID: 4927 RVA: 0x00015445 File Offset: 0x00013645
		// (set) Token: 0x06001340 RID: 4928 RVA: 0x0001544D File Offset: 0x0001364D
		[global::System.Runtime.Serialization.DataMember(Name = "array", IsRequired = false)]
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.IndexedDB.Key> Array { get; set; }
	}
}
