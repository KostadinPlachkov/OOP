import Animals.Puppy;
import RandomArrayList.RandomArrayList;


public class Main {
    public static void main(String[] args) {
        Puppy puppy = new Puppy();
        puppy.weep();
        puppy.eat();

        RandomArrayList randomArrayList = new RandomArrayList();
        randomArrayList.add(1);
        randomArrayList.add("array");
        randomArrayList.add(8);
        randomArrayList.add(96);

        System.out.println(randomArrayList.getRandomElement());
        System.out.println(randomArrayList.getRandomElement());
        System.out.println(randomArrayList.getRandomElement());
        System.out.println(randomArrayList.getRandomElement());
    }
}
