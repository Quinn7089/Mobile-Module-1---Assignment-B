

/**
 * Created by mgreen14 on 12/28/17.
 */

namespace AnimalsApp
{
    


public class Cat : Talkable {
    private int mousesKilled;
    private string name;

    public Cat(int mousesKilled, String name) {
        this.name = name;
        this.mousesKilled = mousesKilled;
    }

    public int getMousesKilled() {
        return mousesKilled;
    }

    public void addMouse() {
        mousesKilled++;
    }

    public String Talk() {
        return "Meow";
    }
    public String GetName() {
        return name;
    }
    public String toString() {
        return "Cat: " + "name=" + name + " mousesKilled=" + mousesKilled;
    }
}

}