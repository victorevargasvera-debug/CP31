using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.Runtime.CompilerServices;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Events;
using Motorola.Common.CustomException;
using Motorola.CommonCPS.RadioManagement.Command;
using Motorola.CommonCPS.RadioManagement.Global;
using Motorola.CommonCPS.RadioManagement.Infrastructure;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.RadioManagement.Common
{
	// Token: 0x0200002C RID: 44
	public class TasksViewModel : global::Motorola.CommonCPS.RadioManagement.Infrastructure.PopoupViewModelBase
	{
		// Token: 0x06000127 RID: 295 RVA: 0x00015330 File Offset: 0x00013530
		public TasksViewModel(global::Microsoft.Practices.Prism.Events.IEventAggregator eventAggregator, global::Motorola.CommonCPS.RadioManagement.Command.ICommandHandler commandHandler) : base(eventAggregator, commandHandler)
		{
			this.TasksContext = global::Motorola.CommonCPS.RadioManagement.Command.BatchOpModelCollection.Instance;
			this.TasksContext.JobContainers.CollectionChanged += this.a;
			this.CancelJobCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer>(new global::System.Action<global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer>(this.c));
			this.ClearCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.b), new global::System.Func<bool>(this.a));
			this.ShowJobDetailCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer>(new global::System.Action<global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer>(this.b), new global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer, bool>(this.a));
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000128 RID: 296 RVA: 0x000153CC File Offset: 0x000135CC
		// (set) Token: 0x06000129 RID: 297 RVA: 0x0001547C File Offset: 0x0001367C
		public global::Motorola.CommonCPS.RadioManagement.UIModels.TasksContext TasksContext
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)837681152;
				short num2 = num;
				num = (short)593544706;
				short num3 = num;
				num = (short)181192194;
				switch (num3 == num)
				{
				}
				num = (short)1304690689;
				if (num != 0)
				{
				}
				num = (short)2065432576;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)377225216;
				short num2 = num;
				num = (short)1002614698;
				short num3 = num;
				num = (short)1390522282;
				switch (num3 == num)
				{
				}
				num = (short)895221761;
				if (num != 0)
				{
				}
				num = (short)898433024;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x0600012A RID: 298 RVA: 0x0001552C File Offset: 0x0001372C
		// (set) Token: 0x0600012B RID: 299 RVA: 0x000155DC File Offset: 0x000137DC
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer> CancelJobCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)857538560;
				short num2 = num;
				num = (short)316342154;
				short num3 = num;
				num = (short)437452682;
				switch (num3 == num)
				{
				}
				num = (short)209780737;
				if (num != 0)
				{
				}
				num = (short)2019360768;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1502281728;
				short num2 = num;
				num = (short)1135103307;
				short num3 = num;
				num = (short)1930644811;
				switch (num3 == num)
				{
				}
				num = (short)749666305;
				if (num != 0)
				{
				}
				num = (short)1474035712;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x0600012C RID: 300 RVA: 0x00015690 File Offset: 0x00013890
		// (set) Token: 0x0600012D RID: 301 RVA: 0x00015740 File Offset: 0x00013940
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand ClearCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1241513984;
				short num2 = num;
				num = (short)619352176;
				short num3 = num;
				num = (short)1424527472;
				switch (num3 == num)
				{
				}
				num = (short)1134690304;
				if (num != 0)
				{
				}
				num = (short)1422983169;
				if (num != 0)
				{
				}
				return this.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1047527424;
				short num2 = num;
				num = (short)1529153552;
				short num3 = num;
				num = (short)563873808;
				switch (num3 == num)
				{
				}
				num = (short)638255105;
				if (num != 0)
				{
				}
				num = (short)1878261760;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x0600012E RID: 302 RVA: 0x000157F0 File Offset: 0x000139F0
		// (set) Token: 0x0600012F RID: 303 RVA: 0x000158A0 File Offset: 0x00013AA0
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer> ShowJobDetailCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1649606656;
				short num2 = num;
				num = (short)1418912843;
				short num3 = num;
				num = (short)690021451;
				switch (num3 == num)
				{
				}
				num = (short)1668612096;
				if (num != 0)
				{
				}
				num = (short)242024449;
				if (num != 0)
				{
				}
				return this.d;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)99942400;
				short num2 = num;
				num = (short)762610591;
				short num3 = num;
				num = (short)926253983;
				switch (num3 == num)
				{
				}
				num = (short)695205888;
				if (num != 0)
				{
				}
				num = (short)2135949313;
				if (num != 0)
				{
				}
				this.d = value;
			}
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00015950 File Offset: 0x00013B50
		private void c(global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer A_0)
		{
			short num;
			try
			{
				num = (short)1981639837;
				short num2 = num;
				num = (short)170945693;
				switch (num2 == num)
				{
				}
				num = (short)1122435073;
				if (num != 0)
				{
				}
				num = (short)1369702400;
				if (num != 0)
				{
				}
				base.CommandHandler.CancelBatchOpCommand.Execute(new object[]
				{
					A_0
				});
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, false, false);
			}
			num = (short)443678720;
			short num3 = num;
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00015A30 File Offset: 0x00013C30
		private void b()
		{
			short num;
			try
			{
				num = (short)1661482040;
				short num2 = num;
				num = (short)1241396280;
				switch (num2 == num)
				{
				}
				num = (short)1367998464;
				if (num != 0)
				{
				}
				base.CommandHandler.ClearBatchOpCommand.Execute(global::System.Array.Empty<object>());
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, false, false);
			}
			num = (short)1909719040;
			short num3 = num;
			num = (short)1597898753;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00015B10 File Offset: 0x00013D10
		private void b(global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer A_0)
		{
			int a_ = 12;
			short num;
			try
			{
				num = (short)782303232;
				switch (num)
				{
				default:
				{
					num = (short)563347457;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::System.Collections.Generic.List<string> parameters;
						switch (num2)
						{
						case 0:
							goto IL_282;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_71;
							}
							continue;
						case 2:
							goto IL_287;
						case 3:
						{
							if (A_0.ForReadWrite)
							{
								num = (short)1111031813;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)264989552;
							short num3 = num;
							num = (short)1253534576;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_282;
							default:
								num = (short)63504384;
								if (num != 0)
								{
								}
								global::Motorola.CommonCPS.RadioManagement.Infrastructure.NavigationHelper.Go(global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("針郟蟡難蟥鳧菩菫胭釯黱냳鏵賷鯹闻鋽珿吁洃挅缇", a_), parameters);
								num = (short)284033031;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 4:
							goto IL_96;
						case 5:
							global::Motorola.CommonCPS.RadioManagement.Infrastructure.NavigationHelper.Go(global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("軝鋟跡菣铥觧蟩臫蟭黯闱냳鏵賷鯹闻鋽珿吁洃挅缇", a_), parameters);
							num = (short)1810759682;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							goto IL_29F;
						case 7:
							goto IL_287;
						case 8:
							if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveMainModule == global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("铝迟胡", a_))
							{
								num = (short)1981284352;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_287;
						}
						IL_71:
						if (!string.IsNullOrEmpty(A_0.InitializationError))
						{
							num = (short)1256128516;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Guid guid = global::System.Guid.NewGuid();
						guid = (global::System.Guid)base.CommandHandler.GetBatchOpCommand.Execute(new object[]
						{
							A_0
						});
						global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxy.GetInstance().NavigateToMainModuleCommand.Execute(global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("铝迟胡", a_));
						num = (short)1998585864;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_282:
						global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
						string str = global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("韝ꓟ\udfe1", a_);
						global::System.Guid guid2 = guid;
						list.Add(str + guid2.ToString());
						list.Add(global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("郝臟迡臣\udbe5", a_) + A_0.ContainerName);
						parameters = list;
						num = (short)918224899;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_287:
						num = (short)163512326;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_96:
					string message = string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Create_JobContainer_Error, A_0.InitializationError);
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_Generic_Error, message);
					IL_29F:
					break;
				}
				}
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
			}
			num = (short)1548484608;
			short num4 = num;
			num = (short)1584136193;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000133 RID: 307 RVA: 0x00015E34 File Offset: 0x00014034
		private bool a()
		{
			short num;
			bool result;
			try
			{
				num = (short)974037156;
				short num2 = num;
				num = (short)1411424420;
				switch (num2 == num)
				{
				}
				num = (short)1352335360;
				if (num != 0)
				{
				}
				result = base.CommandHandler.ClearBatchOpCommand.CanExecute(global::System.Array.Empty<object>());
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, false, false);
				result = false;
			}
			num = (short)1306591232;
			short num3 = num;
			num = (short)1190330369;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x06000134 RID: 308 RVA: 0x00015F10 File Offset: 0x00014110
		private bool a(global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer A_0)
		{
			short num;
			bool result;
			try
			{
				num = (short)1347944448;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					bool flag;
					switch (num2)
					{
					case 0:
						IL_15:
						switch (0)
						{
						case 0:
							goto IL_39;
						}
						continue;
					case 1:
						num = (short)180748292;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_103;
					case 3:
						flag = false;
						goto IL_A0;
					case 4:
						flag = (A_0.Status > global::Motorola.CommonCPS.Server.CommonDBConstants.JobContainerStatus.PENDING);
						goto IL_A0;
					}
					IL_39:
					if (base.CommandHandler.ClearBatchOpCommand.CanExecute(global::System.Array.Empty<object>()))
					{
						num = (short)853737473;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1728577539;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_A0:
					result = flag;
					num = (short)223909975;
					short num3 = num;
					num = (short)1141413975;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_15;
					default:
						num = (short)1117650944;
						if (num != 0)
						{
						}
						num = (short)2143289346;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				IL_103:;
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, false, false);
				result = false;
			}
			num = (short)1989279744;
			short num4 = num;
			num = (short)305528833;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x06000135 RID: 309 RVA: 0x000160A0 File Offset: 0x000142A0
		private void a(object A_0, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs A_1)
		{
			short num = (short)1372913664;
			short num2 = num;
			num = (short)106157658;
			short num3 = num;
			num = (short)1344853594;
			switch (num3 == num)
			{
			}
			num = (short)977928193;
			if (num != 0)
			{
			}
			num = (short)48103424;
			if (num != 0)
			{
			}
			this.ClearCommand.RaiseCanExecuteChanged();
		}

		// Token: 0x040000E1 RID: 225
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.RadioManagement.UIModels.TasksContext a;

		// Token: 0x040000E2 RID: 226
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer> b;

		// Token: 0x040000E3 RID: 227
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand c;

		// Token: 0x040000E4 RID: 228
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer> d;
	}
}
