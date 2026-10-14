using System;

namespace Org.BouncyCastle.Asn1.X509
{
	// Token: 0x0200065D RID: 1629
	public class KeyUsage : global::Org.BouncyCastle.Asn1.DerBitString
	{
		// Token: 0x06003C41 RID: 15425 RVA: 0x00114378 File Offset: 0x00112578
		public new static global::Org.BouncyCastle.Asn1.X509.KeyUsage GetInstance(object obj)
		{
			if (obj is global::Org.BouncyCastle.Asn1.X509.KeyUsage)
			{
				return (global::Org.BouncyCastle.Asn1.X509.KeyUsage)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.X509.X509Extension)
			{
				return global::Org.BouncyCastle.Asn1.X509.KeyUsage.GetInstance(global::Org.BouncyCastle.Asn1.X509.X509Extension.ConvertValueToObject((global::Org.BouncyCastle.Asn1.X509.X509Extension)obj));
			}
			if (obj == null)
			{
				return null;
			}
			return new global::Org.BouncyCastle.Asn1.X509.KeyUsage(global::Org.BouncyCastle.Asn1.DerBitString.GetInstance(obj));
		}

		// Token: 0x06003C42 RID: 15426 RVA: 0x001143B2 File Offset: 0x001125B2
		public static global::Org.BouncyCastle.Asn1.X509.KeyUsage FromExtensions(global::Org.BouncyCastle.Asn1.X509.X509Extensions extensions)
		{
			return global::Org.BouncyCastle.Asn1.X509.KeyUsage.GetInstance(global::Org.BouncyCastle.Asn1.X509.X509Extensions.GetExtensionParsedValue(extensions, global::Org.BouncyCastle.Asn1.X509.X509Extensions.KeyUsage));
		}

		// Token: 0x06003C43 RID: 15427 RVA: 0x001143C4 File Offset: 0x001125C4
		public KeyUsage(int usage) : base(usage)
		{
		}

		// Token: 0x06003C44 RID: 15428 RVA: 0x001143CD File Offset: 0x001125CD
		private KeyUsage(global::Org.BouncyCastle.Asn1.DerBitString usage) : base(usage.GetBytes(), usage.PadBits)
		{
		}

		// Token: 0x06003C45 RID: 15429 RVA: 0x001143E4 File Offset: 0x001125E4
		public override string ToString()
		{
			byte[] data = this.GetBytes();
			if (data.Length == 1)
			{
				return "KeyUsage: 0x" + ((int)(data[0] & byte.MaxValue)).ToString("X");
			}
			return "KeyUsage: 0x" + ((int)(data[1] & byte.MaxValue) << 8 | (int)(data[0] & byte.MaxValue)).ToString("X");
		}

		// Token: 0x04001A94 RID: 6804
		public const int DigitalSignature = 128;

		// Token: 0x04001A95 RID: 6805
		public const int NonRepudiation = 64;

		// Token: 0x04001A96 RID: 6806
		public const int KeyEncipherment = 32;

		// Token: 0x04001A97 RID: 6807
		public const int DataEncipherment = 16;

		// Token: 0x04001A98 RID: 6808
		public const int KeyAgreement = 8;

		// Token: 0x04001A99 RID: 6809
		public const int KeyCertSign = 4;

		// Token: 0x04001A9A RID: 6810
		public const int CrlSign = 2;

		// Token: 0x04001A9B RID: 6811
		public const int EncipherOnly = 1;

		// Token: 0x04001A9C RID: 6812
		public const int DecipherOnly = 32768;
	}
}
