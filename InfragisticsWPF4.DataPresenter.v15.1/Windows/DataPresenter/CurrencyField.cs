using System;
using Infragistics.Windows.Editors;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020000E2 RID: 226
	public class CurrencyField : global::Infragistics.Windows.DataPresenter.MaskedTextField
	{
		// Token: 0x17000346 RID: 838
		// (get) Token: 0x06000C6B RID: 3179 RVA: 0x00036672 File Offset: 0x00034872
		protected override global::System.Type DefaultEditAsType
		{
			get
			{
				return typeof(decimal);
			}
		}

		// Token: 0x17000347 RID: 839
		// (get) Token: 0x06000C6C RID: 3180 RVA: 0x0003667E File Offset: 0x0003487E
		protected override global::System.Type DefaultEditorType
		{
			get
			{
				return typeof(global::Infragistics.Windows.Editors.XamCurrencyEditor);
			}
		}
	}
}
