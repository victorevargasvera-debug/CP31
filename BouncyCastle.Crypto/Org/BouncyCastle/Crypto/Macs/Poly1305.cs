using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Utilities;

namespace Org.BouncyCastle.Crypto.Macs
{
	// Token: 0x02000456 RID: 1110
	public class Poly1305 : global::Org.BouncyCastle.Crypto.IMac
	{
		// Token: 0x06002B07 RID: 11015 RVA: 0x000B8596 File Offset: 0x000B6796
		public Poly1305()
		{
			this.cipher = null;
		}

		// Token: 0x06002B08 RID: 11016 RVA: 0x000B85BE File Offset: 0x000B67BE
		public Poly1305(global::Org.BouncyCastle.Crypto.IBlockCipher cipher)
		{
			if (cipher.GetBlockSize() != 16)
			{
				throw new global::System.ArgumentException("Poly1305 requires a 128 bit block cipher.");
			}
			this.cipher = cipher;
		}

		// Token: 0x06002B09 RID: 11017 RVA: 0x000B85FC File Offset: 0x000B67FC
		public void Init(global::Org.BouncyCastle.Crypto.ICipherParameters parameters)
		{
			byte[] nonce = null;
			if (this.cipher != null)
			{
				if (!(parameters is global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV))
				{
					throw new global::System.ArgumentException("Poly1305 requires an IV when used with a block cipher.", "parameters");
				}
				global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV parametersWithIV = (global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV)parameters;
				nonce = parametersWithIV.GetIV();
				parameters = parametersWithIV.Parameters;
			}
			if (!(parameters is global::Org.BouncyCastle.Crypto.Parameters.KeyParameter))
			{
				throw new global::System.ArgumentException("Poly1305 requires a key.");
			}
			global::Org.BouncyCastle.Crypto.Parameters.KeyParameter keyParams = (global::Org.BouncyCastle.Crypto.Parameters.KeyParameter)parameters;
			this.SetKey(keyParams.GetKey(), nonce);
			this.Reset();
		}

		// Token: 0x06002B0A RID: 11018 RVA: 0x000B866C File Offset: 0x000B686C
		private void SetKey(byte[] key, byte[] nonce)
		{
			if (key.Length != 32)
			{
				throw new global::System.ArgumentException("Poly1305 key must be 256 bits.");
			}
			if (this.cipher != null && (nonce == null || nonce.Length != 16))
			{
				throw new global::System.ArgumentException("Poly1305 requires a 128 bit IV.");
			}
			uint t0 = global::Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(key, 0);
			uint t = global::Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(key, 4);
			uint t2 = global::Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(key, 8);
			uint t3 = global::Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(key, 12);
			this.r0 = (t0 & 67108863U);
			this.r1 = ((t0 >> 26 | t << 6) & 67108611U);
			this.r2 = ((t >> 20 | t2 << 12) & 67092735U);
			this.r3 = ((t2 >> 14 | t3 << 18) & 66076671U);
			this.r4 = (t3 >> 8 & 1048575U);
			this.s1 = this.r1 * 5U;
			this.s2 = this.r2 * 5U;
			this.s3 = this.r3 * 5U;
			this.s4 = this.r4 * 5U;
			byte[] kBytes;
			int kOff;
			if (this.cipher == null)
			{
				kBytes = key;
				kOff = 16;
			}
			else
			{
				kBytes = new byte[16];
				kOff = 0;
				this.cipher.Init(true, new global::Org.BouncyCastle.Crypto.Parameters.KeyParameter(key, 16, 16));
				this.cipher.ProcessBlock(nonce, 0, kBytes, 0);
			}
			this.k0 = global::Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(kBytes, kOff);
			this.k1 = global::Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(kBytes, kOff + 4);
			this.k2 = global::Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(kBytes, kOff + 8);
			this.k3 = global::Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(kBytes, kOff + 12);
		}

		// Token: 0x170005EB RID: 1515
		// (get) Token: 0x06002B0B RID: 11019 RVA: 0x000B87E2 File Offset: 0x000B69E2
		public string AlgorithmName
		{
			get
			{
				if (this.cipher != null)
				{
					return "Poly1305-" + this.cipher.AlgorithmName;
				}
				return "Poly1305";
			}
		}

		// Token: 0x06002B0C RID: 11020 RVA: 0x000B8807 File Offset: 0x000B6A07
		public int GetMacSize()
		{
			return 16;
		}

		// Token: 0x06002B0D RID: 11021 RVA: 0x000B880B File Offset: 0x000B6A0B
		public void Update(byte input)
		{
			this.singleByte[0] = input;
			this.BlockUpdate(this.singleByte, 0, 1);
		}

		// Token: 0x06002B0E RID: 11022 RVA: 0x000B8824 File Offset: 0x000B6A24
		public void BlockUpdate(byte[] input, int inOff, int len)
		{
			int copied = 0;
			while (len > copied)
			{
				if (this.currentBlockOffset == 16)
				{
					this.ProcessBlock();
					this.currentBlockOffset = 0;
				}
				int toCopy = global::System.Math.Min(len - copied, 16 - this.currentBlockOffset);
				global::System.Array.Copy(input, copied + inOff, this.currentBlock, this.currentBlockOffset, toCopy);
				copied += toCopy;
				this.currentBlockOffset += toCopy;
			}
		}

		// Token: 0x06002B0F RID: 11023 RVA: 0x000B888C File Offset: 0x000B6A8C
		private void ProcessBlock()
		{
			if (this.currentBlockOffset < 16)
			{
				this.currentBlock[this.currentBlockOffset] = 1;
				for (int i = this.currentBlockOffset + 1; i < 16; i++)
				{
					this.currentBlock[i] = 0;
				}
			}
			ulong t0 = (ulong)global::Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(this.currentBlock, 0);
			ulong t = (ulong)global::Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(this.currentBlock, 4);
			ulong t2 = (ulong)global::Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(this.currentBlock, 8);
			ulong t3 = (ulong)global::Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(this.currentBlock, 12);
			this.h0 += (uint)(t0 & 67108863UL);
			this.h1 += (uint)((t << 32 | t0) >> 26 & 67108863UL);
			this.h2 += (uint)((t2 << 32 | t) >> 20 & 67108863UL);
			this.h3 += (uint)((t3 << 32 | t2) >> 14 & 67108863UL);
			this.h4 += (uint)(t3 >> 8);
			if (this.currentBlockOffset == 16)
			{
				this.h4 += 16777216U;
			}
			ulong tp0 = global::Org.BouncyCastle.Crypto.Macs.Poly1305.mul32x32_64(this.h0, this.r0) + global::Org.BouncyCastle.Crypto.Macs.Poly1305.mul32x32_64(this.h1, this.s4) + global::Org.BouncyCastle.Crypto.Macs.Poly1305.mul32x32_64(this.h2, this.s3) + global::Org.BouncyCastle.Crypto.Macs.Poly1305.mul32x32_64(this.h3, this.s2) + global::Org.BouncyCastle.Crypto.Macs.Poly1305.mul32x32_64(this.h4, this.s1);
			ulong tp = global::Org.BouncyCastle.Crypto.Macs.Poly1305.mul32x32_64(this.h0, this.r1) + global::Org.BouncyCastle.Crypto.Macs.Poly1305.mul32x32_64(this.h1, this.r0) + global::Org.BouncyCastle.Crypto.Macs.Poly1305.mul32x32_64(this.h2, this.s4) + global::Org.BouncyCastle.Crypto.Macs.Poly1305.mul32x32_64(this.h3, this.s3) + global::Org.BouncyCastle.Crypto.Macs.Poly1305.mul32x32_64(this.h4, this.s2);
			ulong tp2 = global::Org.BouncyCastle.Crypto.Macs.Poly1305.mul32x32_64(this.h0, this.r2) + global::Org.BouncyCastle.Crypto.Macs.Poly1305.mul32x32_64(this.h1, this.r1) + global::Org.BouncyCastle.Crypto.Macs.Poly1305.mul32x32_64(this.h2, this.r0) + global::Org.BouncyCastle.Crypto.Macs.Poly1305.mul32x32_64(this.h3, this.s4) + global::Org.BouncyCastle.Crypto.Macs.Poly1305.mul32x32_64(this.h4, this.s3);
			ulong tp3 = global::Org.BouncyCastle.Crypto.Macs.Poly1305.mul32x32_64(this.h0, this.r3) + global::Org.BouncyCastle.Crypto.Macs.Poly1305.mul32x32_64(this.h1, this.r2) + global::Org.BouncyCastle.Crypto.Macs.Poly1305.mul32x32_64(this.h2, this.r1) + global::Org.BouncyCastle.Crypto.Macs.Poly1305.mul32x32_64(this.h3, this.r0) + global::Org.BouncyCastle.Crypto.Macs.Poly1305.mul32x32_64(this.h4, this.s4);
			ulong tp4 = global::Org.BouncyCastle.Crypto.Macs.Poly1305.mul32x32_64(this.h0, this.r4) + global::Org.BouncyCastle.Crypto.Macs.Poly1305.mul32x32_64(this.h1, this.r3) + global::Org.BouncyCastle.Crypto.Macs.Poly1305.mul32x32_64(this.h2, this.r2) + global::Org.BouncyCastle.Crypto.Macs.Poly1305.mul32x32_64(this.h3, this.r1) + global::Org.BouncyCastle.Crypto.Macs.Poly1305.mul32x32_64(this.h4, this.r0);
			this.h0 = ((uint)tp0 & 67108863U);
			tp += tp0 >> 26;
			this.h1 = ((uint)tp & 67108863U);
			tp2 += tp >> 26;
			this.h2 = ((uint)tp2 & 67108863U);
			tp3 += tp2 >> 26;
			this.h3 = ((uint)tp3 & 67108863U);
			tp4 += tp3 >> 26;
			this.h4 = ((uint)tp4 & 67108863U);
			this.h0 += (uint)(tp4 >> 26) * 5U;
			this.h1 += this.h0 >> 26;
			this.h0 &= 67108863U;
		}

		// Token: 0x06002B10 RID: 11024 RVA: 0x000B8C20 File Offset: 0x000B6E20
		public int DoFinal(byte[] output, int outOff)
		{
			global::Org.BouncyCastle.Crypto.Check.DataLength(output, outOff, 16, "Output buffer is too short.");
			if (this.currentBlockOffset > 0)
			{
				this.ProcessBlock();
			}
			this.h1 += this.h0 >> 26;
			this.h0 &= 67108863U;
			this.h2 += this.h1 >> 26;
			this.h1 &= 67108863U;
			this.h3 += this.h2 >> 26;
			this.h2 &= 67108863U;
			this.h4 += this.h3 >> 26;
			this.h3 &= 67108863U;
			this.h0 += (this.h4 >> 26) * 5U;
			this.h4 &= 67108863U;
			this.h1 += this.h0 >> 26;
			this.h0 &= 67108863U;
			uint g0 = this.h0 + 5U;
			uint b = g0 >> 26;
			g0 &= 67108863U;
			uint g = this.h1 + b;
			b = g >> 26;
			g &= 67108863U;
			uint g2 = this.h2 + b;
			b = g2 >> 26;
			g2 &= 67108863U;
			uint g3 = this.h3 + b;
			b = g3 >> 26;
			g3 &= 67108863U;
			uint g4 = this.h4 + b - 67108864U;
			b = (g4 >> 31) - 1U;
			uint nb = ~b;
			this.h0 = ((this.h0 & nb) | (g0 & b));
			this.h1 = ((this.h1 & nb) | (g & b));
			this.h2 = ((this.h2 & nb) | (g2 & b));
			this.h3 = ((this.h3 & nb) | (g3 & b));
			this.h4 = ((this.h4 & nb) | (g4 & b));
			ulong f0 = (ulong)(this.h0 | this.h1 << 26) + (ulong)this.k0;
			ulong f = (ulong)(this.h1 >> 6 | this.h2 << 20) + (ulong)this.k1;
			ulong f2 = (ulong)(this.h2 >> 12 | this.h3 << 14) + (ulong)this.k2;
			ulong num = (ulong)(this.h3 >> 18 | this.h4 << 8) + (ulong)this.k3;
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_LE((uint)f0, output, outOff);
			f += f0 >> 32;
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_LE((uint)f, output, outOff + 4);
			f2 += f >> 32;
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_LE((uint)f2, output, outOff + 8);
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_LE((uint)(num + (f2 >> 32)), output, outOff + 12);
			this.Reset();
			return 16;
		}

		// Token: 0x06002B11 RID: 11025 RVA: 0x000B8EE0 File Offset: 0x000B70E0
		public void Reset()
		{
			this.currentBlockOffset = 0;
			this.h0 = (this.h1 = (this.h2 = (this.h3 = (this.h4 = 0U))));
		}

		// Token: 0x06002B12 RID: 11026 RVA: 0x000B8F1F File Offset: 0x000B711F
		private static ulong mul32x32_64(uint i1, uint i2)
		{
			return (ulong)i1 * (ulong)i2;
		}

		// Token: 0x040011BC RID: 4540
		private const int BlockSize = 16;

		// Token: 0x040011BD RID: 4541
		private readonly global::Org.BouncyCastle.Crypto.IBlockCipher cipher;

		// Token: 0x040011BE RID: 4542
		private readonly byte[] singleByte = new byte[1];

		// Token: 0x040011BF RID: 4543
		private uint r0;

		// Token: 0x040011C0 RID: 4544
		private uint r1;

		// Token: 0x040011C1 RID: 4545
		private uint r2;

		// Token: 0x040011C2 RID: 4546
		private uint r3;

		// Token: 0x040011C3 RID: 4547
		private uint r4;

		// Token: 0x040011C4 RID: 4548
		private uint s1;

		// Token: 0x040011C5 RID: 4549
		private uint s2;

		// Token: 0x040011C6 RID: 4550
		private uint s3;

		// Token: 0x040011C7 RID: 4551
		private uint s4;

		// Token: 0x040011C8 RID: 4552
		private uint k0;

		// Token: 0x040011C9 RID: 4553
		private uint k1;

		// Token: 0x040011CA RID: 4554
		private uint k2;

		// Token: 0x040011CB RID: 4555
		private uint k3;

		// Token: 0x040011CC RID: 4556
		private byte[] currentBlock = new byte[16];

		// Token: 0x040011CD RID: 4557
		private int currentBlockOffset;

		// Token: 0x040011CE RID: 4558
		private uint h0;

		// Token: 0x040011CF RID: 4559
		private uint h1;

		// Token: 0x040011D0 RID: 4560
		private uint h2;

		// Token: 0x040011D1 RID: 4561
		private uint h3;

		// Token: 0x040011D2 RID: 4562
		private uint h4;
	}
}
