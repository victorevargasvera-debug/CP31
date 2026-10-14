using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using Motorola.CommonCPS.RadioManagement.CommonBase.Utility;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x02000092 RID: 146
	public class SelectTemplateContext : global::Motorola.CommonCPS.RadioManagement.UIModels.ContextBase
	{
		// Token: 0x0600053B RID: 1339 RVA: 0x0004DBE0 File Offset: 0x0004BDE0
		public SelectTemplateContext()
		{
			this.b = new global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.ObservableCollectionFast<global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase>();
		}

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x0600053C RID: 1340 RVA: 0x0004DC00 File Offset: 0x0004BE00
		// (set) Token: 0x0600053D RID: 1341 RVA: 0x0004DCB0 File Offset: 0x0004BEB0
		public int TotalCount
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1508705312;
				short num2 = num;
				num = (short)927335456;
				switch (num2 == num)
				{
				}
				num = (short)1543176193;
				if (num != 0)
				{
				}
				num = (short)559677440;
				if (num != 0)
				{
				}
				num = (short)556466176;
				short num3 = num;
				return this.d;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1829763281;
				short num2 = num;
				num = (short)975632593;
				switch (num2 == num)
				{
				}
				num = (short)1160511489;
				if (num != 0)
				{
				}
				num = (short)1715404800;
				if (num != 0)
				{
				}
				num = (short)496107520;
				short num3 = num;
				this.d = value;
			}
		}

		// Token: 0x17000259 RID: 601
		// (get) Token: 0x0600053E RID: 1342 RVA: 0x0004DD64 File Offset: 0x0004BF64
		// (set) Token: 0x0600053F RID: 1343 RVA: 0x0004DE14 File Offset: 0x0004C014
		public global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> Radios
		{
			get
			{
				short num = (short)729486211;
				short num2 = num;
				num = (short)1997017987;
				switch (num2 == num)
				{
				}
				num = (short)1402601473;
				if (num != 0)
				{
				}
				num = (short)452067328;
				if (num != 0)
				{
				}
				num = (short)1185742848;
				short num3 = num;
				return this.a;
			}
			set
			{
				short num = (short)323944448;
				short num2 = num;
				num = (short)582811649;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						goto IL_118;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_59;
						}
						continue;
					case 2:
						this.a = value;
						base.RaisePropertyChanged<global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.SelectTemplateContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.SelectTemplateContext.get_Radios())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)661192704;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_59:
					num = (short)1005274096;
					short num4 = num;
					num = (short)421872624;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
						num = (short)1337524224;
						if (num != 0)
						{
						}
						if (value == this.a)
						{
							return;
						}
						num = (short)391512066;
						num3 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				IL_118:
				num = (short)184156161;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x1700025A RID: 602
		// (get) Token: 0x06000540 RID: 1344 RVA: 0x0004DF64 File Offset: 0x0004C164
		// (set) Token: 0x06000541 RID: 1345 RVA: 0x0004E014 File Offset: 0x0004C214
		public global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase> SelectedTemplates
		{
			get
			{
				short num = (short)1667539429;
				short num2 = num;
				num = (short)1236443621;
				switch (num2 == num)
				{
				}
				num = (short)495910913;
				if (num != 0)
				{
				}
				num = (short)1163591680;
				if (num != 0)
				{
				}
				num = (short)1016594432;
				short num3 = num;
				return this.b;
			}
			set
			{
				for (;;)
				{
					IL_00:
					short num = (short)1758330880;
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
							num = (short)1406009344;
							short num3 = num;
							num = (short)203076279;
							short num4 = num;
							num = (short)2054009527;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
								num = (short)412483584;
								if (num != 0)
								{
								}
								this.b = value;
								base.RaisePropertyChanged<global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase>>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase>>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.SelectTemplateContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.SelectTemplateContext.get_SelectedTemplates())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
								num = (short)562429954;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 2:
							return;
						}
						IL_31:
						num = (short)1755906049;
						if (num != 0)
						{
						}
						if (value == this.b)
						{
							return;
						}
						num = (short)1563492353;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
			}
		}

		// Token: 0x1700025B RID: 603
		// (get) Token: 0x06000542 RID: 1346 RVA: 0x0004E164 File Offset: 0x0004C364
		// (set) Token: 0x06000543 RID: 1347 RVA: 0x0004E214 File Offset: 0x0004C414
		public global::System.ComponentModel.ICollectionView Templates
		{
			get
			{
				short num = (short)1412759552;
				short num2 = num;
				num = (short)1020526593;
				if (num != 0)
				{
				}
				num = (short)1712589274;
				short num3 = num;
				num = (short)1709967834;
				switch (num3 == num)
				{
				}
				num = (short)1044185088;
				if (num != 0)
				{
				}
				return this.c;
			}
			set
			{
				for (;;)
				{
					IL_00:
					short num = (short)897908736;
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
							num = (short)760003208;
							short num3 = num;
							num = (short)1216330376;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							case 1:
								break;
							default:
							{
								num = (short)1592655872;
								short num4 = num;
								break;
							}
							}
							num = (short)768344064;
							if (num != 0)
							{
							}
							this.c = value;
							base.RaisePropertyChanged<global::System.ComponentModel.ICollectionView>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::System.ComponentModel.ICollectionView>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.SelectTemplateContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.SelectTemplateContext.get_Templates())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
							num = (short)49086465;
							if (num != 0)
							{
							}
							num = (short)795672578;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							return;
						}
						IL_31:
						if (value == this.c)
						{
							return;
						}
						num = (short)875757569;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
			}
		}

		// Token: 0x04000271 RID: 625
		private global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> a;

		// Token: 0x04000272 RID: 626
		private global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase> b;

		// Token: 0x04000273 RID: 627
		private global::System.ComponentModel.ICollectionView c;

		// Token: 0x04000274 RID: 628
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private int d;
	}
}
