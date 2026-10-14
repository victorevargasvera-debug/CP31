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
	// Token: 0x02000017 RID: 23
	[global::Motorola.CommonCPS.RadioManagement.Infrastructure.ViewExport(RegionName = "ASTROSystemMainRegion")]
	public class RadioDetailsView : global::System.Windows.Controls.UserControl, global::System.IDisposable, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x06000082 RID: 130 RVA: 0x00009044 File Offset: 0x00007244
		public RadioDetailsView()
		{
			int a_ = 15;
			base..ctor();
			this.InitializeComponent();
			base.SetBinding(global::Motorola.CommonCPS.RadioManagement.ASTROSystem.RadioDetailsView.CellFillEndedCommandProperty, global::Motorola.CommonCPS.RadioManagement.ASTROSystem.ModuleASTROSystem.b("욢즤쮦슪솬쎮\uddb2톴튶\uddb8튼튾곀ꋂꯄꏆ", a_));
		}

		// Token: 0x17000018 RID: 24
		// (set) Token: 0x06000083 RID: 131 RVA: 0x00009080 File Offset: 0x00007280
		[global::System.ComponentModel.Composition.Import]
		public global::Motorola.CommonCPS.RadioManagement.ASTROSystem.RadioDetailsViewModel ViewModel
		{
			set
			{
				short num = (short)1967128576;
				short num2 = num;
				num = (short)1240006657;
				if (num != 0)
				{
				}
				num = (short)2089783829;
				short num3 = num;
				num = (short)14193173;
				switch (num3 == num)
				{
				}
				num = (short)42008576;
				if (num != 0)
				{
				}
				base.DataContext = value;
			}
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00009130 File Offset: 0x00007330
		private void c(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 11;
			short num = (short)1288175617;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.ASTROMDCEntryFormat.ToUpperInvariant() == global::Motorola.CommonCPS.RadioManagement.ASTROSystem.ModuleASTROSystem.b("햜", a_))
					{
						num = (short)1397358600;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					this.dgrSystems.FieldLayouts[0].Fields[global::Motorola.CommonCPS.RadioManagement.ASTROSystem.ModuleASTROSystem.b("쾜ﺞ얠쪢쪤", a_)].Converter = new global::Motorola.CommonCPS.RadioManagement.Converters.MDCRadioIDEntryFormatToHexConverter();
					this.a(global::System.Windows.LogicalTreeHelper.FindLogicalNode(base.Resources[global::Motorola.CommonCPS.RadioManagement.ASTROSystem.ModuleASTROSystem.b("ﺜ첢쮤톦첨\ud9aa\ud9ac쪮쎰", a_)] as global::System.Windows.Controls.ContextMenu, global::Motorola.CommonCPS.RadioManagement.ASTROSystem.ModuleASTROSystem.b("\ud99c爵슠쪢좤욦얨슬\uddae\udcb0튲솴", a_)));
					num = (short)1079508997;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_59;
					}
					continue;
				case 2:
					return;
				case 3:
					IL_79:
					num = (short)24903681;
					if (num != 0)
					{
					}
					this.dgrSystems.HideColumn(global::Motorola.CommonCPS.RadioManagement.ASTROSystem.ModuleASTROSystem.b("즜爵철펢즤욦\udda8캪캮\udcb0횲", a_));
					num = (short)893648900;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_2FE;
				case 5:
					goto IL_274;
				case 6:
					goto IL_274;
				case 7:
					if (this.fillManager == null)
					{
						num = (short)810811401;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 8:
				{
					num = (short)645791744;
					short num3 = num;
					this.dgrSystems.FieldLayouts[0].Fields[global::Motorola.CommonCPS.RadioManagement.ASTROSystem.ModuleASTROSystem.b("쾜ﺞ얠쪢쪤", a_)].Converter = new global::Motorola.CommonCPS.RadioManagement.Converters.RadioIDEntryFormatConverter();
					this.a(global::System.Windows.LogicalTreeHelper.FindLogicalNode(base.Resources[global::Motorola.CommonCPS.RadioManagement.ASTROSystem.ModuleASTROSystem.b("ﺜ첢쮤톦첨\ud9aa\ud9ac쪮쎰", a_)] as global::System.Windows.Controls.ContextMenu, global::Motorola.CommonCPS.RadioManagement.ASTROSystem.ModuleASTROSystem.b("햜爵\ud9a0쪤햦쒨쪪\ud9ac", a_)));
					num = (short)1901002758;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 9:
				{
					this.fillManager = global::Motorola.CommonCPS.RadioManagement.ASTROSystem.c.a(this.dgrSystems);
					global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillManager cellRangeFillManager = this.fillManager;
					cellRangeFillManager.CellFillEnded = (global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillEndedEventHandler)global::System.Delegate.Combine(cellRangeFillManager.CellFillEnded, new global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillEndedEventHandler(this.a));
					num = (short)919928834;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 10:
					goto IL_2FE;
				}
				IL_59:
				if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ModeIdentifier == global::Motorola.CommonCPS.RadioManagement.Global.ModeIdentifier.Configuration)
				{
					num = (short)1740701699;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				this.dgrSystems.HideColumn(global::Motorola.CommonCPS.RadioManagement.ASTROSystem.ModuleASTROSystem.b("\ude9c쾠얢첤삦\udca8\ud9aa첬\udbae\ud8b0\udcb2\udbb4禮\ud8b8횺\ud8bc", a_));
				num = (short)318439434;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_274:
				num = (short)1849468697;
				short num4 = num;
				num = (short)797157145;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_79;
				default:
					num = (short)1266221056;
					if (num != 0)
					{
					}
					num = (short)1867317255;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_2FE:
				this.dgrSystems.FieldLayouts[0].Fields[global::Motorola.CommonCPS.RadioManagement.ASTROSystem.ModuleASTROSystem.b("쾜ﺞ얠쪢쪤", a_)].Settings.EditAsType = typeof(string);
				num = (short)2025324544;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00009500 File Offset: 0x00007700
		private void a(object A_0, global::System.Windows.Input.MouseButtonEventArgs A_1)
		{
			int a_ = 0;
			for (;;)
			{
				IL_09:
				switch (0)
				{
				case 0:
					goto IL_2D;
				}
				int num;
				short num2;
				global::System.Windows.DependencyObject ancestorFromType;
				for (;;)
				{
					IL_13:
					switch (num)
					{
					case 0:
					{
						num2 = (short)1922999590;
						short num3 = num2;
						num2 = (short)640066854;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_09;
						default:
						{
							num2 = (short)1449197568;
							if (num2 != 0)
							{
							}
							global::System.Windows.Controls.ContextMenu contextMenu = base.FindResource(global::Motorola.CommonCPS.RadioManagement.ASTROSystem.ModuleASTROSystem.b("煉햕ﮝ튟횡솣풥", a_)) as global::System.Windows.Controls.ContextMenu;
							((global::Infragistics.Windows.DataPresenter.LabelPresenter)ancestorFromType).ContextMenu = contextMenu;
							((global::Infragistics.Windows.DataPresenter.LabelPresenter)ancestorFromType).ContextMenu.IsOpen = true;
							A_1.Handled = true;
							num2 = (short)331743232;
							short num4 = num2;
							num2 = (short)2062745602;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						}
						break;
					}
					case 1:
						num2 = (short)926089217;
						if (num2 != 0)
						{
						}
						if (((global::Infragistics.Windows.DataPresenter.LabelPresenter)ancestorFromType).Field.Name == global::Motorola.CommonCPS.RadioManagement.ASTROSystem.ModuleASTROSystem.b("삑햛\uda9d", a_))
						{
							num2 = (short)1076428800;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					case 2:
						return;
					case 3:
						if (ancestorFromType is global::Infragistics.Windows.DataPresenter.LabelPresenter)
						{
							num2 = (short)296878084;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					case 4:
						num2 = (short)397017089;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				IL_2D:
				ancestorFromType = global::Infragistics.Windows.Utilities.GetAncestorFromType(A_1.OriginalSource as global::System.Windows.DependencyObject, typeof(global::Infragistics.Windows.DataPresenter.LabelPresenter), true);
				num2 = (short)1982595075;
				num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
		}

		// Token: 0x06000086 RID: 134 RVA: 0x000096E0 File Offset: 0x000078E0
		private void b(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 19;
			short num = (short)1667088224;
			short num2 = num;
			num = (short)795131744;
			switch (num2 == num)
			{
			}
			num = (short)1750597633;
			if (num != 0)
			{
			}
			num = (short)990838784;
			if (num != 0)
			{
			}
			num = (short)1055850496;
			short num3 = num;
			this.a(global::Motorola.CommonCPS.RadioManagement.ASTROSystem.ModuleASTROSystem.b("", a_));
			this.dgrSystems.FieldLayouts[0].Fields[global::Motorola.CommonCPS.RadioManagement.ASTROSystem.ModuleASTROSystem.b("욦춨슪슬", a_)].Converter = new global::Motorola.CommonCPS.RadioManagement.Converters.MDCRadioIDEntryFormatToHexConverter();
			this.a(A_0);
		}

		// Token: 0x06000087 RID: 135 RVA: 0x000097E0 File Offset: 0x000079E0
		private void a(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 3;
			short num = (short)14958928;
			short num2 = num;
			num = (short)770130256;
			switch (num2 == num)
			{
			}
			num = (short)1304297472;
			if (num != 0)
			{
			}
			num = (short)414973953;
			if (num != 0)
			{
			}
			num = (short)171704320;
			short num3 = num;
			this.a(global::Motorola.CommonCPS.RadioManagement.ASTROSystem.ModuleASTROSystem.b("\udd94", a_));
			this.dgrSystems.FieldLayouts[0].Fields[global::Motorola.CommonCPS.RadioManagement.ASTROSystem.ModuleASTROSystem.b("잔ﶘ횞", a_)].Converter = new global::Motorola.CommonCPS.RadioManagement.Converters.RadioIDEntryFormatConverter();
			this.a(A_0);
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000088 RID: 136 RVA: 0x000098E0 File Offset: 0x00007AE0
		// (set) Token: 0x06000089 RID: 137 RVA: 0x0000999C File Offset: 0x00007B9C
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand CellFillEndedCommand
		{
			get
			{
				short num = (short)193971044;
				short num2 = num;
				num = (short)1960952676;
				switch (num2 == num)
				{
				}
				num = (short)1889075200;
				if (num != 0)
				{
				}
				num = (short)169738241;
				if (num != 0)
				{
				}
				num = (short)2014838784;
				short num3 = num;
				return (global::Microsoft.Practices.Prism.Commands.DelegateCommand)base.GetValue(global::Motorola.CommonCPS.RadioManagement.ASTROSystem.RadioDetailsView.CellFillEndedCommandProperty);
			}
			set
			{
				short num = (short)12673336;
				short num2 = num;
				num = (short)188965176;
				switch (num2 == num)
				{
				}
				num = (short)716177408;
				if (num != 0)
				{
				}
				num = (short)2070806529;
				if (num != 0)
				{
				}
				num = (short)486146048;
				short num3 = num;
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.ASTROSystem.RadioDetailsView.CellFillEndedCommandProperty, value);
			}
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00009A50 File Offset: 0x00007C50
		private void a(string A_0)
		{
			short num = (short)47394451;
			short num2 = num;
			num = (short)1378823827;
			switch (num2 == num)
			{
			}
			num = (short)184025089;
			if (num != 0)
			{
			}
			num = (short)83820544;
			if (num != 0)
			{
			}
			num = (short)407240704;
			short num3 = num;
			global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.ASTROMDCEntryFormat = A_0;
			global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.Save();
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00009B0C File Offset: 0x00007D0C
		private void a(object A_0)
		{
			short num = (short)2042953730;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::System.Windows.Controls.MenuItem menuItem2;
				global::System.Collections.Generic.IEnumerator<global::System.Windows.Controls.MenuItem> enumerator;
				switch (num2)
				{
				case 0:
					num = (short)169082881;
					if (num != 0)
					{
					}
					goto IL_223;
				case 1:
					try
					{
						num = (short)1270546435;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							global::System.Windows.Controls.MenuItem menuItem;
							switch (num2)
							{
							case 0:
								if (menuItem != menuItem2)
								{
									num = (short)23454283;
									short num3 = num;
									num = (short)476766795;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_179;
									default:
										num = (short)1499201536;
										if (num != 0)
										{
										}
										num = (short)2083979268;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
								}
								break;
							case 1:
								num = (short)1147338757;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
								switch (0)
								{
								case 0:
									goto IL_BD;
								}
								continue;
							case 4:
								goto IL_179;
							case 5:
								goto IL_1B4;
							case 6:
								if (!enumerator.MoveNext())
								{
									num = (short)382009345;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								menuItem = enumerator.Current;
								num = (short)285605888;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_BF:
							num = (short)21233670;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_BD:
							goto IL_BF;
							IL_179:
							menuItem.IsChecked = false;
							num = (short)1209466882;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_1B4:
						return;
					}
					finally
					{
						num = (short)24117250;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								enumerator.Dispose();
								num = (short)1488060417;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								goto IL_220;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_1EA;
								}
								continue;
							}
							IL_1EA:
							if (enumerator == null)
							{
								break;
							}
							num = (short)94175232;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_220:;
					}
					goto IL_223;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_31;
					}
					continue;
				}
				IL_31:
				if (A_0 is global::System.Windows.Controls.MenuItem)
				{
					num = (short)1276313600;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_223:
				num = (short)537198592;
				short num4 = num;
				menuItem2 = (A_0 as global::System.Windows.Controls.MenuItem);
				global::System.Collections.Generic.IEnumerable<global::System.Windows.Controls.MenuItem> enumerable = ((global::System.Windows.Controls.ContextMenu)menuItem2.Parent).Items.OfType<global::System.Windows.Controls.MenuItem>();
				menuItem2.IsChecked = true;
				enumerator = enumerable.GetEnumerator();
				num = (short)1455685633;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00009DC8 File Offset: 0x00007FC8
		public void Dispose()
		{
			short num = (short)1464991745;
			if (num != 0)
			{
			}
			num = (short)579287778;
			short num2 = num;
			num = (short)1900362466;
			switch (num2 == num)
			{
			}
			num = (short)495321088;
			if (num != 0)
			{
			}
			num = (short)633077760;
			short num3 = num;
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00009E80 File Offset: 0x00008080
		protected virtual void Dispose(bool disposing)
		{
			short num = (short)1204682755;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_155;
				case 1:
					if (this.fillManager != null)
					{
						num = (short)1580531712;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 2:
				{
					num = (short)1423052458;
					short num3 = num;
					num = (short)1575816874;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_155;
					default:
						goto IL_DF;
					}
					break;
				}
				case 3:
					switch (0)
					{
					case 0:
						goto IL_39;
					}
					continue;
				case 4:
					num = (short)422707201;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_39:
				num = (short)2055733249;
				if (num != 0)
				{
				}
				if (disposing)
				{
					num = (short)516816900;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				return;
				IL_155:
				this.fillManager.Dispose();
				this.fillManager = null;
				num = (short)1078984706;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_DF:
			num = (short)8060928;
			short num4 = num;
			num = (short)932118528;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00009FE8 File Offset: 0x000081E8
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 12;
			short num = (short)942538753;
			if (num != 0)
			{
			}
			if (this._contentLoaded)
			{
				for (;;)
				{
					num = (short)1414463488;
					short num2 = num;
					num = (short)123928685;
					short num3 = num;
					num = (short)2146304109;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_9B;
					}
				}
				IL_9B:
				num = (short)530120704;
				if (num != 0)
				{
				}
				return;
			}
			this._contentLoaded = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.ASTROSystem.ModuleASTROSystem.b("놝춡킣즥\udaa7얩삫쾭麯\udbb3\udbb5햷햹튻ﶽ邿釁铅꧇껉ꗋꇍ鷏돑뫓럕뿗뿙뇛믝軟雡쫣꟥믧뻩뻫ꇭꏯ诱蟳苵鷷韹쟻鷽濿漁球椅昇漉戋稍㼏怑甓爕焗甙砛笝吟䌡䴣䨥嬧尩䔫䬭䜯ᴱ䘳圵尷匹医娽┿㙁╃⽅⑇㥉㩋❍㕏║穓⹕㥗㝙せ", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x0600008F RID: 143 RVA: 0x0000A0CC File Offset: 0x000082CC
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num;
			for (;;)
			{
				num = (short)507772930;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						num = (short)1214513153;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_143;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_30;
						}
						continue;
					}
					IL_30:
					switch (connectionId)
					{
					case 1:
						goto IL_169;
					case 2:
						goto IL_79;
					case 3:
						goto IL_61;
					case 4:
						goto IL_145;
					default:
						num = (short)1401028608;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				IL_79:
				num = (short)484425154;
				short num3 = num;
				num = (short)1159249346;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_AE;
				}
			}
			IL_61:
			((global::System.Windows.Controls.MenuItem)target).Click += this.a;
			return;
			IL_AE:
			num = (short)918487040;
			if (num != 0)
			{
			}
			num = (short)1537998848;
			short num4 = num;
			num = (short)940048385;
			if (num != 0)
			{
			}
			((global::System.Windows.Controls.MenuItem)target).Click += this.b;
			return;
			IL_143:
			this._contentLoaded = true;
			return;
			IL_145:
			this.dgrSystems = (global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid)target;
			this.dgrSystems.PreviewMouseRightButtonDown += this.a;
			return;
			IL_169:
			((global::Motorola.CommonCPS.RadioManagement.ASTROSystem.RadioDetailsView)target).Loaded += this.c;
		}

		// Token: 0x06000090 RID: 144 RVA: 0x0000A264 File Offset: 0x00008464
		// Note: this type is marked as 'beforefieldinit'.
		static RadioDetailsView()
		{
			int a_ = 15;
			short num = (short)431357953;
			if (num != 0)
			{
			}
			num = (short)1038479747;
			short num2 = num;
			num = (short)1563816323;
			switch (num2 == num)
			{
			}
			num = (short)1013317632;
			if (num != 0)
			{
			}
			num = (short)1957691392;
			short num3 = num;
			global::Motorola.CommonCPS.RadioManagement.ASTROSystem.RadioDetailsView.CellFillEndedCommandProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.ASTROSystem.ModuleASTROSystem.b("욢즤쮦슪솬쎮\uddb2톴튶\uddb8튼튾곀ꋂꯄꏆ", a_), typeof(global::Microsoft.Practices.Prism.Commands.DelegateCommand), typeof(global::Motorola.CommonCPS.RadioManagement.ASTROSystem.RadioDetailsView), new global::System.Windows.FrameworkPropertyMetadata(null));
		}

		// Token: 0x06000091 RID: 145 RVA: 0x0000A34C File Offset: 0x0000854C
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private void a(global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillEndedEventArgs A_0)
		{
			short num = (short)842893514;
			short num2 = num;
			num = (short)1702070474;
			switch (num2 == num)
			{
			}
			num = (short)571604992;
			if (num != 0)
			{
			}
			num = (short)509870081;
			if (num != 0)
			{
			}
			num = (short)439943168;
			short num3 = num;
			this.CellFillEndedCommand.Execute();
		}

		// Token: 0x04000039 RID: 57
		private global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillManager fillManager;

		// Token: 0x0400003A RID: 58
		public static readonly global::System.Windows.DependencyProperty CellFillEndedCommandProperty;

		// Token: 0x0400003B RID: 59
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid dgrSystems;

		// Token: 0x0400003C RID: 60
		private bool _contentLoaded;
	}
}
