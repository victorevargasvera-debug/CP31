using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.Server.EntityModel.DBNodeDataModels
{
	// Token: 0x020001C0 RID: 448
	public class MapEntity
	{
		// Token: 0x17000A3F RID: 2623
		// (get) Token: 0x060016F5 RID: 5877 RVA: 0x000F868C File Offset: 0x000F688C
		// (set) Token: 0x060016F6 RID: 5878 RVA: 0x000F873C File Offset: 0x000F693C
		[global::System.ComponentModel.DataAnnotations.Key]
		public int Id
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1804992512;
				short num2 = num;
				num = (short)1073455244;
				short num3 = num;
				num = (short)1382457484;
				switch (num3 == num)
				{
				}
				num = (short)493158401;
				if (num != 0)
				{
				}
				num = (short)2123300864;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)266797056;
				short num2 = num;
				num = (short)1059243408;
				short num3 = num;
				num = (short)1849345424;
				switch (num3 == num)
				{
				}
				num = (short)424083457;
				if (num != 0)
				{
				}
				num = (short)135135232;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x17000A40 RID: 2624
		// (get) Token: 0x060016F7 RID: 5879 RVA: 0x000F87EC File Offset: 0x000F69EC
		// (set) Token: 0x060016F8 RID: 5880 RVA: 0x000F889C File Offset: 0x000F6A9C
		public global::System.Guid ParentUUID
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)562102272;
				short num2 = num;
				num = (short)457054456;
				short num3 = num;
				num = (short)1447762168;
				switch (num3 == num)
				{
				}
				num = (short)1677721600;
				if (num != 0)
				{
				}
				num = (short)923598849;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)989003776;
				short num2 = num;
				num = (short)146836504;
				short num3 = num;
				num = (short)2062388248;
				switch (num3 == num)
				{
				}
				num = (short)1772814336;
				if (num != 0)
				{
				}
				num = (short)585236481;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x17000A41 RID: 2625
		// (get) Token: 0x060016F9 RID: 5881 RVA: 0x000F8950 File Offset: 0x000F6B50
		// (set) Token: 0x060016FA RID: 5882 RVA: 0x000F8A04 File Offset: 0x000F6C04
		public global::System.Guid ChildUUID
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)175702016;
				short num2 = num;
				num = (short)2136231772;
				short num3 = num;
				num = (short)1447710556;
				switch (num3 == num)
				{
				}
				num = (short)1700986880;
				if (num != 0)
				{
				}
				num = (short)1336016897;
				if (num != 0)
				{
				}
				return this.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1955790848;
				short num2 = num;
				num = (short)114819073;
				if (num != 0)
				{
				}
				num = (short)1208458470;
				short num3 = num;
				num = (short)1765580006;
				switch (num3 == num)
				{
				}
				num = (short)304414720;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x17000A42 RID: 2626
		// (get) Token: 0x060016FB RID: 5883 RVA: 0x000F8AB4 File Offset: 0x000F6CB4
		// (set) Token: 0x060016FC RID: 5884 RVA: 0x000F8B64 File Offset: 0x000F6D64
		[global::System.ComponentModel.DataAnnotations.MaxLength(200)]
		public string ParentType
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1371996160;
				short num2 = num;
				num = (short)454844510;
				short num3 = num;
				num = (short)85811294;
				switch (num3 == num)
				{
				}
				num = (short)1397489665;
				if (num != 0)
				{
				}
				num = (short)2136604672;
				if (num != 0)
				{
				}
				return this.d;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)2131951616;
				short num2 = num;
				num = (short)588956320;
				short num3 = num;
				num = (short)334807712;
				switch (num3 == num)
				{
				}
				num = (short)1698234369;
				if (num != 0)
				{
				}
				num = (short)1691090944;
				if (num != 0)
				{
				}
				this.d = value;
			}
		}

		// Token: 0x17000A43 RID: 2627
		// (get) Token: 0x060016FD RID: 5885 RVA: 0x000F8C14 File Offset: 0x000F6E14
		// (set) Token: 0x060016FE RID: 5886 RVA: 0x000F8CC4 File Offset: 0x000F6EC4
		[global::System.ComponentModel.DataAnnotations.MaxLength(200)]
		public string ChildType
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1511981056;
				short num2 = num;
				num = (short)1474694094;
				short num3 = num;
				num = (short)563481550;
				switch (num3 == num)
				{
				}
				num = (short)2069102593;
				if (num != 0)
				{
				}
				num = (short)2011955200;
				if (num != 0)
				{
				}
				return this.e;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)244973568;
				short num2 = num;
				num = (short)2108333229;
				short num3 = num;
				num = (short)716348589;
				switch (num3 == num)
				{
				}
				num = (short)1404370945;
				if (num != 0)
				{
				}
				num = (short)335937536;
				if (num != 0)
				{
				}
				this.e = value;
			}
		}

		// Token: 0x17000A44 RID: 2628
		// (get) Token: 0x060016FF RID: 5887 RVA: 0x000F8D70 File Offset: 0x000F6F70
		// (set) Token: 0x06001700 RID: 5888 RVA: 0x000F8E20 File Offset: 0x000F7020
		[global::System.ComponentModel.DataAnnotations.MaxLength(400)]
		public string NaviFieldName
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)81592320;
				short num2 = num;
				num = (short)1456710994;
				short num3 = num;
				num = (short)1665508690;
				switch (num3 == num)
				{
				}
				num = (short)1760821249;
				if (num != 0)
				{
				}
				num = (short)157614080;
				if (num != 0)
				{
				}
				return this.f;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)2028470272;
				short num2 = num;
				num = (short)379664682;
				short num3 = num;
				num = (short)464795946;
				switch (num3 == num)
				{
				}
				num = (short)1868365824;
				if (num != 0)
				{
				}
				num = (short)1832779777;
				if (num != 0)
				{
				}
				this.f = value;
			}
		}

		// Token: 0x17000A45 RID: 2629
		// (get) Token: 0x06001701 RID: 5889 RVA: 0x000F8ED0 File Offset: 0x000F70D0
		// (set) Token: 0x06001702 RID: 5890 RVA: 0x000F8F80 File Offset: 0x000F7180
		public global::Motorola.CommonCPS.Server.CommonDBConstants.RelationType RelationType
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1592655872;
				short num2 = num;
				num = (short)254173930;
				short num3 = num;
				num = (short)554590954;
				switch (num3 == num)
				{
				}
				num = (short)935723008;
				if (num != 0)
				{
				}
				num = (short)1858076673;
				if (num != 0)
				{
				}
				return this.g;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1010630656;
				short num2 = num;
				num = (short)236968442;
				short num3 = num;
				num = (short)1515117050;
				switch (num3 == num)
				{
				}
				num = (short)389611521;
				if (num != 0)
				{
				}
				num = (short)249692160;
				if (num != 0)
				{
				}
				this.g = value;
			}
		}

		// Token: 0x17000A46 RID: 2630
		// (get) Token: 0x06001703 RID: 5891 RVA: 0x000F9030 File Offset: 0x000F7230
		// (set) Token: 0x06001704 RID: 5892 RVA: 0x000F90E0 File Offset: 0x000F72E0
		public int Order
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1341587456;
				short num2 = num;
				num = (short)1125439603;
				short num3 = num;
				num = (short)1357109363;
				switch (num3 == num)
				{
				}
				num = (short)1828454401;
				if (num != 0)
				{
				}
				num = (short)1184497664;
				if (num != 0)
				{
				}
				return this.h;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)810418176;
				short num2 = num;
				num = (short)797108205;
				short num3 = num;
				num = (short)1840900077;
				switch (num3 == num)
				{
				}
				num = (short)755367936;
				if (num != 0)
				{
				}
				num = (short)1595604993;
				if (num != 0)
				{
				}
				this.h = value;
			}
		}

		// Token: 0x17000A47 RID: 2631
		// (get) Token: 0x06001705 RID: 5893 RVA: 0x000F9194 File Offset: 0x000F7394
		// (set) Token: 0x06001706 RID: 5894 RVA: 0x000F9244 File Offset: 0x000F7444
		public string Checksum
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)268173312;
				short num2 = num;
				num = (short)410146816;
				short num3 = num;
				num = (short)1407080448;
				switch (num3 == num)
				{
				}
				num = (short)1504313345;
				if (num != 0)
				{
				}
				num = (short)398327808;
				if (num != 0)
				{
				}
				return this.i;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)731709440;
				short num2 = num;
				num = (short)1694164723;
				short num3 = num;
				num = (short)894625523;
				switch (num3 == num)
				{
				}
				num = (short)11141120;
				if (num != 0)
				{
				}
				num = (short)1833107457;
				if (num != 0)
				{
				}
				this.i = value;
			}
		}

		// Token: 0x06001707 RID: 5895 RVA: 0x000F92F8 File Offset: 0x000F74F8
		public MapEntity()
		{
			this.Order = 1;
		}

		// Token: 0x04000AC1 RID: 2753
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private int a;

		// Token: 0x04000AC2 RID: 2754
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Guid b;

		// Token: 0x04000AC3 RID: 2755
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Guid c;

		// Token: 0x04000AC4 RID: 2756
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string d;

		// Token: 0x04000AC5 RID: 2757
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string e;

		// Token: 0x04000AC6 RID: 2758
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string f;

		// Token: 0x04000AC7 RID: 2759
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.Server.CommonDBConstants.RelationType g;

		// Token: 0x04000AC8 RID: 2760
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private int h;

		// Token: 0x04000AC9 RID: 2761
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string i;
	}
}
