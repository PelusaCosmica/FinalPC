using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;

namespace Final_Bruno_Urías;

public class Usuario
{
    public string[,] Usuarios = new string[10,5];
    public string Nombre = "", Apellido = "",  Carne = "", Telefono = "";
    int ContadorF = 0;
    Biblioteca ObjBiblioteca = new Biblioteca();
    public void DatosUsuario()
    {
        string VAR = "";
        int A, B, C, D, E;
        Console.WriteLine("Ingrese los datos: ");
        do{
            if(VAR == "N")
            {
                Console.WriteLine("El nombre no debe llevar números");
            }
            VAR = "";
            Console.Write("Nombre: "); Nombre = Console.ReadLine() + "";
            if(Nombre.IndexOf('0') == -1 && Nombre.IndexOf('1') == -1 && Nombre.IndexOf('2') == -1 && Nombre.IndexOf('3') == -1 && Nombre.IndexOf('4') == -1 && Nombre.IndexOf('5') == -1 && Nombre.IndexOf('6') == -1 && Nombre.IndexOf('7') == -1 && Nombre.IndexOf('8') == -1 && Nombre.IndexOf('9') == -1)
            {
                Usuarios[ContadorF,0] = Nombre;
                VAR = "S";
            }else
            {
                VAR = "N";
            }
        }while(VAR != "S");
        do{
            if(VAR == "N")
            {
                Console.WriteLine("El apellido no debe llevar números");
            }
            VAR = "";
            Console.Write("Apellido: "); Apellido = Console.ReadLine() + "";
            if(Apellido.IndexOf('0') == -1 && Apellido.IndexOf('1') == -1 && Apellido.IndexOf('2') == -1 && Apellido.IndexOf('3') == -1 && Apellido.IndexOf('4') == -1 && Apellido.IndexOf('5') == -1 && Apellido.IndexOf('6') == -1 && Apellido.IndexOf('7') == -1 && Apellido.IndexOf('8') == -1 && Apellido.IndexOf('9') == -1)
            {
                Usuarios[ContadorF,1] = Apellido;
                VAR = "S";
            }else
            {
                VAR = "N";
            }
        }while(VAR != "S");
        do{
            if(VAR == "N")
            {
                Console.WriteLine("El carné debe ser de 7 dígitos");
            }
            VAR = "";
            Console.Write("Carné: "); Carne = Console.ReadLine() + "";
            if(Carne.Length < 8 && Carne.Length > 6)
            {
                Usuarios[ContadorF,2] = Carne;
                VAR = "S";
            }else
            {
                VAR = "N";
            }
        }while(VAR != "S");
        do{
            if(VAR == "N")
            {
                Console.WriteLine("El Teléfono debe ser de 8 dígitos");
            }
            VAR = "";
            Console.Write("Número: "); Telefono = Console.ReadLine() + "";
            if(Telefono.Length < 9 && Telefono.Length > 7)
            {
                Usuarios[ContadorF,3] = Telefono;
                VAR = "S";
            }else
            {
                VAR = "N";
            }
        }while(VAR != "S");
        A = new Random().Next(0,15);
        Usuarios[ContadorF,4] = ObjBiblioteca.Catalogo[A] + ",";
        do{
            B = new Random().Next(0,15);
            Usuarios[ContadorF,4] = Usuarios[ContadorF,4] + ObjBiblioteca.Catalogo[B] + ",";
        }while(B == A);
        do{
            C = new Random().Next(0,15);
            Usuarios[ContadorF,4] = Usuarios[ContadorF,4] + ObjBiblioteca.Catalogo[C] + ",";
        }while(C == A || C == B);
        do{
            D = new Random().Next(0,15);
            Usuarios[ContadorF,4] = Usuarios[ContadorF,4] + ObjBiblioteca.Catalogo[D] + ",";
        }while(D == A || D == B || D == C);
        do{
            E = new Random().Next(0,15);
            Usuarios[ContadorF,4] = Usuarios[ContadorF,4] + ObjBiblioteca.Catalogo[E];
        }while(E == A || E == B || E == C || E == D);
        ContadorF++;
    }
    public void PrestadosUsu(string Usuario)
    {
        int Validacion = 0;
        for(int i = 0; i < Usuarios.GetLength(0); i++)
        {
            for(int j = 0; j < Usuarios.GetLength(1); j++)
            {
                if(Usuarios[i,j] == Usuario)
                {
                    Console.WriteLine(Usuarios[i,4]);
                    Validacion = 1;
                }
            }
        }
        if(Validacion == 0)
        {
            Console.WriteLine("este usuario no existe");
        }
    }
    public void UsuariosActivos()
    {
        if(ContadorF > 0)
        {
            for(int i = 0; i < Usuarios.GetLength(0); i++)
        {
            Console.WriteLine(Usuarios[i,0] + " " + Usuarios[i,1]);
        }
        }else
        {
            Console.WriteLine("aún no ha ingresado usuarios");
        }
        
    }
    public void EscribirDatosUsuario()
    {
        for(int i = 0; i < Usuarios.GetLength(0); i++)
        {
            Console.WriteLine();
            for(int j = 0; j < Usuarios.GetLength(1); j++)
            {
                Console.Write(Usuarios[i,j]);
            }
        }
    }
}