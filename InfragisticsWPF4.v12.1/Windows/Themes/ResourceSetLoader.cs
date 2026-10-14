using System;
using System.ComponentModel;
using System.Windows;

namespace Infragistics.Windows.Themes
{
	// Token: 0x020001FC RID: 508
	public class ResourceSetLoader : global::System.Windows.ResourceDictionary, global::System.ComponentModel.ISupportInitialize
	{
		// Token: 0x06001329 RID: 4905 RVA: 0x00046454 File Offset: 0x00044654
		public ResourceSetLoader()
		{
		}

		// Token: 0x0600132A RID: 4906 RVA: 0x0004645C File Offset: 0x0004465C
		internal ResourceSetLoader(global::Infragistics.Windows.Themes.ResourceSetLocator locator)
		{
			this.Locator = locator;
		}

		// Token: 0x17000469 RID: 1129
		// (get) Token: 0x0600132B RID: 4907 RVA: 0x0004646B File Offset: 0x0004466B
		// (set) Token: 0x0600132C RID: 4908 RVA: 0x00046473 File Offset: 0x00044673
		[global::System.ComponentModel.DefaultValue(null)]
		public global::Infragistics.Windows.Themes.ResourceSetLocator Locator
		{
			get
			{
				return this._locator;
			}
			set
			{
				if (value != this._locator)
				{
					global::Infragistics.Windows.Utilities.VerifyCanBeModified(this);
					this._locator = value;
					this.OnCriteriaChanged();
				}
			}
		}

		// Token: 0x0600132D RID: 4909 RVA: 0x00046494 File Offset: 0x00044694
		private void OnCriteriaChanged()
		{
			if (this._initializing)
			{
				return;
			}
			base.Clear();
			base.MergedDictionaries.Clear();
			if (this._locator == null)
			{
				return;
			}
			global::System.Windows.ResourceDictionary item = global::Infragistics.Windows.Utilities.CreateResourceSetDictionary(this._locator.Assembly, this._locator.ResourcePath);
			base.MergedDictionaries.Add(item);
			global::Infragistics.Windows.Themes.ResourceWasher.ForceAutoWashResources(this);
		}

		// Token: 0x0600132E RID: 4910 RVA: 0x000464F2 File Offset: 0x000446F2
		public new void BeginInit()
		{
			this._initializing = true;
			base.BeginInit();
		}

		// Token: 0x0600132F RID: 4911 RVA: 0x00046501 File Offset: 0x00044701
		public new void EndInit()
		{
			this._initializing = false;
			this.OnCriteriaChanged();
			base.EndInit();
		}

		// Token: 0x040009E1 RID: 2529
		private bool _initializing;

		// Token: 0x040009E2 RID: 2530
		private global::Infragistics.Windows.Themes.ResourceSetLocator _locator;
	}
}
