using System;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Threading;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x020004C2 RID: 1218
	public class FacetDescription
	{
		// Token: 0x06003C4B RID: 15435 RVA: 0x000C6C95 File Offset: 0x000C4E95
		internal FacetDescription()
		{
		}

		// Token: 0x06003C4C RID: 15436 RVA: 0x000C6CA0 File Offset: 0x000C4EA0
		internal FacetDescription(string facetName, global::System.Data.Entity.Core.Metadata.Edm.EdmType facetType, int? minValue, int? maxValue, object defaultValue, bool isConstant, string declaringTypeName)
		{
			this._facetName = facetName;
			this._facetType = facetType;
			this._minValue = minValue;
			this._maxValue = maxValue;
			if (defaultValue != null)
			{
				this._defaultValue = defaultValue;
			}
			else
			{
				this._defaultValue = global::System.Data.Entity.Core.Metadata.Edm.FacetDescription._notInitializedSentinel;
			}
			this._isConstant = isConstant;
			this.Validate(declaringTypeName);
			if (this._isConstant)
			{
				global::System.Data.Entity.Core.Metadata.Edm.FacetDescription.UpdateMinMaxValueForConstant(this._facetName, this._facetType, ref this._minValue, ref this._maxValue, this._defaultValue);
			}
		}

		// Token: 0x06003C4D RID: 15437 RVA: 0x000C6D24 File Offset: 0x000C4F24
		internal FacetDescription(string facetName, global::System.Data.Entity.Core.Metadata.Edm.EdmType facetType, int? minValue, int? maxValue, object defaultValue)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(facetName, "facetName");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.EdmType>(facetType, "facetType");
			if ((minValue != null || maxValue != null) && minValue != null)
			{
				bool flag = maxValue != null;
			}
			this._facetName = facetName;
			this._facetType = facetType;
			this._minValue = minValue;
			this._maxValue = maxValue;
			this._defaultValue = defaultValue;
		}

		// Token: 0x17000BCD RID: 3021
		// (get) Token: 0x06003C4E RID: 15438 RVA: 0x000C6D97 File Offset: 0x000C4F97
		public virtual string FacetName
		{
			get
			{
				return this._facetName;
			}
		}

		// Token: 0x17000BCE RID: 3022
		// (get) Token: 0x06003C4F RID: 15439 RVA: 0x000C6D9F File Offset: 0x000C4F9F
		public global::System.Data.Entity.Core.Metadata.Edm.EdmType FacetType
		{
			get
			{
				return this._facetType;
			}
		}

		// Token: 0x17000BCF RID: 3023
		// (get) Token: 0x06003C50 RID: 15440 RVA: 0x000C6DA7 File Offset: 0x000C4FA7
		public int? MinValue
		{
			get
			{
				return this._minValue;
			}
		}

		// Token: 0x17000BD0 RID: 3024
		// (get) Token: 0x06003C51 RID: 15441 RVA: 0x000C6DAF File Offset: 0x000C4FAF
		public int? MaxValue
		{
			get
			{
				return this._maxValue;
			}
		}

		// Token: 0x17000BD1 RID: 3025
		// (get) Token: 0x06003C52 RID: 15442 RVA: 0x000C6DB7 File Offset: 0x000C4FB7
		public object DefaultValue
		{
			get
			{
				if (this._defaultValue == global::System.Data.Entity.Core.Metadata.Edm.FacetDescription._notInitializedSentinel)
				{
					return null;
				}
				return this._defaultValue;
			}
		}

		// Token: 0x17000BD2 RID: 3026
		// (get) Token: 0x06003C53 RID: 15443 RVA: 0x000C6DCE File Offset: 0x000C4FCE
		public virtual bool IsConstant
		{
			get
			{
				return this._isConstant;
			}
		}

		// Token: 0x17000BD3 RID: 3027
		// (get) Token: 0x06003C54 RID: 15444 RVA: 0x000C6DD6 File Offset: 0x000C4FD6
		public bool IsRequired
		{
			get
			{
				return this._defaultValue == global::System.Data.Entity.Core.Metadata.Edm.FacetDescription._notInitializedSentinel;
			}
		}

		// Token: 0x17000BD4 RID: 3028
		// (get) Token: 0x06003C55 RID: 15445 RVA: 0x000C6DE8 File Offset: 0x000C4FE8
		internal global::System.Data.Entity.Core.Metadata.Edm.Facet DefaultValueFacet
		{
			get
			{
				if (this._defaultValueFacet == null)
				{
					global::System.Data.Entity.Core.Metadata.Edm.Facet value = global::System.Data.Entity.Core.Metadata.Edm.Facet.Create(this, this.DefaultValue, true);
					global::System.Threading.Interlocked.CompareExchange<global::System.Data.Entity.Core.Metadata.Edm.Facet>(ref this._defaultValueFacet, value, null);
				}
				return this._defaultValueFacet;
			}
		}

		// Token: 0x17000BD5 RID: 3029
		// (get) Token: 0x06003C56 RID: 15446 RVA: 0x000C6E20 File Offset: 0x000C5020
		internal global::System.Data.Entity.Core.Metadata.Edm.Facet NullValueFacet
		{
			get
			{
				if (this._nullValueFacet == null)
				{
					global::System.Data.Entity.Core.Metadata.Edm.Facet value = global::System.Data.Entity.Core.Metadata.Edm.Facet.Create(this, null, true);
					global::System.Threading.Interlocked.CompareExchange<global::System.Data.Entity.Core.Metadata.Edm.Facet>(ref this._nullValueFacet, value, null);
				}
				return this._nullValueFacet;
			}
		}

		// Token: 0x06003C57 RID: 15447 RVA: 0x000C6E52 File Offset: 0x000C5052
		public override string ToString()
		{
			return this.FacetName;
		}

		// Token: 0x06003C58 RID: 15448 RVA: 0x000C6E5C File Offset: 0x000C505C
		internal global::System.Data.Entity.Core.Metadata.Edm.Facet GetBooleanFacet(bool value)
		{
			if (this._valueCache == null)
			{
				global::System.Threading.Interlocked.CompareExchange<global::System.Data.Entity.Core.Metadata.Edm.Facet[]>(ref this._valueCache, new global::System.Data.Entity.Core.Metadata.Edm.Facet[]
				{
					global::System.Data.Entity.Core.Metadata.Edm.Facet.Create(this, true, true),
					global::System.Data.Entity.Core.Metadata.Edm.Facet.Create(this, false, true)
				}, null);
			}
			if (!value)
			{
				return this._valueCache[1];
			}
			return this._valueCache[0];
		}

		// Token: 0x06003C59 RID: 15449 RVA: 0x000C6EBC File Offset: 0x000C50BC
		internal static bool IsNumericType(global::System.Data.Entity.Core.Metadata.Edm.EdmType facetType)
		{
			if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsPrimitiveType(facetType))
			{
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType primitiveType = (global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType)facetType;
				return primitiveType.PrimitiveTypeKind == global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Byte || primitiveType.PrimitiveTypeKind == global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.SByte || primitiveType.PrimitiveTypeKind == global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int16 || primitiveType.PrimitiveTypeKind == global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int32;
			}
			return false;
		}

		// Token: 0x06003C5A RID: 15450 RVA: 0x000C6F04 File Offset: 0x000C5104
		private static void UpdateMinMaxValueForConstant(string facetName, global::System.Data.Entity.Core.Metadata.Edm.EdmType facetType, ref int? minValue, ref int? maxValue, object defaultValue)
		{
			if (global::System.Data.Entity.Core.Metadata.Edm.FacetDescription.IsNumericType(facetType))
			{
				if (facetName == "Precision" || facetName == "Scale")
				{
					byte? b = (byte?)defaultValue;
					minValue = ((b != null) ? new int?((int)b.GetValueOrDefault()) : null);
					b = (byte?)defaultValue;
					maxValue = ((b != null) ? new int?((int)b.GetValueOrDefault()) : null);
					return;
				}
				minValue = (int?)defaultValue;
				maxValue = (int?)defaultValue;
			}
		}

		// Token: 0x06003C5B RID: 15451 RVA: 0x000C6FB0 File Offset: 0x000C51B0
		private void Validate(string declaringTypeName)
		{
			if (this._defaultValue == global::System.Data.Entity.Core.Metadata.Edm.FacetDescription._notInitializedSentinel)
			{
				if (this._isConstant)
				{
					throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.MissingDefaultValueForConstantFacet(this._facetName, declaringTypeName));
				}
			}
			else if (global::System.Data.Entity.Core.Metadata.Edm.FacetDescription.IsNumericType(this._facetType))
			{
				if (this._isConstant)
				{
					if (this._minValue != null != (this._maxValue != null) || (this._minValue != null && this._minValue.Value != this._maxValue.Value))
					{
						throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.MinAndMaxValueMustBeSameForConstantFacet(this._facetName, declaringTypeName));
					}
				}
				else
				{
					if (this._minValue == null || this._maxValue == null)
					{
						throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.BothMinAndMaxValueMustBeSpecifiedForNonConstantFacet(this._facetName, declaringTypeName));
					}
					int value = this._minValue.Value;
					int? num = this._maxValue;
					if (value == num.GetValueOrDefault() & num != null)
					{
						throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.MinAndMaxValueMustBeDifferentForNonConstantFacet(this._facetName, declaringTypeName));
					}
					num = this._minValue;
					int num2 = 0;
					if (!(num.GetValueOrDefault() < num2 & num != null))
					{
						num = this._maxValue;
						num2 = 0;
						if (!(num.GetValueOrDefault() < num2 & num != null))
						{
							num = this._minValue;
							int? maxValue = this._maxValue;
							if (num.GetValueOrDefault() > maxValue.GetValueOrDefault() & (num != null & maxValue != null))
							{
								throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.MinMustBeLessThanMax(this._minValue.ToString(), this._facetName, declaringTypeName));
							}
							return;
						}
					}
					throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.MinAndMaxMustBePositive(this._facetName, declaringTypeName));
				}
			}
		}

		// Token: 0x040014B9 RID: 5305
		private readonly string _facetName;

		// Token: 0x040014BA RID: 5306
		private readonly global::System.Data.Entity.Core.Metadata.Edm.EdmType _facetType;

		// Token: 0x040014BB RID: 5307
		private readonly int? _minValue;

		// Token: 0x040014BC RID: 5308
		private readonly int? _maxValue;

		// Token: 0x040014BD RID: 5309
		private readonly object _defaultValue;

		// Token: 0x040014BE RID: 5310
		private readonly bool _isConstant;

		// Token: 0x040014BF RID: 5311
		private global::System.Data.Entity.Core.Metadata.Edm.Facet _defaultValueFacet;

		// Token: 0x040014C0 RID: 5312
		private global::System.Data.Entity.Core.Metadata.Edm.Facet _nullValueFacet;

		// Token: 0x040014C1 RID: 5313
		private global::System.Data.Entity.Core.Metadata.Edm.Facet[] _valueCache;

		// Token: 0x040014C2 RID: 5314
		private static readonly object _notInitializedSentinel = new object();
	}
}
