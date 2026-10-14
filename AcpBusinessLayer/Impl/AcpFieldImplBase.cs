using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AcpCommonLib;

namespace AcpBusinessLayer.Impl
{
	// Token: 0x02000061 RID: 97
	internal class AcpFieldImplBase
	{
		// Token: 0x06000538 RID: 1336 RVA: 0x0006F4D0 File Offset: 0x0006D6D0
		private AcpFieldImplBase()
		{
			this.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.FieldId = -1;
		}

		// Token: 0x06000539 RID: 1337 RVA: 0x0006F4F4 File Offset: 0x0006D6F4
		internal AcpFieldImplBase(string uiName) : this()
		{
			this.UIName = uiName;
			this.LegacyUINames = new global::System.Collections.Generic.HashSet<string>();
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x0600053A RID: 1338 RVA: 0x0006F51C File Offset: 0x0006D71C
		// (set) Token: 0x0600053B RID: 1339 RVA: 0x0006F5D0 File Offset: 0x0006D7D0
		internal string UIName
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)954859520;
				short num2 = num;
				num = (short)277601437;
				short num3 = num;
				num = (short)897768605;
				switch (num3 == num)
				{
				}
				num = (short)1545601025;
				if (num != 0)
				{
				}
				num = (short)355467264;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)2065563648;
				short num2 = num;
				num = (short)370047899;
				short num3 = num;
				num = (short)1009744795;
				switch (num3 == num)
				{
				}
				num = (short)13697025;
				if (num != 0)
				{
				}
				num = (short)1927348224;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x0600053C RID: 1340 RVA: 0x0006F680 File Offset: 0x0006D880
		// (set) Token: 0x0600053D RID: 1341 RVA: 0x0006F730 File Offset: 0x0006D930
		internal global::System.Collections.Generic.ISet<string> LegacyUINames
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1062600704;
				short num2 = num;
				num = (short)1182203905;
				if (num != 0)
				{
				}
				num = (short)1467231663;
				short num3 = num;
				num = (short)1229794735;
				switch (num3 == num)
				{
				}
				num = (short)624164864;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)340656128;
				short num2 = num;
				num = (short)1752521184;
				short num3 = num;
				num = (short)581851616;
				switch (num3 == num)
				{
				}
				num = (short)1823277057;
				if (num != 0)
				{
				}
				num = (short)1932066816;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x0600053E RID: 1342 RVA: 0x0006F7E0 File Offset: 0x0006D9E0
		// (set) Token: 0x0600053F RID: 1343 RVA: 0x0006F88C File Offset: 0x0006DA8C
		internal string NewUiExpanderAndName
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1466892288;
				short num2 = num;
				num = (short)817063157;
				short num3 = num;
				num = (short)624256245;
				switch (num3 == num)
				{
				}
				num = (short)1620377601;
				if (num != 0)
				{
				}
				num = (short)979304448;
				if (num != 0)
				{
				}
				return this.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1378746368;
				short num2 = num;
				num = (short)2078801921;
				if (num != 0)
				{
				}
				num = (short)1833074876;
				short num3 = num;
				num = (short)485982396;
				switch (num3 == num)
				{
				}
				num = (short)834732032;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x06000540 RID: 1344 RVA: 0x0006F940 File Offset: 0x0006DB40
		// (set) Token: 0x06000541 RID: 1345 RVA: 0x0006F9F0 File Offset: 0x0006DBF0
		internal string Name
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1554644992;
				short num2 = num;
				num = (short)772347990;
				short num3 = num;
				num = (short)1113659478;
				switch (num3 == num)
				{
				}
				num = (short)773128192;
				if (num != 0)
				{
				}
				num = (short)1862008833;
				if (num != 0)
				{
				}
				return this.d;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1424359424;
				short num2 = num;
				num = (short)95221830;
				short num3 = num;
				num = (short)1414854726;
				switch (num3 == num)
				{
				}
				num = (short)217448448;
				if (num != 0)
				{
				}
				num = (short)852951041;
				if (num != 0)
				{
				}
				this.d = value;
			}
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x06000542 RID: 1346 RVA: 0x0006FAA4 File Offset: 0x0006DCA4
		// (set) Token: 0x06000543 RID: 1347 RVA: 0x0006FB54 File Offset: 0x0006DD54
		internal global::AcpCommonLib.ValueSetterConstraint ValueSetter
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)518848512;
				short num2 = num;
				num = (short)519794683;
				short num3 = num;
				num = (short)521891835;
				switch (num3 == num)
				{
				}
				num = (short)782827521;
				if (num != 0)
				{
				}
				num = (short)152502272;
				if (num != 0)
				{
				}
				return this.e;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1639120896;
				short num2 = num;
				num = (short)250920424;
				short num3 = num;
				num = (short)1669053928;
				switch (num3 == num)
				{
				}
				num = (short)204668929;
				if (num != 0)
				{
				}
				num = (short)1153105920;
				if (num != 0)
				{
				}
				this.e = value;
			}
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x06000544 RID: 1348 RVA: 0x0006FC04 File Offset: 0x0006DE04
		// (set) Token: 0x06000545 RID: 1349 RVA: 0x0006FCB4 File Offset: 0x0006DEB4
		internal global::AcpCommonLib.StateConstraint IsValid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1507721216;
				short num2 = num;
				num = (short)546623921;
				short num3 = num;
				num = (short)1305006513;
				switch (num3 == num)
				{
				}
				num = (short)1033764865;
				if (num != 0)
				{
				}
				num = (short)7798784;
				if (num != 0)
				{
				}
				return this.f;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1742274560;
				short num2 = num;
				num = (short)2060736043;
				short num3 = num;
				num = (short)1048401451;
				switch (num3 == num)
				{
				}
				num = (short)838991872;
				if (num != 0)
				{
				}
				num = (short)1526136833;
				if (num != 0)
				{
				}
				this.f = value;
			}
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x06000546 RID: 1350 RVA: 0x0006FD64 File Offset: 0x0006DF64
		// (set) Token: 0x06000547 RID: 1351 RVA: 0x0006FE14 File Offset: 0x0006E014
		internal global::AcpCommonLib.StateConstraint IsApplicable
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)716570624;
				short num2 = num;
				num = (short)1270815087;
				short num3 = num;
				num = (short)1797855599;
				switch (num3 == num)
				{
				}
				num = (short)421986305;
				if (num != 0)
				{
				}
				num = (short)533594112;
				if (num != 0)
				{
				}
				return this.g;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1910505472;
				short num2 = num;
				num = (short)1307750247;
				short num3 = num;
				num = (short)89698151;
				switch (num3 == num)
				{
				}
				num = (short)76480512;
				if (num != 0)
				{
				}
				num = (short)1684537345;
				if (num != 0)
				{
				}
				this.g = value;
			}
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x06000548 RID: 1352 RVA: 0x0006FEC4 File Offset: 0x0006E0C4
		// (set) Token: 0x06000549 RID: 1353 RVA: 0x0006FF74 File Offset: 0x0006E174
		internal global::AcpCommonLib.StateConstraint IsVisible
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1853423616;
				short num2 = num;
				num = (short)1918959617;
				if (num != 0)
				{
				}
				num = (short)497093330;
				short num3 = num;
				num = (short)183241426;
				switch (num3 == num)
				{
				}
				num = (short)612892672;
				if (num != 0)
				{
				}
				return this.h;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1001914368;
				short num2 = num;
				num = (short)131118389;
				short num3 = num;
				num = (short)1226028341;
				switch (num3 == num)
				{
				}
				num = (short)825294849;
				if (num != 0)
				{
				}
				num = (short)327090176;
				if (num != 0)
				{
				}
				this.h = value;
			}
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x0600054A RID: 1354 RVA: 0x00070024 File Offset: 0x0006E224
		// (set) Token: 0x0600054B RID: 1355 RVA: 0x000700D8 File Offset: 0x0006E2D8
		internal global::AcpCommonLib.StateConstraint IsEditable
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1831337984;
				short num2 = num;
				num = (short)1201733633;
				if (num != 0)
				{
				}
				num = (short)1798020957;
				short num3 = num;
				num = (short)221552477;
				switch (num3 == num)
				{
				}
				num = (short)1031471104;
				if (num != 0)
				{
				}
				return this.i;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)925630464;
				short num2 = num;
				num = (short)1028084597;
				short num3 = num;
				num = (short)887051125;
				switch (num3 == num)
				{
				}
				num = (short)52690945;
				if (num != 0)
				{
				}
				num = (short)592773120;
				if (num != 0)
				{
				}
				this.i = value;
			}
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x0600054C RID: 1356 RVA: 0x00070188 File Offset: 0x0006E388
		// (set) Token: 0x0600054D RID: 1357 RVA: 0x00070238 File Offset: 0x0006E438
		internal global::AcpCommonLib.DifferentiatedUserViewType DifferentiatedUserView
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)696909824;
				short num2 = num;
				num = (short)2093473415;
				short num3 = num;
				num = (short)1033821831;
				switch (num3 == num)
				{
				}
				num = (short)485359617;
				if (num != 0)
				{
				}
				num = (short)993984512;
				if (num != 0)
				{
				}
				return this.j;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1280442368;
				short num2 = num;
				num = (short)338331492;
				short num3 = num;
				num = (short)762283876;
				switch (num3 == num)
				{
				}
				num = (short)326434817;
				if (num != 0)
				{
				}
				num = (short)389283840;
				if (num != 0)
				{
				}
				this.j = value;
			}
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x0600054E RID: 1358 RVA: 0x000702EC File Offset: 0x0006E4EC
		// (set) Token: 0x0600054F RID: 1359 RVA: 0x0007039C File Offset: 0x0006E59C
		internal bool TieredOut
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)697630720;
				short num2 = num;
				num = (short)1489459440;
				short num3 = num;
				num = (short)145447152;
				switch (num3 == num)
				{
				}
				num = (short)393217;
				if (num != 0)
				{
				}
				num = (short)838533120;
				if (num != 0)
				{
				}
				return this.k;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1514668032;
				short num2 = num;
				num = (short)1374928452;
				short num3 = num;
				num = (short)404733508;
				switch (num3 == num)
				{
				}
				num = (short)1465712641;
				if (num != 0)
				{
				}
				num = (short)990314496;
				if (num != 0)
				{
				}
				this.k = value;
			}
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x06000550 RID: 1360 RVA: 0x0007044C File Offset: 0x0006E64C
		// (set) Token: 0x06000551 RID: 1361 RVA: 0x00070500 File Offset: 0x0006E700
		internal bool DefaultSetByTiering
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1406271488;
				short num2 = num;
				num = (short)4947126;
				short num3 = num;
				num = (short)2057993398;
				switch (num3 == num)
				{
				}
				num = (short)505020417;
				if (num != 0)
				{
				}
				num = (short)878837760;
				if (num != 0)
				{
				}
				return this.l;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)171704320;
				short num2 = num;
				num = (short)36372481;
				if (num != 0)
				{
				}
				num = (short)1628666185;
				short num3 = num;
				num = (short)859666761;
				switch (num3 == num)
				{
				}
				num = (short)1894449152;
				if (num != 0)
				{
				}
				this.l = value;
			}
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x06000552 RID: 1362 RVA: 0x000705B0 File Offset: 0x0006E7B0
		// (set) Token: 0x06000553 RID: 1363 RVA: 0x00070660 File Offset: 0x0006E860
		internal int GuiVersion
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1132658688;
				short num2 = num;
				num = (short)1027640160;
				short num3 = num;
				num = (short)459049824;
				switch (num3 == num)
				{
				}
				num = (short)855310336;
				if (num != 0)
				{
				}
				num = (short)1214119937;
				if (num != 0)
				{
				}
				return this.m;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)316801024;
				short num2 = num;
				num = (short)1499267073;
				if (num != 0)
				{
				}
				num = (short)667223005;
				short num3 = num;
				num = (short)38470621;
				switch (num3 == num)
				{
				}
				num = (short)135790592;
				if (num != 0)
				{
				}
				this.m = value;
			}
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x06000554 RID: 1364 RVA: 0x00070710 File Offset: 0x0006E910
		// (set) Token: 0x06000555 RID: 1365 RVA: 0x000707C0 File Offset: 0x0006E9C0
		internal int DataTransferOrder
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)420478976;
				short num2 = num;
				num = (short)1945792199;
				short num3 = num;
				num = (short)638676679;
				switch (num3 == num)
				{
				}
				num = (short)820445185;
				if (num != 0)
				{
				}
				num = (short)2038759424;
				if (num != 0)
				{
				}
				return this.n;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1112014848;
				short num2 = num;
				num = (short)1082491923;
				short num3 = num;
				num = (short)2034598931;
				switch (num3 == num)
				{
				}
				num = (short)1460011009;
				if (num != 0)
				{
				}
				num = (short)297009152;
				if (num != 0)
				{
				}
				this.n = value;
			}
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x06000556 RID: 1366 RVA: 0x00070870 File Offset: 0x0006EA70
		// (set) Token: 0x06000557 RID: 1367 RVA: 0x00070924 File Offset: 0x0006EB24
		internal int FieldId
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)455606272;
				short num2 = num;
				num = (short)543163174;
				short num3 = num;
				num = (short)1380516646;
				switch (num3 == num)
				{
				}
				num = (short)1453785088;
				if (num != 0)
				{
				}
				num = (short)50593793;
				if (num != 0)
				{
				}
				return this.o;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1464729600;
				short num2 = num;
				num = (short)1045577432;
				short num3 = num;
				num = (short)1859141336;
				switch (num3 == num)
				{
				}
				num = (short)2071855105;
				if (num != 0)
				{
				}
				num = (short)1403387904;
				if (num != 0)
				{
				}
				this.o = value;
			}
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x06000558 RID: 1368 RVA: 0x000709D4 File Offset: 0x0006EBD4
		// (set) Token: 0x06000559 RID: 1369 RVA: 0x00070A84 File Offset: 0x0006EC84
		internal bool Protected
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1208352768;
				short num2 = num;
				num = (short)2099823167;
				short num3 = num;
				num = (short)1797243455;
				switch (num3 == num)
				{
				}
				num = (short)699269121;
				if (num != 0)
				{
				}
				num = (short)1075838976;
				if (num != 0)
				{
				}
				return this.p;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1008664576;
				short num2 = num;
				num = (short)688036103;
				short num3 = num;
				num = (short)2029885703;
				switch (num3 == num)
				{
				}
				num = (short)464650241;
				if (num != 0)
				{
				}
				num = (short)1867317248;
				if (num != 0)
				{
				}
				this.p = value;
			}
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x0600055A RID: 1370 RVA: 0x00070B38 File Offset: 0x0006ED38
		// (set) Token: 0x0600055B RID: 1371 RVA: 0x00070BE4 File Offset: 0x0006EDE4
		internal bool IgnoreOnCompare
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)518193152;
				short num2 = num;
				num = (short)237177897;
				short num3 = num;
				num = (short)938282025;
				switch (num3 == num)
				{
				}
				num = (short)629735425;
				if (num != 0)
				{
				}
				num = (short)987234304;
				if (num != 0)
				{
				}
				return this.q;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1241710592;
				short num2 = num;
				num = (short)60177866;
				short num3 = num;
				num = (short)593903050;
				switch (num3 == num)
				{
				}
				num = (short)490668032;
				if (num != 0)
				{
				}
				num = (short)282329089;
				if (num != 0)
				{
				}
				this.q = value;
			}
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x0600055C RID: 1372 RVA: 0x00070C94 File Offset: 0x0006EE94
		// (set) Token: 0x0600055D RID: 1373 RVA: 0x00070D44 File Offset: 0x0006EF44
		internal bool IgnoreOnPrint
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1558773760;
				short num2 = num;
				num = (short)277154352;
				short num3 = num;
				num = (short)864356912;
				switch (num3 == num)
				{
				}
				num = (short)1522597889;
				if (num != 0)
				{
				}
				num = (short)1918959616;
				if (num != 0)
				{
				}
				return this.r;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)839778304;
				short num2 = num;
				num = (short)1592050607;
				short num3 = num;
				num = (short)343131055;
				switch (num3 == num)
				{
				}
				num = (short)1639514113;
				if (num != 0)
				{
				}
				num = (short)1050411008;
				if (num != 0)
				{
				}
				this.r = value;
			}
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x0600055E RID: 1374 RVA: 0x00070DF8 File Offset: 0x0006EFF8
		// (set) Token: 0x0600055F RID: 1375 RVA: 0x00070EA4 File Offset: 0x0006F0A4
		internal bool IsMasked
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1473183744;
				short num2 = num;
				num = (short)1955594241;
				if (num != 0)
				{
				}
				num = (short)1225743501;
				short num3 = num;
				num = (short)1383095437;
				switch (num3 == num)
				{
				}
				num = (short)391839744;
				if (num != 0)
				{
				}
				return this.s;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1307639808;
				short num2 = num;
				num = (short)221006329;
				short num3 = num;
				num = (short)233720313;
				switch (num3 == num)
				{
				}
				num = (short)596770817;
				if (num != 0)
				{
				}
				num = (short)806420480;
				if (num != 0)
				{
				}
				this.s = value;
			}
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x06000560 RID: 1376 RVA: 0x00070F58 File Offset: 0x0006F158
		// (set) Token: 0x06000561 RID: 1377 RVA: 0x00071008 File Offset: 0x0006F208
		internal bool CustomViewVisibility
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1666646016;
				short num2 = num;
				num = (short)1992394060;
				short num3 = num;
				num = (short)186811724;
				switch (num3 == num)
				{
				}
				num = (short)1133314049;
				if (num != 0)
				{
				}
				num = (short)1868169216;
				if (num != 0)
				{
				}
				return this.t;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)453574656;
				short num2 = num;
				num = (short)1484522712;
				short num3 = num;
				num = (short)718341336;
				switch (num3 == num)
				{
				}
				num = (short)1348403201;
				if (num != 0)
				{
				}
				num = (short)578289664;
				if (num != 0)
				{
				}
				this.t = value;
			}
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x06000562 RID: 1378 RVA: 0x000710B8 File Offset: 0x0006F2B8
		// (set) Token: 0x06000563 RID: 1379 RVA: 0x00071164 File Offset: 0x0006F364
		internal bool KeyNameField
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1416167424;
				short num2 = num;
				num = (short)915222241;
				short num3 = num;
				num = (short)871706337;
				switch (num3 == num)
				{
				}
				num = (short)1959002113;
				if (num != 0)
				{
				}
				num = (short)232718336;
				if (num != 0)
				{
				}
				return this.u;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1142882304;
				short num2 = num;
				num = (short)808614111;
				short num3 = num;
				num = (short)2073262303;
				switch (num3 == num)
				{
				}
				num = (short)1039204353;
				if (num != 0)
				{
				}
				num = (short)422576128;
				if (num != 0)
				{
				}
				this.u = value;
			}
		}

		// Token: 0x04000179 RID: 377
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string a;

		// Token: 0x0400017A RID: 378
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Collections.Generic.ISet<string> b;

		// Token: 0x0400017B RID: 379
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string c;

		// Token: 0x0400017C RID: 380
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string d;

		// Token: 0x0400017D RID: 381
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::AcpCommonLib.ValueSetterConstraint e;

		// Token: 0x0400017E RID: 382
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::AcpCommonLib.StateConstraint f;

		// Token: 0x0400017F RID: 383
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::AcpCommonLib.StateConstraint g;

		// Token: 0x04000180 RID: 384
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::AcpCommonLib.StateConstraint h;

		// Token: 0x04000181 RID: 385
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::AcpCommonLib.StateConstraint i;

		// Token: 0x04000182 RID: 386
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::AcpCommonLib.DifferentiatedUserViewType j;

		// Token: 0x04000183 RID: 387
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool k;

		// Token: 0x04000184 RID: 388
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool l;

		// Token: 0x04000185 RID: 389
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private int m;

		// Token: 0x04000186 RID: 390
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private int n;

		// Token: 0x04000187 RID: 391
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private int o;

		// Token: 0x04000188 RID: 392
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool p;

		// Token: 0x04000189 RID: 393
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool q;

		// Token: 0x0400018A RID: 394
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool r;

		// Token: 0x0400018B RID: 395
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool s;

		// Token: 0x0400018C RID: 396
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool t;

		// Token: 0x0400018D RID: 397
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool u;
	}
}
