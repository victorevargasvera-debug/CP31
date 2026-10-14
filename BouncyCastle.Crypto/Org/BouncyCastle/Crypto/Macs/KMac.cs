using System;
using Org.BouncyCastle.Crypto.Digests;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Macs
{
	// Token: 0x02000455 RID: 1109
	public class KMac : global::Org.BouncyCastle.Crypto.IMac, global::Org.BouncyCastle.Crypto.IXof, global::Org.BouncyCastle.Crypto.IDigest
	{
		// Token: 0x06002AF8 RID: 11000 RVA: 0x000B82AF File Offset: 0x000B64AF
		public KMac(int bitLength, byte[] S)
		{
			this.cshake = new global::Org.BouncyCastle.Crypto.Digests.CShakeDigest(bitLength, global::Org.BouncyCastle.Utilities.Strings.ToAsciiByteArray("KMAC"), S);
			this.bitLength = bitLength;
			this.outputLength = bitLength * 2 / 8;
		}

		// Token: 0x170005EA RID: 1514
		// (get) Token: 0x06002AF9 RID: 11001 RVA: 0x000B82E0 File Offset: 0x000B64E0
		public string AlgorithmName
		{
			get
			{
				return "KMAC" + this.cshake.AlgorithmName.Substring(6);
			}
		}

		// Token: 0x06002AFA RID: 11002 RVA: 0x000B82FD File Offset: 0x000B64FD
		public void BlockUpdate(byte[] input, int inOff, int len)
		{
			if (!this.initialised)
			{
				throw new global::System.InvalidOperationException("KMAC not initialized");
			}
			this.cshake.BlockUpdate(input, inOff, len);
		}

		// Token: 0x06002AFB RID: 11003 RVA: 0x000B8320 File Offset: 0x000B6520
		public int DoFinal(byte[] output, int outOff)
		{
			if (this.firstOutput)
			{
				if (!this.initialised)
				{
					throw new global::System.InvalidOperationException("KMAC not initialized");
				}
				byte[] encOut = global::Org.BouncyCastle.Crypto.Digests.XofUtilities.RightEncode((long)(this.GetMacSize() * 8));
				this.cshake.BlockUpdate(encOut, 0, encOut.Length);
			}
			int result = this.cshake.DoFinal(output, outOff, this.GetMacSize());
			this.Reset();
			return result;
		}

		// Token: 0x06002AFC RID: 11004 RVA: 0x000B8380 File Offset: 0x000B6580
		public int DoFinal(byte[] output, int outOff, int outLen)
		{
			if (this.firstOutput)
			{
				if (!this.initialised)
				{
					throw new global::System.InvalidOperationException("KMAC not initialized");
				}
				byte[] encOut = global::Org.BouncyCastle.Crypto.Digests.XofUtilities.RightEncode((long)(outLen * 8));
				this.cshake.BlockUpdate(encOut, 0, encOut.Length);
			}
			int result = this.cshake.DoFinal(output, outOff, outLen);
			this.Reset();
			return result;
		}

		// Token: 0x06002AFD RID: 11005 RVA: 0x000B83D8 File Offset: 0x000B65D8
		public int DoOutput(byte[] output, int outOff, int outLen)
		{
			if (this.firstOutput)
			{
				if (!this.initialised)
				{
					throw new global::System.InvalidOperationException("KMAC not initialized");
				}
				byte[] encOut = global::Org.BouncyCastle.Crypto.Digests.XofUtilities.RightEncode(0L);
				this.cshake.BlockUpdate(encOut, 0, encOut.Length);
				this.firstOutput = false;
			}
			return this.cshake.DoOutput(output, outOff, outLen);
		}

		// Token: 0x06002AFE RID: 11006 RVA: 0x000B842D File Offset: 0x000B662D
		public int GetByteLength()
		{
			return this.cshake.GetByteLength();
		}

		// Token: 0x06002AFF RID: 11007 RVA: 0x000B843A File Offset: 0x000B663A
		public int GetDigestSize()
		{
			return this.outputLength;
		}

		// Token: 0x06002B00 RID: 11008 RVA: 0x000B8442 File Offset: 0x000B6642
		public int GetMacSize()
		{
			return this.outputLength;
		}

		// Token: 0x06002B01 RID: 11009 RVA: 0x000B844C File Offset: 0x000B664C
		public void Init(global::Org.BouncyCastle.Crypto.ICipherParameters parameters)
		{
			global::Org.BouncyCastle.Crypto.Parameters.KeyParameter kParam = (global::Org.BouncyCastle.Crypto.Parameters.KeyParameter)parameters;
			this.key = global::Org.BouncyCastle.Utilities.Arrays.Clone(kParam.GetKey());
			this.initialised = true;
			this.Reset();
		}

		// Token: 0x06002B02 RID: 11010 RVA: 0x000B8480 File Offset: 0x000B6680
		public void Reset()
		{
			this.cshake.Reset();
			if (this.key != null)
			{
				if (this.bitLength == 128)
				{
					this.bytePad(this.key, 168);
				}
				else
				{
					this.bytePad(this.key, 136);
				}
			}
			this.firstOutput = true;
		}

		// Token: 0x06002B03 RID: 11011 RVA: 0x000B84D8 File Offset: 0x000B66D8
		private void bytePad(byte[] X, int w)
		{
			byte[] bytes = global::Org.BouncyCastle.Crypto.Digests.XofUtilities.LeftEncode((long)w);
			this.BlockUpdate(bytes, 0, bytes.Length);
			byte[] encX = global::Org.BouncyCastle.Crypto.Macs.KMac.encode(X);
			this.BlockUpdate(encX, 0, encX.Length);
			int required = w - (bytes.Length + encX.Length) % w;
			if (required > 0 && required != w)
			{
				while (required > global::Org.BouncyCastle.Crypto.Macs.KMac.padding.Length)
				{
					this.BlockUpdate(global::Org.BouncyCastle.Crypto.Macs.KMac.padding, 0, global::Org.BouncyCastle.Crypto.Macs.KMac.padding.Length);
					required -= global::Org.BouncyCastle.Crypto.Macs.KMac.padding.Length;
				}
				this.BlockUpdate(global::Org.BouncyCastle.Crypto.Macs.KMac.padding, 0, required);
			}
		}

		// Token: 0x06002B04 RID: 11012 RVA: 0x000B8554 File Offset: 0x000B6754
		private static byte[] encode(byte[] X)
		{
			return global::Org.BouncyCastle.Utilities.Arrays.Concatenate(global::Org.BouncyCastle.Crypto.Digests.XofUtilities.LeftEncode((long)(X.Length * 8)), X);
		}

		// Token: 0x06002B05 RID: 11013 RVA: 0x000B8567 File Offset: 0x000B6767
		public void Update(byte input)
		{
			if (!this.initialised)
			{
				throw new global::System.InvalidOperationException("KMAC not initialized");
			}
			this.cshake.Update(input);
		}

		// Token: 0x040011B5 RID: 4533
		private static readonly byte[] padding = new byte[100];

		// Token: 0x040011B6 RID: 4534
		private readonly global::Org.BouncyCastle.Crypto.Digests.CShakeDigest cshake;

		// Token: 0x040011B7 RID: 4535
		private readonly int bitLength;

		// Token: 0x040011B8 RID: 4536
		private readonly int outputLength;

		// Token: 0x040011B9 RID: 4537
		private byte[] key;

		// Token: 0x040011BA RID: 4538
		private bool initialised;

		// Token: 0x040011BB RID: 4539
		private bool firstOutput;
	}
}
