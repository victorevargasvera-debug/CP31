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
	// Token: 0x0200000E RID: 14
	public class ResetRadioPasswordView : global::System.Windows.Controls.UserControl, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x06000041 RID: 65 RVA: 0x00006820 File Offset: 0x00004A20
		public ResetRadioPasswordView()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000042 RID: 66 RVA: 0x0000683C File Offset: 0x00004A3C
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 14;
			while (this._contentLoaded)
			{
				short num = (short)277497863;
				short num2 = num;
				num = (short)676284423;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					continue;
				case 1:
					break;
				default:
				{
					num = (short)2033582080;
					short num3 = num;
					break;
				}
				}
				num = (short)1181351936;
				if (num != 0)
				{
				}
				num = (short)1152057345;
				if (num != 0)
				{
				}
				return;
			}
			this._contentLoaded = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("觃꧅볇ꗉ뻋ꇍ볏돑䀘闕럗럙뇛뇝軟ꇡ듣뗥웧룩跫諭駯鷱맳韵雷鯹鯻鯽淿朁樃爅☇堉洋樍礏紑⼓甕眗眙氛焝丟䜡䨣別ܧ堩䤫崭唯䘱䘳圵尷匹医丽ℿㅁ㝃ㅅ❇㡉⡋慍≏㝑❓㍕ⱗ⡙㵛㩝य़ൡᑣݥ᭧ᥩ᭫ŭɯᙱɳήᵷ൹剻ٽ", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00006920 File Offset: 0x00004B20
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)1237057537;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_105;
				case 1:
				{
					num = (short)702205699;
					short num3 = num;
					num = (short)839503619;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_105;
					default:
						num = (short)1519714304;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_7D;
						}
						continue;
					}
					break;
				}
				case 2:
					num = (short)1892483073;
					if (num != 0)
					{
					}
					num = (short)972423168;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_7D:
				switch (connectionId)
				{
				case 1:
					goto IL_13E;
				case 2:
					goto IL_E0;
				case 3:
					goto IL_D3;
				case 4:
					goto IL_131;
				default:
					num = (short)213254146;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_D3:
			this.btnOK = (global::Motorola.CommonCPS.RadioManagement.Controls.RMButton)target;
			return;
			IL_E0:
			this.btnBrowse = (global::Motorola.CommonCPS.RadioManagement.Controls.RMButton)target;
			return;
			IL_105:
			num = (short)807862272;
			short num4 = num;
			this._contentLoaded = true;
			return;
			IL_131:
			this.btnCancel = (global::Motorola.CommonCPS.RadioManagement.Controls.RMButton)target;
			return;
			IL_13E:
			this.PasswordResetFilePath = (global::Motorola.CommonCPS.RadioManagement.Controls.RMTextBox)target;
		}

		// Token: 0x0400002E RID: 46
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMTextBox PasswordResetFilePath;

		// Token: 0x0400002F RID: 47
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMButton btnBrowse;

		// Token: 0x04000030 RID: 48
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMButton btnOK;

		// Token: 0x04000031 RID: 49
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMButton btnCancel;

		// Token: 0x04000032 RID: 50
		private bool _contentLoaded;
	}
}
