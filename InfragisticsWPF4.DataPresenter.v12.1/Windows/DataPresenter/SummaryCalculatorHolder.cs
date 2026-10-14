using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020001A1 RID: 417
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class SummaryCalculatorHolder : global::System.Windows.DependencyObject
	{
		// Token: 0x0600170E RID: 5902 RVA: 0x00066083 File Offset: 0x00064283
		internal SummaryCalculatorHolder(global::Infragistics.Windows.DataPresenter.SummaryCalculatorSelectionControl selectionControl, global::Infragistics.Windows.DataPresenter.SummaryCalculator calculator, bool isChecked)
		{
			global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNotNull(selectionControl);
			global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNotNull(calculator);
			this._selectionControl = selectionControl;
			this._calculator = calculator;
			this.IsChecked = isChecked;
		}

		// Token: 0x17000617 RID: 1559
		// (get) Token: 0x0600170F RID: 5903 RVA: 0x000660AC File Offset: 0x000642AC
		public global::Infragistics.Windows.DataPresenter.SummaryCalculator Calculator
		{
			get
			{
				return this._calculator;
			}
		}

		// Token: 0x17000618 RID: 1560
		// (get) Token: 0x06001710 RID: 5904 RVA: 0x000660B4 File Offset: 0x000642B4
		// (set) Token: 0x06001711 RID: 5905 RVA: 0x000660C6 File Offset: 0x000642C6
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Bindable(true)]
		public bool IsChecked
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.SummaryCalculatorHolder.IsCheckedProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.SummaryCalculatorHolder.IsCheckedProperty, value);
			}
		}

		// Token: 0x06001712 RID: 5906 RVA: 0x000660DC File Offset: 0x000642DC
		private static void OnIsCheckedChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.SummaryCalculatorHolder summaryCalculatorHolder = (global::Infragistics.Windows.DataPresenter.SummaryCalculatorHolder)dependencyObject;
			bool flag = (bool)e.NewValue;
			if (flag)
			{
				global::Infragistics.Windows.DataPresenter.SummaryCalculatorSelectionControl selectionControl = summaryCalculatorHolder.SelectionControl;
				if (selectionControl != null && !selectionControl.AllowMultipleSummaries)
				{
					global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.SummaryCalculatorHolder> summaryCalculatorHolders = selectionControl.SummaryCalculatorHolders;
					if (summaryCalculatorHolders != null)
					{
						foreach (global::Infragistics.Windows.DataPresenter.SummaryCalculatorHolder summaryCalculatorHolder2 in summaryCalculatorHolders)
						{
							if (summaryCalculatorHolder2 != summaryCalculatorHolder)
							{
								summaryCalculatorHolder2.IsChecked = false;
							}
						}
					}
				}
			}
		}

		// Token: 0x17000619 RID: 1561
		// (get) Token: 0x06001713 RID: 5907 RVA: 0x00066164 File Offset: 0x00064364
		public global::Infragistics.Windows.DataPresenter.SummaryCalculatorSelectionControl SelectionControl
		{
			get
			{
				return this._selectionControl;
			}
		}

		// Token: 0x04000904 RID: 2308
		private global::Infragistics.Windows.DataPresenter.SummaryCalculatorSelectionControl _selectionControl;

		// Token: 0x04000905 RID: 2309
		private global::Infragistics.Windows.DataPresenter.SummaryCalculator _calculator;

		// Token: 0x04000906 RID: 2310
		public static readonly global::System.Windows.DependencyProperty IsCheckedProperty = global::System.Windows.DependencyProperty.Register("IsChecked", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.SummaryCalculatorHolder), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.SummaryCalculatorHolder.OnIsCheckedChanged)));
	}
}
