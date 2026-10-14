using System;
using System.Globalization;
using System.Linq;
using System.Windows.Data;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x0200003F RID: 63
	public class ProductFamilyToHeightConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x060000BF RID: 191 RVA: 0x0000A62C File Offset: 0x0000882C
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int num;
			string[] array;
			short num2;
			switch (0)
			{
			case 0:
				break;
			default:
			{
				string[] array2;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						goto IL_1CF;
					case 1:
					{
						if (array.Length == 2)
						{
							string[] source = array[0].ToUpper(global::System.Globalization.CultureInfo.CurrentCulture).Split(new char[]
							{
								';'
							});
							array2 = array[1].Split(new char[]
							{
								':'
							});
							num2 = (short)1760362499;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)1764229120;
						short num3 = num2;
						num2 = (short)390064565;
						short num4 = num2;
						num2 = (short)1261365685;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_3F;
						default:
							num2 = (short)1286668288;
							if (num2 != 0)
							{
							}
							num2 = (short)646578176;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 2:
						goto IL_11B;
					case 3:
					{
						num2 = (short)1902116865;
						if (num2 != 0)
						{
						}
						string[] source;
						if (source.Contains(value.ToString().ToUpper(global::System.Globalization.CultureInfo.CurrentCulture)))
						{
							num2 = (short)1154875394;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_1D8;
					}
					case 4:
						num2 = (short)1153433601;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 5:
						if (array != null)
						{
							num2 = (short)733282308;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_120;
					}
					goto IL_28;
				}
				IL_11B:
				return array2[0];
				IL_120:
				return 0;
				IL_1CF:
				goto IL_120;
				IL_1D8:
				return array2[1];
			}
			}
			IL_28:
			array = parameter.ToString().Split(new char[]
			{
				'?'
			});
			IL_3F:
			num2 = (short)1739456517;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x0000A814 File Offset: 0x00008A14
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)164163407;
			short num2 = num;
			num = (short)832827215;
			switch (num2 == num)
			{
			}
			num = (short)1478492161;
			if (num != 0)
			{
			}
			num = (short)101777408;
			short num3 = num;
			num = (short)286982144;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
