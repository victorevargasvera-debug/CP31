using System;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication.Pba
{
	// Token: 0x02000039 RID: 57
	[global::System.Runtime.Serialization.DataContract]
	public enum SpecialValidationMethod
	{
		// Token: 0x0400014B RID: 331
		[global::System.Runtime.Serialization.EnumMember]
		PCRCodeplugPassword,
		// Token: 0x0400014C RID: 332
		[global::System.Runtime.Serialization.EnumMember]
		PCRFlashSize,
		// Token: 0x0400014D RID: 333
		[global::System.Runtime.Serialization.EnumMember]
		PCRDigitalFw,
		// Token: 0x0400014E RID: 334
		[global::System.Runtime.Serialization.EnumMember]
		PCRDigitalPhonePatch
	}
}
