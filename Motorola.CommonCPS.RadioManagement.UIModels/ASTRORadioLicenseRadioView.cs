using System;
using System.Linq.Expressions;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x020000B4 RID: 180
	public class ASTRORadioLicenseRadioView : global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseRadioViewBase
	{
		// Token: 0x1700032F RID: 815
		// (get) Token: 0x060006D8 RID: 1752 RVA: 0x00063034 File Offset: 0x00061234
		// (set) Token: 0x060006D9 RID: 1753 RVA: 0x000630E0 File Offset: 0x000612E0
		public string FlashCode
		{
			get
			{
				short num = (short)1139867648;
				short num2 = num;
				num = (short)881760170;
				short num3 = num;
				num = (short)1863817130;
				switch (num3 == num)
				{
				}
				num = (short)840433665;
				if (num != 0)
				{
				}
				num = (short)490602496;
				if (num != 0)
				{
				}
				return this.a;
			}
			set
			{
				short num = (short)661913601;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						if (value == this.a)
						{
							num = (short)1959985159;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.a = value;
						num = (short)480903174;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_45;
						}
						continue;
					case 2:
					{
						num = (short)28965793;
						short num3 = num;
						num = (short)546569121;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)460980224;
							if (num != 0)
							{
							}
							num = (short)1643315201;
							if (num != 0)
							{
							}
							num = (short)203030528;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 3:
						if (!base.IsLoading)
						{
							num = (short)1417019392;
							short num4 = num;
							num = (short)261357573;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 4:
						return;
					case 5:
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadioLicenseRadioView)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadioLicenseRadioView.get_FlashCode())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)841416708;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						goto IL_61;
					case 7:
						return;
					}
					IL_45:
					if (value != null)
					{
						num = (short)300154882;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_61:
					this.a = value;
					num = (short)1418461187;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x040002DB RID: 731
		private string a;
	}
}
