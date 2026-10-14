using System;

namespace Org.BouncyCastle.Utilities.Zlib
{
	// Token: 0x0200003D RID: 61
	internal sealed class Adler32
	{
		// Token: 0x060002C0 RID: 704 RVA: 0x0000CB4C File Offset: 0x0000AD4C
		internal long adler32(long adler, byte[] buf, int index, int len)
		{
			if (buf == null)
			{
				return 1L;
			}
			long s = adler & 65535L;
			long s2 = adler >> 16 & 65535L;
			while (len > 0)
			{
				int i = (len < 5552) ? len : 5552;
				len -= i;
				while (i >= 16)
				{
					s += (long)(buf[index++] & byte.MaxValue);
					s2 += s;
					s += (long)(buf[index++] & byte.MaxValue);
					s2 += s;
					s += (long)(buf[index++] & byte.MaxValue);
					s2 += s;
					s += (long)(buf[index++] & byte.MaxValue);
					s2 += s;
					s += (long)(buf[index++] & byte.MaxValue);
					s2 += s;
					s += (long)(buf[index++] & byte.MaxValue);
					s2 += s;
					s += (long)(buf[index++] & byte.MaxValue);
					s2 += s;
					s += (long)(buf[index++] & byte.MaxValue);
					s2 += s;
					s += (long)(buf[index++] & byte.MaxValue);
					s2 += s;
					s += (long)(buf[index++] & byte.MaxValue);
					s2 += s;
					s += (long)(buf[index++] & byte.MaxValue);
					s2 += s;
					s += (long)(buf[index++] & byte.MaxValue);
					s2 += s;
					s += (long)(buf[index++] & byte.MaxValue);
					s2 += s;
					s += (long)(buf[index++] & byte.MaxValue);
					s2 += s;
					s += (long)(buf[index++] & byte.MaxValue);
					s2 += s;
					s += (long)(buf[index++] & byte.MaxValue);
					s2 += s;
					i -= 16;
				}
				if (i != 0)
				{
					do
					{
						s += (long)(buf[index++] & byte.MaxValue);
						s2 += s;
					}
					while (--i != 0);
				}
				s %= 65521L;
				s2 %= 65521L;
			}
			return s2 << 16 | s;
		}

		// Token: 0x040000FB RID: 251
		private const int BASE = 65521;

		// Token: 0x040000FC RID: 252
		private const int NMAX = 5552;
	}
}
