using System;

namespace CefSharp
{
	// Token: 0x0200002F RID: 47
	[global::System.Flags]
	public enum CertStatus
	{
		// Token: 0x0400018B RID: 395
		None = 0,
		// Token: 0x0400018C RID: 396
		CommonNameInvalid = 1,
		// Token: 0x0400018D RID: 397
		DateInvalid = 2,
		// Token: 0x0400018E RID: 398
		AuthorityInvalid = 4,
		// Token: 0x0400018F RID: 399
		NoRevocation_Mechanism = 16,
		// Token: 0x04000190 RID: 400
		UnableToCheckRevocation = 32,
		// Token: 0x04000191 RID: 401
		Revoked = 64,
		// Token: 0x04000192 RID: 402
		Invalid = 128,
		// Token: 0x04000193 RID: 403
		WeakSignatureAlgorithm = 256,
		// Token: 0x04000194 RID: 404
		NonUniqueName = 1024,
		// Token: 0x04000195 RID: 405
		WeakKey = 2048,
		// Token: 0x04000196 RID: 406
		PinnedKeyMissing = 8192,
		// Token: 0x04000197 RID: 407
		NameConstraintViolation = 16384,
		// Token: 0x04000198 RID: 408
		ValidityTooLong = 32768,
		// Token: 0x04000199 RID: 409
		IsEv = 65536,
		// Token: 0x0400019A RID: 410
		RevCheckingEnabled = 131072,
		// Token: 0x0400019B RID: 411
		Sha1SignaturePresent = 524288,
		// Token: 0x0400019C RID: 412
		CtComplianceFailed = 1048576
	}
}
