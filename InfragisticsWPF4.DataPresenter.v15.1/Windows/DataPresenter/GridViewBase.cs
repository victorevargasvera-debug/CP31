using System;
using System.Windows.Controls;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020001E2 RID: 482
	public abstract class GridViewBase : global::Infragistics.Windows.DataPresenter.ViewBase
	{
		// Token: 0x170008A6 RID: 2214
		// (get) Token: 0x06001E23 RID: 7715 RVA: 0x0008615E File Offset: 0x0008435E
		protected internal override bool AutoFitToRecord
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170008A7 RID: 2215
		// (get) Token: 0x06001E24 RID: 7716 RVA: 0x00086161 File Offset: 0x00084361
		protected internal override global::Infragistics.Windows.DataPresenter.CellPresentation CellPresentation
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.CellPresentation.GridView;
			}
		}

		// Token: 0x170008A8 RID: 2216
		// (get) Token: 0x06001E25 RID: 7717 RVA: 0x00086164 File Offset: 0x00084364
		protected internal override global::Infragistics.Windows.DataPresenter.AutoArrangeCells DefaultAutoArrangeCells
		{
			get
			{
				if (this.LogicalOrientation != global::System.Windows.Controls.Orientation.Vertical)
				{
					return global::Infragistics.Windows.DataPresenter.AutoArrangeCells.TopToBottom;
				}
				return global::Infragistics.Windows.DataPresenter.AutoArrangeCells.LeftToRight;
			}
		}

		// Token: 0x170008A9 RID: 2217
		// (get) Token: 0x06001E26 RID: 7718 RVA: 0x00086172 File Offset: 0x00084372
		protected internal override bool HasLogicalOrientation
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170008AA RID: 2218
		// (get) Token: 0x06001E27 RID: 7719 RVA: 0x00086175 File Offset: 0x00084375
		protected internal override bool IsChildRecordsDisplayOrderSupported
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170008AB RID: 2219
		// (get) Token: 0x06001E28 RID: 7720 RVA: 0x00086178 File Offset: 0x00084378
		protected internal override bool IsFilterRecordSupported
		{
			get
			{
				return !base.IsForExport;
			}
		}

		// Token: 0x170008AC RID: 2220
		// (get) Token: 0x06001E29 RID: 7721 RVA: 0x00086183 File Offset: 0x00084383
		protected internal override bool IsFixedFieldsSupported
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170008AD RID: 2221
		// (get) Token: 0x06001E2A RID: 7722 RVA: 0x00086186 File Offset: 0x00084386
		protected internal override bool IsFixedRecordsSupported
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170008AE RID: 2222
		// (get) Token: 0x06001E2B RID: 7723 RVA: 0x00086189 File Offset: 0x00084389
		protected internal override bool IsPanningModeSupported
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06001E2C RID: 7724 RVA: 0x0008618C File Offset: 0x0008438C
		internal override global::Infragistics.Windows.DataPresenter.FixedFieldInfo GetFixedFieldInfo(global::Infragistics.Windows.DataPresenter.RecordPresenter recordPresenter)
		{
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = recordPresenter.DataPresenter;
			global::Infragistics.Windows.DataPresenter.GridViewPanel gridViewPanel = (dataPresenter != null) ? (dataPresenter.CurrentPanel as global::Infragistics.Windows.DataPresenter.GridViewPanel) : null;
			if (gridViewPanel == null)
			{
				return null;
			}
			return gridViewPanel.FixedFieldInfo;
		}
	}
}
