using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AcpCommonLib.Exceptions;

namespace AcpCommonLib
{
	// Token: 0x0200001F RID: 31
	public class FieldInfo
	{
		// Token: 0x0600015C RID: 348 RVA: 0x0000F2DC File Offset: 0x0000D4DC
		protected FieldInfo()
		{
		}

		// Token: 0x0600015D RID: 349 RVA: 0x0000F2F0 File Offset: 0x0000D4F0
		public FieldInfo(global::AcpCommonLib.IAcpField field) : this()
		{
			this.Field = field;
			this.FieldType = global::AcpCommonLib.FieldInfoType.Field;
		}

		// Token: 0x0600015E RID: 350 RVA: 0x0000F314 File Offset: 0x0000D514
		public FieldInfo(global::AcpCommonLib.IAcpFeatureNode node) : this()
		{
			this.Node = node;
			this.FieldType = global::AcpCommonLib.FieldInfoType.Record;
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x0600015F RID: 351 RVA: 0x0000F338 File Offset: 0x0000D538
		// (set) Token: 0x06000160 RID: 352 RVA: 0x0000F3E8 File Offset: 0x0000D5E8
		public global::AcpCommonLib.FieldInfoType FieldType
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)965490714;
				short num2 = num;
				num = (short)1320171546;
				switch (num2 == num)
				{
				}
				num = (short)34078720;
				short num3 = num;
				num = (short)2028666881;
				if (num != 0)
				{
				}
				num = (short)966787072;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)2109378127;
				short num2 = num;
				num = (short)561221199;
				switch (num2 == num)
				{
				}
				num = (short)180813824;
				short num3 = num;
				num = (short)251789313;
				if (num != 0)
				{
				}
				num = (short)1986985984;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x06000161 RID: 353 RVA: 0x0000F498 File Offset: 0x0000D698
		// (set) Token: 0x06000162 RID: 354 RVA: 0x0000F548 File Offset: 0x0000D748
		public global::AcpCommonLib.IAcpField Field
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1700399998;
				short num2 = num;
				num = (short)941099902;
				switch (num2 == num)
				{
				}
				num = (short)1123155968;
				short num3 = num;
				num = (short)227606529;
				if (num != 0)
				{
				}
				num = (short)2133852160;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)188197686;
				short num2 = num;
				num = (short)1708763958;
				switch (num2 == num)
				{
				}
				num = (short)69402624;
				short num3 = num;
				num = (short)93126657;
				if (num != 0)
				{
				}
				num = (short)823066624;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x06000163 RID: 355 RVA: 0x0000F5FC File Offset: 0x0000D7FC
		// (set) Token: 0x06000164 RID: 356 RVA: 0x0000F6AC File Offset: 0x0000D8AC
		public global::AcpCommonLib.IAcpFeatureNode Node
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1310463716;
				short num2 = num;
				num = (short)149165796;
				switch (num2 == num)
				{
				}
				num = (short)1989672960;
				short num3 = num;
				num = (short)428802049;
				if (num != 0)
				{
				}
				num = (short)1359151104;
				if (num != 0)
				{
				}
				return this.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1225087470;
				short num2 = num;
				num = (short)1593727470;
				switch (num2 == num)
				{
				}
				num = (short)2111438848;
				short num3 = num;
				num = (short)1830354945;
				if (num != 0)
				{
				}
				num = (short)694681600;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x06000165 RID: 357 RVA: 0x0000F75C File Offset: 0x0000D95C
		public string Path
		{
			get
			{
				int a_ = 4;
				short num = (short)1147273216;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					switch (0)
					{
					case 0:
						goto IL_8F;
					}
					global::AcpCommonLib.FieldInfoType fieldType;
					string result;
					for (;;)
					{
						IL_30:
						string text;
						string text2;
						switch (num2)
						{
						case 0:
							if (fieldType != global::AcpCommonLib.FieldInfoType.Field)
							{
								num = (short)1789657090;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)312999954;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							text = this.Node.Path(global::AcpCommonLib.Exceptions.AcpSecurityException.b("ꫵ", a_));
							goto IL_579;
						case 2:
							num = (short)1873084433;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							goto IL_509;
						case 4:
							num = (short)1881866252;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							goto IL_338;
						case 6:
							if (this.Field.Parent.Parent != null)
							{
								num = (short)1622867975;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_596;
						case 7:
						{
							global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator = this.Field.Parent.Parent.FeatureSectionsCollection.GetEnumerator();
							num = (short)1470627856;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 8:
							if (this.Field.NewUiExpanderAndName != null)
							{
								num = (short)1166409747;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_50E;
						case 9:
							num = (short)688062465;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 10:
							if (this.Node != null)
							{
								num = (short)1173684233;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)138346510;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 11:
							text2 = null;
							goto IL_4F0;
						case 12:
							goto IL_496;
						case 13:
							num = (short)163708936;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 14:
							text = null;
							goto IL_579;
						case 15:
							goto IL_594;
						case 16:
							try
							{
								num = (short)1169489921;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										num = (short)1150812166;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_1A9;
										}
										continue;
									case 2:
									{
										num = (short)503274165;
										short num3 = num;
										num = (short)629103285;
										switch ((num3 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											goto IL_1F8;
										default:
										{
											num = (short)1790443520;
											if (num != 0)
											{
											}
											global::AcpCommonLib.IAcpFeatureSection acpFeatureSection;
											if (acpFeatureSection == this.Field.NewParent)
											{
												num = (short)900333571;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											break;
										}
										}
										break;
									}
									case 3:
									{
										global::AcpCommonLib.IAcpFeatureSection acpFeatureSection;
										result = acpFeatureSection.Path(global::AcpCommonLib.Exceptions.AcpSecurityException.b("ꫵ", a_));
										num = (short)1269170181;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 4:
									{
										global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator;
										if (!enumerator.MoveNext())
										{
											goto IL_1F8;
										}
										global::AcpCommonLib.IAcpFeatureSection acpFeatureSection = enumerator.Current;
										num = (short)20250626;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 5:
										goto IL_1D6;
									case 6:
										goto IL_2C8;
									}
									IL_1DB:
									num = (short)558891012;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_1A9:
									goto IL_1DB;
									IL_1F8:
									num = (short)525336576;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_1D6:
								IL_2C8:
								goto IL_596;
							}
							finally
							{
								num = (short)1189281793;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator;
									switch (num2)
									{
									case 0:
										enumerator.Dispose();
										num = (short)151912450;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_2FF;
										}
										continue;
									case 2:
										goto IL_335;
									}
									IL_2FF:
									if (enumerator == null)
									{
										break;
									}
									num = (short)302645248;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_335:;
							}
							goto IL_338;
						case 17:
							if (fieldType != global::AcpCommonLib.FieldInfoType.Record)
							{
								num = (short)1308229636;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1199439882;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 18:
							if (this.Field != null)
							{
								num = (short)1362362381;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_50E;
						case 19:
							num = (short)2045313030;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 20:
							text2 = this.Field.Parent.Path(global::AcpCommonLib.Exceptions.AcpSecurityException.b("ꫵ", a_));
							goto IL_4F0;
						case 21:
						{
							num = (short)28573696;
							short num4 = num;
							if (this.Field != null)
							{
								num = (short)1496055813;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)586285067;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						goto IL_8F;
						IL_338:
						num = (short)834273300;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_4F0:
						result = text2;
						num = (short)15400963;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_50E:
						num = (short)603455509;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_579:
						result = text;
						num = (short)1399455759;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_496:
					IL_509:
					IL_594:
					IL_596:
					num = (short)2068709377;
					if (num != 0)
					{
					}
					return result;
					IL_8F:
					result = null;
					fieldType = this.FieldType;
					num = (short)1434910720;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_30;
				}
				}
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06000166 RID: 358 RVA: 0x0000FD44 File Offset: 0x0000DF44
		public string Name
		{
			get
			{
				short num = (short)305182579;
				short num2 = num;
				num = (short)1334097779;
				int num3;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_120:
					num = (short)1572208640;
					num3 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)1824325632;
					if (num != 0)
					{
					}
					num = (short)46923778;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
				for (;;)
				{
					switch (num3)
					{
					case 0:
						if (!string.IsNullOrEmpty(this.Field.NewUiExpanderAndName))
						{
							num = (short)1112801284;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D5;
					case 1:
						goto IL_AB;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_8F;
						}
						continue;
					case 3:
						goto IL_112;
					case 4:
						num = (short)773455877;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						num = (short)2059796481;
						if (num != 0)
						{
						}
						if (this.Field.NewUIName != null)
						{
							num = (short)660602887;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1D8;
					case 6:
						if (this.Field != null)
						{
							num = (short)1253965827;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1DA;
					case 7:
						goto IL_1D3;
					}
					IL_8F:
					if (this.Field != null)
					{
						num = (short)185925633;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_D5:
					num = (short)1305935878;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_AB:
				num = (short)160628736;
				short num4 = num;
				goto IL_120;
				IL_112:
				return this.Field.UIName;
				IL_1D3:
				return this.Field.NewUIName;
				IL_1D8:
				return null;
				IL_1DA:
				return null;
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x06000167 RID: 359 RVA: 0x0000FF2C File Offset: 0x0000E12C
		public string FieldValue
		{
			get
			{
				short num = (short)1087266896;
				short num2 = num;
				num = (short)1177509968;
				switch (num2 == num)
				{
				}
				num = (short)1547698176;
				short num3 = num;
				num = (short)413007873;
				if (num != 0)
				{
				}
				num = (short)1350565888;
				if (num != 0)
				{
				}
				string fldValue = global::AcpCommonLib.Utility.FormatFieldValue(this.Field);
				return global::AcpCommonLib.Utility.displayReverseForSpecialLanguageAndField(this.Field, fldValue);
			}
		}

		// Token: 0x04000085 RID: 133
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::AcpCommonLib.FieldInfoType a;

		// Token: 0x04000086 RID: 134
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::AcpCommonLib.IAcpField b;

		// Token: 0x04000087 RID: 135
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::AcpCommonLib.IAcpFeatureNode c;
	}
}
