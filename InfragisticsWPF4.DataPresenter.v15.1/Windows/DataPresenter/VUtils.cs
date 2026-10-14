using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000223 RID: 547
	internal class VUtils
	{
		// Token: 0x06002068 RID: 8296 RVA: 0x0008D290 File Offset: 0x0008B490
		internal static void CreateGroupByRecordsSynchronizerHelper(global::Infragistics.Windows.DataPresenter.SortedFieldsToCollectionViewSynchronizer collectionViewSynchronizer, global::Infragistics.Windows.DataPresenter.RecordCollectionBase groupByRecordsColl, global::System.Collections.Generic.IList<object> groupObjects)
		{
			if (groupByRecordsColl._groupsSynchronizer == null || groupObjects != groupByRecordsColl._groupsSynchronizer._source || groupByRecordsColl.GroupByField != groupByRecordsColl._groupsSynchronizer._groupByField)
			{
				groupByRecordsColl.InitializeGroupByField();
				global::Infragistics.Windows.DataPresenter.Disposable disposableHelper = global::Infragistics.Windows.DataPresenter.VUtils.GetDisposableHelper(groupByRecordsColl);
				groupByRecordsColl._groupsSynchronizer = new global::Infragistics.Windows.DataPresenter.GroupsSynchronizer(collectionViewSynchronizer, groupByRecordsColl, groupObjects, disposableHelper);
				groupByRecordsColl._groupsSynchronizer.Synchronize();
			}
		}

		// Token: 0x06002069 RID: 8297 RVA: 0x0008D2F0 File Offset: 0x0008B4F0
		internal static global::Infragistics.Windows.DataPresenter.Disposable GetDisposableHelper(global::Infragistics.Windows.DataPresenter.RecordCollectionBase records)
		{
			global::Infragistics.Windows.DataPresenter.RecordCollectionBase parentCollection = global::Infragistics.Windows.DataPresenter.GridUtilities.GetParentCollection(records);
			global::Infragistics.Windows.DataPresenter.Disposable disposable = (parentCollection == null) ? null : ((parentCollection._groupsSynchronizer != null) ? parentCollection._groupsSynchronizer._disposable : ((parentCollection._recordsSynchronizer != null) ? parentCollection._recordsSynchronizer._disposable : null));
			return disposable ?? new global::Infragistics.Windows.DataPresenter.Disposable();
		}

		// Token: 0x0600206A RID: 8298 RVA: 0x0008D340 File Offset: 0x0008B540
		internal static void CreateDataRecordsSynchronizerHelper(global::Infragistics.Windows.DataPresenter.RecordCollectionBase dataRecords, global::System.Collections.Generic.IList<object> dataObjects)
		{
			if (dataRecords._recordsSynchronizer == null || dataObjects != dataRecords._recordsSynchronizer._source)
			{
				global::Infragistics.Windows.DataPresenter.Disposable disposableHelper = global::Infragistics.Windows.DataPresenter.VUtils.GetDisposableHelper(dataRecords);
				dataRecords._recordsSynchronizer = new global::Infragistics.Windows.DataPresenter.DataRecordsSynchronizer(dataRecords, dataObjects, disposableHelper);
				dataRecords._recordsSynchronizer.Synchronize();
			}
		}

		// Token: 0x0600206B RID: 8299 RVA: 0x0008D383 File Offset: 0x0008B583
		internal static global::System.ComponentModel.ICollectionView GetCollectionView(global::Infragistics.Windows.DataPresenter.RecordManager rm)
		{
			return rm.DataSource as global::System.ComponentModel.ICollectionView;
		}

		// Token: 0x0600206C RID: 8300 RVA: 0x0008D390 File Offset: 0x0008B590
		internal static global::System.Collections.IEnumerable GetCollectionViewSourceItems(global::Infragistics.Windows.DataPresenter.RecordManager rm)
		{
			global::System.ComponentModel.ICollectionView collectionView = global::Infragistics.Windows.DataPresenter.VUtils.GetCollectionView(rm);
			if (collectionView == null)
			{
				return null;
			}
			return collectionView.SourceCollection;
		}

		// Token: 0x0600206D RID: 8301 RVA: 0x0008D3AF File Offset: 0x0008B5AF
		internal static string GetPropertyName(global::Infragistics.Windows.DataPresenter.FieldSortDescription fsd)
		{
			return fsd.FieldName;
		}

		// Token: 0x0600206E RID: 8302 RVA: 0x0008D3B7 File Offset: 0x0008B5B7
		internal static string GetPropertyName(global::Infragistics.Windows.DataPresenter.Field field)
		{
			return field.Name;
		}

		// Token: 0x0600206F RID: 8303 RVA: 0x0008D3C0 File Offset: 0x0008B5C0
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

		// Token: 0x06002070 RID: 8304 RVA: 0x0008D424 File Offset: 0x0008B624
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
