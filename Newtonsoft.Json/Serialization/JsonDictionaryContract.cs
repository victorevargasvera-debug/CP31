using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reflection;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x0200008B RID: 139
	[global::System.Runtime.CompilerServices.NullableContext(2)]
	[global::System.Runtime.CompilerServices.Nullable(0)]
	public class JsonDictionaryContract : global::Newtonsoft.Json.Serialization.JsonContainerContract
	{
		// Token: 0x17000105 RID: 261
		// (get) Token: 0x060006CB RID: 1739 RVA: 0x0001C836 File Offset: 0x0001AA36
		// (set) Token: 0x060006CC RID: 1740 RVA: 0x0001C83E File Offset: 0x0001AA3E
		[global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public global::System.Func<string, string> DictionaryKeyResolver { [return: global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			2,
			1,
			1
		})] get; [param: global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			2,
			1,
			1
		})] set; }

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x060006CD RID: 1741 RVA: 0x0001C847 File Offset: 0x0001AA47
		public global::System.Type DictionaryKeyType { get; }

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x060006CE RID: 1742 RVA: 0x0001C84F File Offset: 0x0001AA4F
		public global::System.Type DictionaryValueType { get; }

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x060006CF RID: 1743 RVA: 0x0001C857 File Offset: 0x0001AA57
		// (set) Token: 0x060006D0 RID: 1744 RVA: 0x0001C85F File Offset: 0x0001AA5F
		internal global::Newtonsoft.Json.Serialization.JsonContract KeyContract { get; set; }

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x060006D1 RID: 1745 RVA: 0x0001C868 File Offset: 0x0001AA68
		internal bool ShouldCreateWrapper { get; }

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x060006D2 RID: 1746 RVA: 0x0001C870 File Offset: 0x0001AA70
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

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x060006D3 RID: 1747 RVA: 0x0001C8A4 File Offset: 0x0001AAA4
		// (set) Token: 0x060006D4 RID: 1748 RVA: 0x0001C8AC File Offset: 0x0001AAAC
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
			}
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x060006D5 RID: 1749 RVA: 0x0001C8B5 File Offset: 0x0001AAB5
		// (set) Token: 0x060006D6 RID: 1750 RVA: 0x0001C8BD File Offset: 0x0001AABD
		public bool HasParameterizedCreator { get; set; }

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x060006D7 RID: 1751 RVA: 0x0001C8C6 File Offset: 0x0001AAC6
		internal bool HasParameterizedCreatorInternal
		{
			get
			{
				return this.HasParameterizedCreator || this._parameterizedCreator != null || this._parameterizedConstructor != null;
			}
		}

		// Token: 0x060006D8 RID: 1752 RVA: 0x0001C8E8 File Offset: 0x0001AAE8
		[global::System.Runtime.CompilerServices.NullableContext(1)]
		public JsonDictionaryContract(global::System.Type underlyingType) : base(underlyingType)
		{
			this.ContractType = global::Newtonsoft.Json.Serialization.JsonContractType.Dictionary;
			global::System.Type type;
			global::System.Type type2;
			if (global::Newtonsoft.Json.Utilities.ReflectionUtils.ImplementsGenericDefinition(this.NonNullableUnderlyingType, typeof(global::System.Collections.Generic.IDictionary<, >), out this._genericCollectionDefinitionType))
			{
				type = this._genericCollectionDefinitionType.GetGenericArguments()[0];
				type2 = this._genericCollectionDefinitionType.GetGenericArguments()[1];
				if (global::Newtonsoft.Json.Utilities.ReflectionUtils.IsGenericDefinition(this.NonNullableUnderlyingType, typeof(global::System.Collections.Generic.IDictionary<, >)))
				{
					base.CreatedType = typeof(global::System.Collections.Generic.Dictionary<, >).MakeGenericType(new global::System.Type[]
					{
						type,
						type2
					});
				}
				else if (this.NonNullableUnderlyingType.IsGenericType() && this.NonNullableUnderlyingType.GetGenericTypeDefinition().FullName == "System.Collections.Concurrent.ConcurrentDictionary`2")
				{
					this.ShouldCreateWrapper = 1;
				}
				this.IsReadOnlyOrFixedSize = global::Newtonsoft.Json.Utilities.ReflectionUtils.InheritsGenericDefinition(this.NonNullableUnderlyingType, typeof(global::System.Collections.ObjectModel.ReadOnlyDictionary<, >));
			}
			else if (global::Newtonsoft.Json.Utilities.ReflectionUtils.ImplementsGenericDefinition(this.NonNullableUnderlyingType, typeof(global::System.Collections.Generic.IReadOnlyDictionary<, >), out this._genericCollectionDefinitionType))
			{
				type = this._genericCollectionDefinitionType.GetGenericArguments()[0];
				type2 = this._genericCollectionDefinitionType.GetGenericArguments()[1];
				if (global::Newtonsoft.Json.Utilities.ReflectionUtils.IsGenericDefinition(this.NonNullableUnderlyingType, typeof(global::System.Collections.Generic.IReadOnlyDictionary<, >)))
				{
					base.CreatedType = typeof(global::System.Collections.ObjectModel.ReadOnlyDictionary<, >).MakeGenericType(new global::System.Type[]
					{
						type,
						type2
					});
				}
				this.IsReadOnlyOrFixedSize = true;
			}
			else
			{
				global::Newtonsoft.Json.Utilities.ReflectionUtils.GetDictionaryKeyValueTypes(this.NonNullableUnderlyingType, out type, out type2);
				if (this.NonNullableUnderlyingType == typeof(global::System.Collections.IDictionary))
				{
					base.CreatedType = typeof(global::System.Collections.Generic.Dictionary<object, object>);
				}
			}
			if (type != null && type2 != null)
			{
				this._parameterizedConstructor = global::Newtonsoft.Json.Utilities.CollectionUtils.ResolveEnumerableCollectionConstructor(base.CreatedType, typeof(global::System.Collections.Generic.KeyValuePair<, >).MakeGenericType(new global::System.Type[]
				{
					type,
					type2
				}), typeof(global::System.Collections.Generic.IDictionary<, >).MakeGenericType(new global::System.Type[]
				{
					type,
					type2
				}));
				if (!this.HasParameterizedCreatorInternal && this.NonNullableUnderlyingType.Name == "FSharpMap`2")
				{
					global::Newtonsoft.Json.Utilities.FSharpUtils.EnsureInitialized(this.NonNullableUnderlyingType.Assembly());
					this._parameterizedCreator = global::Newtonsoft.Json.Utilities.FSharpUtils.Instance.CreateMap(type, type2);
				}
			}
			if (!typeof(global::System.Collections.IDictionary).IsAssignableFrom(base.CreatedType))
			{
				this.ShouldCreateWrapper = 1;
			}
			this.DictionaryKeyType = type;
			this.DictionaryValueType = type2;
			global::System.Type createdType;
			global::Newtonsoft.Json.Serialization.ObjectConstructor<object> parameterizedCreator;
			if (this.DictionaryKeyType != null && this.DictionaryValueType != null && global::Newtonsoft.Json.Utilities.ImmutableCollectionsUtils.TryBuildImmutableForDictionaryContract(this.NonNullableUnderlyingType, this.DictionaryKeyType, this.DictionaryValueType, out createdType, out parameterizedCreator))
			{
				base.CreatedType = createdType;
				this._parameterizedCreator = parameterizedCreator;
				this.IsReadOnlyOrFixedSize = true;
			}
		}

		// Token: 0x060006D9 RID: 1753 RVA: 0x0001CB9C File Offset: 0x0001AD9C
		[global::System.Runtime.CompilerServices.NullableContext(1)]
		internal global::Newtonsoft.Json.Utilities.IWrappedDictionary CreateWrapper(object dictionary)
		{
			if (this._genericWrapperCreator == null)
			{
				this._genericWrapperType = typeof(global::Newtonsoft.Json.Utilities.DictionaryWrapper<, >).MakeGenericType(new global::System.Type[]
				{
					this.DictionaryKeyType,
					this.DictionaryValueType
				});
				global::System.Reflection.ConstructorInfo constructor = this._genericWrapperType.GetConstructor(new global::System.Type[]
				{
					this._genericCollectionDefinitionType
				});
				this._genericWrapperCreator = global::Newtonsoft.Json.Serialization.JsonTypeReflector.ReflectionDelegateFactory.CreateParameterizedConstructor(constructor);
			}
			return (global::Newtonsoft.Json.Utilities.IWrappedDictionary)this._genericWrapperCreator(new object[]
			{
				dictionary
			});
		}

		// Token: 0x060006DA RID: 1754 RVA: 0x0001CC24 File Offset: 0x0001AE24
		[global::System.Runtime.CompilerServices.NullableContext(1)]
		internal global::System.Collections.IDictionary CreateTemporaryDictionary()
		{
			if (this._genericTemporaryDictionaryCreator == null)
			{
				global::System.Type type = typeof(global::System.Collections.Generic.Dictionary<, >).MakeGenericType(new global::System.Type[]
				{
					this.DictionaryKeyType ?? typeof(object),
					this.DictionaryValueType ?? typeof(object)
				});
				this._genericTemporaryDictionaryCreator = global::Newtonsoft.Json.Serialization.JsonTypeReflector.ReflectionDelegateFactory.CreateDefaultConstructor<object>(type);
			}
			return (global::System.Collections.IDictionary)this._genericTemporaryDictionaryCreator();
		}

		// Token: 0x04000267 RID: 615
		private readonly global::System.Type _genericCollectionDefinitionType;

		// Token: 0x04000268 RID: 616
		private global::System.Type _genericWrapperType;

		// Token: 0x04000269 RID: 617
		[global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			2,
			1
		})]
		private global::Newtonsoft.Json.Serialization.ObjectConstructor<object> _genericWrapperCreator;

		// Token: 0x0400026A RID: 618
		[global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			2,
			1
		})]
		private global::System.Func<object> _genericTemporaryDictionaryCreator;

		// Token: 0x0400026C RID: 620
		private readonly global::System.Reflection.ConstructorInfo _parameterizedConstructor;

		// Token: 0x0400026D RID: 621
		[global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			2,
			1
		})]
		private global::Newtonsoft.Json.Serialization.ObjectConstructor<object> _overrideCreator;

		// Token: 0x0400026E RID: 622
		[global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			2,
			1
		})]
		private global::Newtonsoft.Json.Serialization.ObjectConstructor<object> _parameterizedCreator;
	}
}
