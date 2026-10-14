using System;
using System.Windows;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200005D RID: 93
	public sealed class CellPresenterLayoutElement : global::Infragistics.Windows.DataPresenter.CellPresenterLayoutElementBase
	{
		// Token: 0x06000500 RID: 1280 RVA: 0x00012054 File Offset: 0x00010254
		internal override global::System.Windows.FrameworkElement CreateCellValuePresenter(global::System.Windows.FrameworkElement oldElem)
		{
			global::Infragistics.Windows.DataPresenter.CellValuePresenter cellValuePresenter = oldElem as global::Infragistics.Windows.DataPresenter.CellValuePresenter;
			bool flag = base.Record is global::Infragistics.Windows.DataPresenter.FilterRecord;
			if (flag && !(cellValuePresenter is global::Infragistics.Windows.DataPresenter.FilterCellValuePresenter))
			{
				cellValuePresenter = null;
			}
			global::Infragistics.Windows.DataPresenter.Field field = base.Field;
			if ((cellValuePresenter == null || cellValuePresenter.Field != field) && cellValuePresenter == null)
			{
				if (flag)
				{
					cellValuePresenter = new global::Infragistics.Windows.DataPresenter.FilterCellValuePresenter();
				}
				else
				{
					cellValuePresenter = new global::Infragistics.Windows.DataPresenter.CellValuePresenter();
				}
			}
			return cellValuePresenter;
		}

		// Token: 0x06000501 RID: 1281 RVA: 0x000120AC File Offset: 0x000102AC
		internal static global::Infragistics.Windows.DataPresenter.LabelPresenter CreateLabelPresenter(global::System.Windows.FrameworkElement oldElem, global::Infragistics.Windows.DataPresenter.Field field)
		{
			global::Infragistics.Windows.DataPresenter.LabelPresenter labelPresenter = oldElem as global::Infragistics.Windows.DataPresenter.LabelPresenter;
			if (labelPresenter == null || labelPresenter.Field != field)
			{
				labelPresenter = new global::Infragistics.Windows.DataPresenter.LabelPresenter();
				labelPresenter.Field = field;
			}
			return labelPresenter;
		}

		// Token: 0x06000502 RID: 1282 RVA: 0x000120DA File Offset: 0x000102DA
		internal override global::System.Windows.FrameworkElement CreateLabelPresenter(global::System.Windows.FrameworkElement oldElem)
		{
			return global::Infragistics.Windows.DataPresenter.CellPresenterLayoutElement.CreateLabelPresenter(oldElem, base.Field);
		}

		// Token: 0x06000503 RID: 1283 RVA: 0x000120E8 File Offset: 0x000102E8
		internal override void GetFieldAndRecordForCaching(out global::Infragistics.Windows.DataPresenter.Field field, out global::Infragistics.Windows.DataPresenter.Record record)
		{
			if (this._cachedParentCellPresenter == null)
			{
				this._cachedParentCellPresenter = (global::Infragistics.Windows.Utilities.GetAncestorFromType(this, typeof(global::Infragistics.Windows.DataPresenter.CellPresenter), false, null, typeof(global::Infragistics.Windows.DataPresenter.RecordListControl)) as global::Infragistics.Windows.DataPresenter.CellPresenter);
			}
			field = ((this._cachedParentCellPresenter != null) ? this._cachedParentCellPresenter.Field : null);
			record = (base.DataContext as global::Infragistics.Windows.DataPresenter.Record);
		}

		// Token: 0x06000504 RID: 1284 RVA: 0x00012149 File Offset: 0x00010349
		internal override void InitializeCellValuePresenter(global::System.Windows.FrameworkElement cvp)
		{
			((global::Infragistics.Windows.DataPresenter.CellValuePresenter)cvp).Field = base.Field;
		}

		// Token: 0x06000505 RID: 1285 RVA: 0x0001215C File Offset: 0x0001035C
		internal override void ReleaseCellValuePresenter(global::System.Windows.FrameworkElement cellValuePresenter, bool recycle)
		{
			if (recycle)
			{
				global::Infragistics.Windows.DataPresenter.CellValuePresenter cellValuePresenter2 = cellValuePresenter as global::Infragistics.Windows.DataPresenter.CellValuePresenter;
				global::Infragistics.Windows.DataPresenter.Field field = base.Field;
				if (field != null && cellValuePresenter2 != null)
				{
					field.ReleaseCellValuePresenter(cellValuePresenter2);
				}
			}
		}

		// Token: 0x06000506 RID: 1286 RVA: 0x00012188 File Offset: 0x00010388
		internal static void ReleaseLabelPresenter(global::System.Windows.FrameworkElement labelPresenter, global::Infragistics.Windows.DataPresenter.Field field)
		{
			global::Infragistics.Windows.DataPresenter.LabelPresenter labelPresenter2 = labelPresenter as global::Infragistics.Windows.DataPresenter.LabelPresenter;
			if (field != null && labelPresenter2 != null)
			{
				field.ReleaseLabelPresenter(labelPresenter2);
			}
		}

		// Token: 0x06000507 RID: 1287 RVA: 0x000121A9 File Offset: 0x000103A9
		internal override void ReleaseLabelPresenter(global::System.Windows.FrameworkElement labelPresenter, bool recycle)
		{
			if (recycle)
			{
				global::Infragistics.Windows.DataPresenter.CellPresenterLayoutElement.ReleaseLabelPresenter(labelPresenter, base.Field);
			}
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x06000508 RID: 1288 RVA: 0x000121BA File Offset: 0x000103BA
		internal new global::Infragistics.Windows.DataPresenter.CellValuePresenter CellValuePresenter
		{
			get
			{
				return base.CellValuePresenter as global::Infragistics.Windows.DataPresenter.CellValuePresenter;
			}
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x06000509 RID: 1289 RVA: 0x000121C7 File Offset: 0x000103C7
		internal new global::Infragistics.Windows.DataPresenter.LabelPresenter LabelPresenter
		{
			get
			{
				return base.LabelPresenter as global::Infragistics.Windows.DataPresenter.LabelPresenter;
			}
		}

		// Token: 0x04000162 RID: 354
		private global::Infragistics.Windows.DataPresenter.CellPresenter _cachedParentCellPresenter;
	}
}
