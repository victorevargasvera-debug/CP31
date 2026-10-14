using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Resources;
using System.Xml;

namespace System.Data.Entity.Core.SchemaObjectModel
{
	// Token: 0x02000321 RID: 801
	internal class TypeElement : global::System.Data.Entity.Core.SchemaObjectModel.SchemaType
	{
		// Token: 0x06002616 RID: 9750 RVA: 0x0006BEE0 File Offset: 0x0006A0E0
		public TypeElement(global::System.Data.Entity.Core.SchemaObjectModel.Schema parent) : base(parent)
		{
			this._primitiveType.NamespaceName = base.Schema.Namespace;
		}

		// Token: 0x06002617 RID: 9751 RVA: 0x0006BF18 File Offset: 0x0006A118
		protected override bool HandleElement(global::System.Xml.XmlReader reader)
		{
			if (base.HandleElement(reader))
			{
				return true;
			}
			if (base.CanHandleElement(reader, "FacetDescriptions"))
			{
				this.SkipThroughElement(reader);
				return true;
			}
			if (base.CanHandleElement(reader, "Precision"))
			{
				this.HandlePrecisionElement(reader);
				return true;
			}
			if (base.CanHandleElement(reader, "Scale"))
			{
				this.HandleScaleElement(reader);
				return true;
			}
			if (base.CanHandleElement(reader, "MaxLength"))
			{
				this.HandleMaxLengthElement(reader);
				return true;
			}
			if (base.CanHandleElement(reader, "Unicode"))
			{
				this.HandleUnicodeElement(reader);
				return true;
			}
			if (base.CanHandleElement(reader, "FixedLength"))
			{
				this.HandleFixedLengthElement(reader);
				return true;
			}
			if (base.CanHandleElement(reader, "SRID"))
			{
				this.HandleSridElement(reader);
				return true;
			}
			if (base.CanHandleElement(reader, "IsStrict"))
			{
				this.HandleIsStrictElement(reader);
				return true;
			}
			return false;
		}

		// Token: 0x06002618 RID: 9752 RVA: 0x0006BFE9 File Offset: 0x0006A1E9
		protected override bool HandleAttribute(global::System.Xml.XmlReader reader)
		{
			if (base.HandleAttribute(reader))
			{
				return true;
			}
			if (global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement.CanHandleAttribute(reader, "PrimitiveTypeKind"))
			{
				this.HandlePrimitiveTypeKindAttribute(reader);
				return true;
			}
			return false;
		}

		// Token: 0x06002619 RID: 9753 RVA: 0x0006C010 File Offset: 0x0006A210
		private void HandlePrecisionElement(global::System.Xml.XmlReader reader)
		{
			global::System.Data.Entity.Core.SchemaObjectModel.ByteFacetDescriptionElement byteFacetDescriptionElement = new global::System.Data.Entity.Core.SchemaObjectModel.ByteFacetDescriptionElement(this, "Precision");
			byteFacetDescriptionElement.Parse(reader);
			this._facetDescriptions.Add(byteFacetDescriptionElement);
		}

		// Token: 0x0600261A RID: 9754 RVA: 0x0006C03C File Offset: 0x0006A23C
		private void HandleScaleElement(global::System.Xml.XmlReader reader)
		{
			global::System.Data.Entity.Core.SchemaObjectModel.ByteFacetDescriptionElement byteFacetDescriptionElement = new global::System.Data.Entity.Core.SchemaObjectModel.ByteFacetDescriptionElement(this, "Scale");
			byteFacetDescriptionElement.Parse(reader);
			this._facetDescriptions.Add(byteFacetDescriptionElement);
		}

		// Token: 0x0600261B RID: 9755 RVA: 0x0006C068 File Offset: 0x0006A268
		private void HandleMaxLengthElement(global::System.Xml.XmlReader reader)
		{
			global::System.Data.Entity.Core.SchemaObjectModel.IntegerFacetDescriptionElement integerFacetDescriptionElement = new global::System.Data.Entity.Core.SchemaObjectModel.IntegerFacetDescriptionElement(this, "MaxLength");
			integerFacetDescriptionElement.Parse(reader);
			this._facetDescriptions.Add(integerFacetDescriptionElement);
		}

		// Token: 0x0600261C RID: 9756 RVA: 0x0006C094 File Offset: 0x0006A294
		private void HandleUnicodeElement(global::System.Xml.XmlReader reader)
		{
			global::System.Data.Entity.Core.SchemaObjectModel.BooleanFacetDescriptionElement booleanFacetDescriptionElement = new global::System.Data.Entity.Core.SchemaObjectModel.BooleanFacetDescriptionElement(this, "Unicode");
			booleanFacetDescriptionElement.Parse(reader);
			this._facetDescriptions.Add(booleanFacetDescriptionElement);
		}

		// Token: 0x0600261D RID: 9757 RVA: 0x0006C0C0 File Offset: 0x0006A2C0
		private void HandleFixedLengthElement(global::System.Xml.XmlReader reader)
		{
			global::System.Data.Entity.Core.SchemaObjectModel.BooleanFacetDescriptionElement booleanFacetDescriptionElement = new global::System.Data.Entity.Core.SchemaObjectModel.BooleanFacetDescriptionElement(this, "FixedLength");
			booleanFacetDescriptionElement.Parse(reader);
			this._facetDescriptions.Add(booleanFacetDescriptionElement);
		}

		// Token: 0x0600261E RID: 9758 RVA: 0x0006C0EC File Offset: 0x0006A2EC
		private void HandleSridElement(global::System.Xml.XmlReader reader)
		{
			global::System.Data.Entity.Core.SchemaObjectModel.SridFacetDescriptionElement sridFacetDescriptionElement = new global::System.Data.Entity.Core.SchemaObjectModel.SridFacetDescriptionElement(this, "SRID");
			sridFacetDescriptionElement.Parse(reader);
			this._facetDescriptions.Add(sridFacetDescriptionElement);
		}

		// Token: 0x0600261F RID: 9759 RVA: 0x0006C118 File Offset: 0x0006A318
		private void HandleIsStrictElement(global::System.Xml.XmlReader reader)
		{
			global::System.Data.Entity.Core.SchemaObjectModel.BooleanFacetDescriptionElement booleanFacetDescriptionElement = new global::System.Data.Entity.Core.SchemaObjectModel.BooleanFacetDescriptionElement(this, "IsStrict");
			booleanFacetDescriptionElement.Parse(reader);
			this._facetDescriptions.Add(booleanFacetDescriptionElement);
		}

		// Token: 0x06002620 RID: 9760 RVA: 0x0006C144 File Offset: 0x0006A344
		private void HandlePrimitiveTypeKindAttribute(global::System.Xml.XmlReader reader)
		{
			string value = reader.Value;
			try
			{
				this._primitiveType.PrimitiveTypeKind = (global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind)global::System.Enum.Parse(typeof(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind), value);
				this._primitiveType.BaseType = global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.EdmProviderManifest.GetPrimitiveType(this._primitiveType.PrimitiveTypeKind);
			}
			catch (global::System.ArgumentException)
			{
				base.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.InvalidPrimitiveTypeKind, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, global::System.Data.Entity.Resources.Strings.InvalidPrimitiveTypeKind(value));
			}
		}

		// Token: 0x1700081C RID: 2076
		// (get) Token: 0x06002621 RID: 9761 RVA: 0x0006C1BC File Offset: 0x0006A3BC
		// (set) Token: 0x06002622 RID: 9762 RVA: 0x0006C1C9 File Offset: 0x0006A3C9
		public override string Name
		{
			get
			{
				return this._primitiveType.Name;
			}
			set
			{
				this._primitiveType.Name = value;
			}
		}

		// Token: 0x1700081D RID: 2077
		// (get) Token: 0x06002623 RID: 9763 RVA: 0x0006C1D7 File Offset: 0x0006A3D7
		public global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType PrimitiveType
		{
			get
			{
				return this._primitiveType;
			}
		}

		// Token: 0x1700081E RID: 2078
		// (get) Token: 0x06002624 RID: 9764 RVA: 0x0006C1DF File Offset: 0x0006A3DF
		public global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.FacetDescription> FacetDescriptions
		{
			get
			{
				foreach (global::System.Data.Entity.Core.SchemaObjectModel.FacetDescriptionElement facetDescriptionElement in this._facetDescriptions)
				{
					yield return facetDescriptionElement.FacetDescription;
				}
				global::System.Collections.Generic.List<global::System.Data.Entity.Core.SchemaObjectModel.FacetDescriptionElement>.Enumerator enumerator = default(global::System.Collections.Generic.List<global::System.Data.Entity.Core.SchemaObjectModel.FacetDescriptionElement>.Enumerator);
				yield break;
				yield break;
			}
		}

		// Token: 0x06002625 RID: 9765 RVA: 0x0006C1F0 File Offset: 0x0006A3F0
		internal override void ResolveTopLevelNames()
		{
			base.ResolveTopLevelNames();
			foreach (global::System.Data.Entity.Core.SchemaObjectModel.FacetDescriptionElement facetDescriptionElement in this._facetDescriptions)
			{
				try
				{
					facetDescriptionElement.CreateAndValidateFacetDescription(this.Name);
				}
				catch (global::System.ArgumentException ex)
				{
					base.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.InvalidFacetInProviderManifest, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, ex.Message);
				}
			}
		}

		// Token: 0x06002626 RID: 9766 RVA: 0x0006C270 File Offset: 0x0006A470
		internal override void Validate()
		{
			base.Validate();
			if (!this.ValidateSufficientFacets())
			{
				return;
			}
			this.ValidateInterFacetConsistency();
		}

		// Token: 0x06002627 RID: 9767 RVA: 0x0006C288 File Offset: 0x0006A488
		private bool ValidateInterFacetConsistency()
		{
			if (this.PrimitiveType.PrimitiveTypeKind == global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Decimal)
			{
				global::System.Data.Entity.Core.Metadata.Edm.FacetDescription facet = global::System.Data.Entity.Core.Metadata.Edm.Helper.GetFacet(this.FacetDescriptions, "Precision");
				global::System.Data.Entity.Core.Metadata.Edm.FacetDescription facet2 = global::System.Data.Entity.Core.Metadata.Edm.Helper.GetFacet(this.FacetDescriptions, "Scale");
				if (facet.MaxValue.Value < facet2.MaxValue.Value)
				{
					base.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.BadPrecisionAndScale, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, global::System.Data.Entity.Resources.Strings.BadPrecisionAndScale(facet.MaxValue.Value, facet2.MaxValue.Value));
					return false;
				}
			}
			return true;
		}

		// Token: 0x06002628 RID: 9768 RVA: 0x0006C31C File Offset: 0x0006A51C
		private bool ValidateSufficientFacets()
		{
			global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType primitiveType = this._primitiveType.BaseType as global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType;
			if (primitiveType == null)
			{
				return false;
			}
			bool flag = false;
			foreach (global::System.Data.Entity.Core.Metadata.Edm.FacetDescription facetDescription in primitiveType.FacetDescriptions)
			{
				if (global::System.Data.Entity.Core.Metadata.Edm.Helper.GetFacet(this.FacetDescriptions, facetDescription.FacetName) == null)
				{
					base.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.RequiredFacetMissing, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, global::System.Data.Entity.Resources.Strings.MissingFacetDescription(this.PrimitiveType.Name, this.PrimitiveType.PrimitiveTypeKind, facetDescription.FacetName));
					flag = true;
				}
			}
			return !flag;
		}

		// Token: 0x04000D5E RID: 3422
		private readonly global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType _primitiveType = new global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType();

		// Token: 0x04000D5F RID: 3423
		private readonly global::System.Collections.Generic.List<global::System.Data.Entity.Core.SchemaObjectModel.FacetDescriptionElement> _facetDescriptions = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.SchemaObjectModel.FacetDescriptionElement>();
	}
}
