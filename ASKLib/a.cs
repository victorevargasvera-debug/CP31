using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using ASK.Interface;
using Motorola.CommonCPS.ResourceRepository;

namespace ASKLib
{
	// Token: 0x0200000B RID: 11
	internal class a
	{
		// Token: 0x06000030 RID: 48 RVA: 0x0000473C File Offset: 0x0000293C
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		internal bool g()
		{
			short num = (short)1385121278;
			short num2 = num;
			num = (short)1972454910;
			switch (num2 == num)
			{
			default:
			{
				num = (short)31653888;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)417595392;
			if (num != 0)
			{
			}
			num = (short)1260584961;
			if (num != 0)
			{
			}
			return this.k;
		}

		// Token: 0x06000031 RID: 49 RVA: 0x000047E8 File Offset: 0x000029E8
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private void b(bool A_0)
		{
			short num = (short)1644169851;
			short num2 = num;
			num = (short)700975739;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1144979456;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1792999425;
			if (num != 0)
			{
			}
			num = (short)2089943040;
			if (num != 0)
			{
			}
			this.k = A_0;
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00004898 File Offset: 0x00002A98
		internal a(global::ASK.Interface.IRadioSecurityData A_0, global::ASK.Interface.IRadioSecurityData A_1, global::ASK.Interface.ASK_COMMS_OP A_2, bool A_3 = false, bool A_4 = false, bool A_5 = false, bool A_6 = false)
		{
			this.d = A_2;
			this.b = A_0;
			this.c = A_1;
			this.e = A_3;
			this.f = A_4;
			this.g = new global::System.Collections.ObjectModel.Collection<string>();
			this.h = global::ASKLib.SystemKeyManager.GetInstance();
			this.i = A_5;
			this.j = A_6;
		}

		// Token: 0x06000033 RID: 51 RVA: 0x000048F8 File Offset: 0x00002AF8
		internal bool b(out string A_0)
		{
			short num = (short)1002635264;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_177;
				}
				bool flag;
				string text;
				string str;
				for (;;)
				{
					IL_28:
					global::ASKLib.SystemKeyData systemKeyData;
					bool flag3;
					global::System.Collections.ObjectModel.ReadOnlyCollection<global::ASK.Interface.ISystemKeyData> readOnlyCollection;
					global::ASKLib.SystemKeyData systemKeyData3;
					global::ASK.Interface.KeyType a_;
					int a_2;
					switch (num2)
					{
					case 0:
						if (flag)
						{
							num = (short)250413122;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3E3;
					case 1:
					{
						num = (short)1581890302;
						short num3 = num;
						num = (short)995867390;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_CCD;
						default:
						{
							num = (short)1031405568;
							if (num != 0)
							{
							}
							int ownerAdvancedKeyType = this.b.OwnerAdvancedKeyType;
							num = (short)219414583;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 2:
						if (systemKeyData.WriteProtectEnabled)
						{
							num = (short)1141440544;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AA9;
					case 3:
						if (!this.j)
						{
							num = (short)1703411775;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_505;
					case 4:
						goto IL_358;
					case 5:
						if (this.d != global::ASK.Interface.ASK_COMMS_OP.USB_CLONE)
						{
							num = (short)365428795;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_24E;
					case 6:
						A_0 = global::Motorola.CommonCPS.ResourceRepository.Resources.Permission_Denied_ASK_OTAP_Enabled;
						flag = false;
						num = (short)215351377;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						text = null;
						flag = this.a(out text);
						num = (short)1990066204;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						goto IL_96A;
					case 9:
						goto IL_926;
					case 10:
						if (this.b.IsConventionalOnly)
						{
							num = (short)237633609;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9FA;
					case 11:
						num = (short)24838179;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						if (!this.c(systemKeyData, out str))
						{
							num = (short)1905328136;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2041708620;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						num = (short)1346109442;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						goto IL_505;
					case 15:
					{
						bool flag2;
						if (!flag2)
						{
							num = (short)532480040;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2D8;
					}
					case 16:
						if (this.b.ProtectionOptn == global::ASK.Interface.ProtectionOption.UNSPECIFIED)
						{
							num = (short)1100087322;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_56E;
					case 17:
						if (!this.i)
						{
							num = (short)58196009;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9FA;
					case 18:
					{
						global::ASKLib.SystemKeyData systemKeyData2;
						this.a(systemKeyData2.iBtnSerialNum);
						bool flag2 = systemKeyData2.WriteProtectEnabled;
						num = (short)1697972267;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 19:
						num = (short)546177040;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						num = (short)344064067;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						if (!this.b.IsConventionalOnly)
						{
							num = (short)1099694099;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_56E;
					case 22:
						if (this.d == global::ASK.Interface.ASK_COMMS_OP.OTAP_READ_WRITE)
						{
							num = (short)1814888495;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_505;
					case 23:
						goto IL_5FD;
					case 24:
						goto IL_B72;
					case 25:
						if (!this.a(ref flag3))
						{
							num = (short)1345126453;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1625227312;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
						this.a(readOnlyCollection, out systemKeyData3);
						num = (short)152174622;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 27:
						if (systemKeyData != null)
						{
							num = (short)1988427789;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AA9;
					case 28:
						if (!flag)
						{
							num = (short)533594170;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3E3;
					case 29:
						if (!this.b.IsConventionalOnly)
						{
							num = (short)909377592;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_926;
					case 30:
						goto IL_B72;
					case 31:
						if (this.b.ProtectionOptn == global::ASK.Interface.ProtectionOption.UNSPECIFIED)
						{
							num = (short)1817444363;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_635;
					case 32:
						systemKeyData3 = systemKeyData;
						num = (short)545456189;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 33:
						num = (short)1926758423;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 34:
					{
						this.a(systemKeyData.iBtnSerialNum);
						bool flag2 = systemKeyData.WriteProtectEnabled;
						num = (short)91619377;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 35:
						if (!this.b.IsConventionalOnly)
						{
							num = (short)568655949;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_635;
					case 36:
					{
						bool flag2;
						if (flag2)
						{
							num = (short)1372585991;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3E3;
					}
					case 37:
						if (systemKeyData3 != null)
						{
							num = (short)2081685578;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2D8;
					case 38:
						this.b();
						this.a();
						num = (short)414974009;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 39:
					{
						global::ASKLib.SystemKeyData systemKeyData2;
						if (systemKeyData2 != null)
						{
							num = (short)966983698;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_293;
					}
					case 40:
					{
						num = (short)685047808;
						short num4 = num;
						systemKeyData3 = null;
						num = (short)17301525;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 41:
						goto IL_488;
					case 42:
						if (this.b.ProtectionOptn != global::ASK.Interface.ProtectionOption.LEGACY_SW)
						{
							num = (short)1399324673;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_926;
					case 43:
						goto IL_293;
					case 44:
						num = (short)1380646927;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 45:
						A_0 = global::Motorola.CommonCPS.ResourceRepository.Resources.Permission_Denied_ASK_Loaded_OTAP_Enabled;
						num = (short)1660092430;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 46:
						if (systemKeyData != null)
						{
							num = (short)1601699874;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B27;
					case 47:
						flag = this.d();
						num = (short)1987969095;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 48:
						if (this.d == global::ASK.Interface.ASK_COMMS_OP.OTAP_CLONE)
						{
							num = (short)549519380;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_505;
					case 49:
						goto IL_293;
					case 50:
					{
						bool flag2 = true;
						this.a(systemKeyData3.iBtnSerialNum);
						num = (short)338165811;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 51:
						goto IL_2D8;
					case 52:
						num = (short)1438580767;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 53:
						A_0 = global::Motorola.CommonCPS.ResourceRepository.Resources.Permission_Denied_SK_For_Trunking_Loaded;
						flag = false;
						num = (short)1003290703;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 54:
						if (this.d != global::ASK.Interface.ASK_COMMS_OP.OTAP_CLONE)
						{
							num = (short)194248776;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_24E;
					case 55:
					{
						int ownerAdvancedKeyType;
						if (ownerAdvancedKeyType != 0)
						{
							num = (short)495583294;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						a_ = global::ASK.Interface.KeyType.ADVANCED_SYSTEM_KEY;
						a_2 = this.b.OwnerSystemID;
						num = (short)2070216705;
						if (num != 0)
						{
						}
						num = (short)1822228558;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 56:
						num = (short)871301162;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 57:
						return flag;
					case 58:
						goto IL_9B1;
					case 59:
						num = (short)686751798;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 60:
					{
						int ownerAdvancedKeyType;
						if (ownerAdvancedKeyType != 1)
						{
							num = (short)853868577;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						a_ = global::ASK.Interface.KeyType.ADVANCED_WACN_KEY;
						a_2 = this.b.OwnerWACNID;
						num = (short)1683882048;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 61:
						goto IL_B72;
					case 62:
						num = (short)1032257596;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 63:
						num = (short)474218501;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 64:
						goto IL_5FD;
					case 65:
						if (flag)
						{
							num = (short)365690918;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 66:
					{
						bool flag2 = false;
						readOnlyCollection = null;
						systemKeyData = null;
						a_2 = 0;
						a_ = global::ASK.Interface.KeyType.UNDEFINED_KEY;
						num = (short)1272447005;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 67:
						if (!flag3)
						{
							num = (short)987561990;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_505;
					case 68:
						if (this.a(systemKeyData))
						{
							num = (short)2004877356;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3E3;
					case 69:
					{
						global::ASKLib.SystemKeyData systemKeyData2;
						if (!this.a(readOnlyCollection, out systemKeyData2))
						{
							num = (short)117506052;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1071644711;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 70:
						if (systemKeyData3.WriteProtectEnabled)
						{
							num = (short)905904178;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2D8;
					case 71:
						if (!flag)
						{
							num = (short)609353773;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_505;
					case 72:
						goto IL_CCD;
					case 73:
						num = (short)1282932753;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 74:
						num = (short)594608198;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 75:
						if (this.d == global::ASK.Interface.ASK_COMMS_OP.BLUETOOTH_CLONE)
						{
							num = (short)1975451728;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)435027990;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 76:
						if (this.c())
						{
							num = (short)457900084;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_293;
					case 77:
					{
						global::ASKLib.SystemKeyData systemKeyData2 = null;
						num = (short)1282867269;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 78:
						goto IL_5FD;
					case 79:
						goto IL_505;
					case 80:
						goto IL_24E;
					case 81:
						goto IL_505;
					}
					goto IL_177;
					IL_24E:
					flag3 = true;
					num = (short)229834777;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_293:
					num = (short)791937092;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2D8:
					num = (short)1364131876;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3E3:
					num = (short)1863188545;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_505:
					num = (short)1756758016;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_56E:
					num = (short)1384906779;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5FD:
					readOnlyCollection = this.h.LoadedASKs;
					this.b(a_2, a_, readOnlyCollection, out systemKeyData);
					num = (short)1871773705;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_635:
					num = (short)83951662;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_926:
					str = null;
					num = (short)845873164;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_9FA:
					num = (short)981139459;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_AA9:
					this.a(a_2, a_, readOnlyCollection, out systemKeyData3);
					num = (short)971243544;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_B72:
					num = (short)1979645989;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_CCD:
					num = (short)1566507083;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_358:
				A_0 = global::Motorola.CommonCPS.ResourceRepository.Resources.Permission_Denied_Write_Without_ASK;
				return false;
				IL_488:
				this.f();
				return true;
				IL_96A:
				A_0 = global::Motorola.CommonCPS.ResourceRepository.Resources.Permission_Denied_Incompatible_RaCp_SK_Protection + str;
				return false;
				IL_9B1:
				A_0 = text;
				return false;
				IL_B27:
				A_0 = global::Motorola.CommonCPS.ResourceRepository.Resources.Permission_Denied_Write_Without_ASK;
				return false;
				IL_177:
				flag = true;
				A_0 = null;
				num = (short)846266378;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06000034 RID: 52 RVA: 0x0000567C File Offset: 0x0000387C
		private void f()
		{
			short num = (short)1138294784;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_62;
					}
					continue;
				case 1:
					goto IL_180;
				case 2:
					goto IL_131;
				case 3:
					return;
				case 4:
					this.c.OwnerAdvancedKeyType = this.b.OwnerAdvancedKeyType;
					this.b(true);
					num = (short)22151173;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					goto IL_292;
				case 6:
					if (this.c.ASKRequired != this.b.ASKRequired)
					{
						num = (short)721027083;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 7:
					if (this.c.OwnerWACNID != this.b.OwnerWACNID)
					{
						num = (short)2037186574;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_209;
				case 8:
					this.c.OwnerSystemID = this.b.OwnerSystemID;
					this.b(true);
					num = (short)2087321601;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					if (this.c.OwnerSystemID != this.b.OwnerSystemID)
					{
						num = (short)609746952;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_180;
				case 10:
					if (this.c.OwnerAdvancedKeyType != this.b.OwnerAdvancedKeyType)
					{
						num = (short)1189740548;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_292;
				case 11:
					this.c.ASKRequired = this.b.ASKRequired;
					this.b(true);
					num = (short)276234243;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					IL_12C:
					goto IL_209;
				case 13:
				{
					num = (short)748814336;
					short num3 = num;
					this.c.WriteProtected = this.b.WriteProtected;
					this.b(true);
					num = (short)941424642;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 14:
					this.c.OwnerWACNID = this.b.OwnerWACNID;
					this.b(true);
					num = (short)2084044812;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_62:
				if (this.c.WriteProtected != this.b.WriteProtected)
				{
					num = (short)958922765;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_131:
				num = (short)1082130442;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_180:
				num = (short)1734803462;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_209:
				num = (short)1775435785;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_292:
				num = (short)556587713;
				short num4 = num;
				num = (short)1282857665;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_12C;
				default:
					num = (short)513605633;
					if (num != 0)
					{
					}
					num = (short)987037696;
					if (num != 0)
					{
					}
					num = (short)936902663;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00005A18 File Offset: 0x00003C18
		private bool a(ref bool A_0)
		{
			short num = (short)1883766784;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_5A;
				}
				bool result;
				global::System.Collections.Generic.IEnumerator<global::ASKLib.TrkSysID> enumerator;
				global::System.Collections.ObjectModel.ReadOnlyCollection<global::ASK.Interface.ISystemKeyData> readOnlyCollection;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
					{
						global::System.Collections.ObjectModel.Collection<global::ASKLib.TrkSysID> collection;
						if (collection.Count > 0)
						{
							num = (short)640221191;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_12F;
					}
					case 1:
						if (!this.c.IsConventionalOnly)
						{
							num = (short)566165513;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 2:
						num = (short)1207173120;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						A_0 = false;
						global::System.Collections.ObjectModel.Collection<global::ASKLib.TrkSysID> collection;
						enumerator = collection.GetEnumerator();
						num = (short)2022113288;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
					{
						global::System.Collections.ObjectModel.Collection<global::ASKLib.TrkSysID> collection;
						if (collection != null)
						{
							num = (short)1564606466;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_12F;
					}
					case 5:
						return result;
					case 6:
						return result;
					case 7:
						num = (short)1371275265;
						if (num != 0)
						{
						}
						try
						{
							num = (short)817627143;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									if (this.c.ProtectionOptn == global::ASK.Interface.ProtectionOption.UNSPECIFIED)
									{
										num = (short)1074528261;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									readOnlyCollection = this.h.LoadedUserSystemKeys;
									num = (short)1462501377;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_358;
								case 2:
									if (!this.c.ASKRequired)
									{
										num = (short)893386755;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_30B;
								case 3:
									goto IL_286;
								case 4:
									goto IL_358;
								case 5:
									goto IL_30B;
								case 6:
									num = (short)1089142786;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
									switch (0)
									{
									case 0:
										goto IL_25F;
									}
									continue;
								case 8:
									goto IL_371;
								}
								IL_25F:
								if (this.c.ProtectionOptn == global::ASK.Interface.ProtectionOption.HARDWARE)
								{
									num = (short)1221591046;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_286:
								num = (short)1993539584;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_30B:
								readOnlyCollection = this.h.LoadedASKs;
								num = (short)291831812;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_358:
								num = (short)1997996040;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_371:
							goto IL_1D9;
						}
						catch (global::System.Exception)
						{
							return false;
						}
						goto Block_6;
						IL_1D9:
						num = (short)1601896458;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						goto IL_C0;
					case 9:
					{
						readOnlyCollection = null;
						global::System.Collections.ObjectModel.Collection<global::ASKLib.TrkSysID> collection = this.e();
						num = (short)1634205700;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						if (readOnlyCollection != null)
						{
							num = (short)170459139;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						result = false;
						num = (short)286523398;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_5A;
					IL_12F:
					result = false;
					num = (short)1238958080;
					short num3 = num;
					num = (short)216465413;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_C0:
				goto IL_37E;
				Block_6:
				try
				{
					for (;;)
					{
						IL_37E:
						num = (short)930349062;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								try
								{
									num = (short)1781792769;
									num2 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										switch (num2)
										{
										case 0:
										{
											global::ASKLib.SystemKeyData systemKeyData;
											global::ASKLib.TrkSysID trkSysID;
											if (systemKeyData.SystemID == trkSysID.ID)
											{
												num = (short)1003618311;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											break;
										}
										case 1:
											switch (0)
											{
											case 0:
												goto IL_41C;
											}
											continue;
										case 2:
											if (!A_0)
											{
												num = (short)908918790;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_551;
										case 3:
											goto IL_569;
										case 4:
											goto IL_551;
										case 5:
										{
											global::System.Collections.Generic.IEnumerator<global::ASK.Interface.ISystemKeyData> enumerator2;
											if (!enumerator2.MoveNext())
											{
												num = (short)220987396;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											global::ASKLib.SystemKeyData systemKeyData = (global::ASKLib.SystemKeyData)enumerator2.Current;
											num = (short)2028994560;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 6:
										{
											global::ASKLib.SystemKeyData systemKeyData;
											A_0 = systemKeyData.OtapEnabled;
											num = (short)2001338378;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 7:
											num = (short)2019360777;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 8:
										{
											bool flag = true;
											num = (short)460718082;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 9:
										{
											global::ASKLib.SystemKeyData systemKeyData;
											global::ASKLib.TrkSysID trkSysID;
											if (systemKeyData.Type == trkSysID.SystemKeyType)
											{
												num = (short)26148872;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											break;
										}
										case 10:
											goto IL_54C;
										}
										IL_4B6:
										num = (short)180486149;
										num2 = (int)((global::System.IntPtr)num);
										continue;
										IL_41C:
										goto IL_4B6;
										IL_551:
										num = (short)97320963;
										num2 = (int)((global::System.IntPtr)num);
									}
									IL_54C:
									IL_569:
									goto IL_66E;
								}
								finally
								{
									num = (short)743899137;
									num2 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										global::System.Collections.Generic.IEnumerator<global::ASK.Interface.ISystemKeyData> enumerator2;
										switch (num2)
										{
										case 0:
											enumerator2.Dispose();
											num = (short)6815746;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 1:
											switch (0)
											{
											case 0:
												goto IL_5A0;
											}
											continue;
										case 2:
											goto IL_5DA;
										}
										IL_5A0:
										if (enumerator2 == null)
										{
											break;
										}
										num = (short)961478656;
										num2 = (int)((global::System.IntPtr)num);
									}
									IL_5DA:;
								}
								break;
								IL_66E:
								num = (short)1167720451;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								result = false;
								num = (short)1525415940;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								num = (short)1954807815;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
							{
								bool flag;
								if (!flag)
								{
									num = (short)1714814977;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 4:
								goto IL_638;
							case 5:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)62586882;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::ASKLib.TrkSysID trkSysID = enumerator.Current;
								bool flag = false;
								global::System.Collections.Generic.IEnumerator<global::ASK.Interface.ISystemKeyData> enumerator2 = readOnlyCollection.GetEnumerator();
								num = (short)1950220288;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 6:
								switch (0)
								{
								case 0:
									goto IL_3C4;
								}
								continue;
							case 7:
								goto IL_6C3;
							}
							IL_5DD:
							num = (short)1203568645;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_3C4:
							goto IL_5DD;
						}
						IL_6C3:
						num = (short)946989252;
						short num4 = num;
						num = (short)337373380;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_6F9;
						}
					}
					IL_638:
					return result;
					IL_6F9:
					num = (short)449970176;
					if (num != 0)
					{
					}
					return result;
				}
				finally
				{
					num = (short)1962999809;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							enumerator.Dispose();
							num = (short)1382481922;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_746;
							}
							continue;
						case 2:
							goto IL_77F;
						}
						IL_746:
						if (enumerator == null)
						{
							break;
						}
						num = (short)1014431744;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_77F:;
				}
				bool result2;
				return result2;
				IL_5A:
				result = true;
				num = (short)725090305;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000036 RID: 54 RVA: 0x000061F4 File Offset: 0x000043F4
		private global::System.Collections.ObjectModel.Collection<global::ASKLib.TrkSysID> e()
		{
			short num = (short)1253834752;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)1719575488;
				short num3 = num;
				num = (short)524788672;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_197:
					num = (short)750649344;
					num2 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)734920704;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_A6;
					}
					break;
				}
				global::System.Collections.ObjectModel.Collection<global::ASKLib.TrkSysID> collection;
				global::System.Collections.Generic.List<global::ASK.Interface.IAskSystem> systems;
				int num4;
				for (;;)
				{
					IL_73:
					global::ASK.Interface.KeyType a_;
					int a_2;
					switch (num2)
					{
					case 0:
						return collection;
					case 1:
						if (systems[num4].SystemType == global::ASK.Interface.AskSystemType.TRUNCKING)
						{
							num = (short)616103936;
							short num5 = num;
							num = (short)804651017;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_221;
					case 2:
						num = (short)1328611329;
						if (num != 0)
						{
						}
						goto IL_D6;
					case 3:
						goto IL_221;
					case 4:
						if (systems[num4].CoverageType == global::ASK.Interface.AskTrkSysCoverageType.IntraWACNRoaming)
						{
							num = (short)577044488;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						a_ = global::ASK.Interface.KeyType.ADVANCED_SYSTEM_KEY;
						a_2 = systems[num4].SystemId;
						num = (short)757399562;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						if (num4 >= systems.Count)
						{
							goto IL_197;
						}
						num = (short)1714094081;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						goto IL_175;
					case 7:
						goto IL_175;
					case 8:
						a_ = global::ASK.Interface.KeyType.ADVANCED_WACN_KEY;
						a_2 = systems[num4].WacnId;
						num = (short)1945174018;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						num = (short)1467547652;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						goto IL_D6;
					}
					goto IL_A6;
					IL_D6:
					global::ASKLib.TrkSysID item = new global::ASKLib.TrkSysID(a_, a_2);
					collection.Add(item);
					num = (short)1226571779;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_175:
					num = (short)555548677;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_221:
					num4++;
					num = (short)2083258374;
					num2 = (int)((global::System.IntPtr)num);
				}
				return collection;
				IL_A6:
				collection = null;
				collection = new global::System.Collections.ObjectModel.Collection<global::ASKLib.TrkSysID>();
				systems = this.c.Systems;
				num4 = 0;
				num = (short)1405222919;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_73;
			}
			}
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00006498 File Offset: 0x00004698
		private bool d()
		{
			short num = (short)1783300096;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_5A;
				}
				bool flag;
				global::System.Collections.Generic.IEnumerator<global::ASKLib.TrkSysID> enumerator;
				global::System.Collections.ObjectModel.ReadOnlyCollection<global::ASK.Interface.ISystemKeyData> readOnlyCollection;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
					{
						global::System.Collections.ObjectModel.Collection<global::ASKLib.TrkSysID> collection;
						if (collection != null)
						{
							num = (short)674037761;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_12F;
					}
					case 1:
						num = (short)1891172356;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						flag = false;
						global::System.Collections.ObjectModel.Collection<global::ASKLib.TrkSysID> collection;
						enumerator = collection.GetEnumerator();
						num = (short)426377217;
						if (num != 0)
						{
						}
						num = (short)1155989514;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
					{
						readOnlyCollection = null;
						global::System.Collections.ObjectModel.Collection<global::ASKLib.TrkSysID> collection = this.e();
						num = (short)858324992;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
					{
						global::System.Collections.ObjectModel.Collection<global::ASKLib.TrkSysID> collection;
						if (collection.Count > 0)
						{
							num = (short)536215560;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_12F;
					}
					case 5:
						return flag;
					case 6:
						if (readOnlyCollection != null)
						{
							num = (short)478674946;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						flag = false;
						num = (short)2007564297;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						if (!this.c.IsConventionalOnly)
						{
							num = (short)1356005379;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 8:
					{
						try
						{
							readOnlyCollection = this.h.LoadedASKs;
							goto IL_1B0;
						}
						catch (global::System.Exception)
						{
							return false;
						}
						goto Block_6;
						IL_1B0:
						num = (short)896729088;
						short num3 = num;
						num = (short)1176436742;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						return flag;
					case 10:
						goto IL_E9;
					}
					goto IL_5A;
					IL_12F:
					flag = false;
					num = (short)882704389;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_E9:
				Block_6:
				try
				{
					num = (short)257425412;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_4FE;
						case 1:
							try
							{
								num = (short)1505492999;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										flag = true;
										num = (short)1416757249;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										goto IL_3CE;
									case 2:
										goto IL_442;
									case 3:
									{
										global::System.Collections.Generic.IEnumerator<global::ASK.Interface.ISystemKeyData> enumerator2;
										if (!enumerator2.MoveNext())
										{
											num = (short)689504266;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::ASKLib.SystemKeyData systemKeyData = (global::ASKLib.SystemKeyData)enumerator2.Current;
										num = (short)1353711625;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 4:
									{
										global::ASKLib.SystemKeyData systemKeyData;
										global::ASKLib.TrkSysID trkSysID;
										if (systemKeyData.Type == trkSysID.SystemKeyType)
										{
											num = (short)1092616200;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 5:
									{
										global::ASKLib.SystemKeyData systemKeyData;
										if (systemKeyData.OtapEnabled)
										{
											num = (short)324993024;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 6:
										num = (short)628883460;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 7:
										switch (0)
										{
										case 0:
											goto IL_2F4;
										}
										continue;
									case 8:
										num = (short)1853030405;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 9:
									{
										global::ASKLib.SystemKeyData systemKeyData;
										global::ASKLib.TrkSysID trkSysID;
										if (systemKeyData.SystemID == trkSysID.ID)
										{
											num = (short)1168637958;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 10:
										num = (short)2124873730;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_2F6:
									num = (short)1246625795;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_2F4:
									goto IL_2F6;
								}
								IL_3CE:
								IL_442:;
							}
							finally
							{
								num = (short)794492929;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.Collections.Generic.IEnumerator<global::ASK.Interface.ISystemKeyData> enumerator2;
									switch (num2)
									{
									case 0:
										enumerator2.Dispose();
										num = (short)587726850;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_476;
										}
										continue;
									case 2:
										goto IL_4AD;
									}
									IL_476:
									if (enumerator2 == null)
									{
										break;
									}
									num = (short)879165440;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_4AD:;
							}
							num = (short)710868999;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							num = (short)357629952;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							num = (short)1184890885;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							switch (0)
							{
							case 0:
								goto IL_273;
							}
							continue;
						case 5:
							goto IL_55B;
						case 6:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)317521923;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::ASKLib.TrkSysID trkSysID = enumerator.Current;
							global::System.Collections.Generic.IEnumerator<global::ASK.Interface.ISystemKeyData> enumerator2 = readOnlyCollection.GetEnumerator();
							num = (short)456916993;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 7:
							if (flag)
							{
								num = (short)1984888834;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						IL_503:
						num = (short)1972568070;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_273:
						goto IL_503;
					}
					IL_4FE:
					IL_55B:
					return flag;
				}
				finally
				{
					num = (short)1914634241;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
						{
							num = (short)495318765;
							short num4 = num;
							num = (short)241432301;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_61B;
							default:
								num = (short)1707933696;
								if (num != 0)
								{
								}
								enumerator.Dispose();
								num = (short)1669595138;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 1:
							switch (0)
							{
							case 0:
								goto IL_594;
							}
							continue;
						case 2:
							goto IL_61B;
						}
						IL_594:
						if (enumerator == null)
						{
							break;
						}
						num = (short)461045760;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_61B:;
				}
				bool result;
				return result;
				IL_5A:
				flag = true;
				num = (short)1988493319;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00006B10 File Offset: 0x00004D10
		private bool b(int A_0, global::ASK.Interface.KeyType A_1, global::System.Collections.ObjectModel.ReadOnlyCollection<global::ASK.Interface.ISystemKeyData> A_2, out global::ASKLib.SystemKeyData A_3)
		{
			short num = (short)1707474944;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_5E;
				}
				global::ASKLib.SystemKeyData systemKeyData;
				global::ASKLib.SystemKeyData systemKeyData2;
				global::ASKLib.SystemKeyData systemKeyData3;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						A_3 = systemKeyData;
						num = (short)1681457160;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						global::System.Collections.Generic.IEnumerator<global::ASK.Interface.ISystemKeyData> enumerator = A_2.GetEnumerator();
						num = (short)1349320710;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_108;
					case 3:
					{
						if (systemKeyData2 != null)
						{
							num = (short)2092761093;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)855375872;
						short num3 = num;
						num = (short)1163329540;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						if (systemKeyData3 != null)
						{
							num = (short)63766539;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_494;
					case 5:
						num = (short)829882369;
						if (num != 0)
						{
						}
						A_3 = systemKeyData2;
						num = (short)1350369282;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						try
						{
							num = (short)200671236;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::ASKLib.SystemKeyData systemKeyData4;
								global::ASK.Interface.KeyAccessLevelType keyAccessLevelType;
								switch (num2)
								{
								case 0:
									goto IL_407;
								case 1:
									num = (short)518127634;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									num = (short)2077425673;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									if (systemKeyData4.WriteProtectEnabled)
									{
										num = (short)1588461583;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									systemKeyData = systemKeyData4;
									num = (short)1402142734;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									switch (0)
									{
									case 0:
										goto IL_180;
									}
									continue;
								case 5:
									num = (short)166592525;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									goto IL_3EA;
								case 8:
									if (A_1 == systemKeyData4.Type)
									{
										num = (short)590741506;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 9:
									if (systemKeyData4.AccessLevel != null)
									{
										num = (short)2030305292;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 10:
									if (A_0 == systemKeyData4.SystemID)
									{
										num = (short)1167720464;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 11:
								{
									global::System.Collections.Generic.IEnumerator<global::ASK.Interface.ISystemKeyData> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)774176773;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									systemKeyData4 = (global::ASKLib.SystemKeyData)enumerator.Current;
									num = (short)438763530;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 12:
									keyAccessLevelType = systemKeyData4.AccessLevel.GetKeyAccessLevelType();
									num = (short)2111242257;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 13:
									goto IL_424;
								case 15:
								{
									num = (short)780248498;
									short num4 = num;
									num = (short)473998770;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_202;
									default:
										num = (short)487784448;
										if (num != 0)
										{
										}
										systemKeyData3 = systemKeyData4;
										num = (short)324272135;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 16:
									num = (short)1348665352;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 17:
									goto IL_202;
								case 18:
									if (keyAccessLevelType == global::ASK.Interface.KeyAccessLevelType.UNLM_ACC_WITHOUT_WP)
									{
										num = (short)2040397830;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)858456067;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_19D:
								num = (short)1663959051;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_180:
								goto IL_19D;
								IL_202:
								if (keyAccessLevelType != global::ASK.Interface.KeyAccessLevelType.UNLM_ACC)
								{
									num = (short)792657921;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_3EA:
								systemKeyData2 = systemKeyData4;
								num = (short)1471152128;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_407:
							IL_424:
							goto IL_579;
						}
						finally
						{
							num = (short)810287105;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::ASK.Interface.ISystemKeyData> enumerator;
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1486880770;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_45B;
									}
									continue;
								case 2:
									goto IL_491;
								}
								IL_45B:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1318715392;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_491:;
						}
						goto IL_494;
						IL_579:
						num = (short)1743978499;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						if (A_2 != null)
						{
							num = (short)1566441473;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5B5;
					case 8:
						goto IL_577;
					case 9:
						if (systemKeyData != null)
						{
							num = (short)1608712192;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5B5;
					case 10:
						goto IL_BC;
					case 11:
						A_3 = systemKeyData3;
						num = (short)1641218058;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_5E;
					IL_494:
					num = (short)2072117257;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_BC:
				IL_108:
				IL_577:
				IL_5B5:
				return A_3 != null;
				IL_5E:
				A_3 = null;
				systemKeyData2 = null;
				systemKeyData3 = null;
				systemKeyData = null;
				num = (short)8060935;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000039 RID: 57 RVA: 0x000070F4 File Offset: 0x000052F4
		private bool c(global::ASKLib.SystemKeyData A_0, out string A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_5A;
			}
			short num;
			int num3;
			bool result;
			for (;;)
			{
				IL_0A:
				num = (short)1384906752;
				short num2 = num;
				switch (num3)
				{
				case 0:
					if (this.d == global::ASK.Interface.ASK_COMMS_OP.BLUETOOTH_CLONE)
					{
						num = (short)1713111042;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					result = this.a(A_0, out A_1);
					num = (short)3407876;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
				{
					num = (short)2118006001;
					short num4 = num;
					num = (short)1780823281;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_9B;
					default:
						num = (short)1754529792;
						if (num != 0)
						{
						}
						num = (short)491126784;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 2:
					num = (short)1000210433;
					if (num != 0)
					{
					}
					goto IL_9B;
				case 3:
					if (this.d != global::ASK.Interface.ASK_COMMS_OP.USB_CLONE)
					{
						num = (short)952238086;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_9B;
				case 4:
					return result;
				case 5:
					return result;
				case 6:
					num = (short)2127626247;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					if (this.d != global::ASK.Interface.ASK_COMMS_OP.OTAP_CLONE)
					{
						num = (short)1287389185;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_9B;
				}
				goto IL_5A;
				IL_9B:
				result = this.b(A_0, out A_1);
				num = (short)1771831301;
				num3 = (int)((global::System.IntPtr)num);
			}
			return result;
			IL_5A:
			result = false;
			A_1 = null;
			num = (short)192544771;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x0600003A RID: 58 RVA: 0x000072DC File Offset: 0x000054DC
		private bool b(global::ASKLib.SystemKeyData A_0, out string A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_108;
			}
			int num;
			short num2;
			bool flag2;
			for (;;)
			{
				IL_0A:
				bool flag;
				bool a_;
				switch (num)
				{
				case 0:
					num2 = (short)1243676703;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					if (A_0.AccessLevelType != global::ASK.Interface.KeyAccessLevelType.UNLM_ACC)
					{
						num2 = (short)948043815;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)59113477;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if (!this.c.IsConventionalOnly)
					{
						num2 = (short)944963630;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_6DD;
				case 3:
					num2 = (short)1816657921;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					num2 = (short)1194983468;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					flag = true;
					goto IL_94E;
				case 6:
					goto IL_1B8;
				case 7:
					flag2 = true;
					num2 = (short)2130640911;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					num2 = (short)1553072139;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					if (this.b.ProtectionOptn == global::ASK.Interface.ProtectionOption.HARDWARE)
					{
						num2 = (short)290455552;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_544;
				case 10:
					flag2 = true;
					num2 = (short)22675515;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 11:
					if (this.c.ASKRequired)
					{
						num2 = (short)164298799;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_83A;
				case 12:
					if (this.b.ProtectionOptn == global::ASK.Interface.ProtectionOption.HARDWARE)
					{
						num2 = (short)1230897175;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_8CA;
				case 13:
					goto IL_1B8;
				case 14:
					num2 = (short)559611960;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 15:
					goto IL_1B8;
				case 16:
					goto IL_1B8;
				case 17:
				{
					num2 = (short)237961216;
					short num3 = num2;
					num2 = (short)1706688513;
					if (num2 != 0)
					{
					}
					num2 = (short)1590820912;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 18:
					goto IL_1B8;
				case 19:
				{
					num2 = (short)809263225;
					short num4 = num2;
					num2 = (short)1325883513;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_20B;
					default:
						num2 = (short)1689452544;
						if (num2 != 0)
						{
						}
						if (this.c.ProtectionOptn == global::ASK.Interface.ProtectionOption.UNSPECIFIED)
						{
							num2 = (short)2097086497;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_6DD;
					}
					break;
				}
				case 20:
					if (this.c.ASKRequired)
					{
						num2 = (short)1860829208;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_4BC;
				case 21:
					if (!this.a(a_))
					{
						num2 = (short)2056323124;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return flag2;
				case 22:
					goto IL_20B;
				case 23:
					num2 = (short)929497126;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 24:
					flag2 = true;
					num2 = (short)1267335194;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 25:
					if (this.b.ProtectionOptn != global::ASK.Interface.ProtectionOption.LEGACY_SW)
					{
						num2 = (short)1253834812;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_7DB;
				case 26:
					goto IL_1B8;
				case 27:
					num2 = (short)250806307;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 28:
					goto IL_659;
				case 29:
					if (this.c.ProtectionOptn == global::ASK.Interface.ProtectionOption.LEGACY_SW)
					{
						num2 = (short)975503390;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_27C;
				case 30:
					num2 = (short)1441202213;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 31:
					if (this.b.ASKRequired)
					{
						num2 = (short)373161988;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_544;
				case 32:
					flag2 = true;
					this.a(A_0.iBtnSerialNum);
					num2 = (short)1412300818;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 33:
					num2 = (short)1765343234;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 34:
					if (flag2)
					{
						num2 = (short)674627626;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return flag2;
				case 35:
					if (!this.b.IsConventionalOnly)
					{
						num2 = (short)1718485009;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1B8;
				case 36:
					if (A_0 != null)
					{
						num2 = (short)2074148896;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					A_1 = global::Motorola.CommonCPS.ResourceRepository.Resources.Advanced_System_key_of_the_Radio_Owner_System_ID_must_be_loaded;
					num2 = (short)1106706448;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 37:
					if (!this.c.IsConventionalOnly)
					{
						num2 = (short)1092747274;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_27C;
				case 38:
					if (this.b.ASKRequired)
					{
						num2 = (short)1865285690;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_7DB;
				case 39:
					num2 = (short)604700729;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 40:
					goto IL_1B8;
				case 41:
					goto IL_7DB;
				case 42:
					a_ = false;
					num2 = (short)105250865;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 43:
					num2 = (short)1049821204;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 44:
					if (this.c.ProtectionOptn == global::ASK.Interface.ProtectionOption.HARDWARE)
					{
						num2 = (short)224264200;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_83A;
				case 45:
					goto IL_1B8;
				case 46:
					flag2 = true;
					num2 = (short)466026541;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 47:
					flag2 = true;
					num2 = (short)1549140029;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 48:
					if (this.c.ProtectionOptn == global::ASK.Interface.ProtectionOption.UNSPECIFIED)
					{
						num2 = (short)642252814;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_501;
				case 49:
					if (A_0 != null)
					{
						num2 = (short)1586298883;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_659;
				case 50:
					if (this.b.ProtectionOptn == global::ASK.Interface.ProtectionOption.UNSPECIFIED)
					{
						num2 = (short)516947995;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1B8;
				case 51:
					if (this.c.IsConventionalOnly)
					{
						num2 = (short)83361845;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					A_1 = global::Motorola.CommonCPS.ResourceRepository.Resources.The_source_codeplug_must_use_Advanced_System_Key_only;
					num2 = (short)1794900008;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 52:
					flag2 = false;
					A_1 = global::Motorola.CommonCPS.ResourceRepository.Resources.Internal_Error;
					num2 = (short)574226487;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 53:
					flag2 = true;
					num2 = (short)1996947469;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 54:
					if (this.c.ProtectionOptn == global::ASK.Interface.ProtectionOption.HARDWARE)
					{
						num2 = (short)1731592235;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_4BC;
				case 55:
					return flag2;
				case 56:
					if (!this.c.IsConventionalOnly)
					{
						num2 = (short)426704903;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_501;
				case 57:
					flag = (A_0.AccessLevelType == global::ASK.Interface.KeyAccessLevelType.UNLM_ACC_WITHOUT_WP);
					goto IL_94E;
				case 58:
					goto IL_8CA;
				case 59:
					goto IL_1B8;
				case 60:
					num2 = (short)1101070358;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 61:
					goto IL_1B8;
				}
				goto IL_108;
				IL_1B8:
				num2 = (short)1897660450;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_20B:
				if (this.b.IsConventionalOnly)
				{
					num2 = (short)50987049;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				num2 = (short)1436221449;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_27C:
				num2 = (short)1863057462;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_4BC:
				num2 = (short)996540467;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_501:
				num2 = (short)867827741;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_544:
				num2 = (short)125501490;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_659:
				num2 = (short)879886357;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_6DD:
				num2 = (short)397541412;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_7DB:
				flag2 = true;
				num2 = (short)1812725766;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_83A:
				num2 = (short)173801491;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_8CA:
				num2 = (short)1070989337;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_94E:
				a_ = flag;
				num2 = (short)1922367516;
				num = (int)((global::System.IntPtr)num2);
			}
			return flag2;
			IL_108:
			flag2 = false;
			A_1 = null;
			num2 = (short)1666777100;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00007C98 File Offset: 0x00005E98
		private void a(string A_0)
		{
			short num = (short)1660551175;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					try
					{
						num = (short)1323958278;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
							{
								global::System.Collections.Generic.IEnumerator<string> enumerator;
								if (string.Compare(enumerator.Current, A_0, true) == 0)
								{
									num = (short)470351876;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 1:
								goto IL_E5;
							case 2:
								goto IL_176;
							case 3:
							{
								global::System.Collections.Generic.IEnumerator<string> enumerator;
								if (!enumerator.MoveNext())
								{
									num = (short)706805765;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)1673068544;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 4:
							{
								bool flag = true;
								num = (short)435486721;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 5:
								num = (short)381747202;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 6:
								switch (0)
								{
								case 0:
									goto IL_CC;
								}
								continue;
							}
							IL_124:
							num = (short)145031171;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_CC:
							goto IL_124;
						}
						IL_E5:
						IL_176:
						goto IL_297;
					}
					finally
					{
						num = (short)1653669890;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							num = (short)1654354916;
							short num3 = num;
							num = (short)1079669732;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
							{
								num = (short)1684209664;
								if (num != 0)
								{
								}
								global::System.Collections.Generic.IEnumerator<string> enumerator;
								switch (num2)
								{
								case 0:
									goto IL_22C;
								case 1:
									enumerator.Dispose();
									goto IL_215;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_1F6;
									}
									continue;
								}
								IL_1F6:
								if (enumerator != null)
								{
									num = (short)33685505;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_22E;
							}
							}
							IL_215:
							num = (short)1250033664;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_22C:
						IL_22E:;
					}
					goto IL_22F;
					IL_297:
					num = (short)751239169;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
				{
					num = (short)1055326209;
					if (num != 0)
					{
					}
					bool flag;
					if (!flag)
					{
						num = (short)937099270;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				case 2:
					if (this.g != null)
					{
						num = (short)165150725;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 3:
					goto IL_5F;
				case 4:
					return;
				case 5:
				{
					bool flag = false;
					global::System.Collections.Generic.IEnumerator<string> enumerator = this.g.GetEnumerator();
					num = (short)410583040;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 6:
					this.g.Add(A_0);
					num = (short)113377284;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					switch (0)
					{
					case 0:
						goto IL_45;
					}
					continue;
				}
				IL_45:
				if (A_0 == null)
				{
					num = (short)347144195;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_22F:
				num = (short)240713730;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_5F:
			num = (short)1809055744;
			short num4 = num;
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00007FD4 File Offset: 0x000061D4
		private bool a(bool A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_40;
			}
			int num;
			short num2;
			bool result;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					this.c.ASKRequired = this.b.ASKRequired;
					this.b(true);
					num2 = (short)1772421127;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					num2 = (short)1710751754;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if (this.c.ASKRequired != this.b.ASKRequired)
					{
						num2 = (short)1025966081;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1D4;
				case 3:
					return result;
				case 4:
					num2 = (short)568852486;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					num2 = (short)1432027138;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					if (this.b != null)
					{
						num2 = (short)1482424329;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 7:
				{
					num2 = (short)1012794265;
					short num3 = num2;
					num2 = (short)943260569;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num2 = (short)2021195776;
						short num4 = num2;
						num2 = (short)1042808833;
						if (num2 != 0)
						{
						}
						num2 = (short)623902720;
						if (num2 != 0)
						{
						}
						goto IL_1D4;
					}
					}
					break;
				}
				case 8:
					if (!A_0)
					{
						num2 = (short)2040725509;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1D4;
				case 9:
					num2 = (short)1812725768;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
					if (!this.i)
					{
						num2 = (short)2021326848;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1D4;
				case 11:
					if (this.c != null)
					{
						num2 = (short)2040528900;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				}
				goto IL_40;
				IL_1D4:
				result = true;
				num2 = (short)2031943683;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_40:
			result = false;
			num2 = (short)401866763;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00008244 File Offset: 0x00006444
		private bool a(global::ASKLib.SystemKeyData A_0, out string A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_B0;
			}
			int num;
			bool flag;
			short num2;
			for (;;)
			{
				IL_0A:
				bool flag2;
				bool flag3;
				switch (num)
				{
				case 0:
					return flag;
				case 1:
					if (this.c.ASKRequired)
					{
						num2 = (short)2070937618;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_55B;
				case 2:
					num2 = (short)1040777229;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					if (this.b.ASKRequired == this.c.ASKRequired)
					{
						num2 = (short)892665882;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_40F;
				case 4:
					num2 = (short)647168023;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					flag = true;
					this.a(A_0.iBtnSerialNum);
					num2 = (short)1101332500;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					if (!this.b.ASKRequired)
					{
						num2 = (short)1575878683;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_55B;
				case 7:
					if (this.b.ASKRequired != this.c.ASKRequired)
					{
						num2 = (short)440795165;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return flag;
				case 8:
					goto IL_59D;
				case 9:
					if (this.b.ProtectionOptn == this.c.ProtectionOptn)
					{
						num2 = (short)1816133671;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_40F;
				case 10:
					if (this.c.ProtectionOptn == global::ASK.Interface.ProtectionOption.HARDWARE)
					{
						num2 = (short)85852185;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return flag;
				case 11:
					return flag;
				case 12:
					flag2 = true;
					goto IL_4DB;
				case 13:
					if (A_0 != null)
					{
						num2 = (short)793313285;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					A_1 = global::Motorola.CommonCPS.ResourceRepository.Resources.Advanced_System_key_of_the_Radio_Owner_System_ID_must_be_loaded;
					num2 = (short)1966735398;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 14:
					flag2 = (A_0.AccessLevelType == global::ASK.Interface.KeyAccessLevelType.UNLM_ACC_WITHOUT_WP);
					goto IL_4DB;
				case 15:
					num2 = (short)2057568257;
					if (num2 != 0)
					{
					}
					if (A_0 != null)
					{
						num2 = (short)888930308;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1E3;
				case 16:
					flag = false;
					A_1 = global::Motorola.CommonCPS.ResourceRepository.Resources.Internal_Error;
					num2 = (short)1217789963;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 17:
				{
					num2 = (short)1392050176;
					short num3 = num2;
					if (this.b.IsConventionalOnly == this.c.IsConventionalOnly)
					{
						num2 = (short)2018181141;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_40F;
				}
				case 18:
					flag = true;
					num2 = (short)579207187;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 19:
					goto IL_4F8;
				case 20:
					goto IL_4F8;
				case 21:
					flag = true;
					num2 = (short)1950023680;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 22:
					num2 = (short)239075342;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 23:
					if (A_0.AccessLevelType != global::ASK.Interface.KeyAccessLevelType.UNLM_ACC)
					{
						num2 = (short)386072598;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1730871308;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 24:
					num2 = (short)2090205215;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 25:
				{
					num2 = (short)1941285453;
					short num4 = num2;
					num2 = (short)811379277;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_59D;
					default:
						num2 = (short)1232994304;
						if (num2 != 0)
						{
						}
						num2 = (short)165085191;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 26:
					num2 = (short)1761935377;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 27:
					num2 = (short)52035585;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 28:
					num2 = (short)2108948515;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 29:
					num2 = (short)2132541446;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 30:
					if (this.b.ProtectionOptn == global::ASK.Interface.ProtectionOption.HARDWARE)
					{
						num2 = (short)824246309;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return flag;
				case 31:
					if (!flag3)
					{
						num2 = (short)1538392092;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return flag;
				case 32:
					if (flag)
					{
						num2 = (short)1054605336;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return flag;
				case 33:
					if (!this.c.ASKRequired)
					{
						num2 = (short)1190002690;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_4F8;
				case 34:
					goto IL_1E3;
				case 35:
					if (!this.a(flag3))
					{
						num2 = (short)240058384;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return flag;
				case 36:
					if (this.b.ASKRequired)
					{
						num2 = (short)1714356232;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_4F8;
				case 37:
					num2 = (short)404226058;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 38:
					goto IL_4F8;
				case 39:
					num2 = (short)48627715;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_B0;
				IL_1E3:
				num2 = (short)1211957280;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_40F:
				num2 = (short)492699678;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_4DB:
				flag3 = flag2;
				num2 = (short)1915355170;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_4F8:
				flag3 = false;
				num2 = (short)1754333199;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_55B:
				num2 = (short)631832612;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_59D:
				num2 = (short)1684602913;
				num = (int)((global::System.IntPtr)num2);
			}
			return flag;
			IL_B0:
			flag = false;
			A_1 = null;
			num2 = (short)839712777;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600003E RID: 62 RVA: 0x000088F0 File Offset: 0x00006AF0
		private bool a(global::ASKLib.SystemKeyData A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_D4;
			}
			int num;
			short num2;
			bool result;
			for (;;)
			{
				IL_0A:
				bool flag;
				switch (num)
				{
				case 0:
					num2 = (short)1543634978;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					num2 = (short)1040384009;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					goto IL_575;
				case 3:
					if (this.c.ProtectionOptn == global::ASK.Interface.ProtectionOption.HARDWARE)
					{
						num2 = (short)533594155;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 4:
					return result;
				case 5:
					flag = (A_0.AccessLevelType == global::ASK.Interface.KeyAccessLevelType.UNLM_ACC_WITHOUT_WP);
					goto IL_363;
				case 6:
					num2 = (short)1802305558;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					if (A_0.AccessLevelType != global::ASK.Interface.KeyAccessLevelType.UNLM_ACC)
					{
						num2 = (short)655687707;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)79167525;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					num2 = (short)1525547055;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					if (this.d != global::ASK.Interface.ASK_COMMS_OP.USB_CLONE)
					{
						num2 = (short)2060582926;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 10:
					if (A_0 != null)
					{
						num2 = (short)1548484616;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 11:
					num2 = (short)649199619;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 12:
					if (!this.b.WriteProtected)
					{
						num2 = (short)1022820376;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 13:
					return result;
				case 14:
					num2 = (short)1509031977;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 15:
					if (this.d != global::ASK.Interface.ASK_COMMS_OP.OTAP_CLONE)
					{
						num2 = (short)1573519380;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 16:
					if (A_0 != null)
					{
						num2 = (short)177995777;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 17:
					num2 = (short)1523712019;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 18:
					num2 = (short)2048851984;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 19:
					if (this.d != global::ASK.Interface.ASK_COMMS_OP.BLUETOOTH_CLONE)
					{
						num2 = (short)1613561892;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 20:
				{
					num2 = (short)1599406080;
					short num3 = num2;
					num2 = (short)822607901;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 21:
					if (A_0.AccessLevelType == global::ASK.Interface.KeyAccessLevelType.UNLM_ACC_WITHOUT_WP)
					{
						num2 = (short)1744371714;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 22:
					if (A_0.AccessLevelType != global::ASK.Interface.KeyAccessLevelType.UNLM_ACC)
					{
						num2 = (short)1119485982;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_575;
				case 23:
					return result;
				case 24:
					num2 = (short)379912227;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 25:
					if (this.b.ProtectionOptn == global::ASK.Interface.ProtectionOption.HARDWARE)
					{
						num2 = (short)1917517824;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_155;
				case 26:
					result = true;
					num2 = (short)1944649741;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 27:
					num2 = (short)910491653;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 28:
					result = false;
					num2 = (short)388956164;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 29:
					if (this.d != global::ASK.Interface.ASK_COMMS_OP.BLUETOOTH_CLONE)
					{
						num2 = (short)1406861318;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 30:
					num2 = (short)1497563157;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 31:
					if (this.c.ProtectionOptn == global::ASK.Interface.ProtectionOption.HARDWARE)
					{
						num2 = (short)1243742241;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 32:
					if (!this.b.ASKRequired)
					{
						goto IL_625;
					}
					return result;
				case 33:
					num2 = (short)1543766060;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 34:
					if (this.b.ASKRequired)
					{
						num2 = (short)1911291946;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_155;
				case 35:
					if (this.b.ProtectionOptn == global::ASK.Interface.ProtectionOption.UNSPECIFIED)
					{
						num2 = (short)416022566;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_449;
				case 36:
					num2 = (short)726663175;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 37:
					flag = true;
					goto IL_363;
				case 38:
					num2 = (short)1426784304;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 39:
					if (this.c.ASKRequired)
					{
						num2 = (short)1201405970;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 40:
					num2 = (short)1463222287;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 41:
					if (this.d != global::ASK.Interface.ASK_COMMS_OP.OTAP_CLONE)
					{
						num2 = (short)175702033;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 42:
					result = true;
					num2 = (short)647626762;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 43:
					num2 = (short)39911463;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 44:
				{
					num2 = (short)285190652;
					short num4 = num2;
					num2 = (short)2018814460;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_625;
					default:
						num2 = (short)1263468544;
						if (num2 != 0)
						{
						}
						if (!this.c.ASKRequired)
						{
							num2 = (short)1907359772;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					}
					break;
				}
				case 45:
					if (this.b.ProtectionOptn == global::ASK.Interface.ProtectionOption.HARDWARE)
					{
						num2 = (short)341180462;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 46:
					num2 = (short)1950089217;
					if (num2 != 0)
					{
					}
					num2 = (short)63045664;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 47:
					if (this.d != global::ASK.Interface.ASK_COMMS_OP.USB_CLONE)
					{
						num2 = (short)1535836200;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 48:
					if (!this.b.IsConventionalOnly)
					{
						num2 = (short)1185873946;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_449;
				}
				goto IL_D4;
				IL_155:
				num2 = (short)1404895277;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_363:
				result = flag;
				num2 = (short)569573399;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_449:
				num2 = (short)364904473;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_575:
				num2 = (short)2133655583;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_625:
				num2 = (short)1219887115;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_D4:
			result = false;
			num2 = (short)680329228;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600003F RID: 63 RVA: 0x000090B8 File Offset: 0x000072B8
		private bool a(global::System.Collections.ObjectModel.ReadOnlyCollection<global::ASK.Interface.ISystemKeyData> A_0, out global::ASKLib.SystemKeyData A_1)
		{
			short num = (short)331087872;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_8B;
				}
				bool result;
				for (;;)
				{
					IL_27:
					num = (short)1260847104;
					short num3 = num;
					switch (num2)
					{
					case 0:
						num = (short)528220172;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_574;
					case 2:
					{
						global::ASKLib.SystemKeyData systemKeyData = null;
						global::System.Collections.Generic.IEnumerator<global::ASK.Interface.ISystemKeyData> enumerator = A_0.GetEnumerator();
						num = (short)1568210947;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						try
						{
							num = (short)874053639;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::System.Collections.Generic.IEnumerator<global::ASK.Interface.ISystemKeyData> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1517748232;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::ASKLib.SystemKeyData systemKeyData2 = (global::ASKLib.SystemKeyData)enumerator.Current;
									global::System.Collections.ObjectModel.Collection<global::ASKLib.TrkSysID> collection;
									global::System.Collections.Generic.IEnumerator<global::ASKLib.TrkSysID> enumerator2 = collection.GetEnumerator();
									num = (short)199360516;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
								{
									global::ASKLib.SystemKeyData systemKeyData;
									if (systemKeyData != null)
									{
										num = (short)1278279685;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
									goto IL_1D9;
								case 3:
									goto IL_502;
								case 4:
									try
									{
										num = (short)1909456903;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												goto IL_3AF;
											case 1:
											{
												global::ASKLib.SystemKeyData systemKeyData2;
												global::ASKLib.TrkSysID trkSysID;
												if (trkSysID.ID == systemKeyData2.SystemID)
												{
													num = (short)1918959622;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											case 2:
											{
												global::ASKLib.SystemKeyData systemKeyData2;
												if (systemKeyData2.WriteProtectEnabled)
												{
													num = (short)1904541706;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											case 3:
											{
												global::ASKLib.SystemKeyData systemKeyData2;
												global::ASKLib.TrkSysID trkSysID;
												if (trkSysID.SystemKeyType == systemKeyData2.Type)
												{
													num = (short)154664965;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											case 4:
												num = (short)1991573504;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 5:
											{
												global::ASKLib.SystemKeyData systemKeyData2;
												global::ASKLib.SystemKeyData systemKeyData = systemKeyData2;
												num = (short)1904803842;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 6:
												num = (short)460128259;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 7:
												switch (0)
												{
												case 0:
													goto IL_261;
												}
												continue;
											case 8:
											{
												global::System.Collections.Generic.IEnumerator<global::ASKLib.TrkSysID> enumerator2;
												if (!enumerator2.MoveNext())
												{
													num = (short)755105796;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												global::ASKLib.TrkSysID trkSysID = enumerator2.Current;
												num = (short)8978433;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 9:
												goto IL_2B5;
											case 10:
												num = (short)1331036169;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											IL_263:
											num = (short)340590600;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_261:
											goto IL_263;
										}
										IL_2B5:
										IL_3AF:;
									}
									finally
									{
										num = (short)1663434753;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												goto IL_44B;
											case 1:
											{
												num = (short)70382111;
												short num4 = num;
												num = (short)2131948063;
												switch ((num4 == num) ? 1 : 0)
												{
												case 0:
												case 2:
													goto IL_44B;
												default:
													num = (short)656146432;
													if (num != 0)
													{
													}
													switch (0)
													{
													case 0:
														goto IL_431;
													}
													continue;
												}
												break;
											}
											case 2:
												goto IL_469;
											}
											IL_431:
											global::System.Collections.Generic.IEnumerator<global::ASKLib.TrkSysID> enumerator2;
											if (enumerator2 != null)
											{
												num = (short)15925248;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											break;
											IL_44B:
											enumerator2.Dispose();
											num = (short)369426434;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_469:;
									}
									num = (short)2083651585;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									num = (short)1512243206;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
								{
									global::ASKLib.SystemKeyData systemKeyData;
									if (systemKeyData.WriteProtectEnabled)
									{
										num = (short)433258505;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 7:
									switch (0)
									{
									case 0:
										goto IL_188;
									}
									continue;
								case 8:
									num = (short)799080451;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
									num = (short)1529479170;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_18A:
								num = (short)605749248;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_188:
								goto IL_18A;
							}
							IL_1D9:
							IL_502:
							goto IL_FB;
						}
						finally
						{
							num = (short)1012662273;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::ASK.Interface.ISystemKeyData> enumerator;
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)192675842;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_53A;
									}
									continue;
								case 2:
									goto IL_571;
								}
								IL_53A:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1128792064;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_571:;
						}
						goto IL_574;
						IL_FB:
						num = (short)995164164;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
					{
						global::ASKLib.SystemKeyData systemKeyData;
						if (systemKeyData != null)
						{
							num = (short)1381564427;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					}
					case 5:
						return result;
					case 6:
					{
						global::System.Collections.ObjectModel.Collection<global::ASKLib.TrkSysID> collection;
						if (collection.Count > 0)
						{
							num = (short)751042560;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					}
					case 7:
					{
						global::System.Collections.ObjectModel.Collection<global::ASKLib.TrkSysID> collection;
						if (collection != null)
						{
							num = (short)403636225;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					}
					case 8:
						return result;
					case 9:
						if (!this.c.IsConventionalOnly)
						{
							num = (short)1543962634;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						result = true;
						num = (short)1784676360;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
					{
						num = (short)674627585;
						if (num != 0)
						{
						}
						global::System.Collections.ObjectModel.Collection<global::ASKLib.TrkSysID> collection = this.e();
						num = (short)932708359;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
					{
						global::ASKLib.SystemKeyData systemKeyData;
						A_1 = systemKeyData;
						result = true;
						num = (short)231538693;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
						if (A_0 != null)
						{
							num = (short)1877409794;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					}
					goto IL_8B;
					IL_574:
					num = (short)1180303366;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_8B:
				result = false;
				A_1 = null;
				num = (short)224264201;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00009794 File Offset: 0x00007994
		private bool c()
		{
			switch (0)
			{
			case 0:
				goto IL_40;
			}
			int num;
			short num2;
			bool result;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (this.b.ProtectionOptn == global::ASK.Interface.ProtectionOption.HARDWARE)
					{
						num2 = (short)17301510;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1F3;
				case 1:
					return result;
				case 2:
					num2 = (short)606273537;
					if (num2 != 0)
					{
					}
					if (!this.b.IsConventionalOnly)
					{
						num2 = (short)1651834887;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 3:
					num2 = (short)1064763392;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					result = true;
					num2 = (short)1154154504;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
				{
					num2 = (short)1047767386;
					short num3 = num2;
					num2 = (short)597338458;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_14D;
					default:
						num2 = (short)2123235328;
						if (num2 != 0)
						{
						}
						if (this.b.ASKRequired)
						{
							num2 = (short)1982660612;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_1F3;
					}
					break;
				}
				case 6:
					num2 = (short)42401797;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					num2 = (short)1830092811;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					return result;
				case 9:
					result = true;
					goto IL_14D;
				case 10:
					if (this.b.WriteProtected)
					{
						num2 = (short)2106785795;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 11:
					if (this.b.ProtectionOptn == global::ASK.Interface.ProtectionOption.UNSPECIFIED)
					{
						num2 = (short)919273481;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				}
				goto IL_40;
				IL_14D:
				num2 = (short)728236033;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_1F3:
				num2 = (short)233635842;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_40:
			result = false;
			num2 = (short)311361536;
			short num4 = num2;
			num2 = (short)2114387978;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00009A00 File Offset: 0x00007C00
		private bool a(int A_0, global::ASK.Interface.KeyType A_1, global::System.Collections.ObjectModel.ReadOnlyCollection<global::ASK.Interface.ISystemKeyData> A_2, out global::ASKLib.SystemKeyData A_3)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			bool result;
			for (;;)
			{
				IL_0A:
				global::System.Collections.Generic.IEnumerator<global::ASK.Interface.ISystemKeyData> enumerator;
				switch (num)
				{
				case 0:
					goto IL_2BF;
				case 1:
					try
					{
						num2 = (short)1111490569;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							global::ASKLib.SystemKeyData systemKeyData;
							switch (num)
							{
							case 0:
								if (systemKeyData.WriteProtectEnabled)
								{
									num2 = (short)1026097155;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								break;
							case 1:
								num2 = (short)1180958720;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 2:
								if (!enumerator.MoveNext())
								{
									num2 = (short)1759379466;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								systemKeyData = (global::ASKLib.SystemKeyData)enumerator.Current;
								num2 = (short)1116340228;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 3:
								goto IL_14E;
							case 4:
								if (A_0 == systemKeyData.SystemID)
								{
									num2 = (short)1590951943;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								break;
							case 5:
								goto IL_16C;
							case 6:
								if (A_1 == systemKeyData.Type)
								{
									num2 = (short)1472736127;
									short num3 = num2;
									num2 = (short)142617471;
									switch ((num3 == num2) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_14E;
									default:
										num2 = (short)1695088640;
										if (num2 != 0)
										{
										}
										num2 = (short)1640759297;
										num = (int)((global::System.IntPtr)num2);
										continue;
									}
								}
								break;
							case 7:
								num2 = (short)1721565190;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 8:
								goto IL_252;
							case 9:
								switch (0)
								{
								case 0:
									goto IL_D0;
								}
								continue;
							case 10:
								num2 = (short)426115080;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							IL_D2:
							num2 = (short)1012662274;
							num = (int)((global::System.IntPtr)num2);
							continue;
							IL_D0:
							goto IL_D2;
							IL_14E:
							A_3 = systemKeyData;
							result = true;
							num2 = (short)2114387973;
							num = (int)((global::System.IntPtr)num2);
						}
						IL_16C:
						IL_252:
						return result;
					}
					finally
					{
						num2 = (short)1447952386;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
								enumerator.Dispose();
								num2 = (short)661454849;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 1:
								goto IL_2BC;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_287;
								}
								continue;
							}
							IL_287:
							if (enumerator == null)
							{
								break;
							}
							num2 = (short)1852637184;
							num = (int)((global::System.IntPtr)num2);
						}
						IL_2BC:;
					}
					goto IL_2BF;
				case 2:
					if (A_2 != null)
					{
						num2 = (short)344784896;
						short num4 = num2;
						num2 = (short)2023292928;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				}
				goto IL_1C;
				IL_2BF:
				num2 = (short)1665728513;
				if (num2 != 0)
				{
				}
				enumerator = A_2.GetEnumerator();
				num2 = (short)1626472449;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_1C:
			result = false;
			A_3 = null;
			num2 = (short)1062273026;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00009D34 File Offset: 0x00007F34
		private bool a(out string A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_2C;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)2092855339;
					short num3 = num2;
					num2 = (short)1767862315;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1B2;
					default:
					{
						num2 = (short)85458944;
						if (num2 != 0)
						{
						}
						num2 = (short)667484160;
						short num4 = num2;
						if (!this.c.WriteProtected)
						{
							num2 = (short)773718017;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return true;
					}
					}
					break;
				}
				case 1:
					this.c.WriteProtected = true;
					this.b(true);
					num2 = (short)311230467;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if (this.f)
					{
						num2 = (short)1855062020;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1B2;
				case 3:
					goto IL_92;
				case 4:
					num2 = (short)1517682688;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					if (this.e)
					{
						num2 = (short)507510790;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 6:
					num2 = (short)1095958530;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_2C;
			}
			IL_92:
			num2 = (short)1921581057;
			if (num2 != 0)
			{
			}
			return true;
			IL_1B2:
			A_0 = global::Motorola.CommonCPS.ResourceRepository.Resources.Write_Radio_Operation_Aborted_WP_Canceled_by_User;
			return false;
			IL_2C:
			A_0 = null;
			num2 = (short)273809413;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00009F00 File Offset: 0x00008100
		private void b()
		{
			int a_ = 13;
			short num = (short)289013760;
			switch (num)
			{
			default:
			{
				num = (short)916717589;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::ASKLib.AstroASKProgrammingHistory astroASKProgrammingHistory;
					global::System.Collections.Generic.SortedList<string, global::ASKLib.ASKProgrammingHistoryItem> sortedList;
					int num4;
					int num5;
					switch (num2)
					{
					case 0:
					{
						int num3;
						if (num3 > 0)
						{
							num = (short)728760331;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7A0;
					}
					case 1:
						num = (short)1413218321;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_7A0;
					case 3:
						astroASKProgrammingHistory.Recset.Clear();
						num = (short)330891277;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (sortedList.Count > 0)
						{
							num = (short)220987406;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2E7;
					case 5:
						goto IL_1F4;
					case 6:
						sortedList.Remove(global::ASKLib.SystemKeyManager.b("곡쯣꟥", a_));
						num = (short)1525153794;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_318;
					case 8:
						if (num4 < 0)
						{
							num = (short)1528692745;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1082064906;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						goto IL_2E7;
					case 10:
						if (num5 < 25)
						{
							num = (short)2025390092;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2E7;
					case 11:
						num = (short)1931345939;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						astroASKProgrammingHistory.Recset.Add(sortedList.Values[num4]);
						num5++;
						num4--;
						num = (short)1951465477;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						goto IL_775;
					case 14:
						num = (short)1047920660;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
					{
						num = (short)1925185536;
						short num6 = num;
						sortedList = new global::System.Collections.Generic.SortedList<string, global::ASKLib.ASKProgrammingHistoryItem>();
						astroASKProgrammingHistory = new global::ASKLib.AstroASKProgrammingHistory(this.c.AskProgLog);
						global::System.Collections.Generic.IEnumerator<global::ASKLib.ASKProgrammingHistoryItem> enumerator = astroASKProgrammingHistory.Recset.GetEnumerator();
						num = (short)2043478038;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 16:
						goto IL_556;
					case 17:
						if (this.g.Count > 0)
						{
							num = (short)143982607;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7E1;
					case 18:
						goto IL_1F4;
					case 19:
						if (sortedList.ContainsKey(global::ASKLib.SystemKeyManager.b("곡쯣꟥", a_)))
						{
							num = (short)317784070;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7A0;
					case 20:
						if (astroASKProgrammingHistory.Recset != null)
						{
							num = (short)58195971;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_775;
					case 21:
						switch (0)
						{
						case 0:
							goto IL_AB;
						}
						continue;
					case 22:
					{
						try
						{
							num = (short)233046021;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::ASKLib.ASKProgrammingHistoryItem askprogrammingHistoryItem;
									sortedList.Add(askprogrammingHistoryItem.LastProgramDateTime, askprogrammingHistoryItem);
									num = (short)1000275974;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
								{
									global::System.Collections.Generic.IEnumerator<global::ASKLib.ASKProgrammingHistoryItem> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1706033154;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::ASKLib.ASKProgrammingHistoryItem askprogrammingHistoryItem = enumerator.Current;
									num = (short)1146028035;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									num = (short)566820868;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
								{
									global::ASKLib.ASKProgrammingHistoryItem askprogrammingHistoryItem;
									if (!sortedList.ContainsKey(askprogrammingHistoryItem.LastProgramDateTime))
									{
										num = (short)402784256;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 4:
									goto IL_497;
								case 5:
									switch (0)
									{
									case 0:
										goto IL_3D2;
									}
									continue;
								}
								IL_442:
								num = (short)248053761;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_3D2:
								goto IL_442;
							}
							IL_497:
							goto IL_27F;
						}
						finally
						{
							num = (short)111017986;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::ASKLib.ASKProgrammingHistoryItem> enumerator;
								switch (num2)
								{
								case 0:
								{
									num = (short)1919868398;
									short num7 = num;
									num = (short)215539182;
									switch ((num7 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_553;
									default:
										num = (short)1297088512;
										if (num != 0)
										{
										}
										enumerator.Dispose();
										num = (short)1131020289;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
									goto IL_553;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_4CE;
									}
									continue;
								}
								IL_4CE:
								if (enumerator == null)
								{
									break;
								}
								num = (short)2017853440;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_553:;
						}
						goto Block_8;
						IL_27F:
						int num3 = 0;
						global::System.Collections.Generic.IEnumerator<string> enumerator2 = this.g.GetEnumerator();
						num = (short)1557397520;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_AB:
					if (this.g != null)
					{
						num = (short)1104412673;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_1F4:
					num = (short)1628962824;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2E7:
					this.c.AskProgLog = astroASKProgrammingHistory.a();
					this.b(true);
					num = (short)1611661319;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					Block_8:
					try
					{
						IL_556:
						num = (short)2122514438;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							int num3;
							switch (num2)
							{
							case 1:
							{
								string text;
								global::ASKLib.ASKProgrammingHistoryItem askprogrammingHistoryItem2;
								sortedList.Add(text, askprogrammingHistoryItem2);
								num = (short)122093575;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 2:
							{
								global::System.Collections.Generic.IEnumerator<string> enumerator2;
								if (!enumerator2.MoveNext())
								{
									num = (short)1510408195;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								string text2 = enumerator2.Current;
								global::ASKLib.ASKProgrammingHistoryItem askprogrammingHistoryItem2 = new global::ASKLib.ASKProgrammingHistoryItem();
								askprogrammingHistoryItem2.SerialNumber = text2.ToUpper();
								string text = global::System.DateTime.UtcNow.AddTicks((long)num3).ToString(global::ASKLib.SystemKeyManager.b("귡", a_));
								askprogrammingHistoryItem2.LastProgramDateTime = text;
								num = (short)1433141252;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 3:
								num = (short)1919614981;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
							{
								string text;
								if (!sortedList.ContainsKey(text))
								{
									num = (short)2070216705;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_694;
							}
							case 5:
								goto IL_6CA;
							case 6:
								switch (0)
								{
								case 0:
									goto IL_59C;
								}
								continue;
							case 7:
								goto IL_694;
							}
							IL_654:
							num = (short)1010434050;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_59C:
							goto IL_654;
							IL_694:
							num3++;
							num = (short)609091584;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_6CA:;
					}
					finally
					{
						num = (short)1854930946;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							global::System.Collections.Generic.IEnumerator<string> enumerator2;
							switch (num2)
							{
							case 0:
								enumerator2.Dispose();
								num = (short)1285685249;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								goto IL_738;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_6FE;
								}
								continue;
							}
							IL_6FE:
							if (enumerator2 == null)
							{
								break;
							}
							num = (short)1186004992;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_738:;
					}
					num = (short)1704263680;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_775:
					num5 = 0;
					num4 = sortedList.Count - 1;
					num = (short)1247412242;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_7A0:
					num = (short)1788149764;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_318:
				IL_7E1:
				num = (short)327024641;
				if (num != 0)
				{
				}
				return;
			}
			}
		}

		// Token: 0x06000044 RID: 68 RVA: 0x0000A74C File Offset: 0x0000894C
		private void a()
		{
			short num = (short)1307115520;
			switch (num)
			{
			default:
			{
				num = (short)1807548416;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)1338376192;
					short num3 = num;
					num = (short)1174732801;
					if (num != 0)
					{
					}
					num = (short)766450927;
					short num4 = num;
					num = (short)66591983;
					global::System.Collections.Generic.List<global::ASK.Interface.IAskSystem> systems;
					global::System.Collections.Generic.List<global::ASK.Interface.IAskSystem>.Enumerator enumerator;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)957022208;
						if (num != 0)
						{
						}
						switch (num2)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_F4;
							}
							continue;
						case 1:
							if (this.c.Is800MHzBandEnabled)
							{
								num = (short)1196163075;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						case 2:
							num = (short)1472987137;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							goto IL_462;
						case 4:
							try
							{
								num = (short)1667039243;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										num = (short)450363393;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										goto IL_44F;
									case 2:
									{
										global::ASKLib.AskSystem askSystem;
										if (askSystem.SystemType == global::ASK.Interface.AskSystemType.TRUNCKING)
										{
											num = (short)266666001;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 3:
										num = (short)210239504;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 4:
									{
										int systemId;
										if (this.h.IsSystemKeyLoaded(systemId, global::ASK.Interface.KeyType.ADVANCED_SYSTEM_KEY, true))
										{
											num = (short)1375600643;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)939851782;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 6:
									{
										global::ASKLib.AskSystem askSystem;
										if (askSystem.ShuffledBandPlan)
										{
											num = (short)343146516;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 7:
									{
										int systemId;
										if (this.a(systemId, systems))
										{
											num = (short)862257170;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)2094333956;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 8:
									{
										global::ASKLib.AskSystem askSystem;
										int systemId = askSystem.SystemId;
										num = (short)1172766727;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 10:
									{
										global::ASKLib.AskSystem askSystem;
										if (askSystem.SystemSubType == global::ASK.Interface.AskSystemSubType.TYPEII)
										{
											num = (short)898695176;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 11:
										switch (0)
										{
										case 0:
											goto IL_19C;
										}
										continue;
									case 12:
									{
										if (!enumerator.MoveNext())
										{
											num = (short)1994326016;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::ASKLib.AskSystem askSystem = (global::ASKLib.AskSystem)enumerator.Current;
										num = (short)1042219010;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 14:
									{
										global::ASKLib.AskSystem askSystem;
										if (!askSystem.ShuffledBandPlan)
										{
											num = (short)1227030547;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 15:
									{
										global::ASKLib.AskSystem askSystem;
										askSystem.ShuffledBandPlan = true;
										this.b(true);
										num = (short)32702473;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 16:
									{
										global::ASKLib.AskSystem askSystem;
										if (!askSystem.ShuffledBandPlan)
										{
											num = (short)138870799;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 17:
										num = (short)1059192842;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 18:
										num = (short)1811677198;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 19:
									{
										global::ASKLib.AskSystem askSystem;
										askSystem.ShuffledBandPlan = true;
										this.b(true);
										num = (short)634191877;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 20:
									{
										global::ASKLib.AskSystem askSystem;
										askSystem.ShuffledBandPlan = false;
										this.b(true);
										num = (short)1888288781;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									}
									IL_204:
									num = (short)389021708;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_19C:
									goto IL_204;
								}
								IL_44F:
								return;
							}
							finally
							{
								((global::System.IDisposable)enumerator).Dispose();
							}
							goto IL_462;
						}
						IL_F4:
						if (!this.c.IsConventionalOnly)
						{
							num = (short)1790902274;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					IL_462:
					global::System.Collections.Generic.List<global::ASK.Interface.IAskSystem> systems2 = this.c.Systems;
					systems = this.b.Systems;
					enumerator = systems2.GetEnumerator();
					num = (short)1261502468;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
			}
			}
		}

		// Token: 0x06000045 RID: 69 RVA: 0x0000AC54 File Offset: 0x00008E54
		private bool a(int A_0, global::System.Collections.Generic.List<global::ASK.Interface.IAskSystem> A_1)
		{
			bool result;
			for (;;)
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				short num2;
				for (;;)
				{
					IL_0A:
					int num;
					global::System.Collections.Generic.List<global::ASK.Interface.IAskSystem>.Enumerator enumerator;
					switch (num)
					{
					case 0:
						if (A_1 != null)
						{
							num2 = (short)1653735426;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					case 1:
						try
						{
							num2 = (short)1955921923;
							num = (int)((global::System.IntPtr)num2);
							for (;;)
							{
								switch (num)
								{
								case 0:
								{
									global::ASKLib.AskSystem askSystem;
									if (askSystem.SystemSubType == global::ASK.Interface.AskSystemSubType.TYPEII)
									{
										num2 = (short)1778974725;
										num = (int)((global::System.IntPtr)num2);
										continue;
									}
									break;
								}
								case 1:
								{
									global::ASKLib.AskSystem askSystem;
									if (askSystem.SystemType == global::ASK.Interface.AskSystemType.TRUNCKING)
									{
										num2 = (short)1707081730;
										num = (int)((global::System.IntPtr)num2);
										continue;
									}
									break;
								}
								case 2:
									num2 = (short)1701969920;
									num = (int)((global::System.IntPtr)num2);
									continue;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_14C;
									}
									continue;
								case 4:
									goto IL_169;
								case 5:
									num2 = (short)1403781131;
									num = (int)((global::System.IntPtr)num2);
									continue;
								case 6:
								{
									if (!enumerator.MoveNext())
									{
										num2 = (short)1457782796;
										num = (int)((global::System.IntPtr)num2);
										continue;
									}
									global::ASKLib.AskSystem askSystem = (global::ASKLib.AskSystem)enumerator.Current;
									num2 = (short)1595408385;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								case 7:
									goto IL_2C2;
								case 8:
								{
									global::ASKLib.AskSystem askSystem;
									if (askSystem.ShuffledBandPlan)
									{
										num2 = (short)127729674;
										num = (int)((global::System.IntPtr)num2);
										continue;
									}
									break;
								}
								case 9:
									num2 = (short)691142664;
									num = (int)((global::System.IntPtr)num2);
									continue;
								case 10:
									result = true;
									num2 = (short)1796407300;
									num = (int)((global::System.IntPtr)num2);
									continue;
								case 11:
								{
									global::ASKLib.AskSystem askSystem;
									if (askSystem.SystemId == A_0)
									{
										num2 = (short)59244553;
										num = (int)((global::System.IntPtr)num2);
										continue;
									}
									break;
								}
								case 12:
									num2 = (short)876871687;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								IL_1F0:
								num2 = (short)767950854;
								num = (int)((global::System.IntPtr)num2);
								continue;
								IL_14C:
								goto IL_1F0;
							}
							IL_169:
							IL_2C2:
							return result;
						}
						finally
						{
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_2D2;
					case 2:
						goto IL_2D2;
					}
					break;
					IL_2D2:
					enumerator = A_1.GetEnumerator();
					num2 = (short)1155989505;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_1C:
				num2 = (short)949288961;
				if (num2 != 0)
				{
				}
				num2 = (short)1917386752;
				short num3 = num2;
				num2 = (short)28513627;
				short num4 = num2;
				num2 = (short)710153563;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num2 = (short)719716352;
					if (num2 != 0)
					{
					}
					result = false;
					num2 = (short)357105664;
					int num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				}
			}
			return result;
		}

		// Token: 0x04000018 RID: 24
		protected const int a = 25;

		// Token: 0x04000019 RID: 25
		protected readonly global::ASK.Interface.IRadioSecurityData b;

		// Token: 0x0400001A RID: 26
		protected global::ASK.Interface.IRadioSecurityData c;

		// Token: 0x0400001B RID: 27
		protected global::ASK.Interface.ASK_COMMS_OP d;

		// Token: 0x0400001C RID: 28
		protected bool e;

		// Token: 0x0400001D RID: 29
		protected bool f;

		// Token: 0x0400001E RID: 30
		protected global::System.Collections.ObjectModel.Collection<string> g;

		// Token: 0x0400001F RID: 31
		private global::ASK.Interface.ISystemKeyManager h;

		// Token: 0x04000020 RID: 32
		private bool i;

		// Token: 0x04000021 RID: 33
		private bool j;

		// Token: 0x04000022 RID: 34
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool k;
	}
}
