using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Metadata.Edm.Provider;
using System.Data.Entity.Resources;
using System.Diagnostics;
using System.Linq;
using System.Xml;

namespace System.Data.Entity.Core.SchemaObjectModel
{
	// Token: 0x0200031B RID: 795
	[global::System.Diagnostics.DebuggerDisplay("DataModel={DataModel}")]
	internal class SchemaManager
	{
		// Token: 0x060025CF RID: 9679 RVA: 0x0006AF14 File Offset: 0x00069114
		private SchemaManager(global::System.Data.Entity.Core.SchemaObjectModel.SchemaDataModelOption dataModel, global::System.Data.Entity.Core.SchemaObjectModel.AttributeValueNotification providerNotification, global::System.Data.Entity.Core.SchemaObjectModel.AttributeValueNotification providerManifestTokenNotification, global::System.Data.Entity.Core.SchemaObjectModel.ProviderManifestNeeded providerManifestNeeded)
		{
			this._dataModel = dataModel;
			this._providerNotification = providerNotification;
			this._providerManifestTokenNotification = providerManifestTokenNotification;
			this._providerManifestNeeded = providerManifestNeeded;
		}

		// Token: 0x060025D0 RID: 9680 RVA: 0x0006AF54 File Offset: 0x00069154
		public static global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError> LoadProviderManifest(global::System.Xml.XmlReader xmlReader, string location, bool checkForSystemNamespace, out global::System.Data.Entity.Core.SchemaObjectModel.Schema schema)
		{
			global::System.Collections.Generic.IList<global::System.Data.Entity.Core.SchemaObjectModel.Schema> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.SchemaObjectModel.Schema>(1);
			global::System.Data.Entity.Core.Common.DbProviderManifest providerManifest = checkForSystemNamespace ? global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifest.Instance : null;
			global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError> result = global::System.Data.Entity.Core.SchemaObjectModel.SchemaManager.ParseAndValidate(new global::System.Xml.XmlReader[]
			{
				xmlReader
			}, new string[]
			{
				location
			}, global::System.Data.Entity.Core.SchemaObjectModel.SchemaDataModelOption.ProviderManifestModel, providerManifest, out list);
			if (list.Count != 0)
			{
				schema = list[0];
				return result;
			}
			schema = null;
			return result;
		}

		// Token: 0x060025D1 RID: 9681 RVA: 0x0006AFA6 File Offset: 0x000691A6
		public static void NoOpAttributeValueNotification(string attributeValue, global::System.Action<string, global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity> addError)
		{
		}

		// Token: 0x060025D2 RID: 9682 RVA: 0x0006AFA8 File Offset: 0x000691A8
		public static global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError> ParseAndValidate(global::System.Collections.Generic.IEnumerable<global::System.Xml.XmlReader> xmlReaders, global::System.Collections.Generic.IEnumerable<string> sourceFilePaths, global::System.Data.Entity.Core.SchemaObjectModel.SchemaDataModelOption dataModel, global::System.Data.Entity.Core.Common.DbProviderManifest providerManifest, out global::System.Collections.Generic.IList<global::System.Data.Entity.Core.SchemaObjectModel.Schema> schemaCollection)
		{
			return global::System.Data.Entity.Core.SchemaObjectModel.SchemaManager.ParseAndValidate(xmlReaders, sourceFilePaths, dataModel, new global::System.Data.Entity.Core.SchemaObjectModel.AttributeValueNotification(global::System.Data.Entity.Core.SchemaObjectModel.SchemaManager.NoOpAttributeValueNotification), new global::System.Data.Entity.Core.SchemaObjectModel.AttributeValueNotification(global::System.Data.Entity.Core.SchemaObjectModel.SchemaManager.NoOpAttributeValueNotification), (global::System.Action<string, global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity> error) => providerManifest ?? global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.EdmProviderManifest, out schemaCollection);
		}

		// Token: 0x060025D3 RID: 9683 RVA: 0x0006AFF0 File Offset: 0x000691F0
		public static global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError> ParseAndValidate(global::System.Collections.Generic.IEnumerable<global::System.Xml.XmlReader> xmlReaders, global::System.Collections.Generic.IEnumerable<string> sourceFilePaths, global::System.Data.Entity.Core.SchemaObjectModel.SchemaDataModelOption dataModel, global::System.Data.Entity.Core.SchemaObjectModel.AttributeValueNotification providerNotification, global::System.Data.Entity.Core.SchemaObjectModel.AttributeValueNotification providerManifestTokenNotification, global::System.Data.Entity.Core.SchemaObjectModel.ProviderManifestNeeded providerManifestNeeded, out global::System.Collections.Generic.IList<global::System.Data.Entity.Core.SchemaObjectModel.Schema> schemaCollection)
		{
			global::System.Data.Entity.Core.SchemaObjectModel.SchemaManager schemaManager = new global::System.Data.Entity.Core.SchemaObjectModel.SchemaManager(dataModel, providerNotification, providerManifestTokenNotification, providerManifestNeeded);
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError>();
			schemaCollection = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.SchemaObjectModel.Schema>();
			bool flag = false;
			global::System.Collections.Generic.List<string> list2;
			if (sourceFilePaths != null)
			{
				list2 = new global::System.Collections.Generic.List<string>(sourceFilePaths);
			}
			else
			{
				list2 = new global::System.Collections.Generic.List<string>();
			}
			int num = 0;
			foreach (global::System.Xml.XmlReader xmlReader in xmlReaders)
			{
				string sourceLocation = null;
				if (list2.Count <= num)
				{
					global::System.Data.Entity.Core.SchemaObjectModel.SchemaManager.TryGetBaseUri(xmlReader, out sourceLocation);
				}
				else
				{
					sourceLocation = list2[num];
				}
				global::System.Data.Entity.Core.SchemaObjectModel.Schema schema = new global::System.Data.Entity.Core.SchemaObjectModel.Schema(schemaManager);
				global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError> newErrors = schema.Parse(xmlReader, sourceLocation);
				global::System.Data.Entity.Core.SchemaObjectModel.SchemaManager.CheckIsSameVersion(schema, schemaCollection, list);
				if (global::System.Data.Entity.Core.SchemaObjectModel.SchemaManager.UpdateErrorCollectionAndCheckForMaxErrors(list, newErrors, ref flag))
				{
					return list;
				}
				if (!flag)
				{
					schemaCollection.Add(schema);
					schemaManager.AddSchema(schema);
				}
				num++;
			}
			if (!flag)
			{
				foreach (global::System.Data.Entity.Core.SchemaObjectModel.Schema schema2 in schemaCollection)
				{
					if (global::System.Data.Entity.Core.SchemaObjectModel.SchemaManager.UpdateErrorCollectionAndCheckForMaxErrors(list, schema2.Resolve(), ref flag))
					{
						return list;
					}
				}
				if (!flag)
				{
					foreach (global::System.Data.Entity.Core.SchemaObjectModel.Schema schema3 in schemaCollection)
					{
						if (global::System.Data.Entity.Core.SchemaObjectModel.SchemaManager.UpdateErrorCollectionAndCheckForMaxErrors(list, schema3.ValidateSchema(), ref flag))
						{
							return list;
						}
					}
				}
			}
			return list;
		}

		// Token: 0x060025D4 RID: 9684 RVA: 0x0006B188 File Offset: 0x00069388
		internal static bool TryGetSchemaVersion(global::System.Xml.XmlReader reader, out double version, out global::System.Data.Entity.Core.Metadata.Edm.DataSpace dataSpace)
		{
			if (!reader.EOF && reader.NodeType != global::System.Xml.XmlNodeType.Element)
			{
				while (reader.Read() && reader.NodeType != global::System.Xml.XmlNodeType.Element)
				{
				}
			}
			if (!reader.EOF && (reader.LocalName == "Schema" || reader.LocalName == "Mapping"))
			{
				return global::System.Data.Entity.Core.SchemaObjectModel.SchemaManager.TryGetSchemaVersion(reader.NamespaceURI, out version, out dataSpace);
			}
			version = 0.0;
			dataSpace = global::System.Data.Entity.Core.Metadata.Edm.DataSpace.OSpace;
			return false;
		}

		// Token: 0x060025D5 RID: 9685 RVA: 0x0006B200 File Offset: 0x00069400
		internal static bool TryGetSchemaVersion(string xmlNamespaceName, out double version, out global::System.Data.Entity.Core.Metadata.Edm.DataSpace dataSpace)
		{
			if (xmlNamespaceName != null)
			{
				uint num = global::<PrivateImplementationDetails>.ComputeStringHash(xmlNamespaceName);
				if (num <= 2737002321U)
				{
					if (num <= 276889131U)
					{
						if (num != 54480152U)
						{
							if (num == 276889131U)
							{
								if (xmlNamespaceName == "http://schemas.microsoft.com/ado/2006/04/edm/ssdl")
								{
									version = 1.0;
									dataSpace = global::System.Data.Entity.Core.Metadata.Edm.DataSpace.SSpace;
									return true;
								}
							}
						}
						else if (xmlNamespaceName == "http://schemas.microsoft.com/ado/2009/11/edm/ssdl")
						{
							version = 3.0;
							dataSpace = global::System.Data.Entity.Core.Metadata.Edm.DataSpace.SSpace;
							return true;
						}
					}
					else if (num != 334451066U)
					{
						if (num != 1932155917U)
						{
							if (num == 2737002321U)
							{
								if (xmlNamespaceName == "http://schemas.microsoft.com/ado/2009/11/edm")
								{
									version = 3.0;
									dataSpace = global::System.Data.Entity.Core.Metadata.Edm.DataSpace.CSpace;
									return true;
								}
							}
						}
						else if (xmlNamespaceName == "urn:schemas-microsoft-com:windows:storage:mapping:CS")
						{
							version = 1.0;
							dataSpace = global::System.Data.Entity.Core.Metadata.Edm.DataSpace.CSSpace;
							return true;
						}
					}
					else if (xmlNamespaceName == "http://schemas.microsoft.com/ado/2008/09/mapping/cs")
					{
						version = 2.0;
						dataSpace = global::System.Data.Entity.Core.Metadata.Edm.DataSpace.CSSpace;
						return true;
					}
				}
				else if (num <= 2886803144U)
				{
					if (num != 2826911950U)
					{
						if (num == 2886803144U)
						{
							if (xmlNamespaceName == "http://schemas.microsoft.com/ado/2006/04/edm")
							{
								version = 1.0;
								dataSpace = global::System.Data.Entity.Core.Metadata.Edm.DataSpace.CSpace;
								return true;
							}
						}
					}
					else if (xmlNamespaceName == "http://schemas.microsoft.com/ado/2007/05/edm")
					{
						version = 1.1;
						dataSpace = global::System.Data.Entity.Core.Metadata.Edm.DataSpace.CSpace;
						return true;
					}
				}
				else if (num != 3075483009U)
				{
					if (num != 3250650152U)
					{
						if (num == 4049421514U)
						{
							if (xmlNamespaceName == "http://schemas.microsoft.com/ado/2009/11/mapping/cs")
							{
								version = 3.0;
								dataSpace = global::System.Data.Entity.Core.Metadata.Edm.DataSpace.CSSpace;
								return true;
							}
						}
					}
					else if (xmlNamespaceName == "http://schemas.microsoft.com/ado/2009/02/edm/ssdl")
					{
						version = 2.0;
						dataSpace = global::System.Data.Entity.Core.Metadata.Edm.DataSpace.SSpace;
						return true;
					}
				}
				else if (xmlNamespaceName == "http://schemas.microsoft.com/ado/2008/09/edm")
				{
					version = 2.0;
					dataSpace = global::System.Data.Entity.Core.Metadata.Edm.DataSpace.CSpace;
					return true;
				}
			}
			version = 0.0;
			dataSpace = global::System.Data.Entity.Core.Metadata.Edm.DataSpace.OSpace;
			return false;
		}

		// Token: 0x060025D6 RID: 9686 RVA: 0x0006B42C File Offset: 0x0006962C
		private static bool CheckIsSameVersion(global::System.Data.Entity.Core.SchemaObjectModel.Schema schemaToBeAdded, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.SchemaObjectModel.Schema> schemaCollection, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError> errorCollection)
		{
			if (schemaToBeAdded.SchemaVersion != 0.0 && schemaCollection.Count<global::System.Data.Entity.Core.SchemaObjectModel.Schema>() > 0 && schemaCollection.Any((global::System.Data.Entity.Core.SchemaObjectModel.Schema s) => s.SchemaVersion != 0.0 && s.SchemaVersion != schemaToBeAdded.SchemaVersion))
			{
				errorCollection.Add(new global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError(global::System.Data.Entity.Resources.Strings.CannotLoadDifferentVersionOfSchemaInTheSameItemCollection, 194, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error));
			}
			return true;
		}

		// Token: 0x17000804 RID: 2052
		// (get) Token: 0x060025D7 RID: 9687 RVA: 0x0006B490 File Offset: 0x00069690
		public double SchemaVersion
		{
			get
			{
				return this.effectiveSchemaVersion;
			}
		}

		// Token: 0x060025D8 RID: 9688 RVA: 0x0006B498 File Offset: 0x00069698
		public void AddSchema(global::System.Data.Entity.Core.SchemaObjectModel.Schema schema)
		{
			if (this._namespaceLookUpTable.Count == 0 && schema.DataModel != global::System.Data.Entity.Core.SchemaObjectModel.SchemaDataModelOption.ProviderManifestModel && this.PrimitiveSchema.Namespace != null)
			{
				this._namespaceLookUpTable.Add(this.PrimitiveSchema.Namespace);
			}
			this._namespaceLookUpTable.Add(schema.Namespace);
		}

		// Token: 0x060025D9 RID: 9689 RVA: 0x0006B4F4 File Offset: 0x000696F4
		public bool TryResolveType(string namespaceName, string typeName, out global::System.Data.Entity.Core.SchemaObjectModel.SchemaType schemaType)
		{
			string key = string.IsNullOrEmpty(namespaceName) ? typeName : (namespaceName + "." + typeName);
			schemaType = this.SchemaTypes.LookUpEquivalentKey(key);
			return schemaType != null;
		}

		// Token: 0x060025DA RID: 9690 RVA: 0x0006B52E File Offset: 0x0006972E
		public bool IsValidNamespaceName(string namespaceName)
		{
			return this._namespaceLookUpTable.Contains(namespaceName);
		}

		// Token: 0x060025DB RID: 9691 RVA: 0x0006B53C File Offset: 0x0006973C
		internal static bool TryGetBaseUri(global::System.Xml.XmlReader xmlReader, out string location)
		{
			string baseURI = xmlReader.BaseURI;
			global::System.Uri uri = null;
			if (!string.IsNullOrEmpty(baseURI) && global::System.Uri.TryCreate(baseURI, global::System.UriKind.Absolute, out uri) && uri.Scheme == "file")
			{
				location = global::System.Data.Entity.Core.Metadata.Edm.Helper.GetFileNameFromUri(uri);
				return true;
			}
			location = null;
			return false;
		}

		// Token: 0x060025DC RID: 9692 RVA: 0x0006B588 File Offset: 0x00069788
		private static bool UpdateErrorCollectionAndCheckForMaxErrors(global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError> errorCollection, global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError> newErrors, ref bool errorEncountered)
		{
			if (!errorEncountered && !global::System.Data.Entity.Core.Common.Utils.MetadataHelper.CheckIfAllErrorsAreWarnings(newErrors))
			{
				errorEncountered = true;
			}
			errorCollection.AddRange(newErrors);
			if (errorEncountered)
			{
				if ((from e in errorCollection
				where e.Severity == global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error
				select e).Count<global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError>() > 100)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x17000805 RID: 2053
		// (get) Token: 0x060025DD RID: 9693 RVA: 0x0006B5E0 File Offset: 0x000697E0
		internal global::System.Data.Entity.Core.SchemaObjectModel.SchemaElementLookUpTable<global::System.Data.Entity.Core.SchemaObjectModel.SchemaType> SchemaTypes
		{
			get
			{
				return this._schemaTypes;
			}
		}

		// Token: 0x060025DE RID: 9694 RVA: 0x0006B5E8 File Offset: 0x000697E8
		internal global::System.Data.Entity.Core.Common.DbProviderManifest GetProviderManifest(global::System.Action<string, global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity> addError)
		{
			if (this._providerManifest == null)
			{
				this._providerManifest = this._providerManifestNeeded(addError);
			}
			return this._providerManifest;
		}

		// Token: 0x17000806 RID: 2054
		// (get) Token: 0x060025DF RID: 9695 RVA: 0x0006B60A File Offset: 0x0006980A
		internal global::System.Data.Entity.Core.SchemaObjectModel.SchemaDataModelOption DataModel
		{
			get
			{
				return this._dataModel;
			}
		}

		// Token: 0x060025E0 RID: 9696 RVA: 0x0006B612 File Offset: 0x00069812
		internal void EnsurePrimitiveSchemaIsLoaded(double forSchemaVersion)
		{
			if (this._primitiveSchema == null)
			{
				this.effectiveSchemaVersion = forSchemaVersion;
				this._primitiveSchema = new global::System.Data.Entity.Core.SchemaObjectModel.PrimitiveSchema(this);
			}
		}

		// Token: 0x17000807 RID: 2055
		// (get) Token: 0x060025E1 RID: 9697 RVA: 0x0006B62F File Offset: 0x0006982F
		internal global::System.Data.Entity.Core.SchemaObjectModel.PrimitiveSchema PrimitiveSchema
		{
			get
			{
				return this._primitiveSchema;
			}
		}

		// Token: 0x17000808 RID: 2056
		// (get) Token: 0x060025E2 RID: 9698 RVA: 0x0006B637 File Offset: 0x00069837
		internal global::System.Data.Entity.Core.SchemaObjectModel.AttributeValueNotification ProviderNotification
		{
			get
			{
				return this._providerNotification;
			}
		}

		// Token: 0x17000809 RID: 2057
		// (get) Token: 0x060025E3 RID: 9699 RVA: 0x0006B63F File Offset: 0x0006983F
		internal global::System.Data.Entity.Core.SchemaObjectModel.AttributeValueNotification ProviderManifestTokenNotification
		{
			get
			{
				return this._providerManifestTokenNotification;
			}
		}

		// Token: 0x04000D49 RID: 3401
		private readonly global::System.Collections.Generic.HashSet<string> _namespaceLookUpTable = new global::System.Collections.Generic.HashSet<string>(global::System.StringComparer.Ordinal);

		// Token: 0x04000D4A RID: 3402
		private readonly global::System.Data.Entity.Core.SchemaObjectModel.SchemaElementLookUpTable<global::System.Data.Entity.Core.SchemaObjectModel.SchemaType> _schemaTypes = new global::System.Data.Entity.Core.SchemaObjectModel.SchemaElementLookUpTable<global::System.Data.Entity.Core.SchemaObjectModel.SchemaType>();

		// Token: 0x04000D4B RID: 3403
		private const int MaxErrorCount = 100;

		// Token: 0x04000D4C RID: 3404
		private global::System.Data.Entity.Core.Common.DbProviderManifest _providerManifest;

		// Token: 0x04000D4D RID: 3405
		private global::System.Data.Entity.Core.SchemaObjectModel.PrimitiveSchema _primitiveSchema;

		// Token: 0x04000D4E RID: 3406
		private double effectiveSchemaVersion;

		// Token: 0x04000D4F RID: 3407
		private readonly global::System.Data.Entity.Core.SchemaObjectModel.SchemaDataModelOption _dataModel;

		// Token: 0x04000D50 RID: 3408
		private readonly global::System.Data.Entity.Core.SchemaObjectModel.ProviderManifestNeeded _providerManifestNeeded;

		// Token: 0x04000D51 RID: 3409
		private readonly global::System.Data.Entity.Core.SchemaObjectModel.AttributeValueNotification _providerNotification;

		// Token: 0x04000D52 RID: 3410
		private readonly global::System.Data.Entity.Core.SchemaObjectModel.AttributeValueNotification _providerManifestTokenNotification;
	}
}
