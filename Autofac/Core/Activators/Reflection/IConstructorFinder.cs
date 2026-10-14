using System;
using System.Reflection;

namespace Autofac.Core.Activators.Reflection
{
	// Token: 0x020000AA RID: 170
	public interface IConstructorFinder
	{
		// Token: 0x060003F2 RID: 1010
		global::System.Reflection.ConstructorInfo[] FindConstructors(global::System.Type targetType);
	}
}
