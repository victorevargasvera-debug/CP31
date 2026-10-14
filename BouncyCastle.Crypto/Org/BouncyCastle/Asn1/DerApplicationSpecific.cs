using System;
using System.IO;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x02000600 RID: 1536
	public class DerApplicationSpecific : global::Org.BouncyCastle.Asn1.Asn1Object
	{
		// Token: 0x06003939 RID: 14649 RVA: 0x0010BB27 File Offset: 0x00109D27
		internal DerApplicationSpecific(bool isConstructed, int tag, byte[] octets)
		{
			this.isConstructed = isConstructed;
			this.tag = tag;
			this.octets = octets;
		}

		// Token: 0x0600393A RID: 14650 RVA: 0x0010BB44 File Offset: 0x00109D44
		public DerApplicationSpecific(int tag, byte[] octets) : this(false, tag, octets)
		{
		}

		// Token: 0x0600393B RID: 14651 RVA: 0x0010BB4F File Offset: 0x00109D4F
		public DerApplicationSpecific(int tag, global::Org.BouncyCastle.Asn1.Asn1Encodable obj) : this(true, tag, obj)
		{
		}

		// Token: 0x0600393C RID: 14652 RVA: 0x0010BB5C File Offset: 0x00109D5C
		public DerApplicationSpecific(bool isExplicit, int tag, global::Org.BouncyCastle.Asn1.Asn1Encodable obj)
		{
			global::Org.BouncyCastle.Asn1.Asn1Object asn1Obj = obj.ToAsn1Object();
			byte[] data = asn1Obj.GetDerEncoded();
			this.isConstructed = global::Org.BouncyCastle.Asn1.Asn1TaggedObject.IsConstructed(isExplicit, asn1Obj);
			this.tag = tag;
			if (isExplicit)
			{
				this.octets = data;
				return;
			}
			int lenBytes = this.GetLengthOfHeader(data);
			byte[] tmp = new byte[data.Length - lenBytes];
			global::System.Array.Copy(data, lenBytes, tmp, 0, tmp.Length);
			this.octets = tmp;
		}

		// Token: 0x0600393D RID: 14653 RVA: 0x0010BBC4 File Offset: 0x00109DC4
		public DerApplicationSpecific(int tagNo, global::Org.BouncyCastle.Asn1.Asn1EncodableVector vec)
		{
			this.tag = tagNo;
			this.isConstructed = true;
			global::System.IO.MemoryStream bOut = new global::System.IO.MemoryStream();
			for (int i = 0; i != vec.Count; i++)
			{
				try
				{
					byte[] bs = vec[i].GetDerEncoded();
					bOut.Write(bs, 0, bs.Length);
				}
				catch (global::System.IO.IOException e)
				{
					throw new global::System.InvalidOperationException("malformed object", e);
				}
			}
			this.octets = bOut.ToArray();
		}

		// Token: 0x0600393E RID: 14654 RVA: 0x0010BC40 File Offset: 0x00109E40
		private int GetLengthOfHeader(byte[] data)
		{
			int length = (int)data[1];
			if (length == 128)
			{
				return 2;
			}
			if (length <= 127)
			{
				return 2;
			}
			int size = length & 127;
			if (size > 4)
			{
				throw new global::System.InvalidOperationException("DER length more than 4 bytes: " + size.ToString());
			}
			return size + 2;
		}

		// Token: 0x0600393F RID: 14655 RVA: 0x0010BC85 File Offset: 0x00109E85
		public bool IsConstructed()
		{
			return this.isConstructed;
		}

		// Token: 0x06003940 RID: 14656 RVA: 0x0010BC8D File Offset: 0x00109E8D
		public byte[] GetContents()
		{
			return this.octets;
		}

		// Token: 0x1700079E RID: 1950
		// (get) Token: 0x06003941 RID: 14657 RVA: 0x0010BC95 File Offset: 0x00109E95
		public int ApplicationTag
		{
			get
			{
				return this.tag;
			}
		}

		// Token: 0x06003942 RID: 14658 RVA: 0x0010BC9D File Offset: 0x00109E9D
		public global::Org.BouncyCastle.Asn1.Asn1Object GetObject()
		{
			return global::Org.BouncyCastle.Asn1.Asn1Object.FromByteArray(this.GetContents());
		}

		// Token: 0x06003943 RID: 14659 RVA: 0x0010BCAC File Offset: 0x00109EAC
		public global::Org.BouncyCastle.Asn1.Asn1Object GetObject(int derTagNo)
		{
			if (derTagNo >= 31)
			{
				throw new global::System.IO.IOException("unsupported tag number");
			}
			byte[] orig = base.GetEncoded();
			byte[] tmp = this.ReplaceTagNumber(derTagNo, orig);
			if ((orig[0] & 32) != 0)
			{
				byte[] array = tmp;
				int num = 0;
				array[num] |= 32;
			}
			return global::Org.BouncyCastle.Asn1.Asn1Object.FromByteArray(tmp);
		}

		// Token: 0x06003944 RID: 14660 RVA: 0x0010BCF5 File Offset: 0x00109EF5
		internal override int EncodedLength(bool withID)
		{
			return global::Org.BouncyCastle.Asn1.Asn1OutputStream.GetLengthOfEncodingDL(withID, this.tag, this.octets.Length);
		}

		// Token: 0x06003945 RID: 14661 RVA: 0x0010BD0C File Offset: 0x00109F0C
		internal override void Encode(global::Org.BouncyCastle.Asn1.Asn1OutputStream asn1Out, bool withID)
		{
			int flags = 64;
			if (this.isConstructed)
			{
				flags |= 32;
			}
			asn1Out.WriteEncodingDL(withID, flags, this.tag, this.octets);
		}

		// Token: 0x06003946 RID: 14662 RVA: 0x0010BD40 File Offset: 0x00109F40
		protected override bool Asn1Equals(global::Org.BouncyCastle.Asn1.Asn1Object asn1Object)
		{
			global::Org.BouncyCastle.Asn1.DerApplicationSpecific other = asn1Object as global::Org.BouncyCastle.Asn1.DerApplicationSpecific;
			return other != null && (this.isConstructed == other.isConstructed && this.tag == other.tag) && global::Org.BouncyCastle.Utilities.Arrays.AreEqual(this.octets, other.octets);
		}

		// Token: 0x06003947 RID: 14663 RVA: 0x0010BD88 File Offset: 0x00109F88
		protected override int Asn1GetHashCode()
		{
			return this.isConstructed.GetHashCode() ^ this.tag.GetHashCode() ^ global::Org.BouncyCastle.Utilities.Arrays.GetHashCode(this.octets);
		}

		// Token: 0x06003948 RID: 14664 RVA: 0x0010BDC0 File Offset: 0x00109FC0
		private byte[] ReplaceTagNumber(int newTag, byte[] input)
		{
			int num = (int)(input[0] & 31);
			int index = 1;
			if (num == 31)
			{
				int b = (int)input[index++];
				if ((b & 127) == 0)
				{
					throw new global::System.IO.IOException("corrupted stream - invalid high tag number found");
				}
				while ((b & 128) != 0)
				{
					b = (int)input[index++];
				}
			}
			int remaining = input.Length - index;
			byte[] tmp = new byte[1 + remaining];
			tmp[0] = (byte)newTag;
			global::System.Array.Copy(input, index, tmp, 1, remaining);
			return tmp;
		}

		// Token: 0x0400197F RID: 6527
		private readonly bool isConstructed;

		// Token: 0x04001980 RID: 6528
		private readonly int tag;

		// Token: 0x04001981 RID: 6529
		private readonly byte[] octets;
	}
}
