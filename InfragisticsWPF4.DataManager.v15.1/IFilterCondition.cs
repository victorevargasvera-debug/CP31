using System;
using System.ComponentModel;

namespace Infragistics
{
	// Token: 0x0200002F RID: 47
	public interface IFilterCondition : global::Infragistics.IExpressConditions, global::System.ComponentModel.INotifyPropertyChanged
	{
		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000236 RID: 566
		// (set) Token: 0x06000237 RID: 567
		global::Infragistics.IRecordFilter Parent { get; set; }
	}
}
