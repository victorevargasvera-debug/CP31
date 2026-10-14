using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Windows.Data;
using Motorola.CommonCPS.RadioManagement.ConvertorExtensions;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x02000075 RID: 117
	public class QueryTypesToItemsSourceConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06000163 RID: 355 RVA: 0x00012E38 File Offset: 0x00011038
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			global::System.Collections.ObjectModel.Collection<global::Motorola.CommonCPS.Server.CommonDBConstants.DataMiningQueryType> collection = value as global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.Server.CommonDBConstants.DataMiningQueryType>;
			global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
			global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.Server.CommonDBConstants.DataMiningQueryType> enumerator = collection.GetEnumerator();
			short num;
			try
			{
				num = (short)1776549892;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_10F;
					case 1:
					{
						num = (short)1122143269;
						short num3 = num;
						num = (short)938970149;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							num = (short)1474297856;
							if (num != 0)
							{
							}
							num = (short)1639120896;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)714670081;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.CommonCPS.Server.CommonDBConstants.DataMiningQueryType queryType = enumerator.Current;
						list.Add(global::Motorola.CommonCPS.RadioManagement.ConvertorExtensions.Enum2ResourceString.DataMiningQueryTypeConverter.GetResouce(queryType));
						num = (short)1499529219;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						switch (0)
						{
						case 0:
							goto IL_4C;
						}
						continue;
					}
					IL_78:
					num = (short)1608646658;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4C:
					goto IL_78;
				}
				IL_10F:
				num = (short)660275201;
				if (num != 0)
				{
				}
			}
			finally
			{
				num = (short)1891958786;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						enumerator.Dispose();
						num = (short)954335233;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_19E;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_169;
						}
						continue;
					}
					IL_169:
					if (enumerator == null)
					{
						break;
					}
					num = (short)1083572224;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_19E:;
			}
			num = (short)698941440;
			short num4 = num;
			return list;
		}

		// Token: 0x06000164 RID: 356 RVA: 0x0001302C File Offset: 0x0001122C
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)530791258;
			short num2 = num;
			num = (short)2134326106;
			switch (num2 == num)
			{
			}
			num = (short)1554513921;
			if (num != 0)
			{
			}
			num = (short)279838720;
			if (num != 0)
			{
			}
			num = (short)85721088;
			short num3 = num;
			throw new global::System.NotImplementedException();
		}
	}
}
