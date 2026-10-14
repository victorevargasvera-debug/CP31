using System;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x02000060 RID: 96
	public enum CodeplugAttributeType : byte
	{
		// Token: 0x040001B8 RID: 440
		None,
		// Token: 0x040001B9 RID: 441
		TotalAllowableMemory,
		// Token: 0x040001BA RID: 442
		CurrentMemoryUsed,
		// Token: 0x040001BB RID: 443
		RegionalInformation,
		// Token: 0x040001BC RID: 444
		OEMManufacturerID,
		// Token: 0x040001BD RID: 445
		RadioSecurityInfomation = 7,
		// Token: 0x040001BE RID: 446
		CertificateSupportedID = 9
	}
}
