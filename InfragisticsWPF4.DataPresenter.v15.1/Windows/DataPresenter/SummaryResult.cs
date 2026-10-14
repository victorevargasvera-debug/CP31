using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Windows;
using Infragistics.Collections;
using Infragistics.Windows.DataPresenter.Events;
using Infragistics.Windows.Internal;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020001D9 RID: 473
	public class SummaryResult : global::Infragistics.PropertyChangeNotifier
	{
		// Token: 0x06001C50 RID: 7248 RVA: 0x0007FAB4 File Offset: 0x0007DCB4
		internal SummaryResult(global::Infragistics.Windows.DataPresenter.SummaryResultCollection parentCollection, global::Infragistics.Windows.DataPresenter.SummaryDefinition summaryDefinition)
		{
			global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNotNull(parentCollection);
			global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNotNull(summaryDefinition);
			this._parentCollection = parentCollection;
			this._summaryDefinition = summaryDefinition;
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = global::Infragistics.Windows.DataPresenter.GridUtilities.GetDataPresenter(parentCollection.Records);
			this._isAsyncOperationSupported = (dataPresenter != null && !dataPresenter.IsReportControl && !dataPresenter.IsExportControl);
		}

		// Token: 0x06001C51 RID: 7249 RVA: 0x0007FB18 File Offset: 0x0007DD18
		protected override void OnHasListenersChanged()
		{
			base.OnHasListenersChanged();
			this.VerifyHasAnyListeners();
		}

		// Token: 0x170007F2 RID: 2034
		// (get) Token: 0x06001C52 RID: 7250 RVA: 0x0007FB28 File Offset: 0x0007DD28
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.DataPresenter.SummaryDisplayAreas DisplayAreaResolved
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = this.FieldLayout;
				global::Infragistics.Windows.DataPresenter.SummaryDefinition summaryDefinition = this.SummaryDefinition;
				global::Infragistics.Windows.DataPresenter.Field positionFieldResolved = this.PositionFieldResolved;
				if (global::Infragistics.Windows.DataPresenter.SummaryPosition.UseSummaryPositionField == this.PositionResolved && (positionFieldResolved == null || global::System.Windows.Visibility.Collapsed == positionFieldResolved.VisibilityResolved))
				{
					return global::Infragistics.Windows.DataPresenter.SummaryDisplayAreas.None;
				}
				if (!summaryDefinition.IsVisible)
				{
					return global::Infragistics.Windows.DataPresenter.SummaryDisplayAreas.None;
				}
				global::Infragistics.Windows.DataPresenter.SummaryDisplayAreas? summaryDisplayAreas = summaryDefinition.DisplayArea;
				if (summaryDisplayAreas != null)
				{
					return summaryDisplayAreas.Value;
				}
				global::Infragistics.Windows.DataPresenter.FieldSettings fieldSettings = (positionFieldResolved != null) ? positionFieldResolved.SettingsIfAllocated : null;
				if (fieldSettings != null)
				{
					summaryDisplayAreas = fieldSettings.SummaryDisplayArea;
					if (summaryDisplayAreas != null)
					{
						return summaryDisplayAreas.Value;
					}
				}
				fieldSettings = ((fieldLayout != null) ? fieldLayout.FieldSettingsIfAllocated : null);
				if (fieldSettings != null)
				{
					summaryDisplayAreas = fieldSettings.SummaryDisplayArea;
					if (summaryDisplayAreas != null)
					{
						return summaryDisplayAreas.Value;
					}
				}
				global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenterBase = (fieldLayout != null) ? fieldLayout.DataPresenter : null;
				fieldSettings = ((dataPresenterBase != null) ? dataPresenterBase.FieldSettingsIfAllocated : null);
				if (fieldSettings != null)
				{
					summaryDisplayAreas = fieldSettings.SummaryDisplayArea;
					if (summaryDisplayAreas != null)
					{
						return summaryDisplayAreas.Value;
					}
				}
				return global::Infragistics.Windows.DataPresenter.SummaryDisplayAreas.Bottom | global::Infragistics.Windows.DataPresenter.SummaryDisplayAreas.TopLevelOnly | global::Infragistics.Windows.DataPresenter.SummaryDisplayAreas.InGroupByRecords;
			}
		}

		// Token: 0x170007F3 RID: 2035
		// (get) Token: 0x06001C53 RID: 7251 RVA: 0x0007FC16 File Offset: 0x0007DE16
		public string DisplayText
		{
			get
			{
				this.EnsureCalculated();
				return this._cachedDisplayText ?? string.Empty;
			}
		}

		// Token: 0x170007F4 RID: 2036
		// (get) Token: 0x06001C54 RID: 7252 RVA: 0x0007FC2D File Offset: 0x0007DE2D
		public string DisplayTextAsync
		{
			get
			{
				if (!this._isAsyncOperationSupported)
				{
					this.EnsureCalculated();
				}
				return this._cachedDisplayText ?? string.Empty;
			}
		}

		// Token: 0x170007F5 RID: 2037
		// (get) Token: 0x06001C55 RID: 7253 RVA: 0x0007FC4C File Offset: 0x0007DE4C
		public global::Infragistics.Windows.DataPresenter.SummaryResultCollection ParentCollection
		{
			get
			{
				return this._parentCollection;
			}
		}

		// Token: 0x170007F6 RID: 2038
		// (get) Token: 0x06001C56 RID: 7254 RVA: 0x0007FC54 File Offset: 0x0007DE54
		public global::Infragistics.Windows.DataPresenter.Field PositionFieldResolved
		{
			get
			{
				this.VerifyFields();
				return this._cachedPositionFieldResolved;
			}
		}

		// Token: 0x170007F7 RID: 2039
		// (get) Token: 0x06001C57 RID: 7255 RVA: 0x0007FC62 File Offset: 0x0007DE62
		public global::Infragistics.Windows.DataPresenter.Field SourceField
		{
			get
			{
				this.VerifyFields();
				return this._cachedSourceField;
			}
		}

		// Token: 0x170007F8 RID: 2040
		// (get) Token: 0x06001C58 RID: 7256 RVA: 0x0007FC70 File Offset: 0x0007DE70
		public global::Infragistics.Windows.DataPresenter.SummaryDefinition SummaryDefinition
		{
			get
			{
				return this._summaryDefinition;
			}
		}

		// Token: 0x170007F9 RID: 2041
		// (get) Token: 0x06001C59 RID: 7257 RVA: 0x0007FC78 File Offset: 0x0007DE78
		// (set) Token: 0x06001C5A RID: 7258 RVA: 0x0007FC80 File Offset: 0x0007DE80
		[global::System.ComponentModel.Bindable(true)]
		public object ToolTip
		{
			get
			{
				return this._tooltip;
			}
			set
			{
				if (value != this._tooltip)
				{
					this._tooltip = value;
					base.RaisePropertyChangedEvent("ToolTip");
					base.RaisePropertyChangedEvent("ToolTipResolved");
				}
			}
		}

		// Token: 0x170007FA RID: 2042
		// (get) Token: 0x06001C5B RID: 7259 RVA: 0x0007FCA8 File Offset: 0x0007DEA8
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.Bindable(true)]
		public object ToolTipResolved
		{
			get
			{
				return this.GetToolTipResolved(true);
			}
		}

		// Token: 0x170007FB RID: 2043
		// (get) Token: 0x06001C5C RID: 7260 RVA: 0x0007FCB1 File Offset: 0x0007DEB1
		public object Value
		{
			get
			{
				this.EnsureCalculated();
				return this._calculatedValue;
			}
		}

		// Token: 0x170007FC RID: 2044
		// (get) Token: 0x06001C5D RID: 7261 RVA: 0x0007FCBF File Offset: 0x0007DEBF
		public object ValueAsync
		{
			get
			{
				if (!this._isAsyncOperationSupported)
				{
					this.EnsureCalculated();
				}
				return this._calculatedValue;
			}
		}

		// Token: 0x170007FD RID: 2045
		// (get) Token: 0x06001C5E RID: 7262 RVA: 0x0007FCD5 File Offset: 0x0007DED5
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.ComponentModel.Browsable(false)]
		public int DataVersion
		{
			get
			{
				return this._dataVersion + this.SummaryDefinition.CalculationVersion;
			}
		}

		// Token: 0x170007FE RID: 2046
		// (get) Token: 0x06001C5F RID: 7263 RVA: 0x0007FCE9 File Offset: 0x0007DEE9
		// (set) Token: 0x06001C60 RID: 7264 RVA: 0x0007FCF1 File Offset: 0x0007DEF1
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

		// Token: 0x170007FF RID: 2047
		// (get) Token: 0x06001C61 RID: 7265 RVA: 0x0007FCFA File Offset: 0x0007DEFA
		internal global::Infragistics.Windows.DataPresenter.FieldLayout FieldLayout
		{
			get
			{
				return this._parentCollection.Records.FieldLayout;
			}
		}

		// Token: 0x06001C62 RID: 7266 RVA: 0x0007FD0C File Offset: 0x0007DF0C
		internal bool IsDirty(bool cleanPendingDirtyAffectedSummaries)
		{
			if (cleanPendingDirtyAffectedSummaries && this._parentCollection != null)
			{
				this._parentCollection.CleanPendingDirtyAffectedSummaries();
			}
			return this._verifiedDataVersion != this.DataVersion;
		}

		// Token: 0x17000800 RID: 2048
		// (get) Token: 0x06001C63 RID: 7267 RVA: 0x0007FD38 File Offset: 0x0007DF38
		internal global::Infragistics.Windows.DataPresenter.SummaryPosition PositionResolved
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.SummaryPosition summaryPosition = this._summaryDefinition.Position;
				if (summaryPosition == global::Infragistics.Windows.DataPresenter.SummaryPosition.Default)
				{
					summaryPosition = global::Infragistics.Windows.DataPresenter.SummaryPosition.UseSummaryPositionField;
				}
				return summaryPosition;
			}
		}

		// Token: 0x17000801 RID: 2049
		// (get) Token: 0x06001C64 RID: 7268 RVA: 0x0007FD58 File Offset: 0x0007DF58
		internal global::System.IFormatProvider StringFormatProviderResolved
		{
			get
			{
				global::System.IFormatProvider formatProvider = this._summaryDefinition.StringFormatProvider;
				if (formatProvider == null)
				{
					formatProvider = global::Infragistics.Windows.DataPresenter.GridUtilities.GetDefaultCulture(this.SourceField, this.FieldLayout);
				}
				return formatProvider;
			}
		}

		// Token: 0x06001C65 RID: 7269 RVA: 0x0007FD87 File Offset: 0x0007DF87
		public void Refresh()
		{
			this._verifiedDataVersion--;
			this._verifiedFieldsVersion--;
			this.ResultChanged_RaisePropChangeNotifications();
		}

		// Token: 0x06001C66 RID: 7270 RVA: 0x0007FDAB File Offset: 0x0007DFAB
		internal void DirtyCalculation()
		{
			if (!this.IsDirty(false))
			{
				this._dataVersion++;
				base.RaisePropertyChangedEvent("DataVersion");
			}
		}

		// Token: 0x06001C67 RID: 7271 RVA: 0x0007FDD0 File Offset: 0x0007DFD0
		internal void EnsureCalculated()
		{
			if (this.SkipEnsureCalculated)
			{
				return;
			}
			if (!this.IsDirty(true))
			{
				return;
			}
			global::Infragistics.Windows.DataPresenter.SummaryCalculator calculator = this._summaryDefinition.Calculator;
			global::Infragistics.Windows.DataPresenter.Field sourceField = this.SourceField;
			this._verifiedDataVersion = this.DataVersion;
			if (calculator != null && sourceField != null)
			{
				global::Infragistics.Windows.DataPresenter.RecordCollectionBase records = this._parentCollection.Records;
				global::Infragistics.Windows.DataPresenter.Record parentRecord = records.ParentRecord;
				if (parentRecord != null && !parentRecord.IsStillValid)
				{
					return;
				}
				global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = records.FieldLayout;
				global::Infragistics.Windows.DataPresenter.CalculationScope calculationScopeResolved = fieldLayout.CalculationScopeResolved;
				bool visibleRecordsOnly = global::Infragistics.Windows.DataPresenter.CalculationScope.FilteredSortedList == calculationScopeResolved;
				object newCalculatedValue;
				if (global::Infragistics.Windows.DataPresenter.GridUtilities.IsTemplateRecords(records))
				{
					newCalculatedValue = null;
				}
				else
				{
					bool flag = true;
					newCalculatedValue = null;
					global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = fieldLayout.DataPresenter;
					if (dataPresenter != null)
					{
						global::Infragistics.Windows.DataPresenter.SummaryEvaluationMode summaryEvaluationModeResolved = fieldLayout.SummaryEvaluationModeResolved;
						flag = (global::Infragistics.Windows.DataPresenter.SummaryEvaluationMode.Manual != summaryEvaluationModeResolved);
						global::Infragistics.Windows.DataPresenter.Events.QuerySummaryResultEventArgs querySummaryResultEventArgs = new global::Infragistics.Windows.DataPresenter.Events.QuerySummaryResultEventArgs(this);
						dataPresenter.RaiseQuerySummaryResult(querySummaryResultEventArgs);
						if (querySummaryResultEventArgs.ProvidedValue != null)
						{
							newCalculatedValue = querySummaryResultEventArgs.ProvidedValue;
							flag = false;
						}
					}
					if (flag)
					{
						global::Infragistics.Windows.DataPresenter.SummaryEvaluationMode summaryEvaluationModeResolved2 = fieldLayout.SummaryEvaluationModeResolved;
						if (global::Infragistics.Windows.DataPresenter.SummaryEvaluationMode.UseLinq == summaryEvaluationModeResolved2 && sourceField.BindingType == global::Infragistics.Windows.DataPresenter.BindingType.UseNameBinding && !(records.ParentRecord is global::Infragistics.Windows.DataPresenter.GroupByRecord))
						{
							string text = null;
							if (typeof(global::Infragistics.Windows.DataPresenter.AverageSummaryCalculator) == calculator.GetType())
							{
								text = "Average";
							}
							else if (typeof(global::Infragistics.Windows.DataPresenter.SumSummaryCalculator) == calculator.GetType())
							{
								text = "Sum";
							}
							else if (typeof(global::Infragistics.Windows.DataPresenter.CountSummaryCalculator) == calculator.GetType())
							{
								text = "Count";
							}
							else if (typeof(global::Infragistics.Windows.DataPresenter.MinimumSummaryCalculator) == calculator.GetType())
							{
								text = "Min";
							}
							else if (typeof(global::Infragistics.Windows.DataPresenter.MaximumSummaryCalculator) == calculator.GetType())
							{
								text = "Max";
							}
							if (text != null)
							{
								global::Infragistics.Windows.DataPresenter.RecordManager parentRecordManager = records.ParentRecordManager;
								global::Infragistics.Windows.DataPresenter.LinqQueryManager linqQueryManager = global::Infragistics.Windows.DataPresenter.VUtils.CreateLinqQueryManager(parentRecordManager, global::Infragistics.Windows.DataPresenter.CalculationScope.FilteredSortedList != calculationScopeResolved);
								if (linqQueryManager != null)
								{
									global::Infragistics.Windows.DataPresenter.LinqQueryManager.LinqInstructionSummary linqStatement = new global::Infragistics.Windows.DataPresenter.LinqQueryManager.LinqInstructionSummary(text, global::Infragistics.Windows.DataPresenter.VUtils.GetPropertyName(sourceField), null);
									object obj = null;
									try
									{
										obj = linqQueryManager.PerformQuery(linqStatement);
									}
									catch
									{
										if ("Average" == text)
										{
											obj = 0m;
										}
									}
									newCalculatedValue = obj;
									flag = false;
								}
							}
						}
						if (global::Infragistics.Windows.DataPresenter.SummaryEvaluationMode.Manual == summaryEvaluationModeResolved2)
						{
							return;
						}
					}
					if (flag)
					{
						bool isTreeView = sourceField.Owner.IsTreeView;
						global::Infragistics.Windows.DataPresenter.Field field = sourceField;
						if (isTreeView && !sourceField.Owner.IsDefault)
						{
							field = sourceField.MappedTreeField;
							if (field == null)
							{
								return;
							}
						}
						bool flag2 = global::Infragistics.Windows.DataPresenter.CalculationScope.FullUnsortedList == calculationScopeResolved && calculator.IsCalculationAffectedBySort;
						global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.DataRecord> enumerable = new global::Infragistics.Collections.TypedEnumerable<global::Infragistics.Windows.DataPresenter.DataRecord>(records.GetRecordEnumerator(global::Infragistics.Windows.DataPresenter.RecordType.DataRecord, isTreeView ? null : sourceField.Owner, sourceField.Owner, visibleRecordsOnly));
						if (flag2)
						{
							global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.DataRecord> list = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.DataRecord>(enumerable);
							list.Sort(new global::Infragistics.Windows.DataPresenter.SummaryResult.SortComparer_UnsortedIndex());
							enumerable = list;
						}
						calculator.BeginCalculation(this);
						foreach (global::Infragistics.Windows.DataPresenter.DataRecord dataRecord in enumerable)
						{
							global::Infragistics.Windows.DataPresenter.Field field2 = field;
							if (isTreeView && field2.Owner != dataRecord.FieldLayout)
							{
								if (field2.IsPlaceholderForTreeView)
								{
									continue;
								}
								field2 = dataRecord.FieldLayout.GetFieldFromMappedField(field);
							}
							object cellValue = dataRecord.GetCellValue(field2, global::Infragistics.Windows.DataPresenter.CellValueType.EditAsType);
							calculator.Aggregate(cellValue, this, dataRecord);
						}
						newCalculatedValue = calculator.EndCalculation(this);
					}
				}
				this.InternalSetNewValue(newCalculatedValue);
			}
		}

		// Token: 0x06001C68 RID: 7272 RVA: 0x0008011C File Offset: 0x0007E31C
		private string GetDisplayTextHelper()
		{
			object value = this.Value;
			global::Infragistics.Windows.DataPresenter.SummaryDefinition summaryDefinition = this.SummaryDefinition;
			global::Infragistics.Windows.DataPresenter.SummaryCalculator calculator = summaryDefinition.Calculator;
			global::Infragistics.Windows.DataPresenter.Field sourceField = this.SourceField;
			if (sourceField != null && calculator != null)
			{
				global::System.IFormatProvider stringFormatProviderResolved = this.StringFormatProviderResolved;
				string text = summaryDefinition.StringFormat;
				if (string.IsNullOrEmpty(text))
				{
					text = sourceField.GetSummaryStringFormat(calculator.Name);
				}
				if (text != null)
				{
					try
					{
						return string.Format(stringFormatProviderResolved, text, new object[]
						{
							value,
							calculator.DisplayName,
							summaryDefinition.Key,
							summaryDefinition.SourceFieldName
						});
					}
					catch (global::System.FormatException)
					{
						if (global::System.Diagnostics.Debugger.IsAttached && global::System.Diagnostics.Debugger.IsLogging())
						{
							global::Infragistics.Windows.DataPresenter.GridUtilities.LogDebuggerError(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("FormatException_1", new object[]
							{
								text,
								value
							}));
						}
					}
				}
				return calculator.ApplyDefaultFormat(value, this);
			}
			if (value != null)
			{
				string text2 = summaryDefinition.StringFormat;
				if (string.IsNullOrEmpty(text2))
				{
					if (string.IsNullOrEmpty(summaryDefinition.Key))
					{
						text2 = "{0}";
					}
					else
					{
						text2 = "{1} = {0}";
					}
				}
				return string.Format(this.StringFormatProviderResolved, text2, new object[]
				{
					value,
					summaryDefinition.Key
				});
			}
			return null;
		}

		// Token: 0x06001C69 RID: 7273 RVA: 0x00080274 File Offset: 0x0007E474
		internal global::Infragistics.Windows.DataPresenter.Field GetPositionFieldResolvedForExport()
		{
			global::Infragistics.Windows.DataPresenter.Field positionFieldResolved = this.PositionFieldResolved;
			if (positionFieldResolved != null)
			{
				return positionFieldResolved;
			}
			global::Infragistics.Windows.DataPresenter.FieldCollection fields = global::Infragistics.Windows.DataPresenter.GridUtilities.GetFields(this.FieldLayout);
			if (fields == null)
			{
				return null;
			}
			global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field> list = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field>(from f in fields
			where f.Visibility != global::System.Windows.Visibility.Collapsed
			select f);
			if (list.Count == 0)
			{
				return null;
			}
			int num = int.MaxValue;
			global::Infragistics.Windows.DataPresenter.Field result = null;
			int num2 = int.MinValue;
			global::Infragistics.Windows.DataPresenter.Field result2 = null;
			foreach (global::Infragistics.Windows.DataPresenter.Field field in list)
			{
				int column = field.ActualPosition.Column;
				int num3 = column + field.ActualPosition.ColumnSpan;
				if (column < num)
				{
					num = column;
					result = field;
				}
				if (num2 < num3)
				{
					num2 = num3;
					result2 = field;
				}
			}
			switch (this.SummaryDefinition.Position)
			{
			case global::Infragistics.Windows.DataPresenter.SummaryPosition.Center:
			{
				int num4 = (num + num2) / 2;
				using (global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field>.Enumerator enumerator2 = list.GetEnumerator())
				{
					while (enumerator2.MoveNext())
					{
						global::Infragistics.Windows.DataPresenter.Field field2 = enumerator2.Current;
						int column2 = field2.ActualPosition.Column;
						int num5 = column2 + field2.ActualPosition.ColumnSpan;
						if (column2 <= num4 && num4 < num5)
						{
							return field2;
						}
					}
					break;
				}
				return result2;
			}
			case global::Infragistics.Windows.DataPresenter.SummaryPosition.Right:
				return result2;
			}
			return result;
		}

		// Token: 0x06001C6A RID: 7274 RVA: 0x0008040C File Offset: 0x0007E60C
		private object GetToolTipResolved(bool async)
		{
			object obj = this._tooltip;
			if (obj != null)
			{
				return obj;
			}
			obj = this.SummaryDefinition.ToolTip;
			if (obj != null)
			{
				return obj;
			}
			string text = async ? this.DisplayTextAsync : this.DisplayText;
			global::Infragistics.Windows.DataPresenter.Field sourceField = this.SourceField;
			if (sourceField != null)
			{
				string str = sourceField.Name;
				string text2 = sourceField.Label as string;
				if (!string.IsNullOrEmpty(text2))
				{
					str = text2;
				}
				return str + ": " + text;
			}
			return text;
		}

		// Token: 0x06001C6B RID: 7275 RVA: 0x00080484 File Offset: 0x0007E684
		internal void InternalSetNewValue(object newCalculatedValue)
		{
			bool flag = !object.Equals(this._calculatedValue, newCalculatedValue);
			this._calculatedValue = newCalculatedValue;
			string displayTextHelper = this.GetDisplayTextHelper();
			global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = this.FieldLayout;
			if (flag || this._cachedDisplayText != displayTextHelper)
			{
				this._cachedDisplayText = displayTextHelper;
				this.ResultChanged_RaisePropChangeNotifications();
				fieldLayout.AutoSizeInfo.OnSummaryChanged(this._parentCollection.Records, this);
			}
			if (flag)
			{
				global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = fieldLayout.DataPresenter;
				if (dataPresenter != null)
				{
					dataPresenter.RaiseSummaryResultChanged(new global::Infragistics.Windows.DataPresenter.Events.SummaryResultChangedEventArgs(this));
				}
			}
		}

		// Token: 0x06001C6C RID: 7276 RVA: 0x00080504 File Offset: 0x0007E704
		private void OnSummaryDefCalcVersionChanged()
		{
			base.RaisePropertyChangedEvent("DataVersion");
		}

		// Token: 0x06001C6D RID: 7277 RVA: 0x00080511 File Offset: 0x0007E711
		private void ResultChanged_RaisePropChangeNotifications()
		{
			base.RaisePropertyChangedEvent("Value");
			base.RaisePropertyChangedEvent("DisplayText");
			base.RaisePropertyChangedEvent("ToolTipResolved");
			base.RaisePropertyChangedEvent("ValueAsync");
			base.RaisePropertyChangedEvent("DisplayTextAsync");
		}

		// Token: 0x06001C6E RID: 7278 RVA: 0x0008054C File Offset: 0x0007E74C
		private void VerifyFields()
		{
			global::Infragistics.Windows.DataPresenter.SummaryDefinition summaryDefinition = this.SummaryDefinition;
			global::Infragistics.Windows.DataPresenter.SummaryDefinitionCollection parentCollection = summaryDefinition.ParentCollection;
			int num = (parentCollection != null) ? parentCollection.SummariesVersion : 0;
			global::Infragistics.Windows.DataPresenter.FieldCollection fields = global::Infragistics.Windows.DataPresenter.GridUtilities.GetFields(this.FieldLayout);
			if (fields != null)
			{
				num += fields.Version;
			}
			if (this._verifiedFieldsVersion != num)
			{
				global::Infragistics.Windows.DataPresenter.Field cachedSourceField = this._cachedSourceField;
				global::Infragistics.Windows.DataPresenter.Field cachedPositionFieldResolved = this._cachedPositionFieldResolved;
				this._cachedSourceField = global::Infragistics.Windows.DataPresenter.GridUtilities.GetField(fields, summaryDefinition.SourceFieldName, false);
				string positionFieldName = summaryDefinition.PositionFieldName;
				if (!string.IsNullOrEmpty(positionFieldName))
				{
					this._cachedPositionFieldResolved = global::Infragistics.Windows.DataPresenter.GridUtilities.GetField(fields, summaryDefinition.PositionFieldName, false);
				}
				else
				{
					this._cachedPositionFieldResolved = this._cachedSourceField;
				}
				this._verifiedFieldsVersion = num;
				if (cachedSourceField != this._cachedSourceField)
				{
					this._verifiedDataVersion--;
					if (this._parentCollection != null)
					{
						this._parentCollection.DirtySourceFieldMapCache();
					}
					base.RaisePropertyChangedEvent("SourceField");
				}
				if (cachedPositionFieldResolved != this._cachedPositionFieldResolved)
				{
					base.RaisePropertyChangedEvent("PositionFieldResolved");
				}
			}
		}

		// Token: 0x06001C6F RID: 7279 RVA: 0x00080640 File Offset: 0x0007E840
		private void VerifyHasAnyListeners()
		{
			bool hasListeners = base.HasListeners;
			if (hasListeners)
			{
				if (this._summaryCalcVersionTracker == null)
				{
					this._summaryCalcVersionTracker = new global::Infragistics.Windows.Internal.PropertyValueTracker(this._summaryDefinition, global::Infragistics.Windows.DataPresenter.SummaryDefinition.CalculationVersionProperty, new global::Infragistics.Windows.Internal.PropertyValueTracker.PropertyValueChangedHandler(this.OnSummaryDefCalcVersionChanged), true);
					return;
				}
			}
			else
			{
				this._summaryCalcVersionTracker = null;
			}
		}

		// Token: 0x04000BA1 RID: 2977
		private object _tooltip;

		// Token: 0x04000BA2 RID: 2978
		private object _calculatedValue;

		// Token: 0x04000BA3 RID: 2979
		private global::Infragistics.Windows.DataPresenter.SummaryDefinition _summaryDefinition;

		// Token: 0x04000BA4 RID: 2980
		private global::Infragistics.Windows.DataPresenter.SummaryResultCollection _parentCollection;

		// Token: 0x04000BA5 RID: 2981
		private int _verifiedDataVersion = -1;

		// Token: 0x04000BA6 RID: 2982
		private int _verifiedFieldsVersion = -1;

		// Token: 0x04000BA7 RID: 2983
		private global::Infragistics.Windows.DataPresenter.Field _cachedSourceField;

		// Token: 0x04000BA8 RID: 2984
		private global::Infragistics.Windows.DataPresenter.Field _cachedPositionFieldResolved;

		// Token: 0x04000BA9 RID: 2985
		private string _cachedDisplayText;

		// Token: 0x04000BAA RID: 2986
		private int _dataVersion;

		// Token: 0x04000BAB RID: 2987
		private global::Infragistics.Windows.Internal.PropertyValueTracker _summaryCalcVersionTracker;

		// Token: 0x04000BAC RID: 2988
		private int _fieldAutoSizeVersion;

		// Token: 0x04000BAD RID: 2989
		private bool _isAsyncOperationSupported;

		// Token: 0x04000BAE RID: 2990
		internal bool SkipEnsureCalculated;

		// Token: 0x020001DA RID: 474
		private class SortComparer_UnsortedIndex : global::System.Collections.Generic.IComparer<global::Infragistics.Windows.DataPresenter.DataRecord>
		{
			// Token: 0x06001C71 RID: 7281 RVA: 0x0008068C File Offset: 0x0007E88C
			public int Compare(global::Infragistics.Windows.DataPresenter.DataRecord x, global::Infragistics.Windows.DataPresenter.DataRecord y)
			{
				int dataItemIndex = x.DataItemIndex;
				int dataItemIndex2 = y.DataItemIndex;
				return dataItemIndex.CompareTo(dataItemIndex2);
			}
		}
	}
}
