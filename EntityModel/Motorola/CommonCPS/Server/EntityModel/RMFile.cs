using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x02000094 RID: 148
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class RMFile : global::Motorola.CommonCPS.Server.EntityModel.IEntity
	{
		// Token: 0x06000B51 RID: 2897 RVA: 0x00079F44 File Offset: 0x00078144
		public RMFile()
		{
			this.Codeplugs = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.Codeplug>();
			this.Templates = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.Template>();
			this.Packages = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.Package>();
		}

		// Token: 0x17000553 RID: 1363
		// (get) Token: 0x06000B52 RID: 2898 RVA: 0x00079F78 File Offset: 0x00078178
		// (set) Token: 0x06000B53 RID: 2899 RVA: 0x0007A02C File Offset: 0x0007822C
		[global::System.Runtime.Serialization.DataMember]
		public string Url
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1232227760;
				short num2 = num;
				num = (short)220679600;
				switch (num2 == num)
				{
				}
				num = (short)1813839872;
				if (num != 0)
				{
				}
				num = (short)332922881;
				if (num != 0)
				{
				}
				num = (short)962723840;
				short num3 = num;
				return this.<Url>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1374720576;
				short num2 = num;
				num = (short)1943769664;
				switch (num2 == num)
				{
				}
				num = (short)2012479489;
				if (num != 0)
				{
				}
				num = (short)810745856;
				if (num != 0)
				{
				}
				num = (short)1805647872;
				short num3 = num;
				this.<Url>k__BackingField = value;
			}
		}

		// Token: 0x17000554 RID: 1364
		// (get) Token: 0x06000B54 RID: 2900 RVA: 0x0007A0DC File Offset: 0x000782DC
		// (set) Token: 0x06000B55 RID: 2901 RVA: 0x0007A18C File Offset: 0x0007838C
		[global::System.Runtime.Serialization.DataMember]
		public string HashCode
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)854652877;
				short num2 = num;
				num = (short)1048836045;
				switch (num2 == num)
				{
				}
				num = (short)206503937;
				if (num != 0)
				{
				}
				num = (short)1194721280;
				if (num != 0)
				{
				}
				num = (short)453705728;
				short num3 = num;
				return this.<HashCode>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)767952938;
				short num2 = num;
				num = (short)344459306;
				switch (num2 == num)
				{
				}
				num = (short)1216806913;
				if (num != 0)
				{
				}
				num = (short)2064252928;
				if (num != 0)
				{
				}
				num = (short)1907294208;
				short num3 = num;
				this.<HashCode>k__BackingField = value;
			}
		}

		// Token: 0x17000555 RID: 1365
		// (get) Token: 0x06000B56 RID: 2902 RVA: 0x0007A23C File Offset: 0x0007843C
		// (set) Token: 0x06000B57 RID: 2903 RVA: 0x0007A2EC File Offset: 0x000784EC
		[global::System.Runtime.Serialization.DataMember]
		public string CacheCode
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)160806194;
				short num2 = num;
				num = (short)1530967346;
				switch (num2 == num)
				{
				}
				num = (short)477298689;
				if (num != 0)
				{
				}
				num = (short)817299456;
				if (num != 0)
				{
				}
				num = (short)1257963520;
				short num3 = num;
				return this.<CacheCode>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)354145942;
				short num2 = num;
				num = (short)1311692438;
				switch (num2 == num)
				{
				}
				num = (short)841351169;
				if (num != 0)
				{
				}
				num = (short)1952317440;
				if (num != 0)
				{
				}
				num = (short)1046282240;
				short num3 = num;
				this.<CacheCode>k__BackingField = value;
			}
		}

		// Token: 0x17000556 RID: 1366
		// (get) Token: 0x06000B58 RID: 2904 RVA: 0x0007A3A0 File Offset: 0x000785A0
		// (set) Token: 0x06000B59 RID: 2905 RVA: 0x0007A454 File Offset: 0x00078654
		[global::System.Runtime.Serialization.DataMember]
		public int? Length
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1009780344;
				short num2 = num;
				num = (short)2069956216;
				switch (num2 == num)
				{
				}
				num = (short)1540620288;
				if (num != 0)
				{
				}
				num = (short)2079391745;
				if (num != 0)
				{
				}
				num = (short)294912000;
				short num3 = num;
				return this.<Length>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)117486650;
				short num2 = num;
				num = (short)1729147962;
				switch (num2 == num)
				{
				}
				num = (short)1489698817;
				if (num != 0)
				{
				}
				num = (short)35127296;
				if (num != 0)
				{
				}
				num = (short)2009726976;
				short num3 = num;
				this.<Length>k__BackingField = value;
			}
		}

		// Token: 0x17000557 RID: 1367
		// (get) Token: 0x06000B5A RID: 2906 RVA: 0x0007A504 File Offset: 0x00078704
		// (set) Token: 0x06000B5B RID: 2907 RVA: 0x0007A5B4 File Offset: 0x000787B4
		[global::System.Runtime.Serialization.DataMember]
		public virtual global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.Codeplug> Codeplugs
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)118856393;
				short num2 = num;
				num = (short)943168201;
				switch (num2 == num)
				{
				}
				num = (short)1978335232;
				if (num != 0)
				{
				}
				num = (short)379715585;
				if (num != 0)
				{
				}
				num = (short)1701969920;
				short num3 = num;
				return this.<Codeplugs>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)821960043;
				short num2 = num;
				num = (short)1243356523;
				switch (num2 == num)
				{
				}
				num = (short)936378369;
				if (num != 0)
				{
				}
				num = (short)295895040;
				if (num != 0)
				{
				}
				num = (short)119078912;
				short num3 = num;
				this.<Codeplugs>k__BackingField = value;
			}
		}

		// Token: 0x17000558 RID: 1368
		// (get) Token: 0x06000B5C RID: 2908 RVA: 0x0007A664 File Offset: 0x00078864
		// (set) Token: 0x06000B5D RID: 2909 RVA: 0x0007A714 File Offset: 0x00078914
		[global::System.Runtime.Serialization.DataMember]
		public virtual global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.Template> Templates
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1713027089;
				short num2 = num;
				num = (short)1716303889;
				switch (num2 == num)
				{
				}
				num = (short)1963589633;
				if (num != 0)
				{
				}
				num = (short)285081600;
				if (num != 0)
				{
				}
				num = (short)576258048;
				short num3 = num;
				return this.<Templates>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1773412346;
				short num2 = num;
				num = (short)2053119994;
				switch (num2 == num)
				{
				}
				num = (short)1500446721;
				if (num != 0)
				{
				}
				num = (short)703791104;
				if (num != 0)
				{
				}
				num = (short)276692992;
				short num3 = num;
				this.<Templates>k__BackingField = value;
			}
		}

		// Token: 0x17000559 RID: 1369
		// (get) Token: 0x06000B5E RID: 2910 RVA: 0x0007A7C4 File Offset: 0x000789C4
		// (set) Token: 0x06000B5F RID: 2911 RVA: 0x0007A870 File Offset: 0x00078A70
		[global::System.Runtime.Serialization.DataMember]
		public virtual global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.Package> Packages
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1170079745;
				if (num != 0)
				{
				}
				num = (short)425857811;
				short num2 = num;
				num = (short)1176769299;
				switch (num2 == num)
				{
				}
				num = (short)898826240;
				if (num != 0)
				{
				}
				num = (short)675676160;
				short num3 = num;
				return this.<Packages>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1280109983;
				short num2 = num;
				num = (short)143453599;
				switch (num2 == num)
				{
				}
				num = (short)1409613825;
				if (num != 0)
				{
				}
				num = (short)2136211456;
				if (num != 0)
				{
				}
				num = (short)640745472;
				short num3 = num;
				this.<Packages>k__BackingField = value;
			}
		}
	}
}
