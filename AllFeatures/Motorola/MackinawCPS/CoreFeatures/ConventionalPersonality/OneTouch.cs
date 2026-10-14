using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality
{
	// Token: 0x020005C5 RID: 1477
	[global::System.Serializable]
	public class OneTouch : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600C886 RID: 51334 RVA: 0x00BB6BB8 File Offset: 0x00BB4DB8
		public OneTouch(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.innerRecset = new global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.OneTouchInnerRecset();
			base.EmbeddedRecset = this.innerRecset;
			this.innerRecset.ParentSection = this;
			this.Init();
		}

		// Token: 0x0600C887 RID: 51335 RVA: 0x00BB6BF8 File Offset: 0x00BB4DF8
		protected OneTouch(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600C888 RID: 51336 RVA: 0x00BB6C10 File Offset: 0x00BB4E10
		public override void Init()
		{
			int a_ = 14;
			short num = (short)67687818;
			short num2 = num;
			num = (short)1953944970;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1248460800;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1012137985;
			if (num != 0)
			{
			}
			num = (short)633339904;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("胎뿐뛒菖뛘껚뻜럞", a_);
			base.Id = 10145;
			base.UIName = global::CommonResources.AcgResources.ID_ONETOUCH;
			base.DataTransferOrder = 11;
		}

		// Token: 0x0600C889 RID: 51337 RVA: 0x00BB6CF8 File Offset: 0x00BB4EF8
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 1;
			short num = (short)1926107582;
			short num2 = num;
			num = (short)111350206;
			switch (num2 == num)
			{
			default:
			{
				num = (short)476708864;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1930756096;
			if (num != 0)
			{
			}
			num = (short)928317441;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("跁꫃ꏅ黉ꏋ믍돏뫑", a_);
			base.Id = 10145;
			base.UIName = global::CommonResources.AcgResources.ID_ONETOUCH;
			base.DataTransferOrder = 11;
		}

		// Token: 0x0600C88A RID: 51338 RVA: 0x00BB6DDC File Offset: 0x00BB4FDC
		public override void PopulateReferences()
		{
			short num = (short)313645190;
			short num2 = num;
			num = (short)536729734;
			switch (num2 == num)
			{
			default:
			{
				num = (short)3407872;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1581318144;
			if (num != 0)
			{
			}
			num = (short)2063859713;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600C88B RID: 51339 RVA: 0x00BB6E84 File Offset: 0x00BB5084
		public override void DropReferences()
		{
			short num = (short)1669759255;
			short num2 = num;
			num = (short)1134133527;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1797128192;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1709178881;
			if (num != 0)
			{
			}
			num = (short)417005568;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600C88C RID: 51340 RVA: 0x00BB6F2C File Offset: 0x00BB512C
		public override void SetConstraints()
		{
			short num = (short)1870081076;
			short num2 = num;
			num = (short)680733748;
			switch (num2 == num)
			{
			default:
			{
				num = (short)94306304;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1105264641;
			if (num != 0)
			{
			}
			num = (short)478806016;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600C88D RID: 51341 RVA: 0x00BB6FD4 File Offset: 0x00BB51D4
		public override void SetupDependencies()
		{
			short num = (short)1417113464;
			short num2 = num;
			num = (short)13528952;
			switch (num2 == num)
			{
			default:
			{
				num = (short)539754496;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1730936833;
			if (num != 0)
			{
			}
			num = (short)504430592;
			if (num != 0)
			{
			}
		}

		// Token: 0x17006499 RID: 25753
		// (get) Token: 0x0600C88E RID: 51342 RVA: 0x00BB7080 File Offset: 0x00BB5280
		public bool HasDiffs
		{
			get
			{
				short num = (short)534584542;
				short num2 = num;
				num = (short)1271667934;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1900281856;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)985792512;
				if (num != 0)
				{
				}
				num = (short)1035927553;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x0600C88F RID: 51343 RVA: 0x00BB7134 File Offset: 0x00BB5334
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
				{
					num2 = (short)29191639;
					short num3 = num2;
					num2 = (short)152268247;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return result;
					case 1:
						break;
					default:
					{
						num2 = (short)346554368;
						short num4 = num2;
						break;
					}
					}
					num2 = (short)541458432;
					if (num2 != 0)
					{
					}
					num2 = (short)848429058;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)780009476;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					num2 = (short)289013761;
					if (num2 != 0)
					{
					}
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)581107713;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 3:
					if (base.ParentRecset != null)
					{
						num2 = (short)855310336;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 4:
					return result;
				}
				goto IL_24;
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)1056243715;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x040064BD RID: 25789
		private global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.OneTouchInnerRecset innerRecset;
	}
}
