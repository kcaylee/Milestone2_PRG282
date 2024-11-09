using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BusinessLayer
{
    internal class Module
    {
        string ModuleName, ModuleLink, ModuleDescription, ModuleCode;

        public Module(string moduleName, string moduleLink, string moduleDescription, string moduleCode)
        {
            ModuleName1 = moduleName;
            ModuleLink1 = moduleLink;
            ModuleDescription1 = moduleDescription;
            
            ModuleCode1 = moduleCode;
        }

        public string ModuleName1 { get => ModuleName; set => ModuleName = value; }
        public string ModuleLink1 { get => ModuleLink; set => ModuleLink = value; }
        public string ModuleDescription1 { get => ModuleDescription; set => ModuleDescription = value; }
        
        public string ModuleCode1 { get => ModuleCode; set => ModuleCode = value; }
    }
}
