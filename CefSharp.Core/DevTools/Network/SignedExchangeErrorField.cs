using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Network
{
	// Token: 0x02000206 RID: 518
	public enum SignedExchangeErrorField
	{
		// Token: 0x040008D3 RID: 2259
		[global::System.Runtime.Serialization.EnumMember(Value = "signatureSig")]
		SignatureSig,
		// Token: 0x040008D4 RID: 2260
		[global::System.Runtime.Serialization.EnumMember(Value = "signatureIntegrity")]
		SignatureIntegrity,
		// Token: 0x040008D5 RID: 2261
		[global::System.Runtime.Serialization.EnumMember(Value = "signatureCertUrl")]
		SignatureCertUrl,
		// Token: 0x040008D6 RID: 2262
		[global::System.Runtime.Serialization.EnumMember(Value = "signatureCertSha256")]
		SignatureCertSha256,
		// Token: 0x040008D7 RID: 2263
		[global::System.Runtime.Serialization.EnumMember(Value = "signatureValidityUrl")]
		SignatureValidityUrl,
		// Token: 0x040008D8 RID: 2264
		[global::System.Runtime.Serialization.EnumMember(Value = "signatureTimestamps")]
		SignatureTimestamps
	}
}
