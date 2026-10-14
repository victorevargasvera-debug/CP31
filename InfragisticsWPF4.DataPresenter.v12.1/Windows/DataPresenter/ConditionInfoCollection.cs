using System;
using System.Collections.Generic;
using System.ComponentModel;
using Infragistics.Collections;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000135 RID: 309
	internal class ConditionInfoCollection : global::Infragistics.Collections.ObservableCollectionExtended<global::Infragistics.Windows.DataPresenter.ConditionInfo>, global::System.ComponentModel.ITypedList
	{
		// Token: 0x060010E9 RID: 4329 RVA: 0x0004A01A File Offset: 0x0004821A
		internal ConditionInfoCollection(global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.ConditionInfo> list) : base(list)
		{
		}

		// Token: 0x060010EA RID: 4330 RVA: 0x0004A024 File Offset: 0x00048224
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

		// Token: 0x060010EB RID: 4331 RVA: 0x0004A072 File Offset: 0x00048272
		string global::System.ComponentModel.ITypedList.GetListName(global::System.ComponentModel.PropertyDescriptor[] listAccessors)
		{
			return string.Empty;
		}
	}
}
