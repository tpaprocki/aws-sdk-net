﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 12.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace ServiceClientGenerator.Generators.ProjectFiles
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using ServiceClientGenerator;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\dev\net\v3\XamarinClean\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\IOSProjectFile.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "12.0.0.0")]
    public partial class IOSProjectFile : IOSProjectFileBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write(@"<?xml version=""1.0"" encoding=""utf-8""?>
<Project ToolsVersion=""4.0"" DefaultTargets=""Build"" xmlns=""http://schemas.microsoft.com/developer/msbuild/2003"">
  <PropertyGroup>
    <Configuration Condition="" '$(Configuration)' == '' "">Debug</Configuration>
    <Platform Condition="" '$(Platform)' == '' "">iPhoneSimulator</Platform>
    <ProductVersion>8.0.30703</ProductVersion>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>");
            
            #line 14 "C:\dev\net\v3\XamarinClean\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\IOSProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["ProjectGuid"]));
            
            #line default
            #line hidden
            this.Write(@"</ProjectGuid>
    <ProjectTypeGuids>{FEACFBD2-3405-455C-9665-78FE426C6842};{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}</ProjectTypeGuids>
    <OutputType>Library</OutputType>
    <RootNamespace>Amazon</RootNamespace>
    <AssemblyName>AWSSDK.Core</AssemblyName>
	<IPhoneResourcePrefix>Resources</IPhoneResourcePrefix>
	<BaseIntermediateOutputPath>obj\");
            
            #line 20 "C:\dev\net\v3\XamarinClean\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\IOSProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["BinSubfolder"]));
            
            #line default
            #line hidden
            this.Write(@"</BaseIntermediateOutputPath> 
  </PropertyGroup>
  <PropertyGroup Condition="" '$(Configuration)|$(Platform)' == 'Debug|AnyCPU' "">
    <DebugSymbols>true</DebugSymbols>
    <DebugType>full</DebugType>
    <Optimize>false</Optimize>
    <OutputPath>bin\Debug\");
            
            #line 26 "C:\dev\net\v3\XamarinClean\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\IOSProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["BinSubfolder"]));
            
            #line default
            #line hidden
            this.Write("</OutputPath>\r\n    <DefineConstants>DEBUG;TRACE;");
            
            #line 27 "C:\dev\net\v3\XamarinClean\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\IOSProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["DefineConstants"]));
            
            #line default
            #line hidden
            this.Write("</DefineConstants>\r\n    <ErrorReport>prompt</ErrorReport>\r\n    <WarningLevel>4</W" +
                    "arningLevel>\r\n    <ConsolePause>false</ConsolePause>\r\n    <MtouchDebug>true</Mto" +
                    "uchDebug>\r\n    <CodesignKey>iPhone Developer</CodesignKey>\r\n");
            
            #line 33 "C:\dev\net\v3\XamarinClean\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\IOSProjectFile.tt"

    if(this.Session.ContainsKey("SupressWarnings"))
    {

            
            #line default
            #line hidden
            this.Write("\t<NoWarn>");
            
            #line 37 "C:\dev\net\v3\XamarinClean\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\IOSProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["SupressWarnings"]));
            
            #line default
            #line hidden
            this.Write("</NoWarn>\r\n");
            
            #line 38 "C:\dev\net\v3\XamarinClean\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\IOSProjectFile.tt"

    }

            
            #line default
            #line hidden
            this.Write("    <CodeAnalysisModuleSuppressionsFile>GlobalSuppressions.cs</CodeAnalysisModule" +
                    "SuppressionsFile>\r\n\t<DocumentationFile>bin\\Debug\\");
            
            #line 42 "C:\dev\net\v3\XamarinClean\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\IOSProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["BinSubfolder"]));
            
            #line default
            #line hidden
            this.Write("\\");
            
            #line 42 "C:\dev\net\v3\XamarinClean\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\IOSProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["AssemblyName"]));
            
            #line default
            #line hidden
            this.Write(".XML</DocumentationFile>\r\n  </PropertyGroup>\r\n  <PropertyGroup Condition=\" \'$(Con" +
                    "figuration)|$(Platform)\' == \'Release|AnyCPU\' \">\r\n    <DebugType>none</DebugType>" +
                    "\r\n    <Optimize>true</Optimize>\r\n    <OutputPath>bin\\Release\\");
            
            #line 47 "C:\dev\net\v3\XamarinClean\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\IOSProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["BinSubfolder"]));
            
            #line default
            #line hidden
            this.Write("</OutputPath>\r\n    <DefineConstants>TRACE;;PCL;AWS_ASYNC_API;LOCAL_FILE</DefineCo" +
                    "nstants>\r\n    <ErrorReport>prompt</ErrorReport>\r\n    <WarningLevel>4</WarningLev" +
                    "el>\r\n    <ConsolePause>false</ConsolePause>\r\n    <CodesignKey>iPhone Developer</" +
                    "CodesignKey>\r\n");
            
            #line 53 "C:\dev\net\v3\XamarinClean\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\IOSProjectFile.tt"

    if(this.Session.ContainsKey("SupressWarnings"))
    {

            
            #line default
            #line hidden
            this.Write("\t<NoWarn>");
            
            #line 57 "C:\dev\net\v3\XamarinClean\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\IOSProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["SupressWarnings"]));
            
            #line default
            #line hidden
            this.Write("</NoWarn>\r\n");
            
            #line 58 "C:\dev\net\v3\XamarinClean\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\IOSProjectFile.tt"

    }

            
            #line default
            #line hidden
            this.Write("    <CodeAnalysisModuleSuppressionsFile>GlobalSuppressions.cs</CodeAnalysisModule" +
                    "SuppressionsFile>\r\n\t<DocumentationFile>bin\\Release\\");
            
            #line 62 "C:\dev\net\v3\XamarinClean\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\IOSProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["BinSubfolder"]));
            
            #line default
            #line hidden
            this.Write("\\");
            
            #line 62 "C:\dev\net\v3\XamarinClean\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\IOSProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["AssemblyName"]));
            
            #line default
            #line hidden
            this.Write(".XML</DocumentationFile>\r\n  </PropertyGroup>\r\n    <PropertyGroup>\r\n    <SignAssem" +
                    "bly>true</SignAssembly>\r\n  </PropertyGroup>\r\n  <Choose>\r\n    <When Condition=\" \'" +
                    "$(AWSKeyFile)\' == \'\' \">\r\n      <PropertyGroup>\r\n");
            
            #line 70 "C:\dev\net\v3\XamarinClean\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\IOSProjectFile.tt"

    if(this.Session.ContainsKey("KeyFilePath"))
    {

            
            #line default
            #line hidden
            this.Write("\t\t<AssemblyOriginatorKeyFile>");
            
            #line 74 "C:\dev\net\v3\XamarinClean\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\IOSProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["KeyFilePath"]));
            
            #line default
            #line hidden
            this.Write("</AssemblyOriginatorKeyFile>\r\n");
            
            #line 75 "C:\dev\net\v3\XamarinClean\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\IOSProjectFile.tt"

    }
	else
    {

            
            #line default
            #line hidden
            this.Write("        <AssemblyOriginatorKeyFile>..\\..\\..\\awssdk.dll.snk</AssemblyOriginatorKey" +
                    "File>\r\n");
            
            #line 81 "C:\dev\net\v3\XamarinClean\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\IOSProjectFile.tt"

    }

            
            #line default
            #line hidden
            this.Write("      </PropertyGroup>\r\n    </When>\r\n    <Otherwise>\r\n      <PropertyGroup>\r\n    " +
                    "    <AssemblyOriginatorKeyFile>$(AWSKeyFile)</AssemblyOriginatorKeyFile>\r\n      " +
                    "</PropertyGroup>\r\n    </Otherwise>\r\n  </Choose>\r\n  <ItemGroup>\r\n");
            
            #line 93 "C:\dev\net\v3\XamarinClean\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\IOSProjectFile.tt"

    foreach(string subDirectory in ((IList<string>)this.Session["SourceDirectories"]))
    {

            
            #line default
            #line hidden
            this.Write("    <Compile Include=\"");
            
            #line 97 "C:\dev\net\v3\XamarinClean\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\IOSProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(subDirectory));
            
            #line default
            #line hidden
            this.Write("\\*.cs\">\r\n      <SubType>Code</SubType>\r\n    </Compile>\r\n");
            
            #line 100 "C:\dev\net\v3\XamarinClean\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\IOSProjectFile.tt"

    }

            
            #line default
            #line hidden
            this.Write("  </ItemGroup>\r\n  <ItemGroup>\r\n");
            
            #line 105 "C:\dev\net\v3\XamarinClean\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\IOSProjectFile.tt"

    if(this.Session.ContainsKey("IndividualFileIncludes"))
    {
        foreach(string file in ((IList<string>)this.Session["IndividualFileIncludes"]))
        {
            if(file.EndsWith(".cs"))
            {

            
            #line default
            #line hidden
            this.Write("    <Compile Include=\"");
            
            #line 113 "C:\dev\net\v3\XamarinClean\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\IOSProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(file));
            
            #line default
            #line hidden
            this.Write("\">\r\n      <SubType>Code</SubType>\r\n    </Compile>\r\n");
            
            #line 116 "C:\dev\net\v3\XamarinClean\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\IOSProjectFile.tt"

            }
            else
            {

            
            #line default
            #line hidden
            this.Write("    <EmbeddedResource Include=\"");
            
            #line 121 "C:\dev\net\v3\XamarinClean\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\IOSProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(file));
            
            #line default
            #line hidden
            this.Write("\">\r\n      <SubType>Designer</SubType>\r\n    </EmbeddedResource>\r\n");
            
            #line 124 "C:\dev\net\v3\XamarinClean\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\IOSProjectFile.tt"

            }
        }
    }

            
            #line default
            #line hidden
            this.Write("  </ItemGroup>\r\n");
            
            #line 130 "C:\dev\net\v3\XamarinClean\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\IOSProjectFile.tt"

    if(this.Session.ContainsKey("ProjectReferences"))
    {
        foreach(var projectReferences in (List<ProjectFileCreator.ProjectReference>)this.Session["ProjectReferences"])
        {

            
            #line default
            #line hidden
            this.Write("  <ItemGroup>\r\n    <ProjectReference Include=\"");
            
            #line 137 "C:\dev\net\v3\XamarinClean\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\IOSProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(projectReferences.IncludePath));
            
            #line default
            #line hidden
            this.Write("\">\r\n        <Project>");
            
            #line 138 "C:\dev\net\v3\XamarinClean\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\IOSProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(projectReferences.ProjectGuid));
            
            #line default
            #line hidden
            this.Write("</Project>\r\n        <Name>");
            
            #line 139 "C:\dev\net\v3\XamarinClean\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\IOSProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(projectReferences.Name));
            
            #line default
            #line hidden
            this.Write("</Name>\r\n    </ProjectReference>\r\n  </ItemGroup>\r\n");
            
            #line 142 "C:\dev\net\v3\XamarinClean\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\IOSProjectFile.tt"

        }
    }

            
            #line default
            #line hidden
            this.Write(@"  <ItemGroup>
    <Compile Include=""Properties\AssemblyInfo.cs"" />
	<None Include=""packages.config"" />
  </ItemGroup>
  <ItemGroup>
    <Reference Include=""System"" />
	<Reference Include=""System.Net"" />
    <Reference Include=""System.Core"" />
    <Reference Include=""System.Xml.Linq"" />
    <Reference Include=""System.Xml"" />
	<Reference Include=""Xamarin.iOS"" />
    <Reference Include=""PCLCrypto"">
      <HintPath>");
            
            #line 158 "C:\dev\net\v3\XamarinClean\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\IOSProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["NugetPackagesLocation"]));
            
            #line default
            #line hidden
            this.Write("PCLCrypto.1.0.2.15130\\lib\\portable-net40+sl50+win+wpa81+wp80+MonoAndroid10+xamari" +
                    "nios10+MonoTouch10\\PCLCrypto.dll</HintPath>\r\n    </Reference>\r\n    <Reference In" +
                    "clude=\"PCLStorage\">\r\n      <HintPath>");
            
            #line 161 "C:\dev\net\v3\XamarinClean\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\IOSProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["NugetPackagesLocation"]));
            
            #line default
            #line hidden
            this.Write("PCLStorage.1.0.2\\lib\\portable-net45+wp8+wpa81+win8+monoandroid+monotouch+Xamarin." +
                    "iOS+Xamarin.Mac\\PCLStorage.dll</HintPath>\r\n    </Reference>\r\n    <Reference Incl" +
                    "ude=\"PCLStorage.Abstractions\">\r\n      <HintPath>");
            
            #line 164 "C:\dev\net\v3\XamarinClean\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\IOSProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["NugetPackagesLocation"]));
            
            #line default
            #line hidden
            this.Write("PCLStorage.1.0.2\\lib\\portable-net45+wp8+wpa81+win8+monoandroid+monotouch+Xamarin." +
                    "iOS+Xamarin.Mac\\PCLStorage.Abstractions.dll</HintPath>\r\n    </Reference>\r\n    <R" +
                    "eference Include=\"System.Net.Http\">\r\n      <HintPath>");
            
            #line 167 "C:\dev\net\v3\XamarinClean\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\IOSProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["NugetPackagesLocation"]));
            
            #line default
            #line hidden
            this.Write("Microsoft.Net.Http.2.2.29\\lib\\portable-net40+sl4+win8+wp71+wpa81\\System.Net.Http." +
                    "dll</HintPath>\r\n    </Reference>\r\n    <Reference Include=\"System.Net.Http.Extens" +
                    "ions\">\r\n      <HintPath>");
            
            #line 170 "C:\dev\net\v3\XamarinClean\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\IOSProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["NugetPackagesLocation"]));
            
            #line default
            #line hidden
            this.Write("Microsoft.Net.Http.2.2.29\\lib\\Xamarin.iOS10\\System.Net.Http.Extensions.dll</HintP" +
                    "ath>\r\n    </Reference>\r\n    <Reference Include=\"System.Net.Http.Primitives\">\r\n  " +
                    "    <HintPath>");
            
            #line 173 "C:\dev\net\v3\XamarinClean\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\IOSProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["NugetPackagesLocation"]));
            
            #line default
            #line hidden
            this.Write(@"Microsoft.Net.Http.2.2.29\lib\Xamarin.iOS10\System.Net.Http.Primitives.dll</HintPath>
    </Reference>
  </ItemGroup>
  <Import Project=""$(MSBuildExtensionsPath)\Xamarin\iOS\Xamarin.iOS.CSharp.targets"" />
  <!-- To modify your build process, add your task inside one of the targets below and uncomment it. 
       Other similar extension points exist, see Microsoft.Common.targets.
  <Target Name=""BeforeBuild"">
  </Target>
  <Target Name=""AfterBuild"">
  </Target>
  -->
</Project>");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "12.0.0.0")]
    public class IOSProjectFileBase
    {
        #region Fields
        private global::System.Text.StringBuilder generationEnvironmentField;
        private global::System.CodeDom.Compiler.CompilerErrorCollection errorsField;
        private global::System.Collections.Generic.List<int> indentLengthsField;
        private string currentIndentField = "";
        private bool endsWithNewline;
        private global::System.Collections.Generic.IDictionary<string, object> sessionField;
        #endregion
        #region Properties
        /// <summary>
        /// The string builder that generation-time code is using to assemble generated output
        /// </summary>
        protected System.Text.StringBuilder GenerationEnvironment
        {
            get
            {
                if ((this.generationEnvironmentField == null))
                {
                    this.generationEnvironmentField = new global::System.Text.StringBuilder();
                }
                return this.generationEnvironmentField;
            }
            set
            {
                this.generationEnvironmentField = value;
            }
        }
        /// <summary>
        /// The error collection for the generation process
        /// </summary>
        public System.CodeDom.Compiler.CompilerErrorCollection Errors
        {
            get
            {
                if ((this.errorsField == null))
                {
                    this.errorsField = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errorsField;
            }
        }
        /// <summary>
        /// A list of the lengths of each indent that was added with PushIndent
        /// </summary>
        private System.Collections.Generic.List<int> indentLengths
        {
            get
            {
                if ((this.indentLengthsField == null))
                {
                    this.indentLengthsField = new global::System.Collections.Generic.List<int>();
                }
                return this.indentLengthsField;
            }
        }
        /// <summary>
        /// Gets the current indent we use when adding lines to the output
        /// </summary>
        public string CurrentIndent
        {
            get
            {
                return this.currentIndentField;
            }
        }
        /// <summary>
        /// Current transformation session
        /// </summary>
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session
        {
            get
            {
                return this.sessionField;
            }
            set
            {
                this.sessionField = value;
            }
        }
        #endregion
        #region Transform-time helpers
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void Write(string textToAppend)
        {
            if (string.IsNullOrEmpty(textToAppend))
            {
                return;
            }
            // If we're starting off, or if the previous text ended with a newline,
            // we have to append the current indent first.
            if (((this.GenerationEnvironment.Length == 0) 
                        || this.endsWithNewline))
            {
                this.GenerationEnvironment.Append(this.currentIndentField);
                this.endsWithNewline = false;
            }
            // Check if the current text ends with a newline
            if (textToAppend.EndsWith(global::System.Environment.NewLine, global::System.StringComparison.CurrentCulture))
            {
                this.endsWithNewline = true;
            }
            // This is an optimization. If the current indent is "", then we don't have to do any
            // of the more complex stuff further down.
            if ((this.currentIndentField.Length == 0))
            {
                this.GenerationEnvironment.Append(textToAppend);
                return;
            }
            // Everywhere there is a newline in the text, add an indent after it
            textToAppend = textToAppend.Replace(global::System.Environment.NewLine, (global::System.Environment.NewLine + this.currentIndentField));
            // If the text ends with a newline, then we should strip off the indent added at the very end
            // because the appropriate indent will be added when the next time Write() is called
            if (this.endsWithNewline)
            {
                this.GenerationEnvironment.Append(textToAppend, 0, (textToAppend.Length - this.currentIndentField.Length));
            }
            else
            {
                this.GenerationEnvironment.Append(textToAppend);
            }
        }
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void WriteLine(string textToAppend)
        {
            this.Write(textToAppend);
            this.GenerationEnvironment.AppendLine();
            this.endsWithNewline = true;
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void Write(string format, params object[] args)
        {
            this.Write(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void WriteLine(string format, params object[] args)
        {
            this.WriteLine(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Raise an error
        /// </summary>
        public void Error(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Raise a warning
        /// </summary>
        public void Warning(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            error.IsWarning = true;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Increase the indent
        /// </summary>
        public void PushIndent(string indent)
        {
            if ((indent == null))
            {
                throw new global::System.ArgumentNullException("indent");
            }
            this.currentIndentField = (this.currentIndentField + indent);
            this.indentLengths.Add(indent.Length);
        }
        /// <summary>
        /// Remove the last indent that was added with PushIndent
        /// </summary>
        public string PopIndent()
        {
            string returnValue = "";
            if ((this.indentLengths.Count > 0))
            {
                int indentLength = this.indentLengths[(this.indentLengths.Count - 1)];
                this.indentLengths.RemoveAt((this.indentLengths.Count - 1));
                if ((indentLength > 0))
                {
                    returnValue = this.currentIndentField.Substring((this.currentIndentField.Length - indentLength));
                    this.currentIndentField = this.currentIndentField.Remove((this.currentIndentField.Length - indentLength));
                }
            }
            return returnValue;
        }
        /// <summary>
        /// Remove any indentation
        /// </summary>
        public void ClearIndent()
        {
            this.indentLengths.Clear();
            this.currentIndentField = "";
        }
        #endregion
        #region ToString Helpers
        /// <summary>
        /// Utility class to produce culture-oriented representation of an object as a string.
        /// </summary>
        public class ToStringInstanceHelper
        {
            private System.IFormatProvider formatProviderField  = global::System.Globalization.CultureInfo.InvariantCulture;
            /// <summary>
            /// Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public System.IFormatProvider FormatProvider
            {
                get
                {
                    return this.formatProviderField ;
                }
                set
                {
                    if ((value != null))
                    {
                        this.formatProviderField  = value;
                    }
                }
            }
            /// <summary>
            /// This is called from the compile/run appdomain to convert objects within an expression block to a string
            /// </summary>
            public string ToStringWithCulture(object objectToConvert)
            {
                if ((objectToConvert == null))
                {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                System.Type t = objectToConvert.GetType();
                System.Reflection.MethodInfo method = t.GetMethod("ToString", new System.Type[] {
                            typeof(System.IFormatProvider)});
                if ((method == null))
                {
                    return objectToConvert.ToString();
                }
                else
                {
                    return ((string)(method.Invoke(objectToConvert, new object[] {
                                this.formatProviderField })));
                }
            }
        }
        private ToStringInstanceHelper toStringHelperField = new ToStringInstanceHelper();
        /// <summary>
        /// Helper to produce culture-oriented representation of an object as a string
        /// </summary>
        public ToStringInstanceHelper ToStringHelper
        {
            get
            {
                return this.toStringHelperField;
            }
        }
        #endregion
    }
    #endregion
}
