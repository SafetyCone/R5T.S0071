using System;


namespace R5T.S0071
{
    public class SolutionGenerationScripts : ISolutionGenerationScripts
    {
        #region Infrastructure

        public static ISolutionGenerationScripts Instance { get; } = new SolutionGenerationScripts();


        private SolutionGenerationScripts()
        {
        }

        #endregion
    }
}
