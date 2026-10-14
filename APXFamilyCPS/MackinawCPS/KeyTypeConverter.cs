using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Windows.Data;
using AcpASKLib;
using CommonResources;

namespace MackinawCPS
{
	// Token: 0x02000065 RID: 101
	public class KeyTypeConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x0600046F RID: 1135 RVA: 0x000DD060 File Offset: 0x000DB260
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)500563968;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_3E;
				}
				global::System.Collections.ObjectModel.Collection<string> collection;
				global::System.Collections.ObjectModel.Collection<global::AcpASKLib.KeyType> collection2;
				for (;;)
				{
					IL_27:
					global::System.Collections.Generic.IEnumerator<global::AcpASKLib.SystemKeyData> enumerator2;
					switch (num2)
					{
					case 0:
						if (((global::System.Collections.ObjectModel.Collection<global::AcpASKLib.SystemKeyData>)value).Count > 0)
						{
							num = (short)1020067843;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_55F;
					case 1:
						try
						{
							num = (short)1786642437;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 1:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpASKLib.KeyType> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)174325768;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpASKLib.KeyType keyType = enumerator.Current;
									num = (short)647364614;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									collection.Add(global::CommonResources.AppResources.Adv_WACN_Key_Column_Header_ID);
									num = (short)934346752;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									goto IL_274;
								case 5:
									switch (0)
									{
									case 0:
										goto IL_E5;
									}
									continue;
								case 6:
								{
									global::AcpASKLib.KeyType keyType;
									if (keyType == global::AcpASKLib.KeyType.ADVANCED_SYSTEM_KEY)
									{
										num = (short)986906631;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1887764491;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
									collection.Add(global::CommonResources.AppResources.Adv_System_Key_Column_Header_ID);
									num = (short)1189543948;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
									num = (short)1926627332;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
								{
									global::AcpASKLib.KeyType keyType;
									if (keyType == global::AcpASKLib.KeyType.NONE)
									{
										num = (short)89718794;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 10:
									collection.Add(global::CommonResources.AppResources.None_Id);
									num = (short)1478098946;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 11:
								{
									global::AcpASKLib.KeyType keyType;
									if (keyType == global::AcpASKLib.KeyType.ADVANCED_WACN_KEY)
									{
										num = (short)2050686979;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)465502217;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_E7:
								num = (short)1169358849;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_E5:
								goto IL_E7;
							}
							IL_274:
							goto IL_55F;
						}
						finally
						{
							num = (short)2015363072;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpASKLib.KeyType> enumerator;
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_2AD;
									}
									continue;
								case 1:
									goto IL_2E4;
								case 2:
									enumerator.Dispose();
									num = (short)1792737281;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_2AD:
								if (enumerator == null)
								{
									break;
								}
								num = (short)950730754;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_2E4:;
						}
						goto IL_2E7;
					case 2:
					{
						try
						{
							num = (short)1961492481;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)1209991176;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_358;
									}
									continue;
								case 2:
									num = (short)1159790597;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
								{
									global::AcpASKLib.SystemKeyData systemKeyData;
									if (!collection2.Contains(systemKeyData.Type))
									{
										num = (short)1587609600;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
									goto IL_458;
								case 6:
								{
									global::AcpASKLib.SystemKeyData systemKeyData;
									collection2.Add(systemKeyData.Type);
									num = (short)357302275;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
								{
									if (!enumerator2.MoveNext())
									{
										num = (short)1083047938;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpASKLib.SystemKeyData systemKeyData = enumerator2.Current;
									num = (short)386269188;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
								{
									global::AcpASKLib.SystemKeyData systemKeyData;
									if (systemKeyData.Type != global::AcpASKLib.KeyType.ADVANCED_CONV_SYSTEM_KEY)
									{
										num = (short)519372806;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_401:
								num = (short)625278983;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_358:
								goto IL_401;
							}
							IL_458:;
						}
						finally
						{
							num = (short)560267264;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_48D;
									}
									continue;
								case 1:
									goto IL_4C2;
								case 2:
									enumerator2.Dispose();
									num = (short)1142685697;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_48D:
								if (enumerator2 == null)
								{
									break;
								}
								num = (short)301334530;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_4C2:;
						}
						global::System.Collections.Generic.IEnumerator<global::AcpASKLib.KeyType> enumerator = collection2.GetEnumerator();
						num = (short)575472992;
						short num3 = num;
						num = (short)2118583648;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_55F;
						default:
							num = (short)2032861184;
							if (num != 0)
							{
							}
							num = (short)591265793;
							if (num != 0)
							{
							}
							num = (short)113115137;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 3:
						goto IL_2E7;
					}
					goto IL_3E;
					IL_2E7:
					enumerator2 = ((global::System.Collections.ObjectModel.Collection<global::AcpASKLib.SystemKeyData>)value).GetEnumerator();
					num = (short)874512386;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_55F:
				num = (short)1351876608;
				short num4 = num;
				return collection;
				IL_3E:
				collection2 = new global::System.Collections.ObjectModel.Collection<global::AcpASKLib.KeyType>();
				collection = new global::System.Collections.ObjectModel.Collection<string>();
				num = (short)1730740224;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000470 RID: 1136 RVA: 0x000DD62C File Offset: 0x000DB82C
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)665255936;
			short num2 = num;
			num = (short)1074856004;
			short num3 = num;
			num = (short)1099366468;
			switch (num3 == num)
			{
			}
			num = (short)2091319297;
			if (num != 0)
			{
			}
			num = (short)1134821376;
			if (num != 0)
			{
			}
			return null;
		}

		// Token: 0x040002D6 RID: 726
		[global::System.NonSerialized]
		string VafgnaprSvryq = 32;
	}
}
