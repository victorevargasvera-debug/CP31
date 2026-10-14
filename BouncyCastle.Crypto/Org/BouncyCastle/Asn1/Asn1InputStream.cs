using System;
using System.IO;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x020005DE RID: 1502
	public class Asn1InputStream : global::Org.BouncyCastle.Utilities.IO.FilterStream
	{
		// Token: 0x0600384F RID: 14415 RVA: 0x0010922C File Offset: 0x0010742C
		internal static int FindLimit(global::System.IO.Stream input)
		{
			if (input is global::Org.BouncyCastle.Asn1.LimitedInputStream)
			{
				return ((global::Org.BouncyCastle.Asn1.LimitedInputStream)input).Limit;
			}
			if (input is global::Org.BouncyCastle.Asn1.Asn1InputStream)
			{
				return ((global::Org.BouncyCastle.Asn1.Asn1InputStream)input).Limit;
			}
			if (input is global::System.IO.MemoryStream)
			{
				global::System.IO.MemoryStream mem = (global::System.IO.MemoryStream)input;
				return (int)(mem.Length - mem.Position);
			}
			return int.MaxValue;
		}

		// Token: 0x06003850 RID: 14416 RVA: 0x00109284 File Offset: 0x00107484
		public Asn1InputStream(global::System.IO.Stream input) : this(input, global::Org.BouncyCastle.Asn1.Asn1InputStream.FindLimit(input))
		{
		}

		// Token: 0x06003851 RID: 14417 RVA: 0x00109293 File Offset: 0x00107493
		public Asn1InputStream(byte[] input) : this(new global::System.IO.MemoryStream(input, false), input.Length)
		{
		}

		// Token: 0x06003852 RID: 14418 RVA: 0x001092A5 File Offset: 0x001074A5
		public Asn1InputStream(global::System.IO.Stream input, int limit) : this(input, limit, new byte[16][])
		{
		}

		// Token: 0x06003853 RID: 14419 RVA: 0x001092B6 File Offset: 0x001074B6
		internal Asn1InputStream(global::System.IO.Stream input, int limit, byte[][] tmpBuffers) : base(input)
		{
			this.limit = limit;
			this.tmpBuffers = tmpBuffers;
		}

		// Token: 0x06003854 RID: 14420 RVA: 0x001092D0 File Offset: 0x001074D0
		private global::Org.BouncyCastle.Asn1.Asn1Object BuildObject(int tag, int tagNo, int length)
		{
			bool isConstructed = (tag & 32) != 0;
			global::Org.BouncyCastle.Asn1.DefiniteLengthInputStream defIn = new global::Org.BouncyCastle.Asn1.DefiniteLengthInputStream(this, length, this.limit);
			int tagClass = tag & 192;
			if (tagClass != 0)
			{
				if ((tag & 64) != 0)
				{
					return new global::Org.BouncyCastle.Asn1.DerApplicationSpecific(isConstructed, tagNo, defIn.ToArray());
				}
				return new global::Org.BouncyCastle.Asn1.Asn1StreamParser(defIn, defIn.Remaining, this.tmpBuffers).ReadTaggedObject(isConstructed, tagNo);
			}
			else
			{
				if (!isConstructed)
				{
					return global::Org.BouncyCastle.Asn1.Asn1InputStream.CreatePrimitiveDerObject(tagNo, defIn, this.tmpBuffers);
				}
				if (tagNo <= 4)
				{
					if (tagNo == 3)
					{
						return this.BuildConstructedBitString(this.ReadVector(defIn));
					}
					if (tagNo == 4)
					{
						return this.BuildConstructedOctetString(this.ReadVector(defIn));
					}
				}
				else
				{
					if (tagNo == 8)
					{
						return new global::Org.BouncyCastle.Asn1.DerExternal(this.ReadVector(defIn));
					}
					if (tagNo == 16)
					{
						return this.CreateDerSequence(defIn);
					}
					if (tagNo == 17)
					{
						return this.CreateDerSet(defIn);
					}
				}
				throw new global::System.IO.IOException("unknown tag " + tagNo.ToString() + " encountered");
			}
		}

		// Token: 0x06003855 RID: 14421 RVA: 0x001093B0 File Offset: 0x001075B0
		internal virtual global::Org.BouncyCastle.Asn1.Asn1EncodableVector ReadVector()
		{
			global::Org.BouncyCastle.Asn1.Asn1Object o = this.ReadObject();
			if (o == null)
			{
				return new global::Org.BouncyCastle.Asn1.Asn1EncodableVector(0);
			}
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector v = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector();
			do
			{
				v.Add(o);
			}
			while ((o = this.ReadObject()) != null);
			return v;
		}

		// Token: 0x06003856 RID: 14422 RVA: 0x001093E8 File Offset: 0x001075E8
		internal virtual global::Org.BouncyCastle.Asn1.Asn1EncodableVector ReadVector(global::Org.BouncyCastle.Asn1.DefiniteLengthInputStream defIn)
		{
			int remaining = defIn.Remaining;
			if (remaining < 1)
			{
				return new global::Org.BouncyCastle.Asn1.Asn1EncodableVector(0);
			}
			return new global::Org.BouncyCastle.Asn1.Asn1InputStream(defIn, remaining, this.tmpBuffers).ReadVector();
		}

		// Token: 0x06003857 RID: 14423 RVA: 0x00109419 File Offset: 0x00107619
		internal virtual global::Org.BouncyCastle.Asn1.DerSequence CreateDerSequence(global::Org.BouncyCastle.Asn1.DefiniteLengthInputStream dIn)
		{
			return global::Org.BouncyCastle.Asn1.DerSequence.FromVector(this.ReadVector(dIn));
		}

		// Token: 0x06003858 RID: 14424 RVA: 0x00109427 File Offset: 0x00107627
		internal virtual global::Org.BouncyCastle.Asn1.DerSet CreateDerSet(global::Org.BouncyCastle.Asn1.DefiniteLengthInputStream dIn)
		{
			return global::Org.BouncyCastle.Asn1.DerSet.FromVector(this.ReadVector(dIn), false);
		}

		// Token: 0x06003859 RID: 14425 RVA: 0x00109438 File Offset: 0x00107638
		public global::Org.BouncyCastle.Asn1.Asn1Object ReadObject()
		{
			int tag = this.ReadByte();
			if (tag <= 0)
			{
				if (tag == 0)
				{
					throw new global::System.IO.IOException("unexpected end-of-contents marker");
				}
				return null;
			}
			else
			{
				int tagNo = global::Org.BouncyCastle.Asn1.Asn1InputStream.ReadTagNumber(this, tag);
				int length = global::Org.BouncyCastle.Asn1.Asn1InputStream.ReadLength(this, this.limit, false);
				if (length >= 0)
				{
					try
					{
						return this.BuildObject(tag, tagNo, length);
					}
					catch (global::System.ArgumentException e)
					{
						throw new global::Org.BouncyCastle.Asn1.Asn1Exception("corrupted stream detected", e);
					}
				}
				if ((tag & 32) == 0)
				{
					throw new global::System.IO.IOException("indefinite-length primitive encoding encountered");
				}
				global::Org.BouncyCastle.Asn1.Asn1StreamParser sp = new global::Org.BouncyCastle.Asn1.Asn1StreamParser(new global::Org.BouncyCastle.Asn1.IndefiniteLengthInputStream(this, this.limit), this.limit, this.tmpBuffers);
				int tagClass = tag & 192;
				if (tagClass == 0)
				{
					if (tagNo <= 8)
					{
						if (tagNo == 4)
						{
							return global::Org.BouncyCastle.Asn1.BerOctetStringParser.Parse(sp);
						}
						if (tagNo == 8)
						{
							return global::Org.BouncyCastle.Asn1.DerExternalParser.Parse(sp);
						}
					}
					else
					{
						if (tagNo == 16)
						{
							return global::Org.BouncyCastle.Asn1.BerSequenceParser.Parse(sp);
						}
						if (tagNo == 17)
						{
							return global::Org.BouncyCastle.Asn1.BerSetParser.Parse(sp);
						}
					}
					throw new global::System.IO.IOException("unknown BER object encountered");
				}
				if ((tag & 64) != 0)
				{
					return new global::Org.BouncyCastle.Asn1.BerApplicationSpecificParser(tagNo, sp).ToAsn1Object();
				}
				return new global::Org.BouncyCastle.Asn1.BerTaggedObjectParser(true, tagNo, sp).ToAsn1Object();
			}
		}

		// Token: 0x0600385A RID: 14426 RVA: 0x0010954C File Offset: 0x0010774C
		internal virtual global::Org.BouncyCastle.Asn1.DerBitString BuildConstructedBitString(global::Org.BouncyCastle.Asn1.Asn1EncodableVector contentsElements)
		{
			global::Org.BouncyCastle.Asn1.DerBitString[] bitStrings = new global::Org.BouncyCastle.Asn1.DerBitString[contentsElements.Count];
			for (int i = 0; i != bitStrings.Length; i++)
			{
				global::Org.BouncyCastle.Asn1.DerBitString bitString = contentsElements[i] as global::Org.BouncyCastle.Asn1.DerBitString;
				if (bitString == null)
				{
					throw new global::Org.BouncyCastle.Asn1.Asn1Exception("unknown object encountered in constructed BIT STRING: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(contentsElements[i]));
				}
				bitStrings[i] = bitString;
			}
			return new global::Org.BouncyCastle.Asn1.BerBitString(bitStrings);
		}

		// Token: 0x0600385B RID: 14427 RVA: 0x001095AC File Offset: 0x001077AC
		internal virtual global::Org.BouncyCastle.Asn1.Asn1OctetString BuildConstructedOctetString(global::Org.BouncyCastle.Asn1.Asn1EncodableVector contentsElements)
		{
			global::Org.BouncyCastle.Asn1.Asn1OctetString[] octetStrings = new global::Org.BouncyCastle.Asn1.Asn1OctetString[contentsElements.Count];
			for (int i = 0; i != octetStrings.Length; i++)
			{
				global::Org.BouncyCastle.Asn1.Asn1OctetString octetString = contentsElements[i] as global::Org.BouncyCastle.Asn1.Asn1OctetString;
				if (octetString == null)
				{
					throw new global::Org.BouncyCastle.Asn1.Asn1Exception("unknown object encountered in constructed OCTET STRING: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(contentsElements[i]));
				}
				octetStrings[i] = octetString;
			}
			return new global::Org.BouncyCastle.Asn1.BerOctetString(octetStrings);
		}

		// Token: 0x1700078E RID: 1934
		// (get) Token: 0x0600385C RID: 14428 RVA: 0x00109609 File Offset: 0x00107809
		internal virtual int Limit
		{
			get
			{
				return this.limit;
			}
		}

		// Token: 0x0600385D RID: 14429 RVA: 0x00109614 File Offset: 0x00107814
		internal static int ReadTagNumber(global::System.IO.Stream s, int tag)
		{
			int tagNo = tag & 31;
			if (tagNo == 31)
			{
				tagNo = 0;
				int b = s.ReadByte();
				if (b < 31)
				{
					if (b < 0)
					{
						throw new global::System.IO.EndOfStreamException("EOF found inside tag value.");
					}
					throw new global::System.IO.IOException("corrupted stream - high tag number < 31 found");
				}
				else
				{
					if ((b & 127) == 0)
					{
						throw new global::System.IO.IOException("corrupted stream - invalid high tag number found");
					}
					while ((b & 128) != 0)
					{
						if ((uint)tagNo >> 24 != 0U)
						{
							throw new global::System.IO.IOException("Tag number more than 31 bits");
						}
						tagNo |= (b & 127);
						tagNo <<= 7;
						b = s.ReadByte();
						if (b < 0)
						{
							throw new global::System.IO.EndOfStreamException("EOF found inside tag value.");
						}
					}
					tagNo |= (b & 127);
				}
			}
			return tagNo;
		}

		// Token: 0x0600385E RID: 14430 RVA: 0x001096A8 File Offset: 0x001078A8
		internal static int ReadLength(global::System.IO.Stream s, int limit, bool isParsing)
		{
			int length = s.ReadByte();
			if ((uint)length >> 7 == 0U)
			{
				return length;
			}
			if (128 == length)
			{
				return -1;
			}
			if (length < 0)
			{
				throw new global::System.IO.EndOfStreamException("EOF found when length expected");
			}
			if (255 == length)
			{
				throw new global::System.IO.IOException("invalid long form definite-length 0xFF");
			}
			int octetsCount = length & 127;
			int octetsPos = 0;
			length = 0;
			for (;;)
			{
				int octet = s.ReadByte();
				if (octet < 0)
				{
					break;
				}
				if ((uint)length >> 23 != 0U)
				{
					goto Block_6;
				}
				length = (length << 8) + octet;
				if (++octetsPos >= octetsCount)
				{
					goto Block_7;
				}
			}
			throw new global::System.IO.EndOfStreamException("EOF found reading length");
			Block_6:
			throw new global::System.IO.IOException("long form definite-length more than 31 bits");
			Block_7:
			if (length >= limit && !isParsing)
			{
				throw new global::System.IO.IOException("corrupted stream - out of bounds length found: " + length.ToString() + " >= " + limit.ToString());
			}
			return length;
		}

		// Token: 0x0600385F RID: 14431 RVA: 0x00109758 File Offset: 0x00107958
		private static byte[] GetBuffer(global::Org.BouncyCastle.Asn1.DefiniteLengthInputStream defIn, byte[][] tmpBuffers)
		{
			int len = defIn.Remaining;
			if (len >= tmpBuffers.Length)
			{
				return defIn.ToArray();
			}
			byte[] buf = tmpBuffers[len];
			if (buf == null)
			{
				buf = (tmpBuffers[len] = new byte[len]);
			}
			defIn.ReadAllIntoByteArray(buf);
			return buf;
		}

		// Token: 0x06003860 RID: 14432 RVA: 0x00109798 File Offset: 0x00107998
		private static char[] GetBmpCharBuffer(global::Org.BouncyCastle.Asn1.DefiniteLengthInputStream defIn)
		{
			int remainingBytes = defIn.Remaining;
			if ((remainingBytes & 1) != 0)
			{
				throw new global::System.IO.IOException("malformed BMPString encoding encountered");
			}
			char[] str = new char[remainingBytes / 2];
			int stringPos = 0;
			byte[] buf = new byte[8];
			while (remainingBytes >= 8)
			{
				if (global::Org.BouncyCastle.Utilities.IO.Streams.ReadFully(defIn, buf, 0, 8) != 8)
				{
					throw new global::System.IO.EndOfStreamException("EOF encountered in middle of BMPString");
				}
				str[stringPos] = (char)((int)buf[0] << 8 | (int)(buf[1] & byte.MaxValue));
				str[stringPos + 1] = (char)((int)buf[2] << 8 | (int)(buf[3] & byte.MaxValue));
				str[stringPos + 2] = (char)((int)buf[4] << 8 | (int)(buf[5] & byte.MaxValue));
				str[stringPos + 3] = (char)((int)buf[6] << 8 | (int)(buf[7] & byte.MaxValue));
				stringPos += 4;
				remainingBytes -= 8;
			}
			if (remainingBytes > 0)
			{
				if (global::Org.BouncyCastle.Utilities.IO.Streams.ReadFully(defIn, buf, 0, remainingBytes) != remainingBytes)
				{
					throw new global::System.IO.EndOfStreamException("EOF encountered in middle of BMPString");
				}
				int bufPos = 0;
				do
				{
					int b = (int)buf[bufPos++] << 8;
					int b2 = (int)(buf[bufPos++] & byte.MaxValue);
					str[stringPos++] = (char)(b | b2);
				}
				while (bufPos < remainingBytes);
			}
			if (defIn.Remaining != 0 || str.Length != stringPos)
			{
				throw new global::System.InvalidOperationException();
			}
			return str;
		}

		// Token: 0x06003861 RID: 14433 RVA: 0x001098A8 File Offset: 0x00107AA8
		internal static global::Org.BouncyCastle.Asn1.Asn1Object CreatePrimitiveDerObject(int tagNo, global::Org.BouncyCastle.Asn1.DefiniteLengthInputStream defIn, byte[][] tmpBuffers)
		{
			if (tagNo <= 6)
			{
				if (tagNo == 1)
				{
					return global::Org.BouncyCastle.Asn1.DerBoolean.FromOctetString(global::Org.BouncyCastle.Asn1.Asn1InputStream.GetBuffer(defIn, tmpBuffers));
				}
				if (tagNo == 6)
				{
					return global::Org.BouncyCastle.Asn1.DerObjectIdentifier.CreatePrimitive(global::Org.BouncyCastle.Asn1.Asn1InputStream.GetBuffer(defIn, tmpBuffers), true);
				}
			}
			else
			{
				if (tagNo == 10)
				{
					return global::Org.BouncyCastle.Asn1.DerEnumerated.FromOctetString(global::Org.BouncyCastle.Asn1.Asn1InputStream.GetBuffer(defIn, tmpBuffers));
				}
				if (tagNo == 30)
				{
					return new global::Org.BouncyCastle.Asn1.DerBmpString(global::Org.BouncyCastle.Asn1.Asn1InputStream.GetBmpCharBuffer(defIn));
				}
			}
			byte[] bytes = defIn.ToArray();
			switch (tagNo)
			{
			case 2:
				return new global::Org.BouncyCastle.Asn1.DerInteger(bytes, false);
			case 3:
				return global::Org.BouncyCastle.Asn1.DerBitString.CreatePrimitive(bytes);
			case 4:
				return new global::Org.BouncyCastle.Asn1.DerOctetString(bytes);
			case 5:
				if (bytes.Length != 0)
				{
					throw new global::System.InvalidOperationException("malformed NULL encoding encountered");
				}
				return global::Org.BouncyCastle.Asn1.DerNull.Instance;
			case 12:
				return new global::Org.BouncyCastle.Asn1.DerUtf8String(bytes);
			case 18:
				return new global::Org.BouncyCastle.Asn1.DerNumericString(bytes);
			case 19:
				return new global::Org.BouncyCastle.Asn1.DerPrintableString(bytes);
			case 20:
				return new global::Org.BouncyCastle.Asn1.DerT61String(bytes);
			case 21:
				return new global::Org.BouncyCastle.Asn1.DerVideotexString(bytes);
			case 22:
				return new global::Org.BouncyCastle.Asn1.DerIA5String(bytes);
			case 23:
				return new global::Org.BouncyCastle.Asn1.DerUtcTime(bytes);
			case 24:
				return new global::Org.BouncyCastle.Asn1.DerGeneralizedTime(bytes);
			case 25:
				return new global::Org.BouncyCastle.Asn1.DerGraphicString(bytes);
			case 26:
				return new global::Org.BouncyCastle.Asn1.DerVisibleString(bytes);
			case 27:
				return new global::Org.BouncyCastle.Asn1.DerGeneralString(bytes);
			case 28:
				return new global::Org.BouncyCastle.Asn1.DerUniversalString(bytes);
			}
			throw new global::System.IO.IOException("unknown tag " + tagNo.ToString() + " encountered");
		}

		// Token: 0x04001935 RID: 6453
		private readonly int limit;

		// Token: 0x04001936 RID: 6454
		internal readonly byte[][] tmpBuffers;
	}
}
