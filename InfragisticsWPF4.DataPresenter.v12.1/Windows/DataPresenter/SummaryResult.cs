using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using Infragistics.Collections;
using Infragistics.Windows.DataPresenter.Events;
using Infragistics.Windows.Internal;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020001B6 RID: 438
	public class SummaryResult : global::Infragistics.PropertyChangeNotifier
	{
		// Token: 0x06001889 RID: 6281 RVA: 0x0006CB14 File Offset: 0x0006AD14
		internal SummaryResult(global::Infragistics.Windows.DataPresenter.SummaryResultCollection parentCollection, global::Infragistics.Windows.DataPresenter.SummaryDefinition summaryDefinition)
		{
			global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNotNull(parentCollection);
			global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNotNull(summaryDefinition);
			this._parentCollection = parentCollection;
			this._summaryDefinition = summaryDefinition;
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = global::Infragistics.Windows.DataPresenter.GridUtilities.GetDataPresenter(parentCollection.Records);
			this._isAsyncOperationSupported = (dataPresenter != null && !dataPresenter.IsReportControl && !dataPresenter.IsExportControl);
		}

		// Token: 0x0600188A RID: 6282 RVA: 0x0006CB78 File Offset: 0x0006AD78
		protected override void OnHasListenersChanged()
		{
			base.OnHasListenersChanged();
			this.VerifyHasAnyListeners();
		}

		// Token: 0x1700068C RID: 1676
		// (get) Token: 0x0600188B RID: 6283 RVA: 0x0006CB88 File Offset: 0x0006AD88
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
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

		// Token: 0x1700068D RID: 1677
		// (get) Token: 0x0600188C RID: 6284 RVA: 0x0006CC6C File Offset: 0x0006AE6C
		public string DisplayText
		{
			get
			{
				this.EnsureCalculated();
				return this._cachedDisplayText ?? string.Empty;
			}
		}

		// Token: 0x1700068E RID: 1678
		// (get) Token: 0x0600188D RID: 6285 RVA: 0x0006CC83 File Offset: 0x0006AE83
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

		// Token: 0x1700068F RID: 1679
		// (get) Token: 0x0600188E RID: 6286 RVA: 0x0006CCA2 File Offset: 0x0006AEA2
		public global::Infragistics.Windows.DataPresenter.SummaryResultCollection ParentCollection
		{
			get
			{
				return this._parentCollection;
			}
		}

		// Token: 0x17000690 RID: 1680
		// (get) Token: 0x0600188F RID: 6287 RVA: 0x0006CCAA File Offset: 0x0006AEAA
		public global::Infragistics.Windows.DataPresenter.Field PositionFieldResolved
		{
			get
			{
				this.VerifyFields();
				return this._cachedPositionFieldResolved;
			}
		}

		// Token: 0x17000691 RID: 1681
		// (get) Token: 0x06001890 RID: 6288 RVA: 0x0006CCB8 File Offset: 0x0006AEB8
		public global::Infragistics.Windows.DataPresenter.Field SourceField
		{
			get
			{
				this.VerifyFields();
				return this._cachedSourceField;
			}
		}

		// Token: 0x17000692 RID: 1682
		// (get) Token: 0x06001891 RID: 6289 RVA: 0x0006CCC6 File Offset: 0x0006AEC6
		public global::Infragistics.Windows.DataPresenter.SummaryDefinition SummaryDefinition
		{
			get
			{
				return this._summaryDefinition;
			}
		}

		// Token: 0x17000693 RID: 1683
		// (get) Token: 0x06001892 RID: 6290 RVA: 0x0006CCCE File Offset: 0x0006AECE
		// (set) Token: 0x06001893 RID: 6291 RVA: 0x0006CCD6 File Offset: 0x0006AED6
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

		// Token: 0x17000694 RID: 1684
		// (get) Token: 0x06001894 RID: 6292 RVA: 0x0006CCFE File Offset: 0x0006AEFE
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Browsable(false)]
		public object ToolTipResolved
		{
			get
			{
				return this.GetToolTipResolved(true);
			}
		}

		// Token: 0x17000695 RID: 1685
		// (get) Token: 0x06001895 RID: 6293 RVA: 0x0006CD07 File Offset: 0x0006AF07
		public object Value
		{
			get
			{
				this.EnsureCalculated();
				return this._calculatedValue;
			}
		}

		// Token: 0x17000696 RID: 1686
		// (get) Token: 0x06001896 RID: 6294 RVA: 0x0006CD15 File Offset: 0x0006AF15
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

		// Token: 0x17000697 RID: 1687
		// (get) Token: 0x06001897 RID: 6295 RVA: 0x0006CD2B File Offset: 0x0006AF2B
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		public int DataVersion
		{
			get
			{
				return this._dataVersion + this.SummaryDefinition.CalculationVersion;
			}
		}

		// Token: 0x17000698 RID: 1688
		// (get) Token: 0x06001898 RID: 6296 RVA: 0x0006CD3F File Offset: 0x0006AF3F
		// (set) Token: 0x06001899 RID: 6297 RVA: 0x0006CD47 File Offset: 0x0006AF47
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

		// Token: 0x17000699 RID: 1689
		// (get) Token: 0x0600189A RID: 6298 RVA: 0x0006CD50 File Offset: 0x0006AF50
		internal global::Infragistics.Windows.DataPresenter.FieldLayout FieldLayout
		{
			get
			{
				return this._parentCollection.Records.FieldLayout;
			}
		}

		// Token: 0x0600189B RID: 6299 RVA: 0x0006CD62 File Offset: 0x0006AF62
		internal bool IsDirty(bool cleanPendingDirtyAffectedSummaries)
		{
			if (cleanPendingDirtyAffectedSummaries && this._parentCollection != null)
			{
				this._parentCollection.CleanPendingDirtyAffectedSummaries();
			}
			return this._verifiedDataVersion != this.DataVersion;
		}

		// Token: 0x1700069A RID: 1690
		// (get) Token: 0x0600189C RID: 6300 RVA: 0x0006CD8C File Offset: 0x0006AF8C
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

		// Token: 0x1700069B RID: 1691
		// (get) Token: 0x0600189D RID: 6301 RVA: 0x0006CDAC File Offset: 0x0006AFAC
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

		// Token: 0x0600189E RID: 6302 RVA: 0x0006CDDB File Offset: 0x0006AFDB
		public void Refresh()
		{
			this._verifiedDataVersion--;
			this._verifiedFieldsVersion--;
			this.ResultChanged_RaisePropChangeNotifications();
		}

		// Token: 0x0600189F RID: 6303 RVA: 0x0006CDFF File Offset: 0x0006AFFF
		internal void DirtyCalculation()
		{
			if (!this.IsDirty(false))
			{
				this._dataVersion++;
				base.RaisePropertyChangedEvent("DataVersion");
			}
		}

		// Token: 0x060018A0 RID: 6304 RVA: 0x0006CE24 File Offset: 0x0006B024
		internal void EnsureCalculated()
		{
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
						if (global::Infragistics.Windows.DataPresenter.SummaryEvaluationMode.UseLinq == summaryEvaluationModeResolved2 && !sourceField.IsUnbound)
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
									global::System.Collections.IEnumerable enumerable = null;
									try
									{
										enumerable = linqQueryManager.PerformQuery(linqStatement);
									}
									catch
									{
										if ("Average" == text)
										{
											enumerable = new object[]
											{
												0m
											};
										}
									}
									object obj = (enumerable != null) ? global::Infragistics.CoreUtilities.GetFirstItem<object>(enumerable, true) : null;
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
						bool flag2 = global::Infragistics.Windows.DataPresenter.CalculationScope.FullUnsortedList == calculationScopeResolved && calculator.IsCalculationAffectedBySort;
						global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.DataRecord> enumerable2 = new global::Infragistics.Collections.TypedEnumerable<global::Infragistics.Windows.DataPresenter.DataRecord>(records.GetRecordEnumerator(global::Infragistics.Windows.DataPresenter.RecordType.DataRecord, sourceField.Owner, sourceField.Owner, visibleRecordsOnly));
						if (flag2)
						{
							global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.DataRecord> list = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.DataRecord>(enumerable2);
							list.Sort(new global::Infragistics.Windows.DataPresenter.SummaryResult.SortComparer_UnsortedIndex());
							enumerable2 = list;
						}
						calculator.BeginCalculation(this);
						foreach (global::Infragistics.Windows.DataPresenter.DataRecord dataRecord in enumerable2)
						{
							object cellValue = dataRecord.GetCellValue(sourceField, global::Infragistics.Windows.DataPresenter.CellValueType.EditAsType);
							calculator.Aggregate(cellValue, this, dataRecord);
						}
						newCalculatedValue = calculator.EndCalculation(this);
					}
				}
				this.InternalSetNewValue(newCalculatedValue);
			}
		}

		// Token: 0x060018A1 RID: 6305 RVA: 0x0006D0F8 File Offset: 0x0006B2F8
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
					return string.Format(stringFormatProviderResolved, text, new object[]
					{
						value,
						calculator.DisplayName,
						summaryDefinition.Key,
						summaryDefinition.SourceFieldName
					});
				}
				return calculator.ApplyDefaultFormat(value, this);
			}
			else
			{
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
		}

		// Token: 0x060018A2 RID: 6306 RVA: 0x0006D1EC File Offset: 0x0006B3EC
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
				string name = sourceField.Name;
				return name + ": " + text;
			}
			return text;
		}

		// Token: 0x060018A3 RID: 6307 RVA: 0x0006D24C File Offset: 0x0006B44C
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

		// Token: 0x060018A4 RID: 6308 RVA: 0x0006D2CC File Offset: 0x0006B4CC
		private void OnSummaryDefCalcVersionChanged()
		{
			base.RaisePropertyChangedEvent("DataVersion");
		}

		// Token: 0x060018A5 RID: 6309 RVA: 0x0006D2D9 File Offset: 0x0006B4D9
		private void ResultChanged_RaisePropChangeNotifications()
		{
			base.RaisePropertyChangedEvent("Value");
			base.RaisePropertyChangedEvent("DisplayText");
			base.RaisePropertyChangedEvent("ToolTipResolved");
			base.RaisePropertyChangedEvent("ValueAsync");
			base.RaisePropertyChangedEvent("DisplayTextAsync");
		}

		// Token: 0x060018A6 RID: 6310 RVA: 0x0006D314 File Offset: 0x0006B514
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

		// Token: 0x060018A7 RID: 6311 RVA: 0x0006D408 File Offset: 0x0006B608
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

		// Token: 0x040009D1 RID: 2513
		private object _tooltip;

		// Token: 0x040009D2 RID: 2514
		private object _calculatedValue;

		// Token: 0x040009D3 RID: 2515
		private global::Infragistics.Windows.DataPresenter.SummaryDefinition _summaryDefinition;

		// Token: 0x040009D4 RID: 2516
		private global::Infragistics.Windows.DataPresenter.SummaryResultCollection _parentCollection;

		// Token: 0x040009D5 RID: 2517
		private int _verifiedDataVersion = -1;

		// Token: 0x040009D6 RID: 2518
		private int _verifiedFieldsVersion = -1;

		// Token: 0x040009D7 RID: 2519
		private global::Infragistics.Windows.DataPresenter.Field _cachedSourceField;

		// Token: 0x040009D8 RID: 2520
		private global::Infragistics.Windows.DataPresenter.Field _cachedPositionFieldResolved;

		// Token: 0x040009D9 RID: 2521
		private string _cachedDisplayText;

		// Token: 0x040009DA RID: 2522
		private int _dataVersion;

		// Token: 0x040009DB RID: 2523
		private global::Infragistics.Windows.Internal.PropertyValueTracker _summaryCalcVersionTracker;

		// Token: 0x040009DC RID: 2524
		private int _fieldAutoSizeVersion;

		// Token: 0x040009DD RID: 2525
		private bool _isAsyncOperationSupported;

		// Token: 0x020001B7 RID: 439
		private class SortComparer_UnsortedIndex : global::System.Collections.Generic.IComparer<global::Infragistics.Windows.DataPresenter.DataRecord>
		{
			// Token: 0x060018A8 RID: 6312 RVA: 0x0006D454 File Offset: 0x0006B654
			public int Compare(global::Infragistics.Windows.DataPresenter.DataRecord x, global::Infragistics.Windows.DataPresenter.DataRecord y)
			{
				int dataItemIndex = x.DataItemIndex;
				int dataItemIndex2 = y.DataItemIndex;
				return dataItemIndex.CompareTo(dataItemIndex2);
			}
		}
	}
}
