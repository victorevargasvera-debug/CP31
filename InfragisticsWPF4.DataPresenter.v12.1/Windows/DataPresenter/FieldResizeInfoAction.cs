using System;
using System.Collections.Generic;
using Infragistics.Windows.DataPresenter.Internal;
using Infragistics.Windows.Helpers;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200006E RID: 110
	internal class FieldResizeInfoAction : global::Infragistics.Windows.DataPresenter.DataPresenterAction
	{
		// Token: 0x060005BF RID: 1471 RVA: 0x000164B1 File Offset: 0x000146B1
		internal FieldResizeInfoAction(global::Infragistics.Windows.DataPresenter.FieldLayout fl, global::Infragistics.Windows.DataPresenter.Field.FieldResizeInfo[] resizeInfos, double[] rowExtents, double[] colExtents, bool isWidth) : base(fl.DataPresenter)
		{
			this._fieldLayout = fl;
			this._resizeInfos = resizeInfos;
			this._rowExtents = rowExtents;
			this._colExtents = colExtents;
			this._isWidth = isWidth;
		}

		// Token: 0x060005C0 RID: 1472 RVA: 0x000164E4 File Offset: 0x000146E4
		protected internal override bool CanPerform(object context)
		{
			foreach (global::Infragistics.Windows.DataPresenter.Field.FieldResizeInfo fieldResizeInfo in this._resizeInfos)
			{
				if (global::Infragistics.Windows.DataPresenter.DataPresenterAction.IsValid(fieldResizeInfo.Field))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060005C1 RID: 1473 RVA: 0x0001651E File Offset: 0x0001471E
		internal override global::Infragistics.Windows.DataPresenter.DataPresenterAction OnCustomizationsChanged(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout, global::Infragistics.Windows.DataPresenter.CustomizationType customizationType)
		{
			if (fieldLayout == this._fieldLayout && (customizationType & global::Infragistics.Windows.DataPresenter.CustomizationType.FieldExtent) != global::Infragistics.Windows.DataPresenter.CustomizationType.None)
			{
				return null;
			}
			return base.OnCustomizationsChanged(fieldLayout, customizationType);
		}

		// Token: 0x060005C2 RID: 1474 RVA: 0x00016538 File Offset: 0x00014738
		protected internal override global::Infragistics.Windows.Helpers.ActionHistory.ActionBase Perform(object context)
		{
			global::Infragistics.Windows.DataPresenter.FieldResizeInfoAction result = global::Infragistics.Windows.DataPresenter.FieldResizeInfoAction.Create(this._fieldLayout, this._isWidth);
			foreach (global::Infragistics.Windows.DataPresenter.Field.FieldResizeInfo fieldResizeInfo in this._resizeInfos)
			{
				global::Infragistics.Windows.DataPresenter.Field.FieldResizeInfo explicitResizeInfo = fieldResizeInfo.Field.ExplicitResizeInfo;
				explicitResizeInfo.InitializeFrom(fieldResizeInfo);
			}
			global::Infragistics.Windows.DataPresenter.Internal.TemplateDataRecordCache templateDataRecordCache = this._fieldLayout.TemplateDataRecordCache;
			if (this._rowExtents != null)
			{
				global::Infragistics.Windows.DataPresenter.FieldResizeInfoAction.PerformImpl(this._rowExtents, templateDataRecordCache.GridRowLayoutItems, this._isWidth);
			}
			if (this._colExtents != null)
			{
				global::Infragistics.Windows.DataPresenter.FieldResizeInfoAction.PerformImpl(this._colExtents, templateDataRecordCache.GridColumnLayoutItems, this._isWidth);
			}
			this._fieldLayout.BumpLayoutManagerVersion();
			return result;
		}

		// Token: 0x060005C3 RID: 1475 RVA: 0x000165E4 File Offset: 0x000147E4
		internal static global::Infragistics.Windows.DataPresenter.FieldResizeInfoAction Create(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout, bool isWidth)
		{
			global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field.FieldResizeInfo> list = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field.FieldResizeInfo>();
			foreach (global::Infragistics.Windows.DataPresenter.Field field in fieldLayout.Fields)
			{
				list.Add(field.ExplicitResizeInfo.Clone());
			}
			global::Infragistics.Windows.DataPresenter.Internal.TemplateDataRecordCache templateDataRecordCache = fieldLayout.TemplateDataRecordCache;
			return new global::Infragistics.Windows.DataPresenter.FieldResizeInfoAction(fieldLayout, list.ToArray(), global::Infragistics.Windows.DataPresenter.FieldResizeInfoAction.GetExtents(templateDataRecordCache.GridRowLayoutItems, isWidth), global::Infragistics.Windows.DataPresenter.FieldResizeInfoAction.GetExtents(templateDataRecordCache.GridColumnLayoutItems, isWidth), isWidth);
		}

		// Token: 0x060005C4 RID: 1476 RVA: 0x00016670 File Offset: 0x00014870
		private static double[] GetExtents(global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.GridDefinitionLayoutItem> layoutItems, bool isWidth)
		{
			global::System.Collections.Generic.List<double> list = new global::System.Collections.Generic.List<double>();
			foreach (global::Infragistics.Windows.DataPresenter.GridDefinitionLayoutItem gridDefinitionLayoutItem in layoutItems)
			{
				list.Add(isWidth ? gridDefinitionLayoutItem.PreferredWidth : gridDefinitionLayoutItem.PreferredHeight);
			}
			return list.ToArray();
		}

		// Token: 0x060005C5 RID: 1477 RVA: 0x000166D4 File Offset: 0x000148D4
		private static void PerformImpl(double[] extents, global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.GridDefinitionLayoutItem> layoutItems, bool isWidth)
		{
			int i = 0;
			int num = global::System.Math.Min(layoutItems.Count, extents.Length);
			while (i < num)
			{
				global::Infragistics.Windows.DataPresenter.GridDefinitionLayoutItem gridDefinitionLayoutItem = layoutItems[i];
				if (isWidth)
				{
					gridDefinitionLayoutItem.SetPreferredWidth(extents[i], global::Infragistics.Windows.DataPresenter.ItemSizeType.Explicit);
				}
				else
				{
					gridDefinitionLayoutItem.SetPreferredHeight(extents[i], global::Infragistics.Windows.DataPresenter.ItemSizeType.Explicit);
				}
				i++;
			}
		}

		// Token: 0x040001AB RID: 427
		private global::Infragistics.Windows.DataPresenter.FieldLayout _fieldLayout;

		// Token: 0x040001AC RID: 428
		private global::Infragistics.Windows.DataPresenter.Field.FieldResizeInfo[] _resizeInfos;

		// Token: 0x040001AD RID: 429
		private double[] _rowExtents;

		// Token: 0x040001AE RID: 430
		private double[] _colExtents;

		// Token: 0x040001AF RID: 431
		private bool _isWidth;
	}
}
