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
	// Token: 0x02000003 RID: 3
	public class AddRadioView : global::System.Windows.Controls.UserControl, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x06000004 RID: 4 RVA: 0x0000211C File Offset: 0x0000031C
		public AddRadioView()
		{
			this.InitializeComponent();
			base.DataContextChanged += this.a;
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002148 File Offset: 0x00000348
		private void a(object A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			short num = (short)1391788033;
			if (num != 0)
			{
			}
			num = (short)121110528;
			short num2 = num;
			num = (short)1335987420;
			short num3 = num;
			num = (short)184257756;
			switch (num3 == num)
			{
			}
			num = (short)1277886464;
			if (num != 0)
			{
			}
			this.msiSerialNumber.Focus();
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002200 File Offset: 0x00000400
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			int a_ = 4;
			if (this._contentLoaded)
			{
				short num = (short)192314482;
				short num2 = num;
				num = (short)1971551346;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1603272704;
					short num3 = num;
					num = (short)7864321;
					if (num != 0)
					{
					}
					num = (short)810942464;
					if (num != 0)
					{
					}
					return;
				}
				}
			}
			this._contentLoaded = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("鞷펻쪽꾿냁ꯃ꫅꧇迋ꇍ뷏뿑믓룕鯗諙进닟菡胣迥蟧꟩跫胭釯闱釳鯵鷷铹裻탽勿持怃漅朇ㄉ漋愍紏我笓砕紗琙栛ㄝ䄟䘡䀣吥䤧丩䔫䄭䘯嬱儳䄵᜷嬹堻娽㈿⍁⁃⽅❇㱉╋⭍❏籑ⱓ㝕㕗㙙", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06000007 RID: 7 RVA: 0x000022E8 File Offset: 0x000004E8
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)408551425;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_187;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				case 2:
					num = (short)621215744;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_30:
				switch (connectionId)
				{
				case 1:
					goto IL_1F4;
				case 2:
					goto IL_E0;
				case 3:
					goto IL_18C;
				case 4:
					goto IL_C6;
				case 5:
					goto IL_13B;
				case 6:
					goto IL_199;
				case 7:
					goto IL_1A6;
				case 8:
					goto IL_162;
				case 9:
					goto IL_1CD;
				case 10:
					goto IL_1DA;
				case 11:
					goto IL_107;
				case 12:
					goto IL_B9;
				case 13:
					goto IL_1E7;
				case 14:
					goto IL_1C0;
				case 15:
					goto IL_ED;
				case 16:
					goto IL_AC;
				case 17:
					goto IL_276;
				case 18:
					goto IL_1B3;
				case 19:
					goto IL_D3;
				case 20:
					goto IL_148;
				case 21:
					goto IL_FA;
				case 22:
					goto IL_155;
				default:
					num = (short)244973570;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_AC:
			this.msiPCRRadioID = (global::Motorola.CommonCPS.RadioManagement.Controls.RMMaskedInput)target;
			return;
			IL_B9:
			this.msiULUID = (global::Motorola.CommonCPS.RadioManagement.Controls.RMMaskedInput)target;
			return;
			IL_C6:
			this.msiOTARID = (global::Motorola.CommonCPS.RadioManagement.Controls.RMMaskedInput)target;
			return;
			IL_D3:
			this.iaiPCRRadioIP = (global::Motorola.CommonCPS.RadioManagement.Controls.RMIPAddressInput)target;
			return;
			IL_E0:
			this.msiPassword = (global::Motorola.CommonCPS.RadioManagement.Controls.RMPasswordBox)target;
			return;
			IL_ED:
			this.msiPCRSerialNumber = (global::Motorola.CommonCPS.RadioManagement.Controls.RMTextBox)target;
			return;
			IL_FA:
			this.btnOK = (global::Motorola.CommonCPS.RadioManagement.Controls.RMButton)target;
			return;
			IL_107:
			num = (short)1333985281;
			if (num != 0)
			{
			}
			this.msiUserPIN = (global::Motorola.CommonCPS.RadioManagement.Controls.RMPasswordBox)target;
			return;
			IL_13B:
			this.iaiSubsciberIP = (global::Motorola.CommonCPS.RadioManagement.Controls.RMIPAddressInput)target;
			return;
			IL_148:
			this.msiPCRPassword = (global::Motorola.CommonCPS.RadioManagement.Controls.RMPasswordBox)target;
			return;
			IL_155:
			this.btnCancel = (global::Motorola.CommonCPS.RadioManagement.Controls.RMButton)target;
			return;
			IL_162:
			this.iaiBDPI = (global::Motorola.CommonCPS.RadioManagement.Controls.RMIPAddressInput)target;
			return;
			IL_187:
			this._contentLoaded = true;
			return;
			IL_18C:
			this.msiAlias = (global::Motorola.CommonCPS.RadioManagement.Controls.RMTextBox)target;
			return;
			IL_199:
			this.iaiPeerIP = (global::Motorola.CommonCPS.RadioManagement.Controls.RMIPAddressInput)target;
			return;
			IL_1A6:
			this.iaiBDSIP = (global::Motorola.CommonCPS.RadioManagement.Controls.RMIPAddressInput)target;
			return;
			IL_1B3:
			this.msiPCRRadioAlias = (global::Motorola.CommonCPS.RadioManagement.Controls.RMTextBox)target;
			return;
			IL_1C0:
			this.msiVRID = (global::Motorola.CommonCPS.RadioManagement.Controls.RMMaskedInput)target;
			return;
			IL_1CD:
			this.msiBFName = (global::Motorola.CommonCPS.RadioManagement.Controls.RMTextBox)target;
			return;
			IL_1DA:
			this.msiUserName = (global::Motorola.CommonCPS.RadioManagement.Controls.RMMaskedInput)target;
			return;
			IL_1E7:
			this.iaiOTAIP = (global::Motorola.CommonCPS.RadioManagement.Controls.RMIPAddressInput)target;
			return;
			IL_1F4:
			num = (short)258142582;
			short num3 = num;
			num = (short)1539567990;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_1C0;
			case 1:
				break;
			default:
			{
				num = (short)1450311680;
				short num4 = num;
				break;
			}
			}
			num = (short)1034944512;
			if (num != 0)
			{
			}
			this.msiSerialNumber = (global::Motorola.CommonCPS.RadioManagement.Controls.RMTextBox)target;
			return;
			IL_276:
			this.msiPCRCAI = (global::Motorola.CommonCPS.RadioManagement.Controls.RMMaskedInput)target;
		}

		// Token: 0x04000003 RID: 3
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMTextBox msiSerialNumber;

		// Token: 0x04000004 RID: 4
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMPasswordBox msiPassword;

		// Token: 0x04000005 RID: 5
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMTextBox msiAlias;

		// Token: 0x04000006 RID: 6
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMMaskedInput msiOTARID;

		// Token: 0x04000007 RID: 7
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMIPAddressInput iaiSubsciberIP;

		// Token: 0x04000008 RID: 8
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMIPAddressInput iaiPeerIP;

		// Token: 0x04000009 RID: 9
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMIPAddressInput iaiBDSIP;

		// Token: 0x0400000A RID: 10
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMIPAddressInput iaiBDPI;

		// Token: 0x0400000B RID: 11
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMTextBox msiBFName;

		// Token: 0x0400000C RID: 12
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMMaskedInput msiUserName;

		// Token: 0x0400000D RID: 13
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMPasswordBox msiUserPIN;

		// Token: 0x0400000E RID: 14
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMMaskedInput msiULUID;

		// Token: 0x0400000F RID: 15
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMIPAddressInput iaiOTAIP;

		// Token: 0x04000010 RID: 16
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMMaskedInput msiVRID;

		// Token: 0x04000011 RID: 17
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMTextBox msiPCRSerialNumber;

		// Token: 0x04000012 RID: 18
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMMaskedInput msiPCRRadioID;

		// Token: 0x04000013 RID: 19
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMMaskedInput msiPCRCAI;

		// Token: 0x04000014 RID: 20
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMTextBox msiPCRRadioAlias;

		// Token: 0x04000015 RID: 21
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMIPAddressInput iaiPCRRadioIP;

		// Token: 0x04000016 RID: 22
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMPasswordBox msiPCRPassword;

		// Token: 0x04000017 RID: 23
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMButton btnOK;

		// Token: 0x04000018 RID: 24
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMButton btnCancel;

		// Token: 0x04000019 RID: 25
		private bool _contentLoaded;
	}
}
