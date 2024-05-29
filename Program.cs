using Final_Bruno_Urías;
string opcion, opciont, Usuario;
Usuario ObjUsuario = new Usuario();
Biblioteca ObjBiblioteca = new Biblioteca();
do{
    Console.WriteLine("Elija una opción: \n1) Ingreso de datos (por entidad)\n2) Mostrar datos\n3) Salir del programa");
    opcion = Console.ReadLine() + "";
    switch(opcion)
    {
        case "1":
            ObjUsuario.DatosUsuario();
            break;
        case "2":
            Console.WriteLine("1) Listado de libros prestados por usuario\n2) Consultar catálogo de libros\n3) Listado de usuarios activos");
            opciont = Console.ReadLine() + "";
            switch(opciont)
            {
                case "1":
                    Console.WriteLine("Ingrese el usuario que desea(nombre): ");
                    Usuario = Console.ReadLine() + "";
                    ObjUsuario.PrestadosUsu(Usuario);
                    break;
                case "2":
                    ObjBiblioteca.ConsultarCatalogo();
                    break;
                case "3":
                    ObjUsuario.UsuariosActivos();
                    break;
            }
            break;
        case "3":
            Console.WriteLine("Un gusto atenderle");
            break;
        default:
            Console.WriteLine("Opció no válida");
            break;
    }
}while(opcion != "3");