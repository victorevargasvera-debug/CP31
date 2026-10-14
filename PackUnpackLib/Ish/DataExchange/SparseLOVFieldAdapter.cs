using System;
using System.Collections.Generic;
using System.Xml;
using AcpBusinessLayer;
using AcpCommonLib;
using AcpCommonLib.UndoRedo;
using Motorola.Acp.PackUnpack.Ish.Collections;

namespace Motorola.Acp.PackUnpack.Ish.DataExchange
{
	// Token: 0x0200008D RID: 141
	internal class SparseLOVFieldAdapter : global::AcpCommonLib.IAcpRecordset, global::AcpCommonLib.IAcpConstraints, global::AcpCommonLib.IAcpCommon, global::System.IDisposable, global::AcpCommonLib.IAcpFeatureNode, global::AcpCommonLib.IAcpFeatureSection, global::AcpCommonLib.IAcpField, global::System.IComparable
	{
		// Token: 0x06000408 RID: 1032 RVA: 0x0004B188 File Offset: 0x00049388
		internal SparseLOVFieldAdapter(global::AcpBusinessLayer.AcpSparseLOVField A_0)
		{
			this.values = new int[A_0.Items.Count];
			int num = 0;
			foreach (int num2 in A_0.Values)
			{
				this.values[num++] = num2;
			}
			this.list = A_0;
			this.nodeIndex = 0;
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x06000409 RID: 1033 RVA: 0x0004B214 File Offset: 0x00049414
		internal global::AcpBusinessLayer.AcpSparseLOVField SparseLOVField
		{
			get
			{
				short num = (short)204996609;
				if (num != 0)
				{
				}
				num = (short)911180942;
				short num2 = num;
				num = (short)1963623566;
				switch (num2 == num)
				{
				}
				num = (short)2121596928;
				short num3 = num;
				num = (short)2106654720;
				if (num != 0)
				{
				}
				return this.list;
			}
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x0004B2C8 File Offset: 0x000494C8
		void global::AcpCommonLib.IAcpRecordset.b()
		{
			short num = (short)1872609804;
			short num2 = num;
			num = (short)1380041228;
			switch (num2 == num)
			{
			}
			num = (short)1053032448;
			if (num != 0)
			{
			}
			num = (short)1109327872;
			short num3 = num;
			num = (short)2030764033;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x0004B378 File Offset: 0x00049578
		void global::AcpCommonLib.IAcpRecordset.c()
		{
			short num = (short)1470620940;
			short num2 = num;
			num = (short)1010885900;
			switch (num2 == num)
			{
			}
			num = (short)1787822081;
			if (num != 0)
			{
			}
			num = (short)604307456;
			short num3 = num;
			num = (short)1855127552;
			if (num != 0)
			{
			}
			this.list.Items.Clear();
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x0600040C RID: 1036 RVA: 0x0004B430 File Offset: 0x00049630
		int global::AcpCommonLib.IAcpRecordset.RecsetId
		{
			get
			{
				short num = (short)1726778523;
				short num2 = num;
				num = (short)1996590235;
				switch (num2 == num)
				{
				}
				num = (short)1144258561;
				if (num != 0)
				{
				}
				num = (short)541458432;
				short num3 = num;
				num = (short)1744109568;
				if (num != 0)
				{
				}
				return this.list.Parent.Parent.Parent.RecsetId;
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x0600040D RID: 1037 RVA: 0x0004B4F0 File Offset: 0x000496F0
		string global::AcpCommonLib.IAcpRecordset.RecordsetName
		{
			get
			{
				short num = (short)1133981365;
				short num2 = num;
				num = (short)1829908149;
				switch (num2 == num)
				{
				}
				num = (short)2116222977;
				if (num != 0)
				{
				}
				num = (short)1110900736;
				short num3 = num;
				num = (short)260964352;
				if (num != 0)
				{
				}
				return this.list.Parent.Parent.Parent.RecordsetName;
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x0600040E RID: 1038 RVA: 0x0004B5B4 File Offset: 0x000497B4
		bool global::AcpCommonLib.IAcpRecordset.SingleInstance
		{
			get
			{
				short num = (short)1912874780;
				short num2 = num;
				num = (short)896018204;
				switch (num2 == num)
				{
				}
				num = (short)379912193;
				if (num != 0)
				{
				}
				num = (short)1472921600;
				short num3 = num;
				num = (short)1960706048;
				if (num != 0)
				{
				}
				return this.list.Parent.Parent.Parent.SingleInstance;
			}
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x0600040F RID: 1039 RVA: 0x0004B678 File Offset: 0x00049878
		string global::AcpCommonLib.IAcpRecordset.UIPagePath
		{
			get
			{
				short num = (short)948242915;
				short num2 = num;
				num = (short)864487907;
				switch (num2 == num)
				{
				}
				num = (short)1651965953;
				if (num != 0)
				{
				}
				num = (short)810024960;
				short num3 = num;
				num = (short)994967552;
				if (num != 0)
				{
				}
				return this.list.Parent.Parent.Parent.UIPagePath;
			}
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x06000410 RID: 1040 RVA: 0x0004B740 File Offset: 0x00049940
		int global::AcpCommonLib.IAcpRecordset.Count
		{
			get
			{
				short num = (short)1603255206;
				short num2 = num;
				num = (short)676248486;
				switch (num2 == num)
				{
				}
				num = (short)1197211649;
				if (num != 0)
				{
				}
				num = (short)1922498560;
				short num3 = num;
				num = (short)759562240;
				if (num != 0)
				{
				}
				return this.list.Items.Count;
			}
		}

		// Token: 0x06000411 RID: 1041 RVA: 0x0004B7FC File Offset: 0x000499FC
		global::AcpCommonLib.IAcpFeatureNode global::AcpCommonLib.IAcpRecordset.i()
		{
			int a_ = 15;
			short num = (short)1989777394;
			short num2 = num;
			num = (short)1397987314;
			switch (num2 == num)
			{
			}
			num = (short)728956929;
			if (num != 0)
			{
			}
			num = (short)1529217024;
			short num3 = num;
			num = (short)462225408;
			if (num != 0)
			{
			}
			this.list.AddItem(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("춧첩춫\udbad\udcaf욱", a_));
			this.nodeIndex = this.list.Items.Count - 1;
			return this;
		}

		// Token: 0x06000412 RID: 1042 RVA: 0x0004B8E0 File Offset: 0x00049AE0
		int global::AcpCommonLib.IAcpRecordset.a(int A_0)
		{
			int a_ = 11;
			short num = (short)341180419;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_198;
				case 1:
				{
					int num3;
					if (num3 >= A_0)
					{
						num = (short)1584857088;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					this.list.AddItem(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("솣삥즧\udfa9삫\udaad", a_));
					num3++;
					num = (short)657260546;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					goto IL_166;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_45;
					}
					continue;
				case 4:
					goto IL_166;
				case 5:
					goto IL_FF;
				}
				IL_45:
				num = (short)1668743169;
				if (num != 0)
				{
				}
				num = (short)642892072;
				short num4 = num;
				num = (short)1139917096;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_166:
					num = (short)1249968129;
					num2 = (int)((global::System.IntPtr)num);
					break;
				default:
				{
					num = (short)1912668160;
					short num5 = num;
					num = (short)1796800512;
					if (num != 0)
					{
					}
					if (A_0 <= 0)
					{
						num = (short)2075459589;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						int num3 = 0;
						num = (short)1993080836;
						num2 = (int)((global::System.IntPtr)num);
					}
					break;
				}
				}
			}
			IL_FF:
			throw new global::System.ArgumentOutOfRangeException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("송쮣펥욧\udea9", a_));
			IL_198:
			this.nodeIndex = this.list.Items.Count - 1;
			return A_0;
		}

		// Token: 0x06000413 RID: 1043 RVA: 0x0004BAA0 File Offset: 0x00049CA0
		void global::AcpCommonLib.IAcpRecordset.b(int A_0)
		{
			short num = (short)1382727651;
			short num2 = num;
			num = (short)798212067;
			switch (num2 == num)
			{
			}
			num = (short)1240137729;
			if (num != 0)
			{
			}
			num = (short)1234042880;
			short num3 = num;
			num = (short)1209991168;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x0004BB4C File Offset: 0x00049D4C
		void global::AcpCommonLib.IAcpRecordset.a(int A_0, int A_1)
		{
			short num = (short)962233452;
			short num2 = num;
			num = (short)1899463788;
			switch (num2 == num)
			{
			}
			num = (short)1533870080;
			if (num != 0)
			{
			}
			num = (short)178061312;
			short num3 = num;
			num = (short)1647116289;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x170000FC RID: 252
		global::AcpCommonLib.IAcpFeatureNode global::AcpCommonLib.IAcpRecordset.this[int A_0]
		{
			get
			{
				int a_ = 3;
				short num = (short)1119289347;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						num = (short)787611649;
						if (num != 0)
						{
						}
						num = (short)1659305986;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_153;
					case 2:
						if (A_0 >= this.list.Items.Count)
						{
							num = (short)1534132225;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_158;
					case 3:
					{
						num = (short)1336083235;
						short num3 = num;
						num = (short)274727715;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
						{
							num = (short)382926848;
							short num4 = num;
							num = (short)2045444096;
							if (num != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_B7;
							}
							continue;
						}
						}
						break;
					}
					}
					IL_B7:
					if (A_0 >= 0)
					{
						goto IL_158;
					}
					num = (short)675282944;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_153:
				throw new global::System.ArgumentOutOfRangeException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("瞧얟\udaa1", a_));
				IL_158:
				this.nodeIndex = A_0;
				return this;
			}
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x0004BD6C File Offset: 0x00049F6C
		int global::AcpCommonLib.IAcpRecordset.a(global::AcpCommonLib.IAcpFeatureNode A_0)
		{
			short num = (short)203586178;
			short num2 = num;
			num = (short)2124577410;
			switch (num2 == num)
			{
			}
			num = (short)2076246017;
			if (num != 0)
			{
			}
			num = (short)1536098304;
			short num3 = num;
			num = (short)1931214848;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x0004BE18 File Offset: 0x0004A018
		global::AcpCommonLib.IAcpFeatureNode global::AcpCommonLib.IAcpRecordset.d(int A_0)
		{
			short num = (short)706581545;
			short num2 = num;
			num = (short)1894880297;
			switch (num2 == num)
			{
			}
			num = (short)507904001;
			if (num != 0)
			{
			}
			num = (short)1087766528;
			short num3 = num;
			num = (short)505020416;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000418 RID: 1048 RVA: 0x0004BEC4 File Offset: 0x0004A0C4
		global::AcpCommonLib.IAcpFeatureNode global::AcpCommonLib.IAcpRecordset.a(string A_0)
		{
			short num = (short)1242154732;
			short num2 = num;
			num = (short)1877722860;
			switch (num2 == num)
			{
			}
			num = (short)1598423041;
			if (num != 0)
			{
			}
			num = (short)916520960;
			short num3 = num;
			num = (short)1617821696;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x06000419 RID: 1049 RVA: 0x0004BF74 File Offset: 0x0004A174
		bool global::AcpCommonLib.IAcpRecordset.HasEmbeddedRecset
		{
			get
			{
				short num = (short)306511873;
				if (num != 0)
				{
				}
				num = (short)75061824;
				short num2 = num;
				num = (short)1906006592;
				switch (num2 == num)
				{
				}
				num = (short)1898840064;
				short num3 = num;
				num = (short)1998323712;
				if (num != 0)
				{
				}
				return false;
			}
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x0600041A RID: 1050 RVA: 0x0004C01C File Offset: 0x0004A21C
		bool global::AcpCommonLib.IAcpRecordset.IsEmbeddedRecset
		{
			get
			{
				short num = (short)187164047;
				short num2 = num;
				num = (short)1204872591;
				switch (num2 == num)
				{
				}
				num = (short)1671561216;
				if (num != 0)
				{
				}
				num = (short)619577344;
				short num3 = num;
				num = (short)671875073;
				if (num != 0)
				{
				}
				return false;
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x0600041B RID: 1051 RVA: 0x0004C0C8 File Offset: 0x0004A2C8
		bool global::AcpCommonLib.IAcpRecordset.HasKeyField
		{
			get
			{
				short num = (short)717160449;
				if (num != 0)
				{
				}
				num = (short)262487577;
				short num2 = num;
				num = (short)1922317849;
				switch (num2 == num)
				{
				}
				num = (short)619708416;
				short num3 = num;
				num = (short)810287104;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x0600041C RID: 1052 RVA: 0x0004C178 File Offset: 0x0004A378
		global::AcpCommonLib.IAcpFeatureSection global::AcpCommonLib.IAcpRecordset.ParentSection
		{
			get
			{
				short num = (short)578496257;
				short num2 = num;
				num = (short)577120001;
				switch (num2 == num)
				{
				}
				num = (short)386924545;
				if (num != 0)
				{
				}
				num = (short)957808640;
				short num3 = num;
				num = (short)680067072;
				if (num != 0)
				{
				}
				return null;
			}
		}

		// Token: 0x0600041D RID: 1053 RVA: 0x0004C220 File Offset: 0x0004A420
		global::System.Collections.Generic.IEnumerable<global::AcpCommonLib.IAcpField> global::AcpCommonLib.IAcpRecordset.b(string A_0)
		{
			short num = (short)448347187;
			short num2 = num;
			num = (short)971193395;
			switch (num2 == num)
			{
			}
			num = (short)1506869248;
			if (num != 0)
			{
			}
			num = (short)1137573888;
			short num3 = num;
			num = (short)1250754561;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600041E RID: 1054 RVA: 0x0004C2CC File Offset: 0x0004A4CC
		global::System.Collections.Generic.IEnumerable<global::AcpCommonLib.IAcpField> global::AcpCommonLib.IAcpRecordset.c(string A_0)
		{
			short num = (short)859850674;
			short num2 = num;
			num = (short)1009141682;
			switch (num2 == num)
			{
			}
			num = (short)576585729;
			if (num != 0)
			{
			}
			num = (short)274464768;
			short num3 = num;
			num = (short)1827471360;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600041F RID: 1055 RVA: 0x0004C37C File Offset: 0x0004A57C
		bool global::AcpCommonLib.IAcpRecordset.a(global::System.Xml.XmlNode A_0, global::AcpCommonLib.XmlFileType A_1)
		{
			short num = (short)1224440712;
			short num2 = num;
			num = (short)234912648;
			switch (num2 == num)
			{
			}
			num = (short)1247346689;
			if (num != 0)
			{
			}
			num = (short)1046282240;
			short num3 = num;
			num = (short)1226768384;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000420 RID: 1056 RVA: 0x0004C42C File Offset: 0x0004A62C
		bool global::AcpCommonLib.IAcpRecordset.a(global::System.Xml.XmlNode A_0, global::AcpCommonLib.UndoRedo.ContainerTask A_1, global::AcpCommonLib.XmlFileType A_2, bool A_3, global::System.Collections.Generic.Dictionary<global::AcpCommonLib.IAcpField, string> A_4, global::System.Collections.Generic.Dictionary<global::AcpCommonLib.IAcpField, string> A_5)
		{
			short num = (short)1204523805;
			short num2 = num;
			num = (short)1003328285;
			switch (num2 == num)
			{
			}
			num = (short)735576065;
			if (num != 0)
			{
			}
			num = (short)44171264;
			short num3 = num;
			num = (short)1909391360;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x0004C4DC File Offset: 0x0004A6DC
		void global::AcpCommonLib.IAcpRecordset.a(global::AcpCommonLib.IAcpRecordset A_0, global::AcpCommonLib.UndoRedo.ContainerTask A_1)
		{
			short num = (short)1928899000;
			short num2 = num;
			num = (short)1927195064;
			switch (num2 == num)
			{
			}
			num = (short)1184366593;
			if (num != 0)
			{
			}
			num = (short)80609280;
			short num3 = num;
			num = (short)307363840;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x06000422 RID: 1058 RVA: 0x0004C58C File Offset: 0x0004A78C
		// (set) Token: 0x06000423 RID: 1059 RVA: 0x0004C63C File Offset: 0x0004A83C
		string global::AcpCommonLib.IAcpRecordset.UIName
		{
			get
			{
				short num = (short)376375616;
				short num2 = num;
				num = (short)1199638848;
				switch (num2 == num)
				{
				}
				num = (short)1923874816;
				if (num != 0)
				{
				}
				num = (short)529530880;
				short num3 = num;
				num = (short)940048385;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
			set
			{
				short num = (short)1013964989;
				short num2 = num;
				num = (short)1249108157;
				switch (num2 == num)
				{
				}
				num = (short)487194624;
				if (num != 0)
				{
				}
				num = (short)171573248;
				short num3 = num;
				num = (short)1456865281;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x06000424 RID: 1060 RVA: 0x0004C6EC File Offset: 0x0004A8EC
		global::AcpCommonLib.IAcpField global::AcpCommonLib.IAcpRecordset.a(string A_0, string A_1)
		{
			short num = (short)815782069;
			short num2 = num;
			num = (short)1036507317;
			switch (num2 == num)
			{
			}
			num = (short)508624896;
			if (num != 0)
			{
			}
			num = (short)1909391360;
			short num3 = num;
			num = (short)1144717313;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000425 RID: 1061 RVA: 0x0004C79C File Offset: 0x0004A99C
		global::AcpCommonLib.IAcpField global::AcpCommonLib.IAcpRecordset.b(string A_0, string A_1)
		{
			short num = (short)370540545;
			if (num != 0)
			{
			}
			num = (short)498649423;
			short num2 = num;
			num = (short)1503250767;
			switch (num2 == num)
			{
			}
			num = (short)1170079744;
			short num3 = num;
			num = (short)1855586304;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x0004C848 File Offset: 0x0004AA48
		void global::AcpCommonLib.IAcpRecordset.a(global::AcpCommonLib.IAcpRecordset A_0)
		{
			short num = (short)454272132;
			short num2 = num;
			num = (short)587179140;
			switch (num2 == num)
			{
			}
			num = (short)616169472;
			if (num != 0)
			{
			}
			num = (short)912588800;
			short num3 = num;
			num = (short)82051073;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x06000427 RID: 1063 RVA: 0x0004C8F8 File Offset: 0x0004AAF8
		// (set) Token: 0x06000428 RID: 1064 RVA: 0x0004C9A4 File Offset: 0x0004ABA4
		int global::AcpCommonLib.IAcpRecordset.DataTransferOrder
		{
			get
			{
				short num = (short)1443648118;
				short num2 = num;
				num = (short)156848758;
				switch (num2 == num)
				{
				}
				num = (short)1474822144;
				if (num != 0)
				{
				}
				num = (short)368050176;
				short num3 = num;
				num = (short)1520304129;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
			set
			{
				short num = (short)877412855;
				short num2 = num;
				num = (short)76497399;
				switch (num2 == num)
				{
				}
				num = (short)1584463873;
				if (num != 0)
				{
				}
				num = (short)595853312;
				short num3 = num;
				num = (short)917176320;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x06000429 RID: 1065 RVA: 0x0004CA54 File Offset: 0x0004AC54
		// (set) Token: 0x0600042A RID: 1066 RVA: 0x0004CB00 File Offset: 0x0004AD00
		global::AcpCommonLib.Document global::AcpCommonLib.IAcpRecordset.ContainerDoc
		{
			get
			{
				short num = (short)2054077088;
				short num2 = num;
				num = (short)1261157024;
				switch (num2 == num)
				{
				}
				num = (short)1346502657;
				if (num != 0)
				{
				}
				num = (short)346619904;
				short num3 = num;
				num = (short)2013462528;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
			set
			{
				short num = (short)1687272477;
				short num2 = num;
				num = (short)549305373;
				switch (num2 == num)
				{
				}
				num = (short)1511915521;
				if (num != 0)
				{
				}
				num = (short)455606272;
				short num3 = num;
				num = (short)1734672384;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x0600042B RID: 1067 RVA: 0x0004CBB4 File Offset: 0x0004ADB4
		// (set) Token: 0x0600042C RID: 1068 RVA: 0x0004CC64 File Offset: 0x0004AE64
		int global::AcpCommonLib.IAcpRecordset.Min
		{
			get
			{
				short num = (short)630001821;
				short num2 = num;
				num = (short)508563613;
				switch (num2 == num)
				{
				}
				num = (short)217776128;
				if (num != 0)
				{
				}
				num = (short)1203306496;
				short num3 = num;
				num = (short)419430401;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
			set
			{
				short num = (short)1410056282;
				short num2 = num;
				num = (short)1756217434;
				switch (num2 == num)
				{
				}
				num = (short)468582401;
				if (num != 0)
				{
				}
				num = (short)1988362240;
				short num3 = num;
				num = (short)1837498368;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x0600042D RID: 1069 RVA: 0x0004CD14 File Offset: 0x0004AF14
		// (set) Token: 0x0600042E RID: 1070 RVA: 0x0004CDC4 File Offset: 0x0004AFC4
		int global::AcpCommonLib.IAcpRecordset.Max
		{
			get
			{
				short num = (short)1309503999;
				short num2 = num;
				num = (short)1881960959;
				switch (num2 == num)
				{
				}
				num = (short)108855297;
				if (num != 0)
				{
				}
				num = (short)771620864;
				short num3 = num;
				num = (short)1538719744;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
			set
			{
				short num = (short)1240388432;
				short num2 = num;
				num = (short)295359312;
				switch (num2 == num)
				{
				}
				num = (short)1116733441;
				if (num != 0)
				{
				}
				num = (short)878706688;
				short num3 = num;
				num = (short)392167424;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x0600042F RID: 1071 RVA: 0x0004CE74 File Offset: 0x0004B074
		int global::AcpCommonLib.IAcpRecordset.CounterToMax
		{
			get
			{
				short num = (short)1023728334;
				short num2 = num;
				num = (short)1003608782;
				switch (num2 == num)
				{
				}
				num = (short)1787756544;
				if (num != 0)
				{
				}
				num = (short)148045824;
				short num3 = num;
				num = (short)890699777;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x06000430 RID: 1072 RVA: 0x0004CF20 File Offset: 0x0004B120
		int global::AcpCommonLib.IAcpRecordset.CounterToMin
		{
			get
			{
				short num = (short)243613201;
				short num2 = num;
				num = (short)931085841;
				switch (num2 == num)
				{
				}
				num = (short)711262209;
				if (num != 0)
				{
				}
				num = (short)238485504;
				short num3 = num;
				num = (short)673972224;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x06000431 RID: 1073 RVA: 0x0004CFD4 File Offset: 0x0004B1D4
		bool global::AcpCommonLib.IAcpRecordset.CanBeEmpty
		{
			get
			{
				short num = (short)57531869;
				short num2 = num;
				num = (short)1326439901;
				switch (num2 == num)
				{
				}
				num = (short)754974721;
				if (num != 0)
				{
				}
				num = (short)1165557760;
				short num3 = num;
				num = (short)2052521984;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x06000432 RID: 1074 RVA: 0x0004D088 File Offset: 0x0004B288
		bool global::AcpCommonLib.IAcpRecordset.PositionBased
		{
			get
			{
				short num = (short)202964993;
				if (num != 0)
				{
				}
				num = (short)1347468563;
				short num2 = num;
				num = (short)1959312659;
				switch (num2 == num)
				{
				}
				num = (short)1750728704;
				short num3 = num;
				num = (short)613679104;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x06000433 RID: 1075 RVA: 0x0004D138 File Offset: 0x0004B338
		string global::AcpCommonLib.IAcpRecordset.e(string A_0)
		{
			short num = (short)382353177;
			short num2 = num;
			num = (short)1647263513;
			switch (num2 == num)
			{
			}
			num = (short)1233453057;
			if (num != 0)
			{
			}
			num = (short)1199112192;
			short num3 = num;
			num = (short)745603072;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000434 RID: 1076 RVA: 0x0004D1E4 File Offset: 0x0004B3E4
		bool global::AcpCommonLib.IAcpRecordset.b(int A_0, int A_1)
		{
			short num = (short)134728358;
			short num2 = num;
			num = (short)1495714470;
			switch (num2 == num)
			{
			}
			num = (short)217972737;
			if (num != 0)
			{
			}
			num = (short)353501184;
			short num3 = num;
			num = (short)41943040;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x0004D294 File Offset: 0x0004B494
		int global::AcpCommonLib.IAcpRecordset.h(int A_0)
		{
			short num = (short)618602705;
			short num2 = num;
			num = (short)551166161;
			switch (num2 == num)
			{
			}
			num = (short)1322057728;
			if (num != 0)
			{
			}
			num = (short)820051968;
			short num3 = num;
			num = (short)910884865;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x06000436 RID: 1078 RVA: 0x0004D340 File Offset: 0x0004B540
		// (set) Token: 0x06000437 RID: 1079 RVA: 0x0004D3EC File Offset: 0x0004B5EC
		bool global::AcpCommonLib.IAcpRecordset.PreDataTransferClearRecordset
		{
			get
			{
				short num = (short)1799789946;
				short num2 = num;
				num = (short)537042298;
				switch (num2 == num)
				{
				}
				num = (short)1883176961;
				if (num != 0)
				{
				}
				num = (short)1914437632;
				short num3 = num;
				num = (short)1748893696;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
			set
			{
				short num = (short)399710249;
				short num2 = num;
				num = (short)185276457;
				switch (num2 == num)
				{
				}
				num = (short)748093441;
				if (num != 0)
				{
				}
				num = (short)361168896;
				short num3 = num;
				num = (short)2146893824;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x06000438 RID: 1080 RVA: 0x0004D498 File Offset: 0x0004B698
		bool global::AcpCommonLib.IAcpRecordset._HasDiffs
		{
			get
			{
				short num = (short)2032285965;
				short num2 = num;
				num = (short)161298701;
				switch (num2 == num)
				{
				}
				num = (short)352583681;
				if (num != 0)
				{
				}
				num = (short)981270528;
				short num3 = num;
				num = (short)970915840;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x06000439 RID: 1081 RVA: 0x0004D548 File Offset: 0x0004B748
		void global::AcpCommonLib.IAcpRecordset.y()
		{
			short num = (short)521936316;
			short num2 = num;
			num = (short)214048188;
			switch (num2 == num)
			{
			}
			num = (short)1218576385;
			if (num != 0)
			{
			}
			num = (short)2011955200;
			short num3 = num;
			num = (short)530251776;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x0600043A RID: 1082 RVA: 0x0004D5F4 File Offset: 0x0004B7F4
		bool global::AcpCommonLib.IAcpRecordset.HasVisibleObjects
		{
			get
			{
				short num = (short)473087587;
				short num2 = num;
				num = (short)6667875;
				switch (num2 == num)
				{
				}
				num = (short)472842241;
				if (num != 0)
				{
				}
				num = (short)57868288;
				short num3 = num;
				num = (short)2104426496;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x0600043B RID: 1083 RVA: 0x0004D6A4 File Offset: 0x0004B8A4
		// (set) Token: 0x0600043C RID: 1084 RVA: 0x0004D750 File Offset: 0x0004B950
		bool global::AcpCommonLib.IAcpRecordset._IsEmpty
		{
			get
			{
				short num = (short)908416969;
				short num2 = num;
				num = (short)1058494409;
				switch (num2 == num)
				{
				}
				num = (short)1311899648;
				if (num != 0)
				{
				}
				num = (short)392364032;
				short num3 = num;
				num = (short)712900609;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
			set
			{
				short num = (short)231681603;
				short num2 = num;
				num = (short)1763454531;
				switch (num2 == num)
				{
				}
				num = (short)1570111489;
				if (num != 0)
				{
				}
				num = (short)1742405632;
				short num3 = num;
				num = (short)605159424;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x0600043D RID: 1085 RVA: 0x0004D800 File Offset: 0x0004BA00
		// (set) Token: 0x0600043E RID: 1086 RVA: 0x0004D8AC File Offset: 0x0004BAAC
		bool global::AcpCommonLib.IAcpRecordset.CalculateHiddenStatic
		{
			get
			{
				short num = (short)1938904673;
				short num2 = num;
				num = (short)1908954721;
				switch (num2 == num)
				{
				}
				num = (short)195821569;
				if (num != 0)
				{
				}
				num = (short)1360723968;
				short num3 = num;
				num = (short)28770304;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
			set
			{
				short num = (short)905637931;
				short num2 = num;
				num = (short)1491857451;
				switch (num2 == num)
				{
				}
				num = (short)1017708545;
				if (num != 0)
				{
				}
				num = (short)722010112;
				short num3 = num;
				num = (short)593035264;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x0600043F RID: 1087 RVA: 0x0004D958 File Offset: 0x0004BB58
		void global::AcpCommonLib.IAcpConstraints.ac()
		{
			short num = (short)268949537;
			short num2 = num;
			num = (short)341760033;
			switch (num2 == num)
			{
			}
			num = (short)1585840128;
			if (num != 0)
			{
			}
			num = (short)1468006400;
			short num3 = num;
			num = (short)644743169;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000440 RID: 1088 RVA: 0x0004DA04 File Offset: 0x0004BC04
		void global::AcpCommonLib.IAcpConstraints.ad()
		{
			short num = (short)1375157468;
			short num2 = num;
			num = (short)1521171676;
			switch (num2 == num)
			{
			}
			num = (short)274595840;
			if (num != 0)
			{
			}
			num = (short)1898381312;
			short num3 = num;
			num = (short)143851521;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000441 RID: 1089 RVA: 0x0004DAB0 File Offset: 0x0004BCB0
		void global::AcpCommonLib.IAcpConstraints.ae()
		{
			short num = (short)346048131;
			short num2 = num;
			num = (short)676611715;
			switch (num2 == num)
			{
			}
			num = (short)1632501761;
			if (num != 0)
			{
			}
			num = (short)1882324992;
			short num3 = num;
			num = (short)480772096;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000442 RID: 1090 RVA: 0x0004DB60 File Offset: 0x0004BD60
		void global::AcpCommonLib.IAcpConstraints.af()
		{
			short num = (short)732430337;
			if (num != 0)
			{
			}
			num = (short)1367757294;
			short num2 = num;
			num = (short)246501870;
			switch (num2 == num)
			{
			}
			num = (short)35913728;
			short num3 = num;
			num = (short)2019360768;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000443 RID: 1091 RVA: 0x0004DC14 File Offset: 0x0004BE14
		void global::AcpCommonLib.IAcpConstraints.ag()
		{
			short num = (short)1287578339;
			short num2 = num;
			num = (short)1942020835;
			switch (num2 == num)
			{
			}
			num = (short)2062352385;
			if (num != 0)
			{
			}
			num = (short)2018705408;
			short num3 = num;
			num = (short)1819344896;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000444 RID: 1092 RVA: 0x0004DCC8 File Offset: 0x0004BEC8
		void global::AcpCommonLib.IAcpConstraints.ah()
		{
			short num = (short)1351820661;
			short num2 = num;
			num = (short)189539701;
			switch (num2 == num)
			{
			}
			num = (short)1175584768;
			if (num != 0)
			{
			}
			num = (short)912916480;
			short num3 = num;
			num = (short)709754881;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000445 RID: 1093 RVA: 0x0004DD78 File Offset: 0x0004BF78
		void global::AcpCommonLib.IAcpConstraints.d(bool A_0)
		{
			short num = (short)1077298782;
			short num2 = num;
			num = (short)2057193054;
			switch (num2 == num)
			{
			}
			num = (short)1294139393;
			if (num != 0)
			{
			}
			num = (short)1434845184;
			short num3 = num;
			num = (short)481427456;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000446 RID: 1094 RVA: 0x0004DE28 File Offset: 0x0004C028
		void global::AcpCommonLib.IAcpConstraints.e(bool A_0)
		{
			short num = (short)1353658670;
			short num2 = num;
			num = (short)1163538734;
			switch (num2 == num)
			{
			}
			num = (short)1103757313;
			if (num != 0)
			{
			}
			num = (short)123207680;
			short num3 = num;
			num = (short)715980800;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000447 RID: 1095 RVA: 0x0004DED4 File Offset: 0x0004C0D4
		void global::AcpCommonLib.IAcpCommon.ai()
		{
			short num = (short)1838543446;
			short num2 = num;
			num = (short)415822422;
			switch (num2 == num)
			{
			}
			num = (short)210829313;
			if (num != 0)
			{
			}
			num = (short)2100625408;
			short num3 = num;
			num = (short)752156672;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x06000448 RID: 1096 RVA: 0x0004DF84 File Offset: 0x0004C184
		// (set) Token: 0x06000449 RID: 1097 RVA: 0x0004E030 File Offset: 0x0004C230
		global::AcpCommonLib.IAcpRecordset global::AcpCommonLib.IAcpFeatureNode.Parent
		{
			get
			{
				short num = (short)260174701;
				short num2 = num;
				num = (short)914551661;
				switch (num2 == num)
				{
				}
				num = (short)314179585;
				if (num != 0)
				{
				}
				num = (short)625344512;
				short num3 = num;
				num = (short)1772552192;
				if (num != 0)
				{
				}
				return this;
			}
			set
			{
				while (value == this)
				{
					short num = (short)1016229554;
					short num2 = num;
					num = (short)37973682;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)955580416;
						short num3 = num;
						num = (short)42336257;
						if (num != 0)
						{
						}
						num = (short)411107328;
						if (num != 0)
						{
						}
						return;
					}
					}
				}
				throw new global::System.NotSupportedException();
			}
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x0600044A RID: 1098 RVA: 0x0004E0E8 File Offset: 0x0004C2E8
		// (set) Token: 0x0600044B RID: 1099 RVA: 0x0004E19C File Offset: 0x0004C39C
		string global::AcpCommonLib.IAcpFeatureNode.FeatureName
		{
			get
			{
				short num = (short)1471512043;
				short num2 = num;
				num = (short)1541045739;
				switch (num2 == num)
				{
				default:
				{
					num = (short)374669312;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)389283841;
				if (num != 0)
				{
				}
				num = (short)1853030400;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
			set
			{
				short num = (short)636406220;
				short num2 = num;
				num = (short)142330316;
				switch (num2 == num)
				{
				default:
				{
					num = (short)202178560;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1079967745;
				if (num != 0)
				{
				}
				num = (short)1849884672;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x0600044C RID: 1100 RVA: 0x0004E24C File Offset: 0x0004C44C
		string global::AcpCommonLib.IAcpFeatureNode.ReferenceKey
		{
			get
			{
				short num = (short)1103626241;
				if (num != 0)
				{
				}
				num = (short)1560936448;
				short num2 = num;
				num = (short)1928414981;
				short num3 = num;
				num = (short)1726498565;
				switch (num3 == num)
				{
				}
				num = (short)746717184;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x0600044D RID: 1101 RVA: 0x0004E2F8 File Offset: 0x0004C4F8
		int global::AcpCommonLib.IAcpFeatureNode.NodeId
		{
			get
			{
				short num = (short)1270639076;
				short num2 = num;
				num = (short)807954916;
				switch (num2 == num)
				{
				default:
				{
					num = (short)32505856;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1459683329;
				if (num != 0)
				{
				}
				num = (short)218365952;
				if (num != 0)
				{
				}
				return this.nodeIndex;
			}
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x0600044E RID: 1102 RVA: 0x0004E3A4 File Offset: 0x0004C5A4
		string global::AcpCommonLib.IAcpFeatureNode.UIPagePath
		{
			get
			{
				short num = (short)1969356801;
				if (num != 0)
				{
				}
				num = (short)291569664;
				short num2 = num;
				num = (short)1272959950;
				short num3 = num;
				num = (short)1618072526;
				switch (num3 == num)
				{
				}
				num = (short)1313996800;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x0600044F RID: 1103 RVA: 0x0004E454 File Offset: 0x0004C654
		// (set) Token: 0x06000450 RID: 1104 RVA: 0x0004E504 File Offset: 0x0004C704
		string global::AcpCommonLib.IAcpFeatureNode.TreeNodeLabel
		{
			get
			{
				short num = (short)1538151660;
				short num2 = num;
				num = (short)377771244;
				switch (num2 == num)
				{
				default:
				{
					num = (short)557907968;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)772931585;
				if (num != 0)
				{
				}
				num = (short)1074266112;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
			set
			{
				short num = (short)485394159;
				short num2 = num;
				num = (short)1185056495;
				switch (num2 == num)
				{
				default:
				{
					num = (short)859897856;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)877002752;
				if (num != 0)
				{
				}
				num = (short)915472385;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x06000451 RID: 1105 RVA: 0x0004E5B0 File Offset: 0x0004C7B0
		void global::AcpCommonLib.IAcpFeatureNode.ap()
		{
			short num = (short)317784065;
			if (num != 0)
			{
			}
			num = (short)2049376256;
			short num2 = num;
			num = (short)1552288449;
			short num3 = num;
			num = (short)2008419009;
			switch (num3 == num)
			{
			}
			num = (short)1205534720;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000452 RID: 1106 RVA: 0x0004E660 File Offset: 0x0004C860
		void global::AcpCommonLib.IAcpFeatureNode.aq()
		{
			short num = (short)73203720;
			short num2 = num;
			num = (short)1113587720;
			switch (num2 == num)
			{
			default:
			{
				num = (short)19988480;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1108475904;
			if (num != 0)
			{
			}
			num = (short)1609236481;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x17000115 RID: 277
		global::AcpCommonLib.IAcpFeatureSection global::AcpCommonLib.IAcpFeatureNode.this[int A_0]
		{
			get
			{
				short num = (short)1744062756;
				short num2 = num;
				num = (short)1688095012;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)236781568;
					short num3 = num;
					num = (short)369098753;
					if (num != 0)
					{
					}
					num = (short)800325632;
					if (num != 0)
					{
					}
					if (A_0 != this.list.Parent.FeatureSectionId)
					{
						return null;
					}
					break;
				}
				}
				return this;
			}
		}

		// Token: 0x06000454 RID: 1108 RVA: 0x0004E7CC File Offset: 0x0004C9CC
		void global::AcpCommonLib.IAcpFeatureNode.a(global::AcpCommonLib.IAcpFeatureSection A_0)
		{
			short num = (short)599359264;
			short num2 = num;
			num = (short)727023392;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1322844160;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)771031040;
			if (num != 0)
			{
			}
			num = (short)1668677633;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x06000455 RID: 1109 RVA: 0x0004E87C File Offset: 0x0004CA7C
		global::System.Collections.Generic.IEnumerable<global::AcpCommonLib.IAcpFeatureSection> global::AcpCommonLib.IAcpFeatureNode.FeatureSectionsCollection
		{
			get
			{
				short num = (short)522389656;
				short num2 = num;
				num = (short)1038682264;
				switch (num2 == num)
				{
				default:
				{
					num = (short)855048192;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2132082689;
				if (num != 0)
				{
				}
				num = (short)138608640;
				if (num != 0)
				{
				}
				global::Motorola.Acp.PackUnpack.Ish.DataExchange.SparseLOVFieldAdapter.a a = new global::Motorola.Acp.PackUnpack.Ish.DataExchange.SparseLOVFieldAdapter.a(-2);
				a.d = this;
				return a;
			}
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x06000456 RID: 1110 RVA: 0x0004E934 File Offset: 0x0004CB34
		global::System.Collections.Generic.IEnumerable<global::AcpCommonLib.IAcpFeatureSection> global::AcpCommonLib.IAcpFeatureNode.FeatureSectionsCollectionByOrder
		{
			get
			{
				short num = (short)947826913;
				short num2 = num;
				num = (short)1670164705;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1124794368;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)533790720;
				if (num != 0)
				{
				}
				num = (short)340262913;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x06000457 RID: 1111 RVA: 0x0004E9E0 File Offset: 0x0004CBE0
		global::System.Collections.Generic.IEnumerable<global::AcpCommonLib.IAcpField> global::AcpCommonLib.IAcpFeatureNode.h(string A_0)
		{
			short num = (short)730100299;
			short num2 = num;
			num = (short)955478603;
			switch (num2 == num)
			{
			default:
			{
				num = (short)21889024;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1649606656;
			if (num != 0)
			{
			}
			num = (short)1058275329;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000458 RID: 1112 RVA: 0x0004EA90 File Offset: 0x0004CC90
		global::System.Collections.Generic.IEnumerable<global::AcpCommonLib.IAcpField> global::AcpCommonLib.IAcpFeatureNode.i(string A_0)
		{
			short num = (short)704515133;
			short num2 = num;
			num = (short)574164029;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1123221504;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)127729665;
			if (num != 0)
			{
			}
			num = (short)1946419200;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x06000459 RID: 1113 RVA: 0x0004EB3C File Offset: 0x0004CD3C
		// (set) Token: 0x0600045A RID: 1114 RVA: 0x0004EBEC File Offset: 0x0004CDEC
		string global::AcpCommonLib.IAcpFeatureNode.UIName
		{
			get
			{
				short num = (short)1403187479;
				short num2 = num;
				num = (short)232517911;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1249574912;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)194838529;
				if (num != 0)
				{
				}
				num = (short)137953280;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
			set
			{
				short num = (short)2018158512;
				short num2 = num;
				num = (short)869509040;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1136197632;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)702742529;
				if (num != 0)
				{
				}
				num = (short)1808269312;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x0600045B RID: 1115 RVA: 0x0004EC98 File Offset: 0x0004CE98
		string global::AcpCommonLib.IAcpFeatureNode.k(string A_0)
		{
			short num = (short)945863416;
			short num2 = num;
			num = (short)71482104;
			switch (num2 == num)
			{
			default:
			{
				num = (short)162660352;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1451884545;
			if (num != 0)
			{
			}
			num = (short)2036596736;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x0600045C RID: 1116 RVA: 0x0004ED44 File Offset: 0x0004CF44
		global::System.Collections.Generic.IEnumerable<global::AcpCommonLib.IAcpRecordset> global::AcpCommonLib.IAcpFeatureNode.EmbeddedRecordsets
		{
			get
			{
				short num = (short)258673388;
				short num2 = num;
				num = (short)2103905004;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1539571712;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1435107328;
				if (num != 0)
				{
				}
				num = (short)1873346561;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x0600045D RID: 1117 RVA: 0x0004EDF4 File Offset: 0x0004CFF4
		bool global::AcpCommonLib.IAcpFeatureNode.Deleted
		{
			get
			{
				short num = (short)1108692155;
				short num2 = num;
				num = (short)634408123;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1697644544;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1165099009;
				if (num != 0)
				{
				}
				num = (short)1980039168;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x0600045E RID: 1118 RVA: 0x0004EEA4 File Offset: 0x0004D0A4
		bool global::AcpCommonLib.IAcpFeatureNode._HasDiffs
		{
			get
			{
				short num = (short)728245298;
				short num2 = num;
				num = (short)19407922;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1389756416;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)154140673;
				if (num != 0)
				{
				}
				num = (short)1687945216;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x0600045F RID: 1119 RVA: 0x0004EF54 File Offset: 0x0004D154
		void global::AcpCommonLib.IAcpFeatureNode.ax()
		{
			short num = (short)129493910;
			short num2 = num;
			num = (short)580643734;
			switch (num2 == num)
			{
			default:
			{
				num = (short)157810688;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2103902208;
			if (num != 0)
			{
			}
			num = (short)1456668673;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x06000460 RID: 1120 RVA: 0x0004F004 File Offset: 0x0004D204
		bool global::AcpCommonLib.IAcpFeatureNode.HasVisibleObjects
		{
			get
			{
				short num = (short)1246218868;
				short num2 = num;
				num = (short)1374538356;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1716912128;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1785069568;
				if (num != 0)
				{
				}
				num = (short)34734081;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x06000461 RID: 1121 RVA: 0x0004F0B4 File Offset: 0x0004D2B4
		// (set) Token: 0x06000462 RID: 1122 RVA: 0x0004F164 File Offset: 0x0004D364
		public global::AcpCommonLib.Permissions Permissions
		{
			get
			{
				short num = (short)627303419;
				short num2 = num;
				num = (short)392225787;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1230307328;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2006581249;
				if (num != 0)
				{
				}
				num = (short)1275002880;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
			set
			{
				short num = (short)605737920;
				short num2 = num;
				num = (short)304796608;
				switch (num2 == num)
				{
				default:
				{
					num = (short)527368192;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1957232641;
				if (num != 0)
				{
				}
				num = (short)1610547200;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x06000463 RID: 1123 RVA: 0x0004F214 File Offset: 0x0004D414
		// (set) Token: 0x06000464 RID: 1124 RVA: 0x0004F2C4 File Offset: 0x0004D4C4
		public bool CloneEnabled
		{
			get
			{
				short num = (short)1558280663;
				short num2 = num;
				num = (short)1711503831;
				switch (num2 == num)
				{
				default:
				{
					num = (short)841154560;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)359071744;
				if (num != 0)
				{
				}
				num = (short)1262092289;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
			set
			{
				short num = (short)1864572945;
				short num2 = num;
				num = (short)1512644625;
				switch (num2 == num)
				{
				default:
				{
					num = (short)396230656;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1715666945;
				if (num != 0)
				{
				}
				num = (short)554696704;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x06000465 RID: 1125 RVA: 0x0004F374 File Offset: 0x0004D574
		// (set) Token: 0x06000466 RID: 1126 RVA: 0x0004F424 File Offset: 0x0004D624
		public bool ZoneCloneEnabled
		{
			get
			{
				short num = (short)1259663469;
				short num2 = num;
				num = (short)1547563117;
				switch (num2 == num)
				{
				default:
				{
					num = (short)515244032;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1987969025;
				if (num != 0)
				{
				}
				num = (short)981663744;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
			set
			{
				short num = (short)474546177;
				if (num != 0)
				{
				}
				num = (short)1850802176;
				short num2 = num;
				num = (short)2049226072;
				short num3 = num;
				num = (short)836154712;
				switch (num3 == num)
				{
				}
				num = (short)408223744;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x06000467 RID: 1127 RVA: 0x0004F4D0 File Offset: 0x0004D6D0
		int global::AcpCommonLib.IAcpFeatureSection.FeatureSectionId
		{
			get
			{
				short num = (short)1705047987;
				short num2 = num;
				num = (short)486209459;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1725693952;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)173539329;
				if (num != 0)
				{
				}
				num = (short)1220018176;
				if (num != 0)
				{
				}
				return this.list.Parent.FeatureSectionId;
			}
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x06000468 RID: 1128 RVA: 0x0004F588 File Offset: 0x0004D788
		// (set) Token: 0x06000469 RID: 1129 RVA: 0x0004F644 File Offset: 0x0004D844
		string global::AcpCommonLib.IAcpFeatureSection.FeatureSectionName
		{
			get
			{
				short num = (short)799124654;
				short num2 = num;
				num = (short)2057022638;
				switch (num2 == num)
				{
				default:
				{
					num = (short)288817152;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)18087937;
				if (num != 0)
				{
				}
				num = (short)1546780672;
				if (num != 0)
				{
				}
				return this.list.Parent.FeatureSectionName;
			}
			set
			{
				short num = (short)569100988;
				short num2 = num;
				num = (short)114150076;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1303183360;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)966262785;
				if (num != 0)
				{
				}
				num = (short)89260032;
				if (num != 0)
				{
				}
				throw new global::System.NotSupportedException();
			}
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x0600046A RID: 1130 RVA: 0x0004F6F0 File Offset: 0x0004D8F0
		// (set) Token: 0x0600046B RID: 1131 RVA: 0x0004F79C File Offset: 0x0004D99C
		global::AcpCommonLib.IAcpFeatureNode global::AcpCommonLib.IAcpFeatureSection.Parent
		{
			get
			{
				short num = (short)1309952939;
				short num2 = num;
				num = (short)1136872363;
				switch (num2 == num)
				{
				default:
				{
					num = (short)848822272;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1659174913;
				if (num != 0)
				{
				}
				num = (short)1525350400;
				if (num != 0)
				{
				}
				return this;
			}
			set
			{
				short num = (short)1995070452;
				short num2 = num;
				num = (short)926899188;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1272250368;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)167837696;
				if (num != 0)
				{
				}
				num = (short)1622933505;
				if (num != 0)
				{
				}
				throw new global::System.NotSupportedException();
			}
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x0600046C RID: 1132 RVA: 0x0004F84C File Offset: 0x0004DA4C
		global::AcpCommonLib.IAcpRecordset global::AcpCommonLib.IAcpFeatureSection.ParentRecset
		{
			get
			{
				short num = (short)1452778214;
				short num2 = num;
				num = (short)1576116966;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1274609664;
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
				num = (short)56164352;
				if (num != 0)
				{
				}
				return this;
			}
		}

		// Token: 0x0600046D RID: 1133 RVA: 0x0004F8F4 File Offset: 0x0004DAF4
		void global::AcpCommonLib.IAcpFeatureSection.a5()
		{
			short num = (short)1056505857;
			if (num != 0)
			{
			}
			num = (short)1411907584;
			short num2 = num;
			num = (short)1564857262;
			short num3 = num;
			num = (short)203674542;
			switch (num3 == num)
			{
			}
			num = (short)1881473024;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600046E RID: 1134 RVA: 0x0004F99C File Offset: 0x0004DB9C
		void global::AcpCommonLib.IAcpFeatureSection.a6()
		{
			short num = (short)896782627;
			short num2 = num;
			num = (short)1931596067;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1437466624;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)87228417;
			if (num != 0)
			{
			}
			num = (short)1596063744;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600046F RID: 1135 RVA: 0x0004FA48 File Offset: 0x0004DC48
		void global::AcpCommonLib.IAcpFeatureSection.a7()
		{
			short num = (short)606981928;
			short num2 = num;
			num = (short)673107752;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1575682048;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)810876928;
			if (num != 0)
			{
			}
			num = (short)1050738689;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000470 RID: 1136 RVA: 0x0004FAF4 File Offset: 0x0004DCF4
		void global::AcpCommonLib.IAcpFeatureSection.a8()
		{
			short num = (short)1135954414;
			short num2 = num;
			num = (short)1126189550;
			switch (num2 == num)
			{
			default:
			{
				num = (short)102039552;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2047410177;
			if (num != 0)
			{
			}
			num = (short)1806237696;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000471 RID: 1137 RVA: 0x0004FBA0 File Offset: 0x0004DDA0
		void global::AcpCommonLib.IAcpFeatureSection.a9()
		{
			short num = (short)550660471;
			short num2 = num;
			num = (short)728787319;
			switch (num2 == num)
			{
			default:
			{
				num = (short)147193856;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)837877760;
			if (num != 0)
			{
			}
			num = (short)595132417;
			if (num != 0)
			{
			}
		}

		// Token: 0x17000124 RID: 292
		global::AcpCommonLib.IAcpField global::AcpCommonLib.IAcpFeatureSection.this[string A_0]
		{
			get
			{
				short num = (short)2136527065;
				short num2 = num;
				num = (short)1112920281;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)475004928;
					short num3 = num;
					num = (short)791871488;
					if (num != 0)
					{
					}
					if (A_0 != this.list.UIName)
					{
						num = (short)755105793;
						if (num != 0)
						{
						}
						return null;
					}
					break;
				}
				}
				return this;
			}
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x06000473 RID: 1139 RVA: 0x0004FD0C File Offset: 0x0004DF0C
		global::System.Collections.Generic.IEnumerable<global::AcpCommonLib.IAcpField> global::AcpCommonLib.IAcpFeatureSection.FieldsCollection
		{
			get
			{
				short num = (short)1963533185;
				short num2 = num;
				num = (short)523510657;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1906245632;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)420937729;
				if (num != 0)
				{
				}
				num = (short)455475200;
				if (num != 0)
				{
				}
				global::Motorola.Acp.PackUnpack.Ish.DataExchange.SparseLOVFieldAdapter.b b = new global::Motorola.Acp.PackUnpack.Ish.DataExchange.SparseLOVFieldAdapter.b(-2);
				b.d = this;
				return b;
			}
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x06000474 RID: 1140 RVA: 0x0004FDC4 File Offset: 0x0004DFC4
		global::System.Collections.Generic.IEnumerable<global::AcpCommonLib.IAcpField> global::AcpCommonLib.IAcpFeatureSection.FieldsCollectionByOrder
		{
			get
			{
				short num = (short)1331189337;
				short num2 = num;
				num = (short)4347481;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1513553920;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1839267840;
				if (num != 0)
				{
				}
				num = (short)40108033;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x06000475 RID: 1141 RVA: 0x0004FE74 File Offset: 0x0004E074
		bool global::AcpCommonLib.IAcpFeatureSection.HasEmbeddedRecset
		{
			get
			{
				short num = (short)96642823;
				short num2 = num;
				num = (short)909616903;
				switch (num2 == num)
				{
				default:
				{
					num = (short)847183872;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1610678273;
				if (num != 0)
				{
				}
				num = (short)1896546304;
				if (num != 0)
				{
				}
				return false;
			}
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x06000476 RID: 1142 RVA: 0x0004FF20 File Offset: 0x0004E120
		// (set) Token: 0x06000477 RID: 1143 RVA: 0x0004FFC8 File Offset: 0x0004E1C8
		global::AcpCommonLib.IAcpRecordset global::AcpCommonLib.IAcpFeatureSection.EmbeddedRecset
		{
			get
			{
				short num = (short)846266369;
				if (num != 0)
				{
				}
				num = (short)765919232;
				short num2 = num;
				num = (short)393566465;
				short num3 = num;
				num = (short)1086150913;
				switch (num3 == num)
				{
				}
				num = (short)389414912;
				if (num != 0)
				{
				}
				return null;
			}
			set
			{
				short num = (short)2096116803;
				short num2 = num;
				num = (short)1041642563;
				switch (num2 == num)
				{
				default:
				{
					num = (short)226820096;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)810418177;
				if (num != 0)
				{
				}
				num = (short)1018232832;
				if (num != 0)
				{
				}
				throw new global::System.NotSupportedException();
			}
		}

		// Token: 0x06000478 RID: 1144 RVA: 0x00050078 File Offset: 0x0004E278
		global::System.Collections.Generic.IEnumerable<global::AcpCommonLib.IAcpField> global::AcpCommonLib.IAcpFeatureSection.n(string A_0)
		{
			short num = (short)1637324193;
			short num2 = num;
			num = (short)2127664545;
			switch (num2 == num)
			{
			default:
			{
				num = (short)145424384;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1226833920;
			if (num != 0)
			{
			}
			num = (short)252444673;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000479 RID: 1145 RVA: 0x00050124 File Offset: 0x0004E324
		global::System.Collections.Generic.IEnumerable<global::AcpCommonLib.IAcpField> global::AcpCommonLib.IAcpFeatureSection.o(string A_0)
		{
			short num = (short)265084835;
			short num2 = num;
			num = (short)372629411;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1702232064;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1582759937;
			if (num != 0)
			{
			}
			num = (short)2069299200;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x0600047A RID: 1146 RVA: 0x000501D4 File Offset: 0x0004E3D4
		// (set) Token: 0x0600047B RID: 1147 RVA: 0x00050290 File Offset: 0x0004E490
		string global::AcpCommonLib.IAcpFeatureSection.UIName
		{
			get
			{
				short num = (short)539350693;
				short num2 = num;
				num = (short)481547941;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1991573504;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)254083072;
				if (num != 0)
				{
				}
				num = (short)29491201;
				if (num != 0)
				{
				}
				return this.list.Parent.UIName;
			}
			set
			{
				short num = (short)33633374;
				short num2 = num;
				num = (short)192427102;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1887109120;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1631191041;
				if (num != 0)
				{
				}
				num = (short)1963196416;
				if (num != 0)
				{
				}
				throw new global::System.NotSupportedException();
			}
		}

		// Token: 0x0600047C RID: 1148 RVA: 0x00050340 File Offset: 0x0004E540
		string global::AcpCommonLib.IAcpFeatureSection.q(string A_0)
		{
			short num = (short)1815216129;
			if (num != 0)
			{
			}
			num = (short)1014235136;
			short num2 = num;
			num = (short)1952292525;
			short num3 = num;
			num = (short)603692717;
			switch (num3 == num)
			{
			}
			num = (short)614989824;
			if (num != 0)
			{
			}
			return this.list.Parent.Path(A_0);
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x0600047D RID: 1149 RVA: 0x000503FC File Offset: 0x0004E5FC
		global::AcpCommonLib.IAcpField global::AcpCommonLib.IAcpFeatureSection.CurrentField
		{
			get
			{
				short num = (short)983922229;
				short num2 = num;
				num = (short)1575712309;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2136604672;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)3080193;
				if (num != 0)
				{
				}
				num = (short)1125384192;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x0600047E RID: 1150 RVA: 0x000504A8 File Offset: 0x0004E6A8
		bool global::AcpCommonLib.IAcpFeatureSection._HasDiffs
		{
			get
			{
				short num = (short)1420945258;
				short num2 = num;
				num = (short)628090730;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1737097216;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)478478337;
				if (num != 0)
				{
				}
				num = (short)1546846208;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x0600047F RID: 1151 RVA: 0x00050558 File Offset: 0x0004E758
		void global::AcpCommonLib.IAcpFeatureSection.bh()
		{
			short num = (short)1084335794;
			short num2 = num;
			num = (short)256550578;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1730609152;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)444465153;
			if (num != 0)
			{
			}
			num = (short)883032064;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x06000480 RID: 1152 RVA: 0x00050608 File Offset: 0x0004E808
		bool global::AcpCommonLib.IAcpFeatureSection.HasVisibleObjects
		{
			get
			{
				short num = (short)1797016191;
				short num2 = num;
				num = (short)1034635903;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1122304000;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2124611584;
				if (num != 0)
				{
				}
				num = (short)631570433;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x06000481 RID: 1153 RVA: 0x000506BC File Offset: 0x0004E8BC
		// (set) Token: 0x06000482 RID: 1154 RVA: 0x0005076C File Offset: 0x0004E96C
		int global::AcpCommonLib.IAcpFeatureSection.DataTransferOrder
		{
			get
			{
				short num = (short)1978962516;
				short num2 = num;
				num = (short)83006036;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1439105024;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1215954945;
				if (num != 0)
				{
				}
				num = (short)826736640;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
			set
			{
				short num = (short)359661568;
				short num2 = num;
				num = (short)1875246935;
				short num3 = num;
				num = (short)907149143;
				switch (num3 == num)
				{
				}
				num = (short)2101608449;
				if (num != 0)
				{
				}
				num = (short)1479606272;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x06000483 RID: 1155 RVA: 0x00050818 File Offset: 0x0004EA18
		// (set) Token: 0x06000484 RID: 1156 RVA: 0x000508C8 File Offset: 0x0004EAC8
		bool global::AcpCommonLib.IAcpField.Editable
		{
			get
			{
				short num = (short)1160839168;
				short num2 = num;
				num = (short)287269642;
				short num3 = num;
				num = (short)868967178;
				switch (num3 == num)
				{
				}
				num = (short)1051787265;
				if (num != 0)
				{
				}
				num = (short)884670464;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
			set
			{
				short num = (short)551354368;
				short num2 = num;
				num = (short)1452054051;
				short num3 = num;
				num = (short)1033082403;
				switch (num3 == num)
				{
				}
				num = (short)1445330945;
				if (num != 0)
				{
				}
				num = (short)1075052544;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x06000485 RID: 1157 RVA: 0x00050974 File Offset: 0x0004EB74
		// (set) Token: 0x06000486 RID: 1158 RVA: 0x00050A20 File Offset: 0x0004EC20
		bool global::AcpCommonLib.IAcpField.Valid
		{
			get
			{
				short num = (short)9633792;
				short num2 = num;
				num = (short)1135041015;
				short num3 = num;
				num = (short)919886327;
				switch (num3 == num)
				{
				}
				num = (short)1018626049;
				if (num != 0)
				{
				}
				num = (short)247005184;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
			set
			{
				short num = (short)1559560192;
				short num2 = num;
				num = (short)227751131;
				short num3 = num;
				num = (short)325006555;
				switch (num3 == num)
				{
				}
				num = (short)1252065280;
				if (num != 0)
				{
				}
				num = (short)449708033;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x06000487 RID: 1159 RVA: 0x00050AD0 File Offset: 0x0004ECD0
		// (set) Token: 0x06000488 RID: 1160 RVA: 0x00050B80 File Offset: 0x0004ED80
		bool global::AcpCommonLib.IAcpField.Visible
		{
			get
			{
				short num = (short)364511232;
				short num2 = num;
				num = (short)338794114;
				short num3 = num;
				num = (short)493393538;
				switch (num3 == num)
				{
				}
				num = (short)401342465;
				if (num != 0)
				{
				}
				num = (short)111804416;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
			set
			{
				short num = (short)1416232960;
				short num2 = num;
				num = (short)1508660585;
				short num3 = num;
				num = (short)792024425;
				switch (num3 == num)
				{
				}
				num = (short)417923072;
				if (num != 0)
				{
				}
				num = (short)1612775425;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x06000489 RID: 1161 RVA: 0x00050C2C File Offset: 0x0004EE2C
		// (set) Token: 0x0600048A RID: 1162 RVA: 0x00050CD8 File Offset: 0x0004EED8
		bool global::AcpCommonLib.IAcpField.Applicable
		{
			get
			{
				short num = (short)1540096000;
				short num2 = num;
				num = (short)252379137;
				if (num != 0)
				{
				}
				num = (short)347342933;
				short num3 = num;
				num = (short)983763029;
				switch (num3 == num)
				{
				}
				num = (short)904527872;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
			set
			{
				short num = (short)1882849280;
				short num2 = num;
				num = (short)581803125;
				short num3 = num;
				num = (short)420125813;
				switch (num3 == num)
				{
				}
				num = (short)101842945;
				if (num != 0)
				{
				}
				num = (short)279904256;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x0600048B RID: 1163 RVA: 0x00050D88 File Offset: 0x0004EF88
		// (set) Token: 0x0600048C RID: 1164 RVA: 0x00050E38 File Offset: 0x0004F038
		bool global::AcpCommonLib.IAcpField.TieredOut
		{
			get
			{
				short num = (short)421330944;
				short num2 = num;
				num = (short)595833956;
				short num3 = num;
				num = (short)1996928100;
				switch (num3 == num)
				{
				}
				num = (short)1244135425;
				if (num != 0)
				{
				}
				num = (short)2134507520;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
			set
			{
				short num = (short)964165632;
				short num2 = num;
				num = (short)1086504173;
				short num3 = num;
				num = (short)616479981;
				switch (num3 == num)
				{
				}
				num = (short)541720577;
				if (num != 0)
				{
				}
				num = (short)2949120;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x0600048D RID: 1165 RVA: 0x00050EE8 File Offset: 0x0004F0E8
		global::AcpCommonLib.UndoRedo.UndoableTask global::AcpCommonLib.IAcpField.a(global::AcpCommonLib.IAcpField A_0)
		{
			short num = (short)112656384;
			short num2 = num;
			num = (short)2094748908;
			short num3 = num;
			num = (short)71062764;
			switch (num3 == num)
			{
			}
			num = (short)3342336;
			if (num != 0)
			{
			}
			num = (short)865599489;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600048E RID: 1166 RVA: 0x00050F98 File Offset: 0x0004F198
		global::AcpCommonLib.UndoRedo.UndoableTask global::AcpCommonLib.IAcpField.a(object A_0)
		{
			short num = (short)970653696;
			short num2 = num;
			num = (short)935907172;
			short num3 = num;
			num = (short)1636159332;
			switch (num3 == num)
			{
			}
			num = (short)1353973761;
			if (num != 0)
			{
			}
			num = (short)1399848960;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x0600048F RID: 1167 RVA: 0x00051048 File Offset: 0x0004F248
		// (set) Token: 0x06000490 RID: 1168 RVA: 0x000510F8 File Offset: 0x0004F2F8
		global::AcpCommonLib.StateConstraint global::AcpCommonLib.IAcpField.IsApplicable
		{
			get
			{
				short num = (short)827588608;
				short num2 = num;
				num = (short)1540241551;
				short num3 = num;
				num = (short)681457807;
				switch (num3 == num)
				{
				}
				num = (short)610009089;
				if (num != 0)
				{
				}
				num = (short)547225600;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
			set
			{
				short num = (short)907345920;
				short num2 = num;
				num = (short)1559887873;
				if (num != 0)
				{
				}
				num = (short)953884660;
				short num3 = num;
				num = (short)1262624756;
				switch (num3 == num)
				{
				}
				num = (short)1195769856;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x06000491 RID: 1169 RVA: 0x000511A8 File Offset: 0x0004F3A8
		// (set) Token: 0x06000492 RID: 1170 RVA: 0x00051258 File Offset: 0x0004F458
		global::AcpCommonLib.StateConstraint global::AcpCommonLib.IAcpField.IsValid
		{
			get
			{
				short num = (short)1942618112;
				short num2 = num;
				num = (short)865523847;
				short num3 = num;
				num = (short)1676859527;
				switch (num3 == num)
				{
				}
				num = (short)1573650433;
				if (num != 0)
				{
				}
				num = (short)1333395456;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
			set
			{
				short num = (short)643694592;
				short num2 = num;
				num = (short)2002481418;
				short num3 = num;
				num = (short)942895370;
				switch (num3 == num)
				{
				}
				num = (short)607059968;
				if (num != 0)
				{
				}
				num = (short)909049857;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x00051304 File Offset: 0x0004F504
		bool global::AcpCommonLib.IAcpField.b(global::AcpCommonLib.IAcpField A_0)
		{
			short num = (short)1040187392;
			short num2 = num;
			num = (short)1890648065;
			if (num != 0)
			{
			}
			num = (short)1393664372;
			short num3 = num;
			num = (short)1310040436;
			switch (num3 == num)
			{
			}
			num = (short)1602420736;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x06000494 RID: 1172 RVA: 0x000513B4 File Offset: 0x0004F5B4
		string global::AcpCommonLib.IAcpField.Name
		{
			get
			{
				short num = (short)2047410176;
				short num2 = num;
				num = (short)865172449;
				short num3 = num;
				num = (short)484146145;
				switch (num3 == num)
				{
				}
				num = (short)727187457;
				if (num != 0)
				{
				}
				num = (short)1091174400;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x06000495 RID: 1173 RVA: 0x00051460 File Offset: 0x0004F660
		string global::AcpCommonLib.IAcpField.UIName
		{
			get
			{
				short num = (short)1655242752;
				short num2 = num;
				num = (short)979828913;
				short num3 = num;
				num = (short)1060503729;
				switch (num3 == num)
				{
				}
				num = (short)2107441153;
				if (num != 0)
				{
				}
				num = (short)1984626688;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x06000496 RID: 1174 RVA: 0x0005150C File Offset: 0x0004F70C
		string global::AcpCommonLib.IAcpField.NewUIName
		{
			get
			{
				short num = (short)1645019136;
				short num2 = num;
				num = (short)498701628;
				short num3 = num;
				num = (short)693146940;
				switch (num3 == num)
				{
				}
				num = (short)1595277312;
				if (num != 0)
				{
				}
				num = (short)1524301825;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x06000497 RID: 1175 RVA: 0x000515B8 File Offset: 0x0004F7B8
		string global::AcpCommonLib.IAcpField.NewUiExpanderAndName
		{
			get
			{
				short num = (short)227672064;
				short num2 = num;
				num = (short)22684525;
				short num3 = num;
				num = (short)507454317;
				switch (num3 == num)
				{
				}
				num = (short)619118593;
				if (num != 0)
				{
				}
				num = (short)24248320;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x06000498 RID: 1176 RVA: 0x00051668 File Offset: 0x0004F868
		// (set) Token: 0x06000499 RID: 1177 RVA: 0x00051714 File Offset: 0x0004F914
		global::AcpCommonLib.IAcpFeatureSection global::AcpCommonLib.IAcpField.Parent
		{
			get
			{
				short num = (short)1313079296;
				short num2 = num;
				num = (short)1919322874;
				short num3 = num;
				num = (short)1493732090;
				switch (num3 == num)
				{
				}
				num = (short)760938497;
				if (num != 0)
				{
				}
				num = (short)2034171904;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
			set
			{
				short num = (short)138084352;
				short num2 = num;
				num = (short)1490198397;
				short num3 = num;
				num = (short)1424531325;
				switch (num3 == num)
				{
				}
				num = (short)1575682049;
				if (num != 0)
				{
				}
				num = (short)52625408;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x0600049A RID: 1178 RVA: 0x000517C0 File Offset: 0x0004F9C0
		global::AcpCommonLib.IAcpFeatureSection global::AcpCommonLib.IAcpField.NewParent
		{
			get
			{
				short num = (short)350683136;
				short num2 = num;
				num = (short)1738866689;
				if (num != 0)
				{
				}
				num = (short)228320309;
				short num3 = num;
				num = (short)408609845;
				switch (num3 == num)
				{
				}
				num = (short)1457061888;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x0600049B RID: 1179 RVA: 0x0005186C File Offset: 0x0004FA6C
		string global::AcpCommonLib.IAcpField.r(string A_0)
		{
			short num = (short)1149829120;
			short num2 = num;
			num = (short)749404161;
			if (num != 0)
			{
			}
			num = (short)1200177261;
			short num3 = num;
			num = (short)335626349;
			switch (num3 == num)
			{
			}
			num = (short)219742208;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x0600049C RID: 1180 RVA: 0x00051918 File Offset: 0x0004FB18
		global::System.Type global::AcpCommonLib.IAcpField.DataType
		{
			get
			{
				short num = (short)1863974912;
				short num2 = num;
				num = (short)1105074631;
				short num3 = num;
				num = (short)855513543;
				switch (num3 == num)
				{
				}
				num = (short)501678080;
				if (num != 0)
				{
				}
				num = (short)119078913;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x0600049D RID: 1181 RVA: 0x000519C8 File Offset: 0x0004FBC8
		void global::AcpCommonLib.IAcpField.s(string A_0)
		{
			short num = (short)154927104;
			short num2 = num;
			num = (short)1396605178;
			short num3 = num;
			num = (short)1694138618;
			switch (num3 == num)
			{
			}
			num = (short)1521745921;
			if (num != 0)
			{
			}
			num = (short)367460352;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600049E RID: 1182 RVA: 0x00051A78 File Offset: 0x0004FC78
		void global::AcpCommonLib.IAcpField.t(string A_0)
		{
			short num = (short)273743872;
			short num2 = num;
			num = (short)1997494533;
			short num3 = num;
			num = (short)370694405;
			switch (num3 == num)
			{
			}
			num = (short)374341633;
			if (num != 0)
			{
			}
			num = (short)844824576;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x0600049F RID: 1183 RVA: 0x00051B28 File Offset: 0x0004FD28
		// (set) Token: 0x060004A0 RID: 1184 RVA: 0x00051BD8 File Offset: 0x0004FDD8
		bool global::AcpCommonLib.IAcpField.CustomViewVisibility
		{
			get
			{
				short num = (short)2099380224;
				short num2 = num;
				num = (short)1246836344;
				short num3 = num;
				num = (short)894776952;
				switch (num3 == num)
				{
				}
				num = (short)936116225;
				if (num != 0)
				{
				}
				num = (short)973668352;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
			set
			{
				short num = (short)145358848;
				short num2 = num;
				num = (short)161669969;
				short num3 = num;
				num = (short)1970594641;
				switch (num3 == num)
				{
				}
				num = (short)1126301696;
				if (num != 0)
				{
				}
				num = (short)579862529;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x060004A1 RID: 1185 RVA: 0x00051C84 File Offset: 0x0004FE84
		// (set) Token: 0x060004A2 RID: 1186 RVA: 0x00051D38 File Offset: 0x0004FF38
		global::AcpCommonLib.DifferentiatedUserViewType global::AcpCommonLib.IAcpField.DifferentiatedUserView
		{
			get
			{
				short num = (short)664207360;
				short num2 = num;
				num = (short)1343488001;
				if (num != 0)
				{
				}
				num = (short)139437305;
				short num3 = num;
				num = (short)1527555321;
				switch (num3 == num)
				{
				}
				num = (short)729415680;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
			set
			{
				short num = (short)1185349632;
				short num2 = num;
				num = (short)20643841;
				if (num != 0)
				{
				}
				num = (short)1882657141;
				short num3 = num;
				num = (short)795939189;
				switch (num3 == num)
				{
				}
				num = (short)1934032896;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x060004A3 RID: 1187 RVA: 0x00051DE8 File Offset: 0x0004FFE8
		// (set) Token: 0x060004A4 RID: 1188 RVA: 0x00051E94 File Offset: 0x00050094
		int global::AcpCommonLib.IAcpField.DataTransferOrder
		{
			get
			{
				short num = (short)488308736;
				short num2 = num;
				num = (short)952762369;
				if (num != 0)
				{
				}
				num = (short)956502161;
				short num3 = num;
				num = (short)1818300561;
				switch (num3 == num)
				{
				}
				num = (short)1330446336;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
			set
			{
				short num = (short)1427374080;
				short num2 = num;
				num = (short)277337174;
				short num3 = num;
				num = (short)1066456150;
				switch (num3 == num)
				{
				}
				num = (short)1850933249;
				if (num != 0)
				{
				}
				num = (short)1227227136;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x060004A5 RID: 1189 RVA: 0x00051F40 File Offset: 0x00050140
		// (set) Token: 0x060004A6 RID: 1190 RVA: 0x00051FEC File Offset: 0x000501EC
		bool global::AcpCommonLib.IAcpField.IgnoreOnCompare
		{
			get
			{
				short num = (short)75956224;
				short num2 = num;
				num = (short)87846425;
				short num3 = num;
				num = (short)1865313817;
				switch (num3 == num)
				{
				}
				num = (short)1872494592;
				if (num != 0)
				{
				}
				num = (short)26214401;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
			set
			{
				short num = (short)751501312;
				short num2 = num;
				num = (short)1916352772;
				short num3 = num;
				num = (short)431896836;
				switch (num3 == num)
				{
				}
				num = (short)1163329537;
				if (num != 0)
				{
				}
				num = (short)339345408;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x060004A7 RID: 1191 RVA: 0x0005209C File Offset: 0x0005029C
		// (set) Token: 0x060004A8 RID: 1192 RVA: 0x0005214C File Offset: 0x0005034C
		bool global::AcpCommonLib.IAcpField.IgnoreOnPrint
		{
			get
			{
				short num = (short)1305214976;
				short num2 = num;
				num = (short)1821503479;
				short num3 = num;
				num = (short)1373433847;
				switch (num3 == num)
				{
				}
				num = (short)1960116225;
				if (num != 0)
				{
				}
				num = (short)586350592;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
			set
			{
				short num = (short)439615488;
				short num2 = num;
				num = (short)1158493340;
				short num3 = num;
				num = (short)1307063452;
				switch (num3 == num)
				{
				}
				num = (short)1095368704;
				if (num != 0)
				{
				}
				num = (short)1783889921;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x060004A9 RID: 1193 RVA: 0x000521FC File Offset: 0x000503FC
		// (set) Token: 0x060004AA RID: 1194 RVA: 0x000522AC File Offset: 0x000504AC
		bool global::AcpCommonLib.IAcpField.IsMasked
		{
			get
			{
				short num = (short)1017905152;
				short num2 = num;
				num = (short)486357591;
				short num3 = num;
				num = (short)1168128599;
				switch (num3 == num)
				{
				}
				num = (short)1545076737;
				if (num != 0)
				{
				}
				num = (short)1024393216;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
			set
			{
				short num = (short)523042816;
				short num2 = num;
				num = (short)391761432;
				short num3 = num;
				num = (short)1896861208;
				switch (num3 == num)
				{
				}
				num = (short)628883457;
				if (num != 0)
				{
				}
				num = (short)1585643520;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x060004AB RID: 1195 RVA: 0x00052358 File Offset: 0x00050558
		global::AcpCommonLib.IAcpFeatureNode global::AcpCommonLib.IAcpField.ParentNode
		{
			get
			{
				short num = (short)289865728;
				short num2 = num;
				num = (short)451694084;
				short num3 = num;
				num = (short)851987972;
				switch (num3 == num)
				{
				}
				num = (short)1088356352;
				if (num != 0)
				{
				}
				num = (short)453181441;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x060004AC RID: 1196 RVA: 0x00052408 File Offset: 0x00050608
		// (set) Token: 0x060004AD RID: 1197 RVA: 0x000524B8 File Offset: 0x000506B8
		bool global::AcpCommonLib.IAcpField._HasDiffs
		{
			get
			{
				short num = (short)108724224;
				short num2 = num;
				num = (short)1213532818;
				short num3 = num;
				num = (short)276433554;
				switch (num3 == num)
				{
				}
				num = (short)727646208;
				if (num != 0)
				{
				}
				num = (short)263651329;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
			set
			{
				short num = (short)168165376;
				short num2 = num;
				num = (short)436905117;
				short num3 = num;
				num = (short)1226417309;
				switch (num3 == num)
				{
				}
				num = (short)502333440;
				if (num != 0)
				{
				}
				num = (short)784859137;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x060004AE RID: 1198 RVA: 0x00052568 File Offset: 0x00050768
		// (set) Token: 0x060004AF RID: 1199 RVA: 0x00052614 File Offset: 0x00050814
		bool global::AcpCommonLib.IAcpField.KeyNameField
		{
			get
			{
				short num = (short)997851136;
				short num2 = num;
				num = (short)1350303745;
				if (num != 0)
				{
				}
				num = (short)1706784598;
				short num3 = num;
				num = (short)1615755094;
				switch (num3 == num)
				{
				}
				num = (short)1967718400;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
			set
			{
				short num = (short)699465728;
				short num2 = num;
				num = (short)1431519412;
				short num3 = num;
				num = (short)1106919604;
				switch (num3 == num)
				{
				}
				num = (short)403439616;
				if (num != 0)
				{
				}
				num = (short)2008875009;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x060004B0 RID: 1200 RVA: 0x000526C4 File Offset: 0x000508C4
		int global::System.IComparable.b(object A_0)
		{
			short num = (short)2070675456;
			short num2 = num;
			num = (short)342036542;
			short num3 = num;
			num = (short)53809214;
			switch (num3 == num)
			{
			}
			num = (short)406323200;
			if (num != 0)
			{
			}
			num = (short)2012348417;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x060004B1 RID: 1201 RVA: 0x00052770 File Offset: 0x00050970
		// (set) Token: 0x060004B2 RID: 1202 RVA: 0x00052828 File Offset: 0x00050A28
		public int Value
		{
			get
			{
				short num = (short)920715264;
				short num2 = num;
				num = (short)1509924374;
				short num3 = num;
				num = (short)1187946006;
				switch (num3 == num)
				{
				}
				num = (short)1349648385;
				if (num != 0)
				{
				}
				num = (short)23855104;
				if (num != 0)
				{
				}
				return this.values[this.nodeIndex];
			}
			set
			{
				short num = (short)1209597952;
				short num2 = num;
				num = (short)1507988585;
				short num3 = num;
				num = (short)1837765737;
				switch (num3 == num)
				{
				}
				num = (short)234684417;
				if (num != 0)
				{
				}
				num = (short)631898112;
				if (num != 0)
				{
				}
				throw new global::System.NotSupportedException();
			}
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x060004B3 RID: 1203 RVA: 0x000528D4 File Offset: 0x00050AD4
		// (set) Token: 0x060004B4 RID: 1204 RVA: 0x00052984 File Offset: 0x00050B84
		bool global::AcpCommonLib.IAcpRecordset.HideRecordsFromTree
		{
			get
			{
				short num = (short)1727266816;
				short num2 = num;
				num = (short)385861158;
				short num3 = num;
				num = (short)836683302;
				switch (num3 == num)
				{
				}
				num = (short)655622145;
				if (num != 0)
				{
				}
				num = (short)1076101120;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
			set
			{
				short num = (short)2001862656;
				short num2 = num;
				num = (short)744949035;
				short num3 = num;
				num = (short)1839727915;
				switch (num3 == num)
				{
				}
				num = (short)1631649793;
				if (num != 0)
				{
				}
				num = (short)2110586880;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x060004B5 RID: 1205 RVA: 0x00052A30 File Offset: 0x00050C30
		// (set) Token: 0x060004B6 RID: 1206 RVA: 0x00052AE0 File Offset: 0x00050CE0
		bool global::AcpCommonLib.IAcpRecordset.HiddenStatic
		{
			get
			{
				short num = (short)1600913408;
				short num2 = num;
				num = (short)1982809589;
				short num3 = num;
				num = (short)1735017973;
				switch (num3 == num)
				{
				}
				num = (short)1372323841;
				if (num != 0)
				{
				}
				num = (short)976355328;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
			set
			{
				short num = (short)1587871744;
				short num2 = num;
				num = (short)1647312897;
				if (num != 0)
				{
				}
				num = (short)1774201552;
				short num3 = num;
				num = (short)356264656;
				switch (num3 == num)
				{
				}
				num = (short)850722816;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x060004B7 RID: 1207 RVA: 0x00052B90 File Offset: 0x00050D90
		// (set) Token: 0x060004B8 RID: 1208 RVA: 0x00052C3C File Offset: 0x00050E3C
		public bool BlockDataTransfer
		{
			get
			{
				short num = (short)981073920;
				short num2 = num;
				num = (short)921651661;
				short num3 = num;
				num = (short)731400653;
				switch (num3 == num)
				{
				}
				num = (short)574160896;
				if (num != 0)
				{
				}
				num = (short)270336001;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
			internal set
			{
				short num = (short)1597112320;
				short num2 = num;
				num = (short)705887512;
				short num3 = num;
				num = (short)1733819672;
				switch (num3 == num)
				{
				}
				num = (short)1782513665;
				if (num != 0)
				{
				}
				num = (short)1211629568;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x060004B9 RID: 1209 RVA: 0x00052CEC File Offset: 0x00050EEC
		// (set) Token: 0x060004BA RID: 1210 RVA: 0x00052D9C File Offset: 0x00050F9C
		public bool Protected
		{
			get
			{
				short num = (short)1113784320;
				short num2 = num;
				num = (short)2106195969;
				if (num != 0)
				{
				}
				num = (short)388946922;
				short num3 = num;
				num = (short)589290474;
				switch (num3 == num)
				{
				}
				num = (short)1977090048;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
			set
			{
				short num = (short)724369408;
				short num2 = num;
				num = (short)947705871;
				short num3 = num;
				num = (short)1651103759;
				switch (num3 == num)
				{
				}
				num = (short)326565888;
				if (num != 0)
				{
				}
				num = (short)1515257857;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x060004BB RID: 1211 RVA: 0x00052E4C File Offset: 0x0005104C
		public void ResetToDefaultWithUndo()
		{
			short num = (short)1313472512;
			short num2 = num;
			num = (short)789575334;
			short num3 = num;
			num = (short)1649800870;
			switch (num3 == num)
			{
			}
			num = (short)1435566081;
			if (num != 0)
			{
			}
			num = (short)777519104;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x060004BC RID: 1212 RVA: 0x00052EF8 File Offset: 0x000510F8
		// (set) Token: 0x060004BD RID: 1213 RVA: 0x00052FA8 File Offset: 0x000511A8
		public int FieldId
		{
			get
			{
				short num = (short)1633091584;
				short num2 = num;
				num = (short)2057795009;
				short num3 = num;
				num = (short)264009153;
				switch (num3 == num)
				{
				}
				num = (short)2134966273;
				if (num != 0)
				{
				}
				num = (short)663224320;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
			set
			{
				short num = (short)98435072;
				short num2 = num;
				num = (short)1830220909;
				short num3 = num;
				num = (short)1465054317;
				switch (num3 == num)
				{
				}
				num = (short)545456128;
				if (num != 0)
				{
				}
				num = (short)1908408321;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x060004BE RID: 1214 RVA: 0x00053058 File Offset: 0x00051258
		// (set) Token: 0x060004BF RID: 1215 RVA: 0x00053108 File Offset: 0x00051308
		public bool HiddenStatic
		{
			get
			{
				short num = (short)1562836992;
				short num2 = num;
				num = (short)680361146;
				short num3 = num;
				num = (short)1621261498;
				switch (num3 == num)
				{
				}
				num = (short)1900085249;
				if (num != 0)
				{
				}
				num = (short)1958215680;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
			set
			{
				short num = (short)1127546880;
				short num2 = num;
				num = (short)426497134;
				short num3 = num;
				num = (short)900453486;
				switch (num3 == num)
				{
				}
				num = (short)682622977;
				if (num != 0)
				{
				}
				num = (short)1858994176;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x060004C0 RID: 1216 RVA: 0x000531B4 File Offset: 0x000513B4
		protected virtual void w(bool A_0)
		{
			short num = (short)2113994752;
			short num2 = num;
			num = (short)2130685775;
			short num3 = num;
			num = (short)1458351951;
			switch (num3 == num)
			{
			}
			num = (short)1177026561;
			if (num != 0)
			{
			}
			num = (short)386924544;
			if (num != 0)
			{
			}
		}

		// Token: 0x060004C1 RID: 1217 RVA: 0x00053260 File Offset: 0x00051460
		public void Dispose()
		{
			short num = (short)184811520;
			short num2 = num;
			num = (short)1846240764;
			short num3 = num;
			num = (short)1837590012;
			switch (num3 == num)
			{
			}
			num = (short)2040856576;
			if (num != 0)
			{
			}
			num = (short)23592961;
			if (num != 0)
			{
			}
			this.w(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x0400017D RID: 381
		private global::AcpBusinessLayer.AcpSparseLOVField list;

		// Token: 0x0400017E RID: 382
		private int nodeIndex;

		// Token: 0x0400017F RID: 383
		private int[] values;
	}
}
