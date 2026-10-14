using System;
using System.Reflection;

namespace Autofac.Core
{
	// Token: 0x0200005B RID: 91
	public interface IPropertySelector
	{
		// Token: 0x06000233 RID: 563
		bool InjectProperty(global::System.Reflection.PropertyInfo propertyInfo, object instance);
	}
}
