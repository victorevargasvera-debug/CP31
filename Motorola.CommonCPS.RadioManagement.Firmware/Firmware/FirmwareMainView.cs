using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.Composition;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Motorola.CommonCPS.RadioManagement.ConfigurationEditor;
using Motorola.CommonCPS.RadioManagement.Controls;

namespace Motorola.CommonCPS.RadioManagement.Firmware
{
	// Token: 0x02000003 RID: 3
	[global::System.ComponentModel.Composition.Export("FirmwareMainView")]
	public class FirmwareMainView : global::System.Windows.Controls.UserControl, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x06000004 RID: 4 RVA: 0x0000211C File Offset: 0x0000031C
		public FirmwareMainView()
		{
			this.InitializeComponent();
		}

		// Token: 0x17000003 RID: 3
		// (set) Token: 0x06000005 RID: 5 RVA: 0x00002138 File Offset: 0x00000338
		[global::System.ComponentModel.Composition.Import]
		public global::Motorola.CommonCPS.RadioManagement.Firmware.MainViewModel ViewModel
		{
			set
			{
				short num = (short)1204096734;
				short num2 = num;
				num = (short)73207518;
				switch (num2 == num)
				{
				}
				num = (short)747962369;
				if (num != 0)
				{
				}
				num = (short)1971191808;
				if (num != 0)
				{
				}
				num = (short)1228406784;
				short num3 = num;
				base.DataContext = value;
			}
		}

		// Token: 0x06000006 RID: 6 RVA: 0x000021EC File Offset: 0x000003EC
		private void a(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 11;
			short num = (short)326002020;
			short num2 = num;
			num = (short)1581475172;
			switch (num2 == num)
			{
			}
			num = (short)17235969;
			if (num != 0)
			{
			}
			num = (short)613089280;
			if (num != 0)
			{
			}
			num = (short)1098907648;
			short num3 = num;
			this.dgrFirmwares.HideColumn(global::Motorola.CommonCPS.RadioManagement.ConfigurationEditor.Styles.d("ꏟ跡胣菥飧蛩駫觭", a_));
			this.dgrFirmwares.HideColumn(global::Motorola.CommonCPS.RadioManagement.ConfigurationEditor.Styles.d("귟跡胣菥蓧ꓩ駫菭鋯韱蛳", a_));
			this.dgrFirmwares.HideColumn(global::Motorola.CommonCPS.RadioManagement.ConfigurationEditor.Styles.d("닟蟡菣迥蟧蓩", a_));
		}

		// Token: 0x06000007 RID: 7 RVA: 0x000022E8 File Offset: 0x000004E8
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 4;
			while (!this._contentLoaded)
			{
				short num = (short)840942057;
				short num2 = num;
				num = (short)552452585;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)958791681;
					if (num != 0)
					{
					}
					num = (short)279838720;
					short num3 = num;
					num = (short)962396160;
					if (num != 0)
					{
					}
					this._contentLoaded = true;
					global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.ConfigurationEditor.Styles.d("雚닜ꯞ軠釢諤详裨엪껬胮鳰黲髴駶뫸꯺껼퇾匀戂愄渆昈䘊氌愎瀐琒瀔稖簘甚検ㄞ朠䨢圤䨦帨䨪弬䨮ਰ倲娴娶䤸吺匼娾⽀㝂橄⩆⡈≊⍌㥎㡐㙒≔祖⅘㩚ぜ㍞", a_), global::System.UriKind.Relative);
					global::System.Windows.Application.LoadComponent(this, resourceLocator);
					return;
				}
				}
			}
		}

		// Token: 0x06000008 RID: 8 RVA: 0x000023C8 File Offset: 0x000005C8
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)531824642;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)827457537;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_12F;
				case 2:
					num = (short)2138177537;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_62;
					}
					continue;
				case 3:
					num = (short)303759364;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_149;
				}
				IL_62:
				num = (short)1077280768;
				short num3 = num;
				num = (short)1661435197;
				short num4 = num;
				num = (short)39746877;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_149:
					if (connectionId == 2)
					{
						goto IL_166;
					}
					num = (short)1972699136;
					num2 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)1842937856;
					if (num != 0)
					{
					}
					if (connectionId == 1)
					{
						goto IL_F3;
					}
					num = (short)914489347;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_F3:
			this.uscFirmwares = (global::Motorola.CommonCPS.RadioManagement.Firmware.FirmwareMainView)target;
			this.uscFirmwares.Loaded += this.a;
			return;
			IL_12F:
			this._contentLoaded = true;
			return;
			IL_166:
			this.dgrFirmwares = (global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid)target;
		}

		// Token: 0x04000003 RID: 3
		internal global::Motorola.CommonCPS.RadioManagement.Firmware.FirmwareMainView uscFirmwares;

		// Token: 0x04000004 RID: 4
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid dgrFirmwares;

		// Token: 0x04000005 RID: 5
		private bool _contentLoaded;
	}
}
