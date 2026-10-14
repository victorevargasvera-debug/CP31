using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Input;

namespace Infragistics
{
	// Token: 0x02000064 RID: 100
	public class CursorTypeConverter : global::System.ComponentModel.TypeConverter
	{
		// Token: 0x060005D8 RID: 1496 RVA: 0x000169B1 File Offset: 0x00014BB1
		public override bool CanConvertFrom(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Type sourceType)
		{
			return sourceType == typeof(string) || base.CanConvertFrom(context, sourceType);
		}

		// Token: 0x060005D9 RID: 1497 RVA: 0x000169CF File Offset: 0x00014BCF
		public override bool CanConvertTo(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Type destinationType)
		{
			return base.CanConvertTo(context, destinationType);
		}

		// Token: 0x060005DA RID: 1498 RVA: 0x000169DC File Offset: 0x00014BDC
		public override object ConvertFrom(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Globalization.CultureInfo culture, object value)
		{
			string text = value as string;
			if (string.IsNullOrEmpty(text))
			{
				return global::System.Windows.Input.Cursors.Arrow;
			}
			string key;
			switch (key = text)
			{
			case "Arrow":
				return global::System.Windows.Input.Cursors.Arrow;
			case "Hand":
				return global::System.Windows.Input.Cursors.Hand;
			case "IBeam":
				return global::System.Windows.Input.Cursors.IBeam;
			case "None":
				return global::System.Windows.Input.Cursors.None;
			case "SizeNS":
				return global::System.Windows.Input.Cursors.SizeNS;
			case "SizeWE":
				return global::System.Windows.Input.Cursors.SizeWE;
			case "Wait":
				return global::System.Windows.Input.Cursors.Wait;
			}
			return global::System.Windows.Input.Cursors.Arrow;
		}
	}
}
