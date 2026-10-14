using System;
using System.Globalization;
using System.Windows.Data;
using Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x0200001F RID: 31
	internal class PeudoCallIdFieldToDatacontextConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06000060 RID: 96 RVA: 0x0000743C File Offset: 0x0000563C
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 1;
			switch (0)
			{
			case 0:
				goto IL_31;
			}
			int num;
			global::Motorola.CommonCPS.RadioManagement.UIModels.Set set;
			short num2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					goto IL_CD;
				case 1:
					if (set != null)
					{
						num2 = (short)1096482821;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_D2;
				case 2:
					goto IL_188;
				case 3:
				{
					string controlType;
					if (controlType == parameter.ToString())
					{
						num2 = (short)1775042560;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1D0;
				}
				case 4:
				{
					num2 = (short)431609570;
					short num3 = num2;
					num2 = (short)1127143138;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num2 = (short)223870976;
						if (num2 != 0)
						{
						}
						num2 = (short)1248591873;
						if (num2 != 0)
						{
						}
						if (set.Fields.Count == 0)
						{
							num2 = (short)1710686210;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						string controlType = (set.Fields[global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("즘ﺚﮞ캠쒤쮦얨즬", a_)] as global::Motorola.CommonCPS.RadioManagement.UIModels.IControlType).ControlType;
						num2 = (short)2068054019;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 5:
					num2 = (short)2032926724;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_31;
			}
			IL_CD:
			num2 = (short)375390208;
			short num4 = num2;
			return set.Fields[global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("즘ﺚﮞ캠쒤쮦얨즬", a_)];
			IL_D2:
			return null;
			IL_188:
			goto IL_D2;
			IL_1D0:
			return null;
			IL_31:
			set = (value as global::Motorola.CommonCPS.RadioManagement.UIModels.Set);
			num2 = (short)1839333377;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000061 RID: 97 RVA: 0x0000761C File Offset: 0x0000581C
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)865992705;
			if (num != 0)
			{
			}
			num = (short)1020347892;
			short num2 = num;
			num = (short)1806845428;
			switch (num2 == num)
			{
			}
			num = (short)100925440;
			if (num != 0)
			{
			}
			num = (short)946667520;
			short num3 = num;
			throw new global::System.NotImplementedException();
		}
	}
}
