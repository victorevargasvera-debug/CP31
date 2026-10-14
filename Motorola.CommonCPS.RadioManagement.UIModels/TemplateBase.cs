using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Xml.Serialization;
using Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x020000F3 RID: 243
	public abstract class TemplateBase : global::Motorola.CommonCPS.RadioManagement.UIModels.EntityWrapper<global::Motorola.CommonCPS.Server.EntityModel.TemplateSummary>
	{
		// Token: 0x06000BCE RID: 3022 RVA: 0x000B1888 File Offset: 0x000AFA88
		protected TemplateBase(global::Motorola.CommonCPS.Server.EntityModel.TemplateSummary templateSummary) : base(templateSummary)
		{
			this.d = new global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRODVRSFileDto();
			if (this.SummaryEntity.ASTRODVRSFiles != null)
			{
				global::System.Xml.Serialization.XmlSerializer xmlSerializer = new global::System.Xml.Serialization.XmlSerializer(typeof(global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRODVRSFileDto>));
				global::System.IO.StringReader textReader = new global::System.IO.StringReader(this.SummaryEntity.ASTRODVRSFiles);
				global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRODVRSFileDto> source = (global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRODVRSFileDto>)xmlSerializer.Deserialize(textReader);
				if (source.Any<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRODVRSFileDto>())
				{
					this.d = source.First<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRODVRSFileDto>();
				}
				this.d.Owner = this.Name;
			}
		}

		// Token: 0x17000575 RID: 1397
		// (get) Token: 0x06000BCF RID: 3023 RVA: 0x000B1910 File Offset: 0x000AFB10
		public override global::System.Guid? ID
		{
			get
			{
				short num = (short)1526973508;
				short num2 = num;
				num = (short)1713357892;
				switch (num2 == num)
				{
				}
				num = (short)976814080;
				if (num != 0)
				{
				}
				num = (short)670629889;
				if (num != 0)
				{
				}
				num = (short)314769408;
				short num3 = num;
				return new global::System.Guid?(this.TemplateID);
			}
		}

		// Token: 0x17000576 RID: 1398
		// (get) Token: 0x06000BD0 RID: 3024 RVA: 0x000B19C4 File Offset: 0x000AFBC4
		// (set) Token: 0x06000BD1 RID: 3025 RVA: 0x000B1A9C File Offset: 0x000AFC9C
		public string Name
		{
			get
			{
				short num = (short)1495596191;
				short num2 = num;
				num = (short)2028534943;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1939865600;
					if (num != 0)
					{
					}
					if (string.IsNullOrWhiteSpace(this.SummaryEntity.Name))
					{
						num = (short)2028863488;
						short num3 = num;
						num = (short)306446337;
						if (num != 0)
						{
						}
						return string.Empty;
					}
					break;
				}
				return this.SummaryEntity.Name.TrimEnd(global::System.Array.Empty<char>());
			}
			set
			{
				int a_ = 16;
				short num = (short)354287617;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						this.SummaryEntity.Name = value.Trim();
						this.RaisePropertyChanged(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("Պⱌ≎㑐", a_));
						num = (short)1242497028;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_43;
						}
						continue;
					case 2:
						num = (short)363790339;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_159;
					case 4:
						return;
					}
					IL_43:
					num = (short)1601793398;
					short num3 = num;
					num = (short)1709403510;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_159:
						if (!(value != this.SummaryEntity.Name))
						{
							return;
						}
						num = (short)1963261952;
						num2 = (int)((global::System.IntPtr)num);
						break;
					default:
					{
						num = (short)1735327745;
						if (num != 0)
						{
						}
						num = (short)457834496;
						short num4 = num;
						num = (short)1318191104;
						if (num != 0)
						{
						}
						if (string.IsNullOrWhiteSpace(value))
						{
							return;
						}
						num = (short)1053425666;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					}
				}
			}
		}

		// Token: 0x17000577 RID: 1399
		// (get) Token: 0x06000BD2 RID: 3026 RVA: 0x000B1C34 File Offset: 0x000AFE34
		// (set) Token: 0x06000BD3 RID: 3027 RVA: 0x000B1CEC File Offset: 0x000AFEEC
		public string ModelNumber
		{
			get
			{
				short num = (short)1587149797;
				short num2 = num;
				num = (short)182516709;
				switch (num2 == num)
				{
				}
				num = (short)398196736;
				if (num != 0)
				{
				}
				num = (short)2074804225;
				if (num != 0)
				{
				}
				num = (short)1061224448;
				short num3 = num;
				return this.SummaryEntity.ModelNumber;
			}
			set
			{
				int a_ = 0;
				short num = (short)1607794688;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_1E;
					case 1:
						goto IL_112;
					case 2:
					{
						num = (short)1477032288;
						short num3 = num;
						num = (short)277264736;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1E;
						default:
							num = (short)2102984704;
							if (num != 0)
							{
							}
							this.SummaryEntity.ModelNumber = value;
							this.RaisePropertyChanged(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("瘺刼嬾⑀⽂ୄ㉆⑈⥊⡌㵎", a_));
							num = (short)1811677185;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					goto IL_3A;
					IL_1E:
					switch (0)
					{
					case 0:
					{
						IL_3A:
						num = (short)1142030336;
						short num4 = num;
						if (!(value != this.SummaryEntity.ModelNumber))
						{
							goto IL_114;
						}
						num = (short)1854603266;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					}
				}
				IL_112:
				IL_114:
				num = (short)630718465;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x17000578 RID: 1400
		// (get) Token: 0x06000BD4 RID: 3028 RVA: 0x000B1E38 File Offset: 0x000B0038
		// (set) Token: 0x06000BD5 RID: 3029 RVA: 0x000B1EE8 File Offset: 0x000B00E8
		public global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRODVRSFileDto DVRSFile
		{
			get
			{
				short num = (short)2046117450;
				short num2 = num;
				num = (short)542328394;
				switch (num2 == num)
				{
				}
				num = (short)1789394944;
				if (num != 0)
				{
				}
				num = (short)2018902017;
				if (num != 0)
				{
				}
				num = (short)94306304;
				short num3 = num;
				return this.d;
			}
			set
			{
				short num = (short)1833893888;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)333709313;
					if (num != 0)
					{
					}
					num = (short)481361920;
					short num3 = num;
					switch (num2)
					{
					case 0:
						IL_14:
						switch (0)
						{
						case 0:
							goto IL_80;
						}
						continue;
					case 1:
						try
						{
							num = (short)844169219;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRODVRSFileDto astrodvrsfileDto;
									this.d = astrodvrsfileDto;
									base.RaisePropertyChanged<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRODVRSFileDto>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRODVRSFileDto>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase.get_DVRSFile())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
									base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase.get_DVRSFileVersion())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
									num = (short)1899495429;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
								{
									global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRODVRSFileDto> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1158283270;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRODVRSFileDto astrodvrsfileDto = enumerator.Current;
									num = (short)1529085956;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									goto IL_202;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_E2;
									}
									continue;
								case 4:
								{
									global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRODVRSFileDto astrodvrsfileDto;
									if (astrodvrsfileDto.Equals(value))
									{
										num = (short)1187643392;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
									goto IL_1E6;
								case 6:
									num = (short)155123714;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_E7:
								num = (short)1389232129;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_E2:
								goto IL_E7;
							}
							IL_1E6:
							IL_202:
							return;
						}
						finally
						{
							num = (short)2057240576;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRODVRSFileDto> enumerator;
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_238;
									}
									continue;
								case 1:
									goto IL_26C;
								case 2:
									enumerator.Dispose();
									num = (short)1532952577;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_238:
								if (enumerator == null)
								{
									break;
								}
								num = (short)474873858;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_26C:;
						}
						goto IL_26F;
					case 2:
						goto IL_26F;
					}
					IL_80:
					if (value != null)
					{
						num = (short)180879362;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_26F:
					num = (short)1113970073;
					short num4 = num;
					num = (short)1435817369;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_14;
					default:
					{
						num = (short)1968635904;
						if (num != 0)
						{
						}
						global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRODVRSFileDto> enumerator = this.DVRSFiles.GetEnumerator();
						num = (short)789643265;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					}
				}
			}
		}

		// Token: 0x17000579 RID: 1401
		// (get) Token: 0x06000BD6 RID: 3030 RVA: 0x000B21F4 File Offset: 0x000B03F4
		public string DVRSFileVersion
		{
			get
			{
				short num = (short)447930417;
				short num2 = num;
				num = (short)430956593;
				switch (num2 == num)
				{
				}
				num = (short)1252458496;
				if (num != 0)
				{
				}
				num = (short)1190854657;
				if (num != 0)
				{
				}
				num = (short)280887296;
				short num3 = num;
				return this.d.PackageVersion;
			}
		}

		// Token: 0x1700057A RID: 1402
		// (get) Token: 0x06000BD7 RID: 3031 RVA: 0x000B22A8 File Offset: 0x000B04A8
		// (set) Token: 0x06000BD8 RID: 3032 RVA: 0x000B2380 File Offset: 0x000B0580
		public override string Comments
		{
			get
			{
				short num = (short)1339928106;
				short num2 = num;
				num = (short)752135722;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)644939777;
					if (num != 0)
					{
					}
					num = (short)142802944;
					if (num != 0)
					{
					}
					num = (short)1126236160;
					short num3 = num;
					if (string.IsNullOrWhiteSpace(this.SummaryEntity.Comment))
					{
						return string.Empty;
					}
					break;
				}
				}
				return this.SummaryEntity.Comment.Trim();
			}
			set
			{
				int a_ = 19;
				short num = (short)2087256066;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)250413056;
					short num3 = num;
					switch (num2)
					{
					case 0:
						goto IL_E2;
					case 1:
					{
						num = (short)2130044461;
						short num4 = num;
						num = (short)380233261;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							num = (short)813629440;
							if (num != 0)
							{
							}
							num = (short)356974596;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
						switch (0)
						{
						case 0:
							goto IL_6D;
						}
						continue;
					case 3:
						value = string.Empty;
						num = (short)1587478528;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (string.IsNullOrEmpty(value))
						{
							num = (short)1832321025;
							if (num != 0)
							{
							}
							num = (short)1905721347;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E2;
					case 5:
						return;
					}
					IL_6D:
					if (value != this.SummaryEntity.Comment)
					{
						num = (short)285147137;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_E2:
					this.SummaryEntity.Comment = value.Trim();
					this.RaisePropertyChanged(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("്㽏㽑㥓㍕㙗⹙⽛", a_));
					num = (short)1558118405;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x1700057B RID: 1403
		// (get) Token: 0x06000BD9 RID: 3033 RVA: 0x000B2530 File Offset: 0x000B0730
		// (set) Token: 0x06000BDA RID: 3034 RVA: 0x000B25E4 File Offset: 0x000B07E4
		public string FirmwareVersion
		{
			get
			{
				short num = (short)112066561;
				if (num != 0)
				{
				}
				num = (short)1628198849;
				short num2 = num;
				num = (short)906844097;
				switch (num2 == num)
				{
				}
				num = (short)1962147840;
				if (num != 0)
				{
				}
				num = (short)313327616;
				short num3 = num;
				return this.SummaryEntity.FirmwareVersion;
			}
			set
			{
				int a_ = 7;
				short num = (short)367976400;
				short num2 = num;
				num = (short)191291344;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)861470720;
					if (num != 0)
					{
					}
					if (value == this.SummaryEntity.FirmwareVersion)
					{
						num = (short)1432813568;
						short num3 = num;
						num = (short)1526136833;
						if (num != 0)
						{
						}
						return;
					}
					break;
				}
				this.SummaryEntity.FirmwareVersion = value;
				this.RaisePropertyChanged(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("сⵃ㑅╇㵉ⵋ㱍㕏ёㅓ⑕⭗㍙㍛そ", a_));
			}
		}

		// Token: 0x1700057C RID: 1404
		// (get) Token: 0x06000BDB RID: 3035 RVA: 0x000B26CC File Offset: 0x000B08CC
		// (set) Token: 0x06000BDC RID: 3036 RVA: 0x000B2780 File Offset: 0x000B0980
		public string BBFBundleVersion
		{
			get
			{
				short num = (short)958320750;
				short num2 = num;
				num = (short)1098698862;
				switch (num2 == num)
				{
				}
				num = (short)1192361984;
				if (num != 0)
				{
				}
				num = (short)761004033;
				if (num != 0)
				{
				}
				num = (short)1622867968;
				short num3 = num;
				return this.SummaryEntity.BBFBundleVersion;
			}
			set
			{
				int a_ = 14;
				short num = (short)51580405;
				short num2 = num;
				num = (short)1009913333;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)600309760;
					if (num != 0)
					{
					}
					if (value == this.SummaryEntity.BBFBundleVersion)
					{
						num = (short)2122973184;
						short num3 = num;
						num = (short)170590209;
						if (num != 0)
						{
						}
						return;
					}
					break;
				}
				this.SummaryEntity.BBFBundleVersion = value;
				this.RaisePropertyChanged(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ୈॊୌൎ⑐㵒ㅔ㭖㱘൚㡜ⵞበ੢੤०", a_));
			}
		}

		// Token: 0x1700057D RID: 1405
		// (get) Token: 0x06000BDD RID: 3037 RVA: 0x000B286C File Offset: 0x000B0A6C
		// (set) Token: 0x06000BDE RID: 3038 RVA: 0x000B2924 File Offset: 0x000B0B24
		public string CodeplugVersion
		{
			get
			{
				short num = (short)1690567540;
				short num2 = num;
				num = (short)1116734324;
				switch (num2 == num)
				{
				}
				num = (short)1902837761;
				if (num != 0)
				{
				}
				num = (short)764674048;
				if (num != 0)
				{
				}
				num = (short)1578696704;
				short num3 = num;
				return this.SummaryEntity.CodeplugVersion;
			}
			set
			{
				int a_ = 13;
				short num = (short)1686934528;
				short num2 = num;
				num = (short)924357632;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1796341760;
					if (num != 0)
					{
					}
					if (value == this.SummaryEntity.CodeplugVersion)
					{
						num = (short)960299008;
						short num3 = num;
						num = (short)1971716097;
						if (num != 0)
						{
						}
						return;
					}
					break;
				}
				this.SummaryEntity.CodeplugVersion = value;
				this.RaisePropertyChanged(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("େ╉⡋⭍⁏㹑⅓ㅕ๗㽙⹛ⵝय़ൡ੣", a_));
			}
		}

		// Token: 0x1700057E RID: 1406
		// (get) Token: 0x06000BDF RID: 3039 RVA: 0x000B2A10 File Offset: 0x000B0C10
		// (set) Token: 0x06000BE0 RID: 3040 RVA: 0x000B2AC4 File Offset: 0x000B0CC4
		public int RadioReferencedCount
		{
			get
			{
				short num = (short)60620801;
				if (num != 0)
				{
				}
				num = (short)573431881;
				short num2 = num;
				num = (short)1759371337;
				switch (num2 == num)
				{
				}
				num = (short)1894187008;
				if (num != 0)
				{
				}
				num = (short)2117337088;
				short num3 = num;
				return this.SummaryEntity.RadioReferencedCount;
			}
			set
			{
				int a_ = 17;
				short num = (short)72989264;
				short num2 = num;
				num = (short)793754192;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1981349888;
					if (num != 0)
					{
					}
					num = (short)795279361;
					if (num != 0)
					{
					}
					num = (short)1110114304;
					short num3 = num;
					if (value == this.SummaryEntity.RadioReferencedCount)
					{
						return;
					}
					break;
				}
				}
				this.SummaryEntity.RadioReferencedCount = value;
				this.RaisePropertyChanged(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ṋ⽍㑏㭑㭓ѕ㵗㱙㥛ⱝ՟ౡݣͥ౧⥩ͫ᭭ṯٱ", a_));
			}
		}

		// Token: 0x1700057F RID: 1407
		// (get) Token: 0x06000BE1 RID: 3041 RVA: 0x000B2BAC File Offset: 0x000B0DAC
		// (set) Token: 0x06000BE2 RID: 3042 RVA: 0x000B2D48 File Offset: 0x000B0F48
		public global::System.DateTime? ModifiedDate
		{
			get
			{
				switch (0)
				{
				case 0:
					goto IL_20;
				}
				int num;
				short num2;
				global::System.DateTime? result;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						goto IL_41;
					case 1:
						goto IL_123;
					case 2:
					{
						global::System.DateTime value;
						if (value.Kind == global::System.DateTimeKind.Local)
						{
							goto IL_158;
						}
						num2 = (short)2040867906;
						short num3 = num2;
						num2 = (short)1117203522;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_41;
						default:
							num2 = (short)1920204800;
							if (num2 != 0)
							{
							}
							num2 = (short)1750138881;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 3:
						goto IL_60;
					}
					goto IL_20;
					IL_41:
					if (result == null)
					{
						num2 = (short)194904067;
						num = (int)((global::System.IntPtr)num2);
					}
					else
					{
						result = this.SummaryEntity.ModifiedDate;
						global::System.DateTime value = result.Value;
						num2 = (short)2117009410;
						num = (int)((global::System.IntPtr)num2);
					}
				}
				IL_60:
				result = null;
				return result;
				IL_123:
				num2 = (short)1451098113;
				if (num2 != 0)
				{
				}
				result = this.SummaryEntity.ModifiedDate;
				return new global::System.DateTime?(global::System.TimeZoneInfo.ConvertTimeFromUtc(result.Value, global::System.TimeZoneInfo.Local));
				IL_158:
				num2 = (short)974716928;
				short num4 = num2;
				return this.SummaryEntity.ModifiedDate;
				IL_20:
				result = this.SummaryEntity.ModifiedDate;
				num2 = (short)822149120;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			set
			{
				int a_ = 6;
				switch (0)
				{
				case 0:
					goto IL_39;
				}
				short num2;
				for (;;)
				{
					IL_13:
					int num;
					bool flag;
					switch (num)
					{
					case 0:
						return;
					case 1:
						num2 = (short)713359367;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 2:
						num2 = (short)794099713;
						if (num2 != 0)
						{
						}
						flag = true;
						goto IL_134;
					case 3:
					{
						global::System.DateTime? dateTime;
						global::System.DateTime? modifiedDate;
						flag = (dateTime.GetValueOrDefault() == modifiedDate.GetValueOrDefault());
						goto IL_134;
					}
					case 4:
					{
						global::System.DateTime? dateTime;
						global::System.DateTime? modifiedDate;
						if (dateTime != null != (modifiedDate != null))
						{
							num2 = (short)1508048897;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)467992582;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 5:
						num2 = (short)1587150850;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 6:
						goto IL_1BF;
					case 7:
						flag = false;
						goto IL_134;
					}
					goto IL_39;
					IL_134:
					if (!flag)
					{
						goto IL_1E4;
					}
					num2 = (short)1851457536;
					num = (int)((global::System.IntPtr)num2);
				}
				return;
				IL_1E4:
				this.SummaryEntity.ModifiedDate = value;
				this.RaisePropertyChanged(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ీⱂ⅄⹆⽈≊⡌⭎ᕐ㉒⅔㉖", a_));
				return;
				IL_39:
				num2 = (short)800189535;
				short num3 = num2;
				num2 = (short)825945183;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
				{
					IL_1BF:
					int num;
					global::System.DateTime? dateTime;
					if (dateTime == null)
					{
						num2 = (short)1606746117;
						num = (int)((global::System.IntPtr)num2);
						goto IL_13;
					}
					num2 = (short)920125440;
					short num4 = num2;
					num2 = (short)1446182915;
					num = (int)((global::System.IntPtr)num2);
					goto IL_13;
				}
				default:
				{
					num2 = (short)1638465536;
					if (num2 != 0)
					{
					}
					global::System.DateTime? dateTime = value;
					global::System.DateTime? modifiedDate = this.SummaryEntity.ModifiedDate;
					num2 = (short)950468612;
					int num = (int)((global::System.IntPtr)num2);
					goto IL_13;
				}
				}
			}
		}

		// Token: 0x17000580 RID: 1408
		// (get) Token: 0x06000BE3 RID: 3043 RVA: 0x000B2F5C File Offset: 0x000B115C
		public string DVRSHashCode
		{
			get
			{
				int a_ = 19;
				short num = (short)672453972;
				short num2 = num;
				num = (short)1812387156;
				switch (num2 == num)
				{
				}
				num = (short)1507328001;
				if (num != 0)
				{
				}
				num = (short)1998585856;
				if (num != 0)
				{
				}
				num = (short)1366294528;
				short num3 = num;
				return global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("繍⡏", a_) + this.SummaryEntity.DVRSHashCode.ToString(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ᙍ", a_));
			}
		}

		// Token: 0x17000581 RID: 1409
		// (get) Token: 0x06000BE4 RID: 3044 RVA: 0x000B3044 File Offset: 0x000B1244
		public long DVRSHashCodeLong
		{
			get
			{
				short num = (short)138280961;
				if (num != 0)
				{
				}
				num = (short)1392685228;
				short num2 = num;
				num = (short)227782828;
				switch (num2 == num)
				{
				}
				num = (short)455278592;
				if (num != 0)
				{
				}
				num = (short)2135949312;
				short num3 = num;
				return this.SummaryEntity.DVRSHashCode;
			}
		}

		// Token: 0x17000582 RID: 1410
		// (get) Token: 0x06000BE5 RID: 3045 RVA: 0x000B30FC File Offset: 0x000B12FC
		public bool? DVRSHardwareEnable
		{
			get
			{
				short num = (short)1881535466;
				short num2 = num;
				num = (short)635565034;
				switch (num2 == num)
				{
				}
				num = (short)190906369;
				if (num != 0)
				{
				}
				num = (short)633405440;
				if (num != 0)
				{
				}
				num = (short)730464256;
				short num3 = num;
				return this.SummaryEntity.DVRSHardwareEnable;
			}
		}

		// Token: 0x17000583 RID: 1411
		// (get) Token: 0x06000BE6 RID: 3046 RVA: 0x000B31B0 File Offset: 0x000B13B0
		// (set) Token: 0x06000BE7 RID: 3047 RVA: 0x000B3264 File Offset: 0x000B1464
		public global::System.Guid TemplateID
		{
			get
			{
				short num = (short)1779811762;
				short num2 = num;
				num = (short)790939058;
				switch (num2 == num)
				{
				}
				num = (short)521928704;
				if (num != 0)
				{
				}
				num = (short)1670119425;
				if (num != 0)
				{
				}
				num = (short)1755578368;
				short num3 = num;
				return this.SummaryEntity.Uuid;
			}
			set
			{
				int a_ = 15;
				short num = (short)1023720432;
				short num2 = num;
				num = (short)1820048368;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)265814017;
					if (num != 0)
					{
					}
					num = (short)1924071424;
					if (num != 0)
					{
					}
					num = (short)1746796544;
					short num3 = num;
					if (value == this.SummaryEntity.Uuid)
					{
						return;
					}
					break;
				}
				}
				this.SummaryEntity.Uuid = value;
				this.RaisePropertyChanged(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ṉ⥋⍍⁏㹑㕓≕㵗ፙᡛ", a_));
			}
		}

		// Token: 0x17000584 RID: 1412
		// (get) Token: 0x06000BE8 RID: 3048 RVA: 0x000B334C File Offset: 0x000B154C
		// (set) Token: 0x06000BE9 RID: 3049 RVA: 0x000B33FC File Offset: 0x000B15FC
		public byte[] FileContent
		{
			get
			{
				short num = (short)911114654;
				short num2 = num;
				num = (short)1762034078;
				switch (num2 == num)
				{
				}
				num = (short)291700737;
				if (num != 0)
				{
				}
				num = (short)873857024;
				if (num != 0)
				{
				}
				num = (short)2094596096;
				short num3 = num;
				return this.a;
			}
			set
			{
				int a_ = 7;
				short num = (short)592878472;
				short num2 = num;
				num = (short)1284217736;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1110245377;
					if (num != 0)
					{
					}
					num = (short)1264517120;
					if (num != 0)
					{
					}
					num = (short)660275200;
					short num3 = num;
					if (value == this.a)
					{
						return;
					}
					break;
				}
				}
				this.a = value;
				this.RaisePropertyChanged(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("сⵃ⩅ⵇॉ⍋⁍⑏㝑㩓≕", a_));
			}
		}

		// Token: 0x17000585 RID: 1413
		// (get) Token: 0x06000BEA RID: 3050 RVA: 0x000B34D8 File Offset: 0x000B16D8
		// (set) Token: 0x06000BEB RID: 3051 RVA: 0x000B358C File Offset: 0x000B178C
		public byte[] TimeStamp
		{
			get
			{
				short num = (short)401539073;
				if (num != 0)
				{
				}
				num = (short)1570612398;
				short num2 = num;
				num = (short)1477092526;
				switch (num2 == num)
				{
				}
				num = (short)1554382848;
				if (num != 0)
				{
				}
				num = (short)214237184;
				short num3 = num;
				return this.SummaryEntity.Timestamp;
			}
			set
			{
				int a_ = 15;
				short num = (short)137051039;
				short num2 = num;
				num = (short)1446198175;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1076297729;
					if (num != 0)
					{
					}
					num = (short)862584832;
					if (num != 0)
					{
					}
					num = (short)1597833216;
					short num3 = num;
					if (value == this.SummaryEntity.Timestamp)
					{
						return;
					}
					break;
				}
				}
				this.SummaryEntity.Timestamp = value;
				this.RaisePropertyChanged(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ṉ╋⍍㕏ő⁓㝕㕗⩙", a_));
			}
		}

		// Token: 0x17000586 RID: 1414
		// (get) Token: 0x06000BEC RID: 3052 RVA: 0x000B366C File Offset: 0x000B186C
		// (set) Token: 0x06000BED RID: 3053 RVA: 0x000B371C File Offset: 0x000B191C
		public string VAFiles
		{
			get
			{
				short num = (short)1247558900;
				short num2 = num;
				num = (short)2093956340;
				switch (num2 == num)
				{
				}
				num = (short)869138433;
				if (num != 0)
				{
				}
				num = (short)355008512;
				if (num != 0)
				{
				}
				num = (short)808714240;
				short num3 = num;
				return this.b;
			}
			set
			{
				switch (0)
				{
				case 0:
					goto IL_8F;
				}
				short num;
				int num3;
				for (;;)
				{
					IL_0A:
					num = (short)1222864596;
					short num2 = num;
					num = (short)1754296020;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)580911104;
						if (num != 0)
						{
						}
						num = (short)2046033921;
						if (num != 0)
						{
						}
						switch (num3)
						{
						case 0:
							if (!base.IsLoading)
							{
								num = (short)1869021186;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						case 1:
							return;
						case 2:
							goto IL_D2;
						}
						goto IL_8F;
					}
					IL_D2:
					num = (short)765788160;
					short num4 = num;
					base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase.get_VAFiles())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
					num = (short)1380188161;
					num3 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_8F:
				this.b = value;
				num = (short)537067520;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_0A;
			}
		}

		// Token: 0x17000587 RID: 1415
		// (get) Token: 0x06000BEE RID: 3054 RVA: 0x000B3874 File Offset: 0x000B1A74
		// (set) Token: 0x06000BEF RID: 3055 RVA: 0x000B3928 File Offset: 0x000B1B28
		public global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRODVRSFileDto> DVRSFiles
		{
			get
			{
				short num = (short)1297552751;
				short num2 = num;
				num = (short)997397871;
				switch (num2 == num)
				{
				}
				num = (short)907476993;
				if (num != 0)
				{
				}
				num = (short)1407909888;
				if (num != 0)
				{
				}
				num = (short)2015559680;
				short num3 = num;
				return this.c;
			}
			set
			{
				switch (0)
				{
				case 0:
					goto IL_66;
				}
				short num;
				int num3;
				for (;;)
				{
					IL_0A:
					num = (short)1278858968;
					short num2 = num;
					num = (short)819910360;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)624951296;
						if (num != 0)
						{
						}
						switch (num3)
						{
						case 0:
							if (!base.IsLoading)
							{
								num = (short)853278722;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						case 1:
							return;
						case 2:
							goto IL_D0;
						}
						goto IL_66;
					}
					IL_D0:
					num = (short)928382976;
					short num4 = num;
					base.RaisePropertyChanged<global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRODVRSFileDto>>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRODVRSFileDto>>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase.get_DVRSFiles())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
					num = (short)1446969345;
					num3 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_66:
				num = (short)1817444353;
				if (num != 0)
				{
				}
				this.c = value;
				num = (short)861667328;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_0A;
			}
		}

		// Token: 0x17000588 RID: 1416
		// (get) Token: 0x06000BF0 RID: 3056 RVA: 0x000B3A7C File Offset: 0x000B1C7C
		// (set) Token: 0x06000BF1 RID: 3057 RVA: 0x000B3B30 File Offset: 0x000B1D30
		public int VATotalCount
		{
			get
			{
				short num = (short)908359271;
				short num2 = num;
				num = (short)1235973735;
				switch (num2 == num)
				{
				}
				num = (short)122486785;
				if (num != 0)
				{
				}
				num = (short)882507776;
				if (num != 0)
				{
				}
				num = (short)641073152;
				short num3 = num;
				return this.SummaryEntity.VATotalCount;
			}
			set
			{
				short num = (short)833486848;
				short num2 = num;
				num = (short)1631261350;
				short num3 = num;
				num = (short)1228083878;
				int num4;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_18B:
					base.RaisePropertyChanged<int>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<int>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase.get_VATotalCount())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
					num = (short)510394371;
					num4 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)1792868352;
					if (num != 0)
					{
					}
					num = (short)1588920320;
					num4 = (int)((global::System.IntPtr)num);
					break;
				}
				for (;;)
				{
					switch (num4)
					{
					case 0:
						num = (short)608894977;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_D1;
						}
						continue;
					case 1:
						return;
					case 2:
						goto IL_18B;
					case 3:
						return;
					case 4:
						if (!base.IsLoading)
						{
							num = (short)1391001602;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					IL_D1:
					if (value == this.SummaryEntity.VATotalCount)
					{
						num = (short)1903165441;
						num4 = (int)((global::System.IntPtr)num);
					}
					else
					{
						this.SummaryEntity.VATotalCount = value;
						num = (short)1029570564;
						num4 = (int)((global::System.IntPtr)num);
					}
				}
			}
		}

		// Token: 0x17000589 RID: 1417
		// (get) Token: 0x06000BF2 RID: 3058 RVA: 0x000B3CD0 File Offset: 0x000B1ED0
		// (set) Token: 0x06000BF3 RID: 3059 RVA: 0x000B3D84 File Offset: 0x000B1F84
		public global::System.Guid FileUuid
		{
			get
			{
				short num = (short)475922432;
				short num2 = num;
				num = (short)793466629;
				short num3 = num;
				num = (short)1240553221;
				switch (num3 == num)
				{
				}
				num = (short)1924333569;
				if (num != 0)
				{
				}
				num = (short)1131479040;
				if (num != 0)
				{
				}
				return this.SummaryEntity.FileUuid;
			}
			set
			{
				short num = (short)328007680;
				short num2 = num;
				num = (short)1258906630;
				short num3 = num;
				num = (short)843801606;
				int num4;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_194:
					base.RaisePropertyChanged<global::System.Guid>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::System.Guid>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase.get_FileUuid())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
					num = (short)1049755651;
					num4 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)1512308736;
					if (num != 0)
					{
					}
					num = (short)1458176000;
					num4 = (int)((global::System.IntPtr)num);
					break;
				}
				for (;;)
				{
					switch (num4)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_AE;
						}
						continue;
					case 1:
						num = (short)584646657;
						if (num != 0)
						{
						}
						this.SummaryEntity.FileUuid = value;
						num = (short)1375404036;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_194;
					case 3:
						return;
					case 4:
						if (!base.IsLoading)
						{
							num = (short)510590978;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					IL_AE:
					if (!(value != this.SummaryEntity.FileUuid))
					{
						break;
					}
					num = (short)1205075969;
					num4 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x1700058A RID: 1418
		// (get) Token: 0x06000BF4 RID: 3060 RVA: 0x000B3F2C File Offset: 0x000B212C
		// (set) Token: 0x06000BF5 RID: 3061 RVA: 0x000B3FD8 File Offset: 0x000B21D8
		public string VaFilesTotalSize
		{
			get
			{
				short num = (short)597426176;
				short num2 = num;
				num = (short)832509938;
				short num3 = num;
				num = (short)458627058;
				switch (num3 == num)
				{
				}
				num = (short)520617985;
				if (num != 0)
				{
				}
				num = (short)48627712;
				if (num != 0)
				{
				}
				return this.g;
			}
			set
			{
				short num = (short)1304559616;
				short num2 = num;
				switch (0)
				{
				case 0:
					goto IL_8F;
				}
				int num4;
				for (;;)
				{
					IL_34:
					num = (short)1920816786;
					short num3 = num;
					num = (short)1280923282;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
						num = (short)2037776384;
						if (num != 0)
						{
						}
						switch (num4)
						{
						case 0:
							if (!base.IsLoading)
							{
								num = (short)2020802561;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						case 1:
							num = (short)1447428097;
							if (num != 0)
							{
							}
							base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase.get_VaFilesTotalSize())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
							num = (short)404946946;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							return;
						}
						goto IL_8F;
					}
				}
				return;
				IL_8F:
				this.g = value;
				num = (short)1731395584;
				num4 = (int)((global::System.IntPtr)num);
				goto IL_34;
			}
		}

		// Token: 0x1700058B RID: 1419
		// (get) Token: 0x06000BF6 RID: 3062 RVA: 0x000B412C File Offset: 0x000B232C
		// (set) Token: 0x06000BF7 RID: 3063 RVA: 0x000B41DC File Offset: 0x000B23DC
		public string LpFilesTotalSize
		{
			get
			{
				short num = (short)874381312;
				short num2 = num;
				num = (short)415514413;
				short num3 = num;
				num = (short)1708932909;
				switch (num3 == num)
				{
				}
				num = (short)564330496;
				if (num != 0)
				{
				}
				num = (short)1176305665;
				if (num != 0)
				{
				}
				return this.f;
			}
			set
			{
				short num = (short)190119936;
				short num2 = num;
				switch (0)
				{
				case 0:
					goto IL_8F;
				}
				int num4;
				for (;;)
				{
					IL_33:
					num = (short)1041367217;
					short num3 = num;
					num = (short)1540686001;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_117;
					default:
						num = (short)1306198016;
						if (num != 0)
						{
						}
						switch (num4)
						{
						case 0:
							if (!base.IsLoading)
							{
								num = (short)74514433;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_119;
						case 1:
							base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase.get_LpFilesTotalSize())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
							num = (short)930545666;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_117;
						}
						goto IL_8F;
					}
				}
				IL_117:
				IL_119:
				num = (short)163053569;
				if (num != 0)
				{
				}
				return;
				IL_8F:
				this.f = value;
				num = (short)855703552;
				num4 = (int)((global::System.IntPtr)num);
				goto IL_33;
			}
		}

		// Token: 0x1700058C RID: 1420
		// (get) Token: 0x06000BF8 RID: 3064 RVA: 0x000B432C File Offset: 0x000B252C
		// (set) Token: 0x06000BF9 RID: 3065 RVA: 0x000B43DC File Offset: 0x000B25DC
		public string LanguagePacksInfo
		{
			get
			{
				short num = (short)929038336;
				short num2 = num;
				num = (short)1884257929;
				short num3 = num;
				num = (short)333217417;
				switch (num3 == num)
				{
				}
				num = (short)1237909505;
				if (num != 0)
				{
				}
				num = (short)690683904;
				if (num != 0)
				{
				}
				return this.e;
			}
			set
			{
				short num = (short)1451753472;
				short num2 = num;
				switch (0)
				{
				case 0:
					goto IL_B4;
				}
				int num4;
				for (;;)
				{
					IL_32:
					num = (short)1873293941;
					short num3 = num;
					num = (short)691024501;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
						num = (short)383451136;
						if (num != 0)
						{
						}
						num = (short)1572667393;
						if (num != 0)
						{
						}
						switch (num4)
						{
						case 0:
							if (!base.IsLoading)
							{
								num = (short)509280257;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						case 1:
							base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase.get_LanguagePacksInfo())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
							num = (short)283443202;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							return;
						}
						goto IL_B4;
					}
				}
				return;
				IL_B4:
				this.e = value;
				num = (short)696320000;
				num4 = (int)((global::System.IntPtr)num);
				goto IL_32;
			}
		}

		// Token: 0x1700058D RID: 1421
		// (get) Token: 0x06000BFA RID: 3066 RVA: 0x000B452C File Offset: 0x000B272C
		// (set) Token: 0x06000BFB RID: 3067 RVA: 0x000B45E0 File Offset: 0x000B27E0
		public string LPError
		{
			get
			{
				short num = (short)1836908544;
				short num2 = num;
				num = (short)1721518400;
				short num3 = num;
				num = (short)1461602624;
				switch (num3 == num)
				{
				}
				num = (short)1233846273;
				if (num != 0)
				{
				}
				num = (short)69926912;
				if (num != 0)
				{
				}
				return this.h;
			}
			set
			{
				short num = (short)708575232;
				short num2 = num;
				switch (0)
				{
				case 0:
					goto IL_B8;
				}
				int num4;
				for (;;)
				{
					IL_34:
					num = (short)856960419;
					short num3 = num;
					num = (short)2145201571;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
						num = (short)1610874880;
						if (num != 0)
						{
						}
						num = (short)1519321089;
						if (num != 0)
						{
						}
						switch (num4)
						{
						case 0:
							if (!base.IsLoading)
							{
								num = (short)1842806785;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						case 1:
							base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase.get_LPError())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
							num = (short)12320770;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							return;
						}
						goto IL_B8;
					}
				}
				return;
				IL_B8:
				this.h = value;
				num = (short)756875264;
				num4 = (int)((global::System.IntPtr)num);
				goto IL_34;
			}
		}

		// Token: 0x1700058E RID: 1422
		// (get) Token: 0x06000BFC RID: 3068 RVA: 0x000B4738 File Offset: 0x000B2938
		// (set) Token: 0x06000BFD RID: 3069 RVA: 0x000B47E8 File Offset: 0x000B29E8
		public string DVRSFileError
		{
			get
			{
				short num = (short)1577844736;
				short num2 = num;
				num = (short)563284911;
				short num3 = num;
				num = (short)1076431791;
				switch (num3 == num)
				{
				}
				num = (short)1201471489;
				if (num != 0)
				{
				}
				num = (short)2129526784;
				if (num != 0)
				{
				}
				return this.i;
			}
			set
			{
				short num = (short)564854784;
				short num2 = num;
				switch (0)
				{
				case 0:
					goto IL_B7;
				}
				int num4;
				for (;;)
				{
					IL_32:
					num = (short)1779892225;
					if (num != 0)
					{
					}
					num = (short)825204475;
					short num3 = num;
					num = (short)1173790459;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
						num = (short)1861812224;
						if (num != 0)
						{
						}
						switch (num4)
						{
						case 0:
							if (!base.IsLoading)
							{
								num = (short)1943273473;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						case 1:
							base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase.get_DVRSFileError())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
							num = (short)1325727746;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							return;
						}
						goto IL_B7;
					}
				}
				return;
				IL_B7:
				this.i = value;
				num = (short)41680896;
				num4 = (int)((global::System.IntPtr)num);
				goto IL_32;
			}
		}

		// Token: 0x1700058F RID: 1423
		// (get) Token: 0x06000BFE RID: 3070 RVA: 0x000B493C File Offset: 0x000B2B3C
		protected global::Motorola.CommonCPS.Server.EntityModel.TemplateSummary SummaryEntity
		{
			get
			{
				short num = (short)1294860288;
				short num2 = num;
				num = (short)1955135489;
				if (num != 0)
				{
				}
				num = (short)1650421688;
				short num3 = num;
				num = (short)726495160;
				switch (num3 == num)
				{
				}
				num = (short)61276160;
				if (num != 0)
				{
				}
				return base.Entity;
			}
		}

		// Token: 0x17000590 RID: 1424
		public override string this[string propertyName]
		{
			get
			{
				int a_ = 19;
				short num = (short)1961295872;
				short num2 = num;
				num = (short)849424903;
				short num3 = num;
				num = (short)1341534727;
				int num4;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)2070544385;
					if (num != 0)
					{
					}
					num = (short)185270272;
					if (num != 0)
					{
					}
					num = (short)1063583744;
					num4 = (int)((global::System.IntPtr)num);
					break;
				}
				for (;;)
				{
					switch (num4)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_D7;
						}
						continue;
					case 1:
						if (!base.Validate(this.LPError))
						{
							num = (short)793509891;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_104;
					case 2:
						num = (short)497352705;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_14A;
					}
					IL_D7:
					if (!(propertyName == global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ɍㅏ㱑㍓⍕㥗㵙㥛๝şšལᕥⅧѩ੫ŭ", a_)))
					{
						goto IL_14C;
					}
					num = (short)99418114;
					num4 = (int)((global::System.IntPtr)num);
				}
				IL_104:
				return string.Empty;
				IL_14A:
				return base.Error;
				IL_14C:
				return string.Empty;
			}
		}

		// Token: 0x06000C00 RID: 3072 RVA: 0x000B4B48 File Offset: 0x000B2D48
		public override bool Equals(object obj)
		{
			bool result;
			for (;;)
			{
				IL_00:
				switch (0)
				{
				case 0:
					goto IL_38;
				}
				int num;
				short num2;
				for (;;)
				{
					IL_0A:
					bool flag;
					switch (num)
					{
					case 0:
						flag = false;
						goto IL_187;
					case 1:
					{
						global::System.Guid? id = (obj as global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase).ID;
						global::System.Guid? id2 = this.ID;
						num2 = (short)1802567688;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 2:
					{
						num2 = (short)1848180737;
						if (num2 != 0)
						{
						}
						global::System.Guid? id;
						global::System.Guid? id2;
						flag = (id.GetValueOrDefault() == id2.GetValueOrDefault());
						goto IL_187;
					}
					case 3:
						num2 = (short)1528758276;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 4:
						flag = true;
						goto IL_187;
					case 5:
						if (obj is global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase)
						{
							num2 = (short)979697664;
							short num3 = num2;
							num2 = (short)1124663297;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					case 6:
					{
						global::System.Guid? id;
						if (id == null)
						{
							num2 = (short)596770819;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)2002124802;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 7:
					{
						num2 = (short)273789411;
						short num4 = num2;
						num2 = (short)1510584803;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num2 = (short)349831168;
							if (num2 != 0)
							{
							}
							num2 = (short)939786240;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 8:
					{
						global::System.Guid? id;
						global::System.Guid? id2;
						if (id != null != (id2 != null))
						{
							num2 = (short)434503687;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)2061172742;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 9:
						return result;
					}
					break;
					IL_187:
					result = flag;
					num2 = (short)1267859465;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_38:
				result = false;
				num2 = (short)35979269;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			return result;
		}

		// Token: 0x06000C01 RID: 3073 RVA: 0x000B4D84 File Offset: 0x000B2F84
		public override int GetHashCode()
		{
			short num = (short)327024640;
			short num2 = num;
			num = (short)837549115;
			short num3 = num;
			num = (short)2078866491;
			switch (num3 == num)
			{
			}
			num = (short)1710424065;
			if (num != 0)
			{
			}
			num = (short)1999175680;
			if (num != 0)
			{
			}
			return base.GetHashCode();
		}

		// Token: 0x06000C02 RID: 3074 RVA: 0x000B4E34 File Offset: 0x000B3034
		public override string ToString()
		{
			short num = (short)1379467264;
			short num2 = num;
			num = (short)285285134;
			short num3 = num;
			num = (short)1713052430;
			switch (num3 == num)
			{
			}
			num = (short)1330577408;
			if (num != 0)
			{
			}
			num = (short)1489502209;
			if (num != 0)
			{
			}
			return this.Name;
		}

		// Token: 0x04000433 RID: 1075
		private byte[] a;

		// Token: 0x04000434 RID: 1076
		private string b;

		// Token: 0x04000435 RID: 1077
		private global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRODVRSFileDto> c;

		// Token: 0x04000436 RID: 1078
		private global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRODVRSFileDto d;

		// Token: 0x04000437 RID: 1079
		private string e;

		// Token: 0x04000438 RID: 1080
		private string f;

		// Token: 0x04000439 RID: 1081
		private string g;

		// Token: 0x0400043A RID: 1082
		private string h;

		// Token: 0x0400043B RID: 1083
		private string i;
	}
}
