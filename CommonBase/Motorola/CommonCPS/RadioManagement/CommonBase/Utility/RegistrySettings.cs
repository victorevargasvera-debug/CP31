using System;
using Microsoft.Win32;

namespace Motorola.CommonCPS.RadioManagement.CommonBase.Utility
{
	// Token: 0x02000019 RID: 25
	public class RegistrySettings
	{
		// Token: 0x06000084 RID: 132 RVA: 0x0000C230 File Offset: 0x0000A430
		private RegistrySettings()
		{
		}

		// Token: 0x06000085 RID: 133 RVA: 0x0000C244 File Offset: 0x0000A444
		public static string GetStringValue(string keyLocation, string valueName)
		{
			short num = (short)1476198401;
			if (num != 0)
			{
			}
			num = (short)579076096;
			short num2 = num;
			string result = string.Empty;
			global::Microsoft.Win32.RegistryKey registryKey = null;
			try
			{
				switch (0)
				{
				case 0:
					goto IL_7C;
				}
				int num3;
				for (;;)
				{
					IL_66:
					switch (num3)
					{
					case 0:
						goto IL_12D;
					case 1:
					{
						result = (string)registryKey.GetValue(valueName);
						num = (short)1380431802;
						short num4 = num;
						num = (short)272349114;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_12D;
						default:
							num = (short)250413056;
							if (num != 0)
							{
							}
							num = (short)1152319488;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
						goto IL_145;
					case 3:
						if (registryKey != null)
						{
							num = (short)515244033;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_12D;
					}
					goto IL_7C;
					IL_12D:
					num = (short)954204162;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_145:
				return result;
				IL_7C:
				registryKey = global::Microsoft.Win32.Registry.LocalMachine.OpenSubKey(keyLocation);
				num = (short)1608450051;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_66;
			}
			catch (global::System.ArgumentNullException)
			{
			}
			catch (global::System.ObjectDisposedException)
			{
			}
			catch (global::System.Exception)
			{
				throw;
			}
			finally
			{
				num = (short)1694892034;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						registryKey.Close();
						num = (short)1150877697;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_1B5;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_181;
						}
						continue;
					}
					IL_181:
					if (registryKey == null)
					{
						break;
					}
					num = (short)535101440;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_1B5:;
			}
			return result;
		}

		// Token: 0x06000086 RID: 134 RVA: 0x0000C440 File Offset: 0x0000A640
		public static bool IsKeyPresent(string keyLocation)
		{
			short num = (short)2063466497;
			if (num != 0)
			{
			}
			num = (short)1895825408;
			short num2 = num;
			bool result = false;
			global::Microsoft.Win32.RegistryKey registryKey = null;
			try
			{
				int num3;
				switch (0)
				{
				case 0:
					break;
				default:
					for (;;)
					{
						IL_5E:
						switch (num3)
						{
						case 0:
							goto IL_E8;
						case 1:
							result = true;
							num = (short)2098593794;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_E8;
						case 3:
							goto IL_14A;
						case 4:
							if (registryKey != null)
							{
								num = (short)503316481;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							result = false;
							num = (short)1966866432;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_78;
						IL_E8:
						num = (short)687619102;
						short num4 = num;
						num = (short)297548830;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_84;
						default:
							num = (short)783417344;
							if (num != 0)
							{
							}
							num = (short)1989869571;
							num3 = (int)((global::System.IntPtr)num);
							break;
						}
					}
					IL_14A:
					return result;
				}
				IL_78:
				registryKey = global::Microsoft.Win32.Registry.LocalMachine.OpenSubKey(keyLocation);
				IL_84:
				num = (short)1580466180;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_5E;
			}
			catch (global::System.ArgumentNullException)
			{
				result = false;
			}
			catch (global::System.ObjectDisposedException)
			{
				result = false;
			}
			catch (global::System.Exception)
			{
				throw;
			}
			finally
			{
				num = (short)516947970;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						registryKey.Close();
						num = (short)1218969601;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_1BF;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_18A;
						}
						continue;
					}
					IL_18A:
					if (registryKey == null)
					{
						break;
					}
					num = (short)1038548992;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_1BF:;
			}
			return result;
		}
	}
}
