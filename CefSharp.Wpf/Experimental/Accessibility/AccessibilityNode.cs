using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Automation.Peers;
using CefSharp.Structs;

namespace CefSharp.Wpf.Experimental.Accessibility
{
	// Token: 0x02000029 RID: 41
	public class AccessibilityNode : global::System.Windows.Automation.Peers.FrameworkElementAutomationPeer
	{
		// Token: 0x17000065 RID: 101
		// (get) Token: 0x060001FD RID: 509 RVA: 0x00007772 File Offset: 0x00005972
		// (set) Token: 0x060001FE RID: 510 RVA: 0x0000777A File Offset: 0x0000597A
		public int Id { get; private set; } = -1;

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x060001FF RID: 511 RVA: 0x00007783 File Offset: 0x00005983
		// (set) Token: 0x06000200 RID: 512 RVA: 0x0000778B File Offset: 0x0000598B
		public string Role { get; private set; }

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000201 RID: 513 RVA: 0x00007794 File Offset: 0x00005994
		// (set) Token: 0x06000202 RID: 514 RVA: 0x0000779C File Offset: 0x0000599C
		public string Name { get; private set; }

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000203 RID: 515 RVA: 0x000077A5 File Offset: 0x000059A5
		// (set) Token: 0x06000204 RID: 516 RVA: 0x000077AD File Offset: 0x000059AD
		public string Value { get; private set; }

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000205 RID: 517 RVA: 0x000077B6 File Offset: 0x000059B6
		// (set) Token: 0x06000206 RID: 518 RVA: 0x000077BE File Offset: 0x000059BE
		public string Description { get; private set; }

		// Token: 0x06000207 RID: 519 RVA: 0x000077C7 File Offset: 0x000059C7
		public AccessibilityNode(global::System.Windows.FrameworkElement owner, global::System.Collections.Generic.IDictionary<string, global::CefSharp.IValue> node, global::CefSharp.Wpf.Experimental.Accessibility.AccessibilityTree accessibilityTree) : base(owner)
		{
			this.accessibilityTree = accessibilityTree;
			this.childIds = new global::System.Collections.Generic.HashSet<int>();
			this.Update(node);
		}

		// Token: 0x06000208 RID: 520 RVA: 0x000077F7 File Offset: 0x000059F7
		protected override global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer> GetChildrenCore()
		{
			return this.GetChildAccessibilityNodes().Cast<global::System.Windows.Automation.Peers.AutomationPeer>().ToList<global::System.Windows.Automation.Peers.AutomationPeer>();
		}

		// Token: 0x06000209 RID: 521 RVA: 0x00007809 File Offset: 0x00005A09
		public override object GetPattern(global::System.Windows.Automation.Peers.PatternInterface patternInterface)
		{
			return null;
		}

		// Token: 0x0600020A RID: 522 RVA: 0x0000780C File Offset: 0x00005A0C
		protected override global::System.Windows.Rect GetBoundingRectangleCore()
		{
			global::CefSharp.Structs.Rect rect = this.GetLocation();
			global::System.Windows.Point point = this.CefPointToScreen(rect.X, rect.Y);
			global::System.Windows.Size size = new global::System.Windows.Size((double)rect.Width, (double)rect.Height);
			return new global::System.Windows.Rect(point, size);
		}

		// Token: 0x0600020B RID: 523 RVA: 0x00007853 File Offset: 0x00005A53
		protected override bool IsOffscreenCore()
		{
			return false;
		}

		// Token: 0x0600020C RID: 524 RVA: 0x00007856 File Offset: 0x00005A56
		protected override global::System.Windows.Automation.Peers.AutomationOrientation GetOrientationCore()
		{
			return global::System.Windows.Automation.Peers.AutomationOrientation.None;
		}

		// Token: 0x0600020D RID: 525 RVA: 0x00007859 File Offset: 0x00005A59
		protected override string GetItemTypeCore()
		{
			return this.Role;
		}

		// Token: 0x0600020E RID: 526 RVA: 0x00007861 File Offset: 0x00005A61
		protected override string GetClassNameCore()
		{
			return "CefSharpAccessibilityNode:" + this.Role;
		}

		// Token: 0x0600020F RID: 527 RVA: 0x00007873 File Offset: 0x00005A73
		protected override string GetItemStatusCore()
		{
			return string.Empty;
		}

		// Token: 0x06000210 RID: 528 RVA: 0x0000787A File Offset: 0x00005A7A
		protected override bool IsRequiredForFormCore()
		{
			return false;
		}

		// Token: 0x06000211 RID: 529 RVA: 0x0000787D File Offset: 0x00005A7D
		protected override bool IsKeyboardFocusableCore()
		{
			return true;
		}

		// Token: 0x06000212 RID: 530 RVA: 0x00007880 File Offset: 0x00005A80
		protected override bool HasKeyboardFocusCore()
		{
			return this.HasFocus();
		}

		// Token: 0x06000213 RID: 531 RVA: 0x00007888 File Offset: 0x00005A88
		protected override bool IsEnabledCore()
		{
			return true;
		}

		// Token: 0x06000214 RID: 532 RVA: 0x0000788B File Offset: 0x00005A8B
		protected override bool IsPasswordCore()
		{
			return false;
		}

		// Token: 0x06000215 RID: 533 RVA: 0x00007890 File Offset: 0x00005A90
		protected override string GetAutomationIdCore()
		{
			return this.Id.ToString();
		}

		// Token: 0x06000216 RID: 534 RVA: 0x000078AB File Offset: 0x00005AAB
		protected override string GetNameCore()
		{
			return this.Name;
		}

		// Token: 0x06000217 RID: 535 RVA: 0x000078B3 File Offset: 0x00005AB3
		protected override global::System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore()
		{
			if (global::CefSharp.Wpf.Experimental.Accessibility.AccessibilityNode.ControlTypeMapping.ContainsKey(this.Role))
			{
				return global::CefSharp.Wpf.Experimental.Accessibility.AccessibilityNode.ControlTypeMapping[this.Role];
			}
			return global::System.Windows.Automation.Peers.AutomationControlType.Custom;
		}

		// Token: 0x06000218 RID: 536 RVA: 0x000078DA File Offset: 0x00005ADA
		protected override bool IsContentElementCore()
		{
			return true;
		}

		// Token: 0x06000219 RID: 537 RVA: 0x000078DD File Offset: 0x00005ADD
		protected override bool IsControlElementCore()
		{
			return true;
		}

		// Token: 0x0600021A RID: 538 RVA: 0x000078E0 File Offset: 0x00005AE0
		protected override global::System.Windows.Automation.Peers.AutomationPeer GetLabeledByCore()
		{
			return null;
		}

		// Token: 0x0600021B RID: 539 RVA: 0x000078E3 File Offset: 0x00005AE3
		protected override string GetHelpTextCore()
		{
			return this.Description;
		}

		// Token: 0x0600021C RID: 540 RVA: 0x000078EB File Offset: 0x00005AEB
		protected override string GetAcceleratorKeyCore()
		{
			return string.Empty;
		}

		// Token: 0x0600021D RID: 541 RVA: 0x000078F2 File Offset: 0x00005AF2
		protected override string GetAccessKeyCore()
		{
			return string.Empty;
		}

		// Token: 0x0600021E RID: 542 RVA: 0x000078FC File Offset: 0x00005AFC
		protected override global::System.Windows.Point GetClickablePointCore()
		{
			global::System.Windows.Rect boundingRectangleCore = this.GetBoundingRectangleCore();
			return new global::System.Windows.Point(boundingRectangleCore.X + boundingRectangleCore.Width / 2.0, boundingRectangleCore.Y + boundingRectangleCore.Height / 2.0);
		}

		// Token: 0x0600021F RID: 543 RVA: 0x00007947 File Offset: 0x00005B47
		protected override void SetFocusCore()
		{
		}

		// Token: 0x06000220 RID: 544 RVA: 0x0000794C File Offset: 0x00005B4C
		public void Update(global::System.Collections.Generic.IDictionary<string, global::CefSharp.IValue> node)
		{
			if (node == null || !node.ContainsKey("id"))
			{
				return;
			}
			this.Id = node["id"].GetInt();
			if (node.ContainsKey("role"))
			{
				this.Role = node["role"].GetString();
			}
			if (node.ContainsKey("child_ids"))
			{
				global::System.Collections.Generic.IEnumerable<int> enumerable = from x in node["child_ids"].GetList()
				select x.GetInt();
				if (!this.childIds.SetEquals(enumerable))
				{
					this.childIds = new global::System.Collections.Generic.HashSet<int>(enumerable);
					this.OnChildrenChanged();
				}
			}
			if (node.ContainsKey("location"))
			{
				global::System.Collections.Generic.IDictionary<string, global::CefSharp.IValue> dictionary = node["location"].GetDictionary();
				if (dictionary != null)
				{
					int x2 = (int)dictionary["x"].GetDouble();
					int y = (int)dictionary["y"].GetDouble();
					int width = (int)dictionary["width"].GetDouble();
					int height = (int)dictionary["height"].GetDouble();
					this.location = new global::CefSharp.Structs.Rect(x2, y, width, height);
				}
			}
			if (node.ContainsKey("offset_container_id"))
			{
				this.offsetContainerId = node["offset_container_id"].GetInt();
			}
			if (node.ContainsKey("attributes"))
			{
				global::System.Collections.Generic.IDictionary<string, global::CefSharp.IValue> dictionary2 = node["attributes"].GetDictionary();
				if (dictionary2 != null)
				{
					if (dictionary2.ContainsKey("name"))
					{
						this.Name = dictionary2["name"].GetString();
					}
					if (dictionary2.ContainsKey("value"))
					{
						this.Value = dictionary2["value"].GetString();
					}
					if (dictionary2.ContainsKey("description"))
					{
						this.Description = dictionary2["description"].GetString();
					}
					if (dictionary2.ContainsKey("scrollX") && dictionary2.ContainsKey("scrollY"))
					{
						int @int = dictionary2["scrollX"].GetInt();
						int int2 = dictionary2["scrollY"].GetInt();
						this.scroll = new global::CefSharp.Structs.Point(@int, int2);
					}
				}
			}
		}

		// Token: 0x06000221 RID: 545 RVA: 0x00007B90 File Offset: 0x00005D90
		protected virtual global::CefSharp.Structs.Rect GetLocation()
		{
			global::CefSharp.Wpf.Experimental.Accessibility.AccessibilityNode node = this.accessibilityTree.GetNode(this.offsetContainerId);
			if (node == null)
			{
				return this.location;
			}
			int num = this.location.X;
			int num2 = this.location.Y;
			global::CefSharp.Structs.Rect rect = node.GetLocation();
			num += rect.X - node.scroll.X;
			num2 += rect.Y - node.scroll.Y;
			return new global::CefSharp.Structs.Rect(num, num2, this.location.Width, this.location.Height);
		}

		// Token: 0x06000222 RID: 546 RVA: 0x00007C24 File Offset: 0x00005E24
		public virtual global::System.Collections.Generic.List<global::CefSharp.Wpf.Experimental.Accessibility.AccessibilityNode> GetChildAccessibilityNodes()
		{
			return (from x in this.childIds
			select this.accessibilityTree.GetNode(x) into y
			where y != null
			select y).ToList<global::CefSharp.Wpf.Experimental.Accessibility.AccessibilityNode>();
		}

		// Token: 0x06000223 RID: 547 RVA: 0x00007C71 File Offset: 0x00005E71
		protected virtual bool HasFocus()
		{
			return this.Id == this.accessibilityTree.FocusedNodeId;
		}

		// Token: 0x06000224 RID: 548 RVA: 0x00007C88 File Offset: 0x00005E88
		protected virtual global::System.Windows.Point CefPointToScreen(int x, int y)
		{
			global::CefSharp.Wpf.ChromiumWebBrowser chromiumWebBrowser = (global::CefSharp.Wpf.ChromiumWebBrowser)base.Owner;
			if (chromiumWebBrowser.DpiScaleFactor > 1f)
			{
				int num = (int)((float)x / (chromiumWebBrowser.DpiScaleFactor / 96f));
				int num2 = (int)((float)y / (chromiumWebBrowser.DpiScaleFactor / 96f));
				return base.Owner.PointToScreen(new global::System.Windows.Point((double)num, (double)num2));
			}
			return base.Owner.PointToScreen(new global::System.Windows.Point((double)x, (double)y));
		}

		// Token: 0x06000225 RID: 549 RVA: 0x00007CF9 File Offset: 0x00005EF9
		protected virtual void OnChildrenChanged()
		{
			base.RaiseAutomationEvent(global::System.Windows.Automation.Peers.AutomationEvents.StructureChanged);
		}

		// Token: 0x06000226 RID: 550 RVA: 0x00007D03 File Offset: 0x00005F03
		public virtual void OnFocusChanged()
		{
			base.RaiseAutomationEvent(global::System.Windows.Automation.Peers.AutomationEvents.AutomationFocusChanged);
		}

		// Token: 0x040001AF RID: 431
		private readonly global::CefSharp.Wpf.Experimental.Accessibility.AccessibilityTree accessibilityTree;

		// Token: 0x040001B0 RID: 432
		private global::CefSharp.Structs.Rect location;

		// Token: 0x040001B1 RID: 433
		private global::CefSharp.Structs.Point scroll;

		// Token: 0x040001B2 RID: 434
		private int offsetContainerId = -1;

		// Token: 0x040001B3 RID: 435
		private global::System.Collections.Generic.HashSet<int> childIds;

		// Token: 0x040001B4 RID: 436
		private static readonly global::System.Collections.Generic.Dictionary<string, global::System.Windows.Automation.Peers.AutomationControlType> ControlTypeMapping = new global::System.Collections.Generic.Dictionary<string, global::System.Windows.Automation.Peers.AutomationControlType>
		{
			{
				"alert",
				global::System.Windows.Automation.Peers.AutomationControlType.Text
			},
			{
				"application",
				global::System.Windows.Automation.Peers.AutomationControlType.Pane
			},
			{
				"button",
				global::System.Windows.Automation.Peers.AutomationControlType.Button
			},
			{
				"buttonDropDown",
				global::System.Windows.Automation.Peers.AutomationControlType.ComboBox
			},
			{
				"client",
				global::System.Windows.Automation.Peers.AutomationControlType.Calendar
			},
			{
				"popUpButton",
				global::System.Windows.Automation.Peers.AutomationControlType.Button
			},
			{
				"checkBox",
				global::System.Windows.Automation.Peers.AutomationControlType.CheckBox
			},
			{
				"comboBox",
				global::System.Windows.Automation.Peers.AutomationControlType.ComboBox
			},
			{
				"dialog",
				global::System.Windows.Automation.Peers.AutomationControlType.Pane
			},
			{
				"genericContainer",
				global::System.Windows.Automation.Peers.AutomationControlType.Group
			},
			{
				"group",
				global::System.Windows.Automation.Peers.AutomationControlType.Group
			},
			{
				"image",
				global::System.Windows.Automation.Peers.AutomationControlType.Image
			},
			{
				"inlineTextBox",
				global::System.Windows.Automation.Peers.AutomationControlType.Text
			},
			{
				"link",
				global::System.Windows.Automation.Peers.AutomationControlType.Hyperlink
			},
			{
				"locationBar",
				global::System.Windows.Automation.Peers.AutomationControlType.Group
			},
			{
				"menuBar",
				global::System.Windows.Automation.Peers.AutomationControlType.MenuBar
			},
			{
				"menuItem",
				global::System.Windows.Automation.Peers.AutomationControlType.MenuItem
			},
			{
				"menuListPopup",
				global::System.Windows.Automation.Peers.AutomationControlType.Menu
			},
			{
				"pane",
				global::System.Windows.Automation.Peers.AutomationControlType.Pane
			},
			{
				"progressIndicator",
				global::System.Windows.Automation.Peers.AutomationControlType.ProgressBar
			},
			{
				"radioButton",
				global::System.Windows.Automation.Peers.AutomationControlType.RadioButton
			},
			{
				"rootWebArea",
				global::System.Windows.Automation.Peers.AutomationControlType.Group
			},
			{
				"scrollBar",
				global::System.Windows.Automation.Peers.AutomationControlType.ScrollBar
			},
			{
				"slider",
				global::System.Windows.Automation.Peers.AutomationControlType.Slider
			},
			{
				"splitter",
				global::System.Windows.Automation.Peers.AutomationControlType.Separator
			},
			{
				"staticText",
				global::System.Windows.Automation.Peers.AutomationControlType.Text
			},
			{
				"tab",
				global::System.Windows.Automation.Peers.AutomationControlType.TabItem
			},
			{
				"tabList",
				global::System.Windows.Automation.Peers.AutomationControlType.Tab
			},
			{
				"textField",
				global::System.Windows.Automation.Peers.AutomationControlType.Edit
			},
			{
				"titleBar",
				global::System.Windows.Automation.Peers.AutomationControlType.Pane
			},
			{
				"toolbar",
				global::System.Windows.Automation.Peers.AutomationControlType.ToolBar
			},
			{
				"tree",
				global::System.Windows.Automation.Peers.AutomationControlType.Tree
			},
			{
				"treeItem",
				global::System.Windows.Automation.Peers.AutomationControlType.TreeItem
			},
			{
				"webView",
				global::System.Windows.Automation.Peers.AutomationControlType.Group
			},
			{
				"window",
				global::System.Windows.Automation.Peers.AutomationControlType.Window
			}
		};
	}
}
