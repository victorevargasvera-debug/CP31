using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Motorola.Common.Communication.CommonUtil;

namespace Motorola.Common.Communication.DeviceDiscovery
{
	// Token: 0x02000032 RID: 50
	public class UDPDeviceManager
	{
		// Token: 0x06000142 RID: 322 RVA: 0x00017840 File Offset: 0x00015A40
		private UDPDeviceManager()
		{
			this.b = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile>();
			this.c = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.AuthenticationInfo>();
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000143 RID: 323 RVA: 0x0001786C File Offset: 0x00015A6C
		public static global::Motorola.Common.Communication.DeviceDiscovery.UDPDeviceManager Instance
		{
			get
			{
				short num = (short)1406480119;
				short num2 = num;
				num = (short)934227703;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)2110849024;
					if (num != 0)
					{
					}
					num = (short)39911425;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							global::Motorola.Common.Communication.DeviceDiscovery.UDPDeviceManager.a = new global::Motorola.Common.Communication.DeviceDiscovery.UDPDeviceManager();
							num = (short)505937922;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_7B;
							}
							continue;
						case 2:
							goto IL_E0;
						}
						IL_7B:
						if (global::Motorola.Common.Communication.DeviceDiscovery.UDPDeviceManager.a != null)
						{
							goto IL_10A;
						}
						num = (short)166920193;
						if (num != 0)
						{
						}
						num = (short)48562176;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_E0:
					num = (short)284033024;
					short num4 = num;
					break;
				}
				}
				IL_10A:
				return global::Motorola.Common.Communication.DeviceDiscovery.UDPDeviceManager.a;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000144 RID: 324 RVA: 0x00017988 File Offset: 0x00015B88
		public global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.AuthenticationInfo> Passwords
		{
			get
			{
				short num = (short)1824213534;
				short num2 = num;
				num = (short)1458391582;
				switch (num2 == num)
				{
				}
				num = (short)1606156288;
				short num3 = num;
				num = (short)12517377;
				if (num != 0)
				{
				}
				num = (short)966066176;
				if (num != 0)
				{
				}
				return this.c;
			}
		}

		// Token: 0x06000145 RID: 325 RVA: 0x00017A3C File Offset: 0x00015C3C
		public void UpdatePasswords(global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.AuthenticationInfo> psws)
		{
			short num = (short)1179254785;
			if (num != 0)
			{
			}
			num = (short)1116753104;
			short num2 = num;
			num = (short)1276464336;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1666973696;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)336527360;
			if (num != 0)
			{
			}
			this.c.Clear();
			this.c.AddRange(psws);
		}

		// Token: 0x06000146 RID: 326 RVA: 0x00017AFC File Offset: 0x00015CFC
		public bool AddProfile(global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile profile)
		{
			global::Motorola.Common.Communication.DeviceDiscovery.UDPDeviceManager.a a = new global::Motorola.Common.Communication.DeviceDiscovery.UDPDeviceManager.a();
			a.a = profile;
			if (this.b.Count(new global::System.Func<global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile, bool>(a.b)) == 0)
			{
				short num = (short)1586763502;
				short num2 = num;
				num = (short)368776942;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return false;
				case 1:
					break;
				default:
				{
					num = (short)1950416896;
					short num3 = num;
					break;
				}
				}
				num = (short)1413545985;
				if (num != 0)
				{
				}
				num = (short)1518338048;
				if (num != 0)
				{
				}
				this.b.Add(a.a);
				return true;
			}
			return false;
		}

		// Token: 0x06000147 RID: 327 RVA: 0x00017BE0 File Offset: 0x00015DE0
		public global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile GetByDomainName(string domain)
		{
			global::Motorola.Common.Communication.DeviceDiscovery.UDPDeviceManager.b b = new global::Motorola.Common.Communication.DeviceDiscovery.UDPDeviceManager.b();
			b.a = domain;
			if (this.b.Count(new global::System.Func<global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile, bool>(b.b)) > 0)
			{
				short num = (short)879629940;
				short num2 = num;
				num = (short)854464116;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_E0;
				case 1:
					break;
				default:
				{
					num = (short)1076101120;
					short num3 = num;
					break;
				}
				}
				num = (short)975044609;
				if (num != 0)
				{
				}
				num = (short)1379860480;
				if (num != 0)
				{
				}
				return this.b.First(new global::System.Func<global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile, bool>(b.c));
			}
			IL_E0:
			return null;
		}

		// Token: 0x06000148 RID: 328 RVA: 0x00017CD0 File Offset: 0x00015ED0
		public bool ContainsProfile(string id)
		{
			global::Motorola.Common.Communication.DeviceDiscovery.UDPDeviceManager.c c = new global::Motorola.Common.Communication.DeviceDiscovery.UDPDeviceManager.c();
			c.a = id;
			if (this.b.Count(new global::System.Func<global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile, bool>(c.b)) > 0)
			{
				short num = (short)1939406849;
				if (num != 0)
				{
				}
				num = (short)1542979584;
				short num2 = num;
				num = (short)828403526;
				short num3 = num;
				num = (short)1791979334;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)107675648;
					if (num != 0)
					{
					}
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000149 RID: 329 RVA: 0x00017DAC File Offset: 0x00015FAC
		public void Remove(global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile profile)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			short num2;
			global::Motorola.Common.Communication.DeviceDiscovery.UDPDeviceManager.d d;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					return;
				case 1:
					num2 = (short)921436164;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
				{
					num2 = (short)51941554;
					short num3 = num2;
					num2 = (short)1839894706;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_14D;
					default:
					{
						num2 = (short)689569792;
						if (num2 != 0)
						{
						}
						global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile udpradioProfile = this.b.First(new global::System.Func<global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile, bool>(d.c));
						udpradioProfile.UniqueIndendifier = null;
						udpradioProfile.HostDetector.a(udpradioProfile);
						num2 = (short)1918566400;
						short num4 = num2;
						num2 = (short)845676544;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 3:
					num2 = (short)498139137;
					if (num2 != 0)
					{
					}
					if (d.a.DeviceConnectionMode == global::Motorola.Common.Communication.DeviceDiscovery.UDPDeviceConnectionMode.Wired)
					{
						num2 = (short)108068865;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 4:
					if (this.b.Count(new global::System.Func<global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile, bool>(d.b)) > 0)
					{
						goto IL_14D;
					}
					return;
				}
				goto IL_24;
				IL_14D:
				num2 = (short)186253314;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_24:
			d = new global::Motorola.Common.Communication.DeviceDiscovery.UDPDeviceManager.d();
			d.a = profile;
			this.b.Remove(d.a);
			num2 = (short)784531459;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600014A RID: 330 RVA: 0x00017F70 File Offset: 0x00016170
		public void DetachDevice(global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile profile)
		{
			short num = (short)2134290305;
			short num2 = num;
			num = (short)714125185;
			switch (num2 == num)
			{
			}
			num = (short)341901312;
			short num3 = num;
			num = (short)1102053377;
			if (num != 0)
			{
			}
			num = (short)925237248;
			if (num != 0)
			{
			}
			profile.HostDetector.b(profile);
			this.Remove(profile);
		}

		// Token: 0x0600014B RID: 331 RVA: 0x0001802C File Offset: 0x0001622C
		public void DetachDevice(string identifier)
		{
			short num = (short)1396572161;
			if (num != 0)
			{
			}
			num = (short)466413913;
			short num2 = num;
			num = (short)1446766937;
			global::Motorola.Common.Communication.DeviceDiscovery.UDPDeviceManager.e e;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_AF:
				if (this.b.Count(new global::System.Func<global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile, bool>(e.b)) <= 0)
				{
					return;
				}
				num = (short)1320288256;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)993132544;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_8E;
				}
				break;
			}
			for (;;)
			{
				IL_7C:
				switch (num3)
				{
				case 0:
				{
					global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile udpradioProfile = this.b.First(new global::System.Func<global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile, bool>(e.c));
					udpradioProfile.HostDetector.b(udpradioProfile);
					this.b.RemoveAll(new global::System.Predicate<global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile>(e.d));
					num = (short)1087373314;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					goto IL_AF;
				case 2:
					goto IL_136;
				}
				goto IL_8E;
			}
			IL_136:
			num = (short)1164509184;
			short num4 = num;
			return;
			IL_8E:
			e = new global::Motorola.Common.Communication.DeviceDiscovery.UDPDeviceManager.e();
			e.a = identifier;
			num = (short)113442817;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_7C;
		}

		// Token: 0x040000B8 RID: 184
		private static global::Motorola.Common.Communication.DeviceDiscovery.UDPDeviceManager a;

		// Token: 0x040000B9 RID: 185
		private global::System.Collections.Generic.List<global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile> b;

		// Token: 0x040000BA RID: 186
		private global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.AuthenticationInfo> c;

		// Token: 0x02000033 RID: 51
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class a
		{
			// Token: 0x0600014D RID: 333 RVA: 0x000181B0 File Offset: 0x000163B0
			internal bool b(global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile A_0)
			{
				if (A_0.IPAddress == this.a.IPAddress)
				{
					short num = (short)1183875385;
					short num2 = num;
					num = (short)2089976121;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return false;
					case 1:
						break;
					default:
					{
						num = (short)1214840832;
						short num3 = num;
						break;
					}
					}
					num = (short)890634241;
					if (num != 0)
					{
					}
					num = (short)893779968;
					if (num != 0)
					{
					}
					return string.IsNullOrEmpty(A_0.UniqueIndendifier);
				}
				return false;
			}

			// Token: 0x040000BB RID: 187
			public global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile a;
		}

		// Token: 0x02000034 RID: 52
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class b
		{
			// Token: 0x0600014F RID: 335 RVA: 0x00018298 File Offset: 0x00016498
			internal bool b(global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile A_0)
			{
				if (A_0.DomainName == this.a)
				{
					short num = (short)589893915;
					short num2 = num;
					num = (short)423498011;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return false;
					case 1:
						break;
					default:
					{
						num = (short)84606976;
						short num3 = num;
						break;
					}
					}
					num = (short)1563820033;
					if (num != 0)
					{
					}
					num = (short)1465122816;
					if (num != 0)
					{
					}
					return A_0.DeviceConnectionMode == global::Motorola.Common.Communication.DeviceDiscovery.UDPDeviceConnectionMode.Wireless;
				}
				return false;
			}

			// Token: 0x06000150 RID: 336 RVA: 0x00018360 File Offset: 0x00016560
			internal bool c(global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile A_0)
			{
				short num = (short)1233190913;
				if (num != 0)
				{
				}
				if (A_0.DomainName == this.a)
				{
					num = (short)1761804288;
					short num2 = num;
					num = (short)1910650495;
					short num3 = num;
					num = (short)1225406079;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1037369344;
						if (num != 0)
						{
						}
						return A_0.DeviceConnectionMode == global::Motorola.Common.Communication.DeviceDiscovery.UDPDeviceConnectionMode.Wireless;
					}
				}
				return false;
			}

			// Token: 0x040000BC RID: 188
			public string a;
		}

		// Token: 0x02000035 RID: 53
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class c
		{
			// Token: 0x06000152 RID: 338 RVA: 0x00018444 File Offset: 0x00016644
			internal bool b(global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile A_0)
			{
				short num = (short)1846729700;
				short num2 = num;
				num = (short)2019810276;
				switch (num2 == num)
				{
				}
				num = (short)168099840;
				short num3 = num;
				num = (short)1997930496;
				if (num != 0)
				{
				}
				num = (short)2079522817;
				if (num != 0)
				{
				}
				return A_0.UniqueIndendifier == this.a;
			}

			// Token: 0x040000BD RID: 189
			public string a;
		}

		// Token: 0x02000036 RID: 54
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class d
		{
			// Token: 0x06000154 RID: 340 RVA: 0x00018514 File Offset: 0x00016714
			internal bool b(global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile A_0)
			{
				if (A_0.DeviceConnectionMode == global::Motorola.Common.Communication.DeviceDiscovery.UDPDeviceConnectionMode.Wireless)
				{
					short num = (short)1616013741;
					short num2 = num;
					num = (short)1862298029;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return false;
					case 1:
						break;
					default:
					{
						num = (short)404750336;
						short num3 = num;
						break;
					}
					}
					num = (short)349241344;
					if (num != 0)
					{
					}
					num = (short)1861287937;
					if (num != 0)
					{
					}
					return A_0.UniqueIndendifier == this.a.UniqueIndendifier;
				}
				return false;
			}

			// Token: 0x06000155 RID: 341 RVA: 0x000185E0 File Offset: 0x000167E0
			internal bool c(global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile A_0)
			{
				if (A_0.DeviceConnectionMode == global::Motorola.Common.Communication.DeviceDiscovery.UDPDeviceConnectionMode.Wireless)
				{
					short num = (short)1250576990;
					short num2 = num;
					num = (short)1669810782;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return false;
					case 1:
						break;
					default:
					{
						num = (short)458031104;
						short num3 = num;
						break;
					}
					}
					num = (short)424345601;
					if (num != 0)
					{
					}
					num = (short)486408192;
					if (num != 0)
					{
					}
					return A_0.UniqueIndendifier == this.a.UniqueIndendifier;
				}
				return false;
			}

			// Token: 0x040000BE RID: 190
			public global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile a;
		}

		// Token: 0x02000037 RID: 55
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class e
		{
			// Token: 0x06000157 RID: 343 RVA: 0x000186C4 File Offset: 0x000168C4
			internal bool b(global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile A_0)
			{
				short num = (short)1193513878;
				short num2 = num;
				num = (short)418419606;
				switch (num2 == num)
				{
				}
				num = (short)847314944;
				short num3 = num;
				num = (short)1520828417;
				if (num != 0)
				{
				}
				num = (short)1714946048;
				if (num != 0)
				{
				}
				return A_0.UniqueIndendifier == this.a;
			}

			// Token: 0x06000158 RID: 344 RVA: 0x0001877C File Offset: 0x0001697C
			internal bool c(global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile A_0)
			{
				short num = (short)1972226538;
				short num2 = num;
				num = (short)460573162;
				switch (num2 == num)
				{
				}
				num = (short)1803681792;
				short num3 = num;
				num = (short)1670971393;
				if (num != 0)
				{
				}
				num = (short)365887488;
				if (num != 0)
				{
				}
				return A_0.UniqueIndendifier == this.a;
			}

			// Token: 0x06000159 RID: 345 RVA: 0x00018838 File Offset: 0x00016A38
			internal bool d(global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile A_0)
			{
				short num = (short)814434532;
				short num2 = num;
				num = (short)1473857764;
				switch (num2 == num)
				{
				}
				num = (short)1648885760;
				short num3 = num;
				num = (short)237436928;
				if (num != 0)
				{
				}
				num = (short)1757020161;
				if (num != 0)
				{
				}
				return A_0.UniqueIndendifier == this.a;
			}

			// Token: 0x040000BF RID: 191
			public string a;
		}
	}
}
