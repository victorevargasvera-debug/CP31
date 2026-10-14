using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using ASK.Interface;

namespace ASKLib
{
	// Token: 0x02000004 RID: 4
	public static class ASKUtility
	{
		// Token: 0x0600000B RID: 11 RVA: 0x00002620 File Offset: 0x00000820
		internal static bool a()
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			bool result;
			for (;;)
			{
				IL_0A:
				global::System.Collections.ObjectModel.ReadOnlyCollection<global::ASK.Interface.ISystemKeyData> loadedUserSystemKeys;
				global::System.Collections.Generic.IEnumerator<global::ASK.Interface.ISystemKeyData> enumerator;
				switch (num)
				{
				case 0:
					if (loadedUserSystemKeys != null)
					{
						num2 = (short)689045505;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 1:
					num2 = (short)1968177153;
					if (num2 != 0)
					{
					}
					goto IL_226;
				case 2:
				{
					num2 = (short)1933049856;
					short num3 = num2;
					try
					{
						num2 = (short)518782980;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
								result = true;
								num2 = (short)1757741059;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 1:
								num2 = (short)426770438;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 2:
								if (!enumerator.MoveNext())
								{
									num2 = (short)265093121;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								num2 = (short)1533018117;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 3:
								goto IL_19C;
							case 4:
								switch (0)
								{
								case 0:
									goto IL_113;
								}
								continue;
							case 5:
								if (enumerator.Current.Type == global::ASK.Interface.KeyType.ADVANCED_CONV_SYSTEM_KEY)
								{
									num2 = (short)1940586496;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								break;
							case 6:
								goto IL_1B9;
							}
							IL_115:
							num2 = (short)886636546;
							num = (int)((global::System.IntPtr)num2);
							continue;
							IL_113:
							goto IL_115;
						}
						IL_19C:
						IL_1B9:
						return result;
					}
					finally
					{
						num2 = (short)736034816;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_1F0;
								}
								continue;
							case 1:
								enumerator.Dispose();
								num2 = (short)65208322;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 2:
								goto IL_223;
							}
							IL_1F0:
							if (enumerator == null)
							{
								break;
							}
							num2 = (short)733544449;
							num = (int)((global::System.IntPtr)num2);
						}
						IL_223:;
					}
					goto IL_226;
				}
				}
				goto IL_1C;
				IL_226:
				enumerator = loadedUserSystemKeys.GetEnumerator();
				num2 = (short)747831298;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			for (;;)
			{
				IL_1C:
				result = false;
				global::System.Collections.ObjectModel.ReadOnlyCollection<global::ASK.Interface.ISystemKeyData> loadedUserSystemKeys = global::ASKLib.SystemKeyManager.GetInstance().LoadedUserSystemKeys;
				num2 = (short)1011192608;
				short num4 = num2;
				num2 = (short)956338976;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_5E;
				}
			}
			IL_5E:
			num2 = (short)958660608;
			if (num2 != 0)
			{
			}
			num2 = (short)1142423552;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600000C RID: 12 RVA: 0x000028B4 File Offset: 0x00000AB4
		internal static bool a(int A_0)
		{
			short num = (short)614793216;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)264634369;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_64;
				}
				global::System.Collections.ObjectModel.ReadOnlyCollection<global::ASK.Interface.ISystemKeyData> loadedUserSystemKeys;
				bool result;
				for (;;)
				{
					IL_51:
					global::System.Collections.Generic.IEnumerator<global::ASK.Interface.ISystemKeyData> enumerator;
					switch (num2)
					{
					case 0:
						if (loadedUserSystemKeys != null)
						{
							num = (short)1442119681;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 1:
						goto IL_2A8;
					case 2:
						try
						{
							num = (short)1549139974;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_10C;
								case 1:
								{
									global::ASK.Interface.ISystemKeyData systemKeyData;
									if (A_0 == systemKeyData.SystemID)
									{
										num = (short)1172242440;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
									num = (short)460259333;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									goto IL_1D6;
								case 4:
								{
									global::ASK.Interface.ISystemKeyData systemKeyData;
									if (systemKeyData.Type == global::ASK.Interface.KeyType.ADVANCED_CONV_SYSTEM_KEY)
									{
										num = (short)1722286087;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
									goto IL_237;
								case 6:
									switch (0)
									{
									case 0:
										goto IL_F4;
									}
									continue;
								case 7:
									num = (short)184025089;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
								{
									result = true;
									num = (short)1773105353;
									short num3 = num;
									num = (short)946434249;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_10C;
									default:
										num = (short)2135556096;
										if (num != 0)
										{
										}
										num = (short)1260060675;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_F6:
								num = (short)1421082624;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_F4:
								goto IL_F6;
								IL_10C:
								if (!enumerator.MoveNext())
								{
									num = (short)1435828226;
									num2 = (int)((global::System.IntPtr)num);
								}
								else
								{
									global::ASK.Interface.ISystemKeyData systemKeyData = enumerator.Current;
									num = (short)420610052;
									num2 = (int)((global::System.IntPtr)num);
								}
							}
							IL_1D6:
							IL_237:
							return result;
						}
						finally
						{
							num = (short)1391460352;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_26F;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)1924202498;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_2A5;
								}
								IL_26F:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1565523969;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_2A5:;
						}
						goto IL_2A8;
					}
					goto IL_64;
					IL_2A8:
					enumerator = loadedUserSystemKeys.GetEnumerator();
					num = (short)1473511424;
					short num4 = num;
					num = (short)833552386;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_64:
				result = false;
				loadedUserSystemKeys = global::ASKLib.SystemKeyManager.GetInstance().LoadedUserSystemKeys;
				num = (short)1757806592;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_51;
			}
			}
		}
	}
}
