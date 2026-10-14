using System;
using Org.BouncyCastle.Crypto.Macs;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Crypto.Generators
{
	// Token: 0x02000477 RID: 1143
	public class KdfDoublePipelineIterationBytesGenerator : global::Org.BouncyCastle.Crypto.IMacDerivationFunction, global::Org.BouncyCastle.Crypto.IDerivationFunction
	{
		// Token: 0x06002BEE RID: 11246 RVA: 0x000BD0F5 File Offset: 0x000BB2F5
		public KdfDoublePipelineIterationBytesGenerator(global::Org.BouncyCastle.Crypto.IMac prf)
		{
			this.prf = prf;
			this.h = prf.GetMacSize();
			this.a = new byte[this.h];
			this.k = new byte[this.h];
		}

		// Token: 0x06002BEF RID: 11247 RVA: 0x000BD134 File Offset: 0x000BB334
		public void Init(global::Org.BouncyCastle.Crypto.IDerivationParameters parameters)
		{
			global::Org.BouncyCastle.Crypto.Parameters.KdfDoublePipelineIterationParameters dpiParams = parameters as global::Org.BouncyCastle.Crypto.Parameters.KdfDoublePipelineIterationParameters;
			if (dpiParams == null)
			{
				throw new global::System.ArgumentException("Wrong type of arguments given");
			}
			this.prf.Init(new global::Org.BouncyCastle.Crypto.Parameters.KeyParameter(dpiParams.Ki));
			this.fixedInputData = dpiParams.FixedInputData;
			int r = dpiParams.R;
			this.ios = new byte[r / 8];
			if (dpiParams.UseCounter)
			{
				global::Org.BouncyCastle.Math.BigInteger maxSize = global::Org.BouncyCastle.Crypto.Generators.KdfDoublePipelineIterationBytesGenerator.Two.Pow(r).Multiply(global::Org.BouncyCastle.Math.BigInteger.ValueOf((long)this.h));
				this.maxSizeExcl = ((maxSize.CompareTo(global::Org.BouncyCastle.Crypto.Generators.KdfDoublePipelineIterationBytesGenerator.IntegerMax) == 1) ? int.MaxValue : maxSize.IntValue);
			}
			else
			{
				this.maxSizeExcl = global::Org.BouncyCastle.Crypto.Generators.KdfDoublePipelineIterationBytesGenerator.IntegerMax.IntValue;
			}
			this.useCounter = dpiParams.UseCounter;
			this.generatedBytes = 0;
		}

		// Token: 0x06002BF0 RID: 11248 RVA: 0x000BD1F8 File Offset: 0x000BB3F8
		private void generateNext()
		{
			if (this.generatedBytes == 0)
			{
				this.prf.BlockUpdate(this.fixedInputData, 0, this.fixedInputData.Length);
				this.prf.DoFinal(this.a, 0);
			}
			else
			{
				this.prf.BlockUpdate(this.a, 0, this.a.Length);
				this.prf.DoFinal(this.a, 0);
			}
			this.prf.BlockUpdate(this.a, 0, this.a.Length);
			if (this.useCounter)
			{
				int i = this.generatedBytes / this.h + 1;
				switch (this.ios.Length)
				{
				case 1:
					goto IL_F4;
				case 2:
					goto IL_DF;
				case 3:
					break;
				case 4:
					this.ios[0] = (byte)(i >> 24);
					break;
				default:
					throw new global::System.InvalidOperationException("Unsupported size of counter i");
				}
				this.ios[this.ios.Length - 3] = (byte)(i >> 16);
				IL_DF:
				this.ios[this.ios.Length - 2] = (byte)(i >> 8);
				IL_F4:
				this.ios[this.ios.Length - 1] = (byte)i;
				this.prf.BlockUpdate(this.ios, 0, this.ios.Length);
			}
			this.prf.BlockUpdate(this.fixedInputData, 0, this.fixedInputData.Length);
			this.prf.DoFinal(this.k, 0);
		}

		// Token: 0x1700060B RID: 1547
		// (get) Token: 0x06002BF1 RID: 11249 RVA: 0x000BD360 File Offset: 0x000BB560
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

		// Token: 0x06002BF2 RID: 11250 RVA: 0x000BD384 File Offset: 0x000BB584
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

		// Token: 0x06002BF3 RID: 11251 RVA: 0x000BD46D File Offset: 0x000BB66D
		public global::Org.BouncyCastle.Crypto.IMac GetMac()
		{
			return this.prf;
		}

		// Token: 0x04001245 RID: 4677
		private static readonly global::Org.BouncyCastle.Math.BigInteger IntegerMax = global::Org.BouncyCastle.Math.BigInteger.ValueOf(2147483647L);

		// Token: 0x04001246 RID: 4678
		private static readonly global::Org.BouncyCastle.Math.BigInteger Two = global::Org.BouncyCastle.Math.BigInteger.Two;

		// Token: 0x04001247 RID: 4679
		private readonly global::Org.BouncyCastle.Crypto.IMac prf;

		// Token: 0x04001248 RID: 4680
		private readonly int h;

		// Token: 0x04001249 RID: 4681
		private byte[] fixedInputData;

		// Token: 0x0400124A RID: 4682
		private int maxSizeExcl;

		// Token: 0x0400124B RID: 4683
		private byte[] ios;

		// Token: 0x0400124C RID: 4684
		private bool useCounter;

		// Token: 0x0400124D RID: 4685
		private int generatedBytes;

		// Token: 0x0400124E RID: 4686
		private byte[] a;

		// Token: 0x0400124F RID: 4687
		private byte[] k;
	}
}
