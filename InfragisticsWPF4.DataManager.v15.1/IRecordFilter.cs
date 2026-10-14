using System;
using System.ComponentModel;

namespace Infragistics
{
	// Token: 0x02000035 RID: 53
	public interface IRecordFilter : global::Infragistics.IExpressConditions, global::System.ComponentModel.INotifyPropertyChanged
	{
		// Token: 0x17000099 RID: 153
		// (get) Token: 0x06000278 RID: 632
		string FieldName { get; }

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x06000279 RID: 633
		global::System.Type ObjectType { get; }

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x0600027A RID: 634
		global::Infragistics.CachedTypedInfo ObjectTypedInfo { get; }

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x0600027B RID: 635
		global::System.Type FieldType { get; }

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x0600027C RID: 636
		global::Infragistics.ConditionCollection Conditions { get; }
	}
}
