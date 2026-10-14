using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.SystemInfo
{
	// Token: 0x02000119 RID: 281
	[global::System.Runtime.Serialization.DataContract]
	public class ImageDecodeAcceleratorCapability : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000343 RID: 835
		// (get) Token: 0x060008CC RID: 2252 RVA: 0x0000B82B File Offset: 0x00009A2B
		// (set) Token: 0x060008CD RID: 2253 RVA: 0x0000B847 File Offset: 0x00009A47
		public global::CefSharp.DevTools.SystemInfo.ImageType ImageType
		{
			get
			{
				return (global::CefSharp.DevTools.SystemInfo.ImageType)global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.SystemInfo.ImageType), this.imageType);
			}
			set
			{
				this.imageType = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x17000344 RID: 836
		// (get) Token: 0x060008CE RID: 2254 RVA: 0x0000B85A File Offset: 0x00009A5A
		// (set) Token: 0x060008CF RID: 2255 RVA: 0x0000B862 File Offset: 0x00009A62
		[global::System.Runtime.Serialization.DataMember(Name = "imageType", IsRequired = true)]
		internal string imageType { get; set; }

		// Token: 0x17000345 RID: 837
		// (get) Token: 0x060008D0 RID: 2256 RVA: 0x0000B86B File Offset: 0x00009A6B
		// (set) Token: 0x060008D1 RID: 2257 RVA: 0x0000B873 File Offset: 0x00009A73
		[global::System.Runtime.Serialization.DataMember(Name = "maxDimensions", IsRequired = true)]
		public global::CefSharp.DevTools.SystemInfo.Size MaxDimensions { get; set; }

		// Token: 0x17000346 RID: 838
		// (get) Token: 0x060008D2 RID: 2258 RVA: 0x0000B87C File Offset: 0x00009A7C
		// (set) Token: 0x060008D3 RID: 2259 RVA: 0x0000B884 File Offset: 0x00009A84
		[global::System.Runtime.Serialization.DataMember(Name = "minDimensions", IsRequired = true)]
		public global::CefSharp.DevTools.SystemInfo.Size MinDimensions { get; set; }

		// Token: 0x17000347 RID: 839
		// (get) Token: 0x060008D4 RID: 2260 RVA: 0x0000B88D File Offset: 0x00009A8D
		// (set) Token: 0x060008D5 RID: 2261 RVA: 0x0000B8A9 File Offset: 0x00009AA9
		public global::CefSharp.DevTools.SystemInfo.SubsamplingFormat[] Subsamplings
		{
			get
			{
				return (global::CefSharp.DevTools.SystemInfo.SubsamplingFormat[])global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.SystemInfo.SubsamplingFormat[]), this.subsamplings);
			}
			set
			{
				this.subsamplings = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x17000348 RID: 840
		// (get) Token: 0x060008D6 RID: 2262 RVA: 0x0000B8B7 File Offset: 0x00009AB7
		// (set) Token: 0x060008D7 RID: 2263 RVA: 0x0000B8BF File Offset: 0x00009ABF
		[global::System.Runtime.Serialization.DataMember(Name = "subsamplings", IsRequired = true)]
		internal string subsamplings { get; set; }
	}
}
