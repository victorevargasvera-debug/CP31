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
	// Token: 0x02000018 RID: 24
	[global::System.ComponentModel.Composition.Export]
	public class RadioDetailsViewModel : global::Motorola.CommonCPS.RadioManagement.Infrastructure.CachedTableViewModelBase<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem>
	{
		// Token: 0x06000092 RID: 146 RVA: 0x0000A404 File Offset: 0x00008604
		[global::System.ComponentModel.Composition.ImportingConstructor]
		public RadioDetailsViewModel(global::Microsoft.Practices.Prism.Events.IEventAggregator eventAggregator)
		{
			int a_ = 3;
			base..ctor(eventAggregator, global::Motorola.CommonCPS.RadioManagement.ASTROSystem.ModuleASTROSystem.b("요좖쮘漢列캠삤펦좨슪솬\udcae\udab2킴삶", a_));
			this.ShowRadioDetailsDialogRequest = new global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.ASTROSystem.RadioJobsViewModel>();
			base.ShowDetailsCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem>(new global::System.Action<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem>(this.a));
			this.ChangeRadioIDEntryFormatCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand<string>(new global::System.Action<string>(this.a));
			this.EnterEditModeCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(global::Motorola.CommonCPS.RadioManagement.ASTROSystem.RadioDetailsViewModel.<>c.<>9.a));
			this.CellFillEndedCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.a));
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000093 RID: 147 RVA: 0x0000A4B0 File Offset: 0x000086B0
		// (set) Token: 0x06000094 RID: 148 RVA: 0x0000A560 File Offset: 0x00008760
		public global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.ASTROSystem.RadioJobsViewModel> ShowRadioDetailsDialogRequest
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)24975533;
				short num2 = num;
				num = (short)1049172141;
				switch (num2 == num)
				{
				}
				num = (short)2055405568;
				if (num != 0)
				{
				}
				num = (short)1189216257;
				if (num != 0)
				{
				}
				num = (short)1825046528;
				short num3 = num;
				return this.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)509542401;
				if (num != 0)
				{
				}
				num = (short)35748718;
				short num2 = num;
				num = (short)850688878;
				switch (num2 == num)
				{
				}
				num = (short)583008256;
				if (num != 0)
				{
				}
				num = (short)394657792;
				short num3 = num;
				this.c = value;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000095 RID: 149 RVA: 0x0000A610 File Offset: 0x00008810
		// (set) Token: 0x06000096 RID: 150 RVA: 0x0000A6C0 File Offset: 0x000088C0
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand<string> ChangeRadioIDEntryFormatCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1729815664;
				short num2 = num;
				num = (short)1704911984;
				switch (num2 == num)
				{
				}
				num = (short)114229248;
				if (num != 0)
				{
				}
				num = (short)1985413121;
				if (num != 0)
				{
				}
				num = (short)1191903232;
				short num3 = num;
				return this.d;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1808558390;
				short num2 = num;
				num = (short)1802266934;
				switch (num2 == num)
				{
				}
				num = (short)1266286592;
				if (num != 0)
				{
				}
				num = (short)1720188929;
				if (num != 0)
				{
				}
				num = (short)152698880;
				short num3 = num;
				this.d = value;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000097 RID: 151 RVA: 0x0000A770 File Offset: 0x00008970
		// (set) Token: 0x06000098 RID: 152 RVA: 0x0000A820 File Offset: 0x00008A20
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand EnterEditModeCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2043255390;
				short num2 = num;
				num = (short)565549662;
				switch (num2 == num)
				{
				}
				num = (short)1327759360;
				if (num != 0)
				{
				}
				num = (short)1727332353;
				if (num != 0)
				{
				}
				num = (short)2011889664;
				short num3 = num;
				return this.e;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)297386828;
				short num2 = num;
				num = (short)609993548;
				switch (num2 == num)
				{
				}
				num = (short)459866113;
				if (num != 0)
				{
				}
				num = (short)85327872;
				if (num != 0)
				{
				}
				num = (short)270401536;
				short num3 = num;
				this.e = value;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000099 RID: 153 RVA: 0x0000A8D4 File Offset: 0x00008AD4
		// (set) Token: 0x0600009A RID: 154 RVA: 0x0000A984 File Offset: 0x00008B84
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand CellFillEndedCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)394932210;
				short num2 = num;
				num = (short)1441214450;
				switch (num2 == num)
				{
				}
				num = (short)1158676481;
				if (num != 0)
				{
				}
				num = (short)1119354880;
				if (num != 0)
				{
				}
				num = (short)1088552960;
				short num3 = num;
				return this.f;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)231178688;
				short num2 = num;
				num = (short)239501760;
				switch (num2 == num)
				{
				}
				num = (short)11141121;
				if (num != 0)
				{
				}
				num = (short)23461888;
				if (num != 0)
				{
				}
				num = (short)1884356608;
				short num3 = num;
				this.f = value;
			}
		}

		// Token: 0x0600009B RID: 155 RVA: 0x0000AA34 File Offset: 0x00008C34
		protected override global::System.ComponentModel.ICollectionView GetItems()
		{
			short num = (short)1927275652;
			short num2 = num;
			num = (short)1188684932;
			switch (num2 == num)
			{
			}
			num = (short)1390280704;
			if (num != 0)
			{
			}
			num = (short)1235746817;
			if (num != 0)
			{
			}
			num = (short)149553152;
			short num3 = num;
			return global::System.Windows.Data.CollectionViewSource.GetDefaultView(base.ServiceProxy.LocalService.GetSystemInfosbyRadio(this.a));
		}

		// Token: 0x0600009C RID: 156 RVA: 0x0000AAF8 File Offset: 0x00008CF8
		protected override void SaveItem(object[] parameters)
		{
			short num;
			try
			{
				num = (short)1897977124;
				short num2 = num;
				num = (short)725800228;
				switch (num2 == num)
				{
				}
				num = (short)844431360;
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
			num = (short)2146893825;
			if (num != 0)
			{
			}
			num = (short)935854080;
			short num3 = num;
		}

		// Token: 0x0600009D RID: 157 RVA: 0x0000ABD4 File Offset: 0x00008DD4
		private void a(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem A_0)
		{
			short num;
			try
			{
				num = (short)440007261;
				short num2 = num;
				num = (short)625343069;
				switch (num2 == num)
				{
				}
				num = (short)706674688;
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
			num = (short)1836449793;
			if (num != 0)
			{
			}
			num = (short)1502150656;
			short num3 = num;
		}

		// Token: 0x0600009E RID: 158 RVA: 0x0000ACE8 File Offset: 0x00008EE8
		private void a(string A_0)
		{
			int a_ = 13;
			short num = (short)57344000;
			short num2 = num;
			num = (short)442695681;
			if (num != 0)
			{
			}
			this.RadioIDEntryFormat = A_0;
			global::System.Collections.IEnumerator enumerator = base.Items.GetEnumerator();
			goto IL_6F;
			try
			{
				for (;;)
				{
					IL_6F:
					num = (short)1697710083;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							goto IL_17F;
						case 1:
							num = (short)1878589440;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							if (!enumerator.MoveNext())
							{
								num = (short)2082209793;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							((global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem)enumerator.Current).InvokeRaisePropertyChanged(global::Motorola.CommonCPS.RadioManagement.ASTROSystem.ModuleASTROSystem.b("춞삠잢첤좦", a_));
							num = (short)1161428996;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							switch (0)
							{
							case 0:
								goto IL_A8;
							}
							continue;
						}
						IL_DF:
						num = (short)724464833;
						short num4 = num;
						num = (short)482374849;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_6F;
						default:
							num = (short)1217069056;
							if (num != 0)
							{
							}
							num = (short)1537998850;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_A8:
						goto IL_DF;
					}
				}
				IL_17F:;
			}
			finally
			{
				switch (0)
				{
				case 0:
					goto IL_19D;
				}
				int num3;
				global::System.IDisposable disposable;
				for (;;)
				{
					IL_18B:
					switch (num3)
					{
					case 0:
						disposable.Dispose();
						num = (short)1850343425;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_1EC;
					case 2:
						if (disposable != null)
						{
							num = (short)600244224;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1EE;
					}
					goto IL_19D;
				}
				IL_1EC:
				IL_1EE:
				goto EndFinally_5;
				IL_19D:
				disposable = (enumerator as global::System.IDisposable);
				num = (short)1844248578;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_18B;
				EndFinally_5:;
			}
		}

		// Token: 0x0600009F RID: 159 RVA: 0x0000AF00 File Offset: 0x00009100
		private void a()
		{
			short num = (short)809016714;
			short num2 = num;
			num = (short)1768463754;
			switch (num2 == num)
			{
			}
			num = (short)1280442369;
			if (num != 0)
			{
			}
			num = (short)1693908992;
			if (num != 0)
			{
			}
			num = (short)292421632;
			short num3 = num;
			global::Motorola.CommonCPS.RadioManagement.LocalService.RadioCache.Instance.Clear();
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x0000AFB4 File Offset: 0x000091B4
		// (set) Token: 0x060000A1 RID: 161 RVA: 0x0000B064 File Offset: 0x00009264
		public string RadioIDEntryFormat
		{
			get
			{
				short num = (short)325566830;
				short num2 = num;
				num = (short)1956626798;
				switch (num2 == num)
				{
				}
				num = (short)633798656;
				if (num != 0)
				{
				}
				num = (short)731512833;
				if (num != 0)
				{
				}
				num = (short)1050869760;
				short num3 = num;
				return this.b;
			}
			set
			{
				short num = (short)990792964;
				short num2 = num;
				num = (short)456740100;
				int num3;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_D9:
					num = (short)1204486145;
					num3 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)969211904;
					if (num != 0)
					{
					}
					num = (short)1130758144;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
				for (;;)
				{
					switch (num3)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_7A;
						}
						continue;
					case 1:
						goto IL_F1;
					case 2:
						goto IL_9C;
					}
					IL_7A:
					if (!(this.b != value))
					{
						goto IL_F3;
					}
					num = (short)1192361986;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_9C:
				this.b = value;
				base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.ASTROSystem.RadioDetailsViewModel)), methodof(global::Motorola.CommonCPS.RadioManagement.ASTROSystem.RadioDetailsViewModel.get_RadioIDEntryFormat())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
				goto IL_D9;
				IL_F1:
				IL_F3:
				num = (short)1013186560;
				short num4 = num;
				num = (short)2100887553;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x0000B1B8 File Offset: 0x000093B8
		public override void OnNavigatedTo(global::Microsoft.Practices.Prism.Regions.NavigationContext navigationContext)
		{
			int a_ = 14;
			short num = (short)386106049;
			short num2 = num;
			num = (short)1861452481;
			switch (num2 == num)
			{
			}
			num = (short)505020417;
			if (num != 0)
			{
			}
			num = (short)1067646976;
			if (num != 0)
			{
			}
			num = (short)1592262656;
			short num3 = num;
			base.OnNavigatedTo(navigationContext);
			this.a = navigationContext.Parameters[global::Motorola.CommonCPS.RadioManagement.ASTROSystem.ModuleASTROSystem.b("쎡삣쾥잧", a_)];
			this.RadioIDEntryFormat = global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.ASTROMDCEntryFormat.ToUpperInvariant();
			this.Refresh();
			global::Motorola.CommonCPS.RadioManagement.Infrastructure.NavigationHelper.AppendInfoToNavigationPath(navigationContext.Parameters[global::Motorola.CommonCPS.RadioManagement.ASTROSystem.ModuleASTROSystem.b("잡횣쾥즧용\udbad\uddaf킱톳쒵", a_)]);
			global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveMainView = global::Motorola.CommonCPS.RadioManagement.ASTROSystem.ModuleASTROSystem.b("ﶡ장첧쎩쎫햯욱햳\udfb5풷즹ힽꖿ뗁", a_);
			base.EventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.LockSelectedNavigationItemRequestedEvent>().Publish(null);
		}

		// Token: 0x0400003D RID: 61
		private string a;

		// Token: 0x0400003E RID: 62
		private string b;

		// Token: 0x0400003F RID: 63
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.ASTROSystem.RadioJobsViewModel> c;

		// Token: 0x04000040 RID: 64
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand<string> d;

		// Token: 0x04000041 RID: 65
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand e;

		// Token: 0x04000042 RID: 66
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand f;
	}
}
