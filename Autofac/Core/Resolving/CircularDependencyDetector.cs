using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Autofac.Core.Resolving
{
	// Token: 0x0200007C RID: 124
	internal class CircularDependencyDetector
	{
		// Token: 0x060002C7 RID: 711 RVA: 0x00008E1C File Offset: 0x0000701C
		private static string CreateDependencyGraphTo(global::Autofac.Core.IComponentRegistration registration, global::System.Collections.Generic.Stack<global::Autofac.Core.Resolving.InstanceLookup> activationStack)
		{
			if (registration == null)
			{
				throw new global::System.ArgumentNullException("registration");
			}
			if (activationStack == null)
			{
				throw new global::System.ArgumentNullException("activationStack");
			}
			string seed = global::Autofac.Core.Resolving.CircularDependencyDetector.Display(registration);
			return (from a in activationStack
			select a.ComponentRegistration).Aggregate(seed, (string current, global::Autofac.Core.IComponentRegistration requestor) => global::Autofac.Core.Resolving.CircularDependencyDetector.Display(requestor) + " -> " + current);
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x00008E96 File Offset: 0x00007096
		private static string Display(global::Autofac.Core.IComponentRegistration registration)
		{
			return registration.Activator.LimitType.FullName ?? string.Empty;
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x00008EB4 File Offset: 0x000070B4
		public static void CheckForCircularDependency(global::Autofac.Core.IComponentRegistration registration, global::System.Collections.Generic.Stack<global::Autofac.Core.Resolving.InstanceLookup> activationStack, int callDepth)
		{
			if (registration == null)
			{
				throw new global::System.ArgumentNullException("registration");
			}
			if (callDepth > 50)
			{
				throw new global::Autofac.Core.DependencyResolutionException(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Autofac.Core.Resolving.CircularDependencyDetectorResources.MaxDepthExceeded, new object[]
				{
					registration
				}));
			}
			if (activationStack.Any((global::Autofac.Core.Resolving.InstanceLookup a) => a.ComponentRegistration == registration))
			{
				throw new global::Autofac.Core.DependencyResolutionException(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Autofac.Core.Resolving.CircularDependencyDetectorResources.CircularDependency, new object[]
				{
					global::Autofac.Core.Resolving.CircularDependencyDetector.CreateDependencyGraphTo(registration, activationStack)
				}));
			}
		}

		// Token: 0x0400009D RID: 157
		private const int MaxResolveDepth = 50;
	}
}
