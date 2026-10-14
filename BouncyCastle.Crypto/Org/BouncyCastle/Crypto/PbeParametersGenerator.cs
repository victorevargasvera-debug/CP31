using System;
using System.Text;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto
{
	// Token: 0x020002EA RID: 746
	public abstract class PbeParametersGenerator
	{
		// Token: 0x06001FE9 RID: 8169 RVA: 0x0009017A File Offset: 0x0008E37A
		public virtual void Init(byte[] password, byte[] salt, int iterationCount)
		{
			if (password == null)
			{
				throw new global::System.ArgumentNullException("password");
			}
			if (salt == null)
			{
				throw new global::System.ArgumentNullException("salt");
			}
			this.mPassword = global::Org.BouncyCastle.Utilities.Arrays.Clone(password);
			this.mSalt = global::Org.BouncyCastle.Utilities.Arrays.Clone(salt);
			this.mIterationCount = iterationCount;
		}

		// Token: 0x17000468 RID: 1128
		// (get) Token: 0x06001FEA RID: 8170 RVA: 0x000901B7 File Offset: 0x0008E3B7
		public virtual byte[] Password
		{
			get
			{
				return global::Org.BouncyCastle.Utilities.Arrays.Clone(this.mPassword);
			}
		}

		// Token: 0x06001FEB RID: 8171 RVA: 0x000901C4 File Offset: 0x0008E3C4
		[global::System.Obsolete("Use 'Password' property")]
		public byte[] GetPassword()
		{
			return this.Password;
		}

		// Token: 0x17000469 RID: 1129
		// (get) Token: 0x06001FEC RID: 8172 RVA: 0x000901CC File Offset: 0x0008E3CC
		public virtual byte[] Salt
		{
			get
			{
				return global::Org.BouncyCastle.Utilities.Arrays.Clone(this.mSalt);
			}
		}

		// Token: 0x06001FED RID: 8173 RVA: 0x000901D9 File Offset: 0x0008E3D9
		[global::System.Obsolete("Use 'Salt' property")]
		public byte[] GetSalt()
		{
			return this.Salt;
		}

		// Token: 0x1700046A RID: 1130
		// (get) Token: 0x06001FEE RID: 8174 RVA: 0x000901E1 File Offset: 0x0008E3E1
		public virtual int IterationCount
		{
			get
			{
				return this.mIterationCount;
			}
		}

		// Token: 0x06001FEF RID: 8175
		[global::System.Obsolete("Use version with 'algorithm' parameter")]
		public abstract global::Org.BouncyCastle.Crypto.ICipherParameters GenerateDerivedParameters(int keySize);

		// Token: 0x06001FF0 RID: 8176
		public abstract global::Org.BouncyCastle.Crypto.ICipherParameters GenerateDerivedParameters(string algorithm, int keySize);

		// Token: 0x06001FF1 RID: 8177
		[global::System.Obsolete("Use version with 'algorithm' parameter")]
		public abstract global::Org.BouncyCastle.Crypto.ICipherParameters GenerateDerivedParameters(int keySize, int ivSize);

		// Token: 0x06001FF2 RID: 8178
		public abstract global::Org.BouncyCastle.Crypto.ICipherParameters GenerateDerivedParameters(string algorithm, int keySize, int ivSize);

		// Token: 0x06001FF3 RID: 8179
		public abstract global::Org.BouncyCastle.Crypto.ICipherParameters GenerateDerivedMacParameters(int keySize);

		// Token: 0x06001FF4 RID: 8180 RVA: 0x000901E9 File Offset: 0x0008E3E9
		public static byte[] Pkcs5PasswordToBytes(char[] password)
		{
			if (password == null)
			{
				return new byte[0];
			}
			return global::Org.BouncyCastle.Utilities.Strings.ToByteArray(password);
		}

		// Token: 0x06001FF5 RID: 8181 RVA: 0x000901FB File Offset: 0x0008E3FB
		[global::System.Obsolete("Use version taking 'char[]' instead")]
		public static byte[] Pkcs5PasswordToBytes(string password)
		{
			if (password == null)
			{
				return new byte[0];
			}
			return global::Org.BouncyCastle.Utilities.Strings.ToByteArray(password);
		}

		// Token: 0x06001FF6 RID: 8182 RVA: 0x0009020D File Offset: 0x0008E40D
		public static byte[] Pkcs5PasswordToUtf8Bytes(char[] password)
		{
			if (password == null)
			{
				return new byte[0];
			}
			return global::System.Text.Encoding.UTF8.GetBytes(password);
		}

		// Token: 0x06001FF7 RID: 8183 RVA: 0x00090224 File Offset: 0x0008E424
		[global::System.Obsolete("Use version taking 'char[]' instead")]
		public static byte[] Pkcs5PasswordToUtf8Bytes(string password)
		{
			if (password == null)
			{
				return new byte[0];
			}
			return global::System.Text.Encoding.UTF8.GetBytes(password);
		}

		// Token: 0x06001FF8 RID: 8184 RVA: 0x0009023B File Offset: 0x0008E43B
		public static byte[] Pkcs12PasswordToBytes(char[] password)
		{
			return global::Org.BouncyCastle.Crypto.PbeParametersGenerator.Pkcs12PasswordToBytes(password, false);
		}

		// Token: 0x06001FF9 RID: 8185 RVA: 0x00090244 File Offset: 0x0008E444
		public static byte[] Pkcs12PasswordToBytes(char[] password, bool wrongPkcs12Zero)
		{
			if (password == null || password.Length < 1)
			{
				return new byte[wrongPkcs12Zero ? 2 : 0];
			}
			byte[] bytes = new byte[(password.Length + 1) * 2];
			global::System.Text.Encoding.BigEndianUnicode.GetBytes(password, 0, password.Length, bytes, 0);
			return bytes;
		}

		// Token: 0x04000B31 RID: 2865
		protected byte[] mPassword;

		// Token: 0x04000B32 RID: 2866
		protected byte[] mSalt;

		// Token: 0x04000B33 RID: 2867
		protected int mIterationCount;
	}
}
