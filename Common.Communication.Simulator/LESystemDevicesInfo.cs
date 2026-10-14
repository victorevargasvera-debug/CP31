using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Motorola.Common.Communication.CommonUtil;

namespace Common.Communication.Simulator
{
	// Token: 0x0200000B RID: 11
	[global::System.Serializable]
	public class LESystemDevicesInfo
	{
		// Token: 0x0600007B RID: 123 RVA: 0x000092BC File Offset: 0x000074BC
		public LESystemDevicesInfo()
		{
			this.LESystem = new global::Motorola.Common.Communication.CommonUtil.PCRIPSystemInfo();
			this.DeviceIdList = new global::System.Collections.Generic.List<string>();
		}

		// Token: 0x0400001B RID: 27
		[global::System.Xml.Serialization.XmlAttribute("LE System")]
		public global::Motorola.Common.Communication.CommonUtil.PCRIPSystemInfo LESystem;

		// Token: 0x0400001C RID: 28
		[global::System.Xml.Serialization.XmlAttribute("Device ID List")]
		public global::System.Collections.Generic.List<string> DeviceIdList;
	}
}
