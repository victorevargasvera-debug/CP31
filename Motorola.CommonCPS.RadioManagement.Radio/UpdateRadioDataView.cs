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
	// Token: 0x0200003A RID: 58
	public class UpdateRadioDataView : global::System.Windows.Controls.UserControl, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x06000240 RID: 576 RVA: 0x00027B90 File Offset: 0x00025D90
		public UpdateRadioDataView()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000241 RID: 577 RVA: 0x00027BAC File Offset: 0x00025DAC
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			int a_ = 8;
			short num = (short)1872887809;
			if (num != 0)
			{
			}
			if (!this._contentLoaded)
			{
				num = (short)768933888;
				short num2 = num;
				num = (short)534944246;
				short num3 = num;
				num = (short)1841142262;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)137166848;
					if (num != 0)
					{
					}
					this._contentLoaded = true;
					global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("鎻꾿뛁ꯃ듅Ꟈꛉ귋鏏뷑맓믕럗듙鿛軝돟쳡뛣蟥賧菩菫ꏭ釯鳱闳釵鷷韹駻都瓿Ⰱ嘃朅氇按挋㔍猏紑礓昕眗琙礛瀝吟ഡ儣嘥䰧䬩堫䬭䈯匱倳張圷帹崻䨽ℿ㑁ⵃ⍅㽇敉㥋㹍㑏㍑⁓㍕⩗㭙㡛㝝ཟ١գብ१ᱩի୭ݯ山౳᝵ᕷᙹ", a_), global::System.UriKind.Relative);
					global::System.Windows.Application.LoadComponent(this, resourceLocator);
					return;
				}
				}
			}
		}

		// Token: 0x06000242 RID: 578 RVA: 0x00027C8C File Offset: 0x00025E8C
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num;
			for (;;)
			{
				num = (short)1626931202;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_BD;
					case 1:
						num = (short)1964965889;
						if (num != 0)
						{
						}
						num = (short)1645608960;
						num2 = (int)((global::System.IntPtr)num);
						continue;
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
						goto IL_141;
					case 2:
						goto IL_98;
					case 3:
						goto IL_14E;
					case 4:
						goto IL_8B;
					case 5:
						goto IL_134;
					default:
						num = (short)1162739713;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				IL_BD:
				num = (short)1758437290;
				short num3 = num;
				num = (short)1250795434;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_F3;
				}
			}
			IL_8B:
			this.btnOK = (global::Motorola.CommonCPS.RadioManagement.Controls.RMButton)target;
			return;
			IL_98:
			this.cbxSystemID = (global::Motorola.CommonCPS.RadioManagement.Controls.RMComboBox)target;
			return;
			IL_F3:
			num = (short)1821310976;
			if (num != 0)
			{
			}
			num = (short)1969487872;
			short num4 = num;
			this._contentLoaded = true;
			return;
			IL_134:
			this.btnCancel = (global::Motorola.CommonCPS.RadioManagement.Controls.RMButton)target;
			return;
			IL_141:
			this.cbxKeyType = (global::Motorola.CommonCPS.RadioManagement.Controls.RMComboBox)target;
			return;
			IL_14E:
			this.cbxIsWriteProtect = (global::Motorola.CommonCPS.RadioManagement.Controls.RMCheckBox)target;
		}

		// Token: 0x04000130 RID: 304
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMComboBox cbxKeyType;

		// Token: 0x04000131 RID: 305
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMComboBox cbxSystemID;

		// Token: 0x04000132 RID: 306
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMCheckBox cbxIsWriteProtect;

		// Token: 0x04000133 RID: 307
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMButton btnOK;

		// Token: 0x04000134 RID: 308
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMButton btnCancel;

		// Token: 0x04000135 RID: 309
		private bool _contentLoaded;
	}
}
