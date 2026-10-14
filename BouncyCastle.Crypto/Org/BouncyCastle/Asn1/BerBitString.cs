using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x020005EF RID: 1519
	public class BerBitString : global::Org.BouncyCastle.Asn1.DerBitString
	{
		// Token: 0x060038D3 RID: 14547 RVA: 0x0010AC34 File Offset: 0x00108E34
		internal static byte[] FlattenBitStrings(global::Org.BouncyCastle.Asn1.DerBitString[] bitStrings)
		{
			int count = bitStrings.Length;
			if (count == 0)
			{
				return new byte[1];
			}
			if (count != 1)
			{
				int last = count - 1;
				int totalLength = 0;
				for (int i = 0; i < last; i++)
				{
					byte[] elementContents = bitStrings[i].contents;
					if (elementContents[0] != 0)
					{
						throw new global::System.ArgumentException("only the last nested bitstring can have padding", "bitStrings");
					}
					totalLength += elementContents.Length - 1;
				}
				byte[] lastElementContents = bitStrings[last].contents;
				byte padBits = lastElementContents[0];
				totalLength += lastElementContents.Length;
				byte[] contents = new byte[totalLength];
				contents[0] = padBits;
				int pos = 1;
				for (int j = 0; j < count; j++)
				{
					byte[] contents2 = bitStrings[j].contents;
					int length = contents2.Length - 1;
					global::System.Array.Copy(contents2, 1, contents, pos, length);
					pos += length;
				}
				return contents;
			}
			return bitStrings[0].contents;
		}

		// Token: 0x060038D4 RID: 14548 RVA: 0x0010ACF8 File Offset: 0x00108EF8
		public BerBitString(byte data, int padBits) : base(data, padBits)
		{
			this.elements = null;
			this.segmentLimit = 1000;
		}

		// Token: 0x060038D5 RID: 14549 RVA: 0x0010AD14 File Offset: 0x00108F14
		public BerBitString(byte[] data) : this(data, 0)
		{
		}

		// Token: 0x060038D6 RID: 14550 RVA: 0x0010AD1E File Offset: 0x00108F1E
		public BerBitString(byte[] data, int padBits) : this(data, padBits, 1000)
		{
		}

		// Token: 0x060038D7 RID: 14551 RVA: 0x0010AD2D File Offset: 0x00108F2D
		public BerBitString(byte[] data, int padBits, int segmentLimit) : base(data, padBits)
		{
			this.elements = null;
			this.segmentLimit = segmentLimit;
		}

		// Token: 0x060038D8 RID: 14552 RVA: 0x0010AD45 File Offset: 0x00108F45
		public BerBitString(int namedBits) : base(namedBits)
		{
			this.elements = null;
			this.segmentLimit = 1000;
		}

		// Token: 0x060038D9 RID: 14553 RVA: 0x0010AD60 File Offset: 0x00108F60
		public BerBitString(global::Org.BouncyCastle.Asn1.Asn1Encodable obj) : this(obj.GetDerEncoded(), 0)
		{
		}

		// Token: 0x060038DA RID: 14554 RVA: 0x0010AD6F File Offset: 0x00108F6F
		public BerBitString(global::Org.BouncyCastle.Asn1.DerBitString[] elements) : this(elements, 1000)
		{
		}

		// Token: 0x060038DB RID: 14555 RVA: 0x0010AD7D File Offset: 0x00108F7D
		public BerBitString(global::Org.BouncyCastle.Asn1.DerBitString[] elements, int segmentLimit) : base(global::Org.BouncyCastle.Asn1.BerBitString.FlattenBitStrings(elements), false)
		{
			this.elements = elements;
			this.segmentLimit = segmentLimit;
		}

		// Token: 0x060038DC RID: 14556 RVA: 0x0010AD9A File Offset: 0x00108F9A
		internal BerBitString(byte[] contents, bool check) : base(contents, check)
		{
			this.elements = null;
			this.segmentLimit = 1000;
		}

		// Token: 0x17000799 RID: 1945
		// (get) Token: 0x060038DD RID: 14557 RVA: 0x0010ADB6 File Offset: 0x00108FB6
		private bool IsConstructed
		{
			get
			{
				return this.elements != null || this.contents.Length > this.segmentLimit;
			}
		}

		// Token: 0x060038DE RID: 14558 RVA: 0x0010ADD2 File Offset: 0x00108FD2
		internal override int EncodedLength(bool withID)
		{
			throw global::Org.BouncyCastle.Utilities.Platform.CreateNotImplementedException("BerBitString.EncodedLength");
		}

		// Token: 0x060038DF RID: 14559 RVA: 0x0010ADE0 File Offset: 0x00108FE0
		internal override void Encode(global::Org.BouncyCastle.Asn1.Asn1OutputStream asn1Out, bool withID)
		{
			if (!asn1Out.IsBer)
			{
				base.Encode(asn1Out, withID);
				return;
			}
			if (!this.IsConstructed)
			{
				global::Org.BouncyCastle.Asn1.DerBitString.Encode(asn1Out, withID, this.contents, 0, this.contents.Length);
				return;
			}
			asn1Out.WriteIdentifier(withID, 35);
			asn1Out.WriteByte(128);
			if (this.elements != null)
			{
				global::Org.BouncyCastle.Asn1.Asn1Object[] primitives = this.elements;
				asn1Out.WritePrimitives(primitives);
			}
			else if (this.contents.Length >= 2)
			{
				byte pad = this.contents[0];
				int length = this.contents.Length;
				int remaining = length - 1;
				int segmentLength = this.segmentLimit - 1;
				while (remaining > segmentLength)
				{
					global::Org.BouncyCastle.Asn1.DerBitString.Encode(asn1Out, true, 0, this.contents, length - remaining, segmentLength);
					remaining -= segmentLength;
				}
				global::Org.BouncyCastle.Asn1.DerBitString.Encode(asn1Out, true, pad, this.contents, length - remaining, remaining);
			}
			asn1Out.WriteByte(0);
			asn1Out.WriteByte(0);
		}

		// Token: 0x04001967 RID: 6503
		private const int DefaultSegmentLimit = 1000;

		// Token: 0x04001968 RID: 6504
		private readonly int segmentLimit;

		// Token: 0x04001969 RID: 6505
		private readonly global::Org.BouncyCastle.Asn1.DerBitString[] elements;
	}
}
