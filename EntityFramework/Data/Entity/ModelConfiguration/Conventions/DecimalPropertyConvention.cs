using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.ModelConfiguration.Conventions
{
	// Token: 0x020001A7 RID: 423
	public class DecimalPropertyConvention : global::System.Data.Entity.ModelConfiguration.Conventions.IConceptualModelConvention<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>, global::System.Data.Entity.ModelConfiguration.Conventions.IConvention
	{
		// Token: 0x0600176E RID: 5998 RVA: 0x0003E0CA File Offset: 0x0003C2CA
		public DecimalPropertyConvention() : this(18, 2)
		{
		}

		// Token: 0x0600176F RID: 5999 RVA: 0x0003E0D5 File Offset: 0x0003C2D5
		public DecimalPropertyConvention(byte precision, byte scale)
		{
			this._precision = precision;
			this._scale = scale;
		}

		// Token: 0x06001770 RID: 6000 RVA: 0x0003E0EC File Offset: 0x0003C2EC
		public virtual void Apply(global::System.Data.Entity.Core.Metadata.Edm.EdmProperty item, global::System.Data.Entity.Infrastructure.DbModel model)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>(item, "item");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Infrastructure.DbModel>(model, "model");
			if (item.PrimitiveType == global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType.GetEdmPrimitiveType(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Decimal))
			{
				if (item.Precision == null)
				{
					item.Precision = new byte?(this._precision);
				}
				if (item.Scale == null)
				{
					item.Scale = new byte?(this._scale);
				}
			}
		}

		// Token: 0x04000A33 RID: 2611
		private readonly byte _precision;

		// Token: 0x04000A34 RID: 2612
		private readonly byte _scale;
	}
}
