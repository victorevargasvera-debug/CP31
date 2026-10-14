using System;
using System.IO;
using System.Security.Cryptography;

namespace Ionic.Zip
{
	// Token: 0x02000045 RID: 69
	internal class WinZipAesCrypto
	{
		// Token: 0x0600030B RID: 779 RVA: 0x0001237D File Offset: 0x0001057D
		private WinZipAesCrypto(string password, int KeyStrengthInBits)
		{
			this._Password = password;
			this._KeyStrengthInBits = KeyStrengthInBits;
		}

		// Token: 0x0600030C RID: 780 RVA: 0x000123A0 File Offset: 0x000105A0
		public static global::Ionic.Zip.WinZipAesCrypto Generate(string password, int KeyStrengthInBits)
		{
			global::Ionic.Zip.WinZipAesCrypto winZipAesCrypto = new global::Ionic.Zip.WinZipAesCrypto(password, KeyStrengthInBits);
			int num = winZipAesCrypto._KeyStrengthInBytes / 2;
			winZipAesCrypto._Salt = new byte[num];
			new global::System.Random().NextBytes(winZipAesCrypto._Salt);
			return winZipAesCrypto;
		}

		// Token: 0x0600030D RID: 781 RVA: 0x000123DC File Offset: 0x000105DC
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

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x0600030E RID: 782 RVA: 0x00012497 File Offset: 0x00010697
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

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x0600030F RID: 783 RVA: 0x000124AD File Offset: 0x000106AD
		public byte[] Salt
		{
			get
			{
				return this._Salt;
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x06000310 RID: 784 RVA: 0x000124B5 File Offset: 0x000106B5
		private int _KeyStrengthInBytes
		{
			get
			{
				return this._KeyStrengthInBits / 8;
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x06000311 RID: 785 RVA: 0x000124BF File Offset: 0x000106BF
		public int SizeOfEncryptionMetadata
		{
			get
			{
				return this._KeyStrengthInBytes / 2 + 10 + 2;
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x06000313 RID: 787 RVA: 0x0001251E File Offset: 0x0001071E
		// (set) Token: 0x06000312 RID: 786 RVA: 0x000124D0 File Offset: 0x000106D0
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

		// Token: 0x06000314 RID: 788 RVA: 0x00012528 File Offset: 0x00010728
		private void _GenerateCryptoBytes()
		{
			global::System.Security.Cryptography.Rfc2898DeriveBytes rfc2898DeriveBytes = new global::System.Security.Cryptography.Rfc2898DeriveBytes(this._Password, this.Salt, this.Rfc2898KeygenIterations);
			this._keyBytes = rfc2898DeriveBytes.GetBytes(this._KeyStrengthInBytes);
			this._MacInitializationVector = rfc2898DeriveBytes.GetBytes(this._KeyStrengthInBytes);
			this._generatedPv = rfc2898DeriveBytes.GetBytes(2);
			this._cryptoGenerated = true;
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x06000315 RID: 789 RVA: 0x00012585 File Offset: 0x00010785
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

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x06000316 RID: 790 RVA: 0x0001259B File Offset: 0x0001079B
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

		// Token: 0x06000317 RID: 791 RVA: 0x000125B4 File Offset: 0x000107B4
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

		// Token: 0x04000202 RID: 514
		internal byte[] _Salt;

		// Token: 0x04000203 RID: 515
		internal byte[] _providedPv;

		// Token: 0x04000204 RID: 516
		internal byte[] _generatedPv;

		// Token: 0x04000205 RID: 517
		internal int _KeyStrengthInBits;

		// Token: 0x04000206 RID: 518
		private byte[] _MacInitializationVector;

		// Token: 0x04000207 RID: 519
		private byte[] _StoredMac;

		// Token: 0x04000208 RID: 520
		private byte[] _keyBytes;

		// Token: 0x04000209 RID: 521
		private short PasswordVerificationStored;

		// Token: 0x0400020A RID: 522
		private short PasswordVerificationGenerated;

		// Token: 0x0400020B RID: 523
		private int Rfc2898KeygenIterations = 1000;

		// Token: 0x0400020C RID: 524
		private string _Password;

		// Token: 0x0400020D RID: 525
		private bool _cryptoGenerated;

		// Token: 0x0400020E RID: 526
		public byte[] CalculatedMac;
	}
}
