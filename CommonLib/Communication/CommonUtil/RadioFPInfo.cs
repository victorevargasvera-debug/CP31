using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Threading;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x0200006A RID: 106
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Serializable]
	public class RadioFPInfo
	{
		// Token: 0x060002E4 RID: 740 RVA: 0x00034D40 File Offset: 0x00032F40
		public RadioFPInfo()
		{
			this._emptySlots = new global::System.Collections.Generic.List<uint>();
			this._radioInfo = new global::System.Collections.Generic.Dictionary<uint, global::Motorola.Common.Communication.CommonUtil.PackHeader>();
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x00034D6C File Offset: 0x00032F6C
		public bool AddSlots(uint emptyslot)
		{
			short num = (short)1985347586;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)98129012;
					short num3 = num;
					num = (short)339498100;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_8F;
					default:
						goto IL_DB;
					}
					break;
				}
				case 1:
					return false;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_34;
					}
					continue;
				case 3:
					if (!this._emptySlots.Contains(emptyslot))
					{
						goto IL_8F;
					}
					return false;
				}
				IL_34:
				if (emptyslot == 0U)
				{
					num = (short)1315962881;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)773521411;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_8F:
				num = (short)1534328832;
				num2 = (int)((global::System.IntPtr)num);
			}
			return false;
			IL_DB:
			num = (short)1333985281;
			if (num != 0)
			{
			}
			num = (short)605224960;
			short num4 = num;
			num = (short)1136984064;
			if (num != 0)
			{
			}
			this._emptySlots.Add(emptyslot);
			this._emptySlots.Sort();
			return true;
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x00034EC4 File Offset: 0x000330C4
		public bool AddRadioFPInfo(uint address, global::Motorola.Common.Communication.CommonUtil.PackHeader pack)
		{
			short num = (short)848822275;
			int num2 = (int)((global::System.IntPtr)num);
			bool result;
			for (;;)
			{
				global::System.Collections.Generic.Dictionary<uint, global::Motorola.Common.Communication.CommonUtil.PackHeader> radioInfo;
				bool flag;
				switch (num2)
				{
				case 0:
					return false;
				case 1:
					if (pack == null)
					{
						num = (short)260112384;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1D9;
				case 2:
					num = (short)1342570497;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					num = (short)1286668289;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_5F;
					}
					continue;
				case 4:
					try
					{
						switch (0)
						{
						case 0:
							goto IL_9F;
						}
						for (;;)
						{
							IL_89:
							switch (num2)
							{
							case 0:
								goto IL_121;
							case 1:
								this._radioInfo.Add(address, pack);
								result = true;
								num = (short)393609219;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								if (!this._radioInfo.ContainsKey(address))
								{
									num = (short)1956315137;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								result = false;
								num = (short)1045430272;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
								goto IL_103;
							}
							goto IL_9F;
						}
						IL_103:
						IL_121:
						goto IL_236;
						IL_9F:
						global::System.Threading.Monitor.Enter(radioInfo, ref flag);
						num = (short)1293090818;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_89;
					}
					finally
					{
						num = (short)1345454081;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_1D6;
							case 1:
							{
								num = (short)933775842;
								short num3 = num;
								num = (short)2108836322;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_1BA;
								default:
									num = (short)1222770688;
									if (num != 0)
									{
									}
									switch (0)
									{
									case 0:
										goto IL_1A1;
									}
									continue;
								}
								break;
							}
							case 2:
								goto IL_1BA;
							}
							IL_1A1:
							if (flag)
							{
								num = (short)381878274;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
							IL_1BA:
							global::System.Threading.Monitor.Exit(radioInfo);
							num = (short)1329463296;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_1D6:;
					}
					goto IL_1D9;
				}
				IL_5F:
				if (address != 0U)
				{
					num = (short)2110914562;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_1D9:
				radioInfo = this._radioInfo;
				flag = false;
				num = (short)1225719812;
				num2 = (int)((global::System.IntPtr)num);
			}
			return false;
			IL_236:
			num = (short)1022820352;
			short num4 = num;
			return result;
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x00035144 File Offset: 0x00033344
		public void UpdateRadioFPInfo(uint oldAddr, uint newAddress, global::Motorola.Common.Communication.CommonUtil.PackHeader pack)
		{
			short num = (short)284295169;
			if (num != 0)
			{
			}
			global::System.Collections.Generic.Dictionary<uint, global::Motorola.Common.Communication.CommonUtil.PackHeader> radioInfo = this._radioInfo;
			bool flag = false;
			try
			{
				switch (0)
				{
				case 0:
					goto IL_66;
				}
				int num2;
				for (;;)
				{
					IL_3C:
					switch (num2)
					{
					case 0:
						goto IL_183;
					case 1:
						if (newAddress != 0U)
						{
							num = (short)453967877;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_16B;
					case 2:
						goto IL_16B;
					case 3:
						this._radioInfo.Remove(oldAddr);
						num = (short)1141047300;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_F4;
					case 5:
						this._radioInfo.Add(newAddress, pack);
						num = (short)526712834;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						if (!this._radioInfo.ContainsKey(newAddress))
						{
							num = (short)290521096;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_16B;
					case 7:
						if (this._radioInfo.ContainsKey(oldAddr))
						{
							num = (short)142475267;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F4;
					case 8:
						num = (short)925761537;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_66;
					IL_F4:
					num = (short)1589772294;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_16B:
					num = (short)1639251968;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_183:
				goto IL_23C;
				IL_66:
				global::System.Threading.Monitor.Enter(radioInfo, ref flag);
				num = (short)1087045639;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_3C;
			}
			finally
			{
				num = (short)1048510465;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_239;
					case 1:
					{
						num = (short)951753372;
						short num3 = num;
						num = (short)1005230748;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_21F;
						default:
							num = (short)59637760;
							if (num != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_206;
							}
							continue;
						}
						break;
					}
					case 2:
						goto IL_21F;
					}
					IL_206:
					if (flag)
					{
						num = (short)337248258;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_21F:
					global::System.Threading.Monitor.Exit(radioInfo);
					num = (short)1011417088;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_239:;
			}
			IL_23C:
			num = (short)60358656;
			short num4 = num;
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x000353D4 File Offset: 0x000335D4
		public void DeleteRadioFPInfo(uint address)
		{
			short num = (short)1338572801;
			if (num != 0)
			{
			}
			global::System.Collections.Generic.Dictionary<uint, global::Motorola.Common.Communication.CommonUtil.PackHeader> radioInfo = this._radioInfo;
			bool flag = false;
			try
			{
				switch (0)
				{
				case 0:
					goto IL_54;
				}
				int num2;
				for (;;)
				{
					IL_3E:
					switch (num2)
					{
					case 0:
						goto IL_D2;
					case 1:
						this._radioInfo.Remove(address);
						num = (short)1483931651;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (this._radioInfo.ContainsKey(address))
						{
							num = (short)899416065;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B9;
					case 3:
						goto IL_B9;
					}
					goto IL_54;
					IL_B9:
					num = (short)1127874560;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_D2:
				goto IL_18A;
				IL_54:
				global::System.Threading.Monitor.Enter(radioInfo, ref flag);
				num = (short)1244528642;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_3E;
			}
			finally
			{
				num = (short)1729888257;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_187;
					case 1:
					{
						num = (short)1933914721;
						short num3 = num;
						num = (short)2061513313;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_16C;
						default:
							num = (short)2106458112;
							if (num != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_152;
							}
							continue;
						}
						break;
					}
					case 2:
						goto IL_16C;
					}
					IL_152:
					if (flag)
					{
						num = (short)1342701570;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_16C:
					global::System.Threading.Monitor.Exit(radioInfo);
					num = (short)1335558144;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_187:;
			}
			IL_18A:
			num = (short)1996816384;
			short num4 = num;
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x000355A4 File Offset: 0x000337A4
		public void DeleteEmptySlot(uint addr)
		{
			global::System.Collections.Generic.List<uint> emptySlots = this._emptySlots;
			bool flag = false;
			short num2;
			try
			{
				switch (0)
				{
				case 0:
					goto IL_2B;
				}
				int num;
				for (;;)
				{
					IL_15:
					switch (num)
					{
					case 0:
						goto IL_A5;
					case 1:
						this._emptySlots.Remove(addr);
						num2 = (short)1874329603;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 2:
						if (this._emptySlots.Contains(addr))
						{
							num2 = (short)373555201;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_8E;
					case 3:
						goto IL_8E;
					}
					goto IL_2B;
					IL_8E:
					num2 = (short)50266112;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_A5:
				goto IL_15E;
				IL_2B:
				global::System.Threading.Monitor.Enter(emptySlots, ref flag);
				num2 = (short)3473410;
				num = (int)((global::System.IntPtr)num2);
				goto IL_15;
			}
			finally
			{
				num2 = (short)1352007681;
				int num = (int)((global::System.IntPtr)num2);
				for (;;)
				{
					switch (num)
					{
					case 0:
						goto IL_15B;
					case 1:
					{
						num2 = (short)2037725184;
						short num3 = num2;
						num2 = (short)1602238464;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_140;
						default:
							num2 = (short)139526144;
							if (num2 != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_127;
							}
							continue;
						}
						break;
					}
					case 2:
						goto IL_140;
					}
					IL_127:
					if (flag)
					{
						num2 = (short)645332994;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
					IL_140:
					global::System.Threading.Monitor.Exit(emptySlots);
					num2 = (short)1443168256;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_15B:;
			}
			IL_15E:
			num2 = (short)1948516353;
			if (num2 != 0)
			{
			}
			num2 = (short)1024131072;
			short num4 = num2;
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x060002EA RID: 746 RVA: 0x00035770 File Offset: 0x00033970
		public global::System.Collections.Generic.List<uint> EmptySlots
		{
			get
			{
				short num = (short)462834912;
				short num2 = num;
				num = (short)635325664;
				switch (num2 == num)
				{
				}
				num = (short)1796997120;
				if (num != 0)
				{
				}
				num = (short)1916600321;
				if (num != 0)
				{
				}
				num = (short)1372717056;
				short num3 = num;
				return this._emptySlots;
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x060002EB RID: 747 RVA: 0x00035820 File Offset: 0x00033A20
		public global::System.Collections.Generic.Dictionary<uint, global::Motorola.Common.Communication.CommonUtil.PackHeader> RadioFlashPack
		{
			get
			{
				short num = (short)620849062;
				short num2 = num;
				num = (short)734685094;
				switch (num2 == num)
				{
				}
				num = (short)435748865;
				if (num != 0)
				{
				}
				num = (short)1429602304;
				if (num != 0)
				{
				}
				num = (short)1939668992;
				short num3 = num;
				return this._radioInfo;
			}
		}

		// Token: 0x040002DD RID: 733
		private global::System.Collections.Generic.List<uint> _emptySlots;

		// Token: 0x040002DE RID: 734
		private global::System.Collections.Generic.Dictionary<uint, global::Motorola.Common.Communication.CommonUtil.PackHeader> _radioInfo;
	}
}
