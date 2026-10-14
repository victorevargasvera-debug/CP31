using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.Internal.Materialization;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Data.Entity.Core.Objects.Internal;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Threading;

namespace System.Data.Entity.Core.Objects.ELinq
{
	// Token: 0x02000463 RID: 1123
	internal abstract class InitializerMetadata : global::System.IEquatable<global::System.Data.Entity.Core.Objects.ELinq.InitializerMetadata>
	{
		// Token: 0x06003759 RID: 14169 RVA: 0x000B2B10 File Offset: 0x000B0D10
		private InitializerMetadata(global::System.Type clrType)
		{
			this.ClrType = clrType;
			this.Identity = global::System.Data.Entity.Core.Objects.ELinq.InitializerMetadata._identifierPrefix + global::System.Threading.Interlocked.Increment(ref global::System.Data.Entity.Core.Objects.ELinq.InitializerMetadata.s_identifier).ToString(global::System.Globalization.CultureInfo.InvariantCulture);
		}

		// Token: 0x17000AA3 RID: 2723
		// (get) Token: 0x0600375A RID: 14170
		internal abstract global::System.Data.Entity.Core.Objects.ELinq.InitializerMetadataKind Kind { get; }

		// Token: 0x0600375B RID: 14171 RVA: 0x000B2B51 File Offset: 0x000B0D51
		internal static bool TryGetInitializerMetadata(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage, out global::System.Data.Entity.Core.Objects.ELinq.InitializerMetadata initializerMetadata)
		{
			initializerMetadata = null;
			if (global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.RowType == typeUsage.EdmType.BuiltInTypeKind)
			{
				initializerMetadata = ((global::System.Data.Entity.Core.Metadata.Edm.RowType)typeUsage.EdmType).InitializerMetadata;
			}
			return initializerMetadata != null;
		}

		// Token: 0x0600375C RID: 14172 RVA: 0x000B2B7C File Offset: 0x000B0D7C
		internal static global::System.Data.Entity.Core.Objects.ELinq.InitializerMetadata CreateGroupingInitializer(global::System.Data.Entity.Core.Metadata.Edm.EdmItemCollection itemCollection, global::System.Type resultType)
		{
			return itemCollection.GetCanonicalInitializerMetadata(new global::System.Data.Entity.Core.Objects.ELinq.InitializerMetadata.GroupingInitializerMetadata(resultType));
		}

		// Token: 0x0600375D RID: 14173 RVA: 0x000B2B8A File Offset: 0x000B0D8A
		internal static global::System.Data.Entity.Core.Objects.ELinq.InitializerMetadata CreateProjectionInitializer(global::System.Data.Entity.Core.Metadata.Edm.EdmItemCollection itemCollection, global::System.Linq.Expressions.MemberInitExpression initExpression)
		{
			return itemCollection.GetCanonicalInitializerMetadata(new global::System.Data.Entity.Core.Objects.ELinq.InitializerMetadata.ProjectionInitializerMetadata(initExpression));
		}

		// Token: 0x0600375E RID: 14174 RVA: 0x000B2B98 File Offset: 0x000B0D98
		internal static global::System.Data.Entity.Core.Objects.ELinq.InitializerMetadata CreateProjectionInitializer(global::System.Data.Entity.Core.Metadata.Edm.EdmItemCollection itemCollection, global::System.Linq.Expressions.NewExpression newExpression)
		{
			return itemCollection.GetCanonicalInitializerMetadata(new global::System.Data.Entity.Core.Objects.ELinq.InitializerMetadata.ProjectionNewMetadata(newExpression));
		}

		// Token: 0x0600375F RID: 14175 RVA: 0x000B2BA6 File Offset: 0x000B0DA6
		internal static global::System.Data.Entity.Core.Objects.ELinq.InitializerMetadata CreateEmptyProjectionInitializer(global::System.Data.Entity.Core.Metadata.Edm.EdmItemCollection itemCollection, global::System.Linq.Expressions.NewExpression newExpression)
		{
			return itemCollection.GetCanonicalInitializerMetadata(new global::System.Data.Entity.Core.Objects.ELinq.InitializerMetadata.EmptyProjectionNewMetadata(newExpression));
		}

		// Token: 0x06003760 RID: 14176 RVA: 0x000B2BB4 File Offset: 0x000B0DB4
		internal static global::System.Data.Entity.Core.Objects.ELinq.InitializerMetadata CreateEntityCollectionInitializer(global::System.Data.Entity.Core.Metadata.Edm.EdmItemCollection itemCollection, global::System.Type type, global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty navigationProperty)
		{
			return itemCollection.GetCanonicalInitializerMetadata(new global::System.Data.Entity.Core.Objects.ELinq.InitializerMetadata.EntityCollectionInitializerMetadata(type, navigationProperty));
		}

		// Token: 0x06003761 RID: 14177 RVA: 0x000B2BC3 File Offset: 0x000B0DC3
		internal virtual void AppendColumnMapKey(global::System.Data.Entity.Core.Common.Internal.Materialization.ColumnMapKeyBuilder builder)
		{
			builder.Append("CLR-", this.ClrType);
		}

		// Token: 0x06003762 RID: 14178 RVA: 0x000B2BD6 File Offset: 0x000B0DD6
		public override bool Equals(object obj)
		{
			return this.Equals(obj as global::System.Data.Entity.Core.Objects.ELinq.InitializerMetadata);
		}

		// Token: 0x06003763 RID: 14179 RVA: 0x000B2BE4 File Offset: 0x000B0DE4
		public bool Equals(global::System.Data.Entity.Core.Objects.ELinq.InitializerMetadata other)
		{
			return this == other || (this.Kind == other.Kind && this.ClrType.Equals(other.ClrType) && this.IsStructurallyEquivalent(other));
		}

		// Token: 0x06003764 RID: 14180 RVA: 0x000B2C18 File Offset: 0x000B0E18
		public override int GetHashCode()
		{
			return this.ClrType.GetHashCode();
		}

		// Token: 0x06003765 RID: 14181 RVA: 0x000B2C25 File Offset: 0x000B0E25
		protected virtual bool IsStructurallyEquivalent(global::System.Data.Entity.Core.Objects.ELinq.InitializerMetadata other)
		{
			return true;
		}

		// Token: 0x06003766 RID: 14182
		internal abstract global::System.Linq.Expressions.Expression Emit(global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.Internal.Materialization.TranslatorResult> propertyTranslatorResults);

		// Token: 0x06003767 RID: 14183
		internal abstract global::System.Collections.Generic.IEnumerable<global::System.Type> GetChildTypes();

		// Token: 0x06003768 RID: 14184 RVA: 0x000B2C28 File Offset: 0x000B0E28
		protected static global::System.Collections.Generic.List<global::System.Linq.Expressions.Expression> GetPropertyReaders(global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.Internal.Materialization.TranslatorResult> propertyTranslatorResults)
		{
			return (from s in propertyTranslatorResults
			select s.UnwrappedExpression).ToList<global::System.Linq.Expressions.Expression>();
		}

		// Token: 0x04001218 RID: 4632
		internal readonly global::System.Type ClrType;

		// Token: 0x04001219 RID: 4633
		private static long s_identifier;

		// Token: 0x0400121A RID: 4634
		internal readonly string Identity;

		// Token: 0x0400121B RID: 4635
		private static readonly string _identifierPrefix = typeof(global::System.Data.Entity.Core.Objects.ELinq.InitializerMetadata).Name;

		// Token: 0x02000AA5 RID: 2725
		private class Grouping<K, T> : global::System.Linq.IGrouping<K, T>, global::System.Collections.Generic.IEnumerable<T>, global::System.Collections.IEnumerable
		{
			// Token: 0x0600629F RID: 25247 RVA: 0x00155B01 File Offset: 0x00153D01
			public Grouping(K key, global::System.Collections.Generic.IEnumerable<T> group)
			{
				this._key = key;
				this._group = group;
			}

			// Token: 0x170010C5 RID: 4293
			// (get) Token: 0x060062A0 RID: 25248 RVA: 0x00155B17 File Offset: 0x00153D17
			public K Key
			{
				get
				{
					return this._key;
				}
			}

			// Token: 0x170010C6 RID: 4294
			// (get) Token: 0x060062A1 RID: 25249 RVA: 0x00155B1F File Offset: 0x00153D1F
			public global::System.Collections.Generic.IEnumerable<T> Group
			{
				get
				{
					return this._group;
				}
			}

			// Token: 0x060062A2 RID: 25250 RVA: 0x00155B27 File Offset: 0x00153D27
			global::System.Collections.Generic.IEnumerator<T> global::System.Collections.Generic.IEnumerable<!1>.GetEnumerator()
			{
				if (this._group == null)
				{
					yield break;
				}
				foreach (T t in this._group)
				{
					yield return t;
				}
				global::System.Collections.Generic.IEnumerator<T> enumerator = null;
				yield break;
				yield break;
			}

			// Token: 0x060062A3 RID: 25251 RVA: 0x00155B36 File Offset: 0x00153D36
			global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
			{
				return ((global::System.Collections.Generic.IEnumerable<!1>)this).GetEnumerator();
			}

			// Token: 0x04002B4D RID: 11085
			private readonly K _key;

			// Token: 0x04002B4E RID: 11086
			private readonly global::System.Collections.Generic.IEnumerable<T> _group;
		}

		// Token: 0x02000AA6 RID: 2726
		private class GroupingInitializerMetadata : global::System.Data.Entity.Core.Objects.ELinq.InitializerMetadata
		{
			// Token: 0x060062A4 RID: 25252 RVA: 0x00155B3E File Offset: 0x00153D3E
			internal GroupingInitializerMetadata(global::System.Type type) : base(type)
			{
			}

			// Token: 0x170010C7 RID: 4295
			// (get) Token: 0x060062A5 RID: 25253 RVA: 0x00155B47 File Offset: 0x00153D47
			internal override global::System.Data.Entity.Core.Objects.ELinq.InitializerMetadataKind Kind
			{
				get
				{
					return global::System.Data.Entity.Core.Objects.ELinq.InitializerMetadataKind.Grouping;
				}
			}

			// Token: 0x060062A6 RID: 25254 RVA: 0x00155B4C File Offset: 0x00153D4C
			internal override global::System.Linq.Expressions.Expression Emit(global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.Internal.Materialization.TranslatorResult> propertyTranslatorResults)
			{
				global::System.Type type = this.ClrType.GetGenericArguments()[0];
				global::System.Type type2 = this.ClrType.GetGenericArguments()[1];
				return global::System.Linq.Expressions.Expression.Convert(global::System.Linq.Expressions.Expression.New(typeof(global::System.Data.Entity.Core.Objects.ELinq.InitializerMetadata.Grouping<, >).MakeGenericType(new global::System.Type[]
				{
					type,
					type2
				}).GetConstructors().Single<global::System.Reflection.ConstructorInfo>(), global::System.Data.Entity.Core.Objects.ELinq.InitializerMetadata.GetPropertyReaders(propertyTranslatorResults)), this.ClrType);
			}

			// Token: 0x060062A7 RID: 25255 RVA: 0x00155BB2 File Offset: 0x00153DB2
			internal override global::System.Collections.Generic.IEnumerable<global::System.Type> GetChildTypes()
			{
				global::System.Type type = this.ClrType.GetGenericArguments()[0];
				global::System.Type groupElementType = this.ClrType.GetGenericArguments()[1];
				yield return type;
				yield return typeof(global::System.Collections.Generic.IEnumerable<>).MakeGenericType(new global::System.Type[]
				{
					groupElementType
				});
				yield break;
			}
		}

		// Token: 0x02000AA7 RID: 2727
		private class ProjectionNewMetadata : global::System.Data.Entity.Core.Objects.ELinq.InitializerMetadata
		{
			// Token: 0x060062A8 RID: 25256 RVA: 0x00155BC2 File Offset: 0x00153DC2
			internal ProjectionNewMetadata(global::System.Linq.Expressions.NewExpression newExpression) : base(newExpression.Type)
			{
				this._newExpression = newExpression;
			}

			// Token: 0x170010C8 RID: 4296
			// (get) Token: 0x060062A9 RID: 25257 RVA: 0x00155BD7 File Offset: 0x00153DD7
			internal override global::System.Data.Entity.Core.Objects.ELinq.InitializerMetadataKind Kind
			{
				get
				{
					return global::System.Data.Entity.Core.Objects.ELinq.InitializerMetadataKind.ProjectionNew;
				}
			}

			// Token: 0x060062AA RID: 25258 RVA: 0x00155BDC File Offset: 0x00153DDC
			protected override bool IsStructurallyEquivalent(global::System.Data.Entity.Core.Objects.ELinq.InitializerMetadata other)
			{
				global::System.Data.Entity.Core.Objects.ELinq.InitializerMetadata.ProjectionNewMetadata projectionNewMetadata = (global::System.Data.Entity.Core.Objects.ELinq.InitializerMetadata.ProjectionNewMetadata)other;
				if (this._newExpression.Members == null && projectionNewMetadata._newExpression.Members == null)
				{
					return true;
				}
				if (this._newExpression.Members == null || projectionNewMetadata._newExpression.Members == null)
				{
					return false;
				}
				if (this._newExpression.Members.Count != projectionNewMetadata._newExpression.Members.Count)
				{
					return false;
				}
				for (int i = 0; i < this._newExpression.Members.Count; i++)
				{
					object obj = this._newExpression.Members[i];
					global::System.Reflection.MemberInfo obj2 = projectionNewMetadata._newExpression.Members[i];
					if (!obj.Equals(obj2))
					{
						return false;
					}
				}
				return true;
			}

			// Token: 0x060062AB RID: 25259 RVA: 0x00155C95 File Offset: 0x00153E95
			internal override global::System.Linq.Expressions.Expression Emit(global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.Internal.Materialization.TranslatorResult> propertyTranslatorResults)
			{
				return global::System.Linq.Expressions.Expression.New(this._newExpression.Constructor, global::System.Data.Entity.Core.Objects.ELinq.InitializerMetadata.GetPropertyReaders(propertyTranslatorResults));
			}

			// Token: 0x060062AC RID: 25260 RVA: 0x00155CAD File Offset: 0x00153EAD
			internal override global::System.Collections.Generic.IEnumerable<global::System.Type> GetChildTypes()
			{
				return from arg in this._newExpression.Arguments
				select arg.Type;
			}

			// Token: 0x060062AD RID: 25261 RVA: 0x00155CE0 File Offset: 0x00153EE0
			internal override void AppendColumnMapKey(global::System.Data.Entity.Core.Common.Internal.Materialization.ColumnMapKeyBuilder builder)
			{
				base.AppendColumnMapKey(builder);
				builder.Append(this._newExpression.Constructor.ToString());
				global::System.Collections.Generic.IEnumerable<global::System.Reflection.MemberInfo> members = this._newExpression.Members;
				foreach (global::System.Reflection.MemberInfo memberInfo in (members ?? global::System.Linq.Enumerable.Empty<global::System.Reflection.MemberInfo>()))
				{
					builder.Append("DT", memberInfo.DeclaringType);
					builder.Append("." + memberInfo.Name);
				}
			}

			// Token: 0x04002B4F RID: 11087
			private readonly global::System.Linq.Expressions.NewExpression _newExpression;
		}

		// Token: 0x02000AA8 RID: 2728
		private class EmptyProjectionNewMetadata : global::System.Data.Entity.Core.Objects.ELinq.InitializerMetadata.ProjectionNewMetadata
		{
			// Token: 0x060062AE RID: 25262 RVA: 0x00155D7C File Offset: 0x00153F7C
			internal EmptyProjectionNewMetadata(global::System.Linq.Expressions.NewExpression newExpression) : base(newExpression)
			{
			}

			// Token: 0x060062AF RID: 25263 RVA: 0x00155D85 File Offset: 0x00153F85
			internal override global::System.Linq.Expressions.Expression Emit(global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.Internal.Materialization.TranslatorResult> propertyReaders)
			{
				return base.Emit(new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.Internal.Materialization.TranslatorResult>());
			}

			// Token: 0x060062B0 RID: 25264 RVA: 0x00155D92 File Offset: 0x00153F92
			internal override global::System.Collections.Generic.IEnumerable<global::System.Type> GetChildTypes()
			{
				yield return null;
				yield break;
			}
		}

		// Token: 0x02000AA9 RID: 2729
		private class ProjectionInitializerMetadata : global::System.Data.Entity.Core.Objects.ELinq.InitializerMetadata
		{
			// Token: 0x060062B1 RID: 25265 RVA: 0x00155D9B File Offset: 0x00153F9B
			internal ProjectionInitializerMetadata(global::System.Linq.Expressions.MemberInitExpression initExpression) : base(initExpression.Type)
			{
				this._initExpression = initExpression;
			}

			// Token: 0x170010C9 RID: 4297
			// (get) Token: 0x060062B2 RID: 25266 RVA: 0x00155DB0 File Offset: 0x00153FB0
			internal override global::System.Data.Entity.Core.Objects.ELinq.InitializerMetadataKind Kind
			{
				get
				{
					return global::System.Data.Entity.Core.Objects.ELinq.InitializerMetadataKind.ProjectionInitializer;
				}
			}

			// Token: 0x060062B3 RID: 25267 RVA: 0x00155DB4 File Offset: 0x00153FB4
			protected override bool IsStructurallyEquivalent(global::System.Data.Entity.Core.Objects.ELinq.InitializerMetadata other)
			{
				global::System.Data.Entity.Core.Objects.ELinq.InitializerMetadata.ProjectionInitializerMetadata projectionInitializerMetadata = (global::System.Data.Entity.Core.Objects.ELinq.InitializerMetadata.ProjectionInitializerMetadata)other;
				if (this._initExpression.Bindings.Count != projectionInitializerMetadata._initExpression.Bindings.Count)
				{
					return false;
				}
				for (int i = 0; i < this._initExpression.Bindings.Count; i++)
				{
					global::System.Linq.Expressions.MemberBinding memberBinding = this._initExpression.Bindings[i];
					global::System.Linq.Expressions.MemberBinding memberBinding2 = projectionInitializerMetadata._initExpression.Bindings[i];
					if (!memberBinding.Member.Equals(memberBinding2.Member))
					{
						return false;
					}
				}
				return true;
			}

			// Token: 0x060062B4 RID: 25268 RVA: 0x00155E40 File Offset: 0x00154040
			internal override global::System.Linq.Expressions.Expression Emit(global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.Internal.Materialization.TranslatorResult> propertyReaders)
			{
				global::System.Linq.Expressions.MemberBinding[] array = new global::System.Linq.Expressions.MemberBinding[this._initExpression.Bindings.Count];
				global::System.Linq.Expressions.MemberBinding[] array2 = new global::System.Linq.Expressions.MemberBinding[array.Length];
				for (int i = 0; i < array.Length; i++)
				{
					global::System.Linq.Expressions.MemberBinding memberBinding = this._initExpression.Bindings[i];
					global::System.Linq.Expressions.Expression unwrappedExpression = propertyReaders[i].UnwrappedExpression;
					global::System.Linq.Expressions.MemberBinding memberBinding2 = global::System.Linq.Expressions.Expression.Bind(memberBinding.Member, unwrappedExpression);
					global::System.Linq.Expressions.MemberBinding memberBinding3 = global::System.Linq.Expressions.Expression.Bind(memberBinding.Member, global::System.Linq.Expressions.Expression.Constant(global::System.Data.Entity.Core.Objects.ELinq.TypeSystem.GetDefaultValue(unwrappedExpression.Type), unwrappedExpression.Type));
					array[i] = memberBinding2;
					array2[i] = memberBinding3;
				}
				return global::System.Linq.Expressions.Expression.MemberInit(this._initExpression.NewExpression, array);
			}

			// Token: 0x060062B5 RID: 25269 RVA: 0x00155EE3 File Offset: 0x001540E3
			internal override global::System.Collections.Generic.IEnumerable<global::System.Type> GetChildTypes()
			{
				foreach (global::System.Linq.Expressions.MemberBinding memberBinding in this._initExpression.Bindings)
				{
					string text;
					global::System.Type type;
					global::System.Data.Entity.Core.Objects.ELinq.TypeSystem.PropertyOrField(memberBinding.Member, out text, out type);
					yield return type;
				}
				global::System.Collections.Generic.IEnumerator<global::System.Linq.Expressions.MemberBinding> enumerator = null;
				yield break;
				yield break;
			}

			// Token: 0x060062B6 RID: 25270 RVA: 0x00155EF4 File Offset: 0x001540F4
			internal override void AppendColumnMapKey(global::System.Data.Entity.Core.Common.Internal.Materialization.ColumnMapKeyBuilder builder)
			{
				base.AppendColumnMapKey(builder);
				foreach (global::System.Linq.Expressions.MemberBinding memberBinding in this._initExpression.Bindings)
				{
					builder.Append(",", memberBinding.Member.DeclaringType);
					builder.Append("." + memberBinding.Member.Name);
				}
			}

			// Token: 0x04002B50 RID: 11088
			private readonly global::System.Linq.Expressions.MemberInitExpression _initExpression;
		}

		// Token: 0x02000AAA RID: 2730
		internal class EntityCollectionInitializerMetadata : global::System.Data.Entity.Core.Objects.ELinq.InitializerMetadata
		{
			// Token: 0x060062B7 RID: 25271 RVA: 0x00155F78 File Offset: 0x00154178
			internal EntityCollectionInitializerMetadata(global::System.Type type, global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty navigationProperty) : base(type)
			{
				this._navigationProperty = navigationProperty;
			}

			// Token: 0x170010CA RID: 4298
			// (get) Token: 0x060062B8 RID: 25272 RVA: 0x00155F88 File Offset: 0x00154188
			internal override global::System.Data.Entity.Core.Objects.ELinq.InitializerMetadataKind Kind
			{
				get
				{
					return global::System.Data.Entity.Core.Objects.ELinq.InitializerMetadataKind.EntityCollection;
				}
			}

			// Token: 0x060062B9 RID: 25273 RVA: 0x00155F8C File Offset: 0x0015418C
			protected override bool IsStructurallyEquivalent(global::System.Data.Entity.Core.Objects.ELinq.InitializerMetadata other)
			{
				global::System.Data.Entity.Core.Objects.ELinq.InitializerMetadata.EntityCollectionInitializerMetadata entityCollectionInitializerMetadata = (global::System.Data.Entity.Core.Objects.ELinq.InitializerMetadata.EntityCollectionInitializerMetadata)other;
				return this._navigationProperty.Equals(entityCollectionInitializerMetadata._navigationProperty);
			}

			// Token: 0x060062BA RID: 25274 RVA: 0x00155FB4 File Offset: 0x001541B4
			internal override global::System.Linq.Expressions.Expression Emit(global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.Internal.Materialization.TranslatorResult> propertyTranslatorResults)
			{
				global::System.Type elementType = this.GetElementType();
				global::System.Reflection.MethodInfo method = global::System.Data.Entity.Core.Objects.ELinq.InitializerMetadata.EntityCollectionInitializerMetadata.CreateEntityCollectionMethod.MakeGenericMethod(new global::System.Type[]
				{
					elementType
				});
				global::System.Linq.Expressions.Expression expression = propertyTranslatorResults[0].Expression;
				global::System.Linq.Expressions.Expression expressionToGetCoordinator = (propertyTranslatorResults[1] as global::System.Data.Entity.Core.Common.Internal.Materialization.CollectionTranslatorResult).ExpressionToGetCoordinator;
				return global::System.Linq.Expressions.Expression.Call(method, expression, expressionToGetCoordinator, global::System.Linq.Expressions.Expression.Constant(this._navigationProperty.RelationshipType.FullName), global::System.Linq.Expressions.Expression.Constant(this._navigationProperty.ToEndMember.Name));
			}

			// Token: 0x060062BB RID: 25275 RVA: 0x0015602C File Offset: 0x0015422C
			public static global::System.Data.Entity.Core.Objects.DataClasses.EntityCollection<T> CreateEntityCollection<T>(global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedOwner, global::System.Data.Entity.Core.Common.Internal.Materialization.Coordinator<T> coordinator, string relationshipName, string targetRoleName) where T : class
			{
				if (wrappedOwner.Entity == null)
				{
					return null;
				}
				global::System.Data.Entity.Core.Objects.DataClasses.EntityCollection<T> result = wrappedOwner.RelationshipManager.GetRelatedCollection<T>(relationshipName, targetRoleName);
				coordinator.RegisterCloseHandler(delegate(global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper readerState, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper> elements)
				{
					result.Load(elements, readerState.MergeOption);
				});
				return result;
			}

			// Token: 0x060062BC RID: 25276 RVA: 0x00156074 File Offset: 0x00154274
			internal override global::System.Collections.Generic.IEnumerable<global::System.Type> GetChildTypes()
			{
				global::System.Type elementType = this.GetElementType();
				yield return null;
				yield return typeof(global::System.Collections.Generic.IEnumerable<>).MakeGenericType(new global::System.Type[]
				{
					elementType
				});
				yield break;
			}

			// Token: 0x060062BD RID: 25277 RVA: 0x00156084 File Offset: 0x00154284
			internal override void AppendColumnMapKey(global::System.Data.Entity.Core.Common.Internal.Materialization.ColumnMapKeyBuilder builder)
			{
				base.AppendColumnMapKey(builder);
				builder.Append(",NP" + this._navigationProperty.Name);
				builder.Append(",AT", this._navigationProperty.DeclaringType);
			}

			// Token: 0x060062BE RID: 25278 RVA: 0x001560C0 File Offset: 0x001542C0
			private global::System.Type GetElementType()
			{
				global::System.Type type = this.ClrType.TryGetElementType(typeof(global::System.Collections.Generic.ICollection<>));
				if (type == null)
				{
					throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ELinq_UnexpectedTypeForNavigationProperty(this._navigationProperty, typeof(global::System.Data.Entity.Core.Objects.DataClasses.EntityCollection<>), typeof(global::System.Collections.Generic.ICollection<>), this.ClrType));
				}
				return type;
			}

			// Token: 0x04002B51 RID: 11089
			private readonly global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty _navigationProperty;

			// Token: 0x04002B52 RID: 11090
			internal static readonly global::System.Reflection.MethodInfo CreateEntityCollectionMethod = typeof(global::System.Data.Entity.Core.Objects.ELinq.InitializerMetadata.EntityCollectionInitializerMetadata).GetOnlyDeclaredMethod("CreateEntityCollection");
		}
	}
}
