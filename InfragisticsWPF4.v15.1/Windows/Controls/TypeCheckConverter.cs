using System;
using System.Globalization;
using System.Windows.Data;

namespace Infragistics.Windows.Controls
{
	// Token: 0x02000110 RID: 272
	public class TypeCheckConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06000970 RID: 2416 RVA: 0x000203F4 File Offset: 0x0001E5F4
		object global::System.Windows.Data.IValueConverter.Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			global::System.Type type = parameter as global::System.Type;
			if (value == null || !(null != type) || !(this._allowDerivedTypes ? type.IsInstanceOfType(value) : (type == value.GetType())))
			{
				return global::Infragistics.KnownBoxes.FalseBox;
			}
			return global::Infragistics.KnownBoxes.TrueBox;
		}

		// Token: 0x06000971 RID: 2417 RVA: 0x0002043E File Offset: 0x0001E63E
		object global::System.Windows.Data.IValueConverter.ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			return global::System.Windows.Data.Binding.DoNothing;
		}

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x06000972 RID: 2418 RVA: 0x00020445 File Offset: 0x0001E645
		// (set) Token: 0x06000973 RID: 2419 RVA: 0x0002044D File Offset: 0x0001E64D
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

		// Token: 0x0400044A RID: 1098
		private bool _allowDerivedTypes = true;
	}
}
