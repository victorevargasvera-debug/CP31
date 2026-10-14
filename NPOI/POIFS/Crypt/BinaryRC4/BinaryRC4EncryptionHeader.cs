using System;
using NPOI.POIFS.Crypt.Standard;
using NPOI.Util;

namespace NPOI.POIFS.Crypt.BinaryRC4
{
	// Token: 0x0200031B RID: 795
	public class BinaryRC4EncryptionHeader : global::NPOI.POIFS.Crypt.EncryptionHeader, global::NPOI.POIFS.Crypt.Standard.EncryptionRecord
	{
		// Token: 0x06001708 RID: 5896 RVA: 0x00044A50 File Offset: 0x00042C50
		protected internal BinaryRC4EncryptionHeader()
		{
			base.CipherAlgorithm = global::NPOI.POIFS.Crypt.CipherAlgorithm.rc4;
			base.KeySize = 40;
			base.BlockSize = -1;
			base.CipherProvider = global::NPOI.POIFS.Crypt.CipherProvider.rc4;
			base.HashAlgorithm = global::NPOI.POIFS.Crypt.HashAlgorithm.md5;
			base.SizeExtra = 0;
			base.Flags = 0;
			base.CspName = "";
			base.ChainingMode = null;
		}

		// Token: 0x06001709 RID: 5897 RVA: 0x00019A7F File Offset: 0x00017C7F
		public void Write(global::NPOI.Util.LittleEndianByteArrayOutputStream littleendianbytearrayoutputstream)
		{
		}
	}
}
