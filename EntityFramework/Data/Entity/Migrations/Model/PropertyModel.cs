using System;
using System.Data.Entity.Core.Metadata.Edm;

namespace System.Data.Entity.Migrations.Model
{
	// Token: 0x020000C5 RID: 197
	public abstract class PropertyModel
	{
		// Token: 0x06000FAC RID: 4012 RVA: 0x0001FD60 File Offset: 0x0001DF60
		protected PropertyModel(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind type, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage)
		{
			this._type = type;
			this._typeUsage = typeUsage;
		}

		// Token: 0x17000441 RID: 1089
		// (get) Token: 0x06000FAD RID: 4013 RVA: 0x0001FD76 File Offset: 0x0001DF76
		public virtual global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind Type
		{
			get
			{
				return this._type;
			}
		}

		// Token: 0x17000442 RID: 1090
		// (get) Token: 0x06000FAE RID: 4014 RVA: 0x0001FD80 File Offset: 0x0001DF80
		public global::System.Data.Entity.Core.Metadata.Edm.TypeUsage TypeUsage
		{
			get
			{
				global::System.Data.Entity.Core.Metadata.Edm.TypeUsage result;
				if ((result = this._typeUsage) == null)
				{
					result = (this._typeUsage = this.BuildTypeUsage());
				}
				return result;
			}
		}

		// Token: 0x17000443 RID: 1091
		// (get) Token: 0x06000FAF RID: 4015 RVA: 0x0001FDA6 File Offset: 0x0001DFA6
		// (set) Token: 0x06000FB0 RID: 4016 RVA: 0x0001FDAE File Offset: 0x0001DFAE
		public virtual string Name { get; set; }

		// Token: 0x17000444 RID: 1092
		// (get) Token: 0x06000FB1 RID: 4017 RVA: 0x0001FDB7 File Offset: 0x0001DFB7
		// (set) Token: 0x06000FB2 RID: 4018 RVA: 0x0001FDBF File Offset: 0x0001DFBF
		public virtual string StoreType { get; set; }

		// Token: 0x17000445 RID: 1093
		// (get) Token: 0x06000FB3 RID: 4019 RVA: 0x0001FDC8 File Offset: 0x0001DFC8
		// (set) Token: 0x06000FB4 RID: 4020 RVA: 0x0001FDD0 File Offset: 0x0001DFD0
		public virtual int? MaxLength { get; set; }

		// Token: 0x17000446 RID: 1094
		// (get) Token: 0x06000FB5 RID: 4021 RVA: 0x0001FDD9 File Offset: 0x0001DFD9
		// (set) Token: 0x06000FB6 RID: 4022 RVA: 0x0001FDE1 File Offset: 0x0001DFE1
		public virtual byte? Precision { get; set; }

		// Token: 0x17000447 RID: 1095
		// (get) Token: 0x06000FB7 RID: 4023 RVA: 0x0001FDEA File Offset: 0x0001DFEA
		// (set) Token: 0x06000FB8 RID: 4024 RVA: 0x0001FDF2 File Offset: 0x0001DFF2
		public virtual byte? Scale { get; set; }

		// Token: 0x17000448 RID: 1096
		// (get) Token: 0x06000FB9 RID: 4025 RVA: 0x0001FDFB File Offset: 0x0001DFFB
		// (set) Token: 0x06000FBA RID: 4026 RVA: 0x0001FE03 File Offset: 0x0001E003
		public virtual object DefaultValue { get; set; }

		// Token: 0x17000449 RID: 1097
		// (get) Token: 0x06000FBB RID: 4027 RVA: 0x0001FE0C File Offset: 0x0001E00C
		// (set) Token: 0x06000FBC RID: 4028 RVA: 0x0001FE14 File Offset: 0x0001E014
		public virtual string DefaultValueSql { get; set; }

		// Token: 0x1700044A RID: 1098
		// (get) Token: 0x06000FBD RID: 4029 RVA: 0x0001FE1D File Offset: 0x0001E01D
		// (set) Token: 0x06000FBE RID: 4030 RVA: 0x0001FE25 File Offset: 0x0001E025
		public virtual bool? IsFixedLength { get; set; }

		// Token: 0x1700044B RID: 1099
		// (get) Token: 0x06000FBF RID: 4031 RVA: 0x0001FE2E File Offset: 0x0001E02E
		// (set) Token: 0x06000FC0 RID: 4032 RVA: 0x0001FE36 File Offset: 0x0001E036
		public virtual bool? IsUnicode { get; set; }

		// Token: 0x06000FC1 RID: 4033 RVA: 0x0001FE40 File Offset: 0x0001E040
		private global::System.Data.Entity.Core.Metadata.Edm.TypeUsage BuildTypeUsage()
		{
			global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType edmPrimitiveType = global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType.GetEdmPrimitiveType(this.Type);
			if (this.Type == global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Binary)
			{
				if (this.MaxLength != null)
				{
					return global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.CreateBinaryTypeUsage(edmPrimitiveType, this.IsFixedLength.GetValueOrDefault(), this.MaxLength.Value);
				}
				return global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.CreateBinaryTypeUsage(edmPrimitiveType, this.IsFixedLength.GetValueOrDefault());
			}
			else if (this.Type == global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String)
			{
				if (this.MaxLength != null)
				{
					return global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.CreateStringTypeUsage(edmPrimitiveType, this.IsUnicode ?? true, this.IsFixedLength.GetValueOrDefault(), this.MaxLength.Value);
				}
				return global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.CreateStringTypeUsage(edmPrimitiveType, this.IsUnicode ?? true, this.IsFixedLength.GetValueOrDefault());
			}
			else
			{
				if (this.Type == global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.DateTime)
				{
					return global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.CreateDateTimeTypeUsage(edmPrimitiveType, this.Precision);
				}
				if (this.Type == global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.DateTimeOffset)
				{
					return global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.CreateDateTimeOffsetTypeUsage(edmPrimitiveType, this.Precision);
				}
				if (this.Type == global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Decimal)
				{
					if (this.Precision != null || this.Scale != null)
					{
						return global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.CreateDecimalTypeUsage(edmPrimitiveType, this.Precision ?? 18, this.Scale.GetValueOrDefault());
					}
					return global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.CreateDecimalTypeUsage(edmPrimitiveType);
				}
				else
				{
					if (this.Type != global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Time)
					{
						return global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.CreateDefaultTypeUsage(edmPrimitiveType);
					}
					return global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.CreateTimeTypeUsage(edmPrimitiveType, this.Precision);
				}
			}
		}

		// Token: 0x06000FC2 RID: 4034 RVA: 0x0001FFDC File Offset: 0x0001E1DC
		internal virtual global::System.Data.Entity.Core.Metadata.Edm.FacetValues ToFacetValues()
		{
			global::System.Data.Entity.Core.Metadata.Edm.FacetValues facetValues = new global::System.Data.Entity.Core.Metadata.Edm.FacetValues();
			if (this.DefaultValue != null)
			{
				facetValues.DefaultValue = this.DefaultValue;
			}
			if (this.IsFixedLength != null)
			{
				facetValues.FixedLength = new bool?(this.IsFixedLength.Value);
			}
			if (this.IsUnicode != null)
			{
				facetValues.Unicode = new bool?(this.IsUnicode.Value);
			}
			if (this.MaxLength != null)
			{
				facetValues.MaxLength = new int?(this.MaxLength.Value);
			}
			if (this.Precision != null)
			{
				facetValues.Precision = new byte?(this.Precision.Value);
			}
			if (this.Scale != null)
			{
				facetValues.Scale = new byte?(this.Scale.Value);
			}
			return facetValues;
		}

		// Token: 0x0400087F RID: 2175
		private readonly global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind _type;

		// Token: 0x04000880 RID: 2176
		private global::System.Data.Entity.Core.Metadata.Edm.TypeUsage _typeUsage;
	}
}
