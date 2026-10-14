using System;

namespace Infragistics
{
	// Token: 0x02000032 RID: 50
	public interface IGroupFilterConditions : global::Infragistics.IExpressConditions
	{
		// Token: 0x17000091 RID: 145
		// (get) Token: 0x0600024D RID: 589
		global::Infragistics.LogicalOperator LogicalOperator { get; }

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x0600024E RID: 590
		// (remove) Token: 0x0600024F RID: 591
		event global::System.EventHandler<global::System.EventArgs> CollectionItemChanged;
	}
}
