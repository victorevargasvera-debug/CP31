using System;
using System.Globalization;
using System.Windows.Data;
using Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree;
using Motorola.CommonCPS.RadioManagement.Global;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x02000028 RID: 40
	internal class SetCategoryAddSetCopiesToResourceConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x0600007B RID: 123 RVA: 0x00008AE4 File Offset: 0x00006CE4
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 6;
			switch (0)
			{
			case 0:
				goto IL_31;
			}
			int num;
			global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory setCategory;
			short num2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					if (setCategory != null)
					{
						num2 = (short)234749953;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1D8;
				case 1:
					goto IL_8D;
				case 2:
				{
					num2 = (short)1305128247;
					short num3 = num2;
					num2 = (short)832679223;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_8D;
					default:
						num2 = (short)1655046144;
						if (num2 != 0)
						{
						}
						if (setCategory.IsTopSet)
						{
							num2 = (short)509149189;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_17A;
					}
					break;
				}
				case 3:
					if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.IsReduceShareableSetMode)
					{
						num2 = (short)1921908740;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_8F;
				case 4:
					goto IL_1D3;
				case 5:
					num2 = (short)1168900099;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_31;
				IL_8D:
				num2 = (short)1474035714;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_8F:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.ResourceManager.GetString(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("첝ﮣ쮧\udea9얫솭\udeaf튵\udcb7惡펻캽릿", a_), global::Motorola.CommonCPS.ResourceRepository.Resources.Culture);
			IL_17A:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.ResourceManager.GetString(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("첝ﮣ쮧\udea9얫솭\udeaf튵\udcb7惡펻캽ꦿꟁ럃", a_), global::Motorola.CommonCPS.ResourceRepository.Resources.Culture);
			IL_1D3:
			num2 = (short)575864832;
			short num4 = num2;
			return global::Motorola.CommonCPS.ResourceRepository.Resources.ResourceManager.GetString(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("첝ﮣ쮧\udea9얫솭\udeaf튵\udcb7惡펻캽ꦿꟁ럃", a_), global::Motorola.CommonCPS.ResourceRepository.Resources.Culture);
			IL_1D8:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.ResourceManager.GetString(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("첝ﮣ쮧\udea9얫솭\udeaf튵\udcb7惡펻캽릿", a_), global::Motorola.CommonCPS.ResourceRepository.Resources.Culture);
			IL_31:
			num2 = (short)1364000769;
			if (num2 != 0)
			{
			}
			setCategory = (value as global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory);
			num2 = (short)231538688;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00008CE8 File Offset: 0x00006EE8
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)79364096;
			short num2 = num;
			num = (short)1305649966;
			short num3 = num;
			num = (short)1238541102;
			switch (num3 == num)
			{
			}
			num = (short)1658847233;
			if (num != 0)
			{
			}
			num = (short)200343552;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
