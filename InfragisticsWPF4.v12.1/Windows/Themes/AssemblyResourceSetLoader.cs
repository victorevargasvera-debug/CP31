using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace Infragistics.Windows.Themes
{
	// Token: 0x0200025F RID: 607
	[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
	public abstract class AssemblyResourceSetLoader
	{
		// Token: 0x170005BE RID: 1470
		// (get) Token: 0x06001827 RID: 6183 RVA: 0x0005C593 File Offset: 0x0005A793
		internal static bool LoadingResourceSets
		{
			get
			{
				return global::Infragistics.Windows.Themes.AssemblyResourceSetLoader.g_resourceSetloadingCount > 0;
			}
		}

		// Token: 0x06001828 RID: 6184 RVA: 0x0005C59D File Offset: 0x0005A79D
		public void RegisterResourceSets()
		{
			this.RegisterResourceSets(null);
		}

		// Token: 0x06001829 RID: 6185 RVA: 0x0005C5A8 File Offset: 0x0005A7A8
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

		// Token: 0x0600182A RID: 6186
		protected abstract void OnRegisterResourceSets(string groupingName);

		// Token: 0x0600182B RID: 6187 RVA: 0x0005C628 File Offset: 0x0005A828
		protected static void RegisterResourceSet(global::Infragistics.Windows.Themes.ResourceSet resourceSet)
		{
			global::Infragistics.Windows.Themes.ThemeManager.Register(resourceSet.Theme, resourceSet.Grouping, resourceSet.Resources);
		}

		// Token: 0x0600182C RID: 6188 RVA: 0x0005C641 File Offset: 0x0005A841
		protected static void RegisterResourceSet(global::Infragistics.Windows.Themes.ResourceSetLocator locator)
		{
			global::Infragistics.Windows.Themes.ThemeManager.Register(locator);
		}

		// Token: 0x04000B87 RID: 2951
		private static int g_resourceSetloadingCount;
	}
}
