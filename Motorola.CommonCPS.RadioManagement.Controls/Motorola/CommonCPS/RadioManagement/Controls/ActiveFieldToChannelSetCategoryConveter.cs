using System;
using System.Globalization;
using System.Windows.Data;
using Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x020000F8 RID: 248
	internal class ActiveFieldToChannelSetCategoryConveter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x060006EA RID: 1770 RVA: 0x0006F1A0 File Offset: 0x0006D3A0
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 8;
			short num = (short)425263104;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				global::Motorola.CommonCPS.RadioManagement.UIModels.CollectionField collectionField;
				for (;;)
				{
					IL_26:
					num = (short)1806827521;
					if (num != 0)
					{
					}
					num = (short)990969856;
					short num3 = num;
					switch (0)
					{
					case 0:
						goto IL_A1;
					}
					global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase fieldBase;
					for (;;)
					{
						IL_82:
						switch (num2)
						{
						case 0:
							goto IL_132;
						case 1:
						{
							global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory setCategory;
							if (setCategory.IsTopSet)
							{
								num = (short)148373506;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1E9;
						}
						case 2:
						{
							global::Motorola.CommonCPS.RadioManagement.UIModels.Set set;
							collectionField = (set.Fields[global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("쪡얣좥욧쾩삫", a_)] as global::Motorola.CommonCPS.RadioManagement.UIModels.CollectionField);
							num = (short)479920132;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
						{
							if (fieldBase == null)
							{
								num = (short)1331167237;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)189254835;
							short num4 = num;
							num = (short)336186547;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_26;
							default:
							{
								num = (short)125894656;
								if (num != 0)
								{
								}
								global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory setCategory = (fieldBase.Parent as global::Motorola.CommonCPS.RadioManagement.UIModels.Set).Parent as global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory;
								global::Motorola.CommonCPS.RadioManagement.UIModels.Set set = fieldBase.Parent as global::Motorola.CommonCPS.RadioManagement.UIModels.Set;
								num = (short)1629093889;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							break;
						}
						case 4:
							if (collectionField != null)
							{
								num = (short)16908288;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1E9;
						case 5:
							goto IL_D7;
						}
						break;
					}
					IL_A1:
					fieldBase = (value as global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase);
					num = (short)1504378883;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_82;
				}
				IL_D7:
				return null;
				IL_132:
				return collectionField.SetCategory;
				IL_1E9:
				return null;
			}
			}
		}

		// Token: 0x060006EB RID: 1771 RVA: 0x0006F398 File Offset: 0x0006D598
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)158830646;
			short num2 = num;
			num = (short)1643483190;
			switch (num2 == num)
			{
			}
			num = (short)715194369;
			if (num != 0)
			{
			}
			num = (short)2025455616;
			short num3 = num;
			num = (short)1664876544;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
