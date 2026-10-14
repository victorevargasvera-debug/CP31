using System;
using System.Collections.Generic;
using System.Linq;
using Autofac.Core.Lifetime;

namespace Autofac.Core
{
	// Token: 0x0200005E RID: 94
	public static class ComponentRegistrationExtensions
	{
		// Token: 0x0600023B RID: 571 RVA: 0x000084C8 File Offset: 0x000066C8
		public static global::System.Collections.Generic.IEnumerable<object> MatchingLifetimeScopeTags(this global::Autofac.Core.IComponentRegistration registration)
		{
			if (registration == null)
			{
				throw new global::System.ArgumentNullException("registration");
			}
			global::Autofac.Core.Lifetime.MatchingScopeLifetime matchingScopeLifetime = registration.Lifetime as global::Autofac.Core.Lifetime.MatchingScopeLifetime;
			if (matchingScopeLifetime != null)
			{
				return matchingScopeLifetime.TagsToMatch;
			}
			return global::System.Linq.Enumerable.Empty<object>();
		}
	}
}
