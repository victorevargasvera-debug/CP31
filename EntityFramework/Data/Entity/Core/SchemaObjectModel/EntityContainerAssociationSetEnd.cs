using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Resources;
using System.Xml;

namespace System.Data.Entity.Core.SchemaObjectModel
{
	// Token: 0x020002E9 RID: 745
	internal sealed class EntityContainerAssociationSetEnd : global::System.Data.Entity.Core.SchemaObjectModel.EntityContainerRelationshipSetEnd
	{
		// Token: 0x06002389 RID: 9097 RVA: 0x00063854 File Offset: 0x00061A54
		public EntityContainerAssociationSetEnd(global::System.Data.Entity.Core.SchemaObjectModel.EntityContainerAssociationSet parentElement) : base(parentElement)
		{
		}

		// Token: 0x1700076C RID: 1900
		// (get) Token: 0x0600238A RID: 9098 RVA: 0x0006385D File Offset: 0x00061A5D
		// (set) Token: 0x0600238B RID: 9099 RVA: 0x00063865 File Offset: 0x00061A65
		public string Role
		{
			get
			{
				return this._unresolvedRelationshipEndRole;
			}
			set
			{
				this._unresolvedRelationshipEndRole = value;
			}
		}

		// Token: 0x1700076D RID: 1901
		// (get) Token: 0x0600238C RID: 9100 RVA: 0x0006386E File Offset: 0x00061A6E
		public override string Name
		{
			get
			{
				return this.Role;
			}
		}

		// Token: 0x0600238D RID: 9101 RVA: 0x00063876 File Offset: 0x00061A76
		protected override bool HandleAttribute(global::System.Xml.XmlReader reader)
		{
			if (base.HandleAttribute(reader))
			{
				return true;
			}
			if (global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement.CanHandleAttribute(reader, "Role"))
			{
				this.HandleRoleAttribute(reader);
				return true;
			}
			return false;
		}

		// Token: 0x0600238E RID: 9102 RVA: 0x0006389A File Offset: 0x00061A9A
		private void HandleRoleAttribute(global::System.Xml.XmlReader reader)
		{
			this._unresolvedRelationshipEndRole = base.HandleUndottedNameAttribute(reader, this._unresolvedRelationshipEndRole);
		}

		// Token: 0x0600238F RID: 9103 RVA: 0x000638AF File Offset: 0x00061AAF
		internal override void ResolveTopLevelNames()
		{
			base.ResolveTopLevelNames();
			global::System.Data.Entity.Core.SchemaObjectModel.IRelationship relationship = base.ParentElement.Relationship;
		}

		// Token: 0x06002390 RID: 9104 RVA: 0x000638C4 File Offset: 0x00061AC4
		internal override void ResolveSecondLevelNames()
		{
			base.ResolveSecondLevelNames();
			if (this._unresolvedRelationshipEndRole == null && base.EntitySet != null)
			{
				base.RelationshipEnd = this.InferRelationshipEnd(base.EntitySet);
				if (base.RelationshipEnd != null)
				{
					this._unresolvedRelationshipEndRole = base.RelationshipEnd.Name;
					return;
				}
			}
			else if (this._unresolvedRelationshipEndRole != null)
			{
				global::System.Data.Entity.Core.SchemaObjectModel.IRelationship relationship = base.ParentElement.Relationship;
				global::System.Data.Entity.Core.SchemaObjectModel.IRelationshipEnd relationshipEnd;
				if (relationship.TryGetEnd(this._unresolvedRelationshipEndRole, out relationshipEnd))
				{
					base.RelationshipEnd = relationshipEnd;
					return;
				}
				base.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.InvalidContainerTypeForEnd, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, global::System.Data.Entity.Resources.Strings.InvalidEntityEndName(this.Role, relationship.FQName));
			}
		}

		// Token: 0x06002391 RID: 9105 RVA: 0x0006395C File Offset: 0x00061B5C
		private global::System.Data.Entity.Core.SchemaObjectModel.IRelationshipEnd InferRelationshipEnd(global::System.Data.Entity.Core.SchemaObjectModel.EntityContainerEntitySet set)
		{
			if (base.ParentElement.Relationship == null)
			{
				return null;
			}
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.SchemaObjectModel.IRelationshipEnd> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.SchemaObjectModel.IRelationshipEnd>();
			foreach (global::System.Data.Entity.Core.SchemaObjectModel.IRelationshipEnd relationshipEnd in base.ParentElement.Relationship.Ends)
			{
				if (set.EntityType.IsOfType(relationshipEnd.Type))
				{
					list.Add(relationshipEnd);
				}
			}
			if (list.Count == 1)
			{
				return list[0];
			}
			if (list.Count == 0)
			{
				base.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.FailedInference, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, global::System.Data.Entity.Resources.Strings.InferRelationshipEndFailedNoEntitySetMatch(set.Name, base.ParentElement.Name, base.ParentElement.Relationship.FQName, set.EntityType.FQName, base.ParentElement.ParentElement.FQName));
			}
			else
			{
				base.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.FailedInference, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, global::System.Data.Entity.Resources.Strings.InferRelationshipEndAmbiguous(set.Name, base.ParentElement.Name, base.ParentElement.Relationship.FQName, set.EntityType.FQName, base.ParentElement.ParentElement.FQName));
			}
			return null;
		}

		// Token: 0x06002392 RID: 9106 RVA: 0x00063A8C File Offset: 0x00061C8C
		internal override global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement Clone(global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement parentElement)
		{
			return new global::System.Data.Entity.Core.SchemaObjectModel.EntityContainerAssociationSetEnd((global::System.Data.Entity.Core.SchemaObjectModel.EntityContainerAssociationSet)parentElement)
			{
				_unresolvedRelationshipEndRole = this._unresolvedRelationshipEndRole,
				EntitySet = base.EntitySet
			};
		}

		// Token: 0x04000C22 RID: 3106
		private string _unresolvedRelationshipEndRole;
	}
}
