using System;
using Buildalyzer;
using Buildalyzer.Workspaces;
using Microsoft.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace Deps {
    class Program {
        static async Task Main(string[] args) {
            var manager = new AnalyzerManager();
            var analyzer = manager.GetProject("tests/MyApp1/MyApp1.csproj");
            var rs = analyzer.GetWorkspace();
            var workspace = new AdhocWorkspace();
            analyzer.AddToWorkspace(workspace);

            var project = workspace.CurrentSolution.Projects.First();
            var docs = project.Documents;
            foreach (var item in docs) {
                Console.WriteLine(item.FilePath);
            }

            var deps = project.MetadataReferences;
            foreach (var item in deps) {
                Console.WriteLine(item.Display);
            }
        }
    }
}
