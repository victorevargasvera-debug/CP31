using System;
using Motorola.CommonCPS.RadioManagement.ASTROOTARProfile;
using Motorola.CommonCPS.RadioManagement.CommandHandlerDIModule;
using Motorola.CommonCPS.RadioManagement.SharedServices;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x02000017 RID: 23
	public abstract class CommandHandler : global::System.MarshalByRefObject, global::Motorola.CommonCPS.RadioManagement.Command.ICommandHandler
	{
		// Token: 0x06000062 RID: 98 RVA: 0x00007B8C File Offset: 0x00005D8C
		protected CommandHandler(global::Motorola.CommonCPS.RadioManagement.CommandHandlerDIModule.IInstanceResolver instanceResolver)
		{
			this.InstanceResolver = instanceResolver;
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000063 RID: 99 RVA: 0x00007BA8 File Offset: 0x00005DA8
		public global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation AddGroupCommand
		{
			get
			{
				short num = (short)138719921;
				short num2 = num;
				num = (short)927118001;
				switch (num2 == num)
				{
				}
				num = (short)1163984897;
				if (num != 0)
				{
				}
				num = (short)1764163584;
				if (num != 0)
				{
				}
				num = (short)219873280;
				short num3 = num;
				return new global::Motorola.CommonCPS.RadioManagement.Command.AddGroupCommand();
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000064 RID: 100 RVA: 0x00007C58 File Offset: 0x00005E58
		public global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation DeleteGroupCommand
		{
			get
			{
				short num = (short)521362620;
				short num2 = num;
				num = (short)1397513404;
				switch (num2 == num)
				{
				}
				num = (short)189530113;
				if (num != 0)
				{
				}
				num = (short)1075511296;
				if (num != 0)
				{
				}
				num = (short)643366912;
				short num3 = num;
				return new global::Motorola.CommonCPS.RadioManagement.Command.DeleteGroupCommand();
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000065 RID: 101 RVA: 0x00007D08 File Offset: 0x00005F08
		public global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation RenameGroupCommand
		{
			get
			{
				short num = (short)2118090113;
				short num2 = num;
				num = (short)699760001;
				switch (num2 == num)
				{
				}
				num = (short)1229127681;
				if (num != 0)
				{
				}
				num = (short)301268992;
				if (num != 0)
				{
				}
				num = (short)1589116928;
				short num3 = num;
				return new global::Motorola.CommonCPS.RadioManagement.Command.RenameGroupCommand();
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000066 RID: 102 RVA: 0x00007DB4 File Offset: 0x00005FB4
		public global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation MoveDeviceCommand
		{
			get
			{
				short num = (short)776732673;
				if (num != 0)
				{
				}
				num = (short)696780066;
				short num2 = num;
				num = (short)718800162;
				switch (num2 == num)
				{
				}
				num = (short)1218183168;
				if (num != 0)
				{
				}
				num = (short)1668022272;
				short num3 = num;
				return new global::Motorola.CommonCPS.RadioManagement.Command.MoveDeviceCommand();
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000067 RID: 103 RVA: 0x00007E64 File Offset: 0x00006064
		public global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation MoveDeviceBatchCommand
		{
			get
			{
				short num = (short)335107472;
				short num2 = num;
				num = (short)1119311248;
				switch (num2 == num)
				{
				}
				num = (short)1216151553;
				if (num != 0)
				{
				}
				num = (short)1673461760;
				if (num != 0)
				{
				}
				num = (short)1931739136;
				short num3 = num;
				return new global::Motorola.CommonCPS.RadioManagement.Command.MoveDeviceBatchCommand();
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000068 RID: 104 RVA: 0x00007F10 File Offset: 0x00006110
		public global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation PrepareMoveDeviceBatchCommand
		{
			get
			{
				short num = (short)987234305;
				if (num != 0)
				{
				}
				num = (short)592014796;
				short num2 = num;
				num = (short)283340236;
				switch (num2 == num)
				{
				}
				num = (short)1810366464;
				if (num != 0)
				{
				}
				num = (short)1406337024;
				short num3 = num;
				return new global::Motorola.CommonCPS.RadioManagement.Command.PrepareMoveDeviceBatchCommand();
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000069 RID: 105 RVA: 0x00007FC4 File Offset: 0x000061C4
		public global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation RefreshGroupCommand
		{
			get
			{
				short num = (short)1723119755;
				short num2 = num;
				num = (short)1045280907;
				switch (num2 == num)
				{
				}
				num = (short)1245118465;
				if (num != 0)
				{
				}
				num = (short)658964480;
				if (num != 0)
				{
				}
				num = (short)724041728;
				short num3 = num;
				return new global::Motorola.CommonCPS.RadioManagement.Command.RefreshGroupCommand();
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600006A RID: 106 RVA: 0x00008074 File Offset: 0x00006274
		public global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation UpdateGroupCommand
		{
			get
			{
				short num = (short)757260764;
				short num2 = num;
				num = (short)171499996;
				switch (num2 == num)
				{
				}
				num = (short)1584332800;
				if (num != 0)
				{
				}
				num = (short)873136129;
				if (num != 0)
				{
				}
				num = (short)1701576704;
				short num3 = num;
				return new global::Motorola.CommonCPS.RadioManagement.Command.UpdateGroupCommand();
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600006B RID: 107 RVA: 0x00008120 File Offset: 0x00006320
		public virtual global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation AddRadioCommand
		{
			get
			{
				short num = (short)2079957458;
				short num2 = num;
				num = (short)2007278034;
				switch (num2 == num)
				{
				}
				num = (short)454033409;
				if (num != 0)
				{
				}
				num = (short)324599808;
				if (num != 0)
				{
				}
				num = (short)540737536;
				short num3 = num;
				return new global::Motorola.CommonCPS.RadioManagement.Command.NullCommand();
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600006C RID: 108 RVA: 0x000081D0 File Offset: 0x000063D0
		public global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation UpgradeLanguageInRadioCommand
		{
			get
			{
				short num = (short)58435102;
				short num2 = num;
				num = (short)425240094;
				switch (num2 == num)
				{
				}
				num = (short)238944256;
				if (num != 0)
				{
				}
				num = (short)1761607681;
				if (num != 0)
				{
				}
				num = (short)866648064;
				short num3 = num;
				return new global::Motorola.CommonCPS.RadioManagement.Command.UpgradeLanguageInRadioCommand();
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600006D RID: 109 RVA: 0x00008280 File Offset: 0x00006480
		public virtual global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation PrepareModifyCodeplugPasswordCommand
		{
			get
			{
				short num = (short)1666838512;
				short num2 = num;
				num = (short)257748976;
				switch (num2 == num)
				{
				}
				num = (short)364183552;
				if (num != 0)
				{
				}
				num = (short)658636801;
				if (num != 0)
				{
				}
				num = (short)2121596928;
				short num3 = num;
				return new global::Motorola.CommonCPS.RadioManagement.Command.NullCommand();
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600006E RID: 110 RVA: 0x0000832C File Offset: 0x0000652C
		public virtual global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation ModifyCodeplugPasswordCommand
		{
			get
			{
				short num = (short)1335296001;
				if (num != 0)
				{
				}
				num = (short)1077457208;
				short num2 = num;
				num = (short)1184870712;
				switch (num2 == num)
				{
				}
				num = (short)726794240;
				if (num != 0)
				{
				}
				num = (short)521142272;
				short num3 = num;
				return new global::Motorola.CommonCPS.RadioManagement.Command.NullCommand();
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600006F RID: 111 RVA: 0x000083DC File Offset: 0x000065DC
		public virtual global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation PrepareResetRadioPasswordCommand
		{
			get
			{
				short num = (short)1273102337;
				if (num != 0)
				{
				}
				num = (short)1788218848;
				short num2 = num;
				num = (short)1560153568;
				switch (num2 == num)
				{
				}
				num = (short)1390215168;
				if (num != 0)
				{
				}
				num = (short)148897792;
				short num3 = num;
				return new global::Motorola.CommonCPS.RadioManagement.Command.NullCommand();
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000070 RID: 112 RVA: 0x0000848C File Offset: 0x0000668C
		public virtual global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation ResetRadioPasswordCommand
		{
			get
			{
				short num = (short)94206921;
				short num2 = num;
				num = (short)569932745;
				switch (num2 == num)
				{
				}
				num = (short)1455947777;
				if (num != 0)
				{
				}
				num = (short)1041825792;
				if (num != 0)
				{
				}
				num = (short)35717120;
				short num3 = num;
				return new global::Motorola.CommonCPS.RadioManagement.Command.NullCommand();
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000071 RID: 113 RVA: 0x0000853C File Offset: 0x0000673C
		public virtual global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation PrepareAddRadioCommand
		{
			get
			{
				short num = (short)711922963;
				short num2 = num;
				num = (short)841553171;
				switch (num2 == num)
				{
				}
				num = (short)757202945;
				if (num != 0)
				{
				}
				num = (short)972029952;
				if (num != 0)
				{
				}
				num = (short)1225785344;
				short num3 = num;
				return new global::Motorola.CommonCPS.RadioManagement.Command.NullCommand();
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000072 RID: 114 RVA: 0x000085E8 File Offset: 0x000067E8
		public global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation SaveRadioCommand
		{
			get
			{
				short num = (short)2129264641;
				if (num != 0)
				{
				}
				num = (short)1518668714;
				short num2 = num;
				num = (short)1360071594;
				switch (num2 == num)
				{
				}
				num = (short)1628766208;
				if (num != 0)
				{
				}
				num = (short)1990393856;
				short num3 = num;
				return new global::Motorola.CommonCPS.RadioManagement.Command.EditRadioCommand();
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000073 RID: 115
		public abstract global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation PrepareScheduleJobCommand { get; }

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000074 RID: 116 RVA: 0x00008698 File Offset: 0x00006898
		public global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation CancelJobCommand
		{
			get
			{
				short num = (short)910670157;
				short num2 = num;
				num = (short)1872607565;
				switch (num2 == num)
				{
				}
				num = (short)903544833;
				if (num != 0)
				{
				}
				num = (short)892731392;
				if (num != 0)
				{
				}
				num = (short)620822528;
				short num3 = num;
				return new global::Motorola.CommonCPS.RadioManagement.Command.CancelJobCommand();
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000075 RID: 117 RVA: 0x00008748 File Offset: 0x00006948
		public global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation CompleteJobCommand
		{
			get
			{
				short num = (short)1103691777;
				if (num != 0)
				{
				}
				num = (short)1823347510;
				short num2 = num;
				num = (short)1351422774;
				switch (num2 == num)
				{
				}
				num = (short)994115584;
				if (num != 0)
				{
				}
				num = (short)806027264;
				short num3 = num;
				return new global::Motorola.CommonCPS.RadioManagement.Command.CompleteJobCommand();
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000076 RID: 118
		public abstract global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation ScheduleJobCommand { get; }

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000077 RID: 119 RVA: 0x000087F8 File Offset: 0x000069F8
		public global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation SelectTemplateCommand
		{
			get
			{
				short num = (short)1423013997;
				short num2 = num;
				num = (short)2133555309;
				switch (num2 == num)
				{
				}
				num = (short)900005889;
				if (num != 0)
				{
				}
				num = (short)903806976;
				if (num != 0)
				{
				}
				num = (short)1887502336;
				short num3 = num;
				return new global::Motorola.CommonCPS.RadioManagement.Command.ApplyTemplateCommand();
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000078 RID: 120 RVA: 0x000088A8 File Offset: 0x00006AA8
		public global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation PrepareSelectTemplateCommand
		{
			get
			{
				short num = (short)1585643521;
				if (num != 0)
				{
				}
				num = (short)1894092000;
				short num2 = num;
				num = (short)403737824;
				switch (num2 == num)
				{
				}
				num = (short)600965120;
				if (num != 0)
				{
				}
				num = (short)344981504;
				short num3 = num;
				return new global::Motorola.CommonCPS.RadioManagement.Command.SelectTemplateCommand();
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000079 RID: 121 RVA: 0x00008958 File Offset: 0x00006B58
		public global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation ExportRadioCommand
		{
			get
			{
				short num = (short)1129434493;
				short num2 = num;
				num = (short)677694845;
				switch (num2 == num)
				{
				}
				num = (short)1757675520;
				if (num != 0)
				{
				}
				num = (short)922353665;
				if (num != 0)
				{
				}
				num = (short)1049886720;
				short num3 = num;
				return new global::Motorola.CommonCPS.RadioManagement.Command.ExportCodeplugCommand();
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x0600007A RID: 122 RVA: 0x00008A08 File Offset: 0x00006C08
		public global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation EditCodeplugCommand
		{
			get
			{
				short num = (short)282003216;
				short num2 = num;
				num = (short)14092048;
				switch (num2 == num)
				{
				}
				num = (short)436469761;
				if (num != 0)
				{
				}
				num = (short)1131806720;
				if (num != 0)
				{
				}
				num = (short)1508573184;
				short num3 = num;
				return new global::Motorola.CommonCPS.RadioManagement.Command.EditCodeplugCommand();
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x0600007B RID: 123 RVA: 0x00008AB4 File Offset: 0x00006CB4
		public global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation ImportRadiosCommand
		{
			get
			{
				short num = (short)34930689;
				if (num != 0)
				{
				}
				num = (short)239263350;
				short num2 = num;
				num = (short)849075830;
				switch (num2 == num)
				{
				}
				num = (short)1379860480;
				if (num != 0)
				{
				}
				num = (short)842989568;
				short num3 = num;
				return new global::Motorola.CommonCPS.RadioManagement.Command.ImportRadioCommand();
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x0600007C RID: 124 RVA: 0x00008B64 File Offset: 0x00006D64
		public global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation PrepareImportRadiosCommand
		{
			get
			{
				short num = (short)1858380567;
				short num2 = num;
				num = (short)673620759;
				switch (num2 == num)
				{
				}
				num = (short)856817665;
				if (num != 0)
				{
				}
				num = (short)1237123072;
				if (num != 0)
				{
				}
				num = (short)1463222272;
				short num3 = num;
				return new global::Motorola.CommonCPS.RadioManagement.Command.PrepareImportRadiosCommand();
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x0600007D RID: 125 RVA: 0x00008C14 File Offset: 0x00006E14
		public global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation ImportFileToRadioGridCommand
		{
			get
			{
				short num = (short)2130119318;
				short num2 = num;
				num = (short)58264214;
				switch (num2 == num)
				{
				}
				num = (short)719978496;
				if (num != 0)
				{
				}
				num = (short)1599930369;
				if (num != 0)
				{
				}
				num = (short)1613692928;
				short num3 = num;
				return new global::Motorola.CommonCPS.RadioManagement.Command.ImportFileToRadioGridCommand();
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x0600007E RID: 126 RVA: 0x00008CC0 File Offset: 0x00006EC0
		public global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation ExportGridToFileCommand
		{
			get
			{
				short num = (short)134018227;
				short num2 = num;
				num = (short)732296371;
				switch (num2 == num)
				{
				}
				num = (short)969211905;
				if (num != 0)
				{
				}
				num = (short)1303838720;
				if (num != 0)
				{
				}
				num = (short)162725888;
				short num3 = num;
				return new global::Motorola.CommonCPS.RadioManagement.Command.ExportGridToFileCommand(global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.GroupService);
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x0600007F RID: 127 RVA: 0x00008D7C File Offset: 0x00006F7C
		public global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation DeleteRadiosCommand
		{
			get
			{
				short num = (short)1192932189;
				short num2 = num;
				num = (short)1696969565;
				switch (num2 == num)
				{
				}
				num = (short)1186004992;
				if (num != 0)
				{
				}
				num = (short)1474232321;
				if (num != 0)
				{
				}
				num = (short)905576448;
				short num3 = num;
				return new global::Motorola.CommonCPS.RadioManagement.Command.DeleteDeviceCommand();
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000080 RID: 128 RVA: 0x00008E30 File Offset: 0x00007030
		public virtual global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation AstroPrepareFlashPortCommand
		{
			get
			{
				short num = (short)1037768050;
				short num2 = num;
				num = (short)2141656434;
				switch (num2 == num)
				{
				}
				num = (short)1381498880;
				if (num != 0)
				{
				}
				num = (short)239403009;
				if (num != 0)
				{
				}
				num = (short)2066153472;
				short num3 = num;
				return new global::Motorola.CommonCPS.RadioManagement.Command.NullCommand();
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000081 RID: 129 RVA: 0x00008EDC File Offset: 0x000070DC
		public virtual global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation PrepareUpgradeFirmwareCommand
		{
			get
			{
				short num = (short)1887193033;
				short num2 = num;
				num = (short)2039498697;
				switch (num2 == num)
				{
				}
				num = (short)1949958145;
				if (num != 0)
				{
				}
				num = (short)1991245824;
				if (num != 0)
				{
				}
				num = (short)1436286976;
				short num3 = num;
				return new global::Motorola.CommonCPS.RadioManagement.Command.NullCommand();
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06000082 RID: 130 RVA: 0x00008F90 File Offset: 0x00007190
		public virtual global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation SelectFirmwareForUpgradeCommand
		{
			get
			{
				short num = (short)616235009;
				if (num != 0)
				{
				}
				num = (short)2040954094;
				short num2 = num;
				num = (short)1336311022;
				switch (num2 == num)
				{
				}
				num = (short)414449664;
				if (num != 0)
				{
				}
				num = (short)1418199040;
				short num3 = num;
				return new global::Motorola.CommonCPS.RadioManagement.Command.NullCommand();
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000083 RID: 131 RVA: 0x00009040 File Offset: 0x00007240
		public virtual global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation RecoverFirmwareCommand
		{
			get
			{
				short num = (short)609892988;
				short num2 = num;
				num = (short)397687420;
				switch (num2 == num)
				{
				}
				num = (short)646316033;
				if (num != 0)
				{
				}
				num = (short)268632064;
				if (num != 0)
				{
				}
				num = (short)1691746304;
				short num3 = num;
				return new global::Motorola.CommonCPS.RadioManagement.Command.NullCommand();
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000084 RID: 132 RVA: 0x000090F0 File Offset: 0x000072F0
		public global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation DiscardCodeplugCommand
		{
			get
			{
				short num = (short)846156155;
				short num2 = num;
				num = (short)1135694203;
				switch (num2 == num)
				{
				}
				num = (short)1909325824;
				if (num != 0)
				{
				}
				num = (short)1300103169;
				if (num != 0)
				{
				}
				num = (short)613744640;
				short num3 = num;
				return new global::Motorola.CommonCPS.RadioManagement.Command.DiscardCodeplugCommand();
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000085 RID: 133 RVA: 0x0000919C File Offset: 0x0000739C
		public virtual global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation ExportDVRS_Command
		{
			get
			{
				short num = (short)1346961409;
				if (num != 0)
				{
				}
				num = (short)2116142514;
				short num2 = num;
				num = (short)496616882;
				switch (num2 == num)
				{
				}
				num = (short)2072444928;
				if (num != 0)
				{
				}
				num = (short)2118713344;
				short num3 = num;
				return new global::Motorola.CommonCPS.RadioManagement.Command.NullCommand();
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000086 RID: 134 RVA: 0x00009248 File Offset: 0x00007448
		public virtual global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation ResetIndentifiersCommand
		{
			get
			{
				short num = (short)777895046;
				short num2 = num;
				num = (short)1542962310;
				switch (num2 == num)
				{
				}
				num = (short)1536622593;
				if (num != 0)
				{
				}
				num = (short)687013888;
				if (num != 0)
				{
				}
				num = (short)776142848;
				short num3 = num;
				return new global::Motorola.CommonCPS.RadioManagement.Command.ResetIdentifiersCommand();
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000087 RID: 135 RVA: 0x000092F8 File Offset: 0x000074F8
		public virtual global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation SelectWarningRadiostoScheduleJobCommand
		{
			get
			{
				short num = (short)1101134530;
				short num2 = num;
				num = (short)134478530;
				switch (num2 == num)
				{
				}
				num = (short)1035010048;
				if (num != 0)
				{
				}
				num = (short)485163009;
				if (num != 0)
				{
				}
				num = (short)1092616192;
				short num3 = num;
				return new global::Motorola.CommonCPS.RadioManagement.Command.NullCommand();
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000088 RID: 136 RVA: 0x000093A8 File Offset: 0x000075A8
		public global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation CancelRunningJobsCommand
		{
			get
			{
				short num = (short)913753037;
				short num2 = num;
				num = (short)1114751949;
				switch (num2 == num)
				{
				}
				num = (short)927727617;
				if (num != 0)
				{
				}
				num = (short)92209152;
				if (num != 0)
				{
				}
				num = (short)1735196672;
				short num3 = num;
				return new global::Motorola.CommonCPS.RadioManagement.Command.CancelRunningJobsCommand();
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000089 RID: 137 RVA: 0x00009454 File Offset: 0x00007654
		public virtual global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation PrepareResetIndentifiersCommand
		{
			get
			{
				short num = (short)1207486975;
				short num2 = num;
				num = (short)294504959;
				switch (num2 == num)
				{
				}
				num = (short)1954283520;
				if (num != 0)
				{
				}
				num = (short)1171849217;
				if (num != 0)
				{
				}
				num = (short)873398272;
				short num3 = num;
				return new global::Motorola.CommonCPS.RadioManagement.Command.PrepareResetIdentifiersCommand();
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x0600008A RID: 138 RVA: 0x00009500 File Offset: 0x00007700
		public global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation ASTROQueryUpdateRadioCommand
		{
			get
			{
				short num = (short)395968513;
				if (num != 0)
				{
				}
				num = (short)1724252935;
				short num2 = num;
				num = (short)212468487;
				switch (num2 == num)
				{
				}
				num = (short)1615200256;
				if (num != 0)
				{
				}
				num = (short)1098973184;
				short num3 = num;
				return new global::Motorola.CommonCPS.RadioManagement.Command.ASTROQueryUpdateRadioCommand();
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x0600008B RID: 139 RVA: 0x000095B0 File Offset: 0x000077B0
		public global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation ASTROPrepareQueryUpdateRadioCommand
		{
			get
			{
				short num = (short)1786100064;
				short num2 = num;
				num = (short)1515960672;
				switch (num2 == num)
				{
				}
				num = (short)1306132481;
				if (num != 0)
				{
				}
				num = (short)702939136;
				if (num != 0)
				{
				}
				num = (short)1336279040;
				short num3 = num;
				return new global::Motorola.CommonCPS.RadioManagement.Command.ASTROPrepareQueryUpdateRadioCommand();
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x0600008C RID: 140 RVA: 0x00009660 File Offset: 0x00007860
		public global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation ShowLanguageDetailInfoCommand
		{
			get
			{
				short num = (short)1395360990;
				short num2 = num;
				num = (short)2080998622;
				switch (num2 == num)
				{
				}
				num = (short)1955069953;
				if (num != 0)
				{
				}
				num = (short)2023620608;
				if (num != 0)
				{
				}
				num = (short)650575872;
				short num3 = num;
				return new global::Motorola.CommonCPS.RadioManagement.Command.ShowLanguageDetailInfomationCommand();
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x0600008D RID: 141 RVA: 0x00009710 File Offset: 0x00007910
		public global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation ShowVADetailInfoCommand
		{
			get
			{
				short num = (short)151671062;
				short num2 = num;
				num = (short)1543131414;
				switch (num2 == num)
				{
				}
				num = (short)995229697;
				if (num != 0)
				{
				}
				num = (short)305528832;
				if (num != 0)
				{
				}
				num = (short)679936000;
				short num3 = num;
				return new global::Motorola.CommonCPS.RadioManagement.Command.ShowVADetailInfomationCommand();
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x0600008E RID: 142 RVA: 0x000097C0 File Offset: 0x000079C0
		public global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation SelectCodeplugVersionCommand
		{
			get
			{
				short num = (short)111400310;
				short num2 = num;
				num = (short)1036965238;
				switch (num2 == num)
				{
				}
				num = (short)1054408705;
				if (num != 0)
				{
				}
				num = (short)1859125248;
				if (num != 0)
				{
				}
				num = (short)654114816;
				short num3 = num;
				return new global::Motorola.CommonCPS.RadioManagement.Command.ASTROSelectCodeplugVersionCommand();
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x0600008F RID: 143 RVA: 0x00009870 File Offset: 0x00007A70
		public global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation PrepareSelectCodeplugVersionCommand
		{
			get
			{
				short num = (short)457900033;
				if (num != 0)
				{
				}
				num = (short)1325426713;
				short num2 = num;
				num = (short)1846175769;
				switch (num2 == num)
				{
				}
				num = (short)540409856;
				if (num != 0)
				{
				}
				num = (short)1123811328;
				short num3 = num;
				return new global::Motorola.CommonCPS.RadioManagement.Command.ASTROPrepareSelectCodeplugVersionCommand();
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000090 RID: 144 RVA: 0x0000991C File Offset: 0x00007B1C
		public global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation PrepareWiFiPasswordValidationCommand
		{
			get
			{
				short num = (short)1976994771;
				short num2 = num;
				num = (short)1735494611;
				switch (num2 == num)
				{
				}
				num = (short)212140033;
				if (num != 0)
				{
				}
				num = (short)1359806464;
				if (num != 0)
				{
				}
				num = (short)536936448;
				short num3 = num;
				return new global::Motorola.CommonCPS.RadioManagement.Command.PrepareWiFiPasswordValidationCommand();
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000091 RID: 145 RVA: 0x000099C8 File Offset: 0x00007BC8
		public global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation WiFiPasswordValidationCommand
		{
			get
			{
				short num = (short)540837052;
				short num2 = num;
				num = (short)1138066620;
				switch (num2 == num)
				{
				}
				num = (short)1373044737;
				if (num != 0)
				{
				}
				num = (short)790364160;
				if (num != 0)
				{
				}
				num = (short)1020723200;
				short num3 = num;
				return new global::Motorola.CommonCPS.RadioManagement.Command.WiFiPasswordValidationCommand();
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000092 RID: 146 RVA: 0x00009A78 File Offset: 0x00007C78
		public global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation CopyRadioIdentityCommand
		{
			get
			{
				short num = (short)1893594928;
				short num2 = num;
				num = (short)677771056;
				switch (num2 == num)
				{
				}
				num = (short)841023489;
				if (num != 0)
				{
				}
				num = (short)1918107648;
				if (num != 0)
				{
				}
				num = (short)296353792;
				short num3 = num;
				return new global::Motorola.CommonCPS.RadioManagement.Command.CopyRadioIdentityCommand();
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000093 RID: 147 RVA: 0x00009B28 File Offset: 0x00007D28
		public global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation PasteRadioIdentityCommand
		{
			get
			{
				short num = (short)106715975;
				short num2 = num;
				num = (short)596138823;
				switch (num2 == num)
				{
				}
				num = (short)1300496385;
				if (num != 0)
				{
				}
				num = (short)1472528384;
				if (num != 0)
				{
				}
				num = (short)2122383360;
				short num3 = num;
				return new global::Motorola.CommonCPS.RadioManagement.Command.PasteRadioIdentityCommand();
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000094 RID: 148 RVA: 0x00009BD8 File Offset: 0x00007DD8
		public global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation SubmitPasteValueCommand
		{
			get
			{
				short num = (short)681826927;
				short num2 = num;
				num = (short)674945647;
				switch (num2 == num)
				{
				}
				num = (short)86900737;
				if (num != 0)
				{
				}
				num = (short)448856064;
				if (num != 0)
				{
				}
				num = (short)2054553600;
				short num3 = num;
				return new global::Motorola.CommonCPS.RadioManagement.Command.SubmitRadioPasteValueCommand();
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000095 RID: 149 RVA: 0x00009C88 File Offset: 0x00007E88
		public global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation ShowRadioDetailsCommand
		{
			get
			{
				short num = (short)904296232;
				short num2 = num;
				num = (short)281245480;
				switch (num2 == num)
				{
				}
				num = (short)1282277377;
				if (num != 0)
				{
				}
				num = (short)875692032;
				if (num != 0)
				{
				}
				num = (short)2070282240;
				short num3 = num;
				return new global::Motorola.CommonCPS.RadioManagement.Command.ShowRadioDetailsCommand();
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000096 RID: 150 RVA: 0x00009D38 File Offset: 0x00007F38
		public global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation PrepareReportsInRadioViewCommmand
		{
			get
			{
				short num = (short)655426382;
				short num2 = num;
				num = (short)657457998;
				switch (num2 == num)
				{
				}
				num = (short)1521090560;
				if (num != 0)
				{
				}
				num = (short)506527745;
				if (num != 0)
				{
				}
				num = (short)1355677696;
				short num3 = num;
				return new global::Motorola.CommonCPS.RadioManagement.Command.PrepareReportsInRadioViewCommmand();
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000097 RID: 151
		public abstract global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation RestoreCommand { get; }

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000098 RID: 152 RVA: 0x00009DE4 File Offset: 0x00007FE4
		public global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation ShowTemplateLanguageDetailInfoCommand
		{
			get
			{
				short num = (short)1186835091;
				short num2 = num;
				num = (short)235973267;
				switch (num2 == num)
				{
				}
				num = (short)1014628352;
				if (num != 0)
				{
				}
				num = (short)695533569;
				if (num != 0)
				{
				}
				num = (short)979173376;
				short num3 = num;
				return new global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateLanguageDetailInfomationCommand();
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000099 RID: 153 RVA: 0x00009E98 File Offset: 0x00008098
		public global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation ShowTemplateVADetailInfoCommand
		{
			get
			{
				short num = (short)1491503939;
				short num2 = num;
				num = (short)540904259;
				switch (num2 == num)
				{
				}
				num = (short)1584529409;
				if (num != 0)
				{
				}
				num = (short)667746304;
				if (num != 0)
				{
				}
				num = (short)1662386176;
				short num3 = num;
				return new global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand();
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x0600009A RID: 154 RVA: 0x00009F48 File Offset: 0x00008148
		public global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation DeleteTemplatesCommand
		{
			get
			{
				short num = (short)1016268471;
				short num2 = num;
				num = (short)1454245559;
				switch (num2 == num)
				{
				}
				num = (short)1297547264;
				if (num != 0)
				{
				}
				num = (short)59113473;
				if (num != 0)
				{
				}
				num = (short)1183186944;
				short num3 = num;
				return new global::Motorola.CommonCPS.RadioManagement.Command.DeleteTemplatesCommand();
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x0600009B RID: 155 RVA: 0x00009FF8 File Offset: 0x000081F8
		public global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation CancelSaveTemplateAsCommand
		{
			get
			{
				short num = (short)927146896;
				short num2 = num;
				num = (short)1688478608;
				switch (num2 == num)
				{
				}
				num = (short)392167424;
				if (num != 0)
				{
				}
				num = (short)1507459073;
				if (num != 0)
				{
				}
				num = (short)459341824;
				short num3 = num;
				return new global::Motorola.CommonCPS.RadioManagement.Command.CancelSaveTemplateAsCommand();
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x0600009C RID: 156 RVA: 0x0000A0A4 File Offset: 0x000082A4
		public global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation EditTemplateCommand
		{
			get
			{
				short num = (short)1507982420;
				short num2 = num;
				num = (short)1510210644;
				switch (num2 == num)
				{
				}
				num = (short)1468661761;
				if (num != 0)
				{
				}
				num = (short)1488715776;
				if (num != 0)
				{
				}
				num = (short)522452992;
				short num3 = num;
				return new global::Motorola.CommonCPS.RadioManagement.Command.EditTemplateCommand();
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x0600009D RID: 157
		public abstract global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation PrepareImportTemplatesCommand { get; }

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x0600009E RID: 158 RVA: 0x0000A150 File Offset: 0x00008350
		public global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation ImportTemplatesCommand
		{
			get
			{
				short num = (short)1307224993;
				short num2 = num;
				num = (short)1745005473;
				switch (num2 == num)
				{
				}
				num = (short)840564737;
				if (num != 0)
				{
				}
				num = (short)813629440;
				if (num != 0)
				{
				}
				num = (short)343343104;
				short num3 = num;
				return new global::Motorola.CommonCPS.RadioManagement.Command.ImportTemplateCommand();
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x0600009F RID: 159 RVA: 0x0000A200 File Offset: 0x00008400
		public global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation SaveTemplateAsCommand
		{
			get
			{
				short num = (short)187006533;
				short num2 = num;
				num = (short)98991685;
				switch (num2 == num)
				{
				}
				num = (short)483065857;
				if (num != 0)
				{
				}
				num = (short)600047616;
				if (num != 0)
				{
				}
				num = (short)657457152;
				short num3 = num;
				return new global::Motorola.CommonCPS.RadioManagement.Command.SaveTemplateAsCommand();
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x0000A2AC File Offset: 0x000084AC
		public global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation SaveTemplateCommand
		{
			get
			{
				short num = (short)819911273;
				short num2 = num;
				num = (short)1069603433;
				switch (num2 == num)
				{
				}
				num = (short)2117599232;
				if (num != 0)
				{
				}
				num = (short)947519489;
				if (num != 0)
				{
				}
				num = (short)708509696;
				short num3 = num;
				return new global::Motorola.CommonCPS.RadioManagement.Command.EditTemplateColumnCommand();
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060000A1 RID: 161 RVA: 0x0000A35C File Offset: 0x0000855C
		public global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation SaveTemplateCommandFromCPS
		{
			get
			{
				short num = (short)997916673;
				if (num != 0)
				{
				}
				num = (short)2076179083;
				short num2 = num;
				num = (short)2143484555;
				switch (num2 == num)
				{
				}
				num = (short)1710620672;
				if (num != 0)
				{
				}
				num = (short)2119630848;
				short num3 = num;
				return new global::Motorola.CommonCPS.RadioManagement.Command.SaveTemplateCommandFromCPS();
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060000A2 RID: 162 RVA: 0x0000A408 File Offset: 0x00008608
		public virtual global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation ASTROUpgradeLanguagePackCommand
		{
			get
			{
				short num = (short)341860572;
				short num2 = num;
				num = (short)1315791068;
				switch (num2 == num)
				{
				}
				num = (short)1845559297;
				if (num != 0)
				{
				}
				num = (short)1832058880;
				if (num != 0)
				{
				}
				num = (short)371064832;
				short num3 = num;
				return new global::Motorola.CommonCPS.RadioManagement.Command.NullCommand();
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060000A3 RID: 163 RVA: 0x0000A4B4 File Offset: 0x000086B4
		public virtual global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation SelectLanguagePackCommand
		{
			get
			{
				short num = (short)907917934;
				short num2 = num;
				num = (short)1606466158;
				switch (num2 == num)
				{
				}
				num = (short)2060058625;
				if (num != 0)
				{
				}
				num = (short)97714176;
				if (num != 0)
				{
				}
				num = (short)866189312;
				short num3 = num;
				return new global::Motorola.CommonCPS.RadioManagement.Command.NullCommand();
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060000A4 RID: 164 RVA: 0x0000A564 File Offset: 0x00008764
		public global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation SavePackageCommand
		{
			get
			{
				short num = (short)1989649176;
				short num2 = num;
				num = (short)61645592;
				switch (num2 == num)
				{
				}
				num = (short)1038155777;
				if (num != 0)
				{
				}
				num = (short)572915712;
				if (num != 0)
				{
				}
				num = (short)926089216;
				short num3 = num;
				return new global::Motorola.CommonCPS.RadioManagement.Command.EditPackageColumnCommand();
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060000A5 RID: 165 RVA: 0x0000A614 File Offset: 0x00008814
		public global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation ImportLanguagePackCommand
		{
			get
			{
				short num = (short)346135059;
				short num2 = num;
				num = (short)1692703251;
				switch (num2 == num)
				{
				}
				num = (short)1202716673;
				if (num != 0)
				{
				}
				num = (short)1279393792;
				if (num != 0)
				{
				}
				num = (short)1385037824;
				short num3 = num;
				return new global::Motorola.CommonCPS.RadioManagement.Command.ImportLanguagePackageCommand();
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060000A6 RID: 166
		public abstract global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation PrepareImportPackagesCommand { get; }

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060000A7 RID: 167 RVA: 0x0000A6C4 File Offset: 0x000088C4
		public virtual global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation PrepareSelectGeneralPackagesCommand
		{
			get
			{
				short num = (short)445195491;
				short num2 = num;
				num = (short)632759523;
				switch (num2 == num)
				{
				}
				num = (short)380502017;
				if (num != 0)
				{
				}
				num = (short)1590755328;
				if (num != 0)
				{
				}
				num = (short)2033647616;
				short num3 = num;
				return new global::Motorola.CommonCPS.RadioManagement.Command.NullCommand();
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060000A8 RID: 168 RVA: 0x0000A774 File Offset: 0x00008974
		public virtual global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation SelectGeneralPackagesCommand
		{
			get
			{
				short num = (short)128740257;
				short num2 = num;
				num = (short)327183265;
				switch (num2 == num)
				{
				}
				num = (short)1851850752;
				short num3 = num;
				num = (short)1186529281;
				if (num != 0)
				{
				}
				num = (short)1668808704;
				if (num != 0)
				{
				}
				return new global::Motorola.CommonCPS.RadioManagement.Command.NullCommand();
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060000A9 RID: 169 RVA: 0x0000A824 File Offset: 0x00008A24
		public global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation DeletePackagesCommand
		{
			get
			{
				short num = (short)304742401;
				if (num != 0)
				{
				}
				num = (short)1826594421;
				short num2 = num;
				num = (short)284008053;
				switch (num2 == num)
				{
				default:
				{
					num = (short)505020416;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1673854976;
				if (num != 0)
				{
				}
				return new global::Motorola.CommonCPS.RadioManagement.Command.DeletePackageCommand();
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060000AA RID: 170 RVA: 0x0000A8D4 File Offset: 0x00008AD4
		public global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation AddSelectedDevices
		{
			get
			{
				short num = (short)1456406529;
				if (num != 0)
				{
				}
				num = (short)1534847877;
				short num2 = num;
				num = (short)2002381701;
				switch (num2 == num)
				{
				default:
				{
					num = (short)810090496;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1632894976;
				if (num != 0)
				{
				}
				return new global::Motorola.CommonCPS.RadioManagement.Command.AddSelectedDevices();
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060000AB RID: 171 RVA: 0x0000A984 File Offset: 0x00008B84
		public global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation RemoveSelectedDevices
		{
			get
			{
				short num = (short)1229541722;
				short num2 = num;
				num = (short)1157845338;
				switch (num2 == num)
				{
				}
				num = (short)1575157760;
				short num3 = num;
				num = (short)1100677121;
				if (num != 0)
				{
				}
				num = (short)1870397440;
				if (num != 0)
				{
				}
				return new global::Motorola.CommonCPS.RadioManagement.Command.RemoveSelectedDevices();
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060000AC RID: 172 RVA: 0x0000AA34 File Offset: 0x00008C34
		public global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation ClearAllEIDHistory
		{
			get
			{
				short num = (short)1622376710;
				short num2 = num;
				num = (short)946897158;
				switch (num2 == num)
				{
				}
				num = (short)11468800;
				short num3 = num;
				num = (short)1381498881;
				if (num != 0)
				{
				}
				num = (short)158597120;
				if (num != 0)
				{
				}
				return new global::Motorola.CommonCPS.RadioManagement.Command.ClearAllCommand();
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060000AD RID: 173 RVA: 0x0000AAE4 File Offset: 0x00008CE4
		public global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation QueryEIDCommand
		{
			get
			{
				short num = (short)2020757830;
				short num2 = num;
				num = (short)366629190;
				switch (num2 == num)
				{
				}
				num = (short)1035665408;
				short num3 = num;
				num = (short)1261305857;
				if (num != 0)
				{
				}
				num = (short)162988032;
				if (num != 0)
				{
				}
				return new global::Motorola.CommonCPS.RadioManagement.Command.QueryEIDCommand();
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060000AE RID: 174 RVA: 0x0000AB94 File Offset: 0x00008D94
		public global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation RegisterRadioLicenseCommand
		{
			get
			{
				short num = (short)1820917761;
				if (num != 0)
				{
				}
				num = (short)2105098666;
				short num2 = num;
				num = (short)902381994;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1821573120;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)764674048;
				if (num != 0)
				{
				}
				return new global::Motorola.CommonCPS.RadioManagement.Command.SubmitLicenseAssignmentCommand();
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060000AF RID: 175 RVA: 0x0000AC44 File Offset: 0x00008E44
		public global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation SaveRadioLicenseCommand
		{
			get
			{
				short num = (short)439006790;
				short num2 = num;
				num = (short)1375516230;
				switch (num2 == num)
				{
				}
				num = (short)1761804288;
				short num3 = num;
				num = (short)1274150913;
				if (num != 0)
				{
				}
				num = (short)1674575872;
				if (num != 0)
				{
				}
				return new global::Motorola.CommonCPS.RadioManagement.Command.UpdateRadioFeatureCommand();
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060000B0 RID: 176 RVA: 0x0000ACF4 File Offset: 0x00008EF4
		public global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation FilterAvailableDevicesCommand
		{
			get
			{
				short num = (short)594434518;
				short num2 = num;
				num = (short)740710870;
				switch (num2 == num)
				{
				}
				num = (short)1671299072;
				short num3 = num;
				num = (short)1820524544;
				if (num != 0)
				{
				}
				num = (short)700579841;
				if (num != 0)
				{
				}
				return new global::Motorola.CommonCPS.RadioManagement.Command.FilterAvailableDevicesCommand();
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060000B1 RID: 177 RVA: 0x0000ADA0 File Offset: 0x00008FA0
		public global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation ApplyTemplatetoRelatedRadiosCommand
		{
			get
			{
				short num = (short)650638223;
				short num2 = num;
				num = (short)580645775;
				switch (num2 == num)
				{
				}
				num = (short)1979908096;
				short num3 = num;
				num = (short)349962241;
				if (num != 0)
				{
				}
				num = (short)926023680;
				if (num != 0)
				{
				}
				return new global::Motorola.CommonCPS.RadioManagement.Command.ApplyTemplatetoRelatedRadiosCommand();
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x060000B2 RID: 178 RVA: 0x0000AE4C File Offset: 0x0000904C
		public global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation PrepareRegisterRadioLicense
		{
			get
			{
				short num = (short)398015433;
				short num2 = num;
				num = (short)2045328329;
				switch (num2 == num)
				{
				}
				num = (short)1689190400;
				short num3 = num;
				num = (short)104726528;
				if (num != 0)
				{
				}
				num = (short)193265665;
				if (num != 0)
				{
				}
				return new global::Motorola.CommonCPS.RadioManagement.Command.PrepareRegisterRadioLicenseDialogCommand();
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x060000B3 RID: 179 RVA: 0x0000AEF8 File Offset: 0x000090F8
		public global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation RecoverApplicationLicensesCommand
		{
			get
			{
				short num = (short)1482553351;
				short num2 = num;
				num = (short)387381255;
				switch (num2 == num)
				{
				}
				num = (short)1510342656;
				short num3 = num;
				num = (short)1708326913;
				if (num != 0)
				{
				}
				num = (short)1160249344;
				if (num != 0)
				{
				}
				return new global::Motorola.CommonCPS.RadioManagement.Command.RecoverAppLicenseCommand();
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060000B4 RID: 180 RVA: 0x0000AFA8 File Offset: 0x000091A8
		public global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation RecoverRadioLicensesCommand
		{
			get
			{
				short num = (short)1976434689;
				if (num != 0)
				{
				}
				num = (short)577609462;
				short num2 = num;
				num = (short)1981718262;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1675362304;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)712376320;
				if (num != 0)
				{
				}
				return new global::Motorola.CommonCPS.RadioManagement.Command.RecoverRadioLicenseCommand();
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x060000B5 RID: 181 RVA: 0x0000B054 File Offset: 0x00009254
		public global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation RegistRadioFeatureGroupChangeCommand
		{
			get
			{
				short num = (short)894653091;
				short num2 = num;
				num = (short)1312903843;
				switch (num2 == num)
				{
				}
				num = (short)203685888;
				short num3 = num;
				num = (short)976224256;
				if (num != 0)
				{
				}
				num = (short)699334657;
				if (num != 0)
				{
				}
				return new global::Motorola.CommonCPS.RadioManagement.Command.RegistRadioFeatureGroupChangeCommand();
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x060000B6 RID: 182 RVA: 0x0000B108 File Offset: 0x00009308
		public global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation RestoreRadioLicenseCommand
		{
			get
			{
				short num = (short)1619271258;
				short num2 = num;
				num = (short)53812826;
				switch (num2 == num)
				{
				}
				num = (short)2075328512;
				short num3 = num;
				num = (short)21430272;
				if (num != 0)
				{
				}
				num = (short)1406599169;
				if (num != 0)
				{
				}
				return new global::Motorola.CommonCPS.RadioManagement.Command.RestoreRadioLicenseCommand();
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x060000B7 RID: 183 RVA: 0x0000B1BC File Offset: 0x000093BC
		public global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation PrepareRegisterApplicationLicenseCommand
		{
			get
			{
				short num = (short)1181815654;
				short num2 = num;
				num = (short)1662784358;
				switch (num2 == num)
				{
				}
				num = (short)551419904;
				short num3 = num;
				num = (short)911212545;
				if (num != 0)
				{
				}
				num = (short)545128448;
				if (num != 0)
				{
				}
				return new global::Motorola.CommonCPS.RadioManagement.Command.PrepareRegisterAppLicenseDialogCommand();
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x060000B8 RID: 184 RVA: 0x0000B26C File Offset: 0x0000946C
		public global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation RegisterApplicationLicenseCommand
		{
			get
			{
				short num = (short)583833963;
				short num2 = num;
				num = (short)241736043;
				switch (num2 == num)
				{
				}
				num = (short)1545338880;
				short num3 = num;
				num = (short)1585840129;
				if (num != 0)
				{
				}
				num = (short)2144731136;
				if (num != 0)
				{
				}
				return new global::Motorola.CommonCPS.RadioManagement.Command.SubmitAppLicenseCommand();
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x060000B9 RID: 185 RVA: 0x0000B318 File Offset: 0x00009518
		public global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation GetHostIDCommand
		{
			get
			{
				short num = (short)132700398;
				short num2 = num;
				num = (short)1623775470;
				switch (num2 == num)
				{
				}
				num = (short)103153664;
				short num3 = num;
				num = (short)922091521;
				if (num != 0)
				{
				}
				num = (short)1039269888;
				if (num != 0)
				{
				}
				return new global::Motorola.CommonCPS.RadioManagement.Command.GetHostIDFileCommand();
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x060000BA RID: 186 RVA: 0x0000B3C8 File Offset: 0x000095C8
		public global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation ChooseLicenseFileCommand
		{
			get
			{
				short num = (short)1046650442;
				short num2 = num;
				num = (short)694591050;
				switch (num2 == num)
				{
				}
				num = (short)600965120;
				short num3 = num;
				num = (short)1147994113;
				if (num != 0)
				{
				}
				num = (short)1787232256;
				if (num != 0)
				{
				}
				return new global::Motorola.CommonCPS.RadioManagement.Command.OpenLicenseFileCommand();
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x060000BB RID: 187 RVA: 0x0000B478 File Offset: 0x00009678
		public global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation QueryApplicationLicenseEIDCommand
		{
			get
			{
				short num = (short)1688618107;
				short num2 = num;
				num = (short)1791313019;
				switch (num2 == num)
				{
				}
				num = (short)240648192;
				short num3 = num;
				num = (short)383320065;
				if (num != 0)
				{
				}
				num = (short)1029832704;
				if (num != 0)
				{
				}
				return new global::Motorola.CommonCPS.RadioManagement.Command.QueryAppEIDCommand();
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x060000BC RID: 188 RVA: 0x0000B528 File Offset: 0x00009728
		public global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation SaveApplicationLicenseCommand
		{
			get
			{
				short num = (short)1458164314;
				short num2 = num;
				num = (short)2092421722;
				switch (num2 == num)
				{
				}
				num = (short)906756096;
				short num3 = num;
				num = (short)216596481;
				if (num != 0)
				{
				}
				num = (short)1062666240;
				if (num != 0)
				{
				}
				return new global::Motorola.CommonCPS.RadioManagement.Command.UpdateAppFeatureCommand();
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x060000BD RID: 189 RVA: 0x0000B5D4 File Offset: 0x000097D4
		public global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation SelectASKForCFSCommand
		{
			get
			{
				short num = (short)516075320;
				short num2 = num;
				num = (short)1570221880;
				switch (num2 == num)
				{
				}
				num = (short)878051328;
				short num3 = num;
				num = (short)428146689;
				if (num != 0)
				{
				}
				num = (short)1495728128;
				if (num != 0)
				{
				}
				return new global::Motorola.CommonCPS.RadioManagement.Command.SelectASKForCFSCommand();
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x060000BE RID: 190 RVA: 0x0000B684 File Offset: 0x00009884
		public virtual global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation SaveASTRODataProfileCommand
		{
			get
			{
				short num = (short)1619610308;
				short num2 = num;
				num = (short)1240681156;
				switch (num2 == num)
				{
				}
				num = (short)147718144;
				short num3 = num;
				num = (short)912719872;
				if (num != 0)
				{
				}
				num = (short)1047658497;
				if (num != 0)
				{
				}
				return new global::Motorola.CommonCPS.RadioManagement.Command.NullCommand();
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x060000BF RID: 191 RVA: 0x0000B734 File Offset: 0x00009934
		public global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation ExportDataProfileGridToFileCommand
		{
			get
			{
				short num = (short)1173463585;
				short num2 = num;
				num = (short)1673437729;
				switch (num2 == num)
				{
				}
				num = (short)339935232;
				short num3 = num;
				num = (short)860749825;
				if (num != 0)
				{
				}
				num = (short)945684480;
				if (num != 0)
				{
				}
				return new global::Motorola.CommonCPS.RadioManagement.Command.ExportDataProfileToFileCommand();
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x060000C0 RID: 192 RVA: 0x0000B7E4 File Offset: 0x000099E4
		public virtual global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation SaveASTROOTARProfileCommand
		{
			get
			{
				short num = (short)1791148081;
				short num2 = num;
				num = (short)1425457;
				switch (num2 == num)
				{
				}
				num = (short)1632894976;
				short num3 = num;
				num = (short)887488513;
				if (num != 0)
				{
				}
				num = (short)88080384;
				if (num != 0)
				{
				}
				return new global::Motorola.CommonCPS.RadioManagement.Command.NullCommand();
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x060000C1 RID: 193 RVA: 0x0000B894 File Offset: 0x00009A94
		public global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation ExportOtarProfileGridToFileCommand
		{
			get
			{
				short num = (short)924733217;
				short num2 = num;
				num = (short)1082478369;
				switch (num2 == num)
				{
				}
				num = (short)931921920;
				short num3 = num;
				num = (short)1433665537;
				if (num != 0)
				{
				}
				num = (short)1220804608;
				if (num != 0)
				{
				}
				return new global::Motorola.CommonCPS.RadioManagement.ASTROOTARProfile.ExportOtarProfileToFileCommand();
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x060000C2 RID: 194 RVA: 0x0000B944 File Offset: 0x00009B44
		public virtual global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation SaveASTROSystemCommand
		{
			get
			{
				short num = (short)1254573447;
				short num2 = num;
				num = (short)1802716551;
				switch (num2 == num)
				{
				}
				num = (short)1298661376;
				short num3 = num;
				num = (short)1560870912;
				if (num != 0)
				{
				}
				num = (short)920780801;
				if (num != 0)
				{
				}
				return new global::Motorola.CommonCPS.RadioManagement.Command.NullCommand();
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x060000C3 RID: 195 RVA: 0x0000B9F4 File Offset: 0x00009BF4
		public global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation ExportASTROSystemGridToFileCommand
		{
			get
			{
				short num = (short)1127214998;
				short num2 = num;
				num = (short)1067642774;
				switch (num2 == num)
				{
				}
				num = (short)11534336;
				short num3 = num;
				num = (short)1933377536;
				if (num != 0)
				{
				}
				num = (short)632422401;
				if (num != 0)
				{
				}
				return new global::Motorola.CommonCPS.RadioManagement.Command.ExportASTROSystemToFileCommand();
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x060000C4 RID: 196 RVA: 0x0000BAA0 File Offset: 0x00009CA0
		public global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation DeleteJobContainerCommand
		{
			get
			{
				short num = (short)44304507;
				short num2 = num;
				num = (short)1567819899;
				switch (num2 == num)
				{
				}
				num = (short)2004418560;
				short num3 = num;
				num = (short)967966720;
				if (num != 0)
				{
				}
				num = (short)451674113;
				if (num != 0)
				{
				}
				return new global::Motorola.CommonCPS.RadioManagement.Command.DeleteJobContainerCommand();
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x060000C5 RID: 197 RVA: 0x0000BB50 File Offset: 0x00009D50
		public global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation ViewProgressesCommand
		{
			get
			{
				short num = (short)517494915;
				short num2 = num;
				num = (short)1125996675;
				switch (num2 == num)
				{
				}
				num = (short)2133786624;
				short num3 = num;
				num = (short)2132017152;
				if (num != 0)
				{
				}
				num = (short)582615041;
				if (num != 0)
				{
				}
				return new global::Motorola.CommonCPS.RadioManagement.Command.ShowBatchOpManagerCommand();
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x060000C6 RID: 198 RVA: 0x0000BBFC File Offset: 0x00009DFC
		public global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation ClearBatchOpCommand
		{
			get
			{
				short num = (short)457886319;
				short num2 = num;
				num = (short)227592815;
				switch (num2 == num)
				{
				}
				num = (short)1416888320;
				short num3 = num;
				num = (short)570032129;
				if (num != 0)
				{
				}
				num = (short)1749352448;
				if (num != 0)
				{
				}
				return new global::Motorola.CommonCPS.RadioManagement.Command.ClearBatchOpCommand();
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x060000C7 RID: 199 RVA: 0x0000BCAC File Offset: 0x00009EAC
		public global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation CancelBatchOpCommand
		{
			get
			{
				short num = (short)2141367805;
				short num2 = num;
				num = (short)188591613;
				switch (num2 == num)
				{
				}
				num = (short)947781632;
				short num3 = num;
				num = (short)1810563073;
				if (num != 0)
				{
				}
				num = (short)1032716288;
				if (num != 0)
				{
				}
				return new global::Motorola.CommonCPS.RadioManagement.Command.CancelBatchOpCommand();
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x060000C8 RID: 200 RVA: 0x0000BD58 File Offset: 0x00009F58
		public global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation GetBatchOpCommand
		{
			get
			{
				short num = (short)1474166785;
				if (num != 0)
				{
				}
				num = (short)2006399842;
				short num2 = num;
				num = (short)693779298;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2140733440;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)251789312;
				if (num != 0)
				{
				}
				return new global::Motorola.CommonCPS.RadioManagement.Command.GetBatchOpCommand();
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x060000C9 RID: 201 RVA: 0x0000BE08 File Offset: 0x0000A008
		public global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation CancelDBMigrationBacthOpCommand
		{
			get
			{
				short num = (short)1506427701;
				short num2 = num;
				num = (short)1513505589;
				switch (num2 == num)
				{
				}
				num = (short)1303511040;
				short num3 = num;
				num = (short)1839136768;
				if (num != 0)
				{
				}
				num = (short)740818945;
				if (num != 0)
				{
				}
				return new global::Motorola.CommonCPS.RadioManagement.Command.CancelDBMigrationBacthOpCommand();
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x060000CA RID: 202 RVA: 0x0000BEB8 File Offset: 0x0000A0B8
		public global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation ChangeRMAppLanguageCommand
		{
			get
			{
				short num = (short)1521492017;
				short num2 = num;
				num = (short)587472945;
				switch (num2 == num)
				{
				}
				num = (short)258670592;
				short num3 = num;
				num = (short)94961665;
				if (num != 0)
				{
				}
				num = (short)2024538112;
				if (num != 0)
				{
				}
				return new global::Motorola.CommonCPS.RadioManagement.Command.ChangeRMAppLanguageCommand();
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x060000CB RID: 203 RVA: 0x0000BF68 File Offset: 0x0000A168
		public global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation ChangeRMAppButtonBarModeCommand
		{
			get
			{
				short num = (short)2086856263;
				short num2 = num;
				num = (short)594208327;
				switch (num2 == num)
				{
				}
				num = (short)803274752;
				short num3 = num;
				num = (short)1633222657;
				if (num != 0)
				{
				}
				num = (short)1285947392;
				if (num != 0)
				{
				}
				return new global::Motorola.CommonCPS.RadioManagement.Command.ChangeRMAppButtonBarModeCommand();
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x060000CC RID: 204 RVA: 0x0000C018 File Offset: 0x0000A218
		public virtual global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation SaveSettingsCommand
		{
			get
			{
				short num = (short)1764821930;
				short num2 = num;
				num = (short)1572670378;
				switch (num2 == num)
				{
				}
				num = (short)833093632;
				short num3 = num;
				num = (short)1774977025;
				if (num != 0)
				{
				}
				num = (short)493682688;
				if (num != 0)
				{
				}
				return new global::Motorola.CommonCPS.RadioManagement.Command.SaveSettingsCommand();
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x060000CD RID: 205 RVA: 0x0000C0C4 File Offset: 0x0000A2C4
		public virtual global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation SaveDealerInfoCommand
		{
			get
			{
				short num = (short)1335558145;
				if (num != 0)
				{
				}
				num = (short)1031997933;
				short num2 = num;
				num = (short)922618349;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2029191168;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1145569280;
				if (num != 0)
				{
				}
				return new global::Motorola.CommonCPS.RadioManagement.Command.SaveDealerInfoCommand();
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x060000CE RID: 206 RVA: 0x0000C178 File Offset: 0x0000A378
		public virtual global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation ChangeRMUserPasswordCommand
		{
			get
			{
				short num = (short)883448168;
				short num2 = num;
				num = (short)1015437672;
				switch (num2 == num)
				{
				}
				num = (short)943194112;
				short num3 = num;
				num = (short)607518721;
				if (num != 0)
				{
				}
				num = (short)1823932416;
				if (num != 0)
				{
				}
				return new global::Motorola.CommonCPS.RadioManagement.Command.ChangeRMUserPasswordCommand();
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x060000CF RID: 207 RVA: 0x0000C228 File Offset: 0x0000A428
		public virtual global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation SaveSettingsForImportFromConsoleCommand
		{
			get
			{
				short num = (short)496369665;
				if (num != 0)
				{
				}
				num = (short)2024547810;
				short num2 = num;
				num = (short)2042111458;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1338834944;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1031995392;
				if (num != 0)
				{
				}
				return new global::Motorola.CommonCPS.RadioManagement.Command.NullCommand();
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x060000D0 RID: 208 RVA: 0x0000C2D8 File Offset: 0x0000A4D8
		public global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation ShowSettingsDialogCommand
		{
			get
			{
				short num = (short)896516515;
				short num2 = num;
				num = (short)1716109731;
				switch (num2 == num)
				{
				}
				num = (short)1726349312;
				short num3 = num;
				num = (short)1522270208;
				if (num != 0)
				{
				}
				num = (short)442695681;
				if (num != 0)
				{
				}
				return new global::Motorola.CommonCPS.RadioManagement.Command.ShowSettingCommand();
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x060000D1 RID: 209 RVA: 0x0000C388 File Offset: 0x0000A588
		public global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation ShowRadioConversionDialogCommand
		{
			get
			{
				short num = (short)1211036749;
				short num2 = num;
				num = (short)191231053;
				switch (num2 == num)
				{
				}
				num = (short)421527552;
				short num3 = num;
				num = (short)1282080769;
				if (num != 0)
				{
				}
				num = (short)1003880448;
				if (num != 0)
				{
				}
				return new global::Motorola.CommonCPS.RadioManagement.Command.ShowRadioConversionDialogCommand();
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x060000D2 RID: 210 RVA: 0x0000C438 File Offset: 0x0000A638
		public global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation ShowTemplateConversionDialogCommand
		{
			get
			{
				short num = (short)1865953645;
				short num2 = num;
				num = (short)179122541;
				switch (num2 == num)
				{
				}
				num = (short)1367474176;
				short num3 = num;
				num = (short)1711472641;
				if (num != 0)
				{
				}
				num = (short)2041315328;
				if (num != 0)
				{
				}
				return new global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateConversionDialogCommand();
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x060000D3 RID: 211 RVA: 0x0000C4E4 File Offset: 0x0000A6E4
		public virtual global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation ShowSettingsDialogForImportFromConsoleCommand
		{
			get
			{
				short num = (short)1190073127;
				short num2 = num;
				num = (short)1622545191;
				switch (num2 == num)
				{
				}
				num = (short)1231355904;
				short num3 = num;
				num = (short)398196737;
				if (num != 0)
				{
				}
				num = (short)416677888;
				if (num != 0)
				{
				}
				return new global::Motorola.CommonCPS.RadioManagement.Command.NullCommand();
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x060000D4 RID: 212 RVA: 0x0000C594 File Offset: 0x0000A794
		public global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation GetDatabaseSizeSummaryCommand
		{
			get
			{
				short num = (short)1545988038;
				short num2 = num;
				num = (short)240052166;
				switch (num2 == num)
				{
				}
				num = (short)996671488;
				short num3 = num;
				num = (short)395378688;
				if (num != 0)
				{
				}
				num = (short)655818753;
				if (num != 0)
				{
				}
				return new global::Motorola.CommonCPS.RadioManagement.Command.GetDatabaseSizeSummaryCommand();
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x060000D5 RID: 213 RVA: 0x0000C644 File Offset: 0x0000A844
		public virtual global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation SaveHiddenMessageCommand
		{
			get
			{
				short num = (short)1964310528;
				short num2 = num;
				num = (short)2006384641;
				if (num != 0)
				{
				}
				num = (short)1033176141;
				short num3 = num;
				num = (short)1994720333;
				switch (num3 == num)
				{
				}
				num = (short)1058078720;
				if (num != 0)
				{
				}
				return new global::Motorola.CommonCPS.RadioManagement.Command.SaveHiddenMessageCommand();
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x060000D6 RID: 214 RVA: 0x0000C6F0 File Offset: 0x0000A8F0
		public virtual global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation UpdateLogSettingCommand
		{
			get
			{
				short num = (short)896204800;
				short num2 = num;
				num = (short)1786383530;
				short num3 = num;
				num = (short)1104481450;
				switch (num3 == num)
				{
				}
				num = (short)1645150209;
				if (num != 0)
				{
				}
				num = (short)1023213568;
				if (num != 0)
				{
				}
				return new global::Motorola.CommonCPS.RadioManagement.Command.UpdateLogSettingCommand();
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x060000D7 RID: 215 RVA: 0x0000C7A0 File Offset: 0x0000A9A0
		public global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation FilterCommand
		{
			get
			{
				short num = (short)393674752;
				short num2 = num;
				num = (short)466234274;
				short num3 = num;
				num = (short)167586722;
				switch (num3 == num)
				{
				}
				num = (short)1666514945;
				if (num != 0)
				{
				}
				num = (short)61800448;
				if (num != 0)
				{
				}
				return new global::Motorola.CommonCPS.RadioManagement.Command.FilterCommand();
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x060000D8 RID: 216 RVA: 0x0000C84C File Offset: 0x0000AA4C
		public global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation StopLoadingCommand
		{
			get
			{
				short num = (short)1287716864;
				short num2 = num;
				num = (short)688717825;
				if (num != 0)
				{
				}
				num = (short)827767823;
				short num3 = num;
				num = (short)505986063;
				switch (num3 == num)
				{
				}
				num = (short)1777664000;
				if (num != 0)
				{
				}
				return new global::Motorola.CommonCPS.RadioManagement.Command.StopLoadingCommand();
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x060000D9 RID: 217 RVA: 0x0000C8FC File Offset: 0x0000AAFC
		public global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation PrintViewCommand
		{
			get
			{
				short num = (short)1916338176;
				short num2 = num;
				num = (short)2084235045;
				short num3 = num;
				num = (short)1811670821;
				switch (num3 == num)
				{
				}
				num = (short)2100297729;
				if (num != 0)
				{
				}
				num = (short)1458372608;
				if (num != 0)
				{
				}
				return new global::Motorola.CommonCPS.RadioManagement.Command.PrintViewCommand();
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x060000DA RID: 218 RVA: 0x0000C9A8 File Offset: 0x0000ABA8
		public global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation PrintPreviewCommand
		{
			get
			{
				short num = (short)1049100288;
				short num2 = num;
				num = (short)987154289;
				short num3 = num;
				num = (short)213632881;
				switch (num3 == num)
				{
				}
				num = (short)1103298560;
				if (num != 0)
				{
				}
				num = (short)1133248513;
				if (num != 0)
				{
				}
				return new global::Motorola.CommonCPS.RadioManagement.Command.PrintPreviewCommand();
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x060000DB RID: 219 RVA: 0x0000CA58 File Offset: 0x0000AC58
		public global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation ShowAboutDialogCommand
		{
			get
			{
				short num = (short)1242693632;
				short num2 = num;
				num = (short)1553858561;
				if (num != 0)
				{
				}
				num = (short)901374336;
				short num3 = num;
				num = (short)218227072;
				switch (num3 == num)
				{
				}
				num = (short)1205075968;
				if (num != 0)
				{
				}
				return new global::Motorola.CommonCPS.RadioManagement.Command.AboutCommand();
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x060000DC RID: 220 RVA: 0x0000CB0C File Offset: 0x0000AD0C
		public global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation MigrateRadioAndCommonResourceCommand
		{
			get
			{
				short num = (short)40370176;
				short num2 = num;
				num = (short)1698168833;
				if (num != 0)
				{
				}
				num = (short)736363726;
				short num3 = num;
				num = (short)702219470;
				switch (num3 == num)
				{
				}
				num = (short)4259840;
				if (num != 0)
				{
				}
				return new global::Motorola.CommonCPS.RadioManagement.Command.MigrateRadioAndCommonResourceCommand();
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x060000DD RID: 221 RVA: 0x0000CBB8 File Offset: 0x0000ADB8
		public global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation QueryMigrationStatusCommand
		{
			get
			{
				short num = (short)1901068288;
				short num2 = num;
				num = (short)567956888;
				short num3 = num;
				num = (short)691164568;
				switch (num3 == num)
				{
				}
				num = (short)115933185;
				if (num != 0)
				{
				}
				num = (short)1391788032;
				if (num != 0)
				{
				}
				return new global::Motorola.CommonCPS.RadioManagement.Command.QueryMigrationStatusCommand();
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x060000DE RID: 222 RVA: 0x0000CC68 File Offset: 0x0000AE68
		public global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation MigrateTemplateCommand
		{
			get
			{
				short num = (short)555679744;
				short num2 = num;
				num = (short)1000297097;
				short num3 = num;
				num = (short)1708282505;
				switch (num3 == num)
				{
				}
				num = (short)1225785344;
				if (num != 0)
				{
				}
				num = (short)265093121;
				if (num != 0)
				{
				}
				return new global::Motorola.CommonCPS.RadioManagement.Command.MigrateTemplateCommand();
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x060000DF RID: 223 RVA: 0x0000CD18 File Offset: 0x0000AF18
		public global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation ConvertRadioInBatchCommand
		{
			get
			{
				short num = (short)1451294720;
				short num2 = num;
				num = (short)119913577;
				short num3 = num;
				num = (short)1386658921;
				switch (num3 == num)
				{
				}
				num = (short)864092161;
				if (num != 0)
				{
				}
				num = (short)1906769920;
				if (num != 0)
				{
				}
				return this.InstanceResolver.Resolve<global::Motorola.CommonCPS.RadioManagement.Command.ConvertRadioInBackgroundCommand>();
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x060000E0 RID: 224 RVA: 0x0000CDCC File Offset: 0x0000AFCC
		public global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation ChangeShowDialogCommand
		{
			get
			{
				short num = (short)243793920;
				short num2 = num;
				num = (short)529290160;
				short num3 = num;
				num = (short)241718192;
				switch (num3 == num)
				{
				}
				num = (short)1092288513;
				if (num != 0)
				{
				}
				num = (short)2063925248;
				if (num != 0)
				{
				}
				return new global::Motorola.CommonCPS.RadioManagement.Command.ChangeShowDialogCommand();
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x060000E1 RID: 225 RVA: 0x0000CE7C File Offset: 0x0000B07C
		public global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation ShowUpdateLogSettingWindowCommand
		{
			get
			{
				short num = (short)130678784;
				short num2 = num;
				num = (short)182995300;
				short num3 = num;
				num = (short)963594596;
				switch (num3 == num)
				{
				}
				num = (short)851902464;
				if (num != 0)
				{
				}
				num = (short)578813953;
				if (num != 0)
				{
				}
				return new global::Motorola.CommonCPS.RadioManagement.Command.ShowUpdateLogSettingWindowCommand();
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x060000E2 RID: 226 RVA: 0x0000CF2C File Offset: 0x0000B12C
		public global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation SelectAgencyCommand
		{
			get
			{
				short num = (short)1978335232;
				short num2 = num;
				num = (short)290033960;
				short num3 = num;
				num = (short)1226936616;
				switch (num3 == num)
				{
				}
				num = (short)1115226113;
				if (num != 0)
				{
				}
				num = (short)1155268608;
				if (num != 0)
				{
				}
				return new global::Motorola.CommonCPS.RadioManagement.Command.SelectAgencyCommand();
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x060000E3 RID: 227
		public abstract global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation UploadCodeplugCommand { get; }

		// Token: 0x0400001D RID: 29
		protected readonly global::Motorola.CommonCPS.RadioManagement.CommandHandlerDIModule.IInstanceResolver InstanceResolver;
	}
}
