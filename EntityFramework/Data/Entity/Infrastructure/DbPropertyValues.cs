using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity.Internal;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Infrastructure
{
	// Token: 0x0200022F RID: 559
	public class DbPropertyValues
	{
		// Token: 0x06001D5C RID: 7516 RVA: 0x00052578 File Offset: 0x00050778
		internal DbPropertyValues(global::System.Data.Entity.Internal.InternalPropertyValues internalValues)
		{
			this._internalValues = internalValues;
		}

		// Token: 0x06001D5D RID: 7517 RVA: 0x00052587 File Offset: 0x00050787
		public object ToObject()
		{
			return this._internalValues.ToObject();
		}

		// Token: 0x06001D5E RID: 7518 RVA: 0x00052594 File Offset: 0x00050794
		public void SetValues(object obj)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<object>(obj, "obj");
			this._internalValues.SetValues(obj);
		}

		// Token: 0x06001D5F RID: 7519 RVA: 0x000525AE File Offset: 0x000507AE
		public global::System.Data.Entity.Infrastructure.DbPropertyValues Clone()
		{
			return new global::System.Data.Entity.Infrastructure.DbPropertyValues(this._internalValues.Clone());
		}

		// Token: 0x06001D60 RID: 7520 RVA: 0x000525C0 File Offset: 0x000507C0
		public void SetValues(global::System.Data.Entity.Infrastructure.DbPropertyValues propertyValues)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Infrastructure.DbPropertyValues>(propertyValues, "propertyValues");
			this._internalValues.SetValues(propertyValues._internalValues);
		}

		// Token: 0x17000697 RID: 1687
		// (get) Token: 0x06001D61 RID: 7521 RVA: 0x000525DF File Offset: 0x000507DF
		public global::System.Collections.Generic.IEnumerable<string> PropertyNames
		{
			get
			{
				return this._internalValues.PropertyNames;
			}
		}

		// Token: 0x17000698 RID: 1688
		public object this[string propertyName]
		{
			get
			{
				global::System.Data.Entity.Utilities.Check.NotEmpty(propertyName, "propertyName");
				object obj = this._internalValues[propertyName];
				global::System.Data.Entity.Internal.InternalPropertyValues internalPropertyValues = obj as global::System.Data.Entity.Internal.InternalPropertyValues;
				if (internalPropertyValues != null)
				{
					obj = new global::System.Data.Entity.Infrastructure.DbPropertyValues(internalPropertyValues);
				}
				return obj;
			}
			set
			{
				global::System.Data.Entity.Utilities.Check.NotEmpty(propertyName, "propertyName");
				this._internalValues[propertyName] = value;
			}
		}

		// Token: 0x06001D64 RID: 7524 RVA: 0x0005263F File Offset: 0x0005083F
		public TValue GetValue<TValue>(string propertyName)
		{
			return (TValue)((object)this[propertyName]);
		}

		// Token: 0x17000699 RID: 1689
		// (get) Token: 0x06001D65 RID: 7525 RVA: 0x0005264D File Offset: 0x0005084D
		internal global::System.Data.Entity.Internal.InternalPropertyValues InternalPropertyValues
		{
			get
			{
				return this._internalValues;
			}
		}

		// Token: 0x06001D66 RID: 7526 RVA: 0x00052655 File Offset: 0x00050855
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}

		// Token: 0x06001D67 RID: 7527 RVA: 0x0005265D File Offset: 0x0005085D
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		// Token: 0x06001D68 RID: 7528 RVA: 0x00052666 File Offset: 0x00050866
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x06001D69 RID: 7529 RVA: 0x0005266E File Offset: 0x0005086E
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public new global::System.Type GetType()
		{
			return base.GetType();
		}

		// Token: 0x04000B20 RID: 2848
		private readonly global::System.Data.Entity.Internal.InternalPropertyValues _internalValues;
	}
}
