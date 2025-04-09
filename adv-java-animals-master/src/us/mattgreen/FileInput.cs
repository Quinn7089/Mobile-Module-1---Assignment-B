


using System;
using System.IO;

/**
 * Created by mgreen14 on 12/27/17.
 */
namespace AnimalsApp {

public class FileInput {

  private StreamReader reader;
    private String fileName;

    public FileInput(String fileName) {
        this.fileName = fileName;
        try {
            reader = new StreamReader(fileName);
        } catch (Exception e) {
            Console.WriteLine($"File Open Error:  {fileName} {e.Message}");
        }
    }

    public void Read() {
        String line;
        try {
            while ((line = ReadLine()) != null) {
                Console.WriteLine(line);
            }
        } catch (Exception e) {
            Console.WriteLine($"File Write Error:  {e.Message} " );
        }
    }

    public String ReadLine() {
        try {
            return reader.ReadLine();
        } catch (Exception e) {
            Console.WriteLine($"File Write Error: {e.Message}");
            return null;
            
        }
    }

    public void Close() {
       
            try {
                reader?.Close();

            } catch (Exception e) {
                Console.WriteLine($"File Close Error: {e.Message}");
            }
        }

    
}
}