using System;
using System.Collections;
using System.Globalization;
using System.IO;
using System.Text;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Parameters
{
	// Token: 0x02000409 RID: 1033
	public class SkeinParameters : global::Org.BouncyCastle.Crypto.ICipherParameters
	{
		// Token: 0x06002887 RID: 10375 RVA: 0x000ACF7B File Offset: 0x000AB17B
		public SkeinParameters() : this(global::Org.BouncyCastle.Utilities.Platform.CreateHashtable())
		{
		}

		// Token: 0x06002888 RID: 10376 RVA: 0x000ACF88 File Offset: 0x000AB188
		private SkeinParameters(global::System.Collections.IDictionary parameters)
		{
			this.parameters = parameters;
		}

		// Token: 0x06002889 RID: 10377 RVA: 0x000ACF97 File Offset: 0x000AB197
		public global::System.Collections.IDictionary GetParameters()
		{
			return this.parameters;
		}

		// Token: 0x0600288A RID: 10378 RVA: 0x000ACF9F File Offset: 0x000AB19F
		public byte[] GetKey()
		{
			return (byte[])this.parameters[0];
		}

		// Token: 0x0600288B RID: 10379 RVA: 0x000ACFB7 File Offset: 0x000AB1B7
		public byte[] GetPersonalisation()
		{
			return (byte[])this.parameters[8];
		}

		// Token: 0x0600288C RID: 10380 RVA: 0x000ACFCF File Offset: 0x000AB1CF
		public byte[] GetPublicKey()
		{
			return (byte[])this.parameters[12];
		}

		// Token: 0x0600288D RID: 10381 RVA: 0x000ACFE8 File Offset: 0x000AB1E8
		public byte[] GetKeyIdentifier()
		{
			return (byte[])this.parameters[16];
		}

		// Token: 0x0600288E RID: 10382 RVA: 0x000AD001 File Offset: 0x000AB201
		public byte[] GetNonce()
		{
			return (byte[])this.parameters[20];
		}

		// Token: 0x04001075 RID: 4213
		public const int PARAM_TYPE_KEY = 0;

		// Token: 0x04001076 RID: 4214
		public const int PARAM_TYPE_CONFIG = 4;

		// Token: 0x04001077 RID: 4215
		public const int PARAM_TYPE_PERSONALISATION = 8;

		// Token: 0x04001078 RID: 4216
		public const int PARAM_TYPE_PUBLIC_KEY = 12;

		// Token: 0x04001079 RID: 4217
		public const int PARAM_TYPE_KEY_IDENTIFIER = 16;

		// Token: 0x0400107A RID: 4218
		public const int PARAM_TYPE_NONCE = 20;

		// Token: 0x0400107B RID: 4219
		public const int PARAM_TYPE_MESSAGE = 48;

		// Token: 0x0400107C RID: 4220
		public const int PARAM_TYPE_OUTPUT = 63;

		// Token: 0x0400107D RID: 4221
		private global::System.Collections.IDictionary parameters;

		// Token: 0x0200080B RID: 2059
		public class Builder
		{
			// Token: 0x06004671 RID: 18033 RVA: 0x00136BF0 File Offset: 0x00134DF0
			public Builder()
			{
			}

			// Token: 0x06004672 RID: 18034 RVA: 0x00136C04 File Offset: 0x00134E04
			public Builder(global::System.Collections.IDictionary paramsMap)
			{
				foreach (object obj in paramsMap.Keys)
				{
					int key = (int)obj;
					this.parameters.Add(key, paramsMap[key]);
				}
			}

			// Token: 0x06004673 RID: 18035 RVA: 0x00136C64 File Offset: 0x00134E64
			public Builder(global::Org.BouncyCastle.Crypto.Parameters.SkeinParameters parameters)
			{
				foreach (object obj in parameters.parameters.Keys)
				{
					int key = (int)obj;
					this.parameters.Add(key, parameters.parameters[key]);
				}
			}

			// Token: 0x06004674 RID: 18036 RVA: 0x00136CCC File Offset: 0x00134ECC
			public global::Org.BouncyCastle.Crypto.Parameters.SkeinParameters.Builder Set(int type, byte[] value)
			{
				if (value == null)
				{
					throw new global::System.ArgumentException("Parameter value must not be null.");
				}
				if (type != 0 && (type <= 4 || type >= 63 || type == 48))
				{
					throw new global::System.ArgumentException("Parameter types must be in the range 0,5..47,49..62.");
				}
				if (type == 4)
				{
					throw new global::System.ArgumentException("Parameter type " + 4.ToString() + " is reserved for internal use.");
				}
				this.parameters.Add(type, value);
				return this;
			}

			// Token: 0x06004675 RID: 18037 RVA: 0x00136D38 File Offset: 0x00134F38
			public global::Org.BouncyCastle.Crypto.Parameters.SkeinParameters.Builder SetKey(byte[] key)
			{
				return this.Set(0, key);
			}

			// Token: 0x06004676 RID: 18038 RVA: 0x00136D42 File Offset: 0x00134F42
			public global::Org.BouncyCastle.Crypto.Parameters.SkeinParameters.Builder SetPersonalisation(byte[] personalisation)
			{
				return this.Set(8, personalisation);
			}

			// Token: 0x06004677 RID: 18039 RVA: 0x00136D4C File Offset: 0x00134F4C
			public global::Org.BouncyCastle.Crypto.Parameters.SkeinParameters.Builder SetPersonalisation(global::System.DateTime date, string emailAddress, string distinguisher)
			{
				global::Org.BouncyCastle.Crypto.Parameters.SkeinParameters.Builder result;
				try
				{
					global::System.IO.MemoryStream bout = new global::System.IO.MemoryStream();
					global::System.IO.StreamWriter streamWriter = new global::System.IO.StreamWriter(bout, global::System.Text.Encoding.UTF8);
					streamWriter.Write(date.ToString("YYYYMMDD", global::System.Globalization.CultureInfo.InvariantCulture));
					streamWriter.Write(" ");
					streamWriter.Write(emailAddress);
					streamWriter.Write(" ");
					streamWriter.Write(distinguisher);
					global::Org.BouncyCastle.Utilities.Platform.Dispose(streamWriter);
					result = this.Set(8, bout.ToArray());
				}
				catch (global::System.IO.IOException e)
				{
					throw new global::System.InvalidOperationException("Byte I/O failed.", e);
				}
				return result;
			}

			// Token: 0x06004678 RID: 18040 RVA: 0x00136DD8 File Offset: 0x00134FD8
			public global::Org.BouncyCastle.Crypto.Parameters.SkeinParameters.Builder SetPublicKey(byte[] publicKey)
			{
				return this.Set(12, publicKey);
			}

			// Token: 0x06004679 RID: 18041 RVA: 0x00136DE3 File Offset: 0x00134FE3
			public global::Org.BouncyCastle.Crypto.Parameters.SkeinParameters.Builder SetKeyIdentifier(byte[] keyIdentifier)
			{
				return this.Set(16, keyIdentifier);
			}

			// Token: 0x0600467A RID: 18042 RVA: 0x00136DEE File Offset: 0x00134FEE
			public global::Org.BouncyCastle.Crypto.Parameters.SkeinParameters.Builder SetNonce(byte[] nonce)
			{
				return this.Set(20, nonce);
			}

			// Token: 0x0600467B RID: 18043 RVA: 0x00136DF9 File Offset: 0x00134FF9
			public global::Org.BouncyCastle.Crypto.Parameters.SkeinParameters Build()
			{
				return new global::Org.BouncyCastle.Crypto.Parameters.SkeinParameters(this.parameters);
			}

			// Token: 0x040024C8 RID: 9416
			private global::System.Collections.IDictionary parameters = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();
		}
	}
}
