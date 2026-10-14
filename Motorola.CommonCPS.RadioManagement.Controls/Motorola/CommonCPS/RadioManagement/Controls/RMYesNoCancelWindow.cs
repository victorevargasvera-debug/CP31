using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Interop;
using System.Windows.Markup;
using Microsoft.Practices.Prism.Interactivity.InteractionRequest;
using Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x02000117 RID: 279
	public class RMYesNoCancelWindow : global::System.Windows.Window, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x060008CC RID: 2252 RVA: 0x00092444 File Offset: 0x00090644
		public RMYesNoCancelWindow()
		{
			this.InitializeComponent();
		}

		// Token: 0x060008CD RID: 2253 RVA: 0x00092460 File Offset: 0x00090660
		private void btnYes_Click(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1239594193;
			short num2 = num;
			num = (short)2072294609;
			switch (num2 == num)
			{
			}
			num = (short)24772609;
			if (num != 0)
			{
			}
			num = (short)1610088448;
			if (num != 0)
			{
			}
			num = (short)663814144;
			short num3 = num;
			((global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.Confirmation)base.DataContext).Confirmed = true;
			base.Close();
		}

		// Token: 0x060008CE RID: 2254 RVA: 0x00092520 File Offset: 0x00090720
		private void Window_Loaded(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)458851572;
			short num2 = num;
			num = (short)1834583284;
			switch (num2 == num)
			{
			}
			num = (short)606273536;
			if (num != 0)
			{
			}
			num = (short)420413441;
			if (num != 0)
			{
			}
			num = (short)233832448;
			short num3 = num;
			global::System.IntPtr handle = new global::System.Windows.Interop.WindowInteropHelper(this).Handle;
			global::Motorola.CommonCPS.RadioManagement.Controls.UnsafeNativeMethods.SetWindowLong(handle, -16, global::Motorola.CommonCPS.RadioManagement.Controls.UnsafeNativeMethods.GetWindowLong(handle, -16) & -524289);
		}

		// Token: 0x060008CF RID: 2255 RVA: 0x000925EC File Offset: 0x000907EC
		private void RMButton_Click(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)915584115;
			short num2 = num;
			num = (short)357741683;
			switch (num2 == num)
			{
			}
			num = (short)1546125313;
			if (num != 0)
			{
			}
			num = (short)1215561728;
			if (num != 0)
			{
			}
			num = (short)1261895680;
			short num3 = num;
			((global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.Confirmation)base.DataContext).Confirmed = false;
			base.Close();
		}

		// Token: 0x060008D0 RID: 2256 RVA: 0x000926AC File Offset: 0x000908AC
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 5;
			short num;
			if (this._contentLoaded)
			{
				num = (short)1322641297;
				short num2 = num;
				num = (short)1039329169;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)398000128;
					if (num != 0)
					{
					}
					num = (short)2066939904;
					short num3 = num;
					return;
				}
				}
			}
			num = (short)413597697;
			if (num != 0)
			{
			}
			this._contentLoaded = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("늜튞캠힢쪤햦욨잪첬膮\udcb2\ud8b4\udab6횸햺ﺼ鋀韄ꛆ귈ꋊꋌ苎냐뷒듔냖볘뛚룜뇞闠췢ꛤ裦蟨鿪鿬胮鷰胲컴银雸雺跼郾漀昂欄猆☈簊搌愎甐簒戔搖㘘椚瀜昞䐠倢䬤䠦䨨䨪䌬䰮吰弲䈴帶圸强刼䠾潀㭂⑄⩆╈", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x060008D1 RID: 2257 RVA: 0x00092790 File Offset: 0x00090990
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		internal global::System.Delegate a(global::System.Type A_0, string A_1)
		{
			short num = (short)458869684;
			short num2 = num;
			num = (short)1525009332;
			switch (num2 == num)
			{
			}
			num = (short)2006253569;
			if (num != 0)
			{
			}
			num = (short)1108606976;
			if (num != 0)
			{
			}
			num = (short)613285888;
			short num3 = num;
			return global::System.Delegate.CreateDelegate(A_0, this, A_1);
		}

		// Token: 0x060008D2 RID: 2258 RVA: 0x00092844 File Offset: 0x00090A44
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)2052063234;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)799277057;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_95;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_31;
					}
					continue;
				}
				IL_31:
				switch (connectionId)
				{
				case 1:
					goto IL_69;
				case 2:
					goto IL_5C;
				case 3:
				{
					num = (short)1383637744;
					short num3 = num;
					num = (short)356754160;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					case 1:
						goto IL_122;
					}
					goto Block_2;
				}
				default:
					num = (short)2092367872;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_5C:
			this.btnYes = (global::Motorola.CommonCPS.RadioManagement.Controls.RMButton)target;
			return;
			IL_69:
			((global::Motorola.CommonCPS.RadioManagement.Controls.RMYesNoCancelWindow)target).Loaded += this.Window_Loaded;
			return;
			IL_95:
			num = (short)1863974913;
			if (num != 0)
			{
			}
			this._contentLoaded = true;
			return;
			Block_2:
			num = (short)940900352;
			short num4 = num;
			IL_122:
			num = (short)593166336;
			if (num != 0)
			{
			}
			this.btnCancel = (global::Motorola.CommonCPS.RadioManagement.Controls.RMButton)target;
		}

		// Token: 0x04000417 RID: 1047
		private const int GWL_STYLE = -16;

		// Token: 0x04000418 RID: 1048
		private const int WS_SYSMENU = 524288;

		// Token: 0x04000419 RID: 1049
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMButton btnYes;

		// Token: 0x0400041A RID: 1050
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMButton btnCancel;

		// Token: 0x0400041B RID: 1051
		private bool _contentLoaded;
	}
}
