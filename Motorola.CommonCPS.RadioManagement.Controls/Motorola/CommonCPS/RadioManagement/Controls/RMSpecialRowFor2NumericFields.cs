using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Markup;
using Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x02000083 RID: 131
	public class RMSpecialRowFor2NumericFields : global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialEditorFor2Fields, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x0600031D RID: 797 RVA: 0x00032A14 File Offset: 0x00030C14
		public RMSpecialRowFor2NumericFields()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600031E RID: 798 RVA: 0x00032A30 File Offset: 0x00030C30
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			int a_ = 8;
			short num;
			if (!this._contentLoaded)
			{
				num = (short)433927642;
				short num2 = num;
				num = (short)585446874;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1181286400;
					if (num != 0)
					{
					}
					num = (short)1702297600;
					short num3 = num;
					this._contentLoaded = true;
					global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("辟쮣튥잧\ud8a9쎫슭톯鲱\ud9b5햷ힹ펻킽莿鋁韃髇ꯉ꣋ꟍ뿏鿑뗓룕맗뷙맛돝藟賡郣죥ꯧ藩苫髭苯鷱飳藵쏷駹鏻鏽烿洁樃挅昇縉⌋笍挏眑易甕眗琙栛氝伟両圣थ䤧天堫尭弯ᴱ䘳嬵䬷䨹夻崽⤿⍁⡃㑅❇㵉⩋⅍≏恑㩓⍕㕗㽙⹛㝝͟ѡൣͥѧ๩Ὣ䁭࡯፱ᥳ᩵", a_), global::System.UriKind.Relative);
					global::System.Windows.Application.LoadComponent(this, resourceLocator);
					return;
				}
				}
			}
			num = (short)2076573697;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600031F RID: 799 RVA: 0x00032B10 File Offset: 0x00030D10
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal global::System.Delegate a(global::System.Type A_0, string A_1)
		{
			short num = (short)683462350;
			short num2 = num;
			num = (short)1558433486;
			switch (num2 == num)
			{
			}
			num = (short)442826752;
			short num3 = num;
			num = (short)888143872;
			if (num != 0)
			{
			}
			num = (short)1285619713;
			if (num != 0)
			{
			}
			return global::System.Delegate.CreateDelegate(A_0, this, A_1);
		}

		// Token: 0x06000320 RID: 800 RVA: 0x00032BC4 File Offset: 0x00030DC4
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)1778122753;
			if (num != 0)
			{
			}
			num = (short)771555331;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1987051520;
				short num3 = num;
				switch (num2)
				{
				case 0:
					goto IL_110;
				case 1:
					num = (short)1895104512;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					num = (short)1155268612;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_89;
					}
					continue;
				case 4:
					if (connectionId != 2)
					{
						num = (short)143589377;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_146;
				}
				IL_89:
				if (connectionId == 1)
				{
					num = (short)1100015177;
					short num4 = num;
					num = (short)2022172233;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_D7;
					}
				}
				num = (short)1603534850;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_D7:
			num = (short)1751646208;
			if (num != 0)
			{
			}
			this.FD1 = (global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericFieldEditor)target;
			return;
			IL_110:
			this._contentLoaded = true;
			return;
			IL_146:
			this.FD2 = (global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericFieldEditor)target;
		}

		// Token: 0x040000FE RID: 254
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericFieldEditor FD1;

		// Token: 0x040000FF RID: 255
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericFieldEditor FD2;

		// Token: 0x04000100 RID: 256
		private bool _contentLoaded;
	}
}
