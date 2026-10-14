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
	// Token: 0x02000010 RID: 16
	public class ShowCACertificatePacksView : global::System.Windows.Controls.UserControl, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x06000052 RID: 82 RVA: 0x00007648 File Offset: 0x00005848
		public ShowCACertificatePacksView()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00007664 File Offset: 0x00005864
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			int a_ = 0;
			if (this._contentLoaded)
			{
				short num = (short)1123221504;
				short num2 = num;
				num = (short)561243781;
				short num3 = num;
				num = (short)222619269;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)829489153;
					if (num != 0)
					{
					}
					num = (short)147849216;
					if (num != 0)
					{
					}
					return;
				}
			}
			this._contentLoaded = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("鮳﮵ힷ캹펻첽꾿껁ꗃ诇ꗉꇋꏍ뿏병韓蛕诗軛뿝蓟诡诣ꯥ觧蓩跫觭闯鿱釳飵賷퓹껻鿽擿欁欃㴅欇攉愋縍缏簑焓砕気㔙漛瘝伟唡䜣䜥䬧伩師娭夯吱崳唵夷丹夻丽ℿ⅁⽃㕅㹇⍉⥋㥍罏⅑㱓㥕⽗㥙㵛㵝՟ၡၣཥ๧ͩཫ཭ѯ᝱ѳ᝵᭷ᅹཻࡽꢅ", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00007748 File Offset: 0x00005948
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)1442906115;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (connectionId != 2)
					{
						num = (short)2131165185;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_150;
				case 1:
				{
					num = (short)1284903740;
					short num3 = num;
					num = (short)2059408188;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num = (short)2107834368;
						if (num != 0)
						{
						}
						num = (short)476381185;
						if (num != 0)
						{
						}
						num = (short)1446707204;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 2:
				{
					num = (short)562692096;
					short num4 = num;
					num = (short)1758265344;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 3:
					switch (0)
					{
					case 0:
						goto IL_38;
					}
					continue;
				case 4:
					goto IL_116;
				}
				IL_38:
				if (connectionId == 1)
				{
					break;
				}
				num = (short)1678835714;
				num2 = (int)((global::System.IntPtr)num);
			}
			this.dgrCACertificatePacks = (global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid)target;
			return;
			IL_116:
			this._contentLoaded = true;
			return;
			IL_150:
			this.btnCancel = (global::Motorola.CommonCPS.RadioManagement.Controls.RMButton)target;
		}

		// Token: 0x04000037 RID: 55
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid dgrCACertificatePacks;

		// Token: 0x04000038 RID: 56
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMButton btnCancel;

		// Token: 0x04000039 RID: 57
		private bool _contentLoaded;
	}
}
