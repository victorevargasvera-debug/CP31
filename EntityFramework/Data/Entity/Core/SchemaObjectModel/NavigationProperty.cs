using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Resources;
using System.Diagnostics;
using System.Xml;

namespace System.Data.Entity.Core.SchemaObjectModel
{
	// Token: 0x020002FD RID: 765
	[global::System.Diagnostics.DebuggerDisplay("Name={Name}, Relationship={_unresolvedRelationshipName}, FromRole={_unresolvedFromEndRole}, ToRole={_unresolvedToEndRole}")]
	internal sealed class NavigationProperty : global::System.Data.Entity.Core.SchemaObjectModel.Property
	{
		// Token: 0x06002459 RID: 9305 RVA: 0x00065E01 File Offset: 0x00064001
		public NavigationProperty(global::System.Data.Entity.Core.SchemaObjectModel.SchemaEntityType parent) : base(parent)
		{
		}

		// Token: 0x170007B2 RID: 1970
		// (get) Token: 0x0600245A RID: 9306 RVA: 0x00065E0A File Offset: 0x0006400A
		public new global::System.Data.Entity.Core.SchemaObjectModel.SchemaEntityType ParentElement
		{
			get
			{
				return base.ParentElement as global::System.Data.Entity.Core.SchemaObjectModel.SchemaEntityType;
			}
		}

		// Token: 0x170007B3 RID: 1971
		// (get) Token: 0x0600245B RID: 9307 RVA: 0x00065E17 File Offset: 0x00064017
		internal global::System.Data.Entity.Core.SchemaObjectModel.IRelationship Relationship
		{
			get
			{
				return this._relationship;
			}
		}

		// Token: 0x170007B4 RID: 1972
		// (get) Token: 0x0600245C RID: 9308 RVA: 0x00065E1F File Offset: 0x0006401F
		internal global::System.Data.Entity.Core.SchemaObjectModel.IRelationshipEnd ToEnd
		{
			get
			{
				return this._toEnd;
			}
		}

		// Token: 0x170007B5 RID: 1973
		// (get) Token: 0x0600245D RID: 9309 RVA: 0x00065E27 File Offset: 0x00064027
		internal global::System.Data.Entity.Core.SchemaObjectModel.IRelationshipEnd FromEnd
		{
			get
			{
				return this._fromEnd;
			}
		}

		// Token: 0x170007B6 RID: 1974
		// (get) Token: 0x0600245E RID: 9310 RVA: 0x00065E2F File Offset: 0x0006402F
		public override global::System.Data.Entity.Core.SchemaObjectModel.SchemaType Type
		{
			get
			{
				if (this._toEnd == null || this._toEnd.Type == null)
				{
					return null;
				}
				return this._toEnd.Type;
			}
		}

		// Token: 0x0600245F RID: 9311 RVA: 0x00065E54 File Offset: 0x00064054
		protected override bool HandleAttribute(global::System.Xml.XmlReader reader)
		{
			if (base.HandleAttribute(reader))
			{
				return true;
			}
			if (global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement.CanHandleAttribute(reader, "Relationship"))
			{
				this.HandleAssociationAttribute(reader);
				return true;
			}
			if (global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement.CanHandleAttribute(reader, "FromRole"))
			{
				this.HandleFromRoleAttribute(reader);
				return true;
			}
			if (global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement.CanHandleAttribute(reader, "ToRole"))
			{
				this.HandleToRoleAttribute(reader);
				return true;
			}
			return global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement.CanHandleAttribute(reader, "ContainsTarget");
		}

		// Token: 0x06002460 RID: 9312 RVA: 0x00065EC0 File Offset: 0x000640C0
		internal override void ResolveTopLevelNames()
		{
			base.ResolveTopLevelNames();
			global::System.Data.Entity.Core.SchemaObjectModel.SchemaType schemaType;
			if (!base.Schema.ResolveTypeName(this, this._unresolvedRelationshipName, out schemaType))
			{
				return;
			}
			this._relationship = (schemaType as global::System.Data.Entity.Core.SchemaObjectModel.IRelationship);
			if (this._relationship == null)
			{
				base.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.BadNavigationProperty, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, global::System.Data.Entity.Resources.Strings.BadNavigationPropertyRelationshipNotRelationship(this._unresolvedRelationshipName));
				return;
			}
			bool flag = true;
			if (!this._relationship.TryGetEnd(this._unresolvedFromEndRole, out this._fromEnd))
			{
				base.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.BadNavigationProperty, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, global::System.Data.Entity.Resources.Strings.BadNavigationPropertyUndefinedRole(this._unresolvedFromEndRole, this._relationship.FQName));
				flag = false;
			}
			if (!this._relationship.TryGetEnd(this._unresolvedToEndRole, out this._toEnd))
			{
				base.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.BadNavigationProperty, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, global::System.Data.Entity.Resources.Strings.BadNavigationPropertyUndefinedRole(this._unresolvedToEndRole, this._relationship.FQName));
				flag = false;
			}
			if (flag && this._fromEnd == this._toEnd)
			{
				base.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.BadNavigationProperty, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, global::System.Data.Entity.Resources.Strings.BadNavigationPropertyRolesCannotBeTheSame);
			}
		}

		// Token: 0x06002461 RID: 9313 RVA: 0x00065FA8 File Offset: 0x000641A8
		internal override void Validate()
		{
			base.Validate();
			if (this._fromEnd.Type != this.ParentElement)
			{
				base.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.BadNavigationProperty, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, global::System.Data.Entity.Resources.Strings.BadNavigationPropertyBadFromRoleType(this.Name, this._fromEnd.Type.FQName, this._fromEnd.Name, this._relationship.FQName, this.ParentElement.FQName));
			}
		}

		// Token: 0x06002462 RID: 9314 RVA: 0x00066013 File Offset: 0x00064213
		private void HandleToRoleAttribute(global::System.Xml.XmlReader reader)
		{
			this._unresolvedToEndRole = base.HandleUndottedNameAttribute(reader, this._unresolvedToEndRole);
		}

		// Token: 0x06002463 RID: 9315 RVA: 0x00066028 File Offset: 0x00064228
		private void HandleFromRoleAttribute(global::System.Xml.XmlReader reader)
		{
			this._unresolvedFromEndRole = base.HandleUndottedNameAttribute(reader, this._unresolvedFromEndRole);
		}

		// Token: 0x06002464 RID: 9316 RVA: 0x00066040 File Offset: 0x00064240
		private void HandleAssociationAttribute(global::System.Xml.XmlReader reader)
		{
			string unresolvedRelationshipName;
			if (!global::System.Data.Entity.Core.SchemaObjectModel.Utils.GetDottedName(base.Schema, reader, out unresolvedRelationshipName))
			{
				return;
			}
			this._unresolvedRelationshipName = unresolvedRelationshipName;
		}

		// Token: 0x04000CED RID: 3309
		private string _unresolvedFromEndRole;

		// Token: 0x04000CEE RID: 3310
		private string _unresolvedToEndRole;

		// Token: 0x04000CEF RID: 3311
		private string _unresolvedRelationshipName;

		// Token: 0x04000CF0 RID: 3312
		private global::System.Data.Entity.Core.SchemaObjectModel.IRelationshipEnd _fromEnd;

		// Token: 0x04000CF1 RID: 3313
		private global::System.Data.Entity.Core.SchemaObjectModel.IRelationshipEnd _toEnd;

		// Token: 0x04000CF2 RID: 3314
		private global::System.Data.Entity.Core.SchemaObjectModel.IRelationship _relationship;
	}
}
