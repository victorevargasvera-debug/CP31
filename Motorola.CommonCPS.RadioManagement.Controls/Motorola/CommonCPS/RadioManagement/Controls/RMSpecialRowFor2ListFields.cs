using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Markup;
using Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x02000084 RID: 132
	public class RMSpecialRowFor2ListFields : global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialEditorFor2Fields, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x06000321 RID: 801 RVA: 0x00032D2C File Offset: 0x00030F2C
		public RMSpecialRowFor2ListFields()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000322 RID: 802 RVA: 0x00032D48 File Offset: 0x00030F48
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 8;
			short num;
			if (!this._contentLoaded)
			{
				num = (short)1663802216;
				short num2 = num;
				num = (short)955292520;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1110966272;
					if (num != 0)
					{
					}
					num = (short)972161024;
					short num3 = num;
					this._contentLoaded = true;
					global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("辟쮣튥잧\ud8a9쎫슭톯鲱\ud9b5햷ힹ펻킽莿鋁韃髇ꯉ꣋ꟍ뿏鿑뗓룕맗뷙맛돝藟賡郣죥ꯧ藩苫髭苯鷱飳藵쏷駹鏻鏽烿洁樃挅昇縉⌋笍挏眑易甕眗琙栛氝伟両圣थ䤧天堫尭弯ᴱ䘳嬵䬷䨹夻崽⤿⍁⡃㑅❇㵉⩋⅍≏恑㡓㽕⭗⹙㩛㝝՟๡cᕥ䙧ቩ൫ͭᱯ", a_), global::System.UriKind.Relative);
					global::System.Windows.Application.LoadComponent(this, resourceLocator);
					return;
				}
				}
			}
			num = (short)594411521;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000323 RID: 803 RVA: 0x00032E28 File Offset: 0x00031028
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		internal global::System.Delegate a(global::System.Type A_0, string A_1)
		{
			short num = (short)1825881286;
			short num2 = num;
			num = (short)1754840262;
			switch (num2 == num)
			{
			}
			num = (short)1785921536;
			short num3 = num;
			num = (short)2035154944;
			if (num != 0)
			{
			}
			num = (short)963837953;
			if (num != 0)
			{
			}
			return global::System.Delegate.CreateDelegate(A_0, this, A_1);
		}

		// Token: 0x06000324 RID: 804 RVA: 0x00032EDC File Offset: 0x000310DC
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)996868099;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_115;
				case 1:
					num = (short)1051852800;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					num = (short)753205252;
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
						num = (short)1689190401;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_14E;
				}
				IL_38:
				num = (short)1404829696;
				short num3 = num;
				if (connectionId == 1)
				{
					num = (short)1799811506;
					short num4 = num;
					num = (short)1547760050;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_B2;
					}
				}
				num = (short)250871810;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_B2:
			num = (short)1773862913;
			if (num != 0)
			{
			}
			num = (short)500367360;
			if (num != 0)
			{
			}
			this.FD1 = (global::Motorola.CommonCPS.RadioManagement.Controls.RMListFieldEditor)target;
			return;
			IL_115:
			this._contentLoaded = true;
			return;
			IL_14E:
			this.FD2 = (global::Motorola.CommonCPS.RadioManagement.Controls.RMListFieldEditor)target;
		}

		// Token: 0x04000101 RID: 257
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMListFieldEditor FD1;

		// Token: 0x04000102 RID: 258
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMListFieldEditor FD2;

		// Token: 0x04000103 RID: 259
		private bool _contentLoaded;
	}
}
