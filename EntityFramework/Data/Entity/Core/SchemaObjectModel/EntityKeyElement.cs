using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Resources;
using System.Xml;

namespace System.Data.Entity.Core.SchemaObjectModel
{
	// Token: 0x020002EE RID: 750
	internal sealed class EntityKeyElement : global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement
	{
		// Token: 0x060023C0 RID: 9152 RVA: 0x00064264 File Offset: 0x00062464
		public EntityKeyElement(global::System.Data.Entity.Core.SchemaObjectModel.SchemaEntityType parentElement) : base(parentElement, null)
		{
		}

		// Token: 0x1700077B RID: 1915
		// (get) Token: 0x060023C1 RID: 9153 RVA: 0x0006426E File Offset: 0x0006246E
		public global::System.Collections.Generic.IList<global::System.Data.Entity.Core.SchemaObjectModel.PropertyRefElement> KeyProperties
		{
			get
			{
				if (this._keyProperties == null)
				{
					this._keyProperties = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.SchemaObjectModel.PropertyRefElement>();
				}
				return this._keyProperties;
			}
		}

		// Token: 0x060023C2 RID: 9154 RVA: 0x00064289 File Offset: 0x00062489
		protected override bool HandleAttribute(global::System.Xml.XmlReader reader)
		{
			return false;
		}

		// Token: 0x060023C3 RID: 9155 RVA: 0x0006428C File Offset: 0x0006248C
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

		// Token: 0x060023C4 RID: 9156 RVA: 0x000642B4 File Offset: 0x000624B4
		private void HandlePropertyRefElement(global::System.Xml.XmlReader reader)
		{
			global::System.Data.Entity.Core.SchemaObjectModel.PropertyRefElement propertyRefElement = new global::System.Data.Entity.Core.SchemaObjectModel.PropertyRefElement(base.ParentElement);
			propertyRefElement.Parse(reader);
			this.KeyProperties.Add(propertyRefElement);
		}

		// Token: 0x060023C5 RID: 9157 RVA: 0x000642E0 File Offset: 0x000624E0
		internal override void ResolveTopLevelNames()
		{
			foreach (global::System.Data.Entity.Core.SchemaObjectModel.PropertyRefElement propertyRefElement in this._keyProperties)
			{
				if (!propertyRefElement.ResolveNames((global::System.Data.Entity.Core.SchemaObjectModel.SchemaEntityType)base.ParentElement))
				{
					base.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.InvalidKey, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, global::System.Data.Entity.Resources.Strings.InvalidKeyNoProperty(base.ParentElement.FQName, propertyRefElement.Name));
				}
			}
		}

		// Token: 0x060023C6 RID: 9158 RVA: 0x00064360 File Offset: 0x00062560
		internal override void Validate()
		{
			global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.SchemaObjectModel.PropertyRefElement> dictionary = new global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.SchemaObjectModel.PropertyRefElement>(global::System.StringComparer.Ordinal);
			foreach (global::System.Data.Entity.Core.SchemaObjectModel.PropertyRefElement propertyRefElement in this._keyProperties)
			{
				global::System.Data.Entity.Core.SchemaObjectModel.StructuredProperty property = propertyRefElement.Property;
				if (dictionary.ContainsKey(property.Name))
				{
					base.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.DuplicatePropertySpecifiedInEntityKey, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, global::System.Data.Entity.Resources.Strings.DuplicatePropertyNameSpecifiedInEntityKey(base.ParentElement.FQName, property.Name));
				}
				else
				{
					dictionary.Add(property.Name, propertyRefElement);
					if (property.Nullable)
					{
						base.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.InvalidKey, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, global::System.Data.Entity.Resources.Strings.InvalidKeyNullablePart(property.Name, base.ParentElement.Name));
					}
					if ((!(property.Type is global::System.Data.Entity.Core.SchemaObjectModel.ScalarType) && !(property.Type is global::System.Data.Entity.Core.SchemaObjectModel.SchemaEnumType)) || property.CollectionKind != global::System.Data.Entity.Core.Metadata.Edm.CollectionKind.None)
					{
						base.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.EntityKeyMustBeScalar, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, global::System.Data.Entity.Resources.Strings.EntityKeyMustBeScalar(property.Name, base.ParentElement.Name));
					}
					else if (!(property.Type is global::System.Data.Entity.Core.SchemaObjectModel.SchemaEnumType))
					{
						global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType primitiveType = (global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType)property.TypeUsage.EdmType;
						if (base.Schema.DataModel == global::System.Data.Entity.Core.SchemaObjectModel.SchemaDataModelOption.EntityDataModel)
						{
							if ((primitiveType.PrimitiveTypeKind == global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Binary && base.Schema.SchemaVersion < 2.0) || global::System.Data.Entity.Core.Metadata.Edm.Helper.IsSpatialType(primitiveType))
							{
								base.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.EntityKeyTypeCurrentlyNotSupported, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, global::System.Data.Entity.Resources.Strings.EntityKeyTypeCurrentlyNotSupported(property.Name, base.ParentElement.FQName, primitiveType.PrimitiveTypeKind));
							}
						}
						else if ((primitiveType.PrimitiveTypeKind == global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Binary && base.Schema.SchemaVersion < 2.0) || global::System.Data.Entity.Core.Metadata.Edm.Helper.IsSpatialType(primitiveType))
						{
							base.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.EntityKeyTypeCurrentlyNotSupported, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, global::System.Data.Entity.Resources.Strings.EntityKeyTypeCurrentlyNotSupportedInSSDL(property.Name, base.ParentElement.FQName, property.TypeUsage.EdmType.Name, property.TypeUsage.EdmType.BaseType.FullName, primitiveType.PrimitiveTypeKind));
						}
					}
				}
			}
		}

		// Token: 0x04000C2E RID: 3118
		private global::System.Collections.Generic.List<global::System.Data.Entity.Core.SchemaObjectModel.PropertyRefElement> _keyProperties;
	}
}
