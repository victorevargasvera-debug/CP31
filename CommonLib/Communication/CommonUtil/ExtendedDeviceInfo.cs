using System;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x02000019 RID: 25
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.Common.Communication.CommonUtil.TetraDeviceInfo))]
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.Common.Communication.CommonUtil.PCRDeviceInfo))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.Common.Communication.CommonUtil.PBBDeviceInfo))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.Common.Communication.CommonUtil.AstroDeviceInfo))]
	[global::System.Serializable]
	public abstract class ExtendedDeviceInfo : global::Motorola.Common.Communication.CommonUtil.DeviceInfo
	{
	}
}
