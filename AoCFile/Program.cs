using System.Collections;

namespace AoCFile;

public class AoCFile
{
    private ArrayList alFile;
    
    public AoCFile()
    {
        alFile = new ArrayList();
        alFile = readFile("Input.txt");
    }

    public AoCFile(string path)
    {
        alFile = new ArrayList();
        alFile = readFile(path);
    }

    private ArrayList readFile(string path)
    {
        ArrayList al = new ArrayList();
        String line;

        StreamReader sr = new StreamReader(path);
        line = sr.ReadLine();
        while (line != null)
        {
            al.Add(line);
            line = sr.ReadLine();
        }
        sr.Close();

        return al;
    }
    
    public ArrayList getAoCFile() { return alFile; }
}