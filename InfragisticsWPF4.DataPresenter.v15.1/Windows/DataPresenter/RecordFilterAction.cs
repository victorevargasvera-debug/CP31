using System;
using System.ComponentModel;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000295 RID: 661
	[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Windows.DataPresenter.RecordFilterActionTypeConverter))]
	public enum RecordFilterAction
	{
		// Token: 0x0400102E RID: 4142
		Default,
		// Token: 0x0400102F RID: 4143
		Hide,
		// Token: 0x04001030 RID: 4144
		Disable,
		// Token: 0x04001031 RID: 4145
		ReduceOpacity,
		// Token: 0x04001032 RID: 4146
		DoNothing,
		// Token: 0x04001033 RID: 4147
		[global::System.Obsolete("Use 'ReduceOpacity' or 'DoNothing' instead. Note: 'None' is equivalent to 'ReduceOpacity'", false)]
		None = 3
	}
}
