using System;
using Microsoft.Practices.Prism.Commands;

namespace Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies
{
	// Token: 0x0200004E RID: 78
	internal abstract class c<a> where a : global::Microsoft.Practices.Prism.Commands.DelegateCommandBase
	{
		// Token: 0x0600020E RID: 526
		public abstract a a();

		// Token: 0x0600020F RID: 527 RVA: 0x0001FB14 File Offset: 0x0001DD14
		private a d()
		{
			short num = (short)898957313;
			if (num != 0)
			{
			}
			num = (short)1498842655;
			short num2 = num;
			num = (short)1263371807;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1689714688;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1769406464;
			if (num != 0)
			{
			}
			return this.b;
		}

		// Token: 0x06000210 RID: 528 RVA: 0x0001FBC8 File Offset: 0x0001DDC8
		public void e(a A_0)
		{
			short num = (short)543581234;
			short num2 = num;
			num = (short)976512050;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_110:
				this.b = A_0;
				num = (short)206307330;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)1614020608;
				if (num != 0)
				{
				}
				num = (short)1787035649;
				num3 = (int)((global::System.IntPtr)num);
				break;
			}
			for (;;)
			{
				switch (num3)
				{
				case 0:
					goto IL_10B;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_88;
					}
					continue;
				case 2:
				{
					num = (short)846135296;
					short num4 = num;
					if (A_0 != null)
					{
						num = (short)781778947;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1B5;
				}
				case 3:
					this.b.CanExecuteChanged += this.a;
					num = (short)2092367873;
					if (num != 0)
					{
					}
					num = (short)1557004288;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					this.b.CanExecuteChanged -= this.a;
					num = (short)173670405;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					goto IL_1B0;
				}
				IL_88:
				if (this.b == null)
				{
					goto IL_110;
				}
				num = (short)1182859268;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_10B:
			goto IL_1B5;
			IL_1B0:
			goto IL_110;
			IL_1B5:
			this.a().RaiseCanExecuteChanged();
		}

		// Token: 0x06000211 RID: 529 RVA: 0x0001FD9C File Offset: 0x0001DF9C
		private void a(object A_0, global::System.EventArgs A_1)
		{
			short num = (short)1219756033;
			if (num != 0)
			{
			}
			num = (short)1013980970;
			short num2 = num;
			num = (short)1233788714;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1860042752;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1444020224;
			if (num != 0)
			{
			}
			this.a().RaiseCanExecuteChanged();
		}

		// Token: 0x06000212 RID: 530 RVA: 0x0001FE58 File Offset: 0x0001E058
		protected virtual void d(object A_0, global::System.EventArgs A_1)
		{
			short num = (short)878170515;
			short num2 = num;
			num = (short)2134167955;
			switch (num2 == num)
			{
			}
			num = (short)1133314048;
			short num3 = num;
			num = (short)1325858817;
			if (num != 0)
			{
			}
			num = (short)1132003328;
			if (num != 0)
			{
			}
			a a = this.d();
			if (a == null)
			{
				return;
			}
			a.RaiseCanExecuteChanged();
		}

		// Token: 0x06000213 RID: 531 RVA: 0x0001FF18 File Offset: 0x0001E118
		public bool a(object A_0)
		{
			while (this.d() != null)
			{
				short num = (short)728385899;
				short num2 = num;
				num = (short)1469335915;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					continue;
				case 1:
					break;
				default:
				{
					num = (short)1321926656;
					short num3 = num;
					break;
				}
				}
				num = (short)1182203905;
				if (num != 0)
				{
				}
				num = (short)943456256;
				if (num != 0)
				{
				}
				return this.d().CanExecute(A_0);
			}
			return false;
		}

		// Token: 0x06000214 RID: 532 RVA: 0x0001FFE8 File Offset: 0x0001E1E8
		public void d(object A_0)
		{
			short num = (short)538899576;
			short num2 = num;
			num = (short)1844442232;
			switch (num2 == num)
			{
			}
			num = (short)91947008;
			short num3 = num;
			num = (short)625344513;
			if (num != 0)
			{
			}
			num = (short)317456384;
			if (num != 0)
			{
			}
			a a = this.d();
			if (a == null)
			{
				return;
			}
			a.Execute(A_0);
		}

		// Token: 0x06000215 RID: 533 RVA: 0x000200A8 File Offset: 0x0001E2A8
		public static a a(global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.c<a> A_0)
		{
			short num = (short)1668575306;
			short num2 = num;
			num = (short)1610510410;
			switch (num2 == num)
			{
			}
			num = (short)1557987328;
			short num3 = num;
			num = (short)1207500801;
			if (num != 0)
			{
			}
			num = (short)1335164928;
			if (num != 0)
			{
			}
			return A_0.a();
		}

		// Token: 0x040000E1 RID: 225
		private a b;
	}
}
