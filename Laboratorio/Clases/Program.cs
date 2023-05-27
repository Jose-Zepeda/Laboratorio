using Laboratorio.Clases;



string path = "C:\\TMP\\Empleados.db";


GestorEmpleados gestorEmpleados = new GestorEmpleados(path);
//gestorEmpleados.CrearTabla();

        Empleado Empleado1 = new Empleado(1, "Maria", "Sandoval", 18, "Administradora");
        gestorEmpleados.AgregarEmpleado(Empleado1);

        Empleado Empleado2 = new Empleado(2, "Manuel", "Robles", 19, "Licenciado");
        gestorEmpleados.AgregarEmpleado(Empleado1);

        Empleado Empleado3 = new Empleado(3, "Fernando", "Casanova", 34, "Ingeniero");
        gestorEmpleados.AgregarEmpleado(Empleado1);

        Empleado Empleado4 = new Empleado(4, "Ernesto", "Quevedo", 23, "Diseñador");
        gestorEmpleados.AgregarEmpleado(Empleado1);

        Empleado Empleado5 = new Empleado(5, "Rene", "Mendoza", 21, "Contador");
        gestorEmpleados.AgregarEmpleado(Empleado1);





    


