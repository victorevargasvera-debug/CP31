using System;
using System.Globalization;
using System.Windows.Data;
using Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x02000032 RID: 50
	internal class UnboundColumnValueConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06000099 RID: 153 RVA: 0x0000A674 File Offset: 0x00008874
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 6;
			switch (0)
			{
			case 0:
				goto IL_39;
			}
			int num;
			global::Motorola.CommonCPS.RadioManagement.UIModels.Set set;
			short num2;
			global::Motorola.CommonCPS.RadioManagement.UIModels.FlatParentChildSet flatParentChildSet;
			string[] array;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					if (set != null)
					{
						num2 = (short)502464514;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_214;
				case 1:
					goto IL_20F;
				case 2:
					goto IL_1D3;
				case 3:
				{
					set = (value as global::Motorola.CommonCPS.RadioManagement.UIModels.Set);
					num2 = (short)270411525;
					short num3 = num2;
					num2 = (short)715859717;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_EB;
					default:
						num2 = (short)1065877505;
						if (num2 != 0)
						{
						}
						num2 = (short)1509294080;
						if (num2 != 0)
						{
						}
						num2 = (short)116719616;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 4:
					if (flatParentChildSet.ChildSet == null)
					{
						num2 = (short)1372389377;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_216;
				case 5:
					if (array[0] == global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("캝솟킡솣좥\udca7囹즫\udaad", a_))
					{
						num2 = (short)380567559;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)73596932;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					if (flatParentChildSet == null)
					{
						num2 = (short)11796483;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					array = parameter.ToString().Split(new char[]
					{
						'|'
					});
					num2 = (short)1696399365;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					goto IL_E9;
				}
				goto IL_39;
			}
			IL_E9:
			return flatParentChildSet.ParentSet.Fields[array[1]];
			IL_EB:
			return set.Fields[parameter.ToString()];
			IL_1D3:
			goto IL_EB;
			IL_20F:
			num2 = (short)1900150784;
			short num4 = num2;
			return null;
			IL_214:
			return null;
			IL_216:
			return flatParentChildSet.ChildSet.Fields[array[1]];
			IL_39:
			flatParentChildSet = (value as global::Motorola.CommonCPS.RadioManagement.UIModels.FlatParentChildSet);
			num2 = (short)1199112198;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x0600009A RID: 154 RVA: 0x0000A8AC File Offset: 0x00008AAC
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)2079196633;
			short num2 = num;
			num = (short)737674713;
			switch (num2 == num)
			{
			}
			num = (short)1346240513;
			if (num != 0)
			{
			}
			num = (short)318504960;
			if (num != 0)
			{
			}
			num = (short)1328676864;
			short num3 = num;
			throw new global::System.NotImplementedException();
		}
	}
}
