using System;
using System.Collections.Generic;
using System.ComponentModel;
using Infragistics.Collections;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000151 RID: 337
	internal class ConditionInfoCollection : global::Infragistics.Collections.ObservableCollectionExtended<global::Infragistics.Windows.DataPresenter.ConditionInfo>, global::System.ComponentModel.ITypedList
	{
		// Token: 0x06001452 RID: 5202 RVA: 0x0005B316 File Offset: 0x00059516
		internal ConditionInfoCollection(global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.ConditionInfo> list) : base(list)
		{
		}

		// Token: 0x06001453 RID: 5203 RVA: 0x0005B320 File Offset: 0x00059520
		global::System.ComponentModel.PropertyDescriptorCollection global::System.ComponentModel.ITypedList.GetItemProperties(global::System.ComponentModel.PropertyDescriptor[] listAccessors)
		{
			return new global::System.ComponentModel.PropertyDescriptorCollection(new global::System.ComponentModel.PropertyDescriptor[]
			{
				new global::Infragistics.Windows.DataPresenter.CustomPropertyDescriptor("ComparisonOperator"),
				new global::Infragistics.Windows.DataPresenter.CustomPropertyDescriptor("Group"),
				new global::Infragistics.Windows.DataPresenter.CustomPropertyDescriptor("Value"),
				new global::Infragistics.Windows.DataPresenter.CustomPropertyDescriptor("ErrorDescription")
			});
		}

		// Token: 0x06001454 RID: 5204 RVA: 0x0005B36E File Offset: 0x0005956E
		string global::System.ComponentModel.ITypedList.GetListName(global::System.ComponentModel.PropertyDescriptor[] listAccessors)
		{
			return string.Empty;
		}
	}
}
