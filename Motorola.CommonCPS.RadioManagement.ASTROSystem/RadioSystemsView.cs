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
using Microsoft.Practices.Prism.Events;
using Motorola.CommonCPS.RadioManagement.Controls;
using Motorola.CommonCPS.RadioManagement.Converters;
using Motorola.CommonCPS.RadioManagement.Events;
using Motorola.CommonCPS.RadioManagement.Global;
using Motorola.CommonCPS.RadioManagement.Infrastructure;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.UI.CellRangeFill;

namespace Motorola.CommonCPS.RadioManagement.ASTROSystem
{
	// Token: 0x02000016 RID: 22
	[global::Motorola.CommonCPS.RadioManagement.Infrastructure.ViewExport(RegionName = "ASTROSystemMainRegion")]
	public class RadioSystemsView : global::System.Windows.Controls.UserControl, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x06000072 RID: 114 RVA: 0x00007DC8 File Offset: 0x00005FC8
		[global::System.ComponentModel.Composition.ImportingConstructor]
		public RadioSystemsView(global::Microsoft.Practices.Prism.Events.IEventAggregator eventAggregator)
		{
			int a_ = 6;
			base..ctor();
			this.InitializeComponent();
			this.a();
			eventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.GetDataGridForASTROSystemRequestedEvent>().Subscribe(new global::System.Action<global::Motorola.CommonCPS.RadioManagement.Events.ResultPayload<global::Motorola.CommonCPS.RadioManagement.UIModels.RMDataGridInfo>>(this.a));
			base.SetBinding(global::Motorola.CommonCPS.RadioManagement.ASTROSystem.RadioSystemsView.CellFillEndedCommandProperty, global::Motorola.CommonCPS.RadioManagement.ASTROSystem.ModuleASTROSystem.b("\udb97ﾙ쮡좣쪥쒩좫쮭풯\udbb3\udbb5햷\udbb9튻\udabd", a_));
		}

		// Token: 0x17000016 RID: 22
		// (set) Token: 0x06000073 RID: 115 RVA: 0x00007E24 File Offset: 0x00006024
		[global::System.ComponentModel.Composition.Import]
		public global::Motorola.CommonCPS.RadioManagement.ASTROSystem.RadioSystemsViewModel ViewModel
		{
			set
			{
				short num = (short)1794244609;
				if (num != 0)
				{
				}
				num = (short)436458074;
				short num2 = num;
				num = (short)1378407002;
				switch (num2 == num)
				{
				}
				num = (short)606863360;
				if (num != 0)
				{
				}
				num = (short)69074944;
				short num3 = num;
				base.DataContext = value;
			}
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00007ED4 File Offset: 0x000060D4
		private void c(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 8;
			switch (0)
			{
			case 0:
				goto IL_5B;
			}
			short num;
			int num2;
			for (;;)
			{
				IL_13:
				num = (short)126812161;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
					return;
				case 1:
					goto IL_166;
				case 2:
					if (this._fillManager == null)
					{
						num = (short)2140930051;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 3:
				{
					this._fillManager = global::Motorola.CommonCPS.RadioManagement.ASTROSystem.c.a(this.dgrRadioSystems);
					global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillManager fillManager = this._fillManager;
					fillManager.CellFillEnded = (global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillEndedEventHandler)global::System.Delegate.Combine(fillManager.CellFillEnded, new global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillEndedEventHandler(this.a));
					num = (short)993722368;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
					this.dgrRadioSystems.FieldLayouts[0].Fields[global::Motorola.CommonCPS.RadioManagement.ASTROSystem.ModuleASTROSystem.b("좙ﶛ瞧즟춡", a_)].Converter = new global::Motorola.CommonCPS.RadioManagement.Converters.RadioIDEntryFormatConverter();
					global::Motorola.CommonCPS.RadioManagement.ASTROSystem.RadioSystemsView.a(global::System.Windows.LogicalTreeHelper.FindLogicalNode(base.Resources[global::Motorola.CommonCPS.RadioManagement.ASTROSystem.ModuleASTROSystem.b("蓮\udd9d쾟첡튣쎥\udaa7\udea9즫\udcad", a_)] as global::System.Windows.Controls.ContextMenu, global::Motorola.CommonCPS.RadioManagement.ASTROSystem.ModuleASTROSystem.b("튙鍊춡횣쮥즧\udea9", a_)));
					num = (short)1544224773;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					goto IL_166;
				case 6:
				{
					num = (short)1897970754;
					short num3 = num;
					num = (short)1665121346;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
					{
						num = (short)1250230272;
						short num4 = num;
						num = (short)1510998016;
						if (num != 0)
						{
						}
						if (global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.ASTROMDCEntryFormat.ToUpperInvariant() == global::Motorola.CommonCPS.RadioManagement.ASTROSystem.ModuleASTROSystem.b("튙", a_))
						{
							num = (short)116654084;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.dgrRadioSystems.FieldLayouts[0].Fields[global::Motorola.CommonCPS.RadioManagement.ASTROSystem.ModuleASTROSystem.b("좙ﶛ瞧즟춡", a_)].Converter = new global::Motorola.CommonCPS.RadioManagement.Converters.MDCRadioIDEntryFormatToHexConverter();
						global::Motorola.CommonCPS.RadioManagement.ASTROSystem.RadioSystemsView.a(global::System.Windows.LogicalTreeHelper.FindLogicalNode(base.Resources[global::Motorola.CommonCPS.RadioManagement.ASTROSystem.ModuleASTROSystem.b("蓮\udd9d쾟첡튣쎥\udaa7\udea9즫\udcad", a_)] as global::System.Windows.Controls.ContextMenu, global::Motorola.CommonCPS.RadioManagement.ASTROSystem.ModuleASTROSystem.b("\ude99鍊ﶝ즟쾡얣쪥얩\udeab쎭톯욱", a_)));
						num = (short)303366145;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				}
				goto IL_5B;
				IL_166:
				num = (short)1312948226;
				num2 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_5B:
			this.dgrRadioSystems.FieldLayouts[0].Fields[global::Motorola.CommonCPS.RadioManagement.ASTROSystem.ModuleASTROSystem.b("좙ﶛ瞧즟춡", a_)].Settings.EditAsType = typeof(string);
			num = (short)810811398;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_13;
		}

		// Token: 0x06000075 RID: 117 RVA: 0x000081E8 File Offset: 0x000063E8
		private void a()
		{
			int a_ = 9;
			short num = (short)122028033;
			if (num != 0)
			{
			}
			num = (short)665239315;
			short num2 = num;
			num = (short)1995554579;
			switch (num2 == num)
			{
			}
			num = (short)2024144896;
			if (num != 0)
			{
			}
			num = (short)538378240;
			short num3 = num;
			this.dgrRadioSystems.RemoveColumn((global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ModeIdentifier == global::Motorola.CommonCPS.RadioManagement.Global.ModeIdentifier.Configuration) ? global::Motorola.CommonCPS.RadioManagement.ASTROSystem.ModuleASTROSystem.b("쾚토쾢쒤펦첨첬슮풰", a_) : global::Motorola.CommonCPS.RadioManagement.ASTROSystem.ModuleASTROSystem.b("\ud89a잠쪢스튦\udba8쪪\ud9ac욮\udeb0\uddb2﮴횶풸\udeba", a_));
		}

		// Token: 0x06000076 RID: 118 RVA: 0x000082D0 File Offset: 0x000064D0
		private void a(global::Motorola.CommonCPS.RadioManagement.Events.ResultPayload<global::Motorola.CommonCPS.RadioManagement.UIModels.RMDataGridInfo> A_0)
		{
			short num = (short)313655297;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid rmdataGrid = this.dgrRadioSystems;
			if (rmdataGrid == null)
			{
				num = (short)1899756332;
				short num2 = num;
				num = (short)51444524;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1370095616;
					if (num != 0)
					{
					}
					return;
				}
			}
			num = (short)1337065472;
			short num3 = num;
			A_0.Result = rmdataGrid.GetGridInfo();
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000077 RID: 119 RVA: 0x00008390 File Offset: 0x00006590
		// (set) Token: 0x06000078 RID: 120 RVA: 0x00008448 File Offset: 0x00006648
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand CellFillEndedCommand
		{
			get
			{
				short num = (short)900190470;
				short num2 = num;
				num = (short)772854022;
				switch (num2 == num)
				{
				}
				num = (short)505020417;
				if (num != 0)
				{
				}
				num = (short)1672871936;
				if (num != 0)
				{
				}
				num = (short)948961280;
				short num3 = num;
				return (global::Microsoft.Practices.Prism.Commands.DelegateCommand)base.GetValue(global::Motorola.CommonCPS.RadioManagement.ASTROSystem.RadioSystemsView.CellFillEndedCommandProperty);
			}
			set
			{
				short num = (short)72837753;
				short num2 = num;
				num = (short)1934781049;
				switch (num2 == num)
				{
				}
				num = (short)15073280;
				if (num != 0)
				{
				}
				num = (short)54132737;
				if (num != 0)
				{
				}
				num = (short)5701632;
				short num3 = num;
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.ASTROSystem.RadioSystemsView.CellFillEndedCommandProperty, value);
			}
		}

		// Token: 0x06000079 RID: 121 RVA: 0x000084FC File Offset: 0x000066FC
		private void a(object A_0, global::System.Windows.Input.MouseButtonEventArgs A_1)
		{
			int a_ = 2;
			switch (0)
			{
			case 0:
				goto IL_2D;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
				{
					global::System.Windows.Controls.ContextMenu contextMenu = base.FindResource(global::Motorola.CommonCPS.RadioManagement.ASTROSystem.ModuleASTROSystem.b("ﮕ\udb97얟킡킣쎥\udaa7", a_)) as global::System.Windows.Controls.ContextMenu;
					global::Infragistics.Windows.DataPresenter.LabelPresenter labelPresenter;
					labelPresenter.ContextMenu = contextMenu;
					labelPresenter.ContextMenu.IsOpen = true;
					A_1.Handled = true;
					num2 = (short)1233256449;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
					goto IL_140;
				case 2:
					num2 = (short)1344471043;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
				{
					global::Infragistics.Windows.DataPresenter.LabelPresenter labelPresenter;
					if (labelPresenter.Field.Name == global::Motorola.CommonCPS.RadioManagement.ASTROSystem.ModuleASTROSystem.b("욓ﲗ힝", a_))
					{
						num2 = (short)387710976;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_196;
				}
				case 4:
				{
					global::Infragistics.Windows.DataPresenter.LabelPresenter labelPresenter;
					if (labelPresenter != null)
					{
						num2 = (short)1655898114;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_196;
				}
				}
				goto IL_2D;
			}
			IL_140:
			IL_196:
			num2 = (short)930611200;
			short num3 = num2;
			return;
			IL_2D:
			num2 = (short)663232926;
			short num4 = num2;
			num2 = (short)632299934;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num2 = (short)1182203905;
				if (num2 != 0)
				{
				}
				num2 = (short)1258881024;
				if (num2 != 0)
				{
				}
				global::Infragistics.Windows.DataPresenter.LabelPresenter labelPresenter = global::Infragistics.Windows.Utilities.GetAncestorFromType(A_1.OriginalSource as global::System.Windows.DependencyObject, typeof(global::Infragistics.Windows.DataPresenter.LabelPresenter), true) as global::Infragistics.Windows.DataPresenter.LabelPresenter;
				break;
			}
			}
			num2 = (short)1095630852;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x0600007A RID: 122 RVA: 0x000086C8 File Offset: 0x000068C8
		private void b(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 6;
			short num = (short)1708261376;
			short num2 = num;
			num = (short)1934549364;
			short num3 = num;
			num = (short)2032394612;
			switch (num3 == num)
			{
			}
			num = (short)179175425;
			if (num != 0)
			{
			}
			num = (short)21233664;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.ASTROSystem.RadioSystemsView.a(global::Motorola.CommonCPS.RadioManagement.ASTROSystem.ModuleASTROSystem.b("\udc97", a_));
			this.dgrRadioSystems.FieldLayouts[0].Fields[global::Motorola.CommonCPS.RadioManagement.ASTROSystem.ModuleASTROSystem.b("쪗ﮙ쾟", a_)].Converter = new global::Motorola.CommonCPS.RadioManagement.Converters.MDCRadioIDEntryFormatToHexConverter();
			global::Motorola.CommonCPS.RadioManagement.ASTROSystem.RadioSystemsView.a(A_0);
		}

		// Token: 0x0600007B RID: 123 RVA: 0x000087C8 File Offset: 0x000069C8
		private void a(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 10;
			short num = (short)2045902848;
			short num2 = num;
			num = (short)1492587865;
			short num3 = num;
			num = (short)1643124057;
			switch (num3 == num)
			{
			}
			num = (short)2030174208;
			if (num != 0)
			{
			}
			num = (short)1858469889;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.ASTROSystem.RadioSystemsView.a(global::Motorola.CommonCPS.RadioManagement.ASTROSystem.ModuleASTROSystem.b("풛", a_));
			this.dgrRadioSystems.FieldLayouts[0].Fields[global::Motorola.CommonCPS.RadioManagement.ASTROSystem.ModuleASTROSystem.b("캛ﾝ쒟쮡쮣", a_)].Converter = new global::Motorola.CommonCPS.RadioManagement.Converters.RadioIDEntryFormatConverter();
			global::Motorola.CommonCPS.RadioManagement.ASTROSystem.RadioSystemsView.a(A_0);
		}

		// Token: 0x0600007C RID: 124 RVA: 0x000088C8 File Offset: 0x00006AC8
		private static void a(string A_0)
		{
			short num = (short)1421737984;
			short num2 = num;
			num = (short)1344260531;
			short num3 = num;
			num = (short)110086579;
			switch (num3 == num)
			{
			}
			num = (short)1291976705;
			if (num != 0)
			{
			}
			num = (short)273547264;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.ASTROMDCEntryFormat = A_0;
			global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.Save();
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00008984 File Offset: 0x00006B84
		private static void a(object A_0)
		{
			for (;;)
			{
				IL_00:
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				global::System.Windows.Controls.MenuItem menuItem;
				short num2;
				for (;;)
				{
					IL_0A:
					global::System.Collections.Generic.IEnumerator<global::System.Windows.Controls.MenuItem> enumerator;
					switch (num)
					{
					case 0:
						if (menuItem != null)
						{
							num2 = (short)64421890;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					case 1:
					{
						num2 = (short)367329280;
						short num3 = num2;
						num2 = (short)1454420141;
						short num4 = num2;
						num2 = (short)865448109;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num2 = (short)978124800;
							if (num2 != 0)
							{
							}
							num2 = (short)764280833;
							if (num2 != 0)
							{
							}
							try
							{
								num2 = (short)1617166337;
								num = (int)((global::System.IntPtr)num2);
								for (;;)
								{
									switch (num)
									{
									case 1:
										switch (0)
										{
										case 0:
											goto IL_97;
										}
										continue;
									case 2:
									{
										if (!enumerator.MoveNext())
										{
											num2 = (short)1153236998;
											num = (int)((global::System.IntPtr)num2);
											continue;
										}
										global::System.Windows.Controls.MenuItem menuItem2 = enumerator.Current;
										num2 = (short)870907907;
										num = (int)((global::System.IntPtr)num2);
										continue;
									}
									case 3:
									{
										global::System.Windows.Controls.MenuItem menuItem2;
										if (menuItem2 != menuItem)
										{
											num2 = (short)7602181;
											num = (int)((global::System.IntPtr)num2);
											continue;
										}
										break;
									}
									case 4:
										goto IL_13E;
									case 5:
									{
										global::System.Windows.Controls.MenuItem menuItem2;
										menuItem2.IsChecked = false;
										num2 = (short)1148452864;
										num = (int)((global::System.IntPtr)num2);
										continue;
									}
									case 6:
										num2 = (short)501481476;
										num = (int)((global::System.IntPtr)num2);
										continue;
									}
									IL_99:
									num2 = (short)422182914;
									num = (int)((global::System.IntPtr)num2);
									continue;
									IL_97:
									goto IL_99;
								}
								IL_13E:
								return;
							}
							finally
							{
								num2 = (short)1590755328;
								num = (int)((global::System.IntPtr)num2);
								for (;;)
								{
									switch (num)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_173;
										}
										continue;
									case 1:
										goto IL_1A7;
									case 2:
										enumerator.Dispose();
										num2 = (short)640024577;
										num = (int)((global::System.IntPtr)num2);
										continue;
									}
									IL_173:
									if (enumerator == null)
									{
										break;
									}
									num2 = (short)303562754;
									num = (int)((global::System.IntPtr)num2);
								}
								IL_1A7:;
							}
							goto IL_1AA;
						}
						break;
					}
					case 2:
						goto IL_1AA;
					}
					break;
					IL_1AA:
					global::System.Collections.Generic.IEnumerable<global::System.Windows.Controls.MenuItem> enumerable = ((global::System.Windows.Controls.ContextMenu)menuItem.Parent).Items.OfType<global::System.Windows.Controls.MenuItem>();
					menuItem.IsChecked = true;
					enumerator = enumerable.GetEnumerator();
					num2 = (short)712835073;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_1C:
				menuItem = (A_0 as global::System.Windows.Controls.MenuItem);
				num2 = (short)2099380224;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00008C28 File Offset: 0x00006E28
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			int a_ = 13;
			short num;
			for (;;)
			{
				num = (short)1586954240;
				short num2 = num;
				if (this._contentLoaded)
				{
					break;
				}
				num = (short)747090995;
				short num3 = num;
				num = (short)1206105139;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_71;
				}
			}
			return;
			IL_71:
			num = (short)986185729;
			if (num != 0)
			{
			}
			num = (short)1821048832;
			if (num != 0)
			{
			}
			this._contentLoaded = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.ASTROSystem.ModuleASTROSystem.b("낞첢톤좦\udba8쒪솬캮龰\udab4\udab6풸풺펼ﲾ釀郂闆꣈꿊꓌ꃎ鳐닒믔뛖뻘뻚냜뫞迠韢쯤ꛦ뫨뿪뿬ꃮꋰ諲蛴菶鳸雺웼鳾渀渂甄栆月渊挌笎㸐愒琔猖瀘琚渜昞删圢䀤䨦娨崪䐬䨮䘰ᰲ䜴嘶崸刺刼䰾㡀あㅄ≆⑈㡊㭌♎㑐⑒答⽖㡘㙚ㅜ", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00008D08 File Offset: 0x00006F08
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)757006336;
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
					goto IL_118;
				case 2:
					num = (short)431554561;
					if (num != 0)
					{
					}
					goto IL_100;
				}
				IL_30:
				switch (connectionId)
				{
				case 1:
					goto IL_13E;
				case 2:
				{
					num = (short)211248792;
					short num3 = num;
					num = (short)1978427032;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_D3;
					}
					break;
				}
				case 3:
					goto IL_85;
				case 4:
					goto IL_11A;
				default:
					num = (short)510001154;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_100:
				num = (short)60751873;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_85:
			((global::System.Windows.Controls.MenuItem)target).Click += this.a;
			return;
			IL_D3:
			num = (short)696451072;
			if (num != 0)
			{
			}
			((global::System.Windows.Controls.MenuItem)target).Click += this.b;
			return;
			IL_118:
			num = (short)883425280;
			short num4 = num;
			this._contentLoaded = true;
			return;
			IL_11A:
			this.dgrRadioSystems = (global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid)target;
			this.dgrRadioSystems.PreviewMouseRightButtonDown += this.a;
			return;
			IL_13E:
			this.uscRadioSystems = (global::Motorola.CommonCPS.RadioManagement.ASTROSystem.RadioSystemsView)target;
			this.uscRadioSystems.Loaded += this.c;
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00008EAC File Offset: 0x000070AC
		// Note: this type is marked as 'beforefieldinit'.
		static RadioSystemsView()
		{
			int a_ = 17;
			short num = (short)2044854272;
			short num2 = num;
			num = (short)1968380371;
			short num3 = num;
			num = (short)22485459;
			switch (num3 == num)
			{
			}
			num = (short)635699201;
			if (num != 0)
			{
			}
			num = (short)693370880;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.ASTROSystem.RadioSystemsView.CellFillEndedCommandProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.ASTROSystem.ModuleASTROSystem.b("삤쮦얨쒬쎮\uddb0\udbb4펶\udcb8\udfbaﺼ킾곀껂꓄꧆귈", a_), typeof(global::Microsoft.Practices.Prism.Commands.DelegateCommand), typeof(global::Motorola.CommonCPS.RadioManagement.ASTROSystem.RadioSystemsView), new global::System.Windows.FrameworkPropertyMetadata(null));
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00008F90 File Offset: 0x00007190
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private void a(global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillEndedEventArgs A_0)
		{
			short num = (short)1205141504;
			short num2 = num;
			num = (short)1751221541;
			short num3 = num;
			num = (short)1253016869;
			switch (num3 == num)
			{
			}
			num = (short)601096193;
			if (num != 0)
			{
			}
			num = (short)157548544;
			if (num != 0)
			{
			}
			this.CellFillEndedCommand.Execute();
		}

		// Token: 0x04000034 RID: 52
		private global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillManager _fillManager;

		// Token: 0x04000035 RID: 53
		public static readonly global::System.Windows.DependencyProperty CellFillEndedCommandProperty;

		// Token: 0x04000036 RID: 54
		internal global::Motorola.CommonCPS.RadioManagement.ASTROSystem.RadioSystemsView uscRadioSystems;

		// Token: 0x04000037 RID: 55
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid dgrRadioSystems;

		// Token: 0x04000038 RID: 56
		private bool _contentLoaded;
	}
}
