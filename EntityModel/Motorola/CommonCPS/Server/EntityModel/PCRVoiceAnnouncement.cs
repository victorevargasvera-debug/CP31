using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x02000087 RID: 135
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class PCRVoiceAnnouncement : global::Motorola.CommonCPS.Server.EntityModel.PCRPackage
	{
		// Token: 0x06000A4F RID: 2639 RVA: 0x0006F460 File Offset: 0x0006D660
		public PCRVoiceAnnouncement()
		{
			this.MatrixTemplates = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.MatrixTemplate>();
			this.MatrixCodeplugs = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.MatrixCodeplug>();
		}

		// Token: 0x170004D9 RID: 1241
		// (get) Token: 0x06000A50 RID: 2640 RVA: 0x0006F48C File Offset: 0x0006D68C
		// (set) Token: 0x06000A51 RID: 2641 RVA: 0x0006F53C File Offset: 0x0006D73C
		[global::System.Runtime.Serialization.DataMember]
		public string PackageName
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)521075787;
				short num2 = num;
				num = (short)1860697163;
				switch (num2 == num)
				{
				}
				num = (short)934019072;
				short num3 = num;
				num = (short)659161089;
				if (num != 0)
				{
				}
				num = (short)436404224;
				if (num != 0)
				{
				}
				return this.<PackageName>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)376266130;
				short num2 = num;
				num = (short)1524194706;
				switch (num2 == num)
				{
				}
				num = (short)1235222528;
				short num3 = num;
				num = (short)1966407681;
				if (num != 0)
				{
				}
				num = (short)1629224960;
				if (num != 0)
				{
				}
				this.<PackageName>k__BackingField = value;
			}
		}

		// Token: 0x170004DA RID: 1242
		// (get) Token: 0x06000A52 RID: 2642 RVA: 0x0006F5EC File Offset: 0x0006D7EC
		// (set) Token: 0x06000A53 RID: 2643 RVA: 0x0006F69C File Offset: 0x0006D89C
		[global::System.Runtime.Serialization.DataMember]
		public int? ReferenceCount
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)526490738;
				short num2 = num;
				num = (short)1600756850;
				switch (num2 == num)
				{
				}
				num = (short)1747845120;
				short num3 = num;
				num = (short)1695088640;
				if (num != 0)
				{
				}
				num = (short)628293633;
				if (num != 0)
				{
				}
				return this.<ReferenceCount>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)274464769;
				if (num != 0)
				{
				}
				num = (short)648176927;
				short num2 = num;
				num = (short)1916495135;
				switch (num2 == num)
				{
				default:
				{
					num = (short)693239808;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1678835712;
				if (num != 0)
				{
				}
				this.<ReferenceCount>k__BackingField = value;
			}
		}

		// Token: 0x170004DB RID: 1243
		// (get) Token: 0x06000A54 RID: 2644 RVA: 0x0006F74C File Offset: 0x0006D94C
		// (set) Token: 0x06000A55 RID: 2645 RVA: 0x0006F7FC File Offset: 0x0006D9FC
		[global::System.Runtime.Serialization.DataMember]
		public int? FileSize
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)441130143;
				short num2 = num;
				num = (short)928324767;
				switch (num2 == num)
				{
				}
				num = (short)1575550976;
				short num3 = num;
				num = (short)781385729;
				if (num != 0)
				{
				}
				num = (short)1709244416;
				if (num != 0)
				{
				}
				return this.<FileSize>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1429204477;
				short num2 = num;
				num = (short)687533565;
				switch (num2 == num)
				{
				}
				num = (short)1800929280;
				short num3 = num;
				num = (short)1208549377;
				if (num != 0)
				{
				}
				num = (short)854065152;
				if (num != 0)
				{
				}
				this.<FileSize>k__BackingField = value;
			}
		}

		// Token: 0x170004DC RID: 1244
		// (get) Token: 0x06000A56 RID: 2646 RVA: 0x0006F8AC File Offset: 0x0006DAAC
		// (set) Token: 0x06000A57 RID: 2647 RVA: 0x0006F95C File Offset: 0x0006DB5C
		[global::System.Runtime.Serialization.DataMember]
		public virtual global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.MatrixTemplate> MatrixTemplates
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1026746629;
				short num2 = num;
				num = (short)305391877;
				switch (num2 == num)
				{
				}
				num = (short)1386283008;
				short num3 = num;
				num = (short)2015166465;
				if (num != 0)
				{
				}
				num = (short)77135872;
				if (num != 0)
				{
				}
				return this.<MatrixTemplates>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)511587768;
				short num2 = num;
				num = (short)982136248;
				switch (num2 == num)
				{
				}
				num = (short)2111963136;
				short num3 = num;
				num = (short)1225588737;
				if (num != 0)
				{
				}
				num = (short)534052864;
				if (num != 0)
				{
				}
				this.<MatrixTemplates>k__BackingField = value;
			}
		}

		// Token: 0x170004DD RID: 1245
		// (get) Token: 0x06000A58 RID: 2648 RVA: 0x0006FA0C File Offset: 0x0006DC0C
		// (set) Token: 0x06000A59 RID: 2649 RVA: 0x0006FABC File Offset: 0x0006DCBC
		[global::System.Runtime.Serialization.DataMember]
		public virtual global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.MatrixCodeplug> MatrixCodeplugs
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1627420380;
				short num2 = num;
				num = (short)739866332;
				switch (num2 == num)
				{
				}
				num = (short)1590624256;
				short num3 = num;
				num = (short)1770979329;
				if (num != 0)
				{
				}
				num = (short)615317504;
				if (num != 0)
				{
				}
				return this.<MatrixCodeplugs>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)172795511;
				short num2 = num;
				num = (short)331196023;
				switch (num2 == num)
				{
				}
				num = (short)1359347712;
				short num3 = num;
				num = (short)244252672;
				if (num != 0)
				{
				}
				num = (short)97845249;
				if (num != 0)
				{
				}
				this.<MatrixCodeplugs>k__BackingField = value;
			}
		}
	}
}
