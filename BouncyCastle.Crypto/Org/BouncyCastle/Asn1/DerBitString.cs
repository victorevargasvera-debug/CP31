using System;
using System.Text;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x02000601 RID: 1537
	public class DerBitString : global::Org.BouncyCastle.Asn1.DerStringBase
	{
		// Token: 0x06003949 RID: 14665 RVA: 0x0010BE24 File Offset: 0x0010A024
		public static global::Org.BouncyCastle.Asn1.DerBitString GetInstance(object obj)
		{
			if (obj == null || obj is global::Org.BouncyCastle.Asn1.DerBitString)
			{
				return (global::Org.BouncyCastle.Asn1.DerBitString)obj;
			}
			if (obj is byte[])
			{
				try
				{
					return (global::Org.BouncyCastle.Asn1.DerBitString)global::Org.BouncyCastle.Asn1.Asn1Object.FromByteArray((byte[])obj);
				}
				catch (global::System.Exception e)
				{
					throw new global::System.ArgumentException("encoding error in GetInstance: " + e.ToString());
				}
			}
			throw new global::System.ArgumentException("illegal object in GetInstance: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj));
		}

		// Token: 0x0600394A RID: 14666 RVA: 0x0010BE9C File Offset: 0x0010A09C
		public static global::Org.BouncyCastle.Asn1.DerBitString GetInstance(global::Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool isExplicit)
		{
			global::Org.BouncyCastle.Asn1.Asn1Object o = obj.GetObject();
			if (isExplicit || o is global::Org.BouncyCastle.Asn1.DerBitString)
			{
				return global::Org.BouncyCastle.Asn1.DerBitString.GetInstance(o);
			}
			return global::Org.BouncyCastle.Asn1.DerBitString.CreatePrimitive(((global::Org.BouncyCastle.Asn1.Asn1OctetString)o).GetOctets());
		}

		// Token: 0x0600394B RID: 14667 RVA: 0x0010BED2 File Offset: 0x0010A0D2
		public DerBitString(byte data, int padBits)
		{
			if (padBits > 7 || padBits < 0)
			{
				throw new global::System.ArgumentException("pad bits cannot be greater than 7 or less than 0", "padBits");
			}
			this.contents = new byte[]
			{
				(byte)padBits,
				data
			};
		}

		// Token: 0x0600394C RID: 14668 RVA: 0x0010BF07 File Offset: 0x0010A107
		public DerBitString(byte[] data) : this(data, 0)
		{
		}

		// Token: 0x0600394D RID: 14669 RVA: 0x0010BF14 File Offset: 0x0010A114
		public DerBitString(byte[] data, int padBits)
		{
			if (data == null)
			{
				throw new global::System.ArgumentNullException("data");
			}
			if (padBits < 0 || padBits > 7)
			{
				throw new global::System.ArgumentException("must be in the range 0 to 7", "padBits");
			}
			if (data.Length == 0 && padBits != 0)
			{
				throw new global::System.ArgumentException("if 'data' is empty, 'padBits' must be 0");
			}
			this.contents = global::Org.BouncyCastle.Utilities.Arrays.Prepend(data, (byte)padBits);
		}

		// Token: 0x0600394E RID: 14670 RVA: 0x0010BF70 File Offset: 0x0010A170
		public DerBitString(int namedBits)
		{
			if (namedBits == 0)
			{
				this.contents = new byte[1];
				return;
			}
			int bytes = (global::Org.BouncyCastle.Math.BigInteger.BitLen(namedBits) + 7) / 8;
			byte[] data = new byte[1 + bytes];
			for (int i = 1; i < bytes; i++)
			{
				data[i] = (byte)namedBits;
				namedBits >>= 8;
			}
			data[bytes] = (byte)namedBits;
			int padBits = 0;
			while ((namedBits & 1 << padBits) == 0)
			{
				padBits++;
			}
			data[0] = (byte)padBits;
			this.contents = data;
		}

		// Token: 0x0600394F RID: 14671 RVA: 0x0010BFE0 File Offset: 0x0010A1E0
		public DerBitString(global::Org.BouncyCastle.Asn1.Asn1Encodable obj) : this(obj.GetDerEncoded())
		{
		}

		// Token: 0x06003950 RID: 14672 RVA: 0x0010BFF0 File Offset: 0x0010A1F0
		internal DerBitString(byte[] contents, bool check)
		{
			if (check)
			{
				if (contents == null)
				{
					throw new global::System.ArgumentNullException("contents");
				}
				if (contents.Length < 1)
				{
					throw new global::System.ArgumentException("cannot be empty", "contents");
				}
				int padBits = (int)contents[0];
				if (padBits > 0)
				{
					if (contents.Length < 2)
					{
						throw new global::System.ArgumentException("zero length data with non-zero pad bits", "contents");
					}
					if (padBits > 7)
					{
						throw new global::System.ArgumentException("pad bits cannot be greater than 7 or less than 0", "contents");
					}
				}
			}
			this.contents = contents;
		}

		// Token: 0x06003951 RID: 14673 RVA: 0x0010C063 File Offset: 0x0010A263
		public virtual byte[] GetOctets()
		{
			if (this.contents[0] != 0)
			{
				throw new global::System.InvalidOperationException("attempt to get non-octet aligned data from BIT STRING");
			}
			return global::Org.BouncyCastle.Utilities.Arrays.CopyOfRange(this.contents, 1, this.contents.Length);
		}

		// Token: 0x06003952 RID: 14674 RVA: 0x0010C090 File Offset: 0x0010A290
		public virtual byte[] GetBytes()
		{
			if (this.contents.Length == 1)
			{
				return global::Org.BouncyCastle.Asn1.Asn1OctetString.EmptyOctets;
			}
			int padBits = (int)this.contents[0];
			byte[] array = global::Org.BouncyCastle.Utilities.Arrays.CopyOfRange(this.contents, 1, this.contents.Length);
			int num = array.Length - 1;
			array[num] &= (byte)(255 << padBits);
			return array;
		}

		// Token: 0x1700079F RID: 1951
		// (get) Token: 0x06003953 RID: 14675 RVA: 0x0010C0E6 File Offset: 0x0010A2E6
		public virtual int PadBits
		{
			get
			{
				return (int)this.contents[0];
			}
		}

		// Token: 0x170007A0 RID: 1952
		// (get) Token: 0x06003954 RID: 14676 RVA: 0x0010C0F0 File Offset: 0x0010A2F0
		public virtual int IntValue
		{
			get
			{
				int value = 0;
				int end = global::System.Math.Min(5, this.contents.Length - 1);
				for (int i = 1; i < end; i++)
				{
					value |= (int)this.contents[i] << 8 * (i - 1);
				}
				if (1 <= end && end < 5)
				{
					int padBits = (int)this.contents[0];
					byte der = (byte)((int)this.contents[end] & 255 << padBits);
					value |= (int)der << 8 * (end - 1);
				}
				return value;
			}
		}

		// Token: 0x06003955 RID: 14677 RVA: 0x0010C166 File Offset: 0x0010A366
		internal override int EncodedLength(bool withID)
		{
			return global::Org.BouncyCastle.Asn1.Asn1OutputStream.GetLengthOfEncodingDL(withID, this.contents.Length);
		}

		// Token: 0x06003956 RID: 14678 RVA: 0x0010C178 File Offset: 0x0010A378
		internal override void Encode(global::Org.BouncyCastle.Asn1.Asn1OutputStream asn1Out, bool withID)
		{
			int padBits = (int)this.contents[0];
			int last = this.contents.Length - 1;
			byte b = this.contents[last];
			byte lastOctetDer = (byte)((int)this.contents[last] & 255 << padBits);
			if (b == lastOctetDer)
			{
				asn1Out.WriteEncodingDL(withID, 3, this.contents);
				return;
			}
			asn1Out.WriteEncodingDL(withID, 3, this.contents, 0, last, lastOctetDer);
		}

		// Token: 0x06003957 RID: 14679 RVA: 0x0010C1DC File Offset: 0x0010A3DC
		protected override int Asn1GetHashCode()
		{
			if (this.contents.Length < 2)
			{
				return 1;
			}
			int padBits = (int)this.contents[0];
			int last = this.contents.Length - 1;
			byte lastOctetDer = (byte)((int)this.contents[last] & 255 << padBits);
			return global::Org.BouncyCastle.Utilities.Arrays.GetHashCode(this.contents, 0, last) * 257 ^ (int)lastOctetDer;
		}

		// Token: 0x06003958 RID: 14680 RVA: 0x0010C234 File Offset: 0x0010A434
		protected override bool Asn1Equals(global::Org.BouncyCastle.Asn1.Asn1Object asn1Object)
		{
			global::Org.BouncyCastle.Asn1.DerBitString that = asn1Object as global::Org.BouncyCastle.Asn1.DerBitString;
			if (that == null)
			{
				return false;
			}
			byte[] thisContents = this.contents;
			byte[] thatContents = that.contents;
			int length = thisContents.Length;
			if (thatContents.Length != length)
			{
				return false;
			}
			if (length == 1)
			{
				return true;
			}
			int last = length - 1;
			for (int i = 0; i < last; i++)
			{
				if (thisContents[i] != thatContents[i])
				{
					return false;
				}
			}
			int padBits = (int)thisContents[0];
			byte b = (byte)((int)thisContents[last] & 255 << padBits);
			byte thatLastOctetDer = (byte)((int)thatContents[last] & 255 << padBits);
			return b == thatLastOctetDer;
		}

		// Token: 0x06003959 RID: 14681 RVA: 0x0010C2BC File Offset: 0x0010A4BC
		public override string GetString()
		{
			global::System.Text.StringBuilder buffer = new global::System.Text.StringBuilder("#");
			byte[] str = base.GetDerEncoded();
			for (int i = 0; i != str.Length; i++)
			{
				uint ubyte = (uint)str[i];
				buffer.Append(global::Org.BouncyCastle.Asn1.DerBitString.table[(int)(ubyte >> 4 & 15U)]);
				buffer.Append(global::Org.BouncyCastle.Asn1.DerBitString.table[(int)(str[i] & 15)]);
			}
			return buffer.ToString();
		}

		// Token: 0x0600395A RID: 14682 RVA: 0x0010C319 File Offset: 0x0010A519
		internal static int EncodedLength(bool withID, int contentsLength)
		{
			return global::Org.BouncyCastle.Asn1.Asn1OutputStream.GetLengthOfEncodingDL(withID, contentsLength);
		}

		// Token: 0x0600395B RID: 14683 RVA: 0x0010C322 File Offset: 0x0010A522
		internal static void Encode(global::Org.BouncyCastle.Asn1.Asn1OutputStream asn1Out, bool withID, byte[] buf, int off, int len)
		{
			asn1Out.WriteEncodingDL(withID, 3, buf, off, len);
		}

		// Token: 0x0600395C RID: 14684 RVA: 0x0010C330 File Offset: 0x0010A530
		internal static void Encode(global::Org.BouncyCastle.Asn1.Asn1OutputStream asn1Out, bool withID, byte pad, byte[] buf, int off, int len)
		{
			asn1Out.WriteEncodingDL(withID, 3, pad, buf, off, len);
		}

		// Token: 0x0600395D RID: 14685 RVA: 0x0010C340 File Offset: 0x0010A540
		internal static global::Org.BouncyCastle.Asn1.DerBitString CreatePrimitive(byte[] contents)
		{
			int length = contents.Length;
			if (length < 1)
			{
				throw new global::System.ArgumentException("truncated BIT STRING detected", "contents");
			}
			int padBits = (int)contents[0];
			if (padBits > 0)
			{
				if (padBits > 7 || length < 2)
				{
					throw new global::System.ArgumentException("invalid pad bits detected", "contents");
				}
				byte finalOctet = contents[length - 1];
				if (finalOctet != (byte)((int)finalOctet & 255 << padBits))
				{
					return new global::Org.BouncyCastle.Asn1.BerBitString(contents, false);
				}
			}
			return new global::Org.BouncyCastle.Asn1.DerBitString(contents, false);
		}

		// Token: 0x04001982 RID: 6530
		private static readonly char[] table = new char[]
		{
			'0',
			'1',
			'2',
			'3',
			'4',
			'5',
			'6',
			'7',
			'8',
			'9',
			'A',
			'B',
			'C',
			'D',
			'E',
			'F'
		};

		// Token: 0x04001983 RID: 6531
		internal readonly byte[] contents;
	}
}
