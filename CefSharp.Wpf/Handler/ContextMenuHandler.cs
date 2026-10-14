using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Threading;
using CefSharp.Handler;

namespace CefSharp.Wpf.Handler
{
	// Token: 0x0200001D RID: 29
	public class ContextMenuHandler : global::CefSharp.Handler.ContextMenuHandler
	{
		// Token: 0x060001B3 RID: 435 RVA: 0x0000687D File Offset: 0x00004A7D
		public ContextMenuHandler(bool addDevtoolsMenuItems = false)
		{
			this.addDevtoolsMenuItems = addDevtoolsMenuItems;
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x0000688C File Offset: 0x00004A8C
		protected override void OnBeforeContextMenu(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::CefSharp.IFrame frame, global::CefSharp.IContextMenuParams parameters, global::CefSharp.IMenuModel model)
		{
			if (this.addDevtoolsMenuItems)
			{
				if (model.Count > 0)
				{
					model.AddSeparator();
				}
				model.AddItem((global::CefSharp.CefMenuCommand)28440, "Show DevTools (Inspect)");
				model.AddItem((global::CefSharp.CefMenuCommand)28441, "Close DevTools");
			}
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x000068CC File Offset: 0x00004ACC
		protected override void OnContextMenuDismissed(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::CefSharp.IFrame frame)
		{
			global::CefSharp.Wpf.ChromiumWebBrowser webBrowser = (global::CefSharp.Wpf.ChromiumWebBrowser)chromiumWebBrowser;
			webBrowser.UiThreadRunAsync(delegate
			{
				webBrowser.ContextMenu = null;
			}, global::System.Windows.Threading.DispatcherPriority.DataBind);
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x00006904 File Offset: 0x00004B04
		protected override bool RunContextMenu(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::CefSharp.IFrame frame, global::CefSharp.IContextMenuParams parameters, global::CefSharp.IMenuModel model, global::CefSharp.IRunContextMenuCallback callback)
		{
			global::CefSharp.Wpf.ChromiumWebBrowser webBrowser = (global::CefSharp.Wpf.ChromiumWebBrowser)chromiumWebBrowser;
			global::System.Collections.Generic.IList<global::CefSharp.Wpf.Handler.ContextMenuHandler.MenuModel> menuItems = global::CefSharp.Wpf.Handler.ContextMenuHandler.GetMenuItems(model);
			global::System.Collections.Generic.List<string> dictionarySuggestions = parameters.DictionarySuggestions;
			int xCoord = parameters.XCoord;
			int yCoord = parameters.YCoord;
			string misspelledWord = parameters.MisspelledWord;
			string selectionText = parameters.SelectionText;
			webBrowser.UiThreadRunAsync(delegate
			{
				global::System.Windows.Controls.ContextMenu menu = new global::System.Windows.Controls.ContextMenu
				{
					IsOpen = true,
					Placement = global::System.Windows.Controls.Primitives.PlacementMode.Mouse
				};
				global::System.Windows.RoutedEventHandler handler = null;
				handler = delegate(object s, global::System.Windows.RoutedEventArgs e)
				{
					menu.Closed -= handler;
					if (!callback.IsDisposed)
					{
						callback.Cancel();
					}
				};
				menu.Closed += handler;
				using (global::System.Collections.Generic.IEnumerator<global::CefSharp.Wpf.Handler.ContextMenuHandler.MenuModel> enumerator = menuItems.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						global::CefSharp.Wpf.Handler.ContextMenuHandler.MenuModel item = enumerator.Current;
						if (item.IsSeperator)
						{
							menu.Items.Add(new global::System.Windows.Controls.Separator());
						}
						else if (item.CommandId != global::CefSharp.CefMenuCommand.NotFound)
						{
							global::System.Windows.Controls.MenuItem menuItem = new global::System.Windows.Controls.MenuItem
							{
								Header = item.Label.Replace("&", "_"),
								IsEnabled = item.IsEnabled,
								IsChecked = item.IsChecked.GetValueOrDefault(),
								IsCheckable = (item.IsChecked != null),
								Command = new global::CefSharp.Wpf.DelegateCommand(delegate()
								{
									this.ExecuteCommand(browser, new global::CefSharp.Wpf.Handler.ContextMenuExecuteModel(item.CommandId, dictionarySuggestions, xCoord, yCoord, selectionText, misspelledWord));
								}, null)
							};
							if (item.SubMenus != null && item.SubMenus.Count > 0)
							{
								using (global::System.Collections.Generic.IEnumerator<global::CefSharp.Wpf.Handler.ContextMenuHandler.MenuModel> enumerator2 = item.SubMenus.GetEnumerator())
								{
									while (enumerator2.MoveNext())
									{
										global::CefSharp.Wpf.Handler.ContextMenuHandler.MenuModel subItem = enumerator2.Current;
										if (subItem.CommandId != global::CefSharp.CefMenuCommand.NotFound)
										{
											if (subItem.IsSeperator)
											{
												menu.Items.Add(new global::System.Windows.Controls.Separator());
											}
											else
											{
												global::System.Windows.Controls.MenuItem newItem = new global::System.Windows.Controls.MenuItem
												{
													Header = subItem.Label.Replace("&", "_"),
													IsEnabled = subItem.IsEnabled,
													IsChecked = subItem.IsChecked.GetValueOrDefault(),
													IsCheckable = (subItem.IsChecked != null),
													Command = new global::CefSharp.Wpf.DelegateCommand(delegate()
													{
														this.ExecuteCommand(browser, new global::CefSharp.Wpf.Handler.ContextMenuExecuteModel(subItem.CommandId, dictionarySuggestions, xCoord, yCoord, selectionText, misspelledWord));
													}, null)
												};
												menuItem.Items.Add(newItem);
											}
										}
									}
								}
							}
							menu.Items.Add(menuItem);
						}
					}
				}
				webBrowser.ContextMenu = menu;
			}, global::System.Windows.Threading.DispatcherPriority.DataBind);
			return true;
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x000069A0 File Offset: 0x00004BA0
		protected virtual void ExecuteCommand(global::CefSharp.IBrowser browser, global::CefSharp.Wpf.Handler.ContextMenuExecuteModel model)
		{
			if (model.MenuCommand >= global::CefSharp.CefMenuCommand.SpellCheckSuggestion0 && model.MenuCommand <= global::CefSharp.CefMenuCommand.SpellCheckSuggestion4)
			{
				int num = model.MenuCommand - global::CefSharp.CefMenuCommand.SpellCheckSuggestion0;
				if (num < model.DictionarySuggestions.Count)
				{
					string word = model.DictionarySuggestions[num];
					browser.ReplaceMisspelling(word);
				}
				return;
			}
			global::CefSharp.CefMenuCommand menuCommand = model.MenuCommand;
			if (menuCommand <= global::CefSharp.CefMenuCommand.ViewSource)
			{
				switch (menuCommand)
				{
				case global::CefSharp.CefMenuCommand.Back:
					browser.GoBack();
					return;
				case global::CefSharp.CefMenuCommand.Forward:
					browser.GoForward();
					return;
				case global::CefSharp.CefMenuCommand.Reload:
					browser.Reload(false);
					return;
				case global::CefSharp.CefMenuCommand.ReloadNoCache:
					browser.Reload(true);
					return;
				case global::CefSharp.CefMenuCommand.StopLoad:
					browser.StopLoad();
					return;
				case (global::CefSharp.CefMenuCommand)105:
				case (global::CefSharp.CefMenuCommand)106:
				case (global::CefSharp.CefMenuCommand)107:
				case (global::CefSharp.CefMenuCommand)108:
				case (global::CefSharp.CefMenuCommand)109:
					break;
				case global::CefSharp.CefMenuCommand.Undo:
					browser.FocusedFrame.Undo();
					return;
				case global::CefSharp.CefMenuCommand.Redo:
					browser.FocusedFrame.Redo();
					return;
				case global::CefSharp.CefMenuCommand.Cut:
					browser.FocusedFrame.Cut();
					return;
				case global::CefSharp.CefMenuCommand.Copy:
					browser.FocusedFrame.Copy();
					return;
				case global::CefSharp.CefMenuCommand.Paste:
					browser.FocusedFrame.Paste();
					return;
				case global::CefSharp.CefMenuCommand.Delete:
					browser.FocusedFrame.Delete();
					return;
				case global::CefSharp.CefMenuCommand.SelectAll:
					browser.FocusedFrame.SelectAll();
					return;
				default:
					switch (menuCommand)
					{
					case global::CefSharp.CefMenuCommand.Find:
						browser.GetHost().Find(model.SelectionText, true, false, false);
						return;
					case global::CefSharp.CefMenuCommand.Print:
						browser.GetHost().Print();
						return;
					case global::CefSharp.CefMenuCommand.ViewSource:
						browser.FocusedFrame.ViewSource();
						return;
					default:
						return;
					}
					break;
				}
			}
			else
			{
				if (menuCommand == global::CefSharp.CefMenuCommand.AddToDictionary)
				{
					browser.GetHost().AddWordToDictionary(model.MisspelledWord);
					return;
				}
				if (menuCommand == (global::CefSharp.CefMenuCommand)28440)
				{
					browser.GetHost().ShowDevTools(null, model.XCoord, model.YCoord);
					return;
				}
				if (menuCommand != (global::CefSharp.CefMenuCommand)28441)
				{
					return;
				}
				browser.GetHost().CloseDevTools();
			}
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x00006B6C File Offset: 0x00004D6C
		private static global::System.Collections.Generic.IList<global::CefSharp.Wpf.Handler.ContextMenuHandler.MenuModel> GetMenuItems(global::CefSharp.IMenuModel model)
		{
			global::System.Collections.Generic.List<global::CefSharp.Wpf.Handler.ContextMenuHandler.MenuModel> list = new global::System.Collections.Generic.List<global::CefSharp.Wpf.Handler.ContextMenuHandler.MenuModel>();
			for (int i = 0; i < model.Count; i++)
			{
				global::CefSharp.MenuItemType typeAt = model.GetTypeAt(i);
				bool? isChecked = null;
				if (typeAt == global::CefSharp.MenuItemType.Check)
				{
					isChecked = new bool?(model.IsCheckedAt(i));
				}
				global::CefSharp.IMenuModel subMenuAt = model.GetSubMenuAt(i);
				global::System.Collections.Generic.IList<global::CefSharp.Wpf.Handler.ContextMenuHandler.MenuModel> subMenus = (subMenuAt == null) ? null : global::CefSharp.Wpf.Handler.ContextMenuHandler.GetMenuItems(subMenuAt);
				global::CefSharp.Wpf.Handler.ContextMenuHandler.MenuModel item = new global::CefSharp.Wpf.Handler.ContextMenuHandler.MenuModel
				{
					Label = model.GetLabelAt(i),
					CommandId = model.GetCommandIdAt(i),
					IsEnabled = model.IsEnabledAt(i),
					Type = typeAt,
					IsSeperator = (typeAt == global::CefSharp.MenuItemType.Separator),
					IsChecked = isChecked,
					SubMenus = subMenus
				};
				list.Add(item);
			}
			return list;
		}

		// Token: 0x04000190 RID: 400
		public const int CefMenuCommandShowDevToolsId = 28440;

		// Token: 0x04000191 RID: 401
		public const int CefMenuCommandCloseDevToolsId = 28441;

		// Token: 0x04000192 RID: 402
		private readonly bool addDevtoolsMenuItems;

		// Token: 0x02000049 RID: 73
		internal class MenuModel
		{
			// Token: 0x17000078 RID: 120
			// (get) Token: 0x0600028D RID: 653 RVA: 0x00009701 File Offset: 0x00007901
			// (set) Token: 0x0600028E RID: 654 RVA: 0x00009709 File Offset: 0x00007909
			internal string Label { get; set; }

			// Token: 0x17000079 RID: 121
			// (get) Token: 0x0600028F RID: 655 RVA: 0x00009712 File Offset: 0x00007912
			// (set) Token: 0x06000290 RID: 656 RVA: 0x0000971A File Offset: 0x0000791A
			internal global::CefSharp.CefMenuCommand CommandId { get; set; }

			// Token: 0x1700007A RID: 122
			// (get) Token: 0x06000291 RID: 657 RVA: 0x00009723 File Offset: 0x00007923
			// (set) Token: 0x06000292 RID: 658 RVA: 0x0000972B File Offset: 0x0000792B
			internal bool IsEnabled { get; set; }

			// Token: 0x1700007B RID: 123
			// (get) Token: 0x06000293 RID: 659 RVA: 0x00009734 File Offset: 0x00007934
			// (set) Token: 0x06000294 RID: 660 RVA: 0x0000973C File Offset: 0x0000793C
			internal bool IsSeperator { get; set; }

			// Token: 0x1700007C RID: 124
			// (get) Token: 0x06000295 RID: 661 RVA: 0x00009745 File Offset: 0x00007945
			// (set) Token: 0x06000296 RID: 662 RVA: 0x0000974D File Offset: 0x0000794D
			internal bool? IsChecked { get; set; }

			// Token: 0x1700007D RID: 125
			// (get) Token: 0x06000297 RID: 663 RVA: 0x00009756 File Offset: 0x00007956
			// (set) Token: 0x06000298 RID: 664 RVA: 0x0000975E File Offset: 0x0000795E
			internal global::CefSharp.MenuItemType Type { get; set; }

			// Token: 0x1700007E RID: 126
			// (get) Token: 0x06000299 RID: 665 RVA: 0x00009767 File Offset: 0x00007967
			// (set) Token: 0x0600029A RID: 666 RVA: 0x0000976F File Offset: 0x0000796F
			internal global::System.Collections.Generic.IList<global::CefSharp.Wpf.Handler.ContextMenuHandler.MenuModel> SubMenus { get; set; }
		}
	}
}
