using System;
using Org.BouncyCastle.Crypto.Macs;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Crypto.Generators
{
	// Token: 0x02000476 RID: 1142
	public class KdfCounterBytesGenerator : global::Org.BouncyCastle.Crypto.IMacDerivationFunction, global::Org.BouncyCastle.Crypto.IDerivationFunction
	{
		// Token: 0x06002BE7 RID: 11239 RVA: 0x000BCDF4 File Offset: 0x000BAFF4
		public KdfCounterBytesGenerator(global::Org.BouncyCastle.Crypto.IMac prf)
		{
			this.prf = prf;
			this.h = prf.GetMacSize();
			this.k = new byte[this.h];
		}

		// Token: 0x06002BE8 RID: 11240 RVA: 0x000BCE20 File Offset: 0x000BB020
		public void Init(global::Org.BouncyCastle.Crypto.IDerivationParameters param)
		{
			global::Org.BouncyCastle.Crypto.Parameters.KdfCounterParameters kdfParams = param as global::Org.BouncyCastle.Crypto.Parameters.KdfCounterParameters;
			if (kdfParams == null)
			{
				throw new global::System.ArgumentException("Wrong type of arguments given");
			}
			this.prf.Init(new global::Org.BouncyCastle.Crypto.Parameters.KeyParameter(kdfParams.Ki));
			this.fixedInputDataCtrPrefix = kdfParams.FixedInputDataCounterPrefix;
			this.fixedInputData_afterCtr = kdfParams.FixedInputDataCounterSuffix;
			int r = kdfParams.R;
			this.ios = new byte[r / 8];
			global::Org.BouncyCastle.Math.BigInteger maxSize = global::Org.BouncyCastle.Crypto.Generators.KdfCounterBytesGenerator.Two.Pow(r).Multiply(global::Org.BouncyCastle.Math.BigInteger.ValueOf((long)this.h));
			this.maxSizeExcl = ((maxSize.CompareTo(global::Org.BouncyCastle.Crypto.Generators.KdfCounterBytesGenerator.IntegerMax) == 1) ? int.MaxValue : maxSize.IntValue);
			this.generatedBytes = 0;
		}

		// Token: 0x06002BE9 RID: 11241 RVA: 0x000BCECA File Offset: 0x000BB0CA
		public global::Org.BouncyCastle.Crypto.IMac GetMac()
		{
			return this.prf;
		}

		// Token: 0x1700060A RID: 1546
		// (get) Token: 0x06002BEA RID: 11242 RVA: 0x000BCED2 File Offset: 0x000BB0D2
		public global::Org.BouncyCastle.Crypto.IDigest Digest
		{
			get
			{
				if (!(this.prf is global::Org.BouncyCastle.Crypto.Macs.HMac))
				{
					return null;
				}
				return ((global::Org.BouncyCastle.Crypto.Macs.HMac)this.prf).GetUnderlyingDigest();
			}
		}

		// Token: 0x06002BEB RID: 11243 RVA: 0x000BCEF4 File Offset: 0x000BB0F4
		public int GenerateBytes(byte[] output, int outOff, int length)
		{
			int generatedBytesAfter = this.generatedBytes + length;
			if (generatedBytesAfter < 0 || generatedBytesAfter >= this.maxSizeExcl)
			{
				throw new global::Org.BouncyCastle.Crypto.DataLengthException("Current KDFCTR may only be used for " + this.maxSizeExcl.ToString() + " bytes");
			}
			if (this.generatedBytes % this.h == 0)
			{
				this.generateNext();
			}
			int posInK = this.generatedBytes % this.h;
			int toCopy = global::System.Math.Min(this.h - this.generatedBytes % this.h, length);
			global::System.Array.Copy(this.k, posInK, output, outOff, toCopy);
			this.generatedBytes += toCopy;
			int toGenerate = length - toCopy;
			outOff += toCopy;
			while (toGenerate > 0)
			{
				this.generateNext();
				toCopy = global::System.Math.Min(this.h, toGenerate);
				global::System.Array.Copy(this.k, 0, output, outOff, toCopy);
				this.generatedBytes += toCopy;
				toGenerate -= toCopy;
				outOff += toCopy;
			}
			return length;
		}

		// Token: 0x06002BEC RID: 11244 RVA: 0x000BCFE0 File Offset: 0x000BB1E0
		private void generateNext()
		{
			int i = this.generatedBytes / this.h + 1;
			switch (this.ios.Length)
			{
			case 1:
				goto IL_6B;
			case 2:
				goto IL_56;
			case 3:
				break;
			case 4:
				this.ios[0] = (byte)(i >> 24);
				break;
			default:
				throw new global::System.InvalidOperationException("Unsupported size of counter i");
			}
			this.ios[this.ios.Length - 3] = (byte)(i >> 16);
			IL_56:
			this.ios[this.ios.Length - 2] = (byte)(i >> 8);
			IL_6B:
			this.ios[this.ios.Length - 1] = (byte)i;
			this.prf.BlockUpdate(this.fixedInputDataCtrPrefix, 0, this.fixedInputDataCtrPrefix.Length);
			this.prf.BlockUpdate(this.ios, 0, this.ios.Length);
			this.prf.BlockUpdate(this.fixedInputData_afterCtr, 0, this.fixedInputData_afterCtr.Length);
			this.prf.DoFinal(this.k, 0);
		}

		// Token: 0x0400123B RID: 4667
		private static readonly global::Org.BouncyCastle.Math.BigInteger IntegerMax = global::Org.BouncyCastle.Math.BigInteger.ValueOf(2147483647L);

		// Token: 0x0400123C RID: 4668
		private static readonly global::Org.BouncyCastle.Math.BigInteger Two = global::Org.BouncyCastle.Math.BigInteger.Two;

		// Token: 0x0400123D RID: 4669
		private readonly global::Org.BouncyCastle.Crypto.IMac prf;

		// Token: 0x0400123E RID: 4670
		private readonly int h;

		// Token: 0x0400123F RID: 4671
		private byte[] fixedInputDataCtrPrefix;

		// Token: 0x04001240 RID: 4672
		private byte[] fixedInputData_afterCtr;

		// Token: 0x04001241 RID: 4673
		private int maxSizeExcl;

		// Token: 0x04001242 RID: 4674
		private byte[] ios;

		// Token: 0x04001243 RID: 4675
		private int generatedBytes;

		// Token: 0x04001244 RID: 4676
		private byte[] k;
	}
}
