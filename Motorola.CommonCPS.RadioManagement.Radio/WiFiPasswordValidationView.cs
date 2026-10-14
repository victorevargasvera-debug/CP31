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
	// Token: 0x0200003F RID: 63
	public class WiFiPasswordValidationView : global::System.Windows.Controls.UserControl, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x0600024F RID: 591 RVA: 0x00028830 File Offset: 0x00026A30
		public WiFiPasswordValidationView()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000250 RID: 592 RVA: 0x0002884C File Offset: 0x00026A4C
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			int a_ = 1;
			if (this._contentLoaded)
			{
				short num = (short)2074214401;
				if (num != 0)
				{
				}
				num = (short)1134034944;
				short num2 = num;
				num = (short)1292675865;
				short num3 = num;
				num = (short)1307618073;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)551092224;
					if (num != 0)
					{
					}
					return;
				}
			}
			this._contentLoaded = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("骴襁횸쾺튼춾껀꿂꓄諈꓊ꃌꋎ뻐뷒雔蟖諘远뻞藠諢諤ꫦ裨藪賬裮铰黲郴駶跸헺꿼黾攀樂樄㰆樈搊怌缎縐紒瀔礖洘㐚樜瘞䜠䨢唤䘦娨堪娬䀮䌰圲䌴嘶唸刺夼帾㕀⩂⩄⥆㽈≊⡌㡎繐⑒㱔ㅖじ⭚㱜ⱞበᑢ੤ᕦ൨ᵪ౬ͮᡰᝲᑴͶၸᑺ፼ॾꦆ", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06000251 RID: 593 RVA: 0x00028930 File Offset: 0x00026B30
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)2089549826;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)530155972;
					short num3 = num;
					num = (short)2024835524;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1737818112;
						if (num != 0)
						{
						}
						num = (short)1600847873;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					goto IL_DD;
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
					goto IL_112;
				case 2:
					goto IL_B9;
				case 3:
					goto IL_11F;
				case 4:
					goto IL_AC;
				case 5:
					goto IL_DF;
				default:
					num = (short)252772352;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_AC:
			this.btnOK = (global::Motorola.CommonCPS.RadioManagement.Controls.RMButton)target;
			return;
			IL_B9:
			this.LblCloneWiFiDescription = (global::Motorola.CommonCPS.RadioManagement.Controls.RMTextBlock)target;
			return;
			IL_DD:
			num = (short)706740224;
			short num4 = num;
			this._contentLoaded = true;
			return;
			IL_DF:
			num = (short)1419313153;
			if (num != 0)
			{
			}
			this.btnCancel = (global::Motorola.CommonCPS.RadioManagement.Controls.RMButton)target;
			return;
			IL_112:
			this.txtTemplateName = (global::Motorola.CommonCPS.RadioManagement.Controls.RMTextBlock)target;
			return;
			IL_11F:
			this.tplWiFiPassword = (global::Motorola.CommonCPS.RadioManagement.Controls.RMWiFiPasswordList)target;
		}

		// Token: 0x0400013C RID: 316
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMTextBlock txtTemplateName;

		// Token: 0x0400013D RID: 317
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMTextBlock LblCloneWiFiDescription;

		// Token: 0x0400013E RID: 318
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMWiFiPasswordList tplWiFiPassword;

		// Token: 0x0400013F RID: 319
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMButton btnOK;

		// Token: 0x04000140 RID: 320
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMButton btnCancel;

		// Token: 0x04000141 RID: 321
		private bool _contentLoaded;
	}
}
