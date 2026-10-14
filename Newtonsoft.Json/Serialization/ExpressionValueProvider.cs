using System;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x0200007C RID: 124
	[global::System.Runtime.CompilerServices.NullableContext(1)]
	[global::System.Runtime.CompilerServices.Nullable(0)]
	public class ExpressionValueProvider : global::Newtonsoft.Json.Serialization.IValueProvider
	{
		// Token: 0x06000675 RID: 1653 RVA: 0x0001BB81 File Offset: 0x00019D81
		public ExpressionValueProvider(global::System.Reflection.MemberInfo memberInfo)
		{
			global::Newtonsoft.Json.Utilities.ValidationUtils.ArgumentNotNull(memberInfo, "memberInfo");
			this._memberInfo = memberInfo;
		}

		// Token: 0x06000676 RID: 1654 RVA: 0x0001BB9C File Offset: 0x00019D9C
		public void SetValue(object target, [global::System.Runtime.CompilerServices.Nullable(2)] object value)
		{
			try
			{
				if (this._setter == null)
				{
					this._setter = global::Newtonsoft.Json.Utilities.ExpressionReflectionDelegateFactory.Instance.CreateSet<object>(this._memberInfo);
				}
				this._setter(target, value);
			}
			catch (global::System.Exception innerException)
			{
				throw new global::Newtonsoft.Json.JsonSerializationException("Error setting value to '{0}' on '{1}'.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, this._memberInfo.Name, target.GetType()), innerException);
			}
		}

		// Token: 0x06000677 RID: 1655 RVA: 0x0001BC10 File Offset: 0x00019E10
		[return: global::System.Runtime.CompilerServices.Nullable(2)]
		public object GetValue(object target)
		{
			object result;
			try
			{
				if (this._getter == null)
				{
					this._getter = global::Newtonsoft.Json.Utilities.ExpressionReflectionDelegateFactory.Instance.CreateGet<object>(this._memberInfo);
				}
				result = this._getter(target);
			}
			catch (global::System.Exception innerException)
			{
				throw new global::Newtonsoft.Json.JsonSerializationException("Error getting value from '{0}' on '{1}'.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, this._memberInfo.Name, target.GetType()), innerException);
			}
			return result;
		}

		// Token: 0x0400022E RID: 558
		private readonly global::System.Reflection.MemberInfo _memberInfo;

		// Token: 0x0400022F RID: 559
		[global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			2,
			1,
			2
		})]
		private global::System.Func<object, object> _getter;

		// Token: 0x04000230 RID: 560
		[global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			2,
			1,
			2
		})]
		private global::System.Action<object, object> _setter;
	}
}
