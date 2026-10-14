using System;
using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using Infragistics.Windows.Automation.Peers.DataPresenter;
using Infragistics.Windows.DataPresenter.Events;
using Infragistics.Windows.Editors;
using Infragistics.Windows.Selection;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200004D RID: 77
	public class Cell : global::Infragistics.PropertyChangeNotifier, global::Infragistics.Windows.Selection.ISelectableItem
	{
		// Token: 0x06000396 RID: 918 RVA: 0x0000D0DE File Offset: 0x0000B2DE
		internal Cell(global::Infragistics.Windows.DataPresenter.DataRecord record, global::Infragistics.Windows.DataPresenter.Field field)
		{
			if (record == null)
			{
				throw new global::System.ArgumentNullException("record");
			}
			if (field == null)
			{
				throw new global::System.ArgumentNullException("field");
			}
			this._record = record;
			this._field = field;
		}

		// Token: 0x06000397 RID: 919 RVA: 0x0000D11C File Offset: 0x0000B31C
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("Cell: ");
			stringBuilder.Append(this.Field.ToString());
			stringBuilder.Append(", ");
			stringBuilder.Append(this.Record.ToString());
			return stringBuilder.ToString();
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x06000398 RID: 920 RVA: 0x0000D171 File Offset: 0x0000B371
		// (set) Token: 0x06000399 RID: 921 RVA: 0x0000D185 File Offset: 0x0000B385
		public virtual object ConvertedValue
		{
			get
			{
				return this._record.GetCellValue(this._field, true);
			}
			set
			{
				this._record.SetCellValue(this._field, value, true);
			}
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x0600039A RID: 922 RVA: 0x0000D19B File Offset: 0x0000B39B
		public object DataError
		{
			get
			{
				return this._record.GetCellDataError(this._field);
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x0600039B RID: 923 RVA: 0x0000D1AE File Offset: 0x0000B3AE
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::Infragistics.Windows.DataPresenter.DataPresenterBase DataPresenter
		{
			get
			{
				return this._field.Owner.DataPresenter;
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x0600039C RID: 924 RVA: 0x0000D1C0 File Offset: 0x0000B3C0
		// (set) Token: 0x0600039D RID: 925 RVA: 0x0000D1C8 File Offset: 0x0000B3C8
		public global::System.Type EditAsType
		{
			get
			{
				return this._editAsType;
			}
			set
			{
				if (value != this._editAsType)
				{
					this._editAsType = value;
					base.RaisePropertyChangedEvent("EditAsType");
					this.ReInitializeCVPEditor();
				}
			}
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x0600039E RID: 926 RVA: 0x0000D1F0 File Offset: 0x0000B3F0
		// (set) Token: 0x0600039F RID: 927 RVA: 0x0000D1F8 File Offset: 0x0000B3F8
		public global::System.Type EditorType
		{
			get
			{
				return this._editorType;
			}
			set
			{
				if (value != this._editorType)
				{
					this._editorType = value;
					base.RaisePropertyChangedEvent("EditorType");
					this.ReInitializeCVPEditor();
				}
			}
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x060003A0 RID: 928 RVA: 0x0000D220 File Offset: 0x0000B420
		// (set) Token: 0x060003A1 RID: 929 RVA: 0x0000D228 File Offset: 0x0000B428
		public global::System.Windows.Style EditorStyle
		{
			get
			{
				return this._editorStyle;
			}
			set
			{
				if (value != this._editorStyle)
				{
					this._editorStyle = value;
					base.RaisePropertyChangedEvent("EditorStyle");
					this.ReInitializeCVPEditor();
				}
			}
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x060003A2 RID: 930 RVA: 0x0000D24B File Offset: 0x0000B44B
		public global::Infragistics.Windows.DataPresenter.Field Field
		{
			get
			{
				return this._field;
			}
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x060003A3 RID: 931 RVA: 0x0000D253 File Offset: 0x0000B453
		public bool HasDataError
		{
			get
			{
				return this._record.GetCellHasDataError(this._field);
			}
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x060003A4 RID: 932 RVA: 0x0000D268 File Offset: 0x0000B468
		// (set) Token: 0x060003A5 RID: 933 RVA: 0x0000D28C File Offset: 0x0000B48C
		public bool IsActive
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this.DataPresenter;
				return dataPresenter != null && dataPresenter.ActiveCell == this;
			}
			set
			{
				if (this.IsActive != value)
				{
					if (this.DataPresenter == null)
					{
						throw new global::System.InvalidOperationException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_InvalidOperationException_5"));
					}
					if (value)
					{
						this.DataPresenter.ActiveCell = this;
						return;
					}
					if (this == this.DataPresenter.ActiveCell)
					{
						this.DataPresenter.ActiveCell = null;
					}
				}
			}
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x060003A6 RID: 934 RVA: 0x0000D2E8 File Offset: 0x0000B4E8
		public bool IsDataChanged
		{
			get
			{
				if (this._isDataChanged)
				{
					return true;
				}
				if (this.IsActive)
				{
					global::Infragistics.Windows.DataPresenter.CellValuePresenter associatedCellValuePresenter = this.AssociatedCellValuePresenter;
					if (associatedCellValuePresenter != null && associatedCellValuePresenter.Editor != null)
					{
						return associatedCellValuePresenter.Editor.HasValueChanged;
					}
				}
				return false;
			}
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x060003A7 RID: 935 RVA: 0x0000D328 File Offset: 0x0000B528
		public bool IsInEditMode
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.CellValuePresenter associatedCellValuePresenter = this.AssociatedCellValuePresenter;
				return associatedCellValuePresenter != null && associatedCellValuePresenter.IsInEditMode;
			}
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x060003A8 RID: 936 RVA: 0x0000D347 File Offset: 0x0000B547
		// (set) Token: 0x060003A9 RID: 937 RVA: 0x0000D350 File Offset: 0x0000B550
		public bool IsSelected
		{
			get
			{
				return this._selected;
			}
			set
			{
				if (this._selected != value)
				{
					global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this.DataPresenter;
					if (dataPresenter != null)
					{
						bool clearExistingSelection = true;
						global::Infragistics.Windows.Selection.SelectionStrategyBase selectionStrategyForItem = this.Field.Owner.GetSelectionStrategyForItem(this);
						if (selectionStrategyForItem != null)
						{
							clearExistingSelection = selectionStrategyForItem.IsSingleSelect;
						}
						if (!dataPresenter.ClearSelectedRecords())
						{
							return;
						}
						bool flag = dataPresenter.InternalSelectItem(this, clearExistingSelection, value);
						if (flag && dataPresenter.SelectedItems.Cells.Count == 1)
						{
							((global::Infragistics.Windows.Selection.ISelectionHost)dataPresenter).SetPivotItem(this, false);
						}
					}
				}
			}
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x060003AA RID: 938 RVA: 0x0000D3BF File Offset: 0x0000B5BF
		public virtual bool IsUnbound
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x060003AB RID: 939 RVA: 0x0000D3C2 File Offset: 0x0000B5C2
		public global::Infragistics.Windows.DataPresenter.DataRecord Record
		{
			get
			{
				return this._record;
			}
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x060003AC RID: 940 RVA: 0x0000D3CA File Offset: 0x0000B5CA
		// (set) Token: 0x060003AD RID: 941 RVA: 0x0000D3D2 File Offset: 0x0000B5D2
		public object Tag
		{
			get
			{
				return this._tag;
			}
			set
			{
				if (this._tag != value)
				{
					this._tag = value;
					base.RaisePropertyChangedEvent("Tag");
				}
			}
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x060003AE RID: 942 RVA: 0x0000D3EF File Offset: 0x0000B5EF
		// (set) Token: 0x060003AF RID: 943 RVA: 0x0000D403 File Offset: 0x0000B603
		public object Value
		{
			get
			{
				return this._record.GetCellValue(this._field, false);
			}
			set
			{
				this._record.SetCellValue(this._field, value, false);
			}
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x060003B0 RID: 944 RVA: 0x0000D419 File Offset: 0x0000B619
		// (set) Token: 0x060003B1 RID: 945 RVA: 0x0000D422 File Offset: 0x0000B622
		internal global::Infragistics.Windows.DataPresenter.CellValuePresenter AssociatedCellValuePresenterInternal
		{
			get
			{
				return this.GetAssociatedCellValuePresenter(true);
			}
			set
			{
				if (value != this.GetAssociatedCellValuePresenter(false))
				{
					if (value != null)
					{
						if (global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.GetIsAutoSizeElement(value))
						{
							return;
						}
						this._associatedCellValuePresenter = value.WeakRef;
						return;
					}
					else
					{
						this.ClearAssociatedCellValuePresenter();
					}
				}
			}
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x060003B2 RID: 946 RVA: 0x0000D44D File Offset: 0x0000B64D
		internal global::Infragistics.Windows.DataPresenter.CellValuePresenter AssociatedCellValuePresenter
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.CellValuePresenter.FromCell(this);
			}
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x060003B3 RID: 947 RVA: 0x0000D458 File Offset: 0x0000B658
		internal global::System.Windows.Automation.Peers.AutomationPeer AutomationPeer
		{
			get
			{
				global::Infragistics.Windows.Automation.Peers.DataPresenter.RecordAutomationPeer recordAutomationPeer = (this._record != null) ? this._record.AutomationPeer : null;
				if (recordAutomationPeer == null)
				{
					return null;
				}
				return recordAutomationPeer.GetCellPeer(this);
			}
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x060003B4 RID: 948 RVA: 0x0000D488 File Offset: 0x0000B688
		internal global::Infragistics.Windows.DataPresenter.DataValueInfoHistory DataValueInfoHistoryCache
		{
			get
			{
				return this.GetDataValueHistoryCache(this.AssociatedCellValuePresenter);
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x060003B5 RID: 949 RVA: 0x0000D496 File Offset: 0x0000B696
		internal global::System.Type EditAsTypeResolved
		{
			get
			{
				if (this._editAsType != null)
				{
					return this._editAsType;
				}
				return this._field.EditAsTypeResolved;
			}
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x060003B6 RID: 950 RVA: 0x0000D4B8 File Offset: 0x0000B6B8
		internal global::System.Type EditorTypeResolved
		{
			get
			{
				if (this._editorType != null)
				{
					return this._editorType;
				}
				if (this._editAsType != null)
				{
					global::System.Type defaultEditorForType = global::Infragistics.Windows.Editors.ValueEditor.GetDefaultEditorForType(this._editAsType);
					if (defaultEditorForType != null)
					{
						return defaultEditorForType;
					}
				}
				return this._field.EditorTypeResolved;
			}
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x060003B7 RID: 951 RVA: 0x0000D50A File Offset: 0x0000B70A
		// (set) Token: 0x060003B8 RID: 952 RVA: 0x0000D512 File Offset: 0x0000B712
		internal int FieldAutoSizeVersion
		{
			get
			{
				return this._fieldAutoSizeVersion;
			}
			set
			{
				this._fieldAutoSizeVersion = value;
			}
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x060003B9 RID: 953 RVA: 0x0000D51B File Offset: 0x0000B71B
		internal virtual bool HasCloneableSettings
		{
			get
			{
				return this._editAsType != null || this._editorType != null || this._editorStyle != null || this._tag != null;
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x060003BA RID: 954 RVA: 0x0000D54F File Offset: 0x0000B74F
		internal bool IsEditingAllowed
		{
			get
			{
				return this.Field.GetIsEditingAllowed(this._record);
			}
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x060003BB RID: 955 RVA: 0x0000D564 File Offset: 0x0000B764
		internal virtual bool IsSelectable
		{
			get
			{
				if (!this._record.IsEnabledResolved)
				{
					return false;
				}
				global::Infragistics.Windows.Selection.SelectionStrategyBase selectionStrategyForItem = this.Field.Owner.GetSelectionStrategyForItem(this);
				return selectionStrategyForItem != null && !(selectionStrategyForItem is global::Infragistics.Windows.Selection.SelectionStrategyNone);
			}
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x060003BC RID: 956 RVA: 0x0000D5A0 File Offset: 0x0000B7A0
		internal virtual bool IsTabStop
		{
			get
			{
				if (!this._record.IsEnabledResolved)
				{
					return false;
				}
				global::Infragistics.Windows.DataPresenter.CellValuePresenter associatedCellValuePresenterInternal = this.AssociatedCellValuePresenterInternal;
				return associatedCellValuePresenterInternal == null || (associatedCellValuePresenterInternal.Visibility == global::System.Windows.Visibility.Visible && associatedCellValuePresenterInternal.IsEnabled);
			}
		}

		// Token: 0x060003BD RID: 957 RVA: 0x0000D5D9 File Offset: 0x0000B7D9
		public bool EndEditMode()
		{
			return this.EndEditMode(true, false);
		}

		// Token: 0x060003BE RID: 958 RVA: 0x0000D5E3 File Offset: 0x0000B7E3
		internal bool EndEditMode(bool acceptChanges)
		{
			return this.EndEditMode(acceptChanges, false);
		}

		// Token: 0x060003BF RID: 959 RVA: 0x0000D5F0 File Offset: 0x0000B7F0
		internal bool EndEditMode(bool acceptChanges, bool forceExit)
		{
			global::Infragistics.Windows.DataPresenter.CellValuePresenter associatedCellValuePresenter = this.AssociatedCellValuePresenter;
			if (associatedCellValuePresenter == null)
			{
				return true;
			}
			associatedCellValuePresenter.EndEditMode(acceptChanges, forceExit);
			return !associatedCellValuePresenter.IsInEditMode;
		}

		// Token: 0x060003C0 RID: 960 RVA: 0x0000D61C File Offset: 0x0000B81C
		public void SetEditorSettings(global::System.Type editorType, global::System.Windows.Style editorStyle, global::System.Type editAsType)
		{
			bool flag = false;
			if (editorType != this._editorType)
			{
				this._editorType = editorType;
				base.RaisePropertyChangedEvent("EditorType");
				flag = true;
			}
			if (editorStyle != this._editorStyle)
			{
				this._editorStyle = editorStyle;
				base.RaisePropertyChangedEvent("EditorStyle");
				flag = true;
			}
			if (editAsType != this._editAsType)
			{
				this._editAsType = editAsType;
				base.RaisePropertyChangedEvent("EditAsType");
			}
			if (flag)
			{
				this.ReInitializeCVPEditor();
			}
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x0000D694 File Offset: 0x0000B894
		internal void AddDataValueChangedHistoryEntryForCurrentValue()
		{
			global::Infragistics.Windows.DataPresenter.DataValueInfoHistory dataValueInfoHistoryCache = this.DataValueInfoHistoryCache;
			if (dataValueInfoHistoryCache != null)
			{
				dataValueInfoHistoryCache.AddEntry(this.Value, global::System.DateTime.Now, null);
			}
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x0000D6BD File Offset: 0x0000B8BD
		internal void ClearAssociatedIfMatch(global::Infragistics.Windows.DataPresenter.CellValuePresenter cvp)
		{
			if (this._associatedCellValuePresenter != null && cvp == global::Infragistics.CoreUtilities.GetWeakReferenceTargetSafe(this._associatedCellValuePresenter))
			{
				this.ClearAssociatedCellValuePresenter();
			}
		}

		// Token: 0x060003C3 RID: 963 RVA: 0x0000D6DC File Offset: 0x0000B8DC
		internal void ClearDataValueChangedHistory(bool destroyCache)
		{
			if (this._dataValueInfoHistoryCache != null)
			{
				if (destroyCache)
				{
					this._dataValueInfoHistoryCache.ClearCacheEntries(false);
					global::Infragistics.Windows.DataPresenter.DataValueInfoHistory.Release(this._dataValueInfoHistoryCache);
					this._dataValueInfoHistoryCache = null;
					global::Infragistics.Windows.DataPresenter.CellValuePresenter cellValuePresenter = global::Infragistics.CoreUtilities.GetWeakReferenceTargetSafe(this._associatedCellValuePresenter) as global::Infragistics.Windows.DataPresenter.CellValuePresenter;
					if (cellValuePresenter != null)
					{
						cellValuePresenter.ClearValue(global::Infragistics.Windows.DataPresenter.CellValuePresenter.ValueHistoryPropertyKey);
						return;
					}
				}
				else
				{
					this._dataValueInfoHistoryCache.ClearCacheEntries(true);
				}
			}
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x0000D73E File Offset: 0x0000B93E
		internal virtual void CloneAssociatedCellSettings(global::Infragistics.Windows.DataPresenter.Cell associatedCell)
		{
			this._editAsType = associatedCell._editAsType;
			this._editorType = associatedCell._editorType;
			this._editorStyle = associatedCell._editorStyle;
			this._tag = associatedCell._tag;
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x0000D770 File Offset: 0x0000B970
		internal void DirtyFieldAutoSizeVersion()
		{
			this._fieldAutoSizeVersion--;
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x0000D780 File Offset: 0x0000B980
		internal void FocusIfActive()
		{
			if (this.IsActive)
			{
				global::Infragistics.Windows.DataPresenter.CellValuePresenter cellValuePresenter = global::Infragistics.Windows.DataPresenter.CellValuePresenter.FromRecordAndField(this.Record, this.Field);
				if (cellValuePresenter != null)
				{
					cellValuePresenter.FocusIfAppropriate();
				}
			}
		}

		// Token: 0x060003C7 RID: 967 RVA: 0x0000D7B0 File Offset: 0x0000B9B0
		internal global::Infragistics.Windows.DataPresenter.CellValuePresenter GetAssociatedCellValuePresenter(bool canSearchElementTree)
		{
			if (this._associatedCellValuePresenter == null)
			{
				return null;
			}
			if (this._associatedCellValuePresenter == global::Infragistics.Windows.DataPresenter.Cell.UninitializedCVP)
			{
				if (!canSearchElementTree)
				{
					return null;
				}
				this._associatedCellValuePresenter = null;
				global::Infragistics.Windows.DataPresenter.CellValuePresenter cellValuePresenter;
				if (this._record is global::Infragistics.Windows.DataPresenter.TemplateDataRecord)
				{
					cellValuePresenter = null;
				}
				else
				{
					cellValuePresenter = global::Infragistics.Windows.DataPresenter.CellValuePresenter.FromRecordAndField(this._record, this._field);
				}
				if (cellValuePresenter != null)
				{
					this._associatedCellValuePresenter = cellValuePresenter.WeakRef;
				}
				return cellValuePresenter;
			}
			else
			{
				global::Infragistics.Windows.DataPresenter.CellValuePresenter cellValuePresenter = global::Infragistics.CoreUtilities.GetWeakReferenceTargetSafe(this._associatedCellValuePresenter) as global::Infragistics.Windows.DataPresenter.CellValuePresenter;
				if (cellValuePresenter == null)
				{
					this.ClearAssociatedCellValuePresenter();
					return null;
				}
				if (cellValuePresenter.Record != this._record || cellValuePresenter.Field != this._field)
				{
					this.ClearAssociatedCellValuePresenter();
					return null;
				}
				return cellValuePresenter;
			}
		}

		// Token: 0x060003C8 RID: 968 RVA: 0x0000D858 File Offset: 0x0000BA58
		internal global::Infragistics.Windows.DataPresenter.DataValueInfoHistory GetDataValueHistoryCache(global::Infragistics.Windows.DataPresenter.CellValuePresenter cvp)
		{
			int dataValueChangedHistoryLimitResolved = this.Field.DataValueChangedHistoryLimitResolved;
			if (dataValueChangedHistoryLimitResolved < 1 && this._dataValueInfoHistoryCache != null)
			{
				this.ClearDataValueChangedHistory(true);
			}
			if (this._dataValueInfoHistoryCache == null)
			{
				if (dataValueChangedHistoryLimitResolved > 0)
				{
					this._dataValueInfoHistoryCache = global::Infragistics.Windows.DataPresenter.DataValueInfoHistory.Create(dataValueChangedHistoryLimitResolved);
					if (cvp != null && cvp.ValueHistory == null)
					{
						cvp.SetValue(global::Infragistics.Windows.DataPresenter.CellValuePresenter.ValueHistoryPropertyKey, this._dataValueInfoHistoryCache);
					}
				}
			}
			else if (this._dataValueInfoHistoryCache.Capacity != dataValueChangedHistoryLimitResolved && dataValueChangedHistoryLimitResolved > 0)
			{
				this._dataValueInfoHistoryCache = global::Infragistics.Windows.DataPresenter.DataValueInfoHistory.GetResizedInstance(this._dataValueInfoHistoryCache, dataValueChangedHistoryLimitResolved);
				if (cvp != null)
				{
					cvp.SetValue(global::Infragistics.Windows.DataPresenter.CellValuePresenter.ValueHistoryPropertyKey, this._dataValueInfoHistoryCache);
				}
			}
			if (this._dataValueInfoHistoryCache == null && cvp != null)
			{
				cvp.ClearValue(global::Infragistics.Windows.DataPresenter.CellValuePresenter.ValueHistoryPropertyKey);
			}
			return this._dataValueInfoHistoryCache;
		}

		// Token: 0x060003C9 RID: 969 RVA: 0x0000D90E File Offset: 0x0000BB0E
		internal void InternalSelect(bool value)
		{
			if (this._selected != value)
			{
				this._selected = value;
				this.RaiseAutomationIsSelectedChanged();
				base.RaisePropertyChangedEvent("IsSelected");
				this.Record.OnCellSelectionChange();
			}
		}

		// Token: 0x060003CA RID: 970 RVA: 0x0000D93C File Offset: 0x0000BB3C
		internal void InternalSetDataChanged(bool value)
		{
			if (this._isDataChanged != value)
			{
				this._isDataChanged = value;
				base.RaisePropertyChangedEvent("IsDataChanged");
				if (value)
				{
					this.Record.InternalSetDataChanged(true);
					return;
				}
				global::Infragistics.Windows.DataPresenter.CellValuePresenter associatedCellValuePresenter = this.AssociatedCellValuePresenter;
				if (associatedCellValuePresenter != null)
				{
					associatedCellValuePresenter.SetValueInternal(this.ConvertedValue, false);
				}
			}
		}

		// Token: 0x060003CB RID: 971 RVA: 0x0000D98C File Offset: 0x0000BB8C
		internal bool IsOnSameTier(global::Infragistics.Windows.DataPresenter.Cell cell, global::System.Windows.Controls.Orientation orientation)
		{
			if (cell == null || cell.Record != this.Record)
			{
				return false;
			}
			global::Infragistics.Windows.DataPresenter.Field.FieldGridPosition gridPosition = this.Field.GridPosition;
			global::Infragistics.Windows.DataPresenter.Field.FieldGridPosition gridPosition2 = cell.Field.GridPosition;
			if (orientation == global::System.Windows.Controls.Orientation.Vertical)
			{
				return gridPosition.Row == gridPosition2.Row && gridPosition.RowSpan == gridPosition2.RowSpan;
			}
			return gridPosition.Column == gridPosition2.Column && gridPosition.ColumnSpan == gridPosition2.ColumnSpan;
		}

		// Token: 0x060003CC RID: 972 RVA: 0x0000DA05 File Offset: 0x0000BC05
		internal virtual void OnActiveCellChanged()
		{
			base.RaisePropertyChangedEvent("IsActive");
			this.Record.OnActiveCellChanged();
		}

		// Token: 0x060003CD RID: 973 RVA: 0x0000DA20 File Offset: 0x0000BC20
		internal void OnEditValueChanged(global::Infragistics.Windows.DataPresenter.CellValuePresenter cellValuePresenter)
		{
			if (!this._isDataChanged)
			{
				base.RaisePropertyChangedEvent("IsDataChanged");
				this.Record.OnEditValueChanged(true);
			}
			this.Record.ClearSizeToContentManager(this);
			global::Infragistics.Windows.DataPresenter.Events.CellChangedEventArgs args = new global::Infragistics.Windows.DataPresenter.Events.CellChangedEventArgs(this, cellValuePresenter.Editor);
			this.DataPresenter.RaiseCellChanged(args);
		}

		// Token: 0x060003CE RID: 974 RVA: 0x0000DA74 File Offset: 0x0000BC74
		internal void RaiseAutomationIsSelectedChanged()
		{
			global::System.Windows.Automation.Peers.AutomationPeer automationPeer = this.AutomationPeer;
			if (automationPeer != null)
			{
				automationPeer.RaisePropertyChangedEvent(global::System.Windows.Automation.SelectionItemPatternIdentifiers.IsSelectedProperty, !this._selected, this._selected);
			}
		}

		// Token: 0x060003CF RID: 975 RVA: 0x0000DAB0 File Offset: 0x0000BCB0
		internal bool RaiseAutomationSelectedChange(global::System.Windows.Automation.Peers.AutomationEvents eventId)
		{
			global::System.Windows.Automation.Peers.AutomationPeer automationPeer = this.AutomationPeer;
			if (automationPeer != null)
			{
				automationPeer.RaiseAutomationEvent(eventId);
				return true;
			}
			return false;
		}

		// Token: 0x060003D0 RID: 976 RVA: 0x0000DAD4 File Offset: 0x0000BCD4
		internal void RaiseAutomationValueChanged(object oldValue, object newValue)
		{
			global::Infragistics.Windows.Automation.Peers.DataPresenter.CellAutomationPeer cellAutomationPeer = this.AutomationPeer as global::Infragistics.Windows.Automation.Peers.DataPresenter.CellAutomationPeer;
			if (cellAutomationPeer != null)
			{
				cellAutomationPeer.RaiseValuePropertyChangedEvent(oldValue, newValue);
			}
		}

		// Token: 0x060003D1 RID: 977 RVA: 0x0000DAF8 File Offset: 0x0000BCF8
		internal void RaiseDataErrorNotifications()
		{
			if (base.HasListeners)
			{
				base.RaisePropertyChangedEvent("DataError");
				base.RaisePropertyChangedEvent("HasDataError");
			}
			global::Infragistics.Windows.DataPresenter.CellValuePresenter associatedCellValuePresenter = this.AssociatedCellValuePresenter;
			if (associatedCellValuePresenter != null)
			{
				associatedCellValuePresenter.UpdateDataError();
			}
		}

		// Token: 0x060003D2 RID: 978 RVA: 0x0000DB34 File Offset: 0x0000BD34
		internal void RaiseValueChangedNotifications()
		{
			if (base.HasListeners && !this._isRaisingPropChangeNotifactions)
			{
				this._isRaisingPropChangeNotifactions = true;
				try
				{
					base.RaisePropertyChangedEvent("Value");
					base.RaisePropertyChangedEvent("ConvertedValue");
				}
				finally
				{
					this._isRaisingPropChangeNotifactions = false;
				}
			}
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x0000DB88 File Offset: 0x0000BD88
		private void ClearAssociatedCellValuePresenter()
		{
			if (this._dataValueInfoHistoryCache != null && this.Field.DataValueChangedScopeResolved == global::Infragistics.Windows.DataPresenter.DataValueChangedScope.OnlyRecordsInView)
			{
				global::Infragistics.Windows.DataPresenter.DataValueInfoHistory.Release(this._dataValueInfoHistoryCache);
				this._dataValueInfoHistoryCache = null;
				global::Infragistics.Windows.DataPresenter.CellValuePresenter cellValuePresenter = global::Infragistics.CoreUtilities.GetWeakReferenceTargetSafe(this._associatedCellValuePresenter) as global::Infragistics.Windows.DataPresenter.CellValuePresenter;
				if (cellValuePresenter != null)
				{
					cellValuePresenter.ClearValue(global::Infragistics.Windows.DataPresenter.CellValuePresenter.ValueHistoryPropertyKey);
				}
			}
			this._associatedCellValuePresenter = null;
			if (this is global::Infragistics.Windows.DataPresenter.UnboundCell && !((global::Infragistics.Windows.DataPresenter.UnboundCell)this).MaintainBindings)
			{
				((global::Infragistics.Windows.DataPresenter.UnboundCell)this).ClearValueHolder();
			}
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x0000DC04 File Offset: 0x0000BE04
		private void ReInitializeCVPEditor()
		{
			global::Infragistics.Windows.DataPresenter.CellValuePresenter associatedCellValuePresenter = this.AssociatedCellValuePresenter;
			if (associatedCellValuePresenter != null)
			{
				associatedCellValuePresenter.InitializeEditor(associatedCellValuePresenter.Value);
			}
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x060003D5 RID: 981 RVA: 0x0000DC27 File Offset: 0x0000BE27
		bool global::Infragistics.Windows.Selection.ISelectableItem.IsDraggable
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x060003D6 RID: 982 RVA: 0x0000DC2A File Offset: 0x0000BE2A
		bool global::Infragistics.Windows.Selection.ISelectableItem.IsSelectable
		{
			get
			{
				return this.IsSelectable;
			}
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x060003D7 RID: 983 RVA: 0x0000DC32 File Offset: 0x0000BE32
		bool global::Infragistics.Windows.Selection.ISelectableItem.IsSelected
		{
			get
			{
				return this.IsSelected;
			}
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x060003D8 RID: 984 RVA: 0x0000DC3A File Offset: 0x0000BE3A
		bool global::Infragistics.Windows.Selection.ISelectableItem.IsTabStop
		{
			get
			{
				return this.IsTabStop;
			}
		}

		// Token: 0x040000E6 RID: 230
		private global::Infragistics.Windows.DataPresenter.DataRecord _record;

		// Token: 0x040000E7 RID: 231
		private global::Infragistics.Windows.DataPresenter.Field _field;

		// Token: 0x040000E8 RID: 232
		private global::System.Type _editAsType;

		// Token: 0x040000E9 RID: 233
		private global::System.Type _editorType;

		// Token: 0x040000EA RID: 234
		private global::System.Windows.Style _editorStyle;

		// Token: 0x040000EB RID: 235
		private bool _selected;

		// Token: 0x040000EC RID: 236
		private bool _isDataChanged;

		// Token: 0x040000ED RID: 237
		private bool _isRaisingPropChangeNotifactions;

		// Token: 0x040000EE RID: 238
		private static readonly global::System.WeakReference UninitializedCVP = new global::System.WeakReference(null);

		// Token: 0x040000EF RID: 239
		private global::System.WeakReference _associatedCellValuePresenter = global::Infragistics.Windows.DataPresenter.Cell.UninitializedCVP;

		// Token: 0x040000F0 RID: 240
		private object _tag;

		// Token: 0x040000F1 RID: 241
		private global::Infragistics.Windows.DataPresenter.DataValueInfoHistory _dataValueInfoHistoryCache;

		// Token: 0x040000F2 RID: 242
		private int _fieldAutoSizeVersion;
	}
}
