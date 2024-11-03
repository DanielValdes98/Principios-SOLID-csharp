using SingleResponsability;

StudentRepository studentRepository = new();
ExportHelper exportHelper = new();
exportHelper.ExportToCSV(studentRepository.GetAll(), "Students");
Console.WriteLine("Proceso Completado");