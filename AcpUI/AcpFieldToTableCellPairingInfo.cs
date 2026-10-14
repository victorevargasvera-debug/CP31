using System;
using AcpCommonLib;
using Infragistics.Windows.DataPresenter;

namespace AcpUI
{
	// Token: 0x0200004A RID: 74
	internal class AcpFieldToTableCellPairingInfo
	{
		// Token: 0x0600040A RID: 1034 RVA: 0x000453F8 File Offset: 0x000435F8
		private AcpFieldToTableCellPairingInfo(global::AcpUI.AcpFieldInfo A_0, global::AcpUI.TableCellInfo A_1)
		{
			this.a = A_0;
			this.b = A_1;
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x0004541C File Offset: 0x0004361C
		internal static global::AcpUI.AcpFieldToTableCellPairingInfo a(global::AcpCommonLib.IAcpField A_0, global::Infragistics.Windows.DataPresenter.Cell A_1)
		{
			short num = (short)1256849415;
			int num2 = (int)((global::System.IntPtr)num);
			global::AcpUI.TableCellInfo a_;
			global::AcpUI.AcpFieldInfo a_2;
			for (;;)
			{
				string text;
				switch (num2)
				{
				case 0:
					a_ = new global::AcpUI.MaskedTableCellInfo(A_1.Field.Label as string, global::AcpUI.CellPosition.c(A_1), text);
					num = (short)550043652;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_111;
				case 2:
					goto IL_111;
				case 3:
					goto IL_1EE;
				case 4:
					goto IL_10C;
				case 5:
					a_2 = new global::AcpUI.AcpFieldInfo(A_0.Parent.ParentRecset.RecsetId, A_0.Parent.FeatureSectionId, A_0.UIName);
					num = (short)1331625985;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					num = (short)2063532033;
					if (num != 0)
					{
					}
					if (text != null)
					{
						num = (short)800784384;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					a_ = new global::AcpUI.TableCellInfo(A_1.Field.Label as string, global::AcpUI.CellPosition.c(A_1));
					num = (short)1739194371;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
				{
					num = (short)1020564741;
					short num3 = num;
					num = (short)988583173;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
					{
						num = (short)1521680384;
						short num4 = num;
						num = (short)1682178048;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_BC;
						}
						continue;
					}
					}
					break;
				}
				}
				IL_BC:
				if (A_0 != null)
				{
					num = (short)1326186501;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				a_2 = null;
				num = (short)1988493314;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_111:
				text = global::AcpUI.MaskedTableCellInfo.a(A_1);
				num = (short)662110214;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_10C:
			IL_1EE:
			return new global::AcpUI.AcpFieldToTableCellPairingInfo(a_2, a_);
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x0600040C RID: 1036 RVA: 0x00045640 File Offset: 0x00043840
		internal global::AcpUI.AcpFieldInfo FieldInfo
		{
			get
			{
				short num = (short)1247870977;
				if (num != 0)
				{
				}
				num = (short)1939406848;
				short num2 = num;
				num = (short)56340901;
				short num3 = num;
				num = (short)1712042405;
				switch (num3 == num)
				{
				}
				num = (short)673710080;
				if (num != 0)
				{
				}
				return this.a;
			}
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x0600040D RID: 1037 RVA: 0x000456F0 File Offset: 0x000438F0
		internal global::AcpUI.TableCellInfo CellInfo
		{
			get
			{
				short num = (short)1669559055;
				short num2 = num;
				num = (short)1287025423;
				switch (num2 == num)
				{
				default:
				{
					num = (short)764411904;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)961740801;
				if (num != 0)
				{
				}
				num = (short)1536032768;
				if (num != 0)
				{
				}
				return this.b;
			}
		}

		// Token: 0x04000250 RID: 592
		private global::AcpUI.AcpFieldInfo a;

		// Token: 0x04000251 RID: 593
		private global::AcpUI.TableCellInfo b;
	}
}
