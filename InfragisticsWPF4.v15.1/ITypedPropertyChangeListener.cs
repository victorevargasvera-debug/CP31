using System;

namespace Infragistics
{
	// Token: 0x02000064 RID: 100
	internal interface ITypedPropertyChangeListener<TItem, TProperty>
	{
		// Token: 0x060003ED RID: 1005
		void OnPropertyValueChanged(TItem dataItem, TProperty property, object extraInfo);
	}
}
