using System;
using System.Collections.ObjectModel;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Hierarchy;
using System.Data.Entity.Spatial;
using System.Data.Entity.Utilities;
using System.Linq;
using System.Threading;
using System.Xml;

namespace System.Data.Entity.Core.Metadata.Edm.Provider
{
	// Token: 0x02000519 RID: 1305
	internal class ClrProviderManifest : global::System.Data.Entity.Core.Common.DbProviderManifest
	{
		// Token: 0x0600405F RID: 16479 RVA: 0x000D672F File Offset: 0x000D492F
		private ClrProviderManifest()
		{
		}

		// Token: 0x17000C97 RID: 3223
		// (get) Token: 0x06004060 RID: 16480 RVA: 0x000D6737 File Offset: 0x000D4937
		internal static global::System.Data.Entity.Core.Metadata.Edm.Provider.ClrProviderManifest Instance
		{
			get
			{
				return global::System.Data.Entity.Core.Metadata.Edm.Provider.ClrProviderManifest._instance;
			}
		}

		// Token: 0x17000C98 RID: 3224
		// (get) Token: 0x06004061 RID: 16481 RVA: 0x000D673E File Offset: 0x000D493E
		public override string NamespaceName
		{
			get
			{
				return "System";
			}
		}

		// Token: 0x06004062 RID: 16482 RVA: 0x000D6748 File Offset: 0x000D4948
		internal bool TryGetPrimitiveType(global::System.Type clrType, out global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType primitiveType)
		{
			primitiveType = null;
			global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind index;
			if (global::System.Data.Entity.Core.Metadata.Edm.Provider.ClrProviderManifest.TryGetPrimitiveTypeKind(clrType, out index))
			{
				this.InitializePrimitiveTypes();
				primitiveType = this._primitiveTypesArray[(int)index];
				return true;
			}
			return false;
		}

		// Token: 0x06004063 RID: 16483 RVA: 0x000D677C File Offset: 0x000D497C
		internal static bool TryGetPrimitiveTypeKind(global::System.Type clrType, out global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind resolvedPrimitiveTypeKind)
		{
			global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind? primitiveTypeKind = null;
			if (!clrType.IsEnum())
			{
				switch (global::System.Type.GetTypeCode(clrType))
				{
				case global::System.TypeCode.Object:
					if (typeof(byte[]) == clrType)
					{
						primitiveTypeKind = new global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind?(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Binary);
					}
					else if (typeof(global::System.DateTimeOffset) == clrType)
					{
						primitiveTypeKind = new global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind?(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.DateTimeOffset);
					}
					else if (typeof(global::System.Data.Entity.Spatial.DbGeography).IsAssignableFrom(clrType))
					{
						primitiveTypeKind = new global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind?(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Geography);
					}
					else if (typeof(global::System.Data.Entity.Spatial.DbGeometry).IsAssignableFrom(clrType))
					{
						primitiveTypeKind = new global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind?(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Geometry);
					}
					else if (typeof(global::System.Guid) == clrType)
					{
						primitiveTypeKind = new global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind?(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Guid);
					}
					else if (typeof(global::System.Data.Entity.Hierarchy.HierarchyId) == clrType)
					{
						primitiveTypeKind = new global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind?(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.HierarchyId);
					}
					else if (typeof(global::System.TimeSpan) == clrType)
					{
						primitiveTypeKind = new global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind?(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Time);
					}
					break;
				case global::System.TypeCode.Boolean:
					primitiveTypeKind = new global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind?(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Boolean);
					break;
				case global::System.TypeCode.SByte:
					primitiveTypeKind = new global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind?(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.SByte);
					break;
				case global::System.TypeCode.Byte:
					primitiveTypeKind = new global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind?(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Byte);
					break;
				case global::System.TypeCode.Int16:
					primitiveTypeKind = new global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind?(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int16);
					break;
				case global::System.TypeCode.Int32:
					primitiveTypeKind = new global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind?(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int32);
					break;
				case global::System.TypeCode.Int64:
					primitiveTypeKind = new global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind?(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int64);
					break;
				case global::System.TypeCode.Single:
					primitiveTypeKind = new global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind?(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Single);
					break;
				case global::System.TypeCode.Double:
					primitiveTypeKind = new global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind?(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Double);
					break;
				case global::System.TypeCode.Decimal:
					primitiveTypeKind = new global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind?(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Decimal);
					break;
				case global::System.TypeCode.DateTime:
					primitiveTypeKind = new global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind?(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.DateTime);
					break;
				case global::System.TypeCode.String:
					primitiveTypeKind = new global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind?(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String);
					break;
				}
			}
			if (primitiveTypeKind != null)
			{
				resolvedPrimitiveTypeKind = primitiveTypeKind.Value;
				return true;
			}
			resolvedPrimitiveTypeKind = global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Binary;
			return false;
		}

		// Token: 0x06004064 RID: 16484 RVA: 0x000D6970 File Offset: 0x000D4B70
		public override global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction> GetStoreFunctions()
		{
			return global::System.Data.Entity.Core.Metadata.Edm.Helper.EmptyEdmFunctionReadOnlyCollection;
		}

		// Token: 0x06004065 RID: 16485 RVA: 0x000D6978 File Offset: 0x000D4B78
		public override global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.FacetDescription> GetFacetDescriptions(global::System.Data.Entity.Core.Metadata.Edm.EdmType type)
		{
			if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsPrimitiveType(type) && type.DataSpace == global::System.Data.Entity.Core.Metadata.Edm.DataSpace.OSpace)
			{
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType primitiveType = (global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType)type.BaseType;
				return primitiveType.ProviderManifest.GetFacetDescriptions(primitiveType);
			}
			return global::System.Data.Entity.Core.Metadata.Edm.Helper.EmptyFacetDescriptionEnumerable;
		}

		// Token: 0x06004066 RID: 16486 RVA: 0x000D69B4 File Offset: 0x000D4BB4
		private void InitializePrimitiveTypes()
		{
			if (this._primitiveTypes != null)
			{
				return;
			}
			global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType[] array = new global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType[32];
			array[0] = this.CreatePrimitiveType(typeof(byte[]), global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Binary);
			array[1] = this.CreatePrimitiveType(typeof(bool), global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Boolean);
			array[2] = this.CreatePrimitiveType(typeof(byte), global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Byte);
			array[3] = this.CreatePrimitiveType(typeof(global::System.DateTime), global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.DateTime);
			array[13] = this.CreatePrimitiveType(typeof(global::System.TimeSpan), global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Time);
			array[14] = this.CreatePrimitiveType(typeof(global::System.DateTimeOffset), global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.DateTimeOffset);
			array[4] = this.CreatePrimitiveType(typeof(decimal), global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Decimal);
			array[5] = this.CreatePrimitiveType(typeof(double), global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Double);
			array[16] = this.CreatePrimitiveType(typeof(global::System.Data.Entity.Spatial.DbGeography), global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Geography);
			array[15] = this.CreatePrimitiveType(typeof(global::System.Data.Entity.Spatial.DbGeometry), global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Geometry);
			array[6] = this.CreatePrimitiveType(typeof(global::System.Guid), global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Guid);
			array[31] = this.CreatePrimitiveType(typeof(global::System.Data.Entity.Hierarchy.HierarchyId), global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.HierarchyId);
			array[9] = this.CreatePrimitiveType(typeof(short), global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int16);
			array[10] = this.CreatePrimitiveType(typeof(int), global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int32);
			array[11] = this.CreatePrimitiveType(typeof(long), global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int64);
			array[8] = this.CreatePrimitiveType(typeof(sbyte), global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.SByte);
			array[7] = this.CreatePrimitiveType(typeof(float), global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Single);
			array[12] = this.CreatePrimitiveType(typeof(string), global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String);
			global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType> value = new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType>(array);
			global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType> value2 = new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType>((from t in array
			where t != null
			select t).ToList<global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType>());
			global::System.Threading.Interlocked.CompareExchange<global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType>>(ref this._primitiveTypesArray, value, null);
			global::System.Threading.Interlocked.CompareExchange<global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType>>(ref this._primitiveTypes, value2, null);
		}

		// Token: 0x06004067 RID: 16487 RVA: 0x000D6BA0 File Offset: 0x000D4DA0
		private global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType CreatePrimitiveType(global::System.Type clrType, global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind primitiveTypeKind)
		{
			global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType primitiveType = global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.EdmProviderManifest.GetPrimitiveType(primitiveTypeKind);
			global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType primitiveType2 = new global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType(clrType, primitiveType, this);
			primitiveType2.SetReadOnly();
			return primitiveType2;
		}

		// Token: 0x06004068 RID: 16488 RVA: 0x000D6BC7 File Offset: 0x000D4DC7
		public override global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType> GetStoreTypes()
		{
			this.InitializePrimitiveTypes();
			return this._primitiveTypes;
		}

		// Token: 0x06004069 RID: 16489 RVA: 0x000D6BD5 File Offset: 0x000D4DD5
		public override global::System.Data.Entity.Core.Metadata.Edm.TypeUsage GetEdmType(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage storeType)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(storeType, "storeType");
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600406A RID: 16490 RVA: 0x000D6BE8 File Offset: 0x000D4DE8
		public override global::System.Data.Entity.Core.Metadata.Edm.TypeUsage GetStoreType(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage edmType)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(edmType, "edmType");
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600406B RID: 16491 RVA: 0x000D6BFB File Offset: 0x000D4DFB
		protected override global::System.Xml.XmlReader GetDbInformation(string informationType)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x04001669 RID: 5737
		private const int s_PrimitiveTypeCount = 32;

		// Token: 0x0400166A RID: 5738
		private global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType> _primitiveTypesArray;

		// Token: 0x0400166B RID: 5739
		private global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType> _primitiveTypes;

		// Token: 0x0400166C RID: 5740
		private static readonly global::System.Data.Entity.Core.Metadata.Edm.Provider.ClrProviderManifest _instance = new global::System.Data.Entity.Core.Metadata.Edm.Provider.ClrProviderManifest();
	}
}
