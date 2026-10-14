using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.Pba;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.CommonFile
{
	// Token: 0x02000011 RID: 17
	[global::System.Serializable]
	public class PartitionCommonFile
	{
		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000022 RID: 34 RVA: 0x0000433C File Offset: 0x0000253C
		// (set) Token: 0x06000023 RID: 35 RVA: 0x000043E8 File Offset: 0x000025E8
		private byte[] FileData
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)454170352;
				short num2 = num;
				num = (short)113448688;
				switch (num2 == num)
				{
				}
				num = (short)1967915008;
				short num3 = num;
				num = (short)509476865;
				if (num != 0)
				{
				}
				num = (short)917831680;
				if (num != 0)
				{
				}
				return this.<FileData>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)2036672080;
				short num2 = num;
				num = (short)16131664;
				switch (num2 == num)
				{
				}
				num = (short)1090387968;
				short num3 = num;
				num = (short)1607925760;
				if (num != 0)
				{
				}
				num = (short)722993153;
				if (num != 0)
				{
				}
				this.<FileData>k__BackingField = value;
			}
		}

		// Token: 0x06000024 RID: 36 RVA: 0x0000449C File Offset: 0x0000269C
		public PartitionCommonFile(bool isCrcBigEndian)
		{
			this.FileData = null;
			this.IsCrcBigEndian = isCrcBigEndian;
		}

		// Token: 0x06000025 RID: 37 RVA: 0x000044C0 File Offset: 0x000026C0
		public byte[] Serialize(global::Motorola.Common.Communication.CommonFile.CodeplugCommFileHeader fileHeader, global::Motorola.Common.Communication.Pba.PbaObject pbaObject)
		{
			short num = (short)1574670045;
			short num2 = num;
			num = (short)1566674653;
			switch (num2 == num)
			{
			}
			num = (short)1864826880;
			short num3 = num;
			num = (short)1447690241;
			if (num != 0)
			{
			}
			num = (short)1708261376;
			if (num != 0)
			{
			}
			byte[] c = global::Motorola.Common.Communication.CommonFile.PartitionCommonFile.a(fileHeader);
			byte[] c2 = this.a(fileHeader, pbaObject);
			global::System.Collections.ArrayList arrayList = new global::System.Collections.ArrayList();
			arrayList.AddRange(c);
			arrayList.AddRange(c2);
			byte[] array = (byte[])arrayList.ToArray(typeof(byte));
			byte[] c3 = global::Motorola.Common.Communication.CommonFile.PartitionCommonFile.c(array);
			global::System.Collections.ArrayList arrayList2 = new global::System.Collections.ArrayList();
			arrayList2.AddRange(array);
			arrayList2.AddRange(c3);
			this.FileData = (byte[])arrayList2.ToArray(typeof(byte));
			return global::Motorola.Common.Communication.CommonFile.d.a(this.FileData);
		}

		// Token: 0x06000026 RID: 38 RVA: 0x000045E8 File Offset: 0x000027E8
		public global::Motorola.Common.Communication.Pba.PbaObject Deserialize(string ishFilePath)
		{
			short num = (short)1836040240;
			short num2 = num;
			num = (short)2032255024;
			global::Motorola.Common.Communication.Pba.PbaObject result;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)522321920;
				if (num != 0)
				{
				}
				num = (short)1295646720;
				int num3 = (int)num;
				switch (num3)
				{
				default:
				{
					result = null;
					global::System.IO.FileStream fileStream = new global::System.IO.FileStream(ishFilePath, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read);
					try
					{
						switch (0)
						{
						case 0:
							goto IL_A8;
						}
						int num4;
						int num6;
						byte[] array;
						for (;;)
						{
							IL_7D:
							switch (num3)
							{
							case 0:
								goto IL_151;
							case 1:
							{
								int num5;
								num4 += num5;
								num6 -= num5;
								num = (short)1679360003;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 2:
								goto IL_18F;
							case 3:
								goto IL_18F;
							case 4:
								if (!global::Motorola.Common.Communication.CommonFile.PartitionCommonFile.b(array))
								{
									num = (short)1901199368;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								result = this.Deserialize(array);
								num = (short)383844357;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 5:
								goto IL_1E9;
							case 6:
							{
								int num5;
								if (num5 != 0)
								{
									num = (short)1451950081;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_151;
							}
							case 7:
							{
								if (num6 <= 0)
								{
									num = (short)627834880;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								int num5 = fileStream.Read(array, num4, num6);
								num = (short)1671692294;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 8:
								goto IL_18A;
							}
							goto IL_A8;
							IL_151:
							num = (short)132972548;
							num3 = (int)((global::System.IntPtr)num);
							continue;
							IL_18F:
							num = (short)124715015;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_18A:
						throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommonFileInvalidCrc32);
						IL_1E9:
						break;
						IL_A8:
						array = new byte[fileStream.Length];
						num6 = (int)fileStream.Length;
						num4 = 0;
						num = (short)212008962;
						num3 = (int)((global::System.IntPtr)num);
						goto IL_7D;
					}
					finally
					{
						num = (short)1234632704;
						num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_21E;
								}
								continue;
							case 1:
								goto IL_254;
							case 2:
								((global::System.IDisposable)fileStream).Dispose();
								num = (short)1981284353;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_21E:
							if (fileStream == null)
							{
								break;
							}
							num = (short)1636106242;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_254:;
					}
					break;
				}
				}
				break;
			}
			}
			num = (short)102367232;
			short num7 = num;
			num = (short)1681522689;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x06000027 RID: 39 RVA: 0x000048B8 File Offset: 0x00002AB8
		public global::Motorola.Common.Communication.Pba.PbaObject Deserialize(byte[] fileData)
		{
			byte[] array;
			short num;
			for (;;)
			{
				array = global::Motorola.Common.Communication.CommonFile.d.a(global::Motorola.Common.Communication.CommonFile.d.b(fileData));
				if (global::Motorola.Common.Communication.CommonFile.PartitionCommonFile.b(array))
				{
					goto IL_C0;
				}
				num = (short)294075677;
				short num2 = num;
				num = (short)2074492189;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_4D;
				}
			}
			IL_4D:
			num = (short)121241601;
			if (num != 0)
			{
			}
			num = (short)433061888;
			if (num != 0)
			{
			}
			num = (short)1487863808;
			short num3 = num;
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommonFileInvalidCrc32);
			IL_C0:
			global::Motorola.Common.Communication.CommonFile.CodeplugCommFileHeader a_ = global::Motorola.Common.Communication.CommonFile.PartitionCommonFile.a(array);
			return this.a(a_, array);
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00004994 File Offset: 0x00002B94
		private static byte[] a(global::Motorola.Common.Communication.CommonFile.CodeplugCommFileHeader A_0)
		{
			short num = (short)192962065;
			short num2 = num;
			num = (short)17718801;
			switch (num2 == num)
			{
			}
			num = (short)1071251456;
			short num3 = num;
			num = (short)1311899649;
			if (num != 0)
			{
			}
			num = (short)680722432;
			if (num != 0)
			{
			}
			byte[] array = new byte[3];
			int num4 = 0;
			array[num4] = A_0.HeaderVer;
			num4++;
			array[num4] = (byte)A_0.Level;
			num4++;
			array[num4] = (byte)A_0.FullDelta;
			return array;
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00004A68 File Offset: 0x00002C68
		private byte[] a(global::Motorola.Common.Communication.CommonFile.CodeplugCommFileHeader A_0, global::Motorola.Common.Communication.Pba.PbaObject A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_9F;
			}
			short num;
			int num4;
			global::Motorola.Common.Communication.CommonFile.InfoLevel infoLevel;
			byte[] result;
			for (;;)
			{
				IL_0A:
				num = (short)6672346;
				short num2 = num;
				num = (short)1930088410;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_177;
				case 1:
					break;
				default:
				{
					num = (short)1001062400;
					short num3 = num;
					break;
				}
				}
				num = (short)1439891456;
				if (num != 0)
				{
				}
				switch (num4)
				{
				case 0:
					switch (infoLevel)
					{
					case global::Motorola.Common.Communication.CommonFile.InfoLevel.TypeLevelChangeDisc:
						result = global::Motorola.Common.Communication.CommonFile.PartitionCommonFile.c(A_1);
						num = (short)1013383173;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case global::Motorola.Common.Communication.CommonFile.InfoLevel.ItemLevelChangeDisc:
						result = global::Motorola.Common.Communication.CommonFile.PartitionCommonFile.b(A_1);
						num = (short)546504706;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case global::Motorola.Common.Communication.CommonFile.InfoLevel.CodeplugData:
						result = this.a(A_1);
						goto IL_177;
					default:
						num = (short)52428803;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				case 1:
					return result;
				case 2:
					return result;
				case 3:
					num = (short)702611457;
					if (num != 0)
					{
					}
					num = (short)1995505665;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					return result;
				case 5:
					return result;
				}
				goto IL_9F;
				IL_177:
				num = (short)1877737476;
				num4 = (int)((global::System.IntPtr)num);
			}
			return result;
			IL_9F:
			result = null;
			infoLevel = A_0.Level;
			num = (short)1522925568;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00004C08 File Offset: 0x00002E08
		private static byte[] c(byte[] A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			byte[] bytes;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)482412154;
					short num3 = num2;
					num2 = (short)851117690;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)1116995584;
						if (num2 != 0)
						{
						}
						if (global::System.BitConverter.IsLittleEndian)
						{
							return bytes;
						}
						break;
					}
					num2 = (short)1108410370;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
					return bytes;
				case 2:
					num2 = (short)1572536321;
					if (num2 != 0)
					{
					}
					global::System.Array.Reverse(bytes);
					num2 = (short)1621491713;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_1C;
			}
			return bytes;
			IL_1C:
			num2 = (short)1869283328;
			short num4 = num2;
			bytes = global::System.BitConverter.GetBytes(global::Motorola.Common.Communication.CommonFile.CheckSumCrc32.GetCrc32CheckSum(A_0));
			num2 = (short)1775828992;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00004D34 File Offset: 0x00002F34
		private static byte[] c(global::Motorola.Common.Communication.Pba.PbaObject A_0)
		{
			short num = (short)1965930239;
			short num2 = num;
			num = (short)371177215;
			byte[] array;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)2093547520;
				if (num != 0)
				{
				}
				num = (short)1469775872;
				switch (num)
				{
				default:
				{
					global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(A_0.CodeplugData.TypeCounters, global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
					array = new byte[A_0.CodeplugData.TypeCounters.Count * 6];
					global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(array);
					try
					{
						byte[] array2 = null;
						using (global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.TypeLevelChangeDiscovery>.Enumerator enumerator = A_0.CodeplugData.TypeCounters.GetEnumerator())
						{
							num = (short)303300614;
							int num3 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::Motorola.Common.Communication.Pba.TypeLevelChangeDiscovery typeLevelChangeDiscovery;
								switch (num3)
								{
								case 0:
									if (!global::System.BitConverter.IsLittleEndian)
									{
										num = (short)1256194055;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_225;
								case 1:
									goto IL_15D;
								case 2:
									array2 = global::System.BitConverter.GetBytes(typeLevelChangeDiscovery.IshType);
									num = (short)395771904;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									goto IL_2B4;
								case 4:
									if (typeLevelChangeDiscovery != null)
									{
										num = (short)742916098;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 5:
									global::System.Array.Reverse(array2);
									num = (short)882966529;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									switch (0)
									{
									case 0:
										goto IL_10D;
									}
									continue;
								case 7:
									global::System.Array.Reverse(array2);
									num = (short)1343356937;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
									if (!enumerator.MoveNext())
									{
										num = (short)132972556;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									typeLevelChangeDiscovery = enumerator.Current;
									num = (short)1006829572;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
									goto IL_225;
								case 11:
									if (!global::System.BitConverter.IsLittleEndian)
									{
										num = (short)241172485;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_15D;
								case 12:
									num = (short)1488912387;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_10D;
								IL_15D:
								memoryStream.Write(array2, 0, 4);
								num = (short)1697710090;
								num3 = (int)((global::System.IntPtr)num);
								continue;
								IL_1E6:
								num = (short)2091581448;
								num3 = (int)((global::System.IntPtr)num);
								continue;
								IL_10D:
								goto IL_1E6;
								IL_225:
								memoryStream.Write(array2, 0, 2);
								array2 = global::System.BitConverter.GetBytes(typeLevelChangeDiscovery.Counter);
								num = (short)82903051;
								num3 = (int)((global::System.IntPtr)num);
							}
							IL_2B4:;
						}
					}
					finally
					{
						num = (short)1323958272;
						int num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_2F7;
								}
								continue;
							case 1:
								goto IL_32F;
							case 2:
								((global::System.IDisposable)memoryStream).Dispose();
								num = (short)1067253761;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_2F7:
							if (memoryStream == null)
							{
								break;
							}
							num = (short)1287454722;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_32F:;
					}
					break;
				}
				}
				break;
			}
			num = (short)940244992;
			short num4 = num;
			num = (short)1430192129;
			if (num != 0)
			{
			}
			return array;
		}

		// Token: 0x0600002C RID: 44 RVA: 0x000050F8 File Offset: 0x000032F8
		private static byte[] b(global::Motorola.Common.Communication.Pba.PbaObject A_0)
		{
			short num = (short)184043164;
			short num2 = num;
			num = (short)1589528220;
			byte[] array;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)692715520;
				if (num != 0)
				{
				}
				num = (short)55443457;
				if (num != 0)
				{
				}
				num = (short)1765539840;
				switch (num)
				{
				default:
				{
					num = (short)1891500032;
					short num3 = num;
					global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(A_0.CodeplugData.IDCounters, global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
					array = new byte[A_0.CodeplugData.IDCounters.Count * 8];
					global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(array);
					try
					{
						byte[] array2 = null;
						using (global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.ItemLevelChangeDiscovery>.Enumerator enumerator = A_0.CodeplugData.IDCounters.GetEnumerator())
						{
							num = (short)1109327881;
							int num4 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::Motorola.Common.Communication.Pba.ItemLevelChangeDiscovery itemLevelChangeDiscovery;
								switch (num4)
								{
								case 0:
									global::System.Array.Reverse(array2);
									num = (short)1576206351;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									global::System.Array.Reverse(array2);
									num = (short)934805506;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_1B7;
								case 3:
									if (!global::System.BitConverter.IsLittleEndian)
									{
										num = (short)789970944;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_31F;
								case 4:
									goto IL_2C9;
								case 5:
									num = (short)1024393227;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									if (!global::System.BitConverter.IsLittleEndian)
									{
										num = (short)1591214092;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2C9;
								case 7:
									if (!enumerator.MoveNext())
									{
										num = (short)1923809285;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									}
									itemLevelChangeDiscovery = enumerator.Current;
									num = (short)1000341517;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
									array2 = global::System.BitConverter.GetBytes(itemLevelChangeDiscovery.IshType);
									num = (short)1402470403;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
									switch (0)
									{
									case 0:
										goto IL_168;
									}
									continue;
								case 11:
									goto IL_38D;
								case 12:
									global::System.Array.Reverse(array2);
									num = (short)487587844;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								case 13:
									if (itemLevelChangeDiscovery != null)
									{
										num = (short)203161608;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 14:
									if (!global::System.BitConverter.IsLittleEndian)
									{
										num = (short)897712129;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1B7;
								case 15:
									goto IL_31F;
								}
								goto IL_168;
								IL_1B7:
								memoryStream.Write(array2, 0, 4);
								num = (short)780926986;
								num4 = (int)((global::System.IntPtr)num);
								continue;
								IL_245:
								num = (short)1469841415;
								num4 = (int)((global::System.IntPtr)num);
								continue;
								IL_168:
								goto IL_245;
								IL_2C9:
								memoryStream.Write(array2, 0, 2);
								array2 = global::System.BitConverter.GetBytes(itemLevelChangeDiscovery.Counter);
								num = (short)1438056462;
								num4 = (int)((global::System.IntPtr)num);
								continue;
								IL_31F:
								memoryStream.Write(array2, 0, 2);
								array2 = global::System.BitConverter.GetBytes(itemLevelChangeDiscovery.IshID);
								num = (short)1375076358;
								num4 = (int)((global::System.IntPtr)num);
							}
							IL_38D:;
						}
					}
					finally
					{
						num = (short)1136984064;
						int num4 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num4)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_3CF;
								}
								continue;
							case 1:
								goto IL_407;
							case 2:
								((global::System.IDisposable)memoryStream).Dispose();
								num = (short)61734913;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_3CF:
							if (memoryStream == null)
							{
								break;
							}
							num = (short)750387202;
							num4 = (int)((global::System.IntPtr)num);
						}
						IL_407:;
					}
					break;
				}
				}
				break;
			}
			return array;
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00005544 File Offset: 0x00003744
		private byte[] a(global::Motorola.Common.Communication.Pba.PbaObject A_0)
		{
			short num = (short)1087635456;
			switch (num)
			{
			default:
			{
				global::Motorola.Common.Communication.CommonUtil.IshItemCollection codeplugInIshItemCollection = A_0.GetCodeplugInIshItemCollection();
				global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(codeplugInIshItemCollection, global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
				global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.DataPartition> dataPartitions = A_0.CodeplugData.DataPartitions;
				global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(dataPartitions, global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
				int num2 = 0;
				global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem>> list = new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem>>(codeplugInIshItemCollection.Count);
				global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem>> enumerator = codeplugInIshItemCollection.GetEnumerator();
				try
				{
					num = (short)963051524;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							num = (short)2092433409;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_717;
						case 3:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1144061952;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> item = enumerator.Current;
							num2 += 6 + item.Value.ItemSize;
							list.Add(item);
							num = (short)1515847682;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
							switch (0)
							{
							case 0:
								goto IL_684;
							}
							continue;
						}
						IL_686:
						num = (short)2049769475;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_684:
						goto IL_686;
					}
					IL_717:
					goto IL_5C8;
				}
				finally
				{
					num = (short)820314114;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							enumerator.Dispose();
							num = (short)1605763073;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_786;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_74E;
							}
							continue;
						}
						IL_74E:
						if (enumerator == null)
						{
							break;
						}
						num = (short)1626603520;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_786:;
				}
				byte[] array;
				return array;
				for (;;)
				{
					IL_5C8:
					num = (short)786628608;
					short num4 = num;
					num = (short)1292697601;
					if (num != 0)
					{
					}
					list.Sort(new global::System.Comparison<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem>>(global::Motorola.Common.Communication.CommonUtil.IshItemCollection.IshPairCompare));
					num2 += 4 * dataPartitions.Count;
					array = new byte[num2];
					global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(array);
					try
					{
						byte[] array2 = null;
						ushort num5 = 0;
						using (global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem>>.Enumerator enumerator2 = list.GetEnumerator())
						{
							num = (short)1252261912;
							int num3 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::Motorola.Common.Communication.CommonUtil.IshHeader key;
								global::Motorola.Common.Communication.CommonUtil.IshItem value;
								switch (num3)
								{
								case 0:
									if (!global::System.BitConverter.IsLittleEndian)
									{
										num = (short)2020605959;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2EB;
								case 1:
								{
									if (!enumerator2.MoveNext())
									{
										num = (short)906821647;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair = enumerator2.Current;
									key = keyValuePair.Key;
									value = keyValuePair.Value;
									num = (short)473104398;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
								{
									byte b = value.Data[value.Data.Length - 1];
									value.Data[value.Data.Length - 1] = value.Data[value.Data.Length - 2];
									value.Data[value.Data.Length - 2] = b;
									num = (short)22544405;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									goto IL_379;
								case 4:
									num = (short)1824915465;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									goto IL_4FA;
								case 6:
									goto IL_2EB;
								case 7:
									global::System.Array.Reverse(array2);
									num = (short)1993605126;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
									if (!global::System.BitConverter.IsLittleEndian)
									{
										num = (short)611057686;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_F6;
								case 9:
									if (!this.IsCrcBigEndian)
									{
										num = (short)1566310402;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_142;
								case 10:
									if (!global::System.BitConverter.IsLittleEndian)
									{
										num = (short)1852375059;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_379;
								case 11:
									goto IL_486;
								case 12:
									goto IL_F6;
								case 13:
									if (!global::System.BitConverter.IsLittleEndian)
									{
										num = (short)1221853200;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_486;
								case 14:
									if (num5 != (ushort)key.PartitionNumber)
									{
										num = (short)1338703895;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_437;
								case 15:
									num = (short)1835073541;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 16:
									global::System.Array.Reverse(array2);
									num = (short)208142347;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 17:
									goto IL_437;
								case 19:
									global::System.Array.Reverse(array2);
									num = (short)954990595;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 20:
									if (value.ItemSize != 0)
									{
										num = (short)782368772;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 21:
									goto IL_142;
								case 22:
									global::System.Array.Reverse(array2);
									num = (short)238092300;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 23:
									num5 = (ushort)key.PartitionNumber;
									memoryStream.WriteByte(byte.MaxValue);
									memoryStream.WriteByte(byte.MaxValue);
									array2 = global::System.BitConverter.GetBytes(num5);
									num = (short)313458688;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 24:
									switch (0)
									{
									case 0:
										goto IL_F1;
									}
									continue;
								}
								goto IL_F1;
								IL_F6:
								memoryStream.Write(array2, 0, 2);
								num = (short)428998676;
								num3 = (int)((global::System.IntPtr)num);
								continue;
								IL_142:
								memoryStream.Write(value.Data, 0, value.ItemSize);
								num = (short)1065156626;
								num3 = (int)((global::System.IntPtr)num);
								continue;
								IL_22B:
								num = (short)1656094721;
								num3 = (int)((global::System.IntPtr)num);
								continue;
								IL_F1:
								goto IL_22B;
								IL_2EB:
								memoryStream.Write(array2, 0, 2);
								num = (short)357236753;
								num3 = (int)((global::System.IntPtr)num);
								continue;
								IL_379:
								memoryStream.Write(array2, 0, 2);
								array2 = global::System.BitConverter.GetBytes(key.IshID);
								num = (short)276168717;
								num3 = (int)((global::System.IntPtr)num);
								continue;
								IL_437:
								array2 = global::System.BitConverter.GetBytes(key.IshType);
								num = (short)2120155146;
								num3 = (int)((global::System.IntPtr)num);
								continue;
								IL_486:
								memoryStream.Write(array2, 0, 2);
								array2 = global::System.BitConverter.GetBytes((ushort)value.ItemSize);
								num = (short)2143617032;
								num3 = (int)((global::System.IntPtr)num);
							}
							IL_4FA:
							break;
						}
					}
					finally
					{
						num = (short)1994915842;
						int num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
								((global::System.IDisposable)memoryStream).Dispose();
								goto IL_5AD;
							case 1:
								goto IL_5C5;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_53F;
								}
								continue;
							}
							IL_53F:
							num = (short)830138042;
							short num6 = num;
							num = (short)220587706;
							switch ((num6 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								IL_5AD:
								num = (short)264044545;
								num3 = (int)((global::System.IntPtr)num);
								break;
							default:
								num = (short)886308864;
								if (num != 0)
								{
								}
								if (memoryStream == null)
								{
									goto IL_5C7;
								}
								num = (short)1693777920;
								num3 = (int)((global::System.IntPtr)num);
								break;
							}
						}
						IL_5C5:
						IL_5C7:;
					}
				}
				return array;
			}
			}
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00005D28 File Offset: 0x00003F28
		private static bool b(byte[] A_0)
		{
			short num = (short)1504116736;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_42;
				}
				bool result;
				int num7;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						return result;
					case 1:
						result = false;
						num = (short)874381312;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						byte[] array;
						uint crc32CheckSum = global::Motorola.Common.Communication.CommonFile.CheckSumCrc32.GetCrc32CheckSum(array);
						uint num3 = (uint)A_0[A_0.Length - 4];
						uint num4 = (uint)A_0[A_0.Length - 4 + 1];
						uint num5 = (uint)A_0[A_0.Length - 4 + 2];
						uint num6 = (uint)((int)A_0[A_0.Length - 4 + 3] << 24 | (int)((int)num5 << 16) | (int)((int)num4 << 8) | (int)num3);
						if (crc32CheckSum != num6)
						{
							num = (short)1284177921;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					}
					case 3:
						goto IL_D4;
					case 4:
					{
						if (0 < num7)
						{
							num = (short)10027009;
							if (num != 0)
							{
							}
							byte[] array = new byte[num7];
							global::System.Array.Copy(A_0, 0, array, 0, num7);
							num = (short)1101529088;
							short num8 = num;
							num = (short)511377410;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)831532900;
						short num9 = num;
						num = (short)1429811044;
						switch ((num9 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)1805582336;
							if (num != 0)
							{
							}
							num = (short)1540947971;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					goto IL_42;
				}
				IL_D4:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommonFileInvalidFileLength);
				IL_42:
				global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(A_0, global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
				result = true;
				num7 = A_0.Length - 4;
				num = (short)710672388;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00005F18 File Offset: 0x00004118
		private static global::Motorola.Common.Communication.CommonFile.CodeplugCommFileHeader a(byte[] A_0)
		{
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(A_0, global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
			global::Motorola.Common.Communication.CommonFile.CodeplugCommFileHeader codeplugCommFileHeader = new global::Motorola.Common.Communication.CommonFile.CodeplugCommFileHeader();
			int num = 0;
			codeplugCommFileHeader.HeaderVer = A_0[num];
			if (16 == codeplugCommFileHeader.HeaderVer)
			{
				short num2 = (short)575331495;
				short num3 = num2;
				num2 = (short)577887399;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_24;
				case 1:
					break;
				default:
				{
					num2 = (short)1683816448;
					short num4 = num2;
					break;
				}
				}
				num2 = (short)282460161;
				if (num2 != 0)
				{
				}
				num2 = (short)328466432;
				if (num2 != 0)
				{
				}
				num++;
				codeplugCommFileHeader.Level = (global::Motorola.Common.Communication.CommonFile.InfoLevel)A_0[num];
				num++;
				codeplugCommFileHeader.FullDelta = (global::Motorola.Common.Communication.CommonFile.FullDeltaCodeplug)A_0[num];
				return codeplugCommFileHeader;
			}
			IL_24:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommonFileInvalidCommonFileVersion);
		}

		// Token: 0x06000030 RID: 48 RVA: 0x0000600C File Offset: 0x0000420C
		private global::Motorola.Common.Communication.Pba.PbaObject a(global::Motorola.Common.Communication.CommonFile.CodeplugCommFileHeader A_0, byte[] A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_28;
			}
			int num;
			short num2;
			global::Motorola.Common.Communication.Pba.PbaObject pbaObject;
			global::Motorola.Common.Communication.CommonFile.InfoLevel infoLevel;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2 = (short)664928259;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					return pbaObject;
				case 2:
					return pbaObject;
				case 3:
					return pbaObject;
				case 4:
					return pbaObject;
				case 5:
					switch (infoLevel)
					{
					case global::Motorola.Common.Communication.CommonFile.InfoLevel.TypeLevelChangeDisc:
					{
						global::Motorola.Common.Communication.CommonFile.PartitionCommonFile.c(pbaObject, A_1);
						num2 = (short)2005942836;
						short num3 = num2;
						num2 = (short)1276789300;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num2 = (short)1757872128;
							if (num2 != 0)
							{
							}
							num2 = (short)1711538177;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case global::Motorola.Common.Communication.CommonFile.InfoLevel.ItemLevelChangeDisc:
						break;
					case global::Motorola.Common.Communication.CommonFile.InfoLevel.CodeplugData:
						this.a(pbaObject, A_1);
						num2 = (short)484769794;
						num = (int)((global::System.IntPtr)num2);
						continue;
					default:
						num2 = (short)1208680449;
						if (num2 != 0)
						{
						}
						num2 = (short)962002944;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					global::Motorola.Common.Communication.CommonFile.PartitionCommonFile.b(pbaObject, A_1);
					num2 = (short)1972436996;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_28;
			}
			return pbaObject;
			IL_28:
			num2 = (short)800849920;
			short num4 = num2;
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(A_1, global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
			pbaObject = new global::Motorola.Common.Communication.Pba.PbaObject();
			infoLevel = A_0.Level;
			num2 = (short)1052246021;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000031 RID: 49 RVA: 0x000061BC File Offset: 0x000043BC
		private static void c(global::Motorola.Common.Communication.Pba.PbaObject A_0, byte[] A_1)
		{
			short num = (short)1489633280;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_6A;
				}
				int num4;
				global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.TypeLevelChangeDiscovery> list;
				for (;;)
				{
					IL_27:
					ushort num5;
					switch (num2)
					{
					case 0:
					{
						int num3;
						if (num3 + 2 > num4)
						{
							num = (short)1895301127;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num5 = global::Motorola.Common.Communication.CommonFile.b.b(A_1, num3);
						num3 += 2;
						num = (short)1169883145;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						goto IL_24C;
					case 2:
						goto IL_1ED;
					case 3:
					{
						num = (short)2045837312;
						short num6 = num;
						int num3;
						if (num3 + 4 > num4)
						{
							num = (short)243138571;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.Common.Communication.Pba.TypeLevelChangeDiscovery typeLevelChangeDiscovery = new global::Motorola.Common.Communication.Pba.TypeLevelChangeDiscovery();
						byte ishPartition;
						typeLevelChangeDiscovery.IshPartition = ishPartition;
						typeLevelChangeDiscovery.IshType = num5;
						typeLevelChangeDiscovery.Counter = global::Motorola.Common.Communication.CommonFile.b.a(A_1, num3);
						num3 += 4;
						list.Add(typeLevelChangeDiscovery);
						num = (short)245694477;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						goto IL_1ED;
					case 5:
					{
						int num3;
						if (num3 >= num4)
						{
							num = (short)265027585;
							if (num != 0)
							{
							}
							num = (short)840761345;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)192348160;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						num = (short)1021575180;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_152;
					case 8:
					{
						num = (short)1339927501;
						short num7 = num;
						num = (short)824355789;
						switch ((num7 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_276;
						default:
							goto IL_2D2;
						}
						break;
					}
					case 9:
						goto IL_276;
					case 10:
						goto IL_339;
					case 11:
						goto IL_109;
					case 12:
					{
						int num3;
						if (num3 + 2 > num4)
						{
							num = (short)1393033226;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						byte ishPartition = A_1[num3];
						num3 += 2;
						num = (short)1598750722;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
						goto IL_1ED;
					case 14:
					{
						if (num4 <= 3)
						{
							num = (short)161677320;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.TypeLevelChangeDiscovery>();
						int num3 = 3;
						byte ishPartition = 0;
						num = (short)1952448516;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_6A;
					IL_276:
					if (num5 == 65535)
					{
						num = (short)887947270;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1052508163;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1ED:
					num = (short)514326533;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_109:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommonFileInvalidCodeplugDataLength);
				IL_152:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommonFileInvalidCodeplugDataLength);
				IL_24C:
				A_0.CodeplugData.SetTypeCounters(list);
				return;
				IL_2D2:
				num = (short)245825536;
				if (num != 0)
				{
				}
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommonFileInvalidCodeplugDataLength);
				IL_339:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommonFileInvalidCodeplugDataLength);
				IL_6A:
				num4 = A_1.Length - 4;
				num = (short)961413134;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00006520 File Offset: 0x00004720
		private static void b(global::Motorola.Common.Communication.Pba.PbaObject A_0, byte[] A_1)
		{
			short num = (short)1758855168;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_6B;
				}
				int num4;
				global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.ItemLevelChangeDiscovery> list;
				for (;;)
				{
					IL_28:
					int num3;
					ushort num5;
					switch (num2)
					{
					case 0:
						if (num3 + 2 > num4)
						{
							num = (short)275841031;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_23C;
					case 1:
						goto IL_237;
					case 2:
						goto IL_1D9;
					case 3:
					{
						if (num3 + 2 + 4 > num4)
						{
							num = (short)2007695371;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.Common.Communication.Pba.ItemLevelChangeDiscovery itemLevelChangeDiscovery;
						byte ishPartition;
						itemLevelChangeDiscovery.IshPartition = ishPartition;
						itemLevelChangeDiscovery.IshType = num5;
						itemLevelChangeDiscovery.IshID = global::Motorola.Common.Communication.CommonFile.b.b(A_1, num3);
						num3 += 2;
						itemLevelChangeDiscovery.Counter = global::Motorola.Common.Communication.CommonFile.b.a(A_1, num3);
						num3 += 4;
						list.Add(itemLevelChangeDiscovery);
						num = (short)887029773;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						goto IL_1D9;
					case 5:
						if (num3 >= num4)
						{
							num = (short)1743388673;
							if (num != 0)
							{
							}
							num = (short)1085669377;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)874512384;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						num = (short)1317470220;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_133;
					case 8:
					{
						num = (short)781549264;
						short num6 = num;
						num = (short)1882029776;
						switch ((num6 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_23C;
						default:
							goto IL_2BD;
						}
						break;
					}
					case 9:
					{
						if (num5 == 65535)
						{
							num = (short)133496838;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.Common.Communication.Pba.ItemLevelChangeDiscovery itemLevelChangeDiscovery = new global::Motorola.Common.Communication.Pba.ItemLevelChangeDiscovery();
						num = (short)1485897731;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						goto IL_324;
					case 11:
						goto IL_E9;
					case 12:
					{
						if (num3 + 2 > num4)
						{
							num = (short)479854602;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						byte ishPartition = A_1[num3];
						num3 += 2;
						num = (short)100007938;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
						goto IL_1D9;
					case 14:
					{
						if (num4 <= 3)
						{
							num = (short)515768328;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.ItemLevelChangeDiscovery>();
						num3 = 3;
						byte ishPartition = 0;
						num = (short)836763652;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_6B;
					IL_1D9:
					num = (short)126812165;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_23C:
					num5 = global::Motorola.Common.Communication.CommonFile.b.b(A_1, num3);
					num3 += 2;
					num = (short)1700528137;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_E9:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommonFileInvalidCodeplugDataLength);
				IL_133:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommonFileInvalidCodeplugDataLength);
				IL_237:
				num = (short)290586624;
				short num7 = num;
				A_0.CodeplugData.SetIDCounters(list);
				return;
				IL_2BD:
				num = (short)2049703936;
				if (num != 0)
				{
				}
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommonFileInvalidCodeplugDataLength);
				IL_324:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommonFileInvalidCodeplugDataLength);
				IL_6B:
				num4 = A_1.Length - 4;
				num = (short)624427022;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00006898 File Offset: 0x00004A98
		private void a(global::Motorola.Common.Communication.Pba.PbaObject A_0, byte[] A_1)
		{
			short num = (short)1729953792;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_96;
				}
				int num3;
				int length;
				byte b;
				global::Motorola.Common.Communication.CommonUtil.IshItemCollection ishItemCollection;
				for (;;)
				{
					IL_27:
					global::Motorola.Common.Communication.CommonUtil.IshHeader headers;
					global::Motorola.Common.Communication.CommonUtil.IshItem item;
					switch (num2)
					{
					case 0:
						goto IL_44D;
					case 1:
						goto IL_129;
					case 2:
					{
						if (num3 + 2 + 2 + 2 > length - 4)
						{
							num = (short)1202454550;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						headers = default(global::Motorola.Common.Communication.CommonUtil.IshHeader);
						ushort num4 = (ushort)A_1[num3];
						num3++;
						ushort num5 = (ushort)A_1[num3];
						num3++;
						headers.IshType = (ushort)((int)num5 << 8 | (int)num4);
						num4 = (ushort)A_1[num3];
						num3++;
						num5 = (ushort)A_1[num3];
						num3++;
						headers.IshID = (ushort)((int)num5 << 8 | (int)num4);
						item = default(global::Motorola.Common.Communication.CommonUtil.IshItem);
						num4 = (ushort)A_1[num3];
						num3++;
						num5 = (ushort)A_1[num3];
						num3++;
						item.ItemSize = ((int)num5 << 8 | (int)num4);
						num = (short)588513285;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						if (num3 + 2 + 2 > length - 4)
						{
							num = (short)617611283;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1456406553;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (A_1[num3 + 1] == 255)
						{
							num = (short)4587526;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_324;
					case 5:
					{
						if (num3 + item.ItemSize > length - 4)
						{
							num = (short)1158152210;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						byte[] array = new byte[item.ItemSize];
						global::System.Array.Copy(A_1, num3, array, 0, item.ItemSize);
						item.Data = array;
						num = (short)700710928;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
					{
						num3 += 2;
						ushort num4 = (ushort)A_1[num3];
						num3++;
						ushort num5 = (ushort)A_1[num3];
						num3++;
						b = (byte)((int)num5 << 8 | (int)num4);
						num = (short)2106785799;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						if (num3 != length - 4)
						{
							num = (short)2032599049;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_44D;
					case 8:
						goto IL_489;
					case 9:
						num = (short)2132017173;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						goto IL_44D;
					case 11:
						goto IL_2F3;
					case 12:
						if (num3 >= length - 4)
						{
							num = (short)857997320;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)57999363;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						headers.PartitionNumber = b;
						num = (short)2019426315;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						num = (short)2035417103;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						if (A_1[num3 + 1] != 255)
						{
							num = (short)1080164376;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_44D;
					case 16:
						if (!this.IsCrcBigEndian)
						{
							num = (short)385679361;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3C6;
					case 17:
					{
						num = (short)310480493;
						short num6 = num;
						num = (short)1828490861;
						switch ((num6 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_129;
						default:
							num = (short)1830354944;
							if (num != 0)
							{
							}
							if (b != 0)
							{
								num = (short)1841102861;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2F3;
						}
						break;
					}
					case 18:
						goto IL_1E3;
					case 19:
						goto IL_50E;
					case 20:
						goto IL_3C6;
					case 21:
						if (A_1[num3] == 255)
						{
							num = (short)1582039054;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_324;
					case 22:
						goto IL_363;
					case 23:
						num = (short)1826750468;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
						goto IL_324;
					case 25:
						if (A_1[num3] == 255)
						{
							num = (short)2028535831;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_324;
					}
					goto IL_96;
					IL_129:
					byte b2 = item.Data[item.Data.Length - 1];
					item.Data[item.Data.Length - 1] = item.Data[item.Data.Length - 2];
					item.Data[item.Data.Length - 2] = b2;
					num = (short)1849884692;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2F3:
					ishItemCollection.Add(headers, item);
					num3 += item.ItemSize;
					num = (short)2087780352;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_324:
					num = (short)137166850;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3C6:
					num = (short)856621073;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_44D:
					num = (short)177799180;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1E3:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommonFileInvalidItemDataLength);
				IL_363:
				num = (short)1470038017;
				if (num != 0)
				{
				}
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommonFileInvalidCodeplugDataLength);
				IL_489:
				A_0.SetCodeplug(ishItemCollection);
				return;
				IL_50E:
				num = (short)1288437760;
				short num7 = num;
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommonFileInvalidCodeplugDataLength);
				IL_96:
				length = A_1.GetLength(0);
				ishItemCollection = new global::Motorola.Common.Communication.CommonUtil.IshItemCollection();
				b = 0;
				num3 = 3;
				num = (short)1671954442;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00006E88 File Offset: 0x00005088
		internal static string e(string A_0, int A_1)
		{
			char[] array = A_0.ToCharArray();
			int num = (int)((global::System.IntPtr)(1178314889 + A_1) + (global::System.IntPtr)41 + (global::System.IntPtr)1 + (global::System.IntPtr)13 + (global::System.IntPtr)13 + (global::System.IntPtr)53);
			int num3;
			int num2;
			if ((num2 = (num3 = 0)) < 1)
			{
				goto IL_6A;
			}
			IL_37:
			int num5;
			int num4 = num5 = num2;
			char[] array2 = array;
			int num6 = num5;
			char c = array[num5];
			byte b = (byte)((int)(c & 'ÿ') ^ num++);
			byte b2 = (byte)((int)(c >> 8) ^ num++);
			byte b3 = b2;
			b2 = b;
			b = b3;
			array2[num6] = (ushort)((int)b2 << 8 | (int)b);
			num3 = num4 + 1;
			IL_6A:
			if ((num2 = num3) >= array.Length)
			{
				return string.Intern(new string(array));
			}
			goto IL_37;
		}

		// Token: 0x04000034 RID: 52
		private bool IsCrcBigEndian;
	}
}
