using System;
using System.Globalization;
using System.Windows.Data;
using Infragistics.Windows.DataPresenter.Internal;
using Infragistics.Windows.Editors;
using Infragistics.Windows.Internal;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000205 RID: 517
	internal class CellTextConverterInfo
	{
		// Token: 0x06001F82 RID: 8066 RVA: 0x00089358 File Offset: 0x00087558
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
			this._format = this._editor.Format;
			this._formatProvider = this._editor.FormatProvider;
		}

		// Token: 0x06001F83 RID: 8067 RVA: 0x00089428 File Offset: 0x00087628
		public static string ConvertCellValue(object value, global::Infragistics.Windows.DataPresenter.Field field)
		{
			global::Infragistics.Windows.DataPresenter.CellTextConverterInfo cachedConverter = global::Infragistics.Windows.DataPresenter.CellTextConverterInfo.GetCachedConverter(field);
			return cachedConverter.ConvertCellValue(value);
		}

		// Token: 0x06001F84 RID: 8068 RVA: 0x00089444 File Offset: 0x00087644
		public static string ConvertCellValue(global::Infragistics.Windows.DataPresenter.DataRecord record, global::Infragistics.Windows.DataPresenter.Field field)
		{
			global::Infragistics.Windows.DataPresenter.CellTextConverterInfo cachedConverter = global::Infragistics.Windows.DataPresenter.CellTextConverterInfo.GetCachedConverter(field);
			return cachedConverter.ConvertCellValue(record);
		}

		// Token: 0x06001F85 RID: 8069 RVA: 0x0008945F File Offset: 0x0008765F
		public string ConvertCellValue(global::Infragistics.Windows.DataPresenter.DataRecord record)
		{
			return this.ConvertCellValue(record.GetCellValue(this._field, global::Infragistics.Windows.DataPresenter.CellValueType.EditAsType));
		}

		// Token: 0x06001F86 RID: 8070 RVA: 0x00089474 File Offset: 0x00087674
		public string ConvertCellValue(object cellValue)
		{
			global::System.Exception ex;
			return this.ConvertCellValue(cellValue, out ex);
		}

		// Token: 0x06001F87 RID: 8071 RVA: 0x0008948C File Offset: 0x0008768C
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

		// Token: 0x06001F88 RID: 8072 RVA: 0x000894D0 File Offset: 0x000876D0
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

		// Token: 0x06001F89 RID: 8073 RVA: 0x00089508 File Offset: 0x00087708
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

		// Token: 0x06001F8A RID: 8074 RVA: 0x0008954C File Offset: 0x0008774C
		internal global::System.DateTime GetVisiblePortion(global::System.DateTime date)
		{
			if (!this.IsTimePortionVisible)
			{
				return date.Date;
			}
			if (this._cachedIsMillisecondsPortionVisible != null && this._cachedIsMillisecondsPortionVisible.Value)
			{
				return date;
			}
			if (!this._cachedIsSecondsPortionVisible.Value)
			{
				return new global::System.DateTime(date.Year, date.Month, date.Day, date.Hour, date.Minute, 0);
			}
			return new global::System.DateTime(date.Year, date.Month, date.Day, date.Hour, date.Minute, date.Second);
		}

		// Token: 0x06001F8B RID: 8075 RVA: 0x000895EB File Offset: 0x000877EB
		internal bool ValidateValue(object newValue, out global::System.Exception error)
		{
			return this._editor.ValidateValue(newValue, out error);
		}

		// Token: 0x17000906 RID: 2310
		// (get) Token: 0x06001F8C RID: 8076 RVA: 0x000895FC File Offset: 0x000877FC
		internal bool CompareByText
		{
			get
			{
				global::Infragistics.Windows.Editors.XamComboEditor xamComboEditor = this._editor as global::Infragistics.Windows.Editors.XamComboEditor;
				return xamComboEditor != null && null != xamComboEditor.ItemsProvider;
			}
		}

		// Token: 0x17000907 RID: 2311
		// (get) Token: 0x06001F8D RID: 8077 RVA: 0x00089626 File Offset: 0x00087826
		internal global::Infragistics.Windows.Editors.ValueEditor Editor
		{
			get
			{
				return this._editor;
			}
		}

		// Token: 0x17000908 RID: 2312
		// (get) Token: 0x06001F8E RID: 8078 RVA: 0x0008962E File Offset: 0x0008782E
		internal string Format
		{
			get
			{
				return this._format;
			}
		}

		// Token: 0x17000909 RID: 2313
		// (get) Token: 0x06001F8F RID: 8079 RVA: 0x00089636 File Offset: 0x00087836
		internal global::System.IFormatProvider FormatProvider
		{
			get
			{
				return this._formatProvider;
			}
		}

		// Token: 0x06001F90 RID: 8080 RVA: 0x0008963E File Offset: 0x0008783E
		private void OnMaskedEditorSectionsChanged()
		{
			this._cachedIsTimePortionVisible = null;
		}

		// Token: 0x1700090A RID: 2314
		// (get) Token: 0x06001F91 RID: 8081 RVA: 0x0008964C File Offset: 0x0008784C
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
						this._cachedIsMillisecondsPortionVisible = new bool?(false);
					}
					else
					{
						this._cachedIsMillisecondsPortionVisible = new bool?(true);
					}
				}
				return this._cachedIsTimePortionVisible.Value;
			}
		}

		// Token: 0x1700090B RID: 2315
		// (get) Token: 0x06001F92 RID: 8082 RVA: 0x00089744 File Offset: 0x00087944
		internal bool ShouldExportText
		{
			get
			{
				return this.CompareByText;
			}
		}

		// Token: 0x1700090C RID: 2316
		// (get) Token: 0x06001F93 RID: 8083 RVA: 0x0008974C File Offset: 0x0008794C
		internal global::Infragistics.Windows.DataPresenter.Field Field
		{
			get
			{
				return this._field;
			}
		}

		// Token: 0x1700090D RID: 2317
		// (get) Token: 0x06001F94 RID: 8084 RVA: 0x00089754 File Offset: 0x00087954
		internal bool SortByText
		{
			get
			{
				global::Infragistics.Windows.Editors.XamComboEditor xamComboEditor = this._editor as global::Infragistics.Windows.Editors.XamComboEditor;
				return xamComboEditor != null && null != xamComboEditor.ItemsProvider;
			}
		}

		// Token: 0x1700090E RID: 2318
		// (get) Token: 0x06001F95 RID: 8085 RVA: 0x0008977E File Offset: 0x0008797E
		internal global::System.Type ValueType
		{
			get
			{
				if (this._editor == null)
				{
					return typeof(object);
				}
				return this._editor.ValueType;
			}
		}

		// Token: 0x04000D3F RID: 3391
		private global::Infragistics.Windows.DataPresenter.Field _field;

		// Token: 0x04000D40 RID: 3392
		private global::Infragistics.Windows.Editors.ValueEditor _editor;

		// Token: 0x04000D41 RID: 3393
		private global::System.Windows.Data.IValueConverter _converter;

		// Token: 0x04000D42 RID: 3394
		private global::System.Globalization.CultureInfo _culture;

		// Token: 0x04000D43 RID: 3395
		private global::System.Type _editAsType;

		// Token: 0x04000D44 RID: 3396
		private int _verifiedTemplateCacheVersion;

		// Token: 0x04000D45 RID: 3397
		private bool? _cachedIsTimePortionVisible;

		// Token: 0x04000D46 RID: 3398
		private bool? _cachedIsSecondsPortionVisible;

		// Token: 0x04000D47 RID: 3399
		private bool? _cachedIsMillisecondsPortionVisible;

		// Token: 0x04000D48 RID: 3400
		private global::Infragistics.Windows.Internal.PropertyValueTracker _cachedMaskedEditorSectionsTracker;

		// Token: 0x04000D49 RID: 3401
		private string _format;

		// Token: 0x04000D4A RID: 3402
		private global::System.IFormatProvider _formatProvider;
	}
}
