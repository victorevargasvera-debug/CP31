using System;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Composition;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Windows.Data;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Events;
using Microsoft.Practices.Prism.Interactivity.InteractionRequest;
using Microsoft.Practices.Prism.Regions;
using Motorola.CommonCPS.RadioManagement.Events;
using Motorola.CommonCPS.RadioManagement.Global;
using Motorola.CommonCPS.RadioManagement.Infrastructure;
using Motorola.CommonCPS.RadioManagement.LocalService;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;

namespace Motorola.CommonCPS.RadioManagement.ASTROSystem
{
	// Token: 0x0200000F RID: 15
	[global::System.ComponentModel.Composition.Export]
	public class SystemDetailsViewModel : global::Motorola.CommonCPS.RadioManagement.Infrastructure.CachedTableViewModelBase<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem>
	{
		// Token: 0x06000035 RID: 53 RVA: 0x00004B5C File Offset: 0x00002D5C
		[global::System.ComponentModel.Composition.ImportingConstructor]
		public SystemDetailsViewModel(global::Microsoft.Practices.Prism.Events.IEventAggregator eventAggregator)
		{
			int a_ = 12;
			base..ctor(eventAggregator, global::Motorola.CommonCPS.RadioManagement.ASTROSystem.ModuleASTROSystem.b("춝\ud99f톡킣쎥얧즫\udaad톯\udbb1\ud8b3억펹\ud9bb즽", a_));
			this.ShowRadioDetailsDialogRequest = new global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.ASTROSystem.RadioJobsViewModel>();
			base.ShowDetailsCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem>(new global::System.Action<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem>(this.a));
			this.EnterEditModeCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(global::Motorola.CommonCPS.RadioManagement.ASTROSystem.SystemDetailsViewModel.<>c.<>9.a));
			this.ChangeRadioIDEntryFormatCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand<string>(new global::System.Action<string>(this.a));
			this.CellFillEndedCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.a));
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000036 RID: 54 RVA: 0x00004C08 File Offset: 0x00002E08
		// (set) Token: 0x06000037 RID: 55 RVA: 0x00004CB8 File Offset: 0x00002EB8
		public global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.ASTROSystem.RadioJobsViewModel> ShowRadioDetailsDialogRequest
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1522693624;
				short num2 = num;
				num = (short)2141025784;
				switch (num2 == num)
				{
				default:
				{
					num = (short)458686464;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)630915073;
				if (num != 0)
				{
				}
				num = (short)1659371520;
				if (num != 0)
				{
				}
				return this.d;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)662085393;
				short num2 = num;
				num = (short)1257021201;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1884749824;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1754398720;
				if (num != 0)
				{
				}
				num = (short)571604993;
				if (num != 0)
				{
				}
				this.d = value;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000038 RID: 56 RVA: 0x00004D68 File Offset: 0x00002F68
		// (set) Token: 0x06000039 RID: 57 RVA: 0x00004E18 File Offset: 0x00003018
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand EnterEditModeCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1501457668;
				short num2 = num;
				num = (short)547908868;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1137901568;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1958412288;
				if (num != 0)
				{
				}
				num = (short)1737490433;
				if (num != 0)
				{
				}
				return this.e;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)450601351;
				short num2 = num;
				num = (short)377201031;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2088632320;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1868627969;
				if (num != 0)
				{
				}
				num = (short)643629056;
				if (num != 0)
				{
				}
				this.e = value;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600003A RID: 58 RVA: 0x00004ECC File Offset: 0x000030CC
		// (set) Token: 0x0600003B RID: 59 RVA: 0x00004F80 File Offset: 0x00003180
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand<string> ChangeRadioIDEntryFormatCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)520228294;
				short num2 = num;
				num = (short)367070662;
				switch (num2 == num)
				{
				default:
				{
					num = (short)40042496;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)148242433;
				if (num != 0)
				{
				}
				num = (short)756285440;
				if (num != 0)
				{
				}
				return this.f;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1387907086;
				short num2 = num;
				num = (short)994822158;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1965031424;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1087045633;
				if (num != 0)
				{
				}
				num = (short)1288830976;
				if (num != 0)
				{
				}
				this.f = value;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600003C RID: 60 RVA: 0x0000502C File Offset: 0x0000322C
		// (set) Token: 0x0600003D RID: 61 RVA: 0x000050DC File Offset: 0x000032DC
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand CellFillEndedCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1838481409;
				if (num != 0)
				{
				}
				num = (short)2108555264;
				short num2 = num;
				num = (short)2136088049;
				short num3 = num;
				num = (short)1680023025;
				switch (num3 == num)
				{
				}
				num = (short)477364224;
				if (num != 0)
				{
				}
				return this.g;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1573276517;
				short num2 = num;
				num = (short)844516197;
				switch (num2 == num)
				{
				default:
				{
					num = (short)69337088;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2054488064;
				if (num != 0)
				{
				}
				num = (short)1518075905;
				if (num != 0)
				{
				}
				this.g = value;
			}
		}

		// Token: 0x0600003E RID: 62 RVA: 0x0000518C File Offset: 0x0000338C
		protected override global::System.ComponentModel.ICollectionView GetItems()
		{
			short num = (short)1930633504;
			short num2 = num;
			num = (short)507453728;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1745944576;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1183514624;
			if (num != 0)
			{
			}
			num = (short)1098448897;
			if (num != 0)
			{
			}
			return global::System.Windows.Data.CollectionViewSource.GetDefaultView(base.ServiceProxy.LocalService.GetRadioInfosBySystem(this.a, this.b));
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00005258 File Offset: 0x00003458
		protected override void SaveItem(object[] parameters)
		{
			short num;
			try
			{
				num = (short)1852876378;
				short num2 = num;
				num = (short)1319282266;
				switch (num2 == num)
				{
				}
				num = (short)1024786432;
				if (num != 0)
				{
				}
				num = (short)677969921;
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
			num = (short)2142699520;
			short num3 = num;
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00005334 File Offset: 0x00003534
		private void a(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem A_0)
		{
			short num;
			try
			{
				num = (short)2002949897;
				short num2 = num;
				num = (short)908957449;
				switch (num2 == num)
				{
				}
				num = (short)1104543744;
				if (num != 0)
				{
				}
				global::Motorola.CommonCPS.RadioManagement.UIModels.RadioDetails radioDetails = base.ServiceProxy.LocalService.GetRadioDetails(A_0.DeviceID.Value, false);
				this.ShowRadioDetailsDialogRequest.Raise(new global::Motorola.CommonCPS.RadioManagement.ASTROSystem.RadioJobsViewModel(base.EventAggregator, base.ServiceProxy.CommandHandler, radioDetails)
				{
					Title = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Title_ViewRadioDetails
				});
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
			}
			num = (short)70057984;
			short num3 = num;
			num = (short)960888833;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00005448 File Offset: 0x00003648
		private void a(string A_0)
		{
			int a_ = 13;
			short num = (short)1154613249;
			if (num != 0)
			{
			}
			this.RadioIDEntryFormat = A_0;
			global::System.Collections.IEnumerator enumerator = base.Items.GetEnumerator();
			try
			{
				num = (short)1096679426;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_105;
					case 1:
						if (!enumerator.MoveNext())
						{
							num = (short)2117795844;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						((global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem)enumerator.Current).InvokeRaisePropertyChanged(global::Motorola.CommonCPS.RadioManagement.ASTROSystem.ModuleASTROSystem.b("춞삠잢첤좦", a_));
						num = (short)524091395;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_7F;
						}
						continue;
					case 4:
						num = (short)1034616832;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_B6:
					num = (short)1833107457;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_7F:
					goto IL_B6;
				}
				IL_105:;
			}
			finally
			{
				switch (0)
				{
				case 0:
					goto IL_126;
				}
				int num2;
				global::System.IDisposable disposable;
				for (;;)
				{
					IL_114:
					switch (num2)
					{
					case 0:
						goto IL_1CB;
					case 1:
						if (disposable != null)
						{
							num = (short)1291321346;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1CD;
					case 2:
						for (;;)
						{
							disposable.Dispose();
							num = (short)1857185839;
							short num3 = num;
							num = (short)1684826159;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								goto IL_19E;
							}
						}
						IL_19E:
						num = (short)1769209856;
						if (num != 0)
						{
						}
						num = (short)573964288;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_126;
				}
				IL_1CB:
				IL_1CD:
				goto EndFinally_5;
				IL_126:
				disposable = (enumerator as global::System.IDisposable);
				num = (short)1940783105;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_114;
				EndFinally_5:;
			}
			num = (short)279576576;
			short num4 = num;
		}

		// Token: 0x06000042 RID: 66 RVA: 0x0000565C File Offset: 0x0000385C
		private void a()
		{
			short num = (short)209356428;
			short num2 = num;
			num = (short)246253196;
			switch (num2 == num)
			{
			}
			num = (short)1256194049;
			if (num != 0)
			{
			}
			num = (short)2111438848;
			if (num != 0)
			{
			}
			num = (short)1907163136;
			short num3 = num;
			global::Motorola.CommonCPS.RadioManagement.LocalService.RadioCache.Instance.Clear();
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000043 RID: 67 RVA: 0x0000570C File Offset: 0x0000390C
		// (set) Token: 0x06000044 RID: 68 RVA: 0x000057B8 File Offset: 0x000039B8
		public string RadioIDEntryFormat
		{
			get
			{
				short num = (short)1778517172;
				short num2 = num;
				num = (short)1912014004;
				switch (num2 == num)
				{
				}
				num = (short)1773928449;
				if (num != 0)
				{
				}
				num = (short)1261699072;
				if (num != 0)
				{
				}
				num = (short)116260864;
				short num3 = num;
				return this.c;
			}
			set
			{
				short num;
				for (;;)
				{
					num = (short)136577025;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_D3;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_31;
							}
							continue;
						case 2:
						{
							this.c = value;
							base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.ASTROSystem.SystemDetailsViewModel)), methodof(global::Motorola.CommonCPS.RadioManagement.ASTROSystem.SystemDetailsViewModel.get_RadioIDEntryFormat())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
							num = (short)1334902784;
							short num3 = num;
							num = (short)1888288768;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						IL_31:
						if (!(this.c != value))
						{
							break;
						}
						num = (short)1706098690;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_FC:
					num = (short)925729051;
					short num4 = num;
					num = (short)352485659;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						goto IL_131;
					}
					IL_D3:
					num = (short)906428417;
					if (num != 0)
					{
					}
					goto IL_FC;
				}
				IL_131:
				num = (short)202440704;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x06000045 RID: 69 RVA: 0x0000590C File Offset: 0x00003B0C
		public override void OnNavigatedTo(global::Microsoft.Practices.Prism.Regions.NavigationContext navigationContext)
		{
			int a_ = 5;
			short num = (short)1697457158;
			short num2 = num;
			num = (short)1600267270;
			switch (num2 == num)
			{
			}
			num = (short)1689190401;
			if (num != 0)
			{
			}
			num = (short)788987904;
			if (num != 0)
			{
			}
			num = (short)661389312;
			short num3 = num;
			base.OnNavigatedTo(navigationContext);
			this.a = navigationContext.Parameters[global::Motorola.CommonCPS.RadioManagement.ASTROSystem.ModuleASTROSystem.b("킖", a_)];
			this.b = navigationContext.Parameters[global::Motorola.CommonCPS.RadioManagement.ASTROSystem.ModuleASTROSystem.b("쒖爵철", a_)];
			this.RadioIDEntryFormat = global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.ASTROMDCEntryFormat.ToUpperInvariant();
			this.Refresh();
			global::Motorola.CommonCPS.RadioManagement.Infrastructure.NavigationHelper.AppendInfoToNavigationPath(navigationContext.Parameters[global::Motorola.CommonCPS.RadioManagement.ASTROSystem.ModuleASTROSystem.b("\ud996", a_)]);
			global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveMainView = global::Motorola.CommonCPS.RadioManagement.ASTROSystem.ModuleASTROSystem.b("쒖爵철삤펦좨슪솬\udcae\udab2킴삶", a_);
			base.EventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.LockSelectedNavigationItemRequestedEvent>().Publish(null);
		}

		// Token: 0x04000014 RID: 20
		private string a;

		// Token: 0x04000015 RID: 21
		private string b;

		// Token: 0x04000016 RID: 22
		private string c;

		// Token: 0x04000017 RID: 23
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.ASTROSystem.RadioJobsViewModel> d;

		// Token: 0x04000018 RID: 24
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand e;

		// Token: 0x04000019 RID: 25
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand<string> f;

		// Token: 0x0400001A RID: 26
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand g;
	}
}
