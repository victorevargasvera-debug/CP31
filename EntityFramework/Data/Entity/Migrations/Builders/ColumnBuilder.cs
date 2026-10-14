using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Hierarchy;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.Migrations.Model;
using System.Data.Entity.Spatial;

namespace System.Data.Entity.Migrations.Builders
{
	// Token: 0x020000E9 RID: 233
	public class ColumnBuilder
	{
		// Token: 0x060011B3 RID: 4531 RVA: 0x0002CAD0 File Offset: 0x0002ACD0
		public global::System.Data.Entity.Migrations.Model.ColumnModel Binary(bool? nullable = null, int? maxLength = null, bool? fixedLength = null, byte[] defaultValue = null, string defaultValueSql = null, bool timestamp = false, string name = null, string storeType = null, global::System.Collections.Generic.IDictionary<string, global::System.Data.Entity.Infrastructure.Annotations.AnnotationValues> annotations = null)
		{
			return global::System.Data.Entity.Migrations.Builders.ColumnBuilder.BuildColumn(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Binary, nullable, defaultValue, defaultValueSql, maxLength, null, null, null, fixedLength, false, timestamp, name, storeType, annotations);
		}

		// Token: 0x060011B4 RID: 4532 RVA: 0x0002CB10 File Offset: 0x0002AD10
		public global::System.Data.Entity.Migrations.Model.ColumnModel Boolean(bool? nullable = null, bool? defaultValue = null, string defaultValueSql = null, string name = null, string storeType = null, global::System.Collections.Generic.IDictionary<string, global::System.Data.Entity.Infrastructure.Annotations.AnnotationValues> annotations = null)
		{
			return global::System.Data.Entity.Migrations.Builders.ColumnBuilder.BuildColumn(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Boolean, nullable, defaultValue, defaultValueSql, null, null, null, null, null, false, false, name, storeType, annotations);
		}

		// Token: 0x060011B5 RID: 4533 RVA: 0x0002CB60 File Offset: 0x0002AD60
		public global::System.Data.Entity.Migrations.Model.ColumnModel Byte(bool? nullable = null, bool identity = false, byte? defaultValue = null, string defaultValueSql = null, string name = null, string storeType = null, global::System.Collections.Generic.IDictionary<string, global::System.Data.Entity.Infrastructure.Annotations.AnnotationValues> annotations = null)
		{
			return global::System.Data.Entity.Migrations.Builders.ColumnBuilder.BuildColumn(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Byte, nullable, defaultValue, defaultValueSql, null, null, null, null, null, identity, false, name, storeType, annotations);
		}

		// Token: 0x060011B6 RID: 4534 RVA: 0x0002CBB4 File Offset: 0x0002ADB4
		public global::System.Data.Entity.Migrations.Model.ColumnModel DateTime(bool? nullable = null, byte? precision = null, global::System.DateTime? defaultValue = null, string defaultValueSql = null, string name = null, string storeType = null, global::System.Collections.Generic.IDictionary<string, global::System.Data.Entity.Infrastructure.Annotations.AnnotationValues> annotations = null)
		{
			return global::System.Data.Entity.Migrations.Builders.ColumnBuilder.BuildColumn(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.DateTime, nullable, defaultValue, defaultValueSql, null, precision, null, null, null, false, false, name, storeType, annotations);
		}

		// Token: 0x060011B7 RID: 4535 RVA: 0x0002CC00 File Offset: 0x0002AE00
		public global::System.Data.Entity.Migrations.Model.ColumnModel Decimal(bool? nullable = null, byte? precision = null, byte? scale = null, decimal? defaultValue = null, string defaultValueSql = null, string name = null, string storeType = null, bool identity = false, global::System.Collections.Generic.IDictionary<string, global::System.Data.Entity.Infrastructure.Annotations.AnnotationValues> annotations = null)
		{
			return global::System.Data.Entity.Migrations.Builders.ColumnBuilder.BuildColumn(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Decimal, nullable, defaultValue, defaultValueSql, null, precision, scale, null, null, identity, false, name, storeType, annotations);
		}

		// Token: 0x060011B8 RID: 4536 RVA: 0x0002CC48 File Offset: 0x0002AE48
		public global::System.Data.Entity.Migrations.Model.ColumnModel Double(bool? nullable = null, double? defaultValue = null, string defaultValueSql = null, string name = null, string storeType = null, global::System.Collections.Generic.IDictionary<string, global::System.Data.Entity.Infrastructure.Annotations.AnnotationValues> annotations = null)
		{
			return global::System.Data.Entity.Migrations.Builders.ColumnBuilder.BuildColumn(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Double, nullable, defaultValue, defaultValueSql, null, null, null, null, null, false, false, name, storeType, annotations);
		}

		// Token: 0x060011B9 RID: 4537 RVA: 0x0002CC98 File Offset: 0x0002AE98
		public global::System.Data.Entity.Migrations.Model.ColumnModel Guid(bool? nullable = null, bool identity = false, global::System.Guid? defaultValue = null, string defaultValueSql = null, string name = null, string storeType = null, global::System.Collections.Generic.IDictionary<string, global::System.Data.Entity.Infrastructure.Annotations.AnnotationValues> annotations = null)
		{
			return global::System.Data.Entity.Migrations.Builders.ColumnBuilder.BuildColumn(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Guid, nullable, defaultValue, defaultValueSql, null, null, null, null, null, identity, false, name, storeType, annotations);
		}

		// Token: 0x060011BA RID: 4538 RVA: 0x0002CCEC File Offset: 0x0002AEEC
		public global::System.Data.Entity.Migrations.Model.ColumnModel Single(bool? nullable = null, float? defaultValue = null, string defaultValueSql = null, string name = null, string storeType = null, global::System.Collections.Generic.IDictionary<string, global::System.Data.Entity.Infrastructure.Annotations.AnnotationValues> annotations = null)
		{
			return global::System.Data.Entity.Migrations.Builders.ColumnBuilder.BuildColumn(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Single, nullable, defaultValue, defaultValueSql, null, null, null, null, null, false, false, name, storeType, annotations);
		}

		// Token: 0x060011BB RID: 4539 RVA: 0x0002CD3C File Offset: 0x0002AF3C
		public global::System.Data.Entity.Migrations.Model.ColumnModel Short(bool? nullable = null, bool identity = false, short? defaultValue = null, string defaultValueSql = null, string name = null, string storeType = null, global::System.Collections.Generic.IDictionary<string, global::System.Data.Entity.Infrastructure.Annotations.AnnotationValues> annotations = null)
		{
			return global::System.Data.Entity.Migrations.Builders.ColumnBuilder.BuildColumn(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int16, nullable, defaultValue, defaultValueSql, null, null, null, null, null, identity, false, name, storeType, annotations);
		}

		// Token: 0x060011BC RID: 4540 RVA: 0x0002CD90 File Offset: 0x0002AF90
		public global::System.Data.Entity.Migrations.Model.ColumnModel Int(bool? nullable = null, bool identity = false, int? defaultValue = null, string defaultValueSql = null, string name = null, string storeType = null, global::System.Collections.Generic.IDictionary<string, global::System.Data.Entity.Infrastructure.Annotations.AnnotationValues> annotations = null)
		{
			return global::System.Data.Entity.Migrations.Builders.ColumnBuilder.BuildColumn(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int32, nullable, defaultValue, defaultValueSql, null, null, null, null, null, identity, false, name, storeType, annotations);
		}

		// Token: 0x060011BD RID: 4541 RVA: 0x0002CDE4 File Offset: 0x0002AFE4
		public global::System.Data.Entity.Migrations.Model.ColumnModel Long(bool? nullable = null, bool identity = false, long? defaultValue = null, string defaultValueSql = null, string name = null, string storeType = null, global::System.Collections.Generic.IDictionary<string, global::System.Data.Entity.Infrastructure.Annotations.AnnotationValues> annotations = null)
		{
			return global::System.Data.Entity.Migrations.Builders.ColumnBuilder.BuildColumn(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int64, nullable, defaultValue, defaultValueSql, null, null, null, null, null, identity, false, name, storeType, annotations);
		}

		// Token: 0x060011BE RID: 4542 RVA: 0x0002CE38 File Offset: 0x0002B038
		public global::System.Data.Entity.Migrations.Model.ColumnModel String(bool? nullable = null, int? maxLength = null, bool? fixedLength = null, bool? unicode = null, string defaultValue = null, string defaultValueSql = null, string name = null, string storeType = null, global::System.Collections.Generic.IDictionary<string, global::System.Data.Entity.Infrastructure.Annotations.AnnotationValues> annotations = null)
		{
			return global::System.Data.Entity.Migrations.Builders.ColumnBuilder.BuildColumn(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String, nullable, defaultValue, defaultValueSql, maxLength, null, null, unicode, fixedLength, false, false, name, storeType, annotations);
		}

		// Token: 0x060011BF RID: 4543 RVA: 0x0002CE74 File Offset: 0x0002B074
		public global::System.Data.Entity.Migrations.Model.ColumnModel Time(bool? nullable = null, byte? precision = null, global::System.TimeSpan? defaultValue = null, string defaultValueSql = null, string name = null, string storeType = null, global::System.Collections.Generic.IDictionary<string, global::System.Data.Entity.Infrastructure.Annotations.AnnotationValues> annotations = null)
		{
			return global::System.Data.Entity.Migrations.Builders.ColumnBuilder.BuildColumn(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Time, nullable, defaultValue, defaultValueSql, null, precision, null, null, null, false, false, name, storeType, annotations);
		}

		// Token: 0x060011C0 RID: 4544 RVA: 0x0002CEC0 File Offset: 0x0002B0C0
		public global::System.Data.Entity.Migrations.Model.ColumnModel DateTimeOffset(bool? nullable = null, byte? precision = null, global::System.DateTimeOffset? defaultValue = null, string defaultValueSql = null, string name = null, string storeType = null, global::System.Collections.Generic.IDictionary<string, global::System.Data.Entity.Infrastructure.Annotations.AnnotationValues> annotations = null)
		{
			return global::System.Data.Entity.Migrations.Builders.ColumnBuilder.BuildColumn(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.DateTimeOffset, nullable, defaultValue, defaultValueSql, null, precision, null, null, null, false, false, name, storeType, annotations);
		}

		// Token: 0x060011C1 RID: 4545 RVA: 0x0002CF0C File Offset: 0x0002B10C
		public global::System.Data.Entity.Migrations.Model.ColumnModel HierarchyId(bool? nullable = null, global::System.Data.Entity.Hierarchy.HierarchyId defaultValue = null, string defaultValueSql = null, string name = null, string storeType = null, global::System.Collections.Generic.IDictionary<string, global::System.Data.Entity.Infrastructure.Annotations.AnnotationValues> annotations = null)
		{
			return global::System.Data.Entity.Migrations.Builders.ColumnBuilder.BuildColumn(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.HierarchyId, nullable, defaultValue, defaultValueSql, null, null, null, null, null, false, false, name, storeType, annotations);
		}

		// Token: 0x060011C2 RID: 4546 RVA: 0x0002CF58 File Offset: 0x0002B158
		public global::System.Data.Entity.Migrations.Model.ColumnModel Geography(bool? nullable = null, global::System.Data.Entity.Spatial.DbGeography defaultValue = null, string defaultValueSql = null, string name = null, string storeType = null, global::System.Collections.Generic.IDictionary<string, global::System.Data.Entity.Infrastructure.Annotations.AnnotationValues> annotations = null)
		{
			return global::System.Data.Entity.Migrations.Builders.ColumnBuilder.BuildColumn(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Geography, nullable, defaultValue, defaultValueSql, null, null, null, null, null, false, false, name, storeType, annotations);
		}

		// Token: 0x060011C3 RID: 4547 RVA: 0x0002CFA4 File Offset: 0x0002B1A4
		public global::System.Data.Entity.Migrations.Model.ColumnModel Geometry(bool? nullable = null, global::System.Data.Entity.Spatial.DbGeometry defaultValue = null, string defaultValueSql = null, string name = null, string storeType = null, global::System.Collections.Generic.IDictionary<string, global::System.Data.Entity.Infrastructure.Annotations.AnnotationValues> annotations = null)
		{
			return global::System.Data.Entity.Migrations.Builders.ColumnBuilder.BuildColumn(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Geometry, nullable, defaultValue, defaultValueSql, null, null, null, null, null, false, false, name, storeType, annotations);
		}

		// Token: 0x060011C4 RID: 4548 RVA: 0x0002CFF0 File Offset: 0x0002B1F0
		private static global::System.Data.Entity.Migrations.Model.ColumnModel BuildColumn(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind primitiveTypeKind, bool? nullable, object defaultValue, string defaultValueSql = null, int? maxLength = null, byte? precision = null, byte? scale = null, bool? unicode = null, bool? fixedLength = null, bool identity = false, bool timestamp = false, string name = null, string storeType = null, global::System.Collections.Generic.IDictionary<string, global::System.Data.Entity.Infrastructure.Annotations.AnnotationValues> annotations = null)
		{
			return new global::System.Data.Entity.Migrations.Model.ColumnModel(primitiveTypeKind)
			{
				IsNullable = nullable,
				MaxLength = maxLength,
				Precision = precision,
				Scale = scale,
				IsUnicode = unicode,
				IsFixedLength = fixedLength,
				IsIdentity = identity,
				DefaultValue = defaultValue,
				DefaultValueSql = defaultValueSql,
				IsTimestamp = timestamp,
				Name = name,
				StoreType = storeType,
				Annotations = annotations
			};
		}

		// Token: 0x060011C5 RID: 4549 RVA: 0x0002D068 File Offset: 0x0002B268
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}

		// Token: 0x060011C6 RID: 4550 RVA: 0x0002D070 File Offset: 0x0002B270
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		// Token: 0x060011C7 RID: 4551 RVA: 0x0002D079 File Offset: 0x0002B279
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x060011C8 RID: 4552 RVA: 0x0002D081 File Offset: 0x0002B281
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public new global::System.Type GetType()
		{
			return base.GetType();
		}

		// Token: 0x060011C9 RID: 4553 RVA: 0x0002D089 File Offset: 0x0002B289
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		protected new object MemberwiseClone()
		{
			return base.MemberwiseClone();
		}
	}
}
