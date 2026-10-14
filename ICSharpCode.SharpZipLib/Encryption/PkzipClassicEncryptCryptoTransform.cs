using System;
using System.Security.Cryptography;

namespace ICSharpCode.SharpZipLib.Encryption
{
	// Token: 0x02000057 RID: 87
	internal class PkzipClassicEncryptCryptoTransform : global::ICSharpCode.SharpZipLib.Encryption.PkzipClassicCryptoBase, global::System.Security.Cryptography.ICryptoTransform, global::System.IDisposable
	{
		// Token: 0x06000405 RID: 1029 RVA: 0x00012D03 File Offset: 0x00010F03
		internal PkzipClassicEncryptCryptoTransform(byte[] keyBlock)
		{
			base.SetKeys(keyBlock);
		}

		// Token: 0x06000406 RID: 1030 RVA: 0x00012D14 File Offset: 0x00010F14
		public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount)
		{
			byte[] array = new byte[inputCount];
			this.TransformBlock(inputBuffer, inputOffset, inputCount, array, 0);
			return array;
		}

		// Token: 0x06000407 RID: 1031 RVA: 0x00012D38 File Offset: 0x00010F38
		public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset)
		{
			for (int i = inputOffset; i < inputOffset + inputCount; i++)
			{
				byte ch = inputBuffer[i];
				outputBuffer[outputOffset++] = (inputBuffer[i] ^ base.TransformByte());
				base.UpdateKeys(ch);
			}
			return inputCount;
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x06000408 RID: 1032 RVA: 0x00012D74 File Offset: 0x00010F74
		public bool CanReuseTransform
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x06000409 RID: 1033 RVA: 0x00012D77 File Offset: 0x00010F77
		public int InputBlockSize
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x0600040A RID: 1034 RVA: 0x00012D7A File Offset: 0x00010F7A
		public int OutputBlockSize
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x0600040B RID: 1035 RVA: 0x00012D7D File Offset: 0x00010F7D
		public bool CanTransformMultipleBlocks
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0600040C RID: 1036 RVA: 0x00012D80 File Offset: 0x00010F80
		public void Dispose()
		{
			base.Reset();
		}
	}
}
