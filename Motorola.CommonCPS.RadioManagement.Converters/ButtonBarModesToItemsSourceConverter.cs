using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Windows.Data;
using Motorola.CommonCPS.RadioManagement.ConvertorExtensions;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x0200004A RID: 74
	public class ButtonBarModesToItemsSourceConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x060000E0 RID: 224 RVA: 0x0000C278 File Offset: 0x0000A478
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1349859926;
			short num2 = num;
			num = (short)1442331222;
			global::System.Collections.Generic.List<string> list;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)654245888;
				if (num != 0)
				{
				}
				num = (short)120389633;
				if (num != 0)
				{
				}
				num = (short)466223104;
				short num3 = num;
				global::System.Collections.ObjectModel.Collection<global::Motorola.CommonCPS.RadioManagement.UIModels.ButtonBarModeEnum> collection = value as global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.ButtonBarModeEnum>;
				list = new global::System.Collections.Generic.List<string>();
				global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.ButtonBarModeEnum> enumerator = collection.GetEnumerator();
				try
				{
					num = (short)340983810;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							num = (short)886636548;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_EB;
							}
							continue;
						case 3:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)558432256;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.RadioManagement.UIModels.ButtonBarModeEnum mode = enumerator.Current;
							list.Add(global::Motorola.CommonCPS.RadioManagement.ConvertorExtensions.Enum2ResourceString.ButtonBarModeConverter.GetResouce(mode));
							num = (short)1639776257;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
							goto IL_163;
						}
						IL_117:
						num = (short)1327366147;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_EB:
						goto IL_117;
					}
					IL_163:;
				}
				finally
				{
					num = (short)2022113280;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_195;
							}
							continue;
						case 1:
							enumerator.Dispose();
							num = (short)1912340482;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_1C9;
						}
						IL_195:
						if (enumerator == null)
						{
							break;
						}
						num = (short)1896022017;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_1C9:;
				}
				break;
			}
			}
			return list;
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x0000C464 File Offset: 0x0000A664
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)642903050;
			short num2 = num;
			num = (short)1454500874;
			switch (num2 == num)
			{
			}
			num = (short)802619393;
			if (num != 0)
			{
			}
			num = (short)1778319360;
			short num3 = num;
			num = (short)1662320640;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
