using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reflection;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000083 RID: 131
	[global::System.Runtime.CompilerServices.NullableContext(2)]
	[global::System.Runtime.CompilerServices.Nullable(0)]
	public class JsonArrayContract : global::Newtonsoft.Json.Serialization.JsonContainerContract
	{
		// Token: 0x170000EA RID: 234
		// (get) Token: 0x06000685 RID: 1669 RVA: 0x0001BC84 File Offset: 0x00019E84
		public global::System.Type CollectionItemType { get; }

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x06000686 RID: 1670 RVA: 0x0001BC8C File Offset: 0x00019E8C
		public bool IsMultidimensionalArray { get; }

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x06000687 RID: 1671 RVA: 0x0001BC94 File Offset: 0x00019E94
		internal bool IsArray { get; }

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x06000688 RID: 1672 RVA: 0x0001BC9C File Offset: 0x00019E9C
		internal bool ShouldCreateWrapper { get; }

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x06000689 RID: 1673 RVA: 0x0001BCA4 File Offset: 0x00019EA4
		// (set) Token: 0x0600068A RID: 1674 RVA: 0x0001BCAC File Offset: 0x00019EAC
		internal bool CanDeserialize { get; private set; }

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x0600068B RID: 1675 RVA: 0x0001BCB5 File Offset: 0x00019EB5
		[global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			2,
			1
		})]
		internal global::Newtonsoft.Json.Serialization.ObjectConstructor<object> ParameterizedCreator
		{
			[return: global::System.Runtime.CompilerServices.Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				if (this._parameterizedCreator == null && this._parameterizedConstructor != null)
				{
					this._parameterizedCreator = global::Newtonsoft.Json.Serialization.JsonTypeReflector.ReflectionDelegateFactory.CreateParameterizedConstructor(this._parameterizedConstructor);
				}
				return this._parameterizedCreator;
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x0600068C RID: 1676 RVA: 0x0001BCE9 File Offset: 0x00019EE9
		// (set) Token: 0x0600068D RID: 1677 RVA: 0x0001BCF1 File Offset: 0x00019EF1
		[global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			2,
			1
		})]
		public global::Newtonsoft.Json.Serialization.ObjectConstructor<object> OverrideCreator
		{
			[return: global::System.Runtime.CompilerServices.Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				return this._overrideCreator;
			}
			[param: global::System.Runtime.CompilerServices.Nullable(new byte[]
			{
				2,
				1
			})]
			set
			{
				this._overrideCreator = value;
				this.CanDeserialize = true;
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x0600068E RID: 1678 RVA: 0x0001BD01 File Offset: 0x00019F01
		// (set) Token: 0x0600068F RID: 1679 RVA: 0x0001BD09 File Offset: 0x00019F09
		public bool HasParameterizedCreator { get; set; }

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x06000690 RID: 1680 RVA: 0x0001BD12 File Offset: 0x00019F12
		internal bool HasParameterizedCreatorInternal
		{
			get
			{
				return this.HasParameterizedCreator || this._parameterizedCreator != null || this._parameterizedConstructor != null;
			}
		}

		// Token: 0x06000691 RID: 1681 RVA: 0x0001BD34 File Offset: 0x00019F34
		[global::System.Runtime.CompilerServices.NullableContext(1)]
		public JsonArrayContract(global::System.Type underlyingType) : base(underlyingType)
		{
			this.ContractType = global::Newtonsoft.Json.Serialization.JsonContractType.Array;
			this.IsArray = (base.CreatedType.IsArray || (this.NonNullableUnderlyingType.IsGenericType() && this.NonNullableUnderlyingType.GetGenericTypeDefinition().FullName == "System.Linq.EmptyPartition`1"));
			bool canDeserialize;
			global::System.Type type;
			if (this.IsArray)
			{
				this.CollectionItemType = global::Newtonsoft.Json.Utilities.ReflectionUtils.GetCollectionItemType(base.UnderlyingType);
				this.IsReadOnlyOrFixedSize = true;
				this._genericCollectionDefinitionType = typeof(global::System.Collections.Generic.List<>).MakeGenericType(new global::System.Type[]
				{
					this.CollectionItemType
				});
				canDeserialize = true;
				this.IsMultidimensionalArray = (base.CreatedType.IsArray && base.UnderlyingType.GetArrayRank() > 1);
			}
			else if (typeof(global::System.Collections.IList).IsAssignableFrom(this.NonNullableUnderlyingType))
			{
				if (global::Newtonsoft.Json.Utilities.ReflectionUtils.ImplementsGenericDefinition(this.NonNullableUnderlyingType, typeof(global::System.Collections.Generic.ICollection<>), out this._genericCollectionDefinitionType))
				{
					this.CollectionItemType = this._genericCollectionDefinitionType.GetGenericArguments()[0];
				}
				else
				{
					this.CollectionItemType = global::Newtonsoft.Json.Utilities.ReflectionUtils.GetCollectionItemType(this.NonNullableUnderlyingType);
				}
				if (this.NonNullableUnderlyingType == typeof(global::System.Collections.IList))
				{
					base.CreatedType = typeof(global::System.Collections.Generic.List<object>);
				}
				if (this.CollectionItemType != null)
				{
					this._parameterizedConstructor = global::Newtonsoft.Json.Utilities.CollectionUtils.ResolveEnumerableCollectionConstructor(this.NonNullableUnderlyingType, this.CollectionItemType);
				}
				this.IsReadOnlyOrFixedSize = global::Newtonsoft.Json.Utilities.ReflectionUtils.InheritsGenericDefinition(this.NonNullableUnderlyingType, typeof(global::System.Collections.ObjectModel.ReadOnlyCollection<>));
				canDeserialize = true;
			}
			else if (global::Newtonsoft.Json.Utilities.ReflectionUtils.ImplementsGenericDefinition(this.NonNullableUnderlyingType, typeof(global::System.Collections.Generic.ICollection<>), out this._genericCollectionDefinitionType))
			{
				this.CollectionItemType = this._genericCollectionDefinitionType.GetGenericArguments()[0];
				if (global::Newtonsoft.Json.Utilities.ReflectionUtils.IsGenericDefinition(this.NonNullableUnderlyingType, typeof(global::System.Collections.Generic.ICollection<>)) || global::Newtonsoft.Json.Utilities.ReflectionUtils.IsGenericDefinition(this.NonNullableUnderlyingType, typeof(global::System.Collections.Generic.IList<>)))
				{
					base.CreatedType = typeof(global::System.Collections.Generic.List<>).MakeGenericType(new global::System.Type[]
					{
						this.CollectionItemType
					});
				}
				if (global::Newtonsoft.Json.Utilities.ReflectionUtils.IsGenericDefinition(this.NonNullableUnderlyingType, typeof(global::System.Collections.Generic.ISet<>)))
				{
					base.CreatedType = typeof(global::System.Collections.Generic.HashSet<>).MakeGenericType(new global::System.Type[]
					{
						this.CollectionItemType
					});
				}
				this._parameterizedConstructor = global::Newtonsoft.Json.Utilities.CollectionUtils.ResolveEnumerableCollectionConstructor(this.NonNullableUnderlyingType, this.CollectionItemType);
				canDeserialize = true;
				this.ShouldCreateWrapper = 1;
			}
			else if (global::Newtonsoft.Json.Utilities.ReflectionUtils.ImplementsGenericDefinition(this.NonNullableUnderlyingType, typeof(global::System.Collections.Generic.IReadOnlyCollection<>), out type))
			{
				this.CollectionItemType = type.GetGenericArguments()[0];
				if (global::Newtonsoft.Json.Utilities.ReflectionUtils.IsGenericDefinition(this.NonNullableUnderlyingType, typeof(global::System.Collections.Generic.IReadOnlyCollection<>)) || global::Newtonsoft.Json.Utilities.ReflectionUtils.IsGenericDefinition(this.NonNullableUnderlyingType, typeof(global::System.Collections.Generic.IReadOnlyList<>)))
				{
					base.CreatedType = typeof(global::System.Collections.ObjectModel.ReadOnlyCollection<>).MakeGenericType(new global::System.Type[]
					{
						this.CollectionItemType
					});
				}
				this._genericCollectionDefinitionType = typeof(global::System.Collections.Generic.List<>).MakeGenericType(new global::System.Type[]
				{
					this.CollectionItemType
				});
				this._parameterizedConstructor = global::Newtonsoft.Json.Utilities.CollectionUtils.ResolveEnumerableCollectionConstructor(base.CreatedType, this.CollectionItemType);
				this.StoreFSharpListCreatorIfNecessary(this.NonNullableUnderlyingType);
				this.IsReadOnlyOrFixedSize = true;
				canDeserialize = this.HasParameterizedCreatorInternal;
			}
			else if (global::Newtonsoft.Json.Utilities.ReflectionUtils.ImplementsGenericDefinition(this.NonNullableUnderlyingType, typeof(global::System.Collections.Generic.IEnumerable<>), out type))
			{
				this.CollectionItemType = type.GetGenericArguments()[0];
				if (global::Newtonsoft.Json.Utilities.ReflectionUtils.IsGenericDefinition(base.UnderlyingType, typeof(global::System.Collections.Generic.IEnumerable<>)))
				{
					base.CreatedType = typeof(global::System.Collections.Generic.List<>).MakeGenericType(new global::System.Type[]
					{
						this.CollectionItemType
					});
				}
				this._parameterizedConstructor = global::Newtonsoft.Json.Utilities.CollectionUtils.ResolveEnumerableCollectionConstructor(this.NonNullableUnderlyingType, this.CollectionItemType);
				this.StoreFSharpListCreatorIfNecessary(this.NonNullableUnderlyingType);
				if (this.NonNullableUnderlyingType.IsGenericType() && this.NonNullableUnderlyingType.GetGenericTypeDefinition() == typeof(global::System.Collections.Generic.IEnumerable<>))
				{
					this._genericCollectionDefinitionType = type;
					this.IsReadOnlyOrFixedSize = false;
					this.ShouldCreateWrapper = 0;
					canDeserialize = true;
				}
				else
				{
					this._genericCollectionDefinitionType = typeof(global::System.Collections.Generic.List<>).MakeGenericType(new global::System.Type[]
					{
						this.CollectionItemType
					});
					this.IsReadOnlyOrFixedSize = true;
					this.ShouldCreateWrapper = 1;
					canDeserialize = this.HasParameterizedCreatorInternal;
				}
			}
			else
			{
				canDeserialize = false;
				this.ShouldCreateWrapper = 1;
			}
			this.CanDeserialize = canDeserialize;
			global::System.Type createdType;
			global::Newtonsoft.Json.Serialization.ObjectConstructor<object> parameterizedCreator;
			if (this.CollectionItemType != null && global::Newtonsoft.Json.Utilities.ImmutableCollectionsUtils.TryBuildImmutableForArrayContract(this.NonNullableUnderlyingType, this.CollectionItemType, out createdType, out parameterizedCreator))
			{
				base.CreatedType = createdType;
				this._parameterizedCreator = parameterizedCreator;
				this.IsReadOnlyOrFixedSize = true;
				this.CanDeserialize = true;
			}
		}

		// Token: 0x06000692 RID: 1682 RVA: 0x0001C1DC File Offset: 0x0001A3DC
		[global::System.Runtime.CompilerServices.NullableContext(1)]
		internal global::Newtonsoft.Json.Utilities.IWrappedCollection CreateWrapper(object list)
		{
			if (this._genericWrapperCreator == null)
			{
				this._genericWrapperType = typeof(global::Newtonsoft.Json.Utilities.CollectionWrapper<>).MakeGenericType(new global::System.Type[]
				{
					this.CollectionItemType
				});
				global::System.Type type;
				if (global::Newtonsoft.Json.Utilities.ReflectionUtils.InheritsGenericDefinition(this._genericCollectionDefinitionType, typeof(global::System.Collections.Generic.List<>)) || this._genericCollectionDefinitionType.GetGenericTypeDefinition() == typeof(global::System.Collections.Generic.IEnumerable<>))
				{
					type = typeof(global::System.Collections.Generic.ICollection<>).MakeGenericType(new global::System.Type[]
					{
						this.CollectionItemType
					});
				}
				else
				{
					type = this._genericCollectionDefinitionType;
				}
				global::System.Reflection.ConstructorInfo constructor = this._genericWrapperType.GetConstructor(new global::System.Type[]
				{
					type
				});
				this._genericWrapperCreator = global::Newtonsoft.Json.Serialization.JsonTypeReflector.ReflectionDelegateFactory.CreateParameterizedConstructor(constructor);
			}
			return (global::Newtonsoft.Json.Utilities.IWrappedCollection)this._genericWrapperCreator(new object[]
			{
				list
			});
		}

		// Token: 0x06000693 RID: 1683 RVA: 0x0001C2B4 File Offset: 0x0001A4B4
		[global::System.Runtime.CompilerServices.NullableContext(1)]
		internal global::System.Collections.IList CreateTemporaryCollection()
		{
			if (this._genericTemporaryCollectionCreator == null)
			{
				global::System.Type type = (this.IsMultidimensionalArray || this.CollectionItemType == null) ? typeof(object) : this.CollectionItemType;
				global::System.Type type2 = typeof(global::System.Collections.Generic.List<>).MakeGenericType(new global::System.Type[]
				{
					type
				});
				this._genericTemporaryCollectionCreator = global::Newtonsoft.Json.Serialization.JsonTypeReflector.ReflectionDelegateFactory.CreateDefaultConstructor<object>(type2);
			}
			return (global::System.Collections.IList)this._genericTemporaryCollectionCreator();
		}

		// Token: 0x06000694 RID: 1684 RVA: 0x0001C32D File Offset: 0x0001A52D
		[global::System.Runtime.CompilerServices.NullableContext(1)]
		private void StoreFSharpListCreatorIfNecessary(global::System.Type underlyingType)
		{
			if (!this.HasParameterizedCreatorInternal && underlyingType.Name == "FSharpList`1")
			{
				global::Newtonsoft.Json.Utilities.FSharpUtils.EnsureInitialized(underlyingType.Assembly());
				this._parameterizedCreator = global::Newtonsoft.Json.Utilities.FSharpUtils.Instance.CreateSeq(this.CollectionItemType);
			}
		}

		// Token: 0x04000233 RID: 563
		private readonly global::System.Type _genericCollectionDefinitionType;

		// Token: 0x04000234 RID: 564
		private global::System.Type _genericWrapperType;

		// Token: 0x04000235 RID: 565
		[global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			2,
			1
		})]
		private global::Newtonsoft.Json.Serialization.ObjectConstructor<object> _genericWrapperCreator;

		// Token: 0x04000236 RID: 566
		[global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			2,
			1
		})]
		private global::System.Func<object> _genericTemporaryCollectionCreator;

		// Token: 0x0400023A RID: 570
		private readonly global::System.Reflection.ConstructorInfo _parameterizedConstructor;

		// Token: 0x0400023B RID: 571
		[global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			2,
			1
		})]
		private global::Newtonsoft.Json.Serialization.ObjectConstructor<object> _parameterizedCreator;

		// Token: 0x0400023C RID: 572
		[global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			2,
			1
		})]
		private global::Newtonsoft.Json.Serialization.ObjectConstructor<object> _overrideCreator;
	}
}
