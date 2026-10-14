using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Motorola.CommonCPS.RadioManagement.Controls;

namespace Motorola.CommonCPS.RadioManagement.Template
{
	// Token: 0x02000011 RID: 17
	public class ShowVAPacksView : global::System.Windows.Controls.UserControl, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x06000090 RID: 144 RVA: 0x0000AEE0 File Offset: 0x000090E0
		public ShowVAPacksView()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000091 RID: 145 RVA: 0x0000AEFC File Offset: 0x000090FC
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 4;
			if (this._contentLoaded)
			{
				short num = (short)1287651329;
				if (num != 0)
				{
				}
				num = (short)1146499540;
				short num2 = num;
				num = (short)1532375508;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_B2;
				case 1:
					break;
				default:
				{
					num = (short)788594688;
					short num3 = num;
					break;
				}
				}
				num = (short)1818427392;
				if (num != 0)
				{
				}
				return;
			}
			IL_B2:
			this._contentLoaded = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.Template.ShowVAPacksViewModel.b("ퟷ럹鏻諽濿瀁欃樅椇␉伋愍紏缑笓砕嬗䨙伛〝爟䌡䀣伥䜧朩䴫䀭儯唱儳嬵崷吹䠻ွᐿ❁⥃㙅⑇⭉㡋⭍歏ㅑ㭓㭕⡗㕙㉛㭝๟ᙡ䭣ᕥgթ᭫ᡭᅯɱᕳᕵ፷ॹ੻᝽ꮃﮋ얟햡誣\udea5즧잩삫", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06000092 RID: 146 RVA: 0x0000AFE0 File Offset: 0x000091E0
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)835452931;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1826112630;
					short num3 = num;
					num = (short)1307264118;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_60;
					default:
						goto IL_EB;
					}
					break;
				}
				case 1:
					if (connectionId != 2)
					{
						num = (short)1692925954;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_A9;
				case 2:
					goto IL_60;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_38;
					}
					continue;
				case 4:
					num = (short)2073100289;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_38:
				if (connectionId != 1)
				{
					num = (short)988479492;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_60:
				num = (short)290062336;
				num2 = (int)((global::System.IntPtr)num);
			}
			this.dgrVAPacks = (global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid)target;
			return;
			IL_A9:
			this.btnCancel = (global::Motorola.CommonCPS.RadioManagement.Controls.RMButton)target;
			return;
			IL_EB:
			num = (short)1552416769;
			if (num != 0)
			{
			}
			num = (short)1660551168;
			if (num != 0)
			{
			}
			num = (short)99287040;
			short num4 = num;
			this._contentLoaded = true;
		}

		// Token: 0x0400003F RID: 63
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid dgrVAPacks;

		// Token: 0x04000040 RID: 64
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMButton btnCancel;

		// Token: 0x04000041 RID: 65
		private bool _contentLoaded;
	}
}
