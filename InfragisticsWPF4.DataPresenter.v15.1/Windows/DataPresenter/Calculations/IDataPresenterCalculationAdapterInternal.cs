using System;

namespace Infragistics.Windows.DataPresenter.Calculations
{
	// Token: 0x02000043 RID: 67
	internal interface IDataPresenterCalculationAdapterInternal : global::Infragistics.Windows.DataPresenter.Calculations.IDataPresenterCalculationAdapter, global::Infragistics.IPropertyChangeListener, global::Infragistics.ITypedPropertyChangeListener<object, string>
	{
		// Token: 0x1700008F RID: 143
		// (get) Token: 0x060002B1 RID: 689
		// (set) Token: 0x060002B2 RID: 690
		global::Infragistics.Windows.DataPresenter.DataPresenterBase DataPresenter { get; set; }
	}
}
