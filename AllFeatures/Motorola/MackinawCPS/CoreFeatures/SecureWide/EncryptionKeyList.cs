using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.SecureWide
{
	// Token: 0x020000E1 RID: 225
	[global::System.Serializable]
	public class EncryptionKeyList : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06001ED1 RID: 7889 RVA: 0x001ED7C4 File Offset: 0x001EB9C4
		public EncryptionKeyList(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.innerRecset = new global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInnerRecset();
			base.EmbeddedRecset = this.innerRecset;
			this.innerRecset.ParentSection = this;
			this.Init();
		}

		// Token: 0x06001ED2 RID: 7890 RVA: 0x001ED804 File Offset: 0x001EBA04
		protected EncryptionKeyList(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06001ED3 RID: 7891 RVA: 0x001ED81C File Offset: 0x001EBA1C
		public override void Init()
		{
			int a_ = 14;
			short num = (short)161153025;
			if (num != 0)
			{
			}
			num = (short)814091083;
			short num2 = num;
			num = (short)495586123;
			switch (num2 == num)
			{
			}
			num = (short)673775616;
			short num3 = num;
			num = (short)204668928;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("諎뿐냒꟔껖꧘꿚드냞迠쏢껤苦部쯪ꇬ蛮苰蟲", a_);
			base.Id = 10040;
			base.UIName = global::CommonResources.AcgResources.ID_ENCRYPTIONKEYLIST;
			base.DataTransferOrder = 5;
		}

		// Token: 0x06001ED4 RID: 7892 RVA: 0x001ED904 File Offset: 0x001EBB04
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 6;
			short num = (short)1908147480;
			short num2 = num;
			num = (short)2072642840;
			switch (num2 == num)
			{
			}
			num = (short)1887305729;
			if (num != 0)
			{
			}
			num = (short)1099497472;
			short num3 = num;
			num = (short)1438842880;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("苆ꟈ꣊뿌뛎ꇐ꟒볔룖럘ﯚ雜뫞飠쏢ꧤ軦髨鿪", a_);
			base.Id = 10040;
			base.UIName = global::CommonResources.AcgResources.ID_ENCRYPTIONKEYLIST;
			base.DataTransferOrder = 5;
		}

		// Token: 0x06001ED5 RID: 7893 RVA: 0x001ED9E8 File Offset: 0x001EBBE8
		public override void PopulateReferences()
		{
			short num = (short)1801650177;
			if (num != 0)
			{
			}
			num = (short)289240296;
			short num2 = num;
			num = (short)222131432;
			switch (num2 == num)
			{
			}
			num = (short)972881920;
			short num3 = num;
			num = (short)127401984;
			if (num != 0)
			{
			}
		}

		// Token: 0x06001ED6 RID: 7894 RVA: 0x001EDA90 File Offset: 0x001EBC90
		public override void DropReferences()
		{
			short num = (short)1775976758;
			short num2 = num;
			num = (short)187908406;
			switch (num2 == num)
			{
			}
			num = (short)1990197249;
			if (num != 0)
			{
			}
			num = (short)1250164736;
			short num3 = num;
			num = (short)1285292032;
			if (num != 0)
			{
			}
		}

		// Token: 0x06001ED7 RID: 7895 RVA: 0x001EDB40 File Offset: 0x001EBD40
		public override void SetConstraints()
		{
			short num = (short)162389866;
			short num2 = num;
			num = (short)420667242;
			switch (num2 == num)
			{
			}
			num = (short)1882521600;
			if (num != 0)
			{
			}
			num = (short)1917976576;
			short num3 = num;
			num = (short)244908033;
			if (num != 0)
			{
			}
		}

		// Token: 0x06001ED8 RID: 7896 RVA: 0x001EDBEC File Offset: 0x001EBDEC
		public override void SetupDependencies()
		{
			short num = (short)1975844865;
			if (num != 0)
			{
			}
			num = (short)106158985;
			short num2 = num;
			num = (short)573561737;
			switch (num2 == num)
			{
			}
			num = (short)561840128;
			short num3 = num;
			num = (short)567083008;
			if (num != 0)
			{
			}
		}

		// Token: 0x17000F70 RID: 3952
		// (get) Token: 0x06001ED9 RID: 7897 RVA: 0x001EDC98 File Offset: 0x001EBE98
		public bool HasDiffs
		{
			get
			{
				short num = (short)361186186;
				short num2 = num;
				num = (short)158614410;
				switch (num2 == num)
				{
				}
				num = (short)1629880320;
				if (num != 0)
				{
				}
				num = (short)1161887744;
				short num3 = num;
				num = (short)1729101825;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x06001EDA RID: 7898 RVA: 0x001EDD48 File Offset: 0x001EBF48
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			short num2;
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)1372323841;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 1:
				{
					num2 = (short)1124156765;
					short num3 = num2;
					num2 = (short)302073181;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_6D;
					case 1:
						break;
					default:
					{
						num2 = (short)567148544;
						short num4 = num2;
						break;
					}
					}
					num2 = (short)1133182976;
					if (num2 != 0)
					{
					}
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)110755842;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					return result;
				case 3:
					num2 = (short)20185089;
					if (num2 != 0)
					{
					}
					if (base.ParentRecset != null)
					{
						goto IL_6D;
					}
					return result;
				case 4:
					num2 = (short)293011456;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_24;
				IL_6D:
				num2 = (short)1202913284;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)1691353091;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x04000BAD RID: 2989
		private global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInnerRecset innerRecset;
	}
}
