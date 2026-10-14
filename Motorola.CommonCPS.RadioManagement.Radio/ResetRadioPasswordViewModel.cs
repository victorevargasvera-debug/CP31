using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Events;
using Motorola.Common.CustomException;
using Motorola.CommonCPS.RadioManagement.Command;
using Motorola.CommonCPS.RadioManagement.Global;
using Motorola.CommonCPS.RadioManagement.Infrastructure;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;

namespace Motorola.CommonCPS.RadioManagement.Radio
{
	// Token: 0x0200000F RID: 15
	public class ResetRadioPasswordViewModel : global::Motorola.CommonCPS.RadioManagement.Infrastructure.PopoupViewModelBase
	{
		// Token: 0x06000044 RID: 68 RVA: 0x00006A80 File Offset: 0x00004C80
		public ResetRadioPasswordViewModel(global::Microsoft.Practices.Prism.Events.IEventAggregator eventAggregator, global::Motorola.CommonCPS.RadioManagement.Command.ICommandHandler commandHandler, global::Motorola.CommonCPS.RadioManagement.UIModels.ResetRadioPasswordContext resetRadioPasswordContext) : base(eventAggregator, commandHandler)
		{
			this.ResetRadioPasswordContext = resetRadioPasswordContext;
			this.ResetRadioPasswordContext.PropertyChanged += this.a;
			this.ResetRadioPasswordCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.d), new global::System.Func<bool>(this.c));
			this.BrowseForFileCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.b), new global::System.Func<bool>(this.a));
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000045 RID: 69 RVA: 0x00006AFC File Offset: 0x00004CFC
		// (set) Token: 0x06000046 RID: 70 RVA: 0x00006BA8 File Offset: 0x00004DA8
		public global::Motorola.CommonCPS.RadioManagement.UIModels.ResetRadioPasswordContext ResetRadioPasswordContext
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)118170403;
				short num2 = num;
				num = (short)2126783267;
				switch (num2 == num)
				{
				}
				num = (short)466878464;
				if (num != 0)
				{
				}
				num = (short)1549926400;
				short num3 = num;
				num = (short)1548025857;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1543101408;
				short num2 = num;
				num = (short)1189338080;
				switch (num2 == num)
				{
				}
				num = (short)1478361089;
				if (num != 0)
				{
				}
				num = (short)405012480;
				short num3 = num;
				num = (short)871366656;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000047 RID: 71 RVA: 0x00006C5C File Offset: 0x00004E5C
		// (set) Token: 0x06000048 RID: 72 RVA: 0x00006D0C File Offset: 0x00004F0C
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand ResetRadioPasswordCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1656598173;
				short num2 = num;
				num = (short)8105629;
				switch (num2 == num)
				{
				}
				num = (short)765394944;
				if (num != 0)
				{
				}
				num = (short)1276444672;
				short num3 = num;
				num = (short)1511456769;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1225457665;
				if (num != 0)
				{
				}
				num = (short)1197614240;
				short num2 = num;
				num = (short)254813344;
				switch (num2 == num)
				{
				}
				num = (short)37289984;
				short num3 = num;
				num = (short)1204289536;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000049 RID: 73 RVA: 0x00006DC0 File Offset: 0x00004FC0
		// (set) Token: 0x0600004A RID: 74 RVA: 0x00006E70 File Offset: 0x00005070
		public bool ResetRadioPasswordIsExecuting
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1209555056;
				short num2 = num;
				num = (short)87578736;
				switch (num2 == num)
				{
				}
				num = (short)251265025;
				if (num != 0)
				{
				}
				num = (short)917372928;
				short num3 = num;
				num = (short)1702363136;
				if (num != 0)
				{
				}
				return this.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1117480305;
				short num2 = num;
				num = (short)287991153;
				switch (num2 == num)
				{
				}
				num = (short)1695154176;
				if (num != 0)
				{
				}
				num = (short)202506240;
				short num3 = num;
				num = (short)1876885505;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600004B RID: 75 RVA: 0x00006F20 File Offset: 0x00005120
		// (set) Token: 0x0600004C RID: 76 RVA: 0x00006FD0 File Offset: 0x000051D0
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand BrowseForFileCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)211377491;
				short num2 = num;
				num = (short)1594121555;
				switch (num2 == num)
				{
				}
				num = (short)511049729;
				if (num != 0)
				{
				}
				num = (short)79429632;
				short num3 = num;
				num = (short)167247872;
				if (num != 0)
				{
				}
				return this.d;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1773266188;
				short num2 = num;
				num = (short)1665131788;
				switch (num2 == num)
				{
				}
				num = (short)35913728;
				if (num != 0)
				{
				}
				num = (short)426246144;
				short num3 = num;
				num = (short)4128769;
				if (num != 0)
				{
				}
				this.d = value;
			}
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00007080 File Offset: 0x00005280
		private void d()
		{
			short num;
			try
			{
				num = (short)856583278;
				short num2 = num;
				num = (short)685075566;
				switch (num2 == num)
				{
				}
				num = (short)1855651840;
				if (num != 0)
				{
				}
				this.ResetRadioPasswordIsExecuting = true;
				base.CommandHandler.ResetRadioPasswordCommand.Execute(new object[]
				{
					this.ResetRadioPasswordContext
				});
				base.CloseCommand.Execute();
			}
			catch (global::Motorola.Common.CustomException.CommonException exception)
			{
				this.ResetRadioPasswordContext.ExceptionMessage = global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, false, false);
			}
			num = (short)47710209;
			if (num != 0)
			{
			}
			num = (short)1812135936;
			short num3 = num;
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00007184 File Offset: 0x00005384
		private bool c()
		{
			short num;
			bool result;
			try
			{
				num = (short)1293090819;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					bool flag;
					switch (num2)
					{
					case 0:
						flag = base.CommandHandler.ResetRadioPasswordCommand.CanExecute(new object[]
						{
							this.ResetRadioPasswordContext
						});
						goto IL_F4;
					case 1:
						goto IL_10C;
					case 2:
					{
						num = (short)877397550;
						short num3 = num;
						num = (short)504301102;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_10C;
						default:
							num = (short)904462336;
							if (num != 0)
							{
							}
							num = (short)804782080;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 3:
						switch (0)
						{
						case 0:
							goto IL_38;
						}
						continue;
					case 4:
						flag = false;
						goto IL_F4;
					}
					IL_38:
					if (!this.ResetRadioPasswordIsExecuting)
					{
						num = (short)1035599874;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1644625924;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_F4:
					result = flag;
					num = (short)1303379969;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_10C:;
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, false, false);
				result = false;
			}
			num = (short)758972417;
			if (num != 0)
			{
			}
			num = (short)981336064;
			short num4 = num;
			return result;
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00007318 File Offset: 0x00005518
		private void b()
		{
			int a_ = 15;
			switch (0)
			{
			case 0:
				goto IL_25;
			}
			int num;
			global::System.Windows.Forms.OpenFileDialog openFileDialog;
			short num2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					return;
				case 1:
					if (openFileDialog.ShowDialog() == global::System.Windows.Forms.DialogResult.OK)
					{
						num2 = (short)948371458;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 2:
				{
					num2 = (short)1393885184;
					short num3 = num2;
					num2 = (short)756389148;
					short num4 = num2;
					num2 = (short)109745436;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
						num2 = (short)1793785857;
						if (num2 != 0)
						{
						}
						num2 = (short)868614144;
						if (num2 != 0)
						{
						}
						this.ResetRadioPasswordContext.PasswordResetFilePath = openFileDialog.FileName;
						global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.LastSelectedPasswordResetFileDirectory = global::System.IO.Path.GetDirectoryName(openFileDialog.FileName);
						global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.Save();
						num2 = (short)899022848;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				}
				goto IL_25;
			}
			return;
			IL_25:
			openFileDialog = new global::System.Windows.Forms.OpenFileDialog
			{
				Filter = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Filter_PasswordResetFiles + global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("꧊꓌ꇎ꿒ￔ淪믘닚돜", a_),
				Multiselect = false,
				InitialDirectory = global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.LastSelectedPasswordResetFileDirectory
			};
			num2 = (short)1540227073;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000050 RID: 80 RVA: 0x000074A8 File Offset: 0x000056A8
		private bool a()
		{
			short num = (short)622758944;
			short num2 = num;
			num = (short)1037208608;
			switch (num2 == num)
			{
			}
			num = (short)519307264;
			if (num != 0)
			{
			}
			num = (short)2007891968;
			short num3 = num;
			num = (short)1117126657;
			if (num != 0)
			{
			}
			return !this.ResetRadioPasswordIsExecuting;
		}

		// Token: 0x06000051 RID: 81 RVA: 0x0000755C File Offset: 0x0000575C
		private void a(object A_0, global::System.ComponentModel.PropertyChangedEventArgs A_1)
		{
			int a_ = 17;
			if (A_1.PropertyName == global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("胄뿆꫈껊뷌믎룐볒믔髖볘꣚껜뻞蛠蛢", a_))
			{
				short num = (short)924385280;
				short num2 = num;
				num = (short)358671795;
				short num3 = num;
				num = (short)21882291;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)924647425;
					if (num != 0)
					{
					}
					num = (short)1412759552;
					if (num != 0)
					{
					}
					return;
				}
			}
			this.ResetRadioPasswordContext.ExceptionMessage = string.Empty;
			this.ResetRadioPasswordCommand.RaiseCanExecuteChanged();
		}

		// Token: 0x04000033 RID: 51
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.RadioManagement.UIModels.ResetRadioPasswordContext a;

		// Token: 0x04000034 RID: 52
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand b;

		// Token: 0x04000035 RID: 53
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool c;

		// Token: 0x04000036 RID: 54
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand d;
	}
}
