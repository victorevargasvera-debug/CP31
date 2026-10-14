using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace SpecialFeatures.Flashport
{
	// Token: 0x02000070 RID: 112
	public abstract class FeatureNode
	{
		// Token: 0x170003B6 RID: 950
		// (get) Token: 0x06000934 RID: 2356 RVA: 0x000A58BC File Offset: 0x000A3ABC
		// (set) Token: 0x06000935 RID: 2357 RVA: 0x000A596C File Offset: 0x000A3B6C
		public bool HasEmbeddedRecset
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)45449574;
				short num2 = num;
				num = (short)1068073318;
				switch (num2 == num)
				{
				default:
				{
					num = (short)672989184;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1862664192;
				if (num != 0)
				{
				}
				num = (short)735117313;
				if (num != 0)
				{
				}
				return this.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1344638839;
				short num2 = num;
				num = (short)556896119;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2043478016;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)812843008;
				if (num != 0)
				{
				}
				num = (short)502530049;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x06000936 RID: 2358 RVA: 0x00002AB6 File Offset: 0x00000CB6
		private FeatureNode()
		{
			this.b = ++global::SpecialFeatures.Flashport.FeatureNode.NodeIdCounter;
		}

		// Token: 0x06000937 RID: 2359 RVA: 0x00002AD1 File Offset: 0x00000CD1
		protected FeatureNode(global::SpecialFeatures.Flashport.Recordset parent) : this()
		{
			this.d = new global::System.Collections.Generic.Dictionary<int, global::SpecialFeatures.Flashport.FeatureSection>();
			this.a = parent;
		}

		// Token: 0x06000938 RID: 2360 RVA: 0x000A5A20 File Offset: 0x000A3C20
		internal void Initialize()
		{
			short num = (short)1537592122;
			short num2 = num;
			num = (short)711183162;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1328939008;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)221380609;
			if (num != 0)
			{
			}
			num = (short)2134573056;
			if (num != 0)
			{
			}
		}

		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x06000939 RID: 2361 RVA: 0x000A5ACC File Offset: 0x000A3CCC
		// (set) Token: 0x0600093A RID: 2362 RVA: 0x000A5B7C File Offset: 0x000A3D7C
		internal global::SpecialFeatures.Flashport.Recordset Parent
		{
			get
			{
				short num = (short)74908774;
				short num2 = num;
				num = (short)1700463718;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2004353024;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)59768832;
				if (num != 0)
				{
				}
				num = (short)877920257;
				if (num != 0)
				{
				}
				return this.a;
			}
			set
			{
				short num = (short)729743361;
				if (num != 0)
				{
				}
				num = (short)484507648;
				short num2 = num;
				num = (short)780339375;
				short num3 = num;
				num = (short)1863059631;
				switch (num3 == num)
				{
				}
				num = (short)535625728;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x0600093B RID: 2363 RVA: 0x000A5C2C File Offset: 0x000A3E2C
		// (set) Token: 0x0600093C RID: 2364 RVA: 0x000A5CE0 File Offset: 0x000A3EE0
		public string FeatureName
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1230372865;
				if (num != 0)
				{
				}
				num = (short)807206912;
				short num2 = num;
				num = (short)859046831;
				short num3 = num;
				num = (short)717816751;
				switch (num3 == num)
				{
				}
				num = (short)744423424;
				if (num != 0)
				{
				}
				return this.f;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)2095825599;
				short num2 = num;
				num = (short)804045503;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1813577728;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)763428865;
				if (num != 0)
				{
				}
				num = (short)1023868928;
				if (num != 0)
				{
				}
				this.f = value;
			}
		}

		// Token: 0x170003B9 RID: 953
		// (get) Token: 0x0600093D RID: 2365 RVA: 0x000A5D90 File Offset: 0x000A3F90
		internal int NodeId
		{
			get
			{
				short num = (short)1949502328;
				short num2 = num;
				num = (short)1649019768;
				switch (num2 == num)
				{
				default:
				{
					num = (short)789184512;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1388642304;
				if (num != 0)
				{
				}
				num = (short)1917583361;
				if (num != 0)
				{
				}
				return this.b;
			}
		}

		// Token: 0x170003BA RID: 954
		// (get) Token: 0x0600093E RID: 2366 RVA: 0x000A5E40 File Offset: 0x000A4040
		// (set) Token: 0x0600093F RID: 2367 RVA: 0x000A5EF0 File Offset: 0x000A40F0
		public string UIPagePath
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)244348315;
				short num2 = num;
				num = (short)1393194395;
				switch (num2 == num)
				{
				default:
				{
					num = (short)165347328;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2138832897;
				if (num != 0)
				{
				}
				num = (short)1111883776;
				if (num != 0)
				{
				}
				return this.g;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			protected set
			{
				short num = (short)1282539521;
				if (num != 0)
				{
				}
				num = (short)127336448;
				short num2 = num;
				num = (short)739508481;
				short num3 = num;
				num = (short)1420886273;
				switch (num3 == num)
				{
				}
				num = (short)242548736;
				if (num != 0)
				{
				}
				this.g = value;
			}
		}

		// Token: 0x170003BB RID: 955
		internal global::SpecialFeatures.Flashport.FeatureSection this[int id]
		{
			get
			{
				short num = (short)39452673;
				if (num != 0)
				{
				}
				if (this.d.ContainsKey(id))
				{
					num = (short)365020314;
					short num2 = num;
					num = (short)74368154;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)329318400;
						short num3 = num;
						num = (short)1993015296;
						if (num != 0)
						{
						}
						return this.d[id];
					}
					}
				}
				return null;
			}
		}

		// Token: 0x06000941 RID: 2369 RVA: 0x000A606C File Offset: 0x000A426C
		internal void AddFeatureSection(global::SpecialFeatures.Flashport.FeatureSection section)
		{
			for (;;)
			{
				IL_00:
				short num = (short)1060306944;
				short num2 = num;
				switch (0)
				{
				case 0:
					goto IL_46;
				}
				int num3;
				for (;;)
				{
					IL_34:
					switch (num3)
					{
					case 0:
						goto IL_11D;
					case 1:
					{
						this.HasEmbeddedRecset = section.HasEmbeddedRecset;
						num = (short)1536750931;
						short num4 = num;
						num = (short)821032275;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num = (short)2023751680;
							if (num != 0)
							{
							}
							num = (short)1272774656;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
						if (!this.HasEmbeddedRecset)
						{
							num = (short)207683585;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_11F;
					}
					break;
				}
				IL_46:
				section.Parent = this;
				num = (short)1455095809;
				if (num != 0)
				{
				}
				num = (short)1523515394;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_34;
			}
			IL_11D:
			IL_11F:
			this.d[section.FeatureSectionId] = section;
		}

		// Token: 0x170003BC RID: 956
		// (get) Token: 0x06000942 RID: 2370 RVA: 0x000A61AC File Offset: 0x000A43AC
		internal global::System.Collections.Generic.IEnumerable<global::SpecialFeatures.Flashport.FeatureSection> FeatureSectionsCollection
		{
			get
			{
				short num = (short)11009852;
				short num2 = num;
				num = (short)567279420;
				switch (num2 == num)
				{
				default:
				{
					num = (short)619511808;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)747110401;
				if (num != 0)
				{
				}
				num = (short)1209466880;
				if (num != 0)
				{
				}
				global::SpecialFeatures.Flashport.FeatureNode.<get_FeatureSectionsCollection>d__29 <get_FeatureSectionsCollection>d__ = new global::SpecialFeatures.Flashport.FeatureNode.<get_FeatureSectionsCollection>d__29(-2);
				<get_FeatureSectionsCollection>d__.<>4__this = this;
				return <get_FeatureSectionsCollection>d__;
			}
		}

		// Token: 0x06000943 RID: 2371 RVA: 0x000A6264 File Offset: 0x000A4464
		internal global::System.Collections.Generic.IEnumerable<global::SpecialFeatures.Flashport.Field> Search(string token)
		{
			short num = (short)1539044405;
			short num2 = num;
			num = (short)985461813;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1002176512;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)773259264;
			if (num != 0)
			{
			}
			num = (short)350945281;
			if (num != 0)
			{
			}
			global::SpecialFeatures.Flashport.FeatureNode.<Search>d__30 <Search>d__ = new global::SpecialFeatures.Flashport.FeatureNode.<Search>d__30(-2);
			<Search>d__.<>4__this = this;
			<Search>d__.<>3__token = token;
			return <Search>d__;
		}

		// Token: 0x170003BD RID: 957
		// (get) Token: 0x06000944 RID: 2372 RVA: 0x000A6324 File Offset: 0x000A4524
		// (set) Token: 0x06000945 RID: 2373 RVA: 0x000A63E4 File Offset: 0x000A45E4
		internal string UIName
		{
			get
			{
				if (this.e == null)
				{
					short num = (short)1833588252;
					short num2 = num;
					num = (short)277960220;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)654376961;
						if (num != 0)
						{
						}
						num = (short)927399936;
						short num3 = num;
						num = (short)1603010560;
						if (num != 0)
						{
						}
						return this.FeatureName;
					}
					}
				}
				return this.e;
			}
			set
			{
				short num = (short)1446190194;
				short num2 = num;
				num = (short)430840946;
				switch (num2 == num)
				{
				default:
				{
					num = (short)473169920;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1955463169;
				if (num != 0)
				{
				}
				num = (short)1935278080;
				if (num != 0)
				{
				}
				this.e = value;
			}
		}

		// Token: 0x170003BE RID: 958
		// (get) Token: 0x06000946 RID: 2374 RVA: 0x000A6494 File Offset: 0x000A4694
		internal global::System.Collections.Generic.IEnumerable<global::SpecialFeatures.Flashport.Field> AllFields
		{
			get
			{
				short num = (short)2057276816;
				short num2 = num;
				num = (short)348360080;
				switch (num2 == num)
				{
				default:
				{
					num = (short)921632768;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1176305665;
				if (num != 0)
				{
				}
				num = (short)1725169664;
				if (num != 0)
				{
				}
				global::SpecialFeatures.Flashport.FeatureNode.<get_AllFields>d__35 <get_AllFields>d__ = new global::SpecialFeatures.Flashport.FeatureNode.<get_AllFields>d__35(-2);
				<get_AllFields>d__.<>4__this = this;
				return <get_AllFields>d__;
			}
		}

		// Token: 0x040003A8 RID: 936
		private global::SpecialFeatures.Flashport.Recordset a;

		// Token: 0x040003A9 RID: 937
		private int b;

		// Token: 0x040003AA RID: 938
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool c;

		// Token: 0x040003AB RID: 939
		private global::System.Collections.Generic.Dictionary<int, global::SpecialFeatures.Flashport.FeatureSection> d;

		// Token: 0x040003AC RID: 940
		internal static int NodeIdCounter;

		// Token: 0x040003AD RID: 941
		private string e;

		// Token: 0x040003AE RID: 942
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string f;

		// Token: 0x040003AF RID: 943
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string g;
	}
}
