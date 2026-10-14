using System;
using System.ComponentModel.Composition;
using System.Runtime.CompilerServices;
using System.Windows.Data;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Events;
using Microsoft.Practices.Prism.Interactivity.InteractionRequest;
using Microsoft.Practices.Prism.Regions;
using Motorola.CommonCPS.RadioManagement.Events;
using Motorola.CommonCPS.RadioManagement.Global;
using Motorola.CommonCPS.RadioManagement.Infrastructure;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;

namespace Motorola.CommonCPS.RadioManagement.Template
{
	// Token: 0x0200000A RID: 10
	[global::System.ComponentModel.Composition.Export]
	public class MainViewModel : global::Motorola.CommonCPS.RadioManagement.Infrastructure.TableViewModelBase<global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase>
	{
		// Token: 0x0600003D RID: 61 RVA: 0x00005E3C File Offset: 0x0000403C
		[global::System.ComponentModel.Composition.ImportingConstructor]
		public MainViewModel(global::Microsoft.Practices.Prism.Events.IEventAggregator eventAggregator) : base(eventAggregator)
		{
			this.ShowTemplateLanguagePacksDialogRequest = new global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Template.ShowLanguagePacksViewModel>();
			this.ShowTemplateVAPacksDialogRequest = new global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Template.ShowVAPacksViewModel>();
			this.ShowImportTemplatesDialogRequest = new global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Template.ImportTemplatesViewModel>();
			this.ShowSelectFirmwareDialogRequest = new global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Template.SelectFirmwareViewModel>();
			this.ShowSelectRelatedRadiosDialogRequest = new global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Template.ApplyTemplatetoRelatedRadiosViewModel>();
			this.UpgradeLanguagePackCommnand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.g), new global::System.Func<bool>(this.b));
			base.CommandProxy.PrepareImportTemplatesCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.h), new global::System.Func<bool>(this.d));
			base.CommandProxy.DeleteTemplatesCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.j), new global::System.Func<bool>(this.f));
			base.CommandProxy.EditTemplateCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.i), new global::System.Func<bool>(this.e));
			this.PrepareShowTemplateLanguagePacksDetailInfoCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase>(new global::System.Action<global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase>(this.b));
			this.PrepareShowTemplateVADetailInfoCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase>(new global::System.Action<global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase>(this.a));
			base.EventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ShowTemplateLanguagePacksDialogRequestedEvent>().Subscribe(new global::System.Action<global::Motorola.CommonCPS.RadioManagement.UIModels.ShowTemplateLanguagePacksContext>(this.a));
			base.EventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ShowTemplateVAPacksDialogRequestedEvent>().Subscribe(new global::System.Action<global::Motorola.CommonCPS.RadioManagement.UIModels.ShowTemplateVAPacksContext>(this.a));
			base.EventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ShowImportTemplatesDialogRequestedEvent>().Subscribe(new global::System.Action<global::Motorola.CommonCPS.RadioManagement.UIModels.ImportTemplatesContext>(this.a));
			base.EventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ShowSelectFirmwareDialogRequestedEvent>().Subscribe(new global::System.Action<global::Motorola.CommonCPS.RadioManagement.UIModels.SelectFirmwareContext>(this.a));
			base.EventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ShowApplyTemplatetoRelatedRadiosDialogRequestedEvent>().Subscribe(new global::System.Action<global::Motorola.CommonCPS.RadioManagement.UIModels.ApplyTemplatetoRelatedRadiosContext>(this.a));
			base.EventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.RefreshRequestedEvent>().Subscribe(new global::System.Action<object>(this.a));
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600003E RID: 62 RVA: 0x00006000 File Offset: 0x00004200
		// (set) Token: 0x0600003F RID: 63 RVA: 0x000060B0 File Offset: 0x000042B0
		public global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Template.ShowLanguagePacksViewModel> ShowTemplateLanguagePacksDialogRequest
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2093223746;
				short num2 = num;
				num = (short)1347161922;
				switch (num2 == num)
				{
				}
				num = (short)2038693889;
				if (num != 0)
				{
				}
				num = (short)79298560;
				if (num != 0)
				{
				}
				num = (short)477167616;
				short num3 = num;
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)24049966;
				short num2 = num;
				num = (short)735050030;
				switch (num2 == num)
				{
				}
				num = (short)886964225;
				if (num != 0)
				{
				}
				num = (short)2026831872;
				if (num != 0)
				{
				}
				num = (short)2002714624;
				short num3 = num;
				this.a = value;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000040 RID: 64 RVA: 0x00006160 File Offset: 0x00004360
		// (set) Token: 0x06000041 RID: 65 RVA: 0x0000620C File Offset: 0x0000440C
		public global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Template.ShowVAPacksViewModel> ShowTemplateVAPacksDialogRequest
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)145729925;
				short num2 = num;
				num = (short)1782491525;
				switch (num2 == num)
				{
				}
				num = (short)1044316160;
				if (num != 0)
				{
				}
				num = (short)1920729089;
				if (num != 0)
				{
				}
				num = (short)1864892416;
				short num3 = num;
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1602499992;
				short num2 = num;
				num = (short)2057188760;
				switch (num2 == num)
				{
				}
				num = (short)73269249;
				if (num != 0)
				{
				}
				num = (short)467140608;
				if (num != 0)
				{
				}
				num = (short)614662144;
				short num3 = num;
				this.b = value;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000042 RID: 66 RVA: 0x000062BC File Offset: 0x000044BC
		// (set) Token: 0x06000043 RID: 67 RVA: 0x0000636C File Offset: 0x0000456C
		public global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Template.ImportTemplatesViewModel> ShowImportTemplatesDialogRequest
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1962040444;
				short num2 = num;
				num = (short)1802591356;
				switch (num2 == num)
				{
				}
				num = (short)652804096;
				if (num != 0)
				{
				}
				num = (short)2054684673;
				if (num != 0)
				{
				}
				num = (short)1500971008;
				short num3 = num;
				return this.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1342485102;
				short num2 = num;
				num = (short)1086632558;
				switch (num2 == num)
				{
				}
				num = (short)458424320;
				if (num != 0)
				{
				}
				num = (short)48168961;
				if (num != 0)
				{
				}
				num = (short)1996095488;
				short num3 = num;
				this.c = value;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000044 RID: 68 RVA: 0x00006420 File Offset: 0x00004620
		// (set) Token: 0x06000045 RID: 69 RVA: 0x000064D0 File Offset: 0x000046D0
		public global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Template.SelectFirmwareViewModel> ShowSelectFirmwareDialogRequest
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1752498177;
				if (num != 0)
				{
				}
				num = (short)24280461;
				short num2 = num;
				num = (short)60259725;
				switch (num2 == num)
				{
				}
				num = (short)1437728768;
				if (num != 0)
				{
				}
				num = (short)603455488;
				short num3 = num;
				return this.d;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)2090058940;
				short num2 = num;
				num = (short)1996407996;
				switch (num2 == num)
				{
				}
				num = (short)1910112257;
				if (num != 0)
				{
				}
				num = (short)1833107456;
				if (num != 0)
				{
				}
				num = (short)679542784;
				short num3 = num;
				this.d = value;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000046 RID: 70 RVA: 0x00006580 File Offset: 0x00004780
		// (set) Token: 0x06000047 RID: 71 RVA: 0x00006634 File Offset: 0x00004834
		public global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Template.ApplyTemplatetoRelatedRadiosViewModel> ShowSelectRelatedRadiosDialogRequest
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)784832208;
				short num2 = num;
				num = (short)714708688;
				switch (num2 == num)
				{
				}
				num = (short)35717121;
				if (num != 0)
				{
				}
				num = (short)2023620608;
				if (num != 0)
				{
				}
				num = (short)356909056;
				short num3 = num;
				return this.e;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)545049185;
				short num2 = num;
				num = (short)1349503585;
				switch (num2 == num)
				{
				}
				num = (short)1418395648;
				if (num != 0)
				{
				}
				num = (short)547815425;
				if (num != 0)
				{
				}
				num = (short)1983774720;
				short num3 = num;
				this.e = value;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000048 RID: 72 RVA: 0x000066E4 File Offset: 0x000048E4
		// (set) Token: 0x06000049 RID: 73 RVA: 0x00006794 File Offset: 0x00004994
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand UpgradeLanguagePackCommnand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)765731613;
				short num2 = num;
				num = (short)261366557;
				switch (num2 == num)
				{
				}
				num = (short)1556611073;
				if (num != 0)
				{
				}
				num = (short)1032454144;
				if (num != 0)
				{
				}
				num = (short)1656160256;
				short num3 = num;
				return this.f;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1015676929;
				if (num != 0)
				{
				}
				num = (short)1609247689;
				short num2 = num;
				num = (short)689908681;
				switch (num2 == num)
				{
				}
				num = (short)940965888;
				if (num != 0)
				{
				}
				num = (short)352124928;
				short num3 = num;
				this.f = value;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600004A RID: 74 RVA: 0x00006848 File Offset: 0x00004A48
		// (set) Token: 0x0600004B RID: 75 RVA: 0x000068FC File Offset: 0x00004AFC
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase> PrepareShowTemplateLanguagePacksDetailInfoCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1078661304;
				short num2 = num;
				num = (short)222957752;
				switch (num2 == num)
				{
				}
				num = (short)378404865;
				if (num != 0)
				{
				}
				num = (short)421068800;
				if (num != 0)
				{
				}
				num = (short)22085632;
				short num3 = num;
				return this.g;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)84200523;
				short num2 = num;
				num = (short)1667681355;
				switch (num2 == num)
				{
				}
				num = (short)97583105;
				if (num != 0)
				{
				}
				num = (short)465567744;
				if (num != 0)
				{
				}
				num = (short)142540800;
				short num3 = num;
				this.g = value;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600004C RID: 76 RVA: 0x000069B0 File Offset: 0x00004BB0
		// (set) Token: 0x0600004D RID: 77 RVA: 0x00006A60 File Offset: 0x00004C60
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase> PrepareShowTemplateVADetailInfoCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2044461057;
				if (num != 0)
				{
				}
				num = (short)768999732;
				short num2 = num;
				num = (short)133890356;
				switch (num2 == num)
				{
				}
				num = (short)805634048;
				if (num != 0)
				{
				}
				num = (short)1880621056;
				short num3 = num;
				return this.h;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)607675942;
				short num2 = num;
				num = (short)688612902;
				switch (num2 == num)
				{
				}
				num = (short)7536641;
				if (num != 0)
				{
				}
				num = (short)1499463680;
				if (num != 0)
				{
				}
				num = (short)1657995264;
				short num3 = num;
				this.h = value;
			}
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00006B10 File Offset: 0x00004D10
		private void b(global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase A_0)
		{
			short num;
			try
			{
				num = (short)1629050105;
				short num2 = num;
				num = (short)1364219129;
				switch (num2 == num)
				{
				}
				num = (short)840302592;
				if (num != 0)
				{
				}
				base.ServiceProxy.CommandHandler.ShowTemplateLanguageDetailInfoCommand.Execute(new object[]
				{
					A_0
				});
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
			}
			num = (short)1112801280;
			short num3 = num;
			num = (short)903413761;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00006BF8 File Offset: 0x00004DF8
		private void a(global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase A_0)
		{
			short num;
			try
			{
				num = (short)729390241;
				short num2 = num;
				num = (short)186752161;
				switch (num2 == num)
				{
				}
				num = (short)891486208;
				if (num != 0)
				{
				}
				base.ServiceProxy.CommandHandler.ShowTemplateVADetailInfoCommand.Execute(new object[]
				{
					A_0
				});
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
			}
			num = (short)1236795392;
			short num3 = num;
			num = (short)117637121;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00006CDC File Offset: 0x00004EDC
		private void j()
		{
			short num;
			try
			{
				num = (short)2133166160;
				short num2 = num;
				num = (short)1153796176;
				switch (num2 == num)
				{
				}
				num = (short)1717698561;
				if (num != 0)
				{
				}
				num = (short)251396096;
				if (num != 0)
				{
				}
				base.ServiceProxy.CommandHandler.DeleteTemplatesCommand.Execute(new object[]
				{
					base.SelectedItems
				});
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
			}
			num = (short)2094268416;
			short num3 = num;
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00006DC8 File Offset: 0x00004FC8
		private void i()
		{
			short num;
			try
			{
				num = (short)1620967425;
				if (num != 0)
				{
				}
				num = (short)448177654;
				short num2 = num;
				num = (short)1379116534;
				switch (num2 == num)
				{
				}
				num = (short)661127168;
				if (num != 0)
				{
				}
				base.ServiceProxy.CommandHandler.EditTemplateCommand.Execute(new object[]
				{
					base.SelectedItems
				});
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
			}
			num = (short)140181504;
			short num3 = num;
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00006EB4 File Offset: 0x000050B4
		private void h()
		{
			short num;
			try
			{
				num = (short)698692224;
				short num2 = num;
				num = (short)655045248;
				switch (num2 == num)
				{
				}
				num = (short)89849856;
				if (num != 0)
				{
				}
				num = (short)932118529;
				if (num != 0)
				{
				}
				base.ServiceProxy.CommandHandler.PrepareImportTemplatesCommand.Execute(global::System.Array.Empty<object>());
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
			}
			num = (short)42926080;
			short num3 = num;
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00006F94 File Offset: 0x00005194
		private void g()
		{
			short num;
			try
			{
				num = (short)1418330113;
				if (num != 0)
				{
				}
				num = (short)148388971;
				short num2 = num;
				num = (short)940784747;
				switch (num2 == num)
				{
				}
				num = (short)73400320;
				if (num != 0)
				{
				}
				base.ServiceProxy.CommandHandler.ASTROUpgradeLanguagePackCommand.Execute(new object[]
				{
					base.SelectedItems
				});
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
			}
			num = (short)1083572224;
			short num3 = num;
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00007080 File Offset: 0x00005280
		private bool f()
		{
			short num;
			bool result;
			try
			{
				num = (short)151837376;
				short num2 = num;
				num = (short)2049301184;
				switch (num2 == num)
				{
				}
				num = (short)1460142080;
				if (num != 0)
				{
				}
				result = base.ServiceProxy.CommandHandler.DeleteTemplatesCommand.CanExecute(new object[]
				{
					base.SelectedItems
				});
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
				result = false;
			}
			num = (short)600178688;
			short num3 = num;
			num = (short)1509359617;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x06000055 RID: 85 RVA: 0x0000716C File Offset: 0x0000536C
		private bool e()
		{
			short num;
			bool result;
			try
			{
				num = (short)1169364729;
				short num2 = num;
				num = (short)1705776889;
				switch (num2 == num)
				{
				}
				num = (short)202637312;
				if (num != 0)
				{
				}
				result = base.ServiceProxy.CommandHandler.EditTemplateCommand.CanExecute(new object[]
				{
					base.SelectedItems
				});
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
				result = false;
			}
			num = (short)1238433792;
			short num3 = num;
			num = (short)14024705;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00007258 File Offset: 0x00005458
		private bool d()
		{
			int a_ = 12;
			short num;
			bool result;
			try
			{
				num = (short)2004549635;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)1411710977;
					if (num != 0)
					{
					}
					bool flag;
					switch (num2)
					{
					case 0:
						goto IL_14A;
					case 1:
						IL_98:
						num = (short)469172228;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						flag = false;
						goto IL_E7;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_6A;
						}
						continue;
					case 4:
						flag = base.ServiceProxy.CommandHandler.PrepareImportTemplatesCommand.CanExecute(global::System.Array.Empty<object>());
						goto IL_E7;
					}
					IL_6A:
					if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveMainModule == global::Motorola.CommonCPS.RadioManagement.Template.ShowVAPacksViewModel.b("哿朁椃瘅搇欉砋欍", a_))
					{
						num = (short)1534853121;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)227672066;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_E7:
					result = flag;
					num = (short)1022823021;
					short num3 = num;
					num = (short)1533020781;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_98;
					default:
						num = (short)2137194496;
						if (num != 0)
						{
						}
						num = (short)885391360;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				IL_14A:;
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
				result = false;
			}
			num = (short)1564409856;
			short num4 = num;
			return result;
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00007404 File Offset: 0x00005604
		private bool c()
		{
			short num;
			bool result;
			try
			{
				num = (short)1319872457;
				short num2 = num;
				num = (short)1210820553;
				switch (num2 == num)
				{
				}
				num = (short)333971456;
				if (num != 0)
				{
				}
				result = base.ServiceProxy.CommandHandler.PrepareUpgradeFirmwareCommand.CanExecute(new object[]
				{
					base.SelectedItems
				});
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
				result = false;
			}
			num = (short)1014300673;
			if (num != 0)
			{
			}
			num = (short)1885077504;
			short num3 = num;
			return result;
		}

		// Token: 0x06000058 RID: 88 RVA: 0x000074F0 File Offset: 0x000056F0
		private bool b()
		{
			short num;
			bool result;
			try
			{
				num = (short)90199902;
				short num2 = num;
				num = (short)155408222;
				switch (num2 == num)
				{
				}
				num = (short)228524032;
				if (num != 0)
				{
				}
				result = base.ServiceProxy.CommandHandler.ASTROUpgradeLanguagePackCommand.CanExecute(new object[]
				{
					base.SelectedItems
				});
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
				result = false;
			}
			num = (short)639172609;
			if (num != 0)
			{
			}
			num = (short)831193088;
			short num3 = num;
			return result;
		}

		// Token: 0x06000059 RID: 89 RVA: 0x000075E0 File Offset: 0x000057E0
		protected override void Refresh()
		{
			short num = (short)2144272385;
			if (num != 0)
			{
			}
			num = (short)384106496;
			short num2 = num;
			num = (short)1622496874;
			short num3 = num;
			num = (short)930502250;
			switch (num3 == num)
			{
			}
			num = (short)1824849920;
			if (num != 0)
			{
			}
			this.a();
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00007690 File Offset: 0x00005890
		protected override void SaveItem(object[] parameters)
		{
			short num;
			try
			{
				num = (short)539756090;
				short num2 = num;
				num = (short)851772986;
				switch (num2 == num)
				{
				}
				num = (short)369885184;
				if (num != 0)
				{
				}
				num = (short)779157505;
				if (num != 0)
				{
				}
				base.ServiceProxy.CommandHandler.SaveTemplateCommand.Execute(parameters);
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
				throw;
			}
			num = (short)253886464;
			short num3 = num;
		}

		// Token: 0x0600005B RID: 91 RVA: 0x0000776C File Offset: 0x0000596C
		private void a(object A_0)
		{
			int a_ = 12;
			if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveMainModule != global::Motorola.CommonCPS.RadioManagement.Template.ShowVAPacksViewModel.b("哿朁椃瘅搇欉砋欍", a_))
			{
				short num = (short)59703296;
				short num2 = num;
				num = (short)519379161;
				short num3 = num;
				num = (short)870193369;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)462553088;
					if (num != 0)
					{
					}
					num = (short)537985025;
					if (num != 0)
					{
					}
					return;
				}
			}
			this.a();
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00007844 File Offset: 0x00005A44
		private void a(global::Motorola.CommonCPS.RadioManagement.UIModels.ShowTemplateVAPacksContext A_0)
		{
			short num = (short)1196457747;
			short num2 = num;
			num = (short)1559658259;
			switch (num2 == num)
			{
			default:
			{
				num = (short)801832960;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)911147008;
			if (num != 0)
			{
			}
			num = (short)933232641;
			if (num != 0)
			{
			}
			this.ShowTemplateVAPacksDialogRequest.Raise(new global::Motorola.CommonCPS.RadioManagement.Template.ShowVAPacksViewModel(base.EventAggregator, base.ServiceProxy.CommandHandler, A_0)
			{
				Title = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Title_ShowVADetails
			});
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00007920 File Offset: 0x00005B20
		private void a(global::Motorola.CommonCPS.RadioManagement.UIModels.ShowTemplateLanguagePacksContext A_0)
		{
			short num = (short)39562834;
			short num2 = num;
			num = (short)1285729874;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1614151680;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1077018625;
			if (num != 0)
			{
			}
			num = (short)781647872;
			if (num != 0)
			{
			}
			this.ShowTemplateLanguagePacksDialogRequest.Raise(new global::Motorola.CommonCPS.RadioManagement.Template.ShowLanguagePacksViewModel(base.EventAggregator, base.ServiceProxy.CommandHandler, A_0)
			{
				Title = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Title_ShowLPDetails
			});
		}

		// Token: 0x0600005E RID: 94 RVA: 0x000079F8 File Offset: 0x00005BF8
		private void a(global::Motorola.CommonCPS.RadioManagement.UIModels.ImportTemplatesContext A_0)
		{
			short num = (short)1692621113;
			short num2 = num;
			num = (short)1856330041;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1375666176;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)637075457;
			if (num != 0)
			{
			}
			num = (short)2107047936;
			if (num != 0)
			{
			}
			this.ShowImportTemplatesDialogRequest.Raise(new global::Motorola.CommonCPS.RadioManagement.Template.ImportTemplatesViewModel(base.EventAggregator, base.ServiceProxy.CommandHandler, A_0)
			{
				Title = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Title_ImportTemplates
			});
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00007ACC File Offset: 0x00005CCC
		private void a(global::Motorola.CommonCPS.RadioManagement.UIModels.SelectFirmwareContext A_0)
		{
			int a_ = 19;
			short num = (short)579076098;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					return;
				case 1:
					goto IL_E3;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_3A;
					}
					continue;
				}
				IL_3A:
				num = (short)1880055151;
				short num3 = num;
				num = (short)1184324975;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_E3:
					num = (short)1893138433;
					if (num != 0)
					{
					}
					this.ShowSelectFirmwareDialogRequest.Raise(new global::Motorola.CommonCPS.RadioManagement.Template.SelectFirmwareViewModel(base.EventAggregator, base.ServiceProxy.CommandHandler, A_0)
					{
						Title = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_ContextMenu_Upgrade
					});
					num = (short)431685632;
					num2 = (int)((global::System.IntPtr)num);
					break;
				default:
				{
					num = (short)937230336;
					if (num != 0)
					{
					}
					if (!(global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveMainModule == global::Motorola.CommonCPS.RadioManagement.Template.ShowVAPacksViewModel.b("匆氈昊紌挎瀐朒瀔", a_)))
					{
						return;
					}
					num = (short)1996161024;
					short num4 = num;
					num = (short)1555759105;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
				}
			}
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00007C2C File Offset: 0x00005E2C
		private void a(global::Motorola.CommonCPS.RadioManagement.UIModels.ApplyTemplatetoRelatedRadiosContext A_0)
		{
			int a_ = 19;
			short num = (short)450756610;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					return;
				case 1:
					goto IL_10A;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_3A;
					}
					continue;
				}
				IL_3A:
				num = (short)664354111;
				short num3 = num;
				num = (short)1160133951;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_10A:
					this.ShowSelectRelatedRadiosDialogRequest.Raise(new global::Motorola.CommonCPS.RadioManagement.Template.ApplyTemplatetoRelatedRadiosViewModel(base.EventAggregator, base.ServiceProxy.CommandHandler, A_0)
					{
						Title = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Title_SelectRadios
					});
					num = (short)750321664;
					num2 = (int)((global::System.IntPtr)num);
					break;
				default:
				{
					num = (short)2018705409;
					if (num != 0)
					{
					}
					num = (short)2084438016;
					if (num != 0)
					{
					}
					num = (short)1816985600;
					short num4 = num;
					if (!(global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveMainModule == global::Motorola.CommonCPS.RadioManagement.Template.ShowVAPacksViewModel.b("匆氈昊紌挎瀐朒瀔", a_)))
					{
						return;
					}
					num = (short)2090926081;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
				}
			}
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00007D8C File Offset: 0x00005F8C
		protected override void OnSelectedItemsCollectionChanged()
		{
			short num = (short)1053413937;
			short num2 = num;
			num = (short)874762801;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1036910592;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)492765185;
			if (num != 0)
			{
			}
			num = (short)1304100864;
			if (num != 0)
			{
			}
			base.OnSelectedItemsCollectionChanged();
			this.UpgradeLanguagePackCommnand.RaiseCanExecuteChanged();
			base.CommandProxy.DeleteTemplatesCommand.RaiseCanExecuteChanged();
			base.CommandProxy.EditTemplateCommand.RaiseCanExecuteChanged();
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00007E68 File Offset: 0x00006068
		private void a()
		{
			short num;
			try
			{
				num = (short)1512406820;
				short num2 = num;
				num = (short)1033797412;
				switch (num2 == num)
				{
				}
				num = (short)1076297728;
				if (num != 0)
				{
				}
				base.Items = global::System.Windows.Data.CollectionViewSource.GetDefaultView(base.ServiceProxy.LocalService.GetTemplate());
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
			}
			num = (short)246415361;
			if (num != 0)
			{
			}
			num = (short)812646400;
			short num3 = num;
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00007F4C File Offset: 0x0000614C
		public override void OnNavigatedTo(global::Microsoft.Practices.Prism.Regions.NavigationContext navigationContext)
		{
			short num = (short)1379205123;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_53;
				case 1:
				{
					num = (short)126914912;
					short num3 = num;
					num = (short)320901472;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_53;
					default:
						goto IL_110;
					}
					break;
				}
				case 2:
					if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.IsCancelled)
					{
						num = (short)1953759233;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_12C;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_35;
					}
					continue;
				}
				IL_35:
				if (!global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.IsNotSetup)
				{
					num = (short)481820672;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_12C;
				IL_53:
				num = (short)2083586048;
				short num4 = num;
				num = (short)1528102913;
				if (num != 0)
				{
				}
				num = (short)91750402;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_110:
			num = (short)1599143936;
			if (num != 0)
			{
			}
			return;
			IL_12C:
			base.OnNavigatedTo(navigationContext);
			this.a();
		}

		// Token: 0x04000022 RID: 34
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Template.ShowLanguagePacksViewModel> a;

		// Token: 0x04000023 RID: 35
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Template.ShowVAPacksViewModel> b;

		// Token: 0x04000024 RID: 36
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Template.ImportTemplatesViewModel> c;

		// Token: 0x04000025 RID: 37
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Template.SelectFirmwareViewModel> d;

		// Token: 0x04000026 RID: 38
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Template.ApplyTemplatetoRelatedRadiosViewModel> e;

		// Token: 0x04000027 RID: 39
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand f;

		// Token: 0x04000028 RID: 40
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase> g;

		// Token: 0x04000029 RID: 41
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase> h;
	}
}
