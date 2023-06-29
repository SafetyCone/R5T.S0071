using System;


namespace R5T.S0071
{
    public static class Instances
    {
        public static L0038.IApplicationContextOperator ApplicationContextOperator => L0038.ApplicationContextOperator.Instance;
        public static L0046.O001.ILibraryNameOperations LibraryNameOperations => L0046.O001.LibraryNameOperations.Instance;
        public static F0134.ILibraryNameOperator LibraryNameOperator => F0134.LibraryNameOperator.Instance;
        public static F0033.INotepadPlusPlusOperator NotepadPlusPlusOperator => F0033.NotepadPlusPlusOperator.Instance;
        public static IPaths Paths => S0071.Paths.Instance;
        public static O0007.IProjectDescriptionOperations ProjectDescriptionOperations => O0007.ProjectDescriptionOperations.Instance;
        public static L0044.O001.IProjectNameOperations ProjectNameOperations => L0044.O001.ProjectNameOperations.Instance;
        public static L0045.O001.ISolutionNameOperations SolutionNameOperations => L0045.O001.SolutionNameOperations.Instance;
        public static O0013.O001.ISolutionOperations SolutionOperations => O0013.O001.SolutionOperations.Instance;
        public static ISolutionContextOperations SolutionContextOperations => S0071.SolutionContextOperations.Instance;
        public static O0014.ISolutionSetContextOperations SolutionSetContextOperations => O0014.SolutionSetContextOperations.Instance;
        public static L0039.F000.ISolutionSetContextOperator SolutionSetContextOperator => L0039.F000.SolutionSetContextOperator.Instance;
        public static IValues Values => S0071.Values.Instance;
        public static F0088.IVisualStudioOperator VisualStudioOperator => F0088.VisualStudioOperator.Instance;
        public static F0034.IWindowsExplorerOperator WindowsExplorerOperator => F0034.WindowsExplorerOperator.Instance;
    }
}