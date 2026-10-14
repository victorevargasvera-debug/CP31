using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Metadata.Edm.Provider;
using System.Data.Entity.Core.SchemaObjectModel;
using System.Data.Entity.Resources;
using System.Xml;

namespace System.Data.Entity.Core.Common
{
	// Token: 0x020005ED RID: 1517
	public abstract class DbXmlEnabledProviderManifest : global::System.Data.Entity.Core.Common.DbProviderManifest
	{
		// Token: 0x06004A54 RID: 19028 RVA: 0x001067CC File Offset: 0x001049CC
		protected DbXmlEnabledProviderManifest(global::System.Xml.XmlReader reader)
		{
			if (reader == null)
			{
				throw new global::System.Data.Entity.Core.ProviderIncompatibleException(global::System.Data.Entity.Resources.Strings.IncorrectProviderManifest, new global::System.ArgumentNullException("reader"));
			}
			this.Load(reader);
		}

		// Token: 0x17000EA8 RID: 3752
		// (get) Token: 0x06004A55 RID: 19029 RVA: 0x0010681F File Offset: 0x00104A1F
		public override string NamespaceName
		{
			get
			{
				return this._namespaceName;
			}
		}

		// Token: 0x17000EA9 RID: 3753
		// (get) Token: 0x06004A56 RID: 19030 RVA: 0x00106827 File Offset: 0x00104A27
		protected global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType> StoreTypeNameToEdmPrimitiveType
		{
			get
			{
				return this._storeTypeNameToEdmPrimitiveType;
			}
		}

		// Token: 0x17000EAA RID: 3754
		// (get) Token: 0x06004A57 RID: 19031 RVA: 0x0010682F File Offset: 0x00104A2F
		protected global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType> StoreTypeNameToStorePrimitiveType
		{
			get
			{
				return this._storeTypeNameToStorePrimitiveType;
			}
		}

		// Token: 0x06004A58 RID: 19032 RVA: 0x00106837 File Offset: 0x00104A37
		public override global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.FacetDescription> GetFacetDescriptions(global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType)
		{
			return global::System.Data.Entity.Core.Common.DbXmlEnabledProviderManifest.GetReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.FacetDescription>(edmType as global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType, this._facetDescriptions, global::System.Data.Entity.Core.Metadata.Edm.Helper.EmptyFacetDescriptionEnumerable);
		}

		// Token: 0x06004A59 RID: 19033 RVA: 0x0010684F File Offset: 0x00104A4F
		public override global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType> GetStoreTypes()
		{
			return this._primitiveTypes;
		}

		// Token: 0x06004A5A RID: 19034 RVA: 0x00106857 File Offset: 0x00104A57
		public override global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction> GetStoreFunctions()
		{
			return this._functions;
		}

		// Token: 0x06004A5B RID: 19035 RVA: 0x00106860 File Offset: 0x00104A60
		private void Load(global::System.Xml.XmlReader reader)
		{
			global::System.Data.Entity.Core.SchemaObjectModel.Schema schema;
			global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError> list = global::System.Data.Entity.Core.SchemaObjectModel.SchemaManager.LoadProviderManifest(reader, (reader.BaseURI.Length > 0) ? reader.BaseURI : null, true, out schema);
			if (list.Count != 0)
			{
				throw new global::System.Data.Entity.Core.ProviderIncompatibleException(global::System.Data.Entity.Resources.Strings.IncorrectProviderManifest + global::System.Data.Entity.Core.Metadata.Edm.Helper.CombineErrorMessage(list));
			}
			this._namespaceName = schema.Namespace;
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType> list2 = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType>();
			foreach (global::System.Data.Entity.Core.SchemaObjectModel.SchemaType schemaType in schema.SchemaTypes)
			{
				global::System.Data.Entity.Core.SchemaObjectModel.TypeElement typeElement = schemaType as global::System.Data.Entity.Core.SchemaObjectModel.TypeElement;
				if (typeElement != null)
				{
					global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType primitiveType = typeElement.PrimitiveType;
					primitiveType.ProviderManifest = this;
					primitiveType.DataSpace = global::System.Data.Entity.Core.Metadata.Edm.DataSpace.SSpace;
					primitiveType.SetReadOnly();
					list2.Add(primitiveType);
					this._storeTypeNameToStorePrimitiveType.Add(primitiveType.Name.ToLowerInvariant(), primitiveType);
					this._storeTypeNameToEdmPrimitiveType.Add(primitiveType.Name.ToLowerInvariant(), global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifest.Instance.GetPrimitiveType(primitiveType.PrimitiveTypeKind));
					global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.FacetDescription> value;
					if (global::System.Data.Entity.Core.Common.DbXmlEnabledProviderManifest.EnumerableToReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.FacetDescription, global::System.Data.Entity.Core.Metadata.Edm.FacetDescription>(typeElement.FacetDescriptions, out value))
					{
						this._facetDescriptions.Add(primitiveType, value);
					}
				}
			}
			this._primitiveTypes = new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType>(list2.ToArray());
			global::System.Data.Entity.Core.Metadata.Edm.ItemCollection itemCollection = new global::System.Data.Entity.Core.Common.DbXmlEnabledProviderManifest.EmptyItemCollection();
			if (!global::System.Data.Entity.Core.Common.DbXmlEnabledProviderManifest.EnumerableToReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction, global::System.Data.Entity.Core.Metadata.Edm.GlobalItem>(global::System.Data.Entity.Core.Metadata.Edm.Converter.ConvertSchema(schema, this, itemCollection), out this._functions))
			{
				this._functions = global::System.Data.Entity.Core.Metadata.Edm.Helper.EmptyEdmFunctionReadOnlyCollection;
			}
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmFunction edmFunction in this._functions)
			{
				edmFunction.SetReadOnly();
			}
		}

		// Token: 0x06004A5C RID: 19036 RVA: 0x00106A10 File Offset: 0x00104C10
		private static global::System.Collections.ObjectModel.ReadOnlyCollection<T> GetReadOnlyCollection<T>(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType type, global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType, global::System.Collections.ObjectModel.ReadOnlyCollection<T>> typeDictionary, global::System.Collections.ObjectModel.ReadOnlyCollection<T> useIfEmpty)
		{
			global::System.Collections.ObjectModel.ReadOnlyCollection<T> result;
			if (typeDictionary.TryGetValue(type, out result))
			{
				return result;
			}
			return useIfEmpty;
		}

		// Token: 0x06004A5D RID: 19037 RVA: 0x00106A2C File Offset: 0x00104C2C
		private static bool EnumerableToReadOnlyCollection<Target, BaseType>(global::System.Collections.Generic.IEnumerable<BaseType> enumerable, out global::System.Collections.ObjectModel.ReadOnlyCollection<Target> collection) where Target : BaseType
		{
			global::System.Collections.Generic.List<Target> list = new global::System.Collections.Generic.List<Target>();
			foreach (BaseType baseType in enumerable)
			{
				if (typeof(Target) == typeof(BaseType) || baseType is Target)
				{
					list.Add((Target)((object)baseType));
				}
			}
			if (list.Count != 0)
			{
				collection = new global::System.Collections.ObjectModel.ReadOnlyCollection<Target>(list);
				return true;
			}
			collection = null;
			return false;
		}

		// Token: 0x04001A30 RID: 6704
		private string _namespaceName;

		// Token: 0x04001A31 RID: 6705
		private global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType> _primitiveTypes;

		// Token: 0x04001A32 RID: 6706
		private readonly global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType, global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.FacetDescription>> _facetDescriptions = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType, global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.FacetDescription>>();

		// Token: 0x04001A33 RID: 6707
		private global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction> _functions;

		// Token: 0x04001A34 RID: 6708
		private readonly global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType> _storeTypeNameToEdmPrimitiveType = new global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType>();

		// Token: 0x04001A35 RID: 6709
		private readonly global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType> _storeTypeNameToStorePrimitiveType = new global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType>();

		// Token: 0x02000C36 RID: 3126
		private class EmptyItemCollection : global::System.Data.Entity.Core.Metadata.Edm.ItemCollection
		{
			// Token: 0x06006A12 RID: 27154 RVA: 0x0016A3B0 File Offset: 0x001685B0
			public EmptyItemCollection() : base(global::System.Data.Entity.Core.Metadata.Edm.DataSpace.SSpace)
			{
			}
		}
	}
}
