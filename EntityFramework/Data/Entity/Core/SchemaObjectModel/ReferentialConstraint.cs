using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Resources;
using System.Xml;

namespace System.Data.Entity.Core.SchemaObjectModel
{
	// Token: 0x02000306 RID: 774
	internal sealed class ReferentialConstraint : global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement
	{
		// Token: 0x0600249F RID: 9375 RVA: 0x00066ABF File Offset: 0x00064CBF
		public ReferentialConstraint(global::System.Data.Entity.Core.SchemaObjectModel.Relationship relationship) : base(relationship, null)
		{
		}

		// Token: 0x060024A0 RID: 9376 RVA: 0x00066ACC File Offset: 0x00064CCC
		internal override void Validate()
		{
			base.Validate();
			this._principalRole.Validate();
			this._dependentRole.Validate();
			if (global::System.Data.Entity.Core.SchemaObjectModel.ReferentialConstraint.ReadyForFurtherValidation(this._principalRole) && global::System.Data.Entity.Core.SchemaObjectModel.ReferentialConstraint.ReadyForFurtherValidation(this._dependentRole))
			{
				global::System.Data.Entity.Core.SchemaObjectModel.IRelationshipEnd end = this._principalRole.End;
				global::System.Data.Entity.Core.SchemaObjectModel.IRelationshipEnd end2 = this._dependentRole.End;
				if (this._principalRole.Name == this._dependentRole.Name)
				{
					base.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.SameRoleReferredInReferentialConstraint, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, global::System.Data.Entity.Resources.Strings.SameRoleReferredInReferentialConstraint(this.ParentElement.Name));
				}
				bool flag;
				bool flag2;
				bool flag3;
				bool flag4;
				global::System.Data.Entity.Core.SchemaObjectModel.ReferentialConstraint.IsKeyProperty(this._dependentRole, end2.Type, out flag, out flag2, out flag3, out flag4);
				bool flag5;
				bool flag6;
				bool flag7;
				bool flag8;
				global::System.Data.Entity.Core.SchemaObjectModel.ReferentialConstraint.IsKeyProperty(this._principalRole, end.Type, out flag5, out flag6, out flag7, out flag8);
				if (!flag5)
				{
					base.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.InvalidPropertyInRelationshipConstraint, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, global::System.Data.Entity.Resources.Strings.InvalidFromPropertyInRelationshipConstraint(this.PrincipalRole.Name, end.Type.FQName, this.ParentElement.FQName));
					return;
				}
				bool flag9 = base.Schema.SchemaVersion <= 1.1;
				global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity relationshipMultiplicity = (flag9 ? flag6 : flag7) ? global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne : global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.One;
				global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity relationshipMultiplicity2 = (flag9 ? flag2 : flag3) ? global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne : global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many;
				end.Multiplicity = new global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity?(end.Multiplicity ?? relationshipMultiplicity);
				end2.Multiplicity = new global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity?(end2.Multiplicity ?? relationshipMultiplicity2);
				global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity? multiplicity = end.Multiplicity;
				global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity relationshipMultiplicity3 = global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many;
				if (multiplicity.GetValueOrDefault() == relationshipMultiplicity3 & multiplicity != null)
				{
					base.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.InvalidMultiplicityInRoleInRelationshipConstraint, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, global::System.Data.Entity.Resources.Strings.InvalidMultiplicityFromRoleUpperBoundMustBeOne(this._principalRole.Name, this.ParentElement.Name));
				}
				else
				{
					if (flag2)
					{
						multiplicity = end.Multiplicity;
						relationshipMultiplicity3 = global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.One;
						if (multiplicity.GetValueOrDefault() == relationshipMultiplicity3 & multiplicity != null)
						{
							string message = global::System.Data.Entity.Resources.Strings.InvalidMultiplicityFromRoleToPropertyNullableV1(this._principalRole.Name, this.ParentElement.Name);
							base.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.InvalidMultiplicityInRoleInRelationshipConstraint, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, message);
							goto IL_28E;
						}
					}
					if ((flag9 && !flag2) || (!flag9 && !flag3))
					{
						multiplicity = end.Multiplicity;
						relationshipMultiplicity3 = global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.One;
						if (!(multiplicity.GetValueOrDefault() == relationshipMultiplicity3 & multiplicity != null))
						{
							string message2;
							if (flag9)
							{
								message2 = global::System.Data.Entity.Resources.Strings.InvalidMultiplicityFromRoleToPropertyNonNullableV1(this._principalRole.Name, this.ParentElement.Name);
							}
							else
							{
								message2 = global::System.Data.Entity.Resources.Strings.InvalidMultiplicityFromRoleToPropertyNonNullableV2(this._principalRole.Name, this.ParentElement.Name);
							}
							base.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.InvalidMultiplicityInRoleInRelationshipConstraint, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, message2);
						}
					}
				}
				IL_28E:
				multiplicity = end2.Multiplicity;
				relationshipMultiplicity3 = global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.One;
				if ((multiplicity.GetValueOrDefault() == relationshipMultiplicity3 & multiplicity != null) && base.Schema.DataModel == global::System.Data.Entity.Core.SchemaObjectModel.SchemaDataModelOption.ProviderDataModel)
				{
					base.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.InvalidMultiplicityInRoleInRelationshipConstraint, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, global::System.Data.Entity.Resources.Strings.InvalidMultiplicityToRoleLowerBoundMustBeZero(this._dependentRole.Name, this.ParentElement.Name));
				}
				if (!flag4 && !this.ParentElement.IsForeignKey && base.Schema.DataModel == global::System.Data.Entity.Core.SchemaObjectModel.SchemaDataModelOption.EntityDataModel)
				{
					base.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.InvalidPropertyInRelationshipConstraint, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, global::System.Data.Entity.Resources.Strings.InvalidToPropertyInRelationshipConstraint(this.DependentRole.Name, end2.Type.FQName, this.ParentElement.FQName));
				}
				if (flag)
				{
					multiplicity = end2.Multiplicity;
					relationshipMultiplicity3 = global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many;
					if (multiplicity.GetValueOrDefault() == relationshipMultiplicity3 & multiplicity != null)
					{
						base.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.InvalidMultiplicityInRoleInRelationshipConstraint, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, global::System.Data.Entity.Resources.Strings.InvalidMultiplicityToRoleUpperBoundMustBeOne(end2.Name, this.ParentElement.Name));
					}
				}
				else
				{
					multiplicity = end2.Multiplicity;
					relationshipMultiplicity3 = global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many;
					if (!(multiplicity.GetValueOrDefault() == relationshipMultiplicity3 & multiplicity != null))
					{
						base.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.InvalidMultiplicityInRoleInRelationshipConstraint, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, global::System.Data.Entity.Resources.Strings.InvalidMultiplicityToRoleUpperBoundMustBeMany(end2.Name, this.ParentElement.Name));
					}
				}
				if (this._dependentRole.RoleProperties.Count != this._principalRole.RoleProperties.Count)
				{
					base.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.MismatchNumberOfPropertiesInRelationshipConstraint, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, global::System.Data.Entity.Resources.Strings.MismatchNumberOfPropertiesinRelationshipConstraint);
					return;
				}
				for (int i = 0; i < this._dependentRole.RoleProperties.Count; i++)
				{
					if (this._dependentRole.RoleProperties[i].Property.Type != this._principalRole.RoleProperties[i].Property.Type)
					{
						base.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.TypeMismatchRelationshipConstraint, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, global::System.Data.Entity.Resources.Strings.TypeMismatchRelationshipConstraint(this._dependentRole.RoleProperties[i].Name, this._dependentRole.End.Type.Identity, this._principalRole.RoleProperties[i].Name, this._principalRole.End.Type.Identity, this.ParentElement.Name));
					}
				}
			}
		}

		// Token: 0x060024A1 RID: 9377 RVA: 0x00066F8C File Offset: 0x0006518C
		private static bool ReadyForFurtherValidation(global::System.Data.Entity.Core.SchemaObjectModel.ReferentialConstraintRoleElement role)
		{
			if (role == null)
			{
				return false;
			}
			if (role.End == null)
			{
				return false;
			}
			if (role.RoleProperties.Count == 0)
			{
				return false;
			}
			using (global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.SchemaObjectModel.PropertyRefElement> enumerator = role.RoleProperties.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.Property == null)
					{
						return false;
					}
				}
			}
			return true;
		}

		// Token: 0x060024A2 RID: 9378 RVA: 0x00067000 File Offset: 0x00065200
		private static void IsKeyProperty(global::System.Data.Entity.Core.SchemaObjectModel.ReferentialConstraintRoleElement roleElement, global::System.Data.Entity.Core.SchemaObjectModel.SchemaEntityType itemType, out bool isKeyProperty, out bool areAllPropertiesNullable, out bool isAnyPropertyNullable, out bool isSubsetOfKeyProperties)
		{
			isKeyProperty = true;
			areAllPropertiesNullable = true;
			isAnyPropertyNullable = false;
			isSubsetOfKeyProperties = true;
			if (itemType.KeyProperties.Count != roleElement.RoleProperties.Count)
			{
				isKeyProperty = false;
			}
			for (int i = 0; i < roleElement.RoleProperties.Count; i++)
			{
				if (isSubsetOfKeyProperties)
				{
					bool flag = false;
					for (int j = 0; j < itemType.KeyProperties.Count; j++)
					{
						if (itemType.KeyProperties[j].Property == roleElement.RoleProperties[i].Property)
						{
							flag = true;
							break;
						}
					}
					if (!flag)
					{
						isKeyProperty = false;
						isSubsetOfKeyProperties = false;
					}
				}
				areAllPropertiesNullable &= roleElement.RoleProperties[i].Property.Nullable;
				isAnyPropertyNullable |= roleElement.RoleProperties[i].Property.Nullable;
			}
		}

		// Token: 0x060024A3 RID: 9379 RVA: 0x000670D9 File Offset: 0x000652D9
		protected override bool HandleAttribute(global::System.Xml.XmlReader reader)
		{
			return false;
		}

		// Token: 0x060024A4 RID: 9380 RVA: 0x000670DC File Offset: 0x000652DC
		protected override bool HandleElement(global::System.Xml.XmlReader reader)
		{
			if (base.HandleElement(reader))
			{
				return true;
			}
			if (base.CanHandleElement(reader, "Principal"))
			{
				this.HandleReferentialConstraintPrincipalRoleElement(reader);
				return true;
			}
			if (base.CanHandleElement(reader, "Dependent"))
			{
				this.HandleReferentialConstraintDependentRoleElement(reader);
				return true;
			}
			return false;
		}

		// Token: 0x060024A5 RID: 9381 RVA: 0x00067118 File Offset: 0x00065318
		internal void HandleReferentialConstraintPrincipalRoleElement(global::System.Xml.XmlReader reader)
		{
			this._principalRole = new global::System.Data.Entity.Core.SchemaObjectModel.ReferentialConstraintRoleElement(this);
			this._principalRole.Parse(reader);
		}

		// Token: 0x060024A6 RID: 9382 RVA: 0x00067132 File Offset: 0x00065332
		internal void HandleReferentialConstraintDependentRoleElement(global::System.Xml.XmlReader reader)
		{
			this._dependentRole = new global::System.Data.Entity.Core.SchemaObjectModel.ReferentialConstraintRoleElement(this);
			this._dependentRole.Parse(reader);
		}

		// Token: 0x060024A7 RID: 9383 RVA: 0x0006714C File Offset: 0x0006534C
		internal override void ResolveTopLevelNames()
		{
			this._dependentRole.ResolveTopLevelNames();
			this._principalRole.ResolveTopLevelNames();
		}

		// Token: 0x170007C6 RID: 1990
		// (get) Token: 0x060024A8 RID: 9384 RVA: 0x00067164 File Offset: 0x00065364
		internal new global::System.Data.Entity.Core.SchemaObjectModel.IRelationship ParentElement
		{
			get
			{
				return (global::System.Data.Entity.Core.SchemaObjectModel.IRelationship)base.ParentElement;
			}
		}

		// Token: 0x170007C7 RID: 1991
		// (get) Token: 0x060024A9 RID: 9385 RVA: 0x00067171 File Offset: 0x00065371
		internal global::System.Data.Entity.Core.SchemaObjectModel.ReferentialConstraintRoleElement PrincipalRole
		{
			get
			{
				return this._principalRole;
			}
		}

		// Token: 0x170007C8 RID: 1992
		// (get) Token: 0x060024AA RID: 9386 RVA: 0x00067179 File Offset: 0x00065379
		internal global::System.Data.Entity.Core.SchemaObjectModel.ReferentialConstraintRoleElement DependentRole
		{
			get
			{
				return this._dependentRole;
			}
		}

		// Token: 0x04000CFE RID: 3326
		private const char KEY_DELIMITER = ' ';

		// Token: 0x04000CFF RID: 3327
		private global::System.Data.Entity.Core.SchemaObjectModel.ReferentialConstraintRoleElement _principalRole;

		// Token: 0x04000D00 RID: 3328
		private global::System.Data.Entity.Core.SchemaObjectModel.ReferentialConstraintRoleElement _dependentRole;
	}
}
