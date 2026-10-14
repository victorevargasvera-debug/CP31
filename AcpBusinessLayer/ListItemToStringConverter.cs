using System;
using System.Globalization;
using System.Windows.Data;

namespace AcpBusinessLayer
{
	// Token: 0x02000017 RID: 23
	public class ListItemToStringConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x0600022F RID: 559 RVA: 0x0002A2F0 File Offset: 0x000284F0
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			global::AcpBusinessLayer.ListItem listItem = value as global::AcpBusinessLayer.ListItem;
			if (listItem != null)
			{
				short num = (short)159765488;
				short num2 = num;
				num = (short)1117115376;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1750597632;
					if (num != 0)
					{
					}
					num = (short)1356595200;
					short num3 = num;
					num = (short)755957761;
					if (num != 0)
					{
					}
					break;
				}
				}
				return listItem.ItemName;
			}
			return string.Empty;
		}

		// Token: 0x06000230 RID: 560 RVA: 0x0002A3B4 File Offset: 0x000285B4
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1270923844;
			short num2 = num;
			num = (short)1733280324;
			switch (num2 == num)
			{
			}
			num = (short)672989184;
			short num3 = num;
			num = (short)1411842049;
			if (num != 0)
			{
			}
			num = (short)1080098816;
			if (num != 0)
			{
			}
			return null;
		}
	}
}
