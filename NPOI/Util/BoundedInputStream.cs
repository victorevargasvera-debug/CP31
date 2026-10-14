using System;

namespace NPOI.Util
{
	// Token: 0x02000257 RID: 599
	public class BoundedInputStream : global::NPOI.Util.ByteArrayInputStream
	{
		// Token: 0x06000EB1 RID: 3761 RVA: 0x0002B871 File Offset: 0x00029A71
		public BoundedInputStream(global::NPOI.Util.ByteArrayInputStream in1, long size)
		{
			this.IsPropagateClose = true;
			this.max = size;
			this.in1 = in1;
		}

		// Token: 0x06000EB2 RID: 3762 RVA: 0x0002B88E File Offset: 0x00029A8E
		public BoundedInputStream(global::NPOI.Util.ByteArrayInputStream in1) : this(in1, -1L)
		{
		}

		// Token: 0x06000EB3 RID: 3763 RVA: 0x0002B899 File Offset: 0x00029A99
		public override int Read()
		{
			if (this.max >= 0L && (long)this.pos == this.max)
			{
				return -1;
			}
			int result = this.in1.Read();
			this.pos++;
			return result;
		}

		// Token: 0x06000EB4 RID: 3764 RVA: 0x0002B8CF File Offset: 0x00029ACF
		public override int Read(byte[] b)
		{
			return this.Read(b, 0, b.Length);
		}

		// Token: 0x06000EB5 RID: 3765 RVA: 0x0002B8DC File Offset: 0x00029ADC
		public override int Read(byte[] b, int off, int len)
		{
			if (this.max >= 0L && (long)this.pos >= this.max)
			{
				return -1;
			}
			long num = (this.max >= 0L) ? global::System.Math.Min((long)len, this.max - (long)this.pos) : ((long)len);
			int num2 = this.in1.Read(b, off, (int)num);
			if (num2 == -1)
			{
				return -1;
			}
			this.pos += num2;
			return num2;
		}

		// Token: 0x06000EB6 RID: 3766 RVA: 0x0002B94D File Offset: 0x00029B4D
		public override void Close()
		{
			if (this.IsPropagateClose)
			{
				this.in1.Close();
			}
		}

		// Token: 0x06000EB7 RID: 3767 RVA: 0x0002B962 File Offset: 0x00029B62
		public override void Reset()
		{
			this.in1.Reset();
			this.pos = this.mark;
		}

		// Token: 0x06000EB8 RID: 3768 RVA: 0x0002B97B File Offset: 0x00029B7B
		public override void Mark(int readlimit)
		{
			this.in1.Mark(readlimit);
			this.mark = this.pos;
		}

		// Token: 0x06000EB9 RID: 3769 RVA: 0x0002B995 File Offset: 0x00029B95
		public override bool MarkSupported()
		{
			return this.in1.MarkSupported();
		}

		// Token: 0x1700031B RID: 795
		// (get) Token: 0x06000EBA RID: 3770 RVA: 0x0002B9A2 File Offset: 0x00029BA2
		// (set) Token: 0x06000EBB RID: 3771 RVA: 0x0002B9AA File Offset: 0x00029BAA
		public bool IsPropagateClose { get; set; }

		// Token: 0x040006AB RID: 1707
		private global::NPOI.Util.ByteArrayInputStream in1;

		// Token: 0x040006AC RID: 1708
		private long max;
	}
}
