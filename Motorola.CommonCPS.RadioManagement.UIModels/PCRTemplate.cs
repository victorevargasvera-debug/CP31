using System;
using System.Collections.ObjectModel;
using System.Linq.Expressions;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x020000F5 RID: 245
	public class PCRTemplate : global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase
	{
		// Token: 0x06000C0A RID: 3082 RVA: 0x000B5320 File Offset: 0x000B3520
		public PCRTemplate() : base(new global::Motorola.CommonCPS.Server.EntityModel.MatrixTemplateSummary())
		{
			this.a();
		}

		// Token: 0x06000C0B RID: 3083 RVA: 0x000B5340 File Offset: 0x000B3540
		public PCRTemplate(global::Motorola.CommonCPS.Server.EntityModel.MatrixTemplateSummary templateSummary) : base(templateSummary)
		{
			this.a();
		}

		// Token: 0x17000594 RID: 1428
		// (get) Token: 0x06000C0C RID: 3084 RVA: 0x000B535C File Offset: 0x000B355C
		// (set) Token: 0x06000C0D RID: 3085 RVA: 0x000B5410 File Offset: 0x000B3610
		public string TanapaNumber
		{
			get
			{
				short num = (short)1228360471;
				short num2 = num;
				num = (short)808274711;
				switch (num2 == num)
				{
				}
				num = (short)1639645185;
				if (num != 0)
				{
				}
				num = (short)663683072;
				if (num != 0)
				{
				}
				num = (short)1498742784;
				short num3 = num;
				return this.MatrixTemplateSummary.TanapaNo;
			}
			set
			{
				short num = (short)820314112;
				short num2 = num;
				if (!(value == this.MatrixTemplateSummary.TanapaNo))
				{
					num = (short)292398960;
					short num3 = num;
					num = (short)107128688;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1086980097;
						if (num != 0)
						{
						}
						num = (short)739049472;
						if (num != 0)
						{
						}
						this.MatrixTemplateSummary.TanapaNo = value;
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.PCRTemplate)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.PCRTemplate.get_TanapaNumber())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						return;
					}
				}
			}
		}

		// Token: 0x17000595 RID: 1429
		// (get) Token: 0x06000C0E RID: 3086 RVA: 0x000B5510 File Offset: 0x000B3710
		// (set) Token: 0x06000C0F RID: 3087 RVA: 0x000B55CC File Offset: 0x000B37CC
		public global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName RegionName
		{
			get
			{
				short num = (short)446624008;
				short num2 = num;
				num = (short)26407176;
				switch (num2 == num)
				{
				}
				num = (short)1224015873;
				if (num != 0)
				{
				}
				num = (short)602537984;
				if (num != 0)
				{
				}
				num = (short)1360986112;
				short num3 = num;
				return this.MatrixTemplateSummary.RegionName.Value;
			}
			set
			{
				short num = (short)596574209;
				if (num != 0)
				{
				}
				num = (short)470161718;
				short num2 = num;
				num = (short)2034047286;
				switch (num2 == num)
				{
				}
				num = (short)509804544;
				if (num != 0)
				{
				}
				num = (short)2070413312;
				short num3 = num;
				this.MatrixTemplateSummary.RegionName = new global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName?(value);
				base.RaisePropertyChanged<global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.PCRTemplate)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.PCRTemplate.get_RegionName())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
			}
		}

		// Token: 0x17000596 RID: 1430
		// (get) Token: 0x06000C10 RID: 3088 RVA: 0x000B56B8 File Offset: 0x000B38B8
		// (set) Token: 0x06000C11 RID: 3089 RVA: 0x000B5778 File Offset: 0x000B3978
		public global::Motorola.CommonCPS.Server.CommonDBConstants.LanguagePackFamily LanguageProductFamily
		{
			get
			{
				short num = (short)1762712106;
				short num2 = num;
				num = (short)1702746666;
				switch (num2 == num)
				{
				}
				num = (short)1729757185;
				if (num != 0)
				{
				}
				num = (short)1772945408;
				if (num != 0)
				{
				}
				num = (short)546701312;
				short num3 = num;
				return (global::Motorola.CommonCPS.Server.CommonDBConstants.LanguagePackFamily)this.MatrixTemplateSummary.LanguagePackFamily.Value;
			}
			set
			{
				short num = (short)1900052867;
				short num2 = num;
				num = (short)140607875;
				switch (num2 == num)
				{
				}
				num = (short)2104033281;
				if (num != 0)
				{
				}
				num = (short)2121793536;
				if (num != 0)
				{
				}
				num = (short)1471807488;
				short num3 = num;
				this.MatrixTemplateSummary.LanguagePackFamily = new int?((int)value);
			}
		}

		// Token: 0x17000597 RID: 1431
		// (get) Token: 0x06000C12 RID: 3090 RVA: 0x000B5834 File Offset: 0x000B3A34
		// (set) Token: 0x06000C13 RID: 3091 RVA: 0x000B58E0 File Offset: 0x000B3AE0
		public global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.LanguageDetailInfo> LanguagePacks
		{
			get
			{
				short num = (short)647168001;
				if (num != 0)
				{
				}
				num = (short)1413552505;
				short num2 = num;
				num = (short)1445140857;
				switch (num2 == num)
				{
				}
				num = (short)307298304;
				if (num != 0)
				{
				}
				num = (short)1187446784;
				short num3 = num;
				return this.a;
			}
			set
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				short num2;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						goto IL_CD;
					case 1:
						base.RaisePropertyChanged<global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.LanguageDetailInfo>>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.LanguageDetailInfo>>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.PCRTemplate)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.PCRTemplate.get_LanguagePacks())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num2 = (short)1439105024;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 2:
						if (!base.IsLoading)
						{
							num2 = (short)541655041;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_CD;
					}
					goto IL_1C;
					IL_CD:
					num2 = (short)68961331;
					short num3 = num2;
					num2 = (short)2030191667;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_103;
					}
				}
				IL_103:
				num2 = (short)1926561792;
				if (num2 != 0)
				{
				}
				num2 = (short)1012203521;
				if (num2 != 0)
				{
				}
				return;
				IL_1C:
				num2 = (short)145162240;
				short num4 = num2;
				this.a = value;
				num2 = (short)1587281922;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x17000598 RID: 1432
		// (get) Token: 0x06000C14 RID: 3092 RVA: 0x000B5A30 File Offset: 0x000B3C30
		// (set) Token: 0x06000C15 RID: 3093 RVA: 0x000B5B08 File Offset: 0x000B3D08
		public global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily ProductFamily
		{
			get
			{
				short num = (short)1363345408;
				short num2 = num;
				if (this.MatrixTemplateSummary.ProductFamily != null)
				{
					num = (short)1344172486;
					short num3 = num;
					num = (short)109212102;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1102970880;
						if (num != 0)
						{
						}
						return (global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily)this.MatrixTemplateSummary.ProductFamily.Value;
					}
				}
				num = (short)1917059073;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.None;
			}
			set
			{
				short num = (short)125998315;
				short num2 = num;
				num = (short)312841451;
				switch (num2 == num)
				{
				}
				num = (short)837156864;
				if (num != 0)
				{
				}
				num = (short)384172033;
				if (num != 0)
				{
				}
				num = (short)581763072;
				short num3 = num;
				this.MatrixTemplateSummary.ProductFamily = new int?((int)value);
			}
		}

		// Token: 0x17000599 RID: 1433
		// (get) Token: 0x06000C16 RID: 3094 RVA: 0x000B5BC4 File Offset: 0x000B3DC4
		// (set) Token: 0x06000C17 RID: 3095 RVA: 0x000B5C78 File Offset: 0x000B3E78
		public string CFS
		{
			get
			{
				short num = (short)910143026;
				short num2 = num;
				num = (short)111914546;
				switch (num2 == num)
				{
				}
				num = (short)1403518977;
				if (num != 0)
				{
				}
				num = (short)1877540864;
				if (num != 0)
				{
				}
				num = (short)150142976;
				short num3 = num;
				return this.MatrixTemplateSummary.CFS;
			}
			set
			{
				short num = (short)262602752;
				short num2 = num;
				if (!(value == this.MatrixTemplateSummary.CFS))
				{
					num = (short)158324458;
					short num3 = num;
					num = (short)186373866;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1551499264;
						if (num != 0)
						{
						}
						this.MatrixTemplateSummary.CFS = value;
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.PCRTemplate)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.PCRTemplate.get_CFS())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						return;
					}
				}
				num = (short)1818755073;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x1700059A RID: 1434
		// (get) Token: 0x06000C18 RID: 3096 RVA: 0x000B5D78 File Offset: 0x000B3F78
		private global::Motorola.CommonCPS.Server.EntityModel.MatrixTemplateSummary MatrixTemplateSummary
		{
			get
			{
				short num = (short)1697403812;
				short num2 = num;
				num = (short)1871336356;
				switch (num2 == num)
				{
				}
				num = (short)311754753;
				if (num != 0)
				{
				}
				num = (short)1166737408;
				if (num != 0)
				{
				}
				num = (short)1201143808;
				short num3 = num;
				return base.SummaryEntity as global::Motorola.CommonCPS.Server.EntityModel.MatrixTemplateSummary;
			}
		}

		// Token: 0x06000C19 RID: 3097 RVA: 0x000B5E2C File Offset: 0x000B402C
		private void a()
		{
			short num = (short)1073074557;
			short num2 = num;
			num = (short)2145898877;
			switch (num2 == num)
			{
			}
			num = (short)1565655040;
			if (num != 0)
			{
			}
			num = (short)1871642625;
			if (num != 0)
			{
			}
			num = (short)330760192;
			short num3 = num;
		}

		// Token: 0x04000440 RID: 1088
		private global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.LanguageDetailInfo> a;
	}
}
