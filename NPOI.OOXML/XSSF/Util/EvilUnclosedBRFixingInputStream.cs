using System;
using System.Collections.Generic;
using System.IO;

namespace NPOI.XSSF.Util
{
	// Token: 0x02000059 RID: 89
	public class EvilUnclosedBRFixingInputStream : global::System.IO.Stream
	{
		// Token: 0x060003FC RID: 1020 RVA: 0x0001013C File Offset: 0x0000E33C
		public EvilUnclosedBRFixingInputStream(global::System.IO.Stream source)
		{
			this.source = source;
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x0001014B File Offset: 0x0000E34B
		public int Read()
		{
			return this.source.ReadByte();
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x00010158 File Offset: 0x0000E358
		public override int Read(byte[] b, int off, int len)
		{
			int num = this.ReadFromSpare(b, off, len);
			int num2 = this.source.Read(b, off + num, len - num);
			int num3;
			if (num2 == -1 || num2 == 0)
			{
				if (num == 0)
				{
					return num2;
				}
				num3 = num;
			}
			else
			{
				num3 = num + num2;
			}
			if (num3 > 0)
			{
				num3 = this.fixUp(b, off, num3);
			}
			return num3;
		}

		// Token: 0x060003FF RID: 1023 RVA: 0x000101A5 File Offset: 0x0000E3A5
		public int Read(byte[] b)
		{
			return this.Read(b, 0, b.Length);
		}

		// Token: 0x06000400 RID: 1024 RVA: 0x000101B4 File Offset: 0x0000E3B4
		private int ReadFromSpare(byte[] b, int offset, int len)
		{
			if (this.spare == null)
			{
				return 0;
			}
			if (len == 0)
			{
				throw new global::System.ArgumentException("Asked to read 0 bytes");
			}
			if (this.spare.Length <= len)
			{
				global::System.Array.Copy(this.spare, 0, b, offset, this.spare.Length);
				int result = this.spare.Length;
				this.spare = null;
				return result;
			}
			byte[] array = new byte[this.spare.Length - len];
			global::System.Array.Copy(this.spare, 0, b, offset, len);
			global::System.Array.Copy(this.spare, len, array, 0, array.Length);
			this.spare = array;
			return len;
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x00010244 File Offset: 0x0000E444
		private void AddToSpare(byte[] b, int offset, int len, bool atTheEnd)
		{
			if (this.spare == null)
			{
				this.spare = new byte[len];
				global::System.Array.Copy(b, offset, this.spare, 0, len);
				return;
			}
			byte[] destinationArray = new byte[this.spare.Length + len];
			if (atTheEnd)
			{
				global::System.Array.Copy(this.spare, 0, destinationArray, 0, this.spare.Length);
				global::System.Array.Copy(b, offset, destinationArray, this.spare.Length, len);
			}
			else
			{
				global::System.Array.Copy(b, offset, destinationArray, 0, len);
				global::System.Array.Copy(this.spare, 0, destinationArray, len, this.spare.Length);
			}
			this.spare = destinationArray;
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x000102DC File Offset: 0x0000E4DC
		private int fixUp(byte[] b, int offset, int read)
		{
			for (int i = 0; i < global::NPOI.XSSF.Util.EvilUnclosedBRFixingInputStream.detect.Length - 1; i++)
			{
				int num = offset + read - 1 - i;
				if (num >= 0)
				{
					bool flag = true;
					int num2 = 0;
					while (num2 <= i && flag)
					{
						if (b[num + num2] != global::NPOI.XSSF.Util.EvilUnclosedBRFixingInputStream.detect[num2])
						{
							flag = false;
						}
						num2++;
					}
					if (flag)
					{
						this.AddToSpare(b, num, i + 1, true);
						read--;
						read -= i;
						break;
					}
				}
			}
			global::System.Collections.Generic.List<int> list = new global::System.Collections.Generic.List<int>();
			for (int j = offset; j <= offset + read - global::NPOI.XSSF.Util.EvilUnclosedBRFixingInputStream.detect.Length; j++)
			{
				bool flag2 = true;
				int num3 = 0;
				while (num3 < global::NPOI.XSSF.Util.EvilUnclosedBRFixingInputStream.detect.Length && flag2)
				{
					if (b[j + num3] != global::NPOI.XSSF.Util.EvilUnclosedBRFixingInputStream.detect[num3])
					{
						flag2 = false;
					}
					num3++;
				}
				if (flag2)
				{
					list.Add(j);
				}
			}
			if (list.Count == 0)
			{
				return read;
			}
			int num4 = offset + read + list.Count;
			int num5 = num4 - b.Length;
			if (num5 > 0)
			{
				int num6 = 0;
				foreach (int num7 in list)
				{
					if (num7 > offset + read - global::NPOI.XSSF.Util.EvilUnclosedBRFixingInputStream.detect.Length - num5 - num6)
					{
						num5 = num4 - num7 - 1 - num6;
						break;
					}
					num6++;
				}
				this.AddToSpare(b, offset + read - num5, num5, false);
				read -= num5;
			}
			for (int k = list.Count - 1; k >= 0; k--)
			{
				int num8 = list[k];
				if (num8 < read + offset && num8 <= read - 3)
				{
					byte[] array = new byte[read - num8 - 3];
					global::System.Array.Copy(b, num8 + 3, array, 0, array.Length);
					b[num8 + 3] = 47;
					global::System.Array.Copy(array, 0, b, num8 + 4, array.Length);
					read++;
				}
			}
			return read;
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x06000403 RID: 1027 RVA: 0x00006FBA File Offset: 0x000051BA
		public override bool CanRead
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x06000404 RID: 1028 RVA: 0x00006FBA File Offset: 0x000051BA
		public override bool CanSeek
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x06000405 RID: 1029 RVA: 0x00005008 File Offset: 0x00003208
		public override bool CanWrite
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000406 RID: 1030 RVA: 0x000029BF File Offset: 0x00000BBF
		public override void Flush()
		{
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x06000407 RID: 1031 RVA: 0x000104B8 File Offset: 0x0000E6B8
		public override long Length
		{
			get
			{
				return this.source.Length;
			}
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x06000408 RID: 1032 RVA: 0x000104C5 File Offset: 0x0000E6C5
		// (set) Token: 0x06000409 RID: 1033 RVA: 0x000104D2 File Offset: 0x0000E6D2
		public override long Position
		{
			get
			{
				return this.source.Position;
			}
			set
			{
				this.source.Position = value;
			}
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x000104E0 File Offset: 0x0000E6E0
		public override long Seek(long offset, global::System.IO.SeekOrigin origin)
		{
			return this.source.Seek(offset, origin);
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x000104EF File Offset: 0x0000E6EF
		public override void SetLength(long value)
		{
			throw new global::System.InvalidOperationException();
		}

		// Token: 0x0600040C RID: 1036 RVA: 0x000104EF File Offset: 0x0000E6EF
		public override void Write(byte[] buffer, int offset, int count)
		{
			throw new global::System.InvalidOperationException();
		}

		// Token: 0x0400024E RID: 590
		private global::System.IO.Stream source;

		// Token: 0x0400024F RID: 591
		private byte[] spare;

		// Token: 0x04000250 RID: 592
		private static byte[] detect = new byte[]
		{
			60,
			98,
			114,
			62
		};
	}
}
