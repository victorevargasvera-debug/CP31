using System;
using System.Security.Cryptography;

namespace ICSharpCode.SharpZipLib.Encryption
{
	// Token: 0x02000058 RID: 88
	internal class PkzipClassicDecryptCryptoTransform : global::ICSharpCode.SharpZipLib.Encryption.PkzipClassicCryptoBase, global::System.Security.Cryptography.ICryptoTransform, global::System.IDisposable
	{
		// Token: 0x0600040D RID: 1037 RVA: 0x00012D88 File Offset: 0x00010F88
		internal PkzipClassicDecryptCryptoTransform(byte[] keyBlock)
		{
			base.SetKeys(keyBlock);
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x00012D98 File Offset: 0x00010F98
		public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount)
		{
			byte[] array = new byte[inputCount];
			this.TransformBlock(inputBuffer, inputOffset, inputCount, array, 0);
			return array;
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x00012DBC File Offset: 0x00010FBC
		public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset)
		{
			for (int i = inputOffset; i < inputOffset + inputCount; i++)
			{
				byte b = inputBuffer[i] ^ base.TransformByte();
				outputBuffer[outputOffset++] = b;
				base.UpdateKeys(b);
			}
			return inputCount;
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x06000410 RID: 1040 RVA: 0x00012DF6 File Offset: 0x00010FF6
		public bool CanReuseTransform
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x06000411 RID: 1041 RVA: 0x00012DF9 File Offset: 0x00010FF9
		public int InputBlockSize
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x06000412 RID: 1042 RVA: 0x00012DFC File Offset: 0x00010FFC
		public int OutputBlockSize
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x06000413 RID: 1043 RVA: 0x00012DFF File Offset: 0x00010FFF
		public bool CanTransformMultipleBlocks
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x00012E02 File Offset: 0x00011002
		public void Dispose()
		{
			base.Reset();
		}
	}
}
