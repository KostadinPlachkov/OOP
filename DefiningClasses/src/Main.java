

public class Main {
    public static void main(String[] args) {
        BankAccount bankAccount = new BankAccount();
        bankAccount.deposit(85);
        bankAccount.withdraw(10);
        System.out.println("Balance for client " + bankAccount.toString() + ": " + bankAccount.getBalance());
      }
}
