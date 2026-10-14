using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Emulation
{
	// Token: 0x02000286 RID: 646
	[global::System.Runtime.Serialization.DataContract]
	public class DisplayFeature : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000795 RID: 1941
		// (get) Token: 0x06001394 RID: 5012 RVA: 0x00015AFB File Offset: 0x00013CFB
		// (set) Token: 0x06001395 RID: 5013 RVA: 0x00015B17 File Offset: 0x00013D17
		public global::CefSharp.DevTools.Emulation.DisplayFeatureOrientation Orientation
		{
			get
			{
				return (global::CefSharp.DevTools.Emulation.DisplayFeatureOrientation)global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.Emulation.DisplayFeatureOrientation), this.orientation);
			}
			set
			{
				this.orientation = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x17000796 RID: 1942
		// (get) Token: 0x06001396 RID: 5014 RVA: 0x00015B2A File Offset: 0x00013D2A
		// (set) Token: 0x06001397 RID: 5015 RVA: 0x00015B32 File Offset: 0x00013D32
		[global::System.Runtime.Serialization.DataMember(Name = "orientation", IsRequired = true)]
		internal string orientation { get; set; }

		// Token: 0x17000797 RID: 1943
		// (get) Token: 0x06001398 RID: 5016 RVA: 0x00015B3B File Offset: 0x00013D3B
		// (set) Token: 0x06001399 RID: 5017 RVA: 0x00015B43 File Offset: 0x00013D43
		[global::System.Runtime.Serialization.DataMember(Name = "offset", IsRequired = true)]
		public int Offset { get; set; }

		// Token: 0x17000798 RID: 1944
		// (get) Token: 0x0600139A RID: 5018 RVA: 0x00015B4C File Offset: 0x00013D4C
		// (set) Token: 0x0600139B RID: 5019 RVA: 0x00015B54 File Offset: 0x00013D54
		[global::System.Runtime.Serialization.DataMember(Name = "maskLength", IsRequired = true)]
		public int MaskLength { get; set; }
	}
}
