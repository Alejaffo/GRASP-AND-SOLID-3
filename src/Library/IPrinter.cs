using System;

namespace Full_GRASP_And_SOLID.Library
{
    public interface IPrinter
    {
        void PrintRecipe(Recipe receta, IPrinter impresora);
    }
}