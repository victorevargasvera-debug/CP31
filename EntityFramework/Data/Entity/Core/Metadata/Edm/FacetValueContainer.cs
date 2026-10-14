using System;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x020004C3 RID: 1219
	internal struct FacetValueContainer<T>
	{
		// Token: 0x17000BD6 RID: 3030
		// (set) Token: 0x06003C5D RID: 15453 RVA: 0x000C7165 File Offset: 0x000C5365
		internal T Value
		{
			set
			{
				this._isUnbounded = false;
				this._hasValue = true;
				this._value = value;
			}
		}

		// Token: 0x06003C5E RID: 15454 RVA: 0x000C717C File Offset: 0x000C537C
		private void SetUnbounded()
		{
			this._isUnbounded = true;
			this._hasValue = true;
		}

		// Token: 0x06003C5F RID: 15455 RVA: 0x000C718C File Offset: 0x000C538C
		public static implicit operator global::System.Data.Entity.Core.Metadata.Edm.FacetValueContainer<T>(global::System.Data.Entity.Core.Metadata.Edm.EdmConstants.Unbounded unbounded)
		{
			global::System.Data.Entity.Core.Metadata.Edm.FacetValueContainer<T> result = default(global::System.Data.Entity.Core.Metadata.Edm.FacetValueContainer<T>);
			result.SetUnbounded();
			return result;
		}

		// Token: 0x06003C60 RID: 15456 RVA: 0x000C71AC File Offset: 0x000C53AC
		public static implicit operator global::System.Data.Entity.Core.Metadata.Edm.FacetValueContainer<T>(T value)
		{
			return new global::System.Data.Entity.Core.Metadata.Edm.FacetValueContainer<T>
			{
				Value = value
			};
		}

		// Token: 0x06003C61 RID: 15457 RVA: 0x000C71CA File Offset: 0x000C53CA
		internal object GetValueAsObject()
		{
			if (this._isUnbounded)
			{
				return global::System.Data.Entity.Core.Metadata.Edm.EdmConstants.UnboundedValue;
			}
			return this._value;
		}

		// Token: 0x17000BD7 RID: 3031
		// (get) Token: 0x06003C62 RID: 15458 RVA: 0x000C71E5 File Offset: 0x000C53E5
		internal bool HasValue
		{
			get
			{
				return this._hasValue;
			}
		}

		// Token: 0x040014C3 RID: 5315
		private T _value;

		// Token: 0x040014C4 RID: 5316
		private bool _hasValue;

		// Token: 0x040014C5 RID: 5317
		private bool _isUnbounded;
	}
}
