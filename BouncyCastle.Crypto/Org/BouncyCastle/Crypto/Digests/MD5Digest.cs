using System;
using Org.BouncyCastle.Crypto.Utilities;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Digests
{
	// Token: 0x020004D4 RID: 1236
	public class MD5Digest : global::Org.BouncyCastle.Crypto.Digests.GeneralDigest
	{
		// Token: 0x06003045 RID: 12357 RVA: 0x000E2B87 File Offset: 0x000E0D87
		public MD5Digest()
		{
			this.Reset();
		}

		// Token: 0x06003046 RID: 12358 RVA: 0x000E2BA2 File Offset: 0x000E0DA2
		public MD5Digest(global::Org.BouncyCastle.Crypto.Digests.MD5Digest t) : base(t)
		{
			this.CopyIn(t);
		}

		// Token: 0x06003047 RID: 12359 RVA: 0x000E2BC0 File Offset: 0x000E0DC0
		private void CopyIn(global::Org.BouncyCastle.Crypto.Digests.MD5Digest t)
		{
			base.CopyIn(t);
			this.H1 = t.H1;
			this.H2 = t.H2;
			this.H3 = t.H3;
			this.H4 = t.H4;
			global::System.Array.Copy(t.X, 0, this.X, 0, t.X.Length);
			this.xOff = t.xOff;
		}

		// Token: 0x17000671 RID: 1649
		// (get) Token: 0x06003048 RID: 12360 RVA: 0x000E2C2B File Offset: 0x000E0E2B
		public override string AlgorithmName
		{
			get
			{
				return "MD5";
			}
		}

		// Token: 0x06003049 RID: 12361 RVA: 0x000E2C32 File Offset: 0x000E0E32
		public override int GetDigestSize()
		{
			return 16;
		}

		// Token: 0x0600304A RID: 12362 RVA: 0x000E2C38 File Offset: 0x000E0E38
		internal override void ProcessWord(byte[] input, int inOff)
		{
			this.X[this.xOff] = global::Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(input, inOff);
			int num = this.xOff + 1;
			this.xOff = num;
			if (num == 16)
			{
				this.ProcessBlock();
			}
		}

		// Token: 0x0600304B RID: 12363 RVA: 0x000E2C74 File Offset: 0x000E0E74
		internal override void ProcessLength(long bitLength)
		{
			if (this.xOff > 14)
			{
				if (this.xOff == 15)
				{
					this.X[15] = 0U;
				}
				this.ProcessBlock();
			}
			for (int i = this.xOff; i < 14; i++)
			{
				this.X[i] = 0U;
			}
			this.X[14] = (uint)bitLength;
			this.X[15] = (uint)((ulong)bitLength >> 32);
		}

		// Token: 0x0600304C RID: 12364 RVA: 0x000E2CDC File Offset: 0x000E0EDC
		public override int DoFinal(byte[] output, int outOff)
		{
			base.Finish();
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_LE(this.H1, output, outOff);
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_LE(this.H2, output, outOff + 4);
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_LE(this.H3, output, outOff + 8);
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_LE(this.H4, output, outOff + 12);
			this.Reset();
			return 16;
		}

		// Token: 0x0600304D RID: 12365 RVA: 0x000E2D34 File Offset: 0x000E0F34
		public override void Reset()
		{
			base.Reset();
			this.H1 = 1732584193U;
			this.H2 = 4023233417U;
			this.H3 = 2562383102U;
			this.H4 = 271733878U;
			this.xOff = 0;
			for (int i = 0; i != this.X.Length; i++)
			{
				this.X[i] = 0U;
			}
		}

		// Token: 0x0600304E RID: 12366 RVA: 0x000E2D96 File Offset: 0x000E0F96
		private static uint RotateLeft(uint x, int n)
		{
			return x << n | x >> 32 - n;
		}

		// Token: 0x0600304F RID: 12367 RVA: 0x000E2DA8 File Offset: 0x000E0FA8
		private static uint F(uint u, uint v, uint w)
		{
			return (u & v) | (~u & w);
		}

		// Token: 0x06003050 RID: 12368 RVA: 0x000E2DB2 File Offset: 0x000E0FB2
		private static uint G(uint u, uint v, uint w)
		{
			return (u & w) | (v & ~w);
		}

		// Token: 0x06003051 RID: 12369 RVA: 0x000E2DBC File Offset: 0x000E0FBC
		private static uint H(uint u, uint v, uint w)
		{
			return u ^ v ^ w;
		}

		// Token: 0x06003052 RID: 12370 RVA: 0x000E2DC3 File Offset: 0x000E0FC3
		private static uint K(uint u, uint v, uint w)
		{
			return v ^ (u | ~w);
		}

		// Token: 0x06003053 RID: 12371 RVA: 0x000E2DCC File Offset: 0x000E0FCC
		internal override void ProcessBlock()
		{
			uint a = this.H1;
			uint b = this.H2;
			uint c = this.H3;
			uint d = this.H4;
			a = global::Org.BouncyCastle.Crypto.Digests.MD5Digest.RotateLeft(a + global::Org.BouncyCastle.Crypto.Digests.MD5Digest.F(b, c, d) + this.X[0] + 3614090360U, global::Org.BouncyCastle.Crypto.Digests.MD5Digest.S11) + b;
			d = global::Org.BouncyCastle.Crypto.Digests.MD5Digest.RotateLeft(d + global::Org.BouncyCastle.Crypto.Digests.MD5Digest.F(a, b, c) + this.X[1] + 3905402710U, global::Org.BouncyCastle.Crypto.Digests.MD5Digest.S12) + a;
			c = global::Org.BouncyCastle.Crypto.Digests.MD5Digest.RotateLeft(c + global::Org.BouncyCastle.Crypto.Digests.MD5Digest.F(d, a, b) + this.X[2] + 606105819U, global::Org.BouncyCastle.Crypto.Digests.MD5Digest.S13) + d;
			b = global::Org.BouncyCastle.Crypto.Digests.MD5Digest.RotateLeft(b + global::Org.BouncyCastle.Crypto.Digests.MD5Digest.F(c, d, a) + this.X[3] + 3250441966U, global::Org.BouncyCastle.Crypto.Digests.MD5Digest.S14) + c;
			a = global::Org.BouncyCastle.Crypto.Digests.MD5Digest.RotateLeft(a + global::Org.BouncyCastle.Crypto.Digests.MD5Digest.F(b, c, d) + this.X[4] + 4118548399U, global::Org.BouncyCastle.Crypto.Digests.MD5Digest.S11) + b;
			d = global::Org.BouncyCastle.Crypto.Digests.MD5Digest.RotateLeft(d + global::Org.BouncyCastle.Crypto.Digests.MD5Digest.F(a, b, c) + this.X[5] + 1200080426U, global::Org.BouncyCastle.Crypto.Digests.MD5Digest.S12) + a;
			c = global::Org.BouncyCastle.Crypto.Digests.MD5Digest.RotateLeft(c + global::Org.BouncyCastle.Crypto.Digests.MD5Digest.F(d, a, b) + this.X[6] + 2821735955U, global::Org.BouncyCastle.Crypto.Digests.MD5Digest.S13) + d;
			b = global::Org.BouncyCastle.Crypto.Digests.MD5Digest.RotateLeft(b + global::Org.BouncyCastle.Crypto.Digests.MD5Digest.F(c, d, a) + this.X[7] + 4249261313U, global::Org.BouncyCastle.Crypto.Digests.MD5Digest.S14) + c;
			a = global::Org.BouncyCastle.Crypto.Digests.MD5Digest.RotateLeft(a + global::Org.BouncyCastle.Crypto.Digests.MD5Digest.F(b, c, d) + this.X[8] + 1770035416U, global::Org.BouncyCastle.Crypto.Digests.MD5Digest.S11) + b;
			d = global::Org.BouncyCastle.Crypto.Digests.MD5Digest.RotateLeft(d + global::Org.BouncyCastle.Crypto.Digests.MD5Digest.F(a, b, c) + this.X[9] + 2336552879U, global::Org.BouncyCastle.Crypto.Digests.MD5Digest.S12) + a;
			c = global::Org.BouncyCastle.Crypto.Digests.MD5Digest.RotateLeft(c + global::Org.BouncyCastle.Crypto.Digests.MD5Digest.F(d, a, b) + this.X[10] + 4294925233U, global::Org.BouncyCastle.Crypto.Digests.MD5Digest.S13) + d;
			b = global::Org.BouncyCastle.Crypto.Digests.MD5Digest.RotateLeft(b + global::Org.BouncyCastle.Crypto.Digests.MD5Digest.F(c, d, a) + this.X[11] + 2304563134U, global::Org.BouncyCastle.Crypto.Digests.MD5Digest.S14) + c;
			a = global::Org.BouncyCastle.Crypto.Digests.MD5Digest.RotateLeft(a + global::Org.BouncyCastle.Crypto.Digests.MD5Digest.F(b, c, d) + this.X[12] + 1804603682U, global::Org.BouncyCastle.Crypto.Digests.MD5Digest.S11) + b;
			d = global::Org.BouncyCastle.Crypto.Digests.MD5Digest.RotateLeft(d + global::Org.BouncyCastle.Crypto.Digests.MD5Digest.F(a, b, c) + this.X[13] + 4254626195U, global::Org.BouncyCastle.Crypto.Digests.MD5Digest.S12) + a;
			c = global::Org.BouncyCastle.Crypto.Digests.MD5Digest.RotateLeft(c + global::Org.BouncyCastle.Crypto.Digests.MD5Digest.F(d, a, b) + this.X[14] + 2792965006U, global::Org.BouncyCastle.Crypto.Digests.MD5Digest.S13) + d;
			b = global::Org.BouncyCastle.Crypto.Digests.MD5Digest.RotateLeft(b + global::Org.BouncyCastle.Crypto.Digests.MD5Digest.F(c, d, a) + this.X[15] + 1236535329U, global::Org.BouncyCastle.Crypto.Digests.MD5Digest.S14) + c;
			a = global::Org.BouncyCastle.Crypto.Digests.MD5Digest.RotateLeft(a + global::Org.BouncyCastle.Crypto.Digests.MD5Digest.G(b, c, d) + this.X[1] + 4129170786U, global::Org.BouncyCastle.Crypto.Digests.MD5Digest.S21) + b;
			d = global::Org.BouncyCastle.Crypto.Digests.MD5Digest.RotateLeft(d + global::Org.BouncyCastle.Crypto.Digests.MD5Digest.G(a, b, c) + this.X[6] + 3225465664U, global::Org.BouncyCastle.Crypto.Digests.MD5Digest.S22) + a;
			c = global::Org.BouncyCastle.Crypto.Digests.MD5Digest.RotateLeft(c + global::Org.BouncyCastle.Crypto.Digests.MD5Digest.G(d, a, b) + this.X[11] + 643717713U, global::Org.BouncyCastle.Crypto.Digests.MD5Digest.S23) + d;
			b = global::Org.BouncyCastle.Crypto.Digests.MD5Digest.RotateLeft(b + global::Org.BouncyCastle.Crypto.Digests.MD5Digest.G(c, d, a) + this.X[0] + 3921069994U, global::Org.BouncyCastle.Crypto.Digests.MD5Digest.S24) + c;
			a = global::Org.BouncyCastle.Crypto.Digests.MD5Digest.RotateLeft(a + global::Org.BouncyCastle.Crypto.Digests.MD5Digest.G(b, c, d) + this.X[5] + 3593408605U, global::Org.BouncyCastle.Crypto.Digests.MD5Digest.S21) + b;
			d = global::Org.BouncyCastle.Crypto.Digests.MD5Digest.RotateLeft(d + global::Org.BouncyCastle.Crypto.Digests.MD5Digest.G(a, b, c) + this.X[10] + 38016083U, global::Org.BouncyCastle.Crypto.Digests.MD5Digest.S22) + a;
			c = global::Org.BouncyCastle.Crypto.Digests.MD5Digest.RotateLeft(c + global::Org.BouncyCastle.Crypto.Digests.MD5Digest.G(d, a, b) + this.X[15] + 3634488961U, global::Org.BouncyCastle.Crypto.Digests.MD5Digest.S23) + d;
			b = global::Org.BouncyCastle.Crypto.Digests.MD5Digest.RotateLeft(b + global::Org.BouncyCastle.Crypto.Digests.MD5Digest.G(c, d, a) + this.X[4] + 3889429448U, global::Org.BouncyCastle.Crypto.Digests.MD5Digest.S24) + c;
			a = global::Org.BouncyCastle.Crypto.Digests.MD5Digest.RotateLeft(a + global::Org.BouncyCastle.Crypto.Digests.MD5Digest.G(b, c, d) + this.X[9] + 568446438U, global::Org.BouncyCastle.Crypto.Digests.MD5Digest.S21) + b;
			d = global::Org.BouncyCastle.Crypto.Digests.MD5Digest.RotateLeft(d + global::Org.BouncyCastle.Crypto.Digests.MD5Digest.G(a, b, c) + this.X[14] + 3275163606U, global::Org.BouncyCastle.Crypto.Digests.MD5Digest.S22) + a;
			c = global::Org.BouncyCastle.Crypto.Digests.MD5Digest.RotateLeft(c + global::Org.BouncyCastle.Crypto.Digests.MD5Digest.G(d, a, b) + this.X[3] + 4107603335U, global::Org.BouncyCastle.Crypto.Digests.MD5Digest.S23) + d;
			b = global::Org.BouncyCastle.Crypto.Digests.MD5Digest.RotateLeft(b + global::Org.BouncyCastle.Crypto.Digests.MD5Digest.G(c, d, a) + this.X[8] + 1163531501U, global::Org.BouncyCastle.Crypto.Digests.MD5Digest.S24) + c;
			a = global::Org.BouncyCastle.Crypto.Digests.MD5Digest.RotateLeft(a + global::Org.BouncyCastle.Crypto.Digests.MD5Digest.G(b, c, d) + this.X[13] + 2850285829U, global::Org.BouncyCastle.Crypto.Digests.MD5Digest.S21) + b;
			d = global::Org.BouncyCastle.Crypto.Digests.MD5Digest.RotateLeft(d + global::Org.BouncyCastle.Crypto.Digests.MD5Digest.G(a, b, c) + this.X[2] + 4243563512U, global::Org.BouncyCastle.Crypto.Digests.MD5Digest.S22) + a;
			c = global::Org.BouncyCastle.Crypto.Digests.MD5Digest.RotateLeft(c + global::Org.BouncyCastle.Crypto.Digests.MD5Digest.G(d, a, b) + this.X[7] + 1735328473U, global::Org.BouncyCastle.Crypto.Digests.MD5Digest.S23) + d;
			b = global::Org.BouncyCastle.Crypto.Digests.MD5Digest.RotateLeft(b + global::Org.BouncyCastle.Crypto.Digests.MD5Digest.G(c, d, a) + this.X[12] + 2368359562U, global::Org.BouncyCastle.Crypto.Digests.MD5Digest.S24) + c;
			a = global::Org.BouncyCastle.Crypto.Digests.MD5Digest.RotateLeft(a + global::Org.BouncyCastle.Crypto.Digests.MD5Digest.H(b, c, d) + this.X[5] + 4294588738U, global::Org.BouncyCastle.Crypto.Digests.MD5Digest.S31) + b;
			d = global::Org.BouncyCastle.Crypto.Digests.MD5Digest.RotateLeft(d + global::Org.BouncyCastle.Crypto.Digests.MD5Digest.H(a, b, c) + this.X[8] + 2272392833U, global::Org.BouncyCastle.Crypto.Digests.MD5Digest.S32) + a;
			c = global::Org.BouncyCastle.Crypto.Digests.MD5Digest.RotateLeft(c + global::Org.BouncyCastle.Crypto.Digests.MD5Digest.H(d, a, b) + this.X[11] + 1839030562U, global::Org.BouncyCastle.Crypto.Digests.MD5Digest.S33) + d;
			b = global::Org.BouncyCastle.Crypto.Digests.MD5Digest.RotateLeft(b + global::Org.BouncyCastle.Crypto.Digests.MD5Digest.H(c, d, a) + this.X[14] + 4259657740U, global::Org.BouncyCastle.Crypto.Digests.MD5Digest.S34) + c;
			a = global::Org.BouncyCastle.Crypto.Digests.MD5Digest.RotateLeft(a + global::Org.BouncyCastle.Crypto.Digests.MD5Digest.H(b, c, d) + this.X[1] + 2763975236U, global::Org.BouncyCastle.Crypto.Digests.MD5Digest.S31) + b;
			d = global::Org.BouncyCastle.Crypto.Digests.MD5Digest.RotateLeft(d + global::Org.BouncyCastle.Crypto.Digests.MD5Digest.H(a, b, c) + this.X[4] + 1272893353U, global::Org.BouncyCastle.Crypto.Digests.MD5Digest.S32) + a;
			c = global::Org.BouncyCastle.Crypto.Digests.MD5Digest.RotateLeft(c + global::Org.BouncyCastle.Crypto.Digests.MD5Digest.H(d, a, b) + this.X[7] + 4139469664U, global::Org.BouncyCastle.Crypto.Digests.MD5Digest.S33) + d;
			b = global::Org.BouncyCastle.Crypto.Digests.MD5Digest.RotateLeft(b + global::Org.BouncyCastle.Crypto.Digests.MD5Digest.H(c, d, a) + this.X[10] + 3200236656U, global::Org.BouncyCastle.Crypto.Digests.MD5Digest.S34) + c;
			a = global::Org.BouncyCastle.Crypto.Digests.MD5Digest.RotateLeft(a + global::Org.BouncyCastle.Crypto.Digests.MD5Digest.H(b, c, d) + this.X[13] + 681279174U, global::Org.BouncyCastle.Crypto.Digests.MD5Digest.S31) + b;
			d = global::Org.BouncyCastle.Crypto.Digests.MD5Digest.RotateLeft(d + global::Org.BouncyCastle.Crypto.Digests.MD5Digest.H(a, b, c) + this.X[0] + 3936430074U, global::Org.BouncyCastle.Crypto.Digests.MD5Digest.S32) + a;
			c = global::Org.BouncyCastle.Crypto.Digests.MD5Digest.RotateLeft(c + global::Org.BouncyCastle.Crypto.Digests.MD5Digest.H(d, a, b) + this.X[3] + 3572445317U, global::Org.BouncyCastle.Crypto.Digests.MD5Digest.S33) + d;
			b = global::Org.BouncyCastle.Crypto.Digests.MD5Digest.RotateLeft(b + global::Org.BouncyCastle.Crypto.Digests.MD5Digest.H(c, d, a) + this.X[6] + 76029189U, global::Org.BouncyCastle.Crypto.Digests.MD5Digest.S34) + c;
			a = global::Org.BouncyCastle.Crypto.Digests.MD5Digest.RotateLeft(a + global::Org.BouncyCastle.Crypto.Digests.MD5Digest.H(b, c, d) + this.X[9] + 3654602809U, global::Org.BouncyCastle.Crypto.Digests.MD5Digest.S31) + b;
			d = global::Org.BouncyCastle.Crypto.Digests.MD5Digest.RotateLeft(d + global::Org.BouncyCastle.Crypto.Digests.MD5Digest.H(a, b, c) + this.X[12] + 3873151461U, global::Org.BouncyCastle.Crypto.Digests.MD5Digest.S32) + a;
			c = global::Org.BouncyCastle.Crypto.Digests.MD5Digest.RotateLeft(c + global::Org.BouncyCastle.Crypto.Digests.MD5Digest.H(d, a, b) + this.X[15] + 530742520U, global::Org.BouncyCastle.Crypto.Digests.MD5Digest.S33) + d;
			b = global::Org.BouncyCastle.Crypto.Digests.MD5Digest.RotateLeft(b + global::Org.BouncyCastle.Crypto.Digests.MD5Digest.H(c, d, a) + this.X[2] + 3299628645U, global::Org.BouncyCastle.Crypto.Digests.MD5Digest.S34) + c;
			a = global::Org.BouncyCastle.Crypto.Digests.MD5Digest.RotateLeft(a + global::Org.BouncyCastle.Crypto.Digests.MD5Digest.K(b, c, d) + this.X[0] + 4096336452U, global::Org.BouncyCastle.Crypto.Digests.MD5Digest.S41) + b;
			d = global::Org.BouncyCastle.Crypto.Digests.MD5Digest.RotateLeft(d + global::Org.BouncyCastle.Crypto.Digests.MD5Digest.K(a, b, c) + this.X[7] + 1126891415U, global::Org.BouncyCastle.Crypto.Digests.MD5Digest.S42) + a;
			c = global::Org.BouncyCastle.Crypto.Digests.MD5Digest.RotateLeft(c + global::Org.BouncyCastle.Crypto.Digests.MD5Digest.K(d, a, b) + this.X[14] + 2878612391U, global::Org.BouncyCastle.Crypto.Digests.MD5Digest.S43) + d;
			b = global::Org.BouncyCastle.Crypto.Digests.MD5Digest.RotateLeft(b + global::Org.BouncyCastle.Crypto.Digests.MD5Digest.K(c, d, a) + this.X[5] + 4237533241U, global::Org.BouncyCastle.Crypto.Digests.MD5Digest.S44) + c;
			a = global::Org.BouncyCastle.Crypto.Digests.MD5Digest.RotateLeft(a + global::Org.BouncyCastle.Crypto.Digests.MD5Digest.K(b, c, d) + this.X[12] + 1700485571U, global::Org.BouncyCastle.Crypto.Digests.MD5Digest.S41) + b;
			d = global::Org.BouncyCastle.Crypto.Digests.MD5Digest.RotateLeft(d + global::Org.BouncyCastle.Crypto.Digests.MD5Digest.K(a, b, c) + this.X[3] + 2399980690U, global::Org.BouncyCastle.Crypto.Digests.MD5Digest.S42) + a;
			c = global::Org.BouncyCastle.Crypto.Digests.MD5Digest.RotateLeft(c + global::Org.BouncyCastle.Crypto.Digests.MD5Digest.K(d, a, b) + this.X[10] + 4293915773U, global::Org.BouncyCastle.Crypto.Digests.MD5Digest.S43) + d;
			b = global::Org.BouncyCastle.Crypto.Digests.MD5Digest.RotateLeft(b + global::Org.BouncyCastle.Crypto.Digests.MD5Digest.K(c, d, a) + this.X[1] + 2240044497U, global::Org.BouncyCastle.Crypto.Digests.MD5Digest.S44) + c;
			a = global::Org.BouncyCastle.Crypto.Digests.MD5Digest.RotateLeft(a + global::Org.BouncyCastle.Crypto.Digests.MD5Digest.K(b, c, d) + this.X[8] + 1873313359U, global::Org.BouncyCastle.Crypto.Digests.MD5Digest.S41) + b;
			d = global::Org.BouncyCastle.Crypto.Digests.MD5Digest.RotateLeft(d + global::Org.BouncyCastle.Crypto.Digests.MD5Digest.K(a, b, c) + this.X[15] + 4264355552U, global::Org.BouncyCastle.Crypto.Digests.MD5Digest.S42) + a;
			c = global::Org.BouncyCastle.Crypto.Digests.MD5Digest.RotateLeft(c + global::Org.BouncyCastle.Crypto.Digests.MD5Digest.K(d, a, b) + this.X[6] + 2734768916U, global::Org.BouncyCastle.Crypto.Digests.MD5Digest.S43) + d;
			b = global::Org.BouncyCastle.Crypto.Digests.MD5Digest.RotateLeft(b + global::Org.BouncyCastle.Crypto.Digests.MD5Digest.K(c, d, a) + this.X[13] + 1309151649U, global::Org.BouncyCastle.Crypto.Digests.MD5Digest.S44) + c;
			a = global::Org.BouncyCastle.Crypto.Digests.MD5Digest.RotateLeft(a + global::Org.BouncyCastle.Crypto.Digests.MD5Digest.K(b, c, d) + this.X[4] + 4149444226U, global::Org.BouncyCastle.Crypto.Digests.MD5Digest.S41) + b;
			d = global::Org.BouncyCastle.Crypto.Digests.MD5Digest.RotateLeft(d + global::Org.BouncyCastle.Crypto.Digests.MD5Digest.K(a, b, c) + this.X[11] + 3174756917U, global::Org.BouncyCastle.Crypto.Digests.MD5Digest.S42) + a;
			c = global::Org.BouncyCastle.Crypto.Digests.MD5Digest.RotateLeft(c + global::Org.BouncyCastle.Crypto.Digests.MD5Digest.K(d, a, b) + this.X[2] + 718787259U, global::Org.BouncyCastle.Crypto.Digests.MD5Digest.S43) + d;
			b = global::Org.BouncyCastle.Crypto.Digests.MD5Digest.RotateLeft(b + global::Org.BouncyCastle.Crypto.Digests.MD5Digest.K(c, d, a) + this.X[9] + 3951481745U, global::Org.BouncyCastle.Crypto.Digests.MD5Digest.S44) + c;
			this.H1 += a;
			this.H2 += b;
			this.H3 += c;
			this.H4 += d;
			this.xOff = 0;
		}

		// Token: 0x06003054 RID: 12372 RVA: 0x000E37D0 File Offset: 0x000E19D0
		public override global::Org.BouncyCastle.Utilities.IMemoable Copy()
		{
			return new global::Org.BouncyCastle.Crypto.Digests.MD5Digest(this);
		}

		// Token: 0x06003055 RID: 12373 RVA: 0x000E37D8 File Offset: 0x000E19D8
		public override void Reset(global::Org.BouncyCastle.Utilities.IMemoable other)
		{
			global::Org.BouncyCastle.Crypto.Digests.MD5Digest d = (global::Org.BouncyCastle.Crypto.Digests.MD5Digest)other;
			this.CopyIn(d);
		}

		// Token: 0x040014EE RID: 5358
		private const int DigestLength = 16;

		// Token: 0x040014EF RID: 5359
		private uint H1;

		// Token: 0x040014F0 RID: 5360
		private uint H2;

		// Token: 0x040014F1 RID: 5361
		private uint H3;

		// Token: 0x040014F2 RID: 5362
		private uint H4;

		// Token: 0x040014F3 RID: 5363
		private uint[] X = new uint[16];

		// Token: 0x040014F4 RID: 5364
		private int xOff;

		// Token: 0x040014F5 RID: 5365
		private static readonly int S11 = 7;

		// Token: 0x040014F6 RID: 5366
		private static readonly int S12 = 12;

		// Token: 0x040014F7 RID: 5367
		private static readonly int S13 = 17;

		// Token: 0x040014F8 RID: 5368
		private static readonly int S14 = 22;

		// Token: 0x040014F9 RID: 5369
		private static readonly int S21 = 5;

		// Token: 0x040014FA RID: 5370
		private static readonly int S22 = 9;

		// Token: 0x040014FB RID: 5371
		private static readonly int S23 = 14;

		// Token: 0x040014FC RID: 5372
		private static readonly int S24 = 20;

		// Token: 0x040014FD RID: 5373
		private static readonly int S31 = 4;

		// Token: 0x040014FE RID: 5374
		private static readonly int S32 = 11;

		// Token: 0x040014FF RID: 5375
		private static readonly int S33 = 16;

		// Token: 0x04001500 RID: 5376
		private static readonly int S34 = 23;

		// Token: 0x04001501 RID: 5377
		private static readonly int S41 = 6;

		// Token: 0x04001502 RID: 5378
		private static readonly int S42 = 10;

		// Token: 0x04001503 RID: 5379
		private static readonly int S43 = 15;

		// Token: 0x04001504 RID: 5380
		private static readonly int S44 = 21;
	}
}
