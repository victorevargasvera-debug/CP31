using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x0200009A RID: 154
	public class RMMultiTextFieldEditor : global::Motorola.CommonCPS.RadioManagement.Controls.RMSealedFieldEditor, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x060003BB RID: 955 RVA: 0x0003D690 File Offset: 0x0003B890
		public RMMultiTextFieldEditor()
		{
			this.InitializeComponent();
		}

		// Token: 0x060003BC RID: 956 RVA: 0x0003D6AC File Offset: 0x0003B8AC
		private void btnLock_Click(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1767378372;
			short num2 = num;
			num = (short)894242244;
			switch (num2 == num)
			{
			}
			num = (short)1803943937;
			if (num != 0)
			{
			}
			num = (short)1793261568;
			short num3 = num;
			num = (short)432144384;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Controls.RMButton rmbutton = A_0 as global::Motorola.CommonCPS.RadioManagement.Controls.RMButton;
			rmbutton.Tag = !(bool)rmbutton.Tag;
		}

		// Token: 0x060003BD RID: 957 RVA: 0x0003D774 File Offset: 0x0003B974
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 13;
			if (this._contentLoaded)
			{
				short num = (short)1238302721;
				if (num != 0)
				{
				}
				num = (short)1630310959;
				short num2 = num;
				num = (short)1631752751;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1358299136;
					short num3 = num;
					num = (short)1670381568;
					if (num != 0)
					{
					}
					return;
				}
				}
			}
			this._contentLoaded = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("誤욨\udfaa슬\uddae\udeb0\udfb2풴馶視풺킼튾껀귂蛄韆髈鿌껎뗐뫒뫔髖룘뗚볜룞蓠転胤触鷨엪껬胮鿰蟲蟴飶闸裺웼鳾渀渂甄栆月渊挌笎㸐昒昔爖欘砚爜焞唠儢䨤䬦娨Ъ䬬䘮吰弲儴制崸刺䤼倾㍀あ橄㕆⑈♊㡌⍎═㩒⅔㉖⅘⽚㭜㙞ѠརŤɦ൨ɪᥬnͰ嵲൴ᙶᑸ᝺", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x060003BE RID: 958 RVA: 0x0003D85C File Offset: 0x0003BA5C
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		internal global::System.Delegate a(global::System.Type A_0, string A_1)
		{
			short num = (short)1457061889;
			if (num != 0)
			{
			}
			num = (short)623864635;
			short num2 = num;
			num = (short)1632332603;
			switch (num2 == num)
			{
			}
			num = (short)23920640;
			short num3 = num;
			num = (short)660602880;
			if (num != 0)
			{
			}
			return global::System.Delegate.CreateDelegate(A_0, this, A_1);
		}

		// Token: 0x060003BF RID: 959 RVA: 0x0003D910 File Offset: 0x0003BB10
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)694878210;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_123;
				case 1:
				{
					num = (short)945175081;
					short num3 = num;
					num = (short)1916156457;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)2029256704;
						short num4 = num;
						num = (short)270729216;
						if (num != 0)
						{
						}
						num = (short)704053248;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
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
					goto IL_F2;
				case 2:
					goto IL_132;
				case 3:
					goto IL_E5;
				case 4:
					goto IL_D8;
				case 5:
					goto IL_125;
				case 6:
					goto IL_FF;
				default:
					num = (short)884146177;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_D8:
			this.txbText = (global::Motorola.CommonCPS.RadioManagement.Controls.RMTextBox)target;
			return;
			IL_E5:
			this.borderInvalid = (global::System.Windows.Controls.Border)target;
			return;
			IL_F2:
			this.fedString = (global::Motorola.CommonCPS.RadioManagement.Controls.RMMultiTextFieldEditor)target;
			return;
			IL_FF:
			this.btnLock = (global::Motorola.CommonCPS.RadioManagement.Controls.RMButton)target;
			return;
			IL_123:
			this._contentLoaded = true;
			return;
			IL_125:
			this.borderfreeze = (global::System.Windows.Controls.Border)target;
			return;
			IL_132:
			num = (short)1095696385;
			if (num != 0)
			{
			}
			this.grdMain = (global::System.Windows.Controls.Grid)target;
		}

		// Token: 0x060003C0 RID: 960 RVA: 0x0003DA8C File Offset: 0x0003BC8C
		// Note: this type is marked as 'beforefieldinit'.
		static RMMultiTextFieldEditor()
		{
			int a_ = 18;
			short num = (short)1654347496;
			short num2 = num;
			num = (short)1221154536;
			switch (num2 == num)
			{
			}
			num = (short)1117454337;
			if (num != 0)
			{
			}
			num = (short)22806528;
			short num3 = num;
			num = (short)851247104;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Controls.RMMultiTextFieldEditor.regexIpMask = new global::System.Text.RegularExpressions.Regex(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("톩슫\udbad\uddaf킱톳쒵芷\ud8bb鎽鲿ꛁ믅铇럋ꃍꗏ뿑뛓돕꫗胛뫝췟뻡胣췥闧뛩싫闭黯蟱駳铵鷷裹웻ꋽ擿⼁堃戅⌇眉個‍欏簑愓笕稗缙減␝簟䘡ण稥䰧ĩ儫", a_));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMMultiTextFieldEditor.regexIpAddress = new global::System.Text.RegularExpressions.Regex(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("蒫醭誯蒳鮵膷잻辽맃髅럋﷍귏觑ﯕ蟙ꟛ쳟퇡駣싥", a_));
		}

		// Token: 0x0400013B RID: 315
		private static readonly global::System.Text.RegularExpressions.Regex regexIpMask;

		// Token: 0x0400013C RID: 316
		private static readonly global::System.Text.RegularExpressions.Regex regexIpAddress;

		// Token: 0x0400013D RID: 317
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMMultiTextFieldEditor fedString;

		// Token: 0x0400013E RID: 318
		internal global::System.Windows.Controls.Grid grdMain;

		// Token: 0x0400013F RID: 319
		internal global::System.Windows.Controls.Border borderInvalid;

		// Token: 0x04000140 RID: 320
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMTextBox txbText;

		// Token: 0x04000141 RID: 321
		internal global::System.Windows.Controls.Border borderfreeze;

		// Token: 0x04000142 RID: 322
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMButton btnLock;

		// Token: 0x04000143 RID: 323
		private bool _contentLoaded;
	}
}
