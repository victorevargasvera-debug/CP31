using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.Composition;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Windows.Data;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Events;
using Microsoft.Practices.Prism.Interactivity.InteractionRequest;
using Microsoft.Practices.Prism.Regions;
using Motorola.Common.CustomException;
using Motorola.CommonCPS.RadioManagement.Events;
using Motorola.CommonCPS.RadioManagement.Global;
using Motorola.CommonCPS.RadioManagement.Infrastructure;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.RadioManagement.Job
{
	// Token: 0x02000008 RID: 8
	[global::System.ComponentModel.Composition.Export]
	public class JobDetailsViewModel : global::Motorola.CommonCPS.RadioManagement.Infrastructure.TableViewModelBase<global::Motorola.CommonCPS.RadioManagement.UIModels.JobBase>
	{
		// Token: 0x06000016 RID: 22 RVA: 0x00002E8C File Offset: 0x0000108C
		[global::System.ComponentModel.Composition.ImportingConstructor]
		public JobDetailsViewModel(global::Microsoft.Practices.Prism.Events.IEventAggregator eventAggregator) : base(eventAggregator)
		{
			this.ShowRadioDetailsCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::Motorola.CommonCPS.RadioManagement.UIModels.ReadWriteDeviceJob>(new global::System.Action<global::Motorola.CommonCPS.RadioManagement.UIModels.ReadWriteDeviceJob>(this.a));
			this.ShowRadioDetailsDialogRequest = new global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Job.JobRadioDetailsViewModel>();
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000017 RID: 23 RVA: 0x00002EC4 File Offset: 0x000010C4
		// (set) Token: 0x06000018 RID: 24 RVA: 0x00002F70 File Offset: 0x00001170
		public global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer JobContainer
		{
			get
			{
				short num = (short)41313839;
				short num2 = num;
				num = (short)1881105967;
				switch (num2 == num)
				{
				}
				num = (short)1005453313;
				if (num != 0)
				{
				}
				num = (short)1090781184;
				short num3 = num;
				num = (short)209387520;
				if (num != 0)
				{
				}
				return this.b;
			}
			set
			{
				short num = (short)181010433;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)1031267712;
					short num3 = num;
					num = (short)758113664;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1776943104;
						if (num != 0)
						{
						}
						switch (num2)
						{
						case 0:
							goto IL_11B;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_7B;
							}
							continue;
						case 2:
							goto IL_C7;
						}
						IL_7B:
						num = (short)1551499265;
						if (num != 0)
						{
						}
						if (value != this.b)
						{
							num = (short)2082865154;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					IL_C7:
					this.b = value;
					base.RaisePropertyChanged<global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.Job.JobDetailsViewModel)), methodof(global::Motorola.CommonCPS.RadioManagement.Job.JobDetailsViewModel.get_JobContainer())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
					num = (short)422117376;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_11B:
				num = (short)1455030272;
				short num4 = num;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000019 RID: 25 RVA: 0x000030C4 File Offset: 0x000012C4
		// (set) Token: 0x0600001A RID: 26 RVA: 0x00003174 File Offset: 0x00001374
		public global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Job.JobRadioDetailsViewModel> ShowRadioDetailsDialogRequest
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1465372676;
				short num2 = num;
				num = (short)1287049220;
				switch (num2 == num)
				{
				}
				num = (short)1433141249;
				if (num != 0)
				{
				}
				num = (short)310312960;
				short num3 = num;
				num = (short)1284374528;
				if (num != 0)
				{
				}
				return this.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1633887323;
				short num2 = num;
				num = (short)1334125659;
				switch (num2 == num)
				{
				}
				num = (short)407502849;
				if (num != 0)
				{
				}
				num = (short)44564480;
				short num3 = num;
				num = (short)460521472;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600001B RID: 27 RVA: 0x00003228 File Offset: 0x00001428
		// (set) Token: 0x0600001C RID: 28 RVA: 0x000032D8 File Offset: 0x000014D8
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::Motorola.CommonCPS.RadioManagement.UIModels.ReadWriteDeviceJob> ShowRadioDetailsCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)851339205;
				short num2 = num;
				num = (short)1525573573;
				switch (num2 == num)
				{
				}
				num = (short)1418264576;
				if (num != 0)
				{
				}
				num = (short)1776680960;
				short num3 = num;
				num = (short)1137115137;
				if (num != 0)
				{
				}
				return this.d;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1276610358;
				short num2 = num;
				num = (short)146114358;
				switch (num2 == num)
				{
				}
				num = (short)2010775553;
				if (num != 0)
				{
				}
				num = (short)1094975488;
				short num3 = num;
				num = (short)34537472;
				if (num != 0)
				{
				}
				this.d = value;
			}
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00003388 File Offset: 0x00001588
		private void a(global::Motorola.CommonCPS.RadioManagement.UIModels.ReadWriteDeviceJob A_0)
		{
			int a_ = 17;
			short num;
			try
			{
				num = (short)280231948;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					string serialNumber;
					switch (num2)
					{
					case 0:
						goto IL_2A1;
					case 1:
						goto IL_D3;
					case 2:
						if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ModeIdentifier != global::Motorola.CommonCPS.RadioManagement.Global.ModeIdentifier.Configuration)
						{
							num = (short)1278607369;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_244;
					case 3:
						if (A_0.WorkMode == global::Motorola.CommonCPS.Server.CommonDBConstants.WorkMode.Configuration)
						{
							goto IL_13D;
						}
						goto IL_D8;
					case 4:
						goto IL_288;
					case 5:
						goto IL_28A;
					case 6:
						num = (short)1304756237;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						if (!string.IsNullOrEmpty(serialNumber))
						{
							num = (short)1293090826;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_28A;
					case 8:
					{
						num = (short)1578331308;
						short num3 = num;
						num = (short)110259372;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_13D;
						default:
							num = (short)1831534592;
							if (num != 0)
							{
							}
							num = (short)1922170882;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 9:
						goto IL_11D;
					case 10:
					{
						global::Motorola.CommonCPS.RadioManagement.UIModels.RadioDetails radioDetailsBySerialNumber = base.ServiceProxy.LocalService.GetRadioDetailsBySerialNumber(serialNumber);
						num = (short)213450763;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
					{
						global::Motorola.CommonCPS.RadioManagement.UIModels.RadioDetails radioDetailsBySerialNumber;
						if (radioDetailsBySerialNumber == null)
						{
							num = (short)78512129;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.ShowRadioDetailsDialogRequest.Raise(new global::Motorola.CommonCPS.RadioManagement.Job.JobRadioDetailsViewModel(base.EventAggregator, base.ServiceProxy.CommandHandler, radioDetailsBySerialNumber)
						{
							Title = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Title_ViewRadioDetails
						});
						num = (short)929955845;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
						switch (0)
						{
						case 0:
							goto IL_65;
						}
						continue;
					case 13:
						if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ModeIdentifier == global::Motorola.CommonCPS.RadioManagement.Global.ModeIdentifier.Template)
						{
							num = (short)358416388;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D8;
					}
					IL_65:
					if (A_0.WorkMode == global::Motorola.CommonCPS.Server.CommonDBConstants.WorkMode.Template)
					{
						num = (short)58392584;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_11D;
					IL_D8:
					serialNumber = A_0.SerialNumber;
					num = (short)1145634823;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_11D:
					num = (short)1133641731;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_13D:
					num = (short)428933126;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_28A:
					num = (short)62193664;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_D3:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_RadioDetails_Error, global::Motorola.CommonCPS.RadioManagement.Job.ModuleJob.b("匠䈢䄤並䘨ପ䔬丮䈰ጲ圴制尸唺ᴼ嬾⑀⽂⁄㍆ⱈ⽊", a_));
				IL_244:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_Job_Not_InCurrentMode);
				IL_288:
				goto IL_244;
				IL_2A1:;
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
			}
			num = (short)1873412096;
			short num4 = num;
			num = (short)333578241;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600001E RID: 30 RVA: 0x000036B0 File Offset: 0x000018B0
		protected override void Refresh()
		{
			short num = (short)1918435276;
			short num2 = num;
			num = (short)960757708;
			switch (num2 == num)
			{
			}
			num = (short)1954873344;
			short num3 = num;
			num = (short)1612185600;
			if (num != 0)
			{
			}
			num = (short)867237889;
			if (num != 0)
			{
			}
			this.a();
		}

		// Token: 0x0600001F RID: 31 RVA: 0x0000375C File Offset: 0x0000195C
		protected override void SaveItem(object[] parameters)
		{
			short num = (short)903125504;
			short num2 = num;
			num = (short)998349312;
			switch (num2 == num)
			{
			}
			num = (short)1746796544;
			short num3 = num;
			num = (short)1265369089;
			if (num != 0)
			{
			}
			num = (short)1447297024;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00003800 File Offset: 0x00001A00
		private void a()
		{
			short num;
			try
			{
				num = (short)447070399;
				short num2 = num;
				num = (short)1614201023;
				switch (num2 == num)
				{
				}
				num = (short)559087616;
				if (num != 0)
				{
				}
				global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer, global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.JobBase>> jobs = base.ServiceProxy.LocalService.GetJobs(new global::System.Guid(this.a));
				this.JobContainer = jobs.Key;
				base.Items = global::System.Windows.Data.CollectionViewSource.GetDefaultView(jobs.Value);
				base.EventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ResetOptionFilterForJobViewEvent>().Publish(false);
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
			}
			num = (short)2015035392;
			short num3 = num;
			num = (short)602669057;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00003910 File Offset: 0x00001B10
		public override void OnNavigatedFrom(global::Microsoft.Practices.Prism.Regions.NavigationContext navigationContext)
		{
			int a_ = 19;
			short num = (short)506033917;
			short num2 = num;
			num = (short)1420850941;
			switch (num2 == num)
			{
			}
			num = (short)1108082688;
			short num3 = num;
			num = (short)1372585984;
			if (num != 0)
			{
			}
			num = (short)1941372929;
			if (num != 0)
			{
			}
			navigationContext.Parameters.Add(global::Motorola.CommonCPS.RadioManagement.Job.ModuleJob.b("瀢䨤刦嬨䠪䠬礮堰嘲䈴", a_), global::Motorola.CommonCPS.RadioManagement.Job.ModuleJob.b("猢圤䠦丨太䰬䈮尰娲嬴倶紸帺䤼帾⡀⽂㙄ᅆ⁈⹊㩌", a_));
			base.OnNavigatedFrom(navigationContext);
		}

		// Token: 0x06000022 RID: 34 RVA: 0x000039F0 File Offset: 0x00001BF0
		public override void OnNavigatedTo(global::Microsoft.Practices.Prism.Regions.NavigationContext navigationContext)
		{
			int a_ = 11;
			short num = (short)436207617;
			if (num != 0)
			{
			}
			num = (short)369734961;
			short num2 = num;
			num = (short)1426634033;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1289355264;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)434962432;
			if (num != 0)
			{
			}
			base.OnNavigatedTo(navigationContext);
			this.a = navigationContext.Parameters[global::Motorola.CommonCPS.RadioManagement.Job.ModuleJob.b("刚夜", a_)];
			this.a();
			global::Motorola.CommonCPS.RadioManagement.Infrastructure.NavigationHelper.AppendInfoToNavigationPath(navigationContext.Parameters[global::Motorola.CommonCPS.RadioManagement.Job.ModuleJob.b("唚簜爞䐠", a_)]);
			global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveMainView = global::Motorola.CommonCPS.RadioManagement.Job.ModuleJob.b("儚䈜嬞䐠圢䐤並䔨堪第䘮吰䐲", a_);
		}

		// Token: 0x04000011 RID: 17
		private string a;

		// Token: 0x04000012 RID: 18
		private global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer b;

		// Token: 0x04000013 RID: 19
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequest<global::Motorola.CommonCPS.RadioManagement.Job.JobRadioDetailsViewModel> c;

		// Token: 0x04000014 RID: 20
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::Motorola.CommonCPS.RadioManagement.UIModels.ReadWriteDeviceJob> d;
	}
}
