using System;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000079 RID: 121
	[global::System.Runtime.CompilerServices.NullableContext(1)]
	[global::System.Runtime.CompilerServices.Nullable(0)]
	public class DynamicValueProvider : global::Newtonsoft.Json.Serialization.IValueProvider
	{
		// Token: 0x06000666 RID: 1638 RVA: 0x0001B9F0 File Offset: 0x00019BF0
		public DynamicValueProvider(global::System.Reflection.MemberInfo memberInfo)
		{
			global::Newtonsoft.Json.Utilities.ValidationUtils.ArgumentNotNull(memberInfo, "memberInfo");
			this._memberInfo = memberInfo;
		}

		// Token: 0x06000667 RID: 1639 RVA: 0x0001BA0C File Offset: 0x00019C0C
		public void SetValue(object target, [global::System.Runtime.CompilerServices.Nullable(2)] object value)
		{
			try
			{
				if (this._setter == null)
				{
					this._setter = global::Newtonsoft.Json.Utilities.DynamicReflectionDelegateFactory.Instance.CreateSet<object>(this._memberInfo);
				}
				this._setter(target, value);
			}
			catch (global::System.Exception innerException)
			{
				throw new global::Newtonsoft.Json.JsonSerializationException("Error setting value to '{0}' on '{1}'.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, this._memberInfo.Name, target.GetType()), innerException);
			}
		}

		// Token: 0x06000668 RID: 1640 RVA: 0x0001BA80 File Offset: 0x00019C80
		[return: global::System.Runtime.CompilerServices.Nullable(2)]
		public object GetValue(object target)
		{
			object result;
			try
			{
				if (this._getter == null)
				{
					this._getter = global::Newtonsoft.Json.Utilities.DynamicReflectionDelegateFactory.Instance.CreateGet<object>(this._memberInfo);
				}
				result = this._getter(target);
			}
			catch (global::System.Exception innerException)
			{
				throw new global::Newtonsoft.Json.JsonSerializationException("Error getting value from '{0}' on '{1}'.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, this._memberInfo.Name, target.GetType()), innerException);
			}
			return result;
		}

		// Token: 0x04000223 RID: 547
		private readonly global::System.Reflection.MemberInfo _memberInfo;

		// Token: 0x04000224 RID: 548
		[global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			2,
			1,
			2
		})]
		private global::System.Func<object, object> _getter;

		// Token: 0x04000225 RID: 549
		[global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			2,
			1,
			2
		})]
		private global::System.Action<object, object> _setter;
	}
}
