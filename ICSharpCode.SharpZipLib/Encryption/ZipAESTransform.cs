using System;
using System.Security.Cryptography;
using ICSharpCode.SharpZipLib.Core;

namespace ICSharpCode.SharpZipLib.Encryption
{
	// Token: 0x0200005B RID: 91
	internal class ZipAESTransform : global::System.Security.Cryptography.ICryptoTransform, global::System.IDisposable
	{
		// Token: 0x06000428 RID: 1064 RVA: 0x00013200 File Offset: 0x00011400
		public ZipAESTransform(string key, byte[] saltBytes, int blockSize, bool writeMode)
		{
			if (blockSize != 16 && blockSize != 32)
			{
				throw new global::System.Exception("Invalid blocksize " + blockSize.ToString() + ". Must be 16 or 32.");
			}
			if (saltBytes.Length != blockSize / 2)
			{
				throw new global::System.Exception("Invalid salt len. Must be " + (blockSize / 2).ToString() + " for blocksize " + blockSize.ToString());
			}
			this._blockSize = blockSize;
			this._encryptBuffer = new byte[this._blockSize];
			this._encrPos = 16;
			global::System.Security.Cryptography.Rfc2898DeriveBytes rfc2898DeriveBytes = new global::System.Security.Cryptography.Rfc2898DeriveBytes(key, saltBytes, 1000);
			global::System.Security.Cryptography.Aes aes = global::System.Security.Cryptography.Aes.Create();
			aes.Mode = global::System.Security.Cryptography.CipherMode.ECB;
			this._counterNonce = new byte[this._blockSize];
			byte[] bytes = rfc2898DeriveBytes.GetBytes(this._blockSize);
			byte[] bytes2 = rfc2898DeriveBytes.GetBytes(this._blockSize);
			this._encryptor = aes.CreateEncryptor(bytes, new byte[16]);
			this._pwdVerifier = rfc2898DeriveBytes.GetBytes(2);
			this._hmacsha1 = global::ICSharpCode.SharpZipLib.Encryption.ZipAESTransform.IncrementalHash.CreateHMAC(global::ICSharpCode.SharpZipLib.Encryption.ZipAESTransform.HashAlgorithmName.SHA1, bytes2);
			this._writeMode = writeMode;
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x00013308 File Offset: 0x00011508
		public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset)
		{
			if (!this._writeMode)
			{
				this._hmacsha1.AppendData(inputBuffer, inputOffset, inputCount);
			}
			for (int i = 0; i < inputCount; i++)
			{
				if (this._encrPos == 16)
				{
					int num = 0;
					for (;;)
					{
						byte[] counterNonce = this._counterNonce;
						int num2 = num;
						byte b = counterNonce[num2] + 1;
						counterNonce[num2] = b;
						if (b != 0)
						{
							break;
						}
						num++;
					}
					this._encryptor.TransformBlock(this._counterNonce, 0, this._blockSize, this._encryptBuffer, 0);
					this._encrPos = 0;
				}
				int num3 = i + outputOffset;
				byte b2 = inputBuffer[i + inputOffset];
				byte[] encryptBuffer = this._encryptBuffer;
				int encrPos = this._encrPos;
				this._encrPos = encrPos + 1;
				outputBuffer[num3] = (b2 ^ encryptBuffer[encrPos]);
			}
			if (this._writeMode)
			{
				this._hmacsha1.AppendData(outputBuffer, outputOffset, inputCount);
			}
			return inputCount;
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x0600042A RID: 1066 RVA: 0x000133C6 File Offset: 0x000115C6
		public byte[] PwdVerifier
		{
			get
			{
				return this._pwdVerifier;
			}
		}

		// Token: 0x0600042B RID: 1067 RVA: 0x000133CE File Offset: 0x000115CE
		public byte[] GetAuthCode()
		{
			if (this._authCode == null)
			{
				this._authCode = this._hmacsha1.GetHashAndReset();
			}
			return this._authCode;
		}

		// Token: 0x0600042C RID: 1068 RVA: 0x000133EF File Offset: 0x000115EF
		public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount)
		{
			if (inputCount > 0)
			{
				throw new global::System.NotImplementedException("TransformFinalBlock is not implemented and inputCount is greater than 0");
			}
			return global::ICSharpCode.SharpZipLib.Core.Empty.Array<byte>();
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x0600042D RID: 1069 RVA: 0x00013405 File Offset: 0x00011605
		public int InputBlockSize
		{
			get
			{
				return this._blockSize;
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x0600042E RID: 1070 RVA: 0x0001340D File Offset: 0x0001160D
		public int OutputBlockSize
		{
			get
			{
				return this._blockSize;
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x0600042F RID: 1071 RVA: 0x00013415 File Offset: 0x00011615
		public bool CanTransformMultipleBlocks
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x06000430 RID: 1072 RVA: 0x00013418 File Offset: 0x00011618
		public bool CanReuseTransform
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000431 RID: 1073 RVA: 0x0001341B File Offset: 0x0001161B
		public void Dispose()
		{
			this._encryptor.Dispose();
		}

		// Token: 0x04000280 RID: 640
		private const int PWD_VER_LENGTH = 2;

		// Token: 0x04000281 RID: 641
		private const int KEY_ROUNDS = 1000;

		// Token: 0x04000282 RID: 642
		private const int ENCRYPT_BLOCK = 16;

		// Token: 0x04000283 RID: 643
		private int _blockSize;

		// Token: 0x04000284 RID: 644
		private readonly global::System.Security.Cryptography.ICryptoTransform _encryptor;

		// Token: 0x04000285 RID: 645
		private readonly byte[] _counterNonce;

		// Token: 0x04000286 RID: 646
		private byte[] _encryptBuffer;

		// Token: 0x04000287 RID: 647
		private int _encrPos;

		// Token: 0x04000288 RID: 648
		private byte[] _pwdVerifier;

		// Token: 0x04000289 RID: 649
		private global::ICSharpCode.SharpZipLib.Encryption.ZipAESTransform.IncrementalHash _hmacsha1;

		// Token: 0x0400028A RID: 650
		private byte[] _authCode;

		// Token: 0x0400028B RID: 651
		private bool _writeMode;

		// Token: 0x02000090 RID: 144
		private class IncrementalHash : global::System.Security.Cryptography.HMACSHA1
		{
			// Token: 0x06000578 RID: 1400 RVA: 0x00019178 File Offset: 0x00017378
			public IncrementalHash(byte[] key) : base(key)
			{
			}

			// Token: 0x06000579 RID: 1401 RVA: 0x00019181 File Offset: 0x00017381
			public static global::ICSharpCode.SharpZipLib.Encryption.ZipAESTransform.IncrementalHash CreateHMAC(string n, byte[] key)
			{
				return new global::ICSharpCode.SharpZipLib.Encryption.ZipAESTransform.IncrementalHash(key);
			}

			// Token: 0x0600057A RID: 1402 RVA: 0x00019189 File Offset: 0x00017389
			public void AppendData(byte[] buffer, int offset, int count)
			{
				base.TransformBlock(buffer, offset, count, buffer, offset);
			}

			// Token: 0x0600057B RID: 1403 RVA: 0x00019198 File Offset: 0x00017398
			public byte[] GetHashAndReset()
			{
				if (!this._finalised)
				{
					byte[] inputBuffer = new byte[0];
					base.TransformFinalBlock(inputBuffer, 0, 0);
					this._finalised = true;
				}
				return this.Hash;
			}

			// Token: 0x04000374 RID: 884
			private bool _finalised;
		}

		// Token: 0x02000091 RID: 145
		private static class HashAlgorithmName
		{
			// Token: 0x04000375 RID: 885
			public static string SHA1;
		}
	}
}
