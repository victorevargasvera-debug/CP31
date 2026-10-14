using System;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000038 RID: 56
	internal struct AutoSizeFieldSettings
	{
		// Token: 0x06000257 RID: 599 RVA: 0x00009C31 File Offset: 0x00007E31
		internal AutoSizeFieldSettings(global::Infragistics.Windows.DataPresenter.Field field)
		{
			this.Options = field.AutoSizeOptionsResolved;
			this.Scope = field.AutoSizeScopeResolved;
		}

		// Token: 0x06000258 RID: 600 RVA: 0x00009C4B File Offset: 0x00007E4B
		internal AutoSizeFieldSettings(global::Infragistics.Windows.DataPresenter.FieldAutoSizeOptions options, global::Infragistics.Windows.DataPresenter.FieldAutoSizeScope scope)
		{
			this.Options = options;
			this.Scope = scope;
		}

		// Token: 0x0400008E RID: 142
		internal global::Infragistics.Windows.DataPresenter.FieldAutoSizeOptions Options;

		// Token: 0x0400008F RID: 143
		internal global::Infragistics.Windows.DataPresenter.FieldAutoSizeScope Scope;
	}
}
