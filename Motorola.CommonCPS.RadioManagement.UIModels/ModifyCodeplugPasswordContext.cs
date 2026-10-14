using System;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x02000035 RID: 53
	public class ModifyCodeplugPasswordContext : global::Motorola.CommonCPS.RadioManagement.UIModels.ContextBase
	{
		// Token: 0x17000075 RID: 117
		// (get) Token: 0x06000125 RID: 293 RVA: 0x00011CB0 File Offset: 0x0000FEB0
		// (set) Token: 0x06000126 RID: 294 RVA: 0x00011D60 File Offset: 0x0000FF60
		public global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase Radio
		{
			get
			{
				short num = (short)21858700;
				short num2 = num;
				num = (short)1743030668;
				switch (num2 == num)
				{
				}
				num = (short)1370423297;
				if (num != 0)
				{
				}
				num = (short)1699872768;
				if (num != 0)
				{
				}
				num = (short)585236480;
				short num3 = num;
				return this.a;
			}
			set
			{
				short num = (short)397191447;
				short num2 = num;
				num = (short)1136961815;
				switch (num2 == num)
				{
				}
				num = (short)737214465;
				if (num != 0)
				{
				}
				num = (short)1732378624;
				if (num != 0)
				{
				}
				num = (short)1042481152;
				short num3 = num;
				this.a = value;
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x06000127 RID: 295 RVA: 0x00011E10 File Offset: 0x00010010
		// (set) Token: 0x06000128 RID: 296 RVA: 0x00011EC0 File Offset: 0x000100C0
		public bool ContextIsChanged
		{
			get
			{
				short num = (short)245582321;
				short num2 = num;
				num = (short)364988913;
				switch (num2 == num)
				{
				}
				num = (short)1865482240;
				if (num != 0)
				{
				}
				num = (short)2126839809;
				if (num != 0)
				{
				}
				num = (short)1611857920;
				short num3 = num;
				return this.e;
			}
			set
			{
				short num = (short)1644167169;
				if (num != 0)
				{
				}
				num = (short)2135563615;
				short num2 = num;
				num = (short)1961565535;
				switch (num2 == num)
				{
				}
				num = (short)294977536;
				if (num != 0)
				{
				}
				num = (short)2076835840;
				short num3 = num;
				this.e = value;
				base.RaisePropertyChanged<bool>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ModifyCodeplugPasswordContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ModifyCodeplugPasswordContext.get_ContextIsChanged())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x06000129 RID: 297 RVA: 0x00011FA8 File Offset: 0x000101A8
		public global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName? Region
		{
			get
			{
				short num = (short)2105100365;
				short num2 = num;
				num = (short)511002701;
				switch (num2 == num)
				{
				}
				num = (short)1685389313;
				if (num != 0)
				{
				}
				num = (short)1619984384;
				if (num != 0)
				{
				}
				num = (short)414842880;
				short num3 = num;
				return null;
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x0600012A RID: 298 RVA: 0x00012058 File Offset: 0x00010258
		// (set) Token: 0x0600012B RID: 299 RVA: 0x00012104 File Offset: 0x00010304
		public string RadioPassword
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)720918920;
				short num2 = num;
				num = (short)1065245064;
				switch (num2 == num)
				{
				}
				num = (short)1882980352;
				if (num != 0)
				{
				}
				num = (short)2103246849;
				if (num != 0)
				{
				}
				num = (short)289406976;
				short num3 = num;
				return this.f;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)26387986;
				short num2 = num;
				num = (short)1384490514;
				switch (num2 == num)
				{
				}
				num = (short)661454849;
				if (num != 0)
				{
				}
				num = (short)725155840;
				if (num != 0)
				{
				}
				num = (short)798490624;
				short num3 = num;
				this.f = value;
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x0600012C RID: 300 RVA: 0x000121B8 File Offset: 0x000103B8
		// (set) Token: 0x0600012D RID: 301 RVA: 0x00012264 File Offset: 0x00010464
		public string OldPasswordForValidate
		{
			get
			{
				short num = (short)1931149313;
				if (num != 0)
				{
				}
				num = (short)1429336583;
				short num2 = num;
				num = (short)809628167;
				switch (num2 == num)
				{
				}
				num = (short)115212288;
				if (num != 0)
				{
				}
				num = (short)436011008;
				short num3 = num;
				return this.b;
			}
			set
			{
				short num = (short)1295768462;
				short num2 = num;
				num = (short)344251278;
				switch (num2 == num)
				{
				}
				num = (short)798031873;
				if (num != 0)
				{
				}
				num = (short)1048444928;
				if (num != 0)
				{
				}
				num = (short)1970470912;
				short num3 = num;
				this.b = value;
				base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ModifyCodeplugPasswordContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ModifyCodeplugPasswordContext.get_OldPasswordForValidate())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
				base.RaisePropertyChanged<bool>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ModifyCodeplugPasswordContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ModifyCodeplugPasswordContext.get_IsPasswordCorrect())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x0600012E RID: 302 RVA: 0x0001237C File Offset: 0x0001057C
		// (set) Token: 0x0600012F RID: 303 RVA: 0x0001242C File Offset: 0x0001062C
		public string NewRadioPassword
		{
			get
			{
				short num = (short)1738728073;
				short num2 = num;
				num = (short)673374857;
				switch (num2 == num)
				{
				}
				num = (short)752287744;
				if (num != 0)
				{
				}
				num = (short)1203896321;
				if (num != 0)
				{
				}
				num = (short)743571456;
				short num3 = num;
				return this.c;
			}
			set
			{
				short num = (short)1159069699;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						return;
					case 1:
						this.ResetPasswordPolicy();
						goto IL_E1;
					case 2:
						goto IL_F9;
					case 3:
						num = (short)1533018113;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_62;
						}
						continue;
					case 4:
						goto IL_168;
					case 5:
						if (string.IsNullOrEmpty(this.c.Trim()))
						{
							num = (short)920518657;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.SetPasswordPolicy();
						num = (short)1833369604;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_62:
					if (string.Compare(this.c, value, global::System.StringComparison.CurrentCulture) != 0)
					{
						this.c = value;
						num = (short)380370949;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1626091595;
					short num3 = num;
					num = (short)707407947;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1567096832;
						if (num != 0)
						{
						}
						num = (short)2130378752;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_E1:
					num = (short)929693698;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_F9:
				goto IL_192;
				IL_168:
				num = (short)1121976320;
				short num4 = num;
				IL_192:
				base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ModifyCodeplugPasswordContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ModifyCodeplugPasswordContext.get_NewRadioPassword())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
				base.RaisePropertyChanged<bool>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ModifyCodeplugPasswordContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ModifyCodeplugPasswordContext.get_IsPasswordForWriteNotBlank())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
				base.RaisePropertyChanged<bool>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ModifyCodeplugPasswordContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ModifyCodeplugPasswordContext.get_IsPasswordNotNullOrEmpty())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
				this.ContextIsChanged = true;
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x06000130 RID: 304 RVA: 0x00012670 File Offset: 0x00010870
		public bool IsPasswordNotNullOrEmpty
		{
			get
			{
				short num = (short)152549732;
				short num2 = num;
				num = (short)1229830500;
				switch (num2 == num)
				{
				}
				num = (short)150274049;
				if (num != 0)
				{
				}
				num = (short)1258946560;
				if (num != 0)
				{
				}
				num = (short)1447559168;
				short num3 = num;
				return !string.IsNullOrEmpty(this.NewRadioPassword);
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x06000131 RID: 305 RVA: 0x00012728 File Offset: 0x00010928
		// (set) Token: 0x06000132 RID: 306 RVA: 0x000127D8 File Offset: 0x000109D8
		public string NewRadioPasswordError
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)541959203;
				short num2 = num;
				num = (short)495952931;
				switch (num2 == num)
				{
				}
				num = (short)707002368;
				if (num != 0)
				{
				}
				num = (short)1032847361;
				if (num != 0)
				{
				}
				num = (short)956235776;
				short num3 = num;
				return this.g;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)837145271;
				short num2 = num;
				num = (short)1545654967;
				switch (num2 == num)
				{
				}
				num = (short)1363869697;
				if (num != 0)
				{
				}
				num = (short)1703936000;
				if (num != 0)
				{
				}
				num = (short)1646985216;
				short num3 = num;
				this.g = value;
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x06000133 RID: 307 RVA: 0x00012888 File Offset: 0x00010A88
		public bool IsPasswordForWriteNotBlank
		{
			get
			{
				short num = (short)1800403859;
				short num2 = num;
				num = (short)1974205331;
				switch (num2 == num)
				{
				}
				num = (short)321323009;
				if (num != 0)
				{
				}
				num = (short)1376256;
				if (num != 0)
				{
				}
				num = (short)2131689472;
				short num3 = num;
				bool flag = string.IsNullOrWhiteSpace(this.NewRadioPassword);
				return !flag;
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x06000134 RID: 308 RVA: 0x00012944 File Offset: 0x00010B44
		// (set) Token: 0x06000135 RID: 309 RVA: 0x000129F4 File Offset: 0x00010BF4
		public bool PasswordPerDevice
		{
			get
			{
				short num = (short)182377225;
				short num2 = num;
				num = (short)1830345481;
				switch (num2 == num)
				{
				}
				num = (short)1415577601;
				if (num != 0)
				{
				}
				num = (short)745537536;
				if (num != 0)
				{
				}
				num = (short)2144272384;
				short num3 = num;
				return this.d;
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
					{
						num2 = (short)562527703;
						short num3 = num2;
						num2 = (short)2105114071;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1C;
						case 1:
							break;
						default:
						{
							num2 = (short)28770304;
							short num4 = num2;
							break;
						}
						}
						num2 = (short)1244528640;
						if (num2 != 0)
						{
						}
						if (!value)
						{
							num2 = (short)1462239233;
							if (num2 != 0)
							{
							}
							num2 = (short)1123811330;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_10D;
					}
					case 1:
						goto IL_10B;
					case 2:
						this.ResetValue();
						num2 = (short)2013069313;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1C;
				}
				IL_10B:
				IL_10D:
				base.RaisePropertyChanged<bool>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ModifyCodeplugPasswordContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ModifyCodeplugPasswordContext.get_PasswordPerDevice())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
				base.RaisePropertyChanged<bool>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ModifyCodeplugPasswordContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ModifyCodeplugPasswordContext.get_IsPasswordCorrect())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
				this.ContextIsChanged = true;
				return;
				IL_1C:
				this.d = value;
				num2 = (short)1766719488;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06000136 RID: 310 RVA: 0x00012B80 File Offset: 0x00010D80
		// (set) Token: 0x06000137 RID: 311 RVA: 0x00012CDC File Offset: 0x00010EDC
		public bool IsPasswordCorrect
		{
			get
			{
				short num = (short)1952382977;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_D0;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_36;
						}
						continue;
					case 2:
						return true;
					case 3:
						if (string.IsNullOrEmpty(this.b))
						{
							num = (short)831193090;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_138;
					}
					IL_36:
					if (string.IsNullOrEmpty(this.RadioPassword))
					{
						num = (short)1153164075;
						short num3 = num;
						num = (short)1935008555;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_D0;
						case 1:
							break;
						default:
						{
							num = (short)1648689152;
							short num4 = num;
							break;
						}
						}
						num = (short)422313984;
						if (num != 0)
						{
						}
						num = (short)1358954496;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_138;
					IL_D0:
					num = (short)1517486081;
					if (num != 0)
					{
					}
					num = (short)1684013059;
					num2 = (int)((global::System.IntPtr)num);
				}
				return true;
				IL_138:
				return string.Compare(this.RadioPassword, this.OldPasswordForValidate, global::System.StringComparison.CurrentCulture) == 0;
			}
			set
			{
				short num = (short)1172633611;
				short num2 = num;
				num = (short)839776267;
				switch (num2 == num)
				{
				}
				num = (short)49152001;
				if (num != 0)
				{
				}
				num = (short)1298857984;
				if (num != 0)
				{
				}
				num = (short)1254883328;
				short num3 = num;
				base.RaisePropertyChanged<bool>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ModifyCodeplugPasswordContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ModifyCodeplugPasswordContext.get_IsPasswordCorrect())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
			}
		}

		// Token: 0x17000080 RID: 128
		public override string this[string propertyName]
		{
			get
			{
				int a_ = 15;
				short num = (short)894107649;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					IL_27:
					num = (short)46202881;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						num = (short)1268711427;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_64;
						}
						continue;
					case 2:
						goto IL_158;
					case 3:
						if (!base.Validate(this.NewRadioPasswordError))
						{
							num = (short)2105933826;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_10D;
					}
					IL_64:
					while (propertyName == global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("щ⥋㥍ɏ㍑こ㽕㝗ਖ਼㵛ⵝ፟ᕡୣᑥ౧", a_))
					{
						num = (short)765198336;
						short num3 = num;
						num = (short)276273270;
						short num4 = num;
						num = (short)908236918;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)2001272832;
							if (num != 0)
							{
							}
							num = (short)485752832;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_27;
						}
					}
					goto IL_15A;
				}
				IL_10D:
				return string.Empty;
				IL_158:
				return base.Error;
				IL_15A:
				return string.Empty;
			}
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00012F28 File Offset: 0x00011128
		public virtual void ResetValue()
		{
			short num = (short)863242327;
			short num2 = num;
			num = (short)804194391;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1957494784;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1411907584;
			if (num != 0)
			{
			}
			num = (short)1014759425;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600013A RID: 314 RVA: 0x00012FD0 File Offset: 0x000111D0
		public virtual void ResetPasswordPolicy()
		{
			short num = (short)1345187702;
			short num2 = num;
			num = (short)1144844150;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1060700160;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)389349376;
			if (num != 0)
			{
			}
			num = (short)154206209;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600013B RID: 315 RVA: 0x0001307C File Offset: 0x0001127C
		public virtual void SetPasswordPolicy()
		{
			short num = (short)528524775;
			short num2 = num;
			num = (short)175678951;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1310851072;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)399966208;
			if (num != 0)
			{
			}
			num = (short)599719937;
			if (num != 0)
			{
			}
		}

		// Token: 0x0400008C RID: 140
		private global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase a;

		// Token: 0x0400008D RID: 141
		private string b;

		// Token: 0x0400008E RID: 142
		private string c;

		// Token: 0x0400008F RID: 143
		private bool d;

		// Token: 0x04000090 RID: 144
		private bool e;

		// Token: 0x04000091 RID: 145
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string f;

		// Token: 0x04000092 RID: 146
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string g;
	}
}
