using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Resources;
using System.Xml;

namespace System.Data.Entity.Core.SchemaObjectModel
{
	// Token: 0x02000309 RID: 777
	internal sealed class RelationshipEnd : global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement, global::System.Data.Entity.Core.SchemaObjectModel.IRelationshipEnd
	{
		// Token: 0x060024C0 RID: 9408 RVA: 0x00067629 File Offset: 0x00065829
		public RelationshipEnd(global::System.Data.Entity.Core.SchemaObjectModel.Relationship relationship) : base(relationship, null)
		{
		}

		// Token: 0x170007CF RID: 1999
		// (get) Token: 0x060024C1 RID: 9409 RVA: 0x00067633 File Offset: 0x00065833
		// (set) Token: 0x060024C2 RID: 9410 RVA: 0x0006763B File Offset: 0x0006583B
		public global::System.Data.Entity.Core.SchemaObjectModel.SchemaEntityType Type { get; private set; }

		// Token: 0x170007D0 RID: 2000
		// (get) Token: 0x060024C3 RID: 9411 RVA: 0x00067644 File Offset: 0x00065844
		// (set) Token: 0x060024C4 RID: 9412 RVA: 0x0006764C File Offset: 0x0006584C
		public global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity? Multiplicity
		{
			get
			{
				return this._multiplicity;
			}
			set
			{
				this._multiplicity = value;
			}
		}

		// Token: 0x170007D1 RID: 2001
		// (get) Token: 0x060024C5 RID: 9413 RVA: 0x00067655 File Offset: 0x00065855
		public global::System.Collections.Generic.ICollection<global::System.Data.Entity.Core.SchemaObjectModel.OnOperation> Operations
		{
			get
			{
				if (this._operations == null)
				{
					this._operations = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.SchemaObjectModel.OnOperation>();
				}
				return this._operations;
			}
		}

		// Token: 0x060024C6 RID: 9414 RVA: 0x00067670 File Offset: 0x00065870
		internal override void ResolveTopLevelNames()
		{
			base.ResolveTopLevelNames();
			if (this.Type == null && this._unresolvedType != null)
			{
				global::System.Data.Entity.Core.SchemaObjectModel.SchemaType schemaType;
				if (!base.Schema.ResolveTypeName(this, this._unresolvedType, out schemaType))
				{
					return;
				}
				this.Type = (schemaType as global::System.Data.Entity.Core.SchemaObjectModel.SchemaEntityType);
				if (this.Type == null)
				{
					base.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.InvalidRelationshipEndType, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, global::System.Data.Entity.Resources.Strings.InvalidRelationshipEndType(this.ParentElement.Name, schemaType.FQName));
				}
			}
		}

		// Token: 0x060024C7 RID: 9415 RVA: 0x000676E0 File Offset: 0x000658E0
		internal override void Validate()
		{
			base.Validate();
			global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity? multiplicity = this.Multiplicity;
			global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity relationshipMultiplicity = global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many;
			if ((multiplicity.GetValueOrDefault() == relationshipMultiplicity & multiplicity != null) && this.Operations.Count != 0)
			{
				base.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.EndWithManyMultiplicityCannotHaveOperationsSpecified, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, global::System.Data.Entity.Resources.Strings.EndWithManyMultiplicityCannotHaveOperationsSpecified(this.Name, this.ParentElement.FQName));
			}
			if (this.ParentElement.Constraints.Count == 0 && this.Multiplicity == null)
			{
				base.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.EndWithoutMultiplicity, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, global::System.Data.Entity.Resources.Strings.EndWithoutMultiplicity(this.Name, this.ParentElement.FQName));
			}
		}

		// Token: 0x060024C8 RID: 9416 RVA: 0x00067783 File Offset: 0x00065983
		protected override void HandleAttributesComplete()
		{
			if (this.Name == null && this._unresolvedType != null)
			{
				this.Name = global::System.Data.Entity.Core.SchemaObjectModel.Utils.ExtractTypeName(this._unresolvedType);
			}
			base.HandleAttributesComplete();
		}

		// Token: 0x060024C9 RID: 9417 RVA: 0x000677AC File Offset: 0x000659AC
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

		// Token: 0x060024CA RID: 9418 RVA: 0x000677CC File Offset: 0x000659CC
		protected override bool HandleAttribute(global::System.Xml.XmlReader reader)
		{
			if (base.HandleAttribute(reader))
			{
				return true;
			}
			if (global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement.CanHandleAttribute(reader, "Multiplicity"))
			{
				this.HandleMultiplicityAttribute(reader);
				return true;
			}
			if (global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement.CanHandleAttribute(reader, "Role"))
			{
				this.HandleNameAttribute(reader);
				return true;
			}
			if (global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement.CanHandleAttribute(reader, "Type"))
			{
				this.HandleTypeAttribute(reader);
				return true;
			}
			return false;
		}

		// Token: 0x060024CB RID: 9419 RVA: 0x00067827 File Offset: 0x00065A27
		protected override bool HandleElement(global::System.Xml.XmlReader reader)
		{
			if (base.HandleElement(reader))
			{
				return true;
			}
			if (base.CanHandleElement(reader, "OnDelete"))
			{
				this.HandleOnDeleteElement(reader);
				return true;
			}
			return false;
		}

		// Token: 0x060024CC RID: 9420 RVA: 0x0006784C File Offset: 0x00065A4C
		private void HandleTypeAttribute(global::System.Xml.XmlReader reader)
		{
			string unresolvedType;
			if (!global::System.Data.Entity.Core.SchemaObjectModel.Utils.GetDottedName(base.Schema, reader, out unresolvedType))
			{
				return;
			}
			this._unresolvedType = unresolvedType;
		}

		// Token: 0x060024CD RID: 9421 RVA: 0x00067874 File Offset: 0x00065A74
		private void HandleMultiplicityAttribute(global::System.Xml.XmlReader reader)
		{
			global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity value;
			if (!global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicityConverter.TryParseMultiplicity(reader.Value, out value))
			{
				base.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.InvalidMultiplicity, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, reader, global::System.Data.Entity.Resources.Strings.InvalidRelationshipEndMultiplicity(this.ParentElement.Name, reader.Value));
			}
			this._multiplicity = new global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity?(value);
		}

		// Token: 0x060024CE RID: 9422 RVA: 0x000678BC File Offset: 0x00065ABC
		private void HandleOnDeleteElement(global::System.Xml.XmlReader reader)
		{
			this.HandleOnOperationElement(reader, global::System.Data.Entity.Core.SchemaObjectModel.Operation.Delete);
		}

		// Token: 0x060024CF RID: 9423 RVA: 0x000678C8 File Offset: 0x00065AC8
		private void HandleOnOperationElement(global::System.Xml.XmlReader reader, global::System.Data.Entity.Core.SchemaObjectModel.Operation operation)
		{
			using (global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.SchemaObjectModel.OnOperation> enumerator = this.Operations.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.Operation == operation)
					{
						base.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.InvalidOperation, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, reader, global::System.Data.Entity.Resources.Strings.DuplicationOperation(reader.Name));
					}
				}
			}
			global::System.Data.Entity.Core.SchemaObjectModel.OnOperation onOperation = new global::System.Data.Entity.Core.SchemaObjectModel.OnOperation(this, operation);
			onOperation.Parse(reader);
			this._operations.Add(onOperation);
		}

		// Token: 0x170007D2 RID: 2002
		// (get) Token: 0x060024D0 RID: 9424 RVA: 0x00067948 File Offset: 0x00065B48
		internal new global::System.Data.Entity.Core.SchemaObjectModel.IRelationship ParentElement
		{
			get
			{
				return (global::System.Data.Entity.Core.SchemaObjectModel.IRelationship)base.ParentElement;
			}
		}

		// Token: 0x04000D07 RID: 3335
		private string _unresolvedType;

		// Token: 0x04000D08 RID: 3336
		private global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity? _multiplicity;

		// Token: 0x04000D09 RID: 3337
		private global::System.Collections.Generic.List<global::System.Data.Entity.Core.SchemaObjectModel.OnOperation> _operations;
	}
}
