using System;
using System.IO;

namespace Ionic.Zip.Deflate64
{
	// Token: 0x0200005D RID: 93
	internal sealed class InflaterManaged
	{
		// Token: 0x0600049A RID: 1178 RVA: 0x0001B454 File Offset: 0x00019654
		internal InflaterManaged(global::Ionic.Zip.Deflate64.IFileFormatReader reader, bool deflate64, long uncompressedSize)
		{
			this._output = new global::Ionic.Zip.Deflate64.OutputWindow();
			this._input = new global::Ionic.Zip.Deflate64.InputBuffer();
			this._codeList = new byte[320];
			this._codeLengthTreeCodeLength = new byte[19];
			this._deflate64 = deflate64;
			this._uncompressedSize = uncompressedSize;
			if (reader != null)
			{
				this._formatReader = reader;
				this._hasFormatReader = true;
			}
			this.Reset();
		}

		// Token: 0x0600049B RID: 1179 RVA: 0x0001B4CB File Offset: 0x000196CB
		private void Reset()
		{
			this._state = (this._hasFormatReader ? global::Ionic.Zip.Deflate64.InflaterState.ReadingHeader : global::Ionic.Zip.Deflate64.InflaterState.ReadingBFinal);
		}

		// Token: 0x0600049C RID: 1180 RVA: 0x0001B4DF File Offset: 0x000196DF
		public void SetInput(byte[] inputBytes, int offset, int length)
		{
			this._input.SetInput(inputBytes, offset, length);
		}

		// Token: 0x0600049D RID: 1181 RVA: 0x0001B4EF File Offset: 0x000196EF
		public bool Finished()
		{
			return this._state == global::Ionic.Zip.Deflate64.InflaterState.Done || this._state == global::Ionic.Zip.Deflate64.InflaterState.VerifyingFooter;
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x0600049E RID: 1182 RVA: 0x0001B507 File Offset: 0x00019707
		public int AvailableOutput
		{
			get
			{
				return this._output.AvailableBytes;
			}
		}

		// Token: 0x0600049F RID: 1183 RVA: 0x0001B514 File Offset: 0x00019714
		public int Inflate(byte[] bytes, int offset, int length)
		{
			int num = 0;
			do
			{
				int num2 = 0;
				if (this._uncompressedSize == -1L)
				{
					num2 = this._output.CopyTo(bytes, offset, length);
				}
				else if (this._uncompressedSize > this._currentInflatedCount)
				{
					length = (int)global::System.Math.Min((long)length, this._uncompressedSize - this._currentInflatedCount);
					num2 = this._output.CopyTo(bytes, offset, length);
					this._currentInflatedCount += (long)num2;
				}
				else
				{
					this._state = global::Ionic.Zip.Deflate64.InflaterState.Done;
					this._output.ClearBytesUsed();
				}
				if (num2 > 0)
				{
					if (this._hasFormatReader)
					{
						this._formatReader.UpdateWithBytesRead(bytes, offset, num2);
					}
					offset += num2;
					num += num2;
					length -= num2;
				}
			}
			while (length != 0 && !this.Finished() && this.Decode());
			if (this._state == global::Ionic.Zip.Deflate64.InflaterState.VerifyingFooter && this._output.AvailableBytes == 0)
			{
				this._formatReader.Validate();
			}
			return num;
		}

		// Token: 0x060004A0 RID: 1184 RVA: 0x0001B5FC File Offset: 0x000197FC
		private bool Decode()
		{
			bool flag = false;
			if (this.Finished())
			{
				return true;
			}
			if (this._hasFormatReader)
			{
				if (this._state == global::Ionic.Zip.Deflate64.InflaterState.ReadingHeader)
				{
					if (!this._formatReader.ReadHeader(this._input))
					{
						return false;
					}
					this._state = global::Ionic.Zip.Deflate64.InflaterState.ReadingBFinal;
				}
				else if (this._state == global::Ionic.Zip.Deflate64.InflaterState.StartReadingFooter || this._state == global::Ionic.Zip.Deflate64.InflaterState.ReadingFooter)
				{
					if (!this._formatReader.ReadFooter(this._input))
					{
						return false;
					}
					this._state = global::Ionic.Zip.Deflate64.InflaterState.VerifyingFooter;
					return true;
				}
			}
			if (this._state == global::Ionic.Zip.Deflate64.InflaterState.ReadingBFinal)
			{
				if (!this._input.EnsureBitsAvailable(1))
				{
					return false;
				}
				this._bfinal = this._input.GetBits(1);
				this._state = global::Ionic.Zip.Deflate64.InflaterState.ReadingBType;
			}
			if (this._state == global::Ionic.Zip.Deflate64.InflaterState.ReadingBType)
			{
				if (!this._input.EnsureBitsAvailable(2))
				{
					this._state = global::Ionic.Zip.Deflate64.InflaterState.ReadingBType;
					return false;
				}
				this._blockType = (global::Ionic.Zip.Deflate64.BlockType)this._input.GetBits(2);
				if (this._blockType == global::Ionic.Zip.Deflate64.BlockType.Dynamic)
				{
					this._state = global::Ionic.Zip.Deflate64.InflaterState.ReadingNumLitCodes;
				}
				else if (this._blockType == global::Ionic.Zip.Deflate64.BlockType.Static)
				{
					this._literalLengthTree = global::Ionic.Zip.Deflate64.HuffmanTree.StaticLiteralLengthTree;
					this._distanceTree = global::Ionic.Zip.Deflate64.HuffmanTree.StaticDistanceTree;
					this._state = global::Ionic.Zip.Deflate64.InflaterState.DecodeTop;
				}
				else
				{
					if (this._blockType != global::Ionic.Zip.Deflate64.BlockType.Uncompressed)
					{
						throw new global::System.IO.InvalidDataException("UnknownBlockType");
					}
					this._state = global::Ionic.Zip.Deflate64.InflaterState.UncompressedAligning;
				}
			}
			bool result;
			if (this._blockType == global::Ionic.Zip.Deflate64.BlockType.Dynamic)
			{
				if (this._state < global::Ionic.Zip.Deflate64.InflaterState.DecodeTop)
				{
					result = this.DecodeDynamicBlockHeader();
				}
				else
				{
					result = this.DecodeBlock(out flag);
				}
			}
			else if (this._blockType == global::Ionic.Zip.Deflate64.BlockType.Static)
			{
				result = this.DecodeBlock(out flag);
			}
			else
			{
				if (this._blockType != global::Ionic.Zip.Deflate64.BlockType.Uncompressed)
				{
					throw new global::System.IO.InvalidDataException("UnknownBlockType");
				}
				result = this.DecodeUncompressedBlock(out flag);
			}
			if (flag && this._bfinal != 0)
			{
				if (this._hasFormatReader)
				{
					this._state = global::Ionic.Zip.Deflate64.InflaterState.StartReadingFooter;
				}
				else
				{
					this._state = global::Ionic.Zip.Deflate64.InflaterState.Done;
				}
			}
			return result;
		}

		// Token: 0x060004A1 RID: 1185 RVA: 0x0001B7B8 File Offset: 0x000199B8
		private bool DecodeUncompressedBlock(out bool end_of_block)
		{
			end_of_block = false;
			for (;;)
			{
				switch (this._state)
				{
				case global::Ionic.Zip.Deflate64.InflaterState.UncompressedAligning:
					this._input.SkipToByteBoundary();
					this._state = global::Ionic.Zip.Deflate64.InflaterState.UncompressedByte1;
					goto IL_43;
				case global::Ionic.Zip.Deflate64.InflaterState.UncompressedByte1:
				case global::Ionic.Zip.Deflate64.InflaterState.UncompressedByte2:
				case global::Ionic.Zip.Deflate64.InflaterState.UncompressedByte3:
				case global::Ionic.Zip.Deflate64.InflaterState.UncompressedByte4:
					goto IL_43;
				case global::Ionic.Zip.Deflate64.InflaterState.DecodingUncompressed:
					goto IL_D1;
				}
				break;
				IL_43:
				int bits = this._input.GetBits(8);
				if (bits < 0)
				{
					return false;
				}
				this._blockLengthBuffer[this._state - global::Ionic.Zip.Deflate64.InflaterState.UncompressedByte1] = (byte)bits;
				if (this._state == global::Ionic.Zip.Deflate64.InflaterState.UncompressedByte4)
				{
					this._blockLength = (int)this._blockLengthBuffer[0] + (int)this._blockLengthBuffer[1] * 256;
					int num = (int)this._blockLengthBuffer[2] + (int)this._blockLengthBuffer[3] * 256;
					if ((ushort)this._blockLength != (ushort)(~(ushort)num))
					{
						goto Block_4;
					}
				}
				this._state++;
			}
			throw new global::System.IO.InvalidDataException("UnknownState");
			Block_4:
			throw new global::System.IO.InvalidDataException("InvalidBlockLength");
			IL_D1:
			int num2 = this._output.CopyFrom(this._input, this._blockLength);
			this._blockLength -= num2;
			if (this._blockLength == 0)
			{
				this._state = global::Ionic.Zip.Deflate64.InflaterState.ReadingBFinal;
				end_of_block = true;
				return true;
			}
			return this._output.FreeBytes == 0;
		}

		// Token: 0x060004A2 RID: 1186 RVA: 0x0001B8EC File Offset: 0x00019AEC
		private bool DecodeBlock(out bool end_of_block_code_seen)
		{
			end_of_block_code_seen = false;
			int i = this._output.FreeBytes;
			while (i > 65536)
			{
				switch (this._state)
				{
				case global::Ionic.Zip.Deflate64.InflaterState.DecodeTop:
				{
					int num = this._literalLengthTree.GetNextSymbol(this._input);
					if (num < 0)
					{
						return false;
					}
					if (num < 256)
					{
						this._output.Write((byte)num);
						i--;
						continue;
					}
					if (num == 256)
					{
						end_of_block_code_seen = true;
						this._state = global::Ionic.Zip.Deflate64.InflaterState.ReadingBFinal;
						return true;
					}
					num -= 257;
					if (num < 8)
					{
						num += 3;
						this._extraBits = 0;
					}
					else if (!this._deflate64 && num == 28)
					{
						num = 258;
						this._extraBits = 0;
					}
					else
					{
						if (num < 0 || num >= global::Ionic.Zip.Deflate64.InflaterManaged.s_extraLengthBits.Length)
						{
							throw new global::System.IO.InvalidDataException("GenericInvalidData");
						}
						this._extraBits = (int)global::Ionic.Zip.Deflate64.InflaterManaged.s_extraLengthBits[num];
					}
					this._length = num;
					goto IL_E5;
				}
				case global::Ionic.Zip.Deflate64.InflaterState.HaveInitialLength:
					goto IL_E5;
				case global::Ionic.Zip.Deflate64.InflaterState.HaveFullLength:
					goto IL_150;
				case global::Ionic.Zip.Deflate64.InflaterState.HaveDistCode:
					break;
				default:
					throw new global::System.IO.InvalidDataException("UnknownState");
				}
				IL_1B2:
				int distance;
				if (this._distanceCode > 3)
				{
					this._extraBits = this._distanceCode - 2 >> 1;
					int bits = this._input.GetBits(this._extraBits);
					if (bits < 0)
					{
						return false;
					}
					distance = global::Ionic.Zip.Deflate64.InflaterManaged.s_distanceBasePosition[this._distanceCode] + bits;
				}
				else
				{
					distance = this._distanceCode + 1;
				}
				this._output.WriteLengthDistance(this._length, distance);
				i -= this._length;
				this._state = global::Ionic.Zip.Deflate64.InflaterState.DecodeTop;
				continue;
				IL_150:
				if (this._blockType == global::Ionic.Zip.Deflate64.BlockType.Dynamic)
				{
					this._distanceCode = this._distanceTree.GetNextSymbol(this._input);
				}
				else
				{
					this._distanceCode = this._input.GetBits(5);
					if (this._distanceCode >= 0)
					{
						this._distanceCode = (int)global::Ionic.Zip.Deflate64.InflaterManaged.s_staticDistanceTreeTable[this._distanceCode];
					}
				}
				if (this._distanceCode < 0)
				{
					return false;
				}
				this._state = global::Ionic.Zip.Deflate64.InflaterState.HaveDistCode;
				goto IL_1B2;
				IL_E5:
				if (this._extraBits > 0)
				{
					this._state = global::Ionic.Zip.Deflate64.InflaterState.HaveInitialLength;
					int bits2 = this._input.GetBits(this._extraBits);
					if (bits2 < 0)
					{
						return false;
					}
					if (this._length < 0 || this._length >= global::Ionic.Zip.Deflate64.InflaterManaged.s_lengthBase.Length)
					{
						throw new global::System.IO.InvalidDataException("GenericInvalidData");
					}
					this._length = global::Ionic.Zip.Deflate64.InflaterManaged.s_lengthBase[this._length] + bits2;
				}
				this._state = global::Ionic.Zip.Deflate64.InflaterState.HaveFullLength;
				goto IL_150;
			}
			return true;
		}

		// Token: 0x060004A3 RID: 1187 RVA: 0x0001BB38 File Offset: 0x00019D38
		private bool DecodeDynamicBlockHeader()
		{
			switch (this._state)
			{
			case global::Ionic.Zip.Deflate64.InflaterState.ReadingNumLitCodes:
				this._literalLengthCodeCount = this._input.GetBits(5);
				if (this._literalLengthCodeCount < 0)
				{
					return false;
				}
				this._literalLengthCodeCount += 257;
				this._state = global::Ionic.Zip.Deflate64.InflaterState.ReadingNumDistCodes;
				goto IL_62;
			case global::Ionic.Zip.Deflate64.InflaterState.ReadingNumDistCodes:
				goto IL_62;
			case global::Ionic.Zip.Deflate64.InflaterState.ReadingNumCodeLengthCodes:
				goto IL_94;
			case global::Ionic.Zip.Deflate64.InflaterState.ReadingCodeLengthCodes:
				break;
			case global::Ionic.Zip.Deflate64.InflaterState.ReadingTreeCodesBefore:
			case global::Ionic.Zip.Deflate64.InflaterState.ReadingTreeCodesAfter:
				goto IL_35A;
			default:
				throw new global::System.IO.InvalidDataException("UnknownState");
			}
			IL_105:
			while (this._loopCounter < this._codeLengthCodeCount)
			{
				int bits = this._input.GetBits(3);
				if (bits < 0)
				{
					return false;
				}
				this._codeLengthTreeCodeLength[(int)global::Ionic.Zip.Deflate64.InflaterManaged.s_codeOrder[this._loopCounter]] = (byte)bits;
				this._loopCounter++;
			}
			for (int i = this._codeLengthCodeCount; i < global::Ionic.Zip.Deflate64.InflaterManaged.s_codeOrder.Length; i++)
			{
				this._codeLengthTreeCodeLength[(int)global::Ionic.Zip.Deflate64.InflaterManaged.s_codeOrder[i]] = 0;
			}
			this._codeLengthTree = new global::Ionic.Zip.Deflate64.HuffmanTree(this._codeLengthTreeCodeLength);
			this._codeArraySize = this._literalLengthCodeCount + this._distanceCodeCount;
			this._loopCounter = 0;
			this._state = global::Ionic.Zip.Deflate64.InflaterState.ReadingTreeCodesBefore;
			IL_35A:
			while (this._loopCounter < this._codeArraySize)
			{
				if (this._state == global::Ionic.Zip.Deflate64.InflaterState.ReadingTreeCodesBefore && (this._lengthCode = this._codeLengthTree.GetNextSymbol(this._input)) < 0)
				{
					return false;
				}
				if (this._lengthCode <= 15)
				{
					byte[] codeList = this._codeList;
					int loopCounter = this._loopCounter;
					this._loopCounter = loopCounter + 1;
					codeList[loopCounter] = (byte)this._lengthCode;
				}
				else if (this._lengthCode == 16)
				{
					if (!this._input.EnsureBitsAvailable(2))
					{
						this._state = global::Ionic.Zip.Deflate64.InflaterState.ReadingTreeCodesAfter;
						return false;
					}
					if (this._loopCounter == 0)
					{
						throw new global::System.IO.InvalidDataException();
					}
					byte b = this._codeList[this._loopCounter - 1];
					int num = this._input.GetBits(2) + 3;
					if (this._loopCounter + num > this._codeArraySize)
					{
						throw new global::System.IO.InvalidDataException();
					}
					for (int j = 0; j < num; j++)
					{
						byte[] codeList2 = this._codeList;
						int loopCounter = this._loopCounter;
						this._loopCounter = loopCounter + 1;
						codeList2[loopCounter] = b;
					}
				}
				else if (this._lengthCode == 17)
				{
					if (!this._input.EnsureBitsAvailable(3))
					{
						this._state = global::Ionic.Zip.Deflate64.InflaterState.ReadingTreeCodesAfter;
						return false;
					}
					int num = this._input.GetBits(3) + 3;
					if (this._loopCounter + num > this._codeArraySize)
					{
						throw new global::System.IO.InvalidDataException();
					}
					for (int k = 0; k < num; k++)
					{
						byte[] codeList3 = this._codeList;
						int loopCounter = this._loopCounter;
						this._loopCounter = loopCounter + 1;
						codeList3[loopCounter] = 0;
					}
				}
				else
				{
					if (!this._input.EnsureBitsAvailable(7))
					{
						this._state = global::Ionic.Zip.Deflate64.InflaterState.ReadingTreeCodesAfter;
						return false;
					}
					int num = this._input.GetBits(7) + 11;
					if (this._loopCounter + num > this._codeArraySize)
					{
						throw new global::System.IO.InvalidDataException();
					}
					for (int l = 0; l < num; l++)
					{
						byte[] codeList4 = this._codeList;
						int loopCounter = this._loopCounter;
						this._loopCounter = loopCounter + 1;
						codeList4[loopCounter] = 0;
					}
				}
				this._state = global::Ionic.Zip.Deflate64.InflaterState.ReadingTreeCodesBefore;
			}
			byte[] array = new byte[288];
			byte[] array2 = new byte[32];
			global::System.Array.Copy(this._codeList, 0, array, 0, this._literalLengthCodeCount);
			global::System.Array.Copy(this._codeList, this._literalLengthCodeCount, array2, 0, this._distanceCodeCount);
			if (array[256] == 0)
			{
				throw new global::System.IO.InvalidDataException();
			}
			this._literalLengthTree = new global::Ionic.Zip.Deflate64.HuffmanTree(array);
			this._distanceTree = new global::Ionic.Zip.Deflate64.HuffmanTree(array2);
			this._state = global::Ionic.Zip.Deflate64.InflaterState.DecodeTop;
			return true;
			IL_62:
			this._distanceCodeCount = this._input.GetBits(5);
			if (this._distanceCodeCount < 0)
			{
				return false;
			}
			this._distanceCodeCount++;
			this._state = global::Ionic.Zip.Deflate64.InflaterState.ReadingNumCodeLengthCodes;
			IL_94:
			this._codeLengthCodeCount = this._input.GetBits(4);
			if (this._codeLengthCodeCount < 0)
			{
				return false;
			}
			this._codeLengthCodeCount += 4;
			this._loopCounter = 0;
			this._state = global::Ionic.Zip.Deflate64.InflaterState.ReadingCodeLengthCodes;
			goto IL_105;
		}

		// Token: 0x060004A4 RID: 1188 RVA: 0x00002061 File Offset: 0x00000261
		public void Dispose()
		{
		}

		// Token: 0x04000301 RID: 769
		private static readonly byte[] s_extraLengthBits = new byte[]
		{
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			1,
			1,
			1,
			1,
			2,
			2,
			2,
			2,
			3,
			3,
			3,
			3,
			4,
			4,
			4,
			4,
			5,
			5,
			5,
			5,
			16
		};

		// Token: 0x04000302 RID: 770
		private static readonly int[] s_lengthBase = new int[]
		{
			3,
			4,
			5,
			6,
			7,
			8,
			9,
			10,
			11,
			13,
			15,
			17,
			19,
			23,
			27,
			31,
			35,
			43,
			51,
			59,
			67,
			83,
			99,
			115,
			131,
			163,
			195,
			227,
			3
		};

		// Token: 0x04000303 RID: 771
		private static readonly int[] s_distanceBasePosition = new int[]
		{
			1,
			2,
			3,
			4,
			5,
			7,
			9,
			13,
			17,
			25,
			33,
			49,
			65,
			97,
			129,
			193,
			257,
			385,
			513,
			769,
			1025,
			1537,
			2049,
			3073,
			4097,
			6145,
			8193,
			12289,
			16385,
			24577,
			32769,
			49153
		};

		// Token: 0x04000304 RID: 772
		private static readonly byte[] s_codeOrder = new byte[]
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

		// Token: 0x04000305 RID: 773
		private static readonly byte[] s_staticDistanceTreeTable = new byte[]
		{
			0,
			16,
			8,
			24,
			4,
			20,
			12,
			28,
			2,
			18,
			10,
			26,
			6,
			22,
			14,
			30,
			1,
			17,
			9,
			25,
			5,
			21,
			13,
			29,
			3,
			19,
			11,
			27,
			7,
			23,
			15,
			31
		};

		// Token: 0x04000306 RID: 774
		private readonly global::Ionic.Zip.Deflate64.OutputWindow _output;

		// Token: 0x04000307 RID: 775
		private readonly global::Ionic.Zip.Deflate64.InputBuffer _input;

		// Token: 0x04000308 RID: 776
		private global::Ionic.Zip.Deflate64.HuffmanTree _literalLengthTree;

		// Token: 0x04000309 RID: 777
		private global::Ionic.Zip.Deflate64.HuffmanTree _distanceTree;

		// Token: 0x0400030A RID: 778
		private global::Ionic.Zip.Deflate64.InflaterState _state;

		// Token: 0x0400030B RID: 779
		private readonly bool _hasFormatReader;

		// Token: 0x0400030C RID: 780
		private int _bfinal;

		// Token: 0x0400030D RID: 781
		private global::Ionic.Zip.Deflate64.BlockType _blockType;

		// Token: 0x0400030E RID: 782
		private readonly byte[] _blockLengthBuffer = new byte[4];

		// Token: 0x0400030F RID: 783
		private int _blockLength;

		// Token: 0x04000310 RID: 784
		private int _length;

		// Token: 0x04000311 RID: 785
		private int _distanceCode;

		// Token: 0x04000312 RID: 786
		private int _extraBits;

		// Token: 0x04000313 RID: 787
		private int _loopCounter;

		// Token: 0x04000314 RID: 788
		private int _literalLengthCodeCount;

		// Token: 0x04000315 RID: 789
		private int _distanceCodeCount;

		// Token: 0x04000316 RID: 790
		private int _codeLengthCodeCount;

		// Token: 0x04000317 RID: 791
		private int _codeArraySize;

		// Token: 0x04000318 RID: 792
		private int _lengthCode;

		// Token: 0x04000319 RID: 793
		private readonly byte[] _codeList;

		// Token: 0x0400031A RID: 794
		private readonly byte[] _codeLengthTreeCodeLength;

		// Token: 0x0400031B RID: 795
		private readonly bool _deflate64;

		// Token: 0x0400031C RID: 796
		private global::Ionic.Zip.Deflate64.HuffmanTree _codeLengthTree;

		// Token: 0x0400031D RID: 797
		private readonly long _uncompressedSize;

		// Token: 0x0400031E RID: 798
		private long _currentInflatedCount;

		// Token: 0x0400031F RID: 799
		private readonly global::Ionic.Zip.Deflate64.IFileFormatReader _formatReader;
	}
}
