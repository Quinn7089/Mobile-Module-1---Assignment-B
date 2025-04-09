


/**
 * Created by mgreen14 on 12/27/17.
 */

namespace AnimalsApp {

public class Dog : Talkable {
    private bool friendly;
    private String name;

    public Dog(bool friendly, string name) {
        this.friendly = friendly;
        this.name = name;
    }

    public bool isFriendly() {
        return friendly;
    }

   
    public string Talk() {
        return "Bark";
    }

    public string GetName() {
        return name;
    }

    public string toString() {
        return $"Dog: name={name},  friendly={friendly}";
    }


}

}