using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsFramework.Test
{
    class Class1
    {
        [Test]
        public void Pth()
        {
            Console.WriteLine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile));
           // Console.WriteLine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)+"\marsframework-master\MarsFramework\ExcelData\TestDataShareSkill.xlsx");
           
            // This will get the current WORKING directory (i.e. \bin\Debug)
            string workingDirectory = Environment.CurrentDirectory;
            // or: Directory.GetCurrentDirectory() gives the same result

            // This will get the current PROJECT directory
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;
            Console.WriteLine(projectDirectory);

            string startupPath = System.IO.Path.GetFullPath(".\\");
            Console.WriteLine(System.IO.Path.GetFullPath(".\\") + "MarsFramework/ExcelData/TestDataShareSkill.xlsx");
            string startupPath1 = System.IO.Path.GetFullPath(".\\") + "MarsFramework/ExcelData/TestDataShareSkill.xlsx";
        }
    }
}