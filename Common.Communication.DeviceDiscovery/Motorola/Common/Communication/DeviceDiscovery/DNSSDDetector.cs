using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Timers;
using DeviceDiscovery.DNSSDDecoder;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.DeviceDiscovery
{
	// Token: 0x02000012 RID: 18
	public class DNSSDDetector : global::Motorola.Common.Communication.DeviceDiscovery.LDTDetectorBase, global::System.IDisposable
	{
		// Token: 0x06000066 RID: 102 RVA: 0x000068A0 File Offset: 0x00004AA0
		public DNSSDDetector()
		{
			this._detectorType = global::Motorola.Common.Communication.DeviceDiscovery.DeviceDetectorType.DNSSDDetector;
			global::Motorola.Common.Communication.DeviceDiscovery.DNSSDDetector.c = new global::Motorola.Common.Communication.DnsConfig();
			global::Motorola.Common.Communication.DeviceDiscovery.DNSSDDetector.c.LoadConfig(global::Motorola.Common.Communication.DnsConfigConstants.ConfigFilePath);
			this.b = global::System.Net.IPAddress.Parse(global::Motorola.Common.Communication.DeviceDiscovery.DNSSDDetector.c.GroupIP);
			byte[] array = new byte[65535];
			int num = new global::Motorola.Common.Communication.DnsQueryMessage(global::Motorola.Common.Communication.DeviceDiscovery.DNSSDDetector.c.OTAPTCP, 12).BuildCommandMessage(array);
			global::Motorola.Common.Communication.DeviceDiscovery.DNSSDDetector.a = new byte[num];
			global::System.Array.Copy(array, global::Motorola.Common.Communication.DeviceDiscovery.DNSSDDetector.a, num);
		}

		// Token: 0x06000067 RID: 103 RVA: 0x000069B4 File Offset: 0x00004BB4
		public override bool Start()
		{
			int a_ = 11;
			switch (0)
			{
			case 0:
				goto IL_39;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					while (global::Motorola.Common.Communication.DeviceDiscovery.DNSSDDetector.c.Port != 0)
					{
						num2 = (short)1076102457;
						short num3 = num2;
						num2 = (short)2039350585;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_1FD;
						}
					}
					num2 = (short)234487809;
					if (num2 != 0)
					{
					}
					num2 = (short)1065091073;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					goto IL_11D;
				case 2:
					num2 = (short)1576402949;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					num2 = (short)635240448;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					num2 = (short)1123549191;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					if (!string.IsNullOrEmpty(global::Motorola.Common.Communication.DeviceDiscovery.DNSSDDetector.c.OTAPTCP))
					{
						num2 = (short)439353348;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1AA;
				case 6:
					if (!string.IsNullOrEmpty(global::Motorola.Common.Communication.DeviceDiscovery.DNSSDDetector.c.GroupIP))
					{
						num2 = (short)304807938;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1AA;
				case 7:
					if (!string.IsNullOrEmpty(global::Motorola.Common.Communication.DeviceDiscovery.DNSSDDetector.c.PasswordIndex))
					{
						num2 = (short)1005780995;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1AA;
				}
				goto IL_39;
			}
			IL_11D:
			IL_1AA:
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("้ɋᵍ͏ᙑၓ㍕ⱗ㽙㽛⩝ཟၡ䑣ᑥ൧३५ݭٯ᝱味ɵၷࡹ᥻ώꊁ꺍ﶓ歹ﶗﺙ늛낝躟", a_), global::System.Array.Empty<object>());
			return false;
			IL_1FD:
			num2 = (short)522125312;
			if (num2 != 0)
			{
			}
			this.g = new global::System.Threading.Thread(new global::System.Threading.ThreadStart(this.b));
			this.g.Start();
			this._receiveThread = new global::System.Threading.Thread(new global::System.Threading.ThreadStart(this.c));
			this._receiveThread.Start();
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("้ɋᵍ͏ᙑၓ㍕ⱗ㽙㽛⩝ཟၡ䑣ᑥ൧३५ݭٯ᝱味ɵၷࡹ᥻ώꊁ", a_), global::System.Array.Empty<object>());
			return true;
			IL_39:
			num2 = (short)949616640;
			short num4 = num2;
			this.j.Reset();
			this._isStopping = false;
			num2 = (short)854130694;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00006C38 File Offset: 0x00004E38
		public override void Stop()
		{
			int a_ = 10;
			short num = (short)1843791688;
			short num2 = num;
			num = (short)122488648;
			switch (num2 == num)
			{
			}
			num = (short)891420672;
			if (num != 0)
			{
			}
			num = (short)2042953729;
			if (num != 0)
			{
			}
			num = (short)1672216576;
			short num3 = num;
			this._isStopping = true;
			this.j.Set();
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("ൈՊṌᱎᕐᝒご⍖㱘㡚⥜ぞ፠䍢ᝤɦ੨๪Ѭ᥮ᑰ卲Ŵὶ୸Ṻᱼ᭾ꆀ麗ﮊ", a_), global::System.Array.Empty<object>());
			this.h.Set();
			this.ab.Stop();
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00006D30 File Offset: 0x00004F30
		public void JoinMulticastGroupAndRequestServiceRecord(global::System.Net.NetworkInformation.NetworkInterface[] latestNetworkAdapterArray, bool reset)
		{
			int a_ = 13;
			short num = (short)2119106560;
			switch (num)
			{
			default:
			{
				num = (short)738656268;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					int num4;
					switch (num2)
					{
					case 0:
						goto IL_59B;
					case 1:
						goto IL_5D4;
					case 2:
					{
						global::System.Net.NetworkInformation.NetworkInterface networkInterface;
						if (networkInterface.OperationalStatus == global::System.Net.NetworkInformation.OperationalStatus.Up)
						{
							num = (short)1418133509;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3BD;
					}
					case 3:
						try
						{
							switch (0)
							{
							case 0:
								goto IL_F5;
							}
							global::System.Net.NetworkInformation.NetworkInterface networkInterface;
							global::System.Net.IPAddress ipaddress;
							global::System.Collections.Generic.IEnumerator<global::System.Net.NetworkInformation.UnicastIPAddressInformation> enumerator;
							for (;;)
							{
								IL_DA:
								switch (num2)
								{
								case 0:
									goto IL_34A;
								case 1:
									if (ipaddress == null)
									{
										num = (short)541261828;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.Common.Communication.DeviceDiscovery.DNSSDDetector.e.JoinMulticastGroup(this.b, ipaddress);
									this.multicastConnectedAdapterList.Add(networkInterface);
									global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("ً⅍㥏㱑㵓㡕㽗穙ㅛ⭝౟ᙡൣե१ᥩᡫ乭ᝯq᭳͵ࡷ婹㕻⹽멿女뒃ﮅꢇ꺍ﾙ뺝麣\udda5馧힩", a_), new object[]
									{
										this.b,
										ipaddress
									});
									num = (short)1522270208;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_2E1;
								case 3:
									try
									{
										num = (short)831717381;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												goto IL_20A;
											case 1:
											{
												if (!enumerator.MoveNext())
												{
													num = (short)122355712;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												global::System.Net.NetworkInformation.IPAddressInformation ipaddressInformation = enumerator.Current;
												num = (short)1520369666;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 2:
											{
												global::System.Net.NetworkInformation.IPAddressInformation ipaddressInformation;
												if (ipaddressInformation.Address.AddressFamily == global::System.Net.Sockets.AddressFamily.InterNetwork)
												{
													num = (short)1807024132;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											case 3:
												goto IL_222;
											case 4:
											{
												global::System.Net.NetworkInformation.IPAddressInformation ipaddressInformation;
												ipaddress = ipaddressInformation.Address;
												num = (short)446824454;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 5:
												switch (0)
												{
												case 0:
													goto IL_165;
												}
												continue;
											case 6:
												goto IL_20A;
											}
											IL_167:
											num = (short)2015952897;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_165:
											goto IL_167;
											IL_20A:
											num = (short)374865923;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_222:;
									}
									finally
									{
										num = (short)443482113;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												goto IL_290;
											case 1:
												switch (0)
												{
												case 0:
													goto IL_257;
												}
												continue;
											case 2:
												enumerator.Dispose();
												num = (short)1182138368;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											IL_257:
											if (enumerator == null)
											{
												break;
											}
											num = (short)136314882;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_290:;
									}
									num = (short)452853761;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									num = (short)1471610882;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_F5;
							}
							IL_2E1:
							IL_34A:
							goto IL_3BD;
							IL_F5:
							ipaddress = null;
							enumerator = networkInterface.GetIPProperties().UnicastAddresses.GetEnumerator();
							num = (short)1102839811;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_DA;
						}
						catch (global::System.Exception ex)
						{
							global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("ᡋ♍㕏牑ၓ㍕⹗㍙㽛㭝䁟㉡ᙣ॥ཧᡩ൫ͭᵯ᝱ٳ噵ᕷ፹᭻ᙽꊁﲇꪉ낏ﮓﾙﾛ얟욡蒣튥잧誩춫躭ﺯힱ삳솵ힷ좹ힻ麽覿곁냃ꏅ뫇곉귋귍뗏ꇑ䀘苕냗동꿛ﻝ跟诡菣軥鳧쫩跫裭雯韱音苵\ud8f7諹軻釽柿瀁攃欅攇按戋植』怑甓爕焗甙漛㸝嘟䬡䔣إ缧䌩ī栭夯ᰱᐳ缵帷ᨹ崻堽☿❁❃㉅ⵇ⹉恋湍⁏㹑ㅓ㝕⭗㽙籛㵝࡟ݡݣ൥䡧ṩѫ୭偯ᱱᅳɵཷᕹ๻ᕽꁿ揄憐﶑望뚕聯뺝튟잡힣튥즧\ud8a9\ud8ab躭쒯\udab1톳隵鲻諾ꖿ듁귃ꗅ귇鳋볍뿏뗑ꛓ럕뗗럙맛곝컟", a_) + ex.Message, global::System.Array.Empty<object>());
							goto IL_3BD;
						}
						goto IL_379;
					case 4:
						goto IL_5D9;
					case 5:
						goto IL_557;
					case 6:
					{
						global::System.Net.NetworkInformation.NetworkInterface networkInterface;
						if (networkInterface.SupportsMulticast)
						{
							num = (short)630128651;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3BD;
					}
					case 7:
						goto IL_59B;
					case 8:
					{
						global::System.Net.NetworkInformation.NetworkInterface networkInterface;
						if (networkInterface.NetworkInterfaceType != global::System.Net.NetworkInformation.NetworkInterfaceType.Loopback)
						{
							num = (short)1447493635;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3BD;
					}
					case 9:
					{
						global::System.Collections.Generic.List<global::System.Net.NetworkInformation.NetworkInterface>.Enumerator enumerator2 = this.multicastConnectedAdapterList.GetEnumerator();
						num = (short)1908932618;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						try
						{
							num = (short)1670905859;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.List<global::System.Net.NetworkInformation.NetworkInterface>.Enumerator enumerator2;
								switch (num2)
								{
								case 0:
									goto IL_544;
								case 1:
									try
									{
										global::Motorola.Common.Communication.DeviceDiscovery.DNSSDDetector.e.DropMulticastGroup(this.b);
										break;
									}
									catch (global::System.Exception ex2)
									{
										global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("ᡋ♍㕏牑ၓ㍕⹗㍙㽛㭝䁟㉡ᙣ॥ཧᡩ൫ͭᵯ᝱ٳ噵ᕷ፹᭻ᙽꊁﲇꪉ낏ﮓﾙﾛ얟욡蒣튥잧誩춫躭ﺯힱ삳솵ힷ좹ힻ麽覿곁냃ꏅ뫇곉귋귍뗏ꇑ䀘苕냗동꿛ﻝ跟诡菣軥鳧쫩跫裭雯韱音苵\ud8f7諹軻釽柿瀁攃欅攇按戋植』怑甓爕焗甙漛㸝嘟䬡䔣إ缧䌩ī栭夯ᰱᐳ缵帷ᨹ崻堽☿❁❃㉅ⵇ⹉恋湍⁏㹑ㅓ㝕⭗㽙籛㵝࡟ݡݣ൥䡧ṩѫ୭偯ᱱᅳɵཷᕹ๻ᕽꁿ揄憐﶑望뚕聯뺝튟잡힣튥즧\ud8a9\ud8ab躭쒯\udab1톳隵鲻諾ꖿ듁귃ꗅ귇鳋볍뿏뗑ꛓ럕뗗럙맛곝컟", a_) + ex2.Message, global::System.Array.Empty<object>());
										break;
									}
									goto IL_480;
								case 2:
									num = (short)1463615488;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_441;
									}
									continue;
								case 4:
									if (!enumerator2.MoveNext())
									{
										num = (short)173015042;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_480;
								}
								goto IL_441;
								IL_480:
								global::System.Net.NetworkInformation.NetworkInterface networkInterface2 = enumerator2.Current;
								num = (short)2056912897;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_4A0:
								num = (short)1655850874;
								short num3 = num;
								num = (short)1002784634;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_544;
								default:
									num = (short)790036480;
									if (num != 0)
									{
									}
									num = (short)1022754820;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_441:
								goto IL_4A0;
							}
							IL_544:
							goto IL_66A;
						}
						finally
						{
							global::System.Collections.Generic.List<global::System.Net.NetworkInformation.NetworkInterface>.Enumerator enumerator2;
							((global::System.IDisposable)enumerator2).Dispose();
						}
						goto IL_557;
						IL_66A:
						this.multicastConnectedAdapterList.Clear();
						this.multicastDisconnectedAdapterList.Clear();
						global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("ŋ㭍㱏♑㵓㕕㥗⥙⡛繝ݟၡୣ፥ᡧ䩩࡫ᱭὯɱѳ፵ᱷ婹፻ၽꁿꢇ", a_), global::System.Array.Empty<object>());
						num = (short)1747189764;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						goto IL_379;
					case 12:
						switch (0)
						{
						case 0:
							goto IL_85;
						}
						continue;
					case 13:
					{
						if (num4 >= latestNetworkAdapterArray.Length)
						{
							num = (short)1632108545;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Net.NetworkInformation.NetworkInterface networkInterface = latestNetworkAdapterArray[num4];
						num = (short)927858694;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_85:
					num = (short)514457601;
					if (num != 0)
					{
					}
					if (reset)
					{
						num = (short)783613961;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_5D9;
					IL_379:
					num = (short)1125711874;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3BD:
					num = (short)971243520;
					short num5 = num;
					num4++;
					num = (short)1927938048;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_557:
					num = (short)1715470344;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_59B:
					num = (short)1584267277;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5D9:
					num4 = 0;
					num = (short)390529031;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_5D4:
				this.DetectAllWiFiDevices();
				return;
			}
			}
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00007464 File Offset: 0x00005664
		public void DetectAllWiFiDevices()
		{
			short num = (short)1800827051;
			short num2 = num;
			num = (short)540700843;
			switch (num2 == num)
			{
			}
			num = (short)1584529409;
			if (num != 0)
			{
			}
			num = (short)940179456;
			if (num != 0)
			{
			}
			num = (short)2007629824;
			short num3 = num;
			global::Motorola.Common.Communication.DeviceDiscovery.DNSSDDetector.b(this.b.ToString());
		}

		// Token: 0x0600006B RID: 107 RVA: 0x0000751C File Offset: 0x0000571C
		public void ResolveNetworkAddressChangedCallback(object sender, global::System.EventArgs e)
		{
			int a_ = 5;
			short num;
			try
			{
				num = (short)1172373504;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					switch (0)
					{
					case 0:
						goto IL_84;
					}
					global::System.Net.NetworkInformation.NetworkInterface[] allNetworkInterfaces;
					int num3;
					global::System.Net.NetworkInformation.NetworkInterface[] array;
					bool flag2;
					for (;;)
					{
						IL_31:
						switch (num2)
						{
						case 0:
							if (this.multicastConnectedAdapterList.Count(new global::System.Func<global::System.Net.NetworkInformation.NetworkInterface, bool>(a2.b)) == 0)
							{
								num = (short)1910833160;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_944;
						case 1:
							num = (short)1218510853;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_5A1;
						case 3:
							if (this.multicastDisconnectedAdapterList.Count(new global::System.Func<global::System.Net.NetworkInformation.NetworkInterface, bool>(a2.c)) == 0)
							{
								num = (short)577306636;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_944;
						case 4:
							goto IL_A45;
						case 5:
							if (a2.a.NetworkInterfaceType != global::System.Net.NetworkInformation.NetworkInterfaceType.Loopback)
							{
								num = (short)1219559426;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_944;
						case 6:
							num = (short)1968504842;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
							try
							{
								num = (short)452263954;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										num = (short)1627586568;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										if (this.multicastDisconnectedAdapterList.Count(new global::System.Func<global::System.Net.NetworkInformation.NetworkInterface, bool>(b.d)) == 0)
										{
											num = (short)414187522;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_7BD;
									case 2:
										this.multicastDisconnectedAdapterList.Add(b.a);
										num = (short)1408892937;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 3:
									{
										if (allNetworkInterfaces.Count(new global::System.Func<global::System.Net.NetworkInformation.NetworkInterface, bool>(b.b)) > 0)
										{
											num = (short)442171406;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										bool flag = true;
										num = (short)26869766;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 4:
										if (this.multicastDisconnectedAdapterList.Count(new global::System.Func<global::System.Net.NetworkInformation.NetworkInterface, bool>(b.e)) > 0)
										{
											num = (short)2078343181;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									case 5:
										goto IL_931;
									case 6:
										goto IL_672;
									case 7:
										goto IL_918;
									case 8:
									{
										global::System.Net.NetworkInformation.NetworkInterface networkInterface;
										if (networkInterface.OperationalStatus != global::System.Net.NetworkInformation.OperationalStatus.Down)
										{
											num = (short)270270475;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 10:
										goto IL_918;
									case 11:
										num = (short)1139736580;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 12:
									{
										bool flag;
										if (flag)
										{
											num = (short)1271201807;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_7BD;
									}
									case 13:
										this.JoinMulticastGroupAndRequestServiceRecord(allNetworkInterfaces, true);
										num = (short)2093219850;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 14:
									{
										global::System.Net.NetworkInformation.NetworkInterface networkInterface = allNetworkInterfaces.First(new global::System.Func<global::System.Net.NetworkInformation.NetworkInterface, bool>(b.c));
										bool flag = networkInterface.OperationalStatus == global::System.Net.NetworkInformation.OperationalStatus.Down;
										num = (short)1472266257;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 15:
										num = (short)81330177;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 16:
									{
										global::System.Collections.Generic.List<global::System.Net.NetworkInformation.NetworkInterface>.Enumerator enumerator;
										if (!enumerator.MoveNext())
										{
											num = (short)1799028743;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::System.Net.NetworkInformation.NetworkInterface a = enumerator.Current;
										num = (short)244318211;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 17:
										goto IL_672;
									case 18:
										switch (0)
										{
										case 0:
											goto IL_66D;
										}
										continue;
									case 19:
									{
										global::System.Net.NetworkInformation.NetworkInterface networkInterface;
										if (networkInterface != null)
										{
											num = (short)1173159936;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									}
									goto IL_66D;
									IL_672:
									num = (short)2089877516;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_7BD:
									num = (short)1334116371;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_89B:
									num = (short)149946384;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_66D:
									goto IL_89B;
									IL_918:
									num = (short)548667397;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_931:
								goto IL_A2D;
							}
							finally
							{
								global::System.Collections.Generic.List<global::System.Net.NetworkInformation.NetworkInterface>.Enumerator enumerator;
								((global::System.IDisposable)enumerator).Dispose();
							}
							goto IL_944;
						case 8:
							num = (short)862584835;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 9:
							goto IL_AB;
						case 10:
							if (a2.a.OperationalStatus == global::System.Net.NetworkInformation.OperationalStatus.Up)
							{
								num = (short)1818492929;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_944;
						case 11:
						{
							if (num3 >= array.Length)
							{
								num = (short)1081147406;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Net.NetworkInformation.NetworkInterface a = array[num3];
							num = (short)98369551;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 12:
							flag2 = true;
							num = (short)2044067856;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 13:
							if (!flag2)
							{
								num = (short)513343506;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_A2D;
						case 14:
							num = (short)842006541;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 15:
							if (a2.a.SupportsMulticast)
							{
								num = (short)946864134;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_944;
						case 16:
							try
							{
								switch (0)
								{
								case 0:
									goto IL_21B;
								}
								global::System.Net.IPAddress ipaddress;
								global::System.Collections.Generic.IEnumerator<global::System.Net.NetworkInformation.UnicastIPAddressInformation> enumerator2;
								for (;;)
								{
									IL_1F0:
									switch (num2)
									{
									case 0:
										if (ipaddress == null)
										{
											num = (short)790102019;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_511;
									case 1:
										goto IL_552;
									case 2:
										goto IL_56C;
									case 3:
										num = (short)1313406981;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 4:
									{
										if (global::Motorola.Common.Communication.DeviceDiscovery.DNSSDDetector.e != null)
										{
											num = (short)770310150;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)70490957;
										short num4 = num;
										num = (short)1546623821;
										switch ((num4 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											goto IL_397;
										default:
											num = (short)873070592;
											if (num != 0)
											{
											}
											global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("Cࡅᭇ杉Ὃ੍灏ݑၓٕ硗㥙せ㝝՟ౡၣ䙥٧Ὡkɭ兯", a_), global::System.Array.Empty<object>());
											num = (short)1795227649;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 5:
										goto IL_397;
									case 6:
										global::Motorola.Common.Communication.DeviceDiscovery.DNSSDDetector.e.JoinMulticastGroup(this.b, ipaddress);
										global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("ใ⥅ⅇ⑉╋⁍㝏牑㥓⍕㑗⹙㕛㵝şᅡၣ䙥ཧᡩͫ᭭o剱㵳♵䉷Ź䱻ͽꁿꚅﺍ뚕톗쪙ꚛ醟\udfa1", a_), new object[]
										{
											this.b,
											ipaddress
										});
										this.multicastConnectedAdapterList.Add(a2.a);
										num = (short)1341063176;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 7:
										try
										{
											num = (short)1611857925;
											num2 = (int)((global::System.IntPtr)num);
											for (;;)
											{
												switch (num2)
												{
												case 0:
												{
													global::System.Net.NetworkInformation.IPAddressInformation ipaddressInformation;
													ipaddress = ipaddressInformation.Address;
													num = (short)2147221510;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												case 1:
												{
													global::System.Net.NetworkInformation.IPAddressInformation ipaddressInformation;
													if (ipaddressInformation.Address.AddressFamily == global::System.Net.Sockets.AddressFamily.InterNetwork)
													{
														num = (short)519700480;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													}
													break;
												}
												case 2:
												{
													if (!enumerator2.MoveNext())
													{
														num = (short)524353540;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													}
													global::System.Net.NetworkInformation.IPAddressInformation ipaddressInformation = enumerator2.Current;
													num = (short)1260584961;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												case 3:
													goto IL_49F;
												case 4:
													goto IL_486;
												case 5:
													switch (0)
													{
													case 0:
														goto IL_3DF;
													}
													continue;
												case 6:
													goto IL_486;
												}
												IL_448:
												num = (short)915734530;
												num2 = (int)((global::System.IntPtr)num);
												continue;
												IL_3DF:
												goto IL_448;
												IL_486:
												num = (short)767819779;
												num2 = (int)((global::System.IntPtr)num);
											}
											IL_49F:
											goto IL_250;
										}
										finally
										{
											num = (short)285933569;
											num2 = (int)((global::System.IntPtr)num);
											for (;;)
											{
												switch (num2)
												{
												case 0:
													goto IL_50E;
												case 1:
													switch (0)
													{
													case 0:
														goto IL_4D7;
													}
													continue;
												case 2:
													enumerator2.Dispose();
													num = (short)1230766080;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												IL_4D7:
												if (enumerator2 == null)
												{
													break;
												}
												num = (short)2069168130;
												num2 = (int)((global::System.IntPtr)num);
											}
											IL_50E:;
										}
										goto IL_511;
										IL_250:
										num = (short)1662779392;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 8:
										goto IL_552;
									}
									goto IL_21B;
									IL_511:
									num = (short)618528772;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_552:
									num = (short)1634336770;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_397:
								IL_56C:
								goto IL_944;
								IL_21B:
								ipaddress = null;
								enumerator2 = a2.a.GetIPProperties().UnicastAddresses.GetEnumerator();
								num = (short)1957888007;
								num2 = (int)((global::System.IntPtr)num);
								goto IL_1F0;
							}
							catch (global::System.Exception ex)
							{
								global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("၃⹅ⵇ橉ࡋ⭍♏㭑㝓㍕硗ਖ਼⹛ㅝݟၡգ୥էཀྵṫ乭ᵯ᭱፳ṵ౷婹ቻᅽꊁꢇﺏﶗﺙ벛쾟芡얣蚥쾩\ud8ab\ud9ad\udfaf삱\udfb3隵풹좻\udbbd늿꓁ꗃꗅ귇막髍룏믑ꟓ뗗동믛뛝铟싡藣胥軧迩迫髭탯英蛳駵鿷裹鷻鏽淿欁樃愅⠇砉洋樍礏紑朓㘕渗猙紛㸝真䬡ण急䄧Щఫ札嘯ሱ唳倵帷弹弻䨽┿♁桃晅㡇♉⥋⽍⍏㝑瑓㕕し㽙㽛㕝䁟ᙡౣͥ䡧ѩ५ᩭݯᵱٳᵵ塷᥹፻ၽ꺍ﲑ뚕ﾙ솟킡킣蚥\udca7슩즫躭ﾱ钳\uddb7첹햻\uddbdꖿ铃듅Ꟈ귉뻋꿍뷏뿑뇓ꓕ", a_) + ex.Message, global::System.Array.Empty<object>());
								goto IL_944;
							}
							goto IL_5A1;
						case 17:
							goto IL_AB;
						case 18:
						{
							bool flag = false;
							global::System.Net.NetworkInformation.NetworkInterface networkInterface = null;
							global::System.Collections.Generic.List<global::System.Net.NetworkInformation.NetworkInterface>.Enumerator enumerator = this.multicastConnectedAdapterList.GetEnumerator();
							num = (short)1311440903;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						goto IL_84;
						IL_AB:
						num = (short)137887755;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_5A1:
						num = (short)969211904;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_944:
						num3++;
						num = (short)1058734089;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_A2D:
						num = (short)1035599876;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_A45:
					break;
					IL_84:
					allNetworkInterfaces = global::System.Net.NetworkInformation.NetworkInterface.GetAllNetworkInterfaces();
					flag2 = false;
					array = allNetworkInterfaces;
					num3 = 0;
					num = (short)1259667473;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_31;
				}
				}
			}
			catch (global::System.Exception ex2)
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("Cࡅᭇ᥉ࡋ੍㕏♑ㅓ㕕ⱗ㕙⹛摝䁟", a_) + ex2.Message, global::System.Array.Empty<object>());
			}
			num = (short)344653824;
			short num5 = num;
			num = (short)853147649;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00008054 File Offset: 0x00006254
		private string c(string srvName)
		{
			int a_ = 17;
			short num = (short)1887174657;
			if (num != 0)
			{
			}
			switch (0)
			{
			case 0:
				goto IL_4C;
			}
			int num2;
			string[] array;
			string result;
			for (;;)
			{
				IL_3A:
				switch (num2)
				{
				case 0:
					if (array.Length == 3)
					{
						goto IL_7D;
					}
					goto IL_146;
				case 1:
				{
					num = (short)729395674;
					short num3 = num;
					num = (short)207991258;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_7D;
					default:
						num = (short)1793916928;
						if (num != 0)
						{
						}
						result = string.Concat(new string[]
						{
							array[2],
							global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("繏", a_),
							array[0],
							global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("繏", a_),
							array[1],
							global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("繏㹑㭓㕕㥗㙙", a_)
						});
						num = (short)753860610;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 2:
					goto IL_144;
				}
				goto IL_4C;
				IL_7D:
				num = (short)73793537;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_144:
			IL_146:
			num = (short)1422721024;
			short num4 = num;
			return result;
			IL_4C:
			result = srvName;
			array = srvName.Split(new char[]
			{
				'.'
			});
			num = (short)785973248;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_3A;
		}

		// Token: 0x0600006D RID: 109 RVA: 0x000081D4 File Offset: 0x000063D4
		internal static void b(string ip)
		{
			int a_ = 6;
			short num = (short)1173228983;
			short num2 = num;
			num = (short)412290487;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1411317760;
				short num3 = num;
				num = (short)1558970368;
				if (num != 0)
				{
				}
				num = (short)2016280577;
				if (num != 0)
				{
				}
				object obj = global::Motorola.Common.Communication.DeviceDiscovery.DNSSDDetector.d;
				bool flag = false;
				try
				{
					global::System.Threading.Monitor.Enter(obj, ref flag);
					try
					{
						global::Motorola.Common.Communication.DeviceDiscovery.DNSSDDetector.e.Send(global::Motorola.Common.Communication.DeviceDiscovery.DNSSDDetector.a, global::Motorola.Common.Communication.DeviceDiscovery.DNSSDDetector.a.Length, new global::System.Net.IPEndPoint(global::System.Net.IPAddress.Parse(ip), global::Motorola.Common.Communication.DeviceDiscovery.DNSSDDetector.c.Port));
						global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("ᙄ≆❈⽊浌୎ὐR硔іᵘ筚౜⩞Ѡᅢᱤ䝦㥨੪๬Ѯᑰݲ啴Ͷᙸ孺", a_) + ip, global::System.Array.Empty<object>());
					}
					catch (global::System.Exception ex)
					{
						global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("D㽆⩈⹊㵌㭎㡐㱒㭔睖⹘㍚㡜ㅞ䅠ၢd०൨ɪͬ࡮兰ɲtቶ୸ɺ嵼㭾쾀킂ꢄ풆춈ꮊﶌꎘ뮚", a_) + ex.Message, global::System.Array.Empty<object>());
					}
				}
				finally
				{
					num = (short)1126170624;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_167;
							}
							continue;
						case 1:
							global::System.Threading.Monitor.Exit(obj);
							num = (short)2073624578;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_19C;
						}
						IL_167:
						if (!flag)
						{
							break;
						}
						num = (short)209780737;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_19C:;
				}
				break;
			}
			}
		}

		// Token: 0x0600006E RID: 110 RVA: 0x0000839C File Offset: 0x0000659C
		private void c()
		{
			int a_ = 7;
			short num = (short)1793720321;
			if (num != 0)
			{
			}
			num = (short)437911552;
			switch (num)
			{
			default:
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("ͅ♇㹉⥋㱍㥏㱑㍓癕᱗ᑙཛ獝㍟♡䑣㍥Ⱨ㩩䱫൭ᱯ᭱ᅳᡵ౷婹ṻ᝽ꪉ낏ﮓ몙꾝\udd9f芡펣쾥\udca7슩貫\uddad쒯\uddb1쒳隵\udeb7횹\uddbb\ud9bd뇁ꇃ닅뻉ꏋꯏ꧓", a_), new object[]
				{
					this._isStopping,
					global::Motorola.Common.Communication.DeviceDiscovery.DNSSDDetector.c.Port
				});
				try
				{
					num = (short)1933246470;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							if (!string.IsNullOrEmpty(global::Motorola.Common.Communication.DeviceDiscovery.DNSSDDetector.c.OTAPTCP))
							{
								num = (short)593231886;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_11F;
						case 1:
							goto IL_8DF;
						case 2:
							if (!string.IsNullOrEmpty(global::Motorola.Common.Communication.DeviceDiscovery.DNSSDDetector.c.PasswordIndex))
							{
								num = (short)960233485;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_11F;
						case 3:
							if (this._isStopping)
							{
								num = (short)2092892161;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1993408522;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							goto IL_61C;
						case 5:
							goto IL_818;
						case 6:
							switch (0)
							{
							case 0:
								goto IL_F4;
							}
							continue;
						case 7:
						{
							if (global::Motorola.Common.Communication.DeviceDiscovery.DNSSDDetector.c.Port == 0)
							{
								num = (short)2078146571;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Net.NetworkInformation.NetworkChange.NetworkAddressChanged += this.ResolveNetworkAddressChangedCallback;
							global::Motorola.Common.Communication.DeviceDiscovery.DNSSDDetector.e = new global::System.Net.Sockets.UdpClient();
							global::System.Net.IPEndPoint localEP = new global::System.Net.IPEndPoint(global::System.Net.IPAddress.Any, global::Motorola.Common.Communication.DeviceDiscovery.DNSSDDetector.c.Port);
							global::Motorola.Common.Communication.DeviceDiscovery.DNSSDDetector.e.Client.SetSocketOption(global::System.Net.Sockets.SocketOptionLevel.Socket, global::System.Net.Sockets.SocketOptionName.ReuseAddress, true);
							num = (short)100335621;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 8:
							goto IL_789;
						case 9:
							goto IL_914;
						case 10:
							try
							{
								switch (0)
								{
								case 0:
									goto IL_190;
								}
								for (;;)
								{
									IL_13D:
									byte[] array;
									switch (num2)
									{
									case 0:
										if (array != null)
										{
											num = (short)260309001;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_310;
									case 1:
										if (this._isStopping)
										{
											num = (short)168296464;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)333578240;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										goto IL_310;
									case 3:
										goto IL_1DB;
									case 4:
										goto IL_4A4;
									case 5:
										if (array.Length != 0)
										{
											num = (short)1568210954;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_310;
									case 6:
										if (global::Motorola.Common.Communication.DeviceDiscovery.DNSSDDetector.e.Client.Available == 0)
										{
											num = (short)999292939;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_1DB;
									case 7:
										goto IL_346;
									case 8:
										global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("ቅ⁇㡉⥋⽍㑏牑⁓㍕⩗㝙㕛そşᙡൣ॥٧䩩Ὣݭᝯᱱᕳ᩵塷ࡹ᥻ᵽꒉ겋삍ﾏ늑歹ﾙ펟芡얣킥즧쎩삫쾭튯\udeb1톳", a_), global::System.Array.Empty<object>());
										num = (short)480641037;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 9:
										num = (short)718929925;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 10:
										num = (short)1275396110;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 11:
										num = (short)363134993;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 12:
										goto IL_261;
									case 13:
										goto IL_30B;
									case 14:
										if (this.f != null)
										{
											num = (short)1765408783;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_310;
									case 15:
										num = (short)1795489810;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 16:
										num = (short)1962213388;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 17:
										if (this.j.WaitOne(20000))
										{
											num = (short)1634205704;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::Motorola.Common.Communication.DeviceDiscovery.DNSSDDetector.b(this.b.ToString());
										num = (short)1792802819;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 18:
									{
										if (this.f.Port != global::Motorola.Common.Communication.DeviceDiscovery.DNSSDDetector.c.Port)
										{
											num = (short)1232404482;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::Motorola.Common.Communication.DeviceDiscovery.RawMDNSMessage item = new global::Motorola.Common.Communication.DeviceDiscovery.RawMDNSMessage
										{
											Message = array,
											RemotePoint = this.f
										};
										this.l.Enqueue(item);
										this.k.Set();
										num = (short)235470852;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									}
									goto IL_190;
									IL_1DB:
									array = global::Motorola.Common.Communication.DeviceDiscovery.DNSSDDetector.e.Receive(ref this.f);
									global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVoid(global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("Ʌه᥉態ᵍᑏ牑♓㝕⽗穙ज़ᩝた䉡ᙣͥ୧ཀྵիᡭᕯᙱ", a_), global::System.Array.Empty<object>());
									num = (short)802947073;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_310:
									global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVoid(global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("Ʌه᥉態ᵍᑏ牑♓㝕⽗穙ज़ᩝた䉡cཥ᭧३൫ᱭᑯ᝱ၳ", a_), global::System.Array.Empty<object>());
									num = (short)291241991;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_261:
								IL_30B:
								goto IL_8DF;
								IL_346:
								IL_4A4:
								goto IL_61C;
								IL_190:
								this.f = null;
								num = (short)1141243910;
								num2 = (int)((global::System.IntPtr)num);
								goto IL_13D;
							}
							catch (global::System.Net.Sockets.SocketException ex)
							{
								if (ex.SocketErrorCode != global::System.Net.Sockets.SocketError.TimedOut)
								{
									global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("Ʌه᥉態ᵍᑏ牑œቕࡗ穙⽛ㅝ͟ॡţብ䡧ཀྵᑫ൭ᕯɱsή᝷ᑹ䙻幽", a_) + ex.Message, global::System.Array.Empty<object>());
									global::System.Threading.Thread.Sleep(1000);
								}
								global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVoid(global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("Ʌه᥉態ᵍᑏ牑œቕࡗ穙⹛㭝͟ݡൣၥ൧䩩ᡫݭᵯ᝱᭳͵౷婹养幽ꒃ늑ﾕ肟\ud9a1钣\udba5\udba7", a_), new object[]
								{
									global::Motorola.Common.Communication.DeviceDiscovery.DNSSDDetector.e.Client.ReceiveTimeout / 1000
								});
								goto IL_61C;
							}
							goto IL_530;
						case 11:
							goto IL_813;
						case 12:
							try
							{
								this.JoinMulticastGroupAndRequestServiceRecord(this.networkAdapterArray, false);
								goto IL_837;
							}
							catch (global::System.Exception ex2)
							{
								global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("౅❇⍉≋͍╏㹑⁓㽕㭗㭙⽛⩝❟ၡୣ፥ᡧ⭩ɫ੭≯᝱ճ͵ᵷॹࡻ⵽\ude8b﶑뢗ﲙﶛ첟잡삣鲥袧", a_) + ex2.Message, global::System.Array.Empty<object>());
								goto IL_837;
							}
							goto IL_8DF;
							IL_837:
							this.ab.Elapsed += this.a;
							this.ab.Start();
							global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("ᕅ㱇⭉㹋㩍㥏㱑㍓癕ᕗṙቛ൝䁟ቡգեͧཀྵᡫ乭ᱯ᭱ݳɵᵷᑹᕻၽꊁ憎겋轢憐ﲓ뚕肟쒡좣장쾧誩\udfab쮭쒯銱삳\ud9b5颷솹費쎽", a_), new object[]
							{
								this._isStopping
							});
							num = (short)1329790980;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 13:
							num = (short)165871623;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 14:
							goto IL_530;
						case 15:
							try
							{
								num = (short)909180929;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										num = (short)2078343170;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_693;
										}
										continue;
									case 2:
										goto IL_6C8;
									case 3:
										goto IL_739;
									}
									IL_693:
									if (this._isStopping)
									{
										num = (short)1954807808;
										num2 = (int)((global::System.IntPtr)num);
									}
									else
									{
										global::System.Net.IPEndPoint localEP;
										global::Motorola.Common.Communication.DeviceDiscovery.DNSSDDetector.e.Client.Bind(localEP);
										global::Motorola.Common.Communication.DeviceDiscovery.DNSSDDetector.e.Client.ReceiveTimeout = 5000;
										global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("Ʌه᥉態ᵍᑏ牑œቕࡗ穙㽛㉝य़ݡ੣ብ䡧թɫ乭oᵱٳɵ塷Ź䱻ͽꁿﾋﶍ歹몙ﾛ얟쎡킣쎥첧蒩", a_), new object[]
										{
											global::Motorola.Common.Communication.DeviceDiscovery.DNSSDDetector.c.Port
										});
										num = (short)597819395;
										num2 = (int)((global::System.IntPtr)num);
									}
								}
								IL_6C8:
								goto IL_A32;
								IL_739:
								goto IL_57A;
							}
							catch (global::System.Exception ex3)
							{
								global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("Ʌه᥉Ὃ੍ᑏ㝑⁓㍕㭗⹙㍛ⱝ䁟ݡᙣᑥݧᡩ䁫乭㑯㱱❳孵⭷㹹屻⭽쑿튁ꒃ늑ﶗﮙ쾟첡蒣즥욧誩\udcab솭슯욱钳춵袷잹鲻\ud8bdꆿꯁꣃꏅ곇믋ꟍ꓏뫑돕ꃗ맙맛껝铟诡诣裥틧쫩", a_) + ex3.Message, new object[]
								{
									global::Motorola.Common.Communication.DeviceDiscovery.DNSSDDetector.c.Port
								});
								global::System.Threading.Thread.Sleep(2000);
								goto IL_818;
							}
							goto IL_789;
							IL_57A:
							num = (short)1519321100;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_F4:
						if (!string.IsNullOrEmpty(global::Motorola.Common.Communication.DeviceDiscovery.DNSSDDetector.c.GroupIP))
						{
							num = (short)707002376;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
						IL_530:
						num = (short)1133576194;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_61C:
						num = (short)1511915523;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_789:
						num = (short)2014707712;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_818:
						num = (short)1392574479;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_8DF:
						global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("ͅぇ⍉㡋㩍㥏㱑㍓癕᱗ᑙཛ獝㍟♡䑣੥ŧᥩᡫ୭ṯ᭱ᩳᅵ塷ᙹ፻ᅽ", a_), global::System.Array.Empty<object>());
						num = (short)1258815497;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_11F:
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("Ʌه᥉汋്㽏㱑㉓㽕㽗穙㕛そᙟ͡ࡣཥ౧", a_));
					IL_813:
					goto IL_11F;
					IL_914:;
				}
				catch (global::System.Exception ex4)
				{
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("Ʌه᥉態ᵍᑏ牑ၓ㍕ⱗ㽙㽛⩝ཟၡ䑣ብgᡩ५཭ᑯ᭱ᩳᅵ塷όѻ᝽ꒃﺉ꺍캟颡蒣", a_) + ex4.Message, global::System.Array.Empty<object>());
				}
				finally
				{
					try
					{
						num = (short)1566244865;
						int num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
							{
								num = (short)747173695;
								short num3 = num;
								num = (short)84539199;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									num = (short)267714560;
									if (num != 0)
									{
									}
									global::Motorola.Common.Communication.DeviceDiscovery.DNSSDDetector.e.Close();
									num = (short)293404674;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 1:
								switch (0)
								{
								case 0:
									goto IL_984;
								}
								continue;
							case 2:
								goto IL_A14;
							case 3:
								goto IL_A2C;
							}
							IL_984:
							if (global::Motorola.Common.Communication.DeviceDiscovery.DNSSDDetector.e != null)
							{
								num = (short)637206528;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_A14:
							num = (short)171900931;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_A2C:;
					}
					catch
					{
					}
				}
				IL_A32:
				num = (short)1726021632;
				short num4 = num;
				return;
			}
			}
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00008E98 File Offset: 0x00007098
		public global::Motorola.Common.Communication.DeviceDiscovery.OriginalPnPMsg DecodeMDNSMessage(global::Motorola.Common.Communication.DeviceDiscovery.RawMDNSMessage rawMsg)
		{
			global::Motorola.Common.Communication.DnsResponseMessage dnsResponseMessage;
			global::Motorola.Common.Communication.DeviceDiscovery.OriginalPnPMsg result;
			short num;
			for (;;)
			{
				dnsResponseMessage = new global::Motorola.Common.Communication.DnsResponseMessage();
				try
				{
					dnsResponseMessage.DecodeReplyMessage(rawMsg.Message, 0, rawMsg.Message.Length);
					goto IL_08;
				}
				catch
				{
					result = null;
				}
				goto IL_7F;
				IL_08:
				num = (short)1381340264;
				short num2 = num;
				num = (short)1823249512;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_40;
				}
			}
			IL_40:
			num = (short)643629056;
			if (num != 0)
			{
			}
			return this.ProcessMDNSMessage(dnsResponseMessage, rawMsg.RemotePoint);
			IL_7F:
			num = (short)402849793;
			if (num != 0)
			{
			}
			num = (short)1099169792;
			short num3 = num;
			return result;
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00008F88 File Offset: 0x00007188
		public global::Motorola.Common.Communication.DeviceDiscovery.OriginalPnPMsg ProcessMDNSMessage(global::Motorola.Common.Communication.DnsResponseMessage response, global::System.Net.IPEndPoint remotePoint)
		{
			int a_ = 12;
			short num = (short)1014497280;
			short num2 = num;
			num = (short)651296768;
			switch (num)
			{
			default:
			{
				global::System.Collections.Generic.IEnumerable<global::Motorola.Common.Communication.RecordPTR> ptrs = response.PTRS;
				global::System.Func<global::Motorola.Common.Communication.RecordPTR, bool> predicate;
				if ((predicate = global::Motorola.Common.Communication.DeviceDiscovery.DNSSDDetector.<>c.<>9__48_0) != null)
				{
					goto IL_210B;
				}
				IL_20F0:
				predicate = (global::Motorola.Common.Communication.DeviceDiscovery.DNSSDDetector.<>c.<>9__48_0 = new global::System.Func<global::Motorola.Common.Communication.RecordPTR, bool>(global::Motorola.Common.Communication.DeviceDiscovery.DNSSDDetector.<>c.<>9.a));
				IL_210B:
				global::System.Collections.Generic.IEnumerator<global::Motorola.Common.Communication.RecordPTR> enumerator = ptrs.Where(predicate).GetEnumerator();
				global::Motorola.Common.Communication.DeviceDiscovery.OriginalPnPMsg result;
				try
				{
					num = (short)409993254;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						string value;
						long num4;
						string text;
						global::Motorola.Common.Communication.RecordTXT recordTXT3;
						global::System.Collections.Generic.Dictionary<global::System.Collections.Generic.KeyValuePair<string, string>, bool> obj;
						bool flag;
						switch (num3)
						{
						case 0:
							goto IL_41A;
						case 1:
							if (e.a.DeviceName.StartsWith(global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("੊ᵌᝎὐᙒൔ͖", a_)))
							{
								num = (short)286457919;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1BF9;
						case 2:
							if (!string.IsNullOrEmpty(value))
							{
								num = (short)1059454981;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)146997315;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							if (this.ad.ContainsKey(d.b.a.Address.ToString()))
							{
								num = (short)896794664;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							this.ad.Add(d.b.a.Address.ToString(), num4);
							num = (short)1713963034;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							goto IL_1BF9;
						case 5:
							e.a.IPAddress = value;
							num = (short)946733146;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							goto IL_1D2C;
						case 7:
							if (response.TXTS.Count(new global::System.Func<global::Motorola.Common.Communication.RecordTXT, bool>(d.c)) > 0)
							{
								num = (short)1472266345;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 8:
							if (global::Motorola.Common.Communication.DeviceDiscovery.LDTDetectorBase._passwords.Count(new global::System.Func<global::Motorola.Common.Communication.CommonUtil.AuthenticationInfo, bool>(e.b)) > 0)
							{
								num = (short)1931935829;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(string.Format(global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("ᭊⱌ㱎≐⑒㩔╖㵘筚㑜㭞Ѡൢᅤ๦ཨɪ࡬ᵮ兰佲๴䝶Ѹ䕺嵼ᙾꎂ랖ﺚ욠욢薤솦\udba8쒪사辮辴鞶薸삺貼슾￀계꧆뿈꫊ꇌꛎ뗐", a_), e.a.PasswordId, e.a.IPAddress), global::System.Array.Empty<object>());
							num = (short)303628307;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 9:
						{
							global::Motorola.Common.Communication.RecordTXT recordTXT;
							if (recordTXT.Txts.ContainsKey(global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("⩊⹌ⱎ═⩒╔㉖", a_)))
							{
								num = (short)213844042;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 10:
							goto IL_191F;
						case 11:
						{
							global::Motorola.Common.Communication.RecordA recordA = response.AS.FirstOrDefault(new global::System.Func<global::Motorola.Common.Communication.RecordA, bool>(f.b));
							if (recordA == null)
							{
								num = (short)1978662925;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							text = recordA.IP;
							goto IL_981;
						}
						case 12:
							goto IL_B79;
						case 13:
							text = null;
							goto IL_981;
						case 14:
							goto IL_1B70;
						case 15:
							num = (short)1629487158;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 16:
						{
							global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile a = new global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile();
							a.DomainName = (a.DeviceName = d.a.DomainName);
							a.ConnectMode = global::Motorola.Common.Communication.DeviceDiscovery.LDTConnectMode.WIFI;
							a.TTL = d.a.TTL;
							num = (short)901054498;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 17:
							num = (short)1823997996;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 18:
							e.a.DeviceName = e.a.DeviceName.Remove(e.a.DeviceName.IndexOf(' '), 1);
							num = (short)1254227978;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 20:
							if (response.SRVS.Count(new global::System.Func<global::Motorola.Common.Communication.RecordSRV, bool>(d.c)) > 0)
							{
								num = (short)743899179;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)915210286;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 21:
							if (d.a.DomainName.Contains(global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("ൊ㡌㭎㹐㵒", a_)))
							{
								num = (short)1212547158;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							result = new global::Motorola.Common.Communication.DeviceDiscovery.OriginalPnPMsg
							{
								m_DeviceAction = global::Motorola.Common.Communication.DeviceDiscovery.DevPnPAction.DeviceDetached,
								sDeviceName = d.a.DomainName
							};
							num = (short)1402404915;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 22:
							this.ad[d.b.a.Address.ToString()] = num4;
							num = (short)203161666;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 23:
						{
							global::System.Collections.Generic.List<global::Motorola.Common.Communication.RecordSRV>.Enumerator enumerator2 = response.SRVS.GetEnumerator();
							num = (short)568328274;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 24:
						{
							global::System.Collections.Generic.List<global::Motorola.Common.Communication.RecordSRV>.Enumerator enumerator2 = response.SRVS.GetEnumerator();
							num = (short)522649701;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 25:
							goto IL_FB4;
						case 26:
							goto IL_1D2C;
						case 27:
							goto IL_B01;
						case 28:
							if (d.a.DomainName.Contains(global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("੊ᵌᝎ煐ᵒ扔杖", a_)))
							{
								num = (short)718077977;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 29:
							goto IL_4ED;
						case 30:
							goto IL_1D2C;
						case 31:
							num = (short)832438283;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 32:
							goto IL_723;
						case 33:
						{
							global::Motorola.Common.Communication.RecordTXT recordTXT;
							if (recordTXT.Txts.ContainsKey(global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("㡊⍌", a_)))
							{
								num = (short)2119368813;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 34:
							if (!d.a.DomainName.Contains(global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("ൊ㡌㭎㹐㵒", a_)))
							{
								num = (short)1292042255;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_C8D;
						case 35:
						{
							global::Motorola.Common.Communication.RecordTXT recordTXT;
							if (recordTXT.Txts[global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("⩊⹌ⱎ═⩒╔㉖", a_)] == global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("ॊŌᩎᑐݒᩔᡖ൘ፚ", a_))
							{
								num = (short)1770455100;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 36:
							e.a.DeviceName = d.a.DomainName;
							e.a.DeviceDescription = d.a.DomainName;
							e.a.UniqueLocation = "";
							e.a.RadioType = global::Motorola.Common.Communication.RadioType.PCR;
							e.a.InstanceId = 0U;
							num = (short)1688600653;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 37:
						{
							global::Motorola.Common.Communication.RecordTXT recordTXT = response.TXTS.First(new global::System.Func<global::Motorola.Common.Communication.RecordTXT, bool>(d.h));
							num = (short)1417216033;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 38:
							switch (0)
							{
							case 0:
								goto IL_262;
							}
							continue;
						case 39:
							if (response.SRVS.Count > 0)
							{
								num = (short)1617035287;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1D2C;
						case 40:
							num = (short)1204158543;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 41:
							if (response.SRVS.Count > 0)
							{
								num = (short)1376256024;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1D2C;
						case 42:
							if (response.TXTS.Count(new global::System.Func<global::Motorola.Common.Communication.RecordTXT, bool>(d.e)) > 0)
							{
								num = (short)828637255;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 43:
						{
							string a = response.SRVS.First(new global::System.Func<global::Motorola.Common.Communication.RecordSRV, bool>(d.d)).Target;
							num = (short)1850736742;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 44:
							if (!d.a.DomainName.Contains(global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("ൊ㡌㭎㹐㵒", a_)))
							{
								num = (short)1677525088;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_723;
						case 45:
						{
							global::Motorola.Common.Communication.RecordTXT recordTXT2;
							if (recordTXT2.Txts.ContainsKey(global::Motorola.Common.Communication.DeviceDiscovery.DNSSDDetector.c.PasswordIndex))
							{
								num = (short)1223491641;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 46:
							if (!d.a.DomainName.Contains(global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("੊ᵌᝎ煐ᵒၔབ൘", a_)))
							{
								num = (short)378929249;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1222;
						case 47:
							e.a.NetCfgInstanceId = global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("᱊⑌ॎ㡐౒", a_) + e.a.DeviceName;
							e.a.PID = global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("᱊⑌ॎ㡐౒ᡔ㡖ⵘ㑚ड़ⵞ͠ౢ", a_);
							num = (short)1409810538;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 49:
							if (!string.IsNullOrEmpty(f.a))
							{
								num = (short)1939537951;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1669529680;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 50:
							e.a.PortName = response.SRVS.First(new global::System.Func<global::Motorola.Common.Communication.RecordSRV, bool>(d.e)).Port.ToString();
							num = (short)194314240;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 51:
							goto IL_15BE;
						case 52:
							if (d.a.DomainName.Contains(global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("੊ᵌᝎ煐ᵒ扔杖", a_)))
							{
								num = (short)1988886612;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 53:
							if (!d.a.DomainName.Contains(global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("ൊ㡌㱎㡐㱒㭔", a_)))
							{
								num = (short)1224343647;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_651;
						case 54:
							if (d.a.DomainName.Contains(global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("ൊ㡌㱎㡐㱒㭔", a_)))
							{
								num = (short)1630928988;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1572733019;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 55:
							goto IL_4ED;
						case 56:
							goto IL_B01;
						case 57:
						{
							global::Motorola.Common.Communication.RecordTXT recordTXT2;
							e.a.PasswordId = recordTXT2.Txts[global::Motorola.Common.Communication.DeviceDiscovery.DNSSDDetector.c.PasswordIndex];
							num = (short)723058696;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 58:
							num = (short)1144979484;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 59:
							if (d.a.DomainName.Contains(global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("يɌ᭎Ṑݒݔᕖᙘњ", a_)))
							{
								num = (short)1153826852;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("Ṋ⍌⑎㽐㱒≔㥖祘ᙚᥜᅞ㉠䍢㕤٦੨j࡬᭮彰卲", a_) + d.a.DomainName, global::System.Array.Empty<object>());
							num = (short)16711686;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 60:
							e.a.NetCfgInstanceId = global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("ॊ᥌၎", a_) + e.a.DeviceName;
							e.a.PID = global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("ॊ᥌၎᱐㱒⅔㡖൘⥚㽜ぞ", a_);
							num = (short)1381630050;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 61:
							goto IL_F18;
						case 62:
							if (d.a.DomainName.Contains(global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("ᵊᕌ", a_)))
							{
								num = (short)93061134;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1407189051;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 63:
							e.a.DeviceName = global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("੊ᵌᝎὐᙒൔ͖", a_);
							num = (short)689569796;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 64:
							goto IL_B01;
						case 65:
						{
							string value2;
							bool tlsPsk;
							if (bool.TryParse(value2, out tlsPsk))
							{
								num = (short)473301096;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_141B;
						}
						case 66:
							if (global::Motorola.Common.Communication.DeviceDiscovery.LDTDetectorBase._arrivedDevices.Count(new global::System.Func<global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile, bool>(d.c)) > 0)
							{
								num = (short)208928857;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1D2C;
						case 67:
							if (d.a.DomainName.Contains(global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("يɌ᭎Ṑݒݔᕖᙘњ", a_)))
							{
								num = (short)266993739;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1887240275;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 68:
							if (recordTXT3.Txts.ContainsKey(global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("㡊⍌", a_)))
							{
								num = (short)1924792381;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							e.a.RadioSerialNumber = d.a.DomainName.Substring(d.a.DomainName.IndexOf('_') + 1, d.a.DomainName.IndexOf('.') - (d.a.DomainName.IndexOf('_') + 1));
							num = (short)769982519;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 69:
						{
							global::Motorola.Common.Communication.RecordTXT recordTXT;
							if (recordTXT.Txts[global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("⩊⹌ⱎ═⩒╔㉖", a_)] == global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("᱊ьॎᡐ", a_))
							{
								num = (short)403308591;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)540934179;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 70:
							num = (short)685572158;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 71:
							recordTXT3 = response.TXTS.First(new global::System.Func<global::Motorola.Common.Communication.RecordTXT, bool>(d.f));
							num = (short)1603665988;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 72:
							if (d.a.DomainName.Contains(global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("੊ᵌᝎ煐", a_)))
							{
								num = (short)1220345874;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_191F;
						case 73:
							num = (short)1933639791;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 74:
							num = (short)1157169221;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 75:
							e.a.IPAddress = response.AS[0].IP;
							num = (short)349110366;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 76:
							try
							{
								switch (0)
								{
								case 0:
									goto IL_D59;
								}
								for (;;)
								{
									IL_D42:
									switch (num3)
									{
									case 0:
										goto IL_E56;
									case 1:
										if (this.ac.ContainsKey(new global::System.Collections.Generic.KeyValuePair<string, string>(d.b.a.Address.ToString(), d.a.DomainName)))
										{
											num = (short)1065156611;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										this.ac.Add(new global::System.Collections.Generic.KeyValuePair<string, string>(d.b.a.Address.ToString(), d.a.DomainName), true);
										num = (short)1796800514;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										goto IL_EA4;
									case 3:
									{
										num = (short)910257489;
										short num5 = num;
										num = (short)1339518289;
										switch ((num5 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											break;
										default:
											num = (short)997064704;
											if (num != 0)
											{
											}
											this.ac[new global::System.Collections.Generic.KeyValuePair<string, string>(d.b.a.Address.ToString(), d.a.DomainName)] = true;
											num = (short)1042874368;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									}
									goto IL_D59;
								}
								IL_E56:
								IL_EA4:
								break;
								IL_D59:
								global::System.Threading.Monitor.Enter(obj, ref flag);
								num = (short)1920139265;
								num3 = (int)((global::System.IntPtr)num);
								goto IL_D42;
							}
							finally
							{
								num = (short)1474101249;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num3)
									{
									case 0:
										goto IL_F15;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_EDC;
										}
										continue;
									case 2:
										global::System.Threading.Monitor.Exit(obj);
										num = (short)305004544;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_EDC:
									if (!flag)
									{
										break;
									}
									num = (short)1698496514;
									num3 = (int)((global::System.IntPtr)num);
								}
								IL_F15:;
							}
							goto IL_F18;
						case 77:
							if (response.TXTS.Count(new global::System.Func<global::Motorola.Common.Communication.RecordTXT, bool>(d.g)) > 0)
							{
								num = (short)299892773;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 78:
							if (d.a.DomainName.Contains(global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("੊ᵌᝎ煐ᵒ扔杖", a_)))
							{
								num = (short)1643380768;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 79:
							if (num4 - this.ad[d.b.a.Address.ToString()] < 30L)
							{
								num = (short)1270153238;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_13DA;
						case 80:
							if (!d.a.DomainName.Contains(global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("੊ᵌᝎ煐ᵒၔབ൘", a_)))
							{
								num = (short)414187578;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_FB4;
						case 81:
							goto IL_141B;
						case 82:
							try
							{
								num = (short)490471426;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num3)
									{
									case 0:
										num = (short)526254081;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										goto IL_407;
									case 2:
										switch (0)
										{
										case 0:
											goto IL_380;
										}
										continue;
									case 4:
									{
										global::System.Collections.Generic.List<global::Motorola.Common.Communication.RecordSRV>.Enumerator enumerator2;
										if (!enumerator2.MoveNext())
										{
											num = (short)1912406016;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::Motorola.Common.Communication.RecordSRV recordSRV = enumerator2.Current;
										recordSRV.NAME = this.c(recordSRV.NAME);
										num = (short)1205272579;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									}
									IL_3B6:
									num = (short)1364393988;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_380:
									goto IL_3B6;
								}
								IL_407:
								goto IL_1D2C;
							}
							finally
							{
								global::System.Collections.Generic.List<global::Motorola.Common.Communication.RecordSRV>.Enumerator enumerator2;
								((global::System.IDisposable)enumerator2).Dispose();
							}
							goto IL_41A;
						case 83:
							if (!d.a.DomainName.Contains(global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("ൊ㡌㱎㡐㱒㭔", a_)))
							{
								num = (short)2076639249;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_723;
						case 84:
							goto IL_1222;
						case 85:
							e.a.Password = global::Motorola.Common.Communication.DeviceDiscovery.LDTDetectorBase._passwords.First(new global::System.Func<global::Motorola.Common.Communication.CommonUtil.AuthenticationInfo, bool>(e.c)).PreSharedKey_Material;
							num = (short)105382001;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 86:
							goto IL_651;
						case 87:
							goto IL_41A;
						case 88:
							if (!d.a.DomainName.Contains(global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("੊ᵌᝎ煐ᵒၔབ൘", a_)))
							{
								num = (short)1400111212;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_723;
						case 89:
							num = (short)1044447280;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 90:
							goto IL_B01;
						case 91:
							if (!d.a.DomainName.Contains(global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("੊ᵌᝎ煐", a_)))
							{
								num = (short)1724317799;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1B70;
						case 92:
							goto IL_C8D;
						case 93:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1163067465;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.Common.Communication.RecordPTR a = enumerator.Current;
							global::DeviceDiscovery.DNSSDDecoder.c.a(a.DomainName);
							num = (short)36503662;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 94:
							goto IL_B01;
						case 95:
							num = (short)1177157653;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 96:
							num = (short)1928790104;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 97:
							num = (short)1489633332;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 98:
							goto IL_1F8D;
						case 99:
						{
							string value2;
							if (recordTXT3.Txts.TryGetValue(global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("㽊⅌㱎Ő⁒㹔", a_), out value2))
							{
								num = (short)2111570032;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_141B;
						}
						case 100:
							try
							{
								switch (0)
								{
								case 0:
									goto IL_129A;
								}
								for (;;)
								{
									IL_1283:
									switch (num3)
									{
									case 0:
										goto IL_134E;
									case 1:
										if (this.ac.ContainsKey(new global::System.Collections.Generic.KeyValuePair<string, string>(d.b.a.Address.ToString(), d.a.DomainName)))
										{
											num = (short)1724252163;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_134E;
									case 2:
										goto IL_1367;
									case 3:
										this.ac.Remove(new global::System.Collections.Generic.KeyValuePair<string, string>(d.b.a.Address.ToString(), d.a.DomainName));
										num = (short)369229824;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_129A;
									IL_134E:
									num = (short)499646466;
									num3 = (int)((global::System.IntPtr)num);
								}
								IL_1367:
								goto IL_267;
								IL_129A:
								global::System.Threading.Monitor.Enter(obj, ref flag);
								num = (short)1091502081;
								num3 = (int)((global::System.IntPtr)num);
								goto IL_1283;
							}
							finally
							{
								num = (short)1064828929;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num3)
									{
									case 0:
										goto IL_13D7;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_139F;
										}
										continue;
									case 2:
										global::System.Threading.Monitor.Exit(obj);
										num = (short)840695808;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_139F:
									if (!flag)
									{
										break;
									}
									num = (short)310640642;
									num3 = (int)((global::System.IntPtr)num);
								}
								IL_13D7:;
							}
							goto IL_13DA;
							IL_267:
							num4 = (long)new global::System.TimeSpan(global::System.DateTime.Now.Ticks).TotalSeconds;
							num = (short)1387069443;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 101:
							try
							{
								num = (short)49872898;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num3)
									{
									case 1:
										goto IL_96E;
									case 2:
										switch (0)
										{
										case 0:
											goto IL_8E5;
										}
										continue;
									case 3:
									{
										global::System.Collections.Generic.List<global::Motorola.Common.Communication.RecordSRV>.Enumerator enumerator2;
										if (!enumerator2.MoveNext())
										{
											num = (short)661585924;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::Motorola.Common.Communication.RecordSRV recordSRV2 = enumerator2.Current;
										recordSRV2.NAME = this.c(recordSRV2.NAME);
										num = (short)2106392576;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 4:
										num = (short)704905217;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_8E7:
									num = (short)607256579;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_8E5:
									goto IL_8E7;
								}
								IL_96E:
								goto IL_1D2C;
							}
							finally
							{
								global::System.Collections.Generic.List<global::Motorola.Common.Communication.RecordSRV>.Enumerator enumerator2;
								((global::System.IDisposable)enumerator2).Dispose();
							}
							goto IL_981;
						case 102:
							if (e.a.RadioType != global::Motorola.Common.Communication.RadioType.PCR)
							{
								num = (short)924778546;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							e.a.PortName = global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("獊経罎捐", a_);
							num = (short)1961885783;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 103:
							num = (short)1052704875;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 104:
						{
							bool tlsPsk;
							e.a.TlsPsk = tlsPsk;
							num = (short)1338179665;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 105:
						{
							global::Motorola.Common.Communication.RecordTXT recordTXT2 = response.TXTS.First(new global::System.Func<global::Motorola.Common.Communication.RecordTXT, bool>(d.d));
							num = (short)714932269;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 106:
							goto IL_1F8D;
						case 107:
							if (!d.a.DomainName.Contains(global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("ᵊ⡌㵎═㙒ⵔ", a_)))
							{
								num = (short)1528430662;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1B70;
						case 108:
							num = (short)719454286;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 109:
						{
							global::Motorola.Common.Communication.RecordTXT recordTXT;
							e.a.RadioSerialNumber = recordTXT.Txts[global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("㡊⍌", a_)];
							num = (short)1841365001;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 110:
							if (d.a.TTL > 0U)
							{
								num = (short)33554448;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1423573045;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 111:
							goto IL_2080;
						case 112:
							num = (short)2129526849;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 113:
							obj = this.ac;
							flag = false;
							num = (short)658833508;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_262;
						IL_41A:
						num = (short)198049841;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_4ED:
						num = (short)1832452195;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_651:
						obj = this.ac;
						flag = false;
						num = (short)1820852300;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_6E2:
						num = (short)2045182045;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_262:
						goto IL_6E2;
						IL_723:
						e.a.IPAddress = d.b.a.Address.ToString();
						num = (short)1844576312;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_981:
						value = text;
						num = (short)1460731906;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_B01:
						global::Motorola.Common.Communication.DeviceDiscovery.OriginalPnPMsg originalPnPMsg = new global::Motorola.Common.Communication.DeviceDiscovery.OriginalPnPMsg();
						originalPnPMsg.m_DeviceAction = global::Motorola.Common.Communication.DeviceDiscovery.DevPnPAction.DeviceAttached;
						originalPnPMsg.sDeviceName = d.a.DomainName;
						originalPnPMsg.radioProfile = e.a;
						global::System.Diagnostics.Trace.TraceInformation(string.Format(global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("၊ᩌ♎ᝐ㩒ࡔౖ≘歚⁜ɞ㩠ᡢ呤ᩦ㑨䭪⁬㱮㕰㵲啴᩶ᱸࡺ๼Ṿꖄ", a_), e.a.ProductFamily, e.a.RadioSerialNumber));
						result = originalPnPMsg;
						num = (short)1030684684;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_C8D:
						e.a.PID = global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("᱊⑌ॎ㡐౒Քᕖ᭘", a_);
						e.a.IMEI = e.a.PID + global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("ᑊ", a_) + d.b.a.Address.ToString();
						num = (short)814415879;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_F18:
						e.a.RadioSerialNumber = recordTXT3.Txts[global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("㡊⍌", a_)];
						num = (short)355336221;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_FB4:
						e.a.IPAddress = d.b.a.Address.ToString();
						num = (short)1443692608;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_1222:
						e.a.IPAddress = d.b.a.Address.ToString();
						e.a.PortName = global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("繊罌罎恐捒", a_);
						num = (short)1014759451;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_13DA:
						this.ad[d.b.a.Address.ToString()] = num4;
						num = (short)919207966;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_141B:
						e.a.UniqueLocation = e.a.RadioSerialNumber;
						e.a.IMEI = e.a.PID + global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("ᑊ", a_) + e.a.RadioSerialNumber;
						e.a.DeviceInstanceID = e.a.PID + global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("ᑊ", a_) + e.a.RadioSerialNumber;
						e.a.PhysicalLocation = e.a.RadioSerialNumber;
						num = (short)399245351;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_191F:
						num = (short)248119297;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_1B70:
						e.a.DeviceName = d.a.DomainName.Substring(0, d.a.DomainName.IndexOf('_'));
						num = (short)738787400;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_1BF9:
						e.a.DeviceDescription = d.a.DomainName;
						e.a.PID = this.a(e.a.DeviceName);
						e.a.UniqueLocation = "";
						e.a.RadioType = global::Motorola.Common.Communication.RadioType.ASTRO;
						e.a.InstanceId = 0U;
						e.a.NetCfgInstanceId = global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("᱊⑌ॎ㡐౒", a_) + e.a.DeviceName;
						num = (short)730791978;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_1D2C:
						num = (short)1630404628;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_1F8D:
						e.a.UniqueLocation = e.a.RadioSerialNumber;
						e.a.IMEI = e.a.PID + global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("ᑊ", a_) + e.a.RadioSerialNumber;
						e.a.DeviceInstanceID = e.a.PID + global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("ᑊ", a_) + e.a.RadioSerialNumber;
						e.a.PhysicalLocation = e.a.RadioSerialNumber;
						num = (short)594608169;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_B79:
					IL_15BE:
					goto IL_211B;
					IL_2080:
					goto IL_2109;
				}
				finally
				{
					num = (short)1275920385;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							goto IL_20ED;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_20B7;
							}
							continue;
						case 2:
							enumerator.Dispose();
							num = (short)552796160;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_20B7:
						if (enumerator == null)
						{
							break;
						}
						num = (short)2099380226;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_20ED:;
				}
				goto IL_20F0;
				IL_2109:
				return null;
				IL_211B:
				num = (short)1882587137;
				if (num != 0)
				{
				}
				return result;
			}
			}
		}

		// Token: 0x06000071 RID: 113 RVA: 0x0000B158 File Offset: 0x00009358
		private string a(string deviceName)
		{
			int a_ = 2;
			short num = (short)1584201728;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_3D;
					}
					continue;
				case 1:
					goto IL_E5;
				case 2:
					if (!(deviceName == global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("@ፂᵄॆ繈筊", a_)))
					{
						num = (short)525598721;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_E7;
				case 3:
					num = (short)1794834433;
					if (num != 0)
					{
					}
					num = (short)1815543810;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_3D;
				IL_56:
				num = (short)881328131;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_E7:
				num = (short)2022047744;
				short num3 = num;
				num = (short)878354873;
				short num4 = num;
				num = (short)585998777;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_56;
				default:
					goto IL_143;
				}
				IL_3D:
				if (!(deviceName == global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("@ፂᵄॆైፊ᥌", a_)))
				{
					goto IL_56;
				}
				goto IL_E7;
			}
			IL_E5:
			return global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("ᙀ⩂̈́⹆ᙈ੊ᵌᝎ", a_);
			IL_143:
			num = (short)1878589440;
			if (num != 0)
			{
			}
			return global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("ᙀ⩂̈́⹆ᙈ੊L὎", a_);
		}

		// Token: 0x06000072 RID: 114 RVA: 0x0000B2CC File Offset: 0x000094CC
		private void b()
		{
			int a_ = 2;
			short num = (short)919994368;
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
				global::System.Collections.Generic.List<global::Motorola.Common.Communication.DeviceDiscovery.OriginalPnPMsg> list2;
				for (;;)
				{
					IL_30:
					switch (num2)
					{
					case 0:
						goto IL_566;
					case 1:
						goto IL_5A3;
					case 2:
						try
						{
							num = (short)136511495;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								object obj;
								bool flag;
								switch (num2)
								{
								case 0:
									goto IL_169;
								case 1:
								{
									global::Motorola.Common.Communication.DeviceDiscovery.RawMDNSMessage rawMsg;
									if (!this.l.TryDequeue(out rawMsg))
									{
										num = (short)763494406;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.Common.Communication.DeviceDiscovery.OriginalPnPMsg originalPnPMsg = this.DecodeMDNSMessage(rawMsg);
									num = (short)288030729;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									try
									{
										global::System.Threading.Monitor.Enter(obj, ref flag);
										global::System.Collections.Generic.List<global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile> list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile>();
										using (global::System.Collections.Generic.List<global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile>.Enumerator enumerator = global::Motorola.Common.Communication.DeviceDiscovery.LDTDetectorBase._arrivedDevices.GetEnumerator())
										{
											num = (short)346488837;
											num2 = (int)((global::System.IntPtr)num);
											for (;;)
											{
												switch (num2)
												{
												case 0:
													if (list2.All(new global::System.Func<global::Motorola.Common.Communication.DeviceDiscovery.OriginalPnPMsg, bool>(g.b)))
													{
														num = (short)1338048516;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													}
													break;
												case 1:
													num = (short)1410334726;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												case 2:
												{
													if (!enumerator.MoveNext())
													{
														num = (short)1228406785;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													}
													global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile a = enumerator.Current;
													num = (short)502267904;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												case 3:
													if (!g.a.a())
													{
														num = (short)1924333575;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													}
													break;
												case 4:
													num = (short)371392515;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												case 5:
													switch (0)
													{
													case 0:
														goto IL_1D6;
													}
													continue;
												case 6:
													goto IL_2FB;
												case 7:
													list.Add(g.a);
													num = (short)108396552;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												IL_2A3:
												num = (short)1617690626;
												num2 = (int)((global::System.IntPtr)num);
												continue;
												IL_1D6:
												goto IL_2A3;
											}
											IL_2FB:;
										}
										list.ForEach(new global::System.Action<global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile>(this.a));
										list2.Clear();
										goto IL_4D7;
									}
									finally
									{
										num = (short)1410203648;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												switch (0)
												{
												case 0:
													goto IL_35C;
												}
												continue;
											case 1:
												goto IL_393;
											case 2:
												global::System.Threading.Monitor.Exit(obj);
												num = (short)1722810369;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											IL_35C:
											if (!flag)
											{
												break;
											}
											num = (short)1204355074;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_393:;
									}
									goto IL_396;
									IL_4D7:
									num = (short)150339592;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									goto IL_396;
								case 4:
									global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("ᕀ⭂㝄≆⡈⽊浌㭎㑐⅒㡔㹖㝘㩚⥜㙞๠ൢ䕤ᑦh౪ͬ๮ᵰ卲ݴቶ᩸Ṻᑼॾ", a_), global::System.Array.Empty<object>());
									num = (short)18415616;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									if (!this._isStopping)
									{
										num = (short)1186136067;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_465;
								case 6:
									goto IL_465;
								case 7:
									switch (0)
									{
									case 0:
										goto IL_112;
									}
									continue;
								case 8:
									goto IL_4F0;
								case 9:
								{
									global::Motorola.Common.Communication.DeviceDiscovery.OriginalPnPMsg originalPnPMsg;
									if (originalPnPMsg != null)
									{
										num = (short)1730281482;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_396;
								}
								case 10:
								{
									global::Motorola.Common.Communication.DeviceDiscovery.OriginalPnPMsg originalPnPMsg;
									list2.Add(originalPnPMsg);
									this.c(originalPnPMsg);
									num = (short)835780613;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_112:
								if (this.a())
								{
									num = (short)1940979716;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_396:
								num = (short)956181914;
								short num3 = num;
								num = (short)927542682;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									num = (short)1572470784;
									if (num != 0)
									{
									}
									num = (short)94633985;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_465:
								obj = this.m;
								flag = false;
								num = (short)1511391234;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_169:
							goto IL_5A5;
							IL_4F0:
							goto IL_566;
						}
						catch (global::System.Exception ex)
						{
							global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("р㭂♄≆㥈㽊⑌⁎㽐獒㩔㥖祘὚㡜⥞ࡠbd⽦ࡨժ६ͮᑰ❲ᵴնᱸ᩺᥼䕾", a_) + ex.Message, global::System.Array.Empty<object>());
							goto IL_566;
						}
						goto IL_51F;
					case 3:
						if (this._isStopping)
						{
							num = (short)1100283905;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_51F;
					}
					goto IL_47;
					IL_51F:
					num = (short)412286977;
					if (num != 0)
					{
					}
					num = (short)1620508674;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_566:
					num = (short)191496195;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_5A3:
				IL_5A5:
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("р㭂ⱄ㍆㵈≊⍌⡎煐ᝒ᭔і瑘࡚ᥜ罞ౠ٢ᙤᑦࡨ౪࡬佮ᥰቲ᭴፶ᕸቺ፼᡾ꆀ麗", a_), global::System.Array.Empty<object>());
				return;
				IL_47:
				list2 = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.DeviceDiscovery.OriginalPnPMsg>();
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("рⵂㅄ≆㭈≊⍌⡎煐ᝒ᭔і瑘࡚ᥜ罞ౠ٢ᙤᑦࡨ౪࡬佮ᥰቲ᭴፶ᕸቺ፼᡾ꆀ麗ꮊ戴ﮒ떔뾞잠쾢쒤삦覨\ud8aa좬\udbae醰잲\udab4鞶슸论삼", a_), new object[]
				{
					this._isStopping
				});
				num = (short)1665859584;
				short num4 = num;
				num = (short)330235904;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x06000073 RID: 115 RVA: 0x0000B8E8 File Offset: 0x00009AE8
		private bool a()
		{
			short num = (short)95976937;
			short num2 = num;
			num = (short)385777129;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_9E;
			case 1:
				break;
			default:
			{
				num = (short)1371275264;
				short num3 = num;
				break;
			}
			}
			num = (short)1305477120;
			if (num != 0)
			{
			}
			if (global::System.Threading.WaitHandle.WaitAny(new global::System.Threading.WaitHandle[]
			{
				this.k,
				this.j
			}, 1000) == 1)
			{
				return true;
			}
			IL_9E:
			num = (short)1954480129;
			if (num != 0)
			{
			}
			return false;
		}

		// Token: 0x06000074 RID: 116 RVA: 0x0000B9BC File Offset: 0x00009BBC
		private void c(global::Motorola.Common.Communication.DeviceDiscovery.OriginalPnPMsg A_0)
		{
			int a_ = 0;
			short num = (short)2137587713;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					try
					{
						this.b(A_0);
						return;
					}
					catch (global::System.Exception ex)
					{
						global::Motorola.Common.Communication.CommonUtil.TraceLogger instance = global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance;
						string str = global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("稾㥀⁂⁄㝆㵈≊≌ⅎ煐㩒㭔睖ᵘ㹚⭜㙞ɠ٢Ⅴɦᵨ๪๬᭮ṰŲ㝴ᙶ੸Ṻ䝼䕾톀ﺌ\udf8eﾐ쎒\ud894ﺘ쾚쒠슢솤鶦覨", a_);
						global::System.Exception ex2 = ex;
						instance.WriteError(str + ((ex2 != null) ? ex2.ToString() : null), global::System.Array.Empty<object>());
						return;
					}
					goto IL_135;
				case 1:
				{
					num = (short)1107296256;
					short num3 = num;
					switch (0)
					{
					case 0:
						goto IL_6D;
					}
					continue;
				}
				case 2:
				{
					num = (short)1044604108;
					short num4 = num;
					num = (short)1518625996;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_1A1;
					}
					break;
				}
				case 3:
					num = (short)1440415745;
					if (num != 0)
					{
					}
					if (A_0.m_DeviceAction == global::Motorola.Common.Communication.DeviceDiscovery.DevPnPAction.DeviceDetached)
					{
						num = (short)466288644;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_135;
				case 4:
					goto IL_EB;
				}
				IL_6D:
				if (A_0.m_DeviceAction == global::Motorola.Common.Communication.DeviceDiscovery.DevPnPAction.DeviceAttached)
				{
					num = (short)1236402176;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)1105788931;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_135:
				string format = global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("派⑀⁂⁄⹆㽈⹊⥌潎ၐ㵒畔ɖ㝘㡚ㅜ㩞`ൢ䕤㝦ݨ㭪䵬≮ᑰrٴᙶṸṺ屼", a_);
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(format, global::System.Array.Empty<object>());
				num = (short)1339031554;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_EB:
			try
			{
				this.a(A_0);
			}
			catch (global::System.Exception ex3)
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger instance2 = global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance;
				string str2 = global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("稾㥀⁂⁄㝆㵈≊≌ⅎ煐㩒㭔睖ᵘ㹚⭜㙞ɠ٢Ⅴɦᵨ๪๬᭮ṰŲ㝴ᙶ੸Ṻ䝼䕾톀ﺌ\udf8eﾐ쎒\ud894ﺘ쾚쒠슢솤鶦覨", a_);
				global::System.Exception ex4 = ex3;
				instance2.WriteError(str2 + ((ex4 != null) ? ex4.ToString() : null), global::System.Array.Empty<object>());
			}
			return;
			IL_1A1:
			num = (short)977403904;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000075 RID: 117 RVA: 0x0000BBE0 File Offset: 0x00009DE0
		private void b(global::Motorola.Common.Communication.DeviceDiscovery.OriginalPnPMsg A_0)
		{
			int a_ = 19;
			short num = (short)1824581535;
			short num2 = num;
			num = (short)1433724831;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)2109734912;
				if (num != 0)
				{
				}
				num = (short)1821179904;
				int num3 = (int)num;
				switch (num3)
				{
				default:
				{
					num = (short)845807617;
					if (num != 0)
					{
					}
					global::Motorola.Common.Communication.DeviceDiscovery.DNSSDDetector.h h = new global::Motorola.Common.Communication.DeviceDiscovery.DNSSDDetector.h();
					h.a = (A_0.radioProfile as global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile);
					object obj = this.m;
					bool flag = false;
					try
					{
						switch (0)
						{
						case 0:
							goto IL_F5;
						}
						bool flag2;
						for (;;)
						{
							IL_C6:
							switch (num3)
							{
							case 0:
								goto IL_22B;
							case 1:
							{
								global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile ldtradioProfile;
								if (ldtradioProfile.IPAddress == h.a.IPAddress)
								{
									num = (short)334626821;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.Common.Communication.DeviceDiscovery.LDTDetectorBase._arrivedDevices.Remove(ldtradioProfile);
								base.c(ldtradioProfile);
								h.a.StartTimer();
								global::Motorola.Common.Communication.DeviceDiscovery.LDTDetectorBase._arrivedDevices.Add(h.a);
								num = (short)268697604;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 2:
								goto IL_32F;
							case 3:
								goto IL_1DC;
							case 4:
								goto IL_22B;
							case 5:
							{
								global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile ldtradioProfile;
								ldtradioProfile.StartTimer();
								flag2 = false;
								global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("ᙑㅓ⁕ㅗ㥙㥛繝᝟ୡၣ๥䡧⍩㱫⽭ᑯᙱٳ፵୷ॹ䙻幽ﭿ늁旅ꚅ꺍쎏ﾕ聯튛춟삡솣풥銧誩힫龭춯銱\uddb3억颷\udbb9킻첽ꖿꏁꃃ뿅꧉ꏋꃍ뻏럑럓ꋕ뷗뻙ﻝ迟賡裣鿥죧飩觫鷭闯蛱胳鿵雷鷹\udcfb諽槿漁愃琅", a_), new object[]
								{
									h.a.IPAddress,
									h.a.RadioSerialNumber
								});
								num = (short)672727047;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 6:
							{
								if (global::Motorola.Common.Communication.DeviceDiscovery.LDTDetectorBase._arrivedDevices.Count(new global::System.Func<global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile, bool>(h.b)) == 0)
								{
									num = (short)1193934851;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile ldtradioProfile = global::Motorola.Common.Communication.DeviceDiscovery.LDTDetectorBase._arrivedDevices.Find(new global::System.Predicate<global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile>(h.c));
								num = (short)1771438081;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 7:
								goto IL_22B;
							case 8:
								if (flag2)
								{
									num = (short)413270025;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)1465057282;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 9:
								try
								{
									base.b(h.a);
									goto IL_39C;
								}
								catch
								{
									base.ClearDevice(h.a);
									base.c(h.a);
									throw;
								}
								goto IL_1DC;
							}
							goto IL_F5;
							IL_1DC:
							h.a.detach += this.a;
							h.a.StartTimer();
							global::Motorola.Common.Communication.DeviceDiscovery.LDTDetectorBase._arrivedDevices.Add(h.a);
							num = (short)653459456;
							num3 = (int)((global::System.IntPtr)num);
							continue;
							IL_22B:
							num = (short)1918697480;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_32F:
						break;
						IL_F5:
						global::System.Threading.Monitor.Enter(obj, ref flag);
						flag2 = true;
						num = (short)1819410438;
						num3 = (int)((global::System.IntPtr)num);
						goto IL_C6;
					}
					finally
					{
						num = (short)1822359552;
						num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_363;
								}
								continue;
							case 1:
								goto IL_399;
							case 2:
								global::System.Threading.Monitor.Exit(obj);
								num = (short)1825570817;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_363:
							if (!flag)
							{
								break;
							}
							num = (short)1220608002;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_399:;
					}
					break;
				}
				}
				break;
			}
			}
			IL_39C:
			num = (short)1835859968;
			short num4 = num;
		}

		// Token: 0x06000076 RID: 118 RVA: 0x0000BFE8 File Offset: 0x0000A1E8
		private void a(global::Motorola.Common.Communication.DeviceDiscovery.OriginalPnPMsg A_0)
		{
			short num = (short)1717501953;
			if (num != 0)
			{
			}
			num = (short)388932925;
			short num2 = num;
			num = (short)1349821757;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1959460864;
				if (num != 0)
				{
				}
				num = (short)1187381248;
				int num3 = (int)num;
				switch (num3)
				{
				default:
				{
					global::Motorola.Common.Communication.DeviceDiscovery.DNSSDDetector.i i = new global::Motorola.Common.Communication.DeviceDiscovery.DNSSDDetector.i();
					i.a = A_0;
					object obj = this.m;
					bool flag = false;
					try
					{
						switch (0)
						{
						case 0:
							goto IL_CA;
						}
						for (;;)
						{
							IL_B3:
							switch (num3)
							{
							case 0:
								if (global::Motorola.Common.Communication.DeviceDiscovery.LDTDetectorBase._arrivedDevices.Count(new global::System.Func<global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile, bool>(i.b)) > 0)
								{
									num = (short)87687170;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_152;
							case 1:
								goto IL_16A;
							case 2:
							{
								global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile a_ = global::Motorola.Common.Communication.DeviceDiscovery.LDTDetectorBase._arrivedDevices.First(new global::System.Func<global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile, bool>(i.c));
								this.a(a_, null);
								num = (short)1611595779;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 3:
								goto IL_152;
							}
							goto IL_CA;
							IL_152:
							num = (short)933494785;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_16A:
						break;
						IL_CA:
						global::System.Threading.Monitor.Enter(obj, ref flag);
						num = (short)751566848;
						num3 = (int)((global::System.IntPtr)num);
						goto IL_B3;
					}
					finally
					{
						num = (short)2033582080;
						num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_19F;
								}
								continue;
							case 1:
								goto IL_1D4;
							case 2:
								global::System.Threading.Monitor.Exit(obj);
								num = (short)1021837313;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_19F:
							if (!flag)
							{
								break;
							}
							num = (short)1528758274;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_1D4:;
					}
					break;
				}
				}
				break;
			}
			}
			num = (short)938344448;
			short num4 = num;
		}

		// Token: 0x06000077 RID: 119 RVA: 0x0000C208 File Offset: 0x0000A408
		private void a(object A_0, global::System.EventArgs A_1 = null)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2 = (short)536805377;
					if (num2 != 0)
					{
					}
					if (global::Motorola.Common.Communication.DeviceDiscovery.LDTDetectorBase._arrivedDevices.Count(new global::System.Func<global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile, bool>(j.b)) > 0)
					{
						num2 = (short)974389250;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 1:
					return;
				case 2:
					base.c(j.a as global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile);
					global::Motorola.Common.Communication.DeviceDiscovery.LDTDetectorBase._arrivedDevices.RemoveAll(new global::System.Predicate<global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile>(j.c));
					num2 = (short)72417281;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_1C;
			}
			return;
			IL_1C:
			num2 = (short)858340014;
			short num3 = num2;
			num2 = (short)1266301614;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num2 = (short)235077632;
				short num4 = num2;
				num2 = (short)1726152704;
				if (num2 != 0)
				{
				}
				break;
			}
			}
			num2 = (short)1385037824;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000078 RID: 120 RVA: 0x0000C368 File Offset: 0x0000A568
		private void a(object A_0)
		{
			short num = (short)182124544;
			short num2 = num;
			num = (short)1262157824;
			switch (num)
			{
			default:
			{
				global::System.Collections.Generic.Dictionary<global::System.Collections.Generic.KeyValuePair<string, string>, bool> obj = this.ac;
				bool flag = false;
				try
				{
					num = (short)1333329921;
					if (num != 0)
					{
					}
					global::System.Threading.Monitor.Enter(obj, ref flag);
					global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, string>> list = new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, string>>();
					using (global::System.Collections.Generic.Dictionary<global::System.Collections.Generic.KeyValuePair<string, string>, bool>.Enumerator enumerator = this.ac.GetEnumerator())
					{
						num = (short)725811204;
						int num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							global::System.Collections.Generic.KeyValuePair<global::System.Collections.Generic.KeyValuePair<string, string>, bool> keyValuePair;
							switch (num3)
							{
							case 0:
								if (!enumerator.MoveNext())
								{
									num = (short)529858563;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_1CC;
							case 2:
								if (keyValuePair.Value)
								{
									num = (short)1092681735;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							case 3:
								num = (short)1864105990;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
								switch (0)
								{
								case 0:
									goto IL_DE;
								}
								continue;
							case 5:
								try
								{
									object syncRoot;
									bool flag2;
									global::System.Threading.Monitor.Enter(syncRoot, ref flag2);
									global::Motorola.Common.Communication.DeviceDiscovery.OriginalPnPMsg originalPnPMsg = new global::Motorola.Common.Communication.DeviceDiscovery.OriginalPnPMsg();
									originalPnPMsg.m_DeviceAction = global::Motorola.Common.Communication.DeviceDiscovery.DevPnPAction.DeviceDetached;
									originalPnPMsg.sDeviceName = keyValuePair.Key.Value;
									this.i.Add(originalPnPMsg);
									goto IL_214;
								}
								finally
								{
									num = (short)1354170368;
									num3 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										switch (num3)
										{
										case 0:
											switch (0)
											{
											case 0:
												goto IL_192;
											}
											continue;
										case 1:
											goto IL_1C9;
										case 2:
										{
											object syncRoot;
											global::System.Threading.Monitor.Exit(syncRoot);
											num = (short)1851719681;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										}
										IL_192:
										bool flag2;
										if (!flag2)
										{
											break;
										}
										num = (short)1653276674;
										num3 = (int)((global::System.IntPtr)num);
									}
									IL_1C9:;
								}
								goto IL_1CC;
								IL_214:
								this.ad.Remove(keyValuePair.Key.Key);
								num = (short)484573185;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 6:
								goto IL_2A2;
							case 7:
							{
								list.Add(keyValuePair.Key);
								object syncRoot = this.i.SyncRoot;
								bool flag2 = false;
								num = (short)1738145797;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							IL_E3:
							num = (short)1963196416;
							num3 = (int)((global::System.IntPtr)num);
							continue;
							IL_DE:
							goto IL_E3;
							IL_1CC:
							keyValuePair = enumerator.Current;
							num = (short)403832834;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_2A2:
						goto IL_388;
					}
					global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, string>>.Enumerator enumerator2;
					try
					{
						IL_2B5:
						num = (short)1448148993;
						int num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 1:
								switch (0)
								{
								case 0:
									goto IL_2F1;
								}
								continue;
							case 2:
								goto IL_375;
							case 3:
							{
								if (!enumerator2.MoveNext())
								{
									num = (short)731381764;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::System.Collections.Generic.KeyValuePair<string, string> key = enumerator2.Current;
								this.ac.Remove(key);
								num = (short)903610368;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 4:
								num = (short)1105264642;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_323:
							num = (short)1807351811;
							num3 = (int)((global::System.IntPtr)num);
							continue;
							IL_2F1:
							goto IL_323;
						}
						IL_375:
						return;
					}
					finally
					{
						((global::System.IDisposable)enumerator2).Dispose();
					}
					IL_388:
					enumerator2 = list.GetEnumerator();
					goto IL_2B5;
				}
				finally
				{
					num = (short)162988032;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_3C7;
							}
							continue;
						case 1:
							goto IL_44F;
						case 2:
							global::System.Threading.Monitor.Exit(obj);
							num = (short)1488322561;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_3C7:
						if (!flag)
						{
							break;
						}
						num = (short)63203780;
						short num4 = num;
						num = (short)993159620;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)356581376;
							if (num != 0)
							{
							}
							num = (short)1725104130;
							num3 = (int)((global::System.IntPtr)num);
							break;
						}
					}
					IL_44F:;
				}
				return;
			}
			}
		}

		// Token: 0x06000079 RID: 121 RVA: 0x0000C82C File Offset: 0x0000AA2C
		public void Dispose()
		{
			short num = (short)1673898189;
			short num2 = num;
			num = (short)1474668749;
			switch (num2 == num)
			{
			}
			num = (short)1654915073;
			if (num != 0)
			{
			}
			num = (short)999817216;
			short num3 = num;
			num = (short)1720057856;
			if (num != 0)
			{
			}
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x0600007A RID: 122 RVA: 0x0000C8E4 File Offset: 0x0000AAE4
		protected virtual void Dispose(bool disposing)
		{
			short num = (short)899547137;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)2006188033;
					if (num != 0)
					{
					}
					num = (short)993020354;
					short num3 = num;
					num = (short)34032066;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
					{
						num = (short)352780288;
						if (num != 0)
						{
						}
						num = (short)801964032;
						short num4 = num;
						this.ab.Close();
						this.h.Close();
						this.k.Close();
						this.j.Close();
						num = (short)91291650;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 1:
					switch (0)
					{
					case 0:
						goto IL_31;
					}
					continue;
				case 2:
					return;
				}
				IL_31:
				if (!disposing)
				{
					break;
				}
				num = (short)928448512;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x0600007B RID: 123 RVA: 0x0000CA20 File Offset: 0x0000AC20
		// Note: this type is marked as 'beforefieldinit'.
		static DNSSDDetector()
		{
			short num = (short)1510899777;
			short num2 = num;
			num = (short)318668865;
			switch (num2 == num)
			{
			}
			num = (short)1711800321;
			if (num != 0)
			{
			}
			num = (short)628228096;
			short num3 = num;
			num = (short)1893400576;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.DeviceDiscovery.DNSSDDetector.c = null;
			global::Motorola.Common.Communication.DeviceDiscovery.DNSSDDetector.d = new object();
			global::Motorola.Common.Communication.DeviceDiscovery.DNSSDDetector.e = null;
		}

		// Token: 0x0600007C RID: 124 RVA: 0x0000CADC File Offset: 0x0000ACDC
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private void a(object A_0, global::System.Timers.ElapsedEventArgs A_1)
		{
			short num = (short)1699676161;
			if (num != 0)
			{
			}
			num = (short)127147912;
			short num2 = num;
			num = (short)1744969608;
			switch (num2 == num)
			{
			}
			num = (short)1257570304;
			short num3 = num;
			num = (short)1549533184;
			if (num != 0)
			{
			}
			this.a(A_0);
		}

		// Token: 0x0600007D RID: 125 RVA: 0x0000CB8C File Offset: 0x0000AD8C
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private void a(global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile A_0)
		{
			short num = (short)2016280576;
			short num2 = num;
			num = (short)1269021523;
			short num3 = num;
			num = (short)640858963;
			switch (num3 == num)
			{
			}
			num = (short)2008940544;
			if (num != 0)
			{
			}
			num = (short)1390870529;
			if (num != 0)
			{
			}
			this.a(A_0, null);
		}

		// Token: 0x0400002F RID: 47
		private static byte[] a;

		// Token: 0x04000030 RID: 48
		private new readonly global::System.Net.IPAddress b;

		// Token: 0x04000031 RID: 49
		private new static global::Motorola.Common.Communication.DnsConfig c;

		// Token: 0x04000032 RID: 50
		private new static object d;

		// Token: 0x04000033 RID: 51
		private static global::System.Net.Sockets.UdpClient e;

		// Token: 0x04000034 RID: 52
		private global::System.Net.IPEndPoint f;

		// Token: 0x04000035 RID: 53
		private global::System.Threading.Thread g;

		// Token: 0x04000036 RID: 54
		private global::System.Threading.AutoResetEvent h = new global::System.Threading.AutoResetEvent(false);

		// Token: 0x04000037 RID: 55
		private global::System.Collections.ArrayList i = new global::System.Collections.ArrayList();

		// Token: 0x04000038 RID: 56
		private global::System.Threading.ManualResetEvent j = new global::System.Threading.ManualResetEvent(false);

		// Token: 0x04000039 RID: 57
		private global::System.Threading.AutoResetEvent k = new global::System.Threading.AutoResetEvent(false);

		// Token: 0x0400003A RID: 58
		private readonly global::System.Collections.Concurrent.ConcurrentQueue<global::Motorola.Common.Communication.DeviceDiscovery.RawMDNSMessage> l = new global::System.Collections.Concurrent.ConcurrentQueue<global::Motorola.Common.Communication.DeviceDiscovery.RawMDNSMessage>();

		// Token: 0x0400003B RID: 59
		private object m = new object();

		// Token: 0x0400003C RID: 60
		public global::System.Net.NetworkInformation.NetworkInterface[] networkAdapterArray = global::System.Net.NetworkInformation.NetworkInterface.GetAllNetworkInterfaces();

		// Token: 0x0400003D RID: 61
		public global::System.Collections.Generic.List<global::System.Net.NetworkInformation.NetworkInterface> multicastConnectedAdapterList = new global::System.Collections.Generic.List<global::System.Net.NetworkInformation.NetworkInterface>();

		// Token: 0x0400003E RID: 62
		public global::System.Collections.Generic.List<global::System.Net.NetworkInformation.NetworkInterface> multicastDisconnectedAdapterList = new global::System.Collections.Generic.List<global::System.Net.NetworkInformation.NetworkInterface>();

		// Token: 0x0400003F RID: 63
		public const string PCR_WIFI_PID = "WiFi_MotoTrbo";

		// Token: 0x04000040 RID: 64
		public const string PCR_BT_PID = "BT_MotoTrbo";

		// Token: 0x04000041 RID: 65
		public const string ASTRO_WIFI_PID = "WiFi_APX";

		// Token: 0x04000042 RID: 66
		public const string PBB_WIFI_PID = "WiFi_PBB";

		// Token: 0x04000043 RID: 67
		public const string AMP_WIFI_PID = "WiFi_AMP";

		// Token: 0x04000044 RID: 68
		private const string n = "MOTOTRBO_";

		// Token: 0x04000045 RID: 69
		private const string o = "APX ";

		// Token: 0x04000046 RID: 70
		private const string p = "APXNEXT";

		// Token: 0x04000047 RID: 71
		private const string q = "52010";

		// Token: 0x04000048 RID: 72
		private const string r = "APX NEXT";

		// Token: 0x04000049 RID: 73
		private const string s = "APXN70";

		// Token: 0x0400004A RID: 74
		private const string t = "APX N70";

		// Token: 0x0400004B RID: 75
		private const string u = "tlsPsk";

		// Token: 0x0400004C RID: 76
		private const string v = "Futon";

		// Token: 0x0400004D RID: 77
		private const string w = "Fusion";

		// Token: 0x0400004E RID: 78
		private const string x = "Vertex";

		// Token: 0x0400004F RID: 79
		private const string y = "VX";

		// Token: 0x04000050 RID: 80
		private const string z = "The Device Programmer might not be connected to a Network Interfaces.This might affect programming radios via Wi-Fi. If affected, please check the network connection and restart the RM Device Programmer.";

		// Token: 0x04000051 RID: 81
		private const int aa = 1000;

		// Token: 0x04000052 RID: 82
		private global::System.Timers.Timer ab = new global::System.Timers.Timer(5000.0);

		// Token: 0x04000053 RID: 83
		private global::System.Collections.Generic.Dictionary<global::System.Collections.Generic.KeyValuePair<string, string>, bool> ac = new global::System.Collections.Generic.Dictionary<global::System.Collections.Generic.KeyValuePair<string, string>, bool>();

		// Token: 0x04000054 RID: 84
		private global::System.Collections.Generic.Dictionary<string, long> ad = new global::System.Collections.Generic.Dictionary<string, long>();

		// Token: 0x02000014 RID: 20
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class a
		{
			// Token: 0x06000090 RID: 144 RVA: 0x0000DEA0 File Offset: 0x0000C0A0
			internal bool b(global::System.Net.NetworkInformation.NetworkInterface A_0)
			{
				short num = (short)1118568448;
				short num2 = num;
				num = (short)1608910311;
				short num3 = num;
				num = (short)1921385959;
				switch (num3 == num)
				{
				}
				num = (short)1096810496;
				if (num != 0)
				{
				}
				num = (short)642580481;
				if (num != 0)
				{
				}
				return A_0.GetPhysicalAddress().ToString() == this.a.GetPhysicalAddress().ToString();
			}

			// Token: 0x06000091 RID: 145 RVA: 0x0000DF68 File Offset: 0x0000C168
			internal bool c(global::System.Net.NetworkInformation.NetworkInterface A_0)
			{
				short num = (short)859635712;
				short num2 = num;
				num = (short)1657172027;
				short num3 = num;
				num = (short)709324859;
				switch (num3 == num)
				{
				}
				num = (short)500236289;
				if (num != 0)
				{
				}
				num = (short)1635123200;
				if (num != 0)
				{
				}
				return A_0.GetPhysicalAddress().ToString() == this.a.GetPhysicalAddress().ToString();
			}

			// Token: 0x0400005D RID: 93
			public global::System.Net.NetworkInformation.NetworkInterface a;
		}

		// Token: 0x02000015 RID: 21
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private new sealed class b
		{
			// Token: 0x06000093 RID: 147 RVA: 0x0000E048 File Offset: 0x0000C248
			internal bool b(global::System.Net.NetworkInformation.NetworkInterface A_0)
			{
				short num = (short)1601699840;
				short num2 = num;
				num = (short)1183503653;
				short num3 = num;
				num = (short)1537004837;
				switch (num3 == num)
				{
				}
				num = (short)534577153;
				if (num != 0)
				{
				}
				num = (short)1227882496;
				if (num != 0)
				{
				}
				return A_0.GetPhysicalAddress().ToString() == this.a.GetPhysicalAddress().ToString();
			}

			// Token: 0x06000094 RID: 148 RVA: 0x0000E114 File Offset: 0x0000C314
			internal bool c(global::System.Net.NetworkInformation.NetworkInterface A_0)
			{
				short num = (short)548732928;
				short num2 = num;
				num = (short)448793707;
				short num3 = num;
				num = (short)1697778795;
				switch (num3 == num)
				{
				}
				num = (short)2055143425;
				if (num != 0)
				{
				}
				num = (short)999620608;
				if (num != 0)
				{
				}
				return A_0.GetPhysicalAddress().ToString() == this.a.GetPhysicalAddress().ToString();
			}

			// Token: 0x06000095 RID: 149 RVA: 0x0000E1DC File Offset: 0x0000C3DC
			internal bool d(global::System.Net.NetworkInformation.NetworkInterface A_0)
			{
				short num = (short)1186070528;
				short num2 = num;
				num = (short)243785414;
				short num3 = num;
				num = (short)1335877318;
				switch (num3 == num)
				{
				}
				num = (short)1936195585;
				if (num != 0)
				{
				}
				num = (short)1918238720;
				if (num != 0)
				{
				}
				return A_0.GetPhysicalAddress().ToString() == this.a.GetPhysicalAddress().ToString();
			}

			// Token: 0x06000096 RID: 150 RVA: 0x0000E2A4 File Offset: 0x0000C4A4
			internal bool e(global::System.Net.NetworkInformation.NetworkInterface A_0)
			{
				short num = (short)330956800;
				short num2 = num;
				num = (short)1698949959;
				short num3 = num;
				num = (short)896133959;
				switch (num3 == num)
				{
				}
				num = (short)1484783617;
				if (num != 0)
				{
				}
				num = (short)881917952;
				if (num != 0)
				{
				}
				return A_0.GetPhysicalAddress().ToString() == this.a.GetPhysicalAddress().ToString();
			}

			// Token: 0x0400005E RID: 94
			public global::System.Net.NetworkInformation.NetworkInterface a;
		}

		// Token: 0x02000016 RID: 22
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private new sealed class c
		{
			// Token: 0x0400005F RID: 95
			public global::System.Net.IPEndPoint a;
		}

		// Token: 0x02000017 RID: 23
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private new sealed class d
		{
			// Token: 0x06000099 RID: 153 RVA: 0x0000E394 File Offset: 0x0000C594
			internal bool c(global::Motorola.Common.Communication.RecordTXT A_0)
			{
				short num = (short)705429504;
				short num2 = num;
				num = (short)2027683841;
				if (num != 0)
				{
				}
				num = (short)1469948657;
				short num3 = num;
				num = (short)1663148785;
				switch (num3 == num)
				{
				}
				num = (short)1607073792;
				if (num != 0)
				{
				}
				return A_0.NAME == this.a.DomainName;
			}

			// Token: 0x0600009A RID: 154 RVA: 0x0000E450 File Offset: 0x0000C650
			internal bool d(global::Motorola.Common.Communication.RecordTXT A_0)
			{
				short num = (short)1796341760;
				short num2 = num;
				num = (short)1329563897;
				short num3 = num;
				num = (short)166496505;
				switch (num3 == num)
				{
				}
				num = (short)919535617;
				if (num != 0)
				{
				}
				num = (short)1375076352;
				if (num != 0)
				{
				}
				return A_0.NAME == this.a.DomainName;
			}

			// Token: 0x0600009B RID: 155 RVA: 0x0000E514 File Offset: 0x0000C714
			internal bool c(global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile A_0)
			{
				while (A_0.DomainName == this.a.DomainName)
				{
					short num = (short)1598357504;
					short num2 = num;
					num = (short)316458694;
					short num3 = num;
					num = (short)279889606;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1047986176;
						if (num != 0)
						{
						}
						num = (short)106496001;
						if (num != 0)
						{
						}
						return A_0.IPAddress == this.b.a.Address.ToString();
					}
				}
				return false;
			}

			// Token: 0x0600009C RID: 156 RVA: 0x0000E600 File Offset: 0x0000C800
			internal bool e(global::Motorola.Common.Communication.RecordTXT A_0)
			{
				short num = (short)1674182656;
				short num2 = num;
				num = (short)202519712;
				short num3 = num;
				num = (short)865285280;
				switch (num3 == num)
				{
				}
				num = (short)1536688129;
				if (num != 0)
				{
				}
				num = (short)1073545216;
				if (num != 0)
				{
				}
				return A_0.NAME == this.a.DomainName;
			}

			// Token: 0x0600009D RID: 157 RVA: 0x0000E6C0 File Offset: 0x0000C8C0
			internal bool f(global::Motorola.Common.Communication.RecordTXT A_0)
			{
				short num = (short)1678049280;
				short num2 = num;
				num = (short)1445833962;
				short num3 = num;
				num = (short)1830202602;
				switch (num3 == num)
				{
				}
				num = (short)1205272576;
				if (num != 0)
				{
				}
				num = (short)612368385;
				if (num != 0)
				{
				}
				return A_0.NAME == this.a.DomainName;
			}

			// Token: 0x0600009E RID: 158 RVA: 0x0000E780 File Offset: 0x0000C980
			internal bool g(global::Motorola.Common.Communication.RecordTXT A_0)
			{
				short num = (short)2034827264;
				short num2 = num;
				num = (short)2069608126;
				short num3 = num;
				num = (short)772060862;
				switch (num3 == num)
				{
				}
				num = (short)1361117185;
				if (num != 0)
				{
				}
				num = (short)866123776;
				if (num != 0)
				{
				}
				return A_0.NAME == this.a.DomainName;
			}

			// Token: 0x0600009F RID: 159 RVA: 0x0000E840 File Offset: 0x0000CA40
			internal bool h(global::Motorola.Common.Communication.RecordTXT A_0)
			{
				short num = (short)1078788096;
				short num2 = num;
				num = (short)357412305;
				short num3 = num;
				num = (short)1036824017;
				switch (num3 == num)
				{
				}
				num = (short)669646849;
				if (num != 0)
				{
				}
				num = (short)1551433728;
				if (num != 0)
				{
				}
				return A_0.NAME == this.a.DomainName;
			}

			// Token: 0x060000A0 RID: 160 RVA: 0x0000E900 File Offset: 0x0000CB00
			internal bool c(global::Motorola.Common.Communication.RecordSRV A_0)
			{
				short num = (short)207486976;
				short num2 = num;
				num = (short)113461121;
				short num3 = num;
				num = (short)775964545;
				switch (num3 == num)
				{
				}
				num = (short)1517617153;
				if (num != 0)
				{
				}
				num = (short)1467285504;
				if (num != 0)
				{
				}
				return A_0.NAME == this.a.DomainName;
			}

			// Token: 0x060000A1 RID: 161 RVA: 0x0000E9BC File Offset: 0x0000CBBC
			internal bool d(global::Motorola.Common.Communication.RecordSRV A_0)
			{
				short num = (short)336003072;
				short num2 = num;
				num = (short)148897793;
				if (num != 0)
				{
				}
				num = (short)781857615;
				short num3 = num;
				num = (short)197342031;
				switch (num3 == num)
				{
				}
				num = (short)1099497472;
				if (num != 0)
				{
				}
				return A_0.NAME == this.a.DomainName;
			}

			// Token: 0x060000A2 RID: 162 RVA: 0x0000EA7C File Offset: 0x0000CC7C
			internal bool e(global::Motorola.Common.Communication.RecordSRV A_0)
			{
				short num = (short)1160904704;
				short num2 = num;
				num = (short)327631265;
				short num3 = num;
				num = (short)1558069665;
				switch (num3 == num)
				{
				}
				num = (short)1281294337;
				if (num != 0)
				{
				}
				num = (short)1586036736;
				if (num != 0)
				{
				}
				return A_0.NAME == this.a.DomainName;
			}

			// Token: 0x04000060 RID: 96
			public global::Motorola.Common.Communication.RecordPTR a;

			// Token: 0x04000061 RID: 97
			public global::Motorola.Common.Communication.DeviceDiscovery.DNSSDDetector.c b;
		}

		// Token: 0x02000018 RID: 24
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class e
		{
			// Token: 0x060000A4 RID: 164 RVA: 0x0000EB50 File Offset: 0x0000CD50
			internal bool b(global::Motorola.Common.Communication.CommonUtil.AuthenticationInfo A_0)
			{
				while (A_0.AuthType == global::Motorola.Common.Communication.CommonUtil.AuthenticationType.PasswordIndex)
				{
					short num = (short)1342504960;
					short num2 = num;
					num = (short)487176625;
					short num3 = num;
					num = (short)870758833;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)366739456;
						if (num != 0)
						{
						}
						num = (short)884670465;
						if (num != 0)
						{
						}
						return A_0.PreSharedKey_ID == this.a.PasswordId;
					}
				}
				return false;
			}

			// Token: 0x060000A5 RID: 165 RVA: 0x0000EC24 File Offset: 0x0000CE24
			internal bool c(global::Motorola.Common.Communication.CommonUtil.AuthenticationInfo A_0)
			{
				short num;
				for (;;)
				{
					num = (short)1847525377;
					if (num != 0)
					{
					}
					num = (short)288686080;
					short num2 = num;
					if (A_0.AuthType != global::Motorola.Common.Communication.CommonUtil.AuthenticationType.PasswordIndex)
					{
						return false;
					}
					num = (short)1328601276;
					short num3 = num;
					num = (short)762566844;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_8E;
					}
				}
				IL_8E:
				num = (short)1686437888;
				if (num != 0)
				{
				}
				return A_0.PreSharedKey_ID == this.a.PasswordId;
			}

			// Token: 0x04000062 RID: 98
			public global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile a;
		}

		// Token: 0x02000019 RID: 25
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class f
		{
			// Token: 0x060000A7 RID: 167 RVA: 0x0000ED04 File Offset: 0x0000CF04
			internal bool b(global::Motorola.Common.Communication.RecordA A_0)
			{
				short num = (short)154206208;
				short num2 = num;
				num = (short)1015827654;
				short num3 = num;
				num = (short)132533446;
				switch (num3 == num)
				{
				}
				num = (short)1042939905;
				if (num != 0)
				{
				}
				num = (short)460193792;
				if (num != 0)
				{
				}
				return A_0.NAME == this.a;
			}

			// Token: 0x04000063 RID: 99
			public string a;
		}

		// Token: 0x0200001B RID: 27
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class g
		{
			// Token: 0x060000AC RID: 172 RVA: 0x0000EF5C File Offset: 0x0000D15C
			internal bool b(global::Motorola.Common.Communication.DeviceDiscovery.OriginalPnPMsg A_0)
			{
				short num = (short)173146112;
				short num2 = num;
				num = (short)1317939554;
				short num3 = num;
				num = (short)709372258;
				switch (num3 == num)
				{
				}
				num = (short)1192558593;
				if (num != 0)
				{
				}
				num = (short)1753022464;
				if (num != 0)
				{
				}
				return A_0.sDeviceName != this.a.DomainName;
			}

			// Token: 0x04000066 RID: 102
			public global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile a;
		}

		// Token: 0x0200001C RID: 28
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class h
		{
			// Token: 0x060000AE RID: 174 RVA: 0x0000F030 File Offset: 0x0000D230
			internal bool b(global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile A_0)
			{
				short num = (short)144310272;
				short num2 = num;
				num = (short)169462961;
				short num3 = num;
				num = (short)41929905;
				switch (num3 == num)
				{
				}
				num = (short)58195969;
				if (num != 0)
				{
				}
				num = (short)608436224;
				if (num != 0)
				{
				}
				return A_0.DomainName == this.a.DomainName;
			}

			// Token: 0x060000AF RID: 175 RVA: 0x0000F0F0 File Offset: 0x0000D2F0
			internal bool c(global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile A_0)
			{
				short num = (short)1168041776;
				short num2 = num;
				num = (short)958457648;
				switch (num2 == num)
				{
				}
				num = (short)978911233;
				if (num != 0)
				{
				}
				num = (short)1178468352;
				short num3 = num;
				num = (short)1885929472;
				if (num != 0)
				{
				}
				return A_0.RadioSerialNumber == this.a.RadioSerialNumber;
			}

			// Token: 0x04000067 RID: 103
			public global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile a;
		}

		// Token: 0x0200001D RID: 29
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class i
		{
			// Token: 0x060000B1 RID: 177 RVA: 0x0000F1C8 File Offset: 0x0000D3C8
			internal bool b(global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile A_0)
			{
				short num = (short)1776718236;
				short num2 = num;
				num = (short)591106460;
				switch (num2 == num)
				{
				}
				num = (short)1452146689;
				if (num != 0)
				{
				}
				num = (short)498008064;
				short num3 = num;
				num = (short)762380288;
				if (num != 0)
				{
				}
				return A_0.DomainName == this.a.sDeviceName;
			}

			// Token: 0x060000B2 RID: 178 RVA: 0x0000F288 File Offset: 0x0000D488
			internal bool c(global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile A_0)
			{
				short num = (short)1066936560;
				short num2 = num;
				num = (short)763963632;
				switch (num2 == num)
				{
				}
				num = (short)1463156736;
				if (num != 0)
				{
				}
				num = (short)305987584;
				short num3 = num;
				num = (short)2015625217;
				if (num != 0)
				{
				}
				return A_0.DomainName == this.a.sDeviceName;
			}

			// Token: 0x04000068 RID: 104
			public global::Motorola.Common.Communication.DeviceDiscovery.OriginalPnPMsg a;
		}

		// Token: 0x0200001E RID: 30
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class j
		{
			// Token: 0x060000B4 RID: 180 RVA: 0x0000F358 File Offset: 0x0000D558
			internal bool b(global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile A_0)
			{
				short num;
				if (A_0.RadioSerialNumber == (this.a as global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile).RadioSerialNumber)
				{
					num = (short)1736793189;
					short num2 = num;
					num = (short)1856199781;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1517158400;
						if (num != 0)
						{
						}
						num = (short)1726283776;
						short num3 = num;
						return A_0.DomainName == (this.a as global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile).DomainName;
					}
					}
				}
				num = (short)1817575425;
				if (num != 0)
				{
				}
				return false;
			}

			// Token: 0x060000B5 RID: 181 RVA: 0x0000F440 File Offset: 0x0000D640
			internal bool c(global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile A_0)
			{
				short num = (short)1051001255;
				short num2 = num;
				num = (short)784859559;
				switch (num2 == num)
				{
				}
				num = (short)1692860416;
				if (num != 0)
				{
				}
				num = (short)1481375744;
				short num3 = num;
				num = (short)1860894721;
				if (num != 0)
				{
				}
				return A_0.RadioSerialNumber == (this.a as global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile).RadioSerialNumber;
			}

			// Token: 0x04000069 RID: 105
			public object a;
		}
	}
}
