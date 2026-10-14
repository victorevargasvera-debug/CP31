using System;
using System.IO;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x020005E9 RID: 1513
	public class Asn1StreamParser
	{
		// Token: 0x060038B5 RID: 14517 RVA: 0x0010A5BC File Offset: 0x001087BC
		public Asn1StreamParser(global::System.IO.Stream input) : this(input, global::Org.BouncyCastle.Asn1.Asn1InputStream.FindLimit(input))
		{
		}

		// Token: 0x060038B6 RID: 14518 RVA: 0x0010A5CB File Offset: 0x001087CB
		public Asn1StreamParser(byte[] encoding) : this(new global::System.IO.MemoryStream(encoding, false), encoding.Length)
		{
		}

		// Token: 0x060038B7 RID: 14519 RVA: 0x0010A5DD File Offset: 0x001087DD
		public Asn1StreamParser(global::System.IO.Stream input, int limit) : this(input, limit, new byte[16][])
		{
		}

		// Token: 0x060038B8 RID: 14520 RVA: 0x0010A5EE File Offset: 0x001087EE
		internal Asn1StreamParser(global::System.IO.Stream input, int limit, byte[][] tmpBuffers)
		{
			if (!input.CanRead)
			{
				throw new global::System.ArgumentException("Expected stream to be readable", "input");
			}
			this._in = input;
			this._limit = limit;
			this.tmpBuffers = tmpBuffers;
		}

		// Token: 0x060038B9 RID: 14521 RVA: 0x0010A624 File Offset: 0x00108824
		internal global::Org.BouncyCastle.Asn1.IAsn1Convertible ReadIndef(int tagValue)
		{
			if (tagValue <= 8)
			{
				if (tagValue == 4)
				{
					return new global::Org.BouncyCastle.Asn1.BerOctetStringParser(this);
				}
				if (tagValue == 8)
				{
					return new global::Org.BouncyCastle.Asn1.DerExternalParser(this);
				}
			}
			else
			{
				if (tagValue == 16)
				{
					return new global::Org.BouncyCastle.Asn1.BerSequenceParser(this);
				}
				if (tagValue == 17)
				{
					return new global::Org.BouncyCastle.Asn1.BerSetParser(this);
				}
			}
			throw new global::Org.BouncyCastle.Asn1.Asn1Exception("unknown BER object encountered: 0x" + tagValue.ToString("X"));
		}

		// Token: 0x060038BA RID: 14522 RVA: 0x0010A684 File Offset: 0x00108884
		internal global::Org.BouncyCastle.Asn1.IAsn1Convertible ReadImplicit(bool constructed, int tag)
		{
			if (!(this._in is global::Org.BouncyCastle.Asn1.IndefiniteLengthInputStream))
			{
				if (constructed)
				{
					if (tag == 4)
					{
						return new global::Org.BouncyCastle.Asn1.BerOctetStringParser(this);
					}
					if (tag == 16)
					{
						return new global::Org.BouncyCastle.Asn1.DerSequenceParser(this);
					}
					if (tag == 17)
					{
						return new global::Org.BouncyCastle.Asn1.DerSetParser(this);
					}
				}
				else
				{
					if (tag == 4)
					{
						return new global::Org.BouncyCastle.Asn1.DerOctetStringParser((global::Org.BouncyCastle.Asn1.DefiniteLengthInputStream)this._in);
					}
					if (tag == 16)
					{
						throw new global::Org.BouncyCastle.Asn1.Asn1Exception("sets must use constructed encoding (see X.690 8.11.1/8.12.1)");
					}
					if (tag == 17)
					{
						throw new global::Org.BouncyCastle.Asn1.Asn1Exception("sequences must use constructed encoding (see X.690 8.9.1/8.10.1)");
					}
				}
				throw new global::Org.BouncyCastle.Asn1.Asn1Exception("implicit tagging not implemented");
			}
			if (!constructed)
			{
				throw new global::System.IO.IOException("indefinite-length primitive encoding encountered");
			}
			return this.ReadIndef(tag);
		}

		// Token: 0x060038BB RID: 14523 RVA: 0x0010A71C File Offset: 0x0010891C
		internal global::Org.BouncyCastle.Asn1.Asn1Object ReadTaggedObject(bool constructed, int tag)
		{
			if (!constructed)
			{
				global::Org.BouncyCastle.Asn1.DefiniteLengthInputStream defIn = (global::Org.BouncyCastle.Asn1.DefiniteLengthInputStream)this._in;
				return new global::Org.BouncyCastle.Asn1.DerTaggedObject(false, tag, new global::Org.BouncyCastle.Asn1.DerOctetString(defIn.ToArray()));
			}
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector v = this.ReadVector();
			if (this._in is global::Org.BouncyCastle.Asn1.IndefiniteLengthInputStream)
			{
				if (v.Count != 1)
				{
					return new global::Org.BouncyCastle.Asn1.BerTaggedObject(false, tag, global::Org.BouncyCastle.Asn1.BerSequence.FromVector(v));
				}
				return new global::Org.BouncyCastle.Asn1.BerTaggedObject(true, tag, v[0]);
			}
			else
			{
				if (v.Count != 1)
				{
					return new global::Org.BouncyCastle.Asn1.DerTaggedObject(false, tag, global::Org.BouncyCastle.Asn1.DerSequence.FromVector(v));
				}
				return new global::Org.BouncyCastle.Asn1.DerTaggedObject(true, tag, v[0]);
			}
		}

		// Token: 0x060038BC RID: 14524 RVA: 0x0010A7AC File Offset: 0x001089AC
		public virtual global::Org.BouncyCastle.Asn1.IAsn1Convertible ReadObject()
		{
			int tag = this._in.ReadByte();
			if (tag == -1)
			{
				return null;
			}
			this.Set00Check(false);
			int tagNo = global::Org.BouncyCastle.Asn1.Asn1InputStream.ReadTagNumber(this._in, tag);
			bool isConstructed = (tag & 32) != 0;
			int length = global::Org.BouncyCastle.Asn1.Asn1InputStream.ReadLength(this._in, this._limit, tagNo == 4 || tagNo == 16 || tagNo == 17 || tagNo == 8);
			if (length < 0)
			{
				if (!isConstructed)
				{
					throw new global::System.IO.IOException("indefinite-length primitive encoding encountered");
				}
				global::Org.BouncyCastle.Asn1.Asn1StreamParser sp = new global::Org.BouncyCastle.Asn1.Asn1StreamParser(new global::Org.BouncyCastle.Asn1.IndefiniteLengthInputStream(this._in, this._limit), this._limit, this.tmpBuffers);
				int tagClass = tag & 192;
				if (tagClass == 0)
				{
					return sp.ReadIndef(tagNo);
				}
				if ((tag & 64) != 0)
				{
					return new global::Org.BouncyCastle.Asn1.BerApplicationSpecificParser(tagNo, sp);
				}
				return new global::Org.BouncyCastle.Asn1.BerTaggedObjectParser(true, tagNo, sp);
			}
			else
			{
				global::Org.BouncyCastle.Asn1.DefiniteLengthInputStream defIn = new global::Org.BouncyCastle.Asn1.DefiniteLengthInputStream(this._in, length, this._limit);
				int tagClass2 = tag & 192;
				if (tagClass2 == 0)
				{
					if (!isConstructed)
					{
						if (tagNo == 4)
						{
							return new global::Org.BouncyCastle.Asn1.DerOctetStringParser(defIn);
						}
						try
						{
							return global::Org.BouncyCastle.Asn1.Asn1InputStream.CreatePrimitiveDerObject(tagNo, defIn, this.tmpBuffers);
						}
						catch (global::System.ArgumentException e)
						{
							throw new global::Org.BouncyCastle.Asn1.Asn1Exception("corrupted stream detected", e);
						}
					}
					global::Org.BouncyCastle.Asn1.Asn1StreamParser sp2 = new global::Org.BouncyCastle.Asn1.Asn1StreamParser(defIn, defIn.Remaining, this.tmpBuffers);
					if (tagNo <= 8)
					{
						if (tagNo == 4)
						{
							return new global::Org.BouncyCastle.Asn1.BerOctetStringParser(sp2);
						}
						if (tagNo == 8)
						{
							return new global::Org.BouncyCastle.Asn1.DerExternalParser(sp2);
						}
					}
					else
					{
						if (tagNo == 16)
						{
							return new global::Org.BouncyCastle.Asn1.DerSequenceParser(sp2);
						}
						if (tagNo == 17)
						{
							return new global::Org.BouncyCastle.Asn1.DerSetParser(sp2);
						}
					}
					throw new global::System.IO.IOException("unknown tag " + tagNo.ToString() + " encountered");
				}
				if ((tag & 64) != 0)
				{
					return new global::Org.BouncyCastle.Asn1.DerApplicationSpecific(isConstructed, tagNo, defIn.ToArray());
				}
				return new global::Org.BouncyCastle.Asn1.BerTaggedObjectParser(isConstructed, tagNo, new global::Org.BouncyCastle.Asn1.Asn1StreamParser(defIn, defIn.Remaining, this.tmpBuffers));
			}
		}

		// Token: 0x060038BD RID: 14525 RVA: 0x0010A974 File Offset: 0x00108B74
		private void Set00Check(bool enabled)
		{
			if (this._in is global::Org.BouncyCastle.Asn1.IndefiniteLengthInputStream)
			{
				((global::Org.BouncyCastle.Asn1.IndefiniteLengthInputStream)this._in).SetEofOn00(enabled);
			}
		}

		// Token: 0x060038BE RID: 14526 RVA: 0x0010A994 File Offset: 0x00108B94
		internal global::Org.BouncyCastle.Asn1.Asn1EncodableVector ReadVector()
		{
			global::Org.BouncyCastle.Asn1.IAsn1Convertible obj = this.ReadObject();
			if (obj == null)
			{
				return new global::Org.BouncyCastle.Asn1.Asn1EncodableVector(0);
			}
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector v = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector();
			do
			{
				v.Add(obj.ToAsn1Object());
			}
			while ((obj = this.ReadObject()) != null);
			return v;
		}

		// Token: 0x0400193B RID: 6459
		private readonly global::System.IO.Stream _in;

		// Token: 0x0400193C RID: 6460
		private readonly int _limit;

		// Token: 0x0400193D RID: 6461
		private readonly byte[][] tmpBuffers;
	}
}
