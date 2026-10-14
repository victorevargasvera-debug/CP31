using System;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x020000A0 RID: 160
	[global::System.Runtime.CompilerServices.NullableContext(1)]
	[global::System.Runtime.CompilerServices.Nullable(0)]
	public class ReflectionValueProvider : global::Newtonsoft.Json.Serialization.IValueProvider
	{
		// Token: 0x06000835 RID: 2101 RVA: 0x00023C11 File Offset: 0x00021E11
		public ReflectionValueProvider(global::System.Reflection.MemberInfo memberInfo)
		{
			global::Newtonsoft.Json.Utilities.ValidationUtils.ArgumentNotNull(memberInfo, "memberInfo");
			this._memberInfo = memberInfo;
		}

		// Token: 0x06000836 RID: 2102 RVA: 0x00023C2C File Offset: 0x00021E2C
		public void SetValue(object target, [global::System.Runtime.CompilerServices.Nullable(2)] object value)
		{
			try
			{
				global::Newtonsoft.Json.Utilities.ReflectionUtils.SetMemberValue(this._memberInfo, target, value);
			}
			catch (global::System.Exception innerException)
			{
				throw new global::Newtonsoft.Json.JsonSerializationException("Error setting value to '{0}' on '{1}'.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, this._memberInfo.Name, target.GetType()), innerException);
			}
		}

		// Token: 0x06000837 RID: 2103 RVA: 0x00023C80 File Offset: 0x00021E80
		[return: global::System.Runtime.CompilerServices.Nullable(2)]
		public object GetValue(object target)
		{
			object memberValue;
			try
			{
				global::System.Reflection.PropertyInfo propertyInfo = this._memberInfo as global::System.Reflection.PropertyInfo;
				if (propertyInfo != null && propertyInfo.PropertyType.IsByRef)
				{
					throw new global::System.InvalidOperationException("Could not create getter for {0}. ByRef return values are not supported.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, propertyInfo));
				}
				memberValue = global::Newtonsoft.Json.Utilities.ReflectionUtils.GetMemberValue(this._memberInfo, target);
			}
			catch (global::System.Exception innerException)
			{
				throw new global::Newtonsoft.Json.JsonSerializationException("Error getting value from '{0}' on '{1}'.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, this._memberInfo.Name, target.GetType()), innerException);
			}
			return memberValue;
		}

		// Token: 0x040002C9 RID: 713
		private readonly global::System.Reflection.MemberInfo _memberInfo;
	}
}
