using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using Motorola.Common.Communication.CommonUtil;

namespace Motorola.Common.Communication.DeviceDiscovery
{
	// Token: 0x02000013 RID: 19
	public class LDTDetectorBase : global::Motorola.Common.Communication.DeviceDiscovery.IDeviceDetector
	{
		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600007F RID: 127 RVA: 0x0000CC54 File Offset: 0x0000AE54
		public global::Motorola.Common.Communication.DeviceDiscovery.DeviceDetectorType DetectorType
		{
			get
			{
				short num = (short)284878257;
				short num2 = num;
				num = (short)1979901361;
				switch (num2 == num)
				{
				}
				num = (short)397017089;
				if (num != 0)
				{
				}
				num = (short)1256783872;
				short num3 = num;
				num = (short)1950613504;
				if (num != 0)
				{
				}
				return this._detectorType;
			}
		}

		// Token: 0x06000080 RID: 128 RVA: 0x0000CD04 File Offset: 0x0000AF04
		public virtual bool Start()
		{
			short num = (short)1368869877;
			short num2 = num;
			num = (short)272714741;
			switch (num2 == num)
			{
			}
			num = (short)666763264;
			if (num != 0)
			{
			}
			num = (short)346423296;
			short num3 = num;
			num = (short)861143041;
			if (num != 0)
			{
			}
			return true;
		}

		// Token: 0x06000081 RID: 129 RVA: 0x0000CDB0 File Offset: 0x0000AFB0
		public virtual void Stop()
		{
			short num = (short)521469953;
			if (num != 0)
			{
			}
			num = (short)1027555730;
			short num2 = num;
			num = (short)163791250;
			switch (num2 == num)
			{
			}
			num = (short)1713045504;
			short num3 = num;
			num = (short)1677656064;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000082 RID: 130 RVA: 0x0000CE5C File Offset: 0x0000B05C
		internal void b(global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile A_0)
		{
			int a_ = 16;
			switch (0)
			{
			case 0:
				goto IL_25;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					return;
				case 1:
					if (this.a != null)
					{
						num2 = (short)1382940674;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 2:
				{
					num2 = (short)370933761;
					if (num2 != 0)
					{
					}
					num2 = (short)839385088;
					short num3 = num2;
					global::Motorola.Common.Communication.DeviceDiscovery.DeviceMsgEventArgs deviceMsgEventArgs = new global::Motorola.Common.Communication.DeviceDiscovery.DeviceMsgEventArgs();
					deviceMsgEventArgs.PnPAction = global::Motorola.Common.Communication.DeviceDiscovery.DevPnPAction.DeviceAttached;
					deviceMsgEventArgs.RadioInfoSet.Add(A_0);
					this.a(this, deviceMsgEventArgs);
					num2 = (short)776994928;
					short num4 = num2;
					num2 = (short)1893793904;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
						num2 = (short)1968308224;
						if (num2 != 0)
						{
						}
						num2 = (short)435814400;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				}
				goto IL_25;
			}
			return;
			IL_25:
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("୎ὐR硔іᵘ慚絜ᅞѠᑢ䕤ͦ౨ᵪѬ౮ᑰ卲ɴṶ൸፺嵼㙾톀슂ﮈﺌﲎꮐ뎒ꦔꦘꎜ뾞삠춢솤螦直캪\udfac욮킰\udfb2﮴슶풸\ud9ba\ud8bc춾﯀뻄듈賌ꯎ뗐뛒뇔", a_), new object[]
			{
				A_0.IPAddress,
				A_0.RadioSerialNumber
			});
			num2 = (short)1006370817;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000083 RID: 131 RVA: 0x0000CFD0 File Offset: 0x0000B1D0
		internal void c(global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile A_0)
		{
			int a_ = 4;
			switch (0)
			{
			case 0:
				goto IL_25;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					goto IL_13D;
				case 1:
					if (this.b != null)
					{
						num2 = (short)1823342594;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_13F;
				case 2:
				{
					num2 = (short)655818752;
					short num3 = num2;
					global::Motorola.Common.Communication.DeviceDiscovery.DeviceMsgEventArgs deviceMsgEventArgs = new global::Motorola.Common.Communication.DeviceDiscovery.DeviceMsgEventArgs();
					deviceMsgEventArgs.PnPAction = global::Motorola.Common.Communication.DeviceDiscovery.DevPnPAction.DeviceDetached;
					deviceMsgEventArgs.RadioInfoSet.Add(A_0);
					this.b(this, deviceMsgEventArgs);
					num2 = (short)997705256;
					short num4 = num2;
					num2 = (short)1957283368;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_13F;
					default:
						num2 = (short)1874853888;
						if (num2 != 0)
						{
						}
						num2 = (short)141688832;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				}
				goto IL_25;
			}
			IL_13D:
			IL_13F:
			num2 = (short)895877121;
			if (num2 != 0)
			{
			}
			return;
			IL_25:
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("݂ୄᑆ摈ᡊौ畎煐ᝒご⅖じ㡚㡜罞ᙠ੢ᅤས䥨≪㵬⹮ᕰᝲݴቶ੸ࡺ䝼彾부떄惘랈ꮊ뎒요ﲜ횢좤얦첨\ud9aa鞬辮쪰芲좴鞶\udeba킼킾럀ꛂꇄ", a_), new object[]
			{
				A_0.IPAddress,
				A_0.RadioSerialNumber
			});
			num2 = (short)1269497857;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000084 RID: 132 RVA: 0x0000D144 File Offset: 0x0000B344
		internal void d(global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			global::Motorola.Common.Communication.DeviceDiscovery.LDTDetectorBase.a a;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (global::Motorola.Common.Communication.DeviceDiscovery.LDTDetectorBase._arrivedDevices.Count(new global::System.Func<global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile, bool>(a.b)) > 0)
					{
						num2 = (short)38469634;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 1:
					if (a.a.ConnectMode == global::Motorola.Common.Communication.DeviceDiscovery.LDTConnectMode.USB)
					{
						num2 = (short)665714691;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 2:
				{
					num2 = (short)1188013422;
					short num3 = num2;
					num2 = (short)538158446;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
					{
						num2 = (short)1236467712;
						if (num2 != 0)
						{
						}
						num2 = (short)2028339200;
						short num4 = num2;
						global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile ldtradioProfile = global::Motorola.Common.Communication.DeviceDiscovery.LDTDetectorBase._arrivedDevices.First(new global::System.Func<global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile, bool>(a.c));
						ldtradioProfile.IMEI = null;
						this.b(ldtradioProfile);
						num2 = (short)1367801860;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 3:
					num2 = (short)1262288896;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					goto IL_12E;
				}
				goto IL_24;
			}
			IL_12E:
			num2 = (short)1540358145;
			if (num2 != 0)
			{
			}
			return;
			IL_24:
			a = new global::Motorola.Common.Communication.DeviceDiscovery.LDTDetectorBase.a();
			a.a = A_0;
			global::Motorola.Common.Communication.DeviceDiscovery.LDTDetectorBase._arrivedDevices.Remove(a.a);
			num2 = (short)1450901505;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x06000085 RID: 133 RVA: 0x0000D2F4 File Offset: 0x0000B4F4
		// (remove) Token: 0x06000086 RID: 134 RVA: 0x0000D430 File Offset: 0x0000B630
		public event global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler deviceAttached
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler deviceEventHandler;
				short num2;
				for (;;)
				{
					IL_0A:
					global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler deviceEventHandler2;
					switch (num)
					{
					case 0:
						return;
					case 1:
						goto IL_63;
					case 2:
					{
						if (deviceEventHandler != deviceEventHandler2)
						{
							goto IL_63;
						}
						num2 = (short)1082011377;
						short num3 = num2;
						num2 = (short)135933681;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							return;
						default:
							num2 = (short)266534912;
							if (num2 != 0)
							{
							}
							num2 = (short)1865089024;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					}
					goto IL_1C;
					IL_63:
					deviceEventHandler2 = deviceEventHandler;
					global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler value2 = (global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler)global::System.Delegate.Combine(deviceEventHandler2, value);
					deviceEventHandler = global::System.Threading.Interlocked.CompareExchange<global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler>(ref this.a, value2, deviceEventHandler2);
					num2 = (short)1970208768;
					short num4 = num2;
					num2 = (short)1549074434;
					num = (int)((global::System.IntPtr)num2);
				}
				return;
				IL_1C:
				deviceEventHandler = this.a;
				num2 = (short)1208418305;
				if (num2 != 0)
				{
				}
				num2 = (short)40566785;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				short num2;
				global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler deviceEventHandler;
				for (;;)
				{
					IL_0A:
					global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler deviceEventHandler2;
					switch (num)
					{
					case 0:
						return;
					case 1:
						goto IL_39;
					case 2:
					{
						num2 = (short)1870331904;
						short num3 = num2;
						if (deviceEventHandler != deviceEventHandler2)
						{
							goto IL_39;
						}
						num2 = (short)297274360;
						short num4 = num2;
						num2 = (short)1482230776;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							return;
						default:
							num2 = (short)128253953;
							if (num2 != 0)
							{
							}
							num2 = (short)916455424;
							if (num2 != 0)
							{
							}
							num2 = (short)794361856;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					}
					goto IL_1C;
					IL_39:
					deviceEventHandler2 = deviceEventHandler;
					global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler value2 = (global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler)global::System.Delegate.Remove(deviceEventHandler2, value);
					deviceEventHandler = global::System.Threading.Interlocked.CompareExchange<global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler>(ref this.a, value2, deviceEventHandler2);
					num2 = (short)1710096386;
					num = (int)((global::System.IntPtr)num2);
				}
				return;
				IL_1C:
				deviceEventHandler = this.a;
				num2 = (short)238092289;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x06000087 RID: 135 RVA: 0x0000D564 File Offset: 0x0000B764
		// (remove) Token: 0x06000088 RID: 136 RVA: 0x0000D698 File Offset: 0x0000B898
		public event global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler deviceDetached
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				short num2;
				global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler deviceEventHandler;
				for (;;)
				{
					IL_0A:
					global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler deviceEventHandler2;
					switch (num)
					{
					case 0:
						goto IL_FC;
					case 1:
						goto IL_3A;
					case 2:
					{
						num2 = (short)2097217536;
						short num3 = num2;
						if (deviceEventHandler != deviceEventHandler2)
						{
							goto IL_3A;
						}
						num2 = (short)925823351;
						short num4 = num2;
						num2 = (short)1954017655;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							return;
						default:
							num2 = (short)1376845824;
							if (num2 != 0)
							{
							}
							num2 = (short)34013184;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					}
					goto IL_1C;
					IL_3A:
					deviceEventHandler2 = deviceEventHandler;
					global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler value2 = (global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler)global::System.Delegate.Combine(deviceEventHandler2, value);
					deviceEventHandler = global::System.Threading.Interlocked.CompareExchange<global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler>(ref this.b, value2, deviceEventHandler2);
					num2 = (short)2094071810;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_FC:
				num2 = (short)1048182785;
				if (num2 != 0)
				{
				}
				return;
				IL_1C:
				deviceEventHandler = this.b;
				num2 = (short)2137391105;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				short num2;
				global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler deviceEventHandler;
				for (;;)
				{
					IL_0A:
					global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler deviceEventHandler2;
					switch (num)
					{
					case 0:
						return;
					case 1:
						goto IL_39;
					case 2:
					{
						num2 = (short)489160704;
						short num3 = num2;
						if (deviceEventHandler != deviceEventHandler2)
						{
							goto IL_39;
						}
						num2 = (short)1139991640;
						short num4 = num2;
						num2 = (short)1495589976;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							return;
						default:
							num2 = (short)1211039744;
							if (num2 != 0)
							{
							}
							num2 = (short)23658497;
							if (num2 != 0)
							{
							}
							num2 = (short)1899429888;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					}
					goto IL_1C;
					IL_39:
					deviceEventHandler2 = deviceEventHandler;
					global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler value2 = (global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler)global::System.Delegate.Remove(deviceEventHandler2, value);
					deviceEventHandler = global::System.Threading.Interlocked.CompareExchange<global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler>(ref this.b, value2, deviceEventHandler2);
					num2 = (short)1777532930;
					num = (int)((global::System.IntPtr)num2);
				}
				return;
				IL_1C:
				deviceEventHandler = this.b;
				num2 = (short)1765801985;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x06000089 RID: 137 RVA: 0x0000D7D0 File Offset: 0x0000B9D0
		public bool DeviceChanged(global::Motorola.Common.Communication.DeviceDiscovery.OriginalPnPMsg pnpMsg)
		{
			short num = (short)791468786;
			short num2 = num;
			num = (short)1156963058;
			switch (num2 == num)
			{
			}
			num = (short)1786445824;
			if (num != 0)
			{
			}
			num = (short)2119958528;
			short num3 = num;
			num = (short)54263809;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600008A RID: 138 RVA: 0x0000D87C File Offset: 0x0000BA7C
		public void UpdatePasswords(global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.AuthenticationInfo> psws)
		{
			short num = (short)1769404665;
			short num2 = num;
			num = (short)691730681;
			switch (num2 == num)
			{
			}
			num = (short)1754136577;
			if (num != 0)
			{
			}
			num = (short)797900800;
			short num3 = num;
			num = (short)1987444736;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.DeviceDiscovery.LDTDetectorBase._passwords.Clear();
			global::Motorola.Common.Communication.DeviceDiscovery.LDTDetectorBase._passwords.AddRange(psws);
		}

		// Token: 0x0600008B RID: 139 RVA: 0x0000D93C File Offset: 0x0000BB3C
		public void DetachDevice(string imei)
		{
			int a_ = 16;
			short num = (short)406061056;
			short num2 = num;
			switch (0)
			{
			case 0:
				goto IL_4D;
			}
			int num3;
			global::Motorola.Common.Communication.DeviceDiscovery.LDTDetectorBase.b b;
			for (;;)
			{
				IL_3B:
				switch (num3)
				{
				case 0:
					goto IL_199;
				case 1:
					if (global::Motorola.Common.Communication.DeviceDiscovery.LDTDetectorBase._arrivedDevices.Any(new global::System.Func<global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile, bool>(b.b)))
					{
						num = (short)936247298;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_19B;
				case 2:
				{
					num = (short)100335617;
					if (num != 0)
					{
					}
					this.c(global::Motorola.Common.Communication.DeviceDiscovery.LDTDetectorBase._arrivedDevices.First(new global::System.Func<global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile, bool>(b.c)));
					global::Motorola.Common.Communication.DeviceDiscovery.LDTDetectorBase._arrivedDevices.RemoveAll(new global::System.Predicate<global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile>(b.d));
					num = (short)98685183;
					short num4 = num;
					num = (short)1655296255;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_19B;
					default:
						num = (short)775946240;
						if (num != 0)
						{
						}
						num = (short)1356988416;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				goto IL_4D;
			}
			IL_199:
			IL_19B:
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("ॎ㡐㵒㱔⑖ㅘ㹚㥜罞፠٢ࡤࡦὨɪͬ࡮兰ݲᵴቶ奸ὺ᡼ॾ붆ꦈ붌뾐뎒횔뾞캠얢薤쎦첨\uddaa쒬첮풰삲辴鞶슸誺삼醾", a_), new object[]
			{
				b.a,
				global::Motorola.Common.Communication.DeviceDiscovery.LDTDetectorBase._arrivedDevices.Count
			});
			return;
			IL_4D:
			b = new global::Motorola.Common.Communication.DeviceDiscovery.LDTDetectorBase.b();
			b.a = imei;
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("ᩎ⅐獒⅔㡖祘⥚㡜㉞๠ᕢ౤०๨䭪ᥬݮᑰ卲ᅴቶླྀቺṼ᩾뮀ꎂﺄ랆ꖊ권첎ﺐﮔ릘ﮜ뾞얠욢펤캦쪨캪\udeac閮醰좲蒴쪶鞸", a_), new object[]
			{
				b.a,
				global::Motorola.Common.Communication.DeviceDiscovery.LDTDetectorBase._arrivedDevices.Count
			});
			num = (short)470351873;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_3B;
		}

		// Token: 0x0600008C RID: 140 RVA: 0x0000DB20 File Offset: 0x0000BD20
		public void ClearDevice(global::Motorola.Common.Communication.DeviceDiscovery.RNDISRadioProfile device)
		{
			int a_ = 0;
			short num = (short)690400781;
			short num2 = num;
			num = (short)612675085;
			switch (num2 == num)
			{
			}
			num = (short)1309999105;
			if (num != 0)
			{
			}
			num = (short)800915456;
			short num3 = num;
			num = (short)1280049152;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("樾ㅀ捂ㅄ⡆楈㥊⡌≎㹐╒㱔㥖㹘筚⥜㝞Ѡ䍢ŤɦὨɪ๬੮䭰卲๴䝶Ѹ啺嵼㱾ꦈ꾎ﺖ滛ﺚꖞ膠\ud8a2钤\udaa6螨", a_), new object[]
			{
				(device != null) ? device.RadioSerialNumber : null,
				global::Motorola.Common.Communication.DeviceDiscovery.LDTDetectorBase._arrivedDevices.Count
			});
			global::Motorola.Common.Communication.DeviceDiscovery.LDTDetectorBase._arrivedDevices.Remove((global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile)device);
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("社⡀ⵂⱄ㑆ⅈ⹊⥌潎⍐㙒㡔㡖⽘㉚㍜㡞䅠ᝢ൤ɦ䥨ཪ࡬᥮ᡰၲၴ䵶奸z䵼ɾ꾀ꎂ욄ﲈ歷꾎ﺐ떔ﲘﲞ쒠킢龤螦튨骪킬膮", a_), new object[]
			{
				(device != null) ? device.RadioSerialNumber : null,
				global::Motorola.Common.Communication.DeviceDiscovery.LDTDetectorBase._arrivedDevices.Count
			});
		}

		// Token: 0x0600008D RID: 141 RVA: 0x0000DC68 File Offset: 0x0000BE68
		public void ClearDevice(string imei)
		{
			int a_ = 6;
			short num = (short)1511864781;
			short num2 = num;
			num = (short)1204173261;
			switch (num2 == num)
			{
			}
			num = (short)2030764032;
			if (num != 0)
			{
			}
			num = (short)1907359744;
			short num3 = num;
			num = (short)2007105537;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.DeviceDiscovery.LDTDetectorBase.c c = new global::Motorola.Common.Communication.DeviceDiscovery.LDTDetectorBase.c();
			c.a = imei;
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("၄㝆楈㽊≌潎⍐㙒㡔㡖⽘㉚㍜㡞䅠ᝢ൤ɦ䥨ཪ࡬᥮ᡰၲၴ䵶奸z䵼ɾ꾀ꎂ욄ﲈ歷꾎ﺐ떔ﲘﲞ쒠킢龤螦튨骪킬膮", a_), new object[]
			{
				c.a,
				global::Motorola.Common.Communication.DeviceDiscovery.LDTDetectorBase._arrivedDevices.Count
			});
			global::Motorola.Common.Communication.DeviceDiscovery.LDTDetectorBase._arrivedDevices.RemoveAll(new global::System.Predicate<global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile>(c.b));
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("̈́⹆❈≊㹌❎㑐㝒畔╖㱘㙚㉜⥞ࡠൢɤ䝦ᵨͪ࡬佮ᕰᙲʹṶ᩸Ṻ䝼彾婢뎂ꦆꦈ좊搜ﾐ떔ﾘ뮚列爵힠쪢욤슦\udaa8醪趬풮肰캲鮴", a_), new object[]
			{
				c.a,
				global::Motorola.Common.Communication.DeviceDiscovery.LDTDetectorBase._arrivedDevices.Count
			});
		}

		// Token: 0x0600008E RID: 142 RVA: 0x0000DDB0 File Offset: 0x0000BFB0
		// Note: this type is marked as 'beforefieldinit'.
		static LDTDetectorBase()
		{
			int a_ = 0;
			short num = (short)582442427;
			short num2 = num;
			num = (short)1685872059;
			switch (num2 == num)
			{
			}
			num = (short)1374552065;
			if (num != 0)
			{
			}
			num = (short)196083712;
			short num3 = num;
			num = (short)559742976;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.DeviceDiscovery.LDTDetectorBase.LTE_REPEATER_PID = global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("怾ീᝂDᡆᭈ⹊㵌⩎ぐ❒ご╖", a_);
			global::Motorola.Common.Communication.DeviceDiscovery.LDTDetectorBase._arrivedDevices = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile>();
			global::Motorola.Common.Communication.DeviceDiscovery.LDTDetectorBase._passwords = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.AuthenticationInfo>();
		}

		// Token: 0x04000055 RID: 85
		public static readonly string LTE_REPEATER_PID;

		// Token: 0x04000056 RID: 86
		public global::Motorola.Common.Communication.DeviceDiscovery.DeviceDetectorType _detectorType;

		// Token: 0x04000057 RID: 87
		public static global::System.Collections.Generic.List<global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile> _arrivedDevices;

		// Token: 0x04000058 RID: 88
		public global::System.Threading.Thread _receiveThread;

		// Token: 0x04000059 RID: 89
		public static global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.AuthenticationInfo> _passwords;

		// Token: 0x0400005A RID: 90
		public bool _isStopping;

		// Token: 0x0400005B RID: 91
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler a;

		// Token: 0x0400005C RID: 92
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler b;

		// Token: 0x02000022 RID: 34
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class a
		{
			// Token: 0x060000C0 RID: 192 RVA: 0x0000F7EC File Offset: 0x0000D9EC
			internal bool b(global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile A_0)
			{
				if (A_0.ConnectMode == global::Motorola.Common.Communication.DeviceDiscovery.LDTConnectMode.WIFI)
				{
					short num;
					for (;;)
					{
						num = (short)2057568256;
						short num2 = num;
						num = (short)877201246;
						short num3 = num;
						num = (short)518981470;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_6F;
						}
					}
					IL_6F:
					num = (short)139919361;
					if (num != 0)
					{
					}
					num = (short)1968111616;
					if (num != 0)
					{
					}
					return A_0.IMEI == this.a.IMEI;
				}
				return false;
			}

			// Token: 0x060000C1 RID: 193 RVA: 0x0000F8BC File Offset: 0x0000DABC
			internal bool c(global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile A_0)
			{
				if (A_0.ConnectMode == global::Motorola.Common.Communication.DeviceDiscovery.LDTConnectMode.WIFI)
				{
					short num;
					for (;;)
					{
						num = (short)424935424;
						short num2 = num;
						num = (short)136914979;
						short num3 = num;
						num = (short)415180835;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_6D;
						}
					}
					IL_6D:
					num = (short)880934913;
					if (num != 0)
					{
					}
					num = (short)1877147648;
					if (num != 0)
					{
					}
					return A_0.IMEI == this.a.IMEI;
				}
				return false;
			}

			// Token: 0x04000075 RID: 117
			public global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile a;
		}

		// Token: 0x02000023 RID: 35
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class b
		{
			// Token: 0x060000C3 RID: 195 RVA: 0x0000F9A0 File Offset: 0x0000DBA0
			internal bool b(global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile A_0)
			{
				short num = (short)337506075;
				short num2 = num;
				num = (short)1408233243;
				switch (num2 == num)
				{
				}
				num = (short)1036845057;
				if (num != 0)
				{
				}
				num = (short)1607139328;
				short num3 = num;
				num = (short)898564096;
				if (num != 0)
				{
				}
				return A_0.IMEI == this.a;
			}

			// Token: 0x060000C4 RID: 196 RVA: 0x0000FA5C File Offset: 0x0000DC5C
			internal bool c(global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile A_0)
			{
				short num = (short)1060663557;
				short num2 = num;
				num = (short)1679126789;
				switch (num2 == num)
				{
				}
				num = (short)1866465281;
				if (num != 0)
				{
				}
				num = (short)2035286016;
				short num3 = num;
				num = (short)236781568;
				if (num != 0)
				{
				}
				return A_0.IMEI == this.a;
			}

			// Token: 0x060000C5 RID: 197 RVA: 0x0000FB18 File Offset: 0x0000DD18
			internal bool d(global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile A_0)
			{
				short num = (short)427229185;
				if (num != 0)
				{
				}
				num = (short)823800699;
				short num2 = num;
				num = (short)1936143227;
				switch (num2 == num)
				{
				}
				num = (short)1366425600;
				short num3 = num;
				num = (short)1422000128;
				if (num != 0)
				{
				}
				return A_0.IMEI == this.a;
			}

			// Token: 0x04000076 RID: 118
			public string a;
		}

		// Token: 0x02000024 RID: 36
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class c
		{
			// Token: 0x060000C7 RID: 199 RVA: 0x0000FBE8 File Offset: 0x0000DDE8
			internal bool b(global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile A_0)
			{
				short num = (short)2110586881;
				if (num != 0)
				{
				}
				num = (short)347151537;
				short num2 = num;
				num = (short)1346313393;
				switch (num2 == num)
				{
				}
				num = (short)884473856;
				short num3 = num;
				num = (short)160956416;
				if (num != 0)
				{
				}
				return A_0.IMEI == this.a;
			}

			// Token: 0x04000077 RID: 119
			public string a;
		}
	}
}
