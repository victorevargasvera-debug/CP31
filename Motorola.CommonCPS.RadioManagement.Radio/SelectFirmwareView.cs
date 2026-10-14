using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Motorola.CommonCPS.RadioManagement.Controls;

namespace Motorola.CommonCPS.RadioManagement.Radio
{
	// Token: 0x02000023 RID: 35
	public class SelectFirmwareView : global::System.Windows.Controls.UserControl, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x060001A9 RID: 425 RVA: 0x0001EDD8 File Offset: 0x0001CFD8
		public SelectFirmwareView()
		{
			this.InitializeComponent();
		}

		// Token: 0x060001AA RID: 426 RVA: 0x0001EDF4 File Offset: 0x0001CFF4
		private void a(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)494355996;
			short num2 = num;
			num = (short)455296540;
			switch (num2 == num)
			{
			default:
			{
				num = (short)641597440;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)535035904;
			if (num != 0)
			{
			}
			num = (short)2044854273;
			if (num != 0)
			{
			}
			this.cb_FirmwareSelectins.SelectedIndex = 0;
		}

		// Token: 0x060001AB RID: 427 RVA: 0x0001EEAC File Offset: 0x0001D0AC
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 9;
			short num;
			if (!this._contentLoaded)
			{
				num = (short)1715633372;
				short num2 = num;
				num = (short)1231060188;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)2076377089;
					if (num != 0)
					{
					}
					num = (short)1973092352;
					if (num != 0)
					{
					}
					this._contentLoaded = true;
					global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("銼껀럂꫄뗆ꛈꟊ곌鋐볒룔뫖뛘뗚黜连닠췢럤蛦跨苪苬ꋮ郰鷲铴郶鳸雺飼釾甀ⴂ圄昆洈戊戌㐎爐簒研朖瘘甚砜焞唠ఢ嘤䈦䔨个丬嬮地娲䜴娶丸娺似娾㝀⩂⁄う晈㡊⡌⍎㑐げ⅔ㅖじ⥚ぜ⡞`ᅢdᅦh๪ᩬ䅮॰ቲᡴ᭶", a_), global::System.UriKind.Relative);
					global::System.Windows.Application.LoadComponent(this, resourceLocator);
					return;
				}
				}
			}
			num = (short)2037252096;
			short num3 = num;
		}

		// Token: 0x060001AC RID: 428 RVA: 0x0001EF8C File Offset: 0x0001D18C
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)2093547521;
			if (num != 0)
			{
			}
			num = (short)1792409601;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_14F;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_59;
					}
					continue;
				case 2:
					num = (short)918552576;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_59:
				switch (connectionId)
				{
				case 1:
					goto IL_F6;
				case 2:
					goto IL_15E;
				case 3:
					goto IL_E9;
				case 4:
					goto IL_DC;
				case 5:
					goto IL_151;
				case 6:
					goto IL_103;
				default:
				{
					num = (short)1173378338;
					short num3 = num;
					num = (short)1271158050;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_14F;
					default:
						num = (short)1036779520;
						if (num != 0)
						{
						}
						num = (short)1938685954;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					break;
				}
				}
			}
			IL_DC:
			this.cbxSystemID = (global::Motorola.CommonCPS.RadioManagement.Controls.RMComboBox)target;
			return;
			IL_E9:
			this.cb_FirmwareSelectins = (global::Motorola.CommonCPS.RadioManagement.Controls.RMComboBox)target;
			return;
			IL_F6:
			this.codeplugSelectionGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_103:
			num = (short)46268416;
			short num4 = num;
			this.btnCancel = (global::Motorola.CommonCPS.RadioManagement.Controls.RMButton)target;
			return;
			IL_14F:
			this._contentLoaded = true;
			return;
			IL_151:
			this.btnOK = (global::Motorola.CommonCPS.RadioManagement.Controls.RMButton)target;
			return;
			IL_15E:
			this.cb_CodeplugSelections = (global::Motorola.CommonCPS.RadioManagement.Controls.RMComboBox)target;
		}

		// Token: 0x040000BE RID: 190
		internal global::System.Windows.Controls.Grid codeplugSelectionGrid;

		// Token: 0x040000BF RID: 191
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMComboBox cb_CodeplugSelections;

		// Token: 0x040000C0 RID: 192
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMComboBox cb_FirmwareSelectins;

		// Token: 0x040000C1 RID: 193
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMComboBox cbxSystemID;

		// Token: 0x040000C2 RID: 194
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMButton btnOK;

		// Token: 0x040000C3 RID: 195
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMButton btnCancel;

		// Token: 0x040000C4 RID: 196
		private bool _contentLoaded;
	}
}
