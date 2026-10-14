using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x0200008D RID: 141
	public class SettingsForImportFromConsoleContext : global::Motorola.CommonCPS.RadioManagement.UIModels.ContextBase
	{
		// Token: 0x06000506 RID: 1286 RVA: 0x0004AED8 File Offset: 0x000490D8
		public SettingsForImportFromConsoleContext()
		{
			this.c = 0;
		}

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x06000507 RID: 1287 RVA: 0x0004AEF4 File Offset: 0x000490F4
		// (set) Token: 0x06000508 RID: 1288 RVA: 0x0004AFA4 File Offset: 0x000491A4
		public bool IsTypeII
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1767178240;
				short num2 = num;
				num = (short)217067158;
				short num3 = num;
				num = (short)434843286;
				switch (num3 == num)
				{
				}
				num = (short)472973312;
				if (num != 0)
				{
				}
				num = (short)1460142081;
				if (num != 0)
				{
				}
				return this.j;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)590807040;
				short num2 = num;
				num = (short)339724257;
				short num3 = num;
				num = (short)2096875489;
				switch (num3 == num)
				{
				}
				num = (short)813170688;
				if (num != 0)
				{
				}
				num = (short)1918894081;
				if (num != 0)
				{
				}
				this.j = value;
			}
		}

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x06000509 RID: 1289 RVA: 0x0004B058 File Offset: 0x00049258
		// (set) Token: 0x0600050A RID: 1290 RVA: 0x0004B10C File Offset: 0x0004930C
		public bool IsAstro25
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)87490560;
				short num2 = num;
				num = (short)1840442247;
				short num3 = num;
				num = (short)139783047;
				switch (num3 == num)
				{
				}
				num = (short)1090191361;
				if (num != 0)
				{
				}
				num = (short)1545076736;
				if (num != 0)
				{
				}
				return this.k;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)824442880;
				short num2 = num;
				num = (short)1020524425;
				short num3 = num;
				num = (short)923989897;
				switch (num3 == num)
				{
				}
				num = (short)1412825089;
				if (num != 0)
				{
				}
				num = (short)1325727744;
				if (num != 0)
				{
				}
				this.k = value;
			}
		}

		// Token: 0x17000241 RID: 577
		// (get) Token: 0x0600050B RID: 1291 RVA: 0x0004B1C0 File Offset: 0x000493C0
		// (set) Token: 0x0600050C RID: 1292 RVA: 0x0004B26C File Offset: 0x0004946C
		public global::System.Collections.Generic.IList<string> SysTypeAndSysName
		{
			get
			{
				short num = (short)167510016;
				short num2 = num;
				num = (short)24156372;
				short num3 = num;
				num = (short)350263508;
				switch (num3 == num)
				{
				}
				num = (short)1778450432;
				if (num != 0)
				{
				}
				num = (short)506200065;
				if (num != 0)
				{
				}
				return this.a;
			}
			set
			{
				short num = (short)1756823552;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)39714816;
					short num3 = num;
					switch (num2)
					{
					case 0:
					{
						num = (short)1570370233;
						short num4 = num;
						num = (short)1718874809;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)1424359424;
							if (num != 0)
							{
							}
							num = (short)693370881;
							if (num != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_CA;
							}
							continue;
						}
						break;
					}
					case 1:
						this.a = value;
						base.RaisePropertyChanged<global::System.Collections.Generic.IList<string>>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::System.Collections.Generic.IList<string>>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.SettingsForImportFromConsoleContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.SettingsForImportFromConsoleContext.get_SysTypeAndSysName())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)452067330;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						return;
					}
					IL_CA:
					if (value == this.a)
					{
						break;
					}
					num = (short)195624961;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x0600050D RID: 1293 RVA: 0x0004B3B8 File Offset: 0x000495B8
		// (set) Token: 0x0600050E RID: 1294 RVA: 0x0004B468 File Offset: 0x00049668
		public global::System.Collections.Generic.IList<string> AllSysTypeAndSysName
		{
			get
			{
				short num = (short)366084096;
				short num2 = num;
				num = (short)1635943722;
				short num3 = num;
				num = (short)415860010;
				switch (num3 == num)
				{
				}
				num = (short)1393295360;
				if (num != 0)
				{
				}
				num = (short)1554251777;
				if (num != 0)
				{
				}
				return this.b;
			}
			set
			{
				short num = (short)1299775488;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)1364253588;
						short num3 = num;
						num = (short)451074964;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)61407232;
							if (num != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_7A;
							}
							continue;
						}
						break;
					}
					case 1:
						this.b = value;
						base.RaisePropertyChanged<global::System.Collections.Generic.IList<string>>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::System.Collections.Generic.IList<string>>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.SettingsForImportFromConsoleContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.SettingsForImportFromConsoleContext.get_AllSysTypeAndSysName())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)163971074;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_11A;
					}
					IL_7A:
					num = (short)1992622080;
					short num4 = num;
					if (value == this.b)
					{
						return;
					}
					num = (short)682295297;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_11A:
				num = (short)2032861185;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x17000243 RID: 579
		// (get) Token: 0x0600050F RID: 1295 RVA: 0x0004B5B8 File Offset: 0x000497B8
		// (set) Token: 0x06000510 RID: 1296 RVA: 0x0004B668 File Offset: 0x00049868
		public string SelectedSystemName
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)645726208;
				short num2 = num;
				num = (short)582419862;
				short num3 = num;
				num = (short)1427965334;
				switch (num3 == num)
				{
				}
				num = (short)972554241;
				if (num != 0)
				{
				}
				num = (short)1724448768;
				if (num != 0)
				{
				}
				return this.l;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)879034368;
				short num2 = num;
				num = (short)1677716015;
				short num3 = num;
				num = (short)638708271;
				switch (num3 == num)
				{
				}
				num = (short)835911680;
				if (num != 0)
				{
				}
				num = (short)1465909249;
				if (num != 0)
				{
				}
				this.l = value;
			}
		}

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x06000511 RID: 1297 RVA: 0x0004B718 File Offset: 0x00049918
		// (set) Token: 0x06000512 RID: 1298 RVA: 0x0004B7C8 File Offset: 0x000499C8
		public string FilePath
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1699086336;
				short num2 = num;
				num = (short)1233710766;
				short num3 = num;
				num = (short)500166318;
				switch (num3 == num)
				{
				}
				num = (short)1674641409;
				if (num != 0)
				{
				}
				num = (short)1095565312;
				if (num != 0)
				{
				}
				return this.m;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1153105920;
				short num2 = num;
				num = (short)1238516375;
				short num3 = num;
				num = (short)826688151;
				switch (num3 == num)
				{
				}
				num = (short)655622144;
				if (num != 0)
				{
				}
				num = (short)323944449;
				if (num != 0)
				{
				}
				this.m = value;
			}
		}

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x06000513 RID: 1299 RVA: 0x0004B878 File Offset: 0x00049A78
		// (set) Token: 0x06000514 RID: 1300 RVA: 0x0004B928 File Offset: 0x00049B28
		public string NameSelection
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1274544128;
				short num2 = num;
				num = (short)1925251073;
				if (num != 0)
				{
				}
				num = (short)1416160311;
				short num3 = num;
				num = (short)397796407;
				switch (num3 == num)
				{
				}
				num = (short)520159232;
				if (num != 0)
				{
				}
				return this.n;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1050214400;
				short num2 = num;
				num = (short)17066280;
				short num3 = num;
				num = (short)1172793640;
				switch (num3 == num)
				{
				}
				num = (short)7471105;
				if (num != 0)
				{
				}
				num = (short)1048117248;
				if (num != 0)
				{
				}
				this.n = value;
			}
		}

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x06000515 RID: 1301 RVA: 0x0004B9D8 File Offset: 0x00049BD8
		// (set) Token: 0x06000516 RID: 1302 RVA: 0x0004BA88 File Offset: 0x00049C88
		public bool ASTRO25
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1129185280;
				short num2 = num;
				num = (short)1175013796;
				short num3 = num;
				num = (short)1164528036;
				switch (num3 == num)
				{
				}
				num = (short)405209089;
				if (num != 0)
				{
				}
				num = (short)799014912;
				if (num != 0)
				{
				}
				return this.o;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1422721024;
				short num2 = num;
				num = (short)623108511;
				short num3 = num;
				num = (short)1668800927;
				switch (num3 == num)
				{
				}
				num = (short)1385365505;
				if (num != 0)
				{
				}
				num = (short)906625024;
				if (num != 0)
				{
				}
				this.o = value;
			}
		}

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x06000517 RID: 1303 RVA: 0x0004BB38 File Offset: 0x00049D38
		// (set) Token: 0x06000518 RID: 1304 RVA: 0x0004BBE4 File Offset: 0x00049DE4
		public bool II
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1947271168;
				short num2 = num;
				num = (short)1163046114;
				short num3 = num;
				num = (short)1097379042;
				switch (num3 == num)
				{
				}
				num = (short)1434779649;
				if (num != 0)
				{
				}
				num = (short)1589510144;
				if (num != 0)
				{
				}
				return this.p;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1596063744;
				short num2 = num;
				num = (short)462960200;
				short num3 = num;
				num = (short)825439816;
				switch (num3 == num)
				{
				}
				num = (short)1749417985;
				if (num != 0)
				{
				}
				num = (short)207618048;
				if (num != 0)
				{
				}
				this.p = value;
			}
		}

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x06000519 RID: 1305 RVA: 0x0004BC94 File Offset: 0x00049E94
		// (set) Token: 0x0600051A RID: 1306 RVA: 0x0004BD48 File Offset: 0x00049F48
		public bool DeleteExtraIds
		{
			get
			{
				short num = (short)1557200896;
				short num2 = num;
				num = (short)1605731960;
				short num3 = num;
				num = (short)1335199352;
				switch (num3 == num)
				{
				}
				num = (short)250871809;
				if (num != 0)
				{
				}
				num = (short)1968898048;
				if (num != 0)
				{
				}
				return this.e;
			}
			set
			{
				short num = (short)532611072;
				short num2 = num;
				num = (short)923735883;
				short num3 = num;
				num = (short)1125848907;
				switch (num3 == num)
				{
				}
				num = (short)475791361;
				if (num != 0)
				{
				}
				num = (short)1302528000;
				if (num != 0)
				{
				}
				this.e = value;
			}
		}

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x0600051B RID: 1307 RVA: 0x0004BDF8 File Offset: 0x00049FF8
		// (set) Token: 0x0600051C RID: 1308 RVA: 0x0004BEAC File Offset: 0x0004A0AC
		public string SystemId
		{
			get
			{
				short num = (short)938344448;
				short num2 = num;
				num = (short)747151310;
				short num3 = num;
				num = (short)382377934;
				switch (num3 == num)
				{
				}
				num = (short)1211891713;
				if (num != 0)
				{
				}
				num = (short)1351548928;
				if (num != 0)
				{
				}
				return this.f;
			}
			set
			{
				short num = (short)462159872;
				short num2 = num;
				num = (short)1288860685;
				short num3 = num;
				num = (short)945910797;
				switch (num3 == num)
				{
				}
				num = (short)731971585;
				if (num != 0)
				{
				}
				num = (short)1592197120;
				if (num != 0)
				{
				}
				this.f = value;
			}
		}

		// Token: 0x1700024A RID: 586
		// (get) Token: 0x0600051D RID: 1309 RVA: 0x0004BF5C File Offset: 0x0004A15C
		// (set) Token: 0x0600051E RID: 1310 RVA: 0x0004C00C File Offset: 0x0004A20C
		public string WacnId
		{
			get
			{
				short num = (short)1360527360;
				short num2 = num;
				num = (short)1961033729;
				if (num != 0)
				{
				}
				num = (short)2103400101;
				short num3 = num;
				num = (short)1752782501;
				switch (num3 == num)
				{
				}
				num = (short)713949184;
				if (num != 0)
				{
				}
				return this.g;
			}
			set
			{
				short num = (short)930700900;
				short num2 = num;
				num = (short)650534500;
				switch (num2 == num)
				{
				}
				num = (short)1965096960;
				if (num != 0)
				{
				}
				num = (short)1380450305;
				if (num != 0)
				{
				}
				num = (short)160956416;
				short num3 = num;
				this.g = value;
			}
		}

		// Token: 0x1700024B RID: 587
		// (get) Token: 0x0600051F RID: 1311 RVA: 0x0004C0C0 File Offset: 0x0004A2C0
		// (set) Token: 0x06000520 RID: 1312 RVA: 0x0004C170 File Offset: 0x0004A370
		public string CustomSystemId
		{
			get
			{
				short num = (short)812950016;
				short num2 = num;
				num = (short)1779474944;
				switch (num2 == num)
				{
				}
				num = (short)172228609;
				if (num != 0)
				{
				}
				num = (short)1674772480;
				if (num != 0)
				{
				}
				num = (short)1906049024;
				short num3 = num;
				return this.h;
			}
			set
			{
				short num = (short)1643996617;
				short num2 = num;
				num = (short)2115331529;
				switch (num2 == num)
				{
				}
				num = (short)1600454657;
				if (num != 0)
				{
				}
				num = (short)1728970752;
				if (num != 0)
				{
				}
				num = (short)1837563904;
				short num3 = num;
				this.h = value;
			}
		}

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x06000521 RID: 1313 RVA: 0x0004C220 File Offset: 0x0004A420
		// (set) Token: 0x06000522 RID: 1314 RVA: 0x0004C2D0 File Offset: 0x0004A4D0
		public string CustomWacnId
		{
			get
			{
				short num = (short)71036196;
				short num2 = num;
				num = (short)1619389732;
				switch (num2 == num)
				{
				}
				num = (short)542572545;
				if (num != 0)
				{
				}
				num = (short)352124928;
				if (num != 0)
				{
				}
				num = (short)1674182656;
				short num3 = num;
				return this.i;
			}
			set
			{
				short num = (short)1395523585;
				if (num != 0)
				{
				}
				num = (short)1537461537;
				short num2 = num;
				num = (short)446549281;
				switch (num2 == num)
				{
				}
				num = (short)1757872128;
				if (num != 0)
				{
				}
				num = (short)1258160128;
				short num3 = num;
				this.i = value;
			}
		}

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x06000523 RID: 1315 RVA: 0x0004C380 File Offset: 0x0004A580
		// (set) Token: 0x06000524 RID: 1316 RVA: 0x0004C430 File Offset: 0x0004A630
		public int SystemTypeIndex
		{
			get
			{
				short num = (short)1648356339;
				short num2 = num;
				num = (short)534703091;
				switch (num2 == num)
				{
				}
				num = (short)497090561;
				if (num != 0)
				{
				}
				num = (short)904462336;
				if (num != 0)
				{
				}
				num = (short)1649016832;
				short num3 = num;
				return this.c;
			}
			set
			{
				short num = (short)736628572;
				short num2 = num;
				num = (short)894832476;
				switch (num2 == num)
				{
				}
				num = (short)51773441;
				if (num != 0)
				{
				}
				num = (short)1085014016;
				if (num != 0)
				{
				}
				num = (short)1738866688;
				short num3 = num;
				this.c = value;
			}
		}

		// Token: 0x1700024E RID: 590
		// (get) Token: 0x06000525 RID: 1317 RVA: 0x0004C4E4 File Offset: 0x0004A6E4
		// (set) Token: 0x06000526 RID: 1318 RVA: 0x0004C594 File Offset: 0x0004A794
		public int SystemNameIndex
		{
			get
			{
				short num = (short)877606171;
				short num2 = num;
				num = (short)1522414875;
				switch (num2 == num)
				{
				}
				num = (short)1883176961;
				if (num != 0)
				{
				}
				num = (short)857931776;
				if (num != 0)
				{
				}
				num = (short)701169664;
				short num3 = num;
				return this.d;
			}
			set
			{
				short num = (short)1736921986;
				short num2 = num;
				num = (short)1288655746;
				switch (num2 == num)
				{
				}
				num = (short)675020801;
				if (num != 0)
				{
				}
				num = (short)1953038336;
				if (num != 0)
				{
				}
				num = (short)1657274368;
				short num3 = num;
				this.d = value;
			}
		}

		// Token: 0x0400025A RID: 602
		private global::System.Collections.Generic.IList<string> a;

		// Token: 0x0400025B RID: 603
		private global::System.Collections.Generic.IList<string> b;

		// Token: 0x0400025C RID: 604
		private int c;

		// Token: 0x0400025D RID: 605
		private int d;

		// Token: 0x0400025E RID: 606
		private bool e;

		// Token: 0x0400025F RID: 607
		private string f;

		// Token: 0x04000260 RID: 608
		private string g;

		// Token: 0x04000261 RID: 609
		private string h;

		// Token: 0x04000262 RID: 610
		private string i;

		// Token: 0x04000263 RID: 611
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool j;

		// Token: 0x04000264 RID: 612
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool k;

		// Token: 0x04000265 RID: 613
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string l;

		// Token: 0x04000266 RID: 614
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string m;

		// Token: 0x04000267 RID: 615
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string n;

		// Token: 0x04000268 RID: 616
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool o;

		// Token: 0x04000269 RID: 617
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool p;
	}
}
