#! "netcoreapp2.1"
#r "nuget:Buildalyzer,0.5.0"
#r "nuget:Buildalyzer.Workspaces,0.5.0"

using Buildalyzer;
using Buildalyzer.Workspaces;
using Microsoft.CodeAnalysis;

var manager = new AnalyzerManager();
var analyzer = manager.GetProject("src/MyApp1/MyApp1.csproj");

var rs = analyzer.GetWorkspace();

var workspace = new AdhocWorkspace();
analyzer.AddToWorkspace(workspace);