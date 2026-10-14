using System;
using System.IO;

namespace Org.BouncyCastle.Utilities.Encoders
{
	// Token: 0x0200005F RID: 95
	public class Base64Encoder : global::Org.BouncyCastle.Utilities.Encoders.IEncoder
	{
		// Token: 0x06000400 RID: 1024 RVA: 0x000149DC File Offset: 0x00012BDC
		protected void InitialiseDecodingTable()
		{
			global::Org.BouncyCastle.Utilities.Arrays.Fill(this.decodingTable, byte.MaxValue);
			for (int i = 0; i < this.encodingTable.Length; i++)
			{
				this.decodingTable[(int)this.encodingTable[i]] = (byte)i;
			}
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x00014A1D File Offset: 0x00012C1D
		public Base64Encoder()
		{
			this.InitialiseDecodingTable();
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x00014A5C File Offset: 0x00012C5C
		public int Encode(byte[] inBuf, int inOff, int inLen, byte[] outBuf, int outOff)
		{
			int inPos = inOff;
			int inEnd = inOff + inLen - 2;
			int outPos = outOff;
			while (inPos < inEnd)
			{
				uint a = (uint)inBuf[inPos++];
				uint a2 = (uint)inBuf[inPos++];
				uint a3 = (uint)inBuf[inPos++];
				outBuf[outPos++] = this.encodingTable[(int)(a >> 2 & 63U)];
				outBuf[outPos++] = this.encodingTable[(int)((a << 4 | a2 >> 4) & 63U)];
				outBuf[outPos++] = this.encodingTable[(int)((a2 << 2 | a3 >> 6) & 63U)];
				outBuf[outPos++] = this.encodingTable[(int)(a3 & 63U)];
			}
			int num = inLen - (inPos - inOff);
			if (num != 1)
			{
				if (num == 2)
				{
					uint a4 = (uint)inBuf[inPos++];
					uint a5 = (uint)inBuf[inPos++];
					outBuf[outPos++] = this.encodingTable[(int)(a4 >> 2 & 63U)];
					outBuf[outPos++] = this.encodingTable[(int)((a4 << 4 | a5 >> 4) & 63U)];
					outBuf[outPos++] = this.encodingTable[(int)(a5 << 2 & 63U)];
					outBuf[outPos++] = this.padding;
				}
			}
			else
			{
				uint a6 = (uint)inBuf[inPos++];
				outBuf[outPos++] = this.encodingTable[(int)(a6 >> 2 & 63U)];
				outBuf[outPos++] = this.encodingTable[(int)(a6 << 4 & 63U)];
				outBuf[outPos++] = this.padding;
				outBuf[outPos++] = this.padding;
			}
			return outPos - outOff;
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x00014BC8 File Offset: 0x00012DC8
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
				inLen = global::System.Math.Min(54, remaining);
				int outLen = this.Encode(buf, off, inLen, tmp, 0);
				outStream.Write(tmp, 0, outLen);
				off += inLen;
			}
			return (len + 2) / 3 * 4;
		}

		// Token: 0x06000404 RID: 1028 RVA: 0x00014C1A File Offset: 0x00012E1A
		private bool Ignore(char c)
		{
			return c == '\n' || c == '\r' || c == '\t' || c == ' ';
		}

		// Token: 0x06000405 RID: 1029 RVA: 0x00014C34 File Offset: 0x00012E34
		public int Decode(byte[] data, int off, int length, global::System.IO.Stream outStream)
		{
			byte[] outBuffer = new byte[54];
			int bufOff = 0;
			int outLen = 0;
			int end = off + length;
			while (end > off && this.Ignore((char)data[end - 1]))
			{
				end--;
			}
			int finish = end - 4;
			int i;
			for (i = this.NextI(data, off, finish); i < finish; i = this.NextI(data, i, finish))
			{
				byte b = this.decodingTable[(int)data[i++]];
				i = this.NextI(data, i, finish);
				byte b2 = this.decodingTable[(int)data[i++]];
				i = this.NextI(data, i, finish);
				byte b3 = this.decodingTable[(int)data[i++]];
				i = this.NextI(data, i, finish);
				byte b4 = this.decodingTable[(int)data[i++]];
				if ((b | b2 | b3 | b4) >= 128)
				{
					throw new global::System.IO.IOException("invalid characters encountered in base64 data");
				}
				outBuffer[bufOff++] = (byte)((int)b << 2 | b2 >> 4);
				outBuffer[bufOff++] = (byte)((int)b2 << 4 | b3 >> 2);
				outBuffer[bufOff++] = (byte)((int)b3 << 6 | (int)b4);
				if (bufOff == outBuffer.Length)
				{
					outStream.Write(outBuffer, 0, bufOff);
					bufOff = 0;
				}
				outLen += 3;
			}
			if (bufOff > 0)
			{
				outStream.Write(outBuffer, 0, bufOff);
			}
			int e0 = this.NextI(data, i, end);
			int e = this.NextI(data, e0 + 1, end);
			int e2 = this.NextI(data, e + 1, end);
			int e3 = this.NextI(data, e2 + 1, end);
			return outLen + this.DecodeLastBlock(outStream, (char)data[e0], (char)data[e], (char)data[e2], (char)data[e3]);
		}

		// Token: 0x06000406 RID: 1030 RVA: 0x00014DE0 File Offset: 0x00012FE0
		private int NextI(byte[] data, int i, int finish)
		{
			while (i < finish && this.Ignore((char)data[i]))
			{
				i++;
			}
			return i;
		}

		// Token: 0x06000407 RID: 1031 RVA: 0x00014DFC File Offset: 0x00012FFC
		public int DecodeString(string data, global::System.IO.Stream outStream)
		{
			int length = 0;
			int end = data.Length;
			while (end > 0 && this.Ignore(data[end - 1]))
			{
				end--;
			}
			int i = 0;
			int finish = end - 4;
			for (i = this.NextI(data, i, finish); i < finish; i = this.NextI(data, i, finish))
			{
				byte b = this.decodingTable[(int)data[i++]];
				i = this.NextI(data, i, finish);
				byte b2 = this.decodingTable[(int)data[i++]];
				i = this.NextI(data, i, finish);
				byte b3 = this.decodingTable[(int)data[i++]];
				i = this.NextI(data, i, finish);
				byte b4 = this.decodingTable[(int)data[i++]];
				if ((b | b2 | b3 | b4) >= 128)
				{
					throw new global::System.IO.IOException("invalid characters encountered in base64 data");
				}
				outStream.WriteByte((byte)((int)b << 2 | b2 >> 4));
				outStream.WriteByte((byte)((int)b2 << 4 | b3 >> 2));
				outStream.WriteByte((byte)((int)b3 << 6 | (int)b4));
				length += 3;
			}
			return length + this.DecodeLastBlock(outStream, data[end - 4], data[end - 3], data[end - 2], data[end - 1]);
		}

		// Token: 0x06000408 RID: 1032 RVA: 0x00014F5C File Offset: 0x0001315C
		private int DecodeLastBlock(global::System.IO.Stream outStream, char c1, char c2, char c3, char c4)
		{
			if (c3 == (char)this.padding)
			{
				if (c4 != (char)this.padding)
				{
					throw new global::System.IO.IOException("invalid characters encountered at end of base64 data");
				}
				byte b = this.decodingTable[(int)c1];
				byte b2 = this.decodingTable[(int)c2];
				if ((b | b2) >= 128)
				{
					throw new global::System.IO.IOException("invalid characters encountered at end of base64 data");
				}
				outStream.WriteByte((byte)((int)b << 2 | b2 >> 4));
				return 1;
			}
			else if (c4 == (char)this.padding)
			{
				byte b3 = this.decodingTable[(int)c1];
				byte b4 = this.decodingTable[(int)c2];
				byte b5 = this.decodingTable[(int)c3];
				if ((b3 | b4 | b5) >= 128)
				{
					throw new global::System.IO.IOException("invalid characters encountered at end of base64 data");
				}
				outStream.WriteByte((byte)((int)b3 << 2 | b4 >> 4));
				outStream.WriteByte((byte)((int)b4 << 4 | b5 >> 2));
				return 2;
			}
			else
			{
				byte b6 = this.decodingTable[(int)c1];
				byte b7 = this.decodingTable[(int)c2];
				byte b8 = this.decodingTable[(int)c3];
				byte b9 = this.decodingTable[(int)c4];
				if ((b6 | b7 | b8 | b9) >= 128)
				{
					throw new global::System.IO.IOException("invalid characters encountered at end of base64 data");
				}
				outStream.WriteByte((byte)((int)b6 << 2 | b7 >> 4));
				outStream.WriteByte((byte)((int)b7 << 4 | b8 >> 2));
				outStream.WriteByte((byte)((int)b8 << 6 | (int)b9));
				return 3;
			}
		}

		// Token: 0x06000409 RID: 1033 RVA: 0x00015093 File Offset: 0x00013293
		private int NextI(string data, int i, int finish)
		{
			while (i < finish && this.Ignore(data[i]))
			{
				i++;
			}
			return i;
		}

		// Token: 0x0400028D RID: 653
		protected readonly byte[] encodingTable = new byte[]
		{
			65,
			66,
			67,
			68,
			69,
			70,
			71,
			72,
			73,
			74,
			75,
			76,
			77,
			78,
			79,
			80,
			81,
			82,
			83,
			84,
			85,
			86,
			87,
			88,
			89,
			90,
			97,
			98,
			99,
			100,
			101,
			102,
			103,
			104,
			105,
			106,
			107,
			108,
			109,
			110,
			111,
			112,
			113,
			114,
			115,
			116,
			117,
			118,
			119,
			120,
			121,
			122,
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
			43,
			47
		};

		// Token: 0x0400028E RID: 654
		protected byte padding = 61;

		// Token: 0x0400028F RID: 655
		protected readonly byte[] decodingTable = new byte[128];
	}
}
