using System;


namespace R5T.S0071
{
    public class Paths : IPaths
    {
        #region Infrastructure

        public static IPaths Instance { get; } = new Paths();


        private Paths()
        {
        }

        #endregion
    }
}
