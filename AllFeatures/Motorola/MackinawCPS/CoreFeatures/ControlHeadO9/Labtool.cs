using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ControlHeadO9
{
	// Token: 0x0200036F RID: 879
	[global::System.Serializable]
	public class Labtool : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600826D RID: 33389 RVA: 0x007980A8 File Offset: 0x007962A8
		public Labtool(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.innerRecset = new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionButtonBCOListInnerRecset();
			base.EmbeddedRecset = this.innerRecset;
			this.innerRecset.ParentSection = this;
			this.Init();
		}

		// Token: 0x0600826E RID: 33390 RVA: 0x007980E8 File Offset: 0x007962E8
		protected Labtool(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600826F RID: 33391 RVA: 0x00798100 File Offset: 0x00796300
		public override void Init()
		{
			int a_ = 18;
			short num = (short)857931776;
			short num2 = num;
			num = (short)589889537;
			if (num != 0)
			{
			}
			num = (short)860538904;
			short num3 = num;
			num = (short)1152501784;
			switch (num3 == num)
			{
			}
			num = (short)1765408768;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("鿒듔뗖귘듚닜돞", a_);
			base.Id = 10628;
			base.UIName = global::CommonResources.AcgResources.ID_LABTOOL;
			base.DataTransferOrder = 7;
		}

		// Token: 0x06008270 RID: 33392 RVA: 0x007981E0 File Offset: 0x007963E0
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 11;
			short num = (short)177405952;
			short num2 = num;
			num = (short)145398502;
			short num3 = num;
			num = (short)669096678;
			switch (num3 == num)
			{
			}
			num = (short)1158086656;
			if (num != 0)
			{
			}
			num = (short)1256194049;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("胋꿍닏ꛑ믓맕듗", a_);
			base.Id = 10628;
			base.UIName = global::CommonResources.AcgResources.ID_LABTOOL;
			base.DataTransferOrder = 7;
		}

		// Token: 0x06008271 RID: 33393 RVA: 0x007982C4 File Offset: 0x007964C4
		public override void PopulateReferences()
		{
			short num = (short)42467328;
			short num2 = num;
			num = (short)1803610985;
			short num3 = num;
			num = (short)497216361;
			switch (num3 == num)
			{
			}
			num = (short)778174465;
			if (num != 0)
			{
			}
			num = (short)1031929856;
			if (num != 0)
			{
			}
		}

		// Token: 0x06008272 RID: 33394 RVA: 0x00798370 File Offset: 0x00796570
		public override void DropReferences()
		{
			short num = (short)1487273984;
			short num2 = num;
			num = (short)1370189450;
			short num3 = num;
			num = (short)1458138762;
			switch (num3 == num)
			{
			}
			num = (short)1622081536;
			if (num != 0)
			{
			}
			num = (short)1938948097;
			if (num != 0)
			{
			}
		}

		// Token: 0x06008273 RID: 33395 RVA: 0x0079841C File Offset: 0x0079661C
		public override void SetConstraints()
		{
			short num = (short)1275461632;
			short num2 = num;
			num = (short)262566236;
			short num3 = num;
			num = (short)942436700;
			switch (num3 == num)
			{
			}
			num = (short)674365440;
			if (num != 0)
			{
			}
			num = (short)1937113089;
			if (num != 0)
			{
			}
		}

		// Token: 0x06008274 RID: 33396 RVA: 0x007984C4 File Offset: 0x007966C4
		public override void SetupDependencies()
		{
			short num = (short)636747776;
			short num2 = num;
			num = (short)553484688;
			short num3 = num;
			num = (short)1962312080;
			switch (num3 == num)
			{
			}
			num = (short)140312576;
			if (num != 0)
			{
			}
			num = (short)1067581441;
			if (num != 0)
			{
			}
		}

		// Token: 0x17004272 RID: 17010
		// (get) Token: 0x06008275 RID: 33397 RVA: 0x0079856C File Offset: 0x0079676C
		public bool HasDiffs
		{
			get
			{
				short num = (short)623181824;
				short num2 = num;
				num = (short)1955367367;
				short num3 = num;
				num = (short)1320257991;
				switch (num3 == num)
				{
				}
				num = (short)1952055296;
				if (num != 0)
				{
				}
				num = (short)1112408065;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x06008276 RID: 33398 RVA: 0x0079861C File Offset: 0x0079681C
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			short num = (short)1191757664;
			short num2 = num;
			num = (short)1844758368;
			global::AcpCommonLib.IAcpRecordset result;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_88:
				if (base.ParentRecset == null)
				{
					return result;
				}
				num = (short)1416626180;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)1941372928;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_71;
				}
				break;
			}
			for (;;)
			{
				IL_57:
				switch (num3)
				{
				case 0:
					goto IL_88;
				case 1:
					num = (short)1380712449;
					if (num != 0)
					{
					}
					if (base.ParentRecset.ContainerDoc != null)
					{
						num = (short)1898446848;
						short num4 = num;
						num = (short)939589634;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				case 2:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num = (short)425525251;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_D0;
				case 4:
					num = (short)284884993;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_71;
			}
			IL_D0:
			return result;
			IL_71:
			result = null;
			num = (short)818741248;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_57;
		}

		// Token: 0x04003E44 RID: 15940
		private global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionButtonBCOListInnerRecset innerRecset;
	}
}
