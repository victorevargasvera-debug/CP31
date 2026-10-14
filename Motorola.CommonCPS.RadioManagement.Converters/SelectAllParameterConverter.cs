using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows;
using System.Windows.Data;
using Infragistics.Windows.DataPresenter;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x02000042 RID: 66
	public class SelectAllParameterConverter : global::System.Windows.Data.IMultiValueConverter
	{
		// Token: 0x060000C8 RID: 200 RVA: 0x0000AD74 File Offset: 0x00008F74
		public object Convert(object[] values, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1918500864;
			switch (num)
			{
			default:
			{
				num = (short)1009451010;
				int num2 = (int)((global::System.IntPtr)num);
				object[] array;
				global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase> list;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						if (values.Count<object>() != 2)
						{
							num = (short)1241776133;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2068905985;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (values[0] != global::System.Windows.DependencyProperty.UnsetValue)
						{
							num = (short)1236926471;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_12F;
					case 2:
					{
						num = (short)984988777;
						short num3 = num;
						num = (short)469810281;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_12D;
						default:
							num = (short)2044002305;
							if (num != 0)
							{
							}
							num = (short)839385088;
							if (num != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_DC;
							}
							continue;
						}
						break;
					}
					case 3:
						goto IL_12D;
					case 4:
						goto IL_30C;
					case 5:
						goto IL_19B;
					case 6:
					{
						if (values[1] == global::System.Windows.DependencyProperty.UnsetValue)
						{
							num = (short)860094468;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						array = new object[2];
						array[0] = values[0];
						global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Record> enumerable = values[1] as global::Infragistics.Windows.DataPresenter.RecordCollectionBase;
						list = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase>();
						global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Record> enumerator = enumerable.GetEnumerator();
						num = (short)440598531;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						goto IL_2CE;
					case 8:
						num = (short)1855455232;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_DC:
					if (values != null)
					{
						num = (short)631373832;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_15A;
					IL_2CE:
					num = (short)342622214;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_12D:
					try
					{
						num = (short)2135949316;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								num = (short)2043871235;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
							{
								global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Record> enumerator;
								if (!enumerator.MoveNext())
								{
									num = (short)486670336;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = (global::Infragistics.Windows.DataPresenter.DataRecord)enumerator.Current;
								list.Add(dataRecord.DataItem as global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase);
								num = (short)263651329;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 3:
								goto IL_25D;
							case 4:
								switch (0)
								{
								case 0:
									goto IL_1D7;
								}
								continue;
							}
							IL_20E:
							num = (short)987824130;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_1D7:
							goto IL_20E;
						}
						IL_25D:
						goto IL_355;
					}
					finally
					{
						num = (short)628228096;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Record> enumerator;
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_296;
								}
								continue;
							case 1:
								enumerator.Dispose();
								num = (short)993656834;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_2CB;
							}
							IL_296:
							if (enumerator == null)
							{
								break;
							}
							num = (short)38404097;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_2CB:;
					}
					goto IL_2CE;
				}
				IL_12F:
				num = (short)923729920;
				short num4 = num;
				return null;
				IL_15A:
				return null;
				IL_19B:
				goto IL_15A;
				IL_30C:
				goto IL_12F;
				IL_355:
				array[1] = list;
				return array;
			}
			}
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x0000B0EC File Offset: 0x000092EC
		public object[] ConvertBack(object value, global::System.Type[] targetTypes, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1449172071;
			short num2 = num;
			num = (short)168598631;
			switch (num2 == num)
			{
			}
			num = (short)768540672;
			if (num != 0)
			{
			}
			num = (short)1430126592;
			short num3 = num;
			num = (short)1927020545;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
