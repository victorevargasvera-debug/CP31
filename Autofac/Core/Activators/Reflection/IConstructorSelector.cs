using System;
using System.Collections.Generic;

namespace Autofac.Core.Activators.Reflection
{
	// Token: 0x020000AB RID: 171
	public interface IConstructorSelector
	{
		// Token: 0x060003F3 RID: 1011
		global::Autofac.Core.Activators.Reflection.ConstructorParameterBinding SelectConstructorBinding(global::Autofac.Core.Activators.Reflection.ConstructorParameterBinding[] constructorBindings, global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Parameter> parameters);
	}
}
