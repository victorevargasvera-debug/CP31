using System;
using System.Globalization;
using System.Windows.Data;
using Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x0200002A RID: 42
	internal class SetCategoryCanCloseConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06000081 RID: 129 RVA: 0x00009134 File Offset: 0x00007334
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 4;
			switch (0)
			{
			case 0:
				goto IL_41;
			}
			short num2;
			global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory setCategory;
			for (;;)
			{
				IL_13:
				int num;
				switch (num)
				{
				case 0:
					goto IL_A1;
				case 1:
					num2 = (short)969015302;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					goto IL_106;
				case 3:
					if (setCategory == null)
					{
						num2 = (short)821428224;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)378077191;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					num2 = (short)316145669;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					if (!(setCategory.Name == global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("\udd9b춝즧캩얫솭羚\udcb1튳\ud9b5쪷ힹ\uddbb쪽ꦿ귁꫃", a_)))
					{
						num2 = (short)2008023041;
						if (num2 != 0)
						{
						}
						num2 = (short)1423179777;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1A2;
				case 6:
					if (!(setCategory.Name == global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("첛\udd9d얣슥솧얩삭횯\uddb1욳\udbb5\ud9b7캹햻톽꺿", a_)))
					{
						num2 = (short)172949512;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1A2;
				case 7:
					if (!setCategory.IsRoot)
					{
						num2 = (short)633536516;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1A2;
				case 8:
					num2 = (short)1559494658;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					goto IL_1B9;
				}
				goto IL_41;
				IL_1A2:
				num2 = (short)1214185481;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_A1:
			num2 = (short)2006650333;
			short num3 = num2;
			num2 = (short)481299933;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_41:
				num2 = (short)1919746048;
				short num4 = num2;
				setCategory = (value as global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory);
				num2 = (short)1298071555;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			default:
				num2 = (short)204603392;
				if (num2 != 0)
				{
				}
				return false;
			}
			IL_106:
			bool flag = !(setCategory.Name == global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("첛\udc9d얣슥솧얩삭횯\uddb1욳\udbb5\ud9b7캹햻톽꺿", a_));
			goto IL_24C;
			IL_1B9:
			flag = false;
			IL_24C:
			return flag;
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00009394 File Offset: 0x00007594
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1316749312;
			short num2 = num;
			num = (short)213363841;
			short num3 = num;
			num = (short)2018094209;
			switch (num3 == num)
			{
			}
			num = (short)1996881921;
			if (num != 0)
			{
			}
			num = (short)559218688;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
