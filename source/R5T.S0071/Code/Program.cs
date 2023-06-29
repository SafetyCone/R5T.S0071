using System;
using System.Threading.Tasks;


namespace R5T.S0071
{
    class Program
    {
        static async Task Main()
        {
            //await SolutionSetGenerationScripts.Instance.Create_WebBlazorClientAndServer();

            await SolutionScripts.Instance.In_New_SampleSolutionContext();
        }
    }
}