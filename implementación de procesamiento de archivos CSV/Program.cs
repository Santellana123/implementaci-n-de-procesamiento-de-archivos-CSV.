Console.WriteLine("Ingrese la ruta del archivo CSV:");
string filePath = Console.ReadLine();

// Verifica si el archivo existe
if (!File.Exists(filePath))
{
    Console.WriteLine("El archivo no existe.");
    return;
}

// Lee todas las líneas del archivo CSV
string[] lines = File.ReadAllLines(filePath);

// Obtiene el encabezado del archivo CSV
string[] headers = lines.First().Split(',');

// Procesa cada línea del archivo CSV
foreach (string line in lines.Skip(1)) // Salta la primera línea (encabezado)
{
    // Divide la línea en columnas
    string[] columns = line.Split(',');

    // Procesa los datos de cada columna
    for (int i = 0; i < headers.Length; i++)
    {
        string header = headers[i];
        string data = columns[i];

        Console.WriteLine($"Encabezado: {header}, Dato: {data}");
    }
}