using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Windows.Data;
using AcpASKLib;
using CommonResources;

namespace MackinawCPS
{
	// Token: 0x02000066 RID: 102
	public class KeyIDConverter : global::System.Windows.Data.IMultiValueConverter
	{
		// Token: 0x06000472 RID: 1138 RVA: 0x000DD6EC File Offset: 0x000DB8EC
		public object Convert(object[] values, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1533411328;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_60;
				}
				string b;
				global::System.Collections.ObjectModel.ObservableCollection<global::AcpASKLib.SystemKeyData> observableCollection;
				for (;;)
				{
					IL_29:
					string a;
					global::System.Collections.Generic.IEnumerator<global::AcpASKLib.SystemKeyData> enumerator;
					switch (num2)
					{
					case 0:
						if (a == global::CommonResources.AppResources.Adv_System_Key_Column_Header_ID)
						{
							num = (short)1825505289;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)804454402;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						num = (short)2051407872;
						short num3 = num;
						num = (short)1467449054;
						short num4 = num;
						num = (short)1382252254;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
						{
							num = (short)799014912;
							if (num != 0)
							{
							}
							global::AcpASKLib.KeyType keyType = global::AcpASKLib.KeyType.ADVANCED_WACN_KEY;
							b = keyType.ToString();
							break;
						}
						}
						num = (short)1263206410;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						if (a == global::CommonResources.AppResources.Adv_WACN_Key_Column_Header_ID)
						{
							num = (short)902692865;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)238485507;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (a == global::CommonResources.AppResources.None_Id)
						{
							num = (short)1178599425;
							if (num != 0)
							{
							}
							num = (short)647626763;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A0;
					case 4:
						if (values[1] != null)
						{
							num = (short)1036648455;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return observableCollection;
					case 5:
						try
						{
							num = (short)1276706818;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::AcpASKLib.KeyType keyType;
									if (keyType.ToString() == b)
									{
										num = (short)1321271301;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)2057830406;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpASKLib.SystemKeyData systemKeyData = enumerator.Current;
									global::AcpASKLib.KeyType keyType = systemKeyData.Type;
									num = (short)614727680;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									switch (0)
									{
									case 0:
										goto IL_1A5;
									}
									continue;
								case 3:
									goto IL_272;
								case 5:
								{
									global::AcpASKLib.SystemKeyData systemKeyData;
									observableCollection.Add(systemKeyData);
									num = (short)195756036;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									num = (short)1967521795;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_1A7:
								num = (short)1139933185;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1A5:
								goto IL_1A7;
							}
							IL_272:
							return observableCollection;
						}
						finally
						{
							num = (short)1819279360;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_2AB;
									}
									continue;
								case 1:
									goto IL_2E4;
								case 2:
									enumerator.Dispose();
									num = (short)1017839617;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_2AB:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1019543554;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_2E4:;
						}
						goto IL_2E7;
					case 6:
						goto IL_A0;
					case 7:
						goto IL_2E7;
					case 8:
						goto IL_A0;
					case 9:
					{
						global::AcpASKLib.KeyType keyType = global::AcpASKLib.KeyType.ADVANCED_SYSTEM_KEY;
						b = keyType.ToString();
						num = (short)678821896;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						goto IL_A0;
					case 11:
					{
						global::AcpASKLib.KeyType keyType = global::AcpASKLib.KeyType.NONE;
						b = keyType.ToString();
						num = (short)27787270;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_60;
					IL_A0:
					enumerator = ((global::System.Collections.ObjectModel.ObservableCollection<global::AcpASKLib.SystemKeyData>)values[0]).GetEnumerator();
					num = (short)741801989;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2E7:
					a = values[1].ToString();
					num = (short)1684930560;
					num2 = (int)((global::System.IntPtr)num);
				}
				return observableCollection;
				IL_60:
				observableCollection = new global::System.Collections.ObjectModel.ObservableCollection<global::AcpASKLib.SystemKeyData>();
				b = null;
				num = (short)190119940;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_29;
			}
			}
		}

		// Token: 0x06000473 RID: 1139 RVA: 0x000DDB60 File Offset: 0x000DBD60
		public object[] ConvertBack(object value, global::System.Type[] targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1168941809;
			short num2 = num;
			num = (short)1208328945;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1599012864;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1496645633;
			if (num != 0)
			{
			}
			num = (short)795869184;
			if (num != 0)
			{
			}
			return null;
		}

		// Token: 0x040002D7 RID: 727
		[global::System.NonSerialized]
		string VafgnaprSvryq = 32;
	}
}
