using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.SchemaObjectModel;
using System.Data.Entity.Resources;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Xml;
using System.Xml.Schema;
using System.Xml.XPath;

namespace System.Data.Entity.Core.Mapping
{
	// Token: 0x0200054B RID: 1355
	internal class MappingItemLoader
	{
		// Token: 0x0600425D RID: 16989 RVA: 0x000E01A0 File Offset: 0x000DE3A0
		internal MappingItemLoader(global::System.Xml.XmlReader reader, global::System.Data.Entity.Core.Mapping.StorageMappingItemCollection storageMappingItemCollection, string fileName, global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EdmMember, global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>> scalarMemberMappings)
		{
			this.m_storageMappingItemCollection = storageMappingItemCollection;
			this.m_alias = new global::System.Collections.Generic.Dictionary<string, string>(global::System.StringComparer.Ordinal);
			if (fileName != null)
			{
				this.m_sourceLocation = fileName;
			}
			else
			{
				this.m_sourceLocation = null;
			}
			this.m_parsingErrors = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError>();
			this.m_scalarMemberMappings = scalarMemberMappings;
			this.m_containerMapping = this.LoadMappingItems(reader);
			if (this.m_currentNamespaceUri != null)
			{
				if (this.m_currentNamespaceUri == "urn:schemas-microsoft-com:windows:storage:mapping:CS")
				{
					this.m_version = 1.0;
					return;
				}
				if (this.m_currentNamespaceUri == "http://schemas.microsoft.com/ado/2008/09/mapping/cs")
				{
					this.m_version = 2.0;
					return;
				}
				this.m_version = 3.0;
			}
		}

		// Token: 0x17000D2E RID: 3374
		// (get) Token: 0x0600425E RID: 16990 RVA: 0x000E0258 File Offset: 0x000DE458
		internal double MappingVersion
		{
			get
			{
				return this.m_version;
			}
		}

		// Token: 0x17000D2F RID: 3375
		// (get) Token: 0x0600425F RID: 16991 RVA: 0x000E0260 File Offset: 0x000DE460
		internal global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError> ParsingErrors
		{
			get
			{
				return this.m_parsingErrors;
			}
		}

		// Token: 0x17000D30 RID: 3376
		// (get) Token: 0x06004260 RID: 16992 RVA: 0x000E0268 File Offset: 0x000DE468
		internal bool HasQueryViews
		{
			get
			{
				return this.m_hasQueryViews;
			}
		}

		// Token: 0x17000D31 RID: 3377
		// (get) Token: 0x06004261 RID: 16993 RVA: 0x000E0270 File Offset: 0x000DE470
		internal global::System.Data.Entity.Core.Mapping.EntityContainerMapping ContainerMapping
		{
			get
			{
				return this.m_containerMapping;
			}
		}

		// Token: 0x17000D32 RID: 3378
		// (get) Token: 0x06004262 RID: 16994 RVA: 0x000E0278 File Offset: 0x000DE478
		private global::System.Data.Entity.Core.Metadata.Edm.EdmItemCollection EdmItemCollection
		{
			get
			{
				return this.m_storageMappingItemCollection.EdmItemCollection;
			}
		}

		// Token: 0x17000D33 RID: 3379
		// (get) Token: 0x06004263 RID: 16995 RVA: 0x000E0285 File Offset: 0x000DE485
		private global::System.Data.Entity.Core.Metadata.Edm.StoreItemCollection StoreItemCollection
		{
			get
			{
				return this.m_storageMappingItemCollection.StoreItemCollection;
			}
		}

		// Token: 0x06004264 RID: 16996 RVA: 0x000E0294 File Offset: 0x000DE494
		private global::System.Data.Entity.Core.Mapping.EntityContainerMapping LoadMappingItems(global::System.Xml.XmlReader innerReader)
		{
			global::System.Xml.XmlReader schemaValidatingReader = this.GetSchemaValidatingReader(innerReader);
			try
			{
				global::System.Xml.XPath.XPathDocument xpathDocument = new global::System.Xml.XPath.XPathDocument(schemaValidatingReader);
				if (this.m_parsingErrors.Count != 0 && !global::System.Data.Entity.Core.Common.Utils.MetadataHelper.CheckIfAllErrorsAreWarnings(this.m_parsingErrors))
				{
					return null;
				}
				global::System.Xml.XPath.XPathNavigator xpathNavigator = xpathDocument.CreateNavigator();
				return this.LoadMappingItems(xpathNavigator.Clone());
			}
			catch (global::System.Xml.XmlException ex)
			{
				global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError item = new global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError(global::System.Data.Entity.Resources.Strings.Mapping_InvalidMappingSchema_Parsing(ex.Message), 2024, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, this.m_sourceLocation, ex.LineNumber, ex.LinePosition);
				this.m_parsingErrors.Add(item);
			}
			return null;
		}

		// Token: 0x06004265 RID: 16997 RVA: 0x000E0338 File Offset: 0x000DE538
		private global::System.Data.Entity.Core.Mapping.EntityContainerMapping LoadMappingItems(global::System.Xml.XPath.XPathNavigator nav)
		{
			if (!this.MoveToRootElement(nav) || nav.NodeType != global::System.Xml.XPath.XPathNodeType.Element)
			{
				global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrors(global::System.Data.Entity.Resources.Strings.Mapping_Invalid_CSRootElementMissing("urn:schemas-microsoft-com:windows:storage:mapping:CS", "http://schemas.microsoft.com/ado/2008/09/mapping/cs", "http://schemas.microsoft.com/ado/2009/11/mapping/cs"), global::System.Data.Entity.Core.Mapping.MappingErrorCode.RootMappingElementMissing, this.m_sourceLocation, (global::System.Xml.IXmlLineInfo)nav, this.m_parsingErrors);
				return null;
			}
			global::System.Data.Entity.Core.Mapping.EntityContainerMapping result = this.LoadMappingChildNodes(nav.Clone());
			if (this.m_parsingErrors.Count != 0 && !global::System.Data.Entity.Core.Common.Utils.MetadataHelper.CheckIfAllErrorsAreWarnings(this.m_parsingErrors))
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06004266 RID: 16998 RVA: 0x000E03B4 File Offset: 0x000DE5B4
		private bool MoveToRootElement(global::System.Xml.XPath.XPathNavigator nav)
		{
			if (nav.MoveToChild("Mapping", "http://schemas.microsoft.com/ado/2009/11/mapping/cs"))
			{
				this.m_currentNamespaceUri = "http://schemas.microsoft.com/ado/2009/11/mapping/cs";
				return true;
			}
			if (nav.MoveToChild("Mapping", "http://schemas.microsoft.com/ado/2008/09/mapping/cs"))
			{
				this.m_currentNamespaceUri = "http://schemas.microsoft.com/ado/2008/09/mapping/cs";
				return true;
			}
			if (nav.MoveToChild("Mapping", "urn:schemas-microsoft-com:windows:storage:mapping:CS"))
			{
				this.m_currentNamespaceUri = "urn:schemas-microsoft-com:windows:storage:mapping:CS";
				return true;
			}
			return false;
		}

		// Token: 0x06004267 RID: 16999 RVA: 0x000E0420 File Offset: 0x000DE620
		private global::System.Data.Entity.Core.Mapping.EntityContainerMapping LoadMappingChildNodes(global::System.Xml.XPath.XPathNavigator nav)
		{
			bool flag;
			if (nav.MoveToChild("Alias", this.m_currentNamespaceUri))
			{
				do
				{
					this.m_alias.Add(global::System.Data.Entity.Core.Mapping.MappingItemLoader.GetAttributeValue(nav.Clone(), "Key"), global::System.Data.Entity.Core.Mapping.MappingItemLoader.GetAttributeValue(nav.Clone(), "Value"));
				}
				while (nav.MoveToNext("Alias", this.m_currentNamespaceUri));
				flag = nav.MoveToNext(global::System.Xml.XPath.XPathNodeType.Element);
			}
			else
			{
				flag = nav.MoveToChild(global::System.Xml.XPath.XPathNodeType.Element);
			}
			if (!flag)
			{
				return null;
			}
			return this.LoadEntityContainerMapping(nav.Clone());
		}

		// Token: 0x06004268 RID: 17000 RVA: 0x000E04A4 File Offset: 0x000DE6A4
		private global::System.Data.Entity.Core.Mapping.EntityContainerMapping LoadEntityContainerMapping(global::System.Xml.XPath.XPathNavigator nav)
		{
			global::System.Xml.IXmlLineInfo xmlLineInfo = (global::System.Xml.IXmlLineInfo)nav;
			string attributeValue = global::System.Data.Entity.Core.Mapping.MappingItemLoader.GetAttributeValue(nav.Clone(), "CdmEntityContainer");
			string attributeValue2 = global::System.Data.Entity.Core.Mapping.MappingItemLoader.GetAttributeValue(nav.Clone(), "StorageEntityContainer");
			bool boolAttributeValue = global::System.Data.Entity.Core.Mapping.MappingItemLoader.GetBoolAttributeValue(nav.Clone(), "GenerateUpdateViews", true);
			global::System.Data.Entity.Core.Mapping.EntityContainerMapping entityContainerMapping;
			global::System.Data.Entity.Core.Metadata.Edm.EntityContainer storageEntityContainer;
			if (this.m_storageMappingItemCollection.TryGetItem<global::System.Data.Entity.Core.Mapping.EntityContainerMapping>(attributeValue, out entityContainerMapping))
			{
				global::System.Data.Entity.Core.Metadata.Edm.EntityContainer edmEntityContainer = entityContainerMapping.EdmEntityContainer;
				storageEntityContainer = entityContainerMapping.StorageEntityContainer;
				if (attributeValue2 != storageEntityContainer.Name)
				{
					global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrors(global::System.Data.Entity.Resources.Strings.StorageEntityContainerNameMismatchWhileSpecifyingPartialMapping(attributeValue2, storageEntityContainer.Name, edmEntityContainer.Name), global::System.Data.Entity.Core.Mapping.MappingErrorCode.StorageEntityContainerNameMismatchWhileSpecifyingPartialMapping, this.m_sourceLocation, xmlLineInfo, this.m_parsingErrors);
					return null;
				}
			}
			else
			{
				if (this.m_storageMappingItemCollection.ContainsStorageEntityContainer(attributeValue2))
				{
					global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrorsWithMemberInfo(new global::System.Func<object, string>(global::System.Data.Entity.Resources.Strings.Mapping_AlreadyMapped_StorageEntityContainer), attributeValue2, global::System.Data.Entity.Core.Mapping.MappingErrorCode.AlreadyMappedStorageEntityContainer, this.m_sourceLocation, xmlLineInfo, this.m_parsingErrors);
					return null;
				}
				global::System.Data.Entity.Core.Metadata.Edm.EntityContainer edmEntityContainer;
				this.EdmItemCollection.TryGetEntityContainer(attributeValue, out edmEntityContainer);
				if (edmEntityContainer == null)
				{
					global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrorsWithMemberInfo(new global::System.Func<object, string>(global::System.Data.Entity.Resources.Strings.Mapping_InvalidContent_EntityContainer), attributeValue, global::System.Data.Entity.Core.Mapping.MappingErrorCode.InvalidEntityContainer, this.m_sourceLocation, xmlLineInfo, this.m_parsingErrors);
				}
				this.StoreItemCollection.TryGetEntityContainer(attributeValue2, out storageEntityContainer);
				if (storageEntityContainer == null)
				{
					global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrorsWithMemberInfo(new global::System.Func<object, string>(global::System.Data.Entity.Resources.Strings.Mapping_InvalidContent_StorageEntityContainer), attributeValue2, global::System.Data.Entity.Core.Mapping.MappingErrorCode.InvalidEntityContainer, this.m_sourceLocation, xmlLineInfo, this.m_parsingErrors);
				}
				if (edmEntityContainer == null || storageEntityContainer == null)
				{
					return null;
				}
				entityContainerMapping = new global::System.Data.Entity.Core.Mapping.EntityContainerMapping(edmEntityContainer, storageEntityContainer, this.m_storageMappingItemCollection, boolAttributeValue, boolAttributeValue);
				entityContainerMapping.StartLineNumber = xmlLineInfo.LineNumber;
				entityContainerMapping.StartLinePosition = xmlLineInfo.LinePosition;
			}
			this.LoadEntityContainerMappingChildNodes(nav.Clone(), entityContainerMapping, storageEntityContainer);
			return entityContainerMapping;
		}

		// Token: 0x06004269 RID: 17001 RVA: 0x000E063C File Offset: 0x000DE83C
		private void LoadEntityContainerMappingChildNodes(global::System.Xml.XPath.XPathNavigator nav, global::System.Data.Entity.Core.Mapping.EntityContainerMapping entityContainerMapping, global::System.Data.Entity.Core.Metadata.Edm.EntityContainer storageEntityContainerType)
		{
			global::System.Xml.IXmlLineInfo lineInfo = (global::System.Xml.IXmlLineInfo)nav;
			bool flag = false;
			if (nav.MoveToChild(global::System.Xml.XPath.XPathNodeType.Element))
			{
				for (;;)
				{
					string localName = nav.LocalName;
					if (localName == null)
					{
						goto IL_79;
					}
					if (!(localName == "EntitySetMapping"))
					{
						if (!(localName == "AssociationSetMapping"))
						{
							if (!(localName == "FunctionImportMapping"))
							{
								goto IL_79;
							}
							this.LoadFunctionImportMapping(nav.Clone(), entityContainerMapping);
						}
						else
						{
							this.LoadAssociationSetMapping(nav.Clone(), entityContainerMapping, storageEntityContainerType);
						}
					}
					else
					{
						this.LoadEntitySetMapping(nav.Clone(), entityContainerMapping, storageEntityContainerType);
						flag = true;
					}
					IL_95:
					if (!nav.MoveToNext(global::System.Xml.XPath.XPathNodeType.Element))
					{
						break;
					}
					continue;
					IL_79:
					global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrors(global::System.Data.Entity.Resources.Strings.Mapping_InvalidContent_Container_SubElement, global::System.Data.Entity.Core.Mapping.MappingErrorCode.SetMappingExpected, this.m_sourceLocation, lineInfo, this.m_parsingErrors);
					goto IL_95;
				}
			}
			if (entityContainerMapping.EdmEntityContainer.BaseEntitySets.Count != 0 && !flag)
			{
				global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrorsWithMemberInfo(new global::System.Func<object, string>(global::System.Data.Entity.Resources.Strings.ViewGen_Missing_Sets_Mapping), entityContainerMapping.EdmEntityContainer.Name, global::System.Data.Entity.Core.Mapping.MappingErrorCode.EmptyContainerMapping, this.m_sourceLocation, lineInfo, this.m_parsingErrors);
				return;
			}
			this.ValidateFunctionAssociationFunctionMappingUnique(nav.Clone(), entityContainerMapping);
			this.ValidateModificationFunctionMappingConsistentForAssociations(nav.Clone(), entityContainerMapping);
			this.ValidateQueryViewsClosure(nav.Clone(), entityContainerMapping);
			this.ValidateEntitySetFunctionMappingClosure(nav.Clone(), entityContainerMapping);
			entityContainerMapping.SourceLocation = this.m_sourceLocation;
		}

		// Token: 0x0600426A RID: 17002 RVA: 0x000E0770 File Offset: 0x000DE970
		private void ValidateModificationFunctionMappingConsistentForAssociations(global::System.Xml.XPath.XPathNavigator nav, global::System.Data.Entity.Core.Mapping.EntityContainerMapping entityContainerMapping)
		{
			foreach (global::System.Data.Entity.Core.Mapping.EntitySetBaseMapping entitySetBaseMapping in entityContainerMapping.EntitySetMaps)
			{
				global::System.Data.Entity.Core.Mapping.EntitySetMapping entitySetMapping = (global::System.Data.Entity.Core.Mapping.EntitySetMapping)entitySetBaseMapping;
				if (entitySetMapping.ModificationFunctionMappings.Count > 0)
				{
					global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.AssociationSetEnd> expectedEnds = new global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.AssociationSetEnd>(entitySetMapping.ImplicitlyMappedAssociationSetEnds).MakeReadOnly();
					foreach (global::System.Data.Entity.Core.Mapping.EntityTypeModificationFunctionMapping entityTypeModificationFunctionMapping in entitySetMapping.ModificationFunctionMappings)
					{
						if (entityTypeModificationFunctionMapping.DeleteFunctionMapping != null)
						{
							this.ValidateModificationFunctionMappingConsistentForAssociations(nav, entitySetMapping, entityTypeModificationFunctionMapping, entityTypeModificationFunctionMapping.DeleteFunctionMapping, expectedEnds, "DeleteFunction");
						}
						if (entityTypeModificationFunctionMapping.InsertFunctionMapping != null)
						{
							this.ValidateModificationFunctionMappingConsistentForAssociations(nav, entitySetMapping, entityTypeModificationFunctionMapping, entityTypeModificationFunctionMapping.InsertFunctionMapping, expectedEnds, "InsertFunction");
						}
						if (entityTypeModificationFunctionMapping.UpdateFunctionMapping != null)
						{
							this.ValidateModificationFunctionMappingConsistentForAssociations(nav, entitySetMapping, entityTypeModificationFunctionMapping, entityTypeModificationFunctionMapping.UpdateFunctionMapping, expectedEnds, "UpdateFunction");
						}
					}
				}
			}
		}

		// Token: 0x0600426B RID: 17003 RVA: 0x000E087C File Offset: 0x000DEA7C
		private void ValidateModificationFunctionMappingConsistentForAssociations(global::System.Xml.XPath.XPathNavigator nav, global::System.Data.Entity.Core.Mapping.EntitySetMapping entitySetMapping, global::System.Data.Entity.Core.Mapping.EntityTypeModificationFunctionMapping entityTypeMapping, global::System.Data.Entity.Core.Mapping.ModificationFunctionMapping functionMapping, global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.AssociationSetEnd> expectedEnds, string elementName)
		{
			global::System.Xml.IXmlLineInfo lineInfo = (global::System.Xml.IXmlLineInfo)nav;
			global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.AssociationSetEnd> set = new global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.AssociationSetEnd>(functionMapping.CollocatedAssociationSetEnds);
			set.MakeReadOnly();
			foreach (global::System.Data.Entity.Core.Metadata.Edm.AssociationSetEnd associationSetEnd in expectedEnds)
			{
				if (global::System.Data.Entity.Core.Common.Utils.MetadataHelper.IsAssociationValidForEntityType(associationSetEnd, entityTypeMapping.EntityType) && !set.Contains(associationSetEnd))
				{
					global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrorWithMessage(global::System.Data.Entity.Resources.Strings.Mapping_ModificationFunction_AssociationSetNotMappedForOperation(entitySetMapping.Set.Name, associationSetEnd.ParentAssociationSet.Name, elementName, entityTypeMapping.EntityType.FullName), global::System.Data.Entity.Core.Mapping.MappingErrorCode.InvalidModificationFunctionMappingAssociationSetNotMappedForOperation, this.m_sourceLocation, lineInfo, this.m_parsingErrors);
				}
			}
			foreach (global::System.Data.Entity.Core.Metadata.Edm.AssociationSetEnd associationSetEnd2 in set)
			{
				if (!global::System.Data.Entity.Core.Common.Utils.MetadataHelper.IsAssociationValidForEntityType(associationSetEnd2, entityTypeMapping.EntityType))
				{
					global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrorWithMessage(global::System.Data.Entity.Resources.Strings.Mapping_ModificationFunction_AssociationEndMappingInvalidForEntityType(entityTypeMapping.EntityType.FullName, associationSetEnd2.ParentAssociationSet.Name, global::System.Data.Entity.Core.Common.Utils.MetadataHelper.GetEntityTypeForEnd(global::System.Data.Entity.Core.Common.Utils.MetadataHelper.GetOppositeEnd(associationSetEnd2).CorrespondingAssociationEndMember).FullName), global::System.Data.Entity.Core.Mapping.MappingErrorCode.InvalidModificationFunctionMappingAssociationEndMappingInvalidForEntityType, this.m_sourceLocation, lineInfo, this.m_parsingErrors);
				}
			}
		}

		// Token: 0x0600426C RID: 17004 RVA: 0x000E09C4 File Offset: 0x000DEBC4
		private void ValidateFunctionAssociationFunctionMappingUnique(global::System.Xml.XPath.XPathNavigator nav, global::System.Data.Entity.Core.Mapping.EntityContainerMapping entityContainerMapping)
		{
			global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase, int> dictionary = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase, int>();
			foreach (global::System.Data.Entity.Core.Mapping.EntitySetBaseMapping entitySetBaseMapping in entityContainerMapping.EntitySetMaps)
			{
				global::System.Data.Entity.Core.Mapping.EntitySetMapping entitySetMapping = (global::System.Data.Entity.Core.Mapping.EntitySetMapping)entitySetBaseMapping;
				if (entitySetMapping.ModificationFunctionMappings.Count > 0)
				{
					global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase> set = new global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase>();
					foreach (global::System.Data.Entity.Core.Metadata.Edm.AssociationSetEnd associationSetEnd in entitySetMapping.ImplicitlyMappedAssociationSetEnds)
					{
						set.Add(associationSetEnd.ParentAssociationSet);
					}
					foreach (global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase key in set)
					{
						global::System.Data.Entity.Core.Mapping.MappingItemLoader.IncrementCount<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase>(dictionary, key);
					}
				}
			}
			foreach (global::System.Data.Entity.Core.Mapping.EntitySetBaseMapping entitySetBaseMapping2 in entityContainerMapping.RelationshipSetMaps)
			{
				global::System.Data.Entity.Core.Mapping.AssociationSetMapping associationSetMapping = (global::System.Data.Entity.Core.Mapping.AssociationSetMapping)entitySetBaseMapping2;
				if (associationSetMapping.ModificationFunctionMapping != null)
				{
					global::System.Data.Entity.Core.Mapping.MappingItemLoader.IncrementCount<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase>(dictionary, associationSetMapping.Set);
				}
			}
			global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
			foreach (global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase, int> keyValuePair in dictionary)
			{
				if (keyValuePair.Value > 1)
				{
					list.Add(keyValuePair.Key.Name);
				}
			}
			if (0 < list.Count)
			{
				global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrorsWithMemberInfo(new global::System.Func<object, string>(global::System.Data.Entity.Resources.Strings.Mapping_ModificationFunction_AssociationSetAmbiguous), global::System.Data.Entity.Core.Common.Utils.StringUtil.ToCommaSeparatedString(list), global::System.Data.Entity.Core.Mapping.MappingErrorCode.AmbiguousModificationFunctionMappingForAssociationSet, this.m_sourceLocation, (global::System.Xml.IXmlLineInfo)nav, this.m_parsingErrors);
			}
		}

		// Token: 0x0600426D RID: 17005 RVA: 0x000E0BA0 File Offset: 0x000DEDA0
		private static void IncrementCount<T>(global::System.Collections.Generic.Dictionary<T, int> counts, T key)
		{
			int num;
			if (counts.TryGetValue(key, out num))
			{
				num++;
			}
			else
			{
				num = 1;
			}
			counts[key] = num;
		}

		// Token: 0x0600426E RID: 17006 RVA: 0x000E0BC8 File Offset: 0x000DEDC8
		private void ValidateEntitySetFunctionMappingClosure(global::System.Xml.XPath.XPathNavigator nav, global::System.Data.Entity.Core.Mapping.EntityContainerMapping entityContainerMapping)
		{
			global::System.Data.Entity.Core.Common.Utils.KeyToListMap<global::System.Data.Entity.Core.Metadata.Edm.EntitySet, global::System.Data.Entity.Core.Mapping.EntitySetBaseMapping> keyToListMap = new global::System.Data.Entity.Core.Common.Utils.KeyToListMap<global::System.Data.Entity.Core.Metadata.Edm.EntitySet, global::System.Data.Entity.Core.Mapping.EntitySetBaseMapping>(global::System.Collections.Generic.EqualityComparer<global::System.Data.Entity.Core.Metadata.Edm.EntitySet>.Default);
			foreach (global::System.Data.Entity.Core.Mapping.EntitySetBaseMapping entitySetBaseMapping in entityContainerMapping.AllSetMaps)
			{
				foreach (global::System.Data.Entity.Core.Mapping.TypeMapping typeMapping in entitySetBaseMapping.TypeMappings)
				{
					foreach (global::System.Data.Entity.Core.Mapping.MappingFragment mappingFragment in typeMapping.MappingFragments)
					{
						keyToListMap.Add(mappingFragment.TableSet, entitySetBaseMapping);
					}
				}
			}
			global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase> implicitMappedAssociationSets = new global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase>();
			foreach (global::System.Data.Entity.Core.Mapping.EntitySetBaseMapping entitySetBaseMapping2 in entityContainerMapping.EntitySetMaps)
			{
				global::System.Data.Entity.Core.Mapping.EntitySetMapping entitySetMapping = (global::System.Data.Entity.Core.Mapping.EntitySetMapping)entitySetBaseMapping2;
				if (entitySetMapping.ModificationFunctionMappings.Count > 0)
				{
					foreach (global::System.Data.Entity.Core.Metadata.Edm.AssociationSetEnd associationSetEnd in entitySetMapping.ImplicitlyMappedAssociationSetEnds)
					{
						implicitMappedAssociationSets.Add(associationSetEnd.ParentAssociationSet);
					}
				}
			}
			global::System.Func<global::System.Data.Entity.Core.Mapping.EntitySetBaseMapping, bool> <>9__0;
			global::System.Func<global::System.Data.Entity.Core.Mapping.EntitySetBaseMapping, bool> <>9__1;
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EntitySet key in keyToListMap.Keys)
			{
				global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.EntitySetBaseMapping> source = keyToListMap.ListForKey(key);
				global::System.Func<global::System.Data.Entity.Core.Mapping.EntitySetBaseMapping, bool> predicate;
				if ((predicate = <>9__0) == null)
				{
					predicate = (<>9__0 = ((global::System.Data.Entity.Core.Mapping.EntitySetBaseMapping s) => s.HasModificationFunctionMapping || implicitMappedAssociationSets.Any((global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase aset) => aset == s.Set)));
				}
				if (source.Any(predicate))
				{
					global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.EntitySetBaseMapping> source2 = keyToListMap.ListForKey(key);
					global::System.Func<global::System.Data.Entity.Core.Mapping.EntitySetBaseMapping, bool> predicate2;
					if ((predicate2 = <>9__1) == null)
					{
						predicate2 = (<>9__1 = ((global::System.Data.Entity.Core.Mapping.EntitySetBaseMapping s) => !s.HasModificationFunctionMapping && !implicitMappedAssociationSets.Any((global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase aset) => aset == s.Set)));
					}
					if (source2.Any(predicate2))
					{
						global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrorsWithMemberInfo(new global::System.Func<object, string>(global::System.Data.Entity.Resources.Strings.Mapping_ModificationFunction_MissingSetClosure), global::System.Data.Entity.Core.Common.Utils.StringUtil.ToCommaSeparatedString(from s in keyToListMap.ListForKey(key)
						where !s.HasModificationFunctionMapping
						select s.Set.Name), global::System.Data.Entity.Core.Mapping.MappingErrorCode.MissingSetClosureInModificationFunctionMapping, this.m_sourceLocation, (global::System.Xml.IXmlLineInfo)nav, this.m_parsingErrors);
					}
				}
			}
		}

		// Token: 0x0600426F RID: 17007 RVA: 0x000E0E68 File Offset: 0x000DF068
		private static void ValidateClosureAmongSets(global::System.Data.Entity.Core.Mapping.EntityContainerMapping entityContainerMapping, global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase> sets, global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase> additionalSetsInClosure)
		{
			bool flag;
			do
			{
				flag = false;
				global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase>();
				foreach (global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase entitySetBase in additionalSetsInClosure)
				{
					global::System.Data.Entity.Core.Metadata.Edm.AssociationSet associationSet = entitySetBase as global::System.Data.Entity.Core.Metadata.Edm.AssociationSet;
					if (associationSet != null && !associationSet.ElementType.IsForeignKey)
					{
						foreach (global::System.Data.Entity.Core.Metadata.Edm.AssociationSetEnd associationSetEnd in associationSet.AssociationSetEnds)
						{
							if (!additionalSetsInClosure.Contains(associationSetEnd.EntitySet))
							{
								list.Add(associationSetEnd.EntitySet);
							}
						}
					}
				}
				foreach (global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase entitySetBase2 in entityContainerMapping.EdmEntityContainer.BaseEntitySets)
				{
					global::System.Data.Entity.Core.Metadata.Edm.AssociationSet associationSet2 = entitySetBase2 as global::System.Data.Entity.Core.Metadata.Edm.AssociationSet;
					if (associationSet2 != null && !associationSet2.ElementType.IsForeignKey && !additionalSetsInClosure.Contains(associationSet2))
					{
						foreach (global::System.Data.Entity.Core.Metadata.Edm.AssociationSetEnd associationSetEnd2 in associationSet2.AssociationSetEnds)
						{
							if (additionalSetsInClosure.Contains(associationSetEnd2.EntitySet))
							{
								list.Add(associationSet2);
								break;
							}
						}
					}
				}
				if (0 < list.Count)
				{
					flag = true;
					additionalSetsInClosure.AddRange(list);
				}
			}
			while (flag);
			additionalSetsInClosure.Subtract(sets);
		}

		// Token: 0x06004270 RID: 17008 RVA: 0x000E1000 File Offset: 0x000DF200
		private void ValidateQueryViewsClosure(global::System.Xml.XPath.XPathNavigator nav, global::System.Data.Entity.Core.Mapping.EntityContainerMapping entityContainerMapping)
		{
			if (!this.m_hasQueryViews)
			{
				return;
			}
			global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase> set = new global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase>();
			global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase> set2 = new global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase>();
			foreach (global::System.Data.Entity.Core.Mapping.EntitySetBaseMapping entitySetBaseMapping in entityContainerMapping.AllSetMaps)
			{
				if (entitySetBaseMapping.QueryView != null)
				{
					set.Add(entitySetBaseMapping.Set);
				}
			}
			set2.AddRange(set);
			global::System.Data.Entity.Core.Mapping.MappingItemLoader.ValidateClosureAmongSets(entityContainerMapping, set, set2);
			if (0 < set2.Count)
			{
				global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrorsWithMemberInfo(new global::System.Func<object, string>(global::System.Data.Entity.Resources.Strings.Mapping_Invalid_Query_Views_MissingSetClosure), global::System.Data.Entity.Core.Common.Utils.StringUtil.ToCommaSeparatedString(set2), global::System.Data.Entity.Core.Mapping.MappingErrorCode.MissingSetClosureInQueryViews, this.m_sourceLocation, (global::System.Xml.IXmlLineInfo)nav, this.m_parsingErrors);
			}
		}

		// Token: 0x06004271 RID: 17009 RVA: 0x000E10B8 File Offset: 0x000DF2B8
		private void LoadEntitySetMapping(global::System.Xml.XPath.XPathNavigator nav, global::System.Data.Entity.Core.Mapping.EntityContainerMapping entityContainerMapping, global::System.Data.Entity.Core.Metadata.Edm.EntityContainer storageEntityContainerType)
		{
			string aliasResolvedAttributeValue = this.GetAliasResolvedAttributeValue(nav.Clone(), "Name");
			string attributeValue = global::System.Data.Entity.Core.Mapping.MappingItemLoader.GetAttributeValue(nav.Clone(), "TypeName");
			string aliasResolvedAttributeValue2 = this.GetAliasResolvedAttributeValue(nav.Clone(), "StoreEntitySet");
			bool boolAttributeValue = global::System.Data.Entity.Core.Mapping.MappingItemLoader.GetBoolAttributeValue(nav.Clone(), "MakeColumnsDistinct", false);
			global::System.Data.Entity.Core.Mapping.EntitySetMapping entitySetMapping = (global::System.Data.Entity.Core.Mapping.EntitySetMapping)entityContainerMapping.GetEntitySetMapping(aliasResolvedAttributeValue);
			global::System.Xml.IXmlLineInfo xmlLineInfo = (global::System.Xml.IXmlLineInfo)nav;
			global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet;
			if (entitySetMapping == null)
			{
				if (!entityContainerMapping.EdmEntityContainer.TryGetEntitySetByName(aliasResolvedAttributeValue, false, out entitySet))
				{
					global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrorsWithMemberInfo(new global::System.Func<object, string>(global::System.Data.Entity.Resources.Strings.Mapping_InvalidContent_Entity_Set), aliasResolvedAttributeValue, global::System.Data.Entity.Core.Mapping.MappingErrorCode.InvalidEntitySet, this.m_sourceLocation, xmlLineInfo, this.m_parsingErrors);
					return;
				}
				entitySetMapping = new global::System.Data.Entity.Core.Mapping.EntitySetMapping(entitySet, entityContainerMapping);
			}
			else
			{
				entitySet = (global::System.Data.Entity.Core.Metadata.Edm.EntitySet)entitySetMapping.Set;
			}
			entitySetMapping.StartLineNumber = xmlLineInfo.LineNumber;
			entitySetMapping.StartLinePosition = xmlLineInfo.LinePosition;
			entityContainerMapping.AddSetMapping(entitySetMapping);
			if (string.IsNullOrEmpty(attributeValue))
			{
				if (nav.MoveToChild(global::System.Xml.XPath.XPathNodeType.Element))
				{
					for (;;)
					{
						string localName = nav.LocalName;
						if (localName == null)
						{
							goto IL_186;
						}
						if (!(localName == "EntityTypeMapping"))
						{
							if (!(localName == "QueryView"))
							{
								goto IL_186;
							}
							if (!string.IsNullOrEmpty(aliasResolvedAttributeValue2))
							{
								break;
							}
							if (!this.LoadQueryView(nav.Clone(), entitySetMapping))
							{
								return;
							}
						}
						else
						{
							aliasResolvedAttributeValue2 = this.GetAliasResolvedAttributeValue(nav.Clone(), "StoreEntitySet");
							this.LoadEntityTypeMapping(nav.Clone(), entitySetMapping, aliasResolvedAttributeValue2, storageEntityContainerType, false, entityContainerMapping.GenerateUpdateViews);
						}
						IL_1A3:
						if (!nav.MoveToNext(global::System.Xml.XPath.XPathNodeType.Element))
						{
							goto Block_9;
						}
						continue;
						IL_186:
						global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrors(global::System.Data.Entity.Resources.Strings.Mapping_InvalidContent_TypeMapping_QueryView, global::System.Data.Entity.Core.Mapping.MappingErrorCode.InvalidContent, this.m_sourceLocation, xmlLineInfo, this.m_parsingErrors);
						goto IL_1A3;
					}
					global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrorsWithMemberInfo(new global::System.Func<object, string>(global::System.Data.Entity.Resources.Strings.Mapping_TableName_QueryView), aliasResolvedAttributeValue, global::System.Data.Entity.Core.Mapping.MappingErrorCode.TableNameAttributeWithQueryView, this.m_sourceLocation, xmlLineInfo, this.m_parsingErrors);
					return;
					Block_9:;
				}
			}
			else
			{
				this.LoadEntityTypeMapping(nav.Clone(), entitySetMapping, aliasResolvedAttributeValue2, storageEntityContainerType, boolAttributeValue, entityContainerMapping.GenerateUpdateViews);
			}
			this.ValidateAllEntityTypesHaveFunctionMapping(nav.Clone(), entitySetMapping);
			if (entitySetMapping.HasNoContent)
			{
				global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrorsWithMemberInfo(new global::System.Func<object, string>(global::System.Data.Entity.Resources.Strings.Mapping_InvalidContent_Emtpty_SetMap), entitySet.Name, global::System.Data.Entity.Core.Mapping.MappingErrorCode.EmptySetMapping, this.m_sourceLocation, xmlLineInfo, this.m_parsingErrors);
			}
		}

		// Token: 0x06004272 RID: 17010 RVA: 0x000E12D0 File Offset: 0x000DF4D0
		private void ValidateAllEntityTypesHaveFunctionMapping(global::System.Xml.XPath.XPathNavigator nav, global::System.Data.Entity.Core.Mapping.EntitySetMapping setMapping)
		{
			global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.EdmType> set = new global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.EdmType>();
			foreach (global::System.Data.Entity.Core.Mapping.EntityTypeModificationFunctionMapping entityTypeModificationFunctionMapping in setMapping.ModificationFunctionMappings)
			{
				set.Add(entityTypeModificationFunctionMapping.EntityType);
			}
			if (0 < set.Count)
			{
				global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.EdmType> set2 = new global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.EdmType>(global::System.Data.Entity.Core.Common.Utils.MetadataHelper.GetTypeAndSubtypesOf(setMapping.Set.ElementType, this.EdmItemCollection, false));
				set2.Subtract(set);
				global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.EdmType> set3 = new global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.EdmType>();
				foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType in set2)
				{
					global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType = (global::System.Data.Entity.Core.Metadata.Edm.EntityType)edmType;
					if (entityType.Abstract)
					{
						set3.Add(entityType);
					}
				}
				set2.Subtract(set3);
				if (0 < set2.Count)
				{
					global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrorsWithMemberInfo(new global::System.Func<object, string>(global::System.Data.Entity.Resources.Strings.Mapping_ModificationFunction_MissingEntityType), global::System.Data.Entity.Core.Common.Utils.StringUtil.ToCommaSeparatedString(set2), global::System.Data.Entity.Core.Mapping.MappingErrorCode.MissingModificationFunctionMappingForEntityType, this.m_sourceLocation, (global::System.Xml.IXmlLineInfo)nav, this.m_parsingErrors);
				}
			}
		}

		// Token: 0x06004273 RID: 17011 RVA: 0x000E13F0 File Offset: 0x000DF5F0
		private bool TryParseEntityTypeAttribute(global::System.Xml.XPath.XPathNavigator nav, global::System.Data.Entity.Core.Metadata.Edm.EntityType rootEntityType, global::System.Func<global::System.Data.Entity.Core.Metadata.Edm.EntityType, string> typeNotAssignableMessage, out global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.EntityType> isOfTypeEntityTypes, out global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.EntityType> entityTypes)
		{
			global::System.Xml.IXmlLineInfo lineInfo = (global::System.Xml.IXmlLineInfo)nav;
			string attributeValue = global::System.Data.Entity.Core.Mapping.MappingItemLoader.GetAttributeValue(nav.Clone(), "TypeName");
			isOfTypeEntityTypes = new global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.EntityType>();
			entityTypes = new global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.EntityType>();
			foreach (string text in from s in attributeValue.Split(new char[]
			{
				';'
			})
			select s.Trim())
			{
				bool flag = text.StartsWith("IsTypeOf(", global::System.StringComparison.Ordinal);
				string text2;
				if (flag)
				{
					if (!text.EndsWith(")", global::System.StringComparison.Ordinal))
					{
						global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrorWithMessage(global::System.Data.Entity.Resources.Strings.Mapping_InvalidContent_IsTypeOfNotTerminated, global::System.Data.Entity.Core.Mapping.MappingErrorCode.InvalidEntityType, this.m_sourceLocation, lineInfo, this.m_parsingErrors);
						return false;
					}
					text2 = text.Substring("IsTypeOf(".Length);
					text2 = text2.Substring(0, text2.Length - ")".Length).Trim();
				}
				else
				{
					text2 = text;
				}
				text2 = this.GetAliasResolvedValue(text2);
				global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType;
				if (!this.EdmItemCollection.TryGetItem<global::System.Data.Entity.Core.Metadata.Edm.EntityType>(text2, out entityType))
				{
					global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrorsWithMemberInfo(new global::System.Func<object, string>(global::System.Data.Entity.Resources.Strings.Mapping_InvalidContent_Entity_Type), text2, global::System.Data.Entity.Core.Mapping.MappingErrorCode.InvalidEntityType, this.m_sourceLocation, lineInfo, this.m_parsingErrors);
					return false;
				}
				if (!global::System.Data.Entity.Core.Metadata.Edm.Helper.IsAssignableFrom(rootEntityType, entityType))
				{
					global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrorWithMessage(typeNotAssignableMessage(entityType), global::System.Data.Entity.Core.Mapping.MappingErrorCode.InvalidEntityType, this.m_sourceLocation, lineInfo, this.m_parsingErrors);
					return false;
				}
				if (entityType.Abstract)
				{
					if (!flag)
					{
						global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrorsWithMemberInfo(new global::System.Func<object, string>(global::System.Data.Entity.Resources.Strings.Mapping_InvalidContent_AbstractEntity_Type), entityType.FullName, global::System.Data.Entity.Core.Mapping.MappingErrorCode.MappingOfAbstractType, this.m_sourceLocation, lineInfo, this.m_parsingErrors);
						return false;
					}
					if (!global::System.Data.Entity.Core.Common.Utils.MetadataHelper.GetTypeAndSubtypesOf(entityType, this.EdmItemCollection, false).GetEnumerator().MoveNext())
					{
						global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrorsWithMemberInfo(new global::System.Func<object, string>(global::System.Data.Entity.Resources.Strings.Mapping_InvalidContent_AbstractEntity_IsOfType), entityType.FullName, global::System.Data.Entity.Core.Mapping.MappingErrorCode.MappingOfAbstractType, this.m_sourceLocation, lineInfo, this.m_parsingErrors);
						return false;
					}
				}
				if (flag)
				{
					isOfTypeEntityTypes.Add(entityType);
				}
				else
				{
					entityTypes.Add(entityType);
				}
			}
			return true;
		}

		// Token: 0x06004274 RID: 17012 RVA: 0x000E1634 File Offset: 0x000DF834
		private void LoadEntityTypeMapping(global::System.Xml.XPath.XPathNavigator nav, global::System.Data.Entity.Core.Mapping.EntitySetMapping entitySetMapping, string tableName, global::System.Data.Entity.Core.Metadata.Edm.EntityContainer storageEntityContainerType, bool distinctFlagAboveType, bool generateUpdateViews)
		{
			global::System.Xml.IXmlLineInfo lineInfo = (global::System.Xml.IXmlLineInfo)nav;
			global::System.Data.Entity.Core.Mapping.EntityTypeMapping entityTypeMapping = new global::System.Data.Entity.Core.Mapping.EntityTypeMapping(entitySetMapping);
			global::System.Data.Entity.Core.Metadata.Edm.EntityType rootEntityType = (global::System.Data.Entity.Core.Metadata.Edm.EntityType)entitySetMapping.Set.ElementType;
			global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.EntityType> set;
			global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.EntityType> set2;
			if (!this.TryParseEntityTypeAttribute(nav.Clone(), rootEntityType, (global::System.Data.Entity.Core.Metadata.Edm.EntityType e) => global::System.Data.Entity.Resources.Strings.Mapping_InvalidContent_Entity_Type_For_Entity_Set(e.FullName, rootEntityType.FullName, entitySetMapping.Set.Name), out set, out set2))
			{
				return;
			}
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EntityType type in set2)
			{
				entityTypeMapping.AddType(type);
			}
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EntityType type2 in set)
			{
				entityTypeMapping.AddIsOfType(type2);
			}
			if (string.IsNullOrEmpty(tableName))
			{
				if (!nav.MoveToChild(global::System.Xml.XPath.XPathNodeType.Element))
				{
					return;
				}
				do
				{
					if (nav.LocalName == "ModificationFunctionMapping")
					{
						entitySetMapping.HasModificationFunctionMapping = true;
						this.LoadEntityTypeModificationFunctionMapping(nav.Clone(), entitySetMapping, entityTypeMapping);
					}
					else if (nav.LocalName != "MappingFragment")
					{
						global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrors(global::System.Data.Entity.Resources.Strings.Mapping_InvalidContent_Table_Expected, global::System.Data.Entity.Core.Mapping.MappingErrorCode.TableMappingFragmentExpected, this.m_sourceLocation, lineInfo, this.m_parsingErrors);
					}
					else
					{
						bool boolAttributeValue = global::System.Data.Entity.Core.Mapping.MappingItemLoader.GetBoolAttributeValue(nav.Clone(), "MakeColumnsDistinct", false);
						if (generateUpdateViews && boolAttributeValue)
						{
							global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrors(global::System.Data.Entity.Resources.Strings.Mapping_DistinctFlagInReadWriteContainer, global::System.Data.Entity.Core.Mapping.MappingErrorCode.DistinctFragmentInReadWriteContainer, this.m_sourceLocation, lineInfo, this.m_parsingErrors);
						}
						tableName = this.GetAliasResolvedAttributeValue(nav.Clone(), "StoreEntitySet");
						global::System.Data.Entity.Core.Mapping.MappingFragment mappingFragment = this.LoadMappingFragment(nav.Clone(), entityTypeMapping, tableName, storageEntityContainerType, boolAttributeValue);
						if (mappingFragment != null)
						{
							entityTypeMapping.AddFragment(mappingFragment);
						}
					}
				}
				while (nav.MoveToNext(global::System.Xml.XPath.XPathNodeType.Element));
			}
			else
			{
				if (nav.LocalName == "ModificationFunctionMapping")
				{
					global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrors(global::System.Data.Entity.Resources.Strings.Mapping_ModificationFunction_In_Table_Context, global::System.Data.Entity.Core.Mapping.MappingErrorCode.InvalidTableNameAttributeWithModificationFunctionMapping, this.m_sourceLocation, lineInfo, this.m_parsingErrors);
				}
				if (generateUpdateViews && distinctFlagAboveType)
				{
					global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrors(global::System.Data.Entity.Resources.Strings.Mapping_DistinctFlagInReadWriteContainer, global::System.Data.Entity.Core.Mapping.MappingErrorCode.DistinctFragmentInReadWriteContainer, this.m_sourceLocation, lineInfo, this.m_parsingErrors);
				}
				global::System.Data.Entity.Core.Mapping.MappingFragment mappingFragment2 = this.LoadMappingFragment(nav.Clone(), entityTypeMapping, tableName, storageEntityContainerType, distinctFlagAboveType);
				if (mappingFragment2 != null)
				{
					entityTypeMapping.AddFragment(mappingFragment2);
				}
			}
			entitySetMapping.AddTypeMapping(entityTypeMapping);
		}

		// Token: 0x06004275 RID: 17013 RVA: 0x000E1898 File Offset: 0x000DFA98
		private void LoadEntityTypeModificationFunctionMapping(global::System.Xml.XPath.XPathNavigator nav, global::System.Data.Entity.Core.Mapping.EntitySetMapping entitySetMapping, global::System.Data.Entity.Core.Mapping.EntityTypeMapping entityTypeMapping)
		{
			global::System.Xml.IXmlLineInfo lineInfo = (global::System.Xml.IXmlLineInfo)nav;
			if (entityTypeMapping.IsOfTypes.Count != 0 || entityTypeMapping.Types.Count != 1)
			{
				global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrors(global::System.Data.Entity.Resources.Strings.Mapping_ModificationFunction_Multiple_Types, global::System.Data.Entity.Core.Mapping.MappingErrorCode.InvalidModificationFunctionMappingForMultipleTypes, this.m_sourceLocation, lineInfo, this.m_parsingErrors);
				return;
			}
			global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType = (global::System.Data.Entity.Core.Metadata.Edm.EntityType)entityTypeMapping.Types[0];
			if (entityType.Abstract)
			{
				global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrorsWithMemberInfo(new global::System.Func<object, string>(global::System.Data.Entity.Resources.Strings.Mapping_InvalidContent_AbstractEntity_FunctionMapping), entityType.FullName, global::System.Data.Entity.Core.Mapping.MappingErrorCode.MappingOfAbstractType, this.m_sourceLocation, lineInfo, this.m_parsingErrors);
				return;
			}
			using (global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Mapping.EntityTypeModificationFunctionMapping> enumerator = entitySetMapping.ModificationFunctionMappings.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.EntityType.Equals(entityType))
					{
						global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrorsWithMemberInfo(new global::System.Func<object, string>(global::System.Data.Entity.Resources.Strings.Mapping_ModificationFunction_RedundantEntityTypeMapping), entityType.Name, global::System.Data.Entity.Core.Mapping.MappingErrorCode.RedundantEntityTypeMappingInModificationFunctionMapping, this.m_sourceLocation, lineInfo, this.m_parsingErrors);
						return;
					}
				}
			}
			global::System.Data.Entity.Core.Mapping.MappingItemLoader.ModificationFunctionMappingLoader modificationFunctionMappingLoader = new global::System.Data.Entity.Core.Mapping.MappingItemLoader.ModificationFunctionMappingLoader(this, entitySetMapping.Set);
			global::System.Data.Entity.Core.Mapping.ModificationFunctionMapping modificationFunctionMapping = null;
			global::System.Data.Entity.Core.Mapping.ModificationFunctionMapping modificationFunctionMapping2 = null;
			global::System.Data.Entity.Core.Mapping.ModificationFunctionMapping modificationFunctionMapping3 = null;
			if (nav.MoveToChild(global::System.Xml.XPath.XPathNodeType.Element))
			{
				do
				{
					string localName = nav.LocalName;
					if (localName != null)
					{
						if (!(localName == "DeleteFunction"))
						{
							if (!(localName == "InsertFunction"))
							{
								if (localName == "UpdateFunction")
								{
									modificationFunctionMapping3 = modificationFunctionMappingLoader.LoadEntityTypeModificationFunctionMapping(nav.Clone(), entitySetMapping.Set, true, true, entityType);
								}
							}
							else
							{
								modificationFunctionMapping2 = modificationFunctionMappingLoader.LoadEntityTypeModificationFunctionMapping(nav.Clone(), entitySetMapping.Set, true, false, entityType);
							}
						}
						else
						{
							modificationFunctionMapping = modificationFunctionMappingLoader.LoadEntityTypeModificationFunctionMapping(nav.Clone(), entitySetMapping.Set, false, true, entityType);
						}
					}
				}
				while (nav.MoveToNext(global::System.Xml.XPath.XPathNodeType.Element));
			}
			global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ModificationFunctionParameterBinding> enumerable = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ModificationFunctionParameterBinding>();
			if (modificationFunctionMapping != null)
			{
				enumerable = global::System.Data.Entity.Core.Metadata.Edm.Helper.Concat<global::System.Data.Entity.Core.Mapping.ModificationFunctionParameterBinding>(new global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ModificationFunctionParameterBinding>[]
				{
					enumerable,
					modificationFunctionMapping.ParameterBindings
				});
			}
			if (modificationFunctionMapping2 != null)
			{
				enumerable = global::System.Data.Entity.Core.Metadata.Edm.Helper.Concat<global::System.Data.Entity.Core.Mapping.ModificationFunctionParameterBinding>(new global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ModificationFunctionParameterBinding>[]
				{
					enumerable,
					modificationFunctionMapping2.ParameterBindings
				});
			}
			if (modificationFunctionMapping3 != null)
			{
				enumerable = global::System.Data.Entity.Core.Metadata.Edm.Helper.Concat<global::System.Data.Entity.Core.Mapping.ModificationFunctionParameterBinding>(new global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ModificationFunctionParameterBinding>[]
				{
					enumerable,
					modificationFunctionMapping3.ParameterBindings
				});
			}
			global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.AssociationSet, global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember> dictionary = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.AssociationSet, global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember>();
			foreach (global::System.Data.Entity.Core.Mapping.ModificationFunctionParameterBinding modificationFunctionParameterBinding in enumerable)
			{
				if (modificationFunctionParameterBinding.MemberPath.AssociationSetEnd != null)
				{
					global::System.Data.Entity.Core.Metadata.Edm.AssociationSet parentAssociationSet = modificationFunctionParameterBinding.MemberPath.AssociationSetEnd.ParentAssociationSet;
					global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember correspondingAssociationEndMember = modificationFunctionParameterBinding.MemberPath.AssociationSetEnd.CorrespondingAssociationEndMember;
					global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember associationEndMember;
					if (dictionary.TryGetValue(parentAssociationSet, out associationEndMember) && associationEndMember != correspondingAssociationEndMember)
					{
						global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrorWithMessage(global::System.Data.Entity.Resources.Strings.Mapping_ModificationFunction_MultipleEndsOfAssociationMapped(correspondingAssociationEndMember.Name, associationEndMember.Name, parentAssociationSet.Name), global::System.Data.Entity.Core.Mapping.MappingErrorCode.InvalidModificationFunctionMappingMultipleEndsOfAssociationMapped, this.m_sourceLocation, lineInfo, this.m_parsingErrors);
						return;
					}
					dictionary[parentAssociationSet] = correspondingAssociationEndMember;
				}
			}
			global::System.Data.Entity.Core.Mapping.EntityTypeModificationFunctionMapping modificationFunctionMapping4 = new global::System.Data.Entity.Core.Mapping.EntityTypeModificationFunctionMapping(entityType, modificationFunctionMapping, modificationFunctionMapping2, modificationFunctionMapping3);
			entitySetMapping.AddModificationFunctionMapping(modificationFunctionMapping4);
		}

		// Token: 0x06004276 RID: 17014 RVA: 0x000E1B94 File Offset: 0x000DFD94
		private bool LoadQueryView(global::System.Xml.XPath.XPathNavigator nav, global::System.Data.Entity.Core.Mapping.EntitySetBaseMapping setMapping)
		{
			string value = nav.Value;
			string text = global::System.Data.Entity.Core.Mapping.MappingItemLoader.GetAttributeValue(nav.Clone(), "TypeName");
			if (text != null)
			{
				text = text.Trim();
			}
			global::System.Xml.IXmlLineInfo xmlLineInfo = nav as global::System.Xml.IXmlLineInfo;
			if (setMapping.QueryView == null)
			{
				if (text != null)
				{
					global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrorsWithMemberInfo((object val) => global::System.Data.Entity.Resources.Strings.Mapping_TypeName_For_First_QueryView, setMapping.Set.Name, global::System.Data.Entity.Core.Mapping.MappingErrorCode.TypeNameForFirstQueryView, this.m_sourceLocation, xmlLineInfo, this.m_parsingErrors);
					return false;
				}
				if (string.IsNullOrEmpty(value))
				{
					global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrorsWithMemberInfo(new global::System.Func<object, string>(global::System.Data.Entity.Resources.Strings.Mapping_Empty_QueryView), setMapping.Set.Name, global::System.Data.Entity.Core.Mapping.MappingErrorCode.EmptyQueryView, this.m_sourceLocation, xmlLineInfo, this.m_parsingErrors);
					return false;
				}
				setMapping.QueryView = value;
				this.m_hasQueryViews = true;
				return true;
			}
			else
			{
				if (text == null || text.Trim().Length == 0)
				{
					global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrorsWithMemberInfo(new global::System.Func<object, string>(global::System.Data.Entity.Resources.Strings.Mapping_QueryView_TypeName_Not_Defined), setMapping.Set.Name, global::System.Data.Entity.Core.Mapping.MappingErrorCode.NoTypeNameForTypeSpecificQueryView, this.m_sourceLocation, xmlLineInfo, this.m_parsingErrors);
					return false;
				}
				global::System.Data.Entity.Core.Metadata.Edm.EntityType rootEntityType = (global::System.Data.Entity.Core.Metadata.Edm.EntityType)setMapping.Set.ElementType;
				global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.EntityType> set;
				global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.EntityType> set2;
				if (!this.TryParseEntityTypeAttribute(nav.Clone(), rootEntityType, (global::System.Data.Entity.Core.Metadata.Edm.EntityType e) => global::System.Data.Entity.Resources.Strings.Mapping_InvalidContent_Entity_Type_For_Entity_Set(e.FullName, rootEntityType.FullName, setMapping.Set.Name), out set, out set2))
				{
					return false;
				}
				global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType;
				bool flag;
				if (set.Count == 1)
				{
					entityType = set.First<global::System.Data.Entity.Core.Metadata.Edm.EntityType>();
					flag = true;
				}
				else
				{
					if (set2.Count != 1)
					{
						global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrorsWithMemberInfo(new global::System.Func<object, string>(global::System.Data.Entity.Resources.Strings.Mapping_QueryViewMultipleTypeInTypeName), setMapping.Set.ToString(), global::System.Data.Entity.Core.Mapping.MappingErrorCode.TypeNameContainsMultipleTypesForQueryView, this.m_sourceLocation, xmlLineInfo, this.m_parsingErrors);
						return false;
					}
					entityType = set2.First<global::System.Data.Entity.Core.Metadata.Edm.EntityType>();
					flag = false;
				}
				if (flag && setMapping.Set.ElementType.EdmEquals(entityType))
				{
					global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrorWithMemberAndStructure(new global::System.Func<object, object, string>(global::System.Data.Entity.Resources.Strings.Mapping_QueryView_For_Base_Type), entityType.ToString(), setMapping.Set.ToString(), global::System.Data.Entity.Core.Mapping.MappingErrorCode.IsTypeOfQueryViewForBaseType, this.m_sourceLocation, xmlLineInfo, this.m_parsingErrors);
					return false;
				}
				if (string.IsNullOrEmpty(value))
				{
					if (flag)
					{
						global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrorWithMemberAndStructure(new global::System.Func<object, object, string>(global::System.Data.Entity.Resources.Strings.Mapping_Empty_QueryView_OfType), entityType.Name, setMapping.Set.Name, global::System.Data.Entity.Core.Mapping.MappingErrorCode.EmptyQueryView, this.m_sourceLocation, xmlLineInfo, this.m_parsingErrors);
						return false;
					}
					global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrorWithMemberAndStructure(new global::System.Func<object, object, string>(global::System.Data.Entity.Resources.Strings.Mapping_Empty_QueryView_OfTypeOnly), setMapping.Set.Name, entityType.Name, global::System.Data.Entity.Core.Mapping.MappingErrorCode.EmptyQueryView, this.m_sourceLocation, xmlLineInfo, this.m_parsingErrors);
					return false;
				}
				else
				{
					global::System.Data.Entity.Core.Common.Utils.Pair<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase, global::System.Data.Entity.Core.Common.Utils.Pair<global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase, bool>> key = new global::System.Data.Entity.Core.Common.Utils.Pair<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase, global::System.Data.Entity.Core.Common.Utils.Pair<global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase, bool>>(setMapping.Set, new global::System.Data.Entity.Core.Common.Utils.Pair<global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase, bool>(entityType, flag));
					if (setMapping.ContainsTypeSpecificQueryView(key))
					{
						global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError item;
						if (flag)
						{
							item = new global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError(global::System.Data.Entity.Resources.Strings.Mapping_QueryView_Duplicate_OfType(setMapping.Set, entityType), 2082, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, this.m_sourceLocation, xmlLineInfo.LineNumber, xmlLineInfo.LinePosition);
						}
						else
						{
							item = new global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError(global::System.Data.Entity.Resources.Strings.Mapping_QueryView_Duplicate_OfTypeOnly(setMapping.Set, entityType), 2082, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, this.m_sourceLocation, xmlLineInfo.LineNumber, xmlLineInfo.LinePosition);
						}
						this.m_parsingErrors.Add(item);
						return false;
					}
					setMapping.AddTypeSpecificQueryView(key, value);
					return true;
				}
			}
		}

		// Token: 0x06004277 RID: 17015 RVA: 0x000E1F0C File Offset: 0x000E010C
		private void LoadAssociationSetMapping(global::System.Xml.XPath.XPathNavigator nav, global::System.Data.Entity.Core.Mapping.EntityContainerMapping entityContainerMapping, global::System.Data.Entity.Core.Metadata.Edm.EntityContainer storageEntityContainerType)
		{
			global::System.Xml.IXmlLineInfo xmlLineInfo = (global::System.Xml.IXmlLineInfo)nav;
			string aliasResolvedAttributeValue = this.GetAliasResolvedAttributeValue(nav.Clone(), "Name");
			string aliasResolvedAttributeValue2 = this.GetAliasResolvedAttributeValue(nav.Clone(), "TypeName");
			string aliasResolvedAttributeValue3 = this.GetAliasResolvedAttributeValue(nav.Clone(), "StoreEntitySet");
			global::System.Data.Entity.Core.Metadata.Edm.RelationshipSet relationshipSet;
			entityContainerMapping.EdmEntityContainer.TryGetRelationshipSetByName(aliasResolvedAttributeValue, false, out relationshipSet);
			global::System.Data.Entity.Core.Metadata.Edm.AssociationSet associationSet = relationshipSet as global::System.Data.Entity.Core.Metadata.Edm.AssociationSet;
			if (associationSet == null)
			{
				global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrorsWithMemberInfo(new global::System.Func<object, string>(global::System.Data.Entity.Resources.Strings.Mapping_InvalidContent_Association_Set), aliasResolvedAttributeValue, global::System.Data.Entity.Core.Mapping.MappingErrorCode.InvalidAssociationSet, this.m_sourceLocation, xmlLineInfo, this.m_parsingErrors);
				return;
			}
			if (associationSet.ElementType.IsForeignKey)
			{
				global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint referentialConstraint = associationSet.ElementType.ReferentialConstraints.Single<global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint>();
				global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmMember> dependentKeys = global::System.Data.Entity.Core.Common.Utils.MetadataHelper.GetEntityTypeForEnd((global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember)referentialConstraint.ToRole).KeyMembers;
				if (associationSet.ElementType.ReferentialConstraints.Single<global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint>().ToProperties.All((global::System.Data.Entity.Core.Metadata.Edm.EdmProperty p) => dependentKeys.Contains(p)))
				{
					global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrorsWithMemberInfo(new global::System.Func<object, string>(global::System.Data.Entity.Resources.Strings.Mapping_InvalidContent_ForeignKey_Association_Set_PKtoPK), aliasResolvedAttributeValue, global::System.Data.Entity.Core.Mapping.MappingErrorCode.InvalidAssociationSet, this.m_sourceLocation, xmlLineInfo, this.m_parsingErrors).Severity = global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Warning;
					return;
				}
				global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrorsWithMemberInfo(new global::System.Func<object, string>(global::System.Data.Entity.Resources.Strings.Mapping_InvalidContent_ForeignKey_Association_Set), aliasResolvedAttributeValue, global::System.Data.Entity.Core.Mapping.MappingErrorCode.InvalidAssociationSet, this.m_sourceLocation, xmlLineInfo, this.m_parsingErrors);
				return;
			}
			else
			{
				if (entityContainerMapping.ContainsAssociationSetMapping(associationSet))
				{
					global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrorsWithMemberInfo(new global::System.Func<object, string>(global::System.Data.Entity.Resources.Strings.Mapping_Duplicate_CdmAssociationSet_StorageMap), aliasResolvedAttributeValue, global::System.Data.Entity.Core.Mapping.MappingErrorCode.DuplicateSetMapping, this.m_sourceLocation, xmlLineInfo, this.m_parsingErrors);
					return;
				}
				global::System.Data.Entity.Core.Mapping.AssociationSetMapping associationSetMapping = new global::System.Data.Entity.Core.Mapping.AssociationSetMapping(associationSet, entityContainerMapping);
				associationSetMapping.StartLineNumber = xmlLineInfo.LineNumber;
				associationSetMapping.StartLinePosition = xmlLineInfo.LinePosition;
				if (!nav.MoveToChild(global::System.Xml.XPath.XPathNodeType.Element))
				{
					global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrorsWithMemberInfo(new global::System.Func<object, string>(global::System.Data.Entity.Resources.Strings.Mapping_InvalidContent_Emtpty_SetMap), associationSet.Name, global::System.Data.Entity.Core.Mapping.MappingErrorCode.EmptySetMapping, this.m_sourceLocation, xmlLineInfo, this.m_parsingErrors);
					return;
				}
				entityContainerMapping.AddSetMapping(associationSetMapping);
				if (nav.LocalName == "QueryView")
				{
					if (!string.IsNullOrEmpty(aliasResolvedAttributeValue3))
					{
						global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrorsWithMemberInfo(new global::System.Func<object, string>(global::System.Data.Entity.Resources.Strings.Mapping_TableName_QueryView), aliasResolvedAttributeValue, global::System.Data.Entity.Core.Mapping.MappingErrorCode.TableNameAttributeWithQueryView, this.m_sourceLocation, xmlLineInfo, this.m_parsingErrors);
						return;
					}
					if (!this.LoadQueryView(nav.Clone(), associationSetMapping))
					{
						return;
					}
					if (!nav.MoveToNext(global::System.Xml.XPath.XPathNodeType.Element))
					{
						return;
					}
				}
				if (nav.LocalName == "EndProperty" || nav.LocalName == "ModificationFunctionMapping")
				{
					if (string.IsNullOrEmpty(aliasResolvedAttributeValue2))
					{
						global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrors(global::System.Data.Entity.Resources.Strings.Mapping_InvalidContent_Association_Type_Empty, global::System.Data.Entity.Core.Mapping.MappingErrorCode.InvalidAssociationType, this.m_sourceLocation, xmlLineInfo, this.m_parsingErrors);
						return;
					}
					this.LoadAssociationTypeMapping(nav.Clone(), associationSetMapping, aliasResolvedAttributeValue2, aliasResolvedAttributeValue3, storageEntityContainerType);
					return;
				}
				else
				{
					if (nav.LocalName == "Condition")
					{
						global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrorsWithMemberInfo(new global::System.Func<object, string>(global::System.Data.Entity.Resources.Strings.Mapping_InvalidContent_AssociationSet_Condition), aliasResolvedAttributeValue, global::System.Data.Entity.Core.Mapping.MappingErrorCode.InvalidContent, this.m_sourceLocation, xmlLineInfo, this.m_parsingErrors);
						return;
					}
					return;
				}
			}
		}

		// Token: 0x06004278 RID: 17016 RVA: 0x000E21DC File Offset: 0x000E03DC
		private void LoadFunctionImportMapping(global::System.Xml.XPath.XPathNavigator nav, global::System.Data.Entity.Core.Mapping.EntityContainerMapping entityContainerMapping)
		{
			global::System.Xml.IXmlLineInfo xmlLineInfo = (global::System.Xml.IXmlLineInfo)nav.Clone();
			global::System.Data.Entity.Core.Metadata.Edm.EdmFunction edmFunction;
			if (!this.TryGetFunctionImportStoreFunction(nav, out edmFunction))
			{
				return;
			}
			global::System.Data.Entity.Core.Metadata.Edm.EdmFunction edmFunction2;
			if (!this.TryGetFunctionImportModelFunction(nav, entityContainerMapping, out edmFunction2))
			{
				return;
			}
			if (!edmFunction2.IsComposableAttribute && edmFunction.IsComposableAttribute)
			{
				global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrorWithMessage(global::System.Data.Entity.Resources.Strings.Mapping_FunctionImport_TargetFunctionMustBeNonComposable(edmFunction2.FullName, edmFunction.FullName), global::System.Data.Entity.Core.Mapping.MappingErrorCode.MappingFunctionImportTargetFunctionMustBeNonComposable, this.m_sourceLocation, xmlLineInfo, this.m_parsingErrors);
				return;
			}
			if (edmFunction2.IsComposableAttribute && !edmFunction.IsComposableAttribute)
			{
				global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrorWithMessage(global::System.Data.Entity.Resources.Strings.Mapping_FunctionImport_TargetFunctionMustBeComposable(edmFunction2.FullName, edmFunction.FullName), global::System.Data.Entity.Core.Mapping.MappingErrorCode.MappingFunctionImportTargetFunctionMustBeComposable, this.m_sourceLocation, xmlLineInfo, this.m_parsingErrors);
				return;
			}
			this.ValidateFunctionImportMappingParameters(nav, edmFunction, edmFunction2);
			global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.FunctionImportStructuralTypeMapping>> list = new global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.FunctionImportStructuralTypeMapping>>();
			if (nav.MoveToChild(global::System.Xml.XPath.XPathNodeType.Element))
			{
				int num = 0;
				do
				{
					if (nav.LocalName == "ResultMapping")
					{
						global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.FunctionImportStructuralTypeMapping> functionImportMappingResultMapping = this.GetFunctionImportMappingResultMapping(nav.Clone(), xmlLineInfo, edmFunction2, num);
						list.Add(functionImportMappingResultMapping);
					}
					num++;
				}
				while (nav.MoveToNext(global::System.Xml.XPath.XPathNodeType.Element));
			}
			if (list.Count > 0 && list.Count != edmFunction2.ReturnParameters.Count)
			{
				global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrors(global::System.Data.Entity.Resources.Strings.Mapping_FunctionImport_ResultMappingCountDoesNotMatchResultCount(edmFunction2.Identity), global::System.Data.Entity.Core.Mapping.MappingErrorCode.FunctionResultMappingCountMismatch, this.m_sourceLocation, xmlLineInfo, this.m_parsingErrors);
				return;
			}
			if (!edmFunction2.IsComposableAttribute)
			{
				global::System.Data.Entity.Core.Mapping.FunctionImportMappingNonComposable functionImportMappingNonComposable = new global::System.Data.Entity.Core.Mapping.FunctionImportMappingNonComposable(edmFunction2, edmFunction, list, this.EdmItemCollection);
				foreach (global::System.Data.Entity.Core.Mapping.FunctionImportStructuralTypeMappingKB functionImportStructuralTypeMappingKB in functionImportMappingNonComposable.InternalResultMappings)
				{
					functionImportStructuralTypeMappingKB.ValidateTypeConditions(false, this.m_parsingErrors, this.m_sourceLocation);
				}
				for (int i = 0; i < functionImportMappingNonComposable.InternalResultMappings.Count; i++)
				{
					global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType;
					if (global::System.Data.Entity.Core.Common.Utils.MetadataHelper.TryGetFunctionImportReturnType<global::System.Data.Entity.Core.Metadata.Edm.EntityType>(edmFunction2, i, out entityType) && entityType.Abstract && functionImportMappingNonComposable.GetResultMapping(i).NormalizedEntityTypeMappings.Count == 0)
					{
						global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrorWithMemberAndStructure(new global::System.Func<object, object, string>(global::System.Data.Entity.Resources.Strings.Mapping_FunctionImport_ImplicitMappingForAbstractReturnType), entityType.FullName, edmFunction2.Identity, global::System.Data.Entity.Core.Mapping.MappingErrorCode.MappingOfAbstractType, this.m_sourceLocation, xmlLineInfo, this.m_parsingErrors);
					}
				}
				entityContainerMapping.AddFunctionImportMapping(functionImportMappingNonComposable);
				return;
			}
			global::System.Data.Entity.Core.Metadata.Edm.EdmFunction edmFunction3 = this.StoreItemCollection.ConvertToCTypeFunction(edmFunction);
			global::System.Data.Entity.Core.Metadata.Edm.RowType tvfReturnType = global::System.Data.Entity.Core.Common.TypeHelpers.GetTvfReturnType(edmFunction3);
			global::System.Data.Entity.Core.Metadata.Edm.RowType tvfReturnType2 = global::System.Data.Entity.Core.Common.TypeHelpers.GetTvfReturnType(edmFunction);
			if (tvfReturnType == null)
			{
				global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrors(global::System.Data.Entity.Resources.Strings.Mapping_FunctionImport_ResultMapping_InvalidSType(edmFunction2.Identity), global::System.Data.Entity.Core.Mapping.MappingErrorCode.MappingFunctionImportTVFExpected, this.m_sourceLocation, xmlLineInfo, this.m_parsingErrors);
				return;
			}
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.FunctionImportStructuralTypeMapping> typeMappings = (list.Count > 0) ? list[0] : new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.FunctionImportStructuralTypeMapping>();
			global::System.Data.Entity.Core.Mapping.FunctionImportMappingComposable functionImportMapping = null;
			global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType;
			if (global::System.Data.Entity.Core.Common.Utils.MetadataHelper.TryGetFunctionImportReturnType<global::System.Data.Entity.Core.Metadata.Edm.EdmType>(edmFunction2, 0, out edmType))
			{
				global::System.Data.Entity.Core.Mapping.FunctionImportMappingComposableHelper functionImportMappingComposableHelper = new global::System.Data.Entity.Core.Mapping.FunctionImportMappingComposableHelper(entityContainerMapping, this.m_sourceLocation, this.m_parsingErrors);
				if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsStructuralType(edmType))
				{
					if (!functionImportMappingComposableHelper.TryCreateFunctionImportMappingComposableWithStructuralResult(edmFunction2, edmFunction3, typeMappings, tvfReturnType, tvfReturnType2, xmlLineInfo, out functionImportMapping))
					{
						return;
					}
				}
				else if (!functionImportMappingComposableHelper.TryCreateFunctionImportMappingComposableWithScalarResult(edmFunction2, edmFunction3, edmFunction, edmType, tvfReturnType, xmlLineInfo, out functionImportMapping))
				{
					return;
				}
			}
			entityContainerMapping.AddFunctionImportMapping(functionImportMapping);
		}

		// Token: 0x06004279 RID: 17017 RVA: 0x000E24BC File Offset: 0x000E06BC
		private bool TryGetFunctionImportStoreFunction(global::System.Xml.XPath.XPathNavigator nav, out global::System.Data.Entity.Core.Metadata.Edm.EdmFunction targetFunction)
		{
			global::System.Xml.IXmlLineInfo lineInfo = (global::System.Xml.IXmlLineInfo)nav;
			targetFunction = null;
			string aliasResolvedAttributeValue = this.GetAliasResolvedAttributeValue(nav.Clone(), "FunctionName");
			global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction> functions = this.StoreItemCollection.GetFunctions(aliasResolvedAttributeValue);
			if (functions.Count == 0)
			{
				global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrorWithMessage(global::System.Data.Entity.Resources.Strings.Mapping_FunctionImport_StoreFunctionDoesNotExist(aliasResolvedAttributeValue), global::System.Data.Entity.Core.Mapping.MappingErrorCode.MappingFunctionImportStoreFunctionDoesNotExist, this.m_sourceLocation, lineInfo, this.m_parsingErrors);
				return false;
			}
			if (functions.Count > 1)
			{
				global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrorWithMessage(global::System.Data.Entity.Resources.Strings.Mapping_FunctionImport_FunctionAmbiguous(aliasResolvedAttributeValue), global::System.Data.Entity.Core.Mapping.MappingErrorCode.MappingFunctionImportStoreFunctionAmbiguous, this.m_sourceLocation, lineInfo, this.m_parsingErrors);
				return false;
			}
			targetFunction = functions.Single<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction>();
			return true;
		}

		// Token: 0x0600427A RID: 17018 RVA: 0x000E254C File Offset: 0x000E074C
		private bool TryGetFunctionImportModelFunction(global::System.Xml.XPath.XPathNavigator nav, global::System.Data.Entity.Core.Mapping.EntityContainerMapping entityContainerMapping, out global::System.Data.Entity.Core.Metadata.Edm.EdmFunction functionImport)
		{
			global::System.Xml.IXmlLineInfo lineInfo = (global::System.Xml.IXmlLineInfo)nav;
			string aliasResolvedAttributeValue = this.GetAliasResolvedAttributeValue(nav.Clone(), "FunctionImportName");
			global::System.Data.Entity.Core.Metadata.Edm.EntityContainer edmEntityContainer = entityContainerMapping.EdmEntityContainer;
			functionImport = null;
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmFunction edmFunction in edmEntityContainer.FunctionImports)
			{
				if (edmFunction.Name == aliasResolvedAttributeValue)
				{
					functionImport = edmFunction;
					break;
				}
			}
			if (functionImport == null)
			{
				global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrorWithMessage(global::System.Data.Entity.Resources.Strings.Mapping_FunctionImport_FunctionImportDoesNotExist(aliasResolvedAttributeValue, entityContainerMapping.EdmEntityContainer.Name), global::System.Data.Entity.Core.Mapping.MappingErrorCode.MappingFunctionImportFunctionImportDoesNotExist, this.m_sourceLocation, lineInfo, this.m_parsingErrors);
				return false;
			}
			global::System.Data.Entity.Core.Mapping.FunctionImportMapping functionImportMapping;
			if (entityContainerMapping.TryGetFunctionImportMapping(functionImport, out functionImportMapping))
			{
				global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrorWithMessage(global::System.Data.Entity.Resources.Strings.Mapping_FunctionImport_FunctionImportMappedMultipleTimes(aliasResolvedAttributeValue), global::System.Data.Entity.Core.Mapping.MappingErrorCode.MappingFunctionImportFunctionImportMappedMultipleTimes, this.m_sourceLocation, lineInfo, this.m_parsingErrors);
				return false;
			}
			return true;
		}

		// Token: 0x0600427B RID: 17019 RVA: 0x000E262C File Offset: 0x000E082C
		private void ValidateFunctionImportMappingParameters(global::System.Xml.XPath.XPathNavigator nav, global::System.Data.Entity.Core.Metadata.Edm.EdmFunction targetFunction, global::System.Data.Entity.Core.Metadata.Edm.EdmFunction functionImport)
		{
			global::System.Xml.IXmlLineInfo lineInfo = (global::System.Xml.IXmlLineInfo)nav;
			foreach (global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter functionParameter in targetFunction.Parameters)
			{
				global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter functionParameter2;
				if (!functionImport.Parameters.TryGetValue(functionParameter.Name, false, out functionParameter2))
				{
					global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrorWithMessage(global::System.Data.Entity.Resources.Strings.Mapping_FunctionImport_TargetParameterHasNoCorrespondingImportParameter(functionParameter.Name), global::System.Data.Entity.Core.Mapping.MappingErrorCode.MappingFunctionImportTargetParameterHasNoCorrespondingImportParameter, this.m_sourceLocation, lineInfo, this.m_parsingErrors);
				}
				else
				{
					if (functionParameter.Mode != functionParameter2.Mode)
					{
						global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrorWithMessage(global::System.Data.Entity.Resources.Strings.Mapping_FunctionImport_IncompatibleParameterMode(functionParameter.Name, functionParameter.Mode, functionParameter2.Mode), global::System.Data.Entity.Core.Mapping.MappingErrorCode.MappingFunctionImportIncompatibleParameterMode, this.m_sourceLocation, lineInfo, this.m_parsingErrors);
					}
					global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType primitiveType = global::System.Data.Entity.Core.Metadata.Edm.Helper.AsPrimitive(functionParameter2.TypeUsage.EdmType);
					if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsSpatialType(primitiveType))
					{
						primitiveType = global::System.Data.Entity.Core.Metadata.Edm.Helper.GetSpatialNormalizedPrimitiveType(primitiveType);
					}
					global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType primitiveType2 = (global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType)this.StoreItemCollection.ProviderManifest.GetEdmType(functionParameter.TypeUsage).EdmType;
					if (primitiveType2 == null)
					{
						global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrorWithMessage(global::System.Data.Entity.Resources.Strings.Mapping_ProviderReturnsNullType(functionParameter.Name), global::System.Data.Entity.Core.Mapping.MappingErrorCode.MappingStoreProviderReturnsNullEdmType, this.m_sourceLocation, lineInfo, this.m_parsingErrors);
						return;
					}
					if (primitiveType2.PrimitiveTypeKind != primitiveType.PrimitiveTypeKind)
					{
						global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrorWithMessage(global::System.Data.Entity.Core.Metadata.Edm.Helper.IsEnumType(functionParameter2.TypeUsage.EdmType) ? global::System.Data.Entity.Resources.Strings.Mapping_FunctionImport_IncompatibleEnumParameterType(functionParameter.Name, primitiveType2.Name, functionParameter2.TypeUsage.EdmType.FullName, global::System.Data.Entity.Core.Metadata.Edm.Helper.GetUnderlyingEdmTypeForEnumType(functionParameter2.TypeUsage.EdmType).Name) : global::System.Data.Entity.Resources.Strings.Mapping_FunctionImport_IncompatibleParameterType(functionParameter.Name, primitiveType2.Name, primitiveType.Name), global::System.Data.Entity.Core.Mapping.MappingErrorCode.MappingFunctionImportIncompatibleParameterType, this.m_sourceLocation, lineInfo, this.m_parsingErrors);
					}
				}
			}
			foreach (global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter functionParameter3 in functionImport.Parameters)
			{
				global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter functionParameter4;
				if (!targetFunction.Parameters.TryGetValue(functionParameter3.Name, false, out functionParameter4))
				{
					global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrorWithMessage(global::System.Data.Entity.Resources.Strings.Mapping_FunctionImport_ImportParameterHasNoCorrespondingTargetParameter(functionParameter3.Name), global::System.Data.Entity.Core.Mapping.MappingErrorCode.MappingFunctionImportImportParameterHasNoCorrespondingTargetParameter, this.m_sourceLocation, lineInfo, this.m_parsingErrors);
				}
			}
		}

		// Token: 0x0600427C RID: 17020 RVA: 0x000E2894 File Offset: 0x000E0A94
		private global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.FunctionImportStructuralTypeMapping> GetFunctionImportMappingResultMapping(global::System.Xml.XPath.XPathNavigator nav, global::System.Xml.IXmlLineInfo functionImportMappingLineInfo, global::System.Data.Entity.Core.Metadata.Edm.EdmFunction functionImport, int resultSetIndex)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.FunctionImportStructuralTypeMapping> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.FunctionImportStructuralTypeMapping>();
			if (nav.MoveToChild(global::System.Xml.XPath.XPathNodeType.Element))
			{
				do
				{
					global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet = (functionImport.EntitySets.Count > resultSetIndex) ? functionImport.EntitySets[resultSetIndex] : null;
					if (nav.LocalName == "EntityTypeMapping")
					{
						global::System.Data.Entity.Core.Metadata.Edm.EntityType resultEntityType;
						if (global::System.Data.Entity.Core.Common.Utils.MetadataHelper.TryGetFunctionImportReturnType<global::System.Data.Entity.Core.Metadata.Edm.EntityType>(functionImport, resultSetIndex, out resultEntityType))
						{
							if (entitySet == null)
							{
								global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrors(global::System.Data.Entity.Resources.Strings.Mapping_FunctionImport_EntityTypeMappingForFunctionNotReturningEntitySet("EntityTypeMapping", functionImport.Identity), global::System.Data.Entity.Core.Mapping.MappingErrorCode.MappingFunctionImportEntityTypeMappingForFunctionNotReturningEntitySet, this.m_sourceLocation, functionImportMappingLineInfo, this.m_parsingErrors);
							}
							global::System.Data.Entity.Core.Mapping.FunctionImportEntityTypeMapping item;
							if (this.TryLoadFunctionImportEntityTypeMapping(nav.Clone(), resultEntityType, (global::System.Data.Entity.Core.Metadata.Edm.EntityType e) => global::System.Data.Entity.Resources.Strings.Mapping_FunctionImport_InvalidContentEntityTypeForEntitySet(e.FullName, resultEntityType.FullName, entitySet.Name, functionImport.Identity), out item))
							{
								list.Add(item);
							}
						}
						else
						{
							global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrors(global::System.Data.Entity.Resources.Strings.Mapping_FunctionImport_ResultMapping_InvalidCTypeETExpected(functionImport.Identity), global::System.Data.Entity.Core.Mapping.MappingErrorCode.MappingFunctionImportUnexpectedEntityTypeMapping, this.m_sourceLocation, functionImportMappingLineInfo, this.m_parsingErrors);
						}
					}
					else if (nav.LocalName == "ComplexTypeMapping")
					{
						global::System.Data.Entity.Core.Metadata.Edm.ComplexType resultComplexType;
						if (global::System.Data.Entity.Core.Common.Utils.MetadataHelper.TryGetFunctionImportReturnType<global::System.Data.Entity.Core.Metadata.Edm.ComplexType>(functionImport, resultSetIndex, out resultComplexType))
						{
							global::System.Data.Entity.Core.Mapping.FunctionImportComplexTypeMapping item2;
							if (this.TryLoadFunctionImportComplexTypeMapping(nav.Clone(), resultComplexType, functionImport, out item2))
							{
								list.Add(item2);
							}
						}
						else
						{
							global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrors(global::System.Data.Entity.Resources.Strings.Mapping_FunctionImport_ResultMapping_InvalidCTypeCTExpected(functionImport.Identity), global::System.Data.Entity.Core.Mapping.MappingErrorCode.MappingFunctionImportUnexpectedComplexTypeMapping, this.m_sourceLocation, functionImportMappingLineInfo, this.m_parsingErrors);
						}
					}
				}
				while (nav.MoveToNext(global::System.Xml.XPath.XPathNodeType.Element));
			}
			return list;
		}

		// Token: 0x0600427D RID: 17021 RVA: 0x000E2A58 File Offset: 0x000E0C58
		private bool TryLoadFunctionImportComplexTypeMapping(global::System.Xml.XPath.XPathNavigator nav, global::System.Data.Entity.Core.Metadata.Edm.ComplexType resultComplexType, global::System.Data.Entity.Core.Metadata.Edm.EdmFunction functionImport, out global::System.Data.Entity.Core.Mapping.FunctionImportComplexTypeMapping typeMapping)
		{
			typeMapping = null;
			global::System.Data.Entity.Core.Mapping.LineInfo lineInfo = new global::System.Data.Entity.Core.Mapping.LineInfo(nav);
			global::System.Data.Entity.Core.Metadata.Edm.ComplexType complexType;
			if (!this.TryParseComplexTypeAttribute(nav, resultComplexType, functionImport, out complexType))
			{
				return false;
			}
			global::System.Collections.ObjectModel.Collection<global::System.Data.Entity.Core.Mapping.FunctionImportReturnTypePropertyMapping> collection = new global::System.Collections.ObjectModel.Collection<global::System.Data.Entity.Core.Mapping.FunctionImportReturnTypePropertyMapping>();
			if (!this.LoadFunctionImportStructuralType(nav.Clone(), new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.StructuralType>
			{
				complexType
			}, collection, null))
			{
				return false;
			}
			typeMapping = new global::System.Data.Entity.Core.Mapping.FunctionImportComplexTypeMapping(complexType, collection, lineInfo);
			return true;
		}

		// Token: 0x0600427E RID: 17022 RVA: 0x000E2AB0 File Offset: 0x000E0CB0
		private bool TryParseComplexTypeAttribute(global::System.Xml.XPath.XPathNavigator nav, global::System.Data.Entity.Core.Metadata.Edm.ComplexType resultComplexType, global::System.Data.Entity.Core.Metadata.Edm.EdmFunction functionImport, out global::System.Data.Entity.Core.Metadata.Edm.ComplexType complexType)
		{
			global::System.Xml.IXmlLineInfo lineInfo = (global::System.Xml.IXmlLineInfo)nav;
			string text = global::System.Data.Entity.Core.Mapping.MappingItemLoader.GetAttributeValue(nav.Clone(), "TypeName");
			text = this.GetAliasResolvedValue(text);
			if (!this.EdmItemCollection.TryGetItem<global::System.Data.Entity.Core.Metadata.Edm.ComplexType>(text, out complexType))
			{
				global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrorsWithMemberInfo(new global::System.Func<object, string>(global::System.Data.Entity.Resources.Strings.Mapping_InvalidContent_Complex_Type), text, global::System.Data.Entity.Core.Mapping.MappingErrorCode.InvalidComplexType, this.m_sourceLocation, lineInfo, this.m_parsingErrors);
				return false;
			}
			if (!global::System.Data.Entity.Core.Metadata.Edm.Helper.IsAssignableFrom(resultComplexType, complexType))
			{
				global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrorWithMessage(global::System.Data.Entity.Resources.Strings.Mapping_FunctionImport_ResultMapping_MappedTypeDoesNotMatchReturnType(functionImport.Identity, complexType.FullName), global::System.Data.Entity.Core.Mapping.MappingErrorCode.InvalidComplexType, this.m_sourceLocation, lineInfo, this.m_parsingErrors);
				return false;
			}
			return true;
		}

		// Token: 0x0600427F RID: 17023 RVA: 0x000E2B4C File Offset: 0x000E0D4C
		private bool TryLoadFunctionImportEntityTypeMapping(global::System.Xml.XPath.XPathNavigator nav, global::System.Data.Entity.Core.Metadata.Edm.EntityType resultEntityType, global::System.Func<global::System.Data.Entity.Core.Metadata.Edm.EntityType, string> registerEntityTypeMismatchError, out global::System.Data.Entity.Core.Mapping.FunctionImportEntityTypeMapping typeMapping)
		{
			typeMapping = null;
			global::System.Data.Entity.Core.Mapping.LineInfo lineInfo = new global::System.Data.Entity.Core.Mapping.LineInfo(nav);
			global::System.Data.Entity.Core.Mapping.MappingItemLoader.GetAttributeValue(nav.Clone(), "TypeName");
			global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.EntityType> set;
			global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.EntityType> set2;
			if (!this.TryParseEntityTypeAttribute(nav.Clone(), resultEntityType, registerEntityTypeMismatchError, out set, out set2))
			{
				return false;
			}
			global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.StructuralType> currentTypes = set.Concat(set2).Distinct<global::System.Data.Entity.Core.Metadata.Edm.EntityType>().OfType<global::System.Data.Entity.Core.Metadata.Edm.StructuralType>();
			global::System.Collections.ObjectModel.Collection<global::System.Data.Entity.Core.Mapping.FunctionImportReturnTypePropertyMapping> collection = new global::System.Collections.ObjectModel.Collection<global::System.Data.Entity.Core.Mapping.FunctionImportReturnTypePropertyMapping>();
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.FunctionImportEntityTypeMappingCondition> conditions = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.FunctionImportEntityTypeMappingCondition>();
			if (!this.LoadFunctionImportStructuralType(nav.Clone(), currentTypes, collection, conditions))
			{
				return false;
			}
			typeMapping = new global::System.Data.Entity.Core.Mapping.FunctionImportEntityTypeMapping(set, set2, conditions, collection, lineInfo);
			return true;
		}

		// Token: 0x06004280 RID: 17024 RVA: 0x000E2BD0 File Offset: 0x000E0DD0
		private bool LoadFunctionImportStructuralType(global::System.Xml.XPath.XPathNavigator nav, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.StructuralType> currentTypes, global::System.Collections.ObjectModel.Collection<global::System.Data.Entity.Core.Mapping.FunctionImportReturnTypePropertyMapping> columnRenameMappings, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.FunctionImportEntityTypeMappingCondition> conditions)
		{
			global::System.Xml.IXmlLineInfo lineInfo = (global::System.Xml.IXmlLineInfo)nav.Clone();
			if (nav.MoveToChild(global::System.Xml.XPath.XPathNodeType.Element))
			{
				do
				{
					if (nav.LocalName == "ScalarProperty")
					{
						this.LoadFunctionImportStructuralTypeMappingScalarProperty(nav, columnRenameMappings, currentTypes);
					}
					if (nav.LocalName == "Condition")
					{
						this.LoadFunctionImportEntityTypeMappingCondition(nav, conditions);
					}
				}
				while (nav.MoveToNext(global::System.Xml.XPath.XPathNodeType.Element));
			}
			bool flag = false;
			if (conditions != null)
			{
				global::System.Collections.Generic.HashSet<string> hashSet = new global::System.Collections.Generic.HashSet<string>();
				foreach (global::System.Data.Entity.Core.Mapping.FunctionImportEntityTypeMappingCondition functionImportEntityTypeMappingCondition in conditions)
				{
					if (!hashSet.Add(functionImportEntityTypeMappingCondition.ColumnName))
					{
						global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrorWithMessage(global::System.Data.Entity.Resources.Strings.Mapping_InvalidContent_Duplicate_Condition_Member(functionImportEntityTypeMappingCondition.ColumnName), global::System.Data.Entity.Core.Mapping.MappingErrorCode.ConditionError, this.m_sourceLocation, lineInfo, this.m_parsingErrors);
						flag = true;
					}
				}
			}
			return !flag;
		}

		// Token: 0x06004281 RID: 17025 RVA: 0x000E2CB4 File Offset: 0x000E0EB4
		private void LoadFunctionImportStructuralTypeMappingScalarProperty(global::System.Xml.XPath.XPathNavigator nav, global::System.Collections.ObjectModel.Collection<global::System.Data.Entity.Core.Mapping.FunctionImportReturnTypePropertyMapping> columnRenameMappings, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.StructuralType> currentTypes)
		{
			global::System.Data.Entity.Core.Mapping.LineInfo lineInfo = new global::System.Data.Entity.Core.Mapping.LineInfo(nav);
			string memberName = this.GetAliasResolvedAttributeValue(nav.Clone(), "Name");
			string aliasResolvedAttributeValue = this.GetAliasResolvedAttributeValue(nav.Clone(), "ColumnName");
			if (!currentTypes.All((global::System.Data.Entity.Core.Metadata.Edm.StructuralType t) => t.Members.Contains(memberName)))
			{
				global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrorWithMessage(global::System.Data.Entity.Resources.Strings.Mapping_InvalidContent_Cdm_Member(memberName), global::System.Data.Entity.Core.Mapping.MappingErrorCode.InvalidEdmMember, this.m_sourceLocation, lineInfo, this.m_parsingErrors);
			}
			if (columnRenameMappings.Any((global::System.Data.Entity.Core.Mapping.FunctionImportReturnTypePropertyMapping m) => m.CMember == memberName))
			{
				global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrorWithMessage(global::System.Data.Entity.Resources.Strings.Mapping_InvalidContent_Duplicate_Cdm_Member(memberName), global::System.Data.Entity.Core.Mapping.MappingErrorCode.DuplicateMemberMapping, this.m_sourceLocation, lineInfo, this.m_parsingErrors);
				return;
			}
			columnRenameMappings.Add(new global::System.Data.Entity.Core.Mapping.FunctionImportReturnTypeScalarPropertyMapping(memberName, aliasResolvedAttributeValue, lineInfo));
		}

		// Token: 0x06004282 RID: 17026 RVA: 0x000E2D78 File Offset: 0x000E0F78
		private void LoadFunctionImportEntityTypeMappingCondition(global::System.Xml.XPath.XPathNavigator nav, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.FunctionImportEntityTypeMappingCondition> conditions)
		{
			global::System.Data.Entity.Core.Mapping.LineInfo lineInfo = new global::System.Data.Entity.Core.Mapping.LineInfo(nav);
			string aliasResolvedAttributeValue = this.GetAliasResolvedAttributeValue(nav.Clone(), "ColumnName");
			string aliasResolvedAttributeValue2 = this.GetAliasResolvedAttributeValue(nav.Clone(), "Value");
			string aliasResolvedAttributeValue3 = this.GetAliasResolvedAttributeValue(nav.Clone(), "IsNull");
			if (aliasResolvedAttributeValue3 != null && aliasResolvedAttributeValue2 != null)
			{
				global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrors(global::System.Data.Entity.Resources.Strings.Mapping_InvalidContent_ConditionMapping_Both_Values, global::System.Data.Entity.Core.Mapping.MappingErrorCode.ConditionError, this.m_sourceLocation, lineInfo, this.m_parsingErrors);
				return;
			}
			if (aliasResolvedAttributeValue3 == null && aliasResolvedAttributeValue2 == null)
			{
				global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrors(global::System.Data.Entity.Resources.Strings.Mapping_InvalidContent_ConditionMapping_Either_Values, global::System.Data.Entity.Core.Mapping.MappingErrorCode.ConditionError, this.m_sourceLocation, lineInfo, this.m_parsingErrors);
				return;
			}
			if (aliasResolvedAttributeValue3 != null)
			{
				bool isNull = global::System.Convert.ToBoolean(aliasResolvedAttributeValue3, global::System.Globalization.CultureInfo.InvariantCulture);
				conditions.Add(new global::System.Data.Entity.Core.Mapping.FunctionImportEntityTypeMappingConditionIsNull(aliasResolvedAttributeValue, isNull, lineInfo));
				return;
			}
			global::System.Xml.XPath.XPathNavigator xpathNavigator = nav.Clone();
			xpathNavigator.MoveToAttribute("Value", string.Empty);
			conditions.Add(new global::System.Data.Entity.Core.Mapping.FunctionImportEntityTypeMappingConditionValue(aliasResolvedAttributeValue, xpathNavigator, lineInfo));
		}

		// Token: 0x06004283 RID: 17027 RVA: 0x000E2E54 File Offset: 0x000E1054
		private void LoadAssociationTypeMapping(global::System.Xml.XPath.XPathNavigator nav, global::System.Data.Entity.Core.Mapping.AssociationSetMapping associationSetMapping, string associationTypeName, string tableName, global::System.Data.Entity.Core.Metadata.Edm.EntityContainer storageEntityContainerType)
		{
			global::System.Xml.IXmlLineInfo lineInfo = (global::System.Xml.IXmlLineInfo)nav;
			global::System.Data.Entity.Core.Metadata.Edm.AssociationType associationType;
			this.EdmItemCollection.TryGetItem<global::System.Data.Entity.Core.Metadata.Edm.AssociationType>(associationTypeName, out associationType);
			if (associationType == null)
			{
				global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrorsWithMemberInfo(new global::System.Func<object, string>(global::System.Data.Entity.Resources.Strings.Mapping_InvalidContent_Association_Type), associationTypeName, global::System.Data.Entity.Core.Mapping.MappingErrorCode.InvalidAssociationType, this.m_sourceLocation, lineInfo, this.m_parsingErrors);
				return;
			}
			if (!associationSetMapping.Set.ElementType.Equals(associationType))
			{
				global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrorWithMessage(global::System.Data.Entity.Resources.Strings.Mapping_Invalid_Association_Type_For_Association_Set(associationTypeName, associationSetMapping.Set.ElementType.FullName, associationSetMapping.Set.Name), global::System.Data.Entity.Core.Mapping.MappingErrorCode.DuplicateTypeMapping, this.m_sourceLocation, lineInfo, this.m_parsingErrors);
				return;
			}
			global::System.Data.Entity.Core.Mapping.AssociationTypeMapping associationTypeMapping = new global::System.Data.Entity.Core.Mapping.AssociationTypeMapping(associationType, associationSetMapping);
			associationSetMapping.AssociationTypeMapping = associationTypeMapping;
			if (string.IsNullOrEmpty(tableName) && associationSetMapping.QueryView == null)
			{
				global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrors(global::System.Data.Entity.Resources.Strings.Mapping_InvalidContent_Table_Expected, global::System.Data.Entity.Core.Mapping.MappingErrorCode.InvalidTable, this.m_sourceLocation, lineInfo, this.m_parsingErrors);
				return;
			}
			global::System.Data.Entity.Core.Mapping.MappingFragment mappingFragment = this.LoadAssociationMappingFragment(nav.Clone(), associationSetMapping, associationTypeMapping, tableName, storageEntityContainerType);
			if (mappingFragment != null)
			{
				associationTypeMapping.MappingFragment = mappingFragment;
			}
		}

		// Token: 0x06004284 RID: 17028 RVA: 0x000E2F48 File Offset: 0x000E1148
		private void LoadAssociationTypeModificationFunctionMapping(global::System.Xml.XPath.XPathNavigator nav, global::System.Data.Entity.Core.Mapping.AssociationSetMapping associationSetMapping)
		{
			global::System.Data.Entity.Core.Mapping.MappingItemLoader.ModificationFunctionMappingLoader modificationFunctionMappingLoader = new global::System.Data.Entity.Core.Mapping.MappingItemLoader.ModificationFunctionMappingLoader(this, associationSetMapping.Set);
			global::System.Data.Entity.Core.Mapping.ModificationFunctionMapping deleteFunctionMapping = null;
			global::System.Data.Entity.Core.Mapping.ModificationFunctionMapping insertFunctionMapping = null;
			if (nav.MoveToChild(global::System.Xml.XPath.XPathNodeType.Element))
			{
				do
				{
					string localName = nav.LocalName;
					if (localName != null)
					{
						if (!(localName == "DeleteFunction"))
						{
							if (localName == "InsertFunction")
							{
								insertFunctionMapping = modificationFunctionMappingLoader.LoadAssociationSetModificationFunctionMapping(nav.Clone(), associationSetMapping.Set, true);
							}
						}
						else
						{
							deleteFunctionMapping = modificationFunctionMappingLoader.LoadAssociationSetModificationFunctionMapping(nav.Clone(), associationSetMapping.Set, false);
						}
					}
				}
				while (nav.MoveToNext(global::System.Xml.XPath.XPathNodeType.Element));
			}
			associationSetMapping.ModificationFunctionMapping = new global::System.Data.Entity.Core.Mapping.AssociationSetModificationFunctionMapping((global::System.Data.Entity.Core.Metadata.Edm.AssociationSet)associationSetMapping.Set, deleteFunctionMapping, insertFunctionMapping);
		}

		// Token: 0x06004285 RID: 17029 RVA: 0x000E2FE0 File Offset: 0x000E11E0
		private global::System.Data.Entity.Core.Mapping.MappingFragment LoadMappingFragment(global::System.Xml.XPath.XPathNavigator nav, global::System.Data.Entity.Core.Mapping.EntityTypeMapping typeMapping, string tableName, global::System.Data.Entity.Core.Metadata.Edm.EntityContainer storageEntityContainerType, bool distinctFlag)
		{
			global::System.Xml.IXmlLineInfo navLineInfo = (global::System.Xml.IXmlLineInfo)nav;
			if (typeMapping.SetMapping.QueryView != null)
			{
				global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrorsWithMemberInfo(new global::System.Func<object, string>(global::System.Data.Entity.Resources.Strings.Mapping_QueryView_PropertyMaps), typeMapping.SetMapping.Set.Name, global::System.Data.Entity.Core.Mapping.MappingErrorCode.PropertyMapsWithQueryView, this.m_sourceLocation, navLineInfo, this.m_parsingErrors);
				return null;
			}
			global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet;
			storageEntityContainerType.TryGetEntitySetByName(tableName, false, out entitySet);
			if (entitySet == null)
			{
				global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrorsWithMemberInfo(new global::System.Func<object, string>(global::System.Data.Entity.Resources.Strings.Mapping_InvalidContent_Table), tableName, global::System.Data.Entity.Core.Mapping.MappingErrorCode.InvalidTable, this.m_sourceLocation, navLineInfo, this.m_parsingErrors);
				return null;
			}
			global::System.Data.Entity.Core.Metadata.Edm.EntityType elementType = entitySet.ElementType;
			global::System.Data.Entity.Core.Mapping.MappingFragment mappingFragment = new global::System.Data.Entity.Core.Mapping.MappingFragment(entitySet, typeMapping, distinctFlag);
			mappingFragment.StartLineNumber = navLineInfo.LineNumber;
			mappingFragment.StartLinePosition = navLineInfo.LinePosition;
			if (nav.MoveToChild(global::System.Xml.XPath.XPathNodeType.Element))
			{
				global::System.Action<global::System.Data.Entity.Core.Metadata.Edm.EdmMember> <>9__0;
				for (;;)
				{
					global::System.Data.Entity.Core.Metadata.Edm.EdmType containerType = null;
					string attributeValue = global::System.Data.Entity.Core.Mapping.MappingItemLoader.GetAttributeValue(nav.Clone(), "Name");
					if (attributeValue != null)
					{
						containerType = typeMapping.GetContainerType(attributeValue);
					}
					string localName = nav.LocalName;
					if (localName == null)
					{
						goto IL_1CF;
					}
					if (!(localName == "ScalarProperty"))
					{
						if (!(localName == "ComplexProperty"))
						{
							if (!(localName == "Condition"))
							{
								goto IL_1CF;
							}
							global::System.Data.Entity.Core.Mapping.ConditionPropertyMapping conditionPropertyMapping = this.LoadConditionPropertyMapping(nav.Clone(), containerType, elementType.Properties);
							if (conditionPropertyMapping != null)
							{
								global::System.Data.Entity.Core.Mapping.MappingFragment mappingFragment2 = mappingFragment;
								global::System.Data.Entity.Core.Mapping.ConditionPropertyMapping conditionPropertyMap = conditionPropertyMapping;
								global::System.Action<global::System.Data.Entity.Core.Metadata.Edm.EdmMember> duplicateMemberConditionError;
								if ((duplicateMemberConditionError = <>9__0) == null)
								{
									duplicateMemberConditionError = (<>9__0 = delegate(global::System.Data.Entity.Core.Metadata.Edm.EdmMember member)
									{
										global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrorsWithMemberInfo(new global::System.Func<object, string>(global::System.Data.Entity.Resources.Strings.Mapping_InvalidContent_Duplicate_Condition_Member), member.Name, global::System.Data.Entity.Core.Mapping.MappingErrorCode.ConditionError, this.m_sourceLocation, navLineInfo, this.m_parsingErrors);
									});
								}
								mappingFragment2.AddConditionProperty(conditionPropertyMap, duplicateMemberConditionError);
							}
						}
						else
						{
							global::System.Data.Entity.Core.Mapping.ComplexPropertyMapping complexPropertyMapping = this.LoadComplexPropertyMapping(nav.Clone(), containerType, elementType.Properties);
							if (complexPropertyMapping != null)
							{
								mappingFragment.AddPropertyMapping(complexPropertyMapping);
							}
						}
					}
					else
					{
						global::System.Data.Entity.Core.Mapping.ScalarPropertyMapping scalarPropertyMapping = this.LoadScalarPropertyMapping(nav.Clone(), containerType, elementType.Properties);
						if (scalarPropertyMapping != null)
						{
							mappingFragment.AddPropertyMapping(scalarPropertyMapping);
						}
					}
					IL_1F0:
					if (!nav.MoveToNext(global::System.Xml.XPath.XPathNodeType.Element))
					{
						break;
					}
					continue;
					IL_1CF:
					global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrors(global::System.Data.Entity.Resources.Strings.Mapping_InvalidContent_General, global::System.Data.Entity.Core.Mapping.MappingErrorCode.InvalidContent, this.m_sourceLocation, navLineInfo, this.m_parsingErrors);
					goto IL_1F0;
				}
			}
			nav.MoveToChild(global::System.Xml.XPath.XPathNodeType.Element);
			return mappingFragment;
		}

		// Token: 0x06004286 RID: 17030 RVA: 0x000E31F4 File Offset: 0x000E13F4
		private global::System.Data.Entity.Core.Mapping.MappingFragment LoadAssociationMappingFragment(global::System.Xml.XPath.XPathNavigator nav, global::System.Data.Entity.Core.Mapping.AssociationSetMapping setMapping, global::System.Data.Entity.Core.Mapping.AssociationTypeMapping typeMapping, string tableName, global::System.Data.Entity.Core.Metadata.Edm.EntityContainer storageEntityContainerType)
		{
			global::System.Xml.IXmlLineInfo navLineInfo = (global::System.Xml.IXmlLineInfo)nav;
			global::System.Data.Entity.Core.Mapping.MappingFragment mappingFragment = null;
			global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType = null;
			if (setMapping.QueryView == null)
			{
				global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet;
				storageEntityContainerType.TryGetEntitySetByName(tableName, false, out entitySet);
				if (entitySet == null)
				{
					global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrorsWithMemberInfo(new global::System.Func<object, string>(global::System.Data.Entity.Resources.Strings.Mapping_InvalidContent_Table), tableName, global::System.Data.Entity.Core.Mapping.MappingErrorCode.InvalidTable, this.m_sourceLocation, navLineInfo, this.m_parsingErrors);
					return null;
				}
				entityType = entitySet.ElementType;
				mappingFragment = new global::System.Data.Entity.Core.Mapping.MappingFragment(entitySet, typeMapping, false);
				mappingFragment.StartLineNumber = setMapping.StartLineNumber;
				mappingFragment.StartLinePosition = setMapping.StartLinePosition;
			}
			global::System.Action<global::System.Data.Entity.Core.Metadata.Edm.EdmMember> <>9__0;
			for (;;)
			{
				string localName = nav.LocalName;
				if (localName == null)
				{
					goto IL_227;
				}
				if (!(localName == "EndProperty"))
				{
					if (!(localName == "Condition"))
					{
						if (!(localName == "ModificationFunctionMapping"))
						{
							goto IL_227;
						}
						setMapping.HasModificationFunctionMapping = true;
						this.LoadAssociationTypeModificationFunctionMapping(nav.Clone(), setMapping);
					}
					else
					{
						if (setMapping.QueryView != null)
						{
							goto Block_9;
						}
						global::System.Data.Entity.Core.Mapping.ConditionPropertyMapping conditionPropertyMapping = this.LoadConditionPropertyMapping(nav.Clone(), null, entityType.Properties);
						if (conditionPropertyMapping != null)
						{
							global::System.Data.Entity.Core.Mapping.MappingFragment mappingFragment2 = mappingFragment;
							global::System.Data.Entity.Core.Mapping.ConditionPropertyMapping conditionPropertyMap = conditionPropertyMapping;
							global::System.Action<global::System.Data.Entity.Core.Metadata.Edm.EdmMember> duplicateMemberConditionError;
							if ((duplicateMemberConditionError = <>9__0) == null)
							{
								duplicateMemberConditionError = (<>9__0 = delegate(global::System.Data.Entity.Core.Metadata.Edm.EdmMember member)
								{
									global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrorsWithMemberInfo(new global::System.Func<object, string>(global::System.Data.Entity.Resources.Strings.Mapping_InvalidContent_Duplicate_Condition_Member), member.Name, global::System.Data.Entity.Core.Mapping.MappingErrorCode.ConditionError, this.m_sourceLocation, navLineInfo, this.m_parsingErrors);
								});
							}
							mappingFragment2.AddConditionProperty(conditionPropertyMap, duplicateMemberConditionError);
						}
					}
				}
				else
				{
					if (setMapping.QueryView != null)
					{
						break;
					}
					string aliasResolvedAttributeValue = this.GetAliasResolvedAttributeValue(nav.Clone(), "Name");
					global::System.Data.Entity.Core.Metadata.Edm.EdmMember edmMember = null;
					typeMapping.AssociationType.Members.TryGetValue(aliasResolvedAttributeValue, false, out edmMember);
					global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember associationEndMember = edmMember as global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember;
					if (associationEndMember == null)
					{
						global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrorsWithMemberInfo(new global::System.Func<object, string>(global::System.Data.Entity.Resources.Strings.Mapping_InvalidContent_End), aliasResolvedAttributeValue, global::System.Data.Entity.Core.Mapping.MappingErrorCode.InvalidEdmMember, this.m_sourceLocation, navLineInfo, this.m_parsingErrors);
					}
					else
					{
						mappingFragment.AddPropertyMapping(this.LoadEndPropertyMapping(nav.Clone(), associationEndMember, entityType));
					}
				}
				IL_248:
				if (!nav.MoveToNext(global::System.Xml.XPath.XPathNodeType.Element))
				{
					return mappingFragment;
				}
				continue;
				IL_227:
				global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrors(global::System.Data.Entity.Resources.Strings.Mapping_InvalidContent_General, global::System.Data.Entity.Core.Mapping.MappingErrorCode.InvalidContent, this.m_sourceLocation, navLineInfo, this.m_parsingErrors);
				goto IL_248;
			}
			global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrorsWithMemberInfo(new global::System.Func<object, string>(global::System.Data.Entity.Resources.Strings.Mapping_QueryView_PropertyMaps), setMapping.Set.Name, global::System.Data.Entity.Core.Mapping.MappingErrorCode.PropertyMapsWithQueryView, this.m_sourceLocation, navLineInfo, this.m_parsingErrors);
			return null;
			Block_9:
			global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrorsWithMemberInfo(new global::System.Func<object, string>(global::System.Data.Entity.Resources.Strings.Mapping_QueryView_PropertyMaps), setMapping.Set.Name, global::System.Data.Entity.Core.Mapping.MappingErrorCode.PropertyMapsWithQueryView, this.m_sourceLocation, navLineInfo, this.m_parsingErrors);
			return null;
		}

		// Token: 0x06004287 RID: 17031 RVA: 0x000E3458 File Offset: 0x000E1658
		private global::System.Data.Entity.Core.Mapping.ScalarPropertyMapping LoadScalarPropertyMapping(global::System.Xml.XPath.XPathNavigator nav, global::System.Data.Entity.Core.Metadata.Edm.EdmType containerType, global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> tableProperties)
		{
			global::System.Xml.IXmlLineInfo xmlLineInfo = (global::System.Xml.IXmlLineInfo)nav;
			string aliasResolvedAttributeValue = this.GetAliasResolvedAttributeValue(nav.Clone(), "Name");
			global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty = null;
			if (!string.IsNullOrEmpty(aliasResolvedAttributeValue) && (containerType == null || !global::System.Data.Entity.Core.Metadata.Edm.Helper.IsCollectionType(containerType)))
			{
				if (containerType != null)
				{
					if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsRefType(containerType))
					{
						((global::System.Data.Entity.Core.Metadata.Edm.EntityType)((global::System.Data.Entity.Core.Metadata.Edm.RefType)containerType).ElementType).Properties.TryGetValue(aliasResolvedAttributeValue, false, out edmProperty);
					}
					else
					{
						global::System.Data.Entity.Core.Metadata.Edm.EdmMember edmMember;
						(containerType as global::System.Data.Entity.Core.Metadata.Edm.StructuralType).Members.TryGetValue(aliasResolvedAttributeValue, false, out edmMember);
						edmProperty = (edmMember as global::System.Data.Entity.Core.Metadata.Edm.EdmProperty);
					}
				}
				if (edmProperty == null)
				{
					global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrorsWithMemberInfo(new global::System.Func<object, string>(global::System.Data.Entity.Resources.Strings.Mapping_InvalidContent_Cdm_Member), aliasResolvedAttributeValue, global::System.Data.Entity.Core.Mapping.MappingErrorCode.InvalidEdmMember, this.m_sourceLocation, xmlLineInfo, this.m_parsingErrors);
				}
			}
			string aliasResolvedAttributeValue2 = this.GetAliasResolvedAttributeValue(nav.Clone(), "ColumnName");
			global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty2;
			tableProperties.TryGetValue(aliasResolvedAttributeValue2, false, out edmProperty2);
			if (edmProperty2 == null)
			{
				global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrorsWithMemberInfo(new global::System.Func<object, string>(global::System.Data.Entity.Resources.Strings.Mapping_InvalidContent_Column), aliasResolvedAttributeValue2, global::System.Data.Entity.Core.Mapping.MappingErrorCode.InvalidStorageMember, this.m_sourceLocation, xmlLineInfo, this.m_parsingErrors);
			}
			if (edmProperty == null || edmProperty2 == null)
			{
				return null;
			}
			if (!global::System.Data.Entity.Core.Metadata.Edm.Helper.IsScalarType(edmProperty.TypeUsage.EdmType))
			{
				global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError item = new global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError(global::System.Data.Entity.Resources.Strings.Mapping_Invalid_CSide_ScalarProperty(edmProperty.Name), 2085, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, this.m_sourceLocation, xmlLineInfo.LineNumber, xmlLineInfo.LinePosition);
				this.m_parsingErrors.Add(item);
				return null;
			}
			this.ValidateAndUpdateScalarMemberMapping(edmProperty, edmProperty2, xmlLineInfo);
			return new global::System.Data.Entity.Core.Mapping.ScalarPropertyMapping(edmProperty, edmProperty2);
		}

		// Token: 0x06004288 RID: 17032 RVA: 0x000E35B0 File Offset: 0x000E17B0
		private global::System.Data.Entity.Core.Mapping.ComplexPropertyMapping LoadComplexPropertyMapping(global::System.Xml.XPath.XPathNavigator nav, global::System.Data.Entity.Core.Metadata.Edm.EdmType containerType, global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> tableProperties)
		{
			global::System.Xml.IXmlLineInfo lineInfo = (global::System.Xml.IXmlLineInfo)nav;
			global::System.Data.Entity.Core.Metadata.Edm.CollectionType collectionType = containerType as global::System.Data.Entity.Core.Metadata.Edm.CollectionType;
			string aliasResolvedAttributeValue = this.GetAliasResolvedAttributeValue(nav.Clone(), "Name");
			global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty = null;
			global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType = null;
			string aliasResolvedAttributeValue2 = this.GetAliasResolvedAttributeValue(nav.Clone(), "TypeName");
			global::System.Data.Entity.Core.Metadata.Edm.StructuralType structuralType = containerType as global::System.Data.Entity.Core.Metadata.Edm.StructuralType;
			if (string.IsNullOrEmpty(aliasResolvedAttributeValue2))
			{
				if (collectionType == null)
				{
					if (structuralType != null)
					{
						global::System.Data.Entity.Core.Metadata.Edm.EdmMember edmMember;
						structuralType.Members.TryGetValue(aliasResolvedAttributeValue, false, out edmMember);
						edmProperty = (edmMember as global::System.Data.Entity.Core.Metadata.Edm.EdmProperty);
						if (edmProperty == null)
						{
							global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrorsWithMemberInfo(new global::System.Func<object, string>(global::System.Data.Entity.Resources.Strings.Mapping_InvalidContent_Cdm_Member), aliasResolvedAttributeValue, global::System.Data.Entity.Core.Mapping.MappingErrorCode.InvalidEdmMember, this.m_sourceLocation, lineInfo, this.m_parsingErrors);
						}
						edmType = edmProperty.TypeUsage.EdmType;
					}
					else
					{
						global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrorsWithMemberInfo(new global::System.Func<object, string>(global::System.Data.Entity.Resources.Strings.Mapping_InvalidContent_Cdm_Member), aliasResolvedAttributeValue, global::System.Data.Entity.Core.Mapping.MappingErrorCode.InvalidEdmMember, this.m_sourceLocation, lineInfo, this.m_parsingErrors);
					}
				}
				else
				{
					edmType = collectionType.TypeUsage.EdmType;
				}
			}
			else
			{
				if (containerType != null)
				{
					global::System.Data.Entity.Core.Metadata.Edm.EdmMember edmMember2;
					structuralType.Members.TryGetValue(aliasResolvedAttributeValue, false, out edmMember2);
					edmProperty = (edmMember2 as global::System.Data.Entity.Core.Metadata.Edm.EdmProperty);
				}
				if (edmProperty == null)
				{
					global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrorsWithMemberInfo(new global::System.Func<object, string>(global::System.Data.Entity.Resources.Strings.Mapping_InvalidContent_Cdm_Member), aliasResolvedAttributeValue, global::System.Data.Entity.Core.Mapping.MappingErrorCode.InvalidEdmMember, this.m_sourceLocation, lineInfo, this.m_parsingErrors);
				}
				this.EdmItemCollection.TryGetItem<global::System.Data.Entity.Core.Metadata.Edm.EdmType>(aliasResolvedAttributeValue2, out edmType);
				edmType = (edmType as global::System.Data.Entity.Core.Metadata.Edm.ComplexType);
				if (edmType == null)
				{
					global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrorsWithMemberInfo(new global::System.Func<object, string>(global::System.Data.Entity.Resources.Strings.Mapping_InvalidContent_Complex_Type), aliasResolvedAttributeValue2, global::System.Data.Entity.Core.Mapping.MappingErrorCode.InvalidComplexType, this.m_sourceLocation, lineInfo, this.m_parsingErrors);
				}
			}
			global::System.Data.Entity.Core.Mapping.ComplexPropertyMapping complexPropertyMapping = new global::System.Data.Entity.Core.Mapping.ComplexPropertyMapping(edmProperty);
			global::System.Xml.XPath.XPathNavigator xpathNavigator = nav.Clone();
			bool flag = false;
			if (xpathNavigator.MoveToChild(global::System.Xml.XPath.XPathNodeType.Element) && xpathNavigator.LocalName == "ComplexTypeMapping")
			{
				flag = true;
			}
			if (edmProperty == null || edmType == null)
			{
				return null;
			}
			if (flag)
			{
				nav.MoveToChild(global::System.Xml.XPath.XPathNodeType.Element);
				do
				{
					complexPropertyMapping.AddTypeMapping(this.LoadComplexTypeMapping(nav.Clone(), null, tableProperties));
				}
				while (nav.MoveToNext(global::System.Xml.XPath.XPathNodeType.Element));
			}
			else
			{
				complexPropertyMapping.AddTypeMapping(this.LoadComplexTypeMapping(nav.Clone(), edmType, tableProperties));
			}
			return complexPropertyMapping;
		}

		// Token: 0x06004289 RID: 17033 RVA: 0x000E37AC File Offset: 0x000E19AC
		private global::System.Data.Entity.Core.Mapping.ComplexTypeMapping LoadComplexTypeMapping(global::System.Xml.XPath.XPathNavigator nav, global::System.Data.Entity.Core.Metadata.Edm.EdmType type, global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> tableType)
		{
			bool isPartial = false;
			string attributeValue = global::System.Data.Entity.Core.Mapping.MappingItemLoader.GetAttributeValue(nav.Clone(), "IsPartial");
			if (!string.IsNullOrEmpty(attributeValue))
			{
				isPartial = global::System.Convert.ToBoolean(attributeValue, global::System.Globalization.CultureInfo.InvariantCulture);
			}
			global::System.Data.Entity.Core.Mapping.ComplexTypeMapping complexTypeMapping = new global::System.Data.Entity.Core.Mapping.ComplexTypeMapping(isPartial);
			if (type != null)
			{
				complexTypeMapping.AddType(type as global::System.Data.Entity.Core.Metadata.Edm.ComplexType);
			}
			else
			{
				string text = this.GetAliasResolvedAttributeValue(nav.Clone(), "TypeName");
				int num = text.IndexOf(';');
				do
				{
					string text2;
					if (num != -1)
					{
						text2 = text.Substring(0, num);
						text = text.Substring(num + 1, text.Length - (num + 1));
					}
					else
					{
						text2 = text;
						text = string.Empty;
					}
					int num2 = text2.IndexOf("IsTypeOf(", global::System.StringComparison.Ordinal);
					if (num2 == 0)
					{
						text2 = text2.Substring("IsTypeOf(".Length, text2.Length - ("IsTypeOf(".Length + 1));
						text2 = this.GetAliasResolvedValue(text2);
					}
					else
					{
						text2 = this.GetAliasResolvedValue(text2);
					}
					global::System.Data.Entity.Core.Metadata.Edm.ComplexType complexType;
					this.EdmItemCollection.TryGetItem<global::System.Data.Entity.Core.Metadata.Edm.ComplexType>(text2, out complexType);
					if (complexType == null)
					{
						global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrorsWithMemberInfo(new global::System.Func<object, string>(global::System.Data.Entity.Resources.Strings.Mapping_InvalidContent_Complex_Type), text2, global::System.Data.Entity.Core.Mapping.MappingErrorCode.InvalidComplexType, this.m_sourceLocation, (global::System.Xml.IXmlLineInfo)nav, this.m_parsingErrors);
						num = text.IndexOf(';');
					}
					else
					{
						if (num2 == 0)
						{
							complexTypeMapping.AddIsOfType(complexType);
						}
						else
						{
							complexTypeMapping.AddType(complexType);
						}
						num = text.IndexOf(';');
					}
				}
				while (text.Length != 0);
			}
			if (nav.MoveToChild(global::System.Xml.XPath.XPathNodeType.Element))
			{
				global::System.Action<global::System.Data.Entity.Core.Metadata.Edm.EdmMember> <>9__0;
				for (;;)
				{
					global::System.Data.Entity.Core.Metadata.Edm.EdmType ownerType = complexTypeMapping.GetOwnerType(global::System.Data.Entity.Core.Mapping.MappingItemLoader.GetAttributeValue(nav.Clone(), "Name"));
					string localName = nav.LocalName;
					if (localName == null)
					{
						break;
					}
					if (!(localName == "ScalarProperty"))
					{
						if (!(localName == "ComplexProperty"))
						{
							if (!(localName == "Condition"))
							{
								break;
							}
							global::System.Data.Entity.Core.Mapping.ConditionPropertyMapping conditionPropertyMapping = this.LoadConditionPropertyMapping(nav.Clone(), ownerType, tableType);
							if (conditionPropertyMapping != null)
							{
								global::System.Data.Entity.Core.Mapping.ComplexTypeMapping complexTypeMapping2 = complexTypeMapping;
								global::System.Data.Entity.Core.Mapping.ConditionPropertyMapping conditionPropertyMap = conditionPropertyMapping;
								global::System.Action<global::System.Data.Entity.Core.Metadata.Edm.EdmMember> duplicateMemberConditionError;
								if ((duplicateMemberConditionError = <>9__0) == null)
								{
									duplicateMemberConditionError = (<>9__0 = delegate(global::System.Data.Entity.Core.Metadata.Edm.EdmMember member)
									{
										global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrorsWithMemberInfo(new global::System.Func<object, string>(global::System.Data.Entity.Resources.Strings.Mapping_InvalidContent_Duplicate_Condition_Member), member.Name, global::System.Data.Entity.Core.Mapping.MappingErrorCode.ConditionError, this.m_sourceLocation, (global::System.Xml.IXmlLineInfo)nav, this.m_parsingErrors);
									});
								}
								complexTypeMapping2.AddConditionProperty(conditionPropertyMap, duplicateMemberConditionError);
							}
						}
						else
						{
							global::System.Data.Entity.Core.Mapping.ComplexPropertyMapping complexPropertyMapping = this.LoadComplexPropertyMapping(nav.Clone(), ownerType, tableType);
							if (complexPropertyMapping != null)
							{
								complexTypeMapping.AddPropertyMapping(complexPropertyMapping);
							}
						}
					}
					else
					{
						global::System.Data.Entity.Core.Mapping.ScalarPropertyMapping scalarPropertyMapping = this.LoadScalarPropertyMapping(nav.Clone(), ownerType, tableType);
						if (scalarPropertyMapping != null)
						{
							complexTypeMapping.AddPropertyMapping(scalarPropertyMapping);
						}
					}
					if (!nav.MoveToNext(global::System.Xml.XPath.XPathNodeType.Element))
					{
						return complexTypeMapping;
					}
				}
				throw global::System.Data.Entity.Resources.Error.NotSupported();
			}
			return complexTypeMapping;
		}

		// Token: 0x0600428A RID: 17034 RVA: 0x000E3A58 File Offset: 0x000E1C58
		private global::System.Data.Entity.Core.Mapping.EndPropertyMapping LoadEndPropertyMapping(global::System.Xml.XPath.XPathNavigator nav, global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember end, global::System.Data.Entity.Core.Metadata.Edm.EntityType tableType)
		{
			global::System.Data.Entity.Core.Mapping.EndPropertyMapping endPropertyMapping = new global::System.Data.Entity.Core.Mapping.EndPropertyMapping
			{
				AssociationEnd = end
			};
			nav.MoveToChild(global::System.Xml.XPath.XPathNodeType.Element);
			global::System.Data.Entity.Core.Mapping.ScalarPropertyMapping scalarPropertyMapping;
			for (;;)
			{
				string localName = nav.LocalName;
				if (localName != null && localName == "ScalarProperty")
				{
					global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase elementType = (end.TypeUsage.EdmType as global::System.Data.Entity.Core.Metadata.Edm.RefType).ElementType;
					scalarPropertyMapping = this.LoadScalarPropertyMapping(nav.Clone(), elementType, tableType.Properties);
					if (scalarPropertyMapping != null)
					{
						if (!elementType.KeyMembers.Contains(scalarPropertyMapping.Property))
						{
							break;
						}
						endPropertyMapping.AddPropertyMapping(scalarPropertyMapping);
					}
				}
				if (!nav.MoveToNext(global::System.Xml.XPath.XPathNodeType.Element))
				{
					return endPropertyMapping;
				}
			}
			global::System.Xml.IXmlLineInfo lineInfo = (global::System.Xml.IXmlLineInfo)nav;
			global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrorsWithMemberInfo(new global::System.Func<object, string>(global::System.Data.Entity.Resources.Strings.Mapping_InvalidContent_EndProperty), scalarPropertyMapping.Property.Name, global::System.Data.Entity.Core.Mapping.MappingErrorCode.InvalidEdmMember, this.m_sourceLocation, lineInfo, this.m_parsingErrors);
			return null;
		}

		// Token: 0x0600428B RID: 17035 RVA: 0x000E3B28 File Offset: 0x000E1D28
		private global::System.Data.Entity.Core.Mapping.ConditionPropertyMapping LoadConditionPropertyMapping(global::System.Xml.XPath.XPathNavigator nav, global::System.Data.Entity.Core.Metadata.Edm.EdmType containerType, global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> tableProperties)
		{
			string aliasResolvedAttributeValue = this.GetAliasResolvedAttributeValue(nav.Clone(), "Name");
			string aliasResolvedAttributeValue2 = this.GetAliasResolvedAttributeValue(nav.Clone(), "ColumnName");
			global::System.Xml.IXmlLineInfo lineInfo = (global::System.Xml.IXmlLineInfo)nav;
			if (aliasResolvedAttributeValue != null && aliasResolvedAttributeValue2 != null)
			{
				global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrors(global::System.Data.Entity.Resources.Strings.Mapping_InvalidContent_ConditionMapping_Both_Members, global::System.Data.Entity.Core.Mapping.MappingErrorCode.ConditionError, this.m_sourceLocation, lineInfo, this.m_parsingErrors);
				return null;
			}
			if (aliasResolvedAttributeValue == null && aliasResolvedAttributeValue2 == null)
			{
				global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrors(global::System.Data.Entity.Resources.Strings.Mapping_InvalidContent_ConditionMapping_Either_Members, global::System.Data.Entity.Core.Mapping.MappingErrorCode.ConditionError, this.m_sourceLocation, lineInfo, this.m_parsingErrors);
				return null;
			}
			global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty = null;
			if (aliasResolvedAttributeValue != null && containerType != null)
			{
				global::System.Data.Entity.Core.Metadata.Edm.EdmMember edmMember;
				((global::System.Data.Entity.Core.Metadata.Edm.StructuralType)containerType).Members.TryGetValue(aliasResolvedAttributeValue, false, out edmMember);
				edmProperty = (edmMember as global::System.Data.Entity.Core.Metadata.Edm.EdmProperty);
			}
			global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty2 = null;
			if (aliasResolvedAttributeValue2 != null)
			{
				tableProperties.TryGetValue(aliasResolvedAttributeValue2, false, out edmProperty2);
			}
			global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty3 = (edmProperty2 != null) ? edmProperty2 : edmProperty;
			if (edmProperty3 == null)
			{
				global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrorsWithMemberInfo(new global::System.Func<object, string>(global::System.Data.Entity.Resources.Strings.Mapping_InvalidContent_ConditionMapping_InvalidMember), (aliasResolvedAttributeValue2 != null) ? aliasResolvedAttributeValue2 : aliasResolvedAttributeValue, global::System.Data.Entity.Core.Mapping.MappingErrorCode.ConditionError, this.m_sourceLocation, lineInfo, this.m_parsingErrors);
				return null;
			}
			bool? flag = null;
			object obj = null;
			string attributeValue = global::System.Data.Entity.Core.Mapping.MappingItemLoader.GetAttributeValue(nav.Clone(), "IsNull");
			global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType = edmProperty3.TypeUsage.EdmType;
			if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsPrimitiveType(edmType))
			{
				global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage;
				if (edmProperty3.DeclaringType.DataSpace == global::System.Data.Entity.Core.Metadata.Edm.DataSpace.SSpace)
				{
					typeUsage = this.StoreItemCollection.ProviderManifest.GetEdmType(edmProperty3.TypeUsage);
					if (typeUsage == null)
					{
						global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrorWithMessage(global::System.Data.Entity.Resources.Strings.Mapping_ProviderReturnsNullType(edmProperty3.Name), global::System.Data.Entity.Core.Mapping.MappingErrorCode.MappingStoreProviderReturnsNullEdmType, this.m_sourceLocation, lineInfo, this.m_parsingErrors);
						return null;
					}
				}
				else
				{
					typeUsage = edmProperty3.TypeUsage;
				}
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType primitiveType = (global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType)typeUsage.EdmType;
				global::System.Type clrEquivalentType = primitiveType.ClrEquivalentType;
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind primitiveTypeKind = primitiveType.PrimitiveTypeKind;
				if (attributeValue == null && !global::System.Data.Entity.Core.Mapping.MappingItemLoader.IsTypeSupportedForCondition(primitiveTypeKind))
				{
					global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrorWithMemberAndStructure(new global::System.Func<object, object, string>(global::System.Data.Entity.Resources.Strings.Mapping_InvalidContent_ConditionMapping_InvalidPrimitiveTypeKind), edmProperty3.Name, edmType.FullName, global::System.Data.Entity.Core.Mapping.MappingErrorCode.ConditionError, this.m_sourceLocation, lineInfo, this.m_parsingErrors);
					return null;
				}
				if (!global::System.Data.Entity.Core.Mapping.MappingItemLoader.TryGetTypedAttributeValue(nav.Clone(), "Value", clrEquivalentType, this.m_sourceLocation, this.m_parsingErrors, out obj))
				{
					return null;
				}
			}
			else
			{
				if (!global::System.Data.Entity.Core.Metadata.Edm.Helper.IsEnumType(edmType))
				{
					global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrors(global::System.Data.Entity.Resources.Strings.Mapping_InvalidContent_ConditionMapping_NonScalar, global::System.Data.Entity.Core.Mapping.MappingErrorCode.ConditionError, this.m_sourceLocation, lineInfo, this.m_parsingErrors);
					return null;
				}
				obj = global::System.Data.Entity.Core.Mapping.MappingItemLoader.GetEnumAttributeValue(nav.Clone(), "Value", (global::System.Data.Entity.Core.Metadata.Edm.EnumType)edmType, this.m_sourceLocation, this.m_parsingErrors);
			}
			if (attributeValue != null && obj != null)
			{
				global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrors(global::System.Data.Entity.Resources.Strings.Mapping_InvalidContent_ConditionMapping_Both_Values, global::System.Data.Entity.Core.Mapping.MappingErrorCode.ConditionError, this.m_sourceLocation, lineInfo, this.m_parsingErrors);
				return null;
			}
			if (attributeValue == null && obj == null)
			{
				global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrors(global::System.Data.Entity.Resources.Strings.Mapping_InvalidContent_ConditionMapping_Either_Values, global::System.Data.Entity.Core.Mapping.MappingErrorCode.ConditionError, this.m_sourceLocation, lineInfo, this.m_parsingErrors);
				return null;
			}
			if (attributeValue != null)
			{
				flag = new bool?(global::System.Convert.ToBoolean(attributeValue, global::System.Globalization.CultureInfo.InvariantCulture));
			}
			if (edmProperty2 != null && (edmProperty2.IsStoreGeneratedComputed || edmProperty2.IsStoreGeneratedIdentity))
			{
				global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrorsWithMemberInfo(new global::System.Func<object, string>(global::System.Data.Entity.Resources.Strings.Mapping_InvalidContent_ConditionMapping_Computed), edmProperty2.Name, global::System.Data.Entity.Core.Mapping.MappingErrorCode.ConditionError, this.m_sourceLocation, lineInfo, this.m_parsingErrors);
				return null;
			}
			if (obj == null)
			{
				return new global::System.Data.Entity.Core.Mapping.IsNullConditionMapping(edmProperty3, flag.Value);
			}
			return new global::System.Data.Entity.Core.Mapping.ValueConditionMapping(edmProperty3, obj);
		}

		// Token: 0x0600428C RID: 17036 RVA: 0x000E3E3C File Offset: 0x000E203C
		internal static bool IsTypeSupportedForCondition(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind primitiveTypeKind)
		{
			switch (primitiveTypeKind)
			{
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Binary:
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.DateTime:
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Decimal:
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Double:
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Guid:
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Single:
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Time:
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.DateTimeOffset:
				return false;
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Boolean:
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Byte:
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.SByte:
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int16:
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int32:
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int64:
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String:
				return true;
			default:
				return false;
			}
		}

		// Token: 0x0600428D RID: 17037 RVA: 0x000E3E94 File Offset: 0x000E2094
		private static global::System.Xml.Schema.XmlSchemaSet GetOrCreateSchemaSet()
		{
			if (global::System.Data.Entity.Core.Mapping.MappingItemLoader.s_mappingXmlSchema == null)
			{
				global::System.Xml.Schema.XmlSchemaSet xmlSchemaSet = new global::System.Xml.Schema.XmlSchemaSet();
				global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddResourceXsdToSchemaSet(xmlSchemaSet, "System.Data.Resources.CSMSL_1.xsd");
				global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddResourceXsdToSchemaSet(xmlSchemaSet, "System.Data.Resources.CSMSL_2.xsd");
				global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddResourceXsdToSchemaSet(xmlSchemaSet, "System.Data.Resources.CSMSL_3.xsd");
				global::System.Threading.Interlocked.CompareExchange<global::System.Xml.Schema.XmlSchemaSet>(ref global::System.Data.Entity.Core.Mapping.MappingItemLoader.s_mappingXmlSchema, xmlSchemaSet, null);
			}
			return global::System.Data.Entity.Core.Mapping.MappingItemLoader.s_mappingXmlSchema;
		}

		// Token: 0x0600428E RID: 17038 RVA: 0x000E3EE4 File Offset: 0x000E20E4
		private static void AddResourceXsdToSchemaSet(global::System.Xml.Schema.XmlSchemaSet set, string resourceName)
		{
			using (global::System.Xml.XmlReader xmlResource = global::System.Data.Entity.Core.Common.DbProviderServices.GetXmlResource(resourceName))
			{
				global::System.Xml.Schema.XmlSchema schema = global::System.Xml.Schema.XmlSchema.Read(xmlResource, null);
				set.Add(schema);
			}
		}

		// Token: 0x0600428F RID: 17039 RVA: 0x000E3F24 File Offset: 0x000E2124
		internal static void AddToSchemaErrors(string message, global::System.Data.Entity.Core.Mapping.MappingErrorCode errorCode, string location, global::System.Xml.IXmlLineInfo lineInfo, global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError> parsingErrors)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError item = new global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError(message, (int)errorCode, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, location, lineInfo.LineNumber, lineInfo.LinePosition);
			parsingErrors.Add(item);
		}

		// Token: 0x06004290 RID: 17040 RVA: 0x000E3F50 File Offset: 0x000E2150
		internal static global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError AddToSchemaErrorsWithMemberInfo(global::System.Func<object, string> messageFormat, string errorMember, global::System.Data.Entity.Core.Mapping.MappingErrorCode errorCode, string location, global::System.Xml.IXmlLineInfo lineInfo, global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError> parsingErrors)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError edmSchemaError = new global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError(messageFormat(errorMember), (int)errorCode, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, location, lineInfo.LineNumber, lineInfo.LinePosition);
			parsingErrors.Add(edmSchemaError);
			return edmSchemaError;
		}

		// Token: 0x06004291 RID: 17041 RVA: 0x000E3F84 File Offset: 0x000E2184
		internal static void AddToSchemaErrorWithMemberAndStructure(global::System.Func<object, object, string> messageFormat, string errorMember, string errorStructure, global::System.Data.Entity.Core.Mapping.MappingErrorCode errorCode, string location, global::System.Xml.IXmlLineInfo lineInfo, global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError> parsingErrors)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError item = new global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError(messageFormat(errorMember, errorStructure), (int)errorCode, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, location, lineInfo.LineNumber, lineInfo.LinePosition);
			parsingErrors.Add(item);
		}

		// Token: 0x06004292 RID: 17042 RVA: 0x000E3FBC File Offset: 0x000E21BC
		private static void AddToSchemaErrorWithMessage(string errorMessage, global::System.Data.Entity.Core.Mapping.MappingErrorCode errorCode, string location, global::System.Xml.IXmlLineInfo lineInfo, global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError> parsingErrors)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError item = new global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError(errorMessage, (int)errorCode, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, location, lineInfo.LineNumber, lineInfo.LinePosition);
			parsingErrors.Add(item);
		}

		// Token: 0x06004293 RID: 17043 RVA: 0x000E3FE7 File Offset: 0x000E21E7
		private string GetAliasResolvedAttributeValue(global::System.Xml.XPath.XPathNavigator nav, string attributeName)
		{
			return this.GetAliasResolvedValue(global::System.Data.Entity.Core.Mapping.MappingItemLoader.GetAttributeValue(nav, attributeName));
		}

		// Token: 0x06004294 RID: 17044 RVA: 0x000E3FF8 File Offset: 0x000E21F8
		private static bool GetBoolAttributeValue(global::System.Xml.XPath.XPathNavigator nav, string attributeName, bool defaultValue)
		{
			bool result = defaultValue;
			object typedAttributeValue = global::System.Data.Entity.Core.Metadata.Edm.Helper.GetTypedAttributeValue(nav, attributeName, typeof(bool));
			if (typedAttributeValue != null)
			{
				result = (bool)typedAttributeValue;
			}
			return result;
		}

		// Token: 0x06004295 RID: 17045 RVA: 0x000E4024 File Offset: 0x000E2224
		private static string GetAttributeValue(global::System.Xml.XPath.XPathNavigator nav, string attributeName)
		{
			return global::System.Data.Entity.Core.Metadata.Edm.Helper.GetAttributeValue(nav, attributeName);
		}

		// Token: 0x06004296 RID: 17046 RVA: 0x000E4030 File Offset: 0x000E2230
		private static bool TryGetTypedAttributeValue(global::System.Xml.XPath.XPathNavigator nav, string attributeName, global::System.Type clrType, string sourceLocation, global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError> parsingErrors, out object value)
		{
			value = null;
			try
			{
				value = global::System.Data.Entity.Core.Metadata.Edm.Helper.GetTypedAttributeValue(nav, attributeName, clrType);
			}
			catch (global::System.FormatException)
			{
				global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrors(global::System.Data.Entity.Resources.Strings.Mapping_ConditionValueTypeMismatch, global::System.Data.Entity.Core.Mapping.MappingErrorCode.ConditionError, sourceLocation, (global::System.Xml.IXmlLineInfo)nav, parsingErrors);
				return false;
			}
			return true;
		}

		// Token: 0x06004297 RID: 17047 RVA: 0x000E4080 File Offset: 0x000E2280
		private static global::System.Data.Entity.Core.Metadata.Edm.EnumMember GetEnumAttributeValue(global::System.Xml.XPath.XPathNavigator nav, string attributeName, global::System.Data.Entity.Core.Metadata.Edm.EnumType enumType, string sourceLocation, global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError> parsingErrors)
		{
			global::System.Xml.IXmlLineInfo lineInfo = (global::System.Xml.IXmlLineInfo)nav;
			string attributeValue = global::System.Data.Entity.Core.Mapping.MappingItemLoader.GetAttributeValue(nav, attributeName);
			if (string.IsNullOrEmpty(attributeValue))
			{
				global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrorsWithMemberInfo(new global::System.Func<object, string>(global::System.Data.Entity.Resources.Strings.Mapping_Enum_EmptyValue), enumType.FullName, global::System.Data.Entity.Core.Mapping.MappingErrorCode.InvalidEnumValue, sourceLocation, lineInfo, parsingErrors);
			}
			global::System.Data.Entity.Core.Metadata.Edm.EnumMember result;
			if (!enumType.Members.TryGetValue(attributeValue, false, out result))
			{
				global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrorsWithMemberInfo(new global::System.Func<object, string>(global::System.Data.Entity.Resources.Strings.Mapping_Enum_InvalidValue), attributeValue, global::System.Data.Entity.Core.Mapping.MappingErrorCode.InvalidEnumValue, sourceLocation, lineInfo, parsingErrors);
			}
			return result;
		}

		// Token: 0x06004298 RID: 17048 RVA: 0x000E40F4 File Offset: 0x000E22F4
		private string GetAliasResolvedValue(string aliasedString)
		{
			if (aliasedString == null || aliasedString.Length == 0)
			{
				return aliasedString;
			}
			int num = aliasedString.LastIndexOf('.');
			if (num == -1)
			{
				return aliasedString;
			}
			string key = aliasedString.Substring(0, num);
			string text;
			this.m_alias.TryGetValue(key, out text);
			if (text != null)
			{
				aliasedString = text + aliasedString.Substring(num);
			}
			return aliasedString;
		}

		// Token: 0x06004299 RID: 17049 RVA: 0x000E4148 File Offset: 0x000E2348
		private global::System.Xml.XmlReader GetSchemaValidatingReader(global::System.Xml.XmlReader innerReader)
		{
			global::System.Xml.XmlReaderSettings xmlReaderSettings = this.GetXmlReaderSettings();
			return global::System.Xml.XmlReader.Create(innerReader, xmlReaderSettings);
		}

		// Token: 0x0600429A RID: 17050 RVA: 0x000E4163 File Offset: 0x000E2363
		private global::System.Xml.XmlReaderSettings GetXmlReaderSettings()
		{
			global::System.Xml.XmlReaderSettings xmlReaderSettings = global::System.Data.Entity.Core.SchemaObjectModel.Schema.CreateEdmStandardXmlReaderSettings();
			xmlReaderSettings.ValidationFlags |= global::System.Xml.Schema.XmlSchemaValidationFlags.ReportValidationWarnings;
			xmlReaderSettings.ValidationEventHandler += this.XsdValidationCallBack;
			xmlReaderSettings.ValidationType = global::System.Xml.ValidationType.Schema;
			xmlReaderSettings.Schemas = global::System.Data.Entity.Core.Mapping.MappingItemLoader.GetOrCreateSchemaSet();
			return xmlReaderSettings;
		}

		// Token: 0x0600429B RID: 17051 RVA: 0x000E419C File Offset: 0x000E239C
		private void XsdValidationCallBack(object sender, global::System.Xml.Schema.ValidationEventArgs args)
		{
			if (args.Severity != global::System.Xml.Schema.XmlSeverityType.Warning)
			{
				string schemaLocation = null;
				if (!string.IsNullOrEmpty(args.Exception.SourceUri))
				{
					schemaLocation = global::System.Data.Entity.Core.Metadata.Edm.Helper.GetFileNameFromUri(new global::System.Uri(args.Exception.SourceUri));
				}
				global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity severity = global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error;
				if (args.Severity == global::System.Xml.Schema.XmlSeverityType.Warning)
				{
					severity = global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Warning;
				}
				global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError item = new global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError(global::System.Data.Entity.Resources.Strings.Mapping_InvalidMappingSchema_validation(args.Exception.Message), 2025, severity, schemaLocation, args.Exception.LineNumber, args.Exception.LinePosition);
				this.m_parsingErrors.Add(item);
			}
		}

		// Token: 0x0600429C RID: 17052 RVA: 0x000E4228 File Offset: 0x000E2428
		private void ValidateAndUpdateScalarMemberMapping(global::System.Data.Entity.Core.Metadata.Edm.EdmProperty member, global::System.Data.Entity.Core.Metadata.Edm.EdmProperty columnMember, global::System.Xml.IXmlLineInfo lineInfo)
		{
			global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage> keyValuePair;
			if (!this.m_scalarMemberMappings.TryGetValue(member, out keyValuePair))
			{
				int count = this.m_parsingErrors.Count;
				global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage = global::System.Data.Entity.Core.Metadata.Edm.Helper.ValidateAndConvertTypeUsage(member, columnMember);
				if (typeUsage != null)
				{
					this.m_scalarMemberMappings.Add(member, new global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(typeUsage, columnMember.TypeUsage));
					return;
				}
				if (count == this.m_parsingErrors.Count)
				{
					global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError item = new global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError(global::System.Data.Entity.Core.Mapping.MappingItemLoader.GetInvalidMemberMappingErrorMessage(member, columnMember), 2019, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, this.m_sourceLocation, lineInfo.LineNumber, lineInfo.LinePosition);
					this.m_parsingErrors.Add(item);
					return;
				}
			}
			else
			{
				global::System.Data.Entity.Core.Metadata.Edm.TypeUsage value = keyValuePair.Value;
				global::System.Data.Entity.Core.Metadata.Edm.TypeUsage modelTypeUsage = columnMember.TypeUsage.ModelTypeUsage;
				if (columnMember.TypeUsage.EdmType != value.EdmType)
				{
					global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError item2 = new global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError(global::System.Data.Entity.Resources.Strings.Mapping_StoreTypeMismatch_ScalarPropertyMapping(member.Name, value.EdmType.Name), 2039, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, this.m_sourceLocation, lineInfo.LineNumber, lineInfo.LinePosition);
					this.m_parsingErrors.Add(item2);
					return;
				}
				if (!global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsSubTypeOf(global::System.Data.Entity.Core.Mapping.MappingItemLoader.ResolveTypeUsageForEnums(member.TypeUsage), modelTypeUsage))
				{
					global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError item3 = new global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError(global::System.Data.Entity.Core.Mapping.MappingItemLoader.GetInvalidMemberMappingErrorMessage(member, columnMember), 2019, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, this.m_sourceLocation, lineInfo.LineNumber, lineInfo.LinePosition);
					this.m_parsingErrors.Add(item3);
				}
			}
		}

		// Token: 0x0600429D RID: 17053 RVA: 0x000E4370 File Offset: 0x000E2570
		internal static string GetInvalidMemberMappingErrorMessage(global::System.Data.Entity.Core.Metadata.Edm.EdmMember cSpaceMember, global::System.Data.Entity.Core.Metadata.Edm.EdmMember sSpaceMember)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType = cSpaceMember.TypeUsage.EdmType;
			object p = ((edmType != null) ? edmType.ToString() : null) + global::System.Data.Entity.Core.Mapping.MappingItemLoader.GetFacetsForDisplay(cSpaceMember.TypeUsage);
			object name = cSpaceMember.Name;
			object fullName = cSpaceMember.DeclaringType.FullName;
			global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType2 = sSpaceMember.TypeUsage.EdmType;
			return global::System.Data.Entity.Resources.Strings.Mapping_Invalid_Member_Mapping(p, name, fullName, ((edmType2 != null) ? edmType2.ToString() : null) + global::System.Data.Entity.Core.Mapping.MappingItemLoader.GetFacetsForDisplay(sSpaceMember.TypeUsage), sSpaceMember.Name, sSpaceMember.DeclaringType.FullName);
		}

		// Token: 0x0600429E RID: 17054 RVA: 0x000E43F4 File Offset: 0x000E25F4
		private static string GetFacetsForDisplay(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage)
		{
			global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.Facet> facets = typeUsage.Facets;
			if (facets == null || facets.Count == 0)
			{
				return string.Empty;
			}
			int count = facets.Count;
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder("[");
			for (int i = 0; i < count - 1; i++)
			{
				stringBuilder.AppendFormat("{0}={1},", facets[i].Name, facets[i].Value ?? string.Empty);
			}
			stringBuilder.AppendFormat("{0}={1}]", facets[count - 1].Name, facets[count - 1].Value ?? string.Empty);
			return stringBuilder.ToString();
		}

		// Token: 0x0600429F RID: 17055 RVA: 0x000E449D File Offset: 0x000E269D
		internal static global::System.Data.Entity.Core.Metadata.Edm.TypeUsage ResolveTypeUsageForEnums(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage)
		{
			if (!global::System.Data.Entity.Core.Metadata.Edm.Helper.IsEnumType(typeUsage.EdmType))
			{
				return typeUsage;
			}
			return global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(global::System.Data.Entity.Core.Metadata.Edm.Helper.GetUnderlyingEdmTypeForEnumType(typeUsage.EdmType), typeUsage.Facets);
		}

		// Token: 0x0400176E RID: 5998
		private readonly global::System.Collections.Generic.Dictionary<string, string> m_alias;

		// Token: 0x0400176F RID: 5999
		private readonly global::System.Data.Entity.Core.Mapping.StorageMappingItemCollection m_storageMappingItemCollection;

		// Token: 0x04001770 RID: 6000
		private readonly string m_sourceLocation;

		// Token: 0x04001771 RID: 6001
		private readonly global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError> m_parsingErrors;

		// Token: 0x04001772 RID: 6002
		private readonly global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EdmMember, global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>> m_scalarMemberMappings;

		// Token: 0x04001773 RID: 6003
		private bool m_hasQueryViews;

		// Token: 0x04001774 RID: 6004
		private string m_currentNamespaceUri;

		// Token: 0x04001775 RID: 6005
		private readonly global::System.Data.Entity.Core.Mapping.EntityContainerMapping m_containerMapping;

		// Token: 0x04001776 RID: 6006
		private readonly double m_version;

		// Token: 0x04001777 RID: 6007
		private static global::System.Xml.Schema.XmlSchemaSet s_mappingXmlSchema;

		// Token: 0x02000B50 RID: 2896
		private class ModificationFunctionMappingLoader
		{
			// Token: 0x060065B4 RID: 26036 RVA: 0x0015C7A0 File Offset: 0x0015A9A0
			internal ModificationFunctionMappingLoader(global::System.Data.Entity.Core.Mapping.MappingItemLoader parentLoader, global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase extent)
			{
				this.m_parentLoader = parentLoader;
				this.m_modelContainer = extent.EntityContainer;
				this.m_edmItemCollection = parentLoader.EdmItemCollection;
				this.m_storeItemCollection = parentLoader.StoreItemCollection;
				this.m_entitySet = (extent as global::System.Data.Entity.Core.Metadata.Edm.EntitySet);
				if (this.m_entitySet == null)
				{
					this.m_associationSet = (global::System.Data.Entity.Core.Metadata.Edm.AssociationSet)extent;
				}
				this.m_seenParameters = new global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter>();
				this.m_members = new global::System.Collections.Generic.Stack<global::System.Data.Entity.Core.Metadata.Edm.EdmMember>();
			}

			// Token: 0x060065B5 RID: 26037 RVA: 0x0015C814 File Offset: 0x0015AA14
			internal global::System.Data.Entity.Core.Mapping.ModificationFunctionMapping LoadEntityTypeModificationFunctionMapping(global::System.Xml.XPath.XPathNavigator nav, global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase entitySet, bool allowCurrentVersion, bool allowOriginalVersion, global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType)
			{
				global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter rowsAffectedParameter;
				this.m_function = this.LoadAndValidateFunctionMetadata(nav.Clone(), out rowsAffectedParameter);
				if (this.m_function == null)
				{
					return null;
				}
				this.m_allowCurrentVersion = allowCurrentVersion;
				this.m_allowOriginalVersion = allowOriginalVersion;
				global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ModificationFunctionParameterBinding> parameterBindings = this.LoadParameterBindings(nav.Clone(), entityType);
				global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ModificationFunctionResultBinding> resultBindings = this.LoadResultBindings(nav.Clone(), entityType);
				return new global::System.Data.Entity.Core.Mapping.ModificationFunctionMapping(entitySet, entityType, this.m_function, parameterBindings, rowsAffectedParameter, resultBindings);
			}

			// Token: 0x060065B6 RID: 26038 RVA: 0x0015C880 File Offset: 0x0015AA80
			internal global::System.Data.Entity.Core.Mapping.ModificationFunctionMapping LoadAssociationSetModificationFunctionMapping(global::System.Xml.XPath.XPathNavigator nav, global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase entitySet, bool isInsert)
			{
				global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter rowsAffectedParameter;
				this.m_function = this.LoadAndValidateFunctionMetadata(nav.Clone(), out rowsAffectedParameter);
				if (this.m_function == null)
				{
					return null;
				}
				if (isInsert)
				{
					this.m_allowCurrentVersion = true;
					this.m_allowOriginalVersion = false;
				}
				else
				{
					this.m_allowCurrentVersion = false;
					this.m_allowOriginalVersion = true;
				}
				global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ModificationFunctionParameterBinding> parameterBindings = this.LoadParameterBindings(nav.Clone(), this.m_associationSet.ElementType);
				return new global::System.Data.Entity.Core.Mapping.ModificationFunctionMapping(entitySet, entitySet.ElementType, this.m_function, parameterBindings, rowsAffectedParameter, null);
			}

			// Token: 0x060065B7 RID: 26039 RVA: 0x0015C8FC File Offset: 0x0015AAFC
			private global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ModificationFunctionResultBinding> LoadResultBindings(global::System.Xml.XPath.XPathNavigator nav, global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType)
			{
				global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ModificationFunctionResultBinding> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ModificationFunctionResultBinding>();
				global::System.Xml.IXmlLineInfo lineInfo = (global::System.Xml.IXmlLineInfo)nav;
				if (nav.MoveToChild(global::System.Xml.XPath.XPathNodeType.Element))
				{
					string aliasResolvedAttributeValue;
					for (;;)
					{
						if (nav.LocalName == "ResultBinding")
						{
							aliasResolvedAttributeValue = this.m_parentLoader.GetAliasResolvedAttributeValue(nav.Clone(), "Name");
							string aliasResolvedAttributeValue2 = this.m_parentLoader.GetAliasResolvedAttributeValue(nav.Clone(), "ColumnName");
							global::System.Data.Entity.Core.Metadata.Edm.EdmProperty property = null;
							if (aliasResolvedAttributeValue == null || !entityType.Properties.TryGetValue(aliasResolvedAttributeValue, false, out property))
							{
								break;
							}
							global::System.Data.Entity.Core.Mapping.ModificationFunctionResultBinding item = new global::System.Data.Entity.Core.Mapping.ModificationFunctionResultBinding(aliasResolvedAttributeValue2, property);
							list.Add(item);
						}
						if (!nav.MoveToNext(global::System.Xml.XPath.XPathNodeType.Element))
						{
							goto IL_CD;
						}
					}
					global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrorWithMemberAndStructure(new global::System.Func<object, object, string>(global::System.Data.Entity.Resources.Strings.Mapping_ModificationFunction_PropertyNotFound), aliasResolvedAttributeValue, entityType.Name, global::System.Data.Entity.Core.Mapping.MappingErrorCode.InvalidEdmMember, this.m_parentLoader.m_sourceLocation, lineInfo, this.m_parentLoader.m_parsingErrors);
					return new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ModificationFunctionResultBinding>();
				}
				IL_CD:
				global::System.Data.Entity.Core.Common.Utils.KeyToListMap<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty, string> keyToListMap = new global::System.Data.Entity.Core.Common.Utils.KeyToListMap<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty, string>(global::System.Collections.Generic.EqualityComparer<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>.Default);
				foreach (global::System.Data.Entity.Core.Mapping.ModificationFunctionResultBinding modificationFunctionResultBinding in list)
				{
					keyToListMap.Add(modificationFunctionResultBinding.Property, modificationFunctionResultBinding.ColumnName);
				}
				foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty in keyToListMap.Keys)
				{
					global::System.Collections.ObjectModel.ReadOnlyCollection<string> readOnlyCollection = keyToListMap.ListForKey(edmProperty);
					if (1 < readOnlyCollection.Count)
					{
						global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrorWithMemberAndStructure(new global::System.Func<object, object, string>(global::System.Data.Entity.Resources.Strings.Mapping_ModificationFunction_AmbiguousResultBinding), edmProperty.Name, global::System.Data.Entity.Core.Common.Utils.StringUtil.ToCommaSeparatedString(readOnlyCollection), global::System.Data.Entity.Core.Mapping.MappingErrorCode.AmbiguousResultBindingInModificationFunctionMapping, this.m_parentLoader.m_sourceLocation, lineInfo, this.m_parentLoader.m_parsingErrors);
						return new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ModificationFunctionResultBinding>();
					}
				}
				return list;
			}

			// Token: 0x060065B8 RID: 26040 RVA: 0x0015CAC8 File Offset: 0x0015ACC8
			private global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ModificationFunctionParameterBinding> LoadParameterBindings(global::System.Xml.XPath.XPathNavigator nav, global::System.Data.Entity.Core.Metadata.Edm.StructuralType type)
			{
				global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ModificationFunctionParameterBinding> result = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ModificationFunctionParameterBinding>(this.LoadParameterBindings(nav.Clone(), type, false));
				global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter> set = new global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter>(this.m_function.Parameters);
				set.Subtract(this.m_seenParameters);
				if (set.Count != 0)
				{
					global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrorWithMemberAndStructure(new global::System.Func<object, object, string>(global::System.Data.Entity.Resources.Strings.Mapping_ModificationFunction_MissingParameter), this.m_function.FullName, global::System.Data.Entity.Core.Common.Utils.StringUtil.ToCommaSeparatedString(set), global::System.Data.Entity.Core.Mapping.MappingErrorCode.InvalidParameterInModificationFunctionMapping, this.m_parentLoader.m_sourceLocation, (global::System.Xml.IXmlLineInfo)nav, this.m_parentLoader.m_parsingErrors);
					return new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ModificationFunctionParameterBinding>();
				}
				return result;
			}

			// Token: 0x060065B9 RID: 26041 RVA: 0x0015CB58 File Offset: 0x0015AD58
			private global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ModificationFunctionParameterBinding> LoadParameterBindings(global::System.Xml.XPath.XPathNavigator nav, global::System.Data.Entity.Core.Metadata.Edm.StructuralType type, bool restrictToKeyMembers)
			{
				if (nav.MoveToChild(global::System.Xml.XPath.XPathNodeType.Element))
				{
					for (;;)
					{
						string localName = nav.LocalName;
						if (localName != null)
						{
							if (!(localName == "ScalarProperty"))
							{
								if (!(localName == "ComplexProperty"))
								{
									if (!(localName == "AssociationEnd"))
									{
										if (localName == "EndProperty")
										{
											global::System.Data.Entity.Core.Metadata.Edm.AssociationSetEnd associationSetEnd = this.LoadEndProperty(nav.Clone());
											if (associationSetEnd != null)
											{
												this.m_members.Push(associationSetEnd.CorrespondingAssociationEndMember);
												foreach (global::System.Data.Entity.Core.Mapping.ModificationFunctionParameterBinding modificationFunctionParameterBinding in this.LoadParameterBindings(nav.Clone(), associationSetEnd.EntitySet.ElementType, true))
												{
													yield return modificationFunctionParameterBinding;
												}
												global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Mapping.ModificationFunctionParameterBinding> enumerator = null;
												this.m_members.Pop();
											}
										}
									}
									else
									{
										global::System.Data.Entity.Core.Metadata.Edm.AssociationSetEnd associationSetEnd2 = this.LoadAssociationEnd(nav.Clone());
										if (associationSetEnd2 != null)
										{
											this.m_members.Push(associationSetEnd2.CorrespondingAssociationEndMember);
											this.m_associationSetNavigation = associationSetEnd2.ParentAssociationSet;
											foreach (global::System.Data.Entity.Core.Mapping.ModificationFunctionParameterBinding modificationFunctionParameterBinding2 in this.LoadParameterBindings(nav.Clone(), associationSetEnd2.EntitySet.ElementType, true))
											{
												yield return modificationFunctionParameterBinding2;
											}
											global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Mapping.ModificationFunctionParameterBinding> enumerator = null;
											this.m_associationSetNavigation = null;
											this.m_members.Pop();
										}
									}
								}
								else
								{
									global::System.Data.Entity.Core.Metadata.Edm.ComplexType type2;
									global::System.Data.Entity.Core.Metadata.Edm.EdmMember edmMember = this.LoadComplexTypeProperty(nav.Clone(), type, out type2);
									if (edmMember != null)
									{
										this.m_members.Push(edmMember);
										foreach (global::System.Data.Entity.Core.Mapping.ModificationFunctionParameterBinding modificationFunctionParameterBinding3 in this.LoadParameterBindings(nav.Clone(), type2, restrictToKeyMembers))
										{
											yield return modificationFunctionParameterBinding3;
										}
										global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Mapping.ModificationFunctionParameterBinding> enumerator = null;
										this.m_members.Pop();
									}
								}
							}
							else
							{
								global::System.Data.Entity.Core.Mapping.ModificationFunctionParameterBinding modificationFunctionParameterBinding4 = this.LoadScalarPropertyParameterBinding(nav.Clone(), type, restrictToKeyMembers);
								if (modificationFunctionParameterBinding4 == null)
								{
									break;
								}
								yield return modificationFunctionParameterBinding4;
							}
						}
						if (!nav.MoveToNext(global::System.Xml.XPath.XPathNodeType.Element))
						{
							goto IL_31E;
						}
					}
					yield break;
				}
				IL_31E:
				yield break;
				yield break;
			}

			// Token: 0x060065BA RID: 26042 RVA: 0x0015CB80 File Offset: 0x0015AD80
			private global::System.Data.Entity.Core.Metadata.Edm.AssociationSetEnd LoadAssociationEnd(global::System.Xml.XPath.XPathNavigator nav)
			{
				global::System.Xml.IXmlLineInfo lineInfo = (global::System.Xml.IXmlLineInfo)nav;
				string aliasResolvedAttributeValue = this.m_parentLoader.GetAliasResolvedAttributeValue(nav.Clone(), "AssociationSet");
				string aliasResolvedAttributeValue2 = this.m_parentLoader.GetAliasResolvedAttributeValue(nav.Clone(), "From");
				string aliasResolvedAttributeValue3 = this.m_parentLoader.GetAliasResolvedAttributeValue(nav.Clone(), "To");
				global::System.Data.Entity.Core.Metadata.Edm.RelationshipSet relationshipSet = null;
				if (aliasResolvedAttributeValue == null || !this.m_modelContainer.TryGetRelationshipSetByName(aliasResolvedAttributeValue, false, out relationshipSet) || global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.AssociationSet != relationshipSet.BuiltInTypeKind)
				{
					global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrorsWithMemberInfo(new global::System.Func<object, string>(global::System.Data.Entity.Resources.Strings.Mapping_ModificationFunction_AssociationSetDoesNotExist), aliasResolvedAttributeValue, global::System.Data.Entity.Core.Mapping.MappingErrorCode.InvalidAssociationSet, this.m_parentLoader.m_sourceLocation, lineInfo, this.m_parentLoader.m_parsingErrors);
					return null;
				}
				global::System.Data.Entity.Core.Metadata.Edm.AssociationSet associationSet = (global::System.Data.Entity.Core.Metadata.Edm.AssociationSet)relationshipSet;
				global::System.Data.Entity.Core.Metadata.Edm.AssociationSetEnd associationSetEnd = null;
				if (aliasResolvedAttributeValue2 == null || !associationSet.AssociationSetEnds.TryGetValue(aliasResolvedAttributeValue2, false, out associationSetEnd))
				{
					global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrorsWithMemberInfo(new global::System.Func<object, string>(global::System.Data.Entity.Resources.Strings.Mapping_ModificationFunction_AssociationSetRoleDoesNotExist), aliasResolvedAttributeValue2, global::System.Data.Entity.Core.Mapping.MappingErrorCode.InvalidAssociationSetRoleInModificationFunctionMapping, this.m_parentLoader.m_sourceLocation, lineInfo, this.m_parentLoader.m_parsingErrors);
					return null;
				}
				global::System.Data.Entity.Core.Metadata.Edm.AssociationSetEnd associationSetEnd2 = null;
				if (aliasResolvedAttributeValue3 == null || !associationSet.AssociationSetEnds.TryGetValue(aliasResolvedAttributeValue3, false, out associationSetEnd2))
				{
					global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrorsWithMemberInfo(new global::System.Func<object, string>(global::System.Data.Entity.Resources.Strings.Mapping_ModificationFunction_AssociationSetRoleDoesNotExist), aliasResolvedAttributeValue3, global::System.Data.Entity.Core.Mapping.MappingErrorCode.InvalidAssociationSetRoleInModificationFunctionMapping, this.m_parentLoader.m_sourceLocation, lineInfo, this.m_parentLoader.m_parsingErrors);
					return null;
				}
				if (!associationSetEnd.EntitySet.Equals(this.m_entitySet))
				{
					global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrorsWithMemberInfo(new global::System.Func<object, string>(global::System.Data.Entity.Resources.Strings.Mapping_ModificationFunction_AssociationSetFromRoleIsNotEntitySet), aliasResolvedAttributeValue2, global::System.Data.Entity.Core.Mapping.MappingErrorCode.InvalidAssociationSetRoleInModificationFunctionMapping, this.m_parentLoader.m_sourceLocation, lineInfo, this.m_parentLoader.m_parsingErrors);
					return null;
				}
				if (associationSetEnd2.CorrespondingAssociationEndMember.RelationshipMultiplicity != global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.One && associationSetEnd2.CorrespondingAssociationEndMember.RelationshipMultiplicity != global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne)
				{
					global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrorsWithMemberInfo(new global::System.Func<object, string>(global::System.Data.Entity.Resources.Strings.Mapping_ModificationFunction_AssociationSetCardinality), aliasResolvedAttributeValue3, global::System.Data.Entity.Core.Mapping.MappingErrorCode.InvalidAssociationSetCardinalityInModificationFunctionMapping, this.m_parentLoader.m_sourceLocation, lineInfo, this.m_parentLoader.m_parsingErrors);
					return null;
				}
				if (associationSet.ElementType.IsForeignKey)
				{
					global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint referentialConstraint = associationSet.ElementType.ReferentialConstraints.Single<global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint>();
					global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError edmSchemaError = global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrorsWithMemberInfo(new global::System.Func<object, string>(global::System.Data.Entity.Resources.Strings.Mapping_ModificationFunction_AssociationEndMappingForeignKeyAssociation), aliasResolvedAttributeValue3, global::System.Data.Entity.Core.Mapping.MappingErrorCode.InvalidModificationFunctionMappingAssociationEndForeignKey, this.m_parentLoader.m_sourceLocation, lineInfo, this.m_parentLoader.m_parsingErrors);
					if (associationSetEnd.CorrespondingAssociationEndMember != referentialConstraint.ToRole || !referentialConstraint.ToProperties.All((global::System.Data.Entity.Core.Metadata.Edm.EdmProperty p) => this.m_entitySet.ElementType.KeyMembers.Contains(p)))
					{
						return null;
					}
					edmSchemaError.Severity = global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Warning;
				}
				return associationSetEnd2;
			}

			// Token: 0x060065BB RID: 26043 RVA: 0x0015CDE4 File Offset: 0x0015AFE4
			private global::System.Data.Entity.Core.Metadata.Edm.AssociationSetEnd LoadEndProperty(global::System.Xml.XPath.XPathNavigator nav)
			{
				string aliasResolvedAttributeValue = this.m_parentLoader.GetAliasResolvedAttributeValue(nav.Clone(), "Name");
				global::System.Data.Entity.Core.Metadata.Edm.AssociationSetEnd result = null;
				if (aliasResolvedAttributeValue == null || !this.m_associationSet.AssociationSetEnds.TryGetValue(aliasResolvedAttributeValue, false, out result))
				{
					global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrorsWithMemberInfo(new global::System.Func<object, string>(global::System.Data.Entity.Resources.Strings.Mapping_ModificationFunction_AssociationSetRoleDoesNotExist), aliasResolvedAttributeValue, global::System.Data.Entity.Core.Mapping.MappingErrorCode.InvalidAssociationSetRoleInModificationFunctionMapping, this.m_parentLoader.m_sourceLocation, (global::System.Xml.IXmlLineInfo)nav, this.m_parentLoader.m_parsingErrors);
					return null;
				}
				return result;
			}

			// Token: 0x060065BC RID: 26044 RVA: 0x0015CE5C File Offset: 0x0015B05C
			private global::System.Data.Entity.Core.Metadata.Edm.EdmMember LoadComplexTypeProperty(global::System.Xml.XPath.XPathNavigator nav, global::System.Data.Entity.Core.Metadata.Edm.StructuralType type, out global::System.Data.Entity.Core.Metadata.Edm.ComplexType complexType)
			{
				global::System.Xml.IXmlLineInfo lineInfo = (global::System.Xml.IXmlLineInfo)nav;
				string aliasResolvedAttributeValue = this.m_parentLoader.GetAliasResolvedAttributeValue(nav.Clone(), "Name");
				string aliasResolvedAttributeValue2 = this.m_parentLoader.GetAliasResolvedAttributeValue(nav.Clone(), "TypeName");
				global::System.Data.Entity.Core.Metadata.Edm.EdmMember edmMember = null;
				if (aliasResolvedAttributeValue == null || !type.Members.TryGetValue(aliasResolvedAttributeValue, false, out edmMember))
				{
					global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrorWithMemberAndStructure(new global::System.Func<object, object, string>(global::System.Data.Entity.Resources.Strings.Mapping_ModificationFunction_PropertyNotFound), aliasResolvedAttributeValue, type.Name, global::System.Data.Entity.Core.Mapping.MappingErrorCode.InvalidEdmMember, this.m_parentLoader.m_sourceLocation, lineInfo, this.m_parentLoader.m_parsingErrors);
					complexType = null;
					return null;
				}
				complexType = null;
				if (aliasResolvedAttributeValue2 == null || !this.m_edmItemCollection.TryGetItem<global::System.Data.Entity.Core.Metadata.Edm.ComplexType>(aliasResolvedAttributeValue2, out complexType))
				{
					global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrorsWithMemberInfo(new global::System.Func<object, string>(global::System.Data.Entity.Resources.Strings.Mapping_ModificationFunction_ComplexTypeNotFound), aliasResolvedAttributeValue2, global::System.Data.Entity.Core.Mapping.MappingErrorCode.InvalidComplexType, this.m_parentLoader.m_sourceLocation, lineInfo, this.m_parentLoader.m_parsingErrors);
					return null;
				}
				if (!edmMember.TypeUsage.EdmType.Equals(complexType) && !global::System.Data.Entity.Core.Metadata.Edm.Helper.IsSubtypeOf(edmMember.TypeUsage.EdmType, complexType))
				{
					global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrorWithMemberAndStructure(new global::System.Func<object, object, string>(global::System.Data.Entity.Resources.Strings.Mapping_ModificationFunction_WrongComplexType), aliasResolvedAttributeValue2, edmMember.Name, global::System.Data.Entity.Core.Mapping.MappingErrorCode.InvalidComplexType, this.m_parentLoader.m_sourceLocation, lineInfo, this.m_parentLoader.m_parsingErrors);
					return null;
				}
				return edmMember;
			}

			// Token: 0x060065BD RID: 26045 RVA: 0x0015CF94 File Offset: 0x0015B194
			private global::System.Data.Entity.Core.Mapping.ModificationFunctionParameterBinding LoadScalarPropertyParameterBinding(global::System.Xml.XPath.XPathNavigator nav, global::System.Data.Entity.Core.Metadata.Edm.StructuralType type, bool restrictToKeyMembers)
			{
				global::System.Xml.IXmlLineInfo lineInfo = (global::System.Xml.IXmlLineInfo)nav;
				string aliasResolvedAttributeValue = this.m_parentLoader.GetAliasResolvedAttributeValue(nav.Clone(), "ParameterName");
				string aliasResolvedAttributeValue2 = this.m_parentLoader.GetAliasResolvedAttributeValue(nav.Clone(), "Name");
				string aliasResolvedAttributeValue3 = this.m_parentLoader.GetAliasResolvedAttributeValue(nav.Clone(), "Version");
				bool flag;
				if (aliasResolvedAttributeValue3 == null)
				{
					if (!this.m_allowOriginalVersion)
					{
						flag = true;
					}
					else
					{
						if (this.m_allowCurrentVersion)
						{
							global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrors(global::System.Data.Entity.Resources.Strings.Mapping_ModificationFunction_MissingVersion, global::System.Data.Entity.Core.Mapping.MappingErrorCode.MissingVersionInModificationFunctionMapping, this.m_parentLoader.m_sourceLocation, lineInfo, this.m_parentLoader.m_parsingErrors);
							return null;
						}
						flag = false;
					}
				}
				else
				{
					flag = (aliasResolvedAttributeValue3 == "Current");
				}
				if (flag && !this.m_allowCurrentVersion)
				{
					global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrors(global::System.Data.Entity.Resources.Strings.Mapping_ModificationFunction_VersionMustBeOriginal, global::System.Data.Entity.Core.Mapping.MappingErrorCode.InvalidVersionInModificationFunctionMapping, this.m_parentLoader.m_sourceLocation, lineInfo, this.m_parentLoader.m_parsingErrors);
					return null;
				}
				if (!flag && !this.m_allowOriginalVersion)
				{
					global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrors(global::System.Data.Entity.Resources.Strings.Mapping_ModificationFunction_VersionMustBeCurrent, global::System.Data.Entity.Core.Mapping.MappingErrorCode.InvalidVersionInModificationFunctionMapping, this.m_parentLoader.m_sourceLocation, lineInfo, this.m_parentLoader.m_parsingErrors);
					return null;
				}
				global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter functionParameter = null;
				if (aliasResolvedAttributeValue == null || !this.m_function.Parameters.TryGetValue(aliasResolvedAttributeValue, false, out functionParameter))
				{
					global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrorWithMemberAndStructure(new global::System.Func<object, object, string>(global::System.Data.Entity.Resources.Strings.Mapping_ModificationFunction_ParameterNotFound), aliasResolvedAttributeValue, this.m_function.Name, global::System.Data.Entity.Core.Mapping.MappingErrorCode.InvalidParameterInModificationFunctionMapping, this.m_parentLoader.m_sourceLocation, lineInfo, this.m_parentLoader.m_parsingErrors);
					return null;
				}
				global::System.Data.Entity.Core.Metadata.Edm.EdmMember edmMember = null;
				if (restrictToKeyMembers)
				{
					if (aliasResolvedAttributeValue2 == null || !((global::System.Data.Entity.Core.Metadata.Edm.EntityType)type).KeyMembers.TryGetValue(aliasResolvedAttributeValue2, false, out edmMember))
					{
						global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrorWithMemberAndStructure(new global::System.Func<object, object, string>(global::System.Data.Entity.Resources.Strings.Mapping_ModificationFunction_PropertyNotKey), aliasResolvedAttributeValue2, type.Name, global::System.Data.Entity.Core.Mapping.MappingErrorCode.InvalidEdmMember, this.m_parentLoader.m_sourceLocation, lineInfo, this.m_parentLoader.m_parsingErrors);
						return null;
					}
				}
				else if (aliasResolvedAttributeValue2 == null || !type.Members.TryGetValue(aliasResolvedAttributeValue2, false, out edmMember))
				{
					global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrorWithMemberAndStructure(new global::System.Func<object, object, string>(global::System.Data.Entity.Resources.Strings.Mapping_ModificationFunction_PropertyNotFound), aliasResolvedAttributeValue2, type.Name, global::System.Data.Entity.Core.Mapping.MappingErrorCode.InvalidEdmMember, this.m_parentLoader.m_sourceLocation, lineInfo, this.m_parentLoader.m_parsingErrors);
					return null;
				}
				if (this.m_seenParameters.Contains(functionParameter))
				{
					global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrorsWithMemberInfo(new global::System.Func<object, string>(global::System.Data.Entity.Resources.Strings.Mapping_ModificationFunction_ParameterBoundTwice), aliasResolvedAttributeValue, global::System.Data.Entity.Core.Mapping.MappingErrorCode.ParameterBoundTwiceInModificationFunctionMapping, this.m_parentLoader.m_sourceLocation, lineInfo, this.m_parentLoader.m_parsingErrors);
					return null;
				}
				int count = this.m_parentLoader.m_parsingErrors.Count;
				if (global::System.Data.Entity.Core.Metadata.Edm.Helper.ValidateAndConvertTypeUsage(edmMember.TypeUsage, functionParameter.TypeUsage) == null && count == this.m_parentLoader.m_parsingErrors.Count)
				{
					global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrorWithMessage(global::System.Data.Entity.Resources.Strings.Mapping_ModificationFunction_PropertyParameterTypeMismatch(edmMember.TypeUsage.EdmType, edmMember.Name, edmMember.DeclaringType.FullName, functionParameter.TypeUsage.EdmType, functionParameter.Name, this.m_function.FullName), global::System.Data.Entity.Core.Mapping.MappingErrorCode.InvalidModificationFunctionMappingPropertyParameterTypeMismatch, this.m_parentLoader.m_sourceLocation, lineInfo, this.m_parentLoader.m_parsingErrors);
				}
				this.m_members.Push(edmMember);
				global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmMember> members = this.m_members;
				global::System.Data.Entity.Core.Metadata.Edm.AssociationSet associationSet = this.m_associationSetNavigation;
				if (this.m_members.Last<global::System.Data.Entity.Core.Metadata.Edm.EdmMember>().BuiltInTypeKind == global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.AssociationEndMember)
				{
					global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember associationEndMember = (global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember)this.m_members.Last<global::System.Data.Entity.Core.Metadata.Edm.EdmMember>();
					global::System.Data.Entity.Core.Metadata.Edm.AssociationType associationType = (global::System.Data.Entity.Core.Metadata.Edm.AssociationType)associationEndMember.DeclaringType;
					if (associationType.IsForeignKey)
					{
						global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint referentialConstraint = associationType.ReferentialConstraints.Single<global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint>();
						if (referentialConstraint.FromRole == associationEndMember)
						{
							int index = referentialConstraint.FromProperties.IndexOf((global::System.Data.Entity.Core.Metadata.Edm.EdmProperty)this.m_members.First<global::System.Data.Entity.Core.Metadata.Edm.EdmMember>());
							members = new global::System.Data.Entity.Core.Metadata.Edm.EdmMember[]
							{
								referentialConstraint.ToProperties[index]
							};
							associationSet = null;
						}
					}
				}
				global::System.Data.Entity.Core.Mapping.ModificationFunctionParameterBinding result = new global::System.Data.Entity.Core.Mapping.ModificationFunctionParameterBinding(functionParameter, new global::System.Data.Entity.Core.Mapping.ModificationFunctionMemberPath(members, associationSet), flag);
				this.m_members.Pop();
				this.m_seenParameters.Add(functionParameter);
				return result;
			}

			// Token: 0x060065BE RID: 26046 RVA: 0x0015D358 File Offset: 0x0015B558
			private global::System.Data.Entity.Core.Metadata.Edm.EdmFunction LoadAndValidateFunctionMetadata(global::System.Xml.XPath.XPathNavigator nav, out global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter rowsAffectedParameter)
			{
				global::System.Xml.IXmlLineInfo lineInfo = (global::System.Xml.IXmlLineInfo)nav;
				this.m_seenParameters.Clear();
				string aliasResolvedAttributeValue = this.m_parentLoader.GetAliasResolvedAttributeValue(nav.Clone(), "FunctionName");
				rowsAffectedParameter = null;
				global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction> functions = this.m_storeItemCollection.GetFunctions(aliasResolvedAttributeValue);
				if (functions.Count == 0)
				{
					global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrorsWithMemberInfo(new global::System.Func<object, string>(global::System.Data.Entity.Resources.Strings.Mapping_ModificationFunction_UnknownFunction), aliasResolvedAttributeValue, global::System.Data.Entity.Core.Mapping.MappingErrorCode.InvalidModificationFunctionMappingUnknownFunction, this.m_parentLoader.m_sourceLocation, lineInfo, this.m_parentLoader.m_parsingErrors);
					return null;
				}
				if (1 < functions.Count)
				{
					global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrorsWithMemberInfo(new global::System.Func<object, string>(global::System.Data.Entity.Resources.Strings.Mapping_ModificationFunction_AmbiguousFunction), aliasResolvedAttributeValue, global::System.Data.Entity.Core.Mapping.MappingErrorCode.InvalidModificationFunctionMappingAmbiguousFunction, this.m_parentLoader.m_sourceLocation, lineInfo, this.m_parentLoader.m_parsingErrors);
					return null;
				}
				global::System.Data.Entity.Core.Metadata.Edm.EdmFunction edmFunction = functions[0];
				if (global::System.Data.Entity.Core.Common.Utils.MetadataHelper.IsComposable(edmFunction))
				{
					global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrorsWithMemberInfo(new global::System.Func<object, string>(global::System.Data.Entity.Resources.Strings.Mapping_ModificationFunction_NotValidFunction), aliasResolvedAttributeValue, global::System.Data.Entity.Core.Mapping.MappingErrorCode.InvalidModificationFunctionMappingNotValidFunction, this.m_parentLoader.m_sourceLocation, lineInfo, this.m_parentLoader.m_parsingErrors);
					return null;
				}
				string attributeValue = global::System.Data.Entity.Core.Mapping.MappingItemLoader.GetAttributeValue(nav, "RowsAffectedParameter");
				if (!string.IsNullOrEmpty(attributeValue))
				{
					if (!edmFunction.Parameters.TryGetValue(attributeValue, false, out rowsAffectedParameter))
					{
						global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrorWithMessage(global::System.Data.Entity.Resources.Strings.Mapping_FunctionImport_RowsAffectedParameterDoesNotExist(attributeValue, edmFunction.FullName), global::System.Data.Entity.Core.Mapping.MappingErrorCode.MappingFunctionImportRowsAffectedParameterDoesNotExist, this.m_parentLoader.m_sourceLocation, lineInfo, this.m_parentLoader.m_parsingErrors);
						return null;
					}
					if (global::System.Data.Entity.Core.Metadata.Edm.ParameterMode.Out != rowsAffectedParameter.Mode && global::System.Data.Entity.Core.Metadata.Edm.ParameterMode.InOut != rowsAffectedParameter.Mode)
					{
						global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrorWithMessage(global::System.Data.Entity.Resources.Strings.Mapping_FunctionImport_RowsAffectedParameterHasWrongMode(attributeValue, rowsAffectedParameter.Mode, global::System.Data.Entity.Core.Metadata.Edm.ParameterMode.Out, global::System.Data.Entity.Core.Metadata.Edm.ParameterMode.InOut), global::System.Data.Entity.Core.Mapping.MappingErrorCode.MappingFunctionImportRowsAffectedParameterHasWrongMode, this.m_parentLoader.m_sourceLocation, lineInfo, this.m_parentLoader.m_parsingErrors);
						return null;
					}
					global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType primitiveType = (global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType)rowsAffectedParameter.TypeUsage.EdmType;
					if (!global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsIntegerNumericType(rowsAffectedParameter.TypeUsage))
					{
						global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrorWithMessage(global::System.Data.Entity.Resources.Strings.Mapping_FunctionImport_RowsAffectedParameterHasWrongType(attributeValue, primitiveType.PrimitiveTypeKind), global::System.Data.Entity.Core.Mapping.MappingErrorCode.MappingFunctionImportRowsAffectedParameterHasWrongType, this.m_parentLoader.m_sourceLocation, lineInfo, this.m_parentLoader.m_parsingErrors);
						return null;
					}
					this.m_seenParameters.Add(rowsAffectedParameter);
				}
				foreach (global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter functionParameter in edmFunction.Parameters)
				{
					if (functionParameter.Mode != global::System.Data.Entity.Core.Metadata.Edm.ParameterMode.In && attributeValue != functionParameter.Name)
					{
						global::System.Data.Entity.Core.Mapping.MappingItemLoader.AddToSchemaErrorWithMessage(global::System.Data.Entity.Resources.Strings.Mapping_ModificationFunction_NotValidFunctionParameter(aliasResolvedAttributeValue, functionParameter.Name, "RowsAffectedParameter"), global::System.Data.Entity.Core.Mapping.MappingErrorCode.InvalidModificationFunctionMappingNotValidFunctionParameter, this.m_parentLoader.m_sourceLocation, lineInfo, this.m_parentLoader.m_parsingErrors);
						return null;
					}
				}
				return edmFunction;
			}

			// Token: 0x04002D83 RID: 11651
			private readonly global::System.Data.Entity.Core.Mapping.MappingItemLoader m_parentLoader;

			// Token: 0x04002D84 RID: 11652
			private global::System.Data.Entity.Core.Metadata.Edm.EdmFunction m_function;

			// Token: 0x04002D85 RID: 11653
			private readonly global::System.Data.Entity.Core.Metadata.Edm.EntitySet m_entitySet;

			// Token: 0x04002D86 RID: 11654
			private readonly global::System.Data.Entity.Core.Metadata.Edm.AssociationSet m_associationSet;

			// Token: 0x04002D87 RID: 11655
			private readonly global::System.Data.Entity.Core.Metadata.Edm.EntityContainer m_modelContainer;

			// Token: 0x04002D88 RID: 11656
			private readonly global::System.Data.Entity.Core.Metadata.Edm.EdmItemCollection m_edmItemCollection;

			// Token: 0x04002D89 RID: 11657
			private readonly global::System.Data.Entity.Core.Metadata.Edm.StoreItemCollection m_storeItemCollection;

			// Token: 0x04002D8A RID: 11658
			private bool m_allowCurrentVersion;

			// Token: 0x04002D8B RID: 11659
			private bool m_allowOriginalVersion;

			// Token: 0x04002D8C RID: 11660
			private readonly global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter> m_seenParameters;

			// Token: 0x04002D8D RID: 11661
			private readonly global::System.Collections.Generic.Stack<global::System.Data.Entity.Core.Metadata.Edm.EdmMember> m_members;

			// Token: 0x04002D8E RID: 11662
			private global::System.Data.Entity.Core.Metadata.Edm.AssociationSet m_associationSetNavigation;
		}
	}
}
