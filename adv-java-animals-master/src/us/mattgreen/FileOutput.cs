

using System;
using System.IO;

/**
 * Created by mgreen14 on 12/27/17.
 */
namespace AnimalsApp {
public class FileOutput {

    private StreamWriter writer;
    private String fileName;

    public FileOutput(String fileName) {
        this.fileName = fileName;
        try {
            writer = new StreamWriter(fileName);
        } catch (Exception e) {
            Console.WriteLine("File Open Error: " + fileName + " " + e);
        }
    }

    public void Write(String line) {
        try {
            writer.WriteLine(line);
        } catch (Exception e) {
            Console.WriteLine("File Write Error: " + fileName + " " + e);
        }
    }

    public void Close() {
      
            try {
                writer.Close();
            } catch (Exception e) {
                Console.WriteLine($"File Close Error: {e.Message}");
            }
        

    }
}
}