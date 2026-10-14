using System;
using System.Collections;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace Infragistics.Shared
{
	// Token: 0x02000073 RID: 115
	[global::System.Runtime.InteropServices.ComVisible(false)]
	public sealed class ResourceCustomizer
	{
		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x060004BD RID: 1213 RVA: 0x0001288C File Offset: 0x00010A8C
		private global::System.Collections.Hashtable CustomizedStrings
		{
			get
			{
				if (this.customizedStrings == null)
				{
					this.customizedStrings = new global::System.Collections.Hashtable();
				}
				return this.customizedStrings;
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x060004BE RID: 1214 RVA: 0x000128A7 File Offset: 0x00010AA7
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public int CustomizedStringsVersion
		{
			get
			{
				return this.versionNumber;
			}
		}

		// Token: 0x060004BF RID: 1215 RVA: 0x000128AF File Offset: 0x00010AAF
		public string GetCustomizedString(string name)
		{
			if (this.CustomizedStrings.Contains(name))
			{
				return this.CustomizedStrings[name] as string;
			}
			return null;
		}

		// Token: 0x060004C0 RID: 1216 RVA: 0x000128D2 File Offset: 0x00010AD2
		private void RaisePropertyChangedEvent(string resourceName)
		{
			if (this.ResourceCustomizationChanged != null)
			{
				this.ResourceCustomizationChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(resourceName));
			}
		}

		// Token: 0x060004C1 RID: 1217 RVA: 0x000128EE File Offset: 0x00010AEE
		public void ResetAllCustomizedStrings()
		{
			if (this.customizedStrings != null)
			{
				this.customizedStrings.Clear();
				this.RaisePropertyChangedEvent(null);
				this.versionNumber++;
			}
		}

		// Token: 0x060004C2 RID: 1218 RVA: 0x00012918 File Offset: 0x00010B18
		public void ResetCustomizedString(string name)
		{
			this.SetCustomizedString(name, null);
		}

		// Token: 0x060004C3 RID: 1219 RVA: 0x00012924 File Offset: 0x00010B24
		public void SetCustomizedString(string name, string customizedText)
		{
			if (this.CustomizedStrings.Contains(name))
			{
				this.CustomizedStrings.Remove(name);
			}
			if (customizedText != null)
			{
				this.CustomizedStrings.Add(name, customizedText);
			}
			this.RaisePropertyChangedEvent(name);
			this.versionNumber++;
		}

		// Token: 0x1400000C RID: 12
		// (add) Token: 0x060004C4 RID: 1220 RVA: 0x00012970 File Offset: 0x00010B70
		// (remove) Token: 0x060004C5 RID: 1221 RVA: 0x000129A8 File Offset: 0x00010BA8
		public event global::System.ComponentModel.PropertyChangedEventHandler ResourceCustomizationChanged;

		// Token: 0x04000184 RID: 388
		private global::System.Collections.Hashtable customizedStrings;

		// Token: 0x04000185 RID: 389
		private int versionNumber;
	}
}
