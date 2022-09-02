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
        string[] SubDirs =Directory.GetDirectories(dir);
        foreach (string file in files)
        {
            Console.WriteLine(file);
         
        }
        foreach (string subdir in SubDirs)
        {
            Console.WriteLine(subdir);
            string[] subfiles = Directory.GetFiles(subdir);
            Console.WriteLine(subfiles);

        }
    }
}


void DisplayAllFolders(string folder, bool displayFiles = false)
{
    string[] folders = Directory.GetDirectories(folder);
    foreach(string f in folders)
    {
        Console.WriteLine(f);
        if (displayFiles)
            DisplayAllFilesInFolder(f);
        DisplayAllFolders(f);

    }
}

void DisplayAllFilesInFolder(string folder)
{
    string[] files = Directory.GetFiles(folder);
    foreach(string file in files)
    {
        Console.WriteLine(file);
        
    }
}

//FilePath(@"C:\repos");
DisplayAllFolders(@"C:\repos", true);


//Recursive call to look into the folder when you give the folder name

//List<string> myrepos = new();



//C:\repos   the files path to my repos


// foreach folder call upon their folders