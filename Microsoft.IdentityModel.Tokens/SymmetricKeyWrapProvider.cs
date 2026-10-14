using System;
using System.Security.Cryptography;
using Microsoft.IdentityModel.Logging;

namespace Microsoft.IdentityModel.Tokens
{
	// Token: 0x0200000F RID: 15
	public class SymmetricKeyWrapProvider : global::Microsoft.IdentityModel.Tokens.KeyWrapProvider
	{
		// Token: 0x0600007B RID: 123 RVA: 0x000047AC File Offset: 0x000029AC
		public SymmetricKeyWrapProvider(global::Microsoft.IdentityModel.Tokens.SecurityKey key, string algorithm)
		{
			if (key == null)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("key");
			}
			if (string.IsNullOrEmpty(algorithm))
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("algorithm");
			}
			if (!this.IsSupportedAlgorithm(key, algorithm))
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::System.NotSupportedException(global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX10661: Unable to create the KeyWrapProvider.\nKeyWrapAlgorithm: '{0}', SecurityKey: '{1}'\n is not supported.", new object[]
				{
					algorithm,
					key
				})));
			}
			this.Algorithm = algorithm;
			this.Key = key;
			this._symmetricAlgorithm = this.GetSymmetricAlgorithm(key, algorithm);
			if (this._symmetricAlgorithm == null)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::System.InvalidOperationException(global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX10669: Failed to create symmetric algorithm.", new object[0])));
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600007C RID: 124 RVA: 0x0000484C File Offset: 0x00002A4C
		public override string Algorithm { get; }

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600007D RID: 125 RVA: 0x00004854 File Offset: 0x00002A54
		// (set) Token: 0x0600007E RID: 126 RVA: 0x0000485C File Offset: 0x00002A5C
		public override string Context { get; set; }

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600007F RID: 127 RVA: 0x00004865 File Offset: 0x00002A65
		public override global::Microsoft.IdentityModel.Tokens.SecurityKey Key { get; }

		// Token: 0x06000080 RID: 128 RVA: 0x0000486D File Offset: 0x00002A6D
		protected override void Dispose(bool disposing)
		{
			if (!this._disposed && disposing)
			{
				if (this._symmetricAlgorithm != null)
				{
					this._symmetricAlgorithm.Dispose();
					this._symmetricAlgorithm = null;
				}
				this._disposed = true;
			}
		}

		// Token: 0x06000081 RID: 129 RVA: 0x0000489C File Offset: 0x00002A9C
		private static byte[] GetBytes(ulong i)
		{
			byte[] bytes = global::System.BitConverter.GetBytes(i);
			if (global::System.BitConverter.IsLittleEndian)
			{
				global::System.Array.Reverse(bytes);
			}
			return bytes;
		}

		// Token: 0x06000082 RID: 130 RVA: 0x000048C0 File Offset: 0x00002AC0
		protected virtual global::System.Security.Cryptography.SymmetricAlgorithm GetSymmetricAlgorithm(global::Microsoft.IdentityModel.Tokens.SecurityKey key, string algorithm)
		{
			byte[] array = null;
			global::Microsoft.IdentityModel.Tokens.SymmetricSecurityKey symmetricSecurityKey = key as global::Microsoft.IdentityModel.Tokens.SymmetricSecurityKey;
			if (symmetricSecurityKey != null)
			{
				array = symmetricSecurityKey.Key;
			}
			else
			{
				global::Microsoft.IdentityModel.Tokens.JsonWebKey jsonWebKey = key as global::Microsoft.IdentityModel.Tokens.JsonWebKey;
				if (jsonWebKey != null && jsonWebKey.K != null && jsonWebKey.Kty == "oct")
				{
					array = global::Microsoft.IdentityModel.Tokens.Base64UrlEncoder.DecodeBytes(jsonWebKey.K);
				}
			}
			if (array == null)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::System.ArgumentException(global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX10657: The SecurityKey provided for the symmetric key wrap algorithm cannot be converted to byte array. Type is: '{0}'.", new object[]
				{
					key.GetType()
				})));
			}
			this.ValidateKeySize(array, algorithm);
			global::System.Security.Cryptography.SymmetricAlgorithm result;
			try
			{
				global::System.Security.Cryptography.Aes aes = global::System.Security.Cryptography.Aes.Create();
				aes.Mode = global::System.Security.Cryptography.CipherMode.ECB;
				aes.Padding = global::System.Security.Cryptography.PaddingMode.None;
				aes.KeySize = array.Length * 8;
				aes.Key = array;
				byte[] array2 = new byte[aes.BlockSize >> 3];
				global::Microsoft.IdentityModel.Tokens.Utility.Zero(array2);
				aes.IV = array2;
				result = aes;
			}
			catch (global::System.Exception innerException)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::System.InvalidOperationException(global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX10663: Failed to create symmetric algorithm with SecurityKey: '{0}', KeyWrapAlgorithm: '{1}'.", new object[]
				{
					key,
					algorithm
				}), innerException));
			}
			return result;
		}

		// Token: 0x06000083 RID: 131 RVA: 0x000049C0 File Offset: 0x00002BC0
		protected virtual bool IsSupportedAlgorithm(global::Microsoft.IdentityModel.Tokens.SecurityKey key, string algorithm)
		{
			if (key == null)
			{
				return false;
			}
			if (string.IsNullOrEmpty(algorithm))
			{
				return false;
			}
			if (algorithm.Equals("A128KW", global::System.StringComparison.Ordinal) || algorithm.Equals("A256KW", global::System.StringComparison.Ordinal))
			{
				if (key is global::Microsoft.IdentityModel.Tokens.SymmetricSecurityKey)
				{
					return true;
				}
				global::Microsoft.IdentityModel.Tokens.JsonWebKey jsonWebKey = key as global::Microsoft.IdentityModel.Tokens.JsonWebKey;
				if (jsonWebKey != null && jsonWebKey.K != null && jsonWebKey.Kty == "oct")
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00004A2C File Offset: 0x00002C2C
		public override byte[] UnwrapKey(byte[] keyBytes)
		{
			if (keyBytes == null || keyBytes.Length == 0)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("keyBytes");
			}
			if (keyBytes.Length % 8 != 0)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::System.ArgumentException(global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX10664: The length of input must be a multiple of 64 bits. The input size is: '{0}' bits.", new object[]
				{
					keyBytes.Length << 3
				}), "keyBytes"));
			}
			if (this._disposed)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::System.ObjectDisposedException(base.GetType().ToString()));
			}
			byte[] result;
			try
			{
				result = this.UnwrapKeyPrivate(keyBytes, 0, keyBytes.Length);
			}
			catch (global::System.Exception ex)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::Microsoft.IdentityModel.Tokens.SecurityTokenKeyWrapException(global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX10659: UnwrapKey failed, exception from cryptographic operation: '{0}'", new object[]
				{
					ex
				})));
			}
			return result;
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00004AE0 File Offset: 0x00002CE0
		private byte[] UnwrapKeyPrivate(byte[] inputBuffer, int inputOffset, int inputCount)
		{
			byte[] array = new byte[global::Microsoft.IdentityModel.Tokens.SymmetricKeyWrapProvider._blockSizeInBytes];
			global::System.Array.Copy(inputBuffer, inputOffset, array, 0, global::Microsoft.IdentityModel.Tokens.SymmetricKeyWrapProvider._blockSizeInBytes);
			int num = inputCount - global::Microsoft.IdentityModel.Tokens.SymmetricKeyWrapProvider._blockSizeInBytes >> 3;
			byte[] array2 = new byte[num << 3];
			global::System.Array.Copy(inputBuffer, inputOffset + global::Microsoft.IdentityModel.Tokens.SymmetricKeyWrapProvider._blockSizeInBytes, array2, 0, inputCount - global::Microsoft.IdentityModel.Tokens.SymmetricKeyWrapProvider._blockSizeInBytes);
			if (this._symmetricAlgorithmDecryptor == null)
			{
				object decryptorLock = global::Microsoft.IdentityModel.Tokens.SymmetricKeyWrapProvider._decryptorLock;
				lock (decryptorLock)
				{
					if (this._symmetricAlgorithmDecryptor == null)
					{
						this._symmetricAlgorithmDecryptor = this._symmetricAlgorithm.CreateDecryptor();
					}
				}
			}
			byte[] array3 = new byte[16];
			for (int i = 5; i >= 0; i--)
			{
				for (int j = num; j > 0; j--)
				{
					ulong i2 = (ulong)((long)(num * i + j));
					global::Microsoft.IdentityModel.Tokens.Utility.Xor(array, global::Microsoft.IdentityModel.Tokens.SymmetricKeyWrapProvider.GetBytes(i2), 0, true);
					global::System.Array.Copy(array, array3, global::Microsoft.IdentityModel.Tokens.SymmetricKeyWrapProvider._blockSizeInBytes);
					global::System.Array.Copy(array2, j - 1 << 3, array3, global::Microsoft.IdentityModel.Tokens.SymmetricKeyWrapProvider._blockSizeInBytes, global::Microsoft.IdentityModel.Tokens.SymmetricKeyWrapProvider._blockSizeInBytes);
					byte[] sourceArray = this._symmetricAlgorithmDecryptor.TransformFinalBlock(array3, 0, 16);
					global::System.Array.Copy(sourceArray, array, global::Microsoft.IdentityModel.Tokens.SymmetricKeyWrapProvider._blockSizeInBytes);
					global::System.Array.Copy(sourceArray, global::Microsoft.IdentityModel.Tokens.SymmetricKeyWrapProvider._blockSizeInBytes, array2, j - 1 << 3, global::Microsoft.IdentityModel.Tokens.SymmetricKeyWrapProvider._blockSizeInBytes);
				}
			}
			if (global::Microsoft.IdentityModel.Tokens.Utility.AreEqual(array, global::Microsoft.IdentityModel.Tokens.SymmetricKeyWrapProvider._defaultIV))
			{
				byte[] array4 = new byte[num << 3];
				for (int k = 0; k < num; k++)
				{
					global::System.Array.Copy(array2, k << 3, array4, k << 3, 8);
				}
				return array4;
			}
			throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::System.InvalidOperationException("IDX10665: Data is not authentic"));
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00004C68 File Offset: 0x00002E68
		private void ValidateKeySize(byte[] key, string algorithm)
		{
			if ("A128KW".Equals(algorithm, global::System.StringComparison.Ordinal))
			{
				if (key.Length != 16)
				{
					throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::System.ArgumentOutOfRangeException("Length", global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX10662: The KeyWrap algorithm '{0}' requires a key size of '{1}' bits. Key '{2}', is of size:'{3}'.", new object[]
					{
						"A128KW",
						128,
						this.Key.KeyId,
						key.Length << 3
					})));
				}
				return;
			}
			else
			{
				if (!"A256KW".Equals(algorithm, global::System.StringComparison.Ordinal))
				{
					throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::System.ArgumentOutOfRangeException("algorithm", global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX10652: The algorithm '{0}' is not supported.", new object[]
					{
						algorithm
					})));
				}
				if (key.Length != 32)
				{
					throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::System.ArgumentOutOfRangeException("Length", global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX10662: The KeyWrap algorithm '{0}' requires a key size of '{1}' bits. Key '{2}', is of size:'{3}'.", new object[]
					{
						"A256KW",
						256,
						this.Key.KeyId,
						key.Length << 3
					})));
				}
				return;
			}
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00004D64 File Offset: 0x00002F64
		public override byte[] WrapKey(byte[] keyBytes)
		{
			if (keyBytes == null || keyBytes.Length == 0)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("keyBytes");
			}
			if (keyBytes.Length % 8 != 0)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::System.ArgumentException(global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX10664: The length of input must be a multiple of 64 bits. The input size is: '{0}' bits.", new object[]
				{
					keyBytes.Length << 3
				}), "keyBytes"));
			}
			if (this._disposed)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::System.ObjectDisposedException(base.GetType().ToString()));
			}
			byte[] result;
			try
			{
				result = this.WrapKeyPrivate(keyBytes, 0, keyBytes.Length);
			}
			catch (global::System.Exception ex)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::Microsoft.IdentityModel.Tokens.SecurityTokenKeyWrapException(global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX10658: WrapKey failed, exception from cryptographic operation: '{0}'", new object[]
				{
					ex
				})));
			}
			return result;
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00004E18 File Offset: 0x00003018
		private byte[] WrapKeyPrivate(byte[] inputBuffer, int inputOffset, int inputCount)
		{
			byte[] array = global::Microsoft.IdentityModel.Tokens.SymmetricKeyWrapProvider._defaultIV.Clone() as byte[];
			int num = inputCount >> 3;
			byte[] array2 = new byte[num << 3];
			global::System.Array.Copy(inputBuffer, inputOffset, array2, 0, inputCount);
			if (this._symmetricAlgorithmEncryptor == null)
			{
				object encryptorLock = global::Microsoft.IdentityModel.Tokens.SymmetricKeyWrapProvider._encryptorLock;
				lock (encryptorLock)
				{
					if (this._symmetricAlgorithmEncryptor == null)
					{
						this._symmetricAlgorithmEncryptor = this._symmetricAlgorithm.CreateEncryptor();
					}
				}
			}
			byte[] array3 = new byte[16];
			for (int i = 0; i < 6; i++)
			{
				for (int j = 0; j < num; j++)
				{
					ulong i2 = (ulong)((long)(num * i + j + 1));
					global::System.Array.Copy(array, array3, array.Length);
					global::System.Array.Copy(array2, j << 3, array3, 8, 8);
					byte[] sourceArray = this._symmetricAlgorithmEncryptor.TransformFinalBlock(array3, 0, 16);
					global::System.Array.Copy(sourceArray, array, 8);
					global::Microsoft.IdentityModel.Tokens.Utility.Xor(array, global::Microsoft.IdentityModel.Tokens.SymmetricKeyWrapProvider.GetBytes(i2), 0, true);
					global::System.Array.Copy(sourceArray, 8, array2, j << 3, 8);
				}
			}
			byte[] array4 = new byte[num + 1 << 3];
			global::System.Array.Copy(array, array4, array.Length);
			for (int k = 0; k < num; k++)
			{
				global::System.Array.Copy(array2, k << 3, array4, k + 1 << 3, 8);
			}
			return array4;
		}

		// Token: 0x04000034 RID: 52
		private static readonly byte[] _defaultIV = new byte[]
		{
			166,
			166,
			166,
			166,
			166,
			166,
			166,
			166
		};

		// Token: 0x04000035 RID: 53
		private static readonly int _blockSizeInBits = 64;

		// Token: 0x04000036 RID: 54
		private static readonly int _blockSizeInBytes = global::Microsoft.IdentityModel.Tokens.SymmetricKeyWrapProvider._blockSizeInBits >> 3;

		// Token: 0x04000037 RID: 55
		private static object _encryptorLock = new object();

		// Token: 0x04000038 RID: 56
		private static object _decryptorLock = new object();

		// Token: 0x04000039 RID: 57
		private global::System.Security.Cryptography.SymmetricAlgorithm _symmetricAlgorithm;

		// Token: 0x0400003A RID: 58
		private global::System.Security.Cryptography.ICryptoTransform _symmetricAlgorithmEncryptor;

		// Token: 0x0400003B RID: 59
		private global::System.Security.Cryptography.ICryptoTransform _symmetricAlgorithmDecryptor;

		// Token: 0x0400003C RID: 60
		private bool _disposed;
	}
}
