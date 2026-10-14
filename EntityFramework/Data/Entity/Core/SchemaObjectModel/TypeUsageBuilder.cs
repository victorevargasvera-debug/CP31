using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Resources;
using System.Diagnostics;
using System.Linq;
using System.Xml;

namespace System.Data.Entity.Core.SchemaObjectModel
{
	// Token: 0x02000324 RID: 804
	internal class TypeUsageBuilder
	{
		// Token: 0x06002630 RID: 9776 RVA: 0x0006C4EE File Offset: 0x0006A6EE
		internal TypeUsageBuilder(global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement element)
		{
			this._element = element;
			this._facetValues = new global::System.Collections.Generic.Dictionary<string, object>();
		}

		// Token: 0x1700081F RID: 2079
		// (get) Token: 0x06002631 RID: 9777 RVA: 0x0006C508 File Offset: 0x0006A708
		internal global::System.Data.Entity.Core.Metadata.Edm.TypeUsage TypeUsage
		{
			get
			{
				return this._typeUsage;
			}
		}

		// Token: 0x17000820 RID: 2080
		// (get) Token: 0x06002632 RID: 9778 RVA: 0x0006C510 File Offset: 0x0006A710
		internal bool Nullable
		{
			get
			{
				return this._nullable == null || this._nullable.Value;
			}
		}

		// Token: 0x17000821 RID: 2081
		// (get) Token: 0x06002633 RID: 9779 RVA: 0x0006C52C File Offset: 0x0006A72C
		internal string Default
		{
			get
			{
				return this._default;
			}
		}

		// Token: 0x17000822 RID: 2082
		// (get) Token: 0x06002634 RID: 9780 RVA: 0x0006C534 File Offset: 0x0006A734
		internal object DefaultAsObject
		{
			get
			{
				return this._defaultObject;
			}
		}

		// Token: 0x17000823 RID: 2083
		// (get) Token: 0x06002635 RID: 9781 RVA: 0x0006C53C File Offset: 0x0006A73C
		internal bool HasUserDefinedFacets
		{
			get
			{
				return this._hasUserDefinedFacets;
			}
		}

		// Token: 0x06002636 RID: 9782 RVA: 0x0006C544 File Offset: 0x0006A744
		private bool TryGetFacets(global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType, bool complainOnMissingFacet, out global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Metadata.Edm.Facet> calculatedFacets)
		{
			bool result = true;
			global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Metadata.Edm.Facet> dictionary = edmType.GetAssociatedFacetDescriptions().ToDictionary((global::System.Data.Entity.Core.Metadata.Edm.FacetDescription f) => f.FacetName, (global::System.Data.Entity.Core.Metadata.Edm.FacetDescription f) => f.DefaultValueFacet);
			calculatedFacets = new global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Metadata.Edm.Facet>();
			foreach (global::System.Data.Entity.Core.Metadata.Edm.Facet facet in dictionary.Values)
			{
				object value;
				if (this._facetValues.TryGetValue(facet.Name, out value))
				{
					if (facet.Description.IsConstant)
					{
						this._element.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.ConstantFacetSpecifiedInSchema, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, this._element, global::System.Data.Entity.Resources.Strings.ConstantFacetSpecifiedInSchema(facet.Name, edmType.Name));
						result = false;
					}
					else
					{
						calculatedFacets.Add(facet.Name, global::System.Data.Entity.Core.Metadata.Edm.Facet.Create(facet.Description, value));
					}
					this._facetValues.Remove(facet.Name);
				}
				else if (complainOnMissingFacet && facet.Description.IsRequired)
				{
					this._element.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.RequiredFacetMissing, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, global::System.Data.Entity.Resources.Strings.RequiredFacetMissing(facet.Name, edmType.Name));
					result = false;
				}
				else
				{
					calculatedFacets.Add(facet.Name, facet);
				}
			}
			foreach (global::System.Collections.Generic.KeyValuePair<string, object> keyValuePair in this._facetValues)
			{
				if (keyValuePair.Key == "StoreGeneratedPattern")
				{
					global::System.Data.Entity.Core.Metadata.Edm.Facet facet2 = global::System.Data.Entity.Core.Metadata.Edm.Facet.Create(global::System.Data.Entity.Core.Metadata.Edm.Converter.StoreGeneratedPatternFacet, keyValuePair.Value);
					calculatedFacets.Add(facet2.Name, facet2);
				}
				else if (keyValuePair.Key == "ConcurrencyMode")
				{
					global::System.Data.Entity.Core.Metadata.Edm.Facet facet3 = global::System.Data.Entity.Core.Metadata.Edm.Facet.Create(global::System.Data.Entity.Core.Metadata.Edm.Converter.ConcurrencyModeFacet, keyValuePair.Value);
					calculatedFacets.Add(facet3.Name, facet3);
				}
				else if (edmType is global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType && ((global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType)edmType).PrimitiveTypeKind == global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String && keyValuePair.Key == "Collation")
				{
					global::System.Data.Entity.Core.Metadata.Edm.Facet facet4 = global::System.Data.Entity.Core.Metadata.Edm.Facet.Create(global::System.Data.Entity.Core.Metadata.Edm.Converter.CollationFacet, keyValuePair.Value);
					calculatedFacets.Add(facet4.Name, facet4);
				}
				else
				{
					this._element.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.FacetNotAllowedByType, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, global::System.Data.Entity.Resources.Strings.FacetNotAllowed(keyValuePair.Key, edmType.Name));
				}
			}
			return result;
		}

		// Token: 0x06002637 RID: 9783 RVA: 0x0006C7C8 File Offset: 0x0006A9C8
		internal void ValidateAndSetTypeUsage(global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType, bool complainOnMissingFacet)
		{
			global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Metadata.Edm.Facet> dictionary;
			this.TryGetFacets(edmType, complainOnMissingFacet, out dictionary);
			this._typeUsage = global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(edmType, dictionary.Values);
		}

		// Token: 0x06002638 RID: 9784 RVA: 0x0006C7F4 File Offset: 0x0006A9F4
		internal void ValidateAndSetTypeUsage(global::System.Data.Entity.Core.SchemaObjectModel.ScalarType scalar, bool complainOnMissingFacet)
		{
			global::System.Diagnostics.Trace.Assert(this._element != null);
			global::System.Diagnostics.Trace.Assert(scalar != null);
			if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsSpatialType(scalar.Type) && !this._facetValues.ContainsKey("IsStrict") && !this._element.Schema.UseStrongSpatialTypes)
			{
				this._facetValues.Add("IsStrict", false);
			}
			global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Metadata.Edm.Facet> dictionary;
			if (this.TryGetFacets(scalar.Type, complainOnMissingFacet, out dictionary))
			{
				switch (scalar.TypeKind)
				{
				case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Binary:
					this.ValidateAndSetBinaryFacets(scalar.Type, dictionary);
					break;
				case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.DateTime:
				case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Time:
				case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.DateTimeOffset:
					this.ValidatePrecisionFacetsForDateTimeFamily(scalar.Type, dictionary);
					break;
				case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Decimal:
					this.ValidateAndSetDecimalFacets(scalar.Type, dictionary);
					break;
				case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String:
					this.ValidateAndSetStringFacets(scalar.Type, dictionary);
					break;
				case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Geometry:
				case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Geography:
				case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeometryPoint:
				case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeometryLineString:
				case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeometryPolygon:
				case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeometryMultiPoint:
				case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeometryMultiLineString:
				case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeometryMultiPolygon:
				case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeometryCollection:
				case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeographyPoint:
				case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeographyLineString:
				case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeographyPolygon:
				case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeographyMultiPoint:
				case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeographyMultiLineString:
				case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeographyMultiPolygon:
				case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeographyCollection:
					this.ValidateSpatialFacets(scalar.Type, dictionary);
					break;
				}
			}
			this._typeUsage = global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(scalar.Type, dictionary.Values);
		}

		// Token: 0x06002639 RID: 9785 RVA: 0x0006C964 File Offset: 0x0006AB64
		internal void ValidateEnumFacets(global::System.Data.Entity.Core.SchemaObjectModel.SchemaEnumType schemaEnumType)
		{
			foreach (global::System.Collections.Generic.KeyValuePair<string, object> keyValuePair in this._facetValues)
			{
				if (keyValuePair.Key != "Nullable" && keyValuePair.Key != "StoreGeneratedPattern" && keyValuePair.Key != "ConcurrencyMode")
				{
					this._element.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.FacetNotAllowedByType, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, global::System.Data.Entity.Resources.Strings.FacetNotAllowed(keyValuePair.Key, schemaEnumType.FQName));
				}
			}
		}

		// Token: 0x0600263A RID: 9786 RVA: 0x0006CA0C File Offset: 0x0006AC0C
		internal bool HandleAttribute(global::System.Xml.XmlReader reader)
		{
			bool flag = this.InternalHandleAttribute(reader);
			this._hasUserDefinedFacets = (this._hasUserDefinedFacets || flag);
			return flag;
		}

		// Token: 0x0600263B RID: 9787 RVA: 0x0006CA30 File Offset: 0x0006AC30
		private bool InternalHandleAttribute(global::System.Xml.XmlReader reader)
		{
			if (global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement.CanHandleAttribute(reader, "Nullable"))
			{
				this.HandleNullableAttribute(reader);
				return true;
			}
			if (global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement.CanHandleAttribute(reader, "DefaultValue"))
			{
				this.HandleDefaultAttribute(reader);
				return true;
			}
			if (global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement.CanHandleAttribute(reader, "Precision"))
			{
				this.HandlePrecisionAttribute(reader);
				return true;
			}
			if (global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement.CanHandleAttribute(reader, "Scale"))
			{
				this.HandleScaleAttribute(reader);
				return true;
			}
			if (global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement.CanHandleAttribute(reader, "StoreGeneratedPattern"))
			{
				this.HandleStoreGeneratedPatternAttribute(reader);
				return true;
			}
			if (global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement.CanHandleAttribute(reader, "ConcurrencyMode"))
			{
				this.HandleConcurrencyModeAttribute(reader);
				return true;
			}
			if (global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement.CanHandleAttribute(reader, "MaxLength"))
			{
				this.HandleMaxLengthAttribute(reader);
				return true;
			}
			if (global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement.CanHandleAttribute(reader, "Unicode"))
			{
				this.HandleUnicodeAttribute(reader);
				return true;
			}
			if (global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement.CanHandleAttribute(reader, "Collation"))
			{
				this.HandleCollationAttribute(reader);
				return true;
			}
			if (global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement.CanHandleAttribute(reader, "FixedLength"))
			{
				this.HandleIsFixedLengthAttribute(reader);
				return true;
			}
			if (global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement.CanHandleAttribute(reader, "Nullable"))
			{
				this.HandleNullableAttribute(reader);
				return true;
			}
			if (global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement.CanHandleAttribute(reader, "SRID"))
			{
				this.HandleSridAttribute(reader);
				return true;
			}
			return false;
		}

		// Token: 0x0600263C RID: 9788 RVA: 0x0006CB46 File Offset: 0x0006AD46
		private void ValidateAndSetBinaryFacets(global::System.Data.Entity.Core.Metadata.Edm.EdmType type, global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Metadata.Edm.Facet> facets)
		{
			this.ValidateLengthFacets(type, facets);
		}

		// Token: 0x0600263D RID: 9789 RVA: 0x0006CB50 File Offset: 0x0006AD50
		private void ValidateAndSetDecimalFacets(global::System.Data.Entity.Core.Metadata.Edm.EdmType type, global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Metadata.Edm.Facet> facets)
		{
			global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType primitiveType = (global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType)type;
			byte? b = null;
			global::System.Data.Entity.Core.Metadata.Edm.Facet facet;
			if (facets.TryGetValue("Precision", out facet) && facet.Value != null)
			{
				b = new byte?((byte)facet.Value);
				global::System.Data.Entity.Core.Metadata.Edm.FacetDescription facet2 = global::System.Data.Entity.Core.Metadata.Edm.Helper.GetFacet(primitiveType.FacetDescriptions, "Precision");
				byte? b2 = b;
				int? num = (b2 != null) ? new int?((int)b2.GetValueOrDefault()) : null;
				int num2 = facet2.MinValue.Value;
				if (!(num.GetValueOrDefault() < num2 & num != null))
				{
					b2 = b;
					num = ((b2 != null) ? new int?((int)b2.GetValueOrDefault()) : null);
					num2 = facet2.MaxValue.Value;
					if (!(num.GetValueOrDefault() > num2 & num != null))
					{
						goto IL_133;
					}
				}
				this._element.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.PrecisionOutOfRange, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, global::System.Data.Entity.Resources.Strings.PrecisionOutOfRange(b, facet2.MinValue.Value, facet2.MaxValue.Value, primitiveType.Name));
			}
			IL_133:
			global::System.Data.Entity.Core.Metadata.Edm.Facet facet3;
			if (facets.TryGetValue("Scale", out facet3) && facet3.Value != null)
			{
				byte b3 = (byte)facet3.Value;
				global::System.Data.Entity.Core.Metadata.Edm.FacetDescription facet4 = global::System.Data.Entity.Core.Metadata.Edm.Helper.GetFacet(primitiveType.FacetDescriptions, "Scale");
				if ((int)b3 < facet4.MinValue.Value || (int)b3 > facet4.MaxValue.Value)
				{
					this._element.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.ScaleOutOfRange, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, global::System.Data.Entity.Resources.Strings.ScaleOutOfRange(b3, facet4.MinValue.Value, facet4.MaxValue.Value, primitiveType.Name));
					return;
				}
				if (b != null)
				{
					byte? b2 = b;
					int? num = (b2 != null) ? new int?((int)b2.GetValueOrDefault()) : null;
					int num2 = (int)b3;
					if (num.GetValueOrDefault() < num2 & num != null)
					{
						this._element.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.BadPrecisionAndScale, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, global::System.Data.Entity.Resources.Strings.BadPrecisionAndScale(b, b3));
					}
				}
			}
		}

		// Token: 0x0600263E RID: 9790 RVA: 0x0006CDA8 File Offset: 0x0006AFA8
		private void ValidatePrecisionFacetsForDateTimeFamily(global::System.Data.Entity.Core.Metadata.Edm.EdmType type, global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Metadata.Edm.Facet> facets)
		{
			global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType primitiveType = (global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType)type;
			byte? b = null;
			global::System.Data.Entity.Core.Metadata.Edm.Facet facet;
			if (facets.TryGetValue("Precision", out facet) && facet.Value != null)
			{
				b = new byte?((byte)facet.Value);
				global::System.Data.Entity.Core.Metadata.Edm.FacetDescription facet2 = global::System.Data.Entity.Core.Metadata.Edm.Helper.GetFacet(primitiveType.FacetDescriptions, "Precision");
				byte? b2 = b;
				int? num = (b2 != null) ? new int?((int)b2.GetValueOrDefault()) : null;
				int value = facet2.MinValue.Value;
				if (!(num.GetValueOrDefault() < value & num != null))
				{
					b2 = b;
					num = ((b2 != null) ? new int?((int)b2.GetValueOrDefault()) : null);
					value = facet2.MaxValue.Value;
					if (!(num.GetValueOrDefault() > value & num != null))
					{
						return;
					}
				}
				this._element.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.PrecisionOutOfRange, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, global::System.Data.Entity.Resources.Strings.PrecisionOutOfRange(b, facet2.MinValue.Value, facet2.MaxValue.Value, primitiveType.Name));
			}
		}

		// Token: 0x0600263F RID: 9791 RVA: 0x0006CEE3 File Offset: 0x0006B0E3
		private void ValidateAndSetStringFacets(global::System.Data.Entity.Core.Metadata.Edm.EdmType type, global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Metadata.Edm.Facet> facets)
		{
			this.ValidateLengthFacets(type, facets);
		}

		// Token: 0x06002640 RID: 9792 RVA: 0x0006CEF0 File Offset: 0x0006B0F0
		private void ValidateLengthFacets(global::System.Data.Entity.Core.Metadata.Edm.EdmType type, global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Metadata.Edm.Facet> facets)
		{
			global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType primitiveType = (global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType)type;
			global::System.Data.Entity.Core.Metadata.Edm.Facet facet;
			if (!facets.TryGetValue("MaxLength", out facet) || facet.Value == null)
			{
				return;
			}
			if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsUnboundedFacetValue(facet))
			{
				return;
			}
			int num = (int)facet.Value;
			global::System.Data.Entity.Core.Metadata.Edm.FacetDescription facet2 = global::System.Data.Entity.Core.Metadata.Edm.Helper.GetFacet(primitiveType.FacetDescriptions, "MaxLength");
			int value = facet2.MaxValue.Value;
			int value2 = facet2.MinValue.Value;
			if (num < value2 || num > value)
			{
				this._element.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.InvalidSize, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, global::System.Data.Entity.Resources.Strings.InvalidSize(num, value2, value, primitiveType.Name));
			}
		}

		// Token: 0x06002641 RID: 9793 RVA: 0x0006CF98 File Offset: 0x0006B198
		private void ValidateSpatialFacets(global::System.Data.Entity.Core.Metadata.Edm.EdmType type, global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Metadata.Edm.Facet> facets)
		{
			global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType primitiveType = (global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType)type;
			if (this._facetValues.ContainsKey("ConcurrencyMode"))
			{
				this._element.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.FacetNotAllowedByType, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, global::System.Data.Entity.Resources.Strings.FacetNotAllowed("ConcurrencyMode", type.FullName));
			}
			global::System.Data.Entity.Core.Metadata.Edm.Facet facet;
			if (this._element.Schema.DataModel == global::System.Data.Entity.Core.SchemaObjectModel.SchemaDataModelOption.EntityDataModel && (!facets.TryGetValue("IsStrict", out facet) || (bool)facet.Value))
			{
				this._element.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.UnexpectedSpatialType, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, global::System.Data.Entity.Resources.Strings.SpatialWithUseStrongSpatialTypesFalse);
			}
			global::System.Data.Entity.Core.Metadata.Edm.Facet facet2;
			if (!facets.TryGetValue("SRID", out facet2) || facet2.Value == null)
			{
				return;
			}
			if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsVariableFacetValue(facet2))
			{
				return;
			}
			int num = (int)facet2.Value;
			global::System.Data.Entity.Core.Metadata.Edm.FacetDescription facet3 = global::System.Data.Entity.Core.Metadata.Edm.Helper.GetFacet(primitiveType.FacetDescriptions, "SRID");
			int value = facet3.MaxValue.Value;
			int value2 = facet3.MinValue.Value;
			if (num < value2 || num > value)
			{
				this._element.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.InvalidSystemReferenceId, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, global::System.Data.Entity.Resources.Strings.InvalidSystemReferenceId(num, value2, value, primitiveType.Name));
			}
		}

		// Token: 0x06002642 RID: 9794 RVA: 0x0006D0B8 File Offset: 0x0006B2B8
		internal void HandleMaxLengthAttribute(global::System.Xml.XmlReader reader)
		{
			if (reader.Value.Trim() == "Max")
			{
				this._facetValues.Add("MaxLength", global::System.Data.Entity.Core.Metadata.Edm.EdmConstants.UnboundedValue);
				return;
			}
			int num = 0;
			if (!this._element.HandleIntAttribute(reader, ref num))
			{
				return;
			}
			this._facetValues.Add("MaxLength", num);
		}

		// Token: 0x06002643 RID: 9795 RVA: 0x0006D11C File Offset: 0x0006B31C
		internal void HandleSridAttribute(global::System.Xml.XmlReader reader)
		{
			if (reader.Value.Trim() == "Variable")
			{
				this._facetValues.Add("SRID", global::System.Data.Entity.Core.Metadata.Edm.EdmConstants.VariableValue);
				return;
			}
			int num = 0;
			if (!this._element.HandleIntAttribute(reader, ref num))
			{
				return;
			}
			this._facetValues.Add("SRID", num);
		}

		// Token: 0x06002644 RID: 9796 RVA: 0x0006D180 File Offset: 0x0006B380
		private void HandleNullableAttribute(global::System.Xml.XmlReader reader)
		{
			bool flag = false;
			if (this._element.HandleBoolAttribute(reader, ref flag))
			{
				this._facetValues.Add("Nullable", flag);
				this._nullable = new bool?(flag);
			}
		}

		// Token: 0x06002645 RID: 9797 RVA: 0x0006D1C4 File Offset: 0x0006B3C4
		internal void HandleStoreGeneratedPatternAttribute(global::System.Xml.XmlReader reader)
		{
			string value = reader.Value;
			global::System.Data.Entity.Core.Metadata.Edm.StoreGeneratedPattern storeGeneratedPattern;
			if (value == "None")
			{
				storeGeneratedPattern = global::System.Data.Entity.Core.Metadata.Edm.StoreGeneratedPattern.None;
			}
			else if (value == "Identity")
			{
				storeGeneratedPattern = global::System.Data.Entity.Core.Metadata.Edm.StoreGeneratedPattern.Identity;
			}
			else
			{
				if (!(value == "Computed"))
				{
					return;
				}
				storeGeneratedPattern = global::System.Data.Entity.Core.Metadata.Edm.StoreGeneratedPattern.Computed;
			}
			this._facetValues.Add("StoreGeneratedPattern", storeGeneratedPattern);
		}

		// Token: 0x06002646 RID: 9798 RVA: 0x0006D224 File Offset: 0x0006B424
		internal void HandleConcurrencyModeAttribute(global::System.Xml.XmlReader reader)
		{
			string value = reader.Value;
			global::System.Data.Entity.Core.Metadata.Edm.ConcurrencyMode concurrencyMode;
			if (value == "None")
			{
				concurrencyMode = global::System.Data.Entity.Core.Metadata.Edm.ConcurrencyMode.None;
			}
			else
			{
				if (!(value == "Fixed"))
				{
					return;
				}
				concurrencyMode = global::System.Data.Entity.Core.Metadata.Edm.ConcurrencyMode.Fixed;
			}
			this._facetValues.Add("ConcurrencyMode", concurrencyMode);
		}

		// Token: 0x06002647 RID: 9799 RVA: 0x0006D271 File Offset: 0x0006B471
		private void HandleDefaultAttribute(global::System.Xml.XmlReader reader)
		{
			this._default = reader.Value;
		}

		// Token: 0x06002648 RID: 9800 RVA: 0x0006D280 File Offset: 0x0006B480
		private void HandlePrecisionAttribute(global::System.Xml.XmlReader reader)
		{
			byte b = 0;
			if (this._element.HandleByteAttribute(reader, ref b))
			{
				this._facetValues.Add("Precision", b);
			}
		}

		// Token: 0x06002649 RID: 9801 RVA: 0x0006D2B8 File Offset: 0x0006B4B8
		private void HandleScaleAttribute(global::System.Xml.XmlReader reader)
		{
			byte b = 0;
			if (this._element.HandleByteAttribute(reader, ref b))
			{
				this._facetValues.Add("Scale", b);
			}
		}

		// Token: 0x0600264A RID: 9802 RVA: 0x0006D2F0 File Offset: 0x0006B4F0
		private void HandleUnicodeAttribute(global::System.Xml.XmlReader reader)
		{
			bool flag = false;
			if (this._element.HandleBoolAttribute(reader, ref flag))
			{
				this._facetValues.Add("Unicode", flag);
			}
		}

		// Token: 0x0600264B RID: 9803 RVA: 0x0006D325 File Offset: 0x0006B525
		private void HandleCollationAttribute(global::System.Xml.XmlReader reader)
		{
			if (string.IsNullOrEmpty(reader.Value))
			{
				return;
			}
			this._facetValues.Add("Collation", reader.Value);
		}

		// Token: 0x0600264C RID: 9804 RVA: 0x0006D34C File Offset: 0x0006B54C
		private void HandleIsFixedLengthAttribute(global::System.Xml.XmlReader reader)
		{
			bool flag = false;
			if (this._element.HandleBoolAttribute(reader, ref flag))
			{
				this._facetValues.Add("FixedLength", flag);
			}
		}

		// Token: 0x0600264D RID: 9805 RVA: 0x0006D384 File Offset: 0x0006B584
		internal void ValidateDefaultValue(global::System.Data.Entity.Core.SchemaObjectModel.SchemaType type)
		{
			if (this._default == null)
			{
				return;
			}
			global::System.Data.Entity.Core.SchemaObjectModel.ScalarType scalarType = type as global::System.Data.Entity.Core.SchemaObjectModel.ScalarType;
			if (scalarType != null)
			{
				this.ValidateScalarMemberDefaultValue(scalarType);
				return;
			}
			this._element.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.DefaultNotAllowed, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, global::System.Data.Entity.Resources.Strings.DefaultNotAllowed);
		}

		// Token: 0x0600264E RID: 9806 RVA: 0x0006D3C0 File Offset: 0x0006B5C0
		private void ValidateScalarMemberDefaultValue(global::System.Data.Entity.Core.SchemaObjectModel.ScalarType scalar)
		{
			if (scalar != null)
			{
				switch (scalar.TypeKind)
				{
				case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Binary:
					this.ValidateBinaryDefaultValue(scalar);
					return;
				case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Boolean:
					this.ValidateBooleanDefaultValue(scalar);
					return;
				case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Byte:
					this.ValidateIntegralDefaultValue(scalar, 0L, 255L);
					return;
				case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.DateTime:
					this.ValidateDateTimeDefaultValue(scalar);
					return;
				case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Decimal:
					this.ValidateDecimalDefaultValue(scalar);
					return;
				case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Double:
					this.ValidateFloatingPointDefaultValue(scalar, double.MinValue, double.MaxValue);
					return;
				case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Guid:
					this.ValidateGuidDefaultValue(scalar);
					return;
				case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Single:
					this.ValidateFloatingPointDefaultValue(scalar, -3.4028234663852886E+38, 3.4028234663852886E+38);
					return;
				case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int16:
					this.ValidateIntegralDefaultValue(scalar, -32768L, 32767L);
					return;
				case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int32:
					this.ValidateIntegralDefaultValue(scalar, -2147483648L, 2147483647L);
					return;
				case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int64:
					this.ValidateIntegralDefaultValue(scalar, long.MinValue, long.MaxValue);
					return;
				case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String:
					this._defaultObject = this._default;
					return;
				case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Time:
					this.ValidateTimeDefaultValue(scalar);
					return;
				case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.DateTimeOffset:
					this.ValidateDateTimeOffsetDefaultValue(scalar);
					return;
				}
				this._element.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.DefaultNotAllowed, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, global::System.Data.Entity.Resources.Strings.DefaultNotAllowed);
				return;
			}
		}

		// Token: 0x0600264F RID: 9807 RVA: 0x0006D500 File Offset: 0x0006B700
		private void ValidateBinaryDefaultValue(global::System.Data.Entity.Core.SchemaObjectModel.ScalarType scalar)
		{
			if (scalar.TryParse(this._default, out this._defaultObject))
			{
				return;
			}
			string message = global::System.Data.Entity.Resources.Strings.InvalidDefaultBinaryWithNoMaxLength(this._default);
			this._element.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.InvalidDefault, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, message);
		}

		// Token: 0x06002650 RID: 9808 RVA: 0x0006D53D File Offset: 0x0006B73D
		private void ValidateBooleanDefaultValue(global::System.Data.Entity.Core.SchemaObjectModel.ScalarType scalar)
		{
			if (!scalar.TryParse(this._default, out this._defaultObject))
			{
				this._element.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.InvalidDefault, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, global::System.Data.Entity.Resources.Strings.InvalidDefaultBoolean(this._default));
			}
		}

		// Token: 0x06002651 RID: 9809 RVA: 0x0006D56C File Offset: 0x0006B76C
		private void ValidateIntegralDefaultValue(global::System.Data.Entity.Core.SchemaObjectModel.ScalarType scalar, long minValue, long maxValue)
		{
			if (!scalar.TryParse(this._default, out this._defaultObject))
			{
				this._element.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.InvalidDefault, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, global::System.Data.Entity.Resources.Strings.InvalidDefaultIntegral(this._default, minValue, maxValue));
			}
		}

		// Token: 0x06002652 RID: 9810 RVA: 0x0006D5A8 File Offset: 0x0006B7A8
		private void ValidateDateTimeDefaultValue(global::System.Data.Entity.Core.SchemaObjectModel.ScalarType scalar)
		{
			if (!scalar.TryParse(this._default, out this._defaultObject))
			{
				this._element.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.InvalidDefault, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, global::System.Data.Entity.Resources.Strings.InvalidDefaultDateTime(this._default, "yyyy-MM-dd HH\\:mm\\:ss.fffZ".Replace("\\", "")));
			}
		}

		// Token: 0x06002653 RID: 9811 RVA: 0x0006D5F8 File Offset: 0x0006B7F8
		private void ValidateTimeDefaultValue(global::System.Data.Entity.Core.SchemaObjectModel.ScalarType scalar)
		{
			if (!scalar.TryParse(this._default, out this._defaultObject))
			{
				this._element.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.InvalidDefault, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, global::System.Data.Entity.Resources.Strings.InvalidDefaultTime(this._default, "HH\\:mm\\:ss.fffffffZ".Replace("\\", "")));
			}
		}

		// Token: 0x06002654 RID: 9812 RVA: 0x0006D648 File Offset: 0x0006B848
		private void ValidateDateTimeOffsetDefaultValue(global::System.Data.Entity.Core.SchemaObjectModel.ScalarType scalar)
		{
			if (!scalar.TryParse(this._default, out this._defaultObject))
			{
				this._element.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.InvalidDefault, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, global::System.Data.Entity.Resources.Strings.InvalidDefaultDateTimeOffset(this._default, "yyyy-MM-dd HH\\:mm\\:ss.fffffffz".Replace("\\", "")));
			}
		}

		// Token: 0x06002655 RID: 9813 RVA: 0x0006D696 File Offset: 0x0006B896
		private void ValidateDecimalDefaultValue(global::System.Data.Entity.Core.SchemaObjectModel.ScalarType scalar)
		{
			if (scalar.TryParse(this._default, out this._defaultObject))
			{
				return;
			}
			this._element.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.InvalidDefault, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, global::System.Data.Entity.Resources.Strings.InvalidDefaultDecimal(this._default, 38, 38));
		}

		// Token: 0x06002656 RID: 9814 RVA: 0x0006D6D4 File Offset: 0x0006B8D4
		private void ValidateFloatingPointDefaultValue(global::System.Data.Entity.Core.SchemaObjectModel.ScalarType scalar, double minValue, double maxValue)
		{
			if (!scalar.TryParse(this._default, out this._defaultObject))
			{
				this._element.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.InvalidDefault, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, global::System.Data.Entity.Resources.Strings.InvalidDefaultFloatingPoint(this._default, minValue, maxValue));
			}
		}

		// Token: 0x06002657 RID: 9815 RVA: 0x0006D70F File Offset: 0x0006B90F
		private void ValidateGuidDefaultValue(global::System.Data.Entity.Core.SchemaObjectModel.ScalarType scalar)
		{
			if (!scalar.TryParse(this._default, out this._defaultObject))
			{
				this._element.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.InvalidDefault, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, global::System.Data.Entity.Resources.Strings.InvalidDefaultGuid(this._default));
			}
		}

		// Token: 0x04000D65 RID: 3429
		private readonly global::System.Collections.Generic.Dictionary<string, object> _facetValues;

		// Token: 0x04000D66 RID: 3430
		private readonly global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement _element;

		// Token: 0x04000D67 RID: 3431
		private string _default;

		// Token: 0x04000D68 RID: 3432
		private object _defaultObject;

		// Token: 0x04000D69 RID: 3433
		private bool? _nullable;

		// Token: 0x04000D6A RID: 3434
		private global::System.Data.Entity.Core.Metadata.Edm.TypeUsage _typeUsage;

		// Token: 0x04000D6B RID: 3435
		private bool _hasUserDefinedFacets;
	}
}
