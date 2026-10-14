using System;
using Org.BouncyCastle.Crypto.Macs;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Signers
{
	// Token: 0x020003A4 RID: 932
	public class HMacDsaKCalculator : global::Org.BouncyCastle.Crypto.Signers.IDsaKCalculator
	{
		// Token: 0x060025FC RID: 9724 RVA: 0x000A4C71 File Offset: 0x000A2E71
		public HMacDsaKCalculator(global::Org.BouncyCastle.Crypto.IDigest digest)
		{
			this.hMac = new global::Org.BouncyCastle.Crypto.Macs.HMac(digest);
			this.V = new byte[this.hMac.GetMacSize()];
			this.K = new byte[this.hMac.GetMacSize()];
		}

		// Token: 0x1700051E RID: 1310
		// (get) Token: 0x060025FD RID: 9725 RVA: 0x000A4CB1 File Offset: 0x000A2EB1
		public virtual bool IsDeterministic
		{
			get
			{
				return true;
			}
		}

		// Token: 0x060025FE RID: 9726 RVA: 0x000A4CB4 File Offset: 0x000A2EB4
		public virtual void Init(global::Org.BouncyCastle.Math.BigInteger n, global::Org.BouncyCastle.Security.SecureRandom random)
		{
			throw new global::System.InvalidOperationException("Operation not supported");
		}

		// Token: 0x060025FF RID: 9727 RVA: 0x000A4CC0 File Offset: 0x000A2EC0
		public void Init(global::Org.BouncyCastle.Math.BigInteger n, global::Org.BouncyCastle.Math.BigInteger d, byte[] message)
		{
			this.n = n;
			global::Org.BouncyCastle.Utilities.Arrays.Fill(this.V, 1);
			global::Org.BouncyCastle.Utilities.Arrays.Fill(this.K, 0);
			int unsignedByteLength = global::Org.BouncyCastle.Utilities.BigIntegers.GetUnsignedByteLength(n);
			byte[] x = new byte[unsignedByteLength];
			byte[] dVal = global::Org.BouncyCastle.Utilities.BigIntegers.AsUnsignedByteArray(d);
			global::System.Array.Copy(dVal, 0, x, x.Length - dVal.Length, dVal.Length);
			byte[] i = new byte[unsignedByteLength];
			global::Org.BouncyCastle.Math.BigInteger mInt = this.BitsToInt(message);
			if (mInt.CompareTo(n) >= 0)
			{
				mInt = mInt.Subtract(n);
			}
			byte[] mVal = global::Org.BouncyCastle.Utilities.BigIntegers.AsUnsignedByteArray(mInt);
			global::System.Array.Copy(mVal, 0, i, i.Length - mVal.Length, mVal.Length);
			this.hMac.Init(new global::Org.BouncyCastle.Crypto.Parameters.KeyParameter(this.K));
			this.hMac.BlockUpdate(this.V, 0, this.V.Length);
			this.hMac.Update(0);
			this.hMac.BlockUpdate(x, 0, x.Length);
			this.hMac.BlockUpdate(i, 0, i.Length);
			this.hMac.DoFinal(this.K, 0);
			this.hMac.Init(new global::Org.BouncyCastle.Crypto.Parameters.KeyParameter(this.K));
			this.hMac.BlockUpdate(this.V, 0, this.V.Length);
			this.hMac.DoFinal(this.V, 0);
			this.hMac.BlockUpdate(this.V, 0, this.V.Length);
			this.hMac.Update(1);
			this.hMac.BlockUpdate(x, 0, x.Length);
			this.hMac.BlockUpdate(i, 0, i.Length);
			this.hMac.DoFinal(this.K, 0);
			this.hMac.Init(new global::Org.BouncyCastle.Crypto.Parameters.KeyParameter(this.K));
			this.hMac.BlockUpdate(this.V, 0, this.V.Length);
			this.hMac.DoFinal(this.V, 0);
		}

		// Token: 0x06002600 RID: 9728 RVA: 0x000A4EA0 File Offset: 0x000A30A0
		public virtual global::Org.BouncyCastle.Math.BigInteger NextK()
		{
			byte[] t = new byte[global::Org.BouncyCastle.Utilities.BigIntegers.GetUnsignedByteLength(this.n)];
			global::Org.BouncyCastle.Math.BigInteger i;
			for (;;)
			{
				int len;
				for (int tOff = 0; tOff < t.Length; tOff += len)
				{
					this.hMac.BlockUpdate(this.V, 0, this.V.Length);
					this.hMac.DoFinal(this.V, 0);
					len = global::System.Math.Min(t.Length - tOff, this.V.Length);
					global::System.Array.Copy(this.V, 0, t, tOff, len);
				}
				i = this.BitsToInt(t);
				if (i.SignValue > 0 && i.CompareTo(this.n) < 0)
				{
					break;
				}
				this.hMac.BlockUpdate(this.V, 0, this.V.Length);
				this.hMac.Update(0);
				this.hMac.DoFinal(this.K, 0);
				this.hMac.Init(new global::Org.BouncyCastle.Crypto.Parameters.KeyParameter(this.K));
				this.hMac.BlockUpdate(this.V, 0, this.V.Length);
				this.hMac.DoFinal(this.V, 0);
			}
			return i;
		}

		// Token: 0x06002601 RID: 9729 RVA: 0x000A4FC0 File Offset: 0x000A31C0
		private global::Org.BouncyCastle.Math.BigInteger BitsToInt(byte[] t)
		{
			global::Org.BouncyCastle.Math.BigInteger v = new global::Org.BouncyCastle.Math.BigInteger(1, t);
			if (t.Length * 8 > this.n.BitLength)
			{
				v = v.ShiftRight(t.Length * 8 - this.n.BitLength);
			}
			return v;
		}

		// Token: 0x04000F1C RID: 3868
		private readonly global::Org.BouncyCastle.Crypto.Macs.HMac hMac;

		// Token: 0x04000F1D RID: 3869
		private readonly byte[] K;

		// Token: 0x04000F1E RID: 3870
		private readonly byte[] V;

		// Token: 0x04000F1F RID: 3871
		private global::Org.BouncyCastle.Math.BigInteger n;
	}
}
