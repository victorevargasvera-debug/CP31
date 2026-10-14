using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.Composition;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Motorola.CommonCPS.RadioManagement.Controls;
using Motorola.CommonCPS.RadioManagement.Global;
using Motorola.CommonCPS.RadioManagement.Infrastructure;

namespace Motorola.CommonCPS.RadioManagement.ASTROSystem
{
	// Token: 0x02000011 RID: 17
	[global::Motorola.CommonCPS.RadioManagement.Infrastructure.ViewExport(RegionName = "ASTROSystemMainRegion")]
	public class RadiosView : global::System.Windows.Controls.UserControl, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x06000049 RID: 73 RVA: 0x00005BD4 File Offset: 0x00003DD4
		public RadiosView()
		{
			this.InitializeComponent();
		}

		// Token: 0x1700000C RID: 12
		// (set) Token: 0x0600004A RID: 74 RVA: 0x00005BF0 File Offset: 0x00003DF0
		[global::System.ComponentModel.Composition.Import]
		public global::Motorola.CommonCPS.RadioManagement.ASTROSystem.RadiosViewModel ViewModel
		{
			set
			{
				short num = (short)1380867404;
				short num2 = num;
				num = (short)1304255820;
				switch (num2 == num)
				{
				}
				num = (short)1187250177;
				if (num != 0)
				{
				}
				num = (short)2064187392;
				if (num != 0)
				{
				}
				num = (short)512622592;
				short num3 = num;
				base.DataContext = value;
			}
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00005CA4 File Offset: 0x00003EA4
		private void a(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 17;
			short num = (short)733544449;
			if (num != 0)
			{
			}
			num = (short)1409030554;
			short num2 = num;
			num = (short)2051676570;
			switch (num2 == num)
			{
			}
			num = (short)1470365696;
			if (num != 0)
			{
			}
			num = (short)1809055744;
			short num3 = num;
			this.dgrRadios.HideColumn((global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ModeIdentifier == global::Motorola.CommonCPS.RadioManagement.Global.ModeIdentifier.Configuration) ? global::Motorola.CommonCPS.RadioManagement.ASTROSystem.ModuleASTROSystem.b("삤쪦\ud9a8잪첬\udbae풰ﶲ풴\udab6\udcb8", a_) : global::Motorola.CommonCPS.RadioManagement.ASTROSystem.ModuleASTROSystem.b("쪤즦쾨슪쪬\udaae쎰튲솴\udeb6횸햺\udebe곀ꛂ", a_));
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00005D8C File Offset: 0x00003F8C
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 5;
			if (this._contentLoaded)
			{
				short num = (short)1095898140;
				short num2 = num;
				num = (short)1583158300;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)996999168;
					if (num != 0)
					{
					}
					num = (short)1162543104;
					short num3 = num;
					num = (short)550371329;
					if (num != 0)
					{
					}
					return;
				}
				}
			}
			this._contentLoaded = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.ASTROSystem.ModuleASTROSystem.b("뢖풘펠첢즤욦螨슬슮\udcb0\udcb2\udbb4鎼ꃀꟂ계꣆蓈꫊ꏌ껎뛐뛒룔닖럘꿚點닠럢럤꣦뫨鋪黬鯮铰黲컴银雸雺跼郾漀昂欄猆☈礊氌欎砐簒昔愖瀘縚樜〞匠䈢䄤並䘨堪嬬䘮吰䐲᬴伶堸嘺儼", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00005E6C File Offset: 0x0000406C
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)1709113344;
			short num2 = num;
			num = (short)936247298;
			int num3 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num3)
				{
				case 0:
				{
					num = (short)39500213;
					short num4 = num;
					num = (short)1225111989;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_146;
					default:
						num = (short)1690894336;
						if (num != 0)
						{
						}
						num = (short)1121124353;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					goto IL_106;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_63;
					}
					continue;
				case 3:
					num = (short)2000289793;
					if (num != 0)
					{
					}
					num = (short)2015559684;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_146;
				}
				IL_63:
				if (connectionId != 1)
				{
					num = (short)1636237315;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_146:
				if (connectionId == 2)
				{
					goto IL_167;
				}
				num = (short)8323072;
				num3 = (int)((global::System.IntPtr)num);
			}
			this.uscRadios = (global::Motorola.CommonCPS.RadioManagement.ASTROSystem.RadiosView)target;
			this.uscRadios.Loaded += this.a;
			return;
			IL_106:
			this._contentLoaded = true;
			return;
			IL_167:
			this.dgrRadios = (global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid)target;
		}

		// Token: 0x0400001D RID: 29
		internal global::Motorola.CommonCPS.RadioManagement.ASTROSystem.RadiosView uscRadios;

		// Token: 0x0400001E RID: 30
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid dgrRadios;

		// Token: 0x0400001F RID: 31
		private bool _contentLoaded;
	}
}
