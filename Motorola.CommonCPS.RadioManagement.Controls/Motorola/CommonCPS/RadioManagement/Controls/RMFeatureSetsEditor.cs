using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Data;
using System.Windows.Markup;
using Infragistics.Windows.DataPresenter;
using Infragistics.Windows.DataPresenter.Events;
using Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x020000D6 RID: 214
	public class RMFeatureSetsEditor : global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x06000608 RID: 1544 RVA: 0x00061430 File Offset: 0x0005F630
		public RMFeatureSetsEditor()
		{
			this.InitializeComponent();
			base.SetDefaultBindings();
			base.DataContextChanged += this.RMFeatureSetsEditor_DataContextChanged;
			base.Loaded += this.RMFeatureSetsEditor_Loaded;
		}

		// Token: 0x06000609 RID: 1545 RVA: 0x00061474 File Offset: 0x0005F674
		private void RMFeatureSetsEditor_Loaded(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1288193591;
			short num2 = num;
			num = (short)499729975;
			switch (num2 == num)
			{
			}
			num = (short)570032128;
			short num3 = num;
			num = (short)594411521;
			if (num != 0)
			{
			}
			num = (short)252575744;
			if (num != 0)
			{
			}
			this.a();
		}

		// Token: 0x0600060A RID: 1546 RVA: 0x00061528 File Offset: 0x0005F728
		private void a()
		{
			int a_ = 11;
			switch (0)
			{
			case 0:
				goto IL_25;
			}
			int num;
			global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter rmsetPresenter;
			short num2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					goto IL_E0;
				case 1:
					if (rmsetPresenter != null)
					{
						num2 = (short)1298071554;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 2:
				{
					global::System.Windows.Data.Binding binding = new global::System.Windows.Data.Binding();
					binding.Path = new global::System.Windows.PropertyPath(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("힤캦춨좬캮쎰킲\uddb4횸횺킼\udebe꿀Ꟃ", a_), global::System.Array.Empty<object>());
					binding.Source = rmsetPresenter;
					this.dgrMismatchOptions.SetBinding(global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid.SearchCommandProperty, binding);
					num2 = (short)2098397184;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_25;
			}
			IL_E0:
			num2 = (short)648539911;
			short num3 = num2;
			num2 = (short)1373564679;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num2 = (short)481689600;
				if (num2 != 0)
				{
				}
				num2 = (short)176881665;
				if (num2 != 0)
				{
				}
				break;
			}
			return;
			IL_25:
			num2 = (short)1582759936;
			short num4 = num2;
			rmsetPresenter = global::Motorola.CommonCPS.RadioManagement.Controls.Utility.a(this.dgrMismatchOptions, false);
			num2 = (short)745209857;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x0600060B RID: 1547 RVA: 0x00061688 File Offset: 0x0005F888
		public void RMFeatureSetsEditor_DataContextChanged(object sender, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			if (e.NewValue == null)
			{
				short num = (short)1598881792;
				short num2 = num;
			}
			else
			{
				short num = (short)985916218;
				short num3 = num;
				num = (short)459858746;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1607467008;
					if (num != 0)
					{
					}
					num = (short)832045057;
					if (num != 0)
					{
					}
					this.dgrMismatchOptions.UpdateLayout();
					return;
				}
			}
		}

		// Token: 0x0600060C RID: 1548 RVA: 0x00061748 File Offset: 0x0005F948
		private void dgrMismatchOptions_InitializeRecord(object A_0, global::Infragistics.Windows.DataPresenter.Events.InitializeRecordEventArgs A_1)
		{
			short num = (short)1679556612;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_110;
				case 1:
				{
					num = (short)840237057;
					if (num != 0)
					{
					}
					global::Motorola.CommonCPS.RadioManagement.UIModels.FeatureOptionStatus featureOptionStatus;
					if (featureOptionStatus != null)
					{
						num = (short)624754691;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				case 2:
				{
					num = (short)1100056784;
					short num3 = num;
					num = (short)411797712;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_110;
					default:
					{
						num = (short)123076608;
						if (num != 0)
						{
						}
						global::Motorola.CommonCPS.RadioManagement.UIModels.FeatureOptionStatus featureOptionStatus;
						if (!featureOptionStatus.Visible)
						{
							num = (short)2122776576;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					}
					break;
				}
				case 3:
				{
					num = (short)1095237632;
					short num4 = num;
					num = (short)2092564482;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
					switch (0)
					{
					case 0:
						goto IL_40;
					}
					continue;
				case 5:
				{
					global::Motorola.CommonCPS.RadioManagement.UIModels.FeatureOptionStatus featureOptionStatus = ((global::Infragistics.Windows.DataPresenter.DataRecord)A_1.Record).DataItem as global::Motorola.CommonCPS.RadioManagement.UIModels.FeatureOptionStatus;
					num = (short)1388052481;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 6:
					return;
				}
				IL_40:
				if (A_1.Record != null)
				{
					num = (short)1273102341;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_110:
				A_1.Record.Visibility = global::System.Windows.Visibility.Collapsed;
				num = (short)1325858822;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x0600060D RID: 1549 RVA: 0x0006190C File Offset: 0x0005FB0C
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			int a_ = 9;
			short num;
			if (this._contentLoaded)
			{
				num = (short)1548279601;
				short num2 = num;
				num = (short)321707825;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1252524033;
					if (num != 0)
					{
					}
					num = (short)1883832320;
					if (num != 0)
					{
					}
					return;
				}
			}
			num = (short)562429952;
			short num3 = num;
			this._contentLoaded = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("躠쪤펦욨\ud9aa슬쎮킰鶲\ud8b6풸횺튼톾苀鏂雄鯈꫊꧌ꛎ뻐黒듔맖룘볚룜닞蓠跢釤짦ꫨ蓪菬鯮菰鳲駴蓶싸飺鋼鋾焀氂欄戆月缊∌税成瘒朔琖瘘甚検洞丠伢嘤ࠦ伨䈪䠬䌮唰嘲儴帶䴸吺似䰾湀ㅂ⡄ⅆⱈ⩊㥌㩎⍐㙒♔㉖ⵘ⡚㡜㭞ࡠᝢ੤ᕦ䝨፪౬ɮᵰ", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x0600060E RID: 1550 RVA: 0x000619EC File Offset: 0x0005FBEC
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal global::System.Delegate a(global::System.Type A_0, string A_1)
		{
			short num = (short)1066612870;
			short num2 = num;
			num = (short)471218310;
			switch (num2 == num)
			{
			}
			num = (short)1018167297;
			if (num != 0)
			{
			}
			num = (short)358612992;
			if (num != 0)
			{
			}
			num = (short)977600512;
			short num3 = num;
			return global::System.Delegate.CreateDelegate(A_0, this, A_1);
		}

		// Token: 0x0600060F RID: 1551 RVA: 0x00061AA0 File Offset: 0x0005FCA0
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num;
			if (connectionId == 1)
			{
				num = (short)1399783425;
				if (num != 0)
				{
				}
				num = (short)1803239760;
				short num2 = num;
				num = (short)1379221840;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)2059993088;
					if (num != 0)
					{
					}
					this.dgrMismatchOptions = (global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid)target;
					return;
				}
			}
			num = (short)872284160;
			short num3 = num;
			this._contentLoaded = true;
		}

		// Token: 0x0400029C RID: 668
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid dgrMismatchOptions;

		// Token: 0x0400029D RID: 669
		private bool _contentLoaded;
	}
}
