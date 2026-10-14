using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Autofac.Core.Lifetime
{
	// Token: 0x0200009E RID: 158
	public class MatchingScopeLifetime : global::Autofac.Core.IComponentLifetime
	{
		// Token: 0x060003C7 RID: 967 RVA: 0x0000B48C File Offset: 0x0000968C
		public MatchingScopeLifetime(params object[] lifetimeScopeTagsToMatch)
		{
			if (lifetimeScopeTagsToMatch == null)
			{
				throw new global::System.ArgumentNullException("lifetimeScopeTagsToMatch");
			}
			this._tagsToMatch = lifetimeScopeTagsToMatch;
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x060003C8 RID: 968 RVA: 0x0000B4A9 File Offset: 0x000096A9
		public global::System.Collections.Generic.IEnumerable<object> TagsToMatch
		{
			get
			{
				return this._tagsToMatch;
			}
		}

		// Token: 0x060003C9 RID: 969 RVA: 0x0000B4B4 File Offset: 0x000096B4
		public global::Autofac.Core.ISharingLifetimeScope FindScope(global::Autofac.Core.ISharingLifetimeScope mostNestedVisibleScope)
		{
			if (mostNestedVisibleScope == null)
			{
				throw new global::System.ArgumentNullException("mostNestedVisibleScope");
			}
			for (global::Autofac.Core.ISharingLifetimeScope sharingLifetimeScope = mostNestedVisibleScope; sharingLifetimeScope != null; sharingLifetimeScope = sharingLifetimeScope.ParentLifetimeScope)
			{
				if (this._tagsToMatch.Contains(sharingLifetimeScope.Tag))
				{
					return sharingLifetimeScope;
				}
			}
			throw new global::Autofac.Core.DependencyResolutionException(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Autofac.Core.Lifetime.MatchingScopeLifetimeResources.MatchingScopeNotFound, new object[]
			{
				string.Join(", ", this._tagsToMatch)
			}));
		}

		// Token: 0x040000FA RID: 250
		private readonly object[] _tagsToMatch;
	}
}
