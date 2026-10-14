using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.RadioWide
{
	// Token: 0x02000187 RID: 391
	[global::System.Serializable]
	public class TPSFireground : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06003F8A RID: 16266 RVA: 0x003BBBC8 File Offset: 0x003B9DC8
		public TPSFireground(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x06003F8B RID: 16267 RVA: 0x003BBBE4 File Offset: 0x003B9DE4
		protected TPSFireground(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06003F8C RID: 16268 RVA: 0x003BBBFC File Offset: 0x003B9DFC
		public override void Init()
		{
			int a_ = 13;
			short num = (short)1236466665;
			short num2 = num;
			num = (short)2082339817;
			switch (num2 == num)
			{
			}
			num = (short)713031681;
			if (num != 0)
			{
			}
			num = (short)1536294912;
			if (num != 0)
			{
			}
			num = (short)1355218944;
			short num3 = num;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("髍胏臑ﯓ蛕뷗꣙꿛뇝軟賡臣諥죧ꯩ迫跭鿯蟱髳苵駷飹闻鋽槿瘁紃", a_);
			base.Id = 10230;
			base.UIName = global::CommonResources.AcgResources.ID_TPSPERSONNELACCOUNTABILITY;
			base.DataTransferOrder = 14;
		}

		// Token: 0x06003F8D RID: 16269 RVA: 0x003BBCE0 File Offset: 0x003B9EE0
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 8;
			short num = (short)823933966;
			short num2 = num;
			num = (short)98450446;
			switch (num2 == num)
			{
			}
			num = (short)411566081;
			if (num != 0)
			{
			}
			num = (short)1501626368;
			if (num != 0)
			{
			}
			num = (short)700317696;
			short num3 = num;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("鷈鯊黌臐뛒꟔ꓖ뛘뗚돜뫞跠쏢ꓤ蓦諨蓪飬臮藰鋲韴黶闸鋺觼蛾", a_);
			base.Id = 10230;
			base.UIName = global::CommonResources.AcgResources.ID_TPSPERSONNELACCOUNTABILITY;
			base.DataTransferOrder = 14;
		}

		// Token: 0x06003F8E RID: 16270 RVA: 0x003BBDC8 File Offset: 0x003B9FC8
		public override void PopulateReferences()
		{
			short num = (short)821376678;
			short num2 = num;
			num = (short)779761318;
			switch (num2 == num)
			{
			}
			num = (short)1599209473;
			if (num != 0)
			{
			}
			num = (short)758317056;
			if (num != 0)
			{
			}
			num = (short)1720320000;
			short num3 = num;
		}

		// Token: 0x06003F8F RID: 16271 RVA: 0x003BBE74 File Offset: 0x003BA074
		public override void DropReferences()
		{
			short num = (short)1646530279;
			short num2 = num;
			num = (short)1364266727;
			switch (num2 == num)
			{
			}
			num = (short)56229888;
			if (num != 0)
			{
			}
			num = (short)1512374273;
			if (num != 0)
			{
			}
			num = (short)14745600;
			short num3 = num;
		}

		// Token: 0x06003F90 RID: 16272 RVA: 0x003BBF20 File Offset: 0x003BA120
		public override void SetConstraints()
		{
			short num = (short)875222467;
			short num2 = num;
			num = (short)904713667;
			switch (num2 == num)
			{
			}
			num = (short)1507131393;
			if (num != 0)
			{
			}
			num = (short)172818432;
			if (num != 0)
			{
			}
			num = (short)1482424320;
			short num3 = num;
		}

		// Token: 0x06003F91 RID: 16273 RVA: 0x003BBFCC File Offset: 0x003BA1CC
		public override void SetupDependencies()
		{
			short num = (short)1456433546;
			short num2 = num;
			num = (short)18114954;
			switch (num2 == num)
			{
			}
			num = (short)1974796288;
			if (num != 0)
			{
			}
			num = (short)1320550401;
			if (num != 0)
			{
			}
			num = (short)1681326080;
			short num3 = num;
		}

		// Token: 0x17002091 RID: 8337
		// (get) Token: 0x06003F92 RID: 16274 RVA: 0x003BC078 File Offset: 0x003BA278
		public bool HasDiffs
		{
			get
			{
				short num = (short)1641807878;
				short num2 = num;
				num = (short)769392646;
				switch (num2 == num)
				{
				}
				num = (short)2129330177;
				if (num != 0)
				{
				}
				num = (short)1824522240;
				if (num != 0)
				{
				}
				num = (short)2046296064;
				short num3 = num;
				return base._HasDiffs;
			}
		}

		// Token: 0x06003F93 RID: 16275 RVA: 0x003BC12C File Offset: 0x003BA32C
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_6F;
			}
			short num;
			global::AcpCommonLib.IAcpRecordset result;
			int num3;
			for (;;)
			{
				IL_0A:
				num = (short)1345077176;
				short num2 = num;
				num = (short)1477459896;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return result;
				default:
					num = (short)905510912;
					if (num != 0)
					{
					}
					switch (num3)
					{
					case 0:
						num = (short)1343225857;
						if (num != 0)
						{
						}
						result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
						num = (short)447610883;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (base.ParentRecset.ContainerDoc != null)
						{
							num = (short)536739840;
							short num4 = num;
							num = (short)1025703936;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 2:
						num = (short)1688272897;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						return result;
					case 4:
						if (base.ParentRecset != null)
						{
							num = (short)1718878210;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					}
					goto IL_6F;
				}
			}
			return result;
			IL_6F:
			result = null;
			num = (short)836698116;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}
	}
}
