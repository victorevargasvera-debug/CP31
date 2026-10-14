using System;
using System.Globalization;
using System.Windows.Data;
using Infragistics.Windows.DataPresenter.Internal;
using Infragistics.Windows.Editors;
using Infragistics.Windows.Internal;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020001DC RID: 476
	internal class CellTextConverterInfo
	{
		// Token: 0x06001B6F RID: 7023 RVA: 0x00075484 File Offset: 0x00073684
		private CellTextConverterInfo(global::Infragistics.Windows.DataPresenter.Field field)
		{
			this._field = field;
			global::Infragistics.Windows.Editors.ValueEditor valueEditor = null;
			global::Infragistics.Windows.DataPresenter.FieldLayout owner = field.Owner;
			global::Infragistics.Windows.DataPresenter.Internal.TemplateDataRecordCache templateDataRecordCache = owner.TemplateDataRecordCache;
			global::Infragistics.Windows.DataPresenter.CellValuePresenter cellValuePresenter = templateDataRecordCache.GetCellValuePresenter(field, true);
			if (cellValuePresenter != null)
			{
				valueEditor = cellValuePresenter.Editor;
			}
			if (valueEditor == null)
			{
				valueEditor = new global::Infragistics.Windows.Editors.XamTextEditor();
				valueEditor.ValueType = this._field.EditAsTypeResolved;
			}
			global::System.Windows.Data.IValueConverter converter;
			if (valueEditor is global::Infragistics.Windows.Editors.TextEditorBase)
			{
				converter = ((global::Infragistics.Windows.Editors.TextEditorBase)valueEditor).ValueToDisplayTextConverterResolved;
			}
			else
			{
				converter = valueEditor.ValueToTextConverterResolved;
			}
			this._editor = valueEditor;
			this._converter = converter;
			this._culture = field.ConverterCultureResolved;
			this._editAsType = field.EditAsTypeResolved;
			this._verifiedTemplateCacheVersion = templateDataRecordCache.CacheVersion;
		}

		// Token: 0x06001B70 RID: 7024 RVA: 0x00075530 File Offset: 0x00073730
		public static string ConvertCellValue(object value, global::Infragistics.Windows.DataPresenter.Field field)
		{
			global::Infragistics.Windows.DataPresenter.CellTextConverterInfo cachedConverter = global::Infragistics.Windows.DataPresenter.CellTextConverterInfo.GetCachedConverter(field);
			return cachedConverter.ConvertCellValue(value);
		}

		// Token: 0x06001B71 RID: 7025 RVA: 0x0007554C File Offset: 0x0007374C
		public static string ConvertCellValue(global::Infragistics.Windows.DataPresenter.DataRecord record, global::Infragistics.Windows.DataPresenter.Field field)
		{
			global::Infragistics.Windows.DataPresenter.CellTextConverterInfo cachedConverter = global::Infragistics.Windows.DataPresenter.CellTextConverterInfo.GetCachedConverter(field);
			return cachedConverter.ConvertCellValue(record);
		}

		// Token: 0x06001B72 RID: 7026 RVA: 0x00075567 File Offset: 0x00073767
		public string ConvertCellValue(global::Infragistics.Windows.DataPresenter.DataRecord record)
		{
			return this.ConvertCellValue(record.GetCellValue(this._field, global::Infragistics.Windows.DataPresenter.CellValueType.EditAsType));
		}

		// Token: 0x06001B73 RID: 7027 RVA: 0x0007557C File Offset: 0x0007377C
		public string ConvertCellValue(object cellValue)
		{
			global::System.Exception ex;
			return this.ConvertCellValue(cellValue, out ex);
		}

		// Token: 0x06001B74 RID: 7028 RVA: 0x00075594 File Offset: 0x00073794
		public string ConvertCellValue(object cellValue, out global::System.Exception error)
		{
			string text = null;
			global::Infragistics.Windows.Editors.ValueEditor editor = this._editor;
			global::Infragistics.Windows.Editors.TextEditorBase textEditorBase = editor as global::Infragistics.Windows.Editors.TextEditorBase;
			if (textEditorBase != null)
			{
				textEditorBase.ConvertValueToDisplayText(cellValue, out text, out error);
			}
			else
			{
				editor.ConvertValueToText(cellValue, out text, out error);
			}
			if (text == null)
			{
				text = string.Empty;
			}
			return text;
		}

		// Token: 0x06001B75 RID: 7029 RVA: 0x000755D8 File Offset: 0x000737D8
		internal object ConvertDisplayText(string displayText, out global::System.Exception error)
		{
			global::Infragistics.Windows.Editors.ValueEditor editor = this._editor;
			global::Infragistics.Windows.Editors.TextEditorBase textEditorBase = editor as global::Infragistics.Windows.Editors.TextEditorBase;
			object result;
			if (textEditorBase != null)
			{
				textEditorBase.ConvertDisplayTextToValue(displayText, out result, out error);
			}
			else
			{
				editor.ConvertTextToValue(displayText, out result, out error);
			}
			return result;
		}

		// Token: 0x06001B76 RID: 7030 RVA: 0x00075610 File Offset: 0x00073810
		internal static global::Infragistics.Windows.DataPresenter.CellTextConverterInfo GetCachedConverter(global::Infragistics.Windows.DataPresenter.Field field)
		{
			global::Infragistics.Windows.DataPresenter.CellTextConverterInfo cellTextConverterInfo = field._cachedCellTextConverterInfo;
			global::Infragistics.Windows.DataPresenter.FieldLayout owner = field.Owner;
			if (cellTextConverterInfo == null || (owner != null && cellTextConverterInfo._verifiedTemplateCacheVersion != owner.TemplateDataRecordCache.CacheVersion))
			{
				cellTextConverterInfo = (field._cachedCellTextConverterInfo = new global::Infragistics.Windows.DataPresenter.CellTextConverterInfo(field));
			}
			return cellTextConverterInfo;
		}

		// Token: 0x06001B77 RID: 7031 RVA: 0x00075654 File Offset: 0x00073854
		internal global::System.DateTime GetVisiblePortion(global::System.DateTime date)
		{
			if (!this.IsTimePortionVisible)
			{
				return date.Date;
			}
			if (!this._cachedIsSecondsPortionVisible.Value)
			{
				return new global::System.DateTime(date.Year, date.Month, date.Day, date.Hour, date.Minute, 0);
			}
			return new global::System.DateTime(date.Year, date.Month, date.Day, date.Hour, date.Minute, date.Second);
		}

		// Token: 0x06001B78 RID: 7032 RVA: 0x000756D7 File Offset: 0x000738D7
		internal bool ValidateValue(object newValue, out global::System.Exception error)
		{
			return this._editor.ValidateValue(newValue, out error);
		}

		// Token: 0x1700077E RID: 1918
		// (get) Token: 0x06001B79 RID: 7033 RVA: 0x000756E8 File Offset: 0x000738E8
		internal bool CompareByText
		{
			get
			{
				global::Infragistics.Windows.Editors.XamComboEditor xamComboEditor = this._editor as global::Infragistics.Windows.Editors.XamComboEditor;
				return xamComboEditor != null && null != xamComboEditor.ItemsProvider;
			}
		}

		// Token: 0x06001B7A RID: 7034 RVA: 0x00075712 File Offset: 0x00073912
		private void OnMaskedEditorSectionsChanged()
		{
			this._cachedIsTimePortionVisible = null;
		}

		// Token: 0x1700077F RID: 1919
		// (get) Token: 0x06001B7B RID: 7035 RVA: 0x00075720 File Offset: 0x00073920
		internal bool IsTimePortionVisible
		{
			get
			{
				if (this._cachedIsTimePortionVisible == null)
				{
					this._cachedIsTimePortionVisible = new bool?(true);
					this._cachedIsSecondsPortionVisible = new bool?(true);
					global::Infragistics.Windows.Editors.XamMaskedEditor xamMaskedEditor = this._editor as global::Infragistics.Windows.Editors.XamMaskedEditor;
					if (xamMaskedEditor != null)
					{
						if (this._cachedMaskedEditorSectionsTracker == null)
						{
							this._cachedMaskedEditorSectionsTracker = new global::Infragistics.Windows.Internal.PropertyValueTracker(xamMaskedEditor, "Sections.Count", new global::Infragistics.Windows.Internal.PropertyValueTracker.PropertyValueChangedHandler(this.OnMaskedEditorSectionsChanged));
						}
						global::Infragistics.Windows.Editors.SectionsCollection sections = xamMaskedEditor.Sections;
						bool value = sections != null && global::Infragistics.Windows.DataPresenter.GridUtilities.GetCount(global::Infragistics.Windows.DataPresenter.GridUtilities.Filter<global::Infragistics.Windows.Editors.SectionBase>(sections, new global::Infragistics.Windows.DataPresenter.GridUtilities.MeetsCriteria_Type(typeof(global::Infragistics.Windows.Editors.HourSection), true))) > 0;
						this._cachedIsTimePortionVisible = new bool?(value);
						this._cachedIsSecondsPortionVisible = new bool?(sections != null && global::Infragistics.Windows.DataPresenter.GridUtilities.GetCount(global::Infragistics.Windows.DataPresenter.GridUtilities.Filter<global::Infragistics.Windows.Editors.SectionBase>(sections, new global::Infragistics.Windows.DataPresenter.GridUtilities.MeetsCriteria_Type(typeof(global::Infragistics.Windows.Editors.SecondSection), true))) > 0);
					}
				}
				return this._cachedIsTimePortionVisible.Value;
			}
		}

		// Token: 0x17000780 RID: 1920
		// (get) Token: 0x06001B7C RID: 7036 RVA: 0x000757FE File Offset: 0x000739FE
		internal bool ShouldExportText
		{
			get
			{
				return this.CompareByText;
			}
		}

		// Token: 0x17000781 RID: 1921
		// (get) Token: 0x06001B7D RID: 7037 RVA: 0x00075806 File Offset: 0x00073A06
		internal global::Infragistics.Windows.DataPresenter.Field Field
		{
			get
			{
				return this._field;
			}
		}

		// Token: 0x17000782 RID: 1922
		// (get) Token: 0x06001B7E RID: 7038 RVA: 0x00075810 File Offset: 0x00073A10
		internal bool SortByText
		{
			get
			{
				global::Infragistics.Windows.Editors.XamComboEditor xamComboEditor = this._editor as global::Infragistics.Windows.Editors.XamComboEditor;
				return xamComboEditor != null && null != xamComboEditor.ItemsProvider;
			}
		}

		// Token: 0x04000B51 RID: 2897
		private global::Infragistics.Windows.DataPresenter.Field _field;

		// Token: 0x04000B52 RID: 2898
		private global::Infragistics.Windows.Editors.ValueEditor _editor;

		// Token: 0x04000B53 RID: 2899
		private global::System.Windows.Data.IValueConverter _converter;

		// Token: 0x04000B54 RID: 2900
		private global::System.Globalization.CultureInfo _culture;

		// Token: 0x04000B55 RID: 2901
		private global::System.Type _editAsType;

		// Token: 0x04000B56 RID: 2902
		private int _verifiedTemplateCacheVersion;

		// Token: 0x04000B57 RID: 2903
		private bool? _cachedIsTimePortionVisible;

		// Token: 0x04000B58 RID: 2904
		private bool? _cachedIsSecondsPortionVisible;

		// Token: 0x04000B59 RID: 2905
		private global::Infragistics.Windows.Internal.PropertyValueTracker _cachedMaskedEditorSectionsTracker;
	}
}
