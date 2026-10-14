using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Globalization;
using System.Threading;
using System.Windows;
using System.Windows.Media;
using AcpCommonResources;
using AcpCryptoLib;
using AcpUtility;
using IBtnWrapperLib;

namespace AcpASKLib
{
	// Token: 0x02000027 RID: 39
	public class HardwareKey : global::AcpASKLib.IKeyRecord
	{
		// Token: 0x060000D9 RID: 217 RVA: 0x00014794 File Offset: 0x00012994
		public HardwareKey()
		{
			this.d = new global::System.Collections.ObjectModel.ObservableCollection<global::AcpASKLib.IKeyDataRecord>();
			this.b = null;
			this.c = null;
			this.a = 0;
			this.q = false;
			this.e = global::AcpASKLib.KeyType.ADVANCED_SYSTEM_KEY;
			this.f = global::AcpASKLib.HardwareKeyFamily.Unknown;
			this.n = false;
			this.r = global::System.DateTime.Now;
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00014800 File Offset: 0x00012A00
		public HardwareKey(bool usePasswordCache) : this()
		{
			this.x = usePasswordCache;
		}

		// Token: 0x060000DB RID: 219 RVA: 0x0001481C File Offset: 0x00012A1C
		internal uint a(global::IBtnWrapperLib.IIBtnWrapper A_0, bool A_1, bool A_2, int A_3, int A_4)
		{
			int a_ = 5;
			short num;
			for (;;)
			{
				num = (short)1574830080;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					num = (short)112292481;
					short num3 = num;
					num = (short)1290433153;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					case 1:
						goto IL_83;
					}
					goto Block_1;
				}
				}
			}
			Block_1:
			num = (short)1411776512;
			short num4 = num;
			IL_83:
			num = (short)941293568;
			if (num != 0)
			{
			}
			uint num5 = 0U;
			bool flag = true;
			try
			{
				switch (0)
				{
				case 0:
					goto IL_1E3;
				}
				int num2;
				bool flag3;
				for (;;)
				{
					IL_A8:
					bool flag2;
					bool flag4;
					switch (num2)
					{
					case 0:
						num = (short)762904622;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						flag = true;
						this.n = true;
						num5 = 0U;
						num = (short)1676869643;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (this.h)
						{
							num = (short)1693384778;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_31E;
					case 3:
						goto IL_C97;
					case 4:
						flag = false;
						num = (short)1240989746;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						if (num5 == 3758129160U)
						{
							num = (short)1427701769;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_35D;
					case 6:
						num = (short)2096496700;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						if (A_4 == 3)
						{
							num = (short)1176305703;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_40E;
					case 8:
						goto IL_C7E;
					case 9:
						num = (short)1528627235;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						num5 = this.a(A_0, 1, out this.a);
						num = (short)683474967;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						goto IL_C7E;
					case 12:
						goto IL_40E;
					case 13:
						this.g = true;
						num = (short)483131444;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						num5 = this.a(A_0, 0, out this.a);
						this.n = global::AcpASKLib.KeyRecordSet.c(this.b);
						flag2 = A_2;
						this.h = this.b(A_0, ref flag3);
						num = (short)1072758803;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						num5 = 0U;
						num = (short)2029387814;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						flag4 = !this.n;
						goto IL_399;
					case 17:
						num5 = 2684387336U;
						num = (short)630784034;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						num = (short)242155561;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						if (this.h)
						{
							num = (short)303038474;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)659750934;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						if (flag2)
						{
							num = (short)424345672;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C7E;
					case 21:
						if (num5 == 0U)
						{
							num = (short)181600304;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3D6;
					case 22:
						if (this.a(A_0, ref flag3))
						{
							num = (short)850526221;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1562968120;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						if (num5 == 0U)
						{
							num = (short)1243152390;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_40E;
					case 24:
						if (num5 == 2684387330U)
						{
							num = (short)1109262337;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1664745477;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
						goto IL_40E;
					case 26:
						goto IL_40E;
					case 27:
						if (num5 == 0U)
						{
							num = (short)388563017;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C7E;
					case 28:
						this.l = true;
						num = (short)922353693;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 29:
						goto IL_532;
					case 30:
						goto IL_C7E;
					case 31:
						num = (short)732954694;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 32:
						num = (short)332529717;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 33:
						if (this.m != null)
						{
							num = (short)914358303;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_532;
					case 34:
						goto IL_40E;
					case 35:
						if (A_4 != 1)
						{
							num = (short)171966530;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_35D;
					case 36:
						goto IL_4CB;
					case 37:
						if (num5 == 0U)
						{
							num = (short)1081671698;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C7E;
					case 38:
						goto IL_40E;
					case 39:
						flag2 = false;
						num = (short)264503354;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 40:
						goto IL_C7E;
					case 41:
						if (flag2)
						{
							num = (short)1228472387;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_31E;
					case 42:
						goto IL_3D6;
					case 43:
						if (this.a < 5)
						{
							num = (short)1696727085;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_40E;
					case 44:
						num5 = this.f(A_0);
						num = (short)532152360;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 45:
						num = (short)1811939391;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 46:
						if (this.a >= 3)
						{
							num = (short)1593638927;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num5 = 2684387338U;
						num = (short)1115815962;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 47:
						goto IL_C7E;
					case 48:
						num5 = this.c(A_0, ref this.k);
						num = (short)1330708522;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 49:
						if (this.m != null)
						{
							num = (short)1808203840;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C7E;
					case 50:
						if (A_4 == 1)
						{
							num = (short)2042363921;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num5 = 2684387339U;
						num = (short)780795916;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 51:
						num5 = 3758129160U;
						num = (short)854327350;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 52:
						if (!A_1)
						{
							num = (short)169607219;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C7E;
					case 53:
						if (this.IsFormated(A_0, ref flag3))
						{
							num = (short)2003697678;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num5 = 3758129160U;
						num = (short)1168834590;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 54:
						goto IL_C7E;
					case 55:
						if (flag)
						{
							num = (short)879231035;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C7E;
					case 56:
						if (A_4 == 1)
						{
							num = (short)755171372;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C7E;
					case 57:
						if (A_4 == 1)
						{
							num = (short)1491599429;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4CB;
					case 58:
						goto IL_40E;
					case 59:
						num = (short)1702101041;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 60:
						if (this.a > 5)
						{
							num = (short)2053046276;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)161873963;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 61:
						num = (short)453115975;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 62:
						if (this.m.Length > 0)
						{
							num = (short)946143308;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C7E;
					case 63:
						if (A_4 == 2)
						{
							num = (short)606076989;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1204224007;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 64:
						num = (short)1701969982;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 65:
						flag4 = false;
						goto IL_399;
					case 66:
						flag = false;
						num = (short)1772093508;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 67:
						num = (short)1958739970;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 68:
						goto IL_C7E;
					case 69:
						num5 = this.f(A_0);
						num = (short)1149894692;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 70:
						if (this.m.Length > 0)
						{
							num = (short)579862556;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_532;
					case 71:
						if (global::System.Windows.MessageBox.Show(global::AcpCommonResources.AcpResources.ResourceManager.GetString(global::AcpASKLib.SystemKeyLoadedEventArgs.b("⍡cၥ१ѩཫ୭⽯㥱ᅳཱུ❷⽹౻᥽", a_), global::AcpCommonResources.AcpResources.Culture).AcpStringFormat(new object[]
						{
							this.w
						}), global::AcpCommonResources.AcpResources.ResourceManager.GetString(global::AcpASKLib.SystemKeyLoadedEventArgs.b("ୡ♣፥ᱧṩͫm⽯㵱ѳ፵ᙷ╹㥻౽", a_), global::AcpCommonResources.AcpResources.Culture), global::System.Windows.MessageBoxButton.YesNo, global::System.Windows.MessageBoxImage.Hand, global::System.Windows.MessageBoxResult.Yes, this.v) == global::System.Windows.MessageBoxResult.Yes)
						{
							num = (short)16646144;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						flag = false;
						num5 = 2684387340U;
						num = (short)1101135897;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 72:
						num5 = this.b(A_0, out this.m);
						num = (short)524288033;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 73:
						num = (short)340328505;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 74:
						num = (short)1224933392;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 75:
						if (!global::AcpASKLib.KeyRecordSet.a(this.b))
						{
							num = (short)233504800;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num5 = 2684387329U;
						flag = false;
						num = (short)769261576;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 76:
						num5 = this.a(this.m);
						num = (short)860749871;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1E3;
					IL_31E:
					num = (short)357367873;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_35D:
					num = (short)1431830583;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_399:
					flag2 = flag4;
					num = (short)1383464980;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3D6:
					num = (short)2037579803;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_40E:
					num = (short)499777557;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4CB:
					num = (short)660668453;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_532:
					num = (short)230883352;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_C7E:
					num = (short)502726659;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_C97:
				goto IL_CB7;
				IL_1E3:
				A_0.OpenNonMotoBtn(A_3);
				flag3 = true;
				this.b = this.a(A_0, -1);
				this.c = A_0.GetROMSerialNum();
				this.f = this.c(A_0);
				num = (short)1259864139;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_A8;
			}
			catch (global::System.Exception innerException)
			{
				A_0.CloseButton();
				throw new global::System.Exception(global::AcpASKLib.SystemKeyLoadedEventArgs.b("ⵡᑣͥ٧䩩⹫᭭ѯٱ᭳ᡵ塷ᱹᵻ᝽벅ꢇ", a_), innerException);
			}
			IL_CB7:
			num = (short)1379205121;
			if (num != 0)
			{
			}
			return num5;
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00015524 File Offset: 0x00013724
		private bool e(global::IBtnWrapperLib.IIBtnWrapper A_0)
		{
			bool result = false;
			short num;
			try
			{
				num = (short)958660609;
				if (num != 0)
				{
				}
				num = (short)864831236;
				short num2 = num;
				num = (short)1620264708;
				string text;
				int num3;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_B5:
					if (text == null)
					{
						goto IL_F2;
					}
					num = (short)790953987;
					num3 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)616300544;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_97;
					}
					break;
				}
				for (;;)
				{
					IL_81:
					switch (num3)
					{
					case 0:
						goto IL_B5;
					case 1:
						goto IL_10A;
					case 2:
						goto IL_F0;
					case 3:
						result = (text == this.b);
						num = (short)688521218;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_97;
				}
				IL_F0:
				goto IL_F2;
				IL_10A:
				goto IL_10D;
				IL_97:
				text = this.a(A_0, -1);
				num = (short)2029846528;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_81;
				IL_F2:
				num = (short)597950465;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_81;
			}
			catch (global::System.Exception ex)
			{
				throw ex;
			}
			IL_10D:
			num = (short)928448512;
			short num4 = num;
			return result;
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00015684 File Offset: 0x00013884
		private uint b(global::IBtnWrapperLib.IIBtnWrapper A_0, out string A_1)
		{
			bool flag = false;
			uint num = 0U;
			A_1 = null;
			short num2;
			try
			{
				num2 = (short)777715715;
				int num3 = (int)((global::System.IntPtr)num2);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						num2 = (short)881000452;
						num3 = (int)((global::System.IntPtr)num2);
						continue;
					case 1:
						goto IL_12B;
					case 2:
						goto IL_1B4;
					case 3:
					{
						num2 = (short)690313594;
						short num4 = num2;
						num2 = (short)1522620794;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_12B;
						default:
							num2 = (short)2104885249;
							if (num2 != 0)
							{
							}
							num2 = (short)321716224;
							if (num2 != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_C9;
							}
							continue;
						}
						break;
					}
					case 4:
						if (flag)
						{
							num2 = (short)1699872776;
							num3 = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_1B4;
					case 5:
						goto IL_1CD;
					case 6:
						goto IL_181;
					case 7:
						if (num == 0U)
						{
							num2 = (short)1324679168;
							num3 = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_1B4;
					case 8:
						num = this.GetPswdFromIBtn(A_0, ref A_1);
						num2 = (short)746455042;
						num3 = (int)((global::System.IntPtr)num2);
						continue;
					case 9:
						goto IL_181;
					}
					IL_C9:
					if (this.d(A_0))
					{
						num2 = (short)1124466689;
						num3 = (int)((global::System.IntPtr)num2);
						continue;
					}
					num = 3758129160U;
					num2 = (short)698023945;
					num3 = (int)((global::System.IntPtr)num2);
					continue;
					IL_12B:
					flag = this.a(A_0);
					num2 = (short)313065478;
					num3 = (int)((global::System.IntPtr)num2);
					continue;
					IL_181:
					num2 = (short)1414201351;
					num3 = (int)((global::System.IntPtr)num2);
					continue;
					IL_1B4:
					num2 = (short)928514053;
					num3 = (int)((global::System.IntPtr)num2);
				}
				IL_1CD:;
			}
			catch
			{
				num = 3758129154U;
			}
			num2 = (short)447741952;
			short num5 = num2;
			return num;
		}

		// Token: 0x060000DE RID: 222 RVA: 0x000158B0 File Offset: 0x00013AB0
		private bool d(global::IBtnWrapperLib.IIBtnWrapper A_0)
		{
			short num = (short)110886912;
			short num2 = num;
			num = (short)1024655361;
			if (num != 0)
			{
			}
			num = (short)1766269859;
			short num3 = num;
			num = (short)1737892771;
			switch (num3 == num)
			{
			}
			num = (short)1343225856;
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

		// Token: 0x060000DF RID: 223 RVA: 0x00015974 File Offset: 0x00013B74
		private uint a(global::IBtnWrapperLib.IIBtnWrapper A_0, out global::AcpASKLib.KeyExpirationType A_1, out short A_2, out short A_3, out short A_4, out int A_5, out short A_6)
		{
			int a_ = 0;
			short num = (short)1147666432;
			short num2 = num;
			num = (short)536084481;
			if (num != 0)
			{
			}
			num = (short)49545216;
			int num3 = (int)num;
			switch (num3)
			{
			default:
			{
				A_1 = global::AcpASKLib.KeyExpirationType.Date;
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
						goto IL_F4;
					}
					short num6;
					byte[] sourceArray;
					for (;;)
					{
						IL_9D:
						switch (num3)
						{
						case 0:
						{
							byte[] array;
							int num5;
							byte b = global::AcpASKLib.Global.a(array, (short)(num5 - 1), 0);
							num = (short)1205927937;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
							goto IL_2CA;
						case 2:
							goto IL_257;
						case 3:
							if (9 > num6 - 2)
							{
								num = (short)1156317201;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_13F;
						case 4:
							if (this.a(A_0, 0, ref sourceArray, out num6))
							{
								num = (short)1595670533;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_4A3;
						case 5:
						{
							int num5 = (int)num6;
							byte[] array = new byte[(int)num6];
							global::System.Array.Copy(sourceArray, array, (int)num6);
							num = (short)1681129475;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 6:
							if (num4 == 0U)
							{
								num = (short)1180631053;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_4A3;
						case 7:
							goto IL_4A3;
						case 8:
						{
							byte[] array;
							int num5;
							byte b;
							if (b != array[num5 - 1])
							{
								goto IL_2F0;
							}
							num4 = this.a(array, out A_1, out A_2, out A_3, out A_4, out A_6);
							A_2 = (short)global::AcpASKLib.Constants.ReferenceDate.AddDays((double)A_2).Subtract(global::System.DateTime.Today).Days;
							this.r = global::System.DateTime.Today.AddDays((double)A_2);
							num = (short)969474063;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 9:
							goto IL_4BD;
						case 10:
						{
							if (A_5 < 3)
							{
								num = (short)1235484672;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							byte[] array;
							int num5;
							byte b = global::AcpASKLib.Global.a(array, (short)(num5 - 2), 0);
							num = (short)363462668;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 11:
							goto IL_4A3;
						case 12:
							goto IL_2CA;
						case 13:
						{
							byte[] array;
							A_5 = (int)array[9];
							byte b = 0;
							num = (short)929300490;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 14:
							this.s = -1;
							num = (short)1589182466;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 15:
							if (A_2 < 0)
							{
								num = (short)1760493582;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							this.s = A_2;
							num = (short)1680277522;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 16:
						{
							num = (short)83384634;
							short num7 = num;
							num = (short)796940602;
							switch ((num7 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_2F0;
							default:
								num = (short)2073755648;
								if (num != 0)
								{
								}
								global::System.Diagnostics.Trace.WriteLine(global::AcpASKLib.SystemKeyLoadedEventArgs.b("Ṝ൞≠䍢Ťࡦ౨ᡪͬ䡮հ卲ᡴᙶ൸᡺ᕼ彾ꦈ力뎒\ud894횖쪘킚뎜꾞膠얢첤쮦첨說責ꖮ", a_));
								num4 = 3758129156U;
								num = (short)1730936843;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 17:
							num4 = 3758129161U;
							num = (short)382599187;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 18:
							goto IL_257;
						case 19:
							goto IL_13F;
						}
						goto IL_F4;
						IL_13F:
						num = (short)1517944838;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_257:
						global::System.TimeSpan timeSpan = new global::System.TimeSpan(23, 59, 59);
						this.r = this.r.Date + timeSpan;
						this.LastDateProgrammed = global::AcpASKLib.Constants.ReferenceDate.AddDays((double)A_4);
						this.LastDateProgrammed = this.LastDateProgrammed.AddHours((double)A_6);
						num = (short)1163657223;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_2CA:
						num = (short)702480392;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_2F0:
						num = (short)2058682384;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_4A3:
						num = (short)1378353161;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_4BD:
					return num4;
					IL_F4:
					sourceArray = null;
					num6 = 50;
					num = (short)1900150788;
					num3 = (int)((global::System.IntPtr)num);
					goto IL_9D;
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

		// Token: 0x060000E0 RID: 224 RVA: 0x00015E64 File Offset: 0x00014064
		private uint a(byte[] A_0, out global::AcpASKLib.KeyExpirationType A_1, out short A_2, out short A_3, out short A_4, out short A_5)
		{
			int a_ = 7;
			short num = (short)444661760;
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
				int num7;
				for (;;)
				{
					IL_30:
					switch (num2)
					{
					case 0:
						if (A_0[9] > 4)
						{
							num = (short)161808390;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1A7;
					case 1:
						goto IL_16C;
					case 2:
					{
						num = (short)1604804293;
						short num3 = num;
						num = (short)349593285;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_16C;
						default:
							goto IL_1F6;
						}
						break;
					}
					case 3:
						goto IL_16C;
					case 4:
					{
						int num4;
						if (num4 >= 8)
						{
							num = (short)1755774978;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int num5;
						array[num4] = A_0[num5 + num4];
						num4++;
						num = (short)1598947331;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
					{
						num = (short)113115136;
						short num6 = num;
						num = (short)1415839745;
						if (num != 0)
						{
						}
						array = new byte[8];
						int num5 = num7 - 9;
						int num4 = 0;
						num = (short)2079719425;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						num7 = A_0.Length;
						num = (short)373686277;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_53;
					IL_16C:
					num = (short)1225850884;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1A7:
				uint result = 2684387342U;
				global::System.Diagnostics.Trace.WriteLine(global::AcpASKLib.SystemKeyLoadedEventArgs.b("っ๥൧䩩⵫੭ٯ፱ᩳᕵᵷṹ屻㕽ﮁꒃﮍ늑캟芡춣향袧\udea9쎫솭邯\uddb1\ud8b3튵钷骹\ud8bb톽꺿냃믇뿉볋뻍뿏ꃑꃓ뷗ꋙ곛럝鋟菡郣迥蟧蓩쳫諭釯蛱釳훵駷铹飻\udefd烿瀁欃愅稇欉愋挍礏簑猓㘕笗甙椛瀝吟䜡嘣ࠥ∧", a_));
				return result;
				IL_1F6:
				num = (short)1913585664;
				if (num != 0)
				{
				}
				A_1 = (global::AcpASKLib.KeyExpirationType)array[0];
				A_2 = (short)(array[1] << 8);
				A_2 |= (short)array[2];
				A_3 = (short)(array[3] << 8);
				A_3 |= (short)array[4];
				A_4 = (short)(array[5] << 8);
				A_4 |= (short)array[6];
				A_5 = (short)array[7];
				return result;
				IL_53:
				result = 0U;
				A_2 = 0;
				A_3 = 0;
				A_4 = 0;
				A_5 = 0;
				A_1 = global::AcpASKLib.KeyExpirationType.Date;
				num7 = 0;
				num = (short)1614086144;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x000160C4 File Offset: 0x000142C4
		private uint a(string A_0)
		{
			int a_ = 2;
			switch (0)
			{
			case 0:
				goto IL_7D;
			}
			int num;
			int num2;
			short num3;
			uint num5;
			for (;;)
			{
				IL_13:
				string text2;
				switch (num)
				{
				case 0:
				{
					if (num2++ >= 3)
					{
						num3 = (short)235208714;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					string text = null;
					num3 = (short)894959629;
					num = (int)((global::System.IntPtr)num3);
					continue;
				}
				case 1:
					global::AcpASKLib.KeyRecordSet.b(this.b);
					num3 = (short)1579548679;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 2:
					num3 = (short)1047920664;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 3:
					num3 = (short)1213661207;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 4:
					num3 = (short)1420951567;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 5:
					goto IL_391;
				case 6:
					global::AcpASKLib.KeyRecordSet.d(this.b);
					num3 = (short)165412883;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 7:
					goto IL_2C6;
				case 8:
					if (this.x)
					{
						num3 = (short)644808710;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_391;
				case 9:
					goto IL_9F;
				case 10:
					goto IL_391;
				case 11:
				{
					num3 = (short)1627551947;
					short num4 = num3;
					num3 = (short)1138194635;
					switch ((num4 == num3) ? 1 : 0)
					{
					case 0:
					case 2:
						return num5;
					default:
						num3 = (short)1335164928;
						if (num3 != 0)
						{
						}
						this.n = true;
						num3 = (short)608698376;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					break;
				}
				case 12:
					if (num2 < 3)
					{
						num3 = (short)952827926;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_9F;
				case 13:
				{
					string text;
					if (this.GetInputPasswordFromUser(ref text))
					{
						num3 = (short)1665007619;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					num5 = 2684387335U;
					num3 = (short)893255681;
					if (num3 != 0)
					{
					}
					num3 = (short)1749549061;
					num = (int)((global::System.IntPtr)num3);
					continue;
				}
				case 14:
					num3 = (short)1848836113;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 15:
				{
					num3 = (short)1894580224;
					short num6 = num3;
					if (this.x)
					{
						num3 = (short)660865025;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_2C6;
				}
				case 16:
					if (num5 != 2684387335U)
					{
						num3 = (short)1372979214;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					return num5;
				case 17:
					if (num2 > 3)
					{
						num3 = (short)149684228;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					return num5;
				case 18:
				{
					string text;
					text2 = text.ToLower();
					goto IL_257;
				}
				case 19:
					goto IL_391;
				case 20:
					goto IL_9F;
				case 21:
					return num5;
				case 22:
					global::System.Windows.MessageBox.Show(global::AcpCommonResources.AcpResources.ResourceManager.GetString(global::AcpASKLib.SystemKeyLoadedEventArgs.b("ᙞའb੤ᕦ᭨๪๬᭮⹰⍲ᑴѶ੸౺ቼൾ\udc82뚄\ud886\udd88", a_), global::AcpCommonResources.AcpResources.Culture), global::AcpCommonResources.AcpResources.ResourceManager.GetString(global::AcpASKLib.SystemKeyLoadedEventArgs.b("࡞`ᅢ୤๦ݨ౪㉬♮ᕰ", a_), global::AcpCommonResources.AcpResources.Culture), global::System.Windows.MessageBoxButton.OK, global::System.Windows.MessageBoxImage.Exclamation, global::System.Windows.MessageBoxResult.OK, this.v);
					num3 = (short)1656815636;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 23:
				{
					string text;
					if (text == null)
					{
						num3 = (short)1647771650;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					num3 = (short)1698955282;
					num = (int)((global::System.IntPtr)num3);
					continue;
				}
				case 24:
					text2 = null;
					goto IL_257;
				}
				goto IL_7D;
				IL_9F:
				num3 = (short)2070609920;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_2C6:
				num5 = 2684387332U;
				num3 = (short)2055077909;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_257:
				if (text2 == ((A_0 != null) ? A_0.ToLower() : null))
				{
					num3 = (short)481493003;
					num = (int)((global::System.IntPtr)num3);
					continue;
				}
				num3 = (short)1301413900;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_391:
				num3 = (short)812122128;
				num = (int)((global::System.IntPtr)num3);
			}
			return num5;
			IL_7D:
			num5 = 0U;
			num2 = 0;
			num3 = (short)1732313097;
			num = (int)((global::System.IntPtr)num3);
			goto IL_13;
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00016570 File Offset: 0x00014770
		public uint GetPswdFromIBtn(global::IBtnWrapperLib.IIBtnWrapper spIBtn, ref string strPassword)
		{
			int a_ = 8;
			short num = (short)1874722816;
			short num2 = num;
			num = (short)962592768;
			int num3 = (int)num;
			switch (num3)
			{
			default:
			{
				strPassword = null;
				uint num4 = 0U;
				try
				{
					switch (0)
					{
					case 0:
						goto IL_A6;
					}
					byte[] sourceArray;
					short num5;
					for (;;)
					{
						IL_5F:
						switch (num3)
						{
						case 0:
							global::System.Diagnostics.Trace.WriteLine(global::AcpASKLib.SystemKeyLoadedEventArgs.b("♤㕦⩨䭪६nᑰr᭴偶൸孺ၼṾꞆﺈ놐ﶘ뮚킜\ude9e认鞦覨춪쒬쎮풰銲钴붶", a_));
							num4 = 3758129156U;
							num = (short)613810181;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							if (this.a(spIBtn, 0, ref sourceArray, out num5))
							{
								num = (short)1938620418;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_321;
						case 2:
						{
							int num6 = (int)num5;
							byte[] array = new byte[(int)num5];
							global::System.Array.Copy(sourceArray, array, (int)num5);
							num = (short)1083113487;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
							goto IL_1E7;
						case 4:
						{
							int num6;
							byte[] array;
							byte b;
							if (b != array[num6 - 1])
							{
								num = (short)864681984;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							num4 = this.a(ref strPassword, array);
							num = (short)1226047500;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 5:
							goto IL_321;
						case 6:
						{
							int num6;
							byte[] array;
							byte b = global::AcpASKLib.Global.a(array, (short)(num6 - 1), 0);
							num = (short)650444808;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 7:
							num = (short)1191641101;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
							goto IL_1E7;
						case 9:
							goto IL_27C;
						case 10:
							num4 = 3758129161U;
							num = (short)2040004617;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 11:
							goto IL_33A;
						case 12:
							goto IL_321;
						case 13:
						{
							byte[] array;
							int num7 = (int)array[9];
							byte b = 0;
							if (num7 < 3)
							{
								num = (short)1260453894;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2B5;
						}
						case 14:
							if (num4 == 0U)
							{
								num = (short)1086062599;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_321;
						case 15:
							if (9 > num5 - 2)
							{
								num = (short)1822818314;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_27C;
						}
						goto IL_A6;
						IL_1E7:
						num = (short)1673789444;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_27C:
						num = (short)1656881166;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_321:
						num = (short)119472139;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_33A:
					goto IL_343;
					IL_A6:
					sourceArray = null;
					num5 = 50;
					num = (short)1372853732;
					short num8 = num;
					num = (short)771036644;
					switch ((num8 == num) ? 1 : 0)
					{
					case 0:
					case 2:
					{
						IL_2B5:
						int num6;
						byte[] array;
						byte b = global::AcpASKLib.Global.a(array, (short)(num6 - 2), 0);
						num = (short)63373315;
						num3 = (int)((global::System.IntPtr)num);
						goto IL_5F;
					}
					default:
						num = (short)2055208960;
						if (num != 0)
						{
						}
						num = (short)1507131393;
						num3 = (int)((global::System.IntPtr)num);
						goto IL_5F;
					}
				}
				catch (global::System.Exception ex)
				{
					num4 = 3758129154U;
					throw ex;
				}
				IL_343:
				num = (short)1643118593;
				if (num != 0)
				{
				}
				return num4;
			}
			}
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00016908 File Offset: 0x00014B08
		private uint a(ref string A_0, byte[] A_1)
		{
			int a_ = 10;
			short num = (short)714735616;
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
				int num3;
				string text;
				for (;;)
				{
					IL_30:
					int num4;
					int num5;
					switch (num2)
					{
					case 0:
						goto IL_23A;
					case 1:
						if (A_1[9] >= 3)
						{
							num = (short)1755316236;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_195;
					case 2:
						if (num3 % 2 == 0)
						{
							num = (short)1885929482;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						text += string.Format(global::AcpASKLib.SystemKeyLoadedEventArgs.b("ᱦ奨兪ᕬቮ", a_), A_1[num4 + num5]);
						num = (short)953483268;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_273;
					case 4:
						goto IL_1B3;
					case 5:
						goto IL_1B3;
					case 6:
						text = null;
						num4 = 12;
						num5 = 0;
						num = (short)200212491;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
					{
						num = (short)845938688;
						short num6 = num;
						if (num5 == (num3 + 1) / 2 - 1)
						{
							num = (short)1816789000;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1F7;
					}
					case 8:
						num = (short)885522434;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						if (num5 >= (num3 + 1) / 2)
						{
							num = (short)1607794691;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1007943687;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
					{
						num = (short)2061731270;
						short num7 = num;
						num = (short)752584134;
						switch ((num7 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							num = (short)1937440768;
							if (num != 0)
							{
							}
							num = (short)1547567105;
							if (num != 0)
							{
							}
							goto IL_1F7;
						}
						break;
					}
					case 11:
						goto IL_23A;
					case 12:
						num3 = (int)A_1[11];
						num = (short)664338438;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_6B;
					IL_1B3:
					num5++;
					num = (short)1695023104;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1F7:
					text += string.Format(global::AcpASKLib.SystemKeyLoadedEventArgs.b("ᱦ奨兪ᕬ嵮౰", a_), A_1[num4 + num5]);
					num = (short)1693843461;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_23A:
					num = (short)1380646921;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_195:
				uint result = 2684387330U;
				global::System.Diagnostics.Trace.WriteLine(global::AcpASKLib.SystemKeyLoadedEventArgs.b("㍦Ũ๪䵬⹮ᕰղᑴ᥶᩸Ṻ᥼彾쪀ﲄꞆ떔ﲘ캠춢薤캦\udaa8讪\ud9ac삮\udeb0鎲\udab4\udbb6\uddb8鞺鶼\udbbe껀귂돆룊료뿎ꇐ볒꟔ꏖ律꿚뗜뫞쇠鏢蓤铦髨鳪苬鷮闰폲藴藶雸迺飼鳾甀樂樄椆✈Ċ", a_));
				A_0 = null;
				return result;
				IL_273:
				A_0 = text;
				return result;
				IL_6B:
				result = 0U;
				num3 = 0;
				num = (short)2104229889;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00016C24 File Offset: 0x00014E24
		internal uint f(global::IBtnWrapperLib.IIBtnWrapper A_0)
		{
			short num = (short)1523974144;
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
				short a_;
				uint num3;
				global::AcpASKLib.KeyExpirationType keyExpirationType;
				short num7;
				short num8;
				short num9;
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
						this.ProgrammingCount = a_;
						num = (short)1710293014;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (this.ProgrammingCount < 1)
						{
							num = (short)2078867477;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return num3;
					case 2:
					{
						num = (short)1179320320;
						short num4 = num;
						num = (short)1122566163;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						A_0.GetNumDaysLeft(ref this.p);
						this.s = this.p;
						this.r = global::System.DateTime.Today.AddHours(23.0).AddMinutes(59.0).AddSeconds(59.0);
						this.r = this.r.AddDays((double)this.p);
						num = (short)782827537;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
					{
						num = (short)2115646358;
						short num5 = num;
						num = (short)272249750;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_34C;
						default:
							num = (short)1075380224;
							if (num != 0)
							{
							}
							num = (short)914751496;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 5:
						if (num3 == 2684387342U)
						{
							num = (short)695140375;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return num3;
					case 6:
					{
						if (this.f == global::AcpASKLib.HardwareKeyFamily.DS1994)
						{
							num = (short)1377042435;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int num6 = 0;
						num3 = this.a(A_0, out keyExpirationType, out num7, out a_, out num8, out num6, out num9);
						num = (short)1872560146;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						this.q = true;
						num3 = 3758129164U;
						num = (short)1517092880;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						if (this.ProgrammingCount < 1)
						{
							num = (short)979697676;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return num3;
					case 9:
						return num3;
					case 10:
						if (this.f != global::AcpASKLib.HardwareKeyFamily.DS1963)
						{
							num = (short)706805762;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_25E;
					case 11:
						goto IL_25E;
					case 12:
						goto IL_F7;
					case 13:
						if (!(this.r < global::System.DateTime.Now))
						{
							num = (short)1069350916;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F7;
					case 14:
						if (num3 == 0U)
						{
							num = (short)1022558208;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)800980997;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						num = (short)744292361;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						return num3;
					case 17:
						goto IL_2C2;
					case 18:
						goto IL_2C2;
					case 19:
						if (this.f == global::AcpASKLib.HardwareKeyFamily.DS1996)
						{
							goto IL_34C;
						}
						return num3;
					case 20:
						if (this.r < global::System.DateTime.Now)
						{
							num = (short)1942552583;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return num3;
					case 21:
						this.q = true;
						num3 = 3758129164U;
						num = (short)935329818;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						switch (keyExpirationType)
						{
						case global::AcpASKLib.KeyExpirationType.Date:
							num = (short)1091829761;
							if (num != 0)
							{
							}
							num = (short)1088421908;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case global::AcpASKLib.KeyExpirationType.Counter:
							num = (short)378798081;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case global::AcpASKLib.KeyExpirationType.Both:
							num = (short)1995243533;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						default:
							num = (short)2067070991;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					case 23:
						num = (short)322371594;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
						return num3;
					case 25:
						return num3;
					case 26:
						return num3;
					}
					goto IL_9B;
					IL_F7:
					this.q = true;
					num3 = 3758129164U;
					num = (short)55509017;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_25E:
					num3 = 0U;
					num = (short)1966473240;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2C2:
					num = (short)170655758;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_34C:
					num = (short)1404502027;
					num2 = (int)((global::System.IntPtr)num);
				}
				return num3;
				IL_9B:
				num7 = 0;
				a_ = 0;
				num8 = 0;
				num9 = 0;
				keyExpirationType = global::AcpASKLib.KeyExpirationType.Date;
				num3 = 0U;
				this.f = this.c(A_0);
				num = (short)1107230726;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x000171C0 File Offset: 0x000153C0
		private uint a(global::IBtnWrapperLib.IIBtnWrapper A_0, int A_1, out short A_2)
		{
			int a_ = 17;
			short num = (short)1232076800;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)67960832;
				short num3 = num;
				byte[] array = null;
				short num4 = 50;
				uint num5 = 0U;
				A_2 = 0;
				try
				{
					switch (0)
					{
					case 0:
						goto IL_A8;
					}
					byte[] array2;
					int num6;
					for (;;)
					{
						IL_65:
						byte b;
						switch (num2)
						{
						case 0:
							if (b != array2[num6 - 1])
							{
								num = (short)1694498828;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_307;
						case 1:
							if (9 > num4 - 2)
							{
								num = (short)1902247950;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_100;
						case 2:
							if (num5 == 0U)
							{
								num = (short)1941897222;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_307;
						case 3:
							num = (short)30670859;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							goto IL_13B;
						case 5:
							b = global::AcpASKLib.Global.a(array2, (short)(num6 - 1), 0);
							num = (short)49872906;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							b = 0;
							A_2 = (short)array[9];
							num = (short)878903303;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
							if (A_1 == 0)
							{
								num = (short)1214578691;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1EF;
						case 8:
							goto IL_307;
						case 9:
							goto IL_100;
						case 10:
							goto IL_13B;
						case 11:
							if (A_2 < 3)
							{
								num = (short)964755461;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1EF;
						case 12:
							goto IL_17A;
						case 13:
							goto IL_321;
						case 14:
						{
							num = (short)1297206953;
							short num7 = num;
							num = (short)1355796137;
							switch ((num7 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_17A;
							default:
								num = (short)193855488;
								if (num != 0)
								{
								}
								num5 = 3758129161U;
								num = (short)952565769;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						}
						goto IL_A8;
						IL_100:
						num = (short)892207106;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_13B:
						num = (short)2086600704;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_17A:
						global::System.Diagnostics.Trace.WriteLine(string.Format(global::AcpASKLib.SystemKeyLoadedEventArgs.b("⵭≯ㅱ味ት᝷όཻၽꝿꒃﺉ낏ﲓ몙ﮝ솟욡蒣\udda5颧힩貫좭\ud9af\udeb1톳鞵馷낹", a_), this.a(A_1)));
						num5 = 3758129156U;
						num = (short)1179123720;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_1EF:
						b = global::AcpASKLib.Global.a(array2, (short)(num6 - 2), 0);
						num = (short)952565764;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_307:
						num = (short)155975693;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_321:
					goto IL_32A;
					IL_A8:
					this.a(A_0, A_1, ref array, out num4);
					array2 = new byte[(int)num4];
					global::System.Array.Copy(array, array2, (int)num4);
					num6 = (int)num4;
					num = (short)481034241;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_65;
				}
				catch (global::System.Exception ex)
				{
					num5 = 3758129154U;
					throw ex;
				}
				IL_32A:
				num = (short)493813761;
				if (num != 0)
				{
				}
				return num5;
			}
			}
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x0001753C File Offset: 0x0001573C
		protected virtual bool GetInputPasswordFromUser(ref string strUserPassword)
		{
			short num = (short)677052416;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)528154624;
				short num3 = num;
				switch (0)
				{
				case 0:
					goto IL_78;
				}
				global::AcpASKLib.IBtnAccessPasswordWnd btnAccessPasswordWnd;
				bool result;
				for (;;)
				{
					IL_51:
					bool? flag;
					bool flag2;
					switch (num2)
					{
					case 0:
						strUserPassword = btnAccessPasswordWnd.b.Password;
						result = true;
						num = (short)1037369350;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (global::System.Windows.Application.Current.MainWindow != null)
						{
							num = (short)1266155523;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_13C;
					case 2:
						num = (short)2138243073;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_1B8;
					case 4:
						goto IL_13C;
					case 5:
						if (flag.GetValueOrDefault() == flag2 & flag != null)
						{
							num = (short)747896832;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 6:
						return result;
					case 7:
					{
						num = (short)476640324;
						short num4 = num;
						num = (short)341505092;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1B8;
						default:
							num = (short)2101673984;
							if (num != 0)
							{
							}
							if (global::System.Windows.Application.Current != null)
							{
								num = (short)799997954;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_13C;
						}
						break;
					}
					}
					goto IL_78;
					IL_13C:
					flag = btnAccessPasswordWnd.ShowDialog();
					flag2 = true;
					num = (short)1551302657;
					if (num != 0)
					{
					}
					num = (short)1049952261;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1B8:
					btnAccessPasswordWnd.Owner = global::System.Windows.Application.Current.MainWindow;
					num = (short)480051204;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_78:
				result = false;
				btnAccessPasswordWnd = new global::AcpASKLib.IBtnAccessPasswordWnd();
				btnAccessPasswordWnd.WindowStyle = global::System.Windows.WindowStyle.ToolWindow;
				btnAccessPasswordWnd.Background = global::System.Windows.Media.Brushes.LightGray;
				btnAccessPasswordWnd.Title = global::AcpCommonResources.AcpResources.Enter_Access_Password.AcpStringFormat(new object[]
				{
					this.b
				});
				btnAccessPasswordWnd.WindowStartupLocation = global::System.Windows.WindowStartupLocation.CenterScreen;
				num = (short)600637447;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_51;
			}
			}
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x0001779C File Offset: 0x0001599C
		internal uint c(global::IBtnWrapperLib.IIBtnWrapper A_0, ref bool A_1)
		{
			int a_ = 9;
			short num = (short)97452032;
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
				uint num3;
				short num5;
				short num7;
				short num8;
				for (;;)
				{
					IL_30:
					switch (num2)
					{
					case 0:
						goto IL_17B;
					case 1:
						if (num3 == 0U)
						{
							num = (short)1158283276;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_CF;
					case 2:
					{
						if (num3 != 0U)
						{
							goto IL_17B;
						}
						num = (short)688861446;
						short num4 = num;
						num = (short)1371287814;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							num = (short)652738560;
							if (num != 0)
							{
							}
							num = (short)1517027338;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 3:
					{
						num = (short)1606287361;
						if (num != 0)
						{
						}
						num3 = this.a(A_0, 4, out num5);
						num = (short)919797760;
						short num6 = num;
						num = (short)1115881479;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						goto IL_CF;
					case 5:
					{
						string fileName = global::AcpASKLib.SystemKeyLoadedEventArgs.b("⥥㱧⭩㱫䁭䁯", a_);
						num = (short)1231749129;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						if (num3 == 0U)
						{
							num = (short)307560453;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_29B;
					case 7:
						goto IL_29B;
					case 8:
						goto IL_29B;
					case 9:
					{
						string fileName;
						if (A_0.DoesFileExist(fileName))
						{
							num = (short)805699587;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num5 = 3;
						num = (short)299106312;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						num3 = this.a(A_0, 2, out num7);
						num = (short)1877606400;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						goto IL_2B3;
					case 12:
						num3 = this.a(A_0, 1, out num8);
						num = (short)906690564;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_6B;
					IL_CF:
					num7 = -1;
					num = (short)1617362946;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_17B:
					num5 = -1;
					num = (short)461766662;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_29B:
					num = (short)1441660939;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_2B3:
				short num9;
				A_1 = (num9 < 3 || num8 < 3 || num7 < 3 || num5 < 3);
				return num3;
				IL_6B:
				num9 = -1;
				num3 = this.a(A_0, 0, out num9);
				num8 = -1;
				num = (short)1126760449;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00017A7C File Offset: 0x00015C7C
		public bool WriteiBtnKey(global::IBtnWrapperLib.IIBtnWrapper spIBtn, ref bool bOpen, bool bValidatePassword, int iKeyType, global::AcpASKLib.OpenMode iOpenMode, global::AcpASKLib.AccessLevelDataRecordSet pRsAccess, out global::AcpASKLib.StatusMsg statusMessage)
		{
			short num = (short)1152516097;
			if (num != 0)
			{
			}
			num = (short)422313984;
			short num2 = num;
			num = (short)611647488;
			int num3 = (int)num;
			switch (num3)
			{
			default:
			{
				bool result = false;
				int a_ = 0;
				uint num4 = 0U;
				string message = "";
				try
				{
					switch (0)
					{
					case 0:
						goto IL_AC;
					}
					for (;;)
					{
						IL_85:
						switch (num3)
						{
						case 0:
							goto IL_215;
						case 1:
						{
							string a_2 = this.b(spIBtn);
							result = this.a(spIBtn, a_2, iKeyType, pRsAccess);
							statusMessage = new global::AcpASKLib.StatusMsg(global::AcpASKLib.AskStatusType.Info, message, num4);
							num = (short)453312515;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							num4 = 0U;
							num = (short)1981677573;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
						{
							num = (short)1327138336;
							short num5 = num;
							num = (short)936936992;
							switch ((num5 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_DC;
							default:
								num = (short)2130706432;
								if (num != 0)
								{
								}
								goto IL_215;
							}
							break;
						}
						case 4:
							if (num4 == 0U)
							{
								num = (short)1024393217;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							num4 = 1610645509U;
							message = global::AcpCommonResources.AcpResources.iBtn_System_key.AcpStringFormat(new object[]
							{
								this.b
							});
							statusMessage = new global::AcpASKLib.StatusMsg(global::AcpASKLib.AskStatusType.Error, message, num4);
							num = (short)1548484608;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							goto IL_15A;
						case 6:
							goto IL_22E;
						case 7:
							if (num4 == 2684387338U)
							{
								goto IL_DC;
							}
							goto IL_15A;
						}
						goto IL_AC;
						IL_DC:
						num = (short)2129854466;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_15A:
						num = (short)1045102596;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_215:
						num = (short)185335814;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_22E:
					return result;
					IL_AC:
					num4 = this.a(spIBtn, false, bValidatePassword, a_, (int)iOpenMode);
					bOpen = true;
					num = (short)1527971847;
					num3 = (int)((global::System.IntPtr)num);
					goto IL_85;
				}
				catch (global::System.Exception ex)
				{
					result = false;
					num4 = 1610645509U;
					statusMessage = new global::AcpASKLib.StatusMsg(global::AcpASKLib.AskStatusType.Error, ex.Message, num4);
					throw ex;
				}
				return result;
			}
			}
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00017CF4 File Offset: 0x00015EF4
		internal bool a(global::IBtnWrapperLib.IIBtnWrapper A_0, string A_1, int A_2, global::AcpASKLib.AccessLevelDataRecordSet A_3)
		{
			int a_ = 13;
			short num = (short)208863232;
			short num2 = num;
			num = (short)494796800;
			int num3 = (int)num;
			switch (num3)
			{
			default:
			{
				num = (short)2139291649;
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
						goto IL_321;
					}
					global::System.Collections.ArrayList arrayList;
					global::System.Collections.ArrayList arrayList2;
					global::System.Collections.ArrayList arrayList3;
					global::System.Collections.Generic.Dictionary<int, global::AcpASKLib.AccessRecord> dictionary;
					int num24;
					int length;
					char[] array9;
					for (;;)
					{
						IL_86:
						bool flag3;
						byte[] array;
						int num4;
						global::AcpCryptoLib.AcpIBtnEncyptDecrpt acpIBtnEncyptDecrpt;
						string fileName;
						int num5;
						byte[] array2;
						int num6;
						int num7;
						int num10;
						bool flag4;
						short num11;
						bool flag5;
						byte[] array5;
						byte[] pFileData3;
						int num13;
						bool flag6;
						byte[] array8;
						byte[] pFileData4;
						int num19;
						short num23;
						switch (num3)
						{
						case 0:
							if (!flag)
							{
								num = (short)1936392339;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_195A;
						case 1:
						{
							arrayList.Insert(8, 1);
							arrayList2.Insert(8, 2);
							arrayList3.Insert(8, 4);
							arrayList.Insert(9, 5);
							arrayList2.Insert(9, 5);
							arrayList3.Insert(9, 5);
							arrayList3.Insert(10, 0);
							byte b = 0;
							global::System.Collections.Generic.IEnumerator<global::AcpASKLib.IKeyDataRecord> enumerator = this.d.GetEnumerator();
							num = (short)1044840594;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							goto IL_1C00;
						case 3:
							goto IL_195A;
						case 4:
							goto IL_A5D;
						case 5:
							goto IL_A1E;
						case 6:
							if (A_3 != null)
							{
								num = (short)402194462;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_16B3;
						case 7:
							goto IL_8E4;
						case 8:
						{
							bool flag2;
							if (flag2)
							{
								num = (short)1070268492;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_17B3;
						}
						case 9:
							goto IL_36D;
						case 10:
							goto IL_1008;
						case 11:
							goto IL_EE6;
						case 12:
						{
							global::System.Collections.ArrayList arrayList4 = new global::System.Collections.ArrayList();
							global::System.Collections.Generic.Dictionary<int, global::AcpASKLib.AccessRecord>.Enumerator enumerator2 = dictionary.GetEnumerator();
							num = (short)239927445;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 13:
						{
							bool flag2;
							if (flag2)
							{
								num = (short)651493440;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_711;
						}
						case 14:
							goto IL_8A5;
						case 15:
							if (flag3)
							{
								num = (short)504627270;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							array[num4] = (byte)arrayList2[num4];
							num = (short)1950220424;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 16:
						{
							byte[] pFileData = null;
							acpIBtnEncyptDecrpt.Encrypt(array, out pFileData);
							A_0.WriteFile(fileName, (short)num5, pFileData);
							num = (short)1413611522;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 17:
							if (flag3)
							{
								num = (short)1993539688;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							array2[num6] = (byte)arrayList3[num6];
							num = (short)1323237387;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 18:
							if (!flag)
							{
								num = (short)303366216;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1008;
						case 19:
						{
							bool flag2;
							if (flag2)
							{
								num = (short)851574818;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_869;
						}
						case 20:
						{
							int num8;
							num7 += num8;
							num = (short)785907755;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 21:
							if (flag3)
							{
								num = (short)1903165527;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_E4F;
						case 22:
							num = (short)618790980;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 23:
							goto IL_1A39;
						case 24:
						{
							byte[] array3;
							short num9;
							this.a(A_0, 2, ref array3, out num9);
							num = (short)305528964;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 25:
							goto IL_602;
						case 26:
							goto IL_922;
						case 27:
							goto IL_36D;
						case 28:
							if (A_3 == null)
							{
								num = (short)854458375;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1826;
						case 29:
						{
							string fileName2 = global::AcpASKLib.SystemKeyLoadedEventArgs.b("❩⩫㩭≯山䕳", a_);
							flag = A_0.DoesFileExist(fileName2);
							num = (short)127664159;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 30:
							goto IL_1826;
						case 31:
							if (!flag)
							{
								num = (short)258080818;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_14E6;
						case 32:
						{
							byte[] pFileData2 = null;
							acpIBtnEncyptDecrpt.Encrypt(array2, out pFileData2);
							A_0.WriteFile(fileName, (short)num10, pFileData2);
							num = (short)516554832;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 33:
							if (flag4)
							{
								num = (short)794886270;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_8E4;
						case 34:
							fileName = global::AcpASKLib.SystemKeyLoadedEventArgs.b("❩㽫㩭≯山䑳", a_);
							A_0.CreateFile(fileName, out num11);
							num = (short)299172001;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 35:
							goto IL_15F6;
						case 36:
							if (flag3)
							{
								num = (short)634191913;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1236;
						case 37:
						{
							byte[] array4;
							short num12;
							this.a(A_0, 4, ref array4, out num12);
							num = (short)1507721220;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 38:
							goto IL_2269;
						case 39:
							goto IL_1155;
						case 40:
							if (!flag5)
							{
								num = (short)204734486;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1C00;
						case 41:
							num = (short)516751476;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 42:
							goto IL_1DDD;
						case 43:
							goto IL_15B2;
						case 44:
							goto IL_1B14;
						case 45:
							goto IL_829;
						case 46:
							goto IL_1F28;
						case 47:
							if (flag3)
							{
								num = (short)1149698161;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1FAB;
						case 48:
							num = (short)779878428;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 49:
							if (A_3 != null)
							{
								num = (short)1923612773;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1C00;
						case 50:
							num = (short)571408540;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 51:
						{
							bool flag2;
							if (flag2)
							{
								num = (short)618397801;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Diagnostics.Trace.WriteLine(global::AcpASKLib.SystemKeyLoadedEventArgs.b("恩敫杭婯塱平屵剷偹噻命ꩿꊁ즃햅\udc87\ud889ꊋ뺍낏ﮓ몙풟芡솣\udea5솧\ud9a9\ud8ab肭邯颱麳鲵銷邹隻钽쳅", a_));
							num = (short)2074476630;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 52:
							goto IL_1155;
						case 53:
							if (flag3)
							{
								num = (short)1150746689;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							acpIBtnEncyptDecrpt.Encrypt(array5, out pFileData3);
							A_0.WriteFile(fileName, (short)num13, pFileData3);
							num = (short)231669856;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 54:
							if (flag6)
							{
								num = (short)1604517981;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_602;
						case 55:
							if (this.d.Count == 0)
							{
								num = (short)1507197086;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)765001817;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 56:
							A_0.DeleteFile(fileName);
							global::System.Diagnostics.Trace.WriteLine(global::AcpASKLib.SystemKeyLoadedEventArgs.b("恩敫杭婯塱平屵剷偹噻命ꩿꊁ삃낏﶑뚕햗펙쾛첝躟銡蒣\udda7즩쾫쮭쎯솱튳쎵풷钹鲻钽𢡊\ud8d1", a_));
							num = (short)1025572890;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 57:
						{
							arrayList.Insert(8, 3);
							arrayList.Insert(9, 5);
							byte b2 = (byte)this.d.Count;
							arrayList.Insert(10, b2);
							byte b3 = global::AcpASKLib.Global.a((byte[])arrayList.ToArray(typeof(byte)));
							arrayList.Add(b3);
							num = (short)1643970701;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 58:
							goto IL_1523;
						case 59:
							if (num6 >= num10)
							{
								num = (short)570490912;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)926154769;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 60:
							goto IL_17B3;
						case 61:
							goto IL_51B;
						case 62:
							goto IL_711;
						case 63:
							if (A_3 == null)
							{
								num = (short)1210122245;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_429;
						case 64:
						{
							int num14 = 0;
							num = (short)1039794185;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 65:
							num = (short)2113601590;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 66:
							if (flag4)
							{
								num = (short)1661403173;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Diagnostics.Trace.WriteLine(global::AcpASKLib.SystemKeyLoadedEventArgs.b("恩敫杭婯塱平屵剷偹噻命ꩿꊁ쮃튅즇\uda89ꊋ뺍낏ﮓ몙풟芡솣\udea5솧\ud9a9\ud8ab肭邯颱麳鲵銷邹隻钽쳅", a_));
							num = (short)596377683;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 67:
						{
							if (flag3)
							{
								num = (short)39256218;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							int num15 = 0;
							num = (short)1449721947;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 68:
							if (!flag3)
							{
								num = (short)341442635;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1C00;
						case 69:
						{
							int num16 = (num16 / 28 + 1) * 28;
							num = (short)1822425102;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 70:
						{
							byte[] array3;
							array[num4] = array3[num4];
							num = (short)792133739;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 71:
						{
							if (this.a(A_0, 0) != A_1)
							{
								num = (short)1693122595;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							bool flag2 = false;
							flag6 = false;
							flag5 = false;
							flag4 = false;
							byte[] array6 = null;
							byte[] array7 = null;
							byte[] array3 = null;
							byte[] array4 = null;
							short num17 = 400;
							short num18 = 400;
							short num9 = 400;
							short num12 = 400;
							fileName = null;
							fileName = global::AcpASKLib.SystemKeyLoadedEventArgs.b("❩㽫㩭≯山䑳", a_);
							flag2 = A_0.DoesFileExist(fileName);
							num = (short)1377042483;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 72:
						{
							string fileName3 = global::AcpASKLib.SystemKeyLoadedEventArgs.b("❩╫㵭≯山䑳", a_);
							flag = A_0.DoesFileExist(fileName3);
							num = (short)1762066442;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 73:
							goto IL_1FAB;
						case 74:
							if (!flag3)
							{
								num = (short)1277165616;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1826;
						case 75:
							num = (short)1166999601;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 76:
							acpIBtnEncyptDecrpt.Encrypt(array8, out pFileData4);
							fileName = global::AcpASKLib.SystemKeyLoadedEventArgs.b("❩㽫㩭≯山䑳", a_);
							A_0.WriteFile(fileName, (short)num19, pFileData4);
							num = (short)1947009084;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 77:
							if (!flag4)
							{
								num = (short)706216099;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_16B3;
						case 78:
							if (flag3)
							{
								num = (short)2040004711;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)887423014;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 79:
							num = (short)895352838;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 80:
							goto IL_16B3;
						case 81:
							num = (short)1527644223;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 82:
						{
							int num16;
							if (num16 % 28 != 0)
							{
								num = (short)473694277;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_8A5;
						}
						case 83:
							goto IL_A5D;
						case 84:
							goto IL_19FC;
						case 85:
							goto IL_829;
						case 86:
							goto IL_51B;
						case 87:
						{
							short num12;
							num10 = (int)num12;
							num = (short)872218733;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 88:
							goto IL_1DDD;
						case 89:
							if (A_3 == null)
							{
								num = (short)729153656;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							fileName = global::AcpASKLib.SystemKeyLoadedEventArgs.b("Ⅹ⥫㝭⍯山䑳", a_);
							num = (short)2016149633;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 90:
							flag3 = true;
							num = (short)950927522;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 91:
							goto IL_1421;
						case 92:
							num = (short)1856438393;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 93:
							acpIBtnEncyptDecrpt.Encrypt(array5, out pFileData3);
							fileName = global::AcpASKLib.SystemKeyLoadedEventArgs.b("Ⅹ⥫㝭⍯山䑳", a_);
							A_0.WriteFile(fileName, (short)num13, pFileData3);
							num = (short)2142175257;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 94:
							goto IL_EA6;
						case 95:
						{
							bool flag2;
							if (flag2)
							{
								num = (short)1257701478;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1236;
						}
						case 96:
							goto IL_17B3;
						case 97:
						{
							int num14;
							if (num14 >= num19)
							{
								num = (short)105250949;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							byte[] array6;
							array8[num14] = array6[num14];
							num14++;
							num = (short)1611530267;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 98:
						{
							byte[] array7;
							short num18;
							this.a(A_0, 1, ref array7, out num18);
							num = (short)1442250862;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 99:
							goto IL_14E6;
						case 100:
						{
							int num20 = 0;
							num = (short)2036858965;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 101:
							goto IL_429;
						case 102:
						{
							short num17;
							num19 = (int)num17;
							num = (short)1773797516;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 103:
							goto IL_16EC;
						case 104:
						{
							byte[] array4;
							array2[num6] = array4[num6];
							num = (short)1431830643;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 105:
						{
							byte[] array6;
							short num17;
							this.a(A_0, 3, ref array6, out num17);
							num = (short)772014141;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 106:
							goto IL_711;
						case 107:
							goto IL_1996;
						case 108:
						{
							if (A_2 == 3)
							{
								num = (short)323158073;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							string fileName4 = global::AcpASKLib.SystemKeyLoadedEventArgs.b("❩㽫㩭≯山䑳", a_);
							flag = A_0.DoesFileExist(fileName4);
							num = (short)929890322;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 109:
							goto IL_E4F;
						case 110:
							goto IL_3D3;
						case 111:
							goto IL_1B14;
						case 112:
							goto IL_1523;
						case 113:
						{
							short num9;
							num5 = (int)num9;
							num = (short)309985353;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 114:
						{
							short num18;
							num13 = (int)num18;
							num = (short)1746403374;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 115:
							goto IL_EE6;
						case 116:
							if (flag6)
							{
								num = (short)1928659058;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1F28;
						case 117:
							if (num4 >= num5)
							{
								num = (short)968622096;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1211826191;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 118:
						{
							int num15;
							if (num15 >= num13)
							{
								num = (short)1381957694;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							array5[num15] = (byte)arrayList[num15];
							num15++;
							num = (short)79167615;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 119:
							goto IL_4C2;
						case 120:
							fileName = global::AcpASKLib.SystemKeyLoadedEventArgs.b("❩㽫㩭≯山䑳", a_);
							num = (short)115671092;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 121:
						{
							if (flag3)
							{
								goto IL_429;
							}
							num = (short)1495031058;
							short num21 = num;
							num = (short)58154258;
							switch ((num21 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_151E;
							default:
								num = (short)1720647680;
								if (num != 0)
								{
								}
								num = (short)679477329;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 122:
						{
							int num22 = (num22 / 28 + 1) * 28;
							num = (short)450756631;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 123:
						{
							int num20;
							if (num20 >= num13)
							{
								num = (short)69861460;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							byte[] array7;
							array5[num20] = array7[num20];
							num20++;
							num = (short)557383725;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 124:
							if (!flag)
							{
								num = (short)694419468;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_177A;
						case 125:
							if (!flag3)
							{
								num = (short)1162674255;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_16B3;
						case 126:
							num = (short)1347289162;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 127:
							goto IL_1421;
						case 128:
						{
							int num22;
							if (num22 % 28 != 0)
							{
								num = (short)600768634;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1A39;
						}
						case 129:
							goto IL_1155;
						case 130:
							fileName = global::AcpASKLib.SystemKeyLoadedEventArgs.b("Ⅹ⥫㝭⍯山䑳", a_);
							A_0.CreateFile(fileName, out num11);
							num = (short)815399024;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 131:
							if (num7 > (int)num23)
							{
								num = (short)458948698;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1B54;
						case 132:
							goto IL_4C2;
						case 133:
							num = (short)584974442;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 134:
						{
							if (num24 >= length / 2)
							{
								num = (short)1833173021;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							array9[0] = A_1[2 * num24];
							array9[1] = A_1[2 * num24 + 1];
							string arg = new string(array9);
							byte b4 = byte.Parse(string.Format(global::AcpASKLib.SystemKeyLoadedEventArgs.b("ᅩ屫呭ཱͯ", a_), arg), global::System.Globalization.NumberStyles.HexNumber);
							arrayList.Insert(num24, b4);
							arrayList2.Insert(num24, b4);
							arrayList3.Insert(num24, b4);
							num24++;
							num = (short)1807286316;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 135:
							if (!flag3)
							{
								num = (short)1554645142;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1397686291;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 136:
							goto IL_1996;
						case 137:
						{
							int num8 = (num8 / 28 + 1) * 28;
							num = (short)1364918366;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 138:
							if (flag6)
							{
								num = (short)260112482;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Diagnostics.Trace.WriteLine(global::AcpASKLib.SystemKeyLoadedEventArgs.b("恩敫杭婯塱平屵剷偹噻命ꩿꊁ쾃쎅톇\ud989ꊋ뺍낏ﮓ몙풟芡솣\udea5솧\ud9a9\ud8ab肭邯颱麳鲵銷邹隻钽쳅", a_));
							num = (short)1750794393;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 139:
							if (flag5)
							{
								num = (short)2099707928;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Diagnostics.Trace.WriteLine(global::AcpASKLib.SystemKeyLoadedEventArgs.b("恩敫杭婯塱平屵剷偹噻命ꩿꊁ삃입\udc87쮉ꊋ뺍낏ﮓ몙풟芡솣\udea5솧\ud9a9\ud8ab肭邯颱麳鲵銷邹隻钽쳅", a_));
							num = (short)891814007;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 140:
							goto IL_1236;
						case 141:
							goto IL_14E6;
						case 142:
						{
							if (A_3 == null)
							{
								num = (short)59375636;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							int num8;
							int num16;
							int num22;
							num7 += num16 + num8 + num22;
							num = (short)831127700;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 143:
							goto IL_2111;
						case 144:
						{
							int num8;
							if (num8 % 28 != 0)
							{
								num = (short)258474121;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_EA6;
						}
						case 145:
							goto IL_14E6;
						case 146:
						{
							byte b;
							try
							{
								num = (short)221904902;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num3)
									{
									case 0:
										goto IL_1D6B;
									case 1:
									{
										int primaryKey;
										global::AcpASKLib.AccessRecord accessLevel;
										dictionary.Add(primaryKey, accessLevel);
										num = (short)592379906;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 3:
									{
										global::System.Collections.Generic.IEnumerator<global::AcpASKLib.IKeyDataRecord> enumerator;
										if (!enumerator.MoveNext())
										{
											num = (short)736624644;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::AcpASKLib.AccessRecord accessLevel = ((global::AcpASKLib.KeyDataRecord)enumerator.Current).AccessLevel;
										byte[] fieldCode = accessLevel.FieldCode;
										b += 1;
										int primaryKey = accessLevel.PrimaryKey;
										num = (short)2063794181;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 4:
										num = (short)861536256;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 5:
									{
										int primaryKey;
										if (!dictionary.ContainsKey(primaryKey))
										{
											num = (short)1581449217;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 6:
										switch (0)
										{
										case 0:
											goto IL_1C82;
										}
										continue;
									}
									IL_1C84:
									num = (short)256573443;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_1C82:
									goto IL_1C84;
								}
								IL_1D6B:
								goto IL_C56;
							}
							finally
							{
								num = (short)973799426;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.Collections.Generic.IEnumerator<global::AcpASKLib.IKeyDataRecord> enumerator;
									switch (num3)
									{
									case 0:
										goto IL_1DDA;
									case 1:
										enumerator.Dispose();
										num = (short)344981504;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										switch (0)
										{
										case 0:
											goto IL_1DA2;
										}
										continue;
									}
									IL_1DA2:
									if (enumerator == null)
									{
										break;
									}
									num = (short)1396310017;
									num3 = (int)((global::System.IntPtr)num);
								}
								IL_1DDA:;
							}
							goto IL_1DDD;
							IL_C56:
							byte b5 = (byte)dictionary.Count;
							arrayList.Insert(10, b);
							arrayList2.Insert(10, b5);
							arrayList3.Insert(11, b);
							byte b6 = global::AcpASKLib.Global.a((byte[])arrayList.ToArray(typeof(byte)));
							arrayList.Add(b6);
							byte b7 = global::AcpASKLib.Global.a((byte[])arrayList2.ToArray(typeof(byte)));
							arrayList2.Add(b7);
							byte b8 = global::AcpASKLib.Global.a((byte[])arrayList3.ToArray(typeof(byte)));
							arrayList3.Add(b8);
							num = (short)1231487121;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 147:
							goto IL_151E;
						case 148:
							goto IL_15B2;
						case 149:
						{
							global::System.Collections.ArrayList arrayList4;
							try
							{
								num = (short)119472132;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num3)
									{
									case 1:
										goto IL_6FE;
									case 2:
									{
										global::System.Collections.Generic.Dictionary<int, global::AcpASKLib.AccessRecord>.Enumerator enumerator2;
										if (!enumerator2.MoveNext())
										{
											num = (short)2115895299;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::System.Collections.Generic.KeyValuePair<int, global::AcpASKLib.AccessRecord> keyValuePair = enumerator2.Current;
										arrayList4.Add(keyValuePair.Value);
										num = (short)347406336;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 3:
										num = (short)2069692417;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 4:
										switch (0)
										{
										case 0:
											goto IL_67A;
										}
										continue;
									}
									IL_67C:
									num = (short)1427505154;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_67A:
									goto IL_67C;
								}
								IL_6FE:
								goto IL_20AA;
							}
							finally
							{
								global::System.Collections.Generic.Dictionary<int, global::AcpASKLib.AccessRecord>.Enumerator enumerator2;
								((global::System.IDisposable)enumerator2).Dispose();
							}
							goto IL_711;
							IL_20AA:
							this.a(ref arrayList, ref arrayList2, ref arrayList3, arrayList4, A_3);
							int num16 = arrayList2.Count;
							int num8 = arrayList.Count;
							int num22 = arrayList3.Count;
							num = (short)2092302418;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 150:
							A_0.CreateFile(fileName, out num11);
							num = (short)658833466;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 151:
						{
							global::System.Diagnostics.Trace.WriteLine(global::AcpASKLib.SystemKeyLoadedEventArgs.b("恩敫杭婯塱平屵剷偹噻命ꩿꊁ킃ﮇﺉ늑秊몙햛춝芡躣貥芧肩蚫蒭骯颱麳鲵늷", a_));
							arrayList.Insert(8, 5);
							arrayList.Insert(9, 5);
							byte b9 = global::AcpASKLib.Global.a((byte[])arrayList.ToArray(typeof(byte)));
							arrayList.Add(b9);
							num = (short)878051427;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 152:
						{
							bool flag7 = A_0.DoesFileExist(fileName);
							if (!flag7)
							{
								global::System.Diagnostics.Trace.WriteLine(global::AcpASKLib.SystemKeyLoadedEventArgs.b("恩敫杭婯塱平屵剷偹噻命ꩿꊁ즃쾅\udb87\ud889ꊋ뺍낏ﮓ몙풟芡솣\udea5솧\ud9a9\ud8ab肭邯颱麳鲵銷邹隻钽쳅", a_));
							}
							fileName = global::AcpASKLib.SystemKeyLoadedEventArgs.b("❩㽫㩭≯山䑳", a_);
							bool flag2;
							if (flag2)
							{
								A_0.DeleteFile(fileName);
								global::System.Diagnostics.Trace.WriteLine(global::AcpASKLib.SystemKeyLoadedEventArgs.b("恩敫杭婯塱平屵剷偹噻命ꩿꊁ삃낏﶑뚕햗즙좛첝躟銡蒣\udda7즩쾫쮭쎯솱튳쎵풷钹鲻钽𢡊\ud8d1", a_));
							}
							fileName = global::AcpASKLib.SystemKeyLoadedEventArgs.b("Ⅹ⥫㝭⍯山䑳", a_);
							if (flag6)
							{
								A_0.DeleteFile(fileName);
								global::System.Diagnostics.Trace.WriteLine(global::AcpASKLib.SystemKeyLoadedEventArgs.b("恩敫杭婯塱平屵剷偹噻命ꩿꊁ삃낏﶑뚕펗\udf99얛춝躟銡蒣\udda7즩쾫쮭쎯솱튳쎵풷钹鲻钽𢡊\ud8d1", a_));
							}
							fileName = global::AcpASKLib.SystemKeyLoadedEventArgs.b("⹩⵫㩭ㅯ山䑳", a_);
							if (flag5)
							{
								A_0.DeleteFile(fileName);
								global::System.Diagnostics.Trace.WriteLine(global::AcpASKLib.SystemKeyLoadedEventArgs.b("恩敫杭婯塱平屵剷偹噻命ꩿꊁ삃낏﶑뚕\udc97\udb99좛\udf9d躟銡蒣\udda7즩쾫쮭쎯솱튳쎵풷钹鲻钽𢡊\ud8d1", a_));
							}
							fileName = global::AcpASKLib.SystemKeyLoadedEventArgs.b("╩㡫⽭⁯山䑳", a_);
							if (flag4)
							{
								A_0.DeleteFile(fileName);
								global::System.Diagnostics.Trace.WriteLine(global::AcpASKLib.SystemKeyLoadedEventArgs.b("恩敫杭婯塱平屵剷偹噻命ꩿꊁ삃낏﶑뚕힗캙\udd9b캝躟銡蒣\udda7즩쾫쮭쎯솱튳쎵풷钹鲻钽𢡊\ud8d1", a_));
							}
							fileName = global::AcpASKLib.SystemKeyLoadedEventArgs.b("❩╫㵭≯山䑳", a_);
							if (flag7)
							{
								num = (short)1989410872;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_922;
						}
						case 153:
							goto IL_3D3;
						case 154:
							num = (short)2078146719;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 155:
							if (flag5)
							{
								num = (short)170066012;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_A1E;
						case 156:
							if (A_2 == 5)
							{
								num = (short)1090912407;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)949354604;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 157:
							if (!flag)
							{
								num = (short)83623937;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_14E6;
						case 158:
							fileName = global::AcpASKLib.SystemKeyLoadedEventArgs.b("❩╫㵭≯山䑳", a_);
							num = (short)100335655;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 159:
							if (flag6)
							{
								num = (short)1961164900;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_19FC;
						case 160:
							if (flag6)
							{
								num = (short)1244201090;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1523;
						case 161:
							goto IL_869;
						case 162:
							goto IL_1B54;
						case 163:
							num = (short)40829053;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 164:
							goto IL_2111;
						}
						goto IL_321;
						IL_36D:
						num = (short)1996423265;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_3D3:
						fileName = global::AcpASKLib.SystemKeyLoadedEventArgs.b("⹩⵫㩭ㅯ山䑳", a_);
						flag5 = A_0.DoesFileExist(fileName);
						num = (short)1082654859;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_429:
						fileName = global::AcpASKLib.SystemKeyLoadedEventArgs.b("⹩⵫㩭ㅯ山䑳", a_);
						int count = arrayList2.Count;
						short num25 = 0;
						A_0.CreateFile(fileName, out num25);
						num5 = arrayList2.Count;
						num = (short)1566703663;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_4C2:
						fileName = global::AcpASKLib.SystemKeyLoadedEventArgs.b("╩㡫⽭⁯山䑳", a_);
						flag4 = A_0.DoesFileExist(fileName);
						num = (short)1477836866;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_51B:
						fileName = global::AcpASKLib.SystemKeyLoadedEventArgs.b("Ⅹ⥫㝭⍯山䑳", a_);
						flag6 = A_0.DoesFileExist(fileName);
						num = (short)1579679882;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_602:
						num = (short)2019360776;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_711:
						pFileData3 = null;
						pFileData4 = null;
						acpIBtnEncyptDecrpt = new global::AcpCryptoLib.AcpIBtnEncyptDecrpt();
						num = (short)610730037;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_829:
						num = (short)2000617595;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_869:
						num = (short)1151991968;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_8A5:
						num = (short)2125791376;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_8E4:
						num = (short)776142925;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_922:
						flag3 = false;
						string fileName5 = null;
						num23 = 0;
						A_0.GetMaxFileSpace(fileName5, out num23);
						string category = string.Format(global::AcpASKLib.SystemKeyLoadedEventArgs.b("⡩ᕫᩭᕯű味᝵๷᭹ᕻችꢇ랉겋ꂏ", a_), num23);
						global::System.Diagnostics.Trace.WriteLine(global::AcpASKLib.SystemKeyLoadedEventArgs.b("恩敫杭婯塱平屵剷偹噻命ꩿꊁﾃ뚅ꪉꚋ꒍몏뢑뺓법늗낙際", a_), category);
						num = (short)1134821507;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_A1E:
						num = (short)1441660968;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_A5D:
						fileName = global::AcpASKLib.SystemKeyLoadedEventArgs.b("❩╫㵭≯山䑳", a_);
						num = (short)224133272;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_E4F:
						array2 = null;
						array2 = new byte[num10];
						num6 = 0;
						num = (short)560201892;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_EA6:
						num = (short)1271988352;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_EE6:
						num6++;
						num = (short)278528143;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_1008:
						num = (short)1821245597;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_1155:
						int count2 = arrayList.Count;
						num11 = 0;
						num = (short)1836253319;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_1236:
						array5 = new byte[num13];
						array8 = new byte[num19];
						num = (short)1801781315;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_1421:
						num = (short)1230307446;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_14E6:
						num = (short)1336410112;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_151E:
						this.RefreshMASKFileLayout(A_0);
						num = (short)161808387;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_1523:
						num13 = arrayList.Count;
						num19 = arrayList.Count;
						num = (short)669515812;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_15B2:
						num = (short)1056571463;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_16B3:
						num = (short)1493237838;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_17B3:
						num = (short)1844117659;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_1826:
						fileName = global::AcpASKLib.SystemKeyLoadedEventArgs.b("╩㡫⽭⁯山䑳", a_);
						int count3 = arrayList3.Count;
						short num26 = 0;
						A_0.CreateFile(fileName, out num26);
						num10 = arrayList3.Count;
						num = (short)1417609237;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_195A:
						num = (short)1417674876;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_1996:
						num4++;
						num = (short)1284112426;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_19FC:
						num = (short)998506509;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_1A39:
						num7 = 28;
						num = (short)842924174;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_1B14:
						num = (short)2140930182;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_1B54:
						num = (short)397738039;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_1C00:
						num = (short)1045430305;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_1DDD:
						num = (short)1990066293;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_1F28:
						num = (short)985923679;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_1FAB:
						array = null;
						array = new byte[num5];
						num4 = 0;
						num = (short)582156376;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_2111:
						num = (short)130678843;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_15F6:
					throw new global::System.Exception(global::AcpASKLib.SystemKeyLoadedEventArgs.b("㥩५ᱭ᥯፱ᡳ噵㙷ཹᅻᱽꒃ쮅솇\ud989솋쾍쒏톑\udc93랕", a_));
					IL_16EC:
					result = false;
					throw new global::System.Exception(global::AcpASKLib.SystemKeyLoadedEventArgs.b("╩ᥫᩭ偯ᵱታ噵㕷όᅻᅽﮁꖃ", a_))
					{
						Data = 
						{
							{
								global::AcpASKLib.SystemKeyLoadedEventArgs.b("⽩ṫᱭὯq㝳᥵ᱷό", a_),
								3758129162U
							}
						}
					};
					IL_177A:
					result = false;
					throw new global::System.Exception(global::AcpASKLib.SystemKeyLoadedEventArgs.b("⭩ཫ൭ᕯűݳ噵㱷όቻ᝽ꖃ", a_))
					{
						Data = 
						{
							{
								global::AcpASKLib.SystemKeyLoadedEventArgs.b("⽩ṫᱭὯq㝳᥵ᱷό", a_),
								3758129163U
							}
						}
					};
					IL_2269:
					return result;
					IL_321:
					array9 = new char[2];
					arrayList = new global::System.Collections.ArrayList();
					arrayList2 = new global::System.Collections.ArrayList();
					arrayList3 = new global::System.Collections.ArrayList();
					dictionary = new global::System.Collections.Generic.Dictionary<int, global::AcpASKLib.AccessRecord>();
					length = A_1.Length;
					num24 = 0;
					num = (short)429916271;
					num3 = (int)((global::System.IntPtr)num);
					goto IL_86;
				}
				catch (global::System.Exception ex)
				{
					throw new global::System.Exception(global::AcpASKLib.SystemKeyLoadedEventArgs.b("ͩ⹫᭭ѯٱ᭳ᡵ塷⵹๻᝽ꒃ쎅慎ﲍꪏ늑", a_) + ex.Message, ex);
				}
				return result;
			}
			}
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00019FE0 File Offset: 0x000181E0
		public void WriteMASKToIBtn(global::IBtnWrapperLib.IIBtnWrapper spIBtn, string pstrPassword, global::AcpASKLib.KeyExpirationType expType, short daysToExpire, short progCount, ref bool bOpen)
		{
			int a_ = 13;
			short num;
			try
			{
				num = (short)695795712;
				switch (num)
				{
				default:
				{
					num = (short)1217003531;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						byte b;
						int num4;
						int length;
						char[] array;
						string text;
						global::System.Collections.ArrayList arrayList;
						int num5;
						string fileName;
						switch (num2)
						{
						case 0:
							goto IL_251;
						case 1:
							goto IL_17A;
						case 2:
							goto IL_3D2;
						case 3:
						{
							num = (short)416665321;
							short num3 = num;
							num = (short)1199296233;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_E1;
							default:
								num = (short)2068119552;
								if (num != 0)
								{
								}
								b = (byte)pstrPassword.Length;
								num = (short)539361294;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 4:
							goto IL_E1;
						case 5:
							num = (short)1661141017;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
						{
							if (num4 >= length / 2)
							{
								num = (short)13238299;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							array.SetValue(null, 0);
							array.SetValue(null, 1);
							array[0] = text[2 * num4];
							array[1] = text[2 * num4 + 1];
							string arg = new string(array);
							byte b2 = byte.Parse(string.Format(global::AcpASKLib.SystemKeyLoadedEventArgs.b("ᅩ屫呭ཱͯ", a_), arg), global::System.Globalization.NumberStyles.HexNumber);
							arrayList.Insert(num4, b2);
							num4++;
							num = (short)1178075155;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 7:
							goto IL_721;
						case 8:
							goto IL_766;
						case 9:
							if (!bOpen)
							{
								num = (short)2069561360;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_74E;
						case 10:
							goto IL_251;
						case 11:
							switch (0)
							{
							case 0:
								goto IL_BC;
							}
							continue;
						case 12:
							num5 = 0;
							num = (short)1052114954;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 13:
							goto IL_295;
						case 14:
							goto IL_667;
						case 15:
							if (num5 >= (int)((b + 1) / 2))
							{
								num = (short)1620705282;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							array.SetValue(null, 0);
							array.SetValue(null, 1);
							array[0] = pstrPassword[2 * num5];
							num = (short)1040842770;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 16:
							spIBtn.CloseButton();
							num = (short)151519258;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 17:
							if (!spIBtn.DoesFileExist(fileName))
							{
								num = (short)1175519254;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_295;
						case 18:
							if (num5 == (int)((b + 1) / 2 - 1))
							{
								num = (short)1249968133;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_721;
						case 19:
							goto IL_17A;
						case 20:
							goto IL_1E5;
						case 21:
						{
							int options = 0;
							spIBtn.OpenNonMotoBtn(options);
							num = (short)2127888404;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 22:
						{
							short num6 = 0;
							spIBtn.CreateFile(fileName, out num6);
							num = (short)358744077;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 23:
							if (pstrPassword != null)
							{
								num = (short)667942915;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_667;
						case 24:
							if (b > 0)
							{
								num = (short)362217484;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_3D2;
						case 25:
							if (b % 2 == 0)
							{
								num = (short)249298951;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_E1;
						case 26:
							goto IL_74E;
						case 27:
						{
							arrayList.Insert(8, 0);
							arrayList.Insert(9, 5);
							byte b3 = global::AcpASKLib.Global.a((byte[])arrayList.ToArray(typeof(byte)));
							arrayList.Add(b3);
							b = 0;
							num = (short)481230871;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						IL_BC:
						if (!bOpen)
						{
							num = (short)282656789;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1E5;
						IL_E1:
						string arg2 = new string(array);
						byte b4 = byte.Parse(string.Format(global::AcpASKLib.SystemKeyLoadedEventArgs.b("ᅩ屫呭ཱͯ", a_), arg2), global::System.Globalization.NumberStyles.HexNumber);
						global::System.Collections.ArrayList arrayList2;
						arrayList2.Add(b4);
						num5++;
						num = (short)184877056;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_17A:
						num = (short)1033895942;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_1E5:
						global::System.DateTime now = global::System.DateTime.Now;
						global::System.DateTime value = new global::System.DateTime(1970, 1, 1);
						daysToExpire += (short)now.Subtract(value).Days;
						arrayList = new global::System.Collections.ArrayList();
						text = this.b(spIBtn);
						array = new char[2];
						length = text.Length;
						num4 = 0;
						num = (short)920518657;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_251:
						num = (short)2042626063;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_295:
						byte[] array2;
						spIBtn.WriteFile(fileName, (short)array2.Length, array2);
						num = (short)2076770313;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_3D2:
						byte b5 = global::AcpASKLib.Global.a((byte[])arrayList2.ToArray(typeof(byte)));
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
						global::System.TimeSpan timeSpan = global::System.DateTime.Now.ToUniversalTime().Subtract(global::AcpASKLib.Constants.ReferenceDate);
						short num7 = (short)timeSpan.Days;
						b6 = (byte)(num7 >> 8);
						array5[0] = b6;
						b6 = (byte)num7;
						array5[1] = b6;
						b6 = (byte)((short)timeSpan.Hours);
						array5[2] = b6;
						arrayList.AddRange(array5);
						byte b7 = global::AcpASKLib.Global.a((byte[])arrayList.ToArray(typeof(byte)));
						arrayList.Add(b7);
						byte[] pDecrypted = (byte[])arrayList.ToArray(typeof(byte));
						array2 = null;
						fileName = global::AcpASKLib.SystemKeyLoadedEventArgs.b("❩⵫㵭㭯山䑳", a_);
						new global::AcpCryptoLib.AcpIBtnEncyptDecrpt().Encrypt(pDecrypted, out array2);
						num = (short)2012413969;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_667:
						arrayList2 = new global::System.Collections.ArrayList();
						arrayList2.Insert(0, b);
						num = (short)35717144;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_721:
						array[1] = pstrPassword[2 * num5 + 1];
						num = (short)593100804;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_74E:
						num = (short)180158472;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_766:
					break;
				}
				}
			}
			catch (global::System.Exception ex)
			{
				throw new global::System.Exception(global::AcpASKLib.SystemKeyLoadedEventArgs.b("㵩ṫݭѯ᝱味㭵㥷⥹㝻幽ꢇﲏ겕뢗", a_) + ex.Message, ex);
			}
			num = (short)944504833;
			if (num != 0)
			{
			}
			num = (short)294191104;
			short num8 = num;
		}

		// Token: 0x060000EB RID: 235 RVA: 0x0001A7E8 File Offset: 0x000189E8
		public void UpdatePassword(global::IBtnWrapperLib.IIBtnWrapper spIBtn, string newPaswd)
		{
			short num = (short)1136656385;
			if (num != 0)
			{
			}
			num = (short)363134976;
			short num2 = num;
			num = (short)1495531520;
			int num3 = (int)num;
			switch (num3)
			{
			default:
			{
				bool flag = true;
				uint num4 = 0U;
				try
				{
					switch (0)
					{
					case 0:
						goto IL_B3;
					}
					global::AcpASKLib.KeyExpirationType expType;
					short num6;
					short progCount;
					short num7;
					int num8;
					short num9;
					for (;;)
					{
						IL_7C:
						switch (num3)
						{
						case 0:
							goto IL_2EA;
						case 1:
							if (num4 == 0U)
							{
								num = (short)2107506692;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_204;
						case 2:
							goto IL_302;
						case 3:
							global::AcpASKLib.KeyRecordSet.d(this.b);
							num = (short)115343360;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
						{
							num = (short)616808189;
							short num5 = num;
							num = (short)1418772221;
							switch ((num5 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_132;
							default:
								num = (short)95485952;
								if (num != 0)
								{
								}
								this.WriteMASKToIBtn(spIBtn, newPaswd, expType, num6, progCount, ref flag);
								num = (short)1531248650;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 5:
							if (this.f == global::AcpASKLib.HardwareKeyFamily.DS1994)
							{
								num = (short)1853489161;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							num4 = this.a(spIBtn, out expType, out num6, out progCount, out num7, out num8, out num9);
							this.r = global::System.DateTime.Now.AddDays((double)num6);
							goto IL_132;
						case 6:
							if (this.x)
							{
								num = (short)1168965635;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2EA;
						case 7:
							goto IL_265;
						case 8:
							num = (short)1070268422;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 9:
							spIBtn.GetNumDaysLeft(ref this.p);
							num6 = this.p;
							this.r = global::System.DateTime.Now.AddDays((double)this.p);
							num = (short)1745813511;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 10:
							if (!global::AcpASKLib.KeyRecordSet.c(this.b))
							{
								num = (short)746127368;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2EA;
						case 11:
							goto IL_265;
						}
						goto IL_B3;
						IL_132:
						num = (short)1961426955;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_265:
						num = (short)767229953;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_2EA:
						num = (short)1512898562;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_204:
					throw new global::System.Exception(global::AcpASKLib.iBtnStatusCode.GetErrorMsg(num4));
					IL_302:
					return;
					IL_B3:
					expType = global::AcpASKLib.KeyExpirationType.Date;
					num6 = 0;
					progCount = 0;
					num7 = 0;
					num8 = 0;
					num9 = 0;
					this.f = this.c(spIBtn);
					num = (short)2001207301;
					num3 = (int)((global::System.IntPtr)num);
					goto IL_7C;
				}
				catch (global::System.Exception ex)
				{
					throw ex;
				}
				return;
			}
			}
		}

		// Token: 0x060000EC RID: 236 RVA: 0x0001AB18 File Offset: 0x00018D18
		public void RefreshMASKFileLayout(global::IBtnWrapperLib.IIBtnWrapper spIBtn)
		{
			short num;
			for (;;)
			{
				num = (short)543424512;
				short num2 = num;
				num = (short)1124663296;
				switch (num)
				{
				default:
				{
					bool flag = true;
					uint num3 = 0U;
					try
					{
						num = (short)1003487242;
						int num4 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							string pstrPassword;
							global::AcpASKLib.KeyExpirationType expType;
							short num5;
							short progCount;
							short num6;
							int num7;
							short num8;
							switch (num4)
							{
							case 0:
								if (num3 == 0U)
								{
									num = (short)506789894;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_2A8;
							case 1:
								goto IL_34C;
							case 2:
								num3 = this.GetPswdFromIBtn(spIBtn, ref pstrPassword);
								num = (short)1766653967;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
								num = (short)308346889;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
								num = (short)1291583500;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 5:
								num = (short)2076377089;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 6:
								this.f = this.c(spIBtn);
								num = (short)464453646;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 7:
								if (num3 != 0U)
								{
									num = (short)152109060;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_137;
							case 8:
								goto IL_2A8;
							case 9:
								if (num3 == 2684387342U)
								{
									num = (short)1110310925;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_1EF;
							case 10:
								switch (0)
								{
								case 0:
									goto IL_B8;
								}
								continue;
							case 11:
								goto IL_2A8;
							case 12:
								if (num3 != 2684387330U)
								{
									num = (short)1294860291;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_137;
							case 13:
								goto IL_137;
							case 14:
								if (this.f == global::AcpASKLib.HardwareKeyFamily.DS1994)
								{
									num = (short)764477456;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								num3 = this.a(spIBtn, out expType, out num5, out progCount, out num6, out num7, out num8);
								this.r = global::System.DateTime.Now.AddDays((double)num5);
								num = (short)480706571;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 15:
								goto IL_164;
							case 16:
								spIBtn.GetNumDaysLeft(ref this.p);
								num5 = this.p;
								this.r = global::System.DateTime.Now.AddDays((double)this.p);
								num = (short)2016870408;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_B8:
							bool flag2 = this.IsFormated(spIBtn, ref flag);
							pstrPassword = "";
							if (flag2)
							{
								num = (short)2079981570;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_164;
							IL_137:
							this.WriteMASKToIBtn(spIBtn, pstrPassword, expType, num5, progCount, ref flag);
							num = (short)162988037;
							num4 = (int)((global::System.IntPtr)num);
							continue;
							IL_164:
							expType = global::AcpASKLib.KeyExpirationType.Date;
							num5 = 0;
							progCount = 0;
							num6 = 0;
							num8 = 0;
							num7 = 0;
							num = (short)13500416;
							num4 = (int)((global::System.IntPtr)num);
							continue;
							IL_2A8:
							num = (short)625410055;
							num4 = (int)((global::System.IntPtr)num);
						}
						IL_1EF:
						throw new global::System.Exception(global::AcpASKLib.iBtnStatusCode.GetErrorMsg(num3));
						IL_34C:;
					}
					catch (global::System.Exception ex)
					{
						throw ex;
					}
					num = (short)1466289542;
					short num9 = num;
					num = (short)1757924742;
					switch ((num9 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_384;
					}
					break;
				}
				}
			}
			IL_384:
			num = (short)318636033;
			if (num != 0)
			{
			}
			num = (short)1961623552;
			if (num != 0)
			{
			}
		}

		// Token: 0x060000ED RID: 237 RVA: 0x0001AF04 File Offset: 0x00019104
		public void InitButton(global::IBtnWrapperLib.IIBtnWrapper spIBtn, short daysToFinalExpiration, global::System.DateTime expirationDate)
		{
			int a_ = 10;
			short num;
			try
			{
				num = (short)1219624960;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					switch (0)
					{
					case 0:
						goto IL_47;
					}
					char offsetFormat;
					for (;;)
					{
						IL_30:
						switch (num2)
						{
						case 0:
							goto IL_1F6;
						case 1:
							if (daysToFinalExpiration >= 0)
							{
								num = (short)682557442;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_8E;
						case 2:
							for (;;)
							{
								byte[] array = new byte[6];
								array[4] = 1;
								byte[] version = array;
								string userid = global::AcpASKLib.SystemKeyLoadedEventArgs.b("⩦♨㽪㉬Ɱⅰ⁲", a_);
								string password = global::AcpASKLib.SystemKeyLoadedEventArgs.b("⩦♨㽪㉬Ɱⅰ⁲", a_);
								short num3 = 1;
								byte[] communityCode = new byte[]
								{
									(byte)(num3 & 255),
									(byte)(num3 >> 8)
								};
								char expirationAction = 'B';
								bool flag = true;
								this.f = this.c(spIBtn);
								flag = (this.f == global::AcpASKLib.HardwareKeyFamily.DS1994 && flag);
								string authCode = global::AcpASKLib.SystemKeyLoadedEventArgs.b("ᱦ彨⥪⹬⵮䉰䅲䑴䁶乸㹺䵼䱾떀솂뚄쒆쮈쾊첌뾎햐힒풔꺖\ud898궚\ud89cꞞ鞢銤醦馨펪鲮螲ힴ톶\udcb8誺醼达맀Ꞔꇆ곈響뗌軎냐뛔곖ꏚ鿜", a_);
								((global::IBtnWrapperLib.MultiBtnWrapper)spIBtn).InitButton(version, communityCode, userid, password, authCode, daysToFinalExpiration, offsetFormat, expirationAction, flag);
								((global::IBtnWrapperLib.MultiBtnWrapper)spIBtn).GetROMSerialNumString();
								short num4 = 0;
								((global::IBtnWrapperLib.MultiBtnWrapper)spIBtn).GetNumDaysLeft(ref num4);
								bool flag2 = true;
								this.WriteMASKToIBtn(spIBtn, null, this.o, this.DaysToExpiration, this.ProgrammingCount, ref flag2);
								this.j = true;
								num = (short)1771657328;
								short num5 = num;
								num = (short)525752432;
								switch ((num5 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									goto IL_1AE;
								}
							}
							IL_1AE:
							num = (short)128647168;
							if (num != 0)
							{
							}
							num = (short)419168259;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							num = (short)1251999744;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_47;
					}
					IL_8E:
					throw new global::System.Exception(global::AcpASKLib.SystemKeyLoadedEventArgs.b("╦ᱨὪᥬnὰ卲㍴ᡶ୸ᙺᱼ୾ꆀ욂力람꾎\ud890ﶒ列뾞\udba2햤캦\udba8쪪\ud9ac욮\udeb0\uddb2閴펶\ud8b8쾺\ud8bc", a_));
					IL_1F6:
					break;
					IL_47:
					this.ExpirationDate = expirationDate;
					this.DaysToExpiration = daysToFinalExpiration;
					offsetFormat = 'D';
					num = (short)1598881793;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_30;
				}
				}
			}
			catch (global::System.Exception ex)
			{
				throw new global::System.Exception(global::AcpASKLib.SystemKeyLoadedEventArgs.b("╦ᱨὪᥬnὰ卲㍴ᡶ୸ᙺᱼ୾ꆀ욂力람꾎", a_) + ex.Message);
			}
			num = (short)1572864;
			short num6 = num;
			num = (short)1372848129;
			if (num != 0)
			{
			}
		}

		// Token: 0x060000EE RID: 238 RVA: 0x0001B198 File Offset: 0x00019398
		public bool ReadiBtnKey(global::IBtnWrapperLib.IIBtnWrapper spIBtn, bool bReadMasterKeys, bool bValidatePassword, global::AcpASKLib.AccessLevelDataRecordSet pRsAccess, ref bool bOpen, ref bool bISR, out global::AcpASKLib.StatusMsg status, bool bASKCalling, bool bAddAccessLevel)
		{
			int a_ = 3;
			short num;
			bool result;
			for (;;)
			{
				num = (short)397869056;
				short num2 = num;
				num = (short)1921187840;
				int num3 = (int)num;
				switch (num3)
				{
				default:
				{
					result = true;
					int a_2 = 0;
					status = null;
					uint num4 = 0U;
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
							switch (num3)
							{
							case 0:
								goto IL_339;
							case 1:
								goto IL_1C0;
							case 2:
							{
								int a_3 = 0;
								num = (short)2005729290;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 3:
								goto IL_321;
							case 4:
								if (this.h)
								{
									num = (short)205848581;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_321;
							case 5:
								goto IL_152;
							case 6:
							{
								int a_3 = 3;
								pRsAccess = null;
								num = (short)1910243340;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 7:
							{
								if (num4 == 0U)
								{
									num = (short)1209204738;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								result = false;
								string message = global::AcpCommonResources.AcpResources.Error_Reading_iButton.AcpStringFormat(new object[]
								{
									global::AcpASKLib.iBtnStatusCode.GetErrorMsg(num4),
									this.b
								});
								status = new global::AcpASKLib.StatusMsg(global::AcpASKLib.AskStatusType.Error, message, num4);
								num = (short)342818819;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 8:
								if (this.h)
								{
									num = (short)332398603;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_1C0;
							case 9:
								if (!this.g)
								{
									num = (short)30474254;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_152;
							case 10:
								if (this.g)
								{
									num = (short)1133838342;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)655425544;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 11:
							{
								int a_3 = 1;
								num = (short)1923940353;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 12:
								goto IL_1C0;
							case 13:
								try
								{
									int a_3;
									this.a(spIBtn, this.b, a_3, pRsAccess, bISR, bASKCalling, bAddAccessLevel);
									goto IL_321;
								}
								catch (global::System.Exception ex)
								{
									this.d.Clear();
									num4 = 1610645507U;
									this.i = false;
									result = false;
									string str = global::AcpCommonResources.AcpResources.iBtn_System_key.AcpStringFormat(new object[]
									{
										this.b
									});
									status = new global::AcpASKLib.StatusMsg(global::AcpASKLib.AskStatusType.Error, str + global::AcpASKLib.SystemKeyLoadedEventArgs.b("䁟", a_) + ex.Message, num4);
									goto IL_321;
								}
								goto IL_2C0;
							case 14:
								goto IL_2C0;
							}
							goto IL_A8;
							IL_152:
							num = (short)218955789;
							num3 = (int)((global::System.IntPtr)num);
							continue;
							IL_1C0:
							num = (short)1242365961;
							num3 = (int)((global::System.IntPtr)num);
							continue;
							IL_2C0:
							num = (short)879624196;
							num3 = (int)((global::System.IntPtr)num);
							continue;
							IL_321:
							num = (short)130547712;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_339:
						goto IL_378;
						IL_A8:
						num4 = this.a(spIBtn, bReadMasterKeys, bValidatePassword, a_2, 1);
						bOpen = true;
						num = (short)589824007;
						num3 = (int)((global::System.IntPtr)num);
						goto IL_65;
					}
					catch (global::System.Exception ex2)
					{
						result = false;
						num4 = 1610645507U;
						string message2 = global::AcpCommonResources.AcpResources.Error_Reading_iButton.AcpStringFormat(new object[]
						{
							ex2.Message,
							this.b
						});
						status = new global::AcpASKLib.StatusMsg(global::AcpASKLib.AskStatusType.Error, message2, num4);
					}
					IL_378:
					num = (short)2082967670;
					short num5 = num;
					num = (short)1387040886;
					switch ((num5 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_3AD;
					}
					break;
				}
				}
			}
			IL_3AD:
			num = (short)868286465;
			if (num != 0)
			{
			}
			num = (short)805765120;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x060000EF RID: 239 RVA: 0x0001B5C4 File Offset: 0x000197C4
		internal void a(global::IBtnWrapperLib.IIBtnWrapper A_0, string A_1, int A_2, global::AcpASKLib.AccessLevelDataRecordSet A_3, bool A_4, bool A_5, bool A_6)
		{
			int a_ = 18;
			short num;
			try
			{
				num = (short)67108864;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					switch (0)
					{
					case 0:
						goto IL_161;
					}
					for (;;)
					{
						IL_32:
						string text;
						global::System.Collections.ArrayList arrayList;
						int num6;
						global::System.Collections.ArrayList arrayList2;
						byte b;
						global::System.Collections.ArrayList arrayList3;
						switch (num2)
						{
						case 0:
							goto IL_BE9;
						case 1:
						{
							if (this.a(A_0, 0) != A_1)
							{
								num = (short)1038155787;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							int a_2 = 2;
							int a_3 = 4;
							byte[] array = null;
							byte[] array2 = null;
							byte[] array3 = null;
							short num3 = 400;
							short num4 = 400;
							short num5 = 400;
							bool flag = false;
							this.a(A_0, A_2, ref array, out num3);
							num = (short)1380712454;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
						{
							bool flag;
							if (flag)
							{
								num = (short)771948571;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_383;
						}
						case 3:
							goto IL_48E;
						case 4:
							num = (short)1540554802;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							goto IL_6CE;
						case 6:
						{
							bool flag2;
							if (flag2)
							{
								num = (short)1752301639;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_3FF;
						}
						case 7:
							num = (short)1212743705;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
							goto IL_807;
						case 9:
							goto IL_DEF;
						case 10:
							if (!(text != A_1))
							{
								num = (short)1528823868;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_684;
						case 11:
							goto IL_60E;
						case 12:
							if (A_3 != null)
							{
								num = (short)1684668432;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_3C0;
						case 13:
						{
							bool flag;
							if (flag)
							{
								num = (short)1707016245;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_CED;
						}
						case 14:
							if (global::AcpASKLib.Global.a((byte[])arrayList.ToArray(typeof(byte)), (short)(num6 - 2), 0) != (byte)arrayList[num6 - 1])
							{
								num = (short)193003579;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2F9;
						case 15:
							num = (short)1538981902;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 16:
							num = (short)25296934;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 17:
						{
							short num5;
							if (num6 >= (int)num5)
							{
								num = (short)1557463079;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							byte[] array3;
							arrayList.Insert(num6, array3[num6++]);
							num = (short)1780154423;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 18:
							goto IL_AD8;
						case 19:
							if ((byte)arrayList[8] != 4)
							{
								num = (short)551747587;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_383;
						case 20:
							if (A_3 != null)
							{
								num = (short)668401679;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2F9;
						case 21:
						{
							short num4;
							int num7;
							if (num7 >= (int)num4)
							{
								num = (short)293928997;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							byte[] array2;
							arrayList2.Insert(num7, array2[num7++]);
							num = (short)1408892936;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 22:
						{
							if (A_2 != 1)
							{
								num = (short)780599363;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							string text2 = this.a(A_0, 2);
							num = (short)1471283213;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 23:
							if ((int)b != A_2)
							{
								num = (short)2140405793;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_D66;
						case 24:
						{
							bool flag;
							if (flag)
							{
								num = (short)77398048;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_C80;
						}
						case 25:
						{
							byte b2;
							if (b2 != 2)
							{
								num = (short)203817014;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_D66;
						}
						case 26:
							A_0.GetNumDaysLeft(ref this.p);
							this.a(this.p, A_0);
							num = (short)1794048042;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 27:
							num = (short)627310611;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 28:
						{
							int num7;
							if (global::AcpASKLib.Global.a((byte[])arrayList2.ToArray(typeof(byte)), (short)(num7 - 2), 0) != (byte)arrayList2[num7 - 1])
							{
								num = (short)1986658369;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_B1D;
						}
						case 29:
						{
							int num8;
							if (global::AcpASKLib.Global.a((byte[])arrayList3.ToArray(typeof(byte)), (short)(num8 - 2), 0) != (byte)arrayList3[num8 - 1])
							{
								num = (short)1762852908;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)665518123;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 30:
							num = (short)901185556;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 31:
							goto IL_3FF;
						case 32:
							num = (short)558825477;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 33:
							goto IL_4CD;
						case 34:
							goto IL_843;
						case 35:
						{
							string text2;
							if (text2 != A_1)
							{
								num = (short)2117599250;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							arrayList2 = new global::System.Collections.ArrayList();
							arrayList3 = new global::System.Collections.ArrayList();
							arrayList = new global::System.Collections.ArrayList();
							int num8 = 0;
							num = (short)1965293638;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 36:
							goto IL_59B;
						case 37:
							goto IL_3C0;
						case 38:
							goto IL_807;
						case 39:
							goto IL_C80;
						case 40:
						{
							byte b2 = (byte)arrayList2[8];
							num = (short)1563688962;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 41:
						{
							int a_3;
							byte[] array3;
							short num5;
							this.a(A_0, a_3, ref array3, out num5);
							num = (short)1315176479;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 42:
							goto IL_59B;
						case 43:
							if (A_3 != null)
							{
								num = (short)805437440;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_B1D;
						case 44:
							goto IL_CE8;
						case 45:
							num = (short)472907800;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 46:
							if (A_3 != null)
							{
								num = (short)1610809384;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1837105175;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 47:
							if (A_2 == 1)
							{
								num = (short)316342338;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_843;
						case 48:
							num = (short)368771136;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 49:
							goto IL_8B4;
						case 50:
						{
							int num9;
							if (num9 >= 5)
							{
								num = (short)1908670533;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_59B;
						}
						case 51:
							if (b == 1)
							{
								num = (short)400883719;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_A86;
						case 52:
						{
							bool flag2;
							if (flag2)
							{
								num = (short)2098331696;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_59B;
						}
						case 53:
							num = (short)1155006520;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 54:
							goto IL_9D5;
						case 55:
							goto IL_6CE;
						case 56:
							if (this.a(A_0, 4) != A_1)
							{
								num = (short)1430847549;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_CED;
						case 57:
						{
							bool flag;
							if (flag)
							{
								num = (short)339410974;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2F9;
						}
						case 58:
						{
							bool flag;
							if (flag)
							{
								num = (short)1699282985;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_3FF;
						}
						case 59:
							goto IL_959;
						case 60:
							num = (short)548339747;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 61:
							goto IL_7A5;
						case 62:
							if (A_3 != null)
							{
								num = (short)1485766701;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_C80;
						case 63:
						{
							int num7 = 0;
							num = (short)805830668;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 64:
						{
							if (this.KeyFamily == global::AcpASKLib.HardwareKeyFamily.DS1994)
							{
								num = (short)616759322;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::AcpASKLib.KeyExpirationType keyExpirationType = global::AcpASKLib.KeyExpirationType.Date;
							short num10 = 0;
							short num11 = 0;
							short num12 = 0;
							int num9 = 0;
							this.a(A_0, out keyExpirationType, out this.s, out num10, out num11, out num9, out num12);
							num = (short)1155268676;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 65:
							goto IL_252;
						case 66:
						{
							bool flag2 = true;
							num = (short)655228962;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 67:
						{
							string text2 = text;
							num = (short)435748936;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 68:
							if (this.KeyFamily == global::AcpASKLib.HardwareKeyFamily.DS1963)
							{
								num = (short)871366660;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_344;
						case 69:
							goto IL_344;
						case 70:
							goto IL_8B4;
						case 71:
						{
							int a_2;
							byte[] array2;
							short num4;
							this.a(A_0, a_2, ref array2, out num4);
							string fileName = global::AcpASKLib.SystemKeyLoadedEventArgs.b("⁮╰㉲╴奶䥸", a_);
							bool flag = A_0.DoesFileExist(fileName);
							num = (short)304807994;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 72:
							goto IL_CED;
						case 73:
						{
							short num3;
							int num8;
							if (num8 >= (int)num3)
							{
								num = (short)1343225919;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							byte[] array;
							arrayList3.Insert(num8, array[num8++]);
							num = (short)1430388785;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						goto IL_161;
						IL_2F9:
						b = (byte)arrayList3[8];
						num = (short)592969774;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_344:
						this.a(this.s, A_0);
						num = (short)1643642916;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_383:
						num = (short)324403251;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_3C0:
						num6 = 0;
						num = (short)85983294;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_3FF:
						text = this.a(A_0, A_2);
						num = (short)793116694;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_59B:
						string fileName2 = global::AcpASKLib.SystemKeyLoadedEventArgs.b("≮ば⁲㹴奶䥸", a_);
						short num13 = 400;
						short num14 = 400;
						A_0.GetMaxFileSpace(fileName2, out num13);
						A_0.GetFileSize(fileName2, ref num14);
						num = (short)290586625;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_6CE:
						num = (short)1327955985;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_807:
						num = (short)861470741;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_843:
						num = (short)1518665780;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_8B4:
						num = (short)1694236745;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_B1D:
						num = (short)1649737785;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_C80:
						num = (short)311296029;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_CED:
						num = (short)350355466;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_D66:
						this.a = (short)((byte)arrayList3[9]);
						byte[] a_4 = (byte[])arrayList3.ToArray(typeof(byte));
						byte[] a_5 = (byte[])arrayList2.ToArray(typeof(byte));
						byte[] a_6 = (byte[])arrayList.ToArray(typeof(byte));
						this.a(null, a_4, a_5, a_6, A_3, A_5, A_6);
						num = (short)1444020233;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_252:
					throw new global::System.Exception(global::AcpASKLib.SystemKeyLoadedEventArgs.b("⭮ၰݲᑴ坶㩸፺᡼᱾ꦈ뎒ﮔ뮚ﺞ햠삢춤螦袨", a_));
					IL_48E:
					throw new global::System.Exception(global::AcpASKLib.SystemKeyLoadedEventArgs.b("♮ὰղᑴ᭶ၸὺ嵼ま햀슂햄Ꞇ쾈놐\uda92톔뚖", a_));
					IL_4CD:
					throw new global::System.Exception(global::AcpASKLib.SystemKeyLoadedEventArgs.b("♮ὰղᑴ᭶ၸὺ嵼㑾쒀\uda82ꖄ솆꾎\ud890힒뒔", a_));
					IL_60E:
					throw new global::System.Exception(global::AcpASKLib.SystemKeyLoadedEventArgs.b("敮硰穲彴嵶卸兺坼啾ꮀꎂ좄욆\uda88삊ꎌ뾎놐漢뾞쾠횢좤얦첨\ud9aa趬쮮\udeb0횲운鞶ힸ풺즼龾곀ꋂ뇄꓆ꇈ꧌꫎Ꟑ뫒뛔닖律꣚룜귞裠苢觤쟦蟨黪胬跮铰臲\udbf4ퟶ폸퇺퟼헾⬀⤂⼄ⴆ⌈Ċ", a_));
					IL_684:
					throw new global::System.Exception(global::AcpASKLib.SystemKeyLoadedEventArgs.b("敮硰穲彴嵶卸兺坼彾권ﺒ붜咽펠첢좤螦쾨슪솬쪮슰鎲톴\ud8b6馸햺튼쮾껂꓄돆꫈ꏊꯎ듐ꗒ볔듖볘ﯚ쯠짢쿤췦쏨", a_));
					IL_7A5:
					throw new global::System.Exception(global::AcpASKLib.SystemKeyLoadedEventArgs.b("敮硰穲彴嵶卸兺坼彾캀힂쒄힆ꦈﶎ璉랖ﶞ쒠톢횤螦쾨\ud9aa슬슮醰햲\udcb4\udbb6\udcb8좺鶼\udbbe껀ꯄ꣆뷈ꃌ껎ꗐ냒뷔뷘뻚ꯜ뛞苠蛢", a_));
					IL_959:
					throw new global::System.Exception(global::AcpASKLib.SystemKeyLoadedEventArgs.b("⁮╰㉲╴坶㩸፺᡼᱾ꦈ뎒ﮔ뮚ﺞ햠삢춤螦袨", a_));
					IL_9D5:
					IL_A86:
					throw new global::System.Exception(global::AcpASKLib.SystemKeyLoadedEventArgs.b("♮ὰղᑴ᭶ၸὺ嵼㑾쒀\uda82ꪄ쎆좈\udf8a첌꾎힐朗璉릘튚\ud99c뺞", a_));
					IL_AD8:
					goto IL_684;
					IL_CE8:
					throw new global::System.Exception(global::AcpASKLib.SystemKeyLoadedEventArgs.b("⑮ᑰੲ啴㑶ᅸṺṼᑾꞆﲎ놐ﶒ杖릘ﲜ슠쮢薤蚦", a_));
					IL_DEF:
					break;
					IL_161:
					num = (short)23890121;
					short num15 = num;
					num = (short)1599768777;
					switch ((num15 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_BE9:
						num = (short)819396636;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_32;
					default:
					{
						num = (short)683016192;
						if (num != 0)
						{
						}
						bool flag2 = false;
						num = (short)1270939695;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_32;
					}
					}
					break;
				}
				}
			}
			catch (global::System.Exception ex)
			{
				throw ex;
			}
			num = (short)54525953;
			if (num != 0)
			{
			}
			num = (short)582549504;
			short num16 = num;
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x0001C430 File Offset: 0x0001A630
		internal void a(short A_0, global::IBtnWrapperLib.IIBtnWrapper A_1)
		{
			int a_ = 10;
			short num = (short)528285698;
			int num2 = (int)((global::System.IntPtr)num);
			string text;
			string text2;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					text = null;
					num = (short)121372687;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					if (text.Length > 0)
					{
						num = (short)1508114439;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_34F;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_6D;
					}
					continue;
				case 3:
					if (text != null)
					{
						num = (short)1966538760;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_34F;
				case 4:
					goto IL_253;
				case 5:
					if (A_0 == 0)
					{
						num = (short)1859125258;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					text2 = string.Format(global::AcpCommonResources.AcpResources.ResourceManager.GetString(global::AcpASKLib.SystemKeyLoadedEventArgs.b("♦ᵨὪ౬౮ᥰᙲᅴ⡶㉸ṺѼ⁾횀횈캊ﾎ", a_), global::AcpCommonResources.AcpResources.Culture), text, A_0);
					num = (short)1746403332;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					goto IL_253;
				case 7:
				{
					num = (short)1117710681;
					short num3 = num;
					num = (short)1395190105;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_9D;
					default:
						num = (short)307167232;
						if (num != 0)
						{
						}
						this.q = true;
						global::AcpASKLib.KeyRecordSet.e(text);
						num = (short)1376190478;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 8:
					num = (short)1380253697;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					goto IL_298;
				case 10:
					text2 = string.Format(global::AcpCommonResources.AcpResources.ResourceManager.GetString(global::AcpASKLib.SystemKeyLoadedEventArgs.b("♦ᵨὪ౬౮ᥰᙲᅴ⡶㉸ṺѼ⁾쒀ﮂﮈ캐잒杖", a_), global::AcpCommonResources.AcpResources.Culture), text);
					num = (short)1513684998;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					num = (short)898826243;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					goto IL_3B0;
				case 13:
					if (A_0 < 0)
					{
						num = (short)1145438208;
						short num4 = num;
						num = (short)175177740;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1003356165;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
					goto IL_34F;
				case 15:
					if (!this.a(A_1, ref text))
					{
						num = (short)727711755;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				goto IL_6D;
				IL_9D:
				num = (short)274857984;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_6D:
				num = (short)1511981057;
				if (num != 0)
				{
				}
				if (A_0 < 30)
				{
					goto IL_9D;
				}
				break;
				IL_253:
				global::System.Windows.MessageBox.Show(text2, global::AcpCommonResources.AcpResources.ResourceManager.GetString(global::AcpASKLib.SystemKeyLoadedEventArgs.b("てࡨᥪͬٮὰᑲ⩴㹶ᵸ", a_), global::AcpCommonResources.AcpResources.Culture), global::System.Windows.MessageBoxButton.OK, global::System.Windows.MessageBoxImage.Exclamation, global::System.Windows.MessageBoxResult.OK, this.v);
				num = (short)1597177865;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_34F:
				text2 = null;
				num = (short)1664286733;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_298:
			return;
			IL_3B0:
			text2 = string.Format(global::AcpCommonResources.AcpResources.ResourceManager.GetString(global::AcpASKLib.SystemKeyLoadedEventArgs.b("♦ᵨὪ౬౮ᥰᙲᅴ⡶㉸ṺѼ⁾쒀ﮂﮈ", a_), global::AcpCommonResources.AcpResources.Culture), text);
			global::System.Windows.MessageBox.Show(text2, global::AcpCommonResources.AcpResources.ResourceManager.GetString(global::AcpASKLib.SystemKeyLoadedEventArgs.b("てࡨᥪͬٮὰᑲ⩴㹶ᵸ", a_), global::AcpCommonResources.AcpResources.Culture), global::System.Windows.MessageBoxButton.OK, global::System.Windows.MessageBoxImage.Exclamation, global::System.Windows.MessageBoxResult.OK, this.v);
			throw new global::System.Exception(text2);
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x0001C7F4 File Offset: 0x0001A9F4
		private void a()
		{
			short num;
			try
			{
				num = (short)1043136514;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_F3;
					case 1:
						goto IL_10B;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_39;
						}
						continue;
					case 3:
						this.v = (global::System.Windows.MessageBoxOptions.RightAlign | global::System.Windows.MessageBoxOptions.RtlReading);
						num = (short)1415839748;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
					{
						num = (short)1367217594;
						short num3 = num;
						num = (short)726537658;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_F3;
						default:
							num = (short)671940608;
							if (num != 0)
							{
							}
							goto IL_F3;
						}
						break;
					}
					}
					IL_39:
					if (global::System.Threading.Thread.CurrentThread.CurrentUICulture.TextInfo.IsRightToLeft)
					{
						num = (short)943652867;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					this.v = global::System.Windows.MessageBoxOptions.None;
					num = (short)1623064576;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_F3:
					num = (short)1485832193;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_10B:;
			}
			catch
			{
			}
			num = (short)1747845120;
			short num4 = num;
			num = (short)1680670721;
			if (num != 0)
			{
			}
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x0001C980 File Offset: 0x0001AB80
		internal bool a(byte[] A_0, byte[] A_1, byte[] A_2, byte[] A_3, global::AcpASKLib.AccessLevelDataRecordSet A_4, bool A_5, bool A_6)
		{
			int a_ = 13;
			short num = (short)786432;
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
				global::System.Collections.ObjectModel.Collection<global::AcpASKLib.KeyDataRecord> collection2;
				for (;;)
				{
					IL_31:
					global::System.Collections.ObjectModel.Collection<global::AcpASKLib.OtapData> collection;
					global::System.Collections.Generic.IEnumerator<global::AcpASKLib.KeyDataRecord> enumerator;
					bool flag;
					switch (num2)
					{
					case 0:
						if (collection != null)
						{
							num = (short)591855617;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_129;
					case 1:
						num = (short)1969618949;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_208;
					case 3:
						try
						{
							num = (short)1669464066;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1082720260;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpASKLib.KeyDataRecord item = enumerator.Current;
									this.d.Add(item);
									num = (short)730595331;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									goto IL_2FE;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_27F;
									}
									continue;
								case 4:
									num = (short)531562497;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_2AE:
								num = (short)599261184;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_27F:
								goto IL_2AE;
							}
							IL_2FE:
							return true;
						}
						finally
						{
							num = (short)750190593;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_39B;
								case 1:
								{
									num = (short)448590331;
									short num3 = num;
									num = (short)1210511867;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_39B;
									default:
										num = (short)395837440;
										if (num != 0)
										{
										}
										switch (0)
										{
										case 0:
											goto IL_382;
										}
										continue;
									}
									break;
								}
								case 2:
									goto IL_3B9;
								}
								IL_382:
								if (enumerator != null)
								{
									num = (short)2079457280;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
								IL_39B:
								enumerator.Dispose();
								num = (short)102957058;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_3B9:;
						}
						goto Block_6;
					case 4:
						if (flag)
						{
							num = (short)1308360717;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_19B;
					case 5:
						if (collection.Count == 0)
						{
							num = (short)1130758156;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_208;
					case 6:
						goto IL_3BC;
					case 7:
						goto IL_163B;
					case 8:
						if (A_4 != null)
						{
							num = (short)1323696128;
							short num4 = num;
							num = (short)1300758537;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_DD;
					case 9:
						enumerator = collection2.GetEnumerator();
						num = (short)752812038;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						goto IL_19B;
					case 11:
						if (collection2 != null)
						{
							num = (short)268500999;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_187;
					case 12:
						goto IL_129;
					case 13:
					{
						int count = collection2.Count;
						int count2 = collection.Count;
						num = (short)348454922;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_70;
					IL_DD:
					enumerator = collection2.GetEnumerator();
					num = (short)1394212867;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					Block_6:
					global::System.Collections.ObjectModel.Collection<global::AcpASKLib.AccessRecordData> collection3;
					try
					{
						IL_3BC:
						num = (short)621019228;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							int num5;
							int num6;
							global::AcpASKLib.AccessRecordData accessRecordData;
							byte[] array;
							int num7;
							switch (num2)
							{
							case 0:
								goto IL_BA2;
							case 1:
								goto IL_5F6;
							case 2:
							{
								global::AcpASKLib.KeyDataRecord keyDataRecord;
								global::AcpASKLib.AccessRecord accessRecord = A_4.a(keyDataRecord.AccessLevel);
								num = (short)1281228815;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 3:
								if (num5 >= 24)
								{
									num = (short)1813643293;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_F18;
							case 4:
								goto IL_111B;
							case 5:
								num6 = 0;
								num = (short)1939406885;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 6:
							{
								global::AcpASKLib.KeyDataRecord keyDataRecord;
								string text;
								keyDataRecord.AccessLevel.Name = text;
								A_4.AddNewRecord(keyDataRecord.AccessLevel);
								num = (short)2012741639;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 8:
								accessRecordData.FieldCode = array;
								num = (short)631439361;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 9:
								num5 = 0;
								num = (short)14090308;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 10:
								goto IL_F47;
							case 11:
								goto IL_903;
							case 12:
								goto IL_1095;
							case 13:
								if (collection3 != null)
								{
									num = (short)828637242;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_11BF;
							case 14:
								if (accessRecordData.Ranges != null)
								{
									num = (short)879493159;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_701;
							case 15:
							{
								global::AcpASKLib.AccessRecord accessRecord;
								if (accessRecord == null)
								{
									num = (short)1686569016;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::AcpASKLib.KeyDataRecord keyDataRecord;
								keyDataRecord.AccessLevel.Name = accessRecord.Name;
								keyDataRecord.AccessLevel.ID = accessRecord.ID;
								keyDataRecord.AccessLevel.PrimaryKey = accessRecord.PrimaryKey;
								num = (short)803995668;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 16:
							{
								bool flag2;
								if (flag2)
								{
									num = (short)1677525066;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_1095;
							}
							case 17:
								if (num7 != 0)
								{
									num = (short)1427439679;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_1533;
							case 18:
								goto IL_BA2;
							case 19:
								if (array.Length != 24)
								{
									num = (short)980942923;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_1436;
							case 21:
								goto IL_C6A;
							case 22:
							{
								if (A_5)
								{
									num = (short)503709727;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								bool flag2;
								global::AcpASKLib.AccessRecordData accessRecordData2 = global::AcpASKLib.AccessDataConverter.a(accessRecordData, flag2);
								global::AcpASKLib.KeyDataRecord keyDataRecord;
								keyDataRecord.AccessLevel = new global::AcpASKLib.AccessRecord(accessRecordData2.PrimaryKey, global::AcpASKLib.FeatureCategoryType.TRUNKING, accessRecordData2.FieldCode, accessRecordData2.Ranges, flag2);
								num = (short)288882699;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 23:
								if (num6 != 0)
								{
									num = (short)1579614288;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_111B;
							case 24:
								goto IL_13F8;
							case 25:
								goto IL_1436;
							case 26:
							{
								global::AcpASKLib.AccessRecord accessRecord2;
								if (accessRecord2 == null)
								{
									num = (short)1679360006;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								int num8;
								string text = string.Format(global::AcpASKLib.SystemKeyLoadedEventArgs.b("⭩ཫ൭ᕯűݳ噵㑷ό੻᭽ꊁﾃ뚅", a_), ++num8);
								accessRecord2 = A_4.a(text);
								num = (short)297140248;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 27:
								goto IL_1533;
							case 28:
							{
								bool flag2;
								if (flag2)
								{
									num = (short)1580597305;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_7EB;
							}
							case 29:
								array[10] = 247;
								num = (short)1932984396;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 30:
								goto IL_101D;
							case 31:
							{
								global::AcpASKLib.KeyDataRecord keyDataRecord;
								bool flag2;
								keyDataRecord.AccessLevel = new global::AcpASKLib.AccessRecord(accessRecordData.PrimaryKey, global::AcpASKLib.FeatureCategoryType.TRUNKING, accessRecordData.FieldCode, accessRecordData.Ranges, flag2);
								num = (short)146276422;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 32:
								goto IL_101D;
							case 33:
								goto IL_1533;
							case 34:
								goto IL_1533;
							case 35:
								if (array[num5] != 255)
								{
									num = (short)1071906856;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								num5++;
								num = (short)705560625;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 36:
								goto IL_1393;
							case 37:
								goto IL_FA6;
							case 38:
								goto IL_15CA;
							case 39:
								num7 = accessRecordData.Ranges.Count;
								num = (short)2109145150;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 40:
								num6 = 0;
								num = (short)1616773164;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 41:
								goto IL_9D4;
							case 42:
								if (!flag)
								{
									num = (short)285802561;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_111B;
							case 43:
								if (A_6)
								{
									num = (short)1190133762;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							case 44:
								goto IL_9D4;
							case 45:
								num = (short)1041301585;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 46:
								goto IL_CE5;
							case 47:
							{
								global::System.Collections.Generic.IEnumerator<global::AcpASKLib.OtapData> enumerator2 = collection.GetEnumerator();
								num = (short)1424293978;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 48:
								if (array[num5] != 255)
								{
									num = (short)1357905925;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								num5++;
								num = (short)1814560814;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 49:
								goto IL_76B;
							case 50:
								num5 = 0;
								num = (short)1712062537;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 51:
								if (num5 >= 10)
								{
									num = (short)109772841;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)1710817315;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 52:
								goto IL_1533;
							case 53:
								if (accessRecordData.FieldCode.Length != 24)
								{
									num = (short)723451963;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_1393;
							case 54:
								num = (short)1642856530;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 55:
								if (this.a == 1)
								{
									num = (short)1717764105;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)1286930523;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 56:
							{
								int num8 = 1;
								string text = global::AcpASKLib.SystemKeyLoadedEventArgs.b("⭩ཫ൭ᕯűݳ噵㑷ό੻᭽ꊁ떃", a_);
								global::AcpASKLib.AccessRecord accessRecord2 = A_4.a(text);
								num = (short)1069023319;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 57:
								num = (short)1616969745;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 58:
							{
								global::System.Collections.Generic.IEnumerator<global::AcpASKLib.AccessRecordData> enumerator3 = collection3.GetEnumerator();
								num = (short)917897301;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 59:
								accessRecordData.FieldCode = array;
								num = (short)255721508;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 60:
							{
								if (flag)
								{
									num = (short)1726873647;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								bool flag2 = true;
								num = (short)596181013;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 61:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)544211028;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::AcpASKLib.KeyDataRecord keyDataRecord = enumerator.Current;
								accessRecordData = null;
								num = (short)1145700365;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 62:
								goto IL_701;
							case 63:
								goto IL_7EB;
							case 64:
								if (num6 == 2)
								{
									num = (short)584974415;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_5F6;
							case 65:
								num = (short)1515782167;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 66:
								if (num7 != 0)
								{
									num = (short)1495007244;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_1533;
							case 67:
								if (accessRecordData != null)
								{
									num = (short)929169494;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							case 68:
								goto IL_76B;
							case 69:
								goto IL_FA6;
							case 70:
								goto IL_903;
							case 71:
								if (num5 >= 12)
								{
									num = (short)26083397;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)1403060272;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 72:
								if (num6 > 0)
								{
									num = (short)122552403;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_872;
							case 73:
								goto IL_CE5;
							case 74:
								num = (short)2055209026;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 75:
								array = new byte[24];
								num = (short)564133913;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 76:
								if (accessRecordData.FieldCode.Length != 24)
								{
									num = (short)2036400136;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_5F6;
							case 77:
								if (num5 >= 24)
								{
									num = (short)308609102;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								array[num5] = byte.MaxValue;
								num5++;
								num = (short)640811038;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 78:
								num = (short)852021;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 79:
								num = (short)1235222547;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 80:
							{
								bool flag2 = true;
								num = (short)674037764;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 81:
								if (num7 == 0)
								{
									num = (short)989659229;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_872;
							case 82:
								if (array.Length != 24)
								{
									num = (short)131858526;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_F47;
							case 83:
								num = (short)401080408;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 84:
								num = (short)2022309926;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 85:
								try
								{
									num = (short)829554689;
									num2 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										switch (num2)
										{
										case 0:
											num = (short)988217349;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 1:
											switch (0)
											{
											case 0:
												goto IL_123F;
											}
											continue;
										case 2:
										{
											global::AcpASKLib.KeyDataRecord keyDataRecord;
											global::AcpASKLib.AccessRecordData accessRecordData3;
											if (accessRecordData3.PrimaryKey == (int)keyDataRecord.ForiegnKey)
											{
												num = (short)786300934;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											break;
										}
										case 3:
											goto IL_12E1;
										case 4:
										{
											global::System.Collections.Generic.IEnumerator<global::AcpASKLib.AccessRecordData> enumerator3;
											if (!enumerator3.MoveNext())
											{
												num = (short)263979008;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											global::AcpASKLib.AccessRecordData accessRecordData3 = enumerator3.Current;
											num = (short)897908738;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 5:
											goto IL_12FF;
										case 6:
										{
											global::AcpASKLib.AccessRecordData accessRecordData3;
											accessRecordData = accessRecordData3;
											num = (short)1037828099;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										}
										IL_1288:
										num = (short)115998724;
										num2 = (int)((global::System.IntPtr)num);
										continue;
										IL_123F:
										goto IL_1288;
									}
									IL_12E1:
									IL_12FF:
									goto IL_11BF;
								}
								finally
								{
									num = (short)608174081;
									num2 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										global::System.Collections.Generic.IEnumerator<global::AcpASKLib.AccessRecordData> enumerator3;
										switch (num2)
										{
										case 0:
											goto IL_136F;
										case 1:
											switch (0)
											{
											case 0:
												goto IL_1336;
											}
											continue;
										case 2:
											enumerator3.Dispose();
											num = (short)238878720;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										IL_1336:
										if (enumerator3 == null)
										{
											break;
										}
										num = (short)2102329346;
										num2 = (int)((global::System.IntPtr)num);
									}
									IL_136F:;
								}
								goto IL_1372;
							case 86:
							{
								bool flag2 = false;
								num = (short)1843331132;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 87:
								goto IL_13F8;
							case 88:
								if ((array[10] & 15) == 15)
								{
									num = (short)1221591085;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_872;
							case 89:
								if (num6 == 1)
								{
									num = (short)1042808886;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_1393;
							case 90:
								try
								{
									num = (short)1576665088;
									num2 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										switch (num2)
										{
										case 0:
											switch (0)
											{
											case 0:
												goto IL_D95;
											}
											continue;
										case 1:
											goto IL_DFC;
										case 2:
										{
											global::System.Collections.Generic.IEnumerator<global::AcpASKLib.OtapData> enumerator2;
											if (!enumerator2.MoveNext())
											{
												num = (short)2146762755;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											global::AcpASKLib.OtapData otapData = enumerator2.Current;
											num = (short)1034944518;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 3:
											num = (short)336789512;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 4:
										{
											global::AcpASKLib.OtapData otapData;
											bool flag2 = otapData.OTAPStatus;
											num = (short)386924545;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 5:
										{
											global::AcpASKLib.KeyDataRecord keyDataRecord;
											global::AcpASKLib.OtapData otapData;
											if (keyDataRecord.KeyType == otapData.OTAPKeyType)
											{
												num = (short)1054146564;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											break;
										}
										case 6:
										{
											global::AcpASKLib.KeyDataRecord keyDataRecord;
											global::AcpASKLib.OtapData otapData;
											if (keyDataRecord.SystemID == otapData.SystemID)
											{
												num = (short)1769996295;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											break;
										}
										case 7:
											num = (short)642252805;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 8:
											goto IL_EA5;
										}
										IL_E50:
										num = (short)91029506;
										num2 = (int)((global::System.IntPtr)num);
										continue;
										IL_D95:
										goto IL_E50;
									}
									IL_DFC:
									IL_EA5:
									goto IL_C6A;
								}
								finally
								{
									num = (short)493355008;
									num2 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										global::System.Collections.Generic.IEnumerator<global::AcpASKLib.OtapData> enumerator2;
										switch (num2)
										{
										case 0:
											switch (0)
											{
											case 0:
												goto IL_EDE;
											}
											continue;
										case 1:
											enumerator2.Dispose();
											num = (short)1824391170;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 2:
											goto IL_F15;
										}
										IL_EDE:
										if (enumerator2 == null)
										{
											break;
										}
										num = (short)154468353;
										num2 = (int)((global::System.IntPtr)num);
									}
									IL_F15:;
								}
								goto IL_F18;
							case 91:
								if (this.a == 2)
								{
									num = (short)1401225266;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								num6 = global::AcpASKLib.KeyDataRecord.a(array);
								num = (short)1478033436;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 92:
								switch (0)
								{
								case 0:
									goto IL_55F;
								}
								continue;
							case 93:
								goto IL_1372;
							case 94:
								array = new byte[24];
								num = (short)943390730;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_55F;
							IL_5F6:
							num = (short)117309482;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_701:
							num6 = 1;
							num5 = 0;
							num = (short)1259536439;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_76B:
							num = (short)1223491635;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_7EB:
							num6 = 0;
							num = (short)463929396;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_872:
							num6 = 0;
							num = (short)1142947867;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_903:
							num = (short)677183531;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_9D4:
							num = (short)1090584648;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_BA2:
							num = (short)1593769987;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_C6A:
							array = accessRecordData.FieldCode;
							num7 = 0;
							num = (short)598212622;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_CE5:
							num = (short)1944715335;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_F18:
							array[num5] = byte.MaxValue;
							num5++;
							num = (short)604635136;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_F47:
							num5 = 0;
							num = (short)1376387104;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_FA6:
							num = (short)52101136;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_101D:
							num = (short)57802829;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_1095:
							num6 = 0;
							num = (short)1557856289;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_111B:
							num = (short)1782448150;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_11BF:
							num = (short)724566083;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_1372:
							num6 = 1;
							num = (short)220200994;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_1393:
							num = (short)765984832;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_13F8:
							num = (short)1827733530;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_1436:
							num5 = 0;
							num = (short)533725202;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_1533:
							num = (short)1138360409;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_1572:
							num = (short)1513226301;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_55F:
							goto IL_1572;
						}
						IL_15CA:
						goto IL_DD;
					}
					finally
					{
						num = (short)676462593;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_1638;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_1601;
								}
								continue;
							case 2:
								enumerator.Dispose();
								num = (short)1253179392;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_1601:
							if (enumerator == null)
							{
								break;
							}
							num = (short)750387202;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_1638:;
					}
					goto IL_163B;
					IL_129:
					flag = false;
					num = (short)1686765570;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_19B:
					collection3 = this.b(A_2);
					num = (short)517668872;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_208:
					num = (short)155975684;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_163B:
					collection = null;
					flag = true;
					collection = this.c(A_3);
					num = (short)1284702208;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_187:
				throw new global::System.Exception(global::AcpASKLib.SystemKeyLoadedEventArgs.b("⑩ͫ乭⍯ୱݳɵᵷ᝹ཻ幽ꪉ낏ﲓ뢗鍊", a_));
				IL_70:
				collection2 = this.a(A_1, A_4);
				num = (short)1820000257;
				if (num != 0)
				{
				}
				num = (short)1977745419;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x0001E0A0 File Offset: 0x0001C2A0
		internal bool a(ref global::System.Collections.ArrayList A_0, ref global::System.Collections.ArrayList A_1, ref global::System.Collections.ArrayList A_2, global::System.Collections.ArrayList A_3, global::AcpASKLib.AccessLevelDataRecordSet A_4)
		{
			short num = (short)1272643584;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)1639186434;
				num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.Collections.Generic.IEnumerator<global::AcpASKLib.IKeyDataRecord> enumerator;
					global::System.Collections.IEnumerator enumerator2;
					switch (num2)
					{
					case 0:
						try
						{
							num = (short)1463549959;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.ArrayList arrayList;
								switch (num2)
								{
								case 0:
									goto IL_378;
								case 1:
								{
									byte b;
									A_2.Add(b);
									byte b2;
									arrayList.Add(b2);
									num = (short)2035941382;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									goto IL_46F;
								case 3:
									goto IL_360;
								case 4:
									num = (short)304218114;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
								{
									byte b = 1;
									num = (short)1975713795;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									goto IL_3CE;
								case 7:
									switch (0)
									{
									case 0:
										goto IL_11C;
									}
									continue;
								case 8:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)350486532;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1263785976;
									short num3 = num;
									num = (short)600758264;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_378;
									default:
										num = (short)1845035008;
										if (num != 0)
										{
										}
										num = (short)1539899401;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 9:
								{
									global::AcpASKLib.KeyDataRecord keyDataRecord = (global::AcpASKLib.KeyDataRecord)enumerator.Current;
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
									byte b5 = global::AcpASKLib.Global.a((byte[])arrayList.ToArray(typeof(byte)));
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
										num = (short)1462632453;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_360;
								}
								}
								goto IL_11C;
								IL_360:
								num = (short)1874395136;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_378:
								if (A_4 != null)
								{
									num = (short)947388417;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_3CE:
								byte b6 = global::AcpASKLib.Global.a((byte[])arrayList.ToArray(typeof(byte)));
								A_2.Add(b6);
								num = (short)2050686986;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_414:
								num = (short)59047944;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_11C:
								goto IL_414;
							}
							IL_46F:
							goto IL_666;
						}
						finally
						{
							num = (short)1577058305;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)667222018;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_4A6;
									}
									continue;
								case 2:
									goto IL_4E0;
								}
								IL_4A6:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1881079808;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_4E0:;
						}
						goto IL_4E3;
					case 1:
						goto IL_4E3;
					case 2:
						num = (short)1049296897;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_7D;
						}
						continue;
					case 3:
						try
						{
							num = (short)127074307;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 1:
									goto IL_5C4;
								case 2:
								{
									if (!enumerator2.MoveNext())
									{
										num = (short)413335556;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpASKLib.AccessRecord accessRecord = (global::AcpASKLib.AccessRecord)enumerator2.Current;
									A_1.AddRange(accessRecord.PackedData);
									num = (short)973930496;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									switch (0)
									{
									case 0:
										goto IL_53F;
									}
									continue;
								case 4:
									num = (short)501612545;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_573:
								num = (short)1707999234;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_53F:
								goto IL_573;
							}
							IL_5C4:;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_5E3;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_5D0:
								switch (num2)
								{
								case 0:
									disposable.Dispose();
									num = (short)1379270658;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									if (disposable != null)
									{
										num = (short)1604255744;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_63A;
								case 2:
									goto IL_638;
								}
								goto IL_5E3;
							}
							IL_638:
							IL_63A:
							goto EndFinally_13;
							IL_5E3:
							disposable = (enumerator2 as global::System.IDisposable);
							num = (short)1398734849;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_5D0;
							EndFinally_13:;
						}
						goto IL_63B;
					}
					IL_7D:
					num = (short)468713472;
					short num4 = num;
					if (A_4 != null)
					{
						num = (short)265945089;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_63B;
					IL_4E3:
					enumerator2 = A_3.GetEnumerator();
					num = (short)307691523;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_63B:
					enumerator = this.d.GetEnumerator();
					num = (short)1475411968;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_666:
				byte b7 = global::AcpASKLib.Global.a((byte[])A_0.ToArray(typeof(byte)));
				A_0.Add(b7);
				byte b8 = global::AcpASKLib.Global.a((byte[])A_1.ToArray(typeof(byte)));
				A_1.Add(b8);
				byte b9 = global::AcpASKLib.Global.a((byte[])A_2.ToArray(typeof(byte)));
				A_2.Add(b9);
				return true;
			}
			}
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x0001E7C8 File Offset: 0x0001C9C8
		private global::System.Collections.ObjectModel.Collection<global::AcpASKLib.OtapData> c(byte[] A_0)
		{
			int a_ = 12;
			short num = (short)1381236736;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_B3;
				}
				bool flag;
				global::System.Collections.ObjectModel.Collection<global::AcpASKLib.OtapData> collection;
				int num5;
				int num6;
				for (;;)
				{
					IL_30:
					int num7;
					int num8;
					global::System.Collections.ArrayList arrayList;
					int num10;
					byte a_3;
					byte b;
					byte b2;
					switch (num2)
					{
					case 0:
						if (flag)
						{
							num = (short)1147469837;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return collection;
					case 1:
						goto IL_2F6;
					case 2:
					{
						int num3;
						if (num3 >= 12)
						{
							num = (short)151453715;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						byte[] array;
						array[num3] = A_0[num3];
						num3++;
						num = (short)575188251;
						short num4 = num;
						num = (short)1753984283;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_30F;
						default:
							num = (short)1769013248;
							if (num != 0)
							{
							}
							num = (short)487784454;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 3:
						flag = false;
						num = (short)1884291092;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_30F;
					case 5:
						if (A_0.Length == 0)
						{
							num = (short)934805507;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_39F;
					case 6:
						goto IL_3DB;
					case 7:
						num = (short)1006108683;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						if (A_0 != null)
						{
							num = (short)295108626;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return collection;
					case 9:
						num = (short)1784086533;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
					{
						byte[] array;
						if (global::AcpASKLib.Global.a(array) != A_0[12])
						{
							num = (short)305070110;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num5 = (int)A_0[9];
						num6 = (int)A_0[11];
						num7 = 13;
						num8 = A_0.Length;
						collection = new global::System.Collections.ObjectModel.Collection<global::AcpASKLib.OtapData>();
						num = (short)398721045;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
					{
						int num9;
						if (num6 != num9)
						{
							num = (short)187891727;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return collection;
					}
					case 12:
					{
						num = (short)1402011649;
						if (num != 0)
						{
						}
						bool a_2 = true;
						num = (short)387448856;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
					{
						int num9 = 0;
						byte[] array = new byte[12];
						int num3 = 0;
						num = (short)142934032;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
						if (A_0.Length != 0)
						{
							num = (short)1724317705;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return collection;
					case 15:
						goto IL_22F;
					case 16:
						goto IL_3DB;
					case 17:
						arrayList.Add(A_0[num7]);
						num10 = (int)A_0[num7++] << 24;
						num = (short)502136855;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						num = (short)1517486094;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						num = (short)342884362;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						goto IL_39F;
					case 21:
						goto IL_2F6;
					case 22:
						goto IL_4F9;
					case 23:
						goto IL_56E;
					case 24:
						goto IL_470;
					case 25:
						if (num5 < 4)
						{
							num = (short)1612972049;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						arrayList.Add(A_0[num7]);
						a_3 = A_0[num7++];
						num = (short)957087773;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
					{
						num = (short)2020540416;
						short num11 = num;
						if (A_0[num7++] != b)
						{
							num = (short)883556374;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						bool a_2;
						global::AcpASKLib.OtapData item = new global::AcpASKLib.OtapData(a_3, num10, a_2);
						collection.Add(item);
						int num9;
						num9++;
						num = (short)1511456769;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 27:
						goto IL_470;
					case 28:
					{
						if ((b2 & 1) > 0)
						{
							num = (short)532414476;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						bool a_2 = false;
						num = (short)651296795;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 29:
						goto IL_56E;
					case 30:
						goto IL_457;
					}
					goto IL_B3;
					IL_30F:
					if (num7 >= num8 - 3)
					{
						num = (short)1565982727;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num10 = 0;
					arrayList = new global::System.Collections.ArrayList();
					a_3 = 0;
					num = (short)1971519513;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2F6:
					num = (short)528482308;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_39F:
					num = (short)1844838400;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3DB:
					num = (short)802619394;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_470:
					b = global::AcpASKLib.Global.a((byte[])arrayList.ToArray(typeof(byte)));
					num = (short)1823080474;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_56E:
					arrayList.Add(A_0[num7]);
					num10 |= (int)A_0[num7++] << 16;
					arrayList.Add(A_0[num7]);
					num10 |= (int)A_0[num7++] << 8;
					arrayList.Add(A_0[num7]);
					num10 |= (int)A_0[num7++];
					b2 = A_0[num7++];
					arrayList.Add(b2);
					num = (short)444006428;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_22F:
				throw new global::System.Exception(global::AcpASKLib.SystemKeyLoadedEventArgs.b("捨扪䵬⥮ば㩲㥴㉶㵸孺㱼⭾ꆀ첂톄욆\ud988ꖊ붌꾎벐뎒잔튖\uda98풚쾜\udb9e膠ﾪ趬龾췆", a_));
				IL_457:
				throw new global::System.Exception(global::AcpASKLib.SystemKeyLoadedEventArgs.b("捨扪䵬⥮ば㩲㥴㉶㵸孺㱼⭾ꆀ첂톄욆\ud988ꖊ붌꾎\ud990횒풔펖\udc98즚붜\udc9e直ﺪ辮邰銲钴붶", a_));
				IL_4F9:
				throw new global::System.Exception(global::AcpASKLib.SystemKeyLoadedEventArgs.b("捨扪䵬⥮ば㩲㥴㉶㵸孺㱼⭾ꆀ첂톄욆\ud988ꖊ붌꾎풐\udd92솔얖삘뮚\ude9c힞ﲨ趬躮邰銲뾴", a_));
				IL_B3:
				collection = null;
				flag = true;
				num6 = 0;
				num5 = -1;
				num = (short)1799290888;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x0001EE64 File Offset: 0x0001D064
		private global::System.Collections.ObjectModel.Collection<global::AcpASKLib.KeyDataRecord> a(byte[] A_0, global::AcpASKLib.AccessLevelDataRecordSet A_1)
		{
			int a_ = 4;
			short num = (short)1654194176;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_9C;
				}
				int num4;
				global::System.Collections.ObjectModel.Collection<global::AcpASKLib.KeyDataRecord> collection;
				for (;;)
				{
					IL_31:
					global::System.Collections.ArrayList arrayList;
					byte b3;
					switch (num2)
					{
					case 0:
						goto IL_DD;
					case 1:
						goto IL_186;
					case 2:
					{
						int num3;
						if (num3 != num4)
						{
							num = (short)825556998;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return collection;
					}
					case 3:
						num = (short)394067981;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
					{
						int num3 = 0;
						byte[] array = new byte[11];
						int num5 = 0;
						num = (short)1005518856;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						num = (short)1522991105;
						if (num != 0)
						{
						}
						goto IL_576;
					case 6:
						goto IL_350;
					case 7:
						if (A_0 != null)
						{
							num = (short)1290338325;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return collection;
					case 8:
						goto IL_211;
					case 9:
						goto IL_277;
					case 10:
						if (A_1 != null)
						{
							num = (short)410583057;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_DD;
					case 11:
						goto IL_416;
					case 12:
					{
						int num6;
						arrayList.Add(A_0[num6]);
						arrayList.Add(A_0[num6 + 1]);
						int a_2 = (int)A_0[num6++] << 8 | (int)A_0[num6++];
						byte a_3 = 0;
						num = (short)1808924677;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
					{
						byte[] array;
						if (global::AcpASKLib.Global.a(array) != A_0[11])
						{
							num = (short)1287520267;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num4 = (int)A_0[10];
						int num6 = 12;
						int num7 = A_0.Length;
						collection = new global::System.Collections.ObjectModel.Collection<global::AcpASKLib.KeyDataRecord>();
						num = (short)1015480344;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
						goto IL_576;
					case 15:
					{
						int num6;
						int num7;
						if (num6 >= num7 - 3)
						{
							num = (short)1753284627;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						byte b = 0;
						arrayList = new global::System.Collections.ArrayList();
						num = (short)2010382358;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 16:
						goto IL_211;
					case 17:
					{
						int num6;
						byte b = A_0[num6++];
						arrayList.Add(b);
						goto IL_2FA;
					}
					case 18:
					{
						int num5;
						if (num5 >= 11)
						{
							num = (short)1616838656;
							short num8 = num;
							num = (short)319684611;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						byte[] array;
						array[num5] = A_0[num5];
						num5++;
						num = (short)586547216;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 19:
						num = (short)222691330;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						if (A_0.Length != 0)
						{
							num = (short)365887492;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return collection;
					case 21:
						num = (short)1482424340;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
					{
						if (this.a < 4)
						{
							num = (short)75300876;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int num6;
						arrayList.Add(A_0[num6]);
						arrayList.Add(A_0[num6 + 1]);
						arrayList.Add(A_0[num6 + 2]);
						byte b2 = A_0[num6] & 15;
						byte a_3 = (byte)(A_0[num6] >> 4);
						num6++;
						int a_2 = (int)b2 << 16 | (int)A_0[num6++] << 8 | (int)A_0[num6++];
						num = (short)2088697870;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 23:
					{
						int num6;
						if (A_0[num6++] != b3)
						{
							num = (short)1051590657;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int a_2;
						byte a_3;
						byte b;
						global::AcpASKLib.KeyDataRecord item = new global::AcpASKLib.KeyDataRecord(a_3, a_2, b);
						collection.Add(item);
						int num3;
						num3++;
						num = (short)379060233;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 24:
						goto IL_277;
					}
					goto IL_9C;
					IL_DD:
					b3 = global::AcpASKLib.Global.a((byte[])arrayList.ToArray(typeof(byte)));
					num = (short)186268623;
					short num9 = num;
					num = (short)1747139535;
					switch ((num9 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_2FA:
						num = (short)1512505344;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					default:
						num = (short)123142144;
						if (num != 0)
						{
						}
						num = (short)1923153943;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_211:
					num = (short)808779794;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_277:
					num = (short)576192527;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_576:
					num = (short)1268252682;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_186:
				throw new global::System.Exception(global::AcpASKLib.SystemKeyLoadedEventArgs.b("歠橢䕤Ⅶ⡨≪Ⅼ⩮㕰卲㑴⍶奸ぺ㡼♾꾀뎂ꖄ슆있\udf8a\udf8c횎놐킒\udd94튖\uda98킚캜쪞莢蒤蚦袨ꆪ", a_));
				IL_350:
				throw new global::System.Exception(global::AcpASKLib.SystemKeyLoadedEventArgs.b("歠橢䕤Ⅶ⡨≪Ⅼ⩮㕰卲㑴⍶奸ぺ㡼♾꾀뎂ꖄꪆꦈ\ud98a좌첎\ude90솒톔랖\uda98풚좜톞莢直ﮮ﮲閴隶颸骺랼", a_));
				IL_416:
				throw new global::System.Exception(global::AcpASKLib.SystemKeyLoadedEventArgs.b("歠橢䕤Ⅶ⡨≪Ⅼ⩮㕰卲㑴⍶奸ぺ㡼♾튀궂떄Ꞇ솈캊첌쮎풐솒떔풖톘\ude9a\ude9c풞螦袨說責ꖮ", a_));
				IL_9C:
				num4 = 0;
				collection = null;
				num = (short)1389232135;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x0001F424 File Offset: 0x0001D624
		private global::System.Collections.ObjectModel.Collection<global::AcpASKLib.AccessRecordData> b(byte[] A_0)
		{
			int a_ = 19;
			short num = (short)969998336;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_EB;
				}
				int num18;
				global::System.Collections.ObjectModel.Collection<global::AcpASKLib.AccessRecordData> collection;
				int num19;
				for (;;)
				{
					IL_30:
					int num4;
					int num5;
					byte[] array2;
					global::System.Collections.Generic.Dictionary<ushort, global::AcpASKLib.FieldValueRangeRecSet> dictionary;
					int num8;
					byte b2;
					byte b3;
					int num11;
					global::AcpASKLib.FieldValueRangeRecSet fieldValueRangeRecSet;
					switch (num2)
					{
					case 0:
					{
						int num3;
						if (num3 >= 11)
						{
							num = (short)823459849;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						byte[] array;
						array[num3] = A_0[num3];
						num3++;
						num = (short)546897932;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
					{
						if (num4 >= num5)
						{
							num = (short)494272540;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int num6;
						array2[num4] = A_0[num6++];
						global::System.Collections.ArrayList arrayList;
						arrayList.Add(array2[num4]);
						num4++;
						num = (short)1435238406;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
					{
						num = (short)1873083412;
						short num7 = num;
						num = (short)1691483156;
						switch ((num7 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_5AB;
						default:
						{
							num = (short)1632894976;
							if (num != 0)
							{
							}
							int num6;
							global::System.Collections.ArrayList arrayList;
							if (global::AcpASKLib.Global.a((byte[])arrayList.ToArray(typeof(byte))) != A_0[num6++])
							{
								num = (short)1794834452;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							arrayList.Clear();
							new global::System.Collections.ArrayList();
							dictionary = new global::System.Collections.Generic.Dictionary<ushort, global::AcpASKLib.FieldValueRangeRecSet>();
							num8 = 0;
							num = (short)1408827424;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 3:
						goto IL_23F;
					case 4:
					{
						int num6;
						byte b = A_0[num6++];
						global::System.Collections.ArrayList arrayList;
						arrayList.Add(b);
						int num9 = (int)b;
						num = (short)1140719651;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						goto IL_244;
					case 6:
						goto IL_5AB;
					case 7:
						goto IL_5AB;
					case 8:
					{
						int num6;
						int num10;
						if (num6 >= num10 - 3)
						{
							num = (short)1759576098;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Collections.ArrayList arrayList = new global::System.Collections.ArrayList();
						b2 = A_0[num6++];
						arrayList.Add(b2);
						num5 = 0;
						num = (short)1273626663;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						num = (short)1542979601;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
					{
						int num6;
						int num10;
						if (num6 >= num10 - 2)
						{
							num = (short)1614741533;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						b3 = A_0[num6++];
						global::System.Collections.ArrayList arrayList;
						arrayList.Add(b3);
						int num9 = 1;
						num = (short)236650514;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
						goto IL_285;
					case 12:
						goto IL_244;
					case 13:
						num5 = 12;
						num = (short)1255604250;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
					{
						int num9;
						if (num11 >= num9)
						{
							num = (short)64749609;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int num6;
						global::System.Collections.ArrayList arrayList;
						arrayList.Add(A_0[num6]);
						uint num12 = (uint)((uint)A_0[num6++] << 24);
						arrayList.Add(A_0[num6]);
						uint num13 = num12 + (uint)((uint)A_0[num6++] << 16);
						arrayList.Add(A_0[num6]);
						uint num14 = num13 + (uint)((uint)A_0[num6++] << 8);
						arrayList.Add(A_0[num6]);
						uint value = num14 + (uint)A_0[num6++];
						arrayList.Add(A_0[num6]);
						uint num15 = (uint)((uint)A_0[num6++] << 24);
						arrayList.Add(A_0[num6]);
						uint num16 = num15 + (uint)((uint)A_0[num6++] << 16);
						arrayList.Add(A_0[num6]);
						uint num17 = num16 + (uint)((uint)A_0[num6++] << 8);
						arrayList.Add(A_0[num6]);
						uint value2 = num17 + (uint)A_0[num6++];
						global::AcpASKLib.AccessFieldValueRange item = new global::AcpASKLib.AccessFieldValueRange((int)b3, new uint?(value), new uint?(value2));
						fieldValueRangeRecSet.Add(item);
						num11++;
						num = (short)795213835;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 15:
					{
						byte b4;
						if (num8 >= (int)b4)
						{
							num = (short)687865872;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1529937930;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 16:
						num = (short)1344471065;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
					{
						byte[] array;
						if (global::AcpASKLib.Global.a(array) != A_0[11])
						{
							num = (short)550961153;
							if (num != 0)
							{
							}
							num = (short)1321861144;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num18 = (int)A_0[10];
						collection = new global::System.Collections.ObjectModel.Collection<global::AcpASKLib.AccessRecordData>();
						int num6 = 12;
						int num10 = A_0.Length;
						num = (short)1886322707;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 18:
						if (this.a > 2)
						{
							num = (short)984743940;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5FF;
					case 19:
						goto IL_2EE;
					case 20:
						goto IL_45B;
					case 21:
						goto IL_9A8;
					case 22:
						goto IL_588;
					case 23:
						goto IL_588;
					case 24:
						goto IL_6B7;
					case 25:
					{
						byte b4;
						if (b4 > 0)
						{
							num = (short)1138950175;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_551;
					}
					case 26:
						goto IL_629;
					case 27:
						if (num19 != num18)
						{
							num = (short)1419771925;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return collection;
					case 28:
					{
						int num6;
						byte b4 = A_0[num6++];
						global::System.Collections.ArrayList arrayList;
						arrayList.Add(b4);
						num = (short)1224933378;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 29:
					{
						byte b4;
						num8 = (int)b4;
						num = (short)1918631958;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 30:
						goto IL_2EE;
					case 31:
						num = (short)89980964;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 32:
						goto IL_9AD;
					case 33:
						num = (short)905379882;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 34:
						num = (short)620429339;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 35:
						goto IL_5FF;
					case 36:
					{
						int num6;
						global::System.Collections.ArrayList arrayList;
						if (global::AcpASKLib.Global.a((byte[])arrayList.ToArray(typeof(byte))) != A_0[num6++])
						{
							num = (short)1265369091;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_551;
					}
					case 37:
					{
						byte[] array = new byte[11];
						int num3 = 0;
						num = (short)60030981;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 38:
						if (A_0 != null)
						{
							num = (short)1875509281;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return collection;
					case 39:
					{
						if (this.a <= 2)
						{
							num = (short)350224397;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int num6;
						num5 = (int)A_0[num6++];
						global::System.Collections.ArrayList arrayList;
						arrayList.Add((byte)num5);
						num = (short)1642397739;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 40:
						goto IL_285;
					case 41:
						dictionary.Add((ushort)b3, fieldValueRangeRecSet);
						num = (short)276758551;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 42:
						if (A_0.Length != 0)
						{
							num = (short)1947664421;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return collection;
					case 43:
						goto IL_629;
					case 44:
						goto IL_9AD;
					}
					goto IL_EB;
					IL_244:
					num = (short)1136590848;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_285:
					num = (short)1770192896;
					short num20 = num;
					num = (short)791085070;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2EE:
					num = (short)1819803656;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_551:
					global::AcpASKLib.AccessRecordData item2 = new global::AcpASKLib.AccessRecordData((int)b2, array2, dictionary);
					collection.Add(item2);
					num19++;
					num = (short)1784217630;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_588:
					num8++;
					num = (short)884342828;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5AB:
					num = (short)1848770561;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5FF:
					fieldValueRangeRecSet = new global::AcpASKLib.FieldValueRangeRecSet((ushort)b3);
					num11 = 0;
					num = (short)282722344;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_629:
					array2 = new byte[num5];
					num4 = 0;
					num = (short)1944453127;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_9AD:
					num = (short)465240079;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_23F:
				throw new global::System.Exception(global::AcpASKLib.SystemKeyLoadedEventArgs.b("穯筱味ふ㥷㍹ほ㭽쑿ꊁ얃튅ꢇ캉춋\uda8d톏벑꒓뚕쪗\udb99튛\ud99d芡ﲧ貫ﶵ麽쳅", a_));
				IL_45B:
				throw new global::System.Exception(global::AcpASKLib.SystemKeyLoadedEventArgs.b("穯筱味ふ㥷㍹ほ㭽쑿ꊁ얃튅ꢇ캉춋\uda8d톏벑꒓뚕\udd97풙좛첝烈芡ﶭﾱ钳鞵馷鮹뚻", a_));
				IL_6B7:
				throw new global::System.Exception(global::AcpASKLib.SystemKeyLoadedEventArgs.b("穯筱味ふ㥷㍹ほ㭽쑿ꊁ얃튅ꢇ캉춋\uda8d톏벑꒓뚕킗\udf99\udd9b\uda9d蒣靈隵馷鮹鶻뒽", a_));
				IL_9A8:
				throw new global::System.Exception(global::AcpASKLib.SystemKeyLoadedEventArgs.b("穯筱味ふ㥷㍹ほ㭽쑿ꊁ얃튅ꢇ캉춋\uda8d톏벑꒓뚕떗몙캛\udb9d袧ﮭﺯ钳﮵ﾽ钿臁賃쓍", a_));
				IL_EB:
				num18 = 0;
				num19 = 0;
				collection = null;
				num = (short)1836384294;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x0001FE20 File Offset: 0x0001E020
		internal string a(global::IBtnWrapperLib.IIBtnWrapper A_0, int A_1)
		{
			short num = (short)988079096;
			short num2 = num;
			num = (short)343991288;
			string result;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1096548352;
				if (num != 0)
				{
				}
				num = (short)1500381185;
				if (num != 0)
				{
				}
				num = (short)445120512;
				short num3 = num;
				result = null;
				byte[] a_ = null;
				short num4 = 400;
				try
				{
					num = (short)623312897;
					int num5 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num5)
						{
						case 0:
							goto IL_143;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_DF;
							}
							continue;
						case 2:
							this.a(A_0, A_1, ref a_, out num4);
							result = this.a(a_);
							num = (short)129236996;
							num5 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							goto IL_15B;
						case 4:
							goto IL_143;
						}
						IL_DF:
						if (A_1 <= 3)
						{
							num = (short)139132930;
							num5 = (int)((global::System.IntPtr)num);
							continue;
						}
						result = this.b(A_0);
						num = (short)1851195392;
						num5 = (int)((global::System.IntPtr)num);
						continue;
						IL_143:
						num = (short)1740242947;
						num5 = (int)((global::System.IntPtr)num);
					}
					IL_15B:;
				}
				catch (global::System.Exception ex)
				{
					throw ex;
				}
				break;
			}
			}
			return result;
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x0001FF9C File Offset: 0x0001E19C
		private string a(byte[] A_0)
		{
			int a_ = 6;
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
				switch (num)
				{
				case 0:
					goto IL_148;
				case 1:
				{
					num2 = (short)62652416;
					short num3 = num2;
					goto IL_66;
				}
				case 2:
					if (A_0 != null)
					{
						num2 = (short)526450691;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return text;
				case 3:
				{
					int num4 = 0;
					num2 = (short)1941045249;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 4:
				{
					int num4;
					if (num4 >= 8)
					{
						num2 = (short)1334050821;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					text += string.Format(global::AcpASKLib.SystemKeyLoadedEventArgs.b("ᡢ啤嵦ᅨ奪ၬ", a_), A_0[num4]);
					num4++;
					num2 = (short)1866091752;
					short num5 = num2;
					num2 = (short)1772309736;
					switch ((num5 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_148;
					default:
						num2 = (short)1095041024;
						if (num2 != 0)
						{
						}
						num2 = (short)958660609;
						if (num2 != 0)
						{
						}
						num2 = (short)1492647936;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 5:
					return text;
				}
				goto IL_31;
				IL_66:
				num2 = (short)2130706436;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_148:
				goto IL_66;
			}
			return text;
			IL_31:
			text = null;
			num2 = (short)601554946;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00020140 File Offset: 0x0001E340
		private global::AcpASKLib.HardwareKeyFamily c(global::IBtnWrapperLib.IIBtnWrapper A_0)
		{
			int a_ = 2;
			short num = (short)919018428;
			short num2 = num;
			num = (short)1254431676;
			global::AcpASKLib.HardwareKeyFamily result;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1020264448;
				if (num != 0)
				{
				}
				num = (short)869072897;
				if (num != 0)
				{
				}
				num = (short)558891008;
				short num3 = num;
				result = global::AcpASKLib.HardwareKeyFamily.Unknown;
				try
				{
					result = (global::AcpASKLib.HardwareKeyFamily)A_0.GetROMSerialNum()[0];
				}
				catch (global::System.Exception innerException)
				{
					throw new global::System.Exception(global::AcpASKLib.SystemKeyLoadedEventArgs.b("ᡞѠᝢ⍤٦ѨɪŬ᙮兰ᕲᑴṶᕸṺ᥼幾", a_), innerException);
				}
				break;
			}
			}
			return result;
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00020228 File Offset: 0x0001E428
		private string b(global::IBtnWrapperLib.IIBtnWrapper A_0)
		{
			int a_ = 5;
			short num = (short)1917059072;
			short num2 = num;
			num = (short)1321516842;
			short num3 = num;
			num = (short)1958395690;
			string text;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1118175232;
				if (num != 0)
				{
				}
				num = (short)644939777;
				if (num != 0)
				{
				}
				num = (short)1244594176;
				int num4 = (int)num;
				switch (num4)
				{
				default:
					text = null;
					try
					{
						switch (0)
						{
						case 0:
							goto IL_EC;
						}
						int num5;
						byte[] romserialNum;
						for (;;)
						{
							IL_D1:
							switch (num4)
							{
							case 0:
								num = (short)51052547;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								goto IL_149;
							case 2:
								goto IL_149;
							case 3:
								goto IL_19A;
							case 4:
								if (num5 < 0)
								{
									num = (short)1142554624;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								text += string.Format(global::AcpASKLib.SystemKeyLoadedEventArgs.b("ᥡ呣履ၧ塩ᅫ", a_), romserialNum[num5]);
								num5--;
								num = (short)2115436546;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_EC;
							IL_149:
							num = (short)2055012356;
							num4 = (int)((global::System.IntPtr)num);
						}
						IL_19A:
						break;
						IL_EC:
						romserialNum = A_0.GetROMSerialNum();
						num5 = 7;
						num = (short)1394868225;
						num4 = (int)((global::System.IntPtr)num);
						goto IL_D1;
					}
					catch (global::System.Exception innerException)
					{
						throw new global::System.Exception(global::AcpASKLib.SystemKeyLoadedEventArgs.b("╡ţብ㩧թū㵭㹯剱ታ᝵ᅷᙹ᥻᩽ꅿ", a_), innerException);
					}
					break;
				}
				break;
			}
			}
			return text;
		}

		// Token: 0x060000FB RID: 251 RVA: 0x000203F8 File Offset: 0x0001E5F8
		private bool a(global::IBtnWrapperLib.IIBtnWrapper A_0, int A_1, ref byte[] A_2, out short A_3)
		{
			int a_ = 2;
			short num = (short)1548550144;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				bool result = true;
				A_3 = 0;
				try
				{
					switch (0)
					{
					case 0:
						goto IL_6C;
					}
					string fileName;
					for (;;)
					{
						IL_39:
						switch (num2)
						{
						case 0:
							fileName = null;
							result = false;
							num = (short)786956296;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							num = (short)875298816;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_240;
						case 3:
							goto IL_240;
						case 4:
							switch (A_1)
							{
							case 0:
								fileName = global::AcpASKLib.SystemKeyLoadedEventArgs.b("቞⁠ぢ⹤䥦奨", a_);
								num = (short)472121351;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								fileName = global::AcpASKLib.SystemKeyLoadedEventArgs.b("ᑞ①㩢㙤䥦奨", a_);
								num = (short)713424899;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								fileName = global::AcpASKLib.SystemKeyLoadedEventArgs.b("᭞⁠㝢⑤䥦奨", a_);
								num = (short)741277706;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
								break;
							case 4:
								fileName = global::AcpASKLib.SystemKeyLoadedEventArgs.b("ၞ㕠≢㕤䥦奨", a_);
								num = (short)2104360962;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 5:
							{
								num = (short)616731732;
								short num3 = num;
								num = (short)2079364180;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									num = (short)1707802624;
									if (num != 0)
									{
									}
									fileName = global::AcpASKLib.SystemKeyLoadedEventArgs.b("቞⡠ぢ㝤䥦奨", a_);
									num = (short)2142109705;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							default:
								num = (short)1801125889;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							fileName = global::AcpASKLib.SystemKeyLoadedEventArgs.b("቞㉠㝢㝤䥦奨", a_);
							num = (short)1341718534;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							goto IL_2AE;
						case 6:
							goto IL_240;
						case 7:
							goto IL_240;
						case 8:
							goto IL_240;
						case 9:
							goto IL_240;
						case 10:
							goto IL_240;
						}
						goto IL_6C;
						IL_240:
						short num4 = 400;
						A_0.GetMaxFileSpace(fileName, out A_3);
						A_0.GetFileSize(fileName, ref num4);
						byte[] sourceArray = new byte[(int)num4];
						A_3 = 0;
						A_0.ReadFile(fileName, ref A_3, out sourceArray);
						byte[] array = new byte[(int)A_3];
						global::System.Array.Copy(sourceArray, 0, array, 0, array.Length);
						new global::AcpCryptoLib.AcpIBtnEncyptDecrpt().Decrypt(array, out A_2);
						num = (short)2032992261;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_2AE:
					goto IL_2C4;
					IL_6C:
					fileName = null;
					num = (short)2128019460;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_39;
				}
				catch (global::IBtnWrapperLib.TMEXException ex)
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
				IL_2C4:
				num = (short)99024896;
				short num5 = num;
				num = (short)1269891073;
				if (num != 0)
				{
				}
				return result;
			}
			}
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00020750 File Offset: 0x0001E950
		internal bool a(global::IBtnWrapperLib.IIBtnWrapper A_0, string A_1, bool A_2)
		{
			short num = (short)898826241;
			if (num != 0)
			{
			}
			num = (short)237305856;
			short num2 = num;
			bool result = false;
			goto IL_54;
			try
			{
				for (;;)
				{
					IL_54:
					num = (short)794361857;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							A_0.CloseButton();
							num = (short)86179844;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_96;
							}
							continue;
						case 2:
						{
							if (A_2)
							{
								goto IL_17A;
							}
							num = (short)896111934;
							short num4 = num;
							num = (short)1069847870;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_54;
							default:
								num = (short)657129472;
								if (num != 0)
								{
								}
								num = (short)2040463360;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 3:
							goto IL_EF;
						case 4:
							goto IL_17A;
						case 5:
						{
							int options = 0;
							A_0.OpenNonMotoBtn(options);
							num = (short)1928003587;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 6:
							goto IL_192;
						}
						IL_96:
						if (!A_2)
						{
							num = (short)209977349;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_EF:
						result = A_0.DoesFileExist(A_1);
						num = (short)289013762;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_17A:
						num = (short)173277190;
						num3 = (int)((global::System.IntPtr)num);
					}
				}
				IL_192:;
			}
			catch (global::System.Exception ex)
			{
				throw ex;
			}
			finally
			{
				num = (short)1864630273;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						A_0.CloseButton();
						num = (short)173735938;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_1C6;
						}
						continue;
					case 2:
						goto IL_1FA;
					}
					IL_1C6:
					if (A_2)
					{
						break;
					}
					num = (short)671154176;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_1FA:;
			}
			return result;
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00020990 File Offset: 0x0001EB90
		private bool b(global::IBtnWrapperLib.IIBtnWrapper A_0, ref bool A_1)
		{
			int a_ = 18;
			short num = (short)1877086105;
			short num2 = num;
			num = (short)1133186969;
			switch (num2 == num)
			{
			}
			num = (short)2039349249;
			if (num != 0)
			{
			}
			num = (short)1777336320;
			short num3 = num;
			num = (short)1638662144;
			if (num != 0)
			{
			}
			return this.a(A_0, global::AcpASKLib.SystemKeyLoadedEventArgs.b("⑮㑰⩲♴奶䥸", a_), A_1);
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00020A5C File Offset: 0x0001EC5C
		private bool a(global::IBtnWrapperLib.IIBtnWrapper A_0, ref bool A_1)
		{
			int a_ = 9;
			short num = (short)853903310;
			short num2 = num;
			num = (short)1955563470;
			switch (num2 == num)
			{
			}
			num = (short)265355265;
			if (num != 0)
			{
			}
			num = (short)610729984;
			short num3 = num;
			num = (short)1018429440;
			if (num != 0)
			{
			}
			return this.a(A_0, global::AcpASKLib.SystemKeyLoadedEventArgs.b("⭥㭧㹩㹫䁭䁯", a_), A_1);
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00020B28 File Offset: 0x0001ED28
		public bool IsFormated(global::IBtnWrapperLib.IIBtnWrapper spIBtn, ref bool pbOpen)
		{
			int a_ = 18;
			short num = (short)1529469824;
			short num2 = num;
			num = (short)1294195584;
			switch (num2 == num)
			{
			}
			num = (short)807927809;
			if (num != 0)
			{
			}
			num = (short)774307840;
			short num3 = num;
			num = (short)1692467200;
			if (num != 0)
			{
			}
			return this.a(spIBtn, global::AcpASKLib.SystemKeyLoadedEventArgs.b("≮ば⁲㹴奶䥸", a_), pbOpen);
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00020BF4 File Offset: 0x0001EDF4
		private bool a(global::IBtnWrapperLib.IIBtnWrapper A_0, int A_1, string A_2)
		{
			int a_ = 7;
			short num = (short)2072641536;
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
				bool result;
				string text2;
				for (;;)
				{
					IL_31:
					string text;
					switch (num2)
					{
					case 0:
						goto IL_30B;
					case 1:
					{
						num = (short)1237518126;
						short num3 = num;
						num = (short)690685742;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1E6;
						default:
							num = (short)1517617152;
							if (num != 0)
							{
							}
							result = false;
							global::System.Diagnostics.Trace.WriteLine(string.Format(global::AcpASKLib.SystemKeyLoadedEventArgs.b("湣潥慧䁩䙫䑭婯塱平屵塷Ź䱻ͽꁿ꺍ﺏ煉ﶗ벛瞧쾟잡힣蚥욧얩\ud8ab躭\uddaf펱삳햵킷骹\ud8bb\udbbd뚿ꯁꟃꏅ막꧋볍맏돑룓뛗꿙뇛볝藟郡쫣웥싧샩웫쓭\udaef\ud8f1\udef3\udcf5틷", a_), text));
							num = (short)801636363;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
					{
						string fileName = text;
						short num4 = 400;
						short num5 = 400;
						A_0.GetMaxFileSpace(fileName, out num4);
						A_0.GetFileSize(fileName, ref num5);
						num = (short)1798111237;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						goto IL_2CC;
					case 4:
						if (A_2 == null)
						{
							num = (short)1552351238;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						text2 = A_2;
						num = (short)82182147;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_1E6;
					case 6:
						text2 = this.a(A_0, -1);
						num = (short)2010972168;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						if (this.a(A_0, text, true))
						{
							num = (short)143982593;
							if (num != 0)
							{
							}
							num = (short)869728258;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						result = false;
						global::System.Diagnostics.Trace.WriteLine(global::AcpASKLib.SystemKeyLoadedEventArgs.b("≣ཥѧཀྵ䱫੭Ὧ᝱ݳ噵ᙷᕹࡻ幽嬨ﲇꮉ", a_));
						num = (short)1886388233;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						goto IL_2CC;
					case 9:
						goto IL_28E;
					case 10:
						goto IL_181;
					case 11:
						goto IL_DA;
					case 12:
						if (text == null)
						{
							num = (short)1386610688;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1335623687;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_6C;
					IL_1E6:
					if (this.a(A_0, A_1) != text2)
					{
						num = (short)1162608641;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					result = true;
					num = (short)906035210;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2CC:
					text = this.a(A_1);
					num = (short)2143748108;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_DA:
				IL_181:
				IL_28E:
				return result;
				IL_30B:
				num = (short)1675165696;
				short num6 = num;
				throw new global::System.Exception(global::AcpASKLib.SystemKeyLoadedEventArgs.b("ⵣ⡥㱧⽩㹫⁭ㅯ㹱味♵⩷㕹㭻ⱽ셿쾁ꒃ쎅\uda87\ud889쎋\udc8d낏뎑떓랕", a_));
				IL_6C:
				result = false;
				text2 = null;
				num = (short)547749892;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00020F10 File Offset: 0x0001F110
		private bool a(global::IBtnWrapperLib.IIBtnWrapper A_0)
		{
			short num = (short)706222857;
			short num2 = num;
			num = (short)1519459081;
			switch (num2 == num)
			{
			}
			num = (short)2010447873;
			if (num != 0)
			{
			}
			num = (short)892534784;
			short num3 = num;
			num = (short)1632436224;
			if (num != 0)
			{
			}
			return this.a(A_0, 1, null);
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00020FC4 File Offset: 0x0001F1C4
		private string a(int A_0)
		{
			int a_ = 14;
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
					result = null;
					num2 = (short)1263796229;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					goto IL_108;
				case 2:
					return result;
				case 3:
					switch (A_0)
					{
					case 0:
						result = global::AcpASKLib.SystemKeyLoadedEventArgs.b("♪ⱬ㱮㩰嵲䕴", a_);
						num2 = (short)1429012481;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 1:
						result = global::AcpASKLib.SystemKeyLoadedEventArgs.b("⁪⡬㙮≰嵲䕴", a_);
						num2 = (short)2047803399;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 2:
						result = global::AcpASKLib.SystemKeyLoadedEventArgs.b("⽪ⱬ㭮ば嵲䕴", a_);
						num2 = (short)656998409;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 3:
						result = global::AcpASKLib.SystemKeyLoadedEventArgs.b("♪㹬㭮⍰嵲䕴", a_);
						num2 = (short)1206648834;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 4:
						num2 = (short)641400833;
						if (num2 != 0)
						{
						}
						result = global::AcpASKLib.SystemKeyLoadedEventArgs.b("⑪㥬⹮ⅰ嵲䕴", a_);
						num2 = (short)571277316;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 5:
						result = global::AcpASKLib.SystemKeyLoadedEventArgs.b("♪⑬㱮⍰嵲䕴", a_);
						num2 = (short)792133638;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_75;
				case 4:
					goto IL_DC;
				case 5:
					return result;
				case 6:
					return result;
				case 7:
				{
					num2 = (short)1942829867;
					short num3 = num2;
					num2 = (short)1876310827;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_75;
					default:
						goto IL_193;
					}
					break;
				}
				case 8:
					num2 = (short)1083506688;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					return result;
				}
				goto IL_41;
				IL_75:
				num2 = (short)68288520;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_DC:
			return result;
			IL_108:
			num2 = (short)1690107904;
			short num4 = num2;
			return result;
			IL_193:
			num2 = (short)1298792448;
			if (num2 != 0)
			{
			}
			return result;
			IL_41:
			result = null;
			num2 = (short)1442906115;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00021230 File Offset: 0x0001F430
		private bool a(global::IBtnWrapperLib.IIBtnWrapper A_0, ref string A_1)
		{
			short num = (short)355212082;
			short num2 = num;
			num = (short)801250098;
			bool result;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1316290560;
				if (num != 0)
				{
				}
				num = (short)580911104;
				short num3 = num;
				result = false;
				try
				{
					switch (0)
					{
					case 0:
						goto IL_A7;
					}
					int num4;
					int num5;
					int count;
					for (;;)
					{
						IL_81:
						switch (num4)
						{
						case 0:
							result = true;
							num = (short)2045181956;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							num = (short)989855745;
							if (num != 0)
							{
							}
							goto IL_145;
						case 2:
							goto IL_145;
						case 3:
							goto IL_1B4;
						case 4:
							goto IL_1B4;
						case 5:
							if (num5 >= count)
							{
								num = (short)1044774915;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1632763910;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							if (A_1 == (string)global::AcpASKLib.KeyRecordSet.ExpiredSerialNumList[num5])
							{
								num = (short)1814888448;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							num5++;
							num = (short)2039480322;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
							goto IL_1CC;
						}
						goto IL_A7;
						IL_145:
						num = (short)2047082501;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_1B4:
						num = (short)578093063;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_1CC:
					break;
					IL_A7:
					A_1 = this.b(A_0);
					count = global::AcpASKLib.KeyRecordSet.ExpiredSerialNumList.Count;
					num5 = 0;
					num = (short)1993211905;
					num4 = (int)((global::System.IntPtr)num);
					goto IL_81;
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

		// Token: 0x06000104 RID: 260 RVA: 0x0002142C File Offset: 0x0001F62C
		public bool HighWaterMarkSupported(ref global::AcpASKLib.HardwareKey hKey, ref global::IBtnWrapperLib.MultiBtnWrapper btnWrapper)
		{
			int a_ = 16;
			switch (0)
			{
			case 0:
				goto IL_45;
			}
			int num;
			bool result;
			short num2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					result = true;
					num2 = (short)1349844999;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					num2 = (short)1641611270;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if (!hKey.IsMaster)
					{
						num2 = (short)714048554;
						short num3 = num2;
						num2 = (short)560432170;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1D0;
						case 1:
							break;
						default:
						{
							num2 = (short)1427767296;
							short num4 = num2;
							break;
						}
						}
						num2 = (short)62521344;
						if (num2 != 0)
						{
						}
						num2 = (short)113442824;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 3:
					goto IL_206;
				case 4:
					if (hKey.KeyFamily != global::AcpASKLib.HardwareKeyFamily.DS1963)
					{
						num2 = (short)56950785;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_206;
				case 5:
					num2 = (short)352976898;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					if (hKey.KeyFamily == global::AcpASKLib.HardwareKeyFamily.DS1996)
					{
						goto IL_1D0;
					}
					return result;
				case 7:
					return result;
				case 8:
					num2 = (short)1732771849;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					if (!btnWrapper.DoesFileExist(global::AcpASKLib.SystemKeyLoadedEventArgs.b("⁬♮≰ⅲ孴䝶", a_)))
					{
						num2 = (short)624558080;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 10:
					if (hKey.Version > 4)
					{
						num2 = (short)131465221;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				}
				goto IL_45;
				IL_1D0:
				num2 = (short)998047747;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_206:
				num2 = (short)311558154;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_45:
			result = false;
			num2 = (short)1035862017;
			if (num2 != 0)
			{
			}
			num2 = (short)424542212;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00021680 File Offset: 0x0001F880
		public bool HighWaterMarkValidation(global::System.DateTime keyDate)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			short num2;
			bool result;
			global::System.DateTime value;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					num2 = (short)49872897;
					if (num2 != 0)
					{
					}
					result = false;
					num2 = (short)1754202114;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
				{
					num2 = (short)750321664;
					short num3 = num2;
					if (keyDate.CompareTo(value) > 0)
					{
						num2 = (short)2118189056;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				}
				case 2:
					return result;
				}
				goto IL_1C;
			}
			return result;
			IL_1C:
			result = true;
			value = global::System.DateTime.Now.ToUniversalTime();
			value = value.AddHours(4.0);
			num2 = (short)1558759778;
			short num4 = num2;
			num2 = (short)727501154;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_0A;
			default:
			{
				num2 = (short)605880320;
				if (num2 != 0)
				{
				}
				num2 = (short)1506148353;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x06000106 RID: 262 RVA: 0x000217C0 File Offset: 0x0001F9C0
		public void EraseData(ref global::IBtnWrapperLib.MultiBtnWrapper btnWrapper)
		{
			int a_ = 7;
			short num = (short)57278464;
			short num2 = num;
			num = (short)217097269;
			short num3 = num;
			num = (short)73245749;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)632946689;
				if (num != 0)
				{
				}
				num = (short)1228472320;
				if (num != 0)
				{
				}
				string fileName = string.Empty;
				try
				{
					switch (0)
					{
					case 0:
						goto IL_F0;
					}
					int num4;
					for (;;)
					{
						IL_B6:
						switch (num4)
						{
						case 0:
							goto IL_2CB;
						case 1:
							if (btnWrapper.DoesFileExist(fileName))
							{
								num = (short)156368905;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_188;
						case 2:
							if (btnWrapper.DoesFileExist(fileName))
							{
								num = (short)12517379;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2B2;
						case 3:
							btnWrapper.DeleteFile(fileName);
							num = (short)772800517;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							if (btnWrapper.DoesFileExist(fileName))
							{
								num = (short)936378374;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_138;
						case 5:
							goto IL_2B2;
						case 6:
							btnWrapper.DeleteFile(fileName);
							num = (short)56098826;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
							btnWrapper.DeleteFile(fileName);
							num = (short)1834090508;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
							goto IL_188;
						case 9:
							btnWrapper.DeleteFile(fileName);
							num = (short)802357256;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 10:
							goto IL_138;
						case 11:
							if (btnWrapper.DoesFileExist(fileName))
							{
								num = (short)1007222791;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_240;
						case 12:
							goto IL_240;
						}
						goto IL_F0;
						IL_138:
						fileName = global::AcpASKLib.SystemKeyLoadedEventArgs.b("⁣❥㱧⭩䉫幭", a_);
						num = (short)1168637963;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_188:
						fileName = global::AcpASKLib.SystemKeyLoadedEventArgs.b("⥣❥㭧Ⅹ䉫幭", a_);
						num = (short)125304834;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_240:
						fileName = global::AcpASKLib.SystemKeyLoadedEventArgs.b("⭣㉥⥧㩩䉫幭", a_);
						num = (short)1323302913;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_2B2:
						num = (short)1725693952;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_2CB:
					break;
					IL_F0:
					fileName = global::AcpASKLib.SystemKeyLoadedEventArgs.b("⽣⍥ㅧ㥩䉫幭", a_);
					num = (short)90636292;
					num4 = (int)((global::System.IntPtr)num);
					goto IL_B6;
				}
				catch (global::System.Exception)
				{
				}
				break;
			}
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000107 RID: 263 RVA: 0x00021ABC File Offset: 0x0001FCBC
		// (set) Token: 0x06000108 RID: 264 RVA: 0x00021B7C File Offset: 0x0001FD7C
		internal global::System.DateTime FinalExpirationDate
		{
			get
			{
				short num = (short)1397258945;
				short num2 = num;
				num = (short)1323793089;
				switch (num2 == num)
				{
				}
				num = (short)1652752385;
				if (num != 0)
				{
				}
				num = (short)2066743296;
				if (num != 0)
				{
				}
				num = (short)1403584512;
				short num3 = num;
				return global::AcpASKLib.Constants.ReferenceDate.AddDays((double)this.p);
			}
			set
			{
				short num = (short)1743132526;
				short num2 = num;
				num = (short)1091966830;
				switch (num2 == num)
				{
				}
				num = (short)619773953;
				if (num != 0)
				{
				}
				num = (short)1474953216;
				if (num != 0)
				{
				}
				num = (short)1319108608;
				short num3 = num;
				global::System.DateTime dateTime = value;
				this.p = (short)dateTime.Subtract(global::AcpASKLib.Constants.ReferenceDate).Days;
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000109 RID: 265 RVA: 0x00021C48 File Offset: 0x0001FE48
		internal short DaysToFinalExpiration
		{
			get
			{
				short num = (short)25279773;
				short num2 = num;
				num = (short)733855005;
				switch (num2 == num)
				{
				}
				num = (short)2095054849;
				if (num != 0)
				{
				}
				num = (short)1261436928;
				if (num != 0)
				{
				}
				num = (short)2069037056;
				short num3 = num;
				return this.p;
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x0600010A RID: 266 RVA: 0x00021CF8 File Offset: 0x0001FEF8
		// (set) Token: 0x0600010B RID: 267 RVA: 0x00021DA8 File Offset: 0x0001FFA8
		public global::AcpASKLib.KeyExpirationType ExpirationType
		{
			get
			{
				short num = (short)63418398;
				short num2 = num;
				num = (short)252489758;
				switch (num2 == num)
				{
				}
				num = (short)1648427009;
				if (num != 0)
				{
				}
				num = (short)1715601408;
				if (num != 0)
				{
				}
				num = (short)249430016;
				short num3 = num;
				return this.o;
			}
			set
			{
				short num = (short)762213695;
				short num2 = num;
				num = (short)386954559;
				switch (num2 == num)
				{
				}
				num = (short)1627979777;
				if (num != 0)
				{
				}
				num = (short)170524672;
				if (num != 0)
				{
				}
				num = (short)95092736;
				short num3 = num;
				this.o = value;
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x0600010C RID: 268 RVA: 0x00021E58 File Offset: 0x00020058
		// (set) Token: 0x0600010D RID: 269 RVA: 0x00021F08 File Offset: 0x00020108
		public global::System.DateTime ExpirationDate
		{
			get
			{
				short num = (short)1417193798;
				short num2 = num;
				num = (short)1409591622;
				switch (num2 == num)
				{
				}
				num = (short)1610416128;
				if (num != 0)
				{
				}
				num = (short)1046413313;
				if (num != 0)
				{
				}
				num = (short)295960576;
				short num3 = num;
				return this.r;
			}
			set
			{
				short num = (short)1463864216;
				short num2 = num;
				num = (short)1444334488;
				switch (num2 == num)
				{
				}
				num = (short)2037514241;
				if (num != 0)
				{
				}
				num = (short)2109669376;
				if (num != 0)
				{
				}
				num = (short)2082013184;
				short num3 = num;
				this.r = value;
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x0600010E RID: 270 RVA: 0x00021FB4 File Offset: 0x000201B4
		internal string ExpirationDateString
		{
			get
			{
				short num;
				while (!this.i)
				{
					num = (short)292943917;
					short num2 = num;
					num = (short)1370814509;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)87490560;
						if (num != 0)
						{
						}
						num = (short)826867712;
						short num3 = num;
						return null;
					}
					}
				}
				num = (short)1461714945;
				if (num != 0)
				{
				}
				return this.r.ToShortDateString();
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x0600010F RID: 271 RVA: 0x00022078 File Offset: 0x00020278
		// (set) Token: 0x06000110 RID: 272 RVA: 0x00022128 File Offset: 0x00020328
		public short DaysToExpiration
		{
			get
			{
				short num = (short)1141253816;
				short num2 = num;
				num = (short)1783178936;
				switch (num2 == num)
				{
				}
				num = (short)1733296128;
				if (num != 0)
				{
				}
				num = (short)1562771457;
				if (num != 0)
				{
				}
				num = (short)1908801536;
				short num3 = num;
				return this.s;
			}
			set
			{
				short num = (short)1171851239;
				short num2 = num;
				num = (short)1431635943;
				switch (num2 == num)
				{
				}
				num = (short)1169096705;
				if (num != 0)
				{
				}
				num = (short)1607991296;
				if (num != 0)
				{
				}
				num = (short)668925952;
				short num3 = num;
				this.s = value;
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000111 RID: 273 RVA: 0x000221D8 File Offset: 0x000203D8
		// (set) Token: 0x06000112 RID: 274 RVA: 0x00022294 File Offset: 0x00020494
		internal short ProgrammingCount
		{
			get
			{
				while (!this.i)
				{
					short num = (short)56552407;
					short num2 = num;
					num = (short)11725783;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)879624193;
						if (num != 0)
						{
						}
						num = (short)1358561280;
						if (num != 0)
						{
						}
						num = (short)500563968;
						short num3 = num;
						return 0;
					}
					}
				}
				return this.t;
			}
			set
			{
				short num = (short)1548323112;
				short num2 = num;
				num = (short)1613465896;
				switch (num2 == num)
				{
				}
				num = (short)1048903681;
				if (num != 0)
				{
				}
				num = (short)1945894912;
				if (num != 0)
				{
				}
				num = (short)750190592;
				short num3 = num;
				this.t = value;
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000113 RID: 275 RVA: 0x00022344 File Offset: 0x00020544
		// (set) Token: 0x06000114 RID: 276 RVA: 0x000223F0 File Offset: 0x000205F0
		public global::System.DateTime LastDateProgrammed
		{
			get
			{
				short num = (short)1247739905;
				if (num != 0)
				{
				}
				num = (short)578302282;
				short num2 = num;
				num = (short)410726730;
				switch (num2 == num)
				{
				}
				num = (short)315555840;
				if (num != 0)
				{
				}
				num = (short)712966144;
				short num3 = num;
				return this.u;
			}
			set
			{
				short num = (short)1595604993;
				if (num != 0)
				{
				}
				num = (short)1136289663;
				short num2 = num;
				num = (short)322332543;
				switch (num2 == num)
				{
				}
				num = (short)1941569536;
				if (num != 0)
				{
				}
				num = (short)1695088640;
				short num3 = num;
				this.u = value;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000115 RID: 277 RVA: 0x000224A0 File Offset: 0x000206A0
		internal bool IsExpired
		{
			get
			{
				short num = (short)601901994;
				short num2 = num;
				num = (short)1311722410;
				switch (num2 == num)
				{
				}
				num = (short)936968192;
				if (num != 0)
				{
				}
				num = (short)1248788481;
				if (num != 0)
				{
				}
				num = (short)1880031232;
				short num3 = num;
				return this.q;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000116 RID: 278 RVA: 0x00022550 File Offset: 0x00020750
		internal byte[] SerialNumBytes
		{
			get
			{
				short num = (short)354615297;
				if (num != 0)
				{
				}
				num = (short)1838525470;
				short num2 = num;
				num = (short)168864798;
				switch (num2 == num)
				{
				}
				num = (short)1961099264;
				if (num != 0)
				{
				}
				num = (short)1352925184;
				short num3 = num;
				return this.c;
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000117 RID: 279 RVA: 0x00022600 File Offset: 0x00020800
		public string SerialNumber
		{
			get
			{
				short num = (short)973349622;
				short num2 = num;
				num = (short)1782588150;
				switch (num2 == num)
				{
				}
				num = (short)2007040001;
				if (num != 0)
				{
				}
				num = (short)1744830464;
				if (num != 0)
				{
				}
				num = (short)685768704;
				short num3 = num;
				return this.b;
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000118 RID: 280 RVA: 0x000226B0 File Offset: 0x000208B0
		public global::AcpASKLib.HardwareKeyFamily KeyFamily
		{
			get
			{
				short num = (short)576158903;
				short num2 = num;
				num = (short)12811447;
				switch (num2 == num)
				{
				}
				num = (short)1487405057;
				if (num != 0)
				{
				}
				num = (short)2038431744;
				if (num != 0)
				{
				}
				num = (short)591790080;
				short num3 = num;
				return this.f;
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000119 RID: 281 RVA: 0x0002275C File Offset: 0x0002095C
		internal string SerialNumberAndFamily
		{
			get
			{
				int a_ = 13;
				short num = (short)698561004;
				short num2 = num;
				num = (short)1200763372;
				switch (num2 == num)
				{
				}
				num = (short)700514304;
				if (num != 0)
				{
				}
				num = (short)554565633;
				if (num != 0)
				{
				}
				num = (short)1467744256;
				short num3 = num;
				return string.Format(global::AcpASKLib.SystemKeyLoadedEventArgs.b("ᅩ屫፭偯剱屳൵䥷ݹ啻", a_), this.b, this.f);
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x0600011A RID: 282 RVA: 0x00022834 File Offset: 0x00020A34
		public bool IsMaster
		{
			get
			{
				short num = (short)1332426973;
				short num2 = num;
				num = (short)1832859869;
				switch (num2 == num)
				{
				}
				num = (short)1312096257;
				if (num != 0)
				{
				}
				num = (short)219545600;
				if (num != 0)
				{
				}
				num = (short)1794637824;
				short num3 = num;
				return this.g;
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x0600011B RID: 283 RVA: 0x000228E0 File Offset: 0x00020AE0
		public bool IsAdvancedSystemKey
		{
			get
			{
				short num = (short)427562970;
				short num2 = num;
				num = (short)1167267802;
				switch (num2 == num)
				{
				}
				num = (short)1789329409;
				if (num != 0)
				{
				}
				num = (short)1400963072;
				if (num != 0)
				{
				}
				num = (short)1498742784;
				short num3 = num;
				return this.h;
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x0600011C RID: 284 RVA: 0x00022990 File Offset: 0x00020B90
		internal bool HasOTAPEnabledSystem
		{
			get
			{
				short num = (short)1563623425;
				if (num != 0)
				{
				}
				num = (short)863309694;
				short num2 = num;
				num = (short)407834494;
				bool result;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1562705920;
					if (num != 0)
					{
					}
					result = false;
					global::System.Collections.Generic.IEnumerator<global::AcpASKLib.IKeyDataRecord> enumerator = this.d.GetEnumerator();
					try
					{
						num = (short)1337262084;
						int num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
								num = (short)698941443;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								result = true;
								num = (short)481624070;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								if (((global::AcpASKLib.KeyDataRecord)enumerator.Current).OTAPState)
								{
									num = (short)406454273;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							case 3:
								goto IL_16C;
							case 4:
								switch (0)
								{
								case 0:
									goto IL_C1;
								}
								continue;
							case 5:
								if (!enumerator.MoveNext())
								{
									num = (short)1494482944;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)1835925506;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 6:
								goto IL_150;
							}
							IL_FF:
							num = (short)858193925;
							num3 = (int)((global::System.IntPtr)num);
							continue;
							IL_C1:
							goto IL_FF;
						}
						IL_150:
						IL_16C:;
					}
					finally
					{
						num = (short)1669922816;
						int num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_19E;
								}
								continue;
							case 1:
								enumerator.Dispose();
								num = (short)1151926274;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_1D2;
							}
							IL_19E:
							if (enumerator == null)
							{
								break;
							}
							num = (short)853475329;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_1D2:;
					}
					break;
				}
				}
				num = (short)141819904;
				short num4 = num;
				return result;
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x0600011D RID: 285 RVA: 0x00022BAC File Offset: 0x00020DAC
		// (set) Token: 0x0600011E RID: 286 RVA: 0x00022C5C File Offset: 0x00020E5C
		internal bool IsPaswordProtected
		{
			get
			{
				short num = (short)1155227632;
				short num2 = num;
				num = (short)781017072;
				switch (num2 == num)
				{
				}
				num = (short)1855848448;
				if (num != 0)
				{
				}
				num = (short)1421803521;
				if (num != 0)
				{
				}
				num = (short)768868352;
				short num3 = num;
				return this.l;
			}
			set
			{
				short num = (short)1588894664;
				short num2 = num;
				num = (short)239377352;
				switch (num2 == num)
				{
				}
				num = (short)1945567233;
				if (num != 0)
				{
				}
				num = (short)1408892928;
				if (num != 0)
				{
				}
				num = (short)303497216;
				short num3 = num;
				this.l = value;
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x0600011F RID: 287 RVA: 0x00022D0C File Offset: 0x00020F0C
		internal string Password
		{
			get
			{
				short num = (short)1364096646;
				short num2 = num;
				num = (short)817919622;
				switch (num2 == num)
				{
				}
				num = (short)1442840577;
				if (num != 0)
				{
				}
				num = (short)475332608;
				if (num != 0)
				{
				}
				num = (short)1073414144;
				short num3 = num;
				return this.m;
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000120 RID: 288 RVA: 0x00022DBC File Offset: 0x00020FBC
		public bool IsPasswordUpgradeNeeded
		{
			get
			{
				short num = (short)1892930884;
				short num2 = num;
				num = (short)1737479492;
				switch (num2 == num)
				{
				}
				num = (short)1554776065;
				if (num != 0)
				{
				}
				num = (short)1469710336;
				if (num != 0)
				{
				}
				num = (short)925827072;
				short num3 = num;
				return this.k;
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000121 RID: 289 RVA: 0x00022E68 File Offset: 0x00021068
		internal bool IsValid
		{
			get
			{
				short num = (short)1906897768;
				short num2 = num;
				num = (short)1219294056;
				switch (num2 == num)
				{
				}
				num = (short)852951041;
				if (num != 0)
				{
				}
				num = (short)1354039296;
				if (num != 0)
				{
				}
				num = (short)921436160;
				short num3 = num;
				return this.i;
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000122 RID: 290 RVA: 0x00022F18 File Offset: 0x00021118
		internal global::AcpASKLib.HardwareKeyStatus KeyStatus
		{
			get
			{
				switch (0)
				{
				case 0:
					goto IL_34;
				}
				int num;
				global::AcpASKLib.HardwareKeyStatus result;
				short num2;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
					{
						result = global::AcpASKLib.HardwareKeyStatus.Expired;
						num2 = (short)1577301966;
						short num3 = num2;
						num2 = (short)923318222;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							return result;
						default:
							num2 = (short)2046558208;
							if (num2 != 0)
							{
							}
							num2 = (short)1961951237;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 1:
						num2 = (short)282132484;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 2:
						if (!this.IsValid)
						{
							num2 = (short)1232863233;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					case 3:
						return result;
					case 4:
						if (!this.j)
						{
							num2 = (short)1380450311;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						result = global::AcpASKLib.HardwareKeyStatus.Invalid;
						num2 = (short)684261384;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 5:
						return result;
					case 6:
						if (this.q)
						{
							num2 = (short)1836515328;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)1415053313;
						if (num2 != 0)
						{
						}
						num2 = (short)1247084546;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 7:
						result = global::AcpASKLib.HardwareKeyStatus.Unformatted;
						num2 = (short)1103691779;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 8:
						return result;
					}
					goto IL_34;
				}
				return result;
				IL_34:
				result = global::AcpASKLib.HardwareKeyStatus.Valid;
				num2 = (short)1573388288;
				short num4 = num2;
				num2 = (short)1982070790;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000123 RID: 291 RVA: 0x00023108 File Offset: 0x00021308
		// (set) Token: 0x06000124 RID: 292 RVA: 0x000231B8 File Offset: 0x000213B8
		public global::AcpASKLib.KeyType Type
		{
			get
			{
				short num = (short)839430781;
				short num2 = num;
				num = (short)1462022781;
				switch (num2 == num)
				{
				}
				num = (short)1819082752;
				if (num != 0)
				{
				}
				num = (short)1085538305;
				if (num != 0)
				{
				}
				num = (short)1032978432;
				short num3 = num;
				return this.e;
			}
			set
			{
				short num = (short)1175919941;
				short num2 = num;
				num = (short)545660229;
				switch (num2 == num)
				{
				}
				num = (short)575995905;
				if (num != 0)
				{
				}
				num = (short)2883584;
				if (num != 0)
				{
				}
				num = (short)1699479552;
				short num3 = num;
				this.e = value;
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000125 RID: 293 RVA: 0x0002326C File Offset: 0x0002146C
		// (set) Token: 0x06000126 RID: 294 RVA: 0x00023318 File Offset: 0x00021518
		public global::System.Collections.ObjectModel.ObservableCollection<global::AcpASKLib.IKeyDataRecord> KeyDataList
		{
			get
			{
				short num = (short)1530426691;
				short num2 = num;
				num = (short)504460611;
				switch (num2 == num)
				{
				}
				num = (short)286392321;
				if (num != 0)
				{
				}
				num = (short)963772416;
				if (num != 0)
				{
				}
				num = (short)495452160;
				short num3 = num;
				return this.d;
			}
			set
			{
				short num = (short)1937638558;
				short num2 = num;
				num = (short)1045562526;
				switch (num2 == num)
				{
				}
				num = (short)314507265;
				if (num != 0)
				{
				}
				num = (short)877264896;
				if (num != 0)
				{
				}
				num = (short)1964834816;
				short num3 = num;
				this.d = value;
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000127 RID: 295 RVA: 0x000233C8 File Offset: 0x000215C8
		// (set) Token: 0x06000128 RID: 296 RVA: 0x00023478 File Offset: 0x00021678
		public short Version
		{
			get
			{
				short num = (short)652877814;
				short num2 = num;
				num = (short)732504054;
				switch (num2 == num)
				{
				}
				num = (short)658767873;
				if (num != 0)
				{
				}
				num = (short)2085879808;
				if (num != 0)
				{
				}
				num = (short)1740177408;
				short num3 = num;
				return this.a;
			}
			set
			{
				short num = 29060;
				short num2 = num;
				num = (short)1607233924;
				switch (num2 == num)
				{
				}
				num = (short)1322975232;
				if (num != 0)
				{
				}
				num = (short)1771241473;
				if (num != 0)
				{
				}
				num = (short)117112832;
				short num3 = num;
				this.a = value;
			}
		}

		// Token: 0x04000173 RID: 371
		private short a;

		// Token: 0x04000174 RID: 372
		private string b;

		// Token: 0x04000175 RID: 373
		private byte[] c;

		// Token: 0x04000176 RID: 374
		private global::System.Collections.ObjectModel.ObservableCollection<global::AcpASKLib.IKeyDataRecord> d;

		// Token: 0x04000177 RID: 375
		private global::AcpASKLib.KeyType e;

		// Token: 0x04000178 RID: 376
		private global::AcpASKLib.HardwareKeyFamily f;

		// Token: 0x04000179 RID: 377
		private bool g;

		// Token: 0x0400017A RID: 378
		private bool h;

		// Token: 0x0400017B RID: 379
		private bool i;

		// Token: 0x0400017C RID: 380
		private bool j;

		// Token: 0x0400017D RID: 381
		private bool k;

		// Token: 0x0400017E RID: 382
		private bool l;

		// Token: 0x0400017F RID: 383
		private string m;

		// Token: 0x04000180 RID: 384
		private bool n;

		// Token: 0x04000181 RID: 385
		private global::AcpASKLib.KeyExpirationType o;

		// Token: 0x04000182 RID: 386
		private short p;

		// Token: 0x04000183 RID: 387
		private bool q;

		// Token: 0x04000184 RID: 388
		private global::System.DateTime r;

		// Token: 0x04000185 RID: 389
		private short s;

		// Token: 0x04000186 RID: 390
		private short t;

		// Token: 0x04000187 RID: 391
		private global::System.DateTime u;

		// Token: 0x04000188 RID: 392
		private global::System.Windows.MessageBoxOptions v;

		// Token: 0x04000189 RID: 393
		private string w = global::AcpCommonResources.AcpResources.Application_Name_CPS;

		// Token: 0x0400018A RID: 394
		private readonly bool x = true;
	}
}
