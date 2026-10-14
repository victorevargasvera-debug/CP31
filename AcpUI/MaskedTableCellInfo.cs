using System;
using System.Windows;
using Infragistics.Windows.DataPresenter;

namespace AcpUI
{
	// Token: 0x02000049 RID: 73
	internal class MaskedTableCellInfo : global::AcpUI.TableCellInfo
	{
		// Token: 0x06000407 RID: 1031 RVA: 0x0004519C File Offset: 0x0004339C
		internal MaskedTableCellInfo(string A_0, int A_1, string A_2) : base(A_0, A_1)
		{
			this.a = A_2;
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x06000408 RID: 1032 RVA: 0x000451B8 File Offset: 0x000433B8
		internal string Mask
		{
			get
			{
				short num = (short)971635322;
				short num2 = num;
				num = (short)844757626;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1398341632;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1351483393;
				if (num != 0)
				{
				}
				num = (short)1073152000;
				if (num != 0)
				{
				}
				return this.a;
			}
		}

		// Token: 0x06000409 RID: 1033 RVA: 0x00045268 File Offset: 0x00043468
		internal new static string a(global::Infragistics.Windows.DataPresenter.Cell A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_52;
			}
			short num;
			int num3;
			global::AcpUI.ISupportsTextBoxMember supportsTextBoxMember;
			global::System.Windows.UIElement uielement;
			for (;;)
			{
				IL_0A:
				num = (short)1443168256;
				short num2 = num;
				switch (num3)
				{
				case 0:
					num = (short)967245828;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					if (supportsTextBoxMember != null)
					{
						num = (short)1581187072;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_137;
				case 2:
					goto IL_F7;
				case 3:
					num = (short)47513601;
					if (num != 0)
					{
					}
					supportsTextBoxMember = (uielement as global::AcpUI.ISupportsTextBoxMember);
					num = (short)1432616961;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					if (supportsTextBoxMember.TextBoxMember.IsMasked)
					{
						num = (short)1422196738;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_137;
				case 5:
					if (uielement != null)
					{
						num = (short)1835794435;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_137;
				}
				goto IL_52;
				IL_137:
				num = (short)398742192;
				short num4 = num;
				num = (short)1330795184;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_16B;
				}
			}
			IL_F7:
			return supportsTextBoxMember.TextBoxMember.MaskType;
			IL_16B:
			num = (short)324730880;
			if (num != 0)
			{
			}
			return null;
			IL_52:
			uielement = global::AcpUI.TableCellInfo.a(A_0);
			num = (short)17891333;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x0400024F RID: 591
		private new string a;
	}
}
