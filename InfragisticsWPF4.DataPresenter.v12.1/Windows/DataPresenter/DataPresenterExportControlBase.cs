using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Markup.Primitives;
using Infragistics.Windows.DataPresenter.Events;
using Infragistics.Windows.Internal;
using Infragistics.Windows.Reporting;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020000EC RID: 236
	internal abstract class DataPresenterExportControlBase : global::Infragistics.Windows.DataPresenter.DataPresenterBase
	{
		// Token: 0x06000D0A RID: 3338 RVA: 0x00039031 File Offset: 0x00037231
		internal DataPresenterExportControlBase(global::Infragistics.Windows.DataPresenter.DataPresenterBase sourceDataPresenter)
		{
			this._sourceDataPresenter = sourceDataPresenter;
		}

		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x06000D0B RID: 3339 RVA: 0x00039040 File Offset: 0x00037240
		// (set) Token: 0x06000D0C RID: 3340 RVA: 0x00039048 File Offset: 0x00037248
		internal bool BypassInitializeRecordEvent
		{
			get
			{
				return this._bypassInitializeRecordEvent;
			}
			set
			{
				this._bypassInitializeRecordEvent = value;
			}
		}

		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x06000D0D RID: 3341 RVA: 0x00039051 File Offset: 0x00037251
		internal int ReportVersion
		{
			get
			{
				return this._reportVersion;
			}
		}

		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x06000D0E RID: 3342 RVA: 0x00039059 File Offset: 0x00037259
		internal global::Infragistics.Windows.DataPresenter.DataPresenterBase SourceDataPresenter
		{
			get
			{
				return this._sourceDataPresenter;
			}
		}

		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x06000D0F RID: 3343 RVA: 0x00039061 File Offset: 0x00037261
		internal override bool IsExportControl
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x06000D10 RID: 3344 RVA: 0x00039064 File Offset: 0x00037264
		internal override bool IsSynchronousControl
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000D11 RID: 3345 RVA: 0x00039067 File Offset: 0x00037267
		protected internal override void OnInitializeRecord(global::Infragistics.Windows.DataPresenter.Events.InitializeRecordEventArgs e)
		{
			if (this._bypassInitializeRecordEvent)
			{
				return;
			}
			base.OnInitializeRecord(e);
		}

		// Token: 0x06000D12 RID: 3346 RVA: 0x00039079 File Offset: 0x00037279
		internal override void RaiseInitializeRecord(global::Infragistics.Windows.DataPresenter.Record record, bool reInitialize, bool sortvalueChanged)
		{
			if (this._bypassInitializeRecordEvent)
			{
				return;
			}
			base.RaiseInitializeRecord(record, reInitialize, false);
		}

		// Token: 0x06000D13 RID: 3347 RVA: 0x00039090 File Offset: 0x00037290
		internal void BindToDataSource()
		{
			try
			{
				base.SuppressExportingDataSourceException = true;
				base.DataSource = (this._sourceDataPresenter.DataSourceInternal as global::System.Collections.IEnumerable);
			}
			finally
			{
				base.SuppressExportingDataSourceException = false;
			}
		}

		// Token: 0x06000D14 RID: 3348 RVA: 0x000390D4 File Offset: 0x000372D4
		internal void ClearResources()
		{
			this._associatedFieldLayouts = null;
			this._associatedFields = null;
		}

		// Token: 0x06000D15 RID: 3349 RVA: 0x000390E4 File Offset: 0x000372E4
		internal static object CloneHelper(object source, bool copyNonSerializableProperties)
		{
			object obj = new global::Infragistics.Windows.DataPresenter.DataPresenterExportControlBase.ExportCloneManager().Clone(source);
			if (copyNonSerializableProperties)
			{
				global::Infragistics.Windows.DataPresenter.GridUtilities.CopyNonSerializableSettings(obj, source);
			}
			return obj;
		}

		// Token: 0x06000D16 RID: 3350 RVA: 0x00039108 File Offset: 0x00037308
		internal void CloneSourceDataPresenter(global::Infragistics.Windows.Reporting.ReportSection section, global::Infragistics.Windows.DataPresenter.IExportOptions options)
		{
			this._bypassInitializeRecordEvent = true;
			this.OnBeginCloneSource(section);
			global::Infragistics.Windows.DataPresenter.IDataPresenterExporter dataPresenterExporter = null;
			global::Infragistics.Windows.DataPresenter.DataPresenterExportControl dataPresenterExportControl = this as global::Infragistics.Windows.DataPresenter.DataPresenterExportControl;
			if (dataPresenterExportControl != null)
			{
				dataPresenterExporter = dataPresenterExportControl.Exporter;
			}
			base.DataSource = null;
			base.FieldLayouts.Clear();
			base.GroupByAreaLocation = global::Infragistics.Windows.DataPresenter.GroupByAreaLocation.None;
			if (base.CellContainerGenerationMode == global::Infragistics.Windows.DataPresenter.CellContainerGenerationMode.PreLoad)
			{
				base.CellContainerGenerationMode = global::Infragistics.Windows.DataPresenter.CellContainerGenerationMode.LazyLoad;
			}
			if (this._sourceDataPresenter.ReportView != null && !string.IsNullOrEmpty(this._sourceDataPresenter.ReportView.Theme))
			{
				base.Theme = this._sourceDataPresenter.ReportView.Theme;
			}
			base.FieldLayoutSettings = null;
			if (options == null || !options.ExcludeFieldLayoutSettings)
			{
				base.FieldLayoutSettings = (global::Infragistics.Windows.DataPresenter.DataPresenterExportControlBase.CloneHelper(this._sourceDataPresenter.FieldLayoutSettings, true) as global::Infragistics.Windows.DataPresenter.FieldLayoutSettings);
				base.FieldLayoutSettings.ResetExcludedSettings(options as global::Infragistics.Windows.DataPresenter.ReportViewBase);
			}
			base.FieldLayoutSettings.AutoGenerateFields = this._sourceDataPresenter.FieldLayoutSettings.AutoGenerateFields;
			if (options != null && options.ExcludeSummaries)
			{
				base.FieldLayoutSettings.SummaryDescriptionVisibility = new global::System.Windows.Visibility?(global::System.Windows.Visibility.Collapsed);
			}
			if (dataPresenterExporter != null)
			{
				dataPresenterExporter.OnObjectCloned(this._sourceDataPresenter.FieldLayoutSettings, base.FieldLayoutSettings);
			}
			base.FieldSettings = null;
			if (options == null || !options.ExcludeFieldSettings)
			{
				base.FieldSettings = (global::Infragistics.Windows.DataPresenter.DataPresenterExportControlBase.CloneHelper(this._sourceDataPresenter.FieldSettings, true) as global::Infragistics.Windows.DataPresenter.FieldSettings);
				base.FieldSettings.ResetExcludedSettings(options);
			}
			if (dataPresenterExporter != null)
			{
				dataPresenterExporter.OnObjectCloned(this._sourceDataPresenter.FieldSettings, base.FieldSettings);
			}
			base.SortRecordsByDataType = this._sourceDataPresenter.SortRecordsByDataType;
			this._associatedFieldLayouts = new global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.FieldLayout, global::Infragistics.Windows.DataPresenter.FieldLayout>();
			this._associatedFields = new global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.Field>();
			foreach (global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout in this._sourceDataPresenter.FieldLayouts)
			{
				fieldLayout.EnsureStyleGeneratorInitialized();
				global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout2 = global::Infragistics.Windows.DataPresenter.DataPresenterExportControlBase.CloneHelper(fieldLayout, false) as global::Infragistics.Windows.DataPresenter.FieldLayout;
				base.FieldLayouts.Add(fieldLayout2);
				this._associatedFieldLayouts.Add(fieldLayout, fieldLayout2);
				if (fieldLayout.HasSettings && (options == null || !options.ExcludeFieldLayoutSettings))
				{
					global::Infragistics.Windows.DataPresenter.GridUtilities.CopyNonSerializableSettings(fieldLayout2.Settings, fieldLayout.Settings);
					fieldLayout2.Settings.ResetExcludedSettings(options as global::Infragistics.Windows.DataPresenter.ReportViewBase);
				}
				else
				{
					fieldLayout2.Settings = null;
				}
				if (dataPresenterExporter != null && fieldLayout2.HasSettings)
				{
					dataPresenterExporter.OnObjectCloned(fieldLayout.Settings, fieldLayout2.Settings);
				}
				if (fieldLayout2.HasSettings)
				{
					fieldLayout2.Settings.ClearValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.ChildRecordsDisplayOrderProperty);
				}
				if (options == null || !options.ExcludeFieldSettings)
				{
					global::Infragistics.Windows.DataPresenter.GridUtilities.CopyNonSerializableSettings(fieldLayout2.FieldSettings, fieldLayout.FieldSettings);
					fieldLayout2.FieldSettings.ResetExcludedSettings(options);
				}
				else
				{
					fieldLayout2.FieldSettings = null;
				}
				if (options != null && options.ExcludeSummaries)
				{
					fieldLayout2.Settings.SummaryDescriptionVisibility = new global::System.Windows.Visibility?(global::System.Windows.Visibility.Collapsed);
					fieldLayout2.SummaryDefinitions.Clear();
				}
				if (dataPresenterExporter != null && fieldLayout.HasFieldSettings)
				{
					dataPresenterExporter.OnObjectCloned(fieldLayout.FieldSettings, fieldLayout2.FieldSettings);
				}
				bool flag = options == null || !options.ExcludeFieldSettings;
				for (int i = 0; i < fieldLayout.Fields.Count; i++)
				{
					global::Infragistics.Windows.DataPresenter.Field field = fieldLayout.Fields[i];
					global::Infragistics.Windows.DataPresenter.Field field2 = fieldLayout2.Fields[i];
					field2.InitializeFrom(field);
					if (!flag)
					{
						if (field2.HasSettings)
						{
							field2.Settings = null;
						}
					}
					else if (field.HasSettings)
					{
						global::Infragistics.Windows.DataPresenter.GridUtilities.CopyNonSerializableSettings(field2.Settings, field.Settings);
					}
					if (flag && field2.HasSettings)
					{
						field2.Settings.ResetExcludedSettings(options);
					}
					this._associatedFields.Add(field, field2);
					if (dataPresenterExporter != null && field.HasSettings)
					{
						dataPresenterExporter.OnObjectCloned(field.Settings, field2.Settings);
					}
				}
				fieldLayout.CloneDragFieldLayoutInfo(fieldLayout2);
				if (fieldLayout.SortedFields.Count > 0)
				{
					fieldLayout2.SortedFields.BeginUpdate();
					fieldLayout2.SortedFields.Clear();
					try
					{
						foreach (global::Infragistics.Windows.DataPresenter.FieldSortDescription fieldSortDescription in fieldLayout.SortedFields)
						{
							if (fieldSortDescription.IsGroupBy)
							{
								if (options == null || !options.ExcludeGroupBySettings)
								{
									global::Infragistics.Windows.DataPresenter.FieldSortDescription fieldSortDescription2 = new global::Infragistics.Windows.DataPresenter.FieldSortDescription();
									fieldSortDescription2.Direction = fieldSortDescription.Direction;
									fieldSortDescription2.FieldName = fieldSortDescription.FieldName;
									fieldSortDescription2.IsGroupBy = fieldSortDescription.IsGroupBy;
									fieldLayout2.SortedFields.Add(fieldSortDescription2);
								}
							}
							else if (options == null || !options.ExcludeSortOrder)
							{
								global::Infragistics.Windows.DataPresenter.FieldSortDescription fieldSortDescription3 = new global::Infragistics.Windows.DataPresenter.FieldSortDescription();
								fieldSortDescription3.Direction = fieldSortDescription.Direction;
								fieldSortDescription3.FieldName = fieldSortDescription.FieldName;
								fieldSortDescription3.IsGroupBy = fieldSortDescription.IsGroupBy;
								fieldLayout2.SortedFields.Add(fieldSortDescription3);
							}
						}
					}
					finally
					{
						fieldLayout2.SortedFields.EndUpdate();
					}
				}
				if (options != null && options.ExcludeRecordFilters)
				{
					fieldLayout2.RecordFilters.Clear();
				}
			}
			base.AutoFit = this._sourceDataPresenter.AutoFit;
			this.OnCloneDataSourceRequested();
			foreach (global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout3 in base.FieldLayouts)
			{
				fieldLayout3.BumpLayoutManagerVersion();
			}
			this.OnEndCloneSource(section);
			this._bypassInitializeRecordEvent = false;
		}

		// Token: 0x06000D17 RID: 3351 RVA: 0x000396AC File Offset: 0x000378AC
		internal global::Infragistics.Windows.DataPresenter.Field GetClonedField(global::Infragistics.Windows.DataPresenter.Field uiLayout)
		{
			if (this._associatedFields == null)
			{
				return null;
			}
			global::Infragistics.Windows.DataPresenter.Field result;
			this._associatedFields.TryGetValue(uiLayout, out result);
			return result;
		}

		// Token: 0x06000D18 RID: 3352 RVA: 0x000396D4 File Offset: 0x000378D4
		internal global::Infragistics.Windows.DataPresenter.FieldLayout GetClonedFieldLayout(global::Infragistics.Windows.DataPresenter.FieldLayout uiLayout)
		{
			if (this._associatedFieldLayouts == null)
			{
				return null;
			}
			global::Infragistics.Windows.DataPresenter.FieldLayout result;
			this._associatedFieldLayouts.TryGetValue(uiLayout, out result);
			return result;
		}

		// Token: 0x06000D19 RID: 3353 RVA: 0x000396FB File Offset: 0x000378FB
		protected virtual void OnBeginCloneSource(global::Infragistics.Windows.Reporting.ReportSection section)
		{
			this._reportVersion++;
		}

		// Token: 0x06000D1A RID: 3354 RVA: 0x0003970B File Offset: 0x0003790B
		protected virtual void OnCloneDataSourceRequested()
		{
		}

		// Token: 0x06000D1B RID: 3355 RVA: 0x0003970D File Offset: 0x0003790D
		protected virtual void OnEndCloneSource(global::Infragistics.Windows.Reporting.ReportSection section)
		{
		}

		// Token: 0x040004F5 RID: 1269
		private global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.FieldLayout, global::Infragistics.Windows.DataPresenter.FieldLayout> _associatedFieldLayouts;

		// Token: 0x040004F6 RID: 1270
		private bool _bypassInitializeRecordEvent;

		// Token: 0x040004F7 RID: 1271
		private int _reportVersion;

		// Token: 0x040004F8 RID: 1272
		private global::Infragistics.Windows.DataPresenter.DataPresenterBase _sourceDataPresenter;

		// Token: 0x040004F9 RID: 1273
		private global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.Field> _associatedFields;

		// Token: 0x020000ED RID: 237
		internal class ExportCloneManager : global::Infragistics.Windows.CloneManager
		{
			// Token: 0x06000D1C RID: 3356 RVA: 0x00039710 File Offset: 0x00037910
			protected override object Clone(global::System.Windows.Markup.Primitives.MarkupObject mo, global::Infragistics.Windows.CloneInfo cloneInfo)
			{
				global::Infragistics.Windows.DataPresenter.RecordFilter recordFilter = mo.Instance as global::Infragistics.Windows.DataPresenter.RecordFilter;
				if (recordFilter != null && cloneInfo != null)
				{
					object obj;
					if (!cloneInfo.TryGetClonedObject(recordFilter, out obj))
					{
						obj = recordFilter.Clone(true, null, false);
						cloneInfo.AddClone(recordFilter, obj);
					}
					return obj;
				}
				return base.Clone(mo, cloneInfo);
			}

			// Token: 0x06000D1D RID: 3357 RVA: 0x00039756 File Offset: 0x00037956
			protected override global::Infragistics.Windows.Internal.CloneBehavior GetCloneBehavior(object source)
			{
				if (source is global::Infragistics.Windows.DataPresenter.RecordFilter)
				{
					return global::Infragistics.Windows.Internal.CloneBehavior.CloneObject;
				}
				return base.GetCloneBehavior(source);
			}
		}
	}
}
