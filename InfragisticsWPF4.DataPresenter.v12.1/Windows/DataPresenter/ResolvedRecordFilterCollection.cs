using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;
using Infragistics.Collections;
using Infragistics.Windows.Controls;
using Infragistics.Windows.DataPresenter.Events;
using Infragistics.Windows.Editors;
using Infragistics.Windows.Helpers;
using Infragistics.Windows.Internal;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000126 RID: 294
	internal class ResolvedRecordFilterCollection : global::System.Windows.DependencyObject
	{
		// Token: 0x0600100A RID: 4106 RVA: 0x00044DF0 File Offset: 0x00042FF0
		internal ResolvedRecordFilterCollection(global::Infragistics.Windows.DataPresenter.RecordManager recordManager)
		{
			global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNotNull(recordManager);
			this._recordManager = recordManager;
			this._evaluationContextCache = new global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.FilterEvaluationContextCache(this);
			global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = recordManager.FieldLayout;
			if (fieldLayout != null)
			{
				this.HookInto(fieldLayout);
			}
		}

		// Token: 0x0600100B RID: 4107 RVA: 0x00044E3C File Offset: 0x0004303C
		private void ApplyFiltersToCollectionViewHelper()
		{
			if (global::Infragistics.Windows.DataPresenter.FilterEvaluationMode.UseCollectionView == this._recordManager.FilterEvaluationModeResolved)
			{
				global::System.ComponentModel.ICollectionView collectionView = global::Infragistics.Windows.DataPresenter.VUtils.GetCollectionView(this._recordManager);
				if (collectionView != null && collectionView.CanFilter)
				{
					if (this._dataItemFilterEvaluator == null)
					{
						this._dataItemFilterEvaluator = new global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.DataItemFilterEvaluator(this, false, null);
					}
					if (global::Infragistics.CoreUtilities.Antirecursion.Enter(this._dataItemFilterEvaluator, "SettingFilter", true))
					{
						if (this.HasActiveFiltersInAnyFieldLayout())
						{
							collectionView.Filter = this._dataItemFilterEvaluator._filterPredicate;
						}
						else if (collectionView.Filter == this._dataItemFilterEvaluator._filterPredicate)
						{
							collectionView.Filter = null;
						}
						global::Infragistics.CoreUtilities.Antirecursion.Exit(this._dataItemFilterEvaluator, "SettingFilter");
					}
				}
			}
		}

		// Token: 0x0600100C RID: 4108 RVA: 0x00044EF1 File Offset: 0x000430F1
		internal void ClearCachedEvaluationContexts()
		{
			this._evaluationContextCache = new global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.FilterEvaluationContextCache(this);
		}

		// Token: 0x0600100D RID: 4109 RVA: 0x00044EFF File Offset: 0x000430FF
		internal static global::Infragistics.Windows.DataPresenter.FilterConditionEvaluationContext CreateEvaluationContext(global::Infragistics.Windows.DataPresenter.RecordManager recordManager, global::Infragistics.Windows.DataPresenter.Field field)
		{
			return global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.FilterEvaluationContextCache.CreateEvaluationContext(recordManager, field);
		}

		// Token: 0x0600100E RID: 4110 RVA: 0x00044F08 File Offset: 0x00043108
		internal bool DoesFilterCriteriaUseAllValues(global::Infragistics.Windows.DataPresenter.Field fieldContext, global::Infragistics.Windows.DataPresenter.DataRecord recordContext)
		{
			if (fieldContext != null)
			{
				return this.UsesAllValues(fieldContext);
			}
			return recordContext != null && this.UsesAllValues(recordContext);
		}

		// Token: 0x0600100F RID: 4111 RVA: 0x00044F24 File Offset: 0x00043124
		internal global::Infragistics.Windows.DataPresenter.RecordFilter GetItem(global::Infragistics.Windows.DataPresenter.Field field, bool create)
		{
			global::Infragistics.Windows.DataPresenter.FieldLayout owner = field.Owner;
			if (owner == null)
			{
				return null;
			}
			global::Infragistics.Windows.DataPresenter.RecordFilterCollection recordFilters = this.GetRecordFilters(owner, create);
			return recordFilters.GetItem(field, create);
		}

		// Token: 0x06001010 RID: 4112 RVA: 0x00044F50 File Offset: 0x00043150
		internal global::Infragistics.Windows.DataPresenter.RecordFilterCollection GetRecordFilters(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout, bool create)
		{
			if (fieldLayout != this._recordManager.FieldLayout)
			{
				this.HookInto(fieldLayout);
			}
			global::Infragistics.Windows.DataPresenter.RecordFilterScope recordFilterScopeResolved = this.GetRecordFilterScopeResolved(fieldLayout);
			if (global::Infragistics.Windows.DataPresenter.RecordFilterScope.SiblingDataRecords == recordFilterScopeResolved)
			{
				if (create)
				{
					return this._recordManager.RecordFilters;
				}
				return this._recordManager.RecordFiltersIfAllocated;
			}
			else
			{
				if (create)
				{
					return fieldLayout.RecordFilters;
				}
				return fieldLayout.RecordFiltersIfAllocated;
			}
		}

		// Token: 0x06001011 RID: 4113 RVA: 0x00044FB0 File Offset: 0x000431B0
		internal bool HasActiveFilters(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout)
		{
			global::Infragistics.Windows.DataPresenter.RecordFilterCollection recordFilters = this.GetRecordFilters(fieldLayout, false);
			if (recordFilters != null)
			{
				global::Infragistics.Windows.DataPresenter.FieldCollection fields = global::Infragistics.Windows.DataPresenter.GridUtilities.GetFields(fieldLayout);
				if (fields != null)
				{
					int i = 0;
					int count = fields.Count;
					while (i < count)
					{
						global::Infragistics.Windows.DataPresenter.Field field = fields[i];
						global::Infragistics.Windows.DataPresenter.RecordFilter item = recordFilters.GetItem(field, false);
						if (item != null && item.HasConditions)
						{
							return true;
						}
						i++;
					}
				}
			}
			return false;
		}

		// Token: 0x06001012 RID: 4114 RVA: 0x0004500C File Offset: 0x0004320C
		internal bool HasActiveFiltersInAnyFieldLayout()
		{
			foreach (global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout in this._pvtTrackers.Keys)
			{
				if (this.HasActiveFilters(fieldLayout))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06001013 RID: 4115 RVA: 0x00045068 File Offset: 0x00043268
		private void HookInto(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout)
		{
			if (!this._pvtTrackers.ContainsKey(fieldLayout))
			{
				global::Infragistics.Windows.Internal.PropertyValueTracker propertyValueTracker = new global::Infragistics.Windows.Internal.PropertyValueTracker(fieldLayout, "RecordFilters.Version", new global::Infragistics.Windows.Internal.PropertyValueTracker.PropertyValueChangedHandler(this.OnSourceFiltersChanged));
				this._pvtTrackers.Add(fieldLayout, propertyValueTracker);
				propertyValueTracker.Tag = new global::Infragistics.Windows.Internal.PropertyValueTracker(fieldLayout, "Fields.Version", new global::Infragistics.Windows.Internal.PropertyValueTracker.PropertyValueChangedHandler(this.OnFieldLayoutFieldsChanged));
				global::Infragistics.Windows.DataPresenter.RecordFilterCollection recordFiltersIfAllocated = fieldLayout.RecordFiltersIfAllocated;
				if (recordFiltersIfAllocated != null && recordFiltersIfAllocated.Version > 0)
				{
					this.BumpVersion();
				}
			}
		}

		// Token: 0x06001014 RID: 4116 RVA: 0x000450DE File Offset: 0x000432DE
		internal bool? MeetsCriteria(global::Infragistics.Windows.DataPresenter.DataRecord record)
		{
			return this.MeetsCriteria(record, null, false);
		}

		// Token: 0x06001015 RID: 4117 RVA: 0x000450EC File Offset: 0x000432EC
		private bool? MeetsCriteria(global::Infragistics.Windows.DataPresenter.DataRecord record, global::Infragistics.Windows.DataPresenter.RecordFilter ignoreFilter, bool populatingFilterDropDown)
		{
			if (this._needToVerifyRecordFilterFields)
			{
				this.VerifyRecordFilterFieldsHelper();
			}
			global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = record.FieldLayout;
			global::Infragistics.Windows.DataPresenter.RecordFilterCollection recordFilterCollection = (fieldLayout != null) ? this.GetRecordFilters(fieldLayout, false) : null;
			if (recordFilterCollection != null)
			{
				if (global::Infragistics.Windows.DataPresenter.FilterEvaluationMode.Auto != fieldLayout.FilterEvaluationModeResolved)
				{
					return null;
				}
				global::Infragistics.Windows.Controls.LogicalOperator recordFiltersLogicalOperatorResolved = fieldLayout.RecordFiltersLogicalOperatorResolved;
				global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.FilterEvaluationContextCache filterEvaluationContextCache = populatingFilterDropDown ? new global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.FilterEvaluationContextCache(this) : this._evaluationContextCache;
				bool flag = true;
				int count = recordFilterCollection.Count;
				int num = 0;
				for (int i = 0; i < count; i++)
				{
					global::Infragistics.Windows.DataPresenter.RecordFilter recordFilter = recordFilterCollection[i];
					if (recordFilter.HasConditions)
					{
						global::Infragistics.Windows.DataPresenter.Field field = recordFilter.Field;
						if (ignoreFilter != recordFilter && fieldLayout == global::Infragistics.Windows.DataPresenter.GridUtilities.GetFieldLayout(field))
						{
							global::Infragistics.Windows.DataPresenter.FilterConditionEvaluationContext cachedEvaluationContext = filterEvaluationContextCache.GetCachedEvaluationContext(field, true);
							bool flag2 = recordFilter.MeetsCriteria(record, cachedEvaluationContext);
							num++;
							filterEvaluationContextCache.MaintainCacheForUsesAllValues(cachedEvaluationContext);
							if (flag2 && global::Infragistics.Windows.Controls.LogicalOperator.Or == recordFiltersLogicalOperatorResolved)
							{
								return new bool?(true);
							}
							if (!flag2 && recordFiltersLogicalOperatorResolved == global::Infragistics.Windows.Controls.LogicalOperator.And)
							{
								return new bool?(false);
							}
							flag = (flag && flag2);
						}
					}
				}
				if (num > 0)
				{
					return new bool?(flag);
				}
			}
			return null;
		}

		// Token: 0x06001016 RID: 4118 RVA: 0x00045201 File Offset: 0x00043401
		internal void OnFieldLayoutAdded(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout)
		{
			this.HookInto(fieldLayout);
		}

		// Token: 0x06001017 RID: 4119 RVA: 0x0004520A File Offset: 0x0004340A
		private void OnFieldLayoutFieldsChanged()
		{
			if (!this._needToVerifyRecordFilterFields)
			{
				this._needToVerifyRecordFilterFields = true;
				base.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Normal, new global::Infragistics.Windows.DataPresenter.GridUtilities.MethodDelegate(this.VerifyRecordFilterFieldsHelper));
			}
		}

		// Token: 0x06001018 RID: 4120 RVA: 0x00045238 File Offset: 0x00043438
		private void VerifyRecordFilterFieldsHelper()
		{
			if (this._needToVerifyRecordFilterFields)
			{
				this._needToVerifyRecordFilterFields = false;
				bool flag = false;
				if (this._pvtTrackers != null)
				{
					foreach (global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout in this._pvtTrackers.Keys)
					{
						global::Infragistics.Windows.DataPresenter.RecordFilterCollection recordFilters = this.GetRecordFilters(fieldLayout, false);
						if (recordFilters != null && recordFilters.VerifyFields())
						{
							flag = true;
						}
					}
				}
				if (flag)
				{
					this.BumpVersion();
				}
			}
		}

		// Token: 0x06001019 RID: 4121 RVA: 0x000452BC File Offset: 0x000434BC
		internal void OnSourceFiltersChanged()
		{
			this.BumpVersion();
		}

		// Token: 0x0600101A RID: 4122 RVA: 0x000452C4 File Offset: 0x000434C4
		internal bool UsesAllValues(global::Infragistics.Windows.DataPresenter.Field field)
		{
			if (this._evaluationContextCache._hasAnyContextUsedAllValues)
			{
				global::Infragistics.Windows.DataPresenter.FilterConditionEvaluationContext cachedEvaluationContext = this._evaluationContextCache.GetCachedEvaluationContext(field, false);
				if (cachedEvaluationContext != null)
				{
					return cachedEvaluationContext.WasAllValuesUsed;
				}
			}
			return false;
		}

		// Token: 0x0600101B RID: 4123 RVA: 0x000452F7 File Offset: 0x000434F7
		internal bool UsesAllValues(global::Infragistics.Windows.DataPresenter.DataRecord record)
		{
			return this.UsesAllValues(record.FieldLayout);
		}

		// Token: 0x0600101C RID: 4124 RVA: 0x00045308 File Offset: 0x00043508
		internal bool UsesAllValues(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout)
		{
			if (this._evaluationContextCache._hasAnyContextUsedAllValues)
			{
				global::Infragistics.Windows.DataPresenter.FieldCollection fields = global::Infragistics.Windows.DataPresenter.GridUtilities.GetFields(fieldLayout);
				if (fields != null)
				{
					int i = 0;
					int count = fields.Count;
					while (i < count)
					{
						if (this.UsesAllValues(fields[i]))
						{
							return true;
						}
						i++;
					}
				}
			}
			return false;
		}

		// Token: 0x1700038B RID: 907
		internal global::Infragistics.Windows.DataPresenter.RecordFilter this[global::Infragistics.Windows.DataPresenter.Field field]
		{
			get
			{
				return this.GetItem(field, true);
			}
		}

		// Token: 0x0600101E RID: 4126 RVA: 0x0004535C File Offset: 0x0004355C
		internal global::Infragistics.Windows.DataPresenter.RecordFilterScope GetRecordFilterScopeResolved(global::Infragistics.Windows.DataPresenter.FieldLayout fl)
		{
			if (this._recordManager.IsRootManager)
			{
				return global::Infragistics.Windows.DataPresenter.RecordFilterScope.AllRecords;
			}
			global::Infragistics.Windows.DataPresenter.RecordFilterScope recordFilterScope = fl.RecordFilterScopeResolvedDefault;
			if (recordFilterScope == global::Infragistics.Windows.DataPresenter.RecordFilterScope.Default || global::Infragistics.Windows.DataPresenter.FilterEvaluationMode.UseCollectionView == fl.FilterEvaluationModeResolved)
			{
				recordFilterScope = global::Infragistics.Windows.DataPresenter.RecordFilterScope.SiblingDataRecords;
			}
			return recordFilterScope;
		}

		// Token: 0x1700038C RID: 908
		// (get) Token: 0x0600101F RID: 4127 RVA: 0x0004538E File Offset: 0x0004358E
		internal int Version
		{
			get
			{
				return this._filtersVersion;
			}
		}

		// Token: 0x06001020 RID: 4128 RVA: 0x00045396 File Offset: 0x00043596
		internal void BumpVersion()
		{
			this._filtersVersion++;
			this.ClearCachedEvaluationContexts();
			base.SetValue(global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.VersionPropertyKey, this._filtersVersion);
			this.ApplyFiltersToCollectionViewHelper();
		}

		// Token: 0x04000639 RID: 1593
		private global::Infragistics.Collections.WeakDictionary<global::Infragistics.Windows.DataPresenter.FieldLayout, global::Infragistics.Windows.Internal.PropertyValueTracker> _pvtTrackers = new global::Infragistics.Collections.WeakDictionary<global::Infragistics.Windows.DataPresenter.FieldLayout, global::Infragistics.Windows.Internal.PropertyValueTracker>(true, false);

		// Token: 0x0400063A RID: 1594
		private global::Infragistics.Windows.DataPresenter.RecordManager _recordManager;

		// Token: 0x0400063B RID: 1595
		private int _filtersVersion;

		// Token: 0x0400063C RID: 1596
		private global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.FilterEvaluationContextCache _evaluationContextCache;

		// Token: 0x0400063D RID: 1597
		private global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.DataItemFilterEvaluator _dataItemFilterEvaluator;

		// Token: 0x0400063E RID: 1598
		private bool _needToVerifyRecordFilterFields;

		// Token: 0x0400063F RID: 1599
		private static readonly global::System.Windows.DependencyPropertyKey VersionPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("Version", typeof(int), typeof(global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection), new global::System.Windows.FrameworkPropertyMetadata(0, global::System.Windows.FrameworkPropertyMetadataOptions.None));

		// Token: 0x04000640 RID: 1600
		internal static readonly global::System.Windows.DependencyProperty VersionProperty = global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.VersionPropertyKey.DependencyProperty;

		// Token: 0x02000127 RID: 295
		private class DataItemFilterEvaluator
		{
			// Token: 0x06001022 RID: 4130 RVA: 0x00045408 File Offset: 0x00043608
			internal DataItemFilterEvaluator(global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection coll, bool populatingFilterDropDown, global::Infragistics.Windows.DataPresenter.RecordFilter ignoreFilter)
			{
				this._coll = coll;
				this._populatingFilterDropDown = populatingFilterDropDown;
				this._ignoreFilter = ignoreFilter;
				this._filterPredicate = new global::System.Predicate<object>(new global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.DataItemFilterEvaluator.WeakPredicateHelper(this).FilterDataItem);
			}

			// Token: 0x06001023 RID: 4131 RVA: 0x0004543C File Offset: 0x0004363C
			private void EnsurePropertyDescriptor(object dataItem, global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.DataItemFilterEvaluator.EvaluationContext context)
			{
				if (context._propertyDescriptor == null)
				{
					global::System.ComponentModel.ICollectionView collectionView = global::Infragistics.Windows.DataPresenter.VUtils.GetCollectionView(this._coll._recordManager);
					global::Infragistics.Windows.Internal.PropertyDescriptorProvider propertyDescriptorProvider;
					if ((propertyDescriptorProvider = this._cachedPropertyDescriptorProvider) == null)
					{
						propertyDescriptorProvider = (this._cachedPropertyDescriptorProvider = global::Infragistics.Windows.Internal.PropertyDescriptorProvider.CreateProvider(dataItem, collectionView));
					}
					global::Infragistics.Windows.Internal.PropertyDescriptorProvider propertyDescriptorProvider2 = propertyDescriptorProvider;
					if (propertyDescriptorProvider2 != null)
					{
						global::System.ComponentModel.PropertyDescriptorCollection properties = propertyDescriptorProvider2.GetProperties();
						context._propertyDescriptor = properties[global::Infragistics.Windows.DataPresenter.VUtils.GetPropertyName(context._field)];
					}
				}
			}

			// Token: 0x06001024 RID: 4132 RVA: 0x000454A0 File Offset: 0x000436A0
			internal bool FilterDataItem(object dataItem)
			{
				global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = this._coll._recordManager.FieldLayout;
				global::Infragistics.Windows.DataPresenter.RecordFilterCollection recordFilterCollection = (fieldLayout != null) ? this._coll.GetRecordFilters(fieldLayout, false) : null;
				if (recordFilterCollection != null)
				{
					global::Infragistics.Windows.Controls.LogicalOperator recordFiltersLogicalOperatorResolved = fieldLayout.RecordFiltersLogicalOperatorResolved;
					bool flag = true;
					int count = recordFilterCollection.Count;
					int num = 0;
					for (int i = 0; i < count; i++)
					{
						global::Infragistics.Windows.DataPresenter.RecordFilter recordFilter = recordFilterCollection[i];
						if (recordFilter.HasConditions)
						{
							global::Infragistics.Windows.DataPresenter.Field field = recordFilter.Field;
							if (this._ignoreFilter != recordFilter && fieldLayout == global::Infragistics.Windows.DataPresenter.GridUtilities.GetFieldLayout(field))
							{
								global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.DataItemFilterEvaluator.EvaluationContext evaluationContext = this.GetEvaluationContext(field);
								this.EnsurePropertyDescriptor(dataItem, evaluationContext);
								object cellValueHelper = evaluationContext.GetCellValueHelper(dataItem);
								evaluationContext.InitializeCurrentValue(dataItem, cellValueHelper);
								bool flag2 = recordFilter.Conditions.IsMatch(cellValueHelper, evaluationContext);
								num++;
								if (flag2 && global::Infragistics.Windows.Controls.LogicalOperator.Or == recordFiltersLogicalOperatorResolved)
								{
									return true;
								}
								if (!flag2 && recordFiltersLogicalOperatorResolved == global::Infragistics.Windows.Controls.LogicalOperator.And)
								{
									return false;
								}
								flag = (flag && flag2);
							}
						}
					}
					if (num > 0)
					{
						return flag;
					}
				}
				return true;
			}

			// Token: 0x06001025 RID: 4133 RVA: 0x00045598 File Offset: 0x00043798
			private global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.DataItemFilterEvaluator.EvaluationContext GetEvaluationContext(global::Infragistics.Windows.DataPresenter.Field field)
			{
				if (this._evaluationContexts == null)
				{
					this._evaluationContexts = new global::Infragistics.Collections.WeakDictionary<global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.DataItemFilterEvaluator.EvaluationContext>(true, false);
				}
				global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.DataItemFilterEvaluator.EvaluationContext evaluationContext;
				if (!this._evaluationContexts.TryGetValue(field, out evaluationContext))
				{
					evaluationContext = new global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.DataItemFilterEvaluator.EvaluationContext(this._coll._recordManager, field);
					this._evaluationContexts[field] = evaluationContext;
				}
				return evaluationContext;
			}

			// Token: 0x04000641 RID: 1601
			private readonly global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection _coll;

			// Token: 0x04000642 RID: 1602
			private readonly bool _populatingFilterDropDown;

			// Token: 0x04000643 RID: 1603
			private global::Infragistics.Collections.WeakDictionary<global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.DataItemFilterEvaluator.EvaluationContext> _evaluationContexts;

			// Token: 0x04000644 RID: 1604
			private global::Infragistics.Windows.DataPresenter.RecordFilter _ignoreFilter;

			// Token: 0x04000645 RID: 1605
			private global::Infragistics.Windows.Internal.PropertyDescriptorProvider _cachedPropertyDescriptorProvider;

			// Token: 0x04000646 RID: 1606
			internal readonly global::System.Predicate<object> _filterPredicate;

			// Token: 0x02000128 RID: 296
			internal class EvaluationContext : global::Infragistics.Windows.Controls.ConditionEvaluationContext
			{
				// Token: 0x06001026 RID: 4134 RVA: 0x000455EC File Offset: 0x000437EC
				internal EvaluationContext(global::Infragistics.Windows.DataPresenter.RecordManager recordManager, global::Infragistics.Windows.DataPresenter.Field field)
				{
					this._recordManager = recordManager;
					this._field = field;
					this._culture = global::Infragistics.Windows.DataPresenter.GridUtilities.GetDefaultCulture(field);
					global::System.Type type = this._field.EditAsTypeResolved;
					if (typeof(string) == type)
					{
						type = null;
					}
					this._prefComparisonType = type;
				}

				// Token: 0x1700038D RID: 909
				// (get) Token: 0x06001027 RID: 4135 RVA: 0x00045658 File Offset: 0x00043858
				public override global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.Controls.ValueEntry> AllValues
				{
					get
					{
						global::System.Collections.IEnumerable collectionViewSourceItems = global::Infragistics.Windows.DataPresenter.VUtils.GetCollectionViewSourceItems(this._recordManager);
						global::System.Collections.Generic.IEnumerable<object> source = (collectionViewSourceItems as global::System.Collections.Generic.IEnumerable<object>) ?? new global::Infragistics.Collections.TypedEnumerable<object>(collectionViewSourceItems);
						return from dataItem in source
						select new global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.DataItemFilterEvaluator.EvaluationContext.ContextValueEntry(this.GetCellValueHelper(dataItem), this);
					}
				}

				// Token: 0x1700038E RID: 910
				// (get) Token: 0x06001028 RID: 4136 RVA: 0x00045694 File Offset: 0x00043894
				public override global::System.Collections.IComparer Comparer
				{
					get
					{
						return this._field.FilterComparerResolved ?? base.Comparer;
					}
				}

				// Token: 0x1700038F RID: 911
				// (get) Token: 0x06001029 RID: 4137 RVA: 0x000456AB File Offset: 0x000438AB
				public override global::Infragistics.Windows.Controls.ValueEntry CurrentValue
				{
					get
					{
						return this._currentValue;
					}
				}

				// Token: 0x17000390 RID: 912
				// (get) Token: 0x0600102A RID: 4138 RVA: 0x000456B3 File Offset: 0x000438B3
				public override bool IgnoreCase
				{
					get
					{
						return this._ignoreCase;
					}
				}

				// Token: 0x0600102B RID: 4139 RVA: 0x000456BB File Offset: 0x000438BB
				public void SetIgnoreCase(bool val)
				{
					this._ignoreCase = val;
				}

				// Token: 0x0600102C RID: 4140 RVA: 0x000456C4 File Offset: 0x000438C4
				public void InitializeCurrentValue(object dataItem, object value)
				{
					this._currentDataItem = dataItem;
					this._currentValue = new global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.DataItemFilterEvaluator.EvaluationContext.ContextValueEntry(value, this);
				}

				// Token: 0x17000391 RID: 913
				// (get) Token: 0x0600102D RID: 4141 RVA: 0x000456DA File Offset: 0x000438DA
				public override global::System.Type PreferredComparisonDataType
				{
					get
					{
						return this._prefComparisonType;
					}
				}

				// Token: 0x0600102E RID: 4142 RVA: 0x000456E2 File Offset: 0x000438E2
				internal object GetCellValueHelper(object dataItem)
				{
					return this._propertyDescriptor.GetValue(dataItem);
				}

				// Token: 0x04000647 RID: 1607
				internal readonly global::Infragistics.Windows.DataPresenter.RecordManager _recordManager;

				// Token: 0x04000648 RID: 1608
				internal readonly global::Infragistics.Windows.DataPresenter.Field _field;

				// Token: 0x04000649 RID: 1609
				internal global::System.ComponentModel.PropertyDescriptor _propertyDescriptor;

				// Token: 0x0400064A RID: 1610
				internal object _currentDataItem;

				// Token: 0x0400064B RID: 1611
				internal global::System.Globalization.CultureInfo _culture;

				// Token: 0x0400064C RID: 1612
				private global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.DataItemFilterEvaluator.EvaluationContext.ContextValueEntry _currentValue;

				// Token: 0x0400064D RID: 1613
				private global::System.Type _prefComparisonType;

				// Token: 0x0400064E RID: 1614
				private bool _ignoreCase = true;

				// Token: 0x02000129 RID: 297
				internal class ContextValueEntry : global::Infragistics.Windows.Controls.ValueEntry
				{
					// Token: 0x06001030 RID: 4144 RVA: 0x000456F0 File Offset: 0x000438F0
					internal ContextValueEntry(object value, global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.DataItemFilterEvaluator.EvaluationContext context)
					{
						this._context = context;
						this._value = value;
					}

					// Token: 0x17000392 RID: 914
					// (get) Token: 0x06001031 RID: 4145 RVA: 0x00045706 File Offset: 0x00043906
					public override object Context
					{
						get
						{
							return this._context._currentDataItem;
						}
					}

					// Token: 0x17000393 RID: 915
					// (get) Token: 0x06001032 RID: 4146 RVA: 0x00045713 File Offset: 0x00043913
					public override global::System.Globalization.CultureInfo Culture
					{
						get
						{
							return this._context._culture;
						}
					}

					// Token: 0x17000394 RID: 916
					// (get) Token: 0x06001033 RID: 4147 RVA: 0x00045720 File Offset: 0x00043920
					public override string Format
					{
						get
						{
							return null;
						}
					}

					// Token: 0x17000395 RID: 917
					// (get) Token: 0x06001034 RID: 4148 RVA: 0x00045723 File Offset: 0x00043923
					public override object Value
					{
						get
						{
							return this._value;
						}
					}

					// Token: 0x0400064F RID: 1615
					private global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.DataItemFilterEvaluator.EvaluationContext _context;

					// Token: 0x04000650 RID: 1616
					private object _value;
				}
			}

			// Token: 0x0200012A RID: 298
			internal class WeakPredicateHelper
			{
				// Token: 0x06001035 RID: 4149 RVA: 0x0004572B File Offset: 0x0004392B
				internal WeakPredicateHelper(global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.DataItemFilterEvaluator evaluator)
				{
					this._evaluator = new global::System.WeakReference(evaluator);
				}

				// Token: 0x06001036 RID: 4150 RVA: 0x00045740 File Offset: 0x00043940
				internal bool FilterDataItem(object dataItem)
				{
					if (this._evaluator != null)
					{
						global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.DataItemFilterEvaluator dataItemFilterEvaluator = (global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.DataItemFilterEvaluator)global::Infragistics.CoreUtilities.GetWeakReferenceTargetSafe(this._evaluator);
						if (dataItemFilterEvaluator != null)
						{
							return dataItemFilterEvaluator.FilterDataItem(dataItem);
						}
						this._evaluator = null;
					}
					return true;
				}

				// Token: 0x04000651 RID: 1617
				private global::System.WeakReference _evaluator;
			}
		}

		// Token: 0x0200012B RID: 299
		internal class FieldFilterInfo : global::Infragistics.PropertyChangeNotifier
		{
			// Token: 0x06001037 RID: 4151 RVA: 0x0004577C File Offset: 0x0004397C
			internal FieldFilterInfo(global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection filters, global::Infragistics.Windows.DataPresenter.Field field)
			{
				global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNotNull(filters);
				global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNotNull(field);
				this._filters = filters;
				this._field = field;
				this._recordManager = filters._recordManager;
				global::Infragistics.Windows.Internal.PropertyValueTracker propertyValueTracker = (global::Infragistics.Windows.Internal.PropertyValueTracker)(this._pvtList = new global::Infragistics.Windows.Internal.PropertyValueTracker(filters, global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.VersionProperty, new global::Infragistics.Windows.Internal.PropertyValueTracker.PropertyValueChangedHandler(this.OnFiltersChanged))).Tag;
			}

			// Token: 0x17000396 RID: 918
			// (get) Token: 0x06001038 RID: 4152 RVA: 0x000457E0 File Offset: 0x000439E0
			public bool HasActiveFilters
			{
				get
				{
					this.VerifyHasActiveFilters();
					return this._cachedHasActiveFilters;
				}
			}

			// Token: 0x17000397 RID: 919
			// (get) Token: 0x06001039 RID: 4153 RVA: 0x000457EE File Offset: 0x000439EE
			public global::Infragistics.Windows.DataPresenter.RecordFilter RecordFilter
			{
				get
				{
					this.VerifyRecordFilter();
					return this._cachedRecordFilter;
				}
			}

			// Token: 0x0600103A RID: 4154 RVA: 0x000457FC File Offset: 0x000439FC
			private void VerifyRecordFilter()
			{
				global::Infragistics.Windows.DataPresenter.RecordFilter cachedRecordFilter = this._cachedRecordFilter;
				this._cachedRecordFilter = ((this._field.Index < 0 && cachedRecordFilter != null) ? cachedRecordFilter : this._filters.GetItem(this._field, true));
				if (cachedRecordFilter != this._cachedRecordFilter)
				{
					base.RaisePropertyChangedEvent("RecordFilter");
					this.VerifyHasActiveFilters();
				}
				int num = (this._cachedRecordFilter != null) ? this._cachedRecordFilter.Version : -1;
				if (num != this._cachedFilterVersion)
				{
					this._cachedFilterVersion = num;
					base.RaisePropertyChangedEvent("RecordFilterVersion");
				}
			}

			// Token: 0x17000398 RID: 920
			// (get) Token: 0x0600103B RID: 4155 RVA: 0x00045888 File Offset: 0x00043A88
			internal global::Infragistics.Windows.DataPresenter.Field Field
			{
				get
				{
					return this._field;
				}
			}

			// Token: 0x17000399 RID: 921
			// (get) Token: 0x0600103C RID: 4156 RVA: 0x00045890 File Offset: 0x00043A90
			internal global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection Filters
			{
				get
				{
					return this._filters;
				}
			}

			// Token: 0x1700039A RID: 922
			// (get) Token: 0x0600103D RID: 4157 RVA: 0x00045898 File Offset: 0x00043A98
			internal global::Infragistics.Windows.DataPresenter.RecordManager RecordManager
			{
				get
				{
					return this._recordManager;
				}
			}

			// Token: 0x0600103E RID: 4158 RVA: 0x000458A0 File Offset: 0x00043AA0
			private void OnFiltersChanged()
			{
				this.VerifyRecordFilter();
				this.VerifyHasActiveFilters();
			}

			// Token: 0x0600103F RID: 4159 RVA: 0x000458B0 File Offset: 0x00043AB0
			private void VerifyHasActiveFilters()
			{
				bool cachedHasActiveFilters = this._cachedHasActiveFilters;
				global::Infragistics.Windows.DataPresenter.RecordFilter recordFilter = this.RecordFilter;
				this._cachedHasActiveFilters = (recordFilter != null && recordFilter.HasConditions);
				if (cachedHasActiveFilters != this._cachedHasActiveFilters)
				{
					base.RaisePropertyChangedEvent("HasActiveFilters");
				}
			}

			// Token: 0x04000652 RID: 1618
			private global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection _filters;

			// Token: 0x04000653 RID: 1619
			private global::Infragistics.Windows.DataPresenter.Field _field;

			// Token: 0x04000654 RID: 1620
			private global::Infragistics.Windows.DataPresenter.RecordManager _recordManager;

			// Token: 0x04000655 RID: 1621
			private global::Infragistics.Windows.Internal.PropertyValueTracker _pvtList;

			// Token: 0x04000656 RID: 1622
			private global::Infragistics.Windows.DataPresenter.RecordFilter _cachedRecordFilter;

			// Token: 0x04000657 RID: 1623
			private bool _cachedHasActiveFilters;

			// Token: 0x04000658 RID: 1624
			private int _cachedFilterVersion;

			// Token: 0x0200012C RID: 300
			internal class FilterDropDownItemComparer : global::System.Collections.Generic.IComparer<global::Infragistics.Windows.DataPresenter.FilterDropDownItem>
			{
				// Token: 0x06001040 RID: 4160 RVA: 0x000458F1 File Offset: 0x00043AF1
				internal FilterDropDownItemComparer(global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.FieldFilterInfo info)
				{
					this._fieldSortInfo = new global::Infragistics.Windows.DataPresenter.RecordManager.SameFieldRecordsSortComparer.FieldSortInfo(info._field);
				}

				// Token: 0x06001041 RID: 4161 RVA: 0x0004590C File Offset: 0x00043B0C
				public int Compare(global::Infragistics.Windows.DataPresenter.FilterDropDownItem x, global::Infragistics.Windows.DataPresenter.FilterDropDownItem y)
				{
					global::System.Collections.IComparer comparer = this._fieldSortInfo._comparer;
					if (comparer != null)
					{
						return comparer.Compare(x.Value, y.Value);
					}
					global::Infragistics.Windows.DataPresenter.RecordManager.SameFieldRecordsSortComparer.CellInfo cellInfo = x._cellInfo;
					global::Infragistics.Windows.DataPresenter.RecordManager.SameFieldRecordsSortComparer.CellInfo cellInfo2 = y._cellInfo;
					return global::Infragistics.Windows.DataPresenter.RecordManager.SameFieldRecordsSortComparer.DefaultCompare(cellInfo.GetCompareValue(), cellInfo2.GetCompareValue(), this._fieldSortInfo._field);
				}

				// Token: 0x04000659 RID: 1625
				internal global::Infragistics.Windows.DataPresenter.RecordManager.SameFieldRecordsSortComparer.FieldSortInfo _fieldSortInfo;
			}

			// Token: 0x0200012D RID: 301
			public class MeetsCriteria_Filter : global::Infragistics.Windows.DataPresenter.GridUtilities.IMeetsCriteria
			{
				// Token: 0x06001042 RID: 4162 RVA: 0x00045965 File Offset: 0x00043B65
				public MeetsCriteria_Filter(global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.FieldFilterInfo info, bool includeFilteredOutValues, global::Infragistics.Windows.DataPresenter.RecordFilter ignoreFilter)
				{
					this._info = info;
					this._includeFilteredOutValues = includeFilteredOutValues;
					this._ignoreFilter = ignoreFilter;
				}

				// Token: 0x06001043 RID: 4163 RVA: 0x00045984 File Offset: 0x00043B84
				public bool MeetsCriteria(object recordObj)
				{
					global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = recordObj as global::Infragistics.Windows.DataPresenter.DataRecord;
					if (dataRecord != null)
					{
						global::System.Windows.Visibility visibilityResolved_NoFiltering = dataRecord.VisibilityResolved_NoFiltering;
						if (visibilityResolved_NoFiltering != global::System.Windows.Visibility.Visible)
						{
							return false;
						}
						if (this._includeFilteredOutValues || !dataRecord.InternalIsFilteredOut_Verify)
						{
							return true;
						}
						if (this._ignoreFilter != null && this._ignoreFilter.HasConditions && (dataRecord.RecordManager.RecordFiltersResolved.MeetsCriteria(dataRecord, this._ignoreFilter, true) ?? true))
						{
							return true;
						}
					}
					return false;
				}

				// Token: 0x0400065A RID: 1626
				private global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.FieldFilterInfo _info;

				// Token: 0x0400065B RID: 1627
				private bool _includeFilteredOutValues;

				// Token: 0x0400065C RID: 1628
				private global::Infragistics.Windows.DataPresenter.RecordFilter _ignoreFilter;
			}
		}

		// Token: 0x0200012E RID: 302
		private class FilterEvaluationContextCache
		{
			// Token: 0x06001044 RID: 4164 RVA: 0x00045A01 File Offset: 0x00043C01
			internal FilterEvaluationContextCache(global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection info)
			{
				this._info = info;
			}

			// Token: 0x06001045 RID: 4165 RVA: 0x00045A10 File Offset: 0x00043C10
			internal static global::Infragistics.Windows.DataPresenter.FilterConditionEvaluationContext CreateEvaluationContext(global::Infragistics.Windows.DataPresenter.RecordManager recordManager, global::Infragistics.Windows.DataPresenter.Field field)
			{
				global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.DataRecord> allValuesRecords = global::Infragistics.Windows.DataPresenter.GridUtilities.Filter<global::Infragistics.Windows.DataPresenter.DataRecord>(recordManager.Unsorted, new global::Infragistics.Windows.DataPresenter.GridUtilities.MeetsCriteria_RecordVisible(true));
				return new global::Infragistics.Windows.DataPresenter.FilterConditionEvaluationContext(field, allValuesRecords);
			}

			// Token: 0x06001046 RID: 4166 RVA: 0x00045A38 File Offset: 0x00043C38
			internal global::Infragistics.Windows.DataPresenter.FilterConditionEvaluationContext GetCachedEvaluationContext(global::Infragistics.Windows.DataPresenter.Field field, bool create)
			{
				global::Infragistics.Windows.DataPresenter.FilterConditionEvaluationContext filterConditionEvaluationContext = null;
				if (this._cachedEvaluationContexts != null && this._cachedEvaluationContexts.TryGetValue(field, out filterConditionEvaluationContext))
				{
					return filterConditionEvaluationContext;
				}
				if (create)
				{
					if (this._cachedEvaluationContexts == null)
					{
						this._cachedEvaluationContexts = new global::Infragistics.Collections.WeakDictionary<global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.FilterConditionEvaluationContext>(true, false);
					}
					filterConditionEvaluationContext = global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.FilterEvaluationContextCache.CreateEvaluationContext(this._info._recordManager, field);
					this._cachedEvaluationContexts[field] = filterConditionEvaluationContext;
				}
				return filterConditionEvaluationContext;
			}

			// Token: 0x06001047 RID: 4167 RVA: 0x00045A99 File Offset: 0x00043C99
			internal void MaintainCacheForUsesAllValues(global::Infragistics.Windows.DataPresenter.FilterConditionEvaluationContext context)
			{
				if (context.WasAllValuesUsed)
				{
					this._hasAnyContextUsedAllValues = true;
				}
			}

			// Token: 0x0400065D RID: 1629
			private global::Infragistics.Collections.WeakDictionary<global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.FilterConditionEvaluationContext> _cachedEvaluationContexts;

			// Token: 0x0400065E RID: 1630
			private global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection _info;

			// Token: 0x0400065F RID: 1631
			internal bool _hasAnyContextUsedAllValues;
		}

		// Token: 0x0200012F RID: 303
		internal class FilterDropDownItemLoader
		{
			// Token: 0x06001048 RID: 4168 RVA: 0x00045AAC File Offset: 0x00043CAC
			internal FilterDropDownItemLoader(global::Infragistics.Windows.Editors.XamComboEditor editor, global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.FieldFilterInfo filterInfo, global::Infragistics.Collections.ObservableCollectionExtended<global::Infragistics.Windows.DataPresenter.FilterDropDownItem> items, bool forCustomFilterSelectionControl)
			{
				this._editor = editor;
				this._items = items;
				this._forCustomFilterSelectionControl = forCustomFilterSelectionControl;
				this._filterInfo = filterInfo;
				this._uniqueCellValues = new global::Infragistics.Windows.Helpers.HashSet();
				if (items == null)
				{
					this._rootMenuItem = new global::Infragistics.Windows.DataPresenter.FieldMenuDataItem();
				}
			}

			// Token: 0x1400005C RID: 92
			// (add) Token: 0x06001049 RID: 4169 RVA: 0x00045B28 File Offset: 0x00043D28
			// (remove) Token: 0x0600104A RID: 4170 RVA: 0x00045B60 File Offset: 0x00043D60
			internal event global::System.EventHandler Phase1Completed;

			// Token: 0x0600104B RID: 4171 RVA: 0x00045B98 File Offset: 0x00043D98
			private void RaisePhase1Completed()
			{
				global::System.EventHandler phase1Completed = this.Phase1Completed;
				if (phase1Completed != null)
				{
					phase1Completed(this, global::System.EventArgs.Empty);
				}
			}

			// Token: 0x1400005D RID: 93
			// (add) Token: 0x0600104C RID: 4172 RVA: 0x00045BBC File Offset: 0x00043DBC
			// (remove) Token: 0x0600104D RID: 4173 RVA: 0x00045BF4 File Offset: 0x00043DF4
			internal event global::System.EventHandler Phase2Completed;

			// Token: 0x0600104E RID: 4174 RVA: 0x00045C2C File Offset: 0x00043E2C
			private void RaisePhase2Completed()
			{
				int num = (this._phase2Items != null) ? this._phase2Items.Count : 0;
				for (int i = 0; i < num; i++)
				{
					this._phase2Items[i]._cellInfo = null;
				}
				if (this._timer != null)
				{
					this._timer.Stop();
					this._timer = null;
					if (this._editor != null)
					{
						this._editor.ClearValue(global::Infragistics.Windows.Editors.XamComboEditor.PostDropDownAreaTemplateProperty);
					}
				}
				if (this.Phase2Completed != null)
				{
					this.Phase2Completed(this, global::System.EventArgs.Empty);
				}
			}

			// Token: 0x1400005E RID: 94
			// (add) Token: 0x0600104F RID: 4175 RVA: 0x00045CBC File Offset: 0x00043EBC
			// (remove) Token: 0x06001050 RID: 4176 RVA: 0x00045CF4 File Offset: 0x00043EF4
			internal event global::System.EventHandler Phase2Updated;

			// Token: 0x06001051 RID: 4177 RVA: 0x00045D2C File Offset: 0x00043F2C
			private void RaisePhase2Updated()
			{
				global::System.EventHandler phase2Updated = this.Phase2Updated;
				if (phase2Updated != null)
				{
					phase2Updated(this, global::System.EventArgs.Empty);
				}
			}

			// Token: 0x1700039B RID: 923
			// (get) Token: 0x06001052 RID: 4178 RVA: 0x00045D4F File Offset: 0x00043F4F
			internal bool Aborted
			{
				get
				{
					return this._aborted;
				}
			}

			// Token: 0x1700039C RID: 924
			// (get) Token: 0x06001053 RID: 4179 RVA: 0x00045D57 File Offset: 0x00043F57
			// (set) Token: 0x06001054 RID: 4180 RVA: 0x00045D60 File Offset: 0x00043F60
			internal global::Infragistics.Windows.Editors.XamComboEditor Editor
			{
				get
				{
					return this._editor;
				}
				set
				{
					if (value != this._editor)
					{
						if (this._editor != null)
						{
							this._editor.ClearValue(global::Infragistics.Windows.Editors.XamComboEditor.PostDropDownAreaTemplateProperty);
						}
						this._editor = value;
						if (this._editor != null && !this._endReached && !this._aborted)
						{
							this._editor.SetResourceReference(global::Infragistics.Windows.Editors.XamComboEditor.PostDropDownAreaTemplateProperty, global::Infragistics.Windows.DataPresenter.DataPresenterBase.FilterDropDownLoadingTemplateKey);
						}
					}
				}
			}

			// Token: 0x1700039D RID: 925
			// (get) Token: 0x06001055 RID: 4181 RVA: 0x00045DC2 File Offset: 0x00043FC2
			internal bool EndReached
			{
				get
				{
					return this._endReached;
				}
			}

			// Token: 0x1700039E RID: 926
			// (get) Token: 0x06001056 RID: 4182 RVA: 0x00045DCA File Offset: 0x00043FCA
			internal global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.FieldFilterInfo FilterInfo
			{
				get
				{
					return this._filterInfo;
				}
			}

			// Token: 0x1700039F RID: 927
			// (get) Token: 0x06001057 RID: 4183 RVA: 0x00045DD2 File Offset: 0x00043FD2
			internal bool HasNullValues
			{
				get
				{
					return this._hasNullValues;
				}
			}

			// Token: 0x170003A0 RID: 928
			// (get) Token: 0x06001058 RID: 4184 RVA: 0x00045DDA File Offset: 0x00043FDA
			internal global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.FilterDropDownItem> Phase2Items
			{
				get
				{
					return this._phase2Items;
				}
			}

			// Token: 0x170003A1 RID: 929
			// (get) Token: 0x06001059 RID: 4185 RVA: 0x00045DE2 File Offset: 0x00043FE2
			internal global::Infragistics.Windows.DataPresenter.FieldMenuDataItem RootMenuItem
			{
				get
				{
					return this._rootMenuItem;
				}
			}

			// Token: 0x170003A2 RID: 930
			// (get) Token: 0x0600105A RID: 4186 RVA: 0x00045DEA File Offset: 0x00043FEA
			internal bool UniqueValuesLoadPending
			{
				get
				{
					return this._uniqueValuesLoadPending;
				}
			}

			// Token: 0x0600105B RID: 4187 RVA: 0x00045DF2 File Offset: 0x00043FF2
			internal void Abort()
			{
				this._aborted = true;
				this.RaisePhase2Completed();
			}

			// Token: 0x0600105C RID: 4188 RVA: 0x00045E04 File Offset: 0x00044004
			internal void PopulatePhase1()
			{
				if (this._rootMenuItem != null)
				{
					this.InitializeFilterMenuItems();
				}
				else
				{
					this._phase1Items = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.FilterDropDownItem>();
					this.GetFilterDropDownSpecialItems(this._phase1Items, this._forCustomFilterSelectionControl);
				}
				global::Infragistics.Windows.DataPresenter.FieldLayout owner = this._filterInfo.Field.Owner;
				global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenterBase = (owner != null) ? owner.DataPresenter : null;
				global::Infragistics.Windows.DataPresenter.Events.RecordFilterDropDownPopulatingEventArgs recordFilterDropDownPopulatingEventArgs;
				if (this._rootMenuItem == null)
				{
					recordFilterDropDownPopulatingEventArgs = new global::Infragistics.Windows.DataPresenter.Events.RecordFilterDropDownPopulatingEventArgs(this._filterInfo.Field, this._filterInfo.RecordManager, this._phase1Items, true, this._forCustomFilterSelectionControl);
				}
				else
				{
					recordFilterDropDownPopulatingEventArgs = new global::Infragistics.Windows.DataPresenter.Events.RecordFilterDropDownPopulatingEventArgs(this._filterInfo.Field, this._filterInfo.RecordManager, this._rootMenuItem.Items, true, this._forCustomFilterSelectionControl);
				}
				if (dataPresenterBase != null)
				{
					dataPresenterBase.RaiseRecordFilterDropDownPopulating(recordFilterDropDownPopulatingEventArgs);
					this._uniqueValuesLoadPending = recordFilterDropDownPopulatingEventArgs.IncludeUniqueValues;
					this._asynchLoadDuration = recordFilterDropDownPopulatingEventArgs.AsynchLoadDuration;
					this._asynchLoadInterval = recordFilterDropDownPopulatingEventArgs.AsynchLoadInterval;
					this._asynchLoadThreshhold = recordFilterDropDownPopulatingEventArgs.AsynchLoadThreshhold;
					if (!this._uniqueValuesLoadPending && this._rootMenuItem != null)
					{
						this.RemoveTreeMenuItem();
					}
				}
				else
				{
					this._uniqueValuesLoadPending = true;
				}
				if (this._items != null && this._phase1Items != null)
				{
					this._items.ReInitialize(this._phase1Items);
				}
				this.RaisePhase1Completed();
			}

			// Token: 0x0600105D RID: 4189 RVA: 0x00045F40 File Offset: 0x00044140
			internal void PopulatePhase2(bool includeFilteredOutValues)
			{
				if (this._phase1Items == null && this._rootMenuItem == null)
				{
					this.PopulatePhase1();
				}
				this._cellTextConverter = global::Infragistics.Windows.DataPresenter.CellTextConverterInfo.GetCachedConverter(this._filterInfo.Field);
				if (this._uniqueValuesLoadPending && this._filterInfo != null && !this._filterInfo.Field.IsUnbound && global::Infragistics.Windows.DataPresenter.FilterEvaluationMode.UseCollectionView == this._filterInfo.Field.Owner.FilterEvaluationModeResolved)
				{
					global::Infragistics.Windows.DataPresenter.LinqQueryManager linqQueryManager = global::Infragistics.Windows.DataPresenter.VUtils.CreateLinqQueryManager(this._filterInfo.RecordManager, true);
					if (linqQueryManager != null)
					{
						global::Infragistics.Windows.DataPresenter.LinqQueryManager.LinqInstructionSelect innerStatement = new global::Infragistics.Windows.DataPresenter.LinqQueryManager.LinqInstructionSelect(global::Infragistics.Windows.DataPresenter.VUtils.GetPropertyName(this._filterInfo.Field), null);
						global::Infragistics.Windows.DataPresenter.LinqQueryManager.LinqInstructionDistinct innerStatement2 = new global::Infragistics.Windows.DataPresenter.LinqQueryManager.LinqInstructionDistinct(innerStatement);
						global::Infragistics.Windows.DataPresenter.LinqQueryManager.LinqInstructionOrderBy linqQuery = new global::Infragistics.Windows.DataPresenter.LinqQueryManager.LinqInstructionOrderBy(null, innerStatement2, false);
						global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.DataItemFilterEvaluator @object = new global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.DataItemFilterEvaluator(this._filterInfo.Filters, true, this._filterInfo.RecordFilter);
						global::System.Collections.IEnumerable enumerable = linqQueryManager.List;
						if (!includeFilteredOutValues)
						{
							enumerable = ((enumerable as global::System.Collections.Generic.IEnumerable<object>) ?? new global::Infragistics.Collections.TypedEnumerable<object>(enumerable)).Where(new global::System.Func<object, bool>(@object.FilterDataItem));
						}
						global::System.Collections.IEnumerable enumerable2 = linqQueryManager.PerformQuery(enumerable, linqQuery);
						this._phase2Items = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.FilterDropDownItem>();
						foreach (object obj in enumerable2)
						{
							global::Infragistics.Windows.DataPresenter.FilterDropDownItem item = new global::Infragistics.Windows.DataPresenter.FilterDropDownItem(obj, this._cellTextConverter.ConvertCellValue(obj), true);
							this._phase2Items.Add(item);
						}
						this._items.AddRange(this._phase2Items);
						this._uniqueValuesLoadPending = false;
					}
				}
				if (!this._uniqueValuesLoadPending)
				{
					this._endReached = true;
					this.RaisePhase2Completed();
					return;
				}
				this._comparer = new global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.FieldFilterInfo.FilterDropDownItemComparer(this._filterInfo);
				this._fieldConversionCulture = global::Infragistics.Windows.DataPresenter.GridUtilities.GetDefaultCulture(this._filterInfo.Field);
				this._includeFilteredOutValues = includeFilteredOutValues;
				this._recordEnumerator = this.GetRecordsForFilterDropDownCellValues(this._includeFilteredOutValues, true).GetEnumerator();
				this._hasNullValues = false;
				this._phase2Items = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.FilterDropDownItem>();
				this.ProcessPhase2Items(this._asynchLoadThreshhold);
			}

			// Token: 0x0600105E RID: 4190 RVA: 0x00046160 File Offset: 0x00044360
			private void AddFilterItemHelper(global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.FilterDropDownItem> items, global::System.Windows.Input.ICommand action, string srDisplayText)
			{
				items.Add(new global::Infragistics.Windows.DataPresenter.FilterDropDownItem(action, global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString(srDisplayText) + "  "));
			}

			// Token: 0x0600105F RID: 4191 RVA: 0x00046180 File Offset: 0x00044380
			private void AddFilterItemHelper(global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.FilterDropDownItem> items, string operandName)
			{
				global::Infragistics.Windows.Controls.SpecialFilterOperandBase registeredOperand = global::Infragistics.Windows.Controls.SpecialFilterOperands.GetRegisteredOperand(operandName);
				if (registeredOperand != null)
				{
					this.AddFilterItemHelper(items, registeredOperand);
				}
			}

			// Token: 0x06001060 RID: 4192 RVA: 0x000461A0 File Offset: 0x000443A0
			private void AddFilterItemHelper(global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.FilterDropDownItem> items, global::Infragistics.Windows.Controls.SpecialFilterOperandBase operand)
			{
				if (operand != null)
				{
					string displayText = global::Infragistics.Windows.DataPresenter.GridUtilities.ToString(operand.DisplayContent, operand.Name, global::Infragistics.Windows.DataPresenter.GridUtilities.GetDefaultCulture(this._filterInfo.Field));
					items.Add(new global::Infragistics.Windows.DataPresenter.FilterDropDownItem(operand, displayText));
				}
			}

			// Token: 0x06001061 RID: 4193 RVA: 0x000461E0 File Offset: 0x000443E0
			private bool CheckForDuplicateDisplayText(global::Infragistics.Windows.Helpers.HashSet duplicateDisplayTexts, global::Infragistics.Windows.DataPresenter.FilterDropDownItem item, global::Infragistics.Windows.DataPresenter.FilterDropDownItem nextItem)
			{
				string originalDisplayText = this.GetOriginalDisplayText(item);
				string originalDisplayText2 = this.GetOriginalDisplayText(nextItem);
				if (originalDisplayText == originalDisplayText2)
				{
					duplicateDisplayTexts.Add(item);
					duplicateDisplayTexts.Add(nextItem);
					this._itemToOriginalTextMap[item] = originalDisplayText;
					this._itemToOriginalTextMap[nextItem] = originalDisplayText;
					return true;
				}
				return false;
			}

			// Token: 0x06001062 RID: 4194 RVA: 0x00046234 File Offset: 0x00044434
			private void GetFilterDropDownSpecialItems(global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.FilterDropDownItem> items, bool forCustomFilterSelectionControl)
			{
				global::Infragistics.Windows.DataPresenter.FieldLayout owner = this._filterInfo.Field.Owner;
				if ((owner == null || global::Infragistics.Windows.DataPresenter.FilterUIType.FilterRecord != owner.FilterUITypeResolved) && !forCustomFilterSelectionControl)
				{
					this.AddFilterItemHelper(items, new global::Infragistics.Windows.DataPresenter.ClearFilterAction(this._filterInfo), "SR_FilterDropDownItem_All");
				}
				if (!forCustomFilterSelectionControl)
				{
					this.AddFilterItemHelper(items, new global::Infragistics.Windows.DataPresenter.CustomFilterAction(this._filterInfo), "SR_FilterDropDownItem_Custom");
				}
				foreach (global::Infragistics.Windows.Controls.SpecialFilterOperandBase operand in global::Infragistics.Windows.Controls.SpecialFilterOperands.GetRegisteredOperands(this._filterInfo.Field.EditAsTypeResolved))
				{
					this.AddFilterItemHelper(items, operand);
				}
			}

			// Token: 0x06001063 RID: 4195 RVA: 0x000462D0 File Offset: 0x000444D0
			private string GetOriginalDisplayText(global::Infragistics.Windows.DataPresenter.FilterDropDownItem item)
			{
				string result;
				if (this._itemToOriginalTextMap.TryGetValue(item, out result))
				{
					return result;
				}
				return item.DisplayText;
			}

			// Token: 0x06001064 RID: 4196 RVA: 0x000462F8 File Offset: 0x000444F8
			internal global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.DataRecord> GetRecordsForFilterDropDownCellValues(bool includeFilteredOutValues, bool ignoreFieldFilter)
			{
				global::Infragistics.Windows.DataPresenter.FieldLayout owner = this._filterInfo.Field.Owner;
				global::Infragistics.Windows.DataPresenter.RecordFilterScope recordFilterScopeResolved = this._filterInfo.Filters.GetRecordFilterScopeResolved(owner);
				global::Infragistics.Windows.DataPresenter.RecordCollectionBase recordCollectionBase = (global::Infragistics.Windows.DataPresenter.RecordFilterScope.SiblingDataRecords == recordFilterScopeResolved) ? (this._filterInfo.RecordManager.Unsorted as global::Infragistics.Windows.DataPresenter.RecordCollectionBase) : (this._filterInfo.RecordManager.DataPresenter.RecordManager.Unsorted as global::Infragistics.Windows.DataPresenter.RecordCollectionBase);
				global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Record> enumerable = recordCollectionBase.GetRecordEnumerator(global::Infragistics.Windows.DataPresenter.RecordType.DataRecord, owner, owner, false);
				enumerable = global::Infragistics.Windows.DataPresenter.GridUtilities.Filter<global::Infragistics.Windows.DataPresenter.Record>(enumerable, new global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.FieldFilterInfo.MeetsCriteria_Filter(this._filterInfo, includeFilteredOutValues, this._filterInfo.RecordFilter));
				return new global::Infragistics.Collections.TypedEnumerable<global::Infragistics.Windows.DataPresenter.DataRecord>(enumerable);
			}

			// Token: 0x06001065 RID: 4197 RVA: 0x00046394 File Offset: 0x00044594
			private void InitializeFilterMenuItems()
			{
				this._rootMenuItem.Items.Clear();
				global::Infragistics.Windows.DataPresenter.FieldMenuItemProvider fieldMenuItemProvider = new global::Infragistics.Windows.DataPresenter.FieldMenuItemProvider(this._rootMenuItem, this._filterInfo);
				fieldMenuItemProvider.AddClearFilterMenuItem(this._rootMenuItem);
				this._rootMenuItem.Items.Add(fieldMenuItemProvider.CreateDataTypeFilterMenuItem(this._filterInfo.Field.EditAsTypeResolved));
				global::Infragistics.Windows.DataPresenter.FieldMenuItemProvider.AddSeparator(this._rootMenuItem);
				global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl recordFilterTreeControl = new global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl();
				recordFilterTreeControl.ValueLoader = this;
				recordFilterTreeControl.HeightInInfiniteContainers = 230.0;
				recordFilterTreeControl.WidthInInfiniteContainers = 230.0;
				this._rootMenuItem.Items.Add(new global::Infragistics.Windows.DataPresenter.FieldMenuDataItem
				{
					Header = recordFilterTreeControl,
					IsResizable = true,
					StaysOpenOnClick = true,
					IsControlHost = true
				});
			}

			// Token: 0x06001066 RID: 4198 RVA: 0x00046460 File Offset: 0x00044660
			private void OnTimerTick(object sender, global::System.EventArgs e)
			{
				this._timer.Stop();
				this.ProcessPhase2Items(this._asynchLoadDuration);
			}

			// Token: 0x06001067 RID: 4199 RVA: 0x0004647C File Offset: 0x0004467C
			private void ProcessPhase2Items(int maxMs)
			{
				if (this._aborted)
				{
					return;
				}
				int tickCount = global::System.Environment.TickCount;
				int num = 0;
				bool flag = false;
				global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.FilterDropDownItem> list = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.FilterDropDownItem>(2000);
				for (;;)
				{
					if (num > 0)
					{
						if (tickCount + maxMs < global::System.Environment.TickCount)
						{
							break;
						}
					}
					try
					{
						this._endReached = !this._recordEnumerator.MoveNext();
					}
					catch (global::System.Exception)
					{
						flag = true;
						break;
					}
					if (this._endReached)
					{
						break;
					}
					num++;
					global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = this._recordEnumerator.Current;
					string text;
					object cellValueForFilterComparisonHelper = global::Infragistics.Windows.DataPresenter.FilterConditionEvaluationContextBase.GetCellValueForFilterComparisonHelper(this._cellTextConverter, dataRecord, false, out text);
					if (global::Infragistics.Windows.DataPresenter.GridUtilities.IsNullOrEmpty(cellValueForFilterComparisonHelper))
					{
						this._hasNullValues = true;
					}
					else if (!this._uniqueCellValues.Exists(cellValueForFilterComparisonHelper))
					{
						if (this._cellTextConverter.CompareByText)
						{
							text = (cellValueForFilterComparisonHelper as string);
						}
						else
						{
							text = this._cellTextConverter.ConvertCellValue(cellValueForFilterComparisonHelper);
						}
						if (!global::Infragistics.Windows.DataPresenter.GridUtilities.IsNullOrEmpty(text))
						{
							this._uniqueCellValues.Add(cellValueForFilterComparisonHelper);
							global::Infragistics.Windows.DataPresenter.FilterDropDownItem filterDropDownItem = new global::Infragistics.Windows.DataPresenter.FilterDropDownItem(cellValueForFilterComparisonHelper, text, true);
							list.Add(filterDropDownItem);
							filterDropDownItem._cellInfo = this._comparer._fieldSortInfo.GetCellInfo(dataRecord);
						}
					}
				}
				int count = list.Count;
				if (count > 0)
				{
					global::Infragistics.Windows.Helpers.HashSet hashSet = new global::Infragistics.Windows.Helpers.HashSet();
					int count2 = this._phase2Items.Count;
					global::Infragistics.CoreUtilities.SortMergeGeneric<global::Infragistics.Windows.DataPresenter.FilterDropDownItem>(list, this._comparer);
					if (count2 == 0)
					{
						this._phase2Items.AddRange(list);
						int num2 = count - 1;
						for (int i = 0; i < num2; i++)
						{
							global::Infragistics.Windows.DataPresenter.FilterDropDownItem item = this._phase2Items[i];
							global::Infragistics.Windows.DataPresenter.FilterDropDownItem nextItem = this._phase2Items[1 + i];
							this.CheckForDuplicateDisplayText(hashSet, item, nextItem);
						}
					}
					else
					{
						int[] array = new int[count];
						for (int j = 0; j < count; j++)
						{
							global::Infragistics.Windows.DataPresenter.FilterDropDownItem item2 = list[j];
							int num3 = this._phase2Items.BinarySearch(item2, this._comparer);
							if (num3 < 0)
							{
								num3 = ~num3;
							}
							if (num3 < 0)
							{
								num3 = 0;
							}
							else if (num3 > count2)
							{
								num3 = count2;
							}
							array[j] = num3;
						}
						this._phase2Items.AddRange(new global::Infragistics.Windows.DataPresenter.FilterDropDownItem[count]);
						int num4 = count;
						int num5 = count - 1;
						int num6 = array[num5] + num4 - 1;
						for (int k = this._phase2Items.Count - 1; k >= 0; k--)
						{
							if (k <= num6)
							{
								this._phase2Items[k] = list[num5];
								array[num5] = k;
								num5--;
								num4--;
								if (num4 == 0 || num5 < 0)
								{
									break;
								}
								num6 = array[num5] + num4 - 1;
							}
							else
							{
								this._phase2Items[k] = this._phase2Items[k - num4];
							}
						}
						for (int l = 0; l < count; l++)
						{
							int num7 = global::System.Math.Min(array[l], this._phase2Items.Count - 2);
							for (int m = global::System.Math.Max(num7 - 1, 0); m <= num7; m++)
							{
								global::Infragistics.Windows.DataPresenter.FilterDropDownItem item3 = this._phase2Items[m];
								global::Infragistics.Windows.DataPresenter.FilterDropDownItem nextItem2 = this._phase2Items[1 + m];
								this.CheckForDuplicateDisplayText(hashSet, item3, nextItem2);
							}
						}
					}
					foreach (object obj in hashSet)
					{
						global::Infragistics.Windows.DataPresenter.FilterDropDownItem filterDropDownItem2 = (global::Infragistics.Windows.DataPresenter.FilterDropDownItem)obj;
						string text2 = (string)global::Infragistics.CoreUtilities.ConvertDataValue(filterDropDownItem2.Value, typeof(string), this._fieldConversionCulture, null);
						if (!string.IsNullOrEmpty(text2))
						{
							global::Infragistics.Windows.DataPresenter.FilterDropDownItem filterDropDownItem3 = filterDropDownItem2;
							filterDropDownItem3.DisplayText = filterDropDownItem3.DisplayText + " (" + text2 + ")";
						}
					}
					if (this._items != null)
					{
						this._items.BeginUpdate();
						global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.FilterDropDownItem> collection;
						if (this._phase1Items == null)
						{
							collection = this._phase2Items;
						}
						else
						{
							collection = new global::Infragistics.CoreUtilities.AggregateEnumerable<global::Infragistics.Windows.DataPresenter.FilterDropDownItem>(new global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.FilterDropDownItem>[]
							{
								this._phase1Items,
								this._phase2Items
							});
						}
						this._items.Clear();
						this._items.InsertRange(0, collection);
						this._items.EndUpdate();
					}
				}
				if (this._endReached)
				{
					this.RaisePhase2Completed();
					return;
				}
				if (flag)
				{
					this._recordEnumerator = this.GetRecordsForFilterDropDownCellValues(this._includeFilteredOutValues, true).GetEnumerator();
					this._phase2Items.Clear();
					this._uniqueCellValues.Clear();
				}
				if (this._timer == null)
				{
					if (this._editor != null)
					{
						this._editor.SetResourceReference(global::Infragistics.Windows.Editors.XamComboEditor.PostDropDownAreaTemplateProperty, global::Infragistics.Windows.DataPresenter.DataPresenterBase.FilterDropDownLoadingTemplateKey);
					}
					this._timer = new global::System.Windows.Threading.DispatcherTimer(global::System.TimeSpan.FromMilliseconds((double)this._asynchLoadInterval), global::System.Windows.Threading.DispatcherPriority.Background, new global::System.EventHandler(this.OnTimerTick), global::System.Windows.Threading.Dispatcher.CurrentDispatcher);
				}
				this._timer.Start();
				this.RaisePhase2Updated();
			}

			// Token: 0x06001068 RID: 4200 RVA: 0x00046958 File Offset: 0x00044B58
			private void RemoveTreeMenuItem()
			{
				if (this._rootMenuItem == null)
				{
					return;
				}
				global::System.Predicate<global::Infragistics.Windows.DataPresenter.FieldMenuDataItem> callback = (global::Infragistics.Windows.DataPresenter.FieldMenuDataItem mi) => mi.Header is global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl;
				global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.FieldMenuDataItem> list = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.FieldMenuDataItem>();
				global::Infragistics.Windows.DataPresenter.FieldMenuDataItem fieldMenuDataItem = this._rootMenuItem.Find(callback, true, list);
				if (fieldMenuDataItem == null)
				{
					return;
				}
				global::Infragistics.Windows.DataPresenter.FieldMenuDataItem item = fieldMenuDataItem;
				int i = 0;
				int count = list.Count;
				while (i < count)
				{
					global::Infragistics.Windows.DataPresenter.FieldMenuDataItem fieldMenuDataItem2 = list[i];
					global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.FieldMenuDataItem> items = fieldMenuDataItem2.Items;
					int num = items.IndexOf(item);
					fieldMenuDataItem2.Items.RemoveAt(num);
					if (items.Count > 0)
					{
						if (num == 0)
						{
							if (items[num].IsSeparator && items[num].Header == null)
							{
								items.RemoveAt(num);
							}
						}
						else if (num == items.Count)
						{
							if (items[num - 1].IsSeparator)
							{
								items.RemoveAt(num - 1);
							}
						}
						else if (items[num].IsSeparator && items[num - 1].IsSeparator)
						{
							items.RemoveAt(num - 1);
						}
						if (items.Count > 0)
						{
							return;
						}
					}
					item = fieldMenuDataItem2;
					i++;
				}
			}

			// Token: 0x04000660 RID: 1632
			private global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.FieldFilterInfo _filterInfo;

			// Token: 0x04000661 RID: 1633
			private global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.DataRecord> _recordEnumerator;

			// Token: 0x04000662 RID: 1634
			private global::Infragistics.Collections.ObservableCollectionExtended<global::Infragistics.Windows.DataPresenter.FilterDropDownItem> _items;

			// Token: 0x04000663 RID: 1635
			private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.FilterDropDownItem> _phase1Items;

			// Token: 0x04000664 RID: 1636
			private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.FilterDropDownItem> _phase2Items;

			// Token: 0x04000665 RID: 1637
			private global::Infragistics.Windows.DataPresenter.CellTextConverterInfo _cellTextConverter;

			// Token: 0x04000666 RID: 1638
			private global::System.Windows.Threading.DispatcherTimer _timer;

			// Token: 0x04000667 RID: 1639
			private global::System.Globalization.CultureInfo _fieldConversionCulture;

			// Token: 0x04000668 RID: 1640
			private int _asynchLoadDuration = 50;

			// Token: 0x04000669 RID: 1641
			private int _asynchLoadInterval = 50;

			// Token: 0x0400066A RID: 1642
			private int _asynchLoadThreshhold = 1000;

			// Token: 0x0400066B RID: 1643
			private global::Infragistics.Windows.Helpers.HashSet _uniqueCellValues = new global::Infragistics.Windows.Helpers.HashSet();

			// Token: 0x0400066C RID: 1644
			private global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.FilterDropDownItem, string> _itemToOriginalTextMap = new global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.FilterDropDownItem, string>();

			// Token: 0x0400066D RID: 1645
			private bool _endReached;

			// Token: 0x0400066E RID: 1646
			private bool _aborted;

			// Token: 0x0400066F RID: 1647
			private bool _forCustomFilterSelectionControl;

			// Token: 0x04000670 RID: 1648
			private bool _uniqueValuesLoadPending;

			// Token: 0x04000671 RID: 1649
			private bool _includeFilteredOutValues;

			// Token: 0x04000672 RID: 1650
			private global::Infragistics.Windows.Editors.XamComboEditor _editor;

			// Token: 0x04000673 RID: 1651
			private global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.FieldFilterInfo.FilterDropDownItemComparer _comparer;

			// Token: 0x04000674 RID: 1652
			private global::Infragistics.Windows.DataPresenter.FieldMenuDataItem _rootMenuItem;

			// Token: 0x04000675 RID: 1653
			private bool _hasNullValues;
		}
	}
}
