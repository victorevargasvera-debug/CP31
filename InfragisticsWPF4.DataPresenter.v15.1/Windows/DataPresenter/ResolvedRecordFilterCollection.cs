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
	// Token: 0x02000142 RID: 322
	internal class ResolvedRecordFilterCollection : global::System.Windows.DependencyObject
	{
		// Token: 0x06001372 RID: 4978 RVA: 0x00055C2C File Offset: 0x00053E2C
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

		// Token: 0x06001373 RID: 4979 RVA: 0x00055C78 File Offset: 0x00053E78
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

		// Token: 0x06001374 RID: 4980 RVA: 0x00055D2D File Offset: 0x00053F2D
		internal void ClearCachedEvaluationContexts()
		{
			this._evaluationContextCache = new global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.FilterEvaluationContextCache(this);
		}

		// Token: 0x06001375 RID: 4981 RVA: 0x00055D3B File Offset: 0x00053F3B
		internal static global::Infragistics.Windows.DataPresenter.FilterConditionEvaluationContext CreateEvaluationContext(global::Infragistics.Windows.DataPresenter.RecordManager recordManager, global::Infragistics.Windows.DataPresenter.Field field)
		{
			return global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.FilterEvaluationContextCache.CreateEvaluationContext(recordManager, field);
		}

		// Token: 0x06001376 RID: 4982 RVA: 0x00055D44 File Offset: 0x00053F44
		internal bool DoesFilterCriteriaUseAllValues(global::Infragistics.Windows.DataPresenter.Field fieldContext, global::Infragistics.Windows.DataPresenter.DataRecord recordContext)
		{
			if (fieldContext != null)
			{
				return this.UsesAllValues(fieldContext);
			}
			return recordContext != null && this.UsesAllValues(recordContext);
		}

		// Token: 0x06001377 RID: 4983 RVA: 0x00055D60 File Offset: 0x00053F60
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

		// Token: 0x06001378 RID: 4984 RVA: 0x00055D8C File Offset: 0x00053F8C
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

		// Token: 0x06001379 RID: 4985 RVA: 0x00055DEC File Offset: 0x00053FEC
		internal bool HasActiveFilter(global::Infragistics.Windows.DataPresenter.Field field)
		{
			global::Infragistics.Windows.DataPresenter.RecordFilterCollection recordFilters = this.GetRecordFilters(field.Owner, false);
			if (recordFilters != null)
			{
				if (recordFilters.Count == 0)
				{
					return false;
				}
				global::Infragistics.Windows.DataPresenter.RecordFilter item = recordFilters.GetItem(field, false);
				if (item != null && item.HasConditions)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0600137A RID: 4986 RVA: 0x00055E30 File Offset: 0x00054030
		internal bool HasActiveFilters(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout)
		{
			global::Infragistics.Windows.DataPresenter.RecordFilterCollection recordFilters = this.GetRecordFilters(fieldLayout, false);
			if (recordFilters != null)
			{
				int count = recordFilters.Count;
				if (count == 0)
				{
					return false;
				}
				for (int i = 0; i < count; i++)
				{
					global::Infragistics.Windows.DataPresenter.RecordFilter recordFilter = recordFilters[i];
					if (recordFilter != null && recordFilter.HasConditions)
					{
						global::Infragistics.Windows.DataPresenter.Field field = recordFilter.Field;
						if (field != null && field.Owner == fieldLayout)
						{
							return true;
						}
					}
				}
			}
			return false;
		}

		// Token: 0x0600137B RID: 4987 RVA: 0x00055E90 File Offset: 0x00054090
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

		// Token: 0x0600137C RID: 4988 RVA: 0x00055EEC File Offset: 0x000540EC
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

		// Token: 0x0600137D RID: 4989 RVA: 0x00055F62 File Offset: 0x00054162
		internal bool? MeetsCriteria(global::Infragistics.Windows.DataPresenter.DataRecord record)
		{
			return this.MeetsCriteria(record, null, false);
		}

		// Token: 0x0600137E RID: 4990 RVA: 0x00055F70 File Offset: 0x00054170
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

		// Token: 0x0600137F RID: 4991 RVA: 0x00056085 File Offset: 0x00054285
		internal void OnFieldLayoutAdded(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout)
		{
			this.HookInto(fieldLayout);
		}

		// Token: 0x06001380 RID: 4992 RVA: 0x0005608E File Offset: 0x0005428E
		private void OnFieldLayoutFieldsChanged()
		{
			if (!this._needToVerifyRecordFilterFields)
			{
				this._needToVerifyRecordFilterFields = true;
				base.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Normal, new global::Infragistics.Windows.DataPresenter.GridUtilities.MethodDelegate(this.VerifyRecordFilterFieldsHelper));
			}
		}

		// Token: 0x06001381 RID: 4993 RVA: 0x000560BC File Offset: 0x000542BC
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

		// Token: 0x06001382 RID: 4994 RVA: 0x00056140 File Offset: 0x00054340
		internal void OnSourceFiltersChanged()
		{
			this.BumpVersion();
		}

		// Token: 0x06001383 RID: 4995 RVA: 0x00056148 File Offset: 0x00054348
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

		// Token: 0x06001384 RID: 4996 RVA: 0x0005617B File Offset: 0x0005437B
		internal bool UsesAllValues(global::Infragistics.Windows.DataPresenter.DataRecord record)
		{
			return this.UsesAllValues(record.FieldLayout);
		}

		// Token: 0x06001385 RID: 4997 RVA: 0x0005618C File Offset: 0x0005438C
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

		// Token: 0x170004CB RID: 1227
		internal global::Infragistics.Windows.DataPresenter.RecordFilter this[global::Infragistics.Windows.DataPresenter.Field field]
		{
			get
			{
				return this.GetItem(field, true);
			}
		}

		// Token: 0x06001387 RID: 4999 RVA: 0x000561E0 File Offset: 0x000543E0
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

		// Token: 0x170004CC RID: 1228
		// (get) Token: 0x06001388 RID: 5000 RVA: 0x00056212 File Offset: 0x00054412
		internal int Version
		{
			get
			{
				return this._filtersVersion;
			}
		}

		// Token: 0x06001389 RID: 5001 RVA: 0x0005621A File Offset: 0x0005441A
		internal void BumpVersion()
		{
			this._filtersVersion++;
			this.ClearCachedEvaluationContexts();
			base.SetValue(global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.VersionPropertyKey, this._filtersVersion);
			this.ApplyFiltersToCollectionViewHelper();
		}

		// Token: 0x040007DE RID: 2014
		private global::Infragistics.Collections.WeakDictionary<global::Infragistics.Windows.DataPresenter.FieldLayout, global::Infragistics.Windows.Internal.PropertyValueTracker> _pvtTrackers = new global::Infragistics.Collections.WeakDictionary<global::Infragistics.Windows.DataPresenter.FieldLayout, global::Infragistics.Windows.Internal.PropertyValueTracker>(true, false);

		// Token: 0x040007DF RID: 2015
		private global::Infragistics.Windows.DataPresenter.RecordManager _recordManager;

		// Token: 0x040007E0 RID: 2016
		private int _filtersVersion;

		// Token: 0x040007E1 RID: 2017
		private global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.FilterEvaluationContextCache _evaluationContextCache;

		// Token: 0x040007E2 RID: 2018
		private global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.DataItemFilterEvaluator _dataItemFilterEvaluator;

		// Token: 0x040007E3 RID: 2019
		private bool _needToVerifyRecordFilterFields;

		// Token: 0x040007E4 RID: 2020
		private static readonly global::System.Windows.DependencyPropertyKey VersionPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("Version", typeof(int), typeof(global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection), new global::System.Windows.FrameworkPropertyMetadata(0, global::System.Windows.FrameworkPropertyMetadataOptions.None));

		// Token: 0x040007E5 RID: 2021
		internal static readonly global::System.Windows.DependencyProperty VersionProperty = global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.VersionPropertyKey.DependencyProperty;

		// Token: 0x02000143 RID: 323
		private class DataItemFilterEvaluator
		{
			// Token: 0x0600138B RID: 5003 RVA: 0x0005628C File Offset: 0x0005448C
			internal DataItemFilterEvaluator(global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection coll, bool populatingFilterDropDown, global::Infragistics.Windows.DataPresenter.RecordFilter ignoreFilter)
			{
				this._coll = coll;
				this._populatingFilterDropDown = populatingFilterDropDown;
				this._ignoreFilter = ignoreFilter;
				this._filterPredicate = new global::System.Predicate<object>(new global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.DataItemFilterEvaluator.WeakPredicateHelper(this).FilterDataItem);
			}

			// Token: 0x0600138C RID: 5004 RVA: 0x000562C0 File Offset: 0x000544C0
			private void EnsurePropertyDescriptor(object dataItem, global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.DataItemFilterEvaluator.EvaluationContext context)
			{
				if (context._propertyDescriptor == null || (context._propertyDescriptor.ComponentType != null && !context._propertyDescriptor.ComponentType.IsAssignableFrom(dataItem.GetType())))
				{
					if (context._propertyDescriptor != null && context._propertyDescriptor.ComponentType != null && !context._propertyDescriptor.ComponentType.IsAssignableFrom(dataItem.GetType()))
					{
						this._cachedPropertyDescriptorProvider = null;
					}
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

			// Token: 0x0600138D RID: 5005 RVA: 0x00056390 File Offset: 0x00054590
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

			// Token: 0x0600138E RID: 5006 RVA: 0x00056488 File Offset: 0x00054688
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

			// Token: 0x040007E6 RID: 2022
			private readonly global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection _coll;

			// Token: 0x040007E7 RID: 2023
			private readonly bool _populatingFilterDropDown;

			// Token: 0x040007E8 RID: 2024
			private global::Infragistics.Collections.WeakDictionary<global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.DataItemFilterEvaluator.EvaluationContext> _evaluationContexts;

			// Token: 0x040007E9 RID: 2025
			private global::Infragistics.Windows.DataPresenter.RecordFilter _ignoreFilter;

			// Token: 0x040007EA RID: 2026
			private global::Infragistics.Windows.Internal.PropertyDescriptorProvider _cachedPropertyDescriptorProvider;

			// Token: 0x040007EB RID: 2027
			internal readonly global::System.Predicate<object> _filterPredicate;

			// Token: 0x02000144 RID: 324
			internal class EvaluationContext : global::Infragistics.Windows.Controls.ConditionEvaluationContext
			{
				// Token: 0x0600138F RID: 5007 RVA: 0x000564DC File Offset: 0x000546DC
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

				// Token: 0x170004CD RID: 1229
				// (get) Token: 0x06001390 RID: 5008 RVA: 0x00056548 File Offset: 0x00054748
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

				// Token: 0x170004CE RID: 1230
				// (get) Token: 0x06001391 RID: 5009 RVA: 0x00056584 File Offset: 0x00054784
				public override global::System.Collections.IComparer Comparer
				{
					get
					{
						return this._field.FilterComparerResolved ?? base.Comparer;
					}
				}

				// Token: 0x170004CF RID: 1231
				// (get) Token: 0x06001392 RID: 5010 RVA: 0x0005659B File Offset: 0x0005479B
				public override global::Infragistics.Windows.Controls.ValueEntry CurrentValue
				{
					get
					{
						return this._currentValue;
					}
				}

				// Token: 0x170004D0 RID: 1232
				// (get) Token: 0x06001393 RID: 5011 RVA: 0x000565A3 File Offset: 0x000547A3
				public override bool IgnoreCase
				{
					get
					{
						return this._ignoreCase;
					}
				}

				// Token: 0x06001394 RID: 5012 RVA: 0x000565AB File Offset: 0x000547AB
				public void SetIgnoreCase(bool val)
				{
					this._ignoreCase = val;
				}

				// Token: 0x06001395 RID: 5013 RVA: 0x000565B4 File Offset: 0x000547B4
				public void InitializeCurrentValue(object dataItem, object value)
				{
					this._currentDataItem = dataItem;
					this._currentValue = new global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.DataItemFilterEvaluator.EvaluationContext.ContextValueEntry(value, this);
				}

				// Token: 0x170004D1 RID: 1233
				// (get) Token: 0x06001396 RID: 5014 RVA: 0x000565CA File Offset: 0x000547CA
				public override global::System.Type PreferredComparisonDataType
				{
					get
					{
						return this._prefComparisonType;
					}
				}

				// Token: 0x06001397 RID: 5015 RVA: 0x000565D2 File Offset: 0x000547D2
				internal object GetCellValueHelper(object dataItem)
				{
					return this._propertyDescriptor.GetValue(dataItem);
				}

				// Token: 0x040007EC RID: 2028
				internal readonly global::Infragistics.Windows.DataPresenter.RecordManager _recordManager;

				// Token: 0x040007ED RID: 2029
				internal readonly global::Infragistics.Windows.DataPresenter.Field _field;

				// Token: 0x040007EE RID: 2030
				internal global::System.ComponentModel.PropertyDescriptor _propertyDescriptor;

				// Token: 0x040007EF RID: 2031
				internal object _currentDataItem;

				// Token: 0x040007F0 RID: 2032
				internal global::System.Globalization.CultureInfo _culture;

				// Token: 0x040007F1 RID: 2033
				private global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.DataItemFilterEvaluator.EvaluationContext.ContextValueEntry _currentValue;

				// Token: 0x040007F2 RID: 2034
				private global::System.Type _prefComparisonType;

				// Token: 0x040007F3 RID: 2035
				private bool _ignoreCase = true;

				// Token: 0x02000145 RID: 325
				internal class ContextValueEntry : global::Infragistics.Windows.Controls.ValueEntry
				{
					// Token: 0x06001399 RID: 5017 RVA: 0x000565E0 File Offset: 0x000547E0
					internal ContextValueEntry(object value, global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.DataItemFilterEvaluator.EvaluationContext context)
					{
						this._context = context;
						this._value = value;
					}

					// Token: 0x170004D2 RID: 1234
					// (get) Token: 0x0600139A RID: 5018 RVA: 0x000565F6 File Offset: 0x000547F6
					public override object Context
					{
						get
						{
							return this._context._currentDataItem;
						}
					}

					// Token: 0x170004D3 RID: 1235
					// (get) Token: 0x0600139B RID: 5019 RVA: 0x00056603 File Offset: 0x00054803
					public override global::System.Globalization.CultureInfo Culture
					{
						get
						{
							return this._context._culture;
						}
					}

					// Token: 0x170004D4 RID: 1236
					// (get) Token: 0x0600139C RID: 5020 RVA: 0x00056610 File Offset: 0x00054810
					public override string Format
					{
						get
						{
							return null;
						}
					}

					// Token: 0x170004D5 RID: 1237
					// (get) Token: 0x0600139D RID: 5021 RVA: 0x00056613 File Offset: 0x00054813
					public override object Value
					{
						get
						{
							return this._value;
						}
					}

					// Token: 0x040007F4 RID: 2036
					private global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.DataItemFilterEvaluator.EvaluationContext _context;

					// Token: 0x040007F5 RID: 2037
					private object _value;
				}
			}

			// Token: 0x02000146 RID: 326
			internal class WeakPredicateHelper
			{
				// Token: 0x0600139E RID: 5022 RVA: 0x0005661B File Offset: 0x0005481B
				internal WeakPredicateHelper(global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.DataItemFilterEvaluator evaluator)
				{
					this._evaluator = new global::System.WeakReference(evaluator);
				}

				// Token: 0x0600139F RID: 5023 RVA: 0x00056630 File Offset: 0x00054830
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

				// Token: 0x040007F6 RID: 2038
				private global::System.WeakReference _evaluator;
			}
		}

		// Token: 0x02000147 RID: 327
		internal class FieldFilterInfo : global::Infragistics.PropertyChangeNotifier
		{
			// Token: 0x060013A0 RID: 5024 RVA: 0x0005666C File Offset: 0x0005486C
			internal FieldFilterInfo(global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection filters, global::Infragistics.Windows.DataPresenter.Field field)
			{
				global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNotNull(filters);
				global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNotNull(field);
				this._filters = filters;
				this._field = field;
				this._recordManager = filters._recordManager;
				global::Infragistics.Windows.Internal.PropertyValueTracker propertyValueTracker = (global::Infragistics.Windows.Internal.PropertyValueTracker)(this._pvtList = new global::Infragistics.Windows.Internal.PropertyValueTracker(filters, global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.VersionProperty, new global::Infragistics.Windows.Internal.PropertyValueTracker.PropertyValueChangedHandler(this.OnFiltersChanged))).Tag;
			}

			// Token: 0x170004D6 RID: 1238
			// (get) Token: 0x060013A1 RID: 5025 RVA: 0x000566D0 File Offset: 0x000548D0
			public bool HasActiveFilters
			{
				get
				{
					this.VerifyHasActiveFilters();
					return this._cachedHasActiveFilters;
				}
			}

			// Token: 0x170004D7 RID: 1239
			// (get) Token: 0x060013A2 RID: 5026 RVA: 0x000566DE File Offset: 0x000548DE
			public global::Infragistics.Windows.DataPresenter.RecordFilter RecordFilter
			{
				get
				{
					this.VerifyRecordFilter();
					return this._cachedRecordFilter;
				}
			}

			// Token: 0x060013A3 RID: 5027 RVA: 0x000566EC File Offset: 0x000548EC
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

			// Token: 0x170004D8 RID: 1240
			// (get) Token: 0x060013A4 RID: 5028 RVA: 0x00056778 File Offset: 0x00054978
			internal global::Infragistics.Windows.DataPresenter.Field Field
			{
				get
				{
					return this._field;
				}
			}

			// Token: 0x170004D9 RID: 1241
			// (get) Token: 0x060013A5 RID: 5029 RVA: 0x00056780 File Offset: 0x00054980
			internal global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection Filters
			{
				get
				{
					return this._filters;
				}
			}

			// Token: 0x170004DA RID: 1242
			// (get) Token: 0x060013A6 RID: 5030 RVA: 0x00056788 File Offset: 0x00054988
			internal global::Infragistics.Windows.DataPresenter.RecordManager RecordManager
			{
				get
				{
					return this._recordManager;
				}
			}

			// Token: 0x060013A7 RID: 5031 RVA: 0x00056790 File Offset: 0x00054990
			private void OnFiltersChanged()
			{
				this.VerifyRecordFilter();
				this.VerifyHasActiveFilters();
			}

			// Token: 0x060013A8 RID: 5032 RVA: 0x000567A0 File Offset: 0x000549A0
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

			// Token: 0x040007F7 RID: 2039
			private global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection _filters;

			// Token: 0x040007F8 RID: 2040
			private global::Infragistics.Windows.DataPresenter.Field _field;

			// Token: 0x040007F9 RID: 2041
			private global::Infragistics.Windows.DataPresenter.RecordManager _recordManager;

			// Token: 0x040007FA RID: 2042
			private global::Infragistics.Windows.Internal.PropertyValueTracker _pvtList;

			// Token: 0x040007FB RID: 2043
			private global::Infragistics.Windows.DataPresenter.RecordFilter _cachedRecordFilter;

			// Token: 0x040007FC RID: 2044
			private bool _cachedHasActiveFilters;

			// Token: 0x040007FD RID: 2045
			private int _cachedFilterVersion;

			// Token: 0x02000148 RID: 328
			internal class FilterDropDownItemComparer : global::System.Collections.Generic.IComparer<global::Infragistics.Windows.DataPresenter.FilterDropDownItem>
			{
				// Token: 0x060013A9 RID: 5033 RVA: 0x000567E1 File Offset: 0x000549E1
				internal FilterDropDownItemComparer(global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.FieldFilterInfo info)
				{
					this._fieldSortInfo = new global::Infragistics.Windows.DataPresenter.RecordManager.SameFieldRecordsSortComparer.FieldSortInfo(info._field);
					this._isCaseInsensitive = (info._field.SortComparisonTypeResolved == global::Infragistics.Windows.DataPresenter.FieldSortComparisonType.CaseInsensitive);
				}

				// Token: 0x060013AA RID: 5034 RVA: 0x00056810 File Offset: 0x00054A10
				public int Compare(global::Infragistics.Windows.DataPresenter.FilterDropDownItem x, global::Infragistics.Windows.DataPresenter.FilterDropDownItem y)
				{
					global::System.Collections.IComparer comparer = this._fieldSortInfo._comparer;
					if (comparer != null)
					{
						return comparer.Compare(x.Value, y.Value);
					}
					global::Infragistics.Windows.DataPresenter.RecordManager.SameFieldRecordsSortComparer.CellInfo cellInfo = x._cellInfo;
					global::Infragistics.Windows.DataPresenter.RecordManager.SameFieldRecordsSortComparer.CellInfo cellInfo2 = y._cellInfo;
					return global::Infragistics.Windows.DataPresenter.RecordManager.SameFieldRecordsSortComparer.DefaultCompare(cellInfo.GetCompareValue(), cellInfo2.GetCompareValue(), true, this._isCaseInsensitive);
				}

				// Token: 0x040007FE RID: 2046
				internal global::Infragistics.Windows.DataPresenter.RecordManager.SameFieldRecordsSortComparer.FieldSortInfo _fieldSortInfo;

				// Token: 0x040007FF RID: 2047
				private bool _isCaseInsensitive;
			}

			// Token: 0x02000149 RID: 329
			public class MeetsCriteria_Filter : global::Infragistics.Windows.DataPresenter.GridUtilities.IMeetsCriteria
			{
				// Token: 0x060013AB RID: 5035 RVA: 0x00056865 File Offset: 0x00054A65
				public MeetsCriteria_Filter(global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.FieldFilterInfo info, bool includeFilteredOutValues, global::Infragistics.Windows.DataPresenter.RecordFilter ignoreFilter)
				{
					this._info = info;
					this._includeFilteredOutValues = includeFilteredOutValues;
					this._ignoreFilter = ignoreFilter;
				}

				// Token: 0x060013AC RID: 5036 RVA: 0x00056884 File Offset: 0x00054A84
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

				// Token: 0x04000800 RID: 2048
				private global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.FieldFilterInfo _info;

				// Token: 0x04000801 RID: 2049
				private bool _includeFilteredOutValues;

				// Token: 0x04000802 RID: 2050
				private global::Infragistics.Windows.DataPresenter.RecordFilter _ignoreFilter;
			}
		}

		// Token: 0x0200014A RID: 330
		private class FilterEvaluationContextCache
		{
			// Token: 0x060013AD RID: 5037 RVA: 0x00056901 File Offset: 0x00054B01
			internal FilterEvaluationContextCache(global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection info)
			{
				this._info = info;
			}

			// Token: 0x060013AE RID: 5038 RVA: 0x00056910 File Offset: 0x00054B10
			internal static global::Infragistics.Windows.DataPresenter.FilterConditionEvaluationContext CreateEvaluationContext(global::Infragistics.Windows.DataPresenter.RecordManager recordManager, global::Infragistics.Windows.DataPresenter.Field field)
			{
				global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.DataRecord> allValuesRecords = global::Infragistics.Windows.DataPresenter.GridUtilities.Filter<global::Infragistics.Windows.DataPresenter.DataRecord>(recordManager.Unsorted, new global::Infragistics.Windows.DataPresenter.GridUtilities.MeetsCriteria_RecordVisible(true));
				return new global::Infragistics.Windows.DataPresenter.FilterConditionEvaluationContext(field, allValuesRecords);
			}

			// Token: 0x060013AF RID: 5039 RVA: 0x00056938 File Offset: 0x00054B38
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

			// Token: 0x060013B0 RID: 5040 RVA: 0x00056999 File Offset: 0x00054B99
			internal void MaintainCacheForUsesAllValues(global::Infragistics.Windows.DataPresenter.FilterConditionEvaluationContext context)
			{
				if (context.WasAllValuesUsed)
				{
					this._hasAnyContextUsedAllValues = true;
				}
			}

			// Token: 0x04000803 RID: 2051
			private global::Infragistics.Collections.WeakDictionary<global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.FilterConditionEvaluationContext> _cachedEvaluationContexts;

			// Token: 0x04000804 RID: 2052
			private global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection _info;

			// Token: 0x04000805 RID: 2053
			internal bool _hasAnyContextUsedAllValues;
		}

		// Token: 0x0200014B RID: 331
		internal class FilterDropDownItemLoader
		{
			// Token: 0x060013B1 RID: 5041 RVA: 0x000569AC File Offset: 0x00054BAC
			internal FilterDropDownItemLoader(global::Infragistics.Windows.Editors.XamComboEditor editor, global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.FieldFilterInfo filterInfo, global::Infragistics.Collections.ObservableCollectionExtended<global::Infragistics.Windows.DataPresenter.FilterDropDownItem> items, bool forCustomFilterSelectionControl, global::System.Collections.IEqualityComparer uniqueCellValueComparer = null)
			{
				this._editor = editor;
				this._items = items;
				this._forCustomFilterSelectionControl = forCustomFilterSelectionControl;
				this._filterInfo = filterInfo;
				this._uniqueCellValues = ((uniqueCellValueComparer == null) ? new global::Infragistics.Windows.Helpers.HashSet() : new global::Infragistics.Windows.Helpers.HashSet(0, 1f, uniqueCellValueComparer));
				if (items == null)
				{
					this._rootMenuItem = new global::Infragistics.Windows.DataPresenter.FieldMenuDataItem();
				}
			}

			// Token: 0x1400005D RID: 93
			// (add) Token: 0x060013B2 RID: 5042 RVA: 0x00056A3C File Offset: 0x00054C3C
			// (remove) Token: 0x060013B3 RID: 5043 RVA: 0x00056A74 File Offset: 0x00054C74
			internal event global::System.EventHandler Phase1Completed;

			// Token: 0x060013B4 RID: 5044 RVA: 0x00056AAC File Offset: 0x00054CAC
			private void RaisePhase1Completed()
			{
				global::System.EventHandler phase1Completed = this.Phase1Completed;
				if (phase1Completed != null)
				{
					phase1Completed(this, global::System.EventArgs.Empty);
				}
			}

			// Token: 0x1400005E RID: 94
			// (add) Token: 0x060013B5 RID: 5045 RVA: 0x00056AD0 File Offset: 0x00054CD0
			// (remove) Token: 0x060013B6 RID: 5046 RVA: 0x00056B08 File Offset: 0x00054D08
			internal event global::System.EventHandler Phase2Completed;

			// Token: 0x060013B7 RID: 5047 RVA: 0x00056B40 File Offset: 0x00054D40
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

			// Token: 0x1400005F RID: 95
			// (add) Token: 0x060013B8 RID: 5048 RVA: 0x00056BD0 File Offset: 0x00054DD0
			// (remove) Token: 0x060013B9 RID: 5049 RVA: 0x00056C08 File Offset: 0x00054E08
			internal event global::System.EventHandler Phase2Updated;

			// Token: 0x060013BA RID: 5050 RVA: 0x00056C40 File Offset: 0x00054E40
			private void RaisePhase2Updated()
			{
				global::System.EventHandler phase2Updated = this.Phase2Updated;
				if (phase2Updated != null)
				{
					phase2Updated(this, global::System.EventArgs.Empty);
				}
			}

			// Token: 0x170004DB RID: 1243
			// (get) Token: 0x060013BB RID: 5051 RVA: 0x00056C63 File Offset: 0x00054E63
			internal bool Aborted
			{
				get
				{
					return this._aborted;
				}
			}

			// Token: 0x170004DC RID: 1244
			// (get) Token: 0x060013BC RID: 5052 RVA: 0x00056C6B File Offset: 0x00054E6B
			// (set) Token: 0x060013BD RID: 5053 RVA: 0x00056C74 File Offset: 0x00054E74
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

			// Token: 0x170004DD RID: 1245
			// (get) Token: 0x060013BE RID: 5054 RVA: 0x00056CD6 File Offset: 0x00054ED6
			internal bool EndReached
			{
				get
				{
					return this._endReached;
				}
			}

			// Token: 0x170004DE RID: 1246
			// (get) Token: 0x060013BF RID: 5055 RVA: 0x00056CDE File Offset: 0x00054EDE
			internal global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.FieldFilterInfo FilterInfo
			{
				get
				{
					return this._filterInfo;
				}
			}

			// Token: 0x170004DF RID: 1247
			// (get) Token: 0x060013C0 RID: 5056 RVA: 0x00056CE6 File Offset: 0x00054EE6
			internal bool HasNullValues
			{
				get
				{
					return this._hasNullValues;
				}
			}

			// Token: 0x170004E0 RID: 1248
			// (get) Token: 0x060013C1 RID: 5057 RVA: 0x00056CEE File Offset: 0x00054EEE
			internal global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.FilterDropDownItem> Phase2Items
			{
				get
				{
					return this._phase2Items;
				}
			}

			// Token: 0x170004E1 RID: 1249
			// (get) Token: 0x060013C2 RID: 5058 RVA: 0x00056CF6 File Offset: 0x00054EF6
			internal global::Infragistics.Windows.DataPresenter.FieldMenuDataItem RootMenuItem
			{
				get
				{
					return this._rootMenuItem;
				}
			}

			// Token: 0x170004E2 RID: 1250
			// (get) Token: 0x060013C3 RID: 5059 RVA: 0x00056CFE File Offset: 0x00054EFE
			internal bool UniqueValuesLoadPending
			{
				get
				{
					return this._uniqueValuesLoadPending;
				}
			}

			// Token: 0x060013C4 RID: 5060 RVA: 0x00056D06 File Offset: 0x00054F06
			internal void Abort()
			{
				this._aborted = true;
				this.RaisePhase2Completed();
			}

			// Token: 0x060013C5 RID: 5061 RVA: 0x00056D18 File Offset: 0x00054F18
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

			// Token: 0x060013C6 RID: 5062 RVA: 0x00056E54 File Offset: 0x00055054
			internal void PopulatePhase2(bool includeFilteredOutValues)
			{
				if (this._phase1Items == null && this._rootMenuItem == null)
				{
					this.PopulatePhase1();
				}
				this._cellTextConverter = global::Infragistics.Windows.DataPresenter.CellTextConverterInfo.GetCachedConverter(this._filterInfo.Field);
				if (this._uniqueValuesLoadPending && this._filterInfo != null && this._filterInfo.Field.BindingType == global::Infragistics.Windows.DataPresenter.BindingType.UseNameBinding && global::Infragistics.Windows.DataPresenter.FilterEvaluationMode.UseCollectionView == this._filterInfo.Field.Owner.FilterEvaluationModeResolved)
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
						global::System.Collections.IEnumerable enumerable2 = linqQueryManager.PerformQuery(enumerable, linqQuery) as global::System.Collections.IEnumerable;
						this._phase2Items = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.FilterDropDownItem>();
						foreach (object obj in enumerable2)
						{
							global::Infragistics.Windows.DataPresenter.FilterDropDownItem item = new global::Infragistics.Windows.DataPresenter.FilterDropDownItem(obj, this._cellTextConverter.ConvertCellValue(obj), true);
							this._phase2Items.Add(item);
						}
						if (this._items != null)
						{
							this._items.AddRange(this._phase2Items);
						}
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

			// Token: 0x060013C7 RID: 5063 RVA: 0x00057080 File Offset: 0x00055280
			private void AddFilterItemHelper(global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.FilterDropDownItem> items, global::System.Windows.Input.ICommand action, string srDisplayText)
			{
				items.Add(new global::Infragistics.Windows.DataPresenter.FilterDropDownItem(action, global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString(srDisplayText) + "  "));
			}

			// Token: 0x060013C8 RID: 5064 RVA: 0x000570A0 File Offset: 0x000552A0
			private void AddFilterItemHelper(global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.FilterDropDownItem> items, string operandName)
			{
				global::Infragistics.Windows.Controls.SpecialFilterOperandBase registeredOperand = global::Infragistics.Windows.Controls.SpecialFilterOperands.GetRegisteredOperand(operandName);
				if (registeredOperand != null)
				{
					this.AddFilterItemHelper(items, registeredOperand);
				}
			}

			// Token: 0x060013C9 RID: 5065 RVA: 0x000570C0 File Offset: 0x000552C0
			private void AddFilterItemHelper(global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.FilterDropDownItem> items, global::Infragistics.Windows.Controls.SpecialFilterOperandBase operand)
			{
				if (operand != null)
				{
					string displayText = global::Infragistics.Windows.DataPresenter.GridUtilities.ToString(operand.DisplayContent, operand.Name, global::Infragistics.Windows.DataPresenter.GridUtilities.GetDefaultCulture(this._filterInfo.Field));
					items.Add(new global::Infragistics.Windows.DataPresenter.FilterDropDownItem(operand, displayText));
				}
			}

			// Token: 0x060013CA RID: 5066 RVA: 0x00057100 File Offset: 0x00055300
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

			// Token: 0x060013CB RID: 5067 RVA: 0x00057154 File Offset: 0x00055354
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

			// Token: 0x060013CC RID: 5068 RVA: 0x000571F0 File Offset: 0x000553F0
			internal string GetOriginalDisplayText(global::Infragistics.Windows.DataPresenter.FilterDropDownItem item)
			{
				string result;
				if (this._itemToOriginalTextMap.TryGetValue(item, out result))
				{
					return result;
				}
				return item.DisplayText;
			}

			// Token: 0x060013CD RID: 5069 RVA: 0x00057218 File Offset: 0x00055418
			internal global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.DataRecord> GetRecordsForFilterDropDownCellValues(bool includeFilteredOutValues, bool ignoreFieldFilter)
			{
				global::Infragistics.Windows.DataPresenter.FieldLayout owner = this._filterInfo.Field.Owner;
				global::Infragistics.Windows.DataPresenter.RecordFilterScope recordFilterScopeResolved = this._filterInfo.Filters.GetRecordFilterScopeResolved(owner);
				bool isTreeView = owner.IsTreeView;
				if (isTreeView)
				{
					return this.GetTreeViewRecordsForFilterDownDownCellValue(includeFilteredOutValues);
				}
				global::Infragistics.Windows.DataPresenter.RecordCollectionBase recordCollectionBase = (global::Infragistics.Windows.DataPresenter.RecordFilterScope.SiblingDataRecords == recordFilterScopeResolved) ? (this._filterInfo.RecordManager.Unsorted as global::Infragistics.Windows.DataPresenter.RecordCollectionBase) : (this._filterInfo.RecordManager.DataPresenter.RecordManager.Unsorted as global::Infragistics.Windows.DataPresenter.RecordCollectionBase);
				global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Record> enumerable = recordCollectionBase.GetRecordEnumerator(global::Infragistics.Windows.DataPresenter.RecordType.DataRecord, owner, owner, false);
				enumerable = global::Infragistics.Windows.DataPresenter.GridUtilities.Filter<global::Infragistics.Windows.DataPresenter.Record>(enumerable, new global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.FieldFilterInfo.MeetsCriteria_Filter(this._filterInfo, includeFilteredOutValues, this._filterInfo.RecordFilter));
				return new global::Infragistics.Collections.TypedEnumerable<global::Infragistics.Windows.DataPresenter.DataRecord>(enumerable);
			}

			// Token: 0x060013CE RID: 5070 RVA: 0x000575D4 File Offset: 0x000557D4
			private global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.DataRecord> GetTreeViewRecordsForFilterDownDownCellValue(bool includeFilteredOutValues)
			{
				global::Infragistics.Windows.DataPresenter.RecordCollectionBase recordColl = this._filterInfo.RecordManager.Unsorted as global::Infragistics.Windows.DataPresenter.RecordCollectionBase;
				global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.FieldLayout, global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.FieldFilterInfo.MeetsCriteria_Filter> filterMap = new global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.FieldLayout, global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.FieldFilterInfo.MeetsCriteria_Filter>();
				global::Infragistics.Windows.DataPresenter.FieldLayout fl = this._filterInfo.Field.Owner;
				global::Infragistics.Windows.DataPresenter.FieldLayout lastFl = fl;
				global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.FieldFilterInfo.MeetsCriteria_Filter lastFilter = new global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.FieldFilterInfo.MeetsCriteria_Filter(this._filterInfo, includeFilteredOutValues, this._filterInfo.RecordFilter);
				filterMap[fl] = lastFilter;
				foreach (global::Infragistics.Windows.DataPresenter.Record record in recordColl.GetRecordEnumerator(global::Infragistics.Windows.DataPresenter.RecordType.DataRecord, null, null, false))
				{
					global::Infragistics.Windows.DataPresenter.DataRecord dr = (global::Infragistics.Windows.DataPresenter.DataRecord)record;
					fl = dr.FieldLayout;
					if (fl != lastFl)
					{
						lastFl = fl;
						if (!filterMap.TryGetValue(fl, out lastFilter))
						{
							global::Infragistics.Windows.DataPresenter.Field fieldFromMappedField = fl.GetFieldFromMappedField(this._filterInfo.Field);
							global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.FieldFilterInfo fieldFilterInfo = new global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.FieldFilterInfo(dr.RecordManager.RecordFiltersResolved, fieldFromMappedField);
							lastFilter = new global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.FieldFilterInfo.MeetsCriteria_Filter(fieldFilterInfo, includeFilteredOutValues, fieldFilterInfo.RecordFilter);
							filterMap[fl] = lastFilter;
						}
					}
					if (lastFilter.MeetsCriteria(dr))
					{
						yield return dr;
					}
				}
				yield break;
			}

			// Token: 0x060013CF RID: 5071 RVA: 0x000575F8 File Offset: 0x000557F8
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

			// Token: 0x060013D0 RID: 5072 RVA: 0x000576C4 File Offset: 0x000558C4
			private void OnTimerTick(object sender, global::System.EventArgs e)
			{
				this._timer.Stop();
				this.ProcessPhase2Items(this._asynchLoadDuration);
			}

			// Token: 0x060013D1 RID: 5073 RVA: 0x000576E0 File Offset: 0x000558E0
			private void ProcessPhase2Items(int maxMs)
			{
				if (this._aborted)
				{
					return;
				}
				global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = this._filterInfo.Field.Owner;
				bool isTreeView = fieldLayout.IsTreeView;
				global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout2 = fieldLayout;
				global::Infragistics.Windows.DataPresenter.CellTextConverterInfo cellTextConverterInfo = this._cellTextConverter;
				global::Infragistics.Windows.DataPresenter.RecordManager.SameFieldRecordsSortComparer.FieldSortInfo fieldSortInfo = this._comparer._fieldSortInfo;
				global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.FieldLayout, global::System.Tuple<global::Infragistics.Windows.DataPresenter.CellTextConverterInfo, global::Infragistics.Windows.DataPresenter.RecordManager.SameFieldRecordsSortComparer.FieldSortInfo>> dictionary = isTreeView ? new global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.FieldLayout, global::System.Tuple<global::Infragistics.Windows.DataPresenter.CellTextConverterInfo, global::Infragistics.Windows.DataPresenter.RecordManager.SameFieldRecordsSortComparer.FieldSortInfo>>() : null;
				if (isTreeView)
				{
					dictionary.Add(fieldLayout2, global::System.Tuple.Create<global::Infragistics.Windows.DataPresenter.CellTextConverterInfo, global::Infragistics.Windows.DataPresenter.RecordManager.SameFieldRecordsSortComparer.FieldSortInfo>(cellTextConverterInfo, fieldSortInfo));
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
					fieldLayout = dataRecord.FieldLayout;
					if (dictionary != null && fieldLayout2 != fieldLayout)
					{
						global::System.Tuple<global::Infragistics.Windows.DataPresenter.CellTextConverterInfo, global::Infragistics.Windows.DataPresenter.RecordManager.SameFieldRecordsSortComparer.FieldSortInfo> tuple = null;
						fieldLayout2 = fieldLayout;
						if (!dictionary.TryGetValue(fieldLayout2, out tuple))
						{
							global::Infragistics.Windows.DataPresenter.Field fieldFromMappedField = fieldLayout2.GetFieldFromMappedField(this._filterInfo.Field);
							cellTextConverterInfo = global::Infragistics.Windows.DataPresenter.CellTextConverterInfo.GetCachedConverter(fieldFromMappedField);
							fieldSortInfo = new global::Infragistics.Windows.DataPresenter.RecordManager.SameFieldRecordsSortComparer.FieldSortInfo(fieldFromMappedField);
							dictionary[fieldLayout2] = global::System.Tuple.Create<global::Infragistics.Windows.DataPresenter.CellTextConverterInfo, global::Infragistics.Windows.DataPresenter.RecordManager.SameFieldRecordsSortComparer.FieldSortInfo>(cellTextConverterInfo, fieldSortInfo);
						}
						else
						{
							cellTextConverterInfo = tuple.Item1;
							fieldSortInfo = tuple.Item2;
						}
					}
					string text;
					object cellValueForFilterComparisonHelper = global::Infragistics.Windows.DataPresenter.FilterConditionEvaluationContextBase.GetCellValueForFilterComparisonHelper(cellTextConverterInfo, dataRecord, false, out text);
					if (global::Infragistics.Windows.DataPresenter.GridUtilities.IsNullOrEmpty(cellValueForFilterComparisonHelper))
					{
						this._hasNullValues = true;
					}
					else if (!this._uniqueCellValues.Exists(cellValueForFilterComparisonHelper))
					{
						if (cellTextConverterInfo.CompareByText)
						{
							text = (cellValueForFilterComparisonHelper as string);
						}
						else
						{
							text = cellTextConverterInfo.ConvertCellValue(cellValueForFilterComparisonHelper);
						}
						if (!global::Infragistics.Windows.DataPresenter.GridUtilities.IsNullOrEmpty(text))
						{
							this._uniqueCellValues.Add(cellValueForFilterComparisonHelper);
							global::Infragistics.Windows.DataPresenter.FilterDropDownItem filterDropDownItem = new global::Infragistics.Windows.DataPresenter.FilterDropDownItem(cellValueForFilterComparisonHelper, text, true);
							list.Add(filterDropDownItem);
							filterDropDownItem._cellInfo = fieldSortInfo.GetCellInfo(dataRecord);
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

			// Token: 0x060013D2 RID: 5074 RVA: 0x00057C70 File Offset: 0x00055E70
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

			// Token: 0x04000806 RID: 2054
			private global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.FieldFilterInfo _filterInfo;

			// Token: 0x04000807 RID: 2055
			private global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.DataRecord> _recordEnumerator;

			// Token: 0x04000808 RID: 2056
			private global::Infragistics.Collections.ObservableCollectionExtended<global::Infragistics.Windows.DataPresenter.FilterDropDownItem> _items;

			// Token: 0x04000809 RID: 2057
			private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.FilterDropDownItem> _phase1Items;

			// Token: 0x0400080A RID: 2058
			private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.FilterDropDownItem> _phase2Items;

			// Token: 0x0400080B RID: 2059
			private global::Infragistics.Windows.DataPresenter.CellTextConverterInfo _cellTextConverter;

			// Token: 0x0400080C RID: 2060
			private global::System.Windows.Threading.DispatcherTimer _timer;

			// Token: 0x0400080D RID: 2061
			private global::System.Globalization.CultureInfo _fieldConversionCulture;

			// Token: 0x0400080E RID: 2062
			private int _asynchLoadDuration = 50;

			// Token: 0x0400080F RID: 2063
			private int _asynchLoadInterval = 50;

			// Token: 0x04000810 RID: 2064
			private int _asynchLoadThreshhold = 1000;

			// Token: 0x04000811 RID: 2065
			private global::Infragistics.Windows.Helpers.HashSet _uniqueCellValues = new global::Infragistics.Windows.Helpers.HashSet();

			// Token: 0x04000812 RID: 2066
			private global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.FilterDropDownItem, string> _itemToOriginalTextMap = new global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.FilterDropDownItem, string>();

			// Token: 0x04000813 RID: 2067
			private bool _endReached;

			// Token: 0x04000814 RID: 2068
			private bool _aborted;

			// Token: 0x04000815 RID: 2069
			private bool _forCustomFilterSelectionControl;

			// Token: 0x04000816 RID: 2070
			private bool _uniqueValuesLoadPending;

			// Token: 0x04000817 RID: 2071
			private bool _includeFilteredOutValues;

			// Token: 0x04000818 RID: 2072
			private global::Infragistics.Windows.Editors.XamComboEditor _editor;

			// Token: 0x04000819 RID: 2073
			private global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.FieldFilterInfo.FilterDropDownItemComparer _comparer;

			// Token: 0x0400081A RID: 2074
			private global::Infragistics.Windows.DataPresenter.FieldMenuDataItem _rootMenuItem;

			// Token: 0x0400081B RID: 2075
			private bool _hasNullValues;
		}
	}
}
