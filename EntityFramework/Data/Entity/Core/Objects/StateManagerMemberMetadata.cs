using System;
using System.Data.Entity.Core.Mapping;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Resources;

namespace System.Data.Entity.Core.Objects
{
	// Token: 0x02000432 RID: 1074
	internal class StateManagerMemberMetadata
	{
		// Token: 0x06003451 RID: 13393 RVA: 0x000A800B File Offset: 0x000A620B
		internal StateManagerMemberMetadata()
		{
		}

		// Token: 0x06003452 RID: 13394 RVA: 0x000A8014 File Offset: 0x000A6214
		internal StateManagerMemberMetadata(global::System.Data.Entity.Core.Mapping.ObjectPropertyMapping memberMap, global::System.Data.Entity.Core.Metadata.Edm.EdmProperty memberMetadata, bool isPartOfKey)
		{
			this._clrProperty = memberMap.ClrProperty;
			this._edmProperty = memberMetadata;
			this._isPartOfKey = isPartOfKey;
			this._isComplexType = (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsEntityType(this._edmProperty.TypeUsage.EdmType) || global::System.Data.Entity.Core.Metadata.Edm.Helper.IsComplexType(this._edmProperty.TypeUsage.EdmType));
		}

		// Token: 0x17000A1A RID: 2586
		// (get) Token: 0x06003453 RID: 13395 RVA: 0x000A8076 File Offset: 0x000A6276
		internal string CLayerName
		{
			get
			{
				return this._edmProperty.Name;
			}
		}

		// Token: 0x17000A1B RID: 2587
		// (get) Token: 0x06003454 RID: 13396 RVA: 0x000A8083 File Offset: 0x000A6283
		internal global::System.Type ClrType
		{
			get
			{
				return this._clrProperty.TypeUsage.EdmType.ClrType;
			}
		}

		// Token: 0x17000A1C RID: 2588
		// (get) Token: 0x06003455 RID: 13397 RVA: 0x000A809A File Offset: 0x000A629A
		internal virtual bool IsComplex
		{
			get
			{
				return this._isComplexType;
			}
		}

		// Token: 0x17000A1D RID: 2589
		// (get) Token: 0x06003456 RID: 13398 RVA: 0x000A80A2 File Offset: 0x000A62A2
		internal virtual global::System.Data.Entity.Core.Metadata.Edm.EdmProperty CdmMetadata
		{
			get
			{
				return this._edmProperty;
			}
		}

		// Token: 0x17000A1E RID: 2590
		// (get) Token: 0x06003457 RID: 13399 RVA: 0x000A80AA File Offset: 0x000A62AA
		internal global::System.Data.Entity.Core.Metadata.Edm.EdmProperty ClrMetadata
		{
			get
			{
				return this._clrProperty;
			}
		}

		// Token: 0x17000A1F RID: 2591
		// (get) Token: 0x06003458 RID: 13400 RVA: 0x000A80B2 File Offset: 0x000A62B2
		internal bool IsPartOfKey
		{
			get
			{
				return this._isPartOfKey;
			}
		}

		// Token: 0x06003459 RID: 13401 RVA: 0x000A80BA File Offset: 0x000A62BA
		public virtual object GetValue(object userObject)
		{
			return global::System.Data.Entity.Core.Objects.DelegateFactory.GetValue(this._clrProperty, userObject);
		}

		// Token: 0x0600345A RID: 13402 RVA: 0x000A80C8 File Offset: 0x000A62C8
		public void SetValue(object userObject, object value)
		{
			if (global::System.DBNull.Value == value)
			{
				value = null;
			}
			if (this.IsComplex && value == null)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ComplexObject_NullableComplexTypesNotSupported(this.CLayerName));
			}
			global::System.Data.Entity.Core.Objects.DelegateFactory.SetValue(this._clrProperty, userObject, value);
		}

		// Token: 0x040010E0 RID: 4320
		private readonly global::System.Data.Entity.Core.Metadata.Edm.EdmProperty _clrProperty;

		// Token: 0x040010E1 RID: 4321
		private readonly global::System.Data.Entity.Core.Metadata.Edm.EdmProperty _edmProperty;

		// Token: 0x040010E2 RID: 4322
		private readonly bool _isPartOfKey;

		// Token: 0x040010E3 RID: 4323
		private readonly bool _isComplexType;
	}
}
