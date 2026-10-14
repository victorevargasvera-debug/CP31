using System;
using System.Collections;
using System.IO;
using System.Text;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Bcpg
{
	// Token: 0x02000567 RID: 1383
	public class ArmoredInputStream : global::Org.BouncyCastle.Utilities.IO.BaseInputStream
	{
		// Token: 0x060034DC RID: 13532 RVA: 0x000FC04C File Offset: 0x000FA24C
		static ArmoredInputStream()
		{
			global::Org.BouncyCastle.Utilities.Arrays.Fill(global::Org.BouncyCastle.Bcpg.ArmoredInputStream.decodingTable, byte.MaxValue);
			for (int i = 65; i <= 90; i++)
			{
				global::Org.BouncyCastle.Bcpg.ArmoredInputStream.decodingTable[i] = (byte)(i - 65);
			}
			for (int j = 97; j <= 122; j++)
			{
				global::Org.BouncyCastle.Bcpg.ArmoredInputStream.decodingTable[j] = (byte)(j - 97 + 26);
			}
			for (int k = 48; k <= 57; k++)
			{
				global::Org.BouncyCastle.Bcpg.ArmoredInputStream.decodingTable[k] = (byte)(k - 48 + 52);
			}
			global::Org.BouncyCastle.Bcpg.ArmoredInputStream.decodingTable[43] = 62;
			global::Org.BouncyCastle.Bcpg.ArmoredInputStream.decodingTable[47] = 63;
		}

		// Token: 0x060034DD RID: 13533 RVA: 0x000FC0E0 File Offset: 0x000FA2E0
		private static int Decode(int in0, int in1, int in2, int in3, int[] result)
		{
			if (in3 < 0)
			{
				throw new global::System.IO.EndOfStreamException("unexpected end of file in armored stream.");
			}
			if (in2 == 61)
			{
				int b = (int)global::Org.BouncyCastle.Bcpg.ArmoredInputStream.decodingTable[in0];
				int b2 = (int)global::Org.BouncyCastle.Bcpg.ArmoredInputStream.decodingTable[in1];
				if ((b | b2) >= 128)
				{
					throw new global::System.IO.IOException("invalid armor");
				}
				result[2] = ((b << 2 | b2 >> 4) & 255);
				return 2;
			}
			else if (in3 == 61)
			{
				int b = (int)global::Org.BouncyCastle.Bcpg.ArmoredInputStream.decodingTable[in0];
				int b2 = (int)global::Org.BouncyCastle.Bcpg.ArmoredInputStream.decodingTable[in1];
				int b3 = (int)global::Org.BouncyCastle.Bcpg.ArmoredInputStream.decodingTable[in2];
				if ((b | b2 | b3) >= 128)
				{
					throw new global::System.IO.IOException("invalid armor");
				}
				result[1] = ((b << 2 | b2 >> 4) & 255);
				result[2] = ((b2 << 4 | b3 >> 2) & 255);
				return 1;
			}
			else
			{
				int b = (int)global::Org.BouncyCastle.Bcpg.ArmoredInputStream.decodingTable[in0];
				int b2 = (int)global::Org.BouncyCastle.Bcpg.ArmoredInputStream.decodingTable[in1];
				int b3 = (int)global::Org.BouncyCastle.Bcpg.ArmoredInputStream.decodingTable[in2];
				int b4 = (int)global::Org.BouncyCastle.Bcpg.ArmoredInputStream.decodingTable[in3];
				if ((b | b2 | b3 | b4) >= 128)
				{
					throw new global::System.IO.IOException("invalid armor");
				}
				result[0] = ((b << 2 | b2 >> 4) & 255);
				result[1] = ((b2 << 4 | b3 >> 2) & 255);
				result[2] = ((b3 << 6 | b4) & 255);
				return 0;
			}
		}

		// Token: 0x060034DE RID: 13534 RVA: 0x000FC1FC File Offset: 0x000FA3FC
		public ArmoredInputStream(global::System.IO.Stream input) : this(input, true)
		{
		}

		// Token: 0x060034DF RID: 13535 RVA: 0x000FC208 File Offset: 0x000FA408
		public ArmoredInputStream(global::System.IO.Stream input, bool hasHeaders)
		{
			this.input = input;
			this.hasHeaders = hasHeaders;
			if (hasHeaders)
			{
				this.ParseHeaders();
			}
			this.start = false;
		}

		// Token: 0x060034E0 RID: 13536 RVA: 0x000FC274 File Offset: 0x000FA474
		private bool ParseHeaders()
		{
			this.header = null;
			int last = 0;
			bool headerFound = false;
			this.headerList = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
			if (this.restart)
			{
				headerFound = true;
			}
			else
			{
				int c;
				while ((c = this.input.ReadByte()) >= 0)
				{
					if (c == 45 && (last == 0 || last == 10 || last == 13))
					{
						headerFound = true;
						break;
					}
					last = c;
				}
			}
			if (headerFound)
			{
				global::System.Text.StringBuilder buf = new global::System.Text.StringBuilder("-");
				bool eolReached = false;
				bool crLf = false;
				if (this.restart)
				{
					buf.Append('-');
				}
				int c;
				while ((c = this.input.ReadByte()) >= 0)
				{
					if (last == 13 && c == 10)
					{
						crLf = true;
					}
					if ((eolReached && last != 13 && c == 10) || (eolReached && c == 13))
					{
						break;
					}
					if (c == 13 || (last != 13 && c == 10))
					{
						string line = buf.ToString();
						if (line.Trim().Length < 1)
						{
							break;
						}
						if (this.headerList.Count > 0 && line.IndexOf(':') < 0)
						{
							throw new global::System.IO.IOException("invalid armor header");
						}
						this.headerList.Add(line);
						buf.Length = 0;
					}
					if (c != 10 && c != 13)
					{
						buf.Append((char)c);
						eolReached = false;
					}
					else if (c == 13 || (last != 13 && c == 10))
					{
						eolReached = true;
					}
					last = c;
				}
				if (crLf)
				{
					this.input.ReadByte();
				}
			}
			if (this.headerList.Count > 0)
			{
				this.header = (string)this.headerList[0];
			}
			this.clearText = "-----BEGIN PGP SIGNED MESSAGE-----".Equals(this.header);
			this.newLineFound = true;
			return headerFound;
		}

		// Token: 0x060034E1 RID: 13537 RVA: 0x000FC417 File Offset: 0x000FA617
		public bool IsClearText()
		{
			return this.clearText;
		}

		// Token: 0x060034E2 RID: 13538 RVA: 0x000FC41F File Offset: 0x000FA61F
		public bool IsEndOfStream()
		{
			return this.isEndOfStream;
		}

		// Token: 0x060034E3 RID: 13539 RVA: 0x000FC427 File Offset: 0x000FA627
		public string GetArmorHeaderLine()
		{
			return this.header;
		}

		// Token: 0x060034E4 RID: 13540 RVA: 0x000FC430 File Offset: 0x000FA630
		public string[] GetArmorHeaders()
		{
			if (this.headerList.Count <= 1)
			{
				return null;
			}
			string[] hdrs = new string[this.headerList.Count - 1];
			for (int i = 0; i != hdrs.Length; i++)
			{
				hdrs[i] = (string)this.headerList[i + 1];
			}
			return hdrs;
		}

		// Token: 0x060034E5 RID: 13541 RVA: 0x000FC488 File Offset: 0x000FA688
		private int ReadIgnoreSpace()
		{
			int c;
			do
			{
				c = this.input.ReadByte();
			}
			while (c == 32 || c == 9 || c == 12 || c == 11);
			if (c >= 128)
			{
				throw new global::System.IO.IOException("invalid armor");
			}
			return c;
		}

		// Token: 0x060034E6 RID: 13542 RVA: 0x000FC4CC File Offset: 0x000FA6CC
		public override int ReadByte()
		{
			if (this.start)
			{
				if (this.hasHeaders)
				{
					this.ParseHeaders();
				}
				this.crc.Reset();
				this.start = false;
			}
			int c;
			if (this.clearText)
			{
				c = this.input.ReadByte();
				if (c == 13 || (c == 10 && this.lastC != 13))
				{
					this.newLineFound = true;
				}
				else if (this.newLineFound && c == 45)
				{
					c = this.input.ReadByte();
					if (c == 45)
					{
						this.clearText = false;
						this.start = true;
						this.restart = true;
					}
					else
					{
						c = this.input.ReadByte();
					}
					this.newLineFound = false;
				}
				else if (c != 10 && this.lastC != 13)
				{
					this.newLineFound = false;
				}
				this.lastC = c;
				if (c < 0)
				{
					this.isEndOfStream = true;
				}
				return c;
			}
			if (this.bufPtr > 2 || this.crcFound)
			{
				c = this.ReadIgnoreSpace();
				if (c == 13 || c == 10)
				{
					c = this.ReadIgnoreSpace();
					while (c == 10 || c == 13)
					{
						c = this.ReadIgnoreSpace();
					}
					if (c < 0)
					{
						this.isEndOfStream = true;
						return -1;
					}
					if (c == 61)
					{
						this.bufPtr = global::Org.BouncyCastle.Bcpg.ArmoredInputStream.Decode(this.ReadIgnoreSpace(), this.ReadIgnoreSpace(), this.ReadIgnoreSpace(), this.ReadIgnoreSpace(), this.outBuf);
						if (this.bufPtr == 0)
						{
							int num = (this.outBuf[0] & 255) << 16 | (this.outBuf[1] & 255) << 8 | (this.outBuf[2] & 255);
							this.crcFound = true;
							if (num != this.crc.Value)
							{
								throw new global::System.IO.IOException("crc check failed in armored message.");
							}
							return this.ReadByte();
						}
						else if (this.detectMissingChecksum)
						{
							throw new global::System.IO.IOException("no crc found in armored message");
						}
					}
					else if (c == 45)
					{
						while ((c = this.input.ReadByte()) >= 0 && c != 10 && c != 13)
						{
						}
						if (!this.crcFound && this.detectMissingChecksum)
						{
							throw new global::System.IO.IOException("crc check not found");
						}
						this.crcFound = false;
						this.start = true;
						this.bufPtr = 3;
						if (c < 0)
						{
							this.isEndOfStream = true;
						}
						return -1;
					}
					else
					{
						this.bufPtr = global::Org.BouncyCastle.Bcpg.ArmoredInputStream.Decode(c, this.ReadIgnoreSpace(), this.ReadIgnoreSpace(), this.ReadIgnoreSpace(), this.outBuf);
					}
				}
				else
				{
					if (c < 0)
					{
						this.isEndOfStream = true;
						return -1;
					}
					this.bufPtr = global::Org.BouncyCastle.Bcpg.ArmoredInputStream.Decode(c, this.ReadIgnoreSpace(), this.ReadIgnoreSpace(), this.ReadIgnoreSpace(), this.outBuf);
				}
			}
			int[] array = this.outBuf;
			int num2 = this.bufPtr;
			this.bufPtr = num2 + 1;
			c = array[num2];
			this.crc.Update(c);
			return c;
		}

		// Token: 0x060034E7 RID: 13543 RVA: 0x000FC77C File Offset: 0x000FA97C
		public override int Read(byte[] b, int off, int len)
		{
			this.CheckIndexSize(b.Length, off, len);
			int pos = 0;
			while (pos < len)
			{
				int c = this.ReadByte();
				if (c < 0)
				{
					break;
				}
				b[off + pos++] = (byte)c;
			}
			return pos;
		}

		// Token: 0x060034E8 RID: 13544 RVA: 0x000FC7B3 File Offset: 0x000FA9B3
		private void CheckIndexSize(int size, int off, int len)
		{
			if (off < 0 || len < 0)
			{
				throw new global::System.IndexOutOfRangeException("Offset and length cannot be negative.");
			}
			if (off > size - len)
			{
				throw new global::System.IndexOutOfRangeException("Invalid offset and length.");
			}
		}

		// Token: 0x060034E9 RID: 13545 RVA: 0x000FC7D9 File Offset: 0x000FA9D9
		public override void Close()
		{
			global::Org.BouncyCastle.Utilities.Platform.Dispose(this.input);
			base.Close();
		}

		// Token: 0x060034EA RID: 13546 RVA: 0x000FC7EC File Offset: 0x000FA9EC
		public virtual void SetDetectMissingCrc(bool detectMissing)
		{
			this.detectMissingChecksum = detectMissing;
		}

		// Token: 0x04001799 RID: 6041
		private static readonly byte[] decodingTable = new byte[128];

		// Token: 0x0400179A RID: 6042
		private bool detectMissingChecksum;

		// Token: 0x0400179B RID: 6043
		private global::System.IO.Stream input;

		// Token: 0x0400179C RID: 6044
		private bool start = true;

		// Token: 0x0400179D RID: 6045
		private int[] outBuf = new int[3];

		// Token: 0x0400179E RID: 6046
		private int bufPtr = 3;

		// Token: 0x0400179F RID: 6047
		private global::Org.BouncyCastle.Bcpg.Crc24 crc = new global::Org.BouncyCastle.Bcpg.Crc24();

		// Token: 0x040017A0 RID: 6048
		private bool crcFound;

		// Token: 0x040017A1 RID: 6049
		private bool hasHeaders = true;

		// Token: 0x040017A2 RID: 6050
		private string header;

		// Token: 0x040017A3 RID: 6051
		private bool newLineFound;

		// Token: 0x040017A4 RID: 6052
		private bool clearText;

		// Token: 0x040017A5 RID: 6053
		private bool restart;

		// Token: 0x040017A6 RID: 6054
		private global::System.Collections.IList headerList = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();

		// Token: 0x040017A7 RID: 6055
		private int lastC;

		// Token: 0x040017A8 RID: 6056
		private bool isEndOfStream;
	}
}
