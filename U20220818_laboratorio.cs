using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
         static void Main(string[] args)
        {
            //PARTE I

            //DECLARACION DE VARIABLE TIPO TEXTO DESDE LA CONSOLA
            string? departamento;
            string? municipio;
            string? ciudad;

            //DECLARAR DOS VARIABLES DE TEXTO, ASIGANANDO SUS VALORES
            string? coloniaquerecide= "Colonia Maria Gregoria";
            string? colordecasa= "Blanca";
            
            //DECLARACION DE VARIABLES DE TIPO ENTERAS ASIGNANDO SU VALOR DE CONSOLA
            int añosderecidencia;
            int edadActual;

            //DECLARACION DE VARIABLES DE TIPO DATE TIME 
            DateTime fechaNacimiento= new DateTime(00, 1, 12, 09, 20, 00);
            DateTime fechaActual= DateTime.Now;

            //DECLARACION DE DATOS DESDE LA TERMINAL

            //DECLARACION DE VARIABLES 
            Console.WriteLine("Ingresar su departamento: ");
            departamento = Convert.ToString(Console.ReadLine);
            Console.WriteLine();
            
            Console.WriteLine("Ingrese su municipio: ");
            municipio=  Convert.ToString(Console.ReadLine);
            Console.WriteLine();

            Console.WriteLine("Ingrese su ciudad: ");
            ciudad= Convert.ToString(Console.ReadLine); 
            Console.WriteLine();

            Console.WriteLine("Ingrese los años de vivir en su recidencia: ");
            añosderecidencia= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Ingrese su edad actual: ");
            edadActual= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(); 

            //APLICACION DE FUNCIONES PARA CADENAS

            //FUNCION DE VARIABLES PARA APLICAR CADENAS
            bool cadenasComparativa = departamento == municipio; 

            //APLICACION DE FUNCION PARA CONCATENAR EL TEXTO
            string? cadenasConcatenada = municipio+ "" + ciudad;

            //APLICAR FUNCIONES DE MAYUSCULA 
            string? funcionMayuscula1 = departamento.ToLower();
            string? funcionMayuscula2 = municipio.ToLower();

            //APLICACION DE FUNCION DE LIMPIADOS DE CADENAS 
            string? funcionLimpiado = ciudad.Trim();

            //APLICACION DE FUNCION DE LONGITUD DE CADENAS 
            int llongitudCadenas1 = municipio.Length;
            int llongitudCadenas2 = ciudad.Length;

            //APLICACION DE FUNCION DE FORMATEO DE DIA/MES/AÑO
            string fechaFormateada = fechaActual.ToString(" dd/MM/yyyy");

            //APLICAR ADICCION DE 2 SEMANAS A CADA FECHA 
            DateTime fechaSumada = fechaNacimiento.AddDays(15);
            DateTime fechaSumada2 = fechaActual.AddDays(15);

            //COMPAREMOS LAS FECHAS ANTERIORES, FECHA1 MAYOR A FECHA2 Y FECHA1 MENOR A FECHA2
            bool fechaIgual= fechaActual == fechaNacimiento;
            bool fecha_Nacimiento= fechaActual < fechaNacimiento;
            bool fecha_Actual = fechaActual > fechaNacimiento; 

            //IMPRISIONES 

            Console.WriteLine("*************Inicio de Impresion de valores de texto***********");
            Console.WriteLine("Escriba su departamento: "+ departamento); 
            Console.WriteLine("Escriba su municipio: "+ municipio);
            Console.WriteLine("Nombre de su ciudad: "+ ciudad);
            Console.WriteLine("Escriba el nombre de su colonia: "+ coloniaquerecide);
            Console.WriteLine("El color de su casa: "+ colordecasa);
            Console.WriteLine("*****************Fin de Impresion***************\n\n");

            Console.WriteLine("\n--------Inicio de Impresion de variables enteras------------------");
            Console.WriteLine("Escriba sus años de recidencia actual: "+ añosderecidencia); 
            Console.WriteLine("Escriba su edad actual: "+ edadActual);
            Console.WriteLine("*****************Fin de Impresion***************\n\n");

            Console.WriteLine("\n-------Inicio de Impresion de valores ingresados de cadenas---------");
            Console.WriteLine("--Funcion de cadena comparativa >>> "+ cadenasComparativa); 
            Console.WriteLine("--Funcion de cadena concatenada >>> "+ cadenasConcatenada);
            Console.WriteLine("--Funcion de mayuscula 1 >>> "+ funcionMayuscula1);
            Console.WriteLine("--Funcion de mayuscula 2 >>> "+  funcionMayuscula2);
            Console.WriteLine("--Funcion de limpiado >>>  "+ funcionLimpiado);
            Console.WriteLine("--Funcion de longitud de cadena 1 >>> "+ llongitudCadenas1);
            Console.WriteLine("--Funcion de longitud de cadena 2 >>> "+ llongitudCadenas2);
            Console.WriteLine("*****************Fin de Impresion***************\n\n");
            
            Console.WriteLine("\n-------Inicio de Impresion de valores de texto---------");
            Console.WriteLine("--Fecha de nacimiento >>> "+ fechaNacimiento); 
            Console.WriteLine("--Fecha actual >>> "+ fechaActual);
            Console.WriteLine("--Fecha de nacimiento >>> "+ fechaNacimiento);
            Console.WriteLine("--Fecha formateada >>> "+  fechaFormateada);
            Console.WriteLine("--Fecha sumada >>>  "+ fechaSumada);
            Console.WriteLine("--Fecha sumada 2 >>> "+ fechaSumada2);
            Console.WriteLine("--Fecha de igual >>> "+ fechaIgual);
            Console.WriteLine("--Fecha de nacimiento >>> "+ fecha_Nacimiento);
            Console.WriteLine("--Fecha de actual >>> "+ fecha_Actual);
            Console.WriteLine("*****************Fin de Impresion***************\n\n");

            //AUTO EVALUACION 10
        }
    }
}