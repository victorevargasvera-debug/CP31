using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity.Core.Common.QueryCache;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Core.Mapping;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Data.Entity.Core.Objects.ELinq;
using System.Data.Entity.Core.Objects.Internal;
using System.Data.Entity.Core.Query.InternalTrees;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace System.Data.Entity.Core.Common.Internal.Materialization
{
	// Token: 0x02000643 RID: 1603
	internal class Translator
	{
		// Token: 0x06004D42 RID: 19778 RVA: 0x0010FF00 File Offset: 0x0010E100
		internal virtual global::System.Data.Entity.Core.Common.Internal.Materialization.ShaperFactory<T> TranslateColumnMap<T>(global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap columnMap, global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace workspace, global::System.Data.Entity.Core.Objects.Internal.SpanIndex spanIndex, global::System.Data.Entity.Core.Objects.MergeOption mergeOption, bool streaming, bool valueLayer)
		{
			global::System.Data.Entity.Core.Common.QueryCache.ShaperFactoryQueryCacheKey<T> shaperFactoryQueryCacheKey = new global::System.Data.Entity.Core.Common.QueryCache.ShaperFactoryQueryCacheKey<T>(global::System.Data.Entity.Core.Common.Internal.Materialization.ColumnMapKeyBuilder.GetColumnMapKey(columnMap, spanIndex), mergeOption, streaming, valueLayer);
			global::System.Data.Entity.Core.Common.QueryCache.QueryCacheManager queryCacheManager = workspace.GetQueryCacheManager();
			global::System.Data.Entity.Core.Common.Internal.Materialization.ShaperFactory<T> shaperFactory;
			if (queryCacheManager.TryCacheLookup<global::System.Data.Entity.Core.Common.QueryCache.ShaperFactoryQueryCacheKey<T>, global::System.Data.Entity.Core.Common.Internal.Materialization.ShaperFactory<T>>(shaperFactoryQueryCacheKey, out shaperFactory))
			{
				return shaperFactory;
			}
			global::System.Data.Entity.Core.Common.Internal.Materialization.Translator.TranslatorVisitor translatorVisitor = new global::System.Data.Entity.Core.Common.Internal.Materialization.Translator.TranslatorVisitor(workspace, spanIndex, mergeOption, streaming, valueLayer);
			columnMap.Accept<global::System.Data.Entity.Core.Common.Internal.Materialization.TranslatorResult, global::System.Data.Entity.Core.Common.Internal.Materialization.TranslatorArg>(translatorVisitor, new global::System.Data.Entity.Core.Common.Internal.Materialization.TranslatorArg(typeof(global::System.Collections.Generic.IEnumerable<>).MakeGenericType(new global::System.Type[]
			{
				typeof(T)
			})));
			global::System.Data.Entity.Core.Common.Internal.Materialization.CoordinatorFactory<T> rootCoordinatorFactory = (global::System.Data.Entity.Core.Common.Internal.Materialization.CoordinatorFactory<T>)translatorVisitor.RootCoordinatorScratchpad.Compile();
			global::System.Type[] array = null;
			bool[] array2 = null;
			if (!streaming)
			{
				int num = global::System.Math.Max(translatorVisitor.ColumnTypes.Any<global::System.Collections.Generic.KeyValuePair<int, global::System.Type>>() ? translatorVisitor.ColumnTypes.Keys.Max() : 0, translatorVisitor.NullableColumns.Any<int>() ? translatorVisitor.NullableColumns.Max() : 0);
				array = new global::System.Type[num + 1];
				foreach (global::System.Collections.Generic.KeyValuePair<int, global::System.Type> keyValuePair in translatorVisitor.ColumnTypes)
				{
					array[keyValuePair.Key] = keyValuePair.Value;
				}
				array2 = new bool[num + 1];
				foreach (int num2 in translatorVisitor.NullableColumns)
				{
					array2[num2] = true;
				}
			}
			shaperFactory = new global::System.Data.Entity.Core.Common.Internal.Materialization.ShaperFactory<T>(translatorVisitor.StateSlotCount, rootCoordinatorFactory, array, array2, mergeOption);
			global::System.Data.Entity.Core.Common.QueryCache.QueryCacheEntry queryCacheEntry = new global::System.Data.Entity.Core.Common.QueryCache.QueryCacheEntry(shaperFactoryQueryCacheKey, shaperFactory);
			if (queryCacheManager.TryLookupAndAdd(queryCacheEntry, out queryCacheEntry))
			{
				shaperFactory = (global::System.Data.Entity.Core.Common.Internal.Materialization.ShaperFactory<T>)queryCacheEntry.GetTarget();
			}
			return shaperFactory;
		}

		// Token: 0x06004D43 RID: 19779 RVA: 0x001100B4 File Offset: 0x0010E2B4
		internal static global::System.Data.Entity.Core.Common.Internal.Materialization.ShaperFactory TranslateColumnMap(global::System.Data.Entity.Core.Common.Internal.Materialization.Translator translator, global::System.Type elementType, global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap columnMap, global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace workspace, global::System.Data.Entity.Core.Objects.Internal.SpanIndex spanIndex, global::System.Data.Entity.Core.Objects.MergeOption mergeOption, bool streaming, bool valueLayer)
		{
			return (global::System.Data.Entity.Core.Common.Internal.Materialization.ShaperFactory)global::System.Data.Entity.Core.Common.Internal.Materialization.Translator.GenericTranslateColumnMap.MakeGenericMethod(new global::System.Type[]
			{
				elementType
			}).Invoke(translator, new object[]
			{
				columnMap,
				workspace,
				spanIndex,
				mergeOption,
				streaming,
				valueLayer
			});
		}

		// Token: 0x04001B70 RID: 7024
		public static readonly global::System.Reflection.MethodInfo GenericTranslateColumnMap = typeof(global::System.Data.Entity.Core.Common.Internal.Materialization.Translator).GetDeclaredMethod("TranslateColumnMap", new global::System.Type[]
		{
			typeof(global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap),
			typeof(global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace),
			typeof(global::System.Data.Entity.Core.Objects.Internal.SpanIndex),
			typeof(global::System.Data.Entity.Core.Objects.MergeOption),
			typeof(bool),
			typeof(bool)
		});

		// Token: 0x02000C6A RID: 3178
		internal class TranslatorVisitor : global::System.Data.Entity.Core.Query.InternalTrees.ColumnMapVisitorWithResults<global::System.Data.Entity.Core.Common.Internal.Materialization.TranslatorResult, global::System.Data.Entity.Core.Common.Internal.Materialization.TranslatorArg>
		{
			// Token: 0x06006B1C RID: 27420 RVA: 0x0016CA80 File Offset: 0x0016AC80
			public TranslatorVisitor(global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace workspace, global::System.Data.Entity.Core.Objects.Internal.SpanIndex spanIndex, global::System.Data.Entity.Core.Objects.MergeOption mergeOption, bool streaming, bool valueLayer)
			{
				this._workspace = workspace;
				this._spanIndex = spanIndex;
				this._mergeOption = mergeOption;
				this._streaming = streaming;
				this.ColumnTypes = new global::System.Collections.Generic.Dictionary<int, global::System.Type>();
				this.NullableColumns = new global::System.Data.Entity.Core.Common.Utils.Set<int>();
				this.IsValueLayer = valueLayer;
			}

			// Token: 0x1700118F RID: 4495
			// (get) Token: 0x06006B1D RID: 27421 RVA: 0x0016CAD9 File Offset: 0x0016ACD9
			// (set) Token: 0x06006B1E RID: 27422 RVA: 0x0016CAE1 File Offset: 0x0016ACE1
			public global::System.Data.Entity.Core.Common.Internal.Materialization.CoordinatorScratchpad RootCoordinatorScratchpad { get; private set; }

			// Token: 0x17001190 RID: 4496
			// (get) Token: 0x06006B1F RID: 27423 RVA: 0x0016CAEA File Offset: 0x0016ACEA
			// (set) Token: 0x06006B20 RID: 27424 RVA: 0x0016CAF2 File Offset: 0x0016ACF2
			public int StateSlotCount { get; private set; }

			// Token: 0x17001191 RID: 4497
			// (get) Token: 0x06006B21 RID: 27425 RVA: 0x0016CAFB File Offset: 0x0016ACFB
			// (set) Token: 0x06006B22 RID: 27426 RVA: 0x0016CB03 File Offset: 0x0016AD03
			public global::System.Collections.Generic.Dictionary<int, global::System.Type> ColumnTypes { get; private set; }

			// Token: 0x17001192 RID: 4498
			// (get) Token: 0x06006B23 RID: 27427 RVA: 0x0016CB0C File Offset: 0x0016AD0C
			// (set) Token: 0x06006B24 RID: 27428 RVA: 0x0016CB14 File Offset: 0x0016AD14
			public global::System.Data.Entity.Core.Common.Utils.Set<int> NullableColumns { get; private set; }

			// Token: 0x06006B25 RID: 27429 RVA: 0x0016CB20 File Offset: 0x0016AD20
			private static global::System.Data.Entity.Core.Common.Internal.Materialization.TranslatorResult AcceptWithMappedType(global::System.Data.Entity.Core.Common.Internal.Materialization.Translator.TranslatorVisitor translatorVisitor, global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap columnMap)
			{
				global::System.Type requestedType = translatorVisitor.DetermineClrType(columnMap.Type);
				return columnMap.Accept<global::System.Data.Entity.Core.Common.Internal.Materialization.TranslatorResult, global::System.Data.Entity.Core.Common.Internal.Materialization.TranslatorArg>(translatorVisitor, new global::System.Data.Entity.Core.Common.Internal.Materialization.TranslatorArg(requestedType));
			}

			// Token: 0x06006B26 RID: 27430 RVA: 0x0016CB48 File Offset: 0x0016AD48
			internal override global::System.Data.Entity.Core.Common.Internal.Materialization.TranslatorResult Visit(global::System.Data.Entity.Core.Query.InternalTrees.ComplexTypeColumnMap columnMap, global::System.Data.Entity.Core.Common.Internal.Materialization.TranslatorArg arg)
			{
				global::System.Linq.Expressions.Expression expression = null;
				bool inNullableType = this._inNullableType;
				if (columnMap.NullSentinel != null)
				{
					expression = global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.Emit_Reader_IsDBNull(columnMap.NullSentinel);
					this._inNullableType = true;
					int columnPos = ((global::System.Data.Entity.Core.Query.InternalTrees.ScalarColumnMap)columnMap.NullSentinel).ColumnPos;
					if (!this._streaming && !this.NullableColumns.Contains(columnPos))
					{
						this.NullableColumns.Add(columnPos);
					}
				}
				global::System.Linq.Expressions.Expression expression2;
				if (this.IsValueLayer)
				{
					expression2 = this.BuildExpressionToGetRecordState(columnMap, null, null, expression);
				}
				else
				{
					global::System.Data.Entity.Core.Metadata.Edm.ComplexType complexType = (global::System.Data.Entity.Core.Metadata.Edm.ComplexType)columnMap.Type.EdmType;
					global::System.Reflection.ConstructorInfo constructorForType = global::System.Data.Entity.Core.Objects.DelegateFactory.GetConstructorForType(this.DetermineClrType(complexType));
					global::System.Collections.Generic.List<global::System.Linq.Expressions.MemberBinding> bindings = this.CreatePropertyBindings(columnMap, complexType.Properties);
					expression2 = global::System.Linq.Expressions.Expression.MemberInit(global::System.Linq.Expressions.Expression.New(constructorForType), bindings);
					if (expression != null)
					{
						expression2 = global::System.Linq.Expressions.Expression.Condition(expression, global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.Emit_NullConstant(expression2.Type), expression2);
					}
				}
				this._inNullableType = inNullableType;
				return new global::System.Data.Entity.Core.Common.Internal.Materialization.TranslatorResult(expression2, arg.RequestedType);
			}

			// Token: 0x06006B27 RID: 27431 RVA: 0x0016CC28 File Offset: 0x0016AE28
			internal override global::System.Data.Entity.Core.Common.Internal.Materialization.TranslatorResult Visit(global::System.Data.Entity.Core.Query.InternalTrees.EntityColumnMap columnMap, global::System.Data.Entity.Core.Common.Internal.Materialization.TranslatorArg arg)
			{
				global::System.Data.Entity.Core.Query.InternalTrees.EntityIdentity entityIdentity = columnMap.EntityIdentity;
				global::System.Linq.Expressions.Expression expression = null;
				global::System.Linq.Expressions.Expression expression2 = this.Emit_EntityKey_ctor(this, entityIdentity, columnMap.Type.EdmType, false, out expression);
				global::System.Linq.Expressions.Expression returnedExpression;
				if (this.IsValueLayer)
				{
					global::System.Linq.Expressions.Expression nullCheckExpression = global::System.Linq.Expressions.Expression.Not(global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.Emit_EntityKey_HasValue(entityIdentity.Keys));
					returnedExpression = this.BuildExpressionToGetRecordState(columnMap, expression2, expression, nullCheckExpression);
				}
				else
				{
					global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType = (global::System.Data.Entity.Core.Metadata.Edm.EntityType)columnMap.Type.EdmType;
					global::System.Data.Entity.Core.Metadata.Edm.ClrEntityType clrEntityType = (global::System.Data.Entity.Core.Metadata.Edm.ClrEntityType)this.LookupObjectMapping(entityType).ClrType;
					global::System.Type clrType = clrEntityType.ClrType;
					global::System.Collections.Generic.List<global::System.Linq.Expressions.MemberBinding> propertyBindings = this.CreatePropertyBindings(columnMap, entityType.Properties);
					global::System.Data.Entity.Core.Objects.Internal.EntityProxyTypeInfo proxyType = global::System.Data.Entity.Core.Objects.Internal.EntityProxyFactory.GetProxyType(clrEntityType, this._workspace);
					global::System.Linq.Expressions.Expression expression3 = this.Emit_ConstructEntity(clrEntityType, propertyBindings, expression2, expression, arg, null);
					global::System.Linq.Expressions.Expression expression4;
					if (proxyType == null)
					{
						expression4 = expression3;
					}
					else
					{
						global::System.Linq.Expressions.Expression ifTrue = this.Emit_ConstructEntity(clrEntityType, propertyBindings, expression2, expression, arg, proxyType);
						expression4 = global::System.Linq.Expressions.Expression.Condition(global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.Shaper_ProxyCreationEnabled, ifTrue, expression3);
					}
					if (global::System.Data.Entity.Core.Objects.MergeOption.NoTracking != this._mergeOption)
					{
						global::System.Type c = (proxyType == null) ? clrType : proxyType.ProxyType;
						if (typeof(global::System.Data.Entity.Core.Objects.DataClasses.IEntityWithKey).IsAssignableFrom(c) && this._mergeOption != global::System.Data.Entity.Core.Objects.MergeOption.AppendOnly)
						{
							expression4 = global::System.Linq.Expressions.Expression.Call(global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.Shaper_Parameter, global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.Shaper_HandleIEntityWithKey.MakeGenericMethod(new global::System.Type[]
							{
								clrType
							}), expression4, expression);
						}
						else if (this._mergeOption == global::System.Data.Entity.Core.Objects.MergeOption.AppendOnly)
						{
							global::System.Linq.Expressions.LambdaExpression arg2 = this.CreateInlineDelegate(expression4);
							expression4 = global::System.Linq.Expressions.Expression.Call(global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.Shaper_Parameter, global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.Shaper_HandleEntityAppendOnly.MakeGenericMethod(new global::System.Type[]
							{
								clrType
							}), arg2, expression2, expression);
						}
						else
						{
							expression4 = global::System.Linq.Expressions.Expression.Call(global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.Shaper_Parameter, global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.Shaper_HandleEntity.MakeGenericMethod(new global::System.Type[]
							{
								clrType
							}), expression4, expression2, expression);
						}
					}
					else
					{
						expression4 = global::System.Linq.Expressions.Expression.Call(global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.Shaper_Parameter, global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.Shaper_HandleEntityNoTracking.MakeGenericMethod(new global::System.Type[]
						{
							clrType
						}), new global::System.Linq.Expressions.Expression[]
						{
							expression4
						});
					}
					returnedExpression = global::System.Linq.Expressions.Expression.Condition(global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.Emit_EntityKey_HasValue(entityIdentity.Keys), expression4, global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.Emit_WrappedNullConstant());
				}
				int columnPos = ((global::System.Data.Entity.Core.Query.InternalTrees.ScalarColumnMap)entityIdentity.Keys[0]).ColumnPos;
				if (!this._streaming && !this.NullableColumns.Contains(columnPos))
				{
					this.NullableColumns.Add(columnPos);
				}
				return new global::System.Data.Entity.Core.Common.Internal.Materialization.TranslatorResult(returnedExpression, arg.RequestedType);
			}

			// Token: 0x06006B28 RID: 27432 RVA: 0x0016CE58 File Offset: 0x0016B058
			private global::System.Linq.Expressions.Expression Emit_ConstructEntity(global::System.Data.Entity.Core.Metadata.Edm.EntityType oSpaceType, global::System.Collections.Generic.IEnumerable<global::System.Linq.Expressions.MemberBinding> propertyBindings, global::System.Linq.Expressions.Expression entityKeyReader, global::System.Linq.Expressions.Expression entitySetReader, global::System.Data.Entity.Core.Common.Internal.Materialization.TranslatorArg arg, global::System.Data.Entity.Core.Objects.Internal.EntityProxyTypeInfo proxyTypeInfo)
			{
				bool flag = proxyTypeInfo != null;
				global::System.Type clrType = oSpaceType.ClrType;
				global::System.Linq.Expressions.Expression expression;
				global::System.Type actualType;
				if (flag)
				{
					expression = global::System.Linq.Expressions.Expression.MemberInit(global::System.Linq.Expressions.Expression.New(proxyTypeInfo.ProxyType), propertyBindings);
					actualType = proxyTypeInfo.ProxyType;
				}
				else
				{
					expression = global::System.Linq.Expressions.Expression.MemberInit(global::System.Linq.Expressions.Expression.New(global::System.Data.Entity.Core.Objects.DelegateFactory.GetConstructorForType(clrType)), propertyBindings);
					actualType = clrType;
				}
				expression = global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.Emit_EnsureTypeAndWrap(expression, entityKeyReader, entitySetReader, arg.RequestedType, clrType, actualType, (this._mergeOption == global::System.Data.Entity.Core.Objects.MergeOption.NoTracking) ? global::System.Data.Entity.Core.Objects.MergeOption.NoTracking : global::System.Data.Entity.Core.Objects.MergeOption.AppendOnly, flag);
				if (flag)
				{
					expression = global::System.Linq.Expressions.Expression.Call(global::System.Linq.Expressions.Expression.Constant(proxyTypeInfo), global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.EntityProxyTypeInfo_SetEntityWrapper, new global::System.Linq.Expressions.Expression[]
					{
						expression
					});
					if (proxyTypeInfo.InitializeEntityCollections != null)
					{
						expression = global::System.Linq.Expressions.Expression.Call(proxyTypeInfo.InitializeEntityCollections, expression);
					}
				}
				return expression;
			}

			// Token: 0x06006B29 RID: 27433 RVA: 0x0016CF04 File Offset: 0x0016B104
			private global::System.Collections.Generic.List<global::System.Linq.Expressions.MemberBinding> CreatePropertyBindings(global::System.Data.Entity.Core.Query.InternalTrees.StructuredColumnMap columnMap, global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> properties)
			{
				global::System.Collections.Generic.List<global::System.Linq.Expressions.MemberBinding> list = new global::System.Collections.Generic.List<global::System.Linq.Expressions.MemberBinding>(columnMap.Properties.Length);
				global::System.Data.Entity.Core.Mapping.ObjectTypeMapping objectTypeMapping = this.LookupObjectMapping(columnMap.Type.EdmType);
				for (int i = 0; i < columnMap.Properties.Length; i++)
				{
					global::System.Reflection.PropertyInfo propertyInfo = global::System.Data.Entity.Core.Objects.DelegateFactory.ValidateSetterProperty(objectTypeMapping.GetPropertyMap(properties[i].Name).ClrProperty.PropertyInfo);
					global::System.Reflection.MethodInfo methodInfo = propertyInfo.Setter();
					global::System.Type propertyType = propertyInfo.PropertyType;
					global::System.Linq.Expressions.Expression expression = columnMap.Properties[i].Accept<global::System.Data.Entity.Core.Common.Internal.Materialization.TranslatorResult, global::System.Data.Entity.Core.Common.Internal.Materialization.TranslatorArg>(this, new global::System.Data.Entity.Core.Common.Internal.Materialization.TranslatorArg(propertyType)).Expression;
					global::System.Data.Entity.Core.Query.InternalTrees.ScalarColumnMap scalarColumnMap = columnMap.Properties[i] as global::System.Data.Entity.Core.Query.InternalTrees.ScalarColumnMap;
					if (scalarColumnMap != null)
					{
						string propertyName = methodInfo.Name.Substring(4);
						global::System.Linq.Expressions.Expression expressionWithErrorHandling = global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.Emit_Shaper_GetPropertyValueWithErrorHandling(propertyType, scalarColumnMap.ColumnPos, propertyName, methodInfo.DeclaringType.Name, scalarColumnMap.Type);
						this._currentCoordinatorScratchpad.AddExpressionWithErrorHandling(expression, expressionWithErrorHandling);
					}
					list.Add(global::System.Linq.Expressions.Expression.Bind(propertyInfo, expression));
				}
				return list;
			}

			// Token: 0x06006B2A RID: 27434 RVA: 0x0016D000 File Offset: 0x0016B200
			internal override global::System.Data.Entity.Core.Common.Internal.Materialization.TranslatorResult Visit(global::System.Data.Entity.Core.Query.InternalTrees.SimplePolymorphicColumnMap columnMap, global::System.Data.Entity.Core.Common.Internal.Materialization.TranslatorArg arg)
			{
				global::System.Linq.Expressions.Expression expression = global::System.Data.Entity.Core.Common.Internal.Materialization.Translator.TranslatorVisitor.AcceptWithMappedType(this, columnMap.TypeDiscriminator).Expression;
				global::System.Linq.Expressions.Expression expression2;
				if (this.IsValueLayer)
				{
					expression2 = global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.Emit_EnsureType(this.BuildExpressionToGetRecordState(columnMap, null, null, global::System.Linq.Expressions.Expression.Constant(true)), arg.RequestedType);
				}
				else
				{
					expression2 = global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.Emit_WrappedNullConstant();
				}
				foreach (global::System.Collections.Generic.KeyValuePair<object, global::System.Data.Entity.Core.Query.InternalTrees.TypedColumnMap> keyValuePair in columnMap.TypeChoices)
				{
					if (!this.DetermineClrType(keyValuePair.Value.Type).IsAbstract())
					{
						global::System.Linq.Expressions.Expression expression3 = global::System.Linq.Expressions.Expression.Constant(keyValuePair.Key, expression.Type);
						global::System.Linq.Expressions.Expression test;
						if (expression.Type == typeof(string))
						{
							test = global::System.Linq.Expressions.Expression.Call(global::System.Linq.Expressions.Expression.Constant(global::System.Data.Entity.Core.Common.Utils.TrailingSpaceStringComparer.Instance), global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.IEqualityComparerOfString_Equals, expression3, expression);
						}
						else
						{
							test = global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.Emit_Equal(expression3, expression);
						}
						bool inNullableType = this._inNullableType;
						this._inNullableType = true;
						expression2 = global::System.Linq.Expressions.Expression.Condition(test, keyValuePair.Value.Accept<global::System.Data.Entity.Core.Common.Internal.Materialization.TranslatorResult, global::System.Data.Entity.Core.Common.Internal.Materialization.TranslatorArg>(this, arg).Expression, expression2);
						this._inNullableType = inNullableType;
					}
				}
				return new global::System.Data.Entity.Core.Common.Internal.Materialization.TranslatorResult(expression2, arg.RequestedType);
			}

			// Token: 0x06006B2B RID: 27435 RVA: 0x0016D140 File Offset: 0x0016B340
			internal override global::System.Data.Entity.Core.Common.Internal.Materialization.TranslatorResult Visit(global::System.Data.Entity.Core.Query.InternalTrees.MultipleDiscriminatorPolymorphicColumnMap columnMap, global::System.Data.Entity.Core.Common.Internal.Materialization.TranslatorArg arg)
			{
				return new global::System.Data.Entity.Core.Common.Internal.Materialization.TranslatorResult((global::System.Linq.Expressions.Expression)global::System.Data.Entity.Core.Common.Internal.Materialization.Translator.TranslatorVisitor.Translator_MultipleDiscriminatorPolymorphicColumnMapHelper.MakeGenericMethod(new global::System.Type[]
				{
					arg.RequestedType
				}).Invoke(this, new object[]
				{
					columnMap
				}), arg.RequestedType);
			}

			// Token: 0x06006B2C RID: 27436 RVA: 0x0016D17C File Offset: 0x0016B37C
			private global::System.Linq.Expressions.Expression MultipleDiscriminatorPolymorphicColumnMapHelper<TElement>(global::System.Data.Entity.Core.Query.InternalTrees.MultipleDiscriminatorPolymorphicColumnMap columnMap)
			{
				global::System.Linq.Expressions.Expression[] array = new global::System.Linq.Expressions.Expression[columnMap.TypeDiscriminators.Length];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = columnMap.TypeDiscriminators[i].Accept<global::System.Data.Entity.Core.Common.Internal.Materialization.TranslatorResult, global::System.Data.Entity.Core.Common.Internal.Materialization.TranslatorArg>(this, new global::System.Data.Entity.Core.Common.Internal.Materialization.TranslatorArg(typeof(object))).Expression;
				}
				global::System.Linq.Expressions.Expression arg = global::System.Linq.Expressions.Expression.NewArrayInit(typeof(object), array);
				global::System.Collections.Generic.List<global::System.Linq.Expressions.Expression> list = new global::System.Collections.Generic.List<global::System.Linq.Expressions.Expression>();
				global::System.Type typeFromHandle = typeof(global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Metadata.Edm.EntityType, global::System.Func<global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper, TElement>>);
				global::System.Reflection.ConstructorInfo declaredConstructor = typeFromHandle.GetDeclaredConstructor(new global::System.Type[]
				{
					typeof(global::System.Data.Entity.Core.Metadata.Edm.EntityType),
					typeof(global::System.Func<global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper, TElement>)
				});
				foreach (global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Metadata.Edm.EntityType, global::System.Data.Entity.Core.Query.InternalTrees.TypedColumnMap> keyValuePair in columnMap.TypeChoices)
				{
					global::System.Linq.Expressions.Expression body = global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.Emit_EnsureType(global::System.Data.Entity.Core.Common.Internal.Materialization.Translator.TranslatorVisitor.AcceptWithMappedType(this, keyValuePair.Value).UnwrappedExpression, typeof(TElement));
					global::System.Linq.Expressions.LambdaExpression lambdaExpression = this.CreateInlineDelegate(body);
					global::System.Linq.Expressions.Expression item = global::System.Linq.Expressions.Expression.New(declaredConstructor, new global::System.Linq.Expressions.Expression[]
					{
						global::System.Linq.Expressions.Expression.Constant(keyValuePair.Key),
						lambdaExpression
					});
					list.Add(item);
				}
				global::System.Reflection.MethodInfo method = global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.Shaper_Discriminate.MakeGenericMethod(new global::System.Type[]
				{
					typeof(TElement)
				});
				return global::System.Linq.Expressions.Expression.Call(global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.Shaper_Parameter, method, arg, global::System.Linq.Expressions.Expression.Constant(columnMap.Discriminate), global::System.Linq.Expressions.Expression.NewArrayInit(typeFromHandle, list));
			}

			// Token: 0x06006B2D RID: 27437 RVA: 0x0016D2F4 File Offset: 0x0016B4F4
			internal override global::System.Data.Entity.Core.Common.Internal.Materialization.TranslatorResult Visit(global::System.Data.Entity.Core.Query.InternalTrees.RecordColumnMap columnMap, global::System.Data.Entity.Core.Common.Internal.Materialization.TranslatorArg arg)
			{
				global::System.Linq.Expressions.Expression expression = null;
				bool inNullableType = this._inNullableType;
				if (columnMap.NullSentinel != null)
				{
					expression = global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.Emit_Reader_IsDBNull(columnMap.NullSentinel);
					this._inNullableType = true;
					int columnPos = ((global::System.Data.Entity.Core.Query.InternalTrees.ScalarColumnMap)columnMap.NullSentinel).ColumnPos;
					if (!this._streaming && !this.NullableColumns.Contains(columnPos))
					{
						this.NullableColumns.Add(columnPos);
					}
				}
				global::System.Linq.Expressions.Expression expression2;
				if (this.IsValueLayer)
				{
					expression2 = this.BuildExpressionToGetRecordState(columnMap, null, null, expression);
				}
				else
				{
					global::System.Data.Entity.Core.Objects.ELinq.InitializerMetadata initializerMetadata;
					global::System.Linq.Expressions.Expression ifTrue;
					if (global::System.Data.Entity.Core.Objects.ELinq.InitializerMetadata.TryGetInitializerMetadata(columnMap.Type, out initializerMetadata))
					{
						expression2 = this.HandleLinqRecord(columnMap, initializerMetadata);
						ifTrue = global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.Emit_NullConstant(expression2.Type);
					}
					else
					{
						global::System.Data.Entity.Core.Metadata.Edm.RowType spanRowType = (global::System.Data.Entity.Core.Metadata.Edm.RowType)columnMap.Type.EdmType;
						if (this._spanIndex != null && this._spanIndex.HasSpanMap(spanRowType))
						{
							expression2 = this.HandleSpandexRecord(columnMap, arg, spanRowType);
							ifTrue = global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.Emit_WrappedNullConstant();
						}
						else
						{
							expression2 = this.HandleRegularRecord(columnMap, arg, spanRowType);
							ifTrue = global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.Emit_NullConstant(expression2.Type);
						}
					}
					if (expression != null)
					{
						expression2 = global::System.Linq.Expressions.Expression.Condition(expression, ifTrue, expression2);
					}
				}
				this._inNullableType = inNullableType;
				return new global::System.Data.Entity.Core.Common.Internal.Materialization.TranslatorResult(expression2, arg.RequestedType);
			}

			// Token: 0x06006B2E RID: 27438 RVA: 0x0016D410 File Offset: 0x0016B610
			private global::System.Linq.Expressions.Expression BuildExpressionToGetRecordState(global::System.Data.Entity.Core.Query.InternalTrees.StructuredColumnMap columnMap, global::System.Linq.Expressions.Expression entityKeyReader, global::System.Linq.Expressions.Expression entitySetReader, global::System.Linq.Expressions.Expression nullCheckExpression)
			{
				global::System.Data.Entity.Core.Common.Internal.Materialization.RecordStateScratchpad recordStateScratchpad = this._currentCoordinatorScratchpad.CreateRecordStateScratchpad();
				int num = this.AllocateStateSlot();
				recordStateScratchpad.StateSlotNumber = num;
				int num2 = columnMap.Properties.Length;
				int num3 = (entityKeyReader != null) ? (num2 + 1) : num2;
				recordStateScratchpad.ColumnCount = num2;
				global::System.Data.Entity.Core.Metadata.Edm.EntityType metadata = null;
				if (global::System.Data.Entity.Core.Common.TypeHelpers.TryGetEdmType<global::System.Data.Entity.Core.Metadata.Edm.EntityType>(columnMap.Type, out metadata))
				{
					recordStateScratchpad.DataRecordInfo = new global::System.Data.Entity.Core.Common.EntityRecordInfo(metadata, global::System.Data.Entity.Core.EntityKey.EntityNotValidKey, null);
				}
				else
				{
					global::System.Data.Entity.Core.Metadata.Edm.TypeUsage modelTypeUsage = global::System.Data.Entity.Core.Metadata.Edm.Helper.GetModelTypeUsage(columnMap.Type);
					recordStateScratchpad.DataRecordInfo = new global::System.Data.Entity.Core.Common.DataRecordInfo(modelTypeUsage);
				}
				global::System.Linq.Expressions.Expression[] array = new global::System.Linq.Expressions.Expression[num3];
				string[] array2 = new string[recordStateScratchpad.ColumnCount];
				global::System.Data.Entity.Core.Metadata.Edm.TypeUsage[] array3 = new global::System.Data.Entity.Core.Metadata.Edm.TypeUsage[recordStateScratchpad.ColumnCount];
				for (int i = 0; i < num2; i++)
				{
					global::System.Linq.Expressions.Expression expression = columnMap.Properties[i].Accept<global::System.Data.Entity.Core.Common.Internal.Materialization.TranslatorResult, global::System.Data.Entity.Core.Common.Internal.Materialization.TranslatorArg>(this, new global::System.Data.Entity.Core.Common.Internal.Materialization.TranslatorArg(typeof(object))).Expression;
					array[i] = global::System.Linq.Expressions.Expression.Call(global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.Shaper_Parameter, global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.Shaper_SetColumnValue, global::System.Linq.Expressions.Expression.Constant(num), global::System.Linq.Expressions.Expression.Constant(i), global::System.Linq.Expressions.Expression.Coalesce(expression, global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.DBNull_Value));
					array2[i] = columnMap.Properties[i].Name;
					array3[i] = columnMap.Properties[i].Type;
				}
				if (entityKeyReader != null)
				{
					array[num3 - 1] = global::System.Linq.Expressions.Expression.Call(global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.Shaper_Parameter, global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.Shaper_SetEntityRecordInfo, global::System.Linq.Expressions.Expression.Constant(num), entityKeyReader, entitySetReader);
				}
				recordStateScratchpad.GatherData = global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.Emit_BitwiseOr(array);
				recordStateScratchpad.PropertyNames = array2;
				recordStateScratchpad.TypeUsages = array3;
				global::System.Linq.Expressions.Expression expression2 = global::System.Linq.Expressions.Expression.Call(global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.Emit_Shaper_GetState(num, typeof(global::System.Data.Entity.Core.Common.Internal.Materialization.RecordState)), global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.RecordState_GatherData, new global::System.Linq.Expressions.Expression[]
				{
					global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.Shaper_Parameter
				});
				if (nullCheckExpression != null)
				{
					global::System.Linq.Expressions.Expression ifTrue = global::System.Linq.Expressions.Expression.Call(global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.Emit_Shaper_GetState(num, typeof(global::System.Data.Entity.Core.Common.Internal.Materialization.RecordState)), global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.RecordState_SetNullRecord);
					expression2 = global::System.Linq.Expressions.Expression.Condition(nullCheckExpression, ifTrue, expression2);
				}
				return expression2;
			}

			// Token: 0x06006B2F RID: 27439 RVA: 0x0016D5E8 File Offset: 0x0016B7E8
			private global::System.Linq.Expressions.Expression HandleLinqRecord(global::System.Data.Entity.Core.Query.InternalTrees.RecordColumnMap columnMap, global::System.Data.Entity.Core.Objects.ELinq.InitializerMetadata initializerMetadata)
			{
				global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.Internal.Materialization.TranslatorResult> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.Internal.Materialization.TranslatorResult>(columnMap.Properties.Length);
				foreach (global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap, global::System.Type> keyValuePair in columnMap.Properties.Zip(initializerMetadata.GetChildTypes()))
				{
					global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap key = keyValuePair.Key;
					global::System.Type type = keyValuePair.Value;
					if (null == type)
					{
						type = this.DetermineClrType(key.Type);
					}
					global::System.Data.Entity.Core.Common.Internal.Materialization.TranslatorResult item = key.Accept<global::System.Data.Entity.Core.Common.Internal.Materialization.TranslatorResult, global::System.Data.Entity.Core.Common.Internal.Materialization.TranslatorArg>(this, new global::System.Data.Entity.Core.Common.Internal.Materialization.TranslatorArg(type));
					list.Add(item);
				}
				return initializerMetadata.Emit(list);
			}

			// Token: 0x06006B30 RID: 27440 RVA: 0x0016D690 File Offset: 0x0016B890
			private global::System.Linq.Expressions.Expression HandleRegularRecord(global::System.Data.Entity.Core.Query.InternalTrees.RecordColumnMap columnMap, global::System.Data.Entity.Core.Common.Internal.Materialization.TranslatorArg arg, global::System.Data.Entity.Core.Metadata.Edm.RowType spanRowType)
			{
				global::System.Linq.Expressions.Expression[] array = new global::System.Linq.Expressions.Expression[columnMap.Properties.Length];
				for (int i = 0; i < array.Length; i++)
				{
					global::System.Linq.Expressions.Expression unwrappedExpression = global::System.Data.Entity.Core.Common.Internal.Materialization.Translator.TranslatorVisitor.AcceptWithMappedType(this, columnMap.Properties[i]).UnwrappedExpression;
					array[i] = global::System.Linq.Expressions.Expression.Coalesce(global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.Emit_EnsureType(unwrappedExpression, typeof(object)), global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.DBNull_Value);
				}
				global::System.Linq.Expressions.Expression expression = global::System.Linq.Expressions.Expression.NewArrayInit(typeof(object), array);
				global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage = columnMap.Type;
				if (this._spanIndex != null)
				{
					typeUsage = (this._spanIndex.GetSpannedRowType(spanRowType) ?? typeUsage);
				}
				global::System.Linq.Expressions.Expression expression2 = global::System.Linq.Expressions.Expression.Constant(typeUsage, typeof(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage));
				return global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.Emit_EnsureType(global::System.Linq.Expressions.Expression.New(global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.MaterializedDataRecord_ctor, new global::System.Linq.Expressions.Expression[]
				{
					global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.Shaper_Workspace,
					expression2,
					expression
				}), arg.RequestedType);
			}

			// Token: 0x06006B31 RID: 27441 RVA: 0x0016D760 File Offset: 0x0016B960
			private global::System.Linq.Expressions.Expression HandleSpandexRecord(global::System.Data.Entity.Core.Query.InternalTrees.RecordColumnMap columnMap, global::System.Data.Entity.Core.Common.Internal.Materialization.TranslatorArg arg, global::System.Data.Entity.Core.Metadata.Edm.RowType spanRowType)
			{
				global::System.Collections.Generic.Dictionary<int, global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember> spanMap = this._spanIndex.GetSpanMap(spanRowType);
				global::System.Linq.Expressions.Expression expression = columnMap.Properties[0].Accept<global::System.Data.Entity.Core.Common.Internal.Materialization.TranslatorResult, global::System.Data.Entity.Core.Common.Internal.Materialization.TranslatorArg>(this, arg).Expression;
				for (int i = 1; i < columnMap.Properties.Length; i++)
				{
					global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember value = spanMap[i];
					global::System.Data.Entity.Core.Common.Internal.Materialization.TranslatorResult translatorResult = global::System.Data.Entity.Core.Common.Internal.Materialization.Translator.TranslatorVisitor.AcceptWithMappedType(this, columnMap.Properties[i]);
					global::System.Linq.Expressions.Expression expression2 = translatorResult.Expression;
					global::System.Data.Entity.Core.Common.Internal.Materialization.CollectionTranslatorResult collectionTranslatorResult = translatorResult as global::System.Data.Entity.Core.Common.Internal.Materialization.CollectionTranslatorResult;
					if (collectionTranslatorResult != null)
					{
						global::System.Linq.Expressions.Expression expressionToGetCoordinator = collectionTranslatorResult.ExpressionToGetCoordinator;
						global::System.Type type = expression2.Type.GetGenericArguments()[0];
						global::System.Reflection.MethodInfo method = global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.Shaper_HandleFullSpanCollection.MakeGenericMethod(new global::System.Type[]
						{
							type
						});
						expression = global::System.Linq.Expressions.Expression.Call(global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.Shaper_Parameter, method, expression, expressionToGetCoordinator, global::System.Linq.Expressions.Expression.Constant(value));
					}
					else if (typeof(global::System.Data.Entity.Core.EntityKey) == expression2.Type)
					{
						global::System.Reflection.MethodInfo shaper_HandleRelationshipSpan = global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.Shaper_HandleRelationshipSpan;
						expression = global::System.Linq.Expressions.Expression.Call(global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.Shaper_Parameter, shaper_HandleRelationshipSpan, expression, expression2, global::System.Linq.Expressions.Expression.Constant(value));
					}
					else
					{
						global::System.Reflection.MethodInfo shaper_HandleFullSpanElement = global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.Shaper_HandleFullSpanElement;
						expression = global::System.Linq.Expressions.Expression.Call(global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.Shaper_Parameter, shaper_HandleFullSpanElement, expression, expression2, global::System.Linq.Expressions.Expression.Constant(value));
					}
				}
				return expression;
			}

			// Token: 0x06006B32 RID: 27442 RVA: 0x0016D86E File Offset: 0x0016BA6E
			internal override global::System.Data.Entity.Core.Common.Internal.Materialization.TranslatorResult Visit(global::System.Data.Entity.Core.Query.InternalTrees.SimpleCollectionColumnMap columnMap, global::System.Data.Entity.Core.Common.Internal.Materialization.TranslatorArg arg)
			{
				return this.ProcessCollectionColumnMap(columnMap, arg);
			}

			// Token: 0x06006B33 RID: 27443 RVA: 0x0016D878 File Offset: 0x0016BA78
			internal override global::System.Data.Entity.Core.Common.Internal.Materialization.TranslatorResult Visit(global::System.Data.Entity.Core.Query.InternalTrees.DiscriminatedCollectionColumnMap columnMap, global::System.Data.Entity.Core.Common.Internal.Materialization.TranslatorArg arg)
			{
				return this.ProcessCollectionColumnMap(columnMap, arg, columnMap.Discriminator, columnMap.DiscriminatorValue);
			}

			// Token: 0x06006B34 RID: 27444 RVA: 0x0016D88E File Offset: 0x0016BA8E
			private global::System.Data.Entity.Core.Common.Internal.Materialization.TranslatorResult ProcessCollectionColumnMap(global::System.Data.Entity.Core.Query.InternalTrees.CollectionColumnMap columnMap, global::System.Data.Entity.Core.Common.Internal.Materialization.TranslatorArg arg)
			{
				return this.ProcessCollectionColumnMap(columnMap, arg, null, null);
			}

			// Token: 0x06006B35 RID: 27445 RVA: 0x0016D89C File Offset: 0x0016BA9C
			private global::System.Data.Entity.Core.Common.Internal.Materialization.TranslatorResult ProcessCollectionColumnMap(global::System.Data.Entity.Core.Query.InternalTrees.CollectionColumnMap columnMap, global::System.Data.Entity.Core.Common.Internal.Materialization.TranslatorArg arg, global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap discriminatorColumnMap, object discriminatorValue)
			{
				global::System.Type type = this.DetermineElementType(arg.RequestedType, columnMap);
				global::System.Data.Entity.Core.Common.Internal.Materialization.CoordinatorScratchpad coordinatorScratchpad = new global::System.Data.Entity.Core.Common.Internal.Materialization.CoordinatorScratchpad(type);
				this.EnterCoordinatorTranslateScope(coordinatorScratchpad);
				global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap columnMap2 = columnMap.Element;
				if (this.IsValueLayer && !(columnMap2 is global::System.Data.Entity.Core.Query.InternalTrees.StructuredColumnMap))
				{
					global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap[] properties = new global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap[]
					{
						columnMap.Element
					};
					columnMap2 = new global::System.Data.Entity.Core.Query.InternalTrees.RecordColumnMap(columnMap.Element.Type, columnMap.Element.Name, properties, null);
				}
				bool inNullableType = this._inNullableType;
				if (discriminatorColumnMap != null)
				{
					this._inNullableType = true;
				}
				global::System.Linq.Expressions.Expression unconvertedExpression = columnMap2.Accept<global::System.Data.Entity.Core.Common.Internal.Materialization.TranslatorResult, global::System.Data.Entity.Core.Common.Internal.Materialization.TranslatorArg>(this, new global::System.Data.Entity.Core.Common.Internal.Materialization.TranslatorArg(type)).UnconvertedExpression;
				global::System.Linq.Expressions.Expression[] array;
				if (columnMap.Keys != null)
				{
					array = new global::System.Linq.Expressions.Expression[columnMap.Keys.Length];
					for (int i = 0; i < array.Length; i++)
					{
						global::System.Linq.Expressions.Expression expression = global::System.Data.Entity.Core.Common.Internal.Materialization.Translator.TranslatorVisitor.AcceptWithMappedType(this, columnMap.Keys[i]).Expression;
						array[i] = expression;
					}
				}
				else
				{
					array = new global::System.Linq.Expressions.Expression[0];
				}
				global::System.Linq.Expressions.Expression discriminator = null;
				if (discriminatorColumnMap != null)
				{
					discriminator = global::System.Data.Entity.Core.Common.Internal.Materialization.Translator.TranslatorVisitor.AcceptWithMappedType(this, discriminatorColumnMap).Expression;
					this._inNullableType = inNullableType;
				}
				global::System.Linq.Expressions.Expression expression2 = this.BuildExpressionToGetCoordinator(type, unconvertedExpression, array, discriminator, discriminatorValue, coordinatorScratchpad);
				global::System.Reflection.MethodInfo genericElementsMethod = global::System.Data.Entity.Core.Common.Internal.Materialization.Translator.TranslatorVisitor.GetGenericElementsMethod(type);
				global::System.Linq.Expressions.Expression expression3;
				if (this.IsValueLayer)
				{
					expression3 = expression2;
				}
				else
				{
					expression3 = global::System.Linq.Expressions.Expression.Call(expression2, genericElementsMethod);
					coordinatorScratchpad.Element = global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.Emit_EnsureType(coordinatorScratchpad.Element, type);
					global::System.Type type2 = arg.RequestedType.TryGetElementType(typeof(global::System.Collections.Generic.ICollection<>));
					if (type2 != null)
					{
						global::System.Type type3 = global::System.Data.Entity.Core.EntityUtil.DetermineCollectionType(arg.RequestedType);
						if (type3 == null)
						{
							throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ObjectQuery_UnableToMaterializeArbitaryProjectionType(arg.RequestedType));
						}
						global::System.Type right = typeof(global::System.Collections.Generic.List<>).MakeGenericType(new global::System.Type[]
						{
							type2
						});
						if (type3 != right)
						{
							coordinatorScratchpad.InitializeCollection = global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.Emit_EnsureType(global::System.Data.Entity.Core.Objects.DelegateFactory.GetNewExpressionForCollectionType(type3), typeof(global::System.Collections.Generic.ICollection<>).MakeGenericType(new global::System.Type[]
							{
								type2
							}));
						}
						expression3 = global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.Emit_EnsureType(expression3, arg.RequestedType);
					}
					else if (!arg.RequestedType.IsAssignableFrom(expression3.Type))
					{
						global::System.Type type4 = typeof(global::System.Data.Entity.Core.Common.Internal.Materialization.CompensatingCollection<>).MakeGenericType(new global::System.Type[]
						{
							type
						});
						expression3 = global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.Emit_EnsureType(global::System.Linq.Expressions.Expression.New(type4.GetConstructors()[0], new global::System.Linq.Expressions.Expression[]
						{
							expression3
						}), type4);
					}
				}
				this.ExitCoordinatorTranslateScope();
				return new global::System.Data.Entity.Core.Common.Internal.Materialization.CollectionTranslatorResult(expression3, arg.RequestedType, expression2);
			}

			// Token: 0x06006B36 RID: 27446 RVA: 0x0016DAFF File Offset: 0x0016BCFF
			public static global::System.Reflection.MethodInfo GetGenericElementsMethod(global::System.Type elementType)
			{
				return typeof(global::System.Data.Entity.Core.Common.Internal.Materialization.Coordinator<>).MakeGenericType(new global::System.Type[]
				{
					elementType
				}).GetOnlyDeclaredMethod("GetElements");
			}

			// Token: 0x06006B37 RID: 27447 RVA: 0x0016DB24 File Offset: 0x0016BD24
			private global::System.Type DetermineElementType(global::System.Type collectionType, global::System.Data.Entity.Core.Query.InternalTrees.CollectionColumnMap columnMap)
			{
				global::System.Type type;
				if (this.IsValueLayer)
				{
					type = typeof(global::System.Data.Entity.Core.Common.Internal.Materialization.RecordState);
				}
				else
				{
					type = global::System.Data.Entity.Core.Objects.ELinq.TypeSystem.GetElementType(collectionType);
					if (type == collectionType)
					{
						global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage = ((global::System.Data.Entity.Core.Metadata.Edm.CollectionType)columnMap.Type.EdmType).TypeUsage;
						type = this.DetermineClrType(typeUsage);
					}
				}
				return type;
			}

			// Token: 0x06006B38 RID: 27448 RVA: 0x0016DB78 File Offset: 0x0016BD78
			private void EnterCoordinatorTranslateScope(global::System.Data.Entity.Core.Common.Internal.Materialization.CoordinatorScratchpad coordinatorScratchpad)
			{
				if (this.RootCoordinatorScratchpad == null)
				{
					coordinatorScratchpad.Depth = 0;
					this.RootCoordinatorScratchpad = coordinatorScratchpad;
					this._currentCoordinatorScratchpad = coordinatorScratchpad;
					return;
				}
				coordinatorScratchpad.Depth = this._currentCoordinatorScratchpad.Depth + 1;
				this._currentCoordinatorScratchpad.AddNestedCoordinator(coordinatorScratchpad);
				this._currentCoordinatorScratchpad = coordinatorScratchpad;
			}

			// Token: 0x06006B39 RID: 27449 RVA: 0x0016DBC9 File Offset: 0x0016BDC9
			private void ExitCoordinatorTranslateScope()
			{
				this._currentCoordinatorScratchpad = this._currentCoordinatorScratchpad.Parent;
			}

			// Token: 0x06006B3A RID: 27450 RVA: 0x0016DBDC File Offset: 0x0016BDDC
			private global::System.Linq.Expressions.Expression BuildExpressionToGetCoordinator(global::System.Type elementType, global::System.Linq.Expressions.Expression element, global::System.Linq.Expressions.Expression[] keyReaders, global::System.Linq.Expressions.Expression discriminator, object discriminatorValue, global::System.Data.Entity.Core.Common.Internal.Materialization.CoordinatorScratchpad coordinatorScratchpad)
			{
				int stateSlotNumber = this.AllocateStateSlot();
				coordinatorScratchpad.StateSlotNumber = stateSlotNumber;
				coordinatorScratchpad.Element = element;
				global::System.Collections.Generic.List<global::System.Linq.Expressions.Expression> list = new global::System.Collections.Generic.List<global::System.Linq.Expressions.Expression>(keyReaders.Length);
				global::System.Collections.Generic.List<global::System.Linq.Expressions.Expression> list2 = new global::System.Collections.Generic.List<global::System.Linq.Expressions.Expression>(keyReaders.Length);
				foreach (global::System.Linq.Expressions.Expression expression in keyReaders)
				{
					int stateSlotNumber2 = this.AllocateStateSlot();
					list.Add(global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.Emit_Shaper_SetState(stateSlotNumber2, expression));
					list2.Add(global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.Emit_Equal(global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.Emit_Shaper_GetState(stateSlotNumber2, expression.Type), expression));
				}
				coordinatorScratchpad.SetKeys = global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.Emit_BitwiseOr(list);
				coordinatorScratchpad.CheckKeys = global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.Emit_AndAlso(list2);
				if (discriminator != null)
				{
					coordinatorScratchpad.HasData = global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.Emit_Equal(global::System.Linq.Expressions.Expression.Constant(discriminatorValue, discriminator.Type), discriminator);
				}
				return global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.Emit_Shaper_GetState(stateSlotNumber, typeof(global::System.Data.Entity.Core.Common.Internal.Materialization.Coordinator<>).MakeGenericType(new global::System.Type[]
				{
					elementType
				}));
			}

			// Token: 0x06006B3B RID: 27451 RVA: 0x0016DCB8 File Offset: 0x0016BEB8
			internal override global::System.Data.Entity.Core.Common.Internal.Materialization.TranslatorResult Visit(global::System.Data.Entity.Core.Query.InternalTrees.RefColumnMap columnMap, global::System.Data.Entity.Core.Common.Internal.Materialization.TranslatorArg arg)
			{
				global::System.Data.Entity.Core.Query.InternalTrees.EntityIdentity entityIdentity = columnMap.EntityIdentity;
				global::System.Linq.Expressions.Expression expression;
				global::System.Linq.Expressions.Expression returnedExpression = global::System.Linq.Expressions.Expression.Condition(global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.Emit_EntityKey_HasValue(entityIdentity.Keys), this.Emit_EntityKey_ctor(this, entityIdentity, ((global::System.Data.Entity.Core.Metadata.Edm.RefType)columnMap.Type.EdmType).ElementType, true, out expression), global::System.Linq.Expressions.Expression.Constant(null, typeof(global::System.Data.Entity.Core.EntityKey)));
				int columnPos = ((global::System.Data.Entity.Core.Query.InternalTrees.ScalarColumnMap)entityIdentity.Keys[0]).ColumnPos;
				if (!this._streaming && !this.NullableColumns.Contains(columnPos))
				{
					this.NullableColumns.Add(columnPos);
				}
				return new global::System.Data.Entity.Core.Common.Internal.Materialization.TranslatorResult(returnedExpression, arg.RequestedType);
			}

			// Token: 0x06006B3C RID: 27452 RVA: 0x0016DD4C File Offset: 0x0016BF4C
			internal override global::System.Data.Entity.Core.Common.Internal.Materialization.TranslatorResult Visit(global::System.Data.Entity.Core.Query.InternalTrees.ScalarColumnMap columnMap, global::System.Data.Entity.Core.Common.Internal.Materialization.TranslatorArg arg)
			{
				global::System.Type requestedType = arg.RequestedType;
				global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type = columnMap.Type;
				int columnPos = columnMap.ColumnPos;
				global::System.Type type2 = null;
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind primitiveTypeKind;
				global::System.Linq.Expressions.Expression expression;
				if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsSpatialType(type, out primitiveTypeKind))
				{
					expression = global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.Emit_Conditional_NotDBNull(global::System.Data.Entity.Core.Metadata.Edm.Helper.IsGeographicType((global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType)type.EdmType) ? global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.Emit_EnsureType(global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.Emit_Shaper_GetGeographyColumnValue(columnPos), requestedType) : global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.Emit_EnsureType(global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.Emit_Shaper_GetGeometryColumnValue(columnPos), requestedType), columnPos, requestedType);
					if (!this._streaming && !this.NullableColumns.Contains(columnPos))
					{
						this.NullableColumns.Add(columnPos);
					}
				}
				else if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsHierarchyIdType(type))
				{
					expression = global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.Emit_Conditional_NotDBNull(global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.Emit_EnsureType(global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.Emit_Shaper_GetHierarchyIdColumnValue(columnPos), requestedType), columnPos, requestedType);
				}
				else
				{
					bool flag;
					global::System.Reflection.MethodInfo readerMethod = global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.GetReaderMethod(requestedType, out flag);
					expression = global::System.Linq.Expressions.Expression.Call(global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.Shaper_Reader, readerMethod, new global::System.Linq.Expressions.Expression[]
					{
						global::System.Linq.Expressions.Expression.Constant(columnPos)
					});
					type2 = global::System.Data.Entity.Core.Objects.ELinq.TypeSystem.GetNonNullableType(requestedType);
					if (type2.IsEnum() && type2 != requestedType)
					{
						expression = global::System.Linq.Expressions.Expression.Convert(expression, type2);
					}
					else if (requestedType == typeof(object) && !this.IsValueLayer && global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsEnumerationType(type))
					{
						expression = global::System.Linq.Expressions.Expression.Condition(global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.Emit_Reader_IsDBNull(columnPos), expression, global::System.Linq.Expressions.Expression.Convert(global::System.Linq.Expressions.Expression.Convert(expression, global::System.Data.Entity.Core.Objects.ELinq.TypeSystem.GetNonNullableType(this.DetermineClrType(type.EdmType))), typeof(object)));
						if (!this._streaming && !this.NullableColumns.Contains(columnPos))
						{
							this.NullableColumns.Add(columnPos);
						}
					}
					expression = global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.Emit_EnsureType(expression, requestedType);
					if (flag)
					{
						expression = global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.Emit_Conditional_NotDBNull(expression, columnPos, requestedType);
						if (!this._streaming && !this.NullableColumns.Contains(columnPos))
						{
							this.NullableColumns.Add(columnPos);
						}
					}
				}
				if (!this._streaming)
				{
					global::System.Type type3 = type2 ?? requestedType;
					type3 = (type3.IsEnum() ? type3.GetEnumUnderlyingType() : type3);
					global::System.Type left;
					if (this.ColumnTypes.TryGetValue(columnPos, out left))
					{
						if (left == typeof(object) && type3 != typeof(object))
						{
							this.ColumnTypes[columnPos] = type3;
						}
					}
					else
					{
						this.ColumnTypes.Add(columnPos, type3);
						if (this._inNullableType && !this.NullableColumns.Contains(columnPos))
						{
							this.NullableColumns.Add(columnPos);
						}
					}
				}
				global::System.Linq.Expressions.Expression expressionWithErrorHandling = global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.Emit_Shaper_GetColumnValueWithErrorHandling(arg.RequestedType, columnPos, type);
				this._currentCoordinatorScratchpad.AddExpressionWithErrorHandling(expression, expressionWithErrorHandling);
				return new global::System.Data.Entity.Core.Common.Internal.Materialization.TranslatorResult(expression, requestedType);
			}

			// Token: 0x06006B3D RID: 27453 RVA: 0x0016DFC0 File Offset: 0x0016C1C0
			internal override global::System.Data.Entity.Core.Common.Internal.Materialization.TranslatorResult Visit(global::System.Data.Entity.Core.Query.InternalTrees.VarRefColumnMap columnMap, global::System.Data.Entity.Core.Common.Internal.Materialization.TranslatorArg arg)
			{
				throw new global::System.InvalidOperationException(string.Empty);
			}

			// Token: 0x06006B3E RID: 27454 RVA: 0x0016DFCC File Offset: 0x0016C1CC
			private int AllocateStateSlot()
			{
				int stateSlotCount = this.StateSlotCount;
				this.StateSlotCount = stateSlotCount + 1;
				return stateSlotCount;
			}

			// Token: 0x06006B3F RID: 27455 RVA: 0x0016DFEA File Offset: 0x0016C1EA
			private global::System.Type DetermineClrType(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage)
			{
				return this.DetermineClrType(typeUsage.EdmType);
			}

			// Token: 0x06006B40 RID: 27456 RVA: 0x0016DFF8 File Offset: 0x0016C1F8
			private global::System.Type DetermineClrType(global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType)
			{
				global::System.Type type = null;
				edmType = this.ResolveSpanType(edmType);
				global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind builtInTypeKind = edmType.BuiltInTypeKind;
				if (builtInTypeKind <= global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EntityType)
				{
					if (builtInTypeKind != global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.CollectionType)
					{
						if (builtInTypeKind == global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.ComplexType || builtInTypeKind == global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EntityType)
						{
							if (this.IsValueLayer)
							{
								type = typeof(global::System.Data.Entity.Core.Common.Internal.Materialization.RecordState);
							}
							else
							{
								type = this.LookupObjectMapping(edmType).ClrType.ClrType;
							}
						}
					}
					else if (this.IsValueLayer)
					{
						type = typeof(global::System.Data.Entity.Core.Common.Internal.Materialization.Coordinator<global::System.Data.Entity.Core.Common.Internal.Materialization.RecordState>);
					}
					else
					{
						global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType2 = ((global::System.Data.Entity.Core.Metadata.Edm.CollectionType)edmType).TypeUsage.EdmType;
						type = this.DetermineClrType(edmType2);
						type = typeof(global::System.Collections.Generic.IEnumerable<>).MakeGenericType(new global::System.Type[]
						{
							type
						});
					}
				}
				else if (builtInTypeKind <= global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.PrimitiveType)
				{
					if (builtInTypeKind != global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EnumType)
					{
						if (builtInTypeKind == global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.PrimitiveType)
						{
							type = ((global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType)edmType).ClrEquivalentType;
							if (type.IsValueType())
							{
								type = typeof(global::System.Nullable<>).MakeGenericType(new global::System.Type[]
								{
									type
								});
							}
						}
					}
					else if (this.IsValueLayer)
					{
						type = this.DetermineClrType(((global::System.Data.Entity.Core.Metadata.Edm.EnumType)edmType).UnderlyingType);
					}
					else
					{
						type = this.LookupObjectMapping(edmType).ClrType.ClrType;
						type = typeof(global::System.Nullable<>).MakeGenericType(new global::System.Type[]
						{
							type
						});
					}
				}
				else if (builtInTypeKind != global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.RefType)
				{
					if (builtInTypeKind == global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.RowType)
					{
						if (this.IsValueLayer)
						{
							type = typeof(global::System.Data.Entity.Core.Common.Internal.Materialization.RecordState);
						}
						else
						{
							global::System.Data.Entity.Core.Objects.ELinq.InitializerMetadata initializerMetadata = ((global::System.Data.Entity.Core.Metadata.Edm.RowType)edmType).InitializerMetadata;
							if (initializerMetadata != null)
							{
								type = initializerMetadata.ClrType;
							}
							else
							{
								type = typeof(global::System.Data.Common.DbDataRecord);
							}
						}
					}
				}
				else
				{
					type = typeof(global::System.Data.Entity.Core.EntityKey);
				}
				return type;
			}

			// Token: 0x06006B41 RID: 27457 RVA: 0x0016E19F File Offset: 0x0016C39F
			private static global::System.Reflection.ConstructorInfo GetConstructor(global::System.Type type)
			{
				if (!type.IsAbstract())
				{
					return global::System.Data.Entity.Core.Objects.DelegateFactory.GetConstructorForType(type);
				}
				return null;
			}

			// Token: 0x06006B42 RID: 27458 RVA: 0x0016E1B4 File Offset: 0x0016C3B4
			private global::System.Data.Entity.Core.Mapping.ObjectTypeMapping LookupObjectMapping(global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType)
			{
				global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType2 = this.ResolveSpanType(edmType);
				if (edmType2 == null)
				{
					edmType2 = edmType;
				}
				global::System.Data.Entity.Core.Mapping.ObjectTypeMapping objectMapping;
				if (!this._objectTypeMappings.TryGetValue(edmType2, out objectMapping))
				{
					objectMapping = global::System.Data.Entity.Core.Metadata.Edm.Util.GetObjectMapping(edmType2, this._workspace);
					this._objectTypeMappings.Add(edmType2, objectMapping);
				}
				return objectMapping;
			}

			// Token: 0x06006B43 RID: 27459 RVA: 0x0016E1FC File Offset: 0x0016C3FC
			private global::System.Data.Entity.Core.Metadata.Edm.EdmType ResolveSpanType(global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType)
			{
				global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType2 = edmType;
				global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind builtInTypeKind = edmType2.BuiltInTypeKind;
				if (builtInTypeKind != global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.CollectionType)
				{
					if (builtInTypeKind == global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.RowType)
					{
						global::System.Data.Entity.Core.Metadata.Edm.RowType rowType = (global::System.Data.Entity.Core.Metadata.Edm.RowType)edmType2;
						if (this._spanIndex != null && this._spanIndex.HasSpanMap(rowType))
						{
							edmType2 = rowType.Members[0].TypeUsage.EdmType;
						}
					}
				}
				else
				{
					edmType2 = this.ResolveSpanType(((global::System.Data.Entity.Core.Metadata.Edm.CollectionType)edmType2).TypeUsage.EdmType);
					if (edmType2 != null)
					{
						edmType2 = new global::System.Data.Entity.Core.Metadata.Edm.CollectionType(edmType2);
					}
				}
				return edmType2;
			}

			// Token: 0x06006B44 RID: 27460 RVA: 0x0016E278 File Offset: 0x0016C478
			private global::System.Linq.Expressions.LambdaExpression CreateInlineDelegate(global::System.Linq.Expressions.Expression body)
			{
				global::System.Type type = body.Type;
				return (global::System.Linq.Expressions.LambdaExpression)global::System.Data.Entity.Core.Common.Internal.Materialization.Translator.TranslatorVisitor.Translator_TypedCreateInlineDelegate.MakeGenericMethod(new global::System.Type[]
				{
					type
				}).Invoke(this, new object[]
				{
					body
				});
			}

			// Token: 0x06006B45 RID: 27461 RVA: 0x0016E2B8 File Offset: 0x0016C4B8
			private global::System.Linq.Expressions.Expression<global::System.Func<global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper, T>> TypedCreateInlineDelegate<T>(global::System.Linq.Expressions.Expression body)
			{
				global::System.Linq.Expressions.Expression<global::System.Func<global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper, T>> expression = global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper, T>>(body, new global::System.Linq.Expressions.ParameterExpression[]
				{
					global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.Shaper_Parameter
				});
				this._currentCoordinatorScratchpad.AddInlineDelegate(expression);
				return expression;
			}

			// Token: 0x06006B46 RID: 27462 RVA: 0x0016E2E8 File Offset: 0x0016C4E8
			private global::System.Linq.Expressions.Expression Emit_EntityKey_ctor(global::System.Data.Entity.Core.Common.Internal.Materialization.Translator.TranslatorVisitor translatorVisitor, global::System.Data.Entity.Core.Query.InternalTrees.EntityIdentity entityIdentity, global::System.Data.Entity.Core.Metadata.Edm.EdmType type, bool isForColumnValue, out global::System.Linq.Expressions.Expression entitySetReader)
			{
				global::System.Linq.Expressions.Expression expression = null;
				global::System.Collections.Generic.List<global::System.Linq.Expressions.Expression> list = new global::System.Collections.Generic.List<global::System.Linq.Expressions.Expression>(entityIdentity.Keys.Length);
				if (this.IsValueLayer)
				{
					for (int i = 0; i < entityIdentity.Keys.Length; i++)
					{
						global::System.Linq.Expressions.Expression expression2 = entityIdentity.Keys[i].Accept<global::System.Data.Entity.Core.Common.Internal.Materialization.TranslatorResult, global::System.Data.Entity.Core.Common.Internal.Materialization.TranslatorArg>(translatorVisitor, new global::System.Data.Entity.Core.Common.Internal.Materialization.TranslatorArg(typeof(object))).Expression;
						list.Add(expression2);
					}
				}
				else
				{
					global::System.Data.Entity.Core.Mapping.ObjectTypeMapping objectTypeMapping = this.LookupObjectMapping(type);
					for (int j = 0; j < entityIdentity.Keys.Length; j++)
					{
						global::System.Type propertyType = global::System.Data.Entity.Core.Objects.DelegateFactory.ValidateSetterProperty(objectTypeMapping.GetPropertyMap(entityIdentity.Keys[j].Name).ClrProperty.PropertyInfo).PropertyType;
						global::System.Linq.Expressions.Expression expression3 = entityIdentity.Keys[j].Accept<global::System.Data.Entity.Core.Common.Internal.Materialization.TranslatorResult, global::System.Data.Entity.Core.Common.Internal.Materialization.TranslatorArg>(translatorVisitor, new global::System.Data.Entity.Core.Common.Internal.Materialization.TranslatorArg(propertyType)).Expression;
						list.Add(global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.Emit_EnsureType(expression3, typeof(object)));
					}
				}
				global::System.Data.Entity.Core.Query.InternalTrees.SimpleEntityIdentity simpleEntityIdentity = entityIdentity as global::System.Data.Entity.Core.Query.InternalTrees.SimpleEntityIdentity;
				if (simpleEntityIdentity != null)
				{
					if (simpleEntityIdentity.EntitySet == null)
					{
						entitySetReader = global::System.Linq.Expressions.Expression.Constant(null, typeof(global::System.Data.Entity.Core.Metadata.Edm.EntitySet));
						return global::System.Linq.Expressions.Expression.Constant(null, typeof(global::System.Data.Entity.Core.EntityKey));
					}
					entitySetReader = global::System.Linq.Expressions.Expression.Constant(simpleEntityIdentity.EntitySet, typeof(global::System.Data.Entity.Core.Metadata.Edm.EntitySet));
				}
				else
				{
					global::System.Data.Entity.Core.Query.InternalTrees.DiscriminatedEntityIdentity discriminatedEntityIdentity = (global::System.Data.Entity.Core.Query.InternalTrees.DiscriminatedEntityIdentity)entityIdentity;
					global::System.Linq.Expressions.Expression expression4 = discriminatedEntityIdentity.EntitySetColumnMap.Accept<global::System.Data.Entity.Core.Common.Internal.Materialization.TranslatorResult, global::System.Data.Entity.Core.Common.Internal.Materialization.TranslatorArg>(translatorVisitor, new global::System.Data.Entity.Core.Common.Internal.Materialization.TranslatorArg(typeof(int?))).Expression;
					global::System.Data.Entity.Core.Metadata.Edm.EntitySet[] entitySetMap = discriminatedEntityIdentity.EntitySetMap;
					entitySetReader = global::System.Linq.Expressions.Expression.Constant(null, typeof(global::System.Data.Entity.Core.Metadata.Edm.EntitySet));
					for (int k = 0; k < entitySetMap.Length; k++)
					{
						entitySetReader = global::System.Linq.Expressions.Expression.Condition(global::System.Linq.Expressions.Expression.Equal(expression4, global::System.Linq.Expressions.Expression.Constant(k, typeof(int?))), global::System.Linq.Expressions.Expression.Constant(entitySetMap[k], typeof(global::System.Data.Entity.Core.Metadata.Edm.EntitySet)), entitySetReader);
					}
					int stateSlotNumber = translatorVisitor.AllocateStateSlot();
					expression = global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.Emit_Shaper_SetStatePassthrough(stateSlotNumber, entitySetReader);
					entitySetReader = global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.Emit_Shaper_GetState(stateSlotNumber, typeof(global::System.Data.Entity.Core.Metadata.Edm.EntitySet));
				}
				global::System.Linq.Expressions.Expression expression5;
				if (1 == entityIdentity.Keys.Length)
				{
					expression5 = global::System.Linq.Expressions.Expression.New(global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.EntityKey_ctor_SingleKey, new global::System.Linq.Expressions.Expression[]
					{
						entitySetReader,
						list[0]
					});
				}
				else
				{
					expression5 = global::System.Linq.Expressions.Expression.New(global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.EntityKey_ctor_CompositeKey, new global::System.Linq.Expressions.Expression[]
					{
						entitySetReader,
						global::System.Linq.Expressions.Expression.NewArrayInit(typeof(object), list)
					});
				}
				if (expression != null)
				{
					global::System.Linq.Expressions.Expression ifTrue;
					if (translatorVisitor.IsValueLayer && !isForColumnValue)
					{
						ifTrue = global::System.Linq.Expressions.Expression.Constant(global::System.Data.Entity.Core.EntityKey.NoEntitySetKey, typeof(global::System.Data.Entity.Core.EntityKey));
					}
					else
					{
						ifTrue = global::System.Linq.Expressions.Expression.Constant(null, typeof(global::System.Data.Entity.Core.EntityKey));
					}
					expression5 = global::System.Linq.Expressions.Expression.Condition(global::System.Linq.Expressions.Expression.Equal(expression, global::System.Linq.Expressions.Expression.Constant(null, typeof(global::System.Data.Entity.Core.Metadata.Edm.EntitySet))), ifTrue, expression5);
				}
				return expression5;
			}

			// Token: 0x04003110 RID: 12560
			private readonly global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace _workspace;

			// Token: 0x04003111 RID: 12561
			private readonly global::System.Data.Entity.Core.Objects.Internal.SpanIndex _spanIndex;

			// Token: 0x04003112 RID: 12562
			private readonly global::System.Data.Entity.Core.Objects.MergeOption _mergeOption;

			// Token: 0x04003113 RID: 12563
			private readonly bool _streaming;

			// Token: 0x04003114 RID: 12564
			private readonly bool IsValueLayer;

			// Token: 0x04003115 RID: 12565
			private global::System.Data.Entity.Core.Common.Internal.Materialization.CoordinatorScratchpad _currentCoordinatorScratchpad;

			// Token: 0x04003116 RID: 12566
			private readonly global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EdmType, global::System.Data.Entity.Core.Mapping.ObjectTypeMapping> _objectTypeMappings = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EdmType, global::System.Data.Entity.Core.Mapping.ObjectTypeMapping>();

			// Token: 0x04003117 RID: 12567
			private bool _inNullableType;

			// Token: 0x04003118 RID: 12568
			public static readonly global::System.Reflection.MethodInfo Translator_MultipleDiscriminatorPolymorphicColumnMapHelper = typeof(global::System.Data.Entity.Core.Common.Internal.Materialization.Translator.TranslatorVisitor).GetOnlyDeclaredMethod("MultipleDiscriminatorPolymorphicColumnMapHelper");

			// Token: 0x04003119 RID: 12569
			public static readonly global::System.Reflection.MethodInfo Translator_TypedCreateInlineDelegate = typeof(global::System.Data.Entity.Core.Common.Internal.Materialization.Translator.TranslatorVisitor).GetOnlyDeclaredMethod("TypedCreateInlineDelegate");
		}
	}
}
