using System;
using System.Windows;

namespace Infragistics.Windows.Themes
{
	// Token: 0x0200023B RID: 571
	public abstract class ResourceSet : global::System.Windows.ResourceDictionary
	{
		// Token: 0x06001790 RID: 6032 RVA: 0x0005BC7C File Offset: 0x00059E7C
		protected ResourceSet()
		{
			global::Infragistics.Windows.Themes.ThemeManager.VerifyThemeInformationRegistered(base.GetType().Assembly);
			this._cachedResourcesReference = this.Resources;
			base.MergedDictionaries.Add(this._cachedResourcesReference);
			this.VerifyResources();
		}

		// Token: 0x06001791 RID: 6033 RVA: 0x0005BCB8 File Offset: 0x00059EB8
		public override string ToString()
		{
			return string.Format("{0} for {1}", new object[]
			{
				this.Theme,
				this.Grouping
			});
		}

		// Token: 0x1700054D RID: 1357
		// (get) Token: 0x06001792 RID: 6034
		public abstract string Theme { get; }

		// Token: 0x1700054E RID: 1358
		// (get) Token: 0x06001793 RID: 6035
		public abstract string Grouping { get; }

		// Token: 0x1700054F RID: 1359
		// (get) Token: 0x06001794 RID: 6036
		public abstract global::System.Windows.ResourceDictionary Resources { get; }

		// Token: 0x06001795 RID: 6037 RVA: 0x0005BCEC File Offset: 0x00059EEC
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

		// Token: 0x06001796 RID: 6038 RVA: 0x0005BD4D File Offset: 0x00059F4D
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

		// Token: 0x04000B61 RID: 2913
		private bool _resourcesWashed;

		// Token: 0x04000B62 RID: 2914
		private global::System.Windows.ResourceDictionary _cachedResourcesReference;
	}
}
