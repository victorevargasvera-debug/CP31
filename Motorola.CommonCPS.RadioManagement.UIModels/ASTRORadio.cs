using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using Motorola.CommonCPS.RadioManagement.CommonBase;
using Motorola.CommonCPS.RadioManagement.CommonBase.Utility;
using Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;
using Motorola.CommonCPS.Server.EntityModel.GenericModel;
using RFResourceRepository;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x020000C5 RID: 197
	public class ASTRORadio : global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase
	{
		// Token: 0x060007AC RID: 1964 RVA: 0x00070328 File Offset: 0x0006E528
		public ASTRORadio()
		{
			int a_ = 6;
			base..ctor(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("@၂ᅄᕆو", a_), new global::Motorola.CommonCPS.Server.EntityModel.ASTRORadioSummary());
		}

		// Token: 0x060007AD RID: 1965 RVA: 0x00070358 File Offset: 0x0006E558
		public ASTRORadio(global::Motorola.CommonCPS.Server.EntityModel.ASTRORadioSummary radioSummary)
		{
			int a_ = 1;
			base..ctor(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("紻洽ᐿ၁ୃ", a_), radioSummary ?? new global::Motorola.CommonCPS.Server.EntityModel.ASTRORadioSummary());
		}

		// Token: 0x060007AE RID: 1966 RVA: 0x00070390 File Offset: 0x0006E590
		protected ASTRORadio(string deviceIdentifier, global::Motorola.CommonCPS.Server.EntityModel.ASTRORadioSummary radioSummary) : base(deviceIdentifier, radioSummary ?? new global::Motorola.CommonCPS.Server.EntityModel.ASTRORadioSummary())
		{
		}

		// Token: 0x17000394 RID: 916
		// (get) Token: 0x060007AF RID: 1967 RVA: 0x000703B4 File Offset: 0x0006E5B4
		// (set) Token: 0x060007B0 RID: 1968 RVA: 0x00070464 File Offset: 0x0006E664
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadioLicense> LicensedFeatureList
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1588262189;
				short num2 = num;
				num = (short)423359789;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1942618112;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)820576256;
				if (num != 0)
				{
				}
				num = (short)326369281;
				if (num != 0)
				{
				}
				return this.h;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1344543011;
				short num2 = num;
				num = (short)2144999715;
				switch (num2 == num)
				{
				default:
				{
					num = (short)657719296;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1304821761;
				if (num != 0)
				{
				}
				num = (short)712310784;
				if (num != 0)
				{
				}
				this.h = value;
			}
		}

		// Token: 0x17000395 RID: 917
		// (get) Token: 0x060007B1 RID: 1969 RVA: 0x00070514 File Offset: 0x0006E714
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public string DeviceInfoFields
		{
			get
			{
				short num = (short)708129954;
				short num2 = num;
				num = (short)1955869858;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1814233088;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)647888896;
				if (num != 0)
				{
				}
				num = (short)1732968449;
				if (num != 0)
				{
				}
				return this.ApxRadioSummaryEntity.DeviceInfoFields;
			}
		}

		// Token: 0x17000396 RID: 918
		// (get) Token: 0x060007B2 RID: 1970 RVA: 0x000705CC File Offset: 0x0006E7CC
		// (set) Token: 0x060007B3 RID: 1971 RVA: 0x00070684 File Offset: 0x0006E884
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public bool AskRequired
		{
			get
			{
				short num = (short)864114532;
				short num2 = num;
				num = (short)711087972;
				switch (num2 == num)
				{
				default:
				{
					num = (short)165085184;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)993394688;
				if (num != 0)
				{
				}
				num = (short)479657985;
				if (num != 0)
				{
				}
				return this.ApxRadioSummaryEntity.AskRequired.GetValueOrDefault();
			}
			set
			{
				short num = (short)707799181;
				short num2 = num;
				num = (short)1226844301;
				int num3;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1816985600;
					if (num != 0)
					{
					}
					num = (short)80478208;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
				for (;;)
				{
					switch (num3)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_7B;
						}
						continue;
					case 1:
						this.ApxRadioSummaryEntity.AskRequired = new bool?(value);
						base.RaisePropertyChanged<bool>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio.get_AskRequired())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						base.RaisePropertyChanged<bool>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio.get_AppIsAskRequired())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)764739586;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_16C;
					}
					IL_7B:
					num = (short)819986433;
					if (num != 0)
					{
					}
					bool? askRequired = this.ApxRadioSummaryEntity.AskRequired;
					if (value == askRequired.GetValueOrDefault() & askRequired != null)
					{
						return;
					}
					num = (short)508887041;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_16C:
				num = (short)440729600;
				short num4 = num;
			}
		}

		// Token: 0x17000397 RID: 919
		// (get) Token: 0x060007B4 RID: 1972 RVA: 0x0007082C File Offset: 0x0006EA2C
		// (set) Token: 0x060007B5 RID: 1973 RVA: 0x00070B7C File Offset: 0x0006ED7C
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.EntitytMemberName("TuningVersion")]
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public string TuningVersion
		{
			get
			{
				int a_ = 5;
				int num;
				short num2;
				global::Motorola.CommonCPS.Server.EntityModel.GenericModel.MultipleFieldsXML multipleFieldsXML;
				switch (0)
				{
				case 0:
					break;
				default:
				{
					global::System.Collections.Generic.Dictionary<string, object> dictionary;
					for (;;)
					{
						IL_13:
						switch (num)
						{
						case 0:
							num2 = (short)333971457;
							if (num2 != 0)
							{
							}
							if (multipleFieldsXML.ConvertToDictionary()[global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ሿ⍁⁃ཅ♇ⱉ⍋्㕏㱑ㅓ⑕㥗㙙࡛⭝๟ୡ੣ť㹧ཀྵṫᵭ᥯ᵱᩳ⥵㥷䍹䥻乽륿", a_)] != null)
							{
								num2 = (short)961609735;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							goto IL_139;
						case 1:
							num2 = (short)529399811;
							num = (int)((global::System.IntPtr)num2);
							continue;
						case 2:
							if (string.IsNullOrEmpty(dictionary[global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ሿ⍁⁃ཅ♇ⱉ⍋्㕏㱑ㅓ⑕㥗㙙࡛⭝๟ୡ੣ť㹧ཀྵṫᵭ᥯ᵱᩳ⥵㥷䍹䥻乽륿", a_)].ToString()))
							{
								num2 = (short)279969803;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							goto IL_328;
						case 3:
							if (multipleFieldsXML.ConvertToDictionary() != null)
							{
								num2 = (short)1545076748;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							goto IL_139;
						case 4:
							if (multipleFieldsXML != null)
							{
								num2 = (short)1672151041;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							goto IL_139;
						case 5:
							if (multipleFieldsXML.ConvertToDictionary().ContainsKey(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ሿ⍁⁃ཅ♇ⱉ⍋्㕏㱑ㅓ⑕㥗㙙࡛⭝๟ୡ੣ť㹧ཀྵṫᵭ᥯ᵱᩳ⥵㥷䍹䥻乽륿", a_)))
							{
								num2 = (short)1984626696;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							goto IL_139;
						case 6:
							num2 = (short)630390786;
							num = (int)((global::System.IntPtr)num2);
							continue;
						case 7:
						{
							num2 = (short)208601088;
							short num3 = num2;
							num2 = (short)1282342925;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						case 8:
							num2 = (short)1450377216;
							num = (int)((global::System.IntPtr)num2);
							continue;
						case 9:
							goto IL_2A9;
						case 10:
						{
							if (dictionary[global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ሿ⍁⁃ཅ♇ⱉ⍋्㕏㱑ㅓ⑕㥗㙙࡛⭝๟ୡ੣ť㹧ཀྵṫᵭ᥯ᵱᩳ⥵㥷䍹䥻乽륿", a_)] == null)
							{
								goto IL_18D;
							}
							num2 = (short)111089631;
							short num4 = num2;
							num2 = (short)63313887;
							switch ((num4 == num2) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_62;
							default:
								num2 = (short)594870272;
								if (num2 != 0)
								{
								}
								num2 = (short)1493041158;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							break;
						}
						case 11:
							goto IL_220;
						case 12:
							num2 = (short)770244613;
							num = (int)((global::System.IntPtr)num2);
							continue;
						case 13:
							if (string.IsNullOrEmpty(multipleFieldsXML.ConvertToDictionary()[global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ሿ⍁⁃ཅ♇ⱉ⍋्㕏㱑ㅓ⑕㥗㙙࡛⭝๟ୡ੣ť㹧ཀྵṫᵭ᥯ᵱᩳ⥵㥷䍹䥻乽륿", a_)].ToString()))
							{
								num2 = (short)922550281;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							dictionary = multipleFieldsXML.ConvertToDictionary();
							num2 = (short)214958090;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_51;
					}
					IL_139:
					return string.Empty;
					IL_18D:
					return string.Empty;
					IL_220:
					goto IL_18D;
					IL_2A9:
					goto IL_139;
					IL_328:
					return dictionary[global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ሿ⍁⁃ཅ♇ⱉ⍋्㕏㱑ㅓ⑕㥗㙙࡛⭝๟ୡ੣ť㹧ཀྵṫᵭ᥯ᵱᩳ⥵㥷䍹䥻乽륿", a_)].ToString();
				}
				}
				IL_51:
				multipleFieldsXML = global::Motorola.CommonCPS.Server.EntityModel.GenericModel.MultipleFieldsXML.DeserializeFromXML(this.ApxRadioSummaryEntity.DeviceInfoFields);
				IL_62:
				num2 = (short)1857617924;
				num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			set
			{
				int a_ = 16;
				for (;;)
				{
					IL_09:
					short num = (short)873725952;
					int num2 = (int)num;
					switch (num2)
					{
					default:
					{
						switch (0)
						{
						case 0:
							goto IL_51;
						}
						global::Motorola.CommonCPS.Server.EntityModel.GenericModel.MultipleFieldsXML multipleFieldsXML;
						for (;;)
						{
							IL_32:
							switch (num2)
							{
							case 0:
								if (!base.IsLoading)
								{
									num = (short)649986052;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								return;
							case 1:
								return;
							case 2:
							{
								if (multipleFieldsXML == null)
								{
									num = (short)629407745;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.GenericModel.NameAndValue> nameAndValueList = multipleFieldsXML.NameAndValueList;
								global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.GenericModel.NameAndValue>.Enumerator enumerator = nameAndValueList.GetEnumerator();
								num = (short)178597284;
								short num3 = num;
								num = (short)927739300;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_09;
								default:
									num = (short)967966721;
									if (num != 0)
									{
									}
									num = (short)1455554560;
									if (num != 0)
									{
									}
									num = (short)775553027;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 3:
								try
								{
									num = (short)1789853699;
									num2 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										switch (num2)
										{
										case 0:
										{
											global::Motorola.CommonCPS.Server.EntityModel.GenericModel.NameAndValue nameAndValue;
											if (nameAndValue.Name == global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("᥊ⱌ⭎ᡐ㵒㍔㡖Ṙ㹚㍜㩞፠ɢ।㍦ᱨժѬŮᙰ╲ၴն੸ቺቼᅾ\ude80슂버늆릈늊", a_))
											{
												num = (short)116391942;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											break;
										}
										case 1:
										{
											global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.GenericModel.NameAndValue>.Enumerator enumerator;
											if (!enumerator.MoveNext())
											{
												num = (short)739770370;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											global::Motorola.CommonCPS.Server.EntityModel.GenericModel.NameAndValue nameAndValue = enumerator.Current;
											num = (short)1138819072;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 2:
											num = (short)1931804676;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 3:
											switch (0)
											{
											case 0:
												goto IL_148;
											}
											continue;
										case 4:
											goto IL_214;
										case 5:
											goto IL_19D;
										case 6:
										{
											global::Motorola.CommonCPS.Server.EntityModel.GenericModel.NameAndValue nameAndValue;
											nameAndValue.Value = value;
											num = (short)930611205;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										}
										IL_14A:
										num = (short)1800142849;
										num2 = (int)((global::System.IntPtr)num);
										continue;
										IL_148:
										goto IL_14A;
									}
									IL_19D:
									IL_214:
									goto IL_C4;
								}
								finally
								{
									global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.GenericModel.NameAndValue>.Enumerator enumerator;
									((global::System.IDisposable)enumerator).Dispose();
								}
								return;
								IL_C4:
								num = (short)94109696;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
								base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio.get_TuningVersion())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
								num = (short)1470562309;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 5:
								return;
							}
							break;
						}
						IL_51:
						multipleFieldsXML = global::Motorola.CommonCPS.Server.EntityModel.GenericModel.MultipleFieldsXML.DeserializeFromXML(this.ApxRadioSummaryEntity.DeviceInfoFields);
						num = (short)135528448;
						short num4 = num;
						num = (short)1729757186;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_32;
					}
					}
				}
			}
		}

		// Token: 0x17000398 RID: 920
		// (get) Token: 0x060007B6 RID: 1974 RVA: 0x00070EC0 File Offset: 0x0006F0C0
		// (set) Token: 0x060007B7 RID: 1975 RVA: 0x00071038 File Offset: 0x0006F238
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.EntitytMemberName("BluetoothDUNSubscriberIP")]
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public string BluetoothDUNSubscriberIPForGUI
		{
			get
			{
				int a_ = 18;
				short num = (short)731447298;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)350617600;
					short num3 = num;
					switch (num2)
					{
					case 0:
					{
						num = (short)1730810855;
						short num4 = num;
						num = (short)1942098919;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1D;
						default:
							goto IL_C1;
						}
						break;
					}
					case 1:
						goto IL_87;
					case 2:
						goto IL_1D;
					case 3:
						if (this.BluetoothDUNSubscriberIP != null)
						{
							num = (short)543817728;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_169;
					}
					goto IL_66;
					IL_1D:
					switch (0)
					{
					case 0:
						IL_66:
						if (base.SuppressIPConvert)
						{
							num = (short)1459224577;
							num2 = (int)((global::System.IntPtr)num);
						}
						else
						{
							num = (short)42663937;
							if (num != 0)
							{
							}
							num = (short)1857945603;
							num2 = (int)((global::System.IntPtr)num);
						}
						break;
					}
				}
				IL_87:
				return this.BluetoothDUNSubscriberIP;
				IL_C1:
				num = (short)427360256;
				if (num != 0)
				{
				}
				return this.BluetoothDUNSubscriberIP.Replace(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("捌", a_), global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("恌", a_));
				IL_169:
				return null;
			}
			set
			{
				int a_ = 12;
				short num = (short)759758848;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_4D;
						}
						continue;
					case 1:
						this.BluetoothDUNSubscriberIP = (string.IsNullOrWhiteSpace(value) ? string.Empty : value);
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio.get_BluetoothDUNSubscriberIP())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio.get_BluetoothDUNSubscriberIPForGUI())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)2028994562;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_1C2;
					case 3:
						goto IL_ED;
					case 4:
						value = value.Replace(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("橆", a_), global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("楆", a_));
						num = (short)1818558470;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						num = (short)111149057;
						if (num != 0)
						{
						}
						num = (short)617873409;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						goto IL_ED;
					case 7:
						if (value != this.BluetoothDUNSubscriberIP)
						{
							num = (short)1801912325;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					IL_4D:
					if (value != null)
					{
						num = (short)319881220;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					value = string.Empty;
					num = (short)1364460101;
					short num3 = num;
					num = (short)1289814597;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num = (short)151126016;
						if (num != 0)
						{
						}
						num = (short)519700483;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_ED:
					num = (short)1263271943;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1C2:
				num = (short)16973824;
				short num4 = num;
			}
		}

		// Token: 0x17000399 RID: 921
		// (get) Token: 0x060007B8 RID: 1976 RVA: 0x000712A0 File Offset: 0x0006F4A0
		// (set) Token: 0x060007B9 RID: 1977 RVA: 0x00071354 File Offset: 0x0006F554
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify("IsBluetoothDUNSubscriberIPEditable", 1, true)]
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.EntitytMemberName("BluetoothDUNSubscriberIP")]
		public string BluetoothDUNSubscriberIP
		{
			get
			{
				short num = (short)646523897;
				short num2 = num;
				num = (short)168176633;
				switch (num2 == num)
				{
				}
				num = (short)1807876097;
				if (num != 0)
				{
				}
				num = (short)1454768128;
				if (num != 0)
				{
				}
				num = (short)1017577472;
				short num3 = num;
				return this.ApxRadioSummaryEntity.BluetoothDUNSubscriberIP;
			}
			set
			{
				short num;
				for (;;)
				{
					num = (short)1743192065;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_10E;
						case 1:
							num = (short)908525569;
							if (num != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_57;
							}
							continue;
						case 2:
							goto IL_81;
						}
						IL_57:
						if (value == this.ApxRadioSummaryEntity.BluetoothDUNSubscriberIP)
						{
							num = (short)1154547714;
							num2 = (int)((global::System.IntPtr)num);
						}
						else
						{
							num = (short)906297344;
							num2 = (int)((global::System.IntPtr)num);
						}
					}
					IL_81:
					num = (short)201064448;
					short num3 = num;
					num = (short)1551760873;
					short num4 = num;
					num = (short)2102328809;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_E0;
					}
				}
				IL_E0:
				num = (short)590282752;
				if (num != 0)
				{
				}
				return;
				IL_10E:
				this.ApxRadioSummaryEntity.BluetoothDUNSubscriberIP = (string.IsNullOrWhiteSpace(value) ? string.Empty : value);
				base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio.get_BluetoothDUNSubscriberIP())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
				base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio.get_BluetoothDUNSubscriberIPForGUI())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
			}
		}

		// Token: 0x1700039A RID: 922
		// (get) Token: 0x060007BA RID: 1978 RVA: 0x000714F8 File Offset: 0x0006F6F8
		// (set) Token: 0x060007BB RID: 1979 RVA: 0x000715A8 File Offset: 0x0006F7A8
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public string PassWord
		{
			get
			{
				short num = (short)931888784;
				short num2 = num;
				num = (short)23363216;
				switch (num2 == num)
				{
				}
				num = (short)1711603713;
				if (num != 0)
				{
				}
				num = (short)1601634304;
				if (num != 0)
				{
				}
				num = (short)969211904;
				short num3 = num;
				return this.c;
			}
			set
			{
				short num = (short)1356070913;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						return;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_31;
						}
						continue;
					case 2:
					{
						num = (short)731139863;
						short num3 = num;
						num = (short)144723735;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
						{
							num = (short)222035968;
							short num4 = num;
							num = (short)410124288;
							if (num != 0)
							{
							}
							this.c = value;
							base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio.get_PassWord())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
							num = (short)153288705;
							if (num != 0)
							{
							}
							num = (short)1534656512;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					}
					IL_31:
					if (!(value != this.c))
					{
						break;
					}
					num = (short)1509818370;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x1700039B RID: 923
		// (get) Token: 0x060007BC RID: 1980 RVA: 0x000716FC File Offset: 0x0006F8FC
		// (set) Token: 0x060007BD RID: 1981 RVA: 0x00071878 File Offset: 0x0006FA78
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.EntitytMemberName("BluetoothDUNPeerIP")]
		public string BluetoothDUNPeerIPForGUI
		{
			get
			{
				int a_ = 17;
				short num = (short)1352531970;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)1847197696;
					short num3 = num;
					switch (num2)
					{
					case 0:
					{
						num = (short)1943118882;
						short num4 = num;
						num = (short)1951441954;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1E;
						default:
							goto IL_C4;
						}
						break;
					}
					case 1:
						goto IL_88;
					case 2:
						goto IL_1E;
					case 3:
						if (this.BluetoothDUNPeerIP != null)
						{
							num = (short)1846870016;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_16E;
					}
					goto IL_67;
					IL_1E:
					switch (0)
					{
					case 0:
						IL_67:
						if (base.SuppressIPConvert)
						{
							num = (short)237961217;
							num2 = (int)((global::System.IntPtr)num);
						}
						else
						{
							num = (short)683409409;
							if (num != 0)
							{
							}
							num = (short)1952841731;
							num2 = (int)((global::System.IntPtr)num);
						}
						break;
					}
				}
				IL_88:
				return this.BluetoothDUNPeerIP;
				IL_C4:
				num = (short)681443328;
				if (num != 0)
				{
				}
				return this.BluetoothDUNPeerIP.Replace(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("手", a_), global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("態", a_));
				IL_16E:
				return null;
			}
			set
			{
				int a_ = 10;
				short num = (short)841482242;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)121488890;
					short num3 = num;
					num = (short)388351482;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
					{
						num = (short)2117730304;
						if (num != 0)
						{
						}
						string text;
						switch (num2)
						{
						case 0:
							goto IL_CC;
						case 1:
							num = (short)747044865;
							if (num != 0)
							{
							}
							text = value.Replace(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("桄", a_), global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("歄", a_));
							goto IL_168;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_94;
							}
							continue;
						case 3:
						{
							num = (short)105840640;
							short num4 = num;
							if (value == this.BluetoothDUNPeerIP)
							{
								num = (short)940769284;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1813053440;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
							goto IL_1D2;
						case 5:
							num = (short)670695430;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							text = string.Empty;
							goto IL_168;
						}
						IL_94:
						if (value == null)
						{
							num = (short)2127364101;
							num2 = (int)((global::System.IntPtr)num);
							break;
						}
						num = (short)136183809;
						num2 = (int)((global::System.IntPtr)num);
						break;
						IL_168:
						value = text;
						num = (short)1841889283;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					}
				}
				IL_CC:
				this.BluetoothDUNPeerIP = (string.IsNullOrWhiteSpace(value) ? string.Empty : value);
				base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio.get_BluetoothDUNPeerIP())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
				base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio.get_BluetoothDUNPeerIPForGUI())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
				return;
				IL_1D2:;
			}
		}

		// Token: 0x1700039C RID: 924
		// (get) Token: 0x060007BE RID: 1982 RVA: 0x00071ACC File Offset: 0x0006FCCC
		// (set) Token: 0x060007BF RID: 1983 RVA: 0x00071B80 File Offset: 0x0006FD80
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify("IsBluetoothDUNPeerIPEditable", 2, true)]
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.EntitytMemberName("BluetoothDUNPeerIP")]
		public string BluetoothDUNPeerIP
		{
			get
			{
				short num = (short)924712448;
				short num2 = num;
				num = (short)1131675136;
				switch (num2 == num)
				{
				}
				num = (short)1587019776;
				short num3 = num;
				num = (short)495845377;
				if (num != 0)
				{
				}
				num = (short)703922176;
				if (num != 0)
				{
				}
				return this.ApxRadioSummaryEntity.BluetoothDUNPeerIP;
			}
			set
			{
				short num = (short)1514864641;
				if (num != 0)
				{
				}
				num = (short)2023489536;
				short num2 = num;
				num = (short)647495680;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
					{
						num = (short)294037770;
						short num4 = num;
						num = (short)639936778;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							return;
						default:
							num = (short)1531838464;
							if (num != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_CB;
							}
							continue;
						}
						break;
					}
					case 1:
						return;
					case 2:
						goto IL_109;
					}
					IL_CB:
					if (value == this.ApxRadioSummaryEntity.BluetoothDUNPeerIP)
					{
						num = (short)885981185;
						num3 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)247398402;
						num3 = (int)((global::System.IntPtr)num);
					}
				}
				return;
				IL_109:
				this.ApxRadioSummaryEntity.BluetoothDUNPeerIP = (string.IsNullOrWhiteSpace(value) ? string.Empty : value);
				base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio.get_BluetoothDUNPeerIP())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
				base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio.get_BluetoothDUNPeerIPForGUI())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
			}
		}

		// Token: 0x1700039D RID: 925
		// (get) Token: 0x060007C0 RID: 1984 RVA: 0x00071D20 File Offset: 0x0006FF20
		// (set) Token: 0x060007C1 RID: 1985 RVA: 0x00071DD4 File Offset: 0x0006FFD4
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify("IsBluetoothFriendlyNameEditable", 3, true)]
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.EntitytMemberName("BluetoothFriendlyName")]
		public string BluetoothFriendlyName
		{
			get
			{
				short num = (short)1869772628;
				short num2 = num;
				num = (short)1153660756;
				switch (num2 == num)
				{
				}
				num = (short)1518469120;
				short num3 = num;
				num = (short)1380712449;
				if (num != 0)
				{
				}
				num = (short)524615680;
				if (num != 0)
				{
				}
				return this.ApxRadioSummaryEntity.BluetoothFriendlyName;
			}
			set
			{
				short num = (short)407175171;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						value = string.Empty;
						num = (short)681771013;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (value != this.ApxRadioSummaryEntity.BluetoothFriendlyName)
						{
							num = (short)931790852;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 2:
						return;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_3D;
						}
						continue;
					case 4:
						IL_17D:
						this.ApxRadioSummaryEntity.BluetoothFriendlyName = value;
						this.ApxRadioSummaryEntity.BluetoothFriendlyName = global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.FilterInvalidChar(value);
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio.get_BluetoothFriendlyName())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)509018114;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						num = (short)1349976065;
						if (num != 0)
						{
						}
						goto IL_C9;
					}
					IL_3D:
					if (value == null)
					{
						num = (short)1427701760;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_C9:
					num = (short)1622605824;
					short num3 = num;
					num = (short)428625772;
					short num4 = num;
					num = (short)1464749932;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_17D;
					default:
						num = (short)182845440;
						if (num != 0)
						{
						}
						num = (short)1276837889;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
			}
		}

		// Token: 0x1700039E RID: 926
		// (get) Token: 0x060007C2 RID: 1986 RVA: 0x00071FB0 File Offset: 0x000701B0
		// (set) Token: 0x060007C3 RID: 1987 RVA: 0x00072068 File Offset: 0x00070268
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify("IsOtarIDEditable", 4, true)]
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.EntitytMemberName("OtarID")]
		public int? OtarID
		{
			get
			{
				short num = (short)2131427329;
				if (num != 0)
				{
				}
				num = (short)569494275;
				short num2 = num;
				num = (short)1290324739;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1169489920;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)660865024;
				if (num != 0)
				{
				}
				return this.ApxRadioSummaryEntity.OtarID;
			}
			set
			{
				short num2;
				for (;;)
				{
					int? num = value;
					int? otarID = this.ApxRadioSummaryEntity.OtarID;
					if (!(num.GetValueOrDefault() == otarID.GetValueOrDefault() & num != null == (otarID != null)))
					{
						goto IL_D2;
					}
					num2 = (short)965632183;
					short num3 = num2;
					num2 = (short)1174626487;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_68;
					}
				}
				IL_68:
				num2 = (short)1747910657;
				if (num2 != 0)
				{
				}
				num2 = (short)782893056;
				if (num2 != 0)
				{
				}
				num2 = (short)453378048;
				short num4 = num2;
				return;
				IL_D2:
				this.ApxRadioSummaryEntity.OtarID = value;
				base.RaisePropertyChanged<int?>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<int?>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio.get_OtarID())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
			}
		}

		// Token: 0x1700039F RID: 927
		// (get) Token: 0x060007C4 RID: 1988 RVA: 0x00072188 File Offset: 0x00070388
		// (set) Token: 0x060007C5 RID: 1989 RVA: 0x0007223C File Offset: 0x0007043C
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public int? OwnerAdvKeyType
		{
			get
			{
				short num = (short)24248320;
				short num2 = num;
				num = (short)1691746305;
				if (num != 0)
				{
				}
				num = (short)1686104092;
				short num3 = num;
				num = (short)1590487068;
				switch (num3 == num)
				{
				}
				num = (short)1131675648;
				if (num != 0)
				{
				}
				return this.ApxRadioSummaryEntity.OwnerAdvKeyType;
			}
			set
			{
				short num = (short)1908870738;
				short num2 = num;
				num = (short)1567821394;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)151126017;
					if (num != 0)
					{
					}
					num = (short)371589120;
					if (num != 0)
					{
					}
					int? num3 = value;
					int? ownerAdvKeyType = this.ApxRadioSummaryEntity.OwnerAdvKeyType;
					if (!(num3.GetValueOrDefault() == ownerAdvKeyType.GetValueOrDefault() & num3 != null == (ownerAdvKeyType != null)))
					{
						this.ApxRadioSummaryEntity.OwnerAdvKeyType = value;
						base.RaisePropertyChanged<int?>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<int?>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio.get_OwnerAdvKeyType())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio.get_OwnerAdvKeyTypeForGUI())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						return;
					}
					num = (short)1734737920;
					short num4 = num;
					break;
				}
				}
			}
		}

		// Token: 0x170003A0 RID: 928
		// (get) Token: 0x060007C6 RID: 1990 RVA: 0x0007238C File Offset: 0x0007058C
		// (set) Token: 0x060007C7 RID: 1991 RVA: 0x00072440 File Offset: 0x00070640
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public int? GroupDataJobId
		{
			get
			{
				short num = (short)464650240;
				short num2 = num;
				num = (short)589838214;
				short num3 = num;
				num = (short)1897019270;
				switch (num3 == num)
				{
				}
				num = (short)1484390401;
				if (num != 0)
				{
				}
				num = (short)1671692288;
				if (num != 0)
				{
				}
				return this.ApxRadioSummaryEntity.GroupDataJobId;
			}
			set
			{
				short num = (short)1632688778;
				short num2 = num;
				num = (short)1117313674;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)512884737;
					if (num != 0)
					{
					}
					num = (short)1869938688;
					if (num != 0)
					{
					}
					int? num3 = value;
					int? groupDataJobId = this.ApxRadioSummaryEntity.GroupDataJobId;
					if (!(num3.GetValueOrDefault() == groupDataJobId.GetValueOrDefault() & num3 != null == (groupDataJobId != null)))
					{
						this.ApxRadioSummaryEntity.GroupDataJobId = value;
						base.RaisePropertyChanged<int?>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<int?>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio.get_GroupDataJobId())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						return;
					}
					num = (short)1853489152;
					short num4 = num;
					break;
				}
				}
			}
		}

		// Token: 0x170003A1 RID: 929
		// (get) Token: 0x060007C8 RID: 1992 RVA: 0x0007255C File Offset: 0x0007075C
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public string MaceSecureHardwareType
		{
			get
			{
				short num = (short)1844576256;
				short num2 = num;
				num = (short)2074963048;
				short num3 = num;
				num = (short)1208642664;
				switch (num3 == num)
				{
				}
				num = (short)506200065;
				if (num != 0)
				{
				}
				num = (short)1826816000;
				if (num != 0)
				{
				}
				return this.ApxRadioSummaryEntity.MaceSecureHardwareType;
			}
		}

		// Token: 0x170003A2 RID: 930
		// (get) Token: 0x060007C9 RID: 1993 RVA: 0x00072614 File Offset: 0x00070814
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public string OwnerAdvKeyTypeForGUI
		{
			get
			{
				switch (0)
				{
				case 0:
					goto IL_30;
				}
				int num;
				int? num2;
				int num3;
				short num4;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						goto IL_198;
					case 1:
						if (num2.GetValueOrDefault() == num3 & num2 != null)
						{
							num4 = (short)1932460035;
							num = (int)((global::System.IntPtr)num4);
							continue;
						}
						goto IL_FC;
					case 2:
						goto IL_1EE;
					case 3:
						num2 = this.OwnerSystemId;
						num3 = 0;
						num4 = (short)1793261575;
						num = (int)((global::System.IntPtr)num4);
						continue;
					case 4:
					{
						if (!(num2.GetValueOrDefault() == num3 & num2 != null))
						{
							goto IL_223;
						}
						num4 = (short)781199277;
						short num5 = num4;
						num4 = (short)1563240365;
						switch ((num5 == num4) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_198;
						default:
							num4 = (short)381943808;
							if (num4 != 0)
							{
							}
							num4 = (short)1196359680;
							num = (int)((global::System.IntPtr)num4);
							continue;
						}
						break;
					}
					case 5:
						goto IL_CD;
					case 6:
						if (!(num2.GetValueOrDefault() == num3 & num2 != null))
						{
							num4 = (short)987561989;
							num = (int)((global::System.IntPtr)num4);
							continue;
						}
						goto IL_223;
					case 7:
						if (!(num2.GetValueOrDefault() == num3 & num2 != null))
						{
							num4 = (short)667680770;
							num = (int)((global::System.IntPtr)num4);
							continue;
						}
						goto IL_FC;
					}
					goto IL_30;
					IL_FC:
					num2 = this.OwnerAdvKeyType;
					num3 = 1;
					num4 = (short)1014824964;
					num = (int)((global::System.IntPtr)num4);
					continue;
					IL_198:
					num2 = this.OwnerSystemId;
					num3 = 0;
					num4 = (short)322961414;
					num = (int)((global::System.IntPtr)num4);
				}
				IL_CD:
				num4 = (short)1831534592;
				short num6 = num4;
				return global::RFResourceRepository.RFResources.Adv_WACN_Key_Column_Header_ID;
				IL_1EE:
				num4 = (short)1421737985;
				if (num4 != 0)
				{
				}
				return global::RFResourceRepository.RFResources.Adv_System_Key_Column_Header_ID;
				IL_223:
				return string.Empty;
				IL_30:
				num2 = this.OwnerAdvKeyType;
				num3 = 0;
				num4 = (short)1402470401;
				num = (int)((global::System.IntPtr)num4);
				goto IL_0A;
			}
		}

		// Token: 0x170003A3 RID: 931
		// (get) Token: 0x060007CA RID: 1994 RVA: 0x0007284C File Offset: 0x00070A4C
		// (set) Token: 0x060007CB RID: 1995 RVA: 0x000729DC File Offset: 0x00070BDC
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public int? OwnerSystemId
		{
			get
			{
				switch (0)
				{
				case 0:
					goto IL_20;
				}
				int num;
				int? result;
				int num2;
				short num3;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						if (result.GetValueOrDefault() == num2 & result != null)
						{
							num3 = (short)1750401026;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						result = this.ApxRadioSummaryEntity.OwnerAdvKeyType;
						num2 = 1;
						num3 = (short)659488769;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 1:
					{
						if (result.GetValueOrDefault() == num2 & result != null)
						{
							num3 = (short)338690051;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						num3 = (short)1494873777;
						short num4 = num3;
						num3 = (short)758576817;
						switch ((num4 == num3) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							goto IL_13B;
						}
						break;
					}
					case 2:
						goto IL_6A;
					case 3:
						goto IL_CC;
					}
					goto IL_20;
				}
				IL_6A:
				return this.ApxRadioSummaryEntity.HomeSystemId;
				IL_CC:
				num3 = (short)1193345024;
				short num5 = num3;
				return this.ApxRadioSummaryEntity.OwnerWacnId;
				IL_13B:
				num3 = (short)1148256257;
				if (num3 != 0)
				{
				}
				num3 = (short)644153344;
				if (num3 != 0)
				{
				}
				result = null;
				return result;
				IL_20:
				result = this.ApxRadioSummaryEntity.OwnerAdvKeyType;
				num2 = 0;
				num3 = (short)976158720;
				num = (int)((global::System.IntPtr)num3);
				goto IL_0A;
			}
			set
			{
				switch (0)
				{
				case 0:
					goto IL_38;
				}
				int num;
				int? num3;
				short num4;
				int num5;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
					{
						int? num2;
						if (num2.GetValueOrDefault() == num3.GetValueOrDefault() & num2 != null == (num3 != null))
						{
							num4 = (short)887554056;
							num = (int)((global::System.IntPtr)num4);
							continue;
						}
						this.ApxRadioSummaryEntity.OwnerWacnId = value;
						num4 = (short)1177419782;
						num = (int)((global::System.IntPtr)num4);
						continue;
					}
					case 1:
					{
						if (!(num3.GetValueOrDefault() == num5 & num3 != null))
						{
							int? num2 = this.ApxRadioSummaryEntity.OwnerAdvKeyType;
							num5 = 1;
							num4 = (short)1549795335;
							num = (int)((global::System.IntPtr)num4);
							continue;
						}
						num4 = (short)1355609607;
						short num6 = num4;
						num4 = (short)1901393415;
						switch ((num6 == num4) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_258;
						default:
							num4 = (short)244121600;
							if (num4 != 0)
							{
							}
							num4 = (short)1301282821;
							num = (int)((global::System.IntPtr)num4);
							continue;
						}
						break;
					}
					case 2:
						goto IL_29A;
					case 3:
					{
						int? num2 = value;
						num3 = this.ApxRadioSummaryEntity.OwnerWacnId;
						num4 = (short)1256194048;
						num = (int)((global::System.IntPtr)num4);
						continue;
					}
					case 4:
					{
						int? num2;
						if (num3.GetValueOrDefault() == num2.GetValueOrDefault() & num3 != null == (num2 != null))
						{
							goto IL_258;
						}
						this.ApxRadioSummaryEntity.HomeSystemId = value;
						num4 = (short)83427330;
						num = (int)((global::System.IntPtr)num4);
						continue;
					}
					case 5:
					{
						num4 = (short)1430781952;
						short num7 = num4;
						num3 = value;
						int? num2 = this.ApxRadioSummaryEntity.HomeSystemId;
						num4 = (short)752222212;
						num = (int)((global::System.IntPtr)num4);
						continue;
					}
					case 6:
						goto IL_20B;
					case 7:
					{
						int? num2;
						if (num2.GetValueOrDefault() == num5 & num2 != null)
						{
							num4 = (short)486080515;
							num = (int)((global::System.IntPtr)num4);
							continue;
						}
						goto IL_29C;
					}
					case 8:
						return;
					case 9:
						return;
					}
					goto IL_38;
					IL_258:
					num4 = (short)235733001;
					num = (int)((global::System.IntPtr)num4);
				}
				return;
				IL_20B:
				IL_29A:
				IL_29C:
				base.RaisePropertyChanged<int?>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<int?>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio.get_OwnerSystemId())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
				base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio.get_OwnerSystemIdForGUI())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
				base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio.get_OwnerAdvKeyTypeForGUI())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
				return;
				IL_38:
				num4 = (short)1348009985;
				if (num4 != 0)
				{
				}
				num3 = this.ApxRadioSummaryEntity.OwnerAdvKeyType;
				num5 = 0;
				num4 = (short)1521876993;
				num = (int)((global::System.IntPtr)num4);
				goto IL_0A;
			}
		}

		// Token: 0x170003A4 RID: 932
		// (get) Token: 0x060007CC RID: 1996 RVA: 0x00072D24 File Offset: 0x00070F24
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public bool AppIsAskRequired
		{
			get
			{
				short num = (short)2088056373;
				short num2 = num;
				num = (short)49755701;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)18284544;
					if (num != 0)
					{
					}
					if (!this.AskRequired)
					{
						num = (short)534970369;
						if (num != 0)
						{
						}
						return false;
					}
					break;
				}
				num = (short)1440546816;
				short num3 = num;
				return true;
			}
		}

		// Token: 0x170003A5 RID: 933
		// (get) Token: 0x060007CD RID: 1997 RVA: 0x00072DDC File Offset: 0x00070FDC
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public string OwnerSystemIdForGUI
		{
			get
			{
				int a_ = 17;
				switch (0)
				{
				case 0:
					goto IL_29;
				}
				int num;
				int? ownerSystemId;
				short num2;
				int num5;
				for (;;)
				{
					IL_13:
					switch (num)
					{
					case 0:
					{
						if (ownerSystemId == null)
						{
							goto IL_17E;
						}
						num2 = (short)1386475018;
						short num3 = num2;
						num2 = (short)1503063562;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_10F;
						default:
						{
							num2 = (short)139132928;
							short num4 = num2;
							num2 = (short)2063335424;
							if (num2 != 0)
							{
							}
							num2 = (short)1167589378;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						}
						break;
					}
					case 1:
						if (!(ownerSystemId.GetValueOrDefault() == num5 & ownerSystemId != null))
						{
							num2 = (short)1695416323;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_17E;
					case 2:
						ownerSystemId = this.OwnerSystemId;
						num5 = 0;
						goto IL_10F;
					case 3:
						goto IL_179;
					}
					goto IL_29;
					IL_10F:
					num2 = (short)1648361473;
					if (num2 != 0)
					{
					}
					num2 = (short)920911873;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_179:
				ownerSystemId = this.OwnerSystemId;
				num5 = ownerSystemId.Value;
				return num5.ToString(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ᑋ", a_), global::System.Globalization.CultureInfo.CurrentCulture);
				IL_17E:
				return null;
				IL_29:
				ownerSystemId = this.OwnerSystemId;
				num2 = (short)1235550208;
				num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
		}

		// Token: 0x170003A6 RID: 934
		// (get) Token: 0x060007CE RID: 1998 RVA: 0x00072F68 File Offset: 0x00071168
		// (set) Token: 0x060007CF RID: 1999 RVA: 0x0007303C File Offset: 0x0007123C
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public bool? DisableWriteProtect
		{
			get
			{
				short num = (short)569217906;
				short num2 = num;
				num = (short)1016435570;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1719599104;
					if (num != 0)
					{
					}
					if (this.ApxRadioSummaryEntity.DisableWriteProtect == null)
					{
						num = (short)614006785;
						if (num != 0)
						{
						}
						return new bool?(false);
					}
					break;
				}
				num = (short)836632576;
				short num3 = num;
				return this.ApxRadioSummaryEntity.DisableWriteProtect;
			}
			set
			{
				short num = (short)1362875168;
				short num2 = num;
				num = (short)2026492704;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)588120065;
					if (num != 0)
					{
					}
					num = (short)1608581120;
					if (num != 0)
					{
					}
					bool? flag = value;
					bool? disableWriteProtect = this.ApxRadioSummaryEntity.DisableWriteProtect;
					if (!(flag.GetValueOrDefault() == disableWriteProtect.GetValueOrDefault() & flag != null == (disableWriteProtect != null)))
					{
						this.ApxRadioSummaryEntity.DisableWriteProtect = value;
						base.RaisePropertyChanged<bool?>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool?>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio.get_DisableWriteProtect())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						return;
					}
					num = (short)137428992;
					short num3 = num;
					break;
				}
				}
			}
		}

		// Token: 0x170003A7 RID: 935
		// (get) Token: 0x060007D0 RID: 2000 RVA: 0x00073158 File Offset: 0x00071358
		// (set) Token: 0x060007D1 RID: 2001 RVA: 0x0007320C File Offset: 0x0007140C
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public int? ExtendedFlags
		{
			get
			{
				short num = (short)1268776960;
				short num2 = num;
				num = (short)807353476;
				short num3 = num;
				num = (short)288701572;
				switch (num3 == num)
				{
				}
				num = (short)1310588929;
				if (num != 0)
				{
				}
				num = (short)1803485184;
				if (num != 0)
				{
				}
				return this.ApxRadioSummaryEntity.ExtendedFlags;
			}
			set
			{
				short num = (short)871899230;
				short num2 = num;
				num = (short)749346910;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)605618176;
					if (num != 0)
					{
					}
					num = (short)1089732609;
					if (num != 0)
					{
					}
					int? num3 = value;
					int? extendedFlags = this.ApxRadioSummaryEntity.ExtendedFlags;
					if (!(num3.GetValueOrDefault() == extendedFlags.GetValueOrDefault() & num3 != null == (extendedFlags != null)))
					{
						this.ApxRadioSummaryEntity.ExtendedFlags = value;
						base.RaisePropertyChanged<int?>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<int?>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio.get_ExtendedFlags())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						return;
					}
					num = (short)964034560;
					short num4 = num;
					break;
				}
				}
			}
		}

		// Token: 0x170003A8 RID: 936
		// (get) Token: 0x060007D2 RID: 2002 RVA: 0x00073330 File Offset: 0x00071530
		// (set) Token: 0x060007D3 RID: 2003 RVA: 0x0007349C File Offset: 0x0007169C
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.EntitytMemberName("ForeignIP")]
		public string ForeignIPForGUI
		{
			get
			{
				int a_ = 8;
				short num = (short)1519255552;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)840892416;
						short num3 = num;
						num = (short)440926209;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_8E;
						}
						continue;
					}
					case 1:
						if (this.ForeignIP != null)
						{
							num = (short)1171587075;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_15D;
					case 2:
						goto IL_AB;
					case 3:
						goto IL_108;
					}
					IL_8E:
					if (base.SuppressIPConvert)
					{
						num = (short)412024834;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)829161473;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				IL_AB:
				num = (short)293349559;
				short num4 = num;
				num = (short)535177399;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_15D:
					return null;
				default:
					num = (short)2074673152;
					if (num != 0)
					{
					}
					return this.ForeignIP;
				}
				IL_108:
				return this.ForeignIP.Replace(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("浂", a_), global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("湂", a_));
			}
			set
			{
				int a_ = 18;
				short num = (short)991756289;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					string text;
					switch (num2)
					{
					case 0:
						num = (short)911736837;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_4E;
						}
						continue;
					case 2:
						num = (short)248184833;
						if (num != 0)
						{
						}
						text = value.Replace(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("恌", a_), global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("捌", a_));
						goto IL_AB;
					case 3:
						num = (short)582615046;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
					{
						if (!(value != this.ForeignIP))
						{
							return;
						}
						num = (short)1728100651;
						short num3 = num;
						num = (short)1548532011;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
						{
							num = (short)1251213312;
							if (num != 0)
							{
							}
							num = (short)1698234368;
							short num4 = num;
							num = (short)1091895296;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 5:
						this.ForeignIP = (string.IsNullOrWhiteSpace(value) ? string.Empty : value);
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio.get_PeerIP())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio.get_ForeignIPForGUI())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)666763271;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						text = string.Empty;
						goto IL_AB;
					case 7:
						return;
					}
					IL_4E:
					if (value == null)
					{
						num = (short)1248198659;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1492910082;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_AB:
					value = text;
					num = (short)1000865796;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x170003A9 RID: 937
		// (get) Token: 0x060007D4 RID: 2004 RVA: 0x00073704 File Offset: 0x00071904
		// (set) Token: 0x060007D5 RID: 2005 RVA: 0x000737BC File Offset: 0x000719BC
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.EntitytMemberName("ForeignIP")]
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify("IsForeignIPEditable", 16, true)]
		public string ForeignIP
		{
			get
			{
				short num = (short)891027456;
				short num2 = num;
				num = (short)1017095285;
				short num3 = num;
				num = (short)816555125;
				switch (num3 == num)
				{
				}
				num = (short)1757347841;
				if (num != 0)
				{
				}
				num = (short)1670512640;
				if (num != 0)
				{
				}
				return this.ApxRadioSummaryEntity.ForeignIP;
			}
			set
			{
				short num = (short)423362560;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_14;
					case 1:
					{
						if (value == this.ApxRadioSummaryEntity.ForeignIP)
						{
							num = (short)821952514;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1797987303;
						short num3 = num;
						num = (short)1523522535;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_14;
						default:
							goto IL_146;
						}
						break;
					}
					case 2:
						goto IL_98;
					case 3:
					{
						num = (short)504627200;
						short num4 = num;
						value = string.Empty;
						num = (short)1344405508;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						goto IL_58;
					}
					goto IL_38;
					IL_14:
					switch (0)
					{
					case 0:
						IL_38:
						if (!string.IsNullOrWhiteSpace(value))
						{
							goto IL_58;
						}
						num = (short)722993155;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					continue;
					IL_58:
					num = (short)651952129;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_98:
				num = (short)1713373185;
				if (num != 0)
				{
				}
				return;
				IL_146:
				num = (short)1406795776;
				if (num != 0)
				{
				}
				this.ApxRadioSummaryEntity.ForeignIP = value;
				base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio.get_ForeignIP())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
				base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio.get_ForeignIPForGUI())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
			}
		}

		// Token: 0x170003AA RID: 938
		// (get) Token: 0x060007D6 RID: 2006 RVA: 0x00073998 File Offset: 0x00071B98
		// (set) Token: 0x060007D7 RID: 2007 RVA: 0x00073B08 File Offset: 0x00071D08
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.EntitytMemberName("PeerIP")]
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public string PeerIPForGUI
		{
			get
			{
				int a_ = 17;
				short num = (short)1365573632;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)1246232576;
						short num3 = num;
						switch (0)
						{
						case 0:
							goto IL_66;
						}
						continue;
					}
					case 1:
						if (this.PeerIP != null)
						{
							num = (short)495255555;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_15F;
					case 2:
						goto IL_A9;
					case 3:
						goto IL_10B;
					}
					IL_66:
					num = (short)869335041;
					if (num != 0)
					{
					}
					if (base.SuppressIPConvert)
					{
						num = (short)875757570;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)910491649;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				IL_A9:
				num = (short)2001176614;
				short num4 = num;
				num = (short)1989904422;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_15F:
					return null;
				default:
					num = (short)2102394880;
					if (num != 0)
					{
					}
					return this.PeerIP;
				}
				IL_10B:
				return this.PeerIP.Replace(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("手", a_), global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("態", a_));
			}
			set
			{
				int a_ = 5;
				short num = (short)1330577409;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					string text;
					switch (num2)
					{
					case 0:
						num = (short)1916665861;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_4D;
						}
						continue;
					case 2:
						text = value.Replace(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("洿", a_), global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("渿", a_));
						goto IL_AB;
					case 3:
						num = (short)1727791110;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
					{
						if (!(value != this.PeerIP))
						{
							return;
						}
						num = (short)1944717673;
						short num3 = num;
						num = (short)2045970793;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
						{
							num = (short)1857945600;
							if (num != 0)
							{
							}
							num = (short)1212678144;
							short num4 = num;
							num = (short)1312948225;
							if (num != 0)
							{
							}
							num = (short)1728380928;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 5:
						this.PeerIP = (string.IsNullOrWhiteSpace(value) ? string.Empty : value);
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio.get_PeerIP())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio.get_PeerIPForGUI())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)2028535815;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						text = string.Empty;
						goto IL_AB;
					case 7:
						return;
					}
					IL_4D:
					if (value == null)
					{
						num = (short)2081357827;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1861550082;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_AB:
					value = text;
					num = (short)1093861380;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x170003AB RID: 939
		// (get) Token: 0x060007D8 RID: 2008 RVA: 0x00073D74 File Offset: 0x00071F74
		// (set) Token: 0x060007D9 RID: 2009 RVA: 0x00073E28 File Offset: 0x00072028
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify("IsPeerIPEditable", 5, true)]
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.EntitytMemberName("PeerIP")]
		public string PeerIP
		{
			get
			{
				short num = (short)2043543552;
				short num2 = num;
				num = (short)1596112321;
				short num3 = num;
				num = (short)532266433;
				switch (num3 == num)
				{
				}
				num = (short)1517092864;
				if (num != 0)
				{
				}
				num = (short)85327873;
				if (num != 0)
				{
				}
				return this.ApxRadioSummaryEntity.PeerIP;
			}
			set
			{
				short num = (short)412155905;
				if (num != 0)
				{
				}
				num = (short)715789231;
				short num2 = num;
				num = (short)771101615;
				int num3;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)2029387776;
					if (num != 0)
					{
					}
					num = (short)1762590721;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
				for (;;)
				{
					switch (num3)
					{
					case 0:
						return;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_A3;
						}
						continue;
					case 2:
						goto IL_10A;
					}
					IL_A3:
					if (value == this.ApxRadioSummaryEntity.PeerIP)
					{
						num = (short)945291264;
						num3 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)651427840;
						short num4 = num;
						num = (short)678821890;
						num3 = (int)((global::System.IntPtr)num);
					}
				}
				return;
				IL_10A:
				this.ApxRadioSummaryEntity.PeerIP = (string.IsNullOrWhiteSpace(value) ? string.Empty : value);
				base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio.get_PeerIP())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
				base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio.get_PeerIPForGUI())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
			}
		}

		// Token: 0x170003AC RID: 940
		// (get) Token: 0x060007DA RID: 2010 RVA: 0x00073FC8 File Offset: 0x000721C8
		// (set) Token: 0x060007DB RID: 2011 RVA: 0x0007407C File Offset: 0x0007227C
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public string PeerIP_Link2
		{
			get
			{
				short num = (short)1365377024;
				short num2 = num;
				num = (short)700895938;
				short num3 = num;
				num = (short)1974457026;
				switch (num3 == num)
				{
				}
				num = (short)1020461057;
				if (num != 0)
				{
				}
				num = (short)83820544;
				if (num != 0)
				{
				}
				return this.ApxRadioSummaryEntity.PeerIP_A41818;
			}
			set
			{
				short num = (short)1146295381;
				short num2 = num;
				num = (short)476255317;
				int num3;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)82378752;
					if (num != 0)
					{
					}
					num = (short)1282867201;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
				for (;;)
				{
					num = (short)827457537;
					if (num != 0)
					{
					}
					switch (num3)
					{
					case 0:
						return;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_A3;
						}
						continue;
					case 2:
						goto IL_10F;
					}
					IL_A3:
					if (value == this.ApxRadioSummaryEntity.PeerIP_A41818)
					{
						num = (short)1644888064;
						num3 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)460914688;
						short num4 = num;
						num = (short)1144193026;
						num3 = (int)((global::System.IntPtr)num);
					}
				}
				return;
				IL_10F:
				this.ApxRadioSummaryEntity.PeerIP_A41818 = (string.IsNullOrWhiteSpace(value) ? string.Empty : value);
			}
		}

		// Token: 0x170003AD RID: 941
		// (get) Token: 0x060007DC RID: 2012 RVA: 0x000741B8 File Offset: 0x000723B8
		// (set) Token: 0x060007DD RID: 2013 RVA: 0x00074328 File Offset: 0x00072528
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.EntitytMemberName("SubscriberIP")]
		public string SubscriberIPForGUI
		{
			get
			{
				int a_ = 1;
				short num = (short)2057043968;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)2062286848;
						short num3 = num;
						switch (0)
						{
						case 0:
							goto IL_65;
						}
						continue;
					}
					case 1:
						if (this.SubscriberIP != null)
						{
							num = (short)523894787;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_15F;
					case 2:
						goto IL_82;
					case 3:
						goto IL_10B;
					}
					IL_65:
					if (base.SuppressIPConvert)
					{
						num = (short)1724907522;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)668205057;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				IL_82:
				num = (short)1654652929;
				if (num != 0)
				{
				}
				num = (short)963264306;
				short num4 = num;
				num = (short)1408646962;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_15F:
					return null;
				default:
					num = (short)1822228480;
					if (num != 0)
					{
					}
					return this.SubscriberIP;
				}
				IL_10B:
				return this.SubscriberIP.Replace(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ሻ", a_), global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ᄻ", a_));
			}
			set
			{
				int a_ = 10;
				short num = (short)1530068992;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					string text;
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_51;
						}
						continue;
					case 1:
						if (value != this.SubscriberIP)
						{
							num = (short)384892935;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 2:
						return;
					case 3:
						text = string.Empty;
						goto IL_232;
					case 4:
						num = (short)2099118083;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_1F0;
					case 6:
					{
						num = (short)1726873600;
						short num3 = num;
						num = (short)1931821242;
						short num4 = num;
						num = (short)658194618;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1F0;
						default:
							num = (short)121307137;
							if (num != 0)
							{
							}
							num = (short)642121728;
							if (num != 0)
							{
							}
							num = (short)1294794753;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 7:
						this.SubscriberIP = value;
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio.get_SubscriberIP())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio.get_SubscriberIPForGUI())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)186843138;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						if (this.SubscriberIP != null)
						{
							num = (short)824442886;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					IL_51:
					if (value == null)
					{
						num = (short)383123460;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)445579269;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_232:
					value = text;
					num = (short)1033830408;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1F0:
					text = value.Replace(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("桄", a_), global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("歄", a_));
					goto IL_232;
				}
			}
		}

		// Token: 0x170003AE RID: 942
		// (get) Token: 0x060007DE RID: 2014 RVA: 0x000745A8 File Offset: 0x000727A8
		// (set) Token: 0x060007DF RID: 2015 RVA: 0x0007465C File Offset: 0x0007285C
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify("IsSubscriberIPEditable", 6, true)]
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.EntitytMemberName("SubscriberIP")]
		public string SubscriberIP
		{
			get
			{
				short num = (short)2037742597;
				short num2 = num;
				num = (short)1099922437;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1179844608;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1832124416;
				if (num != 0)
				{
				}
				num = (short)467402753;
				if (num != 0)
				{
				}
				return this.ApxRadioSummaryEntity.SubscriberIP;
			}
			set
			{
				short num = (short)605945858;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						this.ApxRadioSummaryEntity.SubscriberIP = value;
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio.get_SubscriberIP())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio.get_SubscriberIPForGUI())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1362886657;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						return;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_30;
						}
						continue;
					}
					IL_30:
					num = (short)1993277440;
					short num3 = num;
					num = (short)1093271553;
					if (num != 0)
					{
					}
					num = (short)1318255116;
					short num4 = num;
					num = (short)596507148;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
						num = (short)1901723648;
						if (num != 0)
						{
						}
						if (!(value != this.ApxRadioSummaryEntity.SubscriberIP))
						{
							return;
						}
						num = (short)228917248;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
			}
		}

		// Token: 0x170003AF RID: 943
		// (get) Token: 0x060007E0 RID: 2016 RVA: 0x000747F4 File Offset: 0x000729F4
		// (set) Token: 0x060007E1 RID: 2017 RVA: 0x000748A8 File Offset: 0x00072AA8
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public string SubscriberIP_Link2
		{
			get
			{
				short num = (short)1795242158;
				short num2 = num;
				num = (short)528758958;
				switch (num2 == num)
				{
				default:
				{
					num = (short)42270720;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)66519041;
				if (num != 0)
				{
				}
				num = (short)1845428224;
				if (num != 0)
				{
				}
				return this.ApxRadioSummaryEntity.SubscriberIP_A41819;
			}
			set
			{
				short num = (short)1157431297;
				if (num != 0)
				{
				}
				num = (short)45023234;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						return;
					case 1:
						goto IL_10D;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_58;
						}
						continue;
					}
					IL_58:
					if (value == this.ApxRadioSummaryEntity.SubscriberIP_A41819)
					{
						num = (short)447217664;
						short num3 = num;
						num = (short)1075642368;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)1773293636;
						short num4 = num;
						num = (short)603934788;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							return;
						default:
							num = (short)397017088;
							if (num != 0)
							{
							}
							num = (short)878379009;
							num2 = (int)((global::System.IntPtr)num);
							break;
						}
					}
				}
				return;
				IL_10D:
				this.ApxRadioSummaryEntity.SubscriberIP_A41819 = (string.IsNullOrWhiteSpace(value) ? string.Empty : value);
			}
		}

		// Token: 0x170003B0 RID: 944
		// (get) Token: 0x060007E2 RID: 2018 RVA: 0x000749E4 File Offset: 0x00072BE4
		// (set) Token: 0x060007E3 RID: 2019 RVA: 0x00074A98 File Offset: 0x00072C98
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify("IsUserLoginUnitIDEditable", 10, true)]
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.EntitytMemberName("UserLoginUnitID")]
		public string UserLoginUnitID
		{
			get
			{
				short num = (short)824125562;
				short num2 = num;
				num = (short)1147021434;
				switch (num2 == num)
				{
				default:
				{
					num = (short)321126400;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1617887233;
				if (num != 0)
				{
				}
				num = (short)1082785792;
				if (num != 0)
				{
				}
				return this.ApxRadioSummaryEntity.UserLoginUnitID;
			}
			set
			{
				short num = (short)1159266308;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)446395607;
						short num3 = num;
						num = (short)2016834775;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_152;
						default:
							num = (short)419430400;
							if (num != 0)
							{
							}
							value = string.Empty;
							num = (short)1517092867;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 1:
						goto IL_93;
					case 2:
						if (value == this.ApxRadioSummaryEntity.UserLoginUnitID)
						{
							num = (short)2068316161;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_157;
					case 3:
						goto IL_152;
					case 4:
						switch (0)
						{
						case 0:
							goto IL_38;
						}
						continue;
					}
					IL_38:
					if (value == null)
					{
						num = (short)384761856;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_55:
					num = (short)1098842114;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_152:
					goto IL_55;
				}
				IL_93:
				num = (short)1039466496;
				short num4 = num;
				num = (short)2041380865;
				if (num != 0)
				{
				}
				return;
				IL_157:
				this.ApxRadioSummaryEntity.UserLoginUnitID = value;
				base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio.get_UserLoginUnitID())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
			}
		}

		// Token: 0x170003B1 RID: 945
		// (get) Token: 0x060007E4 RID: 2020 RVA: 0x00074C3C File Offset: 0x00072E3C
		// (set) Token: 0x060007E5 RID: 2021 RVA: 0x00074CF4 File Offset: 0x00072EF4
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.EntitytMemberName("UserName")]
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify("IsUserNameEditable", 8, true)]
		public string UserName
		{
			get
			{
				short num = (short)756054672;
				short num2 = num;
				num = (short)633698960;
				switch (num2 == num)
				{
				default:
				{
					num = (short)911212544;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2063335425;
				if (num != 0)
				{
				}
				num = (short)2111045632;
				if (num != 0)
				{
				}
				return this.ApxRadioSummaryEntity.UserName;
			}
			set
			{
				short num = (short)1066401796;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)2128609280;
					short num3 = num;
					switch (num2)
					{
					case 0:
						if (value != this.ApxRadioSummaryEntity.UserName)
						{
							num = (short)1074528257;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 1:
						this.ApxRadioSummaryEntity.UserName = value;
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio.get_UserName())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1207500803;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						num = (short)990187068;
						short num4 = num;
						num = (short)574819900;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							return;
						default:
							num = (short)662634496;
							if (num != 0)
							{
							}
							goto IL_108;
						}
						break;
					}
					case 3:
						return;
					case 4:
						switch (0)
						{
						case 0:
							goto IL_66;
						}
						continue;
					case 5:
						value = string.Empty;
						num = (short)1763377154;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_66:
					num = (short)927006721;
					if (num != 0)
					{
					}
					if (value == null)
					{
						num = (short)1998061573;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_108:
					num = (short)1502216192;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x170003B2 RID: 946
		// (get) Token: 0x060007E6 RID: 2022 RVA: 0x00074EC4 File Offset: 0x000730C4
		// (set) Token: 0x060007E7 RID: 2023 RVA: 0x00074F88 File Offset: 0x00073188
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify("IsUserPINEditable", 9, true)]
		public string UserPIN
		{
			get
			{
				if (this.b == null)
				{
					short num;
					for (;;)
					{
						num = (short)1759907088;
						short num2 = num;
						num = (short)1870138640;
						switch ((num2 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_42;
						}
					}
					IL_42:
					num = (short)1909522432;
					if (num != 0)
					{
					}
					num = (short)866189313;
					if (num != 0)
					{
					}
					num = (short)1195114496;
					short num3 = num;
					return string.Empty;
				}
				return this.b;
			}
			set
			{
				short num = (short)1019674628;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)917504;
					short num3 = num;
					switch (num2)
					{
					case 0:
						if (value != this.b)
						{
							num = (short)1966080001;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 1:
						this.b = value;
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio.get_UserPIN())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1065418755;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						num = (short)1841040081;
						short num4 = num;
						num = (short)1211304657;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							return;
						default:
							num = (short)2093547521;
							if (num != 0)
							{
							}
							num = (short)502267904;
							if (num != 0)
							{
							}
							goto IL_D9;
						}
						break;
					}
					case 3:
						return;
					case 4:
						switch (0)
						{
						case 0:
							goto IL_66;
						}
						continue;
					case 5:
						value = string.Empty;
						num = (short)1417084930;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_66:
					if (value == null)
					{
						num = (short)296812549;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_D9:
					num = (short)1073348608;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x170003B3 RID: 947
		// (get) Token: 0x060007E8 RID: 2024 RVA: 0x0007514C File Offset: 0x0007334C
		// (set) Token: 0x060007E9 RID: 2025 RVA: 0x000751FC File Offset: 0x000733FC
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public string AstroPurchasedFlashCode
		{
			get
			{
				short num = (short)1080229148;
				short num2 = num;
				num = (short)896990492;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1818034176;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1444872193;
				if (num != 0)
				{
				}
				num = (short)1877278720;
				if (num != 0)
				{
				}
				return this.a;
			}
			set
			{
				short num = (short)1581514756;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)734396416;
					short num3 = num;
					switch (num2)
					{
					case 0:
						if (value != this.a)
						{
							num = (short)360644609;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 1:
						this.a = value;
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio.get_AstroPurchasedFlashCode())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)875036675;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						num = (short)1593736410;
						short num4 = num;
						num = (short)460553434;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							return;
						default:
							num = (short)1733296128;
							if (num != 0)
							{
							}
							goto IL_10A;
						}
						break;
					}
					case 3:
						return;
					case 4:
						switch (0)
						{
						case 0:
							goto IL_65;
						}
						continue;
					case 5:
						num = (short)275972097;
						if (num != 0)
						{
						}
						value = string.Empty;
						num = (short)134283266;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_65:
					if (string.IsNullOrEmpty(value))
					{
						num = (short)1238302725;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_10A:
					num = (short)181665792;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x170003B4 RID: 948
		// (get) Token: 0x060007EA RID: 2026 RVA: 0x000753C4 File Offset: 0x000735C4
		// (set) Token: 0x060007EB RID: 2027 RVA: 0x00075478 File Offset: 0x00073678
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public bool? RadioAliasEnable
		{
			get
			{
				short num = (short)874953765;
				short num2 = num;
				num = (short)1884208165;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1071251456;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1147469825;
				if (num != 0)
				{
				}
				num = (short)1461780480;
				if (num != 0)
				{
				}
				return this.ApxRadioSummaryEntity.RadioAliasEnable;
			}
			set
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				bool? radioAliasEnable;
				bool? flag;
				short num2;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						this.ApxRadioSummaryEntity.RadioAliasEnable = value;
						goto IL_84;
					case 1:
						goto IL_9E;
					case 2:
						if (!(radioAliasEnable.GetValueOrDefault() == flag.GetValueOrDefault() & radioAliasEnable != null == (flag != null)))
						{
							num2 = (short)2123235328;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_9E;
					}
					goto IL_1C;
					IL_84:
					num2 = (short)1754464257;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_9E:
					num2 = (short)1206120498;
					short num3 = num2;
					num2 = (short)1917644850;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_84;
					case 1:
						goto IL_FE;
					}
					break;
				}
				num2 = (short)1435435008;
				short num4 = num2;
				IL_FE:
				num2 = (short)380370944;
				if (num2 != 0)
				{
				}
				num2 = (short)1626144769;
				if (num2 != 0)
				{
				}
				return;
				IL_1C:
				radioAliasEnable = this.ApxRadioSummaryEntity.RadioAliasEnable;
				flag = value;
				num2 = (short)1627127810;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x060007EC RID: 2028 RVA: 0x000755C0 File Offset: 0x000737C0
		// (set) Token: 0x060007ED RID: 2029 RVA: 0x00075674 File Offset: 0x00073874
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public bool? OtarEnable
		{
			get
			{
				short num = (short)187760641;
				if (num != 0)
				{
				}
				num = (short)1100087296;
				short num2 = num;
				num = (short)773928691;
				short num3 = num;
				num = (short)563427059;
				switch (num3 == num)
				{
				}
				num = (short)807469056;
				if (num != 0)
				{
				}
				return this.ApxRadioSummaryEntity.OtarEnable;
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
				bool? otarEnable;
				bool? flag;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						this.ApxRadioSummaryEntity.OtarEnable = value;
						goto IL_85;
					case 1:
						num2 = (short)1636368385;
						if (num2 != 0)
						{
						}
						goto IL_C6;
					case 2:
						if (!(otarEnable.GetValueOrDefault() == flag.GetValueOrDefault() & otarEnable != null == (flag != null)))
						{
							num2 = (short)1198391296;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_C6;
					}
					goto IL_1C;
					IL_85:
					num2 = (short)308150273;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_C6:
					num2 = (short)497025024;
					short num3 = num2;
					num2 = (short)1231363551;
					short num4 = num2;
					num2 = (short)262610399;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_85;
					default:
						goto IL_125;
					}
				}
				IL_125:
				num2 = (short)305922048;
				if (num2 != 0)
				{
				}
				return;
				IL_1C:
				otarEnable = this.ApxRadioSummaryEntity.OtarEnable;
				flag = value;
				num2 = (short)1682833410;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x170003B6 RID: 950
		// (get) Token: 0x060007EE RID: 2030 RVA: 0x000757BC File Offset: 0x000739BC
		// (set) Token: 0x060007EF RID: 2031 RVA: 0x00075870 File Offset: 0x00073A70
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public bool? ASTROOtarEnable
		{
			get
			{
				short num = (short)914541583;
				short num2 = num;
				num = (short)1679936527;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1630208000;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)10682369;
				if (num != 0)
				{
				}
				num = (short)1844969472;
				if (num != 0)
				{
				}
				return this.ApxRadioSummaryEntity.AstroOtarEnable;
			}
			set
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				bool? astroOtarEnable;
				bool? flag;
				short num2;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						this.ApxRadioSummaryEntity.AstroOtarEnable = value;
						goto IL_84;
					case 1:
						goto IL_9D;
					case 2:
						if (!(astroOtarEnable.GetValueOrDefault() == flag.GetValueOrDefault() & astroOtarEnable != null == (flag != null)))
						{
							num2 = (short)1802371072;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_9D;
					}
					goto IL_1C;
					IL_84:
					num2 = (short)1200553985;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_9D:
					num2 = (short)1656487937;
					if (num2 != 0)
					{
					}
					num2 = (short)340721664;
					short num3 = num2;
					num2 = (short)815152622;
					short num4 = num2;
					num2 = (short)1563704814;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_84;
					default:
						goto IL_123;
					}
				}
				IL_123:
				num2 = (short)1283325952;
				if (num2 != 0)
				{
				}
				return;
				IL_1C:
				astroOtarEnable = this.ApxRadioSummaryEntity.AstroOtarEnable;
				flag = value;
				num2 = (short)48431106;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x060007F0 RID: 2032 RVA: 0x000759B8 File Offset: 0x00073BB8
		// (set) Token: 0x060007F1 RID: 2033 RVA: 0x00075A6C File Offset: 0x00073C6C
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public int? SecureOperation
		{
			get
			{
				short num = (short)523528823;
				short num2 = num;
				num = (short)1568959095;
				switch (num2 == num)
				{
				default:
				{
					num = (short)271450112;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)461570049;
				if (num != 0)
				{
				}
				num = (short)1873870848;
				if (num != 0)
				{
				}
				return this.ApxRadioSummaryEntity.SecureOperation;
			}
			set
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				int? secureOperation;
				int? num2;
				short num3;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						this.ApxRadioSummaryEntity.SecureOperation = value;
						goto IL_AE;
					case 1:
						goto IL_C7;
					case 2:
						if (!(secureOperation.GetValueOrDefault() == num2.GetValueOrDefault() & secureOperation != null == (num2 != null)))
						{
							num3 = (short)1297612800;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						goto IL_C7;
					}
					goto IL_1C;
					IL_AE:
					num3 = (short)1626537985;
					num = (int)((global::System.IntPtr)num3);
					continue;
					IL_C7:
					num3 = (short)1720320000;
					short num4 = num3;
					num3 = (short)237480816;
					short num5 = num3;
					num3 = (short)404007792;
					switch ((num5 == num3) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_AE;
					default:
						goto IL_125;
					}
				}
				IL_125:
				num3 = (short)1237123072;
				if (num3 != 0)
				{
				}
				return;
				IL_1C:
				num3 = (short)105775105;
				if (num3 != 0)
				{
				}
				secureOperation = this.ApxRadioSummaryEntity.SecureOperation;
				num2 = value;
				num3 = (short)1745551362;
				num = (int)((global::System.IntPtr)num3);
				goto IL_0A;
			}
		}

		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x060007F2 RID: 2034 RVA: 0x00075BB4 File Offset: 0x00073DB4
		// (set) Token: 0x060007F3 RID: 2035 RVA: 0x00075C68 File Offset: 0x00073E68
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public bool? AESEnable
		{
			get
			{
				short num = (short)1896944275;
				short num2 = num;
				num = (short)1855001235;
				switch (num2 == num)
				{
				default:
				{
					num = (short)595460096;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2070151169;
				if (num != 0)
				{
				}
				num = (short)1130627072;
				if (num != 0)
				{
				}
				return this.ApxRadioSummaryEntity.AESEnable;
			}
			set
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				bool? aesenable;
				bool? flag;
				short num2;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						this.ApxRadioSummaryEntity.AESEnable = value;
						goto IL_AE;
					case 1:
						goto IL_C7;
					case 2:
						if (!(aesenable.GetValueOrDefault() == flag.GetValueOrDefault() & aesenable != null == (flag != null)))
						{
							num2 = (short)953614336;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_C7;
					}
					goto IL_1C;
					IL_AE:
					num2 = (short)1737687041;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_C7:
					num2 = (short)2084241408;
					short num3 = num2;
					num2 = (short)252478404;
					short num4 = num2;
					num2 = (short)249004996;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_AE;
					default:
						goto IL_125;
					}
				}
				IL_125:
				num2 = (short)385875968;
				if (num2 != 0)
				{
				}
				return;
				IL_1C:
				num2 = (short)425394177;
				if (num2 != 0)
				{
				}
				aesenable = this.ApxRadioSummaryEntity.AESEnable;
				flag = value;
				num2 = (short)1628962818;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x170003B9 RID: 953
		// (get) Token: 0x060007F4 RID: 2036 RVA: 0x00075DB0 File Offset: 0x00073FB0
		// (set) Token: 0x060007F5 RID: 2037 RVA: 0x00075E64 File Offset: 0x00074064
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public int? AssignmentType
		{
			get
			{
				short num = (short)106430464;
				short num2 = num;
				num = (short)104045890;
				short num3 = num;
				num = (short)489266498;
				switch (num3 == num)
				{
				}
				num = (short)47316993;
				if (num != 0)
				{
				}
				num = (short)942997504;
				if (num != 0)
				{
				}
				return this.ApxRadioSummaryEntity.BluetoothDunPeerIpAssignmentType;
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
				int? bluetoothDunPeerIpAssignmentType;
				int? num5;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
					{
						num2 = (short)1833649364;
						short num3 = num2;
						num2 = (short)1356350676;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
						{
							num2 = (short)1324613633;
							if (num2 != 0)
							{
							}
							num2 = (short)1932394496;
							if (num2 != 0)
							{
							}
							num2 = (short)3276800;
							short num4 = num2;
							if (!(bluetoothDunPeerIpAssignmentType.GetValueOrDefault() == num5.GetValueOrDefault() & bluetoothDunPeerIpAssignmentType != null == (num5 != null)))
							{
								num2 = (short)1696989186;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							return;
						}
						}
						break;
					}
					case 1:
						return;
					case 2:
						this.ApxRadioSummaryEntity.BluetoothDunPeerIpAssignmentType = value;
						num2 = (short)544145409;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1C;
				}
				return;
				IL_1C:
				bluetoothDunPeerIpAssignmentType = this.ApxRadioSummaryEntity.BluetoothDunPeerIpAssignmentType;
				num5 = value;
				num2 = (short)437387264;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x170003BA RID: 954
		// (get) Token: 0x060007F6 RID: 2038 RVA: 0x00075FB0 File Offset: 0x000741B0
		// (set) Token: 0x060007F7 RID: 2039 RVA: 0x00076064 File Offset: 0x00074264
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public bool? BluetoothEnable
		{
			get
			{
				short num = (short)250085376;
				short num2 = num;
				num = (short)145818773;
				short num3 = num;
				num = (short)88671381;
				switch (num3 == num)
				{
				}
				num = (short)1682046977;
				if (num != 0)
				{
				}
				num = (short)273481728;
				if (num != 0)
				{
				}
				return this.ApxRadioSummaryEntity.BluetoothEnable;
			}
			set
			{
				switch (0)
				{
				case 0:
					goto IL_42;
				}
				short num;
				int num2;
				bool? bluetoothEnable;
				bool? flag;
				for (;;)
				{
					IL_0A:
					num = (short)825622529;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
					{
						num = (short)1030183789;
						short num3 = num;
						num = (short)1540119405;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
						{
							num = (short)1948057600;
							if (num != 0)
							{
							}
							num = (short)42926080;
							short num4 = num;
							if (!(bluetoothEnable.GetValueOrDefault() == flag.GetValueOrDefault() & bluetoothEnable != null == (flag != null)))
							{
								num = (short)143654914;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						}
						}
						break;
					}
					case 1:
						return;
					case 2:
						this.ApxRadioSummaryEntity.BluetoothEnable = value;
						num = (short)854327297;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_42;
				}
				return;
				IL_42:
				bluetoothEnable = this.ApxRadioSummaryEntity.BluetoothEnable;
				flag = value;
				num = (short)108724224;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_0A;
			}
		}

		// Token: 0x170003BB RID: 955
		// (get) Token: 0x060007F8 RID: 2040 RVA: 0x000761B0 File Offset: 0x000743B0
		// (set) Token: 0x060007F9 RID: 2041 RVA: 0x00076268 File Offset: 0x00074468
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public bool? LocationEnable
		{
			get
			{
				short num = (short)107675648;
				short num2 = num;
				num = (short)842450757;
				short num3 = num;
				num = (short)872662853;
				switch (num3 == num)
				{
				}
				num = (short)932315137;
				if (num != 0)
				{
				}
				num = (short)1827340288;
				if (num != 0)
				{
				}
				return this.ApxRadioSummaryEntity.LocationEnable;
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
				bool? locationEnable;
				bool? flag;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
					{
						num2 = (short)792838554;
						short num3 = num2;
						num2 = (short)184205722;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
						{
							num2 = (short)824967169;
							if (num2 != 0)
							{
							}
							num2 = (short)661651456;
							if (num2 != 0)
							{
							}
							num2 = (short)1023148032;
							short num4 = num2;
							if (!(locationEnable.GetValueOrDefault() == flag.GetValueOrDefault() & locationEnable != null == (flag != null)))
							{
								num2 = (short)667156482;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							return;
						}
						}
						break;
					}
					case 1:
						return;
					case 2:
						this.ApxRadioSummaryEntity.LocationEnable = value;
						num2 = (short)2122776577;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1C;
				}
				return;
				IL_1C:
				locationEnable = this.ApxRadioSummaryEntity.LocationEnable;
				flag = value;
				num2 = (short)2883584;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x170003BC RID: 956
		// (get) Token: 0x060007FA RID: 2042 RVA: 0x000763B4 File Offset: 0x000745B4
		// (set) Token: 0x060007FB RID: 2043 RVA: 0x00076468 File Offset: 0x00074668
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public bool? P25LocationReporting
		{
			get
			{
				short num = (short)280494080;
				short num2 = num;
				num = (short)470196982;
				short num3 = num;
				num = (short)348889846;
				switch (num3 == num)
				{
				}
				num = (short)1912078337;
				if (num != 0)
				{
				}
				num = (short)1049886720;
				if (num != 0)
				{
				}
				return this.ApxRadioSummaryEntity.P25LocationReporting;
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
				bool? p25LocationReporting;
				bool? flag;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
					{
						num2 = (short)1539429485;
						short num3 = num2;
						num2 = (short)838456429;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
						{
							num2 = (short)93585408;
							if (num2 != 0)
							{
							}
							num2 = (short)796327936;
							short num4 = num2;
							if (!(p25LocationReporting.GetValueOrDefault() == flag.GetValueOrDefault() & p25LocationReporting != null == (flag != null)))
							{
								num2 = (short)1754202114;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							return;
						}
						}
						break;
					}
					case 1:
						return;
					case 2:
						this.ApxRadioSummaryEntity.P25LocationReporting = value;
						num2 = (short)1134297089;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1C;
				}
				return;
				IL_1C:
				num2 = (short)655622145;
				if (num2 != 0)
				{
				}
				p25LocationReporting = this.ApxRadioSummaryEntity.P25LocationReporting;
				flag = value;
				num2 = (short)1896284160;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x170003BD RID: 957
		// (get) Token: 0x060007FC RID: 2044 RVA: 0x000765B4 File Offset: 0x000747B4
		// (set) Token: 0x060007FD RID: 2045 RVA: 0x00076668 File Offset: 0x00074868
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public string LocServerIPAddress
		{
			get
			{
				short num = (short)1946157056;
				short num2 = num;
				num = (short)928398224;
				short num3 = num;
				num = (short)588462992;
				switch (num3 == num)
				{
				}
				num = (short)497025024;
				if (num != 0)
				{
				}
				num = (short)1551761409;
				if (num != 0)
				{
				}
				return this.ApxRadioSummaryEntity.LocationServerIPAddress;
			}
			set
			{
				for (;;)
				{
					IL_00:
					short num = (short)265093120;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
						{
							num = (short)487072561;
							short num3 = num;
							num = (short)1080173361;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
							{
								num = (short)1971322880;
								short num4 = num;
								num = (short)1503068160;
								if (num != 0)
								{
								}
								switch (0)
								{
								case 0:
									goto IL_A8;
								}
								continue;
							}
							}
							break;
						}
						case 1:
							return;
						case 2:
							this.ApxRadioSummaryEntity.LocationServerIPAddress = value;
							num = (short)2040266753;
							if (num != 0)
							{
							}
							num = (short)408748033;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_A8:
						if (!(this.ApxRadioSummaryEntity.LocationServerIPAddress != value))
						{
							return;
						}
						num = (short)731119618;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
			}
		}

		// Token: 0x170003BE RID: 958
		// (get) Token: 0x060007FE RID: 2046 RVA: 0x00076798 File Offset: 0x00074998
		// (set) Token: 0x060007FF RID: 2047 RVA: 0x0007684C File Offset: 0x00074A4C
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public int? ArsMode
		{
			get
			{
				short num = (short)1728315392;
				short num2 = num;
				num = (short)1442028376;
				short num3 = num;
				num = (short)741055320;
				switch (num3 == num)
				{
				}
				num = (short)1985937409;
				if (num != 0)
				{
				}
				num = (short)1407844352;
				if (num != 0)
				{
				}
				return this.ApxRadioSummaryEntity.ArsMode;
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
				int? arsMode;
				int? num4;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
					{
						num2 = (short)1447373741;
						short num3 = num2;
						num2 = (short)750136237;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							num2 = (short)1024917504;
							if (num2 != 0)
							{
							}
							if (!(arsMode.GetValueOrDefault() == num4.GetValueOrDefault() & arsMode != null == (num4 != null)))
							{
								num2 = (short)1773338624;
								short num5 = num2;
								num2 = (short)1477246978;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							return;
						}
						break;
					}
					case 1:
						goto IL_115;
					case 2:
						this.ApxRadioSummaryEntity.ArsMode = value;
						num2 = (short)1477312513;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1C;
				}
				IL_115:
				num2 = (short)738197505;
				if (num2 != 0)
				{
				}
				return;
				IL_1C:
				arsMode = this.ApxRadioSummaryEntity.ArsMode;
				num4 = value;
				num2 = (short)1419706368;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x170003BF RID: 959
		// (get) Token: 0x06000800 RID: 2048 RVA: 0x00076998 File Offset: 0x00074B98
		// (set) Token: 0x06000801 RID: 2049 RVA: 0x00076A4C File Offset: 0x00074C4C
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public bool? DirectLocationRegistration
		{
			get
			{
				short num = (short)1099431936;
				short num2 = num;
				num = (short)1089470465;
				if (num != 0)
				{
				}
				num = (short)930130856;
				short num3 = num;
				num = (short)1602857896;
				switch (num3 == num)
				{
				}
				num = (short)944898048;
				if (num != 0)
				{
				}
				return this.ApxRadioSummaryEntity.DirectLocationRegistration;
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
				bool? directLocationRegistration;
				bool? flag;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
					{
						num2 = (short)1053097124;
						short num3 = num2;
						num2 = (short)1539243172;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
						{
							num2 = (short)1880031232;
							if (num2 != 0)
							{
							}
							num2 = (short)1164312577;
							if (num2 != 0)
							{
							}
							num2 = (short)317325312;
							short num4 = num2;
							if (!(directLocationRegistration.GetValueOrDefault() == flag.GetValueOrDefault() & directLocationRegistration != null == (flag != null)))
							{
								num2 = (short)699465730;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							return;
						}
						}
						break;
					}
					case 1:
						return;
					case 2:
						this.ApxRadioSummaryEntity.DirectLocationRegistration = value;
						num2 = (short)1057292289;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1C;
				}
				return;
				IL_1C:
				directLocationRegistration = this.ApxRadioSummaryEntity.DirectLocationRegistration;
				flag = value;
				num2 = (short)46071808;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x170003C0 RID: 960
		// (get) Token: 0x06000802 RID: 2050 RVA: 0x00076B98 File Offset: 0x00074D98
		// (set) Token: 0x06000803 RID: 2051 RVA: 0x00076C4C File Offset: 0x00074E4C
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public string BluetoothPANNetworkBaseAddress
		{
			get
			{
				short num = (short)153223168;
				short num2 = num;
				num = (short)887733593;
				short num3 = num;
				num = (short)993312089;
				switch (num3 == num)
				{
				}
				num = (short)544800768;
				if (num != 0)
				{
				}
				num = (short)172228609;
				if (num != 0)
				{
				}
				return this.ApxRadioSummaryEntity.BluetoothPANNetworkBaseAddress;
			}
			set
			{
				for (;;)
				{
					IL_00:
					short num = (short)1561198592;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
						{
							num = (short)1468268545;
							if (num != 0)
							{
							}
							num = (short)990504433;
							short num3 = num;
							num = (short)979232241;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							case 1:
								break;
							default:
							{
								num = (short)168886272;
								short num4 = num;
								break;
							}
							}
							num = (short)1649278976;
							if (num != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_CD;
							}
							continue;
						}
						case 1:
							return;
						case 2:
							this.ApxRadioSummaryEntity.BluetoothPANNetworkBaseAddress = value;
							num = (short)531300353;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_CD:
						if (!(this.ApxRadioSummaryEntity.BluetoothPANNetworkBaseAddress != value))
						{
							return;
						}
						num = (short)1795096578;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
			}
		}

		// Token: 0x170003C1 RID: 961
		// (get) Token: 0x06000804 RID: 2052 RVA: 0x00076D74 File Offset: 0x00074F74
		// (set) Token: 0x06000805 RID: 2053 RVA: 0x00076E28 File Offset: 0x00075028
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public int? UserNameDisplayTextSize
		{
			get
			{
				short num = (short)77070336;
				short num2 = num;
				num = (short)1232586128;
				short num3 = num;
				num = (short)607438224;
				switch (num3 == num)
				{
				}
				num = (short)1256980481;
				if (num != 0)
				{
				}
				num = (short)1838874624;
				if (num != 0)
				{
				}
				return this.ApxRadioSummaryEntity.UserNameDisplayTextSize;
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
				int? userNameDisplayTextSize;
				int? num5;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
					{
						num2 = (short)574561946;
						short num3 = num2;
						num2 = (short)1188372122;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
						{
							num2 = (short)1387069441;
							if (num2 != 0)
							{
							}
							num2 = (short)830865408;
							if (num2 != 0)
							{
							}
							num2 = (short)570753024;
							short num4 = num2;
							if (!(userNameDisplayTextSize.GetValueOrDefault() == num5.GetValueOrDefault() & userNameDisplayTextSize != null == (num5 != null)))
							{
								num2 = (short)761462786;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							return;
						}
						}
						break;
					}
					case 1:
						return;
					case 2:
						this.ApxRadioSummaryEntity.UserNameDisplayTextSize = value;
						num2 = (short)1716584449;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1C;
				}
				return;
				IL_1C:
				userNameDisplayTextSize = this.ApxRadioSummaryEntity.UserNameDisplayTextSize;
				num5 = value;
				num2 = (short)1250426880;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x170003C2 RID: 962
		// (get) Token: 0x06000806 RID: 2054 RVA: 0x00076F6C File Offset: 0x0007516C
		// (set) Token: 0x06000807 RID: 2055 RVA: 0x00077020 File Offset: 0x00075220
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public int? UserLoginUnitIDTextSize
		{
			get
			{
				short num = (short)169934848;
				short num2 = num;
				num = (short)570644623;
				short num3 = num;
				num = (short)1148475535;
				switch (num3 == num)
				{
				}
				num = (short)2142502912;
				if (num != 0)
				{
				}
				num = (short)141557761;
				if (num != 0)
				{
				}
				return this.ApxRadioSummaryEntity.UserLoginUnitIDTextSize;
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
				int? userLoginUnitIDTextSize;
				int? num4;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
					{
						num2 = (short)1279995463;
						short num3 = num2;
						num2 = (short)705310279;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							num2 = (short)1402273792;
							if (num2 != 0)
							{
							}
							if (!(userLoginUnitIDTextSize.GetValueOrDefault() == num4.GetValueOrDefault() & userLoginUnitIDTextSize != null == (num4 != null)))
							{
								num2 = (short)1517551616;
								short num5 = num2;
								num2 = (short)1951924226;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							goto IL_115;
						}
						break;
					}
					case 1:
						goto IL_113;
					case 2:
						this.ApxRadioSummaryEntity.UserLoginUnitIDTextSize = value;
						num2 = (short)1886322689;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1C;
				}
				IL_113:
				IL_115:
				num2 = (short)235732993;
				if (num2 != 0)
				{
				}
				return;
				IL_1C:
				userLoginUnitIDTextSize = this.ApxRadioSummaryEntity.UserLoginUnitIDTextSize;
				num4 = value;
				num2 = (short)1015939072;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x170003C3 RID: 963
		// (get) Token: 0x06000808 RID: 2056 RVA: 0x0007716C File Offset: 0x0007536C
		// (set) Token: 0x06000809 RID: 2057 RVA: 0x00077224 File Offset: 0x00075424
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public bool? UserLoginUnitIDEnable
		{
			get
			{
				short num = (short)554958848;
				short num2 = num;
				num = (short)284627790;
				short num3 = num;
				num = (short)58659662;
				switch (num3 == num)
				{
				}
				num = (short)636223488;
				if (num != 0)
				{
				}
				num = (short)1208483841;
				if (num != 0)
				{
				}
				return this.ApxRadioSummaryEntity.UserLoginUnitIDEnable;
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
				bool? userLoginUnitIDEnable;
				bool? flag;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
					{
						num2 = (short)420741121;
						if (num2 != 0)
						{
						}
						num2 = (short)1714494950;
						short num3 = num2;
						num2 = (short)884743654;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
						{
							num2 = (short)206700544;
							if (num2 != 0)
							{
							}
							num2 = (short)440991744;
							short num4 = num2;
							if (!(userLoginUnitIDEnable.GetValueOrDefault() == flag.GetValueOrDefault() & userLoginUnitIDEnable != null == (flag != null)))
							{
								num2 = (short)1078132738;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							return;
						}
						}
						break;
					}
					case 1:
						return;
					case 2:
						this.ApxRadioSummaryEntity.UserLoginUnitIDEnable = value;
						num2 = (short)868024321;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1C;
				}
				return;
				IL_1C:
				userLoginUnitIDEnable = this.ApxRadioSummaryEntity.UserLoginUnitIDEnable;
				flag = value;
				num2 = (short)26869760;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x170003C4 RID: 964
		// (get) Token: 0x0600080A RID: 2058 RVA: 0x00077374 File Offset: 0x00075574
		// (set) Token: 0x0600080B RID: 2059 RVA: 0x0007742C File Offset: 0x0007562C
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public string AutoRegServerAddress
		{
			get
			{
				short num = (short)1603469312;
				short num2 = num;
				num = (short)84786191;
				short num3 = num;
				num = (short)1851112463;
				switch (num3 == num)
				{
				}
				num = (short)2145320961;
				if (num != 0)
				{
				}
				num = (short)802357248;
				if (num != 0)
				{
				}
				return this.ApxRadioSummaryEntity.AutomaticRegistrationServerAddress;
			}
			set
			{
				for (;;)
				{
					IL_00:
					short num = (short)93585408;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						num = (short)693501953;
						if (num != 0)
						{
						}
						switch (num2)
						{
						case 0:
						{
							num = (short)1122903962;
							short num3 = num;
							num = (short)949102490;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
							{
								num = (short)1330053120;
								short num4 = num;
								num = (short)2050031616;
								if (num != 0)
								{
								}
								switch (0)
								{
								case 0:
									goto IL_D2;
								}
								continue;
							}
							}
							break;
						}
						case 1:
							return;
						case 2:
							this.ApxRadioSummaryEntity.AutomaticRegistrationServerAddress = value;
							num = (short)1917321217;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_D2:
						if (!(this.ApxRadioSummaryEntity.AutomaticRegistrationServerAddress != value))
						{
							return;
						}
						num = (short)667090946;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
			}
		}

		// Token: 0x170003C5 RID: 965
		// (get) Token: 0x0600080C RID: 2060 RVA: 0x0007755C File Offset: 0x0007575C
		// (set) Token: 0x0600080D RID: 2061 RVA: 0x00077614 File Offset: 0x00075814
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public byte[] ServerSideASTROPurchasedFlashCode
		{
			get
			{
				short num = (short)651231232;
				short num2 = num;
				num = (short)1599692737;
				short num3 = num;
				num = (short)638803905;
				switch (num3 == num)
				{
				}
				num = (short)1270808577;
				if (num != 0)
				{
				}
				num = (short)712245248;
				if (num != 0)
				{
				}
				return this.ApxRadioSummaryEntity.AstroPurchasedFlashCode;
			}
			set
			{
				for (;;)
				{
					IL_00:
					short num = (short)1932853248;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
						{
							num = (short)1523685364;
							short num3 = num;
							num = (short)2011600884;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
							{
								num = (short)1716387840;
								short num4 = num;
								num = (short)1526464513;
								if (num != 0)
								{
								}
								num = (short)1068892160;
								if (num != 0)
								{
								}
								switch (0)
								{
								case 0:
									goto IL_CC;
								}
								continue;
							}
							}
							break;
						}
						case 1:
							return;
						case 2:
							this.ApxRadioSummaryEntity.AstroPurchasedFlashCode = value;
							num = (short)1577320449;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_CC:
						if (this.ApxRadioSummaryEntity.AstroPurchasedFlashCode == value)
						{
							return;
						}
						num = (short)735641602;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
			}
		}

		// Token: 0x170003C6 RID: 966
		// (get) Token: 0x0600080E RID: 2062 RVA: 0x00077738 File Offset: 0x00075938
		// (set) Token: 0x0600080F RID: 2063 RVA: 0x000777E8 File Offset: 0x000759E8
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public int? LanguageIndex
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1100283904;
				short num2 = num;
				num = (short)42848886;
				short num3 = num;
				num = (short)1673450102;
				switch (num3 == num)
				{
				}
				num = (short)951517185;
				if (num != 0)
				{
				}
				num = (short)200933376;
				if (num != 0)
				{
				}
				return this.i;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1788477440;
				short num2 = num;
				num = (short)1837342689;
				short num3 = num;
				num = (short)153853921;
				switch (num3 == num)
				{
				}
				num = (short)1252392961;
				if (num != 0)
				{
				}
				num = (short)1632632832;
				if (num != 0)
				{
				}
				this.i = value;
			}
		}

		// Token: 0x170003C7 RID: 967
		// (get) Token: 0x06000810 RID: 2064 RVA: 0x00077898 File Offset: 0x00075A98
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public string LPWarningCode
		{
			get
			{
				short num = (short)665387008;
				short num2 = num;
				num = (short)1399211935;
				short num3 = num;
				num = (short)444155807;
				switch (num3 == num)
				{
				}
				num = (short)1719992321;
				if (num != 0)
				{
				}
				num = (short)323944448;
				if (num != 0)
				{
				}
				return this.ApxRadioSummaryEntity.LPWarningCode;
			}
		}

		// Token: 0x170003C8 RID: 968
		// (get) Token: 0x06000811 RID: 2065 RVA: 0x0007794C File Offset: 0x00075B4C
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public bool Provisioned
		{
			get
			{
				short num = (short)570032128;
				short num2 = num;
				num = (short)917476564;
				short num3 = num;
				num = (short)411145428;
				switch (num3 == num)
				{
				}
				num = (short)890437632;
				if (num != 0)
				{
				}
				num = (short)2122776577;
				if (num != 0)
				{
				}
				return this.ApxRadioSummaryEntity.Provisioned;
			}
		}

		// Token: 0x170003C9 RID: 969
		// (get) Token: 0x06000812 RID: 2066 RVA: 0x00077A04 File Offset: 0x00075C04
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public global::System.DateTime? LastContactTime
		{
			get
			{
				short num = (short)1903820800;
				short num2 = num;
				num = (short)299411934;
				short num3 = num;
				num = (short)566143454;
				switch (num3 == num)
				{
				}
				num = (short)823656449;
				if (num != 0)
				{
				}
				num = (short)1113194496;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.ServerDateTimeToUI(this.ApxRadioSummaryEntity.LastContactTime);
			}
		}

		// Token: 0x170003CA RID: 970
		// (get) Token: 0x06000813 RID: 2067 RVA: 0x00077ABC File Offset: 0x00075CBC
		// (set) Token: 0x06000814 RID: 2068 RVA: 0x00077B74 File Offset: 0x00075D74
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public bool? DVRSHardwareEnable
		{
			get
			{
				short num = (short)878641152;
				short num2 = num;
				num = (short)1949499393;
				if (num != 0)
				{
				}
				num = (short)569611202;
				short num3 = num;
				num = (short)580817858;
				switch (num3 == num)
				{
				}
				num = (short)1457586176;
				if (num != 0)
				{
				}
				return this.ApxRadioSummaryEntity.DVRSHardwareEnable;
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
				bool? dvrshardwareEnable;
				bool? flag;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
					{
						num2 = (short)2010590759;
						short num3 = num2;
						num2 = (short)1235955239;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							num2 = (short)1590099968;
							if (num2 != 0)
							{
							}
							if (!(dvrshardwareEnable.GetValueOrDefault() == flag.GetValueOrDefault() & dvrshardwareEnable != null == (flag != null)))
							{
								num2 = (short)1837432832;
								short num4 = num2;
								num2 = (short)883228673;
								if (num2 != 0)
								{
								}
								num2 = (short)2070740994;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							return;
						}
						break;
					}
					case 1:
						return;
					case 2:
						this.ApxRadioSummaryEntity.DVRSHardwareEnable = value;
						num2 = (short)342818817;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1C;
				}
				return;
				IL_1C:
				dvrshardwareEnable = this.ApxRadioSummaryEntity.DVRSHardwareEnable;
				flag = value;
				num2 = (short)1099825152;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x170003CB RID: 971
		// (get) Token: 0x06000815 RID: 2069 RVA: 0x00077CC4 File Offset: 0x00075EC4
		// (set) Token: 0x06000816 RID: 2070 RVA: 0x00077D78 File Offset: 0x00075F78
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify("IsVRIDEditable", 23, true)]
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.EntitytMemberName("VRID")]
		public int? VRID
		{
			get
			{
				short num = (short)1088618496;
				short num2 = num;
				num = (short)801437761;
				short num3 = num;
				num = (short)173799489;
				switch (num3 == num)
				{
				}
				num = (short)1773142016;
				if (num != 0)
				{
				}
				num = (short)784596993;
				if (num != 0)
				{
				}
				return this.ApxRadioSummaryEntity.VRID;
			}
			set
			{
				short num = (short)2077753344;
				short num2 = num;
				num = (short)700800202;
				short num3 = num;
				num = (short)2142264522;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1608318976;
					if (num != 0)
					{
					}
					int? num4 = value;
					int? vrid = this.ApxRadioSummaryEntity.VRID;
					if (!(num4.GetValueOrDefault() == vrid.GetValueOrDefault() & num4 != null == (vrid != null)))
					{
						this.ApxRadioSummaryEntity.VRID = value;
						base.RaisePropertyChanged<int?>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<int?>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio.get_VRID())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						return;
					}
					break;
				}
				}
				num = (short)1749221377;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x170003CC RID: 972
		// (get) Token: 0x06000817 RID: 2071 RVA: 0x00077E98 File Offset: 0x00076098
		// (set) Token: 0x06000818 RID: 2072 RVA: 0x00077F48 File Offset: 0x00076148
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public virtual bool IsUserLoginUnitIDEditable
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1163526144;
				short num2 = num;
				num = (short)2035479513;
				short num3 = num;
				num = (short)545387481;
				switch (num3 == num)
				{
				}
				num = (short)1133445121;
				if (num != 0)
				{
				}
				num = (short)1346240512;
				if (num != 0)
				{
				}
				return this.j;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)91947008;
				short num2 = num;
				num = (short)1036864430;
				short num3 = num;
				num = (short)1518881710;
				switch (num3 == num)
				{
				}
				num = (short)107479041;
				if (num != 0)
				{
				}
				num = (short)1259667456;
				if (num != 0)
				{
				}
				this.j = value;
			}
		}

		// Token: 0x170003CD RID: 973
		// (get) Token: 0x06000819 RID: 2073 RVA: 0x00077FF8 File Offset: 0x000761F8
		// (set) Token: 0x0600081A RID: 2074 RVA: 0x000780A8 File Offset: 0x000762A8
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public virtual bool IsOtarIDEditable
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1542901004;
				short num2 = num;
				num = (short)618646796;
				switch (num2 == num)
				{
				}
				num = (short)1919614976;
				short num3 = num;
				num = (short)1416232961;
				if (num != 0)
				{
				}
				num = (short)1045692416;
				if (num != 0)
				{
				}
				return this.k;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1305521553;
				short num2 = num;
				num = (short)982494609;
				switch (num2 == num)
				{
				}
				num = (short)1646723072;
				short num3 = num;
				num = (short)603455488;
				if (num != 0)
				{
				}
				num = (short)1966407681;
				if (num != 0)
				{
				}
				this.k = value;
			}
		}

		// Token: 0x170003CE RID: 974
		// (get) Token: 0x0600081B RID: 2075 RVA: 0x00078158 File Offset: 0x00076358
		// (set) Token: 0x0600081C RID: 2076 RVA: 0x00078204 File Offset: 0x00076404
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public virtual bool IsGroupDataJobIDEditable
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)120061953;
				if (num != 0)
				{
				}
				num = (short)1261091061;
				short num2 = num;
				num = (short)266778869;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1389559808;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1481179136;
				if (num != 0)
				{
				}
				return this.l;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1327393606;
				short num2 = num;
				num = (short)1814063942;
				switch (num2 == num)
				{
				}
				num = (short)1013514240;
				short num3 = num;
				num = (short)1407254528;
				if (num != 0)
				{
				}
				num = (short)1224146945;
				if (num != 0)
				{
				}
				this.l = value;
			}
		}

		// Token: 0x170003CF RID: 975
		// (get) Token: 0x0600081D RID: 2077 RVA: 0x000782B4 File Offset: 0x000764B4
		// (set) Token: 0x0600081E RID: 2078 RVA: 0x00078364 File Offset: 0x00076564
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public virtual bool IsBluetoothDUNPeerIPEditable
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)421345443;
				short num2 = num;
				num = (short)1930836131;
				switch (num2 == num)
				{
				}
				num = (short)260308992;
				short num3 = num;
				num = (short)966393857;
				if (num != 0)
				{
				}
				num = (short)42336256;
				if (num != 0)
				{
				}
				return this.m;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)349884225;
				short num2 = num;
				num = (short)323931969;
				switch (num2 == num)
				{
				}
				num = (short)933101568;
				short num3 = num;
				num = (short)637534208;
				if (num != 0)
				{
				}
				num = (short)219611137;
				if (num != 0)
				{
				}
				this.m = value;
			}
		}

		// Token: 0x170003D0 RID: 976
		// (get) Token: 0x0600081F RID: 2079 RVA: 0x00078418 File Offset: 0x00076618
		// (set) Token: 0x06000820 RID: 2080 RVA: 0x000784C4 File Offset: 0x000766C4
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public virtual bool IsBluetoothDUNSubscriberIPEditable
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1695341035;
				short num2 = num;
				num = (short)537319915;
				switch (num2 == num)
				{
				}
				num = (short)1315897344;
				short num3 = num;
				num = (short)1558708224;
				if (num != 0)
				{
				}
				num = (short)698417153;
				if (num != 0)
				{
				}
				return this.n;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1384644609;
				if (num != 0)
				{
				}
				num = (short)580247938;
				short num2 = num;
				num = (short)240574850;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1673199616;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1588068352;
				if (num != 0)
				{
				}
				this.n = value;
			}
		}

		// Token: 0x170003D1 RID: 977
		// (get) Token: 0x06000821 RID: 2081 RVA: 0x00078570 File Offset: 0x00076770
		// (set) Token: 0x06000822 RID: 2082 RVA: 0x00078620 File Offset: 0x00076820
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public virtual bool IsBluetoothFriendlyNameEditable
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1643352183;
				short num2 = num;
				num = (short)988516471;
				switch (num2 == num)
				{
				}
				num = (short)837091328;
				short num3 = num;
				num = (short)551223297;
				if (num != 0)
				{
				}
				num = (short)1244332032;
				if (num != 0)
				{
				}
				return this.o;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1019757705;
				short num2 = num;
				num = (short)312427657;
				switch (num2 == num)
				{
				}
				num = (short)1256652800;
				short num3 = num;
				num = (short)203161600;
				if (num != 0)
				{
				}
				num = (short)170065921;
				if (num != 0)
				{
				}
				this.o = value;
			}
		}

		// Token: 0x170003D2 RID: 978
		// (get) Token: 0x06000823 RID: 2083 RVA: 0x000786D0 File Offset: 0x000768D0
		// (set) Token: 0x06000824 RID: 2084 RVA: 0x00078784 File Offset: 0x00076984
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public virtual bool IsUserNameEditable
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1462123086;
				short num2 = num;
				num = (short)474757710;
				switch (num2 == num)
				{
				}
				num = (short)299368448;
				short num3 = num;
				num = (short)1503395841;
				if (num != 0)
				{
				}
				num = (short)1950941184;
				if (num != 0)
				{
				}
				return this.p;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1037721734;
				short num2 = num;
				num = (short)523722886;
				switch (num2 == num)
				{
				}
				num = (short)1602486272;
				short num3 = num;
				num = (short)50397184;
				if (num != 0)
				{
				}
				num = (short)1993736193;
				if (num != 0)
				{
				}
				this.p = value;
			}
		}

		// Token: 0x170003D3 RID: 979
		// (get) Token: 0x06000825 RID: 2085 RVA: 0x00078834 File Offset: 0x00076A34
		// (set) Token: 0x06000826 RID: 2086 RVA: 0x000788E4 File Offset: 0x00076AE4
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public virtual bool IsUserPINEditable
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)452584990;
				short num2 = num;
				num = (short)923788830;
				switch (num2 == num)
				{
				}
				num = (short)1799159808;
				short num3 = num;
				num = (short)1470365697;
				if (num != 0)
				{
				}
				num = (short)1132527616;
				if (num != 0)
				{
				}
				return this.q;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)555055197;
				short num2 = num;
				num = (short)1627355229;
				switch (num2 == num)
				{
				}
				num = (short)486866944;
				short num3 = num;
				num = (short)1697120257;
				if (num != 0)
				{
				}
				num = (short)607715328;
				if (num != 0)
				{
				}
				this.q = value;
			}
		}

		// Token: 0x170003D4 RID: 980
		// (get) Token: 0x06000827 RID: 2087 RVA: 0x00078994 File Offset: 0x00076B94
		// (set) Token: 0x06000828 RID: 2088 RVA: 0x00078A40 File Offset: 0x00076C40
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public virtual bool IsSubscriberIPEditable
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)413354972;
				short num2 = num;
				num = (short)1311460316;
				switch (num2 == num)
				{
				}
				num = (short)1067057152;
				short num3 = num;
				num = (short)336134144;
				if (num != 0)
				{
				}
				num = (short)1090650113;
				if (num != 0)
				{
				}
				return this.r;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)774066912;
				short num2 = num;
				num = (short)1408652000;
				switch (num2 == num)
				{
				}
				num = (short)1416429568;
				short num3 = num;
				num = (short)1367146497;
				if (num != 0)
				{
				}
				num = (short)1580466176;
				if (num != 0)
				{
				}
				this.r = value;
			}
		}

		// Token: 0x170003D5 RID: 981
		// (get) Token: 0x06000829 RID: 2089 RVA: 0x00078AF0 File Offset: 0x00076CF0
		// (set) Token: 0x0600082A RID: 2090 RVA: 0x00078BA0 File Offset: 0x00076DA0
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public virtual bool IsPeerIPEditable
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)450356300;
				short num2 = num;
				num = (short)641131596;
				switch (num2 == num)
				{
				}
				num = (short)1120600064;
				short num3 = num;
				num = (short)603521025;
				if (num != 0)
				{
				}
				num = (short)1731067904;
				if (num != 0)
				{
				}
				return this.s;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)548499573;
				short num2 = num;
				num = (short)836137077;
				switch (num2 == num)
				{
				}
				num = (short)1285685248;
				short num3 = num;
				num = (short)1382088705;
				if (num != 0)
				{
				}
				num = (short)1433468928;
				if (num != 0)
				{
				}
				this.s = value;
			}
		}

		// Token: 0x170003D6 RID: 982
		// (get) Token: 0x0600082B RID: 2091 RVA: 0x00078C54 File Offset: 0x00076E54
		// (set) Token: 0x0600082C RID: 2092 RVA: 0x00078D08 File Offset: 0x00076F08
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public virtual bool IsForeignIPEditable
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1977384795;
				short num2 = num;
				num = (short)567902043;
				switch (num2 == num)
				{
				}
				num = (short)1077280768;
				short num3 = num;
				num = (short)760872961;
				if (num != 0)
				{
				}
				num = (short)424673280;
				if (num != 0)
				{
				}
				return this.t;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)2030698497;
				if (num != 0)
				{
				}
				num = (short)718899397;
				short num2 = num;
				num = (short)906004677;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1732837376;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)45875200;
				if (num != 0)
				{
				}
				this.t = value;
			}
		}

		// Token: 0x170003D7 RID: 983
		// (get) Token: 0x0600082D RID: 2093 RVA: 0x00078DB8 File Offset: 0x00076FB8
		// (set) Token: 0x0600082E RID: 2094 RVA: 0x00078E68 File Offset: 0x00077068
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public virtual bool IsAskRequiredEditable
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1320738042;
				short num2 = num;
				num = (short)1175051514;
				switch (num2 == num)
				{
				}
				num = (short)884342784;
				short num3 = num;
				num = (short)1334771712;
				if (num != 0)
				{
				}
				num = (short)855375873;
				if (num != 0)
				{
				}
				return this.u;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)254213035;
				short num2 = num;
				num = (short)1039399851;
				switch (num2 == num)
				{
				}
				num = (short)382926848;
				short num3 = num;
				num = (short)683540480;
				if (num != 0)
				{
				}
				num = (short)893911041;
				if (num != 0)
				{
				}
				this.u = value;
			}
		}

		// Token: 0x170003D8 RID: 984
		// (get) Token: 0x0600082F RID: 2095 RVA: 0x00078F1C File Offset: 0x0007711C
		// (set) Token: 0x06000830 RID: 2096 RVA: 0x00078FCC File Offset: 0x000771CC
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public virtual bool IsVRIDEditable
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1808084817;
				short num2 = num;
				num = (short)1149644625;
				switch (num2 == num)
				{
				}
				num = (short)1805910016;
				short num3 = num;
				num = (short)1950285825;
				if (num != 0)
				{
				}
				num = (short)1977221120;
				if (num != 0)
				{
				}
				return this.v;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1796927267;
				short num2 = num;
				num = (short)1647177507;
				switch (num2 == num)
				{
				}
				num = (short)32768000;
				short num3 = num;
				num = (short)103481344;
				if (num != 0)
				{
				}
				num = (short)432144385;
				if (num != 0)
				{
				}
				this.v = value;
			}
		}

		// Token: 0x170003D9 RID: 985
		// (get) Token: 0x06000831 RID: 2097 RVA: 0x0007907C File Offset: 0x0007727C
		// (set) Token: 0x06000832 RID: 2098 RVA: 0x0007912C File Offset: 0x0007732C
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public virtual bool IsMSOTAREnabled
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1178206209;
				if (num != 0)
				{
				}
				num = (short)1416692500;
				short num2 = num;
				num = (short)1087963924;
				switch (num2 == num)
				{
				default:
				{
					num = (short)688324608;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)9240576;
				if (num != 0)
				{
				}
				return this.w;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)261786829;
				short num2 = num;
				num = (short)1190628557;
				switch (num2 == num)
				{
				}
				num = (short)817496064;
				short num3 = num;
				num = (short)1463353345;
				if (num != 0)
				{
				}
				num = (short)1585709056;
				if (num != 0)
				{
				}
				this.w = value;
			}
		}

		// Token: 0x170003DA RID: 986
		// (get) Token: 0x06000833 RID: 2099 RVA: 0x000791D8 File Offset: 0x000773D8
		// (set) Token: 0x06000834 RID: 2100 RVA: 0x0007928C File Offset: 0x0007748C
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public string ForeignIPError
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)644349953;
				if (num != 0)
				{
				}
				num = (short)131180219;
				short num2 = num;
				num = (short)1727375035;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1004666880;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)69664768;
				if (num != 0)
				{
				}
				return this.x;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)13400403;
				short num2 = num;
				num = (short)29194579;
				switch (num2 == num)
				{
				}
				num = (short)437649408;
				short num3 = num;
				num = (short)345833473;
				if (num != 0)
				{
				}
				num = (short)1153236992;
				if (num != 0)
				{
				}
				this.x = value;
			}
		}

		// Token: 0x170003DB RID: 987
		// (get) Token: 0x06000835 RID: 2101 RVA: 0x0007933C File Offset: 0x0007753C
		// (set) Token: 0x06000836 RID: 2102 RVA: 0x000793E8 File Offset: 0x000775E8
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public string SubscriberIPError
		{
			get
			{
				short num = (short)1901395969;
				if (num != 0)
				{
				}
				num = (short)1252591509;
				short num2 = num;
				num = (short)928253845;
				switch (num2 == num)
				{
				default:
				{
					num = (short)561971200;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1911554048;
				if (num != 0)
				{
				}
				return this.d;
			}
			set
			{
				short num = (short)385941505;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_FD;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_32;
						}
						continue;
					case 2:
					{
						IL_7D:
						num = (short)894304256;
						short num3 = num;
						this.d = value;
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio.get_SubscriberIP())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)853540864;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_32:
					num = (short)1031602177;
					if (num != 0)
					{
					}
					if (this.d != value)
					{
						num = (short)1667956738;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_FD:
					num = (short)1016921478;
					short num4 = num;
					num = (short)478084486;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_7D;
					default:
						goto IL_133;
					}
				}
				IL_133:
				num = (short)570556416;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x170003DC RID: 988
		// (get) Token: 0x06000837 RID: 2103 RVA: 0x00079540 File Offset: 0x00077740
		// (set) Token: 0x06000838 RID: 2104 RVA: 0x000795F0 File Offset: 0x000777F0
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public string PeerIPError
		{
			get
			{
				short num = (short)1896395623;
				short num2 = num;
				num = (short)42972007;
				switch (num2 == num)
				{
				}
				num = (short)444268544;
				short num3 = num;
				num = (short)288620545;
				if (num != 0)
				{
				}
				num = (short)1946222592;
				if (num != 0)
				{
				}
				return this.e;
			}
			set
			{
				short num = (short)1301479425;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_D5;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_30;
						}
						continue;
					case 2:
					{
						IL_55:
						this.e = value;
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio.get_PeerIP())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1817772032;
						short num3 = num;
						num = (short)834404352;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_30:
					if (this.e != value)
					{
						num = (short)297533442;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_D5:
					num = (short)1269604314;
					short num4 = num;
					num = (short)143630298;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_55;
					default:
						goto IL_10A;
					}
				}
				IL_10A:
				num = (short)631439361;
				if (num != 0)
				{
				}
				num = (short)2090991616;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x170003DD RID: 989
		// (get) Token: 0x06000839 RID: 2105 RVA: 0x00079744 File Offset: 0x00077944
		// (set) Token: 0x0600083A RID: 2106 RVA: 0x000797F4 File Offset: 0x000779F4
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public string BluetoothDUNSubscriberIPError
		{
			get
			{
				short num = (short)1275971967;
				short num2 = num;
				num = (short)745261439;
				switch (num2 == num)
				{
				}
				num = (short)623509504;
				short num3 = num;
				num = (short)720961537;
				if (num != 0)
				{
				}
				num = (short)703463424;
				if (num != 0)
				{
				}
				return this.f;
			}
			set
			{
				short num = (short)1696399361;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_100;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_30;
						}
						continue;
					case 2:
					{
						IL_56:
						this.f = value;
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio.get_BluetoothDUNSubscriberIP())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1744830464;
						short num3 = num;
						num = (short)1470955521;
						if (num != 0)
						{
						}
						num = (short)41091072;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_30:
					if (this.f != value)
					{
						num = (short)2024734722;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_100:
					num = (short)622697026;
					short num4 = num;
					num = (short)96180802;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_56;
					default:
						goto IL_134;
					}
				}
				IL_134:
				num = (short)1159266304;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x170003DE RID: 990
		// (get) Token: 0x0600083B RID: 2107 RVA: 0x0007994C File Offset: 0x00077B4C
		// (set) Token: 0x0600083C RID: 2108 RVA: 0x00079A00 File Offset: 0x00077C00
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public string BluetoothDUNPeerIPError
		{
			get
			{
				short num = (short)572455044;
				short num2 = num;
				num = (short)1146615940;
				switch (num2 == num)
				{
				}
				num = (short)42926080;
				short num3 = num;
				num = (short)1418788865;
				if (num != 0)
				{
				}
				num = (short)1382875136;
				if (num != 0)
				{
				}
				return this.g;
			}
			set
			{
				short num = (short)1518010369;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_FD;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_30;
						}
						continue;
					case 2:
					{
						IL_55:
						num = (short)1256128513;
						if (num != 0)
						{
						}
						num = (short)154796032;
						short num3 = num;
						this.g = value;
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio.get_BluetoothDUNPeerIP())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1302921216;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_30:
					if (this.g != value)
					{
						num = (short)1714225154;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_FD:
					num = (short)1774022920;
					short num4 = num;
					num = (short)1859612936;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_55;
					default:
						goto IL_132;
					}
				}
				IL_132:
				num = (short)1977221120;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x170003DF RID: 991
		// (get) Token: 0x0600083D RID: 2109 RVA: 0x00079B54 File Offset: 0x00077D54
		// (set) Token: 0x0600083E RID: 2110 RVA: 0x00079C04 File Offset: 0x00077E04
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public string UserNameError
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1601675162;
				short num2 = num;
				num = (short)182689690;
				switch (num2 == num)
				{
				}
				num = (short)684982272;
				short num3 = num;
				num = (short)29818881;
				if (num != 0)
				{
				}
				num = (short)286588928;
				if (num != 0)
				{
				}
				return this.y;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1393279744;
				short num2 = num;
				num = (short)50119424;
				switch (num2 == num)
				{
				}
				num = (short)953876480;
				short num3 = num;
				num = (short)878641153;
				if (num != 0)
				{
				}
				num = (short)1200881664;
				if (num != 0)
				{
				}
				this.y = value;
			}
		}

		// Token: 0x170003E0 RID: 992
		// (get) Token: 0x0600083F RID: 2111 RVA: 0x00079CB4 File Offset: 0x00077EB4
		// (set) Token: 0x06000840 RID: 2112 RVA: 0x00079D64 File Offset: 0x00077F64
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public string UserPINError
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)9109505;
				if (num != 0)
				{
				}
				num = (short)301587115;
				short num2 = num;
				num = (short)1544411819;
				switch (num2 == num)
				{
				default:
				{
					num = (short)166920192;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1263992832;
				if (num != 0)
				{
				}
				return this.z;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1485065893;
				short num2 = num;
				num = (short)1021791909;
				switch (num2 == num)
				{
				}
				num = (short)976814080;
				short num3 = num;
				num = (short)36044801;
				if (num != 0)
				{
				}
				num = (short)1468334080;
				if (num != 0)
				{
				}
				this.z = value;
			}
		}

		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x06000841 RID: 2113 RVA: 0x00079E14 File Offset: 0x00078014
		// (set) Token: 0x06000842 RID: 2114 RVA: 0x00079EC4 File Offset: 0x000780C4
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public string UserLoginUnitIDError
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1220534820;
				short num2 = num;
				num = (short)129163812;
				switch (num2 == num)
				{
				}
				num = (short)870973440;
				short num3 = num;
				num = (short)416415745;
				if (num != 0)
				{
				}
				num = (short)1680146432;
				if (num != 0)
				{
				}
				return this.aa;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1210992152;
				short num2 = num;
				num = (short)454182424;
				switch (num2 == num)
				{
				}
				num = (short)2141716480;
				short num3 = num;
				num = (short)2139947009;
				if (num != 0)
				{
				}
				num = (short)1317797888;
				if (num != 0)
				{
				}
				this.aa = value;
			}
		}

		// Token: 0x170003E2 RID: 994
		// (get) Token: 0x06000843 RID: 2115 RVA: 0x00079F78 File Offset: 0x00078178
		// (set) Token: 0x06000844 RID: 2116 RVA: 0x0007A028 File Offset: 0x00078228
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public string OtarIDError
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2048839498;
				short num2 = num;
				num = (short)481152842;
				switch (num2 == num)
				{
				}
				num = (short)177405952;
				short num3 = num;
				num = (short)434569217;
				if (num != 0)
				{
				}
				num = (short)917307392;
				if (num != 0)
				{
				}
				return this.ab;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)828330859;
				short num2 = num;
				num = (short)1092309867;
				switch (num2 == num)
				{
				}
				num = (short)317325312;
				short num3 = num;
				num = (short)1799880705;
				if (num != 0)
				{
				}
				num = (short)1105985536;
				if (num != 0)
				{
				}
				this.ab = value;
			}
		}

		// Token: 0x170003E3 RID: 995
		// (get) Token: 0x06000845 RID: 2117 RVA: 0x0007A0D8 File Offset: 0x000782D8
		// (set) Token: 0x06000846 RID: 2118 RVA: 0x0007A184 File Offset: 0x00078384
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public string PassWordError
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1362139176;
				short num2 = num;
				num = (short)243570728;
				switch (num2 == num)
				{
				}
				num = (short)499843072;
				short num3 = num;
				num = (short)963117057;
				if (num != 0)
				{
				}
				num = (short)190054400;
				if (num != 0)
				{
				}
				return this.ac;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)63061851;
				short num2 = num;
				num = (short)1949122395;
				switch (num2 == num)
				{
				}
				num = (short)1666383872;
				short num3 = num;
				num = (short)940572673;
				if (num != 0)
				{
				}
				num = (short)300154880;
				if (num != 0)
				{
				}
				this.ac = value;
			}
		}

		// Token: 0x170003E4 RID: 996
		// (get) Token: 0x06000847 RID: 2119 RVA: 0x0007A234 File Offset: 0x00078434
		// (set) Token: 0x06000848 RID: 2120 RVA: 0x0007A2E0 File Offset: 0x000784E0
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public string BluetoothFriendlyNameError
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1113284992;
				short num2 = num;
				num = (short)278421888;
				switch (num2 == num)
				{
				}
				num = (short)1662910464;
				short num3 = num;
				num = (short)1664352257;
				if (num != 0)
				{
				}
				num = (short)981860352;
				if (num != 0)
				{
				}
				return this.ad;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1979784310;
				short num2 = num;
				num = (short)268508278;
				switch (num2 == num)
				{
				}
				num = (short)536674304;
				short num3 = num;
				num = (short)1613037569;
				if (num != 0)
				{
				}
				num = (short)823853056;
				if (num != 0)
				{
				}
				this.ad = value;
			}
		}

		// Token: 0x170003E5 RID: 997
		// (get) Token: 0x06000849 RID: 2121 RVA: 0x0007A394 File Offset: 0x00078594
		// (set) Token: 0x0600084A RID: 2122 RVA: 0x0007A444 File Offset: 0x00078644
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public string MismatchError
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)990600705;
				short num2 = num;
				num = (short)1714839041;
				switch (num2 == num)
				{
				}
				num = (short)1414725632;
				short num3 = num;
				num = (short)360775681;
				if (num != 0)
				{
				}
				num = (short)1874788352;
				if (num != 0)
				{
				}
				return this.ae;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)17776865;
				short num2 = num;
				num = (short)340410593;
				switch (num2 == num)
				{
				}
				num = (short)123142144;
				short num3 = num;
				num = (short)704249857;
				if (num != 0)
				{
				}
				num = (short)1380646912;
				if (num != 0)
				{
				}
				this.ae = value;
			}
		}

		// Token: 0x170003E6 RID: 998
		// (get) Token: 0x0600084B RID: 2123 RVA: 0x0007A4F4 File Offset: 0x000786F4
		// (set) Token: 0x0600084C RID: 2124 RVA: 0x0007A5A4 File Offset: 0x000787A4
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public string VRIDError
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1328761306;
				short num2 = num;
				num = (short)1998670298;
				switch (num2 == num)
				{
				}
				num = (short)118358016;
				short num3 = num;
				num = (short)1360330752;
				if (num != 0)
				{
				}
				num = (short)1473314817;
				if (num != 0)
				{
				}
				return this.af;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)893683659;
				short num2 = num;
				num = (short)1708951499;
				switch (num2 == num)
				{
				}
				num = (short)57475072;
				short num3 = num;
				num = (short)1618083841;
				if (num != 0)
				{
				}
				num = (short)1851392000;
				if (num != 0)
				{
				}
				this.af = value;
			}
		}

		// Token: 0x170003E7 RID: 999
		// (get) Token: 0x0600084D RID: 2125 RVA: 0x0007A654 File Offset: 0x00078854
		// (set) Token: 0x0600084E RID: 2126 RVA: 0x0007A708 File Offset: 0x00078908
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public global::Motorola.CommonCPS.Server.CommonDBConstants.ASTROPasswordPolicy PasswordPolicy
		{
			get
			{
				short num = (short)1177214318;
				short num2 = num;
				num = (short)949411182;
				switch (num2 == num)
				{
				}
				num = (short)899022848;
				short num3 = num;
				num = (short)1967063041;
				if (num != 0)
				{
				}
				num = (short)669712384;
				if (num != 0)
				{
				}
				return this.ApxRadioSummaryEntity.PasswordPolicy;
			}
			set
			{
				short num = (short)278724608;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)836856596;
						short num3 = num;
						num = (short)108882708;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_F0;
						case 1:
							break;
						default:
						{
							num = (short)1860829184;
							short num4 = num;
							break;
						}
						}
						num = (short)1200619520;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_A4;
						}
						continue;
					}
					case 1:
						goto IL_F0;
					case 2:
						return;
					}
					IL_A4:
					num = (short)845021185;
					if (num != 0)
					{
					}
					if (value != this.ApxRadioSummaryEntity.PasswordPolicy)
					{
						num = (short)1214971905;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_F0:
					this.ApxRadioSummaryEntity.PasswordPolicy = value;
					base.RaisePropertyChanged<global::Motorola.CommonCPS.Server.CommonDBConstants.ASTROPasswordPolicy>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::Motorola.CommonCPS.Server.CommonDBConstants.ASTROPasswordPolicy>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio.get_PasswordPolicy())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
					num = (short)399376386;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x170003E8 RID: 1000
		// (get) Token: 0x0600084F RID: 2127 RVA: 0x0007A860 File Offset: 0x00078A60
		// (set) Token: 0x06000850 RID: 2128 RVA: 0x0007A914 File Offset: 0x00078B14
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public string CodeplugPassword
		{
			get
			{
				short num = (short)2032758452;
				short num2 = num;
				num = (short)2030005940;
				switch (num2 == num)
				{
				}
				num = (short)385351680;
				short num3 = num;
				num = (short)56033280;
				if (num != 0)
				{
				}
				num = (short)612040705;
				if (num != 0)
				{
				}
				return this.ApxRadioSummaryEntity.CodeplugPassword;
			}
			set
			{
				short num = (short)1786970112;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)1151062369;
						short num3 = num;
						num = (short)1897386337;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_F5;
						case 1:
							break;
						default:
						{
							num = (short)39780352;
							short num4 = num;
							break;
						}
						}
						num = (short)997064704;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_A4;
						}
						continue;
					}
					case 1:
						goto IL_F5;
					case 2:
						return;
					}
					IL_A4:
					num = (short)38993921;
					if (num != 0)
					{
					}
					if (value != this.ApxRadioSummaryEntity.CodeplugPassword)
					{
						num = (short)1493303297;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_F5:
					this.ApxRadioSummaryEntity.CodeplugPassword = value;
					base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio.get_CodeplugPassword())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
					num = (short)1129644034;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x170003E9 RID: 1001
		// (get) Token: 0x06000851 RID: 2129 RVA: 0x0007AA70 File Offset: 0x00078C70
		// (set) Token: 0x06000852 RID: 2130 RVA: 0x0007AB24 File Offset: 0x00078D24
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.EntitytMemberName("PasswordPerDevice")]
		public bool PasswordPerDevice
		{
			get
			{
				short num = (short)1561165376;
				short num2 = num;
				num = (short)1073577536;
				switch (num2 == num)
				{
				}
				num = (short)1550712832;
				short num3 = num;
				num = (short)458162177;
				if (num != 0)
				{
				}
				num = (short)408944640;
				if (num != 0)
				{
				}
				return this.ApxRadioSummaryEntity.PasswordPerDevice;
			}
			set
			{
				short num = (short)46399488;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)226019794;
						short num3 = num;
						num = (short)1036372434;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_F1;
						case 1:
							break;
						default:
						{
							num = (short)2139029504;
							short num4 = num;
							break;
						}
						}
						num = (short)821952512;
						if (num != 0)
						{
						}
						num = (short)1063256065;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_CC;
						}
						continue;
					}
					case 1:
						goto IL_F1;
					case 2:
						return;
					}
					IL_CC:
					if (value != this.ApxRadioSummaryEntity.PasswordPerDevice)
					{
						num = (short)173998081;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_F1:
					this.ApxRadioSummaryEntity.PasswordPerDevice = value;
					base.RaisePropertyChanged<bool>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio.get_PasswordPerDevice())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
					num = (short)2105212930;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x170003EA RID: 1002
		// (get) Token: 0x06000853 RID: 2131 RVA: 0x0007AC7C File Offset: 0x00078E7C
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public global::Motorola.CommonCPS.Server.EntityModel.ASTRORadioSummary ApxRadioSummaryEntity
		{
			get
			{
				short num = (short)1897490482;
				short num2 = num;
				num = (short)1986291762;
				switch (num2 == num)
				{
				}
				num = (short)357236736;
				short num3 = num;
				num = (short)831520769;
				if (num != 0)
				{
				}
				num = (short)483000320;
				if (num != 0)
				{
				}
				return base.RadioSummaryEntity as global::Motorola.CommonCPS.Server.EntityModel.ASTRORadioSummary;
			}
		}

		// Token: 0x170003EB RID: 1003
		public override string this[string propertyName]
		{
			get
			{
				int a_ = 0;
				switch (0)
				{
				case 0:
					goto IL_209;
				}
				int num;
				uint num2;
				short num3;
				for (;;)
				{
					IL_13:
					switch (num)
					{
					case 0:
						if (num2 != 1157191835U)
						{
							num3 = (short)1938358371;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						num3 = (short)335544364;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 1:
						if (!(propertyName == global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("欺尼䰾㉀ᑂ⩄㕆ⵈ", a_)))
						{
							num3 = (short)930087001;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						num3 = (short)1135083636;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 2:
						goto IL_5BE;
					case 3:
						goto IL_B10;
					case 4:
						goto IL_98D;
					case 5:
						if (!base.Validate(this.UserPINError))
						{
							num3 = (short)684064777;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						goto IL_494;
					case 6:
						goto IL_CEA;
					case 7:
						goto IL_51D;
					case 8:
						goto IL_114B;
					case 9:
						goto IL_1129;
					case 10:
						num3 = (short)1503723521;
						if (num3 != 0)
						{
						}
						if (!(propertyName == global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("栺䠼崾㉀⁂㝄⹆⭈⹊㽌َŐ", a_)))
						{
							num3 = (short)1379794965;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						num3 = (short)1647247441;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 11:
						num3 = (short)1431437404;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 12:
					{
						if (propertyName == global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("砺刼儾❀⩂≄㉆㭈⩊㥌♎㹐㵒᭔㙖㑘㹚", a_))
						{
							num3 = (short)952107125;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						num3 = (short)1601022933;
						short num4 = num3;
						num3 = (short)520793045;
						switch ((num4 == num3) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_C37;
						default:
							num3 = (short)1136328704;
							if (num3 != 0)
							{
							}
							num3 = (short)290455614;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						break;
					}
					case 13:
						if (!(propertyName == global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("渺丼娾㍀ൂ⑄⩆ⱈ", a_)))
						{
							num3 = (short)1057554491;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						num3 = (short)2070151196;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 14:
						if (num2 != 2620727545U)
						{
							num3 = (short)203096141;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						num3 = (short)918945805;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 15:
						goto IL_3B5;
					case 16:
						num3 = (short)1674969210;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 17:
						goto IL_10C1;
					case 18:
						goto IL_1317;
					case 19:
						goto IL_12ED;
					case 20:
						if (num2 != 1216208513U)
						{
							num3 = (short)1194131485;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						num3 = (short)1789526109;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 21:
						num3 = (short)1684078599;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 22:
						goto IL_5A2;
					case 23:
						if (!base.Validate(this.PeerIPError))
						{
							num3 = (short)3342353;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						goto IL_E75;
					case 24:
						num3 = (short)1083899912;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 25:
						goto IL_7EC;
					case 26:
						num3 = (short)708575314;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 27:
						num3 = (short)203554921;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 28:
						if (!base.Validate(this.UserNameError))
						{
							num3 = (short)230293508;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						goto IL_AAC;
					case 29:
						num3 = (short)1967456299;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 30:
						if (num2 != 3180538576U)
						{
							num3 = (short)2135621658;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						num3 = (short)1329791051;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 31:
						if (num2 != 2642881298U)
						{
							num3 = (short)96862311;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						num3 = (short)957284364;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 32:
						num3 = (short)1012006961;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 33:
						if (num2 != 2565758308U)
						{
							num3 = (short)719650930;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						num3 = (short)693370982;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 34:
						goto IL_8F4;
					case 35:
						num3 = (short)2006450286;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 36:
						goto IL_E73;
					case 37:
					{
						if (num2 != 1834575210U)
						{
							num3 = (short)547094607;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						num3 = (short)738525184;
						short num5 = num3;
						num3 = (short)1584726026;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					case 38:
						goto IL_62A;
					case 39:
						num3 = (short)2040397933;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 40:
						if (!base.Validate(this.ForeignIPError))
						{
							num3 = (short)2060779641;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						goto IL_CEF;
					case 41:
						if (!base.Validate(this.OtarIDError))
						{
							num3 = (short)1185218579;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						goto IL_11BC;
					case 42:
						goto IL_107A;
					case 43:
						if (num2 != 1560111736U)
						{
							num3 = (short)1027276861;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						num3 = (short)1320288351;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 44:
						if (!(propertyName == global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("示儼䨾⑀㝂⩄⡆㵈⍊ौᩎὐR⁔㕖⩘㡚⽜㙞͠٢ᝤ⹦㥨", a_)))
						{
							num3 = (short)49414195;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						num3 = (short)1052377206;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 45:
						num3 = (short)800849940;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 46:
						if (!(propertyName == global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("洺漼瘾Հ", a_)))
						{
							num3 = (short)617218098;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						num3 = (short)1667432524;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 47:
						num3 = (short)104661107;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 48:
						if (!(propertyName == global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("欺堼娾㍀ੂᕄ", a_)))
						{
							num3 = (short)1708654616;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						num3 = (short)747175959;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 49:
						if (num2 <= 1157191835U)
						{
							num3 = (short)27983925;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						num3 = (short)2101674085;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 50:
						num3 = (short)445120579;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 51:
						num3 = (short)766902314;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 52:
						num3 = (short)1656619074;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 53:
						num3 = (short)1972633719;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 54:
						if (num2 != 2733624436U)
						{
							num3 = (short)611909643;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						num3 = (short)1481375790;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 55:
						num3 = (short)1894973536;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 56:
						goto IL_C37;
					case 57:
						goto IL_4B1;
					case 58:
						num3 = (short)973799457;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 59:
						num3 = (short)467468345;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 60:
						goto IL_E26;
					case 61:
						num3 = (short)1270939736;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 62:
						num3 = (short)1056505919;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 63:
						goto IL_11B7;
					case 64:
						num3 = (short)136839241;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 65:
						goto IL_31E;
					case 66:
						if (num2 != 3134841045U)
						{
							num3 = (short)1646657552;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						num3 = (short)667549781;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 67:
						goto IL_A8B;
					case 68:
						goto IL_F35;
					case 69:
						goto IL_BF1;
					case 70:
						num3 = (short)1649999890;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 71:
						goto IL_9D9;
					case 72:
						num3 = (short)1334706288;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 73:
						goto IL_C53;
					case 74:
						num3 = (short)1301872720;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 75:
						if (!(propertyName == global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("渺丼娾㍀ག⩄⁆⁈╊ᡌⅎ㡐❒᱔ፖ", a_)))
						{
							num3 = (short)6094895;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						num3 = (short)1648885854;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 76:
						if (!base.Validate(this.VRIDError))
						{
							num3 = (short)764084239;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						goto IL_12F9;
					case 77:
						num3 = (short)490471522;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 78:
						if (num2 != 2231345737U)
						{
							num3 = (short)1522663451;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						num3 = (short)1164836971;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 79:
						num3 = (short)1545797710;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 80:
						if (num2 <= 2620727545U)
						{
							num3 = (short)445710394;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						num3 = (short)1266876447;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 81:
						if (!base.Validate(this.SubscriberIPError))
						{
							num3 = (short)65142818;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						goto IL_500;
					case 82:
						if (num2 != 3942800474U)
						{
							num3 = (short)1503920228;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						num3 = (short)259915866;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 83:
						if (!base.Validate(this.BluetoothFriendlyNameError))
						{
							num3 = (short)550240342;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						goto IL_36E;
					case 84:
						num3 = (short)811991100;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 85:
						if (!(propertyName == global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("示儼䨾⑀㝂⩄⡆㵈⍊ୌ㵎㡐㙒㭔㍖㕘≚፜㹞ౠ٢", a_)))
						{
							num3 = (short)1401552966;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						num3 = (short)52101203;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 86:
						goto IL_1199;
					case 87:
						if (!(propertyName == global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("椺尼嬾⡀ⱂф⭆⁈⩊㹌", a_)))
						{
							num3 = (short)1461977152;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						num3 = (short)2041577578;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 88:
						goto IL_D4B;
					case 89:
						num3 = (short)668860419;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 90:
						if (!(propertyName == global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("紺刼䴾⑀⩂≄⥆Hᭊ", a_)))
						{
							num3 = (short)477429880;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						num3 = (short)1338834984;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 91:
						if (num2 <= 2231345737U)
						{
							num3 = (short)659095584;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						num3 = (short)352518241;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 92:
						goto IL_42D;
					case 93:
						if (!(propertyName == global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("示儼䨾⑀㝂⩄⡆㵈⍊ौᩎὐ͒ご㉖⭘ቚ൜", a_)))
						{
							num3 = (short)703987784;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						num3 = (short)1408041083;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 94:
						if (!base.Validate(this.UserLoginUnitIDError))
						{
							num3 = (short)1339490310;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						goto IL_29A;
					case 95:
						if (!(propertyName == global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("琺䤼帾㍀ੂń", a_)))
						{
							num3 = (short)430833719;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						num3 = (short)44433449;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 96:
						goto IL_646;
					case 97:
						if (num2 <= 2733624436U)
						{
							num3 = (short)1694564426;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						num3 = (short)2081685608;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 98:
						goto IL_44A;
					case 99:
						num3 = (short)463470660;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 100:
						num3 = (short)1382219814;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 101:
						if (num2 <= 1560111736U)
						{
							num3 = (short)314703917;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						num3 = (short)1901854757;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 102:
						if (!(propertyName == global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("栺堼䴾⡀≂⥄ॆ㱈♊⽌⩎⍐", a_)))
						{
							num3 = (short)728563825;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						num3 = (short)524091500;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 103:
						num3 = (short)1054867510;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 104:
						if (num2 <= 3134841045U)
						{
							num3 = (short)1690042407;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						num3 = (short)1690566686;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 105:
						goto IL_AA7;
					case 106:
						if (!base.Validate(base.RadioAliasError))
						{
							num3 = (short)1674051655;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						goto IL_323;
					case 107:
						if (!(propertyName == global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("渺丼娾㍀ፂౄॆ", a_)))
						{
							num3 = (short)1372848212;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						num3 = (short)1552351237;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 108:
						if (!base.Validate(base.SerialNumberError))
						{
							num3 = (short)320340037;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						goto IL_329;
					case 109:
						if (num2 != 2895456536U)
						{
							num3 = (short)1035862068;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						num3 = (short)145424385;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 110:
						if (num2 != 633542544U)
						{
							num3 = (short)1667498095;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						num3 = (short)1097269296;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 111:
						num3 = (short)1639710720;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 112:
						goto IL_743;
					case 113:
						num3 = (short)2012545049;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 114:
						num3 = (short)1652228110;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 115:
						goto IL_3D2;
					case 116:
						if (!base.Validate(this.PassWordError))
						{
							num3 = (short)724566038;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						goto IL_992;
					case 117:
						if (!base.Validate(this.MismatchError))
						{
							num3 = (short)1744764984;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						goto IL_1150;
					case 118:
						if (!base.Validate(this.BluetoothDUNSubscriberIPError))
						{
							num3 = (short)2030633025;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						goto IL_24F;
					case 119:
						if (num2 != 505833392U)
						{
							num3 = (short)1655636003;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						num3 = (short)1088946263;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 120:
						num3 = (short)1908932610;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 121:
						goto IL_AF4;
					case 122:
						goto IL_10DD;
					case 123:
						if (!base.Validate(this.BluetoothDUNPeerIPError))
						{
							num3 = (short)1305280548;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						goto IL_112E;
					}
					goto IL_209;
				}
				IL_24F:
				return string.Empty;
				IL_29A:
				return string.Empty;
				IL_31E:
				return base.Error;
				IL_323:
				return string.Empty;
				IL_329:
				return string.Empty;
				IL_36E:
				return string.Empty;
				IL_3B5:
				return base.Error;
				IL_3D2:
				IL_42D:
				IL_44A:
				goto IL_13A2;
				IL_494:
				return string.Empty;
				IL_4B1:
				goto IL_13A2;
				IL_500:
				return string.Empty;
				IL_51D:
				goto IL_13A2;
				IL_5A2:
				return base.Error;
				IL_5BE:
				IL_62A:
				IL_646:
				IL_743:
				IL_7EC:
				goto IL_13A2;
				IL_8F4:
				return base.Error;
				IL_98D:
				return base.Error;
				IL_992:
				return string.Empty;
				IL_9D9:
				return base.Error;
				IL_A8B:
				IL_AA7:
				goto IL_13A2;
				IL_AAC:
				return string.Empty;
				IL_AF4:
				return base.Error;
				IL_B10:
				goto IL_13A2;
				IL_BF1:
				return base.Error;
				IL_C37:
				return base.Error;
				IL_C53:
				goto IL_13A2;
				IL_CEA:
				return base.Error;
				IL_CEF:
				return string.Empty;
				IL_D4B:
				IL_E26:
				goto IL_13A2;
				IL_E73:
				return base.Error;
				IL_E75:
				return string.Empty;
				IL_F35:
				IL_107A:
				goto IL_13A2;
				IL_10C1:
				return base.Error;
				IL_10DD:
				goto IL_13A2;
				IL_1129:
				return base.Error;
				IL_112E:
				return string.Empty;
				IL_114B:
				goto IL_13A2;
				IL_1150:
				return string.Empty;
				IL_1199:
				return base.Error;
				IL_11B7:
				goto IL_13A2;
				IL_11BC:
				return string.Empty;
				IL_12ED:
				return base.Error;
				IL_12F9:
				return string.Empty;
				IL_1317:
				IL_13A2:
				return string.Empty;
				IL_209:
				num2 = global::<PrivateImplementationDetails>.ComputeStringHash(propertyName);
				num3 = (short)355860571;
				num = (int)((global::System.IntPtr)num3);
				goto IL_13;
			}
		}

		// Token: 0x06000855 RID: 2133 RVA: 0x0007C0E4 File Offset: 0x0007A2E4
		public override void CleanErrors()
		{
			short num = (short)1767712901;
			short num2 = num;
			num = (short)931539077;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1749483520;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)467337216;
			if (num != 0)
			{
			}
			num = (short)1132658689;
			if (num != 0)
			{
			}
			base.CleanErrors();
			this.UserNameError = string.Empty;
			this.UserLoginUnitIDError = string.Empty;
			this.UserPINError = string.Empty;
			this.BluetoothDUNSubscriberIPError = string.Empty;
			this.BluetoothDUNPeerIPError = string.Empty;
			this.PeerIPError = string.Empty;
			this.SubscriberIPError = string.Empty;
			this.ForeignIPError = string.Empty;
			this.PassWordError = string.Empty;
			base.RadioAliasError = string.Empty;
			this.OtarIDError = string.Empty;
			this.BluetoothFriendlyNameError = string.Empty;
			this.VRIDError = string.Empty;
		}

		// Token: 0x06000856 RID: 2134 RVA: 0x0007C224 File Offset: 0x0007A424
		public override bool IsValidRecord()
		{
			switch (0)
			{
			case 0:
				goto IL_80;
			}
			int num;
			short num2;
			bool flag;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)1511718912;
					short num3 = num2;
					if (base.Validate(this.BluetoothDUNPeerIPError))
					{
						num2 = (short)1784348692;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2D3;
				}
				case 1:
					if (base.Validate(base.RadioAliasError))
					{
						num2 = (short)1382613014;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2D3;
				case 2:
					if (base.Validate(this.SubscriberIPError))
					{
						num2 = (short)271253527;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2D3;
				case 3:
					num2 = (short)1704787970;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					if (base.Validate(this.OtarIDError))
					{
						num2 = (short)1982005254;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2D3;
				case 5:
					if (base.Validate(this.BluetoothDUNSubscriberIPError))
					{
						num2 = (short)894042131;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2D3;
				case 6:
					num2 = (short)1413742602;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					goto IL_3B7;
				case 8:
				{
					num2 = (short)915300504;
					short num4 = num2;
					num2 = (short)1015898264;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_3B7;
					default:
						num2 = (short)1448476672;
						if (num2 != 0)
						{
						}
						if (base.Validate(this.UserPINError))
						{
							num2 = (short)1189281806;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_2D3;
					}
					break;
				}
				case 9:
					if (base.Validate(this.ForeignIPError))
					{
						num2 = (short)662437913;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2D3;
				case 10:
					if (base.Validate(this.BluetoothFriendlyNameError))
					{
						num2 = (short)750190608;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2D3;
				case 11:
					goto IL_38E;
				case 12:
					if (flag)
					{
						num2 = (short)131072024;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2D3;
				case 13:
					if (base.Validate(this.UserLoginUnitIDError))
					{
						num2 = (short)2135621653;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2D3;
				case 14:
					num2 = (short)1138622469;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 15:
					num2 = (short)1984167937;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 16:
					num2 = (short)492961803;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 17:
					if (base.Validate(this.UserNameError))
					{
						num2 = (short)197066779;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2D3;
				case 18:
					goto IL_2EB;
				case 19:
					num2 = (short)1465843712;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 20:
					num2 = (short)1489829914;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 21:
					num2 = (short)2093154312;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 22:
					num2 = (short)1234960385;
					if (num2 != 0)
					{
					}
					num2 = (short)2029715460;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 23:
					num2 = (short)1951924233;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 24:
					num2 = (short)926613521;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 25:
					num2 = (short)1951924231;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 26:
					if (base.Validate(this.PeerIPError))
					{
						num2 = (short)1773076483;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2D3;
				case 27:
					num2 = (short)641990669;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_80;
				IL_2D3:
				num2 = (short)337903634;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_3B7:
				if (!base.Validate(this.PassWordError))
				{
					goto IL_2D3;
				}
				num2 = (short)1065484303;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_2EB:
			return false;
			IL_38E:
			return base.Validate(this.VRIDError);
			IL_80:
			flag = base.IsValidRecord();
			num2 = (short)388628492;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000857 RID: 2135 RVA: 0x0007C710 File Offset: 0x0007A910
		public override global::System.Collections.Generic.Dictionary<string, string> InvalidFieldErrorInfo()
		{
			int a_ = 9;
			switch (0)
			{
			case 0:
				goto IL_C1;
			}
			int num;
			global::System.Collections.Generic.Dictionary<string, string> dictionary;
			short num2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					dictionary.Add(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ك⩅㵇⽉㡋⅍㽏♑㱓ቕൗᑙ౛㭝՟ၡⵣ㙥", a_), base.Error);
					num2 = (short)1021378572;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					dictionary.Add(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ᙃ❅ⱇ⍉⍋ཌྷ㱏㭑㕓╕", a_), base.Error);
					num2 = (short)695533606;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if (!base.Validate(this.OtarIDError))
					{
						num2 = (short)1856634903;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_517;
				case 3:
					if (!base.Validate(this.UserPINError))
					{
						num2 = (short)209453095;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1A0;
				case 4:
					dictionary.Add(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ᝃ㍅⩇㥉⽋㱍㥏けㅓ⑕ᅗਖ਼", a_), base.Error);
					num2 = (short)100270107;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					if (!base.Validate(this.BluetoothDUNPeerIPError))
					{
						num2 = (short)1335754752;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_675;
				case 6:
					dictionary.Add(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ᑃ⍅ⵇ㡉Ջṍ", a_), base.Error);
					num2 = (short)77398051;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					goto IL_704;
				case 8:
					if (!base.Validate(this.ForeignIPError))
					{
						num2 = (short)914030613;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_78F;
				case 9:
					if (!base.Validate(this.BluetoothDUNSubscriberIPError))
					{
						num2 = (short)1411579940;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_49E;
				case 10:
					goto IL_749;
				case 11:
					if (!base.Validate(this.UserLoginUnitIDError))
					{
						num2 = (short)1699282962;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_21B;
				case 12:
					goto IL_675;
				case 13:
					if (!base.Validate(this.VRIDError))
					{
						num2 = (short)1110048792;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return dictionary;
				case 14:
					if (!base.Validate(base.RadioAliasError))
					{
						num2 = (short)487194625;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_25F;
				case 15:
					goto IL_7D0;
				case 16:
					dictionary.Add(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ᅃ㕅ⵇ㡉ɋ⽍㵏㝑", a_), base.Error);
					num2 = (short)364118026;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 17:
					goto IL_356;
				case 18:
					dictionary.Add(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ᅃ㕅ⵇ㡉K⅍㝏㭑㩓͕㙗㍙⡛᝝⑟", a_), base.Error);
					num2 = (short)170393619;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 19:
					goto IL_21B;
				case 20:
					if (!base.Validate(this.BluetoothFriendlyNameError))
					{
						num2 = (short)986578976;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_356;
				case 21:
					dictionary.Add(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("Ƀ⥅㩇⽉╋⥍㹏᭑ѓ", a_), base.Error);
					num2 = (short)791805983;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 22:
					return dictionary;
				case 23:
					dictionary.Add(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ୃ㉅⥇㡉Ջ੍", a_), base.Error);
					num2 = (short)113901605;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 24:
					dictionary.Add(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ቃᑅŇ้", a_), base.Error);
					num2 = (short)211746838;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 25:
					if (!base.Validate(this.MismatchError))
					{
						num2 = (short)1250033694;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_704;
				case 26:
					num2 = (short)1972764673;
					if (num2 != 0)
					{
					}
					if (!base.Validate(this.UserNameError))
					{
						num2 = (short)1114832912;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_749;
				case 27:
					goto IL_2DA;
				case 28:
					goto IL_49E;
				case 29:
					goto IL_1A0;
				case 30:
					dictionary.Add(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("݃⥅♇ⱉ╋⥍╏⁑㕓≕ㅗ㕙㉛ၝşཡţ", a_), base.Error);
					goto IL_2BD;
				case 31:
					goto IL_78F;
				case 32:
					dictionary.Add(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ك⩅㵇⽉㡋⅍㽏♑㱓ၕ⩗㍙㥛そџ๡ᵣ⡥१ݩ५", a_), base.Error);
					num2 = (short)1474035729;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 33:
				{
					if (base.Validate(this.PeerIPError))
					{
						goto IL_58F;
					}
					num2 = (short)1274534380;
					short num3 = num2;
					num2 = (short)1135925740;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_2BD;
					default:
						num2 = (short)1067581440;
						if (num2 != 0)
						{
						}
						num2 = (short)1798766598;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 34:
					if (!base.Validate(this.SubscriberIPError))
					{
						num2 = (short)503840772;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2DA;
				case 35:
				{
					num2 = (short)1324548096;
					short num4 = num2;
					goto IL_58F;
				}
				case 36:
					dictionary.Add(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ك⩅㵇⽉㡋⅍㽏♑㱓ቕൗᑙཛ⭝ɟᅡݣᑥŧࡩ५ᱭ㥯≱", a_), base.Error);
					num2 = (short)1215234076;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 37:
					goto IL_517;
				case 38:
					goto IL_25F;
				case 39:
					dictionary.Add(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ᅃ㕅ⵇ㡉᱋ݍṏ", a_), base.Error);
					num2 = (short)1032519709;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 40:
					dictionary.Add(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ᑃ❅㭇㥉ᭋ⅍≏㙑", a_), base.Error);
					num2 = (short)1077018639;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 41:
					if (!base.Validate(this.PassWordError))
					{
						num2 = (short)1683423272;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_7D0;
				}
				goto IL_C1;
				IL_1A0:
				num2 = (short)701104137;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_21B:
				num2 = (short)1777729539;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_25F:
				num2 = (short)778502146;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_2BD:
				num2 = (short)413990919;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_2DA:
				num2 = (short)798687240;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_356:
				num2 = (short)721813529;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_49E:
				num2 = (short)439222277;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_517:
				num2 = (short)1456930836;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_58F:
				num2 = (short)1304494114;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_675:
				num2 = (short)1778253857;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_704:
				num2 = (short)1493696525;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_749:
				num2 = (short)463208459;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_78F:
				num2 = (short)37290025;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_7D0:
				num2 = (short)1383530510;
				num = (int)((global::System.IntPtr)num2);
			}
			return dictionary;
			IL_C1:
			dictionary = base.InvalidFieldErrorInfo();
			num2 = (short)537198618;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x0400032A RID: 810
		private string a;

		// Token: 0x0400032B RID: 811
		private string b;

		// Token: 0x0400032C RID: 812
		private string c;

		// Token: 0x0400032D RID: 813
		private string d;

		// Token: 0x0400032E RID: 814
		private string e;

		// Token: 0x0400032F RID: 815
		private string f;

		// Token: 0x04000330 RID: 816
		private string g;

		// Token: 0x04000331 RID: 817
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadioLicense> h;

		// Token: 0x04000332 RID: 818
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private int? i;

		// Token: 0x04000333 RID: 819
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool j;

		// Token: 0x04000334 RID: 820
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool k;

		// Token: 0x04000335 RID: 821
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool l;

		// Token: 0x04000336 RID: 822
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool m;

		// Token: 0x04000337 RID: 823
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool n;

		// Token: 0x04000338 RID: 824
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool o;

		// Token: 0x04000339 RID: 825
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool p;

		// Token: 0x0400033A RID: 826
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool q;

		// Token: 0x0400033B RID: 827
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool r;

		// Token: 0x0400033C RID: 828
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool s;

		// Token: 0x0400033D RID: 829
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool t;

		// Token: 0x0400033E RID: 830
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool u;

		// Token: 0x0400033F RID: 831
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool v;

		// Token: 0x04000340 RID: 832
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool w;

		// Token: 0x04000341 RID: 833
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string x;

		// Token: 0x04000342 RID: 834
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string y;

		// Token: 0x04000343 RID: 835
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string z;

		// Token: 0x04000344 RID: 836
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string aa;

		// Token: 0x04000345 RID: 837
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string ab;

		// Token: 0x04000346 RID: 838
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string ac;

		// Token: 0x04000347 RID: 839
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string ad;

		// Token: 0x04000348 RID: 840
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string ae;

		// Token: 0x04000349 RID: 841
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string af;
	}
}
