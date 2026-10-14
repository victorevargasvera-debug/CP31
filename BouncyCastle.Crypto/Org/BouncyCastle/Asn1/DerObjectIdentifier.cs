using System;
using System.IO;
using System.Text;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x0200060F RID: 1551
	public class DerObjectIdentifier : global::Org.BouncyCastle.Asn1.Asn1Object
	{
		// Token: 0x060039FC RID: 14844 RVA: 0x0010DC8D File Offset: 0x0010BE8D
		public static global::Org.BouncyCastle.Asn1.DerObjectIdentifier FromContents(byte[] contents)
		{
			return global::Org.BouncyCastle.Asn1.DerObjectIdentifier.CreatePrimitive(contents, true);
		}

		// Token: 0x060039FD RID: 14845 RVA: 0x0010DC98 File Offset: 0x0010BE98
		public static global::Org.BouncyCastle.Asn1.DerObjectIdentifier GetInstance(object obj)
		{
			if (obj == null || obj is global::Org.BouncyCastle.Asn1.DerObjectIdentifier)
			{
				return (global::Org.BouncyCastle.Asn1.DerObjectIdentifier)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Encodable)
			{
				global::Org.BouncyCastle.Asn1.Asn1Object asn1Obj = ((global::Org.BouncyCastle.Asn1.Asn1Encodable)obj).ToAsn1Object();
				if (asn1Obj is global::Org.BouncyCastle.Asn1.DerObjectIdentifier)
				{
					return (global::Org.BouncyCastle.Asn1.DerObjectIdentifier)asn1Obj;
				}
			}
			if (obj is byte[])
			{
				return (global::Org.BouncyCastle.Asn1.DerObjectIdentifier)global::Org.BouncyCastle.Asn1.Asn1Object.FromByteArray((byte[])obj);
			}
			throw new global::System.ArgumentException("illegal object in GetInstance: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x060039FE RID: 14846 RVA: 0x0010DD10 File Offset: 0x0010BF10
		public static global::Org.BouncyCastle.Asn1.DerObjectIdentifier GetInstance(global::Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool explicitly)
		{
			global::Org.BouncyCastle.Asn1.Asn1Object o = obj.GetObject();
			if (explicitly || o is global::Org.BouncyCastle.Asn1.DerObjectIdentifier)
			{
				return global::Org.BouncyCastle.Asn1.DerObjectIdentifier.GetInstance(o);
			}
			return global::Org.BouncyCastle.Asn1.DerObjectIdentifier.FromContents(global::Org.BouncyCastle.Asn1.Asn1OctetString.GetInstance(o).GetOctets());
		}

		// Token: 0x060039FF RID: 14847 RVA: 0x0010DD46 File Offset: 0x0010BF46
		public DerObjectIdentifier(string identifier)
		{
			if (identifier == null)
			{
				throw new global::System.ArgumentNullException("identifier");
			}
			if (!global::Org.BouncyCastle.Asn1.DerObjectIdentifier.IsValidIdentifier(identifier))
			{
				throw new global::System.FormatException("string " + identifier + " not an OID");
			}
			this.identifier = identifier;
		}

		// Token: 0x06003A00 RID: 14848 RVA: 0x0010DD84 File Offset: 0x0010BF84
		internal DerObjectIdentifier(global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid, string branchID)
		{
			if (!global::Org.BouncyCastle.Asn1.DerObjectIdentifier.IsValidBranchID(branchID, 0))
			{
				throw new global::System.ArgumentException("string " + branchID + " not a valid OID branch", "branchID");
			}
			this.identifier = oid.Id + "." + branchID;
		}

		// Token: 0x170007B0 RID: 1968
		// (get) Token: 0x06003A01 RID: 14849 RVA: 0x0010DDD2 File Offset: 0x0010BFD2
		public string Id
		{
			get
			{
				return this.identifier;
			}
		}

		// Token: 0x06003A02 RID: 14850 RVA: 0x0010DDDA File Offset: 0x0010BFDA
		public virtual global::Org.BouncyCastle.Asn1.DerObjectIdentifier Branch(string branchID)
		{
			return new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(this, branchID);
		}

		// Token: 0x06003A03 RID: 14851 RVA: 0x0010DDE4 File Offset: 0x0010BFE4
		public virtual bool On(global::Org.BouncyCastle.Asn1.DerObjectIdentifier stem)
		{
			string id = this.Id;
			string stemId = stem.Id;
			return id.Length > stemId.Length && id[stemId.Length] == '.' && global::Org.BouncyCastle.Utilities.Platform.StartsWith(id, stemId);
		}

		// Token: 0x06003A04 RID: 14852 RVA: 0x0010DE26 File Offset: 0x0010C026
		internal DerObjectIdentifier(byte[] contents, bool clone)
		{
			this.identifier = global::Org.BouncyCastle.Asn1.DerObjectIdentifier.MakeOidStringFromBytes(contents);
			this.contents = (clone ? global::Org.BouncyCastle.Utilities.Arrays.Clone(contents) : contents);
		}

		// Token: 0x06003A05 RID: 14853 RVA: 0x0010DE4C File Offset: 0x0010C04C
		private void WriteField(global::System.IO.Stream outputStream, long fieldValue)
		{
			byte[] result = new byte[9];
			int pos = 8;
			result[pos] = (byte)(fieldValue & 127L);
			while (fieldValue >= 128L)
			{
				fieldValue >>= 7;
				result[--pos] = (byte)((fieldValue & 127L) | 128L);
			}
			outputStream.Write(result, pos, 9 - pos);
		}

		// Token: 0x06003A06 RID: 14854 RVA: 0x0010DE9C File Offset: 0x0010C09C
		private void WriteField(global::System.IO.Stream outputStream, global::Org.BouncyCastle.Math.BigInteger fieldValue)
		{
			int byteCount = (fieldValue.BitLength + 6) / 7;
			if (byteCount == 0)
			{
				outputStream.WriteByte(0);
				return;
			}
			global::Org.BouncyCastle.Math.BigInteger tmpValue = fieldValue;
			byte[] tmp = new byte[byteCount];
			for (int i = byteCount - 1; i >= 0; i--)
			{
				tmp[i] = (byte)((tmpValue.IntValue & 127) | 128);
				tmpValue = tmpValue.ShiftRight(7);
			}
			byte[] array = tmp;
			int num = byteCount - 1;
			array[num] &= 127;
			outputStream.Write(tmp, 0, tmp.Length);
		}

		// Token: 0x06003A07 RID: 14855 RVA: 0x0010DF0C File Offset: 0x0010C10C
		private void DoOutput(global::System.IO.MemoryStream bOut)
		{
			global::Org.BouncyCastle.Asn1.OidTokenizer tok = new global::Org.BouncyCastle.Asn1.OidTokenizer(this.identifier);
			string token = tok.NextToken();
			int first = int.Parse(token) * 40;
			token = tok.NextToken();
			if (token.Length <= 18)
			{
				this.WriteField(bOut, (long)first + long.Parse(token));
			}
			else
			{
				this.WriteField(bOut, new global::Org.BouncyCastle.Math.BigInteger(token).Add(global::Org.BouncyCastle.Math.BigInteger.ValueOf((long)first)));
			}
			while (tok.HasMoreTokens)
			{
				token = tok.NextToken();
				if (token.Length <= 18)
				{
					this.WriteField(bOut, long.Parse(token));
				}
				else
				{
					this.WriteField(bOut, new global::Org.BouncyCastle.Math.BigInteger(token));
				}
			}
		}

		// Token: 0x06003A08 RID: 14856 RVA: 0x0010DFAC File Offset: 0x0010C1AC
		private byte[] GetContents()
		{
			byte[] result;
			lock (this)
			{
				if (this.contents == null)
				{
					global::System.IO.MemoryStream bOut = new global::System.IO.MemoryStream();
					this.DoOutput(bOut);
					this.contents = bOut.ToArray();
				}
				result = this.contents;
			}
			return result;
		}

		// Token: 0x06003A09 RID: 14857 RVA: 0x0010E00C File Offset: 0x0010C20C
		internal override int EncodedLength(bool withID)
		{
			return global::Org.BouncyCastle.Asn1.Asn1OutputStream.GetLengthOfEncodingDL(withID, this.GetContents().Length);
		}

		// Token: 0x06003A0A RID: 14858 RVA: 0x0010E01C File Offset: 0x0010C21C
		internal override void Encode(global::Org.BouncyCastle.Asn1.Asn1OutputStream asn1Out, bool withID)
		{
			asn1Out.WriteEncodingDL(withID, 6, this.GetContents());
		}

		// Token: 0x06003A0B RID: 14859 RVA: 0x0010E02C File Offset: 0x0010C22C
		protected override int Asn1GetHashCode()
		{
			return this.identifier.GetHashCode();
		}

		// Token: 0x06003A0C RID: 14860 RVA: 0x0010E03C File Offset: 0x0010C23C
		protected override bool Asn1Equals(global::Org.BouncyCastle.Asn1.Asn1Object asn1Object)
		{
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier other = asn1Object as global::Org.BouncyCastle.Asn1.DerObjectIdentifier;
			return other != null && this.identifier.Equals(other.identifier);
		}

		// Token: 0x06003A0D RID: 14861 RVA: 0x0010E066 File Offset: 0x0010C266
		public override string ToString()
		{
			return this.identifier;
		}

		// Token: 0x06003A0E RID: 14862 RVA: 0x0010E070 File Offset: 0x0010C270
		private static bool IsValidBranchID(string branchID, int start)
		{
			int digitCount = 0;
			int pos = branchID.Length;
			while (--pos >= start)
			{
				char ch = branchID[pos];
				if (ch == '.')
				{
					if (digitCount == 0 || (digitCount > 1 && branchID[pos + 1] == '0'))
					{
						return false;
					}
					digitCount = 0;
				}
				else
				{
					if ('0' > ch || ch > '9')
					{
						return false;
					}
					digitCount++;
				}
			}
			return digitCount != 0 && (digitCount <= 1 || branchID[pos + 1] != '0');
		}

		// Token: 0x06003A0F RID: 14863 RVA: 0x0010E0E0 File Offset: 0x0010C2E0
		private static bool IsValidIdentifier(string identifier)
		{
			if (identifier.Length < 3 || identifier[1] != '.')
			{
				return false;
			}
			char first = identifier[0];
			return first >= '0' && first <= '2' && global::Org.BouncyCastle.Asn1.DerObjectIdentifier.IsValidBranchID(identifier, 2);
		}

		// Token: 0x06003A10 RID: 14864 RVA: 0x0010E120 File Offset: 0x0010C320
		private static string MakeOidStringFromBytes(byte[] bytes)
		{
			global::System.Text.StringBuilder objId = new global::System.Text.StringBuilder();
			long value = 0L;
			global::Org.BouncyCastle.Math.BigInteger bigValue = null;
			bool first = true;
			for (int i = 0; i != bytes.Length; i++)
			{
				int b = (int)bytes[i];
				if (value <= 72057594037927808L)
				{
					value += (long)(b & 127);
					if ((b & 128) == 0)
					{
						if (first)
						{
							if (value < 40L)
							{
								objId.Append('0');
							}
							else if (value < 80L)
							{
								objId.Append('1');
								value -= 40L;
							}
							else
							{
								objId.Append('2');
								value -= 80L;
							}
							first = false;
						}
						objId.Append('.');
						objId.Append(value);
						value = 0L;
					}
					else
					{
						value <<= 7;
					}
				}
				else
				{
					if (bigValue == null)
					{
						bigValue = global::Org.BouncyCastle.Math.BigInteger.ValueOf(value);
					}
					bigValue = bigValue.Or(global::Org.BouncyCastle.Math.BigInteger.ValueOf((long)(b & 127)));
					if ((b & 128) == 0)
					{
						if (first)
						{
							objId.Append('2');
							bigValue = bigValue.Subtract(global::Org.BouncyCastle.Math.BigInteger.ValueOf(80L));
							first = false;
						}
						objId.Append('.');
						objId.Append(bigValue);
						bigValue = null;
						value = 0L;
					}
					else
					{
						bigValue = bigValue.ShiftLeft(7);
					}
				}
			}
			return objId.ToString();
		}

		// Token: 0x06003A11 RID: 14865 RVA: 0x0010E238 File Offset: 0x0010C438
		internal static global::Org.BouncyCastle.Asn1.DerObjectIdentifier CreatePrimitive(byte[] contents, bool clone)
		{
			int first = global::Org.BouncyCastle.Utilities.Arrays.GetHashCode(contents) & 1023;
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier[] obj = global::Org.BouncyCastle.Asn1.DerObjectIdentifier.cache;
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier result;
			lock (obj)
			{
				global::Org.BouncyCastle.Asn1.DerObjectIdentifier entry = global::Org.BouncyCastle.Asn1.DerObjectIdentifier.cache[first];
				if (entry != null && global::Org.BouncyCastle.Utilities.Arrays.AreEqual(contents, entry.GetContents()))
				{
					result = entry;
				}
				else
				{
					result = (global::Org.BouncyCastle.Asn1.DerObjectIdentifier.cache[first] = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(contents, clone));
				}
			}
			return result;
		}

		// Token: 0x040019A0 RID: 6560
		private readonly string identifier;

		// Token: 0x040019A1 RID: 6561
		private byte[] contents;

		// Token: 0x040019A2 RID: 6562
		private const long LONG_LIMIT = 72057594037927808L;

		// Token: 0x040019A3 RID: 6563
		private static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier[] cache = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier[1024];
	}
}
