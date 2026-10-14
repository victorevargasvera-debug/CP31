using System;
using System.IO;
using NPOI.Util;

namespace NPOI.POIFS.Crypt.Standard
{
	// Token: 0x02000314 RID: 788
	internal class CipherOutputStream : global::NPOI.Util.ByteArrayOutputStream
	{
		// Token: 0x060016D9 RID: 5849 RVA: 0x00043CE9 File Offset: 0x00041EE9
		public CipherOutputStream(global::System.IO.FileStream rawStream, global::NPOI.POIFS.Crypt.Cipher cipher)
		{
			this.output = rawStream;
			this.cipher = cipher;
		}

		// Token: 0x060016DA RID: 5850 RVA: 0x00043D0B File Offset: 0x00041F0B
		protected CipherOutputStream(global::System.IO.FileStream rawStream)
		{
			this.output = rawStream;
			this.cipher = new global::NPOI.POIFS.Crypt.Standard.NullCipher();
		}

		// Token: 0x060016DB RID: 5851 RVA: 0x00043D34 File Offset: 0x00041F34
		public override void Write(int paramInt)
		{
			this.ibuffer[0] = (byte)paramInt;
			this.obuffer = this.cipher.Update(this.ibuffer, 0, 1);
			if (this.obuffer != null)
			{
				this.output.Write(this.obuffer, 0, this.obuffer.Length);
				this.obuffer = null;
			}
		}

		// Token: 0x060016DC RID: 5852 RVA: 0x0002BC27 File Offset: 0x00029E27
		public override void Write(byte[] b)
		{
			this.Write(b, 0, b.Length);
		}

		// Token: 0x060016DD RID: 5853 RVA: 0x00043D90 File Offset: 0x00041F90
		public override void Write(byte[] b, int off, int len)
		{
			this.obuffer = this.cipher.Update(b, off, len);
			if (this.obuffer != null)
			{
				this.output.Write(this.obuffer, 0, this.obuffer.Length);
				this.output.Flush();
				this.obuffer = null;
			}
		}

		// Token: 0x060016DE RID: 5854 RVA: 0x00043DE5 File Offset: 0x00041FE5
		public override void Flush()
		{
			if (this.obuffer != null)
			{
				this.output.Write(this.obuffer, 0, this.obuffer.Length);
				this.obuffer = null;
			}
			this.output.Flush();
		}

		// Token: 0x060016DF RID: 5855 RVA: 0x00043E1C File Offset: 0x0004201C
		public override void Close()
		{
			if (this.closed)
			{
				return;
			}
			this.closed = true;
			try
			{
				this.obuffer = this.cipher.DoFinal();
			}
			catch (global::System.Exception)
			{
				this.obuffer = null;
			}
			try
			{
				this.Flush();
			}
			catch (global::System.IO.IOException)
			{
			}
			this.Close();
		}

		// Token: 0x0400095E RID: 2398
		private byte[] ibuffer = new byte[1];

		// Token: 0x0400095F RID: 2399
		private byte[] obuffer;

		// Token: 0x04000960 RID: 2400
		private bool closed;

		// Token: 0x04000961 RID: 2401
		private global::System.IO.FileStream output;

		// Token: 0x04000962 RID: 2402
		private global::NPOI.POIFS.Crypt.Cipher cipher;
	}
}
