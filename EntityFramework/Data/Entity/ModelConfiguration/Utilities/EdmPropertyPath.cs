using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Utilities;
using System.Linq;
using System.Text;

namespace System.Data.Entity.ModelConfiguration.Utilities
{
	// Token: 0x020001BD RID: 445
	internal class EdmPropertyPath : global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>, global::System.Collections.IEnumerable
	{
		// Token: 0x060017B2 RID: 6066 RVA: 0x0003F5FC File Offset: 0x0003D7FC
		public EdmPropertyPath(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> components)
		{
			this._components.AddRange(components);
		}

		// Token: 0x060017B3 RID: 6067 RVA: 0x0003F61B File Offset: 0x0003D81B
		public EdmPropertyPath(global::System.Data.Entity.Core.Metadata.Edm.EdmProperty component)
		{
			this._components.Add(component);
		}

		// Token: 0x060017B4 RID: 6068 RVA: 0x0003F63A File Offset: 0x0003D83A
		private EdmPropertyPath()
		{
		}

		// Token: 0x170005C8 RID: 1480
		// (get) Token: 0x060017B5 RID: 6069 RVA: 0x0003F64D File Offset: 0x0003D84D
		public static global::System.Data.Entity.ModelConfiguration.Utilities.EdmPropertyPath Empty
		{
			get
			{
				return global::System.Data.Entity.ModelConfiguration.Utilities.EdmPropertyPath._empty;
			}
		}

		// Token: 0x060017B6 RID: 6070 RVA: 0x0003F654 File Offset: 0x0003D854
		public override string ToString()
		{
			global::System.Text.StringBuilder propertyPathName = new global::System.Text.StringBuilder();
			this._components.Each(delegate(global::System.Data.Entity.Core.Metadata.Edm.EdmProperty pi)
			{
				propertyPathName.Append(pi.Name);
				propertyPathName.Append('.');
			});
			return propertyPathName.ToString(0, propertyPathName.Length - 1);
		}

		// Token: 0x060017B7 RID: 6071 RVA: 0x0003F6A2 File Offset: 0x0003D8A2
		public bool Equals(global::System.Data.Entity.ModelConfiguration.Utilities.EdmPropertyPath other)
		{
			if (other == null)
			{
				return false;
			}
			if (this == other)
			{
				return true;
			}
			return this._components.SequenceEqual(other._components, (global::System.Data.Entity.Core.Metadata.Edm.EdmProperty p1, global::System.Data.Entity.Core.Metadata.Edm.EdmProperty p2) => p1 == p2);
		}

		// Token: 0x060017B8 RID: 6072 RVA: 0x0003F6DF File Offset: 0x0003D8DF
		public override bool Equals(object obj)
		{
			return obj != null && (this == obj || (!(obj.GetType() != typeof(global::System.Data.Entity.ModelConfiguration.Utilities.EdmPropertyPath)) && this.Equals((global::System.Data.Entity.ModelConfiguration.Utilities.EdmPropertyPath)obj)));
		}

		// Token: 0x060017B9 RID: 6073 RVA: 0x0003F711 File Offset: 0x0003D911
		public override int GetHashCode()
		{
			return this._components.Aggregate(0, (int t, global::System.Data.Entity.Core.Metadata.Edm.EdmProperty n) => t + n.GetHashCode());
		}

		// Token: 0x060017BA RID: 6074 RVA: 0x0003F73E File Offset: 0x0003D93E
		public static bool operator ==(global::System.Data.Entity.ModelConfiguration.Utilities.EdmPropertyPath left, global::System.Data.Entity.ModelConfiguration.Utilities.EdmPropertyPath right)
		{
			return object.Equals(left, right);
		}

		// Token: 0x060017BB RID: 6075 RVA: 0x0003F747 File Offset: 0x0003D947
		public static bool operator !=(global::System.Data.Entity.ModelConfiguration.Utilities.EdmPropertyPath left, global::System.Data.Entity.ModelConfiguration.Utilities.EdmPropertyPath right)
		{
			return !object.Equals(left, right);
		}

		// Token: 0x060017BC RID: 6076 RVA: 0x0003F753 File Offset: 0x0003D953
		global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>.GetEnumerator()
		{
			return this._components.GetEnumerator();
		}

		// Token: 0x060017BD RID: 6077 RVA: 0x0003F765 File Offset: 0x0003D965
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return this._components.GetEnumerator();
		}

		// Token: 0x04000A42 RID: 2626
		private static readonly global::System.Data.Entity.ModelConfiguration.Utilities.EdmPropertyPath _empty = new global::System.Data.Entity.ModelConfiguration.Utilities.EdmPropertyPath();

		// Token: 0x04000A43 RID: 2627
		private readonly global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> _components = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>();
	}
}
