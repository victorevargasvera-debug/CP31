using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Composition;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using Infragistics.Windows;
using Infragistics.Windows.DataPresenter;
using Microsoft.Practices.Prism.Commands;
using Motorola.CommonCPS.RadioManagement.Controls;
using Motorola.CommonCPS.RadioManagement.Converters;
using Motorola.CommonCPS.RadioManagement.Global;
using Motorola.CommonCPS.RadioManagement.Infrastructure;
using Motorola.CommonCPS.UI.CellRangeFill;

namespace Motorola.CommonCPS.RadioManagement.ASTROSystem
{
	// Token: 0x0200000E RID: 14
	[global::Motorola.CommonCPS.RadioManagement.Infrastructure.ViewExport(RegionName = "ASTROSystemMainRegion")]
	public class SystemDetailsView : global::System.Windows.Controls.UserControl, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x06000027 RID: 39 RVA: 0x000039D4 File Offset: 0x00001BD4
		public SystemDetailsView()
		{
			int a_ = 2;
			base..ctor();
			this.InitializeComponent();
			base.SetBinding(global::Motorola.CommonCPS.RadioManagement.ASTROSystem.SystemDetailsView.CellFillEndedCommandProperty, global::Motorola.CommonCPS.RadioManagement.ASTROSystem.ModuleASTROSystem.b("힓\uda9b첟캡좥첧쾩좫\udfaf\udfb1\ud9b3ힵ횷\udeb9", a_));
		}

		// Token: 0x17000005 RID: 5
		// (set) Token: 0x06000028 RID: 40 RVA: 0x00003A10 File Offset: 0x00001C10
		[global::System.ComponentModel.Composition.Import]
		public global::Motorola.CommonCPS.RadioManagement.ASTROSystem.SystemDetailsViewModel ViewModel
		{
			set
			{
				short num = (short)1514515522;
				short num2 = num;
				num = (short)1068149826;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1294401536;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1315635201;
				if (num != 0)
				{
				}
				num = (short)461373440;
				if (num != 0)
				{
				}
				base.DataContext = value;
			}
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00003AC4 File Offset: 0x00001CC4
		private void c(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 13;
			short num = (short)2096627715;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_326;
				case 1:
					goto IL_2E6;
				case 2:
					if (this.fillManager == null)
					{
						num = (short)1884356618;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_5A;
					}
					continue;
				case 4:
					goto IL_1AF;
				case 5:
					if (global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.ASTROMDCEntryFormat.ToUpperInvariant() == global::Motorola.CommonCPS.RadioManagement.ASTROSystem.ModuleASTROSystem.b("힞", a_))
					{
						num = (short)2017329161;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					this.dgrRadios.FieldLayouts[0].Fields[global::Motorola.CommonCPS.RadioManagement.ASTROSystem.ModuleASTROSystem.b("춞삠잢첤좦", a_)].Converter = new global::Motorola.CommonCPS.RadioManagement.Converters.MDCRadioIDEntryFormatToHexConverter();
					this.a(global::System.Windows.LogicalTreeHelper.FindLogicalNode(base.Resources[global::Motorola.CommonCPS.RadioManagement.ASTROSystem.ModuleASTROSystem.b("ﲞ철쪤즦\udfa8캪\udfac\udbae풰솲", a_)] as global::System.Windows.Controls.ContextMenu, global::Motorola.CommonCPS.RadioManagement.ASTROSystem.ModuleASTROSystem.b("\udb9e쒠삢첤쪦좨잪삮쎰\udeb2풴쎶", a_)));
					num = (short)1559101441;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					return;
				case 7:
					num = (short)1151729665;
					if (num != 0)
					{
					}
					this.dgrRadios.HideColumn(global::Motorola.CommonCPS.RadioManagement.ASTROSystem.ModuleASTROSystem.b("쮞쒠캢햤쮦좨\udfaa좬킰\udeb2킴", a_));
					num = (short)1721892872;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					goto IL_326;
				case 9:
					this.dgrRadios.FieldLayouts[0].Fields[global::Motorola.CommonCPS.RadioManagement.ASTROSystem.ModuleASTROSystem.b("춞삠잢첤좦", a_)].Converter = new global::Motorola.CommonCPS.RadioManagement.Converters.RadioIDEntryFormatConverter();
					this.a(global::System.Windows.LogicalTreeHelper.FindLogicalNode(base.Resources[global::Motorola.CommonCPS.RadioManagement.ASTROSystem.ModuleASTROSystem.b("ﲞ철쪤즦\udfa8캪\udfac\udbae풰솲", a_)] as global::System.Windows.Controls.ContextMenu, global::Motorola.CommonCPS.RadioManagement.ASTROSystem.ModuleASTROSystem.b("힞쒠\udba2좦\udba8욪첬\udbae", a_)));
					num = (short)1892679684;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
				{
					this.fillManager = global::Motorola.CommonCPS.RadioManagement.ASTROSystem.c.a(this.dgrRadios);
					global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillManager cellRangeFillManager = this.fillManager;
					cellRangeFillManager.CellFillEnded = (global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillEndedEventHandler)global::System.Delegate.Combine(cellRangeFillManager.CellFillEnded, new global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillEndedEventHandler(this.a));
					num = (short)1638924294;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_5A:
				if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ModeIdentifier == global::Motorola.CommonCPS.RadioManagement.Global.ModeIdentifier.Configuration)
				{
					num = (short)634388487;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)1126933517;
				short num3 = num;
				num = (short)1638769677;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_1AF;
				case 1:
					break;
				default:
				{
					num = (short)53280768;
					short num4 = num;
					break;
				}
				}
				num = (short)5308416;
				if (num != 0)
				{
				}
				this.dgrRadios.HideColumn(global::Motorola.CommonCPS.RadioManagement.ASTROSystem.ModuleASTROSystem.b("\udc9e캠춢쎤캦캨\udeaa\udfac캮얰\udab2\udab4\ud9b6\udaba킼\udabe", a_));
				num = (short)401014784;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2E6:
				num = (short)856686594;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1AF:
				goto IL_2E6;
				IL_326:
				this.dgrRadios.FieldLayouts[0].Fields[global::Motorola.CommonCPS.RadioManagement.ASTROSystem.ModuleASTROSystem.b("춞삠잢첤좦", a_)].Settings.EditAsType = typeof(string);
				num = (short)122617861;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00003E90 File Offset: 0x00002090
		private void a(object A_0, global::System.Windows.Input.MouseButtonEventArgs A_1)
		{
			int a_ = 18;
			switch (0)
			{
			case 0:
				goto IL_2D;
			}
			short num2;
			global::System.Windows.DependencyObject ancestorFromType;
			for (;;)
			{
				IL_13:
				int num;
				switch (num)
				{
				case 0:
					num2 = (short)1392246787;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					goto IL_A9;
				case 2:
					return;
				case 3:
					if (((global::Infragistics.Windows.DataPresenter.LabelPresenter)ancestorFromType).Field.Name == global::Motorola.CommonCPS.RadioManagement.ASTROSystem.ModuleASTROSystem.b("장첧쎩쎫", a_))
					{
						num2 = (short)1705967620;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 4:
				{
					global::System.Windows.Controls.ContextMenu contextMenu = base.FindResource(global::Motorola.CommonCPS.RadioManagement.ASTROSystem.ModuleASTROSystem.b("잣쮥얩슫\ud8ad햯삱삳펵쪷", a_)) as global::System.Windows.Controls.ContextMenu;
					((global::Infragistics.Windows.DataPresenter.LabelPresenter)ancestorFromType).ContextMenu = contextMenu;
					((global::Infragistics.Windows.DataPresenter.LabelPresenter)ancestorFromType).ContextMenu.IsOpen = true;
					A_1.Handled = true;
					num2 = (short)666435586;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_2D;
			}
			IL_A9:
			num2 = (short)1392050176;
			short num3 = num2;
			num2 = (short)1280507905;
			if (num2 != 0)
			{
			}
			if (ancestorFromType is global::Infragistics.Windows.DataPresenter.LabelPresenter)
			{
				goto IL_105;
			}
			return;
			IL_2D:
			ancestorFromType = global::Infragistics.Windows.Utilities.GetAncestorFromType(A_1.OriginalSource as global::System.Windows.DependencyObject, typeof(global::Infragistics.Windows.DataPresenter.LabelPresenter), true);
			num2 = (short)1476382206;
			short num4 = num2;
			num2 = (short)1649004030;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_105:
				num2 = (short)829882368;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			default:
			{
				num2 = (short)1083047936;
				if (num2 != 0)
				{
				}
				num2 = (short)1371013121;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			}
		}

		// Token: 0x0600002B RID: 43 RVA: 0x0000406C File Offset: 0x0000226C
		private void b(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 14;
			short num = (short)1127819781;
			short num2 = num;
			num = (short)579414533;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1783300096;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)843251713;
			if (num != 0)
			{
			}
			num = (short)1985937408;
			if (num != 0)
			{
			}
			this.a(global::Motorola.CommonCPS.RadioManagement.ASTROSystem.ModuleASTROSystem.b("", a_));
			this.dgrRadios.FieldLayouts[0].Fields[global::Motorola.CommonCPS.RadioManagement.ASTROSystem.ModuleASTROSystem.b("쎡삣쾥잧", a_)].Converter = new global::Motorola.CommonCPS.RadioManagement.Converters.MDCRadioIDEntryFormatToHexConverter();
			this.a(A_0);
		}

		// Token: 0x0600002C RID: 44 RVA: 0x0000416C File Offset: 0x0000236C
		private void a(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 8;
			short num = (short)551354369;
			if (num != 0)
			{
			}
			num = (short)218431488;
			short num2 = num;
			num = (short)697248108;
			short num3 = num;
			num = (short)718678380;
			switch (num3 == num)
			{
			}
			num = (short)1860304896;
			if (num != 0)
			{
			}
			this.a(global::Motorola.CommonCPS.RadioManagement.ASTROSystem.ModuleASTROSystem.b("튙", a_));
			this.dgrRadios.FieldLayouts[0].Fields[global::Motorola.CommonCPS.RadioManagement.ASTROSystem.ModuleASTROSystem.b("좙ﶛ瞧즟춡", a_)].Converter = new global::Motorola.CommonCPS.RadioManagement.Converters.RadioIDEntryFormatConverter();
			this.a(A_0);
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600002D RID: 45 RVA: 0x0000426C File Offset: 0x0000246C
		// (set) Token: 0x0600002E RID: 46 RVA: 0x00004324 File Offset: 0x00002524
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand CellFillEndedCommand
		{
			get
			{
				short num = (short)183954786;
				short num2 = num;
				num = (short)873459042;
				switch (num2 == num)
				{
				default:
				{
					num = (short)911278080;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1850671105;
				if (num != 0)
				{
				}
				num = (short)1704919040;
				if (num != 0)
				{
				}
				return (global::Microsoft.Practices.Prism.Commands.DelegateCommand)base.GetValue(global::Motorola.CommonCPS.RadioManagement.ASTROSystem.SystemDetailsView.CellFillEndedCommandProperty);
			}
			set
			{
				short num = (short)79940630;
				short num2 = num;
				num = (short)892062742;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1356005376;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)850264065;
				if (num != 0)
				{
				}
				num = (short)2064187392;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.ASTROSystem.SystemDetailsView.CellFillEndedCommandProperty, value);
			}
		}

		// Token: 0x0600002F RID: 47 RVA: 0x000043D8 File Offset: 0x000025D8
		private void a(string A_0)
		{
			short num = (short)2145177928;
			short num2 = num;
			num = (short)1598017864;
			switch (num2 == num)
			{
			default:
			{
				num = (short)282132480;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1272643584;
			if (num != 0)
			{
			}
			num = (short)890961921;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.ASTROMDCEntryFormat = A_0;
			global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.Save();
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00004498 File Offset: 0x00002698
		private void a(object A_0)
		{
			short num = (short)701300736;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				case 1:
					goto IL_1A7;
				case 2:
				{
					num = (short)1889337344;
					short num3 = num;
					try
					{
						num = (short)1158152195;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
							{
								global::System.Windows.Controls.MenuItem menuItem;
								menuItem.IsChecked = false;
								num = (short)656998406;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 1:
							{
								global::System.Collections.Generic.IEnumerator<global::System.Windows.Controls.MenuItem> enumerator;
								if (!enumerator.MoveNext())
								{
									num = (short)862060546;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::System.Windows.Controls.MenuItem menuItem = enumerator.Current;
								num = (short)1451622404;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 2:
								num = (short)143851525;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
								switch (0)
								{
								case 0:
									goto IL_95;
								}
								continue;
							case 4:
							{
								global::System.Windows.Controls.MenuItem menuItem;
								global::System.Windows.Controls.MenuItem menuItem2;
								if (menuItem != menuItem2)
								{
									num = (short)456392704;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 5:
								goto IL_13C;
							}
							IL_97:
							num = (short)2054750209;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_95:
							goto IL_97;
						}
						IL_13C:
						return;
					}
					finally
					{
						num = (short)770637824;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							global::System.Collections.Generic.IEnumerator<global::System.Windows.Controls.MenuItem> enumerator;
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_171;
								}
								continue;
							case 1:
								enumerator.Dispose();
								num = (short)2021851138;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_1A4;
							}
							IL_171:
							if (enumerator == null)
							{
								break;
							}
							num = (short)109641729;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_1A4:;
					}
					goto IL_1A7;
				}
				}
				IL_30:
				if (A_0 is global::System.Windows.Controls.MenuItem)
				{
					num = (short)499712001;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_1A7:
				num = (short)795017217;
				if (num != 0)
				{
				}
				num = (short)423467377;
				short num4 = num;
				num = (short)1929353585;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_30;
				default:
				{
					num = (short)1789263872;
					if (num != 0)
					{
					}
					global::System.Windows.Controls.MenuItem menuItem2 = A_0 as global::System.Windows.Controls.MenuItem;
					global::System.Collections.Generic.IEnumerable<global::System.Windows.Controls.MenuItem> enumerable = ((global::System.Windows.Controls.ContextMenu)menuItem2.Parent).Items.OfType<global::System.Windows.Controls.MenuItem>();
					menuItem2.IsChecked = true;
					global::System.Collections.Generic.IEnumerator<global::System.Windows.Controls.MenuItem> enumerator = enumerable.GetEnumerator();
					num = (short)300417026;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
				}
			}
		}

		// Token: 0x06000031 RID: 49 RVA: 0x0000473C File Offset: 0x0000293C
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			int a_ = 5;
			short num = (short)957577532;
			short num2 = num;
			num = (short)151615804;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1325924352;
				if (num != 0)
				{
				}
				num = (short)888209409;
				if (num != 0)
				{
				}
				if (!this._contentLoaded)
				{
					num = (short)419627008;
					short num3 = num;
					this._contentLoaded = true;
					global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.ASTROSystem.ModuleASTROSystem.b("뢖풘펠첢즤욦螨슬슮\udcb0\udcb2\udbb4鎼ꃀꟂ계꣆蓈꫊ꏌ껎뛐뛒룔닖럘꿚點닠럢럤꣦뫨鋪黬鯮铰黲컴银雸雺跼郾漀昂欄猆☈砊琌簎攐瘒研猖簘漚簜瘞䴠倢匤並䰨尪Ȭ尮䠰䀲䄴制吸强堼䬾⁀⩂⥄㑆㽈≊⡌㡎罐⭒㑔㩖㕘", a_), global::System.UriKind.Relative);
					global::System.Windows.Application.LoadComponent(this, resourceLocator);
					return;
				}
				break;
			}
		}

		// Token: 0x06000032 RID: 50 RVA: 0x0000481C File Offset: 0x00002A1C
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)756219904;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				case 1:
					num = (short)1765867521;
					if (num != 0)
					{
					}
					num = (short)345440258;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_CE;
				}
				IL_30:
				switch (connectionId)
				{
				case 1:
				{
					num = (short)230293504;
					short num3 = num;
					num = (short)557341618;
					short num4 = num;
					num = (short)941382578;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_157;
					}
					break;
				}
				case 2:
					goto IL_9E;
				case 3:
					goto IL_86;
				case 4:
					goto IL_D3;
				default:
					num = (short)357957633;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_86:
			((global::System.Windows.Controls.MenuItem)target).Click += this.a;
			return;
			IL_9E:
			((global::System.Windows.Controls.MenuItem)target).Click += this.b;
			return;
			IL_CE:
			this._contentLoaded = true;
			return;
			IL_D3:
			this.dgrRadios = (global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid)target;
			this.dgrRadios.PreviewMouseRightButtonDown += this.a;
			return;
			IL_157:
			num = (short)714473472;
			if (num != 0)
			{
			}
			this.uscSystemDetails = (global::Motorola.CommonCPS.RadioManagement.ASTROSystem.SystemDetailsView)target;
			this.uscSystemDetails.Loaded += this.c;
		}

		// Token: 0x06000033 RID: 51 RVA: 0x000049C0 File Offset: 0x00002BC0
		// Note: this type is marked as 'beforefieldinit'.
		static SystemDetailsView()
		{
			int a_ = 6;
			short num = (short)1310306810;
			short num2 = num;
			num = (short)602583546;
			switch (num2 == num)
			{
			default:
			{
				num = (short)734593024;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1900085249;
			if (num != 0)
			{
			}
			num = (short)751763456;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.ASTROSystem.SystemDetailsView.CellFillEndedCommandProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.ASTROSystem.ModuleASTROSystem.b("\udb97ﾙ쮡좣쪥쒩좫쮭풯\udbb3\udbb5햷\udbb9튻\udabd", a_), typeof(global::Microsoft.Practices.Prism.Commands.DelegateCommand), typeof(global::Motorola.CommonCPS.RadioManagement.ASTROSystem.SystemDetailsView), new global::System.Windows.FrameworkPropertyMetadata(null));
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00004AA8 File Offset: 0x00002CA8
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private void a(global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillEndedEventArgs A_0)
		{
			short num = (short)1016522358;
			short num2 = num;
			num = (short)1529734774;
			switch (num2 == num)
			{
			default:
			{
				num = (short)586547200;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)789315584;
			if (num != 0)
			{
			}
			num = (short)1608581121;
			if (num != 0)
			{
			}
			this.CellFillEndedCommand.Execute();
		}

		// Token: 0x0400000F RID: 15
		private global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillManager fillManager;

		// Token: 0x04000010 RID: 16
		public static readonly global::System.Windows.DependencyProperty CellFillEndedCommandProperty;

		// Token: 0x04000011 RID: 17
		internal global::Motorola.CommonCPS.RadioManagement.ASTROSystem.SystemDetailsView uscSystemDetails;

		// Token: 0x04000012 RID: 18
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid dgrRadios;

		// Token: 0x04000013 RID: 19
		private bool _contentLoaded;
	}
}
