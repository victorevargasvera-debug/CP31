using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using Motorola.Common.LogUtility;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x0200004F RID: 79
	public class WinAPIWrapper
	{
		// Token: 0x06000117 RID: 279 RVA: 0x0000E904 File Offset: 0x0000CB04
		public WinAPIWrapper(string logFileName)
		{
			this.a = logFileName;
		}

		// Token: 0x06000118 RID: 280 RVA: 0x0000E93C File Offset: 0x0000CB3C
		public WinAPIWrapper()
		{
		}

		// Token: 0x06000119 RID: 281 RVA: 0x0000E96C File Offset: 0x0000CB6C
		public static bool SetSockOpt(global::System.IntPtr s, int level, int optname, ref int optval)
		{
			short num;
			for (;;)
			{
				num = (short)791543808;
				short num2 = num;
				if (global::Motorola.Common.Communication.CommonUtil.NativeMethods.setsockopt(s, level, optname, ref optval, 4) != 0)
				{
					break;
				}
				num = (short)1561245043;
				short num3 = num;
				num = (short)96318835;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_9A;
				}
			}
			global::System.ComponentModel.Win32Exception ex = new global::System.ComponentModel.Win32Exception(global::System.Runtime.InteropServices.Marshal.GetLastWin32Error());
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("SetSockOpt last win32 error message is: " + ex.Message, global::System.Array.Empty<object>());
			return false;
			IL_9A:
			num = (short)1370161153;
			if (num != 0)
			{
			}
			num = (short)329252864;
			if (num != 0)
			{
			}
			return true;
		}

		// Token: 0x0600011A RID: 282 RVA: 0x0000EA50 File Offset: 0x0000CC50
		public bool WrapperSetupDiGetClassDevs(ref global::System.IntPtr hDevInfo, ref global::System.Guid classGuid, global::System.IntPtr enumerator)
		{
			short num = (short)1409613824;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_68;
				}
				int a_;
				bool result;
				for (;;)
				{
					IL_29:
					num = (short)1995309057;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						a_ = 18;
						num = (short)1215823875;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						try
						{
							num = (short)876044847;
							short num3 = num;
							num = (short)1694589487;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								IL_1CE:
								global::Motorola.Common.Communication.CommonUtil.TransportLogger.WriteInfo(this.a, this.b);
								num = (short)7864323;
								num2 = (int)((global::System.IntPtr)num);
								break;
							default:
								num = (short)241500160;
								if (num != 0)
								{
								}
								switch (0)
								{
								case 0:
									goto IL_125;
								}
								break;
							}
							int lastWin32Error;
							for (;;)
							{
								IL_102:
								switch (num2)
								{
								case 0:
									if (hDevInfo.ToInt64() == -1L)
									{
										num = (short)2075721733;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_218;
								case 1:
									goto IL_218;
								case 2:
									goto IL_1CE;
								case 3:
									goto IL_1D0;
								case 4:
									if (!string.IsNullOrEmpty(this.a))
									{
										num = (short)1611923458;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1D0;
								case 5:
								{
									global::System.ComponentModel.Win32Exception ex = new global::System.ComponentModel.Win32Exception(lastWin32Error);
									this.b = "SetupDiGetClassDevs last win32 error message is: " + ex.Message;
									num = (short)1055457284;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									goto IL_230;
								}
								goto IL_125;
								IL_1D0:
								result = false;
								num = (short)1022754817;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_218:
								num = (short)1209925638;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_230:
							return result;
							IL_125:
							hDevInfo = global::Motorola.Common.Communication.CommonUtil.NativeMethods.SetupDiGetClassDevs(ref classGuid, enumerator, global::System.IntPtr.Zero, a_);
							lastWin32Error = global::System.Runtime.InteropServices.Marshal.GetLastWin32Error();
							num = (short)1354366976;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_102;
						}
						catch (global::System.Exception ex2)
						{
							this.b = "Exception found when invoking---SetupDiGetClassDevs--- " + ex2.Message;
							if (!string.IsNullOrEmpty(this.a))
							{
								global::Motorola.Common.Communication.CommonUtil.TransportLogger.WriteInfo(this.a, this.b);
							}
							return false;
						}
						goto IL_274;
					case 2:
						if (enumerator == global::System.IntPtr.Zero)
						{
							num = (short)268042240;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_274;
					case 3:
					{
						num = (short)615055360;
						short num4 = num;
						goto IL_274;
					}
					}
					goto IL_68;
					IL_274:
					num = (short)1765212161;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_68:
				result = true;
				a_ = 2;
				num = (short)2134310914;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_29;
			}
			}
		}

		// Token: 0x0600011B RID: 283 RVA: 0x0000ED54 File Offset: 0x0000CF54
		public bool WrapperSetupDiDestroyDeviceInfoList(global::System.IntPtr hDevInfo)
		{
			short num = (short)260571136;
			short num2 = num;
			bool flag = true;
			try
			{
				num = (short)977395835;
				short num3 = num;
				num = (short)1253433467;
				int num4;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_13B:
					global::Motorola.Common.Communication.CommonUtil.TransportLogger.WriteInfo(this.a, this.b);
					num = (short)1671102467;
					num4 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)80084992;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_A5;
					}
					break;
				}
				for (;;)
				{
					IL_83:
					switch (num4)
					{
					case 0:
						if (!flag)
						{
							num = (short)1500839941;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1AA;
					case 1:
						goto IL_1AA;
					case 2:
						goto IL_13B;
					case 3:
						num = (short)1894842369;
						if (num != 0)
						{
						}
						goto IL_13D;
					case 4:
						if (!string.IsNullOrEmpty(this.a))
						{
							num = (short)524812290;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_13D;
					case 5:
					{
						global::System.ComponentModel.Win32Exception ex = new global::System.ComponentModel.Win32Exception(global::System.Runtime.InteropServices.Marshal.GetLastWin32Error());
						this.b = "SetupDiDestroyDeviceInfoList last win32 error message is: " + ex.Message;
						num = (short)654442500;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						goto IL_1C2;
					}
					goto IL_A5;
					IL_13D:
					flag = false;
					num = (short)660865025;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_1AA:
					num = (short)1880752134;
					num4 = (int)((global::System.IntPtr)num);
				}
				IL_1C2:
				return flag;
				IL_A5:
				flag = global::Motorola.Common.Communication.CommonUtil.NativeMethods.SetupDiDestroyDeviceInfoList(hDevInfo);
				num = (short)1361117184;
				num4 = (int)((global::System.IntPtr)num);
				goto IL_83;
			}
			catch (global::System.Exception ex2)
			{
				this.b = "Exception found when invoking---SetupDiDestroyDeviceInfoList--- " + ex2.Message;
				if (!string.IsNullOrEmpty(this.a))
				{
					global::Motorola.Common.Communication.CommonUtil.TransportLogger.WriteInfo(this.a, this.b);
				}
				flag = false;
			}
			return flag;
		}

		// Token: 0x0600011C RID: 284 RVA: 0x0000EF80 File Offset: 0x0000D180
		public bool WrapperSetupDiEnumDeviceInterfaces(global::System.IntPtr hDevInfo, uint index, ref global::Motorola.Common.Communication.CommonUtil.NativeMethods.SP_DEVICE_INTERFACE_DATA devInterfaceData, ref global::System.Guid classGuid)
		{
			short num = (short)1964703744;
			switch (num)
			{
			default:
			{
				num = (short)433455104;
				short num2 = num;
				num = (short)1514668033;
				if (num != 0)
				{
				}
				bool result = true;
				try
				{
					num = (short)40108034;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
						{
							num = (short)2107139491;
							short num4 = num;
							num = (short)232482211;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								continue;
							default:
							{
								num = (short)865533952;
								if (num != 0)
								{
								}
								int lastWin32Error = global::System.Runtime.InteropServices.Marshal.GetLastWin32Error();
								num = (short)121372679;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							break;
						}
						case 1:
							if (!string.IsNullOrEmpty(this.a))
							{
								num = (short)1496121349;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_178;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_C2;
							}
							continue;
						case 3:
							goto IL_223;
						case 4:
						{
							int lastWin32Error;
							global::System.ComponentModel.Win32Exception ex = new global::System.ComponentModel.Win32Exception(lastWin32Error);
							this.b = "SetupDiEnumDeviceInterfaces last win32 error message is: " + ex.Message;
							num = (short)1987117057;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 5:
							global::Motorola.Common.Communication.CommonUtil.TransportLogger.WriteInfo(this.a, this.b);
							num = (short)21889030;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							goto IL_178;
						case 7:
						{
							int lastWin32Error;
							if (lastWin32Error != 259)
							{
								num = (short)943587332;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_178;
						}
						case 8:
							goto IL_23D;
						}
						IL_C2:
						if (global::Motorola.Common.Communication.CommonUtil.NativeMethods.SetupDiEnumDeviceInterfaces(hDevInfo, global::System.IntPtr.Zero, ref classGuid, index, ref devInterfaceData) == 0U)
						{
							num = (short)1782120448;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_223;
						IL_178:
						result = false;
						num = (short)501415939;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_223:
						num = (short)1546059784;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_23D:;
				}
				catch (global::System.Exception ex2)
				{
					this.b = "Exception found when invoking---SetupDiEnumDeviceInterfaces--- " + ex2.Message;
					if (!string.IsNullOrEmpty(this.a))
					{
						global::Motorola.Common.Communication.CommonUtil.TransportLogger.WriteInfo(this.a, this.b);
					}
					result = false;
				}
				return result;
			}
			}
		}

		// Token: 0x0600011D RID: 285 RVA: 0x0000F228 File Offset: 0x0000D428
		public bool WrapperSetupDiGetDeviceInterfaceDetail(global::System.IntPtr hDevInfo, ref global::Motorola.Common.Communication.CommonUtil.NativeMethods.SP_DEVICE_INTERFACE_DATA devInterfaceData, global::System.IntPtr deviceInterfaceDetailData, uint deviceInterfaceDetailDataSize, out uint requiredSize, ref global::Motorola.Common.Communication.CommonUtil.NativeMethods.SP_DEVINFO_DATA devInfoData, out int errorCode)
		{
			short num = (short)692322305;
			if (num != 0)
			{
			}
			num = (short)371458048;
			short num2 = num;
			num = (short)403570688;
			int num3 = (int)num;
			switch (num3)
			{
			default:
			{
				bool flag = true;
				errorCode = 0;
				requiredSize = 0U;
				try
				{
					switch (0)
					{
					case 0:
						goto IL_B1;
					}
					for (;;)
					{
						IL_82:
						switch (num3)
						{
						case 0:
						{
							num = (short)1889981209;
							short num4 = num;
							num = (short)2043990809;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_D5;
							default:
							{
								num = (short)1471021056;
								if (num != 0)
								{
								}
								int lastWin32Error;
								global::System.ComponentModel.Win32Exception ex = new global::System.ComponentModel.Win32Exception(lastWin32Error);
								this.b = "SetupDiGetDeviceInterfaceDetail last win32 error message is: " + ex.Message;
								num = (short)417529864;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							break;
						}
						case 1:
						{
							int lastWin32Error;
							if (lastWin32Error != 122)
							{
								num = (short)1219231744;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							flag = true;
							num = (short)1704984580;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
						{
							int lastWin32Error = global::System.Runtime.InteropServices.Marshal.GetLastWin32Error();
							errorCode = lastWin32Error;
							num = (short)438501377;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
							goto IL_D5;
						case 4:
							goto IL_24F;
						case 5:
							goto IL_24F;
						case 6:
							goto IL_207;
						case 7:
							global::Motorola.Common.Communication.CommonUtil.TransportLogger.WriteInfo(this.a, this.b);
							num = (short)1789067270;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
							if (!string.IsNullOrEmpty(this.a))
							{
								num = (short)1770520583;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_207;
						case 9:
							goto IL_267;
						}
						goto IL_B1;
						IL_D5:
						if (!flag)
						{
							num = (short)1383530498;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_24F;
						IL_207:
						flag = false;
						num = (short)1585577989;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_24F:
						num = (short)785055753;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_267:
					return flag;
					IL_B1:
					flag = global::Motorola.Common.Communication.CommonUtil.NativeMethods.SetupDiGetDeviceInterfaceDetail(hDevInfo, ref devInterfaceData, deviceInterfaceDetailData, deviceInterfaceDetailDataSize, out requiredSize, ref devInfoData);
					num = (short)1584529411;
					num3 = (int)((global::System.IntPtr)num);
					goto IL_82;
				}
				catch (global::System.Exception ex2)
				{
					this.b = "Exception found when invoking---SetupDiGetDeviceInterfaceDetail--- " + ex2.Message;
					if (!string.IsNullOrEmpty(this.a))
					{
						global::Motorola.Common.Communication.CommonUtil.TransportLogger.WriteInfo(this.a, this.b);
					}
					errorCode = 0;
					flag = false;
				}
				return flag;
			}
			}
		}

		// Token: 0x0600011E RID: 286 RVA: 0x0000F4FC File Offset: 0x0000D6FC
		public bool WrapperSetupDiGetDeviceInstanceId(global::System.IntPtr hDevInfo, global::Motorola.Common.Communication.CommonUtil.NativeMethods.SP_DEVINFO_DATA devInfoData, ref string devIntanceID, int bufferSize)
		{
			short num = (short)2009661440;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)684851200;
				short num3 = num;
				num = (short)589692929;
				if (num != 0)
				{
				}
				bool flag = true;
				int num4 = 0;
				global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(bufferSize);
				try
				{
					num = (short)1792134170;
					short num5 = num;
					num = (short)628870170;
					switch ((num5 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_199:
						global::Motorola.Common.Communication.CommonUtil.TransportLogger.WriteInfo(this.a, this.b);
						num = (short)1866465283;
						num2 = (int)((global::System.IntPtr)num);
						break;
					default:
						num = (short)637927424;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_F7;
						}
						break;
					}
					for (;;)
					{
						IL_D4:
						switch (num2)
						{
						case 0:
							if (!flag)
							{
								num = (short)396689413;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1E3;
						case 1:
							goto IL_1E3;
						case 2:
							goto IL_199;
						case 3:
							goto IL_19B;
						case 4:
							if (!string.IsNullOrEmpty(this.a))
							{
								num = (short)1009451010;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_19B;
						case 5:
						{
							global::System.ComponentModel.Win32Exception ex = new global::System.ComponentModel.Win32Exception(global::System.Runtime.InteropServices.Marshal.GetLastWin32Error());
							this.b = "SetupDiGetDeviceInstanceId last win32 error message is: " + ex.Message;
							num = (short)888668164;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 6:
							goto IL_1FB;
						}
						goto IL_F7;
						IL_19B:
						flag = false;
						num = (short)134873089;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_1E3:
						num = (short)943718406;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_1FB:
					goto IL_23C;
					IL_F7:
					flag = global::Motorola.Common.Communication.CommonUtil.NativeMethods.SetupDiGetDeviceInstanceId(hDevInfo, ref devInfoData, stringBuilder, bufferSize, out num4);
					num = (short)1689583616;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_D4;
				}
				catch (global::System.Exception ex2)
				{
					this.b = "Exception found when invoking---SetupDiGetDeviceInstanceId--- " + ex2.Message;
					if (!string.IsNullOrEmpty(this.a))
					{
						global::Motorola.Common.Communication.CommonUtil.TransportLogger.WriteInfo(this.a, this.b);
					}
					flag = false;
				}
				IL_23C:
				devIntanceID = stringBuilder.ToString();
				return flag;
			}
			}
		}

		// Token: 0x0600011F RID: 287 RVA: 0x0000F76C File Offset: 0x0000D96C
		public bool Wrapper_CM_Get_Parent(uint devID, ref uint parentDevID)
		{
			short num = (short)1214578688;
			short num2 = num;
			bool result = true;
			int num3 = 0;
			try
			{
				num = (short)814011038;
				short num4 = num;
				num = (short)718131870;
				int num5;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_133:
					global::Motorola.Common.Communication.CommonUtil.TransportLogger.WriteInfo(this.a, this.b);
					num = (short)1815281667;
					num5 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)1684013056;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_A5;
					}
					break;
				}
				for (;;)
				{
					IL_83:
					switch (num5)
					{
					case 0:
						if (num3 != 0)
						{
							num = (short)423100421;
							num5 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_17A;
					case 1:
						goto IL_17A;
					case 2:
						goto IL_133;
					case 3:
						goto IL_135;
					case 4:
						if (!string.IsNullOrEmpty(this.a))
						{
							num = (short)2144927746;
							num5 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_135;
					case 5:
						this.b = "CM_Get_Parent last win32 error code is: " + num3.ToString();
						num = (short)1088159748;
						num5 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						goto IL_191;
					}
					goto IL_A5;
					IL_135:
					result = false;
					num = (short)1391853569;
					num5 = (int)((global::System.IntPtr)num);
					continue;
					IL_17A:
					num = (short)135331846;
					num5 = (int)((global::System.IntPtr)num);
				}
				IL_191:
				return result;
				IL_A5:
				num3 = global::Motorola.Common.Communication.CommonUtil.NativeMethods.CM_Get_Parent(out parentDevID, devID, 0);
				num = (short)718405632;
				num5 = (int)((global::System.IntPtr)num);
				goto IL_83;
			}
			catch (global::System.Exception ex)
			{
				this.b = "Exception found when invoking---CM_Get_Parent--- " + ex.Message;
				if (!string.IsNullOrEmpty(this.a))
				{
					num = (short)1507917825;
					if (num != 0)
					{
					}
					global::Motorola.Common.Communication.CommonUtil.TransportLogger.WriteInfo(this.a, this.b);
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06000120 RID: 288 RVA: 0x0000F990 File Offset: 0x0000DB90
		public bool Wrapper_CM_Get_Device_ID(uint devID, ref string instanceID)
		{
			short num = (short)1572536320;
			short num2 = num;
			num = (short)122770007;
			short num3 = num;
			num = (short)1729647191;
			bool flag;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1888616448;
				if (num != 0)
				{
				}
				num = (short)1181679616;
				int num4 = (int)num;
				switch (num4)
				{
				default:
				{
					num = (short)1971847169;
					if (num != 0)
					{
					}
					flag = true;
					int num5 = 0;
					global::System.IntPtr intPtr = global::System.Runtime.InteropServices.Marshal.AllocHGlobal(1024);
					instanceID = string.Empty;
					try
					{
						switch (0)
						{
						case 0:
							goto IL_FE;
						}
						for (;;)
						{
							IL_DB:
							switch (num4)
							{
							case 0:
								if (num5 != 0)
								{
									num = (short)893583365;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_1E0;
							case 1:
								goto IL_1E0;
							case 2:
								global::Motorola.Common.Communication.CommonUtil.TransportLogger.WriteInfo(this.a, this.b);
								num = (short)1269235715;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
								goto IL_198;
							case 4:
								if (!string.IsNullOrEmpty(this.a))
								{
									num = (short)217055234;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_198;
							case 5:
								this.b = "CM_Get_Device_ID last win32 error code is: " + num5.ToString();
								num = (short)448987140;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 6:
								goto IL_1F8;
							}
							goto IL_FE;
							IL_198:
							flag = false;
							num = (short)1900216321;
							num4 = (int)((global::System.IntPtr)num);
							continue;
							IL_1E0:
							num = (short)405929990;
							num4 = (int)((global::System.IntPtr)num);
						}
						IL_1F8:
						break;
						IL_FE:
						num5 = global::Motorola.Common.Communication.CommonUtil.NativeMethods.CM_Get_Device_ID(devID, intPtr, 1024, 0);
						num = (short)1984757760;
						num4 = (int)((global::System.IntPtr)num);
						goto IL_DB;
					}
					catch (global::System.Exception ex)
					{
						this.b = "Exception found when invoking---CM_Get_Device_ID--- " + ex.Message;
						if (!string.IsNullOrEmpty(this.a))
						{
							global::Motorola.Common.Communication.CommonUtil.TransportLogger.WriteInfo(this.a, this.b);
						}
						flag = false;
					}
					finally
					{
						num = (short)1284046848;
						num4 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num4)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_27C;
								}
								continue;
							case 1:
								instanceID = global::System.Runtime.InteropServices.Marshal.PtrToStringAuto(intPtr);
								num = (short)1591279619;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								if (intPtr != global::System.IntPtr.Zero)
								{
									num = (short)669843460;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_316;
							case 3:
								goto IL_2B6;
							case 4:
								global::System.Runtime.InteropServices.Marshal.FreeHGlobal(intPtr);
								num = (short)1476460549;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 5:
								goto IL_2B4;
							}
							IL_27C:
							if (flag)
							{
								num = (short)1806827521;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_2B6:
							num = (short)77529090;
							num4 = (int)((global::System.IntPtr)num);
						}
						IL_2B4:
						IL_316:;
					}
					break;
				}
				}
				break;
			}
			}
			return flag;
		}

		// Token: 0x06000121 RID: 289 RVA: 0x0000FCEC File Offset: 0x0000DEEC
		public bool WrapperSetupDiOpenDevRegKey(global::System.IntPtr hDevInfo, ref global::Motorola.Common.Communication.CommonUtil.NativeMethods.SP_DEVINFO_DATA devInfoData, ref global::System.IntPtr regKey)
		{
			short num = (short)1783496704;
			short num2 = num;
			num = (short)2026532025;
			short num3 = num;
			num = (short)1018850489;
			bool result;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1142489088;
				if (num != 0)
				{
				}
				num = (short)1089536000;
				int num4 = (int)num;
				switch (num4)
				{
				default:
				{
					result = true;
					int a_ = 131097;
					try
					{
						switch (0)
						{
						case 0:
							goto IL_C7;
						}
						int lastWin32Error;
						for (;;)
						{
							IL_A4:
							switch (num4)
							{
							case 0:
								if (regKey.ToInt64() == -1L)
								{
									num = (short)1755709441;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_1BB;
							case 1:
							{
								global::System.ComponentModel.Win32Exception ex = new global::System.ComponentModel.Win32Exception(lastWin32Error);
								this.b = "SetupDiOpenDevRegKey last win32 error message is: " + ex.Message;
								num = (short)811008006;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 2:
								goto IL_1D3;
							case 3:
								goto IL_1BB;
							case 4:
								global::Motorola.Common.Communication.CommonUtil.TransportLogger.WriteInfo(this.a, this.b);
								num = (short)1651507205;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 5:
								goto IL_172;
							case 6:
								if (!string.IsNullOrEmpty(this.a))
								{
									num = (short)595591172;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_172;
							}
							goto IL_C7;
							IL_172:
							result = false;
							num = (short)1900675075;
							num4 = (int)((global::System.IntPtr)num);
							continue;
							IL_1BB:
							num = (short)1814560770;
							num4 = (int)((global::System.IntPtr)num);
						}
						IL_1D3:
						break;
						IL_C7:
						regKey = global::Motorola.Common.Communication.CommonUtil.NativeMethods.SetupDiOpenDevRegKey(hDevInfo, ref devInfoData, 1, 0, 1, a_);
						lastWin32Error = global::System.Runtime.InteropServices.Marshal.GetLastWin32Error();
						num = (short)385089536;
						num4 = (int)((global::System.IntPtr)num);
						goto IL_A4;
					}
					catch (global::System.Exception ex2)
					{
						this.b = "Exception found when invoking---SetupDiOpenDevRegKey--- " + ex2.Message;
						if (!string.IsNullOrEmpty(this.a))
						{
							num = (short)2004353025;
							if (num != 0)
							{
							}
							global::Motorola.Common.Communication.CommonUtil.TransportLogger.WriteInfo(this.a, this.b);
						}
						result = false;
					}
					break;
				}
				}
				break;
			}
			}
			return result;
		}

		// Token: 0x06000122 RID: 290 RVA: 0x0000FF54 File Offset: 0x0000E154
		public bool WrapperSetupDiOpenDevRegKey(global::System.IntPtr hDevInfo, ref global::Motorola.Common.Communication.CommonUtil.NativeMethods.SP_DEVINFO_DATA devInfoData, ref global::System.IntPtr regKey, int valueKind, int flags)
		{
			bool result = true;
			short num2;
			try
			{
				switch (0)
				{
				case 0:
					goto IL_24;
				}
				for (;;)
				{
					IL_0E:
					int num;
					switch (num)
					{
					case 0:
						if (regKey.ToInt64() == -1L)
						{
							num2 = (short)798097411;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_F9;
					case 1:
						goto IL_110;
					case 2:
						goto IL_F9;
					case 3:
						result = false;
						num2 = (short)1831206914;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
					IL_F9:
					num2 = (short)1306787841;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_24:
				num2 = (short)234225665;
				if (num2 != 0)
				{
				}
				regKey = global::Motorola.Common.Communication.CommonUtil.NativeMethods.SetupDiOpenDevRegKey(hDevInfo, ref devInfoData, 1, 0, valueKind, flags);
				num2 = (short)2112008231;
				short num3 = num2;
				num2 = (short)1808773159;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_110:
					break;
				default:
				{
					num2 = (short)1299709952;
					if (num2 != 0)
					{
					}
					num2 = (short)356253696;
					int num = (int)((global::System.IntPtr)num2);
					goto IL_0E;
				}
				}
			}
			catch (global::System.Exception)
			{
				result = false;
			}
			num2 = (short)929234944;
			short num4 = num2;
			return result;
		}

		// Token: 0x06000123 RID: 291 RVA: 0x000100C0 File Offset: 0x0000E2C0
		public bool WrapperRegQueryVComName(global::System.IntPtr regKey, ref string devName)
		{
			short num = (short)1360396288;
			short num2 = num;
			num = (short)459319209;
			short num3 = num;
			num = (short)1365092265;
			switch (num3 == num)
			{
			}
			num = (short)1917255681;
			if (num != 0)
			{
			}
			num = (short)417792000;
			if (num != 0)
			{
			}
			return this.WrapperRegQueryValueEx(regKey, "PortName", ref devName);
		}

		// Token: 0x06000124 RID: 292 RVA: 0x00010178 File Offset: 0x0000E378
		public bool WrapperRegQueryValueEx(global::System.IntPtr regKey, string valueName, ref string devName)
		{
			short num = (short)2040791040;
			short num2 = num;
			num = (short)1038102435;
			short num3 = num;
			num = (short)1405366179;
			bool flag;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1825112064;
				if (num != 0)
				{
				}
				num = (short)1581973504;
				int num4 = (int)num;
				switch (num4)
				{
				default:
				{
					num = (short)664993793;
					if (num != 0)
					{
					}
					flag = true;
					uint num5 = 1024U;
					int num6 = 0;
					global::System.IntPtr intPtr = global::System.Runtime.InteropServices.Marshal.AllocHGlobal(1024);
					devName = string.Empty;
					try
					{
						switch (0)
						{
						case 0:
							goto IL_103;
						}
						for (;;)
						{
							IL_E0:
							switch (num4)
							{
							case 0:
								if (num6 != 0)
								{
									num = (short)250216449;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_1E8;
							case 1:
								this.b = "RegQueryValueEx last error code is: " + num6.ToString();
								num = (short)697368582;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_201;
							case 3:
								goto IL_1E8;
							case 4:
								global::Motorola.Common.Communication.CommonUtil.TransportLogger.WriteInfo(this.a, this.b);
								num = (short)1636630533;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 5:
								goto IL_1A1;
							case 6:
								if (!string.IsNullOrEmpty(this.a))
								{
									num = (short)257949700;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_1A1;
							}
							goto IL_103;
							IL_1A1:
							flag = false;
							num = (short)1085931523;
							num4 = (int)((global::System.IntPtr)num);
							continue;
							IL_1E8:
							num = (short)1892679682;
							num4 = (int)((global::System.IntPtr)num);
						}
						IL_201:
						break;
						IL_103:
						num6 = global::Motorola.Common.Communication.CommonUtil.NativeMethods.RegQueryValueEx(regKey, valueName, global::System.IntPtr.Zero, global::System.IntPtr.Zero, intPtr, ref num5);
						num = (short)1461190656;
						num4 = (int)((global::System.IntPtr)num);
						goto IL_E0;
					}
					catch (global::System.Exception ex)
					{
						this.b = "Exception found when invoking---RegQueryValueEx--- " + ex.Message;
						if (!string.IsNullOrEmpty(this.a))
						{
							global::Motorola.Common.Communication.CommonUtil.TransportLogger.WriteInfo(this.a, this.b);
						}
						flag = false;
					}
					finally
					{
						num = (short)1481572352;
						num4 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num4)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_286;
								}
								continue;
							case 1:
								devName = global::System.Runtime.InteropServices.Marshal.PtrToStringAuto(intPtr);
								num = (short)2061434883;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								if (intPtr != global::System.IntPtr.Zero)
								{
									num = (short)1515192324;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_31E;
							case 3:
								goto IL_2C0;
							case 4:
								global::System.Runtime.InteropServices.Marshal.FreeHGlobal(intPtr);
								num = (short)1867841541;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 5:
								goto IL_2BE;
							}
							IL_286:
							if (flag)
							{
								num = (short)310050817;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_2C0:
							num = (short)542048258;
							num4 = (int)((global::System.IntPtr)num);
						}
						IL_2BE:
						IL_31E:;
					}
					break;
				}
				}
				break;
			}
			}
			return flag;
		}

		// Token: 0x06000125 RID: 293 RVA: 0x000104DC File Offset: 0x0000E6DC
		public bool WrapperRegCloseKey(global::System.IntPtr regKey)
		{
			short num;
			bool result;
			for (;;)
			{
				num = (short)1770061824;
				short num2 = num;
				result = true;
				int num3 = 0;
				try
				{
					switch (0)
					{
					case 0:
						goto IL_5D;
					}
					int num4;
					for (;;)
					{
						IL_3B:
						switch (num4)
						{
						case 0:
							if (num3 != 0)
							{
								num = (short)352780289;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_12F;
						case 1:
							this.b = "RegCloseKey last error code is: " + num3.ToString();
							num = (short)461176838;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_146;
						case 3:
							goto IL_12F;
						case 4:
							global::Motorola.Common.Communication.CommonUtil.TransportLogger.WriteInfo(this.a, this.b);
							num = (short)801701893;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							goto IL_EA;
						case 6:
							if (!string.IsNullOrEmpty(this.a))
							{
								num = (short)1444020228;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_EA;
						}
						goto IL_5D;
						IL_EA:
						result = false;
						num = (short)665321475;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_12F:
						num = (short)2123235330;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_146:
					goto IL_1AC;
					IL_5D:
					num3 = global::Motorola.Common.Communication.CommonUtil.NativeMethods.RegCloseKey(regKey);
					num = (short)1382154240;
					num4 = (int)((global::System.IntPtr)num);
					goto IL_3B;
				}
				catch (global::System.Exception ex)
				{
					this.b = "Exception found when invoking---RegCloseKey--- " + ex.Message;
					if (!string.IsNullOrEmpty(this.a))
					{
						global::Motorola.Common.Communication.CommonUtil.TransportLogger.WriteInfo(this.a, this.b);
					}
					num = (short)155844609;
					if (num != 0)
					{
					}
					result = false;
				}
				IL_1AC:
				num = (short)906735631;
				short num5 = num;
				num = (short)422490127;
				switch ((num5 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_1E1;
				}
			}
			IL_1E1:
			num = (short)2107310080;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x06000126 RID: 294 RVA: 0x00010700 File Offset: 0x0000E900
		public bool WrapperRegisterDeviceNotification(global::System.IntPtr hRecipient, global::System.IntPtr notificationFilter, uint flags, ref global::System.IntPtr notifyHandler)
		{
			short num;
			bool result;
			for (;;)
			{
				num = (short)851116032;
				short num2 = num;
				num = (short)1338310657;
				if (num != 0)
				{
				}
				result = true;
				try
				{
					switch (0)
					{
					case 0:
						goto IL_80;
					}
					int num3;
					for (;;)
					{
						IL_5E:
						switch (num3)
						{
						case 0:
							if (notifyHandler == global::System.IntPtr.Zero)
							{
								num = (short)1773993985;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_16D;
						case 1:
						{
							global::System.ComponentModel.Win32Exception ex = new global::System.ComponentModel.Win32Exception(global::System.Runtime.InteropServices.Marshal.GetLastWin32Error());
							this.b = "RegisterDeviceNotification last win32 error message is: " + ex.Message;
							num = (short)1856634886;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							goto IL_185;
						case 3:
							goto IL_16D;
						case 4:
							global::Motorola.Common.Communication.CommonUtil.TransportLogger.WriteInfo(this.a, this.b);
							num = (short)1167785989;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							goto IL_127;
						case 6:
							if (!string.IsNullOrEmpty(this.a))
							{
								num = (short)851050500;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_127;
						}
						goto IL_80;
						IL_127:
						result = false;
						num = (short)537198595;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_16D:
						num = (short)203489282;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_185:
					goto IL_1C4;
					IL_80:
					notifyHandler = global::Motorola.Common.Communication.CommonUtil.NativeMethods.RegisterDeviceNotification(hRecipient, notificationFilter, flags);
					num = (short)286326784;
					num3 = (int)((global::System.IntPtr)num);
					goto IL_5E;
				}
				catch (global::System.Exception ex2)
				{
					this.b = "Exception found when invoking---RegisterDeviceNotification--- " + ex2.Message;
					if (!string.IsNullOrEmpty(this.a))
					{
						global::Motorola.Common.Communication.CommonUtil.TransportLogger.WriteInfo(this.a, this.b);
					}
					result = false;
				}
				IL_1C4:
				num = (short)1597199495;
				short num4 = num;
				num = (short)729502855;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_1F9;
				}
			}
			IL_1F9:
			num = (short)2293760;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00010938 File Offset: 0x0000EB38
		public bool WrapperUnregisterDeviceNotification(global::System.IntPtr hHandle)
		{
			short num;
			bool result;
			for (;;)
			{
				num = (short)44630016;
				short num2 = num;
				num = (short)2104885249;
				if (num != 0)
				{
				}
				result = true;
				try
				{
					num = (short)1529217024;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_94;
							}
							continue;
						case 1:
						{
							global::System.ComponentModel.Win32Exception ex = new global::System.ComponentModel.Win32Exception(global::System.Runtime.InteropServices.Marshal.GetLastWin32Error());
							this.b = "WrapperUnregisterDeviceNotification last win32 error message is: " + ex.Message;
							num = (short)729219078;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							goto IL_172;
						case 3:
							goto IL_15A;
						case 4:
							global::Motorola.Common.Communication.CommonUtil.TransportLogger.WriteInfo(this.a, this.b);
							num = (short)715456517;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							goto IL_114;
						case 6:
							if (!string.IsNullOrEmpty(this.a))
							{
								num = (short)1170014212;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_114;
						}
						IL_94:
						if (global::Motorola.Common.Communication.CommonUtil.NativeMethods.UnregisterDeviceNotification(hHandle) == 0U)
						{
							num = (short)1475280897;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_15A;
						IL_114:
						result = false;
						num = (short)1766391811;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_15A:
						num = (short)1318191106;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_172:;
				}
				catch (global::System.Exception ex2)
				{
					this.b = "Exception found when invoking---WrapperUnregisterDeviceNotification--- " + ex2.Message;
					if (!string.IsNullOrEmpty(this.a))
					{
						global::Motorola.Common.Communication.CommonUtil.TransportLogger.WriteInfo(this.a, this.b);
					}
					result = false;
				}
				num = (short)2025987989;
				short num4 = num;
				num = (short)871112597;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_1E6;
				}
			}
			IL_1E6:
			num = (short)575340544;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00010B60 File Offset: 0x0000ED60
		public bool WrapperCloseHandle(global::System.IntPtr hHandle)
		{
			short num;
			bool result;
			for (;;)
			{
				num = (short)1470824448;
				short num2 = num;
				num = (short)1602682881;
				if (num != 0)
				{
				}
				result = true;
				try
				{
					num = (short)1258881024;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_95;
							}
							continue;
						case 1:
						{
							global::System.ComponentModel.Win32Exception ex = new global::System.ComponentModel.Win32Exception(global::System.Runtime.InteropServices.Marshal.GetLastWin32Error());
							this.b = "WrapperCloseHandle last win32 error message is: " + ex.Message;
							num = (short)951582726;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							goto IL_173;
						case 3:
							goto IL_15B;
						case 4:
							global::Motorola.Common.Communication.CommonUtil.TransportLogger.WriteInfo(this.a, this.b);
							num = (short)1685323781;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							goto IL_114;
						case 6:
							if (!string.IsNullOrEmpty(this.a))
							{
								num = (short)677445636;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_114;
						}
						IL_95:
						if (global::Motorola.Common.Communication.CommonUtil.NativeMethods.CloseHandle(hHandle) == 0U)
						{
							num = (short)546504705;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_15B;
						IL_114:
						result = false;
						num = (short)785186819;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_15B:
						num = (short)1917714434;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_173:;
				}
				catch (global::System.Exception ex2)
				{
					this.b = "Exception found when invoking---WrapperCloseHandle--- " + ex2.Message;
					if (!string.IsNullOrEmpty(this.a))
					{
						global::Motorola.Common.Communication.CommonUtil.TransportLogger.WriteInfo(this.a, this.b);
					}
					result = false;
				}
				num = (short)1333407021;
				short num4 = num;
				num = (short)1907043629;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_1E8;
				}
			}
			IL_1E8:
			num = (short)932511744;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x06000129 RID: 297 RVA: 0x00010D88 File Offset: 0x0000EF88
		public bool WrapperRegisterServiceCtrlHandlerEx(string serviceName, global::Motorola.Common.Communication.CommonUtil.NativeMethods.CtrHandleCallback cbex, ref global::System.IntPtr serviceHandler)
		{
			short num;
			bool result;
			for (;;)
			{
				num = (short)751108096;
				short num2 = num;
				result = true;
				serviceHandler = global::System.IntPtr.Zero;
				try
				{
					switch (0)
					{
					case 0:
						goto IL_5F;
					}
					int num3;
					for (;;)
					{
						IL_3D:
						switch (num3)
						{
						case 0:
							if (serviceHandler == global::System.IntPtr.Zero)
							{
								num = (short)1840513025;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_14D;
						case 1:
						{
							global::System.ComponentModel.Win32Exception ex = new global::System.ComponentModel.Win32Exception(global::System.Runtime.InteropServices.Marshal.GetLastWin32Error());
							this.b = "RegisterServiceCtrlHandlerEx last win32 error message is: " + ex.Message;
							num = (short)207028230;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							goto IL_165;
						case 3:
							goto IL_14D;
						case 4:
							global::Motorola.Common.Communication.CommonUtil.TransportLogger.WriteInfo(this.a, this.b);
							num = (short)1307705349;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							goto IL_106;
						case 6:
							if (!string.IsNullOrEmpty(this.a))
							{
								num = (short)1187774468;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_106;
						}
						goto IL_5F;
						IL_106:
						result = false;
						num = (short)197001219;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_14D:
						num = (short)793116674;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_165:
					goto IL_1A4;
					IL_5F:
					serviceHandler = global::Motorola.Common.Communication.CommonUtil.NativeMethods.RegisterServiceCtrlHandlerEx(serviceName, cbex, global::System.IntPtr.Zero);
					num = (short)51183616;
					num3 = (int)((global::System.IntPtr)num);
					goto IL_3D;
				}
				catch (global::System.Exception ex2)
				{
					this.b = "Exception found when invoking---RegisterServiceCtrlHandlerEx--- " + ex2.Message;
					if (!string.IsNullOrEmpty(this.a))
					{
						global::Motorola.Common.Communication.CommonUtil.TransportLogger.WriteInfo(this.a, this.b);
					}
					result = false;
				}
				IL_1A4:
				num = (short)1192232106;
				short num4 = num;
				num = (short)190317738;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_1D8;
				}
			}
			IL_1D8:
			num = (short)172752897;
			if (num != 0)
			{
			}
			num = (short)833552384;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00010FC8 File Offset: 0x0000F1C8
		public bool WrapperSetServiceStatus(global::System.IntPtr hServiceStatus, ref global::Motorola.Common.Communication.CommonUtil.NativeMethods.SERVICE_STATUS lpServiceStatus)
		{
			bool flag = true;
			short num2;
			try
			{
				switch (0)
				{
				case 0:
					goto IL_2C;
				}
				for (;;)
				{
					IL_0E:
					int num;
					switch (num)
					{
					case 0:
						if (!string.IsNullOrEmpty(this.a))
						{
							num2 = (short)36831234;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_140;
					case 1:
						goto IL_140;
					case 2:
						global::Motorola.Common.Communication.CommonUtil.TransportLogger.WriteInfo(this.a, this.b);
						num2 = (short)269615105;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 3:
						if (!flag)
						{
							num2 = (short)573505541;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_140;
					case 4:
						goto IL_159;
					case 5:
					{
						global::System.ComponentModel.Win32Exception ex = new global::System.ComponentModel.Win32Exception(global::System.Runtime.InteropServices.Marshal.GetLastWin32Error());
						this.b = "SetServiceStatus last win32 error message is: " + ex.Message;
						num2 = (short)417792000;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
					IL_140:
					num2 = (short)1964703748;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_2C:
				num2 = (short)1399762955;
				short num3 = num2;
				num2 = (short)232435723;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_159:
					break;
				default:
				{
					num2 = (short)2106523648;
					if (num2 != 0)
					{
					}
					flag = global::Motorola.Common.Communication.CommonUtil.NativeMethods.SetServiceStatus(hServiceStatus, ref lpServiceStatus);
					num2 = (short)1166999555;
					int num = (int)((global::System.IntPtr)num2);
					goto IL_0E;
				}
				}
			}
			catch (global::System.Exception ex2)
			{
				this.b = "Exception found when invoking---SetServiceStatus--- " + ex2.Message;
				if (!string.IsNullOrEmpty(this.a))
				{
					global::Motorola.Common.Communication.CommonUtil.TransportLogger.WriteInfo(this.a, this.b);
				}
				flag = false;
			}
			num2 = (short)1004339200;
			short num4 = num2;
			num2 = (short)928317441;
			if (num2 != 0)
			{
			}
			return flag;
		}

		// Token: 0x0600012B RID: 299 RVA: 0x000111D8 File Offset: 0x0000F3D8
		public bool WrapperOpenSCManager(string machineName, string databaseName, uint accessRight, ref global::System.IntPtr ctrMngDBHandle)
		{
			bool result = true;
			ctrMngDBHandle = global::System.IntPtr.Zero;
			short num2;
			try
			{
				switch (0)
				{
				case 0:
					goto IL_38;
				}
				int num;
				for (;;)
				{
					IL_16:
					switch (num)
					{
					case 0:
						goto IL_E2;
					case 1:
					{
						num2 = (short)1849748106;
						short num3 = num2;
						num2 = (short)1371466378;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num2 = (short)1640169473;
							if (num2 != 0)
							{
							}
							num2 = (short)724303872;
							if (num2 != 0)
							{
							}
							global::Motorola.Common.Communication.CommonUtil.TransportLogger.WriteInfo(this.a, this.b);
							num2 = (short)242155520;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 2:
						goto IL_1B9;
					case 3:
						goto IL_1A0;
					case 4:
						if (ctrMngDBHandle == global::System.IntPtr.Zero)
						{
							num2 = (short)910360582;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_1A0;
					case 5:
						if (!string.IsNullOrEmpty(this.a))
						{
							num2 = (short)1304887297;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_E2;
					case 6:
					{
						global::System.ComponentModel.Win32Exception ex = new global::System.ComponentModel.Win32Exception(global::System.Runtime.InteropServices.Marshal.GetLastWin32Error());
						this.b = "OpenSCManager last win32 error message is: " + ex.Message;
						num2 = (short)1208352773;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					goto IL_38;
					IL_E2:
					result = false;
					num2 = (short)479920131;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_1A0:
					num2 = (short)93192194;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_1B9:
				goto IL_1F8;
				IL_38:
				ctrMngDBHandle = global::Motorola.Common.Communication.CommonUtil.NativeMethods.OpenSCManager(machineName, databaseName, accessRight);
				num2 = (short)1354235908;
				num = (int)((global::System.IntPtr)num2);
				goto IL_16;
			}
			catch (global::System.Exception ex2)
			{
				this.b = "Exception found when invoking---OpenSCManager--- " + ex2.Message;
				if (!string.IsNullOrEmpty(this.a))
				{
					global::Motorola.Common.Communication.CommonUtil.TransportLogger.WriteInfo(this.a, this.b);
				}
				result = false;
			}
			IL_1F8:
			num2 = (short)1237975040;
			short num4 = num2;
			return result;
		}

		// Token: 0x0600012C RID: 300 RVA: 0x00011424 File Offset: 0x0000F624
		public bool WrapperCloseServiceHandle(global::System.IntPtr hSCObject)
		{
			bool result = true;
			short num;
			try
			{
				num = (short)402522116;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_C3;
					case 1:
					{
						num = (short)2131133085;
						short num3 = num;
						num = (short)1049592477;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_50;
						default:
							num = (short)1045233664;
							if (num != 0)
							{
							}
							global::Motorola.Common.Communication.CommonUtil.TransportLogger.WriteInfo(this.a, this.b);
							num = (short)1156055040;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
						goto IL_16F;
					case 3:
						goto IL_157;
					case 4:
						switch (0)
						{
						case 0:
							goto IL_45;
						}
						continue;
					case 5:
						if (!string.IsNullOrEmpty(this.a))
						{
							num = (short)670564353;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C3;
					case 6:
					{
						global::System.ComponentModel.Win32Exception ex = new global::System.ComponentModel.Win32Exception(global::System.Runtime.InteropServices.Marshal.GetLastWin32Error());
						this.b = "CloseServiceHandle last win32 error message is: " + ex.Message;
						num = (short)807337989;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_45;
					IL_50:
					num = (short)811335686;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_45:
					if (global::Motorola.Common.Communication.CommonUtil.NativeMethods.CloseHandle(hSCObject) == 0U)
					{
						goto IL_50;
					}
					goto IL_157;
					IL_C3:
					result = false;
					num = (short)335347715;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_157:
					num = (short)471203842;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_16F:;
			}
			catch (global::System.Exception ex2)
			{
				this.b = "Exception found when invoking---CloseServiceHandle--- " + ex2.Message;
				if (!string.IsNullOrEmpty(this.a))
				{
					num = (short)909049857;
					if (num != 0)
					{
					}
					global::Motorola.Common.Communication.CommonUtil.TransportLogger.WriteInfo(this.a, this.b);
				}
				result = false;
			}
			num = (short)1934688256;
			short num4 = num;
			return result;
		}

		// Token: 0x0600012D RID: 301 RVA: 0x00011650 File Offset: 0x0000F850
		public bool WrapperGetCurrentProcessId(ref uint processId)
		{
			bool result = true;
			processId = 0U;
			short num;
			try
			{
				processId = global::Motorola.Common.Communication.CommonUtil.NativeMethods.GetCurrentProcessId();
			}
			catch (global::System.Exception ex)
			{
				this.b = "Exception found when invoking---GetCurrentProcessId--- " + ex.Message;
				if (!string.IsNullOrEmpty(this.a))
				{
					num = (short)1882906231;
					short num2 = num;
					num = (short)182836855;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1410793472;
						if (num != 0)
						{
						}
						global::Motorola.Common.Communication.CommonUtil.TransportLogger.WriteInfo(this.a, this.b);
						break;
					}
				}
				result = false;
			}
			num = (short)498008064;
			short num3 = num;
			num = (short)586285057;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x0600012E RID: 302 RVA: 0x00011758 File Offset: 0x0000F958
		public bool WrapperEnumServicesStatusEx(global::System.IntPtr hSCManager, uint InfoLevel, uint dwServiceType, uint dwServiceState, global::System.IntPtr lpServices, uint cbBufSize, out uint pcbBytesNeeded, out uint lpServicesReturned, ref uint lpResumeHandle, string pszGroupName, out int win32LastError)
		{
			short num = (short)1074855937;
			if (num != 0)
			{
			}
			num = (short)2029912064;
			short num2 = num;
			bool flag = true;
			pcbBytesNeeded = 0U;
			lpServicesReturned = 0U;
			lpResumeHandle = 0U;
			win32LastError = 0;
			try
			{
				switch (0)
				{
				case 0:
					goto IL_8F;
				}
				for (;;)
				{
					IL_71:
					int num3;
					switch (num3)
					{
					case 0:
						if (!string.IsNullOrEmpty(this.a))
						{
							num = (short)1051459586;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1B6;
					case 1:
						goto IL_1B6;
					case 2:
						global::Motorola.Common.Communication.CommonUtil.TransportLogger.WriteInfo(this.a, this.b);
						num = (short)743178241;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (!flag)
						{
							num = (short)431161349;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1B6;
					case 4:
						goto IL_1CE;
					case 5:
					{
						win32LastError = global::System.Runtime.InteropServices.Marshal.GetLastWin32Error();
						global::System.ComponentModel.Win32Exception ex = new global::System.ComponentModel.Win32Exception(win32LastError);
						this.b = "EnumServicesStatusEx last win32 error message is: " + ex.Message;
						num = (short)969736192;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
					IL_1B6:
					num = (short)668860420;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_8F:
				num = (short)180770559;
				short num4 = num;
				num = (short)1245992703;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_1CE:
					break;
				default:
				{
					num = (short)1895301120;
					if (num != 0)
					{
					}
					flag = global::Motorola.Common.Communication.CommonUtil.NativeMethods.EnumServicesStatusEx(hSCManager, InfoLevel, dwServiceType, dwServiceState, lpServices, cbBufSize, out pcbBytesNeeded, out lpServicesReturned, ref lpResumeHandle, pszGroupName);
					num = (short)560660483;
					int num3 = (int)((global::System.IntPtr)num);
					goto IL_71;
				}
				}
			}
			catch (global::System.Exception ex2)
			{
				this.b = "Exception found when invoking---EnumServicesStatusEx--- " + ex2.Message;
				if (!string.IsNullOrEmpty(this.a))
				{
					global::Motorola.Common.Communication.CommonUtil.TransportLogger.WriteInfo(this.a, this.b);
				}
				flag = false;
			}
			return flag;
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00011990 File Offset: 0x0000FB90
		public bool WrapperWaitForSingleObject(global::System.IntPtr hHandle, uint dwMilliseconds, ref bool bTimeout)
		{
			short num = (short)28704768;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)1655373825;
				if (num != 0)
				{
				}
				num = (short)436142080;
				short num3 = num;
				bool result = true;
				bTimeout = false;
				try
				{
					switch (0)
					{
					case 0:
						goto IL_AB;
					}
					uint num4;
					for (;;)
					{
						IL_7C:
						switch (num2)
						{
						case 0:
							if (num4 == 4294967295U)
							{
								num = (short)494993416;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_245;
						case 1:
							goto IL_25E;
						case 2:
							goto IL_18C;
						case 3:
							goto IL_245;
						case 4:
							goto IL_170;
						case 5:
							global::Motorola.Common.Communication.CommonUtil.TransportLogger.WriteInfo(this.a, this.b);
							num = (short)1738407940;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							if (!string.IsNullOrEmpty(this.a))
							{
								num = (short)982450181;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_170;
						case 7:
							if (num4 == 258U)
							{
								num = (short)2122579977;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)56885248;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
						{
							num = (short)2113214509;
							short num5 = num;
							num = (short)783095853;
							switch ((num5 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_18C;
							default:
							{
								num = (short)180158464;
								if (num != 0)
								{
								}
								global::System.ComponentModel.Win32Exception ex = new global::System.ComponentModel.Win32Exception(global::System.Runtime.InteropServices.Marshal.GetLastWin32Error());
								this.b = "WaitForSingleObject last win32 error message is: " + ex.Message;
								num = (short)685637638;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							break;
						}
						case 9:
							bTimeout = true;
							result = false;
							num = (short)1053949955;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AB;
						IL_170:
						result = false;
						num = (short)2137456642;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_245:
						num = (short)1835466753;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_18C:
						goto IL_245;
					}
					IL_25E:
					return result;
					IL_AB:
					num4 = global::Motorola.Common.Communication.CommonUtil.NativeMethods.WaitForSingleObject(hHandle, dwMilliseconds);
					num = (short)297795591;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_7C;
				}
				catch (global::System.Exception ex2)
				{
					this.b = "Exception found when invoking --- WaitForSingleObject ---" + ex2.Message;
					if (!string.IsNullOrEmpty(this.a))
					{
						global::Motorola.Common.Communication.CommonUtil.TransportLogger.WriteInfo(this.a, this.b);
					}
					result = false;
				}
				return result;
			}
			}
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00011C58 File Offset: 0x0000FE58
		public bool WrapperSetEvent(global::System.IntPtr hEvent)
		{
			short num = (short)1077149697;
			if (num != 0)
			{
			}
			num = (short)1704132608;
			short num2 = num;
			bool flag = true;
			try
			{
				num = (short)812646407;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						if (!flag)
						{
							num = (short)231211016;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_210;
					case 1:
						goto IL_227;
					case 2:
						goto IL_210;
					case 3:
					{
						num = (short)1239467599;
						short num4 = num;
						num = (short)2144650831;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_F0;
						default:
							num = (short)1788936192;
							if (num != 0)
							{
							}
							goto IL_C0;
						}
						break;
					}
					case 4:
						goto IL_F5;
					case 5:
						global::Motorola.Common.Communication.CommonUtil.TransportLogger.WriteInfo(this.a, this.b);
						num = (short)2047672324;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						if (!string.IsNullOrEmpty(this.a))
						{
							num = (short)1206779909;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F5;
					case 7:
						switch (0)
						{
						case 0:
							goto IL_A1;
						}
						continue;
					case 8:
						goto IL_F0;
					case 9:
						flag = false;
						num = (short)1999437827;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_A1:
					if (global::Motorola.Common.Communication.CommonUtil.NativeMethods.SetEvent(hEvent) == 0)
					{
						num = (short)159711241;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_C0:
					num = (short)889061376;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_F0:
					global::System.ComponentModel.Win32Exception ex = new global::System.ComponentModel.Win32Exception(global::System.Runtime.InteropServices.Marshal.GetLastWin32Error());
					this.b = "SetEvent last win32 error message is: " + ex.Message;
					num = (short)1692401670;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_F5:
					flag = false;
					num = (short)1281359874;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_210:
					num = (short)1316814849;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_227:;
			}
			catch (global::System.Exception ex2)
			{
				this.b = "Exception found when invoking ---SetEvent ---" + ex2.Message;
				if (!string.IsNullOrEmpty(this.a))
				{
					global::Motorola.Common.Communication.CommonUtil.TransportLogger.WriteInfo(this.a, this.b);
				}
				flag = false;
			}
			return flag;
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00011EE8 File Offset: 0x000100E8
		public bool WrapperResetEvent(global::System.IntPtr hEvent)
		{
			bool flag = true;
			short num;
			try
			{
				num = (short)1504706567;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						if (!flag)
						{
							num = (short)39190536;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1C0;
					case 1:
						goto IL_1D8;
					case 2:
						goto IL_1C0;
					case 3:
					{
						num = (short)1025493944;
						short num3 = num;
						num = (short)1912916920;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_9E;
						default:
							num = (short)1818165248;
							if (num != 0)
							{
							}
							goto IL_70;
						}
						break;
					}
					case 4:
						goto IL_A3;
					case 5:
						global::Motorola.Common.Communication.CommonUtil.TransportLogger.WriteInfo(this.a, this.b);
						num = (short)362217476;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						if (!string.IsNullOrEmpty(this.a))
						{
							num = (short)558694405;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A3;
					case 7:
						switch (0)
						{
						case 0:
							goto IL_52;
						}
						continue;
					case 8:
						goto IL_9E;
					case 9:
						flag = false;
						num = (short)738983939;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_52:
					if (global::Motorola.Common.Communication.CommonUtil.NativeMethods.SetEvent(hEvent) == 0)
					{
						num = (short)1509425161;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_70:
					num = (short)148111360;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_9E:
					global::System.ComponentModel.Win32Exception ex = new global::System.ComponentModel.Win32Exception(global::System.Runtime.InteropServices.Marshal.GetLastWin32Error());
					this.b = "ResetEvent last win32 error message is: " + ex.Message;
					num = (short)1802567686;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_A3:
					flag = false;
					num = (short)2019753986;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1C0:
					num = (short)451215361;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1D8:;
			}
			catch (global::System.Exception ex2)
			{
				this.b = "Exception found when invoking ---ResetEvent ---" + ex2.Message;
				if (!string.IsNullOrEmpty(this.a))
				{
					global::Motorola.Common.Communication.CommonUtil.TransportLogger.WriteInfo(this.a, this.b);
				}
				flag = false;
			}
			num = (short)239861760;
			short num4 = num;
			num = (short)1842216961;
			if (num != 0)
			{
			}
			return flag;
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00012178 File Offset: 0x00010378
		public bool WrapperCreateEvent(bool bManualReset, bool bSignaledIniState, ref global::System.IntPtr eventHandle)
		{
			short num = (short)1335492608;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_4B;
				}
				bool result;
				int a_;
				int a_2;
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
						goto IL_296;
					case 1:
						goto IL_2F6;
					case 2:
						try
						{
							switch (0)
							{
							case 0:
								goto IL_E7;
							}
							for (;;)
							{
								IL_C4:
								switch (num2)
								{
								case 0:
									global::Motorola.Common.Communication.CommonUtil.TransportLogger.WriteInfo(this.a, this.b);
									num = (short)502267905;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_138;
								case 2:
									goto IL_24F;
								case 3:
								{
									num = (short)2122191876;
									short num3 = num;
									num = (short)50926596;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										break;
									default:
										num = (short)1349320704;
										if (num != 0)
										{
										}
										if (!string.IsNullOrEmpty(this.a))
										{
											num = (short)1255211008;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_138;
									}
									break;
								}
								case 4:
									if (eventHandle == global::System.IntPtr.Zero)
									{
										num = (short)499384326;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_237;
								case 5:
									goto IL_237;
								case 6:
								{
									global::System.ComponentModel.Win32Exception ex = new global::System.ComponentModel.Win32Exception(global::System.Runtime.InteropServices.Marshal.GetLastWin32Error());
									this.b = "CreateEvent last win32 error message is: " + ex.Message;
									num = (short)184352771;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								goto IL_E7;
								IL_138:
								result = false;
								num = (short)1159462917;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_237:
								num = (short)294125570;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_24F:
							return result;
							IL_E7:
							eventHandle = global::Motorola.Common.Communication.CommonUtil.NativeMethods.CreateEvent(global::System.IntPtr.Zero, a_, a_2, global::System.IntPtr.Zero);
							num = (short)1537212420;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_C4;
						}
						catch (global::System.Exception ex2)
						{
							this.b = "Exception found when invoking ---CreateEvent ---" + ex2.Message;
							if (!string.IsNullOrEmpty(this.a))
							{
								global::Motorola.Common.Communication.CommonUtil.TransportLogger.WriteInfo(this.a, this.b);
							}
							return false;
						}
						goto IL_296;
					case 3:
						if (bSignaledIniState)
						{
							num = (short)864485376;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_32F;
					case 4:
						if (bManualReset)
						{
							num = (short)1218248710;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2F6;
					case 5:
						num = (short)89260033;
						if (num != 0)
						{
						}
						goto IL_32F;
					case 6:
						a_ = 1;
						num = (short)1323696129;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_4B;
					IL_296:
					a_2 = 1;
					num = (short)492634117;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2F6:
					num = (short)710475779;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_32F:
					num = (short)1231749122;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_4B:
				num = (short)400818176;
				short num4 = num;
				result = true;
				eventHandle = global::System.IntPtr.Zero;
				a_ = 0;
				a_2 = 0;
				num = (short)1829044228;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06000133 RID: 307 RVA: 0x000124F0 File Offset: 0x000106F0
		public bool WrapperEscapeCommFunction(global::System.IntPtr hFile, global::Motorola.Common.Communication.CommonUtil.NativeMethods.CommEscapes funcCode)
		{
			short num = (short)1379532800;
			short num2 = num;
			bool result = true;
			try
			{
				num = (short)709033988;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						goto IL_EC;
					case 1:
						global::Motorola.Common.Communication.CommonUtil.TransportLogger.WriteInfo(this.a, this.b);
						num = (short)934739968;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_148;
					case 3:
						goto IL_131;
					case 4:
						switch (0)
						{
						case 0:
							goto IL_6D;
						}
						continue;
					case 5:
						if (!string.IsNullOrEmpty(this.a))
						{
							num = (short)466354177;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_EC;
					case 6:
					{
						global::System.ComponentModel.Win32Exception ex = new global::System.ComponentModel.Win32Exception(global::System.Runtime.InteropServices.Marshal.GetLastWin32Error());
						this.b = "EscapeCommFunction last win32 error message is: " + ex.Message;
						num = (short)878641157;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_6D:
					if (global::Motorola.Common.Communication.CommonUtil.NativeMethods.EscapeCommFunction(hFile, (uint)funcCode) == 0)
					{
						num = (short)231211014;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_131;
					IL_EC:
					result = false;
					num = (short)97517571;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_131:
					num = (short)770179074;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_148:;
			}
			catch (global::System.Exception ex2)
			{
				this.b = "Exception found when invoking ---EscapeCommFunction ---" + ex2.Message;
				if (string.IsNullOrEmpty(this.a))
				{
					goto IL_186;
				}
				IL_171:
				global::Motorola.Common.Communication.CommonUtil.TransportLogger.WriteInfo(this.a, this.b);
				IL_186:
				num = (short)924488955;
				short num4 = num;
				num = (short)254186747;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_171;
				default:
					num = (short)792002561;
					if (num != 0)
					{
					}
					num = (short)296288256;
					if (num != 0)
					{
					}
					result = false;
					break;
				}
			}
			return result;
		}

		// Token: 0x06000134 RID: 308 RVA: 0x0001271C File Offset: 0x0001091C
		public bool WrapperSetCommTimeouts(global::System.IntPtr hFile, ref global::Motorola.Common.Communication.CommonUtil.NativeMethods.CommTimeouts timeouts)
		{
			short num = (short)1524498432;
			short num2 = num;
			bool result = true;
			try
			{
				num = (short)1200947205;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						goto IL_14C;
					case 1:
						goto IL_ED;
					case 2:
						if (!string.IsNullOrEmpty(this.a))
						{
							num = (short)1624178694;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_ED;
					case 3:
						goto IL_135;
					case 4:
					{
						global::System.ComponentModel.Win32Exception ex = new global::System.ComponentModel.Win32Exception(global::System.Runtime.InteropServices.Marshal.GetLastWin32Error());
						this.b = "SetCommTimeouts last win32 error message is: " + ex.Message;
						num = (short)635895810;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						switch (0)
						{
						case 0:
							goto IL_6E;
						}
						continue;
					case 6:
						global::Motorola.Common.Communication.CommonUtil.TransportLogger.WriteInfo(this.a, this.b);
						num = (short)767098881;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_6E:
					if (global::Motorola.Common.Communication.CommonUtil.NativeMethods.SetCommTimeouts(hFile, ref timeouts) == 0)
					{
						num = (short)860028932;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_135;
					IL_ED:
					result = false;
					num = (short)1133707267;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_135:
					num = (short)1126105088;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_14C:;
			}
			catch (global::System.Exception ex2)
			{
				this.b = "Exception found when invoking ---SetCommTimeouts ---" + ex2.Message;
				if (string.IsNullOrEmpty(this.a))
				{
					goto IL_18A;
				}
				IL_175:
				global::Motorola.Common.Communication.CommonUtil.TransportLogger.WriteInfo(this.a, this.b);
				IL_18A:
				num = (short)956400863;
				short num4 = num;
				num = (short)1366394079;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_175;
				default:
					num = (short)2138898433;
					if (num != 0)
					{
					}
					num = (short)1400635392;
					if (num != 0)
					{
					}
					result = false;
					break;
				}
			}
			return result;
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00012948 File Offset: 0x00010B48
		public bool WrapperGetCommState(global::System.IntPtr hFile, ref global::Motorola.Common.Communication.CommonUtil.NativeMethods.DCB dcb)
		{
			short num = (short)763035649;
			if (num != 0)
			{
			}
			bool result = true;
			try
			{
				num = (short)1784020997;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_149;
					case 1:
						goto IL_EA;
					case 2:
						if (!string.IsNullOrEmpty(this.a))
						{
							num = (short)1109393414;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_EA;
					case 3:
						goto IL_130;
					case 4:
					{
						global::System.ComponentModel.Win32Exception ex = new global::System.ComponentModel.Win32Exception(global::System.Runtime.InteropServices.Marshal.GetLastWin32Error());
						this.b = "GetCommState last win32 error message is: " + ex.Message;
						num = (short)954859522;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						switch (0)
						{
						case 0:
							goto IL_6C;
						}
						continue;
					case 6:
						global::Motorola.Common.Communication.CommonUtil.TransportLogger.WriteInfo(this.a, this.b);
						num = (short)1264910337;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_6C:
					if (global::Motorola.Common.Communication.CommonUtil.NativeMethods.GetCommState(hFile, ref dcb) == 0)
					{
						num = (short)2104033284;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_130;
					IL_EA:
					result = false;
					num = (short)1537343491;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_130:
					num = (short)1078591488;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_149:;
			}
			catch (global::System.Exception ex2)
			{
				this.b = "Exception found when invoking ---GetCommState ---" + ex2.Message;
				if (string.IsNullOrEmpty(this.a))
				{
					goto IL_187;
				}
				IL_172:
				global::Motorola.Common.Communication.CommonUtil.TransportLogger.WriteInfo(this.a, this.b);
				IL_187:
				num = (short)882125672;
				short num3 = num;
				num = (short)750463848;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_172;
				default:
					num = (short)967114752;
					if (num != 0)
					{
					}
					result = false;
					break;
				}
			}
			num = (short)340852736;
			short num4 = num;
			return result;
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00012B74 File Offset: 0x00010D74
		public bool WrapperSetCommState(global::System.IntPtr hFile, ref global::Motorola.Common.Communication.CommonUtil.NativeMethods.DCB dcb)
		{
			short num = (short)995360768;
			short num2 = num;
			bool result = true;
			try
			{
				num = (short)1148190725;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						goto IL_14C;
					case 1:
						goto IL_EE;
					case 2:
						if (!string.IsNullOrEmpty(this.a))
						{
							num = (short)580911110;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_EE;
					case 3:
						goto IL_135;
					case 4:
					{
						global::System.ComponentModel.Win32Exception ex = new global::System.ComponentModel.Win32Exception(global::System.Runtime.InteropServices.Marshal.GetLastWin32Error());
						this.b = "SetCommState last win32 error message is: " + ex.Message;
						num = (short)629800962;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						switch (0)
						{
						case 0:
							goto IL_6E;
						}
						continue;
					case 6:
						global::Motorola.Common.Communication.CommonUtil.TransportLogger.WriteInfo(this.a, this.b);
						num = (short)363790337;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_6E:
					if (global::Motorola.Common.Communication.CommonUtil.NativeMethods.SetCommState(hFile, ref dcb) == 0)
					{
						num = (short)599195652;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_135;
					IL_EE:
					result = false;
					num = (short)878379011;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_135:
					num = (short)591396864;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_14C:;
			}
			catch (global::System.Exception ex2)
			{
				this.b = "Exception found when invoking ---SetCommStates ---" + ex2.Message;
				if (string.IsNullOrEmpty(this.a))
				{
					goto IL_1B1;
				}
				IL_175:
				num = (short)495845377;
				if (num != 0)
				{
				}
				global::Motorola.Common.Communication.CommonUtil.TransportLogger.WriteInfo(this.a, this.b);
				IL_1B1:
				num = (short)121097635;
				short num4 = num;
				num = (short)1924386211;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_175;
				default:
					num = (short)253231104;
					if (num != 0)
					{
					}
					result = false;
					break;
				}
			}
			return result;
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00012DA0 File Offset: 0x00010FA0
		public bool WrapperSetupComm(global::System.IntPtr hFile, uint dwInQueue, uint dwOutQueue)
		{
			bool result = true;
			short num;
			try
			{
				num = (short)1308426245;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_125;
					case 1:
						goto IL_C6;
					case 2:
						if (!string.IsNullOrEmpty(this.a))
						{
							num = (short)1844379654;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C6;
					case 3:
						goto IL_10E;
					case 4:
					{
						global::System.ComponentModel.Win32Exception ex = new global::System.ComponentModel.Win32Exception(global::System.Runtime.InteropServices.Marshal.GetLastWin32Error());
						this.b = "SetupComm last win32 error message is: " + ex.Message;
						num = (short)1764229122;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						switch (0)
						{
						case 0:
							goto IL_44;
						}
						continue;
					case 6:
						global::Motorola.Common.Communication.CommonUtil.TransportLogger.WriteInfo(this.a, this.b);
						num = (short)1816788993;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_44:
					if (global::Motorola.Common.Communication.CommonUtil.NativeMethods.SetupComm(hFile, dwInQueue, dwOutQueue) == 0)
					{
						num = (short)1700659204;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_10E;
					IL_C6:
					result = false;
					num = (short)919535619;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_10E:
					num = (short)115212288;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_125:;
			}
			catch (global::System.Exception ex2)
			{
				this.b = "Exception found when invoking ---SetupComm ---" + ex2.Message;
				if (string.IsNullOrEmpty(this.a))
				{
					goto IL_163;
				}
				IL_14E:
				global::Motorola.Common.Communication.CommonUtil.TransportLogger.WriteInfo(this.a, this.b);
				IL_163:
				num = (short)531746380;
				short num3 = num;
				num = (short)1618267724;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_14E;
				default:
					num = (short)1799159808;
					if (num != 0)
					{
					}
					result = false;
					break;
				}
			}
			num = (short)2014117889;
			if (num != 0)
			{
			}
			num = (short)541720576;
			short num4 = num;
			return result;
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00012FD0 File Offset: 0x000111D0
		private unsafe bool b(global::System.IntPtr A_0, byte* A_1, uint A_2, uint A_3, global::System.IntPtr A_4, ref int A_5)
		{
			short num = (short)1904279552;
			short num2 = num;
			bool result = true;
			try
			{
				num = (short)1506934786;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						num = (short)893059073;
						if (num != 0)
						{
						}
						result = false;
						num = (short)981729283;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_ED;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_62;
						}
						continue;
					case 3:
						goto IL_D5;
					}
					IL_62:
					if (global::Motorola.Common.Communication.CommonUtil.NativeMethods.b(A_0, A_1 + A_2, A_3, global::System.IntPtr.Zero, A_4, ref A_5) == 0)
					{
						num = (short)766967808;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_D5:
					num = (short)1418657793;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_ED:;
			}
			catch (global::System.Exception ex)
			{
				this.b = "Exception found when invoking ---WriteFile ---" + ex.Message;
				if (string.IsNullOrEmpty(this.a))
				{
					goto IL_12B;
				}
				IL_116:
				global::Motorola.Common.Communication.CommonUtil.TransportLogger.WriteInfo(this.a, this.b);
				IL_12B:
				num = (short)793043801;
				short num4 = num;
				num = (short)524608345;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_116;
				default:
					num = (short)394854400;
					if (num != 0)
					{
					}
					result = false;
					break;
				}
			}
			return result;
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00013168 File Offset: 0x00011368
		public unsafe void WriteFileAsyn(global::System.IntPtr hFile, byte[] lpBuffer, uint offset, uint nNumberOfBytesToWrite, global::System.IntPtr lpOverlapped, global::System.IntPtr writeEvent, uint waitTime)
		{
			short num = (short)785317888;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_B2;
				}
				bool flag;
				bool flag2;
				uint num3;
				byte[] array;
				uint num4;
				bool flag3;
				int num6;
				for (;;)
				{
					IL_27:
					byte* a_;
					switch (num2)
					{
					case 0:
						num = (short)255721475;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (flag)
						{
							num = (short)1742340118;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1DA;
					case 2:
						if (!string.IsNullOrEmpty(this.a))
						{
							num = (short)2057175063;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_594;
					case 3:
						if (flag2)
						{
							num = (short)993656850;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_140;
					case 4:
						if (num3 >= waitTime)
						{
							num = (short)1072234503;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_594;
					case 5:
						num = (short)1807417370;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						if (array.Length == 0)
						{
							num = (short)829292559;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						a_ = &array[0];
						num = (short)1341456392;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_628;
					case 8:
						goto IL_3E0;
					case 9:
						goto IL_255;
					case 10:
						if (num4 != nNumberOfBytesToWrite)
						{
							num = (short)762904585;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_665;
					case 11:
					{
						num = (short)361345167;
						short num5 = num;
						num = (short)2123018383;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_459;
						default:
							num = (short)190119936;
							if (num != 0)
							{
							}
							goto IL_594;
						}
						break;
					}
					case 12:
						num = (short)193921038;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						if (!flag3 && flag)
						{
							num = (short)1429536798;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_628;
					case 14:
						if (flag)
						{
							num = (short)483131416;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2F6;
					case 15:
						goto IL_606;
					case 16:
						goto IL_3E0;
					case 17:
						global::Motorola.Common.Communication.CommonUtil.TransportLogger.WriteInfo(this.a, this.b);
						num = (short)991166492;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						this.b = "Waiting for WaitForSingleObject in write operation got time-out result!";
						num = (short)1339490333;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						if (!flag3)
						{
							num = (short)869531653;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_42C;
					case 20:
						goto IL_1DA;
					case 21:
						goto IL_189;
					case 22:
						global::System.Threading.Thread.Sleep(10);
						num3 += 10U;
						num = (short)884146196;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						global::Motorola.Common.Communication.CommonUtil.TransportLogger.WriteInfo(this.a, this.b);
						num = (short)1938554891;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
						goto IL_4E9;
					case 25:
						if (!flag3)
						{
							num = (short)1955725324;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)833159178;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
						if ((long)num6 != 997L)
						{
							num = (short)671154197;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_42C;
					case 27:
						fixed (byte[] array = lpBuffer)
						{
							if (lpBuffer != null)
							{
								num = (short)1750466591;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_606;
							break;
						}
					case 28:
						goto IL_545;
					case 29:
					{
						num = (short)849084416;
						short num7 = num;
						if (!string.IsNullOrEmpty(this.a))
						{
							num = (short)1280835601;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_545;
					}
					case 30:
						num = (short)2117402628;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 31:
						num = (short)1104478214;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 32:
						if (!flag3)
						{
							goto IL_459;
						}
						goto IL_594;
					}
					goto IL_B2;
					IL_1DA:
					num = (short)5570573;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3E0:
					flag3 = this.b(hFile, a_, offset, nNumberOfBytesToWrite, lpOverlapped, ref num6);
					num = (short)1766260755;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_42C:
					flag3 = this.WrapperWaitForSingleObject(writeEvent, waitTime, ref flag2);
					num = (short)651100192;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_459:
					num = (short)661651456;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_545:
					this.b = "But we still try to get overlapped result";
					num = (short)392691714;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_594:
					num = (short)2053570561;
					if (num != 0)
					{
					}
					flag3 = this.WrapperGetOverlappedResult(hFile, lpOverlapped, ref num4, false, ref flag);
					num = (short)2145124353;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_606:
					a_ = null;
					num = (short)781713424;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_628:
					num = (short)508690457;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_140:
				throw new global::System.Exception("Waiting for write operation completion got failed result");
				IL_189:
				this.b = "Write operation got failed result, the last win32 error code is :" + global::System.Convert.ToString(num6);
				throw new global::System.Exception(this.b);
				IL_255:
				this.b = "the actually written byte size didn't equal with the size of whishing to be written";
				throw new global::System.Exception(this.b);
				IL_2F6:
				this.b = "Failed to get overlapped result in write operation, the last win32 error code had been logged";
				throw new global::System.Exception(this.b);
				IL_4E9:
				uint purgeFlag = 5U;
				this.WrapperPurgeComm(hFile, purgeFlag);
				this.b = "Waiting for GetOverlappedResult in write operation got time-out result!";
				throw new global::System.TimeoutException(this.b);
				IL_665:
				array = null;
				return;
				IL_B2:
				flag3 = true;
				flag = false;
				num6 = 0;
				num4 = 0U;
				num3 = 0U;
				flag2 = false;
				num = (short)660471835;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x0600013A RID: 314 RVA: 0x000137E0 File Offset: 0x000119E0
		private unsafe bool a(global::System.IntPtr A_0, byte* A_1, uint A_2, uint A_3, global::System.IntPtr A_4, ref int A_5)
		{
			short num = (short)1312620544;
			short num2 = num;
			bool result = true;
			try
			{
				num = (short)1252065282;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						num = (short)571867137;
						if (num != 0)
						{
						}
						result = false;
						num = (short)183631875;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_E9;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_60;
						}
						continue;
					case 3:
						goto IL_D1;
					}
					IL_60:
					if (global::Motorola.Common.Communication.CommonUtil.NativeMethods.a(A_0, A_1 + A_2, A_3, global::System.IntPtr.Zero, A_4, ref A_5) == 0)
					{
						num = (short)182714368;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_D1:
					num = (short)502726657;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_E9:;
			}
			catch (global::System.Exception ex)
			{
				this.b = "Exception found when invoking ---ReadFile ---" + ex.Message;
				if (string.IsNullOrEmpty(this.a))
				{
					goto IL_127;
				}
				IL_112:
				global::Motorola.Common.Communication.CommonUtil.TransportLogger.WriteInfo(this.a, this.b);
				IL_127:
				num = (short)558232788;
				short num4 = num;
				num = (short)1045034196;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_112;
				default:
					num = (short)375652352;
					if (num != 0)
					{
					}
					result = false;
					break;
				}
			}
			return result;
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00013978 File Offset: 0x00011B78
		public unsafe int ReadFileAsyn(global::System.IntPtr hFile, byte[] lpBuffer, uint offset, uint nNumberOfBytesToRead, global::System.IntPtr lpOverlapped, uint waitTime)
		{
			short num = (short)1174077440;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_93;
				}
				bool flag;
				uint num3;
				bool flag2;
				byte[] array;
				uint num5;
				int num7;
				for (;;)
				{
					IL_28:
					byte* a_;
					switch (num2)
					{
					case 0:
						num = (short)1501036548;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (flag)
						{
							num = (short)1367736340;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_281;
					case 2:
						goto IL_2FD;
					case 3:
						goto IL_281;
					case 4:
						if (num3 >= waitTime)
						{
							num = (short)1752236050;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_354;
					case 5:
						goto IL_27C;
					case 6:
						num = (short)574881816;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						if (!flag2 && flag)
						{
							num = (short)1147469824;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_45D;
					case 8:
						if (!flag2)
						{
							num = (short)1758199814;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_354;
					case 9:
					{
						num = (short)1497300992;
						short num4 = num;
						if (flag)
						{
							num = (short)1814495246;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_452;
					}
					case 10:
						num = (short)923992073;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						goto IL_133;
					case 12:
						goto IL_338;
					case 13:
						goto IL_197;
					case 14:
						goto IL_23F;
					case 15:
						if (array.Length == 0)
						{
							num = (short)1310588941;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						a_ = &array[0];
						num = (short)1597374475;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						if (num5 == 0U)
						{
							num = (short)414580748;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)979828757;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						goto IL_3A0;
					case 18:
						goto IL_45D;
					case 19:
						if (!flag2)
						{
							num = (short)409993226;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1812463632;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						global::System.Threading.Thread.Sleep(10);
						num3 += 10U;
						num = (short)59899907;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
					{
						if (num5 > nNumberOfBytesToRead)
						{
							num = (short)1643708421;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1710369611;
						short num6 = num;
						num = (short)31402827;
						switch ((num6 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_3A0;
						default:
							goto IL_4CE;
						}
						break;
					}
					case 22:
						goto IL_133;
					case 23:
						fixed (byte[] array = lpBuffer)
						{
							if (lpBuffer != null)
							{
								num = (short)1519321105;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_197;
							break;
						}
					case 24:
						if ((long)num7 != 997L)
						{
							num = (short)1152581634;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_354;
					}
					goto IL_93;
					IL_133:
					flag2 = this.a(hFile, a_, offset, nNumberOfBytesToRead, lpOverlapped, ref num7);
					num = (short)1781071880;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_197:
					num = (short)28049409;
					if (num != 0)
					{
					}
					a_ = null;
					num = (short)672661526;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_281:
					num = (short)827785223;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_354:
					flag2 = this.WrapperGetOverlappedResult(hFile, lpOverlapped, ref num5, true, ref flag);
					num = (short)1279328257;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3A0:
					num = (short)1426718735;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_45D:
					num = (short)1130889235;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_23F:
				this.b = "Waiting for GetOverlappedResult in read operation got time-out result!";
				throw new global::System.TimeoutException(this.b);
				IL_27C:
				this.b = "Read more data than expected, this maybe cause buffer overflow!";
				throw new global::System.Exception(this.b);
				IL_2FD:
				this.b = "Write operation got failed result, the last win32 error code is :" + global::System.Convert.ToString(num7);
				throw new global::System.Exception(this.b);
				IL_338:
				this.b = "receive zero length packet after a period of waitting ,treat as time-out occured";
				throw new global::System.TimeoutException(this.b);
				IL_452:
				throw new global::System.Exception("Failed to get overlapped result in read operation, the last win32 error code had been logged");
				IL_4CE:
				num = (short)1923678208;
				if (num != 0)
				{
				}
				array = null;
				return (int)num5;
				IL_93:
				flag2 = true;
				flag = false;
				num7 = 0;
				num5 = 0U;
				num3 = 0U;
				num = (short)1389821975;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00013E70 File Offset: 0x00012070
		public bool WrapperSetCommMask(global::System.IntPtr handle, global::Motorola.Common.Communication.CommonUtil.NativeMethods.CommEventFlags dwEvtMask)
		{
			short num = (short)1365568899;
			short num2 = num;
			num = (short)1609100675;
			bool result;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1220214784;
				if (num != 0)
				{
				}
				result = true;
				try
				{
					num = (short)1920466946;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							goto IL_10E;
						case 1:
						{
							global::System.ComponentModel.Win32Exception ex = new global::System.ComponentModel.Win32Exception(global::System.Runtime.InteropServices.Marshal.GetLastWin32Error());
							this.b = "SetCommMask last win32 error message is: " + ex.Message;
							num = (short)66977796;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							switch (0)
							{
							case 0:
								goto IL_91;
							}
							continue;
						case 3:
							global::Motorola.Common.Communication.CommonUtil.TransportLogger.WriteInfo(this.a, this.b);
							num = (short)1988296704;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							if (!string.IsNullOrEmpty(this.a))
							{
								num = (short)1599406083;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_10E;
						case 5:
							goto IL_155;
						case 6:
							goto IL_16D;
						}
						IL_91:
						if (global::Motorola.Common.Communication.CommonUtil.NativeMethods.SetCommMask(handle, (uint)dwEvtMask) == 0)
						{
							num = (short)2009792513;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_155;
						IL_10E:
						result = false;
						num = (short)118489093;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_155:
						num = (short)1799487494;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_16D:;
				}
				catch (global::System.Exception ex2)
				{
					this.b = "Exception found when invoking ---SetCommMask ---" + ex2.Message;
					if (!string.IsNullOrEmpty(this.a))
					{
						global::Motorola.Common.Communication.CommonUtil.TransportLogger.WriteInfo(this.a, this.b);
					}
					result = false;
				}
				break;
			}
			num = (short)1400897536;
			short num4 = num;
			num = (short)34668545;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00014098 File Offset: 0x00012298
		public bool WrapperGetCommModemStatus(global::System.IntPtr hFile, ref uint lpModemStat)
		{
			short num = (short)1997930496;
			short num2 = num;
			num = (short)1659397373;
			short num3 = num;
			num = (short)175793405;
			bool result;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)882114560;
				if (num != 0)
				{
				}
				result = true;
				try
				{
					num = (short)1665400834;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							goto IL_136;
						case 1:
						{
							global::System.ComponentModel.Win32Exception ex = new global::System.ComponentModel.Win32Exception(global::System.Runtime.InteropServices.Marshal.GetLastWin32Error());
							this.b = "GetCommModemStatus last win32 error message is: " + ex.Message;
							num = (short)1660157956;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							switch (0)
							{
							case 0:
								goto IL_B7;
							}
							continue;
						case 3:
							global::Motorola.Common.Communication.CommonUtil.TransportLogger.WriteInfo(this.a, this.b);
							num = (short)279642112;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							if (!string.IsNullOrEmpty(this.a))
							{
								num = (short)1723858947;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_136;
						case 5:
							goto IL_17D;
						case 6:
							goto IL_195;
						}
						IL_B7:
						if (global::Motorola.Common.Communication.CommonUtil.NativeMethods.GetCommModemStatus(hFile, ref lpModemStat) == 0)
						{
							num = (short)1370030081;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_17D;
						IL_136:
						result = false;
						num = (short)108789765;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_17D:
						num = (short)693370886;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_195:;
				}
				catch (global::System.Exception ex2)
				{
					this.b = "Exception found when invoking ---GetCommModemStatus ---" + ex2.Message;
					if (!string.IsNullOrEmpty(this.a))
					{
						global::Motorola.Common.Communication.CommonUtil.TransportLogger.WriteInfo(this.a, this.b);
					}
					num = (short)721944577;
					if (num != 0)
					{
					}
					result = false;
				}
				break;
			}
			return result;
		}

		// Token: 0x0600013E RID: 318 RVA: 0x000142C0 File Offset: 0x000124C0
		public bool WrapperClearCommError(global::System.IntPtr hFile, ref uint lpErrors, ref global::Motorola.Common.Communication.CommonUtil.NativeMethods.CommStat lpStat)
		{
			short num = (short)926760792;
			short num2 = num;
			num = (short)747978584;
			bool result;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1677197313;
				if (num != 0)
				{
				}
				num = (short)1764294656;
				if (num != 0)
				{
				}
				num = (short)735313920;
				short num3 = num;
				result = true;
				try
				{
					num = (short)134414338;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							goto IL_15E;
						case 1:
						{
							global::System.ComponentModel.Win32Exception ex = new global::System.ComponentModel.Win32Exception(global::System.Runtime.InteropServices.Marshal.GetLastWin32Error());
							this.b = "ClearCommError last win32 error message is: " + ex.Message;
							num = (short)895352836;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							switch (0)
							{
							case 0:
								goto IL_DF;
							}
							continue;
						case 3:
							global::Motorola.Common.Communication.CommonUtil.TransportLogger.WriteInfo(this.a, this.b);
							num = (short)1779236864;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							if (!string.IsNullOrEmpty(this.a))
							{
								num = (short)1701183491;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_15E;
						case 5:
							goto IL_1A5;
						case 6:
							goto IL_1BC;
						}
						IL_DF:
						if (global::Motorola.Common.Communication.CommonUtil.NativeMethods.ClearCommError(hFile, ref lpErrors, ref lpStat) == 0)
						{
							num = (short)913047553;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1A5;
						IL_15E:
						result = false;
						num = (short)722927621;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_1A5:
						num = (short)1893859334;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_1BC:;
				}
				catch (global::System.Exception ex2)
				{
					this.b = "Exception found when invoking ---ClearCommError ---" + ex2.Message;
					if (!string.IsNullOrEmpty(this.a))
					{
						global::Motorola.Common.Communication.CommonUtil.TransportLogger.WriteInfo(this.a, this.b);
					}
					result = false;
				}
				break;
			}
			}
			return result;
		}

		// Token: 0x0600013F RID: 319 RVA: 0x000144E8 File Offset: 0x000126E8
		public bool WrapperCreateFile(string lpFileName, uint dwDesiredAccess, uint dwShareMode, uint dwCreationDisposition, uint dwFlagsAndAttributes, ref global::System.IntPtr fileHandle)
		{
			short num = (short)1593640906;
			short num2 = num;
			num = (short)1645086666;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1023868928;
				if (num != 0)
				{
				}
				num = (short)1070465025;
				if (num != 0)
				{
				}
				num = (short)506658816;
				int num3 = (int)num;
				switch (num3)
				{
				}
				break;
			}
			}
			num = (short)1262616576;
			short num4 = num;
			bool result = true;
			try
			{
				switch (0)
				{
				case 0:
					goto IL_10A;
				}
				int num3;
				int lastWin32Error;
				for (;;)
				{
					IL_CB:
					switch (num3)
					{
					case 0:
					{
						bool flag = true;
						num = (short)1100808205;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						global::System.Threading.Thread.Sleep(1000);
						fileHandle = global::Motorola.Common.Communication.CommonUtil.NativeMethods.CreateFile(lpFileName, dwDesiredAccess, dwShareMode, global::System.IntPtr.Zero, dwCreationDisposition, dwFlagsAndAttributes, global::System.IntPtr.Zero);
						num = (short)1290534919;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (!string.IsNullOrEmpty(this.a))
						{
							num = (short)585433096;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2A5;
					case 3:
					{
						bool flag;
						if (!flag)
						{
							num = (short)1281294341;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_316;
					}
					case 4:
						goto IL_2A5;
					case 5:
					{
						global::System.ComponentModel.Win32Exception ex = new global::System.ComponentModel.Win32Exception(lastWin32Error);
						this.b = "CreateFile last win32 error message is: " + ex.Message;
						num = (short)344719362;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						if (fileHandle.ToInt64() == -1L)
						{
							num = (short)906428425;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_316;
					case 7:
						if (fileHandle.ToInt64() != -1L)
						{
							num = (short)1175257088;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2C1;
					case 8:
						global::Motorola.Common.Communication.CommonUtil.TransportLogger.WriteInfo(this.a, this.b);
						num = (short)1058078724;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
					{
						bool flag = false;
						num = (short)928972811;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						goto IL_32E;
					case 11:
						if (lastWin32Error == this.c)
						{
							num = (short)1597702145;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2C1;
					case 12:
						goto IL_316;
					case 13:
						goto IL_2C1;
					}
					goto IL_10A;
					IL_2A5:
					result = false;
					num = (short)1986658316;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_2C1:
					num = (short)914030595;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_316:
					num = (short)650903562;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_32E:
				return result;
				IL_10A:
				fileHandle = global::Motorola.Common.Communication.CommonUtil.NativeMethods.CreateFile(lpFileName, dwDesiredAccess, dwShareMode, global::System.IntPtr.Zero, dwCreationDisposition, dwFlagsAndAttributes, global::System.IntPtr.Zero);
				lastWin32Error = global::System.Runtime.InteropServices.Marshal.GetLastWin32Error();
				num = (short)16711686;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_CB;
			}
			catch (global::System.Exception ex2)
			{
				this.b = "Exception found when invoking ---CreateFile ---" + ex2.Message;
				if (!string.IsNullOrEmpty(this.a))
				{
					global::Motorola.Common.Communication.CommonUtil.TransportLogger.WriteInfo(this.a, this.b);
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06000140 RID: 320 RVA: 0x00014884 File Offset: 0x00012A84
		public bool WrapperWaitCommEvent(global::System.IntPtr hFile, ref uint lpEvtMask, ref global::Motorola.Common.Communication.CommonUtil.NativeMethods.OVERLAPPED lpOverlapped, ref int lastWin32Error)
		{
			short num = (short)2033166497;
			short num2 = num;
			num = (short)2057742497;
			bool result;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)167378945;
				if (num != 0)
				{
				}
				num = (short)1346830336;
				if (num != 0)
				{
				}
				num = (short)1580335104;
				short num3 = num;
				result = true;
				try
				{
					num = (short)1156907009;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							lastWin32Error = global::System.Runtime.InteropServices.Marshal.GetLastWin32Error();
							result = false;
							num = (short)301334530;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_D2;
							}
							continue;
						case 2:
							goto IL_114;
						case 3:
							goto IL_128;
						}
						IL_D2:
						if (global::Motorola.Common.Communication.CommonUtil.NativeMethods.WaitCommEvent(hFile, ref lpEvtMask, ref lpOverlapped) == 0)
						{
							num = (short)826277888;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_114:
						num = (short)1289420803;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_128:;
				}
				catch (global::System.Exception ex)
				{
					this.b = "Exception found when invoking ---WaitCommEvent ---" + ex.Message;
					if (!string.IsNullOrEmpty(this.a))
					{
						global::Motorola.Common.Communication.CommonUtil.TransportLogger.WriteInfo(this.a, this.b);
					}
					result = false;
				}
				break;
			}
			}
			return result;
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00014A0C File Offset: 0x00012C0C
		public bool WrapperGetCommProperties(global::System.IntPtr hFile, ref global::Motorola.Common.Communication.CommonUtil.NativeMethods.COMMPROP commProp)
		{
			short num = (short)762249216;
			short num2 = num;
			num = (short)62716527;
			short num3 = num;
			num = (short)260766319;
			bool result;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)692060160;
				if (num != 0)
				{
				}
				result = true;
				try
				{
					num = (short)2072444930;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							goto IL_137;
						case 1:
						{
							global::System.ComponentModel.Win32Exception ex = new global::System.ComponentModel.Win32Exception(global::System.Runtime.InteropServices.Marshal.GetLastWin32Error());
							this.b = "GetCommProperties last win32 error message is: " + ex.Message;
							num = (short)1402732548;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							switch (0)
							{
							case 0:
								goto IL_B9;
							}
							continue;
						case 3:
							global::Motorola.Common.Communication.CommonUtil.TransportLogger.WriteInfo(this.a, this.b);
							num = (short)355860480;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							if (!string.IsNullOrEmpty(this.a))
							{
								num = (short)1012531203;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_137;
						case 5:
							goto IL_17C;
						case 6:
							goto IL_193;
						}
						IL_B9:
						if (global::Motorola.Common.Communication.CommonUtil.NativeMethods.GetCommProperties(hFile, ref commProp) == 0)
						{
							num = (short)1030422529;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_17C;
						IL_137:
						result = false;
						num = (short)100794373;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_17C:
						num = (short)365232134;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_193:;
				}
				catch (global::System.Exception ex2)
				{
					this.b = "Exception found when invoking ---GetCommProperties ---" + ex2.Message;
					if (!string.IsNullOrEmpty(this.a))
					{
						global::Motorola.Common.Communication.CommonUtil.TransportLogger.WriteInfo(this.a, this.b);
					}
					num = (short)279445505;
					if (num != 0)
					{
					}
					result = false;
				}
				break;
			}
			return result;
		}

		// Token: 0x06000142 RID: 322 RVA: 0x00014C30 File Offset: 0x00012E30
		public bool WrapperGetOverlappedResult(global::System.IntPtr hFile, global::System.IntPtr lpOverlapped, ref uint lpNumberOfBytesTransferred, bool bWait, ref bool bPending)
		{
			short num = (short)596443136;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_3F;
				}
				int a_;
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
						a_ = 1;
						num = (short)951517187;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (bWait)
						{
							num = (short)2031681536;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2D6;
					case 2:
						goto IL_2EF;
					case 3:
						goto IL_30F;
					}
					goto IL_3F;
				}
				IL_2EF:
				bool result;
				try
				{
					num = (short)562561029;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
						{
							int lastWin32Error;
							if (lastWin32Error == 996)
							{
								num = (short)2123890695;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.ComponentModel.Win32Exception ex = new global::System.ComponentModel.Win32Exception(lastWin32Error);
							this.b = "GetOverlappedResult last win32 error message is: " + ex.Message;
							num = (short)819724296;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
							global::Motorola.Common.Communication.CommonUtil.TransportLogger.WriteInfo(this.a, this.b);
							num = (short)498597892;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_1D9;
						case 3:
						{
							int lastWin32Error = global::System.Runtime.InteropServices.Marshal.GetLastWin32Error();
							num = (short)634322944;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
							goto IL_1D9;
						case 5:
							switch (0)
							{
							case 0:
								goto IL_144;
							}
							continue;
						case 6:
							goto IL_279;
						case 7:
							bPending = true;
							num = (short)1085341698;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
							if (!string.IsNullOrEmpty(this.a))
							{
								num = (short)438173697;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1D9;
						case 9:
							goto IL_292;
						}
						IL_144:
						if (global::Motorola.Common.Communication.CommonUtil.NativeMethods.GetOverlappedResult(hFile, lpOverlapped, ref lpNumberOfBytesTransferred, a_) == 0)
						{
							num = (short)1708261379;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_279;
						IL_1D9:
						result = false;
						num = (short)704839686;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_279:
						num = (short)749142025;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_292:
					return result;
				}
				catch (global::System.Exception ex2)
				{
					this.b = "Exception found when invoking ---GetOverlappedResult ---" + ex2.Message;
					if (!string.IsNullOrEmpty(this.a))
					{
						global::Motorola.Common.Communication.CommonUtil.TransportLogger.WriteInfo(this.a, this.b);
					}
					return false;
				}
				goto IL_2D6;
				IL_30F:
				num = (short)744554497;
				if (num != 0)
				{
				}
				goto IL_2D6;
				IL_3F:
				num = (short)1459945472;
				short num3 = num;
				result = true;
				a_ = 0;
				bPending = false;
				num = (short)616370525;
				short num4 = num;
				num = (short)153555293;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_2D6:
					num = (short)59047938;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_28;
				default:
					num = (short)326041600;
					if (num != 0)
					{
					}
					num = (short)1586167809;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_28;
				}
				break;
			}
			}
		}

		// Token: 0x06000143 RID: 323 RVA: 0x00014F94 File Offset: 0x00013194
		public bool WrapperPurgeComm(global::System.IntPtr hFile, uint purgeFlag)
		{
			short num = (short)1959060798;
			short num2 = num;
			num = (short)1001973054;
			bool result;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1381761025;
				if (num != 0)
				{
				}
				num = (short)1052573696;
				if (num != 0)
				{
				}
				num = (short)1059127296;
				short num3 = num;
				result = true;
				try
				{
					num = (short)1811349506;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							goto IL_161;
						case 1:
						{
							global::System.ComponentModel.Win32Exception ex = new global::System.ComponentModel.Win32Exception(global::System.Runtime.InteropServices.Marshal.GetLastWin32Error());
							this.b = "PurgeComm last win32 error message is: " + ex.Message;
							num = (short)514326532;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							switch (0)
							{
							case 0:
								goto IL_E2;
							}
							continue;
						case 3:
							global::Motorola.Common.Communication.CommonUtil.TransportLogger.WriteInfo(this.a, this.b);
							num = (short)34471936;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							if (!string.IsNullOrEmpty(this.a))
							{
								num = (short)17432579;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_161;
						case 5:
							goto IL_1A6;
						case 6:
							goto IL_1BD;
						}
						IL_E2:
						if (global::Motorola.Common.Communication.CommonUtil.NativeMethods.PurgeComm(hFile, purgeFlag) == 0)
						{
							num = (short)777322497;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1A6;
						IL_161:
						result = false;
						num = (short)1384316933;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_1A6:
						num = (short)76480518;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_1BD:;
				}
				catch (global::System.Exception ex2)
				{
					this.b = "Exception found when invoking ---PurgeComm ---" + ex2.Message;
					if (!string.IsNullOrEmpty(this.a))
					{
						global::Motorola.Common.Communication.CommonUtil.TransportLogger.WriteInfo(this.a, this.b);
					}
					result = false;
				}
				break;
			}
			}
			return result;
		}

		// Token: 0x06000144 RID: 324 RVA: 0x000151BC File Offset: 0x000133BC
		public bool WrapperGetFileType(global::System.IntPtr hFile, ref uint fileType)
		{
			short num = (short)191906241;
			short num2 = num;
			num = (short)2140422593;
			bool result;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)520093696;
				short num3 = num;
				num = (short)1305477120;
				if (num != 0)
				{
				}
				result = true;
				try
				{
					fileType = global::Motorola.Common.Communication.CommonUtil.NativeMethods.GetFileType(hFile);
				}
				catch (global::System.Exception ex)
				{
					this.b = "Exception found when invoking ---GetFileType ---" + ex.Message;
					if (!string.IsNullOrEmpty(this.a))
					{
						global::Motorola.Common.Communication.CommonUtil.TransportLogger.WriteInfo(this.a, this.b);
					}
					result = false;
				}
				break;
			}
			}
			num = (short)381091841;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x06000145 RID: 325 RVA: 0x000152C0 File Offset: 0x000134C0
		public bool Wrapper_CM_Get_DevNode_Status(uint devID, ref uint status)
		{
			short num = (short)851378176;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)1724907521;
				if (num != 0)
				{
				}
				bool result = true;
				int num3 = 0;
				uint num4 = 0U;
				try
				{
					switch (0)
					{
					case 0:
						goto IL_79;
					}
					for (;;)
					{
						IL_56:
						switch (num2)
						{
						case 0:
							this.b = "CM_Get_Parent last win32 error code is: " + num3.ToString();
							this.b += " And the problem number is: ";
							this.b += num4.ToString();
							num = (short)1476198402;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
						{
							num = (short)78540483;
							short num5 = num;
							num = (short)1435791043;
							switch ((num5 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_1E6;
							default:
								num = (short)2114191360;
								if (num != 0)
								{
								}
								global::Motorola.Common.Communication.CommonUtil.TransportLogger.WriteInfo(this.a, this.b);
								num = (short)1558708230;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 2:
							if (!string.IsNullOrEmpty(this.a))
							{
								num = (short)1081868289;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_186;
						case 3:
							goto IL_1E6;
						case 4:
							goto IL_1CD;
						case 5:
							if (num3 != 0)
							{
								num = (short)196608;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1CD;
						case 6:
							goto IL_186;
						}
						goto IL_79;
						IL_186:
						result = false;
						num = (short)1714094084;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_1CD:
						num = (short)379781123;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_1E6:
					goto IL_225;
					IL_79:
					num3 = global::Motorola.Common.Communication.CommonUtil.NativeMethods.CM_Get_DevNode_Status(ref status, ref num4, devID, 0);
					num = (short)439877637;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_56;
				}
				catch (global::System.Exception ex)
				{
					this.b = "Exception found when invoking---CM_Get_DevNode_Status--- " + ex.Message;
					if (!string.IsNullOrEmpty(this.a))
					{
						global::Motorola.Common.Communication.CommonUtil.TransportLogger.WriteInfo(this.a, this.b);
					}
					result = false;
				}
				IL_225:
				num = (short)1055916032;
				short num6 = num;
				return result;
			}
			}
		}

		// Token: 0x06000146 RID: 326 RVA: 0x0001553C File Offset: 0x0001373C
		public bool Wrapper_CM_Request_Device_Eject(uint devID)
		{
			short num = (short)1521287168;
			short num2 = num;
			bool result = true;
			int num3 = 0;
			try
			{
				switch (0)
				{
				case 0:
					goto IL_5A;
				}
				int num4;
				for (;;)
				{
					IL_38:
					switch (num4)
					{
					case 0:
						this.b = "CM_Get_Parent last win32 error code is: " + num3.ToString();
						num = (short)1268383746;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						num = (short)1285327575;
						short num5 = num;
						num = (short)1998949079;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_199;
						default:
							num = (short)183828480;
							if (num != 0)
							{
							}
							global::Motorola.Common.Communication.CommonUtil.TransportLogger.WriteInfo(this.a, this.b);
							num = (short)535363590;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
						if (!string.IsNullOrEmpty(this.a))
						{
							num = (short)695140353;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_13B;
					case 3:
						goto IL_199;
					case 4:
						goto IL_182;
					case 5:
						if (num3 != 0)
						{
							num = (short)37355520;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_182;
					case 6:
						goto IL_13B;
					}
					goto IL_5A;
					IL_13B:
					result = false;
					num = (short)379453444;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_182:
					num = (short)1794899971;
					num4 = (int)((global::System.IntPtr)num);
				}
				IL_199:
				return result;
				IL_5A:
				num3 = global::Motorola.Common.Communication.CommonUtil.NativeMethods.CM_Request_Device_Eject(devID, global::System.UIntPtr.Zero, global::System.UIntPtr.Zero, 0U, 0U);
				num = (short)203948037;
				num4 = (int)((global::System.IntPtr)num);
				goto IL_38;
			}
			catch (global::System.Exception ex)
			{
				this.b = "Exception found when invoking---CM_Request_Device_Eject--- " + ex.Message;
				if (!string.IsNullOrEmpty(this.a))
				{
					global::Motorola.Common.Communication.CommonUtil.TransportLogger.WriteInfo(this.a, this.b);
				}
				num = (short)1599668225;
				if (num != 0)
				{
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06000147 RID: 327 RVA: 0x00015768 File Offset: 0x00013968
		public bool Wrapper_DeviceIoControl(global::System.IntPtr hDevice, uint dwIoControlCode, global::System.IntPtr lpInBuffer, uint nInBufferSize, global::System.IntPtr lpOutBuffer, uint nOutBufferSize, out uint lpBytesReturned, global::System.IntPtr lpOverlapped)
		{
			short num = (short)339804160;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_43;
				}
				bool flag;
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
					{
						flag = false;
						string message = "Wrapper_DeviceIoControl: Invalid Device Handle";
						global::Motorola.Common.LogUtility.LogManager.GetLogger("Communication_Logger").Error(message);
						num = (short)152567809;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						goto IL_5D9;
					case 2:
						if (flag)
						{
							num = (short)2133721092;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 3:
						num = (short)1545142273;
						if (num != 0)
						{
						}
						if (hDevice == global::System.IntPtr.Zero)
						{
							num = (short)115933184;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5D9;
					case 4:
						try
						{
							switch (0)
							{
							case 0:
								goto IL_155;
							}
							int lastWin32Error;
							global::System.ComponentModel.Win32Exception ex;
							global::System.ComponentModel.Win32Exception ex2;
							for (;;)
							{
								IL_E6:
								switch (num2)
								{
								case 0:
									if (!flag)
									{
										num = (short)145031179;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_57D;
								case 1:
									goto IL_2D3;
								case 2:
									num = (short)2099904525;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									if ((long)lastWin32Error != 997L)
									{
										num = (short)2101608454;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									flag = true;
									num = (short)408354820;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									goto IL_44C;
								case 5:
									if (lpOverlapped == global::System.IntPtr.Zero)
									{
										num = (short)1491075086;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_44C;
								case 6:
									goto IL_575;
								case 7:
									if (!flag)
									{
										num = (short)35323912;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_44C;
								case 8:
									num = (short)1995898885;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
								{
									bool flag2 = false;
									flag = this.WrapperGetOverlappedResult(hDevice, lpOverlapped, ref lpBytesReturned, true, ref flag2);
									num = (short)500498432;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 10:
									if (!string.IsNullOrEmpty(this.a))
									{
										num = (short)1538785303;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_57A;
								case 11:
									num = (short)653852688;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 12:
									num = (short)12845059;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 13:
									if (lpOverlapped != global::System.IntPtr.Zero)
									{
										num = (short)970719241;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_57D;
								case 14:
								{
									ex = new global::System.ComponentModel.Win32Exception(lastWin32Error);
									this.b = "PurgeComm last win32 error message is: " + ex.Message;
									num = (short)70608825;
									short num3 = num;
									num = (short)838100921;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_575;
									default:
										num = (short)1386086400;
										if (num != 0)
										{
										}
										num = (short)43712522;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 15:
									goto IL_297;
								case 16:
								{
									bool flag2;
									if (flag2)
									{
										num = (short)1204748289;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2D5;
								}
								case 17:
									goto IL_395;
								case 18:
									if (lpOverlapped != global::System.IntPtr.Zero)
									{
										num = (short)728498188;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2EC;
								case 19:
									num = (short)1641086994;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 20:
									if (!string.IsNullOrEmpty(this.a))
									{
										num = (short)928317464;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_29C;
								case 21:
									goto IL_595;
								case 22:
									if (!flag)
									{
										num = (short)1545601043;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2EC;
								case 23:
									global::Motorola.Common.Communication.CommonUtil.TransportLogger.WriteInfo(this.a, this.b);
									num = (short)1472987151;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 24:
									global::Motorola.Common.Communication.CommonUtil.TransportLogger.WriteInfo(this.a, this.b);
									num = (short)2111504401;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 25:
									if (flag)
									{
										num = (short)1093140482;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_57D;
								}
								goto IL_155;
								IL_2EC:
								num = (short)1863254023;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_44C:
								num = (short)778567705;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_575:
								ex2 = new global::System.ComponentModel.Win32Exception(lastWin32Error);
								this.b = "PurgeComm last win32 error message is: " + ex2.Message;
								num = (short)1751973908;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_57D:
								num = (short)911081493;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_297:
							goto IL_57A;
							IL_29C:
							throw ex2;
							IL_2D3:
							this.b = "Waiting for GetOverlappedResult in DeviceIoControl operation got time-out result!";
							throw new global::System.TimeoutException(this.b);
							IL_2D5:
							this.b = "Failed to get overlapped result in DeviceIoControl operation, the last win32 error code had been logged";
							throw new global::System.Exception(this.b);
							IL_395:
							goto IL_29C;
							IL_57A:
							throw ex;
							IL_595:
							return flag;
							IL_155:
							flag = global::Motorola.Common.Communication.CommonUtil.NativeMethods.DeviceIoControl(hDevice, dwIoControlCode, lpInBuffer, nInBufferSize, lpOutBuffer, nOutBufferSize, out lpBytesReturned, lpOverlapped);
							lastWin32Error = global::System.Runtime.InteropServices.Marshal.GetLastWin32Error();
							num = (short)824967190;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_E6;
						}
						catch (global::System.Exception ex3)
						{
							this.b = "Exception found when invoking ---Wrapper_DeviceIoControl ---" + ex3.Message;
							if (!string.IsNullOrEmpty(this.a))
							{
								global::Motorola.Common.Communication.CommonUtil.TransportLogger.WriteInfo(this.a, this.b);
							}
							flag = false;
							throw;
						}
						goto IL_5D9;
					}
					goto IL_43;
					IL_5D9:
					num = (short)1966931970;
					num2 = (int)((global::System.IntPtr)num);
				}
				return flag;
				IL_43:
				flag = true;
				lpBytesReturned = 0U;
				num = (short)1901199360;
				short num4 = num;
				num = (short)519962627;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06000148 RID: 328 RVA: 0x00015DD8 File Offset: 0x00013FD8
		public bool Wrapper_IsWow64Process(out bool bWow64Process)
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
					num2 = (short)1040711681;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					if (global::System.Environment.OSVersion.Version.Minor < 1)
					{
						num2 = (short)456916996;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_71;
				case 2:
					goto IL_86;
				case 3:
					goto IL_71;
				case 4:
				{
					num2 = (short)1141440512;
					short num3 = num2;
					goto IL_124;
				}
				case 5:
					if (global::System.Environment.OSVersion.Version.Major == 5)
					{
						num2 = (short)449445888;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_124;
				case 6:
					if (global::System.Environment.OSVersion.Version.Major > 5)
					{
						num2 = (short)1514602499;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_F7;
				}
				goto IL_2C;
				IL_71:
				num2 = (short)33357826;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_124:
				num2 = (short)1869348870;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_86:
			bool flag;
			try
			{
				switch (0)
				{
				case 0:
					goto IL_198;
				}
				for (;;)
				{
					IL_176:
					switch (num)
					{
					case 0:
					{
						global::System.ComponentModel.Win32Exception ex = new global::System.ComponentModel.Win32Exception(global::System.Runtime.InteropServices.Marshal.GetLastWin32Error());
						this.b = "IsWow64Process last win32 error message is: " + ex.Message;
						num2 = (short)2126839812;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 1:
						goto IL_1DC;
					case 2:
						goto IL_2D2;
					case 3:
						goto IL_2EA;
					case 4:
						if (!string.IsNullOrEmpty(this.a))
						{
							num2 = (short)1716191238;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_1DC;
					case 5:
						if (!flag)
						{
							num2 = (short)803340288;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_2D2;
					case 6:
					{
						global::Motorola.Common.Communication.CommonUtil.TransportLogger.WriteInfo(this.a, this.b);
						num2 = (short)397376741;
						short num4 = num2;
						num2 = (short)876903653;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_2EA;
						default:
							num2 = (short)1594818560;
							if (num2 != 0)
							{
							}
							num2 = (short)93061121;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					}
					goto IL_198;
					IL_1DC:
					flag = false;
					num2 = (short)2130903042;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_2D2:
					num2 = (short)1955135491;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_2EA:
				return flag;
				IL_198:
				flag = global::Motorola.Common.Communication.CommonUtil.NativeMethods.IsWow64Process(global::System.Diagnostics.Process.GetCurrentProcess().Handle, out bWow64Process);
				num2 = (short)1320943621;
				num = (int)((global::System.IntPtr)num2);
				goto IL_176;
			}
			catch (global::System.Exception ex2)
			{
				this.b = "Exception found when invoking---IsWow64Process--- " + ex2.Message;
				if (!string.IsNullOrEmpty(this.a))
				{
					global::Motorola.Common.Communication.CommonUtil.TransportLogger.WriteInfo(this.a, this.b);
				}
				flag = false;
			}
			return flag;
			IL_F7:
			num2 = (short)1637679105;
			if (num2 != 0)
			{
			}
			bWow64Process = false;
			flag = true;
			return flag;
			IL_2C:
			flag = true;
			bWow64Process = false;
			num2 = (short)1397358597;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000149 RID: 329 RVA: 0x0001612C File Offset: 0x0001432C
		public bool Wrapper_SetupDiClassGuidsFromName(string className, out global::System.Guid[] classGuidArray)
		{
			short num = (short)213319680;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)1919025153;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_71;
				}
				bool flag;
				int num5;
				int num8;
				global::System.IntPtr intPtr;
				for (;;)
				{
					IL_4E:
					switch (num2)
					{
					case 0:
					{
						flag = false;
						this.b = "Wrapper_SetupDiClassGuidsFromName: Input class name is null";
						num = (short)1708064768;
						short num3 = num;
						num = (short)102825988;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						try
						{
							switch (0)
							{
							case 0:
								goto IL_134;
							}
							global::System.ComponentModel.Win32Exception ex;
							for (;;)
							{
								IL_C5:
								switch (num2)
								{
								case 0:
									global::Motorola.Common.Communication.CommonUtil.TransportLogger.WriteInfo(this.a, this.b);
									num = (short)1653014530;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
								{
									int num4;
									if (num4 >= num5)
									{
										num = (short)1018626055;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									int num6 = 0;
									num = (short)1120600084;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									goto IL_1E2;
								case 3:
									if (num5 >= 1)
									{
										num = (short)1500971014;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_525;
								case 4:
									goto IL_346;
								case 5:
									goto IL_29F;
								case 6:
								{
									int num7 = 0;
									byte[] array = new byte[num8];
									classGuidArray = new global::System.Guid[num5];
									int num4 = 0;
									num = (short)269287449;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
									goto IL_525;
								case 8:
									if (!flag)
									{
										num = (short)96469010;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1E2;
								case 9:
									num = (short)1218183171;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 10:
									if (!string.IsNullOrEmpty(this.a))
									{
										num = (short)1549205527;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_21F;
								case 11:
									goto IL_222;
								case 12:
								{
									int lastWin32Error;
									if (lastWin32Error != 122)
									{
										num = (short)264110097;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Runtime.InteropServices.Marshal.FreeHGlobal(intPtr);
									intPtr = global::System.Runtime.InteropServices.Marshal.AllocHGlobal(num8 * num5);
									flag = global::Motorola.Common.Communication.CommonUtil.NativeMethods.SetupDiClassGuidsFromName(className, intPtr, num5, out num5);
									num = (short)2091909125;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 13:
									if (flag)
									{
										num = (short)1553924105;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_525;
								case 14:
									if (!string.IsNullOrEmpty(this.a))
									{
										num = (short)1772027904;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1E2;
								case 15:
								{
									int num6;
									if (num6 >= num8)
									{
										num = (short)570294288;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									int num7;
									byte[] array;
									array[num6] = global::System.Runtime.InteropServices.Marshal.ReadByte(intPtr, num7);
									num7++;
									num6++;
									num = (short)1550319627;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 16:
								{
									int num4;
									byte[] array;
									classGuidArray[num4] = new global::System.Guid(array);
									num4++;
									num = (short)679018520;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 17:
								{
									int lastWin32Error;
									ex = new global::System.ComponentModel.Win32Exception(lastWin32Error);
									this.b = "SetupDiClassGuidsFromName last win32 error message is: " + ex.Message;
									num = (short)899743754;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 18:
								{
									global::System.ComponentModel.Win32Exception ex2 = new global::System.ComponentModel.Win32Exception(global::System.Runtime.InteropServices.Marshal.GetLastWin32Error());
									this.b = "SetupDiClassGuidsFromName last win32 error message is: " + ex2.Message;
									num = (short)2135949326;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 19:
								{
									int lastWin32Error = global::System.Runtime.InteropServices.Marshal.GetLastWin32Error();
									num = (short)1440350220;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 20:
									goto IL_222;
								case 21:
									goto IL_53D;
								case 22:
									if (!flag)
									{
										num = (short)2011758611;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_29F;
								case 23:
									global::Motorola.Common.Communication.CommonUtil.TransportLogger.WriteInfo(this.a, this.b);
									num = (short)767361028;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 24:
									goto IL_261;
								case 25:
									goto IL_261;
								}
								goto IL_134;
								IL_1E2:
								num = (short)878313485;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_222:
								num = (short)2037055503;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_261:
								num = (short)1008664577;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_29F:
								num = (short)158466056;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_525:
								num = (short)1073152021;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_21F:
							throw ex;
							IL_346:
							goto IL_21F;
							IL_53D:
							return flag;
							IL_134:
							num8 = global::System.Runtime.InteropServices.Marshal.SizeOf(typeof(global::Motorola.Common.Communication.CommonUtil.NativeMethods.My_GUID));
							intPtr = global::System.Runtime.InteropServices.Marshal.AllocHGlobal(num8);
							flag = global::Motorola.Common.Communication.CommonUtil.NativeMethods.SetupDiClassGuidsFromName(className, intPtr, 1, out num5);
							num = (short)238092310;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_C5;
						}
						catch (global::System.Exception ex3)
						{
							this.b = "Exception found when invoking ---SetupDiClassGuidsFromName ---" + ex3.Message;
							if (!string.IsNullOrEmpty(this.a))
							{
								global::Motorola.Common.Communication.CommonUtil.TransportLogger.WriteInfo(this.a, this.b);
							}
							return false;
						}
						finally
						{
							num = (short)452198401;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									global::System.Runtime.InteropServices.Marshal.FreeHGlobal(intPtr);
									num = (short)1261568002;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_5B7;
									}
									continue;
								case 2:
									goto IL_643;
								}
								IL_5B7:
								num = (short)1886839541;
								short num9 = num;
								num = (short)1736958709;
								switch ((num9 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									num = (short)818020352;
									if (num != 0)
									{
									}
									if (!(intPtr != global::System.IntPtr.Zero))
									{
										goto IL_645;
									}
									num = (short)405798912;
									num2 = (int)((global::System.IntPtr)num);
									break;
								}
							}
							IL_643:
							IL_645:;
						}
						goto IL_646;
					case 2:
						if (flag)
						{
							num = (short)461438977;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 3:
						goto IL_646;
					case 4:
						if (!string.IsNullOrEmpty(this.a))
						{
							num = (short)679477254;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_646;
					case 5:
						if (string.IsNullOrEmpty(className))
						{
							num = (short)763035648;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_646;
					case 6:
						global::Motorola.Common.Communication.CommonUtil.TransportLogger.WriteInfo(this.a, this.b);
						num = (short)1685913603;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_71;
					IL_646:
					num = (short)1795948546;
					num2 = (int)((global::System.IntPtr)num);
				}
				return flag;
				IL_71:
				flag = true;
				classGuidArray = null;
				num5 = 0;
				intPtr = global::System.IntPtr.Zero;
				num8 = 0;
				num = (short)57016325;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_4E;
			}
			}
		}

		// Token: 0x0600014A RID: 330 RVA: 0x0001689C File Offset: 0x00014A9C
		public bool WrapperSetupDiEnumDeviceInfo(global::System.IntPtr hDevInfo, uint memberIndex, ref global::Motorola.Common.Communication.CommonUtil.NativeMethods.SP_DEVINFO_DATA deviceInfoData)
		{
			bool flag = true;
			short num2;
			try
			{
				switch (0)
				{
				case 0:
					goto IL_30;
				}
				int num;
				for (;;)
				{
					IL_0E:
					switch (num)
					{
					case 0:
						flag = false;
						num2 = (short)1274544130;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 1:
						if (global::System.Runtime.InteropServices.Marshal.GetLastWin32Error() != 122)
						{
							num2 = (short)1090781184;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						flag = true;
						num2 = (short)1695285253;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 2:
						goto IL_12C;
					case 3:
						goto IL_B7;
					case 4:
						goto IL_143;
					case 5:
						goto IL_12C;
					case 6:
					{
						if (flag)
						{
							goto IL_12C;
						}
						num2 = (short)1008395029;
						short num3 = num2;
						num2 = (short)990831381;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_B7;
						default:
							num2 = (short)1014235136;
							if (num2 != 0)
							{
							}
							num2 = (short)244252675;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					}
					goto IL_30;
					IL_B7:
					num2 = (short)1188560897;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_12C:
					num2 = (short)958726148;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_143:
				num2 = (short)2130313217;
				if (num2 != 0)
				{
				}
				goto IL_172;
				IL_30:
				flag = global::Motorola.Common.Communication.CommonUtil.NativeMethods.SetupDiEnumDeviceInfo(hDevInfo, memberIndex, ref deviceInfoData);
				num2 = (short)1072693254;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0E;
			}
			catch (global::System.Exception)
			{
				flag = false;
			}
			IL_172:
			num2 = (short)814612480;
			short num4 = num2;
			return flag;
		}

		// Token: 0x0600014B RID: 331 RVA: 0x00016A64 File Offset: 0x00014C64
		public bool Wrapper_OpenVolume(string driveLetter, ref global::System.IntPtr fileHandle)
		{
			short num = (short)1062404096;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)226426880;
				short num3 = num;
				bool result = true;
				bool result2;
				try
				{
					switch (0)
					{
					case 0:
						goto IL_A6;
					}
					global::Motorola.Common.Communication.CommonUtil.NativeMethods.WinDriveType driveType;
					string a_2;
					for (;;)
					{
						IL_57:
						uint a_;
						int lastWin32Error;
						switch (num2)
						{
						case 0:
						{
							string log = "Wrapper_OpenVolume fail: Invalid drive type.";
							num = (short)115474443;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
							if (fileHandle.ToInt64() == -1L)
							{
								num = (short)1725431822;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_36B;
						case 2:
							goto IL_277;
						case 3:
							if (driveType != global::Motorola.Common.Communication.CommonUtil.NativeMethods.WinDriveType.DRIVE_REMOVABLE)
							{
								num = (short)1473642513;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							a_ = 3221225472U;
							num = (short)1471086596;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							goto IL_180;
						case 5:
							goto IL_294;
						case 6:
						{
							string log;
							global::Motorola.Common.Communication.CommonUtil.TransportLogger.WriteInfo(this.a, log);
							num = (short)404881410;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 7:
							goto IL_180;
						case 8:
						{
							string log2;
							global::Motorola.Common.Communication.CommonUtil.TransportLogger.WriteInfo(this.a, log2);
							num = (short)1115291657;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 9:
							goto IL_1E1;
						case 10:
							goto IL_36B;
						case 11:
							if (!string.IsNullOrEmpty(this.a))
							{
								num = (short)594345990;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_277;
						case 12:
							num = (short)722796545;
							if (num != 0)
							{
							}
							if (driveType != global::Motorola.Common.Communication.CommonUtil.NativeMethods.WinDriveType.DRIVE_CDROM)
							{
								num = (short)644874256;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							a_ = 2147483648U;
							num = (short)1504051207;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 13:
							goto IL_384;
						case 14:
						{
							global::System.ComponentModel.Win32Exception ex = new global::System.ComponentModel.Win32Exception(lastWin32Error);
							string log2 = "Wrapper_OpenVolume fail, last win32 error message is: " + ex.Message;
							num = (short)1311178767;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 15:
							if (!string.IsNullOrEmpty(this.a))
							{
								num = (short)1986527240;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1E1;
						case 16:
							num = (short)525729792;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 17:
							num = (short)164757516;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A6;
						IL_180:
						fileHandle = global::Motorola.Common.Communication.CommonUtil.NativeMethods.CreateFile(a_2, a_, 3U, global::System.IntPtr.Zero, 3U, 0U, global::System.IntPtr.Zero);
						lastWin32Error = global::System.Runtime.InteropServices.Marshal.GetLastWin32Error();
						num = (short)1581056001;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_1E1:
						result = false;
						num = (short)1988427786;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_277:
						result2 = false;
						num = (short)984678405;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_36B:
						num = (short)1028784141;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_294:
					return result2;
					IL_384:
					return result;
					IL_A6:
					string lpRootPathName = string.Format("{0}:\\", driveLetter);
					a_2 = string.Format("\\\\.\\{0}:", driveLetter);
					driveType = (global::Motorola.Common.Communication.CommonUtil.NativeMethods.WinDriveType)global::Motorola.Common.Communication.CommonUtil.NativeMethods.GetDriveType(lpRootPathName);
					num = (short)1354498051;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_57;
				}
				catch (global::System.Exception ex2)
				{
					string log3 = "Exception found when invoking ---Wrapper_OpenVolume ---" + ex2.Message;
					if (string.IsNullOrEmpty(this.a))
					{
						goto IL_3BC;
					}
					IL_3AD:
					global::Motorola.Common.Communication.CommonUtil.TransportLogger.WriteInfo(this.a, log3);
					IL_3BC:
					num = (short)1666202670;
					short num4 = num;
					num = (short)918895662;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_3AD;
					default:
						num = (short)1627717632;
						if (num != 0)
						{
						}
						return false;
					}
				}
				return result2;
			}
			}
		}

		// Token: 0x0600014C RID: 332 RVA: 0x00016EA0 File Offset: 0x000150A0
		public bool Wrapper_LockVolume(global::System.IntPtr hVolume)
		{
			bool result = true;
			short num;
			try
			{
				num = (short)1993080833;
				if (num != 0)
				{
				}
				uint ioControlCode = global::Motorola.Common.Communication.CommonUtil.WinAPIWrapper.GetIoControlCode(9U, 6U, 0U, 0U);
				uint num2;
				result = global::Motorola.Common.Communication.CommonUtil.NativeMethods.DeviceIoControl(hVolume, ioControlCode, global::System.IntPtr.Zero, 0U, global::System.IntPtr.Zero, 0U, out num2, global::System.IntPtr.Zero);
			}
			catch (global::System.Exception ex)
			{
				string log = "Exception found when invoking ---Wrapper_LockVolume ---" + ex.Message;
				if (string.IsNullOrEmpty(this.a))
				{
					goto IL_88;
				}
				IL_79:
				global::Motorola.Common.Communication.CommonUtil.TransportLogger.WriteInfo(this.a, log);
				IL_88:
				num = (short)1855958209;
				short num3 = num;
				num = (short)2031398081;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_79;
				default:
					num = (short)2070478848;
					if (num != 0)
					{
					}
					result = false;
					break;
				}
			}
			num = (short)962854912;
			short num4 = num;
			return result;
		}

		// Token: 0x0600014D RID: 333 RVA: 0x00016FC0 File Offset: 0x000151C0
		public bool Wrapper_DismountVolume(global::System.IntPtr hVolume)
		{
			short num = (short)1642463233;
			if (num != 0)
			{
			}
			bool result = true;
			try
			{
				uint ioControlCode = global::Motorola.Common.Communication.CommonUtil.WinAPIWrapper.GetIoControlCode(9U, 8U, 0U, 0U);
				uint num2;
				result = global::Motorola.Common.Communication.CommonUtil.NativeMethods.DeviceIoControl(hVolume, ioControlCode, global::System.IntPtr.Zero, 0U, global::System.IntPtr.Zero, 0U, out num2, global::System.IntPtr.Zero);
			}
			catch (global::System.Exception ex)
			{
				string log = "Exception found when invoking ---Wrapper_DismountVolume ---" + ex.Message;
				if (string.IsNullOrEmpty(this.a))
				{
					goto IL_86;
				}
				IL_77:
				global::Motorola.Common.Communication.CommonUtil.TransportLogger.WriteInfo(this.a, log);
				IL_86:
				num = (short)298511485;
				short num3 = num;
				num = (short)940043389;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_77;
				default:
					num = (short)1169620992;
					if (num != 0)
					{
					}
					result = false;
					break;
				}
			}
			num = (short)192086016;
			short num4 = num;
			return result;
		}

		// Token: 0x0600014E RID: 334 RVA: 0x000170DC File Offset: 0x000152DC
		public bool Wrapper_PreventRemovalOfVolume(global::System.IntPtr hVolume, bool bPreventRemoval)
		{
			short num = (short)2228225;
			if (num != 0)
			{
			}
			bool result = true;
			global::Motorola.Common.Communication.CommonUtil.NativeMethods.PREVENT_MEDIA_REMOVAL structure = default(global::Motorola.Common.Communication.CommonUtil.NativeMethods.PREVENT_MEDIA_REMOVAL);
			byte preventMediaRemoval;
			if (!bPreventRemoval)
			{
				preventMediaRemoval = 0;
				goto IL_F4;
			}
			IL_EE:
			preventMediaRemoval = 1;
			IL_F4:
			structure.PreventMediaRemoval = preventMediaRemoval;
			global::System.IntPtr intPtr = global::System.IntPtr.Zero;
			int num2 = global::System.Runtime.InteropServices.Marshal.SizeOf(typeof(global::Motorola.Common.Communication.CommonUtil.NativeMethods.PREVENT_MEDIA_REMOVAL));
			intPtr = global::System.Runtime.InteropServices.Marshal.AllocHGlobal(num2);
			global::System.Runtime.InteropServices.Marshal.StructureToPtr<global::Motorola.Common.Communication.CommonUtil.NativeMethods.PREVENT_MEDIA_REMOVAL>(structure, intPtr, false);
			try
			{
				uint ioControlCode = global::Motorola.Common.Communication.CommonUtil.WinAPIWrapper.GetIoControlCode(45U, 513U, 0U, 1U);
				uint num3;
				result = global::Motorola.Common.Communication.CommonUtil.NativeMethods.DeviceIoControl(hVolume, ioControlCode, intPtr, (uint)num2, global::System.IntPtr.Zero, 0U, out num3, global::System.IntPtr.Zero);
				goto IL_125;
			}
			catch (global::System.Exception ex)
			{
				string log = "Exception found when invoking ---Wrapper_PreventRemovalOfVolume ---" + ex.Message;
				if (string.IsNullOrEmpty(this.a))
				{
					goto IL_9E;
				}
				IL_8F:
				global::Motorola.Common.Communication.CommonUtil.TransportLogger.WriteInfo(this.a, log);
				IL_9E:
				num = (short)222464813;
				short num4 = num;
				num = (short)380930861;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_8F;
				default:
					num = (short)1572274176;
					if (num != 0)
					{
					}
					result = false;
					goto IL_125;
				}
			}
			goto IL_EE;
			IL_125:
			num = (short)1857617920;
			short num5 = num;
			return result;
		}

		// Token: 0x0600014F RID: 335 RVA: 0x0001724C File Offset: 0x0001544C
		public bool Wrapper_AutoEjectVolume(global::System.IntPtr hVolume)
		{
			short num = (short)506789889;
			if (num != 0)
			{
			}
			bool result = true;
			try
			{
				uint ioControlCode = global::Motorola.Common.Communication.CommonUtil.WinAPIWrapper.GetIoControlCode(45U, 514U, 0U, 1U);
				uint num2;
				result = global::Motorola.Common.Communication.CommonUtil.NativeMethods.DeviceIoControl(hVolume, ioControlCode, global::System.IntPtr.Zero, 0U, global::System.IntPtr.Zero, 0U, out num2, global::System.IntPtr.Zero);
			}
			catch (global::System.Exception ex)
			{
				string log = "Exception found when invoking ---Wrapper_AutoEjectVolume ---" + ex.Message;
				if (string.IsNullOrEmpty(this.a))
				{
					goto IL_8B;
				}
				IL_7C:
				global::Motorola.Common.Communication.CommonUtil.TransportLogger.WriteInfo(this.a, log);
				IL_8B:
				num = (short)910773275;
				short num3 = num;
				num = (short)1342065691;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_7C;
				default:
					num = (short)1785069568;
					if (num != 0)
					{
					}
					result = false;
					break;
				}
			}
			num = (short)860946432;
			short num4 = num;
			return result;
		}

		// Token: 0x06000150 RID: 336 RVA: 0x00017370 File Offset: 0x00015570
		public static uint GetIoControlCode(uint DeviceType, uint Function, uint Method, uint Access)
		{
			short num = (short)431947777;
			if (num != 0)
			{
			}
			num = (short)404094976;
			short num2 = num;
			num = (short)686710388;
			short num3 = num;
			num = (short)1962368628;
			switch (num3 == num)
			{
			}
			num = (short)1861484544;
			if (num != 0)
			{
			}
			return DeviceType << 16 | Access << 14 | Function << 2 | Method;
		}

		// Token: 0x04000253 RID: 595
		private string a = string.Empty;

		// Token: 0x04000254 RID: 596
		private string b = string.Empty;

		// Token: 0x04000255 RID: 597
		private readonly int c = 5;
	}
}
