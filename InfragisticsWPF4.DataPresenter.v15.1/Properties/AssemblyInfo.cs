using System;
using System.Diagnostics;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using System.Security;
using System.Windows;
using System.Windows.Markup;
using Infragistics.Windows.Themes;
using Infragistics.Windows.Themes.Internal;

[assembly: global::System.Reflection.AssemblyVersion("15.1.20151.2008")]
[assembly: global::System.Runtime.CompilerServices.InternalsVisibleTo("InfragisticsWPF4.DataPresenter.ExcelExporter.v15.1, PublicKey=002400000480000094000000060200000024000052534131000400000100010001afa6285b0af5cdd03aa2b6fdaf33fc4759cf9cd9bcf8b778ae60b9fcf71fc8126b78dbf930519614013b7999297907dd9c00bcc487a14f4c6733fe9adb96c053f005d7148f1666fcb882a0f9ba4307c85694b3322889dab357ad5cefd72ccc45e1b6973bdd2f15b2a300077b8d9de30739200887c5407c8a68c90345cbc4f1")]
[assembly: global::System.Resources.NeutralResourcesLanguage("en-US")]
[assembly: global::System.Resources.SatelliteContractVersion("15.1.0.0")]
[assembly: global::System.Windows.ThemeInfo(global::System.Windows.ResourceDictionaryLocation.SourceAssembly, global::System.Windows.ResourceDictionaryLocation.SourceAssembly)]
[assembly: global::System.Reflection.AssemblyDescription("Multi-Format Data Presentation Component for WPF - Release Version")]
[assembly: global::System.Reflection.AssemblyTitle("InfragisticsWPF4.DataPresenter.v15.1")]
[assembly: global::Infragistics.Windows.Themes.AssemblyThemeGroupingName("DataPresenter")]
[assembly: global::System.Reflection.AssemblyFileVersion("15.1.20151.2008")]
[assembly: global::System.Runtime.CompilerServices.InternalsVisibleTo("InfragisticsWPF4.DataPresenter.WordWriter.v15.1, PublicKey=002400000480000094000000060200000024000052534131000400000100010001afa6285b0af5cdd03aa2b6fdaf33fc4759cf9cd9bcf8b778ae60b9fcf71fc8126b78dbf930519614013b7999297907dd9c00bcc487a14f4c6733fe9adb96c053f005d7148f1666fcb882a0f9ba4307c85694b3322889dab357ad5cefd72ccc45e1b6973bdd2f15b2a300077b8d9de30739200887c5407c8a68c90345cbc4f1")]
[assembly: global::System.Runtime.CompilerServices.InternalsVisibleTo("InfragisticsWPF4.DataPresenter.CalculationAdapter.v15.1, PublicKey=002400000480000094000000060200000024000052534131000400000100010001afa6285b0af5cdd03aa2b6fdaf33fc4759cf9cd9bcf8b778ae60b9fcf71fc8126b78dbf930519614013b7999297907dd9c00bcc487a14f4c6733fe9adb96c053f005d7148f1666fcb882a0f9ba4307c85694b3322889dab357ad5cefd72ccc45e1b6973bdd2f15b2a300077b8d9de30739200887c5407c8a68c90345cbc4f1")]
[assembly: global::System.Runtime.CompilerServices.InternalsVisibleTo("InfragisticsWPF4.DataPresenter.UnitTests.v15.1, PublicKey=002400000480000094000000060200000024000052534131000400000100010001afa6285b0af5cdd03aa2b6fdaf33fc4759cf9cd9bcf8b778ae60b9fcf71fc8126b78dbf930519614013b7999297907dd9c00bcc487a14f4c6733fe9adb96c053f005d7148f1666fcb882a0f9ba4307c85694b3322889dab357ad5cefd72ccc45e1b6973bdd2f15b2a300077b8d9de30739200887c5407c8a68c90345cbc4f1")]
[assembly: global::System.Runtime.CompilerServices.InternalsVisibleTo("InfragisticsWPF4.DataPresenter.WordWriter.UnitTest.v15.1, PublicKey=002400000480000094000000060200000024000052534131000400000100010001afa6285b0af5cdd03aa2b6fdaf33fc4759cf9cd9bcf8b778ae60b9fcf71fc8126b78dbf930519614013b7999297907dd9c00bcc487a14f4c6733fe9adb96c053f005d7148f1666fcb882a0f9ba4307c85694b3322889dab357ad5cefd72ccc45e1b6973bdd2f15b2a300077b8d9de30739200887c5407c8a68c90345cbc4f1")]
[assembly: global::System.Reflection.AssemblyConfiguration("Release")]
[assembly: global::System.Reflection.AssemblyProduct("Infragistics Ultimate")]
[assembly: global::System.Reflection.AssemblyCompany("Infragistics Inc.")]
[assembly: global::System.Reflection.AssemblyCopyright("Copyright � 2011-2015 Infragistics, Inc., All Rights Reserved")]
[assembly: global::System.Reflection.AssemblyTrademark("DataPresenterBase�")]
[assembly: global::System.Runtime.InteropServices.ComVisible(false)]
[assembly: global::System.CLSCompliant(true)]
[assembly: global::System.Security.AllowPartiallyTrustedCallers]
[assembly: global::System.Security.SecurityRules(global::System.Security.SecurityRuleSet.Level1)]
[assembly: global::System.Windows.Markup.XmlnsPrefix("http://schemas.infragistics.com/xaml/wpf", "igWPF")]
[assembly: global::System.Windows.Markup.XmlnsDefinition("http://schemas.infragistics.com/xaml/wpf", "Infragistics.Windows.DataPresenter")]
[assembly: global::System.Windows.Markup.XmlnsDefinition("http://schemas.infragistics.com/xaml/wpf", "Infragistics.Windows.Themes")]
[assembly: global::System.Windows.Markup.XmlnsDefinition("http://infragistics.com/DataPresenter", "Infragistics.Windows.DataPresenter")]
[assembly: global::System.Windows.Markup.XmlnsDefinition("http://infragistics.com/Themes", "Infragistics.Windows.Themes")]
[assembly: global::System.Windows.Markup.XmlnsDefinition("http://schemas.infragistics.com/xaml/wpf", "Infragistics.Windows.DataPresenter.Calculations")]
[assembly: global::System.Windows.Markup.XmlnsDefinition("http://infragistics.com/DataPresenter", "Infragistics.Windows.DataPresenter.Calculations")]
[assembly: global::Infragistics.Windows.Themes.AssemblyResourceSetLoader(typeof(global::Infragistics.Windows.Themes.Internal.DataPresenterAssemblyResourceSetLoader))]
