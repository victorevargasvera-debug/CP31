using System;
using Org.BouncyCastle.Crypto.Macs;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Crypto.Generators
{
	// Token: 0x02000478 RID: 1144
	public class KdfFeedbackBytesGenerator : global::Org.BouncyCastle.Crypto.IMacDerivationFunction, global::Org.BouncyCastle.Crypto.IDerivationFunction
	{
		// Token: 0x06002BF5 RID: 11253 RVA: 0x000BD491 File Offset: 0x000BB691
		public KdfFeedbackBytesGenerator(global::Org.BouncyCastle.Crypto.IMac prf)
		{
			this.prf = prf;
			this.h = prf.GetMacSize();
			this.k = new byte[this.h];
		}

		// Token: 0x06002BF6 RID: 11254 RVA: 0x000BD4C0 File Offset: 0x000BB6C0
		public void Init(global::Org.BouncyCastle.Crypto.IDerivationParameters parameters)
		{
			global::Org.BouncyCastle.Crypto.Parameters.KdfFeedbackParameters feedbackParams = parameters as global::Org.BouncyCastle.Crypto.Parameters.KdfFeedbackParameters;
			if (feedbackParams == null)
			{
				throw new global::System.ArgumentException("Wrong type of arguments given");
			}
			this.prf.Init(new global::Org.BouncyCastle.Crypto.Parameters.KeyParameter(feedbackParams.Ki));
			this.fixedInputData = feedbackParams.FixedInputData;
			int r = feedbackParams.R;
			this.ios = new byte[r / 8];
			if (feedbackParams.UseCounter)
			{
				global::Org.BouncyCastle.Math.BigInteger maxSize = global::Org.BouncyCastle.Crypto.Generators.KdfFeedbackBytesGenerator.Two.Pow(r).Multiply(global::Org.BouncyCastle.Math.BigInteger.ValueOf((long)this.h));
				this.maxSizeExcl = ((maxSize.CompareTo(global::Org.BouncyCastle.Crypto.Generators.KdfFeedbackBytesGenerator.IntegerMax) == 1) ? int.MaxValue : maxSize.IntValue);
			}
			else
			{
				this.maxSizeExcl = int.MaxValue;
			}
			this.iv = feedbackParams.Iv;
			this.useCounter = feedbackParams.UseCounter;
			this.generatedBytes = 0;
		}

		// Token: 0x1700060C RID: 1548
		// (get) Token: 0x06002BF7 RID: 11255 RVA: 0x000BD58B File Offset: 0x000BB78B
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

		// Token: 0x06002BF8 RID: 11256 RVA: 0x000BD5AC File Offset: 0x000BB7AC
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

		// Token: 0x06002BF9 RID: 11257 RVA: 0x000BD698 File Offset: 0x000BB898
		private void generateNext()
		{
			if (this.generatedBytes == 0)
			{
				this.prf.BlockUpdate(this.iv, 0, this.iv.Length);
			}
			else
			{
				this.prf.BlockUpdate(this.k, 0, this.k.Length);
			}
			if (this.useCounter)
			{
				int i = this.generatedBytes / this.h + 1;
				switch (this.ios.Length)
				{
				case 1:
					goto IL_B4;
				case 2:
					goto IL_9F;
				case 3:
					break;
				case 4:
					this.ios[0] = (byte)(i >> 24);
					break;
				default:
					throw new global::System.InvalidOperationException("Unsupported size of counter i");
				}
				this.ios[this.ios.Length - 3] = (byte)(i >> 16);
				IL_9F:
				this.ios[this.ios.Length - 2] = (byte)(i >> 8);
				IL_B4:
				this.ios[this.ios.Length - 1] = (byte)i;
				this.prf.BlockUpdate(this.ios, 0, this.ios.Length);
			}
			this.prf.BlockUpdate(this.fixedInputData, 0, this.fixedInputData.Length);
			this.prf.DoFinal(this.k, 0);
		}

		// Token: 0x06002BFA RID: 11258 RVA: 0x000BD7C0 File Offset: 0x000BB9C0
		public global::Org.BouncyCastle.Crypto.IMac GetMac()
		{
			return this.prf;
		}

		// Token: 0x04001250 RID: 4688
		private static readonly global::Org.BouncyCastle.Math.BigInteger IntegerMax = global::Org.BouncyCastle.Math.BigInteger.ValueOf(2147483647L);

		// Token: 0x04001251 RID: 4689
		private static readonly global::Org.BouncyCastle.Math.BigInteger Two = global::Org.BouncyCastle.Math.BigInteger.Two;

		// Token: 0x04001252 RID: 4690
		private readonly global::Org.BouncyCastle.Crypto.IMac prf;

		// Token: 0x04001253 RID: 4691
		private readonly int h;

		// Token: 0x04001254 RID: 4692
		private byte[] fixedInputData;

		// Token: 0x04001255 RID: 4693
		private int maxSizeExcl;

		// Token: 0x04001256 RID: 4694
		private byte[] ios;

		// Token: 0x04001257 RID: 4695
		private byte[] iv;

		// Token: 0x04001258 RID: 4696
		private bool useCounter;

		// Token: 0x04001259 RID: 4697
		private int generatedBytes;

		// Token: 0x0400125A RID: 4698
		private byte[] k;
	}
}
