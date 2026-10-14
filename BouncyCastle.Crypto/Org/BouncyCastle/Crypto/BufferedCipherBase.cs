using System;

namespace Org.BouncyCastle.Crypto
{
	// Token: 0x020002BA RID: 698
	public abstract class BufferedCipherBase : global::Org.BouncyCastle.Crypto.IBufferedCipher
	{
		// Token: 0x17000447 RID: 1095
		// (get) Token: 0x06001F25 RID: 7973
		public abstract string AlgorithmName { get; }

		// Token: 0x06001F26 RID: 7974
		public abstract void Init(bool forEncryption, global::Org.BouncyCastle.Crypto.ICipherParameters parameters);

		// Token: 0x06001F27 RID: 7975
		public abstract int GetBlockSize();

		// Token: 0x06001F28 RID: 7976
		public abstract int GetOutputSize(int inputLen);

		// Token: 0x06001F29 RID: 7977
		public abstract int GetUpdateOutputSize(int inputLen);

		// Token: 0x06001F2A RID: 7978
		public abstract byte[] ProcessByte(byte input);

		// Token: 0x06001F2B RID: 7979 RVA: 0x0008FC08 File Offset: 0x0008DE08
		public virtual int ProcessByte(byte input, byte[] output, int outOff)
		{
			byte[] outBytes = this.ProcessByte(input);
			if (outBytes == null)
			{
				return 0;
			}
			if (outOff + outBytes.Length > output.Length)
			{
				throw new global::Org.BouncyCastle.Crypto.DataLengthException("output buffer too short");
			}
			outBytes.CopyTo(output, outOff);
			return outBytes.Length;
		}

		// Token: 0x06001F2C RID: 7980 RVA: 0x0008FC42 File Offset: 0x0008DE42
		public virtual byte[] ProcessBytes(byte[] input)
		{
			return this.ProcessBytes(input, 0, input.Length);
		}

		// Token: 0x06001F2D RID: 7981
		public abstract byte[] ProcessBytes(byte[] input, int inOff, int length);

		// Token: 0x06001F2E RID: 7982 RVA: 0x0008FC4F File Offset: 0x0008DE4F
		public virtual int ProcessBytes(byte[] input, byte[] output, int outOff)
		{
			return this.ProcessBytes(input, 0, input.Length, output, outOff);
		}

		// Token: 0x06001F2F RID: 7983 RVA: 0x0008FC60 File Offset: 0x0008DE60
		public virtual int ProcessBytes(byte[] input, int inOff, int length, byte[] output, int outOff)
		{
			byte[] outBytes = this.ProcessBytes(input, inOff, length);
			if (outBytes == null)
			{
				return 0;
			}
			if (outOff + outBytes.Length > output.Length)
			{
				throw new global::Org.BouncyCastle.Crypto.DataLengthException("output buffer too short");
			}
			outBytes.CopyTo(output, outOff);
			return outBytes.Length;
		}

		// Token: 0x06001F30 RID: 7984
		public abstract byte[] DoFinal();

		// Token: 0x06001F31 RID: 7985 RVA: 0x0008FCA0 File Offset: 0x0008DEA0
		public virtual byte[] DoFinal(byte[] input)
		{
			return this.DoFinal(input, 0, input.Length);
		}

		// Token: 0x06001F32 RID: 7986
		public abstract byte[] DoFinal(byte[] input, int inOff, int length);

		// Token: 0x06001F33 RID: 7987 RVA: 0x0008FCB0 File Offset: 0x0008DEB0
		public virtual int DoFinal(byte[] output, int outOff)
		{
			byte[] outBytes = this.DoFinal();
			if (outOff + outBytes.Length > output.Length)
			{
				throw new global::Org.BouncyCastle.Crypto.DataLengthException("output buffer too short");
			}
			outBytes.CopyTo(output, outOff);
			return outBytes.Length;
		}

		// Token: 0x06001F34 RID: 7988 RVA: 0x0008FCE4 File Offset: 0x0008DEE4
		public virtual int DoFinal(byte[] input, byte[] output, int outOff)
		{
			return this.DoFinal(input, 0, input.Length, output, outOff);
		}

		// Token: 0x06001F35 RID: 7989 RVA: 0x0008FCF4 File Offset: 0x0008DEF4
		public virtual int DoFinal(byte[] input, int inOff, int length, byte[] output, int outOff)
		{
			int len = this.ProcessBytes(input, inOff, length, output, outOff);
			return len + this.DoFinal(output, outOff + len);
		}

		// Token: 0x06001F36 RID: 7990
		public abstract void Reset();

		// Token: 0x04000B26 RID: 2854
		protected static readonly byte[] EmptyBuffer = new byte[0];
	}
}
