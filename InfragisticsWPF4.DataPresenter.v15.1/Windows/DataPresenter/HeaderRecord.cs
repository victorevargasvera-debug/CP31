using System;
using System.ComponentModel;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000345 RID: 837
	public class HeaderRecord : global::Infragistics.Windows.DataPresenter.DataRecord
	{
		// Token: 0x060027F3 RID: 10227 RVA: 0x000B1C89 File Offset: 0x000AFE89
		internal HeaderRecord(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout, global::Infragistics.Windows.DataPresenter.RecordCollectionBase parentCollection) : base(fieldLayout, parentCollection)
		{
		}

		// Token: 0x17000BCF RID: 3023
		// (get) Token: 0x060027F4 RID: 10228 RVA: 0x000B1C93 File Offset: 0x000AFE93
		internal override global::Infragistics.Windows.DataPresenter.RecordCollectionBase ChildRecordsIfNeeded
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000BD0 RID: 3024
		// (get) Token: 0x060027F5 RID: 10229 RVA: 0x000B1C96 File Offset: 0x000AFE96
		internal override global::Infragistics.Windows.DataPresenter.RecordCollectionBase ChildRecordsInternal
		{
			get
			{
				return null;
			}
		}

		// Token: 0x060027F6 RID: 10230 RVA: 0x000B1C99 File Offset: 0x000AFE99
		internal override global::Infragistics.Windows.DataPresenter.CellCollection CreateCellCollection()
		{
			return null;
		}

		// Token: 0x17000BD1 RID: 3025
		// (get) Token: 0x060027F7 RID: 10231 RVA: 0x000B1C9C File Offset: 0x000AFE9C
		// (set) Token: 0x060027F8 RID: 10232 RVA: 0x000B1CB7 File Offset: 0x000AFEB7
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public override string Description
		{
			get
			{
				if (!string.IsNullOrEmpty(base.Description))
				{
					return base.Description;
				}
				return "Header record";
			}
			set
			{
				base.Description = value;
			}
		}

		// Token: 0x060027F9 RID: 10233 RVA: 0x000B1CC0 File Offset: 0x000AFEC0
		public override global::Infragistics.Windows.DataPresenter.Record GetAssociatedRecord()
		{
			return null;
		}

		// Token: 0x060027FA RID: 10234 RVA: 0x000B1CC3 File Offset: 0x000AFEC3
		public override object GetCellValue(global::Infragistics.Windows.DataPresenter.Field field, bool useConverter)
		{
			return this.GetCellValue(field, useConverter ? global::Infragistics.Windows.DataPresenter.CellValueType.Converted : global::Infragistics.Windows.DataPresenter.CellValueType.Raw);
		}

		// Token: 0x060027FB RID: 10235 RVA: 0x000B1CD3 File Offset: 0x000AFED3
		public override object GetCellValue(global::Infragistics.Windows.DataPresenter.Field field, global::Infragistics.Windows.DataPresenter.CellValueType cellValueType)
		{
			return field.Label;
		}

		// Token: 0x060027FC RID: 10236 RVA: 0x000B1CDB File Offset: 0x000AFEDB
		internal override global::System.Type GetEditorTypeResolved(global::Infragistics.Windows.DataPresenter.Field field)
		{
			return null;
		}

		// Token: 0x060027FD RID: 10237 RVA: 0x000B1CDE File Offset: 0x000AFEDE
		internal override bool GetIsEditingAllowed(global::Infragistics.Windows.DataPresenter.Field field)
		{
			return false;
		}

		// Token: 0x17000BD2 RID: 3026
		// (get) Token: 0x060027FE RID: 10238 RVA: 0x000B1CE1 File Offset: 0x000AFEE1
		internal override bool HasChildrenInternal
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000BD3 RID: 3027
		// (get) Token: 0x060027FF RID: 10239 RVA: 0x000B1CE4 File Offset: 0x000AFEE4
		public override bool IsDataRecord
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000BD4 RID: 3028
		// (get) Token: 0x06002800 RID: 10240 RVA: 0x000B1CE7 File Offset: 0x000AFEE7
		protected internal override bool IsSelectable
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000BD5 RID: 3029
		// (get) Token: 0x06002801 RID: 10241 RVA: 0x000B1CEA File Offset: 0x000AFEEA
		public override bool IsSpecialRecord
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000BD6 RID: 3030
		// (get) Token: 0x06002802 RID: 10242 RVA: 0x000B1CF0 File Offset: 0x000AFEF0
		internal override int NestingDepthOfDataRcds
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.Record attachedToRecord = this.AttachedToRecord;
				if (attachedToRecord != null)
				{
					return attachedToRecord.NestingDepthOfDataRcds;
				}
				return base.NestingDepthOfDataRcds;
			}
		}

		// Token: 0x17000BD7 RID: 3031
		// (get) Token: 0x06002803 RID: 10243 RVA: 0x000B1D14 File Offset: 0x000AFF14
		internal override global::Infragistics.Windows.DataPresenter.Record RecordForLayoutCalculations
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.Record attachedToRecord = this.AttachedToRecord;
				if (attachedToRecord == null)
				{
					return this;
				}
				global::Infragistics.Windows.DataPresenter.Record record = attachedToRecord;
				global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord expandableFieldRecord = record as global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord;
				if (expandableFieldRecord != null)
				{
					global::Infragistics.Windows.DataPresenter.RecordManager childRecordManagerIfNeeded = expandableFieldRecord.ChildRecordManagerIfNeeded;
					if (childRecordManagerIfNeeded != null && childRecordManagerIfNeeded.Unsorted.Count > 0)
					{
						record = childRecordManagerIfNeeded.Unsorted[0];
					}
				}
				switch (record.RecordType)
				{
				case global::Infragistics.Windows.DataPresenter.RecordType.DataRecord:
				case global::Infragistics.Windows.DataPresenter.RecordType.GroupByField:
				{
					global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = record.FieldLayout;
					if (fieldLayout.HasGroupBySortFields && fieldLayout.HeaderPlacementInGroupByResolved == global::Infragistics.Windows.DataPresenter.HeaderPlacementInGroupBy.OnTopOnly)
					{
						global::Infragistics.Windows.DataPresenter.Record topLevelGroupByFieldRecord = record.TopLevelGroupByFieldRecord;
						if (topLevelGroupByFieldRecord != null)
						{
							record = topLevelGroupByFieldRecord;
						}
					}
					break;
				}
				case global::Infragistics.Windows.DataPresenter.RecordType.GroupByFieldLayout:
					for (global::Infragistics.Windows.DataPresenter.RecordCollectionBase childRecordsInternal = record.ChildRecordsInternal; childRecordsInternal != null; childRecordsInternal = childRecordsInternal[0].ChildRecordsInternal)
					{
						if (childRecordsInternal.Count <= 0)
						{
							break;
						}
						if (!(childRecordsInternal[0] is global::Infragistics.Windows.DataPresenter.GroupByRecord))
						{
							return childRecordsInternal[0];
						}
					}
					break;
				case global::Infragistics.Windows.DataPresenter.RecordType.SummaryRecord:
				{
					global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout2 = record.FieldLayout;
					if (fieldLayout2.HasGroupBySortFields)
					{
						if (fieldLayout2.HeaderPlacementInGroupByResolved == global::Infragistics.Windows.DataPresenter.HeaderPlacementInGroupBy.OnTopOnly)
						{
							global::Infragistics.Windows.DataPresenter.Record topLevelGroupByFieldRecord2 = record.TopLevelGroupByFieldRecord;
							if (topLevelGroupByFieldRecord2 != null)
							{
								record = topLevelGroupByFieldRecord2;
							}
						}
						else
						{
							global::Infragistics.Windows.DataPresenter.RecordManager parentRecordManager = record.ParentCollection.ParentRecordManager;
							if (parentRecordManager != null && parentRecordManager.Unsorted.Count > 0)
							{
								return parentRecordManager.Unsorted[0];
							}
						}
					}
					break;
				}
				}
				return record;
			}
		}

		// Token: 0x17000BD8 RID: 3032
		// (get) Token: 0x06002804 RID: 10244 RVA: 0x000B1E56 File Offset: 0x000B0056
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public override global::Infragistics.Windows.DataPresenter.RecordType RecordType
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.RecordType.HeaderRecord;
			}
		}

		// Token: 0x06002805 RID: 10245 RVA: 0x000B1E59 File Offset: 0x000B0059
		internal override bool SetCellValue(global::Infragistics.Windows.DataPresenter.Field field, object value, bool useConverter, out global::Infragistics.Windows.DataPresenter.DataErrorInfo errorInfo, bool dontSetDataChanged)
		{
			throw new global::System.InvalidOperationException("Header record doesn't support setting values.");
		}

		// Token: 0x06002806 RID: 10246 RVA: 0x000B1E65 File Offset: 0x000B0065
		internal override bool ShouldCollapseCell(global::Infragistics.Windows.DataPresenter.Field field)
		{
			return false;
		}

		// Token: 0x06002807 RID: 10247 RVA: 0x000B1E68 File Offset: 0x000B0068
		public override string ToString()
		{
			return this.Description;
		}

		// Token: 0x17000BD9 RID: 3033
		// (get) Token: 0x06002808 RID: 10248 RVA: 0x000B1E70 File Offset: 0x000B0070
		internal override global::Infragistics.Windows.DataPresenter.ViewableRecordCollection ViewableChildRecordsIfNeeded
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000BDA RID: 3034
		// (get) Token: 0x06002809 RID: 10249 RVA: 0x000B1E73 File Offset: 0x000B0073
		// (set) Token: 0x0600280A RID: 10250 RVA: 0x000B1E7B File Offset: 0x000B007B
		internal int AttachedNestingDepth
		{
			get
			{
				return this._attachedNestingDepth;
			}
			set
			{
				if (this._attachedNestingDepth != value)
				{
					this._attachedNestingDepth = value;
					this.AttachedToRecordPrevious = null;
				}
			}
		}

		// Token: 0x17000BDB RID: 3035
		// (get) Token: 0x0600280B RID: 10251 RVA: 0x000B1E94 File Offset: 0x000B0094
		// (set) Token: 0x0600280C RID: 10252 RVA: 0x000B1EF1 File Offset: 0x000B00F1
		public global::Infragistics.Windows.DataPresenter.Record AttachedToRecord
		{
			get
			{
				if (this._attachedToRecord == null)
				{
					return null;
				}
				global::Infragistics.Windows.DataPresenter.Record record = global::Infragistics.CoreUtilities.GetWeakReferenceTargetSafe(this._attachedToRecord) as global::Infragistics.Windows.DataPresenter.Record;
				if (record == null)
				{
					this._attachedToRecord = null;
					global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = base.DataPresenter;
					if (dataPresenter != null)
					{
						dataPresenter.Dispatcher.BeginInvoke(new global::Infragistics.Windows.DataPresenter.GridUtilities.MethodDelegate(this.OnAttachedToRecordChanged), new object[0]);
					}
					return null;
				}
				return record;
			}
			internal set
			{
				if (value != this.AttachedToRecord)
				{
					this._attachedToRecordPrevious = this._attachedToRecord;
					if (value == null)
					{
						this._attachedToRecord = null;
					}
					else
					{
						this._attachedToRecord = new global::System.WeakReference(value);
					}
					this.OnAttachedToRecordChanged();
				}
			}
		}

		// Token: 0x17000BDC RID: 3036
		// (get) Token: 0x0600280D RID: 10253 RVA: 0x000B1F28 File Offset: 0x000B0128
		// (set) Token: 0x0600280E RID: 10254 RVA: 0x000B1F5D File Offset: 0x000B015D
		internal global::Infragistics.Windows.DataPresenter.Record AttachedToRecordPrevious
		{
			get
			{
				if (this._attachedToRecordPrevious == null)
				{
					return null;
				}
				global::Infragistics.Windows.DataPresenter.Record record = global::Infragistics.CoreUtilities.GetWeakReferenceTargetSafe(this._attachedToRecordPrevious) as global::Infragistics.Windows.DataPresenter.Record;
				if (record == null)
				{
					this._attachedToRecordPrevious = null;
					return null;
				}
				return record;
			}
			set
			{
				if (value != this.AttachedToRecordPrevious)
				{
					if (value == null)
					{
						this._attachedToRecordPrevious = null;
						return;
					}
					this._attachedToRecordPrevious = new global::System.WeakReference(value);
				}
			}
		}

		// Token: 0x0600280F RID: 10255 RVA: 0x000B1F7F File Offset: 0x000B017F
		private void OnAttachedToRecordChanged()
		{
			base.RaisePropertyChangedEvent("AttachedToRecord");
		}

		// Token: 0x040013A4 RID: 5028
		private global::System.WeakReference _attachedToRecord;

		// Token: 0x040013A5 RID: 5029
		private global::System.WeakReference _attachedToRecordPrevious;

		// Token: 0x040013A6 RID: 5030
		private int _attachedNestingDepth;

		// Token: 0x040013A7 RID: 5031
		internal bool _isPlaceHolder;

		// Token: 0x040013A8 RID: 5032
		internal global::Infragistics.Windows.DataPresenter.TemplateDataRecord _vrcPlaceholderRecord;
	}
}
