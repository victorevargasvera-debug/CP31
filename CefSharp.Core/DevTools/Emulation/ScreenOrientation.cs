using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Emulation
{
	// Token: 0x02000284 RID: 644
	[global::System.Runtime.Serialization.DataContract]
	public class ScreenOrientation : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000792 RID: 1938
		// (get) Token: 0x0600138D RID: 5005 RVA: 0x00015AA2 File Offset: 0x00013CA2
		// (set) Token: 0x0600138E RID: 5006 RVA: 0x00015ABE File Offset: 0x00013CBE
		public global::CefSharp.DevTools.Emulation.ScreenOrientationType Type
		{
			get
			{
				return (global::CefSharp.DevTools.Emulation.ScreenOrientationType)global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.Emulation.ScreenOrientationType), this.type);
			}
			set
			{
				this.type = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x17000793 RID: 1939
		// (get) Token: 0x0600138F RID: 5007 RVA: 0x00015AD1 File Offset: 0x00013CD1
		// (set) Token: 0x06001390 RID: 5008 RVA: 0x00015AD9 File Offset: 0x00013CD9
		[global::System.Runtime.Serialization.DataMember(Name = "type", IsRequired = true)]
		internal string type { get; set; }

		// Token: 0x17000794 RID: 1940
		// (get) Token: 0x06001391 RID: 5009 RVA: 0x00015AE2 File Offset: 0x00013CE2
		// (set) Token: 0x06001392 RID: 5010 RVA: 0x00015AEA File Offset: 0x00013CEA
		[global::System.Runtime.Serialization.DataMember(Name = "angle", IsRequired = true)]
		public int Angle { get; set; }
	}
}
