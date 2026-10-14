using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Common;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Core.Common.QueryCache;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Core.Metadata.Edm.Provider;
using System.Data.Entity.Core.SchemaObjectModel;
using System.Data.Entity.Infrastructure.DependencyResolution;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Linq;
using System.Text;
using System.Xml;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x020004FD RID: 1277
	public class StoreItemCollection : global::System.Data.Entity.Core.Metadata.Edm.ItemCollection
	{
		// Token: 0x06003F25 RID: 16165 RVA: 0x000D1045 File Offset: 0x000CF245
		internal StoreItemCollection() : base(global::System.Data.Entity.Core.Metadata.Edm.DataSpace.SSpace)
		{
		}

		// Token: 0x06003F26 RID: 16166 RVA: 0x000D1064 File Offset: 0x000CF264
		internal StoreItemCollection(global::System.Data.Common.DbProviderFactory factory, global::System.Data.Entity.Core.Common.DbProviderManifest manifest, string providerInvariantName, string providerManifestToken) : base(global::System.Data.Entity.Core.Metadata.Edm.DataSpace.SSpace)
		{
			this._providerFactory = factory;
			this._providerManifest = manifest;
			this._providerInvariantName = providerInvariantName;
			this._providerManifestToken = providerManifestToken;
			this._cachedCTypeFunction = new global::System.Data.Entity.Core.Common.Utils.Memoizer<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction, global::System.Data.Entity.Core.Metadata.Edm.EdmFunction>(new global::System.Func<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction, global::System.Data.Entity.Core.Metadata.Edm.EdmFunction>(global::System.Data.Entity.Core.Metadata.Edm.StoreItemCollection.ConvertFunctionSignatureToCType), null);
			this.LoadProviderManifest(this._providerManifest);
		}

		// Token: 0x06003F27 RID: 16167 RVA: 0x000D10D0 File Offset: 0x000CF2D0
		private StoreItemCollection(global::System.Collections.Generic.IEnumerable<global::System.Xml.XmlReader> xmlReaders, global::System.Collections.ObjectModel.ReadOnlyCollection<string> filePaths, global::System.Data.Entity.Infrastructure.DependencyResolution.IDbDependencyResolver resolver, out global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError> errors) : base(global::System.Data.Entity.Core.Metadata.Edm.DataSpace.SSpace)
		{
			errors = this.Init(xmlReaders, filePaths, false, resolver, out this._providerManifest, out this._providerFactory, out this._providerInvariantName, out this._providerManifestToken, out this._cachedCTypeFunction);
		}

		// Token: 0x06003F28 RID: 16168 RVA: 0x000D1128 File Offset: 0x000CF328
		internal StoreItemCollection(global::System.Collections.Generic.IEnumerable<global::System.Xml.XmlReader> xmlReaders, global::System.Collections.Generic.IEnumerable<string> filePaths) : base(global::System.Data.Entity.Core.Metadata.Edm.DataSpace.SSpace)
		{
			global::System.Data.Entity.Core.EntityUtil.CheckArgumentEmpty<global::System.Xml.XmlReader>(ref xmlReaders, new global::System.Func<string, string>(global::System.Data.Entity.Resources.Strings.StoreItemCollectionMustHaveOneArtifact), "xmlReader");
			this.Init(xmlReaders, filePaths, true, null, out this._providerManifest, out this._providerFactory, out this._providerInvariantName, out this._providerManifestToken, out this._cachedCTypeFunction);
		}

		// Token: 0x06003F29 RID: 16169 RVA: 0x000D1194 File Offset: 0x000CF394
		public StoreItemCollection(global::System.Collections.Generic.IEnumerable<global::System.Xml.XmlReader> xmlReaders) : base(global::System.Data.Entity.Core.Metadata.Edm.DataSpace.SSpace)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Collections.Generic.IEnumerable<global::System.Xml.XmlReader>>(xmlReaders, "xmlReaders");
			global::System.Data.Entity.Core.EntityUtil.CheckArgumentEmpty<global::System.Xml.XmlReader>(ref xmlReaders, new global::System.Func<string, string>(global::System.Data.Entity.Resources.Strings.StoreItemCollectionMustHaveOneArtifact), "xmlReader");
			global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoader metadataArtifactLoader = global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoader.CreateCompositeFromXmlReaders(xmlReaders);
			this.Init(metadataArtifactLoader.GetReaders(), metadataArtifactLoader.GetPaths(), true, null, out this._providerManifest, out this._providerFactory, out this._providerInvariantName, out this._providerManifestToken, out this._cachedCTypeFunction);
		}

		// Token: 0x06003F2A RID: 16170 RVA: 0x000D1220 File Offset: 0x000CF420
		public StoreItemCollection(global::System.Data.Entity.Core.Metadata.Edm.EdmModel model) : base(global::System.Data.Entity.Core.Metadata.Edm.DataSpace.SSpace)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.EdmModel>(model, "model");
			this._providerManifest = model.ProviderManifest;
			this._providerInvariantName = model.ProviderInfo.ProviderInvariantName;
			this._providerFactory = global::System.Data.Entity.DbConfiguration.DependencyResolver.GetService(this._providerInvariantName);
			this._providerManifestToken = model.ProviderInfo.ProviderManifestToken;
			this._cachedCTypeFunction = new global::System.Data.Entity.Core.Common.Utils.Memoizer<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction, global::System.Data.Entity.Core.Metadata.Edm.EdmFunction>(new global::System.Func<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction, global::System.Data.Entity.Core.Metadata.Edm.EdmFunction>(global::System.Data.Entity.Core.Metadata.Edm.StoreItemCollection.ConvertFunctionSignatureToCType), null);
			this.LoadProviderManifest(this._providerManifest);
			this._schemaVersion = model.SchemaVersion;
			model.Validate();
			foreach (global::System.Data.Entity.Core.Metadata.Edm.GlobalItem globalItem in model.GlobalItems)
			{
				globalItem.SetReadOnly();
				base.AddInternal(globalItem);
			}
		}

		// Token: 0x06003F2B RID: 16171 RVA: 0x000D1318 File Offset: 0x000CF518
		public StoreItemCollection(params string[] filePaths) : base(global::System.Data.Entity.Core.Metadata.Edm.DataSpace.SSpace)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<string[]>(filePaths, "filePaths");
			global::System.Collections.Generic.IEnumerable<string> filePaths2 = filePaths;
			global::System.Data.Entity.Core.EntityUtil.CheckArgumentEmpty<string>(ref filePaths2, new global::System.Func<string, string>(global::System.Data.Entity.Resources.Strings.StoreItemCollectionMustHaveOneArtifact), "filePaths");
			global::System.Collections.Generic.List<global::System.Xml.XmlReader> list = null;
			try
			{
				global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoader metadataArtifactLoader = global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoader.CreateCompositeFromFilePaths(filePaths2, ".ssdl");
				list = metadataArtifactLoader.CreateReaders(global::System.Data.Entity.Core.Metadata.Edm.DataSpace.SSpace);
				global::System.Collections.Generic.IEnumerable<global::System.Xml.XmlReader> enumerable = list.AsEnumerable<global::System.Xml.XmlReader>();
				global::System.Data.Entity.Core.EntityUtil.CheckArgumentEmpty<global::System.Xml.XmlReader>(ref enumerable, new global::System.Func<string, string>(global::System.Data.Entity.Resources.Strings.StoreItemCollectionMustHaveOneArtifact), "filePaths");
				this.Init(list, metadataArtifactLoader.GetPaths(global::System.Data.Entity.Core.Metadata.Edm.DataSpace.SSpace), true, null, out this._providerManifest, out this._providerFactory, out this._providerInvariantName, out this._providerManifestToken, out this._cachedCTypeFunction);
			}
			finally
			{
				if (list != null)
				{
					global::System.Data.Entity.Core.Metadata.Edm.Helper.DisposeXmlReaders(list);
				}
			}
		}

		// Token: 0x06003F2C RID: 16172 RVA: 0x000D13EC File Offset: 0x000CF5EC
		private global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError> Init(global::System.Collections.Generic.IEnumerable<global::System.Xml.XmlReader> xmlReaders, global::System.Collections.Generic.IEnumerable<string> filePaths, bool throwOnError, global::System.Data.Entity.Infrastructure.DependencyResolution.IDbDependencyResolver resolver, out global::System.Data.Entity.Core.Common.DbProviderManifest providerManifest, out global::System.Data.Common.DbProviderFactory providerFactory, out string providerInvariantName, out string providerManifestToken, out global::System.Data.Entity.Core.Common.Utils.Memoizer<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction, global::System.Data.Entity.Core.Metadata.Edm.EdmFunction> cachedCTypeFunction)
		{
			cachedCTypeFunction = new global::System.Data.Entity.Core.Common.Utils.Memoizer<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction, global::System.Data.Entity.Core.Metadata.Edm.EdmFunction>(new global::System.Func<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction, global::System.Data.Entity.Core.Metadata.Edm.EdmFunction>(global::System.Data.Entity.Core.Metadata.Edm.StoreItemCollection.ConvertFunctionSignatureToCType), null);
			global::System.Data.Entity.Core.Metadata.Edm.StoreItemCollection.Loader loader = new global::System.Data.Entity.Core.Metadata.Edm.StoreItemCollection.Loader(xmlReaders, filePaths, throwOnError, resolver);
			providerFactory = loader.ProviderFactory;
			providerManifest = loader.ProviderManifest;
			providerManifestToken = loader.ProviderManifestToken;
			providerInvariantName = loader.ProviderInvariantName;
			if (!loader.HasNonWarningErrors)
			{
				this.LoadProviderManifest(loader.ProviderManifest);
				global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError> list = global::System.Data.Entity.Core.Metadata.Edm.EdmItemCollection.LoadItems(this._providerManifest, loader.Schemas, this);
				foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError item in list)
				{
					loader.Errors.Add(item);
				}
				if (throwOnError && list.Count != 0)
				{
					loader.ThrowOnNonWarningErrors();
				}
			}
			return loader.Errors;
		}

		// Token: 0x17000C68 RID: 3176
		// (get) Token: 0x06003F2D RID: 16173 RVA: 0x000D14C4 File Offset: 0x000CF6C4
		internal global::System.Data.Entity.Core.Common.QueryCache.QueryCacheManager QueryCacheManager
		{
			get
			{
				return this._queryCacheManager;
			}
		}

		// Token: 0x17000C69 RID: 3177
		// (get) Token: 0x06003F2E RID: 16174 RVA: 0x000D14CC File Offset: 0x000CF6CC
		public virtual global::System.Data.Common.DbProviderFactory ProviderFactory
		{
			get
			{
				return this._providerFactory;
			}
		}

		// Token: 0x17000C6A RID: 3178
		// (get) Token: 0x06003F2F RID: 16175 RVA: 0x000D14D4 File Offset: 0x000CF6D4
		public virtual global::System.Data.Entity.Core.Common.DbProviderManifest ProviderManifest
		{
			get
			{
				return this._providerManifest;
			}
		}

		// Token: 0x17000C6B RID: 3179
		// (get) Token: 0x06003F30 RID: 16176 RVA: 0x000D14DC File Offset: 0x000CF6DC
		public virtual string ProviderManifestToken
		{
			get
			{
				return this._providerManifestToken;
			}
		}

		// Token: 0x17000C6C RID: 3180
		// (get) Token: 0x06003F31 RID: 16177 RVA: 0x000D14E4 File Offset: 0x000CF6E4
		public virtual string ProviderInvariantName
		{
			get
			{
				return this._providerInvariantName;
			}
		}

		// Token: 0x17000C6D RID: 3181
		// (get) Token: 0x06003F32 RID: 16178 RVA: 0x000D14EC File Offset: 0x000CF6EC
		// (set) Token: 0x06003F33 RID: 16179 RVA: 0x000D14F4 File Offset: 0x000CF6F4
		public double StoreSchemaVersion
		{
			get
			{
				return this._schemaVersion;
			}
			internal set
			{
				this._schemaVersion = value;
			}
		}

		// Token: 0x06003F34 RID: 16180 RVA: 0x000D14FD File Offset: 0x000CF6FD
		public virtual global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType> GetPrimitiveTypes()
		{
			return this._primitiveTypeMaps.GetTypes();
		}

		// Token: 0x06003F35 RID: 16181 RVA: 0x000D150C File Offset: 0x000CF70C
		internal override global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType GetMappedPrimitiveType(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind primitiveTypeKind)
		{
			global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType result = null;
			this._primitiveTypeMaps.TryGetType(primitiveTypeKind, null, out result);
			return result;
		}

		// Token: 0x06003F36 RID: 16182 RVA: 0x000D152C File Offset: 0x000CF72C
		private void LoadProviderManifest(global::System.Data.Entity.Core.Common.DbProviderManifest storeManifest)
		{
			foreach (global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType primitiveType in storeManifest.GetStoreTypes())
			{
				base.AddInternal(primitiveType);
				this._primitiveTypeMaps.Add(primitiveType);
			}
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmFunction item in storeManifest.GetStoreFunctions())
			{
				base.AddInternal(item);
			}
		}

		// Token: 0x06003F37 RID: 16183 RVA: 0x000D15C4 File Offset: 0x000CF7C4
		internal global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction> GetCTypeFunctions(string functionName, bool ignoreCase)
		{
			global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction> readOnlyCollection;
			if (!base.FunctionLookUpTable.TryGetValue(functionName, out readOnlyCollection))
			{
				return global::System.Data.Entity.Core.Metadata.Edm.Helper.EmptyEdmFunctionReadOnlyCollection;
			}
			readOnlyCollection = this.ConvertToCTypeFunctions(readOnlyCollection);
			if (ignoreCase)
			{
				return readOnlyCollection;
			}
			return global::System.Data.Entity.Core.Metadata.Edm.ItemCollection.GetCaseSensitiveFunctions(readOnlyCollection, functionName);
		}

		// Token: 0x06003F38 RID: 16184 RVA: 0x000D15FC File Offset: 0x000CF7FC
		private global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction> ConvertToCTypeFunctions(global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction> functionOverloads)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction>();
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmFunction sTypeFunction in functionOverloads)
			{
				list.Add(this.ConvertToCTypeFunction(sTypeFunction));
			}
			return new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction>(list);
		}

		// Token: 0x06003F39 RID: 16185 RVA: 0x000D1658 File Offset: 0x000CF858
		internal global::System.Data.Entity.Core.Metadata.Edm.EdmFunction ConvertToCTypeFunction(global::System.Data.Entity.Core.Metadata.Edm.EdmFunction sTypeFunction)
		{
			return this._cachedCTypeFunction.Evaluate(sTypeFunction);
		}

		// Token: 0x06003F3A RID: 16186 RVA: 0x000D1668 File Offset: 0x000CF868
		internal static global::System.Data.Entity.Core.Metadata.Edm.EdmFunction ConvertFunctionSignatureToCType(global::System.Data.Entity.Core.Metadata.Edm.EdmFunction sTypeFunction)
		{
			if (sTypeFunction.IsFromProviderManifest)
			{
				return sTypeFunction;
			}
			global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter functionParameter = null;
			if (sTypeFunction.ReturnParameter != null)
			{
				global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage = global::System.Data.Entity.Core.Common.Utils.MetadataHelper.ConvertStoreTypeUsageToEdmTypeUsage(sTypeFunction.ReturnParameter.TypeUsage);
				functionParameter = new global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter(sTypeFunction.ReturnParameter.Name, typeUsage, sTypeFunction.ReturnParameter.GetParameterMode());
			}
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter>();
			if (sTypeFunction.Parameters.Count > 0)
			{
				foreach (global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter functionParameter2 in sTypeFunction.Parameters)
				{
					global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage2 = global::System.Data.Entity.Core.Common.Utils.MetadataHelper.ConvertStoreTypeUsageToEdmTypeUsage(functionParameter2.TypeUsage);
					global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter item = new global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter(functionParameter2.Name, typeUsage2, functionParameter2.GetParameterMode());
					list.Add(item);
				}
			}
			global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter[] array;
			if (functionParameter != null)
			{
				(array = new global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter[1])[0] = functionParameter;
			}
			else
			{
				array = new global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter[0];
			}
			global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter[] returnParameters = array;
			global::System.Data.Entity.Core.Metadata.Edm.EdmFunction edmFunction = new global::System.Data.Entity.Core.Metadata.Edm.EdmFunction(sTypeFunction.Name, sTypeFunction.NamespaceName, global::System.Data.Entity.Core.Metadata.Edm.DataSpace.CSpace, new global::System.Data.Entity.Core.Metadata.Edm.EdmFunctionPayload
			{
				Schema = sTypeFunction.Schema,
				StoreFunctionName = sTypeFunction.StoreFunctionNameAttribute,
				CommandText = sTypeFunction.CommandTextAttribute,
				IsAggregate = new bool?(sTypeFunction.AggregateAttribute),
				IsBuiltIn = new bool?(sTypeFunction.BuiltInAttribute),
				IsNiladic = new bool?(sTypeFunction.NiladicFunctionAttribute),
				IsComposable = new bool?(sTypeFunction.IsComposableAttribute),
				IsFromProviderManifest = new bool?(sTypeFunction.IsFromProviderManifest),
				IsCachedStoreFunction = new bool?(true),
				IsFunctionImport = new bool?(sTypeFunction.IsFunctionImport),
				ReturnParameters = returnParameters,
				Parameters = list.ToArray(),
				ParameterTypeSemantics = new global::System.Data.Entity.Core.Metadata.Edm.ParameterTypeSemantics?(sTypeFunction.ParameterTypeSemanticsAttribute)
			});
			edmFunction.SetReadOnly();
			return edmFunction;
		}

		// Token: 0x06003F3B RID: 16187 RVA: 0x000D1828 File Offset: 0x000CFA28
		public static global::System.Data.Entity.Core.Metadata.Edm.StoreItemCollection Create(global::System.Collections.Generic.IEnumerable<global::System.Xml.XmlReader> xmlReaders, global::System.Collections.ObjectModel.ReadOnlyCollection<string> filePaths, global::System.Data.Entity.Infrastructure.DependencyResolution.IDbDependencyResolver resolver, out global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError> errors)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Collections.Generic.IEnumerable<global::System.Xml.XmlReader>>(xmlReaders, "xmlReaders");
			global::System.Data.Entity.Core.EntityUtil.CheckArgumentContainsNull<global::System.Xml.XmlReader>(ref xmlReaders, "xmlReaders");
			global::System.Data.Entity.Core.EntityUtil.CheckArgumentEmpty<global::System.Xml.XmlReader>(ref xmlReaders, new global::System.Func<string, string>(global::System.Data.Entity.Resources.Strings.StoreItemCollectionMustHaveOneArtifact), "xmlReaders");
			global::System.Data.Entity.Core.Metadata.Edm.StoreItemCollection result = new global::System.Data.Entity.Core.Metadata.Edm.StoreItemCollection(xmlReaders, filePaths, resolver, ref errors);
			if (errors == null || errors.Count <= 0)
			{
				return result;
			}
			return null;
		}

		// Token: 0x0400158B RID: 5515
		private double _schemaVersion;

		// Token: 0x0400158C RID: 5516
		private readonly global::System.Data.Entity.Core.Metadata.Edm.CacheForPrimitiveTypes _primitiveTypeMaps = new global::System.Data.Entity.Core.Metadata.Edm.CacheForPrimitiveTypes();

		// Token: 0x0400158D RID: 5517
		private readonly global::System.Data.Entity.Core.Common.Utils.Memoizer<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction, global::System.Data.Entity.Core.Metadata.Edm.EdmFunction> _cachedCTypeFunction;

		// Token: 0x0400158E RID: 5518
		private readonly global::System.Data.Entity.Core.Common.DbProviderManifest _providerManifest;

		// Token: 0x0400158F RID: 5519
		private readonly string _providerInvariantName;

		// Token: 0x04001590 RID: 5520
		private readonly string _providerManifestToken;

		// Token: 0x04001591 RID: 5521
		private readonly global::System.Data.Common.DbProviderFactory _providerFactory;

		// Token: 0x04001592 RID: 5522
		private readonly global::System.Data.Entity.Core.Common.QueryCache.QueryCacheManager _queryCacheManager = global::System.Data.Entity.Core.Common.QueryCache.QueryCacheManager.Create();

		// Token: 0x02000B10 RID: 2832
		private class Loader
		{
			// Token: 0x06006470 RID: 25712 RVA: 0x0015A68C File Offset: 0x0015888C
			public Loader(global::System.Collections.Generic.IEnumerable<global::System.Xml.XmlReader> xmlReaders, global::System.Collections.Generic.IEnumerable<string> sourceFilePaths, bool throwOnError, global::System.Data.Entity.Infrastructure.DependencyResolution.IDbDependencyResolver resolver)
			{
				this._throwOnError = throwOnError;
				global::System.Data.Entity.Infrastructure.DependencyResolution.IDbDependencyResolver resolver2;
				if (resolver != null)
				{
					global::System.Data.Entity.Infrastructure.DependencyResolution.IDbDependencyResolver dbDependencyResolver = new global::System.Data.Entity.Infrastructure.DependencyResolution.CompositeResolver<global::System.Data.Entity.Infrastructure.DependencyResolution.IDbDependencyResolver, global::System.Data.Entity.Infrastructure.DependencyResolution.IDbDependencyResolver>(resolver, global::System.Data.Entity.DbConfiguration.DependencyResolver);
					resolver2 = dbDependencyResolver;
				}
				else
				{
					resolver2 = global::System.Data.Entity.DbConfiguration.DependencyResolver;
				}
				this._resolver = resolver2;
				this.LoadItems(xmlReaders, sourceFilePaths);
			}

			// Token: 0x170010ED RID: 4333
			// (get) Token: 0x06006471 RID: 25713 RVA: 0x0015A6CD File Offset: 0x001588CD
			public global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError> Errors
			{
				get
				{
					return this._errors;
				}
			}

			// Token: 0x170010EE RID: 4334
			// (get) Token: 0x06006472 RID: 25714 RVA: 0x0015A6D5 File Offset: 0x001588D5
			public global::System.Collections.Generic.IList<global::System.Data.Entity.Core.SchemaObjectModel.Schema> Schemas
			{
				get
				{
					return this._schemas;
				}
			}

			// Token: 0x170010EF RID: 4335
			// (get) Token: 0x06006473 RID: 25715 RVA: 0x0015A6DD File Offset: 0x001588DD
			public global::System.Data.Entity.Core.Common.DbProviderManifest ProviderManifest
			{
				get
				{
					return this._providerManifest;
				}
			}

			// Token: 0x170010F0 RID: 4336
			// (get) Token: 0x06006474 RID: 25716 RVA: 0x0015A6E5 File Offset: 0x001588E5
			public global::System.Data.Common.DbProviderFactory ProviderFactory
			{
				get
				{
					return this._providerFactory;
				}
			}

			// Token: 0x170010F1 RID: 4337
			// (get) Token: 0x06006475 RID: 25717 RVA: 0x0015A6ED File Offset: 0x001588ED
			public string ProviderManifestToken
			{
				get
				{
					return this._providerManifestToken;
				}
			}

			// Token: 0x170010F2 RID: 4338
			// (get) Token: 0x06006476 RID: 25718 RVA: 0x0015A6F5 File Offset: 0x001588F5
			public string ProviderInvariantName
			{
				get
				{
					return this._provider;
				}
			}

			// Token: 0x170010F3 RID: 4339
			// (get) Token: 0x06006477 RID: 25719 RVA: 0x0015A6FD File Offset: 0x001588FD
			public bool HasNonWarningErrors
			{
				get
				{
					return !global::System.Data.Entity.Core.Common.Utils.MetadataHelper.CheckIfAllErrorsAreWarnings(this._errors);
				}
			}

			// Token: 0x06006478 RID: 25720 RVA: 0x0015A710 File Offset: 0x00158910
			private void LoadItems(global::System.Collections.Generic.IEnumerable<global::System.Xml.XmlReader> xmlReaders, global::System.Collections.Generic.IEnumerable<string> sourceFilePaths)
			{
				this._errors = global::System.Data.Entity.Core.SchemaObjectModel.SchemaManager.ParseAndValidate(xmlReaders, sourceFilePaths, global::System.Data.Entity.Core.SchemaObjectModel.SchemaDataModelOption.ProviderDataModel, new global::System.Data.Entity.Core.SchemaObjectModel.AttributeValueNotification(this.OnProviderNotification), new global::System.Data.Entity.Core.SchemaObjectModel.AttributeValueNotification(this.OnProviderManifestTokenNotification), new global::System.Data.Entity.Core.SchemaObjectModel.ProviderManifestNeeded(this.OnProviderManifestNeeded), out this._schemas);
				if (this._throwOnError)
				{
					this.ThrowOnNonWarningErrors();
				}
			}

			// Token: 0x06006479 RID: 25721 RVA: 0x0015A763 File Offset: 0x00158963
			internal void ThrowOnNonWarningErrors()
			{
				if (!global::System.Data.Entity.Core.Common.Utils.MetadataHelper.CheckIfAllErrorsAreWarnings(this._errors))
				{
					throw global::System.Data.Entity.Core.EntityUtil.InvalidSchemaEncountered(global::System.Data.Entity.Core.Metadata.Edm.Helper.CombineErrorMessage(this._errors));
				}
			}

			// Token: 0x0600647A RID: 25722 RVA: 0x0015A784 File Offset: 0x00158984
			private void OnProviderNotification(string provider, global::System.Action<string, global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity> addError)
			{
				string provider2 = this._provider;
				if (this._provider == null)
				{
					this._provider = provider;
					this.InitializeProviderManifest(addError);
					return;
				}
				if (this._provider == provider)
				{
					return;
				}
				addError(global::System.Data.Entity.Resources.Strings.AllArtifactsMustTargetSameProvider_InvariantName(provider2, this._provider), global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.InconsistentProvider, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error);
			}

			// Token: 0x0600647B RID: 25723 RVA: 0x0015A7D8 File Offset: 0x001589D8
			private void InitializeProviderManifest(global::System.Action<string, global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity> addError)
			{
				if (this._providerManifest == null && this._providerManifestToken != null && this._provider != null)
				{
					global::System.Data.Common.DbProviderFactory providerFactory = null;
					try
					{
						providerFactory = global::System.Data.Entity.DbConfiguration.DependencyResolver.GetService(this._provider);
					}
					catch (global::System.ArgumentException ex)
					{
						addError(ex.Message, global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.InvalidProvider, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error);
						return;
					}
					try
					{
						global::System.Data.Entity.Core.Common.DbProviderServices service = this._resolver.GetService(this._provider);
						this._providerManifest = service.GetProviderManifest(this._providerManifestToken);
						this._providerFactory = providerFactory;
						if (this._providerManifest is global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifest)
						{
							if (this._throwOnError)
							{
								throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.OnlyStoreConnectionsSupported);
							}
							addError(global::System.Data.Entity.Resources.Strings.OnlyStoreConnectionsSupported, global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.InvalidProvider, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error);
						}
					}
					catch (global::System.Data.Entity.Core.ProviderIncompatibleException provEx)
					{
						if (this._throwOnError)
						{
							throw;
						}
						global::System.Data.Entity.Core.Metadata.Edm.StoreItemCollection.Loader.AddProviderIncompatibleError(provEx, addError);
					}
				}
			}

			// Token: 0x0600647C RID: 25724 RVA: 0x0015A8C0 File Offset: 0x00158AC0
			private void OnProviderManifestTokenNotification(string token, global::System.Action<string, global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity> addError)
			{
				if (this._providerManifestToken == null)
				{
					this._providerManifestToken = token;
					this.InitializeProviderManifest(addError);
					return;
				}
				if (this._providerManifestToken != token)
				{
					addError(global::System.Data.Entity.Resources.Strings.AllArtifactsMustTargetSameProvider_ManifestToken(token, this._providerManifestToken), global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.ProviderManifestTokenMismatch, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error);
				}
			}

			// Token: 0x0600647D RID: 25725 RVA: 0x0015A8FF File Offset: 0x00158AFF
			private global::System.Data.Entity.Core.Common.DbProviderManifest OnProviderManifestNeeded(global::System.Action<string, global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity> addError)
			{
				if (this._providerManifest == null)
				{
					addError(global::System.Data.Entity.Resources.Strings.ProviderManifestTokenNotFound, global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.ProviderManifestTokenNotFound, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error);
				}
				return this._providerManifest;
			}

			// Token: 0x0600647E RID: 25726 RVA: 0x0015A920 File Offset: 0x00158B20
			private static void AddProviderIncompatibleError(global::System.Data.Entity.Core.ProviderIncompatibleException provEx, global::System.Action<string, global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity> addError)
			{
				global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(provEx.Message);
				if (provEx.InnerException != null && !string.IsNullOrEmpty(provEx.InnerException.Message))
				{
					stringBuilder.AppendFormat(" {0}", provEx.InnerException.Message);
				}
				addError(stringBuilder.ToString(), global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.FailedToRetrieveProviderManifest, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error);
			}

			// Token: 0x04002CA8 RID: 11432
			private string _provider;

			// Token: 0x04002CA9 RID: 11433
			private string _providerManifestToken;

			// Token: 0x04002CAA RID: 11434
			private global::System.Data.Entity.Core.Common.DbProviderManifest _providerManifest;

			// Token: 0x04002CAB RID: 11435
			private global::System.Data.Common.DbProviderFactory _providerFactory;

			// Token: 0x04002CAC RID: 11436
			private global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError> _errors;

			// Token: 0x04002CAD RID: 11437
			private global::System.Collections.Generic.IList<global::System.Data.Entity.Core.SchemaObjectModel.Schema> _schemas;

			// Token: 0x04002CAE RID: 11438
			private readonly bool _throwOnError;

			// Token: 0x04002CAF RID: 11439
			private readonly global::System.Data.Entity.Infrastructure.DependencyResolution.IDbDependencyResolver _resolver;
		}
	}
}
