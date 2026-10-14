using System;
using System.Data.Entity.Spatial;
using System.Data.Entity.SqlServer.Resources;
using System.Data.Entity.SqlServer.Utilities;
using System.Data.SqlTypes;
using System.IO;
using System.Linq.Expressions;
using System.Reflection;

namespace System.Data.Entity.SqlServer
{
	// Token: 0x02000013 RID: 19
	internal sealed class SqlSpatialDataReader : global::System.Data.Entity.Spatial.DbSpatialDataReader
	{
		// Token: 0x06000180 RID: 384 RVA: 0x00009054 File Offset: 0x00007254
		internal SqlSpatialDataReader(global::System.Data.Entity.Spatial.DbSpatialServices spatialServices, global::System.Data.Entity.SqlServer.Utilities.SqlDataReaderWrapper underlyingReader)
		{
			this._spatialServices = spatialServices;
			this._reader = underlyingReader;
			int fieldCount = this._reader.FieldCount;
			this._geographyColumns = new bool[fieldCount];
			this._geometryColumns = new bool[fieldCount];
			for (int i = 0; i < this._reader.FieldCount; i++)
			{
				string dataTypeName = this._reader.GetDataTypeName(i);
				if (dataTypeName.EndsWith("sys.geography", global::System.StringComparison.Ordinal))
				{
					this._geographyColumns[i] = true;
				}
				else if (dataTypeName.EndsWith("sys.geometry", global::System.StringComparison.Ordinal))
				{
					this._geometryColumns[i] = true;
				}
			}
		}

		// Token: 0x06000181 RID: 385 RVA: 0x000090EC File Offset: 0x000072EC
		public override global::System.Data.Entity.Spatial.DbGeography GetGeography(int ordinal)
		{
			this.EnsureGeographyColumn(ordinal);
			global::System.Data.SqlTypes.SqlBytes sqlBytes = this._reader.GetSqlBytes(ordinal);
			object providerValue = global::System.Data.Entity.SqlServer.SqlSpatialDataReader._sqlGeographyFromBinaryReader.Value(new global::System.IO.BinaryReader(sqlBytes.Stream));
			return this._spatialServices.GeographyFromProviderValue(providerValue);
		}

		// Token: 0x06000182 RID: 386 RVA: 0x00009134 File Offset: 0x00007334
		public override global::System.Data.Entity.Spatial.DbGeometry GetGeometry(int ordinal)
		{
			this.EnsureGeometryColumn(ordinal);
			global::System.Data.SqlTypes.SqlBytes sqlBytes = this._reader.GetSqlBytes(ordinal);
			object providerValue = global::System.Data.Entity.SqlServer.SqlSpatialDataReader._sqlGeometryFromBinaryReader.Value(new global::System.IO.BinaryReader(sqlBytes.Stream));
			return this._spatialServices.GeometryFromProviderValue(providerValue);
		}

		// Token: 0x06000183 RID: 387 RVA: 0x0000917C File Offset: 0x0000737C
		public override bool IsGeographyColumn(int ordinal)
		{
			return this._geographyColumns[ordinal];
		}

		// Token: 0x06000184 RID: 388 RVA: 0x00009186 File Offset: 0x00007386
		public override bool IsGeometryColumn(int ordinal)
		{
			return this._geometryColumns[ordinal];
		}

		// Token: 0x06000185 RID: 389 RVA: 0x00009190 File Offset: 0x00007390
		private void EnsureGeographyColumn(int ordinal)
		{
			if (!this.IsGeographyColumn(ordinal))
			{
				throw new global::System.IO.InvalidDataException(global::System.Data.Entity.SqlServer.Resources.Strings.SqlProvider_InvalidGeographyColumn(this._reader.GetDataTypeName(ordinal)));
			}
		}

		// Token: 0x06000186 RID: 390 RVA: 0x000091B2 File Offset: 0x000073B2
		private void EnsureGeometryColumn(int ordinal)
		{
			if (!this.IsGeometryColumn(ordinal))
			{
				throw new global::System.IO.InvalidDataException(global::System.Data.Entity.SqlServer.Resources.Strings.SqlProvider_InvalidGeometryColumn(this._reader.GetDataTypeName(ordinal)));
			}
		}

		// Token: 0x06000187 RID: 391 RVA: 0x000091D4 File Offset: 0x000073D4
		private static global::System.Func<global::System.IO.BinaryReader, object> CreateBinaryReadDelegate(global::System.Type spatialType)
		{
			global::System.Linq.Expressions.ParameterExpression parameterExpression = global::System.Linq.Expressions.Expression.Parameter(typeof(global::System.IO.BinaryReader));
			global::System.Linq.Expressions.ParameterExpression parameterExpression2 = global::System.Linq.Expressions.Expression.Variable(spatialType);
			global::System.Reflection.MethodInfo publicInstanceMethod = spatialType.GetPublicInstanceMethod("Read", new global::System.Type[]
			{
				typeof(global::System.IO.BinaryReader)
			});
			return global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::System.IO.BinaryReader, object>>(global::System.Linq.Expressions.Expression.Block(new global::System.Linq.Expressions.ParameterExpression[]
			{
				parameterExpression2
			}, new global::System.Linq.Expressions.Expression[]
			{
				global::System.Linq.Expressions.Expression.Assign(parameterExpression2, global::System.Linq.Expressions.Expression.New(spatialType)),
				global::System.Linq.Expressions.Expression.Call(parameterExpression2, publicInstanceMethod, new global::System.Linq.Expressions.Expression[]
				{
					parameterExpression
				}),
				parameterExpression2
			}), new global::System.Linq.Expressions.ParameterExpression[]
			{
				parameterExpression
			}).Compile();
		}

		// Token: 0x04000026 RID: 38
		private static readonly global::System.Lazy<global::System.Func<global::System.IO.BinaryReader, object>> _sqlGeographyFromBinaryReader = new global::System.Lazy<global::System.Func<global::System.IO.BinaryReader, object>>(() => global::System.Data.Entity.SqlServer.SqlSpatialDataReader.CreateBinaryReadDelegate(global::System.Data.Entity.SqlServer.SqlTypesAssemblyLoader.DefaultInstance.GetSqlTypesAssembly().SqlGeographyType), true);

		// Token: 0x04000027 RID: 39
		private static readonly global::System.Lazy<global::System.Func<global::System.IO.BinaryReader, object>> _sqlGeometryFromBinaryReader = new global::System.Lazy<global::System.Func<global::System.IO.BinaryReader, object>>(() => global::System.Data.Entity.SqlServer.SqlSpatialDataReader.CreateBinaryReadDelegate(global::System.Data.Entity.SqlServer.SqlTypesAssemblyLoader.DefaultInstance.GetSqlTypesAssembly().SqlGeometryType), true);

		// Token: 0x04000028 RID: 40
		private const string GeometrySqlType = "sys.geometry";

		// Token: 0x04000029 RID: 41
		private const string GeographySqlType = "sys.geography";

		// Token: 0x0400002A RID: 42
		private readonly global::System.Data.Entity.Spatial.DbSpatialServices _spatialServices;

		// Token: 0x0400002B RID: 43
		private readonly global::System.Data.Entity.SqlServer.Utilities.SqlDataReaderWrapper _reader;

		// Token: 0x0400002C RID: 44
		private readonly bool[] _geographyColumns;

		// Token: 0x0400002D RID: 45
		private readonly bool[] _geometryColumns;
	}
}
