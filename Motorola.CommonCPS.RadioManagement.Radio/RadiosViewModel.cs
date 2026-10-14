using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.Composition;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Data;
using System.Windows.Input;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Events;
using Microsoft.Practices.Prism.Interactivity.InteractionRequest;
using Microsoft.Practices.Prism.Regions;
using Motorola.CommonCPS.RadioManagement.Command;
using Motorola.CommonCPS.RadioManagement.CommonBase.Utility;
using Motorola.CommonCPS.RadioManagement.Events;
using Motorola.CommonCPS.RadioManagement.Global;
using Motorola.CommonCPS.RadioManagement.Infrastructure;
using Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand;
using Motorola.CommonCPS.RadioManagement.InteractionHelper;
using Motorola.CommonCPS.RadioManagement.LocalService;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.RadioManagement.Radio
{
	// Token: 0x02000018 RID: 24
	[global::System.ComponentModel.Composition.Export]
	public class RadiosViewModel : global::Motorola.CommonCPS.RadioManagement.Infrastructure.NavigatedTableViewModelBase<global::Motorola.CommonCPS.RadioManagement.UIModels.Group, global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>
	{
		// Token: 0x06000076 RID: 118 RVA: 0x00009818 File Offset: 0x00007A18
		[global::System.ComponentModel.Composition.ImportingConstructor]
		public RadiosViewModel(global::Microsoft.Practices.Prism.Events.IEventAggregator eventAggregator) : base(eventAggregator)
		{
			this.ShowAddRadioDialogRequest = new global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Radio.AddRadioViewModel>();
			this.ShowModifyCodeplugPasswordDialogRequest = new global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Radio.ModifyCodeplugPasswordViewModel>();
			this.ShowResetRadioPasswordDialogRequest = new global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Radio.ResetRadioPasswordViewModel>();
			this.ShowImportRadiosDialogRequest = new global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Radio.ImportRadiosViewModel>();
			this.ShowLanguagePacksDialogRequest = new global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Radio.ShowLanguagePacksViewModel>();
			this.ShowVAPacksDialogRequest = new global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Radio.ShowVAPacksViewModel>();
			this.ShowMismatchOptionsDialogRequest = new global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Radio.ShowMismatchOptionsViewModel>();
			this.ShowMoveDeviceDialogRequest = new global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Radio.MoveGroupViewModel>();
			this.ShowUpdateRadioDataDialogRequest = new global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Radio.UpdateRadioDataViewModel>();
			this.ShowResetIdentifiersDialogRequest = new global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Radio.ResetIdentifiersViewModel>();
			this.ShowScheduleJobDialogRequest = new global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Radio.ScheduleJobViewModel>();
			this.ShowSelectFirmwareDialogRequest = new global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Radio.SelectFirmwareViewModel>();
			this.ShowSelectRunningRadiosDialogRequest = new global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Radio.SelectRunningRadiosViewModel>();
			this.ShowSelectTemplateDialogRequest = new global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Radio.SelectTemplateViewModel>();
			this.ShowWiFiPasswordValidationDialogRequest = new global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel>();
			this.ShowSelectRadiosDialogRequest = new global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Radio.SelectRadiosViewModel>();
			this.ShowSelectWarningRadiostoScheduleJobDialogRequest = new global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Radio.SelectWarningRadiosViewModel>();
			this.ShowSelectProvisioningPackageDialogRequest = new global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Radio.SelectProvisioningPackageViewModel>();
			this.ShowSelectCodeplugVersionDialogRequest = new global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Radio.SelectCodeplugVersionViewModel>();
			this.ShowCopyPasteWarningContextDialogRequest = new global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Radio.CopyPasteWarningViewModel>();
			this.f = base.ServiceProxy.CommandHandler;
			this.g = base.ServiceProxy.LocalService;
			this.e = new global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand.CompositeCommandBuilderFactory();
			this.UpgradeLanguagePackCommnand = this.a(new global::System.Collections.Generic.List<global::System.Windows.Input.ICommand>
			{
				new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.al), new global::System.Func<bool>(this.i))
			});
			this.PrepareModifyCodeplugPasswordCommand = this.a(new global::System.Collections.Generic.List<global::System.Windows.Input.ICommand>
			{
				new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.aw), new global::System.Func<bool>(this.t))
			});
			this.PrepareResetRadioPasswordCommand = this.a(new global::System.Collections.Generic.List<global::System.Windows.Input.ICommand>
			{
				new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.av), new global::System.Func<bool>(this.s))
			});
			base.CommandProxy.ExportRadioCommand = this.a(new global::System.Collections.Generic.List<global::System.Windows.Input.ICommand>
			{
				new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.az), new global::System.Func<bool>(this.v))
			});
			base.CommandProxy.ShowRadioDetailsCommand = this.a(new global::System.Collections.Generic.List<global::System.Windows.Input.ICommand>
			{
				new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.ah), new global::System.Func<bool>(this.f))
			});
			base.CommandProxy.AddGroupCommand = this.a(new global::System.Collections.Generic.List<global::System.Windows.Input.ICommand>
			{
				new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.a7), new global::System.Func<bool>(this.ad))
			});
			base.CommandProxy.CancelJobCommand = this.a(new global::System.Collections.Generic.List<global::System.Windows.Input.ICommand>
			{
				new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.a6), new global::System.Func<bool>(this.ac))
			});
			base.CommandProxy.CompleteJobCommand = this.a(new global::System.Collections.Generic.List<global::System.Windows.Input.ICommand>
			{
				new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.a5), new global::System.Func<bool>(this.ab))
			});
			base.CommandProxy.DeleteGroupCommand = this.a(new global::System.Collections.Generic.List<global::System.Windows.Input.ICommand>
			{
				new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.a4), new global::System.Func<bool>(this.aa))
			});
			base.CommandProxy.DeleteRadiosCommand = this.a(new global::System.Collections.Generic.List<global::System.Windows.Input.ICommand>
			{
				new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.a3), new global::System.Func<bool>(this.z))
			});
			base.CommandProxy.DiscardChangesCommand = this.a(new global::System.Collections.Generic.List<global::System.Windows.Input.ICommand>
			{
				new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.a2), new global::System.Func<bool>(this.y))
			});
			base.CommandProxy.ExportDVRSCommand = this.a(new global::System.Collections.Generic.List<global::System.Windows.Input.ICommand>
			{
				new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.a0), new global::System.Func<bool>(this.w))
			});
			base.CommandProxy.ExportRadiosGridToFileCommand = (this.aw = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.ay), new global::System.Func<bool>(this.u)));
			base.CommandProxy.MoveDeviceCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand<object[]>(new global::System.Action<object[]>(this.b), new global::System.Func<object[], bool>(this.a));
			base.CommandProxy.PrepareAddRadioCommand = this.a(new global::System.Collections.Generic.List<global::System.Windows.Input.ICommand>
			{
				new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.ax), new global::System.Func<bool>(this.r))
			});
			base.CommandProxy.PrepareImportFileToGridCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.au), new global::System.Func<bool>(this.q));
			base.CommandProxy.PrepareImportRadiosCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.at), new global::System.Func<bool>(this.p));
			base.CommandProxy.PrepareMoveDeviceCommand = this.a(new global::System.Collections.Generic.List<global::System.Windows.Input.ICommand>
			{
				new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.@as), new global::System.Func<bool>(this.e))
			});
			base.CommandProxy.PrepareUpdateRadioDataCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.ak), new global::System.Func<bool>(this.h));
			base.CommandProxy.PrepareRenameGroupCommand = this.a(new global::System.Collections.Generic.List<global::System.Windows.Input.ICommand>
			{
				new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.ar), new global::System.Func<bool>(this.o))
			});
			base.CommandProxy.PrepareResetIdentifiersCommand = this.a(new global::System.Collections.Generic.List<global::System.Windows.Input.ICommand>
			{
				new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.aq), new global::System.Func<bool>(this.n))
			});
			base.CommandProxy.PrepareScheduleJobCommand = this.a(new global::System.Collections.Generic.List<global::System.Windows.Input.ICommand>
			{
				new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.ap), new global::System.Func<bool>(this.m))
			});
			base.CommandProxy.PrepareSelectFirmwareCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.am), new global::System.Func<bool>(this.j));
			base.CommandProxy.PrepareSelectFlashPortCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.aj), new global::System.Func<bool>(this.g));
			this.CopyRadioIdentityCommand = this.a(new global::System.Collections.Generic.List<global::System.Windows.Input.ICommand>
			{
				new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.af), new global::System.Func<bool>(this.c))
			});
			this.EditCodeplugCommand = this.a(new global::System.Collections.Generic.List<global::System.Windows.Input.ICommand>
			{
				new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.a1), new global::System.Func<bool>(this.x))
			});
			this.EnterEditModeCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.ai));
			this.PasteRadioIdentityCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.ae), new global::System.Func<bool>(this.b));
			this.PrepareSelectTemplateCommand = this.a(new global::System.Collections.Generic.List<global::System.Windows.Input.ICommand>
			{
				new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.ao), new global::System.Func<bool>(this.l))
			});
			this.PrepareShowLanguagePacksDetailInfoCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>(new global::System.Action<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>(this.c));
			this.PrepareShowVADetailInfoCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>(new global::System.Action<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>(this.b));
			this.PrepareWiFiPasswordValidationCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.an), new global::System.Func<bool>(this.k));
			this.RefreshGroupCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::Motorola.CommonCPS.RadioManagement.UIModels.Group>(new global::System.Action<global::Motorola.CommonCPS.RadioManagement.UIModels.Group>(this.c), new global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.Group, bool>(this.a));
			this.RenameGroupCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand<string>(new global::System.Action<string>(this.d), new global::System.Func<string, bool>(this.b));
			this.UpdateGroupCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::Motorola.CommonCPS.RadioManagement.UIModels.Group>(new global::System.Action<global::Motorola.CommonCPS.RadioManagement.UIModels.Group>(this.d), new global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.Group, bool>(this.b));
			this.UpgradeCodeplugVersionCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.ag), new global::System.Func<bool>(this.d));
			this.al = new global::Microsoft.Practices.Prism.Commands.DelegateCommand<string>(new global::System.Action<string>(this.c));
			this.MSOtarNavigationCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>(new global::System.Action<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>(this.a));
			eventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.GetGroupCollectionRequestedEvent>().Subscribe(new global::System.Action<global::System.Collections.Generic.List<global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.Group>>>(this.a));
			eventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ShowAddRadioDialogRequestedEvent>().Subscribe(new global::System.Action<global::Motorola.CommonCPS.RadioManagement.UIModels.AddRadioContext>(this.a));
			eventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ShowModifyCodeplugPasswordRequestedEvent>().Subscribe(new global::System.Action<global::Motorola.CommonCPS.RadioManagement.UIModels.ModifyCodeplugPasswordContext>(this.a));
			eventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ShowResetRadioPasswordRequestedEvent>().Subscribe(new global::System.Action<global::Motorola.CommonCPS.RadioManagement.UIModels.ResetRadioPasswordContext>(this.a));
			eventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ShowImportRadiosDialogRequestedEvent>().Subscribe(new global::System.Action<global::Motorola.CommonCPS.RadioManagement.UIModels.ImportRadiosContext>(this.a));
			eventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ShowLanguagePacksDialogRequestedEvent>().Subscribe(new global::System.Action<global::Motorola.CommonCPS.RadioManagement.UIModels.ShowLanguagePacksContext>(this.a));
			eventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ShowVAPacksDialogRequestedEvent>().Subscribe(new global::System.Action<global::Motorola.CommonCPS.RadioManagement.UIModels.ShowVAPacksContext>(this.a));
			eventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ShowMoveDeviceDialogRequestedEvent>().Subscribe(new global::System.Action<global::Motorola.CommonCPS.RadioManagement.UIModels.MoveDeviceContext>(this.a));
			eventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ShowUpdateRadioDataRequsetedEvent>().Subscribe(new global::System.Action<global::Motorola.CommonCPS.RadioManagement.UIModels.UpdateRadioContext>(this.a));
			eventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ShowResetIdentifiersDialogRequestedEvent>().Subscribe(new global::System.Action<global::Motorola.CommonCPS.RadioManagement.UIModels.ResetIdentifiersContext>(this.a));
			eventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ShowScheduleJobDialogRequestedEvent>().Subscribe(new global::System.Action<global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext>(this.a));
			eventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ShowSelectFirmwareDialogRequestedEvent>().Subscribe(new global::System.Action<global::Motorola.CommonCPS.RadioManagement.UIModels.SelectFirmwareContext>(this.a));
			eventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ShowSelectRunningRadiosRequestedEvent>().Subscribe(new global::System.Action<global::Motorola.CommonCPS.RadioManagement.UIModels.SelectRunningRadiosContext>(this.a));
			eventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ShowSelectTemplateDialogRequestedEvent>().Subscribe(new global::System.Action<global::Motorola.CommonCPS.RadioManagement.UIModels.SelectTemplateContext>(this.a));
			eventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ShowWiFiPasswordValidationDialogRequestedEvent>().Subscribe(new global::System.Action<global::Motorola.CommonCPS.RadioManagement.UIModels.WiFiPasswordValidationContext>(this.a));
			eventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ShowSelectRadiosDialogRequestedEvent>().Subscribe(new global::System.Action<global::Motorola.CommonCPS.RadioManagement.UIModels.SelectRadiosContext>(this.a));
			eventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ShowSelectWarningRadiostoScheduleJobsDialogRequestedEvent>().Subscribe(new global::System.Action<global::Motorola.CommonCPS.RadioManagement.UIModels.SelectWarningRadiostoScheduleJobContext>(this.a));
			eventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ShowMismatchOptionsRequestedEvent>().Subscribe(new global::System.Action<global::Motorola.CommonCPS.RadioManagement.UIModels.ShowMismatchOptionsContext>(this.a));
			eventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ShowSelectGeneralPackageRequestedEvent>().Subscribe(new global::System.Action<global::Motorola.CommonCPS.RadioManagement.UIModels.SelectGeneralPackageContext>(this.a));
			eventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ShowCodeplugVersionRequestedEvent>().Subscribe(new global::System.Action<global::Motorola.CommonCPS.RadioManagement.UIModels.SelectCodeplugVersionContext>(this.a));
			eventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.PrintCommandRequestedEvent>().Subscribe(new global::System.Action<object>(this.c));
			eventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.PrintPreviewCommandRequestedEvent>().Subscribe(new global::System.Action<object>(this.b));
			eventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ChangeTechnologyRequestedEvent>().Subscribe(new global::System.Action<string>(this.a));
			eventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ShowCopyPasteWarningDialogRequestedEvent>().Subscribe(new global::System.Action<global::Motorola.CommonCPS.RadioManagement.UIModels.CopyPasteWarningContext>(this.a));
			eventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.RefreshGroupsTree>().Subscribe(new global::System.Action<object>(this.a));
			global::Motorola.CommonCPS.RadioManagement.SharedServices.IServerAccessor instance = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(false, false);
			instance.ConnectionClosedFaulted = (global::Motorola.CommonCPS.RadioManagement.SharedServices.ConnectionClosedFaulted)global::System.Delegate.Combine(instance.ConnectionClosedFaulted, new global::Motorola.CommonCPS.RadioManagement.SharedServices.ConnectionClosedFaulted(this.OnSelectedItemsCollectionChanged));
			global::Motorola.CommonCPS.RadioManagement.SharedServices.IServerAccessor instance2 = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(false, false);
			instance2.ServerConnectedEventHandler = (global::System.EventHandler)global::System.Delegate.Combine(instance2.ServerConnectedEventHandler, new global::System.EventHandler(this.a));
			this.b = global::System.Windows.Visibility.Visible;
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000077 RID: 119 RVA: 0x0000A2BC File Offset: 0x000084BC
		// (set) Token: 0x06000078 RID: 120 RVA: 0x0000A36C File Offset: 0x0000856C
		public global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Radio.AddRadioViewModel> ShowAddRadioDialogRequest
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1481506817;
				if (num != 0)
				{
				}
				num = (short)710082560;
				short num2 = num;
				num = (short)897273982;
				short num3 = num;
				num = (short)1617383550;
				switch (num3 == num)
				{
				}
				num = (short)381812736;
				if (num != 0)
				{
				}
				return this.i;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1940062209;
				if (num != 0)
				{
				}
				num = (short)2065367040;
				short num2 = num;
				num = (short)177590798;
				short num3 = num;
				num = (short)1889915406;
				switch (num3 == num)
				{
				}
				num = (short)606470144;
				if (num != 0)
				{
				}
				this.i = value;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000079 RID: 121 RVA: 0x0000A420 File Offset: 0x00008620
		// (set) Token: 0x0600007A RID: 122 RVA: 0x0000A4D0 File Offset: 0x000086D0
		public global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Radio.ModifyCodeplugPasswordViewModel> ShowModifyCodeplugPasswordDialogRequest
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1183761640;
				short num2 = num;
				num = (short)1846199528;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1699217408;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1872691201;
				if (num != 0)
				{
				}
				num = (short)1670774784;
				if (num != 0)
				{
				}
				return this.j;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)795394409;
				short num2 = num;
				num = (short)1665188201;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1187840000;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1147994113;
				if (num != 0)
				{
				}
				num = (short)2123694080;
				if (num != 0)
				{
				}
				this.j = value;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600007B RID: 123 RVA: 0x0000A580 File Offset: 0x00008780
		// (set) Token: 0x0600007C RID: 124 RVA: 0x0000A630 File Offset: 0x00008830
		public global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Radio.ResetRadioPasswordViewModel> ShowResetRadioPasswordDialogRequest
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)162350562;
				short num2 = num;
				num = (short)2080327138;
				switch (num2 == num)
				{
				default:
				{
					num = (short)483655680;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1117454336;
				if (num != 0)
				{
				}
				num = (short)919404545;
				if (num != 0)
				{
				}
				return this.k;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)889318129;
				short num2 = num;
				num = (short)1139469041;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1575616512;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)269221888;
				if (num != 0)
				{
				}
				num = (short)76611585;
				if (num != 0)
				{
				}
				this.k = value;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600007D RID: 125 RVA: 0x0000A6E0 File Offset: 0x000088E0
		// (set) Token: 0x0600007E RID: 126 RVA: 0x0000A790 File Offset: 0x00008990
		public global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Radio.ImportRadiosViewModel> ShowImportRadiosDialogRequest
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)297643303;
				short num2 = num;
				num = (short)1693887783;
				switch (num2 == num)
				{
				default:
				{
					num = (short)681705472;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1110835201;
				if (num != 0)
				{
				}
				num = (short)19857408;
				if (num != 0)
				{
				}
				return this.l;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)734847114;
				short num2 = num;
				num = (short)1669062794;
				switch (num2 == num)
				{
				default:
				{
					num = (short)750977024;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1159593984;
				if (num != 0)
				{
				}
				num = (short)315424769;
				if (num != 0)
				{
				}
				this.l = value;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600007F RID: 127 RVA: 0x0000A840 File Offset: 0x00008A40
		// (set) Token: 0x06000080 RID: 128 RVA: 0x0000A8F0 File Offset: 0x00008AF0
		public global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Radio.ShowLanguagePacksViewModel> ShowLanguagePacksDialogRequest
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1929445377;
				if (num != 0)
				{
				}
				num = (short)1372389376;
				short num2 = num;
				num = (short)1162368812;
				short num3 = num;
				num = (short)968841004;
				switch (num3 == num)
				{
				}
				num = (short)1118699520;
				if (num != 0)
				{
				}
				return this.m;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)275702380;
				short num2 = num;
				num = (short)1650385516;
				switch (num2 == num)
				{
				}
				num = (short)504889344;
				if (num != 0)
				{
				}
				num = (short)1586102272;
				short num3 = num;
				num = (short)1232994305;
				if (num != 0)
				{
				}
				this.m = value;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000081 RID: 129 RVA: 0x0000A9A0 File Offset: 0x00008BA0
		// (set) Token: 0x06000082 RID: 130 RVA: 0x0000AA50 File Offset: 0x00008C50
		public global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Radio.ShowVAPacksViewModel> ShowVAPacksDialogRequest
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)458013;
				short num2 = num;
				num = (short)1380121885;
				switch (num2 == num)
				{
				}
				num = (short)1187840001;
				if (num != 0)
				{
				}
				num = (short)1161101312;
				short num3 = num;
				num = (short)887357440;
				if (num != 0)
				{
				}
				return this.n;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)407371777;
				if (num != 0)
				{
				}
				num = (short)1106252064;
				short num2 = num;
				num = (short)1155731744;
				switch (num2 == num)
				{
				}
				num = (short)566427648;
				short num3 = num;
				num = (short)300941312;
				if (num != 0)
				{
				}
				this.n = value;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000083 RID: 131 RVA: 0x0000AB00 File Offset: 0x00008D00
		// (set) Token: 0x06000084 RID: 132 RVA: 0x0000ABB0 File Offset: 0x00008DB0
		public global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Radio.ShowCACertificatesPacksViewModel> ShowCACertificatesPacksDialogRequest
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1276852014;
				short num2 = num;
				num = (short)861091630;
				switch (num2 == num)
				{
				}
				num = (short)1394606080;
				if (num != 0)
				{
				}
				num = (short)1473118208;
				short num3 = num;
				num = (short)611581953;
				if (num != 0)
				{
				}
				return this.o;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1804201580;
				short num2 = num;
				num = (short)1552936556;
				switch (num2 == num)
				{
				}
				num = (short)1243480065;
				if (num != 0)
				{
				}
				num = (short)351010816;
				short num3 = num;
				num = (short)888864768;
				if (num != 0)
				{
				}
				this.o = value;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000085 RID: 133 RVA: 0x0000AC60 File Offset: 0x00008E60
		// (set) Token: 0x06000086 RID: 134 RVA: 0x0000AD10 File Offset: 0x00008F10
		public global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Radio.ShowDVRSFilesPacksViewModel> ShowDVRSFilesPacksDialogRequest
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)626670483;
				short num2 = num;
				num = (short)2046966675;
				switch (num2 == num)
				{
				}
				num = (short)272957441;
				if (num != 0)
				{
				}
				num = (short)714211328;
				short num3 = num;
				num = (short)851312640;
				if (num != 0)
				{
				}
				return this.p;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1664712322;
				short num2 = num;
				num = (short)518880898;
				switch (num2 == num)
				{
				}
				num = (short)1575288833;
				if (num != 0)
				{
				}
				num = (short)1323630592;
				short num3 = num;
				num = (short)848035840;
				if (num != 0)
				{
				}
				this.p = value;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000087 RID: 135 RVA: 0x0000ADC0 File Offset: 0x00008FC0
		// (set) Token: 0x06000088 RID: 136 RVA: 0x0000AE70 File Offset: 0x00009070
		public global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Radio.ShowMismatchOptionsViewModel> ShowMismatchOptionsDialogRequest
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)742788236;
				short num2 = num;
				num = (short)463539340;
				switch (num2 == num)
				{
				}
				num = (short)1805451265;
				if (num != 0)
				{
				}
				num = (short)864419840;
				short num3 = num;
				num = (short)1896022016;
				if (num != 0)
				{
				}
				return this.q;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)2129330177;
				if (num != 0)
				{
				}
				num = (short)1808945048;
				short num2 = num;
				num = (short)581717912;
				switch (num2 == num)
				{
				}
				num = (short)849805312;
				short num3 = num;
				num = (short)752812032;
				if (num != 0)
				{
				}
				this.q = value;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000089 RID: 137 RVA: 0x0000AF20 File Offset: 0x00009120
		// (set) Token: 0x0600008A RID: 138 RVA: 0x0000AFD0 File Offset: 0x000091D0
		public global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Radio.MoveGroupViewModel> ShowMoveDeviceDialogRequest
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)11739111;
				short num2 = num;
				num = (short)588193767;
				switch (num2 == num)
				{
				}
				num = (short)682622977;
				if (num != 0)
				{
				}
				num = (short)243335168;
				short num3 = num;
				num = (short)674496512;
				if (num != 0)
				{
				}
				return this.r;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1388546452;
				short num2 = num;
				num = (short)1290111380;
				switch (num2 == num)
				{
				}
				num = (short)117506048;
				if (num != 0)
				{
				}
				num = (short)1450115072;
				short num3 = num;
				num = (short)1606221825;
				if (num != 0)
				{
				}
				this.r = value;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600008B RID: 139 RVA: 0x0000B080 File Offset: 0x00009280
		// (set) Token: 0x0600008C RID: 140 RVA: 0x0000B12C File Offset: 0x0000932C
		public global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Radio.UpdateRadioDataViewModel> ShowUpdateRadioDataDialogRequest
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)673710081;
				if (num != 0)
				{
				}
				num = (short)409390687;
				short num2 = num;
				num = (short)983813727;
				switch (num2 == num)
				{
				}
				num = (short)1845428224;
				short num3 = num;
				num = (short)807862272;
				if (num != 0)
				{
				}
				return this.s;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1418901093;
				short num2 = num;
				num = (short)108377701;
				switch (num2 == num)
				{
				}
				num = (short)217841664;
				if (num != 0)
				{
				}
				num = (short)1925316608;
				short num3 = num;
				num = (short)1506541569;
				if (num != 0)
				{
				}
				this.s = value;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600008D RID: 141 RVA: 0x0000B1DC File Offset: 0x000093DC
		// (set) Token: 0x0600008E RID: 142 RVA: 0x0000B28C File Offset: 0x0000948C
		public global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Radio.ModifyCodeplugPasswordViewModel> ShowAddModifyRadioPasswordDialogRequest
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1648800940;
				short num2 = num;
				num = (short)1763554476;
				switch (num2 == num)
				{
				}
				num = (short)1209335809;
				if (num != 0)
				{
				}
				num = (short)1692794880;
				short num3 = num;
				num = (short)864485376;
				if (num != 0)
				{
				}
				return this.t;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)197595920;
				short num2 = num;
				num = (short)289018640;
				switch (num2 == num)
				{
				}
				num = (short)1439956993;
				if (num != 0)
				{
				}
				num = (short)636223488;
				short num3 = num;
				num = (short)83361792;
				if (num != 0)
				{
				}
				this.t = value;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600008F RID: 143 RVA: 0x0000B33C File Offset: 0x0000953C
		// (set) Token: 0x06000090 RID: 144 RVA: 0x0000B3EC File Offset: 0x000095EC
		public global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Radio.ResetIdentifiersViewModel> ShowResetIdentifiersDialogRequest
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)701562881;
				if (num != 0)
				{
				}
				num = (short)1525176206;
				short num2 = num;
				num = (short)257841038;
				switch (num2 == num)
				{
				}
				num = (short)1048510464;
				short num3 = num;
				num = (short)1036779520;
				if (num != 0)
				{
				}
				return this.u;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1654811035;
				short num2 = num;
				num = (short)308111771;
				switch (num2 == num)
				{
				}
				num = (short)1087242241;
				if (num != 0)
				{
				}
				num = (short)1147928576;
				short num3 = num;
				num = (short)905773056;
				if (num != 0)
				{
				}
				this.u = value;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000091 RID: 145 RVA: 0x0000B4A0 File Offset: 0x000096A0
		// (set) Token: 0x06000092 RID: 146 RVA: 0x0000B550 File Offset: 0x00009750
		public global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Radio.ScheduleJobViewModel> ShowScheduleJobDialogRequest
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)379691214;
				short num2 = num;
				num = (short)1085579470;
				switch (num2 == num)
				{
				}
				num = (short)1180827649;
				if (num != 0)
				{
				}
				num = (short)1665138688;
				short num3 = num;
				num = (short)14811136;
				if (num != 0)
				{
				}
				return this.v;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)964558849;
				if (num != 0)
				{
				}
				num = (short)802880051;
				short num2 = num;
				num = (short)1852832307;
				switch (num2 == num)
				{
				}
				num = (short)531759104;
				short num3 = num;
				num = (short)1881604096;
				if (num != 0)
				{
				}
				this.v = value;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000093 RID: 147 RVA: 0x0000B600 File Offset: 0x00009800
		// (set) Token: 0x06000094 RID: 148 RVA: 0x0000B6B0 File Offset: 0x000098B0
		public global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Radio.SelectFirmwareViewModel> ShowSelectFirmwareDialogRequest
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)918119785;
				short num2 = num;
				num = (short)790717801;
				switch (num2 == num)
				{
				}
				num = (short)1839071233;
				if (num != 0)
				{
				}
				num = (short)383123456;
				short num3 = num;
				num = (short)373358592;
				if (num != 0)
				{
				}
				return this.w;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1369159249;
				short num2 = num;
				num = (short)2036971089;
				switch (num2 == num)
				{
				}
				num = (short)956432384;
				if (num != 0)
				{
				}
				num = (short)711917568;
				short num3 = num;
				num = (short)786433;
				if (num != 0)
				{
				}
				this.w = value;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000095 RID: 149 RVA: 0x0000B764 File Offset: 0x00009964
		// (set) Token: 0x06000096 RID: 150 RVA: 0x0000B810 File Offset: 0x00009A10
		public global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Radio.SelectRunningRadiosViewModel> ShowSelectRunningRadiosDialogRequest
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)13319336;
				short num2 = num;
				num = (short)1553218728;
				switch (num2 == num)
				{
				}
				num = (short)791937025;
				if (num != 0)
				{
				}
				num = (short)1782775808;
				short num3 = num;
				num = (short)2100690944;
				if (num != 0)
				{
				}
				return this.x;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)618476420;
				short num2 = num;
				num = (short)1963864964;
				switch (num2 == num)
				{
				}
				num = (short)1066991617;
				if (num != 0)
				{
				}
				num = (short)2137260032;
				short num3 = num;
				num = (short)977731584;
				if (num != 0)
				{
				}
				this.x = value;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000097 RID: 151 RVA: 0x0000B8C0 File Offset: 0x00009AC0
		// (set) Token: 0x06000098 RID: 152 RVA: 0x0000B974 File Offset: 0x00009B74
		public global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Radio.SelectTemplateViewModel> ShowSelectTemplateDialogRequest
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1265826722;
				short num2 = num;
				num = (short)1523448738;
				switch (num2 == num)
				{
				}
				num = (short)191692800;
				if (num != 0)
				{
				}
				num = (short)925106176;
				short num3 = num;
				num = (short)981663745;
				if (num != 0)
				{
				}
				return this.y;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1589011158;
				short num2 = num;
				num = (short)1528849110;
				switch (num2 == num)
				{
				}
				num = (short)1310851073;
				if (num != 0)
				{
				}
				num = (short)758382592;
				short num3 = num;
				num = (short)1798242304;
				if (num != 0)
				{
				}
				this.y = value;
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000099 RID: 153 RVA: 0x0000BA24 File Offset: 0x00009C24
		// (set) Token: 0x0600009A RID: 154 RVA: 0x0000BAD4 File Offset: 0x00009CD4
		public global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel> ShowWiFiPasswordValidationDialogRequest
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)7267384;
				short num2 = num;
				num = (short)568910904;
				switch (num2 == num)
				{
				}
				num = (short)1345388545;
				if (num != 0)
				{
				}
				num = (short)182779904;
				short num3 = num;
				num = (short)1601503232;
				if (num != 0)
				{
				}
				return this.z;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1224330814;
				short num2 = num;
				num = (short)303812158;
				switch (num2 == num)
				{
				}
				num = (short)1567752193;
				if (num != 0)
				{
				}
				num = (short)25559040;
				short num3 = num;
				num = (short)104792064;
				if (num != 0)
				{
				}
				this.z = value;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x0600009B RID: 155 RVA: 0x0000BB84 File Offset: 0x00009D84
		// (set) Token: 0x0600009C RID: 156 RVA: 0x0000BC30 File Offset: 0x00009E30
		public global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Radio.SelectRadiosViewModel> ShowSelectRadiosDialogRequest
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1607625522;
				short num2 = num;
				num = (short)1956604722;
				switch (num2 == num)
				{
				}
				num = (short)8716289;
				if (num != 0)
				{
				}
				num = (short)1703739392;
				short num3 = num;
				num = (short)875692032;
				if (num != 0)
				{
				}
				return this.aa;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1428575914;
				short num2 = num;
				num = (short)1089558186;
				switch (num2 == num)
				{
				}
				num = (short)1880489984;
				if (num != 0)
				{
				}
				num = (short)407437312;
				short num3 = num;
				num = (short)261554177;
				if (num != 0)
				{
				}
				this.aa = value;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x0600009D RID: 157 RVA: 0x0000BCE0 File Offset: 0x00009EE0
		// (set) Token: 0x0600009E RID: 158 RVA: 0x0000BD90 File Offset: 0x00009F90
		public global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Radio.SelectWarningRadiosViewModel> ShowSelectWarningRadiostoScheduleJobDialogRequest
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1795539700;
				short num2 = num;
				num = (short)1168753396;
				switch (num2 == num)
				{
				}
				num = (short)1755250689;
				if (num != 0)
				{
				}
				num = (short)1295777792;
				short num3 = num;
				num = (short)2006384640;
				if (num != 0)
				{
				}
				return this.ab;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1411865241;
				short num2 = num;
				num = (short)869554841;
				switch (num2 == num)
				{
				}
				num = (short)1554186241;
				if (num != 0)
				{
				}
				num = (short)525467648;
				short num3 = num;
				num = (short)853409792;
				if (num != 0)
				{
				}
				this.ab = value;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x0600009F RID: 159 RVA: 0x0000BE44 File Offset: 0x0000A044
		// (set) Token: 0x060000A0 RID: 160 RVA: 0x0000BEF4 File Offset: 0x0000A0F4
		public global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Radio.SelectProvisioningPackageViewModel> ShowSelectProvisioningPackageDialogRequest
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1001334424;
				short num2 = num;
				num = (short)1566254744;
				switch (num2 == num)
				{
				}
				num = (short)1160773632;
				if (num != 0)
				{
				}
				num = (short)1931345920;
				short num3 = num;
				num = (short)1248591873;
				if (num != 0)
				{
				}
				return this.ac;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)738145827;
				short num2 = num;
				num = (short)1196766755;
				switch (num2 == num)
				{
				}
				num = (short)362217472;
				if (num != 0)
				{
				}
				num = (short)789446656;
				short num3 = num;
				num = (short)1677656065;
				if (num != 0)
				{
				}
				this.ac = value;
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000A1 RID: 161 RVA: 0x0000BFA8 File Offset: 0x0000A1A8
		// (set) Token: 0x060000A2 RID: 162 RVA: 0x0000C058 File Offset: 0x0000A258
		public global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Radio.SelectCodeplugVersionViewModel> ShowSelectCodeplugVersionDialogRequest
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)743202524;
				short num2 = num;
				num = (short)1939365596;
				switch (num2 == num)
				{
				}
				num = (short)1103495169;
				if (num != 0)
				{
				}
				num = (short)2056650752;
				short num3 = num;
				num = (short)2071330816;
				if (num != 0)
				{
				}
				return this.ad;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)171208470;
				short num2 = num;
				num = (short)328232726;
				switch (num2 == num)
				{
				}
				num = (short)1147338752;
				if (num != 0)
				{
				}
				num = (short)878575616;
				short num3 = num;
				num = (short)920780801;
				if (num != 0)
				{
				}
				this.ad = value;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000A3 RID: 163 RVA: 0x0000C108 File Offset: 0x0000A308
		// (set) Token: 0x060000A4 RID: 164 RVA: 0x0000C1BC File Offset: 0x0000A3BC
		public global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Radio.CopyPasteWarningViewModel> ShowCopyPasteWarningContextDialogRequest
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)676889839;
				short num2 = num;
				num = (short)874480879;
				switch (num2 == num)
				{
				}
				num = (short)927137793;
				if (num != 0)
				{
				}
				num = (short)1800732672;
				short num3 = num;
				num = (short)850067456;
				if (num != 0)
				{
				}
				return this.ae;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)604644209;
				short num2 = num;
				num = (short)1003692913;
				switch (num2 == num)
				{
				}
				num = (short)2138570753;
				if (num != 0)
				{
				}
				num = (short)1254096896;
				short num3 = num;
				num = (short)1156055040;
				if (num != 0)
				{
				}
				this.ae = value;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000A5 RID: 165 RVA: 0x0000C270 File Offset: 0x0000A470
		// (set) Token: 0x060000A6 RID: 166 RVA: 0x0000C324 File Offset: 0x0000A524
		public global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.Group> Groups
		{
			get
			{
				short num = (short)1373503489;
				if (num != 0)
				{
				}
				num = (short)688735464;
				short num2 = num;
				num = (short)1116751080;
				switch (num2 == num)
				{
				}
				num = (short)260440064;
				short num3 = num;
				num = (short)1342373888;
				if (num != 0)
				{
				}
				return this.a;
			}
			private set
			{
				short num = (short)2051801089;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						for (;;)
						{
							this.a = value;
							base.RaisePropertyChanged<global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.Group>>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.Group>>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.Radio.RadiosViewModel)), methodof(global::Motorola.CommonCPS.RadioManagement.Radio.RadiosViewModel.get_Groups())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
							num = (short)1813927754;
							short num3 = num;
							num = (short)488658762;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								goto IL_C4;
							}
						}
						IL_C4:
						num = (short)823525377;
						if (num != 0)
						{
						}
						num = (short)1522925568;
						short num4 = num;
						num = (short)856424448;
						if (num != 0)
						{
						}
						num = (short)589430786;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						switch (0)
						{
						case 0:
							goto IL_32;
						}
						continue;
					case 2:
						return;
					}
					IL_32:
					if (this.a == value)
					{
						break;
					}
					num = (short)1865416704;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000A7 RID: 167 RVA: 0x0000C478 File Offset: 0x0000A678
		// (set) Token: 0x060000A8 RID: 168 RVA: 0x0000C524 File Offset: 0x0000A724
		public global::System.Windows.Visibility APXVisibility
		{
			get
			{
				short num = (short)341958005;
				short num2 = num;
				num = (short)2043665781;
				switch (num2 == num)
				{
				}
				num = (short)105316353;
				if (num != 0)
				{
				}
				num = (short)2068054016;
				short num3 = num;
				num = (short)1885077504;
				if (num != 0)
				{
				}
				return this.b;
			}
			set
			{
				short num = (short)1597243393;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						for (;;)
						{
							this.b = value;
							base.RaisePropertyChanged<global::System.Windows.Visibility>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::System.Windows.Visibility>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.Radio.RadiosViewModel)), methodof(global::Motorola.CommonCPS.RadioManagement.Radio.RadiosViewModel.get_APXVisibility())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
							num = (short)2018167672;
							short num3 = num;
							num = (short)1152306040;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								goto IL_C5;
							}
						}
						IL_C5:
						num = (short)892141569;
						if (num != 0)
						{
						}
						num = (short)1501429760;
						short num4 = num;
						num = (short)209518592;
						if (num != 0)
						{
						}
						num = (short)865927170;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						switch (0)
						{
						case 0:
							goto IL_31;
						}
						continue;
					case 2:
						return;
					}
					IL_31:
					if (this.b == value)
					{
						break;
					}
					num = (short)1817903104;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000A9 RID: 169 RVA: 0x0000C678 File Offset: 0x0000A878
		// (set) Token: 0x060000AA RID: 170 RVA: 0x0000C728 File Offset: 0x0000A928
		public global::System.Windows.Visibility PCRVisibility
		{
			get
			{
				short num = (short)1231664317;
				short num2 = num;
				num = (short)429831357;
				switch (num2 == num)
				{
				}
				num = (short)1733230593;
				if (num != 0)
				{
				}
				num = (short)569507840;
				short num3 = num;
				num = (short)820379648;
				if (num != 0)
				{
				}
				return this.c;
			}
			set
			{
				short num = (short)975437825;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						for (;;)
						{
							this.c = value;
							base.RaisePropertyChanged<global::System.Windows.Visibility>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::System.Windows.Visibility>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.Radio.RadiosViewModel)), methodof(global::Motorola.CommonCPS.RadioManagement.Radio.RadiosViewModel.get_PCRVisibility())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
							num = (short)1384580125;
							short num3 = num;
							num = (short)357303325;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								goto IL_E9;
							}
						}
						IL_E9:
						num = (short)127467520;
						short num4 = num;
						num = (short)796721152;
						if (num != 0)
						{
						}
						num = (short)973012994;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						switch (0)
						{
						case 0:
							goto IL_31;
						}
						continue;
					case 2:
						return;
					}
					IL_31:
					num = (short)806813697;
					if (num != 0)
					{
					}
					if (this.c == value)
					{
						break;
					}
					num = (short)1743126528;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000AB RID: 171 RVA: 0x0000C878 File Offset: 0x0000AA78
		// (set) Token: 0x060000AC RID: 172 RVA: 0x0000C924 File Offset: 0x0000AB24
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand EditCodeplugCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)486506723;
				short num2 = num;
				num = (short)1900576995;
				switch (num2 == num)
				{
				}
				num = (short)735117313;
				if (num != 0)
				{
				}
				num = (short)517865472;
				short num3 = num;
				num = (short)268697600;
				if (num != 0)
				{
				}
				return this.af;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1531949488;
				short num2 = num;
				num = (short)1180283312;
				switch (num2 == num)
				{
				}
				num = (short)1500446720;
				if (num != 0)
				{
				}
				num = (short)996474880;
				short num3 = num;
				num = (short)1064501249;
				if (num != 0)
				{
				}
				this.af = value;
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000AD RID: 173 RVA: 0x0000C9D4 File Offset: 0x0000ABD4
		// (set) Token: 0x060000AE RID: 174 RVA: 0x0000CA84 File Offset: 0x0000AC84
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand PrepareSelectTemplateCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)942368415;
				short num2 = num;
				num = (short)229402271;
				switch (num2 == num)
				{
				}
				num = (short)413204481;
				if (num != 0)
				{
				}
				num = (short)1687683072;
				short num3 = num;
				num = (short)480575488;
				if (num != 0)
				{
				}
				return this.ag;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1205207041;
				if (num != 0)
				{
				}
				num = (short)1900321304;
				short num2 = num;
				num = (short)743741976;
				switch (num2 == num)
				{
				}
				num = (short)1057947648;
				short num3 = num;
				num = (short)601948160;
				if (num != 0)
				{
				}
				this.ag = value;
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000AF RID: 175 RVA: 0x0000CB38 File Offset: 0x0000AD38
		// (set) Token: 0x060000B0 RID: 176 RVA: 0x0000CBE8 File Offset: 0x0000ADE8
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand PrepareWiFiPasswordValidationCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2086083938;
				short num2 = num;
				num = (short)1020075362;
				switch (num2 == num)
				{
				}
				num = (short)304480257;
				if (num != 0)
				{
				}
				num = (short)979632128;
				short num3 = num;
				num = (short)622788608;
				if (num != 0)
				{
				}
				return this.ah;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)873050583;
				short num2 = num;
				num = (short)1101050327;
				switch (num2 == num)
				{
				}
				num = (short)834076672;
				if (num != 0)
				{
				}
				num = (short)898498560;
				short num3 = num;
				num = (short)1318649857;
				if (num != 0)
				{
				}
				this.ah = value;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000B1 RID: 177 RVA: 0x0000CC9C File Offset: 0x0000AE9C
		// (set) Token: 0x060000B2 RID: 178 RVA: 0x0000CD4C File Offset: 0x0000AF4C
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> PrepareShowLanguagePacksDetailInfoCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1789487579;
				short num2 = num;
				num = (short)2082105819;
				switch (num2 == num)
				{
				}
				num = (short)1949499393;
				if (num != 0)
				{
				}
				num = (short)1194459136;
				if (num != 0)
				{
				}
				num = (short)272302080;
				short num3 = num;
				return this.ai;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1373101126;
				short num2 = num;
				num = (short)1784732742;
				switch (num2 == num)
				{
				}
				num = (short)94830593;
				if (num != 0)
				{
				}
				num = (short)1435303936;
				if (num != 0)
				{
				}
				num = (short)1109327872;
				short num3 = num;
				this.ai = value;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000B3 RID: 179 RVA: 0x0000CDFC File Offset: 0x0000AFFC
		// (set) Token: 0x060000B4 RID: 180 RVA: 0x0000CEA8 File Offset: 0x0000B0A8
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> PrepareShowVADetailInfoCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)93014563;
				short num2 = num;
				num = (short)1885227555;
				switch (num2 == num)
				{
				}
				num = (short)434044929;
				if (num != 0)
				{
				}
				num = (short)499056640;
				if (num != 0)
				{
				}
				num = (short)139722752;
				short num3 = num;
				return this.aj;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)570077939;
				short num2 = num;
				num = (short)528790259;
				switch (num2 == num)
				{
				}
				num = (short)971898881;
				if (num != 0)
				{
				}
				num = (short)1518993408;
				if (num != 0)
				{
				}
				num = (short)519634944;
				short num3 = num;
				this.aj = value;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000B5 RID: 181 RVA: 0x0000CF58 File Offset: 0x0000B158
		// (set) Token: 0x060000B6 RID: 182 RVA: 0x0000D004 File Offset: 0x0000B204
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> PrepareShowPCRDeviceCertificateDetailInfoCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)672168737;
				short num2 = num;
				num = (short)1691188001;
				switch (num2 == num)
				{
				}
				num = (short)588382209;
				if (num != 0)
				{
				}
				num = (short)1203699712;
				if (num != 0)
				{
				}
				num = (short)665911296;
				short num3 = num;
				return this.ak;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1597808859;
				short num2 = num;
				num = (short)1152491739;
				switch (num2 == num)
				{
				}
				num = (short)638189569;
				if (num != 0)
				{
				}
				num = (short)1943863296;
				if (num != 0)
				{
				}
				num = (short)1697579008;
				short num3 = num;
				this.ak = value;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000B7 RID: 183 RVA: 0x0000D0B4 File Offset: 0x0000B2B4
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand<string> ChangeVRIDEntryFormatCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1221502403;
				short num2 = num;
				num = (short)19310019;
				switch (num2 == num)
				{
				}
				num = (short)1929641985;
				if (num != 0)
				{
				}
				num = (short)552140800;
				if (num != 0)
				{
				}
				num = (short)1619787776;
				short num3 = num;
				return this.al;
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000B8 RID: 184 RVA: 0x0000D164 File Offset: 0x0000B364
		// (set) Token: 0x060000B9 RID: 185 RVA: 0x0000D214 File Offset: 0x0000B414
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand<string> RenameGroupCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1333905816;
				short num2 = num;
				num = (short)115919256;
				switch (num2 == num)
				{
				}
				num = (short)1117716480;
				if (num != 0)
				{
				}
				num = (short)777715713;
				if (num != 0)
				{
				}
				num = (short)1868955648;
				short num3 = num;
				return this.am;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1444872193;
				if (num != 0)
				{
				}
				num = (short)447288702;
				short num2 = num;
				num = (short)1506809214;
				switch (num2 == num)
				{
				}
				num = (short)110034944;
				if (num != 0)
				{
				}
				num = (short)501022720;
				short num3 = num;
				this.am = value;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000BA RID: 186 RVA: 0x0000D2C0 File Offset: 0x0000B4C0
		// (set) Token: 0x060000BB RID: 187 RVA: 0x0000D370 File Offset: 0x0000B570
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::Motorola.CommonCPS.RadioManagement.UIModels.Group> UpdateGroupCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1574556759;
				short num2 = num;
				num = (short)1722471511;
				switch (num2 == num)
				{
				}
				num = (short)527433729;
				if (num != 0)
				{
				}
				num = (short)276037632;
				if (num != 0)
				{
				}
				num = (short)1892024320;
				short num3 = num;
				return this.an;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)952303617;
				if (num != 0)
				{
				}
				num = (short)123537972;
				short num2 = num;
				num = (short)1104874036;
				switch (num2 == num)
				{
				}
				num = (short)1071054848;
				if (num != 0)
				{
				}
				num = (short)456785920;
				short num3 = num;
				this.an = value;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000BC RID: 188 RVA: 0x0000D41C File Offset: 0x0000B61C
		// (set) Token: 0x060000BD RID: 189 RVA: 0x0000D4CC File Offset: 0x0000B6CC
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::Motorola.CommonCPS.RadioManagement.UIModels.Group> RefreshGroupCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)576875860;
				short num2 = num;
				num = (short)524250452;
				switch (num2 == num)
				{
				}
				num = (short)2114256896;
				if (num != 0)
				{
				}
				num = (short)698417153;
				if (num != 0)
				{
				}
				num = (short)623312896;
				short num3 = num;
				return this.ao;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)531501904;
				short num2 = num;
				num = (short)1801917264;
				switch (num2 == num)
				{
				}
				num = (short)983433216;
				if (num != 0)
				{
				}
				num = (short)174063617;
				if (num != 0)
				{
				}
				num = (short)204800000;
				short num3 = num;
				this.ao = value;
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000BE RID: 190 RVA: 0x0000D57C File Offset: 0x0000B77C
		// (set) Token: 0x060000BF RID: 191 RVA: 0x0000D628 File Offset: 0x0000B828
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand EnterEditModeCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)29865441;
				short num2 = num;
				num = (short)1704113633;
				switch (num2 == num)
				{
				}
				num = (short)232259585;
				if (num != 0)
				{
				}
				num = (short)521797632;
				if (num != 0)
				{
				}
				num = (short)746323968;
				short num3 = num;
				return this.ap;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)626822308;
				short num2 = num;
				num = (short)116821156;
				switch (num2 == num)
				{
				}
				num = (short)53739520;
				if (num != 0)
				{
				}
				num = (short)94502913;
				if (num != 0)
				{
				}
				num = (short)339476480;
				short num3 = num;
				this.ap = value;
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000C0 RID: 192 RVA: 0x0000D6D8 File Offset: 0x0000B8D8
		// (set) Token: 0x060000C1 RID: 193 RVA: 0x0000D788 File Offset: 0x0000B988
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand UpgradeCodeplugVersionCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)178701645;
				short num2 = num;
				num = (short)1801635149;
				switch (num2 == num)
				{
				}
				num = (short)388694017;
				if (num != 0)
				{
				}
				num = (short)110166016;
				if (num != 0)
				{
				}
				num = (short)1310785536;
				short num3 = num;
				return this.aq;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)98525948;
				short num2 = num;
				num = (short)581198588;
				switch (num2 == num)
				{
				}
				num = (short)142278656;
				if (num != 0)
				{
				}
				num = (short)500695041;
				if (num != 0)
				{
				}
				num = (short)1838350336;
				short num3 = num;
				this.aq = value;
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000C2 RID: 194 RVA: 0x0000D838 File Offset: 0x0000BA38
		// (set) Token: 0x060000C3 RID: 195 RVA: 0x0000D8E8 File Offset: 0x0000BAE8
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand UpgradeLanguagePackCommnand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1215692801;
				if (num != 0)
				{
				}
				num = (short)1838192699;
				short num2 = num;
				num = (short)287742011;
				switch (num2 == num)
				{
				}
				num = (short)266665984;
				if (num != 0)
				{
				}
				num = (short)667353088;
				short num3 = num;
				return this.ar;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)766138249;
				short num2 = num;
				num = (short)1816680329;
				switch (num2 == num)
				{
				}
				num = (short)1568407553;
				if (num != 0)
				{
				}
				num = (short)819789824;
				if (num != 0)
				{
				}
				num = (short)1902641152;
				short num3 = num;
				this.ar = value;
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000C4 RID: 196 RVA: 0x0000D998 File Offset: 0x0000BB98
		// (set) Token: 0x060000C5 RID: 197 RVA: 0x0000DA48 File Offset: 0x0000BC48
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand PrepareModifyCodeplugPasswordCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1343178133;
				short num2 = num;
				num = (short)1512654229;
				switch (num2 == num)
				{
				}
				num = (short)1275592705;
				if (num != 0)
				{
				}
				num = (short)1665794048;
				if (num != 0)
				{
				}
				num = (short)836567040;
				short num3 = num;
				return this.@as;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)669355553;
				short num2 = num;
				num = (short)1240567329;
				switch (num2 == num)
				{
				}
				num = (short)355532800;
				if (num != 0)
				{
				}
				num = (short)1145962497;
				if (num != 0)
				{
				}
				num = (short)293928960;
				short num3 = num;
				this.@as = value;
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000C6 RID: 198 RVA: 0x0000DAFC File Offset: 0x0000BCFC
		// (set) Token: 0x060000C7 RID: 199 RVA: 0x0000DBAC File Offset: 0x0000BDAC
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand PrepareResetRadioPasswordCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1702835228;
				short num2 = num;
				num = (short)497693724;
				switch (num2 == num)
				{
				}
				num = (short)1211957248;
				if (num != 0)
				{
				}
				num = (short)1701642241;
				if (num != 0)
				{
				}
				num = (short)1715011584;
				short num3 = num;
				return this.at;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)183182515;
				short num2 = num;
				num = (short)45753523;
				switch (num2 == num)
				{
				}
				num = (short)1463943169;
				if (num != 0)
				{
				}
				num = (short)1548288000;
				if (num != 0)
				{
				}
				num = (short)1687158784;
				short num3 = num;
				this.at = value;
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000C8 RID: 200 RVA: 0x0000DC5C File Offset: 0x0000BE5C
		// (set) Token: 0x060000C9 RID: 201 RVA: 0x0000DD0C File Offset: 0x0000BF0C
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand CopyRadioIdentityCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)186927491;
				short num2 = num;
				num = (short)1438796163;
				switch (num2 == num)
				{
				}
				num = (short)454557697;
				if (num != 0)
				{
				}
				num = (short)731054080;
				if (num != 0)
				{
				}
				num = (short)1133838336;
				short num3 = num;
				return this.au;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)730930365;
				short num2 = num;
				num = (short)1224285373;
				switch (num2 == num)
				{
				}
				num = (short)399572993;
				if (num != 0)
				{
				}
				num = (short)899284992;
				if (num != 0)
				{
				}
				num = (short)1757806592;
				short num3 = num;
				this.au = value;
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000CA RID: 202 RVA: 0x0000DDC0 File Offset: 0x0000BFC0
		// (set) Token: 0x060000CB RID: 203 RVA: 0x0000DE70 File Offset: 0x0000C070
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand PasteRadioIdentityCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1565825520;
				short num2 = num;
				num = (short)628726256;
				switch (num2 == num)
				{
				}
				num = (short)628883456;
				if (num != 0)
				{
				}
				num = (short)1750335489;
				if (num != 0)
				{
				}
				num = (short)283508736;
				short num3 = num;
				return this.av;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1198064019;
				short num2 = num;
				num = (short)1084752275;
				switch (num2 == num)
				{
				}
				num = (short)1331363841;
				if (num != 0)
				{
				}
				num = (short)143654912;
				if (num != 0)
				{
				}
				num = (short)749862912;
				short num3 = num;
				this.av = value;
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000CC RID: 204 RVA: 0x0000DF1C File Offset: 0x0000C11C
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand EditCommand
		{
			get
			{
				short num = (short)407058570;
				short num2 = num;
				num = (short)372258954;
				switch (num2 == num)
				{
				}
				num = (short)1080754177;
				if (num != 0)
				{
				}
				num = (short)996671488;
				if (num != 0)
				{
				}
				num = (short)1487405056;
				short num3 = num;
				return this.EditCodeplugCommand;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000CD RID: 205 RVA: 0x0000DFCC File Offset: 0x0000C1CC
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand ExportRadiosGridToFileCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)541307553;
				short num2 = num;
				num = (short)1798812321;
				switch (num2 == num)
				{
				}
				num = (short)1945632768;
				if (num != 0)
				{
				}
				num = (short)380239873;
				if (num != 0)
				{
				}
				num = (short)2089943040;
				short num3 = num;
				return this.aw;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000CE RID: 206 RVA: 0x0000E07C File Offset: 0x0000C27C
		// (set) Token: 0x060000CF RID: 207 RVA: 0x0000E12C File Offset: 0x0000C32C
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> MSOtarNavigationCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2034977265;
				short num2 = num;
				num = (short)775309809;
				switch (num2 == num)
				{
				}
				num = (short)52166656;
				if (num != 0)
				{
				}
				num = (short)26804225;
				if (num != 0)
				{
				}
				num = (short)950992896;
				short num3 = num;
				return this.ax;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)290061366;
				short num2 = num;
				num = (short)2073164854;
				switch (num2 == num)
				{
				}
				num = (short)173277184;
				if (num != 0)
				{
				}
				num = (short)976748545;
				if (num != 0)
				{
				}
				num = (short)347537408;
				short num3 = num;
				this.ax = value;
			}
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x0000E1E0 File Offset: 0x0000C3E0
		private void a7()
		{
			short num;
			try
			{
				num = (short)1141787167;
				short num2 = num;
				num = (short)1207388703;
				switch (num2 == num)
				{
				}
				num = (short)1111425024;
				if (num != 0)
				{
				}
				base.EventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.EndGrouplistEditModeRequestedEvent>().Publish(null);
				global::Motorola.CommonCPS.RadioManagement.UIModels.Group group = (global::Motorola.CommonCPS.RadioManagement.UIModels.Group)this.f.AddGroupCommand.Execute(new object[]
				{
					this.SelectedNavigationItem
				});
				base.NavigationItems = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.GroupService.GetGroupsTree();
				this.SelectedNavigationItem = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.GroupService.FindGroup(group.ID);
				base.EventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.RenameGroupRequestedEvent>().Publish(this.SelectedNavigationItem);
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
			}
			num = (short)374210561;
			if (num != 0)
			{
			}
			num = (short)46596096;
			short num3 = num;
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x0000E328 File Offset: 0x0000C528
		private void a6()
		{
			short num;
			try
			{
				num = (short)1130213596;
				short num2 = num;
				num = (short)447787228;
				switch (num2 == num)
				{
				}
				num = (short)1879244800;
				if (num != 0)
				{
				}
				this.f.CancelJobCommand.Execute(new object[]
				{
					base.SelectedItems
				});
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
			}
			num = (short)1983578113;
			if (num != 0)
			{
			}
			num = (short)1027997696;
			short num3 = num;
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x0000E40C File Offset: 0x0000C60C
		private void a5()
		{
			short num;
			try
			{
				num = (short)1577761114;
				short num2 = num;
				num = (short)776255834;
				switch (num2 == num)
				{
				}
				num = (short)1311899648;
				if (num != 0)
				{
				}
				this.f.CompleteJobCommand.Execute(new object[]
				{
					base.SelectedItems
				});
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
			}
			num = (short)505085953;
			if (num != 0)
			{
			}
			num = (short)1971191808;
			short num3 = num;
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x0000E4F4 File Offset: 0x0000C6F4
		private void a4()
		{
			short num2;
			try
			{
				switch (0)
				{
				case 0:
					goto IL_20;
				}
				int num;
				global::System.Guid? id;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
					{
						if (!(bool)this.f.DeleteGroupCommand.Execute(new object[]
						{
							this.SelectedNavigationItem
						}))
						{
							num2 = (short)840105987;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						base.NavigationItems = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.GroupService.GetGroupsTree();
						this.SelectedNavigationItem = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.GroupService.FindGroup(id);
						num2 = (short)321121487;
						short num3 = num2;
						num2 = (short)1296559311;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_141;
						default:
							num2 = (short)1884225536;
							if (num2 != 0)
							{
							}
							num2 = (short)246218753;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 1:
						goto IL_141;
					case 2:
						goto IL_AE;
					case 3:
						num2 = (short)443940866;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_20;
				}
				IL_AE:
				IL_141:
				goto IL_14D;
				IL_20:
				base.EventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.EndGrouplistEditModeRequestedEvent>().Publish(null);
				id = this.SelectedNavigationItem.Parent.ID;
				num2 = (short)38600704;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
			}
			IL_14D:
			num2 = (short)596312065;
			if (num2 != 0)
			{
			}
			num2 = (short)991821824;
			short num4 = num2;
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x0000E6BC File Offset: 0x0000C8BC
		private void a3()
		{
			short num;
			try
			{
				num = (short)298575534;
				short num2 = num;
				num = (short)1400170158;
				switch (num2 == num)
				{
				}
				num = (short)482213888;
				if (num != 0)
				{
				}
				this.f.DeleteRadiosCommand.Execute(new object[]
				{
					base.SelectedItems
				});
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
			}
			num = (short)645922817;
			if (num != 0)
			{
			}
			num = (short)1137639424;
			short num3 = num;
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x0000E7A4 File Offset: 0x0000C9A4
		private void a2()
		{
			short num;
			try
			{
				num = (short)1849167990;
				short num2 = num;
				num = (short)1785008246;
				switch (num2 == num)
				{
				}
				num = (short)1027276800;
				if (num != 0)
				{
				}
				this.f.DiscardCodeplugCommand.Execute(new object[]
				{
					base.SelectedItems
				});
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
			}
			num = (short)783220737;
			if (num != 0)
			{
			}
			num = (short)853475328;
			short num3 = num;
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x0000E88C File Offset: 0x0000CA8C
		private void a1()
		{
			short num;
			try
			{
				num = (short)588280740;
				short num2 = num;
				num = (short)1223848868;
				switch (num2 == num)
				{
				}
				num = (short)1335623680;
				if (num != 0)
				{
				}
				this.f.EditCodeplugCommand.Execute(new object[]
				{
					base.SelectedItems
				});
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
			}
			num = (short)2076770305;
			if (num != 0)
			{
			}
			num = (short)1818099712;
			short num3 = num;
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x0000E970 File Offset: 0x0000CB70
		private void a0()
		{
			short num;
			try
			{
				num = (short)612940545;
				short num2 = num;
				num = (short)166640385;
				switch (num2 == num)
				{
				}
				num = (short)2057240576;
				if (num != 0)
				{
				}
				this.f.ExportDVRS_Command.Execute(new object[]
				{
					base.SelectedItems
				});
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
			}
			num = (short)1069416449;
			if (num != 0)
			{
			}
			num = (short)292683776;
			short num3 = num;
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x0000EA54 File Offset: 0x0000CC54
		private void az()
		{
			short num;
			try
			{
				num = (short)1643888129;
				short num2 = num;
				num = (short)1212923393;
				switch (num2 == num)
				{
				}
				num = (short)1349386240;
				if (num != 0)
				{
				}
				this.f.ExportRadioCommand.Execute(new object[]
				{
					base.SelectedItems
				});
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
			}
			num = (short)1186594817;
			if (num != 0)
			{
			}
			num = (short)298844160;
			short num3 = num;
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x0000EB38 File Offset: 0x0000CD38
		private void ay()
		{
			short num;
			try
			{
				num = (short)307757057;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_137;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_38;
						}
						continue;
					case 2:
						goto IL_120;
					case 3:
						goto IL_120;
					case 4:
					{
						this.f.ExportGridToFileCommand.Execute(new object[]
						{
							base.SelectedItems
						});
						num = (short)739297618;
						short num3 = num;
						num = (short)1315817810;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_5B;
						default:
							num = (short)550043648;
							if (num != 0)
							{
							}
							num = (short)1114701826;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					IL_38:
					if (base.SelectedItems.Any<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>())
					{
						num = (short)2090139652;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_5B:
					this.f.ExportGridToFileCommand.Execute(new object[]
					{
						base.Items.SourceCollection as global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>
					});
					num = (short)2071855107;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_120:
					num = (short)205717504;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_137:;
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
			}
			num = (short)1196949505;
			if (num != 0)
			{
			}
			num = (short)1864237056;
			short num4 = num;
		}

		// Token: 0x060000DA RID: 218 RVA: 0x0000ECF4 File Offset: 0x0000CEF4
		private void b(object[] A_0)
		{
			short num;
			try
			{
				num = (short)1821376512;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					switch (0)
					{
					case 0:
						goto IL_5E;
					}
					global::Motorola.CommonCPS.RadioManagement.UIModels.Group group;
					global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase;
					for (;;)
					{
						IL_27:
						bool flag;
						switch (num2)
						{
						case 0:
							num = (short)673644551;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_26A;
						case 2:
						{
							global::System.Guid? id;
							if (id == null)
							{
								num = (short)525664256;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)39452675;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
						{
							global::System.Guid? id;
							global::System.Guid? id2;
							flag = (id.GetValueOrDefault() != id2.GetValueOrDefault());
							goto IL_1EF;
						}
						case 4:
							goto IL_251;
						case 5:
						{
							global::System.Guid? id;
							global::System.Guid? id2;
							if (id != null == (id2 != null))
							{
								num = (short)2070347778;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)926137174;
							short num3 = num;
							num = (short)2125380438;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_251;
							default:
								num = (short)2002386944;
								if (num != 0)
								{
								}
								num = (short)288620553;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 6:
							if (group != null)
							{
								num = (short)1916272648;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_251;
						case 7:
							flag = false;
							goto IL_1EF;
						case 8:
						{
							global::System.Guid? id = radioBase.CurentGroup.ID;
							global::System.Guid? id2 = group.ID;
							num = (short)1208614917;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 9:
							num = (short)1541472267;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 10:
							this.f.MoveDeviceCommand.Execute(A_0);
							num = (short)664076292;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 11:
							flag = true;
							goto IL_1EF;
						}
						goto IL_5E;
						IL_1EF:
						if (flag)
						{
							num = (short)1746534410;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_251:
						num = (short)2025259009;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_26A:
					break;
					IL_5E:
					radioBase = (A_0[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase);
					group = (A_0[2] as global::Motorola.CommonCPS.RadioManagement.UIModels.Group);
					num = (short)729350150;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_27;
				}
				}
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
			}
			num = (short)982319105;
			if (num != 0)
			{
			}
			num = (short)1945763840;
			short num4 = num;
		}

		// Token: 0x060000DB RID: 219 RVA: 0x0000EFE4 File Offset: 0x0000D1E4
		private void ax()
		{
			short num;
			try
			{
				num = (short)1946619379;
				short num2 = num;
				num = (short)1796804083;
				switch (num2 == num)
				{
				}
				num = (short)1259274240;
				if (num != 0)
				{
				}
				this.f.PrepareAddRadioCommand.Execute(new object[]
				{
					this.SelectedNavigationItem
				});
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
			}
			num = (short)115867648;
			short num3 = num;
			num = (short)1179189249;
			if (num != 0)
			{
			}
		}

		// Token: 0x060000DC RID: 220 RVA: 0x0000F0C8 File Offset: 0x0000D2C8
		private void aw()
		{
			short num;
			try
			{
				num = (short)1386836112;
				short num2 = num;
				num = (short)1666805904;
				switch (num2 == num)
				{
				}
				num = (short)2000683009;
				if (num != 0)
				{
				}
				num = (short)748290048;
				if (num != 0)
				{
				}
				this.f.PrepareModifyCodeplugPasswordCommand.Execute(new object[]
				{
					base.SelectedItems
				});
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
			}
			num = (short)1169489920;
			short num3 = num;
		}

		// Token: 0x060000DD RID: 221 RVA: 0x0000F1AC File Offset: 0x0000D3AC
		private void av()
		{
			short num;
			try
			{
				num = (short)1435061525;
				short num2 = num;
				num = (short)1285115157;
				switch (num2 == num)
				{
				}
				num = (short)1362427904;
				if (num != 0)
				{
				}
				this.f.PrepareResetRadioPasswordCommand.Execute(new object[]
				{
					base.SelectedItems
				});
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
			}
			num = (short)604635136;
			short num3 = num;
			num = (short)1260453889;
			if (num != 0)
			{
			}
		}

		// Token: 0x060000DE RID: 222 RVA: 0x0000F294 File Offset: 0x0000D494
		private void au()
		{
			short num;
			try
			{
				num = (short)125399072;
				short num2 = num;
				num = (short)677605408;
				switch (num2 == num)
				{
				}
				num = (short)1749024768;
				if (num != 0)
				{
				}
				this.f.ImportFileToRadioGridCommand.Execute(new object[]
				{
					this.SelectedNavigationItem
				});
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
			}
			num = (short)1146814464;
			short num3 = num;
			num = (short)112001025;
			if (num != 0)
			{
			}
		}

		// Token: 0x060000DF RID: 223 RVA: 0x0000F378 File Offset: 0x0000D578
		private void at()
		{
			short num;
			try
			{
				num = (short)1257945128;
				short num2 = num;
				num = (short)558807080;
				switch (num2 == num)
				{
				}
				num = (short)1994784768;
				if (num != 0)
				{
				}
				this.f.PrepareImportRadiosCommand.Execute(new object[]
				{
					this.SelectedNavigationItem
				});
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
			}
			num = (short)815661056;
			short num3 = num;
			num = (short)1903755265;
			if (num != 0)
			{
			}
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x0000F460 File Offset: 0x0000D660
		private void @as()
		{
			short num;
			try
			{
				num = (short)119930588;
				short num2 = num;
				num = (short)1951596252;
				switch (num2 == num)
				{
				}
				num = (short)1355415552;
				if (num != 0)
				{
				}
				this.f.PrepareMoveDeviceBatchCommand.Execute(new object[]
				{
					base.SelectedItems,
					base.NavigationItems
				});
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
			}
			num = (short)2026242048;
			short num3 = num;
			num = (short)950009857;
			if (num != 0)
			{
			}
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x0000F550 File Offset: 0x0000D750
		private void ar()
		{
			short num;
			try
			{
				num = (short)2048096121;
				short num2 = num;
				num = (short)174225273;
				switch (num2 == num)
				{
				}
				num = (short)356515840;
				if (num != 0)
				{
				}
				base.EventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.RenameGroupRequestedEvent>().Publish(this.SelectedNavigationItem);
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
			}
			num = (short)1988165632;
			short num3 = num;
			num = (short)599392257;
			if (num != 0)
			{
			}
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x0000F62C File Offset: 0x0000D82C
		private void aq()
		{
			short num;
			try
			{
				num = (short)581614485;
				short num2 = num;
				num = (short)198425493;
				switch (num2 == num)
				{
				}
				num = (short)1535770625;
				if (num != 0)
				{
				}
				num = (short)507510784;
				if (num != 0)
				{
				}
				this.f.PrepareResetIndentifiersCommand.Execute(new object[]
				{
					base.SelectedItems
				});
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
			}
			num = (short)808779776;
			short num3 = num;
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x0000F710 File Offset: 0x0000D910
		private void ap()
		{
			short num;
			try
			{
				num = (short)977686196;
				short num2 = num;
				num = (short)80432820;
				switch (num2 == num)
				{
				}
				num = (short)261881856;
				if (num != 0)
				{
				}
				this.f.PrepareScheduleJobCommand.Execute(new object[]
				{
					base.SelectedItems
				});
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
			}
			num = (short)810287104;
			short num3 = num;
			num = (short)387645441;
			if (num != 0)
			{
			}
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x0000F7F8 File Offset: 0x0000D9F8
		private void ao()
		{
			short num;
			try
			{
				num = (short)209571428;
				short num2 = num;
				num = (short)1939394148;
				switch (num2 == num)
				{
				}
				num = (short)1838022656;
				if (num != 0)
				{
				}
				this.f.PrepareSelectTemplateCommand.Execute(new object[]
				{
					base.SelectedItems
				});
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
			}
			num = (short)231473152;
			short num3 = num;
			num = (short)1307508737;
			if (num != 0)
			{
			}
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x0000F8DC File Offset: 0x0000DADC
		private void an()
		{
			short num;
			try
			{
				num = (short)1738031759;
				short num2 = num;
				num = (short)997868175;
				switch (num2 == num)
				{
				}
				num = (short)2129657857;
				if (num != 0)
				{
				}
				num = (short)563675136;
				if (num != 0)
				{
				}
				this.f.PrepareWiFiPasswordValidationCommand.Execute(new object[]
				{
					base.SelectedItems
				});
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
			}
			num = (short)1003618304;
			short num3 = num;
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x0000F9C0 File Offset: 0x0000DBC0
		private void am()
		{
			short num;
			try
			{
				num = (short)1447483340;
				short num2 = num;
				num = (short)19519436;
				switch (num2 == num)
				{
				}
				num = (short)436207616;
				if (num != 0)
				{
				}
				this.f.PrepareUpgradeFirmwareCommand.Execute(new object[]
				{
					base.SelectedItems
				});
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
			}
			num = (short)1887240192;
			short num3 = num;
			num = (short)1048379393;
			if (num != 0)
			{
			}
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x0000FAA8 File Offset: 0x0000DCA8
		private void al()
		{
			short num;
			try
			{
				num = (short)1243685814;
				short num2 = num;
				num = (short)1399858102;
				switch (num2 == num)
				{
				}
				num = (short)37158912;
				if (num != 0)
				{
				}
				num = (short)821821441;
				if (num != 0)
				{
				}
				this.f.UpgradeLanguageInRadioCommand.Execute(new object[]
				{
					base.SelectedItems
				});
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
			}
			num = (short)460259328;
			short num3 = num;
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x0000FB90 File Offset: 0x0000DD90
		private void c(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase A_0)
		{
			short num;
			try
			{
				num = (short)1404908990;
				short num2 = num;
				num = (short)1310668222;
				switch (num2 == num)
				{
				}
				num = (short)100466688;
				if (num != 0)
				{
				}
				this.f.ShowLanguageDetailInfoCommand.Execute(new object[]
				{
					A_0
				});
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
			}
			num = (short)1033699328;
			short num3 = num;
			num = (short)1682243585;
			if (num != 0)
			{
			}
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x0000FC70 File Offset: 0x0000DE70
		private void b(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase A_0)
		{
			short num;
			try
			{
				num = (short)733525907;
				short num2 = num;
				num = (short)1477425043;
				switch (num2 == num)
				{
				}
				num = (short)1750925312;
				if (num != 0)
				{
				}
				this.f.ShowVADetailInfoCommand.Execute(new object[]
				{
					A_0
				});
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
			}
			num = (short)303693824;
			short num3 = num;
			num = (short)77725697;
			if (num != 0)
			{
			}
		}

		// Token: 0x060000EA RID: 234 RVA: 0x0000FD50 File Offset: 0x0000DF50
		private void ak()
		{
			short num;
			try
			{
				num = (short)249954463;
				short num2 = num;
				num = (short)506855583;
				switch (num2 == num)
				{
				}
				num = (short)630063104;
				if (num != 0)
				{
				}
				this.f.ASTROPrepareQueryUpdateRadioCommand.Execute(new object[]
				{
					base.SelectedItems
				});
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
			}
			num = (short)1080950784;
			short num3 = num;
			num = (short)930414593;
			if (num != 0)
			{
			}
		}

		// Token: 0x060000EB RID: 235 RVA: 0x0000FE34 File Offset: 0x0000E034
		private void aj()
		{
			short num;
			try
			{
				num = (short)160470582;
				short num2 = num;
				num = (short)668571190;
				switch (num2 == num)
				{
				}
				num = (short)303104001;
				if (num != 0)
				{
				}
				num = (short)1328480256;
				if (num != 0)
				{
				}
				this.f.AstroPrepareFlashPortCommand.Execute(new object[]
				{
					base.SelectedItems
				});
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
			}
			num = (short)115998720;
			short num3 = num;
		}

		// Token: 0x060000EC RID: 236 RVA: 0x0000FF18 File Offset: 0x0000E118
		private void d(string A_0)
		{
			short num;
			try
			{
				num = (short)550822193;
				short num2 = num;
				num = (short)1649140017;
				switch (num2 == num)
				{
				}
				num = (short)1935671296;
				if (num != 0)
				{
				}
				this.f.RenameGroupCommand.Execute(new object[]
				{
					this.SelectedNavigationItem,
					A_0
				});
				base.RefreshCommand.Execute();
				base.RaisePropertyChanged<global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.Group>>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.Group>>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.Radio.RadiosViewModel)), methodof(global::Motorola.CommonCPS.RadioManagement.Infrastructure.NavigatedTableViewModelBase<global::Motorola.CommonCPS.RadioManagement.UIModels.Group, global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>.get_NavigationItems())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
			}
			num = (short)47972352;
			short num3 = num;
			num = (short)560529409;
			if (num != 0)
			{
			}
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00010044 File Offset: 0x0000E244
		private void ai()
		{
			short num = (short)938672128;
			short num2 = num;
			num = (short)573349703;
			short num3 = num;
			num = (short)959356743;
			switch (num3 == num)
			{
			}
			num = (short)1661337600;
			if (num != 0)
			{
			}
			num = (short)320143361;
			if (num != 0)
			{
			}
		}

		// Token: 0x060000EE RID: 238 RVA: 0x000100F0 File Offset: 0x0000E2F0
		private void ah()
		{
			short num;
			try
			{
				num = (short)1393978680;
				short num2 = num;
				num = (short)1262185784;
				switch (num2 == num)
				{
				}
				num = (short)1735000064;
				if (num != 0)
				{
				}
				this.f.ShowRadioDetailsCommand.Execute(new object[]
				{
					base.SelectedItems
				});
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
			}
			num = (short)1057882112;
			short num3 = num;
			num = (short)703791105;
			if (num != 0)
			{
			}
		}

		// Token: 0x060000EF RID: 239 RVA: 0x000101D8 File Offset: 0x0000E3D8
		private void ag()
		{
			short num;
			try
			{
				num = (short)591795959;
				short num2 = num;
				num = (short)1158223607;
				switch (num2 == num)
				{
				}
				num = (short)107282432;
				if (num != 0)
				{
				}
				this.f.PrepareSelectCodeplugVersionCommand.Execute(new object[]
				{
					base.SelectedItems
				});
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
			}
			num = (short)390201344;
			short num3 = num;
			num = (short)1471348737;
			if (num != 0)
			{
			}
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x000102BC File Offset: 0x0000E4BC
		private void af()
		{
			short num;
			try
			{
				num = (short)208653197;
				short num2 = num;
				num = (short)1958988685;
				switch (num2 == num)
				{
				}
				num = (short)582025216;
				if (num != 0)
				{
				}
				this.f.CopyRadioIdentityCommand.Execute(new object[]
				{
					base.SelectedItems
				});
				this.PasteRadioIdentityCommand.RaiseCanExecuteChanged();
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
			}
			num = (short)1305083904;
			short num3 = num;
			num = (short)332464129;
			if (num != 0)
			{
			}
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x000103AC File Offset: 0x0000E5AC
		private void ae()
		{
			short num;
			try
			{
				num = (short)18208801;
				short num2 = num;
				num = (short)1901516833;
				switch (num2 == num)
				{
				}
				num = (short)1478492160;
				if (num != 0)
				{
				}
				this.f.PasteRadioIdentityCommand.Execute(new object[]
				{
					base.SelectedItems
				});
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
			}
			num = (short)1411907584;
			short num3 = num;
			num = (short)2132738049;
			if (num != 0)
			{
			}
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00010494 File Offset: 0x0000E694
		private void d(global::Motorola.CommonCPS.RadioManagement.UIModels.Group A_0)
		{
			short num;
			try
			{
				num = (short)1443872789;
				short num2 = num;
				num = (short)1906884629;
				switch (num2 == num)
				{
				}
				num = (short)1847918592;
				if (num != 0)
				{
				}
				this.f.UpdateGroupCommand.Execute(new object[]
				{
					A_0
				});
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
			}
			num = (short)363003904;
			short num3 = num;
			num = (short)1779957761;
			if (num != 0)
			{
			}
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00010574 File Offset: 0x0000E774
		private void c(global::Motorola.CommonCPS.RadioManagement.UIModels.Group A_0)
		{
			short num;
			try
			{
				num = (short)1544731768;
				short num2 = num;
				num = (short)614251640;
				switch (num2 == num)
				{
				}
				num = (short)1455489024;
				if (num != 0)
				{
				}
				base.NavigationItems = (this.f.RefreshGroupCommand.Execute(global::System.Array.Empty<object>()) as global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.Group>);
				this.SelectedNavigationItem = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.GroupService.FindGroup(A_0.ID);
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
			}
			num = (short)2086928384;
			short num3 = num;
			num = (short)557645825;
			if (num != 0)
			{
			}
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00010674 File Offset: 0x0000E874
		private void c(string A_0)
		{
			int a_ = 11;
			this.RadioVRIDEntryFormat = A_0;
			global::System.Collections.IEnumerator enumerator = base.Items.GetEnumerator();
			short num;
			try
			{
				num = (short)627310592;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_57;
						}
						continue;
					case 1:
						goto IL_134;
					case 2:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)2056519684;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase = (global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase)enumerator.Current;
						global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroradio = (global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio)radioBase;
						radioBase.InvokeRaisePropertyChanged(global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("鏀諂臄", a_));
						num = (short)797573123;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
					{
						num = (short)179591669;
						short num3 = num;
						num = (short)1467374069;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							num = (short)833683456;
							if (num != 0)
							{
							}
							break;
						}
						break;
					}
					case 4:
						num = (short)1042219009;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_E1:
					num = (short)1574895618;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_57:
					goto IL_E1;
				}
				IL_134:;
			}
			finally
			{
				switch (0)
				{
				case 0:
					goto IL_152;
				}
				int num2;
				global::System.IDisposable disposable;
				for (;;)
				{
					IL_140:
					switch (num2)
					{
					case 0:
						disposable.Dispose();
						num = (short)706019330;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (disposable != null)
						{
							num = (short)1324154880;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1A5;
					case 2:
						goto IL_1A3;
					}
					goto IL_152;
				}
				IL_1A3:
				IL_1A5:
				goto EndFinally_5;
				IL_152:
				disposable = (enumerator as global::System.IDisposable);
				num = (short)2050883585;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_140;
				EndFinally_5:;
			}
			num = (short)1631780864;
			short num4 = num;
			num = (short)1735786497;
			if (num != 0)
			{
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000F5 RID: 245 RVA: 0x00010894 File Offset: 0x0000EA94
		// (set) Token: 0x060000F6 RID: 246 RVA: 0x00010944 File Offset: 0x0000EB44
		public string RadioVRIDEntryFormat
		{
			get
			{
				short num = (short)2011299840;
				short num2 = num;
				num = (short)1597360402;
				short num3 = num;
				num = (short)1580910866;
				switch (num3 == num)
				{
				}
				num = (short)276496385;
				if (num != 0)
				{
				}
				num = (short)999358464;
				if (num != 0)
				{
				}
				return this.h;
			}
			set
			{
				int a_ = 10;
				short num = (short)460390401;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)1256039926;
					short num3 = num;
					num = (short)723690998;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)461111296;
						if (num != 0)
						{
						}
						switch (num2)
						{
						case 0:
							num = (short)1216675841;
							if (num != 0)
							{
							}
							this.h = value;
							this.RaisePropertyChanged(global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("ꆿꛁ귃꧅黇飉藋諍闏병ꃓꓕꇗ鳙돛곝跟菡郣", a_));
							num = (short)2020933634;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_1E;
						case 2:
							return;
						}
						goto IL_87;
					}
					IL_1E:
					switch (0)
					{
					case 0:
					{
						IL_87:
						if (!(this.h != value))
						{
							return;
						}
						num = (short)936968192;
						short num4 = num;
						num = (short)1574240256;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					}
				}
			}
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00010A88 File Offset: 0x0000EC88
		private void a(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase A_0)
		{
			int a_ = 16;
			short num;
			try
			{
				num = (short)1408218327;
				short num2 = num;
				num = (short)281195735;
				switch (num2 == num)
				{
				}
				num = (short)709296128;
				if (num != 0)
				{
				}
				global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
				list.Add(global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("雃Ʂ곇ꏉꏋ蟍铏", a_) + A_0.ID.ToString());
				list.Add(global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("韃ꏅ뫇ꏉ귋ꋍ黏ꟑ맓듕뷗꣙", a_) + base.UrlEncode(A_0.SerialNumber));
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.NavigationHelper.Go(global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("藃闅鳇飉菋臍꓏돑ꛓ蛕꫗뗙뫛럝賟蟡", a_), global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("藃闅鳇飉菋重苏돑냓뿕럗黙맛ꫝ臟诡裣闥뻧菩觫駭", a_), list);
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
			}
			num = (short)2145189888;
			short num3 = num;
			num = (short)1654128641;
			if (num != 0)
			{
			}
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00010BD0 File Offset: 0x0000EDD0
		private bool ad()
		{
			int a_ = 4;
			short num;
			bool result;
			try
			{
				num = (short)645332993;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)2045964119;
					short num3 = num;
					num = (short)1042607959;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)99876864;
						if (num != 0)
						{
						}
						bool flag;
						switch (num2)
						{
						case 0:
							flag = this.f.AddGroupCommand.CanExecute(global::System.Array.Empty<object>());
							goto IL_159;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_93;
							}
							continue;
						case 2:
							num = (short)1829830662;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							num = (short)1571880960;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							goto IL_171;
						case 5:
							flag = false;
							goto IL_159;
						case 6:
							if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveMainView == global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("\udbb9\ud8bbힽ꾿뇁鋃꿅귇뷉", a_))
							{
								num = (short)330629123;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_C6;
						}
						IL_93:
						if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveMainModule == global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("\udbb9\ud8bbힽ꾿", a_))
						{
							break;
						}
						IL_C6:
						num = (short)1150156805;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_159:
						result = flag;
						num = (short)1151336452;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					num = (short)1630339074;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_171:
				num = (short)1695809537;
				if (num != 0)
				{
				}
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
				result = false;
			}
			num = (short)453705728;
			short num4 = num;
			return result;
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00010DC8 File Offset: 0x0000EFC8
		private bool ac()
		{
			short num;
			bool result;
			try
			{
				num = (short)1593105721;
				short num2 = num;
				num = (short)940039481;
				switch (num2 == num)
				{
				}
				num = (short)898891776;
				if (num != 0)
				{
				}
				result = this.f.CancelJobCommand.CanExecute(new object[]
				{
					base.SelectedItems
				});
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
				result = false;
			}
			num = (short)1767571456;
			short num3 = num;
			num = (short)1551368193;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00010EB0 File Offset: 0x0000F0B0
		private bool ab()
		{
			int a_ = 9;
			short num;
			bool result;
			try
			{
				num = (short)1013186561;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					bool flag;
					switch (num2)
					{
					case 0:
						flag = false;
						goto IL_16E;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_4B;
						}
						continue;
					case 2:
						num = (short)1289224198;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_187;
					case 4:
						num = (short)1310982149;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						IL_133:
						if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveMainView == global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("\udebeꗀꫂ꫄듆鿈ꋊ꣌룎", a_))
						{
							num = (short)254017538;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7E;
					case 6:
						flag = this.f.CompleteJobCommand.CanExecute(new object[]
						{
							base.SelectedItems
						});
						goto IL_16E;
					}
					IL_4B:
					if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveMainModule == global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("\udebeꗀꫂ꫄", a_))
					{
						num = (short)1299447812;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_7E:
					num = (short)317888904;
					short num3 = num;
					num = (short)46045576;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_133;
					default:
						num = (short)1907621888;
						if (num != 0)
						{
						}
						num = (short)1261699072;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_16E:
					result = flag;
					num = (short)46268419;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_187:;
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
				result = false;
			}
			num = (short)285016064;
			short num4 = num;
			num = (short)1400832001;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x060000FB RID: 251 RVA: 0x000110C0 File Offset: 0x0000F2C0
		private bool aa()
		{
			int a_ = 18;
			short num;
			bool result;
			try
			{
				num = (short)470286337;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					bool flag;
					switch (num2)
					{
					case 0:
						flag = false;
						goto IL_174;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_49;
						}
						continue;
					case 2:
						num = (short)1143996422;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_18D;
					case 4:
						num = (short)388562949;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						IL_13A:
						if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveMainView == global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("铅꧇껉ꗋꇍꏏ蓑뷓돕꿗", a_))
						{
							num = (short)486998018;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7E;
					case 6:
						flag = this.f.DeleteGroupCommand.CanExecute(new object[]
						{
							this.SelectedNavigationItem
						});
						goto IL_174;
					}
					IL_49:
					if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveMainModule == global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("铅꧇껉ꗋꇍ", a_))
					{
						num = (short)13893636;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_7E:
					num = (short)1402960962;
					short num3 = num;
					num = (short)1241480258;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_13A;
					default:
						num = (short)76283904;
						if (num != 0)
						{
						}
						num = (short)1469513728;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_174:
					result = flag;
					num = (short)719585283;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_18D:;
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
				result = false;
			}
			num = (short)645857280;
			short num4 = num;
			num = (short)117309441;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x060000FC RID: 252 RVA: 0x000112D4 File Offset: 0x0000F4D4
		private bool z()
		{
			short num;
			bool result;
			try
			{
				num = (short)117232330;
				short num2 = num;
				num = (short)1115542218;
				switch (num2 == num)
				{
				}
				num = (short)1207369728;
				if (num != 0)
				{
				}
				result = this.f.DeleteRadiosCommand.CanExecute(new object[]
				{
					base.SelectedItems
				});
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
				result = false;
			}
			num = (short)1608646656;
			short num3 = num;
			num = (short)1234108417;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x060000FD RID: 253 RVA: 0x000113BC File Offset: 0x0000F5BC
		private bool y()
		{
			short num;
			bool result;
			try
			{
				num = (short)1179199017;
				short num2 = num;
				num = (short)1401497129;
				switch (num2 == num)
				{
				}
				num = (short)667025408;
				if (num != 0)
				{
				}
				num = (short)1641545729;
				if (num != 0)
				{
				}
				result = this.f.DiscardCodeplugCommand.CanExecute(new object[]
				{
					base.SelectedItems
				});
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
				result = false;
			}
			num = (short)1013514240;
			short num3 = num;
			return result;
		}

		// Token: 0x060000FE RID: 254 RVA: 0x000114A8 File Offset: 0x0000F6A8
		private bool x()
		{
			short num;
			bool result;
			try
			{
				num = (short)939766818;
				short num2 = num;
				num = (short)552973346;
				switch (num2 == num)
				{
				}
				num = (short)1402273792;
				if (num != 0)
				{
				}
				result = this.f.EditCodeplugCommand.CanExecute(new object[]
				{
					base.SelectedItems
				});
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
				result = false;
			}
			num = (short)120979456;
			short num3 = num;
			num = (short)1323761665;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00011594 File Offset: 0x0000F794
		private bool w()
		{
			int a_ = 0;
			short num;
			bool result;
			try
			{
				num = (short)1557004289;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					bool flag;
					switch (num2)
					{
					case 0:
						flag = false;
						goto IL_16F;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_49;
						}
						continue;
					case 2:
						num = (short)1587544070;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_187;
					case 4:
						num = (short)1901854725;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						IL_135:
						if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveMainView == global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("ힵ\udcb7펹펻춽隿ꯁꇃ뇅", a_))
						{
							num = (short)20185090;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7C;
					case 6:
						flag = this.f.ExportDVRS_Command.CanExecute(new object[]
						{
							base.SelectedItems
						});
						goto IL_16F;
					}
					IL_49:
					if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveMainModule == global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("ힵ\udcb7펹펻", a_))
					{
						num = (short)1718419460;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_7C:
					num = (short)1617165422;
					short num3 = num;
					num = (short)588381294;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_135;
					default:
						num = (short)1284833280;
						if (num != 0)
						{
						}
						num = (short)1301544960;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_16F:
					result = flag;
					num = (short)1198522371;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_187:;
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
				result = false;
			}
			num = (short)2025390080;
			short num4 = num;
			num = (short)323682305;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x06000100 RID: 256 RVA: 0x000117A4 File Offset: 0x0000F9A4
		private bool v()
		{
			int a_ = 15;
			short num;
			bool result;
			try
			{
				num = (short)1475674113;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					bool flag;
					switch (num2)
					{
					case 0:
						flag = false;
						goto IL_16F;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_4A;
						}
						continue;
					case 2:
						num = (short)1525219334;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_187;
					case 4:
						num = (short)1215037445;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						IL_136:
						if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveMainView == global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("釂꓄ꏆꃈ꓊뻌駎룐뛒ꋔ", a_))
						{
							num = (short)241238018;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7D;
					case 6:
						flag = this.f.ExportRadioCommand.CanExecute(new object[]
						{
							base.SelectedItems
						});
						goto IL_16F;
					}
					IL_4A:
					if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveMainModule == global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("釂꓄ꏆꃈ꓊", a_))
					{
						num = (short)652148740;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_7D:
					num = (short)365931676;
					short num3 = num;
					num = (short)1054190748;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_136;
					default:
						num = (short)942145536;
						if (num != 0)
						{
						}
						num = (short)1163264000;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_16F:
					result = flag;
					num = (short)230490115;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_187:;
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
				result = false;
			}
			num = (short)1950089216;
			short num4 = num;
			num = (short)590479361;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x06000101 RID: 257 RVA: 0x000119B4 File Offset: 0x0000FBB4
		private bool u()
		{
			short num;
			bool result;
			try
			{
				num = (short)1191961032;
				short num2 = num;
				num = (short)735830472;
				switch (num2 == num)
				{
				}
				num = (short)632225792;
				if (num != 0)
				{
				}
				global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation exportGridToFileCommand = this.f.ExportGridToFileCommand;
				object[] array = new object[1];
				int num3 = 0;
				global::System.ComponentModel.ICollectionView items = base.Items;
				array[num3] = (((items != null) ? items.SourceCollection : null) as global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>);
				result = exportGridToFileCommand.CanExecute(array);
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
				result = false;
			}
			num = (short)1082327040;
			short num4 = num;
			num = (short)80412673;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00011AB4 File Offset: 0x0000FCB4
		private bool t()
		{
			int a_ = 1;
			short num;
			bool result;
			try
			{
				num = (short)558366721;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					bool flag;
					switch (num2)
					{
					case 0:
						flag = false;
						goto IL_16F;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_49;
						}
						continue;
					case 2:
						num = (short)1725169670;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_187;
					case 4:
						num = (short)1473773573;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						IL_134:
						if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveMainView == global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("횶\uddb8튺튼첾韀ꫂꃄ냆", a_))
						{
							num = (short)1152843778;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7D;
					case 6:
						flag = this.f.PrepareModifyCodeplugPasswordCommand.CanExecute(new object[]
						{
							base.SelectedItems
						});
						goto IL_16F;
					}
					IL_49:
					if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveMainModule == global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("횶\uddb8튺튼", a_))
					{
						num = (short)2145320964;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_7D:
					num = (short)2060190391;
					short num3 = num;
					num = (short)543228599;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_134;
					default:
						num = (short)716963840;
						if (num != 0)
						{
						}
						num = (short)378929152;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_16F:
					result = flag;
					num = (short)992346115;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_187:;
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
				result = false;
			}
			num = (short)1179451392;
			short num4 = num;
			num = (short)323878913;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00011CC4 File Offset: 0x0000FEC4
		private bool s()
		{
			int a_ = 16;
			short num;
			bool result;
			try
			{
				num = (short)731512833;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					bool flag;
					switch (num2)
					{
					case 0:
						flag = false;
						goto IL_174;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_49;
						}
						continue;
					case 2:
						num = (short)207486982;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_18D;
					case 4:
						num = (short)440074245;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						IL_139:
						if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveMainView == global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("雃Ʂ곇ꏉꏋ뷍蛏믑뇓ꇕ", a_))
						{
							num = (short)1649934338;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7D;
					case 6:
						flag = this.f.PrepareResetRadioPasswordCommand.CanExecute(new object[]
						{
							base.SelectedItems
						});
						goto IL_174;
					}
					IL_49:
					if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveMainModule == global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("雃Ʂ곇ꏉꏋ", a_))
					{
						num = (short)675479556;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_7D:
					num = (short)839827729;
					short num3 = num;
					num = (short)561627409;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_139;
					default:
						num = (short)1988689920;
						if (num != 0)
						{
						}
						num = (short)1560281088;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_174:
					result = flag;
					num = (short)475201539;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_18D:;
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
				result = false;
			}
			num = (short)844890112;
			short num4 = num;
			num = (short)418775041;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00011EDC File Offset: 0x000100DC
		private bool r()
		{
			int a_ = 4;
			short num;
			bool result;
			try
			{
				num = (short)1780154369;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					bool flag;
					switch (num2)
					{
					case 0:
						flag = false;
						goto IL_199;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_49;
						}
						continue;
					case 2:
						num = (short)1877082118;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_1B3;
					case 4:
						num = (short)252903429;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						IL_136:
						num = (short)2017394689;
						if (num != 0)
						{
						}
						if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveMainView == global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("\udbb9\ud8bbힽ꾿뇁鋃꿅귇뷉", a_))
						{
							num = (short)1806041090;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7C;
					case 6:
						flag = this.f.PrepareAddRadioCommand.CanExecute(new object[]
						{
							base.SelectedItems
						});
						goto IL_199;
					}
					IL_49:
					if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveMainModule == global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("\udbb9\ud8bbힽ꾿", a_))
					{
						num = (short)866385924;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_7C:
					num = (short)86308619;
					short num3 = num;
					num = (short)600045323;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_136;
					default:
						num = (short)1714552832;
						if (num != 0)
						{
						}
						num = (short)1196818432;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_199:
					result = flag;
					num = (short)799277059;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1B3:;
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
				result = false;
			}
			num = (short)1837760512;
			short num4 = num;
			return result;
		}

		// Token: 0x06000105 RID: 261 RVA: 0x000120F0 File Offset: 0x000102F0
		private bool q()
		{
			int a_ = 1;
			short num;
			bool result;
			try
			{
				num = (short)242614273;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					bool flag;
					switch (num2)
					{
					case 0:
						flag = false;
						goto IL_16E;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_4A;
						}
						continue;
					case 2:
						num = (short)176160774;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_188;
					case 4:
						num = (short)1124794373;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						IL_135:
						if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveMainView == global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("횶\uddb8튺튼첾韀ꫂꃄ냆", a_))
						{
							num = (short)1930821634;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7D;
					case 6:
						flag = this.f.ImportFileToRadioGridCommand.CanExecute(new object[]
						{
							this.SelectedNavigationItem
						});
						goto IL_16E;
					}
					IL_4A:
					if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveMainModule == global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("횶\uddb8튺튼", a_))
					{
						num = (short)984481796;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_7D:
					num = (short)1313930045;
					short num3 = num;
					num = (short)1836514109;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_135;
					default:
						num = (short)433127424;
						if (num != 0)
						{
						}
						num = (short)117374976;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_16E:
					result = flag;
					num = (short)899612675;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_188:;
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
				result = false;
			}
			num = (short)1813512192;
			short num4 = num;
			num = (short)336986113;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00012304 File Offset: 0x00010504
		private bool p()
		{
			int a_ = 9;
			short num;
			bool result;
			try
			{
				num = (short)834994179;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					bool flag;
					switch (num2)
					{
					case 0:
						if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveMainView == global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("\udebeꗀꫂ꫄듆鿈ꋊ꣌룎", a_))
						{
							num = (short)1228668929;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7C;
					case 1:
						num = (short)317325317;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						num = (short)1647259090;
						short num3 = num;
						num = (short)667889106;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_D8;
						default:
							num = (short)1345912832;
							if (num != 0)
							{
							}
							num = (short)1546321920;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 3:
						switch (0)
						{
						case 0:
							goto IL_49;
						}
						continue;
					case 4:
						flag = false;
						goto IL_196;
					case 5:
						goto IL_D8;
					case 6:
						goto IL_1AF;
					}
					IL_49:
					if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveMainModule == global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("\udebeꗀꫂ꫄", a_))
					{
						num = (short)2002321410;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_7C:
					num = (short)1257177089;
					if (num != 0)
					{
					}
					num = (short)1523122180;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_196:
					result = flag;
					num = (short)1177747462;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_D8:
					flag = this.f.PrepareImportRadiosCommand.CanExecute(new object[]
					{
						base.SelectedItems
					});
					goto IL_196;
				}
				IL_1AF:;
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
				result = false;
			}
			num = (short)1136197632;
			short num4 = num;
			return result;
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00012518 File Offset: 0x00010718
		private bool o()
		{
			int a_ = 0;
			short num;
			bool result;
			try
			{
				num = (short)14811139;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					bool flag;
					switch (num2)
					{
					case 0:
					{
						if (!(global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveMainView == global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("ힵ\udcb7펹펻춽隿ꯁꇃ뇅", a_)))
						{
							goto IL_79;
						}
						num = (short)308938639;
						short num3 = num;
						num = (short)222889871;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1D;
						default:
							num = (short)904003584;
							if (num != 0)
							{
							}
							num = (short)1061224449;
							if (num != 0)
							{
							}
							num = (short)646512641;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 1:
					{
						global::System.Guid? id = this.SelectedNavigationItem.ID;
						num = (short)1909587973;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						num = (short)1006960640;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_1D;
					case 4:
						flag = false;
						goto IL_182;
					case 5:
					{
						global::System.Guid? id;
						flag = (id != null);
						goto IL_182;
					}
					case 6:
						goto IL_19B;
					}
					goto IL_49;
					IL_1D:
					switch (0)
					{
					case 0:
						IL_49:
						if (!(global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveMainModule == global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("ힵ\udcb7펹펻", a_)))
						{
							goto IL_79;
						}
						num = (short)1831993346;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					continue;
					IL_79:
					num = (short)1779105796;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_182:
					result = flag;
					num = (short)133955590;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_19B:;
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
				result = false;
			}
			num = (short)45350912;
			short num4 = num;
			return result;
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00012714 File Offset: 0x00010914
		private bool n()
		{
			int a_ = 16;
			short num;
			bool result;
			try
			{
				num = (short)176881667;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					bool flag;
					switch (num2)
					{
					case 0:
						if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveMainView == global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("雃Ʂ곇ꏉꏋ뷍蛏믑뇓ꇕ", a_))
						{
							num = (short)260440065;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7A;
					case 1:
						num = (short)1991639045;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						num = (short)2117851408;
						short num3 = num;
						num = (short)1640945936;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_AD;
						default:
							num = (short)830472192;
							if (num != 0)
							{
							}
							num = (short)1285292032;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 3:
						switch (0)
						{
						case 0:
							goto IL_49;
						}
						continue;
					case 4:
						flag = false;
						goto IL_16C;
					case 5:
						goto IL_AD;
					case 6:
						goto IL_184;
					}
					IL_49:
					if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveMainModule == global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("雃Ʂ곇ꏉꏋ", a_))
					{
						num = (short)1830813698;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_7A:
					num = (short)743440388;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_16C:
					result = flag;
					num = (short)751632390;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_AD:
					flag = this.f.PrepareResetIndentifiersCommand.CanExecute(new object[]
					{
						base.SelectedItems
					});
					goto IL_16C;
				}
				IL_184:;
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
				result = false;
			}
			num = (short)1470627840;
			short num4 = num;
			num = (short)864944129;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00012920 File Offset: 0x00010B20
		private bool m()
		{
			int a_ = 11;
			short num;
			bool result;
			try
			{
				num = (short)369229827;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					bool flag;
					switch (num2)
					{
					case 0:
						if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveMainView == global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("ꃀꟂ계꣆뫈鷊꓌꫎ꛐ", a_))
						{
							num = (short)1430388737;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7B;
					case 1:
						num = (short)756088837;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						num = (short)279418275;
						short num3 = num;
						num = (short)704026019;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_AE;
						default:
							num = (short)1386741760;
							if (num != 0)
							{
							}
							num = (short)641335296;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 3:
						switch (0)
						{
						case 0:
							goto IL_4A;
						}
						continue;
					case 4:
						flag = false;
						goto IL_16D;
					case 5:
						goto IL_AE;
					case 6:
						goto IL_186;
					}
					IL_4A:
					if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveMainModule == global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("ꃀꟂ계꣆", a_))
					{
						num = (short)1356398594;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_7B:
					num = (short)2061303812;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_16D:
					result = flag;
					num = (short)963706886;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_AE:
					flag = this.f.PrepareScheduleJobCommand.CanExecute(new object[]
					{
						base.SelectedItems
					});
					goto IL_16D;
				}
				IL_186:;
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
				result = false;
			}
			num = (short)1770979328;
			short num4 = num;
			num = (short)394199041;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00012B30 File Offset: 0x00010D30
		private bool l()
		{
			short num;
			bool result;
			try
			{
				num = (short)1618261776;
				short num2 = num;
				num = (short)1203091216;
				switch (num2 == num)
				{
				}
				num = (short)1823408128;
				if (num != 0)
				{
				}
				num = (short)1669332993;
				if (num != 0)
				{
				}
				result = this.f.PrepareSelectTemplateCommand.CanExecute(new object[]
				{
					base.SelectedItems
				});
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
				result = false;
			}
			num = (short)1263271936;
			short num3 = num;
			return result;
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00012C18 File Offset: 0x00010E18
		private bool k()
		{
			short num;
			bool result;
			try
			{
				num = (short)53817114;
				short num2 = num;
				num = (short)180891418;
				switch (num2 == num)
				{
				}
				num = (short)1031274497;
				if (num != 0)
				{
				}
				num = (short)1965948928;
				if (num != 0)
				{
				}
				result = this.f.PrepareWiFiPasswordValidationCommand.CanExecute(new object[]
				{
					base.SelectedItems
				});
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
				result = false;
			}
			num = (short)300417024;
			short num3 = num;
			return result;
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00012D00 File Offset: 0x00010F00
		private bool j()
		{
			int a_ = 14;
			short num;
			bool result;
			try
			{
				num = (short)1119551491;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					bool flag;
					switch (num2)
					{
					case 0:
						if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveMainView == global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("郁ꗃꋅꇇꗉ뿋飍맏럑ꏓ", a_))
						{
							num = (short)9502721;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7A;
					case 1:
						num = (short)13107205;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						num = (short)521015254;
						short num3 = num;
						num = (short)888213462;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_AE;
						default:
							num = (short)1791623168;
							if (num != 0)
							{
							}
							num = (short)1828847616;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 3:
						switch (0)
						{
						case 0:
							goto IL_4A;
						}
						continue;
					case 4:
						flag = false;
						goto IL_16E;
					case 5:
						goto IL_AE;
					case 6:
						goto IL_187;
					}
					IL_4A:
					if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveMainModule == global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("郁ꗃꋅꇇꗉ", a_))
					{
						num = (short)422641666;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_7A:
					num = (short)185663492;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_16E:
					result = flag;
					num = (short)324927494;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_AE:
					flag = this.f.PrepareUpgradeFirmwareCommand.CanExecute(new object[]
					{
						base.SelectedItems
					});
					goto IL_16E;
				}
				IL_187:
				num = (short)877920257;
				if (num != 0)
				{
				}
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
				result = false;
			}
			num = (short)44040192;
			short num4 = num;
			return result;
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00012F10 File Offset: 0x00011110
		private bool i()
		{
			short num = (short)1557323118;
			short num2 = num;
			num = (short)1841945966;
			switch (num2 == num)
			{
			}
			num = (short)1862008832;
			if (num != 0)
			{
			}
			num = (short)664010752;
			short num3 = num;
			num = (short)233832449;
			if (num != 0)
			{
			}
			return this.f.UpgradeLanguageInRadioCommand.CanExecute(new object[]
			{
				base.SelectedItems
			});
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00012FDC File Offset: 0x000111DC
		private bool h()
		{
			int a_ = 15;
			short num;
			bool result;
			try
			{
				num = (short)1254031363;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					bool flag;
					switch (num2)
					{
					case 0:
						if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveMainView == global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("釂꓄ꏆꃈ꓊뻌駎룐뛒ꋔ", a_))
						{
							num = (short)1149566977;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7B;
					case 1:
						num = (short)1452474373;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						num = (short)2035341776;
						short num3 = num;
						num = (short)1596250576;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_AE;
						default:
							num = (short)849805312;
							if (num != 0)
							{
							}
							num = (short)167575552;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 3:
						switch (0)
						{
						case 0:
							goto IL_49;
						}
						continue;
					case 4:
						flag = false;
						goto IL_16D;
					case 5:
						goto IL_AE;
					case 6:
						goto IL_186;
					}
					IL_49:
					if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveMainModule == global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("釂꓄ꏆꃈ꓊", a_))
					{
						num = (short)1475215362;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_7B:
					num = (short)1332215812;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_16D:
					result = flag;
					num = (short)973275142;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_AE:
					flag = this.f.ASTROPrepareQueryUpdateRadioCommand.CanExecute(new object[]
					{
						base.SelectedItems
					});
					goto IL_16D;
				}
				IL_186:
				num = (short)1900150785;
				if (num != 0)
				{
				}
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
				result = false;
			}
			num = (short)328794112;
			short num4 = num;
			return result;
		}

		// Token: 0x0600010F RID: 271 RVA: 0x000131EC File Offset: 0x000113EC
		private bool g()
		{
			int a_ = 13;
			short num;
			bool result;
			try
			{
				num = (short)1373831171;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					bool flag;
					switch (num2)
					{
					case 0:
						if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveMainView == global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("鏀ꋂꇄ껆ꛈ룊鯌ꛎ듐ꓒ", a_))
						{
							num = (short)44630017;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7C;
					case 1:
						num = (short)1506213893;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						num = (short)1679498937;
						short num3 = num;
						num = (short)852434617;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_AD;
						default:
							num = (short)1332477952;
							if (num != 0)
							{
							}
							num = (short)1470169088;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 3:
						switch (0)
						{
						case 0:
							goto IL_4B;
						}
						continue;
					case 4:
						flag = false;
						goto IL_16B;
					case 5:
						goto IL_AD;
					case 6:
						goto IL_183;
					}
					IL_4B:
					if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveMainModule == global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("鏀ꋂꇄ껆ꛈ", a_))
					{
						num = (short)564592642;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_7C:
					num = (short)473759748;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_16B:
					result = flag;
					num = (short)1405419526;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_AD:
					flag = this.f.AstroPrepareFlashPortCommand.CanExecute(new object[]
					{
						base.SelectedItems
					});
					goto IL_16B;
				}
				IL_183:;
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
				result = false;
			}
			num = (short)1749549056;
			short num4 = num;
			num = (short)1011482625;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x06000110 RID: 272 RVA: 0x000133F8 File Offset: 0x000115F8
		private bool b(string A_0)
		{
			short num2;
			bool result;
			try
			{
				switch (0)
				{
				case 0:
					goto IL_20;
				}
				int num;
				string empty;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						if (!global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.GroupService.ValidateGroupName(this.SelectedNavigationItem, A_0, out empty))
						{
							num2 = (short)529334274;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_10F;
					case 1:
						goto IL_10D;
					case 2:
					{
						global::Motorola.CommonCPS.RadioManagement.InteractionHelper.InteractionFactory.GetInstance().ShowNotificationDialog(empty, global::Motorola.CommonCPS.ResourceRepository.Resources.Validator_MessageBox_Caption);
						result = false;
						num2 = (short)434986010;
						short num3 = num2;
						num2 = (short)1105681434;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_10F;
						default:
							num2 = (short)206766080;
							if (num2 != 0)
							{
							}
							num2 = (short)699400193;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 3:
						goto IL_129;
					}
					goto IL_20;
					IL_10F:
					result = true;
					num2 = (short)1726283779;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_10D:
				IL_129:
				goto IL_137;
				IL_20:
				num2 = (short)1446313985;
				if (num2 != 0)
				{
				}
				empty = string.Empty;
				num2 = (short)571408384;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
				result = false;
			}
			IL_137:
			num2 = (short)606208000;
			short num4 = num2;
			return result;
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00013584 File Offset: 0x00011784
		private bool f()
		{
			int a_ = 14;
			short num;
			bool result;
			try
			{
				num = (short)540344323;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					bool flag;
					switch (num2)
					{
					case 0:
						if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveMainView == global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("郁ꗃꋅꇇꗉ뿋飍맏럑ꏓ", a_))
						{
							num = (short)982515713;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_79;
					case 1:
						num = (short)386531333;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						num = (short)185705566;
						short num3 = num;
						num = (short)251176030;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_A7;
						default:
							num = (short)626655232;
							if (num != 0)
							{
							}
							num = (short)1691680768;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 3:
						switch (0)
						{
						case 0:
							goto IL_49;
						}
						continue;
					case 4:
						flag = false;
						goto IL_153;
					case 5:
						goto IL_A7;
					case 6:
						goto IL_16C;
					}
					IL_49:
					if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveMainModule == global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("郁ꗃꋅꇇꗉ", a_))
					{
						num = (short)1141047298;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_79:
					num = (short)1050673156;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_153:
					result = flag;
					num = (short)1605959686;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_A7:
					flag = (base.SelectedItems.Count == 1);
					goto IL_153;
				}
				IL_16C:;
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
				result = false;
			}
			num = (short)75169792;
			short num4 = num;
			num = (short)1351876609;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x06000112 RID: 274 RVA: 0x0001377C File Offset: 0x0001197C
		private bool a(object[] A_0)
		{
			int a_ = 17;
			short num;
			bool result;
			try
			{
				num = (short)206176259;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					bool flag;
					switch (num2)
					{
					case 0:
						if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveMainView == global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("韄ꛆ귈ꋊꋌ볎蟐뫒냔ꃖ", a_))
						{
							num = (short)2108882945;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_79;
					case 1:
						num = (short)1262092293;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						num = (short)1824735846;
						short num3 = num;
						num = (short)450708070;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_AB;
						default:
							num = (short)1059258368;
							if (num != 0)
							{
							}
							num = (short)922615808;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 3:
						switch (0)
						{
						case 0:
							goto IL_49;
						}
						continue;
					case 4:
						flag = false;
						goto IL_15E;
					case 5:
						goto IL_AB;
					case 6:
						goto IL_177;
					}
					IL_49:
					if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveMainModule == global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("韄ꛆ귈ꋊꋌ", a_))
					{
						num = (short)117768194;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_79:
					num = (short)1831993348;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_15E:
					result = flag;
					num = (short)2028142598;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_AB:
					flag = this.f.MoveDeviceCommand.CanExecute(A_0);
					goto IL_15E;
				}
				IL_177:;
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
				result = false;
			}
			num = (short)282001408;
			short num4 = num;
			num = (short)712376321;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00013980 File Offset: 0x00011B80
		private bool e()
		{
			int a_ = 18;
			short num;
			bool result;
			try
			{
				num = (short)1920729091;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					bool flag;
					switch (num2)
					{
					case 0:
						if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveMainView == global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("铅꧇껉ꗋꇍꏏ蓑뷓돕꿗", a_))
						{
							num = (short)866648065;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7B;
					case 1:
						num = (short)140050437;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						num = (short)1762695279;
						short num3 = num;
						num = (short)316512367;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_AD;
						default:
							num = (short)1265303552;
							if (num != 0)
							{
							}
							num = (short)1394540544;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 3:
						switch (0)
						{
						case 0:
							goto IL_4A;
						}
						continue;
					case 4:
						flag = false;
						goto IL_176;
					case 5:
						goto IL_AD;
					case 6:
						goto IL_18F;
					}
					IL_4A:
					if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveMainModule == global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("铅꧇껉ꗋꇍ", a_))
					{
						num = (short)46333954;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_7B:
					num = (short)919207940;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_176:
					result = flag;
					num = (short)440336390;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_AD:
					flag = this.f.PrepareMoveDeviceBatchCommand.CanExecute(new object[]
					{
						base.SelectedItems,
						base.NavigationItems
					});
					goto IL_176;
				}
				IL_18F:;
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
				result = false;
			}
			num = (short)1189740544;
			short num4 = num;
			num = (short)1034485761;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00013B98 File Offset: 0x00011D98
		private bool d()
		{
			short num;
			bool result;
			try
			{
				num = (short)966954240;
				short num2 = num;
				num = (short)1934003456;
				switch (num2 == num)
				{
				}
				num = (short)926089216;
				if (num != 0)
				{
				}
				result = this.f.PrepareSelectCodeplugVersionCommand.CanExecute(new object[]
				{
					base.SelectedItems
				});
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
				result = false;
			}
			num = (short)532021248;
			short num3 = num;
			num = (short)1206386689;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00013C80 File Offset: 0x00011E80
		private bool c()
		{
			short num;
			bool result;
			try
			{
				num = (short)534426536;
				short num2 = num;
				num = (short)973452200;
				switch (num2 == num)
				{
				}
				num = (short)127533056;
				if (num != 0)
				{
				}
				result = this.f.CopyRadioIdentityCommand.CanExecute(new object[]
				{
					base.SelectedItems
				});
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
				result = false;
			}
			num = (short)1182334976;
			short num3 = num;
			num = (short)364249089;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00013D6C File Offset: 0x00011F6C
		private bool b()
		{
			short num;
			bool result;
			try
			{
				num = (short)380395058;
				short num2 = num;
				num = (short)310009394;
				switch (num2 == num)
				{
				}
				num = (short)210108417;
				if (num != 0)
				{
				}
				num = (short)404553728;
				if (num != 0)
				{
				}
				result = this.f.PasteRadioIdentityCommand.CanExecute(new object[]
				{
					base.SelectedItems
				});
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
				result = false;
			}
			num = (short)243007488;
			short num3 = num;
			return result;
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00013E54 File Offset: 0x00012054
		private bool b(global::Motorola.CommonCPS.RadioManagement.UIModels.Group A_0)
		{
			short num;
			bool result;
			try
			{
				num = (short)219166154;
				short num2 = num;
				num = (short)287061450;
				switch (num2 == num)
				{
				}
				num = (short)1323302912;
				if (num != 0)
				{
				}
				num = (short)1886846977;
				if (num != 0)
				{
				}
				result = this.f.UpdateGroupCommand.CanExecute(global::System.Array.Empty<object>());
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
				result = false;
			}
			num = (short)1475477504;
			short num3 = num;
			return result;
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00013F34 File Offset: 0x00012134
		private bool a(global::Motorola.CommonCPS.RadioManagement.UIModels.Group A_0)
		{
			short num;
			bool result;
			try
			{
				num = (short)1868812675;
				short num2 = num;
				num = (short)836620675;
				switch (num2 == num)
				{
				}
				num = (short)2140667905;
				if (num != 0)
				{
				}
				num = (short)270008320;
				if (num != 0)
				{
				}
				result = this.f.RefreshGroupCommand.CanExecute(global::System.Array.Empty<object>());
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
				result = false;
			}
			num = (short)1255342080;
			short num3 = num;
			return result;
		}

		// Token: 0x06000119 RID: 281 RVA: 0x00014014 File Offset: 0x00012214
		public void EndEditGroupTree()
		{
			short num = (short)1456080573;
			short num2 = num;
			num = (short)1434781373;
			switch (num2 == num)
			{
			default:
			{
				num = (short)505937920;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1805516801;
			if (num != 0)
			{
			}
			num = (short)845479936;
			if (num != 0)
			{
			}
			base.EventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.EndGrouplistEditModeRequestedEvent>().Publish(null);
		}

		// Token: 0x0600011A RID: 282 RVA: 0x000140CC File Offset: 0x000122CC
		private void a(global::System.Collections.Generic.List<global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.Group>> A_0)
		{
			short num = (short)1382047580;
			short num2 = num;
			num = (short)944136028;
			switch (num2 == num)
			{
			default:
			{
				num = (short)477888512;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1080295425;
			if (num != 0)
			{
			}
			num = (short)613351424;
			if (num != 0)
			{
			}
			A_0.Add(base.NavigationItems);
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00014180 File Offset: 0x00012380
		private void a(global::Motorola.CommonCPS.RadioManagement.UIModels.AddRadioContext A_0)
		{
			short num = (short)417526058;
			short num2 = num;
			num = (short)852685098;
			switch (num2 == num)
			{
			default:
			{
				num = (short)461766656;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)351731713;
			if (num != 0)
			{
			}
			num = (short)2094989312;
			if (num != 0)
			{
			}
			this.ShowAddRadioDialogRequest.Raise(new global::Motorola.CommonCPS.RadioManagement.Radio.AddRadioViewModel(base.EventAggregator, this.g, this.f, A_0)
			{
				Title = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Title_NewRadio
			});
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00014258 File Offset: 0x00012458
		private void a(global::Motorola.CommonCPS.RadioManagement.UIModels.ModifyCodeplugPasswordContext A_0)
		{
			short num = (short)2012217345;
			if (num != 0)
			{
			}
			num = (short)942211072;
			short num2 = num;
			num = (short)1325050119;
			short num3 = num;
			num = (short)2109974791;
			switch (num3 == num)
			{
			}
			num = (short)1330642944;
			if (num != 0)
			{
			}
			this.ShowModifyCodeplugPasswordDialogRequest.Raise(new global::Motorola.CommonCPS.RadioManagement.Radio.ModifyCodeplugPasswordViewModel(base.EventAggregator, this.f, A_0)
			{
				Title = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Title_ModifyCodeplugPassword
			});
		}

		// Token: 0x0600011D RID: 285 RVA: 0x0001432C File Offset: 0x0001252C
		private void a(global::Motorola.CommonCPS.RadioManagement.UIModels.ResetRadioPasswordContext A_0)
		{
			short num = (short)943872905;
			short num2 = num;
			num = (short)1804884873;
			switch (num2 == num)
			{
			default:
			{
				num = (short)895221760;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)251265025;
			if (num != 0)
			{
			}
			num = (short)127664128;
			if (num != 0)
			{
			}
			this.ShowResetRadioPasswordDialogRequest.Raise(new global::Motorola.CommonCPS.RadioManagement.Radio.ResetRadioPasswordViewModel(base.EventAggregator, this.f, A_0)
			{
				Title = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Title_ResetRadioPassword
			});
		}

		// Token: 0x0600011E RID: 286 RVA: 0x000143FC File Offset: 0x000125FC
		private void a(global::Motorola.CommonCPS.RadioManagement.UIModels.ImportRadiosContext A_0)
		{
			short num = (short)269373676;
			short num2 = num;
			num = (short)427512044;
			switch (num2 == num)
			{
			default:
			{
				num = (short)388628480;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1718484993;
			if (num != 0)
			{
			}
			num = (short)31195136;
			if (num != 0)
			{
			}
			this.ShowImportRadiosDialogRequest.Raise(new global::Motorola.CommonCPS.RadioManagement.Radio.ImportRadiosViewModel(base.EventAggregator, this.f, A_0)
			{
				Title = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Title_ImportRadios
			});
		}

		// Token: 0x0600011F RID: 287 RVA: 0x000144D0 File Offset: 0x000126D0
		private void a(global::Motorola.CommonCPS.RadioManagement.UIModels.ShowLanguagePacksContext A_0)
		{
			short num = (short)1109458945;
			if (num != 0)
			{
			}
			num = (short)287375360;
			short num2 = num;
			num = (short)1006768021;
			short num3 = num;
			num = (short)606343061;
			switch (num3 == num)
			{
			}
			num = (short)1061945344;
			if (num != 0)
			{
			}
			this.ShowLanguagePacksDialogRequest.Raise(new global::Motorola.CommonCPS.RadioManagement.Radio.ShowLanguagePacksViewModel(base.EventAggregator, this.f, A_0)
			{
				Title = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Title_ShowLPDetails
			});
		}

		// Token: 0x06000120 RID: 288 RVA: 0x000145A4 File Offset: 0x000127A4
		private void a(global::Motorola.CommonCPS.RadioManagement.UIModels.ShowVAPacksContext A_0)
		{
			short num = (short)110624769;
			if (num != 0)
			{
			}
			num = (short)919076864;
			short num2 = num;
			num = (short)468517745;
			short num3 = num;
			num = (short)1356858225;
			switch (num3 == num)
			{
			}
			num = (short)168624128;
			if (num != 0)
			{
			}
			this.ShowVAPacksDialogRequest.Raise(new global::Motorola.CommonCPS.RadioManagement.Radio.ShowVAPacksViewModel(base.EventAggregator, this.f, A_0)
			{
				Title = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Title_ShowVADetails
			});
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00014678 File Offset: 0x00012878
		private void a(global::Motorola.CommonCPS.RadioManagement.UIModels.ShowMismatchOptionsContext A_0)
		{
			short num = (short)1848509489;
			short num2 = num;
			num = (short)704840753;
			switch (num2 == num)
			{
			default:
			{
				num = (short)397606912;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)540672001;
			if (num != 0)
			{
			}
			num = (short)720306176;
			if (num != 0)
			{
			}
			this.ShowMismatchOptionsDialogRequest.Raise(new global::Motorola.CommonCPS.RadioManagement.Radio.ShowMismatchOptionsViewModel(base.EventAggregator, this.f, A_0)
			{
				Title = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Title_ShowFeatureSets
			});
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00014748 File Offset: 0x00012948
		private void a(global::Motorola.CommonCPS.RadioManagement.UIModels.SelectGeneralPackageContext A_0)
		{
			short num = (short)572189081;
			short num2 = num;
			num = (short)296216985;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1402470400;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)626327552;
			if (num != 0)
			{
			}
			num = (short)1508835329;
			if (num != 0)
			{
			}
			this.ShowSelectProvisioningPackageDialogRequest.Raise(new global::Motorola.CommonCPS.RadioManagement.Radio.SelectProvisioningPackageViewModel(base.EventAggregator, this.f, A_0)
			{
				Title = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Title_SelectPackage
			});
		}

		// Token: 0x06000123 RID: 291 RVA: 0x0001481C File Offset: 0x00012A1C
		private void a(global::Motorola.CommonCPS.RadioManagement.UIModels.MoveDeviceContext A_0)
		{
			short num = (short)1373437953;
			if (num != 0)
			{
			}
			num = (short)1303379968;
			short num2 = num;
			num = (short)1298071401;
			short num3 = num;
			num = (short)657194857;
			switch (num3 == num)
			{
			}
			num = (short)908722176;
			if (num != 0)
			{
			}
			this.ShowMoveDeviceDialogRequest.Raise(new global::Motorola.CommonCPS.RadioManagement.Radio.MoveGroupViewModel(base.EventAggregator, this.f, A_0, false)
			{
				Title = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Title_MoveGroup
			});
		}

		// Token: 0x06000124 RID: 292 RVA: 0x000148EC File Offset: 0x00012AEC
		private void a(global::Motorola.CommonCPS.RadioManagement.UIModels.UpdateRadioContext A_0)
		{
			short num = (short)1414831247;
			short num2 = num;
			num = (short)2044959887;
			switch (num2 == num)
			{
			default:
			{
				num = (short)615645184;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)434438145;
			if (num != 0)
			{
			}
			num = (short)1420034048;
			if (num != 0)
			{
			}
			this.ShowUpdateRadioDataDialogRequest.Raise(new global::Motorola.CommonCPS.RadioManagement.Radio.UpdateRadioDataViewModel(base.EventAggregator, this.f, A_0)
			{
				Title = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Title_UpdateRadio
			});
		}

		// Token: 0x06000125 RID: 293 RVA: 0x000149BC File Offset: 0x00012BBC
		private void a(global::Motorola.CommonCPS.RadioManagement.UIModels.ResetIdentifiersContext A_0)
		{
			short num = (short)844278823;
			short num2 = num;
			num = (short)1223601191;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1825898496;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1812987904;
			if (num != 0)
			{
			}
			num = (short)892796929;
			if (num != 0)
			{
			}
			this.ShowResetIdentifiersDialogRequest.Raise(new global::Motorola.CommonCPS.RadioManagement.Radio.ResetIdentifiersViewModel(base.EventAggregator, this.f, A_0)
			{
				Title = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Title_ResetIdentifiers
			});
		}

		// Token: 0x06000126 RID: 294 RVA: 0x00014A90 File Offset: 0x00012C90
		private void a(global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext A_0)
		{
			short num = (short)352067563;
			short num2 = num;
			num = (short)1081941995;
			switch (num2 == num)
			{
			default:
			{
				num = (short)433651712;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)327090177;
			if (num != 0)
			{
			}
			num = (short)965214208;
			if (num != 0)
			{
			}
			this.ShowScheduleJobDialogRequest.Raise(new global::Motorola.CommonCPS.RadioManagement.Radio.ScheduleJobViewModel(base.EventAggregator, this.f, A_0, new global::Motorola.CommonCPS.RadioManagement.LocalService.ScheduleJobContextValidator(), this.e)
			{
				Title = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Title_ScheduleJob
			});
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00014B6C File Offset: 0x00012D6C
		private void a(global::Motorola.CommonCPS.RadioManagement.UIModels.SelectFirmwareContext A_0)
		{
			int a_ = 19;
			short num = (short)480509953;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)2004013135;
				short num3 = num;
				num = (short)1566560335;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1120731136;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						goto IL_E9;
					case 1:
					{
						num = (short)1438056448;
						short num4 = num;
						switch (0)
						{
						case 0:
							goto IL_B5;
						}
						continue;
					}
					case 2:
						goto IL_156;
					case 3:
						this.ShowSelectFirmwareDialogRequest.Raise(new global::Motorola.CommonCPS.RadioManagement.Radio.SelectFirmwareViewModel(base.EventAggregator, this.f, A_0)
						{
							Title = (A_0.IsRecover ? global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_ContextMenu_Recover : global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_ContextMenu_Upgrade)
						});
						num = (short)1794310146;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_B5:
					if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveMainModule == global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("闆꣈꿊꓌ꃎ", a_))
					{
						num = (short)1456668672;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				IL_E9:
				num = (short)1011220483;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_156:
			num = (short)2014314497;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00014CF8 File Offset: 0x00012EF8
		private void a(global::Motorola.CommonCPS.RadioManagement.UIModels.SelectCodeplugVersionContext A_0)
		{
			int a_ = 7;
			short num = (short)512557056;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_3A;
					}
					continue;
				case 1:
					goto IL_E2;
				case 2:
					goto IL_123;
				}
				IL_3A:
				if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveMainModule == global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("\udcbc\udbbeꣀ곂", a_))
				{
					num = (short)135047758;
					short num3 = num;
					num = (short)2028776014;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_E2;
					case 1:
						break;
					default:
					{
						num = (short)1377239040;
						short num4 = num;
						break;
					}
					}
					num = (short)1383071744;
					if (num != 0)
					{
					}
					num = (short)1524039681;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				return;
				IL_E2:
				this.ShowSelectCodeplugVersionDialogRequest.Raise(new global::Motorola.CommonCPS.RadioManagement.Radio.SelectCodeplugVersionViewModel(base.EventAggregator, this.f, A_0)
				{
					Title = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_ContextMenu_Upgrade
				});
				num = (short)2084044802;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_123:
			num = (short)892469249;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000129 RID: 297 RVA: 0x00014E54 File Offset: 0x00013054
		private void a(global::Motorola.CommonCPS.RadioManagement.UIModels.SelectRunningRadiosContext A_0)
		{
			short num = (short)617920645;
			short num2 = num;
			num = (short)716748933;
			switch (num2 == num)
			{
			default:
			{
				num = (short)68288512;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)529465345;
			if (num != 0)
			{
			}
			num = (short)110297088;
			if (num != 0)
			{
			}
			this.ShowSelectRunningRadiosDialogRequest.Raise(new global::Motorola.CommonCPS.RadioManagement.Radio.SelectRunningRadiosViewModel(base.EventAggregator, this.f, A_0)
			{
				Title = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Title_SelectRadios
			});
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00014F28 File Offset: 0x00013128
		private void a(global::Motorola.CommonCPS.RadioManagement.UIModels.SelectTemplateContext A_0)
		{
			short num = (short)1886446439;
			short num2 = num;
			num = (short)1583342439;
			switch (num2 == num)
			{
			default:
			{
				num = (short)2146435072;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)586088449;
			if (num != 0)
			{
			}
			num = (short)886702080;
			if (num != 0)
			{
			}
			this.ShowSelectTemplateDialogRequest.Raise(new global::Motorola.CommonCPS.RadioManagement.Radio.SelectTemplateViewModel(base.EventAggregator, this.f, A_0)
			{
				Title = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Title_SelectTemplate
			});
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00014FFC File Offset: 0x000131FC
		private void a(global::Motorola.CommonCPS.RadioManagement.UIModels.WiFiPasswordValidationContext A_0)
		{
			short num = (short)1745798225;
			short num2 = num;
			num = (short)328254545;
			switch (num2 == num)
			{
			default:
			{
				num = (short)64684032;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2012807169;
			if (num != 0)
			{
			}
			num = (short)255590400;
			if (num != 0)
			{
			}
			this.ShowWiFiPasswordValidationDialogRequest.Raise(new global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel(base.EventAggregator, this.f, A_0)
			{
				Title = global::Motorola.CommonCPS.ResourceRepository.Resources.WiFi_Password_Validation
			});
		}

		// Token: 0x0600012C RID: 300 RVA: 0x000150D0 File Offset: 0x000132D0
		private void a(global::Motorola.CommonCPS.RadioManagement.UIModels.SelectRadiosContext A_0)
		{
			short num = (short)167318017;
			short num2 = num;
			num = (short)996807169;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1735065600;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)166002689;
			if (num != 0)
			{
			}
			num = (short)781451264;
			if (num != 0)
			{
			}
			this.ShowSelectRadiosDialogRequest.Raise(new global::Motorola.CommonCPS.RadioManagement.Radio.SelectRadiosViewModel(base.EventAggregator, this.f, A_0)
			{
				Title = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Title_SelectRadios_NotSuitForConfiguration
			});
		}

		// Token: 0x0600012D RID: 301 RVA: 0x000151A0 File Offset: 0x000133A0
		private void a(global::Motorola.CommonCPS.RadioManagement.UIModels.SelectWarningRadiostoScheduleJobContext A_0)
		{
			short num = (short)1287354075;
			short num2 = num;
			num = (short)1031829211;
			switch (num2 == num)
			{
			default:
			{
				num = (short)395051008;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)345833473;
			if (num != 0)
			{
			}
			num = (short)2054422528;
			if (num != 0)
			{
			}
			this.ShowSelectWarningRadiostoScheduleJobDialogRequest.Raise(new global::Motorola.CommonCPS.RadioManagement.Radio.SelectWarningRadiosViewModel(base.EventAggregator, this.f, A_0)
			{
				Title = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Title_SelectRadios
			});
		}

		// Token: 0x0600012E RID: 302 RVA: 0x00015274 File Offset: 0x00013474
		private void a(global::Motorola.CommonCPS.RadioManagement.UIModels.CopyPasteWarningContext A_0)
		{
			short num = (short)1117168896;
			short num2 = num;
			num = (short)1937548544;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1489174528;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)601030657;
			if (num != 0)
			{
			}
			num = (short)2038824960;
			if (num != 0)
			{
			}
			this.ShowCopyPasteWarningContextDialogRequest.Raise(new global::Motorola.CommonCPS.RadioManagement.Radio.CopyPasteWarningViewModel(base.EventAggregator, this.f, A_0)
			{
				Title = global::Motorola.CommonCPS.ResourceRepository.Resources.RM_RadioIdentityTransferWarning
			});
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00015344 File Offset: 0x00013544
		private void c(object A_0)
		{
			int a_ = 11;
			short num;
			try
			{
				num = (short)1770782723;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_148;
					case 1:
						if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveMainView == global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("ꃀꟂ계꣆뫈鷊꓌꫎ꛐ", a_))
						{
							num = (short)84410373;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_148;
					case 2:
						num = (short)994639873;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						num = (short)1543115241;
						short num3 = num;
						num = (short)2030834153;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_C2;
						default:
							num = (short)647430144;
							if (num != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_8F;
							}
							continue;
						}
						break;
					}
					case 4:
						goto IL_160;
					case 5:
						goto IL_C2;
					}
					IL_8F:
					if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveMainModule == global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("ꃀꟂ계꣆", a_))
					{
						num = (short)135921666;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_148;
					IL_C2:
					this.f.PrintViewCommand.Execute(new object[]
					{
						base.SelectedItems
					});
					num = (short)630194176;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_148:
					num = (short)248053764;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_160:;
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
			}
			num = (short)254803968;
			short num4 = num;
			num = (short)504102913;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000130 RID: 304 RVA: 0x0001552C File Offset: 0x0001372C
		private void b(object A_0)
		{
			int a_ = 13;
			short num;
			try
			{
				num = (short)1502019587;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_16F;
					case 1:
						if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveMainView == global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("鏀ꋂꇄ껆ꛈ룊鯌ꛎ듐ꓒ", a_))
						{
							num = (short)2139684869;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_16F;
					case 2:
						num = (short)1786314753;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						num = (short)552469353;
						short num3 = num;
						num = (short)1985807209;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_E8;
						default:
							num = (short)549584896;
							if (num != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_8F;
							}
							continue;
						}
						break;
					}
					case 4:
						goto IL_186;
					case 5:
						goto IL_E8;
					}
					IL_8F:
					num = (short)293994497;
					if (num != 0)
					{
					}
					if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveMainModule == global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("鏀ꋂꇄ껆ꛈ", a_))
					{
						num = (short)2110193666;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_16F;
					IL_E8:
					this.f.PrintPreviewCommand.Execute(new object[]
					{
						base.SelectedItems
					});
					num = (short)496369664;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_16F:
					num = (short)2064842756;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_186:;
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
			}
			num = (short)875954176;
			short num4 = num;
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00015714 File Offset: 0x00013914
		private void a(string A_0)
		{
			short num = (short)2106555086;
			short num2 = num;
			num = (short)131365582;
			switch (num2 == num)
			{
			default:
			{
				num = (short)379715584;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)699793409;
			if (num != 0)
			{
			}
			num = (short)851312640;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000132 RID: 306 RVA: 0x000157C0 File Offset: 0x000139C0
		private void a(object A_0)
		{
			short num = (short)1223827496;
			short num2 = num;
			num = (short)1060118568;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1474953216;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1377107969;
			if (num != 0)
			{
			}
			num = (short)472186880;
			if (num != 0)
			{
			}
			base.NavigationItems = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.GroupService.GetGroupsTree();
			base.EventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.SelectGroupInGroupsView>().Publish(this.selectedNavigationItem);
		}

		// Token: 0x06000133 RID: 307 RVA: 0x00015894 File Offset: 0x00013A94
		protected override void OnSelectedItemsCollectionChanged()
		{
			short num = (short)1934753793;
			if (num != 0)
			{
			}
			num = (short)1925644288;
			short num2 = num;
			num = (short)1893150315;
			short num3 = num;
			num = (short)850800235;
			switch (num3 == num)
			{
			}
			num = (short)258473984;
			if (num != 0)
			{
			}
			base.CommandProxy.PrepareAddRadioCommand.RaiseCanExecuteChanged();
			this.EditCodeplugCommand.RaiseCanExecuteChanged();
			this.PrepareSelectTemplateCommand.RaiseCanExecuteChanged();
			this.PrepareWiFiPasswordValidationCommand.RaiseCanExecuteChanged();
			this.UpgradeCodeplugVersionCommand.RaiseCanExecuteChanged();
			this.PrepareModifyCodeplugPasswordCommand.RaiseCanExecuteChanged();
			this.PrepareResetRadioPasswordCommand.RaiseCanExecuteChanged();
			base.CommandProxy.AddGroupCommand.RaiseCanExecuteChanged();
			base.CommandProxy.PrepareRenameGroupCommand.RaiseCanExecuteChanged();
			base.CommandProxy.DeleteGroupCommand.RaiseCanExecuteChanged();
			base.CommandProxy.CancelJobCommand.RaiseCanExecuteChanged();
			base.CommandProxy.CompleteJobCommand.RaiseCanExecuteChanged();
			base.CommandProxy.DeleteRadiosCommand.RaiseCanExecuteChanged();
			base.CommandProxy.ExportDVRSCommand.RaiseCanExecuteChanged();
			base.CommandProxy.ExportRadioCommand.RaiseCanExecuteChanged();
			base.CommandProxy.PrepareScheduleJobCommand.RaiseCanExecuteChanged();
			base.CommandProxy.PrepareSelectFirmwareCommand.RaiseCanExecuteChanged();
			base.CommandProxy.PrepareMoveDeviceCommand.RaiseCanExecuteChanged();
			base.CommandProxy.PrepareUpdateRadioDataCommand.RaiseCanExecuteChanged();
			base.CommandProxy.PrepareSelectFlashPortCommand.RaiseCanExecuteChanged();
			base.CommandProxy.ShowRadioDetailsCommand.RaiseCanExecuteChanged();
			base.CommandProxy.DiscardChangesCommand.RaiseCanExecuteChanged();
			base.CommandProxy.PrintViewCommand.RaiseCanExecuteChanged();
			base.CommandProxy.PrintViewPreviewCommand.RaiseCanExecuteChanged();
			this.CopyRadioIdentityCommand.RaiseCanExecuteChanged();
			this.PasteRadioIdentityCommand.RaiseCanExecuteChanged();
			this.UpgradeLanguagePackCommnand.RaiseCanExecuteChanged();
		}

		// Token: 0x06000134 RID: 308 RVA: 0x00015ABC File Offset: 0x00013CBC
		protected override global::System.ComponentModel.ICollectionView GetItems(global::Motorola.CommonCPS.RadioManagement.UIModels.Group group)
		{
			short num;
			global::System.ComponentModel.ICollectionView result;
			try
			{
				num = (short)748748802;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::Motorola.CommonCPS.Server.CommonDBConstants.WorkMode workMode;
					switch (num2)
					{
					case 0:
						goto IL_54;
					case 1:
					{
						num = (short)401466307;
						short num3 = num;
						num = (short)2109858755;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_54;
						default:
							num = (short)605487104;
							if (num != 0)
							{
							}
							workMode = global::Motorola.CommonCPS.Server.CommonDBConstants.WorkMode.Configuration;
							goto IL_D3;
						}
						break;
					}
					case 2:
						switch (0)
						{
						case 0:
							goto IL_38;
						}
						continue;
					case 3:
						goto IL_104;
					case 4:
						workMode = global::Motorola.CommonCPS.Server.CommonDBConstants.WorkMode.Template;
						goto IL_D3;
					}
					IL_38:
					if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ModeIdentifier != global::Motorola.CommonCPS.RadioManagement.Global.ModeIdentifier.Configuration)
					{
						num = (short)451411968;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)125632513;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_54:
					num = (short)805306372;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_D3:
					global::Motorola.CommonCPS.Server.CommonDBConstants.WorkMode workMode2 = workMode;
					result = global::System.Windows.Data.CollectionViewSource.GetDefaultView(base.ServiceProxy.LocalService.GetRadios(group, workMode2));
					num = (short)133758979;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_104:;
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
				result = null;
			}
			num = (short)1330184192;
			short num4 = num;
			num = (short)1806237697;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00015C4C File Offset: 0x00013E4C
		protected override void SaveItem(object[] parameters)
		{
			short num;
			try
			{
				num = (short)944118706;
				short num2 = num;
				num = (short)130685874;
				switch (num2 == num)
				{
				}
				num = (short)762773504;
				if (num != 0)
				{
				}
				this.f.SaveRadioCommand.Execute(parameters);
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, true);
				throw;
			}
			num = (short)1725825024;
			short num3 = num;
			num = (short)1295253505;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00015D28 File Offset: 0x00013F28
		protected override void OnPropertyChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			int a_ = 8;
			short num2;
			try
			{
				switch (0)
				{
				case 0:
					goto IL_39;
				}
				string propertyName;
				for (;;)
				{
					IL_13:
					int num;
					switch (num)
					{
					case 0:
						if (!(propertyName == global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("\udfbd뚿ꯁꏃꟅ볇ꏉꏋꃍ駏ꛑ뇓믕ꯗ", a_)))
						{
							num2 = (short)673382407;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						this.Groups = new global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.ConcurrentObserverCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.Group>(new global::Motorola.CommonCPS.RadioManagement.UIModels.Group(), global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.GroupService.GetGroupsTree());
						num2 = (short)348585990;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 1:
						goto IL_1BB;
					case 2:
						goto IL_1D2;
					case 3:
						num2 = (short)900268032;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 4:
						goto IL_1BB;
					case 5:
						if (!(propertyName == global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("\udbbd겿ꟁꟃ닅귇껉苋꿍ꛏ믑돓럕곗동돛냝꧟雡臣该", a_)))
						{
							num2 = (short)1516568579;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						base.SelectedItems.Clear();
						base.CommandProxy.DeleteGroupCommand.RaiseCanExecuteChanged();
						base.CommandProxy.PrepareRenameGroupCommand.RaiseCanExecuteChanged();
						num2 = (short)712245252;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 6:
						goto IL_1BB;
					case 7:
						num2 = (short)2112552961;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
					IL_1BB:
					num2 = (short)1675165698;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_39:
				base.OnPropertyChanged(sender, e);
				propertyName = e.PropertyName;
				num2 = (short)131690349;
				short num3 = num2;
				num2 = (short)43020141;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_1D2:
					break;
				default:
				{
					num2 = (short)1049034752;
					if (num2 != 0)
					{
					}
					num2 = (short)288358405;
					int num = (int)((global::System.IntPtr)num2);
					goto IL_13;
				}
				}
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
			}
			num2 = (short)1659699201;
			if (num2 != 0)
			{
			}
			num2 = (short)1934491648;
			short num4 = num2;
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00015F80 File Offset: 0x00014180
		protected override bool IsGoingToDetail(global::Microsoft.Practices.Prism.Regions.NavigationContext navigationContext)
		{
			int a_ = 1;
			string text = navigationContext.Uri.ToString();
			if (!text.StartsWith(global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("튶춸\udaba풼펾닀闂계ꋆ뻈", a_), global::System.StringComparison.Ordinal))
			{
				short num = (short)2003564787;
				short num2 = num;
				num = (short)49608947;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return true;
				case 1:
					break;
				default:
				{
					num = (short)768016384;
					short num3 = num;
					break;
				}
				}
				num = (short)97189888;
				if (num != 0)
				{
				}
				num = (short)2141126657;
				if (num != 0)
				{
				}
				return text.StartsWith(global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("튶즸풺쾼쮾닀闂계ꋆ뻈", a_), global::System.StringComparison.Ordinal);
			}
			return true;
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00016070 File Offset: 0x00014270
		protected override bool IsComingBackFromDetail(global::Microsoft.Practices.Prism.Regions.NavigationContext navigationContext)
		{
			int a_ = 18;
			switch (0)
			{
			case 0:
				goto IL_29;
			}
			int num;
			short num2;
			string text;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
				{
					num2 = (short)1430946709;
					short num3 = num2;
					num2 = (short)1613857685;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_57;
					default:
						num2 = (short)1490223104;
						if (num2 != 0)
						{
						}
						if (text == global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("铅韇軉꧋뫍뇏믑룓ꗕ軗동맛꧝", a_))
						{
							num2 = (short)101253121;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return false;
					}
					break;
				}
				case 1:
					goto IL_13F;
				case 2:
					num2 = (short)1736507392;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					goto IL_57;
				}
				goto IL_29;
				IL_57:
				if (text == global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("铅韇飉꧋뻍뿏ꃑꃓꗕ軗동맛꧝", a_))
				{
					break;
				}
				num2 = (short)323092481;
				if (num2 != 0)
				{
				}
				num2 = (short)1542455298;
				num = (int)((global::System.IntPtr)num2);
			}
			return true;
			IL_13F:
			num2 = (short)1707737088;
			short num4 = num2;
			return true;
			IL_29:
			text = navigationContext.Parameters[global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("闅Ꟈ뿉뻋귍뗏蓑뷓돕꿗", a_)];
			num2 = (short)480509955;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000139 RID: 313 RVA: 0x000161EC File Offset: 0x000143EC
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand a(global::System.Collections.Generic.List<global::System.Windows.Input.ICommand> A_0)
		{
			short num = (short)762904577;
			if (num != 0)
			{
			}
			num = (short)1739246829;
			short num2 = num;
			num = (short)1985137901;
			switch (num2 == num)
			{
			}
			num = (short)1546780672;
			short num3 = num;
			num = (short)1486815232;
			if (num != 0)
			{
			}
			global::Microsoft.Practices.Prism.Commands.DelegateCommand command = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(global::Motorola.CommonCPS.RadioManagement.Radio.RadiosViewModel.<>c.<>9.a), new global::System.Func<bool>(global::Motorola.CommonCPS.RadioManagement.Radio.RadiosViewModel.<>c.<>9.b));
			return this.e.CreateInstance.RegisterCommand(command).RegisterCommands(A_0).BuildDelegateCommand();
		}

		// Token: 0x0600013A RID: 314 RVA: 0x00016300 File Offset: 0x00014500
		private void a(global::System.Action<global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>> A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_34;
			}
			int num;
			global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> observableCollection;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_128;
				case 1:
					goto IL_1F3;
				case 2:
					if (observableCollection.Any(new global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase, bool>(global::Motorola.CommonCPS.RadioManagement.Radio.RadiosViewModel.<>c.<>9.a)))
					{
						num2 = (short)1310916612;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_128;
				case 3:
				{
					num2 = (short)1759969281;
					if (num2 != 0)
					{
					}
					if (!observableCollection.Any<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>())
					{
						return;
					}
					num2 = (short)998174605;
					short num3 = num2;
					num2 = (short)748679053;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_6F;
					default:
						num2 = (short)1448869888;
						if (num2 != 0)
						{
						}
						num2 = (short)1150746629;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 4:
					num2 = (short)680984583;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					A_0(observableCollection);
					num2 = (short)1659371521;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					goto IL_6F;
				case 7:
					observableCollection = new global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>(observableCollection.Where(new global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase, bool>(global::Motorola.CommonCPS.RadioManagement.Radio.RadiosViewModel.<>c.<>9.b)));
					num2 = (short)2104885248;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.IsRadioConversionSupported)
					{
						num2 = (short)710737926;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_128;
				}
				goto IL_34;
				IL_6F:
				num2 = (short)1544617986;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_128:
				num2 = (short)730857475;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_1F3:
			num2 = (short)174194688;
			short num4 = num2;
			return;
			IL_34:
			observableCollection = base.SelectedItems;
			num2 = (short)1560936456;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600013B RID: 315 RVA: 0x0001652C File Offset: 0x0001472C
		private void a()
		{
			short num;
			try
			{
				num = (short)1581973509;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)55373902;
						short num3 = num;
						num = (short)1216671822;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_91;
						default:
							num = (short)433848320;
							if (num != 0)
							{
							}
							num = (short)641662978;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 1:
						num = (short)591462404;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_71;
					case 3:
						goto IL_146;
					case 4:
						if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.IsCancelled)
						{
							goto IL_91;
						}
						goto IL_FB;
					case 5:
						switch (0)
						{
						case 0:
							goto IL_3C;
						}
						continue;
					}
					IL_3C:
					if (!global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.IsNotSetup)
					{
						num = (short)564199425;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_FB;
					IL_91:
					num = (short)45088768;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_FB:
					base.NavigationItems = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.GroupService.GetGroupsTree();
					this.SelectedNavigationItem = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.GroupService.FindGroup(global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.LastGroup);
					num = (short)768606211;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_71:
				IL_146:;
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
			}
			num = (short)780795905;
			if (num != 0)
			{
			}
			num = (short)1733623808;
			short num4 = num;
		}

		// Token: 0x0600013C RID: 316 RVA: 0x000166F8 File Offset: 0x000148F8
		public override void OnNavigatedTo(global::Microsoft.Practices.Prism.Regions.NavigationContext navigationContext)
		{
			int a_ = 6;
			switch (0)
			{
			case 0:
				goto IL_29;
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
					num2 = (short)989895648;
					short num3 = num2;
					num2 = (short)856398816;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_6E;
					default:
						num2 = (short)930611201;
						if (num2 != 0)
						{
						}
						num2 = (short)735182848;
						if (num2 != 0)
						{
						}
						if (base.Items == null)
						{
							num2 = (short)976158721;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_16C;
					}
					break;
				}
				case 1:
					goto IL_13F;
				case 2:
					num2 = (short)1305083904;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					goto IL_6E;
				}
				goto IL_29;
				IL_6E:
				if (!this.IsComingBackFromDetail(navigationContext))
				{
					break;
				}
				num2 = (short)1568014338;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_8D:
			this.a();
			return;
			IL_13F:
			num2 = (short)1873674240;
			short num4 = num2;
			goto IL_8D;
			IL_16C:
			base.RaisePropertyChanged<global::System.ComponentModel.ICollectionView>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::System.ComponentModel.ICollectionView>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.Radio.RadiosViewModel)), methodof(global::Motorola.CommonCPS.RadioManagement.Infrastructure.TableViewModelBase<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>.get_Items())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
			base.RaisePropertyChanged<global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.Radio.RadiosViewModel)), methodof(global::Motorola.CommonCPS.RadioManagement.Infrastructure.TableViewModelBase<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>.get_SelectedItems())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
			this.OnSelectedItemsCollectionChanged();
			return;
			IL_29:
			base.OnNavigatedTo(navigationContext);
			global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveMainView = global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("\uddbb\udabdꦿ귁럃郅ꇇ꿉믋", a_);
			this.RadioVRIDEntryFormat = global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.ASTROVRIDEntryFormat.ToUpperInvariant();
			num2 = (short)374931459;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x0600013D RID: 317 RVA: 0x000168EC File Offset: 0x00014AEC
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private void a(object A_0, global::System.EventArgs A_1)
		{
			int a_ = 9;
			short num = (short)782827523;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_E8;
				case 1:
					goto IL_130;
				case 2:
				{
					num = (short)468582401;
					if (num != 0)
					{
					}
					num = (short)453312512;
					short num3 = num;
					num = (short)1309474817;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 3:
					switch (0)
					{
					case 0:
						goto IL_3F;
					}
					continue;
				}
				IL_3F:
				if (!global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.IsHostedDeployment)
				{
					num = (short)509426856;
					short num4 = num;
					num = (short)1625308328;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)2100559872;
						if (num != 0)
						{
						}
						num = (short)918945794;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				else
				{
					num = (short)1254162432;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_E8:
			string text = global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.AgencyName;
			goto IL_13C;
			IL_130:
			text = global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.ServerAddress;
			IL_13C:
			string text2 = text;
			global::Motorola.CommonCPS.RadioManagement.InteractionHelper.InteractionFactory.GetInstance().ReportStatus(global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Status_Connection + global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("鶼", a_) + text2.ToUpper(global::System.Globalization.CultureInfo.InvariantCulture));
			this.OnSelectedItemsCollectionChanged();
		}

		// Token: 0x04000059 RID: 89
		private global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.Group> a;

		// Token: 0x0400005A RID: 90
		private global::System.Windows.Visibility b = global::System.Windows.Visibility.Collapsed;

		// Token: 0x0400005B RID: 91
		private global::System.Windows.Visibility c = global::System.Windows.Visibility.Collapsed;

		// Token: 0x0400005C RID: 92
		private readonly global::Motorola.CommonCPS.RadioManagement.Radio.RadiosViewWorkModeResolver d = new global::Motorola.CommonCPS.RadioManagement.Radio.RadiosViewWorkModeResolver();

		// Token: 0x0400005D RID: 93
		private readonly global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand.ICompositeCommandBuilderFactory e;

		// Token: 0x0400005E RID: 94
		private global::Motorola.CommonCPS.RadioManagement.Command.ICommandHandler f;

		// Token: 0x0400005F RID: 95
		private readonly global::Motorola.CommonCPS.RadioManagement.LocalService.ILocalService g;

		// Token: 0x04000060 RID: 96
		private string h;

		// Token: 0x04000061 RID: 97
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Radio.AddRadioViewModel> i;

		// Token: 0x04000062 RID: 98
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Radio.ModifyCodeplugPasswordViewModel> j;

		// Token: 0x04000063 RID: 99
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Radio.ResetRadioPasswordViewModel> k;

		// Token: 0x04000064 RID: 100
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Radio.ImportRadiosViewModel> l;

		// Token: 0x04000065 RID: 101
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Radio.ShowLanguagePacksViewModel> m;

		// Token: 0x04000066 RID: 102
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Radio.ShowVAPacksViewModel> n;

		// Token: 0x04000067 RID: 103
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Radio.ShowCACertificatesPacksViewModel> o;

		// Token: 0x04000068 RID: 104
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Radio.ShowDVRSFilesPacksViewModel> p;

		// Token: 0x04000069 RID: 105
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Radio.ShowMismatchOptionsViewModel> q;

		// Token: 0x0400006A RID: 106
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Radio.MoveGroupViewModel> r;

		// Token: 0x0400006B RID: 107
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Radio.UpdateRadioDataViewModel> s;

		// Token: 0x0400006C RID: 108
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Radio.ModifyCodeplugPasswordViewModel> t;

		// Token: 0x0400006D RID: 109
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Radio.ResetIdentifiersViewModel> u;

		// Token: 0x0400006E RID: 110
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Radio.ScheduleJobViewModel> v;

		// Token: 0x0400006F RID: 111
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Radio.SelectFirmwareViewModel> w;

		// Token: 0x04000070 RID: 112
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Radio.SelectRunningRadiosViewModel> x;

		// Token: 0x04000071 RID: 113
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Radio.SelectTemplateViewModel> y;

		// Token: 0x04000072 RID: 114
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel> z;

		// Token: 0x04000073 RID: 115
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Radio.SelectRadiosViewModel> aa;

		// Token: 0x04000074 RID: 116
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Radio.SelectWarningRadiosViewModel> ab;

		// Token: 0x04000075 RID: 117
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Radio.SelectProvisioningPackageViewModel> ac;

		// Token: 0x04000076 RID: 118
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Radio.SelectCodeplugVersionViewModel> ad;

		// Token: 0x04000077 RID: 119
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Radio.CopyPasteWarningViewModel> ae;

		// Token: 0x04000078 RID: 120
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand af;

		// Token: 0x04000079 RID: 121
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand ag;

		// Token: 0x0400007A RID: 122
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand ah;

		// Token: 0x0400007B RID: 123
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> ai;

		// Token: 0x0400007C RID: 124
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> aj;

		// Token: 0x0400007D RID: 125
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> ak;

		// Token: 0x0400007E RID: 126
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly global::Microsoft.Practices.Prism.Commands.DelegateCommand<string> al;

		// Token: 0x0400007F RID: 127
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand<string> am;

		// Token: 0x04000080 RID: 128
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::Motorola.CommonCPS.RadioManagement.UIModels.Group> an;

		// Token: 0x04000081 RID: 129
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::Motorola.CommonCPS.RadioManagement.UIModels.Group> ao;

		// Token: 0x04000082 RID: 130
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand ap;

		// Token: 0x04000083 RID: 131
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand aq;

		// Token: 0x04000084 RID: 132
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand ar;

		// Token: 0x04000085 RID: 133
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand @as;

		// Token: 0x04000086 RID: 134
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand at;

		// Token: 0x04000087 RID: 135
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand au;

		// Token: 0x04000088 RID: 136
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand av;

		// Token: 0x04000089 RID: 137
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly global::Microsoft.Practices.Prism.Commands.DelegateCommand aw;

		// Token: 0x0400008A RID: 138
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> ax;
	}
}
