using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Resources;
using System.Diagnostics;
using System.Globalization;
using System.Xml;

namespace System.Data.Entity.Core.SchemaObjectModel
{
	// Token: 0x020002E7 RID: 743
	[global::System.Diagnostics.DebuggerDisplay("Name={Name}")]
	internal sealed class EntityContainer : global::System.Data.Entity.Core.SchemaObjectModel.SchemaType
	{
		// Token: 0x06002366 RID: 9062 RVA: 0x00062D28 File Offset: 0x00060F28
		public EntityContainer(global::System.Data.Entity.Core.SchemaObjectModel.Schema parentElement) : base(parentElement)
		{
			if (base.Schema.DataModel == global::System.Data.Entity.Core.SchemaObjectModel.SchemaDataModelOption.EntityDataModel)
			{
				base.OtherContent.Add(base.Schema.SchemaSource);
			}
		}

		// Token: 0x17000764 RID: 1892
		// (get) Token: 0x06002367 RID: 9063 RVA: 0x00062D54 File Offset: 0x00060F54
		private global::System.Data.Entity.Core.SchemaObjectModel.SchemaElementLookUpTable<global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement> Members
		{
			get
			{
				if (this._members == null)
				{
					this._members = new global::System.Data.Entity.Core.SchemaObjectModel.SchemaElementLookUpTable<global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement>();
				}
				return this._members;
			}
		}

		// Token: 0x17000765 RID: 1893
		// (get) Token: 0x06002368 RID: 9064 RVA: 0x00062D6F File Offset: 0x00060F6F
		public global::System.Data.Entity.Core.SchemaObjectModel.ISchemaElementLookUpTable<global::System.Data.Entity.Core.SchemaObjectModel.EntityContainerEntitySet> EntitySets
		{
			get
			{
				if (this._entitySets == null)
				{
					this._entitySets = new global::System.Data.Entity.Core.SchemaObjectModel.FilteredSchemaElementLookUpTable<global::System.Data.Entity.Core.SchemaObjectModel.EntityContainerEntitySet, global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement>(this.Members);
				}
				return this._entitySets;
			}
		}

		// Token: 0x17000766 RID: 1894
		// (get) Token: 0x06002369 RID: 9065 RVA: 0x00062D90 File Offset: 0x00060F90
		public global::System.Data.Entity.Core.SchemaObjectModel.ISchemaElementLookUpTable<global::System.Data.Entity.Core.SchemaObjectModel.EntityContainerRelationshipSet> RelationshipSets
		{
			get
			{
				if (this._relationshipSets == null)
				{
					this._relationshipSets = new global::System.Data.Entity.Core.SchemaObjectModel.FilteredSchemaElementLookUpTable<global::System.Data.Entity.Core.SchemaObjectModel.EntityContainerRelationshipSet, global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement>(this.Members);
				}
				return this._relationshipSets;
			}
		}

		// Token: 0x17000767 RID: 1895
		// (get) Token: 0x0600236A RID: 9066 RVA: 0x00062DB1 File Offset: 0x00060FB1
		public global::System.Data.Entity.Core.SchemaObjectModel.ISchemaElementLookUpTable<global::System.Data.Entity.Core.SchemaObjectModel.Function> FunctionImports
		{
			get
			{
				if (this._functionImports == null)
				{
					this._functionImports = new global::System.Data.Entity.Core.SchemaObjectModel.FilteredSchemaElementLookUpTable<global::System.Data.Entity.Core.SchemaObjectModel.Function, global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement>(this.Members);
				}
				return this._functionImports;
			}
		}

		// Token: 0x17000768 RID: 1896
		// (get) Token: 0x0600236B RID: 9067 RVA: 0x00062DD2 File Offset: 0x00060FD2
		public global::System.Data.Entity.Core.SchemaObjectModel.EntityContainer ExtendingEntityContainer
		{
			get
			{
				return this._entityContainerGettingExtended;
			}
		}

		// Token: 0x0600236C RID: 9068 RVA: 0x00062DDA File Offset: 0x00060FDA
		protected override bool HandleAttribute(global::System.Xml.XmlReader reader)
		{
			if (base.HandleAttribute(reader))
			{
				return true;
			}
			if (global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement.CanHandleAttribute(reader, "Extends"))
			{
				this.HandleExtendsAttribute(reader);
				return true;
			}
			return false;
		}

		// Token: 0x0600236D RID: 9069 RVA: 0x00062E00 File Offset: 0x00061000
		protected override bool HandleElement(global::System.Xml.XmlReader reader)
		{
			if (base.HandleElement(reader))
			{
				return true;
			}
			if (base.CanHandleElement(reader, "EntitySet"))
			{
				this.HandleEntitySetElement(reader);
				return true;
			}
			if (base.CanHandleElement(reader, "AssociationSet"))
			{
				this.HandleAssociationSetElement(reader);
				return true;
			}
			if (base.CanHandleElement(reader, "FunctionImport"))
			{
				this.HandleFunctionImport(reader);
				return true;
			}
			if (base.Schema.DataModel == global::System.Data.Entity.Core.SchemaObjectModel.SchemaDataModelOption.EntityDataModel)
			{
				if (base.CanHandleElement(reader, "ValueAnnotation"))
				{
					this.SkipElement(reader);
					return true;
				}
				if (base.CanHandleElement(reader, "TypeAnnotation"))
				{
					this.SkipElement(reader);
					return true;
				}
			}
			return false;
		}

		// Token: 0x0600236E RID: 9070 RVA: 0x00062E9C File Offset: 0x0006109C
		private void HandleEntitySetElement(global::System.Xml.XmlReader reader)
		{
			global::System.Data.Entity.Core.SchemaObjectModel.EntityContainerEntitySet entityContainerEntitySet = new global::System.Data.Entity.Core.SchemaObjectModel.EntityContainerEntitySet(this);
			entityContainerEntitySet.Parse(reader);
			this.Members.Add(entityContainerEntitySet, true, new global::System.Func<object, string>(global::System.Data.Entity.Resources.Strings.DuplicateEntityContainerMemberName));
		}

		// Token: 0x0600236F RID: 9071 RVA: 0x00062ED0 File Offset: 0x000610D0
		private void HandleAssociationSetElement(global::System.Xml.XmlReader reader)
		{
			global::System.Data.Entity.Core.SchemaObjectModel.EntityContainerAssociationSet entityContainerAssociationSet = new global::System.Data.Entity.Core.SchemaObjectModel.EntityContainerAssociationSet(this);
			entityContainerAssociationSet.Parse(reader);
			this.Members.Add(entityContainerAssociationSet, true, new global::System.Func<object, string>(global::System.Data.Entity.Resources.Strings.DuplicateEntityContainerMemberName));
		}

		// Token: 0x06002370 RID: 9072 RVA: 0x00062F04 File Offset: 0x00061104
		private void HandleFunctionImport(global::System.Xml.XmlReader reader)
		{
			global::System.Data.Entity.Core.SchemaObjectModel.FunctionImportElement functionImportElement = new global::System.Data.Entity.Core.SchemaObjectModel.FunctionImportElement(this);
			functionImportElement.Parse(reader);
			this.Members.Add(functionImportElement, true, new global::System.Func<object, string>(global::System.Data.Entity.Resources.Strings.DuplicateEntityContainerMemberName));
		}

		// Token: 0x06002371 RID: 9073 RVA: 0x00062F38 File Offset: 0x00061138
		private void HandleExtendsAttribute(global::System.Xml.XmlReader reader)
		{
			this._unresolvedExtendedEntityContainerName = base.HandleUndottedNameAttribute(reader, this._unresolvedExtendedEntityContainerName);
		}

		// Token: 0x06002372 RID: 9074 RVA: 0x00062F50 File Offset: 0x00061150
		internal override void ResolveTopLevelNames()
		{
			if (!this._isAlreadyResolved)
			{
				base.ResolveTopLevelNames();
				if (!string.IsNullOrEmpty(this._unresolvedExtendedEntityContainerName))
				{
					global::System.Data.Entity.Core.SchemaObjectModel.SchemaType schemaType;
					if (this._unresolvedExtendedEntityContainerName == this.Name)
					{
						base.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.EntityContainerCannotExtendItself, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, global::System.Data.Entity.Resources.Strings.EntityContainerCannotExtendItself(this.Name));
					}
					else if (!base.Schema.SchemaManager.TryResolveType(null, this._unresolvedExtendedEntityContainerName, out schemaType))
					{
						base.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.InvalidEntityContainerNameInExtends, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, global::System.Data.Entity.Resources.Strings.InvalidEntityContainerNameInExtends(this._unresolvedExtendedEntityContainerName));
					}
					else
					{
						this._entityContainerGettingExtended = (global::System.Data.Entity.Core.SchemaObjectModel.EntityContainer)schemaType;
						this._entityContainerGettingExtended.ResolveTopLevelNames();
					}
				}
				foreach (global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement schemaElement in this.Members)
				{
					schemaElement.ResolveTopLevelNames();
				}
				this._isAlreadyResolved = true;
			}
		}

		// Token: 0x06002373 RID: 9075 RVA: 0x00063038 File Offset: 0x00061238
		internal override void ResolveSecondLevelNames()
		{
			base.ResolveSecondLevelNames();
			foreach (global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement schemaElement in this.Members)
			{
				schemaElement.ResolveSecondLevelNames();
			}
		}

		// Token: 0x06002374 RID: 9076 RVA: 0x00063088 File Offset: 0x00061288
		internal override void Validate()
		{
			if (!this._isAlreadyValidated)
			{
				base.Validate();
				if (this.ExtendingEntityContainer != null)
				{
					this.ExtendingEntityContainer.Validate();
					foreach (global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement schemaElement in this.ExtendingEntityContainer.Members)
					{
						global::System.Data.Entity.Core.SchemaObjectModel.AddErrorKind error = this.Members.TryAdd(schemaElement.Clone(this));
						this.DuplicateOrEquivalentMemberNameWhileExtendingEntityContainer(schemaElement, error);
					}
				}
				global::System.Collections.Generic.HashSet<string> tableKeys = new global::System.Collections.Generic.HashSet<string>();
				foreach (global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement schemaElement2 in this.Members)
				{
					global::System.Data.Entity.Core.SchemaObjectModel.EntityContainerEntitySet entityContainerEntitySet = schemaElement2 as global::System.Data.Entity.Core.SchemaObjectModel.EntityContainerEntitySet;
					if (entityContainerEntitySet != null && base.Schema.DataModel == global::System.Data.Entity.Core.SchemaObjectModel.SchemaDataModelOption.ProviderDataModel)
					{
						this.CheckForDuplicateTableMapping(tableKeys, entityContainerEntitySet);
					}
					schemaElement2.Validate();
				}
				this.ValidateRelationshipSetHaveUniqueEnds();
				this.ValidateOnlyBaseEntitySetTypeDefinesConcurrency();
				this._isAlreadyValidated = true;
			}
		}

		// Token: 0x06002375 RID: 9077 RVA: 0x00063188 File Offset: 0x00061388
		internal global::System.Data.Entity.Core.SchemaObjectModel.EntityContainerEntitySet FindEntitySet(string name)
		{
			for (global::System.Data.Entity.Core.SchemaObjectModel.EntityContainer entityContainer = this; entityContainer != null; entityContainer = entityContainer.ExtendingEntityContainer)
			{
				foreach (global::System.Data.Entity.Core.SchemaObjectModel.EntityContainerEntitySet entityContainerEntitySet in entityContainer.EntitySets)
				{
					if (global::System.Data.Entity.Core.SchemaObjectModel.Utils.CompareNames(entityContainerEntitySet.Name, name) == 0)
					{
						return entityContainerEntitySet;
					}
				}
			}
			return null;
		}

		// Token: 0x06002376 RID: 9078 RVA: 0x000631F4 File Offset: 0x000613F4
		private void DuplicateOrEquivalentMemberNameWhileExtendingEntityContainer(global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement schemaElement, global::System.Data.Entity.Core.SchemaObjectModel.AddErrorKind error)
		{
			if (error != global::System.Data.Entity.Core.SchemaObjectModel.AddErrorKind.Succeeded)
			{
				schemaElement.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.AlreadyDefined, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, global::System.Data.Entity.Resources.Strings.DuplicateMemberNameInExtendedEntityContainer(schemaElement.Name, this.ExtendingEntityContainer.Name, this.Name));
			}
		}

		// Token: 0x06002377 RID: 9079 RVA: 0x00063220 File Offset: 0x00061420
		private void ValidateOnlyBaseEntitySetTypeDefinesConcurrency()
		{
			global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.SchemaObjectModel.SchemaEntityType, global::System.Data.Entity.Core.SchemaObjectModel.EntityContainerEntitySet> dictionary = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.SchemaObjectModel.SchemaEntityType, global::System.Data.Entity.Core.SchemaObjectModel.EntityContainerEntitySet>();
			foreach (global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement schemaElement in this.Members)
			{
				global::System.Data.Entity.Core.SchemaObjectModel.EntityContainerEntitySet entityContainerEntitySet = schemaElement as global::System.Data.Entity.Core.SchemaObjectModel.EntityContainerEntitySet;
				if (entityContainerEntitySet != null && !dictionary.ContainsKey(entityContainerEntitySet.EntityType))
				{
					dictionary.Add(entityContainerEntitySet.EntityType, entityContainerEntitySet);
				}
			}
			foreach (global::System.Data.Entity.Core.SchemaObjectModel.SchemaType schemaType in base.Schema.SchemaTypes)
			{
				global::System.Data.Entity.Core.SchemaObjectModel.SchemaEntityType schemaEntityType = schemaType as global::System.Data.Entity.Core.SchemaObjectModel.SchemaEntityType;
				global::System.Data.Entity.Core.SchemaObjectModel.EntityContainerEntitySet entityContainerEntitySet2;
				if (schemaEntityType != null && global::System.Data.Entity.Core.SchemaObjectModel.EntityContainer.TypeIsSubTypeOf(schemaEntityType, dictionary, out entityContainerEntitySet2) && global::System.Data.Entity.Core.SchemaObjectModel.EntityContainer.TypeDefinesNewConcurrencyProperties(schemaEntityType))
				{
					base.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.ConcurrencyRedefinedOnSubTypeOfEntitySetType, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, global::System.Data.Entity.Resources.Strings.ConcurrencyRedefinedOnSubTypeOfEntitySetType(schemaEntityType.FQName, entityContainerEntitySet2.EntityType.FQName, entityContainerEntitySet2.FQName));
				}
			}
		}

		// Token: 0x06002378 RID: 9080 RVA: 0x0006331C File Offset: 0x0006151C
		private void ValidateRelationshipSetHaveUniqueEnds()
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.SchemaObjectModel.EntityContainerRelationshipSetEnd> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.SchemaObjectModel.EntityContainerRelationshipSetEnd>();
			bool flag = true;
			foreach (global::System.Data.Entity.Core.SchemaObjectModel.EntityContainerRelationshipSet entityContainerRelationshipSet in this.RelationshipSets)
			{
				foreach (global::System.Data.Entity.Core.SchemaObjectModel.EntityContainerRelationshipSetEnd entityContainerRelationshipSetEnd in entityContainerRelationshipSet.Ends)
				{
					flag = false;
					foreach (global::System.Data.Entity.Core.SchemaObjectModel.EntityContainerRelationshipSetEnd entityContainerRelationshipSetEnd2 in list)
					{
						if (global::System.Data.Entity.Core.SchemaObjectModel.EntityContainer.AreRelationshipEndsEqual(entityContainerRelationshipSetEnd2, entityContainerRelationshipSetEnd))
						{
							base.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.SimilarRelationshipEnd, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, global::System.Data.Entity.Resources.Strings.SimilarRelationshipEnd(entityContainerRelationshipSetEnd2.Name, entityContainerRelationshipSetEnd2.ParentElement.Name, entityContainerRelationshipSetEnd.ParentElement.Name, entityContainerRelationshipSetEnd2.EntitySet.Name, this.FQName));
							flag = true;
							break;
						}
					}
					if (!flag)
					{
						list.Add(entityContainerRelationshipSetEnd);
					}
				}
			}
		}

		// Token: 0x06002379 RID: 9081 RVA: 0x00063440 File Offset: 0x00061640
		private static bool TypeIsSubTypeOf(global::System.Data.Entity.Core.SchemaObjectModel.SchemaEntityType itemType, global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.SchemaObjectModel.SchemaEntityType, global::System.Data.Entity.Core.SchemaObjectModel.EntityContainerEntitySet> baseEntitySetTypes, out global::System.Data.Entity.Core.SchemaObjectModel.EntityContainerEntitySet set)
		{
			if (itemType.IsTypeHierarchyRoot)
			{
				set = null;
				return false;
			}
			for (global::System.Data.Entity.Core.SchemaObjectModel.SchemaEntityType schemaEntityType = itemType.BaseType as global::System.Data.Entity.Core.SchemaObjectModel.SchemaEntityType; schemaEntityType != null; schemaEntityType = (schemaEntityType.BaseType as global::System.Data.Entity.Core.SchemaObjectModel.SchemaEntityType))
			{
				if (baseEntitySetTypes.ContainsKey(schemaEntityType))
				{
					set = baseEntitySetTypes[schemaEntityType];
					return true;
				}
			}
			set = null;
			return false;
		}

		// Token: 0x0600237A RID: 9082 RVA: 0x00063490 File Offset: 0x00061690
		private static bool TypeDefinesNewConcurrencyProperties(global::System.Data.Entity.Core.SchemaObjectModel.SchemaEntityType itemType)
		{
			foreach (global::System.Data.Entity.Core.SchemaObjectModel.StructuredProperty structuredProperty in itemType.Properties)
			{
				if (structuredProperty.Type is global::System.Data.Entity.Core.SchemaObjectModel.ScalarType && global::System.Data.Entity.Core.Common.Utils.MetadataHelper.GetConcurrencyMode(structuredProperty.TypeUsage) != global::System.Data.Entity.Core.Metadata.Edm.ConcurrencyMode.None)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x17000769 RID: 1897
		// (get) Token: 0x0600237B RID: 9083 RVA: 0x000634F8 File Offset: 0x000616F8
		public override string FQName
		{
			get
			{
				return this.Name;
			}
		}

		// Token: 0x1700076A RID: 1898
		// (get) Token: 0x0600237C RID: 9084 RVA: 0x00063500 File Offset: 0x00061700
		public override string Identity
		{
			get
			{
				return this.Name;
			}
		}

		// Token: 0x0600237D RID: 9085 RVA: 0x00063508 File Offset: 0x00061708
		private void CheckForDuplicateTableMapping(global::System.Collections.Generic.HashSet<string> tableKeys, global::System.Data.Entity.Core.SchemaObjectModel.EntityContainerEntitySet entitySet)
		{
			string text;
			if (string.IsNullOrEmpty(entitySet.DbSchema))
			{
				text = this.Name;
			}
			else
			{
				text = entitySet.DbSchema;
			}
			string text2;
			if (string.IsNullOrEmpty(entitySet.Table))
			{
				text2 = entitySet.Name;
			}
			else
			{
				text2 = entitySet.Table;
			}
			string item = string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "{0}.{1}", new object[]
			{
				text,
				text2
			});
			if (entitySet.DefiningQuery != null)
			{
				item = entitySet.Name;
			}
			if (!tableKeys.Add(item))
			{
				entitySet.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.AlreadyDefined, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, global::System.Data.Entity.Resources.Strings.DuplicateEntitySetTable(entitySet.Name, text, text2));
			}
		}

		// Token: 0x0600237E RID: 9086 RVA: 0x0006359E File Offset: 0x0006179E
		private static bool AreRelationshipEndsEqual(global::System.Data.Entity.Core.SchemaObjectModel.EntityContainerRelationshipSetEnd left, global::System.Data.Entity.Core.SchemaObjectModel.EntityContainerRelationshipSetEnd right)
		{
			return left.EntitySet == right.EntitySet && left.ParentElement.Relationship == right.ParentElement.Relationship && left.Name == right.Name;
		}

		// Token: 0x04000C18 RID: 3096
		private global::System.Data.Entity.Core.SchemaObjectModel.SchemaElementLookUpTable<global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement> _members;

		// Token: 0x04000C19 RID: 3097
		private global::System.Data.Entity.Core.SchemaObjectModel.ISchemaElementLookUpTable<global::System.Data.Entity.Core.SchemaObjectModel.EntityContainerEntitySet> _entitySets;

		// Token: 0x04000C1A RID: 3098
		private global::System.Data.Entity.Core.SchemaObjectModel.ISchemaElementLookUpTable<global::System.Data.Entity.Core.SchemaObjectModel.EntityContainerRelationshipSet> _relationshipSets;

		// Token: 0x04000C1B RID: 3099
		private global::System.Data.Entity.Core.SchemaObjectModel.ISchemaElementLookUpTable<global::System.Data.Entity.Core.SchemaObjectModel.Function> _functionImports;

		// Token: 0x04000C1C RID: 3100
		private string _unresolvedExtendedEntityContainerName;

		// Token: 0x04000C1D RID: 3101
		private global::System.Data.Entity.Core.SchemaObjectModel.EntityContainer _entityContainerGettingExtended;

		// Token: 0x04000C1E RID: 3102
		private bool _isAlreadyValidated;

		// Token: 0x04000C1F RID: 3103
		private bool _isAlreadyResolved;
	}
}
