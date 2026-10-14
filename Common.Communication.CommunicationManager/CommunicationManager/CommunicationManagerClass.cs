using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP;
using Motorola.Common.Communication.DeviceDiscovery;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.CommunicationManager
{
	// Token: 0x0200000C RID: 12
	public class CommunicationManagerClass : global::Motorola.Common.Communication.CommunicationManager.DeviceEventHandler, global::Motorola.Common.Communication.CommunicationManager.ICommunicationManager, global::Motorola.Common.Communication.CommonUtil.IObserver, global::System.IDisposable
	{
		// Token: 0x0600001A RID: 26 RVA: 0x00002E44 File Offset: 0x00001044
		public CommunicationManagerClass(global::Motorola.Common.Communication.CommunicationManager.ISequenceManagerFactory sequenceManagerFactory, global::System.Lazy<global::Motorola.Common.Communication.CommunicationManager.MotoDeviceDetector> motoDeviceDetector, global::Motorola.Common.Communication.CommunicationManager.ICommunicationPipeFactory communicationPipeFactory)
		{
			this.j = sequenceManagerFactory;
			this.i = motoDeviceDetector;
			this.k = communicationPipeFactory;
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600001B RID: 27 RVA: 0x00002EB0 File Offset: 0x000010B0
		// (set) Token: 0x0600001C RID: 28 RVA: 0x00002F5C File Offset: 0x0000115C
		public global::Motorola.Common.Communication.CommonUtil.WorkMode DiscoveryWorkMode
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)370160145;
				short num2 = num;
				num = (short)800076305;
				switch (num2 == num)
				{
				}
				num = (short)159776769;
				if (num != 0)
				{
				}
				num = (short)490405888;
				short num3 = num;
				num = (short)1228800000;
				if (num != 0)
				{
				}
				return this.l;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)546687023;
				short num2 = num;
				num = (short)442877999;
				switch (num2 == num)
				{
				}
				num = (short)1798569985;
				if (num != 0)
				{
				}
				num = (short)1079443456;
				short num3 = num;
				num = (short)828702720;
				if (num != 0)
				{
				}
				this.l = value;
			}
		}

		// Token: 0x0600001D RID: 29 RVA: 0x0000300C File Offset: 0x0000120C
		public void Start(global::Motorola.Common.Communication.CommonUtil.ProductFamily deviceFamilySet, global::Motorola.Common.Communication.CommonUtil.WorkMode workMode)
		{
			int a_ = 9;
			if (!this.h)
			{
				short num;
				for (;;)
				{
					num = (short)828375040;
					short num2 = num;
					num = (short)512148818;
					short num3 = num;
					num = (short)1650312530;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_78;
					}
				}
				IL_78:
				num = (short)2089615360;
				if (num != 0)
				{
				}
				num = (short)276496385;
				if (num != 0)
				{
				}
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("畝䭟䥡佣䵥䍧䅩䝫䕭孯奱彳嵵卷兹屻幽썿솁잃ꚅ\udb87ﺋ憐뚕ﮙ뺝슟잡쎣펥욧誩貫薭鮯馱龳鶵鎷醹鞻閽", a_), global::System.Array.Empty<object>());
				this.DiscoveryWorkMode = workMode;
				this.g = deviceFamilySet;
				this.i.Value.Start(deviceFamilySet);
				this.h = true;
				return;
			}
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("畝䭟䥡佣䵥䍧䅩䝫䕭孯奱彳嵵卷兹屻幽푿ﶃ겋揄ﾏ늑聯뺝蚥얧\udfa9삫\udaad\ud9af슱\ud8b3펵颷캹햻펽ꖿ뇁﯏六ￓ﷕쯟짡쿣췥", a_), global::System.Array.Empty<object>());
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00003130 File Offset: 0x00001330
		public void Stop()
		{
			short num = (short)540606465;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)475267072;
					short num3 = num;
					num = (short)1437270017;
					if (num != 0)
					{
					}
					this.i.Value.Stop();
					this.h = false;
					num = (short)609419266;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					goto IL_14;
				case 2:
				{
					num = (short)791390272;
					short num4 = num;
					num = (short)1925556288;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_14;
					default:
						goto IL_106;
					}
					break;
				}
				}
				goto IL_30;
				IL_14:
				switch (0)
				{
				case 0:
					IL_30:
					if (!this.h)
					{
						return;
					}
					num = (short)316014592;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_106:
			num = (short)511508480;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600001F RID: 31 RVA: 0x0000325C File Offset: 0x0000145C
		private global::Motorola.Common.Communication.CommonUtil.DeviceInfo c(string deviceID)
		{
			short num = (short)1045905896;
			short num2 = num;
			num = (short)1579434472;
			switch (num2 == num)
			{
			}
			num = (short)255131649;
			if (num != 0)
			{
			}
			num = (short)1384185856;
			short num3 = num;
			num = (short)1623851008;
			if (num != 0)
			{
			}
			return this.a(deviceID).DeviceInfo;
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00003314 File Offset: 0x00001514
		private global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo b(string deviceID)
		{
			short num = (short)558956545;
			if (num != 0)
			{
			}
			num = (short)2038597677;
			short num2 = num;
			num = (short)702777389;
			switch (num2 == num)
			{
			}
			num = (short)1622933504;
			short num3 = num;
			num = (short)940113920;
			if (num != 0)
			{
			}
			return this.a(deviceID).ReadExtendedDeviceInfo();
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000021 RID: 33 RVA: 0x000033C8 File Offset: 0x000015C8
		public global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DeviceInfo> DeviceInfoList
		{
			get
			{
				short num = (short)1663827968;
				short num2 = num;
				num = (short)675348481;
				if (num != 0)
				{
				}
				num = (short)988663065;
				short num3 = num;
				num = (short)538168601;
				global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DeviceInfo> result;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1348403200;
					if (num != 0)
					{
					}
					object obj = this.a;
					bool flag = false;
					try
					{
						global::System.Threading.Monitor.Enter(obj, ref flag);
						result = this.b.Values.Where(new global::System.Func<global::Motorola.Common.Communication.IMotoDevice, bool>(this.a)).Select(delegate(global::Motorola.Common.Communication.IMotoDevice motoDevice)
						{
							short num5 = (short)1646117535;
							short num6 = num5;
							num5 = (short)461882015;
							switch (num6 == num5)
							{
							default:
							{
								num5 = (short)762576896;
								short num7 = num5;
								break;
							}
							case true:
								break;
							}
							num5 = (short)530907136;
							if (num5 != 0)
							{
							}
							num5 = (short)152240129;
							if (num5 != 0)
							{
							}
							return motoDevice.DeviceInfo;
						}).ToList<global::Motorola.Common.Communication.CommonUtil.DeviceInfo>();
					}
					finally
					{
						num = (short)1304690689;
						int num4 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num4)
							{
							case 0:
								global::System.Threading.Monitor.Exit(obj);
								num = (short)601358338;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_12D;
								}
								continue;
							case 2:
								goto IL_161;
							}
							IL_12D:
							if (!flag)
							{
								break;
							}
							num = (short)1970929664;
							num4 = (int)((global::System.IntPtr)num);
						}
						IL_161:;
					}
					break;
				}
				}
				return result;
			}
		}

		// Token: 0x06000022 RID: 34 RVA: 0x0000354C File Offset: 0x0000174C
		private global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DeviceInfo> b(global::Motorola.Common.Communication.CommonUtil.ProductFamily A_0, int A_1)
		{
			int a_ = 8;
			short num = (short)1708064769;
			if (num != 0)
			{
			}
			num = (short)799473664;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_71;
				}
				global::System.Collections.Generic.List<global::Motorola.Common.Communication.IMotoDevice> list;
				object obj;
				bool flag;
				global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DeviceInfo> list2;
				for (;;)
				{
					IL_56:
					global::System.Collections.Generic.List<global::Motorola.Common.Communication.IMotoDevice>.Enumerator enumerator;
					switch (num2)
					{
					case 0:
						if (this.DiscoveryWorkMode == global::Motorola.Common.Communication.CommonUtil.WorkMode.Lazy)
						{
							num = (short)1893203972;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_CD;
					case 1:
						try
						{
							num = (short)1689911299;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 1:
									num = (short)1562181636;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									if (!enumerator.MoveNext())
									{
										num = (short)1039007745;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									enumerator.Current.Prefetch();
									num = (short)79101952;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_153;
									}
									continue;
								case 4:
									goto IL_1C5;
								}
								IL_155:
								num = (short)833421314;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_153:
								goto IL_155;
							}
							IL_1C5:
							goto IL_CD;
						}
						finally
						{
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto Block_2;
					case 2:
						goto IL_1D8;
					case 3:
					{
						num = (short)1887895552;
						short num3 = num;
						goto IL_40F;
					}
					case 4:
						goto IL_6AB;
					}
					goto IL_71;
					IL_CD:
					long ticks = global::System.DateTime.Now.Ticks;
					int num4 = global::Motorola.Common.Communication.CommunicationManager.CommunicationManagerClass.f + list.Count * 2000;
					int num5 = num4;
					enumerator = list.GetEnumerator();
					num = (short)1235288066;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6AB:
					enumerator = list.GetEnumerator();
					num = (short)499056641;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					Block_3:
					try
					{
						IL_40F:
						global::System.Threading.Monitor.Enter(obj, ref flag);
						using (global::System.Collections.Generic.Dictionary<string, global::Motorola.Common.Communication.IMotoDevice>.ValueCollection.Enumerator enumerator2 = this.b.Values.GetEnumerator())
						{
							num = (short)1242460609;
							short num6 = num;
							num = (short)11891137;
							switch ((num6 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								num = (short)519503872;
								if (num != 0)
								{
								}
								num = (short)1836122115;
								num2 = (int)((global::System.IntPtr)num);
								break;
							}
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::Motorola.Common.Communication.IMotoDevice motoDevice;
									if (A_0.HasFlag(motoDevice.DeviceInfo.Family))
									{
										num = (short)1803681796;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
								{
									if (!enumerator2.MoveNext())
									{
										num = (short)548929543;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.Common.Communication.IMotoDevice motoDevice = enumerator2.Current;
									num = (short)1065353224;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									switch (0)
									{
									case 0:
										goto IL_4CA;
									}
									continue;
								case 4:
									num = (short)1592983557;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
								{
									global::Motorola.Common.Communication.IMotoDevice motoDevice;
									if ((motoDevice.DeviceInfo.ConnectionInfo.ConnectionType & (global::Motorola.Common.Communication.CommonUtil.ConnectionType)A_1) != global::Motorola.Common.Communication.CommonUtil.ConnectionType.None)
									{
										num = (short)98500617;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 6:
									num = (short)510263296;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
									num = (short)766836746;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
								{
									global::Motorola.Common.Communication.IMotoDevice motoDevice;
									if (motoDevice.DeviceInfo != null)
									{
										num = (short)1425014790;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 9:
								{
									global::Motorola.Common.Communication.IMotoDevice motoDevice;
									list.Add(motoDevice);
									num = (short)1484324865;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 10:
									goto IL_62A;
								}
								IL_5B3:
								num = (short)1737752578;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_4CA:
								goto IL_5B3;
							}
							IL_62A:
							goto IL_6D2;
						}
					}
					finally
					{
						num = (short)909639681;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								global::System.Threading.Monitor.Exit(obj);
								num = (short)1370423298;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_670;
								}
								continue;
							case 2:
								goto IL_6A8;
							}
							IL_670:
							if (!flag)
							{
								break;
							}
							num = (short)814022656;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_6A8:;
					}
					goto IL_6AB;
					IL_6D2:
					num = (short)1410859008;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					Block_2:
					try
					{
						IL_1D8:
						num = (short)151977987;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_298;
							case 1:
								num = (short)547487754;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
								switch (0)
								{
								case 0:
									goto IL_22B;
								}
								continue;
							case 4:
								if (num5 < 0)
								{
									num = (short)1791819784;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							case 5:
							{
								global::Motorola.Common.Communication.IMotoDevice motoDevice2;
								if (motoDevice2.WaitForReady(num5))
								{
									num = (short)498204681;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_298;
							}
							case 6:
							{
								global::Motorola.Common.Communication.CommonUtil.TraceLogger instance = global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance;
								string format = global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("ᅜ㙞በᝢ♤ࡦݨժ࡬౮հᙲᅴ㍶ᱸൺᑼ᱾ꖄ놐ﲒ릘ꆚ붜醠\udea2薤鶦覨킪鲬튮醰覲閴첶许욺", a_);
								global::Motorola.Common.Communication.IMotoDevice motoDevice2;
								global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo = motoDevice2.DeviceInfo;
								object arg = (deviceInfo != null) ? deviceInfo.SerialNumber : null;
								global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo2 = motoDevice2.DeviceInfo;
								object arg2 = (deviceInfo2 != null) ? deviceInfo2.RadioID : null;
								global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo3 = motoDevice2.DeviceInfo;
								instance.WriteVerbose(string.Format(format, arg, arg2, (deviceInfo3 != null) ? new global::Motorola.Common.Communication.CommonUtil.RadioState?(deviceInfo3.RadioState) : null), global::System.Array.Empty<object>());
								num5 = 0;
								num = (short)9043970;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 7:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)2015559681;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.Common.Communication.IMotoDevice motoDevice2 = enumerator.Current;
								num = (short)1308295173;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 8:
								num = (short)1583808518;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 9:
							{
								global::Motorola.Common.Communication.IMotoDevice motoDevice2;
								list2.Add(motoDevice2.DeviceInfo);
								num = (short)950206464;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 10:
								goto IL_3FC;
							}
							goto IL_22B;
							IL_298:
							int num7 = (int)((global::System.DateTime.Now.Ticks - ticks) / 10000L);
							num5 = num4 - num7;
							num = (short)418643972;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_3A4:
							num = (short)476774407;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_22B:
							goto IL_3A4;
						}
						IL_3FC:
						break;
					}
					finally
					{
						((global::System.IDisposable)enumerator).Dispose();
					}
					goto Block_3;
				}
				return list2;
				IL_71:
				list2 = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DeviceInfo>();
				list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.IMotoDevice>();
				obj = this.a;
				flag = false;
				num = (short)471072771;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_56;
			}
			}
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00003CD0 File Offset: 0x00001ED0
		private global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DeviceInfo> a(global::Motorola.Common.Communication.CommonUtil.ProductFamily A_0, int A_1, string A_2)
		{
			short num = (short)1328611328;
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
				global::System.Collections.Generic.List<global::Motorola.Common.Communication.IMotoDevice> list;
				object obj;
				bool flag;
				global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DeviceInfo> list2;
				for (;;)
				{
					IL_27:
					global::System.Collections.Generic.List<global::Motorola.Common.Communication.IMotoDevice>.Enumerator enumerator;
					switch (num2)
					{
					case 0:
						goto IL_66E;
					case 1:
						goto IL_3CC;
					case 2:
						try
						{
							num = (short)249823233;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_172;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_FF;
									}
									continue;
								case 2:
									num = (short)2067333120;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									if (!enumerator.MoveNext())
									{
										num = (short)2056519682;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									enumerator.Current.Prefetch();
									num = (short)2000945155;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_101:
								num = (short)2079129604;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_FF:
								goto IL_101;
							}
							IL_172:
							goto IL_9E;
						}
						finally
						{
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto Block_2;
					case 3:
						if (this.DiscoveryWorkMode == global::Motorola.Common.Communication.CommonUtil.WorkMode.Lazy)
						{
							num = (short)1710817280;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9E;
					case 4:
						goto IL_185;
					}
					goto IL_42;
					IL_9E:
					enumerator = list.GetEnumerator();
					num = (short)1173880836;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_66E:
					enumerator = list.GetEnumerator();
					num = (short)1246691330;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					Block_3:
					try
					{
						IL_3CC:
						global::System.Threading.Monitor.Enter(obj, ref flag);
						using (global::System.Collections.Generic.Dictionary<string, global::Motorola.Common.Communication.IMotoDevice>.ValueCollection.Enumerator enumerator2 = this.b.Values.GetEnumerator())
						{
							num = (short)517668871;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_5A4;
								case 1:
									num = (short)1306984448;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
								{
									global::Motorola.Common.Communication.IMotoDevice motoDevice;
									if ((motoDevice.DeviceInfo.ConnectionInfo.ConnectionType & (global::Motorola.Common.Communication.CommonUtil.ConnectionType)A_1) != global::Motorola.Common.Communication.CommonUtil.ConnectionType.None)
									{
										num = (short)398524420;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
									num = (short)1674575874;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
								{
									global::Motorola.Common.Communication.IMotoDevice motoDevice;
									list.Add(motoDevice);
									num = (short)71303176;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
								{
									if (!enumerator2.MoveNext())
									{
										num = (short)145031169;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.Common.Communication.IMotoDevice motoDevice = enumerator2.Current;
									num = (short)1323040774;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
								{
									global::Motorola.Common.Communication.IMotoDevice motoDevice;
									if (motoDevice.DeviceInfo != null)
									{
										num = (short)1238499337;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 7:
									switch (0)
									{
									case 0:
										goto IL_43A;
									}
									continue;
								case 9:
									num = (short)645791754;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 10:
								{
									global::Motorola.Common.Communication.IMotoDevice motoDevice;
									if (A_0.HasFlag(motoDevice.DeviceInfo.Family))
									{
										num = (short)138674179;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_43C:
								num = (short)1351221253;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_43A:
								goto IL_43C;
							}
							IL_5A4:
							goto IL_694;
						}
					}
					finally
					{
						num = (short)1589837826;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_622;
							case 1:
								global::System.Threading.Monitor.Exit(obj);
								num = (short)195952640;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								IL_5CD:
								switch (0)
								{
								case 0:
									goto IL_5EA;
								}
								continue;
							}
							IL_5EA:
							if (flag)
							{
								num = (short)1484914689;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_622:
							num = (short)810866284;
							short num3 = num;
							num = (short)969266796;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_5CD;
							default:
								goto IL_657;
							}
						}
						IL_657:
						num = (short)365035520;
						if (num != 0)
						{
						}
					}
					goto IL_66E;
					IL_694:
					num = (short)1772748803;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					Block_2:
					try
					{
						IL_185:
						num = (short)700776457;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							global::Motorola.Common.Communication.IMotoDevice motoDevice2;
							switch (num2)
							{
							case 0:
								if (motoDevice2.DeviceInfo != null)
								{
									num = (short)2094006274;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							case 1:
								num = (short)759824384;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								num = (short)1005387783;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
								goto IL_391;
							case 4:
								num = (short)1007484933;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 5:
								if (motoDevice2.DeviceInfo.SerialNumber == global::System.Convert.ToBase64String(global::System.Text.Encoding.ASCII.GetBytes(A_2)))
								{
									num = (short)617349130;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							case 6:
								if (!enumerator.MoveNext())
								{
									num = (short)1615659019;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								motoDevice2 = enumerator.Current;
								num = (short)56557580;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 7:
								if (!(motoDevice2.DeviceInfo.SerialNumber == A_2))
								{
									num = (short)1948581892;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_312;
							case 9:
								switch (0)
								{
								case 0:
									goto IL_1E1;
								}
								continue;
							case 10:
								goto IL_312;
							case 11:
								num = (short)240713731;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 12:
								if (motoDevice2.WaitForReady(0))
								{
									num = (short)414973953;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							goto IL_1E1;
							IL_312:
							list2.Add(motoDevice2.DeviceInfo);
							num = (short)957284360;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_339:
							num = (short)1209073670;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_1E1:
							goto IL_339;
						}
						IL_391:
						break;
					}
					finally
					{
						num = (short)1766588417;
						if (num != 0)
						{
						}
						((global::System.IDisposable)enumerator).Dispose();
					}
					goto Block_3;
				}
				return list2;
				IL_42:
				list2 = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DeviceInfo>();
				list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.IMotoDevice>();
				obj = this.a;
				flag = false;
				num = (short)1437073408;
				short num4 = num;
				num = (short)1057882113;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00004414 File Offset: 0x00002614
		private global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DeviceInfo> a(global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DeviceInfo> A_0)
		{
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DeviceInfo>.Enumerator enumerator = A_0.GetEnumerator();
			short num;
			try
			{
				num = (short)1030422529;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_105;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_42;
						}
						continue;
					case 2:
						if (!enumerator.MoveNext())
						{
							num = (short)1797324803;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						for (;;)
						{
							global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo = enumerator.Current;
							num = (short)1397315468;
							short num3 = num;
							num = (short)1359501196;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								goto IL_80;
							}
						}
						IL_80:
						num = (short)1569849344;
						if (num != 0)
						{
						}
						num = (short)518389764;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						num = (short)1322844160;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_B1:
					num = (short)2081619970;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_42:
					goto IL_B1;
				}
				IL_105:;
			}
			finally
			{
				num = (short)1538654209;
				if (num != 0)
				{
				}
				((global::System.IDisposable)enumerator).Dispose();
			}
			num = (short)470548480;
			short num4 = num;
			return A_0;
		}

		// Token: 0x06000025 RID: 37 RVA: 0x0000459C File Offset: 0x0000279C
		public global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DeviceInfo> CheckForDevice(global::Motorola.Common.Communication.CommonUtil.ProductFamily _deviceFamilySet, int _deviceConnectionType, string serialNumber)
		{
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DeviceInfo> result = null;
			short num;
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DeviceInfo> result2;
			try
			{
				num = (short)648740869;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)289947872;
						short num3 = num;
						num = (short)1810186464;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_101;
						default:
							num = (short)2104492032;
							if (num != 0)
							{
							}
							result2 = null;
							num = (short)1138425864;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 1:
						goto IL_1B9;
					case 2:
						goto IL_FC;
					case 3:
						if (_deviceConnectionType == 512)
						{
							num = (short)1144586246;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						result = this.a(_deviceFamilySet, _deviceConnectionType, serialNumber);
						num = (short)1020067841;
						if (num != 0)
						{
						}
						num = (short)639762433;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (_deviceConnectionType != 8)
						{
							num = (short)319815687;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_DA;
					case 5:
						switch (0)
						{
						case 0:
							goto IL_4E;
						}
						continue;
					case 6:
						goto IL_DA;
					case 7:
						goto IL_101;
					case 8:
						goto IL_D5;
					}
					IL_4E:
					if (_deviceConnectionType == 128)
					{
						num = (short)649330688;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)321978372;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_DA:
					result2 = this.ListConnectedDevices(_deviceFamilySet, _deviceConnectionType);
					num = (short)1607860226;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_101:
					num = (short)5701635;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_D5:
				IL_FC:
				goto IL_1C9;
				IL_1B9:;
			}
			catch (global::Motorola.Common.CustomException.CommonException)
			{
				throw;
			}
			catch (global::System.Exception systemException)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.GenericError, systemException);
			}
			return result;
			IL_1C9:
			num = (short)252379136;
			short num4 = num;
			return result2;
		}

		// Token: 0x06000026 RID: 38 RVA: 0x000047D0 File Offset: 0x000029D0
		public global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DeviceInfo> ListConnectedDevices(global::Motorola.Common.Communication.CommonUtil.ProductFamily _deviceFamilySet, int _deviceConnectionType)
		{
			short num = (short)438501376;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DeviceInfo> list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DeviceInfo>();
				try
				{
					switch (0)
					{
					case 0:
						goto IL_56;
					}
					global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DeviceInfo> list2;
					for (;;)
					{
						IL_2F:
						switch (num2)
						{
						case 0:
							goto IL_23C;
						case 1:
							goto IL_31E;
						case 2:
							num = (short)782106625;
							if (num != 0)
							{
							}
							try
							{
								num = (short)1394540549;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
									{
										global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DeviceInfo>.Enumerator enumerator;
										if (!enumerator.MoveNext())
										{
											num = (short)2074411016;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)2066787402;
										short num3 = num;
										num = (short)2049420362;
										switch ((num3 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											break;
										default:
										{
											num = (short)306184192;
											if (num != 0)
											{
											}
											global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo = enumerator.Current;
											num = (short)651427843;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										}
										break;
									}
									case 1:
										goto IL_229;
									case 3:
									{
										global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo;
										if ((deviceInfo.Family & _deviceFamilySet) != global::Motorola.Common.Communication.CommonUtil.ProductFamily.None)
										{
											num = (short)1978662918;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 4:
									{
										global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo;
										if ((deviceInfo.ConnectionInfo.ConnectionType & (global::Motorola.Common.Communication.CommonUtil.ConnectionType)_deviceConnectionType) != global::Motorola.Common.Communication.CommonUtil.ConnectionType.None)
										{
											num = (short)1870200839;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 5:
										switch (0)
										{
										case 0:
											goto IL_DC;
										}
										continue;
									case 6:
										num = (short)1293484036;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 7:
									{
										global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo;
										list.Add(deviceInfo);
										num = (short)1675689986;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 8:
										num = (short)1051066369;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_DE:
									num = (short)1994915840;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_DC:
									goto IL_DE;
								}
								IL_229:
								goto IL_306;
							}
							finally
							{
								global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DeviceInfo>.Enumerator enumerator;
								((global::System.IDisposable)enumerator).Dispose();
							}
							goto IL_23C;
						case 3:
						{
							global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DeviceInfo>.Enumerator enumerator = list2.GetEnumerator();
							num = (short)547815426;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
							if (_deviceConnectionType == 1024)
							{
								num = (short)2056847360;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							list2 = this.a(_deviceFamilySet, _deviceConnectionType);
							num = (short)657915910;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							if (list2 != null)
							{
								num = (short)776601603;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_306;
						case 6:
							goto IL_2A9;
						case 7:
							goto IL_2A9;
						}
						goto IL_56;
						IL_23C:
						list2 = this.a();
						num = (short)1479671815;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_2A9:
						num = (short)872349701;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_306:
						num = (short)538247169;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_31E:
					goto IL_32E;
					IL_56:
					list2 = null;
					num = (short)115146756;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_2F;
				}
				catch (global::Motorola.Common.CustomException.CommonException)
				{
					throw;
				}
				catch (global::System.Exception systemException)
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.GenericError, systemException);
				}
				IL_32E:
				num = (short)973930496;
				short num4 = num;
				return list;
			}
			}
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00004B84 File Offset: 0x00002D84
		private global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DeviceInfo> a(global::Motorola.Common.Communication.CommonUtil.ProductFamily A_0, int A_1)
		{
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DeviceInfo> result;
			short num;
			for (;;)
			{
				result = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DeviceInfo>();
				try
				{
					num = (short)264110081;
					if (num != 0)
					{
					}
					result = this.b(A_0, A_1);
				}
				catch (global::Motorola.Common.CustomException.CommonException ex) when (ex.ErrorCode == global::Motorola.Common.CustomException.CommonErrorCode.InvalidIPAddress)
				{
					global::System.Threading.Thread.Sleep(2000);
					result = this.b(A_0, A_1);
				}
				num = (short)403445782;
				short num2 = num;
				num = (short)2117081110;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_A1;
				}
			}
			IL_A1:
			num = (short)957546496;
			if (num != 0)
			{
			}
			num = (short)788856832;
			short num3 = num;
			return result;
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00004C84 File Offset: 0x00002E84
		private global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DeviceInfo> a()
		{
			short num = (short)477209066;
			short num2 = num;
			num = (short)559260138;
			switch (num2 == num)
			{
			}
			num = (short)1977090049;
			if (num != 0)
			{
			}
			num = (short)216924160;
			if (num != 0)
			{
			}
			num = (short)1875771392;
			short num3 = num;
			return this.i.Value.ScanVirtualDevices();
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00004D3C File Offset: 0x00002F3C
		internal void AddBlindPushDevice(global::Motorola.Common.Communication.IMotoDevice device)
		{
			int a_ = 18;
			short num = (short)47972353;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1546518528;
				short num3 = num;
				object obj;
				bool flag;
				switch (num2)
				{
				case 0:
					goto IL_259;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_6C;
					}
					continue;
				case 2:
					try
					{
						switch (0)
						{
						case 0:
							goto IL_D3;
						}
						for (;;)
						{
							IL_BD:
							switch (num2)
							{
							case 0:
								if (!this.c.ContainsKey(device.DeviceInfo.RadioID))
								{
									num = (short)526385155;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_18D;
							case 1:
								goto IL_1A4;
							case 2:
								goto IL_18D;
							case 3:
								global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("╦ըɪͬ୮兰ͲtѶᅸ孺㥼᩾ꦈ", a_) + device.DeviceInfo.RadioID + global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("䝦ࡨཪ६੮ᕰ割", a_), global::System.Array.Empty<object>());
								this.c[device.DeviceInfo.RadioID] = device;
								num = (short)1574240258;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_D3;
							IL_18D:
							num = (short)1111883777;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_1A4:
						return;
						IL_D3:
						global::System.Threading.Monitor.Enter(obj, ref flag);
						num = (short)1498218496;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_BD;
					}
					finally
					{
						num = (short)1823539202;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_20F;
							case 1:
								global::System.Threading.Monitor.Exit(obj);
								num = (short)1157103616;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								IL_1BD:
								switch (0)
								{
								case 0:
									goto IL_1D9;
								}
								continue;
							}
							IL_1D9:
							if (flag)
							{
								num = (short)1758396417;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_20F:
							num = (short)2124302418;
							short num4 = num;
							num = (short)1742751826;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_1BD;
							default:
								goto IL_243;
							}
						}
						IL_243:
						num = (short)505872384;
						if (num != 0)
						{
						}
					}
					goto IL_259;
				case 3:
					if (device.DeviceInfo != null)
					{
						num = (short)267321344;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 4:
					num = (short)2051342337;
					if (num != 0)
					{
					}
					num = (short)480772099;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_6C:
				if (device != null)
				{
					num = (short)1881079812;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_259:
				obj = this.a;
				flag = false;
				num = (short)734068738;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00005010 File Offset: 0x00003210
		public void AddDevice(global::Motorola.Common.Communication.IMotoDevice device)
		{
			int a_ = 14;
			short num = (short)1083047939;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)666435585;
				if (num != 0)
				{
				}
				object obj;
				bool flag;
				switch (num2)
				{
				case 0:
					num = (short)1413218308;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_322;
				case 2:
					num = (short)2056126469;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_70;
					}
					continue;
				case 4:
					if (device.DeviceInfo != null)
					{
						num = (short)769064962;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3CC;
				case 5:
					if (!string.IsNullOrEmpty(device.DeviceInfo.RadioID))
					{
						num = (short)1767047169;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3CC;
				case 6:
					try
					{
						switch (0)
						{
						case 0:
							goto IL_B8;
						}
						for (;;)
						{
							IL_9A:
							switch (num2)
							{
							case 0:
								goto IL_26C;
							case 1:
								goto IL_254;
							case 2:
								if (!this.b.ContainsKey(device.DeviceInfo.RadioID))
								{
									num = (short)149356549;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_254;
							case 3:
								if (device.DeviceInfo.RadioState == global::Motorola.Common.Communication.CommonUtil.RadioState.Ready)
								{
									num = (short)1249837060;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_254;
							case 4:
								this.c(device.DeviceInfo);
								num = (short)1209008129;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 5:
								global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("❢dᅦhࡪ࡬佮ٰᩲŴὶ奸⥺ᱼ᭾ꖄ캆춈놊권", a_) + device.DeviceInfo.RadioID + global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("䍢Ѥͦ൨๪६乮", a_), global::System.Array.Empty<object>());
								global::System.Diagnostics.Trace.TraceInformation(string.Format(global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("㡢Ṥ坦ᑨ㙪㙬ᑮ䁰๲⡴ⱶɸ䥺|≾\uda80뚄惘품킊첌힒슞猪\ud8a2醤\udaa6횬骮첰閴\udcb8춺풼\udcbe꓀닄껆뷈ꏊ鷎냐럒볔룖律鋚駜쇠飢폤髦짨諪觬诮铰韲퓴", a_), new object[]
								{
									device.DeviceInfo.ConnectionInfo.ConnectionType,
									device.DeviceInfo.Family,
									device.DeviceInfo.SerialNumber,
									device.DeviceInfo.ModelNumber,
									device.DeviceInfo.SoftwareVersion,
									device.DeviceInfo.CodeplugVersion,
									device.DeviceInfo.RadioID
								}));
								this.b[device.DeviceInfo.RadioID] = device;
								num = (short)1369636867;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_B8;
							IL_254:
							num = (short)1878589440;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_26C:
						goto IL_3CC;
						IL_B8:
						global::System.Threading.Monitor.Enter(obj, ref flag);
						num = (short)1225654274;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_9A;
					}
					finally
					{
						num = (short)775290882;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_2D8;
							case 1:
								global::System.Threading.Monitor.Exit(obj);
								num = (short)1672151040;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								IL_285:
								switch (0)
								{
								case 0:
									goto IL_2A1;
								}
								continue;
							}
							IL_2A1:
							if (flag)
							{
								num = (short)1939931137;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_2D8:
							num = (short)1886163317;
							short num3 = num;
							num = (short)1689358709;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_285;
							default:
								goto IL_30C;
							}
						}
						IL_30C:
						num = (short)1496121344;
						if (num != 0)
						{
						}
					}
					goto IL_322;
				}
				IL_70:
				if (device != null)
				{
					num = (short)519569408;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_322:
				obj = this.a;
				flag = false;
				num = (short)426835974;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_3CC:
			num = (short)1243283456;
			short num4 = num;
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00005430 File Offset: 0x00003630
		public void RemoveDevice(string deviceID)
		{
			int a_ = 13;
			short num = (short)687088011;
			short num2 = num;
			num = (short)1150165387;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_5DA:
				num = (short)1555496961;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)2093481984;
				if (num != 0)
				{
				}
				num = (short)2050752512;
				switch (num)
				{
				default:
					num = (short)144179200;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
				break;
			}
			for (;;)
			{
				switch (num3)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_A3;
					}
					continue;
				case 1:
					goto IL_5F3;
				case 2:
					return;
				}
				IL_A3:
				if (!string.IsNullOrEmpty(deviceID))
				{
					goto IL_5AB;
				}
				num = (short)1037565952;
				short num4 = num;
				num = (short)965541890;
				num3 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_5AB:
			num = (short)1487208449;
			if (num != 0)
			{
			}
			object obj = this.a;
			bool flag = false;
			goto IL_5DA;
			IL_5F3:
			try
			{
				switch (0)
				{
				case 0:
					goto IL_13F;
				}
				for (;;)
				{
					IL_FC:
					global::Motorola.Common.Communication.IMotoDevice motoDevice;
					switch (num3)
					{
					case 0:
						if (!this.b.TryGetValue(deviceID, out motoDevice))
						{
							num = (short)1209597961;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("♡ţၥŧ३५乭ݯ᭱sṵ塷ṹ᥻ࡽꚅ솇캉뚋꺍", a_) + deviceID + global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("䉡ᙣͥէթᩫ୭ᑯ危", a_), global::System.Array.Empty<object>());
						num = (short)900202506;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_3D3;
					case 2:
						num = (short)873857037;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						string format = global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("㥡ὣ噥ᕧ㝩㝫ᕭ䅯ཱ⥳⵵ͷ䡹Ż⍽\udb7f女랃ﮅ햇톉\ude8bﶏ﶑\udc97ﾙ쎟잡念ﶥ펧麩톫즱膳쮵骹\ud8bb\udbbd뚿ꯁꟃꏅ껉꧋뫍뇏뇑볓돕볗", a_);
						object[] array = new object[6];
						int num5 = 0;
						global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo = motoDevice.DeviceInfo;
						global::Motorola.Common.Communication.CommonUtil.ConnectionType? connectionType;
						if (deviceInfo == null)
						{
							connectionType = null;
						}
						else
						{
							global::Motorola.Common.Communication.CommonUtil.ConnectionInfo connectionInfo = deviceInfo.ConnectionInfo;
							connectionType = ((connectionInfo != null) ? new global::Motorola.Common.Communication.CommonUtil.ConnectionType?(connectionInfo.ConnectionType) : null);
						}
						array[num5] = connectionType;
						int num6 = 1;
						global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo2 = motoDevice.DeviceInfo;
						array[num6] = ((deviceInfo2 != null) ? new global::Motorola.Common.Communication.CommonUtil.ProductFamily?(deviceInfo2.Family) : null);
						int num7 = 2;
						global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo3 = motoDevice.DeviceInfo;
						array[num7] = ((deviceInfo3 != null) ? deviceInfo3.SerialNumber : null);
						int num8 = 3;
						global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo4 = motoDevice.DeviceInfo;
						array[num8] = ((deviceInfo4 != null) ? deviceInfo4.ModelNumber : null);
						int num9 = 4;
						global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo5 = motoDevice.DeviceInfo;
						array[num9] = ((deviceInfo5 != null) ? deviceInfo5.SoftwareVersion : null);
						int num10 = 5;
						global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo6 = motoDevice.DeviceInfo;
						array[num10] = ((deviceInfo6 != null) ? deviceInfo6.CodeplugVersion : null);
						global::System.Diagnostics.Trace.TraceInformation(string.Format(format, array));
						num = (short)1745485831;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						if (motoDevice.radioState != global::Motorola.Common.Communication.CommonUtil.RadioState.Ready)
						{
							num = (short)693829634;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3D3;
					case 5:
						if (motoDevice.DeviceInfo != null)
						{
							num = (short)649789451;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_40F;
					case 6:
						if (motoDevice.radioState == global::Motorola.Common.Communication.CommonUtil.RadioState.Removing)
						{
							num = (short)643956737;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_40F;
					case 7:
						goto IL_539;
					case 8:
						goto IL_1A2;
					case 9:
						num = (short)814743560;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
					{
						string format2 = global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("㥡ὣ噥ᕧ㝩㝫ᕭ䅯ཱ⥳⵵ͷ䡹Ż⍽\udb7f女랃ﮅ햇톉\ude8bﶏ﶑\udc97ﾙ쎟잡念ﶥ펧麩톫즱膳쮵骹\udbbd뚿ꯁꟃꏅ뷉ꗋ뫍룏냓돕껗동뿛믝샟ꯡꃣ\udce5죧釩\udaeb鏭탯胱釳鯵韷賹駻髽⇿", a_);
						object[] array2 = new object[7];
						int num11 = 0;
						global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo7 = motoDevice.DeviceInfo;
						array2[num11] = ((deviceInfo7 != null) ? new global::Motorola.Common.Communication.CommonUtil.ConnectionType?(deviceInfo7.ConnectionInfo.ConnectionType) : null);
						int num12 = 1;
						global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo8 = motoDevice.DeviceInfo;
						array2[num12] = ((deviceInfo8 != null) ? new global::Motorola.Common.Communication.CommonUtil.ProductFamily?(deviceInfo8.Family) : null);
						int num13 = 2;
						global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo9 = motoDevice.DeviceInfo;
						array2[num13] = ((deviceInfo9 != null) ? deviceInfo9.SerialNumber : null);
						int num14 = 3;
						global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo10 = motoDevice.DeviceInfo;
						array2[num14] = ((deviceInfo10 != null) ? deviceInfo10.ModelNumber : null);
						int num15 = 4;
						global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo11 = motoDevice.DeviceInfo;
						array2[num15] = ((deviceInfo11 != null) ? deviceInfo11.SoftwareVersion : null);
						int num16 = 5;
						global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo12 = motoDevice.DeviceInfo;
						array2[num16] = ((deviceInfo12 != null) ? deviceInfo12.CodeplugVersion : null);
						array2[6] = deviceID;
						global::System.Diagnostics.Trace.TraceInformation(string.Format(format2, array2));
						this.b.Remove(deviceID);
						num = (short)950140933;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
						num = (short)1323302916;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						goto IL_40F;
					case 13:
						if (motoDevice.radioState != global::Motorola.Common.Communication.CommonUtil.RadioState.Busy)
						{
							num = (short)384434190;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3D3;
					case 14:
						num = (short)1567293446;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_13F;
					IL_3D3:
					this.b(motoDevice.DeviceInfo);
					global::Motorola.Common.Communication.CommonUtil.SingletonBase<global::Motorola.Common.Communication.DeviceDiscovery.DNSSDDetector>.Instance().ClearDevice(motoDevice.DeviceInfo.RadioID);
					num = (short)1604648972;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_40F:
					motoDevice.radioState = global::Motorola.Common.Communication.CommonUtil.RadioState.Detached;
					num = (short)362545155;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_1A2:
				IL_539:
				return;
				IL_13F:
				global::System.Threading.Monitor.Enter(obj, ref flag);
				num = (short)1698496512;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_FC;
			}
			finally
			{
				num = (short)948109312;
				num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_571;
						}
						continue;
					case 1:
						goto IL_5A8;
					case 2:
						global::System.Threading.Monitor.Exit(obj);
						num = (short)126418945;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_571:
					if (!flag)
					{
						break;
					}
					num = (short)525860866;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_5A8:;
			}
			goto IL_5AB;
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00005A54 File Offset: 0x00003C54
		public void ReDetectDevice(string deviceID)
		{
			int a_ = 2;
			switch (0)
			{
			case 0:
				goto IL_39;
			}
			int num;
			global::Motorola.Common.Communication.IMotoDevice motoDevice;
			short num2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					motoDevice.Prefetch();
					num2 = (short)123600903;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					if (this.DiscoveryWorkMode == global::Motorola.Common.Communication.CommonUtil.WorkMode.Active)
					{
						num2 = (short)1410465797;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 2:
					if (!string.IsNullOrEmpty(deviceID))
					{
						num2 = (short)1604190211;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 3:
				{
					object obj = this.a;
					bool flag = false;
					goto IL_DE;
				}
				case 4:
					if (motoDevice != null)
					{
						num2 = (short)943587328;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 5:
					num2 = (short)1944453124;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
				{
					try
					{
						switch (0)
						{
						case 0:
							goto IL_156;
						}
						for (;;)
						{
							IL_124:
							switch (num)
							{
							case 0:
								goto IL_2F1;
							case 1:
								goto IL_1BD;
							case 2:
								this.b(motoDevice.DeviceInfo);
								num2 = (short)795017226;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 3:
								if (motoDevice.radioState != global::Motorola.Common.Communication.CommonUtil.RadioState.Ready)
								{
									num2 = (short)2077753353;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								goto IL_1BD;
							case 4:
								motoDevice = this.b[deviceID];
								global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("ፖ㱘ⵚ㑜㱞Ѡ䍢", a_) + deviceID + global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("睖⭘㹚ᥜ㩞ᕠ٢٤፦౨ཪ䱬", a_), global::System.Array.Empty<object>());
								num2 = (short)570818563;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 5:
								if (this.b.ContainsKey(deviceID))
								{
									num2 = (short)1313734660;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								goto IL_2D9;
							case 6:
								goto IL_2D9;
							case 7:
								if (motoDevice.DeviceInfo != null)
								{
									num2 = (short)59637762;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								goto IL_19A;
							case 8:
								if (motoDevice.radioState == global::Motorola.Common.Communication.CommonUtil.RadioState.Busy)
								{
									num2 = (short)22151169;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								goto IL_19A;
							case 9:
								num2 = (short)958201864;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 10:
								goto IL_19A;
							}
							goto IL_156;
							IL_19A:
							motoDevice.radioState = global::Motorola.Common.Communication.CommonUtil.RadioState.Attached;
							num2 = (short)2100690950;
							num = (int)((global::System.IntPtr)num2);
							continue;
							IL_1BD:
							num2 = (short)484245511;
							num = (int)((global::System.IntPtr)num2);
							continue;
							IL_2D9:
							num2 = (short)1629618176;
							num = (int)((global::System.IntPtr)num2);
						}
						IL_2F1:
						goto IL_35A;
						IL_156:
						object obj;
						bool flag;
						global::System.Threading.Monitor.Enter(obj, ref flag);
						num2 = (short)1943732229;
						num = (int)((global::System.IntPtr)num2);
						goto IL_124;
					}
					finally
					{
						num2 = (short)694550528;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_324;
								}
								continue;
							case 1:
								goto IL_357;
							case 2:
							{
								object obj;
								global::System.Threading.Monitor.Exit(obj);
								num2 = (short)1839661057;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							}
							IL_324:
							bool flag;
							if (!flag)
							{
								break;
							}
							num2 = (short)1911881730;
							num = (int)((global::System.IntPtr)num2);
						}
						IL_357:;
					}
					IL_35A:
					num2 = (short)1343422464;
					short num3 = num2;
					num2 = (short)979039964;
					short num4 = num2;
					num2 = (short)349566684;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_DE;
					default:
						num2 = (short)189267968;
						if (num2 != 0)
						{
						}
						num2 = (short)1015742465;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 7:
					return;
				}
				goto IL_39;
				IL_DE:
				num2 = (short)745209862;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_39:
			motoDevice = null;
			num2 = (short)184221697;
			if (num2 != 0)
			{
			}
			num2 = (short)917506;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00005E88 File Offset: 0x00004088
		public void RemoveNonPlugPlayDevice(string deviceID)
		{
			int a_ = 11;
			short num = (short)670695424;
			short num2 = num;
			num = (short)276299777;
			if (num != 0)
			{
			}
			num = (short)1631649792;
			int num3 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1652303202;
				short num4 = num;
				num = (short)1243096418;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return;
				default:
				{
					num = (short)113639424;
					if (num != 0)
					{
					}
					object obj;
					bool flag;
					switch (num3)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_D7;
						}
						continue;
					case 1:
						try
						{
							switch (0)
							{
							case 0:
								goto IL_14F;
							}
							for (;;)
							{
								IL_105:
								switch (num3)
								{
								case 0:
									goto IL_3DF;
								case 1:
									goto IL_1BB;
								case 2:
									if (this.c != null)
									{
										num = (short)1573978123;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_28B;
								case 3:
									goto IL_3C7;
								case 4:
									num = (short)512360457;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									num = (short)6422541;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									num = (short)728170508;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
									goto IL_39F;
								case 8:
									if (this.c.ContainsKey(deviceID))
									{
										num = (short)1506672644;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_28B;
								case 9:
								{
									global::Motorola.Common.Communication.CommonUtil.TraceLogger instance = global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance;
									if (instance == null)
									{
										num = (short)1811021825;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									instance.WriteVerbose(global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("≟๡ൣࡥ౧䩩ᱫ᭭ͯᩱ味㉵ᵷ౹ᕻᵽꊁ", a_) + deviceID + global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("䁟ၡţ୥ݧᱩ५੭兯", a_), global::System.Array.Empty<object>());
									num = (short)89128974;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 10:
									goto IL_1DF;
								case 11:
									num = (short)1415512072;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 12:
								{
									global::Motorola.Common.Communication.CommonUtil.TraceLogger instance2 = global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance;
									if (instance2 == null)
									{
										num = (short)1473183751;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									instance2.WriteVerbose(global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("≟ൡୣብ䡧ݩͫ੭ᕯ剱び፵๷፹ύ᭽ꁿ", a_) + deviceID + global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("䁟ၡţ୥ݧᱩ५੭兯", a_), global::System.Array.Empty<object>());
									num = (short)136511504;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 13:
									if (this.d.ContainsKey(deviceID))
									{
										num = (short)937754630;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_3C7;
								case 14:
									goto IL_1BB;
								case 15:
									if (this.d != null)
									{
										num = (short)974192645;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_3C7;
								case 16:
									goto IL_39F;
								}
								goto IL_14F;
								IL_1BB:
								this.c.Remove(deviceID);
								num = (short)926482442;
								num3 = (int)((global::System.IntPtr)num);
								continue;
								IL_28B:
								num = (short)1152712719;
								num3 = (int)((global::System.IntPtr)num);
								continue;
								IL_39F:
								this.d.Remove(deviceID);
								num = (short)138477571;
								num3 = (int)((global::System.IntPtr)num);
								continue;
								IL_3C7:
								num = (short)1031208960;
								num3 = (int)((global::System.IntPtr)num);
							}
							IL_1DF:
							IL_3DF:
							return;
							IL_14F:
							global::System.Threading.Monitor.Enter(obj, ref flag);
							num = (short)989462530;
							num3 = (int)((global::System.IntPtr)num);
							goto IL_105;
						}
						finally
						{
							num = (short)1395654656;
							num3 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num3)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_414;
									}
									continue;
								case 1:
									goto IL_447;
								case 2:
									global::System.Threading.Monitor.Exit(obj);
									num = (short)649396225;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_414:
								if (!flag)
								{
									break;
								}
								num = (short)1598816258;
								num3 = (int)((global::System.IntPtr)num);
							}
							IL_447:;
						}
						goto IL_44A;
					case 2:
						goto IL_44A;
					}
					IL_D7:
					if (!string.IsNullOrEmpty(deviceID))
					{
						num = (short)1255276546;
						num3 = (int)((global::System.IntPtr)num);
						break;
					}
					return;
					IL_44A:
					obj = this.a;
					flag = false;
					num = (short)590807041;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
				}
			}
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00006320 File Offset: 0x00004520
		public global::Motorola.Common.Communication.IMotoDevice GetDevice(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo)
		{
			switch (0)
			{
			case 0:
				goto IL_64;
			}
			int num;
			short num2;
			global::Motorola.Common.Communication.IMotoDevice motoDevice;
			string managedRadioId;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2 = (short)169869322;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					if (motoDevice.DeviceInfo.Family == global::Motorola.Common.Communication.CommonUtil.ProductFamily.PCRRadio)
					{
						num2 = (short)67305472;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_66D;
				case 2:
					num2 = (short)1800601611;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					num2 = (short)1874657281;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					if (motoDevice != null)
					{
						num2 = (short)2114977799;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_726;
				case 5:
					try
					{
						num2 = (short)797835287;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
								num2 = (short)1288830983;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 1:
								goto IL_59C;
							case 2:
								num2 = (short)1287585808;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 3:
								motoDevice.DeviceInfo.ConnectionInfo.AuthInfo.PreSharedKey_ID = deviceInfo.ConnectionInfo.AuthInfo.PreSharedKey_ID;
								motoDevice.DeviceInfo.ConnectionInfo.AuthInfo.PreSharedKey_Material = deviceInfo.ConnectionInfo.AuthInfo.PreSharedKey_Material;
								num2 = (short)2063728641;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 4:
								if (deviceInfo.ConnectionInfo.ConnectionType != global::Motorola.Common.Communication.CommonUtil.ConnectionType.LENetwork)
								{
									num2 = (short)2047016978;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								goto IL_310;
							case 5:
								num2 = (short)1032978449;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 6:
								if (deviceInfo.ConnectionInfo.ConnectionType != global::Motorola.Common.Communication.CommonUtil.ConnectionType.Provisioning)
								{
									num2 = (short)672137218;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								goto IL_39E;
							case 7:
								if (deviceInfo.ConnectionInfo.ConnectionType != global::Motorola.Common.Communication.CommonUtil.ConnectionType.Bluetooth)
								{
									num2 = (short)1702821907;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								goto IL_39E;
							case 8:
								if (deviceInfo.ConnectionInfo.ConnectionType != global::Motorola.Common.Communication.CommonUtil.ConnectionType.LENetwork)
								{
									num2 = (short)718536719;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								goto IL_39E;
							case 9:
								if (deviceInfo.ConnectionInfo.AuthInfo != null)
								{
									num2 = (short)1714225155;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								goto IL_59C;
							case 10:
								goto IL_310;
							case 11:
								num2 = (short)586547204;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 12:
								goto IL_39E;
							case 13:
								if (deviceInfo.ConnectionInfo.ConnectionType != global::Motorola.Common.Communication.CommonUtil.ConnectionType.Otap)
								{
									num2 = (short)17760256;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								goto IL_39E;
							case 14:
								goto IL_5B3;
							case 15:
								num2 = (short)1639907334;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 16:
								if (deviceInfo.ConnectionInfo.ConnectionType != global::Motorola.Common.Communication.CommonUtil.ConnectionType.DMR3Network)
								{
									num2 = (short)2053111813;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								goto IL_39E;
							case 17:
								if (deviceInfo.ConnectionInfo.ConnectionType == global::Motorola.Common.Communication.CommonUtil.ConnectionType.WIFI)
								{
									num2 = (short)620822540;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								goto IL_54B;
							case 18:
								num2 = (short)1066663958;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 19:
								num2 = (short)845217800;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 20:
								num2 = (short)1710751757;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 21:
								if (deviceInfo.ConnectionInfo != null)
								{
									num2 = (short)1730215947;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								goto IL_59C;
							case 22:
								if (deviceInfo.ConnectionInfo.ConnectionType == global::Motorola.Common.Communication.CommonUtil.ConnectionType.DMR3Network)
								{
									num2 = (short)1028587530;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								goto IL_59C;
							case 23:
								switch (0)
								{
								case 0:
									goto IL_218;
								}
								continue;
							case 24:
								goto IL_59C;
							}
							IL_218:
							if (motoDevice == null)
							{
								num2 = (short)836239380;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							num2 = (short)919470101;
							num = (int)((global::System.IntPtr)num2);
							continue;
							IL_310:
							num2 = (short)2104426505;
							num = (int)((global::System.IntPtr)num2);
							continue;
							IL_39E:
							deviceInfo.RadioID = managedRadioId;
							motoDevice = global::Motorola.Common.Communication.CommunicationManager.BlindPushDeviceFactory.CreateRadio(deviceInfo, this, this.j, this.k);
							num2 = (short)2064384024;
							num = (int)((global::System.IntPtr)num2);
							continue;
							IL_59C:
							num2 = (short)1272774670;
							num = (int)((global::System.IntPtr)num2);
						}
						IL_54B:
						throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerDeviceNotFound);
						IL_5B3:
						return motoDevice;
					}
					catch (global::Motorola.Common.CustomException.CommonException ex)
					{
						if (ex.ErrorCode != global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_RadioIsBusy && motoDevice != null)
						{
							num2 = (short)2002888888;
							short num3 = num2;
							num2 = (short)791849144;
							switch ((num3 == num2) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								num2 = (short)1226768384;
								if (num2 != 0)
								{
								}
								motoDevice.FreeDeviceStatuse(false);
								this.RemoveNonPlugPlayDevice(managedRadioId);
								break;
							}
						}
						throw;
					}
					goto IL_627;
				case 6:
					if (deviceInfo != null)
					{
						num2 = (short)433061890;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_66D;
				case 7:
					motoDevice.DeviceInfo.ConnectionInfo.AuthInfoList = deviceInfo.ConnectionInfo.AuthInfoList;
					num2 = (short)229113871;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					goto IL_66D;
				case 9:
					num2 = (short)1827274772;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
					if (deviceInfo.Family != global::Motorola.Common.Communication.CommonUtil.ProductFamily.None)
					{
						num2 = (short)1076363283;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_66D;
				case 11:
					if (deviceInfo.ConnectionInfo != null)
					{
						num2 = (short)1104936978;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_66D;
				case 12:
					if (deviceInfo.ConnectionInfo.ConnectionType == global::Motorola.Common.Communication.CommonUtil.ConnectionType.Fudally)
					{
						num2 = (short)1900216337;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_66D;
				case 13:
					if ((global::Motorola.Common.Communication.CommonUtil.ProductFamily.PCRRadio & deviceInfo.Family) == deviceInfo.Family)
					{
						num2 = (short)1705705486;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_66D;
				case 14:
					motoDevice.DeviceInfo.Family = deviceInfo.Family;
					num2 = (short)75300872;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 15:
					goto IL_726;
				case 16:
					if (motoDevice != null)
					{
						num2 = (short)27066377;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_66D;
				case 17:
					num2 = (short)1070858256;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 18:
					goto IL_627;
				case 19:
					num2 = (short)336658433;
					if (num2 != 0)
					{
					}
					num2 = (short)2108096525;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 20:
					if (motoDevice.DeviceInfo != null)
					{
						num2 = (short)1822883843;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_66D;
				}
				goto IL_64;
				IL_627:
				num2 = (short)1804795916;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_66D:
				num2 = (short)344129540;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_726:
				num2 = (short)1371209728;
				short num4 = num2;
				num2 = (short)657719301;
				num = (int)((global::System.IntPtr)num2);
			}
			return motoDevice;
			IL_64:
			managedRadioId = this.GetManagedRadioId(deviceInfo);
			motoDevice = this.GetDevice(managedRadioId);
			num2 = (short)1140523014;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00006B70 File Offset: 0x00004D70
		public void DetectWiFiDevices()
		{
			short num = (short)478727383;
			short num2 = num;
			num = (short)1293667543;
			switch (num2 == num)
			{
			}
			num = (short)2104688640;
			if (num != 0)
			{
			}
			num = (short)1055260672;
			short num3 = num;
			num = (short)890503169;
			if (num != 0)
			{
			}
			this.i.Value.DetectWiFiDevices();
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00006C28 File Offset: 0x00004E28
		public global::Motorola.Common.Communication.IMotoDevice GetDevice(string deviceID)
		{
			short num = (short)897581057;
			int num2 = (int)((global::System.IntPtr)num);
			global::Motorola.Common.Communication.IMotoDevice result;
			for (;;)
			{
				num = (short)1713438720;
				short num3 = num;
				object obj;
				bool flag;
				switch (num2)
				{
				case 0:
					try
					{
						switch (0)
						{
						case 0:
							goto IL_B4;
						}
						for (;;)
						{
							IL_86:
							switch (num2)
							{
							case 0:
								goto IL_1B0;
							case 1:
								if (this.c.ContainsKey(deviceID))
								{
									num = (short)1680539653;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)67239943;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_11B;
							case 3:
								goto IL_187;
							case 4:
								result = this.b[deviceID];
								num = (short)361168898;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 5:
								result = this.c[deviceID];
								num = (short)971046912;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 6:
								goto IL_20F;
							case 7:
								if (this.d.ContainsKey(deviceID))
								{
									num = (short)54919177;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)691929094;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 8:
								if (this.b.ContainsKey(deviceID))
								{
									num = (short)1171980292;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)793247745;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 9:
								result = this.d[deviceID];
								num = (short)915537923;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_B4;
						}
						IL_11B:
						IL_187:
						IL_1B0:
						goto IL_2F7;
						IL_20F:
						goto IL_2F5;
						IL_B4:
						global::System.Threading.Monitor.Enter(obj, ref flag);
						num = (short)1574371336;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_86;
					}
					finally
					{
						num = (short)1432158209;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_2CB;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_245;
								}
								continue;
							case 2:
							{
								num = (short)839623553;
								short num4 = num;
								num = (short)445948801;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									num = (short)138936320;
									if (num != 0)
									{
									}
									global::System.Threading.Monitor.Exit(obj);
									break;
								}
								num = (short)2130706432;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							IL_245:
							if (!flag)
							{
								break;
							}
							num = (short)1329135618;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_2CB:;
					}
					goto IL_2CE;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_58;
					}
					continue;
				case 2:
					goto IL_2CE;
				}
				IL_58:
				if (!string.IsNullOrEmpty(deviceID))
				{
					num = (short)1037172738;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_2CE:
				obj = this.a;
				flag = false;
				num = (short)323223552;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_2F5:
			return null;
			IL_2F7:
			num = (short)1752236033;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00006F74 File Offset: 0x00005174
		private global::Motorola.Common.Communication.IMotoDevice a(string deviceID)
		{
			short num = (short)1763265233;
			short num2 = num;
			num = (short)525683409;
			switch (num2 == num)
			{
			}
			num = (short)1425932289;
			if (num != 0)
			{
			}
			num = (short)2095644672;
			short num3 = num;
			num = (short)1090519040;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.IMotoDevice device = this.GetDevice(deviceID);
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(device, global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerDeviceNotFound);
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(device.DeviceInfo, global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerNullDeviceInfo);
			return device;
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00007040 File Offset: 0x00005240
		public void Notify(object anObject)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			global::Motorola.Common.Communication.IMotoDevice motoDevice;
			short num2;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					goto IL_106;
				case 1:
					if (motoDevice.DeviceInfo.RadioState == global::Motorola.Common.Communication.CommonUtil.RadioState.Ready)
					{
						num2 = (short)415563778;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_130;
				case 2:
					goto IL_AC;
				}
				goto IL_1C;
			}
			IL_AC:
			this.e.Set();
			this.c(motoDevice.DeviceInfo);
			goto IL_C6;
			IL_106:
			num2 = (short)2010513409;
			if (num2 != 0)
			{
			}
			IL_130:
			motoDevice.UnRegister(this);
			return;
			IL_1C:
			motoDevice = (anObject as global::Motorola.Common.Communication.IMotoDevice);
			num2 = (short)12756332;
			short num3 = num2;
			num2 = (short)595174764;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_C6:
				num2 = (short)2126577664;
				short num4 = num2;
				num2 = (short)1616183296;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)1156907008;
				if (num2 != 0)
				{
				}
				num2 = (short)658374657;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00007184 File Offset: 0x00005384
		private void c(global::Motorola.Common.Communication.CommonUtil.DeviceInfo devInfo)
		{
			short num = (short)437321729;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					return;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				case 2:
				{
					num = (short)453443585;
					if (num != 0)
					{
					}
					num = (short)846219445;
					short num3 = num;
					num = (short)8210613;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)280690688;
						if (num != 0)
						{
						}
						num = (short)862584832;
						short num4 = num;
						this.OnDeviceConnected(devInfo.Copy());
						break;
					}
					}
					num = (short)1502150656;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_30:
				if (!this.g.HasFlag(devInfo.Family))
				{
					break;
				}
				num = (short)1924792322;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06000034 RID: 52 RVA: 0x000072C0 File Offset: 0x000054C0
		private void b(global::Motorola.Common.Communication.CommonUtil.DeviceInfo devInfo)
		{
			short num = (short)613220353;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					return;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				case 2:
				{
					num = (short)453144963;
					short num3 = num;
					num = (short)250638723;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1215037441;
						if (num != 0)
						{
						}
						num = (short)1545469952;
						if (num != 0)
						{
						}
						num = (short)794099712;
						short num4 = num;
						this.OnDeviceLost(devInfo.Copy());
						break;
					}
					}
					num = (short)2004221952;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_30:
				if (!this.g.HasFlag(devInfo.Family))
				{
					break;
				}
				num = (short)1911422978;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06000035 RID: 53 RVA: 0x000073F4 File Offset: 0x000055F4
		public string GetManagedRadioId(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo)
		{
			int a_ = 10;
			short num = (short)1099497480;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (deviceInfo.ConnectionInfo.ConnectionType != global::Motorola.Common.Communication.CommonUtil.ConnectionType.Otap)
					{
						num = (short)855310337;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1AE;
				case 1:
					num = (short)1899298825;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
				{
					if (deviceInfo.ConnectionInfo.ConnectionType != global::Motorola.Common.Communication.CommonUtil.ConnectionType.WIFI)
					{
						goto IL_274;
					}
					num = (short)2138614960;
					short num3 = num;
					num = (short)1391439024;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num = (short)1599864832;
						if (num != 0)
						{
						}
						num = (short)1417019399;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 3:
					num = (short)2050424837;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_D0;
				case 5:
					if (deviceInfo.ConnectionInfo.ConnectionType != global::Motorola.Common.Communication.CommonUtil.ConnectionType.Provisioning)
					{
						num = (short)714014726;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1AE;
				case 6:
					num = (short)1185742850;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					goto IL_162;
				case 8:
					switch (0)
					{
					case 0:
						goto IL_56;
					}
					continue;
				case 9:
					if (deviceInfo.ConnectionInfo.ConnectionType != global::Motorola.Common.Communication.CommonUtil.ConnectionType.Bluetooth)
					{
						num = (short)454033411;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1AE;
				}
				IL_56:
				num = (short)1129578496;
				short num4 = num;
				if (!string.IsNullOrEmpty(deviceInfo.RadioID))
				{
					num = (short)1976369153;
					if (num != 0)
					{
					}
					num = (short)1314717700;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					global::Motorola.Common.Communication.CommunicationManager.CommunicationManagerClass.a(deviceInfo);
					num = (short)672399360;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_D0:
			return deviceInfo.RadioID;
			IL_162:
			IL_1AE:
			return deviceInfo.Family.ToString() + global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("^", a_) + deviceInfo.ConnectionInfo.UniqueAddress;
			IL_274:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerUnsupportConnectionInfo);
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00007680 File Offset: 0x00005880
		private static void a(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo)
		{
			short num = (short)2118385670;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_5E;
				case 1:
					goto IL_14B;
				case 2:
					goto IL_123;
				case 3:
					if (deviceInfo.Family != global::Motorola.Common.Communication.CommonUtil.ProductFamily.None)
					{
						num = (short)315097092;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_19F;
				case 4:
					num = (short)1341587457;
					if (num != 0)
					{
					}
					num = (short)1378942978;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
				{
					num = (short)1899031150;
					short num3 = num;
					num = (short)970713710;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_123;
					default:
						num = (short)1786839040;
						if (num != 0)
						{
						}
						if (deviceInfo.ConnectionInfo == null)
						{
							num = (short)203685895;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					break;
				}
				case 6:
					switch (0)
					{
					case 0:
						goto IL_44;
					}
					continue;
				case 7:
					goto IL_E2;
				}
				IL_44:
				if (deviceInfo == null)
				{
					num = (short)462684160;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)1512112131;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_123:
				if (deviceInfo.Family == global::Motorola.Common.Communication.CommonUtil.ProductFamily.Any)
				{
					num = (short)61210625;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)5439493;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_5E:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerNullDeviceInfo);
			IL_E2:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerNullConnectionInfo);
			IL_14B:
			IL_19F:
			num = (short)961085440;
			short num4 = num;
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerUnknownDeviceFamily);
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00007864 File Offset: 0x00005A64
		public void ChangeFromBpToAp(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo)
		{
			int a_ = 2;
			short num = (short)32130600;
			short num2 = num;
			num = (short)619857448;
			switch (num2 == num)
			{
			}
			num = (short)1887567873;
			if (num != 0)
			{
			}
			num = (short)892928000;
			if (num != 0)
			{
			}
			num = (short)1860763648;
			short num3 = num;
			global::Motorola.Common.Communication.IMotoDevice device = this.GetDevice(deviceInfo);
			global::System.Diagnostics.Trace.TraceInformation(string.Format(global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("ౖ≘歚⁜ɞ㩠ᡢ呤ᩦ㑨なᙬ嵮౰⹲⹴౶䩸ٺ⁼⑾婢랂\uda86튈뢌첐좒ꆖ욚붜튠莢횤킦삨\udfaa캬잮\ud8b0\uddb2튴鞶춸풺鶼ﺾ釀꣄꣆귈껊", a_), new object[]
			{
				deviceInfo.ConnectionInfo.ConnectionType,
				deviceInfo.Family,
				deviceInfo.SerialNumber,
				deviceInfo.ModelNumber,
				deviceInfo.OperationId,
				deviceInfo.SoftwareVersion,
				deviceInfo.CodeplugVersion
			}));
			device.SwitchAmpRadioToApMode();
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00007990 File Offset: 0x00005B90
		public bool IsRadioInBpMode(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo)
		{
			short num = (short)447373286;
			short num2 = num;
			num = (short)691953638;
			switch (num2 == num)
			{
			}
			num = (short)1978990592;
			if (num != 0)
			{
			}
			num = (short)312475649;
			if (num != 0)
			{
			}
			num = (short)2140798976;
			short num3 = num;
			return (deviceInfo as global::Motorola.Common.Communication.CommonUtil.AmpDeviceInfo).ProcessorType == global::ProcessorType.BP;
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00007A48 File Offset: 0x00005C48
		public bool EstablishSecureConnection(global::Motorola.Common.Communication.CommonUtil.DeviceInfo device, string psk)
		{
			short num = (short)54329345;
			if (num != 0)
			{
			}
			num = (short)2069801587;
			short num2 = num;
			num = (short)153135731;
			switch (num2 == num)
			{
			}
			num = (short)777650176;
			if (num != 0)
			{
			}
			num = (short)1638531072;
			short num3 = num;
			return this.GetDevice(device).EstablishSecureConnection(psk);
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00007B04 File Offset: 0x00005D04
		public string GetPskId(global::Motorola.Common.Communication.CommonUtil.DeviceInfo device)
		{
			short num = (short)613026755;
			short num2 = num;
			num = (short)1184500675;
			switch (num2 == num)
			{
			}
			num = (short)2138177537;
			if (num != 0)
			{
			}
			num = (short)710344704;
			if (num != 0)
			{
			}
			num = (short)156827648;
			short num3 = num;
			return this.GetDevice(device).GetPskId();
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00007BB8 File Offset: 0x00005DB8
		public void UpdatePasswords(global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.AuthenticationInfo> passwords)
		{
			short num = (short)36744318;
			short num2 = num;
			num = (short)14396542;
			switch (num2 == num)
			{
			}
			num = (short)1949630465;
			if (num != 0)
			{
			}
			num = (short)474152960;
			if (num != 0)
			{
			}
			num = (short)636878848;
			short num3 = num;
			global::Motorola.Common.Communication.DeviceDiscovery.UDPDeviceManager.Instance.UpdatePasswords(passwords);
			global::Motorola.Common.Communication.CommonUtil.SingletonBase<global::Motorola.Common.Communication.DeviceDiscovery.DNSSDDetector>.Instance().UpdatePasswords(passwords);
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00007C78 File Offset: 0x00005E78
		public void DetachDevice(string serialnumber)
		{
			short num = (short)209015721;
			short num2 = num;
			num = (short)620647337;
			switch (num2 == num)
			{
			}
			num = (short)1426587649;
			if (num != 0)
			{
			}
			num = (short)550305792;
			if (num != 0)
			{
			}
			num = (short)1742471168;
			short num3 = num;
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00007D20 File Offset: 0x00005F20
		internal string FindDeviceWithSameIpAddressInCache(global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile profile)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			short num2;
			global::Motorola.Common.Communication.IMotoDevice value;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)850178275;
					short num3 = num2;
					num2 = (short)1614655715;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_8F;
					default:
						goto IL_F8;
					}
					break;
				}
				case 1:
					if (value != null)
					{
						num2 = (short)215089152;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_13B;
				case 2:
					value = this.b.FirstOrDefault(delegate(global::System.Collections.Generic.KeyValuePair<string, global::Motorola.Common.Communication.IMotoDevice> r)
					{
						short num5;
						if (r.Value.DeviceInfo.ConnectionInfo.UniqueAddress == profile.IPAddress)
						{
							num5 = (short)51271947;
							short num6 = num5;
							num5 = (short)1421170955;
							switch ((num6 == num5) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								num5 = (short)778829825;
								if (num5 != 0)
								{
								}
								num5 = (short)2059010048;
								if (num5 != 0)
								{
								}
								return r.Value.DeviceInfo.RadioID != profile.RadioIdString;
							}
						}
						num5 = (short)1291583488;
						short num7 = num5;
						return false;
					}).Value;
					goto IL_8F;
				case 3:
					if (profile != null)
					{
						num2 = (short)1843200002;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_13B;
				}
				goto IL_20;
				IL_8F:
				num2 = (short)1821376513;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_F8:
			num2 = (short)1393426432;
			if (num2 != 0)
			{
			}
			num2 = (short)502595584;
			short num4 = num2;
			return value.DeviceInfo.RadioID;
			IL_13B:
			num2 = (short)1622802433;
			if (num2 != 0)
			{
			}
			return null;
			IL_20:
			num2 = (short)1940455427;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00007E90 File Offset: 0x00006090
		public bool ContainWiFiDevice(string radioID)
		{
			short num = (short)1956511745;
			if (num != 0)
			{
			}
			num = (short)861739750;
			short num2 = num;
			num = (short)718674662;
			switch (num2 == num)
			{
			}
			num = (short)792985600;
			if (num != 0)
			{
			}
			num = (short)2012479488;
			short num3 = num;
			return this.b.ContainsKey(radioID);
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00007F44 File Offset: 0x00006144
		public bool AttachDevice(global::Motorola.Common.Communication.IRadioProfile radioProf)
		{
			short num = (short)567113436;
			short num2 = num;
			num = (short)37320412;
			switch (num2 == num)
			{
			}
			num = (short)430702592;
			if (num != 0)
			{
			}
			num = (short)1750532097;
			if (num != 0)
			{
			}
			num = (short)1919090688;
			short num3 = num;
			return this.i.Value.AttachDevice(radioProf);
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00008000 File Offset: 0x00006200
		public bool DetachDevice(global::Motorola.Common.Communication.IRadioProfile radioProf)
		{
			short num = (short)2135491713;
			short num2 = num;
			num = (short)1694827649;
			switch (num2 == num)
			{
			}
			num = (short)855834625;
			if (num != 0)
			{
			}
			num = (short)1075183616;
			if (num != 0)
			{
			}
			num = (short)1931804672;
			short num3 = num;
			return this.i.Value.DetachDevice(radioProf);
		}

		// Token: 0x06000041 RID: 65 RVA: 0x000080BC File Offset: 0x000062BC
		protected virtual void Dispose(bool disposing)
		{
			short num = (short)228567700;
			short num2 = num;
			num = (short)215657108;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1836253185;
				if (num != 0)
				{
				}
				num = (short)911147008;
				if (num != 0)
				{
				}
				num = (short)2117074947;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						return;
					case 1:
					{
						global::System.Threading.AutoResetEvent autoResetEvent = this.e;
						if (autoResetEvent == null)
						{
							return;
						}
						autoResetEvent.Dispose();
						num = (short)1039400960;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
					{
						num = (short)1865351168;
						short num4 = num;
						num = (short)211419137;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						switch (0)
						{
						case 0:
							goto IL_A5;
						}
						continue;
					}
					IL_A5:
					if (!disposing)
					{
						return;
					}
					num = (short)2038038530;
					num3 = (int)((global::System.IntPtr)num);
				}
				return;
			}
			}
		}

		// Token: 0x06000042 RID: 66 RVA: 0x000081F8 File Offset: 0x000063F8
		public void Dispose()
		{
			short num = (short)1866531583;
			short num2 = num;
			num = (short)1180566271;
			switch (num2 == num)
			{
			}
			num = (short)2060189697;
			if (num != 0)
			{
			}
			num = (short)2036203520;
			if (num != 0)
			{
			}
			num = (short)604569600;
			short num3 = num;
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x06000043 RID: 67 RVA: 0x000082B0 File Offset: 0x000064B0
		// Note: this type is marked as 'beforefieldinit'.
		static CommunicationManagerClass()
		{
			short num = (short)1093107457;
			short num2 = num;
			num = (short)1356562177;
			switch (num2 == num)
			{
			}
			num = (short)1555759105;
			if (num != 0)
			{
			}
			num = (short)262144000;
			if (num != 0)
			{
			}
			num = (short)1331494912;
			short num3 = num;
			global::Motorola.Common.Communication.CommunicationManager.CommunicationManagerClass.f = 30000;
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00008360 File Offset: 0x00006560
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool a(global::Motorola.Common.Communication.IMotoDevice A_0)
		{
			if (A_0.DeviceInfo == null)
			{
				short num = (short)1726868659;
				short num2 = num;
				num = (short)1176759475;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)131923968;
					short num3 = num;
					num = (short)224133120;
					if (num != 0)
					{
					}
					num = (short)271384577;
					if (num != 0)
					{
					}
					return false;
				}
				}
			}
			return this.g.HasFlag(A_0.DeviceInfo.Family);
		}

		// Token: 0x04000005 RID: 5
		private readonly object a = new object();

		// Token: 0x04000006 RID: 6
		private readonly global::System.Collections.Generic.Dictionary<string, global::Motorola.Common.Communication.IMotoDevice> b = new global::System.Collections.Generic.Dictionary<string, global::Motorola.Common.Communication.IMotoDevice>();

		// Token: 0x04000007 RID: 7
		private readonly global::System.Collections.Generic.Dictionary<string, global::Motorola.Common.Communication.IMotoDevice> c = new global::System.Collections.Generic.Dictionary<string, global::Motorola.Common.Communication.IMotoDevice>();

		// Token: 0x04000008 RID: 8
		private readonly global::System.Collections.Generic.Dictionary<string, global::Motorola.Common.Communication.IMotoDevice> d = new global::System.Collections.Generic.Dictionary<string, global::Motorola.Common.Communication.IMotoDevice>();

		// Token: 0x04000009 RID: 9
		private readonly global::System.Threading.AutoResetEvent e = new global::System.Threading.AutoResetEvent(false);

		// Token: 0x0400000A RID: 10
		private static int f;

		// Token: 0x0400000B RID: 11
		private global::Motorola.Common.Communication.CommonUtil.ProductFamily g = global::Motorola.Common.Communication.CommonUtil.ProductFamily.Any;

		// Token: 0x0400000C RID: 12
		private bool h;

		// Token: 0x0400000D RID: 13
		private readonly global::System.Lazy<global::Motorola.Common.Communication.CommunicationManager.MotoDeviceDetector> i;

		// Token: 0x0400000E RID: 14
		private readonly global::Motorola.Common.Communication.CommunicationManager.ISequenceManagerFactory j;

		// Token: 0x0400000F RID: 15
		private readonly global::Motorola.Common.Communication.CommunicationManager.ICommunicationPipeFactory k;

		// Token: 0x04000010 RID: 16
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.Common.Communication.CommonUtil.WorkMode l;
	}
}
