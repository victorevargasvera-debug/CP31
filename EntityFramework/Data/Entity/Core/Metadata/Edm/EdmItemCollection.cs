using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Core.Mapping.ViewGeneration.Utils;
using System.Data.Entity.Core.Metadata.Edm.Provider;
using System.Data.Entity.Core.Objects.ELinq;
using System.Data.Entity.Core.SchemaObjectModel;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Xml;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x020004A6 RID: 1190
	public sealed class EdmItemCollection : global::System.Data.Entity.Core.Metadata.Edm.ItemCollection
	{
		// Token: 0x06003A99 RID: 15001 RVA: 0x000C07DA File Offset: 0x000BE9DA
		internal EdmItemCollection(global::System.Collections.Generic.IEnumerable<global::System.Xml.XmlReader> xmlReaders, global::System.Collections.Generic.IEnumerable<string> filePaths, bool skipInitialization = false) : base(global::System.Data.Entity.Core.Metadata.Edm.DataSpace.CSpace)
		{
			if (!skipInitialization)
			{
				this.Init(xmlReaders, filePaths, true);
			}
		}

		// Token: 0x06003A9A RID: 15002 RVA: 0x000C0808 File Offset: 0x000BEA08
		public EdmItemCollection(global::System.Collections.Generic.IEnumerable<global::System.Xml.XmlReader> xmlReaders) : base(global::System.Data.Entity.Core.Metadata.Edm.DataSpace.CSpace)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Collections.Generic.IEnumerable<global::System.Xml.XmlReader>>(xmlReaders, "xmlReaders");
			global::System.Data.Entity.Core.EntityUtil.CheckArgumentContainsNull<global::System.Xml.XmlReader>(ref xmlReaders, "xmlReaders");
			global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoader metadataArtifactLoader = global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoader.CreateCompositeFromXmlReaders(xmlReaders);
			this.Init(metadataArtifactLoader.GetReaders(), metadataArtifactLoader.GetPaths(), true);
		}

		// Token: 0x06003A9B RID: 15003 RVA: 0x000C0868 File Offset: 0x000BEA68
		public EdmItemCollection(global::System.Data.Entity.Core.Metadata.Edm.EdmModel model) : base(global::System.Data.Entity.Core.Metadata.Edm.DataSpace.CSpace)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.EdmModel>(model, "model");
			this.Init();
			this._edmVersion = model.SchemaVersion;
			model.Validate();
			foreach (global::System.Data.Entity.Core.Metadata.Edm.GlobalItem globalItem in model.GlobalItems)
			{
				globalItem.SetReadOnly();
				base.AddInternal(globalItem);
			}
		}

		// Token: 0x06003A9C RID: 15004 RVA: 0x000C08FC File Offset: 0x000BEAFC
		public EdmItemCollection(params string[] filePaths) : base(global::System.Data.Entity.Core.Metadata.Edm.DataSpace.CSpace)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<string[]>(filePaths, "filePaths");
			global::System.Collections.Generic.List<global::System.Xml.XmlReader> list = null;
			try
			{
				global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoader metadataArtifactLoader = global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoader.CreateCompositeFromFilePaths(filePaths, ".csdl");
				list = metadataArtifactLoader.CreateReaders(global::System.Data.Entity.Core.Metadata.Edm.DataSpace.CSpace);
				this.Init(list, metadataArtifactLoader.GetPaths(global::System.Data.Entity.Core.Metadata.Edm.DataSpace.CSpace), true);
			}
			finally
			{
				if (list != null)
				{
					global::System.Data.Entity.Core.Metadata.Edm.Helper.DisposeXmlReaders(list);
				}
			}
		}

		// Token: 0x06003A9D RID: 15005 RVA: 0x000C0978 File Offset: 0x000BEB78
		private EdmItemCollection(global::System.Collections.Generic.IEnumerable<global::System.Xml.XmlReader> xmlReaders, global::System.Collections.ObjectModel.ReadOnlyCollection<string> filePaths, out global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError> errors) : base(global::System.Data.Entity.Core.Metadata.Edm.DataSpace.CSpace)
		{
			errors = this.Init(xmlReaders, filePaths, false);
		}

		// Token: 0x06003A9E RID: 15006 RVA: 0x000C09A2 File Offset: 0x000BEBA2
		private void Init()
		{
			this.LoadEdmPrimitiveTypesAndFunctions();
		}

		// Token: 0x06003A9F RID: 15007 RVA: 0x000C09AA File Offset: 0x000BEBAA
		private global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError> Init(global::System.Collections.Generic.IEnumerable<global::System.Xml.XmlReader> xmlReaders, global::System.Collections.Generic.IEnumerable<string> filePaths, bool throwOnError)
		{
			this.Init();
			return global::System.Data.Entity.Core.Metadata.Edm.EdmItemCollection.LoadItems(xmlReaders, filePaths, global::System.Data.Entity.Core.SchemaObjectModel.SchemaDataModelOption.EntityDataModel, global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.EdmProviderManifest, this, throwOnError);
		}

		// Token: 0x17000B4D RID: 2893
		// (get) Token: 0x06003AA0 RID: 15008 RVA: 0x000C09C1 File Offset: 0x000BEBC1
		// (set) Token: 0x06003AA1 RID: 15009 RVA: 0x000C09C9 File Offset: 0x000BEBC9
		public double EdmVersion
		{
			get
			{
				return this._edmVersion;
			}
			internal set
			{
				this._edmVersion = value;
			}
		}

		// Token: 0x17000B4E RID: 2894
		// (get) Token: 0x06003AA2 RID: 15010 RVA: 0x000C09D2 File Offset: 0x000BEBD2
		internal global::System.Data.Entity.Core.Metadata.Edm.OcAssemblyCache ConventionalOcCache
		{
			get
			{
				return this._conventionalOcCache;
			}
		}

		// Token: 0x06003AA3 RID: 15011 RVA: 0x000C09DC File Offset: 0x000BEBDC
		internal global::System.Data.Entity.Core.Objects.ELinq.InitializerMetadata GetCanonicalInitializerMetadata(global::System.Data.Entity.Core.Objects.ELinq.InitializerMetadata metadata)
		{
			if (this._getCanonicalInitializerMetadataMemoizer == null)
			{
				global::System.Threading.Interlocked.CompareExchange<global::System.Data.Entity.Core.Common.Utils.Memoizer<global::System.Data.Entity.Core.Objects.ELinq.InitializerMetadata, global::System.Data.Entity.Core.Objects.ELinq.InitializerMetadata>>(ref this._getCanonicalInitializerMetadataMemoizer, new global::System.Data.Entity.Core.Common.Utils.Memoizer<global::System.Data.Entity.Core.Objects.ELinq.InitializerMetadata, global::System.Data.Entity.Core.Objects.ELinq.InitializerMetadata>((global::System.Data.Entity.Core.Objects.ELinq.InitializerMetadata m) => m, global::System.Collections.Generic.EqualityComparer<global::System.Data.Entity.Core.Objects.ELinq.InitializerMetadata>.Default), null);
			}
			return this._getCanonicalInitializerMetadataMemoizer.Evaluate(metadata);
		}

		// Token: 0x06003AA4 RID: 15012 RVA: 0x000C0A34 File Offset: 0x000BEC34
		internal static bool IsSystemNamespace(global::System.Data.Entity.Core.Common.DbProviderManifest manifest, string namespaceName)
		{
			if (manifest == global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.EdmProviderManifest)
			{
				return namespaceName == "Transient" || namespaceName == "Edm" || namespaceName == "System";
			}
			return namespaceName == "Transient" || namespaceName == "Edm" || namespaceName == "System" || (manifest != null && namespaceName == manifest.NamespaceName);
		}

		// Token: 0x06003AA5 RID: 15013 RVA: 0x000C0AAC File Offset: 0x000BECAC
		internal static global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError> LoadItems(global::System.Collections.Generic.IEnumerable<global::System.Xml.XmlReader> xmlReaders, global::System.Collections.Generic.IEnumerable<string> sourceFilePaths, global::System.Data.Entity.Core.SchemaObjectModel.SchemaDataModelOption dataModelOption, global::System.Data.Entity.Core.Common.DbProviderManifest providerManifest, global::System.Data.Entity.Core.Metadata.Edm.ItemCollection itemCollection, bool throwOnError)
		{
			global::System.Collections.Generic.IList<global::System.Data.Entity.Core.SchemaObjectModel.Schema> somSchemas = null;
			global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError> list = global::System.Data.Entity.Core.SchemaObjectModel.SchemaManager.ParseAndValidate(xmlReaders, sourceFilePaths, dataModelOption, providerManifest, out somSchemas);
			if (global::System.Data.Entity.Core.Common.Utils.MetadataHelper.CheckIfAllErrorsAreWarnings(list))
			{
				foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError item in global::System.Data.Entity.Core.Metadata.Edm.EdmItemCollection.LoadItems(providerManifest, somSchemas, itemCollection))
				{
					list.Add(item);
				}
			}
			if (!global::System.Data.Entity.Core.Common.Utils.MetadataHelper.CheckIfAllErrorsAreWarnings(list) && throwOnError)
			{
				throw global::System.Data.Entity.Core.EntityUtil.InvalidSchemaEncountered(global::System.Data.Entity.Core.Metadata.Edm.Helper.CombineErrorMessage(list));
			}
			return list;
		}

		// Token: 0x06003AA6 RID: 15014 RVA: 0x000C0B34 File Offset: 0x000BED34
		internal static global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError> LoadItems(global::System.Data.Entity.Core.Common.DbProviderManifest manifest, global::System.Collections.Generic.IList<global::System.Data.Entity.Core.SchemaObjectModel.Schema> somSchemas, global::System.Data.Entity.Core.Metadata.Edm.ItemCollection itemCollection)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError>();
			global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.GlobalItem> enumerable = global::System.Data.Entity.Core.Metadata.Edm.EdmItemCollection.LoadSomSchema(somSchemas, manifest, itemCollection);
			global::System.Collections.Generic.List<string> list2 = new global::System.Collections.Generic.List<string>();
			foreach (global::System.Data.Entity.Core.Metadata.Edm.GlobalItem globalItem in enumerable)
			{
				if (globalItem.BuiltInTypeKind == global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EdmFunction && globalItem.DataSpace == global::System.Data.Entity.Core.Metadata.Edm.DataSpace.SSpace)
				{
					global::System.Data.Entity.Core.Metadata.Edm.EdmFunction edmFunction = (global::System.Data.Entity.Core.Metadata.Edm.EdmFunction)globalItem;
					global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
					global::System.Data.Entity.Core.Metadata.Edm.EdmFunction.BuildIdentity<global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter>(stringBuilder, edmFunction.FullName, edmFunction.Parameters, (global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter param) => global::System.Data.Entity.Core.Common.Utils.MetadataHelper.ConvertStoreTypeUsageToEdmTypeUsage(param.TypeUsage), (global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter param) => param.Mode);
					string text = stringBuilder.ToString();
					if (list2.Contains(text))
					{
						list.Add(new global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError(global::System.Data.Entity.Resources.Strings.DuplicatedFunctionoverloads(edmFunction.FullName, text.Substring(edmFunction.FullName.Length)).Trim(), 174, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error));
						continue;
					}
					list2.Add(text);
				}
				globalItem.SetReadOnly();
				itemCollection.AddInternal(globalItem);
			}
			return list;
		}

		// Token: 0x06003AA7 RID: 15015 RVA: 0x000C0C64 File Offset: 0x000BEE64
		internal static global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.GlobalItem> LoadSomSchema(global::System.Collections.Generic.IList<global::System.Data.Entity.Core.SchemaObjectModel.Schema> somSchemas, global::System.Data.Entity.Core.Common.DbProviderManifest providerManifest, global::System.Data.Entity.Core.Metadata.Edm.ItemCollection itemCollection)
		{
			return global::System.Data.Entity.Core.Metadata.Edm.Converter.ConvertSchema(somSchemas, providerManifest, itemCollection);
		}

		// Token: 0x06003AA8 RID: 15016 RVA: 0x000C0C6E File Offset: 0x000BEE6E
		public global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType> GetPrimitiveTypes()
		{
			return this._primitiveTypeMaps.GetTypes();
		}

		// Token: 0x06003AA9 RID: 15017 RVA: 0x000C0C7C File Offset: 0x000BEE7C
		public global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType> GetPrimitiveTypes(double edmVersion)
		{
			if (edmVersion == 1.0 || edmVersion == 1.1 || edmVersion == 2.0)
			{
				return new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType>((from type in this._primitiveTypeMaps.GetTypes()
				where !global::System.Data.Entity.Core.Metadata.Edm.Helper.IsSpatialType(type) && !global::System.Data.Entity.Core.Metadata.Edm.Helper.IsHierarchyIdType(type)
				select type).ToList<global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType>());
			}
			if (edmVersion == 3.0)
			{
				return this._primitiveTypeMaps.GetTypes();
			}
			throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.InvalidEDMVersion(edmVersion.ToString(global::System.Globalization.CultureInfo.CurrentCulture)));
		}

		// Token: 0x06003AAA RID: 15018 RVA: 0x000C0D18 File Offset: 0x000BEF18
		internal override global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType GetMappedPrimitiveType(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind primitiveTypeKind)
		{
			global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType result = null;
			this._primitiveTypeMaps.TryGetType(primitiveTypeKind, null, out result);
			return result;
		}

		// Token: 0x06003AAB RID: 15019 RVA: 0x000C0D38 File Offset: 0x000BEF38
		private void LoadEdmPrimitiveTypesAndFunctions()
		{
			global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifest instance = global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifest.Instance;
			global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType> storeTypes = instance.GetStoreTypes();
			for (int i = 0; i < storeTypes.Count; i++)
			{
				base.AddInternal(storeTypes[i]);
				this._primitiveTypeMaps.Add(storeTypes[i]);
			}
			global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction> storeFunctions = instance.GetStoreFunctions();
			for (int j = 0; j < storeFunctions.Count; j++)
			{
				base.AddInternal(storeFunctions[j]);
			}
		}

		// Token: 0x06003AAC RID: 15020 RVA: 0x000C0DAC File Offset: 0x000BEFAC
		internal global::System.Data.Entity.Core.Common.CommandTrees.DbLambda GetGeneratedFunctionDefinition(global::System.Data.Entity.Core.Metadata.Edm.EdmFunction function)
		{
			if (this._getGeneratedFunctionDefinitionsMemoizer == null)
			{
				global::System.Threading.Interlocked.CompareExchange<global::System.Data.Entity.Core.Common.Utils.Memoizer<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction, global::System.Data.Entity.Core.Common.CommandTrees.DbLambda>>(ref this._getGeneratedFunctionDefinitionsMemoizer, new global::System.Data.Entity.Core.Common.Utils.Memoizer<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction, global::System.Data.Entity.Core.Common.CommandTrees.DbLambda>(new global::System.Func<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction, global::System.Data.Entity.Core.Common.CommandTrees.DbLambda>(this.GenerateFunctionDefinition), null), null);
			}
			return this._getGeneratedFunctionDefinitionsMemoizer.Evaluate(function);
		}

		// Token: 0x06003AAD RID: 15021 RVA: 0x000C0DE4 File Offset: 0x000BEFE4
		internal global::System.Data.Entity.Core.Common.CommandTrees.DbLambda GenerateFunctionDefinition(global::System.Data.Entity.Core.Metadata.Edm.EdmFunction function)
		{
			if (!function.HasUserDefinedBody)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.Cqt_UDF_FunctionHasNoDefinition(function.Identity));
			}
			global::System.Data.Entity.Core.Common.CommandTrees.DbLambda dbLambda = global::System.Data.Entity.Core.Mapping.ViewGeneration.Utils.ExternalCalls.CompileFunctionDefinition(function.CommandTextAttribute, function.Parameters, this);
			if (!global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsStructurallyEqual(function.ReturnParameter.TypeUsage, dbLambda.Body.ResultType))
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.Cqt_UDF_FunctionDefinitionResultTypeMismatch(function.ReturnParameter.TypeUsage.ToString(), function.FullName, dbLambda.Body.ResultType.ToString()));
			}
			return dbLambda;
		}

		// Token: 0x06003AAE RID: 15022 RVA: 0x000C0E6C File Offset: 0x000BF06C
		public static global::System.Data.Entity.Core.Metadata.Edm.EdmItemCollection Create(global::System.Collections.Generic.IEnumerable<global::System.Xml.XmlReader> xmlReaders, global::System.Collections.ObjectModel.ReadOnlyCollection<string> filePaths, out global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError> errors)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Collections.Generic.IEnumerable<global::System.Xml.XmlReader>>(xmlReaders, "xmlReaders");
			global::System.Data.Entity.Core.EntityUtil.CheckArgumentContainsNull<global::System.Xml.XmlReader>(ref xmlReaders, "xmlReaders");
			global::System.Data.Entity.Core.Metadata.Edm.EdmItemCollection result = new global::System.Data.Entity.Core.Metadata.Edm.EdmItemCollection(xmlReaders, filePaths, ref errors);
			if (errors == null || errors.Count <= 0)
			{
				return result;
			}
			return null;
		}

		// Token: 0x04001427 RID: 5159
		private readonly global::System.Data.Entity.Core.Metadata.Edm.CacheForPrimitiveTypes _primitiveTypeMaps = new global::System.Data.Entity.Core.Metadata.Edm.CacheForPrimitiveTypes();

		// Token: 0x04001428 RID: 5160
		private double _edmVersion;

		// Token: 0x04001429 RID: 5161
		private global::System.Data.Entity.Core.Common.Utils.Memoizer<global::System.Data.Entity.Core.Objects.ELinq.InitializerMetadata, global::System.Data.Entity.Core.Objects.ELinq.InitializerMetadata> _getCanonicalInitializerMetadataMemoizer;

		// Token: 0x0400142A RID: 5162
		private global::System.Data.Entity.Core.Common.Utils.Memoizer<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction, global::System.Data.Entity.Core.Common.CommandTrees.DbLambda> _getGeneratedFunctionDefinitionsMemoizer;

		// Token: 0x0400142B RID: 5163
		private readonly global::System.Data.Entity.Core.Metadata.Edm.OcAssemblyCache _conventionalOcCache = new global::System.Data.Entity.Core.Metadata.Edm.OcAssemblyCache();
	}
}
