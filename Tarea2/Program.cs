int numero_cedula = 0;
string nombre_empleado = null;
int repeticion = 0;
int n = 1;
int opcion = 0;
double aumento = 0;
double horas_trabajadas = 0;
double salario_hora= 0;
double pago = 0;
double salario_bruto = 0;
double rebajo_ccss = 0;
double salario_neto = 0;
double deduccion = 0;
int empleados_Operarios = 0;
int empleados_Tecnicos = 0; 
int empleados_Profesionales = 0;
double acumulado_Salario_Neto_Operarios = 0;
double acumulado_Salario_Neto_Tecnicos = 0;
double acumulado_Salario_Neto_Profesionales = 0;

Console.WriteLine("Indique la cantidad de empleados a revisar");
repeticion = int.Parse(Console.ReadLine());

Console.WriteLine("Indique la cantidad de horas trabajadas");
horas_trabajadas = double.Parse(Console.ReadLine());

Console.WriteLine("Indique el salario por hora");
salario_hora = double.Parse(Console.ReadLine());
do 
{
    Console.WriteLine("Digite el nombre del empleado");
    nombre_empleado = Console.ReadLine();
    Console.WriteLine("Digite el numero de cedula");
    numero_cedula = int.Parse(Console.ReadLine());
    n ++;
    Console.WriteLine("1- Operario");
    Console.WriteLine("2- Tecnico");
    Console.WriteLine("3- Profesional");
    Console.WriteLine("Ingrese el tipo de empleado");
    opcion = int.Parse(Console.ReadLine());
    if (opcion == 1)
    {
        empleados_Operarios++;
        pago = salario_hora*horas_trabajadas;
        aumento = pago*0.15;
        salario_bruto = pago + aumento;
        deduccion = salario_bruto * 0.917;
        rebajo_ccss = salario_bruto - deduccion;
        salario_neto = salario_bruto - rebajo_ccss;
        acumulado_Salario_Neto_Operarios += salario_neto;
    }
    else if (opcion == 2)
    {
        empleados_Profesionales++;
        pago = salario_hora * horas_trabajadas;
        aumento = pago * 0.10;
        salario_bruto = pago + aumento;
        deduccion = salario_bruto * 0.917;
        rebajo_ccss = salario_bruto - deduccion;
        salario_neto = salario_bruto - rebajo_ccss;
        acumulado_Salario_Neto_Profesionales += salario_neto;
    }
    else if (opcion == 3)
    {
        empleados_Profesionales++;
        pago = salario_hora * horas_trabajadas;
        aumento = pago * 0.05;
        salario_bruto = pago + aumento;
        deduccion = salario_bruto * 0.917;
        rebajo_ccss = salario_bruto - deduccion;
        salario_neto = salario_bruto - rebajo_ccss;
        acumulado_Salario_Neto_Profesionales += salario_neto;
    }
    Console.Clear();
    Console.WriteLine("Numero cedula empleado: " +numero_cedula);
    Console.WriteLine("Nombre: " + nombre_empleado);
    Console.WriteLine("Tipo de empleado: " + opcion);
    Console.WriteLine("Aumento; " + aumento);
    Console.WriteLine("Cantidad de horas: " + horas_trabajadas);
    Console.WriteLine("Salario por hora; " + salario_hora);
    Console.WriteLine("Salario ordinario; " + salario_bruto);
    Console.WriteLine("Salario bruto: " + salario_bruto);
    Console.WriteLine("Deduccion CCSS: " + rebajo_ccss);
    Console.WriteLine("Salario neto: "+salario_neto);
}



while (repeticion >= n);

Console.WriteLine();
Console.WriteLine("Cantidad de empleados operarios: " + empleados_Operarios);
Console.WriteLine("Acumulado salario neto operarios: " + acumulado_Salario_Neto_Operarios);
Console.WriteLine("Promedio salario neto de operarios; "+ acumulado_Salario_Neto_Operarios/empleados_Operarios);
Console.WriteLine("Cantidad de empleados operarios: " + empleados_Tecnicos);
Console.WriteLine("Acumulado salario neto operarios: " + acumulado_Salario_Neto_Tecnicos);
Console.WriteLine("Promedio salario neto de operarios; " + acumulado_Salario_Neto_Tecnicos / empleados_Tecnicos);
Console.WriteLine("Cantidad de empleados operarios: " + empleados_Profesionales);
Console.WriteLine("Acumulado salario neto operarios: " + acumulado_Salario_Neto_Profesionales);
Console.WriteLine("Promedio salario neto de operarios; " + acumulado_Salario_Neto_Profesionales / empleados_Profesionales);