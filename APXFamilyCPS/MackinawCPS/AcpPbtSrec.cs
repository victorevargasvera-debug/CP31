using System;
using System.Globalization;
using System.IO;
using System.Text;
using System.Threading;
using PbtSrec;
using PreEmptive.SoS.Runtime;

namespace MackinawCPS
{
	// Token: 0x0200004A RID: 74
	public class AcpPbtSrec
	{
		// Token: 0x0600020F RID: 527 RVA: 0x00062F00 File Offset: 0x00061100
		internal bool ConvertPBTFileToSrec(string pbtFileName, string configFileName)
		{
			short num = (short)1359151104;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)228688458;
				short num3 = num;
				num = (short)161448522;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)740360192;
					short num4 = num;
					num = (short)1748566016;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_BA;
					}
					break;
				}
				}
				bool result;
				for (;;)
				{
					IL_9B:
					switch (num2)
					{
					case 0:
						if (global::System.IO.File.Exists(pbtFileName))
						{
							num = (short)1658519553;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 1:
						goto IL_17A;
					case 2:
						if (global::System.IO.File.Exists(configFileName))
						{
							num = (short)484311045;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 3:
					{
						int num5;
						try
						{
							object obj;
							bool flag;
							global::System.Threading.Monitor.Enter(obj, ref flag);
							num5 = global::PbtSrec.PbtSrecWrapper.PBTMain2(configFileName, pbtFileName, 3U);
							goto IL_1B9;
						}
						finally
						{
							num = (short)667090944;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_141;
									}
									continue;
								case 1:
									goto IL_177;
								case 2:
								{
									object obj;
									global::System.Threading.Monitor.Exit(obj);
									num = (short)388825089;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_141:
								bool flag;
								if (!flag)
								{
									break;
								}
								num = (short)1961623554;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_177:;
						}
						goto IL_17A;
						IL_1B9:
						result = (num5 == 0);
						num = (short)26607620;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						return result;
					case 5:
					{
						num = (short)1821114369;
						if (num != 0)
						{
						}
						object obj = global::MackinawCPS.AcpPbtSrec.pbtSrecLibLock;
						bool flag = false;
						num = (short)171638787;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_BA;
					IL_17A:
					num = (short)682164226;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_BA:
				result = false;
				num = (short)1777664000;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_9B;
			}
			}
		}

		// Token: 0x06000210 RID: 528 RVA: 0x00063144 File Offset: 0x00061344
		internal bool GeneratePBTFromPackedImage(byte[] packedDataArr, string pbtFileName)
		{
			short num = (short)776536064;
			short num2 = num;
			num = (short)1303279326;
			short num3 = num;
			num = (short)1165850334;
			bool result;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)293601281;
				if (num != 0)
				{
				}
				num = (short)1518272512;
				if (num != 0)
				{
				}
				num = (short)602013696;
				int num4 = (int)num;
				switch (num4)
				{
				default:
				{
					result = false;
					bool flag = false;
					global::System.IO.FileStream fileStream = null;
					global::System.IO.BinaryWriter binaryWriter = null;
					try
					{
						switch (0)
						{
						case 0:
							goto IL_138;
						}
						for (;;)
						{
							IL_CD:
							uint num5;
							char[] array;
							ushort twoByteVal3;
							switch (num4)
							{
							case 0:
								if (packedDataArr != null)
								{
									num = (short)756350989;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_4B3;
							case 1:
								if (!flag)
								{
									num = (short)47120408;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_4B3;
							case 2:
								if (binaryWriter != null)
								{
									num = (short)1924399124;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_4B3;
							case 3:
								flag = true;
								num = (short)1293942793;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
								goto IL_2C4;
							case 5:
								goto IL_1A6;
							case 6:
							{
								int length;
								if ((ulong)num5 >= (ulong)((long)length))
								{
									num = (short)2072903684;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								ushort twoByteVal = this.GetTwoByteVal(packedDataArr, num5);
								num5 += 2U;
								num = (short)1083506709;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 7:
								goto IL_4B3;
							case 8:
								if (fileStream != null)
								{
									num = (short)1073872910;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_4B3;
							case 9:
								goto IL_2C4;
							case 10:
								if (packedDataArr.GetLength(0) > 0)
								{
									num = (short)1322123282;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_4B3;
							case 11:
								flag = true;
								num = (short)1157365775;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 12:
								goto IL_1A6;
							case 13:
								num = (short)1913454602;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 14:
								binaryWriter = new global::System.IO.BinaryWriter(fileStream, global::System.Text.Encoding.UTF8);
								num = (short)2019295234;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 15:
								goto IL_2C4;
							case 16:
								goto IL_4CB;
							case 17:
								goto IL_303;
							case 18:
							{
								int length = packedDataArr.GetLength(0);
								num5 = 0U;
								num = (short)583532549;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 19:
							{
								if (array.Length == 0)
								{
									num = (short)1042808843;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								int num6 = global::System.Array.FindIndex<char>(array, new global::System.Predicate<char>(global::MackinawCPS.AcpPbtSrec.IsNulChar));
								num = (short)1267269654;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 20:
								num = (short)638189568;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 21:
							{
								ushort twoByteVal;
								if (twoByteVal == 0)
								{
									num = (short)315621379;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								ushort twoByteVal2 = this.GetTwoByteVal(packedDataArr, num5);
								num5 += 2U;
								twoByteVal3 = this.GetTwoByteVal(packedDataArr, num5);
								num5 += 2U;
								array = new char[this.CalculateIshItemPbtSize(twoByteVal3)];
								this.CreateIshItemPbtArray(ref array, packedDataArr, twoByteVal, twoByteVal2, twoByteVal3, num5);
								num = (short)409337875;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 22:
							{
								int num6;
								if (num6 > 0)
								{
									num = (short)508690455;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_303;
							}
							case 23:
							{
								int num6;
								global::System.Array.Resize<char>(ref array, num6);
								num = (short)242810897;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 24:
								result = true;
								num = (short)1992228871;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_138;
							IL_1A6:
							num = (short)1658388486;
							num4 = (int)((global::System.IntPtr)num);
							continue;
							IL_2C4:
							num = (short)488701953;
							num4 = (int)((global::System.IntPtr)num);
							continue;
							IL_303:
							binaryWriter.Write(array);
							num5 += (uint)twoByteVal3;
							num = (short)1906704396;
							num4 = (int)((global::System.IntPtr)num);
							continue;
							IL_4B3:
							num = (short)1564016656;
							num4 = (int)((global::System.IntPtr)num);
						}
						IL_4CB:
						break;
						IL_138:
						fileStream = new global::System.IO.FileStream(pbtFileName, global::System.IO.FileMode.Append, global::System.IO.FileAccess.Write);
						num = (short)607977480;
						num4 = (int)((global::System.IntPtr)num);
						goto IL_CD;
					}
					finally
					{
						num = (short)1213530112;
						num4 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num4)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_4FF;
								}
								continue;
							case 1:
								goto IL_535;
							case 2:
								fileStream.Dispose();
								num = (short)465764353;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_4FF:
							if (fileStream == null)
							{
								break;
							}
							num = (short)10682370;
							num4 = (int)((global::System.IntPtr)num);
						}
						IL_535:;
					}
					break;
				}
				}
				break;
			}
			}
			return result;
		}

		// Token: 0x06000211 RID: 529 RVA: 0x000636A8 File Offset: 0x000618A8
		private static bool IsNulChar(char a)
		{
			short num = (short)1654325248;
			short num2 = num;
			num = (short)277549250;
			short num3 = num;
			num = (short)437653698;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)199360513;
				if (num != 0)
				{
				}
				num = (short)236716032;
				if (num != 0)
				{
				}
				if (a != '\0')
				{
					return false;
				}
				break;
			}
			return true;
		}

		// Token: 0x06000212 RID: 530 RVA: 0x00063758 File Offset: 0x00061958
		internal void GeneratePBTFromPackedImage(byte[] packedDataArr, ref byte[] pbtByteDataArr)
		{
			short num = (short)2129264640;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_97;
				}
				char[] array2;
				for (;;)
				{
					IL_28:
					int num4;
					switch (num2)
					{
					case 0:
					{
						ushort twoByteVal;
						if (twoByteVal == 0)
						{
							num = (short)1791229977;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						uint num3;
						ushort twoByteVal2 = this.GetTwoByteVal(packedDataArr, num3);
						num3 += 2U;
						ushort twoByteVal3 = this.GetTwoByteVal(packedDataArr, num3);
						num3 += 2U;
						char[] array = new char[this.CalculateIshItemPbtSize(twoByteVal3)];
						this.CreateIshItemPbtArray(ref array, packedDataArr, twoByteVal, twoByteVal2, twoByteVal3, num3);
						num = (short)13762580;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
					{
						int newSize;
						pbtByteDataArr[newSize++] = global::System.Convert.ToByte(array2[num4]);
						num = (short)1449721859;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_13F;
					case 3:
						goto IL_1F5;
					case 4:
						goto IL_297;
					case 5:
						num = (short)1836449816;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						if (array2[num4] != '\0')
						{
							num = (short)637730817;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1F5;
					case 7:
					{
						num = (short)1529833933;
						short num5 = num;
						num = (short)1857448397;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_30E;
						default:
							num = (short)2119434240;
							if (num != 0)
							{
							}
							if (array2 != null)
							{
								num = (short)1006698501;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						}
						break;
					}
					case 8:
						global::System.Array.Clear(pbtByteDataArr, 0, pbtByteDataArr.Length);
						global::System.Array.Resize<byte>(ref pbtByteDataArr, 0);
						global::System.Array.Clear(array2, 0, array2.Length);
						global::System.Array.Resize<char>(ref array2, 0);
						num = (short)1688403989;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						if (packedDataArr != null)
						{
							num = (short)2109800463;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_13F;
					case 10:
					{
						int newSize;
						global::System.Array.Resize<byte>(ref pbtByteDataArr, newSize);
						num = (short)844890123;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
						return;
					case 12:
					{
						num = (short)191365120;
						short num6 = num;
						goto IL_13F;
					}
					case 13:
						if (num4 >= array2.GetLength(0))
						{
							num = (short)1213661194;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)860684294;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
					{
						int length = packedDataArr.GetLength(0);
						uint num3 = 0U;
						num = (short)910491652;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 15:
						num = (short)1490354198;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						goto IL_34B;
					case 17:
					{
						global::System.Array.Resize<byte>(ref pbtByteDataArr, array2.GetLength(0));
						int newSize = 0;
						num4 = 0;
						num = (short)2133196816;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 18:
						goto IL_34B;
					case 19:
					{
						uint num3;
						int length;
						if ((ulong)num3 >= (ulong)((long)length))
						{
							num = (short)538181644;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						ushort twoByteVal = this.GetTwoByteVal(packedDataArr, num3);
						num3 += 2U;
						goto IL_30E;
					}
					case 20:
					{
						char[] array;
						if (array.Length == 0)
						{
							num = (short)1058406408;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int length2 = array2.GetLength(0);
						int newSize2 = array2.GetLength(0) + array.GetLength(0);
						global::System.Array.Resize<char>(ref array2, newSize2);
						array.CopyTo(array2, length2);
						uint num3;
						ushort twoByteVal3;
						num3 += (uint)twoByteVal3;
						num = (short)2102067223;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 21:
						goto IL_13F;
					case 22:
						if (packedDataArr.GetLength(0) > 0)
						{
							num = (short)2293774;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_13F;
					case 23:
						goto IL_297;
					case 24:
						if (array2.GetLength(0) > 0)
						{
							num = (short)1414266897;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 25:
						global::System.Array.Clear(array2, 0, array2.Length);
						global::System.Array.Resize<char>(ref array2, 0);
						num = (short)1816395778;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_97;
					IL_13F:
					num = (short)1793261575;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1F5:
					num4++;
					num = (short)216334354;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_297:
					num = (short)1012400147;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_30E:
					num = (short)742522880;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_34B:
					num = (short)512098317;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_97:
				num = (short)396230657;
				if (num != 0)
				{
				}
				array2 = new char[0];
				num = (short)1451687945;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06000213 RID: 531 RVA: 0x00063CB4 File Offset: 0x00061EB4
		private ushort GetTwoByteVal(byte[] data, uint index)
		{
			switch (0)
			{
			case 0:
				goto IL_44;
			}
			short num;
			int num3;
			ushort num5;
			for (;;)
			{
				IL_0A:
				num = (short)1446903808;
				short num2 = num;
				switch (num3)
				{
				case 0:
				{
					num = (short)1535180643;
					short num4 = num;
					num = (short)2108489571;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return num5;
					default:
						num = (short)303300609;
						if (num != 0)
						{
						}
						num = (short)480706560;
						if (num != 0)
						{
						}
						if ((long)data.GetLength(0) > (long)((ulong)(index + 1U)))
						{
							num = (short)128450561;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return num5;
					}
					break;
				}
				case 1:
					num5 = (ushort)data[(int)index];
					num5 = (ushort)(num5 << 8);
					num5 |= (ushort)data[(int)(index + 1U)];
					num = (short)1580204034;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					return num5;
				}
				goto IL_44;
			}
			return num5;
			IL_44:
			num5 = 0;
			num = (short)269418496;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x06000214 RID: 532 RVA: 0x00063DE0 File Offset: 0x00061FE0
		private uint CalculateIshItemPbtSize(ushort ishDataSize)
		{
			switch (0)
			{
			case 0:
				goto IL_44;
			}
			short num;
			int num3;
			uint num5;
			for (;;)
			{
				IL_0A:
				num = (short)1019674624;
				short num2 = num;
				switch (num3)
				{
				case 0:
				{
					num = (short)1972053474;
					short num4 = num;
					num = (short)673064418;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_10C;
					default:
						num = (short)61734912;
						if (num != 0)
						{
						}
						if (ishDataSize % 28 != 0)
						{
							num = (short)1088946177;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_10C;
					}
					break;
				}
				case 1:
					num5 += 1U;
					num = (short)900857858;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_10A;
				}
				goto IL_44;
			}
			IL_10A:
			IL_10C:
			uint num6 = 72U;
			uint num7 = num5 * num6;
			return num7 + (uint)(num7 * 0.1) + 40U;
			IL_44:
			num5 = (uint)(ishDataSize / 28);
			num = (short)624427009;
			if (num != 0)
			{
			}
			num = (short)53280768;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x06000215 RID: 533 RVA: 0x00063F14 File Offset: 0x00062114
		private void CreateIshItemPbtArray(ref char[] ishItemPbtArr, byte[] packedDataArr, ushort ishType, ushort ishID, ushort ishDataLen, uint packedDataIndex)
		{
			int a_ = 10;
			short num = (short)215810048;
			int num2 = (int)num;
			switch (num2)
			{
			default:
				switch (0)
				{
				case 0:
					goto IL_6F;
				}
				for (;;)
				{
					IL_30:
					char[] array;
					uint num4;
					uint num5;
					switch (num2)
					{
					case 0:
					{
						if (array.Length == 0)
						{
							num = (short)789250061;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int num3;
						array.CopyTo(ishItemPbtArr, num3);
						packedDataIndex += num4;
						num5 += num4;
						num3 += array.GetLength(0);
						int num6;
						num6 -= 28;
						num = (short)41484288;
						short num7 = num;
						num = (short)1368850433;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						goto IL_1A1;
					case 2:
						if (ishItemPbtArr.Length != 0)
						{
							num = (short)861929479;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 3:
						num = (short)17563649;
						if (num != 0)
						{
						}
						goto IL_253;
					case 4:
						goto IL_38F;
					case 5:
						goto IL_38F;
					case 6:
						return;
					case 7:
					{
						char c;
						char c2;
						char[] array2 = (global::PreEmptive.SoS.Runtime.FixedLengthStream.b("꿩ꋫꫭ꿯믱ꃳ돵뗷", a_) + c.ToString() + c2.ToString()).ToCharArray();
						int num3;
						array2.CopyTo(ishItemPbtArr, num3);
						num = (short)867696646;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
					{
						int num6;
						if (num6 >= 28)
						{
							num = (short)713162764;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num4 = (uint)num6;
						num = (short)553320452;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						goto IL_1A1;
					case 10:
						goto IL_253;
					case 11:
					{
						int num6;
						if (num6 <= 0)
						{
							num = (short)1864499210;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)38928392;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
						num4 = 28U;
						num = (short)1942028293;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						global::System.Array.Clear(ishItemPbtArr, 0, ishItemPbtArr.Length);
						global::System.Array.Resize<char>(ref ishItemPbtArr, 0);
						num = (short)9568259;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_6F;
					IL_1A1:
					num = (short)1396441099;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_253:
					num = (short)53542914;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_38F:
					array = new char[12U + 2U * num4 + 4U];
					this.BuildPBTSR3Line(ref array, packedDataArr, packedDataIndex, num4, num5);
					num = (short)1698037760;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				for (;;)
				{
					IL_6F:
					global::System.Globalization.CultureInfo provider = new global::System.Globalization.CultureInfo(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("迩苫쏭藯臱", a_));
					char c = '\r';
					char c2 = '\n';
					int num3 = 0;
					char[] array2 = (global::PreEmptive.SoS.Runtime.FixedLengthStream.b("뻩뗫뻭뗯틱짳훵죷苹", a_) + ishType.ToString(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("鋩", a_), provider) + c.ToString() + c2.ToString()).ToCharArray();
					array2.CopyTo(ishItemPbtArr, 0);
					num3 += array2.GetLength(0);
					array2 = (global::PreEmptive.SoS.Runtime.FixedLengthStream.b("ꏩ꣫컭췯틱쓳軵", a_) + ishID.ToString(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("鋩", a_), provider) + c.ToString() + c2.ToString()).ToCharArray();
					array2.CopyTo(ishItemPbtArr, num3);
					num3 += array2.GetLength(0);
					uint num5 = 0U;
					uint num4 = 0U;
					int num6 = (int)ishDataLen;
					num = (short)2128945130;
					short num8 = num;
					num = (short)1491345386;
					switch ((num8 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_170;
					}
				}
				IL_170:
				num = (short)1332805632;
				if (num != 0)
				{
				}
				num = (short)1063518217;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
		}

		// Token: 0x06000216 RID: 534 RVA: 0x00064330 File Offset: 0x00062530
		private void BuildPBTSR3Line(ref char[] pSRecLine, byte[] data, uint dataIndex, uint dataLen, uint address)
		{
			short num = (short)451342606;
			short num2 = num;
			num = (short)588706062;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)850460672;
				short num3 = num;
				num = (short)1559691264;
				if (num != 0)
				{
				}
				num = (short)1298989057;
				if (num != 0)
				{
				}
				num = (short)1106837504;
				int num4 = (int)num;
				switch (num4)
				{
				}
				break;
			}
			}
			byte b = 0;
			uint num5 = 0U;
			try
			{
				switch (0)
				{
				case 0:
					goto IL_F3;
				}
				int num4;
				byte b2;
				int num7;
				for (;;)
				{
					IL_C8:
					switch (num4)
					{
					case 0:
						goto IL_176;
					case 1:
						b2 = ~b;
						this.WriteSRByte(ref pSRecLine, num5, b2, 16);
						num5 += 2U;
						pSRecLine[(int)num5++] = '\r';
						pSRecLine[(int)num5] = '\n';
						num = (short)381157384;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						int num6 = 0;
						num = (short)1964769280;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
					{
						int num6;
						if ((long)num6 >= (long)((ulong)dataLen))
						{
							num = (short)860028929;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						b2 = data[(int)(checked((global::System.IntPtr)(unchecked((ulong)dataIndex + (ulong)((long)num6)))))];
						b += b2;
						this.WriteSRByte(ref pSRecLine, num5, b2, 16);
						num5 += 2U;
						num6++;
						num = (short)1677590533;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						goto IL_13D;
					case 5:
						goto IL_176;
					case 6:
						if (num7 >= 4)
						{
							num = (short)637075458;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						b2 = (byte)(address << num7 * 8 >> 24);
						b += b2;
						this.WriteSRByte(ref pSRecLine, num5, b2, 16);
						num5 += 2U;
						num7++;
						num = (short)1776156679;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_13D;
					case 8:
						goto IL_292;
					}
					goto IL_F3;
					IL_13D:
					num = (short)46137350;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_176:
					num = (short)1479737347;
					num4 = (int)((global::System.IntPtr)num);
				}
				IL_292:
				return;
				IL_F3:
				pSRecLine[(int)num5++] = 'S';
				pSRecLine[(int)num5++] = '3';
				b2 = (byte)(4U + dataLen + 1U);
				b += b2;
				this.WriteSRByte(ref pSRecLine, num5, b2, 16);
				num5 += 2U;
				num7 = 0;
				num = (short)656932868;
				num4 = (int)((global::System.IntPtr)num);
				goto IL_C8;
			}
			catch (global::System.IndexOutOfRangeException)
			{
				global::System.Array.Clear(pSRecLine, 0, pSRecLine.Length);
				global::System.Array.Resize<char>(ref pSRecLine, 0);
			}
		}

		// Token: 0x06000217 RID: 535 RVA: 0x00064604 File Offset: 0x00062804
		private void WriteSRByte(ref char[] pSRecLine, uint pos, byte byteToWrite, byte baseFormat)
		{
			short num = (short)753074177;
			if (num != 0)
			{
			}
			num = (short)937099264;
			short num2 = num;
			num = (short)1910230173;
			short num3 = num;
			num = (short)1267190941;
			switch (num3 == num)
			{
			}
			num = (short)1537146880;
			if (num != 0)
			{
			}
			uint num4 = (uint)(byteToWrite / baseFormat);
			pSRecLine[(int)pos] = (char)((num4 > 9U) ? (65U + num4 - 10U) : (48U + num4));
			uint num5 = pos + 1U;
			num4 = (uint)(byteToWrite % baseFormat);
			pSRecLine[(int)num5] = (char)((num4 > 9U) ? (65U + num4 - 10U) : (48U + num4));
		}

		// Token: 0x06000218 RID: 536 RVA: 0x000646F8 File Offset: 0x000628F8
		internal bool ConvertPackedImageToSrec(byte[] packedDataArr, string configFileName, out byte[] srecOut)
		{
			short num = (short)1029898240;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_53;
				}
				string s;
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
						goto IL_264;
					case 1:
					{
						byte[] array;
						if (array != null)
						{
							num = (short)1430257671;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_29D;
					}
					case 2:
					{
						byte[] array;
						if (array.GetLength(0) > 0)
						{
							num = (short)584450051;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_29D;
					}
					case 3:
					{
						byte[] array;
						string @string = global::System.Text.Encoding.ASCII.GetString(array);
						object obj = global::MackinawCPS.AcpPbtSrec.pbtSrecLibLock;
						bool flag = false;
						num = (short)86048776;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						goto IL_B9;
					case 5:
					{
						int num3;
						if (num3 == 0)
						{
							num = (short)764936192;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_29D;
					}
					case 6:
					{
						byte[] array = new byte[0];
						this.GeneratePBTFromPackedImage(packedDataArr, ref array);
						num = (short)1730215937;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						goto IL_16A;
					case 8:
						try
						{
							object obj;
							bool flag;
							global::System.Threading.Monitor.Enter(obj, ref flag);
							string @string;
							int num3 = global::PbtSrec.PbtSrecWrapper.PBTMainSA2(configFileName, @string, out s, 3U);
							goto IL_22F;
						}
						finally
						{
							num = (short)633012224;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_12F;
									}
									continue;
								case 1:
								{
									object obj;
									global::System.Threading.Monitor.Exit(obj);
									num = (short)1561853954;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									goto IL_167;
								}
								IL_12F:
								bool flag;
								if (!flag)
								{
									break;
								}
								num = (short)1836384257;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_167:;
						}
						goto IL_16A;
						IL_22F:
						num = (short)337575941;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_53;
					IL_16A:
					num = (short)1117061122;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_B9:
				if (global::System.IO.File.Exists(configFileName))
				{
					goto IL_C4;
				}
				goto IL_29D;
				IL_264:
				num = (short)181927936;
				short num4 = num;
				srecOut = global::System.Text.Encoding.ASCII.GetBytes(s);
				return true;
				IL_29D:
				num = (short)62128129;
				if (num != 0)
				{
				}
				return false;
				IL_53:
				srecOut = null;
				num = (short)1434328257;
				short num5 = num;
				num = (short)1425480897;
				switch ((num5 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_C4:
					num = (short)384172038;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_28;
				default:
					num = (short)982450176;
					if (num != 0)
					{
					}
					num = (short)1031798788;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_28;
				}
				break;
			}
			}
		}

		// Token: 0x06000219 RID: 537 RVA: 0x000649DC File Offset: 0x00062BDC
		internal bool prependS0Line(ref byte[] buffer, string fixedStr, string partPsdtId, string optionalUsageStr, string version)
		{
			short num = (short)751808739;
			short num2 = num;
			num = (short)1694544099;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1617428480;
				short num3 = num;
				num = (short)1739063296;
				if (num != 0)
				{
				}
				num = (short)884408320;
				int num4 = (int)num;
				switch (num4)
				{
				}
				break;
			}
			}
			bool result = false;
			try
			{
				switch (0)
				{
				case 0:
					goto IL_BA;
				}
				int num4;
				global::System.Text.ASCIIEncoding asciiencoding;
				char[] array;
				for (;;)
				{
					IL_A3:
					switch (num4)
					{
					case 0:
					{
						byte[] bytes = asciiencoding.GetBytes(array);
						byte[] array2 = new byte[buffer.Length];
						global::System.Array.Copy(buffer, array2, array2.Length);
						global::System.Array.Resize<byte>(ref buffer, buffer.Length + bytes.Length);
						global::System.Array.Copy(bytes, buffer, bytes.Length);
						global::System.Array.Copy(array2, 0, buffer, bytes.Length, array2.Length);
						result = true;
						num = (short)246743042;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						if (array.Length != 0)
						{
							num = (short)589299712;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1B8;
					case 2:
						goto IL_1B8;
					case 3:
						goto IL_1D1;
					}
					goto IL_BA;
					IL_1B8:
					num = (short)1625030659;
					num4 = (int)((global::System.IntPtr)num);
				}
				IL_1D1:
				goto IL_1D8;
				IL_BA:
				string s = fixedStr + partPsdtId + version + optionalUsageStr;
				array = new char[8 + (fixedStr.Length + partPsdtId.Length + version.Length + optionalUsageStr.Length) * 2 + 2 + 2];
				asciiencoding = new global::System.Text.ASCIIEncoding();
				byte[] bytes2 = asciiencoding.GetBytes(s);
				this.BuildS0Line(ref array, bytes2, 0U, (uint)bytes2.Length, 0U);
				num = (short)2055536641;
				num4 = (int)((global::System.IntPtr)num);
				goto IL_A3;
			}
			catch (global::System.Exception)
			{
				result = false;
			}
			IL_1D8:
			num = (short)746192897;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x0600021A RID: 538 RVA: 0x00064C08 File Offset: 0x00062E08
		private void BuildS0Line(ref char[] pSRecLine, byte[] data, uint dataIndex, uint dataLen, uint address)
		{
			short num = (short)469528972;
			short num2 = num;
			num = (short)742289804;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1747386368;
				short num3 = num;
				num = (short)1706622977;
				if (num != 0)
				{
				}
				num = (short)449118208;
				if (num != 0)
				{
				}
				num = (short)1586888704;
				int num4 = (int)num;
				switch (num4)
				{
				}
				break;
			}
			}
			byte b = 0;
			uint num5 = 0U;
			try
			{
				switch (0)
				{
				case 0:
					goto IL_F2;
				}
				int num4;
				byte b2;
				int num7;
				for (;;)
				{
					IL_C7:
					switch (num4)
					{
					case 0:
						goto IL_175;
					case 1:
						b2 = ~b;
						this.WriteSRByte(ref pSRecLine, num5, b2, 16);
						num5 += 2U;
						pSRecLine[(int)num5++] = '\r';
						pSRecLine[(int)num5] = '\n';
						num = (short)1992753160;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						int num6 = 0;
						num = (short)1325531136;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
					{
						int num6;
						if ((long)num6 >= (long)((ulong)dataLen))
						{
							num = (short)888537089;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						b2 = data[(int)(checked((global::System.IntPtr)(unchecked((ulong)dataIndex + (ulong)((long)num6)))))];
						b += b2;
						this.WriteSRByte(ref pSRecLine, num5, b2, 16);
						num5 += 2U;
						num6++;
						num = (short)161677317;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						goto IL_13B;
					case 5:
						goto IL_175;
					case 6:
						if (num7 >= 2)
						{
							num = (short)1519779842;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						b2 = (byte)(address << num7 * 8 >> 8);
						b += b2;
						this.WriteSRByte(ref pSRecLine, num5, b2, 16);
						num5 += 2U;
						num7++;
						num = (short)346554375;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_13B;
					case 8:
						goto IL_294;
					}
					goto IL_F2;
					IL_13B:
					num = (short)387055622;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_175:
					num = (short)947126275;
					num4 = (int)((global::System.IntPtr)num);
				}
				IL_294:
				return;
				IL_F2:
				pSRecLine[(int)num5++] = 'S';
				pSRecLine[(int)num5++] = '0';
				b2 = (byte)(2U + dataLen + 1U);
				b += b2;
				this.WriteSRByte(ref pSRecLine, num5, b2, 16);
				num5 += 2U;
				num7 = 0;
				num = (short)12058628;
				num4 = (int)((global::System.IntPtr)num);
				goto IL_C7;
			}
			catch (global::System.IndexOutOfRangeException)
			{
				global::System.Array.Clear(pSRecLine, 0, pSRecLine.Length);
				global::System.Array.Resize<char>(ref pSRecLine, 0);
			}
		}

		// Token: 0x0600021C RID: 540 RVA: 0x00064EF4 File Offset: 0x000630F4
		// Note: this type is marked as 'beforefieldinit'.
		static AcpPbtSrec()
		{
			short num = (short)1493270687;
			short num2 = num;
			num = (short)1844805791;
			switch (num2 == num)
			{
			default:
			{
				num = (short)903086080;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1179385857;
			if (num != 0)
			{
			}
			num = (short)338427904;
			if (num != 0)
			{
			}
			global::MackinawCPS.AcpPbtSrec.pbtSrecLibLock = new object();
		}

		// Token: 0x04000178 RID: 376
		public const ushort SrecLineDataSize = 28;

		// Token: 0x04000179 RID: 377
		private static object pbtSrecLibLock;

		// Token: 0x0400017A RID: 378
		[global::System.NonSerialized]
		string VafgnaprSvryq = 32;
	}
}
