using System;
using System.Globalization;
using System.Linq;
using System.Windows.Data;
using Controls.SetsImportExport;
using Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Controls.Converters
{
	// Token: 0x02000136 RID: 310
	public class MultiBindingToSetImportArgsConverter : global::System.Windows.Data.IMultiValueConverter
	{
		// Token: 0x06000976 RID: 2422 RVA: 0x0009CA58 File Offset: 0x0009AC58
		public object Convert(object[] values, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 11;
			short num = (short)722468866;
			int num2 = (int)((global::System.IntPtr)num);
			global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory setCategory;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_160;
				case 1:
					goto IL_183;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_49;
					}
					continue;
				case 3:
					goto IL_108;
				case 4:
					num = (short)150208512;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					if (setCategory != null)
					{
						num = (short)2084634627;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1D2;
				case 6:
					if (values.Any(new global::System.Func<object, bool>(global::Motorola.CommonCPS.RadioManagement.Controls.Converters.MultiBindingToSetImportArgsConverter.<>c.<>9.a)))
					{
						num = (short)24641537;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					setCategory = (values[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory);
					num = (short)374603781;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_49:
				num = (short)1185021952;
				short num3 = num;
				if (!values.Any<object>())
				{
					num = (short)153092100;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)1214316550;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_BD:
			return new global::Controls.SetsImportExport.SetImportArgs
			{
				SetCategory = setCategory
			};
			IL_108:
			num = (short)187826177;
			if (num != 0)
			{
			}
			goto IL_BD;
			IL_160:
			return null;
			IL_183:
			num = (short)469747837;
			short num4 = num;
			num = (short)1608697981;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_BD;
			default:
				num = (short)2132934656;
				if (num != 0)
				{
				}
				return null;
			}
			IL_1D2:
			throw new global::System.ArgumentException(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("쮤풦\udca8\udbaa\uddac삮쎰잲킴펶馸쾺쒼쾾꓀", a_));
		}

		// Token: 0x06000977 RID: 2423 RVA: 0x0009CC4C File Offset: 0x0009AE4C
		public object[] ConvertBack(object value, global::System.Type[] targetTypes, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1061336849;
			short num2 = num;
			num = (short)1078703889;
			switch (num2 == num)
			{
			}
			num = (short)323747840;
			if (num != 0)
			{
			}
			num = (short)1169424384;
			short num3 = num;
			num = (short)1068040193;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
