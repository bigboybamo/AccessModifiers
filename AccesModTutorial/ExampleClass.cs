using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesModTutorial
{
    public class ExampleClass
    {
        public string? PublicName { get; set; }
        private string PrivateName { get; set; }
        protected string? ProtectedName { get; set; }
        private protected string? ProtectedPrivateName { get; set;}

        internal string? InternalName { get; set; }

        public ExampleClass()
        {
            PrivateName = "Test";
        }

        public string GetPrivateName()
        {
            return PrivateName;
        }

    }

    class ChlidExampleClass : ExampleClass
    {
        public ChlidExampleClass()
        {
                ProtectedName = "Test";
                ProtectedPrivateName = "Test";
        }
        public string? GetPrivateProtectedName()
        {
            return ProtectedName;
        }

        public string? GetProtectedName()
        {
            return ProtectedPrivateName;
        }
    }
}
