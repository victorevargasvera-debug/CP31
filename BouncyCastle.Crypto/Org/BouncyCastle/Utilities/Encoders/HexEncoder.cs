using System;
using System.IO;

namespace Org.BouncyCastle.Utilities.Encoders
{
	// Token: 0x02000063 RID: 99
	public class HexEncoder : global::Org.BouncyCastle.Utilities.Encoders.IEncoder
	{
		// Token: 0x0600041D RID: 1053 RVA: 0x00015494 File Offset: 0x00013694
		protected void InitialiseDecodingTable()
		{
			global::Org.BouncyCastle.Utilities.Arrays.Fill(this.decodingTable, byte.MaxValue);
			for (int i = 0; i < this.encodingTable.Length; i++)
			{
				this.decodingTable[(int)this.encodingTable[i]] = (byte)i;
			}
			this.decodingTable[65] = this.decodingTable[97];
			this.decodingTable[66] = this.decodingTable[98];
			this.decodingTable[67] = this.decodingTable[99];
			this.decodingTable[68] = this.decodingTable[100];
			this.decodingTable[69] = this.decodingTable[101];
			this.decodingTable[70] = this.decodingTable[102];
		}

		// Token: 0x0600041E RID: 1054 RVA: 0x00015541 File Offset: 0x00013741
		public HexEncoder()
		{
			this.InitialiseDecodingTable();
		}

		// Token: 0x0600041F RID: 1055 RVA: 0x00015578 File Offset: 0x00013778
		public int Encode(byte[] inBuf, int inOff, int inLen, byte[] outBuf, int outOff)
		{
			int inPos = inOff;
			int inEnd = inOff + inLen;
			int outPos = outOff;
			while (inPos < inEnd)
			{
				uint b = (uint)inBuf[inPos++];
				outBuf[outPos++] = this.encodingTable[(int)(b >> 4)];
				outBuf[outPos++] = this.encodingTable[(int)(b & 15U)];
			}
			return outPos - outOff;
		}

		// Token: 0x06000420 RID: 1056 RVA: 0x000155C8 File Offset: 0x000137C8
		public int Encode(byte[] buf, int off, int len, global::System.IO.Stream outStream)
		{
			if (len < 0)
			{
				return 0;
			}
			byte[] tmp = new byte[72];
			int inLen;
			for (int remaining = len; remaining > 0; remaining -= inLen)
			{
				inLen = global::System.Math.Min(36, remaining);
				int outLen = this.Encode(buf, off, inLen, tmp, 0);
				outStream.Write(tmp, 0, outLen);
				off += inLen;
			}
			return len * 2;
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x00015616 File Offset: 0x00013816
		private static bool Ignore(char c)
		{
			return c == '\n' || c == '\r' || c == '\t' || c == ' ';
		}

		// Token: 0x06000422 RID: 1058 RVA: 0x00015630 File Offset: 0x00013830
		public int Decode(byte[] data, int off, int length, global::System.IO.Stream outStream)
		{
			int outLen = 0;
			byte[] buf = new byte[36];
			int bufOff = 0;
			int end = off + length;
			while (end > off && global::Org.BouncyCastle.Utilities.Encoders.HexEncoder.Ignore((char)data[end - 1]))
			{
				end--;
			}
			int i = off;
			while (i < end)
			{
				while (i < end && global::Org.BouncyCastle.Utilities.Encoders.HexEncoder.Ignore((char)data[i]))
				{
					i++;
				}
				byte b = this.decodingTable[(int)data[i++]];
				while (i < end && global::Org.BouncyCastle.Utilities.Encoders.HexEncoder.Ignore((char)data[i]))
				{
					i++;
				}
				byte b2 = this.decodingTable[(int)data[i++]];
				if ((b | b2) >= 128)
				{
					throw new global::System.IO.IOException("invalid characters encountered in Hex data");
				}
				buf[bufOff++] = (byte)((int)b << 4 | (int)b2);
				if (bufOff == buf.Length)
				{
					outStream.Write(buf, 0, bufOff);
					bufOff = 0;
				}
				outLen++;
			}
			if (bufOff > 0)
			{
				outStream.Write(buf, 0, bufOff);
			}
			return outLen;
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x0001571C File Offset: 0x0001391C
		public int DecodeString(string data, global::System.IO.Stream outStream)
		{
			int length = 0;
			byte[] buf = new byte[36];
			int bufOff = 0;
			int end = data.Length;
			while (end > 0 && global::Org.BouncyCastle.Utilities.Encoders.HexEncoder.Ignore(data[end - 1]))
			{
				end--;
			}
			int i = 0;
			while (i < end)
			{
				while (i < end && global::Org.BouncyCastle.Utilities.Encoders.HexEncoder.Ignore(data[i]))
				{
					i++;
				}
				byte b = this.decodingTable[(int)data[i++]];
				while (i < end && global::Org.BouncyCastle.Utilities.Encoders.HexEncoder.Ignore(data[i]))
				{
					i++;
				}
				byte b2 = this.decodingTable[(int)data[i++]];
				if ((b | b2) >= 128)
				{
					throw new global::System.IO.IOException("invalid characters encountered in Hex data");
				}
				buf[bufOff++] = (byte)((int)b << 4 | (int)b2);
				if (bufOff == buf.Length)
				{
					outStream.Write(buf, 0, bufOff);
					bufOff = 0;
				}
				length++;
			}
			if (bufOff > 0)
			{
				outStream.Write(buf, 0, bufOff);
			}
			return length;
		}

		// Token: 0x06000424 RID: 1060 RVA: 0x0001581C File Offset: 0x00013A1C
		internal byte[] DecodeStrict(string str, int off, int len)
		{
			if (str == null)
			{
				throw new global::System.ArgumentNullException("str");
			}
			if (off < 0 || len < 0 || off > str.Length - len)
			{
				throw new global::System.IndexOutOfRangeException("invalid offset and/or length specified");
			}
			if ((len & 1) != 0)
			{
				throw new global::System.ArgumentException("a hexadecimal encoding must have an even number of characters", "len");
			}
			int resultLen = len >> 1;
			byte[] result = new byte[resultLen];
			int strPos = off;
			for (int i = 0; i < resultLen; i++)
			{
				byte b = this.decodingTable[(int)str[strPos++]];
				byte b2 = this.decodingTable[(int)str[strPos++]];
				if ((b | b2) >= 128)
				{
					throw new global::System.IO.IOException("invalid characters encountered in Hex data");
				}
				result[i] = (byte)((int)b << 4 | (int)b2);
			}
			return result;
		}

		// Token: 0x04000297 RID: 663
		protected readonly byte[] encodingTable = new byte[]
		{
			48,
			49,
			50,
			51,
			52,
			53,
			54,
			55,
			56,
			57,
			97,
			98,
			99,
			100,
			101,
			102
		};

		// Token: 0x04000298 RID: 664
		protected readonly byte[] decodingTable = new byte[128];
	}
}
