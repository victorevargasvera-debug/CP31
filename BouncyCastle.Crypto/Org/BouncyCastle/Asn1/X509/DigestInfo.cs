using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.X509
{
	// Token: 0x0200064F RID: 1615
	public class DigestInfo : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06003BC0 RID: 15296 RVA: 0x001125FB File Offset: 0x001107FB
		public static global::Org.BouncyCastle.Asn1.X509.DigestInfo GetInstance(global::Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool explicitly)
		{
			return global::Org.BouncyCastle.Asn1.X509.DigestInfo.GetInstance(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj, explicitly));
		}

		// Token: 0x06003BC1 RID: 15297 RVA: 0x00112609 File Offset: 0x00110809
		public static global::Org.BouncyCastle.Asn1.X509.DigestInfo GetInstance(object obj)
		{
			if (obj is global::Org.BouncyCastle.Asn1.X509.DigestInfo)
			{
				return (global::Org.BouncyCastle.Asn1.X509.DigestInfo)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.X509.DigestInfo((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("unknown object in factory: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x06003BC2 RID: 15298 RVA: 0x00112648 File Offset: 0x00110848
		public DigestInfo(global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier algID, byte[] digest)
		{
			this.digest = digest;
			this.algID = algID;
		}

		// Token: 0x06003BC3 RID: 15299 RVA: 0x00112660 File Offset: 0x00110860
		private DigestInfo(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			if (seq.Count != 2)
			{
				throw new global::System.ArgumentException("Wrong number of elements in sequence", "seq");
			}
			this.algID = global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier.GetInstance(seq[0]);
			this.digest = global::Org.BouncyCastle.Asn1.Asn1OctetString.GetInstance(seq[1]).GetOctets();
		}

		// Token: 0x170007FE RID: 2046
		// (get) Token: 0x06003BC4 RID: 15300 RVA: 0x001126B5 File Offset: 0x001108B5
		public global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier AlgorithmID
		{
			get
			{
				return this.algID;
			}
		}

		// Token: 0x06003BC5 RID: 15301 RVA: 0x001126BD File Offset: 0x001108BD
		public byte[] GetDigest()
		{
			return this.digest;
		}

		// Token: 0x06003BC6 RID: 15302 RVA: 0x001126C5 File Offset: 0x001108C5
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return new global::Org.BouncyCastle.Asn1.DerSequence(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.algID,
				new global::Org.BouncyCastle.Asn1.DerOctetString(this.digest)
			});
		}

		// Token: 0x04001A4F RID: 6735
		private readonly byte[] digest;

		// Token: 0x04001A50 RID: 6736
		private readonly global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier algID;
	}
}
