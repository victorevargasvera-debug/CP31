using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Windows.Data;
using Motorola.CommonCPS.RadioManagement.ConvertorExtensions;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x0200006E RID: 110
	public class OperatorsToItemsSourceConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x0600014E RID: 334 RVA: 0x00011F84 File Offset: 0x00010184
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)42729473;
			if (num != 0)
			{
			}
			global::System.Collections.ObjectModel.Collection<global::Motorola.CommonCPS.Server.CommonDBConstants.Operator> collection = value as global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.Server.CommonDBConstants.Operator>;
			global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
			global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.Server.CommonDBConstants.Operator> enumerator = collection.GetEnumerator();
			try
			{
				num = (short)2024275968;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_76;
						}
						continue;
					case 1:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)922550275;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.CommonCPS.Server.CommonDBConstants.Operator dataMiningOperator = enumerator.Current;
						list.Add(global::Motorola.CommonCPS.RadioManagement.ConvertorExtensions.Enum2ResourceString.DataMiningOperatorConverter.GetResouce(dataMiningOperator));
						num = (short)1474494468;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_EC;
					case 3:
						num = (short)378339330;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_A1:
					num = (short)800456705;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_76:
					goto IL_A1;
				}
				IL_EC:;
			}
			finally
			{
				num = (short)1124794370;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_1A8;
					case 1:
					{
						num = (short)1103303204;
						short num3 = num;
						num = (short)1188893220;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)92012544;
							if (num != 0)
							{
							}
							enumerator.Dispose();
							break;
						}
						num = (short)1124532224;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						switch (0)
						{
						case 0:
							goto IL_121;
						}
						continue;
					}
					IL_121:
					if (enumerator == null)
					{
						break;
					}
					num = (short)1207631873;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1A8:;
			}
			num = (short)1288503296;
			short num4 = num;
			return list;
		}

		// Token: 0x0600014F RID: 335 RVA: 0x00012178 File Offset: 0x00010378
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)866582528;
			short num2 = num;
			num = (short)1552671763;
			short num3 = num;
			num = (short)1608836115;
			switch (num3 == num)
			{
			}
			num = (short)2052587521;
			if (num != 0)
			{
			}
			num = (short)734396416;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
