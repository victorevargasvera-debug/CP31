using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using Infragistics.Collections;

namespace Infragistics.Shared
{
	// Token: 0x0200008A RID: 138
	[global::System.Runtime.InteropServices.ComVisible(false)]
	public sealed class ResourceCustomizer
	{
		// Token: 0x0600057E RID: 1406 RVA: 0x000150A4 File Offset: 0x000132A4
		public ResourceCustomizer()
		{
			this.customizedStrings = new global::System.Collections.Generic.Dictionary<string, string>();
			lock (global::Infragistics.Shared.ResourceCustomizer.ResourceCustomizerListLock)
			{
				global::Infragistics.Shared.ResourceCustomizer._allCustomizers.Add(this);
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x0600057F RID: 1407 RVA: 0x000150FC File Offset: 0x000132FC
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public int CustomizedStringsVersion
		{
			get
			{
				return this.versionNumber;
			}
		}

		// Token: 0x06000580 RID: 1408 RVA: 0x00015104 File Offset: 0x00013304
		public string GetCustomizedString(string name)
		{
			string result;
			lock (global::Infragistics.Shared.ResourceCustomizer.CustomizedStringsLock)
			{
				this.customizedStrings.TryGetValue(name, out result);
			}
			return result;
		}

		// Token: 0x06000581 RID: 1409 RVA: 0x00015150 File Offset: 0x00013350
		private void RaisePropertyChangedEvent(string resourceName)
		{
			global::System.ComponentModel.PropertyChangedEventHandler resourceCustomizationChanged = this._resourceCustomizationChanged;
			if (resourceCustomizationChanged != null)
			{
				resourceCustomizationChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(resourceName));
			}
		}

		// Token: 0x06000582 RID: 1410 RVA: 0x00015174 File Offset: 0x00013374
		internal static void RefreshLocalizedResources()
		{
			global::Infragistics.Shared.ResourceCustomizer[] array = null;
			lock (global::Infragistics.Shared.ResourceCustomizer.ResourceCustomizerListLock)
			{
				global::Infragistics.Shared.ResourceCustomizer._allCustomizers.Compact();
				array = new global::Infragistics.Shared.ResourceCustomizer[global::Infragistics.Shared.ResourceCustomizer._allCustomizers.Count];
				global::Infragistics.Shared.ResourceCustomizer._allCustomizers.CopyTo(array, 0);
			}
			foreach (global::Infragistics.Shared.ResourceCustomizer resourceCustomizer in array)
			{
				resourceCustomizer.RaisePropertyChangedEvent(null);
			}
		}

		// Token: 0x06000583 RID: 1411 RVA: 0x000151F8 File Offset: 0x000133F8
		public void ResetAllCustomizedStrings()
		{
			lock (global::Infragistics.Shared.ResourceCustomizer.CustomizedStringsLock)
			{
				this.customizedStrings.Clear();
			}
			this.versionNumber++;
			this.RaisePropertyChangedEvent(null);
		}

		// Token: 0x06000584 RID: 1412 RVA: 0x00015254 File Offset: 0x00013454
		public void ResetCustomizedString(string name)
		{
			this.SetCustomizedString(name, null);
		}

		// Token: 0x06000585 RID: 1413 RVA: 0x00015260 File Offset: 0x00013460
		public void SetCustomizedString(string name, string customizedText)
		{
			lock (global::Infragistics.Shared.ResourceCustomizer.CustomizedStringsLock)
			{
				if (customizedText == null)
				{
					this.customizedStrings.Remove(name);
				}
				else
				{
					this.customizedStrings[name] = customizedText;
				}
			}
			this.versionNumber++;
			this.RaisePropertyChangedEvent(name);
		}

		// Token: 0x1400000C RID: 12
		// (add) Token: 0x06000586 RID: 1414 RVA: 0x000152D0 File Offset: 0x000134D0
		// (remove) Token: 0x06000587 RID: 1415 RVA: 0x00015320 File Offset: 0x00013520
		public event global::System.ComponentModel.PropertyChangedEventHandler ResourceCustomizationChanged
		{
			add
			{
				lock (global::Infragistics.Shared.ResourceCustomizer.ResourceCustomizationChangedLock)
				{
					this._resourceCustomizationChanged = (global::System.ComponentModel.PropertyChangedEventHandler)global::System.Delegate.Combine(this._resourceCustomizationChanged, value);
				}
			}
			remove
			{
				lock (global::Infragistics.Shared.ResourceCustomizer.ResourceCustomizationChangedLock)
				{
					this._resourceCustomizationChanged = (global::System.ComponentModel.PropertyChangedEventHandler)global::System.Delegate.Remove(this._resourceCustomizationChanged, value);
				}
			}
		}

		// Token: 0x040001F5 RID: 501
		private readonly global::System.Collections.Generic.Dictionary<string, string> customizedStrings;

		// Token: 0x040001F6 RID: 502
		private static readonly object CustomizedStringsLock = new object();

		// Token: 0x040001F7 RID: 503
		private static readonly object ResourceCustomizerListLock = new object();

		// Token: 0x040001F8 RID: 504
		private static global::Infragistics.Collections.WeakList<global::Infragistics.Shared.ResourceCustomizer> _allCustomizers = new global::Infragistics.Collections.WeakList<global::Infragistics.Shared.ResourceCustomizer>();

		// Token: 0x040001F9 RID: 505
		private int versionNumber;

		// Token: 0x040001FA RID: 506
		private global::System.ComponentModel.PropertyChangedEventHandler _resourceCustomizationChanged;

		// Token: 0x040001FB RID: 507
		private static readonly object ResourceCustomizationChangedLock = new object();
	}
}
