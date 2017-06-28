import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Team team = new Team("FTW");
        Scanner scanner = new Scanner(System.in);
        Integer teamMembers = 2;
        System.out.println("Enter (firstName lastName age salary) for " + teamMembers + " members");
        for (int i = 0; i < teamMembers; i++) {
            team.addPersonToMainTeam(new Person(scanner.next(), scanner.next(), scanner.nextInt(), scanner.nextDouble()));
        }
        System.out.println(team);
        for (Person person: team.getMainTeam()) {
            System.out.println(person);
        }
    }
}
