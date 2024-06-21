using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace TXTEditor
{
    public static class Manager
    {
        //Standard values
        public static string DefaultFolderPath => Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\";
        public static string DefaultFileName => "file";
        public static string DefaultFileExt => ".txt";

        //Values ​​assigned to use
        public static string FolderPath { get; set; } = DefaultFolderPath;
        public static string FileName { get; set; } = DefaultFileName;
        public static string FileExt { get; set; } = DefaultFileExt;
        public static string FilePath => FolderPath + FileName + FileExt; 
    }
}
