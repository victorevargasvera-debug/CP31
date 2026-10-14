using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Data;
using System.Windows.Markup;
using Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x0200008D RID: 141
	public class RMExtendedFeatureSetsEditor : global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x0600034F RID: 847 RVA: 0x00037384 File Offset: 0x00035584
		public RMExtendedFeatureSetsEditor()
		{
			this.InitializeComponent();
			base.SetDefaultBindings();
			base.Loaded += this.RMExtendedFeatureSetsEditor_Loaded;
		}

		// Token: 0x06000350 RID: 848 RVA: 0x000373B8 File Offset: 0x000355B8
		private void RMExtendedFeatureSetsEditor_Loaded(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)207155878;
			short num2 = num;
			num = (short)352842406;
			switch (num2 == num)
			{
			default:
			{
				num = (short)145031168;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)396165121;
			if (num != 0)
			{
			}
			num = (short)1168703488;
			if (num != 0)
			{
			}
			this.a();
		}

		// Token: 0x06000351 RID: 849 RVA: 0x0003746C File Offset: 0x0003566C
		private void a()
		{
			int a_ = 17;
			switch (0)
			{
			case 0:
				goto IL_4D;
			}
			short num;
			global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter rmsetPresenter;
			for (;;)
			{
				IL_13:
				num = (short)1105330176;
				short num2 = num;
				int num3;
				switch (num3)
				{
				case 0:
					goto IL_D8;
				case 1:
					if (rmsetPresenter != null)
					{
						num = (short)1317863424;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 2:
					goto IL_12E;
				}
				goto IL_4D;
			}
			IL_12E:
			num = (short)1316814849;
			if (num != 0)
			{
			}
			return;
			IL_4D:
			rmsetPresenter = global::Motorola.CommonCPS.RadioManagement.Controls.Utility.a(this.dgrMismatchOptions, false);
			num = (short)1423650699;
			short num4 = num;
			num = (short)1085419403;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_D8:
				global::System.Windows.Data.Binding binding = new global::System.Windows.Data.Binding();
				binding.Path = new global::System.Windows.PropertyPath(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("\ud9aa쒬쮮횲풴얶\udab8펺ﺼ킾곀껂꓄꧆귈", a_), global::System.Array.Empty<object>());
				binding.Source = rmsetPresenter;
				this.dgrMismatchOptions.SetBinding(global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid.SearchCommandProperty, binding);
				num = (short)483852290;
				int num3 = (int)((global::System.IntPtr)num);
				goto IL_13;
			}
			default:
			{
				num = (short)1125253120;
				if (num != 0)
				{
				}
				num = (short)1638924289;
				int num3 = (int)((global::System.IntPtr)num);
				goto IL_13;
			}
			}
		}

		// Token: 0x06000352 RID: 850 RVA: 0x000375D0 File Offset: 0x000357D0
		public void RMFeatureSetsEditor_DataContextChanged(object sender, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			if (e.NewValue == null)
			{
				short num = (short)1609068980;
				short num2 = num;
				num = (short)1766093236;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1164312576;
					short num3 = num;
					num = (short)1306591233;
					if (num != 0)
					{
					}
					num = (short)1851916288;
					if (num != 0)
					{
					}
					break;
				}
				}
				return;
			}
			this.dgrMismatchOptions.UpdateLayout();
		}

		// Token: 0x06000353 RID: 851 RVA: 0x00037694 File Offset: 0x00035894
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 13;
			if (this._contentLoaded)
			{
				short num = (short)164253979;
				short num2 = num;
				num = (short)2090291483;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)940703744;
					short num3 = num;
					num = (short)1947598848;
					if (num != 0)
					{
					}
					break;
				}
				}
				num = (short)520421377;
				if (num != 0)
				{
				}
				return;
			}
			this._contentLoaded = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("誤욨\udfaa슬\uddae\udeb0\udfb2풴馶視풺킼튾껀귂蛄韆髈鿌껎뗐뫒뫔髖룘뗚볜룞蓠転胤触鷨엪껬胮鿰蟲蟴飶闸裺웼鳾渀渂甄栆月渊挌笎㸐昒昔爖欘砚爜焞唠儢䨤䬦娨Ъ䬬䘮吰弲儴制崸刺䤼倾㍀あ橄㕆⑈⹊㕌㭎㑐㵒ㅔ㉖㵘㵚㡜㹞ᕠᙢᝤɦᩨ๪६ٮհᱲݴ奶Ÿ᩺ၼ፾", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06000354 RID: 852 RVA: 0x00037778 File Offset: 0x00035978
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		internal global::System.Delegate a(global::System.Type A_0, string A_1)
		{
			short num = (short)1509828553;
			short num2 = num;
			num = (short)794765257;
			switch (num2 == num)
			{
			default:
			{
				num = (short)129302528;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)515047425;
			if (num != 0)
			{
			}
			num = (short)277872640;
			if (num != 0)
			{
			}
			return global::System.Delegate.CreateDelegate(A_0, this, A_1);
		}

		// Token: 0x06000355 RID: 853 RVA: 0x0003782C File Offset: 0x00035A2C
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			if (connectionId == 1)
			{
				short num = (short)383004274;
				short num2 = num;
				num = (short)1872703090;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1483472896;
					short num3 = num;
					num = (short)1912209409;
					if (num != 0)
					{
					}
					num = (short)445251584;
					if (num != 0)
					{
					}
					break;
				}
				}
				this.dgrMismatchOptions = (global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid)target;
				return;
			}
			this._contentLoaded = true;
		}

		// Token: 0x0400010E RID: 270
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid dgrMismatchOptions;

		// Token: 0x0400010F RID: 271
		private bool _contentLoaded;
	}
}
