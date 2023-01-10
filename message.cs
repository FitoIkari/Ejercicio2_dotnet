Console.WriteLine("Por favor capture los siguientes datos: ");

Console.WriteLine("\tNombre: ");
string name = Console.ReadLine();

Console.WriteLine("\tApellido: ");
string lastName = Console.ReadLine();

Console.WriteLine("\tEdad: ");
int age;

int.TryParse(Console.ReadLine(), out age);

Console.WriteLine("¿Sabe programar? (Y/N)");
bool isProgrammer = false;

string sProgrammer = Console.ReadLine();

if (sProgrammer == "Y" || sProgrammer == "y") {
    isProgrammer = true;
}

String message = "El usuario " + name + " " + lastName + " tiene " + age.ToString() + " años y " + (isProgrammer ? "" : "no ") + "sabe programar.";

Console.WriteLine(message);