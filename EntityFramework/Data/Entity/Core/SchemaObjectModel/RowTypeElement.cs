using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Resources;
using System.Text;
using System.Xml;

namespace System.Data.Entity.Core.SchemaObjectModel
{
	// Token: 0x0200030D RID: 781
	internal class RowTypeElement : global::System.Data.Entity.Core.SchemaObjectModel.ModelFunctionTypeElement
	{
		// Token: 0x06002501 RID: 9473 RVA: 0x0006812F File Offset: 0x0006632F
		internal RowTypeElement(global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement parentElement) : base(parentElement)
		{
		}

		// Token: 0x06002502 RID: 9474 RVA: 0x00068143 File Offset: 0x00066343
		protected override bool HandleElement(global::System.Xml.XmlReader reader)
		{
			if (base.CanHandleElement(reader, "Property"))
			{
				this.HandlePropertyElement(reader);
				return true;
			}
			return false;
		}

		// Token: 0x06002503 RID: 9475 RVA: 0x00068160 File Offset: 0x00066360
		protected void HandlePropertyElement(global::System.Xml.XmlReader reader)
		{
			global::System.Data.Entity.Core.SchemaObjectModel.RowTypePropertyElement rowTypePropertyElement = new global::System.Data.Entity.Core.SchemaObjectModel.RowTypePropertyElement(this);
			rowTypePropertyElement.Parse(reader);
			this._properties.Add(rowTypePropertyElement, true, new global::System.Func<object, string>(global::System.Data.Entity.Resources.Strings.DuplicateEntityContainerMemberName));
		}

		// Token: 0x170007E0 RID: 2016
		// (get) Token: 0x06002504 RID: 9476 RVA: 0x00068194 File Offset: 0x00066394
		internal global::System.Data.Entity.Core.SchemaObjectModel.SchemaElementLookUpTable<global::System.Data.Entity.Core.SchemaObjectModel.RowTypePropertyElement> Properties
		{
			get
			{
				return this._properties;
			}
		}

		// Token: 0x06002505 RID: 9477 RVA: 0x0006819C File Offset: 0x0006639C
		internal override void ResolveTopLevelNames()
		{
			foreach (global::System.Data.Entity.Core.SchemaObjectModel.RowTypePropertyElement rowTypePropertyElement in this._properties)
			{
				rowTypePropertyElement.ResolveTopLevelNames();
			}
		}

		// Token: 0x06002506 RID: 9478 RVA: 0x000681E8 File Offset: 0x000663E8
		internal override void WriteIdentity(global::System.Text.StringBuilder builder)
		{
			builder.Append("Row[");
			bool flag = true;
			foreach (global::System.Data.Entity.Core.SchemaObjectModel.ModelFunctionTypeElement modelFunctionTypeElement in this._properties)
			{
				if (flag)
				{
					flag = !flag;
				}
				else
				{
					builder.Append(", ");
				}
				modelFunctionTypeElement.WriteIdentity(builder);
			}
			builder.Append("]");
		}

		// Token: 0x06002507 RID: 9479 RVA: 0x00068264 File Offset: 0x00066464
		internal override global::System.Data.Entity.Core.Metadata.Edm.TypeUsage GetTypeUsage()
		{
			if (this._typeUsage == null)
			{
				global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>();
				foreach (global::System.Data.Entity.Core.SchemaObjectModel.RowTypePropertyElement rowTypePropertyElement in this._properties)
				{
					global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty = new global::System.Data.Entity.Core.Metadata.Edm.EdmProperty(rowTypePropertyElement.FQName, rowTypePropertyElement.GetTypeUsage());
					edmProperty.AddMetadataProperties(rowTypePropertyElement.OtherContent);
					list.Add(edmProperty);
				}
				global::System.Data.Entity.Core.Metadata.Edm.RowType rowType = new global::System.Data.Entity.Core.Metadata.Edm.RowType(list);
				if (base.Schema.DataModel == global::System.Data.Entity.Core.SchemaObjectModel.SchemaDataModelOption.EntityDataModel)
				{
					rowType.DataSpace = global::System.Data.Entity.Core.Metadata.Edm.DataSpace.CSpace;
				}
				else
				{
					rowType.DataSpace = global::System.Data.Entity.Core.Metadata.Edm.DataSpace.SSpace;
				}
				rowType.AddMetadataProperties(base.OtherContent);
				this._typeUsage = global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(rowType);
			}
			return this._typeUsage;
		}

		// Token: 0x06002508 RID: 9480 RVA: 0x00068328 File Offset: 0x00066528
		internal override bool ResolveNameAndSetTypeUsage(global::System.Data.Entity.Core.Metadata.Edm.Converter.ConversionCache convertedItemCache, global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement, global::System.Data.Entity.Core.Metadata.Edm.GlobalItem> newGlobalItems)
		{
			bool result = true;
			if (this._typeUsage == null)
			{
				using (global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.SchemaObjectModel.RowTypePropertyElement> enumerator = this._properties.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						if (!enumerator.Current.ResolveNameAndSetTypeUsage(convertedItemCache, newGlobalItems))
						{
							result = false;
						}
					}
				}
			}
			return result;
		}

		// Token: 0x06002509 RID: 9481 RVA: 0x00068384 File Offset: 0x00066584
		internal override void Validate()
		{
			foreach (global::System.Data.Entity.Core.SchemaObjectModel.RowTypePropertyElement rowTypePropertyElement in this._properties)
			{
				rowTypePropertyElement.Validate();
			}
			if (this._properties.Count == 0)
			{
				base.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.RowTypeWithoutProperty, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, global::System.Data.Entity.Resources.Strings.RowTypeWithoutProperty);
			}
		}

		// Token: 0x04000D15 RID: 3349
		private readonly global::System.Data.Entity.Core.SchemaObjectModel.SchemaElementLookUpTable<global::System.Data.Entity.Core.SchemaObjectModel.RowTypePropertyElement> _properties = new global::System.Data.Entity.Core.SchemaObjectModel.SchemaElementLookUpTable<global::System.Data.Entity.Core.SchemaObjectModel.RowTypePropertyElement>();
	}
}
