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
	// Token: 0x02000145 RID: 325
	[global::System.Windows.Markup.ContentProperty("Conditions")]
	[global::System.ComponentModel.DefaultProperty("Conditions")]
	public class RecordFilter : global::Infragistics.PropertyChangeNotifier, global::System.ICloneable
	{
		// Token: 0x06001160 RID: 4448 RVA: 0x0004B17E File Offset: 0x0004937E
		public RecordFilter()
		{
		}

		// Token: 0x06001161 RID: 4449 RVA: 0x0004B186 File Offset: 0x00049386
		public RecordFilter(global::Infragistics.Windows.DataPresenter.Field field)
		{
			this.Field = field;
		}

		// Token: 0x06001162 RID: 4450 RVA: 0x0004B195 File Offset: 0x00049395
		internal RecordFilter(string fieldName)
		{
			this._fieldName = fieldName;
		}

		// Token: 0x170003F2 RID: 1010
		// (get) Token: 0x06001163 RID: 4451 RVA: 0x0004B1A4 File Offset: 0x000493A4
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

		// Token: 0x170003F3 RID: 1011
		// (get) Token: 0x06001164 RID: 4452 RVA: 0x0004B1D6 File Offset: 0x000493D6
		// (set) Token: 0x06001165 RID: 4453 RVA: 0x0004B1EC File Offset: 0x000493EC
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
					this._field = value;
					this._fieldName = ((this._field != null) ? this._field.Name : null);
					base.RaisePropertyChangedEvent("Field");
					base.RaisePropertyChangedEvent("FieldName");
					this.WireFieldTracker();
				}
			}
		}

		// Token: 0x170003F4 RID: 1012
		// (get) Token: 0x06001166 RID: 4454 RVA: 0x0004B241 File Offset: 0x00049441
		// (set) Token: 0x06001167 RID: 4455 RVA: 0x0004B249 File Offset: 0x00049449
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

		// Token: 0x170003F5 RID: 1013
		// (get) Token: 0x06001168 RID: 4456 RVA: 0x0004B271 File Offset: 0x00049471
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		public int Version
		{
			get
			{
				return this._version;
			}
		}

		// Token: 0x170003F6 RID: 1014
		// (get) Token: 0x06001169 RID: 4457 RVA: 0x0004B279 File Offset: 0x00049479
		// (set) Token: 0x0600116A RID: 4458 RVA: 0x0004B281 File Offset: 0x00049481
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

		// Token: 0x170003F7 RID: 1015
		// (get) Token: 0x0600116B RID: 4459 RVA: 0x0004B28C File Offset: 0x0004948C
		// (set) Token: 0x0600116C RID: 4460 RVA: 0x0004B2C4 File Offset: 0x000494C4
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

		// Token: 0x170003F8 RID: 1016
		// (get) Token: 0x0600116D RID: 4461 RVA: 0x0004B3CA File Offset: 0x000495CA
		// (set) Token: 0x0600116E RID: 4462 RVA: 0x0004B3D4 File Offset: 0x000495D4
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

		// Token: 0x170003F9 RID: 1017
		// (get) Token: 0x0600116F RID: 4463 RVA: 0x0004B5BA File Offset: 0x000497BA
		internal bool HasConditions
		{
			get
			{
				return this._conditions != null && this._conditions.Count > 0;
			}
		}

		// Token: 0x170003FA RID: 1018
		// (get) Token: 0x06001170 RID: 4464 RVA: 0x0004B5D4 File Offset: 0x000497D4
		internal bool HasPendingChanges
		{
			get
			{
				return this._filterUpdatePending;
			}
		}

		// Token: 0x170003FB RID: 1019
		// (get) Token: 0x06001171 RID: 4465 RVA: 0x0004B5DC File Offset: 0x000497DC
		internal bool IsInitializing
		{
			get
			{
				return this._isInitializing;
			}
		}

		// Token: 0x170003FC RID: 1020
		// (get) Token: 0x06001172 RID: 4466 RVA: 0x0004B5E4 File Offset: 0x000497E4
		internal global::Infragistics.Windows.DataPresenter.RecordFilterCollection ParentCollection
		{
			get
			{
				return this._parentCollection;
			}
		}

		// Token: 0x170003FD RID: 1021
		// (get) Token: 0x06001173 RID: 4467 RVA: 0x0004B5EC File Offset: 0x000497EC
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

		// Token: 0x06001174 RID: 4468 RVA: 0x0004B6A8 File Offset: 0x000498A8
		public void ApplyPendingFilter()
		{
			this.ApplyPendingFilter(true, true);
		}

		// Token: 0x06001175 RID: 4469 RVA: 0x0004B6B4 File Offset: 0x000498B4
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

		// Token: 0x06001176 RID: 4470 RVA: 0x0004B7B8 File Offset: 0x000499B8
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

		// Token: 0x06001177 RID: 4471 RVA: 0x0004B984 File Offset: 0x00049B84
		public void Clear()
		{
			this.Clear(false);
		}

		// Token: 0x06001178 RID: 4472 RVA: 0x0004B98D File Offset: 0x00049B8D
		internal void Clear(bool raiseEvents)
		{
			this.Clear(raiseEvents, raiseEvents);
		}

		// Token: 0x06001179 RID: 4473 RVA: 0x0004B998 File Offset: 0x00049B98
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

		// Token: 0x0600117A RID: 4474 RVA: 0x0004BA1A File Offset: 0x00049C1A
		object global::System.ICloneable.Clone()
		{
			return this.Clone(true);
		}

		// Token: 0x0600117B RID: 4475 RVA: 0x0004BA23 File Offset: 0x00049C23
		internal global::Infragistics.Windows.DataPresenter.RecordFilter Clone(bool cloneConditions)
		{
			return this.Clone(cloneConditions, this._parentCollection);
		}

		// Token: 0x0600117C RID: 4476 RVA: 0x0004BA32 File Offset: 0x00049C32
		internal global::Infragistics.Windows.DataPresenter.RecordFilter Clone(bool cloneConditions, global::Infragistics.Windows.DataPresenter.RecordFilterCollection parentCollection)
		{
			return this.Clone(cloneConditions, parentCollection, false);
		}

		// Token: 0x0600117D RID: 4477 RVA: 0x0004BA40 File Offset: 0x00049C40
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

		// Token: 0x0600117E RID: 4478 RVA: 0x0004BAFC File Offset: 0x00049CFC
		public bool MeetsCriteria(global::Infragistics.Windows.DataPresenter.DataRecord record)
		{
			global::Infragistics.Windows.DataPresenter.FilterConditionEvaluationContext evaluationContext = global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.CreateEvaluationContext(record.RecordManager, this.Field);
			return this.MeetsCriteria(record, evaluationContext);
		}

		// Token: 0x0600117F RID: 4479 RVA: 0x0004BB24 File Offset: 0x00049D24
		internal void ApplyNewConditions(global::Infragistics.Windows.Controls.ConditionGroup newGroup)
		{
			this._currentFilterDropDownItem = null;
			this.CurrentUIOperand = newGroup;
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this._parentCollection.DataPresenter;
			global::Infragistics.Windows.DataPresenter.FilterCell cell = (dataPresenter == null) ? null : (dataPresenter.ActiveCell as global::Infragistics.Windows.DataPresenter.FilterCell);
			this._parentCollection.ApplyPendingFilters(true, true, cell);
		}

		// Token: 0x06001180 RID: 4480 RVA: 0x0004BB6B File Offset: 0x00049D6B
		internal void BumpVersionNumber()
		{
			this._version++;
			base.RaisePropertyChangedEvent("Version");
		}

		// Token: 0x06001181 RID: 4481 RVA: 0x0004BB88 File Offset: 0x00049D88
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

		// Token: 0x06001182 RID: 4482 RVA: 0x0004BC90 File Offset: 0x00049E90
		internal bool HasSameValues(global::Infragistics.Windows.DataPresenter.RecordFilter other)
		{
			return other != null && object.Equals(this._filterUpdatePending, other._filterUpdatePending) && object.Equals(this._currentUiOperator, other._currentUiOperator) && object.Equals(this._currentUiOperand, other._currentUiOperand) && object.Equals(this.Conditions, other.Conditions);
		}

		// Token: 0x06001183 RID: 4483 RVA: 0x0004BD0C File Offset: 0x00049F0C
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

		// Token: 0x06001184 RID: 4484 RVA: 0x0004BD60 File Offset: 0x00049F60
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

		// Token: 0x06001185 RID: 4485 RVA: 0x0004BE20 File Offset: 0x0004A020
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

		// Token: 0x06001186 RID: 4486 RVA: 0x0004BF00 File Offset: 0x0004A100
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

		// Token: 0x06001187 RID: 4487 RVA: 0x0004BF36 File Offset: 0x0004A136
		private void InitializePendingCondition()
		{
			if (this._conditionPendingInitialization != null && this._conditions.Count == 1 && this._conditions[0] == this._conditionPendingInitialization)
			{
				this.InitializeFilterDropDownItem(this._conditionPendingInitialization);
				return;
			}
			this._conditionPendingInitialization = null;
		}

		// Token: 0x06001188 RID: 4488 RVA: 0x0004BF76 File Offset: 0x0004A176
		private void InitializeUIOperatorAndOperand()
		{
			this.InitializeUIOperatorAndOperand(false);
		}

		// Token: 0x06001189 RID: 4489 RVA: 0x0004BF80 File Offset: 0x0004A180
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

		// Token: 0x0600118A RID: 4490 RVA: 0x0004C11C File Offset: 0x0004A31C
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
			}
			return oper == condition.Operator;
		}

		// Token: 0x0600118B RID: 4491 RVA: 0x0004C1DC File Offset: 0x0004A3DC
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

		// Token: 0x0600118C RID: 4492 RVA: 0x0004C228 File Offset: 0x0004A428
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

		// Token: 0x0600118D RID: 4493 RVA: 0x0004C286 File Offset: 0x0004A486
		private void OnExecuteCommand(global::System.Windows.Input.ICommand command)
		{
			this._pendingCommand = null;
			if (command.CanExecute(this))
			{
				command.Execute(this);
			}
		}

		// Token: 0x0600118E RID: 4494 RVA: 0x0004C29F File Offset: 0x0004A49F
		internal void OnFieldLayoutInitialized()
		{
			this.InitializePendingCondition();
		}

		// Token: 0x0600118F RID: 4495 RVA: 0x0004C2A7 File Offset: 0x0004A4A7
		internal void ResetUndoFilter()
		{
			if (this._filterUpdatePending)
			{
				this._undoFilter = this.Clone(true, this._parentCollection, true);
				return;
			}
			this._undoFilter = null;
		}

		// Token: 0x06001190 RID: 4496 RVA: 0x0004C2CD File Offset: 0x0004A4CD
		internal bool ShouldSerialize()
		{
			return this.HasConditions;
		}

		// Token: 0x06001191 RID: 4497 RVA: 0x0004C2D8 File Offset: 0x0004A4D8
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
			}
		}

		// Token: 0x06001192 RID: 4498 RVA: 0x0004C3AA File Offset: 0x0004A5AA
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

		// Token: 0x040006D5 RID: 1749
		private global::Infragistics.Windows.DataPresenter.RecordFilterCollection _parentCollection;

		// Token: 0x040006D6 RID: 1750
		private global::Infragistics.Windows.Controls.ConditionGroup _conditions;

		// Token: 0x040006D7 RID: 1751
		private string _fieldName;

		// Token: 0x040006D8 RID: 1752
		private global::Infragistics.Windows.DataPresenter.Field _field;

		// Token: 0x040006D9 RID: 1753
		private int _version;

		// Token: 0x040006DA RID: 1754
		private bool _filterUpdatePending;

		// Token: 0x040006DB RID: 1755
		private global::Infragistics.Windows.Controls.ComparisonOperator? _currentUiOperator;

		// Token: 0x040006DC RID: 1756
		private object _currentUiOperand;

		// Token: 0x040006DD RID: 1757
		private global::Infragistics.Windows.DataPresenter.FilterDropDownItem _currentFilterDropDownItem;

		// Token: 0x040006DE RID: 1758
		private bool _applyingPendingFilter;

		// Token: 0x040006DF RID: 1759
		private global::System.Windows.Input.ICommand _pendingCommand;

		// Token: 0x040006E0 RID: 1760
		private global::Infragistics.Windows.Controls.ComparisonCondition _conditionPendingInitialization;

		// Token: 0x040006E1 RID: 1761
		private bool _isInitializing;

		// Token: 0x040006E2 RID: 1762
		private global::Infragistics.Windows.DataPresenter.RecordFilter _undoFilter;

		// Token: 0x02000146 RID: 326
		// (Invoke) Token: 0x06001194 RID: 4500
		private delegate void ExecuteCommand(global::System.Windows.Input.ICommand command);
	}
}
