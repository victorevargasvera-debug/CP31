using System;
using Org.BouncyCastle.Crypto;

namespace NPOI.POIFS.Crypt.Standard
{
	// Token: 0x0200030E RID: 782
	public class NullBufferedCipher : global::Org.BouncyCastle.Crypto.IBufferedCipher
	{
		// Token: 0x17000465 RID: 1125
		// (get) Token: 0x060016A7 RID: 5799 RVA: 0x000435D8 File Offset: 0x000417D8
		public string AlgorithmName
		{
			get
			{
				return "Null";
			}
		}

		// Token: 0x060016A8 RID: 5800 RVA: 0x000435DF File Offset: 0x000417DF
		public byte[] DoFinal()
		{
			return new byte[0];
		}

		// Token: 0x060016A9 RID: 5801 RVA: 0x000435DF File Offset: 0x000417DF
		public byte[] DoFinal(byte[] input)
		{
			return new byte[0];
		}

		// Token: 0x060016AA RID: 5802 RVA: 0x000435DF File Offset: 0x000417DF
		public byte[] DoFinal(byte[] input, int inOff, int length)
		{
			return new byte[0];
		}

		// Token: 0x060016AB RID: 5803 RVA: 0x00006EB4 File Offset: 0x000050B4
		public int DoFinal(byte[] output, int outOff)
		{
			return 0;
		}

		// Token: 0x060016AC RID: 5804 RVA: 0x00006EB4 File Offset: 0x000050B4
		public int DoFinal(byte[] input, byte[] output, int outOff)
		{
			return 0;
		}

		// Token: 0x060016AD RID: 5805 RVA: 0x00006EB4 File Offset: 0x000050B4
		public int DoFinal(byte[] input, int inOff, int length, byte[] output, int outOff)
		{
			return 0;
		}

		// Token: 0x060016AE RID: 5806 RVA: 0x00006EB4 File Offset: 0x000050B4
		public int GetBlockSize()
		{
			return 0;
		}

		// Token: 0x060016AF RID: 5807 RVA: 0x00006EB4 File Offset: 0x000050B4
		public int GetOutputSize(int inputLen)
		{
			return 0;
		}

		// Token: 0x060016B0 RID: 5808 RVA: 0x00006EB4 File Offset: 0x000050B4
		public int GetUpdateOutputSize(int inputLen)
		{
			return 0;
		}

		// Token: 0x060016B1 RID: 5809 RVA: 0x00019A7F File Offset: 0x00017C7F
		public void Init(bool forEncryption, global::Org.BouncyCastle.Crypto.ICipherParameters parameters)
		{
		}

		// Token: 0x060016B2 RID: 5810 RVA: 0x000435DF File Offset: 0x000417DF
		public byte[] ProcessByte(byte input)
		{
			return new byte[0];
		}

		// Token: 0x060016B3 RID: 5811 RVA: 0x00006EB4 File Offset: 0x000050B4
		public int ProcessByte(byte input, byte[] output, int outOff)
		{
			return 0;
		}

		// Token: 0x060016B4 RID: 5812 RVA: 0x000435DF File Offset: 0x000417DF
		public byte[] ProcessBytes(byte[] input)
		{
			return new byte[0];
		}

		// Token: 0x060016B5 RID: 5813 RVA: 0x000435DF File Offset: 0x000417DF
		public byte[] ProcessBytes(byte[] input, int inOff, int length)
		{
			return new byte[0];
		}

		// Token: 0x060016B6 RID: 5814 RVA: 0x00006EB4 File Offset: 0x000050B4
		public int ProcessBytes(byte[] input, byte[] output, int outOff)
		{
			return 0;
		}

		// Token: 0x060016B7 RID: 5815 RVA: 0x00006EB4 File Offset: 0x000050B4
		public int ProcessBytes(byte[] input, int inOff, int length, byte[] output, int outOff)
		{
			return 0;
		}

		// Token: 0x060016B8 RID: 5816 RVA: 0x00019A7F File Offset: 0x00017C7F
		public void Reset()
		{
		}
	}
}
