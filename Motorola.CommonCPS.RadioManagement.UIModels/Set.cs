using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Windows.Data;
using System.Xml.Linq;
using Motorola.CommonCPS.RadioManagement.CommonBase;
using Motorola.CommonCPS.RadioManagement.CommonBase.Utility;
using Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste;
using Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x020000FA RID: 250
	[global::System.Diagnostics.DebuggerDisplay("SetType: {SetType}")]
	public class Set : global::Motorola.CommonCPS.RadioManagement.UIModels.EntityWrapper<global::Motorola.CommonCPS.Server.EntityModel.RecordSummary>, global::Motorola.CommonCPS.RadioManagement.UIModels.ITreeNode
	{
		// Token: 0x06000C49 RID: 3145 RVA: 0x000B7D34 File Offset: 0x000B5F34
		public Set(global::Motorola.CommonCPS.Server.EntityModel.RecordSummary efSetSummary) : base(efSetSummary ?? new global::Motorola.CommonCPS.Server.EntityModel.RecordSummary())
		{
			this.TelePortMode = true;
			this.e = new global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.ObservableCollectionFast<global::Motorola.CommonCPS.RadioManagement.UIModels.WarningResultItem>();
		}

		// Token: 0x170005AD RID: 1453
		// (get) Token: 0x06000C4A RID: 3146 RVA: 0x000B7D78 File Offset: 0x000B5F78
		// (set) Token: 0x06000C4B RID: 3147 RVA: 0x000B7E24 File Offset: 0x000B6024
		public global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.Set, global::Motorola.CommonCPS.RadioManagement.UIModels.FieldCollection> FieldsBuilder
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1533209425;
				short num2 = num;
				num = (short)1141435217;
				switch (num2 == num)
				{
				}
				num = (short)1119879169;
				if (num != 0)
				{
				}
				num = (short)495714304;
				if (num != 0)
				{
				}
				num = (short)2102001664;
				short num3 = num;
				return this.l;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)972685313;
				if (num != 0)
				{
				}
				num = (short)177406647;
				short num2 = num;
				num = (short)1622409911;
				switch (num2 == num)
				{
				}
				num = (short)1388838912;
				if (num != 0)
				{
				}
				num = (short)52363264;
				short num3 = num;
				this.l = value;
			}
		}

		// Token: 0x170005AE RID: 1454
		// (get) Token: 0x06000C4C RID: 3148 RVA: 0x000B7ED8 File Offset: 0x000B60D8
		// (set) Token: 0x06000C4D RID: 3149 RVA: 0x000B7F88 File Offset: 0x000B6188
		public global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.Set, global::Motorola.CommonCPS.RadioManagement.UIModels.FieldCollection> PreloadFieldsBuilder
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private get
			{
				short num = (short)376849652;
				short num2 = num;
				num = (short)584926452;
				switch (num2 == num)
				{
				}
				num = (short)820772865;
				if (num != 0)
				{
				}
				num = (short)1145700352;
				if (num != 0)
				{
				}
				num = (short)1609564160;
				short num3 = num;
				return this.m;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1317237865;
				short num2 = num;
				num = (short)152663145;
				switch (num2 == num)
				{
				}
				num = (short)1847984129;
				if (num != 0)
				{
				}
				num = (short)2035154944;
				if (num != 0)
				{
				}
				num = (short)363528192;
				short num3 = num;
				this.m = value;
			}
		}

		// Token: 0x170005AF RID: 1455
		// (get) Token: 0x06000C4E RID: 3150 RVA: 0x000B8038 File Offset: 0x000B6238
		// (set) Token: 0x06000C4F RID: 3151 RVA: 0x000B80E8 File Offset: 0x000B62E8
		public bool TelePortMode
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)490898841;
				short num2 = num;
				num = (short)602703257;
				switch (num2 == num)
				{
				}
				num = (short)721289217;
				if (num != 0)
				{
				}
				num = (short)761724928;
				if (num != 0)
				{
				}
				num = (short)1459814400;
				short num3 = num;
				return this.n;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)935723009;
				if (num != 0)
				{
				}
				num = (short)166953449;
				short num2 = num;
				num = (short)27230697;
				switch (num2 == num)
				{
				}
				num = (short)1031995392;
				short num3 = num;
				num = (short)485359616;
				if (num != 0)
				{
				}
				this.n = value;
			}
		}

		// Token: 0x170005B0 RID: 1456
		// (get) Token: 0x06000C50 RID: 3152 RVA: 0x000B8198 File Offset: 0x000B6398
		// (set) Token: 0x06000C51 RID: 3153 RVA: 0x000B8274 File Offset: 0x000B6474
		public override global::System.Guid? ID
		{
			get
			{
				short num = (short)666055652;
				short num2 = num;
				num = (short)1878143972;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1623195648;
					if (num != 0)
					{
					}
					if (!string.IsNullOrEmpty(this.EfSetSummary.UUID))
					{
						return new global::System.Guid?(new global::System.Guid(this.EfSetSummary.UUID));
					}
					break;
				}
				num = (short)835649537;
				if (num != 0)
				{
				}
				num = (short)1777926144;
				short num3 = num;
				return null;
			}
			set
			{
				short num = (short)1048903681;
				if (num != 0)
				{
				}
				num = (short)1402910545;
				short num2 = num;
				num = (short)219395921;
				switch (num2 == num)
				{
				}
				num = (short)906821632;
				short num3 = num;
				num = (short)994312192;
				if (num != 0)
				{
				}
				this.EfSetSummary.UUID = value.ToString();
			}
		}

		// Token: 0x170005B1 RID: 1457
		// (get) Token: 0x06000C52 RID: 3154 RVA: 0x000B8334 File Offset: 0x000B6534
		public virtual int? ConfigurationCount
		{
			get
			{
				short num = (short)38617856;
				short num2 = num;
				num = (short)1343963904;
				switch (num2 == num)
				{
				}
				num = (short)2064384001;
				if (num != 0)
				{
				}
				num = (short)748945408;
				short num3 = num;
				num = (short)725221376;
				if (num != 0)
				{
				}
				return new int?(this.EfSetSummary.ReferedCount);
			}
		}

		// Token: 0x170005B2 RID: 1458
		// (get) Token: 0x06000C53 RID: 3155 RVA: 0x000B83F0 File Offset: 0x000B65F0
		// (set) Token: 0x06000C54 RID: 3156 RVA: 0x000B84A0 File Offset: 0x000B66A0
		public string ConfigurationCountError
		{
			get
			{
				short num = (short)138536453;
				short num2 = num;
				num = (short)1627907589;
				switch (num2 == num)
				{
				}
				num = (short)1625358337;
				if (num != 0)
				{
				}
				num = (short)1216872448;
				short num3 = num;
				num = (short)1396178944;
				if (num != 0)
				{
				}
				return this.b;
			}
			set
			{
				short num = (short)1632174081;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						if (!base.IsLoading)
						{
							num = (short)532545540;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_38;
						}
						continue;
					case 2:
						goto IL_127;
					case 3:
						return;
					case 4:
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.Set)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.Set.get_ConfigurationCountError())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)2030043139;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_38:
					num = (short)193462272;
					short num3 = num;
					num = (short)1788742570;
					short num4 = num;
					num = (short)1359678378;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_127:
						num = (short)624099329;
						if (num != 0)
						{
						}
						this.b = value;
						num = (short)2142240768;
						num2 = (int)((global::System.IntPtr)num);
						break;
					default:
						num = (short)1312030720;
						if (num != 0)
						{
						}
						if (!(value != this.b))
						{
							return;
						}
						num = (short)1589510146;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
			}
		}

		// Token: 0x170005B3 RID: 1459
		// (get) Token: 0x06000C55 RID: 3157 RVA: 0x000B8640 File Offset: 0x000B6840
		// (set) Token: 0x06000C56 RID: 3158 RVA: 0x000B87E0 File Offset: 0x000B69E0
		public virtual global::Motorola.CommonCPS.RadioManagement.UIModels.FieldCollection Fields
		{
			get
			{
				short num = (short)1864499202;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)1031798784;
						short num3 = num;
						num = (short)704053249;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						if (this.FieldsBuilder != null)
						{
							goto IL_171;
						}
						this.c = null;
						num = (short)142147587;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_3D;
						}
						continue;
					case 3:
						goto IL_A6;
					case 4:
						goto IL_120;
					case 5:
					{
						num = (short)668898656;
						short num4 = num;
						num = (short)1768592736;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_171;
						default:
							num = (short)908984320;
							if (num != 0)
							{
							}
							this.c = this.FieldsBuilder(this);
							num = (short)1228406788;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					IL_3D:
					if (this.c == null)
					{
						num = (short)415760385;
						if (num != 0)
						{
						}
						num = (short)231538688;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_171:
					num = (short)1629159429;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_A6:
				IL_120:
				return this.c;
			}
			private set
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
						if (!base.IsLoading)
						{
							num2 = (short)1715994625;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					case 1:
					{
						num2 = (short)1650196481;
						if (num2 != 0)
						{
						}
						base.RaisePropertyChanged<global::Motorola.CommonCPS.RadioManagement.UIModels.FieldCollection>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.FieldCollection>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.Set)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.Set.get_Fields())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num2 = (short)1936023051;
						short num3 = num2;
						num2 = (short)135880203;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							return;
						default:
							num2 = (short)548995072;
							if (num2 != 0)
							{
							}
							num2 = (short)1259667458;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 2:
						return;
					}
					goto IL_1C;
				}
				return;
				IL_1C:
				this.c = value;
				num2 = (short)1282736128;
				short num4 = num2;
				num2 = (short)996999168;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x06000C57 RID: 3159 RVA: 0x000B8934 File Offset: 0x000B6B34
		public global::Motorola.CommonCPS.RadioManagement.UIModels.PasteResult PasteFrom(global::System.Xml.Linq.XElement xmlElement, ref global::System.Collections.Generic.List<global::System.Tuple<global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory, global::System.Xml.Linq.XElement>> setsToAdd, ref global::System.Collections.Generic.List<global::System.Tuple<global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory, global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.Set>>> setsToRemove, global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.PasteContext pasteContext)
		{
			int a_ = 0;
			short num;
			for (;;)
			{
				num = (short)243793920;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					num = (short)197525505;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_6A;
					}
					int num3;
					global::System.Collections.Generic.IEnumerator<global::System.Xml.Linq.XElement> enumerator;
					for (;;)
					{
						IL_57:
						switch (num2)
						{
						case 0:
							try
							{
								num = (short)1501757447;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::Motorola.CommonCPS.RadioManagement.UIModels.Set.<>c__DisplayClass35_0 CS$<>8__locals1;
									switch (num2)
									{
									case 1:
									{
										global::System.Xml.Linq.XElement xelement;
										if (!object.Equals(xelement.Name.ToString(), global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("堺刼匾ⵀ♂♄㍆⁈⑊⍌", a_)))
										{
											num = (short)992346118;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_1DC;
									}
									case 2:
										num = (short)583335955;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 3:
									{
										global::System.Xml.Linq.XElement xelement;
										if (!object.Equals(xelement.Name.ToString(), global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("䠺堼䬾", a_)))
										{
											num = (short)1713307662;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_1DC;
									}
									case 4:
										num = (short)498204673;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 5:
										num3++;
										num = (short)1947664384;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 6:
										num = (short)694616081;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 7:
										switch (0)
										{
										case 0:
											goto IL_1B7;
										}
										continue;
									case 8:
									{
										global::System.Xml.Linq.XElement xelement;
										if (!object.Equals(xelement.Name.ToString(), global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("崺吼娾ⵀ❂", a_)))
										{
											num = (short)1570045956;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_1DC;
									}
									case 9:
									{
										global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase fieldBase;
										if (fieldBase == null)
										{
											num = (short)1707016207;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)104267794;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 11:
									{
										if (!enumerator.MoveNext())
										{
											num = (short)583270402;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::System.Xml.Linq.XElement xelement = enumerator.Current;
										num = (short)77332483;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 13:
										goto IL_1DC;
									case 14:
										num = (short)319291400;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 15:
										pasteContext.Statuses.FieldNotFound(this, CS$<>8__locals1.fieldName);
										num = (short)880017420;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 16:
									{
										global::Motorola.CommonCPS.RadioManagement.UIModels.Set.<>c__DisplayClass35_0 CS$<>8__locals2 = CS$<>8__locals1;
										global::System.Xml.Linq.XElement xelement;
										global::System.Xml.Linq.XAttribute xattribute = xelement.Attribute(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("唺尼刾⑀", a_));
										CS$<>8__locals2.fieldName = ((xattribute != null) ? xattribute.Value : null);
										global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase fieldBase = this.Fields.FirstOrDefault(delegate(global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase fld)
										{
											short num6 = (short)658935510;
											short num7 = num6;
											num6 = (short)165580502;
											switch (num7 == num6)
											{
											}
											num6 = (short)1802240001;
											if (num6 != 0)
											{
											}
											num6 = (short)1892614144;
											short num8 = num6;
											num6 = (short)1758330880;
											if (num6 != 0)
											{
											}
											return fld.Name == CS$<>8__locals1.fieldName;
										});
										num = (short)368902153;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 17:
									{
										global::System.Xml.Linq.XElement xelement;
										if (object.Equals(xelement.Name.ToString(), global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("嘺䠼匾㕀⩂⍄⹆ⱈ❊⥌", a_)))
										{
											num = (short)1992884237;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										pasteContext.Statuses.InvalidXmlNodeName(this, xelement.Name.ToString());
										num = (short)648085514;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 18:
									{
										global::System.Xml.Linq.XElement xelement;
										global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase fieldBase;
										if (fieldBase.PasteFrom(xelement, ref setsToAdd, ref setsToRemove, pasteContext) == global::Motorola.CommonCPS.RadioManagement.UIModels.PasteResult.Changed)
										{
											num = (short)1763901445;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 19:
										goto IL_4EF;
									}
									goto IL_1B7;
									IL_1DC:
									CS$<>8__locals1 = new global::Motorola.CommonCPS.RadioManagement.UIModels.Set.<>c__DisplayClass35_0();
									num = (short)1279983632;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_495:
									num = (short)392429579;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_1B7:
									goto IL_495;
								}
								IL_4EF:
								goto IL_BB;
							}
							finally
							{
								num = (short)1304625152;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_528;
										}
										continue;
									case 1:
										enumerator.Dispose();
										num = (short)1620705282;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										goto IL_55F;
									}
									IL_528:
									if (enumerator == null)
									{
										break;
									}
									num = (short)637730817;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_55F:;
							}
							return global::Motorola.CommonCPS.RadioManagement.UIModels.PasteResult.Unchanged;
							IL_BB:
							num = (short)815267841;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							if (num3 <= 0)
							{
								num = (short)750321666;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return global::Motorola.CommonCPS.RadioManagement.UIModels.PasteResult.Changed;
						case 2:
							goto IL_F0;
						}
						goto IL_6A;
					}
					IL_F0:
					num = (short)1957564340;
					short num4 = num;
					num = (short)382799796;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						goto IL_126;
					}
					IL_6A:
					num = (short)2108293120;
					short num5 = num;
					num3 = 0;
					enumerator = xmlElement.Elements().GetEnumerator();
					num = (short)1499856896;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_57;
				}
				}
			}
			IL_126:
			num = (short)326762496;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.RadioManagement.UIModels.PasteResult.Unchanged;
		}

		// Token: 0x06000C58 RID: 3160 RVA: 0x000B8EC4 File Offset: 0x000B70C4
		public virtual void RefreshAllFields()
		{
			short num = (short)335151104;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)204341249;
				if (num != 0)
				{
				}
				num = (short)1768722354;
				short num3 = num;
				num = (short)288460722;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1381761024;
					short num4 = num;
					num = (short)1876951040;
					if (num != 0)
					{
					}
					global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase> enumerator;
					switch (num2)
					{
					case 0:
						goto IL_14;
					case 1:
						goto IL_206;
					case 2:
						try
						{
							num = (short)1672740865;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 1:
									switch (0)
									{
									case 0:
										goto IL_12B;
									}
									continue;
								case 2:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1447952387;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase fieldBase = enumerator.Current;
									fieldBase.RaisePropertyChanged();
									num = (short)2104360960;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									num = (short)2082930692;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									goto IL_19B;
								}
								IL_12D:
								num = (short)1003552770;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_12B:
								goto IL_12D;
							}
							IL_19B:
							return;
						}
						finally
						{
							num = (short)56426496;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_1D0;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)684261378;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_203;
								}
								IL_1D0:
								if (enumerator == null)
								{
									break;
								}
								num = (short)166789121;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_203:;
						}
						goto IL_206;
					}
					goto IL_CA;
					IL_206:
					enumerator = this.c.GetEnumerator();
					num = (short)1333526530;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_14:
				switch (0)
				{
				case 0:
					IL_CA:
					if (this.c == null)
					{
						return;
					}
					num = (short)1904672769;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
		}

		// Token: 0x170005B4 RID: 1460
		// (get) Token: 0x06000C59 RID: 3161 RVA: 0x000B9110 File Offset: 0x000B7310
		// (set) Token: 0x06000C5A RID: 3162 RVA: 0x000B92B4 File Offset: 0x000B74B4
		public global::Motorola.CommonCPS.RadioManagement.UIModels.FieldCollection PreloadFields
		{
			get
			{
				short num = (short)115998722;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)1594949633;
						if (num != 0)
						{
						}
						num = (short)870055936;
						short num3 = num;
						num = (short)1840054273;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						if (this.PreloadFieldsBuilder != null)
						{
							goto IL_174;
						}
						this.d = null;
						num = (short)1768423427;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_3C;
						}
						continue;
					case 3:
						goto IL_7D;
					case 4:
						goto IL_F9;
					case 5:
					{
						num = (short)994923805;
						short num4 = num;
						num = (short)213996829;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_174;
						default:
							num = (short)269418496;
							if (num != 0)
							{
							}
							this.d = this.PreloadFieldsBuilder(this);
							num = (short)1607925764;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					IL_3C:
					if (this.d == null)
					{
						num = (short)360710144;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_174:
					num = (short)1924464645;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_7D:
				IL_F9:
				return this.d;
			}
			private set
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
						if (!base.IsLoading)
						{
							num2 = (short)58195969;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					case 1:
					{
						base.RaisePropertyChanged<global::Motorola.CommonCPS.RadioManagement.UIModels.FieldCollection>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.FieldCollection>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.Set)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.Set.get_PreloadFields())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num2 = (short)1347321585;
						short num3 = num2;
						num2 = (short)1512865521;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							return;
						default:
							num2 = (short)1885863936;
							if (num2 != 0)
							{
							}
							num2 = (short)1091305473;
							if (num2 != 0)
							{
							}
							num2 = (short)393740290;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 2:
						return;
					}
					goto IL_1C;
				}
				return;
				IL_1C:
				this.d = value;
				num2 = (short)1284636672;
				short num4 = num2;
				num2 = (short)1608646656;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x170005B5 RID: 1461
		// (get) Token: 0x06000C5B RID: 3163 RVA: 0x000B9404 File Offset: 0x000B7604
		public bool IsSetPreloadFieldsBuilder
		{
			get
			{
				short num = (short)882032195;
				short num2 = num;
				num = (short)1126284867;
				switch (num2 == num)
				{
				}
				num = (short)1437073409;
				if (num != 0)
				{
				}
				num = (short)1621557248;
				short num3 = num;
				num = (short)1213267968;
				if (num != 0)
				{
				}
				return this.PreloadFieldsBuilder != null;
			}
		}

		// Token: 0x170005B6 RID: 1462
		// (get) Token: 0x06000C5C RID: 3164 RVA: 0x000B94B4 File Offset: 0x000B76B4
		public virtual bool IsDirty
		{
			get
			{
				short num = (short)1669143253;
				short num2 = num;
				num = (short)831855317;
				switch (num2 == num)
				{
				}
				num = (short)661192705;
				if (num != 0)
				{
				}
				num = (short)584581120;
				short num3 = num;
				num = (short)1241382912;
				if (num != 0)
				{
				}
				return false;
			}
		}

		// Token: 0x170005B7 RID: 1463
		// (get) Token: 0x06000C5D RID: 3165 RVA: 0x000B955C File Offset: 0x000B775C
		// (set) Token: 0x06000C5E RID: 3166 RVA: 0x000B960C File Offset: 0x000B780C
		public string ActiveFieldName
		{
			get
			{
				short num = (short)577384573;
				short num2 = num;
				num = (short)1573728381;
				switch (num2 == num)
				{
				}
				num = (short)736493569;
				if (num != 0)
				{
				}
				num = (short)1870987264;
				short num3 = num;
				num = (short)1346830336;
				if (num != 0)
				{
				}
				return this.a;
			}
			set
			{
				short num = (short)1334312961;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						if (!base.IsLoading)
						{
							num = (short)2041249796;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_38;
						}
						continue;
					case 2:
						goto IL_14A;
					case 3:
						return;
					case 4:
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.Set)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.Set.get_ActiveFieldName())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)2057568259;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_38:
					num = (short)1493434368;
					short num3 = num;
					num = (short)1105788929;
					if (num != 0)
					{
					}
					num = (short)237642642;
					short num4 = num;
					num = (short)1619207058;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_14A:
						this.a = value;
						num = (short)67305472;
						num2 = (int)((global::System.IntPtr)num);
						break;
					default:
						num = (short)1547960320;
						if (num != 0)
						{
						}
						if (!(value != this.a))
						{
							return;
						}
						num = (short)426704898;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
			}
		}

		// Token: 0x170005B8 RID: 1464
		// (get) Token: 0x06000C5F RID: 3167 RVA: 0x000B97A8 File Offset: 0x000B79A8
		// (set) Token: 0x06000C60 RID: 3168 RVA: 0x000B9858 File Offset: 0x000B7A58
		public bool IsSelected
		{
			get
			{
				short num = (short)1686592760;
				short num2 = num;
				num = (short)1519738104;
				switch (num2 == num)
				{
				}
				num = (short)1670578177;
				if (num != 0)
				{
				}
				num = (short)1582039040;
				short num3 = num;
				num = (short)414973952;
				if (num != 0)
				{
				}
				return this.g;
			}
			set
			{
				short num = (short)357892097;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						if (!base.IsLoading)
						{
							num = (short)119865348;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_38;
						}
						continue;
					case 2:
						goto IL_146;
					case 3:
						return;
					case 4:
						base.RaisePropertyChanged<bool>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.Set)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.Set.get_IsSelected())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)480378881;
						if (num != 0)
						{
						}
						num = (short)1772748803;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_38:
					num = (short)1394212864;
					short num3 = num;
					num = (short)744227794;
					short num4 = num;
					num = (short)103810002;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_146:
						this.g = value;
						num = (short)320405504;
						num2 = (int)((global::System.IntPtr)num);
						break;
					default:
						num = (short)731185152;
						if (num != 0)
						{
						}
						if (value == this.g)
						{
							return;
						}
						num = (short)513671170;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
			}
		}

		// Token: 0x170005B9 RID: 1465
		// (get) Token: 0x06000C61 RID: 3169 RVA: 0x000B99F0 File Offset: 0x000B7BF0
		// (set) Token: 0x06000C62 RID: 3170 RVA: 0x000B9AA0 File Offset: 0x000B7CA0
		public virtual bool IsValid
		{
			get
			{
				short num = (short)1967146516;
				short num2 = num;
				num = (short)1010976276;
				switch (num2 == num)
				{
				}
				num = (short)273940481;
				if (num != 0)
				{
				}
				num = (short)1200095232;
				short num3 = num;
				num = (short)1923481600;
				if (num != 0)
				{
				}
				return this.h;
			}
			set
			{
				short num = (short)1366818817;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						if (!base.IsLoading)
						{
							num = (short)2046492676;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_38;
						}
						continue;
					case 2:
						goto IL_148;
					case 3:
						return;
					case 4:
						base.RaisePropertyChanged<bool>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.Set)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.Set.get_IsValid())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)659030019;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_38:
					num = (short)140967936;
					short num3 = num;
					num = (short)1282473024;
					short num4 = num;
					num = (short)448855104;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_148:
						this.h = value;
						num = (short)832372736;
						num2 = (int)((global::System.IntPtr)num);
						break;
					default:
						num = (short)1155530753;
						if (num != 0)
						{
						}
						num = (short)579665920;
						if (num != 0)
						{
						}
						if (value == this.h)
						{
							return;
						}
						num = (short)666763266;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
			}
		}

		// Token: 0x170005BA RID: 1466
		// (get) Token: 0x06000C63 RID: 3171 RVA: 0x000B9C38 File Offset: 0x000B7E38
		public virtual bool IsVisible
		{
			get
			{
				short num = (short)1662344733;
				short num2 = num;
				num = (short)1879072285;
				switch (num2 == num)
				{
				}
				num = (short)220856321;
				if (num != 0)
				{
				}
				num = (short)863633408;
				short num3 = num;
				num = (short)1510277120;
				if (num != 0)
				{
				}
				return true;
			}
		}

		// Token: 0x170005BB RID: 1467
		// (get) Token: 0x06000C64 RID: 3172 RVA: 0x000B9CE4 File Offset: 0x000B7EE4
		// (set) Token: 0x06000C65 RID: 3173 RVA: 0x000B9D98 File Offset: 0x000B7F98
		public bool IsEditable
		{
			get
			{
				short num = (short)1733063607;
				short num2 = num;
				num = (short)1982559159;
				switch (num2 == num)
				{
				}
				num = (short)1241710593;
				if (num != 0)
				{
				}
				num = (short)2040070144;
				short num3 = num;
				num = (short)1255931904;
				if (num != 0)
				{
				}
				return this.f;
			}
			set
			{
				short num = (short)423165952;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)269480025;
						short num3 = num;
						num = (short)2005594201;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_106;
						case 1:
							break;
						default:
						{
							num = (short)343932928;
							short num4 = num;
							break;
						}
						}
						num = (short)1069285376;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_AF;
						}
						continue;
					}
					case 1:
						if (!base.IsLoading)
						{
							num = (short)1661403139;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 2:
						return;
					case 3:
						num = (short)15532033;
						if (num != 0)
						{
						}
						base.RaisePropertyChanged<bool>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.Set)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.Set.get_IsEditable())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						goto IL_106;
					case 4:
						this.f = value;
						num = (short)252248065;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_AF:
					if (value != this.f)
					{
						num = (short)959905796;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_106:
					num = (short)1629814786;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x170005BC RID: 1468
		// (get) Token: 0x06000C66 RID: 3174 RVA: 0x000B9F30 File Offset: 0x000B8130
		// (set) Token: 0x06000C67 RID: 3175 RVA: 0x000B9FE0 File Offset: 0x000B81E0
		public global::System.Drawing.Bitmap TypeIcon
		{
			get
			{
				short num = (short)1159790592;
				short num2 = num;
				num = (short)459293932;
				short num3 = num;
				num = (short)337593580;
				switch (num3 == num)
				{
				}
				num = (short)2014183425;
				if (num != 0)
				{
				}
				num = (short)1169293312;
				if (num != 0)
				{
				}
				return this.k;
			}
			set
			{
				short num = (short)861143040;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)435771560;
						short num3 = num;
						num = (short)1632458920;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_106;
						case 1:
							break;
						default:
						{
							num = (short)1459617792;
							short num4 = num;
							break;
						}
						}
						num = (short)699334656;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_B0;
						}
						continue;
					}
					case 1:
						if (!base.IsLoading)
						{
							num = (short)788594691;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 2:
						return;
					case 3:
						base.RaisePropertyChanged<global::System.Drawing.Bitmap>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::System.Drawing.Bitmap>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.Set)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.Set.get_TypeIcon())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						goto IL_106;
					case 4:
						this.k = value;
						num = (short)1406664705;
						if (num != 0)
						{
						}
						num = (short)977207297;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_B0:
					if (value != this.k)
					{
						num = (short)1579941892;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_106:
					num = (short)870973442;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x170005BD RID: 1469
		// (get) Token: 0x06000C68 RID: 3176 RVA: 0x000BA178 File Offset: 0x000B8378
		// (set) Token: 0x06000C69 RID: 3177 RVA: 0x000BA230 File Offset: 0x000B8430
		public virtual string Name
		{
			get
			{
				short num = (short)439353344;
				short num2 = num;
				num = (short)655301606;
				short num3 = num;
				num = (short)525474790;
				switch (num3 == num)
				{
				}
				num = (short)101056513;
				if (num != 0)
				{
				}
				num = (short)283049984;
				if (num != 0)
				{
				}
				return this.EfSetSummary.SetName;
			}
			set
			{
				short num = (short)879427584;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)1489796307;
						short num3 = num;
						num = (short)1034255571;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_139;
						case 1:
							break;
						default:
						{
							num = (short)1816395776;
							short num4 = num;
							break;
						}
						}
						num = (short)1574699008;
						if (num != 0)
						{
						}
						num = (short)325976065;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_D9;
						}
						continue;
					}
					case 1:
						if (!base.IsLoading)
						{
							num = (short)386334723;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 2:
						return;
					case 3:
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.Set)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.Set.get_Name())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						goto IL_139;
					case 4:
						this.EfSetSummary.SetName = value;
						num = (short)601948161;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_D9:
					if (value != this.EfSetSummary.SetName)
					{
						num = (short)1400832004;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_139:
					num = (short)1750401026;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x170005BE RID: 1470
		// (get) Token: 0x06000C6A RID: 3178 RVA: 0x000BA3DC File Offset: 0x000B85DC
		// (set) Token: 0x06000C6B RID: 3179 RVA: 0x000BA48C File Offset: 0x000B868C
		public override string Comments
		{
			get
			{
				short num = (short)1053491200;
				short num2 = num;
				num = (short)206486775;
				short num3 = num;
				num = (short)744799479;
				switch (num3 == num)
				{
				}
				num = (short)2102067201;
				if (num != 0)
				{
				}
				num = (short)1419509760;
				if (num != 0)
				{
				}
				return this.EfSetSummary.Comments;
			}
			set
			{
				short num = (short)66650112;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)675600578;
						short num3 = num;
						num = (short)1478023362;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_139;
						case 1:
							break;
						default:
						{
							num = (short)1771569152;
							short num4 = num;
							break;
						}
						}
						num = (short)1336803329;
						if (num != 0)
						{
						}
						num = (short)1133969408;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_D9;
						}
						continue;
					}
					case 1:
						if (!base.IsLoading)
						{
							num = (short)806682627;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 2:
						return;
					case 3:
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.Set)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase.get_Comments())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						goto IL_139;
					case 4:
						this.EfSetSummary.Comments = value;
						num = (short)991232001;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_D9:
					if (value != this.EfSetSummary.Comments)
					{
						num = (short)432209924;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_139:
					num = (short)104136706;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x170005BF RID: 1471
		// (get) Token: 0x06000C6C RID: 3180 RVA: 0x000BA634 File Offset: 0x000B8834
		// (set) Token: 0x06000C6D RID: 3181 RVA: 0x000BA734 File Offset: 0x000B8934
		public virtual string Date
		{
			get
			{
				int a_ = 5;
				short num = (short)165412864;
				short num2 = num;
				num = (short)2077994174;
				short num3 = num;
				num = (short)392408254;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)796065792;
					if (num != 0)
					{
					}
					if (!(this.EfSetSummary.LastModifiedDate == global::System.DateTime.MinValue))
					{
						return this.EfSetSummary.LastModifiedDate.ToLocalTime().ToString(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ܿ", a_), global::System.Globalization.CultureInfo.InvariantCulture);
					}
					break;
				}
				num = (short)167772161;
				if (num != 0)
				{
				}
				return string.Empty;
			}
			set
			{
				short num = (short)1266417664;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)907586953;
					short num3 = num;
					num = (short)2028187017;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1A0;
					case 1:
						break;
					default:
					{
						num = (short)604045312;
						short num4 = num;
						break;
					}
					}
					num = (short)418381825;
					if (num != 0)
					{
					}
					num = (short)1286995968;
					if (num != 0)
					{
					}
					global::System.DateTime dateTime;
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_DE;
						}
						continue;
					case 1:
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.Set)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.Set.get_Date())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)591790086;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_1A0;
					case 3:
						if (dateTime != this.EfSetSummary.LastModifiedDate)
						{
							num = (short)1041104901;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 4:
						if (!base.IsLoading)
						{
							num = (short)1514143745;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 5:
						this.EfSetSummary.LastModifiedDate = dateTime;
						num = (short)125632516;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						return;
					}
					IL_DE:
					if (global::System.DateTime.TryParse(value, out dateTime))
					{
						num = (short)101580802;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_1A0:
					num = (short)695402499;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x170005C0 RID: 1472
		// (get) Token: 0x06000C6E RID: 3182 RVA: 0x000BA928 File Offset: 0x000B8B28
		// (set) Token: 0x06000C6F RID: 3183 RVA: 0x000BA9E0 File Offset: 0x000B8BE0
		public string SetType
		{
			get
			{
				short num = (short)22151168;
				short num2 = num;
				num = (short)894173185;
				if (num != 0)
				{
				}
				num = (short)1612619182;
				short num3 = num;
				num = (short)1046650286;
				switch (num3 == num)
				{
				}
				num = (short)2007236608;
				if (num != 0)
				{
				}
				return this.EfSetSummary.RecordType;
			}
			set
			{
				short num = (short)1411055618;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)481427457;
						if (num != 0)
						{
						}
						this.EfSetSummary.RecordType = value;
						num = (short)1241233253;
						short num3 = num;
						num = (short)1067038565;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_14;
						default:
						{
							num = (short)215351296;
							short num4 = num;
							num = (short)1684471808;
							if (num != 0)
							{
							}
							num = (short)1882849281;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 1:
						return;
					case 2:
						goto IL_14;
					}
					goto IL_30;
					IL_14:
					switch (0)
					{
					case 0:
						IL_30:
						if (!(value != this.EfSetSummary.RecordType))
						{
							return;
						}
						num = (short)592576512;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
			}
		}

		// Token: 0x170005C1 RID: 1473
		// (get) Token: 0x06000C70 RID: 3184 RVA: 0x000BAB10 File Offset: 0x000B8D10
		public string UISetType
		{
			get
			{
				int a_ = 16;
				short num = (short)725549056;
				short num2 = num;
				num = (short)553184525;
				short num3 = num;
				num = (short)1355738381;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)451608577;
					if (num != 0)
					{
					}
					num = (short)1816920064;
					if (num != 0)
					{
					}
					if (!string.IsNullOrEmpty(this.SetType))
					{
						return global::Motorola.CommonCPS.RadioManagement.CommonBase.PacResourceFactory.Instance().GetStringByResourceID(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("Ɋौ၎ɐ㙒⅔ࡖ", a_) + this.SetType, null);
					}
					break;
				}
				return string.Empty;
			}
		}

		// Token: 0x170005C2 RID: 1474
		// (get) Token: 0x06000C71 RID: 3185 RVA: 0x000BABF8 File Offset: 0x000B8DF8
		// (set) Token: 0x06000C72 RID: 3186 RVA: 0x000BACA8 File Offset: 0x000B8EA8
		public string NameError
		{
			get
			{
				short num = (short)210632704;
				short num2 = num;
				num = (short)233373697;
				if (num != 0)
				{
				}
				num = (short)757073874;
				short num3 = num;
				num = (short)749668306;
				switch (num3 == num)
				{
				}
				num = (short)12320768;
				if (num != 0)
				{
				}
				return this.j;
			}
			set
			{
				short num = (short)2038235136;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)266865875;
						short num3 = num;
						num = (short)284953811;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_10E;
						case 1:
							break;
						default:
						{
							num = (short)1042022400;
							short num4 = num;
							break;
						}
						}
						num = (short)93978624;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_B3;
						}
						continue;
					}
					case 1:
						if (!base.IsLoading)
						{
							num = (short)294060033;
							if (num != 0)
							{
							}
							num = (short)1698037763;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 2:
						return;
					case 3:
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.Set)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.Set.get_NameError())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						goto IL_10E;
					case 4:
						this.j = value;
						num = (short)943915009;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_B3:
					if (value != this.j)
					{
						num = (short)1788280836;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_10E:
					num = (short)1650327554;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x170005C3 RID: 1475
		// (get) Token: 0x06000C73 RID: 3187 RVA: 0x000BAE4C File Offset: 0x000B904C
		// (set) Token: 0x06000C74 RID: 3188 RVA: 0x000BAF00 File Offset: 0x000B9100
		public byte[] Timestamp
		{
			get
			{
				short num = (short)218169344;
				short num2 = num;
				num = (short)639605876;
				short num3 = num;
				num = (short)979082356;
				switch (num3 == num)
				{
				}
				num = (short)4718593;
				if (num != 0)
				{
				}
				num = (short)437321728;
				if (num != 0)
				{
				}
				return this.EfSetSummary.Timestamp;
			}
			set
			{
				short num = (short)571998208;
				short num2 = num;
				num = (short)1840971777;
				if (num != 0)
				{
				}
				num = (short)1356702297;
				short num3 = num;
				num = (short)467706457;
				switch (num3 == num)
				{
				}
				num = (short)1883045888;
				if (num != 0)
				{
				}
				this.EfSetSummary.Timestamp = value;
			}
		}

		// Token: 0x170005C4 RID: 1476
		// (get) Token: 0x06000C75 RID: 3189 RVA: 0x000BAFB4 File Offset: 0x000B91B4
		public global::System.ComponentModel.ICollectionView Invalids
		{
			get
			{
				switch (0)
				{
				case 0:
					goto IL_20;
				}
				int num;
				global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory setCategory;
				short num2;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						if (setCategory != null)
						{
							num2 = (short)1490747395;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_145;
					case 1:
					{
						if (setCategory.IsTopSet)
						{
							goto IL_145;
						}
						num2 = (short)895622943;
						short num3 = num2;
						num2 = (short)53747487;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_90;
						default:
						{
							num2 = (short)1373175808;
							if (num2 != 0)
							{
							}
							num2 = (short)1036845056;
							short num4 = num2;
							num2 = (short)1585577986;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						}
						break;
					}
					case 2:
						goto IL_140;
					case 3:
						num2 = (short)1155203073;
						if (num2 != 0)
						{
						}
						goto IL_90;
					}
					goto IL_20;
					IL_90:
					num2 = (short)796721153;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_140:
				return this.a(setCategory).Invalids;
				IL_145:
				return null;
				IL_20:
				setCategory = (this.Parent as global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory);
				num2 = (short)1452277760;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x170005C5 RID: 1477
		// (get) Token: 0x06000C76 RID: 3190 RVA: 0x000BB108 File Offset: 0x000B9308
		public global::System.ComponentModel.ICollectionView Warnings
		{
			get
			{
				switch (0)
				{
				case 0:
					goto IL_20;
				}
				int num;
				global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory setCategory;
				short num2;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						goto IL_6A;
					case 1:
						goto IL_13D;
					case 2:
					{
						if (setCategory.IsTopSet)
						{
							goto IL_142;
						}
						num2 = (short)1709639751;
						short num3 = num2;
						num2 = (short)1065879623;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_6A;
						default:
						{
							num2 = (short)952827905;
							if (num2 != 0)
							{
							}
							num2 = (short)333185024;
							if (num2 != 0)
							{
							}
							num2 = (short)1664417792;
							short num4 = num2;
							num2 = (short)1498808321;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						}
						break;
					}
					case 3:
						if (setCategory != null)
						{
							num2 = (short)238026752;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_142;
					}
					goto IL_20;
					IL_6A:
					num2 = (short)542310402;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_13D:
				return this.a(setCategory).Warnings;
				IL_142:
				return global::System.Windows.Data.CollectionViewSource.GetDefaultView(this.e);
				IL_20:
				setCategory = (this.Parent as global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory);
				num2 = (short)555352067;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x170005C6 RID: 1478
		// (get) Token: 0x06000C77 RID: 3191 RVA: 0x000BB264 File Offset: 0x000B9464
		public virtual int Position
		{
			get
			{
				short num = (short)1928527873;
				if (num != 0)
				{
				}
				num = (short)16148909;
				short num2 = num;
				num = (short)1722313133;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1493565440;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)15335424;
				if (num != 0)
				{
				}
				return 0;
			}
		}

		// Token: 0x170005C7 RID: 1479
		// (get) Token: 0x06000C78 RID: 3192 RVA: 0x000BB30C File Offset: 0x000B950C
		public global::System.Collections.IList Children
		{
			get
			{
				short num = (short)2020732997;
				short num2 = num;
				num = (short)463859781;
				switch (num2 == num)
				{
				}
				num = (short)1253244928;
				short num3 = num;
				num = (short)1962999809;
				if (num != 0)
				{
				}
				num = (short)2076901376;
				if (num != 0)
				{
				}
				return this.Fields.ToList<global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase>();
			}
		}

		// Token: 0x170005C8 RID: 1480
		// (get) Token: 0x06000C79 RID: 3193 RVA: 0x000BB3C4 File Offset: 0x000B95C4
		public int ChildrenCount
		{
			get
			{
				short num = (short)997108877;
				short num2 = num;
				num = (short)1631562893;
				switch (num2 == num)
				{
				}
				num = (short)1350631424;
				short num3 = num;
				num = (short)103088128;
				if (num != 0)
				{
				}
				num = (short)373620737;
				if (num != 0)
				{
				}
				return this.Fields.Count;
			}
		}

		// Token: 0x170005C9 RID: 1481
		// (get) Token: 0x06000C7A RID: 3194 RVA: 0x000BB47C File Offset: 0x000B967C
		public bool IsNew
		{
			get
			{
				short num = (short)1383549003;
				short num2 = num;
				num = (short)1896564811;
				switch (num2 == num)
				{
				}
				num = (short)514654208;
				short num3 = num;
				num = (short)144637952;
				if (num != 0)
				{
				}
				num = (short)1255669761;
				if (num != 0)
				{
				}
				return false;
			}
		}

		// Token: 0x170005CA RID: 1482
		// (get) Token: 0x06000C7B RID: 3195 RVA: 0x000BB524 File Offset: 0x000B9724
		// (set) Token: 0x06000C7C RID: 3196 RVA: 0x000BB5D4 File Offset: 0x000B97D4
		public bool IsNeedUpdateInvalids
		{
			get
			{
				short num = (short)2096023987;
				short num2 = num;
				num = (short)1537788339;
				switch (num2 == num)
				{
				}
				num = (short)234160128;
				short num3 = num;
				num = (short)892600321;
				if (num != 0)
				{
				}
				num = (short)1179189248;
				if (num != 0)
				{
				}
				return this.i;
			}
			set
			{
				short num = (short)2490372;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						return;
					case 1:
					{
						num = (short)119805306;
						short num3 = num;
						num = (short)95098234;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_84;
						default:
							num = (short)1170800640;
							if (num != 0)
							{
							}
							num = (short)117374979;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
						goto IL_84;
					case 3:
						if (!base.IsLoading)
						{
							num = (short)1221328898;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 4:
						switch (0)
						{
						case 0:
							goto IL_39;
						}
						continue;
					}
					IL_39:
					num = (short)921174016;
					short num4 = num;
					if (value != this.i)
					{
						num = (short)11075585;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_84:
					num = (short)1681129473;
					if (num != 0)
					{
					}
					base.RaisePropertyChanged<bool>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.Set)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.Set.get_IsNeedUpdateInvalids())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
					num = (short)856948736;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x170005CB RID: 1483
		// (get) Token: 0x06000C7D RID: 3197 RVA: 0x000BB768 File Offset: 0x000B9968
		public virtual bool IsRoot
		{
			get
			{
				short num = (short)1102123395;
				short num2 = num;
				num = (short)1644630403;
				switch (num2 == num)
				{
				}
				num = (short)1161494528;
				short num3 = num;
				num = (short)1691025409;
				if (num != 0)
				{
				}
				num = (short)1337589760;
				if (num != 0)
				{
				}
				return false;
			}
		}

		// Token: 0x170005CC RID: 1484
		// (get) Token: 0x06000C7E RID: 3198 RVA: 0x000BB814 File Offset: 0x000B9A14
		public virtual string Alias
		{
			get
			{
				short num = (short)338018082;
				short num2 = num;
				num = (short)1666826018;
				switch (num2 == num)
				{
				}
				num = (short)1124139008;
				short num3 = num;
				num = (short)1018494977;
				if (num != 0)
				{
				}
				num = (short)870252544;
				if (num != 0)
				{
				}
				return this.Name;
			}
		}

		// Token: 0x170005CD RID: 1485
		// (get) Token: 0x06000C7F RID: 3199 RVA: 0x000BB8C4 File Offset: 0x000B9AC4
		// (set) Token: 0x06000C80 RID: 3200 RVA: 0x000BB970 File Offset: 0x000B9B70
		public global::Motorola.CommonCPS.RadioManagement.UIModels.ITreeNode Parent
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1566216385;
				short num2 = num;
				num = (short)1793822913;
				switch (num2 == num)
				{
				}
				num = (short)521207808;
				short num3 = num;
				num = (short)857145344;
				if (num != 0)
				{
				}
				num = (short)1159987201;
				if (num != 0)
				{
				}
				return this.o;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1996992085;
				short num2 = num;
				num = (short)1080077909;
				switch (num2 == num)
				{
				}
				num = (short)747700224;
				short num3 = num;
				num = (short)424869889;
				if (num != 0)
				{
				}
				num = (short)859439104;
				if (num != 0)
				{
				}
				this.o = value;
			}
		}

		// Token: 0x170005CE RID: 1486
		// (get) Token: 0x06000C81 RID: 3201 RVA: 0x000BBA20 File Offset: 0x000B9C20
		protected global::Motorola.CommonCPS.Server.EntityModel.RecordSummary EfSetSummary
		{
			get
			{
				short num = (short)683183704;
				short num2 = num;
				num = (short)651267672;
				switch (num2 == num)
				{
				}
				num = (short)465633280;
				short num3 = num;
				num = (short)2083192832;
				if (num != 0)
				{
				}
				num = (short)1145044993;
				if (num != 0)
				{
				}
				return base.Entity;
			}
		}

		// Token: 0x170005CF RID: 1487
		public override string this[string propertyName]
		{
			get
			{
				int a_ = 19;
				short num = (short)1105985540;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						if (!(propertyName == global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("Mㅏ㽑ㅓ", a_)))
						{
							num = (short)1012072455;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1734803457;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (!base.Validate(this.NameError))
						{
							goto IL_A8;
						}
						goto IL_10F;
					case 2:
					{
						if (base.Validate(this.ConfigurationCountError))
						{
							goto IL_C4;
						}
						num = (short)262799076;
						short num3 = num;
						num = (short)1535180516;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_A8;
						default:
							num = (short)1181810688;
							if (num != 0)
							{
							}
							num = (short)1032323078;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 3:
						goto IL_BF;
					case 4:
						switch (0)
						{
						case 0:
							goto IL_52;
						}
						continue;
					case 5:
						goto IL_10A;
					case 6:
						goto IL_224;
					case 7:
					{
						num = (short)314507264;
						short num4 = num;
						num = (short)2021785601;
						if (num != 0)
						{
						}
						num = (short)1236008965;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						num = (short)191561728;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_52:
					if (!(propertyName == global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("്㽏㱑㉓㽕㽗⽙⹛㽝ᑟୡୣࡥ⭧թᥫmѯ", a_)))
					{
						num = (short)2138505224;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)752746498;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_A8:
					num = (short)1006829571;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_BF:
				return base.Error;
				IL_C4:
				return string.Empty;
				IL_10A:
				return string.Empty;
				IL_10F:
				return string.Empty;
				IL_224:
				return base.Error;
			}
		}

		// Token: 0x06000C83 RID: 3203 RVA: 0x000BBD0C File Offset: 0x000B9F0C
		public void Accept(global::Motorola.CommonCPS.RadioManagement.UIModels.UIVisitor v, object context)
		{
			short num = (short)11665409;
			if (num != 0)
			{
			}
			global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase> enumerator = this.Fields.GetEnumerator();
			try
			{
				num = (short)1085865988;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)482213891;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase fieldBase = enumerator.Current;
						fieldBase.Accept(v, context);
						num = (short)489684993;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_DF;
					case 3:
						num = (short)1433665538;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						switch (0)
						{
						case 0:
							goto IL_6E;
						}
						continue;
					}
					IL_95:
					num = (short)719126528;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6E:
					goto IL_95;
				}
				IL_DF:;
			}
			finally
			{
				num = (short)1157824514;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_198;
					case 1:
					{
						num = (short)299040480;
						short num3 = num;
						num = (short)1376386784;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_198;
						default:
							num = (short)1789198336;
							if (num != 0)
							{
							}
							enumerator.Dispose();
							num = (short)691666944;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
						switch (0)
						{
						case 0:
							goto IL_115;
						}
						continue;
					}
					IL_115:
					if (enumerator == null)
					{
						break;
					}
					num = (short)1404174337;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_198:;
			}
			num = (short)1725759488;
			short num4 = num;
		}

		// Token: 0x06000C84 RID: 3204 RVA: 0x000BBEF0 File Offset: 0x000BA0F0
		public override void CleanErrors()
		{
			short num = (short)410286121;
			short num2 = num;
			num = (short)890730537;
			switch (num2 == num)
			{
			}
			num = (short)1827864576;
			short num3 = num;
			num = (short)558891009;
			if (num != 0)
			{
			}
			num = (short)743833600;
			if (num != 0)
			{
			}
			base.CleanErrors();
			this.ConfigurationCountError = string.Empty;
			this.NameError = string.Empty;
		}

		// Token: 0x06000C85 RID: 3205 RVA: 0x000BBFB8 File Offset: 0x000BA1B8
		public override void CopyFrom(global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase source)
		{
			int a_ = 13;
			short num = (short)1300430848;
			switch (num)
			{
			default:
			{
				global::Motorola.CommonCPS.RadioManagement.UIModels.Set set = source as global::Motorola.CommonCPS.RadioManagement.UIModels.Set;
				base.Entity = set.ToEntity();
				global::Motorola.CommonCPS.RadioManagement.UIModels.IUIModelValidate validator = base.Validator;
				base.Validator = null;
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.CopyObjectPublicProperties(source, this, global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ṇ⭉⁋❍㑏㍑⁓㥕⩗", a_));
				base.Validator = validator;
				global::System.Collections.Generic.IList<string> objectPublicProperties = global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.GetObjectPublicProperties(source, global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ṇ⭉⁋❍㑏㍑⁓㥕⩗", a_));
				global::System.Collections.Generic.IEnumerator<string> enumerator = objectPublicProperties.GetEnumerator();
				try
				{
					num = (short)1859846148;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)933953539;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							string propertyName = enumerator.Current;
							this.RaisePropertyChanged(propertyName);
							num = (short)237371393;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							goto IL_133;
						case 3:
							num = (short)1675296770;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							switch (0)
							{
							case 0:
								goto IL_BC;
							}
							continue;
						}
						IL_E6:
						num = (short)1916862464;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_BC:
						goto IL_E6;
					}
					IL_133:;
				}
				finally
				{
					num = (short)2088828930;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_216;
						case 1:
						{
							num = (short)464398203;
							short num3 = num;
							num = (short)1082992507;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_216;
							default:
								num = (short)1792671744;
								if (num != 0)
								{
								}
								num = (short)1305935873;
								if (num != 0)
								{
								}
								enumerator.Dispose();
								num = (short)126615552;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 2:
							switch (0)
							{
							case 0:
								goto IL_16A;
							}
							continue;
						}
						IL_16A:
						if (enumerator == null)
						{
							break;
						}
						num = (short)1095892993;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_216:;
				}
				num = (short)223150080;
				short num4 = num;
				return;
			}
			}
		}

		// Token: 0x06000C86 RID: 3206 RVA: 0x000BC218 File Offset: 0x000BA418
		public virtual void ClearFields()
		{
			short num = (short)1595674161;
			short num2 = num;
			num = (short)1404571185;
			switch (num2 == num)
			{
			}
			num = (short)650969088;
			short num3 = num;
			num = (short)756613120;
			if (num != 0)
			{
			}
			num = (short)178651137;
			if (num != 0)
			{
			}
			this.c = null;
		}

		// Token: 0x06000C87 RID: 3207 RVA: 0x000BC2CC File Offset: 0x000BA4CC
		public virtual void RaisePropertyChanged()
		{
			int a_ = 18;
			short num = (short)2001552267;
			short num2 = num;
			num = (short)1939555211;
			switch (num2 == num)
			{
			}
			num = (short)101253120;
			short num3 = num;
			num = (short)60424193;
			if (num != 0)
			{
			}
			num = (short)300285952;
			if (num != 0)
			{
			}
			this.RaisePropertyChanged(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ь㱎ᑐ㝒㱔⍖㡘㥚ㅜ㩞", a_));
			this.RaisePropertyChanged(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ь㱎ݐ㉒㥔㹖㵘", a_));
			this.RaisePropertyChanged(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ь㱎ᕐ㩒❔⍖⁘", a_));
			this.RaisePropertyChanged(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ь㱎ݐ㩒♔㹖㭘㝚㡜", a_));
			this.RaisePropertyChanged(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ᵌ⁎≐㩒⅔㹖㙘㕚", a_));
			this.RaisePropertyChanged(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ౌ⍎㡐㉒♔", a_));
			this.RaisePropertyChanged(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("͌⹎㱐㙒", a_));
			this.RaisePropertyChanged(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ौ⹎═㙒", a_));
			this.RaisePropertyChanged(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("์⁎㱐㹒ご㥖ⵘ⡚", a_));
		}

		// Token: 0x06000C88 RID: 3208 RVA: 0x000BC434 File Offset: 0x000BA634
		public override string ToString()
		{
			short num;
			string result;
			try
			{
				num = (short)210924132;
				short num2 = num;
				num = (short)1784443492;
				switch (num2 == num)
				{
				}
				num = (short)370147328;
				if (num != 0)
				{
				}
				result = this.EfSetSummary.SetName;
			}
			catch (global::System.Exception)
			{
				result = string.Empty;
			}
			num = (short)2122907649;
			if (num != 0)
			{
			}
			num = (short)86441984;
			short num3 = num;
			return result;
		}

		// Token: 0x06000C89 RID: 3209 RVA: 0x000BC508 File Offset: 0x000BA708
		public global::System.Xml.Linq.XElement ToCopy()
		{
			int a_ = 12;
			short num = (short)587661317;
			int num2 = (int)((global::System.IntPtr)num);
			global::System.Xml.Linq.XElement xelement;
			global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase> enumerator;
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1948844032;
					short num3 = num;
					xelement = new global::System.Xml.Linq.XElement(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("㑆ⱈ㽊", a_), new global::System.Xml.Linq.XAttribute(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("⥆⡈♊⡌", a_), this.SetType));
					num = (short)503185409;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					if (global::Motorola.CommonCPS.RadioManagement.UIModels.CopyPasteUtility.IsIdentifiedByAlias(this))
					{
						num = (short)1582891012;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_91;
				case 2:
					goto IL_B4;
				case 3:
					goto IL_91;
				case 4:
					xelement.Add(new global::System.Xml.Linq.XAttribute(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("♆╈≊ⱌ㱎", a_), this.Alias));
					num = (short)920518659;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					switch (0)
					{
					case 0:
						goto IL_46;
					}
					continue;
				}
				IL_46:
				if (this.IsVisible)
				{
					num = (short)1709899776;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_306;
				IL_91:
				enumerator = this.Fields.GetEnumerator();
				num = (short)991166466;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_B4:
			num = (short)967311361;
			if (num != 0)
			{
			}
			try
			{
				num = (short)904069124;
				num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						num = (short)1421213698;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)1679753216;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase fieldBase = enumerator.Current;
						xelement.Add(fieldBase.ToCopy());
						num = (short)1104412675;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_247;
					case 4:
						switch (0)
						{
						case 0:
							goto IL_1D0;
						}
						continue;
					}
					IL_1D2:
					num = (short)1675296769;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1D0:
					goto IL_1D2;
				}
				IL_247:
				return xelement;
			}
			finally
			{
				num = (short)35782658;
				num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_303;
					case 1:
					{
						num = (short)753789528;
						short num4 = num;
						num = (short)1899555416;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_303;
						default:
							num = (short)1120534528;
							if (num != 0)
							{
							}
							enumerator.Dispose();
							num = (short)1673789440;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
						switch (0)
						{
						case 0:
							goto IL_27D;
						}
						continue;
					}
					IL_27D:
					if (enumerator == null)
					{
						break;
					}
					num = (short)1494876161;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_303:;
			}
			IL_306:
			return null;
		}

		// Token: 0x06000C8A RID: 3210 RVA: 0x000BC82C File Offset: 0x000BAA2C
		private global::Motorola.CommonCPS.RadioManagement.UIModels.Set a(global::Motorola.CommonCPS.RadioManagement.UIModels.ITreeNode A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_60;
			}
			int num;
			short num2;
			global::Motorola.CommonCPS.RadioManagement.UIModels.Set result;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (A_0 is global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory)
					{
						num2 = (short)1284440070;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1143078928;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
				{
					num2 = (short)812239390;
					short num3 = num2;
					num2 = (short)642435614;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_386;
					default:
						goto IL_223;
					}
					break;
				}
				case 2:
					if (A_0 is global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory)
					{
						num2 = (short)1064828943;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_109;
				case 3:
					goto IL_187;
				case 4:
					goto IL_BE;
				case 5:
					num2 = (short)93716487;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					result = this.a(A_0.Parent);
					goto IL_386;
				case 7:
					if (A_0.Parent is global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory)
					{
						num2 = (short)369688586;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_187;
				case 8:
					result = this.a(A_0.Parent);
					num2 = (short)1170931713;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					return result;
				case 10:
					num2 = (short)1153695763;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 11:
					if (A_0 is global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase)
					{
						num2 = (short)1421213704;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 12:
					goto IL_9E;
				case 13:
					if (A_0.Parent == null)
					{
						num2 = (short)1688272908;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					result = this.a(A_0.Parent);
					num2 = (short)706347017;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 14:
					if ((A_0 as global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory).IsTopSet)
					{
						num2 = (short)1184628754;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_109;
				case 15:
					num2 = (short)335151105;
					if (num2 != 0)
					{
					}
					num2 = (short)894697486;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 16:
					if (A_0 is global::Motorola.CommonCPS.RadioManagement.UIModels.Set)
					{
						num2 = (short)1225064448;
						short num4 = num2;
						num2 = (short)395444229;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1285619723;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 17:
					return result;
				case 18:
					return result;
				case 19:
					if (!(A_0.Parent as global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory).IsTopSet)
					{
						num2 = (short)344719363;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_9E;
				}
				goto IL_60;
				IL_9E:
				result = (A_0 as global::Motorola.CommonCPS.RadioManagement.UIModels.Set);
				num2 = (short)1274216452;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_109:
				num2 = (short)1703477248;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_187:
				num2 = (short)901316621;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_386:
				num2 = (short)1260584977;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_BE:
			return result;
			IL_223:
			num2 = (short)1875181568;
			if (num2 != 0)
			{
			}
			return result;
			IL_60:
			result = null;
			num2 = (short)2109669378;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x04000453 RID: 1107
		private string a;

		// Token: 0x04000454 RID: 1108
		private string b;

		// Token: 0x04000455 RID: 1109
		private global::Motorola.CommonCPS.RadioManagement.UIModels.FieldCollection c;

		// Token: 0x04000456 RID: 1110
		private global::Motorola.CommonCPS.RadioManagement.UIModels.FieldCollection d;

		// Token: 0x04000457 RID: 1111
		private global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.ObservableCollectionFast<global::Motorola.CommonCPS.RadioManagement.UIModels.WarningResultItem> e;

		// Token: 0x04000458 RID: 1112
		private bool f = true;

		// Token: 0x04000459 RID: 1113
		private bool g;

		// Token: 0x0400045A RID: 1114
		private bool h = true;

		// Token: 0x0400045B RID: 1115
		private bool i;

		// Token: 0x0400045C RID: 1116
		private string j;

		// Token: 0x0400045D RID: 1117
		private global::System.Drawing.Bitmap k;

		// Token: 0x0400045E RID: 1118
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.Set, global::Motorola.CommonCPS.RadioManagement.UIModels.FieldCollection> l;

		// Token: 0x0400045F RID: 1119
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.Set, global::Motorola.CommonCPS.RadioManagement.UIModels.FieldCollection> m;

		// Token: 0x04000460 RID: 1120
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool n;

		// Token: 0x04000461 RID: 1121
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.RadioManagement.UIModels.ITreeNode o;
	}
}
