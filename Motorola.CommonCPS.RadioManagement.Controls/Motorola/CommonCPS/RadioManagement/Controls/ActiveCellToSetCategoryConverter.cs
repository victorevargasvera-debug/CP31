using System;
using System.Globalization;
using System.Windows.Data;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x0200000A RID: 10
	internal class ActiveCellToSetCategoryConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x0600001E RID: 30 RVA: 0x000031AC File Offset: 0x000013AC
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)818872320;
			short num2 = num;
			num = (short)235312579;
			short num3 = num;
			num = (short)431134147;
			global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase fieldBase;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1823735809;
				if (num != 0)
				{
				}
				num = (short)535166976;
				if (num != 0)
				{
				}
				fieldBase = (value as global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase);
				if (fieldBase == null)
				{
					return null;
				}
				break;
			}
			return (fieldBase.Parent as global::Motorola.CommonCPS.RadioManagement.UIModels.Set).Parent as global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory;
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00003278 File Offset: 0x00001478
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)2116091904;
			short num2 = num;
			num = (short)2104104946;
			short num3 = num;
			num = (short)967645170;
			switch (num3 == num)
			{
			}
			num = (short)420282369;
			if (num != 0)
			{
			}
			num = (short)292093952;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
