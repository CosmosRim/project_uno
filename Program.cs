// See https://aka.ms/new-console-template for more information
//using Humanizer;
using System.Diagnostics;
using System.IO;


Console.WriteLine("Hola, WSL2😆");

/*
Console.WriteLine("Quantities:");
HumanizeQuantities();

Console.WriteLine("\nDate-Time Maniplation:");
HumanizeDates();


static void HumanizeQuantities() {
   Console.WriteLine("case".ToQuantity(0));
   Console.WriteLine("case".ToQuantity(1));
   Console.WriteLine("case".ToQuantity(5));
}
static void HumanizeDates() {
   Console.WriteLine(DateTime.UtcNow.AddHours(-24).Humanize());
   Console.WriteLine(DateTime.UtcNow.AddHours(2).Humanize());
   Console.WriteLine(TimeSpan.FromDays(1).Humanize());
   Console.WriteLine(TimeSpan.FromDays(16).Humanize());
}
*/

/*
int result = fibonacci(6);
Console.WriteLine(result);
// Console.ReadKey(true);

static int fibonacci(int n) {
    Debug.WriteLine($"Entering {nameof(fibonacci)} method");
    Debug.WriteLine($"we are looking for the {n}th number");
    int n1 = 0;
    int n2 = 1;
    int sum = 0;

    for (int i = 2; i <= n; i++) {
        sum = n1 + n2;
        n1 = n2;
        n2 = sum;
        Debug.WriteLineIf(sum == 5, $"sum is {sum}, n1 is {n1}, n2 is {n2}");
    }
    //if n2 is 5 then continue, else break.
    Debug.Assert(n2 == 5, "The return value is not 5 while it should be.");
    return n == 0 ? n1 : n2;
}

Console.WriteLine("This message is readable by the end user.");
Trace.WriteLine("This is a trace message when tracing the app.");
Debug.WriteLine("This is a debug message just for developers.");

Debug.Write("Debug - ");
Debug.WriteLine("This is a full line.");
Debug.WriteLine("This is another full line.");
*/

/*
//directories
IEnumerable<string> list_of_directories = Directory.EnumerateDirectories("../stores");
foreach (var dir in list_of_directories) {
    Console.WriteLine(dir);
}

//files
IEnumerable<string> files = Directory.EnumerateFiles("../stores", "*.json", SearchOption.TopDirectoryOnly);
foreach (var file in files) {
    Console.WriteLine(file);
}

//all files in all subdirectories
IEnumerable<string> all_files_in_all_folders = Directory.EnumerateFiles("../stores", "*.json", SearchOption.AllDirectories);
foreach (var file in all_files_in_all_folders) {
    Console.WriteLine(file);
}
*/

//Console.WriteLine(Directory.GetCurrentDirectory());
//Console.WriteLine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
//Console.WriteLine($"stores{Path.DirectorySeparatorChar}201");
//Console.WriteLine(Path.Combine("stores","201","2011"));
//Console.WriteLine(Path.GetExtension("stores.json"));

/*
string file_name = $"../stores{Path.DirectorySeparatorChar}201{Path.DirectorySeparatorChar}sales.json";
FileInfo info = new FileInfo(file_name);
Console.WriteLine($"name: {info.Name}");
Console.WriteLine($"full name: {info.FullName}");
Console.WriteLine($"extension: {info.Extension}");
Console.WriteLine($"directory: {info.Directory}");
Console.WriteLine($"directory name: {info.DirectoryName}");
Console.WriteLine($"create time: {info.CreationTime}");
Console.WriteLine($"create time UTC: {info.CreationTimeUtc}");
Console.WriteLine($"last access time: {info.LastAccessTime}");
Console.WriteLine($"last access time UTC: {info.LastAccessTimeUtc}");
Console.WriteLine($"last write time: {info.LastWriteTime}");
Console.WriteLine($"last write time UTC: {info.LastWriteTimeUtc}");
Console.WriteLine($"attributes: {info.Attributes}");
Console.WriteLine($"is exist: {info.Exists}");
Console.WriteLine($"is read only: {info.IsReadOnly}");
Console.WriteLine($"length: {info.Length}");
Console.WriteLine($"link target: {info.LinkTarget}");
*/

var current_directory = Directory.GetCurrentDirectory();
var stores_directory = Path.Combine(current_directory, "../stores");
var salesFiles = find_files(stores_directory);

foreach (var file in salesFiles){
    Console.WriteLine(file);
}

IEnumerable<string> find_files(string folderName) {
    List<string> salesFiles = new List<string>();
    var foundFiles = Directory.EnumerateFiles(folderName, "*", SearchOption.AllDirectories);
    foreach (var file in foundFiles){
        salesFiles.Add(file);
    }
    return salesFiles;
}