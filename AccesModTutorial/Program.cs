// See https://aka.ms/new-console-template for more information
using AccesModTutorial;

ExampleClass exampleClass = new ExampleClass();
exampleClass.PublicName = "Test";
exampleClass.GetPrivateName();
ChlidExampleClass chlidExampleClass = new ChlidExampleClass();
chlidExampleClass.GetProtectedName();
chlidExampleClass.GetPrivateProtectedName();
exampleClass.InternalName = "Test";
Console.WriteLine(exampleClass.PublicName);
Console.WriteLine(exampleClass.GetPrivateName());
Console.WriteLine(chlidExampleClass.GetProtectedName());
Console.WriteLine(chlidExampleClass.GetPrivateProtectedName());
Console.WriteLine(exampleClass.InternalName);