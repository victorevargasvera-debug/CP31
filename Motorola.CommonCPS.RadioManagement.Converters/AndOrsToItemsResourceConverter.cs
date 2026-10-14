using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Windows.Data;
using Motorola.CommonCPS.RadioManagement.ConvertorExtensions;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x02000005 RID: 5
	public class AndOrsToItemsResourceConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06000008 RID: 8 RVA: 0x0000243C File Offset: 0x0000063C
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			global::System.Collections.ObjectModel.Collection<global::Motorola.CommonCPS.Server.CommonDBConstants.AndOR> collection = value as global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.Server.CommonDBConstants.AndOR>;
			global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
			global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.Server.CommonDBConstants.AndOR> enumerator = collection.GetEnumerator();
			short num;
			try
			{
				num = (short)288751617;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_EB;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_4C;
						}
						continue;
					case 2:
						num = (short)1586429952;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)1194131458;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1638727681;
						if (num != 0)
						{
						}
						global::Motorola.CommonCPS.Server.CommonDBConstants.AndOR andOr = enumerator.Current;
						list.Add(global::Motorola.CommonCPS.RadioManagement.ConvertorExtensions.Enum2ResourceString.DataMiningAndORConverter.GetResouce(andOr));
						num = (short)565051396;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_9E:
					num = (short)333381635;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4C:
					goto IL_9E;
				}
				IL_EB:;
			}
			finally
			{
				num = (short)375980034;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_1A3;
					case 1:
					{
						enumerator.Dispose();
						num = (short)1709650969;
						short num3 = num;
						num = (short)319501337;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_104;
						default:
							num = (short)1351221248;
							if (num != 0)
							{
							}
							num = (short)1045168128;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
						goto IL_104;
					}
					goto IL_120;
					IL_104:
					switch (0)
					{
					case 0:
						IL_120:
						if (enumerator == null)
						{
							goto IL_1A5;
						}
						num = (short)1237581825;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				IL_1A3:
				IL_1A5:;
			}
			num = (short)1465253888;
			short num4 = num;
			return list;
		}

		// Token: 0x06000009 RID: 9 RVA: 0x0000262C File Offset: 0x0000082C
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1684530138;
			short num2 = num;
			num = (short)9495514;
			switch (num2 == num)
			{
			}
			num = (short)2118647808;
			if (num != 0)
			{
			}
			num = (short)1272840193;
			if (num != 0)
			{
			}
			num = (short)148701184;
			short num3 = num;
			throw new global::System.NotImplementedException();
		}
	}
}
