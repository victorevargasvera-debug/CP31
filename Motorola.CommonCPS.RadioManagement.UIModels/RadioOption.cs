using System;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x020000B7 RID: 183
	public class RadioOption : global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase, global::Motorola.CommonCPS.RadioManagement.UIModels.ICopyable
	{
		// Token: 0x17000341 RID: 833
		// (get) Token: 0x06000701 RID: 1793 RVA: 0x00065DC0 File Offset: 0x00063FC0
		// (set) Token: 0x06000702 RID: 1794 RVA: 0x00065E70 File Offset: 0x00064070
		public override global::System.Guid? ID
		{
			get
			{
				short num = (short)1577460082;
				short num2 = num;
				num = (short)1318134130;
				switch (num2 == num)
				{
				}
				num = (short)521404417;
				if (num != 0)
				{
				}
				num = (short)1707212800;
				short num3 = num;
				num = (short)1654390784;
				if (num != 0)
				{
				}
				return this.c;
			}
			set
			{
				short num = (short)1471838863;
				short num2 = num;
				num = (short)1944353423;
				switch (num2 == num)
				{
				}
				num = (short)1078591488;
				if (num != 0)
				{
				}
				num = (short)881786880;
				short num3 = num;
				num = (short)1760296961;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x17000342 RID: 834
		// (get) Token: 0x06000703 RID: 1795 RVA: 0x00065F20 File Offset: 0x00064120
		// (set) Token: 0x06000704 RID: 1796 RVA: 0x00065FD0 File Offset: 0x000641D0
		public string SerialNumber
		{
			get
			{
				short num = (short)938213377;
				if (num != 0)
				{
				}
				num = (short)1461402105;
				short num2 = num;
				num = (short)1224489465;
				switch (num2 == num)
				{
				}
				num = (short)1569062912;
				short num3 = num;
				num = (short)483917824;
				if (num != 0)
				{
				}
				return this.a;
			}
			set
			{
				short num = (short)1203044352;
				short num2 = num;
				num = (short)976771160;
				short num3 = num;
				num = (short)2055690328;
				int num4;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_132:
					num = (short)1848049666;
					num4 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)97779712;
					if (num != 0)
					{
					}
					num = (short)1749221377;
					if (num != 0)
					{
					}
					num = (short)124256260;
					num4 = (int)((global::System.IntPtr)num);
					break;
				}
				for (;;)
				{
					switch (num4)
					{
					case 0:
						if (!base.IsLoading)
						{
							num = (short)735772673;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 1:
						goto IL_18B;
					case 2:
						goto IL_14B;
					case 3:
						this.a = value;
						num = (short)2112094208;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						switch (0)
						{
						case 0:
							goto IL_D7;
						}
						continue;
					}
					IL_D7:
					if (!(value != this.a))
					{
						break;
					}
					num = (short)255787011;
					num4 = (int)((global::System.IntPtr)num);
				}
				IL_14B:
				return;
				IL_18B:
				base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioOption)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioOption.get_SerialNumber())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
				goto IL_132;
			}
		}

		// Token: 0x17000343 RID: 835
		// (get) Token: 0x06000705 RID: 1797 RVA: 0x00066170 File Offset: 0x00064370
		// (set) Token: 0x06000706 RID: 1798 RVA: 0x0006621C File Offset: 0x0006441C
		public bool Option
		{
			get
			{
				short num = (short)694271486;
				short num2 = num;
				num = (short)780713470;
				switch (num2 == num)
				{
				}
				num = (short)67960833;
				if (num != 0)
				{
				}
				num = (short)1417609216;
				short num3 = num;
				num = (short)1729298432;
				if (num != 0)
				{
				}
				return this.b;
			}
			set
			{
				short num = (short)1129381888;
				short num2 = num;
				num = (short)1292351062;
				short num3 = num;
				num = (short)1926739542;
				int num4;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_12F:
					num = (short)2064515074;
					num4 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)442695681;
					if (num != 0)
					{
					}
					num = (short)2138308608;
					if (num != 0)
					{
					}
					num = (short)357826564;
					num4 = (int)((global::System.IntPtr)num);
					break;
				}
				for (;;)
				{
					switch (num4)
					{
					case 0:
						if (!base.IsLoading)
						{
							num = (short)67764225;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 1:
						goto IL_18A;
					case 2:
						goto IL_147;
					case 3:
						this.b = value;
						num = (short)1220739072;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						switch (0)
						{
						case 0:
							goto IL_D8;
						}
						continue;
					}
					IL_D8:
					if (value == this.b)
					{
						break;
					}
					num = (short)1130233859;
					num4 = (int)((global::System.IntPtr)num);
				}
				IL_147:
				return;
				IL_18A:
				base.RaisePropertyChanged<bool>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioOption)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioOption.get_Option())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
				goto IL_12F;
			}
		}

		// Token: 0x17000344 RID: 836
		// (get) Token: 0x06000707 RID: 1799 RVA: 0x000663B8 File Offset: 0x000645B8
		// (set) Token: 0x06000708 RID: 1800 RVA: 0x0006646C File Offset: 0x0006466C
		public global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase InnerRadio
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)904003585;
				if (num != 0)
				{
				}
				num = (short)872008119;
				short num2 = num;
				num = (short)14272951;
				switch (num2 == num)
				{
				}
				num = (short)1752760320;
				short num3 = num;
				num = (short)797638656;
				if (num != 0)
				{
				}
				return this.d;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)130219101;
				short num2 = num;
				num = (short)991689821;
				switch (num2 == num)
				{
				}
				num = (short)51773441;
				if (num != 0)
				{
				}
				num = (short)337838080;
				short num3 = num;
				num = (short)2017525760;
				if (num != 0)
				{
				}
				this.d = value;
			}
		}

		// Token: 0x06000709 RID: 1801 RVA: 0x00066520 File Offset: 0x00064720
		public void CopyFrom(global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase source)
		{
			short num = (short)846331905;
			if (num != 0)
			{
			}
			num = (short)1607952914;
			short num2 = num;
			num = (short)2001431058;
			switch (num2 == num)
			{
			}
			num = (short)1997012992;
			short num3 = num;
			num = (short)1842479104;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.UIModels.RadioOption radioOption = (global::Motorola.CommonCPS.RadioManagement.UIModels.RadioOption)source;
			this.SerialNumber = radioOption.SerialNumber;
			this.Option = radioOption.Option;
			this.InnerRadio = radioOption.InnerRadio;
		}

		// Token: 0x040002EC RID: 748
		private string a;

		// Token: 0x040002ED RID: 749
		private bool b;

		// Token: 0x040002EE RID: 750
		private global::System.Guid? c = new global::System.Guid?(global::System.Guid.NewGuid());

		// Token: 0x040002EF RID: 751
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase d;
	}
}
