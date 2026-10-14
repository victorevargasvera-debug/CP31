using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.Serialization;
using System.Threading;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x0200004E RID: 78
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Serializable]
	public class MemoryImage : global::System.Collections.IEnumerable
	{
		// Token: 0x060001D8 RID: 472 RVA: 0x00024644 File Offset: 0x00022844
		public void AddItem(global::Motorola.Common.Communication.CommonUtil.IMemoryUnit unit)
		{
			short num2;
			for (;;)
			{
				global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IMemoryUnit> unitList = this._unitList;
				bool flag = false;
				try
				{
					switch (0)
					{
					case 0:
						goto IL_37;
					}
					int num;
					for (;;)
					{
						IL_15:
						switch (num)
						{
						case 0:
							if (unit == null)
							{
								num2 = (short)299696130;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							num2 = (short)1345650693;
							num = (int)((global::System.IntPtr)num2);
							continue;
						case 1:
							goto IL_81;
						case 2:
							num2 = (short)942211073;
							num = (int)((global::System.IntPtr)num2);
							continue;
						case 3:
							goto IL_10F;
						case 4:
							this._isGood = false;
							num2 = (short)1009713158;
							num = (int)((global::System.IntPtr)num2);
							continue;
						case 5:
							if (this.a(unit))
							{
								num2 = (short)1007157252;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							this._unitList.Add(unit);
							this._needCompact = true;
							num2 = (short)395444227;
							num = (int)((global::System.IntPtr)num2);
							continue;
						case 6:
							goto IL_A5;
						}
						goto IL_37;
					}
					IL_81:
					IL_A5:
					IL_10F:
					goto IL_177;
					IL_37:
					global::System.Threading.Monitor.Enter(unitList, ref flag);
					num2 = (short)1583153152;
					num = (int)((global::System.IntPtr)num2);
					goto IL_15;
				}
				finally
				{
					num2 = (short)581959680;
					int num = (int)((global::System.IntPtr)num2);
					for (;;)
					{
						switch (num)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_141;
							}
							continue;
						case 1:
							goto IL_174;
						case 2:
							global::System.Threading.Monitor.Exit(unitList);
							num2 = (short)380633089;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						IL_141:
						if (!flag)
						{
							break;
						}
						num2 = (short)1075314690;
						num = (int)((global::System.IntPtr)num2);
					}
					IL_174:;
				}
				IL_177:
				num2 = (short)1690697728;
				short num3 = num2;
				num2 = (short)1083804240;
				short num4 = num2;
				num2 = (short)493718096;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_1D5;
				}
			}
			IL_1D5:
			num2 = (short)2026242049;
			if (num2 != 0)
			{
			}
			num2 = (short)1828323328;
			if (num2 != 0)
			{
			}
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x00024880 File Offset: 0x00022A80
		public int DeleteItem(global::Motorola.Common.Communication.CommonUtil.IMemoryUnit unit)
		{
			short num = (short)1541210112;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IMemoryUnit> unitList = this._unitList;
				bool flag = false;
				int result;
				try
				{
					switch (0)
					{
					case 0:
						goto IL_59;
					}
					int num4;
					for (;;)
					{
						IL_32:
						switch (num2)
						{
						case 0:
							goto IL_FF;
						case 1:
						{
							int num3;
							if (num3 == -1)
							{
								num = (short)624230403;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							this._unitList.RemoveAt(num3);
							num4++;
							num3 = this.b(unit);
							num = (short)37355527;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							result = num4;
							goto IL_E2;
						case 3:
							this._needCompact = true;
							result = num4;
							num = (short)2047016964;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							goto IL_1B2;
						case 5:
						{
							num = (short)861289435;
							short num5 = num;
							num = (short)635190235;
							switch ((num5 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_E2;
							default:
							{
								num = (short)677052416;
								if (num != 0)
								{
								}
								if (unit == null)
								{
									num = (short)109248514;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								int num3 = this.b(unit);
								num = (short)551223296;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							break;
						}
						case 6:
							goto IL_FA;
						case 7:
							goto IL_FF;
						}
						goto IL_59;
						IL_E2:
						num = (short)1678573574;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_FF:
						num = (short)52559873;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_FA:
					IL_1B2:
					goto IL_220;
					IL_59:
					global::System.Threading.Monitor.Enter(unitList, ref flag);
					num4 = 0;
					num = (short)1670512645;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_32;
				}
				finally
				{
					num = (short)383385602;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							global::System.Threading.Monitor.Exit(unitList);
							num = (short)718471169;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_21D;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_1E6;
							}
							continue;
						}
						IL_1E6:
						if (!flag)
						{
							break;
						}
						num = (short)210436096;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_21D:;
				}
				IL_220:
				num = (short)822673409;
				if (num != 0)
				{
				}
				num = (short)331350016;
				short num6 = num;
				return result;
			}
			}
		}

		// Token: 0x060001DA RID: 474 RVA: 0x00024B1C File Offset: 0x00022D1C
		public void RemoveAt(int index)
		{
			short num = (short)191496193;
			if (num != 0)
			{
			}
			num = (short)678952960;
			short num2 = num;
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IMemoryUnit> unitList = this._unitList;
			bool flag = false;
			try
			{
				global::System.Threading.Monitor.Enter(unitList, ref flag);
				this._unitList.RemoveAt(index);
				this._needCompact = false;
			}
			finally
			{
				num = (short)544931842;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						global::System.Threading.Monitor.Exit(unitList);
						goto IL_CF;
					case 1:
					{
						num = (short)1534483580;
						short num4 = num;
						num = (short)1885035644;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_CF;
						default:
							goto IL_11B;
						}
						break;
					}
					case 2:
						switch (0)
						{
						case 0:
							goto IL_AD;
						}
						continue;
					}
					IL_AD:
					if (flag)
					{
						num = (short)1774583808;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_133;
					IL_CF:
					num = (short)1385758721;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_11B:
				num = (short)1095827456;
				if (num != 0)
				{
				}
				IL_133:;
			}
		}

		// Token: 0x060001DB RID: 475 RVA: 0x00024C70 File Offset: 0x00022E70
		public void RemoveAll()
		{
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IMemoryUnit> unitList = this._unitList;
			bool flag = false;
			short num;
			try
			{
				global::System.Threading.Monitor.Enter(unitList, ref flag);
				this._unitList.Clear();
				this._needCompact = false;
			}
			finally
			{
				num = (short)1046216706;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						global::System.Threading.Monitor.Exit(unitList);
						goto IL_7D;
					case 1:
					{
						num = (short)663420929;
						if (num != 0)
						{
						}
						num = (short)1527606140;
						short num3 = num;
						num = (short)1905552252;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_7D;
						default:
							goto IL_EE;
						}
						break;
					}
					case 2:
						switch (0)
						{
						case 0:
							goto IL_5B;
						}
						continue;
					}
					IL_5B:
					if (flag)
					{
						num = (short)1059258368;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_105;
					IL_7D:
					num = (short)149618689;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_EE:
				num = (short)1987903488;
				if (num != 0)
				{
				}
				IL_105:;
			}
			num = (short)188874752;
			short num4 = num;
		}

		// Token: 0x17000079 RID: 121
		public global::Motorola.Common.Communication.CommonUtil.IMemoryUnit this[int index]
		{
			get
			{
				global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IMemoryUnit> unitList = this._unitList;
				bool flag = false;
				global::Motorola.Common.Communication.CommonUtil.IMemoryUnit result;
				short num;
				try
				{
					global::System.Threading.Monitor.Enter(unitList, ref flag);
					result = this._unitList[index];
				}
				finally
				{
					num = (short)162463746;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							global::System.Threading.Monitor.Exit(unitList);
							goto IL_74;
						case 1:
						{
							num = (short)907467133;
							short num3 = num;
							num = (short)888789373;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_74;
							default:
								goto IL_BD;
							}
							break;
						}
						case 2:
							switch (0)
							{
							case 0:
								goto IL_55;
							}
							continue;
						}
						IL_55:
						if (flag)
						{
							num = (short)1991114752;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D4;
						IL_74:
						num = (short)645201921;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_BD:
					num = (short)1277296640;
					if (num != 0)
					{
					}
					IL_D4:;
				}
				num = (short)1201602560;
				short num4 = num;
				num = (short)1819607041;
				if (num != 0)
				{
				}
				return result;
			}
			set
			{
				global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IMemoryUnit> unitList = this._unitList;
				bool flag = false;
				short num;
				try
				{
					global::System.Threading.Monitor.Enter(unitList, ref flag);
					this._unitList[index] = value;
				}
				finally
				{
					num = (short)1991180290;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							global::System.Threading.Monitor.Exit(unitList);
							goto IL_78;
						case 1:
						{
							num = (short)1488841106;
							short num3 = num;
							num = (short)1774971282;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_78;
							default:
								goto IL_C2;
							}
							break;
						}
						case 2:
							switch (0)
							{
							case 0:
								goto IL_55;
							}
							continue;
						}
						IL_55:
						if (flag)
						{
							num = (short)185532416;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D9;
						IL_78:
						num = (short)2022113281;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_C2:
					num = (short)144506880;
					if (num != 0)
					{
					}
					IL_D9:;
				}
				num = (short)157483008;
				short num4 = num;
				num = (short)1875378177;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x060001DE RID: 478 RVA: 0x0002504C File Offset: 0x0002324C
		public bool IsGood()
		{
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IMemoryUnit> unitList = this._unitList;
			bool flag = false;
			bool isGood;
			short num;
			try
			{
				global::System.Threading.Monitor.Enter(unitList, ref flag);
				isGood = this._isGood;
			}
			finally
			{
				num = (short)1647050754;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						num = (short)1797980161;
						if (num != 0)
						{
						}
						global::System.Threading.Monitor.Exit(unitList);
						goto IL_9C;
					case 1:
					{
						num = (short)28116935;
						short num3 = num;
						num = (short)668796871;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_9C;
						default:
							goto IL_E6;
						}
						break;
					}
					case 2:
						switch (0)
						{
						case 0:
							goto IL_4F;
						}
						continue;
					}
					IL_4F:
					if (flag)
					{
						num = (short)425132032;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_FE;
					IL_9C:
					num = (short)1006632961;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_E6:
				num = (short)2033385472;
				if (num != 0)
				{
				}
				IL_FE:;
			}
			num = (short)814088192;
			short num4 = num;
			return isGood;
		}

		// Token: 0x060001DF RID: 479 RVA: 0x00025194 File Offset: 0x00023394
		public void CompactUnits()
		{
			short num;
			try
			{
				num = (short)1353449472;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IMemoryUnit> unitList = this._unitList;
					bool flag = false;
					try
					{
						switch (0)
						{
						case 0:
							goto IL_E2;
						}
						for (;;)
						{
							IL_33:
							int num10;
							switch (num2)
							{
							case 0:
								goto IL_7BA;
							case 1:
							{
								global::Motorola.Common.Communication.CommonUtil.FlashMemoryUnit flashMemoryUnit = new global::Motorola.Common.Communication.CommonUtil.FlashMemoryUnit();
								uint num3;
								byte[] array;
								flashMemoryUnit.ChargeUnit(num3.ToString(global::System.Globalization.CultureInfo.InvariantCulture), array);
								global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IMemoryUnit> list;
								list.Add(flashMemoryUnit);
								num = (short)1649737741;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 2:
							{
								uint num3;
								if (num3 == 4294967295U)
								{
									num = (short)1534066705;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_5A0;
							}
							case 3:
								num = (short)1724973076;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
							{
								uint num3;
								uint num4;
								byte[] array = new byte[num4 - num3 + 1U];
								int num5 = 0;
								int num7;
								int num6 = num7;
								int num9;
								int num8 = num9;
								num = (short)295567397;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 5:
								num = (short)1765343267;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 6:
								goto IL_12C;
							case 7:
								if (!this._needCompact)
								{
									num = (short)1912340521;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)103743518;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 8:
								goto IL_3B1;
							case 9:
							{
								int num6;
								int num8;
								if (num8 > num6)
								{
									num = (short)2076311553;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								byte[] array;
								int num5;
								global::System.Array.Copy(this._unitList[num8].Data, 0L, array, (long)num5, (long)((ulong)this._unitList[num8].Size));
								num5 += (int)this._unitList[num8].Size;
								num8++;
								num = (short)2009071624;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 10:
								goto IL_3AC;
							case 11:
								goto IL_7DD;
							case 12:
								num = (short)294322190;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 13:
								goto IL_6F8;
							case 14:
								goto IL_6B5;
							case 15:
							{
								global::Motorola.Common.Communication.CommonUtil.FlashMemoryUnit flashMemoryUnit2;
								uint num3 = global::System.Convert.ToUInt32(flashMemoryUnit2.Address, global::System.Globalization.CultureInfo.InvariantCulture);
								uint num4 = global::System.Convert.ToUInt32(flashMemoryUnit2.Address, global::System.Globalization.CultureInfo.InvariantCulture) + flashMemoryUnit2.Size - 1U;
								int num9 = num10;
								num = (short)546635803;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 16:
								num = (short)1942880280;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 17:
								num = (short)34340903;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 18:
							{
								global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IMemoryUnit> list;
								if (list.Count != 0)
								{
									num = (short)756219938;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_7DD;
							}
							case 19:
								goto IL_77B;
							case 20:
							{
								uint num4;
								if (num4 != 4294967295U)
								{
									num = (short)661127172;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_6F8;
							}
							case 21:
								num = (short)72024074;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 22:
								goto IL_12C;
							case 23:
							{
								global::Motorola.Common.Communication.CommonUtil.FlashMemoryUnit flashMemoryUnit2;
								uint num4 = global::System.Convert.ToUInt32(flashMemoryUnit2.Address, global::System.Globalization.CultureInfo.InvariantCulture) + flashMemoryUnit2.Size - 1U;
								num = (short)2136145946;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 24:
							{
								uint num3;
								if (num3 != 4294967295U)
								{
									num = (short)1135083523;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_6F8;
							}
							case 25:
							{
								if (num10 >= this._unitList.Count)
								{
									num = (short)1191968784;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.Common.Communication.CommonUtil.FlashMemoryUnit flashMemoryUnit2 = this._unitList[num10] as global::Motorola.Common.Communication.CommonUtil.FlashMemoryUnit;
								int num7 = num10;
								num = (short)1182662658;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 26:
								goto IL_7BA;
							case 27:
								goto IL_7BA;
							case 28:
							{
								if (!(this._unitList[0] is global::Motorola.Common.Communication.CommonUtil.FlashMemoryUnit))
								{
									num = (short)155385877;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								uint num3 = uint.MaxValue;
								uint num4 = uint.MaxValue;
								int num9 = 0;
								int num7 = 0;
								global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IMemoryUnit> list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IMemoryUnit>();
								num10 = 0;
								num = (short)15925254;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 29:
							{
								int num11;
								int num12;
								if (num11 > num12)
								{
									num = (short)930676767;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								byte[] array2;
								int num13;
								global::System.Array.Copy(this._unitList[num11].Data, 0L, array2, (long)num13, (long)((ulong)this._unitList[num11].Size));
								num13 += (int)this._unitList[num11].Size;
								num11++;
								num = (short)1294204961;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 30:
								if (!this.IsGood())
								{
									num = (short)271974412;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)1440022560;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 31:
							{
								global::Motorola.Common.Communication.CommonUtil.FlashMemoryUnit flashMemoryUnit3 = new global::Motorola.Common.Communication.CommonUtil.FlashMemoryUnit();
								uint num3;
								byte[] array2;
								flashMemoryUnit3.ChargeUnit(num3.ToString(global::System.Globalization.CultureInfo.InvariantCulture), array2);
								global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IMemoryUnit> list;
								list.Add(flashMemoryUnit3);
								global::Motorola.Common.Communication.CommonUtil.FlashMemoryUnit flashMemoryUnit2;
								num3 = global::System.Convert.ToUInt32(flashMemoryUnit2.Address, global::System.Globalization.CultureInfo.InvariantCulture);
								uint num4 = global::System.Convert.ToUInt32(flashMemoryUnit2.Address, global::System.Globalization.CultureInfo.InvariantCulture) + flashMemoryUnit2.Size - 1U;
								int num9 = num10;
								num = (short)1811480576;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 32:
								if (this._unitList.Count <= 1)
								{
									num = (short)1485504517;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)1313013788;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 33:
								goto IL_77B;
							case 34:
							{
								this._unitList.Clear();
								global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IMemoryUnit> list;
								this._unitList = list;
								num = (short)610205707;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 35:
								goto IL_4A6;
							case 36:
							{
								uint num4;
								global::Motorola.Common.Communication.CommonUtil.FlashMemoryUnit flashMemoryUnit2;
								if ((ulong)(num4 + 1U) == (ulong)((long)global::System.Convert.ToInt32(flashMemoryUnit2.Address, global::System.Globalization.CultureInfo.InvariantCulture)))
								{
									num = (short)817365015;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								uint num3;
								byte[] array2 = new byte[num4 - num3 + 1U];
								int num13 = 0;
								int num7;
								int num12 = num7 - 1;
								int num9;
								int num11 = num9;
								num = (short)318111763;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 37:
								goto IL_3B1;
							case 38:
								goto IL_7F5;
							case 39:
							{
								uint num4;
								if (num4 == 4294967295U)
								{
									num = (short)450166799;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_5A0;
							}
							case 40:
								goto IL_489;
							case 41:
								num = (short)1266286632;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_E2;
							IL_12C:
							num = (short)77856793;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_3B1:
							num = (short)271843337;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_5A0:
							num = (short)671875108;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_6F8:
							num = (short)235274258;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_77B:
							num = (short)1434255389;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_7BA:
							num10++;
							num = (short)1068892182;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_7DD:
							num = (short)702742566;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_3AC:
						IL_489:
						IL_4A6:
						IL_6B5:
						IL_7F5:
						break;
						IL_E2:
						global::System.Threading.Monitor.Enter(unitList, ref flag);
						num = (short)54067207;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_33;
					}
					finally
					{
						num = (short)1731985410;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								global::System.Threading.Monitor.Exit(unitList);
								goto IL_84E;
							case 1:
								goto IL_866;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_82E;
								}
								continue;
							}
							IL_82E:
							if (flag)
							{
								num = (short)1482358784;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_866;
							IL_84E:
							num = (short)1118961665;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_866:
							num = (short)1167640549;
							short num14 = num;
							num = (short)2058668005;
							switch ((num14 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_84E;
							default:
								goto IL_89A;
							}
						}
						IL_89A:
						num = (short)507183104;
						if (num != 0)
						{
						}
					}
					break;
				}
				}
			}
			finally
			{
				num = (short)794296321;
				if (num != 0)
				{
				}
				this._needCompact = false;
			}
			num = (short)460980224;
			short num15 = num;
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x00025AE0 File Offset: 0x00023CE0
		public global::Motorola.Common.Communication.CommonUtil.MemoryImage Clone()
		{
			short num = (short)343867392;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)1341128705;
				if (num != 0)
				{
				}
				global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IMemoryUnit> unitList = this._unitList;
				bool flag = false;
				global::Motorola.Common.Communication.CommonUtil.MemoryImage result;
				try
				{
					switch (0)
					{
					case 0:
						goto IL_77;
					}
					for (;;)
					{
						IL_5C:
						switch (num2)
						{
						case 0:
							result = null;
							num = (short)128712708;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_1E1;
						case 2:
						{
							global::Motorola.Common.Communication.CommonUtil.MemoryImage memoryImage;
							try
							{
								num = (short)474152963;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
									{
										global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IMemoryUnit>.Enumerator enumerator;
										if (!enumerator.MoveNext())
										{
											num = (short)1492779012;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::Motorola.Common.Communication.CommonUtil.IMemoryUnit memoryUnit = enumerator.Current;
										memoryImage.AddItem(memoryUnit.Clone());
										num = (short)257818626;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 1:
										goto IL_1B7;
									case 3:
										switch (0)
										{
										case 0:
											goto IL_139;
										}
										continue;
									case 4:
										num = (short)278331393;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_13B:
									num = (short)888471552;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_139:
									goto IL_13B;
								}
								IL_1B7:;
							}
							finally
							{
								global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IMemoryUnit>.Enumerator enumerator;
								((global::System.IDisposable)enumerator).Dispose();
							}
							result = memoryImage;
							num = (short)886636545;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
						{
							if (!this.IsGood())
							{
								num = (short)146538496;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.Common.Communication.CommonUtil.MemoryImage memoryImage = new global::Motorola.Common.Communication.CommonUtil.MemoryImage();
							global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IMemoryUnit>.Enumerator enumerator = this._unitList.GetEnumerator();
							num = (short)1789001730;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
							goto IL_CC;
						}
						goto IL_77;
					}
					IL_CC:
					IL_1E1:
					goto IL_29D;
					IL_77:
					global::System.Threading.Monitor.Enter(unitList, ref flag);
					num = (short)618332163;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_5C;
				}
				finally
				{
					num = (short)1180762113;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_24F;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_218;
							}
							continue;
						case 2:
							global::System.Threading.Monitor.Exit(unitList);
							goto IL_238;
						}
						IL_218:
						if (flag)
						{
							num = (short)860749826;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_24F;
						IL_238:
						num = (short)723320832;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_24F:
						num = (short)1907304106;
						short num3 = num;
						num = (short)1526867626;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_238;
						default:
							goto IL_286;
						}
					}
					IL_286:
					num = (short)716308480;
					if (num != 0)
					{
					}
				}
				IL_29D:
				num = (short)255197184;
				short num4 = num;
				return result;
			}
			}
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x00025DE8 File Offset: 0x00023FE8
		public bool GetData(uint addr, uint size, out byte[] buffer)
		{
			short num = (short)1824653312;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IMemoryUnit> unitList = this._unitList;
				bool flag = false;
				bool result;
				try
				{
					switch (0)
					{
					case 0:
						goto IL_69;
					}
					global::Motorola.Common.Communication.CommonUtil.IMemoryUnit memoryUnit;
					int num3;
					for (;;)
					{
						IL_32:
						switch (num2)
						{
						case 0:
							if (addr + size > global::System.Convert.ToUInt32(memoryUnit.Address, global::System.Globalization.CultureInfo.InvariantCulture) + memoryUnit.Size)
							{
								num = (short)967639050;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_166;
						case 1:
							goto IL_1AE;
						case 2:
							if (num3 < this._unitList.Count)
							{
								num = (short)1320157191;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							buffer = null;
							result = false;
							num = (short)1246429189;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							goto IL_166;
						case 4:
							if (num3 >= this._unitList.Count)
							{
								num = (short)1405943811;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							memoryUnit = this._unitList[num3];
							num = (short)4325387;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							goto IL_232;
						case 6:
							num = (short)793051136;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
							result = memoryUnit.GetData(addr, size, out buffer);
							num = (short)1385234440;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
							goto IL_108;
						case 9:
							goto IL_1AE;
						case 10:
							goto IL_1F4;
						case 11:
							if (addr >= global::System.Convert.ToUInt32(memoryUnit.Address, global::System.Globalization.CultureInfo.InvariantCulture))
							{
								num = (short)2018639878;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1F4;
						}
						goto IL_69;
						IL_166:
						num = (short)606732290;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_1AE:
						num = (short)546308100;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_1F4:
						num3++;
						num = (short)1452146689;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_108:
					goto IL_316;
					IL_232:
					num = (short)1122959361;
					if (num != 0)
					{
					}
					goto IL_316;
					IL_69:
					global::System.Threading.Monitor.Enter(unitList, ref flag);
					memoryUnit = null;
					num3 = 0;
					num3 = 0;
					num = (short)1561329673;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_32;
				}
				finally
				{
					num = (short)1925644289;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_2C9;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_292;
							}
							continue;
						case 2:
							global::System.Threading.Monitor.Exit(unitList);
							goto IL_2B2;
						}
						IL_292:
						if (flag)
						{
							num = (short)516816898;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2C9;
						IL_2B2:
						num = (short)1482031104;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_2C9:
						num = (short)258320408;
						short num4 = num;
						num = (short)1415358488;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_2B2;
						default:
							goto IL_2FF;
						}
					}
					IL_2FF:
					num = (short)1985413120;
					if (num != 0)
					{
					}
				}
				IL_316:
				num = (short)1880883200;
				short num5 = num;
				return result;
			}
			}
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x00026154 File Offset: 0x00024354
		public static global::Motorola.Common.Communication.CommonUtil.MemoryImage Add(global::Motorola.Common.Communication.CommonUtil.MemoryImage x, global::Motorola.Common.Communication.CommonUtil.MemoryImage y)
		{
			switch (0)
			{
			case 0:
				goto IL_48;
			}
			int num;
			short num3;
			global::Motorola.Common.Communication.CommonUtil.MemoryImage memoryImage;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					int num2;
					if (num2 >= x._unitList.Count)
					{
						num3 = (short)1491861511;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					memoryImage.AddItem(x._unitList[num2].Clone());
					num2++;
					num3 = (short)255918093;
					num = (int)((global::System.IntPtr)num3);
					continue;
				}
				case 1:
					goto IL_168;
				case 2:
				{
					int num2 = 0;
					num3 = (short)833421321;
					num = (int)((global::System.IntPtr)num3);
					continue;
				}
				case 3:
					goto IL_84;
				case 4:
					return memoryImage;
				case 5:
				{
					int num4 = 0;
					num3 = (short)1110507530;
					num = (int)((global::System.IntPtr)num3);
					continue;
				}
				case 6:
				{
					num3 = (short)2058616832;
					short num5 = num3;
					if (y != null)
					{
						num3 = (short)1312358405;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_168;
				}
				case 7:
					goto IL_222;
				case 8:
					if (memoryImage.IsGood())
					{
						num3 = (short)2047410180;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_2CD;
				case 9:
					num3 = (short)1873739777;
					if (num3 != 0)
					{
					}
					goto IL_288;
				case 10:
					goto IL_84;
				case 11:
					if (x != null)
					{
						num3 = (short)748158978;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_222;
				case 12:
				{
					int num4;
					if (num4 >= y._unitList.Count)
					{
						num3 = (short)902103041;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					memoryImage.AddItem(y._unitList[num4].Clone());
					num4++;
					num3 = (short)1556480003;
					num = (int)((global::System.IntPtr)num3);
					continue;
				}
				case 13:
					IL_163:
					goto IL_288;
				}
				goto IL_48;
				IL_84:
				num3 = (short)62116950;
				short num6 = num3;
				num3 = (short)845337686;
				switch ((num6 == num3) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_163;
				default:
					num3 = (short)2074738688;
					if (num3 != 0)
					{
					}
					num3 = (short)236912652;
					num = (int)((global::System.IntPtr)num3);
					continue;
				}
				IL_168:
				num3 = (short)517931016;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_222:
				num3 = (short)1567948806;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_288:
				num3 = (short)752287744;
				num = (int)((global::System.IntPtr)num3);
			}
			return memoryImage;
			IL_2CD:
			return null;
			IL_48:
			memoryImage = new global::Motorola.Common.Communication.CommonUtil.MemoryImage();
			num3 = (short)1739128843;
			num = (int)((global::System.IntPtr)num3);
			goto IL_0A;
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x060001E3 RID: 483 RVA: 0x00026430 File Offset: 0x00024630
		public int Count
		{
			get
			{
				global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IMemoryUnit> unitList = this._unitList;
				bool flag = false;
				int count;
				short num;
				try
				{
					global::System.Threading.Monitor.Enter(unitList, ref flag);
					count = this._unitList.Count;
				}
				finally
				{
					num = (short)1850540033;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_8C;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_56;
							}
							continue;
						case 2:
							global::System.Threading.Monitor.Exit(unitList);
							goto IL_76;
						}
						IL_56:
						if (flag)
						{
							num = (short)791281666;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_8C;
						IL_76:
						num = (short)456982528;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_8C:
						num = (short)611516417;
						if (num != 0)
						{
						}
						num = (short)1384456405;
						short num3 = num;
						num = (short)792928469;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_76;
						default:
							goto IL_E9;
						}
					}
					IL_E9:
					num = (short)108658688;
					if (num != 0)
					{
					}
				}
				num = (short)1891500032;
				short num4 = num;
				return count;
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x060001E4 RID: 484 RVA: 0x00026578 File Offset: 0x00024778
		public uint Size
		{
			get
			{
				short num = (short)1777598464;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IMemoryUnit> unitList = this._unitList;
					bool flag = false;
					uint result;
					try
					{
						switch (0)
						{
						case 0:
							goto IL_4E;
						}
						uint num3;
						int num4;
						for (;;)
						{
							IL_33:
							switch (num2)
							{
							case 0:
								goto IL_A1;
							case 1:
								goto IL_FD;
							case 2:
								result = num3;
								num = (short)1515388929;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
								goto IL_A1;
							case 4:
								if (num4 >= this._unitList.Count)
								{
									num = (short)1140785154;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								num3 += this._unitList[num4].Size;
								num4++;
								num = (short)1992949760;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_4E;
							IL_A1:
							num = (short)1671888900;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_FD:
						goto IL_1DF;
						IL_4E:
						global::System.Threading.Monitor.Enter(unitList, ref flag);
						num3 = 0U;
						num4 = 0;
						num = (short)516816899;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_33;
					}
					finally
					{
						num = (short)198705153;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_16B;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_134;
								}
								continue;
							case 2:
								global::System.Threading.Monitor.Exit(unitList);
								goto IL_154;
							}
							IL_134:
							if (flag)
							{
								num = (short)39845890;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_16B;
							IL_154:
							num = (short)1136984064;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_16B:
							num = (short)1799836630;
							short num5 = num;
							num = (short)1883591638;
							switch ((num5 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_154;
							default:
								goto IL_1A0;
							}
						}
						IL_1A0:
						num = (short)2010251265;
						if (num != 0)
						{
						}
						num = (short)58589184;
						if (num != 0)
						{
						}
					}
					IL_1DF:
					num = (short)1290665984;
					short num6 = num;
					return result;
				}
				}
			}
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x000267A0 File Offset: 0x000249A0
		private int b(global::Motorola.Common.Communication.CommonUtil.IMemoryUnit A_0)
		{
			short num = (short)1147928576;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IMemoryUnit> unitList = this._unitList;
				bool flag = false;
				int result;
				try
				{
					switch (0)
					{
					case 0:
						goto IL_6D;
					}
					int num3;
					for (;;)
					{
						IL_32:
						int num4;
						switch (num2)
						{
						case 0:
							result = num3;
							num = (short)814546953;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							num = (short)892076038;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
						{
							if (num4 >= this._unitList.Count)
							{
								num = (short)268566536;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.Common.Communication.CommonUtil.IMemoryUnit memoryUnit = this._unitList[num4];
							num = (short)1196163076;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
							num3 = num4;
							num = (short)353828876;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
						{
							global::Motorola.Common.Communication.CommonUtil.IMemoryUnit memoryUnit;
							if (memoryUnit.Address == A_0.Address)
							{
								num = (short)1086980097;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_EB;
						}
						case 5:
							goto IL_14B;
						case 6:
						{
							global::Motorola.Common.Communication.CommonUtil.IMemoryUnit memoryUnit;
							if (memoryUnit.Size == memoryUnit.Size)
							{
								num = (short)1943601155;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_EB;
						}
						case 7:
							goto IL_254;
						case 8:
							goto IL_239;
						case 9:
							goto IL_125;
						case 10:
							if (A_0 == null)
							{
								num = (short)542507008;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num4 = 0;
							num = (short)831848459;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 11:
							num = (short)1453785089;
							if (num != 0)
							{
							}
							goto IL_14B;
						case 12:
							goto IL_239;
						}
						goto IL_6D;
						IL_EB:
						num4++;
						num = (short)470417413;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_14B:
						num = (short)429457410;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_239:
						result = num3;
						num = (short)15597575;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_125:
					IL_254:
					goto IL_313;
					IL_6D:
					global::System.Threading.Monitor.Enter(unitList, ref flag);
					num3 = -1;
					num = (short)1728380938;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_32;
				}
				finally
				{
					num = (short)1125122049;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_2C7;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_28D;
							}
							continue;
						case 2:
							global::System.Threading.Monitor.Exit(unitList);
							goto IL_2AF;
						}
						IL_28D:
						if (flag)
						{
							num = (short)257687554;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2C7;
						IL_2AF:
						num = (short)1833631744;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_2C7:
						num = (short)573924437;
						short num5 = num;
						num = (short)1122853973;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_2AF;
						default:
							goto IL_2FC;
						}
					}
					IL_2FC:
					num = (short)2106392576;
					if (num != 0)
					{
					}
				}
				IL_313:
				num = (short)1572536320;
				short num6 = num;
				return result;
			}
			}
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x00026B08 File Offset: 0x00024D08
		private bool a(global::Motorola.Common.Communication.CommonUtil.IMemoryUnit A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_2C;
			}
			bool result;
			short num2;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					result = true;
					num2 = (short)268042246;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
				{
					int num3;
					if (this._unitList[num3].IsOverlaped(A_0))
					{
						goto IL_152;
					}
					num3++;
					num2 = (short)348979205;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					goto IL_1AC;
				case 3:
				{
					int num3;
					if (num3 >= this._unitList.Count - 1)
					{
						num2 = (short)1254948866;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)2117992449;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 4:
					goto IL_16C;
				case 5:
					goto IL_16C;
				case 6:
					goto IL_120;
				}
				goto IL_2C;
				IL_16C:
				num2 = (short)450297859;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_120:
			IL_1AC:
			this._needCompact = true;
			return result;
			IL_2C:
			num2 = (short)1512636417;
			if (num2 != 0)
			{
			}
			num2 = (short)416219136;
			short num4 = num2;
			num2 = (short)1136712097;
			short num5 = num2;
			num2 = (short)500816289;
			switch ((num5 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_152:
				num2 = (short)1661861888;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)1559298048;
				if (num2 != 0)
				{
				}
				result = false;
				int num3 = 0;
				num2 = (short)1170341892;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x00026CCC File Offset: 0x00024ECC
		public global::System.Collections.IEnumerator GetEnumerator()
		{
			short num = (short)1853904429;
			short num2 = num;
			num = (short)463033901;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1382154240;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1131020288;
			if (num != 0)
			{
			}
			num = (short)419758081;
			if (num != 0)
			{
			}
			return this._unitList.GetEnumerator();
		}

		// Token: 0x040001E1 RID: 481
		[global::System.Runtime.Serialization.DataMember]
		private global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IMemoryUnit> _unitList = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IMemoryUnit>();

		// Token: 0x040001E2 RID: 482
		[global::System.Runtime.Serialization.DataMember]
		private bool _needCompact = true;

		// Token: 0x040001E3 RID: 483
		[global::System.Runtime.Serialization.DataMember]
		private bool _isGood = true;
	}
}
