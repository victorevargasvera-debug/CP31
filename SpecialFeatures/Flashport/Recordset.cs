using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.Flashport
{
	// Token: 0x02000075 RID: 117
	public abstract class Recordset : global::System.Collections.ObjectModel.ObservableCollection<global::SpecialFeatures.Flashport.FeatureNode>
	{
		// Token: 0x06000968 RID: 2408
		public abstract global::SpecialFeatures.Flashport.FeatureNode CreateDefaultRecord();

		// Token: 0x06000969 RID: 2409 RVA: 0x00002B4C File Offset: 0x00000D4C
		protected Recordset()
		{
		}

		// Token: 0x0600096A RID: 2410 RVA: 0x00002B54 File Offset: 0x00000D54
		protected Recordset(string name)
		{
			this.RecordsetName = name;
			this.j = 1024;
			this.i = 0;
		}

		// Token: 0x170003C6 RID: 966
		// (get) Token: 0x0600096B RID: 2411 RVA: 0x000A8A20 File Offset: 0x000A6C20
		// (set) Token: 0x0600096C RID: 2412 RVA: 0x000A8AD0 File Offset: 0x000A6CD0
		protected int Id
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)412584355;
				short num2 = num;
				num = (short)2104658339;
				switch (num2 == num)
				{
				}
				num = (short)1605828608;
				if (num != 0)
				{
				}
				num = (short)34734081;
				if (num != 0)
				{
				}
				num = (short)159514624;
				short num3 = num;
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1113128961;
				if (num != 0)
				{
				}
				num = (short)598335570;
				short num2 = num;
				num = (short)67231826;
				switch (num2 == num)
				{
				}
				num = (short)1189937152;
				if (num != 0)
				{
				}
				num = (short)1212088320;
				short num3 = num;
				this.a = value;
			}
		}

		// Token: 0x0600096D RID: 2413 RVA: 0x000A8B84 File Offset: 0x000A6D84
		internal global::SpecialFeatures.Flashport.FeatureNode InternalAddRecord()
		{
			short num = (short)402356175;
			short num2 = num;
			num = (short)1710520271;
			switch (num2 == num)
			{
			}
			num = (short)1665859585;
			if (num != 0)
			{
			}
			num = (short)17039360;
			if (num != 0)
			{
			}
			num = (short)738197504;
			short num3 = num;
			global::SpecialFeatures.Flashport.FeatureNode featureNode = this.CreateDefaultRecord();
			this.AddRecord(featureNode);
			return featureNode;
		}

		// Token: 0x0600096E RID: 2414 RVA: 0x000A8C3C File Offset: 0x000A6E3C
		private void b(global::SpecialFeatures.Flashport.FeatureNode A_0)
		{
			int a_ = 18;
			short num = (short)1325137922;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					this.HasEmbeddedRecset = A_0.HasEmbeddedRecset;
					num = (short)1148780547;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					if (!this.HasEmbeddedRecset)
					{
						num = (short)1776353280;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_101;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_41;
					}
					continue;
				case 3:
					goto IL_7E;
				case 4:
					goto IL_58;
				}
				IL_41:
				if (A_0 == null)
				{
					num = (short)606142468;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)483196929;
					if (num != 0)
					{
					}
					A_0.Parent = this;
					num = (short)595918849;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_58:
			throw new global::System.ArgumentNullException(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("滛", a_));
			IL_7E:
			IL_101:
			num = (short)1263947239;
			short num3 = num;
			num = (short)527846887;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_7E;
			default:
			{
				num = (short)220004352;
				short num4 = num;
				num = (short)1738407936;
				if (num != 0)
				{
				}
				return;
			}
			}
		}

		// Token: 0x0600096F RID: 2415 RVA: 0x000A8DC0 File Offset: 0x000A6FC0
		private void a(global::SpecialFeatures.Flashport.FeatureNode A_0)
		{
			short num = (short)170865405;
			short num2 = num;
			num = (short)1997288189;
			switch (num2 == num)
			{
			}
			num = (short)931332097;
			if (num != 0)
			{
			}
			num = (short)1486749696;
			if (num != 0)
			{
			}
			num = (short)830341120;
			short num3 = num;
		}

		// Token: 0x06000970 RID: 2416 RVA: 0x000A8E6C File Offset: 0x000A706C
		internal void InsertRecord(int index, global::SpecialFeatures.Flashport.FeatureNode record)
		{
			int a_ = 18;
			short num;
			if (record == null)
			{
				num = (short)1605435392;
				short num2 = num;
				num = (short)796896713;
				short num3 = num;
				num = (short)408006089;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)180420608;
					if (num != 0)
					{
					}
					throw new global::System.ArgumentNullException(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("滛ﮞ", a_));
				}
			}
			num = (short)720437249;
			if (num != 0)
			{
			}
			this.b(record);
			base.Insert(index, record);
		}

		// Token: 0x06000971 RID: 2417 RVA: 0x000A8F48 File Offset: 0x000A7148
		public void Initialize()
		{
			short num = (short)1613103105;
			if (num != 0)
			{
			}
			global::System.Collections.Generic.IEnumerator<global::SpecialFeatures.Flashport.FeatureNode> enumerator = base.GetEnumerator();
			try
			{
				num = (short)2113798146;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_D8;
					case 1:
						num = (short)1470955520;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_69;
						}
						continue;
					case 3:
						if (!enumerator.MoveNext())
						{
							num = (short)947978241;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						enumerator.Current.Parent = this;
						num = (short)2145255428;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_8E:
					num = (short)100204547;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_69:
					goto IL_8E;
				}
				IL_D8:;
			}
			finally
			{
				num = (short)180027394;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_192;
					case 1:
					{
						num = (short)966065829;
						short num3 = num;
						num = (short)216530597;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_194;
						default:
							num = (short)1211170816;
							if (num != 0)
							{
							}
							enumerator.Dispose();
							num = (short)645070848;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
						switch (0)
						{
						case 0:
							goto IL_10D;
						}
						continue;
					}
					IL_10D:
					if (enumerator == null)
					{
						break;
					}
					num = (short)2424833;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_192:
				IL_194:;
			}
			num = (short)67043328;
			short num4 = num;
		}

		// Token: 0x06000972 RID: 2418 RVA: 0x000A9124 File Offset: 0x000A7324
		public global::SpecialFeatures.Flashport.FeatureNode AddDefaultRecord()
		{
			short num = (short)34734081;
			if (num != 0)
			{
			}
			num = (short)261754222;
			short num2 = num;
			num = (short)683478382;
			switch (num2 == num)
			{
			}
			num = (short)1841364992;
			if (num != 0)
			{
			}
			num = (short)477757440;
			short num3 = num;
			return this.CreateDefaultRecord();
		}

		// Token: 0x06000973 RID: 2419 RVA: 0x000A91D4 File Offset: 0x000A73D4
		public void AddRecord(global::SpecialFeatures.Flashport.FeatureNode record)
		{
			int a_ = 0;
			if (record == null)
			{
				short num = (short)235012096;
				short num2 = num;
				num = (short)1907490817;
				if (num != 0)
				{
				}
				num = (short)1669585839;
				short num3 = num;
				num = (short)1384373167;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)355991552;
					if (num != 0)
					{
					}
					throw new global::System.ArgumentNullException(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("力", a_));
				}
			}
			this.b(record);
			base.Add(record);
		}

		// Token: 0x06000974 RID: 2420 RVA: 0x000A92B0 File Offset: 0x000A74B0
		public int AddMultipleDefaultRecords(int count)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			int num2;
			short num3;
			global::SpecialFeatures.Flashport.FeatureNode[] array;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					return num2;
				case 1:
					goto IL_B4;
				case 2:
					if (num2 >= count)
					{
						num3 = (short)364118016;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					array[num2++] = this.CreateDefaultRecord();
					num3 = (short)33423361;
					if (num3 != 0)
					{
					}
					num3 = (short)1131741185;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 3:
				{
					num3 = (short)1187446784;
					short num4 = num3;
					num3 = (short)1089508463;
					short num5 = num3;
					num3 = (short)1297519727;
					switch ((num5 == num3) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_B4;
					default:
						num3 = (short)1817116672;
						if (num3 != 0)
						{
						}
						goto IL_B4;
					}
					break;
				}
				}
				goto IL_20;
				IL_B4:
				num3 = (short)1454833666;
				num = (int)((global::System.IntPtr)num3);
			}
			return num2;
			IL_20:
			num2 = 0;
			array = new global::SpecialFeatures.Flashport.FeatureNode[count];
			num3 = (short)2003828739;
			num = (int)((global::System.IntPtr)num3);
			goto IL_0A;
		}

		// Token: 0x06000975 RID: 2421 RVA: 0x000A93FC File Offset: 0x000A75FC
		internal void RemoveRecord(global::SpecialFeatures.Flashport.FeatureNode record)
		{
			int a_ = 11;
			if (this.Count == this.Min)
			{
				short num = (short)386400256;
				short num2 = num;
				num = (short)1443102721;
				if (num != 0)
				{
				}
				num = (short)847487239;
				short num3 = num;
				num = (short)269721863;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)541720576;
					if (num != 0)
					{
					}
					throw new global::System.InvalidOperationException(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("춍ﲑ望秊몙ﮝ첟잡킣쎥袧\udaa9춫\uddad쒯銱삳\udeb5\uddb7骹ힽ꺿꫃독ꗇ꣉꧋볍뷑닓꫗뿙뿛뇝鋟蛡韣죥", a_));
				}
			}
			this.a(record);
			base.Remove(record);
		}

		// Token: 0x06000976 RID: 2422 RVA: 0x000A94E4 File Offset: 0x000A76E4
		public void RemoveRecordAt(int index)
		{
			int a_ = 19;
			if (this.Count == this.Min)
			{
				short num = (short)299565056;
				short num2 = num;
				num = (short)565668975;
				short num3 = num;
				num = (short)1875143791;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)524484608;
					if (num != 0)
					{
					}
					num = (short)1407778817;
					if (num != 0)
					{
					}
					throw new global::System.InvalidOperationException(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햕聯풟芡삣쎥쒧쾩\ud8ab쮭邯슱햳억첷骹좻횽ꖿ觃꿅ꛇꋋ믍뷏냑뇓ꓕ뗙뫛ﻝ鋟蟡蟣觥髧軩鿫샭", a_));
				}
			}
			global::SpecialFeatures.Flashport.FeatureNode a_2 = this[index];
			this.a(a_2);
			base.RemoveAt(index);
		}

		// Token: 0x170003C7 RID: 967
		// (get) Token: 0x06000977 RID: 2423 RVA: 0x000A95D4 File Offset: 0x000A77D4
		// (set) Token: 0x06000978 RID: 2424 RVA: 0x000A9688 File Offset: 0x000A7888
		public string RecordsetName
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1234713026;
				short num2 = num;
				num = (short)591608258;
				switch (num2 == num)
				{
				}
				num = (short)1460994048;
				if (num != 0)
				{
				}
				num = (short)513409025;
				if (num != 0)
				{
				}
				num = (short)1660616704;
				short num3 = num;
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1064958861;
				short num2 = num;
				num = (short)1614281613;
				switch (num2 == num)
				{
				}
				num = (short)923336704;
				if (num != 0)
				{
				}
				num = (short)1423507457;
				if (num != 0)
				{
				}
				num = (short)105709568;
				short num3 = num;
				this.b = value;
			}
		}

		// Token: 0x170003C8 RID: 968
		// (get) Token: 0x06000979 RID: 2425 RVA: 0x000A973C File Offset: 0x000A793C
		public int RecsetId
		{
			get
			{
				short num = (short)501302962;
				short num2 = num;
				num = (short)630212274;
				switch (num2 == num)
				{
				}
				num = (short)1344667649;
				if (num != 0)
				{
				}
				num = (short)2079522816;
				if (num != 0)
				{
				}
				num = (short)1505624064;
				short num3 = num;
				return this.Id;
			}
		}

		// Token: 0x0600097A RID: 2426 RVA: 0x000A97EC File Offset: 0x000A79EC
		public new void Clear()
		{
			short num = (short)1565431329;
			short num2 = num;
			num = (short)997627425;
			switch (num2 == num)
			{
			}
			num = (short)321126400;
			if (num != 0)
			{
			}
			num = (short)2044526593;
			if (num != 0)
			{
			}
			num = (short)111214592;
			short num3 = num;
			base.Clear();
		}

		// Token: 0x170003C9 RID: 969
		// (get) Token: 0x0600097B RID: 2427 RVA: 0x000A989C File Offset: 0x000A7A9C
		public new int Count
		{
			get
			{
				short num = (short)1328844920;
				short num2 = num;
				num = (short)447320184;
				switch (num2 == num)
				{
				}
				num = (short)1756626945;
				if (num != 0)
				{
				}
				num = (short)256901120;
				if (num != 0)
				{
				}
				num = (short)1951596544;
				short num3 = num;
				return base.Count;
			}
		}

		// Token: 0x170003CA RID: 970
		public new global::SpecialFeatures.Flashport.FeatureNode this[int index]
		{
			get
			{
				short num = (short)1695174342;
				short num2 = num;
				num = (short)1837977286;
				switch (num2 == num)
				{
				}
				num = (short)164757504;
				if (num != 0)
				{
				}
				num = (short)368640001;
				if (num != 0)
				{
				}
				num = (short)1410203648;
				short num3 = num;
				return base[index];
			}
		}

		// Token: 0x0600097D RID: 2429 RVA: 0x000A99F8 File Offset: 0x000A7BF8
		public new int IndexOf(global::SpecialFeatures.Flashport.FeatureNode record)
		{
			short num = (short)1360658888;
			short num2 = num;
			num = (short)1230504392;
			switch (num2 == num)
			{
			}
			num = (short)227147776;
			if (num != 0)
			{
			}
			num = (short)511770625;
			if (num != 0)
			{
			}
			num = (short)1873346560;
			short num3 = num;
			return base.IndexOf(record);
		}

		// Token: 0x170003CB RID: 971
		// (get) Token: 0x0600097E RID: 2430 RVA: 0x000A9AA8 File Offset: 0x000A7CA8
		// (set) Token: 0x0600097F RID: 2431 RVA: 0x000A9B58 File Offset: 0x000A7D58
		public bool SingleInstance
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1135799172;
				short num2 = num;
				num = (short)454880132;
				switch (num2 == num)
				{
				}
				num = (short)1921318913;
				if (num != 0)
				{
				}
				num = (short)1445396480;
				if (num != 0)
				{
				}
				num = (short)449642496;
				short num3 = num;
				return this.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			protected set
			{
				short num = (short)1186617305;
				short num2 = num;
				num = (short)1279023065;
				switch (num2 == num)
				{
				}
				num = (short)1900085248;
				short num3 = num;
				num = (short)1593442304;
				if (num != 0)
				{
				}
				num = (short)31326209;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x170003CC RID: 972
		// (get) Token: 0x06000980 RID: 2432 RVA: 0x000A9C0C File Offset: 0x000A7E0C
		// (set) Token: 0x06000981 RID: 2433 RVA: 0x000A9CBC File Offset: 0x000A7EBC
		public string UIPagePath
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)168884301;
				short num2 = num;
				num = (short)2013526093;
				switch (num2 == num)
				{
				}
				num = (short)1060700160;
				short num3 = num;
				num = (short)2063269889;
				if (num != 0)
				{
				}
				num = (short)1624047616;
				if (num != 0)
				{
				}
				return this.d;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			protected set
			{
				short num = (short)782273336;
				short num2 = num;
				num = (short)1809615672;
				switch (num2 == num)
				{
				}
				num = (short)349700096;
				short num3 = num;
				num = (short)1147600897;
				if (num != 0)
				{
				}
				num = (short)965541888;
				if (num != 0)
				{
				}
				this.d = value;
			}
		}

		// Token: 0x06000982 RID: 2434 RVA: 0x000A9D6C File Offset: 0x000A7F6C
		public global::SpecialFeatures.Flashport.FeatureNode NodeFromId(int nodeId)
		{
			int a_ = 13;
			global::System.Collections.Generic.IEnumerator<global::SpecialFeatures.Flashport.FeatureNode> enumerator = base.GetEnumerator();
			short num;
			global::SpecialFeatures.Flashport.FeatureNode result;
			try
			{
				num = (short)1731133446;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						global::SpecialFeatures.Flashport.FeatureNode featureNode;
						if (featureNode.NodeId == nodeId)
						{
							num = (short)410714114;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 1:
						goto IL_14B;
					case 2:
					{
						global::SpecialFeatures.Flashport.FeatureNode featureNode;
						result = featureNode;
						num = (short)444465157;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)510787588;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::SpecialFeatures.Flashport.FeatureNode featureNode = enumerator.Current;
						num = (short)598343680;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						num = (short)2068840449;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_107;
					case 6:
						switch (0)
						{
						case 0:
							goto IL_79;
						}
						continue;
					}
					IL_7B:
					num = (short)1158348803;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_79:
					goto IL_7B;
				}
				IL_107:
				num = (short)189530113;
				if (num != 0)
				{
				}
				goto IL_208;
				IL_14B:
				goto IL_12;
			}
			finally
			{
				num = (short)137035778;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_205;
					case 1:
					{
						enumerator.Dispose();
						num = (short)705066967;
						short num3 = num;
						num = (short)1045919703;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_207;
						default:
							num = (short)1019150336;
							if (num != 0)
							{
							}
							num = (short)723910656;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
						switch (0)
						{
						case 0:
							goto IL_181;
						}
						continue;
					}
					IL_181:
					if (enumerator == null)
					{
						break;
					}
					num = (short)1544421377;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_205:
				IL_207:;
			}
			goto IL_208;
			IL_12:
			throw new global::System.ArgumentException(this.RecordsetName + global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("낏ﮓ몙풟芡첣장\udea7쾩貫쾭邯\udcb1\udbb3튵\uddb7骹쮻ힽ뒿꫁迅資", a_) + nodeId.ToString());
			IL_208:
			num = (short)215351296;
			short num4 = num;
			return result;
		}

		// Token: 0x170003CD RID: 973
		// (get) Token: 0x06000983 RID: 2435 RVA: 0x000A9FC8 File Offset: 0x000A81C8
		// (set) Token: 0x06000984 RID: 2436 RVA: 0x000AA074 File Offset: 0x000A8274
		public bool HasEmbeddedRecset
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)762828658;
				short num2 = num;
				num = (short)1356715890;
				switch (num2 == num)
				{
				}
				num = (short)298778624;
				short num3 = num;
				num = (short)271515648;
				if (num != 0)
				{
				}
				num = (short)1557856257;
				if (num != 0)
				{
				}
				return this.e;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)225902446;
				short num2 = num;
				num = (short)2044919662;
				switch (num2 == num)
				{
				}
				num = (short)356319232;
				short num3 = num;
				num = (short)95617025;
				if (num != 0)
				{
				}
				num = (short)1816264704;
				if (num != 0)
				{
				}
				this.e = value;
			}
		}

		// Token: 0x170003CE RID: 974
		// (get) Token: 0x06000985 RID: 2437 RVA: 0x000AA124 File Offset: 0x000A8324
		// (set) Token: 0x06000986 RID: 2438 RVA: 0x000AA1D8 File Offset: 0x000A83D8
		public bool IsEmbeddedRecset
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1835456969;
				short num2 = num;
				num = (short)2089998793;
				switch (num2 == num)
				{
				}
				num = (short)155451392;
				short num3 = num;
				num = (short)453181440;
				if (num != 0)
				{
				}
				num = (short)516620289;
				if (num != 0)
				{
				}
				return this.f;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			internal set
			{
				short num = (short)1390852038;
				short num2 = num;
				num = (short)1631958982;
				switch (num2 == num)
				{
				}
				num = (short)1813839872;
				short num3 = num;
				num = (short)870580224;
				if (num != 0)
				{
				}
				num = (short)266207233;
				if (num != 0)
				{
				}
				this.f = value;
			}
		}

		// Token: 0x170003CF RID: 975
		// (get) Token: 0x06000987 RID: 2439 RVA: 0x000AA288 File Offset: 0x000A8488
		// (set) Token: 0x06000988 RID: 2440 RVA: 0x000AA338 File Offset: 0x000A8538
		public global::SpecialFeatures.Flashport.FeatureSection ParentSection
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)874851950;
				short num2 = num;
				num = (short)1797402222;
				switch (num2 == num)
				{
				}
				num = (short)1449656320;
				short num3 = num;
				num = (short)1577648129;
				if (num != 0)
				{
				}
				num = (short)1695023104;
				if (num != 0)
				{
				}
				return this.g;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)2071928257;
				short num2 = num;
				num = (short)572464577;
				switch (num2 == num)
				{
				}
				num = (short)1904738304;
				short num3 = num;
				num = (short)1066008577;
				if (num != 0)
				{
				}
				num = (short)118095872;
				if (num != 0)
				{
				}
				this.g = value;
			}
		}

		// Token: 0x06000989 RID: 2441 RVA: 0x000AA3EC File Offset: 0x000A85EC
		public global::System.Collections.Generic.IEnumerable<global::SpecialFeatures.Flashport.Field> Search(string token)
		{
			short num = (short)861929473;
			if (num != 0)
			{
			}
			num = (short)1129009282;
			short num2 = num;
			num = (short)24662146;
			switch (num2 == num)
			{
			default:
			{
				num = (short)174653440;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1378287616;
			if (num != 0)
			{
			}
			global::SpecialFeatures.Flashport.Recordset.<Search>d__50 <Search>d__ = new global::SpecialFeatures.Flashport.Recordset.<Search>d__50(-2);
			<Search>d__.<>4__this = this;
			<Search>d__.<>3__token = token;
			return <Search>d__;
		}

		// Token: 0x170003D0 RID: 976
		// (get) Token: 0x0600098A RID: 2442 RVA: 0x000AA4AC File Offset: 0x000A86AC
		// (set) Token: 0x0600098B RID: 2443 RVA: 0x000AA55C File Offset: 0x000A875C
		public string UIName
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1567129527;
				short num2 = num;
				num = (short)1850900407;
				switch (num2 == num)
				{
				}
				num = (short)2027421696;
				short num3 = num;
				num = (short)654245888;
				if (num != 0)
				{
				}
				num = (short)605159425;
				if (num != 0)
				{
				}
				return this.h;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1820312129;
				short num2 = num;
				num = (short)604684865;
				switch (num2 == num)
				{
				}
				num = (short)769523712;
				short num3 = num;
				num = (short)720633856;
				if (num != 0)
				{
				}
				num = (short)221642753;
				if (num != 0)
				{
				}
				this.h = value;
			}
		}

		// Token: 0x170003D1 RID: 977
		// (get) Token: 0x0600098C RID: 2444 RVA: 0x000AA60C File Offset: 0x000A880C
		// (set) Token: 0x0600098D RID: 2445 RVA: 0x000AA6BC File Offset: 0x000A88BC
		public virtual int Min
		{
			get
			{
				short num = (short)493158401;
				if (num != 0)
				{
				}
				num = (short)1580591995;
				short num2 = num;
				num = (short)947186555;
				switch (num2 == num)
				{
				default:
				{
					num = (short)899284992;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)267190272;
				if (num != 0)
				{
				}
				return this.i;
			}
			set
			{
				short num = (short)1637618977;
				short num2 = num;
				num = (short)1325667617;
				switch (num2 == num)
				{
				}
				num = (short)55050240;
				short num3 = num;
				num = (short)1260519425;
				if (num != 0)
				{
				}
				num = (short)1215561728;
				if (num != 0)
				{
				}
				this.i = value;
			}
		}

		// Token: 0x170003D2 RID: 978
		// (get) Token: 0x0600098E RID: 2446 RVA: 0x000AA770 File Offset: 0x000A8970
		// (set) Token: 0x0600098F RID: 2447 RVA: 0x000AA81C File Offset: 0x000A8A1C
		public virtual int Max
		{
			get
			{
				short num = (short)174082637;
				short num2 = num;
				num = (short)1353206349;
				switch (num2 == num)
				{
				}
				num = (short)232914944;
				short num3 = num;
				num = (short)651296769;
				if (num != 0)
				{
				}
				num = (short)844627968;
				if (num != 0)
				{
				}
				return this.j;
			}
			set
			{
				short num = (short)1360097798;
				short num2 = num;
				num = (short)530477574;
				switch (num2 == num)
				{
				}
				num = (short)1395392512;
				short num3 = num;
				num = (short)1864433665;
				if (num != 0)
				{
				}
				num = (short)1809776640;
				if (num != 0)
				{
				}
				this.j = value;
			}
		}

		// Token: 0x040003C3 RID: 963
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private int a;

		// Token: 0x040003C4 RID: 964
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string b;

		// Token: 0x040003C5 RID: 965
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool c;

		// Token: 0x040003C6 RID: 966
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string d;

		// Token: 0x040003C7 RID: 967
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool e;

		// Token: 0x040003C8 RID: 968
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool f;

		// Token: 0x040003C9 RID: 969
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::SpecialFeatures.Flashport.FeatureSection g;

		// Token: 0x040003CA RID: 970
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string h;

		// Token: 0x040003CB RID: 971
		private int i;

		// Token: 0x040003CC RID: 972
		private int j;
	}
}
