import java.util.Random;

public class BankAccount {
    private int id;
    private double balance;

    public BankAccount() {
        this.id = new Random().nextInt() ;
        this.balance = 0;
    }

    public int getId() {
        return id;
    }

    public double getBalance() {
        return balance;
    }


    public void deposit(double amount) {
        this.balance += amount;
    }

    public void withdraw(double amount) {
        if (this.balance < amount) {
            throw new IllegalStateException("Insufficient balance");
        }
        else
            this.balance -= amount;
    }

    @Override
    public String toString() {
        return "BankAccountID" + this.id;
    }
}
