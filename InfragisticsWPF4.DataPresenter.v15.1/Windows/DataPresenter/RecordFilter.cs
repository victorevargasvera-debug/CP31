using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Threading;
using Infragistics.Windows.Controls;
using Infragistics.Windows.DataPresenter.Events;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000161 RID: 353
	[global::System.ComponentModel.DefaultProperty("Conditions")]
	[global::System.Windows.Markup.ContentProperty("Conditions")]
	public class RecordFilter : global::Infragistics.PropertyChangeNotifier, global::System.ICloneable
	{
		// Token: 0x060014CC RID: 5324 RVA: 0x0005C83E File Offset: 0x0005AA3E
		public RecordFilter()
		{
		}

		// Token: 0x060014CD RID: 5325 RVA: 0x0005C846 File Offset: 0x0005AA46
		public RecordFilter(global::Infragistics.Windows.DataPresenter.Field field)
		{
			this.Field = field;
		}

		// Token: 0x060014CE RID: 5326 RVA: 0x0005C855 File Offset: 0x0005AA55
		internal RecordFilter(string fieldName)
		{
			this._fieldName = fieldName;
		}

		// Token: 0x17000531 RID: 1329
		// (get) Token: 0x060014CF RID: 5327 RVA: 0x0005C864 File Offset: 0x0005AA64
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Content)]
		public global::Infragistics.Windows.Controls.ConditionGroup Conditions
		{
			get
			{
				if (this._conditions == null)
				{
					this._conditions = new global::Infragistics.Windows.Controls.ConditionGroup();
					((global::System.ComponentModel.INotifyPropertyChanged)this._conditions).PropertyChanged += this.OnConditions_PropertyChanged;
				}
				return this._conditions;
			}
		}

		// Token: 0x17000532 RID: 1330
		// (get) Token: 0x060014D0 RID: 5328 RVA: 0x0005C896 File Offset: 0x0005AA96
		// (set) Token: 0x060014D1 RID: 5329 RVA: 0x0005C8AC File Offset: 0x0005AAAC
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::Infragistics.Windows.DataPresenter.Field Field
		{
			get
			{
				if (this._field == null)
				{
					this.SyncFieldWithFieldName();
				}
				return this._field;
			}
			set
			{
				if (this._field != value)
				{
					global::Infragistics.Windows.DataPresenter.Field field = this._field;
					this._field = value;
					this._fieldName = ((this._field != null) ? this._field.Name : null);
					base.RaisePropertyChangedEvent("Field");
					base.RaisePropertyChangedEvent("FieldName");
					this.WireFieldTracker();
					if (this._parentCollection != null)
					{
						this._parentCollection.OnRecordFilterFieldChanged(this, field);
					}
				}
			}
		}

		// Token: 0x17000533 RID: 1331
		// (get) Token: 0x060014D2 RID: 5330 RVA: 0x0005C91D File Offset: 0x0005AB1D
		// (set) Token: 0x060014D3 RID: 5331 RVA: 0x0005C925 File Offset: 0x0005AB25
		[global::System.ComponentModel.DefaultValue(null)]
		public string FieldName
		{
			get
			{
				return this._fieldName;
			}
			set
			{
				if (this._fieldName != value)
				{
					this._fieldName = value;
					base.RaisePropertyChangedEvent("FieldName");
					this.SyncFieldWithFieldName();
				}
			}
		}

		// Token: 0x17000534 RID: 1332
		// (get) Token: 0x060014D4 RID: 5332 RVA: 0x0005C94D File Offset: 0x0005AB4D
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		public int Version
		{
			get
			{
				return this._version;
			}
		}

		// Token: 0x17000535 RID: 1333
		// (get) Token: 0x060014D5 RID: 5333 RVA: 0x0005C955 File Offset: 0x0005AB55
		// (set) Token: 0x060014D6 RID: 5334 RVA: 0x0005C95D File Offset: 0x0005AB5D
		internal global::Infragistics.Windows.DataPresenter.FilterDropDownItem CurrentFilterDropDownItem
		{
			get
			{
				return this._currentFilterDropDownItem;
			}
			set
			{
				this._currentFilterDropDownItem = value;
			}
		}

		// Token: 0x17000536 RID: 1334
		// (get) Token: 0x060014D7 RID: 5335 RVA: 0x0005C968 File Offset: 0x0005AB68
		// (set) Token: 0x060014D8 RID: 5336 RVA: 0x0005C9A0 File Offset: 0x0005ABA0
		internal global::Infragistics.Windows.Controls.ComparisonOperator CurrentUIOperator
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.Field field = this.Field;
				if (this._currentUiOperator != null)
				{
					return this._currentUiOperator.Value;
				}
				if (field != null)
				{
					return field.FilterOperatorDefaultValueResolved;
				}
				return global::Infragistics.Windows.Controls.ComparisonOperator.Equals;
			}
			set
			{
				if (value != this.CurrentUIOperator)
				{
					if (this._undoFilter == null)
					{
						this._undoFilter = this.Clone(true, this._parentCollection, true);
					}
					this._currentUiOperator = new global::Infragistics.Windows.Controls.ComparisonOperator?(value);
					this._filterUpdatePending = true;
					global::Infragistics.Windows.Controls.SpecialFilterOperandBase specialFilterOperandBase = this._currentUiOperand as global::Infragistics.Windows.Controls.SpecialFilterOperandBase;
					if (specialFilterOperandBase != null)
					{
						if (!specialFilterOperandBase.SupportsOperator(value))
						{
							this._currentUiOperand = null;
							this._currentFilterDropDownItem = null;
						}
					}
					else if (this._currentUiOperator != null && this._currentUiOperand is global::Infragistics.Windows.Controls.ICondition)
					{
						global::Infragistics.Windows.Controls.ComplementCondition complementCondition;
						global::Infragistics.Windows.Controls.ComparisonCondition underlyingComparisonCondition = global::Infragistics.Windows.DataPresenter.RecordFilter.GetUnderlyingComparisonCondition(this._currentUiOperand, out complementCondition);
						if (underlyingComparisonCondition != null)
						{
							if (!global::Infragistics.Windows.DataPresenter.RecordFilter.IsOperatorCompatibleWithCondition(underlyingComparisonCondition, this._currentUiOperator.Value))
							{
								this._currentUiOperand = null;
								this._currentFilterDropDownItem = null;
							}
						}
						else
						{
							this._currentUiOperand = null;
							this._currentFilterDropDownItem = null;
						}
					}
					global::System.Exception ex;
					if (this._currentUiOperand != null && this.Field != null && !this.Field.IsFilterCellEntryValid(this._currentUiOperand, value, out ex))
					{
						this._currentUiOperand = null;
						this._currentFilterDropDownItem = null;
					}
					this.BumpVersionNumber();
				}
			}
		}

		// Token: 0x17000537 RID: 1335
		// (get) Token: 0x060014D9 RID: 5337 RVA: 0x0005CAA6 File Offset: 0x0005ACA6
		// (set) Token: 0x060014DA RID: 5338 RVA: 0x0005CAB0 File Offset: 0x0005ACB0
		internal object CurrentUIOperand
		{
			get
			{
				return this._currentUiOperand;
			}
			set
			{
				if (value != this._currentUiOperand)
				{
					global::Infragistics.Windows.DataPresenter.FilterDropDownItem filterDropDownItem = value as global::Infragistics.Windows.DataPresenter.FilterDropDownItem;
					if (filterDropDownItem != null)
					{
						value = filterDropDownItem.Value;
					}
					global::System.Windows.Input.ICommand command = value as global::System.Windows.Input.ICommand;
					if (command != null)
					{
						if (this._field != null && command != this._pendingCommand)
						{
							global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this._field.DataPresenter;
							if (dataPresenter != null)
							{
								this._pendingCommand = command;
								dataPresenter.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Normal, new global::Infragistics.Windows.DataPresenter.RecordFilter.ExecuteCommand(this.OnExecuteCommand), command);
							}
						}
						return;
					}
					if (global::Infragistics.Windows.DataPresenter.GridUtilities.IsNullOrEmpty(value))
					{
						value = null;
					}
					if (value == this._currentUiOperand)
					{
						return;
					}
					if (this._undoFilter == null)
					{
						this._undoFilter = this.Clone(true, this._parentCollection, true);
					}
					this._currentUiOperand = value;
					global::Infragistics.Windows.Controls.SpecialFilterOperandBase specialFilterOperandBase = value as global::Infragistics.Windows.Controls.SpecialFilterOperandBase;
					if (specialFilterOperandBase != null)
					{
						if (!specialFilterOperandBase.SupportsOperator(this.CurrentUIOperator))
						{
							this._currentUiOperator = null;
							if (!specialFilterOperandBase.SupportsOperator(this.CurrentUIOperator) && specialFilterOperandBase.SupportsOperator(global::Infragistics.Windows.Controls.ComparisonOperator.Equals))
							{
								this._currentUiOperator = new global::Infragistics.Windows.Controls.ComparisonOperator?(global::Infragistics.Windows.Controls.ComparisonOperator.Equals);
							}
						}
					}
					else if (this._currentUiOperand is global::Infragistics.Windows.Controls.ICondition)
					{
						global::Infragistics.Windows.Controls.ComplementCondition complementCondition;
						global::Infragistics.Windows.Controls.ComparisonCondition underlyingComparisonCondition = global::Infragistics.Windows.DataPresenter.RecordFilter.GetUnderlyingComparisonCondition(this._currentUiOperand, out complementCondition);
						if (underlyingComparisonCondition != null)
						{
							if (!string.IsNullOrEmpty(underlyingComparisonCondition.DisplayText))
							{
								this._currentUiOperator = new global::Infragistics.Windows.Controls.ComparisonOperator?(global::Infragistics.Windows.Controls.ComparisonOperator.Equals);
							}
							else if (this._currentUiOperator != null && !global::Infragistics.Windows.DataPresenter.RecordFilter.IsOperatorCompatibleWithCondition(underlyingComparisonCondition, this._currentUiOperator.Value))
							{
								this._currentUiOperator = null;
							}
						}
						else
						{
							this._currentUiOperator = null;
						}
					}
					global::System.Exception ex;
					if (value != null && this.Field != null && !this.Field.IsFilterCellEntryValid(value, this.CurrentUIOperator, out ex))
					{
						this._currentUiOperator = null;
						if (!this.Field.IsFilterCellEntryValid(value, this.CurrentUIOperator, out ex) && this.Field.IsFilterCellEntryValid(value, global::Infragistics.Windows.Controls.ComparisonOperator.Equals, out ex))
						{
							this._currentUiOperator = new global::Infragistics.Windows.Controls.ComparisonOperator?(global::Infragistics.Windows.Controls.ComparisonOperator.Equals);
						}
					}
					this._filterUpdatePending = true;
					this.BumpVersionNumber();
				}
			}
		}

		// Token: 0x17000538 RID: 1336
		// (get) Token: 0x060014DB RID: 5339 RVA: 0x0005CC96 File Offset: 0x0005AE96
		internal bool HasConditions
		{
			get
			{
				return this._conditions != null && this._conditions.Count > 0;
			}
		}

		// Token: 0x17000539 RID: 1337
		// (get) Token: 0x060014DC RID: 5340 RVA: 0x0005CCB0 File Offset: 0x0005AEB0
		internal bool HasPendingChanges
		{
			get
			{
				return this._filterUpdatePending;
			}
		}

		// Token: 0x1700053A RID: 1338
		// (get) Token: 0x060014DD RID: 5341 RVA: 0x0005CCB8 File Offset: 0x0005AEB8
		internal bool IsInitializing
		{
			get
			{
				return this._isInitializing;
			}
		}

		// Token: 0x1700053B RID: 1339
		// (get) Token: 0x060014DE RID: 5342 RVA: 0x0005CCC0 File Offset: 0x0005AEC0
		internal global::Infragistics.Windows.DataPresenter.RecordFilterCollection ParentCollection
		{
			get
			{
				return this._parentCollection;
			}
		}

		// Token: 0x1700053C RID: 1340
		// (get) Token: 0x060014DF RID: 5343 RVA: 0x0005CCC8 File Offset: 0x0005AEC8
		internal object Tooltip
		{
			get
			{
				if (this._currentUiOperand is global::Infragistics.Windows.Controls.ICondition)
				{
					if (this._currentFilterDropDownItem != null)
					{
						string displayText = this._currentFilterDropDownItem.DisplayText;
						if (displayText != null && displayText.Length > 0)
						{
							return displayText;
						}
					}
					global::Infragistics.Windows.Controls.ConditionGroup conditionGroup = this._currentUiOperand as global::Infragistics.Windows.Controls.ConditionGroup;
					if (conditionGroup != null)
					{
						return conditionGroup.ToolTip;
					}
					return this._currentUiOperand.ToString();
				}
				else
				{
					if (this._filterUpdatePending)
					{
						if (this._currentUiOperand == null)
						{
							return null;
						}
						try
						{
							global::Infragistics.Windows.Controls.ComparisonCondition comparisonCondition = new global::Infragistics.Windows.Controls.ComparisonCondition(this.CurrentUIOperator, this._currentUiOperand);
							return comparisonCondition.ToString();
						}
						catch
						{
							return null;
						}
					}
					if (this.Conditions.Count == 0)
					{
						return null;
					}
					return this.Conditions.ToolTip;
				}
			}
		}

		// Token: 0x060014E0 RID: 5344 RVA: 0x0005CD84 File Offset: 0x0005AF84
		public void ApplyPendingFilter()
		{
			this.ApplyPendingFilter(true, true);
		}

		// Token: 0x060014E1 RID: 5345 RVA: 0x0005CD90 File Offset: 0x0005AF90
		internal global::Infragistics.Windows.DataPresenter.RecordFilter ApplyPendingFilter(bool raiseEvents, bool addToUndo)
		{
			if (!this._filterUpdatePending)
			{
				return null;
			}
			bool applyingPendingFilter = this._applyingPendingFilter;
			bool flag = false;
			global::Infragistics.Windows.DataPresenter.RecordFilter recordFilter = this._undoFilter;
			this._undoFilter = null;
			bool flag2;
			try
			{
				this._applyingPendingFilter = true;
				flag = this.ApplyPendingFilterImpl(raiseEvents, out flag2);
			}
			finally
			{
				this._applyingPendingFilter = applyingPendingFilter;
			}
			if (flag && this._parentCollection != null)
			{
				this._parentCollection.OnRecordFilterChanged(this);
			}
			if (!flag || this.HasSameValues(this._undoFilter))
			{
				recordFilter = null;
			}
			if (recordFilter != null && addToUndo)
			{
				global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this.Field.DataPresenter;
				if (dataPresenter != null)
				{
					global::Infragistics.Windows.DataPresenter.FilterCell cell = dataPresenter.ActiveCell as global::Infragistics.Windows.DataPresenter.FilterCell;
					dataPresenter.History.AddUndoActionInternal(new global::Infragistics.Windows.DataPresenter.RecordFiltersAction(new global::Infragistics.Windows.DataPresenter.RecordFilter[]
					{
						recordFilter
					}, this._parentCollection.Owner, cell, dataPresenter));
				}
			}
			if (flag2)
			{
				global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenterBase = (this._field != null) ? this._field.DataPresenter : null;
				if (dataPresenterBase != null)
				{
					dataPresenterBase.RaiseRecordFilterChanged(new global::Infragistics.Windows.DataPresenter.Events.RecordFilterChangedEventArgs(this));
				}
			}
			return recordFilter;
		}

		// Token: 0x060014E2 RID: 5346 RVA: 0x0005CE94 File Offset: 0x0005B094
		private bool ApplyPendingFilterImpl(bool raiseEvents, out bool raiseRecordFilterChanged)
		{
			raiseRecordFilterChanged = false;
			global::Infragistics.Windows.DataPresenter.Field field = this.Field;
			if (field == null)
			{
				return false;
			}
			if (field.DataPresenter == null)
			{
				return false;
			}
			this._filterUpdatePending = false;
			global::Infragistics.Windows.DataPresenter.RecordFilter recordFilter = this.Clone(false);
			if (this._currentUiOperand != null)
			{
				global::Infragistics.Windows.Controls.ConditionGroup conditionGroup = this._currentUiOperand as global::Infragistics.Windows.Controls.ConditionGroup;
				if (conditionGroup != null)
				{
					recordFilter.Conditions.LogicalOperator = conditionGroup.LogicalOperator;
					using (global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.Controls.ICondition> enumerator = conditionGroup.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							global::Infragistics.Windows.Controls.ICondition item = enumerator.Current;
							recordFilter.Conditions.Add(item);
						}
						goto IL_183;
					}
				}
				if (this._currentUiOperand is global::Infragistics.Windows.Controls.ICondition)
				{
					global::Infragistics.Windows.Controls.ComplementCondition complementCondition;
					global::Infragistics.Windows.Controls.ComparisonCondition underlyingComparisonCondition = global::Infragistics.Windows.DataPresenter.RecordFilter.GetUnderlyingComparisonCondition(this._currentUiOperand, out complementCondition);
					if (underlyingComparisonCondition != null)
					{
						if (string.IsNullOrEmpty(underlyingComparisonCondition.DisplayText) && this._currentUiOperator != null && underlyingComparisonCondition.Operator != this._currentUiOperator.Value)
						{
							global::Infragistics.Windows.Controls.ComparisonCondition comparisonCondition = ((global::System.ICloneable)underlyingComparisonCondition).Clone() as global::Infragistics.Windows.Controls.ComparisonCondition;
							comparisonCondition.Operator = this._currentUiOperator.Value;
							if (complementCondition != null)
							{
								recordFilter._conditions.Add(new global::Infragistics.Windows.Controls.ComplementCondition(underlyingComparisonCondition));
							}
							else
							{
								recordFilter._conditions.Add(comparisonCondition);
							}
						}
						else
						{
							recordFilter._conditions.Add(this._currentUiOperand as global::Infragistics.Windows.Controls.ICondition);
						}
					}
					else
					{
						recordFilter._conditions.Add(this._currentUiOperand as global::Infragistics.Windows.Controls.ICondition);
					}
				}
				else
				{
					try
					{
						global::Infragistics.Windows.Controls.ComparisonCondition item2 = new global::Infragistics.Windows.Controls.ComparisonCondition(this.CurrentUIOperator, this._currentUiOperand);
						recordFilter._conditions.Add(item2);
					}
					catch
					{
						return false;
					}
				}
			}
			IL_183:
			bool result = this.CopyConditionGroupHelper(recordFilter, false, raiseEvents, out raiseRecordFilterChanged);
			this.InitializeUIOperatorAndOperand();
			this.BumpVersionNumber();
			return result;
		}

		// Token: 0x060014E3 RID: 5347 RVA: 0x0005D060 File Offset: 0x0005B260
		public void Clear()
		{
			this.Clear(false);
		}

		// Token: 0x060014E4 RID: 5348 RVA: 0x0005D069 File Offset: 0x0005B269
		internal void Clear(bool raiseEvents)
		{
			this.Clear(raiseEvents, raiseEvents);
		}

		// Token: 0x060014E5 RID: 5349 RVA: 0x0005D074 File Offset: 0x0005B274
		internal global::Infragistics.Windows.DataPresenter.RecordFilter Clear(bool raiseEvents, bool addToUndo)
		{
			if (!raiseEvents)
			{
				this._undoFilter = null;
				if (this._conditions != null)
				{
					this._conditions.Clear();
				}
				this._currentUiOperand = null;
				this.InitializeUIOperatorAndOperand();
				this.BumpVersionNumber();
				return null;
			}
			if (!this._filterUpdatePending)
			{
				if (this._undoFilter == null)
				{
					this._undoFilter = this.Clone(true, this._parentCollection, true);
				}
				this._filterUpdatePending = true;
				this._currentUiOperand = null;
				return this.ApplyPendingFilter(raiseEvents, addToUndo);
			}
			this.CurrentUIOperand = null;
			return null;
		}

		// Token: 0x060014E6 RID: 5350 RVA: 0x0005D0F6 File Offset: 0x0005B2F6
		object global::System.ICloneable.Clone()
		{
			return this.Clone(true);
		}

		// Token: 0x060014E7 RID: 5351 RVA: 0x0005D0FF File Offset: 0x0005B2FF
		internal global::Infragistics.Windows.DataPresenter.RecordFilter Clone(bool cloneConditions)
		{
			return this.Clone(cloneConditions, this._parentCollection);
		}

		// Token: 0x060014E8 RID: 5352 RVA: 0x0005D10E File Offset: 0x0005B30E
		internal global::Infragistics.Windows.DataPresenter.RecordFilter Clone(bool cloneConditions, global::Infragistics.Windows.DataPresenter.RecordFilterCollection parentCollection)
		{
			return this.Clone(cloneConditions, parentCollection, false);
		}

		// Token: 0x060014E9 RID: 5353 RVA: 0x0005D11C File Offset: 0x0005B31C
		internal global::Infragistics.Windows.DataPresenter.RecordFilter Clone(bool cloneConditions, global::Infragistics.Windows.DataPresenter.RecordFilterCollection parentCollection, bool includeCurrentState)
		{
			global::Infragistics.Windows.DataPresenter.RecordFilter recordFilter = new global::Infragistics.Windows.DataPresenter.RecordFilter();
			if (parentCollection == this._parentCollection)
			{
				recordFilter._parentCollection = this._parentCollection;
				recordFilter._field = this._field;
			}
			recordFilter._fieldName = this._fieldName;
			if (cloneConditions)
			{
				recordFilter._conditions = (global::Infragistics.Windows.Controls.ConditionGroup)((global::System.ICloneable)this._conditions).Clone();
			}
			else
			{
				recordFilter._conditions = new global::Infragistics.Windows.Controls.ConditionGroup();
				recordFilter._conditions.LogicalOperator = this.Conditions.LogicalOperator;
			}
			if (includeCurrentState)
			{
				recordFilter._currentUiOperand = this._currentUiOperand;
				recordFilter._currentUiOperator = this._currentUiOperator;
				recordFilter._filterUpdatePending = this._filterUpdatePending;
				recordFilter._conditions.ToolTip = this.Conditions.ToolTip;
			}
			return recordFilter;
		}

		// Token: 0x060014EA RID: 5354 RVA: 0x0005D1D8 File Offset: 0x0005B3D8
		public bool MeetsCriteria(global::Infragistics.Windows.DataPresenter.DataRecord record)
		{
			global::Infragistics.Windows.DataPresenter.FilterConditionEvaluationContext evaluationContext = global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.CreateEvaluationContext(record.RecordManager, this.Field);
			return this.MeetsCriteria(record, evaluationContext);
		}

		// Token: 0x060014EB RID: 5355 RVA: 0x0005D200 File Offset: 0x0005B400
		internal void ApplyNewConditions(global::Infragistics.Windows.Controls.ConditionGroup newGroup)
		{
			this._currentFilterDropDownItem = null;
			this.CurrentUIOperand = newGroup;
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this._parentCollection.DataPresenter;
			global::Infragistics.Windows.DataPresenter.FilterCell cell = (dataPresenter == null) ? null : (dataPresenter.ActiveCell as global::Infragistics.Windows.DataPresenter.FilterCell);
			this._parentCollection.ApplyPendingFilters(true, true, cell);
		}

		// Token: 0x060014EC RID: 5356 RVA: 0x0005D247 File Offset: 0x0005B447
		internal void BumpVersionNumber()
		{
			this._version++;
			base.RaisePropertyChangedEvent("Version");
		}

		// Token: 0x060014ED RID: 5357 RVA: 0x0005D264 File Offset: 0x0005B464
		private bool CopyConditionGroupHelper(global::Infragistics.Windows.DataPresenter.RecordFilter source, bool cloneConditions, bool raiseEvents, out bool raiseRecordFilterChanged)
		{
			raiseRecordFilterChanged = false;
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenterBase = (this._field != null) ? this._field.DataPresenter : null;
			if (dataPresenterBase != null && raiseEvents)
			{
				global::Infragistics.Windows.DataPresenter.Events.RecordFilterChangingEventArgs recordFilterChangingEventArgs = new global::Infragistics.Windows.DataPresenter.Events.RecordFilterChangingEventArgs(source);
				dataPresenterBase.RaiseRecordFilterChanging(recordFilterChangingEventArgs);
				if (recordFilterChangingEventArgs.Cancel)
				{
					return false;
				}
			}
			bool isInitializing = this._isInitializing;
			try
			{
				this._isInitializing = true;
				global::Infragistics.Windows.Controls.ConditionGroup conditions = source.Conditions;
				this.Conditions.Clear();
				foreach (global::Infragistics.Windows.Controls.ICondition condition in conditions)
				{
					global::Infragistics.Windows.Controls.ICondition item = cloneConditions ? ((global::Infragistics.Windows.Controls.ICondition)condition.Clone()) : condition;
					this.Conditions.Add(item);
				}
				this.Conditions.LogicalOperator = conditions.LogicalOperator;
				this.Conditions.ToolTip = conditions.ToolTip;
			}
			finally
			{
				this._isInitializing = isInitializing;
			}
			if (dataPresenterBase != null && raiseEvents)
			{
				raiseRecordFilterChanged = true;
			}
			return true;
		}

		// Token: 0x060014EE RID: 5358 RVA: 0x0005D36C File Offset: 0x0005B56C
		internal bool HasSameValues(global::Infragistics.Windows.DataPresenter.RecordFilter other)
		{
			return other != null && object.Equals(this._filterUpdatePending, other._filterUpdatePending) && object.Equals(this._currentUiOperator, other._currentUiOperator) && object.Equals(this._currentUiOperand, other._currentUiOperand) && object.Equals(this.Conditions, other.Conditions);
		}

		// Token: 0x060014EF RID: 5359 RVA: 0x0005D3E8 File Offset: 0x0005B5E8
		private static global::Infragistics.Windows.Controls.ComparisonCondition GetUnderlyingComparisonCondition(object value, out global::Infragistics.Windows.Controls.ComplementCondition complement)
		{
			global::Infragistics.Windows.Controls.ConditionGroup conditionGroup = value as global::Infragistics.Windows.Controls.ConditionGroup;
			if (conditionGroup != null)
			{
				if (conditionGroup.Count == 1)
				{
					return global::Infragistics.Windows.DataPresenter.RecordFilter.GetUnderlyingComparisonCondition(conditionGroup[0], out complement);
				}
				complement = null;
				return null;
			}
			else
			{
				complement = (value as global::Infragistics.Windows.Controls.ComplementCondition);
				if (complement != null)
				{
					return complement.SourceCondition as global::Infragistics.Windows.Controls.ComparisonCondition;
				}
				return value as global::Infragistics.Windows.Controls.ComparisonCondition;
			}
		}

		// Token: 0x060014F0 RID: 5360 RVA: 0x0005D43C File Offset: 0x0005B63C
		private void InitializeFilterDropDownItem(global::Infragistics.Windows.Controls.ComparisonCondition condition)
		{
			if (condition == null || this._field == null)
			{
				return;
			}
			global::Infragistics.Windows.DataPresenter.FieldLayout owner = this._field.Owner;
			if (owner == null)
			{
				this._conditionPendingInitialization = condition;
				return;
			}
			if (owner.FilterUITypeResolved != global::Infragistics.Windows.DataPresenter.FilterUIType.FilterRecord)
			{
				this._conditionPendingInitialization = null;
				return;
			}
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this._field.DataPresenter;
			if (dataPresenter == null)
			{
				this._conditionPendingInitialization = condition;
				return;
			}
			this._conditionPendingInitialization = null;
			global::Infragistics.Windows.DataPresenter.FilterDropDownItem filterDropDownItem = new global::Infragistics.Windows.DataPresenter.FilterDropDownItem(condition.Value, condition.DisplayText, true);
			global::Infragistics.Windows.DataPresenter.RecordManager recordManager = (this._parentCollection != null) ? (this._parentCollection.Owner as global::Infragistics.Windows.DataPresenter.RecordManager) : null;
			dataPresenter.RaiseRecordFilterDropDownItemInitializing(new global::Infragistics.Windows.DataPresenter.Events.RecordFilterDropDownItemInitializingEventArgs(this._field, recordManager, filterDropDownItem));
			if (!string.IsNullOrEmpty(filterDropDownItem.DisplayText) || filterDropDownItem.Image != null)
			{
				this._currentFilterDropDownItem = filterDropDownItem;
			}
		}

		// Token: 0x060014F1 RID: 5361 RVA: 0x0005D4FC File Offset: 0x0005B6FC
		internal bool InitializeFrom(global::Infragistics.Windows.DataPresenter.RecordFilter recordFilter, bool cloneConditions, bool raiseEvents)
		{
			bool isInitializing = this._isInitializing;
			bool result;
			try
			{
				this._isInitializing = true;
				bool flag = false;
				bool flag2 = false;
				global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenterBase = (this._field != null) ? this._field.DataPresenter : null;
				if (!object.Equals(recordFilter.Conditions, this.Conditions) && dataPresenterBase != null)
				{
					if (!this.CopyConditionGroupHelper(recordFilter, cloneConditions, raiseEvents, out flag2))
					{
						return false;
					}
					flag = true;
					this.InitializeUIOperatorAndOperand();
				}
				this._filterUpdatePending = recordFilter._filterUpdatePending;
				this._currentUiOperator = recordFilter._currentUiOperator;
				this._currentUiOperand = recordFilter._currentUiOperand;
				this._currentFilterDropDownItem = null;
				this.BumpVersionNumber();
				if (flag && this._parentCollection != null)
				{
					this._parentCollection.OnRecordFilterChanged(this);
				}
				if (flag2 && dataPresenterBase != null)
				{
					dataPresenterBase.RaiseRecordFilterChanged(new global::Infragistics.Windows.DataPresenter.Events.RecordFilterChangedEventArgs(this));
				}
				result = true;
			}
			finally
			{
				this._isInitializing = isInitializing;
			}
			return result;
		}

		// Token: 0x060014F2 RID: 5362 RVA: 0x0005D5DC File Offset: 0x0005B7DC
		internal void InitializeParentCollection(global::Infragistics.Windows.DataPresenter.RecordFilterCollection parentCollection)
		{
			if (this._parentCollection != parentCollection)
			{
				if (this._parentCollection != null)
				{
					throw new global::System.InvalidOperationException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_InvalidOperationException_27"));
				}
				this._parentCollection = parentCollection;
				this.SyncFieldWithFieldName();
				this.InitializeUIOperatorAndOperand();
			}
		}

		// Token: 0x060014F3 RID: 5363 RVA: 0x0005D612 File Offset: 0x0005B812
		private void InitializePendingCondition()
		{
			if (this._conditionPendingInitialization != null && this._conditions.Count == 1 && this._conditions[0] == this._conditionPendingInitialization)
			{
				this.InitializeFilterDropDownItem(this._conditionPendingInitialization);
				return;
			}
			this._conditionPendingInitialization = null;
		}

		// Token: 0x060014F4 RID: 5364 RVA: 0x0005D652 File Offset: 0x0005B852
		private void InitializeUIOperatorAndOperand()
		{
			this.InitializeUIOperatorAndOperand(false);
		}

		// Token: 0x060014F5 RID: 5365 RVA: 0x0005D65C File Offset: 0x0005B85C
		private void InitializeUIOperatorAndOperand(bool externalChangeOfCriteria)
		{
			if (this._filterUpdatePending)
			{
				return;
			}
			object obj = null;
			global::Infragistics.Windows.Controls.ComparisonOperator? comparisonOperator = null;
			int count = this.Conditions.Count;
			if (count > 0)
			{
				if (count == 1)
				{
					obj = this.Conditions[0];
					global::Infragistics.Windows.Controls.ComplementCondition complementCondition;
					global::Infragistics.Windows.Controls.ComparisonCondition underlyingComparisonCondition = global::Infragistics.Windows.DataPresenter.RecordFilter.GetUnderlyingComparisonCondition(obj, out complementCondition);
					if (underlyingComparisonCondition != null)
					{
						comparisonOperator = new global::Infragistics.Windows.Controls.ComparisonOperator?(underlyingComparisonCondition.Operator);
						if (this._currentFilterDropDownItem == null && externalChangeOfCriteria)
						{
							this.InitializeFilterDropDownItem(underlyingComparisonCondition);
							obj = underlyingComparisonCondition.Value;
						}
						if (!string.IsNullOrEmpty(underlyingComparisonCondition.DisplayText))
						{
							obj = underlyingComparisonCondition;
							comparisonOperator = new global::Infragistics.Windows.Controls.ComparisonOperator?(global::Infragistics.Windows.Controls.ComparisonOperator.Equals);
						}
						else if (this._currentFilterDropDownItem == null)
						{
							obj = underlyingComparisonCondition.Value;
						}
						else if (underlyingComparisonCondition != this._currentFilterDropDownItem.Value)
						{
							global::Infragistics.Windows.Controls.ComplementCondition complementCondition2;
							global::Infragistics.Windows.Controls.ComparisonCondition comparisonCondition = global::Infragistics.Windows.DataPresenter.RecordFilter.GetUnderlyingComparisonCondition(this._currentFilterDropDownItem.Value, out complementCondition2);
							if (complementCondition2 != null)
							{
								comparisonCondition = (complementCondition2.SourceCondition as global::Infragistics.Windows.Controls.ComparisonCondition);
							}
							else
							{
								comparisonCondition = (this._currentFilterDropDownItem.Value as global::Infragistics.Windows.Controls.ComparisonCondition);
							}
							if (comparisonCondition != null && (comparisonCondition == underlyingComparisonCondition || comparisonCondition.Value == underlyingComparisonCondition.Value))
							{
								obj = this._currentFilterDropDownItem.Value;
							}
							else
							{
								obj = underlyingComparisonCondition.Value;
							}
						}
					}
					else
					{
						comparisonOperator = null;
					}
				}
				else
				{
					obj = this.Conditions;
					comparisonOperator = null;
				}
			}
			else
			{
				comparisonOperator = this._currentUiOperator;
			}
			bool flag = false;
			if (!object.Equals(this._currentUiOperand, obj))
			{
				this._currentUiOperand = obj;
				flag = true;
			}
			if (!object.Equals(this._currentUiOperator, comparisonOperator))
			{
				this._currentUiOperator = comparisonOperator;
				flag = true;
			}
			if (flag)
			{
				this.BumpVersionNumber();
			}
		}

		// Token: 0x060014F6 RID: 5366 RVA: 0x0005D7F8 File Offset: 0x0005B9F8
		internal static bool IsOperatorCompatibleWithCondition(global::Infragistics.Windows.Controls.ComparisonCondition condition, global::Infragistics.Windows.Controls.ComparisonOperator oper)
		{
			if (!string.IsNullOrEmpty(condition.DisplayText))
			{
				return oper == global::Infragistics.Windows.Controls.ComparisonOperator.Equals;
			}
			switch (condition.Operator)
			{
			case global::Infragistics.Windows.Controls.ComparisonOperator.Equals:
			case global::Infragistics.Windows.Controls.ComparisonOperator.NotEquals:
				return oper == global::Infragistics.Windows.Controls.ComparisonOperator.Equals || oper == global::Infragistics.Windows.Controls.ComparisonOperator.NotEquals;
			case global::Infragistics.Windows.Controls.ComparisonOperator.Contains:
			case global::Infragistics.Windows.Controls.ComparisonOperator.DoesNotContain:
				return oper == global::Infragistics.Windows.Controls.ComparisonOperator.Contains || oper == global::Infragistics.Windows.Controls.ComparisonOperator.DoesNotContain;
			case global::Infragistics.Windows.Controls.ComparisonOperator.Like:
			case global::Infragistics.Windows.Controls.ComparisonOperator.NotLike:
				return oper == global::Infragistics.Windows.Controls.ComparisonOperator.Like || oper == global::Infragistics.Windows.Controls.ComparisonOperator.NotLike;
			case global::Infragistics.Windows.Controls.ComparisonOperator.Match:
			case global::Infragistics.Windows.Controls.ComparisonOperator.DoesNotMatch:
				return oper == global::Infragistics.Windows.Controls.ComparisonOperator.Match || oper == global::Infragistics.Windows.Controls.ComparisonOperator.DoesNotMatch;
			case global::Infragistics.Windows.Controls.ComparisonOperator.StartsWith:
			case global::Infragistics.Windows.Controls.ComparisonOperator.DoesNotStartWith:
				return oper == global::Infragistics.Windows.Controls.ComparisonOperator.StartsWith || oper == global::Infragistics.Windows.Controls.ComparisonOperator.DoesNotStartWith;
			case global::Infragistics.Windows.Controls.ComparisonOperator.EndsWith:
			case global::Infragistics.Windows.Controls.ComparisonOperator.DoesNotEndWith:
				return oper == global::Infragistics.Windows.Controls.ComparisonOperator.EndsWith || oper == global::Infragistics.Windows.Controls.ComparisonOperator.DoesNotEndWith;
			case global::Infragistics.Windows.Controls.ComparisonOperator.In:
			case global::Infragistics.Windows.Controls.ComparisonOperator.NotIn:
				return oper == global::Infragistics.Windows.Controls.ComparisonOperator.In || oper == global::Infragistics.Windows.Controls.ComparisonOperator.NotIn;
			}
			return oper == condition.Operator;
		}

		// Token: 0x060014F7 RID: 5367 RVA: 0x0005D8DC File Offset: 0x0005BADC
		internal bool MeetsCriteria(global::Infragistics.Windows.DataPresenter.DataRecord record, global::Infragistics.Windows.DataPresenter.FilterConditionEvaluationContext evaluationContext)
		{
			global::Infragistics.Windows.DataPresenter.Field field = this.Field;
			if (field == null || field.Owner != record.FieldLayout)
			{
				return true;
			}
			evaluationContext.Initialize(record);
			object currentCellValueForFilterComparison = evaluationContext.CurrentCellValueForFilterComparison;
			return this._conditions == null || this._conditions.IsMatch(currentCellValueForFilterComparison, evaluationContext);
		}

		// Token: 0x060014F8 RID: 5368 RVA: 0x0005D928 File Offset: 0x0005BB28
		private void OnConditions_PropertyChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			if (this._applyingPendingFilter)
			{
				return;
			}
			if (this._isInitializing)
			{
				return;
			}
			if (e.PropertyName == "Item[]")
			{
				this.InitializeUIOperatorAndOperand(true);
			}
			if (this._parentCollection != null && e.PropertyName != "Count")
			{
				this._parentCollection.OnRecordFilterChanged(this);
			}
		}

		// Token: 0x060014F9 RID: 5369 RVA: 0x0005D986 File Offset: 0x0005BB86
		private void OnExecuteCommand(global::System.Windows.Input.ICommand command)
		{
			this._pendingCommand = null;
			if (command.CanExecute(this))
			{
				command.Execute(this);
			}
		}

		// Token: 0x060014FA RID: 5370 RVA: 0x0005D99F File Offset: 0x0005BB9F
		internal void OnFieldLayoutInitialized()
		{
			this.InitializePendingCondition();
		}

		// Token: 0x060014FB RID: 5371 RVA: 0x0005D9A7 File Offset: 0x0005BBA7
		internal void ResetUndoFilter()
		{
			if (this._filterUpdatePending)
			{
				this._undoFilter = this.Clone(true, this._parentCollection, true);
				return;
			}
			this._undoFilter = null;
		}

		// Token: 0x060014FC RID: 5372 RVA: 0x0005D9CD File Offset: 0x0005BBCD
		internal bool ShouldSerialize()
		{
			return this.HasConditions;
		}

		// Token: 0x060014FD RID: 5373 RVA: 0x0005D9D8 File Offset: 0x0005BBD8
		private void SyncFieldWithFieldName()
		{
			object obj = (this._parentCollection != null) ? this._parentCollection.Owner : null;
			global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout;
			if (obj is global::Infragistics.Windows.DataPresenter.FieldLayout)
			{
				fieldLayout = (global::Infragistics.Windows.DataPresenter.FieldLayout)obj;
			}
			else if (obj is global::Infragistics.Windows.DataPresenter.RecordManager)
			{
				if (this._field != null)
				{
					fieldLayout = this._field.Owner;
				}
				else
				{
					fieldLayout = ((global::Infragistics.Windows.DataPresenter.RecordManager)obj).FieldLayout;
				}
			}
			else
			{
				fieldLayout = null;
			}
			global::Infragistics.Windows.DataPresenter.Field field = this._field;
			global::Infragistics.Windows.DataPresenter.FieldCollection fields = global::Infragistics.Windows.DataPresenter.GridUtilities.GetFields(fieldLayout);
			if (field != null && field.Name == this._fieldName && field.Owner == fieldLayout)
			{
				return;
			}
			this._field = global::Infragistics.Windows.DataPresenter.GridUtilities.GetField(fields, this._fieldName, false);
			if (this._field != field)
			{
				base.RaisePropertyChangedEvent("Field");
				if (this._parentCollection != null)
				{
					this._parentCollection.OnRecordFilterChanged(this);
				}
				this.WireFieldTracker();
				if (this._parentCollection != null)
				{
					this._parentCollection.OnRecordFilterFieldChanged(this, field);
				}
			}
		}

		// Token: 0x060014FE RID: 5374 RVA: 0x0005DABF File Offset: 0x0005BCBF
		private void WireFieldTracker()
		{
			if (this._field != null)
			{
				this.InitializeUIOperatorAndOperand();
				if (this._field.DataPresenter != null)
				{
					this.InitializePendingCondition();
				}
			}
		}

		// Token: 0x04000880 RID: 2176
		private global::Infragistics.Windows.DataPresenter.RecordFilterCollection _parentCollection;

		// Token: 0x04000881 RID: 2177
		private global::Infragistics.Windows.Controls.ConditionGroup _conditions;

		// Token: 0x04000882 RID: 2178
		private string _fieldName;

		// Token: 0x04000883 RID: 2179
		private global::Infragistics.Windows.DataPresenter.Field _field;

		// Token: 0x04000884 RID: 2180
		private int _version;

		// Token: 0x04000885 RID: 2181
		private bool _filterUpdatePending;

		// Token: 0x04000886 RID: 2182
		private global::Infragistics.Windows.Controls.ComparisonOperator? _currentUiOperator;

		// Token: 0x04000887 RID: 2183
		private object _currentUiOperand;

		// Token: 0x04000888 RID: 2184
		private global::Infragistics.Windows.DataPresenter.FilterDropDownItem _currentFilterDropDownItem;

		// Token: 0x04000889 RID: 2185
		private bool _applyingPendingFilter;

		// Token: 0x0400088A RID: 2186
		private global::System.Windows.Input.ICommand _pendingCommand;

		// Token: 0x0400088B RID: 2187
		private global::Infragistics.Windows.Controls.ComparisonCondition _conditionPendingInitialization;

		// Token: 0x0400088C RID: 2188
		private bool _isInitializing;

		// Token: 0x0400088D RID: 2189
		private global::Infragistics.Windows.DataPresenter.RecordFilter _undoFilter;

		// Token: 0x02000162 RID: 354
		// (Invoke) Token: 0x06001500 RID: 5376
		private delegate void ExecuteCommand(global::System.Windows.Input.ICommand command);
	}
}
