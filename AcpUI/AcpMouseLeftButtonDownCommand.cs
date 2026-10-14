using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Input;
using System.Windows.Media;
using Infragistics.Windows.Editors;

namespace AcpUI
{
	// Token: 0x0200003F RID: 63
	public class AcpMouseLeftButtonDownCommand : global::System.Windows.Input.ICommand
	{
		// Token: 0x060003B9 RID: 953 RVA: 0x00040414 File Offset: 0x0003E614
		public bool CanExecute(object parameter)
		{
			short num = (short)1935930227;
			short num2 = num;
			num = (short)1613296499;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1297940480;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1762263040;
			if (num != 0)
			{
			}
			num = (short)1490223105;
			if (num != 0)
			{
			}
			return true;
		}

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x060003BA RID: 954 RVA: 0x000404C0 File Offset: 0x0003E6C0
		// (remove) Token: 0x060003BB RID: 955 RVA: 0x000405F8 File Offset: 0x0003E7F8
		public event global::System.EventHandler CanExecuteChanged
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				short num;
				int num3;
				global::System.EventHandler eventHandler;
				switch (0)
				{
				case 0:
					break;
				default:
					for (;;)
					{
						IL_0A:
						num = (short)281999092;
						short num2 = num;
						num = (short)939587316;
						switch ((num2 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_6E;
						default:
						{
							num = (short)429064192;
							if (num != 0)
							{
							}
							global::System.EventHandler eventHandler2;
							switch (num3)
							{
							case 0:
								return;
							case 1:
								if (eventHandler == eventHandler2)
								{
									num = (short)1989017600;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_85;
							case 2:
								goto IL_85;
							}
							goto IL_67;
							IL_85:
							num = (short)1824194560;
							short num4 = num;
							num = (short)863174657;
							if (num != 0)
							{
							}
							eventHandler2 = eventHandler;
							global::System.EventHandler value2 = (global::System.EventHandler)global::System.Delegate.Combine(eventHandler2, value);
							eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler>(ref this.a, value2, eventHandler2);
							num = (short)1283784705;
							num3 = (int)((global::System.IntPtr)num);
							break;
						}
						}
					}
					return;
				}
				IL_67:
				eventHandler = this.a;
				IL_6E:
				num = (short)1779957762;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_0A;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				short num;
				int num3;
				global::System.EventHandler eventHandler;
				switch (0)
				{
				case 0:
					break;
				default:
					for (;;)
					{
						IL_0A:
						num = (short)444587734;
						short num2 = num;
						num = (short)114810582;
						switch ((num2 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_6D;
						default:
						{
							num = (short)1061683200;
							if (num != 0)
							{
							}
							global::System.EventHandler eventHandler2;
							switch (num3)
							{
							case 0:
								return;
							case 1:
								if (eventHandler == eventHandler2)
								{
									num = (short)823656448;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_D8;
							case 2:
							{
								num = (short)1758593024;
								short num4 = num;
								goto IL_D8;
							}
							}
							goto IL_66;
							IL_D8:
							eventHandler2 = eventHandler;
							global::System.EventHandler value2 = (global::System.EventHandler)global::System.Delegate.Remove(eventHandler2, value);
							eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler>(ref this.a, value2, eventHandler2);
							num = (short)1805320193;
							num3 = (int)((global::System.IntPtr)num);
							break;
						}
						}
					}
					return;
				}
				IL_66:
				eventHandler = this.a;
				IL_6D:
				num = (short)1251409921;
				if (num != 0)
				{
				}
				num = (short)218759170;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_0A;
			}
		}

		// Token: 0x060003BC RID: 956 RVA: 0x00040730 File Offset: 0x0003E930
		public void Execute(object parameter)
		{
			short num;
			try
			{
				num = (short)1770061824;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					switch (0)
					{
					case 0:
						goto IL_11A;
					}
					global::AcpUI.AcpCommandParameter acpCommandParameter;
					for (;;)
					{
						IL_27:
						global::Infragistics.Windows.Editors.XamMaskedEditor xamMaskedEditor;
						global::Infragistics.Windows.Editors.XamMaskedEditor xamMaskedEditor2;
						global::Infragistics.Windows.Editors.XamMaskedEditor xamMaskedEditor4;
						global::Infragistics.Windows.Editors.XamMaskedEditor elementUnderMouse;
						global::Infragistics.Windows.Editors.XamMaskedEditor elementUnderMouse2;
						switch (num2)
						{
						case 0:
							if (xamMaskedEditor != null)
							{
								num = (short)167903277;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_9F9;
						case 1:
							goto IL_A11;
						case 2:
						{
							object parameter2 = acpCommandParameter.Parameter;
							xamMaskedEditor2 = (acpCommandParameter.Sender as global::Infragistics.Windows.Editors.XamMaskedEditor);
							num = (short)566624280;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
						{
							global::Infragistics.Windows.Editors.XamMaskedEditor xamMaskedEditor3;
							if (!xamMaskedEditor3.IsInEditMode)
							{
								num = (short)1767178270;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_20C;
						}
						case 4:
							goto IL_9F9;
						case 5:
							if (acpCommandParameter.Parameter.GetType() == typeof(global::AcpUI.AcpTableTextBoxSpinnerDecHex))
							{
								num = (short)340459560;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1111097358;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							if (!xamMaskedEditor4.IsFocused)
							{
								num = (short)681639977;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_6BC;
						case 7:
							if (acpCommandParameter.Parameter.GetType() == typeof(global::AcpUI.AcpTableTextBoxBase))
							{
								num = (short)1956053026;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1505296435;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
							goto IL_9F9;
						case 9:
						{
							global::Infragistics.Windows.Editors.XamMaskedEditor xamMaskedEditor5;
							if (xamMaskedEditor5 != null)
							{
								num = (short)1638531115;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_9F9;
						}
						case 10:
							goto IL_7E3;
						case 11:
							num = (short)810156074;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 12:
							if (acpCommandParameter.Parameter.GetType() == typeof(global::AcpUI.AcpTableTextBoxDecHex))
							{
								num = (short)620494895;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1615593479;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 13:
						{
							global::Infragistics.Windows.Editors.XamMaskedEditor xamMaskedEditor6;
							if (!xamMaskedEditor6.IsFocused)
							{
								num = (short)1105526795;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_295;
						}
						case 14:
							if (acpCommandParameter.Parameter.GetType() == typeof(global::AcpUI.AcpTableTextBoxSpinner))
							{
								num = (short)1432420371;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)593166348;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 15:
							num = (short)1595342865;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 16:
							goto IL_6BC;
						case 17:
							if (xamMaskedEditor.IsInEditMode)
							{
								num = (short)491192330;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_9F9;
						case 18:
						{
							global::Infragistics.Windows.Editors.XamMaskedEditor xamMaskedEditor3;
							if (!xamMaskedEditor3.IsFocused)
							{
								num = (short)1313931310;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_20C;
						}
						case 19:
						{
							global::AcpUI.AcpTableTextBoxBase acpTextBoxMember = (acpCommandParameter.Parameter as global::AcpUI.AcpTableTextBoxSpinner).AcpTextBoxMember;
							xamMaskedEditor4 = acpTextBoxMember.FindVisualChild<global::Infragistics.Windows.Editors.XamMaskedEditor>(acpTextBoxMember);
							num = (short)528678933;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 20:
						{
							global::Infragistics.Windows.Editors.XamMaskedEditor xamMaskedEditor6;
							if (!xamMaskedEditor6.IsInEditMode)
							{
								num = (short)72679474;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_295;
						}
						case 21:
						{
							if (xamMaskedEditor4 != null)
							{
								num = (short)1049100326;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::AcpUI.AcpTableTextBoxBase acpTextBoxMember;
							acpTextBoxMember.CaretBrush = global::System.Windows.Media.Brushes.Black;
							num = (short)1009451036;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 22:
							if (!xamMaskedEditor2.IsFocused)
							{
								num = (short)402849818;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_3E4;
						case 23:
							num = (short)831389699;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 24:
							if (xamMaskedEditor2 != null)
							{
								num = (short)1604190261;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_9F9;
						case 25:
						{
							global::Infragistics.Windows.Editors.XamMaskedEditor xamMaskedEditor7;
							if (xamMaskedEditor7.IsInEditMode)
							{
								num = (short)2058944548;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_9F9;
						}
						case 26:
							num = (short)1775697976;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 27:
							if (xamMaskedEditor4.IsInEditMode)
							{
								num = (short)1542848528;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_9F9;
						case 28:
						{
							num = (short)2142939388;
							short num3 = num;
							num = (short)2100603132;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_7E3;
							default:
								num = (short)1477902336;
								if (num != 0)
								{
								}
								goto IL_9F9;
							}
							break;
						}
						case 29:
						{
							global::Infragistics.Windows.Editors.XamMaskedEditor xamMaskedEditor5;
							if (!xamMaskedEditor5.IsFocused)
							{
								num = (short)322961431;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_20C;
						}
						case 30:
							num = (short)605224999;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 31:
							goto IL_20C;
						case 32:
							goto IL_3E4;
						case 33:
							num = (short)55771171;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 34:
						{
							object parameter3 = acpCommandParameter.Parameter;
							xamMaskedEditor = (acpCommandParameter.Sender as global::Infragistics.Windows.Editors.XamMaskedEditor);
							num = (short)658636800;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 35:
						{
							global::Infragistics.Windows.Editors.XamMaskedEditor xamMaskedEditor7;
							if (xamMaskedEditor7 != null)
							{
								num = (short)570359845;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_9F9;
						}
						case 36:
							goto IL_295;
						case 37:
							num = (short)857866253;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 38:
							num = (short)1592983558;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 39:
						{
							global::Infragistics.Windows.Editors.XamMaskedEditor xamMaskedEditor5;
							if (xamMaskedEditor5.IsInEditMode)
							{
								num = (short)1895890975;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_9F9;
						}
						case 40:
						{
							global::AcpUI.AcpTableTextBoxSpinnerDecHex acpTableTextBoxSpinnerDecHex = acpCommandParameter.Parameter as global::AcpUI.AcpTableTextBoxSpinnerDecHex;
							global::AcpUI.AcpTableTextBoxBase acpTextBoxMemberDec = acpTableTextBoxSpinnerDecHex.AcpTextBoxMemberDec;
							global::AcpUI.AcpTableTextBoxBase acpTextBoxMemberHex = acpTableTextBoxSpinnerDecHex.AcpTextBoxMemberHex;
							global::Infragistics.Windows.Editors.XamMaskedEditor xamMaskedEditor3 = acpTextBoxMemberDec.FindVisualChild<global::Infragistics.Windows.Editors.XamMaskedEditor>(acpTextBoxMemberDec);
							global::Infragistics.Windows.Editors.XamMaskedEditor xamMaskedEditor5 = acpTextBoxMemberHex.FindVisualChild<global::Infragistics.Windows.Editors.XamMaskedEditor>(acpTextBoxMemberHex);
							elementUnderMouse = global::AcpUI.AcpTextBox.GetElementUnderMouse<global::Infragistics.Windows.Editors.XamMaskedEditor>();
							num = (short)1459093553;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 41:
							num = (short)1570766875;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 42:
						{
							global::Infragistics.Windows.Editors.XamMaskedEditor xamMaskedEditor7;
							if (!xamMaskedEditor7.IsFocused)
							{
								num = (short)793182263;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_295;
						}
						case 43:
							num = (short)1328873490;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 44:
							goto IL_9F9;
						case 45:
							num = (short)1993080889;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 46:
							num = (short)2106982429;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 47:
						{
							global::AcpUI.AcpTableTextBoxDecHex acpTableTextBoxDecHex = acpCommandParameter.Parameter as global::AcpUI.AcpTableTextBoxDecHex;
							global::AcpUI.AcpTableTextBoxBase acpTextBoxMemberDec2 = acpTableTextBoxDecHex.AcpTextBoxMemberDec;
							global::AcpUI.AcpTableTextBoxBase acpTextBoxMemberHex2 = acpTableTextBoxDecHex.AcpTextBoxMemberHex;
							global::Infragistics.Windows.Editors.XamMaskedEditor xamMaskedEditor6 = acpTextBoxMemberDec2.FindVisualChild<global::Infragistics.Windows.Editors.XamMaskedEditor>(acpTextBoxMemberDec2);
							global::Infragistics.Windows.Editors.XamMaskedEditor xamMaskedEditor7 = acpTextBoxMemberHex2.FindVisualChild<global::Infragistics.Windows.Editors.XamMaskedEditor>(acpTextBoxMemberHex2);
							elementUnderMouse2 = global::AcpUI.AcpTextBox.GetElementUnderMouse<global::Infragistics.Windows.Editors.XamMaskedEditor>();
							num = (short)917766196;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 48:
							goto IL_9F9;
						case 49:
						{
							global::Infragistics.Windows.Editors.XamMaskedEditor xamMaskedEditor3;
							if (xamMaskedEditor3 != null)
							{
								num = (short)1586102326;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_9F9;
						}
						case 50:
							num = (short)1027932185;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 51:
							if (acpCommandParameter.Parameter.GetType() == typeof(global::AcpUI.AcpTableTextBox))
							{
								num = (short)1602551810;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_9F9;
						case 52:
						{
							global::Infragistics.Windows.Editors.XamMaskedEditor xamMaskedEditor6;
							if (xamMaskedEditor6 != null)
							{
								num = (short)351731745;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_9F9;
						}
						case 53:
							num = (short)115867670;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 54:
							num = (short)392232969;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 55:
							num = (short)292487188;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 56:
							if (xamMaskedEditor2.IsInEditMode)
							{
								num = (short)1572077600;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_9F9;
						case 57:
							if (!xamMaskedEditor.IsFocused)
							{
								num = (short)515702799;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_231;
						case 58:
							goto IL_9F9;
						}
						goto IL_11A;
						IL_20C:
						elementUnderMouse.IsInEditMode = true;
						num = (short)752484400;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_231:
						xamMaskedEditor.IsInEditMode = true;
						num = (short)947716140;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_7E3:
						goto IL_231;
						IL_295:
						elementUnderMouse2.IsInEditMode = true;
						num = (short)1164378170;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_3E4:
						num = (short)1561657345;
						if (num != 0)
						{
						}
						xamMaskedEditor2.IsInEditMode = true;
						num = (short)881655816;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_6BC:
						xamMaskedEditor4.IsInEditMode = true;
						num = (short)322240516;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_9F9:
						num = (short)1851326465;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_A11:
					break;
					IL_11A:
					acpCommandParameter = (parameter as global::AcpUI.AcpCommandParameter);
					num = (short)1535311877;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_27;
				}
				}
			}
			catch
			{
			}
			num = (short)1825046528;
			short num4 = num;
		}

		// Token: 0x04000231 RID: 561
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.EventHandler a;
	}
}
