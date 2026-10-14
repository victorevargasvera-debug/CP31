using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Automation.Text;
using Infragistics.Windows.Editors;

namespace Infragistics.Windows.Automation.Peers.Editors
{
	// Token: 0x0200000E RID: 14
	public class XamMaskedEditorAutomationPeer : global::Infragistics.Windows.Automation.Peers.Editors.ValueEditorAutomationPeer, global::System.Windows.Automation.Provider.ITextProvider, global::System.Windows.Automation.Provider.IExpandCollapseProvider
	{
		// Token: 0x06000058 RID: 88 RVA: 0x00002AD6 File Offset: 0x00000CD6
		public XamMaskedEditorAutomationPeer(global::Infragistics.Windows.Editors.XamMaskedEditor owner) : base(owner)
		{
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00002ADF File Offset: 0x00000CDF
		protected override global::System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore()
		{
			return global::System.Windows.Automation.Peers.AutomationControlType.Edit;
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00002AE2 File Offset: 0x00000CE2
		protected override string GetClassNameCore()
		{
			return "XamMaskedEditor";
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00002AE9 File Offset: 0x00000CE9
		public override object GetPattern(global::System.Windows.Automation.Peers.PatternInterface patternInterface)
		{
			if (patternInterface == global::System.Windows.Automation.Peers.PatternInterface.Text)
			{
				return this;
			}
			if (patternInterface == global::System.Windows.Automation.Peers.PatternInterface.ExpandCollapse)
			{
				return this;
			}
			return base.GetPattern(patternInterface);
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600005C RID: 92 RVA: 0x00002AFF File Offset: 0x00000CFF
		private global::Infragistics.Windows.Editors.XamMaskedEditor Editor
		{
			get
			{
				return (global::Infragistics.Windows.Editors.XamMaskedEditor)base.Owner;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600005D RID: 93 RVA: 0x00002B0C File Offset: 0x00000D0C
		private int LastCharacterIndex
		{
			get
			{
				return global::Infragistics.Windows.Editors.XamMaskedEditor.GetTotalNumberOfDisplayChars(this.Editor.Sections);
			}
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00002B20 File Offset: 0x00000D20
		internal global::System.Windows.DependencyObject ElementFromProvider(global::System.Windows.Automation.Provider.IRawElementProviderSimple provider)
		{
			global::System.Windows.DependencyObject result = null;
			global::System.Windows.Automation.Peers.AutomationPeer automationPeer = base.PeerFromProvider(provider);
			if (automationPeer is global::System.Windows.Automation.Peers.UIElementAutomationPeer)
			{
				return ((global::System.Windows.Automation.Peers.UIElementAutomationPeer)automationPeer).Owner;
			}
			if (automationPeer is global::System.Windows.Automation.Peers.ContentElementAutomationPeer)
			{
				result = ((global::System.Windows.Automation.Peers.ContentElementAutomationPeer)automationPeer).Owner;
			}
			return result;
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00002B60 File Offset: 0x00000D60
		internal void RaiseExpandCollapseChanged()
		{
			if (this._lastReturnedExpandState != null && global::System.Windows.Automation.Peers.AutomationPeer.ListenerExists(global::System.Windows.Automation.Peers.AutomationEvents.PropertyChanged))
			{
				global::System.Windows.Automation.ExpandCollapseState expandCollapseState = ((global::System.Windows.Automation.Provider.IExpandCollapseProvider)this).ExpandCollapseState;
				if (expandCollapseState != this._lastReturnedExpandState.Value)
				{
					base.RaisePropertyChangedEvent(global::System.Windows.Automation.ExpandCollapsePatternIdentifiers.ExpandCollapseStateProperty, this._lastReturnedExpandState.Value, expandCollapseState);
				}
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000060 RID: 96 RVA: 0x00002BB9 File Offset: 0x00000DB9
		global::System.Windows.Automation.Provider.ITextRangeProvider global::System.Windows.Automation.Provider.ITextProvider.DocumentRange
		{
			get
			{
				return new global::Infragistics.Windows.Automation.Peers.Editors.XamMaskedEditorAutomationPeer.MaskedEditTextRange(this, 0, this.LastCharacterIndex);
			}
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00002BC8 File Offset: 0x00000DC8
		global::System.Windows.Automation.Provider.ITextRangeProvider[] global::System.Windows.Automation.Provider.ITextProvider.GetSelection()
		{
			return new global::System.Windows.Automation.Provider.ITextRangeProvider[]
			{
				new global::Infragistics.Windows.Automation.Peers.Editors.XamMaskedEditorAutomationPeer.MaskedEditTextRange(this, this.Editor.SelectionStart, this.Editor.SelectionStart + this.Editor.SelectionLength)
			};
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00002C08 File Offset: 0x00000E08
		global::System.Windows.Automation.Provider.ITextRangeProvider[] global::System.Windows.Automation.Provider.ITextProvider.GetVisibleRanges()
		{
			global::Infragistics.Windows.Editors.EditInfo editInfo = this.Editor.EditInfo;
			if (editInfo == null)
			{
				return new global::System.Windows.Automation.Provider.ITextRangeProvider[0];
			}
			int nearestDisplayChar = editInfo.GetNearestDisplayChar(new global::System.Windows.Point(0.0, 0.0), true);
			int nearestDisplayChar2 = editInfo.GetNearestDisplayChar(new global::System.Windows.Point(this.Editor.ActualWidth, this.Editor.ActualHeight), true);
			return new global::System.Windows.Automation.Provider.ITextRangeProvider[]
			{
				new global::Infragistics.Windows.Automation.Peers.Editors.XamMaskedEditorAutomationPeer.MaskedEditTextRange(this, nearestDisplayChar, nearestDisplayChar2)
			};
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00002C80 File Offset: 0x00000E80
		global::System.Windows.Automation.Provider.ITextRangeProvider global::System.Windows.Automation.Provider.ITextProvider.RangeFromChild(global::System.Windows.Automation.Provider.IRawElementProviderSimple childElement)
		{
			if (childElement == null)
			{
				throw new global::System.ArgumentNullException("childElement");
			}
			global::System.Windows.DependencyObject descendant = this.ElementFromProvider(childElement);
			if (!((global::Infragistics.Windows.Editors.XamMaskedEditor)base.Owner).IsAncestorOf(descendant))
			{
				throw new global::System.InvalidOperationException(global::Infragistics.Windows.Editors.ValueEditor.GetString("LE_InvalidOperationException_2"));
			}
			return new global::Infragistics.Windows.Automation.Peers.Editors.XamMaskedEditorAutomationPeer.MaskedEditTextRange(this, 0, this.LastCharacterIndex);
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00002CD4 File Offset: 0x00000ED4
		global::System.Windows.Automation.Provider.ITextRangeProvider global::System.Windows.Automation.Provider.ITextProvider.RangeFromPoint(global::System.Windows.Point screenLocation)
		{
			global::Infragistics.Windows.Editors.EditInfo editInfo = this.Editor.EditInfo;
			if (editInfo == null)
			{
				return null;
			}
			global::System.Windows.Point point = global::Infragistics.Windows.Utilities.PointFromScreenSafe(this.Editor, screenLocation);
			int nearestDisplayChar = editInfo.GetNearestDisplayChar(point, true);
			return new global::Infragistics.Windows.Automation.Peers.Editors.XamMaskedEditorAutomationPeer.MaskedEditTextRange(this, nearestDisplayChar, nearestDisplayChar);
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000065 RID: 101 RVA: 0x00002D10 File Offset: 0x00000F10
		global::System.Windows.Automation.SupportedTextSelection global::System.Windows.Automation.Provider.ITextProvider.SupportedTextSelection
		{
			get
			{
				return global::System.Windows.Automation.SupportedTextSelection.Single;
			}
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00002D13 File Offset: 0x00000F13
		private void VerifyCanExpandCollapse()
		{
			if (!base.IsEnabled())
			{
				throw new global::System.Windows.Automation.ElementNotEnabledException();
			}
			if (!this.Editor.HasDropDown)
			{
				throw new global::System.InvalidOperationException();
			}
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00002D36 File Offset: 0x00000F36
		void global::System.Windows.Automation.Provider.IExpandCollapseProvider.Collapse()
		{
			this.VerifyCanExpandCollapse();
			if (this.Editor.HasOpenDropDown)
			{
				this.Editor.ToggleDropDown();
			}
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00002D56 File Offset: 0x00000F56
		void global::System.Windows.Automation.Provider.IExpandCollapseProvider.Expand()
		{
			this.VerifyCanExpandCollapse();
			if (!this.Editor.HasDropDown)
			{
				throw new global::System.InvalidOperationException();
			}
			if (!this.Editor.HasOpenDropDown)
			{
				this.Editor.ToggleDropDown();
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000069 RID: 105 RVA: 0x00002D8C File Offset: 0x00000F8C
		global::System.Windows.Automation.ExpandCollapseState global::System.Windows.Automation.Provider.IExpandCollapseProvider.ExpandCollapseState
		{
			get
			{
				if (!this.Editor.HasDropDown)
				{
					this._lastReturnedExpandState = new global::System.Windows.Automation.ExpandCollapseState?(global::System.Windows.Automation.ExpandCollapseState.LeafNode);
				}
				else if (this.Editor.HasOpenDropDown)
				{
					this._lastReturnedExpandState = new global::System.Windows.Automation.ExpandCollapseState?(global::System.Windows.Automation.ExpandCollapseState.Expanded);
				}
				else
				{
					this._lastReturnedExpandState = new global::System.Windows.Automation.ExpandCollapseState?(global::System.Windows.Automation.ExpandCollapseState.Collapsed);
				}
				return this._lastReturnedExpandState.Value;
			}
		}

		// Token: 0x0400000A RID: 10
		private global::System.Windows.Automation.ExpandCollapseState? _lastReturnedExpandState;

		// Token: 0x0200000F RID: 15
		internal class MaskedEditTextRange : global::System.Windows.Automation.Provider.ITextRangeProvider
		{
			// Token: 0x0600006A RID: 106 RVA: 0x00002DE6 File Offset: 0x00000FE6
			internal MaskedEditTextRange(global::Infragistics.Windows.Automation.Peers.Editors.XamMaskedEditorAutomationPeer peer, int start, int end)
			{
				this._peer = peer;
				this._start = start;
				this._end = end;
			}

			// Token: 0x17000013 RID: 19
			// (get) Token: 0x0600006B RID: 107 RVA: 0x00002E03 File Offset: 0x00001003
			private int EndingDisplayCharacterIndex
			{
				get
				{
					return global::System.Math.Max(this._start, this._end - 1);
				}
			}

			// Token: 0x0600006C RID: 108 RVA: 0x00002E18 File Offset: 0x00001018
			private void VerifyEndPoint(global::System.Windows.Automation.Text.TextPatternRangeEndpoint endPoint)
			{
				if (endPoint == global::System.Windows.Automation.Text.TextPatternRangeEndpoint.End)
				{
					this._end = global::System.Math.Max(this._end, this._start);
					return;
				}
				this._start = global::System.Math.Min(this._end, this._start);
			}

			// Token: 0x0600006D RID: 109 RVA: 0x00002E4D File Offset: 0x0000104D
			private static global::System.Windows.Automation.Text.TextPatternRangeEndpoint GetOtherEndPoint(global::System.Windows.Automation.Text.TextPatternRangeEndpoint endPoint)
			{
				if (endPoint != global::System.Windows.Automation.Text.TextPatternRangeEndpoint.Start)
				{
					return global::System.Windows.Automation.Text.TextPatternRangeEndpoint.Start;
				}
				return global::System.Windows.Automation.Text.TextPatternRangeEndpoint.End;
			}

			// Token: 0x0600006E RID: 110 RVA: 0x00002E55 File Offset: 0x00001055
			void global::System.Windows.Automation.Provider.ITextRangeProvider.AddToSelection()
			{
				throw new global::System.InvalidOperationException();
			}

			// Token: 0x0600006F RID: 111 RVA: 0x00002E5C File Offset: 0x0000105C
			global::System.Windows.Automation.Provider.ITextRangeProvider global::System.Windows.Automation.Provider.ITextRangeProvider.Clone()
			{
				return new global::Infragistics.Windows.Automation.Peers.Editors.XamMaskedEditorAutomationPeer.MaskedEditTextRange(this._peer, this._start, this._end);
			}

			// Token: 0x06000070 RID: 112 RVA: 0x00002E78 File Offset: 0x00001078
			bool global::System.Windows.Automation.Provider.ITextRangeProvider.Compare(global::System.Windows.Automation.Provider.ITextRangeProvider range)
			{
				if (range == null)
				{
					throw new global::System.ArgumentNullException("range");
				}
				global::Infragistics.Windows.Automation.Peers.Editors.XamMaskedEditorAutomationPeer.MaskedEditTextRange maskedEditTextRange = range as global::Infragistics.Windows.Automation.Peers.Editors.XamMaskedEditorAutomationPeer.MaskedEditTextRange;
				if (maskedEditTextRange == null)
				{
					throw new global::System.ArgumentException(global::Infragistics.Windows.Editors.ValueEditor.GetString("LE_ArgumentException_1"), "range");
				}
				return maskedEditTextRange._peer == this._peer && maskedEditTextRange._start == this._start && maskedEditTextRange._end == this._end;
			}

			// Token: 0x06000071 RID: 113 RVA: 0x00002EE0 File Offset: 0x000010E0
			int global::System.Windows.Automation.Provider.ITextRangeProvider.CompareEndpoints(global::System.Windows.Automation.Text.TextPatternRangeEndpoint endpoint, global::System.Windows.Automation.Provider.ITextRangeProvider targetRange, global::System.Windows.Automation.Text.TextPatternRangeEndpoint targetEndpoint)
			{
				if (targetRange == null)
				{
					throw new global::System.ArgumentNullException("targetRange");
				}
				global::Infragistics.Windows.Automation.Peers.Editors.XamMaskedEditorAutomationPeer.MaskedEditTextRange maskedEditTextRange = targetRange as global::Infragistics.Windows.Automation.Peers.Editors.XamMaskedEditorAutomationPeer.MaskedEditTextRange;
				if (maskedEditTextRange == null)
				{
					throw new global::System.ArgumentException(global::Infragistics.Windows.Editors.ValueEditor.GetString("LE_ArgumentException_1"), "targetRange");
				}
				int value = (targetEndpoint == global::System.Windows.Automation.Text.TextPatternRangeEndpoint.Start) ? maskedEditTextRange._start : maskedEditTextRange._end;
				return ((endpoint == global::System.Windows.Automation.Text.TextPatternRangeEndpoint.Start) ? this._start : this._end).CompareTo(value);
			}

			// Token: 0x06000072 RID: 114 RVA: 0x00002F48 File Offset: 0x00001148
			void global::System.Windows.Automation.Provider.ITextRangeProvider.ExpandToEnclosingUnit(global::System.Windows.Automation.Text.TextUnit unit)
			{
				if (unit == global::System.Windows.Automation.Text.TextUnit.Character)
				{
					if (this._start == this._end && this._start < this._peer.LastCharacterIndex)
					{
						this._end++;
						return;
					}
				}
				else if (unit == global::System.Windows.Automation.Text.TextUnit.Word || unit == global::System.Windows.Automation.Text.TextUnit.Format)
				{
					global::Infragistics.Windows.Editors.SectionsCollection sections = this._peer.Editor.Sections;
					global::Infragistics.Windows.Editors.SectionBase sectionContainingPosition = global::Infragistics.Windows.Editors.EditInfo.GetSectionContainingPosition(this._start, sections);
					global::Infragistics.Windows.Editors.SectionBase sectionBase = global::Infragistics.Windows.Editors.EditInfo.GetSectionContainingPosition(this.EndingDisplayCharacterIndex, sections) ?? global::Infragistics.Windows.Editors.EditInfo.GetLastSection(sections);
					if (sectionContainingPosition == null)
					{
						this._start = (this._end = this._peer.LastCharacterIndex);
						return;
					}
					this._start = sectionContainingPosition.FirstDisplayChar.OverallIndexInEdit;
					this._end = sectionBase.LastDisplayChar.OverallIndexInEdit + 1;
					return;
				}
				else
				{
					this._start = 0;
					this._end = this._peer.LastCharacterIndex;
				}
			}

			// Token: 0x06000073 RID: 115 RVA: 0x00003026 File Offset: 0x00001226
			global::System.Windows.Automation.Provider.ITextRangeProvider global::System.Windows.Automation.Provider.ITextRangeProvider.FindAttribute(int attribute, object value, bool backward)
			{
				return null;
			}

			// Token: 0x06000074 RID: 116 RVA: 0x0000302C File Offset: 0x0000122C
			global::System.Windows.Automation.Provider.ITextRangeProvider global::System.Windows.Automation.Provider.ITextRangeProvider.FindText(string text, bool backward, bool ignoreCase)
			{
				string text2 = ((global::System.Windows.Automation.Provider.ITextRangeProvider)this).GetText(-1) ?? string.Empty;
				int num;
				if (backward)
				{
					num = text2.LastIndexOf(text);
				}
				else
				{
					num = text2.IndexOf(text);
				}
				if (num >= 0)
				{
					return new global::Infragistics.Windows.Automation.Peers.Editors.XamMaskedEditorAutomationPeer.MaskedEditTextRange(this._peer, num + this._start, num + this._start + text.Length);
				}
				return null;
			}

			// Token: 0x06000075 RID: 117 RVA: 0x00003087 File Offset: 0x00001287
			object global::System.Windows.Automation.Provider.ITextRangeProvider.GetAttributeValue(int attribute)
			{
				return null;
			}

			// Token: 0x06000076 RID: 118 RVA: 0x0000308C File Offset: 0x0000128C
			double[] global::System.Windows.Automation.Provider.ITextRangeProvider.GetBoundingRectangles()
			{
				global::System.Windows.Automation.Provider.ITextRangeProvider[] visibleRanges = ((global::System.Windows.Automation.Provider.ITextProvider)this._peer).GetVisibleRanges();
				double[] result = new double[0];
				if (visibleRanges != null && visibleRanges.Length > 0)
				{
					global::Infragistics.Windows.Automation.Peers.Editors.XamMaskedEditorAutomationPeer.MaskedEditTextRange maskedEditTextRange = visibleRanges[0] as global::Infragistics.Windows.Automation.Peers.Editors.XamMaskedEditorAutomationPeer.MaskedEditTextRange;
					if (maskedEditTextRange != null)
					{
						int num = global::System.Math.Max(this._start, maskedEditTextRange._start);
						int num2 = global::System.Math.Min(this._end, maskedEditTextRange._end);
						if (num >= 0)
						{
							int lastCharacterIndex = this._peer.LastCharacterIndex;
							int num3 = global::System.Math.Min(num, lastCharacterIndex - 1);
							int num4 = global::System.Math.Max(num3, global::System.Math.Min(num2 - 1, lastCharacterIndex - 1));
							global::Infragistics.Windows.Editors.XamMaskedEditor editor = this._peer.Editor;
							global::Infragistics.Windows.Editors.EditInfo editInfo = editor.EditInfo;
							global::Infragistics.Windows.Editors.DisplayCharBase displayCharAtPosition = editInfo.GetDisplayCharAtPosition(num3);
							global::System.Windows.Rect displayCharLocation = editor.GetDisplayCharLocation(displayCharAtPosition);
							if (num4 != num3)
							{
								displayCharAtPosition = editInfo.GetDisplayCharAtPosition(num4);
								global::System.Windows.Rect displayCharLocation2 = editor.GetDisplayCharLocation(displayCharAtPosition);
								displayCharLocation.Union(displayCharLocation2);
							}
							else if (num == num2)
							{
								if (num2 == this._peer.LastCharacterIndex)
								{
									displayCharLocation.X = displayCharLocation.Right;
								}
								displayCharLocation.Width = 0.0;
							}
							result = new double[]
							{
								displayCharLocation.X,
								displayCharLocation.Top,
								displayCharLocation.Width,
								displayCharLocation.Height
							};
						}
					}
				}
				return result;
			}

			// Token: 0x06000077 RID: 119 RVA: 0x000031E2 File Offset: 0x000013E2
			global::System.Windows.Automation.Provider.IRawElementProviderSimple[] global::System.Windows.Automation.Provider.ITextRangeProvider.GetChildren()
			{
				return null;
			}

			// Token: 0x06000078 RID: 120 RVA: 0x000031E5 File Offset: 0x000013E5
			global::System.Windows.Automation.Provider.IRawElementProviderSimple global::System.Windows.Automation.Provider.ITextRangeProvider.GetEnclosingElement()
			{
				return this._peer.ProviderFromPeer(this._peer);
			}

			// Token: 0x06000079 RID: 121 RVA: 0x000031F8 File Offset: 0x000013F8
			string global::System.Windows.Automation.Provider.ITextRangeProvider.GetText(int maxLength)
			{
				if (maxLength < -2)
				{
					throw new global::System.ArgumentException();
				}
				int num = this._end - this._start;
				int length = (maxLength < 0) ? num : global::System.Math.Min(num, maxLength);
				global::Infragistics.Windows.Editors.MaskInfo maskInfo = this._peer.Editor.MaskInfo;
				return global::Infragistics.Windows.Editors.EditInfo.GetText(maskInfo.DisplayMode, this._start, length, maskInfo.Sections);
			}

			// Token: 0x0600007A RID: 122 RVA: 0x00003258 File Offset: 0x00001458
			int global::System.Windows.Automation.Provider.ITextRangeProvider.Move(global::System.Windows.Automation.Text.TextUnit unit, int count)
			{
				if (count == 0)
				{
					return 0;
				}
				int num = 0;
				bool flag = count < 0;
				if (unit == global::System.Windows.Automation.Text.TextUnit.Character)
				{
					if (this._end != this._start)
					{
						if (flag)
						{
							this._end = this._start;
							count++;
						}
						else
						{
							this._start = this._end;
							count--;
						}
						num++;
					}
					if (count != 0)
					{
						int num2 = ((global::System.Windows.Automation.Provider.ITextRangeProvider)this).MoveEndpointByUnit(flag ? global::System.Windows.Automation.Text.TextPatternRangeEndpoint.Start : global::System.Windows.Automation.Text.TextPatternRangeEndpoint.End, unit, count);
						if (num2 >= 0)
						{
							num += num2;
						}
						else
						{
							num = -1;
						}
						if (flag)
						{
							this._end = this._start;
						}
						else
						{
							this._start = this._end;
						}
					}
				}
				else if (unit == global::System.Windows.Automation.Text.TextUnit.Word || unit == global::System.Windows.Automation.Text.TextUnit.Format)
				{
					num = ((global::System.Windows.Automation.Provider.ITextRangeProvider)this).MoveEndpointByUnit(flag ? global::System.Windows.Automation.Text.TextPatternRangeEndpoint.Start : global::System.Windows.Automation.Text.TextPatternRangeEndpoint.End, unit, count);
					if (num == 0 && this._end != this._start)
					{
						num = -1;
					}
				}
				else if (flag)
				{
					if (this._start != 0)
					{
						this._start = 0;
						num = -1;
					}
				}
				else if (this._end != this._peer.LastCharacterIndex)
				{
					this._end = this._peer.LastCharacterIndex;
					num = -1;
				}
				if (num != 0)
				{
					if (flag)
					{
						this._end = this._start;
					}
					else
					{
						this._start = this._end;
					}
					if (num > 0 && (this._start == 0 || this._end == this._peer.LastCharacterIndex))
					{
						num = -1;
					}
				}
				return num;
			}

			// Token: 0x0600007B RID: 123 RVA: 0x0000339C File Offset: 0x0000159C
			void global::System.Windows.Automation.Provider.ITextRangeProvider.MoveEndpointByRange(global::System.Windows.Automation.Text.TextPatternRangeEndpoint endpoint, global::System.Windows.Automation.Provider.ITextRangeProvider targetRange, global::System.Windows.Automation.Text.TextPatternRangeEndpoint targetEndpoint)
			{
				if (targetRange == null)
				{
					throw new global::System.ArgumentNullException("targetRange");
				}
				global::Infragistics.Windows.Automation.Peers.Editors.XamMaskedEditorAutomationPeer.MaskedEditTextRange maskedEditTextRange = targetRange as global::Infragistics.Windows.Automation.Peers.Editors.XamMaskedEditorAutomationPeer.MaskedEditTextRange;
				if (maskedEditTextRange == null)
				{
					throw new global::System.ArgumentException(global::Infragistics.Windows.Editors.ValueEditor.GetString("LE_ArgumentException_1"), "range");
				}
				int num = (targetEndpoint == global::System.Windows.Automation.Text.TextPatternRangeEndpoint.Start) ? maskedEditTextRange._start : maskedEditTextRange._end;
				if (endpoint == global::System.Windows.Automation.Text.TextPatternRangeEndpoint.Start)
				{
					this._start = num;
				}
				else
				{
					this._end = num;
				}
				this.VerifyEndPoint(global::Infragistics.Windows.Automation.Peers.Editors.XamMaskedEditorAutomationPeer.MaskedEditTextRange.GetOtherEndPoint(endpoint));
			}

			// Token: 0x0600007C RID: 124 RVA: 0x00003408 File Offset: 0x00001608
			int global::System.Windows.Automation.Provider.ITextRangeProvider.MoveEndpointByUnit(global::System.Windows.Automation.Text.TextPatternRangeEndpoint endpoint, global::System.Windows.Automation.Text.TextUnit unit, int count)
			{
				if (count == 0)
				{
					return 0;
				}
				if (count < 0 && endpoint == global::System.Windows.Automation.Text.TextPatternRangeEndpoint.Start && this._start == 0)
				{
					return 0;
				}
				if (count > 0 && endpoint == global::System.Windows.Automation.Text.TextPatternRangeEndpoint.End && this._end == this._peer.LastCharacterIndex)
				{
					return 0;
				}
				bool flag = count < 0;
				bool flag2 = endpoint == global::System.Windows.Automation.Text.TextPatternRangeEndpoint.Start;
				int num = 0;
				if (unit == global::System.Windows.Automation.Text.TextUnit.Character)
				{
					int num2 = flag2 ? this._start : this._end;
					int num3 = num2 + count;
					num3 = global::System.Math.Max(0, global::System.Math.Min(this._peer.LastCharacterIndex, num3));
					num += global::System.Math.Abs(num3 - num2);
					if (flag2)
					{
						this._start = num3;
					}
					else
					{
						this._end = num3;
					}
				}
				else if (unit == global::System.Windows.Automation.Text.TextUnit.Word || unit == global::System.Windows.Automation.Text.TextUnit.Format)
				{
					global::Infragistics.Windows.Editors.MaskInfo maskInfo = this._peer.Editor.MaskInfo;
					int num4 = flag ? this._start : this._end;
					int num5 = num4;
					global::Infragistics.Windows.Editors.SectionBase sectionContainingPosition = global::Infragistics.Windows.Editors.EditInfo.GetSectionContainingPosition(num4, maskInfo.Sections);
					if (sectionContainingPosition != null)
					{
						if (flag && num4 != sectionContainingPosition.FirstDisplayChar.OverallIndexInEdit)
						{
							num5 = sectionContainingPosition.FirstDisplayChar.OverallIndexInEdit;
							num++;
							count++;
						}
						else if (!flag && num4 != sectionContainingPosition.LastDisplayChar.OverallIndexInEdit + 1)
						{
							num5 = sectionContainingPosition.LastDisplayChar.OverallIndexInEdit + 1;
							num++;
							count--;
						}
					}
					if (count != 0)
					{
						int num6 = (sectionContainingPosition == null) ? maskInfo.Sections.Count : sectionContainingPosition.Index;
						int num7 = num6 + count;
						num7 = global::System.Math.Max(0, global::System.Math.Min(maskInfo.Sections.Count, num7));
						num += global::System.Math.Abs(num7 - num6);
						if (num7 == maskInfo.Sections.Count)
						{
							num5 = this._peer.LastCharacterIndex;
						}
						else if (flag)
						{
							num5 = maskInfo.Sections[num7].FirstDisplayChar.OverallIndexInEdit;
						}
						else
						{
							num5 = maskInfo.Sections[num7].LastDisplayChar.OverallIndexInEdit + 1;
						}
					}
					if (flag)
					{
						this._start = num5;
					}
					else
					{
						this._end = num5;
					}
				}
				else
				{
					if (flag2)
					{
						this._start = (flag ? 0 : this._peer.LastCharacterIndex);
					}
					else
					{
						this._end = (flag ? 0 : this._peer.LastCharacterIndex);
					}
					num = -1;
				}
				this.VerifyEndPoint(flag2 ? global::System.Windows.Automation.Text.TextPatternRangeEndpoint.End : global::System.Windows.Automation.Text.TextPatternRangeEndpoint.Start);
				if (num > 0 && (this._start == 0 || this._end == this._peer.LastCharacterIndex))
				{
					num = -1;
				}
				return num;
			}

			// Token: 0x0600007D RID: 125 RVA: 0x00003677 File Offset: 0x00001877
			void global::System.Windows.Automation.Provider.ITextRangeProvider.RemoveFromSelection()
			{
				throw new global::System.InvalidOperationException();
			}

			// Token: 0x0600007E RID: 126 RVA: 0x00003680 File Offset: 0x00001880
			void global::System.Windows.Automation.Provider.ITextRangeProvider.ScrollIntoView(bool alignToTop)
			{
				global::Infragistics.Windows.Editors.EditInfo editInfo = this._peer.Editor.EditInfo;
				if (editInfo == null)
				{
					return;
				}
				editInfo.ScrollDisplayCharIntoView(this.EndingDisplayCharacterIndex);
				editInfo.ScrollDisplayCharIntoView(this._start);
			}

			// Token: 0x0600007F RID: 127 RVA: 0x000036BA File Offset: 0x000018BA
			void global::System.Windows.Automation.Provider.ITextRangeProvider.Select()
			{
				this._peer.Editor.SelectionStart = this._start;
				this._peer.Editor.SelectionLength = this._end - this._start;
			}

			// Token: 0x0400000B RID: 11
			private global::Infragistics.Windows.Automation.Peers.Editors.XamMaskedEditorAutomationPeer _peer;

			// Token: 0x0400000C RID: 12
			private int _start;

			// Token: 0x0400000D RID: 13
			private int _end;
		}
	}
}
