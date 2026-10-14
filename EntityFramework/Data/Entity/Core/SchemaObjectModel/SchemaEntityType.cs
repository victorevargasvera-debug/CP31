using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Resources;
using System.Diagnostics;
using System.Xml;

namespace System.Data.Entity.Core.SchemaObjectModel
{
	// Token: 0x020002FA RID: 762
	[global::System.Diagnostics.DebuggerDisplay("Name={Name}, BaseType={BaseType.FQName}, HasKeys={HasKeys}")]
	internal sealed class SchemaEntityType : global::System.Data.Entity.Core.SchemaObjectModel.StructuredType
	{
		// Token: 0x0600243E RID: 9278 RVA: 0x0006598E File Offset: 0x00063B8E
		public SchemaEntityType(global::System.Data.Entity.Core.SchemaObjectModel.Schema parentElement) : base(parentElement)
		{
			if (base.Schema.DataModel == global::System.Data.Entity.Core.SchemaObjectModel.SchemaDataModelOption.EntityDataModel)
			{
				base.OtherContent.Add(base.Schema.SchemaSource);
			}
		}

		// Token: 0x0600243F RID: 9279 RVA: 0x000659BC File Offset: 0x00063BBC
		internal override void ResolveTopLevelNames()
		{
			base.ResolveTopLevelNames();
			if (base.BaseType != null)
			{
				if (!(base.BaseType is global::System.Data.Entity.Core.SchemaObjectModel.SchemaEntityType))
				{
					base.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.InvalidBaseType, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, global::System.Data.Entity.Resources.Strings.InvalidBaseTypeForItemType(base.BaseType.FQName, this.FQName));
					return;
				}
				if (this._keyElement != null && base.BaseType != null)
				{
					base.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.InvalidKey, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, global::System.Data.Entity.Resources.Strings.InvalidKeyKeyDefinedInBaseClass(this.FQName, base.BaseType.FQName));
					return;
				}
			}
			else
			{
				if (this._keyElement == null)
				{
					base.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.KeyMissingOnEntityType, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, global::System.Data.Entity.Resources.Strings.KeyMissingOnEntityType(this.FQName));
					return;
				}
				if (base.BaseType == null && base.UnresolvedBaseType != null)
				{
					return;
				}
				this._keyElement.ResolveTopLevelNames();
			}
		}

		// Token: 0x06002440 RID: 9280 RVA: 0x00065A70 File Offset: 0x00063C70
		protected override bool HandleAttribute(global::System.Xml.XmlReader reader)
		{
			return base.HandleAttribute(reader) || (global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement.CanHandleAttribute(reader, "OpenType") && base.Schema.DataModel == global::System.Data.Entity.Core.SchemaObjectModel.SchemaDataModelOption.EntityDataModel);
		}

		// Token: 0x170007AC RID: 1964
		// (get) Token: 0x06002441 RID: 9281 RVA: 0x00065A9A File Offset: 0x00063C9A
		public global::System.Data.Entity.Core.SchemaObjectModel.EntityKeyElement KeyElement
		{
			get
			{
				return this._keyElement;
			}
		}

		// Token: 0x170007AD RID: 1965
		// (get) Token: 0x06002442 RID: 9282 RVA: 0x00065AA2 File Offset: 0x00063CA2
		public global::System.Collections.Generic.IList<global::System.Data.Entity.Core.SchemaObjectModel.PropertyRefElement> DeclaredKeyProperties
		{
			get
			{
				if (this.KeyElement == null)
				{
					return global::System.Data.Entity.Core.SchemaObjectModel.SchemaEntityType._emptyKeyProperties;
				}
				return this.KeyElement.KeyProperties;
			}
		}

		// Token: 0x170007AE RID: 1966
		// (get) Token: 0x06002443 RID: 9283 RVA: 0x00065ABD File Offset: 0x00063CBD
		public global::System.Collections.Generic.IList<global::System.Data.Entity.Core.SchemaObjectModel.PropertyRefElement> KeyProperties
		{
			get
			{
				if (this.KeyElement != null)
				{
					return this.KeyElement.KeyProperties;
				}
				if (base.BaseType != null)
				{
					return (base.BaseType as global::System.Data.Entity.Core.SchemaObjectModel.SchemaEntityType).KeyProperties;
				}
				return global::System.Data.Entity.Core.SchemaObjectModel.SchemaEntityType._emptyKeyProperties;
			}
		}

		// Token: 0x170007AF RID: 1967
		// (get) Token: 0x06002444 RID: 9284 RVA: 0x00065AF1 File Offset: 0x00063CF1
		public global::System.Data.Entity.Core.SchemaObjectModel.ISchemaElementLookUpTable<global::System.Data.Entity.Core.SchemaObjectModel.NavigationProperty> NavigationProperties
		{
			get
			{
				if (this._navigationProperties == null)
				{
					this._navigationProperties = new global::System.Data.Entity.Core.SchemaObjectModel.FilteredSchemaElementLookUpTable<global::System.Data.Entity.Core.SchemaObjectModel.NavigationProperty, global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement>(base.NamedMembers);
				}
				return this._navigationProperties;
			}
		}

		// Token: 0x06002445 RID: 9285 RVA: 0x00065B12 File Offset: 0x00063D12
		internal override void Validate()
		{
			base.Validate();
			if (this.KeyElement != null)
			{
				this.KeyElement.Validate();
			}
		}

		// Token: 0x06002446 RID: 9286 RVA: 0x00065B30 File Offset: 0x00063D30
		protected override bool HandleElement(global::System.Xml.XmlReader reader)
		{
			if (base.HandleElement(reader))
			{
				return true;
			}
			if (base.CanHandleElement(reader, "Key"))
			{
				this.HandleKeyElement(reader);
				return true;
			}
			if (base.CanHandleElement(reader, "NavigationProperty"))
			{
				this.HandleNavigationPropertyElement(reader);
				return true;
			}
			if (base.CanHandleElement(reader, "ValueAnnotation") && base.Schema.DataModel == global::System.Data.Entity.Core.SchemaObjectModel.SchemaDataModelOption.EntityDataModel)
			{
				this.SkipElement(reader);
				return true;
			}
			if (base.CanHandleElement(reader, "TypeAnnotation") && base.Schema.DataModel == global::System.Data.Entity.Core.SchemaObjectModel.SchemaDataModelOption.EntityDataModel)
			{
				this.SkipElement(reader);
				return true;
			}
			return false;
		}

		// Token: 0x06002447 RID: 9287 RVA: 0x00065BC0 File Offset: 0x00063DC0
		private void HandleNavigationPropertyElement(global::System.Xml.XmlReader reader)
		{
			global::System.Data.Entity.Core.SchemaObjectModel.NavigationProperty navigationProperty = new global::System.Data.Entity.Core.SchemaObjectModel.NavigationProperty(this);
			navigationProperty.Parse(reader);
			base.AddMember(navigationProperty);
		}

		// Token: 0x06002448 RID: 9288 RVA: 0x00065BE2 File Offset: 0x00063DE2
		private void HandleKeyElement(global::System.Xml.XmlReader reader)
		{
			this._keyElement = new global::System.Data.Entity.Core.SchemaObjectModel.EntityKeyElement(this);
			this._keyElement.Parse(reader);
		}

		// Token: 0x04000CE7 RID: 3303
		private const char KEY_DELIMITER = ' ';

		// Token: 0x04000CE8 RID: 3304
		private global::System.Data.Entity.Core.SchemaObjectModel.ISchemaElementLookUpTable<global::System.Data.Entity.Core.SchemaObjectModel.NavigationProperty> _navigationProperties;

		// Token: 0x04000CE9 RID: 3305
		private global::System.Data.Entity.Core.SchemaObjectModel.EntityKeyElement _keyElement;

		// Token: 0x04000CEA RID: 3306
		private static readonly global::System.Collections.Generic.List<global::System.Data.Entity.Core.SchemaObjectModel.PropertyRefElement> _emptyKeyProperties = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.SchemaObjectModel.PropertyRefElement>(0);
	}
}
