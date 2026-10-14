using System;

namespace Infragistics
{
	// Token: 0x02000050 RID: 80
	internal interface ITypedPropertyChangeListener<TItem, TProperty>
	{
		// Token: 0x06000359 RID: 857
		void OnPropertyValueChanged(TItem dataItem, TProperty property, object extraInfo);
	}
}
