using System;

namespace Org.BouncyCastle.Asn1.Misc
{
	// Token: 0x020006DE RID: 1758
	public class IdeaCbcPar : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06004005 RID: 16389 RVA: 0x001226CE File Offset: 0x001208CE
		public static global::Org.BouncyCastle.Asn1.Misc.IdeaCbcPar GetInstance(object o)
		{
			if (o is global::Org.BouncyCastle.Asn1.Misc.IdeaCbcPar)
			{
				return (global::Org.BouncyCastle.Asn1.Misc.IdeaCbcPar)o;
			}
			if (o is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.Misc.IdeaCbcPar((global::Org.BouncyCastle.Asn1.Asn1Sequence)o);
			}
			throw new global::System.ArgumentException("unknown object in IDEACBCPar factory");
		}

		// Token: 0x06004006 RID: 16390 RVA: 0x001226FD File Offset: 0x001208FD
		public IdeaCbcPar(byte[] iv)
		{
			this.iv = new global::Org.BouncyCastle.Asn1.DerOctetString(iv);
		}

		// Token: 0x06004007 RID: 16391 RVA: 0x00122711 File Offset: 0x00120911
		private IdeaCbcPar(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			if (seq.Count == 1)
			{
				this.iv = (global::Org.BouncyCastle.Asn1.Asn1OctetString)seq[0];
			}
		}

		// Token: 0x06004008 RID: 16392 RVA: 0x00122734 File Offset: 0x00120934
		public byte[] GetIV()
		{
			if (this.iv != null)
			{
				return this.iv.GetOctets();
			}
			return null;
		}

		// Token: 0x06004009 RID: 16393 RVA: 0x0012274C File Offset: 0x0012094C
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector v = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector();
			v.AddOptional(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.iv
			});
			return new global::Org.BouncyCastle.Asn1.DerSequence(v);
		}

		// Token: 0x04001E0C RID: 7692
		internal global::Org.BouncyCastle.Asn1.Asn1OctetString iv;
	}
}
