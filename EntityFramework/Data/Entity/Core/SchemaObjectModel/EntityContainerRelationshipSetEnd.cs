using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Resources;
using System.Xml;

namespace System.Data.Entity.Core.SchemaObjectModel
{
	// Token: 0x020002ED RID: 749
	internal class EntityContainerRelationshipSetEnd : global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement
	{
		// Token: 0x060023B5 RID: 9141 RVA: 0x000640E1 File Offset: 0x000622E1
		public EntityContainerRelationshipSetEnd(global::System.Data.Entity.Core.SchemaObjectModel.EntityContainerRelationshipSet parentElement) : base(parentElement, null)
		{
		}

		// Token: 0x17000778 RID: 1912
		// (get) Token: 0x060023B6 RID: 9142 RVA: 0x000640EB File Offset: 0x000622EB
		// (set) Token: 0x060023B7 RID: 9143 RVA: 0x000640F3 File Offset: 0x000622F3
		public global::System.Data.Entity.Core.SchemaObjectModel.IRelationshipEnd RelationshipEnd
		{
			get
			{
				return this._relationshipEnd;
			}
			internal set
			{
				this._relationshipEnd = value;
			}
		}

		// Token: 0x17000779 RID: 1913
		// (get) Token: 0x060023B8 RID: 9144 RVA: 0x000640FC File Offset: 0x000622FC
		// (set) Token: 0x060023B9 RID: 9145 RVA: 0x00064104 File Offset: 0x00062304
		public global::System.Data.Entity.Core.SchemaObjectModel.EntityContainerEntitySet EntitySet
		{
			get
			{
				return this._entitySet;
			}
			internal set
			{
				this._entitySet = value;
			}
		}

		// Token: 0x060023BA RID: 9146 RVA: 0x0006410D File Offset: 0x0006230D
		protected override bool ProhibitAttribute(string namespaceUri, string localName)
		{
			if (base.ProhibitAttribute(namespaceUri, localName))
			{
				return true;
			}
			if (namespaceUri == null)
			{
				localName == "Name";
				return false;
			}
			return false;
		}

		// Token: 0x060023BB RID: 9147 RVA: 0x0006412D File Offset: 0x0006232D
		protected override bool HandleAttribute(global::System.Xml.XmlReader reader)
		{
			if (base.HandleAttribute(reader))
			{
				return true;
			}
			if (global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement.CanHandleAttribute(reader, "EntitySet"))
			{
				this.HandleEntitySetAttribute(reader);
				return true;
			}
			return false;
		}

		// Token: 0x060023BC RID: 9148 RVA: 0x00064151 File Offset: 0x00062351
		private void HandleEntitySetAttribute(global::System.Xml.XmlReader reader)
		{
			if (base.Schema.DataModel == global::System.Data.Entity.Core.SchemaObjectModel.SchemaDataModelOption.ProviderDataModel)
			{
				this._unresolvedEntitySetName = reader.Value;
				return;
			}
			this._unresolvedEntitySetName = base.HandleUndottedNameAttribute(reader, this._unresolvedEntitySetName);
		}

		// Token: 0x060023BD RID: 9149 RVA: 0x00064184 File Offset: 0x00062384
		internal override void ResolveTopLevelNames()
		{
			base.ResolveTopLevelNames();
			if (this._entitySet == null)
			{
				this._entitySet = this.ParentElement.ParentElement.FindEntitySet(this._unresolvedEntitySetName);
				if (this._entitySet == null)
				{
					base.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.InvalidEndEntitySet, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, global::System.Data.Entity.Resources.Strings.InvalidEntitySetNameReference(this._unresolvedEntitySetName, this.Name));
				}
			}
		}

		// Token: 0x060023BE RID: 9150 RVA: 0x000641E0 File Offset: 0x000623E0
		internal override void Validate()
		{
			base.Validate();
			if (this._relationshipEnd == null || this._entitySet == null)
			{
				return;
			}
			if (!this._relationshipEnd.Type.IsOfType(this._entitySet.EntityType) && !this._entitySet.EntityType.IsOfType(this._relationshipEnd.Type))
			{
				base.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.InvalidEndEntitySet, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, global::System.Data.Entity.Resources.Strings.InvalidEndEntitySetTypeMismatch(this._relationshipEnd.Name));
			}
		}

		// Token: 0x1700077A RID: 1914
		// (get) Token: 0x060023BF RID: 9151 RVA: 0x00064257 File Offset: 0x00062457
		internal new global::System.Data.Entity.Core.SchemaObjectModel.EntityContainerRelationshipSet ParentElement
		{
			get
			{
				return (global::System.Data.Entity.Core.SchemaObjectModel.EntityContainerRelationshipSet)base.ParentElement;
			}
		}

		// Token: 0x04000C2B RID: 3115
		private global::System.Data.Entity.Core.SchemaObjectModel.IRelationshipEnd _relationshipEnd;

		// Token: 0x04000C2C RID: 3116
		private string _unresolvedEntitySetName;

		// Token: 0x04000C2D RID: 3117
		private global::System.Data.Entity.Core.SchemaObjectModel.EntityContainerEntitySet _entitySet;
	}
}
