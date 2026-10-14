using System;
using System.Linq.Expressions;
using System.Reflection;
using Microsoft.Practices.Prism.Properties;

namespace Microsoft.Practices.Prism.ViewModel
{
	// Token: 0x0200008F RID: 143
	public static class PropertySupport
	{
		// Token: 0x060003D0 RID: 976 RVA: 0x0000AA88 File Offset: 0x00008C88
		public static string ExtractPropertyName<T>(global::System.Linq.Expressions.Expression<global::System.Func<T>> propertyExpression)
		{
			if (propertyExpression == null)
			{
				throw new global::System.ArgumentNullException("propertyExpression");
			}
			global::System.Linq.Expressions.MemberExpression memberExpression = propertyExpression.Body as global::System.Linq.Expressions.MemberExpression;
			if (memberExpression == null)
			{
				throw new global::System.ArgumentException(global::Microsoft.Practices.Prism.Properties.Resources.PropertySupport_NotMemberAccessExpression_Exception, "propertyExpression");
			}
			global::System.Reflection.PropertyInfo propertyInfo = memberExpression.Member as global::System.Reflection.PropertyInfo;
			if (propertyInfo == null)
			{
				throw new global::System.ArgumentException(global::Microsoft.Practices.Prism.Properties.Resources.PropertySupport_ExpressionNotProperty_Exception, "propertyExpression");
			}
			global::System.Reflection.MethodInfo getMethod = propertyInfo.GetGetMethod(true);
			if (getMethod.IsStatic)
			{
				throw new global::System.ArgumentException(global::Microsoft.Practices.Prism.Properties.Resources.PropertySupport_StaticExpression_Exception, "propertyExpression");
			}
			return memberExpression.Member.Name;
		}
	}
}
