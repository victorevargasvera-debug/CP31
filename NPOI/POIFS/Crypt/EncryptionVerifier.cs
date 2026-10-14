using System;

namespace NPOI.POIFS.Crypt
{
	// Token: 0x02000304 RID: 772
	public abstract class EncryptionVerifier
	{
		// Token: 0x1700045D RID: 1117
		// (get) Token: 0x06001664 RID: 5732 RVA: 0x00042BB7 File Offset: 0x00040DB7
		// (set) Token: 0x06001665 RID: 5733 RVA: 0x00042BBF File Offset: 0x00040DBF
		public byte[] Salt { get; set; }

		// Token: 0x06001666 RID: 5734 RVA: 0x00042BC8 File Offset: 0x00040DC8
		public byte[] GetVerifier()
		{
			return this.encryptedVerifier;
		}

		// Token: 0x1700045E RID: 1118
		// (get) Token: 0x06001667 RID: 5735 RVA: 0x00042BD0 File Offset: 0x00040DD0
		// (set) Token: 0x06001668 RID: 5736 RVA: 0x00042BD8 File Offset: 0x00040DD8
		public byte[] EncryptedVerifier { get; set; }

		// Token: 0x06001669 RID: 5737 RVA: 0x00042BE1 File Offset: 0x00040DE1
		public byte[] GetVerifierHash()
		{
			return this.encryptedVerifierHash;
		}

		// Token: 0x1700045F RID: 1119
		// (get) Token: 0x0600166A RID: 5738 RVA: 0x00042BE9 File Offset: 0x00040DE9
		// (set) Token: 0x0600166B RID: 5739 RVA: 0x00042BF1 File Offset: 0x00040DF1
		public byte[] EncryptedVerifierHash { get; set; }

		// Token: 0x17000460 RID: 1120
		// (get) Token: 0x0600166C RID: 5740 RVA: 0x00042BFA File Offset: 0x00040DFA
		// (set) Token: 0x0600166D RID: 5741 RVA: 0x00042C02 File Offset: 0x00040E02
		public int SpinCount { get; set; }

		// Token: 0x0600166E RID: 5742 RVA: 0x00042C0B File Offset: 0x00040E0B
		public int GetCipherMode()
		{
			return this.chainingMode.ecmaId;
		}

		// Token: 0x0600166F RID: 5743 RVA: 0x00042C18 File Offset: 0x00040E18
		public int GetAlgorithm()
		{
			return this.cipherAlgorithm.ecmaId;
		}

		// Token: 0x06001670 RID: 5744 RVA: 0x00042C25 File Offset: 0x00040E25
		public string GetAlgorithmName()
		{
			return this.cipherAlgorithm.jceId;
		}

		// Token: 0x17000461 RID: 1121
		// (get) Token: 0x06001671 RID: 5745 RVA: 0x00042C32 File Offset: 0x00040E32
		// (set) Token: 0x06001672 RID: 5746 RVA: 0x00042C3A File Offset: 0x00040E3A
		public byte[] EncryptedKey { get; set; }

		// Token: 0x17000462 RID: 1122
		// (get) Token: 0x06001673 RID: 5747 RVA: 0x00042C43 File Offset: 0x00040E43
		// (set) Token: 0x06001674 RID: 5748 RVA: 0x00042C4B File Offset: 0x00040E4B
		public global::NPOI.POIFS.Crypt.CipherAlgorithm CipherAlgorithm { get; set; }

		// Token: 0x17000463 RID: 1123
		// (get) Token: 0x06001675 RID: 5749 RVA: 0x00042C54 File Offset: 0x00040E54
		// (set) Token: 0x06001676 RID: 5750 RVA: 0x00042C5C File Offset: 0x00040E5C
		public global::NPOI.POIFS.Crypt.HashAlgorithm HashAlgorithm { get; set; }

		// Token: 0x17000464 RID: 1124
		// (get) Token: 0x06001677 RID: 5751 RVA: 0x00042C65 File Offset: 0x00040E65
		// (set) Token: 0x06001678 RID: 5752 RVA: 0x00042C6D File Offset: 0x00040E6D
		public global::NPOI.POIFS.Crypt.ChainingMode ChainingMode { get; set; }

		// Token: 0x04000928 RID: 2344
		private byte[] encryptedVerifier;

		// Token: 0x04000929 RID: 2345
		private byte[] encryptedVerifierHash;

		// Token: 0x0400092A RID: 2346
		private byte[] encryptedKey;

		// Token: 0x0400092B RID: 2347
		private int spinCount;

		// Token: 0x0400092C RID: 2348
		private global::NPOI.POIFS.Crypt.CipherAlgorithm cipherAlgorithm;

		// Token: 0x0400092D RID: 2349
		private global::NPOI.POIFS.Crypt.ChainingMode chainingMode;

		// Token: 0x0400092E RID: 2350
		private global::NPOI.POIFS.Crypt.HashAlgorithm hashAlgorithm;
	}
}
