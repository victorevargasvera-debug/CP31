using System;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Windows.Data;
using AcpCommonLib;
using Microsoft.Win32;
using PreEmptive.SoS.Runtime;

namespace MackinawCPS
{
	// Token: 0x02000020 RID: 32
	public class RibbonRadioUserDefinedEnabledConverter : global::System.Windows.Data.IMultiValueConverter
	{
		// Token: 0x0600006E RID: 110 RVA: 0x0000D44C File Offset: 0x0000B64C
		private bool SearchMsWord(string version)
		{
			int a_ = 3;
			short num;
			bool result;
			try
			{
				num = (short)265420800;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					switch (0)
					{
					case 0:
						goto IL_54;
					}
					global::Microsoft.Win32.RegistryKey registryKey7;
					for (;;)
					{
						IL_31:
						global::Microsoft.Win32.RegistryKey registryKey;
						switch (num2)
						{
						case 0:
							registryKey = null;
							goto IL_1B4;
						case 1:
							registryKey = null;
							goto IL_1B4;
						case 2:
							goto IL_1CE;
						case 3:
							registryKey = null;
							goto IL_1B4;
						case 4:
							registryKey = null;
							goto IL_1B4;
						case 5:
						{
							global::Microsoft.Win32.RegistryKey registryKey2 = global::Microsoft.Win32.RegistryKey.OpenBaseKey(global::Microsoft.Win32.RegistryHive.LocalMachine, global::Microsoft.Win32.RegistryView.Registry64).OpenSubKey(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("냢ꫤꇦ뷨볪곬뷮듰", a_));
							if (registryKey2 == null)
							{
								num = (short)1694760961;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Microsoft.Win32.RegistryKey registryKey3 = registryKey2.OpenSubKey(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("껢賤蓦鯨蓪黬胮韰蟲", a_));
							if (registryKey3 == null)
							{
								num = (short)989265924;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Microsoft.Win32.RegistryKey registryKey4 = registryKey3.OpenSubKey(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("곢菤臦胨裪裬", a_));
							if (registryKey4 == null)
							{
								num = (short)1548222470;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Microsoft.Win32.RegistryKey registryKey5 = registryKey4.OpenSubKey(version);
							if (registryKey5 == null)
							{
								num = (short)1774977024;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Microsoft.Win32.RegistryKey registryKey6 = registryKey5.OpenSubKey(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("듢諤闦跨", a_));
							if (registryKey6 == null)
							{
								num = (short)630521859;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							registryKey = registryKey6.OpenSubKey(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("ꫢ诤铦鷨諪臬菮ꏰ鳲髴菶", a_));
							goto IL_1B4;
						}
						case 6:
							num = (short)124256257;
							if (num != 0)
							{
							}
							registryKey = null;
							goto IL_1B4;
						}
						goto IL_54;
						IL_1B4:
						registryKey7 = registryKey;
						num = (short)2074017794;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_1CE:
					bool flag;
					try
					{
						num = (short)1690107917;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							global::Microsoft.Win32.RegistryKey registryKey8;
							global::Microsoft.Win32.RegistryKey registryKey9;
							string value4;
							switch (num2)
							{
							case 0:
								try
								{
									num = (short)779943938;
									num2 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										string value;
										switch (num2)
										{
										case 0:
											value = null;
											goto IL_515;
										case 1:
											goto IL_536;
										case 2:
											switch (0)
											{
											case 0:
												goto IL_491;
											}
											continue;
										case 3:
											num = (short)211681280;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 4:
											value = null;
											goto IL_515;
										case 5:
										{
											object value2 = registryKey8.GetValue(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("돢蓤鏦臨", a_));
											if (value2 == null)
											{
												num = (short)75890692;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											value = value2.ToString();
											goto IL_515;
										}
										}
										IL_491:
										if (registryKey8 == null)
										{
											num = (short)874315779;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)2086338565;
										num2 = (int)((global::System.IntPtr)num);
										continue;
										IL_515:
										flag = !string.IsNullOrEmpty(value);
										num = (short)1805385729;
										num2 = (int)((global::System.IntPtr)num);
									}
									IL_536:;
								}
								finally
								{
									num = (short)932970496;
									num2 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										switch (num2)
										{
										case 0:
											switch (0)
											{
											case 0:
												goto IL_56E;
											}
											continue;
										case 1:
											goto IL_5F2;
										case 2:
										{
											((global::System.IDisposable)registryKey8).Dispose();
											num = (short)1670999573;
											short num3 = num;
											num = (short)1576037909;
											switch ((num3 == num) ? 1 : 0)
											{
											case 0:
											case 2:
												continue;
											default:
												num = (short)1360920576;
												if (num != 0)
												{
												}
												num = (short)1632567297;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											break;
										}
										}
										IL_56E:
										if (registryKey8 == null)
										{
											break;
										}
										num = (short)1096613890;
										num2 = (int)((global::System.IntPtr)num);
									}
									IL_5F2:;
								}
								goto IL_5F5;
							case 1:
								goto IL_60F;
							case 2:
								registryKey9 = null;
								goto IL_437;
							case 3:
								registryKey9 = null;
								goto IL_437;
							case 4:
							{
								object value3 = registryKey7.GetValue(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("돢蓤鏦臨", a_));
								if (value3 == null)
								{
									num = (short)1553334278;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								value4 = value3.ToString();
								goto IL_2BB;
							}
							case 5:
								if (!flag)
								{
									num = (short)1324023820;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_5F5;
							case 6:
								value4 = null;
								goto IL_2BB;
							case 7:
								registryKey9 = null;
								goto IL_437;
							case 8:
								registryKey9 = null;
								goto IL_437;
							case 9:
							{
								global::Microsoft.Win32.RegistryKey registryKey10 = global::Microsoft.Win32.RegistryKey.OpenBaseKey(global::Microsoft.Win32.RegistryHive.LocalMachine, global::Microsoft.Win32.RegistryView.Registry32).OpenSubKey(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("냢ꫤꇦ뷨볪곬뷮듰", a_));
								if (registryKey10 == null)
								{
									num = (short)1845493774;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Microsoft.Win32.RegistryKey registryKey11 = registryKey10.OpenSubKey(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("껢賤蓦鯨蓪黬胮韰蟲", a_));
								if (registryKey11 == null)
								{
									num = (short)1453457415;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Microsoft.Win32.RegistryKey registryKey12 = registryKey11.OpenSubKey(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("곢菤臦胨裪裬", a_));
								if (registryKey12 == null)
								{
									num = (short)401080328;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Microsoft.Win32.RegistryKey registryKey13 = registryKey12.OpenSubKey(version);
								if (registryKey13 == null)
								{
									num = (short)953155586;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Microsoft.Win32.RegistryKey registryKey14 = registryKey13.OpenSubKey(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("듢諤闦跨", a_));
								if (registryKey14 == null)
								{
									num = (short)1904738307;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								registryKey9 = registryKey14.OpenSubKey(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("ꫢ诤铦鷨諪臬菮ꏰ鳲髴菶", a_));
								goto IL_437;
							}
							case 10:
								value4 = null;
								goto IL_2BB;
							case 11:
								num = (short)911343626;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 12:
								num = (short)1549467657;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 13:
								switch (0)
								{
								case 0:
									goto IL_233;
								}
								continue;
							case 14:
								registryKey9 = null;
								goto IL_437;
							}
							IL_233:
							if (registryKey7 == null)
							{
								num = (short)799866891;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1685323780;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_2BB:
							flag = !string.IsNullOrEmpty(value4);
							num = (short)692649989;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_437:
							registryKey8 = registryKey9;
							num = (short)1924726784;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_5F5:
							result = flag;
							num = (short)948895745;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_60F:
						break;
					}
					finally
					{
						num = (short)423624704;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_646;
								}
								continue;
							case 1:
								goto IL_67B;
							case 2:
								((global::System.IDisposable)registryKey7).Dispose();
								num = (short)1711931393;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_646:
							if (registryKey7 == null)
							{
								break;
							}
							num = (short)1077805058;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_67B:;
					}
					IL_54:
					flag = false;
					num = (short)1837432837;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_31;
				}
				}
			}
			catch (global::System.Exception ex)
			{
				global::System.Diagnostics.Trace.WriteLine(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("냢胤蛦鯨裪藬ꋮ苰ꓲ髴藶鷸\udbfa觼韾猀昂爄✆栈攊ⴌ樎椐瀒瀔朖洘爚爜焞ഠ̢䀤唦嬨䐪弬ᔮᄰ", a_) + ex.Message);
				result = false;
			}
			num = (short)1040646144;
			short num4 = num;
			return result;
		}

		// Token: 0x0600006F RID: 111 RVA: 0x0000DB74 File Offset: 0x0000BD74
		public object Convert(object[] values, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			switch (0)
			{
			case 0:
				goto IL_44;
			}
			int num;
			short num2;
			bool flag;
			for (;;)
			{
				IL_0A:
				bool flag3;
				bool flag4;
				switch (num)
				{
				case 0:
					num2 = (short)661913610;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					goto IL_11B;
				case 2:
					num2 = (short)1191378948;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					if (values.Length == 2)
					{
						num2 = (short)1940062208;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_29A;
				case 4:
				{
					global::AcpCommonLib.ApplicationMode applicationMode;
					if (applicationMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
					{
						num2 = (short)2126708748;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1324066649;
					short num3 = num2;
					num2 = (short)2069735257;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_E4;
					default:
					{
						num2 = (short)1622016000;
						if (num2 != 0)
						{
						}
						num2 = (short)730333184;
						short num4 = num2;
						num2 = (short)741408776;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 5:
					flag = true;
					num2 = (short)1119158273;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
				{
					global::AcpCommonLib.ApplicationMode applicationMode = (global::AcpCommonLib.ApplicationMode)values[0];
					bool flag2 = (bool)values[1];
					flag3 = global::MackinawCPS.RibbonRadioUserDefinedEnabledConverter.wordVersions.Any(new global::System.Func<string, bool>(this.SearchMsWord));
					num2 = (short)715259911;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 7:
				{
					global::AcpCommonLib.ApplicationMode applicationMode;
					if (applicationMode != global::AcpCommonLib.ApplicationMode.CodeplugConfigurationMode)
					{
						num2 = (short)235470850;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_149;
				}
				case 8:
					flag4 = false;
					goto IL_277;
				case 9:
					flag4 = (bool)values[1];
					goto IL_277;
				case 10:
					if (values[0] is global::AcpCommonLib.ApplicationMode)
					{
						num2 = (short)160694278;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_29A;
				case 11:
					goto IL_FC;
				case 12:
					goto IL_149;
				}
				goto IL_44;
				IL_E4:
				num2 = (short)698548235;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_277:
				if (flag4 && flag3)
				{
					num2 = (short)1754005509;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				flag = false;
				goto IL_E4;
				IL_149:
				num2 = (short)1383661577;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_FC:
			goto IL_29A;
			IL_11B:
			num2 = (short)1085014017;
			if (num2 != 0)
			{
			}
			IL_29A:
			return flag;
			IL_44:
			flag = false;
			num2 = (short)1606615043;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000070 RID: 112 RVA: 0x0000DE24 File Offset: 0x0000C024
		public object[] ConvertBack(object value, global::System.Type[] targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1502281728;
			short num2 = num;
			num = (short)1753793308;
			short num3 = num;
			num = (short)1943323420;
			switch (num3 == num)
			{
			}
			num = (short)1714290689;
			if (num != 0)
			{
			}
			num = (short)1779826688;
			if (num != 0)
			{
			}
			return null;
		}

		// Token: 0x06000072 RID: 114 RVA: 0x0000DEE0 File Offset: 0x0000C0E0
		// Note: this type is marked as 'beforefieldinit'.
		static RibbonRadioUserDefinedEnabledConverter()
		{
			int a_ = 5;
			short num = (short)1009451008;
			short num2 = num;
			num = (short)1089933517;
			short num3 = num;
			num = (short)1307644109;
			switch (num3 == num)
			{
			}
			num = (short)2052915200;
			if (num != 0)
			{
			}
			num = (short)1426063361;
			if (num != 0)
			{
			}
			global::MackinawCPS.RibbonRadioUserDefinedEnabledConverter.wordVersions = new string[]
			{
				global::PreEmptive.SoS.Runtime.FixedLengthStream.b("퓤훦쟨\udbea", a_),
				global::PreEmptive.SoS.Runtime.FixedLengthStream.b("퓤헦쟨\udbea", a_),
				global::PreEmptive.SoS.Runtime.FixedLengthStream.b("퓤폦쟨\udbea", a_),
				global::PreEmptive.SoS.Runtime.FixedLengthStream.b("퓤틦쟨\udbea", a_)
			};
		}

		// Token: 0x04000034 RID: 52
		private static string[] wordVersions;

		// Token: 0x04000035 RID: 53
		[global::System.NonSerialized]
		string VafgnaprSvryq = 32;
	}
}
