using System;
using System.IO;
using NPOI.Util;

namespace NPOI.POIFS.Crypt.Standard
{
	// Token: 0x0200030D RID: 781
	public class CipherInputStream : global::NPOI.Util.ByteArrayInputStream
	{
		// Token: 0x0600169D RID: 5789 RVA: 0x0004332D File Offset: 0x0004152D
		public CipherInputStream(global::NPOI.Util.ByteArrayInputStream paramInputStream, global::NPOI.POIFS.Crypt.Cipher paramCipher)
		{
			this.input = paramInputStream;
			this.cipher = paramCipher;
		}

		// Token: 0x0600169E RID: 5790 RVA: 0x00043350 File Offset: 0x00041550
		protected CipherInputStream(global::NPOI.Util.ByteArrayInputStream paramInputStream)
		{
			this.input = paramInputStream;
			this.cipher = new global::NPOI.POIFS.Crypt.Standard.NullCipher();
		}

		// Token: 0x0600169F RID: 5791 RVA: 0x00043378 File Offset: 0x00041578
		private int getMoreData()
		{
			if (this.done)
			{
				return -1;
			}
			int num = this.input.Read(this.ibuffer, 0, this.ibuffer.Length);
			if (num != -1)
			{
				try
				{
					this.obuffer = this.cipher.Update(this.ibuffer, 0, num);
				}
				catch (global::System.Exception ex)
				{
					this.obuffer = null;
					throw ex;
				}
				this.ostart = 0;
				if (this.obuffer == null)
				{
					this.ofinish = 0;
				}
				else
				{
					this.ofinish = this.obuffer.Length;
				}
				return this.ofinish;
			}
			this.done = true;
			try
			{
				this.obuffer = this.cipher.DoFinal();
			}
			catch (global::System.Exception ex2)
			{
				this.obuffer = null;
				throw new global::System.IO.IOException(ex2.Message);
			}
			if (this.obuffer == null)
			{
				return -1;
			}
			this.ostart = 0;
			this.ofinish = this.obuffer.Length;
			return this.ofinish;
		}

		// Token: 0x060016A0 RID: 5792 RVA: 0x0004346C File Offset: 0x0004166C
		public override int Read()
		{
			if (this.ostart >= this.ofinish)
			{
				int num;
				for (num = 0; num == 0; num = this.getMoreData())
				{
				}
				if (num == -1)
				{
					return -1;
				}
			}
			byte[] array = this.obuffer;
			int num2 = this.ostart;
			this.ostart = num2 + 1;
			return array[num2] & 255;
		}

		// Token: 0x060016A1 RID: 5793 RVA: 0x0002B8CF File Offset: 0x00029ACF
		public new int Read(byte[] b)
		{
			return this.Read(b, 0, b.Length);
		}

		// Token: 0x060016A2 RID: 5794 RVA: 0x000434BC File Offset: 0x000416BC
		public override int Read(byte[] b, int off, int len)
		{
			int num;
			if (this.ostart >= this.ofinish)
			{
				for (num = 0; num == 0; num = this.getMoreData())
				{
				}
				if (num == -1)
				{
					return -1;
				}
			}
			if (len <= 0)
			{
				return 0;
			}
			num = this.ofinish - this.ostart;
			if (len < num)
			{
				num = len;
			}
			if (b != null)
			{
				global::System.Array.Copy(this.obuffer, this.ostart, b, off, num);
			}
			this.ostart += num;
			return num;
		}

		// Token: 0x060016A3 RID: 5795 RVA: 0x0004352C File Offset: 0x0004172C
		public new long Skip(long paramLong)
		{
			int num = this.ofinish - this.ostart;
			if (paramLong > (long)num)
			{
				paramLong = (long)num;
			}
			if (paramLong < 0L)
			{
				return 0L;
			}
			this.ostart = (int)((long)this.ostart + paramLong);
			return paramLong;
		}

		// Token: 0x060016A4 RID: 5796 RVA: 0x00043569 File Offset: 0x00041769
		public override int Available()
		{
			return this.ofinish - this.ostart;
		}

		// Token: 0x060016A5 RID: 5797 RVA: 0x00043578 File Offset: 0x00041778
		public override void Close()
		{
			if (this.closed)
			{
				return;
			}
			this.closed = true;
			this.input.Close();
			if (!this.done)
			{
				try
				{
					this.cipher.DoFinal();
				}
				catch (global::System.Exception)
				{
				}
			}
			this.ostart = 0;
			this.ofinish = 0;
		}

		// Token: 0x060016A6 RID: 5798 RVA: 0x00006EB4 File Offset: 0x000050B4
		public new bool MarkSupported()
		{
			return false;
		}

		// Token: 0x0400094E RID: 2382
		private global::NPOI.POIFS.Crypt.Cipher cipher;

		// Token: 0x0400094F RID: 2383
		private global::NPOI.Util.ByteArrayInputStream input;

		// Token: 0x04000950 RID: 2384
		private byte[] ibuffer = new byte[63];

		// Token: 0x04000951 RID: 2385
		private bool done;

		// Token: 0x04000952 RID: 2386
		private byte[] obuffer;

		// Token: 0x04000953 RID: 2387
		private int ostart;

		// Token: 0x04000954 RID: 2388
		private int ofinish;

		// Token: 0x04000955 RID: 2389
		private bool closed;
	}
}
