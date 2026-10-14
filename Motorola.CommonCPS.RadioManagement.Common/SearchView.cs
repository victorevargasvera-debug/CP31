using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.Composition;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Motorola.CommonCPS.RadioManagement.Controls;
using Motorola.CommonCPS.RadioManagement.Infrastructure;

namespace Motorola.CommonCPS.RadioManagement.Common
{
	// Token: 0x0200003E RID: 62
	[global::Motorola.CommonCPS.RadioManagement.Infrastructure.ViewExport(RegionName = "SearchRegion")]
	public class SearchView : global::System.Windows.Controls.UserControl, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x060001A8 RID: 424 RVA: 0x0001DA98 File Offset: 0x0001BC98
		public SearchView()
		{
			this.InitializeComponent();
		}

		// Token: 0x1700004F RID: 79
		// (set) Token: 0x060001A9 RID: 425 RVA: 0x0001DAB4 File Offset: 0x0001BCB4
		[global::System.ComponentModel.Composition.Import]
		public global::Motorola.CommonCPS.RadioManagement.Common.SearchViewModel ViewModel
		{
			set
			{
				short num = (short)1513482495;
				short num2 = num;
				num = (short)617277695;
				switch (num2 == num)
				{
				}
				num = (short)474480640;
				short num3 = num;
				num = (short)1996423169;
				if (num != 0)
				{
				}
				num = (short)344391680;
				if (num != 0)
				{
				}
				base.DataContext = value;
			}
		}

		// Token: 0x060001AA RID: 426 RVA: 0x0001DB64 File Offset: 0x0001BD64
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 11;
			if (this._contentLoaded)
			{
				short num = (short)1070071808;
				short num2 = num;
				num = (short)1004154835;
				short num3 = num;
				num = (short)1992175571;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)797966337;
					if (num != 0)
					{
					}
					num = (short)2130968576;
					if (num != 0)
					{
					}
					return;
				}
			}
			this._contentLoaded = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("鋞軠韢諤闦蛨蟪賬쇮닰鳲飴髶雸闺뻼꿾刀ⴂ圄昆洈戊戌䈎瀐紒琔瀖簘瘚砜焞唠ഢ昤䠦䐨䘪䈬䄮ਰ倲娴娶䤸吺匼娾⽀㝂橄㑆ⱈ⩊㽌ⱎ㥐╒㱔㉖⹘瑚⹜㩞`ᅢ٤སὨɪ࡬ᡮ彰୲ᑴ᩶ᕸ", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x060001AB RID: 427 RVA: 0x0001DC48 File Offset: 0x0001BE48
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)1131413505;
			if (num != 0)
			{
			}
			num = (short)1136984068;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)609740932;
					short num3 = num;
					num = (short)1968695428;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						goto IL_140;
					}
					break;
				}
				case 1:
				{
					num = (short)50200576;
					short num4 = num;
					num = (short)652083203;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					num = (short)1852964864;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (connectionId != 2)
					{
						num = (short)1697185794;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_FE;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_61;
					}
					continue;
				}
				IL_61:
				if (connectionId == 1)
				{
					break;
				}
				num = (short)490274817;
				num2 = (int)((global::System.IntPtr)num);
			}
			this.msiKeyWords = (global::Motorola.CommonCPS.RadioManagement.Controls.RMMaskedInput)target;
			return;
			IL_FE:
			this.lbtSearch = (global::Motorola.CommonCPS.RadioManagement.Controls.RMLinkButton)target;
			return;
			IL_140:
			num = (short)916127744;
			if (num != 0)
			{
			}
			this._contentLoaded = true;
		}

		// Token: 0x0400013E RID: 318
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMMaskedInput msiKeyWords;

		// Token: 0x0400013F RID: 319
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMLinkButton lbtSearch;

		// Token: 0x04000140 RID: 320
		private bool _contentLoaded;
	}
}
