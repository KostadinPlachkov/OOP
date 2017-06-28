import java.util.ArrayList;
import java.util.Collections;
import java.util.List;

public class Team {
    private String name;
    private List<Person> mainTeam;
    private List<Person> reserveTeam;

    public Team(String name) {
        this.name = name;
        this.mainTeam = new ArrayList<>();
        this.reserveTeam = new ArrayList<>();
    }

    public Team(String name, List<Person> mainTeam, List<Person> reserveTeam) {
        this.name = name;
        this.mainTeam = mainTeam;
        this.reserveTeam = reserveTeam;
    }

    private String getName() {
        return name;
    }

    private void setName(String name) {
        this.name = name;
    }

    public List<Person> getMainTeam() {
        return Collections.unmodifiableList(this.mainTeam);
    }

    public void addPersonToMainTeam(Person person) {
        this.mainTeam.add(person);
    }

    public List<Person> getReserveTeam() {
        return Collections.unmodifiableList(this.reserveTeam);
    }

    public void addPersonToReserveTeam(Person person) {
        this.reserveTeam.add(person);
    }

    @Override
    public String toString() {
        return "Team name:" + this.getName();
    }
}
