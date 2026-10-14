using System;
using ICSharpCode.SharpZipLib.Checksum;

namespace ICSharpCode.SharpZipLib.Encryption
{
	// Token: 0x02000056 RID: 86
	internal class PkzipClassicCryptoBase
	{
		// Token: 0x06000400 RID: 1024 RVA: 0x00012BB2 File Offset: 0x00010DB2
		protected byte TransformByte()
		{
			uint num = (this.keys[2] & 65535U) | 2U;
			return (byte)(num * (num ^ 1U) >> 8);
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x00012BCC File Offset: 0x00010DCC
		protected void SetKeys(byte[] keyData)
		{
			if (keyData == null)
			{
				throw new global::System.ArgumentNullException("keyData");
			}
			if (keyData.Length != 12)
			{
				throw new global::System.InvalidOperationException("Key length is not valid");
			}
			this.keys = new uint[3];
			this.keys[0] = (uint)((int)keyData[3] << 24 | (int)keyData[2] << 16 | (int)keyData[1] << 8 | (int)keyData[0]);
			this.keys[1] = (uint)((int)keyData[7] << 24 | (int)keyData[6] << 16 | (int)keyData[5] << 8 | (int)keyData[4]);
			this.keys[2] = (uint)((int)keyData[11] << 24 | (int)keyData[10] << 16 | (int)keyData[9] << 8 | (int)keyData[8]);
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x00012C68 File Offset: 0x00010E68
		protected void UpdateKeys(byte ch)
		{
			this.keys[0] = global::ICSharpCode.SharpZipLib.Checksum.Crc32.ComputeCrc32(this.keys[0], ch);
			this.keys[1] = this.keys[1] + (uint)((byte)this.keys[0]);
			this.keys[1] = this.keys[1] * 134775813U + 1U;
			this.keys[2] = global::ICSharpCode.SharpZipLib.Checksum.Crc32.ComputeCrc32(this.keys[2], (byte)(this.keys[1] >> 24));
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x00012CDE File Offset: 0x00010EDE
		protected void Reset()
		{
			this.keys[0] = 0U;
			this.keys[1] = 0U;
			this.keys[2] = 0U;
		}

		// Token: 0x04000273 RID: 627
		private uint[] keys;
	}
}
