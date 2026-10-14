using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Browser
{
	// Token: 0x02000333 RID: 819
	[global::System.Runtime.Serialization.DataContract]
	public class PermissionDescriptor : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x170009C0 RID: 2496
		// (get) Token: 0x060018F8 RID: 6392 RVA: 0x0001ADCD File Offset: 0x00018FCD
		// (set) Token: 0x060018F9 RID: 6393 RVA: 0x0001ADD5 File Offset: 0x00018FD5
		[global::System.Runtime.Serialization.DataMember(Name = "name", IsRequired = true)]
		public string Name { get; set; }

		// Token: 0x170009C1 RID: 2497
		// (get) Token: 0x060018FA RID: 6394 RVA: 0x0001ADDE File Offset: 0x00018FDE
		// (set) Token: 0x060018FB RID: 6395 RVA: 0x0001ADE6 File Offset: 0x00018FE6
		[global::System.Runtime.Serialization.DataMember(Name = "sysex", IsRequired = false)]
		public bool? Sysex { get; set; }

		// Token: 0x170009C2 RID: 2498
		// (get) Token: 0x060018FC RID: 6396 RVA: 0x0001ADEF File Offset: 0x00018FEF
		// (set) Token: 0x060018FD RID: 6397 RVA: 0x0001ADF7 File Offset: 0x00018FF7
		[global::System.Runtime.Serialization.DataMember(Name = "userVisibleOnly", IsRequired = false)]
		public bool? UserVisibleOnly { get; set; }

		// Token: 0x170009C3 RID: 2499
		// (get) Token: 0x060018FE RID: 6398 RVA: 0x0001AE00 File Offset: 0x00019000
		// (set) Token: 0x060018FF RID: 6399 RVA: 0x0001AE08 File Offset: 0x00019008
		[global::System.Runtime.Serialization.DataMember(Name = "allowWithoutSanitization", IsRequired = false)]
		public bool? AllowWithoutSanitization { get; set; }

		// Token: 0x170009C4 RID: 2500
		// (get) Token: 0x06001900 RID: 6400 RVA: 0x0001AE11 File Offset: 0x00019011
		// (set) Token: 0x06001901 RID: 6401 RVA: 0x0001AE19 File Offset: 0x00019019
		[global::System.Runtime.Serialization.DataMember(Name = "panTiltZoom", IsRequired = false)]
		public bool? PanTiltZoom { get; set; }
	}
}
