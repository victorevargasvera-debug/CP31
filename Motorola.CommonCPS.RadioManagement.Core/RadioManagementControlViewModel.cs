using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.Composition;
using System.Configuration;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Threading;
using System.Windows;
using System.Windows.Forms;
using ACPBrowser;
using IncompatibilityHandler;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Events;
using Microsoft.Practices.Prism.Interactivity.InteractionRequest;
using Microsoft.Win32;
using Motorola.Common.CustomException;
using Motorola.Common.LogUtility;
using Motorola.CommonCPS.RadioManagement.BatchOp;
using Motorola.CommonCPS.RadioManagement.Common;
using Motorola.CommonCPS.RadioManagement.CommonBase.Utility;
using Motorola.CommonCPS.RadioManagement.CommonCore;
using Motorola.CommonCPS.RadioManagement.Controls;
using Motorola.CommonCPS.RadioManagement.Events;
using Motorola.CommonCPS.RadioManagement.Global;
using Motorola.CommonCPS.RadioManagement.Infrastructure;
using Motorola.CommonCPS.RadioManagement.InteractionHelper;
using Motorola.CommonCPS.RadioManagement.LocalService;
using Motorola.CommonCPS.RadioManagement.OAuthOpenIDConnect;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.Template;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.ResourceRepository.RadioCentral;
using Motorola.Security.SamlCommonUtility;
using Motorola.Security.SamlCommonUtility.DMHttpClients;

namespace Motorola.CommonCPS.RadioManagement.Core
{
	// Token: 0x02000007 RID: 7
	[global::System.ComponentModel.Composition.Export]
	public class RadioManagementControlViewModel : global::Motorola.CommonCPS.RadioManagement.CommonCore.CommonMainViewModel
	{
		// Token: 0x06000015 RID: 21 RVA: 0x00003914 File Offset: 0x00001B14
		[global::System.ComponentModel.Composition.ImportingConstructor]
		public RadioManagementControlViewModel(global::Microsoft.Practices.Prism.Events.IEventAggregator eventAggregator)
		{
			int a_ = 6;
			this.incompatibilityHandlerHelper = new global::IncompatibilityHandler.IncompatibilityHandlerHelper();
			this.v = global::System.Windows.Visibility.Hidden;
			this.x = new global::System.Threading.AutoResetEvent(false);
			base..ctor(eventAggregator);
			this.a = new global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.Confirmation>();
			this.b = new global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.Notification>();
			this.c = new global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.Notification>();
			this.d = new global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Common.ProgressViewModel>();
			this.e = new global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Common.ProgressViewModel>();
			this.f = new global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.UIModels.RetryConfirmation>();
			this.g = new global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Template.SaveTemplateAsViewModel>();
			this.h = new global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Common.SettingsViewModel>();
			this.i = new global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Common.DBMigrationViewModel>();
			this.j = new global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Common.ClearDataViewModel>();
			this.k = new global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Common.RadioConversionViewModel>();
			this.l = new global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Common.TemplateConversionViewMode>();
			this.m = new global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Common.SeletcMofiiedRadioViewMode>();
			this.ShowTasksWindowRequest = new global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Common.TasksViewModel>();
			this.o = new global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Common.UserLoginViewModel>();
			this.p = new global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Common.ChangePasswordViewModel>();
			this.q = new global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Common.AboutViewModel>();
			this.r = new global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.OAuthOpenIDConnect.OAuthLoginViewModel>();
			this.s = new global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.OAuthOpenIDConnect.SelectAgencyViewModel>();
			this.t = new global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Common.UpdateLogSettingViewModel>();
			this.u = new global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Common.ErrorMessageViewModel>();
			base.CommandProxy.UploadMotorolaCodeplugCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.UploadMotorolaCodeplug), new global::System.Func<bool>(this.f));
			base.CommandProxy.ShowSettingsCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.ShowSettings), new global::System.Func<bool>(this.e));
			base.CommandProxy.PrintViewCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand<object>(new global::System.Action<object>(this.e), new global::System.Func<object, bool>(this.d));
			base.CommandProxy.PrintViewPreviewCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.h), new global::System.Func<bool>(this.d));
			base.CommandProxy.HelpCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.ShowHelpWindow), new global::System.Func<bool>(this.CanShowHelpWindow));
			base.CommandProxy.AboutCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.g), new global::System.Func<bool>(this.c));
			base.CommandProxy.NavigateToMainModuleCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand<string>(new global::System.Action<string>(this.c), new global::System.Func<string, bool>(this.d));
			base.CommandProxy.NavigateToSetDebuggerCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.m), new global::System.Func<bool>(this.n));
			base.CommandProxy.ViewTasksCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.l));
			base.CommandProxy.ShowRadioConversionCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.ShowRadioConversion), new global::System.Func<bool>(this.p));
			base.CommandProxy.ShowTemplateConversionDialogCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.ShowTemplateConversion), new global::System.Func<bool>(this.o));
			base.CommandProxy.ShowUpdateLogSettingCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::Motorola.CommonCPS.RadioManagement.UIModels.LogSetting>(new global::System.Action<global::Motorola.CommonCPS.RadioManagement.UIModels.LogSetting>(this.b), new global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.LogSetting, bool>(this.CanShowUpdateLogSetting));
			global::Motorola.CommonCPS.RadioManagement.InteractionHelper.InteractionFactory.CreateInstance(eventAggregator);
			eventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.GoToRadioDetailsRequestedEvent>().Subscribe(new global::System.Action<object>(this.c));
			eventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.GoToRadioReportsRequestedEvent>().Subscribe(new global::System.Action<object>(this.b));
			eventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ShowConfirmationDialogRequestedEvent>().Subscribe(new global::System.Action<global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.Confirmation>(this.a));
			eventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ShowNotificationDialogRequestedEvent>().Subscribe(new global::System.Action<global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.Notification>(this.b));
			eventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ShowStartUpNotificationDialogRequestedEvent>().Subscribe(new global::System.Action<global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.Notification>(this.a));
			eventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ShowProgressDialogRequestedEvent>().Subscribe(new global::System.Action<global::Motorola.CommonCPS.RadioManagement.UIModels.ProgressContext>(this.a));
			eventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ShowRetryDialogRequestedEvent>().Subscribe(new global::System.Action<global::Motorola.CommonCPS.RadioManagement.UIModels.RetryConfirmation>(this.a));
			eventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ShowSaveTemplateAsDialogRequestedEvent>().Subscribe(new global::System.Action<global::Motorola.CommonCPS.RadioManagement.UIModels.SaveTemplateAsContext>(this.a));
			eventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ShowSettingsDialogRequestedEvent>().Subscribe(new global::System.Action<global::Motorola.CommonCPS.RadioManagement.UIModels.SettingsContext>(this.a));
			eventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ShowDBMigrationDialogRequestedEvent>().Subscribe(new global::System.Action<global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationContext>(this.a));
			eventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ShowClearDataDialogRequestedEvent>().Subscribe(new global::System.Action<global::Motorola.CommonCPS.RadioManagement.UIModels.ClearOldDBContext>(this.a));
			eventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ShowRadioConversionDialogRequestedEvent>().Subscribe(new global::System.Action<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioConversionContext>(this.a));
			eventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ShowTemplateConversionDialogRequestedEvent>().Subscribe(new global::System.Action<global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateConversionContext>(this.a));
			eventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.WaitingIndicatorVisibilityChangedEvent>().Subscribe(new global::System.Action<bool>(this.a));
			eventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.UserLoginDialogRequestedEvent>().Subscribe(new global::System.Action<global::Motorola.CommonCPS.RadioManagement.UIModels.UserLoginContext>(this.a));
			eventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ChangePasswordDialogRequestedEvent>().Subscribe(new global::System.Action<global::Motorola.CommonCPS.RadioManagement.UIModels.ChangePasswordContext>(this.a));
			eventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ShowHelpWindowRequestedEvent>().Subscribe(new global::System.Action<string>(this.a));
			eventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ShowAboutDialogRequestedEvent>().Subscribe(new global::System.Action<object>(this.a));
			eventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ShowRMSaveFileDialogRequestedEvent>().Subscribe(new global::System.Action<global::Motorola.CommonCPS.RadioManagement.Events.ShowRMSaveFileDialogEventParam>(this.a));
			eventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.OAuthLoginDialogRequestedEvent>().Subscribe(new global::System.Action<global::Motorola.CommonCPS.RadioManagement.UIModels.OAuthLoginContext>(this.a));
			eventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.SelectAgencyRequestedEvent>().Subscribe(new global::System.Action<global::Motorola.CommonCPS.RadioManagement.UIModels.SelectAgencyContext>(this.a));
			eventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ShowUpdateLogSettingRequestedEvent>().Subscribe(new global::System.Action<global::Motorola.CommonCPS.RadioManagement.UIModels.LogSetting>(this.a));
			eventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ShowErrorMessageDialogRequestedEvent>().Subscribe(new global::System.Action<global::Motorola.CommonCPS.RadioManagement.UIModels.ErrorMessageContext>(this.a));
			global::Microsoft.Win32.SystemEvents.DisplaySettingsChanged += this.b;
			if (!global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.SettingUpgraded)
			{
				int serverPort = global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.ServerPort;
				global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.Upgrade();
				global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.SettingUpgraded = true;
				global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.ServerPort = serverPort;
				global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.Save();
			}
			global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ServerAddress = global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.ServerAddress;
			global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ServerPort = global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.ServerPort;
			if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.IsHostedDeployment)
			{
				global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ServerAddress = global::System.Configuration.ConfigurationManager.AppSettings[global::Motorola.CommonCPS.RadioManagement.Core.RadioManagementControlViewModel.q("쮘횚\uda9cﺞ햠욢튤욦킨즬쮮쎰횲운쒶", a_)];
				global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.AuthenticationMethodType = global::Motorola.CommonCPS.RadioManagement.Global.AuthMethod.JwtToken.ToString();
			}
			else
			{
				if (!global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.CheckIfLocalHost(global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ServerAddress))
				{
					if (!global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.CheckIfActiveDirectory())
					{
						global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.AuthenticationMethodType = global::Motorola.CommonCPS.RadioManagement.Global.AuthMethod.UserName.ToString();
						goto IL_610;
					}
				}
				global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.AuthenticationMethodType = global::Motorola.CommonCPS.RadioManagement.Global.AuthMethod.Windows.ToString();
			}
			IL_610:
			global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.WorkingAuthenticationMethodType = global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.AuthenticationMethodType;
			global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.JwtToken = string.Empty;
			global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.WorkingJwtToken = string.Empty;
			global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.SecurePassword = new global::System.Security.SecureString();
			global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.WorkingSecurePassword = new global::System.Security.SecureString();
			global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.UserName = string.Empty;
			global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.WorkingUserName = string.Empty;
			global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.IsConnected = false;
			global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.IsCurrentSessionConnected = false;
			global::Motorola.CommonCPS.RadioManagement.SharedServices.IServerAccessor instance = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(false, false);
			instance.IncompatiblityDetected = (global::Motorola.CommonCPS.RadioManagement.SharedServices.IncompatibilityHandler)global::System.Delegate.Combine(instance.IncompatiblityDetected, new global::Motorola.CommonCPS.RadioManagement.SharedServices.IncompatibilityHandler(this.a));
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000016 RID: 22 RVA: 0x00003FAC File Offset: 0x000021AC
		public global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.Confirmation> ShowConfirmationDialogRequest
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1842151962;
				short num2 = num;
				num = (short)1521025562;
				switch (num2 == num)
				{
				}
				num = (short)1890648064;
				if (num != 0)
				{
				}
				num = (short)2073821185;
				if (num != 0)
				{
				}
				num = (short)638779392;
				short num3 = num;
				return this.a;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000017 RID: 23 RVA: 0x00004060 File Offset: 0x00002260
		public global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.Notification> ShowNotificationDialogRequest
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1202126849;
				if (num != 0)
				{
				}
				num = (short)1229817574;
				short num2 = num;
				num = (short)613385958;
				switch (num2 == num)
				{
				}
				num = (short)568066048;
				if (num != 0)
				{
				}
				num = (short)1984692224;
				short num3 = num;
				return this.b;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000018 RID: 24 RVA: 0x00004114 File Offset: 0x00002314
		public global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.Notification> ShowStartUpNotificationDialogRequest
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)632335098;
				short num2 = num;
				num = (short)632269562;
				switch (num2 == num)
				{
				}
				num = (short)664403968;
				if (num != 0)
				{
				}
				num = (short)1163788289;
				if (num != 0)
				{
				}
				num = (short)1778319360;
				short num3 = num;
				return this.c;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000019 RID: 25 RVA: 0x000041C4 File Offset: 0x000023C4
		public global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Common.ProgressViewModel> ShowProgressRequest
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)48518745;
				short num2 = num;
				num = (short)342513241;
				switch (num2 == num)
				{
				}
				num = (short)657457153;
				if (num != 0)
				{
				}
				num = (short)2007171072;
				if (num != 0)
				{
				}
				num = (short)1630601216;
				short num3 = num;
				return this.d;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600001A RID: 26 RVA: 0x00004274 File Offset: 0x00002474
		public global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Common.ProgressViewModel> ShowProgressDialogRequest
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1677532206;
				short num2 = num;
				num = (short)1185618990;
				switch (num2 == num)
				{
				}
				num = (short)1543634945;
				if (num != 0)
				{
				}
				num = (short)650248192;
				if (num != 0)
				{
				}
				num = (short)1423507456;
				short num3 = num;
				return this.e;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600001B RID: 27 RVA: 0x00004324 File Offset: 0x00002524
		public global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.UIModels.RetryConfirmation> ShowRetryDialogRequest
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)120105017;
				short num2 = num;
				num = (short)241936441;
				switch (num2 == num)
				{
				}
				num = (short)1760493569;
				if (num != 0)
				{
				}
				num = (short)872153088;
				if (num != 0)
				{
				}
				num = (short)1091436544;
				short num3 = num;
				return this.f;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600001C RID: 28 RVA: 0x000043D4 File Offset: 0x000025D4
		public global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Template.SaveTemplateAsViewModel> ShowSaveTemplateAsDialogRequest
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)142519495;
				short num2 = num;
				num = (short)1000582343;
				switch (num2 == num)
				{
				}
				num = (short)735117313;
				if (num != 0)
				{
				}
				num = (short)1107886080;
				if (num != 0)
				{
				}
				num = (short)1807810560;
				short num3 = num;
				return this.g;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600001D RID: 29 RVA: 0x00004488 File Offset: 0x00002688
		public global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Common.SettingsViewModel> ShowSettingsDialogRequest
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1556457619;
				short num2 = num;
				num = (short)1660856467;
				switch (num2 == num)
				{
				}
				num = (short)918552577;
				if (num != 0)
				{
				}
				num = (short)1068040192;
				if (num != 0)
				{
				}
				num = (short)1154023424;
				short num3 = num;
				return this.h;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600001E RID: 30 RVA: 0x00004538 File Offset: 0x00002738
		public global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Common.DBMigrationViewModel> ShowDBMigrationDialogRequest
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)965473187;
				short num2 = num;
				num = (short)1745744803;
				switch (num2 == num)
				{
				}
				num = (short)1308164097;
				if (num != 0)
				{
				}
				num = (short)81788928;
				if (num != 0)
				{
				}
				num = (short)76873728;
				short num3 = num;
				return this.i;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600001F RID: 31 RVA: 0x000045E8 File Offset: 0x000027E8
		public global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Common.ClearDataViewModel> ShowClearDataDialogRequest
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1629506132;
				short num2 = num;
				num = (short)1679837780;
				switch (num2 == num)
				{
				}
				num = (short)33685505;
				if (num != 0)
				{
				}
				num = (short)678887424;
				if (num != 0)
				{
				}
				num = (short)2021392384;
				short num3 = num;
				return this.j;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000020 RID: 32 RVA: 0x00004698 File Offset: 0x00002898
		public global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Common.RadioConversionViewModel> ShowRadioConversionDialogRequest
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2105802560;
				short num2 = num;
				num = (short)407502656;
				switch (num2 == num)
				{
				}
				num = (short)1411514369;
				if (num != 0)
				{
				}
				num = (short)743505920;
				if (num != 0)
				{
				}
				num = (short)556990464;
				short num3 = num;
				return this.k;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000021 RID: 33 RVA: 0x00004748 File Offset: 0x00002948
		public global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Common.TemplateConversionViewMode> ShowTemplateConversionDialogRequest
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1159631033;
				short num2 = num;
				num = (short)1758630073;
				switch (num2 == num)
				{
				}
				num = (short)766377985;
				if (num != 0)
				{
				}
				num = (short)368312320;
				if (num != 0)
				{
				}
				num = (short)423034880;
				short num3 = num;
				return this.l;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000022 RID: 34 RVA: 0x000047F8 File Offset: 0x000029F8
		public global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Common.SeletcMofiiedRadioViewMode> ShowSelectModifiedRadiosDialogRequest
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1173487617;
				if (num != 0)
				{
				}
				num = (short)1145211614;
				short num2 = num;
				num = (short)39815902;
				switch (num2 == num)
				{
				}
				num = (short)171638784;
				if (num != 0)
				{
				}
				num = (short)1933443072;
				short num3 = num;
				return this.m;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000023 RID: 35 RVA: 0x000048A8 File Offset: 0x00002AA8
		// (set) Token: 0x06000024 RID: 36 RVA: 0x00004958 File Offset: 0x00002B58
		public global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Common.TasksViewModel> ShowTasksWindowRequest
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)760856285;
				short num2 = num;
				num = (short)1092140765;
				switch (num2 == num)
				{
				}
				num = (short)1025376256;
				if (num != 0)
				{
				}
				num = (short)1276575745;
				if (num != 0)
				{
				}
				num = (short)1481441280;
				short num3 = num;
				return this.n;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1515051115;
				short num2 = num;
				num = (short)29087851;
				switch (num2 == num)
				{
				}
				num = (short)1270284288;
				if (num != 0)
				{
				}
				num = (short)584712193;
				if (num != 0)
				{
				}
				num = (short)1314652160;
				short num3 = num;
				this.n = value;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000025 RID: 37 RVA: 0x00004A08 File Offset: 0x00002C08
		public global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Common.UserLoginViewModel> UserLoginDialogRequest
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)475603758;
				short num2 = num;
				num = (short)134095662;
				switch (num2 == num)
				{
				}
				num = (short)1743912960;
				if (num != 0)
				{
				}
				num = (short)959447041;
				if (num != 0)
				{
				}
				num = (short)473694208;
				short num3 = num;
				return this.o;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000026 RID: 38 RVA: 0x00004AB4 File Offset: 0x00002CB4
		public global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Common.ChangePasswordViewModel> ChangePasswordDialogRequest
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1397227965;
				short num2 = num;
				num = (short)1758527933;
				switch (num2 == num)
				{
				}
				num = (short)1250230273;
				if (num != 0)
				{
				}
				num = (short)764739584;
				if (num != 0)
				{
				}
				num = (short)154533888;
				short num3 = num;
				return this.p;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000027 RID: 39 RVA: 0x00004B64 File Offset: 0x00002D64
		public global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Common.AboutViewModel> ShowAboutDialogRequest
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1626438115;
				short num2 = num;
				num = (short)1578858979;
				switch (num2 == num)
				{
				}
				num = (short)1329987584;
				if (num != 0)
				{
				}
				num = (short)2110193665;
				if (num != 0)
				{
				}
				num = (short)1830027264;
				short num3 = num;
				return this.q;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000028 RID: 40 RVA: 0x00004C14 File Offset: 0x00002E14
		public global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.OAuthOpenIDConnect.OAuthLoginViewModel> OAuthLoginDialogRequest
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)916242654;
				short num2 = num;
				num = (short)215335134;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1661927424;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)314179585;
				if (num != 0)
				{
				}
				num = (short)1008467968;
				if (num != 0)
				{
				}
				return this.r;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000029 RID: 41 RVA: 0x00004CC4 File Offset: 0x00002EC4
		public global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.OAuthOpenIDConnect.SelectAgencyViewModel> SelectAgencyDialogRequest
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1804337153;
				if (num != 0)
				{
				}
				num = (short)26804224;
				short num2 = num;
				num = (short)132494720;
				short num3 = num;
				num = (short)303216000;
				switch (num3 == num)
				{
				}
				num = (short)374276096;
				if (num != 0)
				{
				}
				return this.s;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600002A RID: 42 RVA: 0x00004D74 File Offset: 0x00002F74
		public global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Common.UpdateLogSettingViewModel> ShowUpdateLogSettingRequest
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1425437380;
				short num2 = num;
				num = (short)214528708;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1499987968;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1190199296;
				if (num != 0)
				{
				}
				num = (short)285278209;
				if (num != 0)
				{
				}
				return this.t;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600002B RID: 43 RVA: 0x00004E24 File Offset: 0x00003024
		public global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Common.ErrorMessageViewModel> ShowErrorMessageRequest
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)329738427;
				short num2 = num;
				num = (short)655452347;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1850736640;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)610729984;
				if (num != 0)
				{
				}
				num = (short)1155661825;
				if (num != 0)
				{
				}
				return this.u;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600002C RID: 44 RVA: 0x00004ED4 File Offset: 0x000030D4
		// (set) Token: 0x0600002D RID: 45 RVA: 0x00004F80 File Offset: 0x00003180
		public global::System.Windows.Visibility WaitingIndicatorVisibility
		{
			get
			{
				short num = (short)2082347046;
				short num2 = num;
				num = (short)994056230;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1341128704;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1422983169;
				if (num != 0)
				{
				}
				num = (short)802488320;
				if (num != 0)
				{
				}
				return this.v;
			}
			set
			{
				short num = (short)197984257;
				if (num != 0)
				{
				}
				num = (short)1213136896;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)1934426112;
					short num3 = num;
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_80;
						}
						continue;
					case 1:
						return;
					case 2:
					{
						this.v = value;
						base.RaisePropertyChanged<global::System.Windows.Visibility>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::System.Windows.Visibility>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.Core.RadioManagementControlViewModel)), methodof(global::Motorola.CommonCPS.RadioManagement.Core.RadioManagementControlViewModel.get_WaitingIndicatorVisibility())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)921025184;
						short num4 = num;
						num = (short)2053618336;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_8C;
						default:
							num = (short)693370880;
							if (num != 0)
							{
							}
							num = (short)1042874369;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					goto IL_80;
					IL_8C:
					num = (short)636289026;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_80:
					if (value != this.v)
					{
						goto IL_8C;
					}
					break;
				}
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600002E RID: 46 RVA: 0x000050D0 File Offset: 0x000032D0
		// (set) Token: 0x0600002F RID: 47 RVA: 0x00005180 File Offset: 0x00003380
		public string ActivedFieldUrl
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)812580865;
				if (num != 0)
				{
				}
				num = (short)1501560832;
				short num2 = num;
				num = (short)559221270;
				short num3 = num;
				num = (short)2139687446;
				switch (num3 == num)
				{
				}
				num = (short)1821769728;
				if (num != 0)
				{
				}
				return this.w;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1042107668;
				short num2 = num;
				num = (short)802835732;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1227423744;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)925958145;
				if (num != 0)
				{
				}
				num = (short)1552809984;
				if (num != 0)
				{
				}
				this.w = value;
			}
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00005230 File Offset: 0x00003430
		public void ShowHelpWindow()
		{
			short num = (short)947388418;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1893269505;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
				{
					num = (short)177756438;
					short num3 = num;
					num = (short)738679062;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)205324288;
						if (num != 0)
						{
						}
						num = (short)954335232;
						short num4 = num;
						num = (short)891289601;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 1:
					if (!string.IsNullOrEmpty(this.ActivedFieldUrl))
					{
						num = (short)480182276;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1875312643;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_64;
					}
					continue;
				case 3:
					goto IL_9A;
				case 4:
					num = (short)1328152581;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					goto IL_C6;
				}
				IL_64:
				if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ModeIdentifier != global::Motorola.CommonCPS.RadioManagement.Global.ModeIdentifier.Configuration)
				{
					goto IL_191;
				}
				num = (short)330432512;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_9A:
			string text = global::Motorola.CommonCPS.RadioManagement.LocalService.LocalServiceProxy.GetInstance().LocalService.GetHelpFilePath(null);
			goto IL_188;
			IL_C6:
			text = this.ActivedFieldUrl;
			IL_188:
			string url = text;
			this.OpenHelpDoc(url);
			return;
			IL_191:
			url = global::Motorola.CommonCPS.RadioManagement.LocalService.LocalServiceProxy.GetInstance().LocalService.GetHelpFilePathForTemplate();
			this.OpenHelpDoc(url);
		}

		// Token: 0x06000031 RID: 49 RVA: 0x000053E8 File Offset: 0x000035E8
		public bool CanShowHelpWindow()
		{
			short num = (short)1339459059;
			short num2 = num;
			num = (short)411207155;
			switch (num2 == num)
			{
			default:
			{
				num = (short)843907072;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1984430081;
			if (num != 0)
			{
			}
			num = (short)687144960;
			if (num != 0)
			{
			}
			return true;
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00005490 File Offset: 0x00003690
		public void OpenHelpDoc(string url = null)
		{
			int a_ = 8;
			short num = (short)1729626112;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_3D;
					}
					continue;
				case 1:
					goto IL_E4;
				case 2:
					num = (short)1424621571;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (global::System.IO.File.Exists(url))
					{
						num = (short)486431018;
						short num3 = num;
						num = (short)1330796842;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_11B;
						}
					}
					num = (short)355860481;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_3D:
				num = (short)1696333825;
				if (num != 0)
				{
				}
				num = (short)2030174208;
				short num4 = num;
				if (string.IsNullOrEmpty(url))
				{
					break;
				}
				num = (short)605093890;
				num2 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_E4:
			return;
			IL_11B:
			num = (short)616235008;
			if (num != 0)
			{
			}
			global::ACPBrowser.Utility.CloseHelpWindowIfOpen();
			global::ACPBrowser.Utility.DisplayCPSHelpDITA(global::Motorola.CommonCPS.RadioManagement.Core.RadioManagementControlViewModel.q("뢚ꢜﮞ삠銢잤隦麨鎪", a_));
		}

		// Token: 0x06000033 RID: 51 RVA: 0x000055E8 File Offset: 0x000037E8
		public void UploadMotorolaCodeplug()
		{
			short num = (short)304479226;
			short num2 = num;
			num = (short)394918906;
			switch (num2 == num)
			{
			default:
			{
				num = (short)364118016;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1971847168;
			if (num != 0)
			{
			}
			num = (short)666566657;
			if (num != 0)
			{
			}
			base.ServiceProxy.CommandHandler.UploadCodeplugCommand.Execute(new object[]
			{
				new global::Motorola.CommonCPS.RadioManagement.SharedServices.DMServiceAccessor()
			});
		}

		// Token: 0x06000034 RID: 52 RVA: 0x000056B4 File Offset: 0x000038B4
		public void ShowSettings()
		{
			short num = (short)537591810;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)579534848;
				short num3 = num;
				switch (num2)
				{
				case 0:
					goto IL_343;
				case 1:
					goto IL_30C;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_91;
					}
					continue;
				case 3:
					if (!global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.IsCurrentSessionConnected)
					{
						num = (short)1867120652;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 4:
					global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.AuthenticationMethodType = global::Motorola.CommonCPS.RadioManagement.Global.AuthMethod.JwtToken.ToString();
					global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ConnectionFailureReason = global::Motorola.CommonCPS.RadioManagement.Global.ConnectionFailureReasonID.JwtTokenCredentialFirstTimeLogin;
					num = (short)551026689;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
				{
					global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.AuthenticationMethodType = global::Motorola.CommonCPS.RadioManagement.Global.AuthMethod.Windows.ToString();
					global::Motorola.CommonCPS.RadioManagement.SharedServices.IServerAccessor instance;
					instance.Connect(global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ServerAddress, global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ServerPort, global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ServerAddress, global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.AuthenticationMethodType, global::System.Threading.SynchronizationContext.Current, global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.UserName, global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.SecurePassword, false, null);
					num = (short)1097138185;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 6:
					if (global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.CheckIfActiveDirectory())
					{
						num = (short)553779216;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.AuthenticationMethodType = global::Motorola.CommonCPS.RadioManagement.Global.AuthMethod.UserName.ToString();
					global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ConnectionFailureReason = global::Motorola.CommonCPS.RadioManagement.Global.ConnectionFailureReasonID.UserNameFirstTimeLogin;
					num = (short)1205272576;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					if ((bool)base.ServiceProxy.CommandHandler.ShowSettingsDialogCommand.Execute(global::System.Array.Empty<object>()))
					{
						num = (short)1989738507;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					global::Motorola.CommonCPS.RadioManagement.Common.SplashScreenHelper.Close();
					num = (short)263454735;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
				{
					num = (short)1156838366;
					short num4 = num;
					num = (short)911864798;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						goto IL_E8;
					}
					break;
				}
				case 9:
					goto IL_1DF;
				case 10:
					if (global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.CheckIfLocalHost(global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ServerAddress))
					{
						num = (short)353697797;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1563230214;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					num = (short)1923022851;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
				{
					global::Motorola.CommonCPS.RadioManagement.SharedServices.IServerAccessor instance = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(false, false);
					num = (short)1315438606;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 13:
					goto IL_15B;
				case 14:
					if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.IsHostedDeployment)
					{
						num = (short)1737293828;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1717305354;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
					goto IL_2D4;
				case 16:
				{
					global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.AuthenticationMethodType = global::Motorola.CommonCPS.RadioManagement.Global.AuthMethod.Windows.ToString();
					global::Motorola.CommonCPS.RadioManagement.SharedServices.IServerAccessor instance;
					instance.Connect(global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ServerAddress, global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ServerPort, global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ServerAddress, global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.AuthenticationMethodType, global::System.Threading.SynchronizationContext.Current, global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.UserName, global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.SecurePassword, false, null);
					num = (short)1762197517;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_91:
				if (this.k())
				{
					num = (short)525664264;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)457572359;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_E8:
			num = (short)1321861120;
			if (num != 0)
			{
			}
			return;
			IL_15B:
			num = (short)667090945;
			if (num != 0)
			{
			}
			IL_1DF:
			IL_21F:
			this.HandleConnectResults();
			return;
			IL_2D4:
			return;
			IL_30C:
			IL_343:
			goto IL_21F;
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00005A94 File Offset: 0x00003C94
		public void ShowRadioConversion()
		{
			short num = (short)1802220897;
			short num2 = num;
			num = (short)1386001761;
			switch (num2 == num)
			{
			default:
			{
				num = (short)470155264;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)398917633;
			if (num != 0)
			{
			}
			num = (short)1774321664;
			if (num != 0)
			{
			}
			base.ServiceProxy.CommandHandler.ShowRadioConversionDialogCommand.Execute(global::System.Array.Empty<object>());
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00005B58 File Offset: 0x00003D58
		private bool p()
		{
			int a_ = 8;
			short num;
			bool result;
			try
			{
				for (;;)
				{
					IL_09:
					num = (short)555417603;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						bool flag;
						switch (num2)
						{
						case 0:
							if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveMainModule == global::Motorola.CommonCPS.RadioManagement.Core.RadioManagementControlViewModel.q("즚ﲜﮞ좠첢", a_))
							{
								num = (short)1881669636;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_E4;
						case 1:
							flag = false;
							goto IL_17A;
						case 2:
							num = (short)1213399040;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							switch (0)
							{
							case 0:
								goto IL_4A;
							}
							continue;
						case 4:
							num = (short)1083965446;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							goto IL_192;
						case 6:
							flag = (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveMainView == global::Motorola.CommonCPS.RadioManagement.Core.RadioManagementControlViewModel.q("즚ﲜﮞ좠첢횤삨캪\udaac", a_));
							goto IL_17A;
						}
						IL_4A:
						if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ModeIdentifier == global::Motorola.CommonCPS.RadioManagement.Global.ModeIdentifier.Configuration)
						{
							num = (short)71041025;
							if (num != 0)
							{
							}
							num = (short)1056066898;
							short num3 = num;
							num = (short)95898962;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_09;
							default:
								num = (short)513474560;
								if (num != 0)
								{
								}
								num = (short)1193672706;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
						}
						IL_E4:
						num = (short)583008257;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_17A:
						result = flag;
						num = (short)276234245;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				IL_192:;
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
				result = false;
			}
			num = (short)821493760;
			short num4 = num;
			return result;
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00005D4C File Offset: 0x00003F4C
		public void ShowTemplateConversion()
		{
			short num = (short)389545985;
			if (num != 0)
			{
			}
			num = (short)1714094080;
			short num2 = num;
			num = (short)677700564;
			short num3 = num;
			num = (short)230745044;
			switch (num3 == num)
			{
			}
			num = (short)1838809088;
			if (num != 0)
			{
			}
			base.ServiceProxy.CommandHandler.ShowTemplateConversionDialogCommand.Execute(global::System.Array.Empty<object>());
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00005E10 File Offset: 0x00004010
		private bool o()
		{
			short num;
			bool result;
			try
			{
				num = (short)1019811381;
				short num2 = num;
				num = (short)1157436981;
				switch (num2 == num)
				{
				}
				num = (short)364707840;
				if (num != 0)
				{
				}
				result = false;
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
				result = false;
			}
			num = (short)221380608;
			short num3 = num;
			num = (short)1104347137;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00005EDC File Offset: 0x000040DC
		private bool d(string A_0)
		{
			short num = (short)1691484161;
			if (num != 0)
			{
			}
			num = (short)1270868073;
			short num2 = num;
			num = (short)287434857;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				return false;
			case 1:
				break;
			default:
			{
				num = (short)1730084864;
				short num3 = num;
				break;
			}
			}
			num = (short)1557790720;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.SharedServices.IServerAccessor instance = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(false, false);
			if (global::Motorola.CommonCPS.RadioManagement.Global.ModuleNames.IsModuleNameMatched(A_0, global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ModeIdentifier))
			{
				return instance.IsConnected;
			}
			return false;
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00005FA8 File Offset: 0x000041A8
		private void c(string A_0)
		{
			short num = (short)907378965;
			short num2 = num;
			num = (short)1496416533;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1204551680;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)993460225;
			if (num != 0)
			{
			}
			num = (short)155451392;
			if (num != 0)
			{
			}
			base.EventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.EndGrouplistEditModeRequestedEvent>().Publish(null);
			base.EventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.NavigateToMainModuleRequestedEvent>().Publish(A_0);
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00006074 File Offset: 0x00004274
		private bool n()
		{
			short num = (short)124324620;
			short num2 = num;
			num = (short)1676675852;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1705181184;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)88997889;
			if (num != 0)
			{
			}
			num = (short)655032320;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ModeIdentifier == global::Motorola.CommonCPS.RadioManagement.Global.ModeIdentifier.Configuration;
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00006128 File Offset: 0x00004328
		private void m()
		{
			short num = (short)96820160;
			short num2 = num;
			num = (short)1513446336;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1564082176;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)399114240;
			if (num != 0)
			{
			}
			num = (short)1824718849;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600003D RID: 61 RVA: 0x000061D0 File Offset: 0x000043D0
		private void l()
		{
			short num = (short)2070478849;
			if (num != 0)
			{
			}
			num = (short)515178496;
			short num2 = num;
			num = (short)1319293568;
			short num3 = num;
			num = (short)1421136512;
			switch (num3 == num)
			{
			}
			num = (short)1525153792;
			if (num != 0)
			{
			}
			base.ServiceProxy.CommandHandler.ViewProgressesCommand.Execute(global::System.Array.Empty<object>());
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00006294 File Offset: 0x00004494
		private string a(global::System.Security.SecureString A_0)
		{
			short num = (short)271156805;
			short num2 = num;
			num = (short)1699448389;
			string result;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				return result;
			case 1:
				break;
			default:
			{
				num = (short)1284112384;
				short num3 = num;
				break;
			}
			}
			num = (short)639893504;
			if (num != 0)
			{
			}
			num = (short)1983512577;
			if (num != 0)
			{
			}
			global::System.IntPtr ptr = global::System.IntPtr.Zero;
			try
			{
				ptr = global::System.Runtime.InteropServices.Marshal.SecureStringToGlobalAllocUnicode(A_0);
				result = global::System.Runtime.InteropServices.Marshal.PtrToStringUni(ptr);
			}
			finally
			{
				global::System.Runtime.InteropServices.Marshal.ZeroFreeGlobalAllocUnicode(ptr);
			}
			return result;
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00006370 File Offset: 0x00004570
		private bool k()
		{
			short num = (short)593853740;
			short num2 = num;
			num = (short)1398832428;
			switch (num2 == num)
			{
			default:
			{
				num = (short)2135425024;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)479592449;
			if (num != 0)
			{
			}
			num = (short)833028096;
			if (num != 0)
			{
			}
			global::System.Collections.Generic.List<bool> list = new global::System.Collections.Generic.List<bool>
			{
				false
			};
			base.EventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ActiveMainModuleChangingEvent>().Publish(list);
			return list[0];
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00006440 File Offset: 0x00004640
		public void HandleConnectResults()
		{
			int a_ = 11;
			short num;
			try
			{
				num = (short)2115239936;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					switch (0)
					{
					case 0:
						goto IL_1F4;
					}
					bool flag2;
					global::Motorola.CommonCPS.RadioManagement.SharedServices.IServerAccessor instance;
					for (;;)
					{
						IL_31:
						string text;
						global::Motorola.CommonCPS.RadioManagement.UIModels.UserLoginContext userLoginContext;
						switch (num2)
						{
						case 0:
							goto IL_E10;
						case 1:
							if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.DBMigrationInfo != null)
							{
								num = (short)2103443513;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_163A;
						case 2:
							goto IL_FCB;
						case 3:
							goto IL_F0B;
						case 4:
							num = (short)321978414;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							goto IL_18DB;
						case 6:
							num = (short)1977942031;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
							goto IL_1434;
						case 8:
							goto IL_1332;
						case 9:
							goto IL_726;
						case 10:
							global::Motorola.CommonCPS.RadioManagement.InteractionHelper.InteractionFactory.GetInstance().ShowNotificationDialog(string.Format(global::Motorola.CommonCPS.ResourceRepository.RadioCentral.RadioCentralResources.RMC_FailedToConnectToServer, '\n', '\n'), global::Motorola.CommonCPS.ResourceRepository.Resources.MessageBox_Title_Error);
							global::System.Environment.Exit(4010);
							num = (short)8454207;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 11:
							goto IL_9B5;
						case 12:
							goto IL_18FB;
						case 13:
							if (!this.incompatibilityHandlerHelper.DetectAndHandleIncompatibility())
							{
								num = (short)1047396438;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1332;
						case 14:
							goto IL_1332;
						case 15:
							text = global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.ServerAddress;
							goto IL_6DF;
						case 16:
							userLoginContext.ExceptionMessage = global::Motorola.CommonCPS.ResourceRepository.ResourceHelper.GetCommonErrorMessageByID(global::Motorola.Common.CustomException.CommonErrorCode.RMC_Failed_To_Connect_To_Server.ToString(), null);
							num = (short)1277296660;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 17:
							if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.WorkingSecurePassword != null)
							{
								num = (short)1653604397;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_9FB;
						case 18:
							global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.AuthenticationMethodType = global::Motorola.CommonCPS.RadioManagement.Global.AuthMethod.UserName.ToString();
							global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.UserName = userLoginContext.UserName;
							global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.SecurePassword = userLoginContext.Password.Copy();
							global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.LogInfoToFilenEvent(global::Motorola.CommonCPS.RadioManagement.Core.RadioManagementControlViewModel.q("쮝펟잡횣좥즧잩즫膭삯펱잳억쾷햹캻\udabdꯁ꫃뛅뷇뻉꧋꫍ﻏ", a_), global::Motorola.Common.LogUtility.LoggingLevel.EventInfo);
							num = (short)230621192;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 19:
							goto IL_CF7;
						case 20:
							goto IL_813;
						case 21:
							if (!global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.IsHostedDeployment)
							{
								num = (short)1803681819;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.RadioManagement.InteractionHelper.InteractionFactory.GetInstance().ShowNotificationDialog(string.Format(global::Motorola.CommonCPS.ResourceRepository.RadioCentral.RadioCentralResources.RMC_FailedToConnectToServer, '\n', '\n'), global::Motorola.CommonCPS.ResourceRepository.Resources.MessageBox_Title_Error);
							global::Motorola.CommonCPS.RadioManagement.Common.SplashScreenHelper.Close();
							global::System.Environment.Exit(4019);
							num = (short)1031929882;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 22:
						{
							global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.AuthenticationMethodType = global::Motorola.CommonCPS.RadioManagement.Global.AuthMethod.UserName.ToString();
							global::Motorola.CommonCPS.RadioManagement.UIModels.UserLoginContext userLoginContext2;
							global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.UserName = userLoginContext2.UserName;
							global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.SecurePassword = userLoginContext2.Password.Copy();
							global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.LogInfoToFilenEvent(global::Motorola.CommonCPS.RadioManagement.Core.RadioManagementControlViewModel.q("쮝펟잡횣蚥솧쒩\udcab\udbad쒯銱솳억\uddb7좹튻\udfbd궿ꟁ뛅꧇막뿋뇏듑ꃓ돕꫗龎꣛뛝藟싡鏣迥蛧軩菫駭華틱音蓵鷷黹駻都瓿欁攃樅⠇椉挋怍縏眑眓戕焗甙爛㸝䘟䌡䴣䨥䴧丩ȫ", a_), global::Motorola.Common.LogUtility.LoggingLevel.EventInfo);
							num = (short)1315242033;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 23:
							if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ConnectionFailureReason != global::Motorola.CommonCPS.RadioManagement.Global.ConnectionFailureReasonID.JwtTokenCredentialFirstTimeLogin)
							{
								num = (short)1683226634;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_12CA;
						case 24:
							if (!this.b(""))
							{
								num = (short)1950613532;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1332;
						case 25:
							if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.SecurePassword != null)
							{
								num = (short)1363542078;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_CF7;
						case 26:
							goto IL_1332;
						case 27:
							num = (short)174063675;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 28:
							global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.LogInfoToFilenEvent(global::Motorola.CommonCPS.RadioManagement.Core.RadioManagementControlViewModel.q("쮝펟잡횣蚥쮧쮩슫춭햯\udeb1\ud8b3펵\udcb7骹좻횽ꖿ럃ꏅ볇뻉ꗋꃍ럏냓뿕맗뛙돛망샟胡臣胥蟧飩觫컭華韱蛳胵鷷裹폻鷽泿欁愃栅簇⨉攋怍猏紑礓昕礗渙甛簝䤟両䴣別儧਩䔫崭ု䀱儳䔵圷嘹䨻嬽␿", a_), global::Motorola.Common.LogUtility.LoggingLevel.EventInfo);
							global::Motorola.CommonCPS.RadioManagement.Common.SplashScreenHelper.Close();
							num = (short)646840359;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 29:
						{
							bool flag;
							if (!flag)
							{
								num = (short)949157981;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.LogInfoToFilenEvent(global::Motorola.CommonCPS.RadioManagement.Core.RadioManagementControlViewModel.q("춝얟킡튣쎥\udaa7誩춫삭풯銱ힳ\udab5톷\udfb9튻쪽ꏁ뛃ꏅꏉꋋꏏ돑맓돕럙뷛뷝裟诡諣菥웧쫩귫苭蟯鏱跳藵\ud8f7軹軻蟽⃿甁洃栅氇攉笋⤍挏㈑眓搕紗縙礛瀝吟䬡䔣䨥ا", a_), global::Motorola.Common.LogUtility.LoggingLevel.EventInfo);
							global::Motorola.CommonCPS.RadioManagement.Common.SplashScreenHelper.Hide();
							num = (short)1681260638;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 30:
							goto IL_1914;
						case 31:
							goto IL_35C;
						case 32:
							global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.WorkingJwtToken = global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.JwtToken;
							global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.JwtToken = string.Empty;
							num = (short)766705695;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 33:
							if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.AuthenticationMethodType.Equals(global::Motorola.CommonCPS.RadioManagement.Global.AuthMethod.UserName.ToString()))
							{
								num = (short)365363261;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1332;
						case 34:
							if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.AuthenticationMethodType.Equals(global::Motorola.CommonCPS.RadioManagement.UIModels.AuthenticationMethod.JwtToken.ToString()))
							{
								num = (short)1545011232;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_35C;
						case 35:
							if (!this.b(""))
							{
								num = (short)571408464;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1332;
						case 36:
							goto IL_BD7;
						case 37:
							goto IL_1072;
						case 38:
							goto IL_9FB;
						case 39:
							goto IL_F88;
						case 40:
							goto IL_1332;
						case 41:
							if (!global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.IsHostedDeployment)
							{
								num = (short)1338900491;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.RadioManagement.Common.SplashScreenHelper.Close();
							global::System.Environment.Exit(4009);
							num = (short)2146238546;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 42:
							global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.UserName = string.Empty;
							num = (short)197263444;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 43:
							try
							{
								global::System.Diagnostics.Process.Start(global::System.Windows.Forms.Application.ExecutablePath);
								global::System.Diagnostics.Process.GetCurrentProcess().Kill();
								goto IL_EF2;
							}
							catch
							{
								goto IL_EF2;
							}
							goto IL_1690;
							IL_EF2:
							num = (short)143654915;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 44:
							if (userLoginContext.SubmitSuccess)
							{
								num = (short)1825701906;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.LogInfoToFilenEvent(global::Motorola.CommonCPS.RadioManagement.Core.RadioManagementControlViewModel.q("쮝펟잡횣蚥쮧쮩슫춭햯\udeb1\ud8b3펵\udcb7骹즻춽ꖿ냁꫃Ʂꗇ꿉ꟍ뻏ꋑꇓꋕ믙닛뫝샟胡藣藥菧쫩飫臭탯臱釳苵賷鏹鋻駽⃿昁洃朅搇攉欋‍", a_), global::Motorola.Common.LogUtility.LoggingLevel.EventInfo);
							global::Motorola.CommonCPS.RadioManagement.Common.SplashScreenHelper.Hide();
							num = (short)1092091968;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 45:
							global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.WorkingSecurePassword.Clear();
							num = (short)483328054;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 46:
						{
							string text2;
							if (!this.b(text2.Replace(global::System.Environment.NewLine, global::Motorola.CommonCPS.RadioManagement.Core.RadioManagementControlViewModel.q("뺝", a_))))
							{
								num = (short)1011744856;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1332;
						}
						case 47:
							text = global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.AgencyName;
							goto IL_6DF;
						case 48:
						{
							string text2 = global::Motorola.CommonCPS.ResourceRepository.Resources.InvalidAppConfigCertificatesSection;
							num = (short)2001666114;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 49:
							goto IL_1332;
						case 50:
							global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.LogInfoToFilenEvent(global::Motorola.CommonCPS.RadioManagement.Core.RadioManagementControlViewModel.q("\udd9d쾟첡쪣쎥쮧\udea9얫솭\udeaf銱삳\ud9b5颷즹\ud9bb첽뚿ꟁ뛃믇뿉꿋귍뗏ꇑꟓ냕귗뛙냛꟝샟闡跣鋥胧쫩", a_) + global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.AuthenticationMethodType.ToString(), global::Motorola.Common.LogUtility.LoggingLevel.EventInfo);
							num = (short)1032388683;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 51:
							if (!flag2)
							{
								num = (short)229703740;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_18DB;
						case 52:
							goto IL_CF2;
						case 53:
							goto IL_4AC;
						case 54:
							goto IL_9FB;
						case 55:
							try
							{
								int num3;
								string hostName;
								switch (0)
								{
								case 0:
									break;
								default:
								{
									for (;;)
									{
										IL_870:
										string str;
										switch (num2)
										{
										case 0:
											if (num3 < 0)
											{
												num = (short)136511490;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											num = (short)836567044;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 1:
											goto IL_961;
										case 2:
											num = (short)1630470147;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 3:
											str = hostName;
											goto IL_92E;
										case 4:
											str = hostName.Substring(0, num3);
											goto IL_92E;
										}
										goto IL_88B;
										IL_92E:
										bool flag = global::Motorola.Security.SamlCommonUtility.NameResolver.IsNameResolveable(str + global::Motorola.CommonCPS.RadioManagement.Core.RadioManagementControlViewModel.q("몝", a_));
										num = (short)1522663425;
										num2 = (int)((global::System.IntPtr)num);
									}
									IL_961:
									num = (short)727735476;
									short num4 = num;
									num = (short)986537140;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_8BA;
									default:
										num = (short)1490419712;
										if (num != 0)
										{
										}
										goto IL_1434;
									}
									break;
								}
								}
								IL_88B:
								hostName = global::System.Net.Dns.GetHostEntry(global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ServerAddress).HostName;
								string empty = string.Empty;
								num3 = hostName.IndexOf(global::Motorola.CommonCPS.RadioManagement.Core.RadioManagementControlViewModel.q("낝", a_), global::System.StringComparison.Ordinal);
								IL_8BA:
								num = (short)1442316288;
								num2 = (int)((global::System.IntPtr)num);
								goto IL_870;
							}
							catch
							{
								goto IL_1434;
							}
							goto IL_9B5;
						case 56:
						{
							global::Motorola.CommonCPS.RadioManagement.Global.ConnectionFailureReasonID connectionFailureReason;
							if (connectionFailureReason != global::Motorola.CommonCPS.RadioManagement.Global.ConnectionFailureReasonID.ConfiguredCertificateTypeNotFound)
							{
								num = (short)623312974;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							string text2 = global::Motorola.CommonCPS.ResourceRepository.Resources.ConfiguredCertificateTypeNotFound;
							num = (short)1585709158;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 57:
							goto IL_1690;
						case 58:
						{
							global::Motorola.CommonCPS.RadioManagement.UIModels.UserLoginContext userLoginContext2;
							if (userLoginContext2.SubmitSuccess)
							{
								num = (short)1718353942;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.LogInfoToFilenEvent(global::Motorola.CommonCPS.RadioManagement.Core.RadioManagementControlViewModel.q("쮝펟잡횣蚥첧쾩쾫잭풯ힱ钳\ud8b5ힷ캹鲻쪽꾿귃ꣅ룇뿉룋ꗏꇑ뇓ꓕ듙뷛돝藟췡铣蟥鯧駩鯫臭苯雱퓳韵黷軹駻賽⃿瘁氃挅⠇紉攋怍琏紑挓攕㠗礙減笝䐟䜡䨣別䄧䬩䀫อ匯崱娳堵崷夹䠻圽⼿ⱁ摃⁅⥇⍉⁋⭍㑏籑", a_), global::Motorola.Common.LogUtility.LoggingLevel.EventInfo);
							global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.AuthenticationMethodType = global::Motorola.CommonCPS.RadioManagement.Global.AuthMethod.Windows.ToString();
							global::Motorola.CommonCPS.RadioManagement.Common.SplashScreenHelper.Hide();
							num = (short)1108279331;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 59:
							if (!this.b(global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_FailedToConnectToServer.Replace(global::System.Environment.NewLine, global::Motorola.CommonCPS.RadioManagement.Core.RadioManagementControlViewModel.q("뺝", a_))))
							{
								num = (short)1493303370;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1332;
						case 60:
							instance.Connect(global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ServerAddress, global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ServerPort, global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ServerAddress, global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.AuthenticationMethodType, global::System.Threading.SynchronizationContext.Current, global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.UserName, global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.SecurePassword, false, global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.JwtToken);
							num = (short)1394016261;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 61:
							global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ConnectionFailureReason = global::Motorola.CommonCPS.RadioManagement.Global.ConnectionFailureReasonID.UserNameFirstTimeLogin;
							flag2 = true;
							num = (short)1432158287;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 62:
							global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.SecurePassword.Clear();
							num = (short)408682515;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 63:
							goto IL_12CA;
						case 64:
							if (!this.b(""))
							{
								num = (short)1614938218;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1258225697;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 65:
							num = (short)1613561904;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 66:
							goto IL_FD0;
						case 67:
							goto IL_FD0;
						case 68:
							if (global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.ServerPort != global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ServerPort)
							{
								num = (short)1341259812;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1128;
						case 69:
							goto IL_1128;
						case 70:
							if (!global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.IsCurrentSessionConnected)
							{
								num = (short)1571749991;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_18FB;
						case 71:
							goto IL_17BC;
						case 72:
							if (!this.b(""))
							{
								num = (short)1886781549;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ConnectionFailureReason = global::Motorola.CommonCPS.RadioManagement.Global.ConnectionFailureReasonID.UserNameFirstTimeLogin;
							flag2 = true;
							num = (short)720109608;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 73:
							goto IL_1332;
						case 74:
							global::Motorola.CommonCPS.RadioManagement.Common.SplashScreenHelper.Close();
							num = (short)878706688;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 75:
							if (string.Equals(global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.ServerAddress, global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ServerAddress.Trim(), global::System.StringComparison.OrdinalIgnoreCase))
							{
								num = (short)1380450412;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_BD7;
						case 76:
						{
							global::Motorola.CommonCPS.RadioManagement.UIModels.ChangePasswordContext changePasswordContext;
							global::System.Security.SecureString currentPassword = changePasswordContext.CurrentPassword;
							currentPassword.MakeReadOnly();
							num = (short)905052255;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 77:
							if (global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.CheckIfLocalHost(global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ServerAddress))
							{
								num = (short)113180769;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)251461687;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 78:
							num = (short)1465319514;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 79:
							goto IL_1332;
						case 80:
							global::Motorola.CommonCPS.RadioManagement.Common.SplashScreenHelper.Close();
							num = (short)1315635271;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 81:
							global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.SecurePassword.Clear();
							num = (short)1316683813;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 82:
							goto IL_1332;
						case 83:
							num = (short)29360238;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 84:
							if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.SecurePassword != null)
							{
								num = (short)1834287185;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1072;
						case 85:
							goto IL_D74;
						case 86:
							global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.LogInfoToFilenEvent(global::Motorola.CommonCPS.RadioManagement.Core.RadioManagementControlViewModel.q("\udf9d햟횡쮣펥\ud8a7충\udeab쾭풯ힱ钳\udfb5쮷骹튻톽뒿듃듅Ꟈ꧉꧋ꯍ듏럑냓𥉉룙뷛뷝诟싡郣觥죧駩觫髭蓯鯱髳釵\ud8f7黹闻鿽泿洁挃", a_), global::Motorola.Common.LogUtility.LoggingLevel.EventInfo);
							num = (short)1883963433;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 87:
							global::Motorola.CommonCPS.RadioManagement.Common.SplashScreenHelper.Close();
							num = (short)1781137410;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 88:
							global::Motorola.CommonCPS.RadioManagement.Common.SplashScreenHelper.Close();
							num = (short)1105133653;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 89:
							if (!global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.IsHostedDeployment)
							{
								num = (short)223346694;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1209401391;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 90:
						{
							global::Motorola.CommonCPS.RadioManagement.Global.ConnectionFailureReasonID connectionFailureReason;
							if (connectionFailureReason != global::Motorola.CommonCPS.RadioManagement.Global.ConnectionFailureReasonID.AmbiguousCertificatesFound)
							{
								num = (short)1622016065;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							string text2 = global::Motorola.CommonCPS.ResourceRepository.Resources.AmbiguousCertificatesFound;
							num = (short)1750990915;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 91:
							global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.SecurePassword.Clear();
							num = (short)63635494;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 92:
							if (!global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.IsHostedDeployment)
							{
								num = (short)601686020;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.RadioManagement.InteractionHelper.InteractionFactory.GetInstance().ShowNotificationDialog(string.Format(global::Motorola.CommonCPS.ResourceRepository.RadioCentral.RadioCentralResources.RMC_FailedToConnectToServer, '\n', '\n'), global::Motorola.CommonCPS.ResourceRepository.Resources.MessageBox_Title_Error);
							global::Motorola.CommonCPS.RadioManagement.Common.SplashScreenHelper.Close();
							global::System.Environment.Exit(4018);
							num = (short)1150418958;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 93:
						{
							global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.LogInfoToFilenEvent(global::Motorola.CommonCPS.RadioManagement.Core.RadioManagementControlViewModel.q("춝얟킡튣쎥\udaa7誩춫삭풯銱ힳ\udab5톷\udfb9튻쪽ꏁ뛃ꏅ꓉ꏋ뫍믑뫓ꯗ믙뇛믝샟迡藣藥胧菩苫语\udeef틱ꃳ蓵臷\udaf9ꧻ跽旿瀁䨃朅攇漉∋", a_), global::Motorola.Common.LogUtility.LoggingLevel.EventInfo);
							global::Motorola.CommonCPS.RadioManagement.UIModels.UserLoginContext userLoginContext2 = new global::Motorola.CommonCPS.RadioManagement.UIModels.UserLoginContext
							{
								UserName = string.Empty,
								Password = new global::System.Security.SecureString()
							};
							global::Motorola.CommonCPS.RadioManagement.Common.SplashScreenHelper.Hide();
							global::Motorola.CommonCPS.RadioManagement.InteractionHelper.InteractionFactory.GetInstance().LoginUserDialog(userLoginContext2);
							num = (short)1039466554;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 94:
							if (!this.b(global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Try_Windows_Again))
							{
								num = (short)871563351;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1332;
						case 95:
							try
							{
								switch (0)
								{
								case 0:
									goto IL_14BC;
								}
								global::Motorola.CommonCPS.RadioManagement.UIModels.ChangePasswordContext changePasswordContext;
								int num5;
								for (;;)
								{
									IL_14A1:
									switch (num2)
									{
									case 0:
										if (num5 != 0)
										{
											num = (short)1949892610;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.LogInfoToFilenEvent(global::Motorola.CommonCPS.RadioManagement.Core.RadioManagementControlViewModel.q("\udf9d쎟횡춣킥즧\udea9즫躭얯솱톳쒵颷즹즻\uddbdꎿꟁ럃뗅껇뿉ꃋꋍꧏﳑ", a_), global::Motorola.Common.LogUtility.LoggingLevel.EventInfo);
										global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.SecurePassword = changePasswordContext.NewPassword.Copy();
										num = (short)781451268;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										goto IL_15F4;
									case 2:
										global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.LogInfoToFilenEvent(global::Motorola.CommonCPS.RadioManagement.Core.RadioManagementControlViewModel.q("\udd9d좟쎡쪣솥춧誩\udcab쾭쎯솱쎳\ud9b5쪷\udeb9鲻\ud8bd떿곁ꟃ뫇꿉룋믍ꋏ병룕뷗뷙뷛ꫝ觟铡臣웥黧诩胫鯭闯틱闳飵鳷\udaf9髻鿽槿渁愃戅☇⨉帋欍搏朑易砕㠗氙紛爝唟䜡У伥嬧਩", a_) + num5.ToString(global::System.Globalization.CultureInfo.InvariantCulture), global::Motorola.Common.LogUtility.LoggingLevel.EventInfo);
										global::Motorola.CommonCPS.RadioManagement.InteractionHelper.InteractionFactory.GetInstance().ShowNotificationDialog(global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_ChangeRMUserPassword_ChangePasswordFailed, global::Motorola.CommonCPS.ResourceRepository.Resources.Validator_MessageBox_Caption);
										num = (short)1806630915;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 3:
										goto IL_15DC;
									case 4:
										goto IL_15DC;
									}
									goto IL_14BC;
									IL_15DC:
									num = (short)1175846913;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_15F4:
								goto IL_1332;
								IL_14BC:
								global::System.Security.SecureString currentPassword;
								num5 = instance.ChangePassword(this.a(changePasswordContext.CurrentPassword), this.a(changePasswordContext.NewPassword), global::Motorola.CommonCPS.RadioManagement.Core.RadioManagementControlViewModel.q("颟隡那钥鞭鶯芳螵袷鞹袻薿胁ﻅﷇ﷉﯋鯗鷝훟ꛡꇣ퓥闧", a_), global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.AuthenticationMethodType, global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ServerAddress, global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ServerPort, global::Motorola.CommonCPS.RadioManagement.Core.RadioManagementControlViewModel.q("첝춣향쮧얩\udaab쮭슯쮱펵쪷첹\ud9bb첽", a_), global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.UserName, currentPassword, true);
								num = (short)734199808;
								num2 = (int)((global::System.IntPtr)num);
								goto IL_14A1;
							}
							catch (global::System.Exception ex)
							{
								global::Motorola.CommonCPS.RadioManagement.InteractionHelper.InteractionFactory.GetInstance().ShowNotificationDialog(global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_ChangeRMUserPassword_ChangePasswordFailed, global::Motorola.CommonCPS.ResourceRepository.Resources.Validator_MessageBox_Caption);
								global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.LogExpToFilenEvent(ex, global::Motorola.Common.LogUtility.LoggingLevel.EventInfo, global::Motorola.CommonCPS.RadioManagement.Core.RadioManagementControlViewModel.q("횝솟첡삣잧쒩슫쮭펯욱\uddb3\ud9b5횷\ud9bb춽떿껁냃", a_));
								global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.LogInfoToFilenEvent(global::Motorola.CommonCPS.RadioManagement.Core.RadioManagementControlViewModel.q("\udd9d좟쎡쪣솥춧誩\udcab쾭쎯솱쎳\ud9b5쪷\udeb9鲻\ud8bd떿곁ꟃꯇꯉ맋뷍뗏ꇑ돕ꃗ맙맛껝铟诡诣裥죧裩觫裭鿯胱釳훵请鿹裻諽槿氁挃★稇漉砋笍戏簑㐓怕礗瘙椛笝ฟ", a_), global::Motorola.Common.LogUtility.LoggingLevel.EventInfo);
								goto IL_1332;
							}
							goto IL_163A;
						case 96:
							if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ConnectionFailureReason != global::Motorola.CommonCPS.RadioManagement.Global.ConnectionFailureReasonID.UserNameFirstTimeLogin)
							{
								num = (short)1803943952;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_813;
						case 97:
						{
							bool flag = true;
							num = (short)1987313671;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 98:
						{
							if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.IsCurrentSessionConnected)
							{
								num = (short)1238630450;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.RadioManagement.Global.ConnectionFailureReasonID connectionFailureReason2 = global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ConnectionFailureReason;
							num = (short)1066991717;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 99:
							if (!global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.AuthenticationMethodType.Equals(global::Motorola.CommonCPS.RadioManagement.UIModels.AuthenticationMethod.UserName.ToString()))
							{
								num = (short)440205354;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.WorkingUserName = global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.UserName;
							global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.WorkingSecurePassword = global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.SecurePassword.Copy();
							global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.UserName = string.Empty;
							num = (short)1327890532;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 100:
							if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.SecurePassword != null)
							{
								num = (short)1218510939;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_9FB;
						case 101:
						{
							global::Motorola.CommonCPS.RadioManagement.Global.ConnectionFailureReasonID connectionFailureReason2;
							switch (connectionFailureReason2)
							{
							case global::Motorola.CommonCPS.RadioManagement.Global.ConnectionFailureReasonID.ServiceNotCompatibleWithClientVersion:
								global::Motorola.CommonCPS.RadioManagement.Common.SplashScreenHelper.Hide();
								global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.LogInfoToFilenEvent(global::Motorola.CommonCPS.RadioManagement.Core.RadioManagementControlViewModel.q("춝얟킡튣쎥\udaa7薩슭\ud9afힱ\udab3습颷첹\ud9bb첽뎿ꯁꯃꣅꏉꋋ귍뿏뿑ꓓ럕곗동뻛럝賟诡郣鿥죧軩觫髭闯釱胳鏵鳷퓹", a_), global::Motorola.Common.LogUtility.LoggingLevel.EventInfo);
								num = (short)298909709;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case global::Motorola.CommonCPS.RadioManagement.Global.ConnectionFailureReasonID.UserNameLoginFailed:
							case global::Motorola.CommonCPS.RadioManagement.Global.ConnectionFailureReasonID.UserNameFirstTimeLogin:
								global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.UserName = string.Empty;
								num = (short)2079784985;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case global::Motorola.CommonCPS.RadioManagement.Global.ConnectionFailureReasonID.WindowsCredentialLoginFailed:
							{
								bool flag = false;
								num = (short)563675213;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case global::Motorola.CommonCPS.RadioManagement.Global.ConnectionFailureReasonID.WinowsCredentialFirstTimeLogin:
							case global::Motorola.CommonCPS.RadioManagement.Global.ConnectionFailureReasonID.CannotConnectToDiscoveryServer:
							case global::Motorola.CommonCPS.RadioManagement.Global.ConnectionFailureReasonID.CannotConnectToTargetServer:
								goto IL_436;
							case global::Motorola.CommonCPS.RadioManagement.Global.ConnectionFailureReasonID.UserNotActived:
							{
								global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.LogInfoToFilenEvent(global::Motorola.CommonCPS.RadioManagement.Core.RadioManagementControlViewModel.q("힝캟쎡잣튥솧\udca9즫躭얯솱톳쒵隷骹첽릿냃꧅ꯉ꿋뫍맏ꓑ뗓ꋕ뷗龎꧛귝藟郡쫣", a_), global::Motorola.Common.LogUtility.LoggingLevel.EventInfo);
								global::Motorola.CommonCPS.RadioManagement.UIModels.ChangePasswordContext changePasswordContext = new global::Motorola.CommonCPS.RadioManagement.UIModels.ChangePasswordContext();
								global::Motorola.CommonCPS.RadioManagement.Common.SplashScreenHelper.Hide();
								global::Motorola.CommonCPS.RadioManagement.InteractionHelper.InteractionFactory.GetInstance().ChangePasswordDialog(changePasswordContext);
								num = (short)566493291;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case global::Motorola.CommonCPS.RadioManagement.Global.ConnectionFailureReasonID.AnotherRMCDoingDBMigration:
								global::Motorola.CommonCPS.RadioManagement.Common.SplashScreenHelper.Hide();
								global::Motorola.CommonCPS.RadioManagement.InteractionHelper.InteractionFactory.GetInstance().ShowNotificationDialog(global::Motorola.CommonCPS.ResourceRepository.Resources.DB_MIGRATION_ANOTHER_RMC_DOING_MIGRATION, global::Motorola.CommonCPS.ResourceRepository.Resources.DB_Migration);
								num = (short)61734964;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case global::Motorola.CommonCPS.RadioManagement.Global.ConnectionFailureReasonID.AnotherRMCDoingDBUpgrade:
								global::Motorola.CommonCPS.RadioManagement.Common.SplashScreenHelper.Hide();
								global::Motorola.CommonCPS.RadioManagement.InteractionHelper.InteractionFactory.GetInstance().ShowNotificationDialog(global::Motorola.CommonCPS.ResourceRepository.Resources.DBUPGRADE_PROCESSING, global::Motorola.CommonCPS.ResourceRepository.Resources.DB_Migration);
								num = (short)555483240;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case global::Motorola.CommonCPS.RadioManagement.Global.ConnectionFailureReasonID.ConfiguredCertificateTypeNotFound:
							case global::Motorola.CommonCPS.RadioManagement.Global.ConnectionFailureReasonID.InvalidAppConfigCertificatesSection:
							case global::Motorola.CommonCPS.RadioManagement.Global.ConnectionFailureReasonID.AmbiguousCertificatesFound:
							{
								global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.LogInfoToFilenEvent(global::Motorola.CommonCPS.RadioManagement.Core.RadioManagementControlViewModel.q("\udd9d쾟첡쪣쎥쮧\udea9얫솭\udeaf銱튳ힵ톷횹\ud9bb\udabdꛁ뇃ꏅ뻉ꏋ돏럑ꛓꋕ뇗볙뗛뷝臟雡臣闥죧髩黫臭鋯黱釳鯵훷\udaf9뻻鿽揿椁␃爅朇⨉缋欍搏昑紓砕缗㨙砛眝䄟両䬣䄥ا", a_), global::Motorola.Common.LogUtility.LoggingLevel.EventInfo);
								global::Motorola.CommonCPS.RadioManagement.Global.ConnectionFailureReasonID connectionFailureReason = global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ConnectionFailureReason;
								num = (short)625606712;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case global::Motorola.CommonCPS.RadioManagement.Global.ConnectionFailureReasonID.JwtTokenCredentialLoginFailed:
							case global::Motorola.CommonCPS.RadioManagement.Global.ConnectionFailureReasonID.JwtTokenCredentialFirstTimeLogin:
								num = (short)343867415;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							default:
								num = (short)1948450899;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 102:
							goto IL_FD0;
						case 103:
							num = (short)1257701427;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 104:
							goto IL_1745;
						case 105:
							goto IL_1123;
						case 106:
							global::Motorola.CommonCPS.RadioManagement.Common.SplashScreenHelper.Close();
							num = (short)2089091177;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 107:
						{
							global::Motorola.CommonCPS.RadioManagement.UIModels.ChangePasswordContext changePasswordContext;
							if (changePasswordContext.SubmitSuccess)
							{
								num = (short)441843788;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.LogInfoToFilenEvent(global::Motorola.CommonCPS.RadioManagement.Core.RadioManagementControlViewModel.q("쮝펟잡횣蚥첧쾩쾫잭풯ힱ钳\ud8b5ힷ캹鲻쪽꾿ꗃꗅ볇ꏉ뫋ꯍꛑ볓돕믙뿛뷝迟韡諣鋥웧쫩껫迭鏯駱퓳苵韷\udaf9迻鯽瓿瘁洃栅漇⨉栋服焏縑笓焕", a_), global::Motorola.Common.LogUtility.LoggingLevel.EventInfo);
							global::Motorola.CommonCPS.RadioManagement.Common.SplashScreenHelper.Hide();
							num = (short)587399240;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 108:
							num = (short)269549636;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 109:
							global::Motorola.CommonCPS.RadioManagement.Common.SplashScreenHelper.Close();
							num = (short)638976053;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 110:
							goto IL_436;
						}
						goto IL_1F4;
						IL_35C:
						num = (short)1326710883;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_436:
						global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.LogInfoToFilenEvent(global::Motorola.CommonCPS.RadioManagement.Core.RadioManagementControlViewModel.q("\udd9d쾟첡쪣쎥쮧\udea9얫솭\udeaf銱튳ힵ톷횹\ud9bb\udabdꛁ뇃ꏅ뻉ꏋ럏럑뫓돕꫗동뿛ﻝ蛟菡跣諥鷧飩觫컭苯韱闳藵韷铹틻\udefd䋿持會洅⠇縉挋⸍挏眑怓戕焗琙笛㸝䐟䬡䔣䨥䜧䴩ȫ", a_), global::Motorola.Common.LogUtility.LoggingLevel.EventInfo);
						global::Motorola.CommonCPS.RadioManagement.Common.SplashScreenHelper.Hide();
						num = (short)1267204117;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_6DF:
						string text3 = text;
						global::Motorola.CommonCPS.RadioManagement.InteractionHelper.InteractionFactory.GetInstance().ReportStatus(global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Status_Connection + global::Motorola.CommonCPS.RadioManagement.Core.RadioManagementControlViewModel.q("뺝", a_) + text3.ToUpper(global::System.Globalization.CultureInfo.InvariantCulture));
						num = (short)676134921;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_813:
						global::Motorola.CommonCPS.RadioManagement.Common.SplashScreenHelper.Hide();
						global::Motorola.CommonCPS.RadioManagement.InteractionHelper.InteractionFactory.GetInstance().LoginUserDialog(userLoginContext);
						num = (short)837681196;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_9B5:
						num = (short)293273624;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_9FB:
						global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.LogInfoToFilenEvent(global::Motorola.CommonCPS.RadioManagement.Core.RadioManagementControlViewModel.q("첝햟첡킣쾥얧쾩貫잭\udeaf풱\udbb3쒵햷\udbb9좻ힽ꾿곁꧇뿉룋ꛍ꓏ꯑꓓ돕龎꧛껝蓟菡郣菥賧쓩", a_), global::Motorola.Common.LogUtility.LoggingLevel.EventInfo);
						num = (short)1174011993;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_BD7:
						global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.LogInfoToFilenEvent(global::Motorola.CommonCPS.RadioManagement.Core.RadioManagementControlViewModel.q("\udd9d쾟첡쪣쎥쮧\udea9즫쪭邯욱\udbb3隵\ud9b7骹튻\udbbd랿럃ꏅ뫇볉꧋볍", a_), global::Motorola.Common.LogUtility.LoggingLevel.EventInfo);
						num = (short)1864892417;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_CF7:
						userLoginContext = new global::Motorola.CommonCPS.RadioManagement.UIModels.UserLoginContext
						{
							UserName = string.Empty,
							Password = new global::System.Security.SecureString()
						};
						num = (short)318373984;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_FD0:
						global::Motorola.CommonCPS.RadioManagement.Common.SplashScreenHelper.Hide();
						num = (short)1986723932;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_1072:
						global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.WorkingUserName = string.Empty;
						num = (short)1218379793;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_1128:
						global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.ServerAddress = global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ServerAddress;
						global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.ServerPort = global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ServerPort;
						global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.Save();
						global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.WorkingAuthenticationMethodType = global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.AuthenticationMethodType;
						global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.IsConnected = global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.IsCurrentSessionConnected;
						global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.LogInfoToFilenEvent(global::Motorola.CommonCPS.RadioManagement.Core.RadioManagementControlViewModel.q("쮝펟잡횣蚥얩슫좭\ud9af햱钳억\ud9b7첹\ud9bb\udabd", a_), global::Motorola.Common.LogUtility.LoggingLevel.EventInfo);
						num = (short)659357730;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_12CA:
						this.j();
						global::Motorola.CommonCPS.RadioManagement.SharedServices.IServerAccessor serverAccessor = instance;
						serverAccessor.InvalidJwtTokenDetected = (global::System.EventHandler)global::System.Delegate.Combine(serverAccessor.InvalidJwtTokenDetected, new global::System.EventHandler(this.c));
						num = (short)1458110537;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_1332:
						global::Motorola.CommonCPS.RadioManagement.Common.SplashScreenHelper.Show();
						global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.LogInfoToFilenEvent(global::Motorola.CommonCPS.RadioManagement.Core.RadioManagementControlViewModel.q("\uda9d쾟芡킣캥춧誩춫춭쒯잱햳\udab5颷\ud9b9펻킽꺿ꟁꟃ닅ꇇꗉꋋ", a_), global::Motorola.Common.LogUtility.LoggingLevel.EventInfo);
						num = (short)1424556102;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_1434:
						num = (short)93519901;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_163A:
						global::Motorola.CommonCPS.RadioManagement.InteractionHelper.InteractionFactory.GetInstance().Redirect(global::Motorola.CommonCPS.RadioManagement.Core.RadioManagementControlViewModel.q("첝솟욡춣즥", a_));
						num = (short)1574895685;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_1690:
						global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.ServerAddress = global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ServerAddress;
						global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.ServerPort = global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ServerPort;
						global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.Save();
						global::Motorola.CommonCPS.RadioManagement.InteractionHelper.InteractionFactory.GetInstance().ShowNotificationDialog(global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_DBMigration_Restart, global::Motorola.CommonCPS.ResourceRepository.Resources.MessageBox_Title_Warning);
						num = (short)520486955;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_18DB:
						this.HandleConnectResults();
						num = (short)1451360268;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_18FB:
						num = (short)642514974;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_4AC:
					IL_726:
					IL_CF2:
					IL_D74:
					IL_E10:
					IL_F0B:
					IL_F88:
					IL_FCB:
					IL_1123:
					IL_1745:
					IL_17BC:
					IL_1914:
					break;
					IL_1F4:
					flag2 = false;
					instance = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(false, false);
					num = (short)1937571938;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_31;
				}
				}
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.LogExpToFilenEvent(exception, global::Motorola.Common.LogUtility.LoggingLevel.EventError, global::Motorola.CommonCPS.RadioManagement.Core.RadioManagementControlViewModel.q("횝솟첡삣쪥춧쎫삭햯\udcb1ힳ습\udfb9쾻쮽겿뛁럃", a_));
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
			}
			num = (short)418316289;
			if (num != 0)
			{
			}
			num = (short)1156710400;
			short num6 = num;
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00007E38 File Offset: 0x00006038
		private void j()
		{
			int a_ = 4;
			short num = (short)1368653824;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_9B;
				}
				global::Motorola.CommonCPS.RadioManagement.UIModels.SelectAgencyContext selectAgencyContext;
				global::Motorola.CommonCPS.RadioManagement.UIModels.OAuthLoginContext oauthLoginContext;
				global::System.Collections.Generic.List<global::Motorola.Security.SamlCommonUtility.DMHttpClients.AgencyInfo> agencyInfoById;
				for (;;)
				{
					IL_30:
					bool flag;
					global::System.Collections.Generic.List<global::Motorola.Security.SamlCommonUtility.DMHttpClients.AgencyId> list;
					global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, string>> headers;
					global::Motorola.CommonCPS.RadioManagement.SharedServices.DMServiceAccessor dmserviceAccessor;
					switch (num2)
					{
					case 0:
						goto IL_5C4;
					case 1:
						if (selectAgencyContext.SubmitSuccess)
						{
							num = (short)244580358;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2B9;
					case 2:
						goto IL_256;
					case 3:
						if (flag)
						{
							num = (short)497352724;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_77B;
					case 4:
						if (oauthLoginContext.LoginResult == global::Motorola.CommonCPS.RadioManagement.UIModels.OAuthLoginResult.Success)
						{
							num = (short)1866203146;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)715587605;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_25B;
					case 6:
						num = (short)1427963913;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_737;
					case 8:
						if (list.Count < 1)
						{
							num = (short)1984233472;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_25B;
					case 9:
						if (selectAgencyContext.SelectedAgency != null)
						{
							num = (short)2116616194;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2B9;
					case 10:
					{
						global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.AuthenticationMethodType = global::Motorola.CommonCPS.RadioManagement.Global.AuthMethod.JwtToken.ToString();
						global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.JwtToken = oauthLoginContext.IdentityToken;
						num = (short)1424490496;
						short num3 = num;
						num = (short)1547567116;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
						if (list != null)
						{
							num = (short)697499655;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5C4;
					case 12:
						goto IL_3A7;
					case 13:
						global::System.Environment.Exit(0);
						num = (short)1231355920;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
					{
						string value = oauthLoginContext.User.FindFirst(global::Motorola.CommonCPS.RadioManagement.Core.RadioManagementControlViewModel.q("ﺚﮜ爵펠톢삤쎦\udeaa\udeac쪮쎰\uddb2풴\udab6\udcb8", a_)).Value;
						global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.PreferredUsernameFromToken = value;
						headers = new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, string>>
						{
							new global::System.Collections.Generic.KeyValuePair<string, string>(global::Motorola.CommonCPS.RadioManagement.Core.RadioManagementControlViewModel.q("쒖ﲘ슠욢쒦쪨쒪\ud8ac솮얰운튶쮸", a_), value),
							new global::System.Collections.Generic.KeyValuePair<string, string>(global::Motorola.CommonCPS.RadioManagement.Core.RadioManagementControlViewModel.q("쒖ﲞ쒠햤힦", a_), global::Motorola.CommonCPS.RadioManagement.Core.RadioManagementControlViewModel.q("얖풘\ud89a쒠춢톤", a_))
						};
						dmserviceAccessor = new global::Motorola.CommonCPS.RadioManagement.SharedServices.DMServiceAccessor();
						list = new global::System.Collections.Generic.List<global::Motorola.Security.SamlCommonUtility.DMHttpClients.AgencyId>();
						num = (short)10420247;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 15:
						if (oauthLoginContext.User != null)
						{
							num = (short)2078146574;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7C0;
					case 16:
						goto IL_3A7;
					case 17:
					{
						string value;
						selectAgencyContext = new global::Motorola.CommonCPS.RadioManagement.UIModels.SelectAgencyContext
						{
							UserName = value,
							AvailableAgencies = new global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.Security.SamlCommonUtility.DMHttpClients.AgencyInfo>(agencyInfoById)
						};
						global::Motorola.CommonCPS.RadioManagement.InteractionHelper.InteractionFactory.GetInstance().ShowSelectAgencyDialog(selectAgencyContext);
						num = (short)704249857;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 18:
						try
						{
							oauthLoginContext = this.i();
						}
						catch (global::Motorola.Common.CustomException.CommonException ex)
						{
							if (ex.ErrorCode == global::Motorola.Common.CustomException.CommonErrorCode.RMC_Authentication_Provider_Error)
							{
								string commonErrorMessageByID = global::Motorola.CommonCPS.ResourceRepository.ResourceHelper.GetCommonErrorMessageByID(global::Motorola.Common.CustomException.CommonErrorCode.RMC_Authentication_Provider_Error.ToString(), null);
								global::Motorola.CommonCPS.RadioManagement.InteractionHelper.InteractionFactory.GetInstance().ShowNotificationDialog(commonErrorMessageByID, global::Motorola.CommonCPS.ResourceRepository.Resources.MessageBox_Title_Error);
							}
							else
							{
								string commonErrorMessageByID2 = global::Motorola.CommonCPS.ResourceRepository.ResourceHelper.GetCommonErrorMessageByID(global::Motorola.Common.CustomException.CommonErrorCode.RMC_OAuth_Login_Error.ToString(), null);
								global::Motorola.CommonCPS.RadioManagement.InteractionHelper.InteractionFactory.GetInstance().ShowNotificationDialog(commonErrorMessageByID2, global::Motorola.CommonCPS.ResourceRepository.Resources.MessageBox_Title_Error);
							}
							global::System.Environment.Exit(4016);
						}
						catch (global::System.Exception)
						{
							string commonErrorMessageByID3 = global::Motorola.CommonCPS.ResourceRepository.ResourceHelper.GetCommonErrorMessageByID(global::Motorola.Common.CustomException.CommonErrorCode.RMC_OAuth_Login_Error.ToString(), null);
							global::Motorola.CommonCPS.RadioManagement.InteractionHelper.InteractionFactory.GetInstance().ShowNotificationDialog(commonErrorMessageByID3, global::Motorola.CommonCPS.ResourceRepository.Resources.MessageBox_Title_Error);
							global::System.Environment.Exit(4016);
						}
						num = (short)312213508;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						goto IL_3A7;
					case 20:
					{
						string commonErrorMessageByID4 = global::Motorola.CommonCPS.ResourceRepository.ResourceHelper.GetCommonErrorMessageByID(global::Motorola.Common.CustomException.CommonErrorCode.RMC_AgencyName_Lookup_Warning.ToString(), null);
						global::Motorola.CommonCPS.RadioManagement.InteractionHelper.InteractionFactory.GetInstance().ShowNotificationDialog(commonErrorMessageByID4, global::Motorola.CommonCPS.ResourceRepository.Resources.MessageBox_Title_Warning);
						num = (short)239140886;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 21:
					{
						if (oauthLoginContext.LoginResult == global::Motorola.CommonCPS.RadioManagement.UIModels.OAuthLoginResult.UserCancel)
						{
							num = (short)310050829;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						string commonErrorMessageByID5 = global::Motorola.CommonCPS.ResourceRepository.ResourceHelper.GetCommonErrorMessageByID(global::Motorola.Common.CustomException.CommonErrorCode.RMC_OAuth_Login_Error.ToString(), null);
						global::Motorola.CommonCPS.RadioManagement.InteractionHelper.InteractionFactory.GetInstance().ShowNotificationDialog(commonErrorMessageByID5, global::Motorola.CommonCPS.ResourceRepository.Resources.MessageBox_Title_Error);
						global::System.Environment.Exit(4011);
						num = (short)1756037139;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 22:
					{
						num = (short)1284286058;
						short num4 = num;
						num = (short)945923690;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_256;
						default:
							num = (short)265486337;
							if (num != 0)
							{
							}
							num = (short)1357578240;
							if (num != 0)
							{
							}
							goto IL_77B;
						}
						break;
					}
					case 23:
						try
						{
							global::Motorola.Security.SamlCommonUtility.DMHttpClients.DMAuthorizationServiceClient dmAuthSvcClient = global::Motorola.Security.SamlCommonUtility.DMHttpClients.DMHttpClientFactory<global::Motorola.Security.SamlCommonUtility.DMHttpClients.DMAuthorizationServiceClient>.Create(oauthLoginContext.IdentityToken, headers);
							string value;
							list = dmserviceAccessor.GetAgencyIdsForUser(dmAuthSvcClient, value);
							goto IL_176;
						}
						catch (global::System.Exception ex2)
						{
							global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.LogInfoToFilenEvent(global::Motorola.CommonCPS.RadioManagement.Core.RadioManagementControlViewModel.q("튖膠톢삤펦\udba8슪좬\ud9ae\ud8b0\uddb2튴鞶첸좺\ud8bc춾苂ꋄꋆꟈ꣊듌飐럒ꛔﯚ", a_) + ex2.Message, global::Motorola.Common.LogUtility.LoggingLevel.EventInfo);
							string commonErrorMessageByID6 = global::Motorola.CommonCPS.ResourceRepository.ResourceHelper.GetCommonErrorMessageByID(global::Motorola.Common.CustomException.CommonErrorCode.RMC_User_Agencies_Retriever_Error.ToString(), null);
							global::Motorola.CommonCPS.RadioManagement.InteractionHelper.InteractionFactory.GetInstance().ShowNotificationDialog(commonErrorMessageByID6, global::Motorola.CommonCPS.ResourceRepository.Resources.MessageBox_Title_Error);
							global::System.Environment.Exit(4012);
							goto IL_176;
						}
						goto IL_737;
						IL_176:
						num = (short)1388576779;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
						if (agencyInfoById.Count > 1)
						{
							num = (short)1399128081;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_360;
					}
					goto IL_9B;
					IL_25B:
					flag = false;
					global::Motorola.Security.SamlCommonUtility.DMHttpClients.DMAgencyAdminServiceClient dmAgencyAdminSvcClient = global::Motorola.Security.SamlCommonUtility.DMHttpClients.DMHttpClientFactory<global::Motorola.Security.SamlCommonUtility.DMHttpClients.DMAgencyAdminServiceClient>.Create(oauthLoginContext.IdentityToken, headers);
					agencyInfoById = dmserviceAccessor.GetAgencyInfoById(dmAgencyAdminSvcClient, list, out flag);
					num = (short)1173159939;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3A7:
					num = (short)300351503;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5C4:
					string commonErrorMessageByID7 = global::Motorola.CommonCPS.ResourceRepository.ResourceHelper.GetCommonErrorMessageByID(global::Motorola.Common.CustomException.CommonErrorCode.RMC_No_User_Agency.ToString(), null);
					global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.LogInfoToFilenEvent(commonErrorMessageByID7, global::Motorola.Common.LogUtility.LoggingLevel.EventInfo);
					global::Motorola.CommonCPS.RadioManagement.InteractionHelper.InteractionFactory.GetInstance().ShowNotificationDialog(commonErrorMessageByID7, global::Motorola.CommonCPS.ResourceRepository.Resources.MessageBox_Title_Error);
					global::System.Environment.Exit(4013);
					num = (short)1147797509;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_737:
					num = (short)16646152;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_77B:
					num = (short)1117323288;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_256:
				global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.AgencyId = selectAgencyContext.SelectedAgency.provAgencyId;
				global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.AgencyName = selectAgencyContext.SelectedAgency.provAgencyName;
				global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ServerAddress = global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.AgencyId + global::Motorola.CommonCPS.RadioManagement.Core.RadioManagementControlViewModel.q("릖", a_) + global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ServerAddress;
				return;
				IL_2B9:
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.LogInfoToFilenEvent(global::Motorola.CommonCPS.RadioManagement.Core.RadioManagementControlViewModel.q("횖ﺘﺚﲞ\ud8a0莢횤슦얨캪캬\udbae\ud8b0\udcb2\udbb4鞶\udab8\udaba펼\udcbe꓀꿂꧄ꋆ귈꿌뛎꟒뷔닖律껚껜뫞鏠", a_), global::Motorola.Common.LogUtility.LoggingLevel.EventInfo);
				global::System.Environment.Exit(4014);
				return;
				IL_360:
				global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.AgencyId = agencyInfoById[0].provAgencyId;
				global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.AgencyName = agencyInfoById[0].provAgencyName;
				global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ServerAddress = global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.AgencyId + global::Motorola.CommonCPS.RadioManagement.Core.RadioManagementControlViewModel.q("릖", a_) + global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ServerAddress;
				return;
				IL_7C0:
				string commonErrorMessageByID8 = global::Motorola.CommonCPS.ResourceRepository.ResourceHelper.GetCommonErrorMessageByID(global::Motorola.Common.CustomException.CommonErrorCode.RMC_Unknown_User.ToString(), null);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.LogInfoToFilenEvent(commonErrorMessageByID8, global::Motorola.Common.LogUtility.LoggingLevel.EventInfo);
				global::Motorola.CommonCPS.RadioManagement.InteractionHelper.InteractionFactory.GetInstance().ShowNotificationDialog(commonErrorMessageByID8, global::Motorola.CommonCPS.ResourceRepository.Resources.MessageBox_Title_Error);
				global::System.Environment.Exit(4015);
				return;
				IL_9B:
				oauthLoginContext = null;
				num = (short)1784217618;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x06000042 RID: 66 RVA: 0x0000866C File Offset: 0x0000686C
		private global::Motorola.CommonCPS.RadioManagement.UIModels.OAuthLoginContext i()
		{
			int a_ = 2;
			short num = (short)594280448;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				for (;;)
				{
					IL_26:
					switch (0)
					{
					case 0:
						goto IL_47;
					}
					global::Motorola.CommonCPS.RadioManagement.UIModels.OAuthLoginContext oauthLoginContext;
					global::Motorola.Security.SamlCommonUtility.DMHttpClients.OAuthApplicationInfo applicationInfo;
					global::Motorola.CommonCPS.RadioManagement.SharedServices.DMServiceAccessor dmserviceAccessor;
					for (;;)
					{
						IL_30:
						switch (num2)
						{
						case 0:
							if (oauthLoginContext == null)
							{
								num = (short)2077360129;
								if (num != 0)
								{
								}
								num = (short)124059650;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return oauthLoginContext;
						case 1:
							try
							{
								oauthLoginContext = new global::Motorola.CommonCPS.RadioManagement.UIModels.OAuthLoginContext(applicationInfo)
								{
									User = null,
									IdentityToken = string.Empty,
									AccessToken = string.Empty,
									RefreshToken = string.Empty
								};
								global::Motorola.CommonCPS.RadioManagement.Common.SplashScreenHelper.Hide();
								global::Motorola.CommonCPS.RadioManagement.InteractionHelper.InteractionFactory.GetInstance().OAuthLoginDialog(oauthLoginContext);
								goto IL_19D;
							}
							catch (global::System.Exception ex)
							{
								global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.LogInfoToFilenEvent(global::Motorola.CommonCPS.RadioManagement.Core.RadioManagementControlViewModel.q("킔뾞펠욢톤햦삨캪\udbac욮\udfb0풲閴횸킺\ud8bc톾ꗂ럄꣆꓈賌뫎ꗐ믒냔맖귘닚뻜뻞闠諢諤触짨믪鿬胮蟰髲釴鋶诸\udbfa탼\udffe", a_) + ex.Message, global::Motorola.Common.LogUtility.LoggingLevel.EventInfo);
								string commonErrorMessageByID = global::Motorola.CommonCPS.ResourceRepository.ResourceHelper.GetCommonErrorMessageByID(global::Motorola.Common.CustomException.CommonErrorCode.RMC_OAuth_Login_Error.ToString(), null);
								throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_OAuth_Login_Error, commonErrorMessageByID);
							}
							goto IL_FB;
						case 2:
							goto IL_1FB;
						case 3:
						{
							try
							{
								global::Motorola.Security.SamlCommonUtility.DMHttpClients.DMIdPDiscoveryClient dmIdpDiscoverySvcClient = global::Motorola.Security.SamlCommonUtility.DMHttpClients.DMHttpClientFactory<global::Motorola.Security.SamlCommonUtility.DMHttpClients.DMIdPDiscoveryClient>.Create(null, null);
								applicationInfo = dmserviceAccessor.GetOAuthApplicationInfo(dmIdpDiscoverySvcClient);
								goto IL_200;
							}
							catch (global::System.Exception ex2)
							{
								global::Motorola.CommonCPS.RadioManagement.Common.SplashScreenHelper.Hide();
								global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.LogInfoToFilenEvent(global::Motorola.CommonCPS.RadioManagement.Core.RadioManagementControlViewModel.q("킔뾞펠욢톤햦삨캪\udbac욮\udfb0풲閴첸쾺햼\udabe꿀럂계꓆꣈뿊꓌ꃎ뿐藔ꗖ뛘귚드믞蓠釢엤껦蟨跪苬鷮鳰鋲致黶雸闺\uddfc틾℀", a_) + ex2.Message, global::Motorola.Common.LogUtility.LoggingLevel.EventInfo);
								string commonErrorMessageByID2 = global::Motorola.CommonCPS.ResourceRepository.ResourceHelper.GetCommonErrorMessageByID(global::Motorola.Common.CustomException.CommonErrorCode.RMC_Authentication_Provider_Error.ToString(), null);
								throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_Authentication_Provider_Error, commonErrorMessageByID2);
							}
							goto IL_19D;
							IL_200:
							num = (short)617196319;
							short num3 = num;
							num = (short)1216457503;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_26;
							default:
							{
								num = (short)1908867072;
								short num4 = num;
								num = (short)157810688;
								if (num != 0)
								{
								}
								num = (short)1428619265;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							break;
						}
						}
						break;
						IL_19D:
						num = (short)23396352;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_47:
					oauthLoginContext = null;
					dmserviceAccessor = new global::Motorola.CommonCPS.RadioManagement.SharedServices.DMServiceAccessor();
					applicationInfo = null;
					num = (short)2077556739;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_30;
				}
				IL_FB:
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.LogInfoToFilenEvent(global::Motorola.CommonCPS.RadioManagement.Core.RadioManagementControlViewModel.q("킔뾞펠욢톤햦삨캪\udbac욮\udfb0풲閴횸킺\ud8bc톾ꗂ럄꣆꓈賌뫎ꗐ믒냔맖귘닚뻜뻞闠諢諤触짨믪鿬胮蟰髲釴鋶诸\udbfa탼\udffe伀瘂椄欆⤈䜊戌栎砐紒㔔吖瘘甚検稞夠圢", a_), global::Motorola.Common.LogUtility.LoggingLevel.EventInfo);
				string commonErrorMessageByID3 = global::Motorola.CommonCPS.ResourceRepository.ResourceHelper.GetCommonErrorMessageByID(global::Motorola.Common.CustomException.CommonErrorCode.RMC_OAuth_Login_Error.ToString(), null);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_OAuth_Login_Error, commonErrorMessageByID3);
				IL_1FB:
				goto IL_FB;
			}
			}
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00008928 File Offset: 0x00006B28
		private void c(object A_0, global::System.EventArgs A_1)
		{
			int a_ = 13;
			short num = (short)609943554;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)691451604;
				short num3 = num;
				num = (short)147306196;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)583008256;
					if (num != 0)
					{
					}
					num = (short)674824193;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
					{
						num = (short)1153302528;
						short num4 = num;
						try
						{
							global::System.Windows.Application.Current.Dispatcher.Invoke(new global::System.Action(this.b));
							return;
						}
						catch (global::System.Exception ex)
						{
							global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.LogInfoToFilenEvent(global::Motorola.CommonCPS.RadioManagement.Core.RadioManagementControlViewModel.q("킡횣즥\udaa7誩\udeab쮭횯삱톳억킷펹튻\ud9bd裁돃닅黉ꏋꗍ뗏병ﯕ", a_) + ex.Message, global::Motorola.Common.LogUtility.LoggingLevel.EventInfo);
							global::Motorola.CommonCPS.RadioManagement.InteractionHelper.InteractionFactory.GetInstance().ShowNotificationDialog(global::Motorola.CommonCPS.ResourceRepository.RadioCentral.RadioCentralResources.IdTokenRefreshFailed, global::Motorola.CommonCPS.ResourceRepository.Resources.MessageBox_Title_Error);
							return;
						}
						finally
						{
							global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.IsJwtTokenRefreshing = false;
						}
						goto IL_12A;
					}
					case 1:
						return;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_A9;
						}
						continue;
					}
					break;
				}
				IL_A9:
				if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.IsJwtTokenRefreshing)
				{
					num = (short)889520129;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_12A:
				global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.IsJwtTokenRefreshing = true;
				num = (short)1716191232;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00008AC8 File Offset: 0x00006CC8
		public bool OnClosingWindow()
		{
			short num = (short)1106575363;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1707149557;
				short num3 = num;
				num = (short)889260277;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1936392192;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						num = (short)1706754050;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						return true;
					case 2:
						if (!global::Motorola.CommonCPS.RadioManagement.InteractionHelper.InteractionFactory.GetInstance().ShowConfirmationDialog(global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Confirmation_DiscardTasks, global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Title_DiscardTasks))
						{
							num = (short)908525569;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 3:
					{
						num = (short)1292238848;
						short num4 = num;
						num = (short)1929773057;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_D1;
						}
						continue;
					}
					}
					break;
				}
				IL_D1:
				if (!global::Motorola.CommonCPS.RadioManagement.BatchOp.BatchOpManager.Instance.IsBusy)
				{
					return false;
				}
				num = (short)1921122304;
				num2 = (int)((global::System.IntPtr)num);
			}
			return true;
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00008C18 File Offset: 0x00006E18
		public bool ShowSettingWithNoWarning()
		{
			short num = (short)598736897;
			if (num != 0)
			{
			}
			num = (short)129865450;
			short num2 = num;
			num = (short)1257543402;
			switch (num2 == num)
			{
			}
			num = (short)975306752;
			if (num != 0)
			{
			}
			num = (short)608632832;
			short num3 = num;
			return (bool)base.ServiceProxy.CommandHandler.ShowSettingsDialogCommand.Execute(global::System.Array.Empty<object>());
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00008CE0 File Offset: 0x00006EE0
		private bool b(string A_0 = "")
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			global::Motorola.CommonCPS.RadioManagement.UIModels.SettingsContext settingsContext;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_132;
				case 1:
				{
					settingsContext.ExceptionMessage = A_0;
					num2 = (short)1428160512;
					short num3 = num2;
					num2 = (short)7471104;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					if (!string.IsNullOrEmpty(A_0))
					{
						num2 = (short)395182081;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_134;
				}
				goto IL_1C;
			}
			IL_132:
			IL_134:
			settingsContext.DealerInfo.Left = global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.DealerInfoLeft;
			settingsContext.DealerInfo.Center = global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.DealerInfoMiddle;
			settingsContext.DealerInfo.Right = global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.DealerInfoRight;
			settingsContext.HiddenMessage.HiddenCapMaxRegisterWarningMessage = global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.HiddenWarningMessageCapacityMaxFeatureRegister;
			settingsContext.HiddenMessage.HiddenWarningMessageTemplateRadios = global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.HiddenWarningMessageTemplateRadios;
			settingsContext.IsSaved = false;
			global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.IsCancelled = false;
			return global::Motorola.CommonCPS.RadioManagement.InteractionHelper.InteractionFactory.GetInstance().ShowSettingsDialog(settingsContext);
			IL_1C:
			num2 = (short)1022112022;
			short num4 = num2;
			num2 = (short)623915286;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num2 = (short)658178048;
				if (num2 != 0)
				{
				}
				num2 = (short)859832321;
				if (num2 != 0)
				{
				}
				settingsContext = new global::Motorola.CommonCPS.RadioManagement.UIModels.SettingsContext
				{
					Connection = 
					{
						Address = global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ServerAddress,
						Port = global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ServerPort
					}
				};
				break;
			}
			num2 = (short)61931522;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00008EA4 File Offset: 0x000070A4
		private void e(object A_0)
		{
			short num = (short)1177577618;
			short num2 = num;
			num = (short)1578985618;
			switch (num2 == num)
			{
			}
			num = (short)391118849;
			if (num != 0)
			{
			}
			num = (short)1792212992;
			if (num != 0)
			{
			}
			num = (short)2012217344;
			short num3 = num;
			base.EventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.PrintCommandRequestedEvent>().Publish(null);
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00008F64 File Offset: 0x00007164
		private void h()
		{
			base.MainViewEnable = false;
			global::Motorola.CommonCPS.RadioManagement.Controls.WaitCursor waitCursor = new global::Motorola.CommonCPS.RadioManagement.Controls.WaitCursor();
			short num;
			try
			{
				num = (short)457572353;
				if (num != 0)
				{
				}
				base.EventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.PrintPreviewCommandRequestedEvent>().Publish(null);
			}
			finally
			{
				num = (short)272367618;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)569510858;
						short num3 = num;
						num = (short)1443433418;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							goto IL_EC;
						}
						break;
					}
					case 1:
						((global::System.IDisposable)waitCursor).Dispose();
						num = (short)1059520512;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_7E;
						}
						continue;
					}
					IL_7E:
					if (waitCursor == null)
					{
						goto IL_103;
					}
					num = (short)2066350081;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_EC:
				num = (short)1298661376;
				if (num != 0)
				{
				}
				IL_103:;
			}
			num = (short)1750138880;
			short num4 = num;
			base.MainViewEnable = true;
		}

		// Token: 0x06000049 RID: 73 RVA: 0x000090B8 File Offset: 0x000072B8
		private void g()
		{
			short num = (short)168735857;
			short num2 = num;
			num = (short)1915466865;
			switch (num2 == num)
			{
			}
			num = (short)139526145;
			if (num != 0)
			{
			}
			num = (short)552140800;
			if (num != 0)
			{
			}
			num = (short)126943232;
			short num3 = num;
			base.ServiceProxy.CommandHandler.ShowAboutDialogCommand.Execute(global::System.Array.Empty<object>());
		}

		// Token: 0x0600004A RID: 74 RVA: 0x0000917C File Offset: 0x0000737C
		private void b(global::Motorola.CommonCPS.RadioManagement.UIModels.LogSetting A_0)
		{
			short num;
			try
			{
				num = (short)281760904;
				short num2 = num;
				num = (short)1517966472;
				switch (num2 == num)
				{
				}
				num = (short)1606221824;
				if (num != 0)
				{
				}
				base.ServiceProxy.CommandHandler.ShowUpdateLogSettingWindowCommand.Execute(new object[]
				{
					A_0
				});
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
			}
			num = (short)457113601;
			if (num != 0)
			{
			}
			num = (short)813760512;
			short num3 = num;
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00009260 File Offset: 0x00007460
		private bool f()
		{
			short num = (short)1001017801;
			short num2 = num;
			num = (short)624054729;
			switch (num2 == num)
			{
			}
			num = (short)1127284737;
			if (num != 0)
			{
			}
			num = (short)1271922688;
			if (num != 0)
			{
			}
			num = (short)1306525696;
			short num3 = num;
			return true;
		}

		// Token: 0x0600004C RID: 76 RVA: 0x0000930C File Offset: 0x0000750C
		private bool e()
		{
			short num = (short)2125977124;
			short num2 = num;
			num = (short)1447024164;
			switch (num2 == num)
			{
			}
			num = (short)1544355840;
			if (num != 0)
			{
			}
			num = (short)722010113;
			if (num != 0)
			{
			}
			num = (short)1277493248;
			short num3 = num;
			return base.ServiceProxy.CommandHandler.ShowSettingsDialogCommand.CanExecute(global::System.Array.Empty<object>());
		}

		// Token: 0x0600004D RID: 77 RVA: 0x000093D0 File Offset: 0x000075D0
		private bool d(object A_0)
		{
			short num = (short)1174247774;
			short num2 = num;
			num = (short)228235614;
			switch (num2 == num)
			{
			}
			num = (short)1900150784;
			if (num != 0)
			{
			}
			num = (short)550305793;
			if (num != 0)
			{
			}
			num = (short)910688256;
			short num3 = num;
			return this.d();
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00009480 File Offset: 0x00007680
		private bool d()
		{
			int a_ = 11;
			short num = (short)458489856;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_63;
				}
				bool flag2;
				bool flag3;
				for (;;)
				{
					IL_30:
					global::System.ComponentModel.ICollectionView collectionView;
					bool flag;
					switch (num2)
					{
					case 0:
						if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveMainModule == global::Motorola.CommonCPS.RadioManagement.Core.RadioManagementControlViewModel.q("첝솟욡춣즥쎩쾫쮭\udeaf솱톳", a_))
						{
							num = (short)590413825;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_23A;
					case 1:
						num = (short)185729033;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (collectionView != null)
						{
							num = (short)471793669;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_38C;
					case 3:
						if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveMainModule == global::Motorola.CommonCPS.RadioManagement.Core.RadioManagementControlViewModel.q("첝솟욡춣즥", a_))
						{
							num = (short)501612554;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AF;
					case 4:
						flag = true;
						goto IL_347;
					case 5:
						try
						{
							switch (0)
							{
							case 0:
								goto IL_175;
							}
							global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase> list;
							for (;;)
							{
								IL_10B:
								num = (short)1635413695;
								short num3 = num;
								num = (short)748318399;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									num = (short)836698112;
									if (num != 0)
									{
									}
									switch (num2)
									{
									case 0:
										goto IL_22D;
									case 1:
										goto IL_212;
									case 2:
										goto IL_214;
									case 3:
										num = (short)1368260612;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 4:
										if (list.Count > 0)
										{
											num = (short)153944065;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_214;
									case 5:
										if (list != null)
										{
											num = (short)1998454787;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_214;
									}
									goto IL_175;
									IL_214:
									num = (short)1136918528;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_212:
								flag2 = true;
								num = (short)291635202;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_22D:
							goto IL_38C;
							IL_175:
							list = collectionView.SourceCollection.Cast<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase>().ToList<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase>();
							num = (short)802881541;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_10B;
						}
						catch
						{
							flag2 = false;
							goto IL_38C;
						}
						goto IL_23A;
					case 6:
						if (!(global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveMainView == global::Motorola.CommonCPS.RadioManagement.Core.RadioManagementControlViewModel.q("첝솟욡춣즥\udba7ﲩ얫쮭잯", a_)))
						{
							num = (short)1320943623;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2041577476;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_AF;
					case 8:
						flag = false;
						goto IL_347;
					case 9:
						flag = (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveMainView == global::Motorola.CommonCPS.RadioManagement.Core.RadioManagementControlViewModel.q("첝ﶡ쾥쮧쾩슫\uddad햯솱\udfb5\uddb7춹", a_));
						goto IL_347;
					case 10:
					{
						num = (short)1472724993;
						if (num != 0)
						{
						}
						num = (short)2012741632;
						short num4 = num;
						num = (short)502202374;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_63;
					IL_AF:
					num = (short)202768384;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_23A:
					num = (short)1557594120;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_347:
					flag3 = flag;
					collectionView = (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveDataContext as global::System.ComponentModel.ICollectionView);
					num = (short)534446082;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_38C:
				return flag3 && flag2;
				IL_63:
				flag2 = false;
				num = (short)1076625411;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00009838 File Offset: 0x00007A38
		private bool c()
		{
			short num = (short)951316569;
			short num2 = num;
			num = (short)2100555865;
			switch (num2 == num)
			{
			}
			num = (short)600768513;
			if (num != 0)
			{
			}
			num = (short)1956511744;
			if (num != 0)
			{
			}
			num = (short)1397686272;
			short num3 = num;
			return base.ServiceProxy.CommandHandler.ShowAboutDialogCommand.CanExecute(global::System.Array.Empty<object>());
		}

		// Token: 0x06000050 RID: 80 RVA: 0x000098FC File Offset: 0x00007AFC
		public bool CanShowUpdateLogSetting(global::Motorola.CommonCPS.RadioManagement.UIModels.LogSetting logSetting)
		{
			short num = (short)641092674;
			short num2 = num;
			num = (short)1230195778;
			switch (num2 == num)
			{
			}
			num = (short)1808793601;
			if (num != 0)
			{
			}
			num = (short)1761214464;
			if (num != 0)
			{
			}
			num = (short)1641283584;
			short num3 = num;
			return base.ServiceProxy.CommandHandler.ShowUpdateLogSettingWindowCommand.CanExecute(new object[]
			{
				logSetting
			});
		}

		// Token: 0x06000051 RID: 81 RVA: 0x000099C4 File Offset: 0x00007BC4
		private void b(object A_0, global::System.EventArgs A_1)
		{
			short num = (short)1040633626;
			short num2 = num;
			num = (short)1231933210;
			switch (num2 == num)
			{
			}
			num = (short)1930690561;
			if (num != 0)
			{
			}
			num = (short)795934720;
			if (num != 0)
			{
			}
			num = (short)212205568;
			short num3 = num;
			base.EventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.DisplaySettingsChangedEvent>().Publish(A_1);
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00009A80 File Offset: 0x00007C80
		private void a(global::Motorola.Common.CustomException.CommonErrorCode A_0)
		{
			short num = (short)2034106369;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					return;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_31;
					}
					continue;
				case 2:
					global::System.Windows.Application.Current.Dispatcher.Invoke(new global::System.Action(this.a));
					num = (short)359399424;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_31:
				if (A_0 != global::Motorola.Common.CustomException.CommonErrorCode.SERVER_CLIENT_RM_VERSION_INCOMPATIBLE)
				{
					break;
				}
				num = (short)1166737408;
				short num3 = num;
				num = (short)1122914083;
				short num4 = num;
				num = (short)2005880611;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)987627521;
					if (num != 0)
					{
					}
					num = (short)288489472;
					if (num != 0)
					{
					}
					num = (short)1355284482;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00009BB4 File Offset: 0x00007DB4
		private void c(object A_0)
		{
			int a_ = 3;
			short num;
			global::System.Collections.Generic.List<string> parameters;
			for (;;)
			{
				num = (short)647954432;
				switch (num)
				{
				default:
				{
					global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase = A_0 as global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase;
					parameters = new global::System.Collections.Generic.List<string>
					{
						global::Motorola.CommonCPS.RadioManagement.Core.RadioManagementControlViewModel.q("쒕聯ﺙ馣", a_) + radioBase.ID.ToString(),
						global::Motorola.CommonCPS.RadioManagement.Core.RadioManagementControlViewModel.q("얕ﶗﾝ첟톣쮥쪧쾩\udeab鎭", a_) + radioBase.SerialNumber,
						global::Motorola.CommonCPS.RadioManagement.Core.RadioManagementControlViewModel.q("쎕톗\ud999ﾝ캟얡솣욧캩얫춭톯욱\udbb3쒵薷", a_) + radioBase.UIChangeIndicator.ToString()
					};
					try
					{
						num = (short)326172673;
						int num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_13C;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_DA;
								}
								continue;
							case 2:
								goto IL_10C;
							}
							IL_DA:
							if (global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).GetRadioByDeviceUuid(radioBase.ID.Value, true) == null)
							{
								num = (short)507904002;
								num2 = (int)((global::System.IntPtr)num);
							}
							else
							{
								num = (short)1435369472;
								num2 = (int)((global::System.IntPtr)num);
							}
						}
						IL_10C:
						throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_RadioDetails_Error, global::Motorola.CommonCPS.RadioManagement.Core.RadioManagementControlViewModel.q("聯ﺙ肟쪡얣향袧좩즫쮭\udeaf銱킳펵풷\udfb9좻\udbbd꒿", a_));
						IL_13C:;
					}
					catch (global::Motorola.Common.CustomException.CommonException)
					{
						throw;
					}
					catch (global::System.Exception)
					{
						throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_RadioDetails_Error, global::Motorola.CommonCPS.RadioManagement.Core.RadioManagementControlViewModel.q("聯ﺙ肟쪡얣향袧좩즫쮭\udeaf銱킳펵풷\udfb9좻\udbbd꒿", a_));
					}
					num = (short)1609049812;
					short num3 = num;
					num = (short)1283270356;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_191;
					}
					break;
				}
				}
			}
			IL_191:
			num = (short)138936320;
			short num4 = num;
			num = (short)1280835585;
			if (num != 0)
			{
			}
			num = (short)1331822592;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Infrastructure.NavigationHelper.Go(global::Motorola.CommonCPS.RadioManagement.Core.RadioManagementControlViewModel.q("쒕聯ﺙ", a_), global::Motorola.CommonCPS.RadioManagement.Core.RadioManagementControlViewModel.q("쒕잗\ude99鍊솟쮡좣향ﺧ쎩즫\ud9ad", a_), parameters);
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00009DF4 File Offset: 0x00007FF4
		private void b(object A_0)
		{
			int a_ = 12;
			short num = (short)1639534440;
			short num2 = num;
			num = (short)837832552;
			switch (num2 == num)
			{
			}
			num = (short)1539047424;
			if (num != 0)
			{
			}
			num = (short)919797761;
			if (num != 0)
			{
			}
			num = (short)1721499648;
			short num3 = num;
			global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase = A_0 as global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase;
			global::System.Collections.Generic.List<string> parameters = new global::System.Collections.Generic.List<string>
			{
				global::Motorola.CommonCPS.RadioManagement.Core.RadioManagementControlViewModel.q("춞삠잢첤좦邬", a_) + radioBase.ID.ToString(),
				global::Motorola.CommonCPS.RadioManagement.Core.RadioManagementControlViewModel.q("첞쒠톢첤욦얨\ud8ac슮펰횲잴誶", a_) + radioBase.SerialNumber
			};
			global::Motorola.CommonCPS.RadioManagement.Infrastructure.NavigationHelper.Go(global::Motorola.CommonCPS.RadioManagement.Core.RadioManagementControlViewModel.q("춞삠잢첤좦", a_), global::Motorola.CommonCPS.RadioManagement.Core.RadioManagementControlViewModel.q("춞ﺠ삤힦욨\ud9aa\ud9ac\udcae\udab2킴삶", a_), parameters);
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00009F28 File Offset: 0x00008128
		private void a(global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.Confirmation A_0)
		{
			short num = (short)45610921;
			short num2 = num;
			num = (short)1188689833;
			switch (num2 == num)
			{
			}
			num = (short)1942749185;
			if (num != 0)
			{
			}
			num = (short)205062144;
			if (num != 0)
			{
			}
			num = (short)804519936;
			short num3 = num;
			this.ShowConfirmationDialogRequest.Raise(A_0);
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00009FE0 File Offset: 0x000081E0
		private void b(global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.Notification A_0)
		{
			short num = (short)1905786881;
			if (num != 0)
			{
			}
			num = (short)1617909366;
			short num2 = num;
			num = (short)1603819126;
			switch (num2 == num)
			{
			}
			num = (short)208994304;
			if (num != 0)
			{
			}
			num = (short)1611792384;
			short num3 = num;
			this.ShowNotificationDialogRequest.Raise(A_0);
		}

		// Token: 0x06000057 RID: 87 RVA: 0x0000A098 File Offset: 0x00008298
		private void a(global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.Notification A_0)
		{
			short num = (short)1114655199;
			short num2 = num;
			num = (short)1243367903;
			switch (num2 == num)
			{
			}
			num = (short)429850624;
			if (num != 0)
			{
			}
			num = (short)815857665;
			if (num != 0)
			{
			}
			num = (short)1285488640;
			short num3 = num;
			this.ShowStartUpNotificationDialogRequest.Raise(A_0);
		}

		// Token: 0x06000058 RID: 88 RVA: 0x0000A150 File Offset: 0x00008350
		private void a(global::Motorola.CommonCPS.RadioManagement.UIModels.ProgressContext A_0)
		{
			short num = (short)1979663207;
			short num2 = num;
			num = (short)1896170343;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1420558336;
				if (num != 0)
				{
				}
				num = (short)205324289;
				if (num != 0)
				{
				}
				if (A_0.IsShowProgressBar)
				{
					this.ShowProgressDialogRequest.Raise(new global::Motorola.CommonCPS.RadioManagement.Common.ProgressViewModel(base.EventAggregator, A_0)
					{
						Title = A_0.Title
					});
					return;
				}
				break;
			}
			num = (short)1945567232;
			short num3 = num;
			base.MainViewEnable = false;
			this.ShowProgressRequest.Raise(new global::Motorola.CommonCPS.RadioManagement.Common.ProgressViewModel(base.EventAggregator, A_0)
			{
				Title = A_0.Title
			});
			base.MainViewEnable = true;
		}

		// Token: 0x06000059 RID: 89 RVA: 0x0000A258 File Offset: 0x00008458
		private void a(global::Motorola.CommonCPS.RadioManagement.UIModels.RetryConfirmation A_0)
		{
			short num = (short)27436810;
			short num2 = num;
			num = (short)1366337290;
			switch (num2 == num)
			{
			}
			num = (short)75300864;
			if (num != 0)
			{
			}
			num = (short)32964609;
			if (num != 0)
			{
			}
			num = (short)136970240;
			short num3 = num;
			this.ShowRetryDialogRequest.Raise(A_0);
		}

		// Token: 0x0600005A RID: 90 RVA: 0x0000A310 File Offset: 0x00008510
		private void a(global::Motorola.CommonCPS.RadioManagement.UIModels.SaveTemplateAsContext A_0)
		{
			short num = (short)931571879;
			short num2 = num;
			num = (short)976595111;
			switch (num2 == num)
			{
			}
			num = (short)1603665920;
			if (num != 0)
			{
			}
			num = (short)1153564673;
			if (num != 0)
			{
			}
			num = (short)1992032256;
			short num3 = num;
			this.ShowSaveTemplateAsDialogRequest.Raise(new global::Motorola.CommonCPS.RadioManagement.Template.SaveTemplateAsViewModel(base.EventAggregator, base.ServiceProxy.CommandHandler, A_0)
			{
				Title = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_SaveTemplateAsTitle
			});
		}

		// Token: 0x0600005B RID: 91 RVA: 0x0000A3E4 File Offset: 0x000085E4
		private void a(global::Motorola.CommonCPS.RadioManagement.UIModels.SettingsContext A_0)
		{
			short num = (short)1027207169;
			short num2 = num;
			num = (short)1064628225;
			switch (num2 == num)
			{
			}
			num = (short)725417985;
			if (num != 0)
			{
			}
			num = (short)1145700352;
			if (num != 0)
			{
			}
			num = (short)1553530880;
			short num3 = num;
			this.ShowSettingsDialogRequest.Raise(new global::Motorola.CommonCPS.RadioManagement.Common.SettingsViewModel(base.EventAggregator, base.ServiceProxy.CommandHandler, A_0)
			{
				Title = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_SettingTitle
			});
		}

		// Token: 0x0600005C RID: 92 RVA: 0x0000A4BC File Offset: 0x000086BC
		private void a(global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationContext A_0)
		{
			short num = (short)420651545;
			short num2 = num;
			num = (short)1796579865;
			switch (num2 == num)
			{
			}
			num = (short)552075265;
			if (num != 0)
			{
			}
			num = (short)1846542336;
			if (num != 0)
			{
			}
			num = (short)2125135872;
			short num3 = num;
			this.ShowDBMigrationDialogRequest.Raise(new global::Motorola.CommonCPS.RadioManagement.Common.DBMigrationViewModel(base.EventAggregator, base.ServiceProxy.LocalService, base.ServiceProxy.CommandHandler, A_0)
			{
				Title = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_DBMigration
			});
		}

		// Token: 0x0600005D RID: 93 RVA: 0x0000A5A0 File Offset: 0x000087A0
		private void a(global::Motorola.CommonCPS.RadioManagement.UIModels.ClearOldDBContext A_0)
		{
			short num = (short)1962145456;
			short num2 = num;
			num = (short)1364194992;
			switch (num2 == num)
			{
			}
			num = (short)1769209857;
			if (num != 0)
			{
			}
			num = (short)284033024;
			if (num != 0)
			{
			}
			num = (short)951517184;
			short num3 = num;
			this.ShowClearDataDialogRequest.Raise(new global::Motorola.CommonCPS.RadioManagement.Common.ClearDataViewModel(base.EventAggregator, base.ServiceProxy.LocalService, base.ServiceProxy.CommandHandler, A_0)
			{
				Title = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_CLEAR_OLD_DATA
			});
		}

		// Token: 0x0600005E RID: 94 RVA: 0x0000A684 File Offset: 0x00008884
		private void a(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioConversionContext A_0)
		{
			short num = (short)627645986;
			short num2 = num;
			num = (short)1978146338;
			switch (num2 == num)
			{
			}
			num = (short)1661665280;
			if (num != 0)
			{
			}
			num = (short)1965490177;
			if (num != 0)
			{
			}
			num = (short)1731985408;
			short num3 = num;
			this.ShowRadioConversionDialogRequest.Raise(new global::Motorola.CommonCPS.RadioManagement.Common.RadioConversionViewModel(base.EventAggregator, base.ServiceProxy.CommandHandler, A_0)
			{
				Title = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Radio_Conversion
			});
		}

		// Token: 0x0600005F RID: 95 RVA: 0x0000A758 File Offset: 0x00008958
		private void a(global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateConversionContext A_0)
		{
			short num = (short)703655518;
			short num2 = num;
			num = (short)1958538846;
			switch (num2 == num)
			{
			}
			num = (short)1978400769;
			if (num != 0)
			{
			}
			num = (short)6094848;
			if (num != 0)
			{
			}
			num = (short)673382400;
			short num3 = num;
			this.ShowTemplateConversionDialogRequest.Raise(new global::Motorola.CommonCPS.RadioManagement.Common.TemplateConversionViewMode(base.EventAggregator, base.ServiceProxy.CommandHandler, A_0)
			{
				Title = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Template_Conversion
			});
		}

		// Token: 0x06000060 RID: 96 RVA: 0x0000A830 File Offset: 0x00008A30
		private void a(object A_0)
		{
			short num = (short)81342267;
			short num2 = num;
			num = (short)1676947259;
			switch (num2 == num)
			{
			}
			num = (short)1311309825;
			if (num != 0)
			{
			}
			num = (short)1419182080;
			if (num != 0)
			{
			}
			num = (short)1776353280;
			short num3 = num;
			this.ShowAboutDialogRequest.Raise(new global::Motorola.CommonCPS.RadioManagement.Common.AboutViewModel(base.EventAggregator, base.ServiceProxy.CommandHandler)
			{
				Title = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_AboutTitle
			});
		}

		// Token: 0x06000061 RID: 97 RVA: 0x0000A904 File Offset: 0x00008B04
		private void a(global::Motorola.CommonCPS.RadioManagement.UIModels.UserLoginContext A_0)
		{
			short num = (short)1093137816;
			short num2 = num;
			num = (short)1409349016;
			switch (num2 == num)
			{
			}
			num = (short)1460142081;
			if (num != 0)
			{
			}
			num = (short)53280768;
			if (num != 0)
			{
			}
			num = (short)2093088768;
			short num3 = num;
			this.UserLoginDialogRequest.Raise(new global::Motorola.CommonCPS.RadioManagement.Common.UserLoginViewModel(base.EventAggregator, base.ServiceProxy.CommandHandler, A_0)
			{
				Title = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_UserLoginTitle
			});
		}

		// Token: 0x06000062 RID: 98 RVA: 0x0000A9DC File Offset: 0x00008BDC
		private void a(global::Motorola.CommonCPS.RadioManagement.UIModels.ChangePasswordContext A_0)
		{
			short num = (short)660540423;
			short num2 = num;
			num = (short)600706055;
			switch (num2 == num)
			{
			}
			num = (short)1716453376;
			if (num != 0)
			{
			}
			num = (short)397017089;
			if (num != 0)
			{
			}
			num = (short)589824000;
			short num3 = num;
			this.ChangePasswordDialogRequest.Raise(new global::Motorola.CommonCPS.RadioManagement.Common.ChangePasswordViewModel(base.EventAggregator, base.ServiceProxy.CommandHandler, A_0)
			{
				Title = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_ChangePasswordTitle
			});
		}

		// Token: 0x06000063 RID: 99 RVA: 0x0000AAB0 File Offset: 0x00008CB0
		private void a(bool A_0)
		{
			short num = (short)1848144315;
			short num2 = num;
			num = (short)1777496507;
			switch (num2 == num)
			{
			}
			num = (short)842399744;
			if (num != 0)
			{
			}
			num = (short)1125711873;
			if (num != 0)
			{
			}
			num = (short)1499987968;
			short num3 = num;
			this.WaitingIndicatorVisibility = (A_0 ? global::System.Windows.Visibility.Visible : global::System.Windows.Visibility.Hidden);
			base.MainViewEnable = !A_0;
		}

		// Token: 0x06000064 RID: 100 RVA: 0x0000AB74 File Offset: 0x00008D74
		private void a(string A_0)
		{
			short num = (short)1057099649;
			short num2 = num;
			num = (short)1871384449;
			switch (num2 == num)
			{
			}
			num = (short)1367801856;
			if (num != 0)
			{
			}
			num = (short)1309409281;
			if (num != 0)
			{
			}
			num = (short)1299906560;
			short num3 = num;
			string helpFilePath = global::Motorola.CommonCPS.RadioManagement.LocalService.LocalServiceProxy.GetInstance().LocalService.GetHelpFilePath(A_0);
			this.OpenHelpDoc(helpFilePath);
		}

		// Token: 0x06000065 RID: 101 RVA: 0x0000AC38 File Offset: 0x00008E38
		private void a(global::Motorola.CommonCPS.RadioManagement.Events.ShowRMSaveFileDialogEventParam A_0)
		{
			int num;
			global::Motorola.CommonCPS.RadioManagement.Controls.RMSaveFileDialog rmsaveFileDialog;
			short num2;
			switch (0)
			{
			case 0:
				break;
			default:
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						if (rmsaveFileDialog.ShowDialog())
						{
							num2 = (short)622264320;
							short num3 = num2;
							num2 = (short)1372127234;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_166;
					case 1:
						goto IL_161;
					case 2:
						num2 = (short)1565589507;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 3:
					{
						if (string.IsNullOrEmpty(rmsaveFileDialog.FileName))
						{
							goto IL_166;
						}
						num2 = (short)810570561;
						short num4 = num2;
						num2 = (short)608654145;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_62;
						default:
							num2 = (short)767426560;
							if (num2 != 0)
							{
							}
							num2 = (short)1046806529;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					}
					goto IL_20;
				}
				IL_161:
				A_0.IsSuccess = true;
				A_0.FileName = rmsaveFileDialog.FileName;
				return;
				IL_166:
				num2 = (short)1941504001;
				if (num2 != 0)
				{
				}
				A_0.IsSuccess = false;
				return;
			}
			IL_20:
			rmsaveFileDialog = new global::Motorola.CommonCPS.RadioManagement.Controls.RMSaveFileDialog
			{
				Filter = A_0.Filter,
				Title = A_0.Title,
				FilterIndex = A_0.FilterIndex,
				FileName = A_0.FileName,
				InitialDirectory = A_0.InitialDirectory
			};
			IL_62:
			num2 = (short)977141760;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000066 RID: 102 RVA: 0x0000ADDC File Offset: 0x00008FDC
		private void a(global::Motorola.CommonCPS.RadioManagement.UIModels.OAuthLoginContext A_0)
		{
			short num = (short)764215297;
			if (num != 0)
			{
			}
			num = (short)1058489374;
			short num2 = num;
			num = (short)1112163358;
			switch (num2 == num)
			{
			}
			num = (short)1265434624;
			if (num != 0)
			{
			}
			num = (short)18481152;
			short num3 = num;
			this.OAuthLoginDialogRequest.Raise(new global::Motorola.CommonCPS.RadioManagement.OAuthOpenIDConnect.OAuthLoginViewModel(base.EventAggregator, base.ServiceProxy.CommandHandler, A_0)
			{
				Title = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_UserLoginTitle
			});
		}

		// Token: 0x06000067 RID: 103 RVA: 0x0000AEB0 File Offset: 0x000090B0
		private void a(global::Motorola.CommonCPS.RadioManagement.UIModels.SelectAgencyContext A_0)
		{
			short num = (short)1742914091;
			short num2 = num;
			num = (short)1303101995;
			switch (num2 == num)
			{
			}
			num = (short)644415488;
			if (num != 0)
			{
			}
			num = (short)1308426241;
			if (num != 0)
			{
			}
			num = (short)1705639936;
			short num3 = num;
			this.SelectAgencyDialogRequest.Raise(new global::Motorola.CommonCPS.RadioManagement.OAuthOpenIDConnect.SelectAgencyViewModel(base.EventAggregator, base.ServiceProxy.CommandHandler, A_0)
			{
				Title = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Select_Agency
			});
		}

		// Token: 0x06000068 RID: 104 RVA: 0x0000AF88 File Offset: 0x00009188
		private void a(global::Motorola.CommonCPS.RadioManagement.UIModels.LogSetting A_0)
		{
			short num = (short)1562989788;
			short num2 = num;
			num = (short)529421532;
			switch (num2 == num)
			{
			}
			num = (short)2097086465;
			if (num != 0)
			{
			}
			num = (short)1192755200;
			if (num != 0)
			{
			}
			num = (short)536018944;
			short num3 = num;
			this.ShowUpdateLogSettingRequest.Raise(new global::Motorola.CommonCPS.RadioManagement.Common.UpdateLogSettingViewModel(base.EventAggregator, base.ServiceProxy.CommandHandler, A_0)
			{
				Title = global::Motorola.CommonCPS.ResourceRepository.Resources.CPS2_LogSetting
			});
		}

		// Token: 0x06000069 RID: 105 RVA: 0x0000B060 File Offset: 0x00009260
		private void a(global::Motorola.CommonCPS.RadioManagement.UIModels.ErrorMessageContext A_0)
		{
			short num = (short)1747316888;
			short num2 = num;
			num = (short)1676538008;
			switch (num2 == num)
			{
			}
			num = (short)739508224;
			if (num != 0)
			{
			}
			num = (short)2134835201;
			if (num != 0)
			{
			}
			num = (short)456785920;
			short num3 = num;
			this.ShowErrorMessageRequest.Raise(new global::Motorola.CommonCPS.RadioManagement.Common.ErrorMessageViewModel(base.EventAggregator, base.ServiceProxy.CommandHandler, A_0)
			{
				Title = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Title_Error
			});
		}

		// Token: 0x0600006A RID: 106 RVA: 0x0000B134 File Offset: 0x00009334
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private void b()
		{
			int a_ = 0;
			short num = (short)2033188864;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_48;
				}
				string content;
				for (;;)
				{
					IL_31:
					switch (num2)
					{
					case 0:
					{
						num = (short)1047003136;
						short num3 = num;
						if (global::Motorola.CommonCPS.RadioManagement.InteractionHelper.InteractionFactory.GetInstance().ShowConfirmationDialog(content, global::Motorola.CommonCPS.ResourceRepository.Resources.MessageBox_Title_Confirm))
						{
							num = (short)883228674;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)744878127;
						short num4 = num;
						num = (short)376696879;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							return;
						default:
							num = (short)1820459008;
							if (num != 0)
							{
							}
							global::System.Environment.Exit(0);
							num = (short)833355777;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 1:
						return;
					case 2:
						goto IL_277;
					case 3:
						num = (short)581304321;
						if (num != 0)
						{
						}
						try
						{
							switch (0)
							{
							case 0:
								goto IL_FB;
							}
							global::Motorola.CommonCPS.RadioManagement.UIModels.OAuthLoginContext oauthLoginContext;
							for (;;)
							{
								IL_E4:
								switch (num2)
								{
								case 0:
									if (oauthLoginContext.LoginResult == global::Motorola.CommonCPS.RadioManagement.UIModels.OAuthLoginResult.Success)
									{
										num = (short)871563266;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_214;
								case 1:
									goto IL_22C;
								case 2:
								{
									global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.AuthenticationMethodType = global::Motorola.CommonCPS.RadioManagement.Global.AuthMethod.JwtToken.ToString();
									global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.JwtToken = oauthLoginContext.IdentityToken;
									global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.WorkingJwtToken = oauthLoginContext.IdentityToken;
									global::Motorola.CommonCPS.RadioManagement.LocalService.LocalServiceProxy.GetInstance().LocalService.Connect(true);
									global::Motorola.CommonCPS.RadioManagement.Controls.WaitCursor waitCursor = new global::Motorola.CommonCPS.RadioManagement.Controls.WaitCursor();
									num = (short)2130903043;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									try
									{
										this.x.WaitOne(60000);
									}
									finally
									{
										num = (short)1211105281;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											global::Motorola.CommonCPS.RadioManagement.Controls.WaitCursor waitCursor;
											switch (num2)
											{
											case 0:
												goto IL_211;
											case 1:
												switch (0)
												{
												case 0:
													goto IL_1DC;
												}
												continue;
											case 2:
												((global::System.IDisposable)waitCursor).Dispose();
												num = (short)1424424960;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											IL_1DC:
											if (waitCursor == null)
											{
												break;
											}
											num = (short)871563266;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_211:;
									}
									goto IL_214;
								}
								goto IL_FB;
								IL_214:
								num = (short)885850113;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_22C:
							return;
							IL_FB:
							oauthLoginContext = this.i();
							num = (short)561971200;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_E4;
						}
						catch (global::System.Exception ex)
						{
							if (!global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.IsConnected)
							{
								global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.LogInfoToFilenEvent(global::Motorola.CommonCPS.RadioManagement.Core.RadioManagementControlViewModel.q("횒붜쒠얢힤슦\udaa8쎪쒬솮횰鎲ﾴ삶춸鮺킾ꫀꛂꯄ", a_) + ex.Message, global::Motorola.Common.LogUtility.LoggingLevel.EventInfo);
								global::Motorola.CommonCPS.RadioManagement.InteractionHelper.InteractionFactory.GetInstance().ShowNotificationDialog(global::Motorola.CommonCPS.ResourceRepository.RadioCentral.RadioCentralResources.IdTokenRefreshFailed, global::Motorola.CommonCPS.ResourceRepository.Resources.MessageBox_Title_Error);
							}
							return;
						}
						goto IL_277;
					}
					goto IL_48;
					IL_277:
					global::Motorola.CommonCPS.RadioManagement.SharedServices.IServerAccessor instance = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(false, false);
					instance.ServerConnectedEventHandler = (global::System.EventHandler)global::System.Delegate.Combine(instance.ServerConnectedEventHandler, new global::System.EventHandler(this.a));
					num = (short)1332740099;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_48:
				content = string.Format(global::Motorola.CommonCPS.ResourceRepository.RadioCentral.RadioCentralResources.IdTokenSessionHasExpired, '\n', '\n', '\n');
				num = (short)1438384128;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x0600006B RID: 107 RVA: 0x0000B4C4 File Offset: 0x000096C4
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private void a(object A_0, global::System.EventArgs A_1)
		{
			short num = (short)399130476;
			short num2 = num;
			num = (short)1996308332;
			switch (num2 == num)
			{
			}
			num = (short)822804480;
			if (num != 0)
			{
			}
			num = (short)1536688129;
			if (num != 0)
			{
			}
			num = (short)1427046400;
			short num3 = num;
			this.x.Set();
		}

		// Token: 0x0600006C RID: 108 RVA: 0x0000B578 File Offset: 0x00009778
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private void a()
		{
			short num = (short)943587329;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					return;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				case 2:
					this.ShowSettings();
					num = (short)751108096;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_30:
				num = (short)616103937;
				if (num != 0)
				{
				}
				num = (short)736493568;
				short num3 = num;
				if (this.incompatibilityHandlerHelper.DetectAndHandleIncompatibility())
				{
					break;
				}
				num = (short)1468686552;
				short num4 = num;
				num = (short)1266245848;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1073348608;
					if (num != 0)
					{
					}
					num = (short)1357905922;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
		}

		// Token: 0x0600006D RID: 109 RVA: 0x0000B698 File Offset: 0x00009898
		internal static string q(string A_0, int A_1)
		{
			char[] array = A_0.ToCharArray();
			int num = (int)((global::System.IntPtr)(113819578 + A_1) + (global::System.IntPtr)64 + (global::System.IntPtr)85 + (global::System.IntPtr)67);
			int num3;
			int num2;
			if ((num2 = (num3 = 0)) < 1)
			{
				goto IL_5C;
			}
			IL_29:
			int num5;
			int num4 = num5 = num2;
			char[] array2 = array;
			int num6 = num5;
			char c = array[num5];
			byte b = (byte)((int)(c & 'ÿ') ^ num++);
			byte b2 = (byte)((int)(c >> 8) ^ num++);
			byte b3 = b2;
			b2 = b;
			b = b3;
			array2[num6] = (ushort)((int)b2 << 8 | (int)b);
			num3 = num4 + 1;
			IL_5C:
			if ((num2 = num3) >= array.Length)
			{
				return string.Intern(new string(array));
			}
			goto IL_29;
		}

		// Token: 0x04000005 RID: 5
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.Confirmation> a;

		// Token: 0x04000006 RID: 6
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.Notification> b;

		// Token: 0x04000007 RID: 7
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.Notification> c;

		// Token: 0x04000008 RID: 8
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Common.ProgressViewModel> d;

		// Token: 0x04000009 RID: 9
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Common.ProgressViewModel> e;

		// Token: 0x0400000A RID: 10
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.UIModels.RetryConfirmation> f;

		// Token: 0x0400000B RID: 11
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Template.SaveTemplateAsViewModel> g;

		// Token: 0x0400000C RID: 12
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Common.SettingsViewModel> h;

		// Token: 0x0400000D RID: 13
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Common.DBMigrationViewModel> i;

		// Token: 0x0400000E RID: 14
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Common.ClearDataViewModel> j;

		// Token: 0x0400000F RID: 15
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Common.RadioConversionViewModel> k;

		// Token: 0x04000010 RID: 16
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Common.TemplateConversionViewMode> l;

		// Token: 0x04000011 RID: 17
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Common.SeletcMofiiedRadioViewMode> m;

		// Token: 0x04000012 RID: 18
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Common.TasksViewModel> n;

		// Token: 0x04000013 RID: 19
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Common.UserLoginViewModel> o;

		// Token: 0x04000014 RID: 20
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Common.ChangePasswordViewModel> p;

		// Token: 0x04000015 RID: 21
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Common.AboutViewModel> q;

		// Token: 0x04000016 RID: 22
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.OAuthOpenIDConnect.OAuthLoginViewModel> r;

		// Token: 0x04000017 RID: 23
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.OAuthOpenIDConnect.SelectAgencyViewModel> s;

		// Token: 0x04000018 RID: 24
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Common.UpdateLogSettingViewModel> t;

		// Token: 0x04000019 RID: 25
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Common.ErrorMessageViewModel> u;

		// Token: 0x0400001A RID: 26
		public global::IncompatibilityHandler.IncompatibilityHandlerHelper incompatibilityHandlerHelper;

		// Token: 0x0400001B RID: 27
		private global::System.Windows.Visibility v;

		// Token: 0x0400001C RID: 28
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string w;

		// Token: 0x0400001D RID: 29
		private global::System.Threading.AutoResetEvent x;
	}
}
