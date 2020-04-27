using System;
using System.IO;

namespace Full_GRASP_And_SOLID.Library
{
    /*Esta clase que es del tipo IPrinter tiene la responsabilidad de implementar la operación de imprimir en archivo
    y no es su responsabilidad como se imprima en otro medio*/

    public class FilePrinter :IPrinter
    {
        /*Cumple con el Patrón de polimorfismo. Esta es una operación Polimórfica, porque en este caso está implementada por 2 objetos de diferente
        tipo que son los que creamos en Program; ConsolePrinter y FilePrinter. Además así como lo tenemos armado hasta el momento
        cumple con el principio de sustitución de Liskov no hay efectos colaterales, con FilePrinter y ConsolePrinter obtenermos
        el mismo resultado*/
        public void PrintRecipe(Recipe receta, IPrinter impresora)
        {
            File.WriteAllText("Recipe.txt", receta.GetTextToPrint());
        }
    }
}