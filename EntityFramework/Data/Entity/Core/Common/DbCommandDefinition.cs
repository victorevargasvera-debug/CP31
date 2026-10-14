using System;
using System.Data.Common;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Core.Common
{
	// Token: 0x020005EA RID: 1514
	public class DbCommandDefinition
	{
		// Token: 0x06004A08 RID: 18952 RVA: 0x00105BB1 File Offset: 0x00103DB1
		protected internal DbCommandDefinition(global::System.Data.Common.DbCommand prototype, global::System.Func<global::System.Data.Common.DbCommand, global::System.Data.Common.DbCommand> cloneMethod)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Common.DbCommand>(prototype, "prototype");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Func<global::System.Data.Common.DbCommand, global::System.Data.Common.DbCommand>>(cloneMethod, "cloneMethod");
			this._prototype = prototype;
			this._cloneMethod = cloneMethod;
		}

		// Token: 0x06004A09 RID: 18953 RVA: 0x00105BDF File Offset: 0x00103DDF
		protected DbCommandDefinition()
		{
		}

		// Token: 0x06004A0A RID: 18954 RVA: 0x00105BE7 File Offset: 0x00103DE7
		public virtual global::System.Data.Common.DbCommand CreateCommand()
		{
			return this._cloneMethod(this._prototype);
		}

		// Token: 0x06004A0B RID: 18955 RVA: 0x00105BFC File Offset: 0x00103DFC
		internal static void PopulateParameterFromTypeUsage(global::System.Data.Common.DbParameter parameter, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type, bool isOutParam)
		{
			parameter.IsNullable = global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsNullable(type);
			global::System.Data.DbType dbType;
			if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsPrimitiveType(type.EdmType) && global::System.Data.Entity.Core.Common.DbCommandDefinition.TryGetDbTypeFromPrimitiveType((global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType)type.EdmType, out dbType))
			{
				if (dbType <= global::System.Data.DbType.Decimal)
				{
					if (dbType == global::System.Data.DbType.Binary)
					{
						global::System.Data.Entity.Core.Common.DbCommandDefinition.PopulateBinaryParameter(parameter, type, dbType, isOutParam);
						return;
					}
					if (dbType != global::System.Data.DbType.DateTime)
					{
						if (dbType != global::System.Data.DbType.Decimal)
						{
							goto IL_75;
						}
						global::System.Data.Entity.Core.Common.DbCommandDefinition.PopulateDecimalParameter(parameter, type, dbType);
						return;
					}
				}
				else
				{
					if (dbType == global::System.Data.DbType.String)
					{
						global::System.Data.Entity.Core.Common.DbCommandDefinition.PopulateStringParameter(parameter, type, isOutParam);
						return;
					}
					if (dbType != global::System.Data.DbType.Time && dbType != global::System.Data.DbType.DateTimeOffset)
					{
						goto IL_75;
					}
				}
				global::System.Data.Entity.Core.Common.DbCommandDefinition.PopulateDateTimeParameter(parameter, type, dbType);
				return;
				IL_75:
				parameter.DbType = dbType;
			}
		}

		// Token: 0x06004A0C RID: 18956 RVA: 0x00105C88 File Offset: 0x00103E88
		internal static bool TryGetDbTypeFromPrimitiveType(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType type, out global::System.Data.DbType dbType)
		{
			switch (type.PrimitiveTypeKind)
			{
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Binary:
				dbType = global::System.Data.DbType.Binary;
				return true;
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Boolean:
				dbType = global::System.Data.DbType.Boolean;
				return true;
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Byte:
				dbType = global::System.Data.DbType.Byte;
				return true;
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.DateTime:
				dbType = global::System.Data.DbType.DateTime;
				return true;
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Decimal:
				dbType = global::System.Data.DbType.Decimal;
				return true;
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Double:
				dbType = global::System.Data.DbType.Double;
				return true;
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Guid:
				dbType = global::System.Data.DbType.Guid;
				return true;
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Single:
				dbType = global::System.Data.DbType.Single;
				return true;
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.SByte:
				dbType = global::System.Data.DbType.SByte;
				return true;
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int16:
				dbType = global::System.Data.DbType.Int16;
				return true;
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int32:
				dbType = global::System.Data.DbType.Int32;
				return true;
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int64:
				dbType = global::System.Data.DbType.Int64;
				return true;
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String:
				dbType = global::System.Data.DbType.String;
				return true;
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Time:
				dbType = global::System.Data.DbType.Time;
				return true;
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.DateTimeOffset:
				dbType = global::System.Data.DbType.DateTimeOffset;
				return true;
			default:
				dbType = global::System.Data.DbType.AnsiString;
				return false;
			}
		}

		// Token: 0x06004A0D RID: 18957 RVA: 0x00105D38 File Offset: 0x00103F38
		private static void PopulateBinaryParameter(global::System.Data.Common.DbParameter parameter, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type, global::System.Data.DbType dbType, bool isOutParam)
		{
			parameter.DbType = dbType;
			global::System.Data.Entity.Core.Common.DbCommandDefinition.SetParameterSize(parameter, type, isOutParam);
		}

		// Token: 0x06004A0E RID: 18958 RVA: 0x00105D4C File Offset: 0x00103F4C
		private static void PopulateDecimalParameter(global::System.Data.Common.DbParameter parameter, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type, global::System.Data.DbType dbType)
		{
			parameter.DbType = dbType;
			byte precision;
			if (global::System.Data.Entity.Core.Common.TypeHelpers.TryGetPrecision(type, out precision))
			{
				((global::System.Data.IDbDataParameter)parameter).Precision = precision;
			}
			byte scale;
			if (global::System.Data.Entity.Core.Common.TypeHelpers.TryGetScale(type, out scale))
			{
				((global::System.Data.IDbDataParameter)parameter).Scale = scale;
			}
		}

		// Token: 0x06004A0F RID: 18959 RVA: 0x00105D84 File Offset: 0x00103F84
		private static void PopulateDateTimeParameter(global::System.Data.Common.DbParameter parameter, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type, global::System.Data.DbType dbType)
		{
			parameter.DbType = dbType;
			byte precision;
			if (global::System.Data.Entity.Core.Common.TypeHelpers.TryGetPrecision(type, out precision))
			{
				((global::System.Data.IDbDataParameter)parameter).Precision = precision;
			}
		}

		// Token: 0x06004A10 RID: 18960 RVA: 0x00105DAC File Offset: 0x00103FAC
		private static void PopulateStringParameter(global::System.Data.Common.DbParameter parameter, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type, bool isOutParam)
		{
			bool flag = true;
			bool flag2 = false;
			if (!global::System.Data.Entity.Core.Common.TypeHelpers.TryGetIsFixedLength(type, out flag2))
			{
				flag2 = false;
			}
			if (!global::System.Data.Entity.Core.Common.TypeHelpers.TryGetIsUnicode(type, out flag))
			{
				flag = true;
			}
			if (flag2)
			{
				parameter.DbType = (flag ? global::System.Data.DbType.StringFixedLength : global::System.Data.DbType.AnsiStringFixedLength);
			}
			else
			{
				parameter.DbType = (flag ? global::System.Data.DbType.String : global::System.Data.DbType.AnsiString);
			}
			global::System.Data.Entity.Core.Common.DbCommandDefinition.SetParameterSize(parameter, type, isOutParam);
		}

		// Token: 0x06004A11 RID: 18961 RVA: 0x00105E00 File Offset: 0x00104000
		private static void SetParameterSize(global::System.Data.Common.DbParameter parameter, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type, bool isOutParam)
		{
			global::System.Data.Entity.Core.Metadata.Edm.Facet facet;
			if (type.Facets.TryGetValue("MaxLength", true, out facet) && facet.Value != null)
			{
				if (!global::System.Data.Entity.Core.Metadata.Edm.Helper.IsUnboundedFacetValue(facet))
				{
					parameter.Size = (int)facet.Value;
					return;
				}
				if (isOutParam)
				{
					parameter.Size = int.MaxValue;
				}
			}
		}

		// Token: 0x04001A19 RID: 6681
		private readonly global::System.Data.Common.DbCommand _prototype;

		// Token: 0x04001A1A RID: 6682
		private readonly global::System.Func<global::System.Data.Common.DbCommand, global::System.Data.Common.DbCommand> _cloneMethod;
	}
}
