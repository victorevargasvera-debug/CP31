using System;
using System.Text;
using NPOI.Util;

namespace NPOI.POIFS.Crypt.Standard
{
	// Token: 0x02000310 RID: 784
	public class StandardEncryptionHeader : global::NPOI.POIFS.Crypt.EncryptionHeader, global::NPOI.POIFS.Crypt.Standard.EncryptionRecord
	{
		// Token: 0x060016BB RID: 5819 RVA: 0x000435FC File Offset: 0x000417FC
		internal StandardEncryptionHeader(global::NPOI.Util.ILittleEndianInput is1)
		{
			base.Flags = is1.ReadInt();
			base.SizeExtra = is1.ReadInt();
			base.CipherAlgorithm = global::NPOI.POIFS.Crypt.CipherAlgorithm.FromEcmaId(is1.ReadInt());
			base.HashAlgorithm = global::NPOI.POIFS.Crypt.HashAlgorithm.FromEcmaId(is1.ReadInt());
			int num = is1.ReadInt();
			if (num == 0)
			{
				num = 40;
			}
			base.KeySize = num;
			base.BlockSize = num;
			base.CipherProvider = global::NPOI.POIFS.Crypt.CipherProvider.FromEcmaId(is1.ReadInt());
			is1.ReadLong();
			((global::NPOI.Util.ByteArrayInputStream)is1).Mark(5);
			int num2 = is1.ReadInt();
			((global::NPOI.Util.ByteArrayInputStream)is1).Reset();
			if (num2 == 16)
			{
				base.CspName = "";
			}
			else
			{
				global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
				for (;;)
				{
					char c = (char)is1.ReadShort();
					if (c == '\0')
					{
						break;
					}
					stringBuilder.Append(c);
				}
				base.CspName = stringBuilder.ToString();
			}
			base.ChainingMode = global::NPOI.POIFS.Crypt.ChainingMode.ecb;
			base.KeySalt = null;
		}

		// Token: 0x060016BC RID: 5820 RVA: 0x000436E4 File Offset: 0x000418E4
		protected internal StandardEncryptionHeader(global::NPOI.POIFS.Crypt.CipherAlgorithm cipherAlgorithm, global::NPOI.POIFS.Crypt.HashAlgorithm hashAlgorithm, int keyBits, int blockSize, global::NPOI.POIFS.Crypt.ChainingMode chainingMode)
		{
			base.CipherAlgorithm = cipherAlgorithm;
			base.HashAlgorithm = hashAlgorithm;
			base.KeySize = keyBits;
			base.BlockSize = blockSize;
			base.CipherProvider = cipherAlgorithm.provider;
			base.Flags = (global::NPOI.POIFS.Crypt.EncryptionInfo.flagCryptoAPI.SetBoolean(0, true) | global::NPOI.POIFS.Crypt.EncryptionInfo.flagAES.SetBoolean(0, cipherAlgorithm.provider == global::NPOI.POIFS.Crypt.CipherProvider.aes));
		}

		// Token: 0x060016BD RID: 5821 RVA: 0x0004374C File Offset: 0x0004194C
		public void Write(global::NPOI.Util.LittleEndianByteArrayOutputStream bos)
		{
			int writeIndex = bos.WriteIndex;
			global::NPOI.Util.ILittleEndianOutput littleEndianOutput = bos.CreateDelayedOutput(4);
			bos.WriteInt(base.Flags);
			bos.WriteInt(0);
			bos.WriteInt(base.CipherAlgorithm.ecmaId);
			bos.WriteInt(base.HashAlgorithm.ecmaId);
			bos.WriteInt(base.KeySize);
			bos.WriteInt(base.CipherProvider.ecmaId);
			bos.WriteInt(0);
			bos.WriteInt(0);
			string text = base.CspName;
			if (text == null)
			{
				text = base.CipherProvider.cipherProviderName;
			}
			bos.Write(global::NPOI.Util.StringUtil.GetToUnicodeLE(text));
			bos.WriteShort(0);
			int v = bos.WriteIndex - writeIndex - 4;
			littleEndianOutput.WriteInt(v);
		}
	}
}
