using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using AcpBusinessLayer;
using AcpCommonLib;
using AcpCommonLib.UndoRedo;
using Motorola.Acp.PackUnpack.Ish.Collections;

namespace Motorola.Acp.PackUnpack.Ish.DataExchange
{
	// Token: 0x02000090 RID: 144
	internal class VoiceFileFieldAdapter : global::AcpCommonLib.IAcpRecordset, global::AcpCommonLib.IAcpConstraints, global::AcpCommonLib.IAcpCommon, global::System.IDisposable, global::AcpCommonLib.IAcpFeatureNode, global::AcpCommonLib.IAcpFeatureSection, global::AcpCommonLib.IAcpField, global::System.IComparable
	{
		// Token: 0x060004D2 RID: 1234 RVA: 0x0005402C File Offset: 0x0005222C
		internal VoiceFileFieldAdapter(global::AcpBusinessLayer.AcpVoiceFileField A_0)
		{
			this.field = A_0;
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x060004D3 RID: 1235 RVA: 0x00054048 File Offset: 0x00052248
		internal global::AcpBusinessLayer.AcpVoiceFileField VoiceFileField
		{
			get
			{
				short num = (short)699858944;
				short num2 = num;
				num = (short)1588668454;
				short num3 = num;
				num = (short)850077734;
				switch (num3 == num)
				{
				}
				num = (short)76611585;
				if (num != 0)
				{
				}
				num = (short)1299382272;
				if (num != 0)
				{
				}
				return this.field;
			}
		}

		// Token: 0x060004D4 RID: 1236 RVA: 0x000540F8 File Offset: 0x000522F8
		void global::AcpCommonLib.IAcpRecordset.b()
		{
			short num = (short)1002635264;
			short num2 = num;
			num = (short)2018550656;
			short num3 = num;
			num = (short)436970368;
			switch (num3 == num)
			{
			}
			num = (short)3932161;
			if (num != 0)
			{
			}
			num = (short)690618368;
			if (num != 0)
			{
			}
		}

		// Token: 0x060004D5 RID: 1237 RVA: 0x000541A0 File Offset: 0x000523A0
		void global::AcpCommonLib.IAcpRecordset.c()
		{
			short num = (short)273743872;
			short num2 = num;
			num = (short)1678835713;
			if (num != 0)
			{
			}
			num = (short)527314991;
			short num3 = num;
			num = (short)1532178479;
			switch (num3 == num)
			{
			}
			num = (short)29687808;
			if (num != 0)
			{
			}
			this.field.VoiceData.Position = 0L;
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x060004D6 RID: 1238 RVA: 0x00054260 File Offset: 0x00052460
		int global::AcpCommonLib.IAcpRecordset.RecsetId
		{
			get
			{
				short num = (short)1698168832;
				short num2 = num;
				num = (short)983727025;
				short num3 = num;
				num = (short)290225073;
				switch (num3 == num)
				{
				}
				num = (short)1055784961;
				if (num != 0)
				{
				}
				num = (short)1790443520;
				if (num != 0)
				{
				}
				return this.field.Parent.Parent.Parent.RecsetId;
			}
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x060004D7 RID: 1239 RVA: 0x00054324 File Offset: 0x00052524
		string global::AcpCommonLib.IAcpRecordset.RecordsetName
		{
			get
			{
				short num = (short)1191247872;
				short num2 = num;
				num = (short)139226256;
				short num3 = num;
				num = (short)2101898384;
				switch (num3 == num)
				{
				}
				num = (short)770113537;
				if (num != 0)
				{
				}
				num = (short)157483008;
				if (num != 0)
				{
				}
				return this.field.Parent.Parent.Parent.RecordsetName;
			}
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x060004D8 RID: 1240 RVA: 0x000543E8 File Offset: 0x000525E8
		bool global::AcpCommonLib.IAcpRecordset.SingleInstance
		{
			get
			{
				short num = (short)114098176;
				short num2 = num;
				num = (short)575378143;
				short num3 = num;
				num = (short)193762015;
				switch (num3 == num)
				{
				}
				num = (short)1265238017;
				if (num != 0)
				{
				}
				num = (short)1249968128;
				if (num != 0)
				{
				}
				return this.field.Parent.Parent.Parent.SingleInstance;
			}
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x060004D9 RID: 1241 RVA: 0x000544AC File Offset: 0x000526AC
		string global::AcpCommonLib.IAcpRecordset.UIPagePath
		{
			get
			{
				short num = (short)1305280512;
				short num2 = num;
				num = (short)1267478861;
				short num3 = num;
				num = (short)540488013;
				switch (num3 == num)
				{
				}
				num = (short)1677262849;
				if (num != 0)
				{
				}
				num = (short)1631584256;
				if (num != 0)
				{
				}
				return this.field.Parent.Parent.Parent.UIPagePath;
			}
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x060004DA RID: 1242 RVA: 0x00054570 File Offset: 0x00052770
		int global::AcpCommonLib.IAcpRecordset.Count
		{
			get
			{
				short num = (short)1965228032;
				short num2 = num;
				num = (short)1672977755;
				short num3 = num;
				num = (short)1687133531;
				switch (num3 == num)
				{
				}
				num = (short)1688666113;
				if (num != 0)
				{
				}
				num = (short)890503168;
				if (num != 0)
				{
				}
				return (int)this.field.VoiceData.Length;
			}
		}

		// Token: 0x060004DB RID: 1243 RVA: 0x00054628 File Offset: 0x00052828
		global::AcpCommonLib.IAcpFeatureNode global::AcpCommonLib.IAcpRecordset.i()
		{
			short num = (short)476512256;
			short num2 = num;
			num = (short)866385921;
			if (num != 0)
			{
			}
			num = (short)65698344;
			short num3 = num;
			num = (short)1597536808;
			switch (num3 == num)
			{
			}
			num = (short)235667456;
			if (num != 0)
			{
			}
			this.field.VoiceData.WriteByte(0);
			return this;
		}

		// Token: 0x060004DC RID: 1244 RVA: 0x000546E4 File Offset: 0x000528E4
		int global::AcpCommonLib.IAcpRecordset.a(int A_0)
		{
			int a_ = 8;
			short num = (short)909574145;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				int num3;
				switch (num2)
				{
				case 0:
					return A_0;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_45;
					}
					continue;
				case 2:
					goto IL_113;
				case 3:
					goto IL_60;
				case 4:
				{
					if (num3 >= A_0)
					{
						num = (short)126418944;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1576599552;
					short num4 = num;
					num = (short)1421410305;
					if (num != 0)
					{
					}
					this.field.VoiceData.WriteByte(0);
					num3++;
					num = (short)2026504194;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 5:
					goto IL_113;
				}
				IL_45:
				if (A_0 <= 0)
				{
					num = (short)1432616963;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_E4:
				num3 = 0;
				num = (short)124321797;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_113:
				num = (short)140232615;
				short num5 = num;
				num = (short)1625999271;
				switch ((num5 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_E4;
				default:
					num = (short)1278345216;
					if (num != 0)
					{
					}
					num = (short)1707278340;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_60:
			throw new global::System.ArgumentOutOfRangeException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("ﲞ캠횢쮤펦", a_));
		}

		// Token: 0x060004DD RID: 1245 RVA: 0x00054888 File Offset: 0x00052A88
		void global::AcpCommonLib.IAcpRecordset.b(int A_0)
		{
			short num = (short)162267136;
			short num2 = num;
			num = (short)139400057;
			short num3 = num;
			num = (short)1690637177;
			switch (num3 == num)
			{
			}
			num = (short)317063169;
			if (num != 0)
			{
			}
			num = (short)351404032;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x060004DE RID: 1246 RVA: 0x00054938 File Offset: 0x00052B38
		void global::AcpCommonLib.IAcpRecordset.a(int A_0, int A_1)
		{
			short num = (short)553254912;
			short num2 = num;
			num = (short)1612052588;
			short num3 = num;
			num = (short)755431532;
			switch (num3 == num)
			{
			}
			num = (short)1203044353;
			if (num != 0)
			{
			}
			num = (short)1413087232;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x17000152 RID: 338
		global::AcpCommonLib.IAcpFeatureNode global::AcpCommonLib.IAcpRecordset.this[int A_0]
		{
			get
			{
				int a_ = 4;
				short num = (short)466458121;
				short num2 = num;
				num = (short)1912247817;
				int num4;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
				{
					IL_F8:
					num = (short)1977679872;
					short num3 = num;
					if ((long)A_0 <= this.field.VoiceData.Position)
					{
						goto IL_14F;
					}
					num = (short)729743363;
					num4 = (int)((global::System.IntPtr)num);
					break;
				}
				default:
					num = (short)2050031617;
					if (num != 0)
					{
					}
					num = (short)1919156224;
					if (num != 0)
					{
					}
					num = (short)657981440;
					num4 = (int)((global::System.IntPtr)num);
					break;
				}
				for (;;)
				{
					switch (num4)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_B2;
						}
						continue;
					case 1:
						goto IL_F8;
					case 2:
						num = (short)1965359105;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_14D;
					}
					IL_B2:
					if (A_0 >= 0)
					{
						goto IL_14F;
					}
					num = (short)1757347842;
					num4 = (int)((global::System.IntPtr)num);
				}
				IL_14D:
				throw new global::System.ArgumentOutOfRangeException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("ﮞ쒠\udba2", a_));
				IL_14F:
				this.field.VoiceData.Position = (long)A_0;
				return this;
			}
		}

		// Token: 0x060004E0 RID: 1248 RVA: 0x00054B54 File Offset: 0x00052D54
		int global::AcpCommonLib.IAcpRecordset.a(global::AcpCommonLib.IAcpFeatureNode A_0)
		{
			short num = (short)2126839809;
			if (num != 0)
			{
			}
			num = (short)1357988446;
			short num2 = num;
			num = (short)659112542;
			switch (num2 == num)
			{
			}
			num = (short)532545536;
			short num3 = num;
			num = (short)1036713984;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x060004E1 RID: 1249 RVA: 0x00054C04 File Offset: 0x00052E04
		global::AcpCommonLib.IAcpFeatureNode global::AcpCommonLib.IAcpRecordset.d(int A_0)
		{
			short num = (short)524646965;
			short num2 = num;
			num = (short)2019326517;
			switch (num2 == num)
			{
			}
			num = (short)151781376;
			if (num != 0)
			{
			}
			num = (short)2138767360;
			short num3 = num;
			num = (short)1591148545;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x060004E2 RID: 1250 RVA: 0x00054CB0 File Offset: 0x00052EB0
		global::AcpCommonLib.IAcpFeatureNode global::AcpCommonLib.IAcpRecordset.a(string A_0)
		{
			short num = (short)1437663233;
			if (num != 0)
			{
			}
			num = (short)57688110;
			short num2 = num;
			num = (short)996818990;
			switch (num2 == num)
			{
			}
			num = (short)1966276608;
			short num3 = num;
			num = (short)161742848;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x060004E3 RID: 1251 RVA: 0x00054D5C File Offset: 0x00052F5C
		bool global::AcpCommonLib.IAcpRecordset.HasEmbeddedRecset
		{
			get
			{
				short num = (short)661437853;
				short num2 = num;
				num = (short)1886436765;
				switch (num2 == num)
				{
				}
				num = (short)644087809;
				if (num != 0)
				{
				}
				num = (short)1634598912;
				short num3 = num;
				num = (short)129892352;
				if (num != 0)
				{
				}
				return false;
			}
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x060004E4 RID: 1252 RVA: 0x00054E04 File Offset: 0x00053004
		bool global::AcpCommonLib.IAcpRecordset.IsEmbeddedRecset
		{
			get
			{
				short num = (short)146340265;
				short num2 = num;
				num = (short)369555881;
				switch (num2 == num)
				{
				}
				num = (short)1159987200;
				if (num != 0)
				{
				}
				num = (short)948764672;
				short num3 = num;
				num = (short)444006401;
				if (num != 0)
				{
				}
				return false;
			}
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x060004E5 RID: 1253 RVA: 0x00054EB0 File Offset: 0x000530B0
		bool global::AcpCommonLib.IAcpRecordset.HasKeyField
		{
			get
			{
				short num = (short)690921140;
				short num2 = num;
				num = (short)2033491636;
				switch (num2 == num)
				{
				}
				num = (short)1096155137;
				if (num != 0)
				{
				}
				num = (short)1070530560;
				short num3 = num;
				num = (short)781320192;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x060004E6 RID: 1254 RVA: 0x00054F60 File Offset: 0x00053160
		global::AcpCommonLib.IAcpFeatureSection global::AcpCommonLib.IAcpRecordset.ParentSection
		{
			get
			{
				short num = (short)494314646;
				short num2 = num;
				num = (short)1749722262;
				switch (num2 == num)
				{
				}
				num = (short)701104128;
				if (num != 0)
				{
				}
				num = (short)435355648;
				short num3 = num;
				num = (short)1432748033;
				if (num != 0)
				{
				}
				return null;
			}
		}

		// Token: 0x060004E7 RID: 1255 RVA: 0x00055008 File Offset: 0x00053208
		global::System.Collections.Generic.IEnumerable<global::AcpCommonLib.IAcpField> global::AcpCommonLib.IAcpRecordset.b(string A_0)
		{
			short num = (short)1128977290;
			short num2 = num;
			num = (short)2127025034;
			switch (num2 == num)
			{
			}
			num = (short)53739521;
			if (num != 0)
			{
			}
			num = (short)1240662016;
			short num3 = num;
			num = (short)669843456;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x060004E8 RID: 1256 RVA: 0x000550B4 File Offset: 0x000532B4
		global::System.Collections.Generic.IEnumerable<global::AcpCommonLib.IAcpField> global::AcpCommonLib.IAcpRecordset.c(string A_0)
		{
			short num = (short)416374627;
			short num2 = num;
			num = (short)1817730915;
			switch (num2 == num)
			{
			}
			num = (short)671481857;
			if (num != 0)
			{
			}
			num = (short)644808704;
			short num3 = num;
			num = (short)372703232;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x060004E9 RID: 1257 RVA: 0x00055164 File Offset: 0x00053364
		bool global::AcpCommonLib.IAcpRecordset.a(global::System.Xml.XmlNode A_0, global::AcpCommonLib.XmlFileType A_1)
		{
			short num = (short)1975844157;
			short num2 = num;
			num = (short)629931325;
			switch (num2 == num)
			{
			}
			num = (short)539623424;
			if (num != 0)
			{
			}
			num = (short)420937728;
			short num3 = num;
			num = (short)967770113;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x060004EA RID: 1258 RVA: 0x00055210 File Offset: 0x00053410
		bool global::AcpCommonLib.IAcpRecordset.a(global::System.Xml.XmlNode A_0, global::AcpCommonLib.UndoRedo.ContainerTask A_1, global::AcpCommonLib.XmlFileType A_2, bool A_3, global::System.Collections.Generic.Dictionary<global::AcpCommonLib.IAcpField, string> A_4, global::System.Collections.Generic.Dictionary<global::AcpCommonLib.IAcpField, string> A_5)
		{
			short num = (short)1635209578;
			short num2 = num;
			num = (short)1885032810;
			switch (num2 == num)
			{
			}
			num = (short)1131020288;
			if (num != 0)
			{
			}
			num = (short)838664192;
			short num3 = num;
			num = (short)203882497;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x060004EB RID: 1259 RVA: 0x000552BC File Offset: 0x000534BC
		void global::AcpCommonLib.IAcpRecordset.a(global::AcpCommonLib.IAcpRecordset A_0, global::AcpCommonLib.UndoRedo.ContainerTask A_1)
		{
			short num = (short)1723742685;
			short num2 = num;
			num = (short)1367423453;
			switch (num2 == num)
			{
			}
			num = (short)789839873;
			if (num != 0)
			{
			}
			num = (short)800391168;
			short num3 = num;
			num = (short)2091450368;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x060004EC RID: 1260 RVA: 0x0005536C File Offset: 0x0005356C
		// (set) Token: 0x060004ED RID: 1261 RVA: 0x0005541C File Offset: 0x0005361C
		string global::AcpCommonLib.IAcpRecordset.UIName
		{
			get
			{
				short num = (short)1741684737;
				if (num != 0)
				{
				}
				num = (short)1286955662;
				short num2 = num;
				num = (short)317219470;
				switch (num2 == num)
				{
				}
				num = (short)882638848;
				short num3 = num;
				num = (short)1313669120;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
			set
			{
				short num = (short)685319843;
				short num2 = num;
				num = (short)495593123;
				switch (num2 == num)
				{
				}
				num = (short)555155457;
				if (num != 0)
				{
				}
				num = (short)855375872;
				short num3 = num;
				num = (short)1273298944;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x060004EE RID: 1262 RVA: 0x000554C8 File Offset: 0x000536C8
		global::AcpCommonLib.IAcpField global::AcpCommonLib.IAcpRecordset.a(string A_0, string A_1)
		{
			short num = (short)1558348825;
			short num2 = num;
			num = (short)1567196185;
			switch (num2 == num)
			{
			}
			num = (short)380895233;
			if (num != 0)
			{
			}
			num = (short)732954624;
			short num3 = num;
			num = (short)1693384704;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x060004EF RID: 1263 RVA: 0x00055574 File Offset: 0x00053774
		global::AcpCommonLib.IAcpField global::AcpCommonLib.IAcpRecordset.b(string A_0, string A_1)
		{
			short num = (short)1000134941;
			short num2 = num;
			num = (short)1133828381;
			switch (num2 == num)
			{
			}
			num = (short)585039873;
			if (num != 0)
			{
			}
			num = (short)592576512;
			short num3 = num;
			num = (short)517210112;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x060004F0 RID: 1264 RVA: 0x00055624 File Offset: 0x00053824
		void global::AcpCommonLib.IAcpRecordset.a(global::AcpCommonLib.IAcpRecordset A_0)
		{
			short num = (short)1128458567;
			short num2 = num;
			num = (short)748218695;
			switch (num2 == num)
			{
			}
			num = (short)1545011201;
			if (num != 0)
			{
			}
			num = (short)11272192;
			short num3 = num;
			num = (short)417529856;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x060004F1 RID: 1265 RVA: 0x000556D0 File Offset: 0x000538D0
		// (set) Token: 0x060004F2 RID: 1266 RVA: 0x00055780 File Offset: 0x00053980
		int global::AcpCommonLib.IAcpRecordset.DataTransferOrder
		{
			get
			{
				short num = (short)1402345268;
				short num2 = num;
				num = (short)1691490100;
				switch (num2 == num)
				{
				}
				num = (short)1570504704;
				if (num != 0)
				{
				}
				num = (short)880279552;
				short num3 = num;
				num = (short)1138622465;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
			set
			{
				short num = (short)1725543903;
				short num2 = num;
				num = (short)611497439;
				switch (num2 == num)
				{
				}
				num = (short)10682369;
				if (num != 0)
				{
				}
				num = (short)1710948352;
				short num3 = num;
				num = (short)998965248;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x060004F3 RID: 1267 RVA: 0x0005582C File Offset: 0x00053A2C
		// (set) Token: 0x060004F4 RID: 1268 RVA: 0x000558DC File Offset: 0x00053ADC
		global::AcpCommonLib.Document global::AcpCommonLib.IAcpRecordset.ContainerDoc
		{
			get
			{
				short num = (short)1672594191;
				short num2 = num;
				num = (short)1440006927;
				switch (num2 == num)
				{
				}
				num = (short)762970113;
				if (num != 0)
				{
				}
				num = (short)221577216;
				short num3 = num;
				num = (short)604635136;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
			set
			{
				short num = (short)240185778;
				short num2 = num;
				num = (short)1057812914;
				switch (num2 == num)
				{
				}
				num = (short)529203200;
				if (num != 0)
				{
				}
				num = (short)1177550848;
				short num3 = num;
				num = (short)1743454209;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x060004F5 RID: 1269 RVA: 0x0005598C File Offset: 0x00053B8C
		// (set) Token: 0x060004F6 RID: 1270 RVA: 0x00055A3C File Offset: 0x00053C3C
		int global::AcpCommonLib.IAcpRecordset.Min
		{
			get
			{
				short num = (short)1203621504;
				short num2 = num;
				num = (short)1173147264;
				switch (num2 == num)
				{
				}
				num = (short)1586495488;
				if (num != 0)
				{
				}
				num = (short)15400960;
				short num3 = num;
				num = (short)2118320129;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
			set
			{
				short num = (short)1865351169;
				if (num != 0)
				{
				}
				num = (short)950522433;
				short num2 = num;
				num = (short)944689729;
				switch (num2 == num)
				{
				}
				num = (short)679542784;
				short num3 = num;
				num = (short)1508966400;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x060004F7 RID: 1271 RVA: 0x00055AEC File Offset: 0x00053CEC
		// (set) Token: 0x060004F8 RID: 1272 RVA: 0x00055B9C File Offset: 0x00053D9C
		int global::AcpCommonLib.IAcpRecordset.Max
		{
			get
			{
				short num = (short)1554498621;
				short num2 = num;
				num = (short)1051575357;
				switch (num2 == num)
				{
				}
				num = (short)483328000;
				if (num != 0)
				{
				}
				num = (short)471859200;
				short num3 = num;
				num = (short)1652621313;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
			set
			{
				short num = (short)835125512;
				short num2 = num;
				num = (short)1821573384;
				switch (num2 == num)
				{
				}
				num = (short)1494810624;
				if (num != 0)
				{
				}
				num = (short)619905024;
				short num3 = num;
				num = (short)1569456129;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x060004F9 RID: 1273 RVA: 0x00055C48 File Offset: 0x00053E48
		int global::AcpCommonLib.IAcpRecordset.CounterToMax
		{
			get
			{
				short num = (short)368011230;
				short num2 = num;
				num = (short)979855326;
				switch (num2 == num)
				{
				}
				num = (short)817561600;
				if (num != 0)
				{
				}
				num = (short)1987641344;
				short num3 = num;
				num = (short)709689345;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x060004FA RID: 1274 RVA: 0x00055CF8 File Offset: 0x00053EF8
		int global::AcpCommonLib.IAcpRecordset.CounterToMin
		{
			get
			{
				short num = (short)146283632;
				short num2 = num;
				num = (short)579542128;
				switch (num2 == num)
				{
				}
				num = (short)568131585;
				if (num != 0)
				{
				}
				num = (short)1494220800;
				short num3 = num;
				num = (short)585695232;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x060004FB RID: 1275 RVA: 0x00055DA8 File Offset: 0x00053FA8
		bool global::AcpCommonLib.IAcpRecordset.CanBeEmpty
		{
			get
			{
				short num = (short)1100362927;
				short num2 = num;
				num = (short)724251823;
				switch (num2 == num)
				{
				}
				num = (short)653393920;
				if (num != 0)
				{
				}
				num = (short)453771264;
				short num3 = num;
				num = (short)1391656961;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x060004FC RID: 1276 RVA: 0x00055E5C File Offset: 0x0005405C
		bool global::AcpCommonLib.IAcpRecordset.PositionBased
		{
			get
			{
				short num = (short)1147994113;
				if (num != 0)
				{
				}
				num = (short)552154039;
				short num2 = num;
				num = (short)573715383;
				switch (num2 == num)
				{
				}
				num = (short)278200320;
				short num3 = num;
				num = (short)2007171072;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x060004FD RID: 1277 RVA: 0x00055F08 File Offset: 0x00054108
		string global::AcpCommonLib.IAcpRecordset.e(string A_0)
		{
			short num = (short)1115004362;
			short num2 = num;
			num = (short)554737098;
			switch (num2 == num)
			{
			}
			num = (short)73400321;
			if (num != 0)
			{
			}
			num = (short)1093992448;
			short num3 = num;
			num = (short)545521664;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x060004FE RID: 1278 RVA: 0x00055FB8 File Offset: 0x000541B8
		bool global::AcpCommonLib.IAcpRecordset.b(int A_0, int A_1)
		{
			short num = (short)603028431;
			short num2 = num;
			num = (short)1238006735;
			switch (num2 == num)
			{
			}
			num = (short)807141377;
			if (num != 0)
			{
			}
			num = (short)949288960;
			short num3 = num;
			num = (short)291373056;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x060004FF RID: 1279 RVA: 0x00056064 File Offset: 0x00054264
		int global::AcpCommonLib.IAcpRecordset.h(int A_0)
		{
			short num = (short)1251584857;
			short num2 = num;
			num = (short)720481113;
			switch (num2 == num)
			{
			}
			num = (short)770637825;
			if (num != 0)
			{
			}
			num = (short)863895552;
			short num3 = num;
			num = (short)1470038016;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x06000500 RID: 1280 RVA: 0x00056114 File Offset: 0x00054314
		// (set) Token: 0x06000501 RID: 1281 RVA: 0x000561C4 File Offset: 0x000543C4
		bool global::AcpCommonLib.IAcpRecordset.PreDataTransferClearRecordset
		{
			get
			{
				short num = (short)1614572492;
				short num2 = num;
				num = (short)1620208588;
				switch (num2 == num)
				{
				}
				num = (short)1661599745;
				if (num != 0)
				{
				}
				num = (short)1687814144;
				short num3 = num;
				num = (short)1616314368;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
			set
			{
				short num = (short)330825729;
				if (num != 0)
				{
				}
				num = (short)98573265;
				short num2 = num;
				num = (short)1842617297;
				switch (num2 == num)
				{
				}
				num = (short)2051211264;
				short num3 = num;
				num = (short)1312817152;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x06000502 RID: 1282 RVA: 0x00056274 File Offset: 0x00054474
		bool global::AcpCommonLib.IAcpRecordset._HasDiffs
		{
			get
			{
				short num = (short)911170852;
				short num2 = num;
				num = (short)439311652;
				switch (num2 == num)
				{
				}
				num = (short)3538944;
				if (num != 0)
				{
				}
				num = (short)2049638400;
				short num3 = num;
				num = (short)699138049;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x06000503 RID: 1283 RVA: 0x00056324 File Offset: 0x00054524
		void global::AcpCommonLib.IAcpRecordset.y()
		{
			short num = (short)930350812;
			short num2 = num;
			num = (short)2008221404;
			switch (num2 == num)
			{
			}
			num = (short)1155661824;
			if (num != 0)
			{
			}
			num = (short)217513984;
			short num3 = num;
			num = (short)1984167937;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x06000504 RID: 1284 RVA: 0x000563D4 File Offset: 0x000545D4
		bool global::AcpCommonLib.IAcpRecordset.HasVisibleObjects
		{
			get
			{
				short num = (short)1533947049;
				short num2 = num;
				num = (short)2119904425;
				switch (num2 == num)
				{
				}
				num = (short)1597702144;
				if (num != 0)
				{
				}
				num = (short)1917059072;
				short num3 = num;
				num = (short)381157377;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x06000505 RID: 1285 RVA: 0x00056480 File Offset: 0x00054680
		// (set) Token: 0x06000506 RID: 1286 RVA: 0x00056530 File Offset: 0x00054730
		bool global::AcpCommonLib.IAcpRecordset._IsEmpty
		{
			get
			{
				short num = (short)2142798828;
				short num2 = num;
				num = (short)1676641260;
				switch (num2 == num)
				{
				}
				num = (short)1100808193;
				if (num != 0)
				{
				}
				num = (short)650969088;
				short num3 = num;
				num = (short)325058560;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
			set
			{
				short num = (short)126091265;
				if (num != 0)
				{
				}
				num = (short)1072314607;
				short num2 = num;
				num = (short)1108687087;
				switch (num2 == num)
				{
				}
				num = (short)808976384;
				short num3 = num;
				num = (short)2130378752;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x06000507 RID: 1287 RVA: 0x000565DC File Offset: 0x000547DC
		// (set) Token: 0x06000508 RID: 1288 RVA: 0x00056688 File Offset: 0x00054888
		bool global::AcpCommonLib.IAcpRecordset.CalculateHiddenStatic
		{
			get
			{
				short num = (short)1395763332;
				short num2 = num;
				num = (short)1551935620;
				switch (num2 == num)
				{
				}
				num = (short)1048576;
				if (num != 0)
				{
				}
				num = (short)1653604352;
				short num3 = num;
				num = (short)865337345;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
			set
			{
				short num = (short)209977344;
				short num2 = num;
				num = (short)160068677;
				short num3 = num;
				num = (short)514749509;
				switch (num3 == num)
				{
				}
				num = (short)1586495489;
				if (num != 0)
				{
				}
				num = (short)1535901696;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x06000509 RID: 1289 RVA: 0x00056734 File Offset: 0x00054934
		void global::AcpCommonLib.IAcpConstraints.ac()
		{
			short num = (short)1628504064;
			short num2 = num;
			num = (short)1189745362;
			short num3 = num;
			num = (short)1622938322;
			switch (num3 == num)
			{
			}
			num = (short)1995898881;
			if (num != 0)
			{
			}
			num = (short)1677590528;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600050A RID: 1290 RVA: 0x000567E4 File Offset: 0x000549E4
		void global::AcpCommonLib.IAcpConstraints.ad()
		{
			short num = (short)1922301952;
			short num2 = num;
			num = (short)745785539;
			short num3 = num;
			num = (short)2033109187;
			switch (num3 == num)
			{
			}
			num = (short)493486080;
			if (num != 0)
			{
			}
			num = (short)1199702017;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600050B RID: 1291 RVA: 0x00056894 File Offset: 0x00054A94
		void global::AcpCommonLib.IAcpConstraints.ae()
		{
			short num = (short)927006720;
			short num2 = num;
			num = (short)1275045443;
			short num3 = num;
			num = (short)401385027;
			switch (num3 == num)
			{
			}
			num = (short)1198194689;
			if (num != 0)
			{
			}
			num = (short)2138046464;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600050C RID: 1292 RVA: 0x00056940 File Offset: 0x00054B40
		void global::AcpCommonLib.IAcpConstraints.af()
		{
			short num = (short)1856831488;
			short num2 = num;
			num = (short)1201856196;
			short num3 = num;
			num = (short)1955978948;
			switch (num3 == num)
			{
			}
			num = (short)1321271297;
			if (num != 0)
			{
			}
			num = (short)859963392;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600050D RID: 1293 RVA: 0x000569F0 File Offset: 0x00054BF0
		void global::AcpCommonLib.IAcpConstraints.ag()
		{
			short num = (short)1685061632;
			short num2 = num;
			num = (short)1819689428;
			short num3 = num;
			num = (short)19415508;
			switch (num3 == num)
			{
			}
			num = (short)363593729;
			if (num != 0)
			{
			}
			num = (short)1300103168;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600050E RID: 1294 RVA: 0x00056AA4 File Offset: 0x00054CA4
		void global::AcpCommonLib.IAcpConstraints.ah()
		{
			short num = (short)2144272384;
			short num2 = num;
			num = (short)756615681;
			short num3 = num;
			num = (short)462424577;
			switch (num3 == num)
			{
			}
			num = (short)1369178113;
			if (num != 0)
			{
			}
			num = (short)2082078720;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600050F RID: 1295 RVA: 0x00056B54 File Offset: 0x00054D54
		void global::AcpCommonLib.IAcpConstraints.d(bool A_0)
		{
			short num = (short)165806080;
			short num2 = num;
			num = (short)2050452539;
			short num3 = num;
			num = (short)1219980347;
			switch (num3 == num)
			{
			}
			num = (short)1688928256;
			if (num != 0)
			{
			}
			num = (short)707592193;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000510 RID: 1296 RVA: 0x00056C00 File Offset: 0x00054E00
		void global::AcpCommonLib.IAcpConstraints.e(bool A_0)
		{
			short num = (short)1778515968;
			short num2 = num;
			num = (short)921480499;
			short num3 = num;
			num = (short)403352883;
			switch (num3 == num)
			{
			}
			num = (short)1984888833;
			if (num != 0)
			{
			}
			num = (short)5177344;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000511 RID: 1297 RVA: 0x00056CB0 File Offset: 0x00054EB0
		void global::AcpCommonLib.IAcpCommon.ai()
		{
			short num = (short)1687027712;
			short num2 = num;
			num = (short)653378622;
			short num3 = num;
			num = (short)1657848894;
			switch (num3 == num)
			{
			}
			num = (short)1433927680;
			if (num != 0)
			{
			}
			num = (short)1293942785;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x06000512 RID: 1298 RVA: 0x00056D60 File Offset: 0x00054F60
		// (set) Token: 0x06000513 RID: 1299 RVA: 0x00056E10 File Offset: 0x00055010
		global::AcpCommonLib.IAcpRecordset global::AcpCommonLib.IAcpFeatureNode.Parent
		{
			get
			{
				short num = (short)865992704;
				short num2 = num;
				num = (short)563777761;
				short num3 = num;
				num = (short)1847496929;
				switch (num3 == num)
				{
				}
				num = (short)1089994752;
				if (num != 0)
				{
				}
				num = (short)324730881;
				if (num != 0)
				{
				}
				return this;
			}
			set
			{
				if (value != this)
				{
					short num = (short)1391439987;
					short num2 = num;
					num = (short)1921888371;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)276299777;
						if (num != 0)
						{
						}
						num = (short)1180631040;
						short num3 = num;
						num = (short)1536163840;
						if (num != 0)
						{
						}
						throw new global::System.NotSupportedException();
					}
					}
				}
			}
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x06000514 RID: 1300 RVA: 0x00056ECC File Offset: 0x000550CC
		// (set) Token: 0x06000515 RID: 1301 RVA: 0x00056F7C File Offset: 0x0005517C
		string global::AcpCommonLib.IAcpFeatureNode.FeatureName
		{
			get
			{
				short num = (short)1008533504;
				short num2 = num;
				num = (short)599809433;
				short num3 = num;
				num = (short)1885691289;
				switch (num3 == num)
				{
				}
				num = (short)1255211008;
				if (num != 0)
				{
				}
				num = (short)1274544129;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
			set
			{
				short num = (short)1607663616;
				short num2 = num;
				num = (short)2011575644;
				short num3 = num;
				num = (short)619263324;
				switch (num3 == num)
				{
				}
				num = (short)644546560;
				if (num != 0)
				{
				}
				num = (short)766967809;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x06000516 RID: 1302 RVA: 0x0005702C File Offset: 0x0005522C
		string global::AcpCommonLib.IAcpFeatureNode.ReferenceKey
		{
			get
			{
				short num = (short)1529806848;
				short num2 = num;
				num = (short)1521132630;
				short num3 = num;
				num = (short)1883546710;
				switch (num3 == num)
				{
				}
				num = (short)32899073;
				if (num != 0)
				{
				}
				num = (short)99680256;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x06000517 RID: 1303 RVA: 0x000570DC File Offset: 0x000552DC
		int global::AcpCommonLib.IAcpFeatureNode.NodeId
		{
			get
			{
				short num = (short)1484980224;
				short num2 = num;
				num = (short)2000974813;
				short num3 = num;
				num = (short)1502376925;
				switch (num3 == num)
				{
				}
				num = (short)48758785;
				if (num != 0)
				{
				}
				num = (short)1451884544;
				if (num != 0)
				{
				}
				return (int)this.VoiceFileField.VoiceData.Position;
			}
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x06000518 RID: 1304 RVA: 0x00057194 File Offset: 0x00055394
		string global::AcpCommonLib.IAcpFeatureNode.UIPagePath
		{
			get
			{
				short num = (short)1010565120;
				short num2 = num;
				num = (short)923510772;
				short num3 = num;
				num = (short)448243700;
				switch (num3 == num)
				{
				}
				num = (short)1531052032;
				if (num != 0)
				{
				}
				num = (short)373555201;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x06000519 RID: 1305 RVA: 0x00057244 File Offset: 0x00055444
		// (set) Token: 0x0600051A RID: 1306 RVA: 0x000572F4 File Offset: 0x000554F4
		string global::AcpCommonLib.IAcpFeatureNode.TreeNodeLabel
		{
			get
			{
				short num = (short)922025984;
				short num2 = num;
				num = (short)660602881;
				if (num != 0)
				{
				}
				num = (short)2003991537;
				short num3 = num;
				num = (short)14187505;
				switch (num3 == num)
				{
				}
				num = (short)1978466304;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
			set
			{
				short num = (short)559087616;
				short num2 = num;
				num = (short)1847966868;
				short num3 = num;
				num = (short)668056724;
				switch (num3 == num)
				{
				}
				num = (short)2139881473;
				if (num != 0)
				{
				}
				num = (short)50593792;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x0600051B RID: 1307 RVA: 0x000573A4 File Offset: 0x000555A4
		void global::AcpCommonLib.IAcpFeatureNode.ap()
		{
			short num = (short)1892745216;
			short num2 = num;
			num = (short)2122224075;
			short num3 = num;
			num = (short)571576779;
			switch (num3 == num)
			{
			}
			num = (short)1172242432;
			if (num != 0)
			{
			}
			num = (short)1826029569;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600051C RID: 1308 RVA: 0x00057450 File Offset: 0x00055650
		void global::AcpCommonLib.IAcpFeatureNode.aq()
		{
			short num = (short)1714028544;
			short num2 = num;
			num = (short)1323302913;
			if (num != 0)
			{
			}
			num = (short)2129232451;
			short num3 = num;
			num = (short)110789187;
			switch (num3 == num)
			{
			}
			num = (short)1355153408;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x1700016B RID: 363
		global::AcpCommonLib.IAcpFeatureSection global::AcpCommonLib.IAcpFeatureNode.this[int A_0]
		{
			get
			{
				short num;
				for (;;)
				{
					num = (short)1318912000;
					short num2 = num;
					if (A_0 != this.field.Parent.FeatureSectionId)
					{
						break;
					}
					num = (short)385708006;
					short num3 = num;
					num = (short)56848358;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_9F;
					}
				}
				num = (short)1110769665;
				if (num != 0)
				{
				}
				return null;
				IL_9F:
				num = (short)1865875456;
				if (num != 0)
				{
				}
				return this;
			}
		}

		// Token: 0x0600051E RID: 1310 RVA: 0x000575C0 File Offset: 0x000557C0
		void global::AcpCommonLib.IAcpFeatureNode.a(global::AcpCommonLib.IAcpFeatureSection A_0)
		{
			short num = (short)1208811520;
			short num2 = num;
			num = (short)1382522835;
			short num3 = num;
			num = (short)1714724819;
			switch (num3 == num)
			{
			}
			num = (short)1257635841;
			if (num != 0)
			{
			}
			num = (short)953614336;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x0600051F RID: 1311 RVA: 0x00057670 File Offset: 0x00055870
		global::System.Collections.Generic.IEnumerable<global::AcpCommonLib.IAcpFeatureSection> global::AcpCommonLib.IAcpFeatureNode.FeatureSectionsCollection
		{
			get
			{
				short num = (short)337444864;
				short num2 = num;
				num = (short)759939480;
				short num3 = num;
				num = (short)412205464;
				switch (num3 == num)
				{
				}
				num = (short)1965883393;
				if (num != 0)
				{
				}
				num = (short)812056576;
				if (num != 0)
				{
				}
				global::Motorola.Acp.PackUnpack.Ish.DataExchange.VoiceFileFieldAdapter.a a = new global::Motorola.Acp.PackUnpack.Ish.DataExchange.VoiceFileFieldAdapter.a(-2);
				a.d = this;
				return a;
			}
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x06000520 RID: 1312 RVA: 0x00057728 File Offset: 0x00055928
		global::System.Collections.Generic.IEnumerable<global::AcpCommonLib.IAcpFeatureSection> global::AcpCommonLib.IAcpFeatureNode.FeatureSectionsCollectionByOrder
		{
			get
			{
				short num = (short)645201920;
				short num2 = num;
				num = (short)1410433389;
				short num3 = num;
				num = (short)200245613;
				switch (num3 == num)
				{
				}
				num = (short)1629290497;
				if (num != 0)
				{
				}
				num = (short)1046216704;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x06000521 RID: 1313 RVA: 0x000577D8 File Offset: 0x000559D8
		global::System.Collections.Generic.IEnumerable<global::AcpCommonLib.IAcpField> global::AcpCommonLib.IAcpFeatureNode.h(string A_0)
		{
			short num = (short)1177944064;
			short num2 = num;
			num = (short)740402705;
			short num3 = num;
			num = (short)1639818769;
			switch (num3 == num)
			{
			}
			num = (short)1445920769;
			if (num != 0)
			{
			}
			num = (short)1311506432;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000522 RID: 1314 RVA: 0x00057888 File Offset: 0x00055A88
		global::System.Collections.Generic.IEnumerable<global::AcpCommonLib.IAcpField> global::AcpCommonLib.IAcpFeatureNode.i(string A_0)
		{
			short num = (short)221577216;
			short num2 = num;
			num = (short)1969147408;
			short num3 = num;
			num = (short)664718864;
			switch (num3 == num)
			{
			}
			num = (short)1918173185;
			if (num != 0)
			{
			}
			num = (short)1476526080;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x06000523 RID: 1315 RVA: 0x00057934 File Offset: 0x00055B34
		// (set) Token: 0x06000524 RID: 1316 RVA: 0x000579E0 File Offset: 0x00055BE0
		string global::AcpCommonLib.IAcpFeatureNode.UIName
		{
			get
			{
				short num = (short)225378304;
				short num2 = num;
				num = (short)916473532;
				short num3 = num;
				num = (short)1843480252;
				switch (num3 == num)
				{
				}
				num = (short)1441988608;
				if (num != 0)
				{
				}
				num = (short)608501761;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
			set
			{
				short num = (short)1207894016;
				short num2 = num;
				num = (short)718326143;
				short num3 = num;
				num = (short)1891355007;
				switch (num3 == num)
				{
				}
				num = (short)1611071489;
				if (num != 0)
				{
				}
				num = (short)64356352;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x06000525 RID: 1317 RVA: 0x00057A90 File Offset: 0x00055C90
		string global::AcpCommonLib.IAcpFeatureNode.k(string A_0)
		{
			short num = (short)433455104;
			short num2 = num;
			num = (short)1760263484;
			short num3 = num;
			num = (short)2088336700;
			switch (num3 == num)
			{
			}
			num = (short)1270874112;
			if (num != 0)
			{
			}
			num = (short)160366593;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x06000526 RID: 1318 RVA: 0x00057B40 File Offset: 0x00055D40
		global::System.Collections.Generic.IEnumerable<global::AcpCommonLib.IAcpRecordset> global::AcpCommonLib.IAcpFeatureNode.EmbeddedRecordsets
		{
			get
			{
				short num = (short)1826422784;
				short num2 = num;
				num = (short)362720371;
				short num3 = num;
				num = (short)1872145523;
				switch (num3 == num)
				{
				}
				num = (short)688259073;
				if (num != 0)
				{
				}
				num = (short)145293312;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x06000527 RID: 1319 RVA: 0x00057BF0 File Offset: 0x00055DF0
		bool global::AcpCommonLib.IAcpFeatureNode.Deleted
		{
			get
			{
				short num = (short)2025324544;
				short num2 = num;
				num = (short)1526424922;
				short num3 = num;
				num = (short)1619813722;
				switch (num3 == num)
				{
				}
				num = (short)1168375809;
				if (num != 0)
				{
				}
				num = (short)1951858688;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x06000528 RID: 1320 RVA: 0x00057C9C File Offset: 0x00055E9C
		bool global::AcpCommonLib.IAcpFeatureNode._HasDiffs
		{
			get
			{
				short num = (short)1751711744;
				short num2 = num;
				num = (short)1575083588;
				short num3 = num;
				num = (short)1628626500;
				switch (num3 == num)
				{
				}
				num = (short)1485504513;
				if (num != 0)
				{
				}
				num = (short)955908096;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x06000529 RID: 1321 RVA: 0x00057D48 File Offset: 0x00055F48
		void global::AcpCommonLib.IAcpFeatureNode.ax()
		{
			short num = (short)1550254080;
			short num2 = num;
			num = (short)2138180955;
			short num3 = num;
			num = (short)1041567067;
			switch (num3 == num)
			{
			}
			num = (short)216924160;
			if (num != 0)
			{
			}
			num = (short)1403781121;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x0600052A RID: 1322 RVA: 0x00057DF8 File Offset: 0x00055FF8
		bool global::AcpCommonLib.IAcpFeatureNode.HasVisibleObjects
		{
			get
			{
				short num = (short)733478912;
				short num2 = num;
				num = (short)1044139722;
				short num3 = num;
				num = (short)496914122;
				switch (num3 == num)
				{
				}
				num = (short)1749811200;
				if (num != 0)
				{
				}
				num = (short)862257153;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x0600052B RID: 1323 RVA: 0x00057EA4 File Offset: 0x000560A4
		int global::AcpCommonLib.IAcpFeatureSection.FeatureSectionId
		{
			get
			{
				short num = (short)958660608;
				short num2 = num;
				num = (short)673767135;
				short num3 = num;
				num = (short)528670431;
				switch (num3 == num)
				{
				}
				num = (short)1336475649;
				if (num != 0)
				{
				}
				num = (short)229638144;
				if (num != 0)
				{
				}
				return this.field.Parent.FeatureSectionId;
			}
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x0600052C RID: 1324 RVA: 0x00057F5C File Offset: 0x0005615C
		// (set) Token: 0x0600052D RID: 1325 RVA: 0x00058018 File Offset: 0x00056218
		string global::AcpCommonLib.IAcpFeatureSection.FeatureSectionName
		{
			get
			{
				short num = (short)129236992;
				short num2 = num;
				num = (short)1392312321;
				if (num != 0)
				{
				}
				num = (short)109970877;
				short num3 = num;
				num = (short)1707410877;
				switch (num3 == num)
				{
				}
				num = (short)1358823424;
				if (num != 0)
				{
				}
				return this.field.Parent.FeatureSectionName;
			}
			set
			{
				short num = (short)1678966784;
				short num2 = num;
				num = (short)957164541;
				short num3 = num;
				num = (short)322120701;
				switch (num3 == num)
				{
				}
				num = (short)69468160;
				if (num != 0)
				{
				}
				num = (short)1579089921;
				if (num != 0)
				{
				}
				throw new global::System.NotSupportedException();
			}
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x0600052E RID: 1326 RVA: 0x000580CC File Offset: 0x000562CC
		// (set) Token: 0x0600052F RID: 1327 RVA: 0x00058178 File Offset: 0x00056378
		global::AcpCommonLib.IAcpFeatureNode global::AcpCommonLib.IAcpFeatureSection.Parent
		{
			get
			{
				short num = (short)1044905984;
				short num2 = num;
				num = (short)1450108280;
				short num3 = num;
				num = (short)1644553592;
				switch (num3 == num)
				{
				}
				num = (short)1330184192;
				if (num != 0)
				{
				}
				num = (short)1720647681;
				if (num != 0)
				{
				}
				return this;
			}
			set
			{
				short num = (short)33619968;
				short num2 = num;
				num = (short)1128185652;
				short num3 = num;
				num = (short)108379956;
				switch (num3 == num)
				{
				}
				num = (short)1781268481;
				if (num != 0)
				{
				}
				num = (short)724303872;
				if (num != 0)
				{
				}
				throw new global::System.NotSupportedException();
			}
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x06000530 RID: 1328 RVA: 0x00058224 File Offset: 0x00056424
		global::AcpCommonLib.IAcpRecordset global::AcpCommonLib.IAcpFeatureSection.ParentRecset
		{
			get
			{
				short num = (short)2110521344;
				short num2 = num;
				num = (short)1993235932;
				short num3 = num;
				num = (short)1599495644;
				switch (num3 == num)
				{
				}
				num = (short)460259329;
				if (num != 0)
				{
				}
				num = (short)1392181248;
				if (num != 0)
				{
				}
				return this;
			}
		}

		// Token: 0x06000531 RID: 1329 RVA: 0x000582D0 File Offset: 0x000564D0
		void global::AcpCommonLib.IAcpFeatureSection.a3()
		{
			short num = (short)1925906432;
			short num2 = num;
			num = (short)1244966965;
			short num3 = num;
			num = (short)1597878325;
			switch (num3 == num)
			{
			}
			num = (short)511115265;
			if (num != 0)
			{
			}
			num = (short)1713963008;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000532 RID: 1330 RVA: 0x0005837C File Offset: 0x0005657C
		void global::AcpCommonLib.IAcpFeatureSection.a4()
		{
			short num = (short)1596981248;
			short num2 = num;
			num = (short)725614593;
			if (num != 0)
			{
			}
			num = (short)1515030395;
			short num3 = num;
			num = (short)676497275;
			switch (num3 == num)
			{
			}
			num = (short)209256448;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000533 RID: 1331 RVA: 0x00058428 File Offset: 0x00056628
		void global::AcpCommonLib.IAcpFeatureSection.a5()
		{
			short num = (short)86507520;
			short num2 = num;
			num = (short)2089971576;
			short num3 = num;
			num = (short)1711173496;
			switch (num3 == num)
			{
			}
			num = (short)1330774017;
			if (num != 0)
			{
			}
			num = (short)1553465344;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000534 RID: 1332 RVA: 0x000584D0 File Offset: 0x000566D0
		void global::AcpCommonLib.IAcpFeatureSection.a6()
		{
			short num = (short)1207631872;
			short num2 = num;
			num = (short)921308392;
			short num3 = num;
			num = (short)657001704;
			switch (num3 == num)
			{
			}
			num = (short)1233584129;
			if (num != 0)
			{
			}
			num = (short)881852416;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000535 RID: 1333 RVA: 0x00058578 File Offset: 0x00056778
		void global::AcpCommonLib.IAcpFeatureSection.a7()
		{
			short num = (short)674299904;
			short num2 = num;
			num = (short)1534643036;
			short num3 = num;
			num = (short)546622300;
			switch (num3 == num)
			{
			}
			num = (short)62259200;
			if (num != 0)
			{
			}
			num = (short)2006056961;
			if (num != 0)
			{
			}
		}

		// Token: 0x17000177 RID: 375
		global::AcpCommonLib.IAcpField global::AcpCommonLib.IAcpFeatureSection.this[string A_0]
		{
			get
			{
				short num;
				for (;;)
				{
					num = (short)1599209472;
					short num2 = num;
					if (A_0 != this.field.UIName)
					{
						break;
					}
					num = (short)2057194943;
					short num3 = num;
					num = (short)1958628799;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_76;
					}
				}
				return null;
				IL_76:
				num = (short)1433272320;
				if (num != 0)
				{
				}
				num = (short)1476853761;
				if (num != 0)
				{
				}
				return this;
			}
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x06000537 RID: 1335 RVA: 0x000586E4 File Offset: 0x000568E4
		global::System.Collections.Generic.IEnumerable<global::AcpCommonLib.IAcpField> global::AcpCommonLib.IAcpFeatureSection.FieldsCollection
		{
			get
			{
				short num = (short)1409941504;
				short num2 = num;
				num = (short)768620143;
				short num3 = num;
				num = (short)938030703;
				switch (num3 == num)
				{
				}
				num = (short)764870656;
				if (num != 0)
				{
				}
				num = (short)1687486465;
				if (num != 0)
				{
				}
				global::Motorola.Acp.PackUnpack.Ish.DataExchange.VoiceFileFieldAdapter.b b = new global::Motorola.Acp.PackUnpack.Ish.DataExchange.VoiceFileFieldAdapter.b(-2);
				b.d = this;
				return b;
			}
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x06000538 RID: 1336 RVA: 0x00058798 File Offset: 0x00056998
		global::System.Collections.Generic.IEnumerable<global::AcpCommonLib.IAcpField> global::AcpCommonLib.IAcpFeatureSection.FieldsCollectionByOrder
		{
			get
			{
				short num = (short)1516830720;
				short num2 = num;
				num = (short)208631675;
				short num3 = num;
				num = (short)91322235;
				switch (num3 == num)
				{
				}
				num = (short)75628544;
				if (num != 0)
				{
				}
				num = (short)855965697;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x06000539 RID: 1337 RVA: 0x00058848 File Offset: 0x00056A48
		bool global::AcpCommonLib.IAcpFeatureSection.HasEmbeddedRecset
		{
			get
			{
				short num = (short)1125711872;
				short num2 = num;
				num = (short)2073028934;
				short num3 = num;
				num = (short)2083055942;
				switch (num3 == num)
				{
				}
				num = (short)1682833409;
				if (num != 0)
				{
				}
				num = (short)1995243520;
				if (num != 0)
				{
				}
				return false;
			}
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x0600053A RID: 1338 RVA: 0x000588F4 File Offset: 0x00056AF4
		// (set) Token: 0x0600053B RID: 1339 RVA: 0x000589A0 File Offset: 0x00056BA0
		global::AcpCommonLib.IAcpRecordset global::AcpCommonLib.IAcpFeatureSection.EmbeddedRecset
		{
			get
			{
				short num = (short)1842110184;
				short num2 = num;
				num = (short)817913576;
				switch (num2 == num)
				{
				}
				num = (short)1500381184;
				if (num != 0)
				{
				}
				num = (short)1699217408;
				short num3 = num;
				num = (short)1508245505;
				if (num != 0)
				{
				}
				return null;
			}
			set
			{
				short num = (short)1974972600;
				short num2 = num;
				num = (short)662548664;
				switch (num2 == num)
				{
				}
				num = (short)1495203840;
				if (num != 0)
				{
				}
				num = (short)88211456;
				short num3 = num;
				num = (short)752549889;
				if (num != 0)
				{
				}
				throw new global::System.NotSupportedException();
			}
		}

		// Token: 0x0600053C RID: 1340 RVA: 0x00058A50 File Offset: 0x00056C50
		global::System.Collections.Generic.IEnumerable<global::AcpCommonLib.IAcpField> global::AcpCommonLib.IAcpFeatureSection.n(string A_0)
		{
			short num = (short)289130328;
			short num2 = num;
			num = (short)1882572632;
			switch (num2 == num)
			{
			}
			num = (short)1873346561;
			if (num != 0)
			{
			}
			num = (short)1460207616;
			short num3 = num;
			num = (short)192675840;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600053D RID: 1341 RVA: 0x00058B00 File Offset: 0x00056D00
		global::System.Collections.Generic.IEnumerable<global::AcpCommonLib.IAcpField> global::AcpCommonLib.IAcpFeatureSection.o(string A_0)
		{
			short num = (short)1836099364;
			short num2 = num;
			num = (short)235448100;
			switch (num2 == num)
			{
			}
			num = (short)1320681473;
			if (num != 0)
			{
			}
			num = (short)1126236160;
			short num3 = num;
			num = (short)2035875840;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x0600053E RID: 1342 RVA: 0x00058BB0 File Offset: 0x00056DB0
		// (set) Token: 0x0600053F RID: 1343 RVA: 0x00058C6C File Offset: 0x00056E6C
		string global::AcpCommonLib.IAcpFeatureSection.UIName
		{
			get
			{
				short num = (short)1301358144;
				short num2 = num;
				num = (short)924919360;
				switch (num2 == num)
				{
				}
				num = (short)1663565825;
				if (num != 0)
				{
				}
				num = (short)1582497792;
				short num3 = num;
				num = (short)227868672;
				if (num != 0)
				{
				}
				return this.field.Parent.UIName;
			}
			set
			{
				short num = (short)94241886;
				short num2 = num;
				num = (short)1384907870;
				switch (num2 == num)
				{
				}
				num = (short)1726676993;
				if (num != 0)
				{
				}
				num = (short)855769088;
				short num3 = num;
				num = (short)1975451648;
				if (num != 0)
				{
				}
				throw new global::System.NotSupportedException();
			}
		}

		// Token: 0x06000540 RID: 1344 RVA: 0x00058D1C File Offset: 0x00056F1C
		string global::AcpCommonLib.IAcpFeatureSection.q(string A_0)
		{
			short num = (short)1159885567;
			short num2 = num;
			num = (short)1066496767;
			switch (num2 == num)
			{
			}
			num = (short)1777205249;
			if (num != 0)
			{
			}
			num = (short)584777728;
			short num3 = num;
			num = (short)1852833792;
			if (num != 0)
			{
			}
			return this.field.Parent.Path(A_0);
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x06000541 RID: 1345 RVA: 0x00058DD4 File Offset: 0x00056FD4
		global::AcpCommonLib.IAcpField global::AcpCommonLib.IAcpFeatureSection.CurrentField
		{
			get
			{
				short num = (short)453510954;
				short num2 = num;
				num = (short)263587626;
				switch (num2 == num)
				{
				}
				num = (short)1886322688;
				if (num != 0)
				{
				}
				num = (short)1660944384;
				short num3 = num;
				num = (short)1736441857;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x06000542 RID: 1346 RVA: 0x00058E84 File Offset: 0x00057084
		bool global::AcpCommonLib.IAcpFeatureSection._HasDiffs
		{
			get
			{
				short num = (short)80487637;
				short num2 = num;
				num = (short)1665541333;
				switch (num2 == num)
				{
				}
				num = (short)957153280;
				if (num != 0)
				{
				}
				num = (short)634978304;
				short num3 = num;
				num = (short)938409985;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x06000543 RID: 1347 RVA: 0x00058F30 File Offset: 0x00057130
		void global::AcpCommonLib.IAcpFeatureSection.bf()
		{
			short num = (short)493631667;
			short num2 = num;
			num = (short)2069313715;
			switch (num2 == num)
			{
			}
			num = (short)853540864;
			if (num != 0)
			{
			}
			num = (short)137494528;
			short num3 = num;
			num = (short)217972737;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x06000544 RID: 1348 RVA: 0x00058FE0 File Offset: 0x000571E0
		bool global::AcpCommonLib.IAcpFeatureSection.HasVisibleObjects
		{
			get
			{
				short num = (short)1545761731;
				short num2 = num;
				num = (short)48919491;
				switch (num2 == num)
				{
				}
				num = (short)76283904;
				if (num != 0)
				{
				}
				num = (short)641204224;
				short num3 = num;
				num = (short)417792001;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x06000545 RID: 1349 RVA: 0x00059090 File Offset: 0x00057290
		// (set) Token: 0x06000546 RID: 1350 RVA: 0x0005913C File Offset: 0x0005733C
		int global::AcpCommonLib.IAcpFeatureSection.DataTransferOrder
		{
			get
			{
				short num = (short)1617150788;
				short num2 = num;
				num = (short)51888964;
				switch (num2 == num)
				{
				}
				num = (short)577961985;
				if (num != 0)
				{
				}
				num = (short)5963776;
				short num3 = num;
				num = (short)842399744;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
			set
			{
				short num = (short)523870908;
				short num2 = num;
				num = (short)807248572;
				switch (num2 == num)
				{
				}
				num = (short)1823408129;
				if (num != 0)
				{
				}
				num = (short)726663168;
				short num3 = num;
				num = (short)1295187968;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x06000547 RID: 1351 RVA: 0x000591EC File Offset: 0x000573EC
		// (set) Token: 0x06000548 RID: 1352 RVA: 0x00059298 File Offset: 0x00057498
		bool global::AcpCommonLib.IAcpField.Editable
		{
			get
			{
				short num = (short)899035127;
				short num2 = num;
				num = (short)1556426743;
				switch (num2 == num)
				{
				}
				num = (short)1850671104;
				if (num != 0)
				{
				}
				num = (short)1394999296;
				short num3 = num;
				num = (short)213254145;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
			set
			{
				short num = (short)1337530315;
				short num2 = num;
				num = (short)1804605387;
				switch (num2 == num)
				{
				}
				num = (short)236781569;
				if (num != 0)
				{
				}
				num = (short)436797440;
				short num3 = num;
				num = (short)1883373568;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x06000549 RID: 1353 RVA: 0x00059344 File Offset: 0x00057544
		// (set) Token: 0x0600054A RID: 1354 RVA: 0x000593F4 File Offset: 0x000575F4
		bool global::AcpCommonLib.IAcpField.Valid
		{
			get
			{
				short num = (short)556870534;
				short num2 = num;
				num = (short)620505990;
				switch (num2 == num)
				{
				}
				num = (short)1270218753;
				if (num != 0)
				{
				}
				num = (short)1464270848;
				short num3 = num;
				num = (short)428933120;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
			set
			{
				short num = (short)1948385281;
				if (num != 0)
				{
				}
				num = (short)1080939054;
				short num2 = num;
				num = (short)1887621678;
				switch (num2 == num)
				{
				}
				num = (short)1325793280;
				short num3 = num;
				num = (short)795475968;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x0600054B RID: 1355 RVA: 0x000594A4 File Offset: 0x000576A4
		// (set) Token: 0x0600054C RID: 1356 RVA: 0x00059550 File Offset: 0x00057750
		bool global::AcpCommonLib.IAcpField.Visible
		{
			get
			{
				short num = (short)1956249601;
				if (num != 0)
				{
				}
				num = (short)155865150;
				short num2 = num;
				num = (short)1173442622;
				switch (num2 == num)
				{
				}
				num = (short)1789526016;
				short num3 = num;
				num = (short)333709312;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
			set
			{
				short num = (short)1964631698;
				short num2 = num;
				num = (short)693626514;
				switch (num2 == num)
				{
				}
				num = (short)1202192384;
				if (num != 0)
				{
				}
				num = (short)577372160;
				short num3 = num;
				num = (short)875823105;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x0600054D RID: 1357 RVA: 0x000595FC File Offset: 0x000577FC
		// (set) Token: 0x0600054E RID: 1358 RVA: 0x000596AC File Offset: 0x000578AC
		bool global::AcpCommonLib.IAcpField.Applicable
		{
			get
			{
				short num = (short)54263809;
				if (num != 0)
				{
				}
				num = (short)1285080439;
				short num2 = num;
				num = (short)57591159;
				switch (num2 == num)
				{
				}
				num = (short)753008640;
				short num3 = num;
				num = (short)69074944;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
			set
			{
				short num = (short)652504608;
				short num2 = num;
				num = (short)2049469984;
				switch (num2 == num)
				{
				}
				num = (short)543686657;
				if (num != 0)
				{
				}
				num = (short)178323456;
				short num3 = num;
				num = (short)1650196480;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x0600054F RID: 1359 RVA: 0x00059758 File Offset: 0x00057958
		// (set) Token: 0x06000550 RID: 1360 RVA: 0x00059804 File Offset: 0x00057A04
		bool global::AcpCommonLib.IAcpField.TieredOut
		{
			get
			{
				short num = (short)863730679;
				short num2 = num;
				num = (short)1013939191;
				switch (num2 == num)
				{
				}
				num = (short)1463877633;
				if (num != 0)
				{
				}
				num = (short)1276903424;
				short num3 = num;
				num = (short)458620928;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
			set
			{
				short num = (short)1491048057;
				short num2 = num;
				num = (short)1433507449;
				switch (num2 == num)
				{
				}
				num = (short)469958657;
				if (num != 0)
				{
				}
				num = (short)1447624704;
				short num3 = num;
				num = (short)1535049728;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x06000551 RID: 1361 RVA: 0x000598B4 File Offset: 0x00057AB4
		global::AcpCommonLib.UndoRedo.UndoableTask global::AcpCommonLib.IAcpField.a(global::AcpCommonLib.IAcpField A_0)
		{
			short num = (short)876806145;
			if (num != 0)
			{
			}
			num = (short)1490156895;
			short num2 = num;
			num = (short)1396637023;
			switch (num2 == num)
			{
			}
			num = (short)600702976;
			short num3 = num;
			num = (short)123731968;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000552 RID: 1362 RVA: 0x00059964 File Offset: 0x00057B64
		global::AcpCommonLib.UndoRedo.UndoableTask global::AcpCommonLib.IAcpField.a(object A_0)
		{
			short num = (short)988361711;
			short num2 = num;
			num = (short)182268911;
			switch (num2 == num)
			{
			}
			num = (short)712114177;
			if (num != 0)
			{
			}
			num = (short)1575878656;
			short num3 = num;
			num = (short)2070020096;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x06000553 RID: 1363 RVA: 0x00059A10 File Offset: 0x00057C10
		// (set) Token: 0x06000554 RID: 1364 RVA: 0x00059AC0 File Offset: 0x00057CC0
		global::AcpCommonLib.StateConstraint global::AcpCommonLib.IAcpField.IsApplicable
		{
			get
			{
				short num = (short)1843778061;
				short num2 = num;
				num = (short)1853936141;
				switch (num2 == num)
				{
				}
				num = (short)404815872;
				if (num != 0)
				{
				}
				num = (short)2123890688;
				short num3 = num;
				num = (short)641007617;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
			set
			{
				short num = (short)1860501505;
				if (num != 0)
				{
				}
				num = (short)2091509867;
				short num2 = num;
				num = (short)604235883;
				switch (num2 == num)
				{
				}
				num = (short)615186432;
				short num3 = num;
				num = (short)852623360;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x06000555 RID: 1365 RVA: 0x00059B6C File Offset: 0x00057D6C
		// (set) Token: 0x06000556 RID: 1366 RVA: 0x00059C18 File Offset: 0x00057E18
		global::AcpCommonLib.StateConstraint global::AcpCommonLib.IAcpField.IsValid
		{
			get
			{
				short num = (short)462893146;
				short num2 = num;
				num = (short)971649114;
				switch (num2 == num)
				{
				}
				num = (short)1296629760;
				if (num != 0)
				{
				}
				num = (short)1767702528;
				short num3 = num;
				num = (short)2057830401;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
			set
			{
				short num = (short)218084527;
				short num2 = num;
				num = (short)903001263;
				switch (num2 == num)
				{
				}
				num = (short)1117650945;
				if (num != 0)
				{
				}
				num = (short)1259732992;
				short num3 = num;
				num = (short)475398144;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x06000557 RID: 1367 RVA: 0x00059CC8 File Offset: 0x00057EC8
		bool global::AcpCommonLib.IAcpField.b(global::AcpCommonLib.IAcpField A_0)
		{
			short num = (short)17479184;
			short num2 = num;
			num = (short)1886696976;
			switch (num2 == num)
			{
			}
			num = (short)643366913;
			if (num != 0)
			{
			}
			num = (short)1990787072;
			short num3 = num;
			num = (short)1252982784;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x06000558 RID: 1368 RVA: 0x00059D74 File Offset: 0x00057F74
		string global::AcpCommonLib.IAcpField.Name
		{
			get
			{
				short num = (short)248666193;
				short num2 = num;
				num = (short)1120950353;
				switch (num2 == num)
				{
				}
				num = (short)78577665;
				if (num != 0)
				{
				}
				num = (short)1696333824;
				short num3 = num;
				num = (short)243073024;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x06000559 RID: 1369 RVA: 0x00059E20 File Offset: 0x00058020
		string global::AcpCommonLib.IAcpField.UIName
		{
			get
			{
				short num = (short)854366112;
				short num2 = num;
				num = (short)296851360;
				switch (num2 == num)
				{
				}
				num = (short)1266155520;
				if (num != 0)
				{
				}
				num = (short)1940979712;
				short num3 = num;
				num = (short)613679105;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x0600055A RID: 1370 RVA: 0x00059ED0 File Offset: 0x000580D0
		string global::AcpCommonLib.IAcpField.NewUIName
		{
			get
			{
				short num = (short)666173441;
				if (num != 0)
				{
				}
				num = (short)1870516033;
				short num2 = num;
				num = (short)1493159745;
				switch (num2 == num)
				{
				}
				num = (short)2082734080;
				short num3 = num;
				num = (short)896663552;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x0600055B RID: 1371 RVA: 0x00059F80 File Offset: 0x00058180
		string global::AcpCommonLib.IAcpField.NewUiExpanderAndName
		{
			get
			{
				short num = (short)1396760632;
				short num2 = num;
				num = (short)1803673656;
				switch (num2 == num)
				{
				}
				num = (short)1451360256;
				if (num != 0)
				{
				}
				num = (short)1696727040;
				short num3 = num;
				num = (short)353632257;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x0600055C RID: 1372 RVA: 0x0005A030 File Offset: 0x00058230
		// (set) Token: 0x0600055D RID: 1373 RVA: 0x0005A0E0 File Offset: 0x000582E0
		global::AcpCommonLib.IAcpFeatureSection global::AcpCommonLib.IAcpField.Parent
		{
			get
			{
				short num = (short)1532304980;
				short num2 = num;
				num = (short)304619092;
				switch (num2 == num)
				{
				}
				num = (short)1846935552;
				if (num != 0)
				{
				}
				num = (short)698744832;
				short num3 = num;
				num = (short)1257832449;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
			set
			{
				short num = (short)271055802;
				short num2 = num;
				num = (short)673381306;
				switch (num2 == num)
				{
				}
				num = (short)475332609;
				if (num != 0)
				{
				}
				num = (short)1019609088;
				short num3 = num;
				num = (short)1660878848;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x0600055E RID: 1374 RVA: 0x0005A18C File Offset: 0x0005838C
		global::AcpCommonLib.IAcpFeatureSection global::AcpCommonLib.IAcpField.NewParent
		{
			get
			{
				short num = (short)1338940930;
				short num2 = num;
				num = (short)564895234;
				switch (num2 == num)
				{
				}
				num = (short)499187713;
				if (num != 0)
				{
				}
				num = (short)1259667456;
				short num3 = num;
				num = (short)562364416;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x0600055F RID: 1375 RVA: 0x0005A238 File Offset: 0x00058438
		string global::AcpCommonLib.IAcpField.r(string A_0)
		{
			short num = (short)482686752;
			short num2 = num;
			num = (short)1142568736;
			switch (num2 == num)
			{
			}
			num = (short)1766391809;
			if (num != 0)
			{
			}
			num = (short)720961536;
			short num3 = num;
			num = (short)1844117504;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x06000560 RID: 1376 RVA: 0x0005A2E4 File Offset: 0x000584E4
		global::System.Type global::AcpCommonLib.IAcpField.DataType
		{
			get
			{
				short num = (short)44230426;
				short num2 = num;
				num = (short)1297082138;
				switch (num2 == num)
				{
				}
				num = (short)92733441;
				if (num != 0)
				{
				}
				num = (short)1510604800;
				short num3 = num;
				num = (short)991625216;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x06000561 RID: 1377 RVA: 0x0005A394 File Offset: 0x00058594
		void global::AcpCommonLib.IAcpField.s(string A_0)
		{
			short num = (short)278547052;
			short num2 = num;
			num = (short)110774892;
			switch (num2 == num)
			{
			}
			num = (short)1093861377;
			if (num != 0)
			{
			}
			num = (short)1479737344;
			short num3 = num;
			num = (short)656670720;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000562 RID: 1378 RVA: 0x0005A440 File Offset: 0x00058640
		void global::AcpCommonLib.IAcpField.t(string A_0)
		{
			short num = (short)1640524768;
			short num2 = num;
			num = (short)1140419552;
			switch (num2 == num)
			{
			}
			num = (short)1086455808;
			if (num != 0)
			{
			}
			num = (short)1237516288;
			short num3 = num;
			num = (short)623640577;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x06000563 RID: 1379 RVA: 0x0005A4F0 File Offset: 0x000586F0
		// (set) Token: 0x06000564 RID: 1380 RVA: 0x0005A59C File Offset: 0x0005879C
		bool global::AcpCommonLib.IAcpField.CustomViewVisibility
		{
			get
			{
				short num = (short)1006108307;
				short num2 = num;
				num = (short)2067005075;
				switch (num2 == num)
				{
				}
				num = (short)677445633;
				if (num != 0)
				{
				}
				num = (short)332660736;
				short num3 = num;
				num = (short)615841792;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
			set
			{
				short num = (short)464193320;
				short num2 = num;
				num = (short)141362984;
				switch (num2 == num)
				{
				}
				num = (short)27983872;
				if (num != 0)
				{
				}
				num = (short)1938227200;
				short num3 = num;
				num = (short)1244332033;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x06000565 RID: 1381 RVA: 0x0005A648 File Offset: 0x00058848
		// (set) Token: 0x06000566 RID: 1382 RVA: 0x0005A6F4 File Offset: 0x000588F4
		global::AcpCommonLib.DifferentiatedUserViewType global::AcpCommonLib.IAcpField.DifferentiatedUserView
		{
			get
			{
				short num = (short)1136766148;
				short num2 = num;
				num = (short)416984260;
				switch (num2 == num)
				{
				}
				num = (short)1963917312;
				if (num != 0)
				{
				}
				num = (short)84279296;
				short num3 = num;
				num = (short)1725497345;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
			set
			{
				short num = (short)1698122608;
				short num2 = num;
				num = (short)1915505520;
				switch (num2 == num)
				{
				}
				num = (short)815071233;
				if (num != 0)
				{
				}
				num = (short)1486684160;
				short num3 = num;
				num = (short)1775042560;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x06000567 RID: 1383 RVA: 0x0005A7A4 File Offset: 0x000589A4
		// (set) Token: 0x06000568 RID: 1384 RVA: 0x0005A854 File Offset: 0x00058A54
		int global::AcpCommonLib.IAcpField.DataTransferOrder
		{
			get
			{
				short num = (short)1708064769;
				if (num != 0)
				{
				}
				num = (short)530029207;
				short num2 = num;
				num = (short)1212783255;
				switch (num2 == num)
				{
				}
				num = (short)492175360;
				short num3 = num;
				num = (short)457506816;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
			set
			{
				short num = (short)1216875897;
				short num2 = num;
				num = (short)1775308153;
				switch (num2 == num)
				{
				}
				num = (short)2052915200;
				if (num != 0)
				{
				}
				num = (short)1638465536;
				short num3 = num;
				num = (short)286130177;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x06000569 RID: 1385 RVA: 0x0005A904 File Offset: 0x00058B04
		// (set) Token: 0x0600056A RID: 1386 RVA: 0x0005A9B0 File Offset: 0x00058BB0
		bool global::AcpCommonLib.IAcpField.IgnoreOnCompare
		{
			get
			{
				short num = (short)1646614403;
				short num2 = num;
				num = (short)995972995;
				switch (num2 == num)
				{
				}
				num = (short)1968898049;
				if (num != 0)
				{
				}
				num = (short)622067712;
				short num3 = num;
				num = (short)110100480;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
			set
			{
				short num = (short)947716097;
				if (num != 0)
				{
				}
				num = (short)1303074733;
				short num2 = num;
				num = (short)2146391981;
				switch (num2 == num)
				{
				}
				num = (short)1916338176;
				short num3 = num;
				num = (short)361955328;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x0600056B RID: 1387 RVA: 0x0005AA60 File Offset: 0x00058C60
		// (set) Token: 0x0600056C RID: 1388 RVA: 0x0005AB0C File Offset: 0x00058D0C
		bool global::AcpCommonLib.IAcpField.IgnoreOnPrint
		{
			get
			{
				short num = (short)1171710306;
				short num2 = num;
				num = (short)275243362;
				switch (num2 == num)
				{
				}
				num = (short)1553137665;
				if (num != 0)
				{
				}
				num = (short)1571094528;
				short num3 = num;
				num = (short)1919418368;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
			set
			{
				short num = (short)109639982;
				short num2 = num;
				num = (short)491649326;
				switch (num2 == num)
				{
				}
				num = (short)223870976;
				if (num != 0)
				{
				}
				num = (short)1704984576;
				short num3 = num;
				num = (short)1980432385;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x0600056D RID: 1389 RVA: 0x0005ABBC File Offset: 0x00058DBC
		// (set) Token: 0x0600056E RID: 1390 RVA: 0x0005AC6C File Offset: 0x00058E6C
		bool global::AcpCommonLib.IAcpField.IsMasked
		{
			get
			{
				short num = (short)1649802625;
				short num2 = num;
				num = (short)1435172225;
				switch (num2 == num)
				{
				}
				num = (short)318046208;
				if (num != 0)
				{
				}
				num = (short)1735786496;
				short num3 = num;
				num = (short)142409729;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
			set
			{
				short num = (short)1318604764;
				short num2 = num;
				num = (short)505499612;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1399390208;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)151781376;
				if (num != 0)
				{
				}
				num = (short)2013659137;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x0600056F RID: 1391 RVA: 0x0005AD18 File Offset: 0x00058F18
		global::AcpCommonLib.IAcpFeatureNode global::AcpCommonLib.IAcpField.ParentNode
		{
			get
			{
				short num = (short)1682289156;
				short num2 = num;
				num = (short)250655236;
				switch (num2 == num)
				{
				default:
				{
					num = (short)430702592;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2026962944;
				if (num != 0)
				{
				}
				num = (short)308412417;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x06000570 RID: 1392 RVA: 0x0005ADC8 File Offset: 0x00058FC8
		// (set) Token: 0x06000571 RID: 1393 RVA: 0x0005AE78 File Offset: 0x00059078
		bool global::AcpCommonLib.IAcpField._HasDiffs
		{
			get
			{
				short num = (short)580614950;
				short num2 = num;
				num = (short)1027636006;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1152450560;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1825177601;
				if (num != 0)
				{
				}
				num = (short)1103626240;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
			set
			{
				short num = (short)1091363569;
				short num2 = num;
				num = (short)1476190961;
				switch (num2 == num)
				{
				default:
				{
					num = (short)272302080;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)820641792;
				if (num != 0)
				{
				}
				num = (short)259784705;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x06000572 RID: 1394 RVA: 0x0005AF28 File Offset: 0x00059128
		// (set) Token: 0x06000573 RID: 1395 RVA: 0x0005AFD8 File Offset: 0x000591D8
		bool global::AcpCommonLib.IAcpField.KeyNameField
		{
			get
			{
				short num = (short)1818696254;
				short num2 = num;
				num = (short)2024348222;
				switch (num2 == num)
				{
				default:
				{
					num = (short)931004416;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1151860737;
				if (num != 0)
				{
				}
				num = (short)220790784;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
			set
			{
				short num = (short)254790136;
				short num2 = num;
				num = (short)1633929720;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1331822592;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1616117761;
				if (num != 0)
				{
				}
				num = (short)1969684480;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x06000574 RID: 1396 RVA: 0x0005B088 File Offset: 0x00059288
		int global::System.IComparable.b(object A_0)
		{
			short num = (short)1098281781;
			short num2 = num;
			num = (short)613643061;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1245446144;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1213661184;
			if (num != 0)
			{
			}
			num = (short)560136193;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x06000575 RID: 1397 RVA: 0x0005B138 File Offset: 0x00059338
		// (set) Token: 0x06000576 RID: 1398 RVA: 0x0005B210 File Offset: 0x00059410
		public int Value
		{
			get
			{
				short num = (short)319116338;
				short num2 = num;
				num = (short)452875314;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1767374848;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)363462656;
				if (num != 0)
				{
				}
				num = (short)48627713;
				if (num != 0)
				{
				}
				int result = this.field.VoiceData.ReadByte();
				global::System.IO.MemoryStream voiceData = this.field.VoiceData;
				long position = voiceData.Position;
				voiceData.Position = position - 1L;
				return result;
			}
			set
			{
				short num = (short)497490930;
				short num2 = num;
				num = (short)1168841714;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2018574336;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1269628929;
				if (num != 0)
				{
				}
				num = (short)660013056;
				if (num != 0)
				{
				}
				throw new global::System.NotSupportedException();
			}
		}

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x06000577 RID: 1399 RVA: 0x0005B2BC File Offset: 0x000594BC
		// (set) Token: 0x06000578 RID: 1400 RVA: 0x0005B368 File Offset: 0x00059568
		bool global::AcpCommonLib.IAcpRecordset.HideRecordsFromTree
		{
			get
			{
				short num = (short)1701921444;
				short num2 = num;
				num = (short)611009188;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1891041280;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1827602433;
				if (num != 0)
				{
				}
				num = (short)2139815936;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
			set
			{
				short num = (short)928207482;
				short num2 = num;
				num = (short)1067668090;
				switch (num2 == num)
				{
				default:
				{
					num = (short)862912512;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1307443201;
				if (num != 0)
				{
				}
				num = (short)1502674944;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x06000579 RID: 1401 RVA: 0x0005B418 File Offset: 0x00059618
		// (set) Token: 0x0600057A RID: 1402 RVA: 0x0005B4C8 File Offset: 0x000596C8
		bool global::AcpCommonLib.IAcpRecordset.HiddenStatic
		{
			get
			{
				short num = (short)1678274244;
				short num2 = num;
				num = (short)124219076;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1584857088;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)567803905;
				if (num != 0)
				{
				}
				num = (short)1282277376;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
			set
			{
				short num = (short)647159906;
				short num2 = num;
				num = (short)1085792354;
				switch (num2 == num)
				{
				default:
				{
					num = (short)760807424;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1811349505;
				if (num != 0)
				{
				}
				num = (short)926416896;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x0600057B RID: 1403 RVA: 0x0005B574 File Offset: 0x00059774
		// (set) Token: 0x0600057C RID: 1404 RVA: 0x0005B620 File Offset: 0x00059820
		public bool BlockDataTransfer
		{
			get
			{
				short num = (short)1258740770;
				short num2 = num;
				num = (short)910023714;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1448083456;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1691615232;
				if (num != 0)
				{
				}
				num = (short)683868161;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
			internal set
			{
				short num = (short)1546449923;
				short num2 = num;
				num = (short)2093806595;
				switch (num2 == num)
				{
				default:
				{
					num = (short)151322624;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1578303489;
				if (num != 0)
				{
				}
				num = (short)1605632000;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x0600057D RID: 1405 RVA: 0x0005B6D0 File Offset: 0x000598D0
		// (set) Token: 0x0600057E RID: 1406 RVA: 0x0005B780 File Offset: 0x00059980
		public bool Protected
		{
			get
			{
				short num = (short)604881540;
				short num2 = num;
				num = (short)2072953476;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1300692992;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)572915713;
				if (num != 0)
				{
				}
				num = (short)286851072;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
			set
			{
				short num = (short)2109673891;
				short num2 = num;
				num = (short)1912148387;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1735196672;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)953679872;
				if (num != 0)
				{
				}
				num = (short)1594556417;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x0600057F RID: 1407 RVA: 0x0005B82C File Offset: 0x00059A2C
		public void ResetToDefaultWithUndo()
		{
			short num = (short)1514806288;
			short num2 = num;
			num = (short)1988238352;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1997078528;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1583153153;
			if (num != 0)
			{
			}
			num = (short)270336000;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x06000580 RID: 1408 RVA: 0x0005B8DC File Offset: 0x00059ADC
		// (set) Token: 0x06000581 RID: 1409 RVA: 0x0005B988 File Offset: 0x00059B88
		public int FieldId
		{
			get
			{
				short num = (short)246975876;
				short num2 = num;
				num = (short)1962184068;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2005270528;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1732116480;
				if (num != 0)
				{
				}
				num = (short)1273561089;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
			set
			{
				short num = (short)1890425614;
				short num2 = num;
				num = (short)960797454;
				switch (num2 == num)
				{
				default:
				{
					num = (short)776273920;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1546518529;
				if (num != 0)
				{
				}
				num = (short)526909440;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x06000582 RID: 1410 RVA: 0x0005BA34 File Offset: 0x00059C34
		// (set) Token: 0x06000583 RID: 1411 RVA: 0x0005BAE4 File Offset: 0x00059CE4
		public bool HiddenStatic
		{
			get
			{
				short num = (short)672622884;
				short num2 = num;
				num = (short)850684196;
				switch (num2 == num)
				{
				default:
				{
					num = (short)208076800;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1235484672;
				if (num != 0)
				{
				}
				num = (short)1098252289;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
			set
			{
				short num = (short)1199741990;
				short num2 = num;
				num = (short)498179110;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1068892160;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)619249665;
				if (num != 0)
				{
				}
				num = (short)1893466112;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x06000584 RID: 1412 RVA: 0x0005BB90 File Offset: 0x00059D90
		// (set) Token: 0x06000585 RID: 1413 RVA: 0x0005BC3C File Offset: 0x00059E3C
		public global::AcpCommonLib.Permissions Permissions
		{
			get
			{
				short num = (short)1397250455;
				short num2 = num;
				num = (short)266623383;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1587609600;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1148256257;
				if (num != 0)
				{
				}
				num = (short)37027840;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
			set
			{
				short num = (short)1568829324;
				short num2 = num;
				num = (short)1621258124;
				switch (num2 == num)
				{
				default:
				{
					num = (short)91357184;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)456196096;
				if (num != 0)
				{
				}
				num = (short)850984961;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x06000586 RID: 1414 RVA: 0x0005BCE8 File Offset: 0x00059EE8
		// (set) Token: 0x06000587 RID: 1415 RVA: 0x0005BD98 File Offset: 0x00059F98
		public bool CloneEnabled
		{
			get
			{
				short num = (short)826307790;
				short num2 = num;
				num = (short)884241614;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1746862080;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)322830337;
				if (num != 0)
				{
				}
				num = (short)489750528;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
			set
			{
				short num = (short)239135156;
				short num2 = num;
				num = (short)1418389940;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1229651968;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2120876033;
				if (num != 0)
				{
				}
				num = (short)257490944;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x06000588 RID: 1416 RVA: 0x0005BE4C File Offset: 0x0005A04C
		// (set) Token: 0x06000589 RID: 1417 RVA: 0x0005BF00 File Offset: 0x0005A100
		public bool ZoneCloneEnabled
		{
			get
			{
				short num = (short)12562926;
				short num2 = num;
				num = (short)1648472558;
				switch (num2 == num)
				{
				default:
				{
					num = (short)131989504;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)275185665;
				if (num != 0)
				{
				}
				num = (short)991494144;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
			set
			{
				short num = (short)476617047;
				short num2 = num;
				num = (short)542021975;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1787101184;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1195638785;
				if (num != 0)
				{
				}
				num = (short)678166528;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x0600058A RID: 1418 RVA: 0x0005BFB0 File Offset: 0x0005A1B0
		protected virtual void w(bool A_0)
		{
			short num = (short)2038285460;
			short num2 = num;
			num = (short)774096020;
			switch (num2 == num)
			{
			default:
			{
				num = (short)590020608;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)516227072;
			if (num != 0)
			{
			}
			num = (short)11862017;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600058B RID: 1419 RVA: 0x0005C058 File Offset: 0x0005A258
		public void Dispose()
		{
			short num = (short)158175464;
			short num2 = num;
			num = (short)409899240;
			switch (num2 == num)
			{
			default:
			{
				num = (short)856686592;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1318322176;
			if (num != 0)
			{
			}
			num = (short)1986789377;
			if (num != 0)
			{
			}
			this.w(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x04000188 RID: 392
		private global::AcpBusinessLayer.AcpVoiceFileField field;
	}
}
