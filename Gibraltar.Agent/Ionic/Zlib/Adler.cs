using System;

namespace Ionic.Zlib
{
	// Token: 0x0200043B RID: 1083
	internal sealed class Adler
	{
		// Token: 0x06002EC9 RID: 11977 RVA: 0x000A36CC File Offset: 0x000A18CC
		public static uint Adler32(uint adler, byte[] buf, int index, int len)
		{
			if (buf == null)
			{
				return 1U;
			}
			uint num = adler & 65535U;
			uint num2 = adler >> 16 & 65535U;
			while (len > 0)
			{
				int i = (len < global::Ionic.Zlib.Adler.NMAX) ? len : global::Ionic.Zlib.Adler.NMAX;
				len -= i;
				while (i >= 16)
				{
					num += (uint)buf[index++];
					num2 += num;
					num += (uint)buf[index++];
					num2 += num;
					num += (uint)buf[index++];
					num2 += num;
					num += (uint)buf[index++];
					num2 += num;
					num += (uint)buf[index++];
					num2 += num;
					num += (uint)buf[index++];
					num2 += num;
					num += (uint)buf[index++];
					num2 += num;
					num += (uint)buf[index++];
					num2 += num;
					num += (uint)buf[index++];
					num2 += num;
					num += (uint)buf[index++];
					num2 += num;
					num += (uint)buf[index++];
					num2 += num;
					num += (uint)buf[index++];
					num2 += num;
					num += (uint)buf[index++];
					num2 += num;
					num += (uint)buf[index++];
					num2 += num;
					num += (uint)buf[index++];
					num2 += num;
					num += (uint)buf[index++];
					num2 += num;
					i -= 16;
				}
				if (i != 0)
				{
					do
					{
						num += (uint)buf[index++];
						num2 += num;
					}
					while (--i != 0);
				}
				num %= global::Ionic.Zlib.Adler.BASE;
				num2 %= global::Ionic.Zlib.Adler.BASE;
			}
			return num2 << 16 | num;
		}

		// Token: 0x040010AF RID: 4271
		private static readonly uint BASE = 65521U;

		// Token: 0x040010B0 RID: 4272
		private static readonly int NMAX = 5552;
	}
}
