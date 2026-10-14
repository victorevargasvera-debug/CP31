using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Metadata.Edm.Provider;

namespace System.Data.Entity.Core.Common.Internal
{
	// Token: 0x02000631 RID: 1585
	internal static class DbTypeMap
	{
		// Token: 0x06004C6B RID: 19563 RVA: 0x0010C150 File Offset: 0x0010A350
		internal static bool TryGetModelTypeUsage(global::System.Data.DbType dbType, out global::System.Data.Entity.Core.Metadata.Edm.TypeUsage modelType)
		{
			switch (dbType)
			{
			case global::System.Data.DbType.AnsiString:
				modelType = global::System.Data.Entity.Core.Common.Internal.DbTypeMap.AnsiString;
				goto IL_161;
			case global::System.Data.DbType.Binary:
				modelType = global::System.Data.Entity.Core.Common.Internal.DbTypeMap.Binary;
				goto IL_161;
			case global::System.Data.DbType.Byte:
				modelType = global::System.Data.Entity.Core.Common.Internal.DbTypeMap.Byte;
				goto IL_161;
			case global::System.Data.DbType.Boolean:
				modelType = global::System.Data.Entity.Core.Common.Internal.DbTypeMap.Boolean;
				goto IL_161;
			case global::System.Data.DbType.Currency:
				modelType = global::System.Data.Entity.Core.Common.Internal.DbTypeMap.Currency;
				goto IL_161;
			case global::System.Data.DbType.Date:
				modelType = global::System.Data.Entity.Core.Common.Internal.DbTypeMap.Date;
				goto IL_161;
			case global::System.Data.DbType.DateTime:
				modelType = global::System.Data.Entity.Core.Common.Internal.DbTypeMap.DateTime;
				goto IL_161;
			case global::System.Data.DbType.Decimal:
				modelType = global::System.Data.Entity.Core.Common.Internal.DbTypeMap.Decimal;
				goto IL_161;
			case global::System.Data.DbType.Double:
				modelType = global::System.Data.Entity.Core.Common.Internal.DbTypeMap.Double;
				goto IL_161;
			case global::System.Data.DbType.Guid:
				modelType = global::System.Data.Entity.Core.Common.Internal.DbTypeMap.Guid;
				goto IL_161;
			case global::System.Data.DbType.Int16:
				modelType = global::System.Data.Entity.Core.Common.Internal.DbTypeMap.Int16;
				goto IL_161;
			case global::System.Data.DbType.Int32:
				modelType = global::System.Data.Entity.Core.Common.Internal.DbTypeMap.Int32;
				goto IL_161;
			case global::System.Data.DbType.Int64:
				modelType = global::System.Data.Entity.Core.Common.Internal.DbTypeMap.Int64;
				goto IL_161;
			case global::System.Data.DbType.SByte:
				modelType = global::System.Data.Entity.Core.Common.Internal.DbTypeMap.SByte;
				goto IL_161;
			case global::System.Data.DbType.Single:
				modelType = global::System.Data.Entity.Core.Common.Internal.DbTypeMap.Single;
				goto IL_161;
			case global::System.Data.DbType.String:
				modelType = global::System.Data.Entity.Core.Common.Internal.DbTypeMap.String;
				goto IL_161;
			case global::System.Data.DbType.Time:
				modelType = global::System.Data.Entity.Core.Common.Internal.DbTypeMap.Time;
				goto IL_161;
			case global::System.Data.DbType.VarNumeric:
				modelType = null;
				goto IL_161;
			case global::System.Data.DbType.AnsiStringFixedLength:
				modelType = global::System.Data.Entity.Core.Common.Internal.DbTypeMap.AnsiStringFixedLength;
				goto IL_161;
			case global::System.Data.DbType.StringFixedLength:
				modelType = global::System.Data.Entity.Core.Common.Internal.DbTypeMap.StringFixedLength;
				goto IL_161;
			case global::System.Data.DbType.Xml:
				modelType = global::System.Data.Entity.Core.Common.Internal.DbTypeMap.Xml;
				goto IL_161;
			case global::System.Data.DbType.DateTime2:
				modelType = global::System.Data.Entity.Core.Common.Internal.DbTypeMap.DateTime2;
				goto IL_161;
			case global::System.Data.DbType.DateTimeOffset:
				modelType = global::System.Data.Entity.Core.Common.Internal.DbTypeMap.DateTimeOffset;
				goto IL_161;
			}
			modelType = null;
			IL_161:
			return modelType != null;
		}

		// Token: 0x06004C6C RID: 19564 RVA: 0x0010C2C3 File Offset: 0x0010A4C3
		private static global::System.Data.Entity.Core.Metadata.Edm.TypeUsage CreateType(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind type)
		{
			return global::System.Data.Entity.Core.Common.Internal.DbTypeMap.CreateType(type, new global::System.Data.Entity.Core.Metadata.Edm.FacetValues());
		}

		// Token: 0x06004C6D RID: 19565 RVA: 0x0010C2D0 File Offset: 0x0010A4D0
		private static global::System.Data.Entity.Core.Metadata.Edm.TypeUsage CreateType(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind type, global::System.Data.Entity.Core.Metadata.Edm.FacetValues facets)
		{
			return global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifest.Instance.GetPrimitiveType(type), facets);
		}

		// Token: 0x04001AC0 RID: 6848
		internal static readonly global::System.Data.Entity.Core.Metadata.Edm.TypeUsage AnsiString = global::System.Data.Entity.Core.Common.Internal.DbTypeMap.CreateType(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String, new global::System.Data.Entity.Core.Metadata.Edm.FacetValues
		{
			Unicode = new bool?(false),
			FixedLength = new bool?(false),
			MaxLength = null
		});

		// Token: 0x04001AC1 RID: 6849
		internal static readonly global::System.Data.Entity.Core.Metadata.Edm.TypeUsage AnsiStringFixedLength = global::System.Data.Entity.Core.Common.Internal.DbTypeMap.CreateType(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String, new global::System.Data.Entity.Core.Metadata.Edm.FacetValues
		{
			Unicode = new bool?(false),
			FixedLength = new bool?(true),
			MaxLength = null
		});

		// Token: 0x04001AC2 RID: 6850
		internal static readonly global::System.Data.Entity.Core.Metadata.Edm.TypeUsage String = global::System.Data.Entity.Core.Common.Internal.DbTypeMap.CreateType(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String, new global::System.Data.Entity.Core.Metadata.Edm.FacetValues
		{
			Unicode = new bool?(true),
			FixedLength = new bool?(false),
			MaxLength = null
		});

		// Token: 0x04001AC3 RID: 6851
		internal static readonly global::System.Data.Entity.Core.Metadata.Edm.TypeUsage StringFixedLength = global::System.Data.Entity.Core.Common.Internal.DbTypeMap.CreateType(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String, new global::System.Data.Entity.Core.Metadata.Edm.FacetValues
		{
			Unicode = new bool?(true),
			FixedLength = new bool?(true),
			MaxLength = null
		});

		// Token: 0x04001AC4 RID: 6852
		internal static readonly global::System.Data.Entity.Core.Metadata.Edm.TypeUsage Xml = global::System.Data.Entity.Core.Common.Internal.DbTypeMap.CreateType(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String, new global::System.Data.Entity.Core.Metadata.Edm.FacetValues
		{
			Unicode = new bool?(true),
			FixedLength = new bool?(false),
			MaxLength = null
		});

		// Token: 0x04001AC5 RID: 6853
		internal static readonly global::System.Data.Entity.Core.Metadata.Edm.TypeUsage Binary = global::System.Data.Entity.Core.Common.Internal.DbTypeMap.CreateType(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Binary, new global::System.Data.Entity.Core.Metadata.Edm.FacetValues
		{
			MaxLength = null
		});

		// Token: 0x04001AC6 RID: 6854
		internal static readonly global::System.Data.Entity.Core.Metadata.Edm.TypeUsage Boolean = global::System.Data.Entity.Core.Common.Internal.DbTypeMap.CreateType(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Boolean);

		// Token: 0x04001AC7 RID: 6855
		internal static readonly global::System.Data.Entity.Core.Metadata.Edm.TypeUsage Byte = global::System.Data.Entity.Core.Common.Internal.DbTypeMap.CreateType(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Byte);

		// Token: 0x04001AC8 RID: 6856
		internal static readonly global::System.Data.Entity.Core.Metadata.Edm.TypeUsage DateTime = global::System.Data.Entity.Core.Common.Internal.DbTypeMap.CreateType(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.DateTime);

		// Token: 0x04001AC9 RID: 6857
		internal static readonly global::System.Data.Entity.Core.Metadata.Edm.TypeUsage Date = global::System.Data.Entity.Core.Common.Internal.DbTypeMap.CreateType(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.DateTime);

		// Token: 0x04001ACA RID: 6858
		internal static readonly global::System.Data.Entity.Core.Metadata.Edm.TypeUsage DateTime2 = global::System.Data.Entity.Core.Common.Internal.DbTypeMap.CreateType(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.DateTime, new global::System.Data.Entity.Core.Metadata.Edm.FacetValues
		{
			Precision = null
		});

		// Token: 0x04001ACB RID: 6859
		internal static readonly global::System.Data.Entity.Core.Metadata.Edm.TypeUsage Time = global::System.Data.Entity.Core.Common.Internal.DbTypeMap.CreateType(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Time, new global::System.Data.Entity.Core.Metadata.Edm.FacetValues
		{
			Precision = null
		});

		// Token: 0x04001ACC RID: 6860
		internal static readonly global::System.Data.Entity.Core.Metadata.Edm.TypeUsage DateTimeOffset = global::System.Data.Entity.Core.Common.Internal.DbTypeMap.CreateType(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.DateTimeOffset, new global::System.Data.Entity.Core.Metadata.Edm.FacetValues
		{
			Precision = null
		});

		// Token: 0x04001ACD RID: 6861
		internal static readonly global::System.Data.Entity.Core.Metadata.Edm.TypeUsage Decimal = global::System.Data.Entity.Core.Common.Internal.DbTypeMap.CreateType(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Decimal, new global::System.Data.Entity.Core.Metadata.Edm.FacetValues
		{
			Precision = null,
			Scale = null
		});

		// Token: 0x04001ACE RID: 6862
		internal static readonly global::System.Data.Entity.Core.Metadata.Edm.TypeUsage Currency = global::System.Data.Entity.Core.Common.Internal.DbTypeMap.CreateType(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Decimal, new global::System.Data.Entity.Core.Metadata.Edm.FacetValues
		{
			Precision = null,
			Scale = null
		});

		// Token: 0x04001ACF RID: 6863
		internal static readonly global::System.Data.Entity.Core.Metadata.Edm.TypeUsage Double = global::System.Data.Entity.Core.Common.Internal.DbTypeMap.CreateType(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Double);

		// Token: 0x04001AD0 RID: 6864
		internal static readonly global::System.Data.Entity.Core.Metadata.Edm.TypeUsage Guid = global::System.Data.Entity.Core.Common.Internal.DbTypeMap.CreateType(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Guid);

		// Token: 0x04001AD1 RID: 6865
		internal static readonly global::System.Data.Entity.Core.Metadata.Edm.TypeUsage Int16 = global::System.Data.Entity.Core.Common.Internal.DbTypeMap.CreateType(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int16);

		// Token: 0x04001AD2 RID: 6866
		internal static readonly global::System.Data.Entity.Core.Metadata.Edm.TypeUsage Int32 = global::System.Data.Entity.Core.Common.Internal.DbTypeMap.CreateType(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int32);

		// Token: 0x04001AD3 RID: 6867
		internal static readonly global::System.Data.Entity.Core.Metadata.Edm.TypeUsage Int64 = global::System.Data.Entity.Core.Common.Internal.DbTypeMap.CreateType(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int64);

		// Token: 0x04001AD4 RID: 6868
		internal static readonly global::System.Data.Entity.Core.Metadata.Edm.TypeUsage Single = global::System.Data.Entity.Core.Common.Internal.DbTypeMap.CreateType(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Single);

		// Token: 0x04001AD5 RID: 6869
		internal static readonly global::System.Data.Entity.Core.Metadata.Edm.TypeUsage SByte = global::System.Data.Entity.Core.Common.Internal.DbTypeMap.CreateType(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.SByte);
	}
}
