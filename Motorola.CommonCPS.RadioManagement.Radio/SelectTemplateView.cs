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
	// Token: 0x0200002B RID: 43
	public class SelectTemplateView : global::System.Windows.Controls.UserControl, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x060001E9 RID: 489 RVA: 0x00022DB8 File Offset: 0x00020FB8
		public SelectTemplateView()
		{
			this.InitializeComponent();
		}

		// Token: 0x060001EA RID: 490 RVA: 0x00022DD4 File Offset: 0x00020FD4
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			int a_ = 17;
			if (!this._contentLoaded)
			{
				short num = (short)545062912;
				short num2 = num;
				num = (short)61321528;
				short num3 = num;
				num = (short)642036024;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1584136192;
					if (num != 0)
					{
					}
					num = (short)1912864769;
					if (num != 0)
					{
					}
					this._contentLoaded = true;
					global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("諆ꛈ뿊ꋌ뷎뻐뿒듔淪高듚냜닞軠跢ꛤ럦뫨엪뿬軮闰髲髴뫶飸闺鳼飾搀渂怄椆紈┊弌渎甐稒稔Ⱆ稘琚瀜漞丠䴢䀤䤦崨Ъ帬䨮崰嘲嘴䌶䴸帺值伾ⵀ≂ㅄ≆㽈≊⡌㡎繐⁒ご㭖㱘㡚⥜⭞Ѡ๢ᕤ୦ࡨὪ࡬᥮ᡰᙲɴ奶Ÿ᩺ၼ፾", a_), global::System.UriKind.Relative);
					global::System.Windows.Application.LoadComponent(this, resourceLocator);
					return;
				}
				}
			}
		}

		// Token: 0x060001EB RID: 491 RVA: 0x00022EB4 File Offset: 0x000210B4
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)403111938;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_127;
				case 1:
					goto IL_110;
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
					goto IL_DB;
				case 2:
				{
					num = (short)1857659223;
					short num3 = num;
					num = (short)799646039;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_92;
					}
					break;
				}
				case 3:
					goto IL_129;
				default:
					num = (short)1960968193;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_110:
				num = (short)878968832;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_92:
			num = (short)1057030144;
			if (num != 0)
			{
			}
			num = (short)1668349953;
			if (num != 0)
			{
			}
			this.btnOK = (global::Motorola.CommonCPS.RadioManagement.Controls.RMButton)target;
			return;
			IL_DB:
			num = (short)633798656;
			short num4 = num;
			this.tplTemplate = (global::Motorola.CommonCPS.RadioManagement.Controls.RMTemplateList)target;
			return;
			IL_127:
			this._contentLoaded = true;
			return;
			IL_129:
			this.btnCancel = (global::Motorola.CommonCPS.RadioManagement.Controls.RMButton)target;
		}

		// Token: 0x040000DE RID: 222
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMTemplateList tplTemplate;

		// Token: 0x040000DF RID: 223
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMButton btnOK;

		// Token: 0x040000E0 RID: 224
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMButton btnCancel;

		// Token: 0x040000E1 RID: 225
		private bool _contentLoaded;
	}
}
