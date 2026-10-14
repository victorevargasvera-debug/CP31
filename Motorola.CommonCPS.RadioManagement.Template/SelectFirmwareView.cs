using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.Composition;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Motorola.CommonCPS.RadioManagement.Controls;

namespace Motorola.CommonCPS.RadioManagement.Template
{
	// Token: 0x0200000B RID: 11
	public class SelectFirmwareView : global::System.Windows.Controls.UserControl, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x06000064 RID: 100 RVA: 0x00008094 File Offset: 0x00006294
		public SelectFirmwareView()
		{
			this.InitializeComponent();
		}

		// Token: 0x17000016 RID: 22
		// (set) Token: 0x06000065 RID: 101 RVA: 0x000080B0 File Offset: 0x000062B0
		[global::System.ComponentModel.Composition.Import]
		public global::Motorola.CommonCPS.RadioManagement.Template.SelectFirmwareViewModel ViewModel
		{
			set
			{
				short num = (short)1517111422;
				short num2 = num;
				num = (short)14829694;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1406074880;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1668612096;
				if (num != 0)
				{
				}
				num = (short)1784152065;
				if (num != 0)
				{
				}
				base.DataContext = value;
			}
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00008160 File Offset: 0x00006360
		private void a(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1710080821;
			short num2 = num;
			num = (short)632144693;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1325400064;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1060044800;
			if (num != 0)
			{
			}
			num = (short)1132593153;
			if (num != 0)
			{
			}
			this.cb_FirmwareSelectins.SelectedIndex = 0;
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00008218 File Offset: 0x00006418
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			int a_ = 6;
			if (this._contentLoaded)
			{
				short num = (short)1707016192;
				short num2 = num;
				num = (short)440823218;
				short num3 = num;
				num = (short)471887282;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1048576000;
					if (num != 0)
					{
					}
					num = (short)140967937;
					if (num != 0)
					{
					}
					return;
				}
			}
			this._contentLoaded = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.Template.ShowVAPacksViewModel.b("헹뇻釽瓿洁瘃椅搇欉∋䴍缏缑礓礕瘗夙䰛䴝ฟ瀡䔣䈥䄧䔩愫伭帯匱匳匵唷弹刻䨽渿ᙁ⅃⭅㡇♉ⵋ㩍㕏楑㝓㥕㕗⩙㍛そ՟ౡၣ䥥᭧ཀྵk୭፯ٱታή੷᝹୻ώﶉꎋﶍﺑﲙ춟햡얣풥춧\udca9얫쮭잯鲱첳ힵ햷횹", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06000068 RID: 104 RVA: 0x000082FC File Offset: 0x000064FC
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)948109314;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_E0;
				case 1:
				{
					num = (short)892207104;
					short num3 = num;
					num = (short)90112000;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				}
				IL_30:
				switch (connectionId)
				{
				case 1:
				{
					num = (short)1523280814;
					short num4 = num;
					num = (short)1329621934;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_123;
					}
					break;
				}
				case 2:
					goto IL_BC;
				case 3:
					goto IL_89;
				case 4:
					goto IL_E2;
				}
				num = (short)559087617;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_89:
			num = (short)70385665;
			if (num != 0)
			{
			}
			this.btnOK = (global::Motorola.CommonCPS.RadioManagement.Controls.RMButton)target;
			return;
			IL_BC:
			this.cbxIDs = (global::Motorola.CommonCPS.RadioManagement.Controls.RMComboBox)target;
			return;
			IL_E0:
			this._contentLoaded = true;
			return;
			IL_E2:
			this.btnCancel = (global::Motorola.CommonCPS.RadioManagement.Controls.RMButton)target;
			return;
			IL_123:
			num = (short)1386741760;
			if (num != 0)
			{
			}
			this.cb_FirmwareSelectins = (global::Motorola.CommonCPS.RadioManagement.Controls.RMComboBox)target;
		}

		// Token: 0x0400002A RID: 42
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMComboBox cb_FirmwareSelectins;

		// Token: 0x0400002B RID: 43
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMComboBox cbxIDs;

		// Token: 0x0400002C RID: 44
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMButton btnOK;

		// Token: 0x0400002D RID: 45
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMButton btnCancel;

		// Token: 0x0400002E RID: 46
		private bool _contentLoaded;
	}
}
