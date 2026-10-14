using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace CefSharp.ModelBinding
{
	// Token: 0x020000BC RID: 188
	public class BindingMemberInfo
	{
		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x060005AA RID: 1450 RVA: 0x00008CF2 File Offset: 0x00006EF2
		// (set) Token: 0x060005AB RID: 1451 RVA: 0x00008CFA File Offset: 0x00006EFA
		public string Name { get; private set; }

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x060005AC RID: 1452 RVA: 0x00008D03 File Offset: 0x00006F03
		// (set) Token: 0x060005AD RID: 1453 RVA: 0x00008D0B File Offset: 0x00006F0B
		public global::System.Type Type { get; private set; }

		// Token: 0x060005AE RID: 1454 RVA: 0x00008D14 File Offset: 0x00006F14
		public BindingMemberInfo(global::System.Reflection.PropertyInfo propertyInfo)
		{
			if (propertyInfo == null)
			{
				throw new global::System.ArgumentNullException("propertyInfo");
			}
			this.memberInfo = propertyInfo;
			this.Type = propertyInfo.PropertyType;
			this.Name = propertyInfo.Name;
		}

		// Token: 0x060005AF RID: 1455 RVA: 0x00008D4F File Offset: 0x00006F4F
		public BindingMemberInfo(global::System.Reflection.FieldInfo fieldInfo)
		{
			if (fieldInfo == null)
			{
				throw new global::System.ArgumentNullException("fieldInfo");
			}
			this.memberInfo = fieldInfo;
			this.Type = fieldInfo.FieldType;
			this.Name = fieldInfo.Name;
		}

		// Token: 0x060005B0 RID: 1456 RVA: 0x00008D8A File Offset: 0x00006F8A
		public void SetValue(object destinationObject, object newValue)
		{
			if (this.memberInfo is global::System.Reflection.PropertyInfo)
			{
				((global::System.Reflection.PropertyInfo)this.memberInfo).SetValue(destinationObject, newValue, null);
				return;
			}
			((global::System.Reflection.FieldInfo)this.memberInfo).SetValue(destinationObject, newValue);
		}

		// Token: 0x060005B1 RID: 1457 RVA: 0x00008DBF File Offset: 0x00006FBF
		public static implicit operator global::System.Reflection.MemberInfo(global::CefSharp.ModelBinding.BindingMemberInfo info)
		{
			return info.memberInfo;
		}

		// Token: 0x060005B2 RID: 1458 RVA: 0x00008DC8 File Offset: 0x00006FC8
		public static global::System.Collections.Generic.IEnumerable<global::CefSharp.ModelBinding.BindingMemberInfo> Collect(global::System.Type type)
		{
			global::System.Collections.Generic.IEnumerable<global::CefSharp.ModelBinding.BindingMemberInfo> first = from p in type.GetProperties(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public)
			where p.CanRead && p.CanWrite
			select p into property
			where !property.GetIndexParameters().Any<global::System.Reflection.ParameterInfo>()
			select new global::CefSharp.ModelBinding.BindingMemberInfo(property);
			global::System.Collections.Generic.IEnumerable<global::CefSharp.ModelBinding.BindingMemberInfo> second = from f in type.GetFields(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public)
			where !f.IsInitOnly
			select f into field
			select new global::CefSharp.ModelBinding.BindingMemberInfo(field);
			return first.Concat(second);
		}

		// Token: 0x04000352 RID: 850
		private readonly global::System.Reflection.MemberInfo memberInfo;
	}
}
