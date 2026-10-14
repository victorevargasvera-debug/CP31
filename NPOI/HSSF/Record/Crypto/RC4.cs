using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record.Crypto
{
	// Token: 0x02000450 RID: 1104
	internal class RC4
	{
		// Token: 0x060028D1 RID: 10449 RVA: 0x0007B4F4 File Offset: 0x000796F4
		public RC4(byte[] key)
		{
			int num = key.Length;
			for (int i = 0; i < 256; i++)
			{
				this._s[i] = (byte)i;
			}
			int j = 0;
			int num2 = 0;
			while (j < 256)
			{
				num2 = (num2 + (int)key[j % num] + (int)this._s[j] & 255);
				byte b = this._s[j];
				this._s[j] = this._s[num2];
				this._s[num2] = b;
				j++;
			}
			this._i = 0;
			this._j = 0;
		}

		// Token: 0x060028D2 RID: 10450 RVA: 0x0007B590 File Offset: 0x00079790
		public byte Output()
		{
			this._i = (this._i + 1 & 255);
			this._j = (this._j + (int)this._s[this._i] & 255);
			byte b = this._s[this._i];
			this._s[this._i] = this._s[this._j];
			this._s[this._j] = b;
			return this._s[(int)(this._s[this._i] + this._s[this._j] & byte.MaxValue)];
		}

		// Token: 0x060028D3 RID: 10451 RVA: 0x0007B630 File Offset: 0x00079830
		public void Encrypt(byte[] in1)
		{
			for (int i = 0; i < in1.Length; i++)
			{
				in1[i] ^= this.Output();
			}
		}

		// Token: 0x060028D4 RID: 10452 RVA: 0x0007B65C File Offset: 0x0007985C
		public void Encrypt(byte[] in1, int OffSet, int len)
		{
			int num = OffSet + len;
			for (int i = OffSet; i < num; i++)
			{
				in1[i] ^= this.Output();
			}
		}

		// Token: 0x060028D5 RID: 10453 RVA: 0x0007B688 File Offset: 0x00079888
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append(base.GetType().Name).Append(" [");
			stringBuilder.Append("i=").Append(this._i);
			stringBuilder.Append(" j=").Append(this._j);
			stringBuilder.Append("]");
			stringBuilder.Append("\n");
			stringBuilder.Append(global::NPOI.Util.HexDump.Dump(this._s, 0L, 0));
			return stringBuilder.ToString();
		}

		// Token: 0x0400118B RID: 4491
		private int _i;

		// Token: 0x0400118C RID: 4492
		private int _j;

		// Token: 0x0400118D RID: 4493
		private byte[] _s = new byte[256];
	}
}
