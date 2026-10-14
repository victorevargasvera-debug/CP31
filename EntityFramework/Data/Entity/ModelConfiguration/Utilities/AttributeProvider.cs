using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;

namespace System.Data.Entity.ModelConfiguration.Utilities
{
	// Token: 0x020001BE RID: 446
	internal class AttributeProvider
	{
		// Token: 0x060017BF RID: 6079 RVA: 0x0003F784 File Offset: 0x0003D984
		public virtual global::System.Collections.Generic.IEnumerable<global::System.Attribute> GetAttributes(global::System.Reflection.MemberInfo memberInfo)
		{
			global::System.Type type = memberInfo as global::System.Type;
			if (type != null)
			{
				return this.GetAttributes(type);
			}
			return this.GetAttributes((global::System.Reflection.PropertyInfo)memberInfo);
		}

		// Token: 0x060017C0 RID: 6080 RVA: 0x0003F7B8 File Offset: 0x0003D9B8
		public virtual global::System.Collections.Generic.IEnumerable<global::System.Attribute> GetAttributes(global::System.Type type)
		{
			global::System.Collections.Generic.List<global::System.Attribute> attrs = new global::System.Collections.Generic.List<global::System.Attribute>(global::System.Data.Entity.ModelConfiguration.Utilities.AttributeProvider.GetTypeDescriptor(type).GetAttributes().Cast<global::System.Attribute>());
			global::System.Collections.Generic.IEnumerable<global::System.Attribute> customAttributes = type.GetCustomAttributes(true);
			global::System.Func<global::System.Attribute, bool> <>9__0;
			global::System.Func<global::System.Attribute, bool> predicate;
			if ((predicate = <>9__0) == null)
			{
				predicate = (<>9__0 = ((global::System.Attribute a) => a.GetType().FullName.Equals("System.Data.Services.Common.EntityPropertyMappingAttribute", global::System.StringComparison.Ordinal) && !attrs.Contains(a)));
			}
			foreach (global::System.Attribute item in customAttributes.Where(predicate))
			{
				attrs.Add(item);
			}
			return attrs;
		}

		// Token: 0x060017C1 RID: 6081 RVA: 0x0003F858 File Offset: 0x0003DA58
		public virtual global::System.Collections.Generic.IEnumerable<global::System.Attribute> GetAttributes(global::System.Reflection.PropertyInfo propertyInfo)
		{
			return this._discoveredAttributes.GetOrAdd(propertyInfo, delegate(global::System.Reflection.PropertyInfo pi)
			{
				global::System.ComponentModel.PropertyDescriptor propertyDescriptor = global::System.Data.Entity.ModelConfiguration.Utilities.AttributeProvider.GetTypeDescriptor(pi.DeclaringType).GetProperties()[pi.Name];
				global::System.Collections.Generic.IEnumerable<global::System.Attribute> enumerable = (propertyDescriptor != null) ? propertyDescriptor.Attributes.Cast<global::System.Attribute>() : pi.GetCustomAttributes(true);
				global::System.Collections.Generic.ICollection<global::System.Attribute> collection = (global::System.Collections.Generic.ICollection<global::System.Attribute>)this.GetAttributes(pi.PropertyType);
				if (collection.Count > 0)
				{
					enumerable = enumerable.Except(collection);
				}
				return enumerable.ToList<global::System.Attribute>();
			});
		}

		// Token: 0x060017C2 RID: 6082 RVA: 0x0003F872 File Offset: 0x0003DA72
		private static global::System.ComponentModel.ICustomTypeDescriptor GetTypeDescriptor(global::System.Type type)
		{
			return new global::System.ComponentModel.DataAnnotations.AssociatedMetadataTypeTypeDescriptionProvider(type).GetTypeDescriptor(type);
		}

		// Token: 0x060017C3 RID: 6083 RVA: 0x0003F880 File Offset: 0x0003DA80
		public virtual void ClearCache()
		{
			this._discoveredAttributes.Clear();
		}

		// Token: 0x04000A44 RID: 2628
		private readonly global::System.Collections.Concurrent.ConcurrentDictionary<global::System.Reflection.PropertyInfo, global::System.Collections.Generic.IEnumerable<global::System.Attribute>> _discoveredAttributes = new global::System.Collections.Concurrent.ConcurrentDictionary<global::System.Reflection.PropertyInfo, global::System.Collections.Generic.IEnumerable<global::System.Attribute>>();
	}
}
