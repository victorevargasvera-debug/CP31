using System;
using System.ComponentModel;
using System.Globalization;

namespace Infragistics.Windows.Controls
{
	// Token: 0x02000161 RID: 353
	public class SpecialFilterOperandTypeConverter : global::System.ComponentModel.TypeConverter
	{
		// Token: 0x06000C01 RID: 3073 RVA: 0x00027655 File Offset: 0x00025855
		public override bool CanConvertFrom(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Type sourceType)
		{
			return sourceType == typeof(string);
		}

		// Token: 0x06000C02 RID: 3074 RVA: 0x00027667 File Offset: 0x00025867
		public override object ConvertFrom(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Globalization.CultureInfo culture, object value)
		{
			if (!(value is string))
			{
				throw base.GetConvertFromException(value);
			}
			return value;
		}

		// Token: 0x06000C03 RID: 3075 RVA: 0x0002767C File Offset: 0x0002587C
		public override global::System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(global::System.ComponentModel.ITypeDescriptorContext context)
		{
			global::Infragistics.Windows.Controls.SpecialFilterOperandBase[] registeredOperands = global::Infragistics.Windows.Controls.SpecialFilterOperands.GetRegisteredOperands();
			string[] array = new string[registeredOperands.Length];
			for (int i = 0; i < registeredOperands.Length; i++)
			{
				array[i] = registeredOperands[i].Name;
			}
			return new global::System.ComponentModel.TypeConverter.StandardValuesCollection(array);
		}

		// Token: 0x06000C04 RID: 3076 RVA: 0x000276B7 File Offset: 0x000258B7
		public override bool GetStandardValuesSupported(global::System.ComponentModel.ITypeDescriptorContext context)
		{
			return true;
		}
	}
}
