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
	// Token: 0x0200001F RID: 31
	public class SelectCodeplugVersionView : global::System.Windows.Controls.UserControl, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x06000185 RID: 389 RVA: 0x0001C578 File Offset: 0x0001A778
		public SelectCodeplugVersionView()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000186 RID: 390 RVA: 0x0001C594 File Offset: 0x0001A794
		private void a(object A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			short num = (short)1910133974;
			short num2 = num;
			num = (short)758142166;
			switch (num2 == num)
			{
			default:
			{
				num = (short)644087808;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)519700480;
			if (num != 0)
			{
			}
			num = (short)1438908417;
			if (num != 0)
			{
			}
			this.cb_CodeplugSelections.SelectedIndex = 0;
		}

		// Token: 0x06000187 RID: 391 RVA: 0x0001C648 File Offset: 0x0001A848
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			int a_ = 4;
			if (this._contentLoaded)
			{
				short num = (short)1033568257;
				if (num != 0)
				{
				}
				num = (short)575225255;
				short num2 = num;
				num = (short)73416103;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_B2;
				case 1:
					break;
				default:
				{
					num = (short)950796288;
					short num3 = num;
					break;
				}
				}
				num = (short)1450442752;
				if (num != 0)
				{
				}
				return;
			}
			IL_B2:
			this._contentLoaded = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("鞷펻쪽꾿냁ꯃ꫅꧇迋ꇍ뷏뿑믓룕鯗諙进닟菡胣迥蟧꟩跫胭釯闱釳鯵鷷铹裻탽勿持怃漅朇ㄉ漋愍紏我笓砕紗琙栛ㄝ匟䜡䠣䌥䬧帩伫䄭启圱䐳娵䴷崹䨻嬽㈿ㅁⵃ⥅♇㱉╋⭍❏絑❓㍕㑗㽙㽛⩝͟ൡcͥᡧ٩ᥫ७ٯ᝱ٳյᅷᕹቻࡽꢅ", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06000188 RID: 392 RVA: 0x0001C72C File Offset: 0x0001A92C
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)1617035266;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_133;
				case 1:
					num = (short)1053622272;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_15;
				}
				goto IL_31;
				IL_15:
				switch (0)
				{
				case 0:
					IL_31:
					switch (connectionId)
					{
					case 1:
						goto IL_142;
					case 2:
						goto IL_10F;
					case 3:
						goto IL_15A;
					case 4:
						goto IL_D9;
					case 5:
						goto IL_135;
					default:
					{
						num = (short)1952743545;
						short num3 = num;
						num = (short)797081721;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_15;
						default:
							num = (short)2134310913;
							if (num != 0)
							{
							}
							num = (short)1072889856;
							if (num != 0)
							{
							}
							num = (short)1821835265;
							num2 = (int)((global::System.IntPtr)num);
							break;
						}
						break;
					}
					}
					break;
				}
			}
			IL_D9:
			num = (short)1141243904;
			short num4 = num;
			this.btnOK = (global::Motorola.CommonCPS.RadioManagement.Controls.RMButton)target;
			return;
			IL_10F:
			this.codeplugSelectionGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_133:
			this._contentLoaded = true;
			return;
			IL_135:
			this.btnCancel = (global::Motorola.CommonCPS.RadioManagement.Controls.RMButton)target;
			return;
			IL_142:
			((global::Motorola.CommonCPS.RadioManagement.Radio.SelectCodeplugVersionView)target).DataContextChanged += this.a;
			return;
			IL_15A:
			this.cb_CodeplugSelections = (global::Motorola.CommonCPS.RadioManagement.Controls.RMComboBox)target;
		}

		// Token: 0x040000AD RID: 173
		internal global::System.Windows.Controls.Grid codeplugSelectionGrid;

		// Token: 0x040000AE RID: 174
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMComboBox cb_CodeplugSelections;

		// Token: 0x040000AF RID: 175
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMButton btnOK;

		// Token: 0x040000B0 RID: 176
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMButton btnCancel;

		// Token: 0x040000B1 RID: 177
		private bool _contentLoaded;
	}
}
