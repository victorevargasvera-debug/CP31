using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Markup;
using Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x02000118 RID: 280
	public class RMRetryWindow : global::System.Windows.Window, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x060008D3 RID: 2259 RVA: 0x000929A0 File Offset: 0x00090BA0
		public RMRetryWindow()
		{
			this.InitializeComponent();
		}

		// Token: 0x060008D4 RID: 2260 RVA: 0x000929BC File Offset: 0x00090BBC
		private void btnRetry_Click(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)307501185;
			short num2 = num;
			num = (short)1070995585;
			switch (num2 == num)
			{
			}
			num = (short)315817985;
			if (num != 0)
			{
			}
			num = (short)1101660160;
			if (num != 0)
			{
			}
			num = (short)1769340928;
			short num3 = num;
			((global::Motorola.CommonCPS.RadioManagement.UIModels.RetryConfirmation)base.DataContext).Confirmed = true;
			base.Close();
		}

		// Token: 0x060008D5 RID: 2261 RVA: 0x00092A7C File Offset: 0x00090C7C
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 11;
			if (this._contentLoaded)
			{
				short num = (short)1681521375;
				short num2 = num;
				num = (short)791870175;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1103757313;
					if (num != 0)
					{
					}
					num = (short)1329266688;
					short num3 = num;
					num = (short)766574592;
					if (num != 0)
					{
					}
					return;
				}
				}
			}
			this._contentLoaded = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("貢좦\udda8쒪\udfac삮\uddb0튲鮴횸횺킼킾꿀胂闄铆駊곌ꯎ룐볒飔뛖럘뫚뫜뫞賠蛢诤鏦쟨꣪苬臮藰臲髴鯶諸샺黼郾氀猂樄椆氈攊礌‎昐稒笔猖瘘氚渜〞匠丢圤䈦崨太听堮堰崲儴堶丸ᔺ䔼帾ⱀ⽂", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x060008D6 RID: 2262 RVA: 0x00092B60 File Offset: 0x00090D60
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal global::System.Delegate a(global::System.Type A_0, string A_1)
		{
			short num = (short)798740353;
			short num2 = num;
			num = (short)599576449;
			switch (num2 == num)
			{
			}
			num = (short)106496000;
			if (num != 0)
			{
			}
			num = (short)811597825;
			if (num != 0)
			{
			}
			num = (short)1535246336;
			short num3 = num;
			return global::System.Delegate.CreateDelegate(A_0, this, A_1);
		}

		// Token: 0x060008D7 RID: 2263 RVA: 0x00092C10 File Offset: 0x00090E10
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			if (connectionId == 1)
			{
				short num = (short)136846044;
				short num2 = num;
				num = (short)1207114460;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1288765440;
					if (num != 0)
					{
					}
					num = (short)1320026112;
					short num3 = num;
					num = (short)1174274049;
					if (num != 0)
					{
					}
					this.btnRetry = (global::Motorola.CommonCPS.RadioManagement.Controls.RMButton)target;
					return;
				}
				}
			}
			this._contentLoaded = true;
		}

		// Token: 0x0400041C RID: 1052
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMButton btnRetry;

		// Token: 0x0400041D RID: 1053
		private bool _contentLoaded;
	}
}
