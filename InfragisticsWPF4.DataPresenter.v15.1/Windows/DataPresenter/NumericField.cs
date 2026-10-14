using System;
using Infragistics.Windows.Editors;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020000E4 RID: 228
	public class NumericField : global::Infragistics.Windows.DataPresenter.MaskedTextField
	{
		// Token: 0x1700034C RID: 844
		// (get) Token: 0x06000C7A RID: 3194 RVA: 0x000367EC File Offset: 0x000349EC
		protected override global::System.Type DefaultEditAsType
		{
			get
			{
				global::System.Type dataType = base.DataType;
				if (dataType == typeof(double) || dataType == typeof(float) || dataType == typeof(short) || dataType == typeof(int) || dataType == typeof(long) || dataType == typeof(sbyte) || dataType == typeof(byte) || dataType == typeof(decimal) || dataType == typeof(ushort) || dataType == typeof(uint) || dataType == typeof(ulong))
				{
					return dataType;
				}
				return typeof(double);
			}
		}

		// Token: 0x1700034D RID: 845
		// (get) Token: 0x06000C7B RID: 3195 RVA: 0x000368DB File Offset: 0x00034ADB
		protected override global::System.Type DefaultEditorType
		{
			get
			{
				return typeof(global::Infragistics.Windows.Editors.XamNumericEditor);
			}
		}
	}
}
