using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile
{
	// Token: 0x020000FB RID: 251
	[global::System.Serializable]
	public class SecureHardwareEncryptionIndependentKeyList : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600257E RID: 9598 RVA: 0x00249328 File Offset: 0x00247528
		public SecureHardwareEncryptionIndependentKeyList(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.innerRecset = new global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureHardwareEncryptionIndependentKeyListInnerRecset();
			base.EmbeddedRecset = this.innerRecset;
			this.innerRecset.ParentSection = this;
			this.Init();
		}

		// Token: 0x0600257F RID: 9599 RVA: 0x00249368 File Offset: 0x00247568
		protected SecureHardwareEncryptionIndependentKeyList(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06002580 RID: 9600 RVA: 0x00249380 File Offset: 0x00247580
		public override void Init()
		{
			int a_ = 12;
			short num = (short)120132777;
			short num2 = num;
			num = (short)1398150313;
			switch (num2 == num)
			{
			}
			num = (short)1408565248;
			short num3 = num;
			num = (short)1440677889;
			if (num != 0)
			{
			}
			num = (short)2044657664;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("裌ꇎ닐ꇒ곔Ꟗ귘닚닜뇞쇠꣢胤黦짨꟪蓬鳮藰", a_);
			base.Id = 10881;
			base.UIName = global::CommonResources.AcgResources.ID_ENCRYPTIONKEYLIST;
			base.DataTransferOrder = 13;
		}

		// Token: 0x06002581 RID: 9601 RVA: 0x00249464 File Offset: 0x00247664
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 10;
			short num = (short)4092166;
			short num2 = num;
			num = (short)1224962310;
			switch (num2 == num)
			{
			}
			num = (short)1239482368;
			short num3 = num;
			num = (short)1638596609;
			if (num != 0)
			{
			}
			num = (short)1829306368;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("車ꏌ곎ꏐ꫒ꗔꏖ냘듚돜￞ꫠ蛢鳤쟦ꗨ苪黬鯮", a_);
			base.Id = 10881;
			base.UIName = global::CommonResources.AcgResources.ID_ENCRYPTIONKEYLIST;
			base.DataTransferOrder = 13;
		}

		// Token: 0x06002582 RID: 9602 RVA: 0x00249544 File Offset: 0x00247744
		public override void PopulateReferences()
		{
			short num = (short)644349953;
			if (num != 0)
			{
			}
			num = (short)1239513899;
			short num2 = num;
			num = (short)1237285675;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1561919488;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1242431488;
			if (num != 0)
			{
			}
		}

		// Token: 0x06002583 RID: 9603 RVA: 0x002495EC File Offset: 0x002477EC
		public override void DropReferences()
		{
			short num = (short)2069838602;
			short num2 = num;
			num = (short)2000304906;
			switch (num2 == num)
			{
			}
			num = (short)1350500353;
			if (num != 0)
			{
			}
			num = (short)2059010048;
			if (num != 0)
			{
			}
			num = (short)1253441536;
			short num3 = num;
		}

		// Token: 0x06002584 RID: 9604 RVA: 0x00249694 File Offset: 0x00247894
		public override void SetConstraints()
		{
			short num = (short)919066271;
			short num2 = num;
			num = (short)127456927;
			switch (num2 == num)
			{
			}
			num = (short)1322975233;
			if (num != 0)
			{
			}
			num = (short)1951334400;
			if (num != 0)
			{
			}
			num = (short)174522368;
			short num3 = num;
		}

		// Token: 0x06002585 RID: 9605 RVA: 0x0024973C File Offset: 0x0024793C
		public override void SetupDependencies()
		{
			short num = (short)224213745;
			short num2 = num;
			num = (short)1969175281;
			switch (num2 == num)
			{
			}
			num = (short)1397751808;
			if (num != 0)
			{
			}
			num = (short)592969729;
			if (num != 0)
			{
			}
			num = (short)722862080;
			short num3 = num;
		}

		// Token: 0x170012E7 RID: 4839
		// (get) Token: 0x06002586 RID: 9606 RVA: 0x002497E8 File Offset: 0x002479E8
		public bool HasDiffs
		{
			get
			{
				short num = (short)867245574;
				short num2 = num;
				num = (short)203169286;
				switch (num2 == num)
				{
				}
				num = (short)2102067201;
				if (num != 0)
				{
				}
				num = (short)1951334400;
				if (num != 0)
				{
				}
				num = (short)1142358016;
				short num3 = num;
				return base._HasDiffs;
			}
		}

		// Token: 0x06002587 RID: 9607 RVA: 0x00249898 File Offset: 0x00247A98
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				switch (0)
				{
				case 0:
					goto IL_24;
				}
				short num2;
				for (;;)
				{
					IL_0A:
					int num;
					switch (num)
					{
					case 0:
						result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
						num2 = (short)764084225;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 1:
						return result;
					case 2:
						if (base.ParentRecset != null)
						{
							num2 = (short)875626500;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					case 3:
						if (base.ParentRecset.ContainerDoc != null)
						{
							num2 = (short)394985472;
							short num3 = num2;
							num2 = (short)1580138496;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					case 4:
						num2 = (short)344915969;
						if (num2 != 0)
						{
						}
						num2 = (short)574685187;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				IL_24:
				num2 = (short)1686509028;
				short num4 = num2;
				num2 = (short)518591972;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num2 = (short)938999808;
					if (num2 != 0)
					{
					}
					result = null;
					num2 = (short)1241776130;
					int num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				}
			}
			return result;
		}

		// Token: 0x04000D65 RID: 3429
		private global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureHardwareEncryptionIndependentKeyListInnerRecset innerRecset;
	}
}
