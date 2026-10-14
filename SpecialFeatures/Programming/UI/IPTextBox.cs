using System;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.Programming.UI
{
	// Token: 0x02000090 RID: 144
	internal class IPTextBox : global::System.Windows.Controls.TextBox
	{
		// Token: 0x06000A8D RID: 2701 RVA: 0x00002CC7 File Offset: 0x00000EC7
		public IPTextBox()
		{
			base.CommandBindings.Add(new global::System.Windows.Input.CommandBinding(global::System.Windows.Input.ApplicationCommands.Paste, new global::System.Windows.Input.ExecutedRoutedEventHandler(this.PasteOnExecute), new global::System.Windows.Input.CanExecuteRoutedEventHandler(this.PasteCanExecute)));
		}

		// Token: 0x1700041C RID: 1052
		// (get) Token: 0x06000A8E RID: 2702 RVA: 0x000C32F4 File Offset: 0x000C14F4
		// (set) Token: 0x06000A8F RID: 2703 RVA: 0x000C33A0 File Offset: 0x000C15A0
		internal int Min
		{
			get
			{
				short num = (short)1630208001;
				if (num != 0)
				{
				}
				num = (short)1788533851;
				short num2 = num;
				num = (short)499440731;
				switch (num2 == num)
				{
				}
				num = (short)1350959104;
				short num3 = num;
				num = (short)1689649152;
				if (num != 0)
				{
				}
				return this.a;
			}
			set
			{
				short num = (short)1182182860;
				short num2 = num;
				num = (short)843886028;
				switch (num2 == num)
				{
				}
				num = (short)523763713;
				if (num != 0)
				{
				}
				num = (short)1725759488;
				short num3 = num;
				num = (short)1197932544;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x1700041D RID: 1053
		// (get) Token: 0x06000A90 RID: 2704 RVA: 0x000C3450 File Offset: 0x000C1650
		// (set) Token: 0x06000A91 RID: 2705 RVA: 0x000C3504 File Offset: 0x000C1704
		internal int Max
		{
			get
			{
				short num = (short)1649082369;
				if (num != 0)
				{
				}
				num = (short)312857106;
				short num2 = num;
				num = (short)718459410;
				switch (num2 == num)
				{
				}
				num = (short)899547136;
				short num3 = num;
				num = (short)981467136;
				if (num != 0)
				{
				}
				return this.b;
			}
			set
			{
				short num = (short)1892037295;
				short num2 = num;
				num = (short)767636143;
				switch (num2 == num)
				{
				}
				num = (short)1113456641;
				if (num != 0)
				{
				}
				num = (short)1326514176;
				short num3 = num;
				num = (short)25296896;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x06000A92 RID: 2706 RVA: 0x000C35B4 File Offset: 0x000C17B4
		protected override void OnPreviewTextInput(global::System.Windows.Input.TextCompositionEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			short num2;
			string text;
			int caretIndex;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)1449841661;
					short num3 = num2;
					num2 = (short)514511869;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_86;
					default:
						goto IL_DA;
					}
					break;
				}
				case 1:
					goto IL_148;
				case 2:
					if (this.a(ref text, out caretIndex))
					{
						num2 = (short)596049923;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_86;
				case 3:
				{
					base.Text = text;
					base.CaretIndex = caretIndex;
					e.Handled = true;
					num2 = (short)1775501312;
					short num4 = num2;
					num2 = (short)474480641;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_20;
				IL_86:
				e.Handled = true;
				num2 = (short)1383989248;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_DA:
			num2 = (short)238223360;
			if (num2 != 0)
			{
			}
			IL_148:
			base.OnPreviewTextInput(e);
			return;
			IL_20:
			text = e.Text;
			caretIndex = 0;
			num2 = (short)353304577;
			if (num2 != 0)
			{
			}
			num2 = (short)1253769218;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000A93 RID: 2707 RVA: 0x000C3714 File Offset: 0x000C1914
		protected override void OnPreviewKeyDown(global::System.Windows.Input.KeyEventArgs e)
		{
			short num = (short)542900228;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)1466105857;
					if (num != 0)
					{
					}
					num = (short)1108344835;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					try
					{
						switch (0)
						{
						case 0:
							goto IL_A4;
						}
						int num4;
						for (;;)
						{
							IL_76:
							switch (num2)
							{
							case 0:
								goto IL_1E6;
							case 1:
								goto IL_223;
							case 2:
								num = (short)241500168;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
							{
								num = (short)1063689477;
								short num3 = num;
								num = (short)870817029;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_1E6;
								default:
									num = (short)502136832;
									if (num != 0)
									{
									}
									num4++;
									num = (short)1705246725;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 4:
								goto IL_23C;
							case 5:
								goto IL_1E6;
							case 6:
								if (e.Key == global::System.Windows.Input.Key.Up)
								{
									num = (short)1306853379;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								num4--;
								num = (short)1914961920;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 7:
								if (num4 >= this.a)
								{
									num = (short)140902402;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_223;
							case 8:
								if (num4 <= this.b)
								{
									num = (short)757399561;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_223;
							case 9:
								base.Text = global::System.Convert.ToString(num4);
								base.CaretIndex = base.Text.Length;
								num = (short)257425409;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_A4;
							IL_1E6:
							num = (short)598409223;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_223:
							num = (short)758972420;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_23C:
						goto IL_32A;
						IL_A4:
						num4 = global::System.Convert.ToInt32(base.Text);
						num = (short)1001521158;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_76;
					}
					catch (global::System.Exception)
					{
						goto IL_32A;
					}
					goto IL_247;
				case 2:
					if (base.Text != null)
					{
						num = (short)1919352838;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_32A;
				case 3:
					if (e.Key == global::System.Windows.Input.Key.Down)
					{
						num = (short)1474035717;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_32A;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_44;
					}
					continue;
				case 5:
					goto IL_2ED;
				case 6:
					goto IL_247;
				case 7:
					if (base.Text.Length > 0)
					{
						num = (short)1336344577;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_32A;
				}
				IL_44:
				if (e.Key != global::System.Windows.Input.Key.Up)
				{
					num = (short)1238237184;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_2ED;
				IL_247:
				num = (short)1426259975;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2ED:
				num = (short)638582786;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_32A:
			num = (short)63176704;
			short num5 = num;
			base.OnPreviewKeyDown(e);
		}

		// Token: 0x06000A94 RID: 2708 RVA: 0x000C3A98 File Offset: 0x000C1C98
		protected override void OnLostFocus(global::System.Windows.RoutedEventArgs e)
		{
			int a_ = 18;
			bool flag = false;
			short num;
			if (!this.c)
			{
				num = (short)47185920;
				short num2 = num;
				try
				{
					num = (short)255000583;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							goto IL_34D;
						case 1:
							goto IL_2AC;
						case 2:
							try
							{
								switch (0)
								{
								case 0:
									goto IL_E1;
								}
								int num4;
								for (;;)
								{
									IL_B7:
									switch (num3)
									{
									case 0:
										goto IL_202;
									case 1:
										if (num4 < this.a)
										{
											num = (short)1116733448;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_1EB;
									case 2:
										goto IL_1EB;
									case 3:
										if (base.Text.Length > 1)
										{
											num = (short)1626210309;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_194;
									case 4:
										num = (short)737411075;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 5:
										flag = true;
										num = (short)2096234502;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 6:
										goto IL_194;
									case 7:
										if (base.Text.StartsWith(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꖔ", a_)))
										{
											num = (short)602406916;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_194;
									case 8:
										flag = true;
										num4 = this.a;
										num = (short)1344405506;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_E1;
									IL_194:
									num = (short)2006384641;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_1EB:
									num = (short)17104896;
									num3 = (int)((global::System.IntPtr)num);
								}
								IL_202:
								goto IL_2B1;
								IL_E1:
								num4 = global::System.Convert.ToInt32(base.Text);
								num = (short)124256263;
								num3 = (int)((global::System.IntPtr)num);
								goto IL_B7;
							}
							catch (global::System.Exception)
							{
								int num4 = this.a;
								flag = true;
								goto IL_2B1;
							}
							goto IL_216;
							IL_2B1:
							num = (short)1406140424;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							goto IL_335;
						case 4:
							num = (short)1311834117;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							if (base.Text.Length > 0)
							{
								num = (short)933888002;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_335;
						case 6:
						{
							int num4;
							base.Text = global::System.Convert.ToString(num4);
							num = (short)691798017;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 7:
							switch (0)
							{
							case 0:
								goto IL_89;
							}
							continue;
						case 8:
						{
							if (!flag)
							{
								goto IL_216;
							}
							num = (short)1042397202;
							short num5 = num;
							num = (short)1893251090;
							switch ((num5 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_2AC;
							default:
								num = (short)416219136;
								if (num != 0)
								{
								}
								num = (short)420282374;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						}
						IL_89:
						if (base.Text != null)
						{
							num = (short)1500971012;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_335;
						IL_216:
						base.CaretIndex = base.Text.Length;
						num = (short)65404931;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_2AC:
						goto IL_216;
						IL_335:
						num = (short)385351680;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_34D:;
				}
				catch (global::System.Exception)
				{
				}
			}
			num = (short)785580033;
			if (num != 0)
			{
			}
			base.OnLostFocus(e);
		}

		// Token: 0x06000A95 RID: 2709 RVA: 0x000C3E5C File Offset: 0x000C205C
		private void PasteCanExecute(object A_0, global::System.Windows.Input.CanExecuteRoutedEventArgs A_1)
		{
			short num = (short)950295575;
			short num2 = num;
			num = (short)1531141143;
			switch (num2 == num)
			{
			}
			num = (short)973340672;
			short num3 = num;
			num = (short)1183645696;
			if (num != 0)
			{
			}
			num = (short)1445593089;
			if (num != 0)
			{
			}
			A_1.CanExecute = true;
			A_1.Handled = true;
		}

		// Token: 0x06000A96 RID: 2710 RVA: 0x000C3F14 File Offset: 0x000C2114
		private bool a(ref string A_0, out int A_1)
		{
			int a_ = 18;
			short num = (short)1311571968;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_93;
				}
				bool flag;
				global::System.Text.StringBuilder stringBuilder;
				for (;;)
				{
					IL_30:
					switch (num2)
					{
					case 0:
						goto IL_4B0;
					case 1:
						if (flag)
						{
							num = (short)1082982404;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4B0;
					case 2:
						if (base.Text.Length + A_0.Length <= base.MaxLength)
						{
							goto IL_134;
						}
						goto IL_E2;
					case 3:
						num = (short)581959696;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						num = (short)771424278;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						return flag;
					case 6:
						num = (short)1355087873;
						if (num != 0)
						{
						}
						goto IL_384;
					case 7:
						flag = false;
						num = (short)785448978;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
					{
						int selectionStart = base.SelectionStart;
						stringBuilder.Remove(selectionStart, base.SelectionLength);
						stringBuilder.Insert(selectionStart, A_0, 1);
						A_1 = selectionStart + A_0.Length;
						num = (short)72482835;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						goto IL_4B0;
					case 10:
						if (A_0.Length <= base.MaxLength)
						{
							num = (short)396820486;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_411;
					case 11:
						if (base.SelectionLength == 0)
						{
							num = (short)501153807;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E2;
					case 12:
					{
						int caretIndex = base.CaretIndex;
						stringBuilder.Insert(caretIndex, A_0, 1);
						A_1 = caretIndex + A_0.Length;
						num = (short)724434944;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
						if (A_0.StartsWith(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("뢔", a_)))
						{
							num = (short)1994981383;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_475;
					case 14:
						try
						{
							switch (0)
							{
							case 0:
								goto IL_1B7;
							}
							int num3;
							for (;;)
							{
								IL_17C:
								string text;
								switch (num2)
								{
								case 0:
									goto IL_377;
								case 1:
									if (text.Length != stringBuilder.Length)
									{
										num = (short)1782054922;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									A_0 = text;
									num = (short)2038300681;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									num = (short)240910340;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									text = num3.ToString();
									num = (short)287506433;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
								{
									int num4;
									if (A_1 >= global::System.Math.Abs(num4))
									{
										num = (short)610271237;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2EE;
								}
								case 5:
								{
									int num4;
									A_1 += num4;
									num = (short)1400832012;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									goto IL_35E;
								case 7:
									goto IL_35E;
								case 8:
								{
									int num4;
									if (num4 < 0)
									{
										num = (short)1457782786;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2EE;
								}
								case 9:
									goto IL_35E;
								case 10:
								{
									int num4 = text.Length - stringBuilder.Length;
									num = (short)876544008;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 11:
									if (num3 <= this.b)
									{
										num = (short)225443843;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									flag = false;
									num = (short)1943076870;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 12:
									goto IL_2EE;
								}
								goto IL_1B7;
								IL_2EE:
								A_0 = text;
								num = (short)1133182983;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_35E:
								num = (short)1410007040;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_377:
							return flag;
							IL_1B7:
							num3 = global::System.Convert.ToInt32(stringBuilder.ToString());
							num = (short)1978793995;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_17C;
						}
						catch (global::System.Exception)
						{
							return false;
						}
						goto IL_384;
					case 15:
						num = (short)832962562;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
					{
						if (base.Text.Length - base.SelectionLength + A_0.Length > base.MaxLength)
						{
							goto IL_664;
						}
						num = (short)72950273;
						short num5 = num;
						num = (short)809050625;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_134;
						default:
							num = (short)373620736;
							if (num != 0)
							{
							}
							num = (short)959512584;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 17:
						if (flag)
						{
							num = (short)1283063808;
							short num6 = num;
							num = (short)1349189646;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 18:
						goto IL_475;
					case 19:
						goto IL_4B0;
					case 20:
						num = (short)1719468042;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						if (A_0 != null)
						{
							num = (short)1000865812;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_411;
					case 22:
						if (base.SelectionLength > 0)
						{
							num = (short)466878467;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_664;
					}
					goto IL_93;
					IL_E2:
					flag = false;
					num = (short)193724425;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_134:
					num = (short)32636940;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_384:
					num = (short)2076770317;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_411:
					flag = false;
					num = (short)1573388293;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_475:
					num = (short)1308884993;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4B0:
					num = (short)2108489745;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_664:
					num = (short)1582956555;
					num2 = (int)((global::System.IntPtr)num);
				}
				return flag;
				IL_93:
				flag = true;
				A_1 = 0;
				stringBuilder = new global::System.Text.StringBuilder(base.Text);
				num = (short)490143765;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x06000A97 RID: 2711 RVA: 0x000C45E4 File Offset: 0x000C27E4
		private void PasteOnExecute(object A_0, global::System.Windows.Input.ExecutedRoutedEventArgs A_1)
		{
			short num = (short)199557121;
			if (num != 0)
			{
			}
			switch (0)
			{
			case 0:
				goto IL_50;
			}
			int num2;
			int caretIndex;
			for (;;)
			{
				IL_32:
				switch (num2)
				{
				case 0:
					goto IL_120;
				case 1:
					goto IL_14F;
				case 2:
				{
					num = (short)916565749;
					short num3 = num;
					num = (short)1289924341;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_102;
					case 1:
						break;
					default:
					{
						num = (short)1576009728;
						short num4 = num;
						break;
					}
					}
					num = (short)328859648;
					if (num != 0)
					{
					}
					string text = global::System.Windows.Clipboard.GetText();
					num = (short)1094189061;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 3:
				{
					string text;
					base.Text = text;
					base.CaretIndex = caretIndex;
					A_1.Handled = true;
					num = (short)1591869441;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
					if (global::System.Windows.Clipboard.ContainsText())
					{
						num = (short)1670578178;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_196;
				case 5:
				{
					string text;
					if (this.a(ref text, out caretIndex))
					{
						num = (short)347078659;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_102;
				}
				}
				goto IL_50;
				IL_102:
				A_1.Handled = true;
				num = (short)4521984;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_120:
			IL_14F:
			IL_196:
			this.c = false;
			return;
			IL_50:
			this.c = true;
			caretIndex = 0;
			num = (short)1223491588;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_32;
		}

		// Token: 0x04000459 RID: 1113
		private int a;

		// Token: 0x0400045A RID: 1114
		private int b;

		// Token: 0x0400045B RID: 1115
		private bool c;
	}
}
