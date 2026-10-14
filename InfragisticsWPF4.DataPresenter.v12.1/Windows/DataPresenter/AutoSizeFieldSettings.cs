using System;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000038 RID: 56
	internal struct AutoSizeFieldSettings
	{
		// Token: 0x06000240 RID: 576 RVA: 0x000092F9 File Offset: 0x000074F9
		internal AutoSizeFieldSettings(global::Infragistics.Windows.DataPresenter.Field field)
		{
			this.Options = field.AutoSizeOptionsResolved;
			this.Scope = field.AutoSizeScopeResolved;
		}

		// Token: 0x06000241 RID: 577 RVA: 0x00009313 File Offset: 0x00007513
		internal AutoSizeFieldSettings(global::Infragistics.Windows.DataPresenter.FieldAutoSizeOptions options, global::Infragistics.Windows.DataPresenter.FieldAutoSizeScope scope)
		{
			this.Options = options;
			this.Scope = scope;
		}

		// Token: 0x0400007C RID: 124
		internal global::Infragistics.Windows.DataPresenter.FieldAutoSizeOptions Options;

		// Token: 0x0400007D RID: 125
		internal global::Infragistics.Windows.DataPresenter.FieldAutoSizeScope Scope;
	}
}
