using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Resources;
using System.Xml;

namespace System.Data.Entity.Core.SchemaObjectModel
{
	// Token: 0x020002E8 RID: 744
	internal sealed class EntityContainerAssociationSet : global::System.Data.Entity.Core.SchemaObjectModel.EntityContainerRelationshipSet
	{
		// Token: 0x0600237F RID: 9087 RVA: 0x000635DC File Offset: 0x000617DC
		public EntityContainerAssociationSet(global::System.Data.Entity.Core.SchemaObjectModel.EntityContainer parentElement) : base(parentElement)
		{
		}

		// Token: 0x1700076B RID: 1899
		// (get) Token: 0x06002380 RID: 9088 RVA: 0x000635FB File Offset: 0x000617FB
		internal override global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.SchemaObjectModel.EntityContainerRelationshipSetEnd> Ends
		{
			get
			{
				foreach (global::System.Data.Entity.Core.SchemaObjectModel.EntityContainerAssociationSetEnd entityContainerAssociationSetEnd in this._relationshipEnds.Values)
				{
					yield return entityContainerAssociationSetEnd;
				}
				global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.SchemaObjectModel.EntityContainerAssociationSetEnd>.ValueCollection.Enumerator enumerator = default(global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.SchemaObjectModel.EntityContainerAssociationSetEnd>.ValueCollection.Enumerator);
				foreach (global::System.Data.Entity.Core.SchemaObjectModel.EntityContainerAssociationSetEnd entityContainerAssociationSetEnd2 in this._rolelessEnds)
				{
					yield return entityContainerAssociationSetEnd2;
				}
				global::System.Collections.Generic.List<global::System.Data.Entity.Core.SchemaObjectModel.EntityContainerAssociationSetEnd>.Enumerator enumerator2 = default(global::System.Collections.Generic.List<global::System.Data.Entity.Core.SchemaObjectModel.EntityContainerAssociationSetEnd>.Enumerator);
				yield break;
				yield break;
			}
		}

		// Token: 0x06002381 RID: 9089 RVA: 0x0006360B File Offset: 0x0006180B
		protected override bool HandleAttribute(global::System.Xml.XmlReader reader)
		{
			if (base.HandleAttribute(reader))
			{
				return true;
			}
			if (global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement.CanHandleAttribute(reader, "Association"))
			{
				base.HandleRelationshipTypeNameAttribute(reader);
				return true;
			}
			return false;
		}

		// Token: 0x06002382 RID: 9090 RVA: 0x0006362F File Offset: 0x0006182F
		protected override bool HandleElement(global::System.Xml.XmlReader reader)
		{
			if (base.HandleElement(reader))
			{
				return true;
			}
			if (base.CanHandleElement(reader, "End"))
			{
				this.HandleEndElement(reader);
				return true;
			}
			return false;
		}

		// Token: 0x06002383 RID: 9091 RVA: 0x00063654 File Offset: 0x00061854
		private void HandleEndElement(global::System.Xml.XmlReader reader)
		{
			global::System.Data.Entity.Core.SchemaObjectModel.EntityContainerAssociationSetEnd entityContainerAssociationSetEnd = new global::System.Data.Entity.Core.SchemaObjectModel.EntityContainerAssociationSetEnd(this);
			entityContainerAssociationSetEnd.Parse(reader);
			if (entityContainerAssociationSetEnd.Role == null)
			{
				this._rolelessEnds.Add(entityContainerAssociationSetEnd);
				return;
			}
			if (this.HasEnd(entityContainerAssociationSetEnd.Role))
			{
				entityContainerAssociationSetEnd.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.InvalidName, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, reader, global::System.Data.Entity.Resources.Strings.DuplicateEndName(entityContainerAssociationSetEnd.Name));
				return;
			}
			this._relationshipEnds.Add(entityContainerAssociationSetEnd.Role, entityContainerAssociationSetEnd);
		}

		// Token: 0x06002384 RID: 9092 RVA: 0x000636BA File Offset: 0x000618BA
		internal override void ResolveTopLevelNames()
		{
			base.ResolveTopLevelNames();
		}

		// Token: 0x06002385 RID: 9093 RVA: 0x000636C4 File Offset: 0x000618C4
		internal override void ResolveSecondLevelNames()
		{
			base.ResolveSecondLevelNames();
			foreach (global::System.Data.Entity.Core.SchemaObjectModel.EntityContainerAssociationSetEnd entityContainerAssociationSetEnd in this._rolelessEnds)
			{
				if (entityContainerAssociationSetEnd.Role != null)
				{
					if (this.HasEnd(entityContainerAssociationSetEnd.Role))
					{
						entityContainerAssociationSetEnd.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.InvalidName, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, global::System.Data.Entity.Resources.Strings.InferRelationshipEndGivesAlreadyDefinedEnd(entityContainerAssociationSetEnd.EntitySet.FQName, this.Name));
					}
					else
					{
						this._relationshipEnds.Add(entityContainerAssociationSetEnd.Role, entityContainerAssociationSetEnd);
					}
				}
			}
			this._rolelessEnds.Clear();
		}

		// Token: 0x06002386 RID: 9094 RVA: 0x0006376C File Offset: 0x0006196C
		protected override void AddEnd(global::System.Data.Entity.Core.SchemaObjectModel.IRelationshipEnd relationshipEnd, global::System.Data.Entity.Core.SchemaObjectModel.EntityContainerEntitySet entitySet)
		{
			global::System.Data.Entity.Core.SchemaObjectModel.EntityContainerAssociationSetEnd entityContainerAssociationSetEnd = new global::System.Data.Entity.Core.SchemaObjectModel.EntityContainerAssociationSetEnd(this);
			entityContainerAssociationSetEnd.Role = relationshipEnd.Name;
			entityContainerAssociationSetEnd.RelationshipEnd = relationshipEnd;
			entityContainerAssociationSetEnd.EntitySet = entitySet;
			if (entityContainerAssociationSetEnd.EntitySet != null)
			{
				this._relationshipEnds.Add(entityContainerAssociationSetEnd.Role, entityContainerAssociationSetEnd);
			}
		}

		// Token: 0x06002387 RID: 9095 RVA: 0x000637B4 File Offset: 0x000619B4
		protected override bool HasEnd(string role)
		{
			return this._relationshipEnds.ContainsKey(role);
		}

		// Token: 0x06002388 RID: 9096 RVA: 0x000637C4 File Offset: 0x000619C4
		internal override global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement Clone(global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement parentElement)
		{
			global::System.Data.Entity.Core.SchemaObjectModel.EntityContainerAssociationSet entityContainerAssociationSet = new global::System.Data.Entity.Core.SchemaObjectModel.EntityContainerAssociationSet((global::System.Data.Entity.Core.SchemaObjectModel.EntityContainer)parentElement);
			entityContainerAssociationSet.Name = this.Name;
			entityContainerAssociationSet.Relationship = base.Relationship;
			foreach (global::System.Data.Entity.Core.SchemaObjectModel.EntityContainerRelationshipSetEnd entityContainerRelationshipSetEnd in this.Ends)
			{
				global::System.Data.Entity.Core.SchemaObjectModel.EntityContainerAssociationSetEnd entityContainerAssociationSetEnd = (global::System.Data.Entity.Core.SchemaObjectModel.EntityContainerAssociationSetEnd)((global::System.Data.Entity.Core.SchemaObjectModel.EntityContainerAssociationSetEnd)entityContainerRelationshipSetEnd).Clone(entityContainerAssociationSet);
				entityContainerAssociationSet._relationshipEnds.Add(entityContainerAssociationSetEnd.Role, entityContainerAssociationSetEnd);
			}
			return entityContainerAssociationSet;
		}

		// Token: 0x04000C20 RID: 3104
		private readonly global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.SchemaObjectModel.EntityContainerAssociationSetEnd> _relationshipEnds = new global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.SchemaObjectModel.EntityContainerAssociationSetEnd>();

		// Token: 0x04000C21 RID: 3105
		private readonly global::System.Collections.Generic.List<global::System.Data.Entity.Core.SchemaObjectModel.EntityContainerAssociationSetEnd> _rolelessEnds = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.SchemaObjectModel.EntityContainerAssociationSetEnd>();
	}
}
