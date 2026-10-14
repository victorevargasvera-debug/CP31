using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Generators
{
	// Token: 0x0200047D RID: 1149
	public class Pkcs12ParametersGenerator : global::Org.BouncyCastle.Crypto.PbeParametersGenerator
	{
		// Token: 0x06002C1A RID: 11290 RVA: 0x000BE59B File Offset: 0x000BC79B
		public Pkcs12ParametersGenerator(global::Org.BouncyCastle.Crypto.IDigest digest)
		{
			this.digest = digest;
			this.u = digest.GetDigestSize();
			this.v = digest.GetByteLength();
		}

		// Token: 0x06002C1B RID: 11291 RVA: 0x000BE5C4 File Offset: 0x000BC7C4
		private void Adjust(byte[] a, int aOff, byte[] b)
		{
			int x = (int)((b[b.Length - 1] & byte.MaxValue) + (a[aOff + b.Length - 1] & byte.MaxValue) + 1);
			a[aOff + b.Length - 1] = (byte)x;
			x = (int)((uint)x >> 8);
			for (int i = b.Length - 2; i >= 0; i--)
			{
				x += (int)((b[i] & byte.MaxValue) + (a[aOff + i] & byte.MaxValue));
				a[aOff + i] = (byte)x;
				x = (int)((uint)x >> 8);
			}
		}

		// Token: 0x06002C1C RID: 11292 RVA: 0x000BE634 File Offset: 0x000BC834
		private byte[] GenerateDerivedKey(int idByte, int n)
		{
			byte[] D = new byte[this.v];
			byte[] dKey = new byte[n];
			for (int i = 0; i != D.Length; i++)
			{
				D[i] = (byte)idByte;
			}
			byte[] S;
			if (this.mSalt != null && this.mSalt.Length != 0)
			{
				S = new byte[this.v * ((this.mSalt.Length + this.v - 1) / this.v)];
				for (int j = 0; j != S.Length; j++)
				{
					S[j] = this.mSalt[j % this.mSalt.Length];
				}
			}
			else
			{
				S = new byte[0];
			}
			byte[] P;
			if (this.mPassword != null && this.mPassword.Length != 0)
			{
				P = new byte[this.v * ((this.mPassword.Length + this.v - 1) / this.v)];
				for (int k = 0; k != P.Length; k++)
				{
					P[k] = this.mPassword[k % this.mPassword.Length];
				}
			}
			else
			{
				P = new byte[0];
			}
			byte[] I = new byte[S.Length + P.Length];
			global::System.Array.Copy(S, 0, I, 0, S.Length);
			global::System.Array.Copy(P, 0, I, S.Length, P.Length);
			byte[] B = new byte[this.v];
			int c = (n + this.u - 1) / this.u;
			byte[] A = new byte[this.u];
			for (int l = 1; l <= c; l++)
			{
				this.digest.BlockUpdate(D, 0, D.Length);
				this.digest.BlockUpdate(I, 0, I.Length);
				this.digest.DoFinal(A, 0);
				for (int m = 1; m != this.mIterationCount; m++)
				{
					this.digest.BlockUpdate(A, 0, A.Length);
					this.digest.DoFinal(A, 0);
				}
				for (int j2 = 0; j2 != B.Length; j2++)
				{
					B[j2] = A[j2 % A.Length];
				}
				for (int j3 = 0; j3 != I.Length / this.v; j3++)
				{
					this.Adjust(I, j3 * this.v, B);
				}
				if (l == c)
				{
					global::System.Array.Copy(A, 0, dKey, (l - 1) * this.u, dKey.Length - (l - 1) * this.u);
				}
				else
				{
					global::System.Array.Copy(A, 0, dKey, (l - 1) * this.u, A.Length);
				}
			}
			return dKey;
		}

		// Token: 0x06002C1D RID: 11293 RVA: 0x000BE8A2 File Offset: 0x000BCAA2
		public override global::Org.BouncyCastle.Crypto.ICipherParameters GenerateDerivedParameters(int keySize)
		{
			keySize /= 8;
			return new global::Org.BouncyCastle.Crypto.Parameters.KeyParameter(this.GenerateDerivedKey(1, keySize), 0, keySize);
		}

		// Token: 0x06002C1E RID: 11294 RVA: 0x000BE8B8 File Offset: 0x000BCAB8
		public override global::Org.BouncyCastle.Crypto.ICipherParameters GenerateDerivedParameters(string algorithm, int keySize)
		{
			keySize /= 8;
			byte[] dKey = this.GenerateDerivedKey(1, keySize);
			return global::Org.BouncyCastle.Security.ParameterUtilities.CreateKeyParameter(algorithm, dKey, 0, keySize);
		}

		// Token: 0x06002C1F RID: 11295 RVA: 0x000BE8DC File Offset: 0x000BCADC
		public override global::Org.BouncyCastle.Crypto.ICipherParameters GenerateDerivedParameters(int keySize, int ivSize)
		{
			keySize /= 8;
			ivSize /= 8;
			byte[] key = this.GenerateDerivedKey(1, keySize);
			byte[] iv = this.GenerateDerivedKey(2, ivSize);
			return new global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV(new global::Org.BouncyCastle.Crypto.Parameters.KeyParameter(key, 0, keySize), iv, 0, ivSize);
		}

		// Token: 0x06002C20 RID: 11296 RVA: 0x000BE914 File Offset: 0x000BCB14
		public override global::Org.BouncyCastle.Crypto.ICipherParameters GenerateDerivedParameters(string algorithm, int keySize, int ivSize)
		{
			keySize /= 8;
			ivSize /= 8;
			byte[] dKey = this.GenerateDerivedKey(1, keySize);
			global::Org.BouncyCastle.Crypto.ICipherParameters parameters = global::Org.BouncyCastle.Security.ParameterUtilities.CreateKeyParameter(algorithm, dKey, 0, keySize);
			byte[] iv = this.GenerateDerivedKey(2, ivSize);
			return new global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV(parameters, iv, 0, ivSize);
		}

		// Token: 0x06002C21 RID: 11297 RVA: 0x000BE94E File Offset: 0x000BCB4E
		public override global::Org.BouncyCastle.Crypto.ICipherParameters GenerateDerivedMacParameters(int keySize)
		{
			keySize /= 8;
			return new global::Org.BouncyCastle.Crypto.Parameters.KeyParameter(this.GenerateDerivedKey(3, keySize), 0, keySize);
		}

		// Token: 0x04001265 RID: 4709
		public const int KeyMaterial = 1;

		// Token: 0x04001266 RID: 4710
		public const int IVMaterial = 2;

		// Token: 0x04001267 RID: 4711
		public const int MacMaterial = 3;

		// Token: 0x04001268 RID: 4712
		private readonly global::Org.BouncyCastle.Crypto.IDigest digest;

		// Token: 0x04001269 RID: 4713
		private readonly int u;

		// Token: 0x0400126A RID: 4714
		private readonly int v;
	}
}
