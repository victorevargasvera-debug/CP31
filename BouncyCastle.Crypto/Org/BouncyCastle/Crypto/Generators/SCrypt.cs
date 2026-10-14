using System;
using Org.BouncyCastle.Crypto.Digests;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Utilities;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Generators
{
	// Token: 0x02000483 RID: 1155
	public class SCrypt
	{
		// Token: 0x06002C40 RID: 11328 RVA: 0x000BF248 File Offset: 0x000BD448
		public static byte[] Generate(byte[] P, byte[] S, int N, int r, int p, int dkLen)
		{
			if (P == null)
			{
				throw new global::System.ArgumentNullException("Passphrase P must be provided.");
			}
			if (S == null)
			{
				throw new global::System.ArgumentNullException("Salt S must be provided.");
			}
			if (N <= 1 || !global::Org.BouncyCastle.Crypto.Generators.SCrypt.IsPowerOf2(N))
			{
				throw new global::System.ArgumentException("Cost parameter N must be > 1 and a power of 2.");
			}
			if (r == 1 && N >= 65536)
			{
				throw new global::System.ArgumentException("Cost parameter N must be > 1 and < 65536.");
			}
			if (r < 1)
			{
				throw new global::System.ArgumentException("Block size r must be >= 1.");
			}
			int maxParallel = int.MaxValue / (128 * r * 8);
			if (p < 1 || p > maxParallel)
			{
				throw new global::System.ArgumentException(string.Concat(new string[]
				{
					"Parallelisation parameter p must be >= 1 and <= ",
					maxParallel.ToString(),
					" (based on block size r of ",
					r.ToString(),
					")"
				}));
			}
			if (dkLen < 1)
			{
				throw new global::System.ArgumentException("Generated key length dkLen must be >= 1.");
			}
			return global::Org.BouncyCastle.Crypto.Generators.SCrypt.MFcrypt(P, S, N, r, p, dkLen);
		}

		// Token: 0x06002C41 RID: 11329 RVA: 0x000BF324 File Offset: 0x000BD524
		private static byte[] MFcrypt(byte[] P, byte[] S, int N, int r, int p, int dkLen)
		{
			int MFLenBytes = r * 128;
			byte[] bytes = global::Org.BouncyCastle.Crypto.Generators.SCrypt.SingleIterationPBKDF2(P, S, p * MFLenBytes);
			uint[] B = null;
			byte[] result;
			try
			{
				int BLen = bytes.Length >> 2;
				B = new uint[BLen];
				global::Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(bytes, 0, B);
				int d = 0;
				int total = N * r;
				while (N - d > 2 && total > 1024)
				{
					d++;
					total >>= 1;
				}
				int MFLenWords = MFLenBytes >> 2;
				for (int BOff = 0; BOff < BLen; BOff += MFLenWords)
				{
					global::Org.BouncyCastle.Crypto.Generators.SCrypt.SMix(B, BOff, N, d, r);
				}
				global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_LE(B, bytes, 0);
				result = global::Org.BouncyCastle.Crypto.Generators.SCrypt.SingleIterationPBKDF2(P, bytes, dkLen);
			}
			finally
			{
				global::Org.BouncyCastle.Crypto.Generators.SCrypt.ClearAll(new global::System.Array[]
				{
					bytes,
					B
				});
			}
			return result;
		}

		// Token: 0x06002C42 RID: 11330 RVA: 0x000BF3E0 File Offset: 0x000BD5E0
		private static byte[] SingleIterationPBKDF2(byte[] P, byte[] S, int dkLen)
		{
			global::Org.BouncyCastle.Crypto.Generators.Pkcs5S2ParametersGenerator pkcs5S2ParametersGenerator = new global::Org.BouncyCastle.Crypto.Generators.Pkcs5S2ParametersGenerator(new global::Org.BouncyCastle.Crypto.Digests.Sha256Digest());
			pkcs5S2ParametersGenerator.Init(P, S, 1);
			return ((global::Org.BouncyCastle.Crypto.Parameters.KeyParameter)pkcs5S2ParametersGenerator.GenerateDerivedMacParameters(dkLen * 8)).GetKey();
		}

		// Token: 0x06002C43 RID: 11331 RVA: 0x000BF408 File Offset: 0x000BD608
		private static void SMix(uint[] B, int BOff, int N, int d, int r)
		{
			int num = global::Org.BouncyCastle.Utilities.Integers.NumberOfTrailingZeros(N);
			int blocksPerChunk = N >> d;
			int chunkCount = 1 << d;
			int chunkMask = blocksPerChunk - 1;
			int chunkPow = num - d;
			int BCount = r * 32;
			uint[] blockX = new uint[16];
			uint[] blockX2 = new uint[16];
			uint[] blockY = new uint[BCount];
			uint[] X = new uint[BCount];
			uint[][] VV = new uint[chunkCount][];
			try
			{
				global::System.Array.Copy(B, BOff, X, 0, BCount);
				for (int c = 0; c < chunkCount; c++)
				{
					uint[] V = new uint[blocksPerChunk * BCount];
					VV[c] = V;
					int off = 0;
					for (int i = 0; i < blocksPerChunk; i += 2)
					{
						global::System.Array.Copy(X, 0, V, off, BCount);
						off += BCount;
						global::Org.BouncyCastle.Crypto.Generators.SCrypt.BlockMix(X, blockX, blockX2, blockY, r);
						global::System.Array.Copy(blockY, 0, V, off, BCount);
						off += BCount;
						global::Org.BouncyCastle.Crypto.Generators.SCrypt.BlockMix(blockY, blockX, blockX2, X, r);
					}
				}
				uint mask = (uint)(N - 1);
				for (int j = 0; j < N; j++)
				{
					int k = (int)(X[BCount - 16] & mask);
					global::System.Array sourceArray = VV[k >> chunkPow];
					int VOff = (k & chunkMask) * BCount;
					global::System.Array.Copy(sourceArray, VOff, blockY, 0, BCount);
					global::Org.BouncyCastle.Crypto.Generators.SCrypt.Xor(blockY, X, 0, blockY);
					global::Org.BouncyCastle.Crypto.Generators.SCrypt.BlockMix(blockY, blockX, blockX2, X, r);
				}
				global::System.Array.Copy(X, 0, B, BOff, BCount);
			}
			finally
			{
				global::System.Array[] arrays = VV;
				global::Org.BouncyCastle.Crypto.Generators.SCrypt.ClearAll(arrays);
				global::Org.BouncyCastle.Crypto.Generators.SCrypt.ClearAll(new global::System.Array[]
				{
					X,
					blockX,
					blockX2,
					blockY
				});
			}
		}

		// Token: 0x06002C44 RID: 11332 RVA: 0x000BF594 File Offset: 0x000BD794
		private static void BlockMix(uint[] B, uint[] X1, uint[] X2, uint[] Y, int r)
		{
			global::System.Array.Copy(B, B.Length - 16, X1, 0, 16);
			int BOff = 0;
			int YOff = 0;
			int halfLen = B.Length >> 1;
			for (int i = 2 * r; i > 0; i--)
			{
				global::Org.BouncyCastle.Crypto.Generators.SCrypt.Xor(X1, B, BOff, X2);
				global::Org.BouncyCastle.Crypto.Engines.Salsa20Engine.SalsaCore(8, X2, X1);
				global::System.Array.Copy(X1, 0, Y, YOff, 16);
				YOff = halfLen + BOff - YOff;
				BOff += 16;
			}
		}

		// Token: 0x06002C45 RID: 11333 RVA: 0x000BF5F4 File Offset: 0x000BD7F4
		private static void Xor(uint[] a, uint[] b, int bOff, uint[] output)
		{
			for (int i = output.Length - 1; i >= 0; i--)
			{
				output[i] = (a[i] ^ b[bOff + i]);
			}
		}

		// Token: 0x06002C46 RID: 11334 RVA: 0x000BF61D File Offset: 0x000BD81D
		private static void Clear(global::System.Array array)
		{
			if (array != null)
			{
				global::System.Array.Clear(array, 0, array.Length);
			}
		}

		// Token: 0x06002C47 RID: 11335 RVA: 0x000BF630 File Offset: 0x000BD830
		private static void ClearAll(params global::System.Array[] arrays)
		{
			for (int i = 0; i < arrays.Length; i++)
			{
				global::Org.BouncyCastle.Crypto.Generators.SCrypt.Clear(arrays[i]);
			}
		}

		// Token: 0x06002C48 RID: 11336 RVA: 0x000BF655 File Offset: 0x000BD855
		private static bool IsPowerOf2(int x)
		{
			return (x & x - 1) == 0;
		}
	}
}
