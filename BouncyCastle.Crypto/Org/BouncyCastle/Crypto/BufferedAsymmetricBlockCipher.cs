using System;

namespace Org.BouncyCastle.Crypto
{
	// Token: 0x020002B8 RID: 696
	public class BufferedAsymmetricBlockCipher : global::Org.BouncyCastle.Crypto.BufferedCipherBase
	{
		// Token: 0x06001F0A RID: 7946 RVA: 0x0008F608 File Offset: 0x0008D808
		public BufferedAsymmetricBlockCipher(global::Org.BouncyCastle.Crypto.IAsymmetricBlockCipher cipher)
		{
			this.cipher = cipher;
		}

		// Token: 0x06001F0B RID: 7947 RVA: 0x0008F617 File Offset: 0x0008D817
		internal int GetBufferPosition()
		{
			return this.bufOff;
		}

		// Token: 0x17000445 RID: 1093
		// (get) Token: 0x06001F0C RID: 7948 RVA: 0x0008F61F File Offset: 0x0008D81F
		public override string AlgorithmName
		{
			get
			{
				return this.cipher.AlgorithmName;
			}
		}

		// Token: 0x06001F0D RID: 7949 RVA: 0x0008F62C File Offset: 0x0008D82C
		public override int GetBlockSize()
		{
			return this.cipher.GetInputBlockSize();
		}

		// Token: 0x06001F0E RID: 7950 RVA: 0x0008F639 File Offset: 0x0008D839
		public override int GetOutputSize(int length)
		{
			return this.cipher.GetOutputBlockSize();
		}

		// Token: 0x06001F0F RID: 7951 RVA: 0x0008F646 File Offset: 0x0008D846
		public override int GetUpdateOutputSize(int length)
		{
			return 0;
		}

		// Token: 0x06001F10 RID: 7952 RVA: 0x0008F649 File Offset: 0x0008D849
		public override void Init(bool forEncryption, global::Org.BouncyCastle.Crypto.ICipherParameters parameters)
		{
			this.Reset();
			this.cipher.Init(forEncryption, parameters);
			this.buffer = new byte[this.cipher.GetInputBlockSize() + (forEncryption ? 1 : 0)];
			this.bufOff = 0;
		}

		// Token: 0x06001F11 RID: 7953 RVA: 0x0008F684 File Offset: 0x0008D884
		public override byte[] ProcessByte(byte input)
		{
			if (this.bufOff >= this.buffer.Length)
			{
				throw new global::Org.BouncyCastle.Crypto.DataLengthException("attempt to process message to long for cipher");
			}
			byte[] array = this.buffer;
			int num = this.bufOff;
			this.bufOff = num + 1;
			array[num] = input;
			return null;
		}

		// Token: 0x06001F12 RID: 7954 RVA: 0x0008F6C8 File Offset: 0x0008D8C8
		public override byte[] ProcessBytes(byte[] input, int inOff, int length)
		{
			if (length < 1)
			{
				return null;
			}
			if (input == null)
			{
				throw new global::System.ArgumentNullException("input");
			}
			if (this.bufOff + length > this.buffer.Length)
			{
				throw new global::Org.BouncyCastle.Crypto.DataLengthException("attempt to process message to long for cipher");
			}
			global::System.Array.Copy(input, inOff, this.buffer, this.bufOff, length);
			this.bufOff += length;
			return null;
		}

		// Token: 0x06001F13 RID: 7955 RVA: 0x0008F729 File Offset: 0x0008D929
		public override byte[] DoFinal()
		{
			byte[] result = (this.bufOff > 0) ? this.cipher.ProcessBlock(this.buffer, 0, this.bufOff) : global::Org.BouncyCastle.Crypto.BufferedCipherBase.EmptyBuffer;
			this.Reset();
			return result;
		}

		// Token: 0x06001F14 RID: 7956 RVA: 0x0008F759 File Offset: 0x0008D959
		public override byte[] DoFinal(byte[] input, int inOff, int length)
		{
			this.ProcessBytes(input, inOff, length);
			return this.DoFinal();
		}

		// Token: 0x06001F15 RID: 7957 RVA: 0x0008F76B File Offset: 0x0008D96B
		public override void Reset()
		{
			if (this.buffer != null)
			{
				global::System.Array.Clear(this.buffer, 0, this.buffer.Length);
				this.bufOff = 0;
			}
		}

		// Token: 0x04000B1F RID: 2847
		private readonly global::Org.BouncyCastle.Crypto.IAsymmetricBlockCipher cipher;

		// Token: 0x04000B20 RID: 2848
		private byte[] buffer;

		// Token: 0x04000B21 RID: 2849
		private int bufOff;
	}
}
