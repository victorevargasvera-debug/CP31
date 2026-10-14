using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.Pba;

namespace Common.Communication.Simulator
{
	// Token: 0x02000009 RID: 9
	public class VirtualDeviceManager
	{
		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000071 RID: 113 RVA: 0x00008608 File Offset: 0x00006808
		public static global::Common.Communication.Simulator.VirtualDeviceManager Instance
		{
			get
			{
				short num = (short)1912668160;
				short num2 = num;
				object obj = global::Common.Communication.Simulator.VirtualDeviceManager.b;
				bool flag = false;
				try
				{
					switch (0)
					{
					case 0:
						goto IL_53;
					}
					int num3;
					for (;;)
					{
						IL_3D:
						switch (num3)
						{
						case 0:
							goto IL_FD;
						case 1:
						{
							num = (short)339301153;
							short num4 = num;
							num = (short)502158113;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_115;
							default:
								num = (short)818216960;
								if (num != 0)
								{
								}
								global::Common.Communication.Simulator.VirtualDeviceManager.a = new global::Common.Communication.Simulator.VirtualDeviceManager();
								num = (short)1689845760;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 2:
							if (global::Common.Communication.Simulator.VirtualDeviceManager.a == null)
							{
								num = (short)648282113;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_FD;
						case 3:
							goto IL_115;
						}
						goto IL_53;
						IL_FD:
						num = (short)877068291;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_115:
					goto IL_1AA;
					IL_53:
					global::System.Threading.Monitor.Enter(obj, ref flag);
					num = (short)1761345538;
					num3 = (int)((global::System.IntPtr)num);
					goto IL_3D;
				}
				finally
				{
					num = (short)243859457;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							global::System.Threading.Monitor.Exit(obj);
							num = (short)44630018;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_14A;
							}
							continue;
						case 2:
							goto IL_17F;
						}
						IL_14A:
						if (!flag)
						{
							break;
						}
						num = (short)1388118016;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_17F:
					num = (short)165675009;
					if (num != 0)
					{
					}
				}
				IL_1AA:
				return global::Common.Communication.Simulator.VirtualDeviceManager.a;
			}
		}

		// Token: 0x06000072 RID: 114 RVA: 0x000087D4 File Offset: 0x000069D4
		private static string b()
		{
			int a_ = 3;
			switch (0)
			{
			case 0:
				goto IL_9A;
			}
			short num;
			int num3;
			string result;
			for (;;)
			{
				IL_13:
				num = (short)1111624467;
				short num2 = num;
				num = (short)1009257235;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)548143105;
					if (num != 0)
					{
					}
					num = (short)785317888;
					if (num != 0)
					{
					}
					switch (num3)
					{
					case 0:
						return result;
					case 1:
						result = global::System.IO.Path.GetDirectoryName(global::System.Reflection.Assembly.GetExecutingAssembly().Location) + global::Common.Communication.Simulator.VirtualLEDevices.b("ṁቃ⽅㩇㹉㥋⽍㱏Q㕓㉕ㅗ㕙⽛ɝ⑟ݡባཥ୧ཀྵ㡫᝭o᝱㡳ή୷๹剻ٽ", a_);
						num = (short)1059520515;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						num = (short)213843968;
						short num4 = num;
						if (global::System.Reflection.Assembly.GetEntryAssembly() == null)
						{
							num = (short)1158807553;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						result = global::Common.Communication.Simulator.VRDefinitions.VirtualDeviceFolder + global::Common.Communication.Simulator.VirtualLEDevices.b("ṁC⍅㹇⍉⽋⭍я⭑⑓㍕ᑗ㍙⽛⩝也ᩡॣ੥", a_);
						goto IL_11F;
					}
					case 3:
						return result;
					}
					goto IL_9A;
				}
				IL_11F:
				num = (short)336527360;
				num3 = (int)((global::System.IntPtr)num);
			}
			return result;
			IL_9A:
			result = string.Empty;
			num = (short)706543618;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_13;
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00008958 File Offset: 0x00006B58
		private VirtualDeviceManager()
		{
			this.c = new global::System.Collections.Generic.Dictionary<global::Motorola.Common.Communication.CommonUtil.ConnectionType, global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.DeviceInfo, global::Motorola.Common.Communication.Pba.PbaObject>>>
			{
				{
					global::Motorola.Common.Communication.CommonUtil.ConnectionType.LENetwork,
					new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.DeviceInfo, global::Motorola.Common.Communication.Pba.PbaObject>>()
				},
				{
					global::Motorola.Common.Communication.CommonUtil.ConnectionType.Otap,
					new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.DeviceInfo, global::Motorola.Common.Communication.Pba.PbaObject>>()
				}
			};
			this.d = null;
			this.a();
		}

		// Token: 0x06000074 RID: 116 RVA: 0x0000899C File Offset: 0x00006B9C
		private void a()
		{
			int a_ = 6;
			short num;
			try
			{
				num = (short)68824730;
				short num2 = num;
				num = (short)857157274;
				switch (num2 == num)
				{
				}
				num = (short)878510081;
				if (num != 0)
				{
				}
				num = (short)2070020096;
				if (num != 0)
				{
				}
				this.d = global::Common.Communication.Simulator.DeviceTypeMap.LoadFromFile();
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(global::Common.Communication.Simulator.VirtualLEDevices.b("̈́♆⁈❊⡌⭎煐❒㩔睖㕘㑚㱜㭞䅠ݢdᅦhࡪ࡬佮ᱰቲմ坶ᕸቺ๼୾궀ꎂﮈﾌ떎놐ꖔ", a_), new object[]
				{
					ex.Message
				});
			}
			num = (short)579469312;
			short num3 = num;
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00008A98 File Offset: 0x00006C98
		public global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.DeviceInfo, global::Motorola.Common.Communication.Pba.PbaObject>> GetBufferedDevices(global::Motorola.Common.Communication.CommonUtil.ConnectionType connType, string serialNumber)
		{
			short num = (short)1243283457;
			if (num != 0)
			{
			}
			num = (short)460849152;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)1787428864;
				short num3 = num;
				global::Common.Communication.Simulator.VirtualDeviceManager.a a = new global::Common.Communication.Simulator.VirtualDeviceManager.a();
				a.a = serialNumber;
				global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.DeviceInfo, global::Motorola.Common.Communication.Pba.PbaObject>> list = new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.DeviceInfo, global::Motorola.Common.Communication.Pba.PbaObject>>();
				object obj = global::Common.Communication.Simulator.VirtualDeviceManager.b;
				bool flag = false;
				try
				{
					switch (0)
					{
					case 0:
						goto IL_AB;
					}
					for (;;)
					{
						IL_94:
						switch (num2)
						{
						case 0:
							try
							{
								num = (short)1232928771;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
									{
										global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.DeviceInfo, global::Motorola.Common.Communication.Pba.PbaObject>> enumerator;
										if (!enumerator.MoveNext())
										{
											num = (short)895156226;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.DeviceInfo, global::Motorola.Common.Communication.Pba.PbaObject> item = enumerator.Current;
										list.Add(item);
										num = (short)1292828673;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 2:
										num = (short)171966468;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 3:
										switch (0)
										{
										case 0:
											goto IL_1B5;
										}
										continue;
									case 4:
										goto IL_232;
									}
									IL_1B7:
									num = (short)1296695296;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_1B5:
									goto IL_1B7;
								}
								IL_232:
								return list;
							}
							finally
							{
								num = (short)400556033;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.DeviceInfo, global::Motorola.Common.Communication.Pba.PbaObject>> enumerator;
									switch (num2)
									{
									case 0:
										enumerator.Dispose();
										num = (short)427622402;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_26A;
										}
										continue;
									case 2:
										goto IL_2A2;
									}
									IL_26A:
									if (enumerator == null)
									{
										break;
									}
									num = (short)1908998144;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_2A2:;
							}
							goto IL_2A5;
						case 1:
						{
							num = (short)1432848640;
							short num4 = num;
							num = (short)588155136;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_2BE;
							default:
							{
								num = (short)1674117120;
								if (num != 0)
								{
								}
								global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.DeviceInfo, global::Motorola.Common.Communication.Pba.PbaObject>> enumerator = this.c[connType].Where(new global::System.Func<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.DeviceInfo, global::Motorola.Common.Communication.Pba.PbaObject>, bool>(a.b)).GetEnumerator();
								num = (short)2141978624;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							break;
						}
						case 2:
							if (this.c.ContainsKey(connType))
							{
								num = (short)843120641;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2A5;
						case 3:
							goto IL_2BE;
						}
						goto IL_AB;
						IL_2A5:
						num = (short)1548812291;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_2BE:
					return list;
					IL_AB:
					global::System.Threading.Monitor.Enter(obj, ref flag);
					num = (short)1134362626;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_94;
				}
				finally
				{
					num = (short)305922049;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							global::System.Threading.Monitor.Exit(obj);
							num = (short)477036546;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_2F2;
							}
							continue;
						case 2:
							goto IL_328;
						}
						IL_2F2:
						if (!flag)
						{
							break;
						}
						num = (short)1608056832;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_328:;
				}
				return list;
			}
			}
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00008E08 File Offset: 0x00007008
		public void DetachDevice(global::Motorola.Common.Communication.CommonUtil.ConnectionType connType, string serialNumber)
		{
			short num = (short)1042315005;
			short num2 = num;
			num = (short)857831165;
			switch (num2 == num)
			{
			default:
			{
				num = (short)915472384;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1579352065;
			if (num != 0)
			{
			}
			num = (short)545587200;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00008EB0 File Offset: 0x000070B0
		public void CorrectAndBufferDevice(global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.DeviceInfo, global::Motorola.Common.Communication.Pba.PbaObject> device)
		{
			short num = (short)1561853954;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (this.c.ContainsKey(device.Key.ConnectionInfo.ConnectionType))
					{
						num = (short)1892089859;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 1:
					goto IL_90;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_44;
					}
					continue;
				case 3:
					this.c[device.Key.ConnectionInfo.ConnectionType].Add(device);
					num = (short)1516371973;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					if (this.d.DeviceTypeList.ContainsKey(device.Key.SerialNumber))
					{
						num = (short)1029767175;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_90;
				case 5:
				{
					num = (short)2124631525;
					short num3 = num;
					num = (short)1087983077;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_14A;
					default:
						goto IL_1D5;
					}
					break;
				}
				case 6:
					goto IL_64;
				case 7:
				{
					num = (short)174522368;
					short num4 = num;
					device.Key.ConnectionInfo.ConnectionType = this.d.DeviceTypeList[device.Key.SerialNumber].ConnType;
					device.Key.RadioID = this.d.DeviceTypeList[device.Key.SerialNumber].RadioID.ToString();
					goto IL_14A;
				}
				}
				IL_44:
				if (this.d == null)
				{
					num = (short)1139015686;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)293142532;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_90:
				num = (short)938672128;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_14A:
				num = (short)1088946177;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_64:
			num = (short)717750273;
			if (num != 0)
			{
			}
			return;
			IL_1D5:
			num = (short)1356791808;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000078 RID: 120 RVA: 0x0000912C File Offset: 0x0000732C
		// Note: this type is marked as 'beforefieldinit'.
		static VirtualDeviceManager()
		{
			short num = (short)561080546;
			short num2 = num;
			num = (short)134834402;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1180565504;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)74776576;
			if (num != 0)
			{
			}
			num = (short)1779564545;
			if (num != 0)
			{
			}
			global::Common.Communication.Simulator.VirtualDeviceManager.a = null;
			global::Common.Communication.Simulator.VirtualDeviceManager.b = new object();
		}

		// Token: 0x04000016 RID: 22
		private static global::Common.Communication.Simulator.VirtualDeviceManager a;

		// Token: 0x04000017 RID: 23
		private static object b;

		// Token: 0x04000018 RID: 24
		private global::System.Collections.Generic.Dictionary<global::Motorola.Common.Communication.CommonUtil.ConnectionType, global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.DeviceInfo, global::Motorola.Common.Communication.Pba.PbaObject>>> c;

		// Token: 0x04000019 RID: 25
		private global::Common.Communication.Simulator.DeviceTypeMap d;

		// Token: 0x0200000A RID: 10
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class a
		{
			// Token: 0x0600007A RID: 122 RVA: 0x000091F8 File Offset: 0x000073F8
			internal bool b(global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.DeviceInfo, global::Motorola.Common.Communication.Pba.PbaObject> A_0)
			{
				short num = (short)598684622;
				short num2 = num;
				num = (short)1788031950;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1418985472;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)165281793;
				if (num != 0)
				{
				}
				num = (short)1724710912;
				if (num != 0)
				{
				}
				return string.Equals(this.a, A_0.Key.SerialNumber, global::System.StringComparison.Ordinal);
			}

			// Token: 0x0400001A RID: 26
			public string a;
		}
	}
}
