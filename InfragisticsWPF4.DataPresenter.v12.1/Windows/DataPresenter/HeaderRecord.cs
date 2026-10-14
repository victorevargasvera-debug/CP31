using System;
using System.ComponentModel;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000304 RID: 772
	public class HeaderRecord : global::Infragistics.Windows.DataPresenter.DataRecord
	{
		// Token: 0x06002443 RID: 9283 RVA: 0x0009DF21 File Offset: 0x0009C121
		internal HeaderRecord(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout, global::Infragistics.Windows.DataPresenter.RecordCollectionBase parentCollection) : base(fieldLayout, parentCollection)
		{
		}

		// Token: 0x17000A9F RID: 2719
		// (get) Token: 0x06002444 RID: 9284 RVA: 0x0009DF2B File Offset: 0x0009C12B
		internal override global::Infragistics.Windows.DataPresenter.RecordCollectionBase ChildRecordsIfNeeded
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000AA0 RID: 2720
		// (get) Token: 0x06002445 RID: 9285 RVA: 0x0009DF2E File Offset: 0x0009C12E
		internal override global::Infragistics.Windows.DataPresenter.RecordCollectionBase ChildRecordsInternal
		{
			get
			{
				return null;
			}
		}

		// Token: 0x06002446 RID: 9286 RVA: 0x0009DF31 File Offset: 0x0009C131
		internal override global::Infragistics.Windows.DataPresenter.CellCollection CreateCellCollection()
		{
			return null;
		}

		// Token: 0x17000AA1 RID: 2721
		// (get) Token: 0x06002447 RID: 9287 RVA: 0x0009DF34 File Offset: 0x0009C134
		// (set) Token: 0x06002448 RID: 9288 RVA: 0x0009DF4F File Offset: 0x0009C14F
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

		// Token: 0x06002449 RID: 9289 RVA: 0x0009DF58 File Offset: 0x0009C158
		public override global::Infragistics.Windows.DataPresenter.Record GetAssociatedRecord()
		{
			return null;
		}

		// Token: 0x0600244A RID: 9290 RVA: 0x0009DF5B File Offset: 0x0009C15B
		public override object GetCellValue(global::Infragistics.Windows.DataPresenter.Field field, bool useConverter)
		{
			return this.GetCellValue(field, useConverter ? global::Infragistics.Windows.DataPresenter.CellValueType.Converted : global::Infragistics.Windows.DataPresenter.CellValueType.Raw);
		}

		// Token: 0x0600244B RID: 9291 RVA: 0x0009DF6B File Offset: 0x0009C16B
		public override object GetCellValue(global::Infragistics.Windows.DataPresenter.Field field, global::Infragistics.Windows.DataPresenter.CellValueType cellValueType)
		{
			return field.Label;
		}

		// Token: 0x0600244C RID: 9292 RVA: 0x0009DF73 File Offset: 0x0009C173
		internal override global::System.Type GetEditorTypeResolved(global::Infragistics.Windows.DataPresenter.Field field)
		{
			return null;
		}

		// Token: 0x0600244D RID: 9293 RVA: 0x0009DF76 File Offset: 0x0009C176
		internal override bool GetIsEditingAllowed(global::Infragistics.Windows.DataPresenter.Field field)
		{
			return false;
		}

		// Token: 0x17000AA2 RID: 2722
		// (get) Token: 0x0600244E RID: 9294 RVA: 0x0009DF79 File Offset: 0x0009C179
		internal override bool HasChildrenInternal
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000AA3 RID: 2723
		// (get) Token: 0x0600244F RID: 9295 RVA: 0x0009DF7C File Offset: 0x0009C17C
		public override bool IsDataRecord
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000AA4 RID: 2724
		// (get) Token: 0x06002450 RID: 9296 RVA: 0x0009DF7F File Offset: 0x0009C17F
		protected internal override bool IsSelectable
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000AA5 RID: 2725
		// (get) Token: 0x06002451 RID: 9297 RVA: 0x0009DF82 File Offset: 0x0009C182
		public override bool IsSpecialRecord
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000AA6 RID: 2726
		// (get) Token: 0x06002452 RID: 9298 RVA: 0x0009DF88 File Offset: 0x0009C188
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

		// Token: 0x17000AA7 RID: 2727
		// (get) Token: 0x06002453 RID: 9299 RVA: 0x0009E0CA File Offset: 0x0009C2CA
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public override global::Infragistics.Windows.DataPresenter.RecordType RecordType
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.RecordType.HeaderRecord;
			}
		}

		// Token: 0x06002454 RID: 9300 RVA: 0x0009E0CD File Offset: 0x0009C2CD
		internal override bool SetCellValue(global::Infragistics.Windows.DataPresenter.Field field, object value, bool useConverter, out global::Infragistics.Windows.DataPresenter.DataErrorInfo errorInfo, bool dontSetDataChanged)
		{
			throw new global::System.InvalidOperationException("Header record doesn't support setting values.");
		}

		// Token: 0x06002455 RID: 9301 RVA: 0x0009E0D9 File Offset: 0x0009C2D9
		internal override bool ShouldCollapseCell(global::Infragistics.Windows.DataPresenter.Field field)
		{
			return false;
		}

		// Token: 0x06002456 RID: 9302 RVA: 0x0009E0DC File Offset: 0x0009C2DC
		public override string ToString()
		{
			return this.Description;
		}

		// Token: 0x17000AA8 RID: 2728
		// (get) Token: 0x06002457 RID: 9303 RVA: 0x0009E0E4 File Offset: 0x0009C2E4
		internal override global::Infragistics.Windows.DataPresenter.ViewableRecordCollection ViewableChildRecordsIfNeeded
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000AA9 RID: 2729
		// (get) Token: 0x06002458 RID: 9304 RVA: 0x0009E0E7 File Offset: 0x0009C2E7
		// (set) Token: 0x06002459 RID: 9305 RVA: 0x0009E0EF File Offset: 0x0009C2EF
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

		// Token: 0x17000AAA RID: 2730
		// (get) Token: 0x0600245A RID: 9306 RVA: 0x0009E108 File Offset: 0x0009C308
		// (set) Token: 0x0600245B RID: 9307 RVA: 0x0009E165 File Offset: 0x0009C365
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

		// Token: 0x17000AAB RID: 2731
		// (get) Token: 0x0600245C RID: 9308 RVA: 0x0009E19C File Offset: 0x0009C39C
		// (set) Token: 0x0600245D RID: 9309 RVA: 0x0009E1D1 File Offset: 0x0009C3D1
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

		// Token: 0x0600245E RID: 9310 RVA: 0x0009E1F3 File Offset: 0x0009C3F3
		private void OnAttachedToRecordChanged()
		{
			base.RaisePropertyChangedEvent("AttachedToRecord");
		}

		// Token: 0x04001184 RID: 4484
		private global::System.WeakReference _attachedToRecord;

		// Token: 0x04001185 RID: 4485
		private global::System.WeakReference _attachedToRecordPrevious;

		// Token: 0x04001186 RID: 4486
		private int _attachedNestingDepth;

		// Token: 0x04001187 RID: 4487
		internal bool _isPlaceHolder;

		// Token: 0x04001188 RID: 4488
		internal global::Infragistics.Windows.DataPresenter.TemplateDataRecord _vrcPlaceholderRecord;
	}
}
