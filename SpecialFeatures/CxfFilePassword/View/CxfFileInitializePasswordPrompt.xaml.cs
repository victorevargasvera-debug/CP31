using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using AcpUI.Common;
using SpecialFeatures.AcpReportManagerLib;
using SpecialFeatures.CxfFilePassword.ViewModel;

namespace SpecialFeatures.CxfFilePassword.View
{
	// Token: 0x0200014A RID: 330
	public partial class CxfFileInitializePasswordPrompt : Window
	{
		// Token: 0x060010DA RID: 4314 RVA: 0x00003612 File Offset: 0x00001812
		public CxfFileInitializePasswordPrompt()
		{
			this.InitializeComponent();
			Utility.SetDirection(this);
		}

		// Token: 0x060010DB RID: 4315 RVA: 0x00178AF8 File Offset: 0x00176CF8
		private void CxfFilePasswordBoxChanged(object A_0, RoutedEventArgs A_1)
		{
			short num = (short)1138622464;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)293863424;
					short num3 = num;
					num = (short)1085325221;
					short num4 = num;
					num = (short)598982565;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
						num = (short)896008192;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_A3;
						}
						continue;
					}
					break;
				}
				case 1:
					num = (short)750714881;
					if (num != 0)
					{
					}
					((CxfFileInitializePasswordPromptViewModel)base.DataContext).ProvidedPassword = ((PasswordBox)A_0).SecurePassword;
					num = (short)1367212034;
					num2 = (int)((IntPtr)num);
					continue;
				case 2:
					return;
				}
				IL_A3:
				if (base.DataContext == null)
				{
					break;
				}
				num = (short)868352001;
				num2 = (int)((IntPtr)num);
			}
		}

		// Token: 0x060010DC RID: 4316 RVA: 0x00178C20 File Offset: 0x00176E20
		private void CxfFileRepeatPasswordBoxChanged(object A_0, RoutedEventArgs A_1)
		{
			short num = (short)319488000;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)632160256;
					short num3 = num;
					num = (short)1173691693;
					short num4 = num;
					num = (short)1759255853;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
						num = (short)1028587520;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_AA;
						}
						continue;
					}
					break;
				}
				case 1:
					((CxfFileInitializePasswordPromptViewModel)base.DataContext).ConfirmProvidedPassword = ((PasswordBox)A_0).SecurePassword;
					num = (short)1368719362;
					num2 = (int)((IntPtr)num);
					continue;
				case 2:
					goto IL_F7;
				}
				IL_AA:
				if (base.DataContext == null)
				{
					return;
				}
				num = (short)37748737;
				num2 = (int)((IntPtr)num);
			}
			IL_F7:
			num = (short)637337601;
			if (num != 0)
			{
			}
		}
	}
}
