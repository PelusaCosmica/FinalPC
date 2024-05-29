using System.Formats.Asn1;

namespace Final_Bruno_Urías;

public class Biblioteca
{
    public string[] Catalogo = new string[15]{"1984 - George Orwell","Nada - Carmen Laforet","Los Miserables - Víctor Hugo","El Alquimista - Paulo Coelho","La Divina Comedia - Dante","Cien años de Soledad - Gabriel García Márquez","El Principito - Antoine de Saint-Exupéry","El retrato de Dorian Grey - Oscar Wilde","Un mundo feliz - Aldous Huxley","A sangre fría - Truman Capote","Cumbres Borrascosas - Emily Bronte","Rayuela - Julio Cortázar","Mujercitas - Louise May Alcott","El Diario de Ana Frank","El gran Gatsby - F. Scott Fitzgerald"};
    public void ConsultarCatalogo()
    {
        for(int i = 0; i < 15; i++)
        {
            Console.WriteLine(Catalogo[i] + ".");
        }
    }
}