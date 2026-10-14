using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile
{
	// Token: 0x020000FF RID: 255
	[global::System.Serializable]
	public class SecureHardwareEncryptionKeyReferencesList : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x060025D0 RID: 9680 RVA: 0x0024D58C File Offset: 0x0024B78C
		public SecureHardwareEncryptionKeyReferencesList(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.innerRecset = new global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureHardwareEncryptionKeyReferencesListInnerRecset();
			base.EmbeddedRecset = this.innerRecset;
			this.innerRecset.ParentSection = this;
			this.Init();
		}

		// Token: 0x060025D1 RID: 9681 RVA: 0x0024D5CC File Offset: 0x0024B7CC
		protected SecureHardwareEncryptionKeyReferencesList(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x060025D2 RID: 9682 RVA: 0x0024D5E4 File Offset: 0x0024B7E4
		public override void Init()
		{
			int a_ = 14;
			short num = (short)1658808855;
			short num2 = num;
			num = (short)1241999895;
			switch (num2 == num)
			{
			}
			num = (short)416415745;
			if (num != 0)
			{
			}
			num = (short)2118713344;
			short num3 = num;
			num = (short)1788870656;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("鳎듐냒ꃔꗖ볘ﯚ飜뇞苠釢鳤韦鷨苪苬臮퇰룲郴軶\ud9f8ꧺ飼駾搀焂怄椆樈渊縌⼎崐稒昔挖", a_);
			base.Id = 10126;
			base.UIName = global::CommonResources.AcgResources.ID_SECUREENCRYPTIONKEYREFERENCESLIST;
			base.DataTransferOrder = 1;
		}

		// Token: 0x060025D3 RID: 9683 RVA: 0x0024D6C4 File Offset: 0x0024B8C4
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 7;
			short num = (short)195585577;
			short num2 = num;
			num = (short)1634756137;
			switch (num2 == num)
			{
			}
			num = (short)761593856;
			if (num != 0)
			{
			}
			num = (short)130678784;
			short num3 = num;
			num = (short)417792001;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("鯇꿉꿋믍ꋏ럑鏕뛗맙껛꟝郟雡跣觥蛧쫩꟫语觯틱꛳鏵黷鿹軻鯽滿愁愃甅⠇䘉攋納搏", a_);
			base.Id = 10126;
			base.UIName = global::CommonResources.AcgResources.ID_SECUREENCRYPTIONKEYREFERENCESLIST;
			base.DataTransferOrder = 1;
		}

		// Token: 0x060025D4 RID: 9684 RVA: 0x0024D7A4 File Offset: 0x0024B9A4
		public override void PopulateReferences()
		{
			short num = (short)662437889;
			if (num != 0)
			{
			}
			num = (short)1520226091;
			short num2 = num;
			num = (short)120573739;
			switch (num2 == num)
			{
			}
			num = (short)1066205184;
			short num3 = num;
			num = (short)1384054784;
			if (num != 0)
			{
			}
		}

		// Token: 0x060025D5 RID: 9685 RVA: 0x0024D850 File Offset: 0x0024BA50
		public override void DropReferences()
		{
			short num = (short)16898875;
			short num2 = num;
			num = (short)1826478907;
			switch (num2 == num)
			{
			}
			num = (short)504496129;
			if (num != 0)
			{
			}
			num = (short)891813888;
			short num3 = num;
			num = (short)85458944;
			if (num != 0)
			{
			}
		}

		// Token: 0x060025D6 RID: 9686 RVA: 0x0024D8F8 File Offset: 0x0024BAF8
		public override void SetConstraints()
		{
			short num = (short)502368279;
			short num2 = num;
			num = (short)1545242647;
			switch (num2 == num)
			{
			}
			num = (short)1799421952;
			if (num != 0)
			{
			}
			num = (short)203161600;
			short num3 = num;
			num = (short)1137836033;
			if (num != 0)
			{
			}
		}

		// Token: 0x060025D7 RID: 9687 RVA: 0x0024D9A0 File Offset: 0x0024BBA0
		public override void SetupDependencies()
		{
			short num = (short)356046421;
			short num2 = num;
			num = (short)1188091477;
			switch (num2 == num)
			{
			}
			num = (short)1761607681;
			if (num != 0)
			{
			}
			num = (short)1947795456;
			short num3 = num;
			num = (short)56164352;
			if (num != 0)
			{
			}
		}

		// Token: 0x17001308 RID: 4872
		// (get) Token: 0x060025D8 RID: 9688 RVA: 0x0024DA4C File Offset: 0x0024BC4C
		public bool HasDiffs
		{
			get
			{
				short num = (short)789483694;
				short num2 = num;
				num = (short)128290990;
				switch (num2 == num)
				{
				}
				num = (short)1883176961;
				if (num != 0)
				{
				}
				num = (short)664076288;
				short num3 = num;
				num = (short)1375731712;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x060025D9 RID: 9689 RVA: 0x0024DAFC File Offset: 0x0024BCFC
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
						num2 = (short)2050162690;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 1:
					num2 = (short)46989312;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
				{
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)158135315;
					short num3 = num2;
					num2 = (short)162722835;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_99;
					default:
						num2 = (short)53805056;
						if (num2 != 0)
						{
						}
						num2 = (short)327352324;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 3:
					if (base.ParentRecset != null)
					{
						goto IL_99;
					}
					return result;
				case 4:
					return result;
				}
				goto IL_24;
				IL_99:
				num2 = (short)1199833089;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_24:
			num2 = (short)231473152;
			short num4 = num2;
			num2 = (short)696057857;
			if (num2 != 0)
			{
			}
			result = null;
			num2 = (short)1797521411;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x04000D6D RID: 3437
		private global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureHardwareEncryptionKeyReferencesListInnerRecset innerRecset;
	}
}
