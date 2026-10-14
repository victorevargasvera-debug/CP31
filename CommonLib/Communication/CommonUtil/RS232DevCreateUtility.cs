using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Threading;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x0200009B RID: 155
	public class RS232DevCreateUtility
	{
		// Token: 0x06000400 RID: 1024 RVA: 0x000414A0 File Offset: 0x0003F6A0
		private RS232DevCreateUtility()
		{
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x06000401 RID: 1025 RVA: 0x000414CC File Offset: 0x0003F6CC
		public static global::Motorola.Common.Communication.CommonUtil.RS232DevCreateUtility Instance
		{
			get
			{
				short num = (short)2080374786;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_C9;
					case 1:
					{
						num = (short)1240793089;
						if (num != 0)
						{
						}
						num = (short)354811904;
						short num3 = num;
						global::Motorola.Common.Communication.CommonUtil.RS232DevCreateUtility.c = new global::Motorola.Common.Communication.CommonUtil.RS232DevCreateUtility();
						num = (short)1729298432;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						switch (0)
						{
						case 0:
							goto IL_30;
						}
						continue;
					}
					goto IL_30;
					IL_3A:
					num = (short)485883905;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_C9:
					num = (short)1736953210;
					short num4 = num;
					num = (short)1100139898;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_3A;
					default:
						goto IL_FE;
					}
					IL_30:
					if (global::Motorola.Common.Communication.CommonUtil.RS232DevCreateUtility.c == null)
					{
						goto IL_3A;
					}
					goto IL_C9;
				}
				IL_FE:
				num = (short)1785790464;
				if (num != 0)
				{
				}
				return global::Motorola.Common.Communication.CommonUtil.RS232DevCreateUtility.c;
			}
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x000415F4 File Offset: 0x0003F7F4
		public bool CloseOpeningRS232Port(string portName)
		{
			short num = (short)1445265409;
			if (num != 0)
			{
			}
			num = (short)554893312;
			short num2 = num;
			num = (short)699269120;
			switch (num)
			{
			default:
			{
				num = (short)1734934529;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.IO.Ports.SerialPort serialPort;
					bool result;
					switch (num3)
					{
					case 0:
						goto IL_139;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_A7;
						}
						continue;
					case 2:
						try
						{
							serialPort.Close();
							return true;
						}
						catch (global::System.Exception)
						{
							return false;
						}
						goto Block_4;
					case 3:
						if (serialPort != null)
						{
							num = (short)1505165314;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 4:
						return false;
					}
					IL_A7:
					if (string.IsNullOrEmpty(portName))
					{
						num = (short)1698103300;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					result = false;
					serialPort = null;
					global::System.Collections.Generic.Dictionary<string, global::System.IO.Ports.SerialPort> obj = this.a;
					bool flag = false;
					num = (short)665124864;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					Block_4:
					try
					{
						IL_139:
						global::System.Threading.Monitor.Enter(obj, ref flag);
						this.a.TryGetValue(portName, out serialPort);
						goto IL_C7;
					}
					finally
					{
						num = (short)553385986;
						num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
								goto IL_1C1;
							case 1:
								global::System.Threading.Monitor.Exit(obj);
								num = (short)1130627072;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_188;
								}
								continue;
							}
							goto IL_188;
							IL_18B:
							num = (short)924057601;
							num3 = (int)((global::System.IntPtr)num);
							continue;
							IL_1C1:
							num = (short)1394572782;
							short num4 = num;
							num = (short)811302382;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_18B;
							default:
								goto IL_1F5;
							}
							IL_188:
							if (flag)
							{
								goto IL_18B;
							}
							goto IL_1C1;
						}
						IL_1F5:
						num = (short)1619132416;
						if (num != 0)
						{
						}
					}
					return result;
					IL_C7:
					num = (short)832634883;
					num3 = (int)((global::System.IntPtr)num);
				}
				return false;
			}
			}
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x0004182C File Offset: 0x0003FA2C
		public void AddOpeningRS232Port(string portName, global::System.IO.Ports.SerialPort portInstance)
		{
			short num = (short)1058603009;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::System.Collections.Generic.Dictionary<string, global::System.IO.Ports.SerialPort> obj;
				bool flag;
				switch (num2)
				{
				case 0:
					if (portInstance == null)
					{
						num = (short)1219756035;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1B1;
				case 1:
				{
					num = (short)18848294;
					short num3 = num;
					num = (short)979802662;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1926627328;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_83;
						}
						continue;
					}
					break;
				}
				case 2:
					num = (short)2076442624;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_232;
				case 4:
					num = (short)885981185;
					if (num != 0)
					{
					}
					try
					{
						switch (0)
						{
						case 0:
							goto IL_C7;
						}
						for (;;)
						{
							IL_B1:
							switch (num2)
							{
							case 0:
								goto IL_143;
							case 1:
								if (!this.a.ContainsKey(portName))
								{
									num = (short)676462595;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_12C;
							case 2:
								goto IL_12C;
							case 3:
								this.a.Add(portName, portInstance);
								num = (short)1648558082;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_C7;
							IL_12C:
							num = (short)1045299200;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_143:
						return;
						IL_C7:
						global::System.Threading.Monitor.Enter(obj, ref flag);
						num = (short)1516699649;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_B1;
					}
					finally
					{
						num = (short)359464960;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_178;
								}
								continue;
							case 1:
								goto IL_1AE;
							case 2:
								global::System.Threading.Monitor.Exit(obj);
								num = (short)1174405121;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_178:
							if (!flag)
							{
								break;
							}
							num = (short)1637810178;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_1AE:;
					}
					goto IL_1B1;
				}
				IL_83:
				if (!string.IsNullOrEmpty(portName))
				{
					num = (short)1939996674;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_1B1:
				obj = this.a;
				flag = false;
				num = (short)2090008580;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_232:
			num = (short)1683947520;
			short num4 = num;
		}

		// Token: 0x06000404 RID: 1028 RVA: 0x00041AA8 File Offset: 0x0003FCA8
		public void RemoveOpeningRS232Port(string portName)
		{
			short num = (short)1635385344;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::System.Collections.Generic.Dictionary<string, global::System.IO.Ports.SerialPort> obj;
				bool flag;
				switch (num2)
				{
				case 0:
				{
					num = (short)1330446336;
					short num3 = num;
					switch (0)
					{
					case 0:
						goto IL_5B;
					}
					continue;
				}
				case 1:
					try
					{
						switch (0)
						{
						case 0:
							goto IL_C9;
						}
						for (;;)
						{
							IL_B3:
							switch (num2)
							{
							case 0:
								goto IL_146;
							case 1:
								if (this.a.ContainsKey(portName))
								{
									num = (short)152502275;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_12E;
							case 2:
								goto IL_12E;
							case 3:
								this.a.Remove(portName);
								num = (short)1640759298;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_C9;
							IL_12E:
							num = (short)1589182464;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_146:
						goto IL_1D9;
						IL_C9:
						global::System.Threading.Monitor.Enter(obj, ref flag);
						num = (short)1743323137;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_B3;
					}
					finally
					{
						num = (short)693960704;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_17B;
								}
								continue;
							case 1:
								goto IL_1AF;
							case 2:
								global::System.Threading.Monitor.Exit(obj);
								num = (short)1866924033;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_17B:
							if (!flag)
							{
								break;
							}
							num = (short)1719664642;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_1AF:;
					}
					goto IL_1B2;
				case 2:
					return;
				}
				IL_5B:
				num = (short)624623617;
				if (num != 0)
				{
				}
				if (string.IsNullOrEmpty(portName))
				{
					num = (short)1354498050;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_1B2:
				obj = this.a;
				flag = false;
				num = (short)1095434241;
				num2 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_1D9:
			num = (short)1011902829;
			short num4 = num;
			num = (short)2049927533;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				return;
			default:
				num = (short)1191706624;
				if (num != 0)
				{
				}
				return;
			}
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x06000405 RID: 1029 RVA: 0x00041CE8 File Offset: 0x0003FEE8
		public global::System.Collections.Generic.Dictionary<string, global::Motorola.Common.Communication.CommonUtil.RS232DeviceCreateStatus> RS232DevCreateStatusDic
		{
			get
			{
				short num = (short)1551606407;
				short num2 = num;
				num = (short)1727636103;
				switch (num2 == num)
				{
				}
				num = (short)66650113;
				if (num != 0)
				{
				}
				num = (short)836370432;
				short num3 = num;
				num = (short)1803288576;
				if (num != 0)
				{
				}
				return this.b;
			}
		}

		// Token: 0x06000406 RID: 1030 RVA: 0x00041D9C File Offset: 0x0003FF9C
		public void UpdateRS232DevCreateStatus(string portPlusTimeStamp, global::Motorola.Common.Communication.CommonUtil.RS232DeviceCreateStatus status)
		{
			short num = (short)984088577;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_114;
				case 1:
				{
					num = (short)220528640;
					short num3 = num;
					num = (short)1562799393;
					short num4 = num;
					num = (short)1775856929;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_DC;
					default:
						num = (short)1550057472;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_AF;
						}
						continue;
					}
					break;
				}
				case 2:
					if (this.b.ContainsKey(portPlusTimeStamp))
					{
						num = (short)426967040;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_13D;
				case 3:
					return;
				}
				IL_AF:
				if (string.IsNullOrEmpty(portPlusTimeStamp))
				{
					num = (short)8060931;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_DC:
				num = (short)1287454722;
				num2 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_114:
			num = (short)784138241;
			if (num != 0)
			{
			}
			this.b[portPlusTimeStamp] = status;
			return;
			IL_13D:
			this.b.Add(portPlusTimeStamp, status);
		}

		// Token: 0x06000407 RID: 1031 RVA: 0x00041EF4 File Offset: 0x000400F4
		public global::Motorola.Common.Communication.CommonUtil.RS232DeviceCreateStatus GetRS232DevCreateStatus(string portPlusTimeStamp)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			short num2;
			global::Motorola.Common.Communication.CommonUtil.RS232DeviceCreateStatus result;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2 = (short)1875247105;
					if (num2 != 0)
					{
					}
					if (this.b.ContainsKey(portPlusTimeStamp))
					{
						num2 = (short)499974147;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 1:
					if (string.IsNullOrEmpty(portPlusTimeStamp))
					{
						num2 = (short)1663238146;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)473694208;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					return result;
				case 3:
				{
					num2 = (short)1634074624;
					short num3 = num2;
					result = this.b[portPlusTimeStamp];
					num2 = (short)1872691204;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 4:
				{
					num2 = (short)931758323;
					short num4 = num2;
					num2 = (short)1084326131;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						goto IL_E1;
					}
					break;
				}
				}
				goto IL_24;
			}
			return result;
			IL_E1:
			num2 = (short)1007878144;
			if (num2 != 0)
			{
			}
			return result;
			IL_24:
			result = global::Motorola.Common.Communication.CommonUtil.RS232DeviceCreateStatus.UN_DEFINED;
			num2 = (short)2081619969;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000408 RID: 1032 RVA: 0x00042068 File Offset: 0x00040268
		public void RemoveRS232DevCreateStatus(string portPlusTimeStamp)
		{
			short num = (short)1891958785;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)77332481;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
					if (this.b.ContainsKey(portPlusTimeStamp))
					{
						num = (short)873267203;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 1:
				{
					num = (short)504206594;
					short num3 = num;
					num = (short)1646302466;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)180355072;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_AC;
						}
						continue;
					}
					break;
				}
				case 2:
					goto IL_C8;
				case 3:
					this.b.Remove(portPlusTimeStamp);
					num = (short)838270980;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					return;
				}
				IL_AC:
				if (string.IsNullOrEmpty(portPlusTimeStamp))
				{
					num = (short)753205250;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)208470016;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_C8:
			num = (short)1061552128;
			short num4 = num;
		}

		// Token: 0x040004B3 RID: 1203
		private global::System.Collections.Generic.Dictionary<string, global::System.IO.Ports.SerialPort> a = new global::System.Collections.Generic.Dictionary<string, global::System.IO.Ports.SerialPort>();

		// Token: 0x040004B4 RID: 1204
		private global::System.Collections.Generic.Dictionary<string, global::Motorola.Common.Communication.CommonUtil.RS232DeviceCreateStatus> b = new global::System.Collections.Generic.Dictionary<string, global::Motorola.Common.Communication.CommonUtil.RS232DeviceCreateStatus>();

		// Token: 0x040004B5 RID: 1205
		private static global::Motorola.Common.Communication.CommonUtil.RS232DevCreateUtility c;
	}
}
