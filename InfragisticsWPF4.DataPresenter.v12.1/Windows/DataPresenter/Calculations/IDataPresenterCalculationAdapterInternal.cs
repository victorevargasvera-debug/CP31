using System;

namespace Infragistics.Windows.DataPresenter.Calculations
{
	// Token: 0x02000043 RID: 67
	internal interface IDataPresenterCalculationAdapterInternal : global::Infragistics.Windows.DataPresenter.Calculations.IDataPresenterCalculationAdapter, global::Infragistics.IPropertyChangeListener, global::Infragistics.ITypedPropertyChangeListener<object, string>
	{
		// Token: 0x17000088 RID: 136
		// (get) Token: 0x0600029A RID: 666
		// (set) Token: 0x0600029B RID: 667
		global::Infragistics.Windows.DataPresenter.DataPresenterBase DataPresenter { get; set; }
	}
}
