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
	// Token: 0x02000025 RID: 37
	public class MoveGroupView : global::System.Windows.Controls.UserControl, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x060001BA RID: 442 RVA: 0x0001FB44 File Offset: 0x0001DD44
		public MoveGroupView()
		{
			this.InitializeComponent();
		}

		// Token: 0x060001BB RID: 443 RVA: 0x0001FB60 File Offset: 0x0001DD60
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 11;
			short num = (short)1648077232;
			short num2 = num;
			num = (short)1148234160;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)2115895297;
				if (num != 0)
				{
				}
				num = (short)588709888;
				if (num != 0)
				{
				}
				if (!this._contentLoaded)
				{
					this._contentLoaded = true;
					global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("邾賀곂뇄꣆믈꓊ꇌ껎￐郒뫔뫖듘듚돜鳞뇠냢쯤뗦裨迪蓬胮볰鋲鯴零黸黺郼髾漀眂⬄唆栈漊搌怎⨐瀒稔稖椘琚猜稞传圢ਤ䨦䘨崪䠬䠮䌰尲䀴䜶伸刺堼䠾湀⹂⩄ㅆⱈⱊ㽌⁎⑐⍒⍔㹖㱘ⱚ獜❞`๢।", a_), global::System.UriKind.Relative);
					global::System.Windows.Application.LoadComponent(this, resourceLocator);
					return;
				}
				num = (short)395837440;
				short num3 = num;
				break;
			}
			}
		}

		// Token: 0x060001BC RID: 444 RVA: 0x0001FC44 File Offset: 0x0001DE44
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)1609236482;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)592167299;
					short num3 = num;
					num = (short)45334915;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_14;
					default:
						num = (short)1024000001;
						if (num != 0)
						{
						}
						num = (short)531038208;
						if (num != 0)
						{
						}
						num = (short)754974721;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					goto IL_FF;
				case 2:
					goto IL_14;
				}
				goto IL_30;
				IL_14:
				switch (0)
				{
				case 0:
					IL_30:
					switch (connectionId)
					{
					case 1:
						goto IL_67;
					case 2:
						goto IL_5A;
					case 3:
						goto IL_101;
					default:
						num = (short)215351296;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					break;
				}
			}
			IL_5A:
			this.btnOK = (global::Motorola.CommonCPS.RadioManagement.Controls.RMButton)target;
			return;
			IL_67:
			this.gplGroups = (global::Motorola.CommonCPS.RadioManagement.Controls.RMGroupList)target;
			return;
			IL_FF:
			num = (short)64421888;
			short num4 = num;
			this._contentLoaded = true;
			return;
			IL_101:
			this.btnCancel = (global::Motorola.CommonCPS.RadioManagement.Controls.RMButton)target;
		}

		// Token: 0x040000C7 RID: 199
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMGroupList gplGroups;

		// Token: 0x040000C8 RID: 200
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMButton btnOK;

		// Token: 0x040000C9 RID: 201
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMButton btnCancel;

		// Token: 0x040000CA RID: 202
		private bool _contentLoaded;
	}
}
