using System;
using System.ComponentModel;
using System.Windows;

namespace Infragistics.Windows.Themes
{
	// Token: 0x0200022C RID: 556
	public class ResourceSetLoader : global::System.Windows.ResourceDictionary, global::System.ComponentModel.ISupportInitialize
	{
		// Token: 0x06001506 RID: 5382 RVA: 0x0004C164 File Offset: 0x0004A364
		public ResourceSetLoader()
		{
		}

		// Token: 0x06001507 RID: 5383 RVA: 0x0004C16C File Offset: 0x0004A36C
		internal ResourceSetLoader(global::Infragistics.Windows.Themes.ResourceSetLocator locator)
		{
			this.Locator = locator;
		}

		// Token: 0x170004DE RID: 1246
		// (get) Token: 0x06001508 RID: 5384 RVA: 0x0004C17B File Offset: 0x0004A37B
		// (set) Token: 0x06001509 RID: 5385 RVA: 0x0004C183 File Offset: 0x0004A383
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

		// Token: 0x0600150A RID: 5386 RVA: 0x0004C1A4 File Offset: 0x0004A3A4
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

		// Token: 0x0600150B RID: 5387 RVA: 0x0004C202 File Offset: 0x0004A402
		public new void BeginInit()
		{
			this._initializing = true;
			base.BeginInit();
		}

		// Token: 0x0600150C RID: 5388 RVA: 0x0004C211 File Offset: 0x0004A411
		public new void EndInit()
		{
			this._initializing = false;
			this.OnCriteriaChanged();
			base.EndInit();
		}

		// Token: 0x04000B2C RID: 2860
		private bool _initializing;

		// Token: 0x04000B2D RID: 2861
		private global::Infragistics.Windows.Themes.ResourceSetLocator _locator;
	}
}
