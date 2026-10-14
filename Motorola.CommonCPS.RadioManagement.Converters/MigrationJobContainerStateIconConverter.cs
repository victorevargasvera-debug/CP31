using System;
using System.Globalization;
using System.Windows.Data;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x02000056 RID: 86
	public class MigrationJobContainerStateIconConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06000105 RID: 261 RVA: 0x0000E6CC File Offset: 0x0000C8CC
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 1;
			short num;
			if ((int)value <= 0)
			{
				num = (short)402055641;
				short num2 = num;
				num = (short)527163865;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1832189952;
					if (num != 0)
					{
					}
					return global::Motorola.CommonCPS.RadioManagement.Converters.ZeroBasedAccessTextToOneBasedAccessText.b("쏫ꏭ鿯蛱鯳蓵韷雹鷻탽䏿洁椃欅朇搉伋帍䌏㰑䘓眕簗猙猛匝䄟䰡䔣䄥䴧䜩䤫䀭䐯ᰱ紳唵圷吹伻Խ⌿ⵁ⥃㙅❇⑉⥋⁍⑏絑㩓㥕ⱗ㍙㩛㝝͟͡ၣཥݧѩ㍫ᵭկᅱᝳ፵୷ॹ剻๽", a_);
				}
			}
			num = (short)32440320;
			short num3 = num;
			num = (short)1569849345;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.RadioManagement.Converters.ZeroBasedAccessTextToOneBasedAccessText.b("쏫ꏭ鿯蛱鯳蓵韷雹鷻탽䏿洁椃欅朇搉伋帍䌏㰑䘓眕簗猙猛匝䄟䰡䔣䄥䴧䜩䤫䀭䐯ᰱ紳唵圷吹伻Խ⌿ⵁ⥃㙅❇⑉⥋⁍⑏絑㩓㥕ⱗ㍙㩛㝝͟͡ၣཥݧѩ㍫ᥭᅯqᩳήᙷᵹ剻๽", a_);
		}

		// Token: 0x06000106 RID: 262 RVA: 0x0000E7AC File Offset: 0x0000C9AC
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1638944745;
			short num2 = num;
			num = (short)1313951721;
			switch (num2 == num)
			{
			}
			num = (short)1313996801;
			if (num != 0)
			{
			}
			num = (short)1940914176;
			if (num != 0)
			{
			}
			num = (short)122748928;
			short num3 = num;
			throw new global::System.NotImplementedException();
		}
	}
}
