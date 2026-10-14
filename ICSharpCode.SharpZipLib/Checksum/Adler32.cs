using System;

namespace ICSharpCode.SharpZipLib.Checksum
{
	// Token: 0x02000070 RID: 112
	public sealed class Adler32 : global::ICSharpCode.SharpZipLib.Checksum.IChecksum
	{
		// Token: 0x06000493 RID: 1171 RVA: 0x000142C5 File Offset: 0x000124C5
		public Adler32()
		{
			this.Reset();
		}

		// Token: 0x06000494 RID: 1172 RVA: 0x000142D3 File Offset: 0x000124D3
		public void Reset()
		{
			this.checkValue = 1U;
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x06000495 RID: 1173 RVA: 0x000142DC File Offset: 0x000124DC
		public long Value
		{
			get
			{
				return (long)((ulong)this.checkValue);
			}
		}

		// Token: 0x06000496 RID: 1174 RVA: 0x000142E8 File Offset: 0x000124E8
		public void Update(int bval)
		{
			uint num = this.checkValue & 65535U;
			uint num2 = this.checkValue >> 16;
			num = (num + (uint)(bval & 255)) % global::ICSharpCode.SharpZipLib.Checksum.Adler32.BASE;
			num2 = (num + num2) % global::ICSharpCode.SharpZipLib.Checksum.Adler32.BASE;
			this.checkValue = (num2 << 16) + num;
		}

		// Token: 0x06000497 RID: 1175 RVA: 0x00014332 File Offset: 0x00012532
		public void Update(byte[] buffer)
		{
			if (buffer == null)
			{
				throw new global::System.ArgumentNullException("buffer");
			}
			this.Update(new global::System.ArraySegment<byte>(buffer, 0, buffer.Length));
		}

		// Token: 0x06000498 RID: 1176 RVA: 0x00014354 File Offset: 0x00012554
		public void Update(global::System.ArraySegment<byte> segment)
		{
			uint num = this.checkValue & 65535U;
			uint num2 = this.checkValue >> 16;
			int i = segment.Count;
			int offset = segment.Offset;
			while (i > 0)
			{
				int num3 = 3800;
				if (num3 > i)
				{
					num3 = i;
				}
				i -= num3;
				while (--num3 >= 0)
				{
					num += (uint)(segment.Array[offset++] & byte.MaxValue);
					num2 += num;
				}
				num %= global::ICSharpCode.SharpZipLib.Checksum.Adler32.BASE;
				num2 %= global::ICSharpCode.SharpZipLib.Checksum.Adler32.BASE;
			}
			this.checkValue = (num2 << 16 | num);
		}

		// Token: 0x040002A8 RID: 680
		private static readonly uint BASE = 65521U;

		// Token: 0x040002A9 RID: 681
		private uint checkValue;
	}
}
