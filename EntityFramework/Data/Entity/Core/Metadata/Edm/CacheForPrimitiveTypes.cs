using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Core.Metadata.Edm.Provider;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x0200048C RID: 1164
	internal class CacheForPrimitiveTypes
	{
		// Token: 0x060039D7 RID: 14807 RVA: 0x000BD648 File Offset: 0x000BB848
		internal void Add(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType type)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType> list = global::System.Data.Entity.Core.EntityUtil.CheckArgumentOutOfRange<global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType>>(this._primitiveTypeMap, (int)type.PrimitiveTypeKind, "primitiveTypeKind");
			if (list == null)
			{
				list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType>();
				list.Add(type);
				this._primitiveTypeMap[(int)type.PrimitiveTypeKind] = list;
				return;
			}
			list.Add(type);
		}

		// Token: 0x060039D8 RID: 14808 RVA: 0x000BD694 File Offset: 0x000BB894
		internal bool TryGetType(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind primitiveTypeKind, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.Facet> facets, out global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType type)
		{
			type = null;
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType> list = global::System.Data.Entity.Core.EntityUtil.CheckArgumentOutOfRange<global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType>>(this._primitiveTypeMap, (int)primitiveTypeKind, "primitiveTypeKind");
			if (list == null || 0 >= list.Count)
			{
				return false;
			}
			if (list.Count == 1)
			{
				type = list[0];
				return true;
			}
			if (facets == null)
			{
				global::System.Data.Entity.Core.Metadata.Edm.FacetDescription[] initialFacetDescriptions = global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifest.GetInitialFacetDescriptions(primitiveTypeKind);
				if (initialFacetDescriptions == null)
				{
					type = list[0];
					return true;
				}
				facets = global::System.Data.Entity.Core.Metadata.Edm.CacheForPrimitiveTypes.CreateInitialFacets(initialFacetDescriptions);
			}
			bool flag = false;
			foreach (global::System.Data.Entity.Core.Metadata.Edm.Facet facet in facets)
			{
				if ((primitiveTypeKind == global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String || primitiveTypeKind == global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Binary) && facet.Value != null && facet.Name == "MaxLength" && global::System.Data.Entity.Core.Metadata.Edm.Helper.IsUnboundedFacetValue(facet))
				{
					flag = true;
				}
			}
			int num = 0;
			foreach (global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType primitiveType in list)
			{
				if (!flag)
				{
					type = primitiveType;
					break;
				}
				if (type == null)
				{
					type = primitiveType;
					num = global::System.Data.Entity.Core.Metadata.Edm.Helper.GetFacet(primitiveType.FacetDescriptions, "MaxLength").MaxValue.Value;
				}
				else
				{
					int value = global::System.Data.Entity.Core.Metadata.Edm.Helper.GetFacet(primitiveType.FacetDescriptions, "MaxLength").MaxValue.Value;
					if (value > num)
					{
						type = primitiveType;
						num = value;
					}
				}
			}
			return true;
		}

		// Token: 0x060039D9 RID: 14809 RVA: 0x000BD808 File Offset: 0x000BBA08
		private static global::System.Data.Entity.Core.Metadata.Edm.Facet[] CreateInitialFacets(global::System.Data.Entity.Core.Metadata.Edm.FacetDescription[] facetDescriptions)
		{
			global::System.Data.Entity.Core.Metadata.Edm.Facet[] array = new global::System.Data.Entity.Core.Metadata.Edm.Facet[facetDescriptions.Length];
			for (int i = 0; i < facetDescriptions.Length; i++)
			{
				string facetName = facetDescriptions[i].FacetName;
				if (facetName != null)
				{
					if (!(facetName == "MaxLength"))
					{
						if (!(facetName == "Unicode"))
						{
							if (!(facetName == "FixedLength"))
							{
								if (!(facetName == "Precision"))
								{
									if (facetName == "Scale")
									{
										array[i] = global::System.Data.Entity.Core.Metadata.Edm.Facet.Create(facetDescriptions[i], global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.DefaultScaleFacetValue);
									}
								}
								else
								{
									array[i] = global::System.Data.Entity.Core.Metadata.Edm.Facet.Create(facetDescriptions[i], global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.DefaultPrecisionFacetValue);
								}
							}
							else
							{
								array[i] = global::System.Data.Entity.Core.Metadata.Edm.Facet.Create(facetDescriptions[i], false);
							}
						}
						else
						{
							array[i] = global::System.Data.Entity.Core.Metadata.Edm.Facet.Create(facetDescriptions[i], true);
						}
					}
					else
					{
						array[i] = global::System.Data.Entity.Core.Metadata.Edm.Facet.Create(facetDescriptions[i], global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.DefaultMaxLengthFacetValue);
					}
				}
			}
			return array;
		}

		// Token: 0x060039DA RID: 14810 RVA: 0x000BD8E0 File Offset: 0x000BBAE0
		internal global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType> GetTypes()
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType>();
			foreach (global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType> list2 in this._primitiveTypeMap)
			{
				if (list2 != null)
				{
					list.AddRange(list2);
				}
			}
			return new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType>(list);
		}

		// Token: 0x0400134B RID: 4939
		private readonly global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType>[] _primitiveTypeMap = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType>[32];
	}
}
