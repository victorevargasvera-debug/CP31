using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Markup;
using Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x02000085 RID: 133
	public class RMSpecialRowFor2BoolFields : global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialEditorFor2Fields, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x06000325 RID: 805 RVA: 0x0003304C File Offset: 0x0003124C
		public RMSpecialRowFor2BoolFields()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000326 RID: 806 RVA: 0x00033068 File Offset: 0x00031268
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			int a_ = 8;
			short num = (short)1079640065;
			if (num != 0)
			{
			}
			if (!this._contentLoaded)
			{
				num = (short)690071856;
				short num2 = num;
				num = (short)2042079536;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)167510016;
					if (num != 0)
					{
					}
					num = (short)840433664;
					short num3 = num;
					this._contentLoaded = true;
					global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("辟쮣튥잧\ud8a9쎫슭톯鲱\ud9b5햷ힹ펻킽莿鋁韃髇ꯉ꣋ꟍ뿏鿑뗓룕맗뷙맛돝藟賡郣죥ꯧ藩苫髭苯鷱飳藵쏷駹鏻鏽烿洁樃挅昇縉⌋笍挏眑易甕眗琙栛氝伟両圣थ䤧天堫尭弯ᴱ䘳嬵䬷䨹夻崽⤿⍁⡃㑅❇㵉⩋⅍≏恑㙓㥕㝗㙙㩛㝝՟๡cᕥ䙧ቩ൫ͭᱯ", a_), global::System.UriKind.Relative);
					global::System.Windows.Application.LoadComponent(this, resourceLocator);
					return;
				}
				}
			}
		}

		// Token: 0x06000327 RID: 807 RVA: 0x00033148 File Offset: 0x00031348
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal global::System.Delegate a(global::System.Type A_0, string A_1)
		{
			short num = (short)811532289;
			if (num != 0)
			{
			}
			num = (short)1972449001;
			short num2 = num;
			num = (short)221458153;
			switch (num2 == num)
			{
			default:
			{
				num = (short)2135228416;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)747372544;
			if (num != 0)
			{
			}
			return global::System.Delegate.CreateDelegate(A_0, this, A_1);
		}

		// Token: 0x06000328 RID: 808 RVA: 0x000331FC File Offset: 0x000313FC
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)378667011;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_113;
				case 1:
					num = (short)1637482496;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					num = (short)539295748;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_38;
					}
					continue;
				case 4:
					if (connectionId != 2)
					{
						num = (short)397475841;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_14B;
				}
				IL_38:
				num = (short)909639680;
				short num3 = num;
				if (connectionId == 1)
				{
					num = (short)1710030849;
					if (num != 0)
					{
					}
					num = (short)1795905695;
					short num4 = num;
					num = (short)1045059743;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_D9;
					}
				}
				num = (short)1903624194;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_D9:
			num = (short)615907328;
			if (num != 0)
			{
			}
			this.FD1 = (global::Motorola.CommonCPS.RadioManagement.Controls.RMBoolFieldEditor)target;
			return;
			IL_113:
			this._contentLoaded = true;
			return;
			IL_14B:
			this.FD2 = (global::Motorola.CommonCPS.RadioManagement.Controls.RMBoolFieldEditor)target;
		}

		// Token: 0x04000104 RID: 260
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMBoolFieldEditor FD1;

		// Token: 0x04000105 RID: 261
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMBoolFieldEditor FD2;

		// Token: 0x04000106 RID: 262
		private bool _contentLoaded;
	}
}
