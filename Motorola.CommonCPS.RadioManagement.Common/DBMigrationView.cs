using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Markup;
using Motorola.CommonCPS.RadioManagement.Controls;

namespace Motorola.CommonCPS.RadioManagement.Common
{
	// Token: 0x02000011 RID: 17
	public class DBMigrationView : global::System.Windows.Controls.UserControl, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x06000039 RID: 57 RVA: 0x000056B8 File Offset: 0x000038B8
		public DBMigrationView()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600003A RID: 58 RVA: 0x000056D4 File Offset: 0x000038D4
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			int a_ = 4;
			short num = (short)336951419;
			short num2 = num;
			num = (short)1914468475;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1559363584;
				if (num != 0)
				{
				}
				if (this._contentLoaded)
				{
					num = (short)680329217;
					if (num != 0)
					{
					}
					return;
				}
				break;
			}
			num = (short)1369636864;
			short num3 = num;
			this._contentLoaded = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("崙闗뗙꣛뇝鋟跡裣蟥웧ꧩ菫菭鷯鷱髳뗵ꣷ꧹틻곽懿昁洃椅䔇欉戋漍眏眑礓猕瘗渙㈛崝伟伡䤣䤥䘧ᄩ伫䄭崯䈱嬳堵崷吹䠻ᄽ␿⁁⥃⽅⽇㡉ⵋ㩍㥏㵑㩓⁕ㅗ㽙⭛煝џaॣཥཧᡩ൫ᩭ᥯ᵱᩳuᅷό୻偽", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x0600003B RID: 59 RVA: 0x000057B4 File Offset: 0x000039B4
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)1830158338;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_199;
				case 1:
					num = (short)1867841537;
					if (num != 0)
					{
					}
					num = (short)1328807936;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_31;
					}
					continue;
				}
				IL_31:
				switch (connectionId)
				{
				case 1:
					goto IL_127;
				case 2:
					goto IL_10D;
				case 3:
					goto IL_15B;
				case 4:
					goto IL_1C8;
				case 5:
					goto IL_14E;
				case 6:
					goto IL_100;
				case 7:
					goto IL_175;
				case 8:
					goto IL_134;
				case 9:
					goto IL_A9;
				case 10:
					goto IL_168;
				case 11:
					goto IL_11A;
				case 12:
					goto IL_141;
				default:
					num = (short)501940225;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_A9:
			num = (short)240413383;
			short num3 = num;
			num = (short)1615293127;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_175:
				this.btnAbort = (global::System.Windows.Controls.Button)target;
				return;
			default:
				num = (short)1503199232;
				if (num != 0)
				{
				}
				this.btnComplete = (global::Motorola.CommonCPS.RadioManagement.Controls.RMButton)target;
				return;
			}
			IL_100:
			this.btnOK_Template = (global::Motorola.CommonCPS.RadioManagement.Controls.RMButton)target;
			return;
			IL_10D:
			this.btnNotNow = (global::Motorola.CommonCPS.RadioManagement.Controls.RMButton)target;
			return;
			IL_11A:
			this.btnCloseAndRetry = (global::Motorola.CommonCPS.RadioManagement.Controls.RMButton)target;
			return;
			IL_127:
			this.btnOK = (global::Motorola.CommonCPS.RadioManagement.Controls.RMButton)target;
			return;
			IL_134:
			this.dgrJobContainer = (global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid)target;
			return;
			IL_141:
			this.statusBar1 = (global::System.Windows.Controls.Primitives.StatusBar)target;
			return;
			IL_14E:
			this.dgrSelectTemplate = (global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid)target;
			return;
			IL_15B:
			this.btnNever = (global::Motorola.CommonCPS.RadioManagement.Controls.RMButton)target;
			return;
			IL_168:
			this.btnClearOldData = (global::Motorola.CommonCPS.RadioManagement.Controls.RMButton)target;
			return;
			IL_199:
			num = (short)1469513728;
			short num4 = num;
			this._contentLoaded = true;
			return;
			IL_1C8:
			this.btnResume = (global::Motorola.CommonCPS.RadioManagement.Controls.RMButton)target;
		}

		// Token: 0x0400003E RID: 62
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMButton btnOK;

		// Token: 0x0400003F RID: 63
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMButton btnNotNow;

		// Token: 0x04000040 RID: 64
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMButton btnNever;

		// Token: 0x04000041 RID: 65
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMButton btnResume;

		// Token: 0x04000042 RID: 66
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid dgrSelectTemplate;

		// Token: 0x04000043 RID: 67
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMButton btnOK_Template;

		// Token: 0x04000044 RID: 68
		internal global::System.Windows.Controls.Button btnAbort;

		// Token: 0x04000045 RID: 69
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid dgrJobContainer;

		// Token: 0x04000046 RID: 70
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMButton btnComplete;

		// Token: 0x04000047 RID: 71
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMButton btnClearOldData;

		// Token: 0x04000048 RID: 72
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMButton btnCloseAndRetry;

		// Token: 0x04000049 RID: 73
		internal global::System.Windows.Controls.Primitives.StatusBar statusBar1;

		// Token: 0x0400004A RID: 74
		private bool _contentLoaded;
	}
}
