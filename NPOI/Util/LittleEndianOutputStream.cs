using System;
using System.IO;

namespace NPOI.Util
{
	// Token: 0x02000278 RID: 632
	public class LittleEndianOutputStream : global::NPOI.Util.ILittleEndianOutput, global::System.IDisposable
	{
		// Token: 0x060010D3 RID: 4307 RVA: 0x000334DD File Offset: 0x000316DD
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x060010D4 RID: 4308 RVA: 0x000334EC File Offset: 0x000316EC
		protected virtual void Dispose(bool disposing)
		{
			if (disposing && this.out1 != null)
			{
				this.out1.Dispose();
				this.out1 = null;
			}
		}

		// Token: 0x060010D5 RID: 4309 RVA: 0x0003350B File Offset: 0x0003170B
		public void Close()
		{
			this.Dispose();
		}

		// Token: 0x060010D6 RID: 4310 RVA: 0x00033513 File Offset: 0x00031713
		public LittleEndianOutputStream(global::System.IO.Stream out1)
		{
			this.out1 = out1;
		}

		// Token: 0x060010D7 RID: 4311 RVA: 0x00033524 File Offset: 0x00031724
		public void WriteByte(int v)
		{
			try
			{
				this.out1.WriteByte((byte)v);
			}
			catch (global::System.IO.IOException e)
			{
				throw new global::NPOI.Util.RuntimeException(e);
			}
		}

		// Token: 0x060010D8 RID: 4312 RVA: 0x00033558 File Offset: 0x00031758
		public void WriteDouble(double v)
		{
			this.WriteLong(global::System.BitConverter.DoubleToInt64Bits(v));
		}

		// Token: 0x060010D9 RID: 4313 RVA: 0x00033568 File Offset: 0x00031768
		public void WriteInt(int v)
		{
			int num = v >> 24 & 255;
			int num2 = v >> 16 & 255;
			int num3 = v >> 8 & 255;
			int num4 = v & 255;
			try
			{
				this.out1.WriteByte((byte)num4);
				this.out1.WriteByte((byte)num3);
				this.out1.WriteByte((byte)num2);
				this.out1.WriteByte((byte)num);
			}
			catch (global::System.IO.IOException e)
			{
				throw new global::NPOI.Util.RuntimeException(e);
			}
		}

		// Token: 0x060010DA RID: 4314 RVA: 0x000335EC File Offset: 0x000317EC
		public void WriteLong(long v)
		{
			this.WriteInt((int)v);
			this.WriteInt((int)(v >> 32));
		}

		// Token: 0x060010DB RID: 4315 RVA: 0x00033604 File Offset: 0x00031804
		public void WriteShort(int v)
		{
			int num = v >> 8 & 255;
			int num2 = v & 255;
			try
			{
				this.out1.WriteByte((byte)num2);
				this.out1.WriteByte((byte)num);
			}
			catch (global::System.IO.IOException e)
			{
				throw new global::NPOI.Util.RuntimeException(e);
			}
		}

		// Token: 0x060010DC RID: 4316 RVA: 0x00033658 File Offset: 0x00031858
		public void Write(byte[] b)
		{
			try
			{
				this.out1.Write(b, 0, b.Length);
			}
			catch (global::System.IO.IOException e)
			{
				throw new global::NPOI.Util.RuntimeException(e);
			}
		}

		// Token: 0x060010DD RID: 4317 RVA: 0x00033690 File Offset: 0x00031890
		public void Write(byte[] b, int off, int len)
		{
			try
			{
				this.out1.Write(b, off, len);
			}
			catch (global::System.IO.IOException e)
			{
				throw new global::NPOI.Util.RuntimeException(e);
			}
		}

		// Token: 0x060010DE RID: 4318 RVA: 0x000336C4 File Offset: 0x000318C4
		public void Flush()
		{
			this.out1.Flush();
		}

		// Token: 0x04000740 RID: 1856
		protected internal global::System.IO.Stream out1;
	}
}
