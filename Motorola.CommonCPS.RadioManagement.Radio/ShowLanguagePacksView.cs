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
	// Token: 0x02000034 RID: 52
	public class ShowLanguagePacksView : global::System.Windows.Controls.UserControl, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x0600022E RID: 558 RVA: 0x00026FC8 File Offset: 0x000251C8
		public ShowLanguagePacksView()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600022F RID: 559 RVA: 0x00026FE4 File Offset: 0x000251E4
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 8;
			if (!this._contentLoaded)
			{
				short num = (short)931847620;
				short num2 = num;
				num = (short)717544900;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return;
				case 1:
					break;
				default:
				{
					num = (short)653721600;
					short num3 = num;
					break;
				}
				}
				num = (short)32964608;
				if (num != 0)
				{
				}
				num = (short)1109917697;
				if (num != 0)
				{
				}
				this._contentLoaded = true;
				global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("鎻꾿뛁ꯃ듅Ꟈꛉ귋鏏뷑맓믕럗듙鿛軝돟쳡뛣蟥賧菩菫ꏭ釯鳱闳釵鷷韹駻都瓿Ⰱ嘃朅氇按挋㔍猏紑礓昕眗琙礛瀝吟ഡ圣严䜧崩䀫伭帯唱䄳圵強弹䰻弽⌿⥁㝃ぅⅇ⽉㭋慍⍏㩑㭓⅕㑗㭙㉛㥝ᕟͣͥ͡ᡧ୩ཫխͯѱᵳ፵ཷ呹ѻώ", a_), global::System.UriKind.Relative);
				global::System.Windows.Application.LoadComponent(this, resourceLocator);
				return;
			}
		}

		// Token: 0x06000230 RID: 560 RVA: 0x000270C4 File Offset: 0x000252C4
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)730267648;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1179388243;
				short num3 = num;
				num = (short)1940851027;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)2080899072;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_83;
						}
						continue;
					case 1:
						goto IL_ED;
					case 2:
						num = (short)1333788673;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_108;
					case 4:
						num = (short)670957571;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_83:
					if (connectionId != 1)
					{
						num = (short)1441595392;
						short num4 = num;
						num = (short)1778450436;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_C9;
				}
				IL_108:
				num = (short)1074855937;
				if (num != 0)
				{
				}
				if (connectionId == 2)
				{
					goto IL_14C;
				}
				num = (short)1787494402;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_C9:
			this.dgrLanguagePacks = (global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid)target;
			return;
			IL_ED:
			this._contentLoaded = true;
			return;
			IL_14C:
			this.btnCancel = (global::Motorola.CommonCPS.RadioManagement.Controls.RMButton)target;
		}

		// Token: 0x04000124 RID: 292
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid dgrLanguagePacks;

		// Token: 0x04000125 RID: 293
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMButton btnCancel;

		// Token: 0x04000126 RID: 294
		private bool _contentLoaded;
	}
}
