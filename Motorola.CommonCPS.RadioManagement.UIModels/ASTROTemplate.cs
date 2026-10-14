using System;
using System.Linq.Expressions;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x020000F2 RID: 242
	public class ASTROTemplate : global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase
	{
		// Token: 0x06000BC6 RID: 3014 RVA: 0x000B11B8 File Offset: 0x000AF3B8
		public ASTROTemplate() : base(new global::Motorola.CommonCPS.Server.EntityModel.APXTemplateSummary())
		{
			this.a();
		}

		// Token: 0x06000BC7 RID: 3015 RVA: 0x000B11D8 File Offset: 0x000AF3D8
		public ASTROTemplate(global::Motorola.CommonCPS.Server.EntityModel.APXTemplateSummary summary) : base(summary)
		{
			this.a();
		}

		// Token: 0x17000572 RID: 1394
		// (get) Token: 0x06000BC8 RID: 3016 RVA: 0x000B11F4 File Offset: 0x000AF3F4
		// (set) Token: 0x06000BC9 RID: 3017 RVA: 0x000B12A8 File Offset: 0x000AF4A8
		public int? CPLanguageIndex
		{
			get
			{
				short num = (short)1354003643;
				short num2 = num;
				num = (short)273511611;
				switch (num2 == num)
				{
				}
				num = (short)2147287041;
				if (num != 0)
				{
				}
				num = (short)1879375872;
				if (num != 0)
				{
				}
				num = (short)1820262400;
				short num3 = num;
				return this.ApxTemplateSummary.LanguageIndex;
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
				int? num3;
				int? languageIndex;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						num2 = (short)1680867329;
						if (num2 != 0)
						{
						}
						goto IL_129;
					case 1:
						this.ApxTemplateSummary.LanguageIndex = value;
						base.RaisePropertyChanged<int?>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<int?>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROTemplate)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROTemplate.get_CPLanguageIndex())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num2 = (short)1131413504;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 2:
						if (!(num3.GetValueOrDefault() == languageIndex.GetValueOrDefault() & num3 != null == (languageIndex != null)))
						{
							num2 = (short)1181745153;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_129;
					}
					goto IL_1C;
					IL_129:
					num2 = (short)1483898528;
					short num4 = num2;
					num2 = (short)2055241376;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_15F;
					}
				}
				IL_15F:
				num2 = (short)720699392;
				if (num2 != 0)
				{
				}
				return;
				IL_1C:
				num2 = (short)665649152;
				short num5 = num2;
				num3 = value;
				languageIndex = this.ApxTemplateSummary.LanguageIndex;
				num2 = (short)1059586050;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x17000573 RID: 1395
		// (get) Token: 0x06000BCA RID: 3018 RVA: 0x000B142C File Offset: 0x000AF62C
		// (set) Token: 0x06000BCB RID: 3019 RVA: 0x000B14E0 File Offset: 0x000AF6E0
		public global::System.Guid? LauguagePackUuid
		{
			get
			{
				short num = (short)1249509377;
				if (num != 0)
				{
				}
				num = (short)1403643103;
				short num2 = num;
				num = (short)1534059743;
				switch (num2 == num)
				{
				}
				num = (short)598081536;
				if (num != 0)
				{
				}
				num = (short)15597568;
				short num3 = num;
				return this.ApxTemplateSummary.LanguagePackUuid;
			}
			set
			{
				short num = (short)1712019224;
				short num2 = num;
				num = (short)481318680;
				global::System.Guid? guid;
				int num3;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_215:
					if (guid == null)
					{
						num = (short)1553858560;
						num3 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)510590983;
						num3 = (int)((global::System.IntPtr)num);
					}
					break;
				default:
					num = (short)993198080;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_A6;
					}
					break;
				}
				global::System.Guid? languagePackUuid;
				for (;;)
				{
					IL_54:
					num = (short)1298202624;
					short num4 = num;
					bool flag;
					switch (num3)
					{
					case 0:
						num = (short)606273538;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (guid != null != (languagePackUuid != null))
						{
							num = (short)1844969480;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1515061254;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						num = (short)1905655809;
						if (num != 0)
						{
						}
						flag = false;
						goto IL_1B0;
					case 3:
						this.ApxTemplateSummary.LanguagePackUuid = value;
						base.RaisePropertyChanged<global::System.Guid?>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::System.Guid?>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROTemplate)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROTemplate.get_LauguagePackUuid())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1494220805;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						flag = true;
						goto IL_1B0;
					case 5:
						return;
					case 6:
						goto IL_215;
					case 7:
						flag = (guid.GetValueOrDefault() != languagePackUuid.GetValueOrDefault());
						goto IL_1B0;
					case 8:
						num = (short)781844484;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_A6;
					IL_1B0:
					if (!flag)
					{
						break;
					}
					num = (short)554303491;
					num3 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_A6:
				guid = value;
				languagePackUuid = this.ApxTemplateSummary.LanguagePackUuid;
				num = (short)1784152065;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_54;
			}
		}

		// Token: 0x17000574 RID: 1396
		// (get) Token: 0x06000BCC RID: 3020 RVA: 0x000B172C File Offset: 0x000AF92C
		private global::Motorola.CommonCPS.Server.EntityModel.APXTemplateSummary ApxTemplateSummary
		{
			get
			{
				short num = (short)1694524797;
				short num2 = num;
				num = (short)801400189;
				switch (num2 == num)
				{
				}
				num = (short)242155521;
				if (num != 0)
				{
				}
				num = (short)189267968;
				if (num != 0)
				{
				}
				num = (short)1346109440;
				short num3 = num;
				return base.SummaryEntity as global::Motorola.CommonCPS.Server.EntityModel.APXTemplateSummary;
			}
		}

		// Token: 0x06000BCD RID: 3021 RVA: 0x000B17E0 File Offset: 0x000AF9E0
		private void a()
		{
			short num = (short)448263200;
			short num2 = num;
			num = (short)1764881440;
			switch (num2 == num)
			{
			}
			num = (short)333840385;
			if (num != 0)
			{
			}
			num = (short)834666496;
			if (num != 0)
			{
			}
			num = (short)1974796288;
			short num3 = num;
		}
	}
}
