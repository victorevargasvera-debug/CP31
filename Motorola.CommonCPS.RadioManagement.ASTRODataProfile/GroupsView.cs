using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Motorola.CommonCPS.RadioManagement.Controls;

namespace Motorola.CommonCPS.RadioManagement.ASTRODataProfile
{
	// Token: 0x0200000F RID: 15
	public class GroupsView : global::System.Windows.Controls.UserControl, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x06000034 RID: 52 RVA: 0x00004EC8 File Offset: 0x000030C8
		public GroupsView()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00004EE4 File Offset: 0x000030E4
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 3;
			short num = (short)1859190784;
			short num2 = num;
			num = (short)828047361;
			if (num != 0)
			{
			}
			if (this._contentLoaded)
			{
				num = (short)161282830;
				short num3 = num;
				num = (short)1326709518;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1638400;
					if (num != 0)
					{
					}
					return;
				}
			}
			this._contentLoaded = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.ModuleASTRODataProfile.b("辟쮣튥잧\ud8a9쎫슭톯鲱\ud9b5햷ힹ펻킽莿鋁韃髇ꯉ꣋ꟍ뿏鿑뗓룕맗뷙맛돝藟賡郣죥ꧧ맩룫볭뿯뛱闳苵駷꫹軻釽替欁栃挅㌇椉挋挍怏紑稓猕瘗渙㌛礝刟䴡儣嘥嬧尩䔫䬭䜯ᴱ匳䐵圷伹䰻䴽㘿⭁⅃ㅅ晇㉉ⵋ⍍㱏", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00004FC4 File Offset: 0x000031C4
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)636878848;
			short num2 = num;
			if (connectionId == 1)
			{
				num = (short)934581142;
				short num3 = num;
				num = (short)1810994070;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)295370752;
					if (num != 0)
					{
					}
					num = (short)1141571585;
					if (num != 0)
					{
					}
					this.gplGroups = (global::Motorola.CommonCPS.RadioManagement.Controls.RMGroupList)target;
					return;
				}
			}
			this._contentLoaded = true;
		}

		// Token: 0x04000016 RID: 22
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMGroupList gplGroups;

		// Token: 0x04000017 RID: 23
		private bool _contentLoaded;
	}
}
