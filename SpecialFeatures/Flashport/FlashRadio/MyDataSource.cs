using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using AcpASKLib;
using AcpSecurityLib;

namespace SpecialFeatures.Flashport.FlashRadio
{
	// Token: 0x020000DE RID: 222
	public class MyDataSource
	{
		// Token: 0x06000D4C RID: 3404 RVA: 0x00117F34 File Offset: 0x00116134
		public static global::System.Collections.ObjectModel.ObservableCollection<global::AcpASKLib.SystemKeyData> GetLoadedASKWithoutDefault()
		{
			short num = (short)2067822094;
			short num2 = num;
			num = (short)2093053454;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_66;
			default:
				num = (short)1119944704;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_66;
				}
				break;
			}
			int num3;
			global::System.Collections.ObjectModel.ObservableCollection<global::AcpASKLib.SystemKeyData> observableCollection;
			for (;;)
			{
				IL_54:
				global::System.Collections.Generic.IEnumerator<global::AcpASKLib.SystemKeyData> enumerator;
				switch (num3)
				{
				case 0:
					if (global::AcpSecurityLib.SecurityManager.LoadedASKs != null)
					{
						num = (short)1146814465;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return observableCollection;
				case 1:
					goto IL_1FD;
				case 2:
				{
					num = (short)2126118913;
					if (num != 0)
					{
					}
					num = (short)1483341824;
					short num4 = num;
					try
					{
						num = (short)1126760450;
						num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 1:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)1332805635;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::AcpASKLib.SystemKeyData systemKeyData = enumerator.Current;
								num = (short)1538916357;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 2:
								switch (0)
								{
								case 0:
									goto IL_E0;
								}
								continue;
							case 3:
								num = (short)958267398;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
							{
								global::AcpASKLib.SystemKeyData systemKeyData;
								observableCollection.Add(systemKeyData);
								num = (short)1348861952;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 5:
							{
								global::AcpASKLib.SystemKeyData systemKeyData;
								if (systemKeyData.SystemID != 1)
								{
									num = (short)2015297540;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 6:
								goto IL_18F;
							}
							IL_E2:
							num = (short)648413185;
							num3 = (int)((global::System.IntPtr)num);
							continue;
							IL_E0:
							goto IL_E2;
						}
						IL_18F:
						return observableCollection;
					}
					finally
					{
						num = (short)106430464;
						num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_1C4;
								}
								continue;
							case 1:
								enumerator.Dispose();
								num = (short)1578958850;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_1FA;
							}
							IL_1C4:
							if (enumerator == null)
							{
								break;
							}
							num = (short)214302721;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_1FA:;
					}
					goto IL_1FD;
				}
				}
				goto IL_66;
				IL_1FD:
				observableCollection = new global::System.Collections.ObjectModel.ObservableCollection<global::AcpASKLib.SystemKeyData>();
				enumerator = global::AcpSecurityLib.SecurityManager.LoadedASKs.GetEnumerator();
				num = (short)1742209026;
				num3 = (int)((global::System.IntPtr)num);
			}
			return observableCollection;
			IL_66:
			observableCollection = null;
			num = (short)777715712;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_54;
		}
	}
}
