using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Data.Entity.Resources;
using System.Xml;

namespace System.Data.Entity.Core.SchemaObjectModel
{
	// Token: 0x02000308 RID: 776
	internal sealed class Relationship : global::System.Data.Entity.Core.SchemaObjectModel.SchemaType, global::System.Data.Entity.Core.SchemaObjectModel.IRelationship
	{
		// Token: 0x060024B4 RID: 9396 RVA: 0x00067318 File Offset: 0x00065518
		public Relationship(global::System.Data.Entity.Core.SchemaObjectModel.Schema parent, global::System.Data.Entity.Core.Objects.DataClasses.RelationshipKind kind) : base(parent)
		{
			this.RelationshipKind = kind;
			if (base.Schema.DataModel == global::System.Data.Entity.Core.SchemaObjectModel.SchemaDataModelOption.EntityDataModel)
			{
				this._isForeignKey = false;
				base.OtherContent.Add(base.Schema.SchemaSource);
				return;
			}
			if (base.Schema.DataModel == global::System.Data.Entity.Core.SchemaObjectModel.SchemaDataModelOption.ProviderDataModel)
			{
				this._isForeignKey = true;
			}
		}

		// Token: 0x170007CB RID: 1995
		// (get) Token: 0x060024B5 RID: 9397 RVA: 0x00067373 File Offset: 0x00065573
		public global::System.Collections.Generic.IList<global::System.Data.Entity.Core.SchemaObjectModel.IRelationshipEnd> Ends
		{
			get
			{
				if (this._ends == null)
				{
					this._ends = new global::System.Data.Entity.Core.SchemaObjectModel.RelationshipEndCollection();
				}
				return this._ends;
			}
		}

		// Token: 0x170007CC RID: 1996
		// (get) Token: 0x060024B6 RID: 9398 RVA: 0x0006738E File Offset: 0x0006558E
		public global::System.Collections.Generic.IList<global::System.Data.Entity.Core.SchemaObjectModel.ReferentialConstraint> Constraints
		{
			get
			{
				if (this._constraints == null)
				{
					this._constraints = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.SchemaObjectModel.ReferentialConstraint>();
				}
				return this._constraints;
			}
		}

		// Token: 0x060024B7 RID: 9399 RVA: 0x000673A9 File Offset: 0x000655A9
		public bool TryGetEnd(string roleName, out global::System.Data.Entity.Core.SchemaObjectModel.IRelationshipEnd end)
		{
			return this._ends.TryGetEnd(roleName, out end);
		}

		// Token: 0x170007CD RID: 1997
		// (get) Token: 0x060024B8 RID: 9400 RVA: 0x000673B8 File Offset: 0x000655B8
		// (set) Token: 0x060024B9 RID: 9401 RVA: 0x000673C0 File Offset: 0x000655C0
		public global::System.Data.Entity.Core.Objects.DataClasses.RelationshipKind RelationshipKind { get; private set; }

		// Token: 0x170007CE RID: 1998
		// (get) Token: 0x060024BA RID: 9402 RVA: 0x000673C9 File Offset: 0x000655C9
		public bool IsForeignKey
		{
			get
			{
				return this._isForeignKey;
			}
		}

		// Token: 0x060024BB RID: 9403 RVA: 0x000673D4 File Offset: 0x000655D4
		internal override void Validate()
		{
			base.Validate();
			bool flag = false;
			foreach (global::System.Data.Entity.Core.SchemaObjectModel.IRelationshipEnd relationshipEnd in this.Ends)
			{
				global::System.Data.Entity.Core.SchemaObjectModel.RelationshipEnd relationshipEnd2 = (global::System.Data.Entity.Core.SchemaObjectModel.RelationshipEnd)relationshipEnd;
				relationshipEnd2.Validate();
				if (this.RelationshipKind == global::System.Data.Entity.Core.Objects.DataClasses.RelationshipKind.Association && relationshipEnd2.Operations.Count > 0)
				{
					if (flag)
					{
						relationshipEnd2.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.InvalidOperation, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, global::System.Data.Entity.Resources.Strings.InvalidOperationMultipleEndsInAssociation);
					}
					flag = true;
				}
			}
			if (this.Constraints.Count == 0)
			{
				if (base.Schema.DataModel == global::System.Data.Entity.Core.SchemaObjectModel.SchemaDataModelOption.ProviderDataModel)
				{
					base.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.MissingConstraintOnRelationshipType, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, global::System.Data.Entity.Resources.Strings.MissingConstraintOnRelationshipType(this.FQName));
					return;
				}
			}
			else
			{
				foreach (global::System.Data.Entity.Core.SchemaObjectModel.ReferentialConstraint referentialConstraint in this.Constraints)
				{
					referentialConstraint.Validate();
				}
			}
		}

		// Token: 0x060024BC RID: 9404 RVA: 0x000674C0 File Offset: 0x000656C0
		internal override void ResolveTopLevelNames()
		{
			base.ResolveTopLevelNames();
			foreach (global::System.Data.Entity.Core.SchemaObjectModel.IRelationshipEnd relationshipEnd in this.Ends)
			{
				((global::System.Data.Entity.Core.SchemaObjectModel.RelationshipEnd)relationshipEnd).ResolveTopLevelNames();
			}
			foreach (global::System.Data.Entity.Core.SchemaObjectModel.ReferentialConstraint referentialConstraint in this.Constraints)
			{
				referentialConstraint.ResolveTopLevelNames();
			}
		}

		// Token: 0x060024BD RID: 9405 RVA: 0x00067550 File Offset: 0x00065750
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
			if (base.CanHandleElement(reader, "ReferentialConstraint"))
			{
				this.HandleConstraintElement(reader);
				return true;
			}
			return false;
		}

		// Token: 0x060024BE RID: 9406 RVA: 0x0006758C File Offset: 0x0006578C
		private void HandleEndElement(global::System.Xml.XmlReader reader)
		{
			global::System.Data.Entity.Core.SchemaObjectModel.RelationshipEnd relationshipEnd = new global::System.Data.Entity.Core.SchemaObjectModel.RelationshipEnd(this);
			relationshipEnd.Parse(reader);
			if (this.Ends.Count == 2)
			{
				base.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.InvalidAssociation, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, global::System.Data.Entity.Resources.Strings.TooManyAssociationEnds(this.FQName));
				return;
			}
			this.Ends.Add(relationshipEnd);
		}

		// Token: 0x060024BF RID: 9407 RVA: 0x000675D8 File Offset: 0x000657D8
		private void HandleConstraintElement(global::System.Xml.XmlReader reader)
		{
			global::System.Data.Entity.Core.SchemaObjectModel.ReferentialConstraint referentialConstraint = new global::System.Data.Entity.Core.SchemaObjectModel.ReferentialConstraint(this);
			referentialConstraint.Parse(reader);
			this.Constraints.Add(referentialConstraint);
			if (base.Schema.DataModel == global::System.Data.Entity.Core.SchemaObjectModel.SchemaDataModelOption.EntityDataModel && base.Schema.SchemaVersion >= 2.0)
			{
				this._isForeignKey = true;
			}
		}

		// Token: 0x04000D03 RID: 3331
		private global::System.Data.Entity.Core.SchemaObjectModel.RelationshipEndCollection _ends;

		// Token: 0x04000D04 RID: 3332
		private global::System.Collections.Generic.List<global::System.Data.Entity.Core.SchemaObjectModel.ReferentialConstraint> _constraints;

		// Token: 0x04000D05 RID: 3333
		private bool _isForeignKey;
	}
}
