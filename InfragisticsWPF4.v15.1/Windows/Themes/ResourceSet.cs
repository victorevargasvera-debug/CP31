using System;
using System.Windows;

namespace Infragistics.Windows.Themes
{
	// Token: 0x02000270 RID: 624
	public abstract class ResourceSet : global::System.Windows.ResourceDictionary
	{
		// Token: 0x06001992 RID: 6546 RVA: 0x000626F4 File Offset: 0x000608F4
		protected ResourceSet()
		{
			global::Infragistics.Windows.Themes.ThemeManager.VerifyThemeInformationRegistered(base.GetType().Assembly);
			this._cachedResourcesReference = this.Resources;
			base.MergedDictionaries.Add(this._cachedResourcesReference);
			this.VerifyResources();
		}

		// Token: 0x06001993 RID: 6547 RVA: 0x00062730 File Offset: 0x00060930
		public override string ToString()
		{
			return string.Format("{0} for {1}", new object[]
			{
				this.Theme,
				this.Grouping
			});
		}

		// Token: 0x170005CA RID: 1482
		// (get) Token: 0x06001994 RID: 6548
		public abstract string Theme { get; }

		// Token: 0x170005CB RID: 1483
		// (get) Token: 0x06001995 RID: 6549
		public abstract string Grouping { get; }

		// Token: 0x170005CC RID: 1484
		// (get) Token: 0x06001996 RID: 6550
		public abstract global::System.Windows.ResourceDictionary Resources { get; }

		// Token: 0x06001997 RID: 6551 RVA: 0x00062764 File Offset: 0x00060964
		public static object GetSealedResource(global::System.Windows.ResourceDictionary dictionary, object key)
		{
			if (dictionary == null)
			{
				throw new global::System.ArgumentNullException("dictionary");
			}
			object obj = dictionary[key];
			if (obj is global::System.Windows.Style)
			{
				((global::System.Windows.Style)obj).Seal();
			}
			else if (obj is global::System.Windows.FrameworkTemplate)
			{
				((global::System.Windows.FrameworkTemplate)obj).Seal();
			}
			else if (obj is global::System.Windows.Freezable)
			{
				((global::System.Windows.Freezable)obj).Freeze();
			}
			return obj;
		}

		// Token: 0x06001998 RID: 6552 RVA: 0x000627C5 File Offset: 0x000609C5
		protected internal void VerifyResources()
		{
			if (this._resourcesWashed || this._cachedResourcesReference == null)
			{
				return;
			}
			if (global::Infragistics.Windows.Themes.AssemblyResourceSetLoader.LoadingResourceSets)
			{
				return;
			}
			this._resourcesWashed = true;
			global::Infragistics.Windows.Themes.ResourceWasher.ForceAutoWashResources(this._cachedResourcesReference);
		}

		// Token: 0x04000CC4 RID: 3268
		private bool _resourcesWashed;

		// Token: 0x04000CC5 RID: 3269
		private global::System.Windows.ResourceDictionary _cachedResourcesReference;
	}
}
