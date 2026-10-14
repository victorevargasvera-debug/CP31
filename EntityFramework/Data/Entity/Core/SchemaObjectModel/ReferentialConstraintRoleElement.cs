using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Resources;
using System.Xml;

namespace System.Data.Entity.Core.SchemaObjectModel
{
	// Token: 0x02000307 RID: 775
	internal sealed class ReferentialConstraintRoleElement : global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement
	{
		// Token: 0x060024AB RID: 9387 RVA: 0x00067181 File Offset: 0x00065381
		public ReferentialConstraintRoleElement(global::System.Data.Entity.Core.SchemaObjectModel.ReferentialConstraint parentElement) : base(parentElement, null)
		{
		}

		// Token: 0x170007C9 RID: 1993
		// (get) Token: 0x060024AC RID: 9388 RVA: 0x0006718B File Offset: 0x0006538B
		public global::System.Collections.Generic.IList<global::System.Data.Entity.Core.SchemaObjectModel.PropertyRefElement> RoleProperties
		{
			get
			{
				if (this._roleProperties == null)
				{
					this._roleProperties = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.SchemaObjectModel.PropertyRefElement>();
				}
				return this._roleProperties;
			}
		}

		// Token: 0x170007CA RID: 1994
		// (get) Token: 0x060024AD RID: 9389 RVA: 0x000671A6 File Offset: 0x000653A6
		public global::System.Data.Entity.Core.SchemaObjectModel.IRelationshipEnd End
		{
			get
			{
				return this._end;
			}
		}

		// Token: 0x060024AE RID: 9390 RVA: 0x000671AE File Offset: 0x000653AE
		protected override bool HandleElement(global::System.Xml.XmlReader reader)
		{
			if (base.HandleElement(reader))
			{
				return true;
			}
			if (base.CanHandleElement(reader, "PropertyRef"))
			{
				this.HandlePropertyRefElement(reader);
				return true;
			}
			return false;
		}

		// Token: 0x060024AF RID: 9391 RVA: 0x000671D3 File Offset: 0x000653D3
		protected override bool HandleAttribute(global::System.Xml.XmlReader reader)
		{
			if (global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement.CanHandleAttribute(reader, "Role"))
			{
				this.HandleRoleAttribute(reader);
				return true;
			}
			return false;
		}

		// Token: 0x060024B0 RID: 9392 RVA: 0x000671EC File Offset: 0x000653EC
		private void HandlePropertyRefElement(global::System.Xml.XmlReader reader)
		{
			global::System.Data.Entity.Core.SchemaObjectModel.PropertyRefElement propertyRefElement = new global::System.Data.Entity.Core.SchemaObjectModel.PropertyRefElement(base.ParentElement);
			propertyRefElement.Parse(reader);
			this.RoleProperties.Add(propertyRefElement);
		}

		// Token: 0x060024B1 RID: 9393 RVA: 0x00067218 File Offset: 0x00065418
		private void HandleRoleAttribute(global::System.Xml.XmlReader reader)
		{
			string name;
			global::System.Data.Entity.Core.SchemaObjectModel.Utils.GetString(base.Schema, reader, out name);
			this.Name = name;
		}

		// Token: 0x060024B2 RID: 9394 RVA: 0x0006723C File Offset: 0x0006543C
		internal override void ResolveTopLevelNames()
		{
			global::System.Data.Entity.Core.SchemaObjectModel.IRelationship relationship = (global::System.Data.Entity.Core.SchemaObjectModel.IRelationship)base.ParentElement.ParentElement;
			if (!relationship.TryGetEnd(this.Name, out this._end))
			{
				base.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.InvalidRoleInRelationshipConstraint, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, global::System.Data.Entity.Resources.Strings.InvalidEndRoleInRelationshipConstraint(this.Name, relationship.Name));
				return;
			}
			global::System.Data.Entity.Core.SchemaObjectModel.SchemaEntityType type = this._end.Type;
		}

		// Token: 0x060024B3 RID: 9395 RVA: 0x00067298 File Offset: 0x00065498
		internal override void Validate()
		{
			base.Validate();
			foreach (global::System.Data.Entity.Core.SchemaObjectModel.PropertyRefElement propertyRefElement in this._roleProperties)
			{
				if (!propertyRefElement.ResolveNames(this._end.Type))
				{
					base.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.InvalidPropertyInRelationshipConstraint, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, global::System.Data.Entity.Resources.Strings.InvalidPropertyInRelationshipConstraint(propertyRefElement.Name, this.Name));
				}
			}
		}

		// Token: 0x04000D01 RID: 3329
		private global::System.Collections.Generic.List<global::System.Data.Entity.Core.SchemaObjectModel.PropertyRefElement> _roleProperties;

		// Token: 0x04000D02 RID: 3330
		private global::System.Data.Entity.Core.SchemaObjectModel.IRelationshipEnd _end;
	}
}
