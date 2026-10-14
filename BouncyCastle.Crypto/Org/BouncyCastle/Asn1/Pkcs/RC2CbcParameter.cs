using System;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Pkcs
{
	// Token: 0x020006BC RID: 1724
	public class RC2CbcParameter : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06003F0B RID: 16139 RVA: 0x0011F29C File Offset: 0x0011D49C
		public static global::Org.BouncyCastle.Asn1.Pkcs.RC2CbcParameter GetInstance(object obj)
		{
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.Pkcs.RC2CbcParameter((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("Unknown object in factory: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x06003F0C RID: 16140 RVA: 0x0011F2CC File Offset: 0x0011D4CC
		public RC2CbcParameter(byte[] iv)
		{
			this.iv = new global::Org.BouncyCastle.Asn1.DerOctetString(iv);
		}

		// Token: 0x06003F0D RID: 16141 RVA: 0x0011F2E0 File Offset: 0x0011D4E0
		public RC2CbcParameter(int parameterVersion, byte[] iv)
		{
			this.version = new global::Org.BouncyCastle.Asn1.DerInteger(parameterVersion);
			this.iv = new global::Org.BouncyCastle.Asn1.DerOctetString(iv);
		}

		// Token: 0x06003F0E RID: 16142 RVA: 0x0011F300 File Offset: 0x0011D500
		private RC2CbcParameter(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			if (seq.Count == 1)
			{
				this.iv = (global::Org.BouncyCastle.Asn1.Asn1OctetString)seq[0];
				return;
			}
			this.version = (global::Org.BouncyCastle.Asn1.DerInteger)seq[0];
			this.iv = (global::Org.BouncyCastle.Asn1.Asn1OctetString)seq[1];
		}

		// Token: 0x170008C1 RID: 2241
		// (get) Token: 0x06003F0F RID: 16143 RVA: 0x0011F353 File Offset: 0x0011D553
		public global::Org.BouncyCastle.Math.BigInteger RC2ParameterVersion
		{
			get
			{
				if (this.version != null)
				{
					return this.version.Value;
				}
				return null;
			}
		}

		// Token: 0x06003F10 RID: 16144 RVA: 0x0011F36A File Offset: 0x0011D56A
		public byte[] GetIV()
		{
			return global::Org.BouncyCastle.Utilities.Arrays.Clone(this.iv.GetOctets());
		}

		// Token: 0x06003F11 RID: 16145 RVA: 0x0011F37C File Offset: 0x0011D57C
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector v = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector();
			v.AddOptional(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.version
			});
			v.Add(this.iv);
			return new global::Org.BouncyCastle.Asn1.DerSequence(v);
		}

		// Token: 0x04001D1F RID: 7455
		internal global::Org.BouncyCastle.Asn1.DerInteger version;

		// Token: 0x04001D20 RID: 7456
		internal global::Org.BouncyCastle.Asn1.Asn1OctetString iv;
	}
}
