using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000351 RID: 849
	public class Ssl3Mac : global::Org.BouncyCastle.Crypto.IMac
	{
		// Token: 0x060022D4 RID: 8916 RVA: 0x00098D91 File Offset: 0x00096F91
		public Ssl3Mac(global::Org.BouncyCastle.Crypto.IDigest digest)
		{
			this.digest = digest;
			if (digest.GetDigestSize() == 20)
			{
				this.padLength = 40;
				return;
			}
			this.padLength = 48;
		}

		// Token: 0x170004D1 RID: 1233
		// (get) Token: 0x060022D5 RID: 8917 RVA: 0x00098DBB File Offset: 0x00096FBB
		public virtual string AlgorithmName
		{
			get
			{
				return this.digest.AlgorithmName + "/SSL3MAC";
			}
		}

		// Token: 0x060022D6 RID: 8918 RVA: 0x00098DD2 File Offset: 0x00096FD2
		public virtual void Init(global::Org.BouncyCastle.Crypto.ICipherParameters parameters)
		{
			this.secret = global::Org.BouncyCastle.Utilities.Arrays.Clone(((global::Org.BouncyCastle.Crypto.Parameters.KeyParameter)parameters).GetKey());
			this.Reset();
		}

		// Token: 0x060022D7 RID: 8919 RVA: 0x00098DF0 File Offset: 0x00096FF0
		public virtual int GetMacSize()
		{
			return this.digest.GetDigestSize();
		}

		// Token: 0x060022D8 RID: 8920 RVA: 0x00098DFD File Offset: 0x00096FFD
		public virtual void Update(byte input)
		{
			this.digest.Update(input);
		}

		// Token: 0x060022D9 RID: 8921 RVA: 0x00098E0B File Offset: 0x0009700B
		public virtual void BlockUpdate(byte[] input, int inOff, int len)
		{
			this.digest.BlockUpdate(input, inOff, len);
		}

		// Token: 0x060022DA RID: 8922 RVA: 0x00098E1C File Offset: 0x0009701C
		public virtual int DoFinal(byte[] output, int outOff)
		{
			byte[] tmp = new byte[this.digest.GetDigestSize()];
			this.digest.DoFinal(tmp, 0);
			this.digest.BlockUpdate(this.secret, 0, this.secret.Length);
			this.digest.BlockUpdate(global::Org.BouncyCastle.Crypto.Tls.Ssl3Mac.OPAD, 0, this.padLength);
			this.digest.BlockUpdate(tmp, 0, tmp.Length);
			int result = this.digest.DoFinal(output, outOff);
			this.Reset();
			return result;
		}

		// Token: 0x060022DB RID: 8923 RVA: 0x00098E9C File Offset: 0x0009709C
		public virtual void Reset()
		{
			this.digest.Reset();
			this.digest.BlockUpdate(this.secret, 0, this.secret.Length);
			this.digest.BlockUpdate(global::Org.BouncyCastle.Crypto.Tls.Ssl3Mac.IPAD, 0, this.padLength);
		}

		// Token: 0x060022DC RID: 8924 RVA: 0x00098EDA File Offset: 0x000970DA
		private static byte[] GenPad(byte b, int count)
		{
			byte[] array = new byte[count];
			global::Org.BouncyCastle.Utilities.Arrays.Fill(array, b);
			return array;
		}

		// Token: 0x04000E24 RID: 3620
		private const byte IPAD_BYTE = 54;

		// Token: 0x04000E25 RID: 3621
		private const byte OPAD_BYTE = 92;

		// Token: 0x04000E26 RID: 3622
		internal static readonly byte[] IPAD = global::Org.BouncyCastle.Crypto.Tls.Ssl3Mac.GenPad(54, 48);

		// Token: 0x04000E27 RID: 3623
		internal static readonly byte[] OPAD = global::Org.BouncyCastle.Crypto.Tls.Ssl3Mac.GenPad(92, 48);

		// Token: 0x04000E28 RID: 3624
		private readonly global::Org.BouncyCastle.Crypto.IDigest digest;

		// Token: 0x04000E29 RID: 3625
		private readonly int padLength;

		// Token: 0x04000E2A RID: 3626
		private byte[] secret;
	}
}
