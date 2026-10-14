using System;
using System.IO;
using System.Security.Cryptography;

namespace Ionic.Zip
{
	// Token: 0x02000460 RID: 1120
	internal class WinZipAesCrypto
	{
		// Token: 0x06003033 RID: 12339 RVA: 0x000AAA34 File Offset: 0x000A8C34
		private WinZipAesCrypto(string password, int KeyStrengthInBits)
		{
			this._Password = password;
			this._KeyStrengthInBits = KeyStrengthInBits;
		}

		// Token: 0x06003034 RID: 12340 RVA: 0x000AAA58 File Offset: 0x000A8C58
		public static global::Ionic.Zip.WinZipAesCrypto Generate(string password, int KeyStrengthInBits)
		{
			global::Ionic.Zip.WinZipAesCrypto winZipAesCrypto = new global::Ionic.Zip.WinZipAesCrypto(password, KeyStrengthInBits);
			int num = winZipAesCrypto._KeyStrengthInBytes / 2;
			winZipAesCrypto._Salt = new byte[num];
			new global::System.Random().NextBytes(winZipAesCrypto._Salt);
			return winZipAesCrypto;
		}

		// Token: 0x06003035 RID: 12341 RVA: 0x000AAA98 File Offset: 0x000A8C98
		public static global::Ionic.Zip.WinZipAesCrypto ReadFromStream(string password, int KeyStrengthInBits, global::System.IO.Stream s)
		{
			global::Ionic.Zip.WinZipAesCrypto winZipAesCrypto = new global::Ionic.Zip.WinZipAesCrypto(password, KeyStrengthInBits);
			int num = winZipAesCrypto._KeyStrengthInBytes / 2;
			winZipAesCrypto._Salt = new byte[num];
			winZipAesCrypto._providedPv = new byte[2];
			s.Read(winZipAesCrypto._Salt, 0, winZipAesCrypto._Salt.Length);
			s.Read(winZipAesCrypto._providedPv, 0, winZipAesCrypto._providedPv.Length);
			winZipAesCrypto.PasswordVerificationStored = (short)((int)winZipAesCrypto._providedPv[0] + (int)winZipAesCrypto._providedPv[1] * 256);
			if (password != null)
			{
				winZipAesCrypto.PasswordVerificationGenerated = (short)((int)winZipAesCrypto.GeneratedPV[0] + (int)winZipAesCrypto.GeneratedPV[1] * 256);
				if (winZipAesCrypto.PasswordVerificationGenerated != winZipAesCrypto.PasswordVerificationStored)
				{
					throw new global::Ionic.Zip.BadPasswordException("bad password");
				}
			}
			return winZipAesCrypto;
		}

		// Token: 0x17000DCC RID: 3532
		// (get) Token: 0x06003036 RID: 12342 RVA: 0x000AAB60 File Offset: 0x000A8D60
		public byte[] GeneratedPV
		{
			get
			{
				if (!this._cryptoGenerated)
				{
					this._GenerateCryptoBytes();
				}
				return this._generatedPv;
			}
		}

		// Token: 0x17000DCD RID: 3533
		// (get) Token: 0x06003037 RID: 12343 RVA: 0x000AAB7C File Offset: 0x000A8D7C
		public byte[] Salt
		{
			get
			{
				return this._Salt;
			}
		}

		// Token: 0x17000DCE RID: 3534
		// (get) Token: 0x06003038 RID: 12344 RVA: 0x000AAB84 File Offset: 0x000A8D84
		private int _KeyStrengthInBytes
		{
			get
			{
				return this._KeyStrengthInBits / 8;
			}
		}

		// Token: 0x17000DCF RID: 3535
		// (get) Token: 0x06003039 RID: 12345 RVA: 0x000AAB90 File Offset: 0x000A8D90
		public int SizeOfEncryptionMetadata
		{
			get
			{
				return this._KeyStrengthInBytes / 2 + 10 + 2;
			}
		}

		// Token: 0x17000DD0 RID: 3536
		// (get) Token: 0x0600303B RID: 12347 RVA: 0x000AABF8 File Offset: 0x000A8DF8
		// (set) Token: 0x0600303A RID: 12346 RVA: 0x000AABA0 File Offset: 0x000A8DA0
		public string Password
		{
			private get
			{
				return this._Password;
			}
			set
			{
				this._Password = value;
				if (this._Password != null)
				{
					this.PasswordVerificationGenerated = (short)((int)this.GeneratedPV[0] + (int)this.GeneratedPV[1] * 256);
					if (this.PasswordVerificationGenerated != this.PasswordVerificationStored)
					{
						throw new global::Ionic.Zip.BadPasswordException();
					}
				}
			}
		}

		// Token: 0x0600303C RID: 12348 RVA: 0x000AAC00 File Offset: 0x000A8E00
		private void _GenerateCryptoBytes()
		{
			global::System.Security.Cryptography.Rfc2898DeriveBytes rfc2898DeriveBytes = new global::System.Security.Cryptography.Rfc2898DeriveBytes(this._Password, this.Salt, this.Rfc2898KeygenIterations);
			this._keyBytes = rfc2898DeriveBytes.GetBytes(this._KeyStrengthInBytes);
			this._MacInitializationVector = rfc2898DeriveBytes.GetBytes(this._KeyStrengthInBytes);
			this._generatedPv = rfc2898DeriveBytes.GetBytes(2);
			this._cryptoGenerated = true;
		}

		// Token: 0x17000DD1 RID: 3537
		// (get) Token: 0x0600303D RID: 12349 RVA: 0x000AAC64 File Offset: 0x000A8E64
		public byte[] KeyBytes
		{
			get
			{
				if (!this._cryptoGenerated)
				{
					this._GenerateCryptoBytes();
				}
				return this._keyBytes;
			}
		}

		// Token: 0x17000DD2 RID: 3538
		// (get) Token: 0x0600303E RID: 12350 RVA: 0x000AAC80 File Offset: 0x000A8E80
		public byte[] MacIv
		{
			get
			{
				if (!this._cryptoGenerated)
				{
					this._GenerateCryptoBytes();
				}
				return this._MacInitializationVector;
			}
		}

		// Token: 0x0600303F RID: 12351 RVA: 0x000AAC9C File Offset: 0x000A8E9C
		public void ReadAndVerifyMac(global::System.IO.Stream s)
		{
			bool flag = false;
			this._StoredMac = new byte[10];
			s.Read(this._StoredMac, 0, this._StoredMac.Length);
			if (this._StoredMac.Length != this.CalculatedMac.Length)
			{
				flag = true;
			}
			if (!flag)
			{
				for (int i = 0; i < this._StoredMac.Length; i++)
				{
					if (this._StoredMac[i] != this.CalculatedMac[i])
					{
						flag = true;
					}
				}
			}
			if (flag)
			{
				throw new global::Ionic.Zip.BadStateException("The MAC does not match.");
			}
		}

		// Token: 0x04001188 RID: 4488
		internal byte[] _Salt;

		// Token: 0x04001189 RID: 4489
		internal byte[] _providedPv;

		// Token: 0x0400118A RID: 4490
		internal byte[] _generatedPv;

		// Token: 0x0400118B RID: 4491
		internal int _KeyStrengthInBits;

		// Token: 0x0400118C RID: 4492
		private byte[] _MacInitializationVector;

		// Token: 0x0400118D RID: 4493
		private byte[] _StoredMac;

		// Token: 0x0400118E RID: 4494
		private byte[] _keyBytes;

		// Token: 0x0400118F RID: 4495
		private short PasswordVerificationStored;

		// Token: 0x04001190 RID: 4496
		private short PasswordVerificationGenerated;

		// Token: 0x04001191 RID: 4497
		private int Rfc2898KeygenIterations = 1000;

		// Token: 0x04001192 RID: 4498
		private string _Password;

		// Token: 0x04001193 RID: 4499
		private bool _cryptoGenerated;

		// Token: 0x04001194 RID: 4500
		public byte[] CalculatedMac;
	}
}
