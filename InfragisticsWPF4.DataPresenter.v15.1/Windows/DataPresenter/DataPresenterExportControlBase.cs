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
	// Token: 0x0200010A RID: 266
	internal abstract class DataPresenterExportControlBase : global::Infragistics.Windows.DataPresenter.DataPresenterBase
	{
		// Token: 0x0600107E RID: 4222 RVA: 0x00049995 File Offset: 0x00047B95
		internal DataPresenterExportControlBase(global::Infragistics.Windows.DataPresenter.DataPresenterBase sourceDataPresenter)
		{
			this._sourceDataPresenter = sourceDataPresenter;
		}

		// Token: 0x17000410 RID: 1040
		// (get) Token: 0x0600107F RID: 4223 RVA: 0x000499A4 File Offset: 0x00047BA4
		// (set) Token: 0x06001080 RID: 4224 RVA: 0x000499AC File Offset: 0x00047BAC
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

		// Token: 0x17000411 RID: 1041
		// (get) Token: 0x06001081 RID: 4225 RVA: 0x000499B5 File Offset: 0x00047BB5
		internal int ReportVersion
		{
			get
			{
				return this._reportVersion;
			}
		}

		// Token: 0x17000412 RID: 1042
		// (get) Token: 0x06001082 RID: 4226 RVA: 0x000499BD File Offset: 0x00047BBD
		internal global::Infragistics.Windows.DataPresenter.DataPresenterBase SourceDataPresenter
		{
			get
			{
				return this._sourceDataPresenter;
			}
		}

		// Token: 0x17000413 RID: 1043
		// (get) Token: 0x06001083 RID: 4227 RVA: 0x000499C5 File Offset: 0x00047BC5
		internal override bool IsExportControl
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000414 RID: 1044
		// (get) Token: 0x06001084 RID: 4228 RVA: 0x000499C8 File Offset: 0x00047BC8
		internal override bool IsSynchronousControl
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000415 RID: 1045
		// (get) Token: 0x06001085 RID: 4229 RVA: 0x000499CB File Offset: 0x00047BCB
		internal override bool IsTreeView
		{
			get
			{
				return this._sourceDataPresenter.IsTreeView;
			}
		}

		// Token: 0x06001086 RID: 4230 RVA: 0x000499D8 File Offset: 0x00047BD8
		protected internal override void OnInitializeRecord(global::Infragistics.Windows.DataPresenter.Events.InitializeRecordEventArgs e)
		{
			if (this._bypassInitializeRecordEvent)
			{
				return;
			}
			base.OnInitializeRecord(e);
		}

		// Token: 0x06001087 RID: 4231 RVA: 0x000499EA File Offset: 0x00047BEA
		internal override void RaiseInitializeRecord(global::Infragistics.Windows.DataPresenter.Record record, bool reInitialize, bool sortvalueChanged)
		{
			if (this._bypassInitializeRecordEvent)
			{
				return;
			}
			base.RaiseInitializeRecord(record, reInitialize, false);
		}

		// Token: 0x06001088 RID: 4232 RVA: 0x00049A00 File Offset: 0x00047C00
		internal void BindToDataSource()
		{
			bool bypassInitializeRecordEvent = this._bypassInitializeRecordEvent;
			this._bypassInitializeRecordEvent = true;
			try
			{
				base.SuppressExportingDataSourceException = true;
				base.DataSource = (this._sourceDataPresenter.DataSourceInternal as global::System.Collections.IEnumerable);
			}
			finally
			{
				this._bypassInitializeRecordEvent = bypassInitializeRecordEvent;
				base.SuppressExportingDataSourceException = false;
			}
		}

		// Token: 0x06001089 RID: 4233 RVA: 0x00049A5C File Offset: 0x00047C5C
		internal void ClearResources()
		{
			this._associatedFieldLayouts = null;
			this._associatedFields = null;
		}

		// Token: 0x0600108A RID: 4234 RVA: 0x00049A6C File Offset: 0x00047C6C
		internal static object CloneHelper(object source, bool copyNonSerializableProperties)
		{
			object obj = new global::Infragistics.Windows.DataPresenter.DataPresenterExportControlBase.ExportCloneManager().Clone(source);
			if (copyNonSerializableProperties)
			{
				global::Infragistics.Windows.DataPresenter.GridUtilities.CopyNonSerializableSettings(obj, source);
			}
			return obj;
		}

		// Token: 0x0600108B RID: 4235 RVA: 0x00049A90 File Offset: 0x00047C90
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
				fieldLayout2.OnClonedForExport(fieldLayout);
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
			base.DataItemEqualityComparer = this._sourceDataPresenter.DataItemEqualityComparer;
			this.OnCloneDataSourceRequested();
			global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout3;
			if (this._associatedFieldLayouts.TryGetValue(this._sourceDataPresenter.DefaultFieldLayout, out fieldLayout3))
			{
				fieldLayout3.IsDefault = true;
			}
			foreach (global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout4 in base.FieldLayouts)
			{
				fieldLayout4.BumpLayoutManagerVersion();
			}
			this.OnEndCloneSource(section);
			this._bypassInitializeRecordEvent = false;
		}

		// Token: 0x0600108C RID: 4236 RVA: 0x0004A070 File Offset: 0x00048270
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

		// Token: 0x0600108D RID: 4237 RVA: 0x0004A098 File Offset: 0x00048298
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

		// Token: 0x0600108E RID: 4238 RVA: 0x0004A0BF File Offset: 0x000482BF
		protected virtual void OnBeginCloneSource(global::Infragistics.Windows.Reporting.ReportSection section)
		{
			this._reportVersion++;
		}

		// Token: 0x0600108F RID: 4239 RVA: 0x0004A0CF File Offset: 0x000482CF
		protected virtual void OnCloneDataSourceRequested()
		{
		}

		// Token: 0x06001090 RID: 4240 RVA: 0x0004A0D1 File Offset: 0x000482D1
		protected virtual void OnEndCloneSource(global::Infragistics.Windows.Reporting.ReportSection section)
		{
		}

		// Token: 0x04000692 RID: 1682
		private global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.FieldLayout, global::Infragistics.Windows.DataPresenter.FieldLayout> _associatedFieldLayouts;

		// Token: 0x04000693 RID: 1683
		private bool _bypassInitializeRecordEvent;

		// Token: 0x04000694 RID: 1684
		private int _reportVersion;

		// Token: 0x04000695 RID: 1685
		private global::Infragistics.Windows.DataPresenter.DataPresenterBase _sourceDataPresenter;

		// Token: 0x04000696 RID: 1686
		private global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.Field> _associatedFields;

		// Token: 0x0200010B RID: 267
		internal class ExportCloneManager : global::Infragistics.Windows.CloneManager
		{
			// Token: 0x06001091 RID: 4241 RVA: 0x0004A0D4 File Offset: 0x000482D4
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

			// Token: 0x06001092 RID: 4242 RVA: 0x0004A11A File Offset: 0x0004831A
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
