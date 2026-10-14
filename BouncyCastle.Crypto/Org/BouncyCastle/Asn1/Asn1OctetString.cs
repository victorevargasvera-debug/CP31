using System;
using System.IO;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Encoders;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x020005E1 RID: 1505
	public abstract class Asn1OctetString : global::Org.BouncyCastle.Asn1.Asn1Object, global::Org.BouncyCastle.Asn1.Asn1OctetStringParser, global::Org.BouncyCastle.Asn1.IAsn1Convertible
	{
		// Token: 0x06003870 RID: 14448 RVA: 0x00109AF4 File Offset: 0x00107CF4
		public static global::Org.BouncyCastle.Asn1.Asn1OctetString GetInstance(global::Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool isExplicit)
		{
			global::Org.BouncyCastle.Asn1.Asn1Object o = obj.GetObject();
			if (isExplicit || o is global::Org.BouncyCastle.Asn1.Asn1OctetString)
			{
				return global::Org.BouncyCastle.Asn1.Asn1OctetString.GetInstance(o);
			}
			return global::Org.BouncyCastle.Asn1.BerOctetString.FromSequence(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(o));
		}

		// Token: 0x06003871 RID: 14449 RVA: 0x00109B28 File Offset: 0x00107D28
		public static global::Org.BouncyCastle.Asn1.Asn1OctetString GetInstance(object obj)
		{
			if (obj == null || obj is global::Org.BouncyCastle.Asn1.Asn1OctetString)
			{
				return (global::Org.BouncyCastle.Asn1.Asn1OctetString)obj;
			}
			if (obj is byte[])
			{
				try
				{
					return global::Org.BouncyCastle.Asn1.Asn1OctetString.GetInstance(global::Org.BouncyCastle.Asn1.Asn1Object.FromByteArray((byte[])obj));
				}
				catch (global::System.IO.IOException e)
				{
					throw new global::System.ArgumentException("failed to construct OCTET STRING from byte[]: " + e.Message);
				}
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1TaggedObject)
			{
				return global::Org.BouncyCastle.Asn1.Asn1OctetString.GetInstance(((global::Org.BouncyCastle.Asn1.Asn1TaggedObject)obj).GetObject());
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Encodable)
			{
				global::Org.BouncyCastle.Asn1.Asn1Object primitive = ((global::Org.BouncyCastle.Asn1.Asn1Encodable)obj).ToAsn1Object();
				if (primitive is global::Org.BouncyCastle.Asn1.Asn1OctetString)
				{
					return (global::Org.BouncyCastle.Asn1.Asn1OctetString)primitive;
				}
			}
			throw new global::System.ArgumentException("illegal object in GetInstance: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj));
		}

		// Token: 0x06003872 RID: 14450 RVA: 0x00109BDC File Offset: 0x00107DDC
		internal Asn1OctetString(byte[] str)
		{
			if (str == null)
			{
				throw new global::System.ArgumentNullException("str");
			}
			this.str = str;
		}

		// Token: 0x06003873 RID: 14451 RVA: 0x00109BF9 File Offset: 0x00107DF9
		public global::System.IO.Stream GetOctetStream()
		{
			return new global::System.IO.MemoryStream(this.str, false);
		}

		// Token: 0x1700078F RID: 1935
		// (get) Token: 0x06003874 RID: 14452 RVA: 0x00109C07 File Offset: 0x00107E07
		public global::Org.BouncyCastle.Asn1.Asn1OctetStringParser Parser
		{
			get
			{
				return this;
			}
		}

		// Token: 0x06003875 RID: 14453 RVA: 0x00109C0A File Offset: 0x00107E0A
		public virtual byte[] GetOctets()
		{
			return this.str;
		}

		// Token: 0x06003876 RID: 14454 RVA: 0x00109C12 File Offset: 0x00107E12
		protected override int Asn1GetHashCode()
		{
			return global::Org.BouncyCastle.Utilities.Arrays.GetHashCode(this.GetOctets());
		}

		// Token: 0x06003877 RID: 14455 RVA: 0x00109C20 File Offset: 0x00107E20
		protected override bool Asn1Equals(global::Org.BouncyCastle.Asn1.Asn1Object asn1Object)
		{
			global::Org.BouncyCastle.Asn1.DerOctetString other = asn1Object as global::Org.BouncyCastle.Asn1.DerOctetString;
			return other != null && global::Org.BouncyCastle.Utilities.Arrays.AreEqual(this.GetOctets(), other.GetOctets());
		}

		// Token: 0x06003878 RID: 14456 RVA: 0x00109C4A File Offset: 0x00107E4A
		public override string ToString()
		{
			return "#" + global::Org.BouncyCastle.Utilities.Encoders.Hex.ToHexString(this.str);
		}

		// Token: 0x04001937 RID: 6455
		internal static readonly byte[] EmptyOctets = new byte[0];

		// Token: 0x04001938 RID: 6456
		internal byte[] str;
	}
}
