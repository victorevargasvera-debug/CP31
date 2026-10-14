using System;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.Utilities;
using System.Runtime.CompilerServices;

namespace System.ComponentModel.DataAnnotations.Schema
{
	// Token: 0x02000053 RID: 83
	[global::System.AttributeUsage(global::System.AttributeTargets.Property, AllowMultiple = true)]
	public class IndexAttribute : global::System.Attribute
	{
		// Token: 0x060001E8 RID: 488 RVA: 0x0000742C File Offset: 0x0000562C
		public IndexAttribute()
		{
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x0000743B File Offset: 0x0000563B
		public IndexAttribute(string name)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(name, "name");
			this._name = name;
		}

		// Token: 0x060001EA RID: 490 RVA: 0x0000745D File Offset: 0x0000565D
		public IndexAttribute(string name, int order)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(name, "name");
			if (order < 0)
			{
				throw new global::System.ArgumentOutOfRangeException("order");
			}
			this._name = name;
			this._order = order;
		}

		// Token: 0x060001EB RID: 491 RVA: 0x00007495 File Offset: 0x00005695
		internal IndexAttribute(string name, bool? isClustered, bool? isUnique)
		{
			this._name = name;
			this._isClustered = isClustered;
			this._isUnique = isUnique;
		}

		// Token: 0x060001EC RID: 492 RVA: 0x000074B9 File Offset: 0x000056B9
		internal IndexAttribute(string name, int order, bool? isClustered, bool? isUnique)
		{
			this._name = name;
			this._order = order;
			this._isClustered = isClustered;
			this._isUnique = isUnique;
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x060001ED RID: 493 RVA: 0x000074E5 File Offset: 0x000056E5
		// (set) Token: 0x060001EE RID: 494 RVA: 0x000074ED File Offset: 0x000056ED
		public virtual string Name
		{
			get
			{
				return this._name;
			}
			internal set
			{
				this._name = value;
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x060001EF RID: 495 RVA: 0x000074F6 File Offset: 0x000056F6
		// (set) Token: 0x060001F0 RID: 496 RVA: 0x000074FE File Offset: 0x000056FE
		public virtual int Order
		{
			get
			{
				return this._order;
			}
			set
			{
				if (value < 0)
				{
					throw new global::System.ArgumentOutOfRangeException("value");
				}
				this._order = value;
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x060001F1 RID: 497 RVA: 0x00007516 File Offset: 0x00005716
		// (set) Token: 0x060001F2 RID: 498 RVA: 0x00007532 File Offset: 0x00005732
		public virtual bool IsClustered
		{
			get
			{
				return this._isClustered != null && this._isClustered.Value;
			}
			set
			{
				this._isClustered = new bool?(value);
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x060001F3 RID: 499 RVA: 0x00007540 File Offset: 0x00005740
		public virtual bool IsClusteredConfigured
		{
			get
			{
				return this._isClustered != null;
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x060001F4 RID: 500 RVA: 0x0000754D File Offset: 0x0000574D
		// (set) Token: 0x060001F5 RID: 501 RVA: 0x00007569 File Offset: 0x00005769
		public virtual bool IsUnique
		{
			get
			{
				return this._isUnique != null && this._isUnique.Value;
			}
			set
			{
				this._isUnique = new bool?(value);
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x060001F6 RID: 502 RVA: 0x00007577 File Offset: 0x00005777
		public virtual bool IsUniqueConfigured
		{
			get
			{
				return this._isUnique != null;
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x060001F7 RID: 503 RVA: 0x00007584 File Offset: 0x00005784
		public override object TypeId
		{
			get
			{
				return global::System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(this);
			}
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x00007594 File Offset: 0x00005794
		protected virtual bool Equals(global::System.ComponentModel.DataAnnotations.Schema.IndexAttribute other)
		{
			return this._name == other._name && this._order == other._order && this._isClustered.Equals(other._isClustered) && this._isUnique.Equals(other._isUnique);
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x000075FE File Offset: 0x000057FE
		public override string ToString()
		{
			return global::System.Data.Entity.Infrastructure.Annotations.IndexAnnotationSerializer.SerializeIndexAttribute(this);
		}

		// Token: 0x060001FA RID: 506 RVA: 0x00007606 File Offset: 0x00005806
		public override bool Equals(object obj)
		{
			return obj != null && (this == obj || (!(obj.GetType() != base.GetType()) && this.Equals((global::System.ComponentModel.DataAnnotations.Schema.IndexAttribute)obj)));
		}

		// Token: 0x060001FB RID: 507 RVA: 0x00007634 File Offset: 0x00005834
		public override int GetHashCode()
		{
			return (((base.GetHashCode() * 397 ^ ((this._name != null) ? this._name.GetHashCode() : 0)) * 397 ^ this._order) * 397 ^ this._isClustered.GetHashCode()) * 397 ^ this._isUnique.GetHashCode();
		}

		// Token: 0x040000A4 RID: 164
		private string _name;

		// Token: 0x040000A5 RID: 165
		private int _order = -1;

		// Token: 0x040000A6 RID: 166
		private bool? _isClustered;

		// Token: 0x040000A7 RID: 167
		private bool? _isUnique;
	}
}
