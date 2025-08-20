// See https://aka.ms/new-console-template for more information
const string filename = "result.txt";
const string dirpath = "FileCollection";
const string excel_ext = ".xlsx";
const string word_ext = ".docx";
const string ppt_ext = ".pptx";

int total_files;
float total_size = 0;
int excel_count = 0;
float excel_size = 0;
int word_count = 0;
float word_size = 0;
int ppt_count = 0;
float ppt_size = 0;

// TODO: Enumerate the contents of directories
List<string> files = new List<string>(Directory.EnumerateFileSystemEntries(dirpath));
// TODO: Get number of total files
total_files = files.Count;
// TODO: Loop through and get number of each file type and size
foreach (string fn in files)
{
    try
    {
        FileInfo fi = new FileInfo(fn);
        string extension = fi.Extension;
        float length = fi.Length;

        total_size += length;

        if (extension.Equals(excel_ext))
        {
            excel_count += 1;
            excel_size += length;
        }
        else if (extension.Equals(word_ext))
        {
            word_count += 1;
            word_size += length;
        }
        else if (extension.Equals(ppt_ext))
        {
            ppt_count += 1;
            ppt_size += length;
        }
    }
    catch (Exception e)
    {
        Console.WriteLine($"Exception: {e}");
    }
}

// TODO: Create result text file
if (filename.Exists(filename)) {
    filename.Delete(filename);
}
using (StreamWriter sw = File.CreateText(filename))
{
    sw.WriteLine("~~~~ Results ~~~~");
    sw.WriteLine($"Total Files: {total_files}");
    sw.WriteLine($"Excel Count: {excel_count}");
    sw.WriteLine($"Word Count: {word_count}");
    sw.WriteLine($"PowerPoint Count: {ppt_count}");

    sw.WriteLine("----");
    sw.WriteLine($"Total Size: {total_size:N0}");
    sw.WriteLine($"Excel Size: {excel_size:N0}");
    sw.WriteLine($"Word Size: {word_size:N0}");
    sw.WriteLine($"PowerPoint Size: {ppt_size:N0}");
}