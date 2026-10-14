using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using Microsoft.Practices.Prism.ViewModel;
using Motorola.Common.LogUtility;
using Motorola.CommonCPS.RadioManagement.CommonBase;
using Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x02000060 RID: 96
	public class TreeViewNode : global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase
	{
		// Token: 0x060002C5 RID: 709 RVA: 0x00029D48 File Offset: 0x00027F48
		private TreeViewNode()
		{
			this.c = new global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.TreeViewNode>();
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x060002C6 RID: 710 RVA: 0x00029D68 File Offset: 0x00027F68
		public global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.TreeViewNode> TreeViewNodes
		{
			get
			{
				short num = (short)541468918;
				short num2 = num;
				num = (short)405481718;
				switch (num2 == num)
				{
				}
				num = (short)1480982528;
				if (num != 0)
				{
				}
				num = (short)1124794369;
				if (num != 0)
				{
				}
				num = (short)1269432320;
				short num3 = num;
				return this.c;
			}
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x060002C7 RID: 711 RVA: 0x00029E1C File Offset: 0x0002801C
		public string UIName
		{
			get
			{
				short num = (short)1833710485;
				short num2 = num;
				num = (short)742405013;
				switch (num2 == num)
				{
				}
				num = (short)1099235329;
				if (num != 0)
				{
				}
				num = (short)1284964352;
				if (num != 0)
				{
				}
				num = (short)1315962880;
				short num3 = num;
				return this.a;
			}
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x060002C8 RID: 712 RVA: 0x00029ECC File Offset: 0x000280CC
		public string Name
		{
			get
			{
				short num = (short)350789811;
				short num2 = num;
				num = (short)1389797555;
				switch (num2 == num)
				{
				}
				num = (short)1068761089;
				if (num != 0)
				{
				}
				num = (short)2088370176;
				if (num != 0)
				{
				}
				num = (short)1203044352;
				short num3 = num;
				return this.b;
			}
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x060002C9 RID: 713 RVA: 0x00029F7C File Offset: 0x0002817C
		public string NodeType
		{
			get
			{
				short num = (short)659634122;
				short num2 = num;
				num = (short)772552650;
				switch (num2 == num)
				{
				}
				num = (short)1826357248;
				if (num != 0)
				{
				}
				num = (short)1382875137;
				if (num != 0)
				{
				}
				num = (short)271056896;
				short num3 = num;
				return global::Motorola.CommonCPS.RadioManagement.UIModels.TreeViewNode.GroupType;
			}
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x060002CA RID: 714 RVA: 0x0002A02C File Offset: 0x0002822C
		public bool Visible
		{
			get
			{
				global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.TreeViewNode> enumerator = this.c.GetEnumerator();
				short num;
				bool result;
				try
				{
					num = (short)1677393923;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_130;
						case 1:
							result = true;
							num = (short)1971585024;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_14C;
						case 3:
							switch (0)
							{
							case 0:
								goto IL_A2;
							}
							continue;
						case 4:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)37814278;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.RadioManagement.UIModels.TreeViewNode treeViewNode = enumerator.Current;
							num = (short)215416837;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 5:
						{
							global::Motorola.CommonCPS.RadioManagement.UIModels.TreeViewNode treeViewNode;
							if (treeViewNode.Visible)
							{
								num = (short)1017118721;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 6:
							num = (short)332791810;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_A4:
						num = (short)1357709316;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_A2:
						goto IL_A4;
					}
					IL_130:
					return result;
					IL_14C:
					goto IL_0E;
				}
				finally
				{
					num = (short)1252327426;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_202;
						case 1:
							enumerator.Dispose();
							goto IL_1EB;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_183;
							}
							continue;
						}
						IL_183:
						num = (short)1464627477;
						short num3 = num;
						num = (short)871919893;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							IL_1EB:
							num = (short)102301696;
							num2 = (int)((global::System.IntPtr)num);
							break;
						default:
							num = (short)1119223808;
							if (num != 0)
							{
							}
							if (enumerator == null)
							{
								goto IL_204;
							}
							num = (short)1075904513;
							num2 = (int)((global::System.IntPtr)num);
							break;
						}
					}
					IL_202:
					IL_204:;
				}
				return result;
				IL_0E:
				num = (short)1850015745;
				if (num != 0)
				{
				}
				num = (short)1098121216;
				short num4 = num;
				return false;
			}
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x060002CB RID: 715 RVA: 0x0002A250 File Offset: 0x00028450
		public bool IsEmpty
		{
			get
			{
				short num = (short)351666177;
				if (num != 0)
				{
				}
				global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.TreeViewNode> enumerator = this.c.GetEnumerator();
				bool result;
				try
				{
					num = (short)1552482307;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_132;
						case 1:
							result = false;
							num = (short)197984256;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_14F;
						case 3:
							switch (0)
							{
							case 0:
								goto IL_A7;
							}
							continue;
						case 4:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)336855046;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.RadioManagement.UIModels.TreeViewNode treeViewNode = enumerator.Current;
							num = (short)1577385989;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 5:
						{
							global::Motorola.CommonCPS.RadioManagement.UIModels.TreeViewNode treeViewNode;
							if (!treeViewNode.IsEmpty)
							{
								num = (short)1866727425;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 6:
							num = (short)494862338;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_A9:
						num = (short)1574699012;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_A7:
						goto IL_A9;
					}
					IL_132:
					return result;
					IL_14F:
					goto IL_37;
				}
				finally
				{
					num = (short)1672871938;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_207;
						case 1:
							enumerator.Dispose();
							goto IL_1EF;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_184;
							}
							continue;
						}
						IL_184:
						num = (short)851523879;
						short num3 = num;
						num = (short)859322663;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							IL_1EF:
							num = (short)1560477696;
							num2 = (int)((global::System.IntPtr)num);
							break;
						default:
							num = (short)1401946112;
							if (num != 0)
							{
							}
							if (enumerator == null)
							{
								goto IL_209;
							}
							num = (short)629866497;
							num2 = (int)((global::System.IntPtr)num);
							break;
						}
					}
					IL_207:
					IL_209:;
				}
				return result;
				IL_37:
				num = (short)1821245440;
				short num4 = num;
				return true;
			}
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x060002CC RID: 716 RVA: 0x0002A478 File Offset: 0x00028678
		public bool IsValid
		{
			get
			{
				short num = (short)1458696790;
				short num2 = num;
				num = (short)226947670;
				switch (num2 == num)
				{
				}
				num = (short)497680384;
				if (num != 0)
				{
				}
				num = (short)605618177;
				if (num != 0)
				{
				}
				num = (short)815792128;
				short num3 = num;
				return true;
			}
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x060002CD RID: 717 RVA: 0x0002A524 File Offset: 0x00028724
		public bool? IsSingleInstance
		{
			get
			{
				short num = (short)360365721;
				short num2 = num;
				num = (short)1422179993;
				switch (num2 == num)
				{
				}
				num = (short)1298333697;
				if (num != 0)
				{
				}
				num = (short)1625227264;
				if (num != 0)
				{
				}
				num = (short)863436800;
				short num3 = num;
				return null;
			}
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x060002CE RID: 718 RVA: 0x0002A5D8 File Offset: 0x000287D8
		public bool? IsShareable
		{
			get
			{
				short num = (short)834797569;
				if (num != 0)
				{
				}
				num = (short)409071577;
				short num2 = num;
				num = (short)805760985;
				switch (num2 == num)
				{
				}
				num = (short)1856831488;
				if (num != 0)
				{
				}
				num = (short)1052311552;
				short num3 = num;
				return null;
			}
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x060002CF RID: 719 RVA: 0x0002A688 File Offset: 0x00028888
		// (set) Token: 0x060002D0 RID: 720 RVA: 0x0002A738 File Offset: 0x00028938
		public global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase Target
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)636526581;
				short num2 = num;
				num = (short)968794101;
				switch (num2 == num)
				{
				}
				num = (short)1770782720;
				if (num != 0)
				{
				}
				num = (short)970391553;
				if (num != 0)
				{
				}
				num = (short)1410793472;
				short num3 = num;
				return this.d;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1491512840;
				short num2 = num;
				num = (short)710389256;
				switch (num2 == num)
				{
				}
				num = (short)2031943681;
				if (num != 0)
				{
				}
				num = (short)1337655296;
				if (num != 0)
				{
				}
				num = (short)1665925120;
				short num3 = num;
				this.d = value;
			}
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x0002A7E8 File Offset: 0x000289E8
		public static global::Motorola.CommonCPS.RadioManagement.UIModels.TreeViewNode MakeGroupNode(string resId, global::System.Collections.Generic.ICollection<global::Motorola.CommonCPS.RadioManagement.UIModels.TreeViewNode> children)
		{
			short num = (short)1691615232;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_46;
				}
				global::Motorola.CommonCPS.RadioManagement.UIModels.TreeViewNode ret;
				global::System.ComponentModel.PropertyChangedEventHandler <>9__0;
				for (;;)
				{
					IL_27:
					global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.TreeViewNode> enumerator;
					switch (num2)
					{
					case 0:
						try
						{
							num = (short)349700098;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 1:
									num = (short)466026499;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_E5;
									}
									continue;
								case 3:
									goto IL_1CB;
								case 4:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1338507265;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.CommonCPS.RadioManagement.UIModels.TreeViewNode treeViewNode = enumerator.Current;
									num = (short)1078198277;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
								{
									global::Motorola.CommonCPS.RadioManagement.UIModels.TreeViewNode treeViewNode;
									global::Microsoft.Practices.Prism.ViewModel.NotificationObject notificationObject = treeViewNode;
									global::System.ComponentModel.PropertyChangedEventHandler value;
									if ((value = <>9__0) == null)
									{
										value = (<>9__0 = delegate(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
										{
											int a_ = 2;
											short num5;
											try
											{
												num5 = (short)431947779;
												int num6 = (int)((global::System.IntPtr)num5);
												for (;;)
												{
													switch (num6)
													{
													case 0:
														goto IL_181;
													case 1:
														ret.RaisePropertyChanged(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("琼䰾р⹂㕄㍆え", a_));
														num5 = (short)856096774;
														num6 = (int)((global::System.IntPtr)num5);
														continue;
													case 2:
														goto IL_198;
													case 3:
														switch (0)
														{
														case 0:
															goto IL_49;
														}
														continue;
													case 4:
													{
														num5 = (short)1029342664;
														short num7 = num5;
														num5 = (short)1112049096;
														switch ((num7 == num5) ? 1 : 0)
														{
														case 0:
														case 2:
															break;
														default:
															num5 = (short)377290752;
															if (num5 != 0)
															{
															}
															ret.RaisePropertyChanged(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("欼嘾㉀⩂❄⭆ⱈ", a_));
															num5 = (short)1807089664;
															num6 = (int)((global::System.IntPtr)num5);
															continue;
														}
														break;
													}
													case 5:
														if (e.PropertyName == global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("琼䰾р⹂㕄㍆え", a_))
														{
															num5 = (short)174063617;
															num6 = (int)((global::System.IntPtr)num5);
															continue;
														}
														goto IL_181;
													case 6:
														goto IL_181;
													}
													IL_49:
													if (e.PropertyName == global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("欼嘾㉀⩂❄⭆ⱈ", a_))
													{
														num5 = (short)1633419268;
														num6 = (int)((global::System.IntPtr)num5);
														continue;
													}
													num5 = (short)1262616581;
													num6 = (int)((global::System.IntPtr)num5);
													continue;
													IL_181:
													num5 = (short)1075445762;
													num6 = (int)((global::System.IntPtr)num5);
												}
												IL_198:;
											}
											catch (global::System.Exception e2)
											{
												global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.CommonCPS.RadioManagement.CommonBase.LoggerName.RMCLoggerName).WriteEventEntry(e2, global::Motorola.Common.LogUtility.LoggingLevel.EventError);
											}
											num5 = (short)1764229121;
											if (num5 != 0)
											{
											}
											num5 = (short)1299841024;
											short num8 = num5;
										});
									}
									notificationObject.PropertyChanged += value;
									num = (short)226557953;
									if (num != 0)
									{
									}
									num = (short)538968064;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_174:
								num = (short)1088421892;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_E5:
								goto IL_174;
							}
							IL_1CB:
							goto IL_34B;
						}
						finally
						{
							num = (short)1776943106;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_288;
								case 1:
									enumerator.Dispose();
									goto IL_26F;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_203;
									}
									continue;
								}
								IL_203:
								num = (short)1772952073;
								short num3 = num;
								num = (short)1620843017;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									IL_26F:
									num = (short)636289024;
									num2 = (int)((global::System.IntPtr)num);
									break;
								default:
									num = (short)595197952;
									if (num != 0)
									{
									}
									if (enumerator == null)
									{
										goto IL_28A;
									}
									num = (short)2063335425;
									num2 = (int)((global::System.IntPtr)num);
									break;
								}
							}
							IL_288:
							IL_28A:;
						}
						goto IL_28B;
					case 1:
						ret.c = new global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.TreeViewNode>(children);
						num = (short)1591672835;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (children != null)
						{
							num = (short)929366021;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_28B;
					case 3:
						goto IL_28B;
					case 4:
						if (children.Count > 0)
						{
							num = (short)1353646081;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_28B;
					case 5:
						num = (short)733347844;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_46;
					IL_28B:
					enumerator = ret.c.GetEnumerator();
					num = (short)186777600;
					short num4 = num;
					num = (short)2055733248;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_34B:
				return ret;
				IL_46:
				string stringByResourceID = global::Motorola.CommonCPS.RadioManagement.CommonBase.PacResourceFactory.Instance().GetStringByResourceID(resId, null);
				ret = new global::Motorola.CommonCPS.RadioManagement.UIModels.TreeViewNode
				{
					a = stringByResourceID,
					b = resId
				};
				num = (short)1689124866;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x0002AB64 File Offset: 0x00028D64
		public override string ToString()
		{
			short num = (short)1132711503;
			short num2 = num;
			num = (short)1994706511;
			switch (num2 == num)
			{
			}
			num = (short)28114945;
			if (num != 0)
			{
			}
			num = (short)1915224064;
			if (num != 0)
			{
			}
			num = (short)2036137984;
			short num3 = num;
			return this.UIName;
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x0002AC14 File Offset: 0x00028E14
		public virtual void RaisePropertyChanged()
		{
			short num = (short)551312623;
			short num2 = num;
			num = (short)84630767;
			switch (num2 == num)
			{
			}
			num = (short)978518017;
			if (num != 0)
			{
			}
			num = (short)953810944;
			if (num != 0)
			{
			}
			num = (short)987430912;
			short num3 = num;
			base.RaisePropertyChanged<bool>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.TreeViewNode)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.TreeViewNode.get_IsValid())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
			base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.TreeViewNode)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.TreeViewNode.get_UIName())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x0002AD24 File Offset: 0x00028F24
		// Note: this type is marked as 'beforefieldinit'.
		static TreeViewNode()
		{
			int a_ = 6;
			short num = (short)131003582;
			short num2 = num;
			num = (short)1016329406;
			switch (num2 == num)
			{
			}
			num = (short)1992622081;
			if (num != 0)
			{
			}
			num = (short)1572864;
			if (num != 0)
			{
			}
			num = (short)301662208;
			short num3 = num;
			global::Motorola.CommonCPS.RadioManagement.UIModels.TreeViewNode.GroupType = global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ـㅂ⩄㉆㥈", a_);
		}

		// Token: 0x0400012D RID: 301
		public static readonly string GroupType;

		// Token: 0x0400012E RID: 302
		private string a;

		// Token: 0x0400012F RID: 303
		private string b;

		// Token: 0x04000130 RID: 304
		private global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.TreeViewNode> c;

		// Token: 0x04000131 RID: 305
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase d;
	}
}
