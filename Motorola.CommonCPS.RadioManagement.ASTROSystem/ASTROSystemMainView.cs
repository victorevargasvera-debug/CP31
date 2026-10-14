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

namespace Motorola.CommonCPS.RadioManagement.ASTROSystem
{
	// Token: 0x0200001D RID: 29
	[global::Motorola.CommonCPS.RadioManagement.Infrastructure.ViewExport(RegionName = "MainRegion")]
	public class ASTROSystemMainView : global::System.Windows.Controls.UserControl, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x060000B9 RID: 185 RVA: 0x0000C690 File Offset: 0x0000A890
		public ASTROSystemMainView()
		{
			this.InitializeComponent();
		}

		// Token: 0x17000022 RID: 34
		// (set) Token: 0x060000BA RID: 186 RVA: 0x0000C6AC File Offset: 0x0000A8AC
		[global::System.ComponentModel.Composition.Import]
		public global::Motorola.CommonCPS.RadioManagement.ASTROSystem.MainViewModel ViewModel
		{
			set
			{
				short num = (short)977580294;
				short num2 = num;
				num = (short)451784966;
				switch (num2 == num)
				{
				}
				num = (short)1242169345;
				if (num != 0)
				{
				}
				num = (short)544276480;
				if (num != 0)
				{
				}
				num = (short)702283776;
				short num3 = num;
				base.DataContext = value;
			}
		}

		// Token: 0x060000BB RID: 187 RVA: 0x0000C75C File Offset: 0x0000A95C
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 16;
			short num;
			for (;;)
			{
				num = (short)1811873792;
				short num2 = num;
				if (!this._contentLoaded)
				{
					goto IL_AF;
				}
				num = (short)151467327;
				short num3 = num;
				num = (short)1825322303;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_71;
				}
			}
			IL_71:
			num = (short)21692416;
			if (num != 0)
			{
			}
			num = (short)1728380929;
			if (num != 0)
			{
			}
			return;
			IL_AF:
			this._contentLoaded = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.ASTROSystem.ModuleASTROSystem.b("趡즥\udca7얩\udeab솭\udcaf펱骳ힷힹ톻톽꺿臁铃闅飉귋꫍맏뷑駓럕뛗믙믛믝跟蟡諣鋥웧ꯩ뿫뫭ꋯ뷱ꟳ迵请軹駻鏽㯿愁欃欅砇攉戋欍縏昑㬓笕礗猙爛栝䤟䜡匣ࠥ倧䬩䄫䈭", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x060000BC RID: 188 RVA: 0x0000C83C File Offset: 0x0000AA3C
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)936837120;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_32;
					}
					continue;
				case 1:
				{
					num = (short)787337155;
					short num3 = num;
					num = (short)1801048003;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_103;
					case 1:
						break;
					default:
					{
						num = (short)777584640;
						short num4 = num;
						break;
					}
					}
					num = (short)872284160;
					if (num != 0)
					{
					}
					num = (short)96534530;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					goto IL_127;
				}
				IL_32:
				switch (connectionId)
				{
				case 1:
					goto IL_103;
				case 2:
					goto IL_CF;
				case 3:
					goto IL_129;
				default:
					num = (short)1844838401;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_CF:
			num = (short)643432449;
			if (num != 0)
			{
			}
			this.rbtRadios = (global::Motorola.CommonCPS.RadioManagement.Controls.RMRadioButton)target;
			return;
			IL_103:
			this.rbtAll = (global::Motorola.CommonCPS.RadioManagement.Controls.RMRadioButton)target;
			return;
			IL_127:
			this._contentLoaded = true;
			return;
			IL_129:
			this.rbtSystems = (global::Motorola.CommonCPS.RadioManagement.Controls.RMRadioButton)target;
		}

		// Token: 0x0400004F RID: 79
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMRadioButton rbtAll;

		// Token: 0x04000050 RID: 80
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMRadioButton rbtRadios;

		// Token: 0x04000051 RID: 81
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMRadioButton rbtSystems;

		// Token: 0x04000052 RID: 82
		private bool _contentLoaded;
	}
}
