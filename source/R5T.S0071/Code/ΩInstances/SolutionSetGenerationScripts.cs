using System;


namespace R5T.S0071
{
    public class SolutionSetGenerationScripts : ISolutionSetGenerationScripts
    {
        #region Infrastructure

        public static ISolutionSetGenerationScripts Instance { get; } = new SolutionSetGenerationScripts();


        private SolutionSetGenerationScripts()
        {
        }

        #endregion
    }
}
