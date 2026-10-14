using System;
using System.Collections.Specialized;
using Infragistics.Windows.DataPresenter;
using Microsoft.Practices.Prism.Commands;
using Motorola.CommonCPS.RadioManagement.Controls.UiHelpers;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Infrastructure
{
	// Token: 0x02000020 RID: 32
	public class DataGridSelectedItemsChangedCommandBehavior : global::Microsoft.Practices.Prism.Commands.CommandBehaviorBase<global::Infragistics.Windows.DataPresenter.XamDataGrid>
	{
		// Token: 0x06000061 RID: 97 RVA: 0x000078B4 File Offset: 0x00005AB4
		public DataGridSelectedItemsChangedCommandBehavior(global::Infragistics.Windows.DataPresenter.XamDataGrid dataGrid) : base(dataGrid)
		{
			dataGrid.SelectedItems.Records.CollectionChanged += new global::System.Collections.Specialized.NotifyCollectionChangedEventHandler(this.a);
			dataGrid.SelectedItems.Cells.CollectionChanged += new global::System.Collections.Specialized.NotifyCollectionChangedEventHandler(this.a);
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00007900 File Offset: 0x00005B00
		private void a(object A_0, global::System.EventArgs A_1)
		{
			short num = (short)1974960779;
			short num2 = num;
			num = (short)403997323;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1794899968;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2012872705;
			if (num != 0)
			{
			}
			num = (short)673906688;
			if (num != 0)
			{
			}
			base.CommandParameter = base.TargetObject.SelectedItems.GetDataItemsFromSelectedCellsOrRecords<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase>();
			this.ExecuteCommand();
		}
	}
}
