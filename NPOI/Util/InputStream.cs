using System;
using System.IO;

namespace NPOI.Util
{
	// Token: 0x0200026C RID: 620
	public abstract class InputStream : global::System.IO.Stream
	{
		// Token: 0x0600103C RID: 4156
		public abstract int Read();

		// Token: 0x0600103D RID: 4157 RVA: 0x0002B8CF File Offset: 0x00029ACF
		public virtual int Read(byte[] b)
		{
			return this.Read(b, 0, b.Length);
		}

		// Token: 0x0600103E RID: 4158 RVA: 0x00031FFC File Offset: 0x000301FC
		public override int Read(byte[] b, int off, int len)
		{
			if (b == null)
			{
				throw new global::System.ArgumentNullException();
			}
			if (off < 0 || len < 0 || len > b.Length - off)
			{
				throw new global::System.IndexOutOfRangeException();
			}
			if (len == 0)
			{
				return 0;
			}
			int num = this.Read();
			if (num == -1)
			{
				return -1;
			}
			b[off] = (byte)num;
			int i = 1;
			try
			{
				while (i < len)
				{
					num = this.Read();
					if (num == -1)
					{
						break;
					}
					b[off + i] = (byte)num;
					i++;
				}
			}
			catch (global::System.IO.IOException)
			{
			}
			return i;
		}

		// Token: 0x0600103F RID: 4159 RVA: 0x00032074 File Offset: 0x00030274
		public virtual long Skip(long n)
		{
			long num = n;
			if (n <= 0L)
			{
				return 0L;
			}
			int num2 = (int)global::System.Math.Min((long)global::NPOI.Util.InputStream.MAX_SKIP_BUFFER_SIZE, num);
			byte[] buffer = new byte[num2];
			while (num > 0L)
			{
				int num3 = this.Read(buffer, 0, (int)global::System.Math.Min((long)num2, num));
				if (num3 < 0)
				{
					break;
				}
				num -= (long)num3;
			}
			return n - num;
		}

		// Token: 0x06001040 RID: 4160 RVA: 0x00006EB4 File Offset: 0x000050B4
		public virtual int Available()
		{
			return 0;
		}

		// Token: 0x06001041 RID: 4161 RVA: 0x00019A7F File Offset: 0x00017C7F
		public override void Close()
		{
		}

		// Token: 0x06001042 RID: 4162 RVA: 0x00019A7F File Offset: 0x00017C7F
		public virtual void Mark(int readlimit)
		{
		}

		// Token: 0x06001043 RID: 4163 RVA: 0x000320C5 File Offset: 0x000302C5
		public virtual void Reset()
		{
			throw new global::System.IO.IOException("mark/reset not supported");
		}

		// Token: 0x06001044 RID: 4164 RVA: 0x00006EB4 File Offset: 0x000050B4
		public virtual bool MarkSupported()
		{
			return false;
		}

		// Token: 0x0400072B RID: 1835
		private static int MAX_SKIP_BUFFER_SIZE = 2048;
	}
}
