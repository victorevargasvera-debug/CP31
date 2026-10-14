using System;
using Org.BouncyCastle.Crypto.Digests;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Macs
{
	// Token: 0x02000458 RID: 1112
	public class SkeinMac : global::Org.BouncyCastle.Crypto.IMac
	{
		// Token: 0x06002B20 RID: 11040 RVA: 0x000B935F File Offset: 0x000B755F
		public SkeinMac(int stateSizeBits, int digestSizeBits)
		{
			this.engine = new global::Org.BouncyCastle.Crypto.Digests.SkeinEngine(stateSizeBits, digestSizeBits);
		}

		// Token: 0x06002B21 RID: 11041 RVA: 0x000B9374 File Offset: 0x000B7574
		public SkeinMac(global::Org.BouncyCastle.Crypto.Macs.SkeinMac mac)
		{
			this.engine = new global::Org.BouncyCastle.Crypto.Digests.SkeinEngine(mac.engine);
		}

		// Token: 0x170005ED RID: 1517
		// (get) Token: 0x06002B22 RID: 11042 RVA: 0x000B9390 File Offset: 0x000B7590
		public string AlgorithmName
		{
			get
			{
				return "Skein-MAC-" + (this.engine.BlockSize * 8).ToString() + "-" + (this.engine.OutputSize * 8).ToString();
			}
		}

		// Token: 0x06002B23 RID: 11043 RVA: 0x000B93D8 File Offset: 0x000B75D8
		public void Init(global::Org.BouncyCastle.Crypto.ICipherParameters parameters)
		{
			global::Org.BouncyCastle.Crypto.Parameters.SkeinParameters skeinParameters;
			if (parameters is global::Org.BouncyCastle.Crypto.Parameters.SkeinParameters)
			{
				skeinParameters = (global::Org.BouncyCastle.Crypto.Parameters.SkeinParameters)parameters;
			}
			else
			{
				if (!(parameters is global::Org.BouncyCastle.Crypto.Parameters.KeyParameter))
				{
					throw new global::System.ArgumentException("Invalid parameter passed to Skein MAC init - " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(parameters));
				}
				skeinParameters = new global::Org.BouncyCastle.Crypto.Parameters.SkeinParameters.Builder().SetKey(((global::Org.BouncyCastle.Crypto.Parameters.KeyParameter)parameters).GetKey()).Build();
			}
			if (skeinParameters.GetKey() == null)
			{
				throw new global::System.ArgumentException("Skein MAC requires a key parameter.");
			}
			this.engine.Init(skeinParameters);
		}

		// Token: 0x06002B24 RID: 11044 RVA: 0x000B9450 File Offset: 0x000B7650
		public int GetMacSize()
		{
			return this.engine.OutputSize;
		}

		// Token: 0x06002B25 RID: 11045 RVA: 0x000B945D File Offset: 0x000B765D
		public void Reset()
		{
			this.engine.Reset();
		}

		// Token: 0x06002B26 RID: 11046 RVA: 0x000B946A File Offset: 0x000B766A
		public void Update(byte inByte)
		{
			this.engine.Update(inByte);
		}

		// Token: 0x06002B27 RID: 11047 RVA: 0x000B9478 File Offset: 0x000B7678
		public void BlockUpdate(byte[] input, int inOff, int len)
		{
			this.engine.Update(input, inOff, len);
		}

		// Token: 0x06002B28 RID: 11048 RVA: 0x000B9488 File Offset: 0x000B7688
		public int DoFinal(byte[] output, int outOff)
		{
			return this.engine.DoFinal(output, outOff);
		}

		// Token: 0x040011DE RID: 4574
		public const int SKEIN_256 = 256;

		// Token: 0x040011DF RID: 4575
		public const int SKEIN_512 = 512;

		// Token: 0x040011E0 RID: 4576
		public const int SKEIN_1024 = 1024;

		// Token: 0x040011E1 RID: 4577
		private readonly global::Org.BouncyCastle.Crypto.Digests.SkeinEngine engine;
	}
}
