using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Media;

namespace Infragistics
{
	// Token: 0x02000067 RID: 103
	public class SolidBrushCollectionConverter : global::System.ComponentModel.TypeConverter
	{
		// Token: 0x060005E4 RID: 1508 RVA: 0x00016C47 File Offset: 0x00014E47
		public override bool CanConvertFrom(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Type sourceType)
		{
			return sourceType == typeof(string) || base.CanConvertFrom(context, sourceType);
		}

		// Token: 0x060005E5 RID: 1509 RVA: 0x00016C68 File Offset: 0x00014E68
		public override object ConvertFrom(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Globalization.CultureInfo culture, object value)
		{
			string text = value as string;
			if (text == null)
			{
				return base.ConvertFrom(context, culture, value);
			}
			global::Infragistics.BrushCollection brushCollection = new global::Infragistics.BrushCollection();
			foreach (string value2 in text.Split(new char[]
			{
				' '
			}))
			{
				global::System.Windows.Media.Color color = global::Infragistics.ColorConverter.FromString(value2);
				brushCollection.Add(new global::System.Windows.Media.SolidColorBrush(color));
			}
			return brushCollection;
		}

		// Token: 0x060005E6 RID: 1510 RVA: 0x00016CD4 File Offset: 0x00014ED4
		public override bool CanConvertTo(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Type destinationType)
		{
			return !(destinationType == typeof(string)) && base.CanConvertTo(context, destinationType);
		}
	}
}
