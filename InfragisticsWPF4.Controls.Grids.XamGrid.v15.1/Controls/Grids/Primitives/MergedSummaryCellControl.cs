using System;
using System.Windows.Controls;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x02000224 RID: 548
	public class MergedSummaryCellControl : global::Infragistics.Controls.Grids.Primitives.SummaryRowCellControl
	{
		// Token: 0x06000F79 RID: 3961 RVA: 0x0003ADDE File Offset: 0x00038FDE
		public MergedSummaryCellControl()
		{
			base.DefaultStyleKey = typeof(global::Infragistics.Controls.Grids.Primitives.MergedSummaryCellControl);
		}

		// Token: 0x06000F7A RID: 3962 RVA: 0x0003ADF8 File Offset: 0x00038FF8
		protected override void FillPanelWithSummaryResults(global::System.Windows.Controls.Panel panel)
		{
			panel.Children.Clear();
			if (base.Cell != null && base.Cell.Row != null)
			{
				global::Infragistics.SummaryResultCollection summaryResultCollection = ((global::Infragistics.Controls.Grids.Primitives.MergedSummaryRow)base.Cell.Row).MergedColumnInfo.SummaryResultCollection;
				foreach (global::Infragistics.SummaryResult summaryResult in summaryResultCollection)
				{
					if (summaryResult.SummaryDefinition.ColumnKey == base.Cell.Column.Key)
					{
						global::System.Windows.Controls.ContentControl contentControl = new global::System.Windows.Controls.ContentControl();
						contentControl.ContentTemplate = base.SummaryDisplayTemplate;
						contentControl.Content = summaryResult;
						panel.Children.Add(contentControl);
					}
				}
			}
		}
	}
}
