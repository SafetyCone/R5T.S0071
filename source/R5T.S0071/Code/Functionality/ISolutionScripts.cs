using System;
using System.Threading.Tasks;

using R5T.F0000;
using R5T.L0031.Extensions;
using R5T.L0038;
using R5T.T0132;
using R5T.T0197;
using R5T.T0197.Extensions;
using R5T.T0198;


namespace R5T.S0071
{
    [FunctionalityMarker]
    public partial interface ISolutionScripts : IFunctionalityMarker
    {
        public async Task In_New_SampleSolutionContext()
        {
            var (humanOutputTextFilePath, logFilePath) = await Instances.ApplicationContextOperator.In_ApplicationContext_Undated(
                Instances.Values.ApplicationName,
                ApplicationContextOperation);

            static async Task ApplicationContextOperation(IApplicationContext applicationContext)
            {
                await Instances.SampleSolutionOperations.In_New_SampleSolutionContext(
                    applicationContext.TextOutput,
                    async solutionContext =>
                    {
                        //// Simply create a new solution file.
                        //await Instances.SolutionContextOperations.Create_New_SolutionFile(solutionContext);

                        // Create a new web library with construction server and client projects.
                        var libraryName = Instances.Values.Sample_LibraryName.Value.ToUnadjustedLibraryName();
                        var libraryDescription = Instances.Values.Sample_LibraryDescription;
                        var isPrivate = true;
                        var repositoryUrl = new IsSet<IRepositoryUrl>();

                        await solutionContext.Run(
                            Instances.SolutionContextOperations.Create_WebLibraryForBlazorWithConstructionServerAndClient(
                                libraryName,
                                libraryDescription,
                                isPrivate,
                                repositoryUrl,
                                out var creationOutput
                            )
                        );

                        Instances.VisualStudioOperator.Open_SolutionFile(
                            solutionContext.SolutionFilePath.Value);
                    });
            }

            Instances.NotepadPlusPlusOperator.Open(
                humanOutputTextFilePath,
                logFilePath);
        }
    }
}
