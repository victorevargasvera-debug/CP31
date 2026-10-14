using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020001C4 RID: 452
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class SummaryCalculatorHolder : global::System.Windows.DependencyObject
	{
		// Token: 0x06001ACB RID: 6859 RVA: 0x00078C1B File Offset: 0x00076E1B
		internal SummaryCalculatorHolder(global::Infragistics.Windows.DataPresenter.SummaryCalculatorSelectionControl selectionControl, global::Infragistics.Windows.DataPresenter.SummaryCalculator calculator, bool isChecked)
		{
			global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNotNull(selectionControl);
			global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNotNull(calculator);
			this._selectionControl = selectionControl;
			this._calculator = calculator;
			this.IsChecked = isChecked;
		}

		// Token: 0x17000779 RID: 1913
		// (get) Token: 0x06001ACC RID: 6860 RVA: 0x00078C44 File Offset: 0x00076E44
		public global::Infragistics.Windows.DataPresenter.SummaryCalculator Calculator
		{
			get
			{
				return this._calculator;
			}
		}

		// Token: 0x1700077A RID: 1914
		// (get) Token: 0x06001ACD RID: 6861 RVA: 0x00078C4C File Offset: 0x00076E4C
		// (set) Token: 0x06001ACE RID: 6862 RVA: 0x00078C5E File Offset: 0x00076E5E
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
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

		// Token: 0x06001ACF RID: 6863 RVA: 0x00078C74 File Offset: 0x00076E74
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

		// Token: 0x1700077B RID: 1915
		// (get) Token: 0x06001AD0 RID: 6864 RVA: 0x00078CFC File Offset: 0x00076EFC
		public global::Infragistics.Windows.DataPresenter.SummaryCalculatorSelectionControl SelectionControl
		{
			get
			{
				return this._selectionControl;
			}
		}

		// Token: 0x04000ACE RID: 2766
		private global::Infragistics.Windows.DataPresenter.SummaryCalculatorSelectionControl _selectionControl;

		// Token: 0x04000ACF RID: 2767
		private global::Infragistics.Windows.DataPresenter.SummaryCalculator _calculator;

		// Token: 0x04000AD0 RID: 2768
		public static readonly global::System.Windows.DependencyProperty IsCheckedProperty = global::System.Windows.DependencyProperty.Register("IsChecked", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.SummaryCalculatorHolder), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.SummaryCalculatorHolder.OnIsCheckedChanged)));
	}
}
