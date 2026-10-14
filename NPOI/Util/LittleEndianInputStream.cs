using System;
using System.IO;

namespace NPOI.Util
{
	// Token: 0x02000276 RID: 630
	public class LittleEndianInputStream : global::NPOI.Util.ILittleEndianInput
	{
		// Token: 0x060010B9 RID: 4281 RVA: 0x000331CA File Offset: 0x000313CA
		public int Read(byte[] b)
		{
			return this.Read(b, 0, b.Length);
		}

		// Token: 0x060010BA RID: 4282 RVA: 0x000331D7 File Offset: 0x000313D7
		public int Read(byte[] b, int off, int len)
		{
			return this.in1.Read(b, off, len);
		}

		// Token: 0x060010BB RID: 4283 RVA: 0x000331E7 File Offset: 0x000313E7
		public void Mark(int readlimit)
		{
			this.readLimit = readlimit;
			this.markPos = this.in1.Position;
		}

		// Token: 0x060010BC RID: 4284 RVA: 0x00033201 File Offset: 0x00031401
		public void Reset()
		{
			this.in1.Seek(this.markPos - this.in1.Position, global::System.IO.SeekOrigin.Current);
		}

		// Token: 0x060010BD RID: 4285 RVA: 0x00033222 File Offset: 0x00031422
		public long Skip(long n)
		{
			return this.in1.Seek(n, global::System.IO.SeekOrigin.Current);
		}

		// Token: 0x060010BE RID: 4286 RVA: 0x00033231 File Offset: 0x00031431
		public int Available()
		{
			return (int)(this.in1.Length - this.in1.Position);
		}

		// Token: 0x060010BF RID: 4287 RVA: 0x0003324B File Offset: 0x0003144B
		public LittleEndianInputStream(global::System.IO.Stream is1)
		{
			this.in1 = is1;
		}

		// Token: 0x060010C0 RID: 4288 RVA: 0x00033269 File Offset: 0x00031469
		public int ReadByte()
		{
			return (int)((byte)this.ReadUByte());
		}

		// Token: 0x060010C1 RID: 4289 RVA: 0x00033274 File Offset: 0x00031474
		public int ReadUByte()
		{
			int num;
			try
			{
				num = this.in1.ReadByte();
			}
			catch (global::System.IO.IOException e)
			{
				throw new global::NPOI.Util.RuntimeException(e);
			}
			global::NPOI.Util.LittleEndianInputStream.CheckEOF(num);
			return num;
		}

		// Token: 0x060010C2 RID: 4290 RVA: 0x000332AC File Offset: 0x000314AC
		public double ReadDouble()
		{
			return global::System.BitConverter.Int64BitsToDouble(this.ReadLong());
		}

		// Token: 0x060010C3 RID: 4291 RVA: 0x000332BC File Offset: 0x000314BC
		public int ReadInt()
		{
			int num;
			int num2;
			int num3;
			int num4;
			try
			{
				num = this.in1.ReadByte();
				num2 = this.in1.ReadByte();
				num3 = this.in1.ReadByte();
				num4 = this.in1.ReadByte();
			}
			catch (global::System.IO.IOException e)
			{
				throw new global::NPOI.Util.RuntimeException(e);
			}
			global::NPOI.Util.LittleEndianInputStream.CheckEOF(num | num2 | num3 | num4);
			return (num4 << 24) + (num3 << 16) + (num2 << 8) + num;
		}

		// Token: 0x060010C4 RID: 4292 RVA: 0x0003332C File Offset: 0x0003152C
		public long ReadUInt()
		{
			return (long)this.ReadInt() & (long)((ulong)-1);
		}

		// Token: 0x060010C5 RID: 4293 RVA: 0x00033338 File Offset: 0x00031538
		public long ReadLong()
		{
			int num;
			int num2;
			int num3;
			int num4;
			int num5;
			int num6;
			int num7;
			int num8;
			try
			{
				num = this.in1.ReadByte();
				num2 = this.in1.ReadByte();
				num3 = this.in1.ReadByte();
				num4 = this.in1.ReadByte();
				num5 = this.in1.ReadByte();
				num6 = this.in1.ReadByte();
				num7 = this.in1.ReadByte();
				num8 = this.in1.ReadByte();
			}
			catch (global::System.IO.IOException e)
			{
				throw new global::NPOI.Util.RuntimeException(e);
			}
			global::NPOI.Util.LittleEndianInputStream.CheckEOF(num | num2 | num3 | num4 | num5 | num6 | num7 | num8);
			return ((long)num8 << 56) + ((long)num7 << 48) + ((long)num6 << 40) + ((long)num5 << 32) + ((long)num4 << 24) + (long)((long)num3 << 16) + (long)((long)num2 << 8) + (long)num;
		}

		// Token: 0x060010C6 RID: 4294 RVA: 0x00033408 File Offset: 0x00031608
		public short ReadShort()
		{
			return (short)this.ReadUShort();
		}

		// Token: 0x060010C7 RID: 4295 RVA: 0x00033414 File Offset: 0x00031614
		public int ReadUShort()
		{
			int num;
			int num2;
			try
			{
				num = this.in1.ReadByte();
				num2 = this.in1.ReadByte();
			}
			catch (global::System.IO.IOException e)
			{
				throw new global::NPOI.Util.RuntimeException(e);
			}
			global::NPOI.Util.LittleEndianInputStream.CheckEOF(num | num2);
			return (num2 << 8) + num;
		}

		// Token: 0x060010C8 RID: 4296 RVA: 0x00033460 File Offset: 0x00031660
		private static void CheckEOF(int value)
		{
			if (value < 0)
			{
				throw new global::NPOI.Util.RuntimeException("Unexpected end-of-file");
			}
		}

		// Token: 0x060010C9 RID: 4297 RVA: 0x00033471 File Offset: 0x00031671
		public void ReadFully(byte[] buf)
		{
			this.ReadFully(buf, 0, buf.Length);
		}

		// Token: 0x060010CA RID: 4298 RVA: 0x00033480 File Offset: 0x00031680
		public void ReadFully(byte[] buf, int off, int len)
		{
			int num = off + len;
			for (int i = off; i < num; i++)
			{
				byte b;
				try
				{
					b = (byte)this.in1.ReadByte();
				}
				catch (global::System.IO.IOException e)
				{
					throw new global::NPOI.Util.RuntimeException(e);
				}
				global::NPOI.Util.LittleEndianInputStream.CheckEOF((int)b);
				buf[i] = b;
			}
		}

		// Token: 0x060010CB RID: 4299 RVA: 0x000334D0 File Offset: 0x000316D0
		internal void Close()
		{
			this.in1.Close();
		}

		// Token: 0x0400073D RID: 1853
		private global::System.IO.Stream in1;

		// Token: 0x0400073E RID: 1854
		private int readLimit = -1;

		// Token: 0x0400073F RID: 1855
		private long markPos = -1L;
	}
}
