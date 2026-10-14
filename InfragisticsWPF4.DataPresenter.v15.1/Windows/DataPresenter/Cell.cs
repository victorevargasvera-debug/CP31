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
		// Token: 0x060003B4 RID: 948 RVA: 0x0000DB21 File Offset: 0x0000BD21
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

		// Token: 0x060003B5 RID: 949 RVA: 0x0000DB60 File Offset: 0x0000BD60
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("Cell: ");
			stringBuilder.Append(this.Field.ToString());
			stringBuilder.Append(", ");
			stringBuilder.Append(this.Record.ToString());
			return stringBuilder.ToString();
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x060003B6 RID: 950 RVA: 0x0000DBB5 File Offset: 0x0000BDB5
		// (set) Token: 0x060003B7 RID: 951 RVA: 0x0000DBC9 File Offset: 0x0000BDC9
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

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x060003B8 RID: 952 RVA: 0x0000DBDF File Offset: 0x0000BDDF
		public object DataError
		{
			get
			{
				return this._record.GetCellDataError(this._field);
			}
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x060003B9 RID: 953 RVA: 0x0000DBF2 File Offset: 0x0000BDF2
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::Infragistics.Windows.DataPresenter.DataPresenterBase DataPresenter
		{
			get
			{
				return this._field.Owner.DataPresenter;
			}
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x060003BA RID: 954 RVA: 0x0000DC04 File Offset: 0x0000BE04
		// (set) Token: 0x060003BB RID: 955 RVA: 0x0000DC0C File Offset: 0x0000BE0C
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

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x060003BC RID: 956 RVA: 0x0000DC34 File Offset: 0x0000BE34
		// (set) Token: 0x060003BD RID: 957 RVA: 0x0000DC3C File Offset: 0x0000BE3C
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

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x060003BE RID: 958 RVA: 0x0000DC64 File Offset: 0x0000BE64
		// (set) Token: 0x060003BF RID: 959 RVA: 0x0000DC6C File Offset: 0x0000BE6C
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

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x060003C0 RID: 960 RVA: 0x0000DC8F File Offset: 0x0000BE8F
		public global::Infragistics.Windows.DataPresenter.Field Field
		{
			get
			{
				return this._field;
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x060003C1 RID: 961 RVA: 0x0000DC97 File Offset: 0x0000BE97
		public bool HasDataError
		{
			get
			{
				return this._record.GetCellHasDataError(this._field);
			}
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x060003C2 RID: 962 RVA: 0x0000DCAC File Offset: 0x0000BEAC
		// (set) Token: 0x060003C3 RID: 963 RVA: 0x0000DCD0 File Offset: 0x0000BED0
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

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x060003C4 RID: 964 RVA: 0x0000DD2C File Offset: 0x0000BF2C
		public bool IsDataChanged
		{
			get
			{
				if (this.GetFlag(global::Infragistics.Windows.DataPresenter.Cell.InternalFlags.IsDataChanged))
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

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x060003C5 RID: 965 RVA: 0x0000DD6B File Offset: 0x0000BF6B
		// (set) Token: 0x060003C6 RID: 966 RVA: 0x0000DD78 File Offset: 0x0000BF78
		public bool? IsEnabled
		{
			get
			{
				return this.GetNullableFlag(global::Infragistics.Windows.DataPresenter.Cell.InternalFlags.IsEnabled, global::Infragistics.Windows.DataPresenter.Cell.InternalFlags.IsEnabledSet);
			}
			set
			{
				if (value != this.IsEnabled)
				{
					this.SetNullableFlag(global::Infragistics.Windows.DataPresenter.Cell.InternalFlags.IsEnabled, global::Infragistics.Windows.DataPresenter.Cell.InternalFlags.IsEnabledSet, value);
					global::Infragistics.Windows.DataPresenter.CellValuePresenter associatedCellValuePresenterInternal = this.AssociatedCellValuePresenterInternal;
					if (associatedCellValuePresenterInternal != null)
					{
						associatedCellValuePresenterInternal.CoerceValue(global::System.Windows.UIElement.IsEnabledProperty);
					}
					this.OnPropertyChanged("IsEnabled");
					this.OnPropertyChanged("IsEnabledResolved");
					this.OnPropertyChanged("IsTabStopResolved");
				}
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x060003C7 RID: 967 RVA: 0x0000DDF6 File Offset: 0x0000BFF6
		public bool IsEnabledResolved
		{
			get
			{
				return this._record.IsCellEnabled(this._field, this, false);
			}
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x060003C8 RID: 968 RVA: 0x0000DE0C File Offset: 0x0000C00C
		public bool IsInEditMode
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.CellValuePresenter associatedCellValuePresenter = this.AssociatedCellValuePresenter;
				return associatedCellValuePresenter != null && associatedCellValuePresenter.IsInEditMode;
			}
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x060003C9 RID: 969 RVA: 0x0000DE2B File Offset: 0x0000C02B
		// (set) Token: 0x060003CA RID: 970 RVA: 0x0000DE34 File Offset: 0x0000C034
		public bool IsSelected
		{
			get
			{
				return this.GetFlag(global::Infragistics.Windows.DataPresenter.Cell.InternalFlags.IsSelected);
			}
			set
			{
				if (this.IsSelected != value)
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

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x060003CB RID: 971 RVA: 0x0000DEA3 File Offset: 0x0000C0A3
		// (set) Token: 0x060003CC RID: 972 RVA: 0x0000DEB0 File Offset: 0x0000C0B0
		public bool? IsTabStop
		{
			get
			{
				return this.GetNullableFlag(global::Infragistics.Windows.DataPresenter.Cell.InternalFlags.IsTabStop, global::Infragistics.Windows.DataPresenter.Cell.InternalFlags.IsTabStopSet);
			}
			set
			{
				if (value != this.IsTabStop)
				{
					this.SetNullableFlag(global::Infragistics.Windows.DataPresenter.Cell.InternalFlags.IsTabStop, global::Infragistics.Windows.DataPresenter.Cell.InternalFlags.IsTabStopSet, value);
					this.OnPropertyChanged("IsTabStop");
					this.OnPropertyChanged("IsTabStopResolved");
				}
			}
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x060003CD RID: 973 RVA: 0x0000DF0F File Offset: 0x0000C10F
		public bool IsTabStopResolved
		{
			get
			{
				return this._record.IsCellTabStop(this._field, this);
			}
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x060003CE RID: 974 RVA: 0x0000DF23 File Offset: 0x0000C123
		public virtual bool IsUnbound
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x060003CF RID: 975 RVA: 0x0000DF26 File Offset: 0x0000C126
		public global::Infragistics.Windows.DataPresenter.DataRecord Record
		{
			get
			{
				return this._record;
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x060003D0 RID: 976 RVA: 0x0000DF2E File Offset: 0x0000C12E
		// (set) Token: 0x060003D1 RID: 977 RVA: 0x0000DF36 File Offset: 0x0000C136
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

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x060003D2 RID: 978 RVA: 0x0000DF53 File Offset: 0x0000C153
		// (set) Token: 0x060003D3 RID: 979 RVA: 0x0000DF67 File Offset: 0x0000C167
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

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x060003D4 RID: 980 RVA: 0x0000DF7D File Offset: 0x0000C17D
		// (set) Token: 0x060003D5 RID: 981 RVA: 0x0000DF86 File Offset: 0x0000C186
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

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x060003D6 RID: 982 RVA: 0x0000DFB1 File Offset: 0x0000C1B1
		internal global::Infragistics.Windows.DataPresenter.CellValuePresenter AssociatedCellValuePresenter
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.CellValuePresenter.FromCell(this);
			}
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x060003D7 RID: 983 RVA: 0x0000DFBC File Offset: 0x0000C1BC
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

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x060003D8 RID: 984 RVA: 0x0000DFEC File Offset: 0x0000C1EC
		internal global::Infragistics.Windows.DataPresenter.DataValueInfoHistory DataValueInfoHistoryCache
		{
			get
			{
				return this.GetDataValueHistoryCache(this.AssociatedCellValuePresenter);
			}
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x060003D9 RID: 985 RVA: 0x0000DFFA File Offset: 0x0000C1FA
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

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x060003DA RID: 986 RVA: 0x0000E01C File Offset: 0x0000C21C
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

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x060003DB RID: 987 RVA: 0x0000E06E File Offset: 0x0000C26E
		// (set) Token: 0x060003DC RID: 988 RVA: 0x0000E076 File Offset: 0x0000C276
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

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x060003DD RID: 989 RVA: 0x0000E07F File Offset: 0x0000C27F
		internal virtual bool HasCloneableSettings
		{
			get
			{
				return this._editAsType != null || this._editorType != null || this._editorStyle != null || this._tag != null;
			}
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x060003DE RID: 990 RVA: 0x0000E0B3 File Offset: 0x0000C2B3
		internal bool IsEditingAllowed
		{
			get
			{
				return this.Field.GetIsEditingAllowed(this._record);
			}
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x060003DF RID: 991 RVA: 0x0000E0C8 File Offset: 0x0000C2C8
		internal virtual bool IsSelectable
		{
			get
			{
				if (!this.IsEnabledResolved)
				{
					return false;
				}
				global::Infragistics.Windows.Selection.SelectionStrategyBase selectionStrategyForItem = this.Field.Owner.GetSelectionStrategyForItem(this);
				return selectionStrategyForItem != null && !(selectionStrategyForItem is global::Infragistics.Windows.Selection.SelectionStrategyNone);
			}
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x0000E0FF File Offset: 0x0000C2FF
		public bool EndEditMode()
		{
			return this.EndEditMode(true, false);
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x0000E109 File Offset: 0x0000C309
		internal bool EndEditMode(bool acceptChanges)
		{
			return this.EndEditMode(acceptChanges, false);
		}

		// Token: 0x060003E2 RID: 994 RVA: 0x0000E114 File Offset: 0x0000C314
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

		// Token: 0x060003E3 RID: 995 RVA: 0x0000E140 File Offset: 0x0000C340
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

		// Token: 0x060003E4 RID: 996 RVA: 0x0000E1B8 File Offset: 0x0000C3B8
		internal void AddDataValueChangedHistoryEntryForCurrentValue()
		{
			global::Infragistics.Windows.DataPresenter.DataValueInfoHistory dataValueInfoHistoryCache = this.DataValueInfoHistoryCache;
			if (dataValueInfoHistoryCache != null)
			{
				dataValueInfoHistoryCache.AddEntry(this.Value, global::System.DateTime.Now, null);
			}
		}

		// Token: 0x060003E5 RID: 997 RVA: 0x0000E1E1 File Offset: 0x0000C3E1
		internal void ClearAssociatedIfMatch(global::Infragistics.Windows.DataPresenter.CellValuePresenter cvp)
		{
			if (this._associatedCellValuePresenter != null && cvp == global::Infragistics.CoreUtilities.GetWeakReferenceTargetSafe(this._associatedCellValuePresenter))
			{
				this.ClearAssociatedCellValuePresenter();
			}
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x0000E200 File Offset: 0x0000C400
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

		// Token: 0x060003E7 RID: 999 RVA: 0x0000E262 File Offset: 0x0000C462
		internal virtual void CloneAssociatedCellSettings(global::Infragistics.Windows.DataPresenter.Cell associatedCell)
		{
			this._editAsType = associatedCell._editAsType;
			this._editorType = associatedCell._editorType;
			this._editorStyle = associatedCell._editorStyle;
			this._tag = associatedCell._tag;
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x0000E294 File Offset: 0x0000C494
		internal void DirtyFieldAutoSizeVersion()
		{
			this._fieldAutoSizeVersion--;
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x0000E2A4 File Offset: 0x0000C4A4
		internal void FocusIfActive()
		{
			if (this.IsActive)
			{
				global::Infragistics.Windows.DataPresenter.CellValuePresenter cellValuePresenter = global::Infragistics.Windows.DataPresenter.CellValuePresenter.FromRecordAndField(this.Record, this.Field);
				if (cellValuePresenter != null)
				{
					cellValuePresenter.FocusIfAppropriate(false);
				}
			}
		}

		// Token: 0x060003EA RID: 1002 RVA: 0x0000E2D8 File Offset: 0x0000C4D8
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

		// Token: 0x060003EB RID: 1003 RVA: 0x0000E380 File Offset: 0x0000C580
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

		// Token: 0x060003EC RID: 1004 RVA: 0x0000E436 File Offset: 0x0000C636
		internal void InternalSelect(bool value)
		{
			if (this.GetFlag(global::Infragistics.Windows.DataPresenter.Cell.InternalFlags.IsSelected) != value)
			{
				this.SetFlag(global::Infragistics.Windows.DataPresenter.Cell.InternalFlags.IsSelected, value);
				this.RaiseAutomationIsSelectedChanged();
				base.RaisePropertyChangedEvent("IsSelected");
				this.Record.OnCellSelectionChange();
			}
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x0000E468 File Offset: 0x0000C668
		internal void InternalSetDataChanged(bool value)
		{
			if (this.GetFlag(global::Infragistics.Windows.DataPresenter.Cell.InternalFlags.IsDataChanged) != value)
			{
				this.SetFlag(global::Infragistics.Windows.DataPresenter.Cell.InternalFlags.IsDataChanged, value);
				base.RaisePropertyChangedEvent("IsDataChanged");
				if (value)
				{
					this.Record.InternalSetDataChanged(true, false);
					return;
				}
				global::Infragistics.Windows.DataPresenter.CellValuePresenter associatedCellValuePresenter = this.AssociatedCellValuePresenter;
				if (associatedCellValuePresenter != null)
				{
					associatedCellValuePresenter.SetValueInternal(this.ConvertedValue, false);
				}
			}
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x0000E4BC File Offset: 0x0000C6BC
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

		// Token: 0x060003EF RID: 1007 RVA: 0x0000E535 File Offset: 0x0000C735
		internal virtual void OnActiveCellChanged()
		{
			base.RaisePropertyChangedEvent("IsActive");
			this.Record.OnActiveCellChanged();
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x0000E550 File Offset: 0x0000C750
		internal void OnEditValueChanged(global::Infragistics.Windows.DataPresenter.CellValuePresenter cellValuePresenter)
		{
			if (!this.GetFlag(global::Infragistics.Windows.DataPresenter.Cell.InternalFlags.IsDataChanged))
			{
				base.RaisePropertyChangedEvent("IsDataChanged");
				this.Record.OnEditValueChanged(true, true);
			}
			this.Record.ClearSizeToContentManager(this);
			global::Infragistics.Windows.DataPresenter.Events.CellChangedEventArgs args = new global::Infragistics.Windows.DataPresenter.Events.CellChangedEventArgs(this, cellValuePresenter.Editor);
			this.DataPresenter.RaiseCellChanged(args);
		}

		// Token: 0x060003F1 RID: 1009 RVA: 0x0000E5A4 File Offset: 0x0000C7A4
		internal void RaiseAutomationIsSelectedChanged()
		{
			global::System.Windows.Automation.Peers.AutomationPeer automationPeer = this.AutomationPeer;
			if (automationPeer != null)
			{
				automationPeer.RaisePropertyChangedEvent(global::System.Windows.Automation.SelectionItemPatternIdentifiers.IsSelectedProperty, !this.IsSelected, this.IsSelected);
			}
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x0000E5E0 File Offset: 0x0000C7E0
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

		// Token: 0x060003F3 RID: 1011 RVA: 0x0000E604 File Offset: 0x0000C804
		internal void RaiseAutomationValueChanged(object oldValue, object newValue)
		{
			global::Infragistics.Windows.Automation.Peers.DataPresenter.CellAutomationPeer cellAutomationPeer = this.AutomationPeer as global::Infragistics.Windows.Automation.Peers.DataPresenter.CellAutomationPeer;
			if (cellAutomationPeer != null)
			{
				cellAutomationPeer.RaiseValuePropertyChangedEvent(oldValue, newValue);
			}
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x0000E628 File Offset: 0x0000C828
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

		// Token: 0x060003F5 RID: 1013 RVA: 0x0000E664 File Offset: 0x0000C864
		internal void RaiseValueChangedNotifications()
		{
			if (base.HasListeners && !this.GetFlag(global::Infragistics.Windows.DataPresenter.Cell.InternalFlags.IsRaisingPropChangeNotifactions))
			{
				this.SetFlag(global::Infragistics.Windows.DataPresenter.Cell.InternalFlags.IsRaisingPropChangeNotifactions, true);
				try
				{
					base.RaisePropertyChangedEvent("Value");
					base.RaisePropertyChangedEvent("ConvertedValue");
				}
				finally
				{
					this.SetFlag(global::Infragistics.Windows.DataPresenter.Cell.InternalFlags.IsRaisingPropChangeNotifactions, false);
				}
			}
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x0000E6BC File Offset: 0x0000C8BC
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

		// Token: 0x060003F7 RID: 1015 RVA: 0x0000E737 File Offset: 0x0000C937
		private bool GetFlag(global::Infragistics.Windows.DataPresenter.Cell.InternalFlags flag)
		{
			return (this._flags & flag) == flag;
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x0000E748 File Offset: 0x0000C948
		private bool? GetNullableFlag(global::Infragistics.Windows.DataPresenter.Cell.InternalFlags flag, global::Infragistics.Windows.DataPresenter.Cell.InternalFlags isFlagSetFlag)
		{
			if (!this.GetFlag(isFlagSetFlag))
			{
				return null;
			}
			return new bool?(this.GetFlag(flag));
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x0000E774 File Offset: 0x0000C974
		private void ReInitializeCVPEditor()
		{
			global::Infragistics.Windows.DataPresenter.CellValuePresenter associatedCellValuePresenter = this.AssociatedCellValuePresenter;
			if (associatedCellValuePresenter != null)
			{
				associatedCellValuePresenter.InitializeEditor(associatedCellValuePresenter.Value);
			}
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x0000E797 File Offset: 0x0000C997
		private void SetFlag(global::Infragistics.Windows.DataPresenter.Cell.InternalFlags flag, bool value)
		{
			if (value)
			{
				this._flags |= flag;
				return;
			}
			this._flags &= ~flag;
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x0000E7BD File Offset: 0x0000C9BD
		private void SetNullableFlag(global::Infragistics.Windows.DataPresenter.Cell.InternalFlags flag, global::Infragistics.Windows.DataPresenter.Cell.InternalFlags isFlagSetFlag, bool? value)
		{
			if (value == null)
			{
				this.SetFlag(isFlagSetFlag, false);
				return;
			}
			this.SetFlag(isFlagSetFlag, true);
			this.SetFlag(flag, value.Value);
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x060003FC RID: 1020 RVA: 0x0000E7E7 File Offset: 0x0000C9E7
		bool global::Infragistics.Windows.Selection.ISelectableItem.IsDraggable
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x060003FD RID: 1021 RVA: 0x0000E7EA File Offset: 0x0000C9EA
		bool global::Infragistics.Windows.Selection.ISelectableItem.IsSelectable
		{
			get
			{
				return this.IsSelectable;
			}
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x060003FE RID: 1022 RVA: 0x0000E7F2 File Offset: 0x0000C9F2
		bool global::Infragistics.Windows.Selection.ISelectableItem.IsSelected
		{
			get
			{
				return this.IsSelected;
			}
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x060003FF RID: 1023 RVA: 0x0000E7FA File Offset: 0x0000C9FA
		bool global::Infragistics.Windows.Selection.ISelectableItem.IsTabStop
		{
			get
			{
				return this.IsTabStopResolved;
			}
		}

		// Token: 0x040000F9 RID: 249
		private global::Infragistics.Windows.DataPresenter.DataRecord _record;

		// Token: 0x040000FA RID: 250
		private global::Infragistics.Windows.DataPresenter.Field _field;

		// Token: 0x040000FB RID: 251
		private global::System.Type _editAsType;

		// Token: 0x040000FC RID: 252
		private global::System.Type _editorType;

		// Token: 0x040000FD RID: 253
		private global::System.Windows.Style _editorStyle;

		// Token: 0x040000FE RID: 254
		private global::Infragistics.Windows.DataPresenter.Cell.InternalFlags _flags;

		// Token: 0x040000FF RID: 255
		private static readonly global::System.WeakReference UninitializedCVP = new global::System.WeakReference(null);

		// Token: 0x04000100 RID: 256
		private global::System.WeakReference _associatedCellValuePresenter = global::Infragistics.Windows.DataPresenter.Cell.UninitializedCVP;

		// Token: 0x04000101 RID: 257
		private object _tag;

		// Token: 0x04000102 RID: 258
		private global::Infragistics.Windows.DataPresenter.DataValueInfoHistory _dataValueInfoHistoryCache;

		// Token: 0x04000103 RID: 259
		private int _fieldAutoSizeVersion;

		// Token: 0x0200004E RID: 78
		private enum InternalFlags : byte
		{
			// Token: 0x04000105 RID: 261
			IsDataChanged = 1,
			// Token: 0x04000106 RID: 262
			IsRaisingPropChangeNotifactions,
			// Token: 0x04000107 RID: 263
			IsSelected = 4,
			// Token: 0x04000108 RID: 264
			IsEnabled = 8,
			// Token: 0x04000109 RID: 265
			IsEnabledSet = 16,
			// Token: 0x0400010A RID: 266
			IsTabStop = 32,
			// Token: 0x0400010B RID: 267
			IsTabStopSet = 64
		}
	}
}
