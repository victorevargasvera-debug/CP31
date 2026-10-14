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

namespace Motorola.CommonCPS.RadioManagement.Radio
{
	// Token: 0x0200000C RID: 12
	[global::Motorola.CommonCPS.RadioManagement.Infrastructure.ViewExport(RegionName = "RadioMainRegion")]
	public class DetailsView : global::System.Windows.Controls.UserControl, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x0600002E RID: 46 RVA: 0x00005634 File Offset: 0x00003834
		public DetailsView()
		{
			this.InitializeComponent();
		}

		// Token: 0x1700000A RID: 10
		// (set) Token: 0x0600002F RID: 47 RVA: 0x00005650 File Offset: 0x00003850
		[global::System.ComponentModel.Composition.Import]
		public global::Motorola.CommonCPS.RadioManagement.Radio.DetailsViewModel ViewModel
		{
			set
			{
				short num = (short)1070725272;
				short num2 = num;
				num = (short)690878616;
				switch (num2 == num)
				{
				}
				num = (short)1036124161;
				if (num != 0)
				{
				}
				num = (short)39124992;
				if (num != 0)
				{
				}
				num = (short)998637568;
				short num3 = num;
				base.DataContext = value;
			}
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00005700 File Offset: 0x00003900
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			int a_ = 0;
			if (this._contentLoaded)
			{
				short num = (short)623306219;
				short num2 = num;
				num = (short)239789547;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1737949184;
					if (num != 0)
					{
					}
					num = (short)127467520;
					short num3 = num;
					num = (short)89718785;
					if (num != 0)
					{
					}
					return;
				}
				}
			}
			this._contentLoaded = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("鮳﮵ힷ캹펻첽꾿껁ꗃ诇ꗉꇋꏍ뿏병韓蛕诗軛뿝蓟诡诣ꯥ觧蓩跫觭闯鿱釳飵賷퓹껻鿽擿欁欃㴅欇攉愋縍缏簑焓砕気㔙砛笝吟䌡䴣䨥嬧尩䔫䬭䜯ᴱ倳匵䰷嬹唻刽㌿㑁ⵃ⍅㽇摉㑋⽍㵏㹑", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06000031 RID: 49 RVA: 0x000057E0 File Offset: 0x000039E0
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			if (connectionId == 1)
			{
				short num = (short)1049144358;
				short num2 = num;
				num = (short)864726054;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)867106817;
					if (num != 0)
					{
					}
					num = (short)169738240;
					if (num != 0)
					{
					}
					num = (short)1077870592;
					short num3 = num;
					this.rdRadioDetail = (global::Motorola.CommonCPS.RadioManagement.Controls.RMRadioDetail)target;
					return;
				}
				}
			}
			this._contentLoaded = true;
		}

		// Token: 0x04000028 RID: 40
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMRadioDetail rdRadioDetail;

		// Token: 0x04000029 RID: 41
		private bool _contentLoaded;
	}
}
