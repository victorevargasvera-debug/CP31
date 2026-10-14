using System;
using Infragistics.Windows.DataPresenter;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.UI.CellRangeFill;

namespace Motorola.CommonCPS.RadioManagement.ASTRODataProfile
{
	// Token: 0x02000005 RID: 5
	public class CellEditabilityResolver : global::Motorola.CommonCPS.UI.CellRangeFill.ICellEditabilityResolver
	{
		// Token: 0x0600000C RID: 12 RVA: 0x000025F4 File Offset: 0x000007F4
		public bool CanEdit(global::Infragistics.Windows.DataPresenter.Cell cell)
		{
			int a_ = 17;
			short num = (short)741867527;
			int num2 = (int)((global::System.IntPtr)num);
			bool result;
			for (;;)
			{
				string name;
				global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile astroDataProfile;
				switch (num2)
				{
				case 0:
				{
					num = (short)861833627;
					short num3 = num;
					num = (short)793676187;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_12B;
					default:
						goto IL_35F;
					}
					break;
				}
				case 1:
					goto IL_205;
				case 2:
					num = (short)615841801;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (!(name == global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.ModuleASTRODataProfile.b("\ud9af삱ﶳ\ud8b5첷\udfb9캻\ud8bdꆿꇁꇃ迅飇", a_)))
					{
						num = (short)328990726;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_12B;
				case 4:
					if (!(name == global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.ModuleASTRODataProfile.b("ﶭ얯킱잳햵쪷펹\udebb\udbbd늿证铃", a_)))
					{
						num = (short)109903889;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					result = astroDataProfile.IsSubscriberIPEditable;
					num = (short)1077280768;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					num = (short)1319567373;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					num = (short)445251585;
					if (num != 0)
					{
					}
					num = (short)1275199499;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					switch (0)
					{
					case 0:
						goto IL_7A;
					}
					continue;
				case 8:
					if (!(name == global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.ModuleASTRODataProfile.b("ﺭ햯ힱ욳ﾵ", a_)))
					{
						num = (short)1653407746;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					result = astroDataProfile.IsPeerIPEditable;
					num = (short)1138819073;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					if (!(name == global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.ModuleASTRODataProfile.b("\udcaf잱톳습ힷ햹좻횽蒿韁諃闅뷇꣉뿋귍ꋏ믑뛓돕꫗鏙賛", a_)))
					{
						num = (short)797966341;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					result = astroDataProfile.IsBluetoothDUNSubscriberIPEditable;
					num = (short)181207058;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					goto IL_225;
				case 11:
					result = false;
					num = (short)1097269258;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					goto IL_149;
				case 13:
					if (!(name == global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.ModuleASTRODataProfile.b("\udcaf잱톳습ힷ햹좻횽蒿韁諃雅귇꿉뻋蟍胏", a_)))
					{
						num = (short)197132304;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					result = astroDataProfile.IsBluetoothDUNPeerIPEditable;
					num = (short)463405070;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
					goto IL_307;
				case 15:
					goto IL_95;
				case 16:
					num = (short)203751427;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 17:
				{
					num = (short)1179123712;
					short num4 = num;
					num = (short)724238344;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 18:
					goto IL_B9;
				}
				IL_7A:
				if (cell == null)
				{
					num = (short)446562319;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				astroDataProfile = (cell.Record.DataItem as global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile);
				name = cell.Field.Name;
				num = (short)2135293956;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_12B:
				result = astroDataProfile.IsAirInterfaceIPEditable;
				num = (short)1674444812;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_95:
			throw new global::System.ArgumentNullException(global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.ModuleASTRODataProfile.b("춭햯\udeb1\ud8b3", a_));
			IL_B9:
			IL_149:
			IL_205:
			IL_225:
			IL_307:
			return result;
			IL_35F:
			num = (short)883490816;
			if (num != 0)
			{
			}
			return result;
		}
	}
}
