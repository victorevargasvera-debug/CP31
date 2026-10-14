using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using Common.Communication.Simulator;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP;
using Motorola.Common.Communication.DeviceDiscovery;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.CommunicationManager
{
	// Token: 0x02000031 RID: 49
	public class MotoDeviceDetector
	{
		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000116 RID: 278 RVA: 0x00016A70 File Offset: 0x00014C70
		// (remove) Token: 0x06000117 RID: 279 RVA: 0x00016BA4 File Offset: 0x00014DA4
		public event global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler DeviceChanged
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
						goto IL_39;
					case 1:
					{
						num2 = (short)297662604;
						short num3 = num2;
						num2 = (short)1811740812;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							goto IL_E5;
						}
						break;
					}
					case 2:
						if (deviceEventHandler == deviceEventHandler2)
						{
							num2 = (short)738590721;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_39;
					}
					goto IL_1C;
					IL_39:
					num2 = (short)982056961;
					if (num2 != 0)
					{
					}
					deviceEventHandler2 = deviceEventHandler;
					global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler value2 = (global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler)global::System.Delegate.Combine(deviceEventHandler2, value);
					deviceEventHandler = global::System.Threading.Interlocked.CompareExchange<global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler>(ref this.c, value2, deviceEventHandler2);
					num2 = (short)2006188034;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_E5:
				num2 = (short)2011234304;
				if (num2 != 0)
				{
				}
				num2 = (short)1308622848;
				short num4 = num2;
				return;
				IL_1C:
				deviceEventHandler = this.c;
				num2 = (short)36765696;
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
						goto IL_5F;
					case 1:
					{
						num2 = (short)1298217804;
						short num3 = num2;
						num2 = (short)1618885452;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							goto IL_E4;
						}
						break;
					}
					case 2:
						if (deviceEventHandler == deviceEventHandler2)
						{
							num2 = (short)849608705;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_5F;
					}
					goto IL_1C;
					IL_5F:
					deviceEventHandler2 = deviceEventHandler;
					global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler value2 = (global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler)global::System.Delegate.Remove(deviceEventHandler2, value);
					deviceEventHandler = global::System.Threading.Interlocked.CompareExchange<global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler>(ref this.c, value2, deviceEventHandler2);
					num2 = (short)1568866306;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_E4:
				num2 = (short)119144448;
				if (num2 != 0)
				{
				}
				num2 = (short)1225981952;
				short num4 = num2;
				return;
				IL_1C:
				num2 = (short)1783431169;
				if (num2 != 0)
				{
				}
				deviceEventHandler = this.c;
				num2 = (short)1387528192;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x06000118 RID: 280 RVA: 0x00016CD8 File Offset: 0x00014ED8
		// (remove) Token: 0x06000119 RID: 281 RVA: 0x00016E0C File Offset: 0x0001500C
		public event global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler OrginalDeviceAttached
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
						goto IL_3A;
					case 1:
					{
						num2 = (short)661512467;
						short num3 = num2;
						num2 = (short)1836769555;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							goto IL_E4;
						}
						break;
					}
					case 2:
						num2 = (short)316342273;
						if (num2 != 0)
						{
						}
						if (deviceEventHandler == deviceEventHandler2)
						{
							num2 = (short)115212289;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_3A;
					}
					goto IL_1C;
					IL_3A:
					deviceEventHandler2 = deviceEventHandler;
					global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler value2 = (global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler)global::System.Delegate.Combine(deviceEventHandler2, value);
					deviceEventHandler = global::System.Threading.Interlocked.CompareExchange<global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler>(ref this.d, value2, deviceEventHandler2);
					num2 = (short)1286799362;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_E4:
				num2 = (short)908853248;
				if (num2 != 0)
				{
				}
				num2 = (short)858259456;
				short num4 = num2;
				return;
				IL_1C:
				deviceEventHandler = this.d;
				num2 = (short)604962816;
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
						goto IL_39;
					case 1:
					{
						num2 = (short)1940208067;
						short num3 = num2;
						num2 = (short)1140275651;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							goto IL_E2;
						}
						break;
					}
					case 2:
						num2 = (short)1144389633;
						if (num2 != 0)
						{
						}
						if (deviceEventHandler == deviceEventHandler2)
						{
							num2 = (short)661454849;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_39;
					}
					goto IL_1C;
					IL_39:
					deviceEventHandler2 = deviceEventHandler;
					global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler value2 = (global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler)global::System.Delegate.Remove(deviceEventHandler2, value);
					deviceEventHandler = global::System.Threading.Interlocked.CompareExchange<global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler>(ref this.d, value2, deviceEventHandler2);
					num2 = (short)1897529346;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_E2:
				num2 = (short)1568473088;
				if (num2 != 0)
				{
				}
				num2 = (short)1946288128;
				short num4 = num2;
				return;
				IL_1C:
				deviceEventHandler = this.d;
				num2 = (short)1988755456;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00016F3C File Offset: 0x0001513C
		public MotoDeviceDetector(global::Motorola.Common.Communication.CommunicationManager.ICommunicationManager communicationManager, global::Motorola.Common.Communication.CommunicationManager.MotoDeviceFactory deviceFactory, global::System.Collections.Generic.IEnumerable<global::Motorola.Common.Communication.DeviceDiscovery.IDeviceDetector> deviceDetectors)
		{
			this.f = communicationManager;
			this.g = deviceFactory;
			this.b = deviceDetectors;
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00016F70 File Offset: 0x00015170
		public void Start(global::Motorola.Common.Communication.CommonUtil.ProductFamily deviceFamilySet)
		{
			short num = (short)1831337984;
			short num2 = num;
			num = (short)1677328385;
			if (num != 0)
			{
			}
			num = (short)477228851;
			short num3 = num;
			num = (short)1952968499;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1825243136;
				if (num != 0)
				{
				}
				object obj = this.a;
				bool flag = false;
				try
				{
					global::System.Threading.Monitor.Enter(obj, ref flag);
					this.e = deviceFamilySet;
					global::System.Collections.Generic.IEnumerator<global::Motorola.Common.Communication.DeviceDiscovery.IDeviceDetector> enumerator = this.b.GetEnumerator();
					try
					{
						num = (short)1373044738;
						int num4 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num4)
							{
							case 0:
							{
								global::Motorola.Common.Communication.DeviceDiscovery.IDeviceDetector deviceDetector = enumerator.Current;
								deviceDetector.deviceAttached += this.a;
								deviceDetector.deviceDetached += this.b;
								if (!deviceDetector.Start())
								{
									num = (short)2069692421;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 1:
								num = (short)1986527235;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_101;
								}
								continue;
							case 3:
								goto IL_1B9;
							case 4:
								if (!enumerator.MoveNext())
								{
									num = (short)1037697025;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)637730816;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 5:
								goto IL_15C;
							}
							IL_15E:
							num = (short)1376124932;
							num4 = (int)((global::System.IntPtr)num);
							continue;
							IL_101:
							goto IL_15E;
						}
						IL_15C:
						throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerDeviceDetectorStartFailure);
						IL_1B9:;
					}
					finally
					{
						num = (short)1980628992;
						int num4 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num4)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_1EF;
								}
								continue;
							case 1:
								goto IL_222;
							case 2:
								enumerator.Dispose();
								num = (short)777256961;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_1EF:
							if (enumerator == null)
							{
								break;
							}
							num = (short)414187522;
							num4 = (int)((global::System.IntPtr)num);
						}
						IL_222:;
					}
				}
				finally
				{
					num = (short)744751104;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_255;
							}
							continue;
						case 1:
							goto IL_289;
						case 2:
							global::System.Threading.Monitor.Exit(obj);
							num = (short)988610561;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_255:
						if (!flag)
						{
							break;
						}
						num = (short)1806172162;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_289:;
				}
				break;
			}
			}
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00017240 File Offset: 0x00015440
		public void Stop()
		{
			short num = (short)344195072;
			short num2 = num;
			num = (short)467086965;
			short num3 = num;
			num = (short)657010293;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1201668096;
				if (num != 0)
				{
				}
				num = (short)551354369;
				if (num != 0)
				{
				}
				object obj = this.a;
				bool flag = false;
				try
				{
					global::System.Threading.Monitor.Enter(obj, ref flag);
					global::System.Collections.Generic.IEnumerator<global::Motorola.Common.Communication.DeviceDiscovery.IDeviceDetector> enumerator = this.b.GetEnumerator();
					try
					{
						num = (short)1002766336;
						int num4 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num4)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_F5;
								}
								continue;
							case 1:
								goto IL_18B;
							case 2:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)1609170948;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.Common.Communication.DeviceDiscovery.IDeviceDetector deviceDetector = enumerator.Current;
								deviceDetector.deviceAttached -= this.a;
								deviceDetector.deviceDetached -= this.b;
								deviceDetector.Stop();
								num = (short)1750925315;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 4:
								num = (short)468254721;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_13D:
							num = (short)1198522370;
							num4 = (int)((global::System.IntPtr)num);
							continue;
							IL_F5:
							goto IL_13D;
						}
						IL_18B:;
					}
					finally
					{
						num = (short)268828673;
						int num4 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num4)
							{
							case 0:
								enumerator.Dispose();
								num = (short)1076101122;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_1C1;
								}
								continue;
							case 2:
								goto IL_1F5;
							}
							IL_1C1:
							if (enumerator == null)
							{
								break;
							}
							num = (short)26017792;
							num4 = (int)((global::System.IntPtr)num);
						}
						IL_1F5:;
					}
				}
				finally
				{
					num = (short)474939393;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							global::System.Threading.Monitor.Exit(obj);
							num = (short)1833631746;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_22A;
							}
							continue;
						case 2:
							goto IL_260;
						}
						IL_22A:
						if (!flag)
						{
							break;
						}
						num = (short)1107296256;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_260:;
				}
				break;
			}
			}
		}

		// Token: 0x0600011D RID: 285 RVA: 0x000174E4 File Offset: 0x000156E4
		private void b(object A_0, global::Motorola.Common.Communication.DeviceDiscovery.DeviceMsgEventArgs A_1)
		{
			int a_ = 9;
			switch (0)
			{
			case 0:
				goto IL_29;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_13:
				global::System.Collections.IEnumerator enumerator;
				switch (num)
				{
				case 0:
				{
					global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler deviceEventHandler = this.c;
					if (deviceEventHandler == null)
					{
						num2 = (short)936706051;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					deviceEventHandler(this, A_1);
					num2 = (short)484966401;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
				{
					num2 = (short)692649984;
					short num3 = num2;
					num2 = (short)1042415617;
					if (num2 != 0)
					{
					}
					goto IL_1DE;
				}
				case 2:
					try
					{
						num2 = (short)2049310720;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_99;
								}
								continue;
							case 1:
								goto IL_16A;
							case 2:
							{
								num2 = (short)496433473;
								short num4 = num2;
								num2 = (short)888076609;
								switch ((num4 == num2) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									num2 = (short)1218707456;
									if (num2 != 0)
									{
									}
									break;
								}
								num2 = (short)1838219265;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							case 3:
							{
								if (!enumerator.MoveNext())
								{
									num2 = (short)1731657730;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								global::Motorola.Common.Communication.IRadioProfile radioProfile = (global::Motorola.Common.Communication.IRadioProfile)enumerator.Current;
								this.f.RemoveDevice(radioProfile.RadioIdString);
								num2 = (short)300810244;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							}
							IL_9B:
							num2 = (short)427556867;
							num = (int)((global::System.IntPtr)num2);
							continue;
							IL_99:
							goto IL_9B;
						}
						IL_16A:
						return;
					}
					finally
					{
						switch (0)
						{
						case 0:
							goto IL_18B;
						}
						global::System.IDisposable disposable;
						for (;;)
						{
							IL_179:
							switch (num)
							{
							case 0:
								disposable.Dispose();
								num2 = (short)1667497986;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 1:
								if (disposable != null)
								{
									num2 = (short)2044526592;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								goto IL_1DD;
							case 2:
								goto IL_1DB;
							}
							goto IL_18B;
						}
						IL_1DB:
						IL_1DD:
						goto EndFinally_6;
						IL_18B:
						disposable = (enumerator as global::System.IDisposable);
						num2 = (short)96141313;
						num = (int)((global::System.IntPtr)num2);
						goto IL_179;
						EndFinally_6:;
					}
					goto IL_1DE;
				case 3:
					goto IL_1DE;
				}
				goto IL_29;
				IL_1DE:
				enumerator = A_1.RadioInfoSet.GetEnumerator();
				num2 = (short)1764950018;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_29:
			global::System.Diagnostics.Trace.WriteLine(global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("ᩝ՟ᑡൣե൧⹩५ᩭᅯᅱᱳ፵ᱷ䁹屻ⱽﺇ꺍톏ﲑ뒓튕ﶗﶛﶝ좟쮡쪣솥袧즫\uddad쎯펱펳펵馷", a_));
			num2 = (short)380698624;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x0600011E RID: 286 RVA: 0x000177A0 File Offset: 0x000159A0
		private void a(object A_0, global::Motorola.Common.Communication.DeviceDiscovery.DeviceMsgEventArgs A_1)
		{
			int a_ = 7;
			short num = (short)527106048;
			int num2 = (int)num;
			switch (num2)
			{
			default:
				switch (0)
				{
				case 0:
					goto IL_8C;
				}
				for (;;)
				{
					IL_31:
					global::System.Collections.Generic.List<global::Motorola.Common.Communication.IRadioProfile> list2;
					int num4;
					switch (num2)
					{
					case 0:
						return;
					case 1:
					{
						global::System.Collections.Generic.List<global::Motorola.Common.Communication.IMotoDevice> list;
						if (this.g.CreateDevice(out list, list2))
						{
							num = (short)387645447;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int count = list2.Count;
						int num3 = 0;
						num = (short)1211826177;
						if (num != 0)
						{
						}
						num = (short)1554448396;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
					{
						global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler deviceEventHandler = this.d;
						if (deviceEventHandler == null)
						{
							num = (short)206897171;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						deviceEventHandler(this, A_1);
						num = (short)653131781;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						goto IL_3C0;
					case 4:
						goto IL_3C5;
					case 5:
						goto IL_1A7;
					case 6:
						goto IL_33B;
					case 7:
						num = (short)430768145;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						goto IL_2D6;
					case 9:
						num4 = 0;
						goto IL_25B;
					case 10:
						goto IL_3C5;
					case 11:
						goto IL_2FE;
					case 12:
						goto IL_33B;
					case 13:
					{
						global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler deviceEventHandler2 = this.c;
						if (deviceEventHandler2 == null)
						{
							num = (short)402128914;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						deviceEventHandler2(this, A_1);
						num = (short)1221263371;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
					{
						global::System.Collections.Generic.List<global::Motorola.Common.Communication.IMotoDevice> list;
						A_1.RadioInfoSet[num4] = list[num4].DeviceInfo.Copy();
						num = (short)717553672;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 15:
						if ((A_1.RadioInfoSet[0] as global::Motorola.Common.Communication.IRadioProfile).RadioType != global::Motorola.Common.Communication.RadioType.TETRA)
						{
							num = (short)119996430;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2D6;
					case 16:
					{
						global::System.Collections.Generic.List<global::Motorola.Common.Communication.IMotoDevice> list;
						if (num4 >= list.Count)
						{
							num = (short)943652864;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.f.AddDevice(list[num4]);
						num = (short)1012858880;
						short num5 = num;
						num = (short)3801103;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 17:
					{
						global::System.Collections.Generic.List<global::Motorola.Common.Communication.IMotoDevice> list;
						if (list != null)
						{
							num = (short)626655241;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 18:
						goto IL_2FE;
					case 19:
						goto IL_1A7;
					case 20:
					{
						num = (short)1577094764;
						short num6 = num;
						num = (short)1028951660;
						switch ((num6 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_25B;
						default:
						{
							num = (short)1584070656;
							if (num != 0)
							{
							}
							int count;
							int num3;
							if (num3 >= count)
							{
								num = (short)494534659;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("ᅛㅝᑟൡ⁣ͥṧͩཫ୭㑯᝱s፵᭷๹፻౽멿뢁삃ﺇ톏ﮗ鍊瞧쎡쪣슥쒧쾩\udeab躭펱\uddb3\udab5\uddb7\udeb9銻", a_), global::System.Array.Empty<object>());
							num3++;
							num = (short)894107654;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					}
					goto IL_8C;
					IL_1A7:
					list2 = A_1.RadioInfoSet.OfType<global::Motorola.Common.Communication.IRadioProfile>().ToList<global::Motorola.Common.Communication.IRadioProfile>();
					num = (short)1137901569;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_25B:
					num = (short)1876426762;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2D6:
					num = (short)1965031437;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2FE:
					num4++;
					num = (short)57802756;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_33B:
					num = (short)897384468;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3C5:
					num = (short)1682767888;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_3C0:
				return;
				IL_8C:
				global::System.Diagnostics.Trace.WriteLine(global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("ᡛ㭝ᙟୡݣͥ⥧ṩᡫ཭፯ᩱᅳት䉷婹⹻᭽겋쾍ﺏ늑햓ﮙﾛ즟첡쎣蚥쾩\udfab\uddad톯햱톳鞵", a_));
				num = (short)1202782210;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
		}

		// Token: 0x0600011F RID: 287 RVA: 0x00017C14 File Offset: 0x00015E14
		public bool AttachDevice(global::Motorola.Common.Communication.IRadioProfile radioProf)
		{
			short num = (short)1534722048;
			short num2 = num;
			num = (short)371299210;
			short num3 = num;
			num = (short)2139591562;
			switch (num3 == num)
			{
			}
			num = (short)40828928;
			if (num != 0)
			{
			}
			num = (short)1475084289;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.DeviceDiscovery.OriginalPnPMsg simulatedMsg = new global::Motorola.Common.Communication.DeviceDiscovery.OriginalPnPMsg
			{
				m_DeviceAction = global::Motorola.Common.Communication.DeviceDiscovery.DevPnPAction.DeviceAttached,
				sDeviceName = string.Empty,
				radioProfile = radioProf
			};
			return this.b.Any(delegate(global::Motorola.Common.Communication.DeviceDiscovery.IDeviceDetector dd)
			{
				short num4 = (short)580648960;
				short num5 = num4;
				num4 = (short)1881744260;
				short num6 = num4;
				num4 = (short)909255556;
				switch (num6 == num4)
				{
				}
				num4 = (short)573440001;
				if (num4 != 0)
				{
				}
				num4 = (short)894894080;
				if (num4 != 0)
				{
				}
				return dd.DeviceChanged(simulatedMsg);
			});
		}

		// Token: 0x06000120 RID: 288 RVA: 0x00017CFC File Offset: 0x00015EFC
		public bool DetachDevice(global::Motorola.Common.Communication.IRadioProfile radioProf)
		{
			short num = (short)2008743936;
			short num2 = num;
			num = (short)111938616;
			short num3 = num;
			num = (short)1528171576;
			switch (num3 == num)
			{
			}
			num = (short)1459552257;
			if (num != 0)
			{
			}
			num = (short)97386496;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.DeviceDiscovery.OriginalPnPMsg simulatedMsg = new global::Motorola.Common.Communication.DeviceDiscovery.OriginalPnPMsg
			{
				m_DeviceAction = global::Motorola.Common.Communication.DeviceDiscovery.DevPnPAction.DeviceAttached,
				sDeviceName = string.Empty,
				radioProfile = radioProf
			};
			return this.b.Any(delegate(global::Motorola.Common.Communication.DeviceDiscovery.IDeviceDetector dd)
			{
				short num4 = (short)790364160;
				short num5 = num4;
				num4 = (short)1218154735;
				short num6 = num4;
				num4 = (short)1714917615;
				switch (num6 == num4)
				{
				}
				num4 = (short)315293696;
				if (num4 != 0)
				{
				}
				num4 = (short)351338497;
				if (num4 != 0)
				{
				}
				return dd.DeviceChanged(simulatedMsg);
			});
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00017DE4 File Offset: 0x00015FE4
		public global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DeviceInfo> ScanVirtualDevices()
		{
			short num = (short)269025280;
			short num2 = num;
			num = (short)459546382;
			short num3 = num;
			num = (short)99819278;
			switch (num3 == num)
			{
			}
			num = (short)368246785;
			if (num != 0)
			{
			}
			num = (short)342294528;
			if (num != 0)
			{
			}
			return global::Motorola.Common.Communication.CommonUtil.SingletonBase<global::Common.Communication.Simulator.VirtualDeviceDetector>.Instance().ScanVirtualDevices();
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00017E98 File Offset: 0x00016098
		internal void DetectWiFiDevices()
		{
			short num = (short)1037828096;
			short num2 = num;
			num = (short)337466692;
			short num3 = num;
			num = (short)1944606020;
			switch (num3 == num)
			{
			}
			num = (short)1797521409;
			if (num != 0)
			{
			}
			num = (short)1051525120;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.CommonUtil.SingletonBase<global::Motorola.Common.Communication.DeviceDiscovery.DNSSDDetector>.Instance().DetectAllWiFiDevices();
		}

		// Token: 0x04000043 RID: 67
		private readonly object a = new object();

		// Token: 0x04000044 RID: 68
		private readonly global::System.Collections.Generic.IEnumerable<global::Motorola.Common.Communication.DeviceDiscovery.IDeviceDetector> b;

		// Token: 0x04000045 RID: 69
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler c;

		// Token: 0x04000046 RID: 70
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler d;

		// Token: 0x04000047 RID: 71
		private global::Motorola.Common.Communication.CommonUtil.ProductFamily e;

		// Token: 0x04000048 RID: 72
		private readonly global::Motorola.Common.Communication.CommunicationManager.ICommunicationManager f;

		// Token: 0x04000049 RID: 73
		private readonly global::Motorola.Common.Communication.CommunicationManager.MotoDeviceFactory g;
	}
}
