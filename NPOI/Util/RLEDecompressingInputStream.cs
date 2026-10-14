using System;
using System.IO;

namespace NPOI.Util
{
	// Token: 0x0200028C RID: 652
	public class RLEDecompressingInputStream : global::NPOI.Util.InputStream
	{
		// Token: 0x17000351 RID: 849
		// (get) Token: 0x060011A3 RID: 4515 RVA: 0x00034F6C File Offset: 0x0003316C
		public override bool CanRead
		{
			get
			{
				return this.input.CanRead;
			}
		}

		// Token: 0x17000352 RID: 850
		// (get) Token: 0x060011A4 RID: 4516 RVA: 0x00034F79 File Offset: 0x00033179
		public override bool CanSeek
		{
			get
			{
				return this.input.CanSeek;
			}
		}

		// Token: 0x17000353 RID: 851
		// (get) Token: 0x060011A5 RID: 4517 RVA: 0x00034F86 File Offset: 0x00033186
		public override bool CanWrite
		{
			get
			{
				return this.input.CanWrite;
			}
		}

		// Token: 0x17000354 RID: 852
		// (get) Token: 0x060011A6 RID: 4518 RVA: 0x00034F93 File Offset: 0x00033193
		public override long Length
		{
			get
			{
				return this.input.Length;
			}
		}

		// Token: 0x17000355 RID: 853
		// (get) Token: 0x060011A7 RID: 4519 RVA: 0x00034FA0 File Offset: 0x000331A0
		// (set) Token: 0x060011A8 RID: 4520 RVA: 0x00034FAD File Offset: 0x000331AD
		public override long Position
		{
			get
			{
				return this.input.Position;
			}
			set
			{
				this.input.Position = value;
			}
		}

		// Token: 0x060011A9 RID: 4521 RVA: 0x00034FBC File Offset: 0x000331BC
		public RLEDecompressingInputStream(global::System.IO.Stream input)
		{
			this.input = input;
			this.buf = new byte[4096];
			this.pos = 0;
			int num = input.ReadByte();
			if (num != 1)
			{
				throw new global::System.ArgumentException(string.Format("Header byte 0x01 expected, received 0x{0:X2}", num & 255));
			}
			this.len = this.ReadChunk();
		}

		// Token: 0x060011AA RID: 4522 RVA: 0x00035020 File Offset: 0x00033220
		public override int Read()
		{
			if (this.len == -1)
			{
				return -1;
			}
			if (this.pos >= this.len && (this.len = this.ReadChunk()) == -1)
			{
				return -1;
			}
			byte[] array = this.buf;
			int num = this.pos;
			this.pos = num + 1;
			return array[num];
		}

		// Token: 0x060011AB RID: 4523 RVA: 0x0002B8CF File Offset: 0x00029ACF
		public override int Read(byte[] b)
		{
			return this.Read(b, 0, b.Length);
		}

		// Token: 0x060011AC RID: 4524 RVA: 0x00035074 File Offset: 0x00033274
		public override int Read(byte[] b, int off, int l)
		{
			if (this.len == -1)
			{
				return -1;
			}
			int num = off;
			int i = l;
			while (i > 0)
			{
				if (this.pos >= this.len && (this.len = this.ReadChunk()) == -1)
				{
					if (num <= off)
					{
						return -1;
					}
					return num - off;
				}
				else
				{
					int num2 = global::System.Math.Min(i, this.len - this.pos);
					global::System.Array.Copy(this.buf, this.pos, b, num, num2);
					this.pos += num2;
					i -= num2;
					num += num2;
				}
			}
			return l;
		}

		// Token: 0x060011AD RID: 4525 RVA: 0x00035100 File Offset: 0x00033300
		public override long Skip(long n)
		{
			int num2;
			for (long num = n; num > 0L; num -= (long)num2)
			{
				if (this.pos >= this.len && (this.len = this.ReadChunk()) == -1)
				{
					return -1L;
				}
				num2 = (int)global::System.Math.Min(n, (long)(this.len - this.pos));
				this.pos += num2;
			}
			return n;
		}

		// Token: 0x060011AE RID: 4526 RVA: 0x00035163 File Offset: 0x00033363
		public override int Available()
		{
			if (this.len <= 0)
			{
				return 0;
			}
			return this.len - this.pos;
		}

		// Token: 0x060011AF RID: 4527 RVA: 0x0003517D File Offset: 0x0003337D
		public override void Close()
		{
			this.input.Close();
		}

		// Token: 0x060011B0 RID: 4528 RVA: 0x0003518C File Offset: 0x0003338C
		private int ReadChunk()
		{
			this.pos = 0;
			int num = this.ReadShort(this.input);
			if (num == -1)
			{
				return -1;
			}
			int num2 = (num & 4095) + 1;
			if ((num & 28672) != 12288)
			{
				throw new global::System.ArgumentException(string.Format("Chunksize header A should be 0x3000, received 0x{0:X4}", num & 57344));
			}
			if ((num & 32768) != 0)
			{
				int i = 0;
				int num3 = 0;
				while (i < num2)
				{
					int num4 = this.input.ReadByte();
					i++;
					if (num4 == -1)
					{
						break;
					}
					int num5 = 0;
					while (num5 < 8 && i < num2)
					{
						if ((num4 & global::NPOI.Util.RLEDecompressingInputStream.POWER2[num5]) == 0)
						{
							int num6 = this.input.ReadByte();
							if (num6 == -1)
							{
								return -1;
							}
							this.buf[num3++] = (byte)num6;
							i++;
						}
						else
						{
							int num7 = this.ReadShort(this.input);
							if (num7 == -1)
							{
								return -1;
							}
							i += 2;
							int copyLenBits = global::NPOI.Util.RLEDecompressingInputStream.GetCopyLenBits(num3 - 1);
							int num8 = (num7 >> copyLenBits) + 1;
							int num9 = (num7 & global::NPOI.Util.RLEDecompressingInputStream.POWER2[copyLenBits] - 1) + 3;
							int num10 = num3 - num8;
							int num11 = num10 + num9;
							for (int j = num10; j < num11; j++)
							{
								this.buf[num3++] = this.buf[j];
							}
						}
						num5++;
					}
				}
				return num3;
			}
			if (this.input.Read(this.buf, 0, num2) < num2)
			{
				throw new global::System.InvalidOperationException(string.Format("Not enough bytes Read, expected {0}", num2));
			}
			return num2;
		}

		// Token: 0x060011B1 RID: 4529 RVA: 0x00035310 File Offset: 0x00033510
		private static int GetCopyLenBits(int offset)
		{
			for (int i = 11; i >= 4; i--)
			{
				if ((offset & global::NPOI.Util.RLEDecompressingInputStream.POWER2[i]) != 0)
				{
					return 15 - i;
				}
			}
			return 12;
		}

		// Token: 0x060011B2 RID: 4530 RVA: 0x0003533C File Offset: 0x0003353C
		public int ReadShort()
		{
			return this.ReadShort(this);
		}

		// Token: 0x060011B3 RID: 4531 RVA: 0x00035345 File Offset: 0x00033545
		public int ReadInt()
		{
			return this.ReadInt(this);
		}

		// Token: 0x060011B4 RID: 4532 RVA: 0x00035350 File Offset: 0x00033550
		private int ReadShort(global::System.IO.Stream stream)
		{
			int num;
			if ((num = stream.ReadByte()) == -1)
			{
				return -1;
			}
			int num2;
			if ((num2 = stream.ReadByte()) == -1)
			{
				return -1;
			}
			return (num & 255) | (num2 & 255) << 8;
		}

		// Token: 0x060011B5 RID: 4533 RVA: 0x00035388 File Offset: 0x00033588
		private int ReadInt(global::NPOI.Util.InputStream stream)
		{
			int num;
			if ((num = stream.Read()) == -1)
			{
				return -1;
			}
			int num2;
			if ((num2 = stream.Read()) == -1)
			{
				return -1;
			}
			int num3;
			if ((num3 = stream.Read()) == -1)
			{
				return -1;
			}
			int num4;
			if ((num4 = stream.Read()) == -1)
			{
				return -1;
			}
			return (num & 255) | (num2 & 255) << 8 | (num3 & 255) << 16 | (num4 & 255) << 24;
		}

		// Token: 0x060011B6 RID: 4534 RVA: 0x000353F0 File Offset: 0x000335F0
		public static byte[] Decompress(byte[] compressed)
		{
			return global::NPOI.Util.RLEDecompressingInputStream.Decompress(compressed, 0, compressed.Length);
		}

		// Token: 0x060011B7 RID: 4535 RVA: 0x000353FC File Offset: 0x000335FC
		public static byte[] Decompress(byte[] compressed, int offset, int length)
		{
			global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream();
			global::NPOI.Util.RLEDecompressingInputStream rledecompressingInputStream = new global::NPOI.Util.RLEDecompressingInputStream(new global::System.IO.MemoryStream(compressed, offset, length));
			global::NPOI.Util.IOUtils.Copy(rledecompressingInputStream, memoryStream);
			rledecompressingInputStream.Close();
			memoryStream.Close();
			return memoryStream.ToArray();
		}

		// Token: 0x060011B8 RID: 4536 RVA: 0x00035434 File Offset: 0x00033634
		public override void Flush()
		{
			this.input.Flush();
		}

		// Token: 0x060011B9 RID: 4537 RVA: 0x00035441 File Offset: 0x00033641
		public override long Seek(long offset, global::System.IO.SeekOrigin origin)
		{
			return this.input.Seek(offset, origin);
		}

		// Token: 0x060011BA RID: 4538 RVA: 0x00035450 File Offset: 0x00033650
		public override void SetLength(long value)
		{
			this.input.SetLength(value);
		}

		// Token: 0x060011BB RID: 4539 RVA: 0x0003545E File Offset: 0x0003365E
		public override void Write(byte[] buffer, int offset, int count)
		{
			this.input.Write(buffer, offset, count);
		}

		// Token: 0x04000765 RID: 1893
		private static int[] POWER2 = new int[]
		{
			1,
			2,
			4,
			8,
			16,
			32,
			64,
			128,
			256,
			512,
			1024,
			2048,
			4096,
			8192,
			16384,
			32768
		};

		// Token: 0x04000766 RID: 1894
		private global::System.IO.Stream input;

		// Token: 0x04000767 RID: 1895
		private byte[] buf;

		// Token: 0x04000768 RID: 1896
		private int pos;

		// Token: 0x04000769 RID: 1897
		private int len;
	}
}
