using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Motorola.CommonCPS.RadioManagement.Controls;

namespace Motorola.CommonCPS.RadioManagement.Radio
{
	// Token: 0x0200001B RID: 27
	public class ResetIdentifiersView : global::System.Windows.Controls.UserControl, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x06000159 RID: 345 RVA: 0x000195DC File Offset: 0x000177DC
		public ResetIdentifiersView()
		{
			this.InitializeComponent();
			base.Loaded += this.a;
			base.IsVisibleChanged += this.a;
		}

		// Token: 0x0600015A RID: 346 RVA: 0x0001961C File Offset: 0x0001781C
		private void a()
		{
			short num = (short)632547262;
			short num2 = num;
			num = (short)436594622;
			switch (num2 == num)
			{
			}
			num = (short)1525219329;
			if (num != 0)
			{
			}
			num = (short)273285120;
			if (num != 0)
			{
			}
			num = (short)1275133952;
			short num3 = num;
			this.msiPassword.Focus();
		}

		// Token: 0x0600015B RID: 347 RVA: 0x000196D0 File Offset: 0x000178D0
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			int a_ = 9;
			short num = (short)1627717632;
			short num2 = num;
			num = (short)21140675;
			short num3 = num;
			num = (short)1629459651;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)166199296;
				if (num != 0)
				{
				}
				if (this._contentLoaded)
				{
					return;
				}
				break;
			}
			num = (short)1741357057;
			if (num != 0)
			{
			}
			this._contentLoaded = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("銼껀럂꫄뗆ꛈꟊ곌鋐볒룔뫖뛘뗚黜连닠췢럤蛦跨苪苬ꋮ郰鷲铴郶鳸雺飼釾甀ⴂ圄昆洈戊戌㐎爐簒研朖瘘甚砜焞唠ఢ圤䈦娨个夬䘮唰嘲嬴䌶倸崺吼娾㍀あ㍄⹆ⱈ㱊扌㵎㑐⁒ご⍖じ㽚㡜ㅞᕠ੢ͤ๦౨ᥪṬ᥮ᡰᙲɴ奶Ÿ᩺ၼ፾", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x0600015C RID: 348 RVA: 0x000197B0 File Offset: 0x000179B0
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)1834156032;
			short num2 = num;
			num = (short)1458241538;
			int num3 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num3)
				{
				case 0:
					goto IL_150;
				case 1:
					num = (short)8716288;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_5A;
					}
					continue;
				}
				IL_5A:
				switch (connectionId)
				{
				case 1:
				{
					num = (short)1530851493;
					short num4 = num;
					num = (short)264958117;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_E3;
					}
					break;
				}
				case 2:
					goto IL_15F;
				case 3:
					goto IL_A1;
				case 4:
					goto IL_94;
				case 5:
					goto IL_152;
				case 6:
					goto IL_12C;
				default:
					num = (short)660668417;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_94:
			this.msiPassword = (global::Motorola.CommonCPS.RadioManagement.Controls.RMPasswordBox)target;
			return;
			IL_A1:
			this.nmiCAI = (global::Motorola.CommonCPS.RadioManagement.Controls.RMMaskedInput)target;
			return;
			IL_E3:
			num = (short)2095448065;
			if (num != 0)
			{
			}
			num = (short)20054016;
			if (num != 0)
			{
			}
			this.tbxSerialNumber = (global::Motorola.CommonCPS.RadioManagement.Controls.RMTextBox)target;
			return;
			IL_12C:
			this.btnCancel = (global::Motorola.CommonCPS.RadioManagement.Controls.RMButton)target;
			return;
			IL_150:
			this._contentLoaded = true;
			return;
			IL_152:
			this.btnOK = (global::Motorola.CommonCPS.RadioManagement.Controls.RMButton)target;
			return;
			IL_15F:
			this.msiRadioID = (global::Motorola.CommonCPS.RadioManagement.Controls.RMMaskedInput)target;
		}

		// Token: 0x0600015D RID: 349 RVA: 0x00019930 File Offset: 0x00017B30
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private void a(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)619740115;
			short num2 = num;
			num = (short)614890451;
			switch (num2 == num)
			{
			}
			num = (short)1987510272;
			if (num != 0)
			{
			}
			num = (short)34275329;
			if (num != 0)
			{
			}
			num = (short)194969600;
			short num3 = num;
			this.a();
		}

		// Token: 0x0600015E RID: 350 RVA: 0x000199E0 File Offset: 0x00017BE0
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private void a(object A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			short num = (short)85905314;
			short num2 = num;
			num = (short)398184354;
			switch (num2 == num)
			{
			}
			num = (short)802553857;
			if (num != 0)
			{
			}
			num = (short)2101018624;
			if (num != 0)
			{
			}
			num = (short)2021916672;
			short num3 = num;
			this.a();
		}

		// Token: 0x04000099 RID: 153
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMTextBox tbxSerialNumber;

		// Token: 0x0400009A RID: 154
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMMaskedInput msiRadioID;

		// Token: 0x0400009B RID: 155
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMMaskedInput nmiCAI;

		// Token: 0x0400009C RID: 156
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMPasswordBox msiPassword;

		// Token: 0x0400009D RID: 157
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMButton btnOK;

		// Token: 0x0400009E RID: 158
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMButton btnCancel;

		// Token: 0x0400009F RID: 159
		private bool _contentLoaded;
	}
}
