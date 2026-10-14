using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x0200005D RID: 93
	public class MigrationCompleteVisibiltyConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x0600011A RID: 282 RVA: 0x0000F88C File Offset: 0x0000DA8C
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)560267265;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_11E;
				case 1:
				{
					num = (short)1680672124;
					short num3 = num;
					num = (short)2014643580;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_103;
					case 1:
						break;
					default:
					{
						num = (short)901316608;
						short num4 = num;
						break;
					}
					}
					num = (short)1190854656;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_A7;
					}
					continue;
				}
				case 2:
					num = (short)993656833;
					if (num != 0)
					{
					}
					num = (short)1145307136;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_103;
				}
				IL_A7:
				if ((global::Motorola.CommonCPS.Server.CommonDBConstants.MigrationStatus)value != global::Motorola.CommonCPS.Server.CommonDBConstants.MigrationStatus.Complete)
				{
					num = (short)1709834242;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)805568515;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_103:
			global::System.Windows.Visibility visibility = global::System.Windows.Visibility.Visible;
			goto IL_121;
			IL_11E:
			visibility = global::System.Windows.Visibility.Collapsed;
			IL_121:
			return visibility;
		}

		// Token: 0x0600011B RID: 283 RVA: 0x0000F9C0 File Offset: 0x0000DBC0
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)317975317;
			short num2 = num;
			num = (short)428534549;
			switch (num2 == num)
			{
			}
			num = (short)581500928;
			if (num != 0)
			{
			}
			num = (short)1260126209;
			if (num != 0)
			{
			}
			num = (short)442499072;
			short num3 = num;
			throw new global::System.NotImplementedException();
		}
	}
}
