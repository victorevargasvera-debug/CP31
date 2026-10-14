using System;
using Ionic.Crc;

namespace Ionic.BZip2
{
	// Token: 0x02000442 RID: 1090
	internal class BZip2Compressor
	{
		// Token: 0x06002F20 RID: 12064 RVA: 0x000A5260 File Offset: 0x000A3460
		public BZip2Compressor(global::Ionic.BZip2.BitWriter writer) : this(writer, global::Ionic.BZip2.BZip2.MaxBlockSize)
		{
		}

		// Token: 0x06002F21 RID: 12065 RVA: 0x000A5270 File Offset: 0x000A3470
		public BZip2Compressor(global::Ionic.BZip2.BitWriter writer, int blockSize)
		{
			this.blockSize100k = blockSize;
			this.bw = writer;
			this.outBlockFillThreshold = blockSize * global::Ionic.BZip2.BZip2.BlockSizeMultiple - 20;
			this.cstate = new global::Ionic.BZip2.BZip2Compressor.CompressionState(blockSize);
			this.Reset();
		}

		// Token: 0x06002F22 RID: 12066 RVA: 0x000A52CC File Offset: 0x000A34CC
		private void Reset()
		{
			this.crc.Reset();
			this.currentByte = -1;
			this.runLength = 0;
			this.last = -1;
			int num = 256;
			while (--num >= 0)
			{
				this.cstate.inUse[num] = false;
			}
		}

		// Token: 0x17000D9A RID: 3482
		// (get) Token: 0x06002F23 RID: 12067 RVA: 0x000A5320 File Offset: 0x000A3520
		public int BlockSize
		{
			get
			{
				return this.blockSize100k;
			}
		}

		// Token: 0x17000D9B RID: 3483
		// (get) Token: 0x06002F24 RID: 12068 RVA: 0x000A5328 File Offset: 0x000A3528
		// (set) Token: 0x06002F25 RID: 12069 RVA: 0x000A5330 File Offset: 0x000A3530
		public uint Crc32 { get; private set; }

		// Token: 0x17000D9C RID: 3484
		// (get) Token: 0x06002F26 RID: 12070 RVA: 0x000A533C File Offset: 0x000A353C
		// (set) Token: 0x06002F27 RID: 12071 RVA: 0x000A5344 File Offset: 0x000A3544
		public int AvailableBytesOut { get; private set; }

		// Token: 0x17000D9D RID: 3485
		// (get) Token: 0x06002F28 RID: 12072 RVA: 0x000A5350 File Offset: 0x000A3550
		public int UncompressedBytes
		{
			get
			{
				return this.last + 1;
			}
		}

		// Token: 0x06002F29 RID: 12073 RVA: 0x000A535C File Offset: 0x000A355C
		public int Fill(byte[] buffer, int offset, int count)
		{
			if (this.last >= this.outBlockFillThreshold)
			{
				return 0;
			}
			int num = 0;
			int num2 = offset + count;
			int num3;
			do
			{
				num3 = this.write0(buffer[offset++]);
				if (num3 > 0)
				{
					num++;
				}
			}
			while (offset < num2 && num3 == 1);
			return num;
		}

		// Token: 0x06002F2A RID: 12074 RVA: 0x000A53AC File Offset: 0x000A35AC
		private int write0(byte b)
		{
			if (this.currentByte == -1)
			{
				this.currentByte = (int)b;
				this.runLength++;
				return 1;
			}
			if (this.currentByte == (int)b)
			{
				int num = this.runLength + 1;
				this.runLength = num;
				if (num <= 254)
				{
					return 1;
				}
				bool flag = this.AddRunToOutputBlock(false);
				this.currentByte = -1;
				this.runLength = 0;
				if (!flag)
				{
					return 1;
				}
				return 2;
			}
			else
			{
				if (this.AddRunToOutputBlock(false))
				{
					this.currentByte = -1;
					this.runLength = 0;
					return 0;
				}
				this.runLength = 1;
				this.currentByte = (int)b;
				return 1;
			}
		}

		// Token: 0x06002F2B RID: 12075 RVA: 0x000A5454 File Offset: 0x000A3654
		private bool AddRunToOutputBlock(bool final)
		{
			this.runs++;
			int num = this.last;
			if (num >= this.outBlockFillThreshold && !final)
			{
				throw new global::System.Exception(string.Format("block overrun(final={2}): {0} >= threshold ({1})", num, this.outBlockFillThreshold, final));
			}
			byte b = (byte)this.currentByte;
			byte[] block = this.cstate.block;
			this.cstate.inUse[(int)b] = true;
			int num2 = this.runLength;
			this.crc.UpdateCRC(b, num2);
			switch (num2)
			{
			case 1:
				block[num + 2] = b;
				this.last = num + 1;
				break;
			case 2:
				block[num + 2] = b;
				block[num + 3] = b;
				this.last = num + 2;
				break;
			case 3:
				block[num + 2] = b;
				block[num + 3] = b;
				block[num + 4] = b;
				this.last = num + 3;
				break;
			default:
				num2 -= 4;
				this.cstate.inUse[num2] = true;
				block[num + 2] = b;
				block[num + 3] = b;
				block[num + 4] = b;
				block[num + 5] = b;
				block[num + 6] = (byte)num2;
				this.last = num + 5;
				break;
			}
			return this.last >= this.outBlockFillThreshold;
		}

		// Token: 0x06002F2C RID: 12076 RVA: 0x000A559C File Offset: 0x000A379C
		public void CompressAndWrite()
		{
			if (this.runLength > 0)
			{
				this.AddRunToOutputBlock(true);
			}
			this.currentByte = -1;
			if (this.last == -1)
			{
				return;
			}
			this.blockSort();
			this.bw.WriteByte(49);
			this.bw.WriteByte(65);
			this.bw.WriteByte(89);
			this.bw.WriteByte(38);
			this.bw.WriteByte(83);
			this.bw.WriteByte(89);
			this.Crc32 = (uint)this.crc.Crc32Result;
			this.bw.WriteInt(this.Crc32);
			this.bw.WriteBits(1, this.blockRandomised ? 1U : 0U);
			this.moveToFrontCodeAndSend();
			this.Reset();
		}

		// Token: 0x06002F2D RID: 12077 RVA: 0x000A5678 File Offset: 0x000A3878
		private void randomiseBlock()
		{
			bool[] inUse = this.cstate.inUse;
			byte[] block = this.cstate.block;
			int num = this.last;
			int num2 = 256;
			while (--num2 >= 0)
			{
				inUse[num2] = false;
			}
			int num3 = 0;
			int num4 = 0;
			int i = 0;
			int num5 = 1;
			while (i <= num)
			{
				if (num3 == 0)
				{
					num3 = (int)((ushort)global::Ionic.BZip2.Rand.Rnums(num4));
					if (++num4 == 512)
					{
						num4 = 0;
					}
				}
				num3--;
				byte[] array = block;
				int num6 = num5;
				array[num6] ^= ((num3 == 1) ? 1 : 0);
				inUse[(int)(block[num5] & byte.MaxValue)] = true;
				i = num5;
				num5++;
			}
			this.blockRandomised = true;
		}

		// Token: 0x06002F2E RID: 12078 RVA: 0x000A573C File Offset: 0x000A393C
		private void mainSort()
		{
			global::Ionic.BZip2.BZip2Compressor.CompressionState compressionState = this.cstate;
			int[] mainSort_runningOrder = compressionState.mainSort_runningOrder;
			int[] mainSort_copy = compressionState.mainSort_copy;
			bool[] mainSort_bigDone = compressionState.mainSort_bigDone;
			int[] ftab = compressionState.ftab;
			byte[] block = compressionState.block;
			int[] fmap = compressionState.fmap;
			char[] quadrant = compressionState.quadrant;
			int num = this.last;
			int num2 = this.workLimit;
			bool flag = this.firstAttempt;
			int num3 = 65537;
			while (--num3 >= 0)
			{
				ftab[num3] = 0;
			}
			for (int i = 0; i < global::Ionic.BZip2.BZip2.NUM_OVERSHOOT_BYTES; i++)
			{
				block[num + i + 2] = block[i % (num + 1) + 1];
			}
			int num4 = num + global::Ionic.BZip2.BZip2.NUM_OVERSHOOT_BYTES + 1;
			while (--num4 >= 0)
			{
				quadrant[num4] = '\0';
			}
			block[0] = block[num + 1];
			int num5 = (int)(block[0] & byte.MaxValue);
			for (int j = 0; j <= num; j++)
			{
				int num6 = (int)(block[j + 1] & byte.MaxValue);
				ftab[(num5 << 8) + num6]++;
				num5 = num6;
			}
			for (int k = 1; k <= 65536; k++)
			{
				ftab[k] += ftab[k - 1];
			}
			num5 = (int)(block[1] & byte.MaxValue);
			int num9;
			for (int l = 0; l < num; l++)
			{
				int num7 = (int)(block[l + 2] & byte.MaxValue);
				int[] array = fmap;
				int[] array2 = ftab;
				int num8 = (num5 << 8) + num7;
				num9 = array2[num8] - 1;
				array2[num8] = num9;
				array[num9] = l;
				num5 = num7;
			}
			int[] array3 = fmap;
			int[] array4 = ftab;
			int num10 = ((int)(block[num + 1] & byte.MaxValue) << 8) + (int)(block[1] & byte.MaxValue);
			num9 = array4[num10] - 1;
			array4[num10] = num9;
			array3[num9] = num;
			int num11 = 256;
			while (--num11 >= 0)
			{
				mainSort_bigDone[num11] = false;
				mainSort_runningOrder[num11] = num11;
			}
			int num12 = 364;
			while (num12 != 1)
			{
				num12 /= 3;
				for (int m = num12; m <= 255; m++)
				{
					int num13 = mainSort_runningOrder[m];
					int num14 = ftab[num13 + 1 << 8] - ftab[num13 << 8];
					int num15 = num12 - 1;
					int num16 = m;
					int num17 = mainSort_runningOrder[num16 - num12];
					while (ftab[num17 + 1 << 8] - ftab[num17 << 8] > num14)
					{
						mainSort_runningOrder[num16] = num17;
						num16 -= num12;
						if (num16 <= num15)
						{
							break;
						}
						num17 = mainSort_runningOrder[num16 - num12];
					}
					mainSort_runningOrder[num16] = num13;
				}
			}
			for (int n = 0; n <= 255; n++)
			{
				int num18 = mainSort_runningOrder[n];
				for (int num19 = 0; num19 <= 255; num19++)
				{
					int num20 = (num18 << 8) + num19;
					int num21 = ftab[num20];
					if ((num21 & global::Ionic.BZip2.BZip2Compressor.SETMASK) != global::Ionic.BZip2.BZip2Compressor.SETMASK)
					{
						int num22 = num21 & global::Ionic.BZip2.BZip2Compressor.CLEARMASK;
						int num23 = (ftab[num20 + 1] & global::Ionic.BZip2.BZip2Compressor.CLEARMASK) - 1;
						if (num23 > num22)
						{
							this.mainQSort3(compressionState, num22, num23, 2);
							if (flag && this.workDone > num2)
							{
								return;
							}
						}
						ftab[num20] = (num21 | global::Ionic.BZip2.BZip2Compressor.SETMASK);
					}
				}
				for (int num24 = 0; num24 <= 255; num24++)
				{
					mainSort_copy[num24] = (ftab[(num24 << 8) + num18] & global::Ionic.BZip2.BZip2Compressor.CLEARMASK);
				}
				int num25 = ftab[num18 << 8] & global::Ionic.BZip2.BZip2Compressor.CLEARMASK;
				int num26 = ftab[num18 + 1 << 8] & global::Ionic.BZip2.BZip2Compressor.CLEARMASK;
				while (num25 < num26)
				{
					int num27 = fmap[num25];
					num5 = (int)(block[num27] & byte.MaxValue);
					if (!mainSort_bigDone[num5])
					{
						fmap[mainSort_copy[num5]] = ((num27 == 0) ? num : (num27 - 1));
						mainSort_copy[num5]++;
					}
					num25++;
				}
				int num28 = 256;
				while (--num28 >= 0)
				{
					ftab[(num28 << 8) + num18] |= global::Ionic.BZip2.BZip2Compressor.SETMASK;
				}
				mainSort_bigDone[num18] = true;
				if (n < 255)
				{
					int num29 = ftab[num18 << 8] & global::Ionic.BZip2.BZip2Compressor.CLEARMASK;
					int num30 = (ftab[num18 + 1 << 8] & global::Ionic.BZip2.BZip2Compressor.CLEARMASK) - num29;
					int num31 = 0;
					while (num30 >> num31 > 65534)
					{
						num31++;
					}
					for (int num32 = 0; num32 < num30; num32++)
					{
						int num33 = fmap[num29 + num32];
						char c = (char)(num32 >> num31);
						quadrant[num33] = c;
						if (num33 < global::Ionic.BZip2.BZip2.NUM_OVERSHOOT_BYTES)
						{
							quadrant[num33 + num + 1] = c;
						}
					}
				}
			}
		}

		// Token: 0x06002F2F RID: 12079 RVA: 0x000A5BDC File Offset: 0x000A3DDC
		private void blockSort()
		{
			this.workLimit = global::Ionic.BZip2.BZip2Compressor.WORK_FACTOR * this.last;
			this.workDone = 0;
			this.blockRandomised = false;
			this.firstAttempt = true;
			this.mainSort();
			if (this.firstAttempt && this.workDone > this.workLimit)
			{
				this.randomiseBlock();
				this.workLimit = (this.workDone = 0);
				this.firstAttempt = false;
				this.mainSort();
			}
			int[] fmap = this.cstate.fmap;
			this.origPtr = -1;
			int i = 0;
			int num = this.last;
			while (i <= num)
			{
				if (fmap[i] == 0)
				{
					this.origPtr = i;
					return;
				}
				i++;
			}
		}

		// Token: 0x06002F30 RID: 12080 RVA: 0x000A5C94 File Offset: 0x000A3E94
		private bool mainSimpleSort(global::Ionic.BZip2.BZip2Compressor.CompressionState dataShadow, int lo, int hi, int d)
		{
			int num = hi - lo + 1;
			if (num < 2)
			{
				return this.firstAttempt && this.workDone > this.workLimit;
			}
			int num2 = 0;
			while (global::Ionic.BZip2.BZip2Compressor.increments[num2] < num)
			{
				num2++;
			}
			int[] fmap = dataShadow.fmap;
			char[] quadrant = dataShadow.quadrant;
			byte[] block = dataShadow.block;
			int num3 = this.last;
			int num4 = num3 + 1;
			bool flag = this.firstAttempt;
			int num5 = this.workLimit;
			int num6 = this.workDone;
			while (--num2 >= 0)
			{
				int num7 = global::Ionic.BZip2.BZip2Compressor.increments[num2];
				int num8 = lo + num7 - 1;
				int i = lo + num7;
				while (i <= hi)
				{
					int num9 = 3;
					while (i <= hi && --num9 >= 0)
					{
						int num10 = fmap[i];
						int num11 = num10 + d;
						int num12 = i;
						bool flag2 = false;
						int num13 = 0;
						for (;;)
						{
							IL_BA:
							if (flag2)
							{
								fmap[num12] = num13;
								if ((num12 -= num7) <= num8)
								{
									break;
								}
							}
							else
							{
								flag2 = true;
							}
							num13 = fmap[num12 - num7];
							int num14 = num13 + d;
							int num15 = num11;
							if (block[num14 + 1] == block[num15 + 1])
							{
								if (block[num14 + 2] == block[num15 + 2])
								{
									if (block[num14 + 3] == block[num15 + 3])
									{
										if (block[num14 + 4] == block[num15 + 4])
										{
											if (block[num14 + 5] == block[num15 + 5])
											{
												if (block[num14 += 6] == block[num15 += 6])
												{
													int j = num3;
													while (j > 0)
													{
														j -= 4;
														if (block[num14 + 1] == block[num15 + 1])
														{
															if (quadrant[num14] == quadrant[num15])
															{
																if (block[num14 + 2] == block[num15 + 2])
																{
																	if (quadrant[num14 + 1] == quadrant[num15 + 1])
																	{
																		if (block[num14 + 3] == block[num15 + 3])
																		{
																			if (quadrant[num14 + 2] == quadrant[num15 + 2])
																			{
																				if (block[num14 + 4] == block[num15 + 4])
																				{
																					if (quadrant[num14 + 3] == quadrant[num15 + 3])
																					{
																						if ((num14 += 4) >= num4)
																						{
																							num14 -= num4;
																						}
																						if ((num15 += 4) >= num4)
																						{
																							num15 -= num4;
																						}
																						num6++;
																					}
																					else
																					{
																						if (quadrant[num14 + 3] > quadrant[num15 + 3])
																						{
																							goto IL_BA;
																						}
																						break;
																					}
																				}
																				else
																				{
																					if ((block[num14 + 4] & 255) > (block[num15 + 4] & 255))
																					{
																						goto IL_BA;
																					}
																					break;
																				}
																			}
																			else
																			{
																				if (quadrant[num14 + 2] > quadrant[num15 + 2])
																				{
																					goto IL_BA;
																				}
																				break;
																			}
																		}
																		else
																		{
																			if ((block[num14 + 3] & 255) > (block[num15 + 3] & 255))
																			{
																				goto IL_BA;
																			}
																			break;
																		}
																	}
																	else
																	{
																		if (quadrant[num14 + 1] > quadrant[num15 + 1])
																		{
																			goto IL_BA;
																		}
																		break;
																	}
																}
																else
																{
																	if ((block[num14 + 2] & 255) > (block[num15 + 2] & 255))
																	{
																		goto IL_BA;
																	}
																	break;
																}
															}
															else
															{
																if (quadrant[num14] > quadrant[num15])
																{
																	goto IL_BA;
																}
																break;
															}
														}
														else
														{
															if ((block[num14 + 1] & 255) > (block[num15 + 1] & 255))
															{
																goto IL_BA;
															}
															break;
														}
													}
													break;
												}
												if ((block[num14] & 255) <= (block[num15] & 255))
												{
													break;
												}
											}
											else if ((block[num14 + 5] & 255) <= (block[num15 + 5] & 255))
											{
												break;
											}
										}
										else if ((block[num14 + 4] & 255) <= (block[num15 + 4] & 255))
										{
											break;
										}
									}
									else if ((block[num14 + 3] & 255) <= (block[num15 + 3] & 255))
									{
										break;
									}
								}
								else if ((block[num14 + 2] & 255) <= (block[num15 + 2] & 255))
								{
									break;
								}
							}
							else if ((block[num14 + 1] & 255) <= (block[num15 + 1] & 255))
							{
								break;
							}
						}
						IL_3FA:
						fmap[num12] = num10;
						i++;
						continue;
						goto IL_3FA;
					}
					if (flag && i <= hi && num6 > num5)
					{
						goto IL_446;
					}
				}
			}
			IL_446:
			this.workDone = num6;
			return flag && num6 > num5;
		}

		// Token: 0x06002F31 RID: 12081 RVA: 0x000A6104 File Offset: 0x000A4304
		private static void vswap(int[] fmap, int p1, int p2, int n)
		{
			n += p1;
			while (p1 < n)
			{
				int num = fmap[p1];
				fmap[p1++] = fmap[p2];
				fmap[p2++] = num;
			}
		}

		// Token: 0x06002F32 RID: 12082 RVA: 0x000A613C File Offset: 0x000A433C
		private static byte med3(byte a, byte b, byte c)
		{
			if (a >= b)
			{
				if (b > c)
				{
					return b;
				}
				if (a <= c)
				{
					return a;
				}
				return c;
			}
			else
			{
				if (b < c)
				{
					return b;
				}
				if (a >= c)
				{
					return a;
				}
				return c;
			}
		}

		// Token: 0x06002F33 RID: 12083 RVA: 0x000A616C File Offset: 0x000A436C
		private void mainQSort3(global::Ionic.BZip2.BZip2Compressor.CompressionState dataShadow, int loSt, int hiSt, int dSt)
		{
			int[] stack_ll = dataShadow.stack_ll;
			int[] stack_hh = dataShadow.stack_hh;
			int[] stack_dd = dataShadow.stack_dd;
			int[] fmap = dataShadow.fmap;
			byte[] block = dataShadow.block;
			stack_ll[0] = loSt;
			stack_hh[0] = hiSt;
			stack_dd[0] = dSt;
			int num = 1;
			while (--num >= 0)
			{
				int num2 = stack_ll[num];
				int num3 = stack_hh[num];
				int num4 = stack_dd[num];
				if (num3 - num2 < global::Ionic.BZip2.BZip2Compressor.SMALL_THRESH || num4 > global::Ionic.BZip2.BZip2Compressor.DEPTH_THRESH)
				{
					if (this.mainSimpleSort(dataShadow, num2, num3, num4))
					{
						return;
					}
				}
				else
				{
					int num5 = num4 + 1;
					int num6 = (int)(global::Ionic.BZip2.BZip2Compressor.med3(block[fmap[num2] + num5], block[fmap[num3] + num5], block[fmap[num2 + num3 >> 1] + num5]) & byte.MaxValue);
					int i = num2;
					int num7 = num3;
					int num8 = num2;
					int num9 = num3;
					for (;;)
					{
						if (i <= num7)
						{
							int num10 = (int)(block[fmap[i] + num5] & byte.MaxValue) - num6;
							if (num10 == 0)
							{
								int num11 = fmap[i];
								fmap[i++] = fmap[num8];
								fmap[num8++] = num11;
								continue;
							}
							if (num10 < 0)
							{
								i++;
								continue;
							}
						}
						while (i <= num7)
						{
							int num12 = (int)(block[fmap[num7] + num5] & byte.MaxValue) - num6;
							if (num12 == 0)
							{
								int num13 = fmap[num7];
								fmap[num7--] = fmap[num9];
								fmap[num9--] = num13;
							}
							else
							{
								if (num12 <= 0)
								{
									break;
								}
								num7--;
							}
						}
						if (i > num7)
						{
							break;
						}
						int num14 = fmap[i];
						fmap[i++] = fmap[num7];
						fmap[num7--] = num14;
					}
					if (num9 < num8)
					{
						stack_ll[num] = num2;
						stack_hh[num] = num3;
						stack_dd[num] = num5;
						num++;
					}
					else
					{
						int num15 = (num8 - num2 < i - num8) ? (num8 - num2) : (i - num8);
						global::Ionic.BZip2.BZip2Compressor.vswap(fmap, num2, i - num15, num15);
						int num16 = (num3 - num9 < num9 - num7) ? (num3 - num9) : (num9 - num7);
						global::Ionic.BZip2.BZip2Compressor.vswap(fmap, i, num3 - num16 + 1, num16);
						num15 = num2 + i - num8 - 1;
						num16 = num3 - (num9 - num7) + 1;
						stack_ll[num] = num2;
						stack_hh[num] = num15;
						stack_dd[num] = num4;
						num++;
						stack_ll[num] = num15 + 1;
						stack_hh[num] = num16 - 1;
						stack_dd[num] = num5;
						num++;
						stack_ll[num] = num16;
						stack_hh[num] = num3;
						stack_dd[num] = num4;
						num++;
					}
				}
			}
		}

		// Token: 0x06002F34 RID: 12084 RVA: 0x000A6410 File Offset: 0x000A4610
		private void generateMTFValues()
		{
			int num = this.last;
			global::Ionic.BZip2.BZip2Compressor.CompressionState compressionState = this.cstate;
			bool[] inUse = compressionState.inUse;
			byte[] block = compressionState.block;
			int[] fmap = compressionState.fmap;
			char[] sfmap = compressionState.sfmap;
			int[] mtfFreq = compressionState.mtfFreq;
			byte[] unseqToSeq = compressionState.unseqToSeq;
			byte[] generateMTFValues_yy = compressionState.generateMTFValues_yy;
			int num2 = 0;
			for (int i = 0; i < 256; i++)
			{
				if (inUse[i])
				{
					unseqToSeq[i] = (byte)num2;
					num2++;
				}
			}
			this.nInUse = num2;
			int num3 = num2 + 1;
			for (int j = num3; j >= 0; j--)
			{
				mtfFreq[j] = 0;
			}
			int num4 = num2;
			while (--num4 >= 0)
			{
				generateMTFValues_yy[num4] = (byte)num4;
			}
			int num5 = 0;
			int num6 = 0;
			for (int k = 0; k <= num; k++)
			{
				byte b = unseqToSeq[(int)(block[fmap[k]] & byte.MaxValue)];
				byte b2 = generateMTFValues_yy[0];
				int num7 = 0;
				while (b != b2)
				{
					num7++;
					byte b3 = b2;
					b2 = generateMTFValues_yy[num7];
					generateMTFValues_yy[num7] = b3;
				}
				generateMTFValues_yy[0] = b2;
				if (num7 == 0)
				{
					num6++;
				}
				else
				{
					if (num6 > 0)
					{
						num6--;
						for (;;)
						{
							if ((num6 & 1) == 0)
							{
								sfmap[num5] = global::Ionic.BZip2.BZip2.RUNA;
								num5++;
								mtfFreq[(int)global::Ionic.BZip2.BZip2.RUNA]++;
							}
							else
							{
								sfmap[num5] = global::Ionic.BZip2.BZip2.RUNB;
								num5++;
								mtfFreq[(int)global::Ionic.BZip2.BZip2.RUNB]++;
							}
							if (num6 < 2)
							{
								break;
							}
							num6 = num6 - 2 >> 1;
						}
						num6 = 0;
					}
					sfmap[num5] = (char)(num7 + 1);
					num5++;
					mtfFreq[num7 + 1]++;
				}
			}
			if (num6 > 0)
			{
				num6--;
				for (;;)
				{
					if ((num6 & 1) == 0)
					{
						sfmap[num5] = global::Ionic.BZip2.BZip2.RUNA;
						num5++;
						mtfFreq[(int)global::Ionic.BZip2.BZip2.RUNA]++;
					}
					else
					{
						sfmap[num5] = global::Ionic.BZip2.BZip2.RUNB;
						num5++;
						mtfFreq[(int)global::Ionic.BZip2.BZip2.RUNB]++;
					}
					if (num6 < 2)
					{
						break;
					}
					num6 = num6 - 2 >> 1;
				}
			}
			sfmap[num5] = (char)num3;
			mtfFreq[num3]++;
			this.nMTF = num5 + 1;
		}

		// Token: 0x06002F35 RID: 12085 RVA: 0x000A666C File Offset: 0x000A486C
		private static void hbAssignCodes(int[] code, byte[] length, int minLen, int maxLen, int alphaSize)
		{
			int num = 0;
			for (int i = minLen; i <= maxLen; i++)
			{
				for (int j = 0; j < alphaSize; j++)
				{
					if ((int)(length[j] & 255) == i)
					{
						code[j] = num;
						num++;
					}
				}
				num <<= 1;
			}
		}

		// Token: 0x06002F36 RID: 12086 RVA: 0x000A66BC File Offset: 0x000A48BC
		private void sendMTFValues()
		{
			byte[][] sendMTFValues_len = this.cstate.sendMTFValues_len;
			int num = this.nInUse + 2;
			int num2 = global::Ionic.BZip2.BZip2.NGroups;
			while (--num2 >= 0)
			{
				byte[] array = sendMTFValues_len[num2];
				int num3 = num;
				while (--num3 >= 0)
				{
					array[num3] = global::Ionic.BZip2.BZip2Compressor.GREATER_ICOST;
				}
			}
			int nGroups = (this.nMTF < 200) ? 2 : ((this.nMTF < 600) ? 3 : ((this.nMTF < 1200) ? 4 : ((this.nMTF < 2400) ? 5 : 6)));
			this.sendMTFValues0(nGroups, num);
			int nSelectors = this.sendMTFValues1(nGroups, num);
			this.sendMTFValues2(nGroups, nSelectors);
			this.sendMTFValues3(nGroups, num);
			this.sendMTFValues4();
			this.sendMTFValues5(nGroups, nSelectors);
			this.sendMTFValues6(nGroups, num);
			this.sendMTFValues7(nSelectors);
		}

		// Token: 0x06002F37 RID: 12087 RVA: 0x000A67BC File Offset: 0x000A49BC
		private void sendMTFValues0(int nGroups, int alphaSize)
		{
			byte[][] sendMTFValues_len = this.cstate.sendMTFValues_len;
			int[] mtfFreq = this.cstate.mtfFreq;
			int num = this.nMTF;
			int num2 = 0;
			for (int i = nGroups; i > 0; i--)
			{
				int num3 = num / i;
				int num4 = num2 - 1;
				int num5 = 0;
				int num6 = alphaSize - 1;
				while (num5 < num3 && num4 < num6)
				{
					num5 += mtfFreq[++num4];
				}
				if (num4 > num2 && i != nGroups && i != 1 && (nGroups - i & 1) != 0)
				{
					num5 -= mtfFreq[num4--];
				}
				byte[] array = sendMTFValues_len[i - 1];
				int num7 = alphaSize;
				while (--num7 >= 0)
				{
					if (num7 >= num2 && num7 <= num4)
					{
						array[num7] = global::Ionic.BZip2.BZip2Compressor.LESSER_ICOST;
					}
					else
					{
						array[num7] = global::Ionic.BZip2.BZip2Compressor.GREATER_ICOST;
					}
				}
				num2 = num4 + 1;
				num -= num5;
			}
		}

		// Token: 0x06002F38 RID: 12088 RVA: 0x000A68BC File Offset: 0x000A4ABC
		private static void hbMakeCodeLengths(byte[] len, int[] freq, global::Ionic.BZip2.BZip2Compressor.CompressionState state1, int alphaSize, int maxLen)
		{
			int[] heap = state1.heap;
			int[] weight = state1.weight;
			int[] parent = state1.parent;
			int num = alphaSize;
			while (--num >= 0)
			{
				weight[num + 1] = ((freq[num] == 0) ? 1 : freq[num]) << 8;
			}
			bool flag = true;
			while (flag)
			{
				flag = false;
				int num2 = alphaSize;
				int i = 0;
				heap[0] = 0;
				weight[0] = 0;
				parent[0] = -2;
				for (int j = 1; j <= alphaSize; j++)
				{
					parent[j] = -1;
					i++;
					heap[i] = j;
					int num3 = i;
					int num4 = heap[num3];
					while (weight[num4] < weight[heap[num3 >> 1]])
					{
						heap[num3] = heap[num3 >> 1];
						num3 >>= 1;
					}
					heap[num3] = num4;
				}
				while (i > 1)
				{
					int num5 = heap[1];
					heap[1] = heap[i];
					i--;
					int num6 = 1;
					int num7 = heap[1];
					for (;;)
					{
						int num8 = num6 << 1;
						if (num8 > i)
						{
							break;
						}
						if (num8 < i && weight[heap[num8 + 1]] < weight[heap[num8]])
						{
							num8++;
						}
						if (weight[num7] < weight[heap[num8]])
						{
							break;
						}
						heap[num6] = heap[num8];
						num6 = num8;
					}
					heap[num6] = num7;
					int num9 = heap[1];
					heap[1] = heap[i];
					i--;
					num6 = 1;
					num7 = heap[1];
					for (;;)
					{
						int num8 = num6 << 1;
						if (num8 > i)
						{
							break;
						}
						if (num8 < i && weight[heap[num8 + 1]] < weight[heap[num8]])
						{
							num8++;
						}
						if (weight[num7] < weight[heap[num8]])
						{
							break;
						}
						heap[num6] = heap[num8];
						num6 = num8;
					}
					heap[num6] = num7;
					num2++;
					parent[num5] = (parent[num9] = num2);
					int num10 = weight[num5];
					int num11 = weight[num9];
					weight[num2] = ((num10 & -256) + (num11 & -256) | 1 + (((num10 & 255) > (num11 & 255)) ? (num10 & 255) : (num11 & 255)));
					parent[num2] = -1;
					i++;
					heap[i] = num2;
					num6 = i;
					num7 = heap[num6];
					int k = weight[num7];
					while (k < weight[heap[num6 >> 1]])
					{
						heap[num6] = heap[num6 >> 1];
						num6 >>= 1;
					}
					heap[num6] = num7;
				}
				for (int l = 1; l <= alphaSize; l++)
				{
					int num12 = 0;
					int num13 = l;
					int num14;
					while ((num14 = parent[num13]) >= 0)
					{
						num13 = num14;
						num12++;
					}
					len[l - 1] = (byte)num12;
					if (num12 > maxLen)
					{
						flag = true;
					}
				}
				if (flag)
				{
					for (int m = 1; m < alphaSize; m++)
					{
						int num15 = weight[m] >> 8;
						num15 = 1 + (num15 >> 1);
						weight[m] = num15 << 8;
					}
				}
			}
		}

		// Token: 0x06002F39 RID: 12089 RVA: 0x000A6B9C File Offset: 0x000A4D9C
		private int sendMTFValues1(int nGroups, int alphaSize)
		{
			global::Ionic.BZip2.BZip2Compressor.CompressionState compressionState = this.cstate;
			int[][] sendMTFValues_rfreq = compressionState.sendMTFValues_rfreq;
			int[] sendMTFValues_fave = compressionState.sendMTFValues_fave;
			short[] sendMTFValues_cost = compressionState.sendMTFValues_cost;
			char[] sfmap = compressionState.sfmap;
			byte[] selector = compressionState.selector;
			byte[][] sendMTFValues_len = compressionState.sendMTFValues_len;
			byte[] array = sendMTFValues_len[0];
			byte[] array2 = sendMTFValues_len[1];
			byte[] array3 = sendMTFValues_len[2];
			byte[] array4 = sendMTFValues_len[3];
			byte[] array5 = sendMTFValues_len[4];
			byte[] array6 = sendMTFValues_len[5];
			int num = this.nMTF;
			int num2 = 0;
			for (int i = 0; i < global::Ionic.BZip2.BZip2.N_ITERS; i++)
			{
				int num3 = nGroups;
				while (--num3 >= 0)
				{
					sendMTFValues_fave[num3] = 0;
					int[] array7 = sendMTFValues_rfreq[num3];
					int num4 = alphaSize;
					while (--num4 >= 0)
					{
						array7[num4] = 0;
					}
				}
				num2 = 0;
				int num5;
				for (int j = 0; j < this.nMTF; j = num5 + 1)
				{
					num5 = global::System.Math.Min(j + global::Ionic.BZip2.BZip2.G_SIZE - 1, num - 1);
					if (nGroups == global::Ionic.BZip2.BZip2.NGroups)
					{
						int[] array8 = new int[6];
						for (int k = j; k <= num5; k++)
						{
							int num6 = (int)sfmap[k];
							array8[0] += (int)(array[num6] & byte.MaxValue);
							array8[1] += (int)(array2[num6] & byte.MaxValue);
							array8[2] += (int)(array3[num6] & byte.MaxValue);
							array8[3] += (int)(array4[num6] & byte.MaxValue);
							array8[4] += (int)(array5[num6] & byte.MaxValue);
							array8[5] += (int)(array6[num6] & byte.MaxValue);
						}
						sendMTFValues_cost[0] = (short)array8[0];
						sendMTFValues_cost[1] = (short)array8[1];
						sendMTFValues_cost[2] = (short)array8[2];
						sendMTFValues_cost[3] = (short)array8[3];
						sendMTFValues_cost[4] = (short)array8[4];
						sendMTFValues_cost[5] = (short)array8[5];
					}
					else
					{
						int num7 = nGroups;
						while (--num7 >= 0)
						{
							sendMTFValues_cost[num7] = 0;
						}
						for (int l = j; l <= num5; l++)
						{
							int num8 = (int)sfmap[l];
							int num9 = nGroups;
							while (--num9 >= 0)
							{
								short[] array9 = sendMTFValues_cost;
								int num10 = num9;
								array9[num10] += (short)(sendMTFValues_len[num9][num8] & byte.MaxValue);
							}
						}
					}
					int num11 = -1;
					int num12 = nGroups;
					int num13 = 999999999;
					while (--num12 >= 0)
					{
						int num14 = (int)sendMTFValues_cost[num12];
						if (num14 < num13)
						{
							num13 = num14;
							num11 = num12;
						}
					}
					sendMTFValues_fave[num11]++;
					selector[num2] = (byte)num11;
					num2++;
					int[] array10 = sendMTFValues_rfreq[num11];
					for (int m = j; m <= num5; m++)
					{
						array10[(int)sfmap[m]]++;
					}
				}
				for (int n = 0; n < nGroups; n++)
				{
					global::Ionic.BZip2.BZip2Compressor.hbMakeCodeLengths(sendMTFValues_len[n], sendMTFValues_rfreq[n], this.cstate, alphaSize, 20);
				}
			}
			return num2;
		}

		// Token: 0x06002F3A RID: 12090 RVA: 0x000A6EB0 File Offset: 0x000A50B0
		private void sendMTFValues2(int nGroups, int nSelectors)
		{
			global::Ionic.BZip2.BZip2Compressor.CompressionState compressionState = this.cstate;
			byte[] sendMTFValues2_pos = compressionState.sendMTFValues2_pos;
			int num = nGroups;
			while (--num >= 0)
			{
				sendMTFValues2_pos[num] = (byte)num;
			}
			for (int i = 0; i < nSelectors; i++)
			{
				byte b = compressionState.selector[i];
				byte b2 = sendMTFValues2_pos[0];
				int num2 = 0;
				while (b != b2)
				{
					num2++;
					byte b3 = b2;
					b2 = sendMTFValues2_pos[num2];
					sendMTFValues2_pos[num2] = b3;
				}
				sendMTFValues2_pos[0] = b2;
				compressionState.selectorMtf[i] = (byte)num2;
			}
		}

		// Token: 0x06002F3B RID: 12091 RVA: 0x000A6F38 File Offset: 0x000A5138
		private void sendMTFValues3(int nGroups, int alphaSize)
		{
			int[][] sendMTFValues_code = this.cstate.sendMTFValues_code;
			byte[][] sendMTFValues_len = this.cstate.sendMTFValues_len;
			for (int i = 0; i < nGroups; i++)
			{
				int num = 32;
				int num2 = 0;
				byte[] array = sendMTFValues_len[i];
				int num3 = alphaSize;
				while (--num3 >= 0)
				{
					int num4 = (int)(array[num3] & byte.MaxValue);
					if (num4 > num2)
					{
						num2 = num4;
					}
					if (num4 < num)
					{
						num = num4;
					}
				}
				global::Ionic.BZip2.BZip2Compressor.hbAssignCodes(sendMTFValues_code[i], sendMTFValues_len[i], num, num2, alphaSize);
			}
		}

		// Token: 0x06002F3C RID: 12092 RVA: 0x000A6FD0 File Offset: 0x000A51D0
		private void sendMTFValues4()
		{
			bool[] inUse = this.cstate.inUse;
			bool[] sentMTFValues4_inUse = this.cstate.sentMTFValues4_inUse16;
			int num = 16;
			while (--num >= 0)
			{
				sentMTFValues4_inUse[num] = false;
				int num2 = num * 16;
				int num3 = 16;
				while (--num3 >= 0)
				{
					if (inUse[num2 + num3])
					{
						sentMTFValues4_inUse[num] = true;
					}
				}
			}
			uint num4 = 0U;
			for (int i = 0; i < 16; i++)
			{
				if (sentMTFValues4_inUse[i])
				{
					num4 |= 1U << 16 - i - 1;
				}
			}
			this.bw.WriteBits(16, num4);
			for (int j = 0; j < 16; j++)
			{
				if (sentMTFValues4_inUse[j])
				{
					int num5 = j * 16;
					num4 = 0U;
					for (int k = 0; k < 16; k++)
					{
						if (inUse[num5 + k])
						{
							num4 |= 1U << 16 - k - 1;
						}
					}
					this.bw.WriteBits(16, num4);
				}
			}
		}

		// Token: 0x06002F3D RID: 12093 RVA: 0x000A70DC File Offset: 0x000A52DC
		private void sendMTFValues5(int nGroups, int nSelectors)
		{
			this.bw.WriteBits(3, (uint)nGroups);
			this.bw.WriteBits(15, (uint)nSelectors);
			byte[] selectorMtf = this.cstate.selectorMtf;
			for (int i = 0; i < nSelectors; i++)
			{
				int j = 0;
				int num = (int)(selectorMtf[i] & byte.MaxValue);
				while (j < num)
				{
					this.bw.WriteBits(1, 1U);
					j++;
				}
				this.bw.WriteBits(1, 0U);
			}
		}

		// Token: 0x06002F3E RID: 12094 RVA: 0x000A7158 File Offset: 0x000A5358
		private void sendMTFValues6(int nGroups, int alphaSize)
		{
			byte[][] sendMTFValues_len = this.cstate.sendMTFValues_len;
			for (int i = 0; i < nGroups; i++)
			{
				byte[] array = sendMTFValues_len[i];
				uint num = (uint)(array[0] & byte.MaxValue);
				this.bw.WriteBits(5, num);
				for (int j = 0; j < alphaSize; j++)
				{
					int num2 = (int)(array[j] & byte.MaxValue);
					while ((ulong)num < (ulong)((long)num2))
					{
						this.bw.WriteBits(2, 2U);
						num += 1U;
					}
					while ((ulong)num > (ulong)((long)num2))
					{
						this.bw.WriteBits(2, 3U);
						num -= 1U;
					}
					this.bw.WriteBits(1, 0U);
				}
			}
		}

		// Token: 0x06002F3F RID: 12095 RVA: 0x000A720C File Offset: 0x000A540C
		private void sendMTFValues7(int nSelectors)
		{
			byte[][] sendMTFValues_len = this.cstate.sendMTFValues_len;
			int[][] sendMTFValues_code = this.cstate.sendMTFValues_code;
			byte[] selector = this.cstate.selector;
			char[] sfmap = this.cstate.sfmap;
			int num = this.nMTF;
			int num2 = 0;
			int i = 0;
			while (i < num)
			{
				int num3 = global::System.Math.Min(i + global::Ionic.BZip2.BZip2.G_SIZE - 1, num - 1);
				int num4 = (int)(selector[num2] & byte.MaxValue);
				int[] array = sendMTFValues_code[num4];
				byte[] array2 = sendMTFValues_len[num4];
				while (i <= num3)
				{
					int num5 = (int)sfmap[i];
					int nbits = (int)(array2[num5] & byte.MaxValue);
					this.bw.WriteBits(nbits, (uint)array[num5]);
					i++;
				}
				i = num3 + 1;
				num2++;
			}
		}

		// Token: 0x06002F40 RID: 12096 RVA: 0x000A72E0 File Offset: 0x000A54E0
		private void moveToFrontCodeAndSend()
		{
			this.bw.WriteBits(24, (uint)this.origPtr);
			this.generateMTFValues();
			this.sendMTFValues();
		}

		// Token: 0x040010E6 RID: 4326
		private int blockSize100k;

		// Token: 0x040010E7 RID: 4327
		private int currentByte = -1;

		// Token: 0x040010E8 RID: 4328
		private int runLength;

		// Token: 0x040010E9 RID: 4329
		private int last;

		// Token: 0x040010EA RID: 4330
		private int outBlockFillThreshold;

		// Token: 0x040010EB RID: 4331
		private global::Ionic.BZip2.BZip2Compressor.CompressionState cstate;

		// Token: 0x040010EC RID: 4332
		private readonly global::Ionic.Crc.CRC32 crc = new global::Ionic.Crc.CRC32(true);

		// Token: 0x040010ED RID: 4333
		private global::Ionic.BZip2.BitWriter bw;

		// Token: 0x040010EE RID: 4334
		private int runs;

		// Token: 0x040010EF RID: 4335
		private int workDone;

		// Token: 0x040010F0 RID: 4336
		private int workLimit;

		// Token: 0x040010F1 RID: 4337
		private bool firstAttempt;

		// Token: 0x040010F2 RID: 4338
		private bool blockRandomised;

		// Token: 0x040010F3 RID: 4339
		private int origPtr;

		// Token: 0x040010F4 RID: 4340
		private int nInUse;

		// Token: 0x040010F5 RID: 4341
		private int nMTF;

		// Token: 0x040010F6 RID: 4342
		private static readonly int SETMASK = 2097152;

		// Token: 0x040010F7 RID: 4343
		private static readonly int CLEARMASK = ~global::Ionic.BZip2.BZip2Compressor.SETMASK;

		// Token: 0x040010F8 RID: 4344
		private static readonly byte GREATER_ICOST = 15;

		// Token: 0x040010F9 RID: 4345
		private static readonly byte LESSER_ICOST = 0;

		// Token: 0x040010FA RID: 4346
		private static readonly int SMALL_THRESH = 20;

		// Token: 0x040010FB RID: 4347
		private static readonly int DEPTH_THRESH = 10;

		// Token: 0x040010FC RID: 4348
		private static readonly int WORK_FACTOR = 30;

		// Token: 0x040010FD RID: 4349
		private static readonly int[] increments = new int[]
		{
			1,
			4,
			13,
			40,
			121,
			364,
			1093,
			3280,
			9841,
			29524,
			88573,
			265720,
			797161,
			2391484
		};

		// Token: 0x020004E1 RID: 1249
		private class CompressionState
		{
			// Token: 0x0600347C RID: 13436 RVA: 0x000BCA4C File Offset: 0x000BAC4C
			public CompressionState(int blockSize100k)
			{
				int num = blockSize100k * global::Ionic.BZip2.BZip2.BlockSizeMultiple;
				this.block = new byte[num + 1 + global::Ionic.BZip2.BZip2.NUM_OVERSHOOT_BYTES];
				this.fmap = new int[num];
				this.sfmap = new char[2 * num];
				this.quadrant = this.sfmap;
				this.sendMTFValues_len = global::Ionic.BZip2.BZip2.InitRectangularArray<byte>(global::Ionic.BZip2.BZip2.NGroups, global::Ionic.BZip2.BZip2.MaxAlphaSize);
				this.sendMTFValues_rfreq = global::Ionic.BZip2.BZip2.InitRectangularArray<int>(global::Ionic.BZip2.BZip2.NGroups, global::Ionic.BZip2.BZip2.MaxAlphaSize);
				this.sendMTFValues_code = global::Ionic.BZip2.BZip2.InitRectangularArray<int>(global::Ionic.BZip2.BZip2.NGroups, global::Ionic.BZip2.BZip2.MaxAlphaSize);
			}

			// Token: 0x04001423 RID: 5155
			public readonly bool[] inUse = new bool[256];

			// Token: 0x04001424 RID: 5156
			public readonly byte[] unseqToSeq = new byte[256];

			// Token: 0x04001425 RID: 5157
			public readonly int[] mtfFreq = new int[global::Ionic.BZip2.BZip2.MaxAlphaSize];

			// Token: 0x04001426 RID: 5158
			public readonly byte[] selector = new byte[global::Ionic.BZip2.BZip2.MaxSelectors];

			// Token: 0x04001427 RID: 5159
			public readonly byte[] selectorMtf = new byte[global::Ionic.BZip2.BZip2.MaxSelectors];

			// Token: 0x04001428 RID: 5160
			public readonly byte[] generateMTFValues_yy = new byte[256];

			// Token: 0x04001429 RID: 5161
			public byte[][] sendMTFValues_len;

			// Token: 0x0400142A RID: 5162
			public int[][] sendMTFValues_rfreq;

			// Token: 0x0400142B RID: 5163
			public readonly int[] sendMTFValues_fave = new int[global::Ionic.BZip2.BZip2.NGroups];

			// Token: 0x0400142C RID: 5164
			public readonly short[] sendMTFValues_cost = new short[global::Ionic.BZip2.BZip2.NGroups];

			// Token: 0x0400142D RID: 5165
			public int[][] sendMTFValues_code;

			// Token: 0x0400142E RID: 5166
			public readonly byte[] sendMTFValues2_pos = new byte[global::Ionic.BZip2.BZip2.NGroups];

			// Token: 0x0400142F RID: 5167
			public readonly bool[] sentMTFValues4_inUse16 = new bool[16];

			// Token: 0x04001430 RID: 5168
			public readonly int[] stack_ll = new int[global::Ionic.BZip2.BZip2.QSORT_STACK_SIZE];

			// Token: 0x04001431 RID: 5169
			public readonly int[] stack_hh = new int[global::Ionic.BZip2.BZip2.QSORT_STACK_SIZE];

			// Token: 0x04001432 RID: 5170
			public readonly int[] stack_dd = new int[global::Ionic.BZip2.BZip2.QSORT_STACK_SIZE];

			// Token: 0x04001433 RID: 5171
			public readonly int[] mainSort_runningOrder = new int[256];

			// Token: 0x04001434 RID: 5172
			public readonly int[] mainSort_copy = new int[256];

			// Token: 0x04001435 RID: 5173
			public readonly bool[] mainSort_bigDone = new bool[256];

			// Token: 0x04001436 RID: 5174
			public int[] heap = new int[global::Ionic.BZip2.BZip2.MaxAlphaSize + 2];

			// Token: 0x04001437 RID: 5175
			public int[] weight = new int[global::Ionic.BZip2.BZip2.MaxAlphaSize * 2];

			// Token: 0x04001438 RID: 5176
			public int[] parent = new int[global::Ionic.BZip2.BZip2.MaxAlphaSize * 2];

			// Token: 0x04001439 RID: 5177
			public readonly int[] ftab = new int[65537];

			// Token: 0x0400143A RID: 5178
			public byte[] block;

			// Token: 0x0400143B RID: 5179
			public int[] fmap;

			// Token: 0x0400143C RID: 5180
			public char[] sfmap;

			// Token: 0x0400143D RID: 5181
			public char[] quadrant;
		}
	}
}
