using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020001EF RID: 495
	internal class VUtils
	{
		// Token: 0x06001BEB RID: 7147 RVA: 0x00076F28 File Offset: 0x00075128
		internal static void CreateGroupByRecordsSynchronizerHelper(global::Infragistics.Windows.DataPresenter.RecordCollectionBase groupByRecordsColl, global::System.Collections.Generic.IList<object> groupObjects)
		{
			if (groupByRecordsColl._groupsSynchronizer == null || groupObjects != groupByRecordsColl._groupsSynchronizer._source || groupByRecordsColl.GroupByField != groupByRecordsColl._groupsSynchronizer._groupByField)
			{
				groupByRecordsColl.InitializeGroupByField();
				groupByRecordsColl._groupsSynchronizer = new global::Infragistics.Windows.DataPresenter.GroupsSynchronizer(groupByRecordsColl, groupObjects);
				groupByRecordsColl._groupsSynchronizer.Synchronize();
			}
		}

		// Token: 0x06001BEC RID: 7148 RVA: 0x00076F7C File Offset: 0x0007517C
		internal static void CreateDataRecordsSynchronizerHelper(global::Infragistics.Windows.DataPresenter.RecordCollectionBase dataRecords, global::System.Collections.Generic.IList<object> dataObjects)
		{
			if (dataRecords._recordsSynchronizer == null || dataRecords != dataRecords._recordsSynchronizer._source)
			{
				dataRecords._recordsSynchronizer = new global::Infragistics.Windows.DataPresenter.DataRecordsSynchronizer(dataRecords, dataObjects);
				dataRecords._recordsSynchronizer.Synchronize();
			}
		}

		// Token: 0x06001BED RID: 7149 RVA: 0x00076FAC File Offset: 0x000751AC
		internal static global::System.ComponentModel.ICollectionView GetCollectionView(global::Infragistics.Windows.DataPresenter.RecordManager rm)
		{
			return rm.DataSource as global::System.ComponentModel.ICollectionView;
		}

		// Token: 0x06001BEE RID: 7150 RVA: 0x00076FBC File Offset: 0x000751BC
		internal static global::System.Collections.IEnumerable GetCollectionViewSourceItems(global::Infragistics.Windows.DataPresenter.RecordManager rm)
		{
			global::System.ComponentModel.ICollectionView collectionView = global::Infragistics.Windows.DataPresenter.VUtils.GetCollectionView(rm);
			if (collectionView == null)
			{
				return null;
			}
			return collectionView.SourceCollection;
		}

		// Token: 0x06001BEF RID: 7151 RVA: 0x00076FDB File Offset: 0x000751DB
		internal static string GetPropertyName(global::Infragistics.Windows.DataPresenter.FieldSortDescription fsd)
		{
			return fsd.FieldName;
		}

		// Token: 0x06001BF0 RID: 7152 RVA: 0x00076FE3 File Offset: 0x000751E3
		internal static string GetPropertyName(global::Infragistics.Windows.DataPresenter.Field field)
		{
			return field.Name;
		}

		// Token: 0x06001BF1 RID: 7153 RVA: 0x00076FEC File Offset: 0x000751EC
		internal static global::Infragistics.Windows.DataPresenter.Field GetField(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout, string propertyName)
		{
			if (!string.IsNullOrEmpty(propertyName))
			{
				foreach (global::Infragistics.Windows.DataPresenter.Field field in fieldLayout.Fields)
				{
					if (global::Infragistics.Windows.DataPresenter.GridUtilities.AreKeysEqual(global::Infragistics.Windows.DataPresenter.VUtils.GetPropertyName(field), propertyName))
					{
						return field;
					}
				}
			}
			return null;
		}

		// Token: 0x06001BF2 RID: 7154 RVA: 0x00077050 File Offset: 0x00075250
		internal static global::Infragistics.Windows.DataPresenter.LinqQueryManager CreateLinqQueryManager(global::Infragistics.Windows.DataPresenter.RecordManager rm, bool useSourceCollection)
		{
			global::System.ComponentModel.ICollectionView collectionView = global::Infragistics.Windows.DataPresenter.VUtils.GetCollectionView(rm);
			if (collectionView != null)
			{
				global::System.Type listElementType = global::Infragistics.Windows.DataPresenter.LinqQueryManager.GetListElementType(collectionView, true);
				if (null != listElementType)
				{
					return new global::Infragistics.Windows.DataPresenter.LinqQueryManager((useSourceCollection ? collectionView.SourceCollection : null) ?? collectionView, listElementType);
				}
			}
			else
			{
				global::System.Collections.IEnumerable dataSource = rm.DataSource;
				global::System.Type type = (dataSource != null) ? global::Infragistics.Windows.DataPresenter.LinqQueryManager.GetListElementType(dataSource, true) : null;
				if (null != type)
				{
					return new global::Infragistics.Windows.DataPresenter.LinqQueryManager(dataSource, type);
				}
			}
			return null;
		}
	}
}
