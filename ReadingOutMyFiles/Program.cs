using System.Security.AccessControl;

string FileName = @"C:\repos";

//This works
void  FilePath(string FileName)
{
string repos = FileName;
string[] dirs = Directory.GetDirectories(repos);
    foreach (string dir in dirs)
    {
        Console.WriteLine(dir);
        string[] files = Directory.GetFiles(dir);
        foreach (string file in files)
        {
            Console.WriteLine(file);
            //FilePath(file);
        }
    }
}


FilePath(@"C:\repos");
FilePath(@"C: \Users\max - s\Desktop");

//Recursive call to look into the folder when you give the folder name

//List<string> myrepos = new();



//C:\repos   the files path to my repos


// foreach folder call upon their folders