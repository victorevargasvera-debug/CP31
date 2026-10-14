using System;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Gibraltar.Windows.UI
{
	// Token: 0x020000C8 RID: 200
	internal partial class FormUserPreferences : ApplicationSettingsBase, IDisposable
	{
		// Token: 0x170003BD RID: 957
		// (get) Token: 0x0600085C RID: 2140 RVA: 0x00012030 File Offset: 0x00010230
		// (set) Token: 0x0600085D RID: 2141 RVA: 0x00012044 File Offset: 0x00010244
		[UserScopedSetting]
		[DefaultSettingValue("0")]
		public int MainWindowHeight
		{
			get
			{
				return (int)this["MainWindowHeight"];
			}
			set
			{
				this["MainWindowHeight"] = value;
			}
		}

		// Token: 0x170003BE RID: 958
		// (get) Token: 0x0600085E RID: 2142 RVA: 0x00012058 File Offset: 0x00010258
		// (set) Token: 0x0600085F RID: 2143 RVA: 0x0001206C File Offset: 0x0001026C
		[UserScopedSetting]
		[DefaultSettingValue("0")]
		public int MainWindowWidth
		{
			get
			{
				return (int)this["MainWindowWidth"];
			}
			set
			{
				this["MainWindowWidth"] = value;
			}
		}

		// Token: 0x170003BF RID: 959
		// (get) Token: 0x06000860 RID: 2144 RVA: 0x00012080 File Offset: 0x00010280
		// (set) Token: 0x06000861 RID: 2145 RVA: 0x00012094 File Offset: 0x00010294
		[UserScopedSetting]
		[DefaultSettingValue("40")]
		public int MainWindowLeft
		{
			get
			{
				return (int)this["MainWindowLeft"];
			}
			set
			{
				this["MainWindowLeft"] = value;
			}
		}

		// Token: 0x170003C0 RID: 960
		// (get) Token: 0x06000862 RID: 2146 RVA: 0x000120A8 File Offset: 0x000102A8
		// (set) Token: 0x06000863 RID: 2147 RVA: 0x000120BC File Offset: 0x000102BC
		[UserScopedSetting]
		[DefaultSettingValue("30")]
		public int MainWindowTop
		{
			get
			{
				return (int)this["MainWindowTop"];
			}
			set
			{
				this["MainWindowTop"] = value;
			}
		}

		// Token: 0x170003C1 RID: 961
		// (get) Token: 0x06000864 RID: 2148 RVA: 0x000120D0 File Offset: 0x000102D0
		// (set) Token: 0x06000865 RID: 2149 RVA: 0x000120E4 File Offset: 0x000102E4
		[UserScopedSetting]
		[DefaultSettingValue("false")]
		public bool MainWindowMaximized
		{
			get
			{
				return (bool)this["MainWindowMaximized"];
			}
			set
			{
				this["MainWindowMaximized"] = value;
			}
		}

		// Token: 0x170003C2 RID: 962
		// (get) Token: 0x06000866 RID: 2150 RVA: 0x000120F8 File Offset: 0x000102F8
		// (set) Token: 0x06000867 RID: 2151 RVA: 0x0001210C File Offset: 0x0001030C
		[UserScopedSetting]
		[DefaultSettingValue("false")]
		public bool AutoSendSessionData
		{
			get
			{
				return (bool)this["AutoSendSessionData"];
			}
			set
			{
				this["AutoSendSessionData"] = value;
			}
		}
	}
}
