using System.Text;

namespace SingleResponsability
{
    public class ExportHelper
    {
        public void ExportToCSV<T>(IEnumerable<T> items, string fileName)
        {
            // Usar reflexión para obtener los nombres de las propiedades de T
            var properties = typeof(T).GetProperties();
            var sb = new StringBuilder();

            // Encabezado con los nombres de las propiedades
            sb.AppendLine(string.Join(";", properties.Select(p => p.Name)));

            // Filas con los valores de cada propiedad
            foreach (var item in items)
            {
                var values = properties.Select(p => p.GetValue(item, null)?.ToString() ?? string.Empty);
                sb.AppendLine(string.Join(";", values));
            }

            // Guardar el archivo
            var filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $"{fileName}.csv");
            File.WriteAllText(filePath, sb.ToString(), Encoding.Unicode);

            // Código original (Sin reflexión): 
            // string csv = String.Join(",", students.Select(x => x.ToString()).ToArray());
            // System.Text.StringBuilder sb = new System.Text.StringBuilder();
            // sb.AppendLine("Id;Fullname;Grades");
            // foreach (var item in students)
            // {
            //     sb.AppendLine($"{item.Id};{item.Fullname};{string.Join("|", item.Grades)}");
            // }
            // System.IO.File.WriteAllText(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Students.csv"), sb.ToString(), Encoding.Unicode);
        }
    }
}