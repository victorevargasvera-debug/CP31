using System;
using System.Windows;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000059 RID: 89
	public sealed class CellPresenterLayoutElement : global::Infragistics.Windows.DataPresenter.CellPresenterLayoutElementBase
	{
		// Token: 0x060004A1 RID: 1185 RVA: 0x00010820 File Offset: 0x0000EA20
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

		// Token: 0x060004A2 RID: 1186 RVA: 0x00010878 File Offset: 0x0000EA78
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

		// Token: 0x060004A3 RID: 1187 RVA: 0x000108A6 File Offset: 0x0000EAA6
		internal override global::System.Windows.FrameworkElement CreateLabelPresenter(global::System.Windows.FrameworkElement oldElem)
		{
			return global::Infragistics.Windows.DataPresenter.CellPresenterLayoutElement.CreateLabelPresenter(oldElem, base.Field);
		}

		// Token: 0x060004A4 RID: 1188 RVA: 0x000108B4 File Offset: 0x0000EAB4
		internal override void GetFieldAndRecordForCaching(out global::Infragistics.Windows.DataPresenter.Field field, out global::Infragistics.Windows.DataPresenter.Record record)
		{
			if (this._cachedParentCellPresenter == null)
			{
				this._cachedParentCellPresenter = (global::Infragistics.Windows.Utilities.GetAncestorFromType(this, typeof(global::Infragistics.Windows.DataPresenter.CellPresenter), false, null, typeof(global::Infragistics.Windows.DataPresenter.RecordListControl)) as global::Infragistics.Windows.DataPresenter.CellPresenter);
			}
			field = ((this._cachedParentCellPresenter != null) ? this._cachedParentCellPresenter.Field : null);
			record = (base.DataContext as global::Infragistics.Windows.DataPresenter.Record);
		}

		// Token: 0x060004A5 RID: 1189 RVA: 0x00010915 File Offset: 0x0000EB15
		internal override void InitializeCellValuePresenter(global::System.Windows.FrameworkElement cvp)
		{
			((global::Infragistics.Windows.DataPresenter.CellValuePresenter)cvp).Field = base.Field;
		}

		// Token: 0x060004A6 RID: 1190 RVA: 0x00010928 File Offset: 0x0000EB28
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

		// Token: 0x060004A7 RID: 1191 RVA: 0x00010954 File Offset: 0x0000EB54
		internal static void ReleaseLabelPresenter(global::System.Windows.FrameworkElement labelPresenter, global::Infragistics.Windows.DataPresenter.Field field)
		{
			global::Infragistics.Windows.DataPresenter.LabelPresenter labelPresenter2 = labelPresenter as global::Infragistics.Windows.DataPresenter.LabelPresenter;
			if (field != null && labelPresenter2 != null)
			{
				field.ReleaseLabelPresenter(labelPresenter2);
			}
		}

		// Token: 0x060004A8 RID: 1192 RVA: 0x00010975 File Offset: 0x0000EB75
		internal override void ReleaseLabelPresenter(global::System.Windows.FrameworkElement labelPresenter, bool recycle)
		{
			if (recycle)
			{
				global::Infragistics.Windows.DataPresenter.CellPresenterLayoutElement.ReleaseLabelPresenter(labelPresenter, base.Field);
			}
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x060004A9 RID: 1193 RVA: 0x00010986 File Offset: 0x0000EB86
		internal new global::Infragistics.Windows.DataPresenter.CellValuePresenter CellValuePresenter
		{
			get
			{
				return base.CellValuePresenter as global::Infragistics.Windows.DataPresenter.CellValuePresenter;
			}
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x060004AA RID: 1194 RVA: 0x00010993 File Offset: 0x0000EB93
		internal new global::Infragistics.Windows.DataPresenter.LabelPresenter LabelPresenter
		{
			get
			{
				return base.LabelPresenter as global::Infragistics.Windows.DataPresenter.LabelPresenter;
			}
		}

		// Token: 0x04000137 RID: 311
		private global::Infragistics.Windows.DataPresenter.CellPresenter _cachedParentCellPresenter;
	}
}
