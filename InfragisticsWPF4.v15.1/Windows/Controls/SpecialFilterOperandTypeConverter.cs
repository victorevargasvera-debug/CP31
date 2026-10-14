using System;
using System.ComponentModel;
using System.Globalization;

namespace Infragistics.Windows.Controls
{
	// Token: 0x02000183 RID: 387
	public class SpecialFilterOperandTypeConverter : global::System.ComponentModel.TypeConverter
	{
		// Token: 0x06000D16 RID: 3350 RVA: 0x0002B7DD File Offset: 0x000299DD
		public override bool CanConvertFrom(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Type sourceType)
		{
			return sourceType == typeof(string);
		}

		// Token: 0x06000D17 RID: 3351 RVA: 0x0002B7EF File Offset: 0x000299EF
		public override object ConvertFrom(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Globalization.CultureInfo culture, object value)
		{
			if (!(value is string))
			{
				throw base.GetConvertFromException(value);
			}
			return value;
		}

		// Token: 0x06000D18 RID: 3352 RVA: 0x0002B804 File Offset: 0x00029A04
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

		// Token: 0x06000D19 RID: 3353 RVA: 0x0002B83F File Offset: 0x00029A3F
		public override bool GetStandardValuesSupported(global::System.ComponentModel.ITypeDescriptorContext context)
		{
			return true;
		}
	}
}
