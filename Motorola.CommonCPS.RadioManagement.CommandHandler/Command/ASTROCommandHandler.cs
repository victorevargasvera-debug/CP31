using System;
using Motorola.CommonCPS.RadioManagement.CommandHandlerDIModule;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x02000019 RID: 25
	public class ASTROCommandHandler : global::Motorola.CommonCPS.RadioManagement.Command.CommandHandler
	{
		// Token: 0x06000164 RID: 356 RVA: 0x0000CFDC File Offset: 0x0000B1DC
		public ASTROCommandHandler() : base(global::Motorola.CommonCPS.RadioManagement.CommandHandlerDIModule.InstanceResolver.GetInstance)
		{
		}

		// Token: 0x06000165 RID: 357 RVA: 0x0000CFF4 File Offset: 0x0000B1F4
		public ASTROCommandHandler(global::Motorola.CommonCPS.RadioManagement.CommandHandlerDIModule.IInstanceResolver instanceResolver) : base(instanceResolver)
		{
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x06000166 RID: 358 RVA: 0x0000D008 File Offset: 0x0000B208
		public override global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation AddRadioCommand
		{
			get
			{
				short num = (short)1158545408;
				short num2 = num;
				num = (short)2124034533;
				short num3 = num;
				num = (short)1454322149;
				switch (num3 == num)
				{
				}
				num = (short)1164509185;
				if (num != 0)
				{
				}
				num = (short)1385562112;
				if (num != 0)
				{
				}
				return new global::Motorola.CommonCPS.RadioManagement.Command.ASTROAddDeviceCommand();
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x06000167 RID: 359 RVA: 0x0000D0B4 File Offset: 0x0000B2B4
		public override global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation PrepareAddRadioCommand
		{
			get
			{
				short num = (short)1136852992;
				short num2 = num;
				num = (short)2089814974;
				short num3 = num;
				num = (short)1292176318;
				switch (num3 == num)
				{
				}
				num = (short)1772552193;
				if (num != 0)
				{
				}
				num = (short)1990918144;
				if (num != 0)
				{
				}
				return new global::Motorola.CommonCPS.RadioManagement.Command.AstroPrepareAddRadioCommand();
			}
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x06000168 RID: 360 RVA: 0x0000D160 File Offset: 0x0000B360
		public override global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation PrepareScheduleJobCommand
		{
			get
			{
				short num = (short)783745024;
				short num2 = num;
				num = (short)118030337;
				if (num != 0)
				{
				}
				num = (short)425087508;
				short num3 = num;
				num = (short)1042240020;
				switch (num3 == num)
				{
				}
				num = (short)2013462528;
				if (num != 0)
				{
				}
				return new global::Motorola.CommonCPS.RadioManagement.Command.ASTROPrepareScheduleJobCommand();
			}
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x06000169 RID: 361 RVA: 0x0000D210 File Offset: 0x0000B410
		public override global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation ScheduleJobCommand
		{
			get
			{
				short num = (short)320536576;
				short num2 = num;
				num = (short)938388939;
				short num3 = num;
				num = (short)1129950667;
				switch (num3 == num)
				{
				}
				num = (short)295632897;
				if (num != 0)
				{
				}
				num = (short)296353792;
				if (num != 0)
				{
				}
				return new global::Motorola.CommonCPS.RadioManagement.Command.ASTROScheduleJobCommand();
			}
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x0600016A RID: 362 RVA: 0x0000D2BC File Offset: 0x0000B4BC
		public override global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation SelectWarningRadiostoScheduleJobCommand
		{
			get
			{
				short num = (short)1715404800;
				short num2 = num;
				num = (short)221512018;
				short num3 = num;
				num = (short)1969094994;
				switch (num3 == num)
				{
				}
				num = (short)1409351680;
				if (num != 0)
				{
				}
				num = (short)1318977537;
				if (num != 0)
				{
				}
				return new global::Motorola.CommonCPS.RadioManagement.Command.ASTROSelectWarningRadiostoScheduleJobCommand();
			}
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x0600016B RID: 363 RVA: 0x0000D36C File Offset: 0x0000B56C
		public override global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation SelectFirmwareForUpgradeCommand
		{
			get
			{
				short num = (short)2752512;
				short num2 = num;
				num = (short)285278209;
				if (num != 0)
				{
				}
				num = (short)783296799;
				short num3 = num;
				num = (short)1261185311;
				switch (num3 == num)
				{
				}
				num = (short)2120220672;
				if (num != 0)
				{
				}
				return new global::Motorola.CommonCPS.RadioManagement.Command.AstroUpgradeCommand();
			}
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x0600016C RID: 364 RVA: 0x0000D41C File Offset: 0x0000B61C
		public override global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation PrepareUpgradeFirmwareCommand
		{
			get
			{
				short num = (short)2041970688;
				short num2 = num;
				num = (short)798002636;
				short num3 = num;
				num = (short)801213900;
				switch (num3 == num)
				{
				}
				num = (short)53936129;
				if (num != 0)
				{
				}
				num = (short)720764928;
				if (num != 0)
				{
				}
				return new global::Motorola.CommonCPS.RadioManagement.Command.AstroPrepareUpgradeFirmwareCommand();
			}
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x0600016D RID: 365 RVA: 0x0000D4C8 File Offset: 0x0000B6C8
		public override global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation RestoreCommand
		{
			get
			{
				short num = (short)777388032;
				short num2 = num;
				num = (short)1576778916;
				short num3 = num;
				num = (short)644136100;
				switch (num3 == num)
				{
				}
				num = (short)1111752705;
				if (num != 0)
				{
				}
				num = (short)259194880;
				if (num != 0)
				{
				}
				return new global::Motorola.CommonCPS.RadioManagement.Command.ASTRORestore_PrepareScheduleJobCommand();
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x0600016E RID: 366 RVA: 0x0000D578 File Offset: 0x0000B778
		public override global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation ASTROUpgradeLanguagePackCommand
		{
			get
			{
				short num = (short)703463424;
				short num2 = num;
				num = (short)675503040;
				short num3 = num;
				num = (short)605117376;
				switch (num3 == num)
				{
				}
				num = (short)1335623681;
				if (num != 0)
				{
				}
				num = (short)649265152;
				if (num != 0)
				{
				}
				return new global::Motorola.CommonCPS.RadioManagement.Command.AstroUpgradeLanguagePackCommand();
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x0600016F RID: 367 RVA: 0x0000D628 File Offset: 0x0000B828
		public override global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation PrepareImportTemplatesCommand
		{
			get
			{
				short num = (short)1901789184;
				short num2 = num;
				num = (short)207224833;
				if (num != 0)
				{
				}
				num = (short)1622880882;
				short num3 = num;
				num = (short)981807730;
				switch (num3 == num)
				{
				}
				num = (short)955842560;
				if (num != 0)
				{
				}
				return new global::Motorola.CommonCPS.RadioManagement.Command.ASTROPrepareImportTemplateCommand();
			}
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x06000170 RID: 368 RVA: 0x0000D6D8 File Offset: 0x0000B8D8
		public override global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation PrepareImportPackagesCommand
		{
			get
			{
				short num = (short)567279616;
				short num2 = num;
				num = (short)361576466;
				short num3 = num;
				num = (short)204093458;
				switch (num3 == num)
				{
				}
				num = (short)1449984001;
				if (num != 0)
				{
				}
				num = (short)637468672;
				if (num != 0)
				{
				}
				return new global::Motorola.CommonCPS.RadioManagement.Command.ASTROPrepareImportPackagesCommand();
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x06000171 RID: 369 RVA: 0x0000D784 File Offset: 0x0000B984
		public override global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation SaveASTRODataProfileCommand
		{
			get
			{
				short num = (short)781320192;
				short num2 = num;
				num = (short)935790524;
				short num3 = num;
				num = (short)1520371644;
				switch (num3 == num)
				{
				}
				num = (short)378273793;
				if (num != 0)
				{
				}
				num = (short)591134720;
				if (num != 0)
				{
				}
				return new global::Motorola.CommonCPS.RadioManagement.Command.EditAstroDataProfileCommand();
			}
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x06000172 RID: 370 RVA: 0x0000D834 File Offset: 0x0000BA34
		public override global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation SaveASTROSystemCommand
		{
			get
			{
				short num = (short)414056448;
				short num2 = num;
				num = (short)1535807358;
				short num3 = num;
				num = (short)1028231038;
				switch (num3 == num)
				{
				}
				num = (short)8585217;
				if (num != 0)
				{
				}
				num = (short)1434189824;
				if (num != 0)
				{
				}
				return new global::Motorola.CommonCPS.RadioManagement.Command.EditAstroSystemCommand();
			}
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x06000173 RID: 371 RVA: 0x0000D8E4 File Offset: 0x0000BAE4
		public override global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation SaveASTROOTARProfileCommand
		{
			get
			{
				short num = (short)394854400;
				short num2 = num;
				num = (short)1346469765;
				short num3 = num;
				num = (short)1867808645;
				switch (num3 == num)
				{
				}
				num = (short)1958477824;
				if (num != 0)
				{
				}
				num = (short)1782185985;
				if (num != 0)
				{
				}
				return new global::Motorola.CommonCPS.RadioManagement.Command.EditASTROOTARProfileCommand();
			}
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x06000174 RID: 372 RVA: 0x0000D998 File Offset: 0x0000BB98
		public override global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation PrepareModifyCodeplugPasswordCommand
		{
			get
			{
				short num = (short)1746272256;
				short num2 = num;
				num = (short)924874856;
				short num3 = num;
				num = (short)799373416;
				switch (num3 == num)
				{
				}
				num = (short)1144586241;
				if (num != 0)
				{
				}
				num = (short)1776812032;
				if (num != 0)
				{
				}
				return new global::Motorola.CommonCPS.RadioManagement.Command.ASTROPrepareModifyCodeplugPasswordCommand();
			}
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x06000175 RID: 373 RVA: 0x0000DA44 File Offset: 0x0000BC44
		public override global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation ModifyCodeplugPasswordCommand
		{
			get
			{
				short num = (short)1401159680;
				short num2 = num;
				num = (short)1692566231;
				short num3 = num;
				num = (short)747733719;
				switch (num3 == num)
				{
				}
				num = (short)1964113921;
				if (num != 0)
				{
				}
				num = (short)1820917760;
				if (num != 0)
				{
				}
				return new global::Motorola.CommonCPS.RadioManagement.Command.ASTROModifyCodeplugPasswordCommand();
			}
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x06000176 RID: 374 RVA: 0x0000DAF4 File Offset: 0x0000BCF4
		public override global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation PrepareResetRadioPasswordCommand
		{
			get
			{
				short num = (short)208601088;
				short num2 = num;
				num = (short)2129264641;
				if (num != 0)
				{
				}
				num = (short)1081531917;
				short num3 = num;
				num = (short)1247796749;
				switch (num3 == num)
				{
				}
				num = (short)2107637760;
				if (num != 0)
				{
				}
				return new global::Motorola.CommonCPS.RadioManagement.Command.PrepareResetRadioPasswordCommand();
			}
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x06000177 RID: 375 RVA: 0x0000DBA4 File Offset: 0x0000BDA4
		public override global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation ResetRadioPasswordCommand
		{
			get
			{
				short num = (short)2093154304;
				short num2 = num;
				num = (short)826375627;
				short num3 = num;
				num = (short)238058955;
				switch (num3 == num)
				{
				}
				num = (short)629080065;
				if (num != 0)
				{
				}
				num = (short)1725562880;
				if (num != 0)
				{
				}
				return new global::Motorola.CommonCPS.RadioManagement.Command.ResetRadioPasswordCommand();
			}
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x06000178 RID: 376 RVA: 0x0000DC54 File Offset: 0x0000BE54
		public override global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation ExportDVRS_Command
		{
			get
			{
				short num = (short)845807616;
				short num2 = num;
				num = (short)538443777;
				if (num != 0)
				{
				}
				num = (short)1486370716;
				short num3 = num;
				num = (short)1378563996;
				switch (num3 == num)
				{
				}
				num = (short)1441071104;
				if (num != 0)
				{
				}
				return new global::Motorola.CommonCPS.RadioManagement.Command.ExportDVRS_Command();
			}
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x06000179 RID: 377 RVA: 0x0000DD04 File Offset: 0x0000BF04
		public override global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation AstroPrepareFlashPortCommand
		{
			get
			{
				short num = (short)266207232;
				short num2 = num;
				num = (short)1218230875;
				short num3 = num;
				num = (short)1420278363;
				switch (num3 == num)
				{
				}
				num = (short)2021982209;
				if (num != 0)
				{
				}
				num = (short)748355584;
				if (num != 0)
				{
				}
				return new global::Motorola.CommonCPS.RadioManagement.Command.AstroPrepareFlashPortCommand();
			}
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x0600017A RID: 378 RVA: 0x0000DDB4 File Offset: 0x0000BFB4
		public override global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation UploadCodeplugCommand
		{
			get
			{
				short num = (short)202571776;
				short num2 = num;
				num = (short)936902657;
				if (num != 0)
				{
				}
				num = (short)1977793508;
				short num3 = num;
				num = (short)2020654052;
				switch (num3 == num)
				{
				}
				num = (short)1386938368;
				if (num != 0)
				{
				}
				return new global::Motorola.CommonCPS.RadioManagement.Command.AstroUploadCodeplugCommand();
			}
		}
	}
}
