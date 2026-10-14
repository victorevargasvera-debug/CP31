using System;

namespace NPOI.HSSF.Record.Crypto
{
	// Token: 0x0200044F RID: 1103
	public class Biff8RC4
	{
		// Token: 0x060028C6 RID: 10438 RVA: 0x0007B1D0 File Offset: 0x000793D0
		public Biff8RC4(int InitialOffset, global::NPOI.HSSF.Record.Crypto.Biff8EncryptionKey key)
		{
			if (InitialOffset >= 1024)
			{
				throw new global::System.Exception(string.Concat(new string[]
				{
					"InitialOffset (",
					InitialOffset.ToString(),
					")>",
					1024.ToString(),
					" not supported yet"
				}));
			}
			this._key = key;
			this._streamPos = 0;
			this.RekeyForNextBlock();
			this._streamPos = InitialOffset;
			for (int i = InitialOffset; i > 0; i--)
			{
				this._rc4.Output();
			}
			this._shouldSkipEncryptionOnCurrentRecord = false;
		}

		// Token: 0x060028C7 RID: 10439 RVA: 0x0007B268 File Offset: 0x00079468
		private void RekeyForNextBlock()
		{
			this._currentKeyIndex = this._streamPos / 1024;
			this._rc4 = this._key.CreateRC4(this._currentKeyIndex);
			this._nextRC4BlockStart = (this._currentKeyIndex + 1) * 1024;
		}

		// Token: 0x060028C8 RID: 10440 RVA: 0x0007B2A8 File Offset: 0x000794A8
		private int GetNextRC4Byte()
		{
			if (this._streamPos >= this._nextRC4BlockStart)
			{
				this.RekeyForNextBlock();
			}
			byte b = this._rc4.Output();
			this._streamPos++;
			if (this._shouldSkipEncryptionOnCurrentRecord)
			{
				return 0;
			}
			return (int)(b & byte.MaxValue);
		}

		// Token: 0x060028C9 RID: 10441 RVA: 0x0007B2F4 File Offset: 0x000794F4
		public void StartRecord(int currentSid)
		{
			this._shouldSkipEncryptionOnCurrentRecord = global::NPOI.HSSF.Record.Crypto.Biff8RC4.IsNeverEncryptedRecord(currentSid);
		}

		// Token: 0x060028CA RID: 10442 RVA: 0x0007B302 File Offset: 0x00079502
		private static bool IsNeverEncryptedRecord(int sid)
		{
			return sid == 47 || sid == 225 || sid == 2057;
		}

		// Token: 0x060028CB RID: 10443 RVA: 0x0007B31C File Offset: 0x0007951C
		public void SkipTwoBytes()
		{
			this.GetNextRC4Byte();
			this.GetNextRC4Byte();
		}

		// Token: 0x060028CC RID: 10444 RVA: 0x0007B32C File Offset: 0x0007952C
		public void Xor(byte[] buf, int pOffSet, int pLen)
		{
			int num = this._nextRC4BlockStart - this._streamPos;
			if (pLen <= num)
			{
				this._rc4.Encrypt(buf, pOffSet, pLen);
				this._streamPos += pLen;
				return;
			}
			int num2 = pOffSet;
			int i = pLen;
			if (i > num)
			{
				if (num > 0)
				{
					this._rc4.Encrypt(buf, num2, num);
					this._streamPos += num;
					num2 += num;
					i -= num;
				}
				this.RekeyForNextBlock();
			}
			while (i > 1024)
			{
				this._rc4.Encrypt(buf, num2, 1024);
				this._streamPos += 1024;
				num2 += 1024;
				i -= 1024;
				this.RekeyForNextBlock();
			}
			this._rc4.Encrypt(buf, num2, i);
			this._streamPos += i;
		}

		// Token: 0x060028CD RID: 10445 RVA: 0x0007B400 File Offset: 0x00079600
		public int XorByte(int rawVal)
		{
			int nextRC4Byte = this.GetNextRC4Byte();
			return (int)((byte)(rawVal ^ nextRC4Byte));
		}

		// Token: 0x060028CE RID: 10446 RVA: 0x0007B418 File Offset: 0x00079618
		public int Xorshort(int rawVal)
		{
			int nextRC4Byte = this.GetNextRC4Byte();
			int num = (this.GetNextRC4Byte() << 8) + nextRC4Byte;
			return rawVal ^ num;
		}

		// Token: 0x060028CF RID: 10447 RVA: 0x0007B43C File Offset: 0x0007963C
		public int XorInt(int rawVal)
		{
			int nextRC4Byte = this.GetNextRC4Byte();
			int nextRC4Byte2 = this.GetNextRC4Byte();
			int nextRC4Byte3 = this.GetNextRC4Byte();
			int num = (this.GetNextRC4Byte() << 24) + (nextRC4Byte3 << 16) + (nextRC4Byte2 << 8) + nextRC4Byte;
			return rawVal ^ num;
		}

		// Token: 0x060028D0 RID: 10448 RVA: 0x0007B478 File Offset: 0x00079678
		public long XorLong(long rawVal)
		{
			int nextRC4Byte = this.GetNextRC4Byte();
			int nextRC4Byte2 = this.GetNextRC4Byte();
			int nextRC4Byte3 = this.GetNextRC4Byte();
			int nextRC4Byte4 = this.GetNextRC4Byte();
			int nextRC4Byte5 = this.GetNextRC4Byte();
			int nextRC4Byte6 = this.GetNextRC4Byte();
			int nextRC4Byte7 = this.GetNextRC4Byte();
			long num = ((long)this.GetNextRC4Byte() << 56) + ((long)nextRC4Byte7 << 48) + ((long)nextRC4Byte6 << 40) + ((long)nextRC4Byte5 << 32) + ((long)nextRC4Byte4 << 24) + (long)((long)nextRC4Byte3 << 16) + (long)((long)nextRC4Byte2 << 8) + (long)nextRC4Byte;
			return rawVal ^ num;
		}

		// Token: 0x04001184 RID: 4484
		private const int RC4_REKEYING_INTERVAL = 1024;

		// Token: 0x04001185 RID: 4485
		private global::NPOI.HSSF.Record.Crypto.RC4 _rc4;

		// Token: 0x04001186 RID: 4486
		private int _streamPos;

		// Token: 0x04001187 RID: 4487
		private int _nextRC4BlockStart;

		// Token: 0x04001188 RID: 4488
		private int _currentKeyIndex;

		// Token: 0x04001189 RID: 4489
		private bool _shouldSkipEncryptionOnCurrentRecord;

		// Token: 0x0400118A RID: 4490
		private global::NPOI.HSSF.Record.Crypto.Biff8EncryptionKey _key;
	}
}
