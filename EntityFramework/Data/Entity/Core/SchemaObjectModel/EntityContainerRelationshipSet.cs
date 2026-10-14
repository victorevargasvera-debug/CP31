using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Resources;
using System.Xml;

namespace System.Data.Entity.Core.SchemaObjectModel
{
	// Token: 0x020002EC RID: 748
	internal abstract class EntityContainerRelationshipSet : global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement
	{
		// Token: 0x060023A7 RID: 9127 RVA: 0x00063E03 File Offset: 0x00062003
		public EntityContainerRelationshipSet(global::System.Data.Entity.Core.SchemaObjectModel.EntityContainer parentElement) : base(parentElement, null)
		{
		}

		// Token: 0x17000774 RID: 1908
		// (get) Token: 0x060023A8 RID: 9128 RVA: 0x00063E0D File Offset: 0x0006200D
		public override string FQName
		{
			get
			{
				return this.ParentElement.Name + "." + this.Name;
			}
		}

		// Token: 0x17000775 RID: 1909
		// (get) Token: 0x060023A9 RID: 9129 RVA: 0x00063E2A File Offset: 0x0006202A
		// (set) Token: 0x060023AA RID: 9130 RVA: 0x00063E32 File Offset: 0x00062032
		internal global::System.Data.Entity.Core.SchemaObjectModel.IRelationship Relationship
		{
			get
			{
				return this._relationship;
			}
			set
			{
				this._relationship = value;
			}
		}

		// Token: 0x060023AB RID: 9131
		protected abstract bool HasEnd(string role);

		// Token: 0x060023AC RID: 9132
		protected abstract void AddEnd(global::System.Data.Entity.Core.SchemaObjectModel.IRelationshipEnd relationshipEnd, global::System.Data.Entity.Core.SchemaObjectModel.EntityContainerEntitySet entitySet);

		// Token: 0x17000776 RID: 1910
		// (get) Token: 0x060023AD RID: 9133
		internal abstract global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.SchemaObjectModel.EntityContainerRelationshipSetEnd> Ends { get; }

		// Token: 0x060023AE RID: 9134 RVA: 0x00063E3C File Offset: 0x0006203C
		protected void HandleRelationshipTypeNameAttribute(global::System.Xml.XmlReader reader)
		{
			global::System.Data.Entity.Core.SchemaObjectModel.ReturnValue<string> returnValue = base.HandleDottedNameAttribute(reader, this._unresolvedRelationshipTypeName);
			if (returnValue.Succeeded)
			{
				this._unresolvedRelationshipTypeName = returnValue.Value;
			}
		}

		// Token: 0x060023AF RID: 9135 RVA: 0x00063E6C File Offset: 0x0006206C
		internal override void ResolveTopLevelNames()
		{
			base.ResolveTopLevelNames();
			if (this._relationship == null)
			{
				global::System.Data.Entity.Core.SchemaObjectModel.SchemaType schemaType;
				if (!base.Schema.ResolveTypeName(this, this._unresolvedRelationshipTypeName, out schemaType))
				{
					return;
				}
				this._relationship = (schemaType as global::System.Data.Entity.Core.SchemaObjectModel.IRelationship);
				if (this._relationship == null)
				{
					base.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.InvalidPropertyType, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, global::System.Data.Entity.Resources.Strings.InvalidRelationshipSetType(schemaType.Name));
					return;
				}
			}
			foreach (global::System.Data.Entity.Core.SchemaObjectModel.EntityContainerRelationshipSetEnd entityContainerRelationshipSetEnd in this.Ends)
			{
				entityContainerRelationshipSetEnd.ResolveTopLevelNames();
			}
		}

		// Token: 0x060023B0 RID: 9136 RVA: 0x00063F04 File Offset: 0x00062104
		internal override void ResolveSecondLevelNames()
		{
			base.ResolveSecondLevelNames();
			foreach (global::System.Data.Entity.Core.SchemaObjectModel.EntityContainerRelationshipSetEnd entityContainerRelationshipSetEnd in this.Ends)
			{
				entityContainerRelationshipSetEnd.ResolveSecondLevelNames();
			}
		}

		// Token: 0x060023B1 RID: 9137 RVA: 0x00063F54 File Offset: 0x00062154
		internal override void Validate()
		{
			base.Validate();
			this.InferEnds();
			foreach (global::System.Data.Entity.Core.SchemaObjectModel.EntityContainerRelationshipSetEnd entityContainerRelationshipSetEnd in this.Ends)
			{
				entityContainerRelationshipSetEnd.Validate();
			}
		}

		// Token: 0x060023B2 RID: 9138 RVA: 0x00063FAC File Offset: 0x000621AC
		private void InferEnds()
		{
			foreach (global::System.Data.Entity.Core.SchemaObjectModel.IRelationshipEnd relationshipEnd in this.Relationship.Ends)
			{
				if (!this.HasEnd(relationshipEnd.Name))
				{
					global::System.Data.Entity.Core.SchemaObjectModel.EntityContainerEntitySet entityContainerEntitySet = this.InferEntitySet(relationshipEnd);
					if (entityContainerEntitySet != null)
					{
						this.AddEnd(relationshipEnd, entityContainerEntitySet);
					}
				}
			}
		}

		// Token: 0x060023B3 RID: 9139 RVA: 0x00064018 File Offset: 0x00062218
		private global::System.Data.Entity.Core.SchemaObjectModel.EntityContainerEntitySet InferEntitySet(global::System.Data.Entity.Core.SchemaObjectModel.IRelationshipEnd relationshipEnd)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.SchemaObjectModel.EntityContainerEntitySet> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.SchemaObjectModel.EntityContainerEntitySet>();
			foreach (global::System.Data.Entity.Core.SchemaObjectModel.EntityContainerEntitySet entityContainerEntitySet in this.ParentElement.EntitySets)
			{
				if (relationshipEnd.Type.IsOfType(entityContainerEntitySet.EntityType))
				{
					list.Add(entityContainerEntitySet);
				}
			}
			if (list.Count == 1)
			{
				return list[0];
			}
			if (list.Count == 0)
			{
				base.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.MissingExtentEntityContainerEnd, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, global::System.Data.Entity.Resources.Strings.MissingEntityContainerEnd(relationshipEnd.Name, this.FQName));
			}
			else
			{
				base.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.AmbiguousEntityContainerEnd, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, global::System.Data.Entity.Resources.Strings.AmbiguousEntityContainerEnd(relationshipEnd.Name, this.FQName));
			}
			return null;
		}

		// Token: 0x17000777 RID: 1911
		// (get) Token: 0x060023B4 RID: 9140 RVA: 0x000640D4 File Offset: 0x000622D4
		internal new global::System.Data.Entity.Core.SchemaObjectModel.EntityContainer ParentElement
		{
			get
			{
				return (global::System.Data.Entity.Core.SchemaObjectModel.EntityContainer)base.ParentElement;
			}
		}

		// Token: 0x04000C29 RID: 3113
		private global::System.Data.Entity.Core.SchemaObjectModel.IRelationship _relationship;

		// Token: 0x04000C2A RID: 3114
		private string _unresolvedRelationshipTypeName;
	}
}
