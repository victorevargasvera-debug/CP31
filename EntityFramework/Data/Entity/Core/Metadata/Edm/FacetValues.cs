using System;
using System.Collections.Generic;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x020004C4 RID: 1220
	internal class FacetValues
	{
		// Token: 0x17000BD8 RID: 3032
		// (set) Token: 0x06003C63 RID: 15459 RVA: 0x000C71ED File Offset: 0x000C53ED
		internal global::System.Data.Entity.Core.Metadata.Edm.FacetValueContainer<bool?> Nullable
		{
			set
			{
				this._nullable = value;
			}
		}

		// Token: 0x17000BD9 RID: 3033
		// (set) Token: 0x06003C64 RID: 15460 RVA: 0x000C71F6 File Offset: 0x000C53F6
		internal global::System.Data.Entity.Core.Metadata.Edm.FacetValueContainer<int?> MaxLength
		{
			set
			{
				this._maxLength = value;
			}
		}

		// Token: 0x17000BDA RID: 3034
		// (set) Token: 0x06003C65 RID: 15461 RVA: 0x000C71FF File Offset: 0x000C53FF
		internal global::System.Data.Entity.Core.Metadata.Edm.FacetValueContainer<bool?> Unicode
		{
			set
			{
				this._unicode = value;
			}
		}

		// Token: 0x17000BDB RID: 3035
		// (set) Token: 0x06003C66 RID: 15462 RVA: 0x000C7208 File Offset: 0x000C5408
		internal global::System.Data.Entity.Core.Metadata.Edm.FacetValueContainer<bool?> FixedLength
		{
			set
			{
				this._fixedLength = value;
			}
		}

		// Token: 0x17000BDC RID: 3036
		// (set) Token: 0x06003C67 RID: 15463 RVA: 0x000C7211 File Offset: 0x000C5411
		internal global::System.Data.Entity.Core.Metadata.Edm.FacetValueContainer<byte?> Precision
		{
			set
			{
				this._precision = value;
			}
		}

		// Token: 0x17000BDD RID: 3037
		// (set) Token: 0x06003C68 RID: 15464 RVA: 0x000C721A File Offset: 0x000C541A
		internal global::System.Data.Entity.Core.Metadata.Edm.FacetValueContainer<byte?> Scale
		{
			set
			{
				this._scale = value;
			}
		}

		// Token: 0x17000BDE RID: 3038
		// (set) Token: 0x06003C69 RID: 15465 RVA: 0x000C7223 File Offset: 0x000C5423
		internal object DefaultValue
		{
			set
			{
				this._defaultValue = value;
			}
		}

		// Token: 0x17000BDF RID: 3039
		// (set) Token: 0x06003C6A RID: 15466 RVA: 0x000C722C File Offset: 0x000C542C
		internal global::System.Data.Entity.Core.Metadata.Edm.FacetValueContainer<string> Collation
		{
			set
			{
				this._collation = value;
			}
		}

		// Token: 0x17000BE0 RID: 3040
		// (set) Token: 0x06003C6B RID: 15467 RVA: 0x000C7235 File Offset: 0x000C5435
		internal global::System.Data.Entity.Core.Metadata.Edm.FacetValueContainer<int?> Srid
		{
			set
			{
				this._srid = value;
			}
		}

		// Token: 0x17000BE1 RID: 3041
		// (set) Token: 0x06003C6C RID: 15468 RVA: 0x000C723E File Offset: 0x000C543E
		internal global::System.Data.Entity.Core.Metadata.Edm.FacetValueContainer<bool?> IsStrict
		{
			set
			{
				this._isStrict = value;
			}
		}

		// Token: 0x17000BE2 RID: 3042
		// (set) Token: 0x06003C6D RID: 15469 RVA: 0x000C7247 File Offset: 0x000C5447
		internal global::System.Data.Entity.Core.Metadata.Edm.FacetValueContainer<global::System.Data.Entity.Core.Metadata.Edm.StoreGeneratedPattern?> StoreGeneratedPattern
		{
			set
			{
				this._storeGeneratedPattern = value;
			}
		}

		// Token: 0x17000BE3 RID: 3043
		// (set) Token: 0x06003C6E RID: 15470 RVA: 0x000C7250 File Offset: 0x000C5450
		internal global::System.Data.Entity.Core.Metadata.Edm.FacetValueContainer<global::System.Data.Entity.Core.Metadata.Edm.ConcurrencyMode?> ConcurrencyMode
		{
			set
			{
				this._concurrencyMode = value;
			}
		}

		// Token: 0x17000BE4 RID: 3044
		// (set) Token: 0x06003C6F RID: 15471 RVA: 0x000C7259 File Offset: 0x000C5459
		internal global::System.Data.Entity.Core.Metadata.Edm.FacetValueContainer<global::System.Data.Entity.Core.Metadata.Edm.CollectionKind?> CollectionKind
		{
			set
			{
				this._collectionKind = value;
			}
		}

		// Token: 0x06003C70 RID: 15472 RVA: 0x000C7264 File Offset: 0x000C5464
		internal bool TryGetFacet(global::System.Data.Entity.Core.Metadata.Edm.FacetDescription description, out global::System.Data.Entity.Core.Metadata.Edm.Facet facet)
		{
			string facetName = description.FacetName;
			if (facetName != null)
			{
				uint num = global::<PrivateImplementationDetails>.ComputeStringHash(facetName);
				if (num <= 1564768107U)
				{
					if (num <= 1183764407U)
					{
						if (num != 676498961U)
						{
							if (num != 961465920U)
							{
								if (num == 1183764407U)
								{
									if (facetName == "Precision")
									{
										if (this._precision.HasValue)
										{
											facet = global::System.Data.Entity.Core.Metadata.Edm.Facet.Create(description, this._precision.GetValueAsObject());
											return true;
										}
									}
								}
							}
							else if (facetName == "Unicode")
							{
								if (this._unicode.HasValue)
								{
									facet = global::System.Data.Entity.Core.Metadata.Edm.Facet.Create(description, this._unicode.GetValueAsObject());
									return true;
								}
							}
						}
						else if (facetName == "Scale")
						{
							if (this._scale.HasValue)
							{
								facet = global::System.Data.Entity.Core.Metadata.Edm.Facet.Create(description, this._scale.GetValueAsObject());
								return true;
							}
						}
					}
					else if (num != 1447003228U)
					{
						if (num != 1463310029U)
						{
							if (num == 1564768107U)
							{
								if (facetName == "ConcurrencyMode")
								{
									if (this._concurrencyMode.HasValue)
									{
										facet = global::System.Data.Entity.Core.Metadata.Edm.Facet.Create(description, this._concurrencyMode.GetValueAsObject());
										return true;
									}
								}
							}
						}
						else if (facetName == "SRID")
						{
							if (this._srid.HasValue)
							{
								facet = global::System.Data.Entity.Core.Metadata.Edm.Facet.Create(description, this._srid.GetValueAsObject());
								return true;
							}
						}
					}
					else if (facetName == "Nullable")
					{
						if (this._nullable.HasValue)
						{
							facet = global::System.Data.Entity.Core.Metadata.Edm.Facet.Create(description, this._nullable.GetValueAsObject());
							return true;
						}
					}
				}
				else if (num <= 2958518788U)
				{
					if (num != 2638156065U)
					{
						if (num != 2732815151U)
						{
							if (num == 2958518788U)
							{
								if (facetName == "IsStrict")
								{
									if (this._isStrict.HasValue)
									{
										facet = global::System.Data.Entity.Core.Metadata.Edm.Facet.Create(description, this._isStrict.GetValueAsObject());
										return true;
									}
								}
							}
						}
						else if (facetName == "StoreGeneratedPattern")
						{
							if (this._storeGeneratedPattern.HasValue)
							{
								facet = global::System.Data.Entity.Core.Metadata.Edm.Facet.Create(description, this._storeGeneratedPattern.GetValueAsObject());
								return true;
							}
						}
					}
					else if (facetName == "MaxLength")
					{
						if (this._maxLength.HasValue)
						{
							facet = global::System.Data.Entity.Core.Metadata.Edm.Facet.Create(description, this._maxLength.GetValueAsObject());
							return true;
						}
					}
				}
				else if (num <= 3829189484U)
				{
					if (num != 3439935391U)
					{
						if (num == 3829189484U)
						{
							if (facetName == "Collation")
							{
								if (this._collation.HasValue)
								{
									facet = global::System.Data.Entity.Core.Metadata.Edm.Facet.Create(description, this._collation.GetValueAsObject());
									return true;
								}
							}
						}
					}
					else if (facetName == "DefaultValue")
					{
						if (this._defaultValue != null)
						{
							facet = global::System.Data.Entity.Core.Metadata.Edm.Facet.Create(description, this._defaultValue);
							return true;
						}
					}
				}
				else if (num != 4242325569U)
				{
					if (num == 4293581999U)
					{
						if (facetName == "CollectionKind")
						{
							if (this._collectionKind.HasValue)
							{
								facet = global::System.Data.Entity.Core.Metadata.Edm.Facet.Create(description, this._collectionKind.GetValueAsObject());
								return true;
							}
						}
					}
				}
				else if (facetName == "FixedLength")
				{
					if (this._fixedLength.HasValue)
					{
						facet = global::System.Data.Entity.Core.Metadata.Edm.Facet.Create(description, this._fixedLength.GetValueAsObject());
						return true;
					}
				}
			}
			facet = null;
			return false;
		}

		// Token: 0x06003C71 RID: 15473 RVA: 0x000C7628 File Offset: 0x000C5828
		public static global::System.Data.Entity.Core.Metadata.Edm.FacetValues Create(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.Facet> facets)
		{
			global::System.Data.Entity.Core.Metadata.Edm.FacetValues facetValues = new global::System.Data.Entity.Core.Metadata.Edm.FacetValues();
			foreach (global::System.Data.Entity.Core.Metadata.Edm.Facet facet in facets)
			{
				string facetName = facet.Description.FacetName;
				if (facetName != null)
				{
					uint num = global::<PrivateImplementationDetails>.ComputeStringHash(facetName);
					if (num <= 1564768107U)
					{
						if (num <= 1183764407U)
						{
							if (num != 676498961U)
							{
								if (num != 961465920U)
								{
									if (num == 1183764407U)
									{
										if (facetName == "Precision")
										{
											global::System.Data.Entity.Core.Metadata.Edm.EdmConstants.Unbounded unbounded = facet.Value as global::System.Data.Entity.Core.Metadata.Edm.EdmConstants.Unbounded;
											if (unbounded != null)
											{
												facetValues.Precision = unbounded;
											}
											else
											{
												facetValues.Precision = (byte?)facet.Value;
											}
										}
									}
								}
								else if (facetName == "Unicode")
								{
									facetValues.Unicode = (bool?)facet.Value;
								}
							}
							else if (facetName == "Scale")
							{
								global::System.Data.Entity.Core.Metadata.Edm.EdmConstants.Unbounded unbounded2 = facet.Value as global::System.Data.Entity.Core.Metadata.Edm.EdmConstants.Unbounded;
								if (unbounded2 != null)
								{
									facetValues.Scale = unbounded2;
								}
								else
								{
									facetValues.Scale = (byte?)facet.Value;
								}
							}
						}
						else if (num != 1447003228U)
						{
							if (num != 1463310029U)
							{
								if (num == 1564768107U)
								{
									if (facetName == "ConcurrencyMode")
									{
										facetValues.ConcurrencyMode = (global::System.Data.Entity.Core.Metadata.Edm.ConcurrencyMode?)facet.Value;
									}
								}
							}
							else if (facetName == "SRID")
							{
								facetValues.Srid = (int?)facet.Value;
							}
						}
						else if (facetName == "Nullable")
						{
							facetValues.Nullable = (bool?)facet.Value;
						}
					}
					else if (num <= 2958518788U)
					{
						if (num != 2638156065U)
						{
							if (num != 2732815151U)
							{
								if (num == 2958518788U)
								{
									if (facetName == "IsStrict")
									{
										facetValues.IsStrict = (bool?)facet.Value;
									}
								}
							}
							else if (facetName == "StoreGeneratedPattern")
							{
								facetValues.StoreGeneratedPattern = (global::System.Data.Entity.Core.Metadata.Edm.StoreGeneratedPattern?)facet.Value;
							}
						}
						else if (facetName == "MaxLength")
						{
							global::System.Data.Entity.Core.Metadata.Edm.EdmConstants.Unbounded unbounded3 = facet.Value as global::System.Data.Entity.Core.Metadata.Edm.EdmConstants.Unbounded;
							if (unbounded3 != null)
							{
								facetValues.MaxLength = unbounded3;
							}
							else
							{
								facetValues.MaxLength = (int?)facet.Value;
							}
						}
					}
					else if (num <= 3829189484U)
					{
						if (num != 3439935391U)
						{
							if (num == 3829189484U)
							{
								if (facetName == "Collation")
								{
									facetValues.Collation = (string)facet.Value;
								}
							}
						}
						else if (facetName == "DefaultValue")
						{
							facetValues.DefaultValue = facet.Value;
						}
					}
					else if (num != 4242325569U)
					{
						if (num == 4293581999U)
						{
							if (facetName == "CollectionKind")
							{
								facetValues.CollectionKind = (global::System.Data.Entity.Core.Metadata.Edm.CollectionKind?)facet.Value;
							}
						}
					}
					else if (facetName == "FixedLength")
					{
						facetValues.FixedLength = (bool?)facet.Value;
					}
				}
			}
			return facetValues;
		}

		// Token: 0x17000BE5 RID: 3045
		// (get) Token: 0x06003C72 RID: 15474 RVA: 0x000C7A38 File Offset: 0x000C5C38
		internal static global::System.Data.Entity.Core.Metadata.Edm.FacetValues NullFacetValues
		{
			get
			{
				return new global::System.Data.Entity.Core.Metadata.Edm.FacetValues
				{
					FixedLength = null,
					MaxLength = null,
					Precision = null,
					Scale = null,
					Unicode = null,
					Collation = null,
					Srid = null,
					IsStrict = null,
					ConcurrencyMode = null,
					StoreGeneratedPattern = null,
					CollectionKind = null
				};
			}
		}

		// Token: 0x040014C6 RID: 5318
		private global::System.Data.Entity.Core.Metadata.Edm.FacetValueContainer<bool?> _nullable;

		// Token: 0x040014C7 RID: 5319
		private global::System.Data.Entity.Core.Metadata.Edm.FacetValueContainer<int?> _maxLength;

		// Token: 0x040014C8 RID: 5320
		private global::System.Data.Entity.Core.Metadata.Edm.FacetValueContainer<bool?> _unicode;

		// Token: 0x040014C9 RID: 5321
		private global::System.Data.Entity.Core.Metadata.Edm.FacetValueContainer<bool?> _fixedLength;

		// Token: 0x040014CA RID: 5322
		private global::System.Data.Entity.Core.Metadata.Edm.FacetValueContainer<byte?> _precision;

		// Token: 0x040014CB RID: 5323
		private global::System.Data.Entity.Core.Metadata.Edm.FacetValueContainer<byte?> _scale;

		// Token: 0x040014CC RID: 5324
		private object _defaultValue;

		// Token: 0x040014CD RID: 5325
		private global::System.Data.Entity.Core.Metadata.Edm.FacetValueContainer<string> _collation;

		// Token: 0x040014CE RID: 5326
		private global::System.Data.Entity.Core.Metadata.Edm.FacetValueContainer<int?> _srid;

		// Token: 0x040014CF RID: 5327
		private global::System.Data.Entity.Core.Metadata.Edm.FacetValueContainer<bool?> _isStrict;

		// Token: 0x040014D0 RID: 5328
		private global::System.Data.Entity.Core.Metadata.Edm.FacetValueContainer<global::System.Data.Entity.Core.Metadata.Edm.StoreGeneratedPattern?> _storeGeneratedPattern;

		// Token: 0x040014D1 RID: 5329
		private global::System.Data.Entity.Core.Metadata.Edm.FacetValueContainer<global::System.Data.Entity.Core.Metadata.Edm.ConcurrencyMode?> _concurrencyMode;

		// Token: 0x040014D2 RID: 5330
		private global::System.Data.Entity.Core.Metadata.Edm.FacetValueContainer<global::System.Data.Entity.Core.Metadata.Edm.CollectionKind?> _collectionKind;
	}
}
