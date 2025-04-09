

/**
 * Created by mgreen14 on 12/27/17.
 */
 
 namespace AnimalsApp   
 {
    
 


public class Teacher : Talkable {
    private int age;
    private String name;

    public Teacher(int age, String name) {
        this.name = name;
        this.age = age;
    }

    public int getAge() {
        return age;
    }

    public void setAge(int age) {
        this.age = age;
    }

    public String GetName() {
        return name;
    }
    public String Talk() {
        return "Don't forget to do the assigned reading!";
    }
}

 }