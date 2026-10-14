using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Network
{
	// Token: 0x020001E6 RID: 486
	[global::System.Runtime.Serialization.DataContract]
	public class SignedCertificateTimestamp : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000599 RID: 1433
		// (get) Token: 0x06000EAB RID: 3755 RVA: 0x00010DF1 File Offset: 0x0000EFF1
		// (set) Token: 0x06000EAC RID: 3756 RVA: 0x00010DF9 File Offset: 0x0000EFF9
		[global::System.Runtime.Serialization.DataMember(Name = "status", IsRequired = true)]
		public string Status { get; set; }

		// Token: 0x1700059A RID: 1434
		// (get) Token: 0x06000EAD RID: 3757 RVA: 0x00010E02 File Offset: 0x0000F002
		// (set) Token: 0x06000EAE RID: 3758 RVA: 0x00010E0A File Offset: 0x0000F00A
		[global::System.Runtime.Serialization.DataMember(Name = "origin", IsRequired = true)]
		public string Origin { get; set; }

		// Token: 0x1700059B RID: 1435
		// (get) Token: 0x06000EAF RID: 3759 RVA: 0x00010E13 File Offset: 0x0000F013
		// (set) Token: 0x06000EB0 RID: 3760 RVA: 0x00010E1B File Offset: 0x0000F01B
		[global::System.Runtime.Serialization.DataMember(Name = "logDescription", IsRequired = true)]
		public string LogDescription { get; set; }

		// Token: 0x1700059C RID: 1436
		// (get) Token: 0x06000EB1 RID: 3761 RVA: 0x00010E24 File Offset: 0x0000F024
		// (set) Token: 0x06000EB2 RID: 3762 RVA: 0x00010E2C File Offset: 0x0000F02C
		[global::System.Runtime.Serialization.DataMember(Name = "logId", IsRequired = true)]
		public string LogId { get; set; }

		// Token: 0x1700059D RID: 1437
		// (get) Token: 0x06000EB3 RID: 3763 RVA: 0x00010E35 File Offset: 0x0000F035
		// (set) Token: 0x06000EB4 RID: 3764 RVA: 0x00010E3D File Offset: 0x0000F03D
		[global::System.Runtime.Serialization.DataMember(Name = "timestamp", IsRequired = true)]
		public double Timestamp { get; set; }

		// Token: 0x1700059E RID: 1438
		// (get) Token: 0x06000EB5 RID: 3765 RVA: 0x00010E46 File Offset: 0x0000F046
		// (set) Token: 0x06000EB6 RID: 3766 RVA: 0x00010E4E File Offset: 0x0000F04E
		[global::System.Runtime.Serialization.DataMember(Name = "hashAlgorithm", IsRequired = true)]
		public string HashAlgorithm { get; set; }

		// Token: 0x1700059F RID: 1439
		// (get) Token: 0x06000EB7 RID: 3767 RVA: 0x00010E57 File Offset: 0x0000F057
		// (set) Token: 0x06000EB8 RID: 3768 RVA: 0x00010E5F File Offset: 0x0000F05F
		[global::System.Runtime.Serialization.DataMember(Name = "signatureAlgorithm", IsRequired = true)]
		public string SignatureAlgorithm { get; set; }

		// Token: 0x170005A0 RID: 1440
		// (get) Token: 0x06000EB9 RID: 3769 RVA: 0x00010E68 File Offset: 0x0000F068
		// (set) Token: 0x06000EBA RID: 3770 RVA: 0x00010E70 File Offset: 0x0000F070
		[global::System.Runtime.Serialization.DataMember(Name = "signatureData", IsRequired = true)]
		public string SignatureData { get; set; }
	}
}
