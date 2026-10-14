using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace SpecialFeatures.Flashport
{
	// Token: 0x0200006C RID: 108
	public abstract class FeatureSection
	{
		// Token: 0x0600090C RID: 2316
		public abstract void Init();

		// Token: 0x170003A7 RID: 935
		// (get) Token: 0x0600090D RID: 2317 RVA: 0x000A37EC File Offset: 0x000A19EC
		// (set) Token: 0x0600090E RID: 2318 RVA: 0x000A3898 File Offset: 0x000A1A98
		protected int Id
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)793444352;
				short num2 = num;
				num = (short)1622095822;
				short num3 = num;
				num = (short)1878407118;
				switch (num3 == num)
				{
				}
				num = (short)854917121;
				if (num != 0)
				{
				}
				num = (short)330825728;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1128792064;
				short num2 = num;
				num = (short)1061477577;
				short num3 = num;
				num = (short)701095113;
				switch (num3 == num)
				{
				}
				num = (short)1503592448;
				if (num != 0)
				{
				}
				num = (short)424476673;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x0600090F RID: 2319 RVA: 0x00002A5F File Offset: 0x00000C5F
		protected FeatureSection() : this(null)
		{
		}

		// Token: 0x06000910 RID: 2320 RVA: 0x00002A68 File Offset: 0x00000C68
		protected FeatureSection(global::SpecialFeatures.Flashport.FeatureNode parent)
		{
			this.Parent = parent;
			this.b = new global::System.Collections.Generic.Dictionary<string, global::SpecialFeatures.Flashport.Field>();
		}

		// Token: 0x170003A8 RID: 936
		// (get) Token: 0x06000911 RID: 2321 RVA: 0x000A3944 File Offset: 0x000A1B44
		// (set) Token: 0x06000912 RID: 2322 RVA: 0x000A39F4 File Offset: 0x000A1BF4
		public global::SpecialFeatures.Flashport.FeatureNode Parent
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)858521600;
				short num2 = num;
				num = (short)1098156642;
				short num3 = num;
				num = (short)1797163618;
				switch (num3 == num)
				{
				}
				num = (short)1025441793;
				if (num != 0)
				{
				}
				num = (short)1341521920;
				if (num != 0)
				{
				}
				return this.e;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)712572929;
				if (num != 0)
				{
				}
				num = (short)1463058068;
				short num2 = num;
				num = (short)201293460;
				switch (num2 == num)
				{
				}
				num = (short)2073100288;
				short num3 = num;
				num = (short)1050214400;
				if (num != 0)
				{
				}
				this.e = value;
			}
		}

		// Token: 0x170003A9 RID: 937
		// (get) Token: 0x06000913 RID: 2323 RVA: 0x000A3AA4 File Offset: 0x000A1CA4
		public global::SpecialFeatures.Flashport.Recordset ParentRecset
		{
			get
			{
				short num;
				if (this.Parent != null)
				{
					num = (short)368690757;
					short num2 = num;
					num = (short)1420150341;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1970798592;
						if (num != 0)
						{
						}
						num = (short)83296257;
						if (num != 0)
						{
						}
						return this.Parent.Parent;
					}
				}
				num = (short)940572672;
				short num3 = num;
				return null;
			}
		}

		// Token: 0x170003AA RID: 938
		// (get) Token: 0x06000914 RID: 2324 RVA: 0x000A3B68 File Offset: 0x000A1D68
		public int FeatureSectionId
		{
			get
			{
				short num = (short)1003657812;
				short num2 = num;
				num = (short)1576835668;
				switch (num2 == num)
				{
				}
				num = (short)535166976;
				if (num != 0)
				{
				}
				num = (short)745799680;
				short num3 = num;
				num = (short)1131479041;
				if (num != 0)
				{
				}
				return this.Id;
			}
		}

		// Token: 0x170003AB RID: 939
		// (get) Token: 0x06000915 RID: 2325 RVA: 0x000A3C1C File Offset: 0x000A1E1C
		// (set) Token: 0x06000916 RID: 2326 RVA: 0x000A3CCC File Offset: 0x000A1ECC
		public string FeatureSectionName
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)445906945;
				if (num != 0)
				{
				}
				num = (short)136462938;
				short num2 = num;
				num = (short)1701003866;
				switch (num2 == num)
				{
				}
				num = (short)1923416064;
				short num3 = num;
				num = (short)84541440;
				if (num != 0)
				{
				}
				return this.f;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1448385820;
				short num2 = num;
				num = (short)435592476;
				switch (num2 == num)
				{
				}
				num = (short)441122817;
				if (num != 0)
				{
				}
				num = (short)1813839872;
				short num3 = num;
				num = (short)284164096;
				if (num != 0)
				{
				}
				this.f = value;
			}
		}

		// Token: 0x170003AC RID: 940
		public global::SpecialFeatures.Flashport.Field this[string name]
		{
			get
			{
				short num;
				if (this.b.ContainsKey(name))
				{
					num = (short)1485843878;
					short num2 = num;
					num = (short)752954790;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)828899328;
						if (num != 0)
						{
						}
						num = (short)1047920641;
						if (num != 0)
						{
						}
						return this.b[name];
					}
				}
				num = (short)1328152576;
				short num3 = num;
				return null;
			}
			set
			{
				short num = (short)1915486209;
				if (num != 0)
				{
				}
				num = (short)104685722;
				short num2 = num;
				num = (short)1463902362;
				switch (num2 == num)
				{
				}
				num = (short)1483145216;
				short num3 = num;
				num = (short)654704640;
				if (num != 0)
				{
				}
				this.b[name] = value;
			}
		}

		// Token: 0x170003AD RID: 941
		// (get) Token: 0x06000919 RID: 2329 RVA: 0x000A3EF8 File Offset: 0x000A20F8
		public global::System.Collections.Generic.IEnumerable<global::SpecialFeatures.Flashport.Field> FieldsCollection
		{
			get
			{
				short num = (short)1059131221;
				short num2 = num;
				num = (short)1394347861;
				switch (num2 == num)
				{
				}
				num = (short)635240449;
				if (num != 0)
				{
				}
				num = (short)1658126336;
				short num3 = num;
				num = (short)1509031936;
				if (num != 0)
				{
				}
				global::SpecialFeatures.Flashport.FeatureSection.<get_FieldsCollection>d__26 <get_FieldsCollection>d__ = new global::SpecialFeatures.Flashport.FeatureSection.<get_FieldsCollection>d__26(-2);
				<get_FieldsCollection>d__.<>4__this = this;
				return <get_FieldsCollection>d__;
			}
		}

		// Token: 0x170003AE RID: 942
		// (get) Token: 0x0600091A RID: 2330 RVA: 0x000A3FB0 File Offset: 0x000A21B0
		public bool HasEmbeddedRecset
		{
			get
			{
				short num = (short)1504815835;
				short num2 = num;
				num = (short)594258651;
				switch (num2 == num)
				{
				}
				num = (short)413859840;
				if (num != 0)
				{
				}
				num = (short)234291200;
				short num3 = num;
				num = (short)1992491009;
				if (num != 0)
				{
				}
				return this.EmbeddedRecset != null;
			}
		}

		// Token: 0x170003AF RID: 943
		// (get) Token: 0x0600091B RID: 2331 RVA: 0x000A4068 File Offset: 0x000A2268
		// (set) Token: 0x0600091C RID: 2332 RVA: 0x000A411C File Offset: 0x000A231C
		public global::SpecialFeatures.Flashport.Recordset EmbeddedRecset
		{
			get
			{
				short num = (short)1626344823;
				short num2 = num;
				num = (short)2005470583;
				switch (num2 == num)
				{
				}
				num = (short)1863909377;
				if (num != 0)
				{
				}
				num = (short)172294144;
				short num3 = num;
				num = (short)865927168;
				if (num != 0)
				{
				}
				return this.c;
			}
			set
			{
				short num = (short)1520173057;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_45;
				}
				int num2;
				for (;;)
				{
					IL_33:
					switch (num2)
					{
					case 0:
					{
						num = (short)1542711459;
						short num3 = num;
						num = (short)571664547;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
						{
							num = (short)1153892352;
							if (num != 0)
							{
							}
							num = (short)1733099520;
							short num4 = num;
							this.c.ParentSection = this;
							this.c.IsEmbeddedRecset = true;
							num = (short)1511587841;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 1:
						return;
					case 2:
						if (this.c != null)
						{
							num = (short)1981677568;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					goto IL_45;
				}
				return;
				IL_45:
				this.c = value;
				num = (short)388038658;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_33;
			}
		}

		// Token: 0x0600091D RID: 2333 RVA: 0x000A4254 File Offset: 0x000A2454
		public global::System.Collections.Generic.IEnumerable<global::SpecialFeatures.Flashport.Field> Search(string token)
		{
			short num = (short)481820673;
			if (num != 0)
			{
			}
			num = (short)2097794384;
			short num2 = num;
			num = (short)1437781328;
			switch (num2 == num)
			{
			}
			num = (short)1015283712;
			short num3 = num;
			num = (short)532807680;
			if (num != 0)
			{
			}
			global::SpecialFeatures.Flashport.FeatureSection.<Search>d__32 <Search>d__ = new global::SpecialFeatures.Flashport.FeatureSection.<Search>d__32(-2);
			<Search>d__.<>4__this = this;
			<Search>d__.<>3__token = token;
			return <Search>d__;
		}

		// Token: 0x170003B0 RID: 944
		// (get) Token: 0x0600091E RID: 2334 RVA: 0x000A4314 File Offset: 0x000A2514
		// (set) Token: 0x0600091F RID: 2335 RVA: 0x000A43DC File Offset: 0x000A25DC
		public string UIName
		{
			get
			{
				short num;
				if (this.d == null)
				{
					num = (short)1389600465;
					short num2 = num;
					num = (short)1056480977;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1284505600;
						if (num != 0)
						{
						}
						num = (short)453378049;
						if (num != 0)
						{
						}
						return this.FeatureSectionName;
					}
				}
				num = (short)1865875456;
				short num3 = num;
				return this.d;
			}
			set
			{
				short num = (short)2050488830;
				short num2 = num;
				num = (short)2093808126;
				switch (num2 == num)
				{
				}
				num = (short)96796672;
				if (num != 0)
				{
				}
				num = (short)1582891008;
				short num3 = num;
				num = (short)1050476545;
				if (num != 0)
				{
				}
				this.d = value;
			}
		}

		// Token: 0x04000396 RID: 918
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private int a;

		// Token: 0x04000397 RID: 919
		private global::System.Collections.Generic.Dictionary<string, global::SpecialFeatures.Flashport.Field> b;

		// Token: 0x04000398 RID: 920
		private global::SpecialFeatures.Flashport.Recordset c;

		// Token: 0x04000399 RID: 921
		private string d;

		// Token: 0x0400039A RID: 922
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::SpecialFeatures.Flashport.FeatureNode e;

		// Token: 0x0400039B RID: 923
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string f;
	}
}
