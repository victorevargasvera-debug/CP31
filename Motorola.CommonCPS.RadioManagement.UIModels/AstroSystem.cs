using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using Motorola.CommonCPS.RadioManagement.CommonBase;
using Motorola.CommonCPS.RadioManagement.CommonBase.Utility;
using Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x020000C9 RID: 201
	public class AstroSystem : global::Motorola.CommonCPS.RadioManagement.UIModels.EntityWrapper<global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystemSummary>
	{
		// Token: 0x0600090A RID: 2314 RVA: 0x00088648 File Offset: 0x00086848
		public AstroSystem() : base(new global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystemSummary())
		{
		}

		// Token: 0x0600090B RID: 2315 RVA: 0x00088660 File Offset: 0x00086860
		public AstroSystem(global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystemSummary summary) : base(summary ?? new global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystemSummary())
		{
		}

		// Token: 0x17000444 RID: 1092
		// (get) Token: 0x0600090C RID: 2316 RVA: 0x00088684 File Offset: 0x00086884
		// (set) Token: 0x0600090D RID: 2317 RVA: 0x00088740 File Offset: 0x00086940
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public override global::System.Guid? ID
		{
			get
			{
				short num = (short)1599219854;
				short num2 = num;
				num = (short)1564158094;
				switch (num2 == num)
				{
				}
				num = (short)1993342977;
				if (num != 0)
				{
				}
				num = (short)735641600;
				short num3 = num;
				num = (short)777388032;
				if (num != 0)
				{
				}
				return new global::System.Guid?(this.EntitySummary.Uuid);
			}
			set
			{
				short num = (short)899612673;
				if (num != 0)
				{
				}
				num = (short)2134438400;
				short num2 = num;
				num = (short)1312748032;
				switch (num2 == num)
				{
				}
				num = (short)2061762560;
				short num3 = num;
				num = (short)419037184;
				if (num != 0)
				{
				}
				this.EntitySummary.Uuid = (value ?? global::System.Guid.Empty);
			}
		}

		// Token: 0x17000445 RID: 1093
		// (get) Token: 0x0600090E RID: 2318 RVA: 0x00088814 File Offset: 0x00086A14
		// (set) Token: 0x0600090F RID: 2319 RVA: 0x000888C8 File Offset: 0x00086AC8
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public bool ExpandedMDCIDRange
		{
			get
			{
				short num = (short)821734584;
				short num2 = num;
				num = (short)719563960;
				switch (num2 == num)
				{
				}
				num = (short)1640300545;
				if (num != 0)
				{
				}
				num = (short)1261895680;
				short num3 = num;
				num = (short)731774976;
				if (num != 0)
				{
				}
				return this.EntitySummary.ExpandedMDCIDRange;
			}
			set
			{
				short num = (short)1132577907;
				short num2 = num;
				num = (short)473416819;
				switch (num2 == num)
				{
				}
				num = (short)2103771136;
				if (num != 0)
				{
				}
				num = (short)1985806336;
				short num3 = num;
				num = (short)1915748353;
				if (num != 0)
				{
				}
				this.EntitySummary.ExpandedMDCIDRange = value;
			}
		}

		// Token: 0x17000446 RID: 1094
		// (get) Token: 0x06000910 RID: 2320 RVA: 0x00088980 File Offset: 0x00086B80
		// (set) Token: 0x06000911 RID: 2321 RVA: 0x00088A34 File Offset: 0x00086C34
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public byte[] RadioSystemTimestamp
		{
			get
			{
				short num = (short)89774033;
				short num2 = num;
				num = (short)1609422801;
				switch (num2 == num)
				{
				}
				num = (short)1843462145;
				if (num != 0)
				{
				}
				num = (short)2014445568;
				short num3 = num;
				num = (short)1072824320;
				if (num != 0)
				{
				}
				return this.EntitySummary.Timestamp;
			}
			set
			{
				short num = (short)1477354751;
				short num2 = num;
				num = (short)1605346559;
				switch (num2 == num)
				{
				}
				num = (short)1273233409;
				if (num != 0)
				{
				}
				num = (short)243531776;
				short num3 = num;
				num = (short)479264768;
				if (num != 0)
				{
				}
				this.EntitySummary.Timestamp = value;
			}
		}

		// Token: 0x17000447 RID: 1095
		// (get) Token: 0x06000912 RID: 2322 RVA: 0x00088AE8 File Offset: 0x00086CE8
		// (set) Token: 0x06000913 RID: 2323 RVA: 0x00088B9C File Offset: 0x00086D9C
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public string SerialNumber
		{
			get
			{
				short num = (short)1164354138;
				short num2 = num;
				num = (short)2128650842;
				switch (num2 == num)
				{
				}
				num = (short)405536769;
				if (num != 0)
				{
				}
				num = (short)1158807552;
				short num3 = num;
				num = (short)494141440;
				if (num != 0)
				{
				}
				return this.EntitySummary.SerialNumber;
			}
			set
			{
				short num = (short)1137865431;
				short num2 = num;
				num = (short)1888776919;
				switch (num2 == num)
				{
				}
				num = (short)430374912;
				if (num != 0)
				{
				}
				num = (short)472842240;
				short num3 = num;
				num = (short)305594369;
				if (num != 0)
				{
				}
				this.EntitySummary.SerialNumber = value;
				base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem.get_SerialNumber())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
			}
		}

		// Token: 0x17000448 RID: 1096
		// (get) Token: 0x06000914 RID: 2324 RVA: 0x00088C88 File Offset: 0x00086E88
		// (set) Token: 0x06000915 RID: 2325 RVA: 0x00088D40 File Offset: 0x00086F40
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public string CodpelugVerison
		{
			get
			{
				short num = (short)2094703736;
				short num2 = num;
				num = (short)1905566840;
				switch (num2 == num)
				{
				}
				num = (short)818282496;
				if (num != 0)
				{
				}
				num = (short)502202368;
				short num3 = num;
				num = (short)657195009;
				if (num != 0)
				{
				}
				return this.EntitySummary.CodeplugVersion;
			}
			set
			{
				short num = (short)1787920520;
				short num2 = num;
				num = (short)1282375816;
				switch (num2 == num)
				{
				}
				num = (short)1462763521;
				if (num != 0)
				{
				}
				num = (short)877199360;
				short num3 = num;
				num = (short)1377959936;
				if (num != 0)
				{
				}
				this.EntitySummary.CodeplugVersion = value;
				base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem.get_CodpelugVerison())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
			}
		}

		// Token: 0x17000449 RID: 1097
		// (get) Token: 0x06000916 RID: 2326 RVA: 0x00088E28 File Offset: 0x00087028
		// (set) Token: 0x06000917 RID: 2327 RVA: 0x00088F00 File Offset: 0x00087100
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public global::Motorola.CommonCPS.Server.CommonDBConstants.RadioStatus? RadioStatus
		{
			get
			{
				int? radioStatus = this.EntitySummary.RadioStatus;
				if (radioStatus == null)
				{
					short num;
					for (;;)
					{
						num = (short)789512192;
						short num2 = num;
						num = (short)2032205825;
						if (num != 0)
						{
						}
						num = (short)321887808;
						short num3 = num;
						num = (short)354000448;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_A0;
						}
					}
					IL_A0:
					num = (short)1333526528;
					if (num != 0)
					{
					}
					return null;
				}
				return new global::Motorola.CommonCPS.Server.CommonDBConstants.RadioStatus?((global::Motorola.CommonCPS.Server.CommonDBConstants.RadioStatus)radioStatus.GetValueOrDefault());
			}
			set
			{
				short num = (short)535101440;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					switch (0)
					{
					case 0:
						goto IL_4B;
					}
					global::Motorola.CommonCPS.Server.CommonDBConstants.RadioStatus? radioStatus;
					for (;;)
					{
						IL_28:
						int? num3;
						int? num6;
						int? num7;
						int? num8;
						switch (num2)
						{
						case 0:
						{
							num3 = null;
							num = (short)494486854;
							short num4 = num;
							num = (short)31933766;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_222;
							default:
							{
								num = (short)2018705408;
								if (num != 0)
								{
								}
								num = (short)1636827136;
								short num5 = num;
								num = (short)1047265283;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							break;
						}
						case 1:
							num = (short)544473089;
							if (num != 0)
							{
							}
							this.EntitySummary.RadioStatus = num6;
							base.RaisePropertyChanged<global::Motorola.CommonCPS.Server.CommonDBConstants.RadioStatus?>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::Motorola.CommonCPS.Server.CommonDBConstants.RadioStatus?>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem.get_RadioStatus())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
							num = (short)442040322;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							return;
						case 3:
							num7 = num3;
							goto IL_17A;
						case 4:
							if (!(num3.GetValueOrDefault() == num8.GetValueOrDefault() & num3 != null == (num8 != null)))
							{
								num = (short)1534328833;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						case 5:
							goto IL_222;
						case 6:
							if (radioStatus == null)
							{
								num = (short)723320832;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)706281477;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4B;
						IL_17A:
						num6 = num7;
						num3 = this.EntitySummary.RadioStatus;
						num8 = num6;
						num = (short)1456930820;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_222:
						num7 = new int?((int)radioStatus.GetValueOrDefault());
						goto IL_17A;
					}
					return;
					IL_4B:
					radioStatus = value;
					num = (short)1581514758;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_28;
				}
				}
			}
		}

		// Token: 0x1700044A RID: 1098
		// (get) Token: 0x06000918 RID: 2328 RVA: 0x00089140 File Offset: 0x00087340
		// (set) Token: 0x06000919 RID: 2329 RVA: 0x000891F4 File Offset: 0x000873F4
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus? JobStatus
		{
			get
			{
				short num = (short)301798200;
				short num2 = num;
				num = (short)1014698808;
				switch (num2 == num)
				{
				}
				num = (short)956104705;
				if (num != 0)
				{
				}
				num = (short)1751384064;
				short num3 = num;
				num = (short)596508672;
				if (num != 0)
				{
				}
				return this.EntitySummary.JobStatus;
			}
			set
			{
				short num = (short)1966399301;
				short num2 = num;
				num = (short)1271062341;
				switch (num2 == num)
				{
				}
				num = (short)2142175232;
				if (num != 0)
				{
				}
				num = (short)1262223360;
				short num3 = num;
				num = (short)525991937;
				if (num != 0)
				{
				}
				this.EntitySummary.JobStatus = value;
				base.RaisePropertyChanged<global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus?>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus?>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem.get_JobStatus())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
			}
		}

		// Token: 0x1700044B RID: 1099
		// (get) Token: 0x0600091A RID: 2330 RVA: 0x000892E0 File Offset: 0x000874E0
		// (set) Token: 0x0600091B RID: 2331 RVA: 0x00089394 File Offset: 0x00087594
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public string TemplateName
		{
			get
			{
				short num = (short)1375036806;
				short num2 = num;
				num = (short)1181181318;
				switch (num2 == num)
				{
				}
				num = (short)1731723264;
				if (num != 0)
				{
				}
				num = (short)1272905728;
				short num3 = num;
				num = (short)1707409409;
				if (num != 0)
				{
				}
				return this.EntitySummary.TemplateName;
			}
			set
			{
				if (value == this.EntitySummary.TemplateName)
				{
					short num;
					for (;;)
					{
						num = (short)1956052992;
						short num2 = num;
						num = (short)254935041;
						if (num != 0)
						{
						}
						num = (short)354277384;
						short num3 = num;
						num = (short)1706350600;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_9E;
						}
					}
					IL_9E:
					num = (short)880279552;
					if (num != 0)
					{
					}
					return;
				}
				this.EntitySummary.TemplateName = value;
				base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem.get_TemplateName())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
			}
		}

		// Token: 0x1700044C RID: 1100
		// (get) Token: 0x0600091C RID: 2332 RVA: 0x00089498 File Offset: 0x00087698
		// (set) Token: 0x0600091D RID: 2333 RVA: 0x0008954C File Offset: 0x0008774C
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public string ConfigurationName
		{
			get
			{
				short num = (short)1719351450;
				short num2 = num;
				num = (short)295712922;
				switch (num2 == num)
				{
				}
				num = (short)1355743232;
				if (num != 0)
				{
				}
				num = (short)1261043712;
				short num3 = num;
				num = (short)462422017;
				if (num != 0)
				{
				}
				return this.EntitySummary.ConfigurationName;
			}
			set
			{
				short num = (short)1396768771;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						this.EntitySummary.ConfigurationName = (string.IsNullOrWhiteSpace(value) ? string.Empty : value);
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem.get_ConfigurationName())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1592459266;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						num = (short)1208877056;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_132;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_34;
						}
						continue;
					}
					IL_34:
					num = (short)1629167694;
					short num3 = num;
					num = (short)1431773262;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_132;
					default:
						num = (short)789446656;
						if (num != 0)
						{
						}
						if (!(value != this.EntitySummary.ConfigurationName))
						{
							goto IL_15C;
						}
						num = (short)1489108993;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				IL_132:
				num = (short)1835335680;
				short num4 = num;
				IL_15C:
				num = (short)614334465;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x1700044D RID: 1101
		// (get) Token: 0x0600091E RID: 2334 RVA: 0x000896E0 File Offset: 0x000878E0
		// (set) Token: 0x0600091F RID: 2335 RVA: 0x00089798 File Offset: 0x00087998
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public string RadioAlias
		{
			get
			{
				short num = (short)1875073206;
				short num2 = num;
				num = (short)1251694774;
				switch (num2 == num)
				{
				}
				num = (short)827326464;
				if (num != 0)
				{
				}
				num = (short)2144665600;
				short num3 = num;
				num = (short)190382081;
				if (num != 0)
				{
				}
				return this.EntitySummary.RadioAlias;
			}
			set
			{
				short num = (short)901376011;
				short num2 = num;
				num = (short)1558177803;
				switch (num2 == num)
				{
				}
				num = (short)1769865217;
				if (num != 0)
				{
				}
				num = (short)287178752;
				short num3 = num;
				num = (short)219480064;
				if (num != 0)
				{
				}
				this.EntitySummary.RadioAlias = global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.FilterInvalidChar(value);
				base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem.get_RadioAlias())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
			}
		}

		// Token: 0x1700044E RID: 1102
		// (get) Token: 0x06000920 RID: 2336 RVA: 0x00089888 File Offset: 0x00087A88
		// (set) Token: 0x06000921 RID: 2337 RVA: 0x00089938 File Offset: 0x00087B38
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType? SystemType
		{
			get
			{
				short num = (short)827448702;
				short num2 = num;
				num = (short)1741348222;
				switch (num2 == num)
				{
				}
				num = (short)1195966465;
				if (num != 0)
				{
				}
				num = (short)536215552;
				short num3 = num;
				num = (short)1659830272;
				if (num != 0)
				{
				}
				return this.EntitySummary.SystemType;
			}
			set
			{
				short num = (short)333053953;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_43;
				}
				global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType? astroSystemType;
				global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType? astroSystemType2;
				global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType? systemType;
				for (;;)
				{
					IL_31:
					int num2;
					switch (num2)
					{
					case 0:
					{
						this.EntitySummary.SystemSubType = new global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemSubType?((global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemSubType)astroSystemType.Value);
						base.RaisePropertyChanged<global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType?>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType?>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem.get_SystemType())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1029505024;
						short num3 = num;
						num = (short)1967063041;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						goto IL_17F;
					case 2:
						if (!(astroSystemType2.GetValueOrDefault() == systemType.GetValueOrDefault() & astroSystemType2 != null == (systemType != null)))
						{
							num = (short)1031274496;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					break;
				}
				IL_43:
				astroSystemType = value;
				astroSystemType2 = astroSystemType;
				systemType = this.EntitySummary.SystemType;
				num = (short)745457277;
				short num4 = num;
				num = (short)567461501;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_17F:
					break;
				default:
				{
					num = (short)1235222528;
					if (num != 0)
					{
					}
					num = (short)767492098;
					int num2 = (int)((global::System.IntPtr)num);
					goto IL_31;
				}
				}
			}
		}

		// Token: 0x1700044F RID: 1103
		// (get) Token: 0x06000922 RID: 2338 RVA: 0x00089AC8 File Offset: 0x00087CC8
		// (set) Token: 0x06000923 RID: 2339 RVA: 0x00089B7C File Offset: 0x00087D7C
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemSubType? SubSystemType
		{
			get
			{
				short num = (short)1411645441;
				if (num != 0)
				{
				}
				num = (short)1592747765;
				short num2 = num;
				num = (short)2146920181;
				switch (num2 == num)
				{
				}
				num = (short)1889468416;
				short num3 = num;
				num = (short)854720512;
				if (num != 0)
				{
				}
				return this.EntitySummary.SystemSubType;
			}
			set
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				short num2;
				global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemSubType? astroSystemSubType;
				global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemSubType? systemSubType;
				for (;;)
				{
					IL_0A:
					int num;
					switch (num)
					{
					case 0:
					{
						this.EntitySummary.SystemSubType = value;
						base.RaisePropertyChanged<global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemSubType?>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemSubType?>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem.get_SubSystemType())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num2 = (short)666435584;
						short num3 = num2;
						num2 = (short)1451491329;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 1:
						goto IL_17A;
					case 2:
						if (!(astroSystemSubType.GetValueOrDefault() == systemSubType.GetValueOrDefault() & astroSystemSubType != null == (systemSubType != null)))
						{
							num2 = (short)1344208896;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					}
					break;
				}
				IL_1C:
				astroSystemSubType = value;
				systemSubType = this.EntitySummary.SystemSubType;
				num2 = (short)66718358;
				short num4 = num2;
				num2 = (short)1046350486;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_17A:
					break;
				default:
				{
					num2 = (short)314572801;
					if (num2 != 0)
					{
					}
					num2 = (short)2053636096;
					if (num2 != 0)
					{
					}
					num2 = (short)444661762;
					int num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				}
			}
		}

		// Token: 0x17000450 RID: 1104
		// (get) Token: 0x06000924 RID: 2340 RVA: 0x00089D08 File Offset: 0x00087F08
		// (set) Token: 0x06000925 RID: 2341 RVA: 0x00089DBC File Offset: 0x00087FBC
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public string SystemName
		{
			get
			{
				short num = (short)694166804;
				short num2 = num;
				num = (short)687940884;
				switch (num2 == num)
				{
				}
				num = (short)1718288385;
				if (num != 0)
				{
				}
				num = (short)102039552;
				short num3 = num;
				num = (short)1823932416;
				if (num != 0)
				{
				}
				return this.EntitySummary.SystemName;
			}
			set
			{
				short num = (short)299827201;
				if (num != 0)
				{
				}
				num = (short)170983424;
				short num2 = num;
				if (value == this.EntitySummary.SystemName)
				{
					for (;;)
					{
						num = (short)1390226103;
						short num3 = num;
						num = (short)42740407;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_9A;
						}
					}
					IL_9A:
					num = (short)1118830592;
					if (num != 0)
					{
					}
					return;
				}
				this.EntitySummary.SystemName = value;
				base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem.get_SystemName())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
			}
		}

		// Token: 0x17000451 RID: 1105
		// (get) Token: 0x06000926 RID: 2342 RVA: 0x00089EBC File Offset: 0x000880BC
		// (set) Token: 0x06000927 RID: 2343 RVA: 0x00089FB4 File Offset: 0x000881B4
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public string SystemId
		{
			get
			{
				int a_ = 6;
				short num;
				if (this.EntitySummary.SystemId == null)
				{
					for (;;)
					{
						num = (short)166592512;
						short num2 = num;
						num = (short)919793672;
						short num3 = num;
						num = (short)213643272;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_7D;
						}
					}
					IL_7D:
					num = (short)1746075648;
					if (num != 0)
					{
					}
					return null;
				}
				num = (short)1933639681;
				if (num != 0)
				{
				}
				return this.EntitySummary.SystemId.Value.ToString(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("᥀", a_), global::System.Globalization.CultureInfo.CurrentCulture);
			}
			set
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num2;
				short num3;
				for (;;)
				{
					IL_0A:
					int num;
					switch (num)
					{
					case 0:
					{
						this.EntitySummary.SystemId = new int?(num2);
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem.get_SystemId())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num3 = (short)904069120;
						short num4 = num3;
						num3 = (short)1282473985;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					case 1:
						goto IL_16E;
					case 2:
					{
						int num5 = num2;
						int? systemId = this.EntitySummary.SystemId;
						if (!(num5 == systemId.GetValueOrDefault() & systemId != null))
						{
							num3 = (short)1705246721;
							if (num3 != 0)
							{
							}
							num3 = (short)893976576;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						return;
					}
					}
					break;
				}
				IL_1C:
				num2 = global::System.Convert.ToInt32(value, 16);
				num3 = (short)212933021;
				short num6 = num3;
				num3 = (short)372775325;
				switch ((num6 == num3) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_16E:
					break;
				default:
				{
					num3 = (short)1246429184;
					if (num3 != 0)
					{
					}
					num3 = (short)663224322;
					int num = (int)((global::System.IntPtr)num3);
					goto IL_0A;
				}
				}
			}
		}

		// Token: 0x17000452 RID: 1106
		// (get) Token: 0x06000928 RID: 2344 RVA: 0x0008A134 File Offset: 0x00088334
		// (set) Token: 0x06000929 RID: 2345 RVA: 0x0008A1EC File Offset: 0x000883EC
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.EntitytMemberName("RadioId")]
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify("IsRadioIDEditable", 0, true)]
		public int? RadioID
		{
			get
			{
				short num = (short)901994822;
				short num2 = num;
				num = (short)862214470;
				switch (num2 == num)
				{
				}
				num = (short)122486784;
				if (num != 0)
				{
				}
				num = (short)1187381248;
				short num3 = num;
				num = (short)1567358977;
				if (num != 0)
				{
				}
				return this.EntitySummary.RadioId;
			}
			set
			{
				int? num = value;
				int? radioId = this.EntitySummary.RadioId;
				if (num.GetValueOrDefault() == radioId.GetValueOrDefault() & num != null == (radioId != null))
				{
					short num2;
					for (;;)
					{
						num2 = (short)534380544;
						short num3 = num2;
						num2 = (short)870390628;
						short num4 = num2;
						num2 = (short)1116085092;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_96;
						}
					}
					IL_96:
					num2 = (short)1894842368;
					if (num2 != 0)
					{
					}
					num2 = (short)672661505;
					if (num2 != 0)
					{
					}
					return;
				}
				this.EntitySummary.RadioId = value;
				base.RaisePropertyChanged<int?>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<int?>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem.get_RadioID())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
			}
		}

		// Token: 0x17000453 RID: 1107
		// (get) Token: 0x0600092A RID: 2346 RVA: 0x0008A310 File Offset: 0x00088510
		// (set) Token: 0x0600092B RID: 2347 RVA: 0x0008A3C8 File Offset: 0x000885C8
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public global::System.Guid? DeviceID
		{
			get
			{
				short num = (short)1968898049;
				if (num != 0)
				{
				}
				num = (short)1087444392;
				short num2 = num;
				num = (short)2002458024;
				switch (num2 == num)
				{
				}
				num = (short)660799488;
				short num3 = num;
				num = (short)263323648;
				if (num != 0)
				{
				}
				return this.EntitySummary.RadioUuid;
			}
			set
			{
				short num = (short)1269165479;
				short num2 = num;
				num = (short)333245863;
				switch (num2 == num)
				{
				}
				num = (short)1821966337;
				if (num != 0)
				{
				}
				num = (short)2015625216;
				short num3 = num;
				num = (short)602603520;
				if (num != 0)
				{
				}
				this.EntitySummary.RadioUuid = value;
			}
		}

		// Token: 0x17000454 RID: 1108
		// (get) Token: 0x0600092C RID: 2348 RVA: 0x0008A480 File Offset: 0x00088680
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public string CustomID
		{
			get
			{
				int a_ = 13;
				short num = (short)1023055906;
				short num2 = num;
				num = (short)1418172450;
				switch (num2 == num)
				{
				}
				num = (short)1611202561;
				if (num != 0)
				{
				}
				num = (short)343998464;
				short num3 = num;
				num = (short)121765888;
				if (num != 0)
				{
				}
				return string.Concat(new string[]
				{
					this.SystemId,
					global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("敇", a_),
					(this.SystemType != null) ? this.SystemType.ToString() : null,
					global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("敇", a_),
					(this.SubSystemType != null) ? this.SubSystemType.ToString() : null,
					global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("敇", a_),
					this.SystemName
				});
			}
		}

		// Token: 0x17000455 RID: 1109
		// (get) Token: 0x0600092D RID: 2349 RVA: 0x0008A5E0 File Offset: 0x000887E0
		// (set) Token: 0x0600092E RID: 2350 RVA: 0x0008A690 File Offset: 0x00088890
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public string RadioIDError
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1869691160;
				short num2 = num;
				num = (short)1572026648;
				switch (num2 == num)
				{
				default:
				{
					num = (short)418381824;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1733754881;
				if (num != 0)
				{
				}
				num = (short)771162112;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)939494172;
				short num2 = num;
				num = (short)2133887772;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1644494848;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1208352768;
				if (num != 0)
				{
				}
				num = (short)1680539649;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x17000456 RID: 1110
		// (get) Token: 0x0600092F RID: 2351 RVA: 0x0008A744 File Offset: 0x00088944
		// (set) Token: 0x06000930 RID: 2352 RVA: 0x0008A7F8 File Offset: 0x000889F8
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public bool IsRadioIDEditable
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1000880539;
				short num2 = num;
				num = (short)897399195;
				switch (num2 == num)
				{
				default:
				{
					num = (short)575602688;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1003945984;
				if (num != 0)
				{
				}
				num = (short)2075590657;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1068242355;
				short num2 = num;
				num = (short)980751795;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2005270528;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1879048193;
				if (num != 0)
				{
				}
				num = (short)1396572160;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x17000457 RID: 1111
		// (get) Token: 0x06000931 RID: 2353 RVA: 0x0008A8A8 File Offset: 0x00088AA8
		private global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystemSummary EntitySummary
		{
			get
			{
				short num = (short)581868023;
				short num2 = num;
				num = (short)1741068791;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1282932736;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1400242177;
				if (num != 0)
				{
				}
				num = (short)972357632;
				if (num != 0)
				{
				}
				return base.Entity;
			}
		}

		// Token: 0x17000458 RID: 1112
		// (get) Token: 0x06000932 RID: 2354 RVA: 0x0008A958 File Offset: 0x00088B58
		// (set) Token: 0x06000933 RID: 2355 RVA: 0x0008AA0C File Offset: 0x00088C0C
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.EntitytMemberName("AskRequired")]
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public bool? AskRequired
		{
			get
			{
				short num = (short)561796028;
				short num2 = num;
				num = (short)2072859580;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1749286912;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)407371777;
				if (num != 0)
				{
				}
				num = (short)1540423680;
				if (num != 0)
				{
				}
				return this.EntitySummary.AskRequired;
			}
			set
			{
				short num;
				for (;;)
				{
					bool? flag = value;
					bool? askRequired = this.EntitySummary.AskRequired;
					if (flag.GetValueOrDefault() == askRequired.GetValueOrDefault() & flag != null == (askRequired != null))
					{
						break;
					}
					num = (short)1691255331;
					short num2 = num;
					num = (short)1779991075;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_90;
					}
				}
				num = (short)1144061952;
				short num3 = num;
				return;
				IL_90:
				num = (short)2058551296;
				if (num != 0)
				{
				}
				num = (short)1417936897;
				if (num != 0)
				{
				}
				this.EntitySummary.AskRequired = value;
				base.RaisePropertyChanged<bool?>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool?>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem.get_AskRequired())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
			}
		}

		// Token: 0x17000459 RID: 1113
		public override string this[string propertyName]
		{
			get
			{
				int a_ = 18;
				short num = (short)1911750657;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)1535201389;
						short num3 = num;
						num = (short)1981894765;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_57;
						default:
							goto IL_A7;
						}
						break;
					}
					case 1:
						switch (0)
						{
						case 0:
							goto IL_3E;
						}
						continue;
					case 2:
						if (!base.Validate(this.RadioIDError))
						{
							num = (short)1318977537;
							if (num != 0)
							{
							}
							num = (short)56754176;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6D;
					case 3:
					{
						num = (short)25886720;
						short num4 = num;
						num = (short)659357698;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_3E;
					IL_57:
					num = (short)1959264259;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3E:
					if (propertyName == global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("Ὄ⹎㕐㩒㩔Ṗᵘ", a_))
					{
						goto IL_57;
					}
					goto IL_158;
				}
				IL_6D:
				return string.Empty;
				IL_A7:
				num = (short)823787520;
				if (num != 0)
				{
				}
				return base.Error;
				IL_158:
				return string.Empty;
			}
		}

		// Token: 0x06000935 RID: 2357 RVA: 0x0008AC94 File Offset: 0x00088E94
		public global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystemSummary GetRawObject()
		{
			short num = (short)1609196272;
			short num2 = num;
			num = (short)788423408;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1935278080;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1759313921;
			if (num != 0)
			{
			}
			num = (short)1642659840;
			if (num != 0)
			{
			}
			return this.EntitySummary;
		}

		// Token: 0x06000936 RID: 2358 RVA: 0x0008AD44 File Offset: 0x00088F44
		public override void CleanErrors()
		{
			short num = (short)1148630613;
			short num2 = num;
			num = (short)189380181;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1083179008;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1057882113;
			if (num != 0)
			{
			}
			num = (short)1499398144;
			if (num != 0)
			{
			}
			base.CleanErrors();
			this.RadioIDError = string.Empty;
		}

		// Token: 0x06000937 RID: 2359 RVA: 0x0008AE00 File Offset: 0x00089000
		public override bool IsValidRecord()
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			bool flag;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_12D;
				case 1:
					if (flag)
					{
						num2 = (short)1864040451;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)2011168770;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					goto IL_EB;
				case 3:
					goto IL_D2;
				}
				goto IL_20;
			}
			IL_D2:
			goto IL_EE;
			IL_EB:
			return false;
			IL_12D:
			return base.Validate(this.RadioIDError);
			IL_20:
			flag = base.IsValidRecord();
			num2 = (short)591834700;
			short num3 = num2;
			num2 = (short)921218636;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_EE:
				num2 = (short)1242365953;
				if (num2 != 0)
				{
				}
				num2 = (short)792985600;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			case 1:
				break;
			default:
			{
				num2 = (short)1845231616;
				short num4 = num2;
				break;
			}
			}
			num2 = (short)1763049472;
			if (num2 != 0)
			{
			}
			num2 = (short)215678977;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000938 RID: 2360 RVA: 0x0008AF4C File Offset: 0x0008914C
		public override global::System.Collections.Generic.Dictionary<string, string> InvalidFieldErrorInfo()
		{
			int a_ = 0;
			switch (0)
			{
			case 0:
				goto IL_25;
			}
			short num2;
			global::System.Collections.Generic.Dictionary<string, string> dictionary;
			for (;;)
			{
				IL_13:
				int num;
				switch (num)
				{
				case 0:
					if (!base.Validate(this.RadioIDError))
					{
						num2 = (short)1000013826;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return dictionary;
				case 1:
					goto IL_13A;
				case 2:
					dictionary.Add(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("椺尼嬾⡀ⱂౄ͆", a_), base.Error);
					num2 = (short)1234829313;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				break;
			}
			IL_25:
			dictionary = base.InvalidFieldErrorInfo();
			num2 = (short)1184759809;
			if (num2 != 0)
			{
			}
			num2 = (short)1618345984;
			short num3 = num2;
			num2 = (short)234915807;
			short num4 = num2;
			num2 = (short)1546094559;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_13A:
				break;
			default:
			{
				num2 = (short)2071068672;
				if (num2 != 0)
				{
				}
				num2 = (short)464650240;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			}
			return dictionary;
		}

		// Token: 0x0400037B RID: 891
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string a;

		// Token: 0x0400037C RID: 892
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool b;
	}
}
