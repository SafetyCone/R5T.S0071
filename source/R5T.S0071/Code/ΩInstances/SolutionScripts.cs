using System;


namespace R5T.S0071
{
    public class SolutionScripts : ISolutionScripts
    {
        #region Infrastructure

        public static ISolutionScripts Instance { get; } = new SolutionScripts();


        private SolutionScripts()
        {
        }

        #endregion
    }
}
