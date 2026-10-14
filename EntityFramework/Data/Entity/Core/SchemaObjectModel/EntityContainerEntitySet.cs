using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Resources;
using System.Xml;

namespace System.Data.Entity.Core.SchemaObjectModel
{
	// Token: 0x020002EA RID: 746
	internal sealed class EntityContainerEntitySet : global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement
	{
		// Token: 0x06002393 RID: 9107 RVA: 0x00063AB1 File Offset: 0x00061CB1
		public EntityContainerEntitySet(global::System.Data.Entity.Core.SchemaObjectModel.EntityContainer parentElement) : base(parentElement, null)
		{
		}

		// Token: 0x1700076E RID: 1902
		// (get) Token: 0x06002394 RID: 9108 RVA: 0x00063ABB File Offset: 0x00061CBB
		public override string FQName
		{
			get
			{
				return base.ParentElement.Name + "." + this.Name;
			}
		}

		// Token: 0x1700076F RID: 1903
		// (get) Token: 0x06002395 RID: 9109 RVA: 0x00063AD8 File Offset: 0x00061CD8
		public global::System.Data.Entity.Core.SchemaObjectModel.SchemaEntityType EntityType
		{
			get
			{
				return this._entityType;
			}
		}

		// Token: 0x17000770 RID: 1904
		// (get) Token: 0x06002396 RID: 9110 RVA: 0x00063AE0 File Offset: 0x00061CE0
		public string DbSchema
		{
			get
			{
				return this._schema;
			}
		}

		// Token: 0x17000771 RID: 1905
		// (get) Token: 0x06002397 RID: 9111 RVA: 0x00063AE8 File Offset: 0x00061CE8
		public string Table
		{
			get
			{
				return this._table;
			}
		}

		// Token: 0x17000772 RID: 1906
		// (get) Token: 0x06002398 RID: 9112 RVA: 0x00063AF0 File Offset: 0x00061CF0
		public string DefiningQuery
		{
			get
			{
				if (this._definingQueryElement != null)
				{
					return this._definingQueryElement.Query;
				}
				return null;
			}
		}

		// Token: 0x06002399 RID: 9113 RVA: 0x00063B08 File Offset: 0x00061D08
		protected override bool HandleElement(global::System.Xml.XmlReader reader)
		{
			if (base.HandleElement(reader))
			{
				return true;
			}
			if (base.Schema.DataModel == global::System.Data.Entity.Core.SchemaObjectModel.SchemaDataModelOption.ProviderDataModel)
			{
				if (base.CanHandleElement(reader, "DefiningQuery"))
				{
					this.HandleDefiningQueryElement(reader);
					return true;
				}
			}
			else if (base.Schema.DataModel == global::System.Data.Entity.Core.SchemaObjectModel.SchemaDataModelOption.EntityDataModel)
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

		// Token: 0x0600239A RID: 9114 RVA: 0x00063B84 File Offset: 0x00061D84
		protected override bool HandleAttribute(global::System.Xml.XmlReader reader)
		{
			if (base.HandleAttribute(reader))
			{
				return true;
			}
			if (global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement.CanHandleAttribute(reader, "EntityType"))
			{
				this.HandleEntityTypeAttribute(reader);
				return true;
			}
			if (base.Schema.DataModel == global::System.Data.Entity.Core.SchemaObjectModel.SchemaDataModelOption.ProviderDataModel)
			{
				if (global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement.CanHandleAttribute(reader, "Schema"))
				{
					this.HandleDbSchemaAttribute(reader);
					return true;
				}
				if (global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement.CanHandleAttribute(reader, "Table"))
				{
					this.HandleTableAttribute(reader);
					return true;
				}
			}
			return false;
		}

		// Token: 0x0600239B RID: 9115 RVA: 0x00063BF0 File Offset: 0x00061DF0
		private void HandleDefiningQueryElement(global::System.Xml.XmlReader reader)
		{
			global::System.Data.Entity.Core.SchemaObjectModel.EntityContainerEntitySetDefiningQuery entityContainerEntitySetDefiningQuery = new global::System.Data.Entity.Core.SchemaObjectModel.EntityContainerEntitySetDefiningQuery(this);
			entityContainerEntitySetDefiningQuery.Parse(reader);
			this._definingQueryElement = entityContainerEntitySetDefiningQuery;
		}

		// Token: 0x0600239C RID: 9116 RVA: 0x00063C12 File Offset: 0x00061E12
		protected override void HandleNameAttribute(global::System.Xml.XmlReader reader)
		{
			if (base.Schema.DataModel == global::System.Data.Entity.Core.SchemaObjectModel.SchemaDataModelOption.ProviderDataModel)
			{
				this.Name = reader.Value;
				return;
			}
			base.HandleNameAttribute(reader);
		}

		// Token: 0x0600239D RID: 9117 RVA: 0x00063C38 File Offset: 0x00061E38
		private void HandleEntityTypeAttribute(global::System.Xml.XmlReader reader)
		{
			global::System.Data.Entity.Core.SchemaObjectModel.ReturnValue<string> returnValue = base.HandleDottedNameAttribute(reader, this._unresolvedEntityTypeName);
			if (returnValue.Succeeded)
			{
				this._unresolvedEntityTypeName = returnValue.Value;
			}
		}

		// Token: 0x0600239E RID: 9118 RVA: 0x00063C67 File Offset: 0x00061E67
		private void HandleDbSchemaAttribute(global::System.Xml.XmlReader reader)
		{
			this._schema = reader.Value;
		}

		// Token: 0x0600239F RID: 9119 RVA: 0x00063C75 File Offset: 0x00061E75
		private void HandleTableAttribute(global::System.Xml.XmlReader reader)
		{
			this._table = reader.Value;
		}

		// Token: 0x060023A0 RID: 9120 RVA: 0x00063C84 File Offset: 0x00061E84
		internal override void ResolveTopLevelNames()
		{
			base.ResolveTopLevelNames();
			if (this._entityType == null)
			{
				global::System.Data.Entity.Core.SchemaObjectModel.SchemaType schemaType = null;
				if (!base.Schema.ResolveTypeName(this, this._unresolvedEntityTypeName, out schemaType))
				{
					return;
				}
				this._entityType = (schemaType as global::System.Data.Entity.Core.SchemaObjectModel.SchemaEntityType);
				if (this._entityType == null)
				{
					base.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.InvalidPropertyType, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, global::System.Data.Entity.Resources.Strings.InvalidEntitySetType(this._unresolvedEntityTypeName));
					return;
				}
			}
		}

		// Token: 0x060023A1 RID: 9121 RVA: 0x00063CE4 File Offset: 0x00061EE4
		internal override void Validate()
		{
			base.Validate();
			if (this._entityType.KeyProperties.Count == 0)
			{
				base.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.EntitySetTypeHasNoKeys, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, global::System.Data.Entity.Resources.Strings.EntitySetTypeHasNoKeys(this.Name, this._entityType.FQName));
			}
			if (this._definingQueryElement != null)
			{
				this._definingQueryElement.Validate();
				if (this.DbSchema != null || this.Table != null)
				{
					base.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.TableAndSchemaAreMutuallyExclusiveWithDefiningQuery, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, global::System.Data.Entity.Resources.Strings.TableAndSchemaAreMutuallyExclusiveWithDefiningQuery(this.FQName));
				}
			}
		}

		// Token: 0x060023A2 RID: 9122 RVA: 0x00063D68 File Offset: 0x00061F68
		internal override global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement Clone(global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement parentElement)
		{
			return new global::System.Data.Entity.Core.SchemaObjectModel.EntityContainerEntitySet((global::System.Data.Entity.Core.SchemaObjectModel.EntityContainer)parentElement)
			{
				_definingQueryElement = this._definingQueryElement,
				_entityType = this._entityType,
				_schema = this._schema,
				_table = this._table,
				Name = this.Name
			};
		}

		// Token: 0x04000C23 RID: 3107
		private global::System.Data.Entity.Core.SchemaObjectModel.SchemaEntityType _entityType;

		// Token: 0x04000C24 RID: 3108
		private string _unresolvedEntityTypeName;

		// Token: 0x04000C25 RID: 3109
		private string _schema;

		// Token: 0x04000C26 RID: 3110
		private string _table;

		// Token: 0x04000C27 RID: 3111
		private global::System.Data.Entity.Core.SchemaObjectModel.EntityContainerEntitySetDefiningQuery _definingQueryElement;
	}
}
