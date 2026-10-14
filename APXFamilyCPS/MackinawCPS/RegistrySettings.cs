using System;
using System.Diagnostics;
using Microsoft.Win32;
using PreEmptive.SoS.Runtime;

namespace MackinawCPS
{
	// Token: 0x0200003C RID: 60
	internal sealed class RegistrySettings
	{
		// Token: 0x06000194 RID: 404 RVA: 0x00054854 File Offset: 0x00052A54
		private RegistrySettings()
		{
		}

		// Token: 0x06000195 RID: 405 RVA: 0x00054868 File Offset: 0x00052A68
		internal static string GetStringValue(string keyLocation, string valueName)
		{
			int a_ = 7;
			short num;
			try
			{
				num = (short)196083712;
				switch (num)
				{
				default:
				{
					global::Microsoft.Win32.RegistryKey registryKey = global::Microsoft.Win32.RegistryKey.OpenBaseKey(global::Microsoft.Win32.RegistryHive.LocalMachine, global::Microsoft.Win32.RegistryView.Registry64).OpenSubKey(keyLocation);
					try
					{
						num = (short)237568002;
						int num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
							{
								string result = registryKey.GetValue(valueName).ToString();
								num = (short)1535836161;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 1:
								goto IL_E8;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_78;
								}
								continue;
							case 3:
								goto IL_201;
							case 4:
								try
								{
									num = (short)697368577;
									num2 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										global::Microsoft.Win32.RegistryKey registryKey2;
										switch (num2)
										{
										case 0:
											goto IL_179;
										case 1:
											switch (0)
											{
											case 0:
												goto IL_123;
											}
											continue;
										case 2:
											goto IL_15F;
										case 3:
										{
											string result = registryKey2.GetValue(valueName).ToString();
											num = (short)1820393474;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										}
										IL_123:
										if (registryKey2 != null)
										{
											num = (short)845676547;
											num2 = (int)((global::System.IntPtr)num);
										}
										else
										{
											num = (short)1871708160;
											num2 = (int)((global::System.IntPtr)num);
										}
									}
									IL_15F:
									goto IL_306;
									IL_179:;
								}
								finally
								{
									num = (short)324337664;
									num2 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										global::Microsoft.Win32.RegistryKey registryKey2;
										switch (num2)
										{
										case 0:
											switch (0)
											{
											case 0:
												goto IL_1AF;
											}
											continue;
										case 1:
											goto IL_1E6;
										case 2:
											((global::System.IDisposable)registryKey2).Dispose();
											num = (short)623771649;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										IL_1AF:
										if (registryKey2 == null)
										{
											break;
										}
										num = (short)1631453186;
										num2 = (int)((global::System.IntPtr)num);
									}
									IL_1E6:;
								}
								num = (short)1966997507;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_78:
							if (registryKey != null)
							{
								num = (short)1695875072;
								num2 = (int)((global::System.IntPtr)num);
							}
							else
							{
								global::Microsoft.Win32.RegistryKey registryKey2 = global::Microsoft.Win32.RegistryKey.OpenBaseKey(global::Microsoft.Win32.RegistryHive.LocalMachine, global::Microsoft.Win32.RegistryView.Registry32).OpenSubKey(keyLocation);
								num = (short)1645477892;
								num2 = (int)((global::System.IntPtr)num);
							}
						}
						IL_E8:
						goto IL_306;
						IL_201:;
					}
					finally
					{
						num = (short)1169752064;
						int num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_235;
								}
								continue;
							case 1:
								goto IL_26B;
							case 2:
								((global::System.IDisposable)registryKey).Dispose();
								num = (short)350748673;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_235:
							if (registryKey == null)
							{
								break;
							}
							num = (short)1928069122;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_26B:;
					}
					break;
				}
				}
			}
			catch (global::System.ArgumentNullException ex)
			{
				global::System.Diagnostics.Trace.WriteLine(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("뗦賨質蓬鳮藰臲賴ꓶ鳸迺觼雾漀搂瘄⤆丈渊礌導攐愒簔礖縘䴚簜猞吠䘢Ԥ匦䄨太䠬堮ᄰ刲嬴᜶尸䌺帼娾ㅀ㝂ⱄ⡆❈杊浌⩎⍐⅒㩔╖捘筚", a_) + ex.Message);
			}
			catch (global::System.ObjectDisposedException ex2)
			{
				global::System.Diagnostics.Trace.WriteLine(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("뗦賨質蓬鳮藰臲賴ꓶ鳸迺觼雾漀搂瘄⤆丈渊礌導攐愒簔礖縘䴚簜猞吠䘢Ԥ匦䄨太䠬堮ᄰ刲嬴᜶尸䌺帼娾ㅀ㝂ⱄ⡆❈杊浌⩎⍐⅒㩔╖捘筚", a_) + ex2.Message);
			}
			catch (global::System.Exception ex3)
			{
				global::System.Diagnostics.Trace.WriteLine(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("뗦賨質蓬鳮藰臲賴ꓶ鳸迺觼雾漀搂瘄⤆丈渊礌導攐愒簔礖縘䴚簜猞吠䘢Ԥ匦䄨太䠬堮ᄰ刲嬴᜶尸䌺帼娾ㅀ㝂ⱄ⡆❈杊浌⩎⍐⅒㩔╖捘筚", a_) + ex3.Message);
				throw;
			}
			IL_2D7:
			num = (short)243531776;
			short num3 = num;
			return string.Empty;
			IL_306:
			num = (short)1803133648;
			short num4 = num;
			num = (short)1671209680;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_2D7;
			default:
			{
				num = (short)649461760;
				if (num != 0)
				{
				}
				num = (short)278003713;
				if (num != 0)
				{
				}
				string result;
				return result;
			}
			}
		}

		// Token: 0x06000196 RID: 406 RVA: 0x00054C6C File Offset: 0x00052E6C
		internal static bool IsKeyPresent(string keyLocation)
		{
			int a_ = 19;
			short num;
			try
			{
				num = (short)1717305344;
				switch (num)
				{
				default:
				{
					global::Microsoft.Win32.RegistryKey registryKey = global::Microsoft.Win32.RegistryKey.OpenBaseKey(global::Microsoft.Win32.RegistryHive.LocalMachine, global::Microsoft.Win32.RegistryView.Registry64).OpenSubKey(keyLocation);
					try
					{
						num = (short)1102381058;
						int num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
							{
								bool result = true;
								num = (short)117833729;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 1:
								goto IL_DB;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_79;
								}
								continue;
							case 3:
								goto IL_1ED;
							case 4:
								try
								{
									num = (short)1638531073;
									num2 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										switch (num2)
										{
										case 0:
											goto IL_166;
										case 1:
											switch (0)
											{
											case 0:
												goto IL_117;
											}
											continue;
										case 2:
											goto IL_14A;
										case 3:
										{
											bool result = true;
											num = (short)750452738;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										}
										IL_117:
										global::Microsoft.Win32.RegistryKey registryKey2;
										if (registryKey2 != null)
										{
											num = (short)73859075;
											num2 = (int)((global::System.IntPtr)num);
										}
										else
										{
											num = (short)2133786624;
											num2 = (int)((global::System.IntPtr)num);
										}
									}
									IL_14A:
									goto IL_2F6;
									IL_166:;
								}
								finally
								{
									num = (short)2031681536;
									num2 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										global::Microsoft.Win32.RegistryKey registryKey2;
										switch (num2)
										{
										case 0:
											switch (0)
											{
											case 0:
												goto IL_19B;
											}
											continue;
										case 1:
											goto IL_1D1;
										case 2:
											((global::System.IDisposable)registryKey2).Dispose();
											num = (short)1823408129;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										IL_19B:
										if (registryKey2 == null)
										{
											break;
										}
										num = (short)2087124994;
										num2 = (int)((global::System.IntPtr)num);
									}
									IL_1D1:;
								}
								num = (short)948699139;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_79:
							if (registryKey != null)
							{
								num = (short)574226432;
								num2 = (int)((global::System.IntPtr)num);
							}
							else
							{
								global::Microsoft.Win32.RegistryKey registryKey2 = global::Microsoft.Win32.RegistryKey.OpenBaseKey(global::Microsoft.Win32.RegistryHive.LocalMachine, global::Microsoft.Win32.RegistryView.Registry32).OpenSubKey(keyLocation);
								num = (short)1369833476;
								num2 = (int)((global::System.IntPtr)num);
							}
						}
						IL_DB:
						goto IL_2F6;
						IL_1ED:;
					}
					finally
					{
						num = (short)376307712;
						int num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_222;
								}
								continue;
							case 1:
								goto IL_25A;
							case 2:
								((global::System.IDisposable)registryKey).Dispose();
								num = (short)791281665;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_222:
							if (registryKey == null)
							{
								break;
							}
							num = (short)1593573378;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_25A:;
					}
					break;
				}
				}
			}
			catch (global::System.ArgumentNullException ex)
			{
				global::System.Diagnostics.Trace.WriteLine(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("ꇲ郴郶郸裺觼跾砀倂怄猆紈戊挌栎成㴒尔搖刘縚搜伞匠䘢嘤䈦䜨弪ബ嬮夰䄲倴䀶ᤸ娺匼Ἶ⑀㭂♄≆㥈㽊⑌⁎㽐罒畔㉖⭘⥚㉜ⵞ孠䍢", a_) + ex.Message);
				bool result = false;
				goto IL_2F6;
			}
			catch (global::System.ObjectDisposedException ex2)
			{
				global::System.Diagnostics.Trace.WriteLine(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("ꇲ郴郶郸裺觼跾砀倂怄猆紈戊挌栎成㴒尔搖刘縚搜伞匠䘢嘤䈦䜨弪ബ嬮夰䄲倴䀶ᤸ娺匼Ἶ⑀㭂♄≆㥈㽊⑌⁎㽐罒畔㉖⭘⥚㉜ⵞ孠䍢", a_) + ex2.Message);
				bool result = false;
				goto IL_2F6;
			}
			catch (global::System.Exception ex3)
			{
				global::System.Diagnostics.Trace.WriteLine(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("ꇲ郴郶郸裺觼跾砀倂怄猆紈戊挌栎成㴒尔搖刘縚搜伞匠䘢嘤䈦䜨弪ബ嬮夰䄲倴䀶ᤸ娺匼Ἶ⑀㭂♄≆㥈㽊⑌⁎㽐罒畔㉖⭘⥚㉜ⵞ孠䍢", a_) + ex3.Message);
				throw;
			}
			IL_2CA:
			num = (short)1352597504;
			short num3 = num;
			return false;
			IL_2F6:
			num = (short)1987051521;
			if (num != 0)
			{
			}
			num = (short)1487065857;
			short num4 = num;
			num = (short)838456065;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_2CA;
			default:
			{
				num = (short)1865351168;
				if (num != 0)
				{
				}
				bool result;
				return result;
			}
			}
		}

		// Token: 0x0400013D RID: 317
		[global::System.NonSerialized]
		private string VafgnaprSvryq = 32;
	}
}
