using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace Infragistics.Windows.Themes
{
	// Token: 0x02000298 RID: 664
	[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
	public abstract class AssemblyResourceSetLoader
	{
		// Token: 0x17000645 RID: 1605
		// (get) Token: 0x06001A37 RID: 6711 RVA: 0x0006309F File Offset: 0x0006129F
		internal static bool LoadingResourceSets
		{
			get
			{
				return global::Infragistics.Windows.Themes.AssemblyResourceSetLoader.g_resourceSetloadingCount > 0;
			}
		}

		// Token: 0x06001A38 RID: 6712 RVA: 0x000630A9 File Offset: 0x000612A9
		public void RegisterResourceSets()
		{
			this.RegisterResourceSets(null);
		}

		// Token: 0x06001A39 RID: 6713 RVA: 0x000630B4 File Offset: 0x000612B4
		internal void RegisterResourceSets(global::System.Collections.Generic.List<string> groupingNames)
		{
			global::System.Threading.Interlocked.Increment(ref global::Infragistics.Windows.Themes.AssemblyResourceSetLoader.g_resourceSetloadingCount);
			try
			{
				if (groupingNames != null)
				{
					using (global::System.Collections.Generic.List<string>.Enumerator enumerator = groupingNames.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							string groupingName = enumerator.Current;
							this.OnRegisterResourceSets(groupingName);
						}
						goto IL_46;
					}
				}
				this.OnRegisterResourceSets(null);
				IL_46:;
			}
			finally
			{
				global::System.Threading.Interlocked.Decrement(ref global::Infragistics.Windows.Themes.AssemblyResourceSetLoader.g_resourceSetloadingCount);
			}
		}

		// Token: 0x06001A3A RID: 6714
		protected abstract void OnRegisterResourceSets(string groupingName);

		// Token: 0x06001A3B RID: 6715 RVA: 0x00063134 File Offset: 0x00061334
		protected static void RegisterResourceSet(global::Infragistics.Windows.Themes.ResourceSet resourceSet)
		{
			global::Infragistics.Windows.Themes.ThemeManager.Register(resourceSet.Theme, resourceSet.Grouping, resourceSet.Resources);
		}

		// Token: 0x06001A3C RID: 6716 RVA: 0x0006314D File Offset: 0x0006134D
		protected static void RegisterResourceSet(global::Infragistics.Windows.Themes.ResourceSetLocator locator)
		{
			global::Infragistics.Windows.Themes.ThemeManager.Register(locator);
		}

		// Token: 0x04000CEC RID: 3308
		private static int g_resourceSetloadingCount;
	}
}
