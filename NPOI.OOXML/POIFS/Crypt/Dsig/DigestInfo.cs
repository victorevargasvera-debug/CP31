using System;
using System.Runtime.Serialization;

namespace NPOI.POIFS.Crypt.Dsig
{
	// Token: 0x020000F5 RID: 245
	public class DigestInfo : global::System.Runtime.Serialization.ISerializable
	{
		// Token: 0x06000EFA RID: 3834 RVA: 0x00035851 File Offset: 0x00033A51
		public DigestInfo(byte[] digestValue, global::NPOI.POIFS.Crypt.HashAlgorithm hashAlgo, string description)
		{
			this.digestValue = digestValue;
			this.hashAlgo = hashAlgo;
			this.description = description;
		}

		// Token: 0x06000EFB RID: 3835 RVA: 0x000065E4 File Offset: 0x000047E4
		public void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x04000476 RID: 1142
		private static long serialVersionUID = 1L;

		// Token: 0x04000477 RID: 1143
		public byte[] digestValue;

		// Token: 0x04000478 RID: 1144
		public string description;

		// Token: 0x04000479 RID: 1145
		public global::NPOI.POIFS.Crypt.HashAlgorithm hashAlgo;
	}
}
