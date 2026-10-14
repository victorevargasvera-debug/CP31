using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.Composition;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Data;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Events;
using Microsoft.Practices.Prism.Regions;
using Motorola.CommonCPS.RadioManagement.Command;
using Motorola.CommonCPS.RadioManagement.Events;
using Motorola.CommonCPS.RadioManagement.Global;
using Motorola.CommonCPS.RadioManagement.Infrastructure;
using Motorola.CommonCPS.RadioManagement.LocalService;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.ASTROSystem
{
	// Token: 0x02000014 RID: 20
	[global::System.ComponentModel.Composition.Export]
	public class RadioSystemsViewModel : global::Motorola.CommonCPS.RadioManagement.Infrastructure.CachedTableViewModelBase<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem>
	{
		// Token: 0x0600005A RID: 90 RVA: 0x00006864 File Offset: 0x00004A64
		[global::System.ComponentModel.Composition.ImportingConstructor]
		public RadioSystemsViewModel(global::Microsoft.Practices.Prism.Events.IEventAggregator eventAggregator) : base(eventAggregator)
		{
			base.ShowDetailsCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem>(new global::System.Action<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem>(this.b));
			this.c = new global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem>(new global::System.Action<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem>(this.a));
			this.d = new global::Microsoft.Practices.Prism.Commands.DelegateCommand<string>(new global::System.Action<string>(this.a));
			this.e = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(global::Motorola.CommonCPS.RadioManagement.ASTROSystem.RadioSystemsViewModel.<>c.<>9.a));
			global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxy.GetInstance().ExportAstroSystemToFileCommand = (this.f = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.b), new global::System.Func<bool>(this.a)));
			this.h = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(global::Motorola.CommonCPS.RadioManagement.ASTROSystem.RadioSystemsViewModel.c));
			this.g = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(global::Motorola.CommonCPS.RadioManagement.ASTROSystem.RadioSystemsViewModel.<>c.<>9.b), new global::System.Func<bool>(global::Motorola.CommonCPS.RadioManagement.ASTROSystem.RadioSystemsViewModel.<>c.<>9.c));
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600005B RID: 91 RVA: 0x00006984 File Offset: 0x00004B84
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem> ShowSystemDetailsCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1103888790;
				short num2 = num;
				num = (short)882508182;
				switch (num2 == num)
				{
				}
				num = (short)765591552;
				if (num != 0)
				{
				}
				num = (short)204996609;
				if (num != 0)
				{
				}
				num = (short)1776680960;
				short num3 = num;
				return this.c;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600005C RID: 92 RVA: 0x00006A38 File Offset: 0x00004C38
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand<string> ChangeRadioIDEntryFormatCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2132438200;
				short num2 = num;
				num = (short)1735027896;
				switch (num2 == num)
				{
				}
				num = (short)207290369;
				if (num != 0)
				{
				}
				num = (short)1359413248;
				if (num != 0)
				{
				}
				num = (short)1721565184;
				short num3 = num;
				return this.d;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600005D RID: 93 RVA: 0x00006AEC File Offset: 0x00004CEC
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand EnterEditModeCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1166737409;
				if (num != 0)
				{
				}
				num = (short)646414222;
				short num2 = num;
				num = (short)783843214;
				switch (num2 == num)
				{
				}
				num = (short)518389760;
				if (num != 0)
				{
				}
				num = (short)1466433536;
				short num3 = num;
				return this.e;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600005E RID: 94 RVA: 0x00006B9C File Offset: 0x00004D9C
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand ExportAstroSystemToFileCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1829891845;
				short num2 = num;
				num = (short)1034743557;
				switch (num2 == num)
				{
				}
				num = (short)836763649;
				if (num != 0)
				{
				}
				num = (short)1074266112;
				if (num != 0)
				{
				}
				num = (short)1213267968;
				short num3 = num;
				return this.f;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600005F RID: 95 RVA: 0x00006C4C File Offset: 0x00004E4C
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand ImportAstroSystemFromFileCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1312948225;
				if (num != 0)
				{
				}
				num = (short)639597805;
				short num2 = num;
				num = (short)1458470125;
				switch (num2 == num)
				{
				}
				num = (short)1207042048;
				if (num != 0)
				{
				}
				num = (short)735248384;
				short num3 = num;
				return this.g;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000060 RID: 96 RVA: 0x00006D00 File Offset: 0x00004F00
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand CellFillEndedCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1274393995;
				short num2 = num;
				num = (short)2064430475;
				switch (num2 == num)
				{
				}
				num = (short)856686592;
				if (num != 0)
				{
				}
				num = (short)1512898561;
				if (num != 0)
				{
				}
				num = (short)21889024;
				short num3 = num;
				return this.h;
			}
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00006DB0 File Offset: 0x00004FB0
		protected override global::System.ComponentModel.ICollectionView GetItems()
		{
			short num = (short)1428881409;
			if (num != 0)
			{
			}
			num = (short)1849114526;
			short num2 = num;
			num = (short)1106788254;
			switch (num2 == num)
			{
			}
			num = (short)904069120;
			if (num != 0)
			{
			}
			num = (short)1912537088;
			short num3 = num;
			return global::System.Windows.Data.CollectionViewSource.GetDefaultView(base.ServiceProxy.LocalService.GetASTROSystems(this.a));
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00006E74 File Offset: 0x00005074
		protected override void SaveItem(object[] parameters)
		{
			short num;
			try
			{
				num = (short)140844028;
				short num2 = num;
				num = (short)341318652;
				switch (num2 == num)
				{
				}
				num = (short)645791745;
				if (num != 0)
				{
				}
				num = (short)232390656;
				if (num != 0)
				{
				}
				base.ServiceProxy.CommandHandler.SaveASTROSystemCommand.Execute(parameters);
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, true);
				throw;
			}
			num = (short)732823552;
			short num3 = num;
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00006F4C File Offset: 0x0000514C
		protected override void OnSelectedItemsCollectionChanged()
		{
			short num = (short)864048693;
			short num2 = num;
			num = (short)717510197;
			switch (num2 == num)
			{
			}
			num = (short)1849753601;
			if (num != 0)
			{
			}
			num = (short)1715142656;
			if (num != 0)
			{
			}
			num = (short)560267264;
			short num3 = num;
			base.OnSelectedItemsCollectionChanged();
			this.ExportAstroSystemToFileCommand.RaiseCanExecuteChanged();
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00007004 File Offset: 0x00005204
		private void b(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem A_0)
		{
			int a_ = 3;
			short num = (short)316846819;
			short num2 = num;
			num = (short)1893380835;
			switch (num2 == num)
			{
			}
			num = (short)1180303360;
			if (num != 0)
			{
			}
			num = (short)1682046977;
			if (num != 0)
			{
			}
			num = (short)656408576;
			short num3 = num;
			global::System.Collections.Generic.List<string> parameters = new global::System.Collections.Generic.List<string>
			{
				global::Motorola.CommonCPS.RadioManagement.ASTROSystem.ModuleASTROSystem.b("잔ﶘ횞麢", a_) + A_0.DeviceID.ToString(),
				global::Motorola.CommonCPS.RadioManagement.ASTROSystem.ModuleASTROSystem.b("요ﲜ횢좤얦첨\ud9aa邬", a_) + base.UrlEncode(A_0.SerialNumber)
			};
			global::Motorola.CommonCPS.RadioManagement.Infrastructure.NavigationHelper.Go(global::Motorola.CommonCPS.RadioManagement.ASTROSystem.ModuleASTROSystem.b("요좖쮘漢列캠삤펦좨슪솬\udcae\udab2킴삶", a_), parameters);
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00007124 File Offset: 0x00005324
		private void a(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem A_0)
		{
			int a_ = 0;
			short num = (short)1791200034;
			short num2 = num;
			num = (short)501386018;
			switch (num2 == num)
			{
			}
			num = (short)1138229249;
			if (num != 0)
			{
			}
			num = (short)1451360256;
			if (num != 0)
			{
			}
			num = (short)2020409344;
			short num3 = num;
			global::System.Collections.Generic.List<string> parameters = new global::System.Collections.Generic.List<string>
			{
				global::Motorola.CommonCPS.RadioManagement.ASTROSystem.ModuleASTROSystem.b("햑秊햛\uda9d鶟", a_) + base.UrlEncode(this.a),
				global::Motorola.CommonCPS.RadioManagement.ASTROSystem.ModuleASTROSystem.b("솑ﾙ힝龡", a_) + base.UrlEncode(A_0.CustomID),
				global::Motorola.CommonCPS.RadioManagement.ASTROSystem.ModuleASTROSystem.b("\udc91ﮕﶗꞙ", a_) + base.UrlEncode(A_0.SystemName)
			};
			global::Motorola.CommonCPS.RadioManagement.Infrastructure.NavigationHelper.Go(global::Motorola.CommonCPS.RadioManagement.ASTROSystem.ModuleASTROSystem.b("솑ﾙ\uda9d얟횡얣쾥쒧\ud9a9磌잭햯얱", a_), parameters);
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00007260 File Offset: 0x00005460
		private void a(string A_0)
		{
			int a_ = 18;
			short num = (short)2020081664;
			short num2 = num;
			this.RadioIDEntryFormat = A_0;
			global::System.Collections.IEnumerator enumerator = base.Items.GetEnumerator();
			try
			{
				num = (short)395902978;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						goto IL_128;
					case 1:
						if (!enumerator.MoveNext())
						{
							num = (short)1700724740;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						((global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem)enumerator.Current).InvokeRaisePropertyChanged(global::Motorola.CommonCPS.RadioManagement.ASTROSystem.ModuleASTROSystem.b("장첧쎩쎫", a_));
						num = (short)713883651;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						num = (short)821100545;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_A5;
						}
						continue;
					case 4:
						num = (short)1489502208;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_DB:
					num = (short)2057175041;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_A5:
					goto IL_DB;
				}
				IL_128:;
			}
			finally
			{
				switch (0)
				{
				case 0:
					goto IL_149;
				}
				int num3;
				global::System.IDisposable disposable;
				for (;;)
				{
					IL_137:
					switch (num3)
					{
					case 0:
						goto IL_1EB;
					case 1:
						if (disposable != null)
						{
							num = (short)2121334786;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1ED;
					case 2:
						for (;;)
						{
							disposable.Dispose();
							num = (short)1318845874;
							short num4 = num;
							num = (short)614727090;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								goto IL_1BD;
							}
						}
						IL_1BD:
						num = (short)163905536;
						if (num != 0)
						{
						}
						num = (short)463863808;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_149;
				}
				IL_1EB:
				IL_1ED:
				goto EndFinally_5;
				IL_149:
				disposable = (enumerator as global::System.IDisposable);
				num = (short)1706360833;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_137;
				EndFinally_5:;
			}
		}

		// Token: 0x06000067 RID: 103 RVA: 0x0000746C File Offset: 0x0000566C
		private static void c()
		{
			short num = (short)1528313589;
			short num2 = num;
			num = (short)834025205;
			switch (num2 == num)
			{
			}
			num = (short)882180096;
			if (num != 0)
			{
			}
			num = (short)541458433;
			if (num != 0)
			{
			}
			num = (short)373751808;
			short num3 = num;
			global::Motorola.CommonCPS.RadioManagement.LocalService.RadioCache.Instance.Clear();
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00007520 File Offset: 0x00005720
		private void b()
		{
			short num;
			try
			{
				num = (short)861995010;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)1156760022;
					short num3 = num;
					num = (short)1003667926;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1290403840;
						if (num != 0)
						{
						}
						switch (num2)
						{
						case 0:
							goto IL_14A;
						case 1:
							goto IL_133;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_83;
							}
							continue;
						case 3:
							base.ServiceProxy.CommandHandler.ExportASTROSystemGridToFileCommand.Execute(new object[]
							{
								base.SelectedItems
							});
							num = (short)208470020;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							goto IL_133;
						}
						break;
						IL_133:
						num = (short)1531248640;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_83:
					if (base.SelectedItems.Any<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem>())
					{
						num = (short)826212355;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						base.ServiceProxy.CommandHandler.ExportASTROSystemGridToFileCommand.Execute(new object[]
						{
							base.Items.SourceCollection as global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem>
						});
						num = (short)2028142593;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				IL_14A:;
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
			}
			num = (short)599523329;
			if (num != 0)
			{
			}
			num = (short)1760821248;
			short num4 = num;
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000069 RID: 105 RVA: 0x000076F0 File Offset: 0x000058F0
		// (set) Token: 0x0600006A RID: 106 RVA: 0x0000779C File Offset: 0x0000599C
		public string RadioIDEntryFormat
		{
			get
			{
				short num = (short)189899487;
				short num2 = num;
				num = (short)251044575;
				switch (num2 == num)
				{
				}
				num = (short)347013121;
				if (num != 0)
				{
				}
				num = (short)8847360;
				if (num != 0)
				{
				}
				num = (short)401932288;
				short num3 = num;
				return this.b;
			}
			set
			{
				int a_ = 13;
				short num = (short)1086914562;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)353239040;
					short num3 = num;
					switch (num2)
					{
					case 0:
						goto IL_107;
					case 1:
						this.b = value;
						this.RaisePropertyChanged(global::Motorola.CommonCPS.RadioManagement.ASTROSystem.ModuleASTROSystem.b("춞삠잢첤좦솮얰솲체횸즺킼\udebe뗀", a_));
						num = (short)211419136;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_61;
						}
						continue;
					}
					IL_61:
					num = (short)703654062;
					short num4 = num;
					num = (short)907077806;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_109;
					default:
						num = (short)1836515328;
						if (num != 0)
						{
						}
						if (!(this.b != value))
						{
							goto IL_109;
						}
						num = (short)1843724289;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				IL_107:
				IL_109:
				num = (short)1317076993;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x0600006B RID: 107 RVA: 0x000078DC File Offset: 0x00005ADC
		private bool a()
		{
			short num;
			bool result;
			try
			{
				num = (short)964840186;
				short num2 = num;
				num = (short)574376698;
				switch (num2 == num)
				{
				}
				num = (short)1123418113;
				if (num != 0)
				{
				}
				num = (short)1381433344;
				if (num != 0)
				{
				}
				global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation exportASTROSystemGridToFileCommand = base.ServiceProxy.CommandHandler.ExportASTROSystemGridToFileCommand;
				object[] array = new object[1];
				int num3 = 0;
				global::System.ComponentModel.ICollectionView items = base.Items;
				array[num3] = (((items != null) ? items.SourceCollection : null) as global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem>);
				result = exportASTROSystemGridToFileCommand.CanExecute(array);
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, false, false);
				result = false;
			}
			num = (short)1971388416;
			short num4 = num;
			return result;
		}

		// Token: 0x0600006C RID: 108 RVA: 0x000079E4 File Offset: 0x00005BE4
		public override void OnNavigatedTo(global::Microsoft.Practices.Prism.Regions.NavigationContext navigationContext)
		{
			int a_ = 18;
			short num = (short)591899969;
			short num2 = num;
			num = (short)744140097;
			switch (num2 == num)
			{
			}
			num = (short)799408129;
			if (num != 0)
			{
			}
			num = (short)1128529920;
			if (num != 0)
			{
			}
			num = (short)782106624;
			short num3 = num;
			base.OnNavigatedTo(navigationContext);
			this.a = navigationContext.Parameters[global::Motorola.CommonCPS.RadioManagement.ASTROSystem.ModuleASTROSystem.b("풥잧\udfa9\udcab", a_)];
			this.RadioIDEntryFormat = global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.ASTROMDCEntryFormat.ToUpperInvariant();
			this.Refresh();
			global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveMainView = global::Motorola.CommonCPS.RadioManagement.ASTROSystem.ModuleASTROSystem.b("장첧쎩쎫ﶭ즯솱삳펵햷즹ힽꖿ뗁", a_);
			base.EventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.LockSelectedNavigationItemRequestedEvent>().Publish(null);
		}

		// Token: 0x04000028 RID: 40
		private string a;

		// Token: 0x04000029 RID: 41
		private string b;

		// Token: 0x0400002A RID: 42
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem> c;

		// Token: 0x0400002B RID: 43
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly global::Microsoft.Practices.Prism.Commands.DelegateCommand<string> d;

		// Token: 0x0400002C RID: 44
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly global::Microsoft.Practices.Prism.Commands.DelegateCommand e;

		// Token: 0x0400002D RID: 45
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly global::Microsoft.Practices.Prism.Commands.DelegateCommand f;

		// Token: 0x0400002E RID: 46
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly global::Microsoft.Practices.Prism.Commands.DelegateCommand g;

		// Token: 0x0400002F RID: 47
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly global::Microsoft.Practices.Prism.Commands.DelegateCommand h;
	}
}
