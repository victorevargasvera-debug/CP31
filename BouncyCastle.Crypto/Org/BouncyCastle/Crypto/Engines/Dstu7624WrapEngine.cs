using System;
using System.Collections;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Utilities;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Engines
{
	// Token: 0x0200049B RID: 1179
	public class Dstu7624WrapEngine : global::Org.BouncyCastle.Crypto.IWrapper
	{
		// Token: 0x06002D6F RID: 11631 RVA: 0x000CBD05 File Offset: 0x000C9F05
		public Dstu7624WrapEngine(int blockSizeBits)
		{
			this.engine = new global::Org.BouncyCastle.Crypto.Engines.Dstu7624Engine(blockSizeBits);
			this.param = null;
			this.blockSize = blockSizeBits / 8;
		}

		// Token: 0x17000628 RID: 1576
		// (get) Token: 0x06002D70 RID: 11632 RVA: 0x000CBD29 File Offset: 0x000C9F29
		public string AlgorithmName
		{
			get
			{
				return "Dstu7624WrapEngine";
			}
		}

		// Token: 0x06002D71 RID: 11633 RVA: 0x000CBD30 File Offset: 0x000C9F30
		public void Init(bool forWrapping, global::Org.BouncyCastle.Crypto.ICipherParameters parameters)
		{
			this.forWrapping = forWrapping;
			if (parameters is global::Org.BouncyCastle.Crypto.Parameters.KeyParameter)
			{
				this.param = (global::Org.BouncyCastle.Crypto.Parameters.KeyParameter)parameters;
				this.engine.Init(forWrapping, this.param);
				return;
			}
			throw new global::System.ArgumentException("Bad parameters passed to Dstu7624WrapEngine");
		}

		// Token: 0x06002D72 RID: 11634 RVA: 0x000CBD6C File Offset: 0x000C9F6C
		public byte[] Wrap(byte[] input, int inOff, int length)
		{
			if (!this.forWrapping)
			{
				throw new global::System.InvalidOperationException("Not set for wrapping");
			}
			if (length % this.blockSize != 0)
			{
				throw new global::System.ArgumentException("Padding not supported");
			}
			int i = 2 * (1 + length / this.blockSize);
			int V = (i - 1) * 6;
			byte[] buffer = new byte[length + this.blockSize];
			global::System.Array.Copy(input, inOff, buffer, 0, length);
			byte[] B = new byte[this.blockSize / 2];
			global::System.Array.Copy(buffer, 0, B, 0, this.blockSize / 2);
			global::System.Collections.IList bTemp = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
			int bHalfBlocksLen = buffer.Length - this.blockSize / 2;
			int bufOff = this.blockSize / 2;
			while (bHalfBlocksLen != 0)
			{
				byte[] temp = new byte[this.blockSize / 2];
				global::System.Array.Copy(buffer, bufOff, temp, 0, this.blockSize / 2);
				bTemp.Add(temp);
				bHalfBlocksLen -= this.blockSize / 2;
				bufOff += this.blockSize / 2;
			}
			for (int j = 0; j < V; j++)
			{
				global::System.Array.Copy(B, 0, buffer, 0, this.blockSize / 2);
				global::System.Array.Copy((byte[])bTemp[0], 0, buffer, this.blockSize / 2, this.blockSize / 2);
				this.engine.ProcessBlock(buffer, 0, buffer, 0);
				byte[] intArray = global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_LE((uint)(j + 1));
				for (int byteNum = 0; byteNum < intArray.Length; byteNum++)
				{
					byte[] array = buffer;
					int num = byteNum + this.blockSize / 2;
					array[num] ^= intArray[byteNum];
				}
				global::System.Array.Copy(buffer, this.blockSize / 2, B, 0, this.blockSize / 2);
				for (int k = 2; k < i; k++)
				{
					global::System.Array.Copy((byte[])bTemp[k - 1], 0, (byte[])bTemp[k - 2], 0, this.blockSize / 2);
				}
				global::System.Array.Copy(buffer, 0, (byte[])bTemp[i - 2], 0, this.blockSize / 2);
			}
			global::System.Array.Copy(B, 0, buffer, 0, this.blockSize / 2);
			bufOff = this.blockSize / 2;
			for (int l = 0; l < i - 1; l++)
			{
				global::System.Array.Copy((byte[])bTemp[l], 0, buffer, bufOff, this.blockSize / 2);
				bufOff += this.blockSize / 2;
			}
			return buffer;
		}

		// Token: 0x06002D73 RID: 11635 RVA: 0x000CBFBC File Offset: 0x000CA1BC
		public byte[] Unwrap(byte[] input, int inOff, int length)
		{
			if (this.forWrapping)
			{
				throw new global::System.InvalidOperationException("not set for unwrapping");
			}
			if (length % this.blockSize != 0)
			{
				throw new global::System.ArgumentException("Padding not supported");
			}
			int i = 2 * length / this.blockSize;
			int V = (i - 1) * 6;
			byte[] buffer = new byte[length];
			global::System.Array.Copy(input, inOff, buffer, 0, length);
			byte[] B = new byte[this.blockSize / 2];
			global::System.Array.Copy(buffer, 0, B, 0, this.blockSize / 2);
			global::System.Collections.IList bTemp = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
			int bHalfBlocksLen = buffer.Length - this.blockSize / 2;
			int bufOff = this.blockSize / 2;
			while (bHalfBlocksLen != 0)
			{
				byte[] temp = new byte[this.blockSize / 2];
				global::System.Array.Copy(buffer, bufOff, temp, 0, this.blockSize / 2);
				bTemp.Add(temp);
				bHalfBlocksLen -= this.blockSize / 2;
				bufOff += this.blockSize / 2;
			}
			for (int j = 0; j < V; j++)
			{
				global::System.Array.Copy((byte[])bTemp[i - 2], 0, buffer, 0, this.blockSize / 2);
				global::System.Array.Copy(B, 0, buffer, this.blockSize / 2, this.blockSize / 2);
				byte[] intArray = global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_LE((uint)(V - j));
				for (int byteNum = 0; byteNum < intArray.Length; byteNum++)
				{
					byte[] array = buffer;
					int num = byteNum + this.blockSize / 2;
					array[num] ^= intArray[byteNum];
				}
				this.engine.ProcessBlock(buffer, 0, buffer, 0);
				global::System.Array.Copy(buffer, 0, B, 0, this.blockSize / 2);
				for (int k = 2; k < i; k++)
				{
					global::System.Array.Copy((byte[])bTemp[i - k - 1], 0, (byte[])bTemp[i - k], 0, this.blockSize / 2);
				}
				global::System.Array.Copy(buffer, this.blockSize / 2, (byte[])bTemp[0], 0, this.blockSize / 2);
			}
			global::System.Array.Copy(B, 0, buffer, 0, this.blockSize / 2);
			bufOff = this.blockSize / 2;
			for (int l = 0; l < i - 1; l++)
			{
				global::System.Array.Copy((byte[])bTemp[l], 0, buffer, bufOff, this.blockSize / 2);
				bufOff += this.blockSize / 2;
			}
			byte diff = 0;
			for (int m = buffer.Length - this.blockSize; m < buffer.Length; m++)
			{
				diff |= buffer[m];
			}
			if (diff != 0)
			{
				throw new global::Org.BouncyCastle.Crypto.InvalidCipherTextException("checksum failed");
			}
			return global::Org.BouncyCastle.Utilities.Arrays.CopyOfRange(buffer, 0, buffer.Length - this.blockSize);
		}

		// Token: 0x04001324 RID: 4900
		private global::Org.BouncyCastle.Crypto.Parameters.KeyParameter param;

		// Token: 0x04001325 RID: 4901
		private global::Org.BouncyCastle.Crypto.Engines.Dstu7624Engine engine;

		// Token: 0x04001326 RID: 4902
		private bool forWrapping;

		// Token: 0x04001327 RID: 4903
		private int blockSize;
	}
}
