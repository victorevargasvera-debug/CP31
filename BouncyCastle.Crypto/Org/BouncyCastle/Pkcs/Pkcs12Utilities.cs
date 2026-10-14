using System;
using System.IO;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Asn1.X509;

namespace Org.BouncyCastle.Pkcs
{
	// Token: 0x020001B0 RID: 432
	public class Pkcs12Utilities
	{
		// Token: 0x0600106C RID: 4204 RVA: 0x0004291A File Offset: 0x00040B1A
		public static byte[] ConvertToDefiniteLength(byte[] berPkcs12File)
		{
			return global::Org.BouncyCastle.Asn1.Pkcs.Pfx.GetInstance(berPkcs12File).GetEncoded("DER");
		}

		// Token: 0x0600106D RID: 4205 RVA: 0x0004292C File Offset: 0x00040B2C
		public static byte[] ConvertToDefiniteLength(byte[] berPkcs12File, char[] passwd)
		{
			global::Org.BouncyCastle.Asn1.Pkcs.Pfx instance = global::Org.BouncyCastle.Asn1.Pkcs.Pfx.GetInstance(berPkcs12File);
			global::Org.BouncyCastle.Asn1.Pkcs.ContentInfo info = instance.AuthSafe;
			global::Org.BouncyCastle.Asn1.Asn1Object obj = global::Org.BouncyCastle.Asn1.Asn1Object.FromByteArray(global::Org.BouncyCastle.Asn1.Asn1OctetString.GetInstance(info.Content).GetOctets());
			info = new global::Org.BouncyCastle.Asn1.Pkcs.ContentInfo(info.ContentType, new global::Org.BouncyCastle.Asn1.DerOctetString(obj.GetEncoded("DER")));
			global::Org.BouncyCastle.Asn1.Pkcs.MacData mData = instance.MacData;
			try
			{
				int itCount = mData.IterationCount.IntValue;
				byte[] data = global::Org.BouncyCastle.Asn1.Asn1OctetString.GetInstance(info.Content).GetOctets();
				byte[] res = global::Org.BouncyCastle.Pkcs.Pkcs12Store.CalculatePbeMac(mData.Mac.AlgorithmID.Algorithm, mData.GetSalt(), itCount, passwd, false, data);
				mData = new global::Org.BouncyCastle.Asn1.Pkcs.MacData(new global::Org.BouncyCastle.Asn1.X509.DigestInfo(new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(mData.Mac.AlgorithmID.Algorithm, global::Org.BouncyCastle.Asn1.DerNull.Instance), res), mData.GetSalt(), itCount);
			}
			catch (global::System.Exception e)
			{
				throw new global::System.IO.IOException("error constructing MAC: " + e.ToString());
			}
			return new global::Org.BouncyCastle.Asn1.Pkcs.Pfx(info, mData).GetEncoded("DER");
		}
	}
}
