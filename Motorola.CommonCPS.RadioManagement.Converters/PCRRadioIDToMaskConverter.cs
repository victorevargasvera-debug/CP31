using System;
using System.Globalization;
using System.Windows.Data;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x02000063 RID: 99
	public class PCRRadioIDToMaskConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x0600012D RID: 301 RVA: 0x000107B8 File Offset: 0x0000E9B8
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 19;
			short num;
			if ((bool)value)
			{
				num = (short)1911327831;
				short num2 = num;
				num = (short)965774423;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_8C;
				case 1:
					break;
				default:
				{
					num = (short)1493893120;
					short num3 = num;
					break;
				}
				}
				num = (short)1761214464;
				if (num != 0)
				{
				}
				IL_8C:
				return global::Motorola.CommonCPS.RadioManagement.Converters.ZeroBasedAccessTextToOneBasedAccessText.b("藽滿省椃搅洇砉㘋㸍㴏‑ℓ⌕攗㐙望瀝唟伡䘣䌥娧ဩᰫ̭ȯܱĳ䬵ᘷ䄹刻䬽ⴿ⁁⅃㑅片穉態籍敏村⥓硕⍗㑙⥛㍝ɟݡᙣ履塧䝩幫孭䕯ཱ", a_);
			}
			num = (short)2024603649;
			if (num != 0)
			{
			}
			return null;
		}

		// Token: 0x0600012E RID: 302 RVA: 0x0001088C File Offset: 0x0000EA8C
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1451978893;
			short num2 = num;
			num = (short)1820291213;
			switch (num2 == num)
			{
			}
			num = (short)465567745;
			if (num != 0)
			{
			}
			num = (short)814219264;
			short num3 = num;
			num = (short)181272576;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
