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

namespace Motorola.CommonCPS.RadioManagement.Job
{
	// Token: 0x0200000B RID: 11
	[global::Motorola.CommonCPS.RadioManagement.Infrastructure.ViewExport(RegionName = "JobMainRegion")]
	public class JobsView : global::System.Windows.Controls.UserControl, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x0600002B RID: 43 RVA: 0x00003FB0 File Offset: 0x000021B0
		public JobsView()
		{
			this.InitializeComponent();
		}

		// Token: 0x1700000A RID: 10
		// (set) Token: 0x0600002C RID: 44 RVA: 0x00003FCC File Offset: 0x000021CC
		[global::System.ComponentModel.Composition.Import]
		public global::Motorola.CommonCPS.RadioManagement.Job.JobsViewModel ViewModel
		{
			set
			{
				short num = (short)1542613067;
				short num2 = num;
				num = (short)1119381579;
				switch (num2 == num)
				{
				}
				num = (short)1774190592;
				short num3 = num;
				num = (short)1853685761;
				if (num != 0)
				{
				}
				num = (short)1264582656;
				if (num != 0)
				{
				}
				base.DataContext = value;
			}
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00004080 File Offset: 0x00002280
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 9;
			if (this._contentLoaded)
			{
				short num = (short)1898743752;
				short num2 = num;
				num = (short)16091080;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1121320960;
					short num3 = num;
					num = (short)1338507264;
					if (num != 0)
					{
					}
					num = (short)1830748161;
					if (num != 0)
					{
					}
					break;
				}
				}
				return;
			}
			this._contentLoaded = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.Job.ModuleJob.b("㘘嘚爜欞丠儢䨤䬦䠨Ԫ測䀮尰帲娴夶稸欺渼ᄾፀ≂⅄⹆♈يⱌⅎぐ㑒ご㩖㱘㕚⥜煞⭠ౢݤ屦੨ѪlὮṰᵲၴ᥶൸呺᝼ၾﲊꊌﺐﺚ놞\ud9a0슢좤쮦", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00004164 File Offset: 0x00002364
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			if (connectionId == 1)
			{
				short num = (short)826146817;
				if (num != 0)
				{
				}
				num = (short)1402050373;
				short num2 = num;
				num = (short)2033882949;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_A6;
				case 1:
					break;
				default:
				{
					num = (short)1803550720;
					short num3 = num;
					break;
				}
				}
				num = (short)833880064;
				if (num != 0)
				{
				}
				IL_A6:
				this.dgrJobContainers = (global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid)target;
				return;
			}
			this._contentLoaded = true;
		}

		// Token: 0x04000019 RID: 25
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid dgrJobContainers;

		// Token: 0x0400001A RID: 26
		private bool _contentLoaded;
	}
}
