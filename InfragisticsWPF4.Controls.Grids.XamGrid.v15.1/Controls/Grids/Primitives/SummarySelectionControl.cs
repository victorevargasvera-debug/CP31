using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x02000155 RID: 341
	public class SummarySelectionControl : global::Infragistics.Controls.Grids.Primitives.SelectionControl
	{
		// Token: 0x06000B11 RID: 2833 RVA: 0x00029968 File Offset: 0x00027B68
		static SummarySelectionControl()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Controls.Grids.Primitives.SummarySelectionControl), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Controls.Grids.Primitives.SummarySelectionControl)));
		}

		// Token: 0x06000B12 RID: 2834 RVA: 0x00029A00 File Offset: 0x00027C00
		public SummarySelectionControl()
		{
			base.Loaded += this.SummarySelectionControl_Loaded;
			base.IsTabStop = false;
			this.OKCaption = global::Infragistics.SRGrid.GetString("OKCaption");
			this.CancelCaption = global::Infragistics.SRGrid.GetString("CancelCaption");
		}

		// Token: 0x06000B13 RID: 2835 RVA: 0x00029A4C File Offset: 0x00027C4C
		private void SummarySelectionControl_Loaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			this.SetupSelectionBox();
		}

		// Token: 0x06000B14 RID: 2836 RVA: 0x00029A54 File Offset: 0x00027C54
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();
			this.SetupSelectionBox();
		}

		// Token: 0x06000B15 RID: 2837 RVA: 0x00029A64 File Offset: 0x00027C64
		protected internal override void AcceptChanges()
		{
			global::Infragistics.Controls.Grids.CellBase cell = base.Cell;
			string key = cell.Column.Key;
			global::Infragistics.SummaryDefinitionCollection summaryDefinitionCollectionResolved = ((global::Infragistics.Controls.Grids.RowsManager)cell.Row.Manager).SummaryDefinitionCollectionResolved;
			global::System.Collections.ObjectModel.ReadOnlyCollection<global::Infragistics.SummaryDefinition> definitionsByKey = summaryDefinitionCollectionResolved.GetDefinitionsByKey(key);
			foreach (object obj in base.Panel.Children)
			{
				global::System.Windows.Controls.CheckBox checkBox = (global::System.Windows.Controls.CheckBox)obj;
				global::Infragistics.SummaryOperandBase summaryOperandBase = (global::Infragistics.SummaryOperandBase)checkBox.Tag;
				bool value = checkBox.IsChecked.Value;
				if (value)
				{
					bool flag = false;
					foreach (global::Infragistics.SummaryDefinition summaryDefinition in definitionsByKey)
					{
						if (summaryDefinition.SummaryOperand == summaryOperandBase)
						{
							flag = true;
							break;
						}
					}
					if (!flag)
					{
						summaryDefinitionCollectionResolved.Add(new global::Infragistics.SummaryDefinition
						{
							ColumnKey = key,
							SummaryOperand = summaryOperandBase
						});
						summaryOperandBase.IsApplied = true;
					}
				}
				else
				{
					global::Infragistics.SummaryDefinition summaryDefinition2 = null;
					foreach (global::Infragistics.SummaryDefinition summaryDefinition3 in definitionsByKey)
					{
						if (summaryDefinition3.SummaryOperand == summaryOperandBase)
						{
							summaryDefinition2 = summaryDefinition3;
							break;
						}
					}
					if (summaryDefinition2 != null)
					{
						summaryDefinitionCollectionResolved.Remove(summaryDefinition2);
						summaryDefinition2.SummaryOperand.IsApplied = false;
					}
				}
			}
			global::Infragistics.Controls.Grids.XamGrid grid = cell.Row.ColumnLayout.Grid;
			grid.ResetPanelRows();
			grid.InvalidateScrollPanel(false);
		}

		// Token: 0x06000B16 RID: 2838 RVA: 0x00029C44 File Offset: 0x00027E44
		protected override void SetupSelectionBox()
		{
			if (base.Panel != null && base.Cell != null && base.Cell.Column != null)
			{
				base.Panel.Children.Clear();
				global::Infragistics.SummaryOperandCollection summaryOperands = base.Cell.Column.SummaryColumnSettings.SummaryOperands;
				foreach (global::Infragistics.SummaryOperandBase summaryOperandBase in summaryOperands)
				{
					base.Panel.Children.Add(new global::System.Windows.Controls.CheckBox
					{
						Content = summaryOperandBase.SelectionDisplayLabelResolved,
						Tag = summaryOperandBase,
						Style = base.CheckBoxStyle
					});
				}
				global::Infragistics.SummaryDefinitionCollection summaryDefinitionCollectionResolved = ((global::Infragistics.Controls.Grids.RowsManager)base.Cell.Row.Manager).SummaryDefinitionCollectionResolved;
				string key = base.Cell.Column.Key;
				foreach (global::Infragistics.SummaryDefinition summaryDefinition in summaryDefinitionCollectionResolved)
				{
					if (summaryDefinition.ColumnKey == key)
					{
						int count = base.Panel.Children.Count;
						for (int i = 0; i < count; i++)
						{
							global::System.Windows.Controls.CheckBox checkBox = (global::System.Windows.Controls.CheckBox)base.Panel.Children[i];
							checkBox.Style = base.CheckBoxStyle;
							global::Infragistics.SummaryOperandBase summaryOperandBase2 = (global::Infragistics.SummaryOperandBase)checkBox.Tag;
							if (summaryOperandBase2 == summaryDefinition.SummaryOperand)
							{
								checkBox.IsChecked = new bool?(true);
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x17000348 RID: 840
		// (get) Token: 0x06000B17 RID: 2839 RVA: 0x00029DF8 File Offset: 0x00027FF8
		// (set) Token: 0x06000B18 RID: 2840 RVA: 0x00029E0A File Offset: 0x0002800A
		public string OKCaption
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Controls.Grids.Primitives.SummarySelectionControl.OKCaptionProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.Primitives.SummarySelectionControl.OKCaptionProperty, value);
			}
		}

		// Token: 0x06000B19 RID: 2841 RVA: 0x00029E18 File Offset: 0x00028018
		private static void OKCaptionChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.Primitives.SummarySelectionControl summarySelectionControl = (global::Infragistics.Controls.Grids.Primitives.SummarySelectionControl)obj;
			summarySelectionControl.OnPropertyChanged("OKCaption");
		}

		// Token: 0x17000349 RID: 841
		// (get) Token: 0x06000B1A RID: 2842 RVA: 0x00029E37 File Offset: 0x00028037
		// (set) Token: 0x06000B1B RID: 2843 RVA: 0x00029E49 File Offset: 0x00028049
		public string CancelCaption
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Controls.Grids.Primitives.SummarySelectionControl.CancelCaptionProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.Primitives.SummarySelectionControl.CancelCaptionProperty, value);
			}
		}

		// Token: 0x06000B1C RID: 2844 RVA: 0x00029E58 File Offset: 0x00028058
		private static void CancelCaptionChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.Primitives.SummarySelectionControl summarySelectionControl = (global::Infragistics.Controls.Grids.Primitives.SummarySelectionControl)obj;
			summarySelectionControl.OnPropertyChanged("CancelCaption");
		}

		// Token: 0x040002B0 RID: 688
		public static readonly global::System.Windows.DependencyProperty OKCaptionProperty = global::System.Windows.DependencyProperty.Register("OKCaption", typeof(string), typeof(global::Infragistics.Controls.Grids.Primitives.SummarySelectionControl), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.Primitives.SummarySelectionControl.OKCaptionChanged)));

		// Token: 0x040002B1 RID: 689
		public static readonly global::System.Windows.DependencyProperty CancelCaptionProperty = global::System.Windows.DependencyProperty.Register("CancelCaption", typeof(string), typeof(global::Infragistics.Controls.Grids.Primitives.SummarySelectionControl), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.Primitives.SummarySelectionControl.CancelCaptionChanged)));
	}
}
