using System;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x02000093 RID: 147
	public class TestDlgContext : global::Motorola.CommonCPS.RadioManagement.UIModels.ContextBase
	{
		// Token: 0x06000544 RID: 1348 RVA: 0x0004E364 File Offset: 0x0004C564
		public TestDlgContext()
		{
			this.a = new global::Motorola.CommonCPS.RadioManagement.UIModels.Connection();
		}

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x06000545 RID: 1349 RVA: 0x0004E384 File Offset: 0x0004C584
		// (set) Token: 0x06000546 RID: 1350 RVA: 0x0004E434 File Offset: 0x0004C634
		public global::Motorola.CommonCPS.RadioManagement.UIModels.Connection Connection
		{
			get
			{
				short num = (short)1835270144;
				short num2 = num;
				num = (short)1733652795;
				short num3 = num;
				num = (short)1913942331;
				switch (num3 == num)
				{
				}
				num = (short)52559872;
				if (num != 0)
				{
				}
				num = (short)1390280705;
				if (num != 0)
				{
				}
				return this.a;
			}
			set
			{
				for (;;)
				{
					IL_00:
					short num = (short)1822687232;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_31;
							}
							continue;
						case 1:
						{
							num = (short)1254817793;
							if (num != 0)
							{
							}
							num = (short)33816576;
							short num3 = num;
							num = (short)543526178;
							short num4 = num;
							num = (short)937397538;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
								num = (short)894631936;
								if (num != 0)
								{
								}
								this.a = value;
								base.RaisePropertyChanged<global::Motorola.CommonCPS.RadioManagement.UIModels.Connection>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.Connection>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.TestDlgContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.TestDlgContext.get_Connection())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
								num = (short)1304363010;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 2:
							return;
						}
						IL_31:
						if (value == this.a)
						{
							return;
						}
						num = (short)442695681;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
			}
		}

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x06000547 RID: 1351 RVA: 0x0004E584 File Offset: 0x0004C784
		// (set) Token: 0x06000548 RID: 1352 RVA: 0x0004E634 File Offset: 0x0004C834
		public bool IsSaved
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)18677760;
				short num2 = num;
				num = (short)1117148552;
				short num3 = num;
				num = (short)1441289608;
				switch (num3 == num)
				{
				}
				num = (short)1686372353;
				if (num != 0)
				{
				}
				num = (short)1633222656;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)304939008;
				short num2 = num;
				num = (short)1660891915;
				short num3 = num;
				num = (short)370160395;
				switch (num3 == num)
				{
				}
				num = (short)809959424;
				if (num != 0)
				{
				}
				num = (short)2135359489;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x04000275 RID: 629
		private global::Motorola.CommonCPS.RadioManagement.UIModels.Connection a;

		// Token: 0x04000276 RID: 630
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool b;
	}
}
