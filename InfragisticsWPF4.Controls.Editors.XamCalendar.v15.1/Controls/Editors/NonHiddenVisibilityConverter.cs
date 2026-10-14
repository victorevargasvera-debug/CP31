using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;

namespace Infragistics.Controls.Editors
{
	// Token: 0x0200004E RID: 78
	internal class NonHiddenVisibilityConverter : global::System.ComponentModel.EnumConverter
	{
		// Token: 0x0600032E RID: 814 RVA: 0x0000F152 File Offset: 0x0000D352
		public NonHiddenVisibilityConverter() : base(typeof(global::System.Windows.Visibility))
		{
		}

		// Token: 0x0600032F RID: 815 RVA: 0x0000F164 File Offset: 0x0000D364
		public override bool GetStandardValuesSupported(global::System.ComponentModel.ITypeDescriptorContext context)
		{
			return true;
		}

		// Token: 0x06000330 RID: 816 RVA: 0x0000F168 File Offset: 0x0000D368
		public override global::System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(global::System.ComponentModel.ITypeDescriptorContext context)
		{
			return new global::System.ComponentModel.TypeConverter.StandardValuesCollection(new global::System.Collections.Generic.List<global::System.Windows.Visibility>
			{
				global::System.Windows.Visibility.Visible,
				global::System.Windows.Visibility.Collapsed
			});
		}

		// Token: 0x06000331 RID: 817 RVA: 0x0000F18F File Offset: 0x0000D38F
		public override bool GetStandardValuesExclusive(global::System.ComponentModel.ITypeDescriptorContext context)
		{
			return true;
		}
	}
}
