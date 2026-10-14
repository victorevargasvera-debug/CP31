using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Motorola.CommonCPS.RadioManagement.Controls;

namespace Motorola.CommonCPS.RadioManagement.Common
{
	// Token: 0x0200000C RID: 12
	public class UpdateLogSettingView : global::System.Windows.Controls.UserControl, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x06000023 RID: 35 RVA: 0x000044C0 File Offset: 0x000026C0
		public UpdateLogSettingView()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000024 RID: 36 RVA: 0x000044DC File Offset: 0x000026DC
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			int a_ = 19;
			short num = (short)646578177;
			if (num != 0)
			{
			}
			if (this._contentLoaded)
			{
				num = (short)579273869;
				short num2 = num;
				num = (short)2002060429;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)220463104;
					if (num != 0)
					{
					}
					num = (short)211484672;
					short num3 = num;
					return;
				}
				}
			}
			this._contentLoaded = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("쫤ꫦ蛨鿪苬鷮黰鿲铴\ud9f6뫸铺郼鋾渀洂䘄圆娈┊弌渎甐稒稔娖砘甚簜砞䐠丢䀤䤦崨Ԫ測䀮尰帲娴夶ȸ堺刼刾ㅀⱂ⭄≆❈㽊扌ⱎ⅐⁒穔≖⥘㽚㱜⭞Ѡར੤fᩨ๪ᥬ᭮ᡰᵲቴŶၸṺ੼偾ﶈ힠쪢삤킦螨펪첬슮\uddb0", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06000025 RID: 37 RVA: 0x000045C0 File Offset: 0x000027C0
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)941162500;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1570373632;
					short num3 = num;
					num = (short)833421313;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
				{
					num = (short)1863057409;
					if (num != 0)
					{
					}
					num = (short)648550874;
					short num4 = num;
					num = (short)1631328730;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_75;
					default:
						num = (short)1480654848;
						if (num != 0)
						{
						}
						if (connectionId != 2)
						{
							num = (short)925827074;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_14D;
					}
					break;
				}
				case 2:
					num = (short)2070609923;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_75;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_39;
					}
					continue;
				}
				IL_39:
				if (connectionId == 1)
				{
					break;
				}
				num = (short)1237319680;
				num2 = (int)((global::System.IntPtr)num);
			}
			this.btnYes = (global::Motorola.CommonCPS.RadioManagement.Controls.RMButton)target;
			return;
			IL_75:
			this._contentLoaded = true;
			return;
			IL_14D:
			this.btnNo = (global::Motorola.CommonCPS.RadioManagement.Controls.RMButton)target;
		}

		// Token: 0x0400002E RID: 46
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMButton btnYes;

		// Token: 0x0400002F RID: 47
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMButton btnNo;

		// Token: 0x04000030 RID: 48
		private bool _contentLoaded;
	}
}
