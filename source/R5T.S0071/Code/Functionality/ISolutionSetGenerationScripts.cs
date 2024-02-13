using System;
using System.Threading.Tasks;

using R5T.F0000;
using R5T.L0038;
using R5T.T0132;
using R5T.T0197.Extensions;
using R5T.T0198;
using R5T.T0201;
using R5T.T0204;


namespace R5T.S0071
{
    [FunctionalityMarker]
    public partial interface ISolutionSetGenerationScripts : IFunctionalityMarker
    {
        /// <summary>
        /// See also: R5T.S0065.ISolutionSetGenerationScripts.Create_WebBlazorClientAndServer()
        /// </summary>
        public async Task Create_WebBlazorClientAndServer()
        {
            /// Inputs.
            var solutionDirectoryPath =
                //@""
                Instances.Paths.Sample_SolutionDirectoryPath
                ;
            var libraryName =
                //""
                Instances.Values.Sample_LibraryName.Value
                .ToUnadjustedLibraryName();
            var libraryDescription =
                Instances.Values.Sample_LibraryDescription
                ;
            bool isPrivate = true;


            /// Run.
            var repositoryUrl = new IsSet<IRepositoryUrl>();

            var (humanOutputTextFilePath, logFilePath) = await Instances.ApplicationContextOperator.In_ApplicationContext_Undated(
                Instances.Values.ApplicationName,
                ApplicationContextOperation);

            async Task ApplicationContextOperation(IApplicationContext applicationContext)
            {
                await Instances.SolutionSetContextOperator.In_SolutionSetContext(
                    applicationContext.TextOutput,
                    Instances.SolutionSetContextOperations.Create_BlazorClientAndServer(
                        solutionDirectoryPath,
                        repositoryUrl,
                        libraryName,
                        isPrivate,
                        out var creationResult));

                /// Show results.
                Instances.VisualStudioOperator.Open_SolutionFile(
                    creationResult.SolutionFilePath.Value);
            }            

            Instances.WindowsExplorerOperator._Platform.OpenDirectoryInExplorer(
                solutionDirectoryPath.Value);
        }
    }
}
