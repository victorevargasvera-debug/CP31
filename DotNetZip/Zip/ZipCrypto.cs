using System;
using System.IO;
using Ionic.Crc;

namespace Ionic.Zip
{
	// Token: 0x02000048 RID: 72
	internal class ZipCrypto
	{
		// Token: 0x0600032E RID: 814 RVA: 0x00012DD4 File Offset: 0x00010FD4
		private ZipCrypto()
		{
		}

		// Token: 0x0600032F RID: 815 RVA: 0x00012DFE File Offset: 0x00010FFE
		public static global::Ionic.Zip.ZipCrypto ForWrite(string password)
		{
			global::Ionic.Zip.ZipCrypto zipCrypto = new global::Ionic.Zip.ZipCrypto();
			if (password == null)
			{
				throw new global::Ionic.Zip.BadPasswordException("This entry requires a password.");
			}
			zipCrypto.InitCipher(password);
			return zipCrypto;
		}

		// Token: 0x06000330 RID: 816 RVA: 0x00012E1C File Offset: 0x0001101C
		public static global::Ionic.Zip.ZipCrypto ForRead(string password, global::Ionic.Zip.ZipEntry e)
		{
			global::System.IO.Stream archiveStream = e._archiveStream;
			e._WeakEncryptionHeader = new byte[12];
			byte[] weakEncryptionHeader = e._WeakEncryptionHeader;
			global::Ionic.Zip.ZipCrypto zipCrypto = new global::Ionic.Zip.ZipCrypto();
			if (password == null)
			{
				throw new global::Ionic.Zip.BadPasswordException("This entry requires a password.");
			}
			zipCrypto.InitCipher(password);
			global::Ionic.Zip.ZipEntry.ReadWeakEncryptionHeader(archiveStream, weakEncryptionHeader);
			byte[] array = zipCrypto.DecryptMessage(weakEncryptionHeader, weakEncryptionHeader.Length);
			if (array[11] != (byte)(e._Crc32 >> 24 & 255))
			{
				if ((e._BitField & 8) != 8)
				{
					throw new global::Ionic.Zip.BadPasswordException("The password did not match.");
				}
				if (array[11] != (byte)(e._TimeBlob >> 8 & 255))
				{
					throw new global::Ionic.Zip.BadPasswordException("The password did not match.");
				}
			}
			return zipCrypto;
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x06000331 RID: 817 RVA: 0x00012EC0 File Offset: 0x000110C0
		private byte MagicByte
		{
			get
			{
				ushort num = (ushort)(this._Keys[2] & 65535U) | 2;
				return (byte)(num * (num ^ 1) >> 8);
			}
		}

		// Token: 0x06000332 RID: 818 RVA: 0x00012EE8 File Offset: 0x000110E8
		public byte[] DecryptMessage(byte[] cipherText, int length)
		{
			if (cipherText == null)
			{
				throw new global::System.ArgumentNullException("cipherText");
			}
			if (length > cipherText.Length)
			{
				throw new global::System.ArgumentOutOfRangeException("length", "Bad length during Decryption: the length parameter must be smaller than or equal to the size of the destination array.");
			}
			byte[] array = new byte[length];
			for (int i = 0; i < length; i++)
			{
				byte b = cipherText[i] ^ this.MagicByte;
				this.UpdateKeys(b);
				array[i] = b;
			}
			return array;
		}

		// Token: 0x06000333 RID: 819 RVA: 0x00012F44 File Offset: 0x00011144
		public byte[] EncryptMessage(byte[] plainText, int length)
		{
			if (plainText == null)
			{
				throw new global::System.ArgumentNullException("plaintext");
			}
			if (length > plainText.Length)
			{
				throw new global::System.ArgumentOutOfRangeException("length", "Bad length during Encryption: The length parameter must be smaller than or equal to the size of the destination array.");
			}
			byte[] array = new byte[length];
			for (int i = 0; i < length; i++)
			{
				byte byteValue = plainText[i];
				array[i] = (plainText[i] ^ this.MagicByte);
				this.UpdateKeys(byteValue);
			}
			return array;
		}

		// Token: 0x06000334 RID: 820 RVA: 0x00012FA4 File Offset: 0x000111A4
		public void InitCipher(string passphrase)
		{
			byte[] array = global::Ionic.Zip.SharedUtilities.StringToByteArray(passphrase);
			for (int i = 0; i < passphrase.Length; i++)
			{
				this.UpdateKeys(array[i]);
			}
		}

		// Token: 0x06000335 RID: 821 RVA: 0x00012FD4 File Offset: 0x000111D4
		private void UpdateKeys(byte byteValue)
		{
			this._Keys[0] = (uint)this.crc32.ComputeCrc32((int)this._Keys[0], byteValue);
			this._Keys[1] = this._Keys[1] + (uint)((byte)this._Keys[0]);
			this._Keys[1] = this._Keys[1] * 134775813U + 1U;
			this._Keys[2] = (uint)this.crc32.ComputeCrc32((int)this._Keys[2], (byte)(this._Keys[1] >> 24));
		}

		// Token: 0x0400022D RID: 557
		private uint[] _Keys = new uint[]
		{
			305419896U,
			591751049U,
			878082192U
		};

		// Token: 0x0400022E RID: 558
		private global::Ionic.Crc.CRC32 crc32 = new global::Ionic.Crc.CRC32();
	}
}
