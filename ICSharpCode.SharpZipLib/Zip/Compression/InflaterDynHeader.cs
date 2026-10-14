using System;
using System.Collections.Generic;
using ICSharpCode.SharpZipLib.Zip.Compression.Streams;

namespace ICSharpCode.SharpZipLib.Zip.Compression
{
	// Token: 0x0200003A RID: 58
	internal class InflaterDynHeader
	{
		// Token: 0x06000266 RID: 614 RVA: 0x0000D0A1 File Offset: 0x0000B2A1
		public bool AttemptRead()
		{
			return !this.state.MoveNext() || this.state.Current;
		}

		// Token: 0x06000267 RID: 615 RVA: 0x0000D0BD File Offset: 0x0000B2BD
		public InflaterDynHeader(global::ICSharpCode.SharpZipLib.Zip.Compression.Streams.StreamManipulator input)
		{
			this.input = input;
			this.stateMachine = this.CreateStateMachine();
			this.state = this.stateMachine.GetEnumerator();
		}

		// Token: 0x06000268 RID: 616 RVA: 0x0000D0F9 File Offset: 0x0000B2F9
		private global::System.Collections.Generic.IEnumerable<bool> CreateStateMachine()
		{
			while (!this.input.TryGetBits(5, ref this.litLenCodeCount, 257))
			{
				yield return false;
			}
			while (!this.input.TryGetBits(5, ref this.distanceCodeCount, 1))
			{
				yield return false;
			}
			while (!this.input.TryGetBits(4, ref this.metaCodeCount, 4))
			{
				yield return false;
			}
			int dataCodeCount = this.litLenCodeCount + this.distanceCodeCount;
			if (this.litLenCodeCount > 286)
			{
				throw new global::ICSharpCode.SharpZipLib.ValueOutOfRangeException("litLenCodeCount");
			}
			if (this.distanceCodeCount > 30)
			{
				throw new global::ICSharpCode.SharpZipLib.ValueOutOfRangeException("distanceCodeCount");
			}
			if (this.metaCodeCount > 19)
			{
				throw new global::ICSharpCode.SharpZipLib.ValueOutOfRangeException("metaCodeCount");
			}
			int num;
			for (int i = 0; i < this.metaCodeCount; i = num + 1)
			{
				while (!this.input.TryGetBits(3, ref this.codeLengths, global::ICSharpCode.SharpZipLib.Zip.Compression.InflaterDynHeader.MetaCodeLengthIndex[i]))
				{
					yield return false;
				}
				num = i;
			}
			global::ICSharpCode.SharpZipLib.Zip.Compression.InflaterHuffmanTree metaCodeTree = new global::ICSharpCode.SharpZipLib.Zip.Compression.InflaterHuffmanTree(this.codeLengths);
			int index = 0;
			while (index < dataCodeCount)
			{
				int symbol;
				while ((symbol = metaCodeTree.GetSymbol(this.input)) < 0)
				{
					yield return false;
				}
				if (symbol < 16)
				{
					byte[] array = this.codeLengths;
					num = index;
					index = num + 1;
					array[num] = (byte)symbol;
				}
				else
				{
					int i = 0;
					byte codeLength;
					if (symbol == 16)
					{
						if (index == 0)
						{
							throw new global::ICSharpCode.SharpZipLib.StreamDecodingException("Cannot repeat previous code length when no other code length has been read");
						}
						codeLength = this.codeLengths[index - 1];
						while (!this.input.TryGetBits(2, ref i, 3))
						{
							yield return false;
						}
					}
					else if (symbol == 17)
					{
						codeLength = 0;
						while (!this.input.TryGetBits(3, ref i, 3))
						{
							yield return false;
						}
					}
					else
					{
						codeLength = 0;
						while (!this.input.TryGetBits(7, ref i, 11))
						{
							yield return false;
						}
					}
					if (index + i > dataCodeCount)
					{
						throw new global::ICSharpCode.SharpZipLib.StreamDecodingException("Cannot repeat code lengths past total number of data code lengths");
					}
					for (;;)
					{
						num = i;
						i = num - 1;
						if (num <= 0)
						{
							break;
						}
						byte[] array2 = this.codeLengths;
						num = index;
						index = num + 1;
						array2[num] = codeLength;
					}
				}
			}
			if (this.codeLengths[256] == 0)
			{
				throw new global::ICSharpCode.SharpZipLib.StreamDecodingException("Inflater dynamic header end-of-block code missing");
			}
			this.litLenTree = new global::ICSharpCode.SharpZipLib.Zip.Compression.InflaterHuffmanTree(new global::System.ArraySegment<byte>(this.codeLengths, 0, this.litLenCodeCount));
			this.distTree = new global::ICSharpCode.SharpZipLib.Zip.Compression.InflaterHuffmanTree(new global::System.ArraySegment<byte>(this.codeLengths, this.litLenCodeCount, this.distanceCodeCount));
			yield return true;
			yield break;
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000269 RID: 617 RVA: 0x0000D109 File Offset: 0x0000B309
		public global::ICSharpCode.SharpZipLib.Zip.Compression.InflaterHuffmanTree LiteralLengthTree
		{
			get
			{
				global::ICSharpCode.SharpZipLib.Zip.Compression.InflaterHuffmanTree inflaterHuffmanTree = this.litLenTree;
				if (inflaterHuffmanTree == null)
				{
					throw new global::ICSharpCode.SharpZipLib.StreamDecodingException("Header properties were accessed before header had been successfully read");
				}
				return inflaterHuffmanTree;
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x0600026A RID: 618 RVA: 0x0000D120 File Offset: 0x0000B320
		public global::ICSharpCode.SharpZipLib.Zip.Compression.InflaterHuffmanTree DistanceTree
		{
			get
			{
				global::ICSharpCode.SharpZipLib.Zip.Compression.InflaterHuffmanTree inflaterHuffmanTree = this.distTree;
				if (inflaterHuffmanTree == null)
				{
					throw new global::ICSharpCode.SharpZipLib.StreamDecodingException("Header properties were accessed before header had been successfully read");
				}
				return inflaterHuffmanTree;
			}
		}

		// Token: 0x04000191 RID: 401
		private const int LITLEN_MAX = 286;

		// Token: 0x04000192 RID: 402
		private const int DIST_MAX = 30;

		// Token: 0x04000193 RID: 403
		private const int CODELEN_MAX = 316;

		// Token: 0x04000194 RID: 404
		private const int META_MAX = 19;

		// Token: 0x04000195 RID: 405
		private static readonly int[] MetaCodeLengthIndex = new int[]
		{
			16,
			17,
			18,
			0,
			8,
			7,
			9,
			6,
			10,
			5,
			11,
			4,
			12,
			3,
			13,
			2,
			14,
			1,
			15
		};

		// Token: 0x04000196 RID: 406
		private readonly global::ICSharpCode.SharpZipLib.Zip.Compression.Streams.StreamManipulator input;

		// Token: 0x04000197 RID: 407
		private readonly global::System.Collections.Generic.IEnumerator<bool> state;

		// Token: 0x04000198 RID: 408
		private readonly global::System.Collections.Generic.IEnumerable<bool> stateMachine;

		// Token: 0x04000199 RID: 409
		private byte[] codeLengths = new byte[316];

		// Token: 0x0400019A RID: 410
		private global::ICSharpCode.SharpZipLib.Zip.Compression.InflaterHuffmanTree litLenTree;

		// Token: 0x0400019B RID: 411
		private global::ICSharpCode.SharpZipLib.Zip.Compression.InflaterHuffmanTree distTree;

		// Token: 0x0400019C RID: 412
		private int litLenCodeCount;

		// Token: 0x0400019D RID: 413
		private int distanceCodeCount;

		// Token: 0x0400019E RID: 414
		private int metaCodeCount;
	}
}
