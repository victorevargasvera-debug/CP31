using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity.Utilities;
using System.Linq;
using System.Reflection;
using System.Text;

namespace System.Data.Entity.ModelConfiguration.Utilities
{
	// Token: 0x020001BF RID: 447
	internal class PropertyPath : global::System.Collections.Generic.IEnumerable<global::System.Reflection.PropertyInfo>, global::System.Collections.IEnumerable
	{
		// Token: 0x060017C6 RID: 6086 RVA: 0x0003F90A File Offset: 0x0003DB0A
		public PropertyPath(global::System.Collections.Generic.IEnumerable<global::System.Reflection.PropertyInfo> components)
		{
			this._components.AddRange(components);
		}

		// Token: 0x060017C7 RID: 6087 RVA: 0x0003F929 File Offset: 0x0003DB29
		public PropertyPath(global::System.Reflection.PropertyInfo component)
		{
			this._components.Add(component);
		}

		// Token: 0x060017C8 RID: 6088 RVA: 0x0003F948 File Offset: 0x0003DB48
		private PropertyPath()
		{
		}

		// Token: 0x170005C9 RID: 1481
		// (get) Token: 0x060017C9 RID: 6089 RVA: 0x0003F95B File Offset: 0x0003DB5B
		public int Count
		{
			get
			{
				return this._components.Count;
			}
		}

		// Token: 0x170005CA RID: 1482
		// (get) Token: 0x060017CA RID: 6090 RVA: 0x0003F968 File Offset: 0x0003DB68
		public static global::System.Data.Entity.ModelConfiguration.Utilities.PropertyPath Empty
		{
			get
			{
				return global::System.Data.Entity.ModelConfiguration.Utilities.PropertyPath._empty;
			}
		}

		// Token: 0x170005CB RID: 1483
		public global::System.Reflection.PropertyInfo this[int index]
		{
			get
			{
				return this._components[index];
			}
		}

		// Token: 0x060017CC RID: 6092 RVA: 0x0003F980 File Offset: 0x0003DB80
		public override string ToString()
		{
			global::System.Text.StringBuilder propertyPathName = new global::System.Text.StringBuilder();
			this._components.Each(delegate(global::System.Reflection.PropertyInfo pi)
			{
				propertyPathName.Append(pi.Name);
				propertyPathName.Append('.');
			});
			return propertyPathName.ToString(0, propertyPathName.Length - 1);
		}

		// Token: 0x060017CD RID: 6093 RVA: 0x0003F9CE File Offset: 0x0003DBCE
		public bool Equals(global::System.Data.Entity.ModelConfiguration.Utilities.PropertyPath other)
		{
			if (other == null)
			{
				return false;
			}
			if (this == other)
			{
				return true;
			}
			return this._components.SequenceEqual(other._components, (global::System.Reflection.PropertyInfo p1, global::System.Reflection.PropertyInfo p2) => p1.IsSameAs(p2));
		}

		// Token: 0x060017CE RID: 6094 RVA: 0x0003FA0B File Offset: 0x0003DC0B
		public override bool Equals(object obj)
		{
			return obj != null && (this == obj || (!(obj.GetType() != typeof(global::System.Data.Entity.ModelConfiguration.Utilities.PropertyPath)) && this.Equals((global::System.Data.Entity.ModelConfiguration.Utilities.PropertyPath)obj)));
		}

		// Token: 0x060017CF RID: 6095 RVA: 0x0003FA3D File Offset: 0x0003DC3D
		public override int GetHashCode()
		{
			return this._components.Aggregate(0, (int t, global::System.Reflection.PropertyInfo n) => t ^ n.DeclaringType.GetHashCode() * n.Name.GetHashCode() * 397);
		}

		// Token: 0x060017D0 RID: 6096 RVA: 0x0003FA6A File Offset: 0x0003DC6A
		public static bool operator ==(global::System.Data.Entity.ModelConfiguration.Utilities.PropertyPath left, global::System.Data.Entity.ModelConfiguration.Utilities.PropertyPath right)
		{
			return object.Equals(left, right);
		}

		// Token: 0x060017D1 RID: 6097 RVA: 0x0003FA73 File Offset: 0x0003DC73
		public static bool operator !=(global::System.Data.Entity.ModelConfiguration.Utilities.PropertyPath left, global::System.Data.Entity.ModelConfiguration.Utilities.PropertyPath right)
		{
			return !object.Equals(left, right);
		}

		// Token: 0x060017D2 RID: 6098 RVA: 0x0003FA7F File Offset: 0x0003DC7F
		global::System.Collections.Generic.IEnumerator<global::System.Reflection.PropertyInfo> global::System.Collections.Generic.IEnumerable<global::System.Reflection.PropertyInfo>.GetEnumerator()
		{
			return this._components.GetEnumerator();
		}

		// Token: 0x060017D3 RID: 6099 RVA: 0x0003FA91 File Offset: 0x0003DC91
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return this._components.GetEnumerator();
		}

		// Token: 0x04000A45 RID: 2629
		private static readonly global::System.Data.Entity.ModelConfiguration.Utilities.PropertyPath _empty = new global::System.Data.Entity.ModelConfiguration.Utilities.PropertyPath();

		// Token: 0x04000A46 RID: 2630
		private readonly global::System.Collections.Generic.List<global::System.Reflection.PropertyInfo> _components = new global::System.Collections.Generic.List<global::System.Reflection.PropertyInfo>();
	}
}
