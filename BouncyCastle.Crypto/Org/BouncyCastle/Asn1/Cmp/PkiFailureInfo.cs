using System;

namespace Org.BouncyCastle.Asn1.Cmp
{
	// Token: 0x0200077F RID: 1919
	public class PkiFailureInfo : global::Org.BouncyCastle.Asn1.DerBitString
	{
		// Token: 0x06004447 RID: 17479 RVA: 0x001307B0 File Offset: 0x0012E9B0
		public PkiFailureInfo(int info) : base(info)
		{
		}

		// Token: 0x06004448 RID: 17480 RVA: 0x001307B9 File Offset: 0x0012E9B9
		public PkiFailureInfo(global::Org.BouncyCastle.Asn1.DerBitString info) : base(info.GetBytes(), info.PadBits)
		{
		}

		// Token: 0x06004449 RID: 17481 RVA: 0x001307D0 File Offset: 0x0012E9D0
		public override string ToString()
		{
			return "PkiFailureInfo: 0x" + this.IntValue.ToString("X");
		}

		// Token: 0x040020F9 RID: 8441
		public const int BadAlg = 128;

		// Token: 0x040020FA RID: 8442
		public const int BadMessageCheck = 64;

		// Token: 0x040020FB RID: 8443
		public const int BadRequest = 32;

		// Token: 0x040020FC RID: 8444
		public const int BadTime = 16;

		// Token: 0x040020FD RID: 8445
		public const int BadCertId = 8;

		// Token: 0x040020FE RID: 8446
		public const int BadDataFormat = 4;

		// Token: 0x040020FF RID: 8447
		public const int WrongAuthority = 2;

		// Token: 0x04002100 RID: 8448
		public const int IncorrectData = 1;

		// Token: 0x04002101 RID: 8449
		public const int MissingTimeStamp = 32768;

		// Token: 0x04002102 RID: 8450
		public const int BadPop = 16384;

		// Token: 0x04002103 RID: 8451
		public const int CertRevoked = 8192;

		// Token: 0x04002104 RID: 8452
		public const int CertConfirmed = 4096;

		// Token: 0x04002105 RID: 8453
		public const int WrongIntegrity = 2048;

		// Token: 0x04002106 RID: 8454
		public const int BadRecipientNonce = 1024;

		// Token: 0x04002107 RID: 8455
		public const int TimeNotAvailable = 512;

		// Token: 0x04002108 RID: 8456
		public const int UnacceptedPolicy = 256;

		// Token: 0x04002109 RID: 8457
		public const int UnacceptedExtension = 8388608;

		// Token: 0x0400210A RID: 8458
		public const int AddInfoNotAvailable = 4194304;

		// Token: 0x0400210B RID: 8459
		public const int BadSenderNonce = 2097152;

		// Token: 0x0400210C RID: 8460
		public const int BadCertTemplate = 1048576;

		// Token: 0x0400210D RID: 8461
		public const int SignerNotTrusted = 524288;

		// Token: 0x0400210E RID: 8462
		public const int TransactionIdInUse = 262144;

		// Token: 0x0400210F RID: 8463
		public const int UnsupportedVersion = 131072;

		// Token: 0x04002110 RID: 8464
		public const int NotAuthorized = 65536;

		// Token: 0x04002111 RID: 8465
		public const int SystemUnavail = -2147483648;

		// Token: 0x04002112 RID: 8466
		public const int SystemFailure = 1073741824;

		// Token: 0x04002113 RID: 8467
		public const int DuplicateCertReq = 536870912;
	}
}
