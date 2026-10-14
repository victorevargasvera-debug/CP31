using System;
using System.Collections.Generic;
using Infragistics.Windows.DataPresenter.Internal;
using Infragistics.Windows.Helpers;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000073 RID: 115
	internal class FieldResizeInfoAction : global::Infragistics.Windows.DataPresenter.DataPresenterAction
	{
		// Token: 0x0600063A RID: 1594 RVA: 0x000188AD File Offset: 0x00016AAD
		internal FieldResizeInfoAction(global::Infragistics.Windows.DataPresenter.FieldLayout fl, global::Infragistics.Windows.DataPresenter.Field.FieldResizeInfo[] resizeInfos, double[] rowExtents, double[] colExtents, bool isWidth) : base(fl.DataPresenter)
		{
			this._fieldLayout = fl;
			this._resizeInfos = resizeInfos;
			this._rowExtents = rowExtents;
			this._colExtents = colExtents;
			this._isWidth = isWidth;
		}

		// Token: 0x0600063B RID: 1595 RVA: 0x000188E0 File Offset: 0x00016AE0
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

		// Token: 0x0600063C RID: 1596 RVA: 0x0001891A File Offset: 0x00016B1A
		internal override global::Infragistics.Windows.DataPresenter.DataPresenterAction OnCustomizationsChanged(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout, global::Infragistics.Windows.DataPresenter.CustomizationType customizationType)
		{
			if (fieldLayout == this._fieldLayout && (customizationType & global::Infragistics.Windows.DataPresenter.CustomizationType.FieldExtent) != global::Infragistics.Windows.DataPresenter.CustomizationType.None)
			{
				return null;
			}
			return base.OnCustomizationsChanged(fieldLayout, customizationType);
		}

		// Token: 0x0600063D RID: 1597 RVA: 0x00018934 File Offset: 0x00016B34
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

		// Token: 0x0600063E RID: 1598 RVA: 0x000189E0 File Offset: 0x00016BE0
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

		// Token: 0x0600063F RID: 1599 RVA: 0x00018A6C File Offset: 0x00016C6C
		private static double[] GetExtents(global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.GridDefinitionLayoutItem> layoutItems, bool isWidth)
		{
			global::System.Collections.Generic.List<double> list = new global::System.Collections.Generic.List<double>();
			foreach (global::Infragistics.Windows.DataPresenter.GridDefinitionLayoutItem gridDefinitionLayoutItem in layoutItems)
			{
				list.Add(isWidth ? gridDefinitionLayoutItem.PreferredWidth : gridDefinitionLayoutItem.PreferredHeight);
			}
			return list.ToArray();
		}

		// Token: 0x06000640 RID: 1600 RVA: 0x00018AD0 File Offset: 0x00016CD0
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

		// Token: 0x040001E4 RID: 484
		private global::Infragistics.Windows.DataPresenter.FieldLayout _fieldLayout;

		// Token: 0x040001E5 RID: 485
		private global::Infragistics.Windows.DataPresenter.Field.FieldResizeInfo[] _resizeInfos;

		// Token: 0x040001E6 RID: 486
		private double[] _rowExtents;

		// Token: 0x040001E7 RID: 487
		private double[] _colExtents;

		// Token: 0x040001E8 RID: 488
		private bool _isWidth;
	}
}
