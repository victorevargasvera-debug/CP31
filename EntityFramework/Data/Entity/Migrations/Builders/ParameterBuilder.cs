using System;
using System.ComponentModel;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Migrations.Model;
using System.Data.Entity.Spatial;

namespace System.Data.Entity.Migrations.Builders
{
	// Token: 0x020000EA RID: 234
	public class ParameterBuilder
	{
		// Token: 0x060011CB RID: 4555 RVA: 0x0002D09C File Offset: 0x0002B29C
		public global::System.Data.Entity.Migrations.Model.ParameterModel Binary(int? maxLength = null, bool? fixedLength = null, byte[] defaultValue = null, string defaultValueSql = null, string name = null, string storeType = null, bool outParameter = false)
		{
			return global::System.Data.Entity.Migrations.Builders.ParameterBuilder.BuildParameter(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Binary, defaultValue, defaultValueSql, maxLength, null, null, null, fixedLength, name, storeType, outParameter);
		}

		// Token: 0x060011CC RID: 4556 RVA: 0x0002D0D8 File Offset: 0x0002B2D8
		public global::System.Data.Entity.Migrations.Model.ParameterModel Boolean(bool? defaultValue = null, string defaultValueSql = null, string name = null, string storeType = null, bool outParameter = false)
		{
			return global::System.Data.Entity.Migrations.Builders.ParameterBuilder.BuildParameter(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Boolean, defaultValue, defaultValueSql, null, null, null, null, null, name, storeType, outParameter);
		}

		// Token: 0x060011CD RID: 4557 RVA: 0x0002D124 File Offset: 0x0002B324
		public global::System.Data.Entity.Migrations.Model.ParameterModel Byte(byte? defaultValue = null, string defaultValueSql = null, string name = null, string storeType = null, bool outParameter = false)
		{
			return global::System.Data.Entity.Migrations.Builders.ParameterBuilder.BuildParameter(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Byte, defaultValue, defaultValueSql, null, null, null, null, null, name, storeType, outParameter);
		}

		// Token: 0x060011CE RID: 4558 RVA: 0x0002D170 File Offset: 0x0002B370
		public global::System.Data.Entity.Migrations.Model.ParameterModel DateTime(byte? precision = null, global::System.DateTime? defaultValue = null, string defaultValueSql = null, string name = null, string storeType = null, bool outParameter = false)
		{
			return global::System.Data.Entity.Migrations.Builders.ParameterBuilder.BuildParameter(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.DateTime, defaultValue, defaultValueSql, null, precision, null, null, null, name, storeType, outParameter);
		}

		// Token: 0x060011CF RID: 4559 RVA: 0x0002D1B8 File Offset: 0x0002B3B8
		public global::System.Data.Entity.Migrations.Model.ParameterModel Decimal(byte? precision = null, byte? scale = null, decimal? defaultValue = null, string defaultValueSql = null, string name = null, string storeType = null, bool outParameter = false)
		{
			return global::System.Data.Entity.Migrations.Builders.ParameterBuilder.BuildParameter(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Decimal, defaultValue, defaultValueSql, null, precision, scale, null, null, name, storeType, outParameter);
		}

		// Token: 0x060011D0 RID: 4560 RVA: 0x0002D1F8 File Offset: 0x0002B3F8
		public global::System.Data.Entity.Migrations.Model.ParameterModel Double(double? defaultValue = null, string defaultValueSql = null, string name = null, string storeType = null, bool outParameter = false)
		{
			return global::System.Data.Entity.Migrations.Builders.ParameterBuilder.BuildParameter(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Double, defaultValue, defaultValueSql, null, null, null, null, null, name, storeType, outParameter);
		}

		// Token: 0x060011D1 RID: 4561 RVA: 0x0002D244 File Offset: 0x0002B444
		public global::System.Data.Entity.Migrations.Model.ParameterModel Guid(global::System.Guid? defaultValue = null, string defaultValueSql = null, string name = null, string storeType = null, bool outParameter = false)
		{
			return global::System.Data.Entity.Migrations.Builders.ParameterBuilder.BuildParameter(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Guid, defaultValue, defaultValueSql, null, null, null, null, null, name, storeType, outParameter);
		}

		// Token: 0x060011D2 RID: 4562 RVA: 0x0002D290 File Offset: 0x0002B490
		public global::System.Data.Entity.Migrations.Model.ParameterModel Single(float? defaultValue = null, string defaultValueSql = null, string name = null, string storeType = null, bool outParameter = false)
		{
			return global::System.Data.Entity.Migrations.Builders.ParameterBuilder.BuildParameter(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Single, defaultValue, defaultValueSql, null, null, null, null, null, name, storeType, outParameter);
		}

		// Token: 0x060011D3 RID: 4563 RVA: 0x0002D2DC File Offset: 0x0002B4DC
		public global::System.Data.Entity.Migrations.Model.ParameterModel Short(short? defaultValue = null, string defaultValueSql = null, string name = null, string storeType = null, bool outParameter = false)
		{
			return global::System.Data.Entity.Migrations.Builders.ParameterBuilder.BuildParameter(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int16, defaultValue, defaultValueSql, null, null, null, null, null, name, storeType, outParameter);
		}

		// Token: 0x060011D4 RID: 4564 RVA: 0x0002D32C File Offset: 0x0002B52C
		public global::System.Data.Entity.Migrations.Model.ParameterModel Int(int? defaultValue = null, string defaultValueSql = null, string name = null, string storeType = null, bool outParameter = false)
		{
			return global::System.Data.Entity.Migrations.Builders.ParameterBuilder.BuildParameter(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int32, defaultValue, defaultValueSql, null, null, null, null, null, name, storeType, outParameter);
		}

		// Token: 0x060011D5 RID: 4565 RVA: 0x0002D37C File Offset: 0x0002B57C
		public global::System.Data.Entity.Migrations.Model.ParameterModel Long(long? defaultValue = null, string defaultValueSql = null, string name = null, string storeType = null, bool outParameter = false)
		{
			return global::System.Data.Entity.Migrations.Builders.ParameterBuilder.BuildParameter(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int64, defaultValue, defaultValueSql, null, null, null, null, null, name, storeType, outParameter);
		}

		// Token: 0x060011D6 RID: 4566 RVA: 0x0002D3CC File Offset: 0x0002B5CC
		public global::System.Data.Entity.Migrations.Model.ParameterModel String(int? maxLength = null, bool? fixedLength = null, bool? unicode = null, string defaultValue = null, string defaultValueSql = null, string name = null, string storeType = null, bool outParameter = false)
		{
			return global::System.Data.Entity.Migrations.Builders.ParameterBuilder.BuildParameter(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String, defaultValue, defaultValueSql, maxLength, null, null, unicode, fixedLength, name, storeType, outParameter);
		}

		// Token: 0x060011D7 RID: 4567 RVA: 0x0002D404 File Offset: 0x0002B604
		public global::System.Data.Entity.Migrations.Model.ParameterModel Time(byte? precision = null, global::System.TimeSpan? defaultValue = null, string defaultValueSql = null, string name = null, string storeType = null, bool outParameter = false)
		{
			return global::System.Data.Entity.Migrations.Builders.ParameterBuilder.BuildParameter(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Time, defaultValue, defaultValueSql, null, precision, null, null, null, name, storeType, outParameter);
		}

		// Token: 0x060011D8 RID: 4568 RVA: 0x0002D44C File Offset: 0x0002B64C
		public global::System.Data.Entity.Migrations.Model.ParameterModel DateTimeOffset(byte? precision = null, global::System.DateTimeOffset? defaultValue = null, string defaultValueSql = null, string name = null, string storeType = null, bool outParameter = false)
		{
			return global::System.Data.Entity.Migrations.Builders.ParameterBuilder.BuildParameter(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.DateTimeOffset, defaultValue, defaultValueSql, null, precision, null, null, null, name, storeType, outParameter);
		}

		// Token: 0x060011D9 RID: 4569 RVA: 0x0002D494 File Offset: 0x0002B694
		public global::System.Data.Entity.Migrations.Model.ParameterModel Geography(global::System.Data.Entity.Spatial.DbGeography defaultValue = null, string defaultValueSql = null, string name = null, string storeType = null, bool outParameter = false)
		{
			return global::System.Data.Entity.Migrations.Builders.ParameterBuilder.BuildParameter(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Geography, defaultValue, defaultValueSql, null, null, null, null, null, name, storeType, outParameter);
		}

		// Token: 0x060011DA RID: 4570 RVA: 0x0002D4DC File Offset: 0x0002B6DC
		public global::System.Data.Entity.Migrations.Model.ParameterModel Geometry(global::System.Data.Entity.Spatial.DbGeometry defaultValue = null, string defaultValueSql = null, string name = null, string storeType = null, bool outParameter = false)
		{
			return global::System.Data.Entity.Migrations.Builders.ParameterBuilder.BuildParameter(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Geometry, defaultValue, defaultValueSql, null, null, null, null, null, name, storeType, outParameter);
		}

		// Token: 0x060011DB RID: 4571 RVA: 0x0002D524 File Offset: 0x0002B724
		private static global::System.Data.Entity.Migrations.Model.ParameterModel BuildParameter(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind primitiveTypeKind, object defaultValue, string defaultValueSql = null, int? maxLength = null, byte? precision = null, byte? scale = null, bool? unicode = null, bool? fixedLength = null, string name = null, string storeType = null, bool outParameter = false)
		{
			return new global::System.Data.Entity.Migrations.Model.ParameterModel(primitiveTypeKind)
			{
				MaxLength = maxLength,
				Precision = precision,
				Scale = scale,
				IsUnicode = unicode,
				IsFixedLength = fixedLength,
				DefaultValue = defaultValue,
				DefaultValueSql = defaultValueSql,
				Name = name,
				StoreType = storeType,
				IsOutParameter = outParameter
			};
		}

		// Token: 0x060011DC RID: 4572 RVA: 0x0002D584 File Offset: 0x0002B784
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}

		// Token: 0x060011DD RID: 4573 RVA: 0x0002D58C File Offset: 0x0002B78C
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		// Token: 0x060011DE RID: 4574 RVA: 0x0002D595 File Offset: 0x0002B795
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x060011DF RID: 4575 RVA: 0x0002D59D File Offset: 0x0002B79D
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public new global::System.Type GetType()
		{
			return base.GetType();
		}

		// Token: 0x060011E0 RID: 4576 RVA: 0x0002D5A5 File Offset: 0x0002B7A5
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		protected new object MemberwiseClone()
		{
			return base.MemberwiseClone();
		}
	}
}
