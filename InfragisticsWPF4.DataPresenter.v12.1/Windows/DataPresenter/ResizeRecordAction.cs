using System;
using System.Collections.Generic;
using Infragistics.Controls.Layouts.Primitives;
using Infragistics.Windows.Helpers;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200006F RID: 111
	internal class ResizeRecordAction : global::Infragistics.Windows.DataPresenter.DataRecordAction
	{
		// Token: 0x060005C6 RID: 1478 RVA: 0x0001671D File Offset: 0x0001491D
		private ResizeRecordAction(bool isWidth, global::Infragistics.Windows.DataPresenter.DataRecord record) : base(record)
		{
			this._extents = new global::System.Collections.Generic.Dictionary<global::Infragistics.Controls.Layouts.Primitives.ILayoutItem, double?>();
			this._isWidth = isWidth;
		}

		// Token: 0x060005C7 RID: 1479 RVA: 0x00016738 File Offset: 0x00014938
		protected internal override global::Infragistics.Windows.Helpers.ActionHistory.ActionBase Perform(object context)
		{
			if (!this.CanPerform(context))
			{
				return null;
			}
			global::Infragistics.Windows.DataPresenter.FieldGridBagLayoutManager layoutManager = base.Record.GetLayoutManager(true);
			global::Infragistics.Windows.DataPresenter.ResizeRecordAction result = global::Infragistics.Windows.DataPresenter.ResizeRecordAction.Create(base.Record, this._isWidth);
			foreach (global::Infragistics.Controls.Layouts.Primitives.ILayoutItem layoutItem in ((global::System.Collections.Generic.IEnumerable<global::Infragistics.Controls.Layouts.Primitives.ILayoutItem>)layoutManager.LayoutItems))
			{
				global::Infragistics.Windows.DataPresenter.IWrapperLayoutItem wrapperLayoutItem = layoutItem as global::Infragistics.Windows.DataPresenter.IWrapperLayoutItem;
				double? num;
				if (wrapperLayoutItem != null && this._extents.TryGetValue(wrapperLayoutItem.InnerLayoutItem, out num))
				{
					if (this._isWidth)
					{
						wrapperLayoutItem.ExplicitWidth = num;
					}
					else
					{
						wrapperLayoutItem.ExplicitHeight = num;
					}
				}
			}
			return result;
		}

		// Token: 0x060005C8 RID: 1480 RVA: 0x000167E8 File Offset: 0x000149E8
		internal static global::Infragistics.Windows.DataPresenter.ResizeRecordAction Create(global::Infragistics.Windows.DataPresenter.Record targetRecord, bool isWidth)
		{
			global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = targetRecord as global::Infragistics.Windows.DataPresenter.DataRecord;
			if (dataRecord == null)
			{
				return null;
			}
			global::Infragistics.Windows.DataPresenter.FieldGridBagLayoutManager layoutManager = targetRecord.GetLayoutManager(true);
			global::Infragistics.Windows.DataPresenter.ResizeRecordAction resizeRecordAction = new global::Infragistics.Windows.DataPresenter.ResizeRecordAction(isWidth, dataRecord);
			foreach (global::Infragistics.Controls.Layouts.Primitives.ILayoutItem layoutItem in ((global::System.Collections.Generic.IEnumerable<global::Infragistics.Controls.Layouts.Primitives.ILayoutItem>)layoutManager.LayoutItems))
			{
				global::Infragistics.Windows.DataPresenter.IWrapperLayoutItem wrapperLayoutItem = layoutItem as global::Infragistics.Windows.DataPresenter.IWrapperLayoutItem;
				if (wrapperLayoutItem != null)
				{
					resizeRecordAction._extents[wrapperLayoutItem.InnerLayoutItem] = (isWidth ? wrapperLayoutItem.ExplicitWidth : wrapperLayoutItem.ExplicitHeight);
				}
			}
			return resizeRecordAction;
		}

		// Token: 0x040001B0 RID: 432
		private global::System.Collections.Generic.Dictionary<global::Infragistics.Controls.Layouts.Primitives.ILayoutItem, double?> _extents;

		// Token: 0x040001B1 RID: 433
		private bool _isWidth;
	}
}
