using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Windows.Data;
using ASK.Interface;
using Motorola.CommonCPS.RadioManagement.ConvertorExtensions;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x02000069 RID: 105
	public class KeyTypesToItemsSourceConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x0600013F RID: 319 RVA: 0x000114D0 File Offset: 0x0000F6D0
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			global::System.Collections.ObjectModel.Collection<global::ASK.Interface.KeyType> collection = value as global::System.Collections.ObjectModel.ObservableCollection<global::ASK.Interface.KeyType>;
			global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
			global::System.Collections.Generic.IEnumerator<global::ASK.Interface.KeyType> enumerator = collection.GetEnumerator();
			short num;
			try
			{
				num = (short)1915224064;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_4D;
						}
						continue;
					case 1:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)973209603;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::ASK.Interface.KeyType systemKeyType = enumerator.Current;
						list.Add(systemKeyType.ToResourceString());
						num = (short)1385103364;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_EB;
					case 3:
						num = (short)2035875841;
						if (num != 0)
						{
						}
						num = (short)2103967746;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_79:
					num = (short)861667329;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4D:
					goto IL_79;
				}
				IL_EB:;
			}
			finally
			{
				num = (short)1937244162;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_1A6;
					case 1:
					{
						num = (short)943771316;
						short num3 = num;
						num = (short)653446836;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)838664192;
							if (num != 0)
							{
							}
							enumerator.Dispose();
							break;
						}
						num = (short)1253310464;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						switch (0)
						{
						case 0:
							goto IL_120;
						}
						continue;
					}
					IL_120:
					if (enumerator == null)
					{
						break;
					}
					num = (short)1829044225;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1A6:;
			}
			num = (short)1403846656;
			short num4 = num;
			return list;
		}

		// Token: 0x06000140 RID: 320 RVA: 0x000116C4 File Offset: 0x0000F8C4
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)514326528;
			short num2 = num;
			num = (short)94468160;
			short num3 = num;
			num = (short)1541765184;
			switch (num3 == num)
			{
			}
			num = (short)1488322561;
			if (num != 0)
			{
			}
			num = (short)1351483392;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
