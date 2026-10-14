using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Motorola.Common.Communication.CommonUtil;

namespace Common.Communication.Simulator
{
	// Token: 0x0200000D RID: 13
	public class VirtualLeManager
	{
		// Token: 0x06000082 RID: 130 RVA: 0x00009A78 File Offset: 0x00007C78
		private VirtualLeManager()
		{
			this.c = global::Common.Communication.Simulator.VirtualLEDevices.LoadFromFile();
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00009A98 File Offset: 0x00007C98
		private static string a()
		{
			int a_ = 11;
			switch (0)
			{
			case 0:
				goto IL_29;
			}
			int num;
			short num2;
			string result;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					num2 = (short)142868481;
					if (num2 != 0)
					{
					}
					result = global::System.IO.Path.GetDirectoryName(global::System.Reflection.Assembly.GetExecutingAssembly().Location) + global::Common.Communication.Simulator.VirtualLEDevices.b("ᙉᩋ❍≏♑⅓㝕㑗࡙㵛㩝य़ൡᝣ㩥Ⱨཀྵᩫݭ፯᝱⁳ཱུࡷόほ᝽ꪃﺅ", a_);
					num2 = (short)1029439489;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					return result;
				case 2:
					return result;
				case 3:
					if (global::System.Reflection.Assembly.GetEntryAssembly() == null)
					{
						num2 = (short)1153826816;
						short num3 = num2;
						num2 = (short)385995477;
						short num4 = num2;
						num2 = (short)231330517;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num2 = (short)677773312;
							if (num2 != 0)
							{
							}
							num2 = (short)679739392;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
					}
					else
					{
						result = global::Common.Communication.Simulator.VRDefinitions.VirtualDeviceFolder + global::Common.Communication.Simulator.VirtualLEDevices.b("ᙉࡋ⭍♏㭑㝓㍕౗⍙ⱛ㭝ⱟୡᝣብ䙧ቩūɭ", a_);
					}
					num2 = (short)1751580674;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_29;
			}
			return result;
			IL_29:
			result = string.Empty;
			num2 = (short)123011075;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000084 RID: 132 RVA: 0x00009C1C File Offset: 0x00007E1C
		public static global::Common.Communication.Simulator.VirtualLeManager Instance
		{
			get
			{
				short num = (short)277086209;
				if (num != 0)
				{
				}
				object obj = global::Common.Communication.Simulator.VirtualLeManager.b;
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
							global::Common.Communication.Simulator.VirtualLeManager.a = new global::Common.Communication.Simulator.VirtualLeManager();
							num = (short)666959874;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_C6;
						case 2:
							goto IL_AF;
						case 3:
							if (global::Common.Communication.Simulator.VirtualLeManager.a == null)
							{
								num = (short)1040777216;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_AF;
						}
						goto IL_54;
						IL_AF:
						num = (short)1546518529;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_C6:
					goto IL_182;
					IL_54:
					global::System.Threading.Monitor.Enter(obj, ref flag);
					num = (short)241893379;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_3E;
				}
				finally
				{
					num = (short)1462829058;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_17F;
						case 1:
							for (;;)
							{
								num = (short)932836489;
								short num3 = num;
								num = (short)1073476745;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									goto IL_14C;
								}
							}
							IL_14C:
							num = (short)688062464;
							if (num != 0)
							{
							}
							global::System.Threading.Monitor.Exit(obj);
							num = (short)785645568;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_FB;
							}
							continue;
						}
						IL_FB:
						if (!flag)
						{
							break;
						}
						num = (short)2094858241;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_17F:;
				}
				IL_182:
				num = (short)1820852224;
				short num4 = num;
				return global::Common.Communication.Simulator.VirtualLeManager.a;
			}
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00009DE8 File Offset: 0x00007FE8
		private void b(global::Common.Communication.Simulator.LESystemDevicesInfo A_0)
		{
			global::System.Threading.Thread.Sleep(50);
			global::System.Collections.Generic.List<string>.Enumerator enumerator = A_0.DeviceIdList.GetEnumerator();
			short num;
			try
			{
				num = (short)1850933250;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)1362034691;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1524914743;
						short num3 = num;
						num = (short)301029943;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
						{
							num = (short)684392448;
							if (num != 0)
							{
							}
							string serialNumber = enumerator.Current;
							global::Motorola.Common.Communication.CommonUtil.SingletonBase<global::Common.Communication.Simulator.VirtualDeviceDetector>.Instance().AttachDevice(global::Motorola.Common.Communication.CommonUtil.ConnectionType.LENetwork, serialNumber);
							num = (short)2142109700;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 1:
						goto IL_11D;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_4F;
						}
						continue;
					case 3:
						num = (short)26476545;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_C8:
					num = (short)1685848064;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4F:
					goto IL_C8;
				}
				IL_11D:;
			}
			finally
			{
				num = (short)866779137;
				if (num != 0)
				{
				}
				((global::System.IDisposable)enumerator).Dispose();
			}
			num = (short)330432512;
			short num4 = num;
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00009F90 File Offset: 0x00008190
		private void a(global::Common.Communication.Simulator.LESystemDevicesInfo A_0)
		{
			short num;
			using (global::System.Collections.Generic.List<string>.Enumerator enumerator = A_0.DeviceIdList.GetEnumerator())
			{
				num = (short)1460994050;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)1210843139;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)158332006;
						short num3 = num;
						num = (short)310375526;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
						{
							num = (short)1477705728;
							if (num != 0)
							{
							}
							num = (short)340983809;
							if (num != 0)
							{
							}
							string serialNumber = enumerator.Current;
							global::Motorola.Common.Communication.CommonUtil.SingletonBase<global::Common.Communication.Simulator.VirtualDeviceDetector>.Instance().DetachDevice(global::Motorola.Common.Communication.CommonUtil.ConnectionType.LENetwork, serialNumber);
							num = (short)1087569924;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 1:
						goto IL_146;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_47;
						}
						continue;
					case 3:
						num = (short)1703084033;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_ED:
					num = (short)1690697728;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_47:
					goto IL_ED;
				}
				IL_146:;
			}
			num = (short)1467809792;
			short num4 = num;
		}

		// Token: 0x06000087 RID: 135 RVA: 0x0000A138 File Offset: 0x00008338
		public bool CloseVirtualLE(global::Motorola.Common.Communication.CommonUtil.PCRIPSystemInfo leInfo)
		{
			short num = (short)1481506817;
			if (num != 0)
			{
			}
			num = (short)1114570752;
			short num2 = num;
			num = (short)1888157696;
			int num3 = (int)num;
			switch (num3)
			{
			default:
			{
				bool result = false;
				object obj = global::Common.Communication.Simulator.VirtualLeManager.b;
				bool flag = false;
				try
				{
					switch (0)
					{
					case 0:
						goto IL_9B;
					}
					for (;;)
					{
						IL_84:
						switch (num3)
						{
						case 0:
							for (;;)
							{
								global::System.Collections.Generic.List<global::Common.Communication.Simulator.LESystemDevicesInfo>.Enumerator enumerator = this.c.LESysDeviceList.GetEnumerator();
								num = (short)733823367;
								short num4 = num;
								num = (short)1662206343;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									goto IL_120;
								}
							}
							IL_120:
							num = (short)185335808;
							if (num != 0)
							{
							}
							num = (short)1978728450;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_2B0;
						case 2:
							try
							{
								num = (short)1632763908;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num3)
									{
									case 0:
										goto IL_285;
									case 1:
										goto IL_201;
									case 2:
										if (leInfo == a2.a.LESystem)
										{
											num = (short)1929838597;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									case 3:
										num = (short)1959395328;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 4:
										switch (0)
										{
										case 0:
											goto IL_192;
										}
										continue;
									case 5:
										result = true;
										global::System.Threading.Tasks.Task.Factory.StartNew(new global::System.Action(a2.c));
										num = (short)834535425;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 6:
									{
										global::System.Collections.Generic.List<global::Common.Communication.Simulator.LESystemDevicesInfo>.Enumerator enumerator;
										if (!enumerator.MoveNext())
										{
											num = (short)1562181635;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::Common.Communication.Simulator.LESystemDevicesInfo a = enumerator.Current;
										num = (short)1662124034;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									}
									IL_194:
									num = (short)1878130694;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_192:
									goto IL_194;
								}
								IL_201:
								IL_285:
								return result;
							}
							finally
							{
								global::System.Collections.Generic.List<global::Common.Communication.Simulator.LESystemDevicesInfo>.Enumerator enumerator;
								((global::System.IDisposable)enumerator).Dispose();
							}
							goto IL_298;
						case 3:
							if (this.c != null)
							{
								num = (short)1890582528;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_298;
						}
						goto IL_9B;
						IL_298:
						num = (short)1002897409;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_2B0:
					return result;
					IL_9B:
					global::System.Threading.Monitor.Enter(obj, ref flag);
					num = (short)2009333763;
					num3 = (int)((global::System.IntPtr)num);
					goto IL_84;
				}
				finally
				{
					num = (short)1504247810;
					num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							goto IL_31C;
						case 1:
							global::System.Threading.Monitor.Exit(obj);
							num = (short)2132017152;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_2E5;
							}
							continue;
						}
						IL_2E5:
						if (!flag)
						{
							break;
						}
						num = (short)1480982529;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_31C:;
				}
				return result;
			}
			}
		}

		// Token: 0x06000088 RID: 136 RVA: 0x0000A49C File Offset: 0x0000869C
		private static bool a(global::Motorola.Common.Communication.CommonUtil.PCRIPSystemInfo A_0, global::Motorola.Common.Communication.CommonUtil.PCRIPSystemInfo A_1)
		{
			short num = (short)1999765514;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				int num4;
				switch (num2)
				{
				case 0:
				{
					if (A_0.LocalType != A_1.LocalType)
					{
						num = (short)878247948;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1628792687;
					short num3 = num;
					num = (short)197617519;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return false;
					default:
						num = (short)1818689536;
						if (num != 0)
						{
						}
						num = (short)1911029764;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					return false;
				case 2:
					if (num4 >= A_0.AuthenticationKey.Length)
					{
						num = (short)1178927109;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)909246475;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					return false;
				case 4:
					if (A_0.RemoteHostNameOrAddress != A_1.RemoteHostNameOrAddress)
					{
						num = (short)1099169800;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)135528455;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					num = (short)1953955840;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					goto IL_2D8;
				case 7:
					if (A_0.RemotePort != A_1.RemotePort)
					{
						num = (short)1762263041;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)999227401;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					return false;
				case 9:
					if (A_0.SystemAlias != A_1.SystemAlias)
					{
						num = (short)610664451;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 10:
					switch (0)
					{
					case 0:
						goto IL_66;
					}
					continue;
				case 11:
					num = (short)217317377;
					if (num != 0)
					{
					}
					if (A_0.AuthenticationKey[num4] != A_1.AuthenticationKey[num4])
					{
						num = (short)1175322639;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num4++;
					num = (short)1643315214;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					return false;
				case 13:
					return false;
				case 14:
					goto IL_2D8;
				case 15:
					goto IL_102;
				}
				IL_66:
				if (A_0.AuthenticationKey.Length != A_1.AuthenticationKey.Length)
				{
					num = (short)378273805;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num4 = 0;
				num = (short)1387397126;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2D8:
				num = (short)128122882;
				num2 = (int)((global::System.IntPtr)num);
			}
			return false;
			IL_102:
			num = (short)2093940736;
			short num5 = num;
			return false;
		}

		// Token: 0x06000089 RID: 137 RVA: 0x0000A7C8 File Offset: 0x000089C8
		public bool OpenVirtualLE(global::Motorola.Common.Communication.CommonUtil.PCRIPSystemInfo leInfo)
		{
			short num = (short)167182336;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				bool result = false;
				object obj = global::Common.Communication.Simulator.VirtualLeManager.b;
				bool flag = false;
				try
				{
					switch (0)
					{
					case 0:
						goto IL_4B;
					}
					for (;;)
					{
						IL_34:
						switch (num2)
						{
						case 0:
							for (;;)
							{
								global::System.Collections.Generic.List<global::Common.Communication.Simulator.LESystemDevicesInfo>.Enumerator enumerator = this.c.LESysDeviceList.GetEnumerator();
								num = (short)1668745887;
								short num3 = num;
								num = (short)80939679;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									goto IL_D3;
								}
							}
							IL_D3:
							num = (short)625803264;
							if (num != 0)
							{
							}
							num = (short)1843331074;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_265;
						case 2:
							try
							{
								num = (short)140640260;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										goto IL_238;
									case 1:
										goto IL_1B1;
									case 2:
										if (global::Common.Communication.Simulator.VirtualLeManager.a(leInfo, b.a.LESystem))
										{
											num = (short)1960443909;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									case 3:
										num = (short)1853947904;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 4:
										switch (0)
										{
										case 0:
											goto IL_144;
										}
										continue;
									case 5:
										result = true;
										global::System.Threading.Tasks.Task.Factory.StartNew(new global::System.Action(b.c));
										num = (short)523501569;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 6:
									{
										global::System.Collections.Generic.List<global::Common.Communication.Simulator.LESystemDevicesInfo>.Enumerator enumerator;
										if (!enumerator.MoveNext())
										{
											num = (short)1915355139;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::Common.Communication.Simulator.LESystemDevicesInfo a = enumerator.Current;
										num = (short)1124270082;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									}
									IL_146:
									num = (short)1893597190;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_144:
									goto IL_146;
								}
								IL_1B1:
								IL_238:
								goto IL_2FA;
							}
							finally
							{
								global::System.Collections.Generic.List<global::Common.Communication.Simulator.LESystemDevicesInfo>.Enumerator enumerator;
								((global::System.IDisposable)enumerator).Dispose();
							}
							goto IL_24B;
						case 3:
							if (this.c != null)
							{
								num = (short)826540032;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_24B;
						}
						goto IL_4B;
						IL_24B:
						num = (short)1077870593;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_265:
					num = (short)1084620801;
					if (num != 0)
					{
					}
					goto IL_2FA;
					IL_4B:
					global::System.Threading.Monitor.Enter(obj, ref flag);
					num = (short)786825219;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_34;
				}
				finally
				{
					num = (short)942211074;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_2F7;
						case 1:
							global::System.Threading.Monitor.Exit(obj);
							num = (short)685178880;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_2C1;
							}
							continue;
						}
						IL_2C1:
						if (!flag)
						{
							break;
						}
						num = (short)1542914049;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_2F7:;
				}
				IL_2FA:
				num = (short)1590624256;
				short num4 = num;
				return result;
			}
			}
		}

		// Token: 0x0600008A RID: 138 RVA: 0x0000AB30 File Offset: 0x00008D30
		// Note: this type is marked as 'beforefieldinit'.
		static VirtualLeManager()
		{
			short num = (short)1916625264;
			short num2 = num;
			num = (short)1317691760;
			switch (num2 == num)
			{
			}
			num = (short)100335616;
			short num3 = num;
			num = (short)1703542784;
			if (num != 0)
			{
			}
			num = (short)153616385;
			if (num != 0)
			{
			}
			global::Common.Communication.Simulator.VirtualLeManager.a = null;
			global::Common.Communication.Simulator.VirtualLeManager.b = new object();
		}

		// Token: 0x0400001E RID: 30
		private static global::Common.Communication.Simulator.VirtualLeManager a;

		// Token: 0x0400001F RID: 31
		private static object b;

		// Token: 0x04000020 RID: 32
		private global::Common.Communication.Simulator.VirtualLEDevices c;

		// Token: 0x0200000E RID: 14
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class a
		{
			// Token: 0x0600008C RID: 140 RVA: 0x0000AC04 File Offset: 0x00008E04
			internal void c()
			{
				short num = (short)1729219700;
				short num2 = num;
				num = (short)1103023220;
				switch (num2 == num)
				{
				}
				num = (short)1915879424;
				short num3 = num;
				num = (short)903741440;
				if (num != 0)
				{
				}
				num = (short)645660673;
				if (num != 0)
				{
				}
				this.b.a(this.a);
			}

			// Token: 0x04000021 RID: 33
			public global::Common.Communication.Simulator.LESystemDevicesInfo a;

			// Token: 0x04000022 RID: 34
			public global::Common.Communication.Simulator.VirtualLeManager b;
		}

		// Token: 0x0200000F RID: 15
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class b
		{
			// Token: 0x0600008E RID: 142 RVA: 0x0000ACD4 File Offset: 0x00008ED4
			internal void c()
			{
				short num = (short)1139109245;
				short num2 = num;
				num = (short)2048617853;
				switch (num2 == num)
				{
				}
				num = (short)1963917312;
				short num3 = num;
				num = (short)1783365632;
				if (num != 0)
				{
				}
				num = (short)297926657;
				if (num != 0)
				{
				}
				this.b.b(this.a);
			}

			// Token: 0x04000023 RID: 35
			public global::Common.Communication.Simulator.LESystemDevicesInfo a;

			// Token: 0x04000024 RID: 36
			public global::Common.Communication.Simulator.VirtualLeManager b;
		}
	}
}
