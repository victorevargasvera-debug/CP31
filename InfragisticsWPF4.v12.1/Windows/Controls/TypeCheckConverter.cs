using System;
using System.Globalization;
using System.Windows.Data;

namespace Infragistics.Windows.Controls
{
	// Token: 0x020000F2 RID: 242
	public class TypeCheckConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06000871 RID: 2161 RVA: 0x0001C82C File Offset: 0x0001AA2C
		object global::System.Windows.Data.IValueConverter.Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			global::System.Type type = parameter as global::System.Type;
			if (value == null || !(null != type) || !(this._allowDerivedTypes ? type.IsInstanceOfType(value) : (type == value.GetType())))
			{
				return global::Infragistics.KnownBoxes.FalseBox;
			}
			return global::Infragistics.KnownBoxes.TrueBox;
		}

		// Token: 0x06000872 RID: 2162 RVA: 0x0001C876 File Offset: 0x0001AA76
		object global::System.Windows.Data.IValueConverter.ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			return global::System.Windows.Data.Binding.DoNothing;
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x06000873 RID: 2163 RVA: 0x0001C87D File Offset: 0x0001AA7D
		// (set) Token: 0x06000874 RID: 2164 RVA: 0x0001C885 File Offset: 0x0001AA85
		public bool AllowDerivedTypes
		{
			get
			{
				return this._allowDerivedTypes;
			}
			set
			{
				this._allowDerivedTypes = value;
			}
		}

		// Token: 0x04000397 RID: 919
		private bool _allowDerivedTypes = true;
	}
}
