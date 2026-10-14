using System;
using System.Globalization;
using System.Windows.Data;
using AcpBusinessLayer.UndoRedo;

namespace AcpBusinessLayer.ValueConverters
{
	// Token: 0x02000049 RID: 73
	public class DivideBy10Converter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x060004D3 RID: 1235 RVA: 0x0006799C File Offset: 0x00065B9C
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 0;
			short num = (short)1468071936;
			short num2 = num;
			num = (short)1641252152;
			short num3 = num;
			num = (short)1264616760;
			switch (num3 == num)
			{
			}
			num = (short)1606025217;
			if (num != 0)
			{
			}
			num = (short)1823866880;
			if (num != 0)
			{
			}
			return ((double)((int)value) / 10.0).ToString(global::AcpBusinessLayer.UndoRedo.SetValueTask.b("듑", a_));
		}

		// Token: 0x060004D4 RID: 1236 RVA: 0x00067A78 File Offset: 0x00065C78
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)119275520;
			short num2 = num;
			num = (short)776939103;
			short num3 = num;
			num = (short)2101159519;
			switch (num3 == num)
			{
			}
			num = (short)1017577473;
			if (num != 0)
			{
			}
			num = (short)458096640;
			if (num != 0)
			{
			}
			return (int)(double.Parse((string)value) * 10.0);
		}
	}
}
