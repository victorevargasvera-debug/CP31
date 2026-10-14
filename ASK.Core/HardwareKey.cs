using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Globalization;
using System.Threading;
using System.Windows;
using System.Windows.Media;
using AcpCryptoLib;
using AcpUtility;
using ASK.Interface;
using Motorola.CommonCPS.ResourceRepository;
using RMIBtnWrapperLib;

namespace ASK.Core
{
	// Token: 0x02000019 RID: 25
	public class HardwareKey : global::ASK.Core.IKeyRecord
	{
		// Token: 0x060000DB RID: 219 RVA: 0x0001560C File Offset: 0x0001380C
		public HardwareKey()
		{
			this.d = new global::System.Collections.ObjectModel.ObservableCollection<global::ASK.Core.IKeyDataRecord>();
			this.b = null;
			this.c = null;
			this.a = 0;
			this.q = false;
			this.e = global::ASK.Interface.KeyType.ADVANCED_SYSTEM_KEY;
			this.f = global::ASK.Interface.HardwareKeyFamily.Unknown;
			this.n = false;
			this.r = global::System.DateTime.Now;
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00015674 File Offset: 0x00013874
		internal uint a(global::RMIBtnWrapperLib.IIBtnWrapper A_0, bool A_1, bool A_2, int A_3, int A_4)
		{
			int a_ = 3;
			short num = (short)997989646;
			short num2 = num;
			num = (short)1251155214;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_98;
			case 1:
				break;
			default:
			{
				num = (short)1552547840;
				short num3 = num;
				break;
			}
			}
			num = (short)801570816;
			if (num != 0)
			{
			}
			num = (short)946012160;
			int num4 = (int)num;
			switch (num4)
			{
			default:
			{
				IL_98:
				uint num5 = 0U;
				bool flag = true;
				try
				{
					switch (0)
					{
					case 0:
						goto IL_1E3;
					}
					bool flag2;
					for (;;)
					{
						IL_A8:
						bool flag3;
						bool flag4;
						switch (num4)
						{
						case 0:
							if (this.a(A_0, ref flag2))
							{
								num = (short)1522925612;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)510066719;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							if (global::System.Windows.MessageBox.Show(global::Motorola.CommonCPS.ResourceRepository.Resources.ResourceManager.GetString(global::ASK.Core.StatusMsg.b("績╀㕂⑄⥆⩈⹊ቌю㑐⩒੔ɖ⥘㱚⽜㹞ՠ٢", a_), global::Motorola.CommonCPS.ResourceRepository.Resources.Culture).AcpStringFormat(new object[]
							{
								this.w
							}), global::Motorola.CommonCPS.ResourceRepository.Resources.ResourceManager.GetString(global::ASK.Core.StatusMsg.b("嘾̀㙂ㅄ㍆♈╊ቌN⅐㙒㭔ࡖ᱘⥚⽜ぞ፠", a_), global::Motorola.CommonCPS.ResourceRepository.Resources.Culture), global::System.Windows.MessageBoxButton.YesNo, global::System.Windows.MessageBoxImage.Hand, global::System.Windows.MessageBoxResult.Yes, this.v) == global::System.Windows.MessageBoxResult.Yes)
							{
								num = (short)1601044505;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							flag = false;
							num5 = 2684387340U;
							num = (short)1015873589;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							flag = false;
							num = (short)1971978260;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							num5 = this.b(A_0, out this.m);
							num = (short)817102914;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							goto IL_4CA;
						case 5:
							goto IL_C77;
						case 6:
							goto IL_C77;
						case 7:
							flag = false;
							num = (short)1387790342;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
							flag3 = !this.n;
							goto IL_395;
						case 9:
							num = (short)775422014;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 10:
							if (num5 == 0U)
							{
								num = (short)1270612038;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_C77;
						case 11:
							num5 = this.a(A_0, 1, out this.a);
							num = (short)1915355192;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 12:
							if (A_4 == 2)
							{
								num = (short)1865809937;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)786497565;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 13:
							num = (short)279838783;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 14:
							if (num5 == 2684387330U)
							{
								num = (short)901578806;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1298333771;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 15:
							goto IL_C90;
						case 16:
							if (num5 == 0U)
							{
								num = (short)928972871;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_3D3;
						case 17:
							num = (short)959381505;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 18:
							num5 = 3758129160U;
							num = (short)999620675;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 19:
							num5 = this.f(A_0);
							num = (short)1850146820;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 20:
							if (A_4 == 1)
							{
								num = (short)1419509793;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							num5 = 2684387339U;
							num = (short)1460731947;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 21:
							if (A_4 != 1)
							{
								num = (short)1615724551;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_358;
						case 22:
							goto IL_C77;
						case 23:
							num = (short)1912209416;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 24:
							flag3 = false;
							goto IL_395;
						case 25:
							num = (short)160170020;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 26:
							num5 = 0U;
							num = (short)916389935;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 27:
							num = (short)1777401898;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 28:
							num = (short)1696006212;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 29:
							if (A_4 == 3)
							{
								num = (short)1709637678;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_40D;
						case 30:
							num5 = this.f(A_0);
							num = (short)784138316;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 31:
							if (A_4 == 1)
							{
								num = (short)1889861662;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_C77;
						case 32:
							this.l = true;
							num = (short)900071462;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 33:
							num5 = 2684387336U;
							num = (short)795148337;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 34:
							if (flag4)
							{
								num = (short)2032926723;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_C77;
						case 35:
							if (!A_1)
							{
								num = (short)1468989458;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_C77;
						case 36:
							if (this.a >= 3)
							{
								num = (short)1330053146;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							num5 = 2684387338U;
							num = (short)700383280;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 37:
							if (this.a > 5)
							{
								num = (short)506331138;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)184156221;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 38:
							goto IL_532;
						case 39:
							goto IL_C77;
						case 40:
							num = (short)751108117;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 41:
							num = (short)165281837;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 42:
							if (this.m.Length > 0)
							{
								num = (short)263258144;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_532;
						case 43:
							goto IL_40D;
						case 44:
							this.g = true;
							num = (short)184549411;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 45:
							if (this.IsFormated(A_0, ref flag2))
							{
								num = (short)1113456699;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							num5 = 3758129160U;
							num = (short)707198998;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 46:
							flag4 = false;
							num = (short)853737530;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 47:
							goto IL_40D;
						case 48:
							goto IL_40D;
						case 49:
							goto IL_40D;
						case 50:
							if (num5 == 0U)
							{
								num = (short)1629224973;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_C77;
						case 51:
							num = (short)607322149;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 52:
							if (this.m.Length > 0)
							{
								num = (short)289144901;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_C77;
						case 53:
							goto IL_40D;
						case 54:
							flag = true;
							this.n = true;
							num5 = 0U;
							num = (short)256114762;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 55:
							goto IL_3D3;
						case 56:
							if (num5 == 0U)
							{
								num = (short)1186201651;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_40D;
						case 57:
							num = (short)1154088972;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 58:
							goto IL_40D;
						case 59:
							num5 = this.a(A_0, 0, out this.a);
							this.n = global::ASK.Core.KeyRecordSet.c(this.b);
							flag4 = A_2;
							this.h = this.b(A_0, ref flag2);
							num = (short)1328808008;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 60:
							num = (short)1340080180;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 61:
							if (this.a < 5)
							{
								num = (short)258605113;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_40D;
						case 62:
							if (this.h)
							{
								num = (short)672595991;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_319;
						case 63:
							if (A_4 == 1)
							{
								num = (short)1832845331;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_4CA;
						case 64:
							if (flag4)
							{
								num = (short)465174537;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_319;
						case 65:
							if (flag)
							{
								num = (short)145489948;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_C77;
						case 66:
							if (this.m != null)
							{
								num = (short)2140012571;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_532;
						case 67:
							goto IL_C77;
						case 68:
							if (this.m != null)
							{
								num = (short)1765867580;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_C77;
						case 69:
							num5 = this.a(this.m);
							num = (short)480772135;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 70:
							num = (short)1973420096;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 71:
							num5 = this.c(A_0, ref this.k);
							num = (short)1575682103;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 72:
							if (this.h)
							{
								num = (short)607322123;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1415839744;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 73:
							if (!global::ASK.Core.KeyRecordSet.a(this.b))
							{
								num = (short)458031145;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							num5 = 2684387329U;
							flag = false;
							num = (short)1534656517;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 74:
							goto IL_C77;
						case 75:
							if (num5 == 3758129160U)
							{
								num = (short)640942120;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_358;
						case 76:
							goto IL_C77;
						}
						goto IL_1E3;
						IL_319:
						num = (short)1413742616;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_358:
						num = (short)1903362113;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_395:
						flag4 = flag3;
						num = (short)1252589602;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_3D3:
						num = (short)578945074;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_40D:
						num = (short)471531536;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_4CA:
						num = (short)2011234314;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_532:
						num = (short)1324351502;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_C77:
						num = (short)114491407;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_C90:
					goto IL_CB0;
					IL_1E3:
					A_0.OpenNonMotoBtn(A_3);
					flag2 = true;
					this.b = this.a(A_0, -1);
					this.c = A_0.GetROMSerialNum();
					this.f = this.c(A_0);
					num = (short)242090057;
					num4 = (int)((global::System.IntPtr)num);
					goto IL_A8;
				}
				catch (global::System.Exception innerException)
				{
					A_0.CloseButton();
					throw new global::System.Exception(global::ASK.Core.StatusMsg.b("瀾ㅀ♂⭄杆ୈ㹊㥌㭎㹐㵒畔ㅖ㡘㉚ㅜ㩞ՠ奢䕤", a_), innerException);
				}
				IL_CB0:
				num = (short)1551761409;
				if (num != 0)
				{
				}
				return num5;
			}
			}
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00016378 File Offset: 0x00014578
		private bool e(global::RMIBtnWrapperLib.IIBtnWrapper A_0)
		{
			bool result = false;
			short num;
			try
			{
				num = (short)1131085825;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_4D;
				}
				int num2;
				string text;
				for (;;)
				{
					IL_37:
					switch (num2)
					{
					case 0:
						goto IL_F8;
					case 1:
						result = (text == this.b);
						num = (short)915013632;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_111;
					case 3:
					{
						num = (short)418321943;
						short num3 = num;
						num = (short)1589253655;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)553254912;
							if (num != 0)
							{
							}
							if (text == null)
							{
								goto IL_F8;
							}
							break;
						}
						num = (short)1727201281;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_4D;
					IL_F8:
					num = (short)1338441730;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_111:
				goto IL_114;
				IL_4D:
				text = this.a(A_0, -1);
				num = (short)1310261251;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_37;
			}
			catch (global::System.Exception ex)
			{
				throw ex;
			}
			IL_114:
			num = (short)146341888;
			short num4 = num;
			return result;
		}

		// Token: 0x060000DE RID: 222 RVA: 0x000164E0 File Offset: 0x000146E0
		private uint b(global::RMIBtnWrapperLib.IIBtnWrapper A_0, out string A_1)
		{
			bool flag = false;
			uint num = 0U;
			A_1 = null;
			short num2;
			try
			{
				num2 = (short)1636433922;
				int num3 = (int)((global::System.IntPtr)num2);
				for (;;)
				{
					num2 = (short)897056769;
					if (num2 != 0)
					{
					}
					switch (num3)
					{
					case 0:
						goto IL_1B9;
					case 1:
						goto IL_185;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_7E;
						}
						continue;
					case 3:
						num = this.GetPswdFromIBtn(A_0, ref A_1);
						num2 = (short)1563688960;
						num3 = (int)((global::System.IntPtr)num2);
						continue;
					case 4:
						goto IL_1D2;
					case 5:
						if (flag)
						{
							num2 = (short)1757675523;
							num3 = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_1B9;
					case 6:
						num2 = (short)496304133;
						num3 = (int)((global::System.IntPtr)num2);
						continue;
					case 7:
						if (num == 0U)
						{
							num2 = (short)2076704774;
							num3 = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_1B9;
					case 8:
					{
						num2 = (short)2053757957;
						short num4 = num2;
						num2 = (short)560585733;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							num2 = (short)845742080;
							if (num2 != 0)
							{
							}
							goto IL_185;
						}
						break;
					}
					case 9:
						flag = this.a(A_0);
						num2 = (short)216530945;
						num3 = (int)((global::System.IntPtr)num2);
						continue;
					}
					IL_7E:
					if (this.d(A_0))
					{
						num2 = (short)1113849865;
						num3 = (int)((global::System.IntPtr)num2);
						continue;
					}
					num = 3758129160U;
					num2 = (short)1859518472;
					num3 = (int)((global::System.IntPtr)num2);
					continue;
					IL_185:
					num2 = (short)2014511111;
					num3 = (int)((global::System.IntPtr)num2);
					continue;
					IL_1B9:
					num2 = (short)1124204548;
					num3 = (int)((global::System.IntPtr)num2);
				}
				IL_1D2:;
			}
			catch
			{
				num = 3758129154U;
			}
			num2 = (short)711458816;
			short num5 = num2;
			return num;
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00016710 File Offset: 0x00014910
		private bool d(global::RMIBtnWrapperLib.IIBtnWrapper A_0)
		{
			short num = (short)2085552129;
			if (num != 0)
			{
			}
			num = (short)1093218818;
			short num2 = num;
			num = (short)1047802370;
			switch (num2 == num)
			{
			}
			num = (short)904069120;
			short num3 = num;
			num = (short)629800960;
			if (num != 0)
			{
			}
			bool flag = this.a(A_0, 0, null);
			if (flag)
			{
				this.j = true;
				return flag;
			}
			this.j = false;
			return flag;
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x000167D4 File Offset: 0x000149D4
		private uint a(global::RMIBtnWrapperLib.IIBtnWrapper A_0, out global::ASK.Interface.KeyExpirationType A_1, out short A_2, out short A_3, out short A_4, out int A_5, out short A_6)
		{
			int a_ = 8;
			short num = (short)144310273;
			if (num != 0)
			{
			}
			num = (short)75497472;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)1282080768;
				short num3 = num;
				A_1 = global::ASK.Interface.KeyExpirationType.Date;
				A_2 = 0;
				A_3 = 0;
				A_4 = 0;
				A_6 = 0;
				uint num4 = 0U;
				A_5 = 0;
				try
				{
					switch (0)
					{
					case 0:
						goto IL_F1;
					}
					short num6;
					byte[] sourceArray;
					for (;;)
					{
						IL_9A:
						switch (num2)
						{
						case 0:
							goto IL_24F;
						case 1:
							goto IL_498;
						case 2:
						{
							byte[] array;
							int num5;
							byte b = global::ASK.Core.Global.calculateCRC8(array, (short)(num5 - 1), 0);
							num = (short)756482060;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
						{
							int num5 = (int)num6;
							byte[] array = new byte[(int)num6];
							global::System.Array.Copy(sourceArray, array, (int)num6);
							num = (short)397672461;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
						{
							byte[] array;
							int num5;
							byte b;
							if (b != array[num5 - 1])
							{
								num = (short)250937353;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num4 = this.a(array, out A_1, out A_2, out A_3, out A_4, out A_6);
							A_2 = (short)global::ASK.Core.Constants.ReferenceDate.AddDays((double)A_2).Subtract(global::System.DateTime.Today).Days;
							this.r = global::System.DateTime.Today.AddDays((double)A_2);
							num = (short)2077687819;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 5:
							if (this.a(A_0, 0, ref sourceArray, out num6))
							{
								num = (short)31326211;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_498;
						case 6:
							goto IL_24F;
						case 7:
						{
							if (A_5 < 3)
							{
								num = (short)1450508290;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							byte[] array;
							int num5;
							byte b = global::ASK.Core.Global.calculateCRC8(array, (short)(num5 - 2), 0);
							num = (short)319488008;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 8:
							goto IL_2C2;
						case 9:
							global::System.Diagnostics.Trace.WriteLine(global::ASK.Core.StatusMsg.b("݃ᑅେ橉⡋⅍㕏⅑㩓煕ⱗ穙ㅛ㽝ᑟšౣ䙥ὧɩ५m偯qᅳ᝵ᱷ婹ㅻ㽽퍿즁ꪃ뚅ꢇ뎑떓鲕", a_));
							num4 = 3758129156U;
							num = (short)1158283279;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 10:
							if (num4 == 0U)
							{
								num = (short)1723727891;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_498;
						case 11:
							if (A_2 < 0)
							{
								num = (short)1081016336;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_34A;
						case 12:
						{
							num = (short)902929023;
							short num7 = num;
							num = (short)190683775;
							switch ((num7 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_34A;
							default:
								num = (short)1524891648;
								if (num != 0)
								{
								}
								goto IL_2C2;
							}
							break;
						}
						case 13:
							if (9 > num6 - 2)
							{
								num = (short)1134821393;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_13A;
						case 14:
							goto IL_4B1;
						case 15:
							goto IL_498;
						case 16:
							this.s = -1;
							num = (short)1677131782;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 17:
							num4 = 3758129161U;
							num = (short)1259274258;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 18:
							goto IL_13A;
						case 19:
						{
							byte[] array;
							A_5 = (int)array[9];
							byte b = 0;
							num = (short)1758461959;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						goto IL_F1;
						IL_13A:
						num = (short)268566538;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_24F:
						global::System.TimeSpan timeSpan = new global::System.TimeSpan(23, 59, 59);
						this.r = this.r.Date + timeSpan;
						this.LastDateProgrammed = global::ASK.Core.Constants.ReferenceDate.AddDays((double)A_4);
						this.LastDateProgrammed = this.LastDateProgrammed.AddHours((double)A_6);
						num = (short)1684865025;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_2C2:
						num = (short)1022296068;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_34A:
						this.s = A_2;
						num = (short)142409728;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_498:
						num = (short)1166409742;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_4B1:
					return num4;
					IL_F1:
					sourceArray = null;
					num6 = 50;
					num = (short)735379461;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_9A;
				}
				catch (global::System.Exception ex)
				{
					num4 = 3758129154U;
					throw ex;
				}
				return num4;
			}
			}
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00016CB8 File Offset: 0x00014EB8
		private uint a(byte[] A_0, out global::ASK.Interface.KeyExpirationType A_1, out short A_2, out short A_3, out short A_4, out short A_5)
		{
			int a_ = 17;
			short num = (short)489095168;
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
				byte[] array;
				int num5;
				for (;;)
				{
					IL_30:
					switch (num2)
					{
					case 0:
						goto IL_1BC;
					case 1:
						if (A_0[9] > 4)
						{
							num = (short)1001652230;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1F8;
					case 2:
						goto IL_1BC;
					case 3:
					{
						int num3;
						if (num3 >= 8)
						{
							num = (short)607977477;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int num4;
						array[num3] = A_0[num4 + num3];
						num3++;
						num = (short)1107099650;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
					{
						array = new byte[8];
						int num4 = num5 - 9;
						int num3 = 0;
						num = (short)581894144;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						goto IL_1F6;
					case 6:
					{
						num = (short)1903034368;
						short num6 = num;
						num = (short)1923496033;
						short num7 = num;
						num = (short)1899116641;
						switch ((num7 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1F8;
						default:
							num = (short)1380122625;
							if (num != 0)
							{
							}
							num = (short)1290862592;
							if (num != 0)
							{
							}
							num5 = A_0.Length;
							num = (short)985989124;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					goto IL_53;
					IL_1BC:
					num = (short)1879441411;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1F6:
				A_1 = (global::ASK.Interface.KeyExpirationType)array[0];
				A_2 = (short)(array[1] << 8);
				A_2 |= (short)array[2];
				A_3 = (short)(array[3] << 8);
				A_3 |= (short)array[4];
				A_4 = (short)(array[5] << 8);
				A_4 |= (short)array[6];
				A_5 = (short)array[7];
				uint result;
				return result;
				IL_1F8:
				result = 2684387342U;
				global::System.Diagnostics.Trace.WriteLine(global::ASK.Core.StatusMsg.b("᥌❎㑐獒ᑔ㍖⽘㩚㍜㱞Ѡݢ䕤ⱦ౨ቪ䵬ͮၰੲᩴɶ൸孺୼᩾ꮊﲎ놐杖릘ﮞ趠莢솤좦잨貪\ud9ac辮슰욲어잶횸즺즼龾꓀믂뗄껆믈꫊만ꛎ뻐뷒돖룘꿚룜￞胠跢臤쟦駨駪苬裮菰鋲飴髶郸闺髼\udffe戀氂瀄椆紈渊缌ℎᬐ", a_));
				return result;
				IL_53:
				result = 0U;
				A_2 = 0;
				A_3 = 0;
				A_4 = 0;
				A_5 = 0;
				A_1 = global::ASK.Interface.KeyExpirationType.Date;
				num5 = 0;
				num = (short)144441345;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00016F20 File Offset: 0x00015120
		private uint a(string A_0)
		{
			int a_ = 5;
			switch (0)
			{
			case 0:
				goto IL_5D;
			}
			int num;
			int num2;
			short num3;
			uint num4;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					if (num2 > 3)
					{
						num3 = (short)270794758;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					return num4;
				case 1:
				{
					string text;
					if (this.a(ref text))
					{
						goto IL_219;
					}
					num4 = 2684387335U;
					num3 = (short)1525743626;
					num = (int)((global::System.IntPtr)num3);
					continue;
				}
				case 2:
					goto IL_237;
				case 3:
					num3 = (short)850722831;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 4:
					if (num2 < 3)
					{
						num3 = (short)659619845;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_237;
				case 5:
					global::System.Windows.MessageBox.Show(global::Motorola.CommonCPS.ResourceRepository.Resources.ResourceManager.GetString(global::ASK.Core.StatusMsg.b("ࡀⵂ♄⡆㭈㥊⡌ⱎ═౒Ք㙖⩘⡚⩜ぞ፠ݢ㩤呦㙨㽪Ѭɮᑰr", a_), global::Motorola.CommonCPS.ResourceRepository.Resources.Culture), global::Motorola.CommonCPS.ResourceRepository.Resources.ResourceManager.GetString(global::ASK.Core.StatusMsg.b("ᙀ≂㝄⥆⁈╊⩌၎ᡐ㝒", a_), global::Motorola.CommonCPS.ResourceRepository.Resources.Culture), global::System.Windows.MessageBoxButton.OK, global::System.Windows.MessageBoxImage.Exclamation, global::System.Windows.MessageBoxResult.OK, this.v);
					num3 = (short)985726992;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 6:
					global::ASK.Core.KeyRecordSet.b(this.b);
					num4 = 2684387332U;
					num3 = (short)1334902793;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 7:
					num3 = (short)198574081;
					if (num3 != 0)
					{
					}
					if (num4 != 2684387335U)
					{
						num3 = (short)1736900619;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					return num4;
				case 8:
				{
					if (num2++ >= 3)
					{
						num3 = (short)1368457228;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					string text = null;
					num3 = (short)1914503169;
					num = (int)((global::System.IntPtr)num3);
					continue;
				}
				case 9:
					return num4;
				case 10:
				{
					num3 = (short)595281662;
					short num5 = num3;
					num3 = (short)367412990;
					switch ((num5 == num3) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_219;
					default:
						num3 = (short)1161756672;
						if (num3 != 0)
						{
						}
						goto IL_7B;
					}
					break;
				}
				case 11:
					num3 = (short)1722023936;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 12:
					goto IL_7B;
				case 13:
					this.n = true;
					global::ASK.Core.KeyRecordSet.d(this.b);
					num3 = (short)1698037774;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 14:
					goto IL_7B;
				case 15:
				{
					num3 = (short)1499529216;
					short num6 = num3;
					string text;
					if (text.ToLower() == A_0.ToLower())
					{
						num3 = (short)1804926989;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					num3 = (short)659554308;
					num = (int)((global::System.IntPtr)num3);
					continue;
				}
				case 16:
					goto IL_237;
				}
				goto IL_5D;
				IL_7B:
				num3 = (short)393805831;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_219:
				num3 = (short)1502216195;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_237:
				num3 = (short)468189192;
				num = (int)((global::System.IntPtr)num3);
			}
			return num4;
			IL_5D:
			num4 = 0U;
			num2 = 0;
			num3 = (short)637730818;
			num = (int)((global::System.IntPtr)num3);
			goto IL_13;
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x000172AC File Offset: 0x000154AC
		public uint GetPswdFromIBtn(global::RMIBtnWrapperLib.IIBtnWrapper spIBtn, ref string strPassword)
		{
			int a_ = 3;
			short num = (short)671744000;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				strPassword = null;
				uint num3 = 0U;
				try
				{
					switch (0)
					{
					case 0:
						goto IL_7F;
					}
					byte[] sourceArray;
					short num4;
					for (;;)
					{
						IL_38:
						switch (num2)
						{
						case 0:
							goto IL_2F2;
						case 1:
							if (this.a(spIBtn, 0, ref sourceArray, out num4))
							{
								num = (short)187301894;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2F2;
						case 2:
						{
							num = (short)1128113673;
							short num5 = num;
							num = (short)921740809;
							switch ((num5 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								continue;
							default:
								num = (short)799801344;
								if (num != 0)
								{
								}
								goto IL_171;
							}
							break;
						}
						case 3:
							global::System.Diagnostics.Trace.WriteLine(global::ASK.Core.StatusMsg.b("簾ፀB敄⍆♈⹊㹌ⅎ癐❒畔㩖㡘⽚㹜㝞䅠ᑢ൤ɦݨ䭪Ὤ੮ၰᝲ啴㩶㡸⡺㙼兾놀ꎂ게꺎鮐", a_));
							num3 = 3758129156U;
							num = (short)1464336399;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
						{
							byte[] array;
							int num6;
							byte b = global::ASK.Core.Global.calculateCRC8(array, (short)(num6 - 1), 0);
							num = (short)915275778;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 5:
						{
							byte[] array;
							int num6;
							byte b;
							if (b != array[num6 - 1])
							{
								num = (short)427163651;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num3 = this.a(ref strPassword, array);
							num = (short)2008023040;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 6:
						{
							int num6 = (int)num4;
							byte[] array = new byte[(int)num4];
							global::System.Array.Copy(sourceArray, array, (int)num4);
							num = (short)1559101447;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 7:
							if (9 > num4 - 2)
							{
								num = (short)1384251404;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_24D;
						case 8:
							num = (short)1864499213;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 9:
							goto IL_171;
						case 10:
							goto IL_24D;
						case 11:
							if (num3 == 0U)
							{
								num = (short)761462792;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2F2;
						case 12:
							num3 = 3758129161U;
							num = (short)500563978;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 13:
						{
							byte[] array;
							int num7 = (int)array[9];
							byte b = 0;
							if (num7 < 3)
							{
								num = (short)699203588;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							int num6;
							b = global::ASK.Core.Global.calculateCRC8(array, (short)(num6 - 2), 0);
							num = (short)939917321;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 14:
							goto IL_30B;
						case 15:
							goto IL_2F2;
						}
						goto IL_7F;
						IL_171:
						num = (short)1329201157;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_24D:
						num = (short)1322647563;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_2F2:
						num = (short)361562126;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_30B:
					goto IL_314;
					IL_7F:
					sourceArray = null;
					num4 = 50;
					num = (short)683016193;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_38;
				}
				catch (global::System.Exception ex)
				{
					num3 = 3758129154U;
					throw ex;
				}
				IL_314:
				num = (short)700710912;
				short num8 = num;
				num = (short)589234177;
				if (num != 0)
				{
				}
				return num3;
			}
			}
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x0001763C File Offset: 0x0001583C
		private uint a(ref string A_0, byte[] A_1)
		{
			int a_ = 13;
			short num = (short)437256192;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				int num6;
				uint result;
				switch (0)
				{
				case 0:
					break;
				default:
				{
					string text;
					for (;;)
					{
						IL_31:
						int num3;
						int num4;
						switch (num2)
						{
						case 0:
							goto IL_2A3;
						case 1:
							goto IL_269;
						case 2:
							text = null;
							num3 = 12;
							num4 = 0;
							num = (short)1027014660;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							if (A_1[9] >= 3)
							{
								num = (short)1810300935;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_199;
						case 4:
							goto IL_269;
						case 5:
							goto IL_1B7;
						case 6:
						{
							num = (short)924858189;
							short num5 = num;
							num = (short)544094029;
							switch ((num5 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_70;
							default:
								num = (short)1899495424;
								if (num != 0)
								{
								}
								num = (short)116785163;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 7:
							num6 = (int)A_1[11];
							num = (short)1834942466;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
							if (num4 >= (num6 + 1) / 2)
							{
								num = (short)17104896;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)933232650;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 9:
							num = (short)1126236161;
							if (num != 0)
							{
							}
							goto IL_1FD;
						case 10:
							if (num4 == (num6 + 1) / 2 - 1)
							{
								num = (short)1816330246;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1FD;
						case 11:
							if (num6 % 2 == 0)
							{
								num = (short)1498415113;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							text += string.Format(global::ASK.Core.StatusMsg.b("㉈筊睌㝎ⱐ", a_), A_1[num3 + num4]);
							num = (short)1901592588;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 12:
							goto IL_1B7;
						}
						goto IL_6C;
						IL_1B7:
						num4++;
						num = (short)1793785857;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_1FD:
						text += string.Format(global::ASK.Core.StatusMsg.b("㉈筊睌㝎捐⹒", a_), A_1[num3 + num4]);
						num = (short)1466957824;
						short num7 = num;
						num = (short)1162674181;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_269:
						num = (short)623181832;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_199:
					result = 2684387330U;
					global::System.Diagnostics.Trace.WriteLine(global::ASK.Core.StatusMsg.b("ᵈ⍊⡌潎ၐ㝒⍔㙖㝘㡚㡜㭞䅠⡢dṦ䥨ݪ౬᙮ṰٲŴ坶ླྀṺོ౾Ꞇ권ﮎﺐﲒ떔ﾚ놜뾞얠첢쮤肦\udda8讪\udeac\udaae솰쎲\udab4얶춸鮺즼ힾ꓀뗄ꛆ뫈룊뫌ꃎꏐ럒Ꟗꯘ듚꧜뫞苠韢賤裦蟨엪", a_));
					A_0 = null;
					return result;
					IL_2A3:
					A_0 = text;
					return result;
				}
				}
				IL_6C:
				result = 0U;
				num6 = 0;
				IL_70:
				num = (short)530513923;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x0001795C File Offset: 0x00015B5C
		internal uint f(global::RMIBtnWrapperLib.IIBtnWrapper A_0)
		{
			short num = (short)1906704384;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				short a_;
				uint num3;
				global::ASK.Interface.KeyExpirationType keyExpirationType;
				short num5;
				short num6;
				short num7;
				switch (0)
				{
				case 0:
					break;
				default:
					for (;;)
					{
						IL_28:
						switch (num2)
						{
						case 0:
							this.ProgrammingCount = a_;
							num = (short)950468632;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							return num3;
						case 2:
							return num3;
						case 3:
						{
							if (this.f == global::ASK.Interface.HardwareKeyFamily.DS1994)
							{
								num = (short)1433731082;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							int num4 = 0;
							num3 = this.a(A_0, out keyExpirationType, out num5, out a_, out num6, out num4, out num7);
							num = (short)1281163268;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
							goto IL_333;
						case 5:
							num = (short)679084051;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							if (num3 == 2684387342U)
							{
								num = (short)2040332293;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return num3;
						case 7:
							num = (short)1857749008;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
						{
							num = (short)784855454;
							short num8 = num;
							num = (short)841347486;
							switch ((num8 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_B6;
							default:
								num = (short)892796928;
								if (num != 0)
								{
								}
								if (this.ProgrammingCount < 1)
								{
									num = (short)1350303762;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								return num3;
							}
							break;
						}
						case 9:
							return num3;
						case 10:
							A_0.GetNumDaysLeft(ref this.p);
							this.s = this.p;
							this.r = global::System.DateTime.Today.AddHours(23.0).AddMinutes(59.0).AddSeconds(59.0);
							this.r = this.r.AddDays((double)this.p);
							num = (short)1268580369;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 11:
							num = (short)245104649;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 12:
							this.q = true;
							num3 = 3758129164U;
							num = (short)1809186841;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 13:
						{
							num = (short)1699807232;
							short num9 = num;
							this.q = true;
							num3 = 3758129164U;
							num = (short)1936850945;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 14:
							if (this.ProgrammingCount < 1)
							{
								num = (short)729415693;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return num3;
						case 15:
							goto IL_2A6;
						case 16:
							if (this.f == global::ASK.Interface.HardwareKeyFamily.DS1996)
							{
								num = (short)1591738383;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return num3;
						case 17:
							goto IL_333;
						case 18:
							goto IL_F9;
						case 19:
							if (this.f != global::ASK.Interface.HardwareKeyFamily.DS1963)
							{
								num = (short)1202257927;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2A6;
						case 20:
							num = (short)1916076040;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 21:
							if (!(this.r < global::System.DateTime.Now))
							{
								num = (short)1410990100;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_F9;
						case 22:
							return num3;
						case 23:
							if (this.r < global::System.DateTime.Now)
							{
								num = (short)672792588;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return num3;
						case 24:
							switch (keyExpirationType)
							{
							case global::ASK.Interface.KeyExpirationType.Date:
								num = (short)1482096663;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case global::ASK.Interface.KeyExpirationType.Counter:
								num = (short)1582628878;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case global::ASK.Interface.KeyExpirationType.Both:
								num = (short)291242005;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							default:
								num = (short)1078198283;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 25:
							return num3;
						case 26:
							if (num3 == 0U)
							{
								num = (short)817037312;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1715142657;
							if (num != 0)
							{
							}
							num = (short)1521876998;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9B;
						IL_F9:
						this.q = true;
						num3 = 3758129164U;
						num = (short)1020067862;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_2A6:
						num3 = 0U;
						num = (short)1758068738;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_333:
						num = (short)257425434;
						num2 = (int)((global::System.IntPtr)num);
					}
					return num3;
				}
				IL_9B:
				num5 = 0;
				a_ = 0;
				num6 = 0;
				num7 = 0;
				keyExpirationType = global::ASK.Interface.KeyExpirationType.Date;
				num3 = 0U;
				this.f = this.c(A_0);
				IL_B6:
				num = (short)464584707;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00017EF4 File Offset: 0x000160F4
		private uint a(global::RMIBtnWrapperLib.IIBtnWrapper A_0, int A_1, out short A_2)
		{
			int a_ = 6;
			short num = (short)1184934139;
			short num2 = num;
			num = (short)1296148731;
			uint num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				return num3;
			case 1:
				break;
			default:
			{
				num = (short)1820721152;
				short num4 = num;
				break;
			}
			}
			num = (short)1326383104;
			if (num != 0)
			{
			}
			num = (short)1310392320;
			int num5 = (int)num;
			switch (num5)
			{
			default:
			{
				byte[] array = null;
				short num6 = 50;
				num3 = 0U;
				A_2 = 0;
				try
				{
					num = (short)2114912257;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_11B;
					}
					byte[] array2;
					int num7;
					for (;;)
					{
						IL_D8:
						byte b;
						switch (num5)
						{
						case 0:
							goto IL_343;
						case 1:
							if (A_1 == 0)
							{
								num = (short)2090729481;
								num5 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_212;
						case 2:
							goto IL_1B0;
						case 3:
							global::System.Diagnostics.Trace.WriteLine(string.Format(global::ASK.Core.StatusMsg.b("ŁᙃՅ桇⹉⍋⭍⍏㱑獓≕硗㝙㵛⩝͟੡䑣ᅥgཀྵɫ乭ɯ᝱ᕳት塷Ź䱻ͽꁿꮉ궋蒍", a_), this.a(A_1)));
							num3 = 3758129156U;
							num = (short)781516814;
							num5 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							if (b != array2[num7 - 1])
							{
								num = (short)1885667331;
								num5 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_32B;
						case 5:
							if (9 > num6 - 2)
							{
								num = (short)1775304714;
								num5 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_172;
						case 6:
							b = 0;
							A_2 = (short)array[9];
							num = (short)314179585;
							num5 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
							if (A_2 < 3)
							{
								num = (short)1471152139;
								num5 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_212;
						case 8:
							goto IL_172;
						case 9:
							num = (short)532742151;
							num5 = (int)((global::System.IntPtr)num);
							continue;
						case 10:
							num3 = 3758129161U;
							num = (short)1253965832;
							num5 = (int)((global::System.IntPtr)num);
							continue;
						case 11:
							b = global::ASK.Core.Global.calculateCRC8(array2, (short)(num7 - 1), 0);
							num = (short)81199117;
							num5 = (int)((global::System.IntPtr)num);
							continue;
						case 12:
							if (num3 == 0U)
							{
								num = (short)789905414;
								num5 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_32B;
						case 13:
							goto IL_1B0;
						case 14:
							goto IL_32B;
						}
						goto IL_11B;
						IL_172:
						num = (short)1475411980;
						num5 = (int)((global::System.IntPtr)num);
						continue;
						IL_1B0:
						num = (short)1451425796;
						num5 = (int)((global::System.IntPtr)num);
						continue;
						IL_212:
						b = global::ASK.Core.Global.calculateCRC8(array2, (short)(num7 - 2), 0);
						num = (short)1582694402;
						num5 = (int)((global::System.IntPtr)num);
						continue;
						IL_32B:
						num = (short)984416256;
						num5 = (int)((global::System.IntPtr)num);
					}
					IL_343:
					break;
					IL_11B:
					this.a(A_0, A_1, ref array, out num6);
					array2 = new byte[(int)num6];
					global::System.Array.Copy(array, array2, (int)num6);
					num7 = (int)num6;
					num = (short)281214981;
					num5 = (int)((global::System.IntPtr)num);
					goto IL_D8;
				}
				catch (global::System.Exception ex)
				{
					num3 = 3758129154U;
					throw ex;
				}
				break;
			}
			}
			return num3;
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x0001826C File Offset: 0x0001646C
		private bool a(ref string A_0)
		{
			short num = (short)2064973824;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_50;
				}
				bool result;
				global::ASK.Core.IBtnAccessPasswordWnd btnAccessPasswordWnd;
				for (;;)
				{
					IL_29:
					bool? flag;
					bool flag2;
					switch (num2)
					{
					case 0:
						if (flag.GetValueOrDefault() == flag2 & flag != null)
						{
							num = (short)488833026;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 1:
						if (global::System.Windows.Application.Current.MainWindow != null)
						{
							num = (short)1310916614;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F5;
					case 2:
						A_0 = btnAccessPasswordWnd.b.Password;
						result = true;
						num = (short)790888452;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (global::System.Windows.Application.Current != null)
						{
							num = (short)684916741;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F5;
					case 4:
						return result;
					case 5:
						goto IL_F0;
					case 6:
					{
						num = (short)149380030;
						short num3 = num;
						num = (short)495344574;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_F0;
						default:
							num = (short)876544000;
							if (num != 0)
							{
							}
							num = (short)1425866753;
							if (num != 0)
							{
							}
							btnAccessPasswordWnd.Owner = global::System.Windows.Application.Current.MainWindow;
							num = (short)810352647;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 7:
						goto IL_F5;
					}
					goto IL_50;
					IL_F0:
					num = (short)1051131905;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_F5:
					flag = btnAccessPasswordWnd.ShowDialog();
					flag2 = true;
					num = (short)1308229632;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_50:
				num = (short)656343040;
				short num4 = num;
				result = false;
				btnAccessPasswordWnd = new global::ASK.Core.IBtnAccessPasswordWnd();
				btnAccessPasswordWnd.WindowStyle = global::System.Windows.WindowStyle.ToolWindow;
				btnAccessPasswordWnd.Background = global::System.Windows.Media.Brushes.LightGray;
				btnAccessPasswordWnd.Title = global::Motorola.CommonCPS.ResourceRepository.Resources.Enter_Access_Password.AcpStringFormat(new object[]
				{
					this.b
				});
				btnAccessPasswordWnd.WindowStartupLocation = global::System.Windows.WindowStartupLocation.CenterScreen;
				num = (short)854589443;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_29;
			}
			}
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x000184D8 File Offset: 0x000166D8
		internal uint c(global::RMIBtnWrapperLib.IIBtnWrapper A_0, ref bool A_1)
		{
			int a_ = 13;
			short num = (short)232521728;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_6D;
				}
				uint num5;
				short num6;
				short num7;
				short num8;
				for (;;)
				{
					IL_32:
					switch (num2)
					{
					case 0:
					{
						num = (short)855302511;
						short num3 = num;
						num = (short)1683677551;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_117;
						case 1:
							break;
						default:
						{
							num = (short)1635057664;
							short num4 = num;
							break;
						}
						}
						num = (short)2103902208;
						if (num != 0)
						{
						}
						goto IL_1A7;
					}
					case 1:
						if (num5 == 0U)
						{
							num = (short)1934491654;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1A7;
					case 2:
						if (num5 == 0U)
						{
							num = (short)1225129996;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_29B;
					case 3:
						if (num5 == 0U)
						{
							num = (short)1652228106;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D2;
					case 4:
						goto IL_D2;
					case 5:
						goto IL_2B3;
					case 6:
						num5 = this.a(A_0, 2, out num6);
						goto IL_117;
					case 7:
						num = (short)195756033;
						if (num != 0)
						{
						}
						num5 = this.a(A_0, 4, out num7);
						num = (short)1856372744;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						goto IL_29B;
					case 9:
					{
						string fileName;
						if (A_0.DoesFileExist(fileName))
						{
							num = (short)744620039;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num7 = 3;
						num = (short)1867055115;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						num5 = this.a(A_0, 1, out num8);
						num = (short)1116930052;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						goto IL_29B;
					case 12:
					{
						string fileName = global::ASK.Core.StatusMsg.b("وὊౌ὎罐捒", a_);
						num = (short)378994697;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_6D;
					IL_D2:
					num6 = -1;
					num = (short)1726545921;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_117:
					num = (short)791412736;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1A7:
					num7 = -1;
					num = (short)735772674;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_29B:
					num = (short)35979269;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_2B3:
				short num9;
				A_1 = (num9 < 3 || num8 < 3 || num6 < 3 || num7 < 3);
				return num5;
				IL_6D:
				num9 = -1;
				num5 = this.a(A_0, 0, out num9);
				num8 = -1;
				num = (short)1879048195;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_32;
			}
			}
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x000187B8 File Offset: 0x000169B8
		public bool WriteiBtnKey(global::RMIBtnWrapperLib.IIBtnWrapper spIBtn, ref bool bOpen, bool bValidatePassword, int iKeyType, global::ASK.Interface.OpenMode iOpenMode, global::ASK.Core.AccessLevelDataRecordSet pRsAccess, out global::ASK.Core.StatusMsg statusMessage)
		{
			short num = (short)2134316888;
			short num2 = num;
			num = (short)1095112536;
			bool result;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				return result;
			case 1:
				break;
			default:
			{
				num = (short)609943552;
				short num3 = num;
				break;
			}
			}
			num = (short)431554561;
			if (num != 0)
			{
			}
			num = (short)1855979520;
			if (num != 0)
			{
			}
			num = (short)1057488896;
			int num4 = (int)num;
			switch (num4)
			{
			default:
			{
				result = false;
				int a_ = 0;
				uint num5 = 0U;
				string message = "";
				try
				{
					switch (0)
					{
					case 0:
						goto IL_F8;
					}
					for (;;)
					{
						IL_D1:
						switch (num4)
						{
						case 0:
							goto IL_1A1;
						case 1:
						{
							string a_2 = this.b(spIBtn);
							result = this.a(spIBtn, a_2, iKeyType, pRsAccess);
							statusMessage = new global::ASK.Core.StatusMsg(global::ASK.Core.AskStatusType.Info, message, num5);
							num = (short)1384644614;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							goto IL_213;
						case 3:
							if (num5 == 2684387338U)
							{
								num = (short)1666842629;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1A1;
						case 4:
							goto IL_22B;
						case 5:
							num5 = 0U;
							num = (short)1750859776;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							goto IL_213;
						case 7:
							if (num5 == 0U)
							{
								num = (short)262930433;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							num5 = 1610645509U;
							message = global::Motorola.CommonCPS.ResourceRepository.Resources.iBtn_System_key.AcpStringFormat(new object[]
							{
								this.b
							});
							statusMessage = new global::ASK.Core.StatusMsg(global::ASK.Core.AskStatusType.Error, message, num5);
							num = (short)298319874;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F8;
						IL_1A1:
						num = (short)748945415;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_213:
						num = (short)105906180;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_22B:
					break;
					IL_F8:
					num5 = this.a(spIBtn, false, bValidatePassword, a_, (int)iOpenMode);
					bOpen = true;
					num = (short)415956995;
					num4 = (int)((global::System.IntPtr)num);
					goto IL_D1;
				}
				catch (global::System.Exception ex)
				{
					result = false;
					num5 = 1610645509U;
					statusMessage = new global::ASK.Core.StatusMsg(global::ASK.Core.AskStatusType.Error, ex.Message, num5);
					throw ex;
				}
				break;
			}
			}
			return result;
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00018A30 File Offset: 0x00016C30
		internal bool a(global::RMIBtnWrapperLib.IIBtnWrapper A_0, string A_1, int A_2, global::ASK.Core.AccessLevelDataRecordSet A_3)
		{
			int a_ = 11;
			short num = (short)345899008;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)929628160;
				short num3 = num;
				num = (short)364249089;
				if (num != 0)
				{
				}
				bool flag = false;
				bool result = true;
				try
				{
					switch (0)
					{
					case 0:
						goto IL_322;
					}
					global::System.Collections.Generic.Dictionary<int, global::ASK.Core.AccessRecord> dictionary;
					global::System.Collections.ArrayList arrayList2;
					int num12;
					int length;
					char[] array3;
					global::System.Collections.ArrayList arrayList3;
					global::System.Collections.ArrayList arrayList4;
					for (;;)
					{
						IL_87:
						bool flag2;
						global::AcpCryptoLib.AcpIBtnEncyptDecrpt acpIBtnEncyptDecrpt;
						byte[] array;
						string fileName;
						int num4;
						bool flag3;
						int num6;
						short num7;
						bool flag5;
						int num9;
						byte[] array2;
						byte[] pFileData2;
						short num11;
						byte[] array4;
						int num13;
						bool flag6;
						int num18;
						byte[] array8;
						int num20;
						byte[] pFileData3;
						int num24;
						switch (num2)
						{
						case 0:
							if (flag2)
							{
								num = (short)666304531;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_93D;
						case 1:
							goto IL_1532;
						case 2:
							goto IL_1991;
						case 3:
							goto IL_16F9;
						case 4:
							goto IL_AB1;
						case 5:
							if (!flag)
							{
								num = (short)1171652663;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1532;
						case 6:
							goto IL_93D;
						case 7:
							goto IL_156D;
						case 8:
							goto IL_761;
						case 9:
						{
							byte[] pFileData = null;
							acpIBtnEncyptDecrpt.Encrypt(array, out pFileData);
							A_0.WriteFile(fileName, (short)num4, pFileData);
							num = (short)1687683075;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 10:
							goto IL_51C;
						case 11:
							goto IL_1058;
						case 12:
							goto IL_1953;
						case 13:
							num = (short)1933901960;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 14:
						{
							int num5 = 0;
							num = (short)1773207703;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 15:
						{
							global::System.Collections.ArrayList arrayList = new global::System.Collections.ArrayList();
							global::System.Collections.Generic.Dictionary<int, global::ASK.Core.AccessRecord>.Enumerator enumerator = dictionary.GetEnumerator();
							num = (short)1078788212;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 16:
							num = (short)1690828905;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 17:
							if (flag3)
							{
								num = (short)1308688417;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1F2A;
						case 18:
							if (num6 > (int)num7)
							{
								num = (short)350683255;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1B51;
						case 19:
							num = (short)2051211355;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 20:
							goto IL_36E;
						case 21:
							goto IL_17AD;
						case 22:
							goto IL_11A0;
						case 23:
						{
							bool flag4;
							if (flag4)
							{
								num = (short)1963917412;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Diagnostics.Trace.WriteLine(global::ASK.Core.StatusMsg.b("䵆䁈䉊杌敎筐祒罔絖獘煚睜罞Ⱡぢㅤ㕦䝨孪䵬୮Ṱᙲٴ坶᝸ᑺॼ彾ﮂﶈꖊ권ꖎ뮐릒뾔붖뎘놚랜떞讠ꦢ", a_));
							num = (short)780140554;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 24:
							goto IL_1DDF;
						case 25:
							if (flag3)
							{
								num = (short)127664214;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_156D;
						case 26:
						{
							string fileName2 = global::ASK.Core.StatusMsg.b("੆HᡊὌ慎慐", a_);
							flag = A_0.DoesFileExist(fileName2);
							num = (short)878510091;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 27:
							if (flag5)
							{
								num = (short)1089667219;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_EA0;
						case 28:
						{
							int num8;
							if (num8 >= num9)
							{
								num = (short)1572995080;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							array2[num8] = (byte)arrayList2[num8];
							num8++;
							num = (short)1607860266;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 29:
							goto IL_146C;
						case 30:
							if (!flag)
							{
								num = (short)1352990843;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1953;
						case 31:
							goto IL_15FA;
						case 32:
							if (!flag)
							{
								num = (short)1425932303;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1774;
						case 33:
						{
							short num10;
							num9 = (int)num10;
							num = (short)604569759;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 34:
							if (!flag)
							{
								num = (short)459145358;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1532;
						case 35:
							num = (short)1537540202;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 36:
							if (flag5)
							{
								num = (short)785186851;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							acpIBtnEncyptDecrpt.Encrypt(array2, out pFileData2);
							A_0.WriteFile(fileName, (short)num9, pFileData2);
							num = (short)1275723797;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 37:
							goto IL_F36;
						case 38:
							goto IL_1BFD;
						case 39:
							fileName = global::ASK.Core.StatusMsg.b("੆HᡊὌ慎慐", a_);
							num = (short)2131951776;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 40:
							fileName = global::ASK.Core.StatusMsg.b("੆ᩈὊὌ慎慐", a_);
							A_0.CreateFile(fileName, out num11);
							num = (short)1887502437;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 41:
						{
							if (num12 >= length / 2)
							{
								num = (short)325648541;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							array3[0] = A_1[2 * num12];
							array3[1] = A_1[2 * num12 + 1];
							string arg = new string(array3);
							byte b = byte.Parse(string.Format(global::ASK.Core.StatusMsg.b("㱆祈煊㹌㉎", a_), arg), global::System.Globalization.NumberStyles.HexNumber);
							arrayList2.Insert(num12, b);
							arrayList3.Insert(num12, b);
							arrayList4.Insert(num12, b);
							num12++;
							num = (short)2021720227;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 42:
							goto IL_146C;
						case 43:
							goto IL_42D;
						case 44:
						{
							byte[] array5;
							array4[num13] = array5[num13];
							num = (short)98238534;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 45:
							if (flag6)
							{
								num = (short)904527929;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Diagnostics.Trace.WriteLine(global::ASK.Core.StatusMsg.b("䵆䁈䉊杌敎筐祒罔絖獘煚睜罞╠≢ㅤ♦䝨孪䵬୮Ṱᙲٴ坶᝸ᑺॼ彾ﮂﶈꖊ권ꖎ뮐릒뾔붖뎘놚랜떞讠ꦢ", a_));
							num = (short)1725759652;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 46:
						{
							int num14 = (num14 / 28 + 1) * 28;
							num = (short)162332738;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 47:
						{
							bool flag7 = A_0.DoesFileExist(fileName);
							if (!flag7)
							{
								global::System.Diagnostics.Trace.WriteLine(global::ASK.Core.StatusMsg.b("䵆䁈䉊杌敎筐祒罔絖獘煚睜罞Ⱡ⩢㙤㕦䝨孪䵬୮Ṱᙲٴ坶᝸ᑺॼ彾ﮂﶈꖊ권ꖎ뮐릒뾔붖뎘놚랜떞讠ꦢ", a_));
							}
							fileName = global::ASK.Core.StatusMsg.b("੆ᩈὊὌ慎慐", a_);
							bool flag4;
							if (flag4)
							{
								A_0.DeleteFile(fileName);
								global::System.Diagnostics.Trace.WriteLine(global::ASK.Core.StatusMsg.b("䵆䁈䉊杌敎筐祒罔絖獘煚睜罞╠٢।ɦᵨ๪䵬nᝰ卲㡴⑶⵸⥺卼佾ꆀ킂ﺌﲎ璉릖릘놚랜떞讠覢辤趦莨膪螬ꖮ", a_));
							}
							fileName = global::ASK.Core.StatusMsg.b("ెైቊṌ慎慐", a_);
							if (flag3)
							{
								A_0.DeleteFile(fileName);
								global::System.Diagnostics.Trace.WriteLine(global::ASK.Core.StatusMsg.b("䵆䁈䉊杌敎筐祒罔絖獘煚睜罞╠٢।ɦᵨ๪䵬nᝰ卲㹴㉶⁸⡺卼佾ꆀ킂ﺌﲎ璉릖릘놚랜떞讠覢辤趦莨膪螬ꖮ", a_));
							}
							fileName = global::ASK.Core.StatusMsg.b("͆ࡈὊౌ慎慐", a_);
							if (flag6)
							{
								A_0.DeleteFile(fileName);
								global::System.Diagnostics.Trace.WriteLine(global::ASK.Core.StatusMsg.b("䵆䁈䉊杌敎筐祒罔絖獘煚睜罞╠٢।ɦᵨ๪䵬nᝰ卲ㅴ㙶⵸㩺卼佾ꆀ킂ﺌﲎ璉릖릘놚랜떞讠覢辤趦莨膪螬ꖮ", a_));
							}
							fileName = global::ASK.Core.StatusMsg.b("ࡆᵈ੊ᵌ慎慐", a_);
							if (flag2)
							{
								A_0.DeleteFile(fileName);
								global::System.Diagnostics.Trace.WriteLine(global::ASK.Core.StatusMsg.b("䵆䁈䉊杌敎筐祒罔絖獘煚睜罞╠٢।ɦᵨ๪䵬nᝰ卲㩴⍶㡸⭺卼佾ꆀ킂ﺌﲎ璉릖릘놚랜떞讠覢辤趦莨膪螬ꖮ", a_));
							}
							fileName = global::ASK.Core.StatusMsg.b("੆HᡊὌ慎慐", a_);
							if (flag7)
							{
								num = (short)196722;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_97B;
						}
						case 48:
							if (A_3 != null)
							{
								num = (short)542244907;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1BFD;
						case 49:
							goto IL_15FA;
						case 50:
						{
							bool flag4;
							if (flag4)
							{
								num = (short)1013973074;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1282;
						}
						case 51:
						{
							short num10;
							byte[] array6;
							this.a(A_0, 1, ref array6, out num10);
							num = (short)606470196;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 52:
							goto IL_3D6;
						case 53:
							goto IL_87C;
						case 54:
							if (!flag6)
							{
								num = (short)259063824;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1BFD;
						case 55:
							num = (short)1515061316;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 56:
							goto IL_1B0D;
						case 57:
						{
							byte[] array5;
							short num15;
							this.a(A_0, 2, ref array5, out num15);
							num = (short)35651715;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 58:
							goto IL_1DDF;
						case 59:
							if (!flag)
							{
								num = (short)474808346;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1058;
						case 60:
							goto IL_19F5;
						case 61:
						{
							bool flag4;
							if (flag4)
							{
								num = (short)452919406;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_17AD;
						}
						case 62:
							goto IL_1FAD;
						case 63:
							if (flag5)
							{
								num = (short)389939280;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)875036760;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 64:
							acpIBtnEncyptDecrpt.Encrypt(array2, out pFileData2);
							fileName = global::ASK.Core.StatusMsg.b("ెైቊṌ慎慐", a_);
							A_0.WriteFile(fileName, (short)num9, pFileData2);
							num = (short)31719509;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 65:
							goto IL_AB1;
						case 66:
							goto IL_1A31;
						case 67:
						{
							arrayList2.Insert(8, 3);
							arrayList2.Insert(9, 5);
							byte b2 = (byte)this.d.Count;
							arrayList2.Insert(10, b2);
							byte b3 = global::ASK.Core.Global.CalculateCheckSum((byte[])arrayList2.ToArray(typeof(byte)));
							arrayList2.Add(b3);
							num = (short)33882236;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 68:
							if (A_2 == 5)
							{
								num = (short)112787565;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1464139865;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 69:
						{
							bool flag4;
							if (flag4)
							{
								num = (short)687472680;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_8BC;
						}
						case 70:
							goto IL_1991;
						case 71:
							num = (short)369229841;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 72:
							if (flag5)
							{
								num = (short)1097203756;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							array4[num13] = (byte)arrayList3[num13];
							num = (short)724172802;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 73:
							if (!flag2)
							{
								num = (short)509280269;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_16F9;
						case 74:
						{
							byte[] array7;
							short num16;
							this.a(A_0, 4, ref array7, out num16);
							num = (short)483524673;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 75:
							goto IL_11A0;
						case 76:
							if (this.d.Count == 0)
							{
								num = (short)1262616615;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)288358499;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 77:
						{
							int num17;
							num6 += num17;
							num = (short)620888113;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 78:
						{
							byte b4;
							try
							{
								num = (short)241500165;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
									{
										global::System.Collections.Generic.IEnumerator<global::ASK.Core.IKeyDataRecord> enumerator2;
										if (!enumerator2.MoveNext())
										{
											num = (short)1025441796;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::ASK.Core.AccessRecord accessLevel = ((global::ASK.Core.KeyDataRecord)enumerator2.Current).AccessLevel;
										byte[] fieldCode = accessLevel.FieldCode;
										b4 += 1;
										int primaryKey = accessLevel.PrimaryKey;
										num = (short)2064318466;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 1:
									{
										global::ASK.Core.AccessRecord accessLevel;
										int primaryKey;
										dictionary.Add(primaryKey, accessLevel);
										num = (short)210960387;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 2:
									{
										int primaryKey;
										if (!dictionary.ContainsKey(primaryKey))
										{
											num = (short)389021697;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 4:
										num = (short)2009726982;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 5:
										switch (0)
										{
										case 0:
											goto IL_1C7D;
										}
										continue;
									case 6:
										goto IL_1D6A;
									}
									IL_1C7F:
									num = (short)396820480;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_1C7D:
									goto IL_1C7F;
								}
								IL_1D6A:
								goto IL_CA9;
							}
							finally
							{
								num = (short)2093678593;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.Collections.Generic.IEnumerator<global::ASK.Core.IKeyDataRecord> enumerator2;
									switch (num2)
									{
									case 0:
										enumerator2.Dispose();
										num = (short)1236205570;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_1DA2;
										}
										continue;
									case 2:
										goto IL_1DDC;
									}
									IL_1DA2:
									if (enumerator2 == null)
									{
										break;
									}
									num = (short)2098855936;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_1DDC:;
							}
							goto IL_1DDF;
							IL_CA9:
							byte b5 = (byte)dictionary.Count;
							arrayList2.Insert(10, b4);
							arrayList3.Insert(10, b5);
							arrayList4.Insert(11, b4);
							byte b6 = global::ASK.Core.Global.CalculateCheckSum((byte[])arrayList2.ToArray(typeof(byte)));
							arrayList2.Add(b6);
							byte b7 = global::ASK.Core.Global.CalculateCheckSum((byte[])arrayList3.ToArray(typeof(byte)));
							arrayList3.Add(b7);
							byte b8 = global::ASK.Core.Global.CalculateCheckSum((byte[])arrayList4.ToArray(typeof(byte)));
							arrayList4.Add(b8);
							num = (short)695926876;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 79:
							num = (short)1952317598;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 80:
							goto IL_1733;
						case 81:
							num = (short)1652686896;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 82:
						{
							short num19;
							num18 = (int)num19;
							num = (short)1843069025;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 83:
							num = (short)340983957;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 84:
							goto IL_F36;
						case 85:
							goto IL_603;
						case 86:
							fileName = global::ASK.Core.StatusMsg.b("ెైቊṌ慎慐", a_);
							A_0.CreateFile(fileName, out num11);
							num = (short)182059152;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 87:
							num = (short)733413472;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 88:
							goto IL_2271;
						case 89:
						{
							if (A_2 == 3)
							{
								num = (short)1169424451;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							string fileName3 = global::ASK.Core.StatusMsg.b("੆ᩈὊὌ慎慐", a_);
							flag = A_0.DoesFileExist(fileName3);
							num = (short)1332805691;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 90:
							num = (short)111476873;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 91:
							if (!flag5)
							{
								num = (short)134742099;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1820;
						case 92:
							goto IL_1532;
						case 93:
							goto IL_A75;
						case 94:
						{
							int num5;
							if (num5 >= num18)
							{
								num = (short)801177679;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							byte[] array9;
							array8[num5] = array9[num5];
							num5++;
							num = (short)1104085012;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 95:
							A_0.CreateFile(fileName, out num11);
							num = (short)818610183;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 96:
							if (!flag5)
							{
								num = (short)1935016064;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_42D;
						case 97:
							goto IL_1282;
						case 98:
							num = (short)1693974673;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 99:
							if (A_3 == null)
							{
								num = (short)866648191;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							fileName = global::ASK.Core.StatusMsg.b("ెైቊṌ慎慐", a_);
							num = (short)359006283;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 100:
						{
							short num19;
							byte[] array9;
							this.a(A_0, 3, ref array9, out num19);
							num = (short)545914987;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 101:
							goto IL_8BC;
						case 102:
							if (flag3)
							{
								num = (short)93847603;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Diagnostics.Trace.WriteLine(global::ASK.Core.StatusMsg.b("䵆䁈䉊杌敎筐祒罔絖獘煚睜罞⩠♢㱤㑦䝨孪䵬୮Ṱᙲٴ坶᝸ᑺॼ彾ﮂﶈꖊ권ꖎ뮐릒뾔붖뎘놚랜떞讠ꦢ", a_));
							num = (short)1763770486;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 103:
							goto IL_1820;
						case 104:
							if (flag5)
							{
								num = (short)519831700;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							array[num20] = (byte)arrayList4[num20];
							num = (short)1231290405;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 105:
							if (!flag5)
							{
								num = (short)1031864401;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1BFD;
						case 106:
							if (flag3)
							{
								num = (short)2002452544;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_603;
						case 107:
							goto IL_51C;
						case 108:
							if (num20 >= num4)
							{
								num = (short)1533542409;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1790902376;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 109:
						{
							global::System.Diagnostics.Trace.WriteLine(global::ASK.Core.StatusMsg.b("䵆䁈䉊杌敎筐祒罔絖獘煚睜罞㕠٢ᙤ፦hժ੬佮ᝰᱲݴ坶へ⡺⽼彾ꮀꦂ꾄궆ꎈꆊꞌꖎ뮐릒龔", a_));
							arrayList2.Insert(8, 5);
							arrayList2.Insert(9, 5);
							byte b9 = global::ASK.Core.Global.CalculateCheckSum((byte[])arrayList2.ToArray(typeof(byte)));
							arrayList2.Add(b9);
							num = (short)1262354433;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 110:
							acpIBtnEncyptDecrpt.Encrypt(array8, out pFileData3);
							fileName = global::ASK.Core.StatusMsg.b("੆ᩈὊὌ慎慐", a_);
							A_0.WriteFile(fileName, (short)num18, pFileData3);
							num = (short)603848836;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 111:
							goto IL_8FB;
						case 112:
							goto IL_2117;
						case 113:
						{
							int num14;
							if (num14 % 28 != 0)
							{
								num = (short)387907630;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1A31;
						}
						case 114:
							A_0.DeleteFile(fileName);
							global::System.Diagnostics.Trace.WriteLine(global::ASK.Core.StatusMsg.b("䵆䁈䉊杌敎筐祒罔絖獘煚睜罞╠٢।ɦᵨ๪䵬nᝰ卲㡴㹶⩸⥺卼佾ꆀ킂ﺌﲎ璉릖릘놚랜떞讠覢辤趦莨膪螬ꖮ", a_));
							num = (short)1475805325;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 115:
							goto IL_2117;
						case 116:
						{
							global::System.Collections.ArrayList arrayList;
							try
							{
								num = (short)803733508;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										num = (short)958595074;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
									{
										global::System.Collections.Generic.Dictionary<int, global::ASK.Core.AccessRecord>.Enumerator enumerator;
										if (!enumerator.MoveNext())
										{
											num = (short)2078343168;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::System.Collections.Generic.KeyValuePair<int, global::ASK.Core.AccessRecord> keyValuePair = enumerator.Current;
										arrayList.Add(keyValuePair.Value);
										num = (short)304892221;
										short num21 = num;
										num = (short)1560627517;
										switch ((num21 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											break;
										default:
											num = (short)794689536;
											if (num != 0)
											{
											}
											num = (short)1092747267;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 2:
										goto IL_74E;
									case 4:
										switch (0)
										{
										case 0:
											goto IL_67A;
										}
										continue;
									}
									IL_67C:
									num = (short)705953793;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_67A:
									goto IL_67C;
								}
								IL_74E:
								goto IL_20AF;
							}
							finally
							{
								global::System.Collections.Generic.Dictionary<int, global::ASK.Core.AccessRecord>.Enumerator enumerator;
								((global::System.IDisposable)enumerator).Dispose();
							}
							goto IL_761;
							IL_20AF:
							this.a(ref arrayList2, ref arrayList3, ref arrayList4, arrayList, A_3);
							int num22 = arrayList3.Count;
							int num17 = arrayList2.Count;
							int num14 = arrayList4.Count;
							num = (short)987496573;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 117:
						{
							int num23 = 0;
							num = (short)1964441753;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 118:
							goto IL_3D6;
						case 119:
							flag5 = true;
							num = (short)2096431237;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 120:
						{
							if (A_3 == null)
							{
								num = (short)1363214413;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							int num14;
							int num17;
							int num22;
							num6 += num22 + num17 + num14;
							num = (short)1338179615;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 121:
						{
							if (flag5)
							{
								num = (short)272236634;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							int num8 = 0;
							num = (short)1102774301;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 122:
						{
							int num17 = (num17 / 28 + 1) * 28;
							num = (short)463732892;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 123:
							this.RefreshMASKFileLayout(A_0);
							num = (short)1593376780;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 124:
							goto IL_1532;
						case 125:
						{
							int num22;
							if (num22 % 28 != 0)
							{
								num = (short)478544012;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_8FB;
						}
						case 126:
						{
							int num17;
							if (num17 % 28 != 0)
							{
								num = (short)1017774202;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_EF7;
						}
						case 127:
							fileName = global::ASK.Core.StatusMsg.b("੆ᩈὊὌ慎慐", a_);
							num = (short)2088370198;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 128:
							num = (short)1415970946;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 129:
							if (flag2)
							{
								num = (short)504692810;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Diagnostics.Trace.WriteLine(global::ASK.Core.StatusMsg.b("䵆䁈䉊杌敎筐祒罔絖獘煚睜罞⹠㝢⑤㝦䝨孪䵬୮Ṱᙲٴ坶᝸ᑺॼ彾ﮂﶈꖊ권ꖎ뮐릒뾔붖뎘놚랜떞讠ꦢ", a_));
							num = (short)432209924;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 130:
							if (A_3 == null)
							{
								num = (short)1515454557;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_42D;
						case 131:
							goto IL_4C5;
						case 132:
							goto IL_17AD;
						case 133:
							goto IL_1B51;
						case 134:
							if (!flag5)
							{
								num = (short)1036779615;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)567017541;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 135:
							if (flag5)
							{
								num = (short)1983512647;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1282;
						case 136:
							if (!flag5)
							{
								num = (short)2077753442;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_16F9;
						case 137:
							if (flag3)
							{
								num = (short)907542645;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_19F5;
						case 138:
							goto IL_163E;
						case 139:
						{
							if (this.a(A_0, 0) != A_1)
							{
								num = (short)411304074;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							bool flag4 = false;
							flag3 = false;
							flag6 = false;
							flag2 = false;
							byte[] array9 = null;
							byte[] array6 = null;
							byte[] array5 = null;
							byte[] array7 = null;
							short num19 = 400;
							short num10 = 400;
							short num15 = 400;
							short num16 = 400;
							fileName = null;
							fileName = global::ASK.Core.StatusMsg.b("੆ᩈὊὌ慎慐", a_);
							flag4 = A_0.DoesFileExist(fileName);
							num = (short)386531351;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 140:
						{
							int num22 = (num22 / 28 + 1) * 28;
							num = (short)1996882031;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 141:
							goto IL_97B;
						case 142:
						{
							arrayList2.Insert(8, 1);
							arrayList3.Insert(8, 2);
							arrayList4.Insert(8, 4);
							arrayList2.Insert(9, 5);
							arrayList3.Insert(9, 5);
							arrayList4.Insert(9, 5);
							arrayList4.Insert(10, 0);
							byte b4 = 0;
							global::System.Collections.Generic.IEnumerator<global::ASK.Core.IKeyDataRecord> enumerator2 = this.d.GetEnumerator();
							num = (short)1157169230;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 143:
						{
							byte[] pFileData4 = null;
							acpIBtnEncyptDecrpt.Encrypt(array4, out pFileData4);
							A_0.WriteFile(fileName, (short)num24, pFileData4);
							num = (short)857604134;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 144:
							goto IL_156D;
						case 145:
							if (A_3 != null)
							{
								num = (short)958201959;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_16F9;
						case 146:
							if (num13 >= num24)
							{
								num = (short)1574240399;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1091502152;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 147:
						{
							short num16;
							num4 = (int)num16;
							num = (short)357040283;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 148:
						{
							byte[] array7;
							array[num20] = array7[num20];
							num = (short)1227882580;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 149:
							if (A_3 == null)
							{
								num = (short)766967814;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1820;
						case 150:
						{
							bool flag4;
							if (flag4)
							{
								num = (short)1079115790;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_761;
						}
						case 151:
							goto IL_36E;
						case 152:
						{
							int num23;
							if (num23 >= num9)
							{
								num = (short)59834428;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							byte[] array6;
							array2[num23] = array6[num23];
							num23++;
							num = (short)872087605;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 153:
							goto IL_87C;
						case 154:
						{
							short num15;
							num24 = (int)num15;
							num = (short)1241972798;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 155:
							goto IL_EA0;
						case 156:
							goto IL_EF7;
						case 157:
						{
							string fileName4 = global::ASK.Core.StatusMsg.b("੆཈ὊὌ慎恐", a_);
							flag = A_0.DoesFileExist(fileName4);
							num = (short)61669381;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 158:
							goto IL_761;
						case 159:
							goto IL_1F2A;
						case 160:
							goto IL_11A0;
						case 161:
							if (flag5)
							{
								num = (short)390201498;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1FAD;
						case 162:
							if (flag6)
							{
								num = (short)443220055;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_A75;
						case 163:
							goto IL_1B0D;
						case 164:
							goto IL_4C5;
						}
						goto IL_322;
						IL_36E:
						num = (short)535560286;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_3D6:
						fileName = global::ASK.Core.StatusMsg.b("͆ࡈὊౌ慎慐", a_);
						flag6 = A_0.DoesFileExist(fileName);
						num = (short)1277034541;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_42D:
						fileName = global::ASK.Core.StatusMsg.b("͆ࡈὊౌ慎慐", a_);
						int count = arrayList3.Count;
						short num25 = 0;
						A_0.CreateFile(fileName, out num25);
						num24 = arrayList3.Count;
						num = (short)1379729569;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_4C5:
						fileName = global::ASK.Core.StatusMsg.b("ࡆᵈ੊ᵌ慎慐", a_);
						flag2 = A_0.DoesFileExist(fileName);
						num = (short)381485185;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_51C:
						fileName = global::ASK.Core.StatusMsg.b("ెైቊṌ慎慐", a_);
						flag3 = A_0.DoesFileExist(fileName);
						num = (short)533266534;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_603:
						num = (short)928579645;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_761:
						pFileData2 = null;
						pFileData3 = null;
						acpIBtnEncyptDecrpt = new global::AcpCryptoLib.AcpIBtnEncyptDecrpt();
						num = (short)190840868;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_87C:
						num = (short)1811742872;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_8BC:
						num = (short)769064985;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_8FB:
						num = (short)424214654;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_93D:
						num = (short)1260519497;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_97B:
						flag5 = false;
						string fileName5 = null;
						num7 = 0;
						A_0.GetMaxFileSpace(fileName5, out num7);
						string category = string.Format(global::ASK.Core.StatusMsg.b("Նえ㽊⡌㱎煐㉒⍔㙖じ㝚㱜㵞ൠ٢䕤婦䥨ၪ嵬ቮ", a_), num7);
						global::System.Diagnostics.Trace.WriteLine(global::ASK.Core.StatusMsg.b("䵆䁈䉊杌敎筐祒罔絖獘煚睜罞᩠卢ᡤ䝦䍨䅪䝬䕮孰奲彴嵶獸", a_), category);
						num = (short)2145845266;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_A75:
						num = (short)1974665270;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_AB1:
						fileName = global::ASK.Core.StatusMsg.b("੆HᡊὌ慎慐", a_);
						num = (short)486932527;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_EA0:
						array = null;
						array = new byte[num4];
						num20 = 0;
						num = (short)2126053491;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_EF7:
						num = (short)892731505;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_F36:
						num20++;
						num = (short)1340342384;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_1058:
						num = (short)1793916962;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_11A0:
						int count2 = arrayList2.Count;
						num11 = 0;
						num = (short)931004550;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_1282:
						array2 = new byte[num9];
						array8 = new byte[num18];
						num = (short)1026621561;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_146C:
						num = (short)231473180;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_1532:
						num = (short)1726414878;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_156D:
						num9 = arrayList2.Count;
						num18 = arrayList2.Count;
						num = (short)876478599;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_15FA:
						num = (short)2034368651;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_16F9:
						num = (short)1125122111;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_17AD:
						num = (short)301858978;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_1820:
						fileName = global::ASK.Core.StatusMsg.b("ࡆᵈ੊ᵌ慎慐", a_);
						int count3 = arrayList4.Count;
						short num26 = 0;
						A_0.CreateFile(fileName, out num26);
						num4 = arrayList4.Count;
						num = (short)1103888411;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_1953:
						num = (short)1494417440;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_1991:
						num13++;
						num = (short)1385234490;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_19F5:
						num = (short)2002387094;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_1A31:
						num6 = 28;
						num = (short)1655505016;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_1B0D:
						num = (short)612433961;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_1B51:
						num = (short)1730674764;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_1BFD:
						num = (short)1250099200;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_1DDF:
						num = (short)1809383570;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_1F2A:
						num = (short)2045050930;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_1FAD:
						array4 = null;
						array4 = new byte[num24];
						num13 = 0;
						num = (short)1763442712;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_2117:
						num = (short)103743596;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_163E:
					throw new global::System.Exception(global::ASK.Core.StatusMsg.b("ᑆⱈ㥊⑌⹎㵐獒᭔≖㑘㥚㡜ⵞ䅠⹢Ɽ㑦⑨⩪㥬Ɱ㥰割", a_));
					IL_1733:
					result = false;
					throw new global::System.Exception(global::ASK.Core.StatusMsg.b("ࡆ㱈㽊浌⁎㝐獒ᡔ㉖㑘㑚⽜♞䁠", a_))
					{
						Data = 
						{
							{
								global::ASK.Core.StatusMsg.b("Ɇ㭈㥊≌㵎ቐ㱒ㅔ㉖", a_),
								3758129162U
							}
						}
					};
					IL_1774:
					result = false;
					throw new global::System.Exception(global::ASK.Core.StatusMsg.b("ن⩈⡊⡌㱎≐獒ᅔ㉖㝘㉚㡜㭞䁠", a_))
					{
						Data = 
						{
							{
								global::ASK.Core.StatusMsg.b("Ɇ㭈㥊≌㵎ቐ㱒ㅔ㉖", a_),
								3758129163U
							}
						}
					};
					IL_2271:
					return result;
					IL_322:
					array3 = new char[2];
					arrayList2 = new global::System.Collections.ArrayList();
					arrayList3 = new global::System.Collections.ArrayList();
					arrayList4 = new global::System.Collections.ArrayList();
					dictionary = new global::System.Collections.Generic.Dictionary<int, global::ASK.Core.AccessRecord>();
					length = A_1.Length;
					num12 = 0;
					num = (short)1577582648;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_87;
				}
				catch (global::System.Exception ex)
				{
					throw new global::System.Exception(global::ASK.Core.StatusMsg.b("⹆ୈ㹊㥌㭎㹐㵒畔V⭘㉚⥜㩞䅠♢ᝤᕦ٨ᥪ坬佮", a_) + ex.Message, ex);
				}
				return result;
			}
			}
		}

		// Token: 0x060000EB RID: 235 RVA: 0x0001AD24 File Offset: 0x00018F24
		public void WriteMASKToIBtn(global::RMIBtnWrapperLib.IIBtnWrapper spIBtn, string pstrPassword, global::ASK.Interface.KeyExpirationType expType, short daysToExpire, short progCount, ref bool bOpen)
		{
			int a_ = 12;
			short num;
			try
			{
				num = (short)1890582528;
				switch (num)
				{
				default:
				{
					num = (short)52494345;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						string fileName;
						byte b;
						int num3;
						char[] array;
						global::System.Collections.ArrayList arrayList;
						int num6;
						int length;
						string text;
						switch (num2)
						{
						case 0:
							goto IL_762;
						case 1:
							goto IL_1E8;
						case 2:
							if (!spIBtn.DoesFileExist(fileName))
							{
								num = (short)1438253076;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_295;
						case 3:
							b = (byte)pstrPassword.Length;
							num = (short)585695238;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							goto IL_253;
						case 5:
							if (num3 >= (int)((b + 1) / 2))
							{
								num = (short)999358479;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							array.SetValue(null, 0);
							array.SetValue(null, 1);
							array[0] = pstrPassword[2 * num3];
							num = (short)1825898523;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							goto IL_61D;
						case 7:
							if (pstrPassword != null)
							{
								num = (short)83558403;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_61D;
						case 8:
						{
							num = (short)373371793;
							short num4 = num;
							num = (short)1273574289;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_53A;
							default:
								num = (short)727318528;
								if (num != 0)
								{
								}
								if (b > 0)
								{
									num = (short)248512526;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_388;
							}
							break;
						}
						case 9:
							switch (0)
							{
							case 0:
								goto IL_BD;
							}
							continue;
						case 10:
						{
							int options = 0;
							spIBtn.OpenNonMotoBtn(options);
							num = (short)1139802113;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 11:
							num = (short)401145874;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 12:
							goto IL_53A;
						case 13:
						{
							arrayList.Insert(8, 0);
							arrayList.Insert(9, 5);
							byte b2 = global::ASK.Core.Global.CalculateCheckSum((byte[])arrayList.ToArray(typeof(byte)));
							arrayList.Add(b2);
							b = 0;
							num = (short)867696647;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 14:
							num3 = 0;
							num = (short)1468399637;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 15:
							goto IL_388;
						case 16:
							goto IL_295;
						case 17:
							goto IL_17B;
						case 18:
							if (b % 2 == 0)
							{
								num = (short)717750295;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_E2;
						case 19:
							spIBtn.CloseButton();
							num = (short)2116550668;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 20:
						{
							short num5 = 0;
							spIBtn.CreateFile(fileName, out num5);
							num = (short)1727135760;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 21:
							goto IL_253;
						case 22:
							goto IL_E2;
						case 23:
							goto IL_71D;
						case 24:
						{
							if (num6 >= length / 2)
							{
								num = (short)1855586317;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							array.SetValue(null, 0);
							array.SetValue(null, 1);
							array[0] = text[2 * num6];
							array[1] = text[2 * num6 + 1];
							string arg = new string(array);
							byte b3 = byte.Parse(string.Format(global::ASK.Core.StatusMsg.b("㍇穉癋㵍ⵏ", a_), arg), global::System.Globalization.NumberStyles.HexNumber);
							arrayList.Insert(num6, b3);
							num6++;
							num = (short)578617370;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 25:
							if (!bOpen)
							{
								num = (short)739573779;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_74A;
						case 26:
							goto IL_17B;
						case 27:
							if (num3 == (int)((b + 1) / 2 - 1))
							{
								num = (short)1727528971;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_71D;
						}
						IL_BD:
						if (!bOpen)
						{
							num = (short)1398145034;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1E8;
						IL_E2:
						string arg2 = new string(array);
						byte b4 = byte.Parse(string.Format(global::ASK.Core.StatusMsg.b("㍇穉癋㵍ⵏ", a_), arg2), global::System.Globalization.NumberStyles.HexNumber);
						global::System.Collections.ArrayList arrayList2;
						arrayList2.Add(b4);
						num3++;
						num = (short)1081802756;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_17B:
						num = (short)517931032;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_1E8:
						global::System.DateTime now = global::System.DateTime.Now;
						global::System.DateTime value = new global::System.DateTime(1970, 1, 1);
						daysToExpire += (short)now.Subtract(value).Days;
						arrayList = new global::System.Collections.ArrayList();
						text = this.b(spIBtn);
						array = new char[2];
						length = text.Length;
						num6 = 0;
						num = (short)1757151249;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_253:
						num = (short)376111109;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_295:
						byte[] array2;
						spIBtn.WriteFile(fileName, (short)array2.Length, array2);
						num = (short)1884225561;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_388:
						byte b5 = global::ASK.Core.Global.CalculateCheckSum((byte[])arrayList2.ToArray(typeof(byte)));
						arrayList2.Add(b5);
						arrayList.AddRange(arrayList2);
						arrayList.Add((byte)expType);
						byte[] array3 = new byte[2];
						byte b6 = (byte)(daysToExpire >> 8);
						array3[0] = b6;
						b6 = (byte)daysToExpire;
						array3[1] = b6;
						arrayList.AddRange(array3);
						byte[] array4 = new byte[2];
						b6 = (byte)(progCount >> 8);
						array4[0] = b6;
						b6 = (byte)progCount;
						array4[1] = b6;
						arrayList.AddRange(array4);
						byte[] array5 = new byte[3];
						global::System.TimeSpan timeSpan = global::System.DateTime.Now.ToUniversalTime().Subtract(global::ASK.Core.Constants.ReferenceDate);
						short num7 = (short)timeSpan.Days;
						b6 = (byte)(num7 >> 8);
						array5[0] = b6;
						b6 = (byte)num7;
						array5[1] = b6;
						b6 = (byte)((short)timeSpan.Hours);
						array5[2] = b6;
						arrayList.AddRange(array5);
						byte b7 = global::ASK.Core.Global.CalculateCheckSum((byte[])arrayList.ToArray(typeof(byte)));
						arrayList.Add(b7);
						byte[] pDecrypted = (byte[])arrayList.ToArray(typeof(byte));
						array2 = null;
						fileName = global::ASK.Core.StatusMsg.b("Շ୉ὋՍ繏扑", a_);
						new global::AcpCryptoLib.AcpIBtnEncyptDecrpt().Encrypt(pDecrypted, out array2);
						num = (short)1421213698;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_61D:
						arrayList2 = new global::System.Collections.ArrayList();
						arrayList2.Insert(0, b);
						num = (short)1560674312;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_71D:
						array[1] = pstrPassword[2 * num3 + 1];
						num = (short)1439825942;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_74A:
						num = (short)1679491072;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_53A:
						goto IL_74A;
					}
					IL_762:
					break;
				}
				}
			}
			catch (global::System.Exception ex)
			{
				throw new global::System.Exception(global::ASK.Core.StatusMsg.b("὇㡉╋㩍㕏牑ᥓ᝕ୗᅙ籛㡝य़๡ţ䙥๧୩իɭᕯᙱ乳噵", a_) + ex.Message, ex);
			}
			num = (short)1331625984;
			short num8 = num;
			num = (short)60948481;
			if (num != 0)
			{
			}
		}

		// Token: 0x060000EC RID: 236 RVA: 0x0001B528 File Offset: 0x00019728
		public void UpdatePassword(global::RMIBtnWrapperLib.IIBtnWrapper spIBtn, string newPaswd)
		{
			short num = (short)569391638;
			short num2 = num;
			num = (short)1634286102;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)821690369;
				if (num != 0)
				{
				}
				num = (short)1850343424;
				if (num != 0)
				{
				}
				num = (short)716046336;
				int num3 = (int)num;
				switch (num3)
				{
				}
				break;
			}
			}
			num = (short)257622016;
			short num4 = num;
			bool flag = true;
			uint num5 = 0U;
			try
			{
				switch (0)
				{
				case 0:
					goto IL_F6;
				}
				int num3;
				global::ASK.Interface.KeyExpirationType expType;
				short num6;
				short progCount;
				short num7;
				int num8;
				short num9;
				for (;;)
				{
					IL_C7:
					switch (num3)
					{
					case 0:
						if (this.f == global::ASK.Interface.HardwareKeyFamily.DS1994)
						{
							num = (short)106430470;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						num5 = this.a(spIBtn, out expType, out num6, out progCount, out num7, out num8, out num9);
						this.r = global::System.DateTime.Now.AddDays((double)num6);
						num = (short)2086273027;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (!global::ASK.Core.KeyRecordSet.c(this.b))
						{
							num = (short)1836515333;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_29A;
					case 2:
						goto IL_2B2;
					case 3:
						goto IL_25D;
					case 4:
						goto IL_29A;
					case 5:
						global::ASK.Core.KeyRecordSet.d(this.b);
						num = (short)1028194308;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						spIBtn.GetNumDaysLeft(ref this.p);
						num6 = this.p;
						this.r = global::System.DateTime.Now.AddDays((double)this.p);
						num = (short)1791098887;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_25D;
					case 8:
						if (num5 == 0U)
						{
							num = (short)1789853705;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_194;
					case 9:
						this.WriteMASKToIBtn(spIBtn, newPaswd, expType, num6, progCount, ref flag);
						num = (short)777977857;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_F6;
					IL_25D:
					num = (short)257097736;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_29A:
					num = (short)853868546;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_194:
				throw new global::System.Exception(global::ASK.Core.iBtnStatusCode.GetErrorMsg(num5));
				IL_2B2:
				return;
				IL_F6:
				expType = global::ASK.Interface.KeyExpirationType.Date;
				num6 = 0;
				progCount = 0;
				num7 = 0;
				num8 = 0;
				num9 = 0;
				this.f = this.c(spIBtn);
				num = (short)586022912;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_C7;
			}
			catch (global::System.Exception ex)
			{
				throw ex;
			}
		}

		// Token: 0x060000ED RID: 237 RVA: 0x0001B808 File Offset: 0x00019A08
		public void RefreshMASKFileLayout(global::RMIBtnWrapperLib.IIBtnWrapper spIBtn)
		{
			short num = (short)949944320;
			switch (num)
			{
			default:
			{
				bool flag = true;
				uint num2 = 0U;
				try
				{
					num = (short)1107623937;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						string pstrPassword;
						global::ASK.Interface.KeyExpirationType expType;
						short num5;
						short progCount;
						short num6;
						int num7;
						short num8;
						switch (num3)
						{
						case 0:
							goto IL_2CC;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_8E;
							}
							continue;
						case 2:
							num = (short)945029130;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							if (num2 != 2684387330U)
							{
								num = (short)1758134281;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_10B;
						case 4:
							goto IL_137;
						case 5:
							goto IL_2CC;
						case 6:
							if (num2 != 0U)
							{
								num = (short)633995280;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_10B;
						case 7:
						{
							num = (short)774274566;
							short num4 = num;
							num = (short)31686150;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_36C;
							default:
								num = (short)805306368;
								if (num != 0)
								{
								}
								num2 = this.GetPswdFromIBtn(spIBtn, ref pstrPassword);
								num = (short)1773928452;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 8:
							if (num2 == 0U)
							{
								num = (short)715128846;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2CC;
						case 9:
							num = (short)298450955;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 10:
							goto IL_36C;
						case 11:
							if (num2 == 2684387342U)
							{
								num = (short)86900751;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1C6;
						case 12:
							if (this.f == global::ASK.Interface.HardwareKeyFamily.DS1994)
							{
								num = (short)1623916557;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							num2 = this.a(spIBtn, out expType, out num5, out progCount, out num6, out num7, out num8);
							this.r = global::System.DateTime.Now.AddDays((double)num5);
							num = (short)1589903360;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 13:
							spIBtn.GetNumDaysLeft(ref this.p);
							num5 = this.p;
							this.r = global::System.DateTime.Now.AddDays((double)this.p);
							num = (short)834273285;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 14:
							this.f = this.c(spIBtn);
							num = (short)272957452;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 15:
							goto IL_10B;
						case 16:
							num = (short)1180958723;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_8E:
						bool flag2 = this.IsFormated(spIBtn, ref flag);
						pstrPassword = "";
						if (flag2)
						{
							num = (short)326631431;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_137;
						IL_10B:
						this.WriteMASKToIBtn(spIBtn, pstrPassword, expType, num5, progCount, ref flag);
						num = (short)266928130;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_137:
						expType = global::ASK.Interface.KeyExpirationType.Date;
						num5 = 0;
						progCount = 0;
						num6 = 0;
						num8 = 0;
						num7 = 0;
						num = (short)242286600;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_2CC:
						num = (short)1307836422;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_1C6:
					throw new global::System.Exception(global::ASK.Core.iBtnStatusCode.GetErrorMsg(num2));
					IL_36C:;
				}
				catch (global::System.Exception ex)
				{
					throw ex;
				}
				num = (short)1246560257;
				if (num != 0)
				{
				}
				num = (short)688062464;
				short num9 = num;
				return;
			}
			}
		}

		// Token: 0x060000EE RID: 238 RVA: 0x0001BBF4 File Offset: 0x00019DF4
		public void InitButton(global::RMIBtnWrapperLib.IIBtnWrapper spIBtn, short daysToFinalExpiration, global::System.DateTime expirationDate)
		{
			int a_ = 11;
			short num;
			try
			{
				num = (short)455933952;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					switch (0)
					{
					case 0:
						goto IL_48;
					}
					char offsetFormat;
					for (;;)
					{
						IL_31:
						switch (num2)
						{
						case 0:
							goto IL_200;
						case 1:
							num = (short)637992960;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
						{
							byte[] array = new byte[6];
							array[4] = 1;
							byte[] version = array;
							string userid = global::ASK.Core.StatusMsg.b("੆وὊቌ౎ŐR", a_);
							string password = global::ASK.Core.StatusMsg.b("੆وὊቌ౎ŐR", a_);
							short num3 = 1;
							byte[] communityCode = new byte[]
							{
								(byte)(num3 & 255),
								(byte)(num3 >> 8)
							};
							char expirationAction = 'B';
							bool flag = true;
							this.f = this.c(spIBtn);
							flag = (this.f == global::ASK.Interface.HardwareKeyFamily.DS1994 && flag);
							string authCode = global::ASK.Core.StatusMsg.b("㱆罈ॊ์ൎ扐慒摔恖湘Ṛ浜汞啠Ⅲ噤⑦⭨⽪ⱬ彮㕰㝲㑴乶㡸䵺㡼䝾쒀랂늄놆릈캌벎킐Ꞓﲘꪚ놜꾞\ud9a0鞢잤솦첨骪햬킰蒲횴첶覸쎺ﾼ蚾", a_);
							((global::RMIBtnWrapperLib.MultiBtnWrapper)spIBtn).InitButton(version, communityCode, userid, password, authCode, daysToFinalExpiration, offsetFormat, expirationAction, flag);
							((global::RMIBtnWrapperLib.MultiBtnWrapper)spIBtn).GetROMSerialNumString();
							short num4 = 0;
							((global::RMIBtnWrapperLib.MultiBtnWrapper)spIBtn).GetNumDaysLeft(ref num4);
							bool flag2 = true;
							this.WriteMASKToIBtn(spIBtn, null, this.o, this.DaysToExpiration, this.ProgrammingCount, ref flag2);
							this.j = true;
							num = (short)1508507649;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
							goto IL_BF;
						}
						goto IL_48;
					}
					IL_200:
					break;
					IL_48:
					this.ExpirationDate = expirationDate;
					this.DaysToExpiration = daysToFinalExpiration;
					offsetFormat = 'D';
					num = (short)557116981;
					short num5 = num;
					num = (short)545386037;
					switch ((num5 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_BF:
						if (daysToFinalExpiration >= 0)
						{
							num = (short)1182138370;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_31;
						}
						throw new global::System.Exception(global::ASK.Core.StatusMsg.b("Ն㱈㽊㥌⁎㽐獒ፔ㡖⭘㙚㱜⭞䅠♢ᝤᕦ٨ᥪ坬佮㡰ᵲʹᙶᕸቺ᥼彾쒀ﮂﮈ歷ﺐﶒ떔", a_));
					default:
						num = (short)1796866048;
						if (num != 0)
						{
						}
						num = (short)71499779;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_31;
					}
					break;
				}
				}
			}
			catch (global::System.Exception ex)
			{
				throw new global::System.Exception(global::ASK.Core.StatusMsg.b("Ն㱈㽊㥌⁎㽐獒ፔ㡖⭘㙚㱜⭞䅠♢ᝤᕦ٨ᥪ坬佮", a_) + ex.Message);
			}
			num = (short)569442305;
			if (num != 0)
			{
			}
			num = (short)1210515456;
			short num6 = num;
		}

		// Token: 0x060000EF RID: 239 RVA: 0x0001BE94 File Offset: 0x0001A094
		public bool ReadiBtnKey(global::RMIBtnWrapperLib.IIBtnWrapper spIBtn, bool bReadMasterKeys, bool bValidatePassword, global::ASK.Core.AccessLevelDataRecordSet pRsAccess, ref bool bOpen, ref bool bISR, out global::ASK.Core.StatusMsg status, bool bASKCalling, bool bAddAccessLevel)
		{
			int a_ = 16;
			short num = (short)262275073;
			if (num != 0)
			{
			}
			num = (short)1151270912;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				bool result = true;
				int a_2 = 0;
				status = null;
				uint num3 = 0U;
				try
				{
					switch (0)
					{
					case 0:
						goto IL_A8;
					}
					for (;;)
					{
						IL_65:
						int a_3;
						switch (num2)
						{
						case 0:
							try
							{
								this.a(spIBtn, this.b, a_3, pRsAccess, bISR, bASKCalling, bAddAccessLevel);
								goto IL_36A;
							}
							catch (global::System.Exception ex)
							{
								this.d.Clear();
								num3 = 1610645507U;
								this.i = false;
								result = false;
								string str = global::Motorola.CommonCPS.ResourceRepository.Resources.iBtn_System_key.AcpStringFormat(new object[]
								{
									this.b
								});
								status = new global::ASK.Core.StatusMsg(global::ASK.Core.AskStatusType.Error, str + global::ASK.Core.StatusMsg.b("汋", a_) + ex.Message, num3);
								goto IL_36A;
							}
							goto IL_30A;
						case 1:
							goto IL_19C;
						case 2:
							if (this.h)
							{
								num = (short)1994260494;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_20B;
						case 3:
							goto IL_383;
						case 4:
							a_3 = 0;
							num = (short)795869193;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
						{
							if (num3 != 0U)
							{
								result = false;
								string message = global::Motorola.CommonCPS.ResourceRepository.Resources.Error_Reading_iButton.AcpStringFormat(new object[]
								{
									global::ASK.Core.iBtnStatusCode.GetErrorMsg(num3),
									this.b
								});
								status = new global::ASK.Core.StatusMsg(global::ASK.Core.AskStatusType.Error, message, num3);
								num = (short)1641938957;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)849085572;
							short num4 = num;
							num = (short)262472836;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_28A;
							default:
								num = (short)1075642368;
								if (num != 0)
								{
								}
								num = (short)888078340;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 6:
							goto IL_28A;
						case 7:
							goto IL_20B;
						case 8:
							if (this.h)
							{
								num = (short)429457409;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_36A;
						case 9:
							if (this.g)
							{
								num = (short)58654726;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1720516610;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 10:
							goto IL_20B;
						case 11:
							if (!this.g)
							{
								num = (short)792789004;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_19C;
						case 12:
							goto IL_30A;
						case 13:
							goto IL_36A;
						case 14:
							a_3 = 1;
							num = (short)93585415;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A8;
						IL_19C:
						num = (short)879886336;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_20B:
						num = (short)2000486411;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_28A:
						a_3 = 3;
						pRsAccess = null;
						num = (short)1159987210;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_30A:
						num = (short)1658847240;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_36A:
						num = (short)699006979;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_383:
					goto IL_3C2;
					IL_A8:
					num3 = this.a(spIBtn, bReadMasterKeys, bValidatePassword, a_2, 1);
					bOpen = true;
					num = (short)1933443077;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_65;
				}
				catch (global::System.Exception ex2)
				{
					result = false;
					num3 = 1610645507U;
					string message2 = global::Motorola.CommonCPS.ResourceRepository.Resources.Error_Reading_iButton.AcpStringFormat(new object[]
					{
						ex2.Message,
						this.b
					});
					status = new global::ASK.Core.StatusMsg(global::ASK.Core.AskStatusType.Error, message2, num3);
				}
				IL_3C2:
				num = (short)1707212800;
				short num5 = num;
				return result;
			}
			}
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x0001C2C4 File Offset: 0x0001A4C4
		internal void a(global::RMIBtnWrapperLib.IIBtnWrapper A_0, string A_1, int A_2, global::ASK.Core.AccessLevelDataRecordSet A_3, bool A_4, bool A_5, bool A_6)
		{
			int a_ = 13;
			short num;
			try
			{
				num = (short)732758016;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					switch (0)
					{
					case 0:
						goto IL_15F;
					}
					bool flag;
					for (;;)
					{
						IL_30:
						global::System.Collections.ArrayList arrayList;
						global::System.Collections.ArrayList arrayList2;
						global::System.Collections.ArrayList arrayList3;
						string text2;
						int num10;
						byte b2;
						switch (num2)
						{
						case 0:
							if ((byte)arrayList[8] != 4)
							{
								num = (short)298582057;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_381;
						case 1:
						{
							byte b = (byte)arrayList2[8];
							num = (short)1107296290;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							goto IL_59D;
						case 3:
							if (A_3 != null)
							{
								num = (short)1780940826;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2F6;
						case 4:
							goto IL_342;
						case 5:
							goto IL_59D;
						case 6:
							goto IL_24F;
						case 7:
							goto IL_60E;
						case 8:
							flag = true;
							num = (short)353632269;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 9:
						{
							if (this.KeyFamily == global::ASK.Interface.HardwareKeyFamily.DS1994)
							{
								num = (short)32047150;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::ASK.Interface.KeyExpirationType keyExpirationType = global::ASK.Interface.KeyExpirationType.Date;
							short num3 = 0;
							short num4 = 0;
							short num5 = 0;
							int num6 = 0;
							this.a(A_0, out keyExpirationType, out this.s, out num3, out num4, out num6, out num5);
							num = (short)729743414;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 10:
							goto IL_8DB;
						case 11:
						{
							string text;
							if (text != A_1)
							{
								num = (short)1168769074;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							arrayList2 = new global::System.Collections.ArrayList();
							arrayList3 = new global::System.Collections.ArrayList();
							arrayList = new global::System.Collections.ArrayList();
							int num7 = 0;
							num = (short)2076049418;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 12:
							goto IL_4CF;
						case 13:
							goto IL_869;
						case 14:
							num = (short)196542475;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 15:
							if (!(text2 != A_1))
							{
								num = (short)1134821390;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_685;
						case 16:
							goto IL_CA6;
						case 17:
							if (this.a(A_0, 4) != A_1)
							{
								num = (short)67567669;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_D13;
						case 18:
							if (A_3 != null)
							{
								num = (short)591462438;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_CA6;
						case 19:
							num = (short)985399296;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 20:
							num = (short)1401552928;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 21:
						{
							int num8;
							short num9;
							if (num8 >= (int)num9)
							{
								num = (short)1012924440;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							byte[] array;
							arrayList2.Insert(num8, array[num8++]);
							num = (short)667418685;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 22:
							if (flag)
							{
								num = (short)2063728687;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_402;
						case 23:
						{
							short num11;
							if (num10 >= (int)num11)
							{
								num = (short)2079064080;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							byte[] array2;
							arrayList.Insert(num10, array2[num10++]);
							num = (short)1417478171;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 24:
							goto IL_3C1;
						case 25:
						{
							int num7;
							short num12;
							if (num7 >= (int)num12)
							{
								num = (short)134676513;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							byte[] array3;
							arrayList3.Insert(num7, array3[num7++]);
							num = (short)36372516;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 26:
							num = (short)1901723718;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 27:
							goto IL_D86;
						case 28:
							if (A_2 == 1)
							{
								num = (short)1484521480;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_869;
						case 29:
						{
							bool flag2;
							if (flag2)
							{
								num = (short)449445944;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_CA6;
						}
						case 30:
						{
							int num7;
							if (global::ASK.Core.Global.calculateCRC8((byte[])arrayList3.ToArray(typeof(byte)), (short)(num7 - 2), 0) != (byte)arrayList3[num7 - 1])
							{
								num = (short)728105015;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)216268858;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 31:
							goto IL_402;
						case 32:
						{
							byte b;
							if (b != 2)
							{
								num = (short)1637089320;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_D8B;
						}
						case 33:
						{
							int num8 = 0;
							num = (short)1861091377;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 34:
						{
							bool flag2;
							if (flag2)
							{
								num = (short)314376211;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_381;
						}
						case 35:
							if ((int)b2 != A_2)
							{
								num = (short)2124480524;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_D8B;
						case 36:
							num = (short)1998127105;
							if (num != 0)
							{
							}
							goto IL_8DB;
						case 37:
							goto IL_6F5;
						case 38:
							num = (short)1012072477;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 39:
							if (A_3 != null)
							{
								num = (short)2055667713;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)2135687203;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 40:
							goto IL_9FD;
						case 41:
							goto IL_48F;
						case 42:
							num = (short)1744896051;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 43:
						{
							if (A_2 != 1)
							{
								num = (short)1257832521;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							string text = this.a(A_0, 2);
							num = (short)143982664;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 44:
						{
							bool flag2;
							if (flag2)
							{
								num = (short)651493440;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_402;
						}
						case 45:
							if (b2 == 1)
							{
								num = (short)1356267540;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_AAD;
						case 46:
							A_0.GetNumDaysLeft(ref this.p);
							this.a(this.p, A_0);
							num = (short)429326341;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 47:
						{
							short num9;
							byte[] array;
							int a_2;
							this.a(A_0, a_2, ref array, out num9);
							string fileName = global::ASK.Core.StatusMsg.b("وὊౌ὎罐捒", a_);
							bool flag2 = A_0.DoesFileExist(fileName);
							num = (short)2055667756;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 48:
						{
							num = (short)138340189;
							short num13 = num;
							num = (short)932964189;
							switch ((num13 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_D86;
							default:
							{
								num = (short)2064384000;
								if (num != 0)
								{
								}
								int num8;
								if (global::ASK.Core.Global.calculateCRC8((byte[])arrayList2.ToArray(typeof(byte)), (short)(num8 - 2), 0) != (byte)arrayList2[num8 - 1])
								{
									num = (short)6094854;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_B44;
							}
							}
							break;
						}
						case 49:
							if (A_3 != null)
							{
								num = (short)667222058;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_3C1;
						case 50:
							goto IL_B01;
						case 51:
							goto IL_82D;
						case 52:
						{
							if (this.a(A_0, 0) != A_1)
							{
								num = (short)805634055;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							int a_2 = 2;
							int a_3 = 4;
							byte[] array3 = null;
							byte[] array = null;
							byte[] array2 = null;
							short num12 = 400;
							short num9 = 400;
							short num11 = 400;
							bool flag2 = false;
							this.a(A_0, A_2, ref array3, out num12);
							num = (short)1151729686;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 53:
							goto IL_7CC;
						case 54:
							if (this.KeyFamily == global::ASK.Interface.HardwareKeyFamily.DS1963)
							{
								num = (short)1772748867;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_342;
						case 55:
							goto IL_D0E;
						case 56:
							num = (short)1921187877;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 57:
						{
							bool flag2;
							if (flag2)
							{
								num = (short)576258110;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2F6;
						}
						case 58:
							if (A_3 != null)
							{
								num = (short)1424752708;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_B44;
						case 59:
							num = (short)182452233;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 60:
							num = (short)1572274193;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 61:
							goto IL_82D;
						case 62:
							num = (short)944242691;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 63:
							goto IL_E13;
						case 64:
						{
							short num11;
							byte[] array2;
							int a_3;
							this.a(A_0, a_3, ref array2, out num11);
							num = (short)1712324639;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 65:
							if (flag)
							{
								num = (short)1835663419;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_59D;
						case 66:
						{
							int num6;
							if (num6 >= 5)
							{
								num = (short)1087373316;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_59D;
						}
						case 67:
							num = (short)560136258;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 68:
							num = (short)1083179056;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 69:
							goto IL_D13;
						case 70:
							if (global::ASK.Core.Global.calculateCRC8((byte[])arrayList.ToArray(typeof(byte)), (short)(num10 - 2), 0) != (byte)arrayList[num10 - 1])
							{
								num = (short)1664155719;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2F6;
						case 71:
							goto IL_97E;
						case 72:
						{
							bool flag2;
							if (flag2)
							{
								num = (short)1058406460;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_D13;
						}
						case 73:
						{
							string text = text2;
							num = (short)748552261;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						goto IL_15F;
						IL_2F6:
						b2 = (byte)arrayList3[8];
						num = (short)337969191;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_342:
						this.a(this.s, A_0);
						num = (short)1833631746;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_381:
						num = (short)1494614061;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_3C1:
						num10 = 0;
						num = (short)1939603474;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_402:
						text2 = this.a(A_0, A_2);
						num = (short)9830443;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_59D:
						string fileName2 = global::ASK.Core.StatusMsg.b("ш੊Ṍю罐捒", a_);
						short num14 = 400;
						short num15 = 400;
						A_0.GetMaxFileSpace(fileName2, out num14);
						A_0.GetFileSize(fileName2, ref num15);
						num = (short)70451252;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_6F5:
						num = (short)1093206039;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_D86:
						goto IL_6F5;
						IL_82D:
						num = (short)182517781;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_869:
						num = (short)628949057;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_8DB:
						num = (short)508100633;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_B44:
						num = (short)1136984121;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_CA6:
						num = (short)2099839006;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_D13:
						num = (short)1937309711;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_D8B:
						this.a = (short)((byte)arrayList3[9]);
						byte[] a_4 = (byte[])arrayList3.ToArray(typeof(byte));
						byte[] a_5 = (byte[])arrayList2.ToArray(typeof(byte));
						byte[] a_6 = (byte[])arrayList.ToArray(typeof(byte));
						this.a(null, a_4, a_5, a_6, A_3, A_5, A_6);
						num = (short)1308819519;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_24F:
					throw new global::System.Exception(global::ASK.Core.StatusMsg.b("ൈ⩊㥌⹎煐ၒ㵔㉖㩘ず⹜⩞ౠ䍢Ťࡦ౨ᡪ䵬ŮṰݲ啴᩶ᡸེṼ᝾ꆀꊂ", a_));
					IL_48F:
					throw new global::System.Exception(global::ASK.Core.StatusMsg.b("H╊㭌⹎㵐㩒ㅔ睖ᙘཚᱜཞ䅠╢౤୦౨䭪⑬⭮偰", a_));
					IL_4CF:
					throw new global::System.Exception(global::ASK.Core.StatusMsg.b("H╊㭌⹎㵐㩒ㅔ睖ቘṚќ罞❠੢।ɦ䥨≪⥬乮", a_));
					IL_60E:
					throw new global::System.Exception(global::ASK.Core.StatusMsg.b("䍈䉊䑌敎筐祒罔絖獘煚絜቞⁠ぢ⹤䥦奨䭪Ṭ੮Ͱᩲᑴ᭶奸ᕺࡼቾꞆﲎ놐ﶒ杖릘ﲜ슠쮢薤쎦첨\uddaa쒬첮풰鎲운튶쮸튺\udcbc펾귂냄꫆ꯈ껊뿌戮ￔ﷖쯠짢", a_));
					IL_685:
					throw new global::System.Exception(global::ASK.Core.StatusMsg.b("䍈䉊䑌敎筐祒罔絖祘⡚㡜ⵞࡠɢ।䝦ݨṪl൮ᑰŲٴ坶ὸॺቼቾꆀ권ﺐ뎒ﮔ뮚ﺞ햠삢춤螦춨캪\udbac욮튰횲閴鶶鎸醺鞼閾쿄", a_));
					IL_7CC:
					throw new global::System.Exception(global::ASK.Core.StatusMsg.b("䍈䉊䑌敎筐祒罔絖祘ᑚड़Ṟㅠ䍢ᙤɦ᭨ɪ౬ͮ兰ᵲt᩶᭸Ṻོ౾ꆀꮊ﶐랖ﶘ붜캠힢薤쪦좨\udfaa캬잮醰ힲ킴솶킸\ud8ba\ud8bc", a_));
					IL_97E:
					throw new global::System.Exception(global::ASK.Core.StatusMsg.b("وὊౌ὎煐ၒ㵔㉖㩘ず⹜⩞ౠ䍢Ťࡦ౨ᡪ䵬ŮṰݲ啴᩶ᡸེṼ᝾ꆀꊂ", a_));
					IL_9FD:
					IL_AAD:
					throw new global::System.Exception(global::ASK.Core.StatusMsg.b("H╊㭌⹎㵐㩒ㅔ睖ቘṚќ灞╠≢ㅤ♦䥨⵪Ѭͮᑰ卲㱴㍶塸", a_));
					IL_B01:
					goto IL_685;
					IL_D0E:
					throw new global::System.Exception(global::ASK.Core.StatusMsg.b("Ɉ⹊㑌潎ቐ㭒ご㑖㉘⡚⡜㉞䅠ݢ੤ɦᩨ䭪ͬnհ卲ᡴᙶ൸᡺ᕼ彾ꂀ", a_));
					IL_E13:
					break;
					IL_15F:
					flag = false;
					num = (short)389611548;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_30;
				}
				}
			}
			catch (global::System.Exception ex)
			{
				throw ex;
			}
			num = (short)1483866112;
			short num16 = num;
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x0001D130 File Offset: 0x0001B330
		internal void a(short A_0, global::RMIBtnWrapperLib.IIBtnWrapper A_1)
		{
			int a_ = 4;
			short num = (short)183762954;
			int num2 = (int)((global::System.IntPtr)num);
			string text;
			string text2;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					text = null;
					num = (short)1462763535;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_328;
				case 2:
					goto IL_27B;
				case 3:
					text2 = string.Format(global::Motorola.CommonCPS.ResourceRepository.Resources.ResourceManager.GetString(global::ASK.Core.StatusMsg.b("Ŀ㙁ぃ❅⭇≉⥋⩍ཏᥑㅓ⽕ݗὙ⑛⹝य़ၡൣࡥཧ㕩㡫ŭᑯ፱൳", a_), global::Motorola.CommonCPS.ResourceRepository.Resources.Culture), text);
					num = (short)1203503106;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_27B;
				case 5:
					goto IL_2C1;
				case 6:
					num = (short)395706380;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
				{
					if (A_0 >= 0)
					{
						num = (short)1046282254;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)20913199;
					short num3 = num;
					num = (short)1266359343;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_2A9;
					default:
						num = (short)442761216;
						if (num != 0)
						{
						}
						num = (short)1747320841;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 8:
					if (text.Length > 0)
					{
						num = (short)368443403;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_328;
				case 9:
					goto IL_3AB;
				case 10:
					switch (0)
					{
					case 0:
						goto IL_6D;
					}
					continue;
				case 11:
					this.q = true;
					global::ASK.Core.KeyRecordSet.e(text);
					num = (short)2130903041;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					if (text != null)
					{
						num = (short)1917911053;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_328;
				case 13:
					num = (short)1282932744;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
					num = (short)297730049;
					if (num != 0)
					{
					}
					if (A_0 == 0)
					{
						num = (short)54788099;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					text2 = string.Format(global::Motorola.CommonCPS.ResourceRepository.Resources.ResourceManager.GetString(global::ASK.Core.StatusMsg.b("Ŀ㙁ぃ❅⭇≉⥋⩍ཏᥑㅓ⽕ݗ൙㕛㉝౟㵡Ⅳṥᡧͩṫ୭", a_), global::Motorola.CommonCPS.ResourceRepository.Resources.Culture), text, A_0);
					num = (short)611254276;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
					if (!this.a(A_1, ref text))
					{
						num = (short)304087046;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				IL_6D:
				if (A_0 < 30)
				{
					num = (short)1312358400;
					short num4 = num;
					num = (short)1463877632;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_2A9:
				num = (short)305004549;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_27B:
				global::System.Windows.MessageBox.Show(text2, global::Motorola.CommonCPS.ResourceRepository.Resources.ResourceManager.GetString(global::ASK.Core.StatusMsg.b("᜿⍁㙃⡅ⅇ⑉⭋ᅍ᥏㙑", a_), global::Motorola.CommonCPS.ResourceRepository.Resources.Culture), global::System.Windows.MessageBoxButton.OK, global::System.Windows.MessageBoxImage.Exclamation, global::System.Windows.MessageBoxResult.OK, this.v);
				goto IL_2A9;
				IL_328:
				text2 = null;
				num = (short)396820487;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_2C1:
			return;
			IL_3AB:
			text2 = string.Format(global::Motorola.CommonCPS.ResourceRepository.Resources.ResourceManager.GetString(global::ASK.Core.StatusMsg.b("Ŀ㙁ぃ❅⭇≉⥋⩍ཏᥑㅓ⽕ݗὙ⑛⹝य़ၡţɥ", a_), global::Motorola.CommonCPS.ResourceRepository.Resources.Culture), text);
			global::System.Windows.MessageBox.Show(text2, global::Motorola.CommonCPS.ResourceRepository.Resources.ResourceManager.GetString(global::ASK.Core.StatusMsg.b("᜿⍁㙃⡅ⅇ⑉⭋ᅍ᥏㙑", a_), global::Motorola.CommonCPS.ResourceRepository.Resources.Culture), global::System.Windows.MessageBoxButton.OK, global::System.Windows.MessageBoxImage.Exclamation, global::System.Windows.MessageBoxResult.OK, this.v);
			throw new global::System.Exception(text2);
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x0001D4F0 File Offset: 0x0001B6F0
		private void a()
		{
			short num;
			try
			{
				num = (short)1163919362;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)2009464833;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						this.v = (global::System.Windows.MessageBoxOptions.RightAlign | global::System.Windows.MessageBoxOptions.RtlReading);
						num = (short)1229979649;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_122;
					case 2:
						goto IL_15;
					case 3:
						goto IL_139;
					case 4:
						goto IL_122;
					}
					goto IL_61;
					IL_15:
					switch (0)
					{
					case 0:
						IL_61:
						if (global::System.Threading.Thread.CurrentThread.CurrentUICulture.TextInfo.IsRightToLeft)
						{
							num = (short)1895713243;
							short num3 = num;
							num = (short)770525659;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_15;
							default:
								num = (short)1390149632;
								if (num != 0)
								{
								}
								num = (short)1413283840;
								num2 = (int)((global::System.IntPtr)num);
								break;
							}
						}
						else
						{
							this.v = global::System.Windows.MessageBoxOptions.None;
							num = (short)222232580;
							num2 = (int)((global::System.IntPtr)num);
						}
						break;
					}
					continue;
					IL_122:
					num = (short)105906179;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_139:;
			}
			catch
			{
			}
			num = (short)777650176;
			short num4 = num;
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x0001D680 File Offset: 0x0001B880
		internal bool a(byte[] A_0, byte[] A_1, byte[] A_2, byte[] A_3, global::ASK.Core.AccessLevelDataRecordSet A_4, bool A_5, bool A_6)
		{
			int a_ = 16;
			short num = (short)613810176;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_70;
				}
				global::System.Collections.ObjectModel.Collection<global::ASK.Core.KeyDataRecord> collection;
				for (;;)
				{
					IL_31:
					bool flag;
					global::System.Collections.Generic.IEnumerator<global::ASK.Core.KeyDataRecord> enumerator;
					global::System.Collections.ObjectModel.Collection<global::ASK.Core.OtapData> collection2;
					switch (num2)
					{
					case 0:
						goto IL_1D9;
					case 1:
						goto IL_1605;
					case 2:
						if (flag)
						{
							num = (short)120520710;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_195;
					case 3:
						enumerator = collection.GetEnumerator();
						num = (short)1668153355;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						num = (short)1527971853;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_FB;
					case 6:
					{
						int count = collection.Count;
						int count2 = collection2.Count;
						num = (short)1129054209;
						if (num != 0)
						{
						}
						num = (short)576847879;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						goto IL_195;
					case 8:
						if (collection != null)
						{
							num = (short)1287389185;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_181;
					case 9:
						if (collection2 != null)
						{
							num = (short)513343492;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_FB;
					case 10:
						try
						{
							num = (short)730660866;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 1:
									num = (short)1927610371;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_24E;
									}
									continue;
								case 3:
									goto IL_2D2;
								case 4:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)628883457;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::ASK.Core.KeyDataRecord item = enumerator.Current;
									this.d.Add(item);
									num = (short)2035744768;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_27E:
								num = (short)672333828;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_24E:
								goto IL_27E;
							}
							IL_2D2:
							return true;
						}
						finally
						{
							num = (short)856752128;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_30A;
									}
									continue;
								case 1:
									goto IL_342;
								case 2:
									enumerator.Dispose();
									num = (short)1994457089;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_30A:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1371209730;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_342:;
						}
						goto Block_6;
					case 11:
						goto IL_345;
					case 12:
						if (A_4 != null)
						{
							num = (short)1314848771;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AF;
					case 13:
						if (collection2.Count == 0)
						{
							num = (short)1850081285;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1D9;
					}
					goto IL_70;
					IL_AF:
					enumerator = collection.GetEnumerator();
					num = (short)872349706;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					Block_6:
					global::System.Collections.ObjectModel.Collection<global::ASK.Core.AccessRecordData> collection3;
					try
					{
						IL_345:
						num = (short)505675843;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							global::ASK.Core.AccessRecordData accessRecordData;
							byte[] array;
							int num3;
							int num4;
							int num7;
							switch (num2)
							{
							case 0:
								if (accessRecordData != null)
								{
									num = (short)467730482;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							case 1:
								goto IL_F24;
							case 2:
								goto IL_109A;
							case 3:
								if (array[num3] != 255)
								{
									num = (short)1961951321;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								num3++;
								num = (short)1587675181;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
								goto IL_12EE;
							case 5:
								try
								{
									num = (short)1906442244;
									num2 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										switch (num2)
										{
										case 0:
											goto IL_D7E;
										case 1:
										{
											global::System.Collections.Generic.IEnumerator<global::ASK.Core.OtapData> enumerator2;
											if (!enumerator2.MoveNext())
											{
												num = (short)1625882631;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											global::ASK.Core.OtapData otapData = enumerator2.Current;
											num = (short)756678659;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 2:
										{
											global::ASK.Core.OtapData otapData;
											global::ASK.Core.KeyDataRecord keyDataRecord;
											if (keyDataRecord.KeyType == otapData.OTAPKeyType)
											{
												num = (short)83689480;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											break;
										}
										case 3:
										{
											global::ASK.Core.OtapData otapData;
											global::ASK.Core.KeyDataRecord keyDataRecord;
											if (keyDataRecord.SystemID == otapData.SystemID)
											{
												num = (short)1419051014;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											break;
										}
										case 4:
											switch (0)
											{
											case 0:
												goto IL_D18;
											}
											continue;
										case 5:
											goto IL_E28;
										case 6:
											num = (short)1787625474;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 7:
											num = (short)2029125637;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 8:
										{
											global::ASK.Core.OtapData otapData;
											bool flag2 = otapData.OTAPStatus;
											num = (short)139460608;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										}
										IL_DD4:
										num = (short)429064193;
										num2 = (int)((global::System.IntPtr)num);
										continue;
										IL_D18:
										goto IL_DD4;
									}
									IL_D7E:
									IL_E28:
									goto IL_BEB;
								}
								finally
								{
									num = (short)907673600;
									num2 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										global::System.Collections.Generic.IEnumerator<global::ASK.Core.OtapData> enumerator2;
										switch (num2)
										{
										case 0:
											switch (0)
											{
											case 0:
												goto IL_E60;
											}
											continue;
										case 1:
											goto IL_E97;
										case 2:
											enumerator2.Dispose();
											num = (short)625475585;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										IL_E60:
										if (enumerator2 == null)
										{
											break;
										}
										num = (short)2052390914;
										num2 = (int)((global::System.IntPtr)num);
									}
									IL_E97:;
								}
								goto IL_E9A;
							case 6:
								if (array.Length != 24)
								{
									num = (short)1419116581;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_EC7;
							case 7:
							{
								bool flag2 = true;
								num = (short)1390084098;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 9:
								goto IL_AA4;
							case 10:
								if (num4 == 1)
								{
									num = (short)1492713489;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_130F;
							case 11:
								try
								{
									num = (short)1358233601;
									num2 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										switch (num2)
										{
										case 0:
										{
											global::ASK.Core.AccessRecordData accessRecordData2;
											accessRecordData = accessRecordData2;
											num = (short)1157234692;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 1:
											switch (0)
											{
											case 0:
												goto IL_11BE;
											}
											continue;
										case 2:
										{
											global::ASK.Core.KeyDataRecord keyDataRecord;
											global::ASK.Core.AccessRecordData accessRecordData2;
											if (accessRecordData2.PrimaryKey == (int)keyDataRecord.ForiegnKey)
											{
												num = (short)405405696;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											break;
										}
										case 3:
										{
											global::System.Collections.Generic.IEnumerator<global::ASK.Core.AccessRecordData> enumerator3;
											if (!enumerator3.MoveNext())
											{
												num = (short)601554950;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											global::ASK.Core.AccessRecordData accessRecordData2 = enumerator3.Current;
											num = (short)2049310722;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 4:
											goto IL_125B;
										case 5:
											goto IL_1279;
										case 6:
											num = (short)2115633157;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										IL_1206:
										num = (short)108855299;
										num2 = (int)((global::System.IntPtr)num);
										continue;
										IL_11BE:
										goto IL_1206;
									}
									IL_125B:
									IL_1279:
									goto IL_113D;
								}
								finally
								{
									num = (short)2100494336;
									num2 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										global::System.Collections.Generic.IEnumerator<global::ASK.Core.AccessRecordData> enumerator3;
										switch (num2)
										{
										case 0:
											switch (0)
											{
											case 0:
												goto IL_12B0;
											}
											continue;
										case 1:
											goto IL_12EB;
										case 2:
											enumerator3.Dispose();
											num = (short)1440546817;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										IL_12B0:
										if (enumerator3 == null)
										{
											break;
										}
										num = (short)1169227778;
										num2 = (int)((global::System.IntPtr)num);
									}
									IL_12EB:;
								}
								goto IL_12EE;
							case 12:
								if (!flag)
								{
									num = (short)881918025;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_109A;
							case 13:
								if (num3 >= 24)
								{
									num = (short)496238647;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								array[num3] = byte.MaxValue;
								num3++;
								num = (short)571342912;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 14:
								goto IL_C65;
							case 15:
								num = (short)1729101892;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 16:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)1012924473;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::ASK.Core.KeyDataRecord keyDataRecord = enumerator.Current;
								accessRecordData = null;
								num = (short)732299298;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 17:
								num = (short)812122118;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 18:
							{
								global::ASK.Core.AccessRecord recordByData;
								if (recordByData == null)
								{
									num = (short)1811742741;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::ASK.Core.KeyDataRecord keyDataRecord;
								keyDataRecord.AccessLevel.Name = recordByData.Name;
								keyDataRecord.AccessLevel.ID = recordByData.ID;
								keyDataRecord.AccessLevel.PrimaryKey = recordByData.PrimaryKey;
								num = (short)506855460;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 19:
								accessRecordData.FieldCode = array;
								num = (short)1320747051;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 20:
								goto IL_1374;
							case 21:
							{
								int num5 = 1;
								string text = global::ASK.Core.StatusMsg.b("ോⵍ㍏㝑❓╕硗ᙙ㥛⡝՟๡䑣坥", a_);
								global::ASK.Core.AccessRecord recordByAccessName = A_4.GetRecordByAccessName(text);
								num = (short)1668743224;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 22:
								array[10] = 247;
								num = (short)149225548;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 23:
							{
								if (this.a != 2)
								{
									num4 = global::ASK.Core.KeyDataRecord.GetAccessLevelType(array);
									num = (short)1774845985;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)1287872275;
								short num6 = num;
								num = (short)140730131;
								switch ((num6 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_AA4;
								default:
									num = (short)694091776;
									if (num != 0)
									{
									}
									num = (short)1742995500;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 24:
								goto IL_14F9;
							case 25:
								goto IL_95D;
							case 26:
								if (num3 >= 12)
								{
									num = (short)1419051074;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)1699807297;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 27:
								goto IL_580;
							case 28:
								num = (short)726794318;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 29:
								accessRecordData.FieldCode = array;
								num = (short)2111766555;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 30:
								if (num4 > 0)
								{
									num = (short)938016783;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_7FE;
							case 31:
								goto IL_13B2;
							case 32:
								goto IL_890;
							case 33:
							{
								bool flag2;
								if (flag2)
								{
									num = (short)920387675;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_775;
							}
							case 34:
								if (collection3 != null)
								{
									num = (short)1348272208;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_113D;
							case 35:
								goto IL_775;
							case 37:
								array = new byte[24];
								num = (short)71499869;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 38:
								if (accessRecordData.Ranges != null)
								{
									num = (short)425066575;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_689;
							case 39:
							{
								global::ASK.Core.KeyDataRecord keyDataRecord;
								string text;
								keyDataRecord.AccessLevel.Name = text;
								A_4.AddNewRecord(keyDataRecord.AccessLevel);
								num = (short)295305224;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 40:
								if (accessRecordData.FieldCode.Length != 24)
								{
									num = (short)5963795;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_130F;
							case 41:
								if (num4 == 2)
								{
									num = (short)939261999;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_580;
							case 42:
								goto IL_B23;
							case 43:
								goto IL_130F;
							case 44:
								num3 = 0;
								num = (short)410386446;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 45:
								goto IL_6F1;
							case 46:
							{
								global::ASK.Core.KeyDataRecord keyDataRecord;
								global::ASK.Core.AccessRecord recordByData = A_4.GetRecordByData(keyDataRecord.AccessLevel);
								num = (short)1145634834;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 47:
								num = (short)154140742;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 48:
								goto IL_689;
							case 49:
								if (num3 >= 10)
								{
									num = (short)1201995801;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)1426259971;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 50:
							{
								bool flag2 = false;
								num = (short)2058879062;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 51:
								goto IL_1592;
							case 52:
								if (num7 != 0)
								{
									num = (short)668729379;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_14F9;
							case 53:
								goto IL_95D;
							case 54:
								goto IL_14F9;
							case 55:
								num = (short)745340968;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 56:
								goto IL_1374;
							case 57:
								num = (short)1186791475;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 58:
								goto IL_890;
							case 59:
								if (num7 == 0)
								{
									num = (short)1896939524;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_7FE;
							case 60:
								goto IL_6F1;
							case 61:
								goto IL_F99;
							case 62:
								goto IL_B23;
							case 63:
								num3 = 0;
								num = (short)1702887484;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 64:
								goto IL_F99;
							case 65:
								if (array[num3] != 255)
								{
									num = (short)872349780;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								num3++;
								num = (short)1603534919;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 66:
								goto IL_F24;
							case 67:
								switch (0)
								{
								case 0:
									goto IL_4E8;
								}
								continue;
							case 68:
								if ((array[10] & 15) == 15)
								{
									num = (short)1276510217;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_7FE;
							case 69:
							{
								global::ASK.Core.KeyDataRecord keyDataRecord;
								bool flag2;
								keyDataRecord.AccessLevel = new global::ASK.Core.AccessRecord(accessRecordData.PrimaryKey, global::ASK.Interface.FeatureCategoryType.TRUNKING, accessRecordData.FieldCode, accessRecordData.Ranges, flag2);
								num = (short)117243936;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 70:
								if (array.Length != 24)
								{
									num = (short)294125640;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_13B2;
							case 71:
								goto IL_C65;
							case 72:
								array = new byte[24];
								num = (short)81133599;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 73:
								num = (short)794427479;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 74:
								goto IL_14F9;
							case 75:
							{
								if (A_5)
								{
									num = (short)7864389;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								bool flag2;
								global::ASK.Core.AccessRecordData accessRecordData3 = global::ASK.Core.AccessDataConverter.ConvertLegacyAccessRecordData(accessRecordData, flag2, (global::ASK.Interface.KeyAccessLevelType)num4);
								global::ASK.Core.KeyDataRecord keyDataRecord;
								keyDataRecord.AccessLevel = new global::ASK.Core.AccessRecord(accessRecordData3.PrimaryKey, global::ASK.Interface.FeatureCategoryType.TRUNKING, accessRecordData3.FieldCode, accessRecordData3.Ranges, flag2);
								num = (short)392036410;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 76:
								if (accessRecordData.FieldCode.Length != 24)
								{
									num = (short)905510941;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_580;
							case 77:
								goto IL_14F9;
							case 78:
								if (num7 != 0)
								{
									num = (short)1970077784;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_14F9;
							case 79:
								num7 = accessRecordData.Ranges.Count;
								num = (short)144179248;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 80:
							{
								global::System.Collections.Generic.IEnumerator<global::ASK.Core.AccessRecordData> enumerator3 = collection3.GetEnumerator();
								num = (short)1453457419;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 81:
							{
								bool flag2;
								if (flag2)
								{
									num = (short)1865613340;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_1013;
							}
							case 82:
							{
								global::ASK.Core.AccessRecord recordByAccessName;
								if (recordByAccessName == null)
								{
									num = (short)72155175;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								int num5;
								string text = string.Format(global::ASK.Core.StatusMsg.b("ോⵍ㍏㝑❓╕硗ᙙ㥛⡝՟๡䑣ᵥ塧ᝩ", a_), ++num5);
								recordByAccessName = A_4.GetRecordByAccessName(text);
								num = (short)609222676;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 83:
								if (this.a == 1)
								{
									num = (short)606601279;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)1063059479;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 84:
								num4 = 0;
								num = (short)258408449;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 85:
								if (num3 >= 24)
								{
									num = (short)591986710;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_E9A;
							case 86:
							{
								if (flag)
								{
									num = (short)133824606;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								bool flag2 = true;
								num = (short)398852186;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 87:
								if (num4 != 0)
								{
									num = (short)1606483975;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_109A;
							case 88:
								goto IL_1013;
							case 89:
								num4 = 0;
								num = (short)1326121013;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 90:
								goto IL_BEB;
							case 91:
								num = (short)461701172;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 92:
								if (A_6)
								{
									num = (short)537133102;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							case 93:
								goto IL_EC7;
							case 94:
							{
								global::System.Collections.Generic.IEnumerator<global::ASK.Core.OtapData> enumerator2 = collection2.GetEnumerator();
								num = (short)1969553413;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							goto IL_4E8;
							IL_580:
							num = (short)1669660684;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_689:
							num4 = 1;
							num3 = 0;
							num = (short)999293011;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_6F1:
							num = (short)2094596145;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_775:
							num4 = 0;
							num = (short)1855586328;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_7FE:
							num4 = 0;
							num = (short)592707661;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_890:
							num = (short)1960968284;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_95D:
							num = (short)1563426846;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_AA4:
							num = (short)633405499;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_B23:
							num = (short)1898512469;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_BEB:
							array = accessRecordData.FieldCode;
							num7 = 0;
							num = (short)163577894;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_C65:
							num = (short)1928003610;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_E9A:
							array[num3] = byte.MaxValue;
							num3++;
							num = (short)1646395454;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_EC7:
							num3 = 0;
							num = (short)1673134141;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_F24:
							num = (short)75366481;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_F99:
							num = (short)556793869;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_1013:
							num4 = 0;
							num = (short)1164902454;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_109A:
							num = (short)1657143371;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_113D:
							num = (short)2004877312;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_12EE:
							num4 = 1;
							num = (short)632094794;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_130F:
							num = (short)1594753065;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_1374:
							num = (short)1071186002;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_13B2:
							num3 = 0;
							num = (short)2095382570;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_14F9:
							num = (short)819855370;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_1538:
							num = (short)1220411408;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_4E8:
							goto IL_1538;
						}
						IL_1592:
						goto IL_AF;
					}
					finally
					{
						num = (short)108920832;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_15CB;
								}
								continue;
							case 1:
								goto IL_1602;
							case 2:
								enumerator.Dispose();
								num = (short)434962433;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_15CB:
							if (enumerator == null)
							{
								break;
							}
							num = (short)74776578;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_1602:;
					}
					goto IL_1605;
					IL_FB:
					flag = false;
					num = (short)1053491200;
					short num8 = num;
					num = (short)1985085440;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_195:
					collection3 = this.b(A_2);
					num = (short)121176076;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1D9:
					num = (short)1973420034;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1605:
					collection2 = null;
					flag = true;
					collection2 = this.c(A_3);
					num = (short)1087963145;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_181:
				throw new global::System.Exception(global::ASK.Core.StatusMsg.b("ɋ⅍灏őⵓ╕ⱗ㽙ㅛⵝ䁟ѡୣ፥٧๩䱫ݭṯ剱sṵᵷ婹᝻᭽勵", a_));
				IL_70:
				collection = this.a(A_1, A_4);
				num = (short)926154760;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x0001ED94 File Offset: 0x0001CF94
		internal bool a(ref global::System.Collections.ArrayList A_0, ref global::System.Collections.ArrayList A_1, ref global::System.Collections.ArrayList A_2, global::System.Collections.ArrayList A_3, global::ASK.Core.AccessLevelDataRecordSet A_4)
		{
			short num = (short)1220083712;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)142999553;
				num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.Collections.IEnumerator enumerator;
					global::System.Collections.Generic.IEnumerator<global::ASK.Core.IKeyDataRecord> enumerator2;
					switch (num2)
					{
					case 0:
						try
						{
							num = (short)2107113474;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_5AD;
								case 1:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)802619392;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::ASK.Core.AccessRecord accessRecord = (global::ASK.Core.AccessRecord)enumerator.Current;
									A_1.AddRange(accessRecord.PackedData);
									num = (short)435814403;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									switch (0)
									{
									case 0:
										goto IL_4ED;
									}
									continue;
								case 4:
									goto IL_5C5;
								}
								IL_522:
								num = (short)1359517842;
								short num3 = num;
								num = (short)1356896402;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									IL_5AD:
									num = (short)58982404;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								default:
									num = (short)1724579840;
									if (num != 0)
									{
									}
									num = (short)522059777;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_4ED:
								goto IL_522;
							}
							IL_5C5:;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_5E4;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_5D1:
								switch (num2)
								{
								case 0:
									disposable.Dispose();
									num = (short)537591810;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									if (disposable != null)
									{
										num = (short)763822080;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_63B;
								case 2:
									goto IL_639;
								}
								goto IL_5E4;
							}
							IL_639:
							IL_63B:
							goto EndFinally_14;
							IL_5E4:
							disposable = (enumerator as global::System.IDisposable);
							num = (short)201261057;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_5D1;
							EndFinally_14:;
						}
						goto IL_63C;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_54;
						}
						continue;
					case 2:
						goto IL_440;
					case 3:
						try
						{
							num = (short)833683461;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.ArrayList arrayList;
								switch (num2)
								{
								case 1:
									if (!enumerator2.MoveNext())
									{
										num = (short)1219493892;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1898512392;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
								{
									byte b;
									A_2.Add(b);
									byte b2;
									arrayList.Add(b2);
									num = (short)1762787331;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									goto IL_32E;
								case 4:
									num = (short)905445386;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									switch (0)
									{
									case 0:
										goto IL_C7;
									}
									continue;
								case 6:
									if (A_4 != null)
									{
										num = (short)2029256706;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_32E;
								case 7:
								{
									byte b = 1;
									num = (short)1409613833;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
								{
									global::ASK.Core.KeyDataRecord keyDataRecord = (global::ASK.Core.KeyDataRecord)enumerator2.Current;
									byte b3 = (byte)keyDataRecord.AccessLevel.PrimaryKey;
									arrayList = new global::System.Collections.ArrayList();
									int systemID = keyDataRecord.SystemID;
									byte keyType = keyDataRecord.KeyType;
									byte b4 = (byte)(keyType << 4);
									byte b2 = (byte)(systemID >> 16);
									b2 |= b4;
									A_0.Add(b2);
									arrayList.Add(b2);
									b2 = (byte)(systemID >> 8);
									A_0.Add(b2);
									arrayList.Add(b2);
									b2 = (byte)systemID;
									A_0.Add(b2);
									arrayList.Add(b2);
									if (A_4 != null)
									{
										A_0.Add(b3);
										arrayList.Add(b3);
									}
									byte b5 = global::ASK.Core.Global.CalculateCheckSum((byte[])arrayList.ToArray(typeof(byte)));
									A_0.Add(b5);
									arrayList.Clear();
									A_2.Add(keyType);
									arrayList.Add(keyType);
									b2 = (byte)(systemID >> 16);
									A_2.Add(b2);
									arrayList.Add(b2);
									b2 = (byte)(systemID >> 8);
									A_2.Add(b2);
									arrayList.Add(b2);
									b2 = (byte)systemID;
									A_2.Add(b2);
									arrayList.Add(b2);
									bool optapstate = keyDataRecord.AccessLevel.OPTAPState;
									byte b = 0;
									if (optapstate)
									{
										num = (short)193265671;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2BE;
								}
								case 9:
									goto IL_2BE;
								case 10:
									goto IL_3CE;
								}
								goto IL_C7;
								IL_2BE:
								num = (short)458686470;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_32E:
								byte b6 = global::ASK.Core.Global.CalculateCheckSum((byte[])arrayList.ToArray(typeof(byte)));
								A_2.Add(b6);
								num = (short)1000734720;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_376:
								num = (short)450494465;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_C7:
								goto IL_376;
							}
							IL_3CE:
							goto IL_667;
						}
						finally
						{
							num = (short)674365441;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator2.Dispose();
									num = (short)808321026;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_406;
									}
									continue;
								case 2:
									goto IL_43D;
								}
								IL_406:
								if (enumerator2 == null)
								{
									break;
								}
								num = (short)442892288;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_43D:;
						}
						goto IL_440;
					}
					IL_54:
					if (A_4 != null)
					{
						num = (short)1895825410;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_63C;
					IL_440:
					num = (short)1211105281;
					if (num != 0)
					{
					}
					num = (short)168951808;
					short num4 = num;
					enumerator = A_3.GetEnumerator();
					num = (short)1660878848;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_63C:
					enumerator2 = this.d.GetEnumerator();
					num = (short)2004549635;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_667:
				byte b7 = global::ASK.Core.Global.CalculateCheckSum((byte[])A_0.ToArray(typeof(byte)));
				A_0.Add(b7);
				byte b8 = global::ASK.Core.Global.CalculateCheckSum((byte[])A_1.ToArray(typeof(byte)));
				A_1.Add(b8);
				byte b9 = global::ASK.Core.Global.CalculateCheckSum((byte[])A_2.ToArray(typeof(byte)));
				A_2.Add(b9);
				return true;
			}
			}
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x0001F4BC File Offset: 0x0001D6BC
		private global::System.Collections.ObjectModel.Collection<global::ASK.Core.OtapData> c(byte[] A_0)
		{
			int a_ = 0;
			short num = (short)950468608;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_B5;
				}
				int num3;
				int num4;
				global::System.Collections.ObjectModel.Collection<global::ASK.Core.OtapData> collection;
				bool flag;
				for (;;)
				{
					IL_32:
					int num5;
					global::System.Collections.ArrayList arrayList;
					int num8;
					byte b;
					switch (num2)
					{
					case 0:
					{
						byte[] array;
						if (global::ASK.Core.Global.CalculateCheckSum(array) != A_0[12])
						{
							num = (short)699203602;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num3 = (int)A_0[9];
						num4 = (int)A_0[11];
						num5 = 13;
						int num6 = A_0.Length;
						collection = new global::System.Collections.ObjectModel.Collection<global::ASK.Core.OtapData>();
						num = (short)1085603847;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						goto IL_4F7;
					case 2:
						goto IL_234;
					case 3:
					{
						if (num3 < 4)
						{
							num = (short)79691805;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						arrayList.Add(A_0[num5]);
						byte keytype = A_0[num5++];
						num = (short)1432616977;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						goto IL_390;
					case 5:
						if (A_0.Length == 0)
						{
							num = (short)196083742;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_355;
					case 6:
						goto IL_56C;
					case 7:
						goto IL_2B0;
					case 8:
					{
						int num7;
						if (num4 != num7)
						{
							goto IL_21C;
						}
						return collection;
					}
					case 9:
					{
						int num6;
						if (num5 >= num6 - 3)
						{
							num = (short)1937899532;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num8 = 0;
						arrayList = new global::System.Collections.ArrayList();
						byte keytype = 0;
						num = (short)1746403331;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						if (A_0 != null)
						{
							num = (short)1768292363;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return collection;
					case 11:
						num = (short)1375993876;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						num = (short)1768751112;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						goto IL_355;
					case 14:
					{
						num = (short)1200422912;
						short num9 = num;
						if ((b & 1) > 0)
						{
							num = (short)1030422544;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						bool otap = false;
						num = (short)945225753;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 15:
						num = (short)368115712;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
					{
						bool otap = true;
						num = (short)2091843611;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 17:
						goto IL_56C;
					case 18:
						goto IL_40C;
					case 19:
						if (flag)
						{
							num = (short)1591083032;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return collection;
					case 20:
						if (A_0.Length != 0)
						{
							num = (short)611319834;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return collection;
					case 21:
					{
						int num10;
						if (num10 >= 12)
						{
							num = (short)937426959;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						byte[] array;
						array[num10] = A_0[num10];
						num10++;
						num = (short)2034368516;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 22:
						goto IL_2B0;
					case 23:
					{
						byte b2;
						if (A_0[num5++] != b2)
						{
							num = (short)753729537;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						byte keytype;
						bool otap;
						global::ASK.Core.OtapData item = new global::ASK.Core.OtapData(keytype, num8, otap);
						collection.Add(item);
						int num7;
						num7++;
						num = (short)659423254;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 24:
					{
						int num7 = 0;
						byte[] array = new byte[12];
						int num10 = 0;
						num = (short)1209401372;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 25:
						goto IL_44C;
					case 26:
						num = (short)207093765;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 27:
						goto IL_44C;
					case 28:
						goto IL_390;
					case 29:
						arrayList.Add(A_0[num5]);
						num8 = (int)A_0[num5++] << 24;
						num = (short)391905286;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 30:
						flag = false;
						num = (short)853278733;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_B5;
					IL_21C:
					num = (short)996081666;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_44C:
					num = (short)226740225;
					short num11 = num;
					num = (short)1905969153;
					switch ((num11 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_21C;
					default:
					{
						num = (short)887422976;
						if (num != 0)
						{
						}
						byte b2 = global::ASK.Core.Global.CalculateCheckSum((byte[])arrayList.ToArray(typeof(byte)));
						num = (short)172490775;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_2B0:
					num = (short)19333129;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_355:
					num = (short)382468115;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_390:
					num = (short)1058078741;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_56C:
					arrayList.Add(A_0[num5]);
					num8 |= (int)A_0[num5++] << 16;
					arrayList.Add(A_0[num5]);
					num8 |= (int)A_0[num5++] << 8;
					arrayList.Add(A_0[num5]);
					num8 |= (int)A_0[num5++];
					b = A_0[num5++];
					arrayList.Add(b);
					num = (short)172687374;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_234:
				throw new global::System.Exception(global::ASK.Core.StatusMsg.b("㘻㜽怿сՃཅчཉࡋ湍ᅏّ瑓ᥕ౗᭙౛灝偟䉡䥣䙥㩧⽩⽫Ⅽ≯㙱味㕵㝷⽹㉻⩽ꁿ쾁춃햅얇쮉\ud88b춍\ud88f늑떓랕릗邙", a_));
				IL_40C:
				num = (short)874250241;
				if (num != 0)
				{
				}
				throw new global::System.Exception(global::ASK.Core.StatusMsg.b("㘻㜽怿сՃཅчཉࡋ湍ᅏّ瑓ᥕ౗᭙౛灝偟䉡Ᵽ⍥⥧⹩⥫㱭偯ㅱ㱳㍵㭷ㅹ⽻⭽쵿ꊁꖃꞅꦇ肉", a_));
				IL_4F7:
				throw new global::System.Exception(global::ASK.Core.StatusMsg.b("㘻㜽怿сՃཅчཉࡋ湍ᅏّ瑓ᥕ౗᭙౛灝偟䉡Ⅳ⡥㱧㡩㕫乭㍯㩱ㅳ㕵㍷⥹⥻㍽ꁿꎁꖃꞅ芇", a_));
				IL_B5:
				collection = null;
				flag = true;
				num4 = 0;
				num3 = -1;
				num = (short)1786249226;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_32;
			}
			}
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x0001FB58 File Offset: 0x0001DD58
		private global::System.Collections.ObjectModel.Collection<global::ASK.Core.KeyDataRecord> a(byte[] A_0, global::ASK.Core.AccessLevelDataRecordSet A_1)
		{
			int a_ = 3;
			short num = (short)1683423232;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_9B;
				}
				global::System.Collections.ObjectModel.Collection<global::ASK.Core.KeyDataRecord> collection;
				int num9;
				for (;;)
				{
					IL_30:
					byte b;
					global::System.Collections.ArrayList arrayList;
					switch (num2)
					{
					case 0:
					{
						int num3 = 0;
						byte[] array = new byte[11];
						int num4 = 0;
						num = (short)1626931217;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
					{
						int num5;
						if (A_0[num5++] != b)
						{
							num = (short)1778384905;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						byte uKeyType;
						int sysID;
						byte b2;
						global::ASK.Core.KeyDataRecord item = new global::ASK.Core.KeyDataRecord(uKeyType, sysID, b2);
						collection.Add(item);
						int num3;
						num3++;
						num = (short)1137115139;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_209;
					case 3:
					{
						num = (short)1926111324;
						short num6 = num;
						num = (short)2119180380;
						switch ((num6 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_DD;
						default:
							num = (short)1713242112;
							if (num != 0)
							{
							}
							goto IL_209;
						}
						break;
					}
					case 4:
					{
						if (this.a < 4)
						{
							num = (short)1667891211;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int num5;
						arrayList.Add(A_0[num5]);
						arrayList.Add(A_0[num5 + 1]);
						arrayList.Add(A_0[num5 + 2]);
						byte b3 = A_0[num5] & 15;
						byte uKeyType = (byte)(A_0[num5] >> 4);
						num5++;
						int sysID = (int)b3 << 16 | (int)A_0[num5++] << 8 | (int)A_0[num5++];
						num = (short)2120548371;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
					{
						int num4;
						if (num4 >= 11)
						{
							num = (short)1916010511;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						byte[] array;
						array[num4] = A_0[num4];
						num4++;
						num = (short)170786840;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						if (A_0 != null)
						{
							num = (short)181010448;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return collection;
					case 7:
						goto IL_3A9;
					case 8:
						goto IL_578;
					case 9:
						goto IL_13B;
					case 10:
						goto IL_2E3;
					case 11:
					{
						int num5;
						arrayList.Add(A_0[num5]);
						arrayList.Add(A_0[num5 + 1]);
						int sysID = (int)A_0[num5++] << 8 | (int)A_0[num5++];
						byte uKeyType = 0;
						num = (short)127860744;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
						if (A_1 != null)
						{
							num = (short)593166354;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_DD;
					case 13:
					{
						int num5;
						int num7;
						if (num5 >= num7 - 3)
						{
							num = (short)525926420;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)552861696;
						short num8 = num;
						byte b2 = 0;
						arrayList = new global::System.Collections.ArrayList();
						num = (short)1214578692;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
					{
						int num3;
						if (num3 != num9)
						{
							num = (short)1754726410;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return collection;
					}
					case 15:
						num = (short)1723400214;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						num = (short)1126826007;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						goto IL_1C8;
					case 18:
					{
						int num5;
						byte b2 = A_0[num5++];
						arrayList.Add(b2);
						num = (short)2102722581;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 19:
						goto IL_578;
					case 20:
						num = (short)1246822414;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						goto IL_DD;
					case 22:
					{
						num = (short)1108148225;
						if (num != 0)
						{
						}
						byte[] array;
						if (global::ASK.Core.Global.CalculateCheckSum(array) != A_0[11])
						{
							num = (short)203554823;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num9 = (int)A_0[10];
						int num5 = 12;
						int num7 = A_0.Length;
						collection = new global::System.Collections.ObjectModel.Collection<global::ASK.Core.KeyDataRecord>();
						num = (short)1227751426;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 23:
						if (A_0.Length != 0)
						{
							num = (short)1370947584;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return collection;
					case 24:
						goto IL_1C8;
					}
					goto IL_9B;
					IL_DD:
					b = global::ASK.Core.Global.CalculateCheckSum((byte[])arrayList.ToArray(typeof(byte)));
					num = (short)927268865;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1C8:
					num = (short)381026309;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_209:
					num = (short)619577357;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_578:
					num = (short)2098462732;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_13B:
				throw new global::System.Exception(global::ASK.Core.StatusMsg.b("㔾䡀捂̈́نH݊ࡌ୎煐ቒŔ睖ቘṚќ煞兠䍢⁤⥦㵨㥪㑬佮㉰㭲ぴ㑶㉸⡺⡼㉾ꆀꊂꒄꚆ莈", a_));
				IL_2E3:
				throw new global::System.Exception(global::ASK.Core.StatusMsg.b("㔾䡀捂̈́نH݊ࡌ୎煐ቒŔ睖ቘṚќ煞兠䍢䡤䝦㭨⹪⹬⁮⍰㝲啴㑶㙸⹺㍼⭾ꆀ캂첄풆쒈쪊\ud98c첎\ud990뎒뒔뚖뢘醚", a_));
				IL_3A9:
				throw new global::System.Exception(global::ASK.Core.StatusMsg.b("㔾䡀捂̈́نH݊ࡌ୎煐ቒŔ睖ቘṚќ౞你卢䕤⽦ⱨ⩪⥬⩮⍰卲㙴㽶㱸㡺㙼Ȿ풀캂ꖄꚆꢈꪊ螌", a_));
				IL_9B:
				num9 = 0;
				collection = null;
				num = (short)774307846;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x0002011C File Offset: 0x0001E31C
		private global::System.Collections.ObjectModel.Collection<global::ASK.Core.AccessRecordData> b(byte[] A_0)
		{
			int a_ = 3;
			short num = (short)1901048730;
			short num2 = num;
			num = (short)1465299866;
			global::System.Collections.Generic.Dictionary<ushort, global::ASK.Core.FieldValueRangeRecSet> dictionary;
			byte b;
			global::ASK.Core.FieldValueRangeRecSet fieldValueRangeRecSet;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_179:
				dictionary.Add((ushort)b, fieldValueRangeRecSet);
				num = (short)886636549;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)2015428608;
				if (num != 0)
				{
				}
				num = (short)91357184;
				num3 = (int)num;
				switch (num3)
				{
				default:
					switch (0)
					{
					case 0:
						goto IL_137;
					}
					break;
				}
				break;
			}
			global::System.Collections.ObjectModel.Collection<global::ASK.Core.AccessRecordData> collection;
			int num10;
			int num18;
			for (;;)
			{
				IL_7C:
				int num5;
				byte b2;
				int num7;
				int num8;
				byte[] array;
				int num11;
				switch (num3)
				{
				case 0:
				{
					global::System.Collections.ArrayList arrayList;
					int num4;
					if (global::ASK.Core.Global.CalculateCheckSum((byte[])arrayList.ToArray(typeof(byte))) != A_0[num4++])
					{
						num = (short)921894950;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					arrayList.Clear();
					new global::System.Collections.ArrayList();
					dictionary = new global::System.Collections.Generic.Dictionary<ushort, global::ASK.Core.FieldValueRangeRecSet>();
					num5 = 0;
					num = (short)1561133099;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
				{
					global::System.Collections.ArrayList arrayList;
					int num4;
					if (global::ASK.Core.Global.CalculateCheckSum((byte[])arrayList.ToArray(typeof(byte))) != A_0[num4++])
					{
						num = (short)921894935;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_54C;
				}
				case 2:
				{
					int num4;
					int num6;
					if (num4 >= num6 - 3)
					{
						num = (short)1418854421;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					global::System.Collections.ArrayList arrayList = new global::System.Collections.ArrayList();
					b2 = A_0[num4++];
					arrayList.Add(b2);
					num7 = 0;
					num = (short)211288105;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 3:
					num = (short)1148846102;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_30A;
				case 5:
					goto IL_582;
				case 6:
					if (this.a > 2)
					{
						num = (short)1860829220;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_5F8;
				case 7:
					if (A_0.Length != 0)
					{
						num = (short)704643109;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return collection;
				case 8:
					num = (short)1479344129;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					num = (short)1785135135;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
				{
					byte b3;
					if (num5 >= (int)b3)
					{
						num = (short)753074185;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)984219666;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 11:
					goto IL_30F;
				case 12:
					goto IL_293;
				case 13:
					goto IL_5A6;
				case 14:
					goto IL_622;
				case 15:
				{
					if (num8 >= num7)
					{
						num = (short)998375448;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					int num4;
					array[num8] = A_0[num4++];
					global::System.Collections.ArrayList arrayList;
					arrayList.Add(array[num8]);
					num8++;
					num = (short)2058027009;
					if (num != 0)
					{
					}
					num = (short)1884618765;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 16:
				{
					byte b3;
					num5 = (int)b3;
					num = (short)1044512803;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 17:
					goto IL_5A6;
				case 18:
				{
					int num4;
					int num6;
					if (num4 >= num6 - 2)
					{
						num = (short)764608528;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					b = A_0[num4++];
					global::System.Collections.ArrayList arrayList;
					arrayList.Add(b);
					int num9 = 1;
					num = (short)837222406;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 19:
					goto IL_5F8;
				case 20:
					num = (short)359464967;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 21:
					num = (short)1247608864;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 22:
				{
					byte[] array2;
					if (global::ASK.Core.Global.CalculateCheckSum(array2) != A_0[11])
					{
						num = (short)1780613145;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					num10 = (int)A_0[10];
					collection = new global::System.Collections.ObjectModel.Collection<global::ASK.Core.AccessRecordData>();
					int num4 = 12;
					int num6 = A_0.Length;
					num = (short)1034223627;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 23:
					goto IL_28E;
				case 24:
				{
					int num4;
					byte b3 = A_0[num4++];
					global::System.Collections.ArrayList arrayList;
					arrayList.Add(b3);
					num = (short)1342570496;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 25:
					goto IL_68E;
				case 26:
					if (A_0 != null)
					{
						num = (short)732102676;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return collection;
				case 27:
					num7 = 12;
					num = (short)1807548456;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 28:
					goto IL_30F;
				case 29:
				{
					int num9;
					if (num11 >= num9)
					{
						num = (short)1558577156;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					global::System.Collections.ArrayList arrayList;
					int num4;
					arrayList.Add(A_0[num4]);
					uint num12 = (uint)((uint)A_0[num4++] << 24);
					arrayList.Add(A_0[num4]);
					uint num13 = num12 + (uint)((uint)A_0[num4++] << 16);
					arrayList.Add(A_0[num4]);
					uint num14 = num13 + (uint)((uint)A_0[num4++] << 8);
					arrayList.Add(A_0[num4]);
					uint value = num14 + (uint)A_0[num4++];
					arrayList.Add(A_0[num4]);
					uint num15 = (uint)((uint)A_0[num4++] << 24);
					arrayList.Add(A_0[num4]);
					uint num16 = num15 + (uint)((uint)A_0[num4++] << 16);
					arrayList.Add(A_0[num4]);
					uint num17 = num16 + (uint)((uint)A_0[num4++] << 8);
					arrayList.Add(A_0[num4]);
					uint value2 = num17 + (uint)A_0[num4++];
					global::ASK.Core.AccessFieldValueRange item = new global::ASK.Core.AccessFieldValueRange((int)b, new uint?(value), new uint?(value2));
					fieldValueRangeRecSet.Add(item);
					num11++;
					num = (short)494207020;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 30:
					goto IL_9A8;
				case 31:
				{
					byte b3;
					if (b3 > 0)
					{
						num = (short)1706622984;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_54C;
				}
				case 32:
					if (num18 != num10)
					{
						num = (short)1585381410;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return collection;
				case 33:
					goto IL_293;
				case 34:
					goto IL_9A3;
				case 35:
					goto IL_582;
				case 36:
				{
					int num4;
					byte b4 = A_0[num4++];
					global::System.Collections.ArrayList arrayList;
					arrayList.Add(b4);
					int num9 = (int)b4;
					num = (short)1985740819;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 37:
				{
					byte[] array2 = new byte[11];
					int num19 = 0;
					num = (short)926023713;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 38:
					goto IL_431;
				case 39:
				{
					int num19;
					if (num19 >= 11)
					{
						num = (short)1052835843;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					byte[] array2;
					array2[num19] = A_0[num19];
					num19++;
					num = (short)1166999564;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 40:
					goto IL_622;
				case 41:
				{
					if (this.a <= 2)
					{
						num = (short)179568667;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					int num4;
					num7 = (int)A_0[num4++];
					global::System.Collections.ArrayList arrayList;
					arrayList.Add((byte)num7);
					num = (short)960430094;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 42:
					goto IL_2D1;
				case 43:
					goto IL_9A8;
				case 44:
					goto IL_2D1;
				}
				goto IL_137;
				IL_293:
				num = (short)973930535;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_2D1:
				num = (short)1709309981;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_30F:
				num = (short)134545410;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_54C:
				global::ASK.Core.AccessRecordData item2 = new global::ASK.Core.AccessRecordData((int)b2, array, dictionary);
				collection.Add(item2);
				num18++;
				num = (short)431882268;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_582:
				num5++;
				num = (short)754319390;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_5A6:
				num = (short)1460076559;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_5F8:
				fieldValueRangeRecSet = new global::ASK.Core.FieldValueRangeRecSet((ushort)b);
				num11 = 0;
				num = (short)1178927146;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_622:
				array = new byte[num7];
				num8 = 0;
				num = (short)551682065;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_9A8:
				num = (short)1204027402;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_28E:
			throw new global::System.Exception(global::ASK.Core.StatusMsg.b("㔾䡀捂̈́نH݊ࡌ୎煐ቒŔ睖ᵘᩚड़Ṟ你卢䕤㕦⡨╪⩬⩮兰㝲㑴⍶㡸孺㹼㝾쒀삂캄풆\udc88욊권꺎낐늒龔", a_));
			IL_30A:
			goto IL_179;
			IL_431:
			num = (short)1696923648;
			short num20 = num;
			throw new global::System.Exception(global::ASK.Core.StatusMsg.b("㔾䡀捂̈́نH݊ࡌ୎煐ቒŔ睖ᵘᩚड़Ṟ你卢䕤≦❨㽪㽬㙮兰ひ㵴㉶㩸ぺ⹼⩾첀ꎂꒄꚆꢈ膊", a_));
			IL_68E:
			throw new global::System.Exception(global::ASK.Core.StatusMsg.b("㔾䡀捂̈́نH݊ࡌ୎煐ቒŔ睖ᵘᩚड़Ṟ你卢䕤⽦ⱨ⩪⥬⩮⍰卲㙴㽶㱸㡺㙼Ȿ풀캂ꖄꚆꢈꪊ螌", a_));
			IL_9A3:
			throw new global::System.Exception(global::ASK.Core.StatusMsg.b("㔾䡀捂̈́نH݊ࡌ୎煐ቒŔ睖ᵘᩚड़Ṟ你卢䕤䩦䥨㥪⡬Ɱ㹰ⅲㅴ坶㩸㑺⡼ㅾ햀ꎂ좄캆\uda88욊첌\udb8e튐\udb92떔뚖뢘몚鞜", a_));
			IL_137:
			num10 = 0;
			num18 = 0;
			collection = null;
			num = (short)824705050;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_7C;
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00020B14 File Offset: 0x0001ED14
		internal string a(global::RMIBtnWrapperLib.IIBtnWrapper A_0, int A_1)
		{
			string result = null;
			byte[] a_ = null;
			short num = 400;
			short num2;
			try
			{
				num2 = (short)1447034884;
				int num3 = (int)((global::System.IntPtr)num2);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						goto IL_110;
					case 1:
						goto IL_F9;
					case 2:
						goto IL_F9;
					case 3:
						this.a(A_0, A_1, ref a_, out num);
						result = this.a(a_);
						goto IL_75;
					case 4:
						switch (0)
						{
						case 0:
							goto IL_44;
						}
						continue;
					}
					IL_44:
					if (A_1 <= 3)
					{
						num2 = (short)1497300995;
						num3 = (int)((global::System.IntPtr)num2);
						continue;
					}
					result = this.b(A_0);
					num2 = (short)176337556;
					short num4 = num2;
					num2 = (short)595636884;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)1337982976;
						if (num2 != 0)
						{
						}
						num2 = (short)1587937281;
						num3 = (int)((global::System.IntPtr)num2);
						continue;
					}
					IL_75:
					num2 = (short)266600450;
					num3 = (int)((global::System.IntPtr)num2);
					continue;
					IL_F9:
					num2 = (short)671285248;
					num3 = (int)((global::System.IntPtr)num2);
				}
				IL_110:;
			}
			catch (global::System.Exception ex)
			{
				throw ex;
			}
			num2 = (short)1201864704;
			short num5 = num2;
			num2 = (short)965804033;
			if (num2 != 0)
			{
			}
			return result;
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00020CA4 File Offset: 0x0001EEA4
		private string a(byte[] A_0)
		{
			int a_ = 18;
			switch (0)
			{
			case 0:
				goto IL_31;
			}
			int num;
			short num2;
			string text;
			for (;;)
			{
				IL_13:
				int num5;
				switch (num)
				{
				case 0:
				{
					num2 = (short)1418461184;
					short num3 = num2;
					if (A_0 != null)
					{
						num2 = (short)1042612229;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return text;
				}
				case 1:
					goto IL_91;
				case 2:
					goto IL_91;
				case 3:
				{
					num2 = (short)1205001722;
					short num4 = num2;
					num2 = (short)1309269498;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_15A;
					default:
						goto IL_FB;
					}
					break;
				}
				case 4:
					if (num5 >= 8)
					{
						num2 = (short)1819148291;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					text += string.Format(global::ASK.Core.StatusMsg.b("㕍恏桑ⱓ摕╗", a_), A_0[num5]);
					num5++;
					num2 = (short)1755119618;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					goto IL_15A;
				}
				goto IL_31;
				IL_91:
				num2 = (short)1752891396;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_15A:
				num2 = (short)1531969537;
				if (num2 != 0)
				{
				}
				num5 = 0;
				num2 = (short)885325825;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_FB:
			num2 = (short)186122240;
			if (num2 != 0)
			{
			}
			return text;
			IL_31:
			text = null;
			num2 = (short)907149312;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00020E58 File Offset: 0x0001F058
		private global::ASK.Interface.HardwareKeyFamily c(global::RMIBtnWrapperLib.IIBtnWrapper A_0)
		{
			int a_ = 2;
			short num;
			global::ASK.Interface.HardwareKeyFamily result;
			for (;;)
			{
				num = (short)346292224;
				short num2 = num;
				result = global::ASK.Interface.HardwareKeyFamily.Unknown;
				try
				{
					result = (global::ASK.Interface.HardwareKeyFamily)A_0.GetROMSerialNum()[0];
				}
				catch (global::System.Exception innerException)
				{
					throw new global::System.Exception(global::ASK.Core.StatusMsg.b("礽┿㙁Ƀ❅╇⍉⁋㝍灏㑑㕓㽕㑗㽙㡛罝", a_), innerException);
				}
				num = (short)1397555201;
				if (num != 0)
				{
				}
				num = (short)1938156929;
				short num3 = num;
				num = (short)1169616257;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_B4;
				}
			}
			IL_B4:
			num = (short)1917124608;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00020F40 File Offset: 0x0001F140
		private string b(global::RMIBtnWrapperLib.IIBtnWrapper A_0)
		{
			int a_ = 14;
			short num = (short)1767440385;
			if (num != 0)
			{
			}
			num = (short)9961472;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				string text = null;
				try
				{
					switch (0)
					{
					case 0:
						goto IL_77;
					}
					int num3;
					byte[] romserialNum;
					for (;;)
					{
						IL_5C:
						switch (num2)
						{
						case 0:
							goto IL_16E;
						case 1:
							num = (short)421003264;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
						{
							if (num3 >= 0)
							{
								text += string.Format(global::ASK.Core.StatusMsg.b("ㅉ籋瑍⡏恑⥓", a_), romserialNum[num3]);
								num3--;
								num = (short)1402667011;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)263654975;
							short num4 = num;
							num = (short)1378815551;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_D3;
							default:
								num = (short)119341056;
								if (num != 0)
								{
								}
								num = (short)1315897345;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 3:
							goto IL_D3;
						case 4:
							goto IL_D5;
						}
						goto IL_77;
						IL_D5:
						num = (short)377552898;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_D3:
						goto IL_D5;
					}
					IL_16E:
					goto IL_186;
					IL_77:
					romserialNum = A_0.GetROMSerialNum();
					num3 = 7;
					num = (short)1251999748;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_5C;
				}
				catch (global::System.Exception innerException)
				{
					throw new global::System.Exception(global::ASK.Core.StatusMsg.b("൉⥋㩍ɏ㵑㥓Օᙗ穙㩛㽝य़๡ţɥ䥧", a_), innerException);
				}
				IL_186:
				num = (short)216334336;
				short num5 = num;
				return text;
			}
			}
		}

		// Token: 0x060000FC RID: 252 RVA: 0x0002111C File Offset: 0x0001F31C
		private bool a(global::RMIBtnWrapperLib.IIBtnWrapper A_0, int A_1, ref byte[] A_2, out short A_3)
		{
			int a_ = 5;
			short num = (short)181075968;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)778108928;
				short num3 = num;
				bool result = true;
				A_3 = 0;
				try
				{
					num = (short)176406938;
					short num4 = num;
					num = (short)671269274;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_26D:
						goto IL_29A;
					default:
						num = (short)1606418432;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_E2;
						}
						break;
					}
					string fileName;
					for (;;)
					{
						IL_AF:
						switch (num2)
						{
						case 0:
							goto IL_1E9;
						case 1:
							goto IL_215;
						case 2:
							switch (A_1)
							{
							case 0:
								fileName = global::ASK.Core.StatusMsg.b("ీɂᙄె杈筊", a_);
								num = (short)2137260039;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								fileName = global::ASK.Core.StatusMsg.b("ੀق᱄ᑆ杈筊", a_);
								num = (short)1353056264;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								fileName = global::ASK.Core.StatusMsg.b("Հɂᅄن杈筊", a_);
								num = (short)936181766;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
								fileName = global::ASK.Core.StatusMsg.b("ీ၂ᅄᕆ杈筊", a_);
								num = (short)2074869761;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
								fileName = global::ASK.Core.StatusMsg.b("เᝂфᝆ杈筊", a_);
								num = (short)549060609;
								if (num != 0)
								{
								}
								num = (short)1005256713;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 5:
								fileName = global::ASK.Core.StatusMsg.b("ీੂᙄᕆ杈筊", a_);
								num = (short)1504772099;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							default:
								num = (short)871694346;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 3:
							goto IL_155;
						case 4:
							fileName = null;
							result = false;
							num = (short)876871680;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							goto IL_309;
						case 6:
							goto IL_298;
						case 7:
							goto IL_26D;
						case 8:
							goto IL_243;
						case 9:
							goto IL_1C7;
						case 10:
							num = (short)1241513988;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E2;
					}
					IL_155:
					IL_1C7:
					IL_1E9:
					IL_215:
					IL_243:
					IL_298:
					goto IL_29A;
					IL_309:
					return result;
					IL_E2:
					fileName = null;
					num = (short)143917058;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_AF;
					IL_29A:
					short num5 = 400;
					A_0.GetMaxFileSpace(fileName, out A_3);
					A_0.GetFileSize(fileName, ref num5);
					byte[] sourceArray = new byte[(int)num5];
					A_3 = 0;
					A_0.ReadFile(fileName, ref A_3, out sourceArray);
					byte[] array = new byte[(int)A_3];
					global::System.Array.Copy(sourceArray, 0, array, 0, array.Length);
					new global::AcpCryptoLib.AcpIBtnEncyptDecrpt().Decrypt(array, out A_2);
					num = (short)168624133;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_AF;
				}
				catch (global::RMIBtnWrapperLib.TMEXException ex)
				{
					if (ex.ErrorCode == -6)
					{
						result = false;
					}
				}
				catch (global::System.Exception ex2)
				{
					result = false;
					throw ex2;
				}
				return result;
			}
			}
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00021480 File Offset: 0x0001F680
		internal bool a(global::RMIBtnWrapperLib.IIBtnWrapper A_0, string A_1, bool A_2)
		{
			bool result = false;
			short num;
			try
			{
				num = (short)1889468417;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						A_0.CloseButton();
						num = (short)690618371;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_44;
						}
						continue;
					case 2:
						goto IL_165;
					case 3:
						goto IL_14E;
					case 4:
						if (!A_2)
						{
							num = (short)1520697344;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_14E;
					case 5:
						num = (short)1355808769;
						if (num != 0)
						{
						}
						goto IL_112;
					case 6:
					{
						int options = 0;
						A_0.OpenNonMotoBtn(options);
						num = (short)487930542;
						short num3 = num;
						num = (short)688011950;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_11A;
						default:
							num = (short)1932132352;
							if (num != 0)
							{
							}
							num = (short)1510604805;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					IL_44:
					if (!A_2)
					{
						num = (short)1762983942;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_112;
					IL_11A:
					num = (short)696123396;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_112:
					result = A_0.DoesFileExist(A_1);
					goto IL_11A;
					IL_14E:
					num = (short)362610690;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_165:;
			}
			catch (global::System.Exception ex)
			{
				throw ex;
			}
			finally
			{
				num = (short)148504578;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						A_0.CloseButton();
						num = (short)1809252353;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_1CD;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_198;
						}
						continue;
					}
					IL_198:
					if (A_2)
					{
						break;
					}
					num = (short)290258944;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1CD:;
			}
			num = (short)554237952;
			short num4 = num;
			return result;
		}

		// Token: 0x060000FE RID: 254 RVA: 0x000216BC File Offset: 0x0001F8BC
		private bool b(global::RMIBtnWrapperLib.IIBtnWrapper A_0, ref bool A_1)
		{
			int a_ = 13;
			short num = (short)559628053;
			short num2 = num;
			num = (short)186662677;
			switch (num2 == num)
			{
			}
			num = (short)452067329;
			if (num != 0)
			{
			}
			num = (short)305397760;
			if (num != 0)
			{
			}
			num = (short)996409344;
			short num3 = num;
			return this.a(A_0, global::ASK.Core.StatusMsg.b("Ɉ๊ᑌᱎ罐捒", a_), A_1);
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00021784 File Offset: 0x0001F984
		private bool a(global::RMIBtnWrapperLib.IIBtnWrapper A_0, ref bool A_1)
		{
			int a_ = 12;
			short num = (short)931814243;
			short num2 = num;
			num = (short)2006801251;
			switch (num2 == num)
			{
			}
			num = (short)1792212992;
			if (num != 0)
			{
			}
			num = (short)711852033;
			if (num != 0)
			{
			}
			num = (short)856162304;
			short num3 = num;
			return this.a(A_0, global::ASK.Core.StatusMsg.b("Շ᥉ᡋᱍ繏扑", a_), A_1);
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00021850 File Offset: 0x0001FA50
		public bool IsFormated(global::RMIBtnWrapperLib.IIBtnWrapper spIBtn, ref bool pbOpen)
		{
			int a_ = 15;
			short num = (short)1478371472;
			short num2 = num;
			num = (short)1488398480;
			switch (num2 == num)
			{
			}
			num = (short)1186725889;
			if (num != 0)
			{
			}
			num = (short)725680128;
			if (num != 0)
			{
			}
			num = (short)1172701184;
			short num3 = num;
			return this.a(spIBtn, global::ASK.Core.StatusMsg.b("يౌᱎᩐ絒敔", a_), pbOpen);
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00021918 File Offset: 0x0001FB18
		private bool a(global::RMIBtnWrapperLib.IIBtnWrapper A_0, int A_1, string A_2)
		{
			int a_ = 13;
			short num = (short)202571776;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_6C;
				}
				string text;
				bool result;
				for (;;)
				{
					IL_31:
					string text2;
					switch (num2)
					{
					case 0:
						goto IL_31B;
					case 1:
						goto IL_1B4;
					case 2:
						if (this.a(A_0, A_1) != text)
						{
							num = (short)127729674;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						result = true;
						num = (short)490405889;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_2DB;
					case 4:
					{
						if (A_2 == null)
						{
							num = (short)1851195399;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1819148288;
						short num3 = num;
						text = A_2;
						num = (short)905838603;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						if (this.a(A_0, text2, true))
						{
							num = (short)1494155270;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						result = false;
						global::System.Diagnostics.Trace.WriteLine(global::ASK.Core.StatusMsg.b("཈≊⅌⩎煐㝒㩔㉖⩘筚㍜ぞᕠ䍢dὦhᡪᥬ乮", a_));
						num = (short)2080309257;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
					{
						string fileName = text2;
						short num4 = 400;
						short num5 = 400;
						A_0.GetMaxFileSpace(fileName, out num4);
						A_0.GetFileSize(fileName, ref num5);
						num = (short)834207746;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
					{
						text = this.a(A_0, -1);
						num = (short)1603936724;
						short num6 = num;
						num = (short)1735008724;
						switch ((num6 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_103;
						default:
							num = (short)1924726784;
							if (num != 0)
							{
							}
							num = (short)2141650947;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 8:
						if (text2 == null)
						{
							num = (short)1164705792;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)117178373;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						goto IL_2C5;
					case 10:
						result = false;
						global::System.Diagnostics.Trace.WriteLine(string.Format(global::ASK.Core.StatusMsg.b("䍈䉊䑌敎筐祒罔絖獘煚絜⑞兠Ṣ䕤ᑦ౨ᥪѬ๮ᵰ卲᭴ɶᑸ᥺᡼ൾꆀ愈ꮊ뎒뾞얠욢펤캦쪨캪趬\udcae풰솲\udcb4횶햸鮺펼쪾곀ꇂꃄ뗆﯐戮ￔ﷖헞", a_), text2));
						num = (short)2069561356;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						goto IL_2DB;
					case 12:
						goto IL_103;
					}
					goto IL_6C;
					IL_2DB:
					text2 = this.a(A_1);
					num = (short)619380744;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_103:
				IL_1B4:
				IL_2C5:
				return result;
				IL_31B:
				throw new global::System.Exception(global::ASK.Core.StatusMsg.b("HՊ᥌੎͐ᵒᑔ᭖祘୚ཛྷၞ♠ㅢ⑤⩦䥨⹪㽬㵮㹰ⅲ啴噶塸婺", a_));
				IL_6C:
				num = (short)2118516737;
				if (num != 0)
				{
				}
				result = false;
				text = null;
				num = (short)383320068;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00021C44 File Offset: 0x0001FE44
		private bool a(global::RMIBtnWrapperLib.IIBtnWrapper A_0)
		{
			short num = (short)1912484151;
			short num2 = num;
			num = (short)520433975;
			switch (num2 == num)
			{
			}
			num = (short)307036160;
			if (num != 0)
			{
			}
			num = (short)1128398849;
			if (num != 0)
			{
			}
			num = (short)591331328;
			short num3 = num;
			return this.a(A_0, 1, null);
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00021CF4 File Offset: 0x0001FEF4
		private string a(int A_0)
		{
			int a_ = 10;
			switch (0)
			{
			case 0:
				goto IL_41;
			}
			int num;
			string result;
			short num2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					return result;
				case 1:
					return result;
				case 2:
					return result;
				case 3:
					goto IL_E2;
				case 4:
				{
					num2 = (short)1436483584;
					short num3 = num2;
					switch (A_0)
					{
					case 0:
						result = global::ASK.Core.StatusMsg.b("୅े᥉݋恍恏", a_);
						num2 = (short)1553924101;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 1:
						result = global::ASK.Core.StatusMsg.b("൅േፉὋ恍恏", a_);
						num2 = (short)1390805000;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 2:
						result = global::ASK.Core.StatusMsg.b("Ʌेṉോ恍恏", a_);
						num2 = (short)1062862850;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 3:
						result = global::ASK.Core.StatusMsg.b("୅ᭇṉṋ恍恏", a_);
						num2 = (short)1579352065;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 4:
						result = global::ASK.Core.StatusMsg.b("ॅ᱇୉᱋恍恏", a_);
						num2 = (short)2141650947;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 5:
						result = global::ASK.Core.StatusMsg.b("୅Ň᥉ṋ恍恏", a_);
						num2 = (short)1989214214;
						num = (int)((global::System.IntPtr)num2);
						continue;
					default:
						num2 = (short)2134310921;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 5:
					goto IL_10E;
				case 6:
					goto IL_211;
				case 7:
					result = null;
					num2 = (short)1881341952;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					return result;
				case 9:
					num2 = (short)312344583;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_41;
			}
			IL_E2:
			return result;
			IL_10E:
			num2 = (short)614695363;
			short num4 = num2;
			num2 = (short)1502249411;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_211:
				break;
			default:
				num2 = (short)868483073;
				if (num2 != 0)
				{
				}
				num2 = (short)730398720;
				if (num2 != 0)
				{
				}
				break;
			}
			return result;
			IL_41:
			result = null;
			num2 = (short)999882756;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00021F68 File Offset: 0x00020168
		private bool a(global::RMIBtnWrapperLib.IIBtnWrapper A_0, ref string A_1)
		{
			short num = (short)1092153970;
			short num2 = num;
			num = (short)1597895282;
			bool result;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)162070528;
				short num3 = num;
				num = (short)2140209153;
				if (num != 0)
				{
				}
				num = (short)208732160;
				if (num != 0)
				{
				}
				result = false;
				try
				{
					switch (0)
					{
					case 0:
						goto IL_D2;
					}
					int num4;
					int num5;
					int count;
					for (;;)
					{
						IL_AC:
						switch (num4)
						{
						case 0:
							result = true;
							num = (short)1303314434;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_1CC;
						case 2:
							goto IL_1B4;
						case 3:
							if (num5 >= count)
							{
								num = (short)891748359;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)401211398;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							goto IL_146;
						case 5:
							goto IL_146;
						case 6:
							if (A_1 == (string)global::ASK.Core.KeyRecordSet.ExpiredSerialNumList[num5])
							{
								num = (short)967966720;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							num5++;
							num = (short)942800900;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
							goto IL_1B4;
						}
						goto IL_D2;
						IL_146:
						num = (short)174391299;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_1B4:
						num = (short)246415361;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_1CC:
					break;
					IL_D2:
					A_1 = this.b(A_0);
					count = global::ASK.Core.KeyRecordSet.ExpiredSerialNumList.Count;
					num5 = 0;
					num = (short)1935212549;
					num4 = (int)((global::System.IntPtr)num);
					goto IL_AC;
				}
				catch (global::System.Exception ex)
				{
					result = false;
					throw ex;
				}
				break;
			}
			}
			return result;
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00022164 File Offset: 0x00020364
		public bool HighWaterMarkSupported(ref global::ASK.Core.HardwareKey hKey, ref global::RMIBtnWrapperLib.MultiBtnWrapper btnWrapper)
		{
			int a_ = 18;
			switch (0)
			{
			case 0:
				goto IL_45;
			}
			int num;
			short num2;
			bool result;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					if (hKey.KeyFamily == global::ASK.Interface.HardwareKeyFamily.DS1996)
					{
						num2 = (short)1462304771;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 1:
					if (!hKey.IsMaster)
					{
						num2 = (short)1013973002;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 2:
					return result;
				case 3:
					goto IL_1E0;
				case 4:
				{
					result = true;
					num2 = (short)1736775156;
					short num3 = num2;
					num2 = (short)652809716;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_136;
					default:
						num2 = (short)1189019648;
						if (num2 != 0)
						{
						}
						num2 = (short)823263234;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 5:
					if (hKey.Version > 4)
					{
						num2 = (short)615514112;
						short num4 = num2;
						num2 = (short)1834876934;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 6:
					num2 = (short)1647640577;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					if (!btnWrapper.DoesFileExist(global::ASK.Core.StatusMsg.b("͍᥏őٓ硕桗", a_)))
					{
						num2 = (short)393609220;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 8:
					if (hKey.KeyFamily != global::ASK.Interface.HardwareKeyFamily.DS1963)
					{
						num2 = (short)1154154505;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1E0;
				case 9:
					num2 = (short)1660223489;
					if (num2 != 0)
					{
					}
					goto IL_136;
				case 10:
					num2 = (short)114032647;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_45;
				IL_136:
				num2 = (short)1429733376;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_1E0:
				num2 = (short)606994437;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_45:
			result = false;
			num2 = (short)1458438152;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000106 RID: 262 RVA: 0x000223BC File Offset: 0x000205BC
		public bool HighWaterMarkValidation(global::System.DateTime keyDate)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			bool result;
			short num2;
			global::System.DateTime value;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					return result;
				case 1:
					goto IL_52;
				case 2:
				{
					num2 = (short)1251217411;
					short num3 = num2;
					num2 = (short)645271555;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_52;
					default:
						num2 = (short)1542389760;
						if (num2 != 0)
						{
						}
						result = false;
						num2 = (short)1235025920;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				}
				goto IL_1C;
				IL_52:
				num2 = (short)1322057729;
				if (num2 != 0)
				{
				}
				if (keyDate.CompareTo(value) <= 0)
				{
					break;
				}
				num2 = (short)330760192;
				short num4 = num2;
				num2 = (short)1759117314;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_1C:
			result = true;
			value = global::System.DateTime.Now.ToUniversalTime();
			value = value.AddHours(4.0);
			num2 = (short)350420993;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000107 RID: 263 RVA: 0x000224FC File Offset: 0x000206FC
		public void EraseData(ref global::RMIBtnWrapperLib.MultiBtnWrapper btnWrapper)
		{
			int a_ = 14;
			short num = (short)348343191;
			short num2 = num;
			num = (short)709512087;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)399310848;
				short num3 = num;
				num = (short)1198850049;
				if (num != 0)
				{
				}
				num = (short)935788544;
				if (num != 0)
				{
				}
				string fileName = string.Empty;
				try
				{
					switch (0)
					{
					case 0:
						goto IL_EF;
					}
					int num4;
					for (;;)
					{
						IL_B5:
						switch (num4)
						{
						case 0:
							goto IL_2C7;
						case 1:
							goto IL_23E;
						case 2:
							goto IL_2B0;
						case 3:
							if (btnWrapper.DoesFileExist(fileName))
							{
								num = (short)776929286;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2B0;
						case 4:
							btnWrapper.DeleteFile(fileName);
							num = (short)1469317128;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							if (btnWrapper.DoesFileExist(fileName))
							{
								num = (short)493944836;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_188;
						case 6:
							btnWrapper.DeleteFile(fileName);
							num = (short)600834050;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
							btnWrapper.DeleteFile(fileName);
							num = (short)643235852;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
							goto IL_188;
						case 9:
							btnWrapper.DeleteFile(fileName);
							num = (short)864616449;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 10:
							if (btnWrapper.DoesFileExist(fileName))
							{
								num = (short)904527879;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_138;
						case 11:
							if (btnWrapper.DoesFileExist(fileName))
							{
								num = (short)529530889;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_23E;
						case 12:
							goto IL_138;
						}
						goto IL_EF;
						IL_138:
						fileName = global::ASK.Core.StatusMsg.b("้ോᩍᅏ籑摓", a_);
						num = (short)565444619;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_188:
						fileName = global::ASK.Core.StatusMsg.b("݉ോᵍ᭏籑摓", a_);
						num = (short)948633603;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_23E:
						fileName = global::ASK.Core.StatusMsg.b("ՉᡋཌྷO籑摓", a_);
						num = (short)865009669;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_2B0:
						num = (short)2010054656;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_2C7:
					break;
					IL_EF:
					fileName = global::ASK.Core.StatusMsg.b("ŉोᝍ͏籑摓", a_);
					num = (short)253558794;
					num4 = (int)((global::System.IntPtr)num);
					goto IL_B5;
				}
				catch (global::System.Exception)
				{
				}
				break;
			}
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000108 RID: 264 RVA: 0x000227F4 File Offset: 0x000209F4
		// (set) Token: 0x06000109 RID: 265 RVA: 0x000228B4 File Offset: 0x00020AB4
		internal global::System.DateTime FinalExpirationDate
		{
			get
			{
				short num = (short)865328612;
				short num2 = num;
				num = (short)1550966244;
				switch (num2 == num)
				{
				default:
				{
					num = (short)964100096;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)784990209;
				if (num != 0)
				{
				}
				num = (short)1047330816;
				if (num != 0)
				{
				}
				return global::ASK.Core.Constants.ReferenceDate.AddDays((double)this.p);
			}
			set
			{
				short num = (short)1431421953;
				short num2 = num;
				num = (short)1539097601;
				switch (num2 == num)
				{
				default:
				{
					num = (short)377683968;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2004680704;
				if (num != 0)
				{
				}
				num = (short)403177473;
				if (num != 0)
				{
				}
				global::System.DateTime dateTime = value;
				this.p = (short)dateTime.Subtract(global::ASK.Core.Constants.ReferenceDate).Days;
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x0600010A RID: 266 RVA: 0x0002297C File Offset: 0x00020B7C
		internal short DaysToFinalExpiration
		{
			get
			{
				short num = (short)1153524544;
				short num2 = num;
				num = (short)555901760;
				switch (num2 == num)
				{
				default:
				{
					num = (short)6356992;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)485031937;
				if (num != 0)
				{
				}
				num = (short)1901395968;
				if (num != 0)
				{
				}
				return this.p;
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x0600010B RID: 267 RVA: 0x00022A2C File Offset: 0x00020C2C
		// (set) Token: 0x0600010C RID: 268 RVA: 0x00022ADC File Offset: 0x00020CDC
		public global::ASK.Interface.KeyExpirationType ExpirationType
		{
			get
			{
				short num = (short)903708855;
				short num2 = num;
				num = (short)1880457399;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2102591488;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1642266625;
				if (num != 0)
				{
				}
				num = (short)620560384;
				if (num != 0)
				{
				}
				return this.o;
			}
			set
			{
				short num = (short)377231552;
				short num2 = num;
				num = (short)1061820608;
				switch (num2 == num)
				{
				default:
				{
					num = (short)12255232;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)408289280;
				if (num != 0)
				{
				}
				num = (short)284033025;
				if (num != 0)
				{
				}
				this.o = value;
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x0600010D RID: 269 RVA: 0x00022B8C File Offset: 0x00020D8C
		// (set) Token: 0x0600010E RID: 270 RVA: 0x00022C40 File Offset: 0x00020E40
		public global::System.DateTime ExpirationDate
		{
			get
			{
				short num = (short)597102682;
				short num2 = num;
				num = (short)1121259610;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1598685184;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2131296257;
				if (num != 0)
				{
				}
				num = (short)66912256;
				if (num != 0)
				{
				}
				return this.r;
			}
			set
			{
				short num = (short)915384376;
				short num2 = num;
				num = (short)1290315832;
				switch (num2 == num)
				{
				default:
				{
					num = (short)713687040;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1448411137;
				if (num != 0)
				{
				}
				num = (short)322568192;
				if (num != 0)
				{
				}
				this.r = value;
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x0600010F RID: 271 RVA: 0x00022CF0 File Offset: 0x00020EF0
		internal string ExpirationDateString
		{
			get
			{
				if (this.i)
				{
					short num = (short)342016022;
					short num2 = num;
					num = (short)342409238;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_B3;
					case 1:
						break;
					default:
					{
						num = (short)1135411200;
						short num3 = num;
						break;
					}
					}
					num = (short)1986134017;
					if (num != 0)
					{
					}
					num = (short)662044672;
					if (num != 0)
					{
					}
					return this.r.ToShortDateString();
				}
				IL_B3:
				return null;
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000110 RID: 272 RVA: 0x00022DB4 File Offset: 0x00020FB4
		// (set) Token: 0x06000111 RID: 273 RVA: 0x00022E64 File Offset: 0x00021064
		public short DaysToExpiration
		{
			get
			{
				short num = (short)596770817;
				if (num != 0)
				{
				}
				num = (short)1732509696;
				short num2 = num;
				num = (short)284853023;
				short num3 = num;
				num = (short)1841922847;
				switch (num3 == num)
				{
				}
				num = (short)1260453888;
				if (num != 0)
				{
				}
				return this.s;
			}
			set
			{
				short num = (short)479068161;
				if (num != 0)
				{
				}
				num = (short)1274019840;
				short num2 = num;
				num = (short)63463838;
				short num3 = num;
				num = (short)1207198110;
				switch (num3 == num)
				{
				}
				num = (short)1594032128;
				if (num != 0)
				{
				}
				this.s = value;
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000112 RID: 274 RVA: 0x00022F14 File Offset: 0x00021114
		// (set) Token: 0x06000113 RID: 275 RVA: 0x00022FD8 File Offset: 0x000211D8
		internal short ProgrammingCount
		{
			get
			{
				if (this.i)
				{
					short num = (short)804684527;
					short num2 = num;
					num = -32017;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return 0;
					case 1:
						break;
					default:
					{
						num = (short)1858142208;
						short num3 = num;
						break;
					}
					}
					num = (short)434241536;
					if (num != 0)
					{
					}
					num = (short)1923284993;
					if (num != 0)
					{
					}
					return this.t;
				}
				return 0;
			}
			set
			{
				short num = (short)762511361;
				if (num != 0)
				{
				}
				num = (short)901120000;
				short num2 = num;
				num = (short)1730543838;
				short num3 = num;
				num = (short)1940324574;
				switch (num3 == num)
				{
				}
				num = (short)644808704;
				if (num != 0)
				{
				}
				this.t = value;
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000114 RID: 276 RVA: 0x00023088 File Offset: 0x00021288
		// (set) Token: 0x06000115 RID: 277 RVA: 0x00023138 File Offset: 0x00021338
		public global::System.DateTime LastDateProgrammed
		{
			get
			{
				short num = (short)227331132;
				short num2 = num;
				num = (short)1402129468;
				switch (num2 == num)
				{
				default:
				{
					num = (short)902889472;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)174915585;
				if (num != 0)
				{
				}
				num = (short)1623654400;
				if (num != 0)
				{
				}
				return this.u;
			}
			set
			{
				short num = (short)1969454322;
				short num2 = num;
				num = (short)1258781938;
				switch (num2 == num)
				{
				default:
				{
					num = (short)358481920;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)340000769;
				if (num != 0)
				{
				}
				num = (short)30277632;
				if (num != 0)
				{
				}
				this.u = value;
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000116 RID: 278 RVA: 0x000231E8 File Offset: 0x000213E8
		internal bool IsExpired
		{
			get
			{
				short num = (short)1415420271;
				short num2 = num;
				num = (short)1410898287;
				switch (num2 == num)
				{
				default:
				{
					num = (short)281149440;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)90112000;
				if (num != 0)
				{
				}
				num = (short)116326401;
				if (num != 0)
				{
				}
				return this.q;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000117 RID: 279 RVA: 0x0002329C File Offset: 0x0002149C
		internal byte[] SerialNumBytes
		{
			get
			{
				short num = (short)1904136829;
				short num2 = num;
				num = (short)1559220861;
				switch (num2 == num)
				{
				default:
				{
					num = (short)640155648;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)369033217;
				if (num != 0)
				{
				}
				num = (short)1868431360;
				if (num != 0)
				{
				}
				return this.c;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000118 RID: 280 RVA: 0x0002334C File Offset: 0x0002154C
		public string SerialNumber
		{
			get
			{
				short num = (short)1624315908;
				short num2 = num;
				num = (short)222369796;
				switch (num2 == num)
				{
				default:
				{
					num = (short)638451712;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2035351553;
				if (num != 0)
				{
				}
				num = (short)1379467264;
				if (num != 0)
				{
				}
				return this.b;
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000119 RID: 281 RVA: 0x000233F8 File Offset: 0x000215F8
		public global::ASK.Interface.HardwareKeyFamily KeyFamily
		{
			get
			{
				short num = (short)1608450049;
				if (num != 0)
				{
				}
				num = (short)1209335808;
				short num2 = num;
				num = (short)366973796;
				short num3 = num;
				num = (short)1425380196;
				switch (num3 == num)
				{
				}
				num = (short)1699938304;
				if (num != 0)
				{
				}
				return this.f;
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x0600011A RID: 282 RVA: 0x000234A8 File Offset: 0x000216A8
		internal string SerialNumberAndFamily
		{
			get
			{
				int a_ = 7;
				short num = (short)1067316084;
				short num2 = num;
				num = (short)927921012;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2064908288;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2123431936;
				if (num != 0)
				{
				}
				num = (short)18087937;
				if (num != 0)
				{
				}
				return string.Format(global::ASK.Core.StatusMsg.b("㡂畄㩆楈歊敌㑎恐⹒籔", a_), this.b, this.f);
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x0600011B RID: 283 RVA: 0x00023580 File Offset: 0x00021780
		public bool IsMaster
		{
			get
			{
				short num = (short)1006655826;
				short num2 = num;
				num = (short)371939666;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1106051072;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)274137089;
				if (num != 0)
				{
				}
				num = (short)574160896;
				if (num != 0)
				{
				}
				return this.g;
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x0600011C RID: 284 RVA: 0x00023630 File Offset: 0x00021830
		public bool IsAdvancedSystemKey
		{
			get
			{
				short num = (short)2028995612;
				short num2 = num;
				num = (short)1638532124;
				switch (num2 == num)
				{
				default:
				{
					num = (short)757334016;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)389611521;
				if (num != 0)
				{
				}
				num = (short)282460160;
				if (num != 0)
				{
				}
				return this.h;
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x0600011D RID: 285 RVA: 0x000236E4 File Offset: 0x000218E4
		internal bool HasOTAPEnabledSystem
		{
			get
			{
				short num = (short)301203456;
				short num2 = num;
				bool result = false;
				global::System.Collections.Generic.IEnumerator<global::ASK.Core.IKeyDataRecord> enumerator = this.d.GetEnumerator();
				try
				{
					num = (short)643235844;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							goto IL_156;
						case 1:
							num = (short)150142976;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							result = true;
							num = (short)1191182339;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							goto IL_139;
						case 4:
							switch (0)
							{
							case 0:
								goto IL_79;
							}
							continue;
						case 5:
							num = (short)1942683649;
							if (num != 0)
							{
							}
							if (((global::ASK.Core.KeyDataRecord)enumerator.Current).OTAPState)
							{
								num = (short)1544945666;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 6:
							if (!enumerator.MoveNext())
							{
								num = (short)555155457;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1340801029;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_E4:
						num = (short)1375404038;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_79:
						goto IL_E4;
					}
					IL_139:
					IL_156:;
				}
				finally
				{
					num = (short)1179975681;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							goto IL_213;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_18D;
							}
							continue;
						case 2:
						{
							num = (short)907254460;
							short num4 = num;
							num = (short)1865063100;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_215;
							default:
								num = (short)1604780032;
								if (num != 0)
								{
								}
								enumerator.Dispose();
								num = (short)626982912;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						}
						IL_18D:
						if (enumerator == null)
						{
							break;
						}
						num = (short)1460535298;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_213:
					IL_215:;
				}
				return result;
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x0600011E RID: 286 RVA: 0x00023924 File Offset: 0x00021B24
		// (set) Token: 0x0600011F RID: 287 RVA: 0x000239D8 File Offset: 0x00021BD8
		internal bool IsPaswordProtected
		{
			get
			{
				short num = (short)1453890084;
				short num2 = num;
				num = (short)2111543844;
				switch (num2 == num)
				{
				default:
				{
					num = (short)876871680;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)463470592;
				if (num != 0)
				{
				}
				num = (short)1228800001;
				if (num != 0)
				{
				}
				return this.l;
			}
			set
			{
				short num = (short)1536140992;
				short num2 = num;
				num = (short)800237248;
				switch (num2 == num)
				{
				default:
				{
					num = (short)697303040;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)357564416;
				if (num != 0)
				{
				}
				num = (short)226164737;
				if (num != 0)
				{
				}
				this.l = value;
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000120 RID: 288 RVA: 0x00023A88 File Offset: 0x00021C88
		internal string Password
		{
			get
			{
				short num = (short)1433851970;
				short num2 = num;
				num = (short)1035458626;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1211301888;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1076625409;
				if (num != 0)
				{
				}
				num = (short)795541504;
				if (num != 0)
				{
				}
				return this.m;
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000121 RID: 289 RVA: 0x00023B34 File Offset: 0x00021D34
		public bool IsPasswordUpgradeNeeded
		{
			get
			{
				short num = (short)169209305;
				short num2 = num;
				num = (short)236318169;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1541472256;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)236257281;
				if (num != 0)
				{
				}
				num = (short)2017722368;
				if (num != 0)
				{
				}
				return this.k;
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000122 RID: 290 RVA: 0x00023BE4 File Offset: 0x00021DE4
		internal bool IsValid
		{
			get
			{
				short num = (short)665651969;
				short num2 = num;
				num = (short)654052097;
				switch (num2 == num)
				{
				default:
				{
					num = (short)805437440;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1480458241;
				if (num != 0)
				{
				}
				num = (short)1687224320;
				if (num != 0)
				{
				}
				return this.i;
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000123 RID: 291 RVA: 0x00023C94 File Offset: 0x00021E94
		internal global::ASK.Interface.HardwareKeyStatus KeyStatus
		{
			get
			{
				switch (0)
				{
				case 0:
					goto IL_34;
				}
				short num2;
				global::ASK.Interface.HardwareKeyStatus result;
				for (;;)
				{
					IL_0A:
					int num;
					switch (num)
					{
					case 0:
						goto IL_FE;
					case 1:
						if (this.q)
						{
							num2 = (short)1324023809;
							if (num2 != 0)
							{
							}
							num2 = (short)1462501379;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)2094530562;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 2:
						if (!this.IsValid)
						{
							num2 = (short)139657222;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					case 3:
						result = global::ASK.Interface.HardwareKeyStatus.Expired;
						num2 = (short)947126276;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 4:
						return result;
					case 5:
						return result;
					case 6:
						num2 = (short)216793096;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 7:
						goto IL_139;
					case 8:
						if (!this.j)
						{
							num2 = (short)1948778503;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						result = global::ASK.Interface.HardwareKeyStatus.Invalid;
						num2 = (short)983040005;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_34;
				}
				IL_FE:
				return result;
				IL_139:
				num2 = (short)767885312;
				short num3 = num2;
				result = global::ASK.Interface.HardwareKeyStatus.Unformatted;
				goto IL_E7;
				IL_34:
				num2 = (short)1030887490;
				short num4 = num2;
				num2 = (short)1435310146;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
				{
					IL_E7:
					num2 = (short)1491664896;
					int num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				default:
				{
					num2 = (short)777519104;
					if (num2 != 0)
					{
					}
					result = global::ASK.Interface.HardwareKeyStatus.Valid;
					num2 = (short)1049362433;
					int num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				}
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000124 RID: 292 RVA: 0x00023E7C File Offset: 0x0002207C
		// (set) Token: 0x06000125 RID: 293 RVA: 0x00023F2C File Offset: 0x0002212C
		public global::ASK.Interface.KeyType Type
		{
			get
			{
				short num = (short)1882259456;
				short num2 = num;
				num = (short)482299087;
				short num3 = num;
				num = (short)1674005711;
				switch (num3 == num)
				{
				}
				num = (short)1252917248;
				if (num != 0)
				{
				}
				num = (short)1307967489;
				if (num != 0)
				{
				}
				return this.e;
			}
			set
			{
				short num = (short)803012608;
				short num2 = num;
				num = (short)326528114;
				short num3 = num;
				num = (short)2002611314;
				switch (num3 == num)
				{
				}
				num = (short)907149313;
				if (num != 0)
				{
				}
				num = (short)1627914240;
				if (num != 0)
				{
				}
				this.e = value;
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000126 RID: 294 RVA: 0x00023FE0 File Offset: 0x000221E0
		// (set) Token: 0x06000127 RID: 295 RVA: 0x00024090 File Offset: 0x00022290
		public global::System.Collections.ObjectModel.ObservableCollection<global::ASK.Core.IKeyDataRecord> KeyDataList
		{
			get
			{
				short num = (short)1792409600;
				short num2 = num;
				num = (short)993595922;
				short num3 = num;
				num = (short)1797263890;
				switch (num3 == num)
				{
				}
				num = (short)205258753;
				if (num != 0)
				{
				}
				num = (short)14745600;
				if (num != 0)
				{
				}
				return this.d;
			}
			set
			{
				short num = (short)1448345600;
				short num2 = num;
				num = (short)891539816;
				short num3 = num;
				num = (short)826331496;
				switch (num3 == num)
				{
				}
				num = (short)83492865;
				if (num != 0)
				{
				}
				num = (short)2130968576;
				if (num != 0)
				{
				}
				this.d = value;
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000128 RID: 296 RVA: 0x00024144 File Offset: 0x00022344
		// (set) Token: 0x06000129 RID: 297 RVA: 0x000241F4 File Offset: 0x000223F4
		public short Version
		{
			get
			{
				short num = (short)1709834240;
				short num2 = num;
				num = (short)1081347115;
				short num3 = num;
				num = (short)787287083;
				switch (num3 == num)
				{
				}
				num = (short)1207369729;
				if (num != 0)
				{
				}
				num = (short)451018752;
				if (num != 0)
				{
				}
				return this.a;
			}
			set
			{
				short num = (short)1943732224;
				short num2 = num;
				num = (short)2012282435;
				short num3 = num;
				num = (short)1962868291;
				switch (num3 == num)
				{
				}
				num = (short)1281687553;
				if (num != 0)
				{
				}
				num = (short)575406080;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x04000065 RID: 101
		private short a;

		// Token: 0x04000066 RID: 102
		private string b;

		// Token: 0x04000067 RID: 103
		private byte[] c;

		// Token: 0x04000068 RID: 104
		private global::System.Collections.ObjectModel.ObservableCollection<global::ASK.Core.IKeyDataRecord> d;

		// Token: 0x04000069 RID: 105
		private global::ASK.Interface.KeyType e;

		// Token: 0x0400006A RID: 106
		private global::ASK.Interface.HardwareKeyFamily f;

		// Token: 0x0400006B RID: 107
		private bool g;

		// Token: 0x0400006C RID: 108
		private bool h;

		// Token: 0x0400006D RID: 109
		private bool i;

		// Token: 0x0400006E RID: 110
		private bool j;

		// Token: 0x0400006F RID: 111
		private bool k;

		// Token: 0x04000070 RID: 112
		private bool l;

		// Token: 0x04000071 RID: 113
		private string m;

		// Token: 0x04000072 RID: 114
		private bool n;

		// Token: 0x04000073 RID: 115
		private global::ASK.Interface.KeyExpirationType o;

		// Token: 0x04000074 RID: 116
		private short p;

		// Token: 0x04000075 RID: 117
		private bool q;

		// Token: 0x04000076 RID: 118
		private global::System.DateTime r;

		// Token: 0x04000077 RID: 119
		private short s;

		// Token: 0x04000078 RID: 120
		private short t;

		// Token: 0x04000079 RID: 121
		private global::System.DateTime u;

		// Token: 0x0400007A RID: 122
		private global::System.Windows.MessageBoxOptions v;

		// Token: 0x0400007B RID: 123
		private string w = global::Motorola.CommonCPS.ResourceRepository.Resources.Application_Name;
	}
}
