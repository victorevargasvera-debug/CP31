using System;
using Microsoft.Practices.Prism.Commands;
using Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Infrastructure
{
	// Token: 0x02000036 RID: 54
	public class CommandProxy
	{
		// Token: 0x060000D9 RID: 217 RVA: 0x0000E79C File Offset: 0x0000C99C
		private CommandProxy()
		{
		}

		// Token: 0x060000DA RID: 218 RVA: 0x0000EA70 File Offset: 0x0000CC70
		public static global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxy GetInstance()
		{
			short num = (short)1149083355;
			short num2 = num;
			num = (short)1329307355;
			switch (num2 == num)
			{
			}
			num = (short)1916862464;
			if (num != 0)
			{
			}
			num = (short)394002433;
			if (num != 0)
			{
			}
			num = (short)1879703552;
			short num3 = num;
			global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxy result;
			if ((result = global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxy.a) == null)
			{
				result = (global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxy.a = new global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxy());
			}
			return result;
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x060000DB RID: 219 RVA: 0x0000EB34 File Offset: 0x0000CD34
		// (set) Token: 0x060000DC RID: 220 RVA: 0x0000EBEC File Offset: 0x0000CDEC
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand AddGroupCommand
		{
			get
			{
				short num = (short)714242988;
				short num2 = num;
				num = (short)1384217516;
				switch (num2 == num)
				{
				}
				num = (short)832176128;
				if (num != 0)
				{
				}
				num = (short)1751318529;
				if (num != 0)
				{
				}
				num = (short)1241251840;
				short num3 = num;
				return this.b.a();
			}
			set
			{
				short num = (short)1531875438;
				short num2 = num;
				num = (short)1939378286;
				switch (num2 == num)
				{
				}
				num = (short)1074724865;
				if (num != 0)
				{
				}
				num = (short)1810366464;
				if (num != 0)
				{
				}
				num = (short)1685651456;
				short num3 = num;
				this.b.e(value);
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x060000DD RID: 221 RVA: 0x0000ECA0 File Offset: 0x0000CEA0
		// (set) Token: 0x060000DE RID: 222 RVA: 0x0000ED54 File Offset: 0x0000CF54
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand AddSetCommand
		{
			get
			{
				short num = (short)1845162823;
				short num2 = num;
				num = (short)1854927687;
				switch (num2 == num)
				{
				}
				num = (short)986578944;
				if (num != 0)
				{
				}
				num = (short)290979841;
				if (num != 0)
				{
				}
				num = (short)1290862592;
				short num3 = num;
				return this.c.a();
			}
			set
			{
				short num = (short)2134441985;
				if (num != 0)
				{
				}
				num = (short)800243854;
				short num2 = num;
				num = (short)1073266830;
				switch (num2 == num)
				{
				}
				num = (short)315752448;
				if (num != 0)
				{
				}
				num = (short)841416704;
				short num3 = num;
				this.c.e(value);
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x060000DF RID: 223 RVA: 0x0000EE0C File Offset: 0x0000D00C
		// (set) Token: 0x060000E0 RID: 224 RVA: 0x0000EEC0 File Offset: 0x0000D0C0
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand CancelJobCommand
		{
			get
			{
				short num = (short)47866528;
				short num2 = num;
				num = (short)1348887200;
				switch (num2 == num)
				{
				}
				num = (short)1595736064;
				if (num != 0)
				{
				}
				num = (short)2060189697;
				if (num != 0)
				{
				}
				num = (short)311427072;
				short num3 = num;
				return this.d.a();
			}
			set
			{
				short num = (short)359123588;
				short num2 = num;
				num = (short)1146079876;
				switch (num2 == num)
				{
				}
				num = (short)1221066753;
				if (num != 0)
				{
				}
				num = (short)2125463552;
				if (num != 0)
				{
				}
				num = (short)884932608;
				short num3 = num;
				this.d.e(value);
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060000E1 RID: 225 RVA: 0x0000EF78 File Offset: 0x0000D178
		// (set) Token: 0x060000E2 RID: 226 RVA: 0x0000F02C File Offset: 0x0000D22C
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand CompleteJobCommand
		{
			get
			{
				short num = (short)797259736;
				short num2 = num;
				num = (short)1660106712;
				switch (num2 == num)
				{
				}
				num = (short)1542324224;
				if (num != 0)
				{
				}
				num = (short)2066022401;
				if (num != 0)
				{
				}
				num = (short)779157504;
				short num3 = num;
				return global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.c<global::Microsoft.Practices.Prism.Commands.DelegateCommand>.a(this.e);
			}
			set
			{
				short num = (short)475725825;
				if (num != 0)
				{
				}
				num = (short)1908870180;
				short num2 = num;
				num = (short)712969252;
				switch (num2 == num)
				{
				}
				num = (short)1895759872;
				if (num != 0)
				{
				}
				num = (short)595525632;
				short num3 = num;
				this.e.e(value);
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060000E3 RID: 227 RVA: 0x0000F0E4 File Offset: 0x0000D2E4
		// (set) Token: 0x060000E4 RID: 228 RVA: 0x0000F198 File Offset: 0x0000D398
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand CloseDetailsCommand
		{
			get
			{
				short num = (short)1783812201;
				short num2 = num;
				num = (short)2045038697;
				switch (num2 == num)
				{
				}
				num = (short)1392902145;
				if (num != 0)
				{
				}
				num = (short)1388445696;
				if (num != 0)
				{
				}
				num = (short)1128529920;
				short num3 = num;
				return global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.c<global::Microsoft.Practices.Prism.Commands.DelegateCommand>.a(this.f);
			}
			set
			{
				short num = (short)1388773377;
				if (num != 0)
				{
				}
				num = (short)1388556164;
				short num2 = num;
				num = (short)561557380;
				switch (num2 == num)
				{
				}
				num = (short)1619460096;
				if (num != 0)
				{
				}
				num = (short)995033088;
				short num3 = num;
				this.f.e(value);
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000E5 RID: 229 RVA: 0x0000F250 File Offset: 0x0000D450
		// (set) Token: 0x060000E6 RID: 230 RVA: 0x0000F308 File Offset: 0x0000D508
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand DeleteConfigurationsCommand
		{
			get
			{
				short num = (short)1332849112;
				short num2 = num;
				num = (short)939239896;
				switch (num2 == num)
				{
				}
				num = (short)2118909952;
				if (num != 0)
				{
				}
				num = (short)1644363777;
				if (num != 0)
				{
				}
				num = (short)1919090688;
				short num3 = num;
				return global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.c<global::Microsoft.Practices.Prism.Commands.DelegateCommand>.a(this.g);
			}
			set
			{
				short num = (short)451258290;
				short num2 = num;
				num = (short)760194994;
				switch (num2 == num)
				{
				}
				num = (short)655294465;
				if (num != 0)
				{
				}
				num = (short)2127298560;
				if (num != 0)
				{
				}
				num = (short)1986920448;
				short num3 = num;
				this.g.e(value);
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000E7 RID: 231 RVA: 0x0000F3BC File Offset: 0x0000D5BC
		// (set) Token: 0x060000E8 RID: 232 RVA: 0x0000F474 File Offset: 0x0000D674
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand DeleteFirmwaresCommand
		{
			get
			{
				short num = (short)883687425;
				if (num != 0)
				{
				}
				num = (short)1669740168;
				short num2 = num;
				num = (short)45758088;
				switch (num2 == num)
				{
				}
				num = (short)722665472;
				if (num != 0)
				{
				}
				num = (short)1276510208;
				short num3 = num;
				return global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.c<global::Microsoft.Practices.Prism.Commands.DelegateCommand>.a(this.h);
			}
			set
			{
				short num = (short)2018194819;
				short num2 = num;
				num = (short)1337865603;
				switch (num2 == num)
				{
				}
				num = (short)672727041;
				if (num != 0)
				{
				}
				num = (short)1928331264;
				if (num != 0)
				{
				}
				num = (short)1104347136;
				short num3 = num;
				this.h.e(value);
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000E9 RID: 233 RVA: 0x0000F528 File Offset: 0x0000D728
		// (set) Token: 0x060000EA RID: 234 RVA: 0x0000F5DC File Offset: 0x0000D7DC
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand DeleteGroupCommand
		{
			get
			{
				short num = (short)1186654150;
				short num2 = num;
				num = (short)1494673350;
				switch (num2 == num)
				{
				}
				num = (short)257228800;
				if (num != 0)
				{
				}
				num = (short)1162805249;
				if (num != 0)
				{
				}
				num = (short)1412694016;
				short num3 = num;
				return global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.c<global::Microsoft.Practices.Prism.Commands.DelegateCommand>.a(this.i);
			}
			set
			{
				short num = (short)1540524101;
				short num2 = num;
				num = (short)1315080261;
				switch (num2 == num)
				{
				}
				num = (short)288096257;
				if (num != 0)
				{
				}
				num = (short)1921974272;
				if (num != 0)
				{
				}
				num = (short)90308608;
				short num3 = num;
				this.i.e(value);
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000EB RID: 235 RVA: 0x0000F690 File Offset: 0x0000D890
		// (set) Token: 0x060000EC RID: 236 RVA: 0x0000F748 File Offset: 0x0000D948
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand DeleteLanguagePacksCommand
		{
			get
			{
				short num = (short)91628757;
				short num2 = num;
				num = (short)50668757;
				switch (num2 == num)
				{
				}
				num = (short)293928961;
				if (num != 0)
				{
				}
				num = (short)2052653056;
				if (num != 0)
				{
				}
				num = (short)676593664;
				short num3 = num;
				return global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.c<global::Microsoft.Practices.Prism.Commands.DelegateCommand>.a(this.j);
			}
			set
			{
				short num = (short)2114537871;
				short num2 = num;
				num = (short)1548503439;
				switch (num2 == num)
				{
				}
				num = (short)1000013824;
				if (num != 0)
				{
				}
				num = (short)1539440641;
				if (num != 0)
				{
				}
				num = (short)1183055872;
				short num3 = num;
				this.j.e(value);
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000ED RID: 237 RVA: 0x0000F7FC File Offset: 0x0000D9FC
		// (set) Token: 0x060000EE RID: 238 RVA: 0x0000F8B0 File Offset: 0x0000DAB0
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand DeleteRadiosCommand
		{
			get
			{
				short num = (short)1796937199;
				short num2 = num;
				num = (short)1755518447;
				switch (num2 == num)
				{
				}
				num = (short)1541144577;
				if (num != 0)
				{
				}
				num = (short)95617024;
				if (num != 0)
				{
				}
				num = (short)1105264640;
				short num3 = num;
				return global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.c<global::Microsoft.Practices.Prism.Commands.DelegateCommand>.a(this.k);
			}
			set
			{
				short num = (short)76235035;
				short num2 = num;
				num = (short)1647526171;
				switch (num2 == num)
				{
				}
				num = (short)727908353;
				if (num != 0)
				{
				}
				num = (short)1309212672;
				if (num != 0)
				{
				}
				num = (short)1431371776;
				short num3 = num;
				this.k.e(value);
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000EF RID: 239 RVA: 0x0000F968 File Offset: 0x0000DB68
		// (set) Token: 0x060000F0 RID: 240 RVA: 0x0000FA1C File Offset: 0x0000DC1C
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand DeleteTemplatesCommand
		{
			get
			{
				short num = (short)971634020;
				short num2 = num;
				num = (short)396359012;
				switch (num2 == num)
				{
				}
				num = (short)1996029952;
				if (num != 0)
				{
				}
				num = (short)1570766849;
				if (num != 0)
				{
				}
				num = (short)765263872;
				short num3 = num;
				return global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.c<global::Microsoft.Practices.Prism.Commands.DelegateCommand>.a(this.l);
			}
			set
			{
				short num = (short)887471236;
				short num2 = num;
				num = (short)594918532;
				switch (num2 == num)
				{
				}
				num = (short)85327873;
				if (num != 0)
				{
				}
				num = (short)239337472;
				if (num != 0)
				{
				}
				num = (short)69206016;
				short num3 = num;
				this.l.e(value);
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000F1 RID: 241 RVA: 0x0000FAD0 File Offset: 0x0000DCD0
		// (set) Token: 0x060000F2 RID: 242 RVA: 0x0000FB84 File Offset: 0x0000DD84
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand DeleteVoiceAnnouncementsCommand
		{
			get
			{
				short num = (short)368723209;
				short num2 = num;
				num = (short)710558985;
				switch (num2 == num)
				{
				}
				num = (short)1991376897;
				if (num != 0)
				{
				}
				num = (short)586940416;
				if (num != 0)
				{
				}
				num = (short)253624320;
				short num3 = num;
				return global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.c<global::Microsoft.Practices.Prism.Commands.DelegateCommand>.a(this.m);
			}
			set
			{
				short num = (short)1070978481;
				short num2 = num;
				num = (short)397858225;
				switch (num2 == num)
				{
				}
				num = (short)1841168385;
				if (num != 0)
				{
				}
				num = (short)1845166080;
				if (num != 0)
				{
				}
				num = (short)161611776;
				short num3 = num;
				this.m.e(value);
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000F3 RID: 243 RVA: 0x0000FC38 File Offset: 0x0000DE38
		// (set) Token: 0x060000F4 RID: 244 RVA: 0x0000FCEC File Offset: 0x0000DEEC
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand DeleteCACertificatesCommand
		{
			get
			{
				short num = (short)585584413;
				short num2 = num;
				num = (short)649875229;
				switch (num2 == num)
				{
				}
				num = (short)845021185;
				if (num != 0)
				{
				}
				num = (short)1703936000;
				if (num != 0)
				{
				}
				num = (short)334626816;
				short num3 = num;
				return global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.c<global::Microsoft.Practices.Prism.Commands.DelegateCommand>.a(this.n);
			}
			set
			{
				short num = (short)1423966209;
				if (num != 0)
				{
				}
				num = (short)1448021969;
				short num2 = num;
				num = (short)2057310161;
				switch (num2 == num)
				{
				}
				num = (short)1037828096;
				if (num != 0)
				{
				}
				num = (short)1662517248;
				short num3 = num;
				this.n.e(value);
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000F5 RID: 245 RVA: 0x0000FDA0 File Offset: 0x0000DFA0
		// (set) Token: 0x060000F6 RID: 246 RVA: 0x0000FE54 File Offset: 0x0000E054
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand DeleteDVRSFilesCommand
		{
			get
			{
				short num = (short)996345043;
				short num2 = num;
				num = (short)1829373139;
				switch (num2 == num)
				{
				}
				num = (short)1546649600;
				if (num != 0)
				{
				}
				num = (short)1187446785;
				if (num != 0)
				{
				}
				num = (short)974651392;
				short num3 = num;
				return global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.c<global::Microsoft.Practices.Prism.Commands.DelegateCommand>.a(this.o);
			}
			set
			{
				short num = (short)881259762;
				short num2 = num;
				num = (short)453637362;
				switch (num2 == num)
				{
				}
				num = (short)1249378305;
				if (num != 0)
				{
				}
				num = (short)858521600;
				if (num != 0)
				{
				}
				num = (short)1753284608;
				short num3 = num;
				this.o.e(value);
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000F7 RID: 247 RVA: 0x0000FF08 File Offset: 0x0000E108
		// (set) Token: 0x060000F8 RID: 248 RVA: 0x0000FFBC File Offset: 0x0000E1BC
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand DiscardChangesCommand
		{
			get
			{
				short num = (short)744390685;
				short num2 = num;
				num = (short)581926941;
				switch (num2 == num)
				{
				}
				num = (short)1463091200;
				if (num != 0)
				{
				}
				num = (short)1653932033;
				if (num != 0)
				{
				}
				num = (short)220266496;
				short num3 = num;
				return global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.c<global::Microsoft.Practices.Prism.Commands.DelegateCommand>.a(this.p);
			}
			set
			{
				short num = (short)1153892352;
				short num2 = num;
				num = (short)2089864663;
				short num3 = num;
				num = (short)140103127;
				switch (num3 == num)
				{
				}
				num = (short)285409281;
				if (num != 0)
				{
				}
				num = (short)737411072;
				if (num != 0)
				{
				}
				this.p.e(value);
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000F9 RID: 249 RVA: 0x00010070 File Offset: 0x0000E270
		// (set) Token: 0x060000FA RID: 250 RVA: 0x00010128 File Offset: 0x0000E328
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand EditTemplateCommand
		{
			get
			{
				short num = (short)394395648;
				short num2 = num;
				num = (short)1173848100;
				short num3 = num;
				num = (short)1946976292;
				switch (num3 == num)
				{
				}
				num = (short)139526144;
				if (num != 0)
				{
				}
				num = (short)1615265793;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.c<global::Microsoft.Practices.Prism.Commands.DelegateCommand>.a(this.q);
			}
			set
			{
				short num = (short)970522624;
				short num2 = num;
				num = (short)1922070052;
				short num3 = num;
				num = (short)708736548;
				switch (num3 == num)
				{
				}
				num = (short)1267138561;
				if (num != 0)
				{
				}
				num = (short)218955776;
				if (num != 0)
				{
				}
				this.q.e(value);
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000FB RID: 251 RVA: 0x000101E0 File Offset: 0x0000E3E0
		// (set) Token: 0x060000FC RID: 252 RVA: 0x00010294 File Offset: 0x0000E494
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand ExportDVRSCommand
		{
			get
			{
				short num = (short)438566912;
				short num2 = num;
				num = (short)1093690981;
				short num3 = num;
				num = (short)1486186085;
				switch (num3 == num)
				{
				}
				num = (short)88604672;
				if (num != 0)
				{
				}
				num = (short)315424769;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.c<global::Microsoft.Practices.Prism.Commands.DelegateCommand>.a(this.r);
			}
			set
			{
				short num = (short)1239023616;
				short num2 = num;
				num = (short)506905903;
				short num3 = num;
				num = (short)1178715439;
				switch (num3 == num)
				{
				}
				num = (short)1385955329;
				if (num != 0)
				{
				}
				num = (short)378470400;
				if (num != 0)
				{
				}
				this.r.e(value);
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000FD RID: 253 RVA: 0x00010348 File Offset: 0x0000E548
		// (set) Token: 0x060000FE RID: 254 RVA: 0x000103FC File Offset: 0x0000E5FC
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand ExportRadioCommand
		{
			get
			{
				short num = (short)596049920;
				short num2 = num;
				num = (short)2034692634;
				short num3 = num;
				num = (short)1934225946;
				switch (num3 == num)
				{
				}
				num = (short)1456209921;
				if (num != 0)
				{
				}
				num = (short)135069696;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.c<global::Microsoft.Practices.Prism.Commands.DelegateCommand>.a(this.s);
			}
			set
			{
				short num = (short)1020133376;
				short num2 = num;
				num = (short)1879843572;
				short num3 = num;
				num = (short)1928209140;
				switch (num3 == num)
				{
				}
				num = (short)1510408193;
				if (num != 0)
				{
				}
				num = (short)1312882688;
				if (num != 0)
				{
				}
				this.s.e(value);
			}
		}

		// Token: 0x1700002F RID: 47
		// (set) Token: 0x060000FF RID: 255 RVA: 0x000104B4 File Offset: 0x0000E6B4
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand ExportRadiosGridToFileCommand
		{
			set
			{
				short num = (short)2118516736;
				short num2 = num;
				num = (short)1102964751;
				short num3 = num;
				num = (short)249423887;
				switch (num3 == num)
				{
				}
				num = (short)66256897;
				if (num != 0)
				{
				}
				num = (short)29884416;
				if (num != 0)
				{
				}
				this.t.g(value);
			}
		}

		// Token: 0x17000030 RID: 48
		// (set) Token: 0x06000100 RID: 256 RVA: 0x0001056C File Offset: 0x0000E76C
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand ExportPCRRadioSystemsToFileCommand
		{
			set
			{
				short num = (short)468058112;
				short num2 = num;
				num = (short)361379807;
				short num3 = num;
				num = (short)706688991;
				switch (num3 == num)
				{
				}
				num = (short)1659699200;
				if (num != 0)
				{
				}
				num = (short)1808859137;
				if (num != 0)
				{
				}
				this.t.h(value);
			}
		}

		// Token: 0x17000031 RID: 49
		// (set) Token: 0x06000101 RID: 257 RVA: 0x00010624 File Offset: 0x0000E824
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand ExportAstroSystemToFileCommand
		{
			set
			{
				short num = (short)1664679936;
				short num2 = num;
				num = (short)856687966;
				short num3 = num;
				num = (short)1406666078;
				switch (num3 == num)
				{
				}
				num = (short)163315713;
				if (num != 0)
				{
				}
				num = (short)1849360384;
				if (num != 0)
				{
				}
				this.t.i(value);
			}
		}

		// Token: 0x17000032 RID: 50
		// (set) Token: 0x06000102 RID: 258 RVA: 0x000106D8 File Offset: 0x0000E8D8
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand ExportRadioDataProfilesCommand
		{
			set
			{
				short num = (short)408551424;
				short num2 = num;
				num = (short)1360831167;
				short num3 = num;
				num = (short)1109959359;
				switch (num3 == num)
				{
				}
				num = (short)1222115329;
				if (num != 0)
				{
				}
				num = (short)605749248;
				if (num != 0)
				{
				}
				this.t.j(value);
			}
		}

		// Token: 0x17000033 RID: 51
		// (set) Token: 0x06000103 RID: 259 RVA: 0x00010790 File Offset: 0x0000E990
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand ExportRadioOtarProfilesCommand
		{
			set
			{
				short num = (short)973209600;
				short num2 = num;
				num = (short)623747704;
				short num3 = num;
				num = (short)341877368;
				switch (num3 == num)
				{
				}
				num = (short)608305153;
				if (num != 0)
				{
				}
				num = (short)617873408;
				if (num != 0)
				{
				}
				this.t.k(value);
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000104 RID: 260 RVA: 0x00010848 File Offset: 0x0000EA48
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand ExportCurrentGridToFileCommand
		{
			get
			{
				short num = (short)819200000;
				short num2 = num;
				num = (short)1826257926;
				short num3 = num;
				num = (short)316374022;
				switch (num3 == num)
				{
				}
				num = (short)1503789056;
				if (num != 0)
				{
				}
				num = (short)234422273;
				if (num != 0)
				{
				}
				return this.t.j();
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000105 RID: 261 RVA: 0x00010900 File Offset: 0x0000EB00
		// (set) Token: 0x06000106 RID: 262 RVA: 0x000109B4 File Offset: 0x0000EBB4
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand ImportFromConsoleCommand
		{
			get
			{
				short num = (short)1247739904;
				short num2 = num;
				num = (short)1866780001;
				short num3 = num;
				num = (short)1385155937;
				switch (num3 == num)
				{
				}
				num = (short)2120744961;
				if (num != 0)
				{
				}
				num = (short)1932394496;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.c<global::Microsoft.Practices.Prism.Commands.DelegateCommand>.a(this.u);
			}
			set
			{
				short num = (short)41222144;
				short num2 = num;
				num = (short)865746593;
				short num3 = num;
				num = (short)1341800097;
				switch (num3 == num)
				{
				}
				num = (short)1961558016;
				if (num != 0)
				{
				}
				num = (short)56098817;
				if (num != 0)
				{
				}
				this.u.e(value);
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000107 RID: 263 RVA: 0x00010A6C File Offset: 0x0000EC6C
		// (set) Token: 0x06000108 RID: 264 RVA: 0x00010B20 File Offset: 0x0000ED20
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand<string> NavigateToMainModuleCommand
		{
			get
			{
				short num = (short)1710292992;
				short num2 = num;
				num = (short)360841031;
				short num3 = num;
				num = (short)980221767;
				switch (num3 == num)
				{
				}
				num = (short)525008897;
				if (num != 0)
				{
				}
				num = (short)337510400;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.c<global::Microsoft.Practices.Prism.Commands.DelegateCommand<string>>.a(this.v);
			}
			set
			{
				short num = (short)1417084928;
				short num2 = num;
				num = (short)300523616;
				short num3 = num;
				num = (short)357605472;
				switch (num3 == num)
				{
				}
				num = (short)950468609;
				if (num != 0)
				{
				}
				num = (short)180813824;
				if (num != 0)
				{
				}
				this.v.e(value);
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000109 RID: 265 RVA: 0x00010BD4 File Offset: 0x0000EDD4
		// (set) Token: 0x0600010A RID: 266 RVA: 0x00010C8C File Offset: 0x0000EE8C
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand NavigateToSetDebuggerCommand
		{
			get
			{
				short num = (short)1576796160;
				short num2 = num;
				num = (short)1844838401;
				if (num != 0)
				{
				}
				num = (short)744582511;
				short num3 = num;
				num = (short)1477995887;
				switch (num3 == num)
				{
				}
				num = (short)893190144;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.c<global::Microsoft.Practices.Prism.Commands.DelegateCommand>.a(this.w);
			}
			set
			{
				short num = (short)184287232;
				short num2 = num;
				num = (short)1315999032;
				short num3 = num;
				num = (short)260345144;
				switch (num3 == num)
				{
				}
				num = (short)937885697;
				if (num != 0)
				{
				}
				num = (short)1275985920;
				if (num != 0)
				{
				}
				this.w.e(value);
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x0600010B RID: 267 RVA: 0x00010D44 File Offset: 0x0000EF44
		// (set) Token: 0x0600010C RID: 268 RVA: 0x00010DF8 File Offset: 0x0000EFF8
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand PrepareAddConfigurationCommand
		{
			get
			{
				short num = (short)1164705792;
				short num2 = num;
				num = (short)437563146;
				short num3 = num;
				num = (short)1752674058;
				switch (num3 == num)
				{
				}
				num = (short)1567096833;
				if (num != 0)
				{
				}
				num = (short)166658048;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.c<global::Microsoft.Practices.Prism.Commands.DelegateCommand>.a(this.x);
			}
			set
			{
				short num = (short)365166592;
				short num2 = num;
				num = (short)743928154;
				short num3 = num;
				num = (short)1307275610;
				switch (num3 == num)
				{
				}
				num = (short)640548865;
				if (num != 0)
				{
				}
				num = (short)1089404928;
				if (num != 0)
				{
				}
				this.x.e(value);
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x0600010D RID: 269 RVA: 0x00010EB0 File Offset: 0x0000F0B0
		// (set) Token: 0x0600010E RID: 270 RVA: 0x00010F64 File Offset: 0x0000F164
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand PrepareAddRadioCommand
		{
			get
			{
				short num = (short)873594880;
				short num2 = num;
				num = (short)521807260;
				short num3 = num;
				num = (short)1903240604;
				switch (num3 == num)
				{
				}
				num = (short)2017460225;
				if (num != 0)
				{
				}
				num = (short)108199936;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.c<global::Microsoft.Practices.Prism.Commands.DelegateCommand>.a(this.y);
			}
			set
			{
				short num = (short)1451884544;
				short num2 = num;
				num = (short)821130043;
				short num3 = num;
				num = (short)74412859;
				switch (num3 == num)
				{
				}
				num = (short)1070792704;
				if (num != 0)
				{
				}
				num = (short)2123563009;
				if (num != 0)
				{
				}
				this.y.e(value);
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x0600010F RID: 271 RVA: 0x00011018 File Offset: 0x0000F218
		// (set) Token: 0x06000110 RID: 272 RVA: 0x000110D0 File Offset: 0x0000F2D0
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand PrepareCopyConfigurationCommand
		{
			get
			{
				short num = (short)1189675008;
				short num2 = num;
				num = (short)2083608447;
				short num3 = num;
				num = (short)1267685247;
				switch (num3 == num)
				{
				}
				num = (short)1423245312;
				if (num != 0)
				{
				}
				num = (short)1648230401;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.c<global::Microsoft.Practices.Prism.Commands.DelegateCommand>.a(this.z);
			}
			set
			{
				short num = (short)278790144;
				short num2 = num;
				num = (short)1116016595;
				short num3 = num;
				num = (short)794300371;
				switch (num3 == num)
				{
				}
				num = (short)562036736;
				if (num != 0)
				{
				}
				num = (short)876806145;
				if (num != 0)
				{
				}
				this.z.e(value);
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000111 RID: 273 RVA: 0x00011188 File Offset: 0x0000F388
		// (set) Token: 0x06000112 RID: 274 RVA: 0x0001123C File Offset: 0x0000F43C
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand PrepareImportConfigurationsCommand
		{
			get
			{
				short num = (short)2034106368;
				short num2 = num;
				num = (short)1424599414;
				short num3 = num;
				num = (short)413378934;
				switch (num3 == num)
				{
				}
				num = (short)1026490368;
				if (num != 0)
				{
				}
				num = (short)2128740353;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.c<global::Microsoft.Practices.Prism.Commands.DelegateCommand>.a(this.aa);
			}
			set
			{
				short num = (short)603717632;
				short num2 = num;
				num = (short)411418408;
				short num3 = num;
				num = (short)844349224;
				switch (num3 == num)
				{
				}
				num = (short)1195376641;
				if (num != 0)
				{
				}
				num = (short)128974848;
				if (num != 0)
				{
				}
				this.aa.e(value);
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000113 RID: 275 RVA: 0x000112F4 File Offset: 0x0000F4F4
		// (set) Token: 0x06000114 RID: 276 RVA: 0x000113A8 File Offset: 0x0000F5A8
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand PrepareImportFirmwaresCommand
		{
			get
			{
				short num = (short)41680896;
				short num2 = num;
				num = (short)1256475492;
				short num3 = num;
				num = (short)2013023076;
				switch (num3 == num)
				{
				}
				num = (short)2143485953;
				if (num != 0)
				{
				}
				num = (short)1850933248;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.c<global::Microsoft.Practices.Prism.Commands.DelegateCommand>.a(this.ab);
			}
			set
			{
				short num = (short)415760384;
				short num2 = num;
				num = (short)1176509845;
				short num3 = num;
				num = (short)975183253;
				switch (num3 == num)
				{
				}
				num = (short)428867585;
				if (num != 0)
				{
				}
				num = (short)137232384;
				if (num != 0)
				{
				}
				this.ab.e(value);
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000115 RID: 277 RVA: 0x0001145C File Offset: 0x0000F65C
		// (set) Token: 0x06000116 RID: 278 RVA: 0x00011510 File Offset: 0x0000F710
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand PrepareImportFileToGridCommand
		{
			get
			{
				short num = (short)2017198080;
				short num2 = num;
				num = (short)1537831280;
				short num3 = num;
				num = (short)137785712;
				switch (num3 == num)
				{
				}
				num = (short)352387073;
				if (num != 0)
				{
				}
				num = (short)1318191104;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.c<global::Microsoft.Practices.Prism.Commands.DelegateCommand>.a(this.ac);
			}
			set
			{
				short num = (short)422445056;
				short num2 = num;
				num = (short)936596175;
				short num3 = num;
				num = (short)2142327503;
				switch (num3 == num)
				{
				}
				num = (short)571867136;
				if (num != 0)
				{
				}
				num = (short)2025914369;
				if (num != 0)
				{
				}
				this.ac.e(value);
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000117 RID: 279 RVA: 0x000115CC File Offset: 0x0000F7CC
		// (set) Token: 0x06000118 RID: 280 RVA: 0x00011680 File Offset: 0x0000F880
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand PrepareImportLanguagePacksCommand
		{
			get
			{
				short num = (short)1189806080;
				short num2 = num;
				num = (short)1069270449;
				short num3 = num;
				num = (short)1634059697;
				switch (num3 == num)
				{
				}
				num = (short)1723203585;
				if (num != 0)
				{
				}
				num = (short)54067200;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.c<global::Microsoft.Practices.Prism.Commands.DelegateCommand>.a(this.ad);
			}
			set
			{
				short num = (short)1591017472;
				short num2 = num;
				num = (short)174736102;
				short num3 = num;
				num = (short)724779750;
				switch (num3 == num)
				{
				}
				num = (short)1252589569;
				if (num != 0)
				{
				}
				num = (short)1157955584;
				if (num != 0)
				{
				}
				this.ad.e(value);
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000119 RID: 281 RVA: 0x00011738 File Offset: 0x0000F938
		// (set) Token: 0x0600011A RID: 282 RVA: 0x000117EC File Offset: 0x0000F9EC
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand PrepareImportRadiosCommand
		{
			get
			{
				short num = (short)495976448;
				short num2 = num;
				num = (short)1558285319;
				short num3 = num;
				num = (short)2147322887;
				switch (num3 == num)
				{
				}
				num = (short)1744240641;
				if (num != 0)
				{
				}
				num = (short)791478272;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.c<global::Microsoft.Practices.Prism.Commands.DelegateCommand>.a(this.ae);
			}
			set
			{
				short num = (short)1630535680;
				short num2 = num;
				num = (short)1771700881;
				short num3 = num;
				num = (short)1974534801;
				switch (num3 == num)
				{
				}
				num = (short)524025856;
				if (num != 0)
				{
				}
				num = (short)1134821377;
				if (num != 0)
				{
				}
				this.ae.e(value);
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x0600011B RID: 283 RVA: 0x000118A4 File Offset: 0x0000FAA4
		// (set) Token: 0x0600011C RID: 284 RVA: 0x00011958 File Offset: 0x0000FB58
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand PrepareImportTemplatesCommand
		{
			get
			{
				short num = (short)256704512;
				short num2 = num;
				num = (short)1954742273;
				if (num != 0)
				{
				}
				num = (short)954412896;
				short num3 = num;
				num = (short)1467363168;
				switch (num3 == num)
				{
				}
				num = (short)1172701184;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.c<global::Microsoft.Practices.Prism.Commands.DelegateCommand>.a(this.af);
			}
			set
			{
				short num = (short)34275328;
				short num2 = num;
				num = (short)1971663795;
				short num3 = num;
				num = (short)634401715;
				switch (num3 == num)
				{
				}
				num = (short)2059534337;
				if (num != 0)
				{
				}
				num = (short)1750728704;
				if (num != 0)
				{
				}
				this.af.e(value);
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x0600011D RID: 285 RVA: 0x00011A10 File Offset: 0x0000FC10
		// (set) Token: 0x0600011E RID: 286 RVA: 0x00011AC4 File Offset: 0x0000FCC4
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand PrepareImportVoiceAnnouncementsCommand
		{
			get
			{
				short num = (short)1860239360;
				short num2 = num;
				num = (short)1339310412;
				short num3 = num;
				num = (short)1064321356;
				switch (num3 == num)
				{
				}
				num = (short)1047003137;
				if (num != 0)
				{
				}
				num = (short)1609170944;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.c<global::Microsoft.Practices.Prism.Commands.DelegateCommand>.a(this.ag);
			}
			set
			{
				short num = (short)729706841;
				short num2 = num;
				num = (short)1835233625;
				switch (num2 == num)
				{
				default:
				{
					num = (short)201916416;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)834338817;
				if (num != 0)
				{
				}
				num = (short)795082752;
				if (num != 0)
				{
				}
				this.ag.e(value);
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x0600011F RID: 287 RVA: 0x00011B80 File Offset: 0x0000FD80
		// (set) Token: 0x06000120 RID: 288 RVA: 0x00011C38 File Offset: 0x0000FE38
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand PrepareImportCACertificatesCommand
		{
			get
			{
				short num = (short)1637827433;
				short num2 = num;
				num = (short)1404978025;
				switch (num2 == num)
				{
				default:
				{
					num = (short)255590400;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1348272128;
				if (num != 0)
				{
				}
				num = (short)1824915457;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.c<global::Microsoft.Practices.Prism.Commands.DelegateCommand>.a(this.ah);
			}
			set
			{
				short num = (short)277923026;
				short num2 = num;
				num = (short)1606010066;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1858273280;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2090270721;
				if (num != 0)
				{
				}
				num = (short)1443692544;
				if (num != 0)
				{
				}
				this.ah.e(value);
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000121 RID: 289 RVA: 0x00011CF0 File Offset: 0x0000FEF0
		// (set) Token: 0x06000122 RID: 290 RVA: 0x00011DA4 File Offset: 0x0000FFA4
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand PrepareImportDVRSFilesCommand
		{
			get
			{
				short num = (short)942317621;
				short num2 = num;
				num = (short)54239285;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1190330368;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1845821440;
				if (num != 0)
				{
				}
				num = (short)1820262401;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.c<global::Microsoft.Practices.Prism.Commands.DelegateCommand>.a(this.ai);
			}
			set
			{
				short num = (short)1516301558;
				short num2 = num;
				num = (short)286715126;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2117926912;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1206386689;
				if (num != 0)
				{
				}
				num = (short)636682240;
				if (num != 0)
				{
				}
				this.ai.e(value);
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000123 RID: 291 RVA: 0x00011E5C File Offset: 0x0001005C
		// (set) Token: 0x06000124 RID: 292 RVA: 0x00011F10 File Offset: 0x00010110
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand PrepareImportTextToSpeechsCommand
		{
			get
			{
				short num = (short)1014711344;
				short num2 = num;
				num = (short)680674352;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1205469184;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)951713793;
				if (num != 0)
				{
				}
				num = (short)1790771200;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.c<global::Microsoft.Practices.Prism.Commands.DelegateCommand>.a(this.aj);
			}
			set
			{
				short num = (short)611021615;
				short num2 = num;
				num = (short)1497658159;
				switch (num2 == num)
				{
				default:
				{
					num = (short)752484352;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1396375553;
				if (num != 0)
				{
				}
				num = (short)1290010624;
				if (num != 0)
				{
				}
				this.aj.e(value);
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000125 RID: 293 RVA: 0x00011FC8 File Offset: 0x000101C8
		// (set) Token: 0x06000126 RID: 294 RVA: 0x0001207C File Offset: 0x0001027C
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand PrepareImportGeneralPackagesCommand
		{
			get
			{
				short num = (short)1238146722;
				short num2 = num;
				num = (short)2114494114;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1688993792;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1063124992;
				if (num != 0)
				{
				}
				num = (short)2056192001;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.c<global::Microsoft.Practices.Prism.Commands.DelegateCommand>.a(this.ak);
			}
			set
			{
				short num = (short)162429278;
				short num2 = num;
				num = (short)847673694;
				switch (num2 == num)
				{
				default:
				{
					num = (short)505479168;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1207762944;
				if (num != 0)
				{
				}
				num = (short)1561591809;
				if (num != 0)
				{
				}
				this.ak.e(value);
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000127 RID: 295 RVA: 0x00012138 File Offset: 0x00010338
		// (set) Token: 0x06000128 RID: 296 RVA: 0x000121EC File Offset: 0x000103EC
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand PrepareUpdateRadioDataCommand
		{
			get
			{
				short num = (short)168619811;
				short num2 = num;
				num = (short)219475747;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1548681216;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2121138177;
				if (num != 0)
				{
				}
				num = (short)976486400;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.c<global::Microsoft.Practices.Prism.Commands.DelegateCommand>.a(this.al);
			}
			set
			{
				short num = (short)2144142951;
				short num2 = num;
				num = (short)1824720487;
				switch (num2 == num)
				{
				default:
				{
					num = (short)708640768;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1108541441;
				if (num != 0)
				{
				}
				num = (short)1793982464;
				if (num != 0)
				{
				}
				this.al.e(value);
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000129 RID: 297 RVA: 0x000122A0 File Offset: 0x000104A0
		// (set) Token: 0x0600012A RID: 298 RVA: 0x00012350 File Offset: 0x00010550
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand PrepareRenameGroupCommand
		{
			get
			{
				short num = (short)1881866241;
				if (num != 0)
				{
				}
				num = (short)1963524096;
				short num2 = num;
				num = (short)1448597098;
				short num3 = num;
				num = (short)1126815338;
				switch (num3 == num)
				{
				}
				num = (short)1886519296;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.c<global::Microsoft.Practices.Prism.Commands.DelegateCommand>.a(this.am);
			}
			set
			{
				short num = (short)1932504764;
				short num2 = num;
				num = (short)1118285500;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1344929792;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1960116225;
				if (num != 0)
				{
				}
				num = (short)231604224;
				if (num != 0)
				{
				}
				this.am.e(value);
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x0600012B RID: 299 RVA: 0x00012404 File Offset: 0x00010604
		// (set) Token: 0x0600012C RID: 300 RVA: 0x000124BC File Offset: 0x000106BC
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand PrepareResetIdentifiersCommand
		{
			get
			{
				short num = (short)1411317761;
				if (num != 0)
				{
				}
				num = (short)323158016;
				short num2 = num;
				num = (short)1439539809;
				short num3 = num;
				num = (short)2138088033;
				switch (num3 == num)
				{
				}
				num = (short)1711734784;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.c<global::Microsoft.Practices.Prism.Commands.DelegateCommand>.a(this.an);
			}
			set
			{
				short num = (short)1773500314;
				short num2 = num;
				num = (short)2057598874;
				switch (num2 == num)
				{
				default:
				{
					num = (short)756416512;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1700921345;
				if (num != 0)
				{
				}
				num = (short)176750592;
				if (num != 0)
				{
				}
				this.an.e(value);
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x0600012D RID: 301 RVA: 0x00012570 File Offset: 0x00010770
		// (set) Token: 0x0600012E RID: 302 RVA: 0x00012624 File Offset: 0x00010824
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand PrepareSaveAsSetCommand
		{
			get
			{
				short num = (short)1100891623;
				short num2 = num;
				num = (short)764429799;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1421344768;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)661848065;
				if (num != 0)
				{
				}
				num = (short)633405440;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.c<global::Microsoft.Practices.Prism.Commands.DelegateCommand>.a(this.ao);
			}
			set
			{
				short num = (short)142806723;
				short num2 = num;
				num = (short)1680674499;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1095368704;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)746389505;
				if (num != 0)
				{
				}
				num = (short)113377280;
				if (num != 0)
				{
				}
				this.ao.e(value);
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x0600012F RID: 303 RVA: 0x000126D8 File Offset: 0x000108D8
		// (set) Token: 0x06000130 RID: 304 RVA: 0x00012790 File Offset: 0x00010990
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand PrepareSaveAsSetInConfigurationCommand
		{
			get
			{
				short num = (short)1448454202;
				short num2 = num;
				num = (short)1773381690;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1210908672;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1495334912;
				if (num != 0)
				{
				}
				num = (short)1157562369;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.c<global::Microsoft.Practices.Prism.Commands.DelegateCommand>.a(this.ap);
			}
			set
			{
				short num = (short)1360199681;
				if (num != 0)
				{
				}
				num = (short)2039087104;
				short num2 = num;
				num = (short)164170985;
				short num3 = num;
				num = (short)1891634409;
				switch (num3 == num)
				{
				}
				num = (short)429588480;
				if (num != 0)
				{
				}
				this.ap.e(value);
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000131 RID: 305 RVA: 0x00012844 File Offset: 0x00010A44
		// (set) Token: 0x06000132 RID: 306 RVA: 0x000128F8 File Offset: 0x00010AF8
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand PrepareScheduleJobCommand
		{
			get
			{
				short num = (short)137895588;
				short num2 = num;
				num = (short)1663770276;
				switch (num2 == num)
				{
				default:
				{
					num = (short)661389312;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)495058945;
				if (num != 0)
				{
				}
				num = (short)583598080;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.c<global::Microsoft.Practices.Prism.Commands.DelegateCommand>.a(this.aq);
			}
			set
			{
				short num = (short)456808082;
				short num2 = num;
				num = (short)175593106;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1766195200;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)516292609;
				if (num != 0)
				{
				}
				num = (short)662241280;
				if (num != 0)
				{
				}
				this.aq.e(value);
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000133 RID: 307 RVA: 0x000129AC File Offset: 0x00010BAC
		// (set) Token: 0x06000134 RID: 308 RVA: 0x00012A60 File Offset: 0x00010C60
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand RestoreRadioCommand
		{
			get
			{
				short num = (short)1434131384;
				short num2 = num;
				num = (short)2108496824;
				switch (num2 == num)
				{
				default:
				{
					num = (short)103546880;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)167706624;
				if (num != 0)
				{
				}
				num = (short)269942785;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.c<global::Microsoft.Practices.Prism.Commands.DelegateCommand>.a(this.ar);
			}
			set
			{
				short num = (short)228406002;
				short num2 = num;
				num = (short)1278030578;
				switch (num2 == num)
				{
				default:
				{
					num = (short)596705280;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)615907329;
				if (num != 0)
				{
				}
				num = (short)1214578688;
				if (num != 0)
				{
				}
				this.ar.e(value);
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000135 RID: 309 RVA: 0x00012B14 File Offset: 0x00010D14
		// (set) Token: 0x06000136 RID: 310 RVA: 0x00012BC8 File Offset: 0x00010DC8
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand SaveConfigurationCommand
		{
			get
			{
				short num = (short)952227727;
				short num2 = num;
				num = (short)1304024975;
				switch (num2 == num)
				{
				default:
				{
					num = (short)529203200;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1709703168;
				if (num != 0)
				{
				}
				num = (short)1821114369;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.c<global::Microsoft.Practices.Prism.Commands.DelegateCommand>.a(this.@as);
			}
			set
			{
				short num = (short)92654201;
				short num2 = num;
				num = (short)1060031097;
				switch (num2 == num)
				{
				default:
				{
					num = (short)474284032;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)245432320;
				if (num != 0)
				{
				}
				num = (short)361168897;
				if (num != 0)
				{
				}
				this.@as.e(value);
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000137 RID: 311 RVA: 0x00012C80 File Offset: 0x00010E80
		// (set) Token: 0x06000138 RID: 312 RVA: 0x00012D38 File Offset: 0x00010F38
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand SaveSetCommand
		{
			get
			{
				short num = (short)613664366;
				short num2 = num;
				num = (short)1115670126;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1005584384;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)579207169;
				if (num != 0)
				{
				}
				num = (short)1132199936;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.c<global::Microsoft.Practices.Prism.Commands.DelegateCommand>.a(this.at);
			}
			set
			{
				short num = (short)1051243151;
				short num2 = num;
				num = (short)1670361743;
				switch (num2 == num)
				{
				default:
				{
					num = (short)762839040;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)156893184;
				if (num != 0)
				{
				}
				num = (short)1950547969;
				if (num != 0)
				{
				}
				this.at.e(value);
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000139 RID: 313 RVA: 0x00012DEC File Offset: 0x00010FEC
		// (set) Token: 0x0600013A RID: 314 RVA: 0x00012EA0 File Offset: 0x000110A0
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand ShowRadioDetailsCommand
		{
			get
			{
				short num = (short)1927404813;
				short num2 = num;
				num = (short)1910627597;
				switch (num2 == num)
				{
				default:
				{
					num = (short)738197504;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)922091521;
				if (num != 0)
				{
				}
				num = (short)10485760;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.c<global::Microsoft.Practices.Prism.Commands.DelegateCommand>.a(this.au);
			}
			set
			{
				short num = (short)794124178;
				short num2 = num;
				num = (short)1094999954;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1689255936;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1932394496;
				if (num != 0)
				{
				}
				num = (short)1000996865;
				if (num != 0)
				{
				}
				this.au.e(value);
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x0600013B RID: 315 RVA: 0x00012F54 File Offset: 0x00011154
		// (set) Token: 0x0600013C RID: 316 RVA: 0x00013008 File Offset: 0x00011208
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand UploadMotorolaCodeplugCommand
		{
			get
			{
				short num = (short)11333631;
				short num2 = num;
				num = (short)1539174399;
				switch (num2 == num)
				{
				default:
				{
					num = (short)990380032;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)642383873;
				if (num != 0)
				{
				}
				num = (short)1489108992;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.c<global::Microsoft.Practices.Prism.Commands.DelegateCommand>.a(this.av);
			}
			set
			{
				short num = (short)1933953743;
				short num2 = num;
				num = (short)2081868495;
				switch (num2 == num)
				{
				default:
				{
					num = (short)736886784;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1103888385;
				if (num != 0)
				{
				}
				num = (short)1344929792;
				if (num != 0)
				{
				}
				this.av.e(value);
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x0600013D RID: 317 RVA: 0x000130BC File Offset: 0x000112BC
		// (set) Token: 0x0600013E RID: 318 RVA: 0x00013174 File Offset: 0x00011374
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand ShowSettingsCommand
		{
			get
			{
				short num = (short)1662127937;
				short num2 = num;
				num = (short)1475284801;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1916600320;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)862191616;
				if (num != 0)
				{
				}
				num = (short)874315777;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.c<global::Microsoft.Practices.Prism.Commands.DelegateCommand>.a(this.aw);
			}
			set
			{
				short num = (short)1625148307;
				short num2 = num;
				num = (short)1181076371;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1708326912;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)219283456;
				if (num != 0)
				{
				}
				num = (short)1895628801;
				if (num != 0)
				{
				}
				this.aw.e(value);
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x0600013F RID: 319 RVA: 0x00013228 File Offset: 0x00011428
		// (set) Token: 0x06000140 RID: 320 RVA: 0x000132DC File Offset: 0x000114DC
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand ShowRadioConversionCommand
		{
			get
			{
				short num = (short)1561812756;
				short num2 = num;
				num = (short)728719124;
				switch (num2 == num)
				{
				default:
				{
					num = (short)975437824;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)966787072;
				if (num != 0)
				{
				}
				num = (short)92405761;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.c<global::Microsoft.Practices.Prism.Commands.DelegateCommand>.a(this.ax);
			}
			set
			{
				short num = (short)1968307222;
				short num2 = num;
				num = (short)1939471382;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1504903168;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1512243201;
				if (num != 0)
				{
				}
				num = (short)1131937792;
				if (num != 0)
				{
				}
				this.ax.e(value);
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000141 RID: 321 RVA: 0x00013390 File Offset: 0x00011590
		// (set) Token: 0x06000142 RID: 322 RVA: 0x00013444 File Offset: 0x00011644
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand ShowTemplateConversionDialogCommand
		{
			get
			{
				short num = (short)113920463;
				short num2 = num;
				num = (short)432753103;
				switch (num2 == num)
				{
				default:
				{
					num = (short)642973696;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)552534017;
				if (num != 0)
				{
				}
				num = (short)1349320704;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.c<global::Microsoft.Practices.Prism.Commands.DelegateCommand>.a(this.ay);
			}
			set
			{
				short num = (short)683797047;
				short num2 = num;
				num = (short)215607863;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1218314240;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)471138304;
				if (num != 0)
				{
				}
				num = (short)1363542017;
				if (num != 0)
				{
				}
				this.ay.e(value);
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000143 RID: 323 RVA: 0x000134FC File Offset: 0x000116FC
		// (set) Token: 0x06000144 RID: 324 RVA: 0x000135AC File Offset: 0x000117AC
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand ShowSettingsForImportFromConsoleCommand
		{
			get
			{
				short num = (short)640471332;
				short num2 = num;
				num = (short)998691108;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1797980160;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1064435713;
				if (num != 0)
				{
				}
				num = (short)1327038464;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.c<global::Microsoft.Practices.Prism.Commands.DelegateCommand>.a(this.az);
			}
			set
			{
				short num = (short)1236744358;
				short num2 = num;
				num = (short)1498822822;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1570045952;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2036269057;
				if (num != 0)
				{
				}
				num = (short)1530068992;
				if (num != 0)
				{
				}
				this.az.e(value);
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000145 RID: 325 RVA: 0x00013664 File Offset: 0x00011864
		// (set) Token: 0x06000146 RID: 326 RVA: 0x00013718 File Offset: 0x00011918
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand ViewTasksCommand
		{
			get
			{
				short num = (short)1502293770;
				short num2 = num;
				num = (short)206647050;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1918042112;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)296878081;
				if (num != 0)
				{
				}
				num = (short)482869248;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.c<global::Microsoft.Practices.Prism.Commands.DelegateCommand>.a(this.a0);
			}
			set
			{
				short num = (short)1921573967;
				short num2 = num;
				num = (short)420602959;
				switch (num2 == num)
				{
				default:
				{
					num = (short)951582720;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)135725057;
				if (num != 0)
				{
				}
				num = (short)1060634624;
				if (num != 0)
				{
				}
				this.a0.e(value);
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000147 RID: 327 RVA: 0x000137D0 File Offset: 0x000119D0
		// (set) Token: 0x06000148 RID: 328 RVA: 0x00013884 File Offset: 0x00011A84
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand PrepareSelectFirmwareCommand
		{
			get
			{
				short num = (short)1270444336;
				short num2 = num;
				num = (short)300118320;
				switch (num2 == num)
				{
				default:
				{
					num = (short)253952000;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1006174208;
				if (num != 0)
				{
				}
				num = (short)191430657;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.c<global::Microsoft.Practices.Prism.Commands.DelegateCommand>.a(this.a1);
			}
			set
			{
				short num = (short)83963928;
				short num2 = num;
				num = (short)1642344472;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1578106880;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)289013760;
				if (num != 0)
				{
				}
				num = (short)1060438017;
				if (num != 0)
				{
				}
				this.a1.e(value);
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000149 RID: 329 RVA: 0x00013938 File Offset: 0x00011B38
		// (set) Token: 0x0600014A RID: 330 RVA: 0x000139F0 File Offset: 0x00011BF0
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand PrepareSelectFlashPortCommand
		{
			get
			{
				short num = (short)1893781509;
				short num2 = num;
				num = (short)2024525829;
				switch (num2 == num)
				{
				default:
				{
					num = (short)927137792;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)866254848;
				if (num != 0)
				{
				}
				num = (short)261685249;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.c<global::Microsoft.Practices.Prism.Commands.DelegateCommand>.a(this.a2);
			}
			set
			{
				short num = (short)1309671425;
				if (num != 0)
				{
				}
				num = (short)630456320;
				short num2 = num;
				num = (short)417547516;
				short num3 = num;
				num = (short)2014987516;
				switch (num3 == num)
				{
				}
				num = (short)748093440;
				if (num != 0)
				{
				}
				this.a2.e(value);
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x0600014B RID: 331 RVA: 0x00013AA4 File Offset: 0x00011CA4
		// (set) Token: 0x0600014C RID: 332 RVA: 0x00013B58 File Offset: 0x00011D58
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand PrepareSpellCheckCommand
		{
			get
			{
				short num = (short)1032800043;
				short num2 = num;
				num = (short)1823688491;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1217134592;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1286537217;
				if (num != 0)
				{
				}
				num = (short)255066112;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.c<global::Microsoft.Practices.Prism.Commands.DelegateCommand>.a(this.a3);
			}
			set
			{
				short num = (short)15057588;
				short num2 = num;
				num = (short)1474347700;
				switch (num2 == num)
				{
				default:
				{
					num = (short)850264064;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1572732929;
				if (num != 0)
				{
				}
				num = (short)351207424;
				if (num != 0)
				{
				}
				this.a3.e(value);
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x0600014D RID: 333 RVA: 0x00013C0C File Offset: 0x00011E0C
		// (set) Token: 0x0600014E RID: 334 RVA: 0x00013CC0 File Offset: 0x00011EC0
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand PrepareMoveDeviceCommand
		{
			get
			{
				short num = (short)1397862510;
				short num2 = num;
				num = (short)727494766;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1292828672;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)370278400;
				if (num != 0)
				{
				}
				num = (short)1001717761;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.c<global::Microsoft.Practices.Prism.Commands.DelegateCommand>.a(this.a4);
			}
			set
			{
				short num = (short)391859734;
				short num2 = num;
				num = (short)117853718;
				switch (num2 == num)
				{
				default:
				{
					num = (short)523501568;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)329449473;
				if (num != 0)
				{
				}
				num = (short)652410880;
				if (num != 0)
				{
				}
				this.a4.e(value);
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x0600014F RID: 335 RVA: 0x00013D74 File Offset: 0x00011F74
		// (set) Token: 0x06000150 RID: 336 RVA: 0x00013E28 File Offset: 0x00012028
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand<object[]> MoveDeviceCommand
		{
			get
			{
				short num = (short)2050620670;
				short num2 = num;
				num = (short)1079311614;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1462763520;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1222836225;
				if (num != 0)
				{
				}
				num = (short)1112145920;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.c<global::Microsoft.Practices.Prism.Commands.DelegateCommand<object[]>>.a(this.a5);
			}
			set
			{
				short num = (short)424542208;
				short num2 = num;
				num = (short)746192897;
				if (num != 0)
				{
				}
				num = (short)2000584003;
				short num3 = num;
				num = (short)1600879939;
				switch (num3 == num)
				{
				}
				num = (short)1507196928;
				if (num != 0)
				{
				}
				this.a5.e(value);
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000151 RID: 337 RVA: 0x00013EDC File Offset: 0x000120DC
		// (set) Token: 0x06000152 RID: 338 RVA: 0x00013F90 File Offset: 0x00012190
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand DeleteGeneralPackageCommand
		{
			get
			{
				short num = (short)777256960;
				short num2 = num;
				num = (short)604920406;
				short num3 = num;
				num = (short)7232086;
				switch (num3 == num)
				{
				}
				num = (short)280756224;
				if (num != 0)
				{
				}
				num = (short)1344208897;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.c<global::Microsoft.Practices.Prism.Commands.DelegateCommand>.a(this.a6);
			}
			set
			{
				short num = (short)1473970176;
				short num2 = num;
				num = (short)1019084801;
				if (num != 0)
				{
				}
				num = (short)1779835510;
				short num3 = num;
				num = (short)1589781110;
				switch (num3 == num)
				{
				}
				num = (short)323354624;
				if (num != 0)
				{
				}
				this.a6.e(value);
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x06000153 RID: 339 RVA: 0x00014044 File Offset: 0x00012244
		// (set) Token: 0x06000154 RID: 340 RVA: 0x000140F8 File Offset: 0x000122F8
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand PrepareUploadSystemKeysCommand
		{
			get
			{
				short num = (short)1547894784;
				short num2 = num;
				num = (short)1342838030;
				short num3 = num;
				num = (short)344462606;
				switch (num3 == num)
				{
				}
				num = (short)292552705;
				if (num != 0)
				{
				}
				num = (short)1334575104;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.c<global::Microsoft.Practices.Prism.Commands.DelegateCommand>.a(this.a7);
			}
			set
			{
				short num = (short)712507392;
				short num2 = num;
				num = (short)1975058433;
				if (num != 0)
				{
				}
				num = (short)18999993;
				short num3 = num;
				num = (short)100657849;
				switch (num3 == num)
				{
				}
				num = (short)1881800704;
				if (num != 0)
				{
				}
				this.a7.e(value);
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06000155 RID: 341 RVA: 0x000141AC File Offset: 0x000123AC
		// (set) Token: 0x06000156 RID: 342 RVA: 0x00014260 File Offset: 0x00012460
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand<object> PrintViewCommand
		{
			get
			{
				short num = (short)48496640;
				short num2 = num;
				num = (short)1867928992;
				short num3 = num;
				num = (short)370365856;
				switch (num3 == num)
				{
				}
				num = (short)1973092353;
				if (num != 0)
				{
				}
				num = (short)1094975488;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.c<global::Microsoft.Practices.Prism.Commands.DelegateCommand<object>>.a(this.a8);
			}
			set
			{
				short num = (short)1124532224;
				short num2 = num;
				num = (short)1604587638;
				short num3 = num;
				num = (short)94965878;
				switch (num3 == num)
				{
				}
				num = (short)517603329;
				if (num != 0)
				{
				}
				num = (short)2052194304;
				if (num != 0)
				{
				}
				this.a8.e(value);
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000157 RID: 343 RVA: 0x00014314 File Offset: 0x00012514
		// (set) Token: 0x06000158 RID: 344 RVA: 0x000143C8 File Offset: 0x000125C8
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand PrintViewPreviewCommand
		{
			get
			{
				short num = (short)616562688;
				short num2 = num;
				num = (short)1528819010;
				short num3 = num;
				num = (short)1784540482;
				switch (num3 == num)
				{
				}
				num = (short)92930049;
				if (num != 0)
				{
				}
				num = (short)1711931392;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.c<global::Microsoft.Practices.Prism.Commands.DelegateCommand>.a(this.a9);
			}
			set
			{
				short num = (short)1629880320;
				short num2 = num;
				num = (short)1899954177;
				if (num != 0)
				{
				}
				num = (short)599578044;
				short num3 = num;
				num = (short)1968625084;
				switch (num3 == num)
				{
				}
				num = (short)1320222720;
				if (num != 0)
				{
				}
				this.a9.e(value);
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000159 RID: 345 RVA: 0x0001447C File Offset: 0x0001267C
		// (set) Token: 0x0600015A RID: 346 RVA: 0x00014534 File Offset: 0x00012734
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand AboutCommand
		{
			get
			{
				short num = (short)1046544384;
				short num2 = num;
				num = (short)1331167233;
				if (num != 0)
				{
				}
				num = (short)1768498823;
				short num3 = num;
				num = (short)617227911;
				switch (num3 == num)
				{
				}
				num = (short)1215299584;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.c<global::Microsoft.Practices.Prism.Commands.DelegateCommand>.a(this.ba);
			}
			set
			{
				short num = (short)2087649280;
				short num2 = num;
				num = (short)1876529569;
				short num3 = num;
				num = (short)397513121;
				switch (num3 == num)
				{
				}
				num = (short)1716977665;
				if (num != 0)
				{
				}
				num = (short)944832512;
				if (num != 0)
				{
				}
				this.ba.e(value);
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x0600015B RID: 347 RVA: 0x000145E8 File Offset: 0x000127E8
		// (set) Token: 0x0600015C RID: 348 RVA: 0x0001469C File Offset: 0x0001289C
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand HelpCommand
		{
			get
			{
				short num = (short)858324992;
				short num2 = num;
				num = (short)408327714;
				short num3 = num;
				num = (short)1089377826;
				switch (num3 == num)
				{
				}
				num = (short)507379712;
				if (num != 0)
				{
				}
				num = (short)1486880769;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.c<global::Microsoft.Practices.Prism.Commands.DelegateCommand>.a(this.bb);
			}
			set
			{
				short num = (short)304807936;
				short num2 = num;
				num = (short)1136475920;
				short num3 = num;
				num = (short)1912487696;
				switch (num3 == num)
				{
				}
				num = (short)1131872256;
				if (num != 0)
				{
				}
				num = (short)2020540417;
				if (num != 0)
				{
				}
				this.bb.e(value);
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x0600015D RID: 349 RVA: 0x00014750 File Offset: 0x00012950
		// (set) Token: 0x0600015E RID: 350 RVA: 0x00014804 File Offset: 0x00012A04
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::Motorola.CommonCPS.RadioManagement.UIModels.LogSetting> ShowUpdateLogSettingCommand
		{
			get
			{
				short num = (short)1390804992;
				short num2 = num;
				num = (short)1104054622;
				short num3 = num;
				num = (short)1730185566;
				switch (num3 == num)
				{
				}
				num = (short)126353409;
				if (num != 0)
				{
				}
				num = (short)668729344;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.c<global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::Motorola.CommonCPS.RadioManagement.UIModels.LogSetting>>.a(this.bc);
			}
			set
			{
				short num = (short)861732864;
				short num2 = num;
				num = (short)1000341505;
				if (num != 0)
				{
				}
				num = (short)1871324243;
				short num3 = num;
				num = (short)1614357587;
				switch (num3 == num)
				{
				}
				num = (short)581632000;
				if (num != 0)
				{
				}
				this.bc.e(value);
			}
		}

		// Token: 0x04000046 RID: 70
		private static global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxy a;

		// Token: 0x04000047 RID: 71
		private readonly global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.b b = new global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.b();

		// Token: 0x04000048 RID: 72
		private readonly global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.b c = new global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.b();

		// Token: 0x04000049 RID: 73
		private readonly global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.b d = new global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.b();

		// Token: 0x0400004A RID: 74
		private readonly global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.b e = new global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.b();

		// Token: 0x0400004B RID: 75
		private readonly global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.b f = new global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.b();

		// Token: 0x0400004C RID: 76
		private readonly global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.b g = new global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.b();

		// Token: 0x0400004D RID: 77
		private readonly global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.b h = new global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.b();

		// Token: 0x0400004E RID: 78
		private readonly global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.b i = new global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.b();

		// Token: 0x0400004F RID: 79
		private readonly global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.b j = new global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.b();

		// Token: 0x04000050 RID: 80
		private readonly global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.b k = new global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.b();

		// Token: 0x04000051 RID: 81
		private readonly global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.b l = new global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.b();

		// Token: 0x04000052 RID: 82
		private readonly global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.b m = new global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.b();

		// Token: 0x04000053 RID: 83
		private readonly global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.b n = new global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.b();

		// Token: 0x04000054 RID: 84
		private readonly global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.b o = new global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.b();

		// Token: 0x04000055 RID: 85
		private readonly global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.b p = new global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.b();

		// Token: 0x04000056 RID: 86
		private readonly global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.b q = new global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.b();

		// Token: 0x04000057 RID: 87
		private readonly global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.b r = new global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.b();

		// Token: 0x04000058 RID: 88
		private readonly global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.b s = new global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.b();

		// Token: 0x04000059 RID: 89
		private readonly global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.d t = new global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.d();

		// Token: 0x0400005A RID: 90
		private readonly global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.b u = new global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.b();

		// Token: 0x0400005B RID: 91
		private readonly global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.a<string> v = new global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.a<string>();

		// Token: 0x0400005C RID: 92
		private readonly global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.b w = new global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.b();

		// Token: 0x0400005D RID: 93
		private readonly global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.b x = new global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.b();

		// Token: 0x0400005E RID: 94
		private readonly global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.b y = new global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.b();

		// Token: 0x0400005F RID: 95
		private readonly global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.b z = new global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.b();

		// Token: 0x04000060 RID: 96
		private readonly global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.b aa = new global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.b();

		// Token: 0x04000061 RID: 97
		private readonly global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.b ab = new global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.b();

		// Token: 0x04000062 RID: 98
		private readonly global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.b ac = new global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.b();

		// Token: 0x04000063 RID: 99
		private readonly global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.b ad = new global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.b();

		// Token: 0x04000064 RID: 100
		private readonly global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.b ae = new global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.b();

		// Token: 0x04000065 RID: 101
		private readonly global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.b af = new global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.b();

		// Token: 0x04000066 RID: 102
		private readonly global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.b ag = new global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.b();

		// Token: 0x04000067 RID: 103
		private readonly global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.b ah = new global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.b();

		// Token: 0x04000068 RID: 104
		private readonly global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.b ai = new global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.b();

		// Token: 0x04000069 RID: 105
		private readonly global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.b aj = new global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.b();

		// Token: 0x0400006A RID: 106
		private readonly global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.b ak = new global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.b();

		// Token: 0x0400006B RID: 107
		private readonly global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.b al = new global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.b();

		// Token: 0x0400006C RID: 108
		private readonly global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.b am = new global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.b();

		// Token: 0x0400006D RID: 109
		private readonly global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.b an = new global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.b();

		// Token: 0x0400006E RID: 110
		private readonly global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.b ao = new global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.b();

		// Token: 0x0400006F RID: 111
		private readonly global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.b ap = new global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.b();

		// Token: 0x04000070 RID: 112
		private readonly global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.b aq = new global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.b();

		// Token: 0x04000071 RID: 113
		private readonly global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.b ar = new global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.b();

		// Token: 0x04000072 RID: 114
		private readonly global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.b @as = new global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.b();

		// Token: 0x04000073 RID: 115
		private readonly global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.b at = new global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.b();

		// Token: 0x04000074 RID: 116
		private readonly global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.b au = new global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.b();

		// Token: 0x04000075 RID: 117
		private readonly global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.b av = new global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.b();

		// Token: 0x04000076 RID: 118
		private readonly global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.b aw = new global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.b();

		// Token: 0x04000077 RID: 119
		private readonly global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.b ax = new global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.b();

		// Token: 0x04000078 RID: 120
		private readonly global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.b ay = new global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.b();

		// Token: 0x04000079 RID: 121
		private readonly global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.b az = new global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.b();

		// Token: 0x0400007A RID: 122
		private readonly global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.b a0 = new global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.b();

		// Token: 0x0400007B RID: 123
		private readonly global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.b a1 = new global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.b();

		// Token: 0x0400007C RID: 124
		private readonly global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.b a2 = new global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.b();

		// Token: 0x0400007D RID: 125
		private readonly global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.b a3 = new global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.b();

		// Token: 0x0400007E RID: 126
		private readonly global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.b a4 = new global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.b();

		// Token: 0x0400007F RID: 127
		private readonly global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.a<object[]> a5 = new global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.a<object[]>();

		// Token: 0x04000080 RID: 128
		private readonly global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.b a6 = new global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.b();

		// Token: 0x04000081 RID: 129
		private readonly global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.b a7 = new global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.b();

		// Token: 0x04000082 RID: 130
		private readonly global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.a<object> a8 = new global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.a<object>();

		// Token: 0x04000083 RID: 131
		private readonly global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.b a9 = new global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.b();

		// Token: 0x04000084 RID: 132
		private readonly global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.b ba = new global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.b();

		// Token: 0x04000085 RID: 133
		private readonly global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.b bb = new global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.b();

		// Token: 0x04000086 RID: 134
		private readonly global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.a<global::Motorola.CommonCPS.RadioManagement.UIModels.LogSetting> bc = new global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.a<global::Motorola.CommonCPS.RadioManagement.UIModels.LogSetting>();
	}
}
