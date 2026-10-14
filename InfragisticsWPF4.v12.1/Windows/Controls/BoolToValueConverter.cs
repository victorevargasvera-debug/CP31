using System;

namespace Infragistics.Windows.Controls
{
	// Token: 0x020000ED RID: 237
	public class BoolToValueConverter : global::Infragistics.Windows.Controls.BoolConverter
	{
		// Token: 0x1700016E RID: 366
		// (get) Token: 0x06000864 RID: 2148 RVA: 0x0001C75C File Offset: 0x0001A95C
		// (set) Token: 0x06000865 RID: 2149 RVA: 0x0001C764 File Offset: 0x0001A964
		public object FalseConvertValue
		{
			get
			{
				return this.falseValue;
			}
			set
			{
				this.falseValue = value;
			}
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x06000866 RID: 2150 RVA: 0x0001C76D File Offset: 0x0001A96D
		// (set) Token: 0x06000867 RID: 2151 RVA: 0x0001C775 File Offset: 0x0001A975
		public object TrueConvertValue
		{
			get
			{
				return this.trueValue;
			}
			set
			{
				this.trueValue = value;
			}
		}
	}
}
