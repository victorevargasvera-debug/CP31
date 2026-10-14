using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Resources;
using System.Xml;

namespace System.Data.Entity.Core.SchemaObjectModel
{
	// Token: 0x0200031F RID: 799
	internal abstract class StructuredType : global::System.Data.Entity.Core.SchemaObjectModel.SchemaType
	{
		// Token: 0x17000815 RID: 2069
		// (get) Token: 0x060025FB RID: 9723 RVA: 0x0006B9BB File Offset: 0x00069BBB
		// (set) Token: 0x060025FC RID: 9724 RVA: 0x0006B9C3 File Offset: 0x00069BC3
		public global::System.Data.Entity.Core.SchemaObjectModel.StructuredType BaseType { get; private set; }

		// Token: 0x17000816 RID: 2070
		// (get) Token: 0x060025FD RID: 9725 RVA: 0x0006B9CC File Offset: 0x00069BCC
		public global::System.Data.Entity.Core.SchemaObjectModel.ISchemaElementLookUpTable<global::System.Data.Entity.Core.SchemaObjectModel.StructuredProperty> Properties
		{
			get
			{
				if (this._properties == null)
				{
					this._properties = new global::System.Data.Entity.Core.SchemaObjectModel.FilteredSchemaElementLookUpTable<global::System.Data.Entity.Core.SchemaObjectModel.StructuredProperty, global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement>(this.NamedMembers);
				}
				return this._properties;
			}
		}

		// Token: 0x17000817 RID: 2071
		// (get) Token: 0x060025FE RID: 9726 RVA: 0x0006B9ED File Offset: 0x00069BED
		protected global::System.Data.Entity.Core.SchemaObjectModel.SchemaElementLookUpTable<global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement> NamedMembers
		{
			get
			{
				if (this._namedMembers == null)
				{
					this._namedMembers = new global::System.Data.Entity.Core.SchemaObjectModel.SchemaElementLookUpTable<global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement>();
				}
				return this._namedMembers;
			}
		}

		// Token: 0x17000818 RID: 2072
		// (get) Token: 0x060025FF RID: 9727 RVA: 0x0006BA08 File Offset: 0x00069C08
		public virtual bool IsTypeHierarchyRoot
		{
			get
			{
				return this.BaseType == null;
			}
		}

		// Token: 0x17000819 RID: 2073
		// (get) Token: 0x06002600 RID: 9728 RVA: 0x0006BA13 File Offset: 0x00069C13
		public bool IsAbstract
		{
			get
			{
				return this._isAbstract;
			}
		}

		// Token: 0x06002601 RID: 9729 RVA: 0x0006BA1C File Offset: 0x00069C1C
		public global::System.Data.Entity.Core.SchemaObjectModel.StructuredProperty FindProperty(string name)
		{
			global::System.Data.Entity.Core.SchemaObjectModel.StructuredProperty structuredProperty = this.Properties.LookUpEquivalentKey(name);
			if (structuredProperty != null)
			{
				return structuredProperty;
			}
			if (this.IsTypeHierarchyRoot)
			{
				return null;
			}
			return this.BaseType.FindProperty(name);
		}

		// Token: 0x06002602 RID: 9730 RVA: 0x0006BA54 File Offset: 0x00069C54
		public bool IsOfType(global::System.Data.Entity.Core.SchemaObjectModel.StructuredType baseType)
		{
			global::System.Data.Entity.Core.SchemaObjectModel.StructuredType structuredType = this;
			while (structuredType != null && structuredType != baseType)
			{
				structuredType = structuredType.BaseType;
			}
			return structuredType == baseType;
		}

		// Token: 0x06002603 RID: 9731 RVA: 0x0006BA78 File Offset: 0x00069C78
		internal override void ResolveTopLevelNames()
		{
			base.ResolveTopLevelNames();
			this.TryResolveBaseType();
			foreach (global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement schemaElement in this.NamedMembers)
			{
				schemaElement.ResolveTopLevelNames();
			}
		}

		// Token: 0x06002604 RID: 9732 RVA: 0x0006BAD0 File Offset: 0x00069CD0
		internal override void Validate()
		{
			base.Validate();
			foreach (global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement schemaElement in this.NamedMembers)
			{
				if (this.BaseType != null)
				{
					string text = null;
					global::System.Data.Entity.Core.SchemaObjectModel.StructuredType structuredType;
					global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement schemaElement2;
					if (global::System.Data.Entity.Core.SchemaObjectModel.StructuredType.HowDefined.AsMember == this.BaseType.DefinesMemberName(schemaElement.Name, out structuredType, out schemaElement2))
					{
						text = global::System.Data.Entity.Resources.Strings.DuplicateMemberName(schemaElement.Name, this.FQName, structuredType.FQName);
					}
					if (text != null)
					{
						schemaElement.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.AlreadyDefined, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, text);
					}
				}
				schemaElement.Validate();
			}
		}

		// Token: 0x06002605 RID: 9733 RVA: 0x0006BB70 File Offset: 0x00069D70
		protected StructuredType(global::System.Data.Entity.Core.SchemaObjectModel.Schema parentElement) : base(parentElement)
		{
		}

		// Token: 0x06002606 RID: 9734 RVA: 0x0006BB7C File Offset: 0x00069D7C
		protected void AddMember(global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement newMember)
		{
			if (string.IsNullOrEmpty(newMember.Name))
			{
				return;
			}
			if (base.Schema.DataModel != global::System.Data.Entity.Core.SchemaObjectModel.SchemaDataModelOption.ProviderDataModel && global::System.Data.Entity.Core.SchemaObjectModel.Utils.CompareNames(newMember.Name, this.Name) == 0)
			{
				newMember.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.BadProperty, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, global::System.Data.Entity.Resources.Strings.InvalidMemberNameMatchesTypeName(newMember.Name, this.FQName));
			}
			this.NamedMembers.Add(newMember, true, new global::System.Func<object, string>(global::System.Data.Entity.Resources.Strings.PropertyNameAlreadyDefinedDuplicate));
		}

		// Token: 0x06002607 RID: 9735 RVA: 0x0006BBEC File Offset: 0x00069DEC
		private global::System.Data.Entity.Core.SchemaObjectModel.StructuredType.HowDefined DefinesMemberName(string name, out global::System.Data.Entity.Core.SchemaObjectModel.StructuredType definingType, out global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement definingMember)
		{
			if (this.NamedMembers.ContainsKey(name))
			{
				definingType = this;
				definingMember = this.NamedMembers[name];
				return global::System.Data.Entity.Core.SchemaObjectModel.StructuredType.HowDefined.AsMember;
			}
			definingMember = this.NamedMembers.LookUpEquivalentKey(name);
			if (this.IsTypeHierarchyRoot)
			{
				definingType = null;
				definingMember = null;
				return global::System.Data.Entity.Core.SchemaObjectModel.StructuredType.HowDefined.NotDefined;
			}
			return this.BaseType.DefinesMemberName(name, out definingType, out definingMember);
		}

		// Token: 0x1700081A RID: 2074
		// (get) Token: 0x06002608 RID: 9736 RVA: 0x0006BC46 File Offset: 0x00069E46
		// (set) Token: 0x06002609 RID: 9737 RVA: 0x0006BC4E File Offset: 0x00069E4E
		protected string UnresolvedBaseType
		{
			get
			{
				return this._unresolvedBaseType;
			}
			set
			{
				this._unresolvedBaseType = value;
			}
		}

		// Token: 0x0600260A RID: 9738 RVA: 0x0006BC57 File Offset: 0x00069E57
		protected override bool HandleElement(global::System.Xml.XmlReader reader)
		{
			if (base.HandleElement(reader))
			{
				return true;
			}
			if (base.CanHandleElement(reader, "Property"))
			{
				this.HandlePropertyElement(reader);
				return true;
			}
			return false;
		}

		// Token: 0x0600260B RID: 9739 RVA: 0x0006BC7C File Offset: 0x00069E7C
		protected override bool HandleAttribute(global::System.Xml.XmlReader reader)
		{
			if (base.HandleAttribute(reader))
			{
				return true;
			}
			if (global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement.CanHandleAttribute(reader, "BaseType"))
			{
				this.HandleBaseTypeAttribute(reader);
				return true;
			}
			if (global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement.CanHandleAttribute(reader, "Abstract"))
			{
				this.HandleAbstractAttribute(reader);
				return true;
			}
			return false;
		}

		// Token: 0x0600260C RID: 9740 RVA: 0x0006BCB8 File Offset: 0x00069EB8
		private bool TryResolveBaseType()
		{
			if (this._baseTypeResolveResult != null)
			{
				return this._baseTypeResolveResult.Value;
			}
			if (this.BaseType != null)
			{
				this._baseTypeResolveResult = new bool?(true);
				return this._baseTypeResolveResult.Value;
			}
			if (this.UnresolvedBaseType == null)
			{
				this._baseTypeResolveResult = new bool?(true);
				return this._baseTypeResolveResult.Value;
			}
			global::System.Data.Entity.Core.SchemaObjectModel.SchemaType schemaType;
			if (!base.Schema.ResolveTypeName(this, this.UnresolvedBaseType, out schemaType))
			{
				this._baseTypeResolveResult = new bool?(false);
				return this._baseTypeResolveResult.Value;
			}
			this.BaseType = (schemaType as global::System.Data.Entity.Core.SchemaObjectModel.StructuredType);
			if (this.BaseType == null)
			{
				base.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.InvalidBaseType, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, global::System.Data.Entity.Resources.Strings.InvalidBaseTypeForStructuredType(this.UnresolvedBaseType, this.FQName));
				this._baseTypeResolveResult = new bool?(false);
				return this._baseTypeResolveResult.Value;
			}
			if (this.CheckForInheritanceCycle())
			{
				this.BaseType = null;
				base.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.CycleInTypeHierarchy, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, global::System.Data.Entity.Resources.Strings.CycleInTypeHierarchy(this.FQName));
				this._baseTypeResolveResult = new bool?(false);
				return this._baseTypeResolveResult.Value;
			}
			this._baseTypeResolveResult = new bool?(true);
			return true;
		}

		// Token: 0x0600260D RID: 9741 RVA: 0x0006BDDC File Offset: 0x00069FDC
		private void HandleBaseTypeAttribute(global::System.Xml.XmlReader reader)
		{
			string unresolvedBaseType;
			if (!global::System.Data.Entity.Core.SchemaObjectModel.Utils.GetDottedName(base.Schema, reader, out unresolvedBaseType))
			{
				return;
			}
			this.UnresolvedBaseType = unresolvedBaseType;
		}

		// Token: 0x0600260E RID: 9742 RVA: 0x0006BE01 File Offset: 0x0006A001
		private void HandleAbstractAttribute(global::System.Xml.XmlReader reader)
		{
			base.HandleBoolAttribute(reader, ref this._isAbstract);
		}

		// Token: 0x0600260F RID: 9743 RVA: 0x0006BE14 File Offset: 0x0006A014
		private void HandlePropertyElement(global::System.Xml.XmlReader reader)
		{
			global::System.Data.Entity.Core.SchemaObjectModel.StructuredProperty structuredProperty = new global::System.Data.Entity.Core.SchemaObjectModel.StructuredProperty(this);
			structuredProperty.Parse(reader);
			this.AddMember(structuredProperty);
		}

		// Token: 0x06002610 RID: 9744 RVA: 0x0006BE38 File Offset: 0x0006A038
		private bool CheckForInheritanceCycle()
		{
			global::System.Data.Entity.Core.SchemaObjectModel.StructuredType baseType;
			global::System.Data.Entity.Core.SchemaObjectModel.StructuredType structuredType = baseType = this.BaseType;
			for (;;)
			{
				baseType = baseType.BaseType;
				if (structuredType == baseType)
				{
					break;
				}
				if (structuredType == null)
				{
					return false;
				}
				structuredType = structuredType.BaseType;
				if (baseType != null)
				{
					baseType = baseType.BaseType;
				}
				if (baseType == null)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x04000D57 RID: 3415
		private bool? _baseTypeResolveResult;

		// Token: 0x04000D58 RID: 3416
		private string _unresolvedBaseType;

		// Token: 0x04000D59 RID: 3417
		private bool _isAbstract;

		// Token: 0x04000D5A RID: 3418
		private global::System.Data.Entity.Core.SchemaObjectModel.SchemaElementLookUpTable<global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement> _namedMembers;

		// Token: 0x04000D5B RID: 3419
		private global::System.Data.Entity.Core.SchemaObjectModel.ISchemaElementLookUpTable<global::System.Data.Entity.Core.SchemaObjectModel.StructuredProperty> _properties;

		// Token: 0x020009C1 RID: 2497
		private enum HowDefined
		{
			// Token: 0x04002818 RID: 10264
			NotDefined,
			// Token: 0x04002819 RID: 10265
			AsMember
		}
	}
}
