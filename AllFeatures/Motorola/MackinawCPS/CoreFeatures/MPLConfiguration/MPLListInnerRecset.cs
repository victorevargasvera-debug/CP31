using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.MPLConfiguration
{
	// Token: 0x0200053D RID: 1341
	[global::System.Serializable]
	public class MPLListInnerRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x0600B22B RID: 45611 RVA: 0x00A57AB8 File Offset: 0x00A55CB8
		public MPLListInnerRecset() : base(global::CommonResources.AcgResources.ID_MPLLIST, global::CommonResources.AcgResources.ID_MPLENTRY)
		{
			this.SetValues();
		}

		// Token: 0x0600B22C RID: 45612 RVA: 0x00A57ADC File Offset: 0x00A55CDC
		public MPLListInnerRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x17005940 RID: 22848
		// (get) Token: 0x0600B22D RID: 45613 RVA: 0x00A57B08 File Offset: 0x00A55D08
		public override int MaxPool
		{
			get
			{
				short num = (short)334568244;
				short num2 = num;
				num = (short)757209908;
				switch (num2 == num)
				{
				}
				num = (short)628031489;
				if (num != 0)
				{
				}
				num = (short)2106982400;
				short num3 = num;
				num = (short)1681129472;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.MPLListInnerRecset._MaxPool;
			}
		}

		// Token: 0x17005941 RID: 22849
		// (get) Token: 0x0600B22E RID: 45614 RVA: 0x00A57BB4 File Offset: 0x00A55DB4
		// (set) Token: 0x0600B22F RID: 45615 RVA: 0x00A57C74 File Offset: 0x00A55E74
		public override int Max
		{
			get
			{
				short num = (short)1707379055;
				short num2 = num;
				num = (short)1745455471;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)187760641;
					if (num != 0)
					{
					}
					num = (short)1565458432;
					if (num != 0)
					{
					}
					if (this._DynMax != -1)
					{
						return this._DynMax;
					}
					num = (short)1525547008;
					short num3 = num;
					break;
				}
				}
				return global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.MPLListInnerRecset._Max;
			}
			set
			{
				short num = (short)443020089;
				short num2 = num;
				num = (short)1884746553;
				switch (num2 == num)
				{
				}
				num = (short)288751617;
				if (num != 0)
				{
				}
				num = (short)589168640;
				short num3 = num;
				num = (short)1757020160;
				if (num != 0)
				{
				}
				this._DynMax = value;
			}
		}

		// Token: 0x17005942 RID: 22850
		// (get) Token: 0x0600B230 RID: 45616 RVA: 0x00A57D24 File Offset: 0x00A55F24
		public override int Min
		{
			get
			{
				short num = (short)878580345;
				short num2 = num;
				num = (short)1105138297;
				switch (num2 == num)
				{
				}
				num = (short)1288306688;
				if (num != 0)
				{
				}
				num = (short)530055168;
				short num3 = num;
				num = (short)926810113;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.MPLListInnerRecset._Min;
			}
		}

		// Token: 0x17005943 RID: 22851
		// (get) Token: 0x0600B231 RID: 45617 RVA: 0x00A57DD0 File Offset: 0x00A55FD0
		// (set) Token: 0x0600B232 RID: 45618 RVA: 0x00A57E7C File Offset: 0x00A5607C
		public override int DefaultRecordCount
		{
			get
			{
				short num = (short)1960094782;
				short num2 = num;
				num = (short)163818558;
				switch (num2 == num)
				{
				}
				num = (short)1672544257;
				if (num != 0)
				{
				}
				num = (short)743374848;
				short num3 = num;
				num = (short)711262208;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.MPLListInnerRecset._DefaultRecordCount;
			}
			set
			{
				short num = (short)207956938;
				short num2 = num;
				num = (short)910568394;
				switch (num2 == num)
				{
				}
				num = (short)1591410689;
				if (num != 0)
				{
				}
				num = (short)109248512;
				short num3 = num;
				num = (short)93323264;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.MPLListInnerRecset._DefaultRecordCount = value;
			}
		}

		// Token: 0x17005944 RID: 22852
		// (get) Token: 0x0600B233 RID: 45619 RVA: 0x00A57F2C File Offset: 0x00A5612C
		public bool HasDiffs
		{
			get
			{
				short num = (short)1759495794;
				short num2 = num;
				num = (short)1970914930;
				switch (num2 == num)
				{
				}
				num = (short)1381302273;
				if (num != 0)
				{
				}
				num = (short)114098176;
				short num3 = num;
				num = (short)1293484032;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x0600B234 RID: 45620 RVA: 0x00A57FDC File Offset: 0x00A561DC
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)514129921;
			if (num != 0)
			{
			}
			num = (short)2038258085;
			short num2 = num;
			num = (short)1908300197;
			switch (num2 == num)
			{
			}
			num = (short)2009858048;
			short num3 = num;
			num = (short)608894976;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.MPLListInner(this);
		}

		// Token: 0x0600B235 RID: 45621 RVA: 0x00A58088 File Offset: 0x00A56288
		internal void SetValues()
		{
			short num = (short)1222958378;
			short num2 = num;
			num = (short)1191435562;
			switch (num2 == num)
			{
			}
			num = (short)1516896257;
			if (num != 0)
			{
			}
			num = (short)53018624;
			short num3 = num;
			num = (short)1941241856;
			if (num != 0)
			{
			}
			this._DynMax = -1;
			base.SingleInstance = false;
			base.UIName = global::CommonResources.AcgResources.ID_MPLLIST;
			base.KeySeed = global::CommonResources.AcgResources.ID_MPLENTRY;
			base.DataTransferOrder = 10;
		}

		// Token: 0x0600B236 RID: 45622 RVA: 0x00A58160 File Offset: 0x00A56360
		// Note: this type is marked as 'beforefieldinit'.
		static MPLListInnerRecset()
		{
			short num = (short)1920160378;
			short num2 = num;
			num = (short)981750394;
			switch (num2 == num)
			{
			}
			num = (short)796917761;
			if (num != 0)
			{
			}
			num = (short)320864256;
			short num3 = num;
			num = (short)235339776;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.MPLListInnerRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.MPLListInnerRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.MPLListInnerRecset._Min = 1;
		}

		// Token: 0x04005793 RID: 22419
		public static int _MaxPool;

		// Token: 0x04005794 RID: 22420
		public static int _Max;

		// Token: 0x04005795 RID: 22421
		public int _DynMax;

		// Token: 0x04005796 RID: 22422
		public static int _Min;

		// Token: 0x04005797 RID: 22423
		public static int _DefaultRecordCount;
	}
}
